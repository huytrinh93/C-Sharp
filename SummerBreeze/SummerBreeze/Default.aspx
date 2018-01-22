<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
  CodeBehind="Default.aspx.cs" Inherits="SummerBreeze._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurrentPage" runat="server">
  Welcome to the Summer Breeze App
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Instructions" runat="server">
 You will be using the customer table in the local database to do your work.
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
This is where you put content
     <br /><br />
  <%--Below here, add an asp.net textbox and put your choice as its text--%>
    <asp:Label ID="Label1"  runat="server"  Text="First name"  AssociatedControlID="TextBox1" Font-Bold="true" ForeColor="Navy" Font-Size="Large"/>
    <asp:TextBox  ID="TextBox1" runat="server" Height="35" Font-Bold="true" BackColor="White" Font-Size="Large" />
    <br /><br />
  <%--below that, make a text area/ big textbox with your information--%>
  <asp:TextBox runat="server" Height="117px" Width="389px" ID="Information" text="My name is Huy Trinh, master student at University of Missouri"/>
</asp:Content>
