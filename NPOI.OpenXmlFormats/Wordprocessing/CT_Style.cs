using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200014A RID: 330
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Style
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x00020214 File Offset: 0x0001E414
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style ct_Style = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style();
			if (node.Attributes["w:type"] != null)
			{
				ct_Style.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_StyleType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_StyleType), node.Attributes["w:type"].Value);
			}
			ct_Style.styleId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:styleId"]);
			if (node.Attributes["w:default"] != null)
			{
				ct_Style.@default = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:default"].Value, true);
			}
			if (node.Attributes["w:customStyle"] != null)
			{
				ct_Style.customStyle = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:customStyle"].Value, true);
			}
			ct_Style.tblStylePr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "name")
				{
					ct_Style.name = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "aliases")
				{
					ct_Style.aliases = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "basedOn")
				{
					ct_Style.basedOn = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "next")
				{
					ct_Style.next = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "link")
				{
					ct_Style.link = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoRedefine")
				{
					ct_Style.autoRedefine = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hidden")
				{
					ct_Style.hidden = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "uiPriority")
				{
					ct_Style.uiPriority = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "semiHidden")
				{
					ct_Style.semiHidden = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "unhideWhenUsed")
				{
					ct_Style.unhideWhenUsed = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "qFormat")
				{
					ct_Style.qFormat = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "locked")
				{
					ct_Style.locked = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "personal")
				{
					ct_Style.personal = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "personalCompose")
				{
					ct_Style.personalCompose = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "personalReply")
				{
					ct_Style.personalReply = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rsid")
				{
					ct_Style.rsid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pPr")
				{
					ct_Style.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPr")
				{
					ct_Style.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblPr")
				{
					ct_Style.tblPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trPr")
				{
					ct_Style.trPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcPr")
				{
					ct_Style.tcPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStylePr")
				{
					ct_Style.tblStylePr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Style;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00020680 File Offset: 0x0001E880
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			if (this.@default != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:default", "1");
			}
			if (this.customStyle == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:customStyle", "1");
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:styleId", this.styleId);
			sw.Write(">");
			if (this.name != null)
			{
				this.name.Write(sw, "name");
			}
			if (this.aliases != null)
			{
				this.aliases.Write(sw, "aliases");
			}
			if (this.basedOn != null)
			{
				this.basedOn.Write(sw, "basedOn");
			}
			if (this.next != null)
			{
				this.next.Write(sw, "next");
			}
			if (this.link != null)
			{
				this.link.Write(sw, "link");
			}
			if (this.autoRedefine != null)
			{
				this.autoRedefine.Write(sw, "autoRedefine");
			}
			if (this.hidden != null)
			{
				this.hidden.Write(sw, "hidden");
			}
			if (this.uiPriority != null)
			{
				this.uiPriority.Write(sw, "uiPriority");
			}
			if (this.semiHidden != null)
			{
				this.semiHidden.Write(sw, "semiHidden");
			}
			if (this.unhideWhenUsed != null)
			{
				this.unhideWhenUsed.Write(sw, "unhideWhenUsed");
			}
			if (this.qFormat != null)
			{
				this.qFormat.Write(sw, "qFormat");
			}
			if (this.locked != null)
			{
				this.locked.Write(sw, "locked");
			}
			if (this.personal != null)
			{
				this.personal.Write(sw, "personal");
			}
			if (this.personalCompose != null)
			{
				this.personalCompose.Write(sw, "personalCompose");
			}
			if (this.personalReply != null)
			{
				this.personalReply.Write(sw, "personalReply");
			}
			if (this.rsid != null)
			{
				this.rsid.Write(sw, "rsid");
			}
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.tblPr != null)
			{
				this.tblPr.Write(sw, "tblPr");
			}
			if (this.trPr != null)
			{
				this.trPr.Write(sw, "trPr");
			}
			if (this.tcPr != null)
			{
				this.tcPr.Write(sw, "tcPr");
			}
			if (this.tblStylePr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr ct_TblStylePr in this.tblStylePr)
				{
					ct_TblStylePr.Write(sw, "tblStylePr");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002097C File Offset: 0x0001EB7C
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00020984 File Offset: 0x0001EB84
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002098D File Offset: 0x0001EB8D
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00020995 File Offset: 0x0001EB95
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String aliases
		{
			get
			{
				return this.aliasesField;
			}
			set
			{
				this.aliasesField = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0002099E File Offset: 0x0001EB9E
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000209A6 File Offset: 0x0001EBA6
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String basedOn
		{
			get
			{
				return this.basedOnField;
			}
			set
			{
				this.basedOnField = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000209AF File Offset: 0x0001EBAF
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000209B7 File Offset: 0x0001EBB7
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String next
		{
			get
			{
				return this.nextField;
			}
			set
			{
				this.nextField = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x000209C0 File Offset: 0x0001EBC0
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000209C8 File Offset: 0x0001EBC8
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000209D1 File Offset: 0x0001EBD1
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x000209D9 File Offset: 0x0001EBD9
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoRedefine
		{
			get
			{
				return this.autoRedefineField;
			}
			set
			{
				this.autoRedefineField = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000209E2 File Offset: 0x0001EBE2
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x000209EA File Offset: 0x0001EBEA
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000209F3 File Offset: 0x0001EBF3
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x000209FB File Offset: 0x0001EBFB
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber uiPriority
		{
			get
			{
				return this.uiPriorityField;
			}
			set
			{
				this.uiPriorityField = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00020A04 File Offset: 0x0001EC04
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00020A0C File Offset: 0x0001EC0C
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff semiHidden
		{
			get
			{
				return this.semiHiddenField;
			}
			set
			{
				this.semiHiddenField = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00020A15 File Offset: 0x0001EC15
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00020A1D File Offset: 0x0001EC1D
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff unhideWhenUsed
		{
			get
			{
				return this.unhideWhenUsedField;
			}
			set
			{
				this.unhideWhenUsedField = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00020A26 File Offset: 0x0001EC26
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00020A2E File Offset: 0x0001EC2E
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff qFormat
		{
			get
			{
				return this.qFormatField;
			}
			set
			{
				this.qFormatField = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00020A37 File Offset: 0x0001EC37
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00020A3F File Offset: 0x0001EC3F
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff locked
		{
			get
			{
				return this.lockedField;
			}
			set
			{
				this.lockedField = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00020A48 File Offset: 0x0001EC48
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00020A50 File Offset: 0x0001EC50
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personal
		{
			get
			{
				return this.personalField;
			}
			set
			{
				this.personalField = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00020A59 File Offset: 0x0001EC59
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00020A61 File Offset: 0x0001EC61
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personalCompose
		{
			get
			{
				return this.personalComposeField;
			}
			set
			{
				this.personalComposeField = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00020A6A File Offset: 0x0001EC6A
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00020A72 File Offset: 0x0001EC72
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personalReply
		{
			get
			{
				return this.personalReplyField;
			}
			set
			{
				this.personalReplyField = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00020A7B File Offset: 0x0001EC7B
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00020A83 File Offset: 0x0001EC83
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber rsid
		{
			get
			{
				return this.rsidField;
			}
			set
			{
				this.rsidField = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00020A8C File Offset: 0x0001EC8C
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00020A94 File Offset: 0x0001EC94
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
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

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00020A9D File Offset: 0x0001EC9D
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00020AA5 File Offset: 0x0001ECA5
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00020AAE File Offset: 0x0001ECAE
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00020AB6 File Offset: 0x0001ECB6
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase tblPr
		{
			get
			{
				return this.tblPrField;
			}
			set
			{
				this.tblPrField = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00020ABF File Offset: 0x0001ECBF
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00020AC7 File Offset: 0x0001ECC7
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr
		{
			get
			{
				return this.trPrField;
			}
			set
			{
				this.trPrField = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00020AD0 File Offset: 0x0001ECD0
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPr
		{
			get
			{
				return this.tcPrField;
			}
			set
			{
				this.tcPrField = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00020AE1 File Offset: 0x0001ECE1
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00020AE9 File Offset: 0x0001ECE9
		[global::System.Xml.Serialization.XmlElement("tblStylePr", Order = 21)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr> tblStylePr
		{
			get
			{
				return this.tblStylePrField;
			}
			set
			{
				this.tblStylePrField = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00020AF2 File Offset: 0x0001ECF2
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00020AFA File Offset: 0x0001ECFA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_StyleType type
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00020B03 File Offset: 0x0001ED03
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00020B0B File Offset: 0x0001ED0B
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00020B14 File Offset: 0x0001ED14
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00020B1C File Offset: 0x0001ED1C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string styleId
		{
			get
			{
				return this.styleIdField;
			}
			set
			{
				this.styleIdField = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00020B25 File Offset: 0x0001ED25
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00020B2D File Offset: 0x0001ED2D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff @default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00020B36 File Offset: 0x0001ED36
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00020B3E File Offset: 0x0001ED3E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defaultSpecified
		{
			get
			{
				return this.defaultFieldSpecified;
			}
			set
			{
				this.defaultFieldSpecified = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00020B47 File Offset: 0x0001ED47
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00020B4F File Offset: 0x0001ED4F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff customStyle
		{
			get
			{
				return this.customStyleField;
			}
			set
			{
				this.customStyleField = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00020B58 File Offset: 0x0001ED58
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00020B60 File Offset: 0x0001ED60
		[global::System.Xml.Serialization.XmlIgnore]
		public bool customStyleSpecified
		{
			get
			{
				return this.customStyleFieldSpecified;
			}
			set
			{
				this.customStyleFieldSpecified = value;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00020B69 File Offset: 0x0001ED69
		public bool IsSetName()
		{
			return this.name != null;
		}

		// Token: 0x04000834 RID: 2100
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nameField;

		// Token: 0x04000835 RID: 2101
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String aliasesField;

		// Token: 0x04000836 RID: 2102
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String basedOnField;

		// Token: 0x04000837 RID: 2103
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nextField;

		// Token: 0x04000838 RID: 2104
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String linkField;

		// Token: 0x04000839 RID: 2105
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoRedefineField;

		// Token: 0x0400083A RID: 2106
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hiddenField;

		// Token: 0x0400083B RID: 2107
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber uiPriorityField;

		// Token: 0x0400083C RID: 2108
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff semiHiddenField;

		// Token: 0x0400083D RID: 2109
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff unhideWhenUsedField;

		// Token: 0x0400083E RID: 2110
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff qFormatField;

		// Token: 0x0400083F RID: 2111
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff lockedField;

		// Token: 0x04000840 RID: 2112
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personalField;

		// Token: 0x04000841 RID: 2113
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personalComposeField;

		// Token: 0x04000842 RID: 2114
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff personalReplyField;

		// Token: 0x04000843 RID: 2115
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber rsidField;

		// Token: 0x04000844 RID: 2116
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPrField;

		// Token: 0x04000845 RID: 2117
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;

		// Token: 0x04000846 RID: 2118
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase tblPrField;

		// Token: 0x04000847 RID: 2119
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPrField;

		// Token: 0x04000848 RID: 2120
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPrField;

		// Token: 0x04000849 RID: 2121
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblStylePr> tblStylePrField;

		// Token: 0x0400084A RID: 2122
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_StyleType typeField;

		// Token: 0x0400084B RID: 2123
		private bool typeFieldSpecified;

		// Token: 0x0400084C RID: 2124
		private string styleIdField;

		// Token: 0x0400084D RID: 2125
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defaultField;

		// Token: 0x0400084E RID: 2126
		private bool defaultFieldSpecified;

		// Token: 0x0400084F RID: 2127
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff customStyleField;

		// Token: 0x04000850 RID: 2128
		private bool customStyleFieldSpecified;
	}
}
