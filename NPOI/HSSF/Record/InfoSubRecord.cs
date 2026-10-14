using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D9 RID: 985
	public class InfoSubRecord
	{
		// Token: 0x06002330 RID: 9008 RVA: 0x0006A7CB File Offset: 0x000689CB
		public InfoSubRecord(int streamPos, int bucketSstOffset)
		{
			this.field_1_stream_pos = streamPos;
			this.field_2_bucket_sst_offset = bucketSstOffset;
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0006A7E1 File Offset: 0x000689E1
		public InfoSubRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_stream_pos = in1.ReadInt();
			this.field_2_bucket_sst_offset = (int)in1.ReadShort();
			this.field_3_zero = in1.ReadShort();
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x0006A816 File Offset: 0x00068A16
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x0006A80D File Offset: 0x00068A0D
		public int StreamPos
		{
			get
			{
				return this.field_1_stream_pos;
			}
			set
			{
				this.field_1_stream_pos = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x0006A81E File Offset: 0x00068A1E
		public short BucketRecordOffset
		{
			set
			{
				this.field_2_bucket_sst_offset = (int)value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0006A827 File Offset: 0x00068A27
		public int BucketSSTOffset
		{
			get
			{
				return this.field_2_bucket_sst_offset;
			}
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0006A830 File Offset: 0x00068A30
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[EXTSST]\n");
			stringBuilder.Append("    .streampos      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.StreamPos)).Append("\n");
			stringBuilder.Append("    .bucketsstoffset= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BucketSSTOffset)).Append("\n");
			stringBuilder.Append("    .zero           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_3_zero)).Append("\n");
			stringBuilder.Append("[/EXTSST]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0006A8D1 File Offset: 0x00068AD1
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_stream_pos);
			out1.WriteShort(this.field_2_bucket_sst_offset);
			out1.WriteShort((int)this.field_3_zero);
		}

		// Token: 0x04000ED0 RID: 3792
		public const int ENCODED_SIZE = 8;

		// Token: 0x04000ED1 RID: 3793
		public const short sid = 4095;

		// Token: 0x04000ED2 RID: 3794
		private int field_1_stream_pos;

		// Token: 0x04000ED3 RID: 3795
		private int field_2_bucket_sst_offset;

		// Token: 0x04000ED4 RID: 3796
		private short field_3_zero;
	}
}
