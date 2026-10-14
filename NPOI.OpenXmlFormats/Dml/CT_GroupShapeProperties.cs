using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000302 RID: 770
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Serializable]
	public class CT_GroupShapeProperties
	{
		// Token: 0x06001E3F RID: 7743 RVA: 0x00051C98 File Offset: 0x0004FE98
		public static global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties ct_GroupShapeProperties = new global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties();
			if (node.Attributes["bwMode"] != null)
			{
				ct_GroupShapeProperties.bwMode = (global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode), node.Attributes["bwMode"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "xfrm")
				{
					ct_GroupShapeProperties.xfrm = global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noFill")
				{
					ct_GroupShapeProperties.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_GroupShapeProperties.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_GroupShapeProperties.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_GroupShapeProperties.blipFill = global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_GroupShapeProperties.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_GroupShapeProperties.grpFill = new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties();
				}
				else if (xmlNode.LocalName == "effectLst")
				{
					ct_GroupShapeProperties.effectLst = global::NPOI.OpenXmlFormats.Dml.CT_EffectList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectDag")
				{
					ct_GroupShapeProperties.effectDag = global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scene3d")
				{
					ct_GroupShapeProperties.scene3d = global::NPOI.OpenXmlFormats.Dml.CT_Scene3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_GroupShapeProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupShapeProperties;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00051EC4 File Offset: 0x000500C4
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
				this.xfrm.Write(sw, "xfrm");
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
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0005202C File Offset: 0x0005022C
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D AddNewXfrm()
		{
			this.xfrmField = new global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D();
			return this.xfrmField;
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0005203F File Offset: 0x0005023F
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00052047 File Offset: 0x00050247
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D xfrm
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

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00052050 File Offset: 0x00050250
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x00052058 File Offset: 0x00050258
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00052061 File Offset: 0x00050261
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x00052069 File Offset: 0x00050269
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x00052072 File Offset: 0x00050272
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0005207A File Offset: 0x0005027A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00052083 File Offset: 0x00050283
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0005208B File Offset: 0x0005028B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00052094 File Offset: 0x00050294
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0005209C File Offset: 0x0005029C
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x000520A5 File Offset: 0x000502A5
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x000520AD File Offset: 0x000502AD
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x000520B6 File Offset: 0x000502B6
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x000520BE File Offset: 0x000502BE
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x000520C7 File Offset: 0x000502C7
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x000520CF File Offset: 0x000502CF
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000520D8 File Offset: 0x000502D8
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x000520E0 File Offset: 0x000502E0
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x000520E9 File Offset: 0x000502E9
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x000520F1 File Offset: 0x000502F1
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
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

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x000520FA File Offset: 0x000502FA
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x00052102 File Offset: 0x00050302
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

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0005210B File Offset: 0x0005030B
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x00052113 File Offset: 0x00050313
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bwModeSpecified
		{
			get
			{
				return this.bwModeFieldSpecified;
			}
			set
			{
				this.bwModeFieldSpecified = value;
			}
		}

		// Token: 0x040017DD RID: 6109
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D xfrmField;

		// Token: 0x040017DE RID: 6110
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x040017DF RID: 6111
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x040017E0 RID: 6112
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x040017E1 RID: 6113
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x040017E2 RID: 6114
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x040017E3 RID: 6115
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x040017E4 RID: 6116
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x040017E5 RID: 6117
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x040017E6 RID: 6118
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x040017E7 RID: 6119
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017E8 RID: 6120
		private global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode bwModeField;

		// Token: 0x040017E9 RID: 6121
		private bool bwModeFieldSpecified;
	}
}
