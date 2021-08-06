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

            if (int.TryParse(str_base, out baseNum))
            {
                this.lblBase.Text = baseNum.ToString();
            }
            if (int.TryParse(str_col, out colNum))
            {
                this.lblCol.Text = colNum.ToString();
            }

            for(int i = 1; i <= colNum; i++)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = $"{baseNum} x {i} = {baseNum*i}";
                row.Cells.Add(cell);
                this.Table1.Rows.Add(row);
            }
        }
    }
}