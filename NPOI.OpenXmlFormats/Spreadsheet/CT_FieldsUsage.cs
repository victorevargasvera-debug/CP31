using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049B RID: 1179
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_FieldsUsage
	{
		// Token: 0x06003007 RID: 12295 RVA: 0x0007867C File Offset: 0x0007687C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage ct_FieldsUsage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage();
			if (node.Attributes["count"] != null)
			{
				ct_FieldsUsage.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_FieldsUsage.fieldUsage = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fieldUsage")
				{
					ct_FieldsUsage.fieldUsage.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FieldsUsage;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00078738 File Offset: 0x00076938
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.fieldUsage != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage ct_FieldUsage in this.fieldUsage)
				{
					ct_FieldUsage.Write(sw, "fieldUsage");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000787D8 File Offset: 0x000769D8
		public CT_FieldsUsage()
		{
			this.fieldUsageField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage>();
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x000787EB File Offset: 0x000769EB
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x000787F3 File Offset: 0x000769F3
		[global::System.Xml.Serialization.XmlElement("fieldUsage", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage> fieldUsage
		{
			get
			{
				return this.fieldUsageField;
			}
			set
			{
				this.fieldUsageField = value;
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x000787FC File Offset: 0x000769FC
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x00078804 File Offset: 0x00076A04
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

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x0007880D File Offset: 0x00076A0D
		// (set) Token: 0x0600300F RID: 12303 RVA: 0x00078815 File Offset: 0x00076A15
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

		// Token: 0x040020C0 RID: 8384
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage> fieldUsageField;

		// Token: 0x040020C1 RID: 8385
		private uint countField;

		// Token: 0x040020C2 RID: 8386
		private bool countFieldSpecified;
	}
}
