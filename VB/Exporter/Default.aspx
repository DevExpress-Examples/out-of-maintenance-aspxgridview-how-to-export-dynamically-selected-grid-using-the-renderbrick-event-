<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exporter._Default" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxGridView.Export"
    TagPrefix="dxwgv" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxPanel"
    TagPrefix="dxp" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxRoundPanel"
    TagPrefix="dxrp" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxGridView"
    TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
      <tr>
        <td style="vertical-align:top">
          
           
               
                  <dxrp:aspxroundpanel ID="ASPxRoundPanel1" runat="server" Width="200px" HeaderText="Select the grid for export">
                      <panelcollection>
                          <dxp:panelcontent runat="server">
                          
                              <dxe:aspxradiobuttonlist ID="ASPxRadioButtonList1" runat="server" SelectedIndex="0">
                      <items>
                          <dxe:listedititem Text="Categories" Value="c" />
                          <dxe:listedititem Text="Products" Value="p" />
                      </items>
                  </dxe:aspxradiobuttonlist>
                          </dxp:panelcontent>
                      </panelcollection>
                  </dxrp:aspxroundpanel>
                  <br />
                  
            <dxrp:aspxroundpanel ID="ASPxRoundPanel2" runat="server" Width="200px" HeaderText="Select the theme">
                <panelcollection>
                    <dxp:panelcontent runat="server">
                        <dxe:aspxradiobuttonlist ID="ASPxRadioButtonList2" runat="server" SelectedIndex="0">
                            <items>
                                <dxe:listedititem Text="Red" Value="r" />
                                <dxe:listedititem Text="Green" Value="g" />
                                <dxe:listedititem Text="Blue" Value="b" />
                            </items>
                        </dxe:aspxradiobuttonlist>
                    </dxp:panelcontent>
                </panelcollection>
            </dxrp:aspxroundpanel>
            <br />
                  
                  
          <table>
            <tr>
              <td>
                  <dxe:aspxbutton ID="ASPxButton1" runat="server" Text="XLS" ClientInstanceName="xlsButton" OnClick="ASPxButton1_Click" AutoPostBack="False">
                  </dxe:aspxbutton>
              </td>
              <td>
                  <dxe:aspxbutton ID="ASPxButton2" runat="server" Text="PDF" AutoPostBack="False" OnClick="ASPxButton2_Click">
                  </dxe:aspxbutton>
              </td>
              <td>
                  <dxe:aspxbutton ID="ASPxButton3" runat="server" Text="RTF" AutoPostBack="False" OnClick="ASPxButton3_Click">
                  </dxe:aspxbutton>
              </td>
            </tr>
          </table>
         
        </td>
        <td style="width:100px"></td>
        <td>
            <dxwgv:aspxgridview ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="dsCategories" KeyFieldName="CategoryID" Width="500px">
                <columns>
                    <dxwgv:gridviewdatatextcolumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="0">
                        <editformsettings Visible="False" />
                    </dxwgv:gridviewdatatextcolumn>
                    <dxwgv:gridviewdatatextcolumn FieldName="CategoryName" VisibleIndex="1">
                    </dxwgv:gridviewdatatextcolumn>
                    <dxwgv:gridviewdatatextcolumn FieldName="Description" VisibleIndex="2">
                    </dxwgv:gridviewdatatextcolumn>
                </columns>
                <settingstext Title="Categories" />
                <settings ShowTitlePanel="True" />
            </dxwgv:aspxgridview>
            <br />
            <br />
            <dxwgv:aspxgridview ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" DataSourceID="dsProduct" KeyFieldName="ProductID" Width="500px">
                <columns>
                    <dxwgv:gridviewdatatextcolumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0">
                        <editformsettings Visible="False" />
                    </dxwgv:gridviewdatatextcolumn>
                    <dxwgv:gridviewdatatextcolumn FieldName="ProductName" VisibleIndex="1">
                    </dxwgv:gridviewdatatextcolumn>
                    <dxwgv:gridviewdatatextcolumn FieldName="CategoryID" VisibleIndex="2">
                    </dxwgv:gridviewdatatextcolumn>
                    <dxwgv:gridviewdatatextcolumn FieldName="UnitPrice" VisibleIndex="3">
                    </dxwgv:gridviewdatatextcolumn>
                </columns>
                <settingstext Title="Products" />
                <settings ShowTitlePanel="True" />
            </dxwgv:aspxgridview>
        </td>
      </tr>
    </table>
    </div>
        <asp:accessdatasource ID="dsCategories" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Categories]"></asp:accessdatasource>
        <asp:accessdatasource ID="dsProduct" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [ProductID], [ProductName], [CategoryID], [UnitPrice] FROM [Products]">
        </asp:accessdatasource>
        <dxwgv:aspxgridviewexporter ID="ASPxGridViewExporter1" runat="server" OnRenderBrick="ASPxGridViewExporter1_RenderBrick">
        </dxwgv:aspxgridviewexporter>
    </form>
</body>
</html>
