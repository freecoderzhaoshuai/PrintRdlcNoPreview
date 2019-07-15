using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrintRdlcNoPreview
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("Report.rdlc");
            string printerName = "Microsoft XPS Document Writer";
            localReport.PrintToPrinter(printerName);
        }
    }
}