using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200043A RID: 1082
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DLbl
	{
		// Token: 0x06002B5A RID: 11098 RVA: 0x0006CC70 File Offset: 0x0006AE70
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl ct_DLbl = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl();
			ct_DLbl.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_DLbl.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "layout")
				{
					ct_DLbl.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLblPos")
				{
					ct_DLbl.dLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_DLbl.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DLbl.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_DLbl.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_DLbl.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showBubbleSize")
				{
					ct_DLbl.showBubbleSize = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showCatName")
				{
					ct_DLbl.showCatName = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showLegendKey")
				{
					ct_DLbl.showLegendKey = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showPercent")
				{
					ct_DLbl.showPercent = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showSerName")
				{
					ct_DLbl.showSerName = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showVal")
				{
					ct_DLbl.showVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "separator")
				{
					ct_DLbl.separator = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DLbl.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DLbl;
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0006CF00 File Offset: 0x0006B100
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.idx != null)
			{
				this.idx.Write(sw, "idx");
			}
			if (this.layout != null)
			{
				this.layout.Write(sw, "layout");
			}
			if (this.dLblPos != null)
			{
				this.dLblPos.Write(sw, "dLblPos");
			}
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
			}
			if (this.delete != null)
			{
				this.delete.Write(sw, "delete");
			}
			if (this.showBubbleSize != null)
			{
				this.showBubbleSize.Write(sw, "showBubbleSize");
			}
			if (this.showCatName != null)
			{
				this.showCatName.Write(sw, "showCatName");
			}
			if (this.showLegendKey != null)
			{
				this.showLegendKey.Write(sw, "showLegendKey");
			}
			if (this.showPercent != null)
			{
				this.showPercent.Write(sw, "showPercent");
			}
			if (this.showSerName != null)
			{
				this.showSerName.Write(sw, "showSerName");
			}
			if (this.showVal != null)
			{
				this.showVal.Write(sw, "showVal");
			}
			if (this.separator != null)
			{
				sw.Write(string.Format("<separator>{0}</separator>", this.separator));
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idx
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x0006D101 File Offset: 0x0006B301
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x0006D109 File Offset: 0x0006B309
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layout
		{
			get
			{
				return this.layoutField;
			}
			set
			{
				this.layoutField = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x0006D112 File Offset: 0x0006B312
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x0006D11A File Offset: 0x0006B31A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos dLblPos
		{
			get
			{
				return this.dLblPosField;
			}
			set
			{
				this.dLblPosField = value;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x0006D123 File Offset: 0x0006B323
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x0006D12B File Offset: 0x0006B32B
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x0006D134 File Offset: 0x0006B334
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x0006D13C File Offset: 0x0006B33C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x0006D145 File Offset: 0x0006B345
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x0006D14D File Offset: 0x0006B34D
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPr
		{
			get
			{
				return this.txPrField;
			}
			set
			{
				this.txPrField = value;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x0006D156 File Offset: 0x0006B356
		// (set) Token: 0x06002B69 RID: 11113 RVA: 0x0006D15E File Offset: 0x0006B35E
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x0006D167 File Offset: 0x0006B367
		// (set) Token: 0x06002B6B RID: 11115 RVA: 0x0006D16F File Offset: 0x0006B36F
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showBubbleSize
		{
			get
			{
				return this.showBubbleSizeField;
			}
			set
			{
				this.showBubbleSizeField = value;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x0006D178 File Offset: 0x0006B378
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x0006D180 File Offset: 0x0006B380
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showCatName
		{
			get
			{
				return this.showCatNameField;
			}
			set
			{
				this.showCatNameField = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x0006D189 File Offset: 0x0006B389
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x0006D191 File Offset: 0x0006B391
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showLegendKey
		{
			get
			{
				return this.showLegendKeyField;
			}
			set
			{
				this.showLegendKeyField = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0006D19A File Offset: 0x0006B39A
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x0006D1A2 File Offset: 0x0006B3A2
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showPercent
		{
			get
			{
				return this.showPercentField;
			}
			set
			{
				this.showPercentField = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x0006D1AB File Offset: 0x0006B3AB
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x0006D1B3 File Offset: 0x0006B3B3
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showSerName
		{
			get
			{
				return this.showSerNameField;
			}
			set
			{
				this.showSerNameField = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0006D1BC File Offset: 0x0006B3BC
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x0006D1C4 File Offset: 0x0006B3C4
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showVal
		{
			get
			{
				return this.showValField;
			}
			set
			{
				this.showValField = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0006D1CD File Offset: 0x0006B3CD
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x0006D1D5 File Offset: 0x0006B3D5
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public string separator
		{
			get
			{
				return this.separatorField;
			}
			set
			{
				this.separatorField = value;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0006D1DE File Offset: 0x0006B3DE
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x0006D1E6 File Offset: 0x0006B3E6
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
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

		// Token: 0x04001EB6 RID: 7862
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001EB7 RID: 7863
		private string separatorField;

		// Token: 0x04001EB8 RID: 7864
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001EB9 RID: 7865
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showBubbleSizeField;

		// Token: 0x04001EBA RID: 7866
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showCatNameField;

		// Token: 0x04001EBB RID: 7867
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showLegendKeyField;

		// Token: 0x04001EBC RID: 7868
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showPercentField;

		// Token: 0x04001EBD RID: 7869
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showSerNameField;

		// Token: 0x04001EBE RID: 7870
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showValField;

		// Token: 0x04001EBF RID: 7871
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001EC0 RID: 7872
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos dLblPosField;

		// Token: 0x04001EC1 RID: 7873
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001EC2 RID: 7874
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001EC3 RID: 7875
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001EC4 RID: 7876
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;
	}
}
