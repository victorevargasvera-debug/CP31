using System;
using System.Globalization;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BD RID: 957
	public class ContinueRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600219A RID: 8602 RVA: 0x0005FE49 File Offset: 0x0005E049
		private ContinueRecord()
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00066869 File Offset: 0x00064A69
		public ContinueRecord(byte[] data)
		{
			this.field_1_data = data;
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00066878 File Offset: 0x00064A78
		public ContinueRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_data = in1.ReadRemainder();
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0006688C File Offset: 0x00064A8C
		protected override int DataSize
		{
			get
			{
				return this.field_1_data.Length;
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00066896 File Offset: 0x00064A96
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this.field_1_data);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000668A4 File Offset: 0x00064AA4
		[global::System.Obsolete]
		public static int Write(byte[] destBuf, int destOffset, byte? initialDataByte, byte[] srcData)
		{
			return global::NPOI.HSSF.Record.ContinueRecord.Write(destBuf, destOffset, initialDataByte, srcData, 0, srcData.Length);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000668B4 File Offset: 0x00064AB4
		[global::System.Obsolete]
		public static int Write(byte[] destBuf, int destOffset, byte? initialDataByte, byte[] srcData, int srcOffset, int len)
		{
			int num = len + ((initialDataByte == null) ? 0 : 1);
			global::NPOI.Util.LittleEndian.PutUShort(destBuf, destOffset, 60);
			global::NPOI.Util.LittleEndian.PutUShort(destBuf, destOffset + 2, num);
			int num2 = destOffset + 4;
			if (initialDataByte != null)
			{
				global::NPOI.Util.LittleEndian.PutByte(destBuf, num2, (int)global::System.Convert.ToByte(initialDataByte, global::System.Globalization.CultureInfo.InvariantCulture));
				num2++;
			}
			global::System.Array.Copy(srcData, srcOffset, destBuf, num2, len);
			return 4 + num;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0006691C File Offset: 0x00064B1C
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00066924 File Offset: 0x00064B24
		public byte[] Data
		{
			get
			{
				return this.field_1_data;
			}
			set
			{
				this.field_1_data = value;
			}
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00066930 File Offset: 0x00064B30
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CONTINUE RECORD]\n");
			stringBuilder.Append("    .data        = ").Append(global::NPOI.Util.StringUtil.ToHexString(60)).Append("\n");
			stringBuilder.Append("[/CONTINUE RECORD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00066981 File Offset: 0x00064B81
		public override short Sid
		{
			get
			{
				return 60;
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00066985 File Offset: 0x00064B85
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ContinueRecord
			{
				Data = this.field_1_data
			};
		}

		// Token: 0x04000D33 RID: 3379
		public const short sid = 60;

		// Token: 0x04000D34 RID: 3380
		private byte[] field_1_data;
	}
}
