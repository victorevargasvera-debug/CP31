using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.CSharp.RuntimeBinder;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000006 RID: 6
	public class ChangePasswordView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002C60 File Offset: 0x00000E60
		public ChangePasswordView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.RaiseCleanPasswordEvt = (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.CleanPasswordEvt)global::System.Delegate.Combine(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.RaiseCleanPasswordEvt, new global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.CleanPasswordEvt(this.HandleCleanPassowordEvt));
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002C9C File Offset: 0x00000E9C
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel ViewModel
		{
			set
			{
				short num = (short)1277671493;
				short num2 = num;
				num = (short)494712901;
				switch (num2 == num)
				{
				}
				num = (short)1031929856;
				short num3 = num;
				num = (short)551419904;
				if (num != 0)
				{
				}
				num = (short)1431896065;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D4C File Offset: 0x00000F4C
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)2050555908;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1227489280;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1264713731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꃢ郤闦鯨軪菬鯮ꇰ鋲蛴蓶軸铺迼鯾", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)1152122886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)723245045;
					short num4 = num;
					num = (short)1048434677;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_232;
					default:
						num = (short)1427570688;
						if (num != 0)
						{
						}
						num = (short)1674641409;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.b == null)
						{
							num = (short)1690632194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19D;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 5:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돢蓤铦髨鳪苬鷮闰냲鷴零韸鳺飼볾渀洂焄戆焈缊", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(b, global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.a.a, base.DataContext), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					goto IL_232;
				}
				case 6:
					goto IL_19D;
				}
				IL_74:
				if (base.DataContext != null)
				{
					num = (short)1534263296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19D:
				num = (short)1446445061;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_232:
				num = (short)1037959169;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002FA4 File Offset: 0x000011A4
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)690814982;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.b == null)
					{
						goto IL_89;
					}
					goto IL_122;
				case 1:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돢蓤铦髨鳪苬鷮闰냲鷴零韸鳺飼볾渀洂焄戆焈缊", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(b, global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.a, base.DataContext), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)1226637315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.b.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("귢胤郦맨諪黬鳮蛰鳲蟴鏶", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)2122842117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1D1;
				case 4:
					num = (short)698548224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1874984960;
					short num3 = num;
					goto IL_122;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)2024341508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D1;
				IL_89:
				num = (short)1479409666;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D1:
				num = (short)1096207927;
				short num4 = num;
				num = (short)1606471223;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_89;
				default:
					goto IL_205;
				}
				IL_122:
				num = (short)1869217793;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_205:
			num = (short)1082327040;
			if (num != 0)
			{
			}
			num = (short)871628801;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000031F4 File Offset: 0x000013F4
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)2046951430;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.b == null)
					{
						goto IL_89;
					}
					goto IL_123;
				case 1:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("连胠郢雤郦蛨駪觬곮駰鋲鯴郶鳸룺鋼釾甀昂約猆", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(b, global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.a, base.DataContext), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)1001717763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView.c.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("跞蓠蛢诤鏦賨駪ꏬ諮蛰ꏲ铴蓶諸賺鋼跾攀", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)1671299077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1D2;
				case 4:
					num = (short)873857024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)310706176;
					short num3 = num;
					goto IL_123;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)336330756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D2;
				IL_89:
				num = (short)803340290;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D2:
				num = (short)1734010944;
				short num4 = num;
				num = (short)850913344;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_89;
				default:
					goto IL_208;
				}
				IL_123:
				num = (short)1206779905;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_208:
			num = (short)1948450817;
			if (num != 0)
			{
			}
			num = (short)1946943488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003448 File Offset: 0x00001648
		public void HandleCleanPassowordEvt(global::System.EventArgs e)
		{
			short num = (short)1767768072;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)432406529;
					if (num != 0)
					{
					}
					goto IL_6C;
				case 1:
				{
					num = (short)1896480768;
					short num3 = num;
					if (this.ReEnterNewPasswordField != null)
					{
						num = (short)1092485123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					if (this.NewPasswordField != null)
					{
						goto IL_1D4;
					}
					goto IL_6C;
				case 3:
					this.ReEnterNewPasswordField.Clear();
					num = (short)1647968260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					this.NewPasswordField.Clear();
					num = (short)1073872896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.CurrentPasswordField.Clear();
					num = (short)830341127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_168;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				}
				IL_48:
				if (this.CurrentPasswordField != null)
				{
					num = (short)1491009542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_168;
				IL_6C:
				num = (short)1267073025;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_168:
				num = (short)1116982260;
				short num4 = num;
				num = (short)894553076;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D4:
					num = (short)1424621573;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1686700032;
					if (num != 0)
					{
					}
					num = (short)981729282;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003648 File Offset: 0x00001848
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)1030678654;
				short num2 = num;
				num = (short)312797310;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)869138433;
					if (num != 0)
					{
					}
					num = (short)498860032;
					if (num != 0)
					{
					}
					num = (short)2125332480;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏝迟雡诣铥蟧蛩跫샭돯鷱駳鯵韷铹뿻껽叿Ⰱ嘃朅氇按挋䌍焏簑甓焕紗眙礛瀝吟డ朣䤥䔧䜩䌫䀭ଯ儱嬳嬵䠷唹刻嬽⸿㙁歃╅⁇⭉≋⥍㕏≑㕓╕⭗ⵙ㍛ⱝџᑡൣͥὧ䕩ཫ٭ᅯᱱ፳፵ࡷ᭹ཻൽﺇ轢뺏ﮕ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000372C File Offset: 0x0000192C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)814350338;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_122;
				case 1:
					num = (short)975175680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_134;
				case 2:
				{
					num = (short)69037333;
					short num3 = num;
					num = (short)510618901;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A9;
					}
					break;
				}
				case 3:
					goto IL_158;
				case 4:
					goto IL_67;
				case 5:
					goto IL_127;
				}
				num = (short)1138491393;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_67:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_A9:
			num = (short)498597888;
			if (num != 0)
			{
			}
			num = (short)2050883585;
			if (num != 0)
			{
			}
			this.NewPasswordField = (global::System.Windows.Controls.PasswordBox)target;
			this.NewPasswordField.PasswordChanged += this.b;
			return;
			IL_122:
			num = (short)1727594496;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_127:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_134:
			this.CurrentPasswordField = (global::System.Windows.Controls.PasswordBox)target;
			this.CurrentPasswordField.PasswordChanged += this.c;
			return;
			IL_158:
			this.ReEnterNewPasswordField = (global::System.Windows.Controls.PasswordBox)target;
			this.ReEnterNewPasswordField.PasswordChanged += this.a;
		}

		// Token: 0x0400001E RID: 30
		internal global::System.Windows.Controls.PasswordBox CurrentPasswordField;

		// Token: 0x0400001F RID: 31
		internal global::System.Windows.Controls.PasswordBox NewPasswordField;

		// Token: 0x04000020 RID: 32
		internal global::System.Windows.Controls.PasswordBox ReEnterNewPasswordField;

		// Token: 0x04000021 RID: 33
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000022 RID: 34
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000023 RID: 35
		private bool _contentLoaded;

		// Token: 0x02000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class a
		{
			// Token: 0x04000024 RID: 36
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x04000025 RID: 37
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> b;
		}

		// Token: 0x02000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class b
		{
			// Token: 0x04000026 RID: 38
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x04000027 RID: 39
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> b;
		}

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class c
		{
			// Token: 0x04000028 RID: 40
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x04000029 RID: 41
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> b;
		}
	}
}
