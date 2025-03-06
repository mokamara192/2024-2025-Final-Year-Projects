Public Class frmReportViewer
 

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        MyCrystalReportViewer.PrintReport()

    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        MyCrystalReportViewer.ExportReport()

    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        MyCrystalReportViewer.RefreshReport()

    End Sub


    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        MyCrystalReportViewer.ShowFirstPage()

    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        MyCrystalReportViewer.ShowNextPage()

    End Sub


    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        MyCrystalReportViewer.ShowPreviousPage()

    End Sub


    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        MyCrystalReportViewer.ShowLastPage()

    End Sub


    Private Sub MyLoading() Handles Me.Load
        'RibbonControl1.Minimized = True
        Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = Me.MyCrystalReportViewer.ReportSource
        MyDocument.PrintOptions.PrinterName = MyPrinterName

        Me.MyCrystalReportViewer.ReportSource = MyDocument

    End Sub

End Class
