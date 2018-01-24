<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Matrix1"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Matrix2"></asp:Label>
            <asp:FileUpload ID="FileUpload2" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pomnóż macierze" />
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Results"></asp:Label><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:Button ID="saveButton" runat="server" Text="Save results" Enabled="False" OnClick="saveButton_Click1" />
        </div>
    </form>
</body>
</html>
