using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A2 RID: 1186
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_GroupMember
	{
		// Token: 0x06003050 RID: 12368 RVA: 0x00079264 File Offset: 0x00077464
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember ct_GroupMember = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember();
			ct_GroupMember.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			if (node.Attributes["group"] != null)
			{
				ct_GroupMember.group = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["group"]);
			}
			return ct_GroupMember;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000792C8 File Offset: 0x000774C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "group", this.group);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00079324 File Offset: 0x00077524
		public CT_GroupMember()
		{
			this.groupField = false;
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x00079333 File Offset: 0x00077533
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x0007933B File Offset: 0x0007753B
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

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x00079344 File Offset: 0x00077544
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x0007934C File Offset: 0x0007754C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool group
		{
			get
			{
				return this.groupField;
			}
			set
			{
				this.groupField = value;
			}
		}

		// Token: 0x040020DA RID: 8410
		private string uniqueNameField;

		// Token: 0x040020DB RID: 8411
		private bool groupField;
	}
}
