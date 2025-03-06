Imports DevExpress.XtraEditors.Controls

Public Class frmViewImage

    Public AccRecordID As String


    Private Sub MyLoading() Handles Me.Load

        ImagePictureBox.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True
        ImagePictureBox.Properties.ShowScrollBars = True
        ImagePictureBox.Properties.ShowMenu = True

    End Sub


    Private Sub BarButtonItemRotate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRotate.ItemClick
        ImagePictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        ImagePictureBox.Refresh()
        'ImagePictureBox.Enabled = False
        'Me.ProgressPanel1.Visible = True

    End Sub


    Private Sub BarButtonItemFlipHorizontal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemFlipHorizontal.ItemClick
        ImagePictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        ImagePictureBox.Refresh()
        'ImagePictureBox.Enabled = False
        'Me.ProgressPanel1.Visible = True

    End Sub


    Private Sub BarButtonItemFlipVertical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemFlipVertical.ItemClick
        ImagePictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        ImagePictureBox.Refresh()
        'ImagePictureBox.Enabled = False
        'Me.ProgressPanel1.Visible = True

    End Sub


    Private Sub BarButtonItemDownload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDownload.ItemClick
        Try

            Dim FSD As New SaveFileDialog
            FSD.FileName = BarStaticItemName.Caption
            FSD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

            Dim TheFilter As String = "Image|*.jpeg"
            FSD.Filter = TheFilter

            FSD.AddExtension = False

            Dim MyMemoryStream As New System.IO.MemoryStream()
            ImagePictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            If FSD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(FSD.FileName, MyMemoryStream.ToArray, False)
                MessageBox.Show("File is Successfully Downloaded.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BarEditItemZoom_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemZoom.EditValueChanged
        'ImagePictureBox.Properties.ZoomPercent = BarEditItemZoom.EditValue
        'BarStaticItemZoomLevel.Caption = BarEditItemZoom.EditValue & "%"

    End Sub


    Private Sub ImagePictureBox_ImageChanged(sender As Object, e As EventArgs) Handles ImagePictureBox.ImageChanged
        ImagePictureBox.Enabled = True
        Me.ProgressPanel1.Visible = False

    End Sub


    Private Sub ImagePictureBox_Invalidated(sender As Object, e As InvalidateEventArgs) Handles ImagePictureBox.Invalidated
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_EditValueChanged(sender As Object, e As EventArgs) Handles ImagePictureBox.EditValueChanged
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_BackgroundImageChanged(sender As Object, e As EventArgs) Handles ImagePictureBox.BackgroundImageChanged
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_LoadCompleted(sender As Object, e As EventArgs) Handles ImagePictureBox.LoadCompleted
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_Modified(sender As Object, e As EventArgs) Handles ImagePictureBox.Modified
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_Validated(sender As Object, e As EventArgs) Handles ImagePictureBox.Validated
        Dim triggered As String = "True"

    End Sub


    Private Sub ImagePictureBox_ZoomPercentChanged(sender As Object, e As EventArgs) Handles ImagePictureBox.ZoomPercentChanged
        BarStaticItemZoomLevel.Caption = ImagePictureBox.Properties.ZoomPercent.ToString("N0") & "%"

    End Sub

End Class
