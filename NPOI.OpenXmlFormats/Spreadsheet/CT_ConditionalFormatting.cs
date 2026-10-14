using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200059C RID: 1436
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ConditionalFormatting
	{
		// Token: 0x06003F48 RID: 16200 RVA: 0x000996C0 File Offset: 0x000978C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting();
			ct_ConditionalFormatting.pivot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pivot"]);
			ct_ConditionalFormatting.sqref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"]);
			ct_ConditionalFormatting.cfRule = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ConditionalFormatting.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cfRule")
				{
					ct_ConditionalFormatting.cfRule.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ConditionalFormatting;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000997A4 File Offset: 0x000979A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.pivot)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pivot", this.pivot);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", this.sqref);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.cfRule != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ct_CfRule in this.cfRule)
				{
					ct_CfRule.Write(sw, "cfRule");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x00099874 File Offset: 0x00097A74
		public CT_ConditionalFormatting()
		{
			this.pivotField = false;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00099883 File Offset: 0x00097A83
		public int sizeOfCfRuleArray()
		{
			if (this.cfRule == null)
			{
				return 0;
			}
			return this.cfRule.Count;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0009989A File Offset: 0x00097A9A
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting obj)
		{
			this.cfRuleField = obj.cfRuleField;
			this.extLstField = obj.extLstField;
			this.pivotField = obj.pivotField;
			this.sqrefField = obj.sqrefField;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x000998CC File Offset: 0x00097ACC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule GetCfRuleArray(int index)
		{
			return this.cfRule[index];
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x000998DC File Offset: 0x00097ADC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule AddNewCfRule()
		{
			if (this.cfRule == null)
			{
				this.cfRule = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ct_CfRule = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule();
			this.cfRule.Add(ct_CfRule);
			return ct_CfRule;
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x0009990F File Offset: 0x00097B0F
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x00099917 File Offset: 0x00097B17
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule> cfRule
		{
			get
			{
				return this.cfRuleField;
			}
			set
			{
				this.cfRuleField = value;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x00099920 File Offset: 0x00097B20
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x00099928 File Offset: 0x00097B28
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

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x00099931 File Offset: 0x00097B31
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00099939 File Offset: 0x00097B39
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pivot
		{
			get
			{
				return this.pivotField;
			}
			set
			{
				this.pivotField = value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x00099942 File Offset: 0x00097B42
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x0009994A File Offset: 0x00097B4A
		[global::System.Xml.Serialization.XmlAttribute]
		public string sqref
		{
			get
			{
				return this.sqrefField;
			}
			set
			{
				this.sqrefField = value;
			}
		}

		// Token: 0x04002814 RID: 10260
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule> cfRuleField;

		// Token: 0x04002815 RID: 10261
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002816 RID: 10262
		private bool pivotField;

		// Token: 0x04002817 RID: 10263
		private string sqrefField;
	}
}
