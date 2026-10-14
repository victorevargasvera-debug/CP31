using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Vml;
using NPOI.OpenXmlFormats.Vml.Office;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A6 RID: 166
	public class XSSFVMLDrawing : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x00025AA0 File Offset: 0x00023CA0
		public XSSFVMLDrawing()
		{
			this.newDrawing();
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00025AC4 File Offset: 0x00023CC4
		protected XSSFVMLDrawing(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.Read(base.GetPackagePart().GetInputStream());
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00025AF4 File Offset: 0x00023CF4
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFVMLDrawing(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00025B00 File Offset: 0x00023D00
		internal void Read(global::System.IO.Stream is1)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			string text = new global::System.IO.StreamReader(is1).ReadToEnd();
			xmlDocument.LoadXml(text.Replace("<br>", ""));
			global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("o", "urn:schemas-microsoft-com:office:office");
			xmlNamespaceManager.AddNamespace("x", "urn:schemas-microsoft-com:office:excel");
			xmlNamespaceManager.AddNamespace("v", "urn:schemas-microsoft-com:vml");
			this._items = new global::System.Collections.ArrayList();
			foreach (object obj in xmlDocument.SelectNodes("/xml/*", xmlNamespaceManager))
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				string outerXml = xmlNode.OuterXml;
				if (xmlNode.LocalName == global::NPOI.XSSF.UserModel.XSSFVMLDrawing.QNAME_SHAPE_LAYOUT.Name)
				{
					global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout value = global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout.Parse(xmlNode, xmlNamespaceManager);
					this._items.Add(value);
				}
				else if (xmlNode.LocalName == global::NPOI.XSSF.UserModel.XSSFVMLDrawing.QNAME_SHAPE_TYPE.Name)
				{
					global::NPOI.OpenXmlFormats.Vml.CT_Shapetype ct_Shapetype = global::NPOI.OpenXmlFormats.Vml.CT_Shapetype.Parse(xmlNode, xmlNamespaceManager);
					this._items.Add(ct_Shapetype);
					this._shapeTypeId = ct_Shapetype.id;
				}
				else if (xmlNode.LocalName == global::NPOI.XSSF.UserModel.XSSFVMLDrawing.QNAME_SHAPE.Name)
				{
					global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = global::NPOI.OpenXmlFormats.Vml.CT_Shape.Parse(xmlNode, xmlNamespaceManager);
					string id = ct_Shape.id;
					if (id != null)
					{
						global::System.Text.RegularExpressions.MatchCollection matchCollection = global::NPOI.XSSF.UserModel.XSSFVMLDrawing.ptrn_shapeId.Matches(id);
						if (matchCollection.Count > 0)
						{
							this._shapeId = global::System.Math.Max(this._shapeId, int.Parse(matchCollection[0].Groups[1].Value));
						}
					}
					this._items.Add(ct_Shape);
				}
				else
				{
					this._items.Add(xmlNode);
				}
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00025CE4 File Offset: 0x00023EE4
		internal global::System.Collections.ArrayList GetItems()
		{
			return this._items;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00025CEC File Offset: 0x00023EEC
		internal void Write(global::System.IO.Stream out1)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(out1))
			{
				streamWriter.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
				streamWriter.Write("<xml");
				streamWriter.Write(" xmlns:v=\"urn:schemas-microsoft-com:vml\"");
				streamWriter.Write(" xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
				streamWriter.Write(" xmlns:x=\"urn:schemas-microsoft-com:office:excel\"");
				streamWriter.Write(" xmlns:w=\"urn:schemas-microsoft-com:office:word\"");
				streamWriter.Write(" xmlns:p=\"urn:schemas-microsoft-com:office:powerpoint\"");
				streamWriter.Write(">");
				for (int i = 0; i < this._items.Count; i++)
				{
					object obj = this._items[i];
					if (obj is global::System.Xml.XmlNode)
					{
						streamWriter.Write(((global::System.Xml.XmlNode)obj).OuterXml.Replace(" xmlns:v=\"urn:schemas-microsoft-com:vml\"", "").Replace(" xmlns:x=\"urn:schemas-microsoft-com:office:excel\"", "").Replace(" xmlns:o=\"urn:schemas-microsoft-com:office:office\"", "").Replace("&#xD;&#xA;", ""));
					}
					else if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Shapetype)
					{
						((global::NPOI.OpenXmlFormats.Vml.CT_Shapetype)obj).Write(streamWriter, "shapetype");
					}
					else if (obj is global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout)
					{
						((global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout)obj).Write(streamWriter, "shapelayout");
					}
					else if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Shape)
					{
						((global::NPOI.OpenXmlFormats.Vml.CT_Shape)obj).Write(streamWriter, "shape");
					}
					else
					{
						streamWriter.Write(obj.ToString().Replace(" xmlns:v=\"urn:schemas-microsoft-com:vml\"", "").Replace(" xmlns:x=\"urn:schemas-microsoft-com:office:excel\"", "").Replace(" xmlns:o=\"urn:schemas-microsoft-com:office:office\"", "").Replace("&#xD;&#xA;", ""));
					}
				}
				streamWriter.Write("</xml>");
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00025EA8 File Offset: 0x000240A8
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.Write(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00025ED0 File Offset: 0x000240D0
		private void newDrawing()
		{
			global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout ct_ShapeLayout = new global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout();
			ct_ShapeLayout.ext = global::NPOI.OpenXmlFormats.Vml.ST_Ext.edit;
			global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap ct_IdMap = ct_ShapeLayout.AddNewIdmap();
			ct_IdMap.ext = global::NPOI.OpenXmlFormats.Vml.ST_Ext.edit;
			ct_IdMap.data = "1";
			this._items.Add(ct_ShapeLayout);
			global::NPOI.OpenXmlFormats.Vml.CT_Shapetype ct_Shapetype = new global::NPOI.OpenXmlFormats.Vml.CT_Shapetype();
			this._shapeTypeId = global::NPOI.XSSF.UserModel.XSSFVMLDrawing.COMMENT_SHAPE_TYPE_ID;
			ct_Shapetype.id = this._shapeTypeId;
			ct_Shapetype.coordsize = "21600,21600";
			ct_Shapetype.spt = 202f;
			ct_Shapetype.path2 = "m,l,21600r21600,l21600,xe";
			ct_Shapetype.AddNewStroke().joinstyle = global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle.miter;
			global::NPOI.OpenXmlFormats.Vml.CT_Path ct_Path = ct_Shapetype.AddNewPath();
			ct_Path.gradientshapeok = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			ct_Path.connecttype = global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType.rect;
			this._items.Add(ct_Shapetype);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00025F78 File Offset: 0x00024178
		internal global::NPOI.OpenXmlFormats.Vml.CT_Shape newCommentShape()
		{
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Vml.CT_Shape();
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape2 = ct_Shape;
			string str = "_x0000_s";
			int shapeId = this._shapeId + 1;
			this._shapeId = shapeId;
			ct_Shape2.id = str + shapeId.ToString();
			ct_Shape.type = "#" + this._shapeTypeId;
			ct_Shape.style = "position:absolute; visibility:hidden";
			ct_Shape.fillcolor = "#ffffe1";
			ct_Shape.insetmode = global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode.auto;
			ct_Shape.AddNewFill().color = "#ffffe1";
			global::NPOI.OpenXmlFormats.Vml.CT_Shadow ct_Shadow = ct_Shape.AddNewShadow();
			ct_Shadow.on = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			ct_Shadow.color = "black";
			ct_Shadow.obscured = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			ct_Shape.AddNewPath().connecttype = global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType.none;
			ct_Shape.AddNewTextbox().style = "mso-direction-alt:auto";
			global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData ct_ClientData = ct_Shape.AddNewClientData();
			ct_ClientData.ObjectType = global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType.Note;
			ct_ClientData.AddNewMoveWithCells();
			ct_ClientData.AddNewSizeWithCells();
			ct_ClientData.AddNewAnchor("1, 15, 0, 2, 3, 15, 3, 16");
			ct_ClientData.AddNewAutoFill(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false);
			ct_ClientData.AddNewRow(0);
			ct_ClientData.AddNewColumn(0);
			this._items.Add(ct_Shape);
			return ct_Shape;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00026078 File Offset: 0x00024278
		internal global::NPOI.OpenXmlFormats.Vml.CT_Shape FindCommentShape(int row, int col)
		{
			foreach (object obj in this._items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Shape)
				{
					global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = (global::NPOI.OpenXmlFormats.Vml.CT_Shape)obj;
					if (ct_Shape.sizeOfClientDataArray() > 0)
					{
						global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData clientDataArray = ct_Shape.GetClientDataArray(0);
						if (clientDataArray.ObjectType == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType.Note)
						{
							int rowArray = clientDataArray.GetRowArray(0);
							int columnArray = clientDataArray.GetColumnArray(0);
							if (rowArray == row && columnArray == col)
							{
								return ct_Shape;
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00026118 File Offset: 0x00024318
		internal bool RemoveCommentShape(int row, int col)
		{
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = this.FindCommentShape(row, col);
			if (ct_Shape == null)
			{
				return false;
			}
			this._items.Remove(ct_Shape);
			return true;
		}

		// Token: 0x04000374 RID: 884
		private static global::System.Xml.XmlQualifiedName QNAME_SHAPE_LAYOUT = new global::System.Xml.XmlQualifiedName("shapelayout", "urn:schemas-microsoft-com:office:office");

		// Token: 0x04000375 RID: 885
		private static global::System.Xml.XmlQualifiedName QNAME_SHAPE_TYPE = new global::System.Xml.XmlQualifiedName("shapetype", "urn:schemas-microsoft-com:vml");

		// Token: 0x04000376 RID: 886
		private static global::System.Xml.XmlQualifiedName QNAME_SHAPE = new global::System.Xml.XmlQualifiedName("shape", "urn:schemas-microsoft-com:vml");

		// Token: 0x04000377 RID: 887
		private static string COMMENT_SHAPE_TYPE_ID = "_x0000_t202";

		// Token: 0x04000378 RID: 888
		private static global::System.Text.RegularExpressions.Regex ptrn_shapeId = new global::System.Text.RegularExpressions.Regex("_x0000_s(\\d+)", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000379 RID: 889
		private static global::System.Text.RegularExpressions.Regex ptrn_shapeTypeId = new global::System.Text.RegularExpressions.Regex("_x0000_[tm](\\d+)", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0400037A RID: 890
		private global::System.Collections.ArrayList _items = new global::System.Collections.ArrayList();

		// Token: 0x0400037B RID: 891
		private string _shapeTypeId;

		// Token: 0x0400037C RID: 892
		private int _shapeId = 1024;
	}
}
