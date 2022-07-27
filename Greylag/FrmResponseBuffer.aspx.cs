using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Greylag
{
    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = -1;
            //buffer 사용을 활성화 하면 write 후 flush를 해줘야 출력됨.
            Response.Buffer = true;
            Response.Write("[1] 이 글은 보임<br/>");
            Response.Flush();
            Response.Write("[2] 현재 이 글은 안보임");
            //buffer에 저장된 내용을 초기화
            Response.Clear();
            Response.Write("[3] 이 글은 보임<br/>");
            Response.End(); //Response.Flush() + End();
            Response.Write("[4] 이 글은 안보임"); 
        }
    }
}