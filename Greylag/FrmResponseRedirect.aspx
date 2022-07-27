<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseRedirect.aspx.cs" Inherits="Greylag.FrmResponseRedirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Response 개체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat ="server"
                ID ="btnDotNetKorea" Text="닷넷 코리아"
                OnClick="btnDotNetKorea_Click"/>
            <br />
            <asp:LinkButton runat="server"
                ID="btnDevLec" OnClick="btnDevLec_Click">
                데브렉
            </asp:LinkButton>
            <br />
            <asp:ImageButton runat ="server"
                ID ="btnVisualAcademy" AlternateText ="비주얼 아카데미"
                ToolTip="하와소" OnClick="btnVisualAcademy_Click"
                Style =" height : 16px"/>
        </div>
    </form>
</body>
</html>
