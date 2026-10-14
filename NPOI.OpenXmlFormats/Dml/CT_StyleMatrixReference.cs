using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F3 RID: 755
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StyleMatrixReference
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x0004F37C File Offset: 0x0004D57C
		public static global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference ct_StyleMatrixReference = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			ct_StyleMatrixReference.idx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["idx"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_StyleMatrixReference.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_StyleMatrixReference.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_StyleMatrixReference.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_StyleMatrixReference.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_StyleMatrixReference.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_StyleMatrixReference.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_StyleMatrixReference;
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0004F4C8 File Offset: 0x0004D6C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idx", this.idx, true);
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

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0004F5AA File Offset: 0x0004D7AA
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0004F5B2 File Offset: 0x0004D7B2
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

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0004F5BB File Offset: 0x0004D7BB
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0004F5C3 File Offset: 0x0004D7C3
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x0004F5CC File Offset: 0x0004D7CC
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0004F5D4 File Offset: 0x0004D7D4
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

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0004F5DD File Offset: 0x0004D7DD
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0004F5E5 File Offset: 0x0004D7E5
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x0004F5EE File Offset: 0x0004D7EE
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor AddNewSchemeClr()
		{
			this.schemeClrField = new global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor();
			return this.schemeClrField;
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0004F601 File Offset: 0x0004D801
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0004F609 File Offset: 0x0004D809
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0004F612 File Offset: 0x0004D812
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x0004F61A File Offset: 0x0004D81A
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

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0004F623 File Offset: 0x0004D823
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0004F62B File Offset: 0x0004D82B
		[global::System.Xml.Serialization.XmlAttribute]
		public uint idx
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

		// Token: 0x04001774 RID: 6004
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x04001775 RID: 6005
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x04001776 RID: 6006
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x04001777 RID: 6007
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x04001778 RID: 6008
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001779 RID: 6009
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x0400177A RID: 6010
		private uint idxField;
	}
}
