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
	// Token: 0x0200002D RID: 45
	public class UserLoginView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00016158 File Offset: 0x00014358
		public UserLoginView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.RaiseCleanUserLoginFormEvt = (global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.CleanUserLoginFormEvt)global::System.Delegate.Combine(global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.RaiseCleanUserLoginFormEvt, new global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.CleanUserLoginFormEvt(this.HandleCleanUserLoginFormEvt));
		}

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00016194 File Offset: 0x00014394
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel ViewModel
		{
			set
			{
				short num = (short)88866816;
				short num2 = num;
				num = (short)1590244995;
				short num3 = num;
				num = (short)615069315;
				switch (num3 == num)
				{
				}
				num = (short)37945345;
				if (num != 0)
				{
				}
				num = (short)1890320384;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00016248 File Offset: 0x00014448
		public void CloseLoginWindow(object sender, global::System.EventArgs e)
		{
			short num = (short)806354944;
			short num2 = num;
			num = (short)1047068485;
			short num3 = num;
			num = (short)303824709;
			switch (num3 == num)
			{
			}
			num = (short)994377728;
			if (num != 0)
			{
			}
			num = (short)1499004929;
			if (num != 0)
			{
			}
			global::System.Windows.Window.GetWindow(this).Close();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000162FC File Offset: 0x000144FC
		public void HandleCleanUserLoginFormEvt(global::System.EventArgs e)
		{
			short num = (short)565051392;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1051250056;
				short num3 = num;
				num = (short)544918920;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EA;
				default:
					num = (short)1752956928;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 1:
						this.UserPassword.Clear();
						num = (short)69206018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_EA;
					}
					IL_7C:
					if (this.UserPassword == null)
					{
						return;
					}
					num = (short)1378418689;
					if (num != 0)
					{
					}
					num = (short)925630465;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EA:
			num = (short)854589440;
			short num4 = num;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00016420 File Offset: 0x00014620
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)1315176450;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1112342528;
					short num3 = num;
					num = (short)470186434;
					short num4 = num;
					num = (short)1327987138;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						num = (short)433651712;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.b == null)
						{
							num = (short)1182990339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					}
					break;
				}
				case 1:
					goto IL_69;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.SetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("賛뿝鏟釡鏣觥髧軩", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
					num = (short)1711341573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					num = (short)1961820161;
					if (num != 0)
					{
					}
					goto IL_198;
				case 6:
				{
					global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object> target = global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.b.Target;
					global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.b;
					if (global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.a == null)
					{
						global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.GetMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觛귝藟郡꣣觥迧菩苫귭鿯鳱胳鏵胷軹", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(b, global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.a.Target(global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView.a.a, base.DataContext), ((global::System.Windows.Controls.PasswordBox)A_0).SecurePassword);
					num = (short)657063940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_49:
				if (base.DataContext != null)
				{
					num = (short)611713025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_69:
				num = (short)451280896;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_198:
				num = (short)961478662;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00016674 File Offset: 0x00014874
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2104688640;
			short num2 = num;
			num = (short)129372231;
			short num3 = num;
			num = (short)1727467591;
			switch (num3 == num)
			{
			}
			num = (short)226099201;
			if (num != 0)
			{
			}
			num = (short)108199936;
			if (num != 0)
			{
			}
			global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
			window.Topmost = true;
			window.Activate();
			window.Topmost = false;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00016734 File Offset: 0x00014934
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 19;
			short num = (short)147783680;
			short num2 = num;
			num = (short)1103760460;
			short num3 = num;
			num = (short)1474038860;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1316421632;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쫤ꫦ蛨鿪苬鷮黰鿲铴\ud9f6뫸铺郼鋾渀洂䘄圆娈┊弌渎甐稒稔娖砘甚簜砞䐠丢䀤䤦崨Ԫ測䀮尰帲娴夶ȸ堺刼刾ㅀⱂ⭄≆❈㽊扌㩎≐㙒❔㭖㙘㱚㑜ㅞᝠ੢dၦ䙨ṪṬ੮Ͱὲᩴၶၸᕺ୼ᙾꮄﾆ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			num = (short)208338945;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00016814 File Offset: 0x00014A14
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)19267584;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
				{
					num = (short)1514973242;
					short num3 = num;
					num = (short)1451796538;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_108;
					default:
					{
						num = (short)47906816;
						if (num != 0)
						{
						}
						num = (short)668336128;
						short num4 = num;
						num = (short)884473857;
						if (num != 0)
						{
						}
						num = (short)39321602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_176;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_139;
				case 2:
					goto IL_192;
				case 3:
					goto IL_185;
				case 4:
					goto IL_12C;
				case 5:
					goto IL_108;
				case 6:
					goto IL_178;
				case 7:
					goto IL_151;
				default:
					num = (short)80478209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_108:
			this.UserPassword = (global::System.Windows.Controls.PasswordBox)target;
			this.UserPassword.PasswordChanged += this.b;
			return;
			IL_12C:
			this.UserNameField = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_139:
			((global::Motorola.CommonCPS.RadioManagement.Common.UserLoginView)target).Loaded += this.a;
			return;
			IL_151:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_176:
			this._contentLoaded = true;
			return;
			IL_178:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_185:
			this.ConnectionPort = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_192:
			this.ConnectionAddress = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
		}

		// Token: 0x040000E5 RID: 229
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock ConnectionAddress;

		// Token: 0x040000E6 RID: 230
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock ConnectionPort;

		// Token: 0x040000E7 RID: 231
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox UserNameField;

		// Token: 0x040000E8 RID: 232
		internal global::System.Windows.Controls.PasswordBox UserPassword;

		// Token: 0x040000E9 RID: 233
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000EA RID: 234
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000EB RID: 235
		private bool _contentLoaded;

		// Token: 0x0200002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class a
		{
			// Token: 0x040000EC RID: 236
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> a;

			// Token: 0x040000ED RID: 237
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, global::System.Security.SecureString, object>> b;
		}
	}
}
