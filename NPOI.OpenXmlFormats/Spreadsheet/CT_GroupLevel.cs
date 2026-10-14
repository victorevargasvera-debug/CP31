using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049E RID: 1182
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_GroupLevel
	{
		// Token: 0x0600301E RID: 12318 RVA: 0x00078A5C File Offset: 0x00076C5C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel ct_GroupLevel = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel();
			ct_GroupLevel.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			ct_GroupLevel.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			if (node.Attributes["user"] != null)
			{
				ct_GroupLevel.user = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["user"]);
			}
			if (node.Attributes["customRollUp"] != null)
			{
				ct_GroupLevel.customRollUp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customRollUp"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "groups")
				{
					ct_GroupLevel.groups = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_GroupLevel.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupLevel;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00078B8C File Offset: 0x00076D8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "user", this.user);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customRollUp", this.customRollUp);
			sw.Write(">");
			if (this.groups != null)
			{
				this.groups.Write(sw, "groups");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00078C3C File Offset: 0x00076E3C
		public CT_GroupLevel()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.groupsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups();
			this.userField = false;
			this.customRollUpField = false;
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00078C68 File Offset: 0x00076E68
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00078C70 File Offset: 0x00076E70
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups groups
		{
			get
			{
				return this.groupsField;
			}
			set
			{
				this.groupsField = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00078C79 File Offset: 0x00076E79
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x00078C81 File Offset: 0x00076E81
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

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x00078C8A File Offset: 0x00076E8A
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x00078C92 File Offset: 0x00076E92
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x00078C9B File Offset: 0x00076E9B
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x00078CA3 File Offset: 0x00076EA3
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x00078CAC File Offset: 0x00076EAC
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00078CB4 File Offset: 0x00076EB4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool user
		{
			get
			{
				return this.userField;
			}
			set
			{
				this.userField = value;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x00078CBD File Offset: 0x00076EBD
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x00078CC5 File Offset: 0x00076EC5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool customRollUp
		{
			get
			{
				return this.customRollUpField;
			}
			set
			{
				this.customRollUpField = value;
			}
		}

		// Token: 0x040020C7 RID: 8391
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups groupsField;

		// Token: 0x040020C8 RID: 8392
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040020C9 RID: 8393
		private string uniqueNameField;

		// Token: 0x040020CA RID: 8394
		private string captionField;

		// Token: 0x040020CB RID: 8395
		private bool userField;

		// Token: 0x040020CC RID: 8396
		private bool customRollUpField;
	}
}
