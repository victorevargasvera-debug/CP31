using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200051A RID: 1306
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "workbook", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Workbook
	{
		// Token: 0x06003918 RID: 14616 RVA: 0x0008DED0 File Offset: 0x0008C0D0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook ct_Workbook = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook();
			ct_Workbook.fileRecoveryPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fileVersion")
				{
					ct_Workbook.fileVersion = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileVersion.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fileSharing")
				{
					ct_Workbook.fileSharing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileSharing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "workbookPr")
				{
					ct_Workbook.workbookPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "workbookProtection")
				{
					ct_Workbook.workbookProtection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookViews")
				{
					ct_Workbook.bookViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheets")
				{
					ct_Workbook.sheets = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "functionGroups")
				{
					ct_Workbook.functionGroups = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "externalReferences")
				{
					ct_Workbook.externalReferences = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "definedNames")
				{
					ct_Workbook.definedNames = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "calcPr")
				{
					ct_Workbook.calcPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oleSize")
				{
					ct_Workbook.oleSize = global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleSize.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "customWorkbookViews")
				{
					ct_Workbook.customWorkbookViews = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotCaches")
				{
					ct_Workbook.pivotCaches = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smartTagPr")
				{
					ct_Workbook.smartTagPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smartTagTypes")
				{
					ct_Workbook.smartTagTypes = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webPublishing")
				{
					ct_Workbook.webPublishing = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webPublishObjects")
				{
					ct_Workbook.webPublishObjects = global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Workbook.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fileRecoveryPr")
				{
					ct_Workbook.fileRecoveryPr.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Workbook;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0008E1F0 File Offset: 0x0008C3F0
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<workbook xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"");
			sw.Write(" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"x15 xr xr6 xr10 xr2\" xmlns:x15=\"http://schemas.microsoft.com/office/spreadsheetml/2010/11/main\" xmlns:xr=\"http://schemas.microsoft.com/office/spreadsheetml/2014/revision\"");
			sw.Write(" xmlns:xr6=\"http://schemas.microsoft.com/office/spreadsheetml/2016/revision6\" xmlns:xr10=\"http://schemas.microsoft.com/office/spreadsheetml/2016/revision10\" xmlns:xr2=\"http://schemas.microsoft.com/office/spreadsheetml/2015/revision2\"");
			sw.Write(">");
			if (this.fileVersion != null)
			{
				this.fileVersion.Write(sw, "fileVersion");
			}
			if (this.fileSharing != null)
			{
				this.fileSharing.Write(sw, "fileSharing");
			}
			if (this.workbookPr != null)
			{
				this.workbookPr.Write(sw, "workbookPr");
			}
			if (this.workbookProtection != null)
			{
				this.workbookProtection.Write(sw, "workbookProtection");
			}
			if (this.bookViews != null)
			{
				this.bookViews.Write(sw, "bookViews");
			}
			if (this.sheets != null)
			{
				this.sheets.Write(sw, "sheets");
			}
			if (this.functionGroups != null)
			{
				this.functionGroups.Write(sw, "functionGroups");
			}
			if (this.externalReferences != null)
			{
				this.externalReferences.Write(sw, "externalReferences");
			}
			if (this.definedNames != null)
			{
				this.definedNames.Write(sw, "definedNames");
			}
			if (this.calcPr != null)
			{
				this.calcPr.Write(sw, "calcPr");
			}
			if (this.oleSize != null)
			{
				this.oleSize.Write(sw, "oleSize");
			}
			if (this.customWorkbookViews != null)
			{
				this.customWorkbookViews.Write(sw, "customWorkbookViews");
			}
			if (this.pivotCaches != null)
			{
				this.pivotCaches.Write(sw, "pivotCaches");
			}
			if (this.smartTagPr != null)
			{
				this.smartTagPr.Write(sw, "smartTagPr");
			}
			if (this.smartTagTypes != null)
			{
				this.smartTagTypes.Write(sw, "smartTagTypes");
			}
			if (this.webPublishing != null)
			{
				this.webPublishing.Write(sw, "webPublishing");
			}
			if (this.webPublishObjects != null)
			{
				this.webPublishObjects.Write(sw, "webPublishObjects");
			}
			if (this.fileRecoveryPr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr ct_FileRecoveryPr in this.fileRecoveryPr)
				{
					ct_FileRecoveryPr.Write(sw, "fileRecoveryPr");
				}
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write("</workbook>");
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0008E454 File Offset: 0x0008C654
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr AddNewWorkbookPr()
		{
			this.workbookPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr();
			return this.workbookPrField;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0008E467 File Offset: 0x0008C667
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr AddNewCalcPr()
		{
			this.calcPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr();
			return this.calcPrField;
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x0008E47A File Offset: 0x0008C67A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets AddNewSheets()
		{
			this.sheetsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets();
			return this.sheetsField;
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0008E48D File Offset: 0x0008C68D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews AddNewBookViews()
		{
			this.bookViewsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews();
			return this.bookViewsField;
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0008E4A0 File Offset: 0x0008C6A0
		public bool IsSetWorkbookPr()
		{
			return this.workbookPrField != null;
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x0008E4AB File Offset: 0x0008C6AB
		public bool IsSetCalcPr()
		{
			return this.calcPrField != null;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0008E4B6 File Offset: 0x0008C6B6
		public bool IsSetSheets()
		{
			return this.sheetsField != null;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0008E4C1 File Offset: 0x0008C6C1
		public bool IsSetBookViews()
		{
			return this.bookViewsField != null;
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0008E4CC File Offset: 0x0008C6CC
		public bool IsSetExternalReferences()
		{
			return this.externalReferencesField != null;
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0008E4D7 File Offset: 0x0008C6D7
		public bool IsSetDefinedNames()
		{
			return this.definedNamesField != null;
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0008E4E2 File Offset: 0x0008C6E2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames AddNewDefinedNames()
		{
			this.definedNamesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames();
			return this.definedNamesField;
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0008E4F5 File Offset: 0x0008C6F5
		public void SetDefinedNames(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames definedNames)
		{
			this.definedNamesField = definedNames;
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0008E4FE File Offset: 0x0008C6FE
		public void unsetDefinedNames()
		{
			this.definedNamesField = null;
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0008E507 File Offset: 0x0008C707
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x0008E50F File Offset: 0x0008C70F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileVersion fileVersion
		{
			get
			{
				return this.fileVersionField;
			}
			set
			{
				this.fileVersionField = value;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x0008E518 File Offset: 0x0008C718
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x0008E520 File Offset: 0x0008C720
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileSharing fileSharing
		{
			get
			{
				return this.fileSharingField;
			}
			set
			{
				this.fileSharingField = value;
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0008E529 File Offset: 0x0008C729
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x0008E531 File Offset: 0x0008C731
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr workbookPr
		{
			get
			{
				return this.workbookPrField;
			}
			set
			{
				this.workbookPrField = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x0008E53A File Offset: 0x0008C73A
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x0008E542 File Offset: 0x0008C742
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection workbookProtection
		{
			get
			{
				return this.workbookProtectionField;
			}
			set
			{
				this.workbookProtectionField = value;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x0008E54B File Offset: 0x0008C74B
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x0008E553 File Offset: 0x0008C753
		[global::System.Xml.Serialization.XmlElement("bookViews", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews bookViews
		{
			get
			{
				return this.bookViewsField;
			}
			set
			{
				this.bookViewsField = value;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x0008E55C File Offset: 0x0008C75C
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x0008E564 File Offset: 0x0008C764
		[global::System.Xml.Serialization.XmlElement("sheets", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets sheets
		{
			get
			{
				return this.sheetsField;
			}
			set
			{
				this.sheetsField = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0008E56D File Offset: 0x0008C76D
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x0008E575 File Offset: 0x0008C775
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups functionGroups
		{
			get
			{
				return this.functionGroupsField;
			}
			set
			{
				this.functionGroupsField = value;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x0008E57E File Offset: 0x0008C77E
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x0008E586 File Offset: 0x0008C786
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences externalReferences
		{
			get
			{
				return this.externalReferencesField;
			}
			set
			{
				this.externalReferencesField = value;
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0008E58F File Offset: 0x0008C78F
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0008E4F5 File Offset: 0x0008C6F5
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames definedNames
		{
			get
			{
				return this.definedNamesField;
			}
			set
			{
				this.definedNamesField = value;
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0008E597 File Offset: 0x0008C797
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0008E59F File Offset: 0x0008C79F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr calcPr
		{
			get
			{
				return this.calcPrField;
			}
			set
			{
				this.calcPrField = value;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x0008E5A8 File Offset: 0x0008C7A8
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x0008E5B0 File Offset: 0x0008C7B0
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleSize oleSize
		{
			get
			{
				return this.oleSizeField;
			}
			set
			{
				this.oleSizeField = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x0008E5B9 File Offset: 0x0008C7B9
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x0008E5C1 File Offset: 0x0008C7C1
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews customWorkbookViews
		{
			get
			{
				return this.customWorkbookViewsField;
			}
			set
			{
				this.customWorkbookViewsField = value;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x0008E5CA File Offset: 0x0008C7CA
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x0008E5D2 File Offset: 0x0008C7D2
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches pivotCaches
		{
			get
			{
				return this.pivotCachesField;
			}
			set
			{
				this.pivotCachesField = value;
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x0008E5DB File Offset: 0x0008C7DB
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x0008E5E3 File Offset: 0x0008C7E3
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr smartTagPr
		{
			get
			{
				return this.smartTagPrField;
			}
			set
			{
				this.smartTagPrField = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x0008E5EC File Offset: 0x0008C7EC
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x0008E5F4 File Offset: 0x0008C7F4
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes smartTagTypes
		{
			get
			{
				return this.smartTagTypesField;
			}
			set
			{
				this.smartTagTypesField = value;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x0008E5FD File Offset: 0x0008C7FD
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x0008E605 File Offset: 0x0008C805
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing webPublishing
		{
			get
			{
				return this.webPublishingField;
			}
			set
			{
				this.webPublishingField = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x0008E60E File Offset: 0x0008C80E
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x0008E616 File Offset: 0x0008C816
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr> fileRecoveryPr
		{
			get
			{
				return this.fileRecoveryPrField;
			}
			set
			{
				this.fileRecoveryPrField = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0008E61F File Offset: 0x0008C81F
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x0008E627 File Offset: 0x0008C827
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects webPublishObjects
		{
			get
			{
				return this.webPublishObjectsField;
			}
			set
			{
				this.webPublishObjectsField = value;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0008E630 File Offset: 0x0008C830
		// (set) Token: 0x0600394C RID: 14668 RVA: 0x0008E638 File Offset: 0x0008C838
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

		// Token: 0x0600394D RID: 14669 RVA: 0x0008E641 File Offset: 0x0008C841
		public bool IsSetPivotCaches()
		{
			return this.pivotCachesField != null;
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0008E64C File Offset: 0x0008C84C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches AddNewPivotCaches()
		{
			this.pivotCachesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches();
			return this.pivotCachesField;
		}

		// Token: 0x040024A9 RID: 9385
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileVersion fileVersionField;

		// Token: 0x040024AA RID: 9386
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileSharing fileSharingField;

		// Token: 0x040024AB RID: 9387
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr workbookPrField;

		// Token: 0x040024AC RID: 9388
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection workbookProtectionField;

		// Token: 0x040024AD RID: 9389
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookViews bookViewsField;

		// Token: 0x040024AE RID: 9390
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets sheetsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets();

		// Token: 0x040024AF RID: 9391
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroups functionGroupsField;

		// Token: 0x040024B0 RID: 9392
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences externalReferencesField;

		// Token: 0x040024B1 RID: 9393
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames definedNamesField;

		// Token: 0x040024B2 RID: 9394
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr calcPrField;

		// Token: 0x040024B3 RID: 9395
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleSize oleSizeField;

		// Token: 0x040024B4 RID: 9396
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomWorkbookViews customWorkbookViewsField;

		// Token: 0x040024B5 RID: 9397
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches pivotCachesField;

		// Token: 0x040024B6 RID: 9398
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagPr smartTagPrField;

		// Token: 0x040024B7 RID: 9399
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagTypes smartTagTypesField;

		// Token: 0x040024B8 RID: 9400
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing webPublishingField;

		// Token: 0x040024B9 RID: 9401
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr> fileRecoveryPrField;

		// Token: 0x040024BA RID: 9402
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects webPublishObjectsField;

		// Token: 0x040024BB RID: 9403
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
