using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200053D RID: 1341
	public class CT_SortState
	{
		// Token: 0x06003AB4 RID: 15028 RVA: 0x000911B5 File Offset: 0x0008F3B5
		public CT_SortState()
		{
			this.columnSortField = false;
			this.caseSensitiveField = false;
			this.sortMethodField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod.none;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x000911D4 File Offset: 0x0008F3D4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState ct_SortState = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState();
			if (node.Attributes["columnSort"] != null)
			{
				ct_SortState.columnSort = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["columnSort"]);
			}
			if (node.Attributes["caseSensitive"] != null)
			{
				ct_SortState.caseSensitive = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["caseSensitive"]);
			}
			if (node.Attributes["sortMethod"] != null)
			{
				ct_SortState.sortMethod = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod), node.Attributes["sortMethod"].Value);
			}
			ct_SortState.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			ct_SortState.sortCondition = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_SortState.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sortCondition")
				{
					ct_SortState.sortCondition.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SortState;
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00091338 File Offset: 0x0008F538
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "columnSort", this.columnSort);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caseSensitive", this.caseSensitive);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sortMethod", this.sortMethod.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.sortCondition != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition ct_SortCondition in this.sortCondition)
				{
					ct_SortCondition.Write(sw, "sortCondition");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00091430 File Offset: 0x0008F630
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00091438 File Offset: 0x0008F638
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition> sortCondition
		{
			get
			{
				return this.sortConditionField;
			}
			set
			{
				this.sortConditionField = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x00091441 File Offset: 0x0008F641
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00091449 File Offset: 0x0008F649
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00091452 File Offset: 0x0008F652
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x0009145A File Offset: 0x0008F65A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool columnSort
		{
			get
			{
				return this.columnSortField;
			}
			set
			{
				this.columnSortField = value;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00091463 File Offset: 0x0008F663
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x0009146B File Offset: 0x0008F66B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool caseSensitive
		{
			get
			{
				return this.caseSensitiveField;
			}
			set
			{
				this.caseSensitiveField = value;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00091474 File Offset: 0x0008F674
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x0009147C File Offset: 0x0008F67C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod sortMethod
		{
			get
			{
				return this.sortMethodField;
			}
			set
			{
				this.sortMethodField = value;
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x00091485 File Offset: 0x0008F685
		// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x0009148D File Offset: 0x0008F68D
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x0400259B RID: 9627
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortCondition> sortConditionField;

		// Token: 0x0400259C RID: 9628
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400259D RID: 9629
		private bool columnSortField;

		// Token: 0x0400259E RID: 9630
		private bool caseSensitiveField;

		// Token: 0x0400259F RID: 9631
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortMethod sortMethodField;

		// Token: 0x040025A0 RID: 9632
		private string refField;
	}
}
