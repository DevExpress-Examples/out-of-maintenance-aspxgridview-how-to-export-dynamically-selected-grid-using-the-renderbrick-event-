using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView.Export;

namespace Exporter
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string SetGrid()
        {
            if (ASPxRadioButtonList1.Value.ToString() == "c")
            {
                return ASPxGridView1.ID;
            }
            else
            {
                return ASPxGridView2.ID;
            }
        }

        protected void SetHeaderStyle()
        {
            if (ASPxRadioButtonList2.Value.ToString() == "r")
            {
                ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Red;
                ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.MistyRose;
            }

            if (ASPxRadioButtonList2.Value.ToString() == "b")
            {
                ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Navy;
                ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.White;
            }

            if (ASPxRadioButtonList2.Value.ToString() == "g")
            {
                ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Green;
                ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.PaleGreen;
            }
        }



        protected void ASPxButton1_Click(object sender, EventArgs e)
        {



            SetHeaderStyle();
            ASPxGridViewExporter1.GridViewID = SetGrid();
            ASPxGridViewExporter1.WriteXlsToResponse();
        }
        protected void ASPxGridViewExporter1_RenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e)
        {


            #region Styles

            if (ASPxRadioButtonList2.Value.ToString() == "r")
            {

                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Title)
                {

                    e.BrickStyle.BackColor = System.Drawing.Color.DarkRed;
                    e.BrickStyle.ForeColor = System.Drawing.Color.MistyRose;
                }
                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Data)
                {


                    e.BrickStyle.BackColor = System.Drawing.Color.MistyRose;
                    e.BrickStyle.ForeColor = System.Drawing.Color.Black;
                }

            }
            if (ASPxRadioButtonList2.Value.ToString() == "b")
            {
                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Title)
                {

                    e.BrickStyle.BackColor = System.Drawing.Color.DarkBlue;
                    e.BrickStyle.ForeColor = System.Drawing.Color.SteelBlue;
                }
                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Data)
                {

                    e.BrickStyle.BackColor = System.Drawing.Color.SteelBlue;
                    e.BrickStyle.ForeColor = System.Drawing.Color.White;
                }

            }

            if (ASPxRadioButtonList2.Value.ToString() == "g")
            {
                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Title)
                {

                    e.BrickStyle.BackColor = System.Drawing.Color.DarkGreen;
                    e.BrickStyle.ForeColor = System.Drawing.Color.PaleGreen;
                }
                if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Data)
                {

                    e.BrickStyle.BackColor = System.Drawing.Color.PaleGreen;
                    e.BrickStyle.ForeColor = System.Drawing.Color.Black;
                }

            }
            #endregion

        }


        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            SetHeaderStyle();
            ASPxGridViewExporter1.GridViewID = SetGrid();
            ASPxGridViewExporter1.WritePdfToResponse();
        }
        protected void ASPxButton3_Click(object sender, EventArgs e)
        {

            SetHeaderStyle();
            ASPxGridViewExporter1.GridViewID = SetGrid();
            ASPxGridViewExporter1.WriteRtfToResponse();
        }
    }
}
