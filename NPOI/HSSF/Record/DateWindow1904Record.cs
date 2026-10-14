using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C2 RID: 962
	public class DateWindow1904Record : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060021C2 RID: 8642 RVA: 0x0005FE49 File Offset: 0x0005E049
		public DateWindow1904Record()
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00066C9D File Offset: 0x00064E9D
		public DateWindow1904Record(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_window = in1.ReadShort();
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00066CB1 File Offset: 0x00064EB1
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x00066CB9 File Offset: 0x00064EB9
		public short Windowing
		{
			get
			{
				return this.field_1_window;
			}
			set
			{
				this.field_1_window = value;
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00066CC4 File Offset: 0x00064EC4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[1904]\n");
			stringBuilder.Append("    .is1904          = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Windowing)).Append("\n");
			stringBuilder.Append("[/1904]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00066D19 File Offset: 0x00064F19
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Windowing);
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00066D27 File Offset: 0x00064F27
		public override short Sid
		{
			get
			{
				return 34;
			}
		}

		// Token: 0x04000D41 RID: 3393
		public const short sid = 34;

		// Token: 0x04000D42 RID: 3394
		private short field_1_window;
	}
}
