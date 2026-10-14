using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DA RID: 986
	public class ExtSSTRecord : global::NPOI.HSSF.Record.Cont.ContinuableRecord
	{
		// Token: 0x06002338 RID: 9016 RVA: 0x0006A8F7 File Offset: 0x00068AF7
		public ExtSSTRecord()
		{
			this._sstInfos = new global::NPOI.HSSF.Record.InfoSubRecord[0];
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0006A914 File Offset: 0x00068B14
		public ExtSSTRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_strings_per_bucket = in1.ReadShort();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.InfoSubRecord> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.InfoSubRecord>(in1.Remaining / 8);
			while (in1.Available() > 0)
			{
				global::NPOI.HSSF.Record.InfoSubRecord item = new global::NPOI.HSSF.Record.InfoSubRecord(in1);
				list.Add(item);
				if (in1.Available() == 0 && in1.HasNextRecord && in1.GetNextSid() == 60)
				{
					in1.NextRecord();
				}
			}
			this._sstInfos = list.ToArray();
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0006A98D File Offset: 0x00068B8D
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._sstInfos.GetEnumerator();
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x0006A99A File Offset: 0x00068B9A
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x0006A9A2 File Offset: 0x00068BA2
		public short NumStringsPerBucket
		{
			get
			{
				return this.field_1_strings_per_bucket;
			}
			set
			{
				this.field_1_strings_per_bucket = value;
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0006A9AC File Offset: 0x00068BAC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[EXTSST]\n");
			stringBuilder.Append("    .dsst           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.NumStringsPerBucket)).Append("\n");
			stringBuilder.Append("    .numInfoRecords = ").Append(this._sstInfos.Length).Append("\n");
			for (int i = 0; i < this._sstInfos.Length; i++)
			{
				stringBuilder.Append("    .inforecord     = ").Append(i).Append("\n");
				stringBuilder.Append("    .streampos      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this._sstInfos[i].StreamPos)).Append("\n");
				stringBuilder.Append("    .sstoffset      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this._sstInfos[i].BucketSSTOffset)).Append("\n");
			}
			stringBuilder.Append("[/EXTSST]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0006AAB4 File Offset: 0x00068CB4
		protected override void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			out1.WriteShort((int)this.field_1_strings_per_bucket);
			for (int i = 0; i < this._sstInfos.Length; i++)
			{
				this._sstInfos[i].Serialize(out1);
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x0006AAEE File Offset: 0x00068CEE
		internal int DataSize
		{
			get
			{
				return 2 + 8 * this._sstInfos.Length;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x0006AAFC File Offset: 0x00068CFC
		internal global::NPOI.HSSF.Record.InfoSubRecord[] InfoSubRecords
		{
			get
			{
				return this._sstInfos;
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0006AB04 File Offset: 0x00068D04
		public static int GetNumberOfInfoRecsForStrings(int numStrings)
		{
			int num = numStrings / 8;
			if (numStrings % 8 != 0)
			{
				num++;
			}
			if (num > 128)
			{
				num = 128;
			}
			return num;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0006AB2D File Offset: 0x00068D2D
		public static int GetRecordSizeForStrings(int numStrings)
		{
			return 6 + global::NPOI.HSSF.Record.ExtSSTRecord.GetNumberOfInfoRecsForStrings(numStrings) * 8;
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x0006AB39 File Offset: 0x00068D39
		public override short Sid
		{
			get
			{
				return 255;
			}
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0006AB40 File Offset: 0x00068D40
		public void SetBucketOffsets(int[] bucketAbsoluteOffsets, int[] bucketRelativeOffsets)
		{
			this._sstInfos = new global::NPOI.HSSF.Record.InfoSubRecord[bucketAbsoluteOffsets.Length];
			for (int i = 0; i < bucketAbsoluteOffsets.Length; i++)
			{
				this._sstInfos[i] = new global::NPOI.HSSF.Record.InfoSubRecord(bucketAbsoluteOffsets[i], bucketRelativeOffsets[i]);
			}
		}

		// Token: 0x04000ED5 RID: 3797
		public const short DEFAULT_BUCKET_SIZE = 8;

		// Token: 0x04000ED6 RID: 3798
		public const int MAX_BUCKETS = 128;

		// Token: 0x04000ED7 RID: 3799
		public const short sid = 255;

		// Token: 0x04000ED8 RID: 3800
		private short field_1_strings_per_bucket = 8;

		// Token: 0x04000ED9 RID: 3801
		private global::NPOI.HSSF.Record.InfoSubRecord[] _sstInfos;
	}
}
