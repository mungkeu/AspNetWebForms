<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex004.aspx.cs" Inherits="AspNetWebform.Ex004" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            아이디 :  <asp:TextBox ID="UserID" runat="server" OnTextChanged="UserID_TextChanged"></asp:TextBox>
            <br />
            암호 :    <asp:TextBox ID="Password" runat="server" OnTextChanged="Password_TextChanged" style="height: 19px"></asp:TextBox>
            <br />
            이름 :    <asp:TextBox ID="Name" runat="server" OnTextChanged="Name_TextChanged"></asp:TextBox>
            <br />
            나이 :    <asp:TextBox ID="Age" runat="server" OnTextChanged="Age_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="전송" OnClick="btnSubmet_Click" />
        </div>
    </form>
</body>
</html>