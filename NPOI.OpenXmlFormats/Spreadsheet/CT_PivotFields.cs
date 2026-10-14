using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BB RID: 1211
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotFields
	{
		// Token: 0x06003246 RID: 12870 RVA: 0x0007DE64 File Offset: 0x0007C064
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields ct_PivotFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields();
			if (node.Attributes["count"] != null)
			{
				ct_PivotFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PivotFields.pivotField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotField")
				{
					ct_PivotFields.pivotField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotFields;
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0007DF20 File Offset: 0x0007C120
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.pivotField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField in this.pivotField)
				{
					ct_PivotField.Write(sw, "pivotField");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0007DFC0 File Offset: 0x0007C1C0
		public CT_PivotFields()
		{
			this.pivotFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField>();
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x0007DFD3 File Offset: 0x0007C1D3
		// (set) Token: 0x0600324A RID: 12874 RVA: 0x0007DFDB File Offset: 0x0007C1DB
		[global::System.Xml.Serialization.XmlElement("pivotField", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField> pivotField
		{
			get
			{
				return this.pivotFieldField;
			}
			set
			{
				this.pivotFieldField = value;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x0007DFE4 File Offset: 0x0007C1E4
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x0007DFEC File Offset: 0x0007C1EC
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

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x0007DFF5 File Offset: 0x0007C1F5
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x0007DFFD File Offset: 0x0007C1FD
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

		// Token: 0x0600324F RID: 12879 RVA: 0x0007E006 File Offset: 0x0007C206
		public void SetPivotFieldArray(int columnIndex, global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField pivotField)
		{
			this.pivotFieldField[columnIndex] = pivotField;
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x0007E018 File Offset: 0x0007C218
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField AddNewPivotField()
		{
			if (this.pivotFieldField == null)
			{
				this.pivotFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField();
			this.pivotFieldField.Add(ct_PivotField);
			return ct_PivotField;
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x0007E04B File Offset: 0x0007C24B
		public uint SizeOfPivotFieldArray()
		{
			if (this.pivotFieldField == null)
			{
				this.pivotFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField>();
			}
			return (uint)this.pivotFieldField.Count;
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x0007E06B File Offset: 0x0007C26B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField GetPivotFieldArray(int columnIndex)
		{
			if (this.pivotFieldField == null)
			{
				this.pivotFieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField>();
			}
			return this.pivotFieldField[columnIndex];
		}

		// Token: 0x040021B5 RID: 8629
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField> pivotFieldField;

		// Token: 0x040021B6 RID: 8630
		private uint countField;

		// Token: 0x040021B7 RID: 8631
		private bool countFieldSpecified;
	}
}
