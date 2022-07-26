using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Greylag
{
    public partial class FrmHelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ASP.NET 프로그램의 진입점으로 C의 Main 메소드와 같음

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "안녕하세요";
            Response.Write("안녕하세요 <br>");
        }
    }
}