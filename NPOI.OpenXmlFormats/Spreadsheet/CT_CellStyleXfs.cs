using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F5 RID: 1269
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellStyleXfs
	{
		// Token: 0x06003598 RID: 13720 RVA: 0x00085FB0 File Offset: 0x000841B0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs ct_CellStyleXfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs();
			ct_CellStyleXfs.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_CellStyleXfs.xf = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "xf")
				{
					ct_CellStyleXfs.xf.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellStyleXfs;
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00086058 File Offset: 0x00084258
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

		// Token: 0x0600359B RID: 13723 RVA: 0x000860F8 File Offset: 0x000842F8
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

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x0008612B File Offset: 0x0008432B
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x00086133 File Offset: 0x00084333
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0008613C File Offset: 0x0008433C
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x00086144 File Offset: 0x00084344
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

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x0008614D File Offset: 0x0008434D
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x00086155 File Offset: 0x00084355
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

		// Token: 0x04002393 RID: 9107
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf> xfField;

		// Token: 0x04002394 RID: 9108
		private uint countField;

		// Token: 0x04002395 RID: 9109
		private bool countFieldSpecified;
	}
}
