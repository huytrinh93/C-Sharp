<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
  CodeBehind="Page1_New.aspx.cs" Inherits="SummerBreeze.Page1_New" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurrentPage" runat="server">
    New {Update this<%-- with your choice--%>}
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Instructions" runat="server">
    Create an entry form.
  <br />
  Use an Sql Datasource with a Formview set to insert. The connection string already
  exists.
  <br />
  <br />
  Stored procedures are where we house all the selects, inserts, updates, and deletes/undelete
  queries. Sometimes the content of a stored procedure is realllllly complicated.
  However, from your perspective, it's not an issue. All you need to know is what you
  need to pass in and what comes out of it.
  <br />
  <br />
  Sql data source needs to be connected to the stored procedure. Then the formview
  needs to be connected to the sql data source. When you do that, it should put stuff
  in the formview automatically based on the select in sql data source. You will then
  need to add/remove extra stuff to match what the insert statement is asking for.
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
