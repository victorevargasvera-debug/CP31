using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200029B RID: 667
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shape3D
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x00049968 File Offset: 0x00047B68
		public static global::NPOI.OpenXmlFormats.Dml.CT_Shape3D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Shape3D ct_Shape3D = new global::NPOI.OpenXmlFormats.Dml.CT_Shape3D();
			ct_Shape3D.z = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["z"]);
			ct_Shape3D.extrusionH = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["extrusionH"]);
			ct_Shape3D.contourW = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["contourW"]);
			if (node.Attributes["prstMaterial"] != null)
			{
				ct_Shape3D.prstMaterial = (global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType), node.Attributes["prstMaterial"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "bevelT")
				{
					ct_Shape3D.bevelT = global::NPOI.OpenXmlFormats.Dml.CT_Bevel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bevelB")
				{
					ct_Shape3D.bevelB = global::NPOI.OpenXmlFormats.Dml.CT_Bevel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extrusionClr")
				{
					ct_Shape3D.extrusionClr = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "contourClr")
				{
					ct_Shape3D.contourClr = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Shape3D.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Shape3D;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00049B04 File Offset: 0x00047D04
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "z", (double)this.z);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "extrusionH", (double)this.extrusionH);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "contourW", (double)this.contourW);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prstMaterial", this.prstMaterial.ToString());
			sw.Write(">");
			if (this.bevelT != null)
			{
				this.bevelT.Write(sw, "bevelT");
			}
			if (this.bevelB != null)
			{
				this.bevelB.Write(sw, "bevelB");
			}
			if (this.extrusionClr != null)
			{
				this.extrusionClr.Write(sw, "extrusionClr");
			}
			if (this.contourClr != null)
			{
				this.contourClr.Write(sw, "contourClr");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00049C10 File Offset: 0x00047E10
		public CT_Shape3D()
		{
			this.zField = 0L;
			this.extrusionHField = 0L;
			this.contourWField = 0L;
			this.prstMaterialField = global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType.warmMatte;
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00049C37 File Offset: 0x00047E37
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x00049C3F File Offset: 0x00047E3F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevelT
		{
			get
			{
				return this.bevelTField;
			}
			set
			{
				this.bevelTField = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00049C48 File Offset: 0x00047E48
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00049C50 File Offset: 0x00047E50
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevelB
		{
			get
			{
				return this.bevelBField;
			}
			set
			{
				this.bevelBField = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00049C59 File Offset: 0x00047E59
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00049C61 File Offset: 0x00047E61
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color extrusionClr
		{
			get
			{
				return this.extrusionClrField;
			}
			set
			{
				this.extrusionClrField = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00049C6A File Offset: 0x00047E6A
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00049C72 File Offset: 0x00047E72
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color contourClr
		{
			get
			{
				return this.contourClrField;
			}
			set
			{
				this.contourClrField = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00049C7B File Offset: 0x00047E7B
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00049C83 File Offset: 0x00047E83
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00049C8C File Offset: 0x00047E8C
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00049C94 File Offset: 0x00047E94
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long z
		{
			get
			{
				return this.zField;
			}
			set
			{
				this.zField = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00049C9D File Offset: 0x00047E9D
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00049CA5 File Offset: 0x00047EA5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long extrusionH
		{
			get
			{
				return this.extrusionHField;
			}
			set
			{
				this.extrusionHField = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00049CAE File Offset: 0x00047EAE
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x00049CB6 File Offset: 0x00047EB6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long contourW
		{
			get
			{
				return this.contourWField;
			}
			set
			{
				this.contourWField = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00049CBF File Offset: 0x00047EBF
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x00049CC7 File Offset: 0x00047EC7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType.warmMatte)]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType prstMaterial
		{
			get
			{
				return this.prstMaterialField;
			}
			set
			{
				this.prstMaterialField = value;
			}
		}

		// Token: 0x0400144E RID: 5198
		private global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevelTField;

		// Token: 0x0400144F RID: 5199
		private global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevelBField;

		// Token: 0x04001450 RID: 5200
		private global::NPOI.OpenXmlFormats.Dml.CT_Color extrusionClrField;

		// Token: 0x04001451 RID: 5201
		private global::NPOI.OpenXmlFormats.Dml.CT_Color contourClrField;

		// Token: 0x04001452 RID: 5202
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001453 RID: 5203
		private long zField;

		// Token: 0x04001454 RID: 5204
		private long extrusionHField;

		// Token: 0x04001455 RID: 5205
		private long contourWField;

		// Token: 0x04001456 RID: 5206
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType prstMaterialField;
	}
}
