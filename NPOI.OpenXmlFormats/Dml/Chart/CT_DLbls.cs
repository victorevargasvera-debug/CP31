using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000439 RID: 1081
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DLbls
	{
		// Token: 0x06002B39 RID: 11065 RVA: 0x0006C6AC File Offset: 0x0006A8AC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls ct_DLbls = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls();
			ct_DLbls.dLbl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl>();
			ct_DLbls.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dLblPos")
				{
					ct_DLbls.dLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_DLbls.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DLbls.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_DLbls.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showBubbleSize")
				{
					ct_DLbls.showBubbleSize = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showCatName")
				{
					ct_DLbls.showCatName = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showLegendKey")
				{
					ct_DLbls.showLegendKey = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showPercent")
				{
					ct_DLbls.showPercent = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showSerName")
				{
					ct_DLbls.showSerName = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showVal")
				{
					ct_DLbls.showVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_DLbls.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "separator")
				{
					ct_DLbls.separator = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "showLeaderLines")
				{
					ct_DLbls.showLeaderLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbl")
				{
					ct_DLbls.dLbl.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DLbls.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DLbls;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0006C94C File Offset: 0x0006AB4C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
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
			if (this.showLegendKey != null)
			{
				this.showLegendKey.Write(sw, "showLegendKey");
			}
			if (this.showVal != null)
			{
				this.showVal.Write(sw, "showVal");
			}
			if (this.showCatName != null)
			{
				this.showCatName.Write(sw, "showCatName");
			}
			if (this.showSerName != null)
			{
				this.showSerName.Write(sw, "showSerName");
			}
			if (this.showPercent != null)
			{
				this.showPercent.Write(sw, "showPercent");
			}
			if (this.showBubbleSize != null)
			{
				this.showBubbleSize.Write(sw, "showBubbleSize");
			}
			if (this.delete != null)
			{
				this.delete.Write(sw, "delete");
			}
			if (this.separator != null)
			{
				sw.Write(string.Format("<separator>{0}</separator>", this.separator));
			}
			if (this.showLeaderLines != null)
			{
				this.showLeaderLines.Write(sw, "showLeaderLines");
			}
			if (this.dLbl != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl ct_DLbl in this.dLbl)
				{
					ct_DLbl.Write(sw, "dLbl");
				}
			}
			if (this.dLblPos != null)
			{
				this.dLblPos.Write(sw, "dLblPos");
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

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0006CB70 File Offset: 0x0006AD70
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0006CB78 File Offset: 0x0006AD78
		[global::System.Xml.Serialization.XmlElement("dLbl", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl> dLbl
		{
			get
			{
				return this.dLblField;
			}
			set
			{
				this.dLblField = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0006CB81 File Offset: 0x0006AD81
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0006CB89 File Offset: 0x0006AD89
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0006CB92 File Offset: 0x0006AD92
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x0006CB9A File Offset: 0x0006AD9A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x0006CBA3 File Offset: 0x0006ADA3
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x0006CBAB File Offset: 0x0006ADAB
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

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x0006CBB4 File Offset: 0x0006ADB4
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x0006CBBC File Offset: 0x0006ADBC
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x0006CBC5 File Offset: 0x0006ADC5
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x0006CBCD File Offset: 0x0006ADCD
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x0006CBD6 File Offset: 0x0006ADD6
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x0006CBDE File Offset: 0x0006ADDE
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x0006CBE7 File Offset: 0x0006ADE7
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0006CBEF File Offset: 0x0006ADEF
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0006CC00 File Offset: 0x0006AE00
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0006CC09 File Offset: 0x0006AE09
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x0006CC11 File Offset: 0x0006AE11
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

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0006CC1A File Offset: 0x0006AE1A
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x0006CC22 File Offset: 0x0006AE22
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

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x0006CC2B File Offset: 0x0006AE2B
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x0006CC33 File Offset: 0x0006AE33
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
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

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x0006CC3C File Offset: 0x0006AE3C
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x0006CC44 File Offset: 0x0006AE44
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x0006CC4D File Offset: 0x0006AE4D
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x0006CC55 File Offset: 0x0006AE55
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showLeaderLines
		{
			get
			{
				return this.showLeaderLinesField;
			}
			set
			{
				this.showLeaderLinesField = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0006CC5E File Offset: 0x0006AE5E
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0006CC66 File Offset: 0x0006AE66
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

		// Token: 0x04001EA7 RID: 7847
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl> dLblField;

		// Token: 0x04001EA8 RID: 7848
		private string separatorField;

		// Token: 0x04001EA9 RID: 7849
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001EAA RID: 7850
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showBubbleSizeField;

		// Token: 0x04001EAB RID: 7851
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showCatNameField;

		// Token: 0x04001EAC RID: 7852
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showLeaderLinesField;

		// Token: 0x04001EAD RID: 7853
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showLegendKeyField;

		// Token: 0x04001EAE RID: 7854
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showPercentField;

		// Token: 0x04001EAF RID: 7855
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showSerNameField;

		// Token: 0x04001EB0 RID: 7856
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showValField;

		// Token: 0x04001EB1 RID: 7857
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001EB2 RID: 7858
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos dLblPosField;

		// Token: 0x04001EB3 RID: 7859
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001EB4 RID: 7860
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001EB5 RID: 7861
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;
	}
}
