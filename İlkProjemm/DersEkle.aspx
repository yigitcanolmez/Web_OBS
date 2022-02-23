<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="İlkProjemm.DersEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;
    <form id="Form1" runat="server">
        <div class="form-group">
         

            <div>
                <asp:Label for="TxtDers" runat="server">Ders Adı</asp:Label>
                <asp:TextBox ID="TxtDers" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        
            </div>
             <asp:Button ID="Button1" runat="server" Text="Ders Oluştur" CssClass="btn btn-info" OnClick="Button1_Click" />
            </form>

</asp:Content>
