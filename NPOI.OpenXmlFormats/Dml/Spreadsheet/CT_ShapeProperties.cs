using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036D RID: 877
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_ShapeProperties
	{
		// Token: 0x060022E0 RID: 8928 RVA: 0x0005AE78 File Offset: 0x00059078
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D AddNewPrstGeom()
		{
			this.prstGeomField = new global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D();
			return this.prstGeomField;
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0005AE8B File Offset: 0x0005908B
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D AddNewXfrm()
		{
			this.xfrmField = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			return this.xfrmField;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0005AE9E File Offset: 0x0005909E
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties AddNewSolidFill()
		{
			this.solidFillField = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			return this.solidFillField;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0005AEB1 File Offset: 0x000590B1
		public bool IsSetPattFill()
		{
			return this.pattFillField != null;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0005AEBC File Offset: 0x000590BC
		public bool IsSetSolidFill()
		{
			return this.solidFillField != null;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0005AEC7 File Offset: 0x000590C7
		public bool IsSetLn()
		{
			return this.lnField != null;
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0005AED2 File Offset: 0x000590D2
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties AddNewLn()
		{
			this.lnField = new global::NPOI.OpenXmlFormats.Dml.CT_LineProperties();
			return this.lnField;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0005AEE5 File Offset: 0x000590E5
		public void unsetPattFill()
		{
			this.pattFill = null;
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0005AEEE File Offset: 0x000590EE
		public void unsetSolidFill()
		{
			this.solidFill = null;
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0005AEF7 File Offset: 0x000590F7
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x0005AEFF File Offset: 0x000590FF
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

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x0005AF08 File Offset: 0x00059108
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x0005AF10 File Offset: 0x00059110
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

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x0005AF19 File Offset: 0x00059119
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x0005AF21 File Offset: 0x00059121
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x0005AF2A File Offset: 0x0005912A
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x0005AF32 File Offset: 0x00059132
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

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0005AF3B File Offset: 0x0005913B
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x0005AF43 File Offset: 0x00059143
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

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0005AF4C File Offset: 0x0005914C
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0005AF54 File Offset: 0x00059154
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0005AF5D File Offset: 0x0005915D
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0005AF65 File Offset: 0x00059165
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties blipFill
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0005AF6E File Offset: 0x0005916E
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x0005AF76 File Offset: 0x00059176
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0005AF7F File Offset: 0x0005917F
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x0005AF87 File Offset: 0x00059187
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x0005AF90 File Offset: 0x00059190
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x0005AF98 File Offset: 0x00059198
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

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0005AFA1 File Offset: 0x000591A1
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x0005AFA9 File Offset: 0x000591A9
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

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0005AFB2 File Offset: 0x000591B2
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x0005AFBA File Offset: 0x000591BA
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x0005AFC3 File Offset: 0x000591C3
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x0005AFCB File Offset: 0x000591CB
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

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x0005AFD4 File Offset: 0x000591D4
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0005AFDC File Offset: 0x000591DC
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x0005AFE5 File Offset: 0x000591E5
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0005AFED File Offset: 0x000591ED
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

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0005AFF6 File Offset: 0x000591F6
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0005AFFE File Offset: 0x000591FE
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

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0005B007 File Offset: 0x00059207
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bwModeSpecified
		{
			get
			{
				return this.bwModeField > global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode.none;
			}
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0005B014 File Offset: 0x00059214
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties ct_ShapeProperties = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties();
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
					ct_ShapeProperties.blipFill = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
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

		// Token: 0x0600230B RID: 8971 RVA: 0x0005B2D0 File Offset: 0x000594D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
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
				this.blipFill.Write(sw, "blipFill");
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
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x04001A3D RID: 6717
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D xfrmField;

		// Token: 0x04001A3E RID: 6718
		private global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D custGeomField;

		// Token: 0x04001A3F RID: 6719
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D prstGeomField;

		// Token: 0x04001A40 RID: 6720
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001A41 RID: 6721
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001A42 RID: 6722
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001A43 RID: 6723
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties blipFillField;

		// Token: 0x04001A44 RID: 6724
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x04001A45 RID: 6725
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x04001A46 RID: 6726
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnField;

		// Token: 0x04001A47 RID: 6727
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x04001A48 RID: 6728
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x04001A49 RID: 6729
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x04001A4A RID: 6730
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;

		// Token: 0x04001A4B RID: 6731
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001A4C RID: 6732
		private global::NPOI.OpenXmlFormats.Dml.ST_BlackWhiteMode bwModeField;
	}
}
