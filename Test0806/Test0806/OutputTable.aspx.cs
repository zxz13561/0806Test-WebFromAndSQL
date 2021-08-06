using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test0806
{
    public partial class OutputTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str_base = this.Session["baseNum"].ToString();
            string str_col = this.Session["colNum"].ToString();

            int baseNum;
            int colNum;

            // to int 
            if (!int.TryParse(str_base, out baseNum))
            {
                this.plcTableMsg.Visible = true;
            }
            if (!int.TryParse(str_col, out colNum)) 
            {
                this.plcTableMsg.Visible = true;
            }

            // output
            for (int j = 1; j <= colNum; j++)
            {
                TableRow row = new TableRow();
                for (int i = 1; i <= baseNum; i++)
                { 
                    TableCell cell = new TableCell();
                    if( j == 1)
                    {
                        cell.Text = "&ensp;" + $"基數 : {i} </br>";
                    }
                    cell.Text += "&ensp;" + $"{i} x {j} = {j * i}" + "&ensp;" + "</br>";
                    row.Cells.Add(cell);
                }
                this.Table1.Rows.Add(row);
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}