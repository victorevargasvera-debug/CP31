using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Xml;
using DevAge.Drawing;
using DevAge.Windows.Forms;
using SourceGrid.Cells;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Exporter
{
	// Token: 0x02000390 RID: 912
	internal class HTML
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x00090A68 File Offset: 0x0008EC68
		public HTML(global::SourceGrid.Exporter.ExportHTMLMode p_Mode, string p_ImageFullPath, string p_ImageRelativePath, global::System.IO.Stream p_HtmlStream)
		{
			this.m_Mode = p_Mode;
			this.m_Stream = p_HtmlStream;
			this.m_ImageFullPath = p_ImageFullPath;
			this.m_ImageRelativePath = p_ImageRelativePath;
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x00090AA8 File Offset: 0x0008ECA8
		public virtual global::SourceGrid.Exporter.ExportHTMLMode Mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x00090AB4 File Offset: 0x0008ECB4
		public virtual string[] EmbeddedImagesPath
		{
			get
			{
				string[] array = new string[this.m_EmbeddedImagesPath.Count];
				this.m_EmbeddedImagesPath.Values.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00090AEC File Offset: 0x0008ECEC
		public virtual void ClearEmbeddedImages()
		{
			this.m_EmbeddedImagesPath.Clear();
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x00090AFC File Offset: 0x0008ECFC
		public virtual global::System.IO.Stream Stream
		{
			get
			{
				return this.m_Stream;
			}
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00090B04 File Offset: 0x0008ED04
		public virtual string ExportImage(global::System.Drawing.Image p_Image)
		{
			string text;
			if (this.m_EmbeddedImagesPath.ContainsKey(p_Image))
			{
				text = (string)this.m_EmbeddedImagesPath[p_Image];
			}
			else
			{
				text = global::System.IO.Path.Combine(this.m_ImageFullPath, global::System.IO.Path.GetTempFileName() + ".jpg");
				p_Image.Save(text, global::System.Drawing.Imaging.ImageFormat.Jpeg);
				this.m_EmbeddedImagesPath.Add(p_Image, text);
			}
			return text.Replace(this.m_ImageFullPath, this.m_ImageRelativePath);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00090B88 File Offset: 0x0008ED88
		public static string ColorToHTML(global::System.Drawing.Color p_Color)
		{
			return global::System.Drawing.ColorTranslator.ToHtml(global::System.Drawing.Color.FromArgb((int)p_Color.A, (int)p_Color.R, (int)p_Color.G, (int)p_Color.B));
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00090BC0 File Offset: 0x0008EDC0
		public static string BorderToHTMLStyle(global::DevAge.Drawing.BorderLine p_Border)
		{
			if (p_Border.Width > 0f)
			{
				return p_Border.Width.ToString() + "px solid " + global::SourceGrid.Exporter.HTML.ColorToHTML(p_Border.Color);
			}
			return "none";
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00090BFC File Offset: 0x0008EDFC
		public static string BorderToHTMLStyle(global::DevAge.Drawing.IBorder border)
		{
			if (border is global::DevAge.Drawing.RectangleBorder)
			{
				global::DevAge.Drawing.RectangleBorder rectangleBorder = (global::DevAge.Drawing.RectangleBorder)border;
				return string.Concat(new string[]
				{
					"border-top:",
					global::SourceGrid.Exporter.HTML.BorderToHTMLStyle(rectangleBorder.Top),
					";border-right:",
					global::SourceGrid.Exporter.HTML.BorderToHTMLStyle(rectangleBorder.Right),
					";border-bottom:",
					global::SourceGrid.Exporter.HTML.BorderToHTMLStyle(rectangleBorder.Bottom),
					";border-left:",
					global::SourceGrid.Exporter.HTML.BorderToHTMLStyle(rectangleBorder.Left),
					";"
				});
			}
			return string.Empty;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00090CBC File Offset: 0x0008EEBC
		public static void ExportHTML_Element_Font(global::System.Xml.XmlTextWriter p_Writer, string p_DisplayText, global::System.Drawing.Font p_Font)
		{
			if (p_Font != null)
			{
				p_Writer.WriteAttributeString("style", "font-size:" + p_Font.SizeInPoints + "pt");
				if (p_Font.Bold)
				{
					p_Writer.WriteStartElement("b");
				}
				if (p_Font.Underline)
				{
					p_Writer.WriteStartElement("u");
				}
				if (p_Font.Italic)
				{
					p_Writer.WriteStartElement("i");
				}
			}
			if (p_DisplayText == null || p_DisplayText.Trim().Length <= 0)
			{
				p_Writer.WriteRaw("&nbsp;");
			}
			else
			{
				p_Writer.WriteString(p_DisplayText);
			}
			if (p_Font != null)
			{
				if (p_Font.Italic)
				{
					p_Writer.WriteEndElement();
				}
				if (p_Font.Underline)
				{
					p_Writer.WriteEndElement();
				}
				if (p_Font.Bold)
				{
					p_Writer.WriteEndElement();
				}
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00090DA4 File Offset: 0x0008EFA4
		public void Export(global::SourceGrid.GridVirtual grid)
		{
			global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(this.Stream, global::System.Text.Encoding.UTF8);
			if ((this.Mode & global::SourceGrid.Exporter.ExportHTMLMode.HTMLAndBody) == global::SourceGrid.Exporter.ExportHTMLMode.HTMLAndBody)
			{
				xmlTextWriter.WriteStartElement("html");
				xmlTextWriter.WriteStartElement("body");
			}
			xmlTextWriter.WriteStartElement("table");
			xmlTextWriter.WriteAttributeString("cellspacing", "0");
			xmlTextWriter.WriteAttributeString("cellpadding", "0");
			for (int i = 0; i < grid.Rows.Count; i++)
			{
				xmlTextWriter.WriteStartElement("tr");
				for (int j = 0; j < grid.Columns.Count; j++)
				{
					global::SourceGrid.Cells.ICellVirtual cell = grid.GetCell(i, j);
					global::SourceGrid.Position pPosition = new global::SourceGrid.Position(i, j);
					global::SourceGrid.CellContext context = new global::SourceGrid.CellContext(grid, pPosition, cell);
					this.ExportHTMLCell(context, xmlTextWriter);
				}
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.WriteEndElement();
			if ((this.Mode & global::SourceGrid.Exporter.ExportHTMLMode.HTMLAndBody) == global::SourceGrid.Exporter.ExportHTMLMode.HTMLAndBody)
			{
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.Flush();
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00090EA4 File Offset: 0x0008F0A4
		protected virtual void ExportHTMLCell(global::SourceGrid.CellContext context, global::System.Xml.XmlTextWriter writer)
		{
			if (context.Cell == null)
			{
				writer.WriteStartElement("td");
				writer.WriteRaw("&nbsp;");
				return;
			}
			global::SourceGrid.Range range = context.Grid.PositionToCellRange(context.Position);
			if (range.Start != context.Position)
			{
				return;
			}
			writer.WriteStartElement("td");
			if (range.ColumnsCount > 1 || range.RowsCount > 1)
			{
				writer.WriteAttributeString("colspan", range.ColumnsCount.ToString());
				writer.WriteAttributeString("rowspan", range.RowsCount.ToString());
			}
			if (context.Cell.View is global::SourceGrid.Cells.Views.Cell)
			{
				global::SourceGrid.Cells.Views.Cell cell = (global::SourceGrid.Cells.Views.Cell)context.Cell.View;
				if ((this.Mode & global::SourceGrid.Exporter.ExportHTMLMode.CellBackColor) == global::SourceGrid.Exporter.ExportHTMLMode.CellBackColor)
				{
					writer.WriteAttributeString("bgcolor", global::SourceGrid.Exporter.HTML.ColorToHTML(context.Cell.View.BackColor));
				}
				string value = global::SourceGrid.Exporter.HTML.BorderToHTMLStyle(cell.Border);
				writer.WriteAttributeString("style", value);
				writer.WriteAttributeString("align", global::DevAge.Windows.Forms.Utilities.ContentToHorizontalAlignment(cell.TextAlignment).ToString().ToLower());
				if (global::DevAge.Drawing.Utilities.IsBottom(cell.TextAlignment))
				{
					writer.WriteAttributeString("valign", "bottom");
				}
				else if (global::DevAge.Drawing.Utilities.IsTop(cell.TextAlignment))
				{
					writer.WriteAttributeString("valign", "top");
				}
				else if (global::DevAge.Drawing.Utilities.IsMiddle(cell.TextAlignment))
				{
					writer.WriteAttributeString("valign", "middle");
				}
			}
			if (context.Cell.View is global::SourceGrid.Cells.Views.CheckBox)
			{
				if (((global::SourceGrid.Cells.Models.ICheckBox)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ICheckBox))).GetCheckBoxStatus(context).Checked == true)
				{
					writer.WriteRaw("<input type=\"checkbox\" checked>");
				}
				else
				{
					writer.WriteRaw("<input type=\"checkbox\">");
				}
			}
			if (context.Cell.View is global::SourceGrid.Cells.Views.Cell)
			{
				global::System.Drawing.Image image = null;
				global::SourceGrid.Cells.Models.IImage image2 = (global::SourceGrid.Cells.Models.IImage)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.IImage));
				if (image2 != null)
				{
					image = image2.GetImage(context);
				}
				global::SourceGrid.Cells.Views.Cell cell2 = (global::SourceGrid.Cells.Views.Cell)context.Cell.View;
				if (image != null)
				{
					writer.WriteStartElement("img");
					writer.WriteAttributeString("align", global::DevAge.Windows.Forms.Utilities.ContentToHorizontalAlignment(cell2.ImageAlignment).ToString().ToLower());
					writer.WriteAttributeString("src", this.ExportImage(image));
					writer.WriteEndElement();
				}
				writer.WriteStartElement("font");
				writer.WriteAttributeString("color", global::SourceGrid.Exporter.HTML.ColorToHTML(cell2.ForeColor));
				this.ExportHTMLCellContent(context, writer);
				writer.WriteEndElement();
			}
			else
			{
				this.ExportHTMLCellContent(context, writer);
			}
			writer.WriteEndElement();
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000911DC File Offset: 0x0008F3DC
		protected virtual void ExportHTMLCellContent(global::SourceGrid.CellContext context, global::System.Xml.XmlTextWriter writer)
		{
			if (context.Cell.View is global::SourceGrid.Cells.Views.CheckBox)
			{
				global::SourceGrid.Cells.Models.ICheckBox checkBox = (global::SourceGrid.Cells.Models.ICheckBox)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ICheckBox));
				global::SourceGrid.Exporter.HTML.ExportHTML_Element_Font(writer, checkBox.GetCheckBoxStatus(context).Caption, context.Cell.View.GetDrawingFont(context.Grid));
				return;
			}
			global::SourceGrid.Exporter.HTML.ExportHTML_Element_Font(writer, context.DisplayText, context.Cell.View.GetDrawingFont(context.Grid));
		}

		// Token: 0x04000E6E RID: 3694
		protected global::SourceGrid.Exporter.ExportHTMLMode m_Mode = global::SourceGrid.Exporter.ExportHTMLMode.Default;

		// Token: 0x04000E6F RID: 3695
		protected global::System.IO.Stream m_Stream;

		// Token: 0x04000E70 RID: 3696
		protected string m_ImageFullPath;

		// Token: 0x04000E71 RID: 3697
		protected string m_ImageRelativePath;

		// Token: 0x04000E72 RID: 3698
		protected global::System.Collections.Hashtable m_EmbeddedImagesPath = new global::System.Collections.Hashtable();
	}
}
