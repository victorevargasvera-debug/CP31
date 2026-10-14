using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CF RID: 975
	public class EOFRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002264 RID: 8804 RVA: 0x0005FE49 File Offset: 0x0005E049
		public EOFRecord()
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0005FE49 File Offset: 0x0005E049
		public EOFRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00068007 File Offset: 0x00066207
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[EOF]\n");
			stringBuilder.Append("[/EOF]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00018662 File Offset: 0x00016862
		public override short Sid
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00047B5F File Offset: 0x00045D5F
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.EOFRecord();
		}

		// Token: 0x04000D82 RID: 3458
		public const short sid = 10;

		// Token: 0x04000D83 RID: 3459
		public const int ENCODED_SIZE = 4;

		// Token: 0x04000D84 RID: 3460
		public static readonly global::NPOI.HSSF.Record.EOFRecord instance = new global::NPOI.HSSF.Record.EOFRecord();
	}
}
