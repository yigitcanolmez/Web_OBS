<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="İlkProjemm.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
            <th scope="col">ID</th>
            <th scope="col">AD</th>
            <th scope="col">SOYAD</th>
            <th scope="col">TELEFON</th>
            <th scope="col">MAİL</th>
            <th scope="col">ŞİFRE</th>
            <th scope="col">FOTOĞRAF LİNK</th>
            <th scope="col">İŞLEMLER</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRID") %></td>
                        <td><%#Eval("OGRAD") %></td>
                        <td><%#Eval("OGRSOYAD") %></td>
                        <td><%#Eval("OGRTELEFON") %></td>
                        <td><%#Eval("OGRMAİL") %></td>
                        <td><%#Eval("OGRSIFRE") %></td>
                        <td><%#Eval("OGRFOTOGRAF") %></td>
                        
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgrSil.aspx?OGRID="+Eval("OGRID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2"   NavigateUrl='<%#"~/OgrGuncelle.aspx?OGRID="+Eval("OGRID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                        </td>
              

                    </tr>
  
                </ItemTemplate>



            </asp:Repeater>

        </tbody>
    </table>
    


</asp:Content>
<%--  <th scope="row">1</th>--%>
