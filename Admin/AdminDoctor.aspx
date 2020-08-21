<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="AdminDoctor.aspx.vb" Inherits="Admin_AdminDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            height: 46px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%;">
        <tr>
            <td colspan="3" 
                style="color:Green; font-size:xx-large; font-family:Matura MT Script Capitals" 
                class="style5">
                <asp:Label ID="lblTitle" runat="server" Text="Doctor Validation"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
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
                <asp:ImageField DataImageUrlField="DImage" HeaderText="Image" HeaderStyle-HorizontalAlign="Left">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
                <asp:BoundField DataField="DName" HeaderText="Doctor Name" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="DQualifications" HeaderText="Qualifications" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="DExperience" HeaderText="Experience" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="DValidity" HeaderText="Validity" HeaderStyle-HorizontalAlign="Left"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdSelect" runat="server" Text="Validate" CommandArgument='<%# Eval("DID") %>' CommandName="validate" />
                    <asp:Button ID="Button1" runat="server" Text="Change" CommandArgument='<%# Eval("DID") %>' CommandName="change" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
                </td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td>
            <asp:ImageButton ID="ImgbtnBack" runat="server" Height="29px" ImageUrl="~/Images/Buttons/Doctor/Back.png" Width="119px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

