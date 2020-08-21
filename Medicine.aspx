<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Medicine.aspx.vb" Inherits="Medicine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="HomeBackground">
    <table width="100%" border="0">
  <tr>
    <td colspan="4" align="center">
        <asp:Image ID="myHeading" runat="server" 
            ImageUrl="~/Images/Title/Herbal Plants/Medicine.png" Height="73px" 
            Width="420px" />
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="4" align="center">
        <asp:GridView ID="gdviewMedicine" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateColumns="False" Width="664px" 
            OnRowCommand="gdviewMedicine_RowCommand" 
            OnPageIndexChanging="gdviewMedicine_PageIndexChanging" EnableViewState="False">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:ImageField DataImageUrlField="PLImage" HeaderText="Image">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
                <asp:BoundField DataField="PLNme" HeaderText="Plant Name" />
                <asp:BoundField DataField="PLBotnicalNme" HeaderText="Botnical Name"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdDetails" runat="server" Text="Details" CommandArgument='<%# Eval("PLID") %>' CommandName="details" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

