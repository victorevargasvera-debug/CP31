using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000029 RID: 41
	internal class c : global::Motorola.Common.Communication.RUDP.States.f
	{
		// Token: 0x060001AE RID: 430 RVA: 0x0001B178 File Offset: 0x00019378
		public static global::Motorola.Common.Communication.RUDP.States.a b()
		{
			short num = (short)204800000;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_10E;
				case 2:
				{
					num = (short)1031703786;
					short num3 = num;
					num = (short)1005817066;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)907280385;
						if (num != 0)
						{
						}
						num = (short)1563885568;
						if (num != 0)
						{
						}
						num = (short)296157184;
						short num4 = num;
						global::Motorola.Common.Communication.RUDP.States.c.a = new global::Motorola.Common.Communication.RUDP.States.c();
						break;
					}
					}
					num = (short)1949958145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_32:
				if (global::Motorola.Common.Communication.RUDP.States.c.a != null)
				{
					break;
				}
				num = (short)147718146;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			return global::Motorola.Common.Communication.RUDP.States.c.a;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001B29C File Offset: 0x0001949C
		private c()
		{
			base.b(global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001B2B8 File Offset: 0x000194B8
		public override void k(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			short num = (short)356646912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_F1;
				case 2:
				{
					num = (short)41232099;
					short num3 = num;
					num = (short)658384611;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1614413824;
						if (num != 0)
						{
						}
						A_1.i.a0();
						A_0.ad();
						break;
					}
					num = (short)80281600;
					short num4 = num;
					num = (short)92274689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (A_1.b != global::Motorola.Common.Communication.RUDP.f.g)
				{
					return;
				}
				num = (short)1080229890;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			num = (short)106233857;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001B3E0 File Offset: 0x000195E0
		public override void l(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			int a_ = 2;
			short num = (short)1007362287;
			short num2 = num;
			num = (short)1632510191;
			switch (num2 == num)
			{
			}
			num = (short)1575223297;
			if (num != 0)
			{
			}
			num = (short)271056896;
			short num3 = num;
			num = (short)502267904;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("琥紧温簫ᐭု䀱儳䘵崷嬹䠻ḽ⌿⍁⡃⩅桇ॉ⁋⅍⍏㝑瑓㽕㙗穙Ὓቝ⽟ㅡⅣ㥥㽧⭩╫㩭偯űs᝵౷ό剻偽깿", a_), global::System.Array.Empty<object>());
		}

		// Token: 0x040000DA RID: 218
		private static global::Motorola.Common.Communication.RUDP.States.a a;
	}
}
