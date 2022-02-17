<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruEkle.aspx.cs" Inherits="İlkProjemm.DuyuruEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtDuyuruOgrt" runat="server">Duyuru Öğretmen</asp:Label>
                <asp:DropDownList ID="TxtDuyuruOgrt" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <div>
                <asp:Label for="TxtDuyuruBaslik" runat="server">Duyuru Başlık</asp:Label>
                <asp:TextBox ID="TxtDuyuruBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtDuyuruIcerik" runat="server">Duyuru İçerik</asp:Label>
                <textarea id="TxtDuyuruIcerik" cols="20" rows="6" class="form-control" runat="server"></textarea>

            </div>
            </div>
             <asp:Button ID="Button1" runat="server" Text="Duyuru Oluştur" CssClass="btn btn-info" OnClick="Button1_Click" />
            </form>





</asp:Content>
