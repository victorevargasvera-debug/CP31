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
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000013 RID: 19
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROOtarProfileMainRegion")]
	public class RadioDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000073E0 File Offset: 0x000055E0
		public RadioDetailsView()
		{
			int a_ = 8;
			base..ctor();
			this.InitializeComponent();
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillStartedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᩘ㹚ㅜ㍞❠੢।୦㩨Ὢ౬ᵮհᙲᅴ㑶ᙸᙺၼṾ", a_));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᩘ㹚ㅜ㍞❠੢।୦ⱨժ६੮ᕰひᩴ᩶ᑸ᩺፼᭾", a_));
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00007438 File Offset: 0x00005638
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)363084110;
				short num2 = num;
				num = (short)269957454;
				switch (num2 == num)
				{
				}
				num = (short)33947649;
				if (num != 0)
				{
				}
				num = (short)760938496;
				if (num != 0)
				{
				}
				num = (short)437649408;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000074E8 File Offset: 0x000056E8
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)1307049989;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_134;
				case 1:
					if (this.fillManager == null)
					{
						num = (short)1714749440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1956072980;
					short num3 = num;
					num = (short)2089307668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						goto IL_209;
					}
					break;
				}
				case 3:
					goto IL_91;
				case 4:
					goto IL_91;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					this.dgrOtarProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("୞Ѡ๢ᕤ୦ࡨὪ࡬ⅮၰṲၴ", a_));
					num = (short)1532690435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)425132032;
					short num4 = num;
					num = (short)335478790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.dgrOtarProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᱞ๠ൢͤ๦๨ṪὬ๮հᩲᩴ᥶㝸᩺ၼ᩾", a_));
				num = (short)1476526084;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_91:
				num = (short)1980628993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_134:
				num = (short)1777729537;
				if (num != 0)
				{
				}
				this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.b.a(this.dgrOtarProfiles);
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
				cellRangeFillManager.CellFillStarted = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillStarted, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler(this.a));
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager2 = this.fillManager;
				cellRangeFillManager2.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager2.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
				num = (short)1482686466;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_209:
			num = (short)575537152;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007718 File Offset: 0x00005918
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000077D0 File Offset: 0x000059D0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			get
			{
				short num = (short)831998412;
				short num2 = num;
				num = (short)1738754508;
				switch (num2 == num)
				{
				}
				num = (short)1409351680;
				if (num != 0)
				{
				}
				num = (short)2075656193;
				if (num != 0)
				{
				}
				num = (short)385875968;
				short num3 = num;
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillStartedCommandProperty);
			}
			set
			{
				short num = (short)1987162405;
				short num2 = num;
				num = (short)1569698085;
				switch (num2 == num)
				{
				}
				num = (short)998572033;
				if (num != 0)
				{
				}
				num = (short)934084608;
				if (num != 0)
				{
				}
				num = (short)1570897920;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillStartedCommandProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00007888 File Offset: 0x00005A88
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00007940 File Offset: 0x00005B40
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)1188757505;
				if (num != 0)
				{
				}
				num = (short)1484328719;
				short num2 = num;
				num = (short)890638095;
				switch (num2 == num)
				{
				}
				num = (short)1074266112;
				if (num != 0)
				{
				}
				num = (short)1504444416;
				short num3 = num;
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)2012358087;
				short num2 = num;
				num = (short)216802759;
				switch (num2 == num)
				{
				}
				num = (short)101974016;
				if (num != 0)
				{
				}
				num = (short)1600978945;
				if (num != 0)
				{
				}
				num = (short)1183711232;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000079F4 File Offset: 0x00005BF4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)12700594;
				short num2 = num;
				num = (short)103271346;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)189136896;
					short num3 = num;
					num = (short)1709244417;
					if (num != 0)
					{
					}
					num = (short)1052704768;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("瑚ၜぞᕠౢᝤࡦը੪䍬ⱮṰṲᡴᡶ᝸㡺⵼Ȿ꾀톂삌ﾐﺚ辠ﮨ\udbae킰솲얶횸\uddba풼펾꓀ꛄ꣆꓈믊ꋌꇎ듐뷒ꇔꯘ뫚맜뛞軠蟢胤鏦裨苪臬鳮蟰髲郴胶훸觺鳼鯾栀氂愄戆紈樊搌挎成攒簔爖渘㔚攜縞䰠伢", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007AD8 File Offset: 0x00005CD8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1071579139;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)454426626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (connectionId != 2)
					{
						num = (short)1527709696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 2:
					goto IL_A8;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					num = (short)1324875777;
					if (num != 0)
					{
					}
					num = (short)1685913601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)352845828;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView)target).Loaded += this.a;
			return;
			IL_A8:
			num = (short)325042278;
			short num3 = num;
			num = (short)1682817126;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12D:
				num = (short)1197604864;
				short num4 = num;
				this.dgrOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			}
			default:
				num = (short)40960000;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007C50 File Offset: 0x00005E50
		// Note: this type is marked as 'beforefieldinit'.
		static RadioDetailsView()
		{
			int a_ = 16;
			short num = (short)284861635;
			short num2 = num;
			num = (short)1424008387;
			switch (num2 == num)
			{
			}
			num = (short)1934098432;
			if (num != 0)
			{
			}
			num = (short)1717370881;
			if (num != 0)
			{
			}
			num = (short)2120810496;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillStartedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("≠٢।୦⽨ɪŬͮ≰ݲᑴն൸Ṻ᥼㱾", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("≠٢।୦⽨ɪŬͮ㑰ᵲᅴቶᵸ㡺ቼቾ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007D64 File Offset: 0x00005F64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventArgs A_0)
		{
			short num = (short)1172350183;
			short num2 = num;
			num = (short)374908135;
			switch (num2 == num)
			{
			}
			num = (short)350093313;
			if (num != 0)
			{
			}
			num = (short)504692736;
			if (num != 0)
			{
			}
			num = (short)784400384;
			short num3 = num;
			this.CellFillStartedCommand.Execute();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007E1C File Offset: 0x0000601C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)836924486;
			short num2 = num;
			num = (short)1236956230;
			switch (num2 == num)
			{
			}
			num = (short)1274150912;
			if (num != 0)
			{
			}
			num = (short)400293889;
			if (num != 0)
			{
			}
			num = (short)653459456;
			short num3 = num;
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x0400002A RID: 42
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x0400002B RID: 43
		public static readonly global::System.Windows.DependencyProperty CellFillStartedCommandProperty;

		// Token: 0x0400002C RID: 44
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x0400002D RID: 45
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrOtarProfiles;

		// Token: 0x0400002E RID: 46
		private bool _contentLoaded;
	}
}
