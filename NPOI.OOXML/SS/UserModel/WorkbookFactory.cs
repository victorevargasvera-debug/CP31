using System;
using System.IO;
using NPOI.HSSF.Record.Crypto;
using NPOI.HSSF.UserModel;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.POIFS.Crypt;
using NPOI.POIFS.FileSystem;
using NPOI.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.SS.UserModel
{
	// Token: 0x020000F1 RID: 241
	public class WorkbookFactory
	{
		// Token: 0x06000EC1 RID: 3777 RVA: 0x00033C48 File Offset: 0x00031E48
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs)
		{
			return new global::NPOI.HSSF.UserModel.HSSFWorkbook(fs);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00033C50 File Offset: 0x00031E50
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			return new global::NPOI.HSSF.UserModel.HSSFWorkbook(fs.Root, true);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00033C60 File Offset: 0x00031E60
		private static global::NPOI.SS.UserModel.IWorkbook Create(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs, string password)
		{
			global::NPOI.POIFS.FileSystem.DirectoryNode root = fs.Root;
			if (root.HasEntry(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY))
			{
				return global::NPOI.SS.UserModel.WorkbookFactory.Create(global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(global::NPOI.POIFS.FileSystem.DocumentFactoryHelper.GetDecryptedStream(fs, password)));
			}
			if (password != null)
			{
				global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.CurrentUserPassword = password;
			}
			global::NPOI.SS.UserModel.IWorkbook result;
			try
			{
				result = new global::NPOI.HSSF.UserModel.HSSFWorkbook(root, true);
			}
			finally
			{
				global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.CurrentUserPassword = null;
			}
			return result;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00033CC0 File Offset: 0x00031EC0
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			return new global::NPOI.XSSF.UserModel.XSSFWorkbook(pkg);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00033CC8 File Offset: 0x00031EC8
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::System.IO.Stream inputStream, bool bReadonly)
		{
			if (inputStream.Length == 0L)
			{
				throw new global::NPOI.EmptyFileException();
			}
			inputStream = new global::NPOI.Util.PushbackStream(inputStream);
			if (global::NPOI.POIFS.FileSystem.POIFSFileSystem.HasPOIFSHeader(inputStream))
			{
				return new global::NPOI.HSSF.UserModel.HSSFWorkbook(inputStream);
			}
			inputStream.Position = 0L;
			if (global::NPOI.POIFS.FileSystem.DocumentFactoryHelper.HasOOXMLHeader(inputStream))
			{
				return new global::NPOI.XSSF.UserModel.XSSFWorkbook(global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(inputStream, bReadonly));
			}
			throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Your stream was neither an OLE2 stream, nor an OOXML stream.");
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00033D21 File Offset: 0x00031F21
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::System.IO.Stream inputStream)
		{
			return global::NPOI.SS.UserModel.WorkbookFactory.Create(inputStream, false);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00033D2C File Offset: 0x00031F2C
		public static global::NPOI.SS.UserModel.IWorkbook Create(string file)
		{
			if (!global::System.IO.File.Exists(file))
			{
				throw new global::System.IO.FileNotFoundException(file);
			}
			global::NPOI.SS.UserModel.IWorkbook result;
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(file))
			{
				result = global::NPOI.SS.UserModel.WorkbookFactory.Create(fileStream);
			}
			return result;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00033D74 File Offset: 0x00031F74
		public static global::NPOI.SS.UserModel.IWorkbook Create(string file, string password)
		{
			return global::NPOI.SS.UserModel.WorkbookFactory.Create(file, password, false);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00033D80 File Offset: 0x00031F80
		public static global::NPOI.SS.UserModel.IWorkbook Create(string file, string password, bool readOnly)
		{
			if (!global::System.IO.File.Exists(file))
			{
				throw new global::System.IO.FileNotFoundException(file);
			}
			global::System.IO.FileInfo file2 = new global::System.IO.FileInfo(file);
			global::NPOI.SS.UserModel.IWorkbook result;
			try
			{
				global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(file2, readOnly);
				try
				{
					result = global::NPOI.SS.UserModel.WorkbookFactory.Create(npoifsfileSystem, password);
				}
				finally
				{
					if (npoifsfileSystem != null)
					{
						npoifsfileSystem.Close();
					}
				}
			}
			catch (global::NPOI.POIFS.FileSystem.OfficeXmlFileException)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(file, readOnly ? global::NPOI.OpenXml4Net.OPC.PackageAccess.READ : global::NPOI.OpenXml4Net.OPC.PackageAccess.READ_WRITE);
				try
				{
					result = new global::NPOI.XSSF.UserModel.XSSFWorkbook(opcpackage);
				}
				catch (global::System.IO.IOException ex)
				{
					opcpackage.Revert();
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					opcpackage.Revert();
					throw ex2;
				}
			}
			return result;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00033E1C File Offset: 0x0003201C
		public static global::NPOI.SS.UserModel.IWorkbook Create(global::System.IO.Stream inputStream, global::NPOI.SS.UserModel.ImportOption importOption)
		{
			global::NPOI.SS.UserModel.WorkbookFactory.SetImportOption(importOption);
			return global::NPOI.SS.UserModel.WorkbookFactory.Create(inputStream, true);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00033E2B File Offset: 0x0003202B
		public static global::NPOI.SS.UserModel.IFormulaEvaluator CreateFormulaEvaluator(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			if (typeof(global::NPOI.HSSF.UserModel.HSSFWorkbook) == workbook.GetType())
			{
				return new global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator(workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook);
			}
			return new global::NPOI.XSSF.UserModel.XSSFFormulaEvaluator(workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00033E5C File Offset: 0x0003205C
		public static void SetImportOption(global::NPOI.SS.UserModel.ImportOption importOption)
		{
			if (global::NPOI.SS.UserModel.ImportOption.SheetContentOnly == importOption)
			{
				global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKSHEET);
				global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHARED_STRINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TEMPLATE_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_TEMPLATE_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_ADDIN_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHARTSHEET);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.STYLES);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.DRAWINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHART);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VML_DRAWINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CUSTOM_XML_MAPPINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGES);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_EMF);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_WMF);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PICT);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_JPEG);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PNG);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_DIB);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_COMMENTS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_HYPERLINKS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.OLEEMBEDDINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PACKEMBEDDINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_CONTROLS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_BINS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.THEME);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CALC_CHAIN);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PRINTER_SETTINGS);
				return;
			}
			if (global::NPOI.SS.UserModel.ImportOption.TextOnly == importOption)
			{
				global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKSHEET);
				global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHARED_STRINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_COMMENTS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TEMPLATE_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_TEMPLATE_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_ADDIN_WORKBOOK);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHARTSHEET);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.STYLES);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.DRAWINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHART);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VML_DRAWINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CUSTOM_XML_MAPPINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGES);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_EMF);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_WMF);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PICT);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_JPEG);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PNG);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_DIB);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_HYPERLINKS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.OLEEMBEDDINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PACKEMBEDDINGS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_CONTROLS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_BINS);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.THEME);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CALC_CHAIN);
				global::NPOI.XSSF.UserModel.XSSFRelation.RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PRINTER_SETTINGS);
				return;
			}
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TEMPLATE_WORKBOOK);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_TEMPLATE_WORKBOOK);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_ADDIN_WORKBOOK);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.WORKSHEET);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHARTSHEET);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHARED_STRINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.STYLES);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.DRAWINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CHART);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VML_DRAWINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CUSTOM_XML_MAPPINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGES);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_EMF);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_WMF);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PICT);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_JPEG);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PNG);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_DIB);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_COMMENTS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_HYPERLINKS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.OLEEMBEDDINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PACKEMBEDDINGS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.VBA_MACROS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_CONTROLS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.ACTIVEX_BINS);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.THEME);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.CALC_CHAIN);
			global::NPOI.XSSF.UserModel.XSSFRelation.AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation.PRINTER_SETTINGS);
		}
	}
}
