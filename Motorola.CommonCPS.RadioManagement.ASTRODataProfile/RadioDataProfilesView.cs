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

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000010 RID: 16
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTRODataProfileMainRegion")]
	public class RadioDataProfilesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000508C File Offset: 0x0000328C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioDataProfilesView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 3;
			base..ctor();
			this.InitializeComponent();
			this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForDataProfileRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>>(this.a));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("잡좣쪥쎩삫슭\udcb1킳펵\udcb7惡펻펽궿ꏁ꫃ꋅ", a_));
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000050E8 File Offset: 0x000032E8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesViewModel ViewModel
		{
			set
			{
				short num = (short)1234425241;
				short num2 = num;
				num = (short)1229182361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860698112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)315752449;
				if (num != 0)
				{
				}
				num = (short)1472987136;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005198 File Offset: 0x00003398
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)715930183;
			short num2 = num;
			num = (short)1537882695;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D4:
				num = (short)753664002;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1324941312;
				if (num != 0)
				{
				}
				num = (short)868286465;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)208928768;
					short num4 = num;
					num = (short)186449921;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CC;
					}
					continue;
				}
				case 2:
				{
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.b.a(this.dgrRadioDataProfiles);
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
					cellRangeFillManager.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
					num = (short)719126528;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			IL_CC:
			if (this.fillManager == null)
			{
				goto IL_D4;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000052E4 File Offset: 0x000034E4
		private void a()
		{
			int a_ = 8;
			short num = (short)1205796864;
			short num2 = num;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				num = (short)1297347900;
				short num3 = num;
				num = (short)2059269436;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)757792769;
					if (num != 0)
					{
					}
					num = (short)1124270080;
					if (num != 0)
					{
					}
					this.dgrRadioDataProfiles.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("슦쒨\udbaa솬캮얰횲﮴횶풸\udeba", a_));
					return;
				}
			}
			this.dgrRadioDataProfiles.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("좦잨춪쒬좮쒰솲풴쎶킸풺펼ꃀ껂ꃄ", a_));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000053D4 File Offset: 0x000035D4
		private void a(global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> A_0)
		{
			short num = (short)1633484800;
			short num2 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = this.dgrRadioDataProfiles;
			if (rmdataGrid == null)
			{
				num = (short)628381431;
				short num3 = num;
				num = (short)1079203575;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)407568384;
					if (num != 0)
					{
					}
					num = (short)1449787393;
					if (num != 0)
					{
					}
					return;
				}
			}
			A_0.Result = rmdataGrid.GetGridInfo();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00005498 File Offset: 0x00003698
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00005554 File Offset: 0x00003754
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)278855681;
				if (num != 0)
				{
				}
				num = (short)1988034560;
				short num2 = num;
				num = (short)1639261141;
				short num3 = num;
				num = (short)179643349;
				switch (num3 == num)
				{
				}
				num = (short)286916608;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)1089975724;
				short num2 = num;
				num = (short)389264812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685913600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				num = (short)739966977;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000560C File Offset: 0x0000380C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num = (short)264568832;
			short num2 = num;
			if (this._contentLoaded)
			{
				num = (short)1224987242;
				short num3 = num;
				num = (short)15389290;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)935591936;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1666449409;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("讣잧\udea9쎫\udcad\udfaf\udeb1햳颵﮷햹톻펽꾿곁蟃雅鯇黋꿍듏믑믓鯕맗듙뷛망藟迡臣裥鳧쓩귫뷭ꓯꃱ믳답駷軹鷻껽狿洁戃漅搇漉㜋洍缏缑搓礕瘗缙爛樝༟倡䔣䈥䄧䔩䠫伭䐯匱䐳䐵圷尹唻刽┿ㅁ㉃⽅ⵇ㵉捋㱍ㅏ㙑㵓㥕㱗㭙⡛㽝ၟၡୣeŧ٩५ᵭٯ᭱ᅳŵ噷ɹᵻ፽", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000056E8 File Offset: 0x000038E8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)488929574;
			short num2 = num;
			num = (short)1775204646;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_141:
				num = (short)73531393;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1655832576;
				if (num != 0)
				{
				}
				num = (short)220725251;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)2070151168;
					short num4 = num;
					num = (short)2060320770;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1812791300;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_13D;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				case 4:
					goto IL_D4;
				}
				IL_82:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)716636160;
				num3 = (int)((global::System.IntPtr)num);
			}
			this.uscRadioDataProfiles = (global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView)target;
			this.uscRadioDataProfiles.Loaded += this.a;
			return;
			IL_D4:
			num = (short)568393729;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_13D:
			if (connectionId != 2)
			{
				goto IL_141;
			}
			this.dgrRadioDataProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005868 File Offset: 0x00003A68
		// Note: this type is marked as 'beforefieldinit'.
		static RadioDataProfilesView()
		{
			int a_ = 9;
			short num = (short)508804855;
			short num2 = num;
			num = (short)226803447;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2052194304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)647233537;
			if (num != 0)
			{
			}
			num = (short)1898971136;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("춧용삫\ud9af\udeb1\ud8b3횷\udeb9\ud9bb\udabd莿귁꧃ꯅ꧇꓉꣋", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005950 File Offset: 0x00003B50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)1863325860;
			short num2 = num;
			num = (short)1857296548;
			switch (num2 == num)
			{
			default:
			{
				num = (short)301531136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)238354433;
			if (num != 0)
			{
			}
			num = (short)1638137856;
			if (num != 0)
			{
			}
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x04000018 RID: 24
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x0400001A RID: 26
		internal global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesView uscRadioDataProfiles;

		// Token: 0x0400001B RID: 27
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadioDataProfiles;

		// Token: 0x0400001C RID: 28
		private bool _contentLoaded;
	}
}
