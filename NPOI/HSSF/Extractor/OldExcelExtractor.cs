using System;
using System.IO;
using System.Text;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Extractor
{
	// Token: 0x020004F4 RID: 1268
	public class OldExcelExtractor
	{
		// Token: 0x06002FA2 RID: 12194 RVA: 0x0009000C File Offset: 0x0008E20C
		public OldExcelExtractor(global::System.IO.Stream input)
		{
			this.Open(input);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0009001C File Offset: 0x0008E21C
		public OldExcelExtractor(global::System.IO.FileInfo f)
		{
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = null;
			try
			{
				npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(f);
				this.toClose = npoifsfileSystem;
				this.Open(npoifsfileSystem);
				return;
			}
			catch (global::NPOI.HSSF.OldExcelFormatException)
			{
				if (npoifsfileSystem != null)
				{
					npoifsfileSystem.Close();
				}
			}
			catch (global::NPOI.POIFS.FileSystem.NotOLE2FileException)
			{
				if (npoifsfileSystem != null)
				{
					npoifsfileSystem.Close();
				}
			}
			global::System.IO.FileStream fileStream = f.OpenRead();
			try
			{
				this.Open(fileStream);
			}
			catch (global::System.IO.IOException ex)
			{
				fileStream.Close();
				throw ex;
			}
			catch (global::NPOI.Util.RuntimeException ex2)
			{
				fileStream.Close();
				throw ex2;
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000900B4 File Offset: 0x0008E2B4
		public OldExcelExtractor(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			this.Open(fs);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000900C3 File Offset: 0x0008E2C3
		public OldExcelExtractor(global::NPOI.POIFS.FileSystem.DirectoryNode directory)
		{
			this.Open(directory);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000900D4 File Offset: 0x0008E2D4
		private void Open(global::System.IO.Stream biffStream)
		{
			global::System.IO.BufferedStream bufferedStream = (biffStream is global::System.IO.BufferedStream) ? ((global::System.IO.BufferedStream)biffStream) : new global::System.IO.BufferedStream(biffStream, 8);
			if (global::NPOI.POIFS.FileSystem.NPOIFSFileSystem.HasPOIFSHeader(bufferedStream))
			{
				global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(bufferedStream);
				try
				{
					this.Open(npoifsfileSystem);
					return;
				}
				finally
				{
					npoifsfileSystem.Close();
				}
			}
			this.ris = new global::NPOI.HSSF.Record.RecordInputStream(bufferedStream);
			this.toCloseStream = bufferedStream;
			this.Prepare();
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00090144 File Offset: 0x0008E344
		private void Open(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			this.Open(fs.Root);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00090154 File Offset: 0x0008E354
		private void Open(global::NPOI.POIFS.FileSystem.DirectoryNode directory)
		{
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode;
			try
			{
				documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)directory.GetEntry(global::NPOI.HSSF.Model.InternalWorkbook.OLD_WORKBOOK_DIR_ENTRY_NAME);
			}
			catch (global::System.IO.FileNotFoundException)
			{
				documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)directory.GetEntry(global::NPOI.HSSF.Model.InternalWorkbook.WORKBOOK_DIR_ENTRY_NAMES[0]);
			}
			if (documentNode == null)
			{
				throw new global::System.IO.IOException("No Excel 5/95 Book stream found");
			}
			this.ris = new global::NPOI.HSSF.Record.RecordInputStream(directory.CreateDocumentInputStream(documentNode));
			this.Prepare();
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000901C0 File Offset: 0x0008E3C0
		public static void main(string[] args)
		{
			if (args.Length < 1)
			{
				global::System.Console.WriteLine("Use:");
				global::System.Console.WriteLine("   OldExcelExtractor <filename>");
				return;
			}
			global::NPOI.HSSF.Extractor.OldExcelExtractor oldExcelExtractor = new global::NPOI.HSSF.Extractor.OldExcelExtractor(new global::System.IO.FileInfo(args[0]));
			global::System.Console.WriteLine(oldExcelExtractor.Text);
			oldExcelExtractor.Close();
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000901FC File Offset: 0x0008E3FC
		private void Prepare()
		{
			if (!this.ris.HasNextRecord)
			{
				throw new global::System.ArgumentException("File Contains no records!");
			}
			this.ris.NextRecord();
			int sid = (int)this.ris.Sid;
			if (sid <= 521)
			{
				if (sid == 9)
				{
					this.biffVersion = 2;
					goto IL_93;
				}
				if (sid == 521)
				{
					this.biffVersion = 3;
					goto IL_93;
				}
			}
			else
			{
				if (sid == 1033)
				{
					this.biffVersion = 4;
					goto IL_93;
				}
				if (sid == 2057)
				{
					this.biffVersion = 5;
					goto IL_93;
				}
			}
			throw new global::System.ArgumentException("File does not begin with a BOF, found sid of " + sid.ToString());
			IL_93:
			global::NPOI.HSSF.Record.BOFRecord bofrecord = new global::NPOI.HSSF.Record.BOFRecord(this.ris);
			this.fileType = (int)bofrecord.Type;
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x000902B4 File Offset: 0x0008E4B4
		public int BiffVersion
		{
			get
			{
				return this.biffVersion;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x000902BC File Offset: 0x0008E4BC
		public int FileType
		{
			get
			{
				return this.fileType;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x000902C4 File Offset: 0x0008E4C4
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::NPOI.HSSF.Record.CodepageRecord codePage = null;
				while (this.ris.HasNextRecord)
				{
					int nextSid = this.ris.GetNextSid();
					this.ris.NextRecord();
					if (nextSid <= 133)
					{
						switch (nextSid)
						{
						case 4:
							break;
						case 5:
							goto IL_1D0;
						case 6:
							goto IL_150;
						case 7:
							goto IL_FF;
						default:
						{
							if (nextSid == 66)
							{
								codePage = new global::NPOI.HSSF.Record.CodepageRecord(this.ris);
								continue;
							}
							if (nextSid != 133)
							{
								goto IL_1D0;
							}
							global::NPOI.HSSF.Record.OldSheetRecord oldSheetRecord = new global::NPOI.HSSF.Record.OldSheetRecord(this.ris);
							oldSheetRecord.SetCodePage(codePage);
							stringBuilder.Append("Sheet: ");
							stringBuilder.Append(oldSheetRecord.Sheetname);
							stringBuilder.Append('\n');
							continue;
						}
						}
					}
					else
					{
						switch (nextSid)
						{
						case 515:
						{
							global::NPOI.HSSF.Record.NumberRecord numberRecord = new global::NPOI.HSSF.Record.NumberRecord(this.ris);
							this.handleNumericCell(stringBuilder, numberRecord.Value);
							continue;
						}
						case 516:
							break;
						case 517:
							goto IL_1D0;
						case 518:
							goto IL_150;
						case 519:
							goto IL_FF;
						default:
							if (nextSid == 638)
							{
								global::NPOI.HSSF.Record.RKRecord rkrecord = new global::NPOI.HSSF.Record.RKRecord(this.ris);
								this.handleNumericCell(stringBuilder, rkrecord.RKNumber);
								continue;
							}
							if (nextSid != 1030)
							{
								goto IL_1D0;
							}
							goto IL_150;
						}
					}
					global::NPOI.HSSF.Record.OldLabelRecord oldLabelRecord = new global::NPOI.HSSF.Record.OldLabelRecord(this.ris);
					oldLabelRecord.SetCodePage(codePage);
					stringBuilder.Append(oldLabelRecord.Value);
					stringBuilder.Append('\n');
					continue;
					IL_FF:
					global::NPOI.HSSF.Record.OldStringRecord oldStringRecord = new global::NPOI.HSSF.Record.OldStringRecord(this.ris);
					oldStringRecord.SetCodePage(codePage);
					stringBuilder.Append(oldStringRecord.GetString());
					stringBuilder.Append('\n');
					continue;
					IL_150:
					if (this.biffVersion == 5)
					{
						global::NPOI.HSSF.Record.FormulaRecord formulaRecord = new global::NPOI.HSSF.Record.FormulaRecord(this.ris);
						if (formulaRecord.CachedResultType == global::NPOI.SS.UserModel.CellType.Numeric)
						{
							this.handleNumericCell(stringBuilder, formulaRecord.Value);
							continue;
						}
						continue;
					}
					else
					{
						global::NPOI.HSSF.Record.OldFormulaRecord oldFormulaRecord = new global::NPOI.HSSF.Record.OldFormulaRecord(this.ris);
						if (oldFormulaRecord.GetCachedResultType() == global::NPOI.SS.UserModel.CellType.Numeric)
						{
							this.handleNumericCell(stringBuilder, oldFormulaRecord.Value);
							continue;
						}
						continue;
					}
					IL_1D0:
					this.ris.ReadFully(new byte[this.ris.Remaining]);
				}
				this.Close();
				this.ris = null;
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x000904DF File Offset: 0x0008E6DF
		protected void handleNumericCell(global::System.Text.StringBuilder text, double value)
		{
			text.Append(value);
			text.Append('\n');
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000904F2 File Offset: 0x0008E6F2
		public void Close()
		{
			if (this.toClose != null)
			{
				global::NPOI.Util.IOUtils.CloseQuietly(this.toClose);
				this.toClose = null;
			}
			if (this.toCloseStream != null)
			{
				global::NPOI.Util.IOUtils.CloseQuietly(this.toCloseStream);
				this.toClose = null;
			}
		}

		// Token: 0x04001551 RID: 5457
		private global::NPOI.HSSF.Record.RecordInputStream ris;

		// Token: 0x04001552 RID: 5458
		private global::NPOI.Util.ICloseable toClose;

		// Token: 0x04001553 RID: 5459
		private global::System.IO.Stream toCloseStream;

		// Token: 0x04001554 RID: 5460
		private int biffVersion;

		// Token: 0x04001555 RID: 5461
		private int fileType;
	}
}
