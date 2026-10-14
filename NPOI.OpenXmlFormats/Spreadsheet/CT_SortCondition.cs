using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200053E RID: 1342
	public class CT_SortCondition
	{
		// Token: 0x06003AC3 RID: 15043 RVA: 0x00091496 File Offset: 0x0008F696
		public CT_SortCondition()
		{
			this.descendingField = false;
			this.sortByField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy.value;
			this.iconSetField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3Arrows;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x000914B4 File Offset: 0x0008F6B4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition ct_SortCondition = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition();
			if (node.Attributes["descending"] != null)
			{
				ct_SortCondition.descending = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["descending"]);
			}
			if (node.Attributes["sortBy"] != null)
			{
				ct_SortCondition.sortBy = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy), node.Attributes["sortBy"].Value);
			}
			ct_SortCondition.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			ct_SortCondition.customList = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["customList"]);
			if (node.Attributes["dxfId"] != null)
			{
				ct_SortCondition.dxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dxfId"]);
			}
			if (node.Attributes["iconSet"] != null)
			{
				ct_SortCondition.iconSet = global::NPOI.OpenXml4Net.Util.XmlHelper.GetEnumValueFromString<global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType>(node.Attributes["iconSet"].Value);
			}
			if (node.Attributes["iconId"] != null)
			{
				ct_SortCondition.iconId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["iconId"]);
			}
			return ct_SortCondition;
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00091600 File Offset: 0x0008F800
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "descending", this.descending);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sortBy", this.sortBy.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customList", this.customList);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dxfId", this.dxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iconSet", global::NPOI.OpenXml4Net.Util.XmlHelper.GetEnumValue(this.iconSet));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iconId", this.iconId, false);
			sw.Write("/>");
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x000916BA File Offset: 0x0008F8BA
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x000916C2 File Offset: 0x0008F8C2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool descending
		{
			get
			{
				return this.descendingField;
			}
			set
			{
				this.descendingField = value;
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x000916CB File Offset: 0x0008F8CB
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x000916D3 File Offset: 0x0008F8D3
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy.value)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy sortBy
		{
			get
			{
				return this.sortByField;
			}
			set
			{
				this.sortByField = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x000916DC File Offset: 0x0008F8DC
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x000916E4 File Offset: 0x0008F8E4
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x000916ED File Offset: 0x0008F8ED
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x000916F5 File Offset: 0x0008F8F5
		public string customList
		{
			get
			{
				return this.customListField;
			}
			set
			{
				this.customListField = value;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x000916FE File Offset: 0x0008F8FE
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00091706 File Offset: 0x0008F906
		public uint dxfId
		{
			get
			{
				return this.dxfIdField;
			}
			set
			{
				this.dxfIdField = value;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0009170F File Offset: 0x0008F90F
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00091717 File Offset: 0x0008F917
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxfIdSpecified
		{
			get
			{
				return this.dxfIdFieldSpecified;
			}
			set
			{
				this.dxfIdFieldSpecified = value;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00091720 File Offset: 0x0008F920
		// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x00091728 File Offset: 0x0008F928
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3Arrows)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSet
		{
			get
			{
				return this.iconSetField;
			}
			set
			{
				this.iconSetField = value;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00091731 File Offset: 0x0008F931
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x00091739 File Offset: 0x0008F939
		public uint iconId
		{
			get
			{
				return this.iconIdField;
			}
			set
			{
				this.iconIdField = value;
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x00091742 File Offset: 0x0008F942
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x0009174A File Offset: 0x0008F94A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iconIdSpecified
		{
			get
			{
				return this.iconIdFieldSpecified;
			}
			set
			{
				this.iconIdFieldSpecified = value;
			}
		}

		// Token: 0x040025A1 RID: 9633
		private bool descendingField;

		// Token: 0x040025A2 RID: 9634
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortBy sortByField;

		// Token: 0x040025A3 RID: 9635
		private string refField;

		// Token: 0x040025A4 RID: 9636
		private string customListField;

		// Token: 0x040025A5 RID: 9637
		private uint dxfIdField;

		// Token: 0x040025A6 RID: 9638
		private bool dxfIdFieldSpecified;

		// Token: 0x040025A7 RID: 9639
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSetField;

		// Token: 0x040025A8 RID: 9640
		private uint iconIdField;

		// Token: 0x040025A9 RID: 9641
		private bool iconIdFieldSpecified;
	}
}
