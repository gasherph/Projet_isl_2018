﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerPageFR.aspx.cs" Inherits="Burger2Home_ISL_Project.Views.CustomerPageFR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page Client en Francais</title>
    <link href="../Ressources/burgerStyle.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header id="header"><p> Page Client Connecté</p>
                 <a href="CustomerPageFR.aspx" title =" Français"> Fr </a>&nbsp;&nbsp; <a href="CustomerPageEN.aspx" title="English">En </a>  

                <br />

                <asp:Label ID="LabelConnectedCustomer" runat="server" Text="Label"></asp:Label>

                <br />

            </header>
            <nav id="navigation">
                <asp:Button ID="Btn_Menu"   runat="server"  Text="Voir le Menu"   Height="30" Width="170px" />
                <asp:Button ID="Btn_Order"      runat="server"  Text="Commander"      Height="30" Width="170px" />
                <asp:Button ID="Btn_Profil"     runat ="server" Text="Profil"     Height="30" Width="170px" />
                <asp:Button ID="Btn_retour"  runat="server"  Text="Page Accueille"  Height="30" Width="170px" OnClick="Btn_retour_Click" BackColor="#FF6600" PostBackUrl="~/Default.aspx" />
               
            </nav>
            <section id= "Contenu">

            </section>
            
        </div>
    </form>
</body>
</html>