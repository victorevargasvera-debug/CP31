using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000500 RID: 1280
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellXfs
	{
		// Token: 0x06003686 RID: 13958 RVA: 0x00087D9C File Offset: 0x00085F9C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs ct_CellXfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs();
			ct_CellXfs.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_CellXfs.xf = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "xf")
				{
					ct_CellXfs.xf.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellXfs;
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00087E44 File Offset: 0x00086044
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.xf != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf in this.xf)
				{
					ct_Xf.Write(sw, "xf");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00087EE4 File Offset: 0x000860E4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf AddNewXf()
		{
			if (this.xfField == null)
			{
				this.xfField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf();
			this.xfField.Add(ct_Xf);
			return ct_Xf;
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x00087F17 File Offset: 0x00086117
		// (set) Token: 0x0600368B RID: 13963 RVA: 0x00087F1F File Offset: 0x0008611F
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf> xf
		{
			get
			{
				return this.xfField;
			}
			set
			{
				this.xfField = value;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x00087F28 File Offset: 0x00086128
		// (set) Token: 0x0600368D RID: 13965 RVA: 0x00087F30 File Offset: 0x00086130
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x00087F39 File Offset: 0x00086139
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x00087F41 File Offset: 0x00086141
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x040023E3 RID: 9187
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf> xfField;

		// Token: 0x040023E4 RID: 9188
		private uint countField;

		// Token: 0x040023E5 RID: 9189
		private bool countFieldSpecified;
	}
}
