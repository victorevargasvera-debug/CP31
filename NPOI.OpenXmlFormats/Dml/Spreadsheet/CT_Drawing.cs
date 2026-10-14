using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000373 RID: 883
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Xml.Serialization.XmlRoot("wsDr", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Drawing
	{
		// Token: 0x0600233A RID: 9018 RVA: 0x0005BC14 File Offset: 0x00059E14
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor AddNewTwoCellAnchor()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor ct_TwoCellAnchor = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor();
			this.cellAnchors.Add(ct_TwoCellAnchor);
			return ct_TwoCellAnchor;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0005BC34 File Offset: 0x00059E34
		public int SizeOfTwoCellAnchorArray()
		{
			int num = 0;
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor>.Enumerator enumerator = this.cellAnchors.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0005BC90 File Offset: 0x00059E90
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
				streamWriter.Write("<xdr:wsDr xmlns:xdr=\"http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing\" xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\">");
				foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor ieg_Anchor in this.cellAnchors)
				{
					ieg_Anchor.Write(streamWriter);
				}
				streamWriter.Write("</xdr:wsDr>");
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x0005BD24 File Offset: 0x00059F24
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x0005BD2C File Offset: 0x00059F2C
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor> CellAnchors
		{
			get
			{
				return this.cellAnchors;
			}
			set
			{
				this.cellAnchors = value;
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0005BD38 File Offset: 0x00059F38
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing ctDrawing)
		{
			this.cellAnchors.Clear();
			foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor item in ctDrawing.cellAnchors)
			{
				this.cellAnchors.Add(item);
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0005BD9C File Offset: 0x00059F9C
		public int SizeOfAbsoluteAnchorArray()
		{
			return 0;
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0005BDA0 File Offset: 0x00059FA0
		public int SizeOfOneCellAnchorArray()
		{
			int num = 0;
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor>.Enumerator enumerator = this.cellAnchors.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0005BDFC File Offset: 0x00059FFC
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::System.Xml.XmlNodeList xmlNodeList = xmldoc.SelectNodes("/xdr:wsDr/*", namespaceManager);
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing ct_Drawing = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing();
			foreach (object obj in xmlNodeList)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "twoCellAnchor")
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor item = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor.Parse(xmlNode, namespaceManager);
					ct_Drawing.cellAnchors.Add(item);
				}
				else if (xmlNode.LocalName == "oneCellAnchor")
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor item2 = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor.Parse(xmlNode, namespaceManager);
					ct_Drawing.cellAnchors.Add(item2);
				}
				else if (xmlNode.LocalName == "absCellAnchor")
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AbsoluteCellAnchor item3 = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AbsoluteCellAnchor.Parse(xmlNode, namespaceManager);
					ct_Drawing.cellAnchors.Add(item3);
				}
			}
			return ct_Drawing;
		}

		// Token: 0x04001A5F RID: 6751
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor> cellAnchors = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor>();
	}
}
