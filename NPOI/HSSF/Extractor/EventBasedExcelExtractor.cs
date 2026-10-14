using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using NPOI.HPSF;
using NPOI.HSSF.EventUserModel;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.Extractor
{
	// Token: 0x020004F5 RID: 1269
	public class EventBasedExcelExtractor : global::NPOI.POIOLE2TextExtractor
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x00090528 File Offset: 0x0008E728
		public EventBasedExcelExtractor(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : base(null)
		{
			this.fs = fs;
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x0009053F File Offset: 0x0008E73F
		public override global::NPOI.HPSF.DocumentSummaryInformation DocSummaryInformation
		{
			get
			{
				throw new global::System.NotImplementedException("Metadata extraction not supported in streaming mode, please use ExcelExtractor");
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x0009053F File Offset: 0x0008E73F
		public override global::NPOI.HPSF.SummaryInformation SummaryInformation
		{
			get
			{
				throw new global::System.NotImplementedException("Metadata extraction not supported in streaming mode, please use ExcelExtractor");
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0009054B File Offset: 0x0008E74B
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x00090553 File Offset: 0x0008E753
		public bool IncludeSheetNames
		{
			get
			{
				return this.includeSheetNames;
			}
			set
			{
				this.includeSheetNames = value;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x0009055C File Offset: 0x0008E75C
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00090564 File Offset: 0x0008E764
		public bool FormulasNotResults
		{
			get
			{
				return this.formulasNotResults;
			}
			set
			{
				this.formulasNotResults = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x00090570 File Offset: 0x0008E770
		public override string Text
		{
			get
			{
				string text = null;
				try
				{
					text = this.TriggerExtraction().text.ToString();
					if (!text.EndsWith("\n", global::System.StringComparison.Ordinal))
					{
						text += "\n";
					}
				}
				catch (global::System.IO.IOException)
				{
					throw;
				}
				return text;
			}
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000905C0 File Offset: 0x0008E7C0
		private global::NPOI.HSSF.Extractor.EventBasedExcelExtractor.TextListener TriggerExtraction()
		{
			global::NPOI.HSSF.Extractor.EventBasedExcelExtractor.TextListener textListener = new global::NPOI.HSSF.Extractor.EventBasedExcelExtractor.TextListener(this.includeSheetNames, this.formulasNotResults);
			global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener formatTrackingHSSFListener = new global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener(textListener);
			textListener.ft = formatTrackingHSSFListener;
			global::NPOI.HSSF.EventUserModel.HSSFEventFactory hssfeventFactory = new global::NPOI.HSSF.EventUserModel.HSSFEventFactory();
			global::NPOI.HSSF.EventUserModel.HSSFRequest hssfrequest = new global::NPOI.HSSF.EventUserModel.HSSFRequest();
			hssfrequest.AddListenerForAllRecords(formatTrackingHSSFListener);
			hssfeventFactory.ProcessWorkbookEvents(hssfrequest, this.fs);
			return textListener;
		}

		// Token: 0x04001556 RID: 5462
		private global::NPOI.POIFS.FileSystem.POIFSFileSystem fs;

		// Token: 0x04001557 RID: 5463
		private bool includeSheetNames = true;

		// Token: 0x04001558 RID: 5464
		private bool formulasNotResults;

		// Token: 0x02000626 RID: 1574
		private class TextListener : global::NPOI.HSSF.EventUserModel.IHSSFListener
		{
			// Token: 0x060036D5 RID: 14037 RVA: 0x000A74FE File Offset: 0x000A56FE
			public TextListener(bool includeSheetNames, bool formulasNotResults)
			{
				this.includeSheetNames = includeSheetNames;
				this.formulasNotResults = formulasNotResults;
			}

			// Token: 0x060036D6 RID: 14038 RVA: 0x000A7538 File Offset: 0x000A5738
			public void ProcessRecord(global::NPOI.HSSF.Record.Record record)
			{
				string text = null;
				int num = -1;
				short sid = record.Sid;
				if (sid <= 133)
				{
					if (sid != 6)
					{
						if (sid != 28)
						{
							if (sid == 133)
							{
								global::NPOI.HSSF.Record.BoundSheetRecord boundSheetRecord = (global::NPOI.HSSF.Record.BoundSheetRecord)record;
								this.sheetNames.Add(boundSheetRecord.Sheetname);
							}
						}
						else
						{
							num = ((global::NPOI.HSSF.Record.NoteRecord)record).Row;
						}
					}
					else
					{
						global::NPOI.HSSF.Record.FormulaRecord formulaRecord = (global::NPOI.HSSF.Record.FormulaRecord)record;
						num = formulaRecord.Row;
						if (this.formulasNotResults)
						{
							text = global::NPOI.HSSF.Model.HSSFFormulaParser.ToFormulaString(null, formulaRecord.ParsedExpression);
						}
						else if (formulaRecord.HasCachedResultString)
						{
							this.outputNextStringValue = true;
							this.nextRow = formulaRecord.Row;
						}
						else
						{
							text = this.FormatNumberDateCell(formulaRecord, formulaRecord.Value);
						}
					}
				}
				else if (sid <= 253)
				{
					if (sid != 252)
					{
						if (sid == 253)
						{
							global::NPOI.HSSF.Record.LabelSSTRecord labelSSTRecord = (global::NPOI.HSSF.Record.LabelSSTRecord)record;
							num = labelSSTRecord.Row;
							if (this.sstRecord == null)
							{
								throw new global::System.Exception("No SST record found");
							}
							text = this.sstRecord.GetString(labelSSTRecord.SSTIndex).ToString();
						}
					}
					else
					{
						this.sstRecord = (global::NPOI.HSSF.Record.SSTRecord)record;
					}
				}
				else
				{
					switch (sid)
					{
					case 515:
					{
						global::NPOI.HSSF.Record.NumberRecord numberRecord = (global::NPOI.HSSF.Record.NumberRecord)record;
						num = numberRecord.Row;
						text = this.FormatNumberDateCell(numberRecord, numberRecord.Value);
						break;
					}
					case 516:
					{
						global::NPOI.HSSF.Record.LabelRecord labelRecord = (global::NPOI.HSSF.Record.LabelRecord)record;
						num = labelRecord.Row;
						text = labelRecord.Value;
						break;
					}
					case 517:
					case 518:
						break;
					case 519:
						if (this.outputNextStringValue)
						{
							text = ((global::NPOI.HSSF.Record.StringRecord)record).String;
							num = this.nextRow;
							this.outputNextStringValue = false;
						}
						break;
					default:
						if (sid == 2057)
						{
							if (((global::NPOI.HSSF.Record.BOFRecord)record).Type == global::NPOI.HSSF.Record.BOFRecordType.Worksheet)
							{
								this.sheetNum++;
								this.rowNum = -1;
								if (this.includeSheetNames)
								{
									if (this.text.Length > 0)
									{
										this.text.Append("\n");
									}
									this.text.Append(this.sheetNames[this.sheetNum]);
								}
							}
						}
						break;
					}
				}
				if (text != null)
				{
					if (num != this.rowNum)
					{
						this.rowNum = num;
						if (this.text.Length > 0)
						{
							this.text.Append("\n");
						}
					}
					else
					{
						this.text.Append("\t");
					}
					this.text.Append(text);
				}
			}

			// Token: 0x060036D7 RID: 14039 RVA: 0x000A77C8 File Offset: 0x000A59C8
			private string FormatNumberDateCell(global::NPOI.HSSF.Record.CellValueRecordInterface cell, double value)
			{
				int formatIndex = this.ft.GetFormatIndex(cell);
				string text = this.ft.GetFormatString(cell);
				if (text == null)
				{
					return value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
				if (global::NPOI.SS.UserModel.DateUtil.IsADateFormat(formatIndex, text) && global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(value))
				{
					text = text.Replace('m', 'M');
					text = text.Replace("\\\\-", "-");
					global::System.DateTime javaDate = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(value, false);
					return new global::NPOI.SS.Util.SimpleDateFormat(text).Format(javaDate, global::System.Globalization.CultureInfo.CurrentCulture);
				}
				if (text == "General")
				{
					return value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
				return new global::NPOI.SS.Util.DecimalFormat(text).Format(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}

			// Token: 0x04001AAF RID: 6831
			public global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener ft;

			// Token: 0x04001AB0 RID: 6832
			private global::NPOI.HSSF.Record.SSTRecord sstRecord;

			// Token: 0x04001AB1 RID: 6833
			private global::System.Collections.IList sheetNames = new global::System.Collections.ArrayList();

			// Token: 0x04001AB2 RID: 6834
			public global::System.Text.StringBuilder text = new global::System.Text.StringBuilder();

			// Token: 0x04001AB3 RID: 6835
			private int sheetNum = -1;

			// Token: 0x04001AB4 RID: 6836
			private int rowNum;

			// Token: 0x04001AB5 RID: 6837
			private bool outputNextStringValue;

			// Token: 0x04001AB6 RID: 6838
			private int nextRow = -1;

			// Token: 0x04001AB7 RID: 6839
			private bool includeSheetNames;

			// Token: 0x04001AB8 RID: 6840
			private bool formulasNotResults;
		}
	}
}
