Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView.Export

Namespace Exporter
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Function SetGrid() As String
			If ASPxRadioButtonList1.Value.ToString() = "c" Then
				Return ASPxGridView1.ID
			Else
				Return ASPxGridView2.ID
			End If
		End Function

		Protected Sub SetHeaderStyle()
			If ASPxRadioButtonList2.Value.ToString() = "r" Then
				ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Red
				ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.MistyRose
			End If

			If ASPxRadioButtonList2.Value.ToString() = "b" Then
				ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Navy
				ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.White
			End If

			If ASPxRadioButtonList2.Value.ToString() = "g" Then
				ASPxGridViewExporter1.Styles.Header.BackColor = System.Drawing.Color.Green
				ASPxGridViewExporter1.Styles.Header.ForeColor = System.Drawing.Color.PaleGreen
			End If
		End Sub



		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)



			SetHeaderStyle()
			ASPxGridViewExporter1.GridViewID = SetGrid()
			ASPxGridViewExporter1.WriteXlsToResponse()
		End Sub
		Protected Sub ASPxGridViewExporter1_RenderBrick(ByVal sender As Object, ByVal e As ASPxGridViewExportRenderingEventArgs)


'			#Region "Styles"

			If ASPxRadioButtonList2.Value.ToString() = "r" Then

				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Title Then

					e.BrickStyle.BackColor = System.Drawing.Color.DarkRed
					e.BrickStyle.ForeColor = System.Drawing.Color.MistyRose
				End If
				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then


					e.BrickStyle.BackColor = System.Drawing.Color.MistyRose
					e.BrickStyle.ForeColor = System.Drawing.Color.Black
				End If

			End If
			If ASPxRadioButtonList2.Value.ToString() = "b" Then
				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Title Then

					e.BrickStyle.BackColor = System.Drawing.Color.DarkBlue
					e.BrickStyle.ForeColor = System.Drawing.Color.SteelBlue
				End If
				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then

					e.BrickStyle.BackColor = System.Drawing.Color.SteelBlue
					e.BrickStyle.ForeColor = System.Drawing.Color.White
				End If

			End If

			If ASPxRadioButtonList2.Value.ToString() = "g" Then
				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Title Then

					e.BrickStyle.BackColor = System.Drawing.Color.DarkGreen
					e.BrickStyle.ForeColor = System.Drawing.Color.PaleGreen
				End If
				If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then

					e.BrickStyle.BackColor = System.Drawing.Color.PaleGreen
					e.BrickStyle.ForeColor = System.Drawing.Color.Black
				End If

			End If
'			#End Region

		End Sub


		Protected Sub ASPxButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetHeaderStyle()
			ASPxGridViewExporter1.GridViewID = SetGrid()
			ASPxGridViewExporter1.WritePdfToResponse()
		End Sub
		Protected Sub ASPxButton3_Click(ByVal sender As Object, ByVal e As EventArgs)

			SetHeaderStyle()
			ASPxGridViewExporter1.GridViewID = SetGrid()
			ASPxGridViewExporter1.WriteRtfToResponse()
		End Sub
	End Class
End Namespace
