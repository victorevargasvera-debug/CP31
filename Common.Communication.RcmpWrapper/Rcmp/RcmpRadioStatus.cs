using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000040 RID: 64
	public class RcmpRadioStatus : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		public RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition condition)
		{
			base.Opcode = 14;
			this.Condition = condition;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		private global::Motorola.Common.Communication.Rcmp.RadioStatusCondition Condition
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1912213453;
				short num2 = num;
				num = (short)1800212429;
				switch (num2 == num)
				{
				}
				num = (short)1070727168;
				if (num != 0)
				{
				}
				num = (short)118292481;
				if (num != 0)
				{
				}
				num = (short)1606483968;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1165009096;
				short num2 = num;
				num = (short)799514824;
				switch (num2 == num)
				{
				}
				num = (short)358219777;
				if (num != 0)
				{
				}
				num = (short)345243648;
				if (num != 0)
				{
				}
				num = (short)208011264;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000D64C File Offset: 0x0000B84C
		public byte[] Status
		{
			get
			{
				short num;
				while (this.a != null)
				{
					num = (short)743450351;
					short num2 = num;
					num = (short)1811425007;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)218955776;
						if (num != 0)
						{
						}
						byte[] array = new byte[this.a.Length];
						global::System.Array.Copy(this.a, array, array.Length);
						return array;
					}
					}
				}
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000D720 File Offset: 0x0000B920
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)437846017;
			if (num != 0)
			{
			}
			num = (short)613947912;
			short num2 = num;
			num = (short)1807817224;
			switch (num2 == num)
			{
			}
			num = (short)1137180672;
			if (num != 0)
			{
			}
			num = (short)1785135104;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.Condition
			});
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1043726728;
			short num2 = num;
			num = (short)302514568;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14E:
				num = (short)882049025;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1081933824;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_A6:
				switch (num3)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)132382722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_104;
				}
				goto IL_B8;
			}
			IL_104:
			object[] array = new object[]
			{
				global::Motorola.Common.Communication.r.b,
				global::Motorola.Common.Communication.r.c
			};
			global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
			this.Condition = (global::Motorola.Common.Communication.Rcmp.RadioStatusCondition)array[0];
			this.a = (byte[])array[1];
			goto IL_14E;
			IL_5F:
			num = (short)1738211329;
			if (num != 0)
			{
			}
			num = (short)586285056;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			goto IL_A6;
			IL_B8:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)1106968576;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A6;
		}

		// Token: 0x04000136 RID: 310
		private byte[] a;

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.Rcmp.RadioStatusCondition b;
	}
}
