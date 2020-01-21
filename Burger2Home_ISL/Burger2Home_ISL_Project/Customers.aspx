<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Burger2Home_ISL_Project.Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 39px;
        }

        .auto-style3 {
            width: 39px;
            height: 42px;
        }

        .auto-style4 {
            height: 35px;
            width: 872px;
        }

        .auto-style5 {
            height: 37px;
        }

        .auto-style6 {
            height: 42px;
        }

        .auto-style7 {
            height: 42px;
            width: 872px;
            text-align: center;
            font-size: xx-large;
            color: #FFCC00;
        }

        .auto-style8 {
            margin-right: 0px;
            width: 872px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style7"><strong>Customer Details</strong></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style4">
                <table>                   
                    <tr>
                        <td>
                            <asp:GridView ID="GridViewCustomerDetails" runat="server" Width="96%"
                                AutoGenerateColumns="false" ShowFooter="true"
                                OnRowCommand="GridViewCustomerDetails_RowCommand"
                                OnRowDeleting="GridViewCustomerDetails_RowDeleting"
                                OnRowUpdating="GridViewCustomerDetails_RowUpdating"
                                OnRowCancelingEdit="GridViewCustomerDetails_RowCancelingEdit"
                                OnRowEditing="GridViewCustomerDetails_RowEditing"
                                CellPadding="4"
                                BorderStyle="Solid" 
                                BorderWidth="3px" 
                                BorderColor="#999999"   
                                CellSpacing="2"
                                ForeColor="#333333">

                                <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                                <Columns>

                                    <asp:TemplateField HeaderText="CutomerID">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCutomerID" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "customer_id") %>'></asp:Label>
                                        </ItemTemplate>

                                        <EditItemTemplate>
                                            <asp:Label ID="lblEditCutomerID" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "customer_id") %>'></asp:Label>
                                        </EditItemTemplate>

                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddCutomerID" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="First Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFirstName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "firstname") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEditFirstName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "firstname") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddFirstName" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Last Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "lastname") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEditLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "lastname") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddLastName" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Email">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "email") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEditEmail" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "email") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddEmail" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Password">
                                        <ItemTemplate>
                                            <asp:Label ID="lblPassword" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "password") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEditPassword" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "password") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddPassword" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Address">
                                        <ItemTemplate>
                                            <asp:Label ID="lblAddress" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "address") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEditAddress" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "address") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="txtAddAddress" runat="server"></asp:TextBox>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgbtnEdit" runat="server" CommandName="Edit" ImageUrl="~/Ressources/images/Edit.png" Height="30" Width="30" />
                                            <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" ImageUrl="~/Ressources/images/Delete.png" Width="30" Height="30" />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:ImageButton ID="imgbtnUpdate" runat="server" CommandName="Update" ImageUrl="~/Ressources/images/update02.png" Width="30" Height="30" />
                                            <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/Ressources/images/Cancel.png" Width="30" Height="30" />
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:Button ID="lbtnAdd" runat="server" Text="Add" CommandName="ADD" Width="100px" />
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></FooterStyle>
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></HeaderStyle>
                                <PagerStyle HorizontalAlign="Center" BackColor="#FFCC66" ForeColor="#333333"></PagerStyle>
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333"></RowStyle>
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy"></SelectedRowStyle>
                                <SortedAscendingCellStyle BackColor="#FDF5AC"></SortedAscendingCellStyle>
                                <SortedAscendingHeaderStyle BackColor="#4D0000"></SortedAscendingHeaderStyle>
                                <SortedDescendingCellStyle BackColor="#FCF6C0"></SortedDescendingCellStyle>
                                <SortedDescendingHeaderStyle BackColor="#820000"></SortedDescendingHeaderStyle>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
