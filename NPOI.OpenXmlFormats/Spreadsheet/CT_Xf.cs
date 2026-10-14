using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000519 RID: 1305
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(ElementName = "xf", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Xf
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x0008D77C File Offset: 0x0008B97C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf Copy()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf();
			if (this.alignment != null)
			{
				ct_Xf.alignment = this.alignment.Copy();
			}
			ct_Xf.protection = this.protection;
			ct_Xf.extLstField = ((this.extLstField == null) ? null : this.extLstField.Copy());
			ct_Xf.applyAlignment = this.applyAlignment;
			ct_Xf.applyBorder = this.applyBorder;
			ct_Xf.applyFill = this.applyFill;
			ct_Xf.applyFont = this.applyFont;
			ct_Xf.applyNumberFormat = this.applyNumberFormat;
			ct_Xf.applyProtection = this.applyProtection;
			ct_Xf.borderId = this.borderId;
			ct_Xf.borderIdSpecified = this.borderIdSpecified;
			ct_Xf.fillId = this.fillId;
			ct_Xf.fillIdSpecifiedField = this.fillIdSpecifiedField;
			ct_Xf.fontId = this.fontId;
			ct_Xf.fontIdSpecified = this.fontIdSpecified;
			ct_Xf.numFmtId = this.numFmtId;
			ct_Xf.numFmtIdSpecified = this.numFmtIdSpecified;
			ct_Xf.pivotButtonField = this.pivotButtonField;
			ct_Xf.quotePrefixField = this.quotePrefixField;
			ct_Xf.xfIdField = this.xfIdField;
			return ct_Xf;
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0008D8A0 File Offset: 0x0008BAA0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf();
			ct_Xf.numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"]);
			ct_Xf.fontId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fontId"]);
			ct_Xf.fillId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fillId"]);
			ct_Xf.borderId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["borderId"]);
			ct_Xf.xfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["xfId"]);
			ct_Xf.quotePrefix = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["quotePrefix"]);
			ct_Xf.pivotButton = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pivotButton"]);
			ct_Xf.applyNumberFormat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyNumberFormat"]);
			ct_Xf.applyFont = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyFont"]);
			ct_Xf.applyFill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyFill"]);
			ct_Xf.applyBorder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyBorder"]);
			ct_Xf.applyAlignment = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyAlignment"]);
			ct_Xf.applyProtection = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyProtection"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alignment")
				{
					ct_Xf.alignment = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "protection")
				{
					ct_Xf.protection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Xf.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Xf;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0008DAC0 File Offset: 0x0008BCC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fontId", this.fontId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fillId", this.fillId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "borderId", this.borderId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xfId", this.xfId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "quotePrefix", this.quotePrefix, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pivotButton", this.pivotButton, false);
			if (this.applyNumberFormat)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyNumberFormat", this.applyNumberFormat);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyFont", this.applyFont, false);
			if (this.applyFill)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyFill", this.applyFill);
			}
			if (this.applyBorder)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyBorder", this.applyBorder, true);
			}
			if (this.applyAlignment)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyAlignment", this.applyAlignment, true);
			}
			if (this.applyProtection)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyProtection", this.applyProtection, true);
			}
			if (this.alignment == null && this.protection == null && this.extLst == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			if (this.alignment != null)
			{
				this.alignment.Write(sw, "alignment");
			}
			if (this.protection != null)
			{
				this.protection.Write(sw, "protection");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0008DC7C File Offset: 0x0008BE7C
		public override string ToString()
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf));
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter())
			{
				xmlSerializer.Serialize(stringWriter, this);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0008DCCC File Offset: 0x0008BECC
		public bool IsSetFontId()
		{
			return this.fontIdSpecifiedField;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0008DCD4 File Offset: 0x0008BED4
		public bool IsSetAlignment()
		{
			return this.alignmentField != null;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0008DCDF File Offset: 0x0008BEDF
		public void UnsetAlignment()
		{
			this.alignmentField = null;
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0008DCE8 File Offset: 0x0008BEE8
		public bool IsSetExtLst()
		{
			return this.extLst == null;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0008DCF3 File Offset: 0x0008BEF3
		public void UnsetExtLst()
		{
			this.extLst = null;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0008DCFC File Offset: 0x0008BEFC
		public bool IsSetProtection()
		{
			return this.protection != null;
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0008DD07 File Offset: 0x0008BF07
		public void UnsetProtection()
		{
			this.protection = null;
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0008DD10 File Offset: 0x0008BF10
		public bool IsSetLocked()
		{
			return this.IsSetProtection() && this.protectionField.locked;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0008DD27 File Offset: 0x0008BF27
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection AddNewProtection()
		{
			this.protectionField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection();
			return this.protectionField;
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0008DD3A File Offset: 0x0008BF3A
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0008DD42 File Offset: 0x0008BF42
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment
		{
			get
			{
				return this.alignmentField;
			}
			set
			{
				this.alignmentField = value;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x0008DD4B File Offset: 0x0008BF4B
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x0008DD53 File Offset: 0x0008BF53
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection protection
		{
			get
			{
				return this.protectionField;
			}
			set
			{
				this.protectionField = value;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0008DD5C File Offset: 0x0008BF5C
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x0008DD64 File Offset: 0x0008BF64
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
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

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x0008DD6D File Offset: 0x0008BF6D
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x0008DD75 File Offset: 0x0008BF75
		[global::System.Xml.Serialization.XmlAttribute]
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
				this.numFmtIdSpecifiedField = true;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x0008DD85 File Offset: 0x0008BF85
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x0008DD8D File Offset: 0x0008BF8D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numFmtIdSpecified
		{
			get
			{
				return this.numFmtIdSpecifiedField;
			}
			set
			{
				this.numFmtIdSpecifiedField = value;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x0008DD96 File Offset: 0x0008BF96
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x0008DD9E File Offset: 0x0008BF9E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fontId
		{
			get
			{
				return this.fontIdField;
			}
			set
			{
				this.fontIdField = value;
				this.fontIdSpecifiedField = true;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0008DCCC File Offset: 0x0008BECC
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0008DDAE File Offset: 0x0008BFAE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fontIdSpecified
		{
			get
			{
				return this.fontIdSpecifiedField;
			}
			set
			{
				this.fontIdSpecifiedField = value;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x0008DDB7 File Offset: 0x0008BFB7
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0008DDBF File Offset: 0x0008BFBF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fillId
		{
			get
			{
				return this.fillIdField;
			}
			set
			{
				this.fillIdField = value;
				this.fillIdSpecifiedField = true;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0008DDCF File Offset: 0x0008BFCF
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0008DDD7 File Offset: 0x0008BFD7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fillIdSpecified
		{
			get
			{
				return this.fillIdSpecifiedField;
			}
			set
			{
				this.fillIdSpecifiedField = value;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x0008DDE0 File Offset: 0x0008BFE0
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0008DDE8 File Offset: 0x0008BFE8
		[global::System.Xml.Serialization.XmlAttribute]
		public uint borderId
		{
			get
			{
				return this.borderIdField;
			}
			set
			{
				this.borderIdField = value;
				this.borderIdSpecifiedField = true;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x0008DDF8 File Offset: 0x0008BFF8
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0008DE00 File Offset: 0x0008C000
		[global::System.Xml.Serialization.XmlIgnore]
		public bool borderIdSpecified
		{
			get
			{
				return this.borderIdSpecifiedField;
			}
			set
			{
				this.borderIdSpecifiedField = value;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x0008DE09 File Offset: 0x0008C009
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x0008DE11 File Offset: 0x0008C011
		[global::System.Xml.Serialization.XmlAttribute]
		public uint xfId
		{
			get
			{
				return this.xfIdField;
			}
			set
			{
				this.xfIdField = value;
				this.xfIdSpecifiedField = true;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x0008DE21 File Offset: 0x0008C021
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x0008DE29 File Offset: 0x0008C029
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xfIdSpecified
		{
			get
			{
				return this.xfIdSpecifiedField;
			}
			set
			{
				this.xfIdSpecifiedField = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x0008DE32 File Offset: 0x0008C032
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x0008DE3A File Offset: 0x0008C03A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool quotePrefix
		{
			get
			{
				return this.quotePrefixField;
			}
			set
			{
				this.quotePrefixField = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x0008DE43 File Offset: 0x0008C043
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x0008DE4B File Offset: 0x0008C04B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pivotButton
		{
			get
			{
				return this.pivotButtonField;
			}
			set
			{
				this.pivotButtonField = value;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x0008DE54 File Offset: 0x0008C054
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x0008DE5C File Offset: 0x0008C05C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyNumberFormat
		{
			get
			{
				return this.applyNumberFormatField;
			}
			set
			{
				this.applyNumberFormatField = value;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x0008DE65 File Offset: 0x0008C065
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x0008DE6D File Offset: 0x0008C06D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyFont
		{
			get
			{
				return this.applyFontField;
			}
			set
			{
				this.applyFontField = value;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0008DE76 File Offset: 0x0008C076
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x0008DE7E File Offset: 0x0008C07E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyFill
		{
			get
			{
				return this.applyFillField;
			}
			set
			{
				this.applyFillField = value;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0008DE87 File Offset: 0x0008C087
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x0008DE8F File Offset: 0x0008C08F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyBorder
		{
			get
			{
				return this.applyBorderField;
			}
			set
			{
				this.applyBorderField = value;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0008DE98 File Offset: 0x0008C098
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x0008DEA0 File Offset: 0x0008C0A0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyAlignment
		{
			get
			{
				return this.applyAlignmentField;
			}
			set
			{
				this.applyAlignmentField = value;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x0008DEA9 File Offset: 0x0008C0A9
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0008DEB1 File Offset: 0x0008C0B1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyProtection
		{
			get
			{
				return this.applyProtectionField;
			}
			set
			{
				this.applyProtectionField = value;
			}
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0008DE76 File Offset: 0x0008C076
		public bool IsSetApplyFill()
		{
			return this.applyFillField;
		}

		// Token: 0x04002494 RID: 9364
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignmentField;

		// Token: 0x04002495 RID: 9365
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection protectionField;

		// Token: 0x04002496 RID: 9366
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002497 RID: 9367
		private uint numFmtIdField;

		// Token: 0x04002498 RID: 9368
		private uint fontIdField;

		// Token: 0x04002499 RID: 9369
		private uint fillIdField;

		// Token: 0x0400249A RID: 9370
		private uint borderIdField;

		// Token: 0x0400249B RID: 9371
		private uint xfIdField;

		// Token: 0x0400249C RID: 9372
		private bool quotePrefixField;

		// Token: 0x0400249D RID: 9373
		private bool pivotButtonField;

		// Token: 0x0400249E RID: 9374
		private bool applyNumberFormatField;

		// Token: 0x0400249F RID: 9375
		private bool applyFontField;

		// Token: 0x040024A0 RID: 9376
		private bool applyFillField;

		// Token: 0x040024A1 RID: 9377
		private bool applyBorderField;

		// Token: 0x040024A2 RID: 9378
		private bool applyAlignmentField;

		// Token: 0x040024A3 RID: 9379
		private bool applyProtectionField;

		// Token: 0x040024A4 RID: 9380
		private bool numFmtIdSpecifiedField;

		// Token: 0x040024A5 RID: 9381
		private bool fontIdSpecifiedField;

		// Token: 0x040024A6 RID: 9382
		private bool fillIdSpecifiedField;

		// Token: 0x040024A7 RID: 9383
		private bool borderIdSpecifiedField;

		// Token: 0x040024A8 RID: 9384
		private bool xfIdSpecifiedField;
	}
}
