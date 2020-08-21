<%@ Page Title="Doctor Details" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="DoctorReg.aspx.vb" Inherits="DoctorReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .backMain
        {
            background-image: url('/Images/Background-Home.png');
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="HomeBackground">
<table width="100%" border="0" class="backMain">
  <tr>
    <td class="style5" colspan="4">
        <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/DocReg.png" Height="55px" Width="358px" />
      </td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:Label ID="lblUID" runat="server" Text="" Visible="false"></asp:Label>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Name</td>
    <td>
        <asp:TextBox ID="txtNme" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNme" runat="server" 
            ErrorMessage="Name Can't be Blank" Font-Size="Medium" 
            ControlToValidate="txtNme" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" valign="top">Address</td>
    <td>
        <asp:TextBox ID="txtAddress" runat="server" Width="300px" TextMode="MultiLine" 
            Height="96px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" 
            ErrorMessage="Address Can't be Blank" ControlToValidate="txtAddress" 
            Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Contact No</td>
    <td>
        <asp:TextBox ID="txtCN" runat="server" Width="200px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCN" runat="server" 
            ErrorMessage="Contact No Can't be Blank" ControlToValidate="txtCN" 
            Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Email Address</td>
    <td>
        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" 
            ErrorMessage="Email Address is Invalid" ControlToValidate="txtEmail" 
            Font-Size="Medium" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ForeColor="Red"></asp:RegularExpressionValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" valign="top">Qualifications</td>
    <td>
        <asp:TextBox ID="txtQualifications" runat="server" Width="300px" TextMode="MultiLine" 
            Height="100px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorQualific" runat="server" 
            ErrorMessage="Qualifications Must be Specified" 
            ControlToValidate="txtQualifications" Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" valign="top">Experiance</td>
    <td>
        <asp:TextBox ID="txtExp" runat="server" Width="300px" TextMode="MultiLine" Height="100px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorExp" runat="server" 
            ErrorMessage="Experience Must be Specified" ControlToValidate="txtExp" 
            Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" valign="top">Speciality</td>
    <td>
        <asp:TextBox ID="txtSpec" runat="server" Width="300px" TextMode="MultiLine" Height="100px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Username</td>
    <td>
        <asp:TextBox ID="txtUN" runat="server" Width="200px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUN" runat="server" 
            ErrorMessage="Username Can't be Blank" Font-Size="Medium" 
            ControlToValidate="txtUN" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Password</td>
    <td>
        <asp:TextBox ID="txtPW" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPW" runat="server" 
            ErrorMessage="Password Can't be Blank" Font-Size="Medium" 
            ControlToValidate="txtPW" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Re - Type Password</td>
    <td>
        <asp:TextBox ID="txtRPW" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:CompareValidator ID="CompareValidatorRPW" runat="server" 
            ErrorMessage="Passwords Dose Not Match" ControlToCompare="txtPW" 
            ControlToValidate="txtRPW" Font-Size="Medium" ForeColor="Red"></asp:CompareValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Image</td>
    <td>
        <asp:FileUpload ID="FileUploadImageDoc" runat="server" Width="300px" />
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td>
        <asp:ImageButton ID="ImgbtnSubmit" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Reg/Submit.png" Width="102" Height="25px"/>
        <asp:ImageButton ID="ImgbtnChg" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Reg/Change.png" Width="102" Height="25px"/>
        <asp:ImageButton ID="ImgbtnClr" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Comment/Clear.png" Width="102" Height="25px"/>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

