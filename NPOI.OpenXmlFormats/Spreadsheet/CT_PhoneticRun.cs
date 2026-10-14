using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200054F RID: 1359
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "rPh", IsNullable = false)]
	[global::System.Serializable]
	public class CT_PhoneticRun
	{
		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x000927EC File Offset: 0x000909EC
		// (set) Token: 0x06003B2C RID: 15148 RVA: 0x000927F4 File Offset: 0x000909F4
		[global::System.Xml.Serialization.XmlAttribute]
		public string t
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

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x000927FD File Offset: 0x000909FD
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x00092805 File Offset: 0x00090A05
		[global::System.Xml.Serialization.XmlAttribute]
		public uint sb
		{
			get
			{
				return this.sbField;
			}
			set
			{
				this.sbField = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x0009280E File Offset: 0x00090A0E
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x00092816 File Offset: 0x00090A16
		[global::System.Xml.Serialization.XmlAttribute]
		public uint eb
		{
			get
			{
				return this.ebField;
			}
			set
			{
				this.ebField = value;
			}
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00092820 File Offset: 0x00090A20
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun ct_PhoneticRun = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun();
			ct_PhoneticRun.sb = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["sb"]);
			ct_PhoneticRun.eb = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["eb"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "t")
				{
					ct_PhoneticRun.t = xmlNode.InnerText;
				}
			}
			return ct_PhoneticRun;
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x000928D4 File Offset: 0x00090AD4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sb", this.sb.ToString(), true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "eb", this.eb.ToString(), true);
			sw.Write(">");
			sw.Write("<t>");
			if (this.t != null)
			{
				sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.t));
			}
			sw.Write("</t>");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040025DC RID: 9692
		private string tField;

		// Token: 0x040025DD RID: 9693
		private uint sbField;

		// Token: 0x040025DE RID: 9694
		private uint ebField;
	}
}
