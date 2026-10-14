using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C9 RID: 457
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Column
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00039C94 File Offset: 0x00037E94
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column
			{
				w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:w"]),
				space = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:space"])
			};
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00039CE4 File Offset: 0x00037EE4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:space", this.space);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00039D44 File Offset: 0x00037F44
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x00039D4C File Offset: 0x00037F4C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00039D55 File Offset: 0x00037F55
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00039D5D File Offset: 0x00037F5D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wSpecified
		{
			get
			{
				return this.wFieldSpecified;
			}
			set
			{
				this.wFieldSpecified = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00039D66 File Offset: 0x00037F66
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00039D6E File Offset: 0x00037F6E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00039D77 File Offset: 0x00037F77
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00039D7F File Offset: 0x00037F7F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spaceSpecified
		{
			get
			{
				return this.spaceFieldSpecified;
			}
			set
			{
				this.spaceFieldSpecified = value;
			}
		}

		// Token: 0x04000D88 RID: 3464
		private ulong wField;

		// Token: 0x04000D89 RID: 3465
		private bool wFieldSpecified;

		// Token: 0x04000D8A RID: 3466
		private ulong spaceField;

		// Token: 0x04000D8B RID: 3467
		private bool spaceFieldSpecified;
	}
}
