using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.CSharp.RuntimeBinder;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000038 RID: 56
	public class SettingsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000167 RID: 359 RVA: 0x000186F4 File Offset: 0x000168F4
		public SettingsView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt = (global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.CleanPasswordEvt)global::System.Delegate.Combine(global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt, new global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.CleanPasswordEvt(this.HandleCleanPassowordEvt));
			this.txtBlockRecoverCMSCLicense.Visibility = global::System.Windows.Visibility.Hidden;
			this.btnRecoverCMSCLicense.Visibility = global::System.Windows.Visibility.Hidden;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
			{
				this.lbLicenses.IsSelected = true;
			}
			base.DataContextChanged += this.b;
			base.Loaded += this.a;
			base.IsVisibleChanged += this.a;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00018798 File Offset: 0x00016998
		private void b()
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			int num;
			short num2;
			global::System.Windows.Controls.ListBoxItem listBoxItem;
			string name;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)2000945169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					num2 = (short)1243152392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					uint num3;
					if (num3 != 3931609814U)
					{
						num2 = (short)1202520068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3ED;
				}
				case 4:
					return;
				case 5:
				{
					uint num3;
					if (num3 != 2317727307U)
					{
						num2 = (short)1580924956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_184;
				}
				case 6:
					num2 = (short)212664335;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
				{
					uint num3;
					if (num3 != 3846887551U)
					{
						num2 = (short)688455700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12E;
				}
				case 9:
					goto IL_5B4;
				case 10:
					num2 = (short)932118533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)458424346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					uint num3;
					if (num3 <= 2317727307U)
					{
						num2 = (short)1460666368;
						short num4 = num2;
						num2 = (short)623378432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)35323927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					num2 = (short)1998127118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					num2 = (short)1102302496;
					short num5 = num2;
					num2 = (short)611568928;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B4;
					default:
					{
						num2 = (short)917504;
						if (num2 != 0)
						{
						}
						uint num3;
						if (num3 != 1294746715U)
						{
							num2 = (short)127533063;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1460273173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 15:
				{
					uint num3;
					if (num3 != 240411240U)
					{
						num2 = (short)347078657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)218562582;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
				{
					if (listBoxItem == null)
					{
						num2 = (short)1833369627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					name = listBoxItem.Name;
					uint num3 = global::h.a(name);
					num2 = (short)1138163731;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 17:
				{
					uint num3;
					if (num3 != 1929082914U)
					{
						num2 = (short)229113866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				}
				case 18:
					return;
				case 19:
				{
					uint num3;
					if (num3 <= 1294746715U)
					{
						num2 = (short)771948553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1108148225;
					if (num2 != 0)
					{
					}
					num2 = (short)963772428;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 20:
					num2 = (short)501940227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥ꯧ藩苫胭闯釱胳鿵韷铹", a_)))
					{
						num2 = (short)643235858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_291;
				case 22:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥뷧駩觫鳭", a_)))
					{
						num2 = (short)1716453405;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5D0;
				case 23:
				{
					uint num3;
					if (num3 != 3617337103U)
					{
						num2 = (short)574226434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5B9;
				}
				case 24:
				{
					uint num3;
					if (num3 <= 240411240U)
					{
						num2 = (short)916258827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2001338393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 25:
				{
					uint num3;
					if (num3 != 1292600093U)
					{
						num2 = (short)1536360461;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D6;
				}
				case 26:
				{
					uint num3;
					if (num3 != 190297451U)
					{
						num2 = (short)853344262;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27B;
				}
				case 27:
					return;
				case 28:
					return;
				case 29:
					return;
				}
				goto IL_91;
				IL_5B4:
				num2 = (short)488701976;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_12E:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥ꫧ鿩飫髭鿯鳱雳韵諷럹鏻髽旿", a_);
			return;
			IL_184:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥ꓧ菩迫语黯臱釳藵", a_);
			return;
			IL_19A:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥ꃧ菩裫諭闯鳱맳鏵请觹鷻駽旿", a_);
			return;
			IL_27B:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥곧诩飫迭鋯鏱蟳鏵꯷鏹蛻鯽䧿氁戃椅", a_);
			return;
			IL_291:
			this.rtbAddress.Focus();
			return;
			IL_3ED:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥곧迩跫苭闯胱", a_);
			return;
			IL_4D6:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥ꓧ诩苫觭藯鏱鏳鏵", a_);
			return;
			IL_5B9:
			name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("裣蓥臧ꛩ菫觭韯鯱髳釵", a_);
			return;
			IL_5D0:
			this.OldPasswordBox.Focus();
			return;
			IL_91:
			listBoxItem = (this.listBox.SelectedItem as global::System.Windows.Controls.ListBoxItem);
			num2 = (short)1627586576;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00018D84 File Offset: 0x00016F84
		public void HandleCleanPassowordEvt(global::System.EventArgs e)
		{
			short num = (short)2111832071;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (this.ConfirmedPasswordBox.SecurePassword != null)
					{
						num = (short)1154940933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (this.NewPasswordBox.SecurePassword != null)
					{
						num = (short)1784086531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72;
				case 3:
				{
					num = (short)1837105152;
					short num3 = num;
					num = (short)953663413;
					short num4 = num;
					num = (short)1306050485;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)683409408;
						if (num != 0)
						{
						}
						this.NewPasswordBox.Clear();
						num = (short)571015176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1C4;
				case 5:
					num = (short)310706177;
					if (num != 0)
					{
					}
					this.ConfirmedPasswordBox.Clear();
					num = (short)219611136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.OldPasswordBox.Clear();
					num = (short)1931608068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 8:
					goto IL_72;
				}
				IL_49:
				if (this.OldPasswordBox.SecurePassword != null)
				{
					num = (short)2077491206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C4;
				IL_72:
				num = (short)1335689217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)882507778;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000042 RID: 66
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00018F9C File Offset: 0x0001719C
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel ViewModel
		{
			set
			{
				short num = (short)1536809846;
				short num2 = num;
				num = (short)1444797302;
				switch (num2 == num)
				{
				}
				num = (short)1287192577;
				if (num != 0)
				{
				}
				num = (short)1576665088;
				if (num != 0)
				{
				}
				num = (short)1369571328;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001904C File Offset: 0x0001724C
		private void e(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)560594949;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.c.Target;
					global::System.Runtime.CompilerServices.CallSite c = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.c;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.b == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蟔髖賘꣚룜귞뇠苢雤铦黨蓪鿬诮", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object> target2 = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛔닖귘꿚드뇞蛠郢ꛤ裦蟨鿪裬韮藰", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(c, target2(b, global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.a, base.DataContext)), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)1872151726;
					short num3 = num;
					num = (short)1662829742;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7F;
					default:
						num = (short)785907713;
						if (num != 0)
						{
						}
						num = (short)1240399872;
						if (num != 0)
						{
						}
						num = (short)2359298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_124;
				case 2:
					return;
				case 3:
					goto IL_7F;
				case 4:
					num = (short)542572547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.c = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛔닖뫘껚꿜뫞껠迢臤럦裨飪黬飮黰臲釴", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)1680343041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)252772356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7F:
				num = (short)1456603136;
				short num4 = num;
				if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.a.c == null)
				{
					num = (short)1422393350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_124:
				num = (short)526319616;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000192F4 File Offset: 0x000174F4
		private void d(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)201981957;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1569193985;
					if (num != 0)
					{
					}
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.c.Target;
					global::System.Runtime.CompilerServices.CallSite c = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.c;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.b == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諗韙觛귝藟郡듣蟥鯧駩鯫臭苯雱", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object> target2 = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诗뿙꣛ꫝ觟賡菣闥ꯧ藩苫髭闯諱胳", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(c, target2(b, global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.a, base.DataContext)), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)1668480397;
					short num3 = num;
					num = (short)603848077;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						num = (short)1037959168;
						if (num != 0)
						{
						}
						num = (short)202768386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_124;
				case 2:
					return;
				case 3:
					goto IL_80;
				case 4:
					num = (short)56819715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.c = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诗뿙뿛ꯝ鋟蟡ꫣ菥鿧뫩跫鷭華藱鯳蓵鳷", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)1230766081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)959184900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_80:
				num = (short)1403191296;
				short num4 = num;
				if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.b.c == null)
				{
					num = (short)127664134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_124:
				num = (short)1280376832;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000195A0 File Offset: 0x000177A0
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)865206277;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.c.Target;
					global::System.Runtime.CompilerServices.CallSite c = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.c;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.b == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远鋞든郢胤闦맨諪黬鳮蛰鳲蟴鏶", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object> target2 = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軜뫞闠韢賤触軨飪껬胮鿰蟲郴迶跸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(c, target2(b, global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.a, base.DataContext)), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)838674409;
					short num3 = num;
					num = (short)227878889;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7F;
					default:
						num = (short)588447744;
						if (num != 0)
						{
						}
						num = (short)140705794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)857276417;
					if (num != 0)
					{
					}
					goto IL_14F;
				case 2:
					return;
				case 3:
					goto IL_7F;
				case 4:
					num = (short)1596129283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.c = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軜뫞苠離韤苦ꫨ蓪菬觮飰臲飴鋶鷸꯺鳼賾爀琂樄甆洈", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SettingsView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)298516481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)972488708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7F:
				num = (short)2124873728;
				short num4 = num;
				if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsView.c.c == null)
				{
					num = (short)1345978374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14F:
				num = (short)916258816;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001984C File Offset: 0x00017A4C
		private void a(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			object obj;
			global::System.Windows.Controls.ListBox listBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)320339969;
					if (num2 != 0)
					{
					}
					obj = A_1.RemovedItems[0];
					num2 = (short)170131459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_1.RemovedItems.Count > 0)
					{
						num2 = (short)1007222784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					if (listBox.Items.Contains(obj))
					{
						num2 = (short)807993350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					for (;;)
					{
						num2 = (short)627284809;
						short num3 = num2;
						num2 = (short)130063177;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_14A;
						}
					}
					IL_14A:
					num2 = (short)1146617856;
					if (num2 != 0)
					{
					}
					num2 = (short)234291201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (listBox.SelectedItem == null)
					{
						num2 = (short)209190916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a();
					num2 = (short)2121859074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_114;
				}
				goto IL_2C;
			}
			IL_114:
			listBox.SelectedItem = obj;
			return;
			IL_2C:
			listBox = (global::System.Windows.Controls.ListBox)A_0;
			num2 = (short)1911881728;
			short num4 = num2;
			num2 = (short)638255109;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00019A1C File Offset: 0x00017C1C
		private void b(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1915551750;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1EA;
				case 1:
					if (A_1.NewValue is global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel)
					{
						num = (short)807731202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.lbUser.IsEnabled = true;
					num = (short)275775492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel settingsViewModel = (global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel)A_1.NewValue;
					this.lbUser.IsEnabled = settingsViewModel.SettingsContext.ServerConnectedWithUserName;
					num = (short)858611451;
					short num3 = num;
					num = (short)1759076091;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23D;
					case 1:
						break;
					default:
					{
						num = (short)1675821056;
						short num4 = num;
						break;
					}
					}
					num = (short)1872494592;
					if (num != 0)
					{
					}
					num = (short)464781319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_19E;
				case 4:
					goto IL_1A3;
				case 5:
					this.lbLicenses.IsEnabled = false;
					this.lbUser.IsEnabled = false;
					this.lbLanguage.IsEnabled = false;
					this.lbDealer.IsEnabled = false;
					this.lbButtonbarMode.IsEnabled = false;
					this.lbDatabaseSizeInfo.IsEnabled = false;
					num = (short)2104557571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					goto IL_1A3;
				}
				IL_44:
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					num = (short)892731397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.lbLicenses.IsEnabled = true;
				num = (short)1306591233;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A3:
				this.lbLanguage.IsEnabled = true;
				this.lbDealer.IsEnabled = true;
				this.lbButtonbarMode.IsEnabled = true;
				this.lbDatabaseSizeInfo.IsEnabled = true;
				num = (short)1742602240;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_19E:
			IL_1EA:
			IL_23D:
			num = (short)1723269121;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00019C94 File Offset: 0x00017E94
		private void a()
		{
			int a_ = 19;
			short num = (short)1187774499;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.ListBoxItem listBoxItem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					uint num3;
					if (num3 != 3931609814U)
					{
						num = (short)1128988683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1618083894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦ꫨ蓪菬臮铰郲致黶雸闺", a_)))
					{
						num = (short)415825957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B0;
				}
				case 2:
					num = (short)1011220486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					uint num3;
					if (num3 != 240411240U)
					{
						num = (short)223543317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1330380819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_AD1;
				case 5:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦귨諪駬軮鏰鋲蛴鋶꫸鋺蟼髾䠀洂挄栆", a_)))
					{
						num = (short)2017067044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F0;
				}
				case 6:
				{
					uint num3;
					if (num3 != 190297451U)
					{
						num = (short)135856177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1869807621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_AD1;
				case 8:
				{
					uint num3;
					if (num3 != 1294746715U)
					{
						num = (short)133300242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2111700993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)2119696413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.btnOK.IsLoaded)
					{
						num = (short)461176865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					num = (short)1559166980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					uint num3;
					if (num3 != 2317727307U)
					{
						num = (short)1174601760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)108134458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					num = (short)2012938240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦ꯨ黪駬鯮黰鷲韴零诸뛺鋼鯾搀", a_)))
					{
						num = (short)1375141914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6BA;
				}
				case 15:
					goto IL_AD1;
				case 16:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦胨꟪苬裮雰髲鯴郶", a_)))
					{
						goto IL_637;
					}
					listBoxItem.IsEnabled = true;
					this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
					this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Setting_Save;
					num = (short)1971257394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					goto IL_AD1;
				case 18:
					num = (short)946602044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦볨飪裬鷮", a_)))
					{
						num = (short)1411252266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B32;
				}
				case 20:
				{
					num = (short)1017184256;
					short num4 = num;
					num = (short)7471145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 21:
					num = (short)1035337780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_AD1;
				case 23:
					num = (short)2004942891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦ꇨ苪觬诮铰鷲룴鋶諸裺鳼飾搀", a_)))
					{
						num = (short)1251475479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_998;
				}
				case 25:
				{
					string name;
					if (name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦ꗨ諪菬裮蓰鋲鋴鋶", a_))
					{
						goto IL_914;
					}
					num = (short)611656438;
					short num5 = num;
					num = (short)1138565878;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_637;
					default:
						num = (short)2117074944;
						if (num != 0)
						{
						}
						num = (short)51380262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 26:
					num = (short)732823569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
				{
					uint num3;
					if (num3 != 3846887551U)
					{
						num = (short)382926861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2102329358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 28:
					return;
				case 29:
					goto IL_AD1;
				case 30:
					num = (short)831258675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					num = (short)2145386504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					num = (short)1940717625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
				{
					listBoxItem = (this.listBox.SelectedItem as global::System.Windows.Controls.ListBoxItem);
					string name = listBoxItem.Name;
					uint num3 = global::h.a(name);
					num = (short)506920994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 34:
				{
					uint num3;
					if (num3 <= 1294746715U)
					{
						num = (short)1334902840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)865271863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 35:
					switch (0)
					{
					case 0:
						goto IL_121;
					}
					continue;
				case 36:
					num = (short)1292238888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					num = (short)293208079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)967245831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					goto IL_B2D;
				case 40:
					goto IL_AD1;
				case 41:
					goto IL_AD1;
				case 42:
					num = (short)1560674326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					goto IL_AD1;
				case 44:
					num = (short)1480851468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
				{
					uint num3;
					if (num3 <= 240411240U)
					{
						num = (short)1501954050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1688797237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 46:
					num = (short)790233115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_AD1;
				case 48:
				{
					uint num3;
					if (num3 != 3617337103U)
					{
						num = (short)1552482350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1003880464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 49:
					num = (short)1320091651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_39E;
				case 51:
				{
					uint num3;
					if (num3 != 1929082914U)
					{
						num = (short)546963500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1426325528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 52:
					goto IL_AD1;
				case 53:
				{
					uint num3;
					if (num3 != 1292600093U)
					{
						num = (short)986251295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1249509401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 54:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦귨軪賬菮铰臲", a_)))
					{
						num = (short)273678395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45B;
				}
				case 55:
				{
					uint num3;
					if (num3 <= 2317727307U)
					{
						num = (short)805175326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1247477808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 56:
					num = (short)1069350957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					goto IL_AD1;
				case 58:
				{
					string name;
					if (!(name == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觤藦ꗨ苪軬諮鿰胲郴蓶", a_)))
					{
						num = (short)356057108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231;
				}
				case 59:
					num = (short)1470890031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					goto IL_AD1;
				}
				IL_121:
				if (this.btnOK == null)
				{
					num = (short)761659420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1317208074;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_637:
				num = (short)1128071177;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AD1:
				this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
				this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Setting_Connect;
				num = (short)218038273;
				if (num != 0)
				{
				}
				num = (short)30474279;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_231:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_39E:
			global::System.Windows.Controls.Primitives.ButtonBase buttonBase = this.btnOK;
			global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel settingsViewModel = base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel;
			buttonBase.Command = ((settingsViewModel != null) ? settingsViewModel.UpdateLoggingSetting : null);
			return;
			IL_45B:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Setting_Save;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).SaveDealerInfoCommand;
			return;
			IL_5B0:
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Setting_Connect;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).SaveSettingsCommand;
			return;
			IL_6BA:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Change_ButtonBarMode;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).ChangeRMAppButtonBarModeCommand;
			return;
			IL_8F0:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Collapsed;
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).GetDatabaseSizeSummary();
			return;
			IL_914:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Change_Language;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).ChangeRMAppLanguageCommand;
			return;
			IL_998:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Setting_Hide;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).SaveHiddenMessageCommand;
			return;
			IL_B2D:
			return;
			IL_B32:
			listBoxItem.IsEnabled = true;
			this.btnOK.Visibility = global::System.Windows.Visibility.Visible;
			this.btnOK.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Change_Password;
			this.btnOK.Command = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel).ChangeRMUserPasswordCommand;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001A854 File Offset: 0x00018A54
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1566638080;
			short num2 = num;
			num = (short)1134732665;
			short num3 = num;
			num = (short)1140434297;
			switch (num3 == num)
			{
			}
			num = (short)1220476929;
			if (num != 0)
			{
			}
			num = (short)1773404160;
			if (num != 0)
			{
			}
			global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
			window.Topmost = true;
			window.Activate();
			window.Topmost = false;
			this.a();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001A920 File Offset: 0x00018B20
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num = (short)357761024;
			short num2 = num;
			num = (short)442992394;
			short num3 = num;
			num = (short)632784650;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1418854400;
				if (num != 0)
				{
				}
				num = (short)577568769;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郜냞闠賢韤裦藨諪쏬곮黰黲飴飶韸룺근곾⼀儂搄挆怈搊䀌渎缐爒爔爖琘縚猜欞༠怢䨤䨦䐨䐪䌬ᐮ到尲場䜶嘸唺堼儾㕀求㙄≆㵈㽊⑌ⅎ㙐⁒⍔㹖㱘ⱚ牜ⱞѠᝢᅤ๦ݨ౪Ṭ᥮ᡰᙲɴ奶Ÿ᩺ၼ፾", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001AA00 File Offset: 0x00018C00
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1487667202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D6;
				case 1:
					num = (short)1353383936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_32B;
				case 2:
					goto IL_391;
				case 3:
					goto IL_384;
				case 4:
					goto IL_13F;
				case 5:
					goto IL_2FA;
				case 6:
					goto IL_1E8;
				case 7:
					goto IL_1DB;
				case 8:
					goto IL_125;
				case 9:
					goto IL_18A;
				case 10:
					goto IL_250;
				case 11:
					goto IL_1F5;
				case 12:
					goto IL_2E0;
				case 13:
					goto IL_243;
				case 14:
					goto IL_2ED;
				case 15:
					goto IL_229;
				case 16:
					goto IL_1B1;
				case 17:
					goto IL_21C;
				case 18:
					goto IL_3E9;
				case 19:
					goto IL_350;
				case 20:
					goto IL_36A;
				case 21:
					goto IL_343;
				case 22:
					goto IL_101;
				case 23:
					goto IL_166;
				case 24:
					goto IL_307;
				case 25:
					goto IL_236;
				case 26:
					goto IL_3F6;
				case 27:
					goto IL_14C;
				case 28:
					goto IL_F4;
				case 29:
					goto IL_410;
				case 30:
					goto IL_403;
				case 31:
					goto IL_20F;
				case 32:
					goto IL_2D3;
				case 33:
					goto IL_132;
				case 34:
					goto IL_35D;
				case 35:
					goto IL_197;
				case 36:
					goto IL_202;
				case 37:
					goto IL_159;
				case 38:
					goto IL_377;
				case 39:
					goto IL_3DC;
				case 40:
					goto IL_1A4;
				default:
					num = (short)1637548033;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F4:
			this.bdButtonBarMode = (global::System.Windows.Controls.Border)target;
			return;
			IL_101:
			this.OldPasswordBox = (global::System.Windows.Controls.PasswordBox)target;
			this.OldPasswordBox.PasswordChanged += this.e;
			return;
			IL_125:
			this.lbButtonbarMode = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_132:
			this.SetSize = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_13F:
			this.lbLicenses = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_14C:
			this.bdDealer = (global::System.Windows.Controls.Border)target;
			return;
			IL_159:
			this.bdLogging = (global::System.Windows.Controls.Border)target;
			return;
			IL_166:
			this.NewPasswordBox = (global::System.Windows.Controls.PasswordBox)target;
			this.NewPasswordBox.PasswordChanged += this.d;
			return;
			IL_18A:
			this.lbDatabaseSizeInfo = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_197:
			this.chkHiddenWarningMessageCapMaxRegister = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_1A4:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1B1:
			this.btnRecoverAPPLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1D6:
			this._contentLoaded = true;
			return;
			IL_1DB:
			this.lbDealer = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_1E8:
			this.lbLanguage = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_1F5:
			this.lbiLogging = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_202:
			this.chkHiddenWarningMessageTemplateRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_20F:
			this.TotalUsedSpace = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_21C:
			this.txtBlockRecoverRadioLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_229:
			this.bdLicenses = (global::System.Windows.Controls.Border)target;
			return;
			IL_236:
			this.bdLanguage = (global::System.Windows.Controls.Border)target;
			return;
			IL_243:
			this.rtbAddress = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_250:
			num = (short)1895890944;
			short num3 = num;
			num = (short)1699785721;
			short num4 = num;
			num = (short)788835321;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_410:
				this.rcbButtonBarMode = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
				return;
			default:
				num = (short)1854930944;
				if (num != 0)
				{
				}
				this.lbHiddenMessage = (global::System.Windows.Controls.ListBoxItem)target;
				return;
			}
			IL_2D3:
			this.setSizeGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2E0:
			this.bdConnection = (global::System.Windows.Controls.Border)target;
			return;
			IL_2ED:
			this.rtbPort = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_2FA:
			this.lbUser = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_307:
			this.ConfirmedPasswordBox = (global::System.Windows.Controls.PasswordBox)target;
			this.ConfirmedPasswordBox.PasswordChanged += this.c;
			return;
			IL_32B:
			((global::Motorola.CommonCPS.RadioManagement.Common.SettingsView)target).Loaded += this.b;
			return;
			IL_343:
			this.bdUser = (global::System.Windows.Controls.Border)target;
			return;
			IL_350:
			this.txtBlockRecoverCMSCLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_35D:
			this.bdHiddenMessage = (global::System.Windows.Controls.Border)target;
			return;
			IL_36A:
			this.btnRecoverCMSCLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_377:
			this.chkLogging = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_384:
			this.lbConnection = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_391:
			num = (short)1437401089;
			if (num != 0)
			{
			}
			this.listBox = (global::System.Windows.Controls.ListBox)target;
			this.listBox.SelectionChanged += this.a;
			return;
			IL_3DC:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_3E9:
			this.btnRecoverRadioLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_3F6:
			this.rcbLanguage = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_403:
			this.bdDatabaseSizeInfo = (global::System.Windows.Controls.Border)target;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001AE34 File Offset: 0x00019034
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)95551488;
			short num2 = num;
			num = (short)148734027;
			short num3 = num;
			num = (short)1869971531;
			switch (num3 == num)
			{
			}
			num = (short)740818945;
			if (num != 0)
			{
			}
			num = (short)1488977920;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001AEE4 File Offset: 0x000190E4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)438459795;
			short num2 = num;
			num = (short)24534419;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1210974208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)681967617;
			if (num != 0)
			{
			}
			num = (short)353697792;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x040000FF RID: 255
		internal global::System.Windows.Controls.ListBox listBox;

		// Token: 0x04000100 RID: 256
		internal global::System.Windows.Controls.ListBoxItem lbConnection;

		// Token: 0x04000101 RID: 257
		internal global::System.Windows.Controls.ListBoxItem lbLicenses;

		// Token: 0x04000102 RID: 258
		internal global::System.Windows.Controls.ListBoxItem lbUser;

		// Token: 0x04000103 RID: 259
		internal global::System.Windows.Controls.ListBoxItem lbLanguage;

		// Token: 0x04000104 RID: 260
		internal global::System.Windows.Controls.ListBoxItem lbDealer;

		// Token: 0x04000105 RID: 261
		internal global::System.Windows.Controls.ListBoxItem lbButtonbarMode;

		// Token: 0x04000106 RID: 262
		internal global::System.Windows.Controls.ListBoxItem lbDatabaseSizeInfo;

		// Token: 0x04000107 RID: 263
		internal global::System.Windows.Controls.ListBoxItem lbHiddenMessage;

		// Token: 0x04000108 RID: 264
		internal global::System.Windows.Controls.ListBoxItem lbiLogging;

		// Token: 0x04000109 RID: 265
		internal global::System.Windows.Controls.Border bdConnection;

		// Token: 0x0400010A RID: 266
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox rtbAddress;

		// Token: 0x0400010B RID: 267
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox rtbPort;

		// Token: 0x0400010C RID: 268
		internal global::System.Windows.Controls.Border bdLicenses;

		// Token: 0x0400010D RID: 269
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRecoverAPPLicense;

		// Token: 0x0400010E RID: 270
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtBlockRecoverRadioLicense;

		// Token: 0x0400010F RID: 271
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRecoverRadioLicense;

		// Token: 0x04000110 RID: 272
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtBlockRecoverCMSCLicense;

		// Token: 0x04000111 RID: 273
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRecoverCMSCLicense;

		// Token: 0x04000112 RID: 274
		internal global::System.Windows.Controls.Border bdUser;

		// Token: 0x04000113 RID: 275
		internal global::System.Windows.Controls.PasswordBox OldPasswordBox;

		// Token: 0x04000114 RID: 276
		internal global::System.Windows.Controls.PasswordBox NewPasswordBox;

		// Token: 0x04000115 RID: 277
		internal global::System.Windows.Controls.PasswordBox ConfirmedPasswordBox;

		// Token: 0x04000116 RID: 278
		internal global::System.Windows.Controls.Border bdLanguage;

		// Token: 0x04000117 RID: 279
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox rcbLanguage;

		// Token: 0x04000118 RID: 280
		internal global::System.Windows.Controls.Border bdDealer;

		// Token: 0x04000119 RID: 281
		internal global::System.Windows.Controls.Border bdButtonBarMode;

		// Token: 0x0400011A RID: 282
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox rcbButtonBarMode;

		// Token: 0x0400011B RID: 283
		internal global::System.Windows.Controls.Border bdDatabaseSizeInfo;

		// Token: 0x0400011C RID: 284
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TotalUsedSpace;

		// Token: 0x0400011D RID: 285
		internal global::System.Windows.Controls.Grid setSizeGrid;

		// Token: 0x0400011E RID: 286
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock SetSize;

		// Token: 0x0400011F RID: 287
		internal global::System.Windows.Controls.Border bdHiddenMessage;

		// Token: 0x04000120 RID: 288
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox chkHiddenWarningMessageCapMaxRegister;

		// Token: 0x04000121 RID: 289
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox chkHiddenWarningMessageTemplateRadios;

		// Token: 0x04000122 RID: 290
		internal global::System.Windows.Controls.Border bdLogging;

		// Token: 0x04000123 RID: 291
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox chkLogging;

		// Token: 0x04000124 RID: 292
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000125 RID: 293
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000126 RID: 294
		private bool _contentLoaded;

		// Token: 0x02000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class a
		{
			// Token: 0x04000127 RID: 295
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x04000128 RID: 296
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> b;

			// Token: 0x04000129 RID: 297
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> c;
		}

		// Token: 0x0200003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class b
		{
			// Token: 0x0400012A RID: 298
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x0400012B RID: 299
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> b;

			// Token: 0x0400012C RID: 300
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> c;
		}

		// Token: 0x0200003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class c
		{
			// Token: 0x0400012D RID: 301
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x0400012E RID: 302
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> b;

			// Token: 0x0400012F RID: 303
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> c;
		}
	}
}
