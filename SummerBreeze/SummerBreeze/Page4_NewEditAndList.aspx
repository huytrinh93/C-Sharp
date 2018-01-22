<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
  CodeBehind="Page4_NewEditAndList.aspx.cs" Inherits="SummerBreeze.Page4_NewEditAndList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurrentPage" runat="server">
  New, Edit, and List
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Instructions" runat="server">
  This page is just like page 3 (new and list) except that you will not do inline
  editing. when you click on edit, you will load the item in the formview (which should
  then be put into edit/update mode).
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
