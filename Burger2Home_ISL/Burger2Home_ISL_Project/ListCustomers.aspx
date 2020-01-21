<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCustomers.aspx.cs" Inherits="Burger2Home_ISL_Project.ListCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Ressources/user.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 277px;
        }
        .auto-style4 {
            width: 1060px;
        }
        .auto-style5 {
            width: 42px;
        }
        .auto-style6 {
            width: 42px;
            height: 234px;
        }
        .auto-style7 {
            width: 1060px;
            height: 234px;
        }
        .auto-style8 {
            height: 234px;
        }
        .auto-style23 {
            margin: 0% 1%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menu">
            <ul>
                
                <li class="navigation_first_item"><a href="Default.aspx">Home</a></li>
                <li><a href="#">About us</a></li>
                <li><a href="ListCustomers.aspx">Customers</a></li>
                <li><a href="#">Orders</a></li>
                <li><a href="Burgers.aspx">Burgers</a></li>
                <li><a href="ListCategories.aspx">Categories</a></li>
                <li><a href="Ingredients.aspx">Ingredients</a></li>
                <li><a href="#">Allergenes</a></li>
                <li><a href="#">Contact us</a></li>
            </ul>
        </div>
        <br />
        <br />
        <div id="content">

            <asp:SqlDataSource ID="CustomerLibelle" runat="server"
                ConnectionString="Data Source=PC\SQLEXPRESS;Initial Catalog=Burger2Home;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"
                SelectCommand="SELECT customer_id, firstname,lastname,email,password,address FROM Customer ORDER BY customer_id" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style7">
                            <asp:GridView ID="gridViewCustomers" runat="server" AllowSorting="True" AlternatingRowStyle-CssClass="lignesgrille" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style23" DataKeyNames="customer_id" DataSourceID="CustomerLibelle" HeaderStyle-CssClass="entetegrille" Height="274px" Style="padding-left:10px; " Width="57%">
                                <AlternatingRowStyle CssClass="lignesgrille" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Name" SortExpression="firstname">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("firstname") %>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBoxName" runat="server" MaxLength="50" Text='<%# Bind("firstname") %>' />
                                            <asp:RequiredFieldValidator ID="requiredFieldValidatorName" runat="server" ControlToValidate="TextBoxName" CssClass="erreurvalidateur" ErrorMessage="Valeur requise!" SetFocusOnError="True" />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:TemplateField HeaderText="Last Name" SortExpression="lastname">
                                        <ItemTemplate>
                                            <asp:Label ID="lblLastName" runat="server" Text='<%# Eval("lastname") %>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBoxLastName" runat="server" MaxLength="50" Text='<%# Bind("lastname") %>' />
                                            <asp:RequiredFieldValidator ID="requiredFieldValidatorLastName" runat="server" ControlToValidate="TextBoxLastName" CssClass="erreurvalidateur" ErrorMessage="Valeur requise!" SetFocusOnError="True" />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
            
                                <Columns>
                                    <asp:TemplateField HeaderText="Email Address" SortExpression="email">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("email") %>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBoxEmail" runat="server" Text='<%# Bind("email") %>' />
                                            <asp:RequiredFieldValidator ID="requiredFieldValidatorEmail" runat="server" BackColor="#3366FF" ControlToValidate="TextBoxEmail" CssClass="erreurvalidateur" ErrorMessage="Valeur correct requise!" ForeColor="Red" SetFocusOnError="True">
                            </asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxEmail" CssClass="requiredFieldValidateStyle" ErrorMessage="Please Enter Valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgSubmit">
                            </asp:RegularExpressionValidator>
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                                </Columns>
                                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                <HeaderStyle BackColor="#A55129" CssClass="entetegrille" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                <SortedDescendingHeaderStyle BackColor="#93451F" />
                            </asp:GridView>
                        </td>
                        <td class="auto-style8"> &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br/>

                <br/>      

        </div>
        <div id="footer">
            Saint-Laurent,Promotion Sociale,<br />
            Rue St-Laurent,33-4000 Liège
        </div>

    </form>
</body>
</html>
