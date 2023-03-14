<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiEkle.aspx.cs" Inherits="BlogWeb1.HobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
         <form id="Form1" runat="server">
      <div class="form-group">
          <div>
              <asp:Label ID="Label1" runat="server" Text="HOBİ"></asp:Label>
              <asp:TextBox ID="txtHobi" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          
          <asp:Button ID="Button1" runat="server" Text=" Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
      </div>
  </form>
</asp:Content>
