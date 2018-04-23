using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page
{
    protected void gridView_BeforeGetCallbackResult(object sender, EventArgs e)
    {
        ASPxGridView gridView = sender as ASPxGridView;

        foreach (GridViewDataColumn column in gridView.DataColumns)
        {
            if (column.Visible)
                column.Settings.AllowSort = DefaultBoolean.True;
            else
                column.Settings.AllowSort = DefaultBoolean.False;
        }
    }
}