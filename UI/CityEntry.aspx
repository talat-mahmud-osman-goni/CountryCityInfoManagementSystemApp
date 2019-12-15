<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryCityInfoManagementSystemApp.UI.CityEntry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City</title>
    <style type="text/css">
        .auto-style1 {
            height: 164px;
        }
        .auto-style2 {
            width: 752px;
        }
        .auto-style3 {
            height: 164px;
            width: 752px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
            <td class="auto-style2">
                <asp:TextBox ID="citynameTextBox" runat="server" Width="149px"></asp:TextBox></td>
        </tr>
         <tr>
            <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text="About"></asp:Label></td>
            <td class="auto-style3">
                <cc1:Editor ID="cityAboutEditor" runat="server" />
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="Label3" runat="server" Text="No. of Dwellers"></asp:Label></td>
            <td class="auto-style2"><asp:TextBox ID="noOfDwellersTextBox" runat="server" Width="141px"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="Label4" runat="server" Text="Location"></asp:Label></td>
            <td class="auto-style2"><asp:TextBox ID="locationTextBo" runat="server" Width="140px"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Weather"></asp:Label></td>
            <td class="auto-style2"><asp:TextBox ID="weatherTextBox" runat="server" Width="135px"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="Label6" runat="server" Text="Country"></asp:Label></td>
            <td class="auto-style2">
                <asp:DropDownList ID="countryDropDownList" runat="server" Height="16px" Width="145px"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="cancelButton" runat="server" Text="Cancel" Height="35px" Width="74px" OnClick="cancelButton_Click" /></td>
            <td class="auto-style2">
                <asp:Button ID="saveButton" runat="server" Text="Save" Height="34px" Width="79px" OnClick="saveButton_Click" /></td>
        </tr>
    </table>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    </div>
        <div>
         <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="794px">
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
                           <asp:Label runat="server" Text='<%#Eval("CityName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="200px" />
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="No. of Dwellers">
                        <ItemTemplate>
                           <asp:Label runat="server" Text='<%#Eval("NoOfDwellers") %>'></asp:Label>
                        </ItemTemplate>
                         <ItemStyle Width="500px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>
                           <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
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
