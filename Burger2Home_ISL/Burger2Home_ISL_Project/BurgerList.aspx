<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BurgerList.aspx.cs" Inherits="Burger2Home_ISL_Project.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 200px;
            height: 21px;
        }

        .auto-style6 {
            width: 458px;
            height: 21px;
        }

        .auto-style7 {
            height: 21px;
        }

        .auto-style8 {
            width: 458px;
            height: 81px;
        }

        .auto-style9 {
            height: 81px;
        }

        .auto-style10 {
            width: 100%;
            height: 131px;
            margin-bottom: 21px;
        }

        .auto-style11 {
            width: 200px;
            height: 35px;
        }

        .auto-style12 {
            width: 458px;
            height: 35px;
        }

        .auto-style13 {
            height: 35px;
        }

        .auto-style14 {
            width: 200px;
            height: 81px;
        }

        .auto-style15 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="auto-style10">
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:ImageButton ID="ImageButton2" runat="server" Height="150px" Width="150px"
                    ImageUrl="~/Ressources/images/burger01.jpg"  OnClick="ImageButton2_Click" />
            </td>
            <td class="auto-style8">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="150px" 
                    ImageUrl="~/Ressources/images/burger02.jpg" Width="150px" />
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>
                <asp:Panel ID="PanelDetails" runat="server">
                    <asp:Label ID="LabelDescription" runat="server" CssClass="auto-style15" Text="Label" Visible="False"></asp:Label>
                    <br />
                    <asp:Label ID="LabelPrice" runat="server" CssClass="auto-style15" Text="Label" Visible="False"></asp:Label>
                </asp:Panel>
            </strong></td>
            <td class="auto-style12"></td>
            <td class="auto-style13"></td>
        </tr>
    </table>
</asp:Content>
