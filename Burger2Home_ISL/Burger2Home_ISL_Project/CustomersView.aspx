<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomersView.aspx.cs" Inherits="Burger2Home_ISL_Project.CustomersView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 381px;
        }

        .auto-style2 {
            width: 373px;
        }

        .auto-style3 {
            width: 367px;
        }

        .auto-style4 {
            width: 363px;
        }

        .auto-style5 {
            width: 357px;
        }

        .auto-style6 {
            width: 136px;
        }

        .auto-style7 {
            width: 922px;
        }

        .auto-style8 {
            width: 136px;
            height: 44px;
        }

        .auto-style9 {
            width: 922px;
            height: 44px;
        }

        .auto-style10 {
            height: 44px;
        }

        .auto-style11 {
            width: 136px;
            height: 177px;
        }

        .auto-style12 {
            width: 922px;
            height: 177px;
        }

        .auto-style13 {
            height: 177px;
        }
        .auto-style14 {
            width: 136px;
            height: 58px;
        }
        .auto-style15 {
            width: 922px;
            height: 58px;
        }
        .auto-style16 {
            height: 58px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="4" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="customer_id" HeaderText="CustomerID" />
                        <asp:BoundField DataField="firstname" HeaderText="First Name" />
                        <asp:BoundField DataField="lastname" HeaderText="Last Name" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="password" HeaderText="Password" />
                        <asp:BoundField DataField="address" HeaderText="Address" />
                    </Columns>
                    <HeaderStyle BackColor="#663300" ForeColor="#ffffff" />
                    <RowStyle BackColor="#e7ceb6" />
                </asp:GridView>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style5">Customer ID</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="TextCustomerID" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">First Name</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextFirstname" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Last Name</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="Textlastname" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Email</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Password</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextPassword" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Address</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextAddress" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td class="auto-style3">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style16"></td>
        </tr>
    </table>
    <br />
    <br />   
</asp:Content>
