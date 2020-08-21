<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Video.aspx.vb" Inherits="Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 131px;
        }
        .style6
        {
            width: 845px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<table style="width: 100%;" class="HomeBackground">
    <tr>
        <td class="style5">
            &nbsp;
        </td>
        <td class="style6">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;
        </td>
        <td class="style6">
            <script type="text/javascript" src="http://videocallroom.oovoo.com/oovoomelink/codelib/oovoorooms.js"></script>
            <script type='text/javascript'>
                roomProps.roomID = '967FD61866E0517AE04400144F7E8E22';
                roomProps.width = '800';
                roomProps.height = '650';
                roomProps.backgroundColor = '#666666';
                roomProps.captionColor = '#FFFFFF';
                roomProps.captionText = 'HumeAyu';
                var myRoom = CreateRoom();
            </script>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;
        </td>
        <td class="style6">
            <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
</table>
</center>
</asp:Content>

