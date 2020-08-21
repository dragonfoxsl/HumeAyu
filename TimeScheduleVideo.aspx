<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="TimeScheduleVideo.aspx.vb" Inherits="TimeScheduleVideo" title="Time Schedule Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .style6
        {
        }
        .style7
        {
            width: 222px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="4">
            <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/VidCoonSchedule.PNG" Height="55px" 
                Width="521px" />
    </td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblDID" runat="server" Text="" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">Select a Date</td>
    <td class="style6">
        <asp:TextBox ID="txtTimeSchdule" runat="server" Width="150px"></asp:TextBox>
      </td>
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
        <asp:Label ID="lblCheckDate" runat="server" Font-Size="Medium"></asp:Label>
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:ImageButton ID="ImgbtnSchedule" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Select.png" Height="28px" Width="128px" />
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6">
        <asp:Label ID="lblRequest" runat="server" Text="Video Conferance Requests" style="color:Green; font-size:x-large; font-family:Cooper Std Black"
        Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td valign="top" class="style6">
        &nbsp;</td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style6" colspan="3">
                <asp:GridView ID="gvTimeScheduleVideo" runat="server" AutoGenerateColumns="False" 
                OnPageIndexChanging="gvTimeScheduleVideo_PageIndexChanging" 
                OnRowCommand="gvTimeScheduleVideo_RowCommand" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Width="683px" EnableModelValidation="True">
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="PID" HeaderText="Patient ID">
                    <ItemStyle HorizontalAlign="Center" /></asp:BoundField>
                    <asp:BoundField DataField="PDate" HeaderText="Date">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:BoundField DataField="PTime" HeaderText="Time">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:BoundField DataField="PayT" HeaderText="Payment">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:BoundField DataField="Confirm" HeaderText="Confirmed">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:BoundField DataField="ConfTime" HeaderText="Schedule Time">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:TemplateField>
                    <ItemTemplate>
                    <asp:Button ID="cmdSchedule" runat="server" Text="View" CommandArgument='<%# Eval("VBID") %>' CommandName="schedule" />
                    </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
    </td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td colspan="3">
        &nbsp;</td>
  </tr>
  </table>
</asp:Content>
