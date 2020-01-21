<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Burger2Home_ISL_Project.NewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        .auto-style2 {
            height: 223px;
        }

        .auto-style3 {
            height: 189px;
            width: 143px;
        }

        .auto-style4 {
            height: 223px;
            width: 100px;
        }

        .auto-style5 {
            width: 442px;
        }

        .auto-style7 {
            height: 223px;
            width: 900px;
        }

        .auto-style9 {
            width: 100%;
            height: 316px;
        }

        .auto-style10 {
            height: 189px;
        }

        .auto-style11 {
            color: #FFFFFF;
            font-size: large;
        }

        .auto-style12 {
            color: #0066FF;
        }
        .auto-style13 {
            height: 29px;
        }
        .auto-style14 {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="auto-style9">
        <%-- <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6"></td>
            <td class="auto-style1"></td>
        </tr>--%>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style7">
                <table class="auto-style5">
                    <tr>

                        <td class="auto-style10">
                            <br />
                            <br />
                        </td>
                        <td class="auto-style3">
                            <%--<asp:Image ID="ImageBox" runat="server" Height="120px" Width="100px"  ImageUrl='<%#Eval("ImageUrl") %>'/>--%>
                            <asp:Image ID="ImageBox" runat="server" Height="120px" Width="100px" />
                            <br />
                            <br />
                            <strong>
                                <asp:FileUpload ID="btn_Browse" runat="server" Height="28px" Width="205px" />
                            </strong>
                            <br />
                            <asp:Button ID="btnUPLOAD" Text="UPLOAD" runat="server" OnClick="btnUPLOAD_Click" Width="119px" />
                            <br />
                            <asp:Label ID="LblMsg" runat="server" CssClass="auto-style12" Text="Label" Visible="False"></asp:Label>
                        </td>

                    </tr>

                    <tr>

                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="Lbl_Name" runat="server" Text="Name :" CssClass="auto-style11"></asp:Label></strong><br />
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox_firstname" runat="server" DataField="firstname"></asp:TextBox>
                            <asp:Label ID="Label_firstname" runat="server" ForeColor="Red" Text="Valeur incorrect!" Visible="False"></asp:Label>
                        </td>

                    </tr>

                    <tr>
                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="Label_Lastname" runat="server" Text="Lastname :" CssClass="auto-style11"></asp:Label></strong><br />
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox_lastname" runat="server" DataField="lastname"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="Label_email" runat="server" Text="Email :" CssClass="auto-style11"></asp:Label></strong></td>
                        <td>
                            <asp:TextBox ID="TextBox_email" runat="server" DataField="email" TextMode="Email"></asp:TextBox>
                            <asp:Label ID="Label_mail_exist" runat="server" ForeColor="Red" Text="Cette email existe!" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="Label_Confirm_Email" runat="server" Text="Confirmer Email :" CssClass="auto-style11"></asp:Label></strong></td>
                        <td>
                            <asp:TextBox ID="TextBox_Confirm_Email" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:Label ID="Label_Email_Distinct" runat="server" ForeColor="Red" Text="Email non identique!" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style13">
                            <strong>
                                <asp:Label ID="Label_password" runat="server" Text="Password :" CssClass="auto-style11"></asp:Label></strong></td>
                        <td class="auto-style13">
                            <asp:TextBox ID="TextBox_password" runat="server" DataField="password" TextMode="Password"></asp:TextBox>
                            <asp:Label ID="Label_password_vide" runat="server" ForeColor="Red" Text="Password est vide!" Visible="False"></asp:Label>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <strong>
                                <asp:Label ID="Label_Password_Confirm" runat="server" Text="Confirmer Password :" CssClass="auto-style11"></asp:Label></strong></td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox_Password_Confirm" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:Label ID="Label_Password_Distinct" runat="server" ForeColor="Red" Text="Password non identique!" Visible="False"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="Label_Phone" runat="server" Text="Phone :" CssClass="auto-style11"></asp:Label>
                            </strong>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox_Phone" runat="server" DataField="phone"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <strong>
                                <asp:Label ID="LabelIsAdmin" runat="server" Text="Is Admin :" CssClass="auto-style11"></asp:Label>
                            </strong>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBoxIsAdmin" runat="server" />
                        </td>
                    </tr>
                    </table>
            </td>
            <td class="auto-style2"></td>
        </tr>

    </table>
</asp:Content>
