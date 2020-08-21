<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="TimeSchedule.aspx.vb" Inherits="TimeSchedule" title="Time Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .style6
        {
            width: 513px;
        }
        #Button1
        {
            width: 83px;
        }
        .style7
        {
            width: 206px;
        }
    </style>
    <script type="text/javascript">
    function Redirect()
    {
        detailedresults = window.open('ViewTimeSchedule.aspx');
    }

    function RedirectCustomer() {
        detailedresults = window.open('ViewSchedule.aspx');
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="4">
            <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/CTime.png" Height="55px" 
                Width="414px" />
    </td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblDID" runat="server" Text="" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr><tr>
    <td class="style7">Select a Date</td>
    <td class="style6">
        <asp:TextBox ID="txtTimeSchdule" runat="server" Width="150px"></asp:TextBox>
      </td>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
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
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblCheckDate" runat="server" Font-Size="Medium"></asp:Label><br />
        <input id="btnViewID" type="button" value="View Schedule" onclick="Redirect()" />
        <input id="btnViewSchedule" type="button" value="View Customer Schedule" onclick="RedirectCustomer()" /></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">Time</td>
    <td class="style6">
        <asp:DropDownList ID="dpdwnTime" runat="server" Width="200px">
            <asp:ListItem>10:00 am - 11:00 am</asp:ListItem>
            <asp:ListItem>11:00 am - 12:00 pm</asp:ListItem>
            <asp:ListItem>02:00 pm - 03:00 pm</asp:ListItem>
            <asp:ListItem>03:00 pm - 04:00 pm</asp:ListItem>
            <asp:ListItem>04:00 pm - 05:00 pm</asp:ListItem>
            <asp:ListItem>06:00 pm - 07:00 pm</asp:ListItem>
            <asp:ListItem>07:00 pm - 08:00 pm</asp:ListItem>
            <asp:ListItem>08:00 pm - 09:00 pm</asp:ListItem>
        </asp:DropDownList>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="dpdwnTime" 
            ErrorMessage="Please Select a Appropriate Time" Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">No of Patients</td>
    <td class="style6">
        <asp:TextBox ID="txtNoPat" runat="server" Width="200px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblCheckPatient" runat="server" Font-Size="Medium"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td valign="top" class="style6">
        <asp:ImageButton ID="ImgbtnSchedule" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Schedule.png" Height="28px" Width="128px" />
        <asp:ImageButton ID="ImgbtnClear" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Comment/Clear.png" Height="28px" 
            Width="128px" />
      </td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td colspan="3">
        &nbsp;</td>
  </tr>
  </table>
</asp:Content>


