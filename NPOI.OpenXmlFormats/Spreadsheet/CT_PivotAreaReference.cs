using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000581 RID: 1409
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotAreaReference
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x00095A74 File Offset: 0x00093C74
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference ct_PivotAreaReference = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference();
			ct_PivotAreaReference.field = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["field"]);
			ct_PivotAreaReference.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_PivotAreaReference.selected = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["selected"]);
			ct_PivotAreaReference.byPosition = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["byPosition"]);
			ct_PivotAreaReference.relative = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["relative"]);
			ct_PivotAreaReference.defaultSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["defaultSubtotal"]);
			ct_PivotAreaReference.sumSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sumSubtotal"]);
			ct_PivotAreaReference.countASubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["countASubtotal"]);
			ct_PivotAreaReference.avgSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["avgSubtotal"]);
			ct_PivotAreaReference.maxSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["maxSubtotal"]);
			ct_PivotAreaReference.minSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["minSubtotal"]);
			ct_PivotAreaReference.productSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["productSubtotal"]);
			ct_PivotAreaReference.countSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["countSubtotal"]);
			ct_PivotAreaReference.stdDevSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stdDevSubtotal"]);
			ct_PivotAreaReference.stdDevPSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stdDevPSubtotal"]);
			ct_PivotAreaReference.varSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["varSubtotal"]);
			ct_PivotAreaReference.varPSubtotal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["varPSubtotal"]);
			ct_PivotAreaReference.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_PivotAreaReference.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_PivotAreaReference.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotAreaReference;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00095CF0 File Offset: 0x00093EF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "field", this.field, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "selected", this.selected);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "byPosition", this.byPosition);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "relative", this.relative);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultSubtotal", this.defaultSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sumSubtotal", this.sumSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "countASubtotal", this.countASubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "avgSubtotal", this.avgSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxSubtotal", this.maxSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minSubtotal", this.minSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "productSubtotal", this.productSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "countSubtotal", this.countSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stdDevSubtotal", this.stdDevSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stdDevPSubtotal", this.stdDevPSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "varSubtotal", this.varSubtotal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "varPSubtotal", this.varPSubtotal);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.x != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index ct_Index in this.x)
				{
					ct_Index.Write(sw, "x");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00095EB8 File Offset: 0x000940B8
		public CT_PivotAreaReference()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index>();
			this.selectedField = true;
			this.byPositionField = false;
			this.relativeField = false;
			this.defaultSubtotalField = false;
			this.sumSubtotalField = false;
			this.countASubtotalField = false;
			this.avgSubtotalField = false;
			this.maxSubtotalField = false;
			this.minSubtotalField = false;
			this.productSubtotalField = false;
			this.countSubtotalField = false;
			this.stdDevSubtotalField = false;
			this.stdDevPSubtotalField = false;
			this.varSubtotalField = false;
			this.varPSubtotalField = false;
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x00095F4A File Offset: 0x0009414A
		// (set) Token: 0x06003DA4 RID: 15780 RVA: 0x00095F52 File Offset: 0x00094152
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index> x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x00095F5B File Offset: 0x0009415B
		// (set) Token: 0x06003DA6 RID: 15782 RVA: 0x00095F63 File Offset: 0x00094163
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

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x00095F6C File Offset: 0x0009416C
		// (set) Token: 0x06003DA8 RID: 15784 RVA: 0x00095F74 File Offset: 0x00094174
		public uint field
		{
			get
			{
				return this.fieldField;
			}
			set
			{
				this.fieldField = value;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x00095F7D File Offset: 0x0009417D
		// (set) Token: 0x06003DAA RID: 15786 RVA: 0x00095F85 File Offset: 0x00094185
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fieldSpecified
		{
			get
			{
				return this.fieldFieldSpecified;
			}
			set
			{
				this.fieldFieldSpecified = value;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00095F8E File Offset: 0x0009418E
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00095F96 File Offset: 0x00094196
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

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00095F9F File Offset: 0x0009419F
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x00095FA7 File Offset: 0x000941A7
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

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x00095FB0 File Offset: 0x000941B0
		// (set) Token: 0x06003DB0 RID: 15792 RVA: 0x00095FB8 File Offset: 0x000941B8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool selected
		{
			get
			{
				return this.selectedField;
			}
			set
			{
				this.selectedField = value;
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00095FC1 File Offset: 0x000941C1
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x00095FC9 File Offset: 0x000941C9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool byPosition
		{
			get
			{
				return this.byPositionField;
			}
			set
			{
				this.byPositionField = value;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x00095FD2 File Offset: 0x000941D2
		// (set) Token: 0x06003DB4 RID: 15796 RVA: 0x00095FDA File Offset: 0x000941DA
		[global::System.ComponentModel.DefaultValue(false)]
		public bool relative
		{
			get
			{
				return this.relativeField;
			}
			set
			{
				this.relativeField = value;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00095FE3 File Offset: 0x000941E3
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x00095FEB File Offset: 0x000941EB
		[global::System.ComponentModel.DefaultValue(false)]
		public bool defaultSubtotal
		{
			get
			{
				return this.defaultSubtotalField;
			}
			set
			{
				this.defaultSubtotalField = value;
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x00095FF4 File Offset: 0x000941F4
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x00095FFC File Offset: 0x000941FC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool sumSubtotal
		{
			get
			{
				return this.sumSubtotalField;
			}
			set
			{
				this.sumSubtotalField = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x00096005 File Offset: 0x00094205
		// (set) Token: 0x06003DBA RID: 15802 RVA: 0x0009600D File Offset: 0x0009420D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool countASubtotal
		{
			get
			{
				return this.countASubtotalField;
			}
			set
			{
				this.countASubtotalField = value;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x00096016 File Offset: 0x00094216
		// (set) Token: 0x06003DBC RID: 15804 RVA: 0x0009601E File Offset: 0x0009421E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool avgSubtotal
		{
			get
			{
				return this.avgSubtotalField;
			}
			set
			{
				this.avgSubtotalField = value;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x00096027 File Offset: 0x00094227
		// (set) Token: 0x06003DBE RID: 15806 RVA: 0x0009602F File Offset: 0x0009422F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool maxSubtotal
		{
			get
			{
				return this.maxSubtotalField;
			}
			set
			{
				this.maxSubtotalField = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x00096038 File Offset: 0x00094238
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x00096040 File Offset: 0x00094240
		[global::System.ComponentModel.DefaultValue(false)]
		public bool minSubtotal
		{
			get
			{
				return this.minSubtotalField;
			}
			set
			{
				this.minSubtotalField = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x00096049 File Offset: 0x00094249
		// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x00096051 File Offset: 0x00094251
		[global::System.ComponentModel.DefaultValue(false)]
		public bool productSubtotal
		{
			get
			{
				return this.productSubtotalField;
			}
			set
			{
				this.productSubtotalField = value;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x0009605A File Offset: 0x0009425A
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x00096062 File Offset: 0x00094262
		[global::System.ComponentModel.DefaultValue(false)]
		public bool countSubtotal
		{
			get
			{
				return this.countSubtotalField;
			}
			set
			{
				this.countSubtotalField = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x0009606B File Offset: 0x0009426B
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x00096073 File Offset: 0x00094273
		[global::System.ComponentModel.DefaultValue(false)]
		public bool stdDevSubtotal
		{
			get
			{
				return this.stdDevSubtotalField;
			}
			set
			{
				this.stdDevSubtotalField = value;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x0009607C File Offset: 0x0009427C
		// (set) Token: 0x06003DC8 RID: 15816 RVA: 0x00096084 File Offset: 0x00094284
		[global::System.ComponentModel.DefaultValue(false)]
		public bool stdDevPSubtotal
		{
			get
			{
				return this.stdDevPSubtotalField;
			}
			set
			{
				this.stdDevPSubtotalField = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x0009608D File Offset: 0x0009428D
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x00096095 File Offset: 0x00094295
		[global::System.ComponentModel.DefaultValue(false)]
		public bool varSubtotal
		{
			get
			{
				return this.varSubtotalField;
			}
			set
			{
				this.varSubtotalField = value;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x0009609E File Offset: 0x0009429E
		// (set) Token: 0x06003DCC RID: 15820 RVA: 0x000960A6 File Offset: 0x000942A6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool varPSubtotal
		{
			get
			{
				return this.varPSubtotalField;
			}
			set
			{
				this.varPSubtotalField = value;
			}
		}

		// Token: 0x04002740 RID: 10048
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index> xField;

		// Token: 0x04002741 RID: 10049
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002742 RID: 10050
		private uint fieldField;

		// Token: 0x04002743 RID: 10051
		private bool fieldFieldSpecified;

		// Token: 0x04002744 RID: 10052
		private uint countField;

		// Token: 0x04002745 RID: 10053
		private bool countFieldSpecified;

		// Token: 0x04002746 RID: 10054
		private bool selectedField;

		// Token: 0x04002747 RID: 10055
		private bool byPositionField;

		// Token: 0x04002748 RID: 10056
		private bool relativeField;

		// Token: 0x04002749 RID: 10057
		private bool defaultSubtotalField;

		// Token: 0x0400274A RID: 10058
		private bool sumSubtotalField;

		// Token: 0x0400274B RID: 10059
		private bool countASubtotalField;

		// Token: 0x0400274C RID: 10060
		private bool avgSubtotalField;

		// Token: 0x0400274D RID: 10061
		private bool maxSubtotalField;

		// Token: 0x0400274E RID: 10062
		private bool minSubtotalField;

		// Token: 0x0400274F RID: 10063
		private bool productSubtotalField;

		// Token: 0x04002750 RID: 10064
		private bool countSubtotalField;

		// Token: 0x04002751 RID: 10065
		private bool stdDevSubtotalField;

		// Token: 0x04002752 RID: 10066
		private bool stdDevPSubtotalField;

		// Token: 0x04002753 RID: 10067
		private bool varSubtotalField;

		// Token: 0x04002754 RID: 10068
		private bool varPSubtotalField;
	}
}
