using System;
using System.Collections.Generic;
using System.Globalization;
using NPOI.HSSF.Record;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x02000347 RID: 839
	public class FormatTrackingHSSFListener : global::NPOI.HSSF.EventUserModel.IHSSFListener
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x0004CEB7 File Offset: 0x0004B0B7
		public FormatTrackingHSSFListener(global::NPOI.HSSF.EventUserModel.IHSSFListener childListener)
		{
			this.childListener = childListener;
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0004CEE7 File Offset: 0x0004B0E7
		public int NumberOfCustomFormats
		{
			get
			{
				return this.customFormatRecords.Count;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0004CEF4 File Offset: 0x0004B0F4
		public int NumberOfExtendedFormats
		{
			get
			{
				return this.xfRecords.Count;
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0004CF01 File Offset: 0x0004B101
		public void ProcessRecord(global::NPOI.HSSF.Record.Record record)
		{
			this.ProcessRecordInternally(record);
			this.childListener.ProcessRecord(record);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0004CF18 File Offset: 0x0004B118
		public void ProcessRecordInternally(global::NPOI.HSSF.Record.Record record)
		{
			if (record is global::NPOI.HSSF.Record.FormatRecord)
			{
				global::NPOI.HSSF.Record.FormatRecord formatRecord = (global::NPOI.HSSF.Record.FormatRecord)record;
				this.customFormatRecords[formatRecord.IndexCode] = formatRecord;
				return;
			}
			if (record is global::NPOI.HSSF.Record.ExtendedFormatRecord)
			{
				global::NPOI.HSSF.Record.ExtendedFormatRecord item = (global::NPOI.HSSF.Record.ExtendedFormatRecord)record;
				this.xfRecords.Add(item);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0004CF64 File Offset: 0x0004B164
		public string FormatNumberDateCell(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			double value;
			if (cell is global::NPOI.HSSF.Record.NumberRecord)
			{
				value = ((global::NPOI.HSSF.Record.NumberRecord)cell).Value;
			}
			else
			{
				if (!(cell is global::NPOI.HSSF.Record.FormulaRecord))
				{
					throw new global::System.ArgumentException("Unsupported CellValue Record passed in " + ((cell != null) ? cell.ToString() : null));
				}
				value = ((global::NPOI.HSSF.Record.FormulaRecord)cell).Value;
			}
			int formatIndex = this.GetFormatIndex(cell);
			string formatString = this.GetFormatString(cell);
			if (formatString == null)
			{
				return value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return this.formatter.FormatRawCellContents(value, formatIndex, formatString);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0004CFE8 File Offset: 0x0004B1E8
		public string GetFormatString(int formatIndex)
		{
			string result = null;
			if (formatIndex >= global::NPOI.HSSF.UserModel.HSSFDataFormat.NumberOfBuiltinBuiltinFormats)
			{
				global::NPOI.HSSF.Record.FormatRecord formatRecord = this.customFormatRecords[formatIndex];
				if (formatRecord == null)
				{
					global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener.logger.Log(7, "Requested format at index " + formatIndex.ToString() + ", but it wasn't found");
				}
				else
				{
					result = formatRecord.FormatString;
				}
			}
			else
			{
				result = global::NPOI.HSSF.UserModel.HSSFDataFormat.GetBuiltinFormat((short)formatIndex);
			}
			return result;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0004D044 File Offset: 0x0004B244
		public string GetFormatString(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			int formatIndex = this.GetFormatIndex(cell);
			if (formatIndex == -1)
			{
				return null;
			}
			return this.GetFormatString(formatIndex);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0004D068 File Offset: 0x0004B268
		public int GetFormatIndex(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			global::NPOI.HSSF.Record.ExtendedFormatRecord extendedFormatRecord = this.xfRecords[(int)cell.XFIndex];
			if (extendedFormatRecord == null)
			{
				global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener.logger.Log(7, string.Concat(new string[]
				{
					"Cell ",
					cell.Row.ToString(),
					",",
					cell.Column.ToString(),
					" uses XF with index ",
					cell.XFIndex.ToString(),
					", but we don't have that"
				}));
				return -1;
			}
			return (int)extendedFormatRecord.FormatIndex;
		}

		// Token: 0x040009FC RID: 2556
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.EventUserModel.FormatTrackingHSSFListener));

		// Token: 0x040009FD RID: 2557
		private global::NPOI.HSSF.EventUserModel.IHSSFListener childListener;

		// Token: 0x040009FE RID: 2558
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.FormatRecord> customFormatRecords = new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.FormatRecord>();

		// Token: 0x040009FF RID: 2559
		private global::NPOI.SS.UserModel.DataFormatter formatter = new global::NPOI.SS.UserModel.DataFormatter();

		// Token: 0x04000A00 RID: 2560
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ExtendedFormatRecord> xfRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ExtendedFormatRecord>();
	}
}
