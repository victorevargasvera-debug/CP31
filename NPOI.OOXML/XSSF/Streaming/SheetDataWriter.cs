using System;
using System.Globalization;
using System.IO;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C4 RID: 196
	public class SheetDataWriter
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0002C5F7 File Offset: 0x0002A7F7
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0002C5FF File Offset: 0x0002A7FF
		protected global::System.IO.FileInfo TemporaryFileInfo { get; set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0002C608 File Offset: 0x0002A808
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0002C610 File Offset: 0x0002A810
		private protected global::System.IO.Stream OutputStream { protected get; private set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0002C619 File Offset: 0x0002A819
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0002C621 File Offset: 0x0002A821
		private int RowNum { get; set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0002C62A File Offset: 0x0002A82A
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0002C632 File Offset: 0x0002A832
		public int NumberOfFlushedRows { get; set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0002C63B File Offset: 0x0002A83B
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0002C643 File Offset: 0x0002A843
		public int LowestIndexOfFlushedRows { get; set; } = -1;

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0002C64C File Offset: 0x0002A84C
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0002C654 File Offset: 0x0002A854
		public int NumberOfCellsOfLastFlushedRow { get; set; }

		// Token: 0x06000C2A RID: 3114 RVA: 0x0002C660 File Offset: 0x0002A860
		public SheetDataWriter()
		{
			this.TemporaryFileInfo = this.CreateTempFile();
			this.OutputStream = this.CreateWriter(this.TemporaryFileInfo);
			this._outputWriter = new global::System.IO.StreamWriter(this.OutputStream, global::System.Text.Encoding.UTF8);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002C6B5 File Offset: 0x0002A8B5
		public SheetDataWriter(global::NPOI.XSSF.Model.SharedStringsTable sharedStringsTable) : this()
		{
			this._sharedStringSource = sharedStringsTable;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		public virtual global::System.IO.FileInfo CreateTempFile()
		{
			return global::NPOI.Util.TempFile.CreateTempFile("poi-sxssf-sheet", ".xml");
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
		public virtual global::System.IO.Stream CreateWriter(global::System.IO.FileInfo fd)
		{
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(fd.FullName, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			global::System.IO.Stream result = null;
			try
			{
				result = this.DecorateOutputStream(fileStream);
			}
			catch (global::System.Exception)
			{
				fileStream.Close();
				throw;
			}
			return result;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00010684 File Offset: 0x0000E884
		protected virtual global::System.IO.Stream DecorateOutputStream(global::System.IO.Stream fos)
		{
			return fos;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0002C71C File Offset: 0x0002A91C
		public void Close()
		{
			try
			{
				this._outputWriter.Flush();
				this.OutputStream.Flush();
			}
			catch (global::System.Exception)
			{
			}
			try
			{
				this.OutputStream.Close();
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0002C774 File Offset: 0x0002A974
		public global::System.IO.FileInfo TempFileInfo
		{
			get
			{
				return this.TemporaryFileInfo;
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0002C77C File Offset: 0x0002A97C
		public global::System.IO.Stream GetWorksheetXmlInputStream()
		{
			global::System.IO.Stream stream = new global::System.IO.FileStream(this.TemporaryFileInfo.FullName, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			global::System.IO.Stream result;
			try
			{
				result = this.DecorateInputStream(stream);
			}
			catch (global::System.IO.IOException)
			{
				stream.Close();
				throw;
			}
			return result;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00010684 File Offset: 0x0000E884
		protected virtual global::System.IO.Stream DecorateInputStream(global::System.IO.Stream fis)
		{
			return fis;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		protected void FinalizeWriter()
		{
			this.TemporaryFileInfo.Delete();
			if (global::System.IO.File.Exists(this.TemporaryFileInfo.FullName))
			{
				global::NPOI.Util.POILogger poilogger = global::NPOI.XSSF.Streaming.SheetDataWriter.logger;
				int level = 7;
				string str = "Can't delete temporary encryption file: ";
				global::System.IO.FileInfo temporaryFileInfo = this.TemporaryFileInfo;
				poilogger.Log(level, str + ((temporaryFileInfo != null) ? temporaryFileInfo.ToString() : null));
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0002C814 File Offset: 0x0002AA14
		public void WriteRow(int rownum, global::NPOI.XSSF.Streaming.SXSSFRow row)
		{
			this.BeginRow(rownum, row);
			using (global::NPOI.XSSF.Streaming.SXSSFRow.CellIterator cellIterator = row.AllCellsIterator())
			{
				int num = 0;
				while (cellIterator.MoveNext())
				{
					global::NPOI.SS.UserModel.ICell cell = cellIterator.Current;
					this.WriteCell(num++, cell);
				}
				this.EndRow();
			}
			if (this.LowestIndexOfFlushedRows == -1 || this.LowestIndexOfFlushedRows > rownum)
			{
				this.LowestIndexOfFlushedRows = rownum;
				int numberOfFlushedRows = this.NumberOfFlushedRows;
				this.NumberOfFlushedRows = numberOfFlushedRows + 1;
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0002C898 File Offset: 0x0002AA98
		public void FlushRows(int rowCount, int lastRowNum, int lastRowCellsCount)
		{
			this.NumberLastFlushedRow = global::System.Math.Max(lastRowNum, this.NumberLastFlushedRow);
			this.NumberOfCellsOfLastFlushedRow = lastRowCellsCount;
			this._outputWriter.Flush();
			this.OutputStream.Flush();
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0002C8CC File Offset: 0x0002AACC
		private void BeginRow(int rownum, global::NPOI.XSSF.Streaming.SXSSFRow row)
		{
			this.WriteAsBytes("<row r=\"");
			this.WriteAsBytes(rownum + 1);
			this.WriteAsBytes("\"");
			if (row.HasCustomHeight())
			{
				this.WriteAsBytes(" customHeight=\"true\"  ht=\"");
				this.WriteAsBytes(row.HeightInPoints);
				this.WriteAsBytes("\"");
			}
			if (row.ZeroHeight)
			{
				this.WriteAsBytes(" hidden=\"true\"");
			}
			if (row.IsFormatted)
			{
				this.WriteAsBytes(" s=\"");
				this.WriteAsBytes((int)row.RowStyle.Index);
				this.WriteAsBytes("\"");
				this.WriteAsBytes(" customFormat=\"1\"");
			}
			if (row.OutlineLevel != 0)
			{
				this.WriteAsBytes(" outlineLevel=\"");
				this.WriteAsBytes(row.OutlineLevel);
				this.WriteAsBytes("\"");
			}
			if (row.Hidden != null)
			{
				this.WriteAsBytes(" hidden=\"");
				this.WriteAsBytes(row.Hidden.Value ? "1" : "0");
				this.WriteAsBytes("\"");
			}
			if (row.Collapsed != null)
			{
				this.WriteAsBytes(" collapsed=\"");
				this.WriteAsBytes(row.Collapsed.Value ? "1" : "0");
				this.WriteAsBytes("\"");
			}
			this.WriteAsBytes(">\n");
			this.RowNum = rownum;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0002CA3B File Offset: 0x0002AC3B
		private void EndRow()
		{
			this.WriteAsBytes("</row>\n");
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0002CA48 File Offset: 0x0002AC48
		public void WriteCell(int columnIndex, global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return;
			}
			string text = new global::NPOI.SS.Util.CellReference(this.RowNum, columnIndex).FormatAsString();
			this.WriteAsBytes("<c r=\"");
			this.WriteAsBytes(text);
			this.WriteAsBytes("\"");
			if (cell.CellStyle.Index != 0)
			{
				this.WriteAsBytes(" s=\"");
				this.WriteAsBytes((int)cell.CellStyle.Index & 65535);
				this.WriteAsBytes("\"");
			}
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				this.WriteAsBytes(" t=\"n\">");
				this.WriteAsBytes("<v>");
				this.WriteAsBytes(cell.NumericCellValue);
				this.WriteAsBytes("</v>");
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				if (this._sharedStringSource != null)
				{
					global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(cell.StringCellValue);
					int value = this._sharedStringSource.AddEntry(xssfrichTextString.GetCTRst());
					this.WriteAsBytes(" t=\"");
					this.WriteAsBytes("s");
					this.WriteAsBytes("\">");
					this.WriteAsBytes("<v>");
					this.WriteAsBytes(value);
					this.WriteAsBytes("</v>");
				}
				else
				{
					this.WriteAsBytes(" t=\"inlineStr\">");
					this.WriteAsBytes("<is><t");
					if (this.HasLeadingTrailingSpaces(cell.StringCellValue))
					{
						this.WriteAsBytes(" xml:space=\"preserve\"");
					}
					this.WriteAsBytes(">");
					this.OutputQuotedString(cell.StringCellValue);
					this.WriteAsBytes("</t></is>");
				}
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				this.WriteAsBytes(">");
				this.WriteAsBytes("<f>");
				this.OutputQuotedString(cell.CellFormula);
				this.WriteAsBytes("</f>");
				if (cell.GetCachedFormulaResultTypeEnum() == global::NPOI.SS.UserModel.CellType.Numeric)
				{
					double numericCellValue = cell.NumericCellValue;
					if (!double.IsNaN(numericCellValue))
					{
						this.WriteAsBytes("<v>");
						this.WriteAsBytes(numericCellValue);
						this.WriteAsBytes("</v>");
					}
				}
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				this.WriteAsBytes(">");
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				this.WriteAsBytes(" t=\"b\">");
				this.WriteAsBytes("<v>");
				this.WriteAsBytes(cell.BooleanCellValue ? "1" : "0");
				this.WriteAsBytes("</v>");
				break;
			case global::NPOI.SS.UserModel.CellType.Error:
			{
				global::NPOI.SS.UserModel.FormulaError formulaError = global::NPOI.SS.UserModel.FormulaError.ForInt(cell.ErrorCellValue);
				this.WriteAsBytes(" t=\"e\">");
				this.WriteAsBytes("<v>");
				this.WriteAsBytes(formulaError.String);
				this.WriteAsBytes("</v>");
				break;
			}
			default:
				throw new global::System.InvalidOperationException("Invalid cell type: " + cell.CellType.ToString());
			}
			this.WriteAsBytes("</c>");
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0002CD05 File Offset: 0x0002AF05
		private void WriteAsBytes(string text)
		{
			this._outputWriter.Write(text);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0002CD13 File Offset: 0x0002AF13
		private void WriteAsBytes(global::System.ArraySegment<char> chars)
		{
			this._outputWriter.Write(chars.Array, chars.Offset, chars.Count);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002CD35 File Offset: 0x0002AF35
		private void WriteAsBytes(int value)
		{
			this._outputWriter.Write(value);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0002CD43 File Offset: 0x0002AF43
		private void WriteAsBytes(float value)
		{
			this._outputWriter.Write(value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		private void WriteAsBytes(double value)
		{
			this._outputWriter.Write(value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002CD78 File Offset: 0x0002AF78
		private bool HasLeadingTrailingSpaces(string str)
		{
			if (!string.IsNullOrEmpty(str))
			{
				char src = str[0];
				char src2 = str[str.Length - 1];
				return global::NPOI.Util.Character.isWhitespace(src) || global::NPOI.Util.Character.isWhitespace(src2);
			}
			return false;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		protected void OutputQuotedString(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return;
			}
			char[] array = s.ToCharArray();
			int num = 0;
			int length = s.Length;
			int i = 0;
			while (i < length)
			{
				char c = array[i];
				if (c <= '&')
				{
					switch (c)
					{
					case '\t':
						if (i > num)
						{
							this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
						}
						this.WriteAsBytes("&#x9;");
						num = i + 1;
						break;
					case '\n':
					case '\r':
						if (i > num)
						{
							this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
						}
						this.WriteAsBytes("&#xa;");
						num = i + 1;
						break;
					case '\v':
					case '\f':
						goto IL_192;
					default:
						if (c != '"')
						{
							if (c != '&')
							{
								goto IL_192;
							}
							if (i > num)
							{
								this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
							}
							num = i + 1;
							this.WriteAsBytes("&amp;");
						}
						else
						{
							if (i > num)
							{
								this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
							}
							num = i + 1;
							this.WriteAsBytes("&quot;");
						}
						break;
					}
				}
				else if (c != '<')
				{
					if (c != '>')
					{
						if (c != '\u00a0')
						{
							goto IL_192;
						}
						if (i > num)
						{
							this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
						}
						this.WriteAsBytes("&#xa0;");
						num = i + 1;
					}
					else
					{
						if (i > num)
						{
							this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
						}
						num = i + 1;
						this.WriteAsBytes("&gt;");
					}
				}
				else
				{
					if (i > num)
					{
						this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
					}
					num = i + 1;
					this.WriteAsBytes("&lt;");
				}
				IL_214:
				i++;
				continue;
				IL_192:
				if (c < ' ' || char.IsLowSurrogate(c) || char.IsHighSurrogate(c) || '￾' <= c)
				{
					if (i > num)
					{
						this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
					}
					this.WriteAsBytes("?");
					num = i + 1;
					goto IL_214;
				}
				if (c > '\u007f')
				{
					if (i > num)
					{
						this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, i - num));
					}
					num = i + 1;
					this.WriteAsBytes("&#");
					this.WriteAsBytes((int)c);
					this.WriteAsBytes(";");
					goto IL_214;
				}
				goto IL_214;
			}
			if (num < length)
			{
				this.WriteAsBytes(global::NPOI.XSSF.Streaming.SheetDataWriter.GetSubArray(array, num, length - num));
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
		private static global::System.ArraySegment<char> GetSubArray(char[] oldArray, int skip, int take)
		{
			return new global::System.ArraySegment<char>(oldArray, skip, take);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0002D000 File Offset: 0x0002B200
		public bool Dispose()
		{
			bool result;
			try
			{
				this.OutputStream.Close();
			}
			finally
			{
				this.TemporaryFileInfo.Delete();
				result = !global::System.IO.File.Exists(this.TemporaryFileInfo.FullName);
				this.TemporaryFileInfo.Refresh();
			}
			return result;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0002D058 File Offset: 0x0002B258
		public string TemporaryFilePath()
		{
			if (this.TemporaryFileInfo != null)
			{
				return this.TemporaryFileInfo.FullName;
			}
			return string.Empty;
		}

		// Token: 0x040003D3 RID: 979
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.Streaming.SheetDataWriter));

		// Token: 0x040003DA RID: 986
		public int NumberLastFlushedRow = -1;

		// Token: 0x040003DB RID: 987
		private global::NPOI.XSSF.Model.SharedStringsTable _sharedStringSource;

		// Token: 0x040003DC RID: 988
		private global::System.IO.StreamWriter _outputWriter;
	}
}
