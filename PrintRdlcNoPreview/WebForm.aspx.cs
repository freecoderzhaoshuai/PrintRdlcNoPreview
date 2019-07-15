using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("InvoiceNo");
            dataTable.Columns.Add("Company");
            DataRow row = dataTable.NewRow();
            row["InvoiceNo"] = "311111";
            row["Company"] = "hahahah";
            dataTable.Rows.Add(row);
            localReport.DataSources.Add(new ReportDataSource("GridHead", dataTable));
            string printerName = "Microsoft Print to PDF";
            localReport.PrintToPrinter(printerName);
        }
    }
}