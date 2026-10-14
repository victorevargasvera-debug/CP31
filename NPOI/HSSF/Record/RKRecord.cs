using System;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000417 RID: 1047
	public class RKRecord : global::NPOI.HSSF.Record.CellRecord
	{
		// Token: 0x0600263B RID: 9787 RVA: 0x00064026 File Offset: 0x00062226
		public RKRecord()
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000733FC File Offset: 0x000715FC
		public RKRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this.field_4_rk_number = in1.ReadInt();
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x00073411 File Offset: 0x00071611
		public int RKField
		{
			get
			{
				return this.field_4_rk_number;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x00073419 File Offset: 0x00071619
		public short RKType
		{
			get
			{
				return (short)(this.field_4_rk_number & 3);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x00073424 File Offset: 0x00071624
		public double RKNumber
		{
			get
			{
				return global::NPOI.HSSF.Util.RKUtil.DecodeNumber(this.field_4_rk_number);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x00073431 File Offset: 0x00071631
		protected override string RecordName
		{
			get
			{
				return "RK";
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00073438 File Offset: 0x00071638
		protected override void AppendValueText(global::System.Text.StringBuilder sb)
		{
			sb.Append("  .value= ").Append(this.RKNumber);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00073451 File Offset: 0x00071651
		protected override void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_4_rk_number);
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x00018498 File Offset: 0x00016698
		protected override int ValueDataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x0007345F File Offset: 0x0007165F
		public override short Sid
		{
			get
			{
				return 638;
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00073468 File Offset: 0x00071668
		public new object Clone()
		{
			global::NPOI.HSSF.Record.RKRecord rkrecord = new global::NPOI.HSSF.Record.RKRecord();
			base.CopyBaseFields(rkrecord);
			rkrecord.field_4_rk_number = this.field_4_rk_number;
			return rkrecord;
		}

		// Token: 0x04001001 RID: 4097
		public const short sid = 638;

		// Token: 0x04001002 RID: 4098
		public const short RK_IEEE_NUMBER = 0;

		// Token: 0x04001003 RID: 4099
		public const short RK_IEEE_NUMBER_TIMES_100 = 1;

		// Token: 0x04001004 RID: 4100
		public const short RK_INTEGER = 2;

		// Token: 0x04001005 RID: 4101
		public const short RK_INTEGER_TIMES_100 = 3;

		// Token: 0x04001006 RID: 4102
		private int field_4_rk_number;
	}
}
