using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200031F RID: 799
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SolidColorFillProperties
	{
		// Token: 0x06001FCC RID: 8140 RVA: 0x00054E4C File Offset: 0x0005304C
		public static global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_SolidColorFillProperties.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_SolidColorFillProperties.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_SolidColorFillProperties.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_SolidColorFillProperties.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_SolidColorFillProperties.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_SolidColorFillProperties.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SolidColorFillProperties;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00054F7C File Offset: 0x0005317C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0005504C File Offset: 0x0005324C
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00055054 File Offset: 0x00053254
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0005505D File Offset: 0x0005325D
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00055065 File Offset: 0x00053265
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0005506E File Offset: 0x0005326E
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00055076 File Offset: 0x00053276
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

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0005507F File Offset: 0x0005327F
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00055087 File Offset: 0x00053287
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

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00055090 File Offset: 0x00053290
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x00055098 File Offset: 0x00053298
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

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000550A1 File Offset: 0x000532A1
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x000550A9 File Offset: 0x000532A9
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

		// Token: 0x06001FDA RID: 8154 RVA: 0x000550B2 File Offset: 0x000532B2
		public bool IsSetSrgbClr()
		{
			return this.srgbClrField != null;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000550BD File Offset: 0x000532BD
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor AddNewSrgbClr()
		{
			this.srgbClrField = new global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor();
			return this.srgbClrField;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000550D0 File Offset: 0x000532D0
		public bool IsSetHslClr()
		{
			return this.hslClrField != null;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000550DB File Offset: 0x000532DB
		public bool IsSetPrstClr()
		{
			return this.prstClrField != null;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000550E6 File Offset: 0x000532E6
		public bool IsSetSchemeClr()
		{
			return this.schemeClrField != null;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000550F1 File Offset: 0x000532F1
		public bool IsSetScrgbClr()
		{
			return this.scrgbClrField != null;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000550FC File Offset: 0x000532FC
		public bool IsSetSysClr()
		{
			return this.sysClrField != null;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00055107 File Offset: 0x00053307
		public void UnsetHslClr()
		{
			this.hslClrField = null;
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00055110 File Offset: 0x00053310
		public void UnsetPrstClr()
		{
			this.prstClrField = null;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00055119 File Offset: 0x00053319
		public void UnsetSchemeClr()
		{
			this.schemeClrField = null;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00055122 File Offset: 0x00053322
		public void UnsetScrgbClr()
		{
			this.scrgbClrField = null;
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0005512B File Offset: 0x0005332B
		public void UnsetSysClr()
		{
			this.sysClrField = null;
		}

		// Token: 0x040018A7 RID: 6311
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x040018A8 RID: 6312
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x040018A9 RID: 6313
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x040018AA RID: 6314
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x040018AB RID: 6315
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x040018AC RID: 6316
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;
	}
}
