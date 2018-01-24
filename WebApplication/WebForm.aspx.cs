using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "D:\\STUDIA\\programy\\WebApplication\\WebApplication\\Data\\";
            FileUpload1.PostedFile.SaveAs(path + "m1.txt");
            FileUpload2.PostedFile.SaveAs(path + "m2.txt");

            Matrix matrix1 = new Matrix("m1.txt");
            Matrix matrix2 = new Matrix("m2.txt");

            Matrix res = new Matrix();
            res = res.Multiply(matrix1, matrix2);
            string filename = res.saveInFile();
            Label4.Text = filename;
            saveButton.Enabled = true;
        }

        protected void saveButton_Click1(object sender, EventArgs e)
        {
            string fileName = Label4.Text;
            Response.ContentType = "text/plain";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.TransmitFile(Server.MapPath("~/Data/" + fileName));
            Response.End(); 
        }
    }
}