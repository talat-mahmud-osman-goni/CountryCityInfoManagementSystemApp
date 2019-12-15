<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryCityInfoManagementSystemApp.UI.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View City</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Search Criteria</legend>
        <span style="font-size: 18px;">
		    <div style=" width:700px;"> 
        <div style="width:200px; float:left;">
            <asp:RadioButtonList ID="searchRadioButtonList" runat="server" Height="66px">
            <asp:ListItem Value="CityName"></asp:ListItem>  
            <asp:ListItem Value="CountryName"></asp:ListItem>   
        </asp:RadioButtonList>
        </div>
        <div style=" width:490px; float:left;"> 
            <asp:TextBox runat="server" ID="citySearchTextBox" Height="21px" Width="223px"></asp:TextBox>
			<br />
			<asp:DropDownList ID="countryDropDownList" runat="server" Height="25px" style="margin-bottom: 0px" Width="230px"></asp:DropDownList>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button runat="server" ID="searchButton" Text="Search" Height="33px" Width="117px" style="margin-left: 0px" OnClick="searchButton_Click" />
			</div>
        </div>
    </span>
    </fieldset>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
         <asp:GridView ID="viewCitiesGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="951px" PageSize="3" AllowPaging="True"
            OnPageIndexChanging="viewCitiesGridView_PageIndexChanging" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>

                            <%#Container.DataItemIndex+1%>
                        </ItemTemplate>
                        <ItemStyle Width="30px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City Name"  >
                        <ItemTemplate>

                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CityName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="About">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CityAbout") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="300px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="No. Of Dwellers">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("NoOfDwellers") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Location">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("Location") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Weather">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("Weather") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="About Country">
                        <ItemTemplate>
                            <asp:Label Style="color: Black" runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="300px" />
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
