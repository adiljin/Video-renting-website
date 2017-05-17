<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaveAsCSV.aspx.cs" Inherits="Feedback_SaveAsCSV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 268px">
    
        Thank you for the Feedback<br />
        <br />
        The Following detail are saved. We will contact you soon.<br />
        <br />
        Your Name:
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Your E-mail:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        Your Comment:
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <a href="../login.html">Back to Profile</a></div>
    </form>
</body>
</html>
