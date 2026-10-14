using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.SS;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CF RID: 207
	public class SXSSFWorkbook : global::NPOI.SS.UserModel.IWorkbook, global::NPOI.Util.ICloseable
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0002F759 File Offset: 0x0002D959
		public global::NPOI.XSSF.UserModel.XSSFWorkbook XssfWorkbook
		{
			get
			{
				return this._wb;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0002F761 File Offset: 0x0002D961
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0002F769 File Offset: 0x0002D969
		public int RandomAccessWindowSize
		{
			get
			{
				return this._randomAccessWindowSize;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::System.ArgumentException("rowAccessWindowSize must be greater than 0 or -1");
				}
				this._randomAccessWindowSize = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0002F781 File Offset: 0x0002D981
		public int ActiveSheetIndex
		{
			get
			{
				return this.XssfWorkbook.ActiveSheetIndex;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0002F78E File Offset: 0x0002D98E
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x0002F79B File Offset: 0x0002D99B
		public int FirstVisibleTab
		{
			get
			{
				return this.XssfWorkbook.FirstVisibleTab;
			}
			set
			{
				this.XssfWorkbook.FirstVisibleTab = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0002F7A9 File Offset: 0x0002D9A9
		public int NumberOfSheets
		{
			get
			{
				return this.XssfWorkbook.NumberOfSheets;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0002F7B6 File Offset: 0x0002D9B6
		public short NumberOfFonts
		{
			get
			{
				return this.XssfWorkbook.NumberOfFonts;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0002F7C3 File Offset: 0x0002D9C3
		public int NumCellStyles
		{
			get
			{
				return this.XssfWorkbook.NumCellStyles;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		public int NumberOfNames
		{
			get
			{
				return this.XssfWorkbook.NumberOfNames;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0002F7DD File Offset: 0x0002D9DD
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0002F7EA File Offset: 0x0002D9EA
		public global::NPOI.SS.UserModel.MissingCellPolicy MissingCellPolicy
		{
			get
			{
				return this.XssfWorkbook.MissingCellPolicy;
			}
			set
			{
				this.XssfWorkbook.MissingCellPolicy = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0002F7F8 File Offset: 0x0002D9F8
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0002F805 File Offset: 0x0002DA05
		public bool IsHidden
		{
			get
			{
				return this.XssfWorkbook.IsHidden;
			}
			set
			{
				this.XssfWorkbook.IsHidden = value;
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002F813 File Offset: 0x0002DA13
		public SXSSFWorkbook(int rowAccessWindowSize) : this(null, rowAccessWindowSize)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0002F81D File Offset: 0x0002DA1D
		public SXSSFWorkbook() : this(null)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002F826 File Offset: 0x0002DA26
		public SXSSFWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook) : this(workbook, 100)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0002F831 File Offset: 0x0002DA31
		public SXSSFWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, int rowAccessWindowSize) : this(workbook, rowAccessWindowSize, false)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002F83C File Offset: 0x0002DA3C
		public SXSSFWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, int rowAccessWindowSize, bool compressTmpFiles) : this(workbook, rowAccessWindowSize, compressTmpFiles, false)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0002F848 File Offset: 0x0002DA48
		public SXSSFWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, int rowAccessWindowSize, bool compressTmpFiles, bool useSharedStringsTable)
		{
			this.RandomAccessWindowSize = rowAccessWindowSize;
			this._compressTmpFiles = compressTmpFiles;
			if (workbook == null)
			{
				this._wb = new global::NPOI.XSSF.UserModel.XSSFWorkbook();
				this._sharedStringSource = (useSharedStringsTable ? this.XssfWorkbook.GetSharedStringSource() : null);
				return;
			}
			this._wb = workbook;
			this._sharedStringSource = (useSharedStringsTable ? this.XssfWorkbook.GetSharedStringSource() : null);
			int numberOfSheets = this.XssfWorkbook.NumberOfSheets;
			for (int i = 0; i < numberOfSheets; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFSheet xSheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.XssfWorkbook.GetSheetAt(i);
				this.CreateAndRegisterSXSSFSheet(xSheet);
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0002F900 File Offset: 0x0002DB00
		private global::NPOI.XSSF.Streaming.SXSSFSheet CreateAndRegisterSXSSFSheet(global::NPOI.SS.UserModel.ISheet xSheet)
		{
			global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet;
			try
			{
				sxssfsheet = new global::NPOI.XSSF.Streaming.SXSSFSheet(this, (global::NPOI.XSSF.UserModel.XSSFSheet)xSheet);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			this.RegisterSheetMapping(sxssfsheet, (global::NPOI.XSSF.UserModel.XSSFSheet)xSheet);
			return sxssfsheet;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0002F940 File Offset: 0x0002DB40
		private void RegisterSheetMapping(global::NPOI.XSSF.Streaming.SXSSFSheet sxSheet, global::NPOI.XSSF.UserModel.XSSFSheet xSheet)
		{
			this._sxFromXHash.Add(sxSheet, xSheet);
			this._xFromSxHash.Add(xSheet, sxSheet);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0002F95C File Offset: 0x0002DB5C
		private void DeregisterSheetMapping(global::NPOI.XSSF.UserModel.XSSFSheet xSheet)
		{
			global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet = this.GetSXSSFSheet(xSheet);
			try
			{
				sxssfsheet.SheetDataWriter.Close();
			}
			catch (global::System.IO.IOException)
			{
			}
			this._sxFromXHash.Remove(sxssfsheet);
			this._xFromSxHash.Remove(xSheet);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0002F9AC File Offset: 0x0002DBAC
		private global::NPOI.XSSF.UserModel.XSSFSheet GetXSSFSheet(global::NPOI.XSSF.Streaming.SXSSFSheet sheet)
		{
			if (sheet != null && this._sxFromXHash.ContainsKey(sheet))
			{
				return this._sxFromXHash[sheet];
			}
			return null;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002F9CD File Offset: 0x0002DBCD
		private global::NPOI.XSSF.Streaming.SXSSFSheet GetSXSSFSheet(global::NPOI.XSSF.UserModel.XSSFSheet sheet)
		{
			if (sheet != null && this._xFromSxHash.ContainsKey(sheet))
			{
				return this._xFromSxHash[sheet];
			}
			return null;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0002F9EE File Offset: 0x0002DBEE
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0002F9F6 File Offset: 0x0002DBF6
		public bool CompressTempFiles
		{
			get
			{
				return this._compressTmpFiles;
			}
			set
			{
				this._compressTmpFiles = value;
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0002F9FF File Offset: 0x0002DBFF
		public global::NPOI.XSSF.Streaming.SheetDataWriter CreateSheetDataWriter()
		{
			if (this._compressTmpFiles)
			{
				return new global::NPOI.XSSF.Streaming.GZIPSheetDataWriter(this._sharedStringSource);
			}
			return new global::NPOI.XSSF.Streaming.SheetDataWriter(this._sharedStringSource);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002FA20 File Offset: 0x0002DC20
		private global::NPOI.XSSF.UserModel.XSSFSheet GetSheetFromZipEntryName(string sheetRef)
		{
			foreach (global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet in this._sxFromXHash.Values)
			{
				if (sheetRef.Equals(xssfsheet.GetPackagePart().PartName.Name.Substring(1)))
				{
					return xssfsheet;
				}
			}
			return null;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002FA98 File Offset: 0x0002DC98
		private void InjectData(global::System.IO.FileInfo zipfile, global::System.IO.Stream outStream)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(zipfile.FullName);
			try
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(outStream);
				try
				{
					foreach (object obj in zipFile)
					{
						global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj;
						zipOutputStream.PutNextEntry(new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(zipEntry.Name));
						global::System.IO.Stream inputStream = zipFile.GetInputStream(zipEntry);
						global::NPOI.XSSF.UserModel.XSSFSheet sheetFromZipEntryName = this.GetSheetFromZipEntryName(zipEntry.Name);
						if (sheetFromZipEntryName != null)
						{
							global::System.IO.Stream worksheetXMLInputStream = this.GetSXSSFSheet(sheetFromZipEntryName).GetWorksheetXMLInputStream();
							try
							{
								global::NPOI.XSSF.Streaming.SXSSFWorkbook.CopyStreamAndInjectWorksheet(inputStream, zipOutputStream, worksheetXMLInputStream);
								goto IL_7F;
							}
							finally
							{
								worksheetXMLInputStream.Close();
							}
							goto IL_77;
						}
						goto IL_77;
						IL_7F:
						inputStream.Close();
						continue;
						IL_77:
						inputStream.CopyTo(zipOutputStream);
						goto IL_7F;
					}
				}
				finally
				{
					zipOutputStream.Close();
				}
			}
			finally
			{
				zipFile.Close();
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		private static void CopyStreamAndInjectWorksheet(global::System.IO.Stream inputStream, global::System.IO.Stream outputStream, global::System.IO.Stream worksheetData)
		{
			global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(inputStream, global::System.Text.Encoding.UTF8);
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(outputStream, global::System.Text.Encoding.UTF8);
			bool flag = true;
			int num = 0;
			string text = "<sheetData";
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int length = text.Length;
			int num2;
			while ((num2 = streamReader.Read()) != -1)
			{
				if ((char)num2 == text[num])
				{
					num++;
					if (num == length)
					{
						if (!"<sheetData".Equals(text))
						{
							break;
						}
						num2 = streamReader.Read();
						if (num2 == -1)
						{
							streamWriter.Write(text);
							stringBuilder.Append(text);
							break;
						}
						if ((ushort)num2 == 62)
						{
							streamWriter.Write(text);
							stringBuilder.Append(text);
							streamWriter.Write((char)num2);
							stringBuilder.Append((char)num2);
							text = "</sheetData>";
							length = text.Length;
							num = 0;
							flag = false;
						}
						else if ((ushort)num2 == 47)
						{
							num2 = streamReader.Read();
							if (num2 == -1)
							{
								streamWriter.Write(text);
								stringBuilder.Append(text);
								break;
							}
							if ((ushort)num2 == 62)
							{
								break;
							}
							streamWriter.Write(text);
							stringBuilder.Append(text);
							streamWriter.Write('/');
							stringBuilder.Append('/');
							streamWriter.Write((char)num2);
							stringBuilder.Append((char)num2);
							num = 0;
						}
						else
						{
							streamWriter.Write(text);
							stringBuilder.Append(text);
							streamWriter.Write('/');
							stringBuilder.Append('/');
							streamWriter.Write((char)num2);
							stringBuilder.Append((char)num2);
							num = 0;
						}
					}
				}
				else
				{
					if (num > 0)
					{
						streamWriter.Write(text.Substring(0, num));
						stringBuilder.Append(text, 0, num);
					}
					if (num2 == (int)text[0])
					{
						num = 1;
					}
					else
					{
						streamWriter.Write((char)num2);
						stringBuilder.Append((char)num2);
						num = 0;
					}
				}
			}
			streamWriter.Flush();
			if (flag)
			{
				streamWriter.Write("<sheetData>\n");
				stringBuilder.Append("<sheetData>\n");
				streamWriter.Flush();
			}
			worksheetData.CopyTo(outputStream);
			streamWriter.Write("</sheetData>");
			streamWriter.Flush();
			while ((num2 = streamReader.Read()) != -1)
			{
				streamWriter.Write((char)num2);
				stringBuilder.Append((char)num2);
			}
			streamWriter.Flush();
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002FDAB File Offset: 0x0002DFAB
		public void SetSheetOrder(string sheetname, int pos)
		{
			this.XssfWorkbook.SetSheetOrder(sheetname, pos);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0002FDBA File Offset: 0x0002DFBA
		public void SetSelectedTab(int index)
		{
			this.XssfWorkbook.SetSelectedTab(index);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		public void SetActiveSheet(int sheetIndex)
		{
			this.XssfWorkbook.SetActiveSheet(sheetIndex);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002FDD6 File Offset: 0x0002DFD6
		public string GetSheetName(int sheet)
		{
			return this.XssfWorkbook.GetSheetName(sheet);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		public void SetSheetName(int sheet, string name)
		{
			this.XssfWorkbook.SetSheetName(sheet, name);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002FDF3 File Offset: 0x0002DFF3
		public int GetSheetIndex(string name)
		{
			return this.XssfWorkbook.GetSheetIndex(name);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002FE01 File Offset: 0x0002E001
		public int GetSheetIndex(global::NPOI.SS.UserModel.ISheet sheet)
		{
			return this.XssfWorkbook.GetSheetIndex(this.GetXSSFSheet((global::NPOI.XSSF.Streaming.SXSSFSheet)sheet));
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0002FE1A File Offset: 0x0002E01A
		public global::NPOI.SS.UserModel.ISheet CreateSheet()
		{
			return this.CreateAndRegisterSXSSFSheet(this.XssfWorkbook.CreateSheet());
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002FE2D File Offset: 0x0002E02D
		public global::NPOI.SS.UserModel.ISheet CreateSheet(string sheetname)
		{
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(sheetname);
			return this.CreateAndRegisterSXSSFSheet(this.XssfWorkbook.CreateSheet(sheetname));
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002FE47 File Offset: 0x0002E047
		public global::NPOI.SS.UserModel.ISheet CloneSheet(int sheetNum)
		{
			throw new global::NPOI.Util.RuntimeException("NotImplemented");
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0002FE53 File Offset: 0x0002E053
		public global::NPOI.SS.UserModel.ISheet GetSheetAt(int index)
		{
			return this.GetSXSSFSheet((global::NPOI.XSSF.UserModel.XSSFSheet)this.XssfWorkbook.GetSheetAt(index));
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002FE6C File Offset: 0x0002E06C
		public global::NPOI.SS.UserModel.ISheet GetSheet(string name)
		{
			return this.GetSXSSFSheet((global::NPOI.XSSF.UserModel.XSSFSheet)this.XssfWorkbook.GetSheet(name));
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0002FE88 File Offset: 0x0002E088
		public void RemoveSheetAt(int index)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.XssfWorkbook.GetSheetAt(index);
			global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet = this.GetSXSSFSheet(xssfsheet);
			this.XssfWorkbook.RemoveSheetAt(index);
			this.DeregisterSheetMapping(xssfsheet);
			try
			{
				sxssfsheet.Dispose();
			}
			catch (global::System.IO.IOException exception)
			{
				global::NPOI.XSSF.Streaming.SXSSFWorkbook.logger.Log(5, exception);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> GetEnumerator()
		{
			return new global::NPOI.XSSF.Streaming.SXSSFWorkbook.SheetEnumerator<global::NPOI.XSSF.Streaming.SXSSFSheet>(this.XssfWorkbook, this);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002FEFA File Offset: 0x0002E0FA
		public global::NPOI.SS.UserModel.IFont CreateFont()
		{
			return this.XssfWorkbook.CreateFont();
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002FF08 File Offset: 0x0002E108
		[global::System.Obsolete("deprecated in poi 3.16")]
		public global::NPOI.SS.UserModel.IFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			return this.XssfWorkbook.FindFont(boldWeight, color, fontHeight, name, italic, strikeout, typeOffset, underline);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0002FF30 File Offset: 0x0002E130
		public global::NPOI.SS.UserModel.IFont FindFont(bool bold, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			return this.XssfWorkbook.FindFont(bold, color, fontHeight, name, italic, strikeout, typeOffset, underline);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0002FF55 File Offset: 0x0002E155
		public global::NPOI.SS.UserModel.IFont GetFontAt(short idx)
		{
			return this.XssfWorkbook.GetFontAt(idx);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0002FF63 File Offset: 0x0002E163
		public global::NPOI.SS.UserModel.ICellStyle CreateCellStyle()
		{
			return this.XssfWorkbook.CreateCellStyle();
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0002FF70 File Offset: 0x0002E170
		public global::NPOI.SS.UserModel.ICellStyle GetCellStyleAt(int idx)
		{
			return this.XssfWorkbook.GetCellStyleAt(idx);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0002FF80 File Offset: 0x0002E180
		public void Close()
		{
			foreach (global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet in this._xFromSxHash.Values)
			{
				try
				{
					sxssfsheet.SheetDataWriter.Close();
				}
				catch (global::System.IO.IOException exception)
				{
					global::NPOI.XSSF.Streaming.SXSSFWorkbook.logger.Log(5, "An exception occurred while closing sheet data writer for sheet " + sxssfsheet.SheetName + ".", exception);
				}
			}
			this.XssfWorkbook.Close();
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003001C File Offset: 0x0002E21C
		public void Write(global::System.IO.Stream stream)
		{
			this.FlushSheets();
			global::System.IO.FileInfo fileInfo = global::NPOI.Util.TempFile.CreateTempFile("poi-sxssf-template", ".xlsx");
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(fileInfo.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
				try
				{
					this.XssfWorkbook.Write(fileStream);
				}
				finally
				{
					fileStream.Close();
				}
				this.InjectData(fileInfo, stream);
			}
			finally
			{
				fileInfo.Delete();
				if (global::System.IO.File.Exists(fileInfo.FullName))
				{
					string str = "Could not delete temporary file after processing: ";
					global::System.IO.FileInfo fileInfo2 = fileInfo;
					throw new global::System.IO.IOException(str + ((fileInfo2 != null) ? fileInfo2.ToString() : null));
				}
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000300BC File Offset: 0x0002E2BC
		private void FlushSheets()
		{
			foreach (global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet in this._xFromSxHash.Values)
			{
				sxssfsheet.FlushRows();
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00030114 File Offset: 0x0002E314
		public bool Dispose()
		{
			bool flag = true;
			foreach (global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet in this._sxFromXHash.Keys)
			{
				try
				{
					flag = (sxssfsheet.Dispose() && flag);
				}
				catch (global::System.IO.IOException exception)
				{
					global::NPOI.XSSF.Streaming.SXSSFWorkbook.logger.Log(5, exception);
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00030190 File Offset: 0x0002E390
		public global::NPOI.SS.UserModel.IName GetName(string name)
		{
			return this.XssfWorkbook.GetName(name);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003019E File Offset: 0x0002E39E
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetNames(string name)
		{
			return this.XssfWorkbook.GetNames(name);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000301AC File Offset: 0x0002E3AC
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetAllNames()
		{
			return this._wb.GetAllNames();
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000301B9 File Offset: 0x0002E3B9
		[global::System.Obsolete("Deprecated 3.16, New projects should avoid accessing named ranges by index.")]
		public global::NPOI.SS.UserModel.IName GetNameAt(int nameIndex)
		{
			return this.XssfWorkbook.GetNameAt(nameIndex);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x000301C7 File Offset: 0x0002E3C7
		public global::NPOI.SS.UserModel.IName CreateName()
		{
			return this.XssfWorkbook.CreateName();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000301D4 File Offset: 0x0002E3D4
		[global::System.Obsolete("deprecated in 3.16 New projects should avoid accessing named ranges by index. GetName(String)} instead.")]
		public int GetNameIndex(string name)
		{
			return this.XssfWorkbook.GetNameIndex(name);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000301E2 File Offset: 0x0002E3E2
		[global::System.Obsolete("deprecated in 3.16 New projects should use RemoveName(Name)")]
		public void RemoveName(int index)
		{
			this.XssfWorkbook.RemoveName(index);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000301F0 File Offset: 0x0002E3F0
		[global::System.Obsolete("deprecated in 3.16 New projects should use RemoveName(IName Name)")]
		public void RemoveName(string name)
		{
			this.XssfWorkbook.RemoveName(name);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000301FE File Offset: 0x0002E3FE
		public void RemoveName(global::NPOI.SS.UserModel.IName name)
		{
			this._wb.RemoveName(name);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000065E4 File Offset: 0x000047E4
		public int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003020C File Offset: 0x0002E40C
		public void SetPrintArea(int sheetIndex, string reference)
		{
			this.XssfWorkbook.SetPrintArea(sheetIndex, reference);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003021B File Offset: 0x0002E41B
		public void SetPrintArea(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow)
		{
			this.XssfWorkbook.SetPrintArea(sheetIndex, startColumn, endColumn, startRow, endRow);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0003022F File Offset: 0x0002E42F
		public string GetPrintArea(int sheetIndex)
		{
			return this.XssfWorkbook.GetPrintArea(sheetIndex);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003023D File Offset: 0x0002E43D
		public void RemovePrintArea(int sheetIndex)
		{
			this.XssfWorkbook.RemovePrintArea(sheetIndex);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003024B File Offset: 0x0002E44B
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			return this.XssfWorkbook.CreateDataFormat();
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00030258 File Offset: 0x0002E458
		public int AddPicture(byte[] pictureData, global::NPOI.SS.UserModel.PictureType format)
		{
			return this.XssfWorkbook.AddPicture(pictureData, format);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00030267 File Offset: 0x0002E467
		public global::System.Collections.IList GetAllPictures()
		{
			return this.XssfWorkbook.GetAllPictures();
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00030274 File Offset: 0x0002E474
		public global::NPOI.SS.UserModel.ICreationHelper GetCreationHelper()
		{
			return new global::NPOI.XSSF.Streaming.SXSSFCreationHelper(this);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0003027C File Offset: 0x0002E47C
		public bool IsSheetHidden(int sheetIx)
		{
			return this.XssfWorkbook.IsSheetHidden(sheetIx);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003028A File Offset: 0x0002E48A
		public bool IsSheetVeryHidden(int sheetIx)
		{
			return this.XssfWorkbook.IsSheetVeryHidden(sheetIx);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00030298 File Offset: 0x0002E498
		public void SetSheetHidden(int sheetIx, global::NPOI.SS.UserModel.SheetState hidden)
		{
			this.XssfWorkbook.SetSheetHidden(sheetIx, hidden);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000302A7 File Offset: 0x0002E4A7
		public void SetSheetHidden(int sheetIx, int hidden)
		{
			this.XssfWorkbook.SetSheetHidden(sheetIx, hidden);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000302B6 File Offset: 0x0002E4B6
		public void AddToolPack(global::NPOI.SS.Formula.UDF.UDFFinder toopack)
		{
			this.XssfWorkbook.AddToolPack(toopack);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00010C53 File Offset: 0x0000EE53
		public global::NPOI.SS.SpreadsheetVersion SpreadsheetVersion
		{
			get
			{
				return global::NPOI.SS.SpreadsheetVersion.EXCEL2007;
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000302C4 File Offset: 0x0002E4C4
		public bool IsDate1904()
		{
			return this.XssfWorkbook.IsDate1904();
		}

		// Token: 0x04000400 RID: 1024
		private static readonly global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.Streaming.SXSSFWorkbook));

		// Token: 0x04000401 RID: 1025
		public const int DEFAULT_WINDOW_SIZE = 100;

		// Token: 0x04000402 RID: 1026
		private global::NPOI.XSSF.UserModel.XSSFWorkbook _wb;

		// Token: 0x04000403 RID: 1027
		private global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.Streaming.SXSSFSheet, global::NPOI.XSSF.UserModel.XSSFSheet> _sxFromXHash = new global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.Streaming.SXSSFSheet, global::NPOI.XSSF.UserModel.XSSFSheet>();

		// Token: 0x04000404 RID: 1028
		private global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.UserModel.XSSFSheet, global::NPOI.XSSF.Streaming.SXSSFSheet> _xFromSxHash = new global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.UserModel.XSSFSheet, global::NPOI.XSSF.Streaming.SXSSFSheet>();

		// Token: 0x04000405 RID: 1029
		private int _randomAccessWindowSize = 100;

		// Token: 0x04000406 RID: 1030
		private bool _compressTmpFiles;

		// Token: 0x04000407 RID: 1031
		private global::NPOI.XSSF.Model.SharedStringsTable _sharedStringSource;

		// Token: 0x0200014B RID: 331
		private class SheetEnumerator<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator where T : class, global::NPOI.SS.UserModel.ISheet
		{
			// Token: 0x06001063 RID: 4195 RVA: 0x000392E6 File Offset: 0x000374E6
			public SheetEnumerator(global::NPOI.XSSF.UserModel.XSSFWorkbook wb, global::NPOI.XSSF.Streaming.SXSSFWorkbook xwb)
			{
				this._wb = wb;
				this._xwb = xwb;
				this.it = wb.GetEnumerator();
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06001064 RID: 4196 RVA: 0x00039308 File Offset: 0x00037508
			T global::System.Collections.Generic.IEnumerator<!0>.Current
			{
				get
				{
					global::NPOI.XSSF.UserModel.XSSFSheet sheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.it.Current;
					return this._xwb.GetSXSSFSheet(sheet) as T;
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06001065 RID: 4197 RVA: 0x0003933C File Offset: 0x0003753C
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					global::NPOI.XSSF.UserModel.XSSFSheet sheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.it.Current;
					return this._xwb.GetSXSSFSheet(sheet);
				}
			}

			// Token: 0x06001066 RID: 4198 RVA: 0x00039366 File Offset: 0x00037566
			public void Dispose()
			{
				this.it.Dispose();
			}

			// Token: 0x06001067 RID: 4199 RVA: 0x00039373 File Offset: 0x00037573
			public bool MoveNext()
			{
				return this.it.MoveNext();
			}

			// Token: 0x06001068 RID: 4200 RVA: 0x00039380 File Offset: 0x00037580
			public void Reset()
			{
				this.it.Reset();
			}

			// Token: 0x04000531 RID: 1329
			private global::NPOI.XSSF.UserModel.XSSFWorkbook _wb;

			// Token: 0x04000532 RID: 1330
			private global::NPOI.XSSF.Streaming.SXSSFWorkbook _xwb;

			// Token: 0x04000533 RID: 1331
			private global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> it;
		}
	}
}
