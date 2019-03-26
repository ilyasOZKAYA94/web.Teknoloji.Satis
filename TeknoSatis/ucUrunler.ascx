<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucUrunler.ascx.cs" Inherits="TeknoSatis.ucUrunler" %>
<div class="container">
    <div class="row">
        <asp:DataList ID="dlstUrunler" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="3" Width="801px" BackColor="White" OnItemCommand="dlstUrunler_ItemCommand" >
            <ItemTemplate>
                <div>
                    <span class="badge default-bg">%25 indirim</span>
                </div>
                <h3>
                    <asp:Label ID="lblUrunAdi" runat="server" Text='<%#Eval("UrunAdi") %>'></asp:Label></h3>
                <div>
                <img src='<%#Eval("Resimyolu1") %>' alt='<%#Eval("UrunAdi") %>'  height="150"  /></div>
                <div><strong>Özel indirimli Kdv dahil fiyatlardır.</strong></div>
                <div><asp:Label ID="lblFiyat" runat="server" Text='<%#Eval("Fiyat", "{0:C}") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtAdet" runat="server" TextMode="Number" Min="1" Max='<%#Eval("Miktar") %>' Width="30" Text="1"></asp:TextBox></div>
                <div style="text-align:center">
                    <asp:Button ID="btnSepeteEkle" CssClass="btn btn-Primary" runat="server" Text="Sepete Ekle" CommandName="sepet" CommandArgument='<%#Eval("Id") %>'/>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>