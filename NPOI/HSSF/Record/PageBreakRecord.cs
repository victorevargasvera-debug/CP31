using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FF RID: 1023
	public class PageBreakRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002523 RID: 9507 RVA: 0x0006F824 File Offset: 0x0006DA24
		public PageBreakRecord()
		{
			this._breaks = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.PageBreakRecord.Break>();
			this._breakMap = new global::System.Collections.Hashtable();
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0006F844 File Offset: 0x0006DA44
		public PageBreakRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int num = (int)in1.ReadShort();
			this._breaks = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.PageBreakRecord.Break>(num + 2);
			this._breakMap = new global::System.Collections.Hashtable();
			for (int i = 0; i < num; i++)
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = new global::NPOI.HSSF.Record.PageBreakRecord.Break(in1);
				this._breaks.Add(@break);
				this._breakMap[@break.main] = @break;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x0006F8AD File Offset: 0x0006DAAD
		public override short Sid
		{
			get
			{
				return this.sid;
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int count = this._breaks.Count;
			out1.WriteShort(count);
			for (int i = 0; i < count; i++)
			{
				this._breaks[i].Serialize(out1);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0006F8F6 File Offset: 0x0006DAF6
		protected override int DataSize
		{
			get
			{
				return 2 + this._breaks.Count * 6;
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0006F907 File Offset: 0x0006DB07
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.PageBreakRecord.Break> GetBreaksEnumerator()
		{
			return this._breaks.GetEnumerator();
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0006F914 File Offset: 0x0006DB14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string str;
			string value;
			string value2;
			if (this.Sid == 27)
			{
				str = "HORIZONTALPAGEBREAK";
				value = "row";
				value2 = "col";
			}
			else
			{
				str = "VERTICALPAGEBREAK";
				value = "column";
				value2 = "row";
			}
			stringBuilder.Append("[" + str + "]").Append("\n");
			stringBuilder.Append("     .Sid        =").Append(this.Sid).Append("\n");
			stringBuilder.Append("     .num_breaks =").Append(this.NumBreaks).Append("\n");
			global::System.Collections.IEnumerator breaksEnumerator = this.GetBreaksEnumerator();
			for (int i = 0; i < this.NumBreaks; i++)
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = (global::NPOI.HSSF.Record.PageBreakRecord.Break)breaksEnumerator.Current;
				stringBuilder.Append("     .").Append(value).Append(" (zero-based) =").Append(@break.main).Append("\n");
				stringBuilder.Append("     .").Append(value2).Append("From    =").Append(@break.subFrom).Append("\n");
				stringBuilder.Append("     .").Append(value2).Append("To      =").Append(@break.subTo).Append("\n");
			}
			stringBuilder.Append("[" + str + "]").Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x0006FAA8 File Offset: 0x0006DCA8
		public void AddBreak(int main, int subFrom, int subTo)
		{
			global::NPOI.HSSF.Record.PageBreakRecord.Break @break = (global::NPOI.HSSF.Record.PageBreakRecord.Break)this._breakMap[main];
			if (@break != null)
			{
				@break.main = main;
				@break.subFrom = subFrom;
				@break.subTo = subTo;
			}
			else
			{
				@break = new global::NPOI.HSSF.Record.PageBreakRecord.Break(main, subFrom, subTo);
				this._breaks.Add(@break);
			}
			this._breakMap[main] = @break;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0006FB10 File Offset: 0x0006DD10
		public void RemoveBreak(int main)
		{
			global::NPOI.HSSF.Record.PageBreakRecord.Break item = (global::NPOI.HSSF.Record.PageBreakRecord.Break)this._breakMap[main];
			this._breaks.Remove(item);
			this._breakMap.Remove(main);
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0006FB54 File Offset: 0x0006DD54
		public override int RecordSize
		{
			get
			{
				if (this._breaks.Count < 1)
				{
					return 0;
				}
				return 4 + this.DataSize;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0006FB6E File Offset: 0x0006DD6E
		public int NumBreaks
		{
			get
			{
				return this._breaks.Count;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0006FB7B File Offset: 0x0006DD7B
		public bool IsEmpty
		{
			get
			{
				return this._breaks.Count == 0;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0006FB8B File Offset: 0x0006DD8B
		public global::NPOI.HSSF.Record.PageBreakRecord.Break GetBreak(int main)
		{
			return (global::NPOI.HSSF.Record.PageBreakRecord.Break)this._breakMap[main];
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0006FBA4 File Offset: 0x0006DDA4
		public int[] GetBreaks()
		{
			int numBreaks = this.NumBreaks;
			if (numBreaks < 1)
			{
				return global::NPOI.HSSF.Record.PageBreakRecord.EMPTY_INT_ARRAY;
			}
			int[] array = new int[numBreaks];
			for (int i = 0; i < numBreaks; i++)
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = this._breaks[i];
				array[i] = @break.main;
			}
			return array;
		}

		// Token: 0x04000F9E RID: 3998
		private const bool IS_EMPTY_RECORD_WRITTEN = false;

		// Token: 0x04000F9F RID: 3999
		private static readonly int[] EMPTY_INT_ARRAY = new int[0];

		// Token: 0x04000FA0 RID: 4000
		public short sid;

		// Token: 0x04000FA1 RID: 4001
		private global::System.Collections.Generic.IList<global::NPOI.HSSF.Record.PageBreakRecord.Break> _breaks;

		// Token: 0x04000FA2 RID: 4002
		private global::System.Collections.Hashtable _breakMap;

		// Token: 0x02000612 RID: 1554
		public class Break
		{
			// Token: 0x06003687 RID: 13959 RVA: 0x000A69BD File Offset: 0x000A4BBD
			public Break(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this.main = in1.ReadUShort() - 1;
				this.subFrom = in1.ReadUShort();
				this.subTo = in1.ReadUShort();
			}

			// Token: 0x06003688 RID: 13960 RVA: 0x000A69EB File Offset: 0x000A4BEB
			public Break(int main, int subFrom, int subTo)
			{
				this.main = main;
				this.subFrom = subFrom;
				this.subTo = subTo;
			}

			// Token: 0x06003689 RID: 13961 RVA: 0x000A6A08 File Offset: 0x000A4C08
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort(this.main + 1);
				out1.WriteShort(this.subFrom);
				out1.WriteShort(this.subTo);
			}

			// Token: 0x04001A7D RID: 6781
			public const int ENCODED_SIZE = 6;

			// Token: 0x04001A7E RID: 6782
			public int main;

			// Token: 0x04001A7F RID: 6783
			public int subFrom;

			// Token: 0x04001A80 RID: 6784
			public int subTo;
		}
	}
}
