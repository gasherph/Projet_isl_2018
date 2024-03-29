﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CategoriesList.aspx.cs" Inherits="Burger2Home_ISL_Project.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
    Categorie
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 55px;
        }

        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">

    <asp:SqlDataSource ID="CategorieLibelle" runat="server"
        ConnectionString="Data Source=EPHREM-PC;Initial Catalog=Burger2Home;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;"
        SelectCommand="SELECT categorie_id, categorie_name FROM Categorie ORDER BY categorie_id" ProviderName="System.Data.SqlClient"
        UpdateCommand="UPDATE Categorie SET categorie_name=@categorie_name WHERE categorie_id=@categorie_id"
        DeleteCommand="DELETE FROM Categorie WHERE categorie_id=@categorie_id"></asp:SqlDataSource>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:GridView ID="gridViewCategories" runat="server"
                    DataSourceID="CategorieLibelle" AllowSorting="True" DataKeyNames="categorie_id"
                    HeaderStyle-CssClass="entetegrille"
                    AlternatingRowStyle-CssClass="lignesgrille" CellPadding="4"
                    AutoGenerateEditButton="True"
                    AutoGenerateSelectButton="True"
                    AutoGenerateDeleteButton="true"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CssClass="auto-style2" Height="190px" Width="472px">
                    <%-- AutoGenerateColumns="False" OnSelectedIndexChanged="gridViewCategories_SelectedIndexChanged">--%>
                    <AlternatingRowStyle CssClass="lignesgrille"></AlternatingRowStyle>

                    <Columns>
                        <asp:BoundField DataField="categorie_id" HeaderText="ID" SortExpression="id" ReadOnly="true" />
                    </Columns>

                    <Columns>
                        <asp:TemplateField HeaderText="Name" SortExpression="categorie_name">
                            <ItemTemplate>

                                <asp:Label ID="lblName" runat="server" Text='<%# Eval("categorie_name") %>' />

                            </ItemTemplate>
                            <EditItemTemplate>

                                <asp:TextBox ID="TextBoxName" runat="server" MaxLength="50" Text='<%# Bind("categorie_name") %>' />

                                <asp:RequiredFieldValidator ID="requiredFieldValidatorName" runat="server" ControlToValidate="TextBoxName"
                                    ErrorMessage="Valeur requise!" CssClass="erreurvalidateur" SetFocusOnError="True" />

                            </EditItemTemplate>

                        </asp:TemplateField>
                    </Columns>
            
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099"></FooterStyle>

                    <HeaderStyle BackColor="#990000" CssClass="entetegrille" Font-Bold="True" ForeColor="#FFFFCC"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>

                    <RowStyle BackColor="White" ForeColor="#330099"></RowStyle>

                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399"></SelectedRowStyle>

                    <SortedAscendingCellStyle BackColor="#FEFCEB"></SortedAscendingCellStyle>

                    <SortedAscendingHeaderStyle BackColor="#AF0101"></SortedAscendingHeaderStyle>

                    <SortedDescendingCellStyle BackColor="#F6F0C0"></SortedDescendingCellStyle>

                    <SortedDescendingHeaderStyle BackColor="#7E0000"></SortedDescendingHeaderStyle>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
