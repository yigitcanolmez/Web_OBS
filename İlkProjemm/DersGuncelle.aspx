<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DersGuncelle.aspx.cs" Inherits="İlkProjemm.DersGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="Form1" runat="server">    
    <div class="form-group">
      
            <div>
                <asp:Label for="TxtDersID" runat="server">DERS ID</asp:Label>
                <asp:TextBox ID="TxtDersID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           
          <br />
            <div>
                <asp:Label for="TxtDers" runat="server">Ders Adı</asp:Label>
                <asp:TextBox ID="TxtDers" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        
            </div>
             <asp:Button ID="Button1" runat="server" Text="Ders Güncelle" CssClass="btn btn-info" OnClick="Button1_Click" />
            </form>
</asp:Content>
