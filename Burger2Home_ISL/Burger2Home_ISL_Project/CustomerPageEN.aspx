<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerPageEN.aspx.cs" Inherits="Burger2Home_ISL_Project.Views.CustomerPageEN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<head runat="server">  
    <title>Customer Page in English</title>
     <link href="../Ressources/burgerStyle.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <header id="header"> <h2> <p>Connected Customer Page</p></h2>
                 <a href="CustomerPageFR.aspx" title =" Français"> Fr </a> &nbsp;&nbsp;
                <a href="CustomerPageEN.aspx" title="English">En </a>  
                <br />

                <asp:Label ID="LabelConnectedCustomer" runat="server" Text="Label"></asp:Label>

                <br /> 
                
            </header>
            <nav id="navigation">
                
                <asp:Button ID="Btn_Menu"   runat="server"  Text="Menu"   Height="30" Width="170px" />
                <asp:Button ID="Btn_Order"      runat="server"  Text="Make an Order"      Height="30" Width="170px" />
                <asp:Button ID="Btn_Profil"     runat ="server" Text="Profil"     Height="30" Width="170px" />
                <asp:Button ID="Btn_retour"  runat="server"  Text="Home"  Height="30" Width="170px" OnClick="Btn_retour_Click" />
               
            </nav>

            
            <section id= "Contenu">

            </section>
           
        </div>
    </form>
</body>
</html>
