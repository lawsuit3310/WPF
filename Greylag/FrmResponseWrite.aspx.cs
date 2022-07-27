using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Greylag
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write("안녕하세요 <br/>");
        }

        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script language = 'javascript'>
                window.alert('안녕');
            </script>
            ";
            Response.Write(strJs);
        }
    }
}