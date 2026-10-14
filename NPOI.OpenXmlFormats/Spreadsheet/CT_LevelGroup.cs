using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A0 RID: 1184
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_LevelGroup
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x00078E74 File Offset: 0x00077074
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup ct_LevelGroup = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup();
			ct_LevelGroup.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_LevelGroup.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			ct_LevelGroup.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			ct_LevelGroup.uniqueParent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueParent"]);
			if (node.Attributes["id"] != null)
			{
				ct_LevelGroup.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["id"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "groupMembers")
				{
					ct_LevelGroup.groupMembers = global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_LevelGroup;
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00078F8C File Offset: 0x0007718C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueParent", this.uniqueParent);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			sw.Write(">");
			if (this.groupMembers != null)
			{
				this.groupMembers.Write(sw, "groupMembers");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00079034 File Offset: 0x00077234
		public CT_LevelGroup()
		{
			this.groupMembersField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers();
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x00079047 File Offset: 0x00077247
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x0007904F File Offset: 0x0007724F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers groupMembers
		{
			get
			{
				return this.groupMembersField;
			}
			set
			{
				this.groupMembersField = value;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x00079058 File Offset: 0x00077258
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x00079060 File Offset: 0x00077260
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x00079069 File Offset: 0x00077269
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x00079071 File Offset: 0x00077271
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

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x0007907A File Offset: 0x0007727A
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x00079082 File Offset: 0x00077282
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

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x0007908B File Offset: 0x0007728B
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x00079093 File Offset: 0x00077293
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueParent
		{
			get
			{
				return this.uniqueParentField;
			}
			set
			{
				this.uniqueParentField = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x0007909C File Offset: 0x0007729C
		// (set) Token: 0x06003044 RID: 12356 RVA: 0x000790A4 File Offset: 0x000772A4
		[global::System.Xml.Serialization.XmlAttribute]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x000790AD File Offset: 0x000772AD
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x000790B5 File Offset: 0x000772B5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool idSpecified
		{
			get
			{
				return this.idFieldSpecified;
			}
			set
			{
				this.idFieldSpecified = value;
			}
		}

		// Token: 0x040020D0 RID: 8400
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers groupMembersField;

		// Token: 0x040020D1 RID: 8401
		private string nameField;

		// Token: 0x040020D2 RID: 8402
		private string uniqueNameField;

		// Token: 0x040020D3 RID: 8403
		private string captionField;

		// Token: 0x040020D4 RID: 8404
		private string uniqueParentField;

		// Token: 0x040020D5 RID: 8405
		private int idField;

		// Token: 0x040020D6 RID: 8406
		private bool idFieldSpecified;
	}
}
