<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountrysUI.aspx.cs" Inherits="CountryCityInfoManagementSystemApp.UI.ViewCountrysUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Country</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Search Criteria</legend> 
        
        <div style=" width:490px; float:left;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Country Name"></asp:Label></td>
                    <td><asp:TextBox runat="server" ID="countrySearchTextBox" Height="21px" Width="223px"></asp:TextBox></td>
                    <td><asp:Button runat="server" ID="searchButton" Text="Search" Height="33px" Width="117px" style="margin-left: 0" OnClick="searchButton_Click" /></td>
                </tr>
            </table> 
			
			</div>
    </fieldset>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
         <asp:GridView ID="viewCountryGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="951px" PageSize="3" AllowPaging="True"
            OnPageIndexChanging="viewCountryGridView_PageIndexChanging" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>

                            <%#Container.DataItemIndex+1%>
                        </ItemTemplate>
                        <ItemStyle Width="30px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Country Name"  >
                        <ItemTemplate>

                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="About">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="400px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="No. Of Cities">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("NoOfCities") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="No. Of City Dwellers">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("NoOfCityDwellers") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>
                    

                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle ForeColor="Black" BackColor="#EEEEEE" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
    </div>
    </form>
</body>
</html>
