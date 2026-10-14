using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000301 RID: 769
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeProperties
	{
		// Token: 0x06001E12 RID: 7698 RVA: 0x00051674 File Offset: 0x0004F874
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D AddNewPrstGeom()
		{
			this.prstGeomField = new global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D();
			return this.prstGeomField;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00051687 File Offset: 0x0004F887
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D AddNewXfrm()
		{
			this.xfrmField = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			return this.xfrmField;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0005169A File Offset: 0x0004F89A
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties AddNewSolidFill()
		{
			this.solidFillField = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			return this.solidFillField;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x000516AD File Offset: 0x0004F8AD
		public bool IsSetPattFill()
		{
			return this.pattFillField != null;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x000516B8 File Offset: 0x0004F8B8
		public bool IsSetSolidFill()
		{
			return this.solidFillField != null;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000516C3 File Offset: 0x0004F8C3
		public bool IsSetLn()
		{
			return this.lnField != null;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000516CE File Offset: 0x0004F8CE
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties AddNewLn()
		{
			this.lnField = new global::NPOI.OpenXmlFormats.Dml.CT_LineProperties();
			return this.lnField;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000516E1 File Offset: 0x0004F8E1
		public void unsetPattFill()
		{
			this.pattFill = null;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000516EA File Offset: 0x0004F8EA
		public void unsetSolidFill()
		{
			this.solidFill = null;
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000516F3 File Offset: 0x0004F8F3
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x000516FB File Offset: 0x0004F8FB
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrm
		{
			get
			{
				return this.xfrmField;
			}
			set
			{
				this.xfrmField = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00051704 File Offset: 0x0004F904
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0005170C File Offset: 0x0004F90C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D custGeom
		{
			get
			{
				return this.custGeomField;
			}
			set
			{
				this.custGeomField = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00051715 File Offset: 0x0004F915
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0005171D File Offset: 0x0004F91D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D prstGeom
		{
			get
			{
				return this.prstGeomField;
			}
			set
			{
				this.prstGeomField = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x00051726 File Offset: 0x0004F926
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0005172E File Offset: 0x0004F92E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00051737 File Offset: 0x0004F937
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0005173F File Offset: 0x0004F93F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00051748 File Offset: 0x0004F948
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00051750 File Offset: 0x0004F950
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00051759 File Offset: 0x0004F959
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00051761 File Offset: 0x0004F961
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0005176A File Offset: 0x0004F96A
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00051772 File Offset: 0x0004F972
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0005177B File Offset: 0x0004F97B
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x00051783 File Offset: 0x0004F983
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFill
		{
			get
			{
				return this.grpFillField;
			}
			set
			{
				this.grpFillField = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0005178C File Offset: 0x0004F98C
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00051794 File Offset: 0x0004F994
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ln
		{
			get
			{
				return this.lnField;
			}
			set
			{
				this.lnField = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0005179D File Offset: 0x0004F99D
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000517A5 File Offset: 0x0004F9A5
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLst
		{
			get
			{
				return this.effectLstField;
			}
			set
			{
				this.effectLstField = value;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x000517AE File Offset: 0x0004F9AE
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x000517B6 File Offset: 0x0004F9B6
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDag
		{
			get
			{
				return this.effectDagField;
			}
			set
			{
				this.effectDagField = value;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000517BF File Offset: 0x0004F9BF
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x000517C7 File Offset: 0x0004F9C7
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000517D0 File Offset: 0x0004F9D0
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x000517D8 File Offset: 0x0004F9D8
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
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

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000517E1 File Offset: 0x0004F9E1
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x000517E9 File Offset: 0x0004F9E9
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
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

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000517F2 File Offset: 0x0004F9F2
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x000517FA File Offset: 0x0004F9FA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode bwMode
		{
			get
			{
				return this.bwModeField;
			}
			set
			{
				this.bwModeField = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00051803 File Offset: 0x0004FA03
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bwModeSpecified
		{
			get
			{
				return this.bwModeField > global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode.none;
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00051810 File Offset: 0x0004FA10
		public static global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties ct_ShapeProperties = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties();
			if (node.Attributes["bwMode"] != null)
			{
				ct_ShapeProperties.bwMode = (global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode), node.Attributes["bwMode"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "xfrm")
				{
					ct_ShapeProperties.xfrm = global::NPOI.OpenXmlFormats.Dml.CT_Transform2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "custGeom")
				{
					ct_ShapeProperties.custGeom = global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstGeom")
				{
					ct_ShapeProperties.prstGeom = global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noFill")
				{
					ct_ShapeProperties.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_ShapeProperties.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_ShapeProperties.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_ShapeProperties.blipFill = global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_ShapeProperties.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_ShapeProperties.grpFill = new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties();
				}
				else if (xmlNode.LocalName == "ln")
				{
					ct_ShapeProperties.ln = global::NPOI.OpenXmlFormats.Dml.CT_LineProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectLst")
				{
					ct_ShapeProperties.effectLst = global::NPOI.OpenXmlFormats.Dml.CT_EffectList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectDag")
				{
					ct_ShapeProperties.effectDag = global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scene3d")
				{
					ct_ShapeProperties.scene3d = global::NPOI.OpenXmlFormats.Dml.CT_Scene3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp3d")
				{
					ct_ShapeProperties.sp3d = global::NPOI.OpenXmlFormats.Dml.CT_Shape3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ShapeProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeProperties;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00051ACC File Offset: 0x0004FCCC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.bwMode != global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bwMode", this.bwMode.ToString());
			}
			sw.Write(">");
			if (this.xfrm != null)
			{
				this.xfrm.Write(sw, "a:xfrm");
			}
			if (this.custGeom != null)
			{
				this.custGeom.Write(sw, "custGeom");
			}
			if (this.prstGeom != null)
			{
				this.prstGeom.Write(sw, "prstGeom");
			}
			if (this.noFill != null)
			{
				sw.Write("<a:noFill/>");
			}
			if (this.solidFill != null)
			{
				this.solidFill.Write(sw, "solidFill");
			}
			if (this.gradFill != null)
			{
				this.gradFill.Write(sw, "gradFill");
			}
			if (this.blipFill != null)
			{
				this.blipFill.Write(sw, "a:blipFill");
			}
			if (this.pattFill != null)
			{
				this.pattFill.Write(sw, "pattFill");
			}
			if (this.grpFill != null)
			{
				sw.Write("<a:grpFill/>");
			}
			if (this.ln != null)
			{
				this.ln.Write(sw, "ln");
			}
			if (this.effectLst != null)
			{
				this.effectLst.Write(sw, "effectLst");
			}
			if (this.effectDag != null)
			{
				this.effectDag.Write(sw, "effectDag");
			}
			if (this.scene3d != null)
			{
				this.scene3d.Write(sw, "scene3d");
			}
			if (this.sp3d != null)
			{
				this.sp3d.Write(sw, "sp3d");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040017CD RID: 6093
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x040017CE RID: 6094
		private global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D custGeomField;

		// Token: 0x040017CF RID: 6095
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D prstGeomField;

		// Token: 0x040017D0 RID: 6096
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x040017D1 RID: 6097
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x040017D2 RID: 6098
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x040017D3 RID: 6099
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x040017D4 RID: 6100
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x040017D5 RID: 6101
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x040017D6 RID: 6102
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnField;

		// Token: 0x040017D7 RID: 6103
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x040017D8 RID: 6104
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x040017D9 RID: 6105
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x040017DA RID: 6106
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x040017DB RID: 6107
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017DC RID: 6108
		private global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode bwModeField;
	}
}
