<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="PatientList.aspx.vb" Inherits="PatientList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="5" style="color:Green; font-family:@Malgun Gothic; font-size:xx-large; font-style:oblique; font-weight:200; font-variant:normal">
        Patient List</td>
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
    <asp:GridView ID="gdviewPatient" runat="server" CellPadding="4" 
            ForeColor="#333333" AutoGenerateColumns="False" 
            GridLines="None" Width="650px" EnableViewState="false" 
            OnPageIndexChanging="gdviewPatient_PageIndexChanging" 
            OnRowCommand="gdviewPatient_RowCommand">
            <RowStyle BackColor="#E3EAEB" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="PID" HeaderText="Patient ID" />
                <asp:BoundField DataField="PFirstName" HeaderText="First Name" />
                <asp:BoundField DataField="PLastName" HeaderText="Last Name" />
                <asp:BoundField DataField="PEmail" HeaderText="Email Address"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdDetails" runat="server" Text="Details" CommandArgument='<%# Eval("PID") %>' CommandName="details" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
      </td>
  </tr>
  <tr>
    <td colspan="5">
    <center>
    </center>
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

