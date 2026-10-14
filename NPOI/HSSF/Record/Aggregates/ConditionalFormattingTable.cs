using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.SS.Formula;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CE RID: 1230
	public class ConditionalFormattingTable : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002EA3 RID: 11939 RVA: 0x0008A470 File Offset: 0x00088670
		public ConditionalFormattingTable()
		{
			this._cfHeaders = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate>();
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x0008A484 File Offset: 0x00088684
		public ConditionalFormattingTable(global::NPOI.HSSF.Model.RecordStream rs)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate>();
			while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.CFHeaderRecord) || rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.CFHeader12Record))
			{
				list.Add(global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate.CreateCFAggregate(rs));
			}
			this._cfHeaders = list;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x0008A4E0 File Offset: 0x000886E0
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			foreach (global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfrecordsAggregate in this._cfHeaders)
			{
				cfrecordsAggregate.VisitContainedRecords(rv);
			}
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x0008A52C File Offset: 0x0008872C
		public int Add(global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfAggregate)
		{
			cfAggregate.Header.ID = this._cfHeaders.Count;
			this._cfHeaders.Add(cfAggregate);
			return this._cfHeaders.Count - 1;
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x0008A55D File Offset: 0x0008875D
		public int Count
		{
			get
			{
				return this._cfHeaders.Count;
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0008A56A File Offset: 0x0008876A
		public global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate Get(int index)
		{
			this.CheckIndex(index);
			return this._cfHeaders[index];
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x0008A57F File Offset: 0x0008877F
		public void Remove(int index)
		{
			this.CheckIndex(index);
			this._cfHeaders.RemoveAt(index);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x0008A594 File Offset: 0x00088794
		private void CheckIndex(int index)
		{
			if (index < 0 || index >= this._cfHeaders.Count)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified CF index ",
					index.ToString(),
					" is outside the allowable range (0..",
					(this._cfHeaders.Count - 1).ToString(),
					")"
				}));
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x0008A600 File Offset: 0x00088800
		public void UpdateFormulasAfterCellShift(global::NPOI.SS.Formula.FormulaShifter shifter, int externSheetIndex)
		{
			for (int i = 0; i < this._cfHeaders.Count; i++)
			{
				if (!this._cfHeaders[i].UpdateFormulasAfterCellShift(shifter, externSheetIndex))
				{
					this._cfHeaders.RemoveAt(i);
					i--;
				}
			}
		}

		// Token: 0x04001462 RID: 5218
		private global::System.Collections.Generic.IList<global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate> _cfHeaders;
	}
}
