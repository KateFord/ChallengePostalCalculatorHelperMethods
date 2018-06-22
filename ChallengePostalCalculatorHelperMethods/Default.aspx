<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="widthTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
        <br />
        Height:
        <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="heightTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
        <br />
        Length: <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="shipping" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" GroupName="shipping" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
