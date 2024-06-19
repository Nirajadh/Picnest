Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Windows.Media.Imaging
Imports AForge.Imaging.Filters


Public Class edit1
    Inherits UserControl
    Private originalImage As Bitmap
    Private editedImage As Bitmap
    Private croppedImage As Bitmap
    Private croppedtempImage As Bitmap
    Private filteredImage As Bitmap
    Private filtersbtnimage As Bitmap
    Private adjustedImage As Bitmap
    Private adjustedtempImage As Bitmap
    ' Use croppedImage instead of editedImage for cropping
    Private isCropping As Boolean = False
    Private cropStartPoint As Point
    Private cropEndPoint As Point
    Private currentRotation As RotateFlipType = RotateFlipType.RotateNoneFlipNone
    Private db As New sqlcontrol()

    Public Sub New()
        InitializeComponent()
        If Imageedit IsNot Nothing Then
            originalImage = Imageedit
            editedImage = ConvertTo24bppRgb(originalImage).Clone()
            adjustedtempImage = editedImage.Clone()
            PictureBox1.Image = editedImage
            Guna2PictureBox1.Visible = False
            filterbtn.PerformClick()

        End If

    End Sub

    Private Sub editpb_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick, Guna2PictureBox1.Click
        If Imageedit IsNot Nothing Then


        Else

            Using openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
                If openFileDialog.ShowDialog = DialogResult.OK Then
                    originalImage = CType(Image.FromFile(openFileDialog.FileName), Bitmap)
                    editedImage = ConvertTo24bppRgb(originalImage).Clone()
                    adjustedtempImage = editedImage.Clone()
                    PictureBox1.Image = editedImage

                End If
            End Using

        End If
        Guna2PictureBox1.Visible = False
    End Sub
    Private Sub Guna2PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles Guna2PictureBox1.DoubleClick
        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog = DialogResult.OK Then
                originalImage = CType(Image.FromFile(openFileDialog.FileName), Bitmap)
                editedImage = ConvertTo24bppRgb(originalImage).Clone()
                PictureBox1.Image = editedImage
            End If


        End Using
        Guna2PictureBox1.Visible = False
    End Sub

    Private Function ConvertTo24bppRgb(img As Bitmap) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height, PixelFormat.Format24bppRgb)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height))
        End Using
        Return bmp
    End Function

    Private Function GetEncoder(format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()
        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next
        Return Nothing
    End Function
    'filter
    Private Sub filterbtn_Click(sender As Object, e As EventArgs) Handles filterbtn.Click

        If PictureBox1.Image IsNot Nothing Then
            panelcrop.Visible = False
            paneladjust.Visible = False
            panelfilters.Visible = True
            pnlupload.Visible = False
            PictureBox1.Image = editedImage
            filteredImage = PictureBox1.Image
            Dim sepiaFilter As New Sepia()
            Dim grayscaleFilter As New Grayscale(0.2125, 0.7154, 0.0721)
            Dim sharpenFilter As New Sharpen()
            Dim gaussianBlurFilter As New GaussianBlur(4.0, 7)
            Dim invertFilter As New Invert()
            filtersbtnimage = sepiaFilter.Apply(editedImage)
            btnfiltersepia.Image = filtersbtnimage
            filtersbtnimage = grayscaleFilter.Apply(editedImage)
            btnfiltergray.Image = filtersbtnimage
            filtersbtnimage = gaussianBlurFilter.Apply(editedImage)
            btnfilterblur.Image = filtersbtnimage
            filtersbtnimage = invertFilter.Apply(editedImage)
            btnfilterinvert.Image = filtersbtnimage
            filtersbtnimage = sharpenFilter.Apply(editedImage)
            btnfiltersharpen.Image = filtersbtnimage
        End If
    End Sub
    Private Sub btnfiltergray_Click(sender As Object, e As EventArgs) Handles btnfiltergray.Click
        If editedImage IsNot Nothing Then
            Try

                Dim grayscaleFilter As New Grayscale(0.2125, 0.7154, 0.0721)
                filteredImage = grayscaleFilter.Apply(editedImage)
                PictureBox1.Image = filteredImage
            Catch ex As Exception
                MessageBox.Show("Error applying grayscale filter: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnfilterinvert_Click(sender As Object, e As EventArgs) Handles btnfilterinvert.Click
        If editedImage IsNot Nothing Then
            Try
                Dim invertFilter As New Invert()
                filteredImage = invertFilter.Apply(editedImage)
                PictureBox1.Image = filteredImage
            Catch ex As Exception
                MessageBox.Show("Error applying invert filter: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnfiltersharpen_Click(sender As Object, e As EventArgs) Handles btnfiltersharpen.Click
        If editedImage IsNot Nothing Then
            Try
                Dim sharpenFilter As New Sharpen()
                filteredImage = sharpenFilter.Apply(editedImage)
                PictureBox1.Image = filteredImage
            Catch ex As Exception
                MessageBox.Show("Error applying sharpen filter: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnfilterblur_Click(sender As Object, e As EventArgs) Handles btnfilterblur.Click
        If editedImage IsNot Nothing Then
            Try
                Dim gaussianBlurFilter As New GaussianBlur(4.0, 7)
                filteredImage = gaussianBlurFilter.Apply(editedImage)
                PictureBox1.Image = filteredImage
            Catch ex As Exception
                MessageBox.Show("Error applying blur filter: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnfiltersepia_Click(sender As Object, e As EventArgs) Handles btnfiltersepia.Click


        If filteredImage IsNot Nothing Then
            Try
                Dim sepiaFilter As New Sepia()
                Dim a As New Invert
                filteredImage = sepiaFilter.Apply(editedImage)
                PictureBox1.Image = filteredImage
            Catch ex As Exception
                MessageBox.Show("Error applying sepia filter: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        editedImage = filteredImage.Clone()
    End Sub

    Private Sub btnfilterrevert_Click(sender As Object, e As EventArgs) Handles btnfilterrevert.Click
        PictureBox1.Image = editedImage
        filteredImage = editedImage.Clone()

    End Sub
    'filter end

    'crop
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If originalImage IsNot Nothing AndAlso e.Button = MouseButtons.Left AndAlso btncropopen.Checked = True AndAlso btncrop.Checked = True Then
            isCropping = True
            cropStartPoint = e.Location
        End If
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If isCropping Then
            cropEndPoint = e.Location
            PictureBox1.Invalidate() ' Invalidate to show selection rectangle
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If isCropping Then
            croppedtempImage = croppedImage.Clone()
            CropImage(cropStartPoint, cropEndPoint)
            isCropping = False
        End If
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If isCropping Then
            Dim cropRect As New Rectangle(
                Math.Min(cropStartPoint.X, cropEndPoint.X),
                Math.Min(cropStartPoint.Y, cropEndPoint.Y),
                Math.Abs(cropStartPoint.X - cropEndPoint.X),
                Math.Abs(cropStartPoint.Y - cropEndPoint.Y)
            )

            e.Graphics.DrawRectangle(Pens.WhiteSmoke, cropRect) ' Draw selection rectangle
        End If
    End Sub
    Private Sub btncropopen_Click(sender As Object, e As EventArgs) Handles btncropopen.Click
        If PictureBox1.Image IsNot Nothing Then
            panelfilters.Visible = False
            paneladjust.Visible = False
            pnlupload.Visible = False
            panelcrop.Visible = True



            PictureBox1.Image = editedImage
            croppedImage = editedImage.Clone()
        End If

    End Sub



    Private Sub btnrotateright_Click(sender As Object, e As EventArgs) Handles btnrotateright.Click
        btncrop.Checked = False
        If editedImage IsNot Nothing Then
            croppedImage.RotateFlip(RotateFlipType.Rotate90FlipNone)


            PictureBox1.Image = croppedImage
        End If
    End Sub
    Private Sub CropImage(startPoint As Point, endPoint As Point)
        ' Adjust coordinates if the image size is smaller than the picture box size
        Dim scaleX As Double = croppedImage.Width / PictureBox1.Width
        Dim scaleY As Double = croppedImage.Height / PictureBox1.Height

        startPoint.X = CInt(startPoint.X * scaleX)
        startPoint.Y = CInt(startPoint.Y * scaleY)
        endPoint.X = CInt(endPoint.X * scaleX)
        endPoint.Y = CInt(endPoint.Y * scaleY)

        Dim cropRect As New Rectangle(
        Math.Min(startPoint.X, endPoint.X),
        Math.Min(startPoint.Y, endPoint.Y),
        Math.Abs(startPoint.X - endPoint.X),
        Math.Abs(startPoint.Y - endPoint.Y)
    )

        If cropRect.Width > 0 AndAlso cropRect.Height > 0 Then
            croppedImage = New Bitmap(cropRect.Width, cropRect.Height)
            Using g As Graphics = Graphics.FromImage(croppedImage)
                g.DrawImage(croppedtempImage, New Rectangle(0, 0, cropRect.Width, cropRect.Height), cropRect, GraphicsUnit.Pixel)
            End Using
            croppedImage = ConvertTo24bppRgb(croppedImage)
        End If
        PictureBox1.Image = croppedImage
    End Sub


    Private Sub btncropapply_Click(sender As Object, e As EventArgs) Handles btncropapply.Click
        isCropping = False
        editedImage = croppedImage.Clone

    End Sub
    Private Sub btncroprevert_Click(sender As Object, e As EventArgs) Handles btncroprevert.Click
        editedImage.RotateFlip(RotateFlipType.RotateNoneFlipNone)

        PictureBox1.Image = editedImage

        croppedImage = editedImage.Clone()


    End Sub
    Private Sub btncrop_Click(sender As Object, e As EventArgs) Handles btncrop.Click
        If btncrop.Checked = False Then
            btncrop.Checked = True
        Else
            btncrop.Checked = False
        End If

    End Sub


    Private Sub btncropopen_Leave(sender As Object, e As EventArgs) Handles btncropopen.Leave
        editedImage = PictureBox1.Image
    End Sub

    'endcrop


    'adjust
    Private Sub btnadjust_Click(sender As Object, e As EventArgs) Handles btnadjust.Click
        If PictureBox1.Image IsNot Nothing Then
            panelfilters.Visible = False
            panelcrop.Visible = False
            pnlupload.Visible = False
            paneladjust.Visible = True

            PictureBox1.Image = editedImage
            adjustedImage = PictureBox1.Image
            adjustedtempImage = PictureBox1.Image
            trackbardefault()
        End If

    End Sub

    Private Sub trackbarbrightness_ValueChanged(sender As Object, e As EventArgs) Handles trackbarbrightness.ValueChanged


        If editedImage IsNot Nothing Then
            Dim brightnessValue = trackbarbrightness.Value
            ApplyBrightness(brightnessValue)
        End If

    End Sub

    Private Sub ApplyBrightness(brightnessValue As Integer)
        Try

            Dim brightnessFilter As New BrightnessCorrection(brightnessValue)


            adjustedImage = brightnessFilter.Apply(adjustedtempImage)
            PictureBox1.Image = adjustedImage
        Catch ex As Exception
            MessageBox.Show("Error applying brightness adjustment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnadjustapply_Click(sender As Object, e As EventArgs) Handles btnadjustapply.Click
        editedImage = adjustedImage.Clone
    End Sub

    Private Sub btnadjustrevert_Click(sender As Object, e As EventArgs) Handles btnadjustrevert.Click
        PictureBox1.Image = editedImage
        adjustedImage = editedImage.Clone
        adjustedtempImage = editedImage.Clone
        trackbardefault()

    End Sub
    'adjust end
    Private Sub trackbardefault()
        trackbarbrightness.Value = 0
        trackbarcontrast.Value = 0
        trackbarsaturation.Value = 0
    End Sub


    'save
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        panelcrop.Visible = False
        paneladjust.Visible = False
        panelfilters.Visible = False
        pnlupload.Visible = True
        captiontxtbox.Visible = True
        uploadbtn.Visible = False
        saveconfirmbtn.Visible = True


    End Sub

    Private Sub trackbarcontrast_ValueChanged(sender As Object, e As EventArgs) Handles trackbarcontrast.ValueChanged
        If editedImage IsNot Nothing Then
            Dim contrastValue As Single = trackbarcontrast.Value
            ApplyContrast(contrastValue)
        End If
    End Sub
    Private Sub trackbarsaturation_ValueChanged(sender As Object, e As EventArgs) Handles trackbarsaturation.ValueChanged
        If editedImage IsNot Nothing Then
            Dim saturationValue = MapSaturationValue(trackbarsaturation.Value)
            ApplySaturation(saturationValue)
        End If
    End Sub
    Private Function MapSaturationValue(trackbarValue As Integer) As Single
        ' Assuming the trackbar ranges from -100 to 100
        ' Map -100 to 0, 0 to 1, and 100 to 2
        Return (trackbarValue + 1) / 100.0F
    End Function
    Private Sub ApplyContrast(contrastValue As Single)
        Try

            Dim contrastFilter As New ContrastCorrection(contrastValue)
            adjustedImage = contrastFilter.Apply(adjustedtempImage)
            PictureBox1.Image = adjustedImage
        Catch ex As Exception
            MessageBox.Show("Error applying contrast adjustment: " & ex.Message)
        End Try
    End Sub
    Private Sub ApplySaturation(saturationValue As Single)
        Try

            Dim saturationFilter As New SaturationCorrection(saturationValue)
            adjustedImage = saturationFilter.Apply(adjustedtempImage)
            PictureBox1.Image = adjustedImage
        Catch ex As Exception
            MessageBox.Show("Error applying saturation adjustment: " & ex.Message)
        End Try
    End Sub




    Private Sub trackbarbrightness_Leave(sender As Object, e As EventArgs) Handles trackbarbrightness.Leave
        adjustedtempImage = adjustedImage.Clone
    End Sub

    Private Sub trackbarcontrast_Leave(sender As Object, e As EventArgs) Handles trackbarcontrast.Leave
        adjustedtempImage = adjustedImage.Clone
    End Sub



    Private Sub trackbarsaturation_Leave(sender As Object, e As EventArgs) Handles trackbarsaturation.Leave
        adjustedtempImage = adjustedImage.Clone
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        If PictureBox1.Image IsNot Nothing Then
            trackbardefault()
            editedImage = ConvertTo24bppRgb(originalImage).Clone()
            PictureBox1.Image = editedImage.Clone()
        End If
    End Sub





    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles uploadbtn.Click


        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog = DialogResult.OK Then
                originalImage = CType(Image.FromFile(openFileDialog.FileName), Bitmap)
                editedImage = ConvertTo24bppRgb(originalImage).Clone()
                adjustedtempImage = editedImage.Clone()
                PictureBox1.Image = editedImage
                filterbtn.PerformClick()

            End If
        End Using


        Guna2PictureBox1.Visible = False
    End Sub


    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles saveconfirmbtn.Click
        If editedImage IsNot Nothing Then
            Try



                Using ms As New MemoryStream()
                    Dim codecInfo As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)
                    Dim encoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
                    Dim encoderParams As New EncoderParameters(1)
                    encoderParams.Param(0) = New EncoderParameter(encoder, 100L)

                    editedImage.Save(ms, codecInfo, encoderParams)
                    Dim imageData As Byte() = ms.ToArray()

                    db.AddParam("@UserID", Convert.ToInt32(userid))
                    db.AddParam("@ImageData", imageData)
                    db.AddParam("@Caption", captiontxtbox.Text)
                    db.AddParam("@UploadDate", DateTime.Now)
                    db.AddParam("@UploadID", useruploadid)
                    If updatecheck = False Then

                        db.ExecQuery("INSERT INTO UserUploads (UserID, ImageData, Caption, UploadDate) VALUES (@UserID, @ImageData, @Caption, @UploadDate)")
                    Else
                        db.ExecQuery("UPDATE UserUploads SET UserID=@UserID,ImageData=@ImageData,UploadDate=@UploadDate,Caption = @Caption WHERE UploadID = @UploadID")
                    End If
                    If db.HasException(True) Then Exit Sub
                    ''''1
                    MessageBox.Show("Image uploaded successfully!")
                    Form3.btngallery.PerformClick()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error saving image: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select an image")
        End If
    End Sub

    Private Sub captiontxtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles captiontxtbox.KeyDown
        If e.KeyValue = Keys.Enter Then
            saveconfirmbtn.PerformClick()

        End If

    End Sub
End Class


