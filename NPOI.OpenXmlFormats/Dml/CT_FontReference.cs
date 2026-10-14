using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F4 RID: 756
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontReference
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x0004F634 File Offset: 0x0004D834
		public static global::NPOI.OpenXmlFormats.Dml.CT_FontReference Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_FontReference ct_FontReference = new global::NPOI.OpenXmlFormats.Dml.CT_FontReference();
			if (node.Attributes["idx"] != null)
			{
				ct_FontReference.idx = (global::NPOI.OpenXmlFormats.Dml.ST_FontCollectionIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_FontCollectionIndex), node.Attributes["idx"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_FontReference.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_FontReference.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_FontReference.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_FontReference.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_FontReference.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_FontReference.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FontReference;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0004F7A4 File Offset: 0x0004D9A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idx", this.idx.ToString());
			sw.Write(">");
			if (this.scrgbClr != null)
			{
				this.scrgbClr.Write(sw, "scrgbClr");
			}
			if (this.srgbClr != null)
			{
				this.srgbClr.Write(sw, "srgbClr");
			}
			if (this.hslClr != null)
			{
				this.hslClr.Write(sw, "hslClr");
			}
			if (this.sysClr != null)
			{
				this.sysClr.Write(sw, "sysClr");
			}
			if (this.schemeClr != null)
			{
				this.schemeClr.Write(sw, "schemeClr");
			}
			if (this.prstClr != null)
			{
				this.prstClr.Write(sw, "prstClr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0004F893 File Offset: 0x0004DA93
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0004F89B File Offset: 0x0004DA9B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClr
		{
			get
			{
				return this.scrgbClrField;
			}
			set
			{
				this.scrgbClrField = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0004F8A4 File Offset: 0x0004DAA4
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0004F8AC File Offset: 0x0004DAAC
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClr
		{
			get
			{
				return this.srgbClrField;
			}
			set
			{
				this.srgbClrField = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0004F8B5 File Offset: 0x0004DAB5
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0004F8BD File Offset: 0x0004DABD
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClr
		{
			get
			{
				return this.hslClrField;
			}
			set
			{
				this.hslClrField = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0004F8C6 File Offset: 0x0004DAC6
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0004F8CE File Offset: 0x0004DACE
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClr
		{
			get
			{
				return this.sysClrField;
			}
			set
			{
				this.sysClrField = value;
			}
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0004F8D7 File Offset: 0x0004DAD7
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor AddNewSchemeClr()
		{
			this.schemeClrField = new global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor();
			return this.schemeClrField;
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0004F8EA File Offset: 0x0004DAEA
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x0004F8F2 File Offset: 0x0004DAF2
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClr
		{
			get
			{
				return this.schemeClrField;
			}
			set
			{
				this.schemeClrField = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0004F8FB File Offset: 0x0004DAFB
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0004F903 File Offset: 0x0004DB03
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClr
		{
			get
			{
				return this.prstClrField;
			}
			set
			{
				this.prstClrField = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0004F90C File Offset: 0x0004DB0C
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0004F914 File Offset: 0x0004DB14
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_FontCollectionIndex idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x0400177B RID: 6011
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400177C RID: 6012
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400177D RID: 6013
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x0400177E RID: 6014
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x0400177F RID: 6015
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001780 RID: 6016
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x04001781 RID: 6017
		private global::NPOI.OpenXmlFormats.Dml.ST_FontCollectionIndex idxField;
	}
}
