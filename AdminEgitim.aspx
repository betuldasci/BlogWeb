<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitim.aspx.cs" Inherits="BlogWeb1.AdminEgitim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <table class=" table table-bordered">
            <tr>
                <th>ID</th>
                <th>BAŞLIK</th>
                <th>ALT BAŞLIK</th>
                <th>GENEL NOT ORTALAMASI</th>
                <th>TARİH</th>
                <th>AÇIKLAMA</th>
                <th>İŞLEMLER</th>

            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("BAŞLIK") %></td>
                            <td><%#Eval("ALTBAŞ") %></td>
                            <td><%#Eval("GNOT") %></td>
                            <td><%#Eval("TARİH") %></td>
                            <td><%#Eval("AÇIKLAMA") %></td>

                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"AdminEgitimGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-warning" runat="server">GÜNCELLE</asp:HyperLink>

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" CssClass="btn btn-primary" runat="server">Eğitim Ekle</asp:HyperLink>
    </form>
</asp:Content>
