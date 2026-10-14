using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000264 RID: 612
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextParagraphProperties
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x00044AAD File Offset: 0x00042CAD
		public CT_TextParagraphProperties()
		{
			this.algn = global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType.l;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00044ABC File Offset: 0x00042CBC
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties();
			ct_TextParagraphProperties.marL = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["marL"]);
			ct_TextParagraphProperties.marR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["marR"]);
			ct_TextParagraphProperties.lvlFieldSpecified = (node.Attributes["lvl"] != null);
			ct_TextParagraphProperties.lvlField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lvl"]);
			ct_TextParagraphProperties.indent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["indent"]);
			ct_TextParagraphProperties.algnFieldSpecified = (node.Attributes["algn"] != null);
			if (node.Attributes["algn"] != null)
			{
				ct_TextParagraphProperties.algnField = (global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType), node.Attributes["algn"].Value);
			}
			else
			{
				ct_TextParagraphProperties.algnField = global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType.l;
			}
			ct_TextParagraphProperties.defTabSz = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["defTabSz"]);
			ct_TextParagraphProperties.rtlFieldSpecified = (node.Attributes["rtl"] != null);
			ct_TextParagraphProperties.rtlField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rtl"]);
			ct_TextParagraphProperties.eaLnBrk = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["eaLnBrk"]);
			ct_TextParagraphProperties.fontAlgnFieldSpecified = (node.Attributes["fontAlgn"] != null);
			if (node.Attributes["fontAlgn"] != null)
			{
				ct_TextParagraphProperties.fontAlgnField = (global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType), node.Attributes["fontAlgn"].Value);
			}
			ct_TextParagraphProperties.latinLnBrkFieldSpecified = (node.Attributes["latinLnBrk"] != null);
			ct_TextParagraphProperties.latinLnBrkField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["latinLnBrk"]);
			ct_TextParagraphProperties.hangingPunct = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hangingPunct"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "lnSpc")
				{
					ct_TextParagraphProperties.lnSpc = global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spcBef")
				{
					ct_TextParagraphProperties.spcBef = global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spcAft")
				{
					ct_TextParagraphProperties.spcAft = global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buClrTx")
				{
					ct_TextParagraphProperties.buClrTx = new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletColorFollowText();
				}
				else if (xmlNode.LocalName == "buClr")
				{
					ct_TextParagraphProperties.buClr = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buSzTx")
				{
					ct_TextParagraphProperties.buSzTx = new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizeFollowText();
				}
				else if (xmlNode.LocalName == "buSzPct")
				{
					ct_TextParagraphProperties.buSzPct = global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buSzPts")
				{
					ct_TextParagraphProperties.buSzPts = global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buFontTx")
				{
					ct_TextParagraphProperties.buFontTx = new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletTypefaceFollowText();
				}
				else if (xmlNode.LocalName == "buFont")
				{
					ct_TextParagraphProperties.buFont = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buNone")
				{
					ct_TextParagraphProperties.buNone = new global::NPOI.OpenXmlFormats.Dml.CT_TextNoBullet();
				}
				else if (xmlNode.LocalName == "buAutoNum")
				{
					ct_TextParagraphProperties.buAutoNum = global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buChar")
				{
					ct_TextParagraphProperties.buChar = global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "buBlip")
				{
					ct_TextParagraphProperties.buBlip = global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "defRPr")
				{
					ct_TextParagraphProperties.defRPr = global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TextParagraphProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tabLst")
				{
					ct_TextParagraphProperties.tabLst = global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextParagraphProperties;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00044F78 File Offset: 0x00043178
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "marL", this.marL);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "marR", this.marR);
			if (this.lvlFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lvl", this.lvlField, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "indent", this.indent);
			if (this.algnFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algnField.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defTabSz", this.defTabSz);
			if (this.rtlFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rtl", this.rtlField);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "eaLnBrk", this.eaLnBrk, false);
			if (this.fontAlgnFieldSpecified && this.fontAlgn != global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType.auto)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fontAlgn", this.fontAlgnField.ToString());
			}
			if (this.latinLnBrkFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "latinLnBrk", this.latinLnBrk, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hangingPunct", this.hangingPunct, false);
			sw.Write(">");
			if (this.lnSpc != null)
			{
				this.lnSpc.Write(sw, "lnSpc");
			}
			if (this.spcBef != null)
			{
				this.spcBef.Write(sw, "spcBef");
			}
			if (this.spcAft != null)
			{
				this.spcAft.Write(sw, "spcAft");
			}
			if (this.buClrTx != null)
			{
				sw.Write("<a:buClrTx/>");
			}
			if (this.buClr != null)
			{
				this.buClr.Write(sw, "buClr");
			}
			if (this.buSzTx != null)
			{
				sw.Write("<a:buSzTx/>");
			}
			if (this.buSzPct != null)
			{
				this.buSzPct.Write(sw, "buSzPct");
			}
			if (this.buSzPts != null)
			{
				this.buSzPts.Write(sw, "buSzPts");
			}
			if (this.buFontTx != null)
			{
				sw.Write("<a:buFontTx/>");
			}
			if (this.buFont != null)
			{
				this.buFont.Write(sw, "buFont");
			}
			if (this.buNone != null)
			{
				sw.Write("<a:buNone/>");
			}
			if (this.buAutoNum != null)
			{
				this.buAutoNum.Write(sw, "buAutoNum");
			}
			if (this.buChar != null)
			{
				this.buChar.Write(sw, "buChar");
			}
			if (this.buBlip != null)
			{
				this.buBlip.Write(sw, "buBlip");
			}
			if (this.tabLstField != null)
			{
				this.tabLstField.Write(sw, "tabLst");
			}
			if (this.defRPr != null)
			{
				this.defRPr.Write(sw, "defRPr");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00045248 File Offset: 0x00043448
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00045250 File Offset: 0x00043450
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing lnSpc
		{
			get
			{
				return this.lnSpcField;
			}
			set
			{
				this.lnSpcField = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00045259 File Offset: 0x00043459
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00045261 File Offset: 0x00043461
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcBef
		{
			get
			{
				return this.spcBefField;
			}
			set
			{
				this.spcBefField = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0004526A File Offset: 0x0004346A
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00045272 File Offset: 0x00043472
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcAft
		{
			get
			{
				return this.spcAftField;
			}
			set
			{
				this.spcAftField = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0004527B File Offset: 0x0004347B
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00045283 File Offset: 0x00043483
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletColorFollowText buClrTx
		{
			get
			{
				return this.buClrTxField;
			}
			set
			{
				this.buClrTxField = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0004528C File Offset: 0x0004348C
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x00045294 File Offset: 0x00043494
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color buClr
		{
			get
			{
				return this.buClrField;
			}
			set
			{
				this.buClrField = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0004529D File Offset: 0x0004349D
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x000452A5 File Offset: 0x000434A5
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizeFollowText buSzTx
		{
			get
			{
				return this.buSzTxField;
			}
			set
			{
				this.buSzTxField = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000452AE File Offset: 0x000434AE
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x000452B6 File Offset: 0x000434B6
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent buSzPct
		{
			get
			{
				return this.buSzPctField;
			}
			set
			{
				this.buSzPctField = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000452BF File Offset: 0x000434BF
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x000452C7 File Offset: 0x000434C7
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint buSzPts
		{
			get
			{
				return this.buSzPtsField;
			}
			set
			{
				this.buSzPtsField = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000452D0 File Offset: 0x000434D0
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x000452D8 File Offset: 0x000434D8
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletTypefaceFollowText buFontTx
		{
			get
			{
				return this.buFontTxField;
			}
			set
			{
				this.buFontTxField = value;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000452E1 File Offset: 0x000434E1
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x000452E9 File Offset: 0x000434E9
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont buFont
		{
			get
			{
				return this.buFontField;
			}
			set
			{
				this.buFontField = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000452F2 File Offset: 0x000434F2
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x000452FA File Offset: 0x000434FA
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextNoBullet buNone
		{
			get
			{
				return this.buNoneField;
			}
			set
			{
				this.buNoneField = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00045303 File Offset: 0x00043503
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0004530B File Offset: 0x0004350B
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet buAutoNum
		{
			get
			{
				return this.buAutoNumField;
			}
			set
			{
				this.buAutoNumField = value;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00045314 File Offset: 0x00043514
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0004531C File Offset: 0x0004351C
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet buChar
		{
			get
			{
				return this.buCharField;
			}
			set
			{
				this.buCharField = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00045325 File Offset: 0x00043525
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0004532D File Offset: 0x0004352D
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet buBlip
		{
			get
			{
				return this.buBlipField;
			}
			set
			{
				this.buBlipField = value;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00045336 File Offset: 0x00043536
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0004533E File Offset: 0x0004353E
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList tabLst
		{
			get
			{
				return this.tabLstField;
			}
			set
			{
				this.tabLstField = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00045347 File Offset: 0x00043547
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0004534F File Offset: 0x0004354F
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties defRPr
		{
			get
			{
				return this.defRPrField;
			}
			set
			{
				this.defRPrField = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00045358 File Offset: 0x00043558
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00045360 File Offset: 0x00043560
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00045369 File Offset: 0x00043569
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00045371 File Offset: 0x00043571
		[global::System.Xml.Serialization.XmlAttribute]
		public int marL
		{
			get
			{
				return this.marLField;
			}
			set
			{
				this.marLField = value;
				this.marLFieldSpecified = true;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00045381 File Offset: 0x00043581
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00045389 File Offset: 0x00043589
		[global::System.Xml.Serialization.XmlIgnore]
		public bool marLSpecified
		{
			get
			{
				return this.marLFieldSpecified;
			}
			set
			{
				this.marLFieldSpecified = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00045392 File Offset: 0x00043592
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0004539A File Offset: 0x0004359A
		[global::System.Xml.Serialization.XmlAttribute]
		public int marR
		{
			get
			{
				return this.marRField;
			}
			set
			{
				this.marRField = value;
				this.marRFieldSpecified = true;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x000453AA File Offset: 0x000435AA
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x000453B2 File Offset: 0x000435B2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool marRSpecified
		{
			get
			{
				return this.marRFieldSpecified;
			}
			set
			{
				this.marRFieldSpecified = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x000453BB File Offset: 0x000435BB
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x000453C3 File Offset: 0x000435C3
		[global::System.Xml.Serialization.XmlAttribute]
		public int lvl
		{
			get
			{
				return this.lvlField;
			}
			set
			{
				this.lvlField = value;
				this.lvlFieldSpecified = true;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000453D3 File Offset: 0x000435D3
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x000453DB File Offset: 0x000435DB
		[global::System.Xml.Serialization.XmlAttribute]
		public int indent
		{
			get
			{
				return this.indentField;
			}
			set
			{
				this.indentField = value;
				this.indentFieldSpecified = true;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000453EB File Offset: 0x000435EB
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x000453F3 File Offset: 0x000435F3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool indentSpecified
		{
			get
			{
				return this.indentFieldSpecified;
			}
			set
			{
				this.indentFieldSpecified = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000453FC File Offset: 0x000435FC
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00045404 File Offset: 0x00043604
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
				this.algnFieldSpecified = true;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00045414 File Offset: 0x00043614
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0004541C File Offset: 0x0004361C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnFieldSpecified;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x00045425 File Offset: 0x00043625
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0004542D File Offset: 0x0004362D
		[global::System.Xml.Serialization.XmlAttribute]
		public int defTabSz
		{
			get
			{
				return this.defTabSzField;
			}
			set
			{
				this.defTabSzField = value;
				this.defTabSzFieldSpecified = true;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0004543D File Offset: 0x0004363D
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x00045445 File Offset: 0x00043645
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defTabSzSpecified
		{
			get
			{
				return this.defTabSzFieldSpecified;
			}
			set
			{
				this.defTabSzFieldSpecified = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0004544E File Offset: 0x0004364E
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00045456 File Offset: 0x00043656
		[global::System.Xml.Serialization.XmlAttribute]
		public bool rtl
		{
			get
			{
				return this.rtlField;
			}
			set
			{
				this.rtlField = value;
				this.rtlFieldSpecified = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00045466 File Offset: 0x00043666
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0004546E File Offset: 0x0004366E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rtlSpecified
		{
			get
			{
				return this.rtlFieldSpecified;
			}
			set
			{
				this.rtlFieldSpecified = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00045477 File Offset: 0x00043677
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0004547F File Offset: 0x0004367F
		[global::System.Xml.Serialization.XmlAttribute]
		public bool eaLnBrk
		{
			get
			{
				return this.eaLnBrkField;
			}
			set
			{
				this.eaLnBrkField = value;
				this.eaLnBrkFieldSpecified = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0004548F File Offset: 0x0004368F
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00045497 File Offset: 0x00043697
		[global::System.Xml.Serialization.XmlIgnore]
		public bool eaLnBrkSpecified
		{
			get
			{
				return this.eaLnBrkFieldSpecified;
			}
			set
			{
				this.eaLnBrkFieldSpecified = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x000454A0 File Offset: 0x000436A0
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x000454A8 File Offset: 0x000436A8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType fontAlgn
		{
			get
			{
				return this.fontAlgnField;
			}
			set
			{
				this.fontAlgnField = value;
				this.fontAlgnFieldSpecified = true;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x000454B8 File Offset: 0x000436B8
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x000454C0 File Offset: 0x000436C0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fontAlgnSpecified
		{
			get
			{
				return this.fontAlgnFieldSpecified;
			}
			set
			{
				this.fontAlgnFieldSpecified = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x000454C9 File Offset: 0x000436C9
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x000454D1 File Offset: 0x000436D1
		[global::System.Xml.Serialization.XmlAttribute]
		public bool latinLnBrk
		{
			get
			{
				return this.latinLnBrkField;
			}
			set
			{
				this.latinLnBrkField = value;
				this.latinLnBrkFieldSpecified = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000454E1 File Offset: 0x000436E1
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x000454E9 File Offset: 0x000436E9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool latinLnBrkSpecified
		{
			get
			{
				return this.latinLnBrkFieldSpecified;
			}
			set
			{
				this.latinLnBrkFieldSpecified = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000454F2 File Offset: 0x000436F2
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x000454FA File Offset: 0x000436FA
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hangingPunct
		{
			get
			{
				return this.hangingPunctField;
			}
			set
			{
				this.hangingPunctField = value;
				this.hangingPunctFieldSpecified = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0004550A File Offset: 0x0004370A
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00045512 File Offset: 0x00043712
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hangingPunctSpecified
		{
			get
			{
				return this.hangingPunctFieldSpecified;
			}
			set
			{
				this.hangingPunctFieldSpecified = value;
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00045414 File Offset: 0x00043614
		public bool IsSetAlgn()
		{
			return this.algnFieldSpecified;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0004551B File Offset: 0x0004371B
		public bool IsSetBuNone()
		{
			return this.buNoneField != null;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00045526 File Offset: 0x00043726
		public bool IsSetBuFont()
		{
			return this.buFontField != null;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00045531 File Offset: 0x00043731
		public bool IsSetBuChar()
		{
			return this.buCharField != null;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0004553C File Offset: 0x0004373C
		public bool IsSetBuAutoNum()
		{
			return this.buAutoNumField != null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00045547 File Offset: 0x00043747
		public void AddNewBuNone()
		{
			this.buNoneField = new global::NPOI.OpenXmlFormats.Dml.CT_TextNoBullet();
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00045554 File Offset: 0x00043754
		public bool IsSetBuBlip()
		{
			return this.buBlipField != null;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0004555F File Offset: 0x0004375F
		public bool IsSetBuClr()
		{
			return this.buClrField != null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0004556A File Offset: 0x0004376A
		public bool IsSetBuClrTx()
		{
			return this.buClrTxField != null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00045575 File Offset: 0x00043775
		public bool IsSetBuFontTx()
		{
			return this.buFontTxField != null;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00045580 File Offset: 0x00043780
		public bool IsSetBuSzPct()
		{
			return this.buSzPctField != null;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0004558B File Offset: 0x0004378B
		public bool IsSetBuSzPts()
		{
			return this.buSzPtsField != null;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00045596 File Offset: 0x00043796
		public bool IsSetBuSzTx()
		{
			return this.buSzTxField != null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000455A1 File Offset: 0x000437A1
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet AddNewBuChar()
		{
			this.buCharField = new global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet();
			return this.buCharField;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000455B4 File Offset: 0x000437B4
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont AddNewBuFont()
		{
			this.buFontField = new global::NPOI.OpenXmlFormats.Dml.CT_TextFont();
			return this.buFontField;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000455C7 File Offset: 0x000437C7
		public void UnsetBuNone()
		{
			this.buNoneField = null;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000455D0 File Offset: 0x000437D0
		public void UnsetBuSzTx()
		{
			this.buSzTxField = null;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000455D9 File Offset: 0x000437D9
		public void UnsetBuSzPts()
		{
			this.buSzPtsField = null;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000455E2 File Offset: 0x000437E2
		public void UnsetBuAutoNum()
		{
			this.buAutoNumField = null;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000455EB File Offset: 0x000437EB
		public void UnsetBuBlip()
		{
			this.buBlipField = null;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000455F4 File Offset: 0x000437F4
		public void UnsetBuChar()
		{
			this.buCharField = null;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000455FD File Offset: 0x000437FD
		public void UnsetBuClr()
		{
			this.buClrField = null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00045606 File Offset: 0x00043806
		public void UnsetBuClrTx()
		{
			this.buClrTxField = null;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0004560F File Offset: 0x0004380F
		public void UnsetBuFont()
		{
			this.buFontField = null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00045618 File Offset: 0x00043818
		public void UnsetBuFontTx()
		{
			this.buFontTxField = null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00045621 File Offset: 0x00043821
		public void UnsetBuSzPct()
		{
			this.buSzPctField = null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0004562A File Offset: 0x0004382A
		public void UnsetAlgn()
		{
			this.algnFieldSpecified = false;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000454B8 File Offset: 0x000436B8
		public bool IsSetFontAlgn()
		{
			return this.fontAlgnFieldSpecified;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00045633 File Offset: 0x00043833
		public void UnsetFontAlgn()
		{
			this.fontAlgnFieldSpecified = false;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0004563C File Offset: 0x0004383C
		public global::NPOI.OpenXmlFormats.Dml.CT_Color AddNewBuClr()
		{
			this.buClrField = new global::NPOI.OpenXmlFormats.Dml.CT_Color();
			return this.buClrField;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0004564F File Offset: 0x0004384F
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent AddNewBuSzPct()
		{
			this.buSzPctField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent();
			return this.buSzPctField;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00045662 File Offset: 0x00043862
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint AddNewBuSzPts()
		{
			this.buSzPtsField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint();
			return this.buSzPtsField;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000453EB File Offset: 0x000435EB
		public bool IsSetIndent()
		{
			return this.indentFieldSpecified;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00045675 File Offset: 0x00043875
		public void UnsetIndent()
		{
			this.indentFieldSpecified = false;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00045381 File Offset: 0x00043581
		public bool IsSetMarL()
		{
			return this.marLFieldSpecified;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0004567E File Offset: 0x0004387E
		public void UnsetMarL()
		{
			this.marLFieldSpecified = false;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000453AA File Offset: 0x000435AA
		public bool IsSetMarR()
		{
			return this.marRFieldSpecified;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00045687 File Offset: 0x00043887
		public void UnsetMarR()
		{
			this.marRFieldSpecified = false;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0004543D File Offset: 0x0004363D
		public bool IsSetDefTabSz()
		{
			return this.defTabSzFieldSpecified;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00045690 File Offset: 0x00043890
		public bool IsSetTabLst()
		{
			return this.tabLstField != null;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0004569B File Offset: 0x0004389B
		public global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList AddNewTabLst()
		{
			this.tabLstField = new global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList();
			return this.tabLstField;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000456AE File Offset: 0x000438AE
		public bool IsSetLnSpc()
		{
			return this.lnSpcField != null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000456B9 File Offset: 0x000438B9
		public bool IsSetSpcBef()
		{
			return this.spcBefField != null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x000456C4 File Offset: 0x000438C4
		public bool IsSetSpcAft()
		{
			return this.spcAftField != null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000456CF File Offset: 0x000438CF
		public global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet AddNewBuAutoNum()
		{
			this.buAutoNumField = new global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet();
			return this.buAutoNumField;
		}

		// Token: 0x040012DF RID: 4831
		private global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing lnSpcField;

		// Token: 0x040012E0 RID: 4832
		private global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcBefField;

		// Token: 0x040012E1 RID: 4833
		private global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcAftField;

		// Token: 0x040012E2 RID: 4834
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBulletColorFollowText buClrTxField;

		// Token: 0x040012E3 RID: 4835
		private global::NPOI.OpenXmlFormats.Dml.CT_Color buClrField;

		// Token: 0x040012E4 RID: 4836
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizeFollowText buSzTxField;

		// Token: 0x040012E5 RID: 4837
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent buSzPctField;

		// Token: 0x040012E6 RID: 4838
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint buSzPtsField;

		// Token: 0x040012E7 RID: 4839
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBulletTypefaceFollowText buFontTxField;

		// Token: 0x040012E8 RID: 4840
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont buFontField;

		// Token: 0x040012E9 RID: 4841
		private global::NPOI.OpenXmlFormats.Dml.CT_TextNoBullet buNoneField;

		// Token: 0x040012EA RID: 4842
		private global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet buAutoNumField;

		// Token: 0x040012EB RID: 4843
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet buCharField;

		// Token: 0x040012EC RID: 4844
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet buBlipField;

		// Token: 0x040012ED RID: 4845
		private global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList tabLstField;

		// Token: 0x040012EE RID: 4846
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties defRPrField;

		// Token: 0x040012EF RID: 4847
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040012F0 RID: 4848
		private int marLField;

		// Token: 0x040012F1 RID: 4849
		private bool marLFieldSpecified;

		// Token: 0x040012F2 RID: 4850
		private int marRField;

		// Token: 0x040012F3 RID: 4851
		private bool marRFieldSpecified;

		// Token: 0x040012F4 RID: 4852
		private int lvlField;

		// Token: 0x040012F5 RID: 4853
		private bool lvlFieldSpecified;

		// Token: 0x040012F6 RID: 4854
		private int indentField;

		// Token: 0x040012F7 RID: 4855
		private bool indentFieldSpecified;

		// Token: 0x040012F8 RID: 4856
		private global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType algnField;

		// Token: 0x040012F9 RID: 4857
		private bool algnFieldSpecified;

		// Token: 0x040012FA RID: 4858
		private int defTabSzField;

		// Token: 0x040012FB RID: 4859
		private bool defTabSzFieldSpecified;

		// Token: 0x040012FC RID: 4860
		private bool rtlField;

		// Token: 0x040012FD RID: 4861
		private bool rtlFieldSpecified;

		// Token: 0x040012FE RID: 4862
		private bool eaLnBrkField;

		// Token: 0x040012FF RID: 4863
		private bool eaLnBrkFieldSpecified;

		// Token: 0x04001300 RID: 4864
		private global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType fontAlgnField;

		// Token: 0x04001301 RID: 4865
		private bool fontAlgnFieldSpecified;

		// Token: 0x04001302 RID: 4866
		private bool latinLnBrkField;

		// Token: 0x04001303 RID: 4867
		private bool latinLnBrkFieldSpecified;

		// Token: 0x04001304 RID: 4868
		private bool hangingPunctField;

		// Token: 0x04001305 RID: 4869
		private bool hangingPunctFieldSpecified;
	}
}
