using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058B RID: 1419
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Scenarios
	{
		// Token: 0x06003E49 RID: 15945 RVA: 0x000970EC File Offset: 0x000952EC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios ct_Scenarios = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenarios();
			ct_Scenarios.current = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["current"]);
			ct_Scenarios.show = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["show"]);
			ct_Scenarios.scenario = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario>();
			ct_Scenarios.sqref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scenario")
				{
					ct_Scenarios.scenario.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Scenarios;
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x000971CC File Offset: 0x000953CC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "current", this.current, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "show", this.show, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", this.sqref);
			sw.Write(">");
			if (this.scenario != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario ct_Scenario in this.scenario)
				{
					ct_Scenario.Write(sw, "scenario");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x0009728C File Offset: 0x0009548C
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00097294 File Offset: 0x00095494
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario> scenario
		{
			get
			{
				return this.scenarioField;
			}
			set
			{
				this.scenarioField = value;
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x0009729D File Offset: 0x0009549D
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x000972A5 File Offset: 0x000954A5
		[global::System.Xml.Serialization.XmlAttribute]
		public uint current
		{
			get
			{
				return this.currentField;
			}
			set
			{
				this.currentField = value;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x000972AE File Offset: 0x000954AE
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x000972B6 File Offset: 0x000954B6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool currentSpecified
		{
			get
			{
				return this.currentFieldSpecified;
			}
			set
			{
				this.currentFieldSpecified = value;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x000972BF File Offset: 0x000954BF
		// (set) Token: 0x06003E52 RID: 15954 RVA: 0x000972C7 File Offset: 0x000954C7
		[global::System.Xml.Serialization.XmlAttribute]
		public uint show
		{
			get
			{
				return this.showField;
			}
			set
			{
				this.showField = value;
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x000972D0 File Offset: 0x000954D0
		// (set) Token: 0x06003E54 RID: 15956 RVA: 0x000972D8 File Offset: 0x000954D8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showSpecified
		{
			get
			{
				return this.showFieldSpecified;
			}
			set
			{
				this.showFieldSpecified = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x000972E1 File Offset: 0x000954E1
		// (set) Token: 0x06003E56 RID: 15958 RVA: 0x000972E9 File Offset: 0x000954E9
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

		// Token: 0x04002798 RID: 10136
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario> scenarioField;

		// Token: 0x04002799 RID: 10137
		private uint currentField;

		// Token: 0x0400279A RID: 10138
		private bool currentFieldSpecified;

		// Token: 0x0400279B RID: 10139
		private uint showField;

		// Token: 0x0400279C RID: 10140
		private bool showFieldSpecified;

		// Token: 0x0400279D RID: 10141
		private string sqrefField;
	}
}
