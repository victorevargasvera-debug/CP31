using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000016 RID: 22
	public class ModifyCodeplugPasswordView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00008344 File Offset: 0x00006544
		public ModifyCodeplugPasswordView()
		{
			this.InitializeComponent();
			this.RMPassword.GotFocus += this.a;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008380 File Offset: 0x00006580
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)271074698;
			short num2 = num;
			num = (short)1631012234;
			switch (num2 == num)
			{
			}
			num = (short)1629880321;
			if (num != 0)
			{
			}
			num = (short)196149248;
			short num3 = num;
			num = (short)506003456;
			if (num != 0)
			{
			}
			base.OnMouseDown(e);
			this.a();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008434 File Offset: 0x00006634
		private void a()
		{
			short num = (short)1898763199;
			short num2 = num;
			num = (short)335270847;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)411566080;
				short num3 = num;
				break;
			}
			}
			num = (short)580190209;
			if (num != 0)
			{
			}
			num = (short)1728577536;
			if (num != 0)
			{
			}
			num = (short)561643520;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_BA:
				object obj = this.lockobj;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_126;
					}
					global::System.Windows.Window window;
					global::System.Windows.FrameworkElement frameworkElement;
					for (;;)
					{
						IL_CF:
						switch (num4)
						{
						case 0:
						{
							global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(window) as global::System.Windows.Interop.HwndSource;
							num = (short)632291344;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)732495880;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)356057098;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)2104885261;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (window != null)
							{
								num = (short)1276641280;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C2;
						case 5:
							num = (short)588185606;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (frameworkElement is global::System.Windows.Window)
							{
								num = (short)483459084;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
							num = (short)2021851147;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_382;
						case 8:
							if (window != null)
							{
								num = (short)147390467;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BA;
						case 9:
							goto IL_3C2;
						case 10:
							goto IL_221;
						case 11:
							goto IL_348;
						case 12:
							window = (frameworkElement as global::System.Windows.Window);
							num = (short)1378746375;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (window.Equals(this.parentWindow))
							{
								num = (short)730202114;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BA;
						case 14:
							goto IL_348;
						case 15:
						{
							global::System.Windows.Interop.HwndSource hwndSource;
							hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.WndProc));
							num = (short)239534089;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::System.Windows.Interop.HwndSource hwndSource;
							if (hwndSource != null)
							{
								num = (short)276168719;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C2;
						}
						case 17:
							goto IL_3DB;
						case 18:
							if (this.isAddHook)
							{
								num = (short)1046740993;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BA;
						case 19:
							if (frameworkElement != null)
							{
								num = (short)1936850949;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_382;
						}
						goto IL_126;
						IL_2BA:
						this.isAddHook = true;
						this.parentWindow = window;
						num = (short)1208745988;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_348:
						num = (short)440664083;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_382:
						num = (short)1437007890;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C2:
						num = (short)1855914001;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_221:
					IL_3DB:
					return;
					IL_126:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					frameworkElement = (base.Parent as global::System.Windows.FrameworkElement);
					window = null;
					num = (short)1914109966;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_CF;
				}
				finally
				{
					num = (short)1778057216;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_40F;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)2085552130;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_445;
						}
						IL_40F:
						if (!flag)
						{
							break;
						}
						num = (short)761659393;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_445:;
				}
				return;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000088A8 File Offset: 0x00006AA8
		protected virtual global::System.IntPtr WndProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)736362502;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)966268589;
				short num3 = num;
				num = (short)716314285;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2019098624;
					if (num != 0)
					{
					}
					int num4;
					switch (num2)
					{
					case 0:
						if (msg == 134)
						{
							num = (short)489488386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 1:
						if (num4 != 1)
						{
							goto IL_142;
						}
						goto IL_E3;
					case 2:
						this.deActivate = true;
						num = (short)1534001163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						this.deActivate = false;
						this.RMPassword.Password = string.Empty;
						num = (short)1645674496;
						short num5 = num;
						num = (short)1080688649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (this.deActivate)
						{
							num = (short)326107139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 5:
						num = (short)1624244234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_9E;
						}
						continue;
					case 7:
						goto IL_E3;
					case 8:
						num = (short)1069809664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1F1;
					case 10:
						if (num4 == 2)
						{
							num = (short)724172807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 11:
						goto IL_212;
					}
					IL_9E:
					num = (short)408944641;
					if (num != 0)
					{
					}
					if (msg != 6)
					{
						num = (short)54657032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = wParam.ToInt32();
					num = (short)1134166017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3:
					num = (short)5570564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_142:
				num = (short)1552220165;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F1:
			IL_212:
			IL_24B:
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008B08 File Offset: 0x00006D08
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)1785771529;
			short num2 = num;
			num = (short)1468708361;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)547880960;
				short num3 = num;
				num = (short)668598272;
				if (num != 0)
				{
				}
				num = (short)587005953;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鞷펻쪽꾿냁ꯃ꫅꧇迋ꇍ뷏뿑믓룕鯗諙进닟菡胣迥蟧꟩跫胭釯闱釳鯵鷷铹裻탽勿持怃漅朇ㄉ漋愍紏我笓砕紗琙栛ㄝ䴟䴡䀣伥丧匩伫䄭启圱䐳娵䴷崹䰻弽㌿ㅁ㍃⥅㩇⹉㩋❍㕏║筓㭕㝗㹙㕛㡝ᥟšୣɥ൧ᩩk᭭ᝯɱᕳյ୷൹፻౽ﾇꒉﶏﺑ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008BE8 File Offset: 0x00006DE8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1430650880;
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
				{
					num = (short)385351680;
					short num3 = num;
					num = (short)1694629890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_171;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_DA;
				case 2:
					goto IL_C0;
				case 3:
					goto IL_1B9;
				case 4:
					goto IL_14D;
				case 5:
					goto IL_1AC;
				case 6:
					goto IL_B3;
				case 7:
					goto IL_E7;
				case 8:
					goto IL_A6;
				case 9:
					goto IL_19F;
				case 10:
					goto IL_CD;
				case 11:
					goto IL_F4;
				default:
					num = (short)1744568321;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A6:
			this.OpenFileCheckBox = (global::System.Windows.Controls.CheckBox)target;
			return;
			IL_B3:
			this.ReadRadioCheckBox = (global::System.Windows.Controls.CheckBox)target;
			return;
			IL_C0:
			this.RMCheckCPPD = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_CD:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_DA:
			this.RMPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_E7:
			this.WriteRadioCheckBox = (global::System.Windows.Controls.CheckBox)target;
			return;
			IL_F4:
			num = (short)987910530;
			short num4 = num;
			num = (short)99307906;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1B9:
				this.PcrRMCPPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
				return;
			default:
				num = (short)1455685632;
				if (num != 0)
				{
				}
				this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
				return;
			}
			IL_14D:
			this.AstroRMCPPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_171:
			num = (short)454688769;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_19F:
			this.RMMaxAttempts = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_1AC:
			this.RMCombCPD = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008DC4 File Offset: 0x00006FC4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1433633292;
			short num2 = num;
			num = (short)179601932;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1679949824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)740884481;
			if (num != 0)
			{
			}
			num = (short)1287585792;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x04000041 RID: 65
		private object lockobj = new object();

		// Token: 0x04000042 RID: 66
		private bool isAddHook;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Window parentWindow;

		// Token: 0x04000044 RID: 68
		private bool deActivate;

		// Token: 0x04000045 RID: 69
		private const int WM_ACTIVATE = 6;

		// Token: 0x04000046 RID: 70
		private const int WM_NCACTIVATE = 134;

		// Token: 0x04000047 RID: 71
		private const int WA_ACTIVE = 1;

		// Token: 0x04000048 RID: 72
		private const int WA_CLICKACTIVE = 2;

		// Token: 0x04000049 RID: 73
		private const int WA_INACTIVE = 0;

		// Token: 0x0400004A RID: 74
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox RMPassword;

		// Token: 0x0400004B RID: 75
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox RMCheckCPPD;

		// Token: 0x0400004C RID: 76
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox PcrRMCPPassword;

		// Token: 0x0400004D RID: 77
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox AstroRMCPPassword;

		// Token: 0x0400004E RID: 78
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox RMCombCPD;

		// Token: 0x0400004F RID: 79
		internal global::System.Windows.Controls.CheckBox ReadRadioCheckBox;

		// Token: 0x04000050 RID: 80
		internal global::System.Windows.Controls.CheckBox WriteRadioCheckBox;

		// Token: 0x04000051 RID: 81
		internal global::System.Windows.Controls.CheckBox OpenFileCheckBox;

		// Token: 0x04000052 RID: 82
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput RMMaxAttempts;

		// Token: 0x04000053 RID: 83
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000054 RID: 84
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000055 RID: 85
		private bool _contentLoaded;
	}
}
