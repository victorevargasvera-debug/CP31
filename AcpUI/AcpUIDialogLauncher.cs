using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Navigation;

namespace AcpUI
{
	// Token: 0x0200003B RID: 59
	internal class AcpUIDialogLauncher<T> : global::System.Windows.Navigation.PageFunction<T>
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x0003F714 File Offset: 0x0003D914
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void a(global::AcpUI.AcpUIDialogLauncherReturnEventHandler A_0)
		{
			short num;
			int num3;
			global::AcpUI.AcpUIDialogLauncherReturnEventHandler acpUIDialogLauncherReturnEventHandler;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1730186970;
					short num2 = num;
					num = (short)1976274650;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
					{
						num = (short)93061120;
						if (num != 0)
						{
						}
						global::AcpUI.AcpUIDialogLauncherReturnEventHandler acpUIDialogLauncherReturnEventHandler2;
						switch (num3)
						{
						case 0:
							return;
						case 1:
							num = (short)1212874753;
							if (num != 0)
							{
							}
							if (acpUIDialogLauncherReturnEventHandler == acpUIDialogLauncherReturnEventHandler2)
							{
								num = (short)419364864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_83;
						case 2:
							goto IL_83;
						}
						goto IL_65;
						IL_83:
						num = (short)1736245248;
						short num4 = num;
						acpUIDialogLauncherReturnEventHandler2 = acpUIDialogLauncherReturnEventHandler;
						global::AcpUI.AcpUIDialogLauncherReturnEventHandler value = (global::AcpUI.AcpUIDialogLauncherReturnEventHandler)global::System.Delegate.Combine(acpUIDialogLauncherReturnEventHandler2, A_0);
						acpUIDialogLauncherReturnEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.AcpUIDialogLauncherReturnEventHandler>(ref this.b, value, acpUIDialogLauncherReturnEventHandler2);
						num = (short)654704641;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
			}
			IL_65:
			acpUIDialogLauncherReturnEventHandler = this.b;
			IL_6C:
			num = (short)40370178;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0003F84C File Offset: 0x0003DA4C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void b(global::AcpUI.AcpUIDialogLauncherReturnEventHandler A_0)
		{
			short num;
			int num3;
			global::AcpUI.AcpUIDialogLauncherReturnEventHandler acpUIDialogLauncherReturnEventHandler;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)2066795077;
					short num2 = num;
					num = (short)1151978053;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
					{
						num = (short)1751515136;
						if (num != 0)
						{
						}
						global::AcpUI.AcpUIDialogLauncherReturnEventHandler acpUIDialogLauncherReturnEventHandler2;
						switch (num3)
						{
						case 0:
							return;
						case 1:
							if (acpUIDialogLauncherReturnEventHandler == acpUIDialogLauncherReturnEventHandler2)
							{
								num = (short)1710555137;
								if (num != 0)
								{
								}
								num = (short)1729232896;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_86;
						case 2:
							goto IL_86;
						}
						goto IL_67;
						IL_86:
						num = (short)646643712;
						short num4 = num;
						acpUIDialogLauncherReturnEventHandler2 = acpUIDialogLauncherReturnEventHandler;
						global::AcpUI.AcpUIDialogLauncherReturnEventHandler value = (global::AcpUI.AcpUIDialogLauncherReturnEventHandler)global::System.Delegate.Remove(acpUIDialogLauncherReturnEventHandler2, A_0);
						acpUIDialogLauncherReturnEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.AcpUIDialogLauncherReturnEventHandler>(ref this.b, value, acpUIDialogLauncherReturnEventHandler2);
						num = (short)2098331649;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
			}
			IL_67:
			acpUIDialogLauncherReturnEventHandler = this.b;
			IL_6E:
			num = (short)477036546;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0003F980 File Offset: 0x0003DB80
		internal AcpUIDialogLauncher(global::System.Windows.Navigation.PageFunction<T> A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0003F99C File Offset: 0x0003DB9C
		protected override void Start()
		{
			short num = (short)1984606315;
			short num2 = num;
			num = (short)1165275243;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1565130752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)131203072;
			if (num != 0)
			{
			}
			num = (short)800653313;
			if (num != 0)
			{
			}
			base.Start();
			base.KeepAlive = true;
			this.a.Return += this.PageReturn;
			base.NavigationService.Navigate(this.a);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003FA78 File Offset: 0x0003DC78
		private void OnLoaded(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)639410717;
			short num2 = num;
			num = (short)705864221;
			switch (num2 == num)
			{
			default:
			{
				num = (short)3670016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1993932801;
			if (num != 0)
			{
			}
			num = (short)526057472;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003FB20 File Offset: 0x0003DD20
		internal void PageReturn(object A_0, global::System.Windows.Navigation.ReturnEventArgs<T> A_1)
		{
			short num = (short)1454899204;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2111111168;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1272774657;
					if (num != 0)
					{
					}
					num = (short)1031536642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)541008865;
					short num4 = num;
					num = (short)2075337697;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num = (short)1712717824;
						if (num != 0)
						{
						}
						this.b(this, new global::AcpUI.PageReturnEventArgs(true, A_1.Result));
						num = (short)914620419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_FD;
				case 3:
					goto IL_B8;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (this.b != null)
				{
					num = (short)463536128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FD:
				if (A_1 == null)
				{
					break;
				}
				num = (short)1559756801;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B8:
			this.OnReturn(null);
		}

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Navigation.PageFunction<T> a;

		// Token: 0x0400022C RID: 556
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpUI.AcpUIDialogLauncherReturnEventHandler b;
	}
}
