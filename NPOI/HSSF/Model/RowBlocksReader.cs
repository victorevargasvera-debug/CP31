using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.Util;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000336 RID: 822
	public class RowBlocksReader
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x00046868 File Offset: 0x00044A68
		public RowBlocksReader(global::NPOI.HSSF.Model.RecordStream rs)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList4 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList5 = new global::System.Collections.ArrayList();
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellReference> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellReference>();
			global::NPOI.HSSF.Record.Record record = null;
			while (!global::NPOI.HSSF.Model.RecordOrderer.IsEndOfRowBlock(rs.PeekNextSid()))
			{
				if (!rs.HasNext())
				{
					throw new global::System.InvalidOperationException("Failed to find end of row/cell records");
				}
				global::NPOI.HSSF.Record.Record next = rs.GetNext();
				short sid = next.Sid;
				global::System.Collections.ArrayList arrayList6;
				if (sid <= 545)
				{
					if (sid != 229)
					{
						if (sid != 545)
						{
							goto IL_D5;
						}
						arrayList6 = arrayList3;
					}
					else
					{
						arrayList6 = arrayList5;
					}
				}
				else if (sid != 566)
				{
					if (sid != 1212)
					{
						goto IL_D5;
					}
					arrayList6 = arrayList2;
					if (!(record is global::NPOI.HSSF.Record.FormulaRecord))
					{
						throw new global::System.Exception("Shared formula record should follow a FormulaRecord");
					}
					global::NPOI.HSSF.Record.FormulaRecord formulaRecord = (global::NPOI.HSSF.Record.FormulaRecord)record;
					list.Add(new global::NPOI.SS.Util.CellReference(formulaRecord.Row, formulaRecord.Column));
				}
				else
				{
					arrayList6 = arrayList4;
				}
				IL_D8:
				arrayList6.Add(next);
				record = next;
				continue;
				IL_D5:
				arrayList6 = arrayList;
				goto IL_D8;
			}
			global::NPOI.HSSF.Record.SharedFormulaRecord[] sharedFormulaRecords = new global::NPOI.HSSF.Record.SharedFormulaRecord[arrayList2.Count];
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord> arrayRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord>(arrayList3.Count);
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord> tableRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord>(arrayList4.Count);
			sharedFormulaRecords = (global::NPOI.HSSF.Record.SharedFormulaRecord[])arrayList2.ToArray(typeof(global::NPOI.HSSF.Record.SharedFormulaRecord));
			global::NPOI.SS.Util.CellReference[] firstCells = new global::NPOI.SS.Util.CellReference[list.Count];
			firstCells = list.ToArray();
			arrayRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord>((global::NPOI.HSSF.Record.ArrayRecord[])arrayList3.ToArray(typeof(global::NPOI.HSSF.Record.ArrayRecord)));
			tableRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord>((global::NPOI.HSSF.Record.TableRecord[])arrayList4.ToArray(typeof(global::NPOI.HSSF.Record.TableRecord)));
			this._plainRecords = arrayList;
			this._sfm = global::NPOI.HSSF.Record.Aggregates.SharedValueManager.Create(sharedFormulaRecords, firstCells, arrayRecords, tableRecords);
			this._mergedCellsRecords = new global::NPOI.HSSF.Record.MergeCellsRecord[arrayList5.Count];
			this._mergedCellsRecords = (global::NPOI.HSSF.Record.MergeCellsRecord[])arrayList5.ToArray(typeof(global::NPOI.HSSF.Record.MergeCellsRecord));
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00046A40 File Offset: 0x00044C40
		public global::NPOI.HSSF.Record.MergeCellsRecord[] LooseMergedCells
		{
			get
			{
				return this._mergedCellsRecords;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00046A48 File Offset: 0x00044C48
		public global::NPOI.HSSF.Record.Aggregates.SharedValueManager SharedFormulaManager
		{
			get
			{
				return this._sfm;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00046A50 File Offset: 0x00044C50
		public global::NPOI.HSSF.Model.RecordStream PlainRecordStream
		{
			get
			{
				return new global::NPOI.HSSF.Model.RecordStream(this._plainRecords, 0);
			}
		}

		// Token: 0x040009A5 RID: 2469
		private global::System.Collections.ArrayList _plainRecords;

		// Token: 0x040009A6 RID: 2470
		private global::NPOI.HSSF.Record.Aggregates.SharedValueManager _sfm;

		// Token: 0x040009A7 RID: 2471
		private global::NPOI.HSSF.Record.MergeCellsRecord[] _mergedCellsRecords;
	}
}
