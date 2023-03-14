<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SertifikaListesi.aspx.cs" Inherits="BlogWeb1.SertifikaListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class=" table table-bordered">
            <tr>
                <th>ID</th>
                <th>SERTİFİKA</th>
                <th>İŞLEMLER</th>

            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("ÖDÜL") %></td>
                           

                            <td>
                                <asp:HyperLink NavigateUrl='<%# "SertifikaSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"SertifikaGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-warning" runat="server">GÜNCELLE</asp:HyperLink>

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/SertifikaEkle.aspx" ID="HyperLink3" CssClass="btn btn-primary" runat="server">Sertifika Ekle</asp:HyperLink>
    </form>
</asp:Content>
