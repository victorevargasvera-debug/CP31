using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow
{
	// Token: 0x02000007 RID: 7
	internal class a : global::System.IDisposable
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002904 File Offset: 0x00000B04
		private a(global::System.Func<global::System.Windows.Window> A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.b b = new global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.b();
			b.b = A_0;
			base..ctor();
			b.a = this;
			this.b = new global::System.Threading.SemaphoreSlim(0);
			this.a = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(b.c));
			this.a.SetApartmentState(global::System.Threading.ApartmentState.STA);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000295C File Offset: 0x00000B5C
		public static global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a a(global::System.Func<global::System.Windows.Window> A_0)
		{
			short num = (short)511859725;
			short num2 = num;
			num = (short)1381063693;
			switch (num2 == num)
			{
			}
			num = (short)1630470144;
			short num3 = num;
			num = (short)1364262912;
			if (num != 0)
			{
			}
			num = (short)1174863873;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a a = new global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a(A_0);
			a.a.Start();
			a.b.Wait();
			return a;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A24 File Offset: 0x00000C24
		public void a()
		{
			short num = (short)342425601;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)258408448;
					short num3 = num;
					num = (short)1035042369;
					short num4 = num;
					num = (short)1607958081;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1376257;
						if (num != 0)
						{
						}
						num = (short)1245708288;
						if (num != 0)
						{
						}
						global::System.Threading.Thread.Sleep(200);
						this.Dispose();
						num = (short)1220608002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return;
				}
				IL_31:
				if (this.c == null)
				{
					break;
				}
				num = (short)759758848;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B4C File Offset: 0x00000D4C
		public void Dispose()
		{
			short num = (short)1164443649;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)124387328;
					short num3 = num;
					num = (short)1602374760;
					short num4 = num;
					num = (short)398806120;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)571867136;
						if (num != 0)
						{
						}
						num = (short)1388511233;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.a.a();
						this.c.Dispatcher.Invoke(new global::System.Action(this.c.Close));
						this.c.Dispatcher.InvokeShutdown();
						this.c = null;
						num = (short)1784152066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					return;
				}
				IL_30:
				if (this.c == null)
				{
					break;
				}
				num = (short)40763392;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000008 RID: 8
		private readonly global::System.Threading.Thread a;

		// Token: 0x04000009 RID: 9
		private readonly global::System.Threading.SemaphoreSlim b;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Window c;

		// Token: 0x02000008 RID: 8
		[global::System.Security.SuppressUnmanagedCodeSecurity]
		internal static class a
		{
			// Token: 0x06000014 RID: 20
			[global::System.Security.SuppressUnmanagedCodeSecurity]
			[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
			public static extern bool PeekMessage(out global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.a.a A_0, global::System.IntPtr A_1, uint A_2, uint A_3, uint A_4);

			// Token: 0x06000015 RID: 21 RVA: 0x00002CA0 File Offset: 0x00000EA0
			public static void a()
			{
				short num;
				for (;;)
				{
					num = (short)266403841;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.a.a a;
					if (!global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.a.PeekMessage(out a, global::System.IntPtr.Zero, 512U, 525U, 1U))
					{
						num = (short)1457363506;
						short num2 = num;
						num = (short)1355651634;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_9D;
						}
						break;
					}
				}
				num = (short)1529348096;
				short num3 = num;
				IL_9D:
				num = (short)903741440;
				if (num != 0)
				{
				}
			}

			// Token: 0x0400000B RID: 11
			private const uint a = 512U;

			// Token: 0x0400000C RID: 12
			private const uint b = 525U;

			// Token: 0x0400000D RID: 13
			private const int c = 1;

			// Token: 0x02000009 RID: 9
			public struct a
			{
				// Token: 0x0400000E RID: 14
				public global::System.IntPtr a;

				// Token: 0x0400000F RID: 15
				public uint b;

				// Token: 0x04000010 RID: 16
				public global::System.IntPtr c;

				// Token: 0x04000011 RID: 17
				public global::System.IntPtr d;

				// Token: 0x04000012 RID: 18
				public uint e;

				// Token: 0x04000013 RID: 19
				public global::System.Windows.Point f;
			}
		}

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000017 RID: 23 RVA: 0x00002D78 File Offset: 0x00000F78
			internal void c()
			{
				short num = (short)1477138743;
				short num2 = num;
				num = (short)1910266167;
				switch (num2 == num)
				{
				}
				num = (short)143589376;
				short num3 = num;
				num = (short)269746177;
				if (num != 0)
				{
				}
				num = (short)384761856;
				if (num != 0)
				{
				}
				this.a.c = this.b();
				this.a.c.Show();
				this.a.b.Release();
				global::System.Windows.Threading.Dispatcher.Run();
			}

			// Token: 0x04000014 RID: 20
			public global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a a;

			// Token: 0x04000015 RID: 21
			public global::System.Func<global::System.Windows.Window> b;
		}
	}
}
