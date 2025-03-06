Imports System.IO

Public Class frmWordProcessor


    Private Sub MyLoading() Handles Me.Load
        Try

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub LoadUserManual()

        RibbonControl1.Minimized = True

        Dim Source As String = Application.StartupPath & "\General Sales Manager User Manual.docx"

        RichEditControl1.Document.OpenXmlBytes() = GetByteData(Source)
        RichEditControl1.ReadOnly = True


    End Sub

    Private Function GetByteData(ByVal FilePath As String) As Byte()
        Try

            If FilePath.ToCharArray.Count > 0 Then

                Dim fInfo As New FileInfo(FilePath)
                Dim numBytes As Long = fInfo.Length
                Dim fStream As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
                Dim br As New BinaryReader(fStream)
                Dim data As Byte() = br.ReadBytes(CInt(numBytes))
                br.Close()
                fStream.Close()

                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function


End Class
