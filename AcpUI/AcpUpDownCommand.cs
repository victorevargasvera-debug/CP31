using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200003E RID: 62
	public class AcpUpDownCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x00040018 File Offset: 0x0003E218
		public bool CanExecute(object parameter)
		{
			short num = (short)946859528;
			short num2 = num;
			num = (short)429387272;
			switch (num2 == num)
			{
			default:
			{
				num = (short)399441920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)652279808;
			if (num != 0)
			{
			}
			num = (short)260243457;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003B5 RID: 949 RVA: 0x000400C4 File Offset: 0x0003E2C4
		// (remove) Token: 0x060003B6 RID: 950 RVA: 0x000401FC File Offset: 0x0003E3FC
		public event global::System.EventHandler CanExecuteChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num;
				int num3;
				global::System.EventHandler eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)602923494;
						short num2 = num;
						num = (short)1854661094;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_93;
						default:
						{
							num = (short)1546911745;
							if (num != 0)
							{
							}
							num = (short)1012006912;
							if (num != 0)
							{
							}
							global::System.EventHandler eventHandler2;
							switch (num3)
							{
							case 0:
								return;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)1836711936;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D6;
							case 2:
							{
								num = (short)1103429632;
								short num4 = num;
								goto IL_D6;
							}
							}
							goto IL_8C;
							IL_D6:
							eventHandler2 = eventHandler;
							global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
							num = (short)487587841;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					return;
				}
				IL_8C:
				eventHandler = this.a;
				IL_93:
				num = (short)629932034;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num;
				int num3;
				global::System.EventHandler eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)1679567993;
						short num2 = num;
						num = (short)685911161;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_93;
						default:
						{
							num = (short)1319436288;
							if (num != 0)
							{
							}
							num = (short)1400504321;
							if (num != 0)
							{
							}
							global::System.EventHandler eventHandler2;
							switch (num3)
							{
							case 0:
								return;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)1592393728;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D7;
							case 2:
							{
								num = (short)1103953920;
								short num4 = num;
								goto IL_D7;
							}
							}
							goto IL_8C;
							IL_D7:
							eventHandler2 = eventHandler;
							global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
							num = (short)176226305;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					return;
				}
				IL_8C:
				eventHandler = this.a;
				IL_93:
				num = (short)91291650;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00040334 File Offset: 0x0003E534
		public void Execute(object parameter)
		{
			short num = (short)1166470548;
			short num2 = num;
			num = (short)1743449492;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1812070400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1519386624;
			if (num != 0)
			{
			}
			num = (short)993263617;
			if (num != 0)
			{
			}
			global::AcpUI.AcpCommandParameter acpCommandParameter = parameter as global::AcpUI.AcpCommandParameter;
			global::AcpUI.Common.StepUpDownUtility.a(acpCommandParameter.Sender, acpCommandParameter.Parameter as global::AcpBusinessLayer.AcpFieldBase);
		}

		// Token: 0x04000230 RID: 560
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;
	}
}
