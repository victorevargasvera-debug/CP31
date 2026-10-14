using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D3 RID: 1235
	public class PageSettingsBlock : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002EE3 RID: 12003 RVA: 0x0008B016 File Offset: 0x00089216
		public PageSettingsBlock(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._plsRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.PLSAggregate>();
			while (this.ReadARecord(rs))
			{
			}
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x0008B040 File Offset: 0x00089240
		public PageSettingsBlock()
		{
			this._plsRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.PLSAggregate>();
			this._rowBreaksRecord = new global::NPOI.HSSF.Record.HorizontalPageBreakRecord();
			this._columnBreaksRecord = new global::NPOI.HSSF.Record.VerticalPageBreakRecord();
			this.header = new global::NPOI.HSSF.Record.HeaderRecord(string.Empty);
			this.footer = new global::NPOI.HSSF.Record.FooterRecord(string.Empty);
			this._hCenter = global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.CreateHCenter();
			this._vCenter = global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.CreateVCenter();
			this.printSetup = global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.CreatePrintSetup();
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x0008B0C0 File Offset: 0x000892C0
		public static bool IsComponentRecord(int sid)
		{
			if (sid <= 51)
			{
				if (sid <= 27)
				{
					if (sid - 20 > 1 && sid - 26 > 1)
					{
						return false;
					}
				}
				else if (sid - 38 > 3 && sid != 51)
				{
					return false;
				}
			}
			else if (sid <= 132)
			{
				if (sid != 77 && sid - 131 > 1)
				{
					return false;
				}
			}
			else if (sid != 161 && sid != 233 && sid != 2204)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x0008B12C File Offset: 0x0008932C
		private bool ReadARecord(global::NPOI.HSSF.Model.RecordStream rs)
		{
			int num = rs.PeekNextSid();
			if (num <= 51)
			{
				if (num <= 26)
				{
					if (num == 20)
					{
						this.CheckNotPresent(this.header);
						this.header = (global::NPOI.HSSF.Record.HeaderRecord)rs.GetNext();
						return true;
					}
					if (num == 21)
					{
						this.CheckNotPresent(this.footer);
						this.footer = (global::NPOI.HSSF.Record.FooterRecord)rs.GetNext();
						return true;
					}
					if (num == 26)
					{
						this.CheckNotPresent(this._columnBreaksRecord);
						this._columnBreaksRecord = (global::NPOI.HSSF.Record.PageBreakRecord)rs.GetNext();
						return true;
					}
				}
				else
				{
					if (num == 27)
					{
						this.CheckNotPresent(this._rowBreaksRecord);
						this._rowBreaksRecord = (global::NPOI.HSSF.Record.PageBreakRecord)rs.GetNext();
						return true;
					}
					switch (num)
					{
					case 38:
						this.CheckNotPresent(this._leftMargin);
						this._leftMargin = (global::NPOI.HSSF.Record.LeftMarginRecord)rs.GetNext();
						return true;
					case 39:
						this.CheckNotPresent(this._rightMargin);
						this._rightMargin = (global::NPOI.HSSF.Record.RightMarginRecord)rs.GetNext();
						return true;
					case 40:
						this.CheckNotPresent(this._topMargin);
						this._topMargin = (global::NPOI.HSSF.Record.TopMarginRecord)rs.GetNext();
						return true;
					case 41:
						this.CheckNotPresent(this._bottomMargin);
						this._bottomMargin = (global::NPOI.HSSF.Record.BottomMarginRecord)rs.GetNext();
						return true;
					default:
						if (num == 51)
						{
							this.CheckNotPresent(this._printSize);
							this._printSize = rs.GetNext();
							return true;
						}
						break;
					}
				}
			}
			else if (num <= 132)
			{
				if (num == 77)
				{
					this._plsRecords.Add(new global::NPOI.HSSF.Record.Aggregates.PLSAggregate(rs));
					return true;
				}
				if (num == 131)
				{
					this.CheckNotPresent(this._hCenter);
					this._hCenter = (global::NPOI.HSSF.Record.HCenterRecord)rs.GetNext();
					return true;
				}
				if (num == 132)
				{
					this.CheckNotPresent(this._vCenter);
					this._vCenter = (global::NPOI.HSSF.Record.VCenterRecord)rs.GetNext();
					return true;
				}
			}
			else
			{
				if (num == 161)
				{
					this.CheckNotPresent(this.printSetup);
					this.printSetup = (global::NPOI.HSSF.Record.PrintSetupRecord)rs.GetNext();
					return true;
				}
				if (num == 233)
				{
					this.CheckNotPresent(this._bitmap);
					this._bitmap = rs.GetNext();
					return true;
				}
				if (num == 2204)
				{
					global::NPOI.HSSF.Record.HeaderFooterRecord headerFooterRecord = (global::NPOI.HSSF.Record.HeaderFooterRecord)rs.GetNext();
					if (headerFooterRecord.IsCurrentSheet)
					{
						this._headerFooter = headerFooterRecord;
						return true;
					}
					this._sviewHeaderFooters.Add(headerFooterRecord);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x0008B3CE File Offset: 0x000895CE
		private void CheckNotPresent(global::NPOI.HSSF.Record.Record rec)
		{
			if (rec != null)
			{
				throw new global::NPOI.Util.RecordFormatException("Duplicate PageSettingsBlock record (sid=0x" + global::NPOI.Util.StringUtil.ToHexString(rec.Sid) + ")");
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x0008B3F3 File Offset: 0x000895F3
		private global::NPOI.HSSF.Record.PageBreakRecord RowBreaksRecord
		{
			get
			{
				if (this._rowBreaksRecord == null)
				{
					this._rowBreaksRecord = new global::NPOI.HSSF.Record.HorizontalPageBreakRecord();
				}
				return this._rowBreaksRecord;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x0008B40E File Offset: 0x0008960E
		private global::NPOI.HSSF.Record.PageBreakRecord ColumnBreaksRecord
		{
			get
			{
				if (this._columnBreaksRecord == null)
				{
					this._columnBreaksRecord = new global::NPOI.HSSF.Record.VerticalPageBreakRecord();
				}
				return this._columnBreaksRecord;
			}
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x0008B429 File Offset: 0x00089629
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._plsRecords.GetEnumerator();
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x0008B43B File Offset: 0x0008963B
		public void SetColumnBreak(int column, int fromRow, int toRow)
		{
			this.ColumnBreaksRecord.AddBreak(column, fromRow, toRow);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x0008B44B File Offset: 0x0008964B
		public void RemoveColumnBreak(int column)
		{
			this.ColumnBreaksRecord.RemoveBreak(column);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x0008B45C File Offset: 0x0008965C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._rowBreaksRecord, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._columnBreaksRecord, rv);
			if (this.header == null)
			{
				rv.VisitRecord(new global::NPOI.HSSF.Record.HeaderRecord(""));
			}
			else
			{
				rv.VisitRecord(this.header);
			}
			if (this.footer == null)
			{
				rv.VisitRecord(new global::NPOI.HSSF.Record.FooterRecord(""));
			}
			else
			{
				rv.VisitRecord(this.footer);
			}
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._hCenter, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._vCenter, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._leftMargin, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._rightMargin, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._topMargin, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._bottomMargin, rv);
			foreach (global::NPOI.HSSF.Record.Aggregates.PLSAggregate plsaggregate in this._plsRecords)
			{
				plsaggregate.VisitContainedRecords(rv);
			}
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this.printSetup, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._printSize, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._headerFooter, rv);
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.VisitIfPresent(this._bitmap, rv);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00088FC9 File Offset: 0x000871C9
		private static void VisitIfPresent(global::NPOI.HSSF.Record.Record r, global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (r != null)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x0008B58C File Offset: 0x0008978C
		private static void VisitIfPresent(global::NPOI.HSSF.Record.PageBreakRecord r, global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (r != null)
			{
				if (r.IsEmpty)
				{
					return;
				}
				rv.VisitRecord(r);
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000476C6 File Offset: 0x000458C6
		private static global::NPOI.HSSF.Record.HCenterRecord CreateHCenter()
		{
			return new global::NPOI.HSSF.Record.HCenterRecord
			{
				HCenter = false
			};
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000476D4 File Offset: 0x000458D4
		private static global::NPOI.HSSF.Record.VCenterRecord CreateVCenter()
		{
			return new global::NPOI.HSSF.Record.VCenterRecord
			{
				VCenter = false
			};
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x0008B5A4 File Offset: 0x000897A4
		private static global::NPOI.HSSF.Record.PrintSetupRecord CreatePrintSetup()
		{
			return new global::NPOI.HSSF.Record.PrintSetupRecord
			{
				PaperSize = 1,
				Scale = 100,
				PageStart = 1,
				FitWidth = 1,
				FitHeight = 1,
				Options = 2,
				HResolution = 300,
				VResolution = 300,
				HeaderMargin = 0.5,
				FooterMargin = 0.5,
				Copies = 1
			};
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x0008B61C File Offset: 0x0008981C
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x0008B624 File Offset: 0x00089824
		public global::NPOI.HSSF.Record.HeaderRecord Header
		{
			get
			{
				return this.header;
			}
			set
			{
				this.header = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x0008B62D File Offset: 0x0008982D
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x0008B635 File Offset: 0x00089835
		public global::NPOI.HSSF.Record.FooterRecord Footer
		{
			get
			{
				return this.footer;
			}
			set
			{
				this.footer = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x0008B63E File Offset: 0x0008983E
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x0008B646 File Offset: 0x00089846
		public global::NPOI.HSSF.Record.PrintSetupRecord PrintSetup
		{
			get
			{
				return this.printSetup;
			}
			set
			{
				this.printSetup = value;
			}
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x0008B650 File Offset: 0x00089850
		private global::NPOI.HSSF.Record.IMargin GetMarginRec(global::NPOI.SS.UserModel.MarginType margin)
		{
			switch (margin)
			{
			case global::NPOI.SS.UserModel.MarginType.LeftMargin:
				return this._leftMargin;
			case global::NPOI.SS.UserModel.MarginType.RightMargin:
				return this._rightMargin;
			case global::NPOI.SS.UserModel.MarginType.TopMargin:
				return this._topMargin;
			case global::NPOI.SS.UserModel.MarginType.BottomMargin:
				return this._bottomMargin;
			default:
			{
				string str = "Unknown margin constant:  ";
				short num = (short)margin;
				throw new global::System.InvalidOperationException(str + num.ToString());
			}
			}
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x0008B6AC File Offset: 0x000898AC
		public double GetMargin(global::NPOI.SS.UserModel.MarginType margin)
		{
			global::NPOI.HSSF.Record.IMargin marginRec = this.GetMarginRec(margin);
			if (marginRec != null)
			{
				return marginRec.Margin;
			}
			switch (margin)
			{
			case global::NPOI.SS.UserModel.MarginType.LeftMargin:
				return 0.75;
			case global::NPOI.SS.UserModel.MarginType.RightMargin:
				return 0.75;
			case global::NPOI.SS.UserModel.MarginType.TopMargin:
				return 1.0;
			case global::NPOI.SS.UserModel.MarginType.BottomMargin:
				return 1.0;
			default:
				throw new global::System.InvalidOperationException("Unknown margin constant:  " + margin.ToString());
			}
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x0008B728 File Offset: 0x00089928
		public void SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size)
		{
			global::NPOI.HSSF.Record.IMargin margin2 = this.GetMarginRec(margin);
			if (margin2 == null)
			{
				switch (margin)
				{
				case global::NPOI.SS.UserModel.MarginType.LeftMargin:
					this._leftMargin = new global::NPOI.HSSF.Record.LeftMarginRecord();
					margin2 = this._leftMargin;
					break;
				case global::NPOI.SS.UserModel.MarginType.RightMargin:
					this._rightMargin = new global::NPOI.HSSF.Record.RightMarginRecord();
					margin2 = this._rightMargin;
					break;
				case global::NPOI.SS.UserModel.MarginType.TopMargin:
					this._topMargin = new global::NPOI.HSSF.Record.TopMarginRecord();
					margin2 = this._topMargin;
					break;
				case global::NPOI.SS.UserModel.MarginType.BottomMargin:
					this._bottomMargin = new global::NPOI.HSSF.Record.BottomMarginRecord();
					margin2 = this._bottomMargin;
					break;
				default:
					throw new global::System.InvalidOperationException("Unknown margin constant:  " + margin.ToString());
				}
			}
			margin2.Margin = size;
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x0008B7D0 File Offset: 0x000899D0
		private static void ShiftBreaks(global::NPOI.HSSF.Record.PageBreakRecord breaks, int start, int stop, int count)
		{
			global::System.Collections.IEnumerator enumerator = breaks.GetBreaksEnumerator();
			global::System.Collections.IList list = new global::System.Collections.ArrayList();
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = (global::NPOI.HSSF.Record.PageBreakRecord.Break)obj;
				int main = @break.main;
				bool flag = main >= start;
				bool flag2 = main <= stop;
				if (flag && flag2)
				{
					list.Add(@break);
				}
			}
			foreach (object obj2 in list)
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break break2 = (global::NPOI.HSSF.Record.PageBreakRecord.Break)obj2;
				breaks.RemoveBreak(break2.main);
				breaks.AddBreak((int)((short)(break2.main + count)), break2.subFrom, break2.subTo);
			}
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x0008B86D File Offset: 0x00089A6D
		public void SetRowBreak(int row, short fromCol, short toCol)
		{
			this.RowBreaksRecord.AddBreak((int)((short)row), (int)fromCol, (int)toCol);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x0008B87E File Offset: 0x00089A7E
		public void RemoveRowBreak(int row)
		{
			if (this.RowBreaksRecord.GetBreaks().Length < 1)
			{
				throw new global::System.ArgumentException("Sheet does not define any row breaks");
			}
			this.RowBreaksRecord.RemoveBreak((int)((short)row));
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x0008B8A8 File Offset: 0x00089AA8
		public bool IsRowBroken(int row)
		{
			return this.RowBreaksRecord.GetBreak(row) != null;
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x0008B8B9 File Offset: 0x00089AB9
		public bool IsColumnBroken(int column)
		{
			return this.ColumnBreaksRecord.GetBreak(column) != null;
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0008B8CA File Offset: 0x00089ACA
		public void ShiftRowBreaks(int startingRow, int endingRow, int count)
		{
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.ShiftBreaks(this.RowBreaksRecord, startingRow, endingRow, count);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x0008B8DA File Offset: 0x00089ADA
		public void ShiftColumnBreaks(short startingCol, short endingCol, short count)
		{
			global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.ShiftBreaks(this.ColumnBreaksRecord, (int)startingCol, (int)endingCol, (int)count);
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x0008B8EA File Offset: 0x00089AEA
		public int[] RowBreaks
		{
			get
			{
				return this.RowBreaksRecord.GetBreaks();
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x0008B8F7 File Offset: 0x00089AF7
		public int NumRowBreaks
		{
			get
			{
				return this.RowBreaksRecord.NumBreaks;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x0008B904 File Offset: 0x00089B04
		public int[] ColumnBreaks
		{
			get
			{
				return this.ColumnBreaksRecord.GetBreaks();
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x0008B911 File Offset: 0x00089B11
		public int NumColumnBreaks
		{
			get
			{
				return this.ColumnBreaksRecord.NumBreaks;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x0008B91E File Offset: 0x00089B1E
		public global::NPOI.HSSF.Record.VCenterRecord VCenter
		{
			get
			{
				return this._vCenter;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x0008B926 File Offset: 0x00089B26
		public global::NPOI.HSSF.Record.HCenterRecord HCenter
		{
			get
			{
				return this._hCenter;
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x0008B930 File Offset: 0x00089B30
		public void AddLateHeaderFooter(global::NPOI.HSSF.Record.HeaderFooterRecord rec)
		{
			if (this._headerFooter != null)
			{
				throw new global::System.ArgumentNullException("This page settings block already has a header/footer record");
			}
			if (rec.Sid != 2204)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected header-footer record sid: 0x" + global::NPOI.Util.StringUtil.ToHexString(rec.Sid));
			}
			this._headerFooter = rec;
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x0008B97F File Offset: 0x00089B7F
		public void AddLateRecords(global::NPOI.HSSF.Model.RecordStream rs)
		{
			while (this.ReadARecord(rs))
			{
			}
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0008B98C File Offset: 0x00089B8C
		public void PositionRecords(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> sheetRecords)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord>(this._sviewHeaderFooters);
			global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.HeaderFooterRecord> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.HeaderFooterRecord>();
			foreach (global::NPOI.HSSF.Record.HeaderFooterRecord headerFooterRecord in list)
			{
				string key = global::NPOI.Util.HexDump.ToHex(headerFooterRecord.Guid);
				if (dictionary.ContainsKey(key))
				{
					dictionary[key] = headerFooterRecord;
				}
				else
				{
					dictionary.Add(global::NPOI.Util.HexDump.ToHex(headerFooterRecord.Guid), headerFooterRecord);
				}
			}
			foreach (global::NPOI.HSSF.Record.HeaderFooterRecord hf in list)
			{
				foreach (global::NPOI.HSSF.Record.RecordBase recordBase in sheetRecords)
				{
					if (recordBase is global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate)
					{
						global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate customViewSettingsRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate)recordBase;
						customViewSettingsRecordAggregate.VisitContainedRecords(new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.CustomRecordVisitor1(customViewSettingsRecordAggregate, hf, this._sviewHeaderFooters, dictionary));
					}
				}
			}
		}

		// Token: 0x04001470 RID: 5232
		private global::NPOI.HSSF.Record.PageBreakRecord _rowBreaksRecord;

		// Token: 0x04001471 RID: 5233
		private global::NPOI.HSSF.Record.PageBreakRecord _columnBreaksRecord;

		// Token: 0x04001472 RID: 5234
		private global::NPOI.HSSF.Record.HeaderRecord header;

		// Token: 0x04001473 RID: 5235
		private global::NPOI.HSSF.Record.FooterRecord footer;

		// Token: 0x04001474 RID: 5236
		private global::NPOI.HSSF.Record.HCenterRecord _hCenter;

		// Token: 0x04001475 RID: 5237
		private global::NPOI.HSSF.Record.VCenterRecord _vCenter;

		// Token: 0x04001476 RID: 5238
		private global::NPOI.HSSF.Record.LeftMarginRecord _leftMargin;

		// Token: 0x04001477 RID: 5239
		private global::NPOI.HSSF.Record.RightMarginRecord _rightMargin;

		// Token: 0x04001478 RID: 5240
		private global::NPOI.HSSF.Record.TopMarginRecord _topMargin;

		// Token: 0x04001479 RID: 5241
		private global::NPOI.HSSF.Record.BottomMarginRecord _bottomMargin;

		// Token: 0x0400147A RID: 5242
		private global::NPOI.HSSF.Record.PrintSetupRecord printSetup;

		// Token: 0x0400147B RID: 5243
		private global::NPOI.HSSF.Record.Record _bitmap;

		// Token: 0x0400147C RID: 5244
		private global::NPOI.HSSF.Record.HeaderFooterRecord _headerFooter;

		// Token: 0x0400147D RID: 5245
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord> _sviewHeaderFooters = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord>();

		// Token: 0x0400147E RID: 5246
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.PLSAggregate> _plsRecords;

		// Token: 0x0400147F RID: 5247
		private global::NPOI.HSSF.Record.Record _printSize;

		// Token: 0x0200061D RID: 1565
		private class CustomRecordVisitor1 : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x060036B0 RID: 14000 RVA: 0x000A6DCB File Offset: 0x000A4FCB
			public CustomRecordVisitor1(global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate cv, global::NPOI.HSSF.Record.HeaderFooterRecord hf, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord> sviewHeaderFooter, global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.HeaderFooterRecord> hfGuidMap)
			{
				this._cv = cv;
				this._hf = hf;
				this._sviewHeaderFooters = sviewHeaderFooter;
				this._hfGuidMap = hfGuidMap;
			}

			// Token: 0x060036B1 RID: 14001 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				if (r.Sid == 426)
				{
					string key = global::NPOI.Util.HexDump.ToHex(((global::NPOI.HSSF.Record.UserSViewBegin)r).Guid);
					if (this._hfGuidMap[key] != null)
					{
						this._cv.Append(this._hf);
						this._sviewHeaderFooters.Remove(this._hf);
					}
				}
			}

			// Token: 0x04001A97 RID: 6807
			private global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate _cv;

			// Token: 0x04001A98 RID: 6808
			private global::NPOI.HSSF.Record.HeaderFooterRecord _hf;

			// Token: 0x04001A99 RID: 6809
			private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HeaderFooterRecord> _sviewHeaderFooters;

			// Token: 0x04001A9A RID: 6810
			private global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.HeaderFooterRecord> _hfGuidMap;
		}
	}
}
