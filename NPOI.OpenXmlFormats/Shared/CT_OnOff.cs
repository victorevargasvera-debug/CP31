using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000631 RID: 1585
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OnOff
	{
		// Token: 0x060044DC RID: 17628 RVA: 0x000A37E0 File Offset: 0x000A19E0
		public static global::NPOI.OpenXmlFormats.Shared.CT_OnOff Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OnOff ct_OnOff = new global::NPOI.OpenXmlFormats.Shared.CT_OnOff();
			if (node.Attributes["m:val"] != null)
			{
				ct_OnOff.val = (global::NPOI.OpenXmlFormats.Shared.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_OnOff), node.Attributes["m:val"].Value, true);
			}
			return ct_OnOff;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x000A383C File Offset: 0x000A1A3C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			if (this.val == global::NPOI.OpenXmlFormats.Shared.ST_OnOff.off || this.val == global::NPOI.OpenXmlFormats.Shared.ST_OnOff.Value0)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", "0");
			}
			else
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", "1");
			}
			sw.Write("/>");
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x000A3898 File Offset: 0x000A1A98
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x000A38A0 File Offset: 0x000A1AA0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_OnOff val
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x000A38A9 File Offset: 0x000A1AA9
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x000A38B1 File Offset: 0x000A1AB1
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

		// Token: 0x04002B25 RID: 11045
		private global::NPOI.OpenXmlFormats.Shared.ST_OnOff valField;

		// Token: 0x04002B26 RID: 11046
		private bool valFieldSpecified;
	}
}
