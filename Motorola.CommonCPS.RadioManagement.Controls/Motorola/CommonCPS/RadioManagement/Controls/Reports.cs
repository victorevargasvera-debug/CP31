using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.DockManager;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B1 RID: 177
	public class Reports : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x0004949C File Offset: 0x0004769C
		public Reports()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000494C8 File Offset: 0x000476C8
		private void ReportsOptionsListBox_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			int num;
			global::System.Windows.Controls.ListBox listBox;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (listBox.SelectedItem != null)
						{
							num2 = (short)1422655492;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1863997089;
						short num3 = num2;
						num2 = (short)672487073;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33;
						default:
							num2 = (short)1802829824;
							if (num2 != 0)
							{
							}
							num2 = (short)623443973;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
					{
						num2 = (short)283049984;
						short num4 = num2;
						object obj;
						if (listBox.Items.Contains(obj))
						{
							num2 = (short)1817444355;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 2:
					{
						num2 = (short)678952961;
						if (num2 != 0)
						{
						}
						object obj = A_1.RemovedItems[0];
						num2 = (short)24182785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						object obj;
						listBox.SelectedItem = obj;
						num2 = (short)1599209478;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						goto IL_68;
					case 5:
						if (A_1.RemovedItems.Count > 0)
						{
							num2 = (short)1875247106;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 6:
						return;
					}
					goto IL_2C;
				}
				IL_68:
				global::Motorola.CommonCPS.RadioManagement.UIModels.ReportType parameter = ((global::System.Windows.Controls.ListBox)A_0).SelectedValue as global::Motorola.CommonCPS.RadioManagement.UIModels.ReportType;
				this.GenerateReportCommand.Execute(parameter);
				return;
			}
			}
			IL_2C:
			listBox = (global::System.Windows.Controls.ListBox)A_0;
			IL_33:
			num2 = (short)1777139712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000496B4 File Offset: 0x000478B4
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0004976C File Offset: 0x0004796C
		public global::System.Windows.Data.CollectionView ReportTypeSelections
		{
			get
			{
				short num = (short)386596865;
				if (num != 0)
				{
				}
				num = (short)1361264043;
				short num2 = num;
				num = (short)1281113515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813643264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211957248;
				if (num != 0)
				{
				}
				return (global::System.Windows.Data.CollectionView)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.ReportTypeSelectionsProperty);
			}
			set
			{
				short num = (short)191496193;
				if (num != 0)
				{
				}
				num = (short)693366425;
				short num2 = num;
				num = (short)1776414361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822621696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625803264;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.ReportTypeSelectionsProperty, value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00049824 File Offset: 0x00047A24
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000498DC File Offset: 0x00047ADC
		public string HtmlSource
		{
			get
			{
				short num = (short)1994441805;
				short num2 = num;
				num = (short)73450573;
				switch (num2 == num)
				{
				}
				num = (short)1673986048;
				short num3 = num;
				num = (short)251461633;
				if (num != 0)
				{
				}
				num = (short)723910656;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.HtmlSourceProperty);
			}
			set
			{
				short num = (short)927854807;
				short num2 = num;
				num = (short)1298002135;
				switch (num2 == num)
				{
				}
				num = (short)846856192;
				short num3 = num;
				num = (short)1902510080;
				if (num != 0)
				{
				}
				num = (short)962330625;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.HtmlSourceProperty, value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00049994 File Offset: 0x00047B94
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00049A4C File Offset: 0x00047C4C
		public global::System.Windows.Input.ICommand GenerateReportCommand
		{
			get
			{
				short num = (short)1834050069;
				short num2 = num;
				num = (short)21258773;
				switch (num2 == num)
				{
				}
				num = (short)1182466048;
				if (num != 0)
				{
				}
				num = (short)770244608;
				short num3 = num;
				num = (short)476708865;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.GenerateReportCommandProperty);
			}
			set
			{
				short num = (short)2024940142;
				short num2 = num;
				num = (short)127476334;
				switch (num2 == num)
				{
				}
				num = (short)1636761601;
				if (num != 0)
				{
				}
				num = (short)779026432;
				short num3 = num;
				num = (short)1060438016;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.GenerateReportCommandProperty, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00049B04 File Offset: 0x00047D04
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00049BC0 File Offset: 0x00047DC0
		public global::System.Windows.Input.ICommand RefreshCommand
		{
			get
			{
				short num = (short)755957826;
				short num2 = num;
				num = (short)1801453634;
				switch (num2 == num)
				{
				}
				num = (short)508559360;
				if (num != 0)
				{
				}
				num = (short)1429274624;
				short num3 = num;
				num = (short)923205633;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.RefreshCommandProperty);
			}
			set
			{
				short num = (short)966479181;
				short num2 = num;
				num = (short)1890667853;
				switch (num2 == num)
				{
				}
				num = (short)564461569;
				if (num != 0)
				{
				}
				num = (short)564920320;
				short num3 = num;
				num = (short)1673986048;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.RefreshCommandProperty, value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00049C74 File Offset: 0x00047E74
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00049D30 File Offset: 0x00047F30
		public global::System.Windows.Input.ICommand PrintReportCommand
		{
			get
			{
				short num = (short)675757709;
				short num2 = num;
				num = (short)1971863181;
				switch (num2 == num)
				{
				}
				num = (short)1159069697;
				if (num != 0)
				{
				}
				num = (short)496893952;
				short num3 = num;
				num = (short)85131264;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.PrintReportCommandProperty);
			}
			set
			{
				short num = (short)1691674063;
				short num2 = num;
				num = (short)255845839;
				switch (num2 == num)
				{
				}
				num = (short)1480392705;
				if (num != 0)
				{
				}
				num = (short)698220544;
				short num3 = num;
				num = (short)340918272;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.PrintReportCommandProperty, value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00049DE8 File Offset: 0x00047FE8
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00049EA4 File Offset: 0x000480A4
		public global::System.Windows.Input.ICommand SaveReportCommand
		{
			get
			{
				short num = (short)1069089158;
				short num2 = num;
				num = (short)1126891910;
				switch (num2 == num)
				{
				}
				num = (short)455213057;
				if (num != 0)
				{
				}
				num = (short)479002624;
				short num3 = num;
				num = (short)1382023168;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.SaveReportCommandProperty);
			}
			set
			{
				short num = (short)118825015;
				short num2 = num;
				num = (short)1939611703;
				switch (num2 == num)
				{
				}
				num = (short)1347289089;
				if (num != 0)
				{
				}
				num = (short)415629312;
				short num3 = num;
				num = (short)269418496;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Reports.SaveReportCommandProperty, value);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00049F58 File Offset: 0x00048158
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 19;
			short num;
			while (this._contentLoaded)
			{
				num = (short)1027488206;
				short num2 = num;
				num = (short)1727085006;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)312541184;
					short num3 = num;
					num = (short)188219392;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			num = (short)390332417;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("蒪삮얰\udcb2잴\ud8b6햸\udaba鎼ﲾ껀껂꣄꣆ꟈ裊鷌鳎￐臒듔돖냘듚郜뻞迠苢苤苦蓨軪菬鯮\udff0냲髴駶跸觺鋼鏾爀㠂昄栆搈笊戌愎琐紒愔㠖氘栚砜洞䈠䰢䬤匦嬨䐪䄬尮Ḱ䄲倴䜶嘸䤺䤼䰾潀㭂⑄⩆╈", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0004A038 File Offset: 0x00048238
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)648478721;
			if (num != 0)
			{
			}
			num = (short)917644648;
			short num2 = num;
			num = (short)911943016;
			switch (num2 == num)
			{
			}
			num = (short)1061945344;
			short num3 = num;
			num = (short)2137784320;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0004A0E8 File Offset: 0x000482E8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)521469952;
			short num2 = num;
			num = (short)1397948418;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_132;
				case 1:
				{
					num = (short)1393426433;
					if (num != 0)
					{
					}
					num = (short)193515185;
					short num4 = num;
					num = (short)1785515697;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						num = (short)1058668544;
						if (num != 0)
						{
						}
						num = (short)1257046016;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
					goto IL_141;
				case 2:
					goto IL_99;
				case 3:
					goto IL_14E;
				case 4:
					goto IL_8C;
				case 5:
					goto IL_134;
				default:
					num = (short)1778319361;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8C:
			this.dmgDockManagerReport = (global::Infragistics.Windows.DockManager.XamDockManager)target;
			return;
			IL_99:
			this.cpnReportsList = (global::Infragistics.Windows.DockManager.ContentPane)target;
			return;
			IL_132:
			this._contentLoaded = true;
			return;
			IL_134:
			this.wbReports = (global::System.Windows.Controls.WebBrowser)target;
			return;
			IL_141:
			this.dmgDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)target;
			return;
			IL_14E:
			this.ReportsOptionsListBox = (global::System.Windows.Controls.ListBox)target;
			this.ReportsOptionsListBox.SelectionChanged += this.ReportsOptionsListBox_SelectionChanged;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0004A270 File Offset: 0x00048470
		// Note: this type is marked as 'beforefieldinit'.
		static Reports()
		{
			int a_ = 12;
			short num = (short)1266701032;
			short num2 = num;
			num = (short)1317163752;
			switch (num2 == num)
			{
			}
			num = (short)869400577;
			if (num != 0)
			{
			}
			num = (short)619446272;
			short num3 = num;
			num = (short)759955456;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.ReportTypeSelectionsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎥\ud8a7얩\udeab\udaad쮱쒳펵\udfb9킻\udbbdꎿ뛁귃꧅ꛇ막", a_), typeof(global::System.Windows.Data.CollectionView), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports), new global::System.Windows.PropertyMetadata());
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.HtmlSourceProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튥얧용ﾫ솭얯삱ힳ펵", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports), new global::System.Windows.PropertyMetadata(string.Empty));
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.GenerateReportCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎥욧쾩\udeab쾭쒯ힱ펵좷햹캻쪽莿귁꧃ꯅ꧇꓉꣋", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports));
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.RefreshCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎥캧\ud8a9즫\uddad\ud8af\udbb3\udbb5햷\udbb9튻\udabd", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports));
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.PrintReportCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풥솧쒩\ud8abﲭ햯슱\udbb3쒵첷惡펻펽궿ꏁ꫃ꋅ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports));
			global::Motorola.CommonCPS.RadioManagement.Controls.Reports.SaveReportCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("장\udea7쾩ﺫ쮭삯\uddb1욳습﮷햹톻펽ꆿ곁ꃃ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Reports));
		}

		// Token: 0x040001AA RID: 426
		private global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty ReportTypeSelectionsProperty;

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.DependencyProperty HtmlSourceProperty;

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.DependencyProperty GenerateReportCommandProperty;

		// Token: 0x040001AE RID: 430
		public static readonly global::System.Windows.DependencyProperty RefreshCommandProperty;

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty PrintReportCommandProperty;

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty SaveReportCommandProperty;

		// Token: 0x040001B1 RID: 433
		internal global::Infragistics.Windows.DockManager.XamDockManager dmgDockManager;

		// Token: 0x040001B2 RID: 434
		internal global::Infragistics.Windows.DockManager.ContentPane cpnReportsList;

		// Token: 0x040001B3 RID: 435
		internal global::System.Windows.Controls.ListBox ReportsOptionsListBox;

		// Token: 0x040001B4 RID: 436
		internal global::Infragistics.Windows.DockManager.XamDockManager dmgDockManagerReport;

		// Token: 0x040001B5 RID: 437
		internal global::System.Windows.Controls.WebBrowser wbReports;

		// Token: 0x040001B6 RID: 438
		private bool _contentLoaded;
	}
}
