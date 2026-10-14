using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200034D RID: 845
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualDrawingProps
	{
		// Token: 0x0600213E RID: 8510 RVA: 0x00057830 File Offset: 0x00055A30
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps();
			ct_NonVisualDrawingProps.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			ct_NonVisualDrawingProps.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_NonVisualDrawingProps.descr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["descr"]);
			ct_NonVisualDrawingProps.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "hlinkClick")
				{
					ct_NonVisualDrawingProps.hlinkClick = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlinkHover")
				{
					ct_NonVisualDrawingProps.hlinkHover = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualDrawingProps.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualDrawingProps;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0005795C File Offset: 0x00055B5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "descr", this.descr.Replace("\n", "&#xA;").Replace("\r", "&#xD;"));
			if (this.hidden)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			}
			if (this.hlinkClick == null && this.hlinkHover == null && this.extLst == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			if (this.hlinkClick != null)
			{
				this.hlinkClick.Write(sw, "hlinkClick");
			}
			if (this.hlinkHover != null)
			{
				this.hlinkHover.Write(sw, "hlinkHover");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00057A70 File Offset: 0x00055C70
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00057A78 File Offset: 0x00055C78
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClick
		{
			get
			{
				return this.hlinkClickField;
			}
			set
			{
				this.hlinkClickField = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00057A81 File Offset: 0x00055C81
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x00057A89 File Offset: 0x00055C89
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHover
		{
			get
			{
				return this.hlinkHoverField;
			}
			set
			{
				this.hlinkHoverField = value;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00057A92 File Offset: 0x00055C92
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x00057A9A File Offset: 0x00055C9A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00057AA3 File Offset: 0x00055CA3
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x00057AAB File Offset: 0x00055CAB
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
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

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00057AB4 File Offset: 0x00055CB4
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x00057ABC File Offset: 0x00055CBC
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

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00057AC5 File Offset: 0x00055CC5
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x00057ADB File Offset: 0x00055CDB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string descr
		{
			get
			{
				if (this.descrField != null)
				{
					return this.descrField;
				}
				return "";
			}
			set
			{
				this.descrField = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x00057AE4 File Offset: 0x00055CE4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool descrSpecified
		{
			get
			{
				return this.descrField != null;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x00057AEF File Offset: 0x00055CEF
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00057B0B File Offset: 0x00055D0B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField != null && this.hiddenField.Value;
			}
			set
			{
				this.hiddenField = new bool?(value);
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00057B19 File Offset: 0x00055D19
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hiddenSpecified
		{
			get
			{
				return this.hiddenField != null;
			}
		}

		// Token: 0x0400197F RID: 6527
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClickField;

		// Token: 0x04001980 RID: 6528
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHoverField;

		// Token: 0x04001981 RID: 6529
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001982 RID: 6530
		private uint idField;

		// Token: 0x04001983 RID: 6531
		private string nameField;

		// Token: 0x04001984 RID: 6532
		private string descrField;

		// Token: 0x04001985 RID: 6533
		private bool? hiddenField;
	}
}
