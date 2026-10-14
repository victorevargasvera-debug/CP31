using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000AC RID: 172
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumLvl
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x0000D720 File Offset: 0x0000B920
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl ct_NumLvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl();
			ct_NumLvl.ilvl = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:ilvl"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "startOverride")
				{
					ct_NumLvl.startOverride = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl")
				{
					ct_NumLvl.lvl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NumLvl;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:ilvl", this.ilvl);
			sw.Write(">");
			if (this.startOverride != null)
			{
				this.startOverride.Write(sw, "startOverride");
			}
			if (this.lvl != null)
			{
				this.lvl.Write(sw, "lvl");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000D859 File Offset: 0x0000BA59
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0000D861 File Offset: 0x0000BA61
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber startOverride
		{
			get
			{
				return this.startOverrideField;
			}
			set
			{
				this.startOverrideField = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000D86A File Offset: 0x0000BA6A
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0000D872 File Offset: 0x0000BA72
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl lvl
		{
			get
			{
				return this.lvlField;
			}
			set
			{
				this.lvlField = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0000D87B File Offset: 0x0000BA7B
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x0000D883 File Offset: 0x0000BA83
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string ilvl
		{
			get
			{
				return this.ilvlField;
			}
			set
			{
				this.ilvlField = value;
			}
		}

		// Token: 0x04000420 RID: 1056
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber startOverrideField;

		// Token: 0x04000421 RID: 1057
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl lvlField;

		// Token: 0x04000422 RID: 1058
		private string ilvlField;
	}
}
