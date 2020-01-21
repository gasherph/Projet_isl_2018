<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="toConnect.aspx.cs" Inherits="Burger2Home_ISL_Project.toConnect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 229px;
            color: #009900;
        }

        .auto-style2 {
            width: 91px;
        }

        .auto-style3 {
            width: 1366px;
        }

        .auto-style4 {
            margin-left: 0px;
        }

        .auto-style7 {
            width: 126px;
        }

        .auto-style8 {
            width: 54px;
        }

        .auto-style9 {
            width: 1042px;
        }

        .auto-style10 {
            width: 54px;
            height: 35px;
        }

        .auto-style11 {
            width: 1042px;
            height: 35px;
        }

        .auto-style12 {
            height: 35px;
        }

        .auto-style13 {
            color: #009933;
        }
        .auto-style14 {
            width: 91px;
            height: 26px;
        }
        .auto-style15 {
            width: 1366px;
            height: 26px;
        }
        .auto-style16 {
            height: 26px;
        }
        .auto-style17 {
            font-size: large;
        }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>
                <asp:Label ID="LblNewCustomer" runat="server" CssClass="auto-style17" Text="Label new Customer" Visible="False"></asp:Label>
                </strong></td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Image ID="image1" ImageUrl="~/Ressources/images/staff.png" class="w3-round-xxlarge" Style="width: 10%; margin-left: 43%" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">

                <table id="table" style="padding-left: 40%" class="auto-style4">
                    <tr style="padding: inherit; margin: inherit">
                        <td style="color: black" class="auto-style7">Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:</td>
                        <td>
                            <asp:TextBox ID="TextBoxEmail" runat="server">useroot@isl.be</asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="color: black" class="auto-style7">Password : </td>
                        <td>
                            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" rowspan="2"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="auto-style7">&nbsp;&nbsp;&nbsp;</td>
                    </tr>

                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="Btn_Send" runat="server" Text="Send" Width="100px" OnClick="Btn_Send_Click" />&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" Width="100px" OnClick="Btn_Cancel_Click" OnClientClick="return confirm('Are you sure you want to delete?')" />

                        </td>
                    </tr>
                </table>
                <br />
                <asp:LinkButton ID="Btn_Password_Forget" runat="server" Font-Bold="True" Style="padding-left: 40%" Text="Forget Password?"></asp:LinkButton>
                <asp:LinkButton ID="Btn_Register" runat="server" Font-Bold="True" OnClick="Btn_Register_Click" Style="padding-left: 2%" Text=" Register?"></asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="padding-left: 40%" class="auto-style4">
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <table>
                    <tr>
                        <td class="auto-style5"><strong><span class="auto-style13">Social Logins</span></strong></td>
                    </tr>
                    <tr>
                        <%--<td class="fb-login-button>--%>
                        <td class="auto-style7">
                            <asp:Button ID="BtnFacebook" runat="server" Text="Facebook" Width="100px" OnClick="BtnFacebook_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:Button ID="BtnGoogle" runat="server" Text="Google" Width="100px" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


    <br />

</asp:Content>
