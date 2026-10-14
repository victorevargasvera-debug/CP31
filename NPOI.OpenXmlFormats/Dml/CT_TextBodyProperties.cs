using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200030C RID: 780
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBodyProperties
	{
		// Token: 0x06001E7F RID: 7807 RVA: 0x000525FE File Offset: 0x000507FE
		public CT_TextBodyProperties()
		{
			this.uprightField = false;
			this.vertField = global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType.horz;
			this.wrapField = global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType.none;
			this.spcFirstLastParaField = false;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00052624 File Offset: 0x00050824
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties ct_TextBodyProperties = new global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties();
			ct_TextBodyProperties.rotFieldSpecified = (node.Attributes["rot"] != null);
			ct_TextBodyProperties.rotField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["rot"]);
			ct_TextBodyProperties.spcFirstLastPara = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["spcFirstLastPara"]);
			ct_TextBodyProperties.vertOverflowFieldSpecified = (node.Attributes["vertOverflow"] != null);
			if (node.Attributes["vertOverflow"] != null)
			{
				ct_TextBodyProperties.vertOverflowField = (global::NPOI.OpenXmlFormats.Dml.ST_TextVertOverflowType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextVertOverflowType), node.Attributes["vertOverflow"].Value);
			}
			ct_TextBodyProperties.horzOverflowFieldSpecified = (node.Attributes["horzOverflow"] != null);
			if (node.Attributes["horzOverflow"] != null)
			{
				ct_TextBodyProperties.horzOverflowField = (global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType), node.Attributes["horzOverflow"].Value);
			}
			ct_TextBodyProperties.vertFieldSpecified = (node.Attributes["vert"] != null);
			if (node.Attributes["vert"] != null)
			{
				ct_TextBodyProperties.vertField = (global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType), node.Attributes["vert"].Value);
			}
			ct_TextBodyProperties.wrapFieldSpecified = (node.Attributes["wrap"] != null);
			if (node.Attributes["wrap"] != null)
			{
				ct_TextBodyProperties.wrapField = (global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType), node.Attributes["wrap"].Value);
			}
			ct_TextBodyProperties.lIns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lIns"]);
			ct_TextBodyProperties.tIns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["tIns"]);
			ct_TextBodyProperties.rIns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["rIns"]);
			ct_TextBodyProperties.bIns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["bIns"]);
			ct_TextBodyProperties.numCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["numCol"]);
			ct_TextBodyProperties.spcCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["spcCol"]);
			ct_TextBodyProperties.rtlCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rtlCol"]);
			ct_TextBodyProperties.fromWordArt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fromWordArt"]);
			ct_TextBodyProperties.anchorFieldSpecified = (node.Attributes["anchor"] != null);
			if (node.Attributes["anchor"] != null)
			{
				ct_TextBodyProperties.anchorField = (global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType), node.Attributes["anchor"].Value);
			}
			ct_TextBodyProperties.anchorCtr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["anchorCtr"]);
			ct_TextBodyProperties.forceAA = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["forceAA"]);
			ct_TextBodyProperties.upright = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["upright"]);
			ct_TextBodyProperties.compatLnSpc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["compatLnSpc"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "prstTxWarp")
				{
					ct_TextBodyProperties.prstTxWarp = global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noAutofit")
				{
					ct_TextBodyProperties.noAutofit = new global::NPOI.OpenXmlFormats.Dml.CT_TextNoAutofit();
				}
				else if (xmlNode.LocalName == "normAutofit")
				{
					ct_TextBodyProperties.normAutofit = global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spAutoFit")
				{
					ct_TextBodyProperties.spAutoFit = new global::NPOI.OpenXmlFormats.Dml.CT_TextShapeAutofit();
				}
				else if (xmlNode.LocalName == "scene3d")
				{
					ct_TextBodyProperties.scene3d = global::NPOI.OpenXmlFormats.Dml.CT_Scene3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp3d")
				{
					ct_TextBodyProperties.sp3d = global::NPOI.OpenXmlFormats.Dml.CT_Shape3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "flatTx")
				{
					ct_TextBodyProperties.flatTx = global::NPOI.OpenXmlFormats.Dml.CT_FlatText.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TextBodyProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextBodyProperties;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00052AF8 File Offset: 0x00050CF8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			if (this.rotFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rot", this.rotField, true);
			}
			if (this.spcFirstLastPara)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "spcFirstLastPara", this.spcFirstLastPara);
			}
			if (this.vertOverflowFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vertOverflow", this.vertOverflowField.ToString());
			}
			if (this.horzOverflowFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horzOverflow", this.horzOverflowField.ToString());
			}
			if (this.vertFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vert", this.vert.ToString());
			}
			if (this.wrapFieldSpecified && this.wrap != global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wrap", this.wrap.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lIns", this.lIns);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tIns", this.tIns);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rIns", this.rIns);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bIns", this.bIns);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numCol", this.numCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "spcCol", this.spcCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rtlCol", this.rtlCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fromWordArt", this.fromWordArt, false);
			if (this.anchorFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "anchor", this.anchorField.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "anchorCtr", this.anchorCtr, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "forceAA", this.forceAA, false);
			if (this.upright)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "upright", this.upright);
			}
			if (this.compatLnSpc)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "compatLnSpc", this.compatLnSpc);
			}
			sw.Write(">");
			if (this.prstTxWarp != null)
			{
				this.prstTxWarp.Write(sw, "prstTxWarp");
			}
			if (this.noAutofit != null)
			{
				sw.Write("<a:noAutofit/>");
			}
			if (this.normAutofit != null)
			{
				this.normAutofit.Write(sw, "normAutofit");
			}
			if (this.spAutoFit != null)
			{
				sw.Write("<a:spAutoFit/>");
			}
			if (this.scene3d != null)
			{
				this.scene3d.Write(sw, "scene3d");
			}
			if (this.sp3d != null)
			{
				this.sp3d.Write(sw, "sp3d");
			}
			if (this.flatTx != null)
			{
				this.flatTx.Write(sw, "flatTx");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00052DC2 File Offset: 0x00050FC2
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00052DCA File Offset: 0x00050FCA
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape prstTxWarp
		{
			get
			{
				return this.prstTxWarpField;
			}
			set
			{
				this.prstTxWarpField = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00052DD3 File Offset: 0x00050FD3
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00052DDB File Offset: 0x00050FDB
		public global::NPOI.OpenXmlFormats.Dml.CT_TextNoAutofit noAutofit
		{
			get
			{
				return this.noAutofitField;
			}
			set
			{
				this.noAutofitField = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00052DE4 File Offset: 0x00050FE4
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00052DEC File Offset: 0x00050FEC
		public global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit normAutofit
		{
			get
			{
				return this.normAutofitField;
			}
			set
			{
				this.normAutofitField = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00052DF5 File Offset: 0x00050FF5
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x00052DFD File Offset: 0x00050FFD
		public global::NPOI.OpenXmlFormats.Dml.CT_TextShapeAutofit spAutoFit
		{
			get
			{
				return this.spAutoFitField;
			}
			set
			{
				this.spAutoFitField = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00052E06 File Offset: 0x00051006
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00052E0E File Offset: 0x0005100E
		public global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3d
		{
			get
			{
				return this.scene3dField;
			}
			set
			{
				this.scene3dField = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00052E17 File Offset: 0x00051017
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00052E1F File Offset: 0x0005101F
		public global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3d
		{
			get
			{
				return this.sp3dField;
			}
			set
			{
				this.sp3dField = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00052E28 File Offset: 0x00051028
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x00052E30 File Offset: 0x00051030
		public global::NPOI.OpenXmlFormats.Dml.CT_FlatText flatTx
		{
			get
			{
				return this.flatTxField;
			}
			set
			{
				this.flatTxField = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00052E39 File Offset: 0x00051039
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00052E41 File Offset: 0x00051041
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

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00052E4A File Offset: 0x0005104A
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x00052E52 File Offset: 0x00051052
		[global::System.Xml.Serialization.XmlAttribute]
		public int rot
		{
			get
			{
				return this.rotField;
			}
			set
			{
				this.rotField = value;
				this.rotFieldSpecified = true;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00052E62 File Offset: 0x00051062
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00052E6A File Offset: 0x0005106A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rotSpecified
		{
			get
			{
				return this.rotFieldSpecified;
			}
			set
			{
				this.rotFieldSpecified = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00052E73 File Offset: 0x00051073
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x00052E7B File Offset: 0x0005107B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool spcFirstLastPara
		{
			get
			{
				return this.spcFirstLastParaField;
			}
			set
			{
				this.spcFirstLastParaField = value;
				this.spcFirstLastParaFieldSpecified = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00052E8B File Offset: 0x0005108B
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00052E93 File Offset: 0x00051093
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spcFirstLastParaSpecified
		{
			get
			{
				return this.spcFirstLastParaFieldSpecified;
			}
			set
			{
				this.spcFirstLastParaFieldSpecified = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00052E9C File Offset: 0x0005109C
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x00052EA4 File Offset: 0x000510A4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextVertOverflowType vertOverflow
		{
			get
			{
				return this.vertOverflowField;
			}
			set
			{
				this.vertOverflowField = value;
				this.vertOverflowFieldSpecified = true;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00052EB4 File Offset: 0x000510B4
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x00052EBC File Offset: 0x000510BC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertOverflowSpecified
		{
			get
			{
				return this.vertOverflowFieldSpecified;
			}
			set
			{
				this.vertOverflowFieldSpecified = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00052EC5 File Offset: 0x000510C5
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x00052ECD File Offset: 0x000510CD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType horzOverflow
		{
			get
			{
				return this.horzOverflowField;
			}
			set
			{
				this.horzOverflowField = value;
				this.horzOverflowFieldSpecified = true;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00052EDD File Offset: 0x000510DD
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00052EE5 File Offset: 0x000510E5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool horzOverflowSpecified
		{
			get
			{
				return this.horzOverflowFieldSpecified;
			}
			set
			{
				this.horzOverflowFieldSpecified = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00052EEE File Offset: 0x000510EE
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00052EF6 File Offset: 0x000510F6
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType vert
		{
			get
			{
				return this.vertField;
			}
			set
			{
				this.vertField = value;
				this.vertFieldSpecified = true;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00052F06 File Offset: 0x00051106
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00052F0E File Offset: 0x0005110E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertSpecified
		{
			get
			{
				return this.vertFieldSpecified;
			}
			set
			{
				this.vertFieldSpecified = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00052F17 File Offset: 0x00051117
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x00052F1F File Offset: 0x0005111F
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType wrap
		{
			get
			{
				return this.wrapField;
			}
			set
			{
				this.wrapField = value;
				this.wrapFieldSpecified = true;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x00052F2F File Offset: 0x0005112F
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x00052F37 File Offset: 0x00051137
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wrapSpecified
		{
			get
			{
				return this.wrapFieldSpecified;
			}
			set
			{
				this.wrapFieldSpecified = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00052F40 File Offset: 0x00051140
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00052F48 File Offset: 0x00051148
		[global::System.Xml.Serialization.XmlAttribute]
		public int lIns
		{
			get
			{
				return this.lInsField;
			}
			set
			{
				this.lInsField = value;
				this.lInsFieldSpecified = true;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00052F58 File Offset: 0x00051158
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00052F60 File Offset: 0x00051160
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lInsSpecified
		{
			get
			{
				return this.lInsFieldSpecified;
			}
			set
			{
				this.lInsFieldSpecified = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00052F69 File Offset: 0x00051169
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x00052F71 File Offset: 0x00051171
		[global::System.Xml.Serialization.XmlAttribute]
		public int tIns
		{
			get
			{
				return this.tInsField;
			}
			set
			{
				this.tInsField = value;
				this.tInsFieldSpecified = true;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00052F81 File Offset: 0x00051181
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00052F89 File Offset: 0x00051189
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tInsSpecified
		{
			get
			{
				return this.tInsFieldSpecified;
			}
			set
			{
				this.tInsFieldSpecified = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00052F92 File Offset: 0x00051192
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00052F9A File Offset: 0x0005119A
		[global::System.Xml.Serialization.XmlAttribute]
		public int rIns
		{
			get
			{
				return this.rInsField;
			}
			set
			{
				this.rInsField = value;
				this.rInsFieldSpecified = true;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00052FAA File Offset: 0x000511AA
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x00052FB2 File Offset: 0x000511B2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rInsSpecified
		{
			get
			{
				return this.rInsFieldSpecified;
			}
			set
			{
				this.rInsFieldSpecified = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00052FBB File Offset: 0x000511BB
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00052FC3 File Offset: 0x000511C3
		[global::System.Xml.Serialization.XmlAttribute]
		public int bIns
		{
			get
			{
				return this.bInsField;
			}
			set
			{
				this.bInsField = value;
				this.bInsFieldSpecified = true;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00052FD3 File Offset: 0x000511D3
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00052FDB File Offset: 0x000511DB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bInsSpecified
		{
			get
			{
				return this.bInsFieldSpecified;
			}
			set
			{
				this.bInsFieldSpecified = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00052FE4 File Offset: 0x000511E4
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00052FEC File Offset: 0x000511EC
		[global::System.Xml.Serialization.XmlAttribute]
		public int numCol
		{
			get
			{
				return this.numColField;
			}
			set
			{
				this.numColField = value;
				this.numColFieldSpecified = true;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00052FFC File Offset: 0x000511FC
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00053004 File Offset: 0x00051204
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numColSpecified
		{
			get
			{
				return this.numColFieldSpecified;
			}
			set
			{
				this.numColFieldSpecified = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0005300D File Offset: 0x0005120D
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00053015 File Offset: 0x00051215
		[global::System.Xml.Serialization.XmlAttribute]
		public int spcCol
		{
			get
			{
				return this.spcColField;
			}
			set
			{
				this.spcColField = value;
				this.spcColFieldSpecified = true;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00053025 File Offset: 0x00051225
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0005302D File Offset: 0x0005122D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spcColSpecified
		{
			get
			{
				return this.spcColFieldSpecified;
			}
			set
			{
				this.spcColFieldSpecified = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00053036 File Offset: 0x00051236
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0005303E File Offset: 0x0005123E
		[global::System.Xml.Serialization.XmlAttribute]
		public bool rtlCol
		{
			get
			{
				return this.rtlColField;
			}
			set
			{
				this.rtlColField = value;
				this.rtlColFieldSpecified = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0005304E File Offset: 0x0005124E
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x00053056 File Offset: 0x00051256
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rtlColSpecified
		{
			get
			{
				return this.rtlColFieldSpecified;
			}
			set
			{
				this.rtlColFieldSpecified = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0005305F File Offset: 0x0005125F
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x00053067 File Offset: 0x00051267
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fromWordArt
		{
			get
			{
				return this.fromWordArtField;
			}
			set
			{
				this.fromWordArtField = value;
				this.fromWordArtFieldSpecified = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00053077 File Offset: 0x00051277
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0005307F File Offset: 0x0005127F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fromWordArtSpecified
		{
			get
			{
				return this.fromWordArtFieldSpecified;
			}
			set
			{
				this.fromWordArtFieldSpecified = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00053088 File Offset: 0x00051288
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00053090 File Offset: 0x00051290
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType anchor
		{
			get
			{
				return this.anchorField;
			}
			set
			{
				this.anchorField = value;
				this.anchorFieldSpecified = true;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x000530A0 File Offset: 0x000512A0
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x000530A8 File Offset: 0x000512A8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool anchorSpecified
		{
			get
			{
				return this.anchorFieldSpecified;
			}
			set
			{
				this.anchorFieldSpecified = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x000530B1 File Offset: 0x000512B1
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x000530B9 File Offset: 0x000512B9
		[global::System.Xml.Serialization.XmlAttribute]
		public bool anchorCtr
		{
			get
			{
				return this.anchorCtrField;
			}
			set
			{
				this.anchorCtrField = value;
				this.anchorCtrFieldSpecified = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x000530C9 File Offset: 0x000512C9
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x000530D1 File Offset: 0x000512D1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool anchorCtrSpecified
		{
			get
			{
				return this.anchorCtrFieldSpecified;
			}
			set
			{
				this.anchorCtrFieldSpecified = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000530DA File Offset: 0x000512DA
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x000530E2 File Offset: 0x000512E2
		[global::System.Xml.Serialization.XmlAttribute]
		public bool forceAA
		{
			get
			{
				return this.forceAAField;
			}
			set
			{
				this.forceAAField = value;
				this.forceAAFieldSpecified = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000530F2 File Offset: 0x000512F2
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x000530FA File Offset: 0x000512FA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool forceAASpecified
		{
			get
			{
				return this.forceAAFieldSpecified;
			}
			set
			{
				this.forceAAFieldSpecified = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00053103 File Offset: 0x00051303
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0005310B File Offset: 0x0005130B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool upright
		{
			get
			{
				return this.uprightField;
			}
			set
			{
				this.uprightField = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00053114 File Offset: 0x00051314
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x0005311C File Offset: 0x0005131C
		[global::System.Xml.Serialization.XmlAttribute]
		public bool compatLnSpc
		{
			get
			{
				return this.compatLnSpcField;
			}
			set
			{
				this.compatLnSpcField = value;
				this.compatLnSpcFieldSpecified = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x0005312C File Offset: 0x0005132C
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00053134 File Offset: 0x00051334
		[global::System.Xml.Serialization.XmlIgnore]
		public bool compatLnSpcSpecified
		{
			get
			{
				return this.compatLnSpcFieldSpecified;
			}
			set
			{
				this.compatLnSpcFieldSpecified = value;
			}
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0005313D File Offset: 0x0005133D
		public void UnsetTIns()
		{
			this.tInsFieldSpecified = false;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00053146 File Offset: 0x00051346
		public void UnsetVertOverflow()
		{
			this.vertOverflowFieldSpecified = false;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0005314F File Offset: 0x0005134F
		public void UnsetVert()
		{
			this.vertFieldSpecified = false;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00052F06 File Offset: 0x00051106
		public bool IsSetVert()
		{
			return this.vertFieldSpecified;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00052FD3 File Offset: 0x000511D3
		public bool IsSetBIns()
		{
			return this.bInsFieldSpecified;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00052F58 File Offset: 0x00051158
		public bool IsSetLIns()
		{
			return this.lInsFieldSpecified;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00052FAA File Offset: 0x000511AA
		public bool IsSetRIns()
		{
			return this.rInsFieldSpecified;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00052F81 File Offset: 0x00051181
		public bool IsSetTIns()
		{
			return this.tInsFieldSpecified;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00053158 File Offset: 0x00051358
		public void UnsetBIns()
		{
			this.bInsFieldSpecified = false;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00053161 File Offset: 0x00051361
		public void UnsetLIns()
		{
			this.lInsFieldSpecified = false;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0005316A File Offset: 0x0005136A
		public void UnsetRIns()
		{
			this.rInsFieldSpecified = false;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00053173 File Offset: 0x00051373
		public bool IsSetSpAutoFit()
		{
			return this.spAutoFitField != null;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0005317E File Offset: 0x0005137E
		public bool IsSetNoAutofit()
		{
			return this.noAutofitField != null;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00053189 File Offset: 0x00051389
		public bool IsSetNormAutofit()
		{
			return this.normAutofitField != null;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00053194 File Offset: 0x00051394
		public void UnsetSpAutoFit()
		{
			this.spAutoFitField = null;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0005319D File Offset: 0x0005139D
		public void UnsetNoAutofit()
		{
			this.noAutofitField = null;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000531A6 File Offset: 0x000513A6
		public void UnsetNormAutofit()
		{
			this.normAutofitField = null;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000531AF File Offset: 0x000513AF
		public global::NPOI.OpenXmlFormats.Dml.CT_TextNoAutofit AddNewNoAutofit()
		{
			this.noAutofitField = new global::NPOI.OpenXmlFormats.Dml.CT_TextNoAutofit();
			return this.noAutofitField;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000531C2 File Offset: 0x000513C2
		public global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit AddNewNormAutofit()
		{
			this.normAutofitField = new global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit();
			return this.normAutofitField;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000531D5 File Offset: 0x000513D5
		public global::NPOI.OpenXmlFormats.Dml.CT_TextShapeAutofit AddNewSpAutoFit()
		{
			this.spAutoFitField = new global::NPOI.OpenXmlFormats.Dml.CT_TextShapeAutofit();
			return this.spAutoFitField;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000531E8 File Offset: 0x000513E8
		public void UnsetHorzOverflow()
		{
			this.horzOverflowFieldSpecified = false;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00052EDD File Offset: 0x000510DD
		public bool IsSetHorzOverflow()
		{
			return this.horzOverflowFieldSpecified;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00052EB4 File Offset: 0x000510B4
		public bool IsSetVertOverflow()
		{
			return this.vertOverflowFieldSpecified;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000530A0 File Offset: 0x000512A0
		public bool IsSetAnchor()
		{
			return this.anchorFieldSpecified;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000531F1 File Offset: 0x000513F1
		public void UnsetAnchor()
		{
			this.anchorFieldSpecified = false;
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00052F2F File Offset: 0x0005112F
		public bool IsSetWrap()
		{
			return this.wrapFieldSpecified;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000531FA File Offset: 0x000513FA
		public void UnsetWrap()
		{
			this.wrapFieldSpecified = false;
		}

		// Token: 0x0400180F RID: 6159
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape prstTxWarpField;

		// Token: 0x04001810 RID: 6160
		private global::NPOI.OpenXmlFormats.Dml.CT_TextNoAutofit noAutofitField;

		// Token: 0x04001811 RID: 6161
		private global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit normAutofitField;

		// Token: 0x04001812 RID: 6162
		private global::NPOI.OpenXmlFormats.Dml.CT_TextShapeAutofit spAutoFitField;

		// Token: 0x04001813 RID: 6163
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x04001814 RID: 6164
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x04001815 RID: 6165
		private global::NPOI.OpenXmlFormats.Dml.CT_FlatText flatTxField;

		// Token: 0x04001816 RID: 6166
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001817 RID: 6167
		private int rotField;

		// Token: 0x04001818 RID: 6168
		private bool rotFieldSpecified;

		// Token: 0x04001819 RID: 6169
		private bool spcFirstLastParaField;

		// Token: 0x0400181A RID: 6170
		private bool spcFirstLastParaFieldSpecified;

		// Token: 0x0400181B RID: 6171
		private global::NPOI.OpenXmlFormats.Dml.ST_TextVertOverflowType vertOverflowField;

		// Token: 0x0400181C RID: 6172
		private bool vertOverflowFieldSpecified;

		// Token: 0x0400181D RID: 6173
		private global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType horzOverflowField;

		// Token: 0x0400181E RID: 6174
		private bool horzOverflowFieldSpecified;

		// Token: 0x0400181F RID: 6175
		private global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType vertField;

		// Token: 0x04001820 RID: 6176
		private bool vertFieldSpecified;

		// Token: 0x04001821 RID: 6177
		private global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType wrapField;

		// Token: 0x04001822 RID: 6178
		private bool wrapFieldSpecified;

		// Token: 0x04001823 RID: 6179
		private int lInsField;

		// Token: 0x04001824 RID: 6180
		private bool lInsFieldSpecified;

		// Token: 0x04001825 RID: 6181
		private int tInsField;

		// Token: 0x04001826 RID: 6182
		private bool tInsFieldSpecified;

		// Token: 0x04001827 RID: 6183
		private int rInsField;

		// Token: 0x04001828 RID: 6184
		private bool rInsFieldSpecified;

		// Token: 0x04001829 RID: 6185
		private int bInsField;

		// Token: 0x0400182A RID: 6186
		private bool bInsFieldSpecified;

		// Token: 0x0400182B RID: 6187
		private int numColField;

		// Token: 0x0400182C RID: 6188
		private bool numColFieldSpecified;

		// Token: 0x0400182D RID: 6189
		private int spcColField;

		// Token: 0x0400182E RID: 6190
		private bool spcColFieldSpecified;

		// Token: 0x0400182F RID: 6191
		private bool rtlColField;

		// Token: 0x04001830 RID: 6192
		private bool rtlColFieldSpecified;

		// Token: 0x04001831 RID: 6193
		private bool fromWordArtField;

		// Token: 0x04001832 RID: 6194
		private bool fromWordArtFieldSpecified;

		// Token: 0x04001833 RID: 6195
		private global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType anchorField;

		// Token: 0x04001834 RID: 6196
		private bool anchorFieldSpecified;

		// Token: 0x04001835 RID: 6197
		private bool anchorCtrField;

		// Token: 0x04001836 RID: 6198
		private bool anchorCtrFieldSpecified;

		// Token: 0x04001837 RID: 6199
		private bool forceAAField;

		// Token: 0x04001838 RID: 6200
		private bool forceAAFieldSpecified;

		// Token: 0x04001839 RID: 6201
		private bool uprightField;

		// Token: 0x0400183A RID: 6202
		private bool compatLnSpcField;

		// Token: 0x0400183B RID: 6203
		private bool compatLnSpcFieldSpecified;
	}
}
