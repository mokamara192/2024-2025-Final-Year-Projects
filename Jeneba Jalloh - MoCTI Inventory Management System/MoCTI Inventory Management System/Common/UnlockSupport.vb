Imports System.Windows.Forms

Imports Leadtools
Imports System

Friend NotInheritable Class Support
   Private Sub New()
   End Sub
   Public Const MedicalServerKey As String = ""

   Public Shared Function SetLicense(ByVal silent As Boolean) As Boolean
      Try
         ' TODO: Change this to use your license file and developer key */
         Dim licenseFilePath As String = "Replace this with the path to the LEADTOOLS license file"
         Dim developerKey As String = "Replace this with your developer key"
         RasterSupport.SetLicense(licenseFilePath, developerKey)
      Catch ex As Exception
         System.Diagnostics.Debug.Write(ex.Message)
      End Try

      If RasterSupport.KernelExpired Then
         Dim dir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
         ' Try the common LIC directory 

         Dim licenseFileRelativePath As String = System.IO.Path.Combine(dir, "..\..\..\Common\License\LEADTOOLS.LIC")
         Dim keyFileRelativePath As String = System.IO.Path.Combine(dir, "..\..\..\Common\License\LEADTOOLS.LIC.key")

         If System.IO.File.Exists(licenseFileRelativePath) AndAlso System.IO.File.Exists(keyFileRelativePath) Then
            Dim developerKey As String = System.IO.File.ReadAllText(keyFileRelativePath)
            Try
               RasterSupport.SetLicense(licenseFileRelativePath, developerKey)
            Catch ex As Exception
               System.Diagnostics.Debug.Write(ex.Message)
            End Try
         End If
      End If

      If RasterSupport.KernelExpired Then
         If silent = False Then
            Dim msg As String = "Your license file is missing, invalid or expired. LEADTOOLS will not function. Please contact LEAD Sales for information on obtaining a valid license."
            Dim logmsg As String = String.Format("*** NOTE: {0} ***{1}", msg, Environment.NewLine)
            System.Diagnostics.Debugger.Log(0, Nothing, "*******************************************************************************" & Environment.NewLine)
            System.Diagnostics.Debugger.Log(0, Nothing, logmsg)
            System.Diagnostics.Debugger.Log(0, Nothing, "*******************************************************************************" & Environment.NewLine)

            MessageBox.Show(Nothing, msg, "No LEADTOOLS License", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            System.Diagnostics.Process.Start("https://www.leadtools.com/downloads/evaluation-form.asp?evallicenseonly=true")
         End If

         Return False
      End If
      Return True
   End Function

   Public Shared Function SetLicense() As Boolean
      Return SetLicense(False)
   End Function

End Class