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
	// Token: 0x02000008 RID: 8
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROOtarProfileMainRegion")]
	public class OtarProfileDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002F7C File Offset: 0x0000117C
		public OtarProfileDetailsView()
		{
			int a_ = 15;
			base..ctor();
			this.InitializeComponent();
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillStartedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⍟ݡࡣ੥⹧ͩkɭ⍯ٱᕳѵ౷ό᡻㵽", a_));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⍟ݡࡣ੥⹧ͩkɭ㕯ᱱၳ፵ᱷ㥹፻፽", a_));
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002FD4 File Offset: 0x000011D4
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1094171481;
				short num2 = num;
				num = (short)2102704985;
				switch (num2 == num)
				{
				}
				num = (short)1065222144;
				short num3 = num;
				num = (short)1650720769;
				if (num != 0)
				{
				}
				num = (short)1167261696;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003088 File Offset: 0x00001288
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1265500166;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BB;
				case 1:
					goto IL_F7;
				case 2:
				{
					num = (short)841875457;
					if (num != 0)
					{
					}
					num = (short)1848770560;
					short num3 = num;
					this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("S㍕㕗⩙せ㽝ᑟݡ⩣ݥէཀྵ", a_));
					num = (short)1708457989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (this.fillManager == null)
					{
						num = (short)759693313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					goto IL_BB;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				}
				IL_4B:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᝓ㥕㙗㱙㕛㥝ᕟၡգብŧթɫ⁭ᅯάᅳ", a_));
					num = (short)1444478976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)4915134;
				short num4 = num;
				num = (short)535429054;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F7;
				default:
					num = (short)1046544384;
					if (num != 0)
					{
					}
					num = (short)1477902338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BB:
				num = (short)132579331;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F7:
				this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.b.a(this.dgrRadios);
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
				cellRangeFillManager.CellFillStarted = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillStarted, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler(this.a));
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager2 = this.fillManager;
				cellRangeFillManager2.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager2.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
				num = (short)1489436676;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000032C0 File Offset: 0x000014C0
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000337C File Offset: 0x0000157C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			get
			{
				short num = (short)1382547457;
				if (num != 0)
				{
				}
				num = (short)2061680480;
				short num2 = num;
				num = (short)620478304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813432832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)233832448;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillStartedCommandProperty);
			}
			set
			{
				short num = (short)798619398;
				short num2 = num;
				num = (short)1493432070;
				switch (num2 == num)
				{
				}
				num = (short)133627904;
				short num3 = num;
				num = (short)288096256;
				if (num != 0)
				{
				}
				num = (short)957874177;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillStartedCommandProperty, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003430 File Offset: 0x00001630
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000034E8 File Offset: 0x000016E8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)1482686465;
				if (num != 0)
				{
				}
				num = (short)2012303525;
				short num2 = num;
				num = (short)2106806437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)350093312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392167424;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)1835167169;
				short num2 = num;
				num = (short)1607691713;
				switch (num2 == num)
				{
				}
				num = (short)1112080384;
				short num3 = num;
				num = (short)287571969;
				if (num != 0)
				{
				}
				num = (short)1929183232;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000359C File Offset: 0x0000179C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num;
			if (this._contentLoaded)
			{
				num = (short)1665290196;
				short num2 = num;
				num = (short)31936468;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)221904896;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1166606337;
			if (num != 0)
			{
			}
			num = (short)1814953984;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("祕ᕗ㕙⡛ㅝ቟ൡࡣݥ䙧⥩ͫͭᵯᵱᩳ㕵⡷⥹剻ⱽ얇煉늛\udf9d\udea9춫\udcad삱\udbb3킵톷횹\ud9bb薽ꎿ귁꧃뛅Ꟈ꓉꧋ꃍ꓏﷑믓ꋕ맗꣙곛곝迟蓡跣諥跧軩觫髭釯鯱飳藵軷鏹駻觽⿿洁瀃朅稇稉縋愍瘏笑砓猕簗缙栛缝䤟両圣倥䄧伩嬫-䠯匱夳娵", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003680 File Offset: 0x00001880
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1965948932;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D8;
				case 1:
					num = (short)689831937;
					if (num != 0)
					{
					}
					num = (short)1983447043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_136;
				case 3:
					if (connectionId != 2)
					{
						num = (short)633733122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				IL_38:
				num = (short)1188586630;
				short num3 = num;
				num = (short)1713267846;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_136:
					num = (short)1110048768;
					short num4 = num;
					num = (short)1300955136;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)354484224;
					if (num != 0)
					{
					}
					if (connectionId == 1)
					{
						goto IL_9C;
					}
					num = (short)697434113;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_9C:
			this.uscOtarProfileDetails = (global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView)target;
			this.uscOtarProfileDetails.Loaded += this.a;
			return;
			IL_D8:
			this._contentLoaded = true;
			return;
			IL_166:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003808 File Offset: 0x00001A08
		// Note: this type is marked as 'beforefieldinit'.
		static OtarProfileDetailsView()
		{
			int a_ = 15;
			short num = (short)1398964336;
			short num2 = num;
			num = (short)118194288;
			switch (num2 == num)
			{
			}
			num = (short)630784000;
			short num3 = num;
			num = (short)1787625473;
			if (num != 0)
			{
			}
			num = (short)329187328;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillStartedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⍟ݡࡣ੥⹧ͩkɭ⍯ٱᕳѵ౷ό᡻㵽", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("⍟ݡࡣ੥⹧ͩkɭ㕯ᱱၳ፵ᱷ㥹፻፽", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003920 File Offset: 0x00001B20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventArgs A_0)
		{
			short num = (short)1222686421;
			short num2 = num;
			num = (short)1055897301;
			switch (num2 == num)
			{
			}
			num = (short)906297344;
			short num3 = num;
			num = (short)1930756097;
			if (num != 0)
			{
			}
			num = (short)1544224768;
			if (num != 0)
			{
			}
			this.CellFillStartedCommand.Execute();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000039D4 File Offset: 0x00001BD4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)1193883050;
			short num2 = num;
			num = (short)990983594;
			switch (num2 == num)
			{
			}
			num = (short)811728896;
			short num3 = num;
			num = (short)497745921;
			if (num != 0)
			{
			}
			num = (short)1380646912;
			if (num != 0)
			{
			}
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x04000004 RID: 4
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty CellFillStartedCommandProperty;

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsView uscOtarProfileDetails;

		// Token: 0x04000008 RID: 8
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000009 RID: 9
		private bool _contentLoaded;
	}
}
