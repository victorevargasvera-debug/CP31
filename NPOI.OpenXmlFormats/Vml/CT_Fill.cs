using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001CF RID: 463
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public class CT_Fill
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x0003B2C0 File Offset: 0x000394C0
		public static global::NPOI.OpenXmlFormats.Vml.CT_Fill Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Fill ct_Fill = new global::NPOI.OpenXmlFormats.Vml.CT_Fill();
			ct_Fill.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			if (node.Attributes["type"] != null)
			{
				ct_Fill.type = (global::NPOI.OpenXmlFormats.Vml.ST_FillType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_FillType), node.Attributes["type"].Value);
			}
			if (node.Attributes["on"] != null)
			{
				ct_Fill.on = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["on"]);
			}
			ct_Fill.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color"]);
			ct_Fill.opacity = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["opacity"]);
			ct_Fill.color2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color2"]);
			ct_Fill.src = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["src"]);
			ct_Fill.size = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["size"]);
			ct_Fill.origin = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["origin"]);
			ct_Fill.position = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["position"]);
			if (node.Attributes["aspect"] != null)
			{
				ct_Fill.aspect = (global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect), node.Attributes["aspect"].Value);
			}
			ct_Fill.colors = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["colors"]);
			if (node.Attributes["angle"] != null)
			{
				ct_Fill.angle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDecimal(node.Attributes["angle"]);
			}
			if (node.Attributes["alignshape"] != null)
			{
				ct_Fill.alignshape = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["alignshape"]);
			}
			ct_Fill.focus = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["focus"]);
			ct_Fill.focussize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["focussize"]);
			ct_Fill.focusposition = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["focusposition"]);
			if (node.Attributes["method"] != null)
			{
				ct_Fill.method = (global::NPOI.OpenXmlFormats.Vml.ST_FillMethod)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_FillMethod), node.Attributes["method"].Value);
			}
			if (node.Attributes["recolor"] != null)
			{
				ct_Fill.recolor = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["recolor"]);
			}
			if (node.Attributes["rotate"] != null)
			{
				ct_Fill.rotate = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["rotate"]);
			}
			return ct_Fill;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0003B5C4 File Offset: 0x000397C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color", this.color);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color2", this.color2);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "src", this.src);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "size", this.size);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "origin", this.origin);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "position", this.position);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "aspect", this.aspect.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colors", this.colors);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "angle", (double)this.angle);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "alignshape", this.alignshape);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "focus", this.focus);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "focussize", this.focussize);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "focusposition", this.focusposition);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "method", this.method.ToString());
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "recolor", this.recolor);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "rotate", this.rotate);
			sw.Write(">");
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0003B782 File Offset: 0x00039982
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0003B78A File Offset: 0x0003998A
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0003B793 File Offset: 0x00039993
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0003B79B File Offset: 0x0003999B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_FillType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0003B7A4 File Offset: 0x000399A4
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0003B7AC File Offset: 0x000399AC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0003B7B5 File Offset: 0x000399B5
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0003B7BD File Offset: 0x000399BD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0003B7C6 File Offset: 0x000399C6
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0003B7CE File Offset: 0x000399CE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0003B7D7 File Offset: 0x000399D7
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0003B7DF File Offset: 0x000399DF
		[global::System.Xml.Serialization.XmlAttribute]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0003B7E8 File Offset: 0x000399E8
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0003B7F0 File Offset: 0x000399F0
		[global::System.Xml.Serialization.XmlAttribute]
		public string opacity
		{
			get
			{
				return this.opacityField;
			}
			set
			{
				this.opacityField = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x0003B7F9 File Offset: 0x000399F9
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0003B801 File Offset: 0x00039A01
		[global::System.Xml.Serialization.XmlAttribute]
		public string color2
		{
			get
			{
				return this.color2Field;
			}
			set
			{
				this.color2Field = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0003B80A File Offset: 0x00039A0A
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x0003B812 File Offset: 0x00039A12
		[global::System.Xml.Serialization.XmlAttribute]
		public string src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0003B81B File Offset: 0x00039A1B
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0003B823 File Offset: 0x00039A23
		[global::System.Xml.Serialization.XmlAttribute]
		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0003B82C File Offset: 0x00039A2C
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0003B834 File Offset: 0x00039A34
		[global::System.Xml.Serialization.XmlAttribute]
		public string origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0003B83D File Offset: 0x00039A3D
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0003B845 File Offset: 0x00039A45
		[global::System.Xml.Serialization.XmlAttribute]
		public string position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0003B84E File Offset: 0x00039A4E
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0003B856 File Offset: 0x00039A56
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect aspect
		{
			get
			{
				return this.aspectField;
			}
			set
			{
				this.aspectField = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0003B85F File Offset: 0x00039A5F
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0003B867 File Offset: 0x00039A67
		[global::System.Xml.Serialization.XmlIgnore]
		public bool aspectSpecified
		{
			get
			{
				return this.aspectFieldSpecified;
			}
			set
			{
				this.aspectFieldSpecified = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0003B870 File Offset: 0x00039A70
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0003B878 File Offset: 0x00039A78
		[global::System.Xml.Serialization.XmlAttribute]
		public string colors
		{
			get
			{
				return this.colorsField;
			}
			set
			{
				this.colorsField = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0003B881 File Offset: 0x00039A81
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0003B889 File Offset: 0x00039A89
		[global::System.Xml.Serialization.XmlAttribute]
		public decimal angle
		{
			get
			{
				return this.angleField;
			}
			set
			{
				this.angleField = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0003B892 File Offset: 0x00039A92
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0003B89A File Offset: 0x00039A9A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool angleSpecified
		{
			get
			{
				return this.angleFieldSpecified;
			}
			set
			{
				this.angleFieldSpecified = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0003B8A3 File Offset: 0x00039AA3
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x0003B8AB File Offset: 0x00039AAB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse alignshape
		{
			get
			{
				return this.alignshapeField;
			}
			set
			{
				this.alignshapeField = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0003B8B4 File Offset: 0x00039AB4
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool alignshapeSpecified
		{
			get
			{
				return this.alignshapeFieldSpecified;
			}
			set
			{
				this.alignshapeFieldSpecified = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0003B8C5 File Offset: 0x00039AC5
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0003B8CD File Offset: 0x00039ACD
		[global::System.Xml.Serialization.XmlAttribute]
		public string focus
		{
			get
			{
				return this.focusField;
			}
			set
			{
				this.focusField = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0003B8D6 File Offset: 0x00039AD6
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0003B8DE File Offset: 0x00039ADE
		[global::System.Xml.Serialization.XmlAttribute]
		public string focussize
		{
			get
			{
				return this.focussizeField;
			}
			set
			{
				this.focussizeField = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0003B8E7 File Offset: 0x00039AE7
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0003B8EF File Offset: 0x00039AEF
		[global::System.Xml.Serialization.XmlAttribute]
		public string focusposition
		{
			get
			{
				return this.focuspositionField;
			}
			set
			{
				this.focuspositionField = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0003B8F8 File Offset: 0x00039AF8
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0003B900 File Offset: 0x00039B00
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_FillMethod method
		{
			get
			{
				return this.methodField;
			}
			set
			{
				this.methodField = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0003B909 File Offset: 0x00039B09
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0003B911 File Offset: 0x00039B11
		[global::System.Xml.Serialization.XmlIgnore]
		public bool methodSpecified
		{
			get
			{
				return this.methodFieldSpecified;
			}
			set
			{
				this.methodFieldSpecified = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0003B91A File Offset: 0x00039B1A
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0003B922 File Offset: 0x00039B22
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse recolor
		{
			get
			{
				return this.recolorField;
			}
			set
			{
				this.recolorField = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0003B92B File Offset: 0x00039B2B
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x0003B933 File Offset: 0x00039B33
		[global::System.Xml.Serialization.XmlIgnore]
		public bool recolorSpecified
		{
			get
			{
				return this.recolorFieldSpecified;
			}
			set
			{
				this.recolorFieldSpecified = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0003B93C File Offset: 0x00039B3C
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x0003B944 File Offset: 0x00039B44
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse rotate
		{
			get
			{
				return this.rotateField;
			}
			set
			{
				this.rotateField = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0003B94D File Offset: 0x00039B4D
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x0003B955 File Offset: 0x00039B55
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rotateSpecified
		{
			get
			{
				return this.rotateFieldSpecified;
			}
			set
			{
				this.rotateFieldSpecified = value;
			}
		}

		// Token: 0x04000DBF RID: 3519
		private string idField;

		// Token: 0x04000DC0 RID: 3520
		private global::NPOI.OpenXmlFormats.Vml.ST_FillType typeField;

		// Token: 0x04000DC1 RID: 3521
		private bool typeFieldSpecified;

		// Token: 0x04000DC2 RID: 3522
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse onField;

		// Token: 0x04000DC3 RID: 3523
		private bool onFieldSpecified;

		// Token: 0x04000DC4 RID: 3524
		private string colorField;

		// Token: 0x04000DC5 RID: 3525
		private string opacityField;

		// Token: 0x04000DC6 RID: 3526
		private string color2Field;

		// Token: 0x04000DC7 RID: 3527
		private string srcField;

		// Token: 0x04000DC8 RID: 3528
		private string sizeField;

		// Token: 0x04000DC9 RID: 3529
		private string originField;

		// Token: 0x04000DCA RID: 3530
		private string positionField;

		// Token: 0x04000DCB RID: 3531
		private global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect aspectField;

		// Token: 0x04000DCC RID: 3532
		private bool aspectFieldSpecified;

		// Token: 0x04000DCD RID: 3533
		private string colorsField;

		// Token: 0x04000DCE RID: 3534
		private decimal angleField;

		// Token: 0x04000DCF RID: 3535
		private bool angleFieldSpecified;

		// Token: 0x04000DD0 RID: 3536
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse alignshapeField;

		// Token: 0x04000DD1 RID: 3537
		private bool alignshapeFieldSpecified;

		// Token: 0x04000DD2 RID: 3538
		private string focusField;

		// Token: 0x04000DD3 RID: 3539
		private string focussizeField;

		// Token: 0x04000DD4 RID: 3540
		private string focuspositionField;

		// Token: 0x04000DD5 RID: 3541
		private global::NPOI.OpenXmlFormats.Vml.ST_FillMethod methodField;

		// Token: 0x04000DD6 RID: 3542
		private bool methodFieldSpecified;

		// Token: 0x04000DD7 RID: 3543
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse recolorField;

		// Token: 0x04000DD8 RID: 3544
		private bool recolorFieldSpecified;

		// Token: 0x04000DD9 RID: 3545
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse rotateField;

		// Token: 0x04000DDA RID: 3546
		private bool rotateFieldSpecified;
	}
}
