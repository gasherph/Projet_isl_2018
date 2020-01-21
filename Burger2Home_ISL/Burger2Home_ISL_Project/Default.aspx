<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Burger2Home_ISL_Project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">Home</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">

    <style type="text/css">
        .auto-style1 {
            height: 174px;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style4 {
            height: 174px;
            width: 160px;
        }
        .auto-style5 {
            width: 1212px;
        }
        .auto-style6 {
            height: 174px;
            width: 1212px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">
        <asp:Image ID="image1" ImageUrl="~/Ressources/images/connection.jpg" class="w3-round-xxlarge" Style="width: 10%; margin-left: 40%" runat="server" />
                <br />
                <br />
    <asp:Button ID="Btn_Connexion" runat="server" Text="Connexion" Height="30px"
        Style="width: 10%; margin-left: 40%; border-radius: 5px; background-image: -webkit-repeating-linear-gradient(top,#ff6a00 0%, #2A2333 100%); background-image: linear-gradient(to bottom,#ff6a00 0%, #2A2333 100%); color: white"
        border-radius="10px" align="center" OnClick="Btn_Connexion_Click" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <br />
    <br />
</asp:Content>
