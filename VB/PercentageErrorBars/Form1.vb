Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace ErrorBarsWin
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private ReadOnly Property series() As Series
            Get
                Return chartControl.Series(0)
            End Get
        End Property
        #Region "#PercentageErrorBars"
        Private Sub FormOnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
            Dim view As PointSeriesView = CType(chartControl.Series(0).View, PointSeriesView)
            view.Indicators.Add(New PercentageErrorBars With {.Percent = 10, .Direction = ErrorBarDirection.Both, .ShowInLegend = True, .Name = "Units on Custom Order"})
        End Sub
        #End Region ' #PercentageErrorBars
    End Class
End Namespace
