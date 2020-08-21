<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Payment.aspx.vb" Inherits="Payment" title="Payment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        	volume:loud
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="4">
        <asp:Image ID="ImageTitle" runat="server" 
            ImageUrl="~/Images/Title/Reg/Payment.PNG" Height="59px" Width="200px"/>
      </td>
  </tr>
  <tr>
    <td colspan="4" style="color:Red">A Standard Chanelling Fee of US $5 will be Charged</td>
  </tr>
  <tr>
    <td colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td colspan="4">
        <asp:Panel ID="PanelCash" runat="server">
        <table width="100%" border="0">
          <tr>
            <td colspan="4" style="font-style:oblique; font-size:xx-large; font-family:Blackadder ITC; color:Green">
            Cash Payments
            </td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">Please forward your Payments Using Wire Transfer to Account Number 0009273553432</td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">
                <asp:Image ID="ImageCash" runat="server" ImageUrl="~/Images/Payment/wiretransfer.gif"/>
              </td>
          </tr>
        </table>
        </asp:Panel>
      </td>
  </tr>
  <tr>
    <td colspan="4"></td>
  </tr>
  <tr>
    <td colspan="4">
        <asp:Panel ID="PanelCheaque" runat="server">
        <table width="100%" border="0">
          <tr>
            <td colspan="4" style="font-style:oblique; font-size:xx-large; font-family:Blackadder ITC; color:Green">
            Cheque Payments
            </td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="2">Please forward your Cheques in behalf of HumeAyu.com</td>
              <td colspan="2">
                  &nbsp;</td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">
            <asp:Image ID="ImageCheaque" runat="server" ImageUrl="~/Images/Payment/cheque.jpg" 
                    Height="135px" Width="222px"/>
            </td>
          </tr>
        </table>
        </asp:Panel>
      </td>
  </tr>
  <tr>
    <td colspan="4"></td>
  </tr>
  <tr>
    <td colspan="4">
        <asp:Panel ID="PanelCreditCard" runat="server">
        <table width="100%" border="0">
          <tr>
            <td colspan="4" style="font-style:oblique; font-size:xx-large; font-family:Blackadder ITC; color:Green">
            Credit Card Payment
            </td>
          </tr>
          <tr>
            <td class="style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">Please Fill the Following Details</td>
          </tr>
          <tr>
            <td class="style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2" rowspan="6">
                <asp:Image ID="ImageCreditCard" runat="server" 
                    ImageUrl="~/Images/Payment/cred.jpg" Height="153px" Width="195px"/>
              </td>
          </tr>
          <tr>
            <td class="style5">Card Number</td>
            <td>
                <asp:TextBox ID="txtCardNo" runat="server" Width="200px"></asp:TextBox>
              </td>
          </tr>
            <tr>
                <td class="style5">
                    Expiry Date</td>
                <td>
                    <asp:TextBox ID="txtExpDate" runat="server"  Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Amount To Be Paied</td>
                <td>
                    <asp:TextBox ID="txtAmount" runat="server"  Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="61px" />
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" colspan="4">
                    &nbsp;</td>
            </tr>
        </table>
        </asp:Panel>
      </td>
  </tr>
  <tr>
    <td colspan="4"></td>
  </tr>
  <tr>
    <td colspan="4">
        <asp:Panel ID="PanelByPhone" runat="server">
        <table width="100%" border="0">
          <tr>
            <td colspan="4" style="font-style:oblique; font-size:xx-large; font-family:Blackadder ITC; color:Green">
            Pay By Phone
            </td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">Call the Number (+94)0112772278</td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td colspan="4">
                <asp:Image ID="ImagePhone" runat="server" 
                    ImageUrl="~/Images/Payment/paybyphone.jpg" Height="170px" Width="119px" />
              </td>
          </tr>
        </table>
        </asp:Panel>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>
        <asp:ImageButton ID="ImgbtnBack" runat="server" Height="27px" 
            ImageUrl="~/Images/Buttons/Doctor/Back.png" Width="107px" />
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</asp:Content>

