using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000040 RID: 64
	public class AcpKeyCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x060003BE RID: 958 RVA: 0x000411AC File Offset: 0x0003F3AC
		public bool CanExecute(object parameter)
		{
			short num = (short)283115521;
			if (num != 0)
			{
			}
			num = (short)1392783884;
			short num2 = num;
			num = (short)2066166284;
			switch (num2 == num)
			{
			}
			num = (short)1483800576;
			if (num != 0)
			{
			}
			num = (short)1993474048;
			short num3 = num;
			return true;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060003BF RID: 959 RVA: 0x00041258 File Offset: 0x0003F458
		// (remove) Token: 0x060003C0 RID: 960 RVA: 0x00041394 File Offset: 0x0003F594
		public event global::System.EventHandler CanExecuteChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						global::System.EventHandler eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_DE;
						case 1:
							goto IL_39;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num2 = (short)718340096;
								short num3 = num2;
								num2 = (short)881590272;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						}
						goto IL_1C;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
						num2 = (short)1193869313;
						if (num2 != 0)
						{
						}
						num2 = (short)1896742914;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_DE:
					num2 = (short)36758057;
					short num4 = num2;
					num2 = (short)335798825;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23;
					default:
						num2 = (short)1095237632;
						if (num2 != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_1C:
				eventHandler = this.a;
				IL_23:
				num2 = (short)1666121729;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						global::System.EventHandler eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D8;
						case 1:
							goto IL_3B;
						case 2:
							num2 = (short)217251841;
							if (num2 != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num2 = (short)1542520832;
								short num3 = num2;
								num2 = (short)1809842176;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_3B;
						}
						goto IL_1C;
						IL_3B:
						eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
						num2 = (short)1507524610;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_D8:
					num2 = (short)955212233;
					short num4 = num2;
					num2 = (short)790258121;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23;
					default:
						num2 = (short)1866203136;
						if (num2 != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_1C:
				eventHandler = this.a;
				IL_23:
				num2 = (short)705101825;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000414C4 File Offset: 0x0003F6C4
		public void Execute(object parameter)
		{
			short num = (short)851574784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::AcpUI.AcpCommandParameter acpCommandParameter;
				for (;;)
				{
					IL_27:
					global::System.Windows.Input.KeyEventArgs keyEventArgs;
					switch (num2)
					{
					case 0:
						goto IL_27B;
					case 1:
					{
						global::System.Windows.Input.Key key;
						if (key != global::System.Windows.Input.Key.Up)
						{
							num = (short)1007484937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					}
					case 2:
						goto IL_332;
					case 3:
						if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxDecHex))
						{
							num = (short)346423303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						num = (short)974230597;
						short num3 = num;
						num = (short)396006469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DD;
						default:
							num = (short)602210304;
							if (num != 0)
							{
							}
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxSpinner))
							{
								num = (short)732168192;
								short num4 = num;
								num = (short)1618673676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1823277059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_280;
					case 6:
						if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex))
						{
							num = (short)1263927306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)10158081;
						if (num != 0)
						{
						}
						num = (short)759365636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						keyEventArgs = (acpCommandParameter.EventArgs as global::System.Windows.Input.KeyEventArgs);
						global::System.Windows.Input.Key key = keyEventArgs.Key;
						num = (short)420675585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_29F;
					case 9:
						num = (short)385941515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpBusinessLayer.AcpFieldBase myBLObject = (acpCommandParameter.Parameter as global::AcpUI.AcpTableTextBoxSpinnerDecHex).MyBLObject;
						global::AcpUI.Common.StepUpDownUtility.a(acpCommandParameter.EventArgs as global::System.Windows.Input.KeyEventArgs, myBLObject);
						num = (short)320405504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.Input.Key key;
						if (key == global::System.Windows.Input.Key.Down)
						{
							goto IL_DD;
						}
						goto IL_334;
					}
					case 12:
					{
						global::AcpBusinessLayer.AcpFieldBase myBLObject = (acpCommandParameter.Parameter as global::AcpUI.AcpTableTextBoxSpinner).MyBLObject;
						global::AcpUI.Common.StepUpDownUtility.a(acpCommandParameter.EventArgs as global::System.Windows.Input.KeyEventArgs, myBLObject);
						num = (short)1411776514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_62;
					IL_DD:
					num = (short)1642725381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280:
					keyEventArgs.Handled = true;
					num = (short)1254031368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_27B:
				IL_29F:
				IL_332:
				IL_334:
				(acpCommandParameter.Sender as global::AcpUI.AcpTableTextBoxBase).AcpTableTextBox_PreviewKeyDown(acpCommandParameter.Sender, acpCommandParameter.EventArgs as global::System.Windows.Input.KeyEventArgs);
				return;
				IL_62:
				acpCommandParameter = (parameter as global::AcpUI.AcpCommandParameter);
				num = (short)1434910726;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000232 RID: 562
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;
	}
}
