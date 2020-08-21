<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="AddAdmin.aspx.vb" Inherits="Admin_AddAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 75px;
        }
        .style6
        {
            width: 75px;
            height: 23px;
        }
        .style7
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%;">
    <tr>
        <td style="color:Green; font-size:xx-large; font-family:Matura MT Script Capitals" 
            colspan="3">
                <asp:Label ID="lblTitle" runat="server" Text="Administration Users"></asp:Label>
            &nbsp;
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;
        </td>
        <td class="style7">
            &nbsp;
        </td>
        <td class="style7">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style5">
            User Name</td>
        <td>
            <asp:TextBox ID="txtUN" runat="server" Width="165px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            Password</td>
        <td>
            <asp:TextBox ID="txtPASS" runat="server" Width="165px" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="79px" /><asp:Button ID="BbtnClear" runat="server" Text="Clear" Width="79px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
        <asp:GridView ID="gdviewMedicine" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateColumns="False" Width="439px" 
            OnRowCommand="gdviewMedicine_RowCommand" 
            OnPageIndexChanging="gdviewMedicine_PageIndexChanging" EnableViewState="False">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:BoundField DataField="AUNme" HeaderText="User Name" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="APass" HeaderText="Password" HeaderStyle-HorizontalAlign="Left"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdDetails" runat="server" Text="Delete" CommandArgument='<%# Eval("AID") %>' CommandName="delete" />
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
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImgbtnBack" runat="server" Height="29px" 
                ImageUrl="~/Images/Buttons/Doctor/Back.png" Width="119px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>


