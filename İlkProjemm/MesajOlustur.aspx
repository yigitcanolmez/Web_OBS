<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="MesajOlustur.aspx.cs" Inherits="İlkProjemm.MesajOlustur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtGondereen" runat="server">GÖNDEREN</asp:Label>
                <asp:TextBox ID="TxtGondereen" runat="server" CssClass="form-control" Enabled="False">10</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtAlıcı" runat="server">Alıcı</asp:Label>
                <asp:TextBox ID="TxtAlıcı" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtMesajBaslik" runat="server">Mesaj Başlık</asp:Label>
                <asp:TextBox ID="TxtMesajBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TxtMesajIcerik" runat="server">Mesaj İçerik</asp:Label>
                <textarea id="TxtMesajIcerik" cols="20" rows="6" class="form-control" runat="server"></textarea>

            </div>


        </div>
        <asp:Button ID="BtnGonder" runat="server" Text="Mesaj Gönder" CssClass="btn btn-info" OnClick="BtnGonder_Click" />
    </form>


</asp:Content>
