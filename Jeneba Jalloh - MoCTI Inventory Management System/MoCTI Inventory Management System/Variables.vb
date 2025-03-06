
Imports BarcodeLib.Barcode
Imports System.Data.SqlClient
Imports DevExpress.DataAccess.Excel
Imports System.ComponentModel
Imports DevExpress.SpreadsheetSource
Imports System.IO
Imports DevExpress.XtraEditors
Imports Leadtools.Codecs
Imports Leadtools.Twain
Imports Leadtools.Wia

Module Variables

    Public Longitude As String
    Public Latitude As String
    Public CurrentDisplayedFormName As String
    Public FileCount As Integer = Nothing
    Public FileName As String = Nothing
    Public FileRecords As New ListBox
    Public IndexToRemove As Integer
    Public MirrorlstPreview As New ListBox
    Public SettingsFile As String = Application.StartupPath & "\System32.dll"
    Public IsProductActivationExpired As Boolean
    Public ProgramVersion As String = "1.0.2"

    Public QuickPreviewDialogResult As String = ""
    Public FILEServerIPAddress As String
    Public FILEUsername As String
    Public FILEPassword As String
    Public FILEFolder As String
    Public ServerIPAddress As String
    Public PortNumber As String
    Public Username As String
    Public Password As String
    Public DatabaseName As String
    Public MyConnectionString As String
    Public ConnectionTimeout As Integer
    Public ConnectionStatus As String

    Public CurrentUserID As String = "DEFAULT"
    Public ServerAddress As String
    Public AccessibleFeatures As String = ""
    Public AccessLevel As String = "DEFAULT"
    Public RecordAccessLevel As String = ""
    Public CurrentUserName As String = ""
    Public CurrentPassword As String = ""
    Public FullNameofUser As String = "DEFAULT"
    Public UserAccountID As String = "DEFAULT"
    Public UserGroup As String = ""
    Public SelectorValue As String
    Public MyPrinterName As String

    Public ScanFullPath As String

    Public DocumentTypeandQuantityDataTable As DocumentTypeandQuanfityDataSet.TypeDataTableDataTable
    Public _wiaProperties As WiaProperties = WiaProperties.Empty
    Public _flagValuesStrings As ArrayList

    <System.Runtime.CompilerServices.Extension>
    Public Function ExcelDatasourceToDataTable(ByVal excelDataSource As ExcelDataSource) As DataTable
        Dim list As IList = (CType(excelDataSource, IListSource)).GetList()
        Dim dataView As DevExpress.DataAccess.Native.Excel.DataView = CType(list, DevExpress.DataAccess.Native.Excel.DataView)
        Dim props As List(Of DevExpress.DataAccess.Native.Excel.ViewColumn) = dataView.Columns

        Dim table As New DataTable()
        For i As Integer = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next i
        Dim values(props.Count - 1) As Object
        For Each item As DevExpress.DataAccess.Native.Excel.ViewRow In list
            For i As Integer = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next i
            table.Rows.Add(values)
        Next item
        Return table
    End Function

    Public Function GetExcelDataSourceDataTable(ByVal FileName As String) As DataTable

        Try

            Dim ds As New ExcelDataSource()
            ds.FileName = FileName
            Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions()
            Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            excelWorksheetSettings1.WorksheetName = GetWorkSheetNameByIndex(FileName, 0)
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            ds.SourceOptions = excelSourceOptions1
            ds.Fill()

            Dim ConvertedTable As DataTable = ExcelDatasourceToDataTable(ds)
            Return ConvertedTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Function GetWorkSheetNameByIndex(ByVal FileName As String, ByVal p As Integer) As String
        Dim worksheetName As String = ""
        Using spreadsheetSource As ISpreadsheetSource = SpreadsheetSourceFactory.CreateSource(FileName)
            Dim worksheetCollection As IWorksheetCollection = spreadsheetSource.Worksheets
            worksheetName = worksheetCollection(p).Name
        End Using
        Return worksheetName
    End Function

    Public Function GetByteData(ByVal FilePath As String) As Byte()
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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function


    Public Sub DeleteDocumentFromFileStream(ByVal FileName As String, ByVal FolderTableName As String)

        Try
            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & FolderTableName & ""

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & FileName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    My.Computer.FileSystem.DeleteFile(FullPath)
                End If

            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Public Sub InsertDocumentToFileStream(ByVal FileName As String, ByVal Optional FileData As Byte() = Nothing, Optional ByVal FolderTableName As String = "")

        Try
            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & FolderTableName & ""

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & FileName
                My.Computer.FileSystem.WriteAllBytes(FullPath, FileData, False)
            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Function ValidateGeneratedFileName(ByVal FileName As String, ByVal FolderTableName As String) As Boolean
        Try
            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & FolderTableName & ""

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & FileName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    Return True
                Else
                    Return False
                End If
            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetDocumentGeneratedName(ByVal RecordID As String, ByVal ColumnName As String, ByVal TableName As String, ByVal PrimaryKey As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT " & ColumnName & " FROM " & TableName & " WHERE " & PrimaryKey & " = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("GeneratedFileName")
            Else
                Return ""
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetFileInformation(ByVal ID As String, ByVal TableName As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT ID, FileName, GeneratedFileName, FileStatus, Description, RegDate FROM " & TableName & " WHERE ID = '" & ID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable
        End Try
    End Function




    Public Function GetDocumentData(ByVal ID As String, ByVal ColumnName As String, ByVal TableName As String, ByVal PrimaryKey As String) As Byte()

        Try
            Dim theName As String = GetDocumentGeneratedName(ID, ColumnName, TableName, PrimaryKey)
            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & TableName & ""

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & theName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    Dim TheBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(FullPath)
                    Return TheBytes
                End If

            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function



    Public Function GenerateDocumentFileName(ByVal FileExtension As String, ByVal PrimaryKey As String, ByVal TableName As String) As String

A:
        Dim RandomGen As New Random
        Dim RandomValue As String = RandomGen.NextDouble.ToString
        Dim RandomSplit As String() = RandomValue.Trim.Split(".")

        Dim TotalNoofDocuments As Integer = GetNoofFiles(PrimaryKey, TableName)

        Dim GeneratedFileValue As String = DateTime.Now.ToString("yyyyMMdd-HHmmss") & "-" & TotalNoofDocuments & "-" & RandomSplit(1).Substring(3, 5) & "." & FileExtension & ""

        If ValidateGeneratedFileName(GeneratedFileValue, TableName) Then
            GoTo A
        Else
            Return GeneratedFileValue
        End If

    End Function

    Public Function GetNoofFiles(ByVal PrimaryKey As String, ByVal TableName As String) As Integer
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Count(" & PrimaryKey & ") AS Total FROM " & TableName & ""
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("Total")
            Else
                Return 0
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Sub CreateLog(ByVal UserID As String, ByVal FullName As String, ByVal Activity As String, ByVal Amount As Single)
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "INSERT INTO tblUserLog (UserID, FullName, UserName, Activity, Amount, LogDate, ActivityTime ) VALUES(@UserID, @FullName, @UserName, @Activity, @Amount, CURRENT_TIMESTAMP, @ActivityTime)"

            Dim ConCommand As New SqlCommand(Query, Conn)

            With ConCommand.Parameters
                .AddWithValue("@UserID", UserID)
                .AddWithValue("@FullName", FullName)
                .AddWithValue("@UserName", CurrentUserName)
                .AddWithValue("@Activity", Activity)
                .AddWithValue("@Amount", Amount)
                .AddWithValue("@LogDate", Date.Today)
                .AddWithValue("@ActivityTime", Format(Now, "HH:mm:ss"))
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Function getColumnValueCount(ByVal TableName As String, ByVal ColumnName As String, ByVal ColumnValue As String, ByVal DateColumn As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal IncludeTheDate As Boolean) As Integer
        Try

            Dim EStartDate As String = StartDate.Year & "-" & Format(StartDate, "MM") & "-" & Format(StartDate, "dd")
            Dim EEndDate As String = EndDate.Year & "-" & Format(EndDate, "MM") & "-" & Format(EndDate, "dd")

            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String

            If ColumnName.ToUpper.Contains("DATE") Then
                Query = "Select Count(" & ColumnName & ") From " & TableName & " WHERE " & ColumnName & " = '" & ColumnValue & "'"
            Else
                If IncludeTheDate = True Then
                    Query = "Select Count(" & ColumnName & ") From " & TableName & " WHERE " & ColumnName & " = '" & ColumnValue & "' AND " & DateColumn & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'"
                Else
                    Query = "Select Count(" & ColumnName & ") From " & TableName & " WHERE " & ColumnName & " = '" & ColumnValue & "'"
                End If
            End If

            Dim ConCommand As New SqlCommand(Query, Conn)

            Conn.Open()
            Dim RecordCount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            Conn.Dispose()
            ConCommand.Dispose()

            Return RecordCount

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Public Function ValidateUniversalID(ByVal TableName As String, ByVal PrimaryKey As String, ByVal KeyValue As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM " & TableName & " WHERE " & PrimaryKey & " = '" & KeyValue & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            If Recordcount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Function AmountInWords(ByVal nAmount As String, ByVal Currency As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim TheCurrency As String = Currency

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, TheCurrency, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
                tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), TheCurrency,
                  wAmount.Trim & " " & TheCurrency & " And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
          IIf(InStr(wAmount.Trim.ToLower, TheCurrency.ToString.ToLower),
          wAmount.Trim, wAmount.Trim & " " & ConvertToNormalCase(TheCurrency))

        'Display the result
        Return wAmount
    End Function


    Private Function ConvertToNormalCase(ByVal TheValue As String) As String
        If TheValue <> "" Then
            Dim thefullstring As String = ""

            For i = 0 To TheValue.ToCharArray.Count - 1
                If i = 0 Then
                    thefullstring = CChar(TheValue(i)).ToString().ToUpper()
                Else
                    If thefullstring <> "" Then
                        thefullstring = thefullstring & CChar(TheValue(i)).ToString().ToLower()
                    Else
                        thefullstring = CChar(TheValue(i)).ToString().ToLower()
                    End If
                End If
            Next

            Return thefullstring
        Else
            Return ""
        End If
    End Function

    Public Function generateReportSummaryGroup(ByVal Category As String, ByVal TableName As String, ByVal ColumnName As String, ByVal DateColumn As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal IncludeDate As Boolean) As DataTable
        Try
            Dim EStartDate As String = StartDate.Year & "-" & Format(StartDate, "MM") & "-" & Format(StartDate, "dd")
            Dim EEndDate As String = EndDate.Year & "-" & Format(EndDate, "MM") & "-" & Format(EndDate, "dd")

            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select Distinct(" & ColumnName & ") From " & TableName & ""
            Dim ConTableadap As New SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            ConTableadap.Fill(MyTable)

            Dim MySummaryTable As DataTable = New SummaryDataSet.SummaryDataTable

            If MyTable.Rows.Count Then
                For Each Record In MyTable.Rows
                    Dim Entity As String = Record(ColumnName)
                    Dim FixedDate As String = Nothing

                    If ColumnName.ToUpper.Contains("DATE") Then
                        Dim DDate As Date = CDate(Record(ColumnName))
                        FixedDate = DDate.Year & "-" & Format(DDate, "MM") & "-" & Format(DDate, "dd")
                    End If

                    Dim EntityValue As Integer

                    If ColumnName.ToUpper.Contains("DATE") Then
                        EntityValue = getColumnValueCount(TableName, ColumnName, FixedDate, DateColumn, StartDate, EndDate, IncludeDate)
                    Else
                        EntityValue = getColumnValueCount(TableName, ColumnName, Record(ColumnName), DateColumn, StartDate, EndDate, IncludeDate)
                    End If

                    MySummaryTable.Rows.Add(Category, Entity, EntityValue)
                Next

                Return MySummaryTable
            Else
                'MessageBox.Show("No Record Found when generating the group")
                Return MySummaryTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Public Function ReduceImageSize(ByVal ImageSource As String, ByVal widthpercent As Single, ByVal heightpercent As Single) As Bitmap
        Try

            Dim MyImage As Image
            Dim MyMemoryStream As New System.IO.MemoryStream(GetByteData(ImageSource))
            MyImage = Image.FromStream(MyMemoryStream)

            Dim TheWidth As Integer
            Dim TheHeight As Integer

            If MyImage.Width >= 1024 Then
                Dim Percent As Single = 1024 / MyImage.Width

                TheWidth = MyImage.Width * Percent
                TheHeight = MyImage.Height * Percent
            Else
                TheWidth = MyImage.Width
                TheHeight = MyImage.Height
            End If

            Dim g As Graphics
            Dim captured As Bitmap = New System.Drawing.Bitmap(TheWidth, TheHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
            g = Graphics.FromImage(captured)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(MyImage, New Rectangle(0, 0, TheWidth, TheHeight), New Rectangle(0, 0, MyImage.Width, MyImage.Height), GraphicsUnit.Pixel)

            Return captured

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Function


    Public Function SeparateText(ByVal TheText As String) As String
        Try

            Dim SplitArray As Char() = TheText.ToCharArray
            Dim FullString As String = Nothing
            Dim CurrentIndex As Integer = 0
            Dim PreviousCharCase As String = Nothing

            For Each thechar As Char In SplitArray
                Dim NIndex As Integer = CurrentIndex + 1

                If NIndex <= SplitArray.Count - 1 Then

                    Dim NextChar As Char = SplitArray(NIndex)
                    If Char.IsUpper(thechar) = False And Char.IsUpper(NextChar) = True Then
                        FullString += thechar & " "
                    Else
                        FullString += thechar

                    End If

                Else
                    FullString += thechar
                End If

                CurrentIndex += 1
            Next

            Dim EditedString As String = FullString.Replace(" ", "")
            Dim SecondSplit As Char() = EditedString.ToCharArray

            Dim theUppercount As Integer = 0

            For Each thesecondchar As Char In SecondSplit
                If Char.IsUpper(thesecondchar) = True Then
                    theUppercount += 1
                End If
            Next

            If theUppercount = SecondSplit.Count Then
                Return TheText
            Else
                Return FullString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Public Function GetCompanyData() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM CompanySettings"
            Dim MyTable As New DataTable

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)

            ConTableAdap.Fill(MyTable)

            Return MyTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function UniversalValidateID(ByVal GenereatedID As String, ByVal TableName As String, ByVal PrimaryKey As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM " & TableName & " WHERE " & PrimaryKey & " = '" & GenereatedID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            If Recordcount > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function UniversalGenerateRecordID(ByVal LastID As String, ByVal TableName As String, ByVal PrimaryKey As String) As String

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM Admission"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            Dim IsIDGenerated As Boolean = False

            Dim StartPrefix As String = ""
            Dim TotalNumericCount As Integer = 0

            Dim NumericCharacters As String = ""
            Dim NumericCharacterswithoutZero As String = ""
            Dim isnumericCharfound As Boolean = False

            For Each DChar As Char In LastID.ToCharArray
                If IsNumeric(DChar.ToString) Then
                    TotalNumericCount += 1
                    NumericCharacters = NumericCharacters & DChar.ToString

                    If isnumericCharfound = False Then
                        If CInt(DChar.ToString) > 0 Then
                            NumericCharacterswithoutZero = NumericCharacterswithoutZero & DChar.ToString
                            isnumericCharfound = True
                        End If
                    Else
                        NumericCharacterswithoutZero = NumericCharacterswithoutZero & DChar.ToString
                    End If

                Else
                    StartPrefix = StartPrefix & DChar.ToString
                End If
            Next

            If StartPrefix = "" Then
                Dim GeneratedforInt As Integer = LastID

                While IsIDGenerated = False
                    GeneratedforInt += 1
                    If UniversalValidateID(GeneratedforInt, TableName, PrimaryKey) = False Then
                        Return GeneratedforInt
                        Exit While
                    End If
                End While

            Else

                Dim GeneratedforInt As Integer = NumericCharacterswithoutZero

                While IsIDGenerated = False
                    Dim FullString As String = ""
                    GeneratedforInt += 1

                    Dim MissingZeroCount As Integer = NumericCharacters.ToCharArray.Count - GeneratedforInt.ToString.ToCharArray.Count

                    For i = 0 To MissingZeroCount - 1
                        FullString = FullString & "0"
                    Next

                    FullString = FullString & GeneratedforInt

                    If UniversalValidateID(FullString, TableName, PrimaryKey) = False Then
                        Return StartPrefix & FullString
                        Exit While
                    End If
                End While
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Connection Error"
        End Try

    End Function
    Public Function UniversalGetDatafromTable(ByVal TableName As String, ByVal Fields As String, ByVal DValues As String) As DataTable
        Try
            Dim conn As New SqlClient.SqlConnection(MyConnectionString)

            If DValues <> "" Then
                Dim WhereCondition As String = ""

                If Fields <> "" Then
                    WhereCondition = " WHERE "

                    If Fields.Contains(",") Then
                        Dim DFields As String() = Fields.Trim.Split(",")

                        For Each Item In DFields
                            If Not WhereCondition.Contains("=") Then
                                WhereCondition += Item & " = @" & Item
                            Else
                                WhereCondition += " AND " & Item & " = @" & Item
                            End If
                        Next
                    Else
                        WhereCondition = Fields & " = @" & Fields
                    End If

                Else
                    WhereCondition = ""
                End If

                Dim Query As String
                If WhereCondition.Contains("WHERE") Then
                    Query = "SELECT * FROM " & TableName & WhereCondition
                Else
                    Query = "SELECT * FROM " & TableName & " WHERE " & WhereCondition
                End If
                Dim Contableadap As New SqlDataAdapter(Query, conn)

                If DValues <> "" Then
                    Dim SplitValues As String() = DValues.Trim.Split(",")
                    Dim DFields As String() = Fields.Trim.Split(",")

                    With Contableadap.SelectCommand.Parameters
                        For i = 0 To DFields.Count - 1
                            .AddWithValue("@" & DFields(i), SplitValues(i))
                        Next
                    End With
                End If

                Dim MyTable As New DataTable

                Contableadap.Fill(MyTable)

                Return MyTable

            Else

                Dim Query As String

                If Fields <> "" Then
                    Query = "SELECT " & Fields & " FROM " & TableName
                Else
                    Query = "SELECT * FROM " & TableName
                End If
                Dim Contableadap As New SqlDataAdapter(Query, conn)

                Dim MyTable As New DataTable

                Contableadap.Fill(MyTable)

                Return MyTable

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function GetColumnDataType(ByVal TheTable As String, ByVal Columnname As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select DATA_TYPE From " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TheTable & "' AND COLUMN_NAME = '" & Columnname & "'"
            Dim MYtABLE As New DataTable
            Dim ContableAdpater As New SqlClient.SqlDataAdapter(Query, Conn)

            ContableAdpater.Fill(MYtABLE)

            If MYtABLE.Rows.Count > 0 Then
                Return MYtABLE.Rows(0).Item("DATA_TYPE")
            Else
                Return "VARCHAR"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Function UniversalGetLastRecordPKValue(ByVal TableName As String, ByVal Field As String) As String
        Try
            Dim conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT TOP 1 " & Field & " FROM " & TableName & " ORDER BY " & Field & " DESC"
            Dim Contableadap As New SqlDataAdapter(Query, conn)

            Dim MyTable As New DataTable

            Contableadap.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Return MyTable.Rows(0).Item(Field)
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetPrimaryKey(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM " & DatabaseName & ".INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" & TableName & "' AND CONSTRAINT_NAME LIKE '%PK%'"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Return MyTable.Rows(0).Item("COLUMN_NAME")
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function ConvertDatefromString(ByVal TheDate As String) As String
        Try
            Dim CleanDate As String = TheDate.Replace("12:00:00 AM", "")

            If CleanDate.Contains("/") Then
                Dim SplitDate As String() = CleanDate.Trim.Split("/")

                If SplitDate.Count = 3 Then
                    Dim FullDate As String

                    Dim DMonth As Integer = SplitDate(1)
                    Dim FullMonth As String
                    If CInt(DMonth) < 10 Then
                        FullMonth = "0" & DMonth
                    Else
                        FullMonth = DMonth
                    End If

                    Dim DDay As Integer = SplitDate(0)
                    Dim FullDay As String
                    If CInt(DDay) < 10 Then
                        FullDay = "0" & DDay
                    Else
                        FullDay = DDay
                    End If

                    FullDate = SplitDate(2) & "-" & FullMonth & "-" & FullDay
                    Return FullDate
                Else
                    Return ""
                End If
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function LoadCompanySettings() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * From CompanySettings "
            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            ConTableAdap.Fill(MyTable)

            Return MyTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetFullMonth(ByVal MonthInt As Integer) As String
        Select Case MonthInt
            Case 1 : Return "JAN"
            Case 2 : Return "FEB"
            Case 3 : Return "MAR"
            Case 4 : Return "APR"
            Case 5 : Return "MAY"
            Case 6 : Return "JUN"
            Case 7 : Return "JUL"
            Case 8 : Return "AUG"
            Case 9 : Return "SEP"
            Case 10 : Return "OCT"
            Case 11 : Return "NOV"
            Case 12 : Return "DEC"
        End Select
    End Function

    Public Function GetDataForTable(ByVal QueryItems As String, ByVal TableName As String, ByVal Condition As String, ByVal OrderByCondition As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            If Condition <> "" Then
                Query = "SELECT " & QueryItems & " FROM " & TableName & " WHERE " & Condition & " " & OrderByCondition
            Else
                Query = "SELECT " & QueryItems & " FROM " & TableName & " " & OrderByCondition
            End If

            Dim ContableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ContableAdapter.Fill(MyTable)

            Return MyTable

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable
        End Try
    End Function


    Public Sub PopulateDatainSearchToolStripButtonCombobox(ByVal QueryItem As String, ByVal TableName As String, ByVal SearchCombobox As ToolStripComboBox)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT DISTINCT(" & QueryItem & ") FROM " & TableName & " ORDER BY " & QueryItem & " ASC"
            Dim ContableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ContableAdapter.Fill(MyTable)

            'SearchCombobox.Items.Clear()

            For Each Record In MyTable.Rows
                SearchCombobox.Items.Add(Record(QueryItem))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Function GenerateQRCODE(ByVal TheData As String) As Byte()

        Try

            Dim Barcode As PDF417 = New PDF417

            'Dim MyHasher As RijndaelEnhanced = New RijndaelEnhanced("I4CU") 
            'Dim HashedString As String = MyHasher.Encrypt(TheData)

            Barcode.Data = TheData

            'Barcode.Data = GetHash(TheData.Replace("  ", " "), "I")
            Barcode.ECL = PDF417ErrorCorrectionLevel.Level_2

            'Barcode.Rows = 7
            'Barcode.Columns = 5

            If TheData.ToCharArray.Count <= 64 Then
                Barcode.Rows = 10
                Barcode.Columns = 8
            ElseIf TheData.ToCharArray.Count > 64 And TheData.ToCharArray.Count <= 128 Then
                Barcode.Rows = 14
                Barcode.Columns = 10
            Else
                Barcode.Rows = 18
                Barcode.Columns = 10
            End If

            Barcode.Encoding = PDF417Encoding.Text

            Barcode.UOM = UnitOfMeasure.PIXEL
            Barcode.LeftMargin = 0
            Barcode.RightMargin = 0
            Barcode.TopMargin = 0
            Barcode.BottomMargin = 0
            Barcode.Resolution = 96

            'Barcode.Rotate = RotateOrientation.BottomFacingDown 

            'Image format settings
            Barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
            Return Barcode.drawBarcodeAsBytes()

        Catch ex As Exception

        End Try

    End Function

    Public Function GenerateLinearCode(ByVal TheData As String) As Byte()
        Dim Barcode As New BarcodeLib.Barcode.Linear
        Dim TheSalt As String = "I4"

        Dim OnlyNumeric As String = ""

        For Each DChar As Char In TheData.ToCharArray
            If IsNumeric(DChar.ToString) Then
                OnlyNumeric += DChar.ToString
            End If
        Next

        Barcode.Data = TheData
        'Barcode.TextFontColor = Color.White
        Barcode.ShowText = False
        Barcode.BarHeight = 120
        Barcode.LeftMargin = 0
        Barcode.RightMargin = 0
        Barcode.TopMargin = 0
        Barcode.BottomMargin = 0
        Barcode.BarWidth = 5

        'Barcode.BackgroundColor = Color.WhiteSmoke
        Barcode.TextFont = New Font("Calibri", 32, FontStyle.Bold)
        Barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
        Barcode.ShowText = True

        Return Barcode.drawBarcodeAsBytes()

    End Function



    Public Sub UniversalIncrease(ByVal TableName As String, ByVal Column As String, ByVal Amount As String, ByVal Condition As String)
        Try
            Dim Query As String = "UPDATE " & TableName & " SET " & Column & " = " & Column & " + " & Amount & " WHERE " & Condition
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub UniversalDecrease(ByVal TableName As String, ByVal Column As String, ByVal Amount As String, ByVal Condition As String)
        Try
            Dim Query As String = "UPDATE " & TableName & " SET " & Column & " = " & Column & " - " & Amount & " WHERE " & Condition
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function UniversalGet(ByVal TableName As String, ByVal Column As String, ByVal Condition As String) As String
        Try
            Dim Query As String = "SELECT " & Column & " FROM " & TableName & " WHERE " & Condition
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Return MyTable.Rows(0).Item(Column)
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Function UniversalLoadBranch(ByRef BranchCombo As System.Windows.Forms.ComboBox) As String
        Try
            Dim Query As String = "SELECT BranchName FROM Branch"
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            BranchCombo.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    BranchCombo.Items.Add(Record("BranchName"))
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Module
