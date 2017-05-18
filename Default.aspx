<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <asp:FileUpload ID="FileUpload2" runat="server" />
        <br />
        <asp:FileUpload ID="FileUpload3" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Store" />
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Get" />
        <h1>Update images</h1>
        <asp:Image ID="Image1" Width="200px" Height="200px" runat="server" /><asp:FileUpload ID="FileUpload4" runat="server" /><br />
        <asp:Image ID="Image2" Width="200px" Height="200px" runat="server" /><asp:FileUpload ID="FileUpload5" runat="server" /><br />
        <asp:Image ID="Image3" Width="200px" Height="200px" runat="server" /><asp:FileUpload ID="FileUpload6" runat="server" /><br />
       
        <asp:Button ID="Button2" runat="server" Text="Update" />
    </form>
</body>
</html>
