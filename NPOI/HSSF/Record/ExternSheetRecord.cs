using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D7 RID: 983
	public class ExternSheetRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x0006A396 File Offset: 0x00068596
		public ExternSheetRecord()
		{
			this._list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RefSubRecord>();
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0006A3AC File Offset: 0x000685AC
		public ExternSheetRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RefSubRecord>();
			int num = (int)in1.ReadShort();
			for (int i = 0; i < num; i++)
			{
				global::NPOI.HSSF.Record.RefSubRecord item = new global::NPOI.HSSF.Record.RefSubRecord(in1);
				this._list.Add(item);
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0006A3F0 File Offset: 0x000685F0
		public int AddRef(int extBookIndex, int firstSheetIndex, int lastSheetIndex)
		{
			this._list.Add(new global::NPOI.HSSF.Record.RefSubRecord(extBookIndex, firstSheetIndex, lastSheetIndex));
			return this._list.Count - 1;
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0006A414 File Offset: 0x00068614
		public int GetRefIxForSheet(int externalBookIndex, int firstSheetIndex, int lastSheetIndex)
		{
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.HSSF.Record.RefSubRecord @ref = this.GetRef(i);
				if (@ref.ExtBookIndex == externalBookIndex && @ref.FirstSheetIndex == firstSheetIndex && @ref.LastSheetIndex == lastSheetIndex)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x0006A45F File Offset: 0x0006865F
		public int NumOfREFRecords
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0006A45F File Offset: 0x0006865F
		public int NumOfRefs
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0006A46C File Offset: 0x0006866C
		public void AddREFRecord(global::NPOI.HSSF.Record.RefSubRecord rec)
		{
			this._list.Add(rec);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0006A47A File Offset: 0x0006867A
		private global::NPOI.HSSF.Record.RefSubRecord GetRef(int i)
		{
			return this._list[i];
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0006A488 File Offset: 0x00068688
		public void RemoveSheet(int sheetIdx)
		{
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.HSSF.Record.RefSubRecord refSubRecord = this._list[i];
				if (refSubRecord.FirstSheetIndex == sheetIdx && refSubRecord.LastSheetIndex == sheetIdx)
				{
					this._list[i] = new global::NPOI.HSSF.Record.RefSubRecord(refSubRecord.ExtBookIndex, -1, -1);
				}
				else if (refSubRecord.FirstSheetIndex > sheetIdx && refSubRecord.LastSheetIndex > sheetIdx)
				{
					this._list[i] = new global::NPOI.HSSF.Record.RefSubRecord(refSubRecord.ExtBookIndex, refSubRecord.FirstSheetIndex - 1, refSubRecord.LastSheetIndex - 1);
				}
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0006A520 File Offset: 0x00068720
		public int GetExtbookIndexFromRefIndex(int refIndex)
		{
			return this.GetRef(refIndex).ExtBookIndex;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0006A530 File Offset: 0x00068730
		public int FindRefIndexFromExtBookIndex(int extBookIndex)
		{
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.GetRef(i).ExtBookIndex == extBookIndex)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0006A568 File Offset: 0x00068768
		public static global::NPOI.HSSF.Record.ExternSheetRecord Combine(global::NPOI.HSSF.Record.ExternSheetRecord[] esrs)
		{
			global::NPOI.HSSF.Record.ExternSheetRecord externSheetRecord = new global::NPOI.HSSF.Record.ExternSheetRecord();
			foreach (global::NPOI.HSSF.Record.ExternSheetRecord externSheetRecord2 in esrs)
			{
				int numOfREFRecords = externSheetRecord2.NumOfREFRecords;
				for (int j = 0; j < numOfREFRecords; j++)
				{
					externSheetRecord.AddREFRecord(externSheetRecord2.GetRef(j));
				}
			}
			return externSheetRecord;
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0006A5B3 File Offset: 0x000687B3
		public int GetFirstSheetIndexFromRefIndex(int extRefIndex)
		{
			return this.GetRef(extRefIndex).FirstSheetIndex;
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0006A5C1 File Offset: 0x000687C1
		public int GetLastSheetIndexFromRefIndex(int extRefIndex)
		{
			return this.GetRef(extRefIndex).LastSheetIndex;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0006A5D0 File Offset: 0x000687D0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int count = this._list.Count;
			stringBuilder.Append("[EXTERNSHEET]\n");
			stringBuilder.Append("   numOfRefs     = ").Append(count).Append("\n");
			for (int i = 0; i < count; i++)
			{
				stringBuilder.Append("refrec         #").Append(i).Append(": ");
				stringBuilder.Append(this.GetRef(i).ToString());
				stringBuilder.Append('\n');
			}
			stringBuilder.Append("[/EXTERNSHEET]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0006A670 File Offset: 0x00068870
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int count = this._list.Count;
			out1.WriteShort(count);
			for (int i = 0; i < count; i++)
			{
				this.GetRef(i).Serialize(out1);
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0006A6A9 File Offset: 0x000688A9
		protected override int DataSize
		{
			get
			{
				return 2 + this._list.Count * 6;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0006A6BA File Offset: 0x000688BA
		public override short Sid
		{
			get
			{
				return 23;
			}
		}

		// Token: 0x04000ECA RID: 3786
		public const short sid = 23;

		// Token: 0x04000ECB RID: 3787
		private global::System.Collections.Generic.IList<global::NPOI.HSSF.Record.RefSubRecord> _list;
	}
}
