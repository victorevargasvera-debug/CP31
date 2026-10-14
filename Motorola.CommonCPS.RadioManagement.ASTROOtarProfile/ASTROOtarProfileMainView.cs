using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x0200001B RID: 27
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MainRegion")]
	public class ASTROOtarProfileMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00009B3C File Offset: 0x00007D3C
		public ASTROOtarProfileMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700001E RID: 30
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00009B58 File Offset: 0x00007D58
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.MainViewModel ViewModel
		{
			set
			{
				short num = (short)907134367;
				short num2 = num;
				num = (short)1150535071;
				switch (num2 == num)
				{
				}
				num = (short)514588672;
				short num3 = num;
				num = (short)2083061760;
				if (num != 0)
				{
				}
				num = (short)434700289;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009C0C File Offset: 0x00007E0C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this._contentLoaded)
			{
				short num = (short)2131401994;
				short num2 = num;
				num = (short)1806015754;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)119668736;
					if (num != 0)
					{
					}
					num = (short)2124808193;
					if (num != 0)
					{
					}
					num = (short)617021440;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("煝ⵟൡၣ॥ᩧթk཭幯ㅱ᭳᭵ᕷᕹቻ㵽큿톁ꪃ풅\udd8f望ﾗﾙﮝ캟횡誣ﮧﺩﺫﾯ욱햳쒵좹펻\ud8bdꦿ껁ꇃﷅꯇꗉꇋ뻍뿏병뇓룕곗뇛뿝觟賡鋣迥跧鷩싫雭釯鿱飳", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)817758210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9E;
				case 1:
					goto IL_B6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)2071134209;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_91;
				case 2:
					goto IL_84;
				case 3:
				{
					num = (short)2063548349;
					short num3 = num;
					num = (short)319569853;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_EE;
					}
					break;
				}
				default:
					num = (short)933429248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9E:
				num = (short)2031747073;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_84:
			this.rbtRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_91:
			this.rbtAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_B6:
			num = (short)552140800;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_EE:
			num = (short)253231104;
			if (num != 0)
			{
			}
			this.rbtOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
		}

		// Token: 0x0400003F RID: 63
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAll;

		// Token: 0x04000040 RID: 64
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtRadios;

		// Token: 0x04000041 RID: 65
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtOtarProfiles;

		// Token: 0x04000042 RID: 66
		private bool _contentLoaded;
	}
}
