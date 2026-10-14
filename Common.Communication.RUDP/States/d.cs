using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x0200002A RID: 42
	internal class d : global::Motorola.Common.Communication.RUDP.States.f
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0001B4B0 File Offset: 0x000196B0
		public static global::Motorola.Common.Communication.RUDP.States.a b()
		{
			short num = (short)574816256;
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
					goto IL_10E;
				case 2:
				{
					num = (short)2069889025;
					if (num != 0)
					{
					}
					num = (short)1413339329;
					short num3 = num;
					num = (short)363256001;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)626655232;
						if (num != 0)
						{
						}
						num = (short)171573248;
						short num4 = num;
						global::Motorola.Common.Communication.RUDP.States.d.a = new global::Motorola.Common.Communication.RUDP.States.d();
						break;
					}
					}
					num = (short)143130625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (global::Motorola.Common.Communication.RUDP.States.d.a != null)
				{
					break;
				}
				num = (short)1956577282;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			return global::Motorola.Common.Communication.RUDP.States.d.a;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public d()
		{
			base.b(global::Motorola.Common.Communication.RUDP.RUDPSockState.LISTEN);
		}

		// Token: 0x040000DB RID: 219
		private static global::Motorola.Common.Communication.RUDP.States.a a;
	}
}
