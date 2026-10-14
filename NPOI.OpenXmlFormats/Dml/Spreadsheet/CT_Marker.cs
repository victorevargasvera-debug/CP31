using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000370 RID: 880
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_Marker
	{
		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0005B860 File Offset: 0x00059A60
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x0005B868 File Offset: 0x00059A68
		public int col
		{
			get
			{
				return this._col;
			}
			set
			{
				this._col = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x0005B871 File Offset: 0x00059A71
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x0005B879 File Offset: 0x00059A79
		public long colOff
		{
			get
			{
				return this._colOff;
			}
			set
			{
				this._colOff = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x0005B882 File Offset: 0x00059A82
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x0005B88A File Offset: 0x00059A8A
		public int row
		{
			get
			{
				return this._row;
			}
			set
			{
				this._row = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x0005B893 File Offset: 0x00059A93
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x0005B89B File Offset: 0x00059A9B
		public long rowOff
		{
			get
			{
				return this._rowOff;
			}
			set
			{
				this._rowOff = value;
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0005B8A4 File Offset: 0x00059AA4
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker ct_Marker = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "col")
				{
					ct_Marker.col = int.Parse(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "colOff")
				{
					ct_Marker.colOff = long.Parse(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "row")
				{
					ct_Marker.row = int.Parse(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "rowOff")
				{
					ct_Marker.rowOff = long.Parse(xmlNode.InnerText);
				}
			}
			return ct_Marker;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0005B998 File Offset: 0x00059B98
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(stringBuilder))
			{
				stringWriter.Write("<xdr:col>");
				stringWriter.Write(this.col.ToString());
				stringWriter.Write("</xdr:col>");
				stringWriter.Write("<xdr:colOff>");
				stringWriter.Write(this.colOff.ToString());
				stringWriter.Write("</xdr:colOff>");
				stringWriter.Write("<xdr:row>");
				stringWriter.Write(this.row.ToString());
				stringWriter.Write("</xdr:row>");
				stringWriter.Write("<xdr:rowOff>");
				stringWriter.Write(this.rowOff.ToString());
				stringWriter.Write("</xdr:rowOff>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0005BA7C File Offset: 0x00059C7C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			sw.Write("<xdr:col>");
			sw.Write(this.col.ToString());
			sw.Write("</xdr:col>");
			sw.Write("<xdr:colOff>");
			sw.Write(this.colOff.ToString());
			sw.Write("</xdr:colOff>");
			sw.Write("<xdr:row>");
			sw.Write(this.row.ToString());
			sw.Write("</xdr:row>");
			sw.Write("<xdr:rowOff>");
			sw.Write(this.rowOff.ToString());
			sw.Write("</xdr:rowOff>");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04001A54 RID: 6740
		private int _col;

		// Token: 0x04001A55 RID: 6741
		private long _colOff;

		// Token: 0x04001A56 RID: 6742
		private int _row;

		// Token: 0x04001A57 RID: 6743
		private long _rowOff;
	}
}
