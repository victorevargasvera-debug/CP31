using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B2 RID: 434
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPrExBase
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x000355AC File Offset: 0x000337AC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase ct_TblPrExBase = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblW")
				{
					ct_TblPrExBase.tblW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TblPrExBase.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TblPrExBase.tblCellSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblInd")
				{
					ct_TblPrExBase.tblInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblBorders")
				{
					ct_TblPrExBase.tblBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TblPrExBase.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLayout")
				{
					ct_TblPrExBase.tblLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellMar")
				{
					ct_TblPrExBase.tblCellMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLook")
				{
					ct_TblPrExBase.tblLook = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPrExBase;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00035754 File Offset: 0x00033954
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
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
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0003586F File Offset: 0x00033A6F
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x00035877 File Offset: 0x00033A77
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00035880 File Offset: 0x00033A80
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x00035888 File Offset: 0x00033A88
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00035891 File Offset: 0x00033A91
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00035899 File Offset: 0x00033A99
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x000358A2 File Offset: 0x00033AA2
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x000358AA File Offset: 0x00033AAA
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000358B3 File Offset: 0x00033AB3
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000358BB File Offset: 0x00033ABB
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000358C4 File Offset: 0x00033AC4
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x000358CC File Offset: 0x00033ACC
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000358D5 File Offset: 0x00033AD5
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x000358DD File Offset: 0x00033ADD
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000358E6 File Offset: 0x00033AE6
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x000358EE File Offset: 0x00033AEE
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000358F7 File Offset: 0x00033AF7
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x000358FF File Offset: 0x00033AFF
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x04000D19 RID: 3353
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblWField;

		// Token: 0x04000D1A RID: 3354
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc jcField;

		// Token: 0x04000D1B RID: 3355
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblCellSpacingField;

		// Token: 0x04000D1C RID: 3356
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tblIndField;

		// Token: 0x04000D1D RID: 3357
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBordersField;

		// Token: 0x04000D1E RID: 3358
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x04000D1F RID: 3359
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType tblLayoutField;

		// Token: 0x04000D20 RID: 3360
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMarField;

		// Token: 0x04000D21 RID: 3361
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber tblLookField;
	}
}
