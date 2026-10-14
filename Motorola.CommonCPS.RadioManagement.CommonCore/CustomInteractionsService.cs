using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Common;
using Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.CommonCore
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.Composition.Export]
	public class CustomInteractionsService
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024DC File Offset: 0x000006DC
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public CustomInteractionsService(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.a = eventAggregator;
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSTAProgressWindow>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext>(this.a));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002510 File Offset: 0x00000710
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext A_0)
		{
			short num = (short)350903873;
			short num2 = num;
			num = (short)1030184513;
			switch (num2 == num)
			{
			}
			num = (short)1396310016;
			short num3 = num;
			num = (short)543686657;
			if (num != 0)
			{
			}
			num = (short)651558912;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonCore.CustomInteractionsService.a a = new global::Motorola.CommonCPS.RadioManagement.CommonCore.CustomInteractionsService.a();
			a.a = A_0;
			a.c = this;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DisableMainViewEvent>().Publish(null);
			a.b = global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a.a(new global::System.Func<global::System.Windows.Window>(a.d));
			a.a.PropertyChanged += a.d;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000260C File Offset: 0x0000080C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1776924900 + A_1) + (global::System.IntPtr)61 + (global::System.IntPtr)3);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x04000004 RID: 4
		private readonly global::Microsoft.Practices.Prism.Events.IEventAggregator a;

		// Token: 0x02000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600000E RID: 14 RVA: 0x00002694 File Offset: 0x00000894
			internal global::System.Windows.Window d()
			{
				short num = (short)228205886;
				short num2 = num;
				num = (short)1616782654;
				switch (num2 == num)
				{
				}
				num = (short)283967488;
				short num3 = num;
				num = (short)1943142400;
				if (num != 0)
				{
				}
				num = (short)1875116033;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Common.WindowedProgressView(this.a);
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002748 File Offset: 0x00000948
			internal void d(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
			{
				int a_ = 8;
				short num = (short)1652883459;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1182203904;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						return;
					case 2:
						if (global::System.Math.Abs(this.a.Rate - 100.0) < 0.001)
						{
							num = (short)1623916548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 4:
					{
						num = (short)1338053325;
						short num4 = num;
						num = (short)1811616461;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B1;
						default:
							num = (short)881131520;
							if (num != 0)
							{
							}
							this.b.a();
							this.c.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EnableMainViewEvent>().Publish(null);
							num = (short)756940800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_6A;
					IL_B1:
					num = (short)1827733505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A:
					num = (short)2109734913;
					if (num != 0)
					{
					}
					if (A_1.PropertyName != global::Motorola.CommonCPS.RadioManagement.CommonCore.CustomInteractionsService.b("缬丮䔰嘲", a_))
					{
						goto IL_B1;
					}
					num = (short)856817666;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x04000005 RID: 5
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext a;

			// Token: 0x04000006 RID: 6
			public global::Motorola.CommonCPS.RadioManagement.CommonCore.ProgressWindow.a b;

			// Token: 0x04000007 RID: 7
			public global::Motorola.CommonCPS.RadioManagement.CommonCore.CustomInteractionsService c;
		}
	}
}
