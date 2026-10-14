using System;
using System.Runtime.InteropServices;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x0200003F RID: 63
	internal class j
	{
		// Token: 0x060002D1 RID: 721
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern int SetWindowLong(global::System.IntPtr A_0, int A_1, int A_2);

		// Token: 0x060002D2 RID: 722
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern int GetWindowLong(global::System.IntPtr A_0, int A_1);

		// Token: 0x060002D3 RID: 723
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool SetWindowPos(global::System.IntPtr A_0, global::System.IntPtr A_1, int A_2, int A_3, int A_4, int A_5, int A_6);

		// Token: 0x060002D4 RID: 724
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr A_0, bool A_1);

		// Token: 0x060002D5 RID: 725
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool EnableMenuItem(global::System.IntPtr A_0, uint A_1, uint A_2);

		// Token: 0x060002D6 RID: 726 RVA: 0x00049A80 File Offset: 0x00047C80
		public static int b(int A_0)
		{
			short num = (short)1387909604;
			short num2 = num;
			num = (short)1395380708;
			switch (num2 == num)
			{
			}
			num = (short)1519910913;
			if (num != 0)
			{
			}
			num = (short)151126016;
			short num3 = num;
			num = (short)12976128;
			if (num != 0)
			{
			}
			return (int)((short)(A_0 & 65535));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00049B34 File Offset: 0x00047D34
		public static int a(int A_0)
		{
			short num = (short)1394123736;
			short num2 = num;
			num = (short)121480152;
			switch (num2 == num)
			{
			}
			num = (short)218038272;
			if (num != 0)
			{
			}
			num = (short)1416888320;
			short num3 = num;
			num = (short)215941121;
			if (num != 0)
			{
			}
			return (int)((short)(A_0 >> 16 & 65535));
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00049BE8 File Offset: 0x00047DE8
		public static int b(global::System.IntPtr A_0)
		{
			short num = (short)405842559;
			short num2 = num;
			num = (short)90417791;
			switch (num2 == num)
			{
			}
			num = (short)1054605312;
			if (num != 0)
			{
			}
			num = (short)306577408;
			short num3 = num;
			num = (short)1225457665;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfDock.j.b((int)((long)A_0));
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00049CA4 File Offset: 0x00047EA4
		public static int a(global::System.IntPtr A_0)
		{
			short num = (short)836667417;
			short num2 = num;
			num = (short)1978370073;
			switch (num2 == num)
			{
			}
			num = (short)112918529;
			if (num != 0)
			{
			}
			num = (short)76480512;
			short num3 = num;
			num = (short)1929445376;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfDock.j.a((int)((long)A_0));
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00049D58 File Offset: 0x00047F58
		internal static void a(string A_0)
		{
			int a_ = 14;
			if (A_0 == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("觌軎闐駜點폠퇢", a_))
			{
				short num = (short)956956672;
				short num2 = num;
				num = (short)1871752107;
				short num3 = num;
				num = (short)1999285163;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)203358209;
					if (num != 0)
					{
					}
					num = (short)1790902272;
					if (num != 0)
					{
					}
					global::DevComponents.WpfDock.j.c = true;
					return;
				}
			}
			global::DevComponents.WpfDock.j.c = false;
		}

		// Token: 0x060002DB RID: 731
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetCursorPos(ref global::DevComponents.WpfDock.j.g A_0);

		// Token: 0x040001AA RID: 426
		internal const uint a = 0U;

		// Token: 0x040001AB RID: 427
		internal const uint b = 1U;

		// Token: 0x040001AC RID: 428
		internal static bool c;

		// Token: 0x02000040 RID: 64
		public enum a
		{
			// Token: 0x040001AE RID: 430
			a = -20,
			// Token: 0x040001AF RID: 431
			b = -16
		}

		// Token: 0x02000041 RID: 65
		public enum b
		{
			// Token: 0x040001B1 RID: 433
			a = 262144
		}

		// Token: 0x02000042 RID: 66
		[global::System.Flags]
		public enum c
		{
			// Token: 0x040001B3 RID: 435
			a = 32,
			// Token: 0x040001B4 RID: 436
			b = 1,
			// Token: 0x040001B5 RID: 437
			c = 2,
			// Token: 0x040001B6 RID: 438
			d = 4
		}

		// Token: 0x02000043 RID: 67
		public enum d
		{
			// Token: 0x040001B8 RID: 440
			a = 163,
			// Token: 0x040001B9 RID: 441
			b = 160,
			// Token: 0x040001BA RID: 442
			c,
			// Token: 0x040001BB RID: 443
			d = 274
		}

		// Token: 0x02000044 RID: 68
		public enum e
		{
			// Token: 0x040001BD RID: 445
			a = 61536,
			// Token: 0x040001BE RID: 446
			b = 61504,
			// Token: 0x040001BF RID: 447
			c = 61520,
			// Token: 0x040001C0 RID: 448
			d = 61696,
			// Token: 0x040001C1 RID: 449
			e = 61728,
			// Token: 0x040001C2 RID: 450
			f = 61472,
			// Token: 0x040001C3 RID: 451
			g = 61488,
			// Token: 0x040001C4 RID: 452
			h = 61458,
			// Token: 0x040001C5 RID: 453
			i = 61440
		}

		// Token: 0x02000045 RID: 69
		public enum f
		{
			// Token: 0x040001C7 RID: 455
			a = -2,
			// Token: 0x040001C8 RID: 456
			b,
			// Token: 0x040001C9 RID: 457
			c,
			// Token: 0x040001CA RID: 458
			d,
			// Token: 0x040001CB RID: 459
			e,
			// Token: 0x040001CC RID: 460
			f,
			// Token: 0x040001CD RID: 461
			g,
			// Token: 0x040001CE RID: 462
			h,
			// Token: 0x040001CF RID: 463
			i,
			// Token: 0x040001D0 RID: 464
			j,
			// Token: 0x040001D1 RID: 465
			k,
			// Token: 0x040001D2 RID: 466
			l,
			// Token: 0x040001D3 RID: 467
			m,
			// Token: 0x040001D4 RID: 468
			n,
			// Token: 0x040001D5 RID: 469
			o,
			// Token: 0x040001D6 RID: 470
			p,
			// Token: 0x040001D7 RID: 471
			q,
			// Token: 0x040001D8 RID: 472
			r,
			// Token: 0x040001D9 RID: 473
			s,
			// Token: 0x040001DA RID: 474
			t,
			// Token: 0x040001DB RID: 475
			u,
			// Token: 0x040001DC RID: 476
			v,
			// Token: 0x040001DD RID: 477
			w,
			// Token: 0x040001DE RID: 478
			x,
			// Token: 0x040001DF RID: 479
			y = 4,
			// Token: 0x040001E0 RID: 480
			z = 8,
			// Token: 0x040001E1 RID: 481
			aa
		}

		// Token: 0x02000046 RID: 70
		internal struct g
		{
			// Token: 0x040001E2 RID: 482
			public int a;

			// Token: 0x040001E3 RID: 483
			public int b;
		}
	}
}
