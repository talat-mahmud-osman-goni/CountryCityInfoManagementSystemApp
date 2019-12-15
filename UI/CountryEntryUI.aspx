<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntryUI.aspx.cs" Inherits="CountryCityInfoManagementSystemApp.UI.CountryEntryUI" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Country</title>
    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br/>
    <br/>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="countryNameTextBox" runat="server" Width="167px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="About"></asp:Label></td>
                <td>
                    <cc1:Editor ID="CountryAboutEditor" runat="server" BackColor="#66CCFF" BorderColor="#6600CC" BorderStyle="None" Height="300px" Width="700px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="cancelButton" runat="server" Text="Cancel" BackColor="#9933FF" BorderColor="#FFCCFF" Font-Bold="True" ForeColor="White" Height="40px" OnClick="cancelButton_Click" Width="100px" /></td>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="100px" BackColor="#9933FF" BorderColor="#FFCCFF" Font-Bold="True" ForeColor="White" OnClick="saveButton_Click" Height="40px" /></td>
            </tr>
        </table>
        <asp:Label ID="showLabel" runat="server" Text=""></asp:Label>
    </div>
        <div>
         <asp:GridView ID="countryGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="794px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                             <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                        <ItemStyle Width="70px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                           <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="200px" />
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="About">
                        <ItemTemplate>
                           <asp:Label runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                        </ItemTemplate>
                         <ItemStyle Width="500px" />
                    </asp:TemplateField>
                </Columns>             
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            </div>
    </form>
</body>
</html>
