<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerRegister.aspx.cs" Inherits="Burger2Home_ISL_Project.CustomerRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 31px;
        }

        .auto-style3 {
            height: 100px;
        }

        .auto-style4 {
            width: 93px;
        }

        .auto-style5 {
            height: 100px;
            width: 93px;
        }

        .auto-style6 {
            width: 93px;
            height: 51px;
        }

        .auto-style7 {
            height: 51px;
        }

        .auto-style8 {
            color: #FFCC99;
        }

        .auto-style9 {
            width: 100%;
        }

        .auto-style10 {
            height: 51px;
            width: 1203px;
        }

        .auto-style11 {
            height: 100px;
            width: 1203px;
        }

        .auto-style12 {
            width: 1203px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="auto-style9">
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style10"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style11">
                <table style="width: 40%;">
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Lbl_Name" runat="server" text="Name :" cssclass="auto-style8"></asp:label>
                            </strong>
                            <br />
                        </td>
                        <td>
                            <asp:textbox id="TextBox_firstname" runat="server" datafield="firstname" height="20px" width="162px"></asp:textbox>
                            <asp:label id="Label_firstname" runat="server" forecolor="Red" text="Valeur incorrect!" visible="False"></asp:label>
                        </td>

                    </tr>

                    <tr>
                        <td class="auto-style2">
                            <strong>
                                <asp:label id="Label_Lastname" runat="server" text="Lastname :" cssclass="auto-style8"></asp:label>
                            </strong>
                            <br />
                        </td>
                        <td class="auto-style2">
                            <asp:textbox id="TextBox_lastname" runat="server" datafield="lastname" height="19px" width="163px"></asp:textbox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Label_email" runat="server" text="Email :" cssclass="auto-style8"></asp:label>
                            </strong>
                        </td>
                        <td>
                            <asp:textbox id="TextBox_email" runat="server" datafield="email" textmode="Email" width="162px"></asp:textbox>
                            <asp:label id="Label_mail_exist" runat="server" forecolor="Red" text="Cette email existe!" visible="False"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Label_Confirm_Email" runat="server" text="Confirmer Email :" cssclass="auto-style8"></asp:label>
                            </strong>
                        </td>
                        <td>
                            <asp:textbox id="TextBox_Confirm_Email" runat="server" textmode="Email" width="162px"></asp:textbox>
                            <asp:label id="Label_Email_Distinct" runat="server" forecolor="Red" text="Email non identique!" visible="False"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Label_password" runat="server" text="Password :" cssclass="auto-style8"></asp:label>
                            </strong>
                        </td>
                        <td>
                            <asp:textbox id="TextBox_password" runat="server" datafield="password" textmode="Password" width="162px"></asp:textbox>
                            <asp:label id="Label_password_vide" runat="server" forecolor="Red" text="Password est vide!" visible="False"></asp:label>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Label_Password_Confirm" runat="server" text="Confirmer Password :" cssclass="auto-style8"></asp:label>
                            </strong>
                        </td>
                        <td>
                            <asp:textbox id="TextBox_Password_Confirm" runat="server" textmode="Password" width="162px"></asp:textbox>
                            <asp:label id="Label_Password_Distinct" runat="server" forecolor="Red" text="Password non identique!" visible="False"></asp:label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>
                                <asp:label id="Label_address" runat="server" text="Address :" cssclass="auto-style8"></asp:label>
                            </strong>
                        </td>
                        <td>
                            <asp:textbox id="TextBox_address" runat="server" datafield="address" height="26px" width="162px"></asp:textbox>

                        </td>
                    </tr>
                </table>

            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style12">
                <asp:button id="Btn_Save" runat="server" text="Save" width="132px" onclick="Btn_Save_Click" />
                <asp:button id="Btn_cancel" runat="server" text="Cancel" onclick="Btn_cancel_Click" width="148px" />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
