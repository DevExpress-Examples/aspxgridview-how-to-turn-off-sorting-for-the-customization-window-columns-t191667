Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub gridView_BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
        Dim gridView As ASPxGridView = TryCast(sender, ASPxGridView)

        For Each column As GridViewDataColumn In gridView.DataColumns
            If column.Visible Then
                column.Settings.AllowSort = DefaultBoolean.True
            Else
                column.Settings.AllowSort = DefaultBoolean.False
            End If
        Next column
    End Sub
End Class