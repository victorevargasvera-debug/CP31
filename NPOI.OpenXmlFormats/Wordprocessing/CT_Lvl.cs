using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B8 RID: 184
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Lvl
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x0000E734 File Offset: 0x0000C934
		public CT_Lvl()
		{
			this.rPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			this.pPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr();
			this.lvlJcField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc();
			this.lvlTextField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText();
			this.numFmtField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt();
			this.startField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.tentativeField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000E790 File Offset: 0x0000C990
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl();
			ct_Lvl.ilvl = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:ilvl"]);
			ct_Lvl.tplc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:tplc"]);
			if (node.Attributes["w:tentative"] != null)
			{
				ct_Lvl.tentative = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:tentative"].Value, true);
				ct_Lvl.tentativeSpecified = true;
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "start")
				{
					ct_Lvl.start = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_Lvl.numFmt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvlRestart")
				{
					ct_Lvl.lvlRestart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pStyle")
				{
					ct_Lvl.pStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "isLgl")
				{
					ct_Lvl.isLgl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suff")
				{
					ct_Lvl.suff = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvlText")
				{
					ct_Lvl.lvlText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvlPicBulletId")
				{
					ct_Lvl.lvlPicBulletId = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacy")
				{
					ct_Lvl.legacy = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvlJc")
				{
					ct_Lvl.lvlJc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pPr")
				{
					ct_Lvl.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPr")
				{
					ct_Lvl.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Lvl;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000EA24 File Offset: 0x0000CC24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:ilvl", this.ilvl);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tplc", this.tplc);
			if (this.tentative != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off || this.tentativeFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tentative", this.tentative.ToString());
			}
			sw.Write(">");
			if (this.start != null)
			{
				this.start.Write(sw, "start");
			}
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
			}
			if (this.lvlRestart != null)
			{
				this.lvlRestart.Write(sw, "lvlRestart");
			}
			if (this.pStyle != null)
			{
				this.pStyle.Write(sw, "pStyle");
			}
			if (this.isLgl != null)
			{
				this.isLgl.Write(sw, "isLgl");
			}
			if (this.suff != null)
			{
				this.suff.Write(sw, "suff");
			}
			if (this.lvlText != null)
			{
				this.lvlText.Write(sw, "lvlText");
			}
			if (this.lvlPicBulletId != null)
			{
				this.lvlPicBulletId.Write(sw, "lvlPicBulletId");
			}
			if (this.legacy != null)
			{
				this.legacy.Write(sw, "legacy");
			}
			if (this.lvlJc != null)
			{
				this.lvlJc.Write(sw, "lvlJc");
			}
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000EBDB File Offset: 0x0000CDDB
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0000EBE3 File Offset: 0x0000CDE3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt numFmt
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000EBFD File Offset: 0x0000CDFD
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0000EC05 File Offset: 0x0000CE05
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber lvlRestart
		{
			get
			{
				return this.lvlRestartField;
			}
			set
			{
				this.lvlRestartField = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000EC0E File Offset: 0x0000CE0E
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x0000EC16 File Offset: 0x0000CE16
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String pStyle
		{
			get
			{
				return this.pStyleField;
			}
			set
			{
				this.pStyleField = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000EC1F File Offset: 0x0000CE1F
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0000EC27 File Offset: 0x0000CE27
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff isLgl
		{
			get
			{
				return this.isLglField;
			}
			set
			{
				this.isLglField = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0000EC30 File Offset: 0x0000CE30
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000EC38 File Offset: 0x0000CE38
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix suff
		{
			get
			{
				return this.suffField;
			}
			set
			{
				this.suffField = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000EC41 File Offset: 0x0000CE41
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000EC49 File Offset: 0x0000CE49
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText lvlText
		{
			get
			{
				return this.lvlTextField;
			}
			set
			{
				this.lvlTextField = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000EC52 File Offset: 0x0000CE52
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0000EC5A File Offset: 0x0000CE5A
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber lvlPicBulletId
		{
			get
			{
				return this.lvlPicBulletIdField;
			}
			set
			{
				this.lvlPicBulletIdField = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000EC63 File Offset: 0x0000CE63
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000EC6B File Offset: 0x0000CE6B
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy legacy
		{
			get
			{
				return this.legacyField;
			}
			set
			{
				this.legacyField = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0000EC74 File Offset: 0x0000CE74
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc lvlJc
		{
			get
			{
				return this.lvlJcField;
			}
			set
			{
				this.lvlJcField = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000EC85 File Offset: 0x0000CE85
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0000EC8D File Offset: 0x0000CE8D
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0000EC96 File Offset: 0x0000CE96
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0000EC9E File Offset: 0x0000CE9E
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000ECA7 File Offset: 0x0000CEA7
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0000ECAF File Offset: 0x0000CEAF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string ilvl
		{
			get
			{
				return this.ilvlField;
			}
			set
			{
				this.ilvlField = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] tplc
		{
			get
			{
				return this.tplcField;
			}
			set
			{
				this.tplcField = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0000ECD1 File Offset: 0x0000CED1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff tentative
		{
			get
			{
				return this.tentativeField;
			}
			set
			{
				this.tentativeField = value;
				this.tentativeFieldSpecified = true;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000ECE1 File Offset: 0x0000CEE1
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0000ECE9 File Offset: 0x0000CEE9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tentativeSpecified
		{
			get
			{
				return this.tentativeFieldSpecified;
			}
			set
			{
				this.tentativeFieldSpecified = value;
			}
		}

		// Token: 0x0400047F RID: 1151
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber startField;

		// Token: 0x04000480 RID: 1152
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt numFmtField;

		// Token: 0x04000481 RID: 1153
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber lvlRestartField;

		// Token: 0x04000482 RID: 1154
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String pStyleField;

		// Token: 0x04000483 RID: 1155
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff isLglField;

		// Token: 0x04000484 RID: 1156
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix suffField;

		// Token: 0x04000485 RID: 1157
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelText lvlTextField;

		// Token: 0x04000486 RID: 1158
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber lvlPicBulletIdField;

		// Token: 0x04000487 RID: 1159
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy legacyField;

		// Token: 0x04000488 RID: 1160
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc lvlJcField;

		// Token: 0x04000489 RID: 1161
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPrField;

		// Token: 0x0400048A RID: 1162
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;

		// Token: 0x0400048B RID: 1163
		private string ilvlField;

		// Token: 0x0400048C RID: 1164
		private byte[] tplcField;

		// Token: 0x0400048D RID: 1165
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff tentativeField;

		// Token: 0x0400048E RID: 1166
		private bool tentativeFieldSpecified;
	}
}
