<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="Burger2Home_ISL_Project.UsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 73px;
        }
        .auto-style2 {
            height: 28px;
        }
        .auto-style3 {
            height: 28px;
            width: 98px;
        }
        .auto-style4 {
            height: 73px;
            width: 98px;
        }
        .auto-style5 {
            width: 98px;
        }
        .auto-style6 {
            height: 28px;
            width: 718px;
        }
        .auto-style7 {
            height: 73px;
            width: 718px;
        }
        .auto-style8 {
            width: 718px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style7">

                <asp:GridView ID="GrilleUpload" runat="server" 

                    AutoGenerateColumns="false" ShowFooter="true" Height="647px" Width="664px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC"></AlternatingRowStyle>
                    <Columns>
                      
                        <asp:TemplateField HeaderText="User ID">
                            <ItemTemplate>
                                <asp:Label ID="lblUserID" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "user_id") %>'></asp:Label>
                            </ItemTemplate>
                            <%--<FooterTemplate>
                                <asp:TextBox ID="TextBox_UserID" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Name">
                            <ItemTemplate>
                                <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "firstname") %>'></asp:Label>
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:TextBox ID="TextBox_UserName" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User LastName">
                            <ItemTemplate>
                                <asp:Label ID="lblLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "lastname") %>'></asp:Label>
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:TextBox ID="TextBox_UserLastName" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Email">
                            <ItemTemplate>
                                <asp:Label ID="lblEmail" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "email") %>'></asp:Label>
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:TextBox ID="TextBox_UserEmail" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Password">
                            <ItemTemplate>
                                <asp:Label ID="lblPassword" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "password") %>'></asp:Label>
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:TextBox ID="TextBox_UserPassword" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Phone">
                            <ItemTemplate>
                                <asp:Label ID="lblPhone" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "phone") %>'></asp:Label>
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:TextBox ID="TextBox_UserPhone" runat="server"></asp:TextBox>
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Photo">
                            <ItemTemplate>
                                <asp:Image ID="imgPhoto" runat="server" Width="100px" Height="120px"
                                    ImageUrl='<%#DataBinder.Eval(Container.DataItem, "ImageUrl") %>' />
                            </ItemTemplate>
                           <%-- <FooterTemplate>
                                <asp:FileUpload ID="fUpload" runat="server" />
                            </FooterTemplate>--%>
                        </asp:TemplateField>

                        <%--<asp:TemplateField>
                           <FooterTemplate>
                                <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_OnClick" />
                            </FooterTemplate>
                        </asp:TemplateField>--%>
                    </Columns>

                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black"></FooterStyle>

                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Center" BackColor="#999999" ForeColor="Black"></PagerStyle>

                    <RowStyle BackColor="#EEEEEE" ForeColor="Black"></RowStyle>

                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

                    <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                    <SortedAscendingHeaderStyle BackColor="#0000A9"></SortedAscendingHeaderStyle>

                    <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                    <SortedDescendingHeaderStyle BackColor="#000065"></SortedDescendingHeaderStyle>
                </asp:GridView>

            </td>
            <td class="auto-style1">
                <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
