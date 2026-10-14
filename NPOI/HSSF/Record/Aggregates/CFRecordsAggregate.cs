using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Model;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CC RID: 1228
	public class CFRecordsAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002E71 RID: 11889 RVA: 0x00089114 File Offset: 0x00087314
		private CFRecordsAggregate(global::NPOI.HSSF.Record.CFHeaderBase pHeader, global::NPOI.HSSF.Record.CFRuleBase[] pRules)
		{
			if (pHeader == null)
			{
				throw new global::System.ArgumentException("header must not be null");
			}
			if (pRules == null)
			{
				throw new global::System.ArgumentException("rules must not be null");
			}
			if (pRules.Length > 3)
			{
				global::System.Console.WriteLine(string.Concat(new string[]
				{
					"Excel versions before 2007 require that No more than ",
					3.ToString(),
					" rules may be specified, ",
					pRules.Length.ToString(),
					" were found, this file will cause problems with old Excel versions"
				}));
			}
			if (pRules.Length != pHeader.NumberOfConditionalFormats)
			{
				throw new global::NPOI.Util.RecordFormatException("Mismatch number of rules");
			}
			this.header = pHeader;
			this.rules = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.CFRuleBase>(pRules.Length);
			foreach (global::NPOI.HSSF.Record.CFRuleBase cfruleBase in pRules)
			{
				this.CheckRuleType(cfruleBase);
				this.rules.Add(cfruleBase);
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000891DD File Offset: 0x000873DD
		public CFRecordsAggregate(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.HSSF.Record.CFRuleBase[] rules) : this(global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate.CreateHeader(regions, rules), rules)
		{
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000891F0 File Offset: 0x000873F0
		private static global::NPOI.HSSF.Record.CFHeaderBase CreateHeader(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.HSSF.Record.CFRuleBase[] rules)
		{
			global::NPOI.HSSF.Record.CFHeaderBase cfheaderBase;
			if (rules.Length == 0 || rules[0] is global::NPOI.HSSF.Record.CFRuleRecord)
			{
				cfheaderBase = new global::NPOI.HSSF.Record.CFHeaderRecord(regions, rules.Length);
			}
			else
			{
				cfheaderBase = new global::NPOI.HSSF.Record.CFHeader12Record(regions, rules.Length);
			}
			cfheaderBase.NeedRecalculation = true;
			return cfheaderBase;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0008922C File Offset: 0x0008742C
		public static global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate CreateCFAggregate(global::NPOI.HSSF.Model.RecordStream rs)
		{
			global::NPOI.HSSF.Record.Record next = rs.GetNext();
			if (next.Sid != global::NPOI.HSSF.Record.CFHeaderRecord.sid && next.Sid != global::NPOI.HSSF.Record.CFHeader12Record.sid)
			{
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"next record sid was ",
					next.Sid.ToString(),
					" instead of ",
					global::NPOI.HSSF.Record.CFHeaderRecord.sid.ToString(),
					" or ",
					global::NPOI.HSSF.Record.CFHeader12Record.sid.ToString(),
					" as expected"
				}));
			}
			global::NPOI.HSSF.Record.CFHeaderBase cfheaderBase = (global::NPOI.HSSF.Record.CFHeaderBase)next;
			global::NPOI.HSSF.Record.CFRuleBase[] array = new global::NPOI.HSSF.Record.CFRuleBase[cfheaderBase.NumberOfConditionalFormats];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (global::NPOI.HSSF.Record.CFRuleBase)rs.GetNext();
			}
			return new global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate(cfheaderBase, array);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000892F4 File Offset: 0x000874F4
		[global::System.Obsolete("Not found in poi(2015-07-14), maybe was removed")]
		public static global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate CreateCFAggregate(global::System.Collections.IList recs, int pOffset)
		{
			global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)recs[pOffset];
			if (record.Sid != global::NPOI.HSSF.Record.CFHeaderRecord.sid)
			{
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"next record sid was ",
					record.Sid.ToString(),
					" instead of ",
					global::NPOI.HSSF.Record.CFHeaderRecord.sid.ToString(),
					" as expected"
				}));
			}
			global::NPOI.HSSF.Record.CFHeaderRecord cfheaderRecord = (global::NPOI.HSSF.Record.CFHeaderRecord)record;
			int numberOfConditionalFormats = cfheaderRecord.NumberOfConditionalFormats;
			global::NPOI.HSSF.Record.CFRuleRecord[] array = new global::NPOI.HSSF.Record.CFRuleRecord[numberOfConditionalFormats];
			int num = pOffset;
			int i;
			for (i = 0; i < array.Length; i++)
			{
				num++;
				if (num >= recs.Count)
				{
					break;
				}
				record = (global::NPOI.HSSF.Record.Record)recs[num];
				if (!(record is global::NPOI.HSSF.Record.CFRuleRecord))
				{
					break;
				}
				array[i] = (global::NPOI.HSSF.Record.CFRuleRecord)record;
			}
			if (i < numberOfConditionalFormats)
			{
				cfheaderRecord.NumberOfConditionalFormats = numberOfConditionalFormats;
				global::NPOI.HSSF.Record.CFRuleRecord[] array2 = new global::NPOI.HSSF.Record.CFRuleRecord[i];
				global::System.Array.Copy(array, 0, array2, 0, i);
				array = array2;
			}
			global::NPOI.HSSF.Record.CFHeaderBase pHeader = cfheaderRecord;
			global::NPOI.HSSF.Record.CFRuleBase[] pRules = array;
			return new global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate(pHeader, pRules);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000893EC File Offset: 0x000875EC
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.header);
			foreach (global::NPOI.HSSF.Record.CFRuleBase r in this.rules)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0008944C File Offset: 0x0008764C
		public global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate CloneCFAggregate()
		{
			global::NPOI.HSSF.Record.CFRuleBase[] array = new global::NPOI.HSSF.Record.CFRuleBase[this.rules.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (global::NPOI.HSSF.Record.CFRuleRecord)this.GetRule(i).Clone();
			}
			return new global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate((global::NPOI.HSSF.Record.CFHeaderBase)this.header.Clone(), array);
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x000894A2 File Offset: 0x000876A2
		public override short Sid
		{
			get
			{
				return -2008;
			}
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000894AC File Offset: 0x000876AC
		public override int Serialize(int offset, byte[] data)
		{
			int count = this.rules.Count;
			this.header.NumberOfConditionalFormats = count;
			int num = offset + this.header.Serialize(offset, data);
			for (int i = 0; i < count; i++)
			{
				num += this.GetRule(i).Serialize(num, data);
			}
			return num - offset;
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00089503 File Offset: 0x00087703
		public global::NPOI.HSSF.Record.CFHeaderBase Header
		{
			get
			{
				return this.header;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0008950C File Offset: 0x0008770C
		private void CheckRuleIndex(int idx)
		{
			if (idx < 0 || idx >= this.rules.Count)
			{
				throw new global::System.ArgumentException("Bad rule record index (" + idx.ToString() + ") nRules=" + this.rules.Count.ToString());
			}
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x0008955A File Offset: 0x0008775A
		private void CheckRuleType(global::NPOI.HSSF.Record.CFRuleBase r)
		{
			if (this.header is global::NPOI.HSSF.Record.CFHeaderRecord && r is global::NPOI.HSSF.Record.CFRuleRecord)
			{
				return;
			}
			if (this.header is global::NPOI.HSSF.Record.CFHeader12Record && r is global::NPOI.HSSF.Record.CFRule12Record)
			{
				return;
			}
			throw new global::System.ArgumentException("Header and Rule must both be CF or both be CF12, can't mix");
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00089592 File Offset: 0x00087792
		public global::NPOI.HSSF.Record.CFRuleBase GetRule(int idx)
		{
			this.CheckRuleIndex(idx);
			return this.rules[idx];
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000895A7 File Offset: 0x000877A7
		public void SetRule(int idx, global::NPOI.HSSF.Record.CFRuleBase r)
		{
			this.CheckRuleIndex(idx);
			this.CheckRuleType(r);
			this.rules[idx] = r;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000895C4 File Offset: 0x000877C4
		public bool UpdateFormulasAfterCellShift(global::NPOI.SS.Formula.FormulaShifter shifter, int currentExternSheetIx)
		{
			global::NPOI.SS.Util.CellRangeAddress[] cellRanges = this.header.CellRanges;
			bool flag = false;
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in cellRanges)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 = global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate.ShiftRange(shifter, cellRangeAddress, currentExternSheetIx);
				if (cellRangeAddress2 == null)
				{
					flag = true;
				}
				else
				{
					list.Add(cellRangeAddress2);
					if (cellRangeAddress2 != cellRangeAddress)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				int count = list.Count;
				if (count == 0)
				{
					return false;
				}
				global::NPOI.SS.Util.CellRangeAddress[] cellRanges2 = new global::NPOI.SS.Util.CellRangeAddress[count];
				cellRanges2 = list.ToArray();
				this.header.CellRanges = cellRanges2;
			}
			foreach (global::NPOI.HSSF.Record.CFRuleBase cfruleBase in this.rules)
			{
				global::NPOI.SS.Formula.PTG.Ptg[] array2 = cfruleBase.ParsedExpression1;
				if (array2 != null && shifter.AdjustFormula(array2, currentExternSheetIx))
				{
					cfruleBase.ParsedExpression1 = array2;
				}
				array2 = cfruleBase.ParsedExpression2;
				if (array2 != null && shifter.AdjustFormula(array2, currentExternSheetIx))
				{
					cfruleBase.ParsedExpression2 = array2;
				}
				if (cfruleBase is global::NPOI.HSSF.Record.CFRule12Record)
				{
					global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = (global::NPOI.HSSF.Record.CFRule12Record)cfruleBase;
					array2 = cfrule12Record.ParsedExpressionScale;
					if (array2 != null && shifter.AdjustFormula(array2, currentExternSheetIx))
					{
						cfrule12Record.ParsedExpressionScale = array2;
					}
				}
			}
			return true;
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00089704 File Offset: 0x00087904
		private static global::NPOI.SS.Util.CellRangeAddress ShiftRange(global::NPOI.SS.Formula.FormulaShifter shifter, global::NPOI.SS.Util.CellRangeAddress cra, int currentExternSheetIx)
		{
			global::NPOI.SS.Formula.PTG.AreaPtg areaPtg = new global::NPOI.SS.Formula.PTG.AreaPtg(cra.FirstRow, cra.LastRow, cra.FirstColumn, cra.LastColumn, false, false, false, false);
			global::NPOI.SS.Formula.PTG.Ptg[] array = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				areaPtg
			};
			if (!shifter.AdjustFormula(array, currentExternSheetIx))
			{
				return cra;
			}
			global::NPOI.SS.Formula.PTG.Ptg ptg = array[0];
			if (ptg is global::NPOI.SS.Formula.PTG.AreaPtg)
			{
				global::NPOI.SS.Formula.PTG.AreaPtg areaPtg2 = (global::NPOI.SS.Formula.PTG.AreaPtg)ptg;
				return new global::NPOI.SS.Util.CellRangeAddress(areaPtg2.FirstRow, areaPtg2.LastRow, areaPtg2.FirstColumn, areaPtg2.LastColumn);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AreaErrPtg)
			{
				return null;
			}
			throw new global::System.InvalidCastException("Unexpected shifted ptg class (" + ptg.GetType().Name + ")");
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000897A4 File Offset: 0x000879A4
		public void AddRule(global::NPOI.HSSF.Record.CFRuleBase r)
		{
			if (this.rules.Count >= 3)
			{
				global::System.Console.WriteLine("Excel versions before 2007 cannot cope with any more than " + 3.ToString() + " - this file will cause problems with old Excel versions");
			}
			this.CheckRuleType(r);
			this.rules.Add(r);
			this.header.NumberOfConditionalFormats = this.rules.Count;
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00089805 File Offset: 0x00087A05
		public int NumberOfRules
		{
			get
			{
				return this.rules.Count;
			}
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00089814 File Offset: 0x00087A14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string value = "CF";
			if (this.header is global::NPOI.HSSF.Record.CFHeader12Record)
			{
				value = "CF12";
			}
			stringBuilder.Append("[").Append(value).Append("]\n");
			if (this.header != null)
			{
				stringBuilder.Append(this.header.ToString());
			}
			foreach (global::NPOI.HSSF.Record.CFRuleBase cfruleBase in this.rules)
			{
				if (cfruleBase != null)
				{
					stringBuilder.Append(cfruleBase.ToString());
				}
			}
			stringBuilder.Append("[/CF]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400145D RID: 5213
		private const int MAX_97_2003_CONDTIONAL_FORMAT_RULES = 3;

		// Token: 0x0400145E RID: 5214
		public const short sid = -2008;

		// Token: 0x0400145F RID: 5215
		private global::NPOI.HSSF.Record.CFHeaderBase header;

		// Token: 0x04001460 RID: 5216
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.CFRuleBase> rules;
	}
}
