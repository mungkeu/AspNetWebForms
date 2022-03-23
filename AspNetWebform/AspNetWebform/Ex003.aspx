<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex003.aspx.cs" Inherits="AspNetWebform.Ex003" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Response Redirect</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnNaver" runat="server" Text="네이버" OnClick="Naver_Click" />
            <br />
            <asp:LinkButton ID="btnYoutube" runat="server" OnClick="btnYoutube_Click">유튜브</asp:LinkButton>
            <br />
            <asp:ImageButton ID="btnGoogle" runat="server" AlternateText="구글" ToolTip="구글이미지"
                OnClick="btnGoogle_Click" Style="height: 16px" /><br />

        </div>
    </form>
</body>
</html>
