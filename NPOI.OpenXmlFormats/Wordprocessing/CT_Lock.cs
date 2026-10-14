using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E8 RID: 232
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Lock
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0001537C File Offset: 0x0001357C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock ct_Lock = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock();
			if (node.Attributes["w:val"] != null)
			{
				ct_Lock.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Lock)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Lock), node.Attributes["w:val"].Value);
			}
			return ct_Lock;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000153D8 File Offset: 0x000135D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00015431 File Offset: 0x00013631
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00015439 File Offset: 0x00013639
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Lock val
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00015442 File Offset: 0x00013642
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0001544A File Offset: 0x0001364A
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

		// Token: 0x040005A8 RID: 1448
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Lock valField;

		// Token: 0x040005A9 RID: 1449
		private bool valFieldSpecified;
	}
}
