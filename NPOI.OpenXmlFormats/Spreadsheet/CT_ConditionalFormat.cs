using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D1 RID: 1233
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ConditionalFormat
	{
		// Token: 0x0600337F RID: 13183 RVA: 0x000812F0 File Offset: 0x0007F4F0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat ct_ConditionalFormat = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat();
			if (node.Attributes["scope"] != null)
			{
				ct_ConditionalFormat.scope = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope), node.Attributes["scope"].Value);
			}
			if (node.Attributes["type"] != null)
			{
				ct_ConditionalFormat.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type), node.Attributes["type"].Value);
			}
			if (node.Attributes["priority"] != null)
			{
				ct_ConditionalFormat.priority = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["priority"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotAreas")
				{
					ct_ConditionalFormat.pivotAreas = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ConditionalFormat.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ConditionalFormat;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00081440 File Offset: 0x0007F640
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scope", this.scope.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "priority", this.priority, false);
			sw.Write(">");
			if (this.pivotAreas != null)
			{
				this.pivotAreas.Write(sw, "pivotAreas");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000814FC File Offset: 0x0007F6FC
		public CT_ConditionalFormat()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.pivotAreasField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas();
			this.scopeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope.selection;
			this.typeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type.none;
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x00081528 File Offset: 0x0007F728
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x00081530 File Offset: 0x0007F730
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas pivotAreas
		{
			get
			{
				return this.pivotAreasField;
			}
			set
			{
				this.pivotAreasField = value;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x00081539 File Offset: 0x0007F739
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x00081541 File Offset: 0x0007F741
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x0008154A File Offset: 0x0007F74A
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x00081552 File Offset: 0x0007F752
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope.selection)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x0008155B File Offset: 0x0007F75B
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00081563 File Offset: 0x0007F763
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x0008156C File Offset: 0x0007F76C
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00081574 File Offset: 0x0007F774
		[global::System.Xml.Serialization.XmlAttribute]
		public uint priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}

		// Token: 0x04002251 RID: 8785
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas pivotAreasField;

		// Token: 0x04002252 RID: 8786
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002253 RID: 8787
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Scope scopeField;

		// Token: 0x04002254 RID: 8788
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Type typeField;

		// Token: 0x04002255 RID: 8789
		private uint priorityField;
	}
}
