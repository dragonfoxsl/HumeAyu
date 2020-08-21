<%@ Page Title="User Registration" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="UserRegister.aspx.vb" Inherits="UserRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .MyFont
    {
       	font-style:oblique;
        font-size:large;
    }
    .style7
    {
        height: 24px;
    }
    .backMain
    {
        background-image: url('/Images/Background-Home.png');
    }
    .style9
    {
        height: 24px;
        width: 202px;
    }
    .style10
    {
        }
        .style11
        {
            width: 760px;
        }
        .style12
        {
            height: 24px;
            width: 760px;
        }
        .style13
        {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="MyFont">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="4">
        <asp:Image ID="ImgTitleUReg" runat="server" Height="55px" 
            ImageUrl="~/Images/Title/Reg/Userreg.png" Width="358px" />
      </td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:TextBox ID="txtPID" runat="server" Visible="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">First Name</td>
    <td class="style11">
        <asp:TextBox ID="txtFNme" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="First Name can't be blank" ControlToValidate="txtFNme" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Last Name</td>
    <td class="style11">
        <asp:TextBox ID="txtLNme" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Last Name can't be blank" ControlToValidate="txtLNme" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr valign="top">
    <td class="style13" valign="top">Address</td>
    <td valign="top" class="style11">
        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Height="117px" 
            Width="298px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="Address can't be blank" ControlToValidate="txtAddress" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Email Address</td>
    <td class="style11">
        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="Email Address is Invalid" ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            Font-Size="Medium"></asp:RegularExpressionValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Contact No</td>
    <td class="style11">
        <asp:TextBox ID="txtTP" runat="server" Width="200px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="Contact Number Can't be blank" ControlToValidate="txtTP" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Date of Birth</td>
    <td valign="bottom" class="style11">
        <asp:TextBox ID="txtDOB" runat="server" Width="200px"></asp:TextBox>
        <asp:ImageButton ID="ImgbtnCal" runat="server" AlternateText="C" 
            ImageUrl="~/Images/Buttons/Button_Reg/Calender.png" Height="18px" 
            Width="20px" />
      &nbsp; MM/DD/YYYY</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:Calendar ID="CalDOB" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
            ForeColor="#003399" Height="193px" Width="220px" Visible="false">
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
    <td class="style13">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Date of Joined</td>
    <td class="style11">
        <asp:TextBox ID="txtDOJ" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">UserName</td>
    <td class="style11">
        <asp:TextBox ID="txtUN" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ErrorMessage="A Username Must be Specified" ControlToValidate="txtUN" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style13">Password</td>
    <td class="style11">
        <asp:TextBox ID="txtPW" runat="server" Width="300px" TextMode="Password" MaxLength="20"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style9"></td>
    <td class="style12">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ErrorMessage="A Password Must be Specified" ControlToValidate="txtPW" 
            Font-Size="Medium"></asp:RequiredFieldValidator>
      </td>
    <td class="style7"></td>
    <td class="style7"></td>
  </tr>
    <tr>
    <td class="style13">Re - Type Password</td>
    <td class="style11">
        <asp:TextBox ID="txtRPW" runat="server" Width="300px" TextMode="Password" MaxLength="20"></asp:TextBox>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Passwords Do Not Match" ControlToCompare="txtPW" 
            ControlToValidate="txtRPW" Font-Size="Medium"></asp:CompareValidator>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style10" colspan="4">&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:CheckBox ID="cbxTerms" runat="server" Text="I have Read and accept the Terms and Conditions of HumeAyu.com" Font-Bold="true"/>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
    <asp:Label ID="lblCheck" runat="server" Text="" ForeColor="Red"></asp:Label>    
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">
        <asp:ImageButton ID="ImgbtnSubmit" runat="server" Height="25px" 
            ImageUrl="~/Images/Buttons/Button_Reg/Submit.png" Width="102px" Visible="false"/>
        <asp:ImageButton ID="lmgbtnChage" runat="server" Height="25px"
            ImageUrl="~/Images/Buttons/Button_Reg/Change.png" Width="102px"  Visible="false"/>
        <asp:ImageButton ID="ImgbtnClr" runat="server" Height="25px"
            ImageUrl="~/Images/Buttons/Button_Comment/Clear.png" Width="102px"  Visible="false"/>
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style13">&nbsp;</td>
    <td class="style11">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td colspan="4">&nbsp;</td>
  </tr>
    </table>
</div>
</asp:Content>

