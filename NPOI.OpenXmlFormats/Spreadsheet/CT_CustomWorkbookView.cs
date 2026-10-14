using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200051F RID: 1311
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomWorkbookView
	{
		// Token: 0x06003987 RID: 14727 RVA: 0x0008EEE8 File Offset: 0x0008D0E8
		public CT_CustomWorkbookView()
		{
			this.autoUpdateField = false;
			this.changesSavedWinField = false;
			this.onlySyncField = false;
			this.personalViewField = false;
			this.includePrintSettingsField = true;
			this.includeHiddenRowColField = true;
			this.maximizedField = false;
			this.minimizedField = false;
			this.showHorizontalScrollField = true;
			this.showVerticalScrollField = true;
			this.showSheetTabsField = true;
			this.xWindowField = 0;
			this.yWindowField = 0;
			this.tabRatioField = 600U;
			this.showFormulaBarField = true;
			this.showStatusbarField = true;
			this.showCommentsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments.commIndicator;
			this.showObjectsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects.all;
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0008EF80 File Offset: 0x0008D180
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView ct_CustomWorkbookView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookView();
			ct_CustomWorkbookView.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_CustomWorkbookView.guid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["guid"]);
			ct_CustomWorkbookView.autoUpdate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoUpdate"]);
			ct_CustomWorkbookView.mergeInterval = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["mergeInterval"]);
			ct_CustomWorkbookView.mergeIntervalSpecified = (node.Attributes["mergeInterval"] != null);
			ct_CustomWorkbookView.changesSavedWin = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["changesSavedWin"]);
			ct_CustomWorkbookView.onlySync = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["onlySync"]);
			ct_CustomWorkbookView.personalView = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["personalView"]);
			ct_CustomWorkbookView.includePrintSettings = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["includePrintSettings"]);
			ct_CustomWorkbookView.includeHiddenRowCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["includeHiddenRowCol"]);
			ct_CustomWorkbookView.maximized = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["maximized"]);
			ct_CustomWorkbookView.minimized = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["minimized"]);
			ct_CustomWorkbookView.showHorizontalScroll = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showHorizontalScroll"]);
			ct_CustomWorkbookView.showVerticalScroll = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showVerticalScroll"]);
			ct_CustomWorkbookView.showSheetTabs = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showSheetTabs"]);
			ct_CustomWorkbookView.xWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["xWindow"]);
			ct_CustomWorkbookView.yWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["yWindow"]);
			ct_CustomWorkbookView.windowWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["windowWidth"]);
			ct_CustomWorkbookView.windowHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["windowHeight"]);
			ct_CustomWorkbookView.tabRatio = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["tabRatio"]);
			ct_CustomWorkbookView.activeSheetId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["activeSheetId"]);
			ct_CustomWorkbookView.showFormulaBar = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showFormulaBar"]);
			ct_CustomWorkbookView.showStatusbar = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showStatusbar"]);
			if (node.Attributes["showComments"] != null)
			{
				ct_CustomWorkbookView.showComments = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments), node.Attributes["showComments"].Value);
			}
			if (node.Attributes["showObjects"] != null)
			{
				ct_CustomWorkbookView.showObjects = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects), node.Attributes["showObjects"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_CustomWorkbookView.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CustomWorkbookView;
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0008F2EC File Offset: 0x0008D4EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "guid", this.guid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoUpdate", this.autoUpdate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mergeInterval", this.mergeInterval, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "changesSavedWin", this.changesSavedWin);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "onlySync", this.onlySync);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "personalView", this.personalView);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "includePrintSettings", this.includePrintSettings);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "includeHiddenRowCol", this.includeHiddenRowCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maximized", this.maximized);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minimized", this.minimized);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showHorizontalScroll", this.showHorizontalScroll);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showVerticalScroll", this.showVerticalScroll);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showSheetTabs", this.showSheetTabs);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xWindow", this.xWindow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "yWindow", this.yWindow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "windowWidth", this.windowWidth, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "windowHeight", this.windowHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tabRatio", this.tabRatio, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeSheetId", this.activeSheetId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showFormulaBar", this.showFormulaBar);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showStatusbar", this.showStatusbar);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showComments", this.showComments.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showObjects", this.showObjects.ToString());
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
		// (set) Token: 0x0600398B RID: 14731 RVA: 0x0008F500 File Offset: 0x0008D700
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

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x0008F509 File Offset: 0x0008D709
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x0008F511 File Offset: 0x0008D711
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
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

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x0008F51A File Offset: 0x0008D71A
		// (set) Token: 0x0600398F RID: 14735 RVA: 0x0008F522 File Offset: 0x0008D722
		[global::System.Xml.Serialization.XmlAttribute]
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x0008F52B File Offset: 0x0008D72B
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x0008F533 File Offset: 0x0008D733
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool autoUpdate
		{
			get
			{
				return this.autoUpdateField;
			}
			set
			{
				this.autoUpdateField = value;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x0008F53C File Offset: 0x0008D73C
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x0008F544 File Offset: 0x0008D744
		[global::System.Xml.Serialization.XmlAttribute]
		public uint mergeInterval
		{
			get
			{
				return this.mergeIntervalField;
			}
			set
			{
				this.mergeIntervalField = value;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0008F54D File Offset: 0x0008D74D
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x0008F555 File Offset: 0x0008D755
		[global::System.Xml.Serialization.XmlIgnore]
		public bool mergeIntervalSpecified
		{
			get
			{
				return this.mergeIntervalFieldSpecified;
			}
			set
			{
				this.mergeIntervalFieldSpecified = value;
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x0008F55E File Offset: 0x0008D75E
		// (set) Token: 0x06003997 RID: 14743 RVA: 0x0008F566 File Offset: 0x0008D766
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool changesSavedWin
		{
			get
			{
				return this.changesSavedWinField;
			}
			set
			{
				this.changesSavedWinField = value;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x0008F56F File Offset: 0x0008D76F
		// (set) Token: 0x06003999 RID: 14745 RVA: 0x0008F577 File Offset: 0x0008D777
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool onlySync
		{
			get
			{
				return this.onlySyncField;
			}
			set
			{
				this.onlySyncField = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x0008F580 File Offset: 0x0008D780
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x0008F588 File Offset: 0x0008D788
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool personalView
		{
			get
			{
				return this.personalViewField;
			}
			set
			{
				this.personalViewField = value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0008F591 File Offset: 0x0008D791
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x0008F599 File Offset: 0x0008D799
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool includePrintSettings
		{
			get
			{
				return this.includePrintSettingsField;
			}
			set
			{
				this.includePrintSettingsField = value;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0008F5A2 File Offset: 0x0008D7A2
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x0008F5AA File Offset: 0x0008D7AA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool includeHiddenRowCol
		{
			get
			{
				return this.includeHiddenRowColField;
			}
			set
			{
				this.includeHiddenRowColField = value;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x0008F5B3 File Offset: 0x0008D7B3
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x0008F5BB File Offset: 0x0008D7BB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool maximized
		{
			get
			{
				return this.maximizedField;
			}
			set
			{
				this.maximizedField = value;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x060039A2 RID: 14754 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
		// (set) Token: 0x060039A3 RID: 14755 RVA: 0x0008F5CC File Offset: 0x0008D7CC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool minimized
		{
			get
			{
				return this.minimizedField;
			}
			set
			{
				this.minimizedField = value;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x0008F5D5 File Offset: 0x0008D7D5
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x0008F5DD File Offset: 0x0008D7DD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showHorizontalScroll
		{
			get
			{
				return this.showHorizontalScrollField;
			}
			set
			{
				this.showHorizontalScrollField = value;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x0008F5E6 File Offset: 0x0008D7E6
		// (set) Token: 0x060039A7 RID: 14759 RVA: 0x0008F5EE File Offset: 0x0008D7EE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showVerticalScroll
		{
			get
			{
				return this.showVerticalScrollField;
			}
			set
			{
				this.showVerticalScrollField = value;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0008F5F7 File Offset: 0x0008D7F7
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x0008F5FF File Offset: 0x0008D7FF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showSheetTabs
		{
			get
			{
				return this.showSheetTabsField;
			}
			set
			{
				this.showSheetTabsField = value;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x0008F608 File Offset: 0x0008D808
		// (set) Token: 0x060039AB RID: 14763 RVA: 0x0008F610 File Offset: 0x0008D810
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int xWindow
		{
			get
			{
				return this.xWindowField;
			}
			set
			{
				this.xWindowField = value;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x0008F619 File Offset: 0x0008D819
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x0008F621 File Offset: 0x0008D821
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int yWindow
		{
			get
			{
				return this.yWindowField;
			}
			set
			{
				this.yWindowField = value;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x0008F62A File Offset: 0x0008D82A
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x0008F632 File Offset: 0x0008D832
		[global::System.Xml.Serialization.XmlAttribute]
		public uint windowWidth
		{
			get
			{
				return this.windowWidthField;
			}
			set
			{
				this.windowWidthField = value;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x0008F63B File Offset: 0x0008D83B
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0008F643 File Offset: 0x0008D843
		[global::System.Xml.Serialization.XmlAttribute]
		public uint windowHeight
		{
			get
			{
				return this.windowHeightField;
			}
			set
			{
				this.windowHeightField = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x0008F64C File Offset: 0x0008D84C
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x0008F654 File Offset: 0x0008D854
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "600")]
		public uint tabRatio
		{
			get
			{
				return this.tabRatioField;
			}
			set
			{
				this.tabRatioField = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x0008F65D File Offset: 0x0008D85D
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x0008F665 File Offset: 0x0008D865
		[global::System.Xml.Serialization.XmlAttribute]
		public uint activeSheetId
		{
			get
			{
				return this.activeSheetIdField;
			}
			set
			{
				this.activeSheetIdField = value;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x0008F66E File Offset: 0x0008D86E
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x0008F676 File Offset: 0x0008D876
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showFormulaBar
		{
			get
			{
				return this.showFormulaBarField;
			}
			set
			{
				this.showFormulaBarField = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x0008F67F File Offset: 0x0008D87F
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x0008F687 File Offset: 0x0008D887
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showStatusbar
		{
			get
			{
				return this.showStatusbarField;
			}
			set
			{
				this.showStatusbarField = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x0008F690 File Offset: 0x0008D890
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x0008F698 File Offset: 0x0008D898
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments.commIndicator)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments showComments
		{
			get
			{
				return this.showCommentsField;
			}
			set
			{
				this.showCommentsField = value;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0008F6A1 File Offset: 0x0008D8A1
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x0008F6A9 File Offset: 0x0008D8A9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects.all)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects showObjects
		{
			get
			{
				return this.showObjectsField;
			}
			set
			{
				this.showObjectsField = value;
			}
		}

		// Token: 0x040024D4 RID: 9428
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040024D5 RID: 9429
		private string nameField;

		// Token: 0x040024D6 RID: 9430
		private string guidField;

		// Token: 0x040024D7 RID: 9431
		private bool autoUpdateField;

		// Token: 0x040024D8 RID: 9432
		private uint mergeIntervalField;

		// Token: 0x040024D9 RID: 9433
		private bool mergeIntervalFieldSpecified;

		// Token: 0x040024DA RID: 9434
		private bool changesSavedWinField;

		// Token: 0x040024DB RID: 9435
		private bool onlySyncField;

		// Token: 0x040024DC RID: 9436
		private bool personalViewField;

		// Token: 0x040024DD RID: 9437
		private bool includePrintSettingsField;

		// Token: 0x040024DE RID: 9438
		private bool includeHiddenRowColField;

		// Token: 0x040024DF RID: 9439
		private bool maximizedField;

		// Token: 0x040024E0 RID: 9440
		private bool minimizedField;

		// Token: 0x040024E1 RID: 9441
		private bool showHorizontalScrollField;

		// Token: 0x040024E2 RID: 9442
		private bool showVerticalScrollField;

		// Token: 0x040024E3 RID: 9443
		private bool showSheetTabsField;

		// Token: 0x040024E4 RID: 9444
		private int xWindowField;

		// Token: 0x040024E5 RID: 9445
		private int yWindowField;

		// Token: 0x040024E6 RID: 9446
		private uint windowWidthField;

		// Token: 0x040024E7 RID: 9447
		private uint windowHeightField;

		// Token: 0x040024E8 RID: 9448
		private uint tabRatioField;

		// Token: 0x040024E9 RID: 9449
		private uint activeSheetIdField;

		// Token: 0x040024EA RID: 9450
		private bool showFormulaBarField;

		// Token: 0x040024EB RID: 9451
		private bool showStatusbarField;

		// Token: 0x040024EC RID: 9452
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Comments showCommentsField;

		// Token: 0x040024ED RID: 9453
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Objects showObjectsField;
	}
}
