<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex005.aspx.cs" Inherits="AspNetWebform.chapter05.Ex005" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>링크버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="NaverCom" runat="server" OnClick="Naver_Click">
                네이버로 이동
            </asp:LinkButton>
        </div>
    </form>
</body>
</html>
