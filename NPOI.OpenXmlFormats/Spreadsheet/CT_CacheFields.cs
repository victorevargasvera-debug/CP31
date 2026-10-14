using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000489 RID: 1161
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CacheFields
	{
		// Token: 0x06002E81 RID: 11905 RVA: 0x00074AF4 File Offset: 0x00072CF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields ct_CacheFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields();
			if (node.Attributes["count"] != null)
			{
				ct_CacheFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_CacheFields.cacheField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cacheField")
				{
					ct_CacheFields.cacheField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CacheFields;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00074BB0 File Offset: 0x00072DB0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.cacheField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField ct_CacheField in this.cacheField)
				{
					ct_CacheField.Write(sw, "cacheField");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00074C50 File Offset: 0x00072E50
		public CT_CacheFields()
		{
			this.cacheFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField>();
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x00074C63 File Offset: 0x00072E63
		// (set) Token: 0x06002E85 RID: 11909 RVA: 0x00074C6B File Offset: 0x00072E6B
		[global::System.Xml.Serialization.XmlElement("cacheField", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField> cacheField
		{
			get
			{
				return this.cacheFieldField;
			}
			set
			{
				this.cacheFieldField = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00074C74 File Offset: 0x00072E74
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x00074C7C File Offset: 0x00072E7C
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

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x00074C85 File Offset: 0x00072E85
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x00074C8D File Offset: 0x00072E8D
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

		// Token: 0x06002E8A RID: 11914 RVA: 0x00074C98 File Offset: 0x00072E98
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField AddNewCacheField()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField ct_CacheField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField();
			this.cacheFieldField.Add(ct_CacheField);
			return ct_CacheField;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00074CB8 File Offset: 0x00072EB8
		public uint SizeOfCacheFieldArray()
		{
			if (this.cacheFieldField == null)
			{
				return 0U;
			}
			return (uint)this.cacheFieldField.Count;
		}

		// Token: 0x0400200F RID: 8207
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField> cacheFieldField;

		// Token: 0x04002010 RID: 8208
		private uint countField;

		// Token: 0x04002011 RID: 8209
		private bool countFieldSpecified;
	}
}
