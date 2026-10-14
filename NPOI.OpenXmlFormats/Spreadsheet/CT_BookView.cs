using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200051D RID: 1309
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_BookView
	{
		// Token: 0x06003958 RID: 14680 RVA: 0x0008E83C File Offset: 0x0008CA3C
		public CT_BookView()
		{
			this.visibilityField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility.visible;
			this.minimizedField = false;
			this.showHorizontalScrollField = true;
			this.showVerticalScrollField = true;
			this.showSheetTabsField = true;
			this.tabRatioField = 600U;
			this.firstSheetField = 0U;
			this.activeTabField = 0U;
			this.autoFilterDateGroupingField = true;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0008E894 File Offset: 0x0008CA94
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView ct_BookView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView();
			if (node.Attributes["visibility"] != null)
			{
				ct_BookView.visibility = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility), node.Attributes["visibility"].Value);
			}
			ct_BookView.minimized = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["minimized"]);
			ct_BookView.showHorizontalScroll = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showHorizontalScroll"], true);
			ct_BookView.showVerticalScroll = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showVerticalScroll"], true);
			ct_BookView.showSheetTabs = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showSheetTabs"], true);
			ct_BookView.xWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["xWindow"]);
			ct_BookView.yWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["yWindow"]);
			ct_BookView.windowWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["windowWidth"]);
			ct_BookView.windowHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["windowHeight"]);
			ct_BookView.tabRatio = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["tabRatio"]);
			ct_BookView.firstSheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstSheet"]);
			ct_BookView.activeTab = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["activeTab"]);
			ct_BookView.autoFilterDateGrouping = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoFilterDateGrouping"], true);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_BookView.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BookView;
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0008EA9C File Offset: 0x0008CC9C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.visibility != global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility.visible)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "visibility", this.visibility.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minimized", this.minimized, false);
			if (!this.showHorizontalScroll)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showHorizontalScroll", this.showHorizontalScroll);
			}
			if (!this.showVerticalScroll)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showVerticalScroll", this.showVerticalScroll);
			}
			if (!this.showSheetTabs)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showSheetTabs", this.showSheetTabs);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xWindow", this.xWindow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "yWindow", this.yWindow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "windowWidth", this.windowWidth, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "windowHeight", this.windowHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tabRatio", this.tabRatio, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstSheet", this.firstSheet, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeTab", this.activeTab, false);
			if (!this.autoFilterDateGrouping)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoFilterDateGrouping", this.autoFilterDateGrouping);
			}
			if (this.extLst != null)
			{
				sw.Write(">");
				this.extLst.Write(sw, "extLst");
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x0008EC14 File Offset: 0x0008CE14
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x0008EC1C File Offset: 0x0008CE1C
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

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0008EC25 File Offset: 0x0008CE25
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extLstSpecified
		{
			get
			{
				return this.extLstField != null;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x0008EC30 File Offset: 0x0008CE30
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x0008EC38 File Offset: 0x0008CE38
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility.visible)]
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility visibility
		{
			get
			{
				return this.visibilityField;
			}
			set
			{
				this.visibilityField = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x0008EC41 File Offset: 0x0008CE41
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x0008EC49 File Offset: 0x0008CE49
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x0008EC52 File Offset: 0x0008CE52
		// (set) Token: 0x06003963 RID: 14691 RVA: 0x0008EC5A File Offset: 0x0008CE5A
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x0008EC63 File Offset: 0x0008CE63
		// (set) Token: 0x06003965 RID: 14693 RVA: 0x0008EC6B File Offset: 0x0008CE6B
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x0008EC74 File Offset: 0x0008CE74
		// (set) Token: 0x06003967 RID: 14695 RVA: 0x0008EC7C File Offset: 0x0008CE7C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x0008EC85 File Offset: 0x0008CE85
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x0008EC8D File Offset: 0x0008CE8D
		[global::System.Xml.Serialization.XmlAttribute]
		public int xWindow
		{
			get
			{
				return this.xWindowField;
			}
			set
			{
				this.xWindowField = value;
				this.xWindowFieldSpecified = true;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x0008EC9D File Offset: 0x0008CE9D
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x0008ECA5 File Offset: 0x0008CEA5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xWindowSpecified
		{
			get
			{
				return this.xWindowFieldSpecified;
			}
			set
			{
				this.xWindowFieldSpecified = value;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x0600396C RID: 14700 RVA: 0x0008ECAE File Offset: 0x0008CEAE
		// (set) Token: 0x0600396D RID: 14701 RVA: 0x0008ECB6 File Offset: 0x0008CEB6
		[global::System.Xml.Serialization.XmlAttribute]
		public int yWindow
		{
			get
			{
				return this.yWindowField;
			}
			set
			{
				this.yWindowField = value;
				this.yWindowFieldSpecified = true;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x0008ECC6 File Offset: 0x0008CEC6
		// (set) Token: 0x0600396F RID: 14703 RVA: 0x0008ECCE File Offset: 0x0008CECE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool yWindowSpecified
		{
			get
			{
				return this.yWindowFieldSpecified;
			}
			set
			{
				this.yWindowFieldSpecified = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x0008ECD7 File Offset: 0x0008CED7
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x0008ECDF File Offset: 0x0008CEDF
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
				this.windowWidthFieldSpecified = true;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x0008ECEF File Offset: 0x0008CEEF
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x0008ECF7 File Offset: 0x0008CEF7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool windowWidthSpecified
		{
			get
			{
				return this.windowWidthFieldSpecified;
			}
			set
			{
				this.windowWidthFieldSpecified = value;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x0008ED00 File Offset: 0x0008CF00
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x0008ED08 File Offset: 0x0008CF08
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
				this.windowHeightFieldSpecified = true;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x0008ED18 File Offset: 0x0008CF18
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x0008ED20 File Offset: 0x0008CF20
		[global::System.Xml.Serialization.XmlIgnore]
		public bool windowHeightSpecified
		{
			get
			{
				return this.windowHeightFieldSpecified;
			}
			set
			{
				this.windowHeightFieldSpecified = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x0008ED29 File Offset: 0x0008CF29
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x0008ED31 File Offset: 0x0008CF31
		[global::System.ComponentModel.DefaultValue(typeof(uint), "600")]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x0008ED3A File Offset: 0x0008CF3A
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x0008ED42 File Offset: 0x0008CF42
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		[global::System.Xml.Serialization.XmlAttribute]
		public uint firstSheet
		{
			get
			{
				return this.firstSheetField;
			}
			set
			{
				this.firstSheetField = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x0008ED4B File Offset: 0x0008CF4B
		// (set) Token: 0x0600397D RID: 14717 RVA: 0x0008ED53 File Offset: 0x0008CF53
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		[global::System.Xml.Serialization.XmlAttribute]
		public uint activeTab
		{
			get
			{
				return this.activeTabField;
			}
			set
			{
				this.activeTabField = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x0008ED5C File Offset: 0x0008CF5C
		// (set) Token: 0x0600397F RID: 14719 RVA: 0x0008ED64 File Offset: 0x0008CF64
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool autoFilterDateGrouping
		{
			get
			{
				return this.autoFilterDateGroupingField;
			}
			set
			{
				this.autoFilterDateGroupingField = value;
			}
		}

		// Token: 0x040024C1 RID: 9409
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040024C2 RID: 9410
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Visibility visibilityField;

		// Token: 0x040024C3 RID: 9411
		private bool minimizedField;

		// Token: 0x040024C4 RID: 9412
		private bool showHorizontalScrollField;

		// Token: 0x040024C5 RID: 9413
		private bool showVerticalScrollField;

		// Token: 0x040024C6 RID: 9414
		private bool showSheetTabsField;

		// Token: 0x040024C7 RID: 9415
		private int xWindowField;

		// Token: 0x040024C8 RID: 9416
		private bool xWindowFieldSpecified;

		// Token: 0x040024C9 RID: 9417
		private int yWindowField;

		// Token: 0x040024CA RID: 9418
		private bool yWindowFieldSpecified;

		// Token: 0x040024CB RID: 9419
		private uint windowWidthField;

		// Token: 0x040024CC RID: 9420
		private bool windowWidthFieldSpecified;

		// Token: 0x040024CD RID: 9421
		private uint windowHeightField;

		// Token: 0x040024CE RID: 9422
		private bool windowHeightFieldSpecified;

		// Token: 0x040024CF RID: 9423
		private uint tabRatioField;

		// Token: 0x040024D0 RID: 9424
		private uint firstSheetField;

		// Token: 0x040024D1 RID: 9425
		private uint activeTabField;

		// Token: 0x040024D2 RID: 9426
		private bool autoFilterDateGroupingField;
	}
}
