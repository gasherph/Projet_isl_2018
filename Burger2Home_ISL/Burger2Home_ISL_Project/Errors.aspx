<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Errors.aspx.cs" Inherits="Burger2Home_ISL_Project.Errors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titre" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
<div style="font-family: Arial">
            <table style="border: 2px solid black">
                <tr>
                    <td style="color: red">
                        <h2>Application Error</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>An unkown error has occured.
                        We are aware of it and the It team isn currently working on this issue.
                        We are so sorry for the inconinient caused.
                        </h3>
                    </td>

                </tr>
                <tr>
                    <td>
                        <h5>If you need further assistance, please contact our helpdesk at helpdesk@companyhelpdesk.com
                        </h5>
                    </td>
                </tr>

            </table>
        </div>
</asp:Content>
