using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000633 RID: 1587
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BreakBinSub
	{
		// Token: 0x060044E3 RID: 17635 RVA: 0x000A38BC File Offset: 0x000A1ABC
		public static global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub ct_BreakBinSub = new global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub();
			if (node.Attributes["m:val"] != null)
			{
				if (node.Attributes["m:val"].Value == "--")
				{
					ct_BreakBinSub.val = global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub.Item;
				}
				else if (node.Attributes["m:val"].Value == "-+")
				{
					ct_BreakBinSub.val = global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub.Item1;
				}
				else if (node.Attributes["m:val"].Value == "+-")
				{
					ct_BreakBinSub.val = global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub.Item2;
				}
			}
			return ct_BreakBinSub;
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x000A3963 File Offset: 0x000A1B63
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", global::NPOI.OpenXml4Net.Util.XmlHelper.GetEnumValue(this.val));
			sw.Write("/>");
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x000A399C File Offset: 0x000A1B9C
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x000A39A4 File Offset: 0x000A1BA4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x000A39AD File Offset: 0x000A1BAD
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x000A39B5 File Offset: 0x000A1BB5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x04002B2C RID: 11052
		private global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub valField;

		// Token: 0x04002B2D RID: 11053
		private bool valFieldSpecified;
	}
}
