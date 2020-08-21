<%@ Page Title="Channeling" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Bookings.aspx.vb" Inherits="Bookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            background-color: Transparent;
        }
        .style6
        {
            background-color: Transparent;
            width: 258px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="5">
        <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/Channeling.png" Height="55px" Width="358px" />
    </td>
  </tr>
  <tr>
    <td class="style5" colspan="2">
        <asp:Label ID="lblDID" runat="server" Text="" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="3">Doctor Name : 
        <asp:Label ID="lblDNme" runat="server" Text="" Width="300px"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">Select Date</td>
    <td class="style5" valign="top">
        <asp:TextBox ID="txtChanelDate" runat="server" Width="150px"></asp:TextBox>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:Calendar ID="calATime" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
            ForeColor="#003399" Height="200px" Width="220px">
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <WeekendDayStyle BackColor="#CCCCFF" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        </asp:Calendar>
      </td>
    <td colspan="3">&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:Label ID="lblMsgChcDate" runat="server" ForeColor="#FF3300"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2" style="font-style:oblique; font-size:xx-large; font-family:Matura MT Script Capitals; color:Green">
        <asp:Label ID="lblATime" runat="server" Text="Available Times"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2" style="color:Red;">
        <asp:Label ID="lblError" runat="server" 
            Text="Bookings are Currently Unavailable for the Specific Date, Please Try Again Later." style="text-align: center" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="5">
        <asp:GridView ID="gdviewATimes" runat="server" CellPadding="4" 
            Width="830px" AutoGenerateColumns="False" ForeColor="#333333" 
            GridLines="None" EnableModelValidation="True">
            <RowStyle BackColor="#EFF3FB" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ChannelingDate"  HeaderText="Channeling Date">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ChannelingTime"  HeaderText="Channeling Time">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="NoPatients"  HeaderText="No of Patients">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
      </td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td colspan="3" rowspan="9">&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">
        <asp:Label ID="lblSTime" runat="server" Text="Select a Time"></asp:Label>
      </td>
    <td class="style5">
        <asp:DropDownList ID="dpdwnTime" runat="server" Width="200px">
        </asp:DropDownList>
      </td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style5">
        <asp:Label ID="lblMsgChkTime" runat="server" ForeColor="#FF3300"></asp:Label>
      </td>
  </tr>
  <tr>
    <td class="style6">
        <asp:Label ID="lblPMethod" runat="server" Text="Payment Method"></asp:Label>
      </td>
    <td class="style5">
    <asp:DropDownList ID="dpdwnPay" runat="server" Width="200px">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Cash</asp:ListItem>
        <asp:ListItem>Cheaque</asp:ListItem>
        <asp:ListItem>By_Phone</asp:ListItem>
        <asp:ListItem>Credit_Card</asp:ListItem>
        </asp:DropDownList>
    </td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style5">
        <asp:Label ID="lblMsgChkPay" runat="server" ForeColor="#FF3300"></asp:Label>
      </td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style5">&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:ImageButton ID="ImgbtnSelect" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Select.png" Width="122px" Height="26px" />
      </td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="5">&nbsp;</td>
  </tr>
  </table>
</asp:Content>

