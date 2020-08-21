<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="AdminDBPayment.aspx.vb" Inherits="Admin_AdminDBPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%;">
        <tr>
            <td colspan="3" style="color:Green; font-size:xx-large; font-family:Matura MT Script Capitals">
                <asp:Label ID="lblTitle" runat="server" Text="Payment Confirmation"></asp:Label>
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
            <td style="color:Green; font-size:medium; font-family:Arial Black">
                <asp:Label ID="lblPa1" runat="server" Text="Channeling Payment Confirmation"></asp:Label></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            <asp:GridView ID="gdviewTime" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" 
            GridLines="None" Width="100%" EnableViewState="false" OnPageIndexChanging="gdviewTime_PageIndexChanging" OnRowCommand="gdviewTime_RowCommand">
            <RowStyle BackColor="#E3EAEB" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="BIDT" HeaderText="ID" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="DID" HeaderText="Doctor ID" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PID" HeaderText="Patient ID" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="BDate" HeaderText="Date" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="Time" HeaderText="Time" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PayType" HeaderText="Payment Method" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="Confirm" HeaderText="Confirmation" HeaderStyle-HorizontalAlign="Left"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdSelect" runat="server" Text="Confirm" CommandArgument='<%# Eval("BIDT") %>' CommandName="select" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
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
            <td style="color:Green; font-size:medium; font-family:Arial Black">
                <asp:Label ID="lblPa2" runat="server" Text="Video Conferancing Payment Confirmation"></asp:Label></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            <asp:GridView ID="gdviewTime0" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" 
            GridLines="None" Width="100%" EnableViewState="false" 
                    OnPageIndexChanging="gdviewTime_PageIndexChanging" 
                    OnRowCommand="gdviewTime_RowCommand">
            <RowStyle BackColor="#E3EAEB" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DID" HeaderText="Doctor ID" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PID" HeaderText="Patient ID" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PDate" HeaderText="Date" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PTime" HeaderText="Time" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="Confirm" HeaderText="Doctor Confirmation" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="ConfTime" HeaderText="Confirmed Time" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="ConfP" HeaderText="Patient Confirmation" HeaderStyle-HorizontalAlign="Left"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdSelect0" runat="server" Text="Confirm" CommandArgument='<%# Eval("VBID") %>' CommandName="select2"/>
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </td>
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

