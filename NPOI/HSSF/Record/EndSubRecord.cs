using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000428 RID: 1064
	public class EndSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x000618AB File Offset: 0x0005FAAB
		public EndSubRecord()
		{
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00075B56 File Offset: 0x00073D56
		public EndSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if ((size & 255) != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + size.ToString() + ")");
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsTerminating
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00075B83 File Offset: 0x00073D83
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ftEnd]\n");
			stringBuilder.Append("[/ftEnd]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00075BA7 File Offset: 0x00073DA7
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(0);
			out1.WriteShort(0);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override short Sid
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00075BB7 File Offset: 0x00073DB7
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.EndSubRecord();
		}

		// Token: 0x04001080 RID: 4224
		public const short sid = 0;

		// Token: 0x04001081 RID: 4225
		private const int ENCODED_SIZE = 0;
	}
}
