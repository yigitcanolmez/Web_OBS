<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="GidenMesajlar.aspx.cs" Inherits="İlkProjemm.GidenMesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
            <th scope="col">ID</th>
            <th scope="col">ALICI NUMARA</th>
            <th scope="col">ALICI AD SOYAD</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">TARİH</th>
            <th scope="col">İŞLEMLER</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("MESAJID") %></td>
                        <td><%#Eval("ALICI NUMARA") %></td>
                        <td><%#Eval("ALICI AD SOYAD") %></td>
                        <td><%#Eval("BASLIK") %></td>
                        <td><%#Eval("ICERIK") %></td>
                        <td><%#Eval("TARIH") %></td>
                        <%--      <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"DuyuruSil.aspx?DUYURUID="+Eval("DUYURUID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"DuyuruGuncelle.aspx?DUYURUID="+Eval("DUYURUID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                        </td>--%>
                    </tr>

                </ItemTemplate>



            </asp:Repeater>

        </tbody>
    </table>
</asp:Content>
