using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000010 RID: 16
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROOtarProfileMainRegion")]
	public class RadioOtarProfilesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00005410 File Offset: 0x00003610
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioOtarProfilesView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 2;
			base..ctor();
			this.InitializeComponent();
			this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForOtarProfileRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>>(this.a));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillStartedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၒご㭖㕘ᵚ㑜㍞ൠぢᅤ٦᭨Ὢ࡬୮㉰ᱲᡴ᩶ᡸᕺ᥼", a_));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၒご㭖㕘ᵚ㑜㍞ൠ♢୤ͦ౨ཪ⹬nᱰṲᑴ᥶ᵸ", a_));
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00005484 File Offset: 0x00003684
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesViewModel ViewModel
		{
			set
			{
				short num = (short)1343750144;
				short num2 = num;
				num = (short)1075064513;
				short num3 = num;
				num = (short)2098605761;
				switch (num3 == num)
				{
				}
				num = (short)2027749376;
				if (num != 0)
				{
				}
				num = (short)1396572161;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005534 File Offset: 0x00003734
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)342818816;
			short num2 = num;
			num = (short)13074314;
			short num3 = num;
			num = (short)1864793994;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1287454720;
				if (num != 0)
				{
				}
				num = (short)1842085889;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
				{
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.b.a(this.dgrRadioOtarProfiles);
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
					cellRangeFillManager.CellFillStarted = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillStarted, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler(this.a));
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager2 = this.fillManager;
					cellRangeFillManager2.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager2.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
					num = (short)247398402;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 2:
					return;
				}
				IL_A5:
				if (this.fillManager != null)
				{
					break;
				}
				num = (short)860684289;
				if (num != 0)
				{
				}
				num = (short)467271680;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000056AC File Offset: 0x000038AC
		private void a()
		{
			int a_ = 10;
			short num = (short)880241304;
			short num2 = num;
			num = (short)1388735128;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)36831232;
				if (num != 0)
				{
				}
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					this.dgrRadioOtarProfiles.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᡚ㉜ㅞݠ੢ɤቦ᭨੪ᥬٮṰᵲ㭴ᙶᑸṺ", a_));
					return;
				}
				num = (short)2050883585;
				if (num != 0)
				{
				}
				num = (short)1923940352;
				short num3 = num;
				break;
			}
			}
			this.dgrRadioOtarProfiles.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ཚ㡜㉞ᅠརѤ፦౨╪౬ɮᑰ", a_));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005798 File Offset: 0x00003998
		private void a(global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> A_0)
		{
			short num = (short)1856056373;
			short num2 = num;
			num = (short)1915235381;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)24838145;
				if (num != 0)
				{
				}
				num = (short)30605312;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = this.dgrRadioOtarProfiles;
				if (rmdataGrid != null)
				{
					A_0.Result = rmdataGrid.GetGridInfo();
					return;
				}
				num = (short)432865280;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000585C File Offset: 0x00003A5C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005914 File Offset: 0x00003B14
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			get
			{
				short num = (short)2002780160;
				short num2 = num;
				num = (short)2074439279;
				short num3 = num;
				num = (short)2053074543;
				switch (num3 == num)
				{
				}
				num = (short)177012737;
				if (num != 0)
				{
				}
				num = (short)1731592192;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillStartedCommandProperty);
			}
			set
			{
				short num = (short)868352000;
				short num2 = num;
				num = (short)424671714;
				short num3 = num;
				num = (short)1342175714;
				switch (num3 == num)
				{
				}
				num = (short)382337025;
				if (num != 0)
				{
				}
				num = (short)2015297536;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillStartedCommandProperty, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000059CC File Offset: 0x00003BCC
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005A84 File Offset: 0x00003C84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)1384513536;
				short num2 = num;
				num = (short)737106810;
				short num3 = num;
				num = (short)897080186;
				switch (num3 == num)
				{
				}
				num = (short)1695285248;
				if (num != 0)
				{
				}
				num = (short)212074497;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)929890304;
				short num2 = num;
				num = (short)677488719;
				short num3 = num;
				num = (short)2084743247;
				switch (num3 == num)
				{
				}
				num = (short)1901985793;
				if (num != 0)
				{
				}
				num = (short)1000669184;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005B38 File Offset: 0x00003D38
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1910177793;
			if (num != 0)
			{
			}
			num = (short)1297404322;
			short num2 = num;
			num = (short)1601622434;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1836974080;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("䱢⡤ࡦᵨѪὬnᵰቲ孴㑶ᙸᙺၼၾ삂햄풆ꞈ\ud98aﲒ\ud894漢煮爵철욢쮤펦螨ﺬﮮﲲ華쎶\ud8b8즺춾껀ꗂ계ꯆ곈껌ꃎ볐ꏒ뫔맖볘뗚꧜鏠苢臤軦蛨蓪駬軮菰菲蟴飶鿸鋺釼髾爀甂氄戆縈␊缌渎甐稒稔砖洘稚漜漞匠䰢䌤並䔨个帬央堰嘲䈴ᤶ䄸娺值匾", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)1251999744;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005C18 File Offset: 0x00003E18
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1560744364;
			short num2 = num;
			num = (short)1180176812;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)76152832;
				short num3 = num;
				goto IL_5D;
			}
			}
			int num4;
			for (;;)
			{
				IL_BA:
				switch (num4)
				{
				case 0:
					num = (short)1296367617;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_D4;
					}
					continue;
				case 1:
					if (connectionId != 2)
					{
						num = (short)1056374788;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15E;
				case 2:
					goto IL_128;
				case 3:
					num = (short)1016201217;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1682833410;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D4:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1499201539;
				num4 = (int)((global::System.IntPtr)num);
			}
			this.uscRadioOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView)target;
			this.uscRadioOtarProfiles.Loaded += this.a;
			return;
			IL_128:
			this._contentLoaded = true;
			return;
			IL_15E:
			this.dgrRadioOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_5D:
			num = (short)538443776;
			if (num != 0)
			{
			}
			num = (short)532611072;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_BA;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005D98 File Offset: 0x00003F98
		// Note: this type is marked as 'beforefieldinit'.
		static RadioOtarProfilesView()
		{
			int a_ = 18;
			short num = (short)1487929344;
			short num2 = num;
			num = (short)77932301;
			short num3 = num;
			num = (short)1321019149;
			switch (num3 == num)
			{
			}
			num = (short)379453441;
			if (num != 0)
			{
			}
			num = (short)694353920;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillStartedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⁢d୦ը⵪Ѭͮᵰ⁲Ŵᙶ୸ེ᡼᭾슀", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⁢d୦ը⵪Ѭͮᵰ㙲᭴፶ᱸὺ㹼ၾ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005EAC File Offset: 0x000040AC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventArgs A_0)
		{
			short num = (short)1857355776;
			short num2 = num;
			num = (short)1803800446;
			short num3 = num;
			num = (short)2058211198;
			switch (num3 == num)
			{
			}
			num = (short)837550080;
			if (num != 0)
			{
			}
			num = (short)1142358017;
			if (num != 0)
			{
			}
			this.CellFillStartedCommand.Execute();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005F68 File Offset: 0x00004168
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)652804096;
			short num2 = num;
			num = (short)1859834435;
			short num3 = num;
			num = (short)1439879747;
			switch (num3 == num)
			{
			}
			num = (short)1586823169;
			if (num != 0)
			{
			}
			num = (short)468123648;
			if (num != 0)
			{
			}
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x0400001C RID: 28
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty CellFillStartedCommandProperty;

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x0400001F RID: 31
		internal global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesView uscRadioOtarProfiles;

		// Token: 0x04000020 RID: 32
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadioOtarProfiles;

		// Token: 0x04000021 RID: 33
		private bool _contentLoaded;
	}
}
