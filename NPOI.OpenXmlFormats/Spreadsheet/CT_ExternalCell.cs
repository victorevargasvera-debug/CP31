using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000606 RID: 1542
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalCell
	{
		// Token: 0x0600438B RID: 17291 RVA: 0x000A0A90 File Offset: 0x0009EC90
		public CT_ExternalCell()
		{
			this.tField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n;
			this.vmField = 0U;
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000A0AA6 File Offset: 0x0009ECA6
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x000A0AAE File Offset: 0x0009ECAE
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x000A0AB7 File Offset: 0x0009ECB7
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x000A0ABF File Offset: 0x0009ECBF
		[global::System.Xml.Serialization.XmlAttribute]
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000A0AC8 File Offset: 0x0009ECC8
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x000A0AD0 File Offset: 0x0009ECD0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x000A0AD9 File Offset: 0x0009ECD9
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x000A0AE1 File Offset: 0x0009ECE1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint vm
		{
			get
			{
				return this.vmField;
			}
			set
			{
				this.vmField = value;
			}
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000A0AEC File Offset: 0x0009ECEC
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell ct_ExternalCell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell();
			ct_ExternalCell.rField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"]);
			if (node.Attributes["t"] != null)
			{
				ct_ExternalCell.tField = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType), node.Attributes["t"].Value);
			}
			ct_ExternalCell.vm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["vm"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "v")
				{
					ct_ExternalCell.v = xmlNode.InnerText;
				}
			}
			return ct_ExternalCell;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000A0BDC File Offset: 0x0009EDDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.rField);
			if (this.t != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.tField.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vm", this.vmField, false);
			if (this.v == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			sw.Write(string.Format("<v>{0}</v>", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.v)));
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A8E RID: 10894
		private string vField;

		// Token: 0x04002A8F RID: 10895
		private string rField;

		// Token: 0x04002A90 RID: 10896
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType tField;

		// Token: 0x04002A91 RID: 10897
		private uint vmField;
	}
}
