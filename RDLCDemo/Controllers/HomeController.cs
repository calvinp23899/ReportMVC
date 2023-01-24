using RDLCDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDLCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void GetEmployeeReport()
        {
            ReportParams objReportParams = new ReportParams();
            var data = GetEmployeeInfo();
            objReportParams.DataSource = data.Tables[0];
            //Folder Reports
            objReportParams.ReportTitle = "Employee Info Report"; // Any Title
            objReportParams.RptFileName = "UserReport.rdlc"; //File name Rdlc
            objReportParams.ReportType = "EmpReport"; // Any Type name
            objReportParams.DataSetName = "dsEmpReport"; // FileName DataSet
            this.HttpContext.Session["ReportParam"] = objReportParams;

        }
        public DataSet GetEmployeeInfo()
        {
            string conStr = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
            DataSet ds = new DataSet();
            string sql = "Select * From [User]";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dt =new SqlDataAdapter(cmd);
            dt.Fill(ds);
            return ds;
        }
    }
}