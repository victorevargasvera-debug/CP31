using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046F RID: 1135
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeProperties
	{
		// Token: 0x06002D35 RID: 11573 RVA: 0x0007234F File Offset: 0x0007054F
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D AddNewPrstGeom()
		{
			this.prstGeomField = new global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D();
			return this.prstGeomField;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00072362 File Offset: 0x00070562
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D AddNewXfrm()
		{
			this.xfrmField = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			return this.xfrmField;
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00072375 File Offset: 0x00070575
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties AddNewSolidFill()
		{
			this.solidFillField = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			return this.solidFillField;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00072388 File Offset: 0x00070588
		public bool IsSetPattFill()
		{
			return this.pattFillField != null;
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00072393 File Offset: 0x00070593
		public bool IsSetSolidFill()
		{
			return this.solidFillField != null;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0007239E File Offset: 0x0007059E
		public bool IsSetLn()
		{
			return this.lnField != null;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000723A9 File Offset: 0x000705A9
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties AddNewLn()
		{
			this.lnField = new global::NPOI.OpenXmlFormats.Dml.CT_LineProperties();
			return this.lnField;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000723BC File Offset: 0x000705BC
		public void unsetPattFill()
		{
			this.pattFill = null;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000723C5 File Offset: 0x000705C5
		public void unsetSolidFill()
		{
			this.solidFill = null;
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000723CE File Offset: 0x000705CE
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x000723D6 File Offset: 0x000705D6
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

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000723DF File Offset: 0x000705DF
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x000723E7 File Offset: 0x000705E7
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

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000723F0 File Offset: 0x000705F0
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x000723F8 File Offset: 0x000705F8
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

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00072401 File Offset: 0x00070601
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x00072409 File Offset: 0x00070609
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

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00072412 File Offset: 0x00070612
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x0007241A File Offset: 0x0007061A
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

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x00072423 File Offset: 0x00070623
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x0007242B File Offset: 0x0007062B
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

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x00072434 File Offset: 0x00070634
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x0007243C File Offset: 0x0007063C
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

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x00072445 File Offset: 0x00070645
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x0007244D File Offset: 0x0007064D
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

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x00072456 File Offset: 0x00070656
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x0007245E File Offset: 0x0007065E
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

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x00072467 File Offset: 0x00070667
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x0007246F File Offset: 0x0007066F
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

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x00072478 File Offset: 0x00070678
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x00072480 File Offset: 0x00070680
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00072489 File Offset: 0x00070689
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x00072491 File Offset: 0x00070691
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x0007249A File Offset: 0x0007069A
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x000724A2 File Offset: 0x000706A2
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

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000724AB File Offset: 0x000706AB
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000724B3 File Offset: 0x000706B3
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

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000724BC File Offset: 0x000706BC
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x000724C4 File Offset: 0x000706C4
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

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000724CD File Offset: 0x000706CD
		// (set) Token: 0x06002D5D RID: 11613 RVA: 0x000724D5 File Offset: 0x000706D5
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

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000724DE File Offset: 0x000706DE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bwModeSpecified
		{
			get
			{
				return this.bwModeField > global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode.none;
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000724EC File Offset: 0x000706EC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties ct_ShapeProperties = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties();
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

		// Token: 0x06002D60 RID: 11616 RVA: 0x000727A8 File Offset: 0x000709A8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
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
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001F83 RID: 8067
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x04001F84 RID: 8068
		private global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D custGeomField;

		// Token: 0x04001F85 RID: 8069
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D prstGeomField;

		// Token: 0x04001F86 RID: 8070
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001F87 RID: 8071
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001F88 RID: 8072
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001F89 RID: 8073
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001F8A RID: 8074
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x04001F8B RID: 8075
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x04001F8C RID: 8076
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnField;

		// Token: 0x04001F8D RID: 8077
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x04001F8E RID: 8078
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x04001F8F RID: 8079
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x04001F90 RID: 8080
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x04001F91 RID: 8081
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001F92 RID: 8082
		private global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode bwModeField;
	}
}
