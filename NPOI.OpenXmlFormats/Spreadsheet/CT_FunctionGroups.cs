using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000573 RID: 1395
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FunctionGroups
	{
		// Token: 0x06003CC6 RID: 15558 RVA: 0x00093AAC File Offset: 0x00091CAC
		public CT_FunctionGroups()
		{
			this.builtInGroupCountField = 16U;
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00093ABC File Offset: 0x00091CBC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups ct_FunctionGroups = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups();
			ct_FunctionGroups.builtInGroupCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["builtInGroupCount"]);
			ct_FunctionGroups.functionGroup = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "functionGroup")
				{
					ct_FunctionGroups.functionGroup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FunctionGroups;
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00093B64 File Offset: 0x00091D64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "builtInGroupCount", this.builtInGroupCount, false);
			sw.Write(">");
			if (this.functionGroup != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup ct_FunctionGroup in this.functionGroup)
				{
					ct_FunctionGroup.Write(sw, "functionGroup");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00093C04 File Offset: 0x00091E04
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x00093C0C File Offset: 0x00091E0C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup> functionGroup
		{
			get
			{
				return this.functionGroupField;
			}
			set
			{
				this.functionGroupField = value;
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00093C15 File Offset: 0x00091E15
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x00093C1D File Offset: 0x00091E1D
		[global::System.ComponentModel.DefaultValue(typeof(uint), "16")]
		public uint builtInGroupCount
		{
			get
			{
				return this.builtInGroupCountField;
			}
			set
			{
				this.builtInGroupCountField = value;
			}
		}

		// Token: 0x040026E1 RID: 9953
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup> functionGroupField;

		// Token: 0x040026E2 RID: 9954
		private uint builtInGroupCountField;
	}
}
