Imports System
Imports System.Windows.Forms
Imports Leadtools

Public NotInheritable Class Messager
   Private Shared _caption As String

   Private Sub New()
   End Sub

   Public Shared Property Caption() As String
      Get
         Return _caption
      End Get
      Set(value As String)
         _caption = value
      End Set
   End Property

   Public Shared Sub ShowError(ByVal owner As IWin32Window, ByVal ex As Exception)
      Dim message As String = ex.Message
      message = CheckIfSupportError(ex, False)
      Show(owner, message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
   End Sub

   Public Shared Sub ShowError(ByVal owner As IWin32Window, ByVal message As String)
      Show(owner, message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
   End Sub

   Public Shared Sub ShowWarning(ByVal owner As IWin32Window, ByVal ex As Exception)
      Dim message As String = ex.Message
      message = CheckIfSupportError(ex, False)
      Show(owner, message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
   End Sub

   Public Shared Sub ShowWarning(ByVal owner As IWin32Window, ByVal message As String)
      Show(owner, message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
   End Sub

   Public Shared Function ShowQuestion(ByVal owner As IWin32Window, ByVal message As String, ByVal buttons As MessageBoxButtons) As DialogResult
      Return Show(owner, message, MessageBoxIcon.Question, buttons)
   End Function

   Public Shared Function ShowQuestion(ByVal owner As IWin32Window, ByVal message As String, ByVal icon As MessageBoxIcon, ByVal buttons As MessageBoxButtons) As DialogResult
      Return Show(owner, message, icon, buttons)
   End Function

   Public Shared Sub ShowInformation(ByVal owner As IWin32Window, ByVal message As String)
      Show(owner, message, MessageBoxIcon.Information, MessageBoxButtons.OK)
   End Sub

   Public Shared Sub Show(ByVal owner As IWin32Window, ByVal ex As Exception, ByVal icon As MessageBoxIcon)
      Dim message As String = ex.Message
      message = CheckIfSupportError(ex, False)
      Show(owner, message, icon, MessageBoxButtons.OK)
   End Sub

   Private Const _fileOpenErrorMessage As String = "Error opening file:"
   Private Const _fileSaveErrorMessage As String = "Error saving file:"

   Public Shared Sub ShowFileOpenError(ByVal owner As IWin32Window, ByVal fileName As String, ByVal ex As Exception)
      Dim message As String = ex.Message
      message = CheckIfSupportError(ex, False)
      If fileName IsNot Nothing AndAlso fileName <> String.Empty Then
         If ex IsNot Nothing Then
            Show(owner, String.Format("{0}{2}{1}{2}{2}{3}", _fileOpenErrorMessage, fileName, Environment.NewLine, message), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
         Else
            Show(owner, String.Format("{0}{1}", _fileOpenErrorMessage, fileName), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
         End If
      Else
         If ex IsNot Nothing Then
            Show(owner, String.Format("{0}{1}{1}{2}", _fileOpenErrorMessage, Environment.NewLine, message), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
         Else
            Show(owner, _fileOpenErrorMessage, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
         End If
      End If
   End Sub

   Public Shared Sub ShowFileSaveError(ByVal owner As IWin32Window, ByVal fileName As String, ByVal ex As Exception)
      Dim message As String = ex.Message
      message = CheckIfSupportError(ex, False)
      If fileName IsNot Nothing AndAlso fileName <> String.Empty Then
         If ex IsNot Nothing Then
            ShowError(owner, String.Format("{0}{2}{1}{2}{2}{3}", _fileSaveErrorMessage, fileName, Environment.NewLine, message))
         Else
            ShowError(owner, String.Format("{0}{1}", _fileSaveErrorMessage, fileName))
         End If
      Else
         If ex IsNot Nothing Then
            ShowError(owner, String.Format("{0}{1}{1}{2}", _fileSaveErrorMessage, Environment.NewLine, message))
         Else
            ShowError(owner, _fileSaveErrorMessage)
         End If
      End If
   End Sub

   Public Shared Function CheckIfSupportError(ByVal ex As Exception, ByVal ignoreIfNotSupportError As Boolean) As String
      Dim message As String = ex.Message

      If ex.GetType() IsNot GetType(RasterException) Then
         Return ex.Message
      End If

      Dim rex As RasterException = CType(ex, RasterException)

      If ignoreIfNotSupportError Then
         Return message
      End If

      If rex.Code = RasterExceptionCode.FeatureNotSupported Or _
         rex.Code = RasterExceptionCode.DicomNotEnabled Or _
         rex.Code = RasterExceptionCode.DocumentNotEnabled Or _
         rex.Code = RasterExceptionCode.MedicalNotEnabled Or _
         rex.Code = RasterExceptionCode.ProNotEnabled Or _
         rex.Code = RasterExceptionCode.LzwLocked Or _
         rex.Code = RasterExceptionCode.JbigNotEnabled Or _
         rex.Code = RasterExceptionCode.Jbig2Locked Or _
         rex.Code = RasterExceptionCode.J2kLocked Or _
         rex.Code = RasterExceptionCode.PdfNotEnabled Or _
         rex.Code = RasterExceptionCode.CmwLocked Or _
         rex.Code = RasterExceptionCode.AbcLocked Or _
         rex.Code = RasterExceptionCode.MedicalNetNotEnabled Or _
         rex.Code = RasterExceptionCode.NitfLocked Or _
         rex.Code = RasterExceptionCode.JpipLocked Or _
         rex.Code = RasterExceptionCode.FormsLocked Or _
         rex.Code = RasterExceptionCode.DocumentWritersNotEnabled Or _
         rex.Code = RasterExceptionCode.MediaWriterNotEnabled Or _
         rex.Code = RasterExceptionCode.DocumentWritersPdfNotEnabled Or _
         rex.Code = RasterExceptionCode.LeadPrinterNotEnabled Or _
         rex.Code = RasterExceptionCode.LeadPrinterServerNotEnabled Or _
         rex.Code = RasterExceptionCode.LeadPrinterNetworkNotEnabled Or _
         rex.Code = RasterExceptionCode.AppStoreNotEnabled Or _
         rex.Code = RasterExceptionCode.BasicNotEnabled Or _
         rex.Code = RasterExceptionCode.NoServerLicense Then
         message = String.Format("Your runtime license does not include support for this functionality." & Environment.NewLine & "* {0}" & Environment.NewLine & "Please contact sales@leadtools.com to discuss options to include this feature set in your runtime license.", rex.Message)
      End If
      Return message
   End Function

   Public Shared Function Show(ByVal owner As IWin32Window, message As String, icon As MessageBoxIcon, buttons As MessageBoxButtons) As DialogResult
      Return MessageBox.Show(owner, message, Caption, buttons, icon)
   End Function
End Class
