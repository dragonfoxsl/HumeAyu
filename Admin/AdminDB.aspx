<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="AdminDB.aspx.vb" Inherits="Admin_AdminDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 142px;
        }
        .style6
        {
            width: 142px;
            height: 23px;
        }
        .style7
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%;">
        <tr>
            <td colspan="3" style="color:Green; font-size:xx-large; font-family:Matura MT Script Capitals">
                <asp:Label ID="lblTitle" runat="server" Text="Medical Plants Database"></asp:Label>
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
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="style5">
                            Plant Name</td>
                        <td>
                            <asp:TextBox ID="txtPNme" runat="server" Width="313px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Botnical Name</td>
                        <td>
                            <asp:TextBox ID="txtBNme" runat="server" Width="313px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5" style="vertical-align:top">
                            Description</td>
                        <td>
                            <asp:TextBox ID="txtDes" runat="server" Height="100px" Width="313px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5" style="vertical-align:top">
                            Image</td>
                        <td>
                            <asp:FileUpload ID="FileUploadImage" runat="server" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6" style="vertical-align:top">
                            </td>
                        <td class="style7">
                            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                        </td>
                        <td class="style7">
                            </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnAdd" runat="server" Height="22px" Text="Add" 
                                Width="113px" />
                            <asp:Button ID="btnClear" runat="server" Height="22px" Text="Clear" 
                                Width="113px" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
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
    <td colspan="5" valign="top">
        <asp:GridView ID="gdviewMedicine" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateColumns="False" Width="664px" 
            OnRowCommand="gdviewMedicine_RowCommand" 
            OnPageIndexChanging="gdviewMedicine_PageIndexChanging" EnableViewState="False">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:ImageField DataImageUrlField="PLImage" HeaderText="Image" HeaderStyle-HorizontalAlign="Left">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
                <asp:BoundField DataField="PLNme" HeaderText="Plant Name" HeaderStyle-HorizontalAlign="Left"/>
                <asp:BoundField DataField="PLBotnicalNme" HeaderText="Botnical Name" HeaderStyle-HorizontalAlign="Left"/>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="cmdDetails" runat="server" Text="Delete" CommandArgument='<%# Eval("PLID") %>' CommandName="delete" />
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

