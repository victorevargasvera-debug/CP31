using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000348 RID: 840
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("theme", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_OfficeStyleSheet
	{
		// Token: 0x06002111 RID: 8465 RVA: 0x00057194 File Offset: 0x00055394
		public static global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet ct_OfficeStyleSheet = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet();
			ct_OfficeStyleSheet.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_OfficeStyleSheet.custClrLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "themeElements")
				{
					ct_OfficeStyleSheet.themeElements = global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "objectDefaults")
				{
					ct_OfficeStyleSheet.objectDefaults = global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_OfficeStyleSheet.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extraClrSchemeLst")
				{
					if (ct_OfficeStyleSheet.extraClrSchemeLst == null)
					{
						ct_OfficeStyleSheet.extraClrSchemeLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping>();
					}
					ct_OfficeStyleSheet.extraClrSchemeLst.Add(global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "custClrLst")
				{
					ct_OfficeStyleSheet.custClrLst.Add(global::NPOI.OpenXmlFormats.Dml.CT_CustomColor.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_OfficeStyleSheet;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000572E4 File Offset: 0x000554E4
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<a:theme xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			if (this.themeElements != null)
			{
				this.themeElements.Write(sw, "themeElements");
			}
			if (this.objectDefaults != null)
			{
				this.objectDefaults.Write(sw, "objectDefaults");
			}
			if (this.extraClrSchemeLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping ct_ColorSchemeAndMapping in this.extraClrSchemeLst)
				{
					ct_ColorSchemeAndMapping.Write(sw, "extraClrSchemeLst");
				}
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.custClrLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_CustomColor ct_CustomColor in this.custClrLst)
				{
					ct_CustomColor.Write(sw, "custClrLst");
				}
			}
			sw.Write(string.Format("</a:theme>", new object[0]));
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00057418 File Offset: 0x00055618
		public void AddNewThemeElements()
		{
			this.themeElementsField = new global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles();
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00057425 File Offset: 0x00055625
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0005742D File Offset: 0x0005562D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles themeElements
		{
			get
			{
				return this.themeElementsField;
			}
			set
			{
				this.themeElementsField = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00057436 File Offset: 0x00055636
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x0005743E File Offset: 0x0005563E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults objectDefaults
		{
			get
			{
				return this.objectDefaultsField;
			}
			set
			{
				this.objectDefaultsField = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x00057447 File Offset: 0x00055647
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x0005744F File Offset: 0x0005564F
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping> extraClrSchemeLst
		{
			get
			{
				return this.extraClrSchemeLstField;
			}
			set
			{
				this.extraClrSchemeLstField = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00057458 File Offset: 0x00055658
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x00057460 File Offset: 0x00055660
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor> custClrLst
		{
			get
			{
				return this.custClrLstField;
			}
			set
			{
				this.custClrLstField = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x00057469 File Offset: 0x00055669
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x00057471 File Offset: 0x00055671
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0005747A File Offset: 0x0005567A
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00057482 File Offset: 0x00055682
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x04001970 RID: 6512
		private global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles themeElementsField;

		// Token: 0x04001971 RID: 6513
		private global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults objectDefaultsField;

		// Token: 0x04001972 RID: 6514
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping> extraClrSchemeLstField;

		// Token: 0x04001973 RID: 6515
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_CustomColor> custClrLstField;

		// Token: 0x04001974 RID: 6516
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001975 RID: 6517
		private string nameField;
	}
}
