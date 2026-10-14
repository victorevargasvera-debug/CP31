using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200025B RID: 603
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ObjectStyleDefaults
	{
		// Token: 0x0600188F RID: 6287 RVA: 0x00043F34 File Offset: 0x00042134
		public static global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults ct_ObjectStyleDefaults = new global::NPOI.OpenXmlFormats.Dml.CT_ObjectStyleDefaults();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spDef")
				{
					ct_ObjectStyleDefaults.spDef = global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lnDef")
				{
					ct_ObjectStyleDefaults.lnDef = global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txDef")
				{
					ct_ObjectStyleDefaults.txDef = global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ObjectStyleDefaults.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ObjectStyleDefaults;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0004401C File Offset: 0x0004221C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.spDef != null)
			{
				this.spDef.Write(sw, "spDef");
			}
			if (this.lnDef != null)
			{
				this.lnDef.Write(sw, "lnDef");
			}
			if (this.txDef != null)
			{
				this.txDef.Write(sw, "txDef");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x000440BA File Offset: 0x000422BA
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x000440C2 File Offset: 0x000422C2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition spDef
		{
			get
			{
				return this.spDefField;
			}
			set
			{
				this.spDefField = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x000440CB File Offset: 0x000422CB
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x000440D3 File Offset: 0x000422D3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition lnDef
		{
			get
			{
				return this.lnDefField;
			}
			set
			{
				this.lnDefField = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x000440DC File Offset: 0x000422DC
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x000440E4 File Offset: 0x000422E4
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition txDef
		{
			get
			{
				return this.txDefField;
			}
			set
			{
				this.txDefField = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x000440ED File Offset: 0x000422ED
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x000440F5 File Offset: 0x000422F5
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x040012C6 RID: 4806
		private global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition spDefField;

		// Token: 0x040012C7 RID: 4807
		private global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition lnDefField;

		// Token: 0x040012C8 RID: 4808
		private global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition txDefField;

		// Token: 0x040012C9 RID: 4809
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
