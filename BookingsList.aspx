<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="BookingsList.aspx.vb" Inherits="BookingsList" title="Bookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="5">
        <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/Images/Title/Reg/DocList.png" />
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="5" align="center" valign="top">
        <asp:GridView ID="gdviewDoctor" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" 
            GridLines="None" Width="100%" EnableViewState="false" OnPageIndexChanging="gdviewDoctor_PageIndexChanging" OnRowCommand="gdviewDoctor_RowCommand">
            <RowStyle BackColor="#E3EAEB" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ImageField DataImageUrlField="DImage" HeaderText="Image">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
                <asp:BoundField DataField="DName" HeaderText="Doctor Name" />
                <asp:BoundField DataField="DQualifications" HeaderText="Qualifications"/>
                <asp:BoundField DataField="DExperience" HeaderText="Experience"/>
                <asp:BoundField DataField="DSpecility" HeaderText="Specility"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdSelect" runat="server" Text="Schedule" CommandArgument='<%# Eval("DID") %>' CommandName="select" />
                    <asp:Button ID="cmdVideo" runat="server" Text="Video Channeling" CommandArgument='<%# Eval("DID") %>' CommandName="video" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
      </td>
  </tr>
  <tr>
    <td colspan="5" align="center" valign="top">
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="Large" ForeColor="Red"></asp:Label>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</asp:Content>

