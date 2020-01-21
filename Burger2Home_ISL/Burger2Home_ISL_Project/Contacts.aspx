<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Burger2Home_ISL_Project.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <div style="font-family: Arial">
        <table>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <fieldset style="width: 400px">
                        <legend>Contact us</legend>
                        <table>
                            <tr>
                                <td class="auto-style16">
                                    <b>Name :</b>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtName" Width="200px" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ErrorMessage="Name is required" ControlToValidate="txtName" Text="*" ForeColor="Red">

                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <b>Email :</b>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEmail" Width="200px" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                        runat="server"
                                        ErrorMessage="Email is required"
                                        ControlToValidate="txtEmail"
                                        Display="Dynamic"
                                        Text="*" ForeColor="Red"> 
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <b>Subject :</b>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtSubject" Width="200px" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                        ErrorMessage="Subject is required" ControlToValidate="txtSubject" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td style="vertical-align: top">
                                    <b>Comments :</b>
                                </td>
                                <td style="vertical-align: top">
                                    <asp:TextBox ID="txtComments" Width="204px" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td style="vertical-align: top" class="auto-style18">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                        ErrorMessage="Comments is required" ControlToValidate="txtComments" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="3">
                                    <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please fix the following Erros" ForeColor="Red" runat="server" />
                                </td>
                            </tr>

                            <tr>
                                <td colspan="3">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="3">
                                    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
                                </td>
                            </tr>

                        </table>
                       
                    </fieldset>
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>
