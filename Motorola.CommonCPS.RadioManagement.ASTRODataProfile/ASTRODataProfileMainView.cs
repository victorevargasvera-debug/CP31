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

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200001B RID: 27
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MainRegion")]
	public class ASTRODataProfileMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000881C File Offset: 0x00006A1C
		public ASTRODataProfileMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00008838 File Offset: 0x00006A38
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.MainViewModel ViewModel
		{
			set
			{
				short num = (short)1762567964;
				short num2 = num;
				num = (short)1823319836;
				switch (num2 == num)
				{
				}
				num = (short)1092878337;
				if (num != 0)
				{
				}
				num = (short)1272840192;
				if (num != 0)
				{
				}
				num = (short)667942912;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000088EC File Offset: 0x00006AEC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			if (this._contentLoaded)
			{
				short num = (short)1766284222;
				short num2 = num;
				num = (short)1351244734;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1783234560;
					if (num != 0)
					{
					}
					num = (short)1393557504;
					short num3 = num;
					num = (short)1684668417;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("낞첢톤좦\udba8쒪솬캮龰\udab4\udab6풸풺펼ﲾ釀郂闆꣈꿊꓌ꃎ鳐닒믔뛖뻘뻚냜뫞迠韢쯤ꛦ뫨뿪뿬ꃮ뗰鋲致零꧸觺鋼駾栀漂怄㰆樈搊怌缎縐紒瀔礖洘㐚瀜縞䠠䴢匤並䰨尪̬圮倰帲头", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000089D0 File Offset: 0x00006BD0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)866451457;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1795424256;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_F3;
				case 1:
				{
					num = (short)1595603887;
					short num4 = num;
					num = (short)1670708143;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)751697921;
						if (num != 0)
						{
						}
						num = (short)792985600;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CB;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_127;
				}
				IL_CB:
				switch (connectionId)
				{
				case 1:
					goto IL_102;
				case 2:
					goto IL_F5;
				case 3:
					goto IL_129;
				default:
					num = (short)1282867200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F3:
				num = (short)1931804674;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F5:
			this.rbtRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_102:
			this.rbtAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_127:
			this._contentLoaded = true;
			return;
			IL_129:
			this.rbtDataProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
		}

		// Token: 0x04000035 RID: 53
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAll;

		// Token: 0x04000036 RID: 54
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtRadios;

		// Token: 0x04000037 RID: 55
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtDataProfiles;

		// Token: 0x04000038 RID: 56
		private bool _contentLoaded;
	}
}
