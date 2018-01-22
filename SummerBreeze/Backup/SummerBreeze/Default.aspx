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
  <%--Below here, add an asp.net textbox and put your choice as its text--%>
  <%--below that, make a text area/ big textbox with your information--%>
</asp:Content>
