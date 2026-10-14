using System;
using NPOI.HSSF.Record.Cont;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000421 RID: 1057
	public class SSTSerializer
	{
		// Token: 0x060026D0 RID: 9936 RVA: 0x000748A8 File Offset: 0x00072AA8
		public SSTSerializer(global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings, int numStrings, int numUniqueStrings)
		{
			this.strings = strings;
			this._numStrings = numStrings;
			this._numUniqueStrings = numUniqueStrings;
			int numberOfInfoRecsForStrings = global::NPOI.HSSF.Record.ExtSSTRecord.GetNumberOfInfoRecsForStrings(strings.Size);
			this.bucketAbsoluteOffsets = new int[numberOfInfoRecsForStrings];
			this.bucketRelativeOffsets = new int[numberOfInfoRecsForStrings];
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000748F4 File Offset: 0x00072AF4
		public void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			out1.WriteInt(this._numStrings);
			out1.WriteInt(this._numUniqueStrings);
			for (int i = 0; i < this.strings.Size; i++)
			{
				if (i % 8 == 0)
				{
					int totalSize = out1.TotalSize;
					int num = i / 8;
					if (num < 128)
					{
						this.bucketAbsoluteOffsets[num] = totalSize;
						this.bucketRelativeOffsets[num] = totalSize;
					}
				}
				this.GetUnicodeString(i).Serialize(out1);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00074966 File Offset: 0x00072B66
		private global::NPOI.HSSF.Record.UnicodeString GetUnicodeString(int index)
		{
			return global::NPOI.HSSF.Record.SSTSerializer.GetUnicodeString(this.strings, index);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00074974 File Offset: 0x00072B74
		private static global::NPOI.HSSF.Record.UnicodeString GetUnicodeString(global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings, int index)
		{
			return strings[index];
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x0007497D File Offset: 0x00072B7D
		public int[] BucketAbsoluteOffsets
		{
			get
			{
				return this.bucketAbsoluteOffsets;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00074985 File Offset: 0x00072B85
		public int[] BucketRelativeOffsets
		{
			get
			{
				return this.bucketRelativeOffsets;
			}
		}

		// Token: 0x0400103A RID: 4154
		private int _numStrings;

		// Token: 0x0400103B RID: 4155
		private int _numUniqueStrings;

		// Token: 0x0400103C RID: 4156
		private global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings;

		// Token: 0x0400103D RID: 4157
		private int[] bucketAbsoluteOffsets;

		// Token: 0x0400103E RID: 4158
		private int[] bucketRelativeOffsets;
	}
}
