using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A7 RID: 167
	public class XSSFWorkbook : global::NPOI.POIXMLDocument, global::NPOI.SS.UserModel.IWorkbook, global::NPOI.Util.ICloseable
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x000261B3 File Offset: 0x000243B3
		public XSSFWorkbook() : this(global::NPOI.XSSF.UserModel.XSSFWorkbookType.XLSX)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000261C0 File Offset: 0x000243C0
		public XSSFWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbookType workbookType)
		{
			this._udfFinder = new global::NPOI.SS.Formula.UDF.IndexedUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.UDF.UDFFinder.GetDefault()
			});
			this._missingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK;
			base..ctor(global::NPOI.XSSF.UserModel.XSSFWorkbook.newPackage(workbookType));
			this.OnWorkbookCreate();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000261F4 File Offset: 0x000243F4
		public XSSFWorkbook(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			this._udfFinder = new global::NPOI.SS.Formula.UDF.IndexedUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.UDF.UDFFinder.GetDefault()
			});
			this._missingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK;
			base..ctor(pkg);
			this.BeforeDocumentRead();
			base.Load(global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
			if (!this.workbook.IsSetBookViews())
			{
				this.workbook.AddNewBookViews().AddNewWorkbookView().activeTab = 0U;
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002625C File Offset: 0x0002445C
		public XSSFWorkbook(global::System.IO.Stream is1)
		{
			this._udfFinder = new global::NPOI.SS.Formula.UDF.IndexedUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.UDF.UDFFinder.GetDefault()
			});
			this._missingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK;
			base..ctor(global::NPOI.Util.PackageHelper.Open(is1));
			this.BeforeDocumentRead();
			base.Load(global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
			if (!this.workbook.IsSetBookViews())
			{
				this.workbook.AddNewBookViews().AddNewWorkbookView().activeTab = 0U;
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000262C9 File Offset: 0x000244C9
		public XSSFWorkbook(global::System.IO.FileInfo file) : this(global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(file))
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000262D7 File Offset: 0x000244D7
		public XSSFWorkbook(string path) : this(global::NPOI.POIXMLDocument.OpenPackage(path))
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000262E5 File Offset: 0x000244E5
		protected void BeforeDocumentRead()
		{
			if (base.CorePart.ContentType.Equals(global::NPOI.XSSF.UserModel.XSSFRelation.XLSB_BINARY_WORKBOOK.ContentType))
			{
				throw new global::NPOI.XSSF.XLSBUnsupportedException();
			}
			this.pivotTables = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable>();
			this.pivotCaches = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache>();
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00026320 File Offset: 0x00024520
		internal override void OnDocumentRead()
		{
			try
			{
				global::System.Xml.XmlDocument xmlDoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(base.GetPackagePart().GetInputStream());
				this.doc = global::NPOI.OpenXmlFormats.Spreadsheet.WorkbookDocument.Parse(xmlDoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.workbook = this.doc.Workbook;
				global::NPOI.XSSF.Model.ThemesTable theme = null;
				global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFSheet> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFSheet>();
				global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.Model.ExternalLinksTable> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.Model.ExternalLinksTable>();
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
				{
					global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
					if (documentPart is global::NPOI.XSSF.Model.SharedStringsTable)
					{
						this.sharedStringSource = (global::NPOI.XSSF.Model.SharedStringsTable)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.Model.StylesTable)
					{
						this.stylesSource = (global::NPOI.XSSF.Model.StylesTable)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.Model.ThemesTable)
					{
						theme = (global::NPOI.XSSF.Model.ThemesTable)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.Model.CalculationChain)
					{
						this.calcChain = (global::NPOI.XSSF.Model.CalculationChain)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.Model.MapInfo)
					{
						this.mapInfo = (global::NPOI.XSSF.Model.MapInfo)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.UserModel.XSSFSheet)
					{
						dictionary[relationPart.Relationship.Id] = (global::NPOI.XSSF.UserModel.XSSFSheet)documentPart;
					}
					else if (documentPart is global::NPOI.XSSF.Model.ExternalLinksTable)
					{
						dictionary2[relationPart.Relationship.Id] = (global::NPOI.XSSF.Model.ExternalLinksTable)documentPart;
					}
				}
				bool flag = base.Package.GetPackageAccess() == global::NPOI.OpenXml4Net.OPC.PackageAccess.READ;
				if (this.stylesSource == null)
				{
					if (flag)
					{
						this.stylesSource = new global::NPOI.XSSF.Model.StylesTable();
					}
					else
					{
						this.stylesSource = (global::NPOI.XSSF.Model.StylesTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.STYLES, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
					}
				}
				this.stylesSource.SetWorkbook(this);
				this.stylesSource.SetTheme(theme);
				if (this.sharedStringSource == null)
				{
					if (flag)
					{
						this.sharedStringSource = new global::NPOI.XSSF.Model.SharedStringsTable();
					}
					else
					{
						this.sharedStringSource = (global::NPOI.XSSF.Model.SharedStringsTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.SHARED_STRINGS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
					}
				}
				this.sheets = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFSheet>(dictionary.Count);
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ctSheet in this.workbook.sheets.sheet)
				{
					this.ParseSheet(dictionary, ctSheet);
				}
				this.externalLinks = new global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable>(dictionary2.Count);
				if (this.workbook.IsSetExternalReferences())
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference ct_ExternalReference in this.workbook.externalReferences.externalReference)
					{
						global::NPOI.XSSF.Model.ExternalLinksTable externalLinksTable = null;
						if (dictionary2.ContainsKey(ct_ExternalReference.id))
						{
							externalLinksTable = dictionary2[ct_ExternalReference.id];
						}
						if (externalLinksTable == null)
						{
							global::NPOI.XSSF.UserModel.XSSFWorkbook.logger.Log(5, "ExternalLinksTable with r:id " + ct_ExternalReference.id + " was defined, but didn't exist in package, skipping");
						}
						else
						{
							this.externalLinks.Add(externalLinksTable);
						}
					}
				}
				this.ReprocessNamedRanges();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00026678 File Offset: 0x00024878
		private void ParseSheet(global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFSheet> shIdMap, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ctSheet)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = null;
			if (shIdMap.ContainsKey(ctSheet.id))
			{
				xssfsheet = shIdMap[ctSheet.id];
			}
			if (xssfsheet == null)
			{
				global::NPOI.XSSF.UserModel.XSSFWorkbook.logger.Log(5, string.Concat(new string[]
				{
					"Sheet with name ",
					ctSheet.name,
					" and r:id ",
					ctSheet.id,
					" was defined, but didn't exist in package, skipping"
				}));
				return;
			}
			xssfsheet.sheet = ctSheet;
			xssfsheet.OnDocumentRead();
			this.sheets.Add(xssfsheet);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00026700 File Offset: 0x00024900
		private void OnWorkbookCreate()
		{
			this.doc = new global::NPOI.OpenXmlFormats.Spreadsheet.WorkbookDocument();
			this.workbook = this.doc.Workbook;
			this.workbook.AddNewWorkbookPr().date1904 = false;
			this.workbook.AddNewBookViews().AddNewWorkbookView().activeTab = 0U;
			this.workbook.AddNewSheets();
			global::NPOI.OpenXmlFormats.CT_ExtendedProperties underlyingProperties = base.GetProperties().ExtendedProperties.GetUnderlyingProperties();
			underlyingProperties.Application = global::NPOI.POIXMLDocument.DOCUMENT_CREATOR;
			underlyingProperties.DocSecurity = 0;
			underlyingProperties.DocSecuritySpecified = true;
			underlyingProperties.ScaleCrop = false;
			underlyingProperties.ScaleCropSpecified = true;
			underlyingProperties.LinksUpToDate = false;
			underlyingProperties.LinksUpToDateSpecified = true;
			underlyingProperties.HyperlinksChanged = false;
			underlyingProperties.HyperlinksChangedSpecified = true;
			underlyingProperties.SharedDoc = false;
			underlyingProperties.SharedDocSpecified = true;
			this.sharedStringSource = (global::NPOI.XSSF.Model.SharedStringsTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.SHARED_STRINGS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
			this.stylesSource = (global::NPOI.XSSF.Model.StylesTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.STYLES, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
			this.stylesSource.SetWorkbook(this);
			this.namedRanges = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>();
			this.namedRangesByName = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>>();
			this.sheets = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFSheet>();
			this.pivotTables = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable>();
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002682C File Offset: 0x00024A2C
		protected static global::NPOI.OpenXml4Net.OPC.OPCPackage newPackage(global::NPOI.XSSF.UserModel.XSSFWorkbookType workbookType)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = global::NPOI.OpenXml4Net.OPC.OPCPackage.Create(new global::System.IO.MemoryStream());
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK.DefaultFileName);
				opcpackage.AddRelationship(packagePartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
				opcpackage.CreatePart(packagePartName, workbookType.ContentType);
				opcpackage.GetPackageProperties().SetCreatorProperty(global::NPOI.POIXMLDocument.DOCUMENT_CREATOR);
				result = opcpackage;
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002689C File Offset: 0x00024A9C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook GetCTWorkbook()
		{
			return this.workbook;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000268A4 File Offset: 0x00024AA4
		public int AddPicture(byte[] pictureData, int format)
		{
			return this.AddPicture(pictureData, (global::NPOI.SS.UserModel.PictureType)format);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000268B0 File Offset: 0x00024AB0
		public int AddPicture(global::System.IO.Stream picStream, int format)
		{
			int num = this.GetAllPictures().Count + 1;
			global::NPOI.XSSF.UserModel.XSSFPictureData xssfpictureData = (global::NPOI.XSSF.UserModel.XSSFPictureData)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[format], global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), num, true).DocumentPart;
			global::System.IO.Stream outputStream = xssfpictureData.GetPackagePart().GetOutputStream();
			global::NPOI.Util.IOUtils.Copy(picStream, outputStream);
			outputStream.Close();
			this.pictures.Add(xssfpictureData);
			return num - 1;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00026916 File Offset: 0x00024B16
		public global::NPOI.SS.UserModel.ISheet CloneSheet(int sheetNum)
		{
			return this.CloneSheet(sheetNum, null);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00026920 File Offset: 0x00024B20
		public global::NPOI.SS.UserModel.ISheet CloneSheet(int sheetNum, string newName)
		{
			this.ValidateSheetIndex(sheetNum);
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = this.sheets[sheetNum];
			if (newName == null)
			{
				string sheetName = xssfsheet.SheetName;
				newName = this.GetUniqueSheetName(sheetName);
			}
			else
			{
				this.ValidateSheetName(newName);
				global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(newName);
			}
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet2 = this.CreateSheet(newName) as global::NPOI.XSSF.UserModel.XSSFSheet;
			global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart> relationParts = xssfsheet.RelationParts;
			global::NPOI.XSSF.UserModel.XSSFDrawing xssfdrawing = null;
			foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in relationParts)
			{
				global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
				if (documentPart is global::NPOI.XSSF.UserModel.XSSFDrawing)
				{
					xssfdrawing = (global::NPOI.XSSF.UserModel.XSSFDrawing)documentPart;
				}
				else
				{
					global::NPOI.XSSF.UserModel.XSSFWorkbook.AddRelation(relationPart, xssfsheet2);
				}
			}
			try
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in xssfsheet.GetPackagePart().Relationships)
				{
					global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = packageRelationship.TargetMode;
					global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
					if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
					{
						xssfsheet2.GetPackagePart().AddExternalRelationship(packageRelationship.TargetUri.ToString(), packageRelationship.RelationshipType, null);
					}
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::NPOI.POIXMLException("Failed to clone sheet", ex);
			}
			try
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					xssfsheet.Write(memoryStream);
					xssfsheet2.Read(new global::System.IO.MemoryStream(memoryStream.ToArray()));
				}
			}
			catch (global::System.IO.IOException ex2)
			{
				throw new global::NPOI.POIXMLException("Failed to clone sheet", ex2);
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ctworksheet = xssfsheet2.GetCTWorksheet();
			if (ctworksheet.IsSetLegacyDrawing())
			{
				ctworksheet.UnsetLegacyDrawing();
			}
			if (ctworksheet.IsSetPageSetup())
			{
				ctworksheet.UnsetPageSetup();
			}
			xssfsheet2.IsSelected = false;
			if (xssfdrawing != null)
			{
				if (ctworksheet.IsSetDrawing())
				{
					ctworksheet.UnsetDrawing();
				}
				global::NPOI.XSSF.UserModel.XSSFDrawing xssfdrawing2 = xssfsheet2.CreateDrawingPatriarch() as global::NPOI.XSSF.UserModel.XSSFDrawing;
				xssfdrawing2.GetCTDrawing().Set(xssfdrawing.GetCTDrawing());
				xssfdrawing2 = (xssfsheet2.CreateDrawingPatriarch() as global::NPOI.XSSF.UserModel.XSSFDrawing);
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart rp in (xssfsheet.CreateDrawingPatriarch() as global::NPOI.XSSF.UserModel.XSSFDrawing).RelationParts)
				{
					global::NPOI.XSSF.UserModel.XSSFWorkbook.AddRelation(rp, xssfdrawing2);
				}
			}
			return xssfsheet2;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00026B88 File Offset: 0x00024D88
		private static void AddRelation(global::NPOI.POIXMLDocumentPart.RelationPart rp, global::NPOI.POIXMLDocumentPart target)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = rp.Relationship;
			global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = relationship.TargetMode;
			global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
			if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
			{
				target.GetPackagePart().AddRelationship(relationship.TargetUri, relationship.TargetMode.Value, relationship.RelationshipType, relationship.Id);
				return;
			}
			global::NPOI.XSSF.UserModel.XSSFRelation instance = global::NPOI.XSSF.UserModel.XSSFRelation.GetInstance(relationship.RelationshipType);
			if (instance == null)
			{
				throw new global::NPOI.POIXMLException("Can't clone sheet - unknown relation type found: " + relationship.RelationshipType);
			}
			target.AddRelation(relationship.Id, instance, rp.DocumentPart);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00026C20 File Offset: 0x00024E20
		private string GetUniqueSheetName(string srcName)
		{
			int num = 2;
			string text = srcName;
			int num2 = srcName.LastIndexOf('(');
			if (num2 > 0 && srcName.EndsWith(")"))
			{
				string text2 = srcName.Substring(num2 + 1, srcName.Length - ")".Length - num2 - 1);
				try
				{
					num = int.Parse(text2.Trim());
					num++;
					text = srcName.Substring(0, num2).Trim();
				}
				catch (global::System.FormatException)
				{
				}
			}
			string text4;
			do
			{
				string text3 = num++.ToString();
				if (text.Length + text3.Length + 2 < 31)
				{
					text4 = text + " (" + text3 + ")";
				}
				else
				{
					text4 = text.Substring(0, 31 - text3.Length - 2) + "(" + text3 + ")";
				}
			}
			while (this.GetSheetIndex(text4) != -1);
			return text4;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00026D0C File Offset: 0x00024F0C
		public global::NPOI.SS.UserModel.ICellStyle CreateCellStyle()
		{
			return this.stylesSource.CreateCellStyle();
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00026D19 File Offset: 0x00024F19
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			if (this.formatter == null)
			{
				this.formatter = new global::NPOI.XSSF.UserModel.XSSFDataFormat(this.stylesSource);
			}
			return this.formatter;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00026D3A File Offset: 0x00024F3A
		public global::NPOI.SS.UserModel.IFont CreateFont()
		{
			global::NPOI.XSSF.UserModel.XSSFFont xssffont = new global::NPOI.XSSF.UserModel.XSSFFont();
			xssffont.RegisterTo(this.stylesSource);
			return xssffont;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00026D50 File Offset: 0x00024F50
		public global::NPOI.SS.UserModel.IName CreateName()
		{
			return this.CreateAndStoreName(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName
			{
				name = ""
			});
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00026D75 File Offset: 0x00024F75
		private void PutValuesMapping(string key, global::NPOI.XSSF.UserModel.XSSFName name)
		{
			if (this.namedRangesByName.ContainsKey(key))
			{
				this.namedRangesByName[key].Add(name);
				return;
			}
			this.namedRangesByName.Add(key, new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>
			{
				name
			});
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00026DB0 File Offset: 0x00024FB0
		private global::NPOI.XSSF.UserModel.XSSFName CreateAndStoreName(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ctName)
		{
			global::NPOI.XSSF.UserModel.XSSFName xssfname = new global::NPOI.XSSF.UserModel.XSSFName(ctName, this);
			this.namedRanges.Add(xssfname);
			this.PutValuesMapping(ctName.name.ToLower(), xssfname);
			return xssfname;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00026DE4 File Offset: 0x00024FE4
		public global::NPOI.SS.UserModel.ISheet CreateSheet()
		{
			string text = "Sheet" + this.sheets.Count.ToString();
			int num = 0;
			while (this.GetSheet(text) != null)
			{
				text = "Sheet" + num.ToString();
				num++;
			}
			return this.CreateSheet(text);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00026E3C File Offset: 0x0002503C
		public global::NPOI.SS.UserModel.ISheet CreateSheet(string sheetname)
		{
			if (sheetname == null)
			{
				throw new global::System.ArgumentException("sheetName must not be null");
			}
			this.ValidateSheetName(sheetname);
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(sheetname);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet = this.AddSheet(sheetname);
			int num = 1;
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
			{
				num = (int)global::System.Math.Max((long)((ulong)(xssfsheet.sheet.sheetId + 1U)), (long)num);
			}
			for (;;)
			{
				IL_6A:
				foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet2 in this.sheets)
				{
					num = (int)global::System.Math.Max((long)((ulong)(xssfsheet2.sheet.sheetId + 1U)), (long)num);
				}
				string fileName = global::NPOI.XSSF.UserModel.XSSFRelation.WORKSHEET.GetFileName(num);
				foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in base.GetRelations())
				{
					if (poixmldocumentPart.GetPackagePart() != null && fileName.Equals(poixmldocumentPart.GetPackagePart().PartName.Name))
					{
						num++;
						goto IL_6A;
					}
				}
				break;
			}
			global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.WORKSHEET, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), num, false);
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet3 = relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFSheet;
			xssfsheet3.sheet = ct_Sheet;
			ct_Sheet.id = relationPart.Relationship.Id;
			ct_Sheet.sheetId = (uint)num;
			if (this.sheets.Count == 0)
			{
				xssfsheet3.IsSelected = true;
			}
			this.sheets.Add(xssfsheet3);
			return xssfsheet3;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00026FEC File Offset: 0x000251EC
		private void ValidateSheetName(string sheetName)
		{
			if (this.ContainsSheet(sheetName, this.sheets.Count))
			{
				throw new global::System.ArgumentException(string.Format("The workbook already contains a sheet named '{0}'", sheetName));
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00027014 File Offset: 0x00025214
		protected global::NPOI.XSSF.UserModel.XSSFDialogsheet CreateDialogsheet(string sheetname, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dialogsheet dialogsheet)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = this.CreateSheet(sheetname) as global::NPOI.XSSF.UserModel.XSSFSheet;
			string relationId = base.GetRelationId(xssfsheet);
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = base.GetPackagePart().GetRelationship(relationId);
			return new global::NPOI.XSSF.UserModel.XSSFDialogsheet(xssfsheet, relationship);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002704A File Offset: 0x0002524A
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet AddSheet(string sheetname)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet = this.workbook.sheets.AddNewSheet();
			ct_Sheet.name = sheetname;
			return ct_Sheet;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00027064 File Offset: 0x00025264
		[global::System.Obsolete("deprecated POI 3.15. Use {@link #findFont(boolean, short, short, String, boolean, boolean, short, byte)} instead.")]
		public global::NPOI.SS.UserModel.IFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			return this.stylesSource.FindFont(boldWeight, color, fontHeight, name, italic, strikeout, typeOffset, underline);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002708C File Offset: 0x0002528C
		public global::NPOI.SS.UserModel.IFont FindFont(bool bold, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			return this.stylesSource.FindFont(bold, color, fontHeight, name, italic, strikeout, typeOffset, underline);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000270B1 File Offset: 0x000252B1
		public int ActiveSheetIndex
		{
			get
			{
				return (int)this.workbook.bookViews.GetWorkbookViewArray(0).activeTab;
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000270CC File Offset: 0x000252CC
		public global::System.Collections.IList GetAllPictures()
		{
			if (this.pictures == null)
			{
				global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> partsByName = base.Package.GetPartsByName(new global::System.Text.RegularExpressions.Regex("/xl/media/.*?"));
				this.pictures = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPictureData>(partsByName.Count);
				foreach (global::NPOI.OpenXml4Net.OPC.PackagePart part in partsByName)
				{
					this.pictures.Add(new global::NPOI.XSSF.UserModel.XSSFPictureData(part));
				}
			}
			return this.pictures;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002715C File Offset: 0x0002535C
		public global::NPOI.SS.UserModel.ICellStyle GetCellStyleAt(int idx)
		{
			return this.stylesSource.GetStyleAt(idx);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002716A File Offset: 0x0002536A
		public global::NPOI.SS.UserModel.IFont GetFontAt(short idx)
		{
			return this.stylesSource.GetFontAt((int)idx);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00027178 File Offset: 0x00025378
		public global::NPOI.SS.UserModel.IName GetName(string name)
		{
			global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> names = this.GetNames(name);
			if (names.Count == 0)
			{
				return null;
			}
			return names[0];
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000271A0 File Offset: 0x000253A0
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetNames(string name)
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName>();
			if (this.namedRangesByName.ContainsKey(name.ToLower()))
			{
				list.AddRange(this.namedRangesByName[name.ToLower()]);
			}
			return list.AsReadOnly();
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000271E4 File Offset: 0x000253E4
		[global::System.Obsolete("deprecated 3.16. New projects should avoid accessing named ranges by index.")]
		public global::NPOI.SS.UserModel.IName GetNameAt(int nameIndex)
		{
			int count = this.namedRanges.Count;
			if (count < 1)
			{
				throw new global::System.InvalidOperationException("There are no defined names in this workbook");
			}
			if (nameIndex < 0 || nameIndex > count)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified name index ",
					nameIndex.ToString(),
					" is outside the allowable range (0..",
					(count - 1).ToString(),
					")."
				}));
			}
			return this.namedRanges[nameIndex];
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00027261 File Offset: 0x00025461
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetAllNames()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName>();
			list.AddRange(this.namedRanges);
			return list.AsReadOnly();
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002727C File Offset: 0x0002547C
		[global::System.Obsolete("deprecated 3.16. New projects should avoid accessing named ranges by index. Use {@link #getName(String)} instead.")]
		public int GetNameIndex(string name)
		{
			global::NPOI.XSSF.UserModel.XSSFName xssfname = this.GetName(name) as global::NPOI.XSSF.UserModel.XSSFName;
			if (xssfname != null)
			{
				return this.namedRanges.IndexOf(xssfname);
			}
			return -1;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000272A7 File Offset: 0x000254A7
		public int NumCellStyles
		{
			get
			{
				return this.stylesSource.NumCellStyles;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000272B4 File Offset: 0x000254B4
		public short NumberOfFonts
		{
			get
			{
				return (short)this.stylesSource.GetFonts().Count;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000272C7 File Offset: 0x000254C7
		public int NumberOfNames
		{
			get
			{
				return this.namedRanges.Count;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x000272D4 File Offset: 0x000254D4
		public int NumberOfSheets
		{
			get
			{
				return this.sheets.Count;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000272E4 File Offset: 0x000254E4
		public string GetPrintArea(int sheetIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFName builtInName = this.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_AREA, sheetIndex);
			if (builtInName == null)
			{
				return null;
			}
			return builtInName.RefersToFormula;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002730C File Offset: 0x0002550C
		public global::NPOI.SS.UserModel.ISheet GetSheet(string name)
		{
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
			{
				if (name.Equals(xssfsheet.SheetName, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					return xssfsheet;
				}
			}
			return null;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00027370 File Offset: 0x00025570
		public global::NPOI.SS.UserModel.ISheet GetSheetAt(int index)
		{
			this.ValidateSheetIndex(index);
			return this.sheets[index];
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00027388 File Offset: 0x00025588
		public int GetSheetIndex(string name)
		{
			int num = 0;
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
			{
				if (name.Equals(xssfsheet.SheetName, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000273F0 File Offset: 0x000255F0
		public int GetSheetIndex(global::NPOI.SS.UserModel.ISheet sheet)
		{
			int num = 0;
			using (global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFSheet>.Enumerator enumerator = this.sheets.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == sheet)
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002744C File Offset: 0x0002564C
		public string GetSheetName(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.sheets[sheetIx].SheetName;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00027466 File Offset: 0x00025666
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> GetEnumerator()
		{
			return this.sheets.GetEnumerator();
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00027478 File Offset: 0x00025678
		public bool IsMacroEnabled()
		{
			return base.GetPackagePart().ContentType.Equals(global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK.ContentType);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00027494 File Offset: 0x00025694
		[global::System.Obsolete("deprecated 3.16. New projects should use {@link #removeName(Name)}.")]
		public void RemoveName(int nameIndex)
		{
			this.RemoveName(this.GetNameAt(nameIndex));
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000274A4 File Offset: 0x000256A4
		public void RemoveName(string name)
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName> list = this.namedRangesByName[name.ToLower()];
			if (list.Count == 0)
			{
				throw new global::System.ArgumentException("Named range was not found: " + name);
			}
			this.RemoveName(list[0]);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000274E9 File Offset: 0x000256E9
		private bool RemoveMapping(string key, global::NPOI.XSSF.UserModel.XSSFName item)
		{
			return this.namedRangesByName.ContainsKey(key) && this.namedRangesByName[key].Remove(item);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00027510 File Offset: 0x00025710
		public void RemoveName(global::NPOI.SS.UserModel.IName name)
		{
			if (!this.RemoveMapping(name.NameName.ToLower(), name as global::NPOI.XSSF.UserModel.XSSFName))
			{
				throw new global::System.ArgumentException("Name was not found: " + ((name != null) ? name.ToString() : null));
			}
			if (!this.namedRanges.Remove((global::NPOI.XSSF.UserModel.XSSFName)name))
			{
				throw new global::System.ArgumentException("Name was not found: " + ((name != null) ? name.ToString() : null));
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00027583 File Offset: 0x00025783
		internal void UpdateName(global::NPOI.XSSF.UserModel.XSSFName name, string oldName)
		{
			if (!this.RemoveMapping(oldName.ToLower(), name))
			{
				throw new global::System.ArgumentException("Name was not found: " + ((name != null) ? name.ToString() : null));
			}
			this.PutValuesMapping(name.NameName.ToLower(), name);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000275C4 File Offset: 0x000257C4
		public void RemovePrintArea(int sheetIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFName builtInName = this.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_AREA, sheetIndex);
			if (builtInName != null)
			{
				this.RemoveName(builtInName);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000275E8 File Offset: 0x000257E8
		public void RemoveSheetAt(int index)
		{
			this.ValidateSheetIndex(index);
			this.OnSheetDelete(index);
			global::NPOI.XSSF.UserModel.XSSFSheet part = (global::NPOI.XSSF.UserModel.XSSFSheet)this.GetSheetAt(index);
			base.RemoveRelation(part);
			this.sheets.RemoveAt(index);
			if (this.sheets.Count == 0)
			{
				return;
			}
			int num = index;
			if (num >= this.sheets.Count)
			{
				num = this.sheets.Count - 1;
			}
			int activeSheetIndex = this.ActiveSheetIndex;
			if (activeSheetIndex == index)
			{
				this.SetActiveSheet(num);
				return;
			}
			if (activeSheetIndex > index)
			{
				this.SetActiveSheet(activeSheetIndex - 1);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00027670 File Offset: 0x00025870
		private void OnSheetDelete(int index)
		{
			this.workbook.sheets.RemoveSheet(index);
			if (this.calcChain != null)
			{
				base.RemoveRelation(this.calcChain);
				this.calcChain = null;
			}
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>();
			foreach (global::NPOI.XSSF.UserModel.XSSFName xssfname in this.namedRanges)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ctname = xssfname.GetCTName();
				if (ctname.IsSetLocalSheetId())
				{
					if ((ulong)ctname.localSheetId == (ulong)((long)index))
					{
						list.Add(xssfname);
					}
					else if ((ulong)ctname.localSheetId > (ulong)((long)index))
					{
						ctname.localSheetId -= 1U;
						ctname.localSheetIdSpecified = true;
					}
				}
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFName name in list)
			{
				this.RemoveName(name);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00027770 File Offset: 0x00025970
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00027778 File Offset: 0x00025978
		public global::NPOI.SS.UserModel.MissingCellPolicy MissingCellPolicy
		{
			get
			{
				return this._missingCellPolicy;
			}
			set
			{
				this._missingCellPolicy = value;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00027784 File Offset: 0x00025984
		private void ValidateSheetIndex(int index)
		{
			int num = this.sheets.Count - 1;
			if (index < 0 || index > num)
			{
				string str = "(0.." + num.ToString() + ")";
				if (num == -1)
				{
					str = "(no sheets)";
				}
				throw new global::System.ArgumentException("Sheet index (" + index.ToString() + ") is out of range " + str);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000277E5 File Offset: 0x000259E5
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x000277FD File Offset: 0x000259FD
		public int FirstVisibleTab
		{
			get
			{
				return (int)this.workbook.bookViews.GetWorkbookViewArray(0).firstSheet;
			}
			set
			{
				this.workbook.bookViews.GetWorkbookViewArray(0).firstSheet = (uint)value;
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00027818 File Offset: 0x00025A18
		public void SetPrintArea(int sheetIndex, string reference)
		{
			global::NPOI.XSSF.UserModel.XSSFName xssfname = this.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_AREA, sheetIndex);
			if (xssfname == null)
			{
				xssfname = this.CreateBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_AREA, sheetIndex);
			}
			string[] array = global::NPOI.XSSF.UserModel.XSSFWorkbook.COMMA_PATTERN.Split(reference);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.GetSheetName(sheetIndex));
				stringBuilder.Append("!");
				stringBuilder.Append(array[i]);
			}
			xssfname.RefersToFormula = stringBuilder.ToString();
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000278A4 File Offset: 0x00025AA4
		public void SetPrintArea(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow)
		{
			string referencePrintArea = global::NPOI.XSSF.UserModel.XSSFWorkbook.GetReferencePrintArea(this.GetSheetName(sheetIndex), startColumn, endColumn, startRow, endRow);
			this.SetPrintArea(sheetIndex, referencePrintArea);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000278CC File Offset: 0x00025ACC
		private static string GetReferenceBuiltInRecord(string sheetName, int startC, int endC, int startR, int endR)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(sheetName, 0, startC, true, true);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(sheetName, 0, endC, true, true);
			string text = global::NPOI.SS.Formula.SheetNameFormatter.Format(sheetName);
			string value;
			if (startC == -1 && endC == -1)
			{
				value = "";
			}
			else
			{
				value = string.Concat(new string[]
				{
					text,
					"!$",
					cellReference.CellRefParts[2],
					":$",
					cellReference2.CellRefParts[2]
				});
			}
			global::NPOI.SS.Util.CellReference cellReference3 = new global::NPOI.SS.Util.CellReference(sheetName, startR, 0, true, true);
			global::NPOI.SS.Util.CellReference cellReference4 = new global::NPOI.SS.Util.CellReference(sheetName, endR, 0, true, true);
			string text2 = "";
			if (startR == -1 && endR == -1)
			{
				text2 = "";
			}
			else if (!cellReference3.CellRefParts[1].Equals("0") && !cellReference4.CellRefParts[1].Equals("0"))
			{
				text2 = string.Concat(new string[]
				{
					text,
					"!$",
					cellReference3.CellRefParts[1],
					":$",
					cellReference4.CellRefParts[1]
				});
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(value);
			if (stringBuilder.Length > 0 && text2.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append(text2);
			return stringBuilder.ToString();
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00027A10 File Offset: 0x00025C10
		private static string GetReferencePrintArea(string sheetName, int startC, int endC, int startR, int endR)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(sheetName, startR, startC, true, true);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(sheetName, endR, endC, true, true);
			return string.Concat(new string[]
			{
				"$",
				cellReference.CellRefParts[2],
				"$",
				cellReference.CellRefParts[1],
				":$",
				cellReference2.CellRefParts[2],
				"$",
				cellReference2.CellRefParts[1]
			});
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00027A8C File Offset: 0x00025C8C
		public global::NPOI.XSSF.UserModel.XSSFName GetBuiltInName(string builtInCode, int sheetNumber)
		{
			if (!this.namedRangesByName.ContainsKey(builtInCode.ToLower()))
			{
				return null;
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFName xssfname in this.namedRangesByName[builtInCode.ToLower()])
			{
				if (xssfname.SheetIndex == sheetNumber)
				{
					return xssfname;
				}
			}
			return null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00027B08 File Offset: 0x00025D08
		internal global::NPOI.XSSF.UserModel.XSSFName CreateBuiltInName(string builtInName, int sheetNumber)
		{
			this.ValidateSheetIndex(sheetNumber);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ct_DefinedName = ((this.workbook.definedNames == null) ? this.workbook.AddNewDefinedNames() : this.workbook.definedNames).AddNewDefinedName();
			ct_DefinedName.name = builtInName;
			ct_DefinedName.localSheetId = (uint)sheetNumber;
			ct_DefinedName.localSheetIdSpecified = true;
			if (this.GetBuiltInName(builtInName, sheetNumber) != null)
			{
				throw new global::NPOI.POIXMLException(string.Concat(new string[]
				{
					"Builtin (",
					builtInName,
					") already exists for sheet (",
					sheetNumber.ToString(),
					")"
				}));
			}
			return this.CreateAndStoreName(ct_DefinedName);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00027BA4 File Offset: 0x00025DA4
		public void SetSelectedTab(int index)
		{
			int num = 0;
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
			{
				xssfsheet.IsSelected = (num == index);
				num++;
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00027C00 File Offset: 0x00025E00
		public void SetSheetName(int sheetIndex, string sheetname)
		{
			this.ValidateSheetIndex(sheetIndex);
			string sheetName = this.GetSheetName(sheetIndex);
			if (sheetname != null && sheetname.Length > 31)
			{
				sheetname = sheetname.Substring(0, 31);
			}
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(sheetname);
			if (sheetname.Equals(sheetName))
			{
				return;
			}
			if (this.ContainsSheet(sheetname, sheetIndex))
			{
				throw new global::System.ArgumentException(string.Format("The workbook already contains a sheet named '{0}'", sheetname));
			}
			new global::NPOI.XSSF.UserModel.Helpers.XSSFFormulaUtils(this).UpdateSheetName(sheetIndex, sheetName, sheetname);
			this.workbook.sheets.GetSheetArray(sheetIndex).name = sheetname;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00027C84 File Offset: 0x00025E84
		public void SetSheetOrder(string sheetname, int pos)
		{
			int sheetIndex = this.GetSheetIndex(sheetname);
			global::NPOI.XSSF.UserModel.XSSFSheet item = this.sheets[sheetIndex];
			this.sheets.RemoveAt(sheetIndex);
			this.sheets.Insert(pos, item);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets ct_Sheets = this.workbook.sheets;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet sheet = ct_Sheets.GetSheetArray(sheetIndex).Copy();
			this.workbook.sheets.RemoveSheet(sheetIndex);
			ct_Sheets.InsertNewSheet(pos).Set(sheet);
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet> sheet2 = ct_Sheets.sheet;
			for (int i = 0; i < this.sheets.Count; i++)
			{
				this.sheets[i].sheet = sheet2[i];
			}
			int activeSheetIndex = this.ActiveSheetIndex;
			if (activeSheetIndex == sheetIndex)
			{
				this.SetActiveSheet(pos);
				return;
			}
			if ((activeSheetIndex >= sheetIndex || activeSheetIndex >= pos) && (activeSheetIndex <= sheetIndex || activeSheetIndex <= pos))
			{
				if (pos > sheetIndex)
				{
					this.SetActiveSheet(activeSheetIndex - 1);
					return;
				}
				this.SetActiveSheet(activeSheetIndex + 1);
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00027D74 File Offset: 0x00025F74
		private void SaveNamedRanges()
		{
			if (this.namedRanges.Count > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames ct_DefinedNames = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames();
				global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName>(this.namedRanges.Count);
				foreach (global::NPOI.XSSF.UserModel.XSSFName xssfname in this.namedRanges)
				{
					list.Add(xssfname.GetCTName());
				}
				ct_DefinedNames.SetDefinedNameArray(list);
				if (this.workbook.IsSetDefinedNames())
				{
					this.workbook.unsetDefinedNames();
				}
				this.workbook.SetDefinedNames(ct_DefinedNames);
				this.ReprocessNamedRanges();
				return;
			}
			if (this.workbook.IsSetDefinedNames())
			{
				this.workbook.unsetDefinedNames();
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00027E40 File Offset: 0x00026040
		private void ReprocessNamedRanges()
		{
			this.namedRangesByName = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>>();
			this.namedRanges = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>();
			if (this.workbook.IsSetDefinedNames())
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ctName in this.workbook.definedNames.definedName)
				{
					this.CreateAndStoreName(ctName);
				}
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00027EC4 File Offset: 0x000260C4
		private void SaveCalculationChain()
		{
			if (this.calcChain != null && this.calcChain.GetCTCalcChain().SizeOfCArray() == 0)
			{
				base.RemoveRelation(this.calcChain);
				this.calcChain = null;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00027EF4 File Offset: 0x000260F4
		protected internal override void Commit()
		{
			this.SaveNamedRanges();
			this.SaveCalculationChain();
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = base.GetPackagePart();
			this.doc.Save(packagePart.GetOutputStream());
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00027F28 File Offset: 0x00026128
		public void Write(global::System.IO.Stream stream, bool leaveOpen)
		{
			bool? flag = null;
			if (base.Package is global::NPOI.OpenXml4Net.OPC.ZipPackage)
			{
				flag = new bool?(((global::NPOI.OpenXml4Net.OPC.ZipPackage)base.Package).IsExternalStream);
				((global::NPOI.OpenXml4Net.OPC.ZipPackage)base.Package).IsExternalStream = leaveOpen;
			}
			base.Write(stream);
			if (flag != null && base.Package is global::NPOI.OpenXml4Net.OPC.ZipPackage)
			{
				((global::NPOI.OpenXml4Net.OPC.ZipPackage)base.Package).IsExternalStream = flag.Value;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00027FA6 File Offset: 0x000261A6
		public global::NPOI.XSSF.Model.SharedStringsTable GetSharedStringSource()
		{
			return this.sharedStringSource;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00027FAE File Offset: 0x000261AE
		public global::NPOI.XSSF.Model.StylesTable GetStylesSource()
		{
			return this.stylesSource;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00027FB6 File Offset: 0x000261B6
		public global::NPOI.XSSF.Model.ThemesTable GetTheme()
		{
			if (this.stylesSource == null)
			{
				return null;
			}
			return this.stylesSource.GetTheme();
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00027FCD File Offset: 0x000261CD
		public global::NPOI.SS.UserModel.ICreationHelper GetCreationHelper()
		{
			if (this._creationHelper == null)
			{
				this._creationHelper = new global::NPOI.XSSF.UserModel.XSSFCreationHelper(this);
			}
			return this._creationHelper;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00027FEC File Offset: 0x000261EC
		private bool ContainsSheet(string name, int excludeSheetIdx)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet> sheet = this.workbook.sheets.sheet;
			if (name.Length > global::NPOI.XSSF.UserModel.XSSFWorkbook.Max_SENSITIVE_SHEET_NAME_LEN)
			{
				name = name.Substring(0, global::NPOI.XSSF.UserModel.XSSFWorkbook.Max_SENSITIVE_SHEET_NAME_LEN);
			}
			for (int i = 0; i < sheet.Count; i++)
			{
				string text = sheet[i].name;
				if (text.Length > global::NPOI.XSSF.UserModel.XSSFWorkbook.Max_SENSITIVE_SHEET_NAME_LEN)
				{
					text = text.Substring(0, global::NPOI.XSSF.UserModel.XSSFWorkbook.Max_SENSITIVE_SHEET_NAME_LEN);
				}
				if (excludeSheetIdx != i && name.Equals(text, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00028070 File Offset: 0x00026270
		public bool IsDate1904()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookPr workbookPr = this.workbook.workbookPr;
			return workbookPr != null && workbookPr.date1904Specified && workbookPr.date1904;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000280A0 File Offset: 0x000262A0
		public override global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetAllEmbedds()
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship rel in xssfsheet.GetPackagePart().GetRelationshipsByType(global::NPOI.XSSF.UserModel.XSSFRelation.OLEEMBEDDINGS.Relation))
				{
					list.Add(xssfsheet.GetPackagePart().GetRelatedPart(rel));
				}
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship rel2 in xssfsheet.GetPackagePart().GetRelationshipsByType(global::NPOI.XSSF.UserModel.XSSFRelation.PACKEMBEDDINGS.Relation))
				{
					list.Add(xssfsheet.GetPackagePart().GetRelatedPart(rel2));
				}
			}
			return list;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool IsHidden
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000281AC File Offset: 0x000263AC
		public bool IsSheetHidden(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.sheets[sheetIx].sheet.state == global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.hidden;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000281CE File Offset: 0x000263CE
		public bool IsSheetVeryHidden(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.sheets[sheetIx].sheet.state == global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.veryHidden;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000281F0 File Offset: 0x000263F0
		public void SetSheetHidden(int sheetIx, bool hidden)
		{
			this.SetSheetHidden(sheetIx, hidden ? global::NPOI.SS.UserModel.SheetState.Hidden : global::NPOI.SS.UserModel.SheetState.Visible);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00028200 File Offset: 0x00026400
		public void SetSheetHidden(int sheetIx, global::NPOI.SS.UserModel.SheetState state)
		{
			this.ValidateSheetIndex(sheetIx);
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetState(state);
			this.sheets[sheetIx].sheet.state = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState)state;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00028226 File Offset: 0x00026426
		public void SetSheetHidden(int sheetIx, int hidden)
		{
			this.ValidateSheetIndex(sheetIx);
			this.SetSheetHidden(sheetIx, (global::NPOI.SS.UserModel.SheetState)hidden);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00028238 File Offset: 0x00026438
		internal void OnDeleteFormula(global::NPOI.XSSF.UserModel.XSSFCell cell)
		{
			if (this.calcChain != null)
			{
				int sheetId = (int)((global::NPOI.XSSF.UserModel.XSSFSheet)cell.Sheet).sheet.sheetId;
				this.calcChain.RemoveItem(sheetId, cell.GetReference());
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00028275 File Offset: 0x00026475
		public global::NPOI.XSSF.Model.CalculationChain GetCalculationChain()
		{
			return this.calcChain;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002827D File Offset: 0x0002647D
		public global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable> ExternalLinksTable
		{
			get
			{
				return this.externalLinks;
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00028285 File Offset: 0x00026485
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFMap> GetCustomXMLMappings()
		{
			if (this.mapInfo != null)
			{
				return this.mapInfo.GetAllXSSFMaps();
			}
			return new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFMap>();
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000282A0 File Offset: 0x000264A0
		public global::NPOI.XSSF.Model.MapInfo GetMapInfo()
		{
			return this.mapInfo;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000282A8 File Offset: 0x000264A8
		public int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			throw new global::NPOI.Util.RuntimeException("Not Implemented - see bug #57184");
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000282B4 File Offset: 0x000264B4
		public bool IsStructureLocked()
		{
			return this.WorkbookProtectionPresent() && this.workbook.workbookProtection.lockStructure;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000282D0 File Offset: 0x000264D0
		public bool IsWindowsLocked()
		{
			return this.WorkbookProtectionPresent() && this.workbook.workbookProtection.lockWindows;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000282EC File Offset: 0x000264EC
		public bool IsRevisionLocked()
		{
			return this.WorkbookProtectionPresent() && this.workbook.workbookProtection.lockRevision;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00028308 File Offset: 0x00026508
		public void LockStructure()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockStructure = true;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00028321 File Offset: 0x00026521
		public void UnlockStructure()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockStructure = false;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0002833A File Offset: 0x0002653A
		public void LockWindows()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockWindows = true;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00028353 File Offset: 0x00026553
		public void UnlockWindows()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockWindows = false;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002836C File Offset: 0x0002656C
		public void LockRevision()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockRevision = true;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00028385 File Offset: 0x00026585
		public void UnlockRevision()
		{
			this.CreateProtectionFieldIfNotPresent();
			this.workbook.workbookProtection.lockRevision = false;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000283A0 File Offset: 0x000265A0
		public void RemovePivotTables()
		{
			foreach (global::NPOI.XSSF.UserModel.XSSFPivotTable xssfpivotTable in this.pivotTables)
			{
				global::NPOI.POIXMLDocumentPart parent = xssfpivotTable.GetParent();
				if (parent is global::NPOI.XSSF.UserModel.XSSFSheet)
				{
					parent.RemoveRelation(xssfpivotTable);
				}
			}
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in base.GetRelations())
			{
				if (poixmldocumentPart is global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition)
				{
					global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition part = (global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition)poixmldocumentPart;
					base.RemoveRelation(part);
				}
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00028458 File Offset: 0x00026658
		private bool WorkbookProtectionPresent()
		{
			return this.workbook.workbookProtection != null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00028468 File Offset: 0x00026668
		private void CreateProtectionFieldIfNotPresent()
		{
			if (this.workbook.workbookProtection == null)
			{
				this.workbook.workbookProtection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection();
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00028487 File Offset: 0x00026687
		internal global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder()
		{
			return this._udfFinder;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002848F File Offset: 0x0002668F
		public void AddToolPack(global::NPOI.SS.Formula.UDF.UDFFinder toopack)
		{
			this._udfFinder.Add(toopack);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000284A0 File Offset: 0x000266A0
		public void SetForceFormulaRecalculation(bool value)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook ctworkbook = this.GetCTWorkbook();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr ct_CalcPr = ctworkbook.IsSetCalcPr() ? ctworkbook.calcPr : ctworkbook.AddNewCalcPr();
			ct_CalcPr.calcId = 0U;
			if (value && ct_CalcPr.calcMode == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.manual)
			{
				ct_CalcPr.calcMode = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.auto;
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000284E4 File Offset: 0x000266E4
		public bool GetForceFormulaRecalculation()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr calcPr = this.GetCTWorkbook().calcPr;
			return calcPr != null && calcPr.calcId > 0U;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00010C53 File Offset: 0x0000EE53
		public global::NPOI.SS.SpreadsheetVersion SpreadsheetVersion
		{
			get
			{
				return global::NPOI.SS.SpreadsheetVersion.EXCEL2007;
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002850C File Offset: 0x0002670C
		public global::NPOI.XSSF.UserModel.XSSFTable GetTable(string name)
		{
			if (name != null && this.sheets != null)
			{
				foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this.sheets)
				{
					foreach (global::NPOI.XSSF.UserModel.XSSFTable xssftable in xssfsheet.GetTables())
					{
						if (name.Equals(xssftable.Name, global::System.StringComparison.OrdinalIgnoreCase))
						{
							return xssftable;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000285B4 File Offset: 0x000267B4
		public void SetActiveSheet(int sheetIndex)
		{
			this.ValidateSheetIndex(sheetIndex);
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BookView ct_BookView in this.workbook.bookViews.workbookView)
			{
				ct_BookView.activeTab = (uint)sheetIndex;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00028618 File Offset: 0x00026818
		protected internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache AddPivotCache(string rId)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook ctworkbook = this.GetCTWorkbook();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCaches ct_PivotCaches;
			if (ctworkbook.IsSetPivotCaches())
			{
				ct_PivotCaches = ctworkbook.pivotCaches;
			}
			else
			{
				ct_PivotCaches = ctworkbook.AddNewPivotCaches();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache ct_PivotCache = ct_PivotCaches.AddNewPivotCache();
			int cacheId = this.PivotTables.Count + 1;
			ct_PivotCache.cacheId = (uint)cacheId;
			ct_PivotCache.id = rId;
			if (this.pivotCaches == null)
			{
				this.pivotCaches = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache>();
			}
			this.pivotCaches.Add(ct_PivotCache);
			return ct_PivotCache;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00028687 File Offset: 0x00026887
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0002868F File Offset: 0x0002688F
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable> PivotTables
		{
			get
			{
				return this.pivotTables;
			}
			set
			{
				this.pivotTables = value;
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00028698 File Offset: 0x00026898
		public int AddPicture(byte[] pictureData, global::NPOI.SS.UserModel.PictureType format)
		{
			int num = this.GetAllPictures().Count + 1;
			global::NPOI.XSSF.UserModel.XSSFPictureData xssfpictureData = (global::NPOI.XSSF.UserModel.XSSFPictureData)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[(int)format], global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), num, true).DocumentPart;
			try
			{
				global::System.IO.Stream outputStream = xssfpictureData.GetPackagePart().GetOutputStream();
				outputStream.Write(pictureData, 0, pictureData.Length);
				outputStream.Close();
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			this.pictures.Add(xssfpictureData);
			return num - 1;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00028718 File Offset: 0x00026918
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00028730 File Offset: 0x00026930
		public global::NPOI.XSSF.UserModel.XSSFWorkbookType WorkbookType
		{
			get
			{
				if (!this.IsMacroEnabled())
				{
					return global::NPOI.XSSF.UserModel.XSSFWorkbookType.XLSX;
				}
				return global::NPOI.XSSF.UserModel.XSSFWorkbookType.XLSM;
			}
			set
			{
				try
				{
					base.GetPackagePart().ContentType = value.ContentType;
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00028768 File Offset: 0x00026968
		public void SetVBAProject(global::System.IO.Stream vbaProjectStream)
		{
			if (!this.IsMacroEnabled())
			{
				this.WorkbookType = global::NPOI.XSSF.UserModel.XSSFWorkbookType.XLSM;
			}
			global::NPOI.OpenXml4Net.OPC.PackagePartName partName;
			try
			{
				partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS.DefaultFileName);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			global::NPOI.OpenXml4Net.OPC.OPCPackage package = base.Package;
			global::System.IO.Stream outputStream;
			if (!package.ContainPart(partName))
			{
				outputStream = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance()).GetPackagePart().GetOutputStream();
			}
			else
			{
				outputStream = package.GetPart(partName).GetOutputStream();
			}
			try
			{
				global::NPOI.Util.IOUtils.Copy(vbaProjectStream, outputStream);
			}
			finally
			{
				global::NPOI.Util.IOUtils.CloseQuietly(outputStream);
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00028808 File Offset: 0x00026A08
		public void SetVBAProject(global::NPOI.XSSF.UserModel.XSSFWorkbook macroWorkbook)
		{
			if (!macroWorkbook.IsMacroEnabled())
			{
				return;
			}
			global::System.IO.Stream contents = global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS.GetContents(macroWorkbook.CorePart);
			if (contents != null)
			{
				this.SetVBAProject(contents);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000065E4 File Offset: 0x000047E4
		public int IndexOf(global::NPOI.SS.UserModel.ISheet item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00028839 File Offset: 0x00026A39
		public void Insert(int index, global::NPOI.SS.UserModel.ISheet item)
		{
			this.sheets.Insert(index, (global::NPOI.XSSF.UserModel.XSSFSheet)item);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002884D File Offset: 0x00026A4D
		public void RemoveAt(int index)
		{
			this.RemoveSheetAt(index);
		}

		// Token: 0x17000307 RID: 775
		public global::NPOI.SS.UserModel.ISheet this[int index]
		{
			get
			{
				return this.GetSheetAt(index);
			}
			set
			{
				if (this.sheets[index] != null)
				{
					this.sheets[index] = (global::NPOI.XSSF.UserModel.XSSFSheet)value;
					return;
				}
				this.sheets.Insert(index, (global::NPOI.XSSF.UserModel.XSSFSheet)value);
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00028894 File Offset: 0x00026A94
		public void Add(global::NPOI.SS.UserModel.ISheet item)
		{
			this.sheets.Add((global::NPOI.XSSF.UserModel.XSSFSheet)item);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000288A7 File Offset: 0x00026AA7
		public void Clear()
		{
			this.sheets.Clear();
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000288B4 File Offset: 0x00026AB4
		public bool Contains(global::NPOI.SS.UserModel.ISheet item)
		{
			return this.sheets.Contains(item as global::NPOI.XSSF.UserModel.XSSFSheet);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000065E4 File Offset: 0x000047E4
		public void CopyTo(global::NPOI.SS.UserModel.ISheet[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000288C7 File Offset: 0x00026AC7
		public int Count
		{
			get
			{
				return this.NumberOfSheets;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00005008 File Offset: 0x00003208
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000288CF File Offset: 0x00026ACF
		public bool Remove(global::NPOI.SS.UserModel.ISheet item)
		{
			return this.sheets.Remove((global::NPOI.XSSF.UserModel.XSSFSheet)item);
		}

		// Token: 0x0400037D RID: 893
		private static global::System.Text.RegularExpressions.Regex COMMA_PATTERN = new global::System.Text.RegularExpressions.Regex(",", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0400037E RID: 894
		public static float DEFAULT_CHARACTER_WIDTH = 7.0017f;

		// Token: 0x0400037F RID: 895
		private static int Max_SENSITIVE_SHEET_NAME_LEN = 31;

		// Token: 0x04000380 RID: 896
		public static int PICTURE_TYPE_EMF = 2;

		// Token: 0x04000381 RID: 897
		public static int PICTURE_TYPE_WMF = 3;

		// Token: 0x04000382 RID: 898
		public static int PICTURE_TYPE_PICT = 4;

		// Token: 0x04000383 RID: 899
		public static int PICTURE_TYPE_JPEG = 5;

		// Token: 0x04000384 RID: 900
		public static int PICTURE_TYPE_PNG = 6;

		// Token: 0x04000385 RID: 901
		public static int PICTURE_TYPE_DIB = 7;

		// Token: 0x04000386 RID: 902
		public static int PICTURE_TYPE_GIF = 8;

		// Token: 0x04000387 RID: 903
		public static int PICTURE_TYPE_TIFF = 9;

		// Token: 0x04000388 RID: 904
		public static int PICTURE_TYPE_EPS = 10;

		// Token: 0x04000389 RID: 905
		public static int PICTURE_TYPE_BMP = 11;

		// Token: 0x0400038A RID: 906
		public static int PICTURE_TYPE_WPG = 12;

		// Token: 0x0400038B RID: 907
		public static int PICTURE_TYPE_JPG = 13;

		// Token: 0x0400038C RID: 908
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook workbook;

		// Token: 0x0400038D RID: 909
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFSheet> sheets;

		// Token: 0x0400038E RID: 910
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName>> namedRangesByName;

		// Token: 0x0400038F RID: 911
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFName> namedRanges;

		// Token: 0x04000390 RID: 912
		private global::NPOI.XSSF.Model.SharedStringsTable sharedStringSource;

		// Token: 0x04000391 RID: 913
		private global::NPOI.XSSF.Model.StylesTable stylesSource;

		// Token: 0x04000392 RID: 914
		private global::NPOI.SS.Formula.UDF.IndexedUDFFinder _udfFinder;

		// Token: 0x04000393 RID: 915
		private global::NPOI.XSSF.Model.CalculationChain calcChain;

		// Token: 0x04000394 RID: 916
		private global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable> externalLinks;

		// Token: 0x04000395 RID: 917
		private global::NPOI.XSSF.Model.MapInfo mapInfo;

		// Token: 0x04000396 RID: 918
		private global::NPOI.XSSF.UserModel.XSSFDataFormat formatter;

		// Token: 0x04000397 RID: 919
		private global::NPOI.SS.UserModel.MissingCellPolicy _missingCellPolicy;

		// Token: 0x04000398 RID: 920
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPictureData> pictures;

		// Token: 0x04000399 RID: 921
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFWorkbook));

		// Token: 0x0400039A RID: 922
		private global::NPOI.XSSF.UserModel.XSSFCreationHelper _creationHelper;

		// Token: 0x0400039B RID: 923
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable> pivotTables;

		// Token: 0x0400039C RID: 924
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache> pivotCaches;

		// Token: 0x0400039D RID: 925
		private global::NPOI.OpenXmlFormats.Spreadsheet.WorkbookDocument doc;
	}
}
