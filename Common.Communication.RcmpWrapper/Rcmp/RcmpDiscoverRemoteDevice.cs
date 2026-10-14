using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002F RID: 47
	public class RcmpDiscoverRemoteDevice : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000BB90 File Offset: 0x00009D90
		public RcmpDiscoverRemoteDevice()
		{
			base.Opcode = 35;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public ushort BusID
		{
			get
			{
				short num = (short)1613186075;
				short num2 = num;
				num = (short)1172194331;
				switch (num2 == num)
				{
				}
				num = (short)1512308736;
				if (num != 0)
				{
				}
				num = (short)179896321;
				if (num != 0)
				{
				}
				num = (short)1625751552;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000BC5C File Offset: 0x00009E5C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)723063477;
			short num2 = num;
			num = (short)1826362037;
			switch (num2 == num)
			{
			}
			num = (short)1988427777;
			if (num != 0)
			{
			}
			num = (short)480903168;
			if (num != 0)
			{
			}
			num = (short)487325696;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000BD24 File Offset: 0x00009F24
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)945526394;
			short num2 = num;
			num = (short)342005370;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13B:
				num = (short)564002817;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_62;
			default:
			{
				num = (short)612171776;
				short num4 = num;
				goto IL_62;
			}
			}
			for (;;)
			{
				IL_81:
				switch (num3)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)341835778;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_E1;
				}
				goto IL_93;
			}
			IL_E1:
			num = (short)1947664385;
			if (num != 0)
			{
			}
			object[] array = new object[]
			{
				global::Motorola.Common.Communication.r.a
			};
			global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
			this.a = (ushort)array[0];
			goto IL_13B;
			IL_62:
			num = (short)1747648512;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_93;
			}
			goto IL_81;
			IL_93:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)2038038528;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_81;
		}

		// Token: 0x040000E9 RID: 233
		private ushort a;
	}
}
