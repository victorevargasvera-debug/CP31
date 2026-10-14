using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x0200000B RID: 11
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROOtarProfileMainRegion")]
	public class OtarProfilesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000047DC File Offset: 0x000029DC
		public OtarProfilesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000047F8 File Offset: 0x000029F8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfilesViewModel ViewModel
		{
			set
			{
				short num = (short)2110966737;
				short num2 = num;
				num = (short)1514130385;
				switch (num2 == num)
				{
				}
				num = (short)2089811968;
				short num3 = num;
				num = (short)888406017;
				if (num != 0)
				{
				}
				num = (short)1907687424;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000048AC File Offset: 0x00002AAC
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				num = (short)942699622;
				short num2 = num;
				num = (short)289829990;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)452919296;
					if (num != 0)
					{
					}
					num = (short)1103101953;
					if (num != 0)
					{
					}
					this.dgrOtarProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("っͥէᩩk཭ѯ᝱㩳᝵ᕷό", a_));
					return;
				}
			}
			num = (short)1116471296;
			short num3 = num;
			this.dgrOtarProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("❣॥٧౩ի७կqᕳɵᅷᕹቻぽ", a_));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000049A0 File Offset: 0x00002BA0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num;
			if (this._contentLoaded)
			{
				num = (short)881739401;
				short num2 = num;
				num = (short)792086153;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2024669184;
					if (num != 0)
					{
					}
					num = (short)921632768;
					short num3 = num;
					return;
				}
				}
			}
			num = (short)307363841;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("睗᝙㍛⩝ཟၡୣ੥१䑩⽫ŭᵯά᭳ᡵ㭷⩹⽻偽퉿잉ﮕﶗ낝\ud8ab쾭슯욳\ud9b5\udeb7펹킻\udbbd﮿ꇁꯃꯅ룇ꗉꋋꯍ뻏ꛑﯓ맕곗믙껛껝鋟跡苣迥蓧迩鿫飭駯韱菳\ud9f5韷軹鷻賽烿瀁欃怅愇昉椋納昏笑焓愕㘗戙紛猝䰟", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004A80 File Offset: 0x00002C80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)932288645;
			short num2 = num;
			num = (short)686856325;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1850146816;
				short num3 = num;
				goto IL_5E;
			}
			}
			int num4;
			for (;;)
			{
				IL_94:
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 1:
					if (connectionId != 2)
					{
						num = (short)765263876;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
				case 2:
					goto IL_F7;
				case 3:
					num = (short)2143354881;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1925709826;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AE:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)2000158723;
				num4 = (int)((global::System.IntPtr)num);
			}
			((global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfilesView)target).Loaded += this.a;
			return;
			IL_F7:
			num = (short)319094785;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_155:
			this.dgrOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_5E:
			num = (short)904200192;
			if (num != 0)
			{
			}
			num = (short)1201340416;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_94;
		}

		// Token: 0x04000013 RID: 19
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrOtarProfiles;

		// Token: 0x04000014 RID: 20
		private bool _contentLoaded;
	}
}
