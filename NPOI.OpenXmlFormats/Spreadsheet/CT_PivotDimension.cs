using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B4 RID: 1204
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotDimension
	{
		// Token: 0x06003143 RID: 12611 RVA: 0x0007B8C8 File Offset: 0x00079AC8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension ct_PivotDimension = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension();
			if (node.Attributes["measure"] != null)
			{
				ct_PivotDimension.measure = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["measure"]);
			}
			ct_PivotDimension.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_PivotDimension.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			ct_PivotDimension.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			return ct_PivotDimension;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0007B960 File Offset: 0x00079B60
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measure", this.measure);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0007B9DE File Offset: 0x00079BDE
		public CT_PivotDimension()
		{
			this.measureField = false;
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x0007B9ED File Offset: 0x00079BED
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x0007B9F5 File Offset: 0x00079BF5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool measure
		{
			get
			{
				return this.measureField;
			}
			set
			{
				this.measureField = value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x0007B9FE File Offset: 0x00079BFE
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x0007BA06 File Offset: 0x00079C06
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x0007BA0F File Offset: 0x00079C0F
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x0007BA17 File Offset: 0x00079C17
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

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0007BA20 File Offset: 0x00079C20
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x0007BA28 File Offset: 0x00079C28
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

		// Token: 0x04002142 RID: 8514
		private bool measureField;

		// Token: 0x04002143 RID: 8515
		private string nameField;

		// Token: 0x04002144 RID: 8516
		private string uniqueNameField;

		// Token: 0x04002145 RID: 8517
		private string captionField;
	}
}
