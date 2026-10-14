using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001AD RID: 429
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPrBase
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00034888 File Offset: 0x00032A88
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase ct_TblPrBase = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblStyle")
				{
					ct_TblPrBase.tblStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblpPr")
				{
					ct_TblPrBase.tblpPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblOverlap")
				{
					ct_TblPrBase.tblOverlap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidiVisual")
				{
					ct_TblPrBase.bidiVisual = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStyleRowBandSize")
				{
					ct_TblPrBase.tblStyleRowBandSize = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStyleColBandSize")
				{
					ct_TblPrBase.tblStyleColBandSize = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblW")
				{
					ct_TblPrBase.tblW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TblPrBase.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TblPrBase.tblCellSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblInd")
				{
					ct_TblPrBase.tblInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblBorders")
				{
					ct_TblPrBase.tblBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TblPrBase.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLayout")
				{
					ct_TblPrBase.tblLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellMar")
				{
					ct_TblPrBase.tblCellMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLook")
				{
					ct_TblPrBase.tblLook = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCaption")
				{
					ct_TblPrBase.tblCaption = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblDescription")
				{
					ct_TblPrBase.tblDescription = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPrBase;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00034B50 File Offset: 0x00032D50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.tblStyle != null)
			{
				this.tblStyle.Write(sw, "tblStyle");
			}
			if (this.tblpPr != null)
			{
				this.tblpPr.Write(sw, "tblpPr");
			}
			if (this.tblOverlap != null)
			{
				this.tblOverlap.Write(sw, "tblOverlap");
			}
			if (this.bidiVisual != null)
			{
				this.bidiVisual.Write(sw, "bidiVisual");
			}
			if (this.tblStyleRowBandSize != null)
			{
				this.tblStyleRowBandSize.Write(sw, "tblStyleRowBandSize");
			}
			if (this.tblStyleColBandSize != null)
			{
				this.tblStyleColBandSize.Write(sw, "tblStyleColBandSize");
			}
			if (this.tblW != null)
			{
				this.tblW.Write(sw, "tblW");
			}
			if (this.jc != null)
			{
				this.jc.Write(sw, "jc");
			}
			if (this.tblCellSpacing != null)
			{
				this.tblCellSpacing.Write(sw, "tblCellSpacing");
			}
			if (this.tblInd != null)
			{
				this.tblInd.Write(sw, "tblInd");
			}
			if (this.tblBorders != null)
			{
				this.tblBorders.Write(sw, "tblBorders");
			}
			if (this.shd != null)
			{
				this.shd.Write(sw, "shd");
			}
			if (this.tblLayout != null)
			{
				this.tblLayout.Write(sw, "tblLayout");
			}
			if (this.tblCellMar != null)
			{
				this.tblCellMar.Write(sw, "tblCellMar");
			}
			if (this.tblLook != null)
			{
				this.tblLook.Write(sw, "tblLook");
			}
			if (this.tblCaption != null)
			{
				this.tblCaption.Write(sw, "tblCaption");
			}
			if (this.tblDescription != null)
			{
				this.tblDescription.Write(sw, "tblDescription");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00034D33 File Offset: 0x00032F33
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00034D3B File Offset: 0x00032F3B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblStyle
		{
			get
			{
				return this.tblStyleField;
			}
			set
			{
				this.tblStyleField = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00034D44 File Offset: 0x00032F44
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00034D4C File Offset: 0x00032F4C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr tblpPr
		{
			get
			{
				return this.tblpPrField;
			}
			set
			{
				this.tblpPrField = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00034D55 File Offset: 0x00032F55
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00034D5D File Offset: 0x00032F5D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap tblOverlap
		{
			get
			{
				return this.tblOverlapField;
			}
			set
			{
				this.tblOverlapField = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00034D66 File Offset: 0x00032F66
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00034D6E File Offset: 0x00032F6E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidiVisual
		{
			get
			{
				return this.bidiVisualField;
			}
			set
			{
				this.bidiVisualField = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00034D77 File Offset: 0x00032F77
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00034D7F File Offset: 0x00032F7F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber tblStyleRowBandSize
		{
			get
			{
				return this.tblStyleRowBandSizeField;
			}
			set
			{
				this.tblStyleRowBandSizeField = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00034D88 File Offset: 0x00032F88
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00034D90 File Offset: 0x00032F90
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber tblStyleColBandSize
		{
			get
			{
				return this.tblStyleColBandSizeField;
			}
			set
			{
				this.tblStyleColBandSizeField = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00034D99 File Offset: 0x00032F99
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00034DA1 File Offset: 0x00032FA1
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblW
		{
			get
			{
				return this.tblWField;
			}
			set
			{
				this.tblWField = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00034DAA File Offset: 0x00032FAA
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00034DB2 File Offset: 0x00032FB2
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc jc
		{
			get
			{
				return this.jcField;
			}
			set
			{
				this.jcField = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00034DBB File Offset: 0x00032FBB
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00034DC3 File Offset: 0x00032FC3
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblCellSpacing
		{
			get
			{
				return this.tblCellSpacingField;
			}
			set
			{
				this.tblCellSpacingField = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00034DCC File Offset: 0x00032FCC
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00034DD4 File Offset: 0x00032FD4
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblInd
		{
			get
			{
				return this.tblIndField;
			}
			set
			{
				this.tblIndField = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00034DDD File Offset: 0x00032FDD
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00034DE5 File Offset: 0x00032FE5
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders
		{
			get
			{
				return this.tblBordersField;
			}
			set
			{
				this.tblBordersField = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00034DEE File Offset: 0x00032FEE
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00034DF6 File Offset: 0x00032FF6
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd
		{
			get
			{
				return this.shdField;
			}
			set
			{
				this.shdField = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00034DFF File Offset: 0x00032FFF
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00034E07 File Offset: 0x00033007
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType tblLayout
		{
			get
			{
				return this.tblLayoutField;
			}
			set
			{
				this.tblLayoutField = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00034E10 File Offset: 0x00033010
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00034E18 File Offset: 0x00033018
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMar
		{
			get
			{
				return this.tblCellMarField;
			}
			set
			{
				this.tblCellMarField = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00034E21 File Offset: 0x00033021
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00034E29 File Offset: 0x00033029
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber tblLook
		{
			get
			{
				return this.tblLookField;
			}
			set
			{
				this.tblLookField = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00034E32 File Offset: 0x00033032
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00034E3A File Offset: 0x0003303A
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblCaption
		{
			get
			{
				return this.tblCaptionField;
			}
			set
			{
				this.tblCaptionField = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00034E43 File Offset: 0x00033043
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00034E4B File Offset: 0x0003304B
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblDescription
		{
			get
			{
				return this.tblDescriptionField;
			}
			set
			{
				this.tblDescriptionField = value;
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00034E54 File Offset: 0x00033054
		public bool IsSetTblW()
		{
			return this.tblW != null;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00034E5F File Offset: 0x0003305F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewTblW()
		{
			if (this.tblWField == null)
			{
				this.tblWField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			}
			return this.tblWField;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00034E7A File Offset: 0x0003307A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders AddNewTblBorders()
		{
			if (this.tblBordersField == null)
			{
				this.tblBordersField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders();
			}
			return this.tblBordersField;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00034E95 File Offset: 0x00033095
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String AddNewTblStyle()
		{
			this.tblStyleField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			return this.tblStyleField;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00034EA8 File Offset: 0x000330A8
		public bool IsSetTblBorders()
		{
			return this.tblBordersField != null;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00034EB3 File Offset: 0x000330B3
		public bool IsSetTblStyleRowBandSize()
		{
			return this.tblStyleRowBandSizeField != null;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00034EBE File Offset: 0x000330BE
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewTblStyleRowBandSize()
		{
			this.tblStyleRowBandSizeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			return this.tblStyleRowBandSizeField;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00034ED1 File Offset: 0x000330D1
		public bool IsSetTblStyleColBandSize()
		{
			return this.tblStyleColBandSizeField != null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00034EDC File Offset: 0x000330DC
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewTblStyleColBandSize()
		{
			this.tblStyleColBandSizeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			return this.tblStyleColBandSizeField;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00034EEF File Offset: 0x000330EF
		public bool IsSetTblCellMar()
		{
			return this.tblCellMarField != null;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00034EFA File Offset: 0x000330FA
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar AddNewTblCellMar()
		{
			this.tblCellMarField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar();
			return this.tblCellMarField;
		}

		// Token: 0x04000CE6 RID: 3302
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblStyleField;

		// Token: 0x04000CE7 RID: 3303
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr tblpPrField;

		// Token: 0x04000CE8 RID: 3304
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap tblOverlapField;

		// Token: 0x04000CE9 RID: 3305
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidiVisualField;

		// Token: 0x04000CEA RID: 3306
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber tblStyleRowBandSizeField;

		// Token: 0x04000CEB RID: 3307
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber tblStyleColBandSizeField;

		// Token: 0x04000CEC RID: 3308
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblWField;

		// Token: 0x04000CED RID: 3309
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc jcField;

		// Token: 0x04000CEE RID: 3310
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblCellSpacingField;

		// Token: 0x04000CEF RID: 3311
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblIndField;

		// Token: 0x04000CF0 RID: 3312
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBordersField;

		// Token: 0x04000CF1 RID: 3313
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x04000CF2 RID: 3314
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType tblLayoutField;

		// Token: 0x04000CF3 RID: 3315
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMarField;

		// Token: 0x04000CF4 RID: 3316
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber tblLookField;

		// Token: 0x04000CF5 RID: 3317
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblCaptionField;

		// Token: 0x04000CF6 RID: 3318
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblDescriptionField;
	}
}
