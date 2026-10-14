using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Controls.Menus;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000018 RID: 24
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "NavigationRegion")]
	public class NavigationView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000939C File Offset: 0x0000759C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public NavigationView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.InitializeComponent();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangeButtonBarModeEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>(this.a));
			if (!string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode))
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum a_ = (global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum), global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode);
				this.a(a_);
			}
			else
			{
				this.a(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.IconMode);
				global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode = global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.IconMode.ToString();
				global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.Save();
			}
			this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LeavingSetCancelledEvent>().Subscribe(new global::System.Action<string>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LeavingHomeSetCancelledEvent>().Subscribe(new global::System.Action<string>(this.a));
			this.cmnActions.Opened += this.a;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009484 File Offset: 0x00007684
		private void a(object A_0, global::Infragistics.Controls.Menus.OpenedEventArgs A_1)
		{
			short num = (short)873995702;
			short num2 = num;
			num = (short)2097683894;
			switch (num2 == num)
			{
			}
			num = (short)1098055681;
			if (num != 0)
			{
			}
			num = (short)238944256;
			if (num != 0)
			{
			}
			num = (short)1472659456;
			short num3 = num;
			this.a(this.cmnActions.Items.Cast<object>().OfType<global::Infragistics.Controls.Menus.XamMenuItem>());
			this.b(this.cmnActions.Items.Cast<object>().OfType<global::Infragistics.Controls.Menus.XamMenuItem>());
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009564 File Offset: 0x00007764
		private void b(global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Menus.XamMenuItem> A_0)
		{
			short num;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamMenuItem> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)632422404;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							xamMenuItem.IsEnabled = false;
							xamMenuItem.IsKeyboardNavigable = false;
							num = (short)1902182402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1719468040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = enumerator.Current;
							num = (short)1327628291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							if (xamMenuItem.Items.Count > 0)
							{
								num = (short)1318453257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 5:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							if (xamMenuItem.Items.Cast<object>().OfType<global::Infragistics.Controls.Menus.XamMenuItem>().All(new global::System.Func<global::Infragistics.Controls.Menus.XamMenuItem, bool>(global::Motorola.CommonCPS.RadioManagement.Common.NavigationView.<>c.<>9.a)))
							{
								num = (short)410976256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							xamMenuItem.IsEnabled = true;
							xamMenuItem.IsKeyboardNavigable = true;
							num = (short)379977734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_1D2;
						case 8:
							num = (short)875560967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							this.b(xamMenuItem.Items.Cast<object>().OfType<global::Infragistics.Controls.Menus.XamMenuItem>());
							num = (short)914620421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_13F:
						num = (short)1309605889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_57:
						goto IL_13F;
					}
					IL_1D2:;
				}
				finally
				{
					num = (short)818806784;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_206;
							}
							continue;
						case 1:
							goto IL_23A;
						case 2:
							enumerator.Dispose();
							num = (short)361955329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_206:
						if (enumerator == null)
						{
							break;
						}
						num = (short)699072514;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_23A:;
				}
				num = (short)2046769272;
				short num3 = num;
				num = (short)319502456;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_271;
				}
			}
			IL_271:
			num = (short)1804402688;
			short num4 = num;
			num = (short)1180827649;
			if (num != 0)
			{
			}
			num = (short)1856045056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009868 File Offset: 0x00007A68
		private void a(global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Menus.XamMenuItem> A_0)
		{
			short num;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamMenuItem> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)1648689154;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_11E;
						case 1:
							num = (short)1988231168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4B;
							}
							continue;
						case 3:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							if (xamMenuItem.Items.Count > 0)
							{
								num = (short)367788036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							this.a(xamMenuItem.Items.Cast<object>().OfType<global::Infragistics.Controls.Menus.XamMenuItem>());
							num = (short)1285029893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1444020225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = enumerator.Current;
							xamMenuItem.IsKeyboardNavigable = (xamMenuItem.Visibility == global::System.Windows.Visibility.Visible);
							num = (short)573571075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_9C:
						num = (short)277348358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4B:
						goto IL_9C;
					}
					IL_11E:;
				}
				finally
				{
					num = (short)150339584;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_152;
							}
							continue;
						case 1:
							goto IL_185;
						case 2:
							enumerator.Dispose();
							num = (short)1023410177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_152:
						if (enumerator == null)
						{
							break;
						}
						num = (short)545718274;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_185:;
				}
				num = (short)600001369;
				short num3 = num;
				num = (short)1914063705;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1BE;
				}
			}
			IL_1BE:
			num = (short)913833984;
			short num4 = num;
			num = (short)910032897;
			if (num != 0)
			{
			}
			num = (short)944963584;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00009AB4 File Offset: 0x00007CB4
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel ViewModel
		{
			set
			{
				short num = (short)809172993;
				if (num != 0)
				{
				}
				num = (short)497831065;
				short num2 = num;
				num = (short)1978420377;
				switch (num2 == num)
				{
				}
				num = (short)90243072;
				if (num != 0)
				{
				}
				num = (short)1598685184;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009B64 File Offset: 0x00007D64
		private void b(object A_0)
		{
			short num = (short)795126882;
			short num2 = num;
			num = (short)757967970;
			switch (num2 == num)
			{
			}
			num = (short)455475201;
			if (num != 0)
			{
			}
			num = (short)2146369536;
			if (num != 0)
			{
			}
			num = (short)1747517440;
			short num3 = num;
			this.tbiRadios.IsSelected = false;
			this.tbiASTROSystems.IsSelected = false;
			this.tbiASTRODataProfiles.IsSelected = false;
			this.tbiJobs.IsSelected = false;
			this.tbiPCRSystems.IsSelected = false;
			this.tbcMainModules.Focus();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009C58 File Offset: 0x00007E58
		private void a(object A_0)
		{
			short num = (short)756171341;
			short num2 = num;
			num = (short)1752777293;
			switch (num2 == num)
			{
			}
			num = (short)1642070017;
			if (num != 0)
			{
			}
			num = (short)1588199424;
			if (num != 0)
			{
			}
			num = (short)1465516032;
			short num3 = num;
			this.tbiRadios.IsSelected = false;
			this.tbiASTROSystems.IsSelected = false;
			this.tbiASTRODataProfiles.IsSelected = false;
			this.tbiJobs.IsSelected = false;
			this.tbiPCRSystems.IsSelected = false;
			this.tbcMainModules.Focus();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009D4C File Offset: 0x00007F4C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum A_0)
		{
			int a_ = 17;
			short num = (short)1776156672;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_24E;
				case 2:
					if (A_0 == global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.IconMode)
					{
						num = (short)1823866881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_373;
				case 3:
					goto IL_59;
				}
				IL_3D:
				if (A_0 == global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.TextMode)
				{
					num = (short)974651395;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)258725193;
					short num3 = num;
					num = (short)570021193;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1830682624;
						if (num != 0)
						{
						}
						num = (short)1843003392;
						short num4 = num;
						num = (short)2041839617;
						if (num != 0)
						{
						}
						num = (short)216072194;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_59:
			this.tbiRadios.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뇢蓤菦胨蓪黬믮铰诲致ꏶ飸駺듼课搀渂嘄猆瀈朊栌", a_)];
			this.tbiASTROSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪ뻬雮苰蟲郴髶諸꿺飼蟾甀圂搄攆䀈缊栌戎䈐朒气笖簘", a_)];
			this.tbiASTRODataProfiles.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪꧬ軮藰鋲ꗴ藶雸鷺铼鏾搀瀂億戆焈缊夌渎猐娒愔爖琘䠚検昞䴠䘢", a_)];
			this.tbiPCRSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돢ꛤ뗦뫨鋪黬鯮铰黲蛴ꏶ鳸菺觼꯾怀愂䰄猆氈昊希笎栐缒瀔", a_)];
			this.tbiJobs.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꧢ諤藦髨뿪裬韮藰ꟲ铴闶냸迺飼鋾刀眂簄欆氈", a_)];
			this.tgbActions.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ蛤鏦胨蓪菬귮蓰蟲致飶韸꿺飼蟾甀倂焄縆攈渊", a_)];
			this.btnScheduleJob.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("냢蛤迦賨迪飬菮铰맲髴闶그黺藼课刀眂簄欆氈", a_)];
			return;
			IL_24E:
			this.tbiRadios.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뇢蓤菦胨蓪黬믮郰釲보菶鳸雺껼课砀漂怄", a_)];
			this.tbiASTROSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪ뻬雮苰蟲郴髶諸꿺鳼鷾䠀眂怄樆娈缊琌挎琐", a_)];
			this.tbiASTRODataProfiles.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪꧬ軮藰鋲ꗴ藶雸鷺铼鏾搀瀂億昆欈䈊礌樎簐䀒愔渖甘縚", a_)];
			this.tbiPCRSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돢ꛤ뗦뫨鋪黬鯮铰黲蛴ꏶ飸駺듼课搀渂嘄猆瀈朊栌", a_)];
			this.tbiJobs.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꧢ諤藦髨뿪賬跮룰蟲郴髶꫸迺蓼鏾搀", a_)];
			this.tgbActions.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ蛤鏦胨蓪菬鳮돰蛲致菶雸闺껼课砀漂怄", a_)];
			this.btnScheduleJob.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("냢蛤迦賨迪飬菮铰맲髴闶미軺觼课渀洂嘄猆瀈朊栌", a_)];
			return;
			IL_373:
			this.tbiRadios.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뇢蓤菦胨蓪黬믮郰釲보菶鳸雺껼课砀漂怄", a_)];
			this.tbiASTROSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪ뻬雮苰蟲郴髶諸꿺鳼鷾䠀眂怄樆娈缊琌挎琐", a_)];
			this.tbiASTRODataProfiles.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ뛤돦믨ꓪꧬ軮藰鋲ꗴ藶雸鷺铼鏾搀瀂億昆欈䈊礌樎簐䀒愔渖甘縚", a_)];
			this.tbiPCRSystems.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돢ꛤ뗦뫨鋪黬鯮铰黲蛴ꏶ飸駺듼课搀渂嘄猆瀈朊栌", a_)];
			this.tbiJobs.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꧢ諤藦髨뿪賬跮룰蟲郴髶꫸迺蓼鏾搀", a_)];
			this.tgbActions.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꋢ蛤鏦胨蓪菬鳮돰蛲致菶雸闺껼课砀漂怄", a_)];
			this.btnScheduleJob.Style = (global::System.Windows.Style)base.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("냢蛤迦賨迪飬菮铰맲髴闶미軺觼课渀洂嘄猆瀈朊栌", a_)];
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000A1EC File Offset: 0x000083EC
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)671032207;
			short num2 = num;
			num = (short)1636770703;
			switch (num2 == num)
			{
			}
			num = (short)337575937;
			if (num != 0)
			{
			}
			num = (short)1616838656;
			if (num != 0)
			{
			}
			num = (short)400293888;
			short num3 = num;
			this.tgbActions.IsChecked = new bool?(false);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A2A4 File Offset: 0x000084A4
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)543303893;
			short num2 = num;
			num = (short)691742933;
			switch (num2 == num)
			{
			}
			num = (short)775421952;
			if (num != 0)
			{
			}
			num = (short)174784513;
			if (num != 0)
			{
			}
			num = (short)504430592;
			short num3 = num;
			this.tgbActions.Focus();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A35C File Offset: 0x0000855C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)838027128;
			short num2 = num;
			num = (short)887768952;
			switch (num2 == num)
			{
			}
			num = (short)955449345;
			if (num != 0)
			{
			}
			num = (short)1982791680;
			if (num != 0)
			{
			}
			num = (short)847052800;
			short num3 = num;
			this.cmnActions.IsOpen = true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A414 File Offset: 0x00008614
		private void a()
		{
			int a_ = 10;
			short num = (short)988039623;
			short num2 = num;
			num = (short)1326401991;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2127822848;
				short num3 = num;
				num = (short)1311899648;
				if (num != 0)
				{
				}
				num = (short)2007695361;
				if (num != 0)
				{
				}
				num = (short)678625280;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					string text = global::System.IO.Path.Combine(global::System.Windows.Forms.Application.StartupPath, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軛뿝蓟诡诣ꯥ觧蓩跫觭闯鿱釳飵賷퓹뻻닽哿朁眃爅☇渉怋戍", a_));
					if (global::System.IO.File.Exists(text))
					{
						try
						{
							switch (0)
							{
							case 0:
								goto IL_108;
							}
							global::System.Reflection.MethodInfo method;
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
							for (;;)
							{
								IL_F1:
								switch (num4)
								{
								case 0:
									if (method != null)
									{
										num = (short)1821114371;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_324;
								case 1:
									goto IL_33E;
								case 2:
									try
									{
										num = (short)532086785;
										num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num4)
											{
											case 0:
												goto IL_2B4;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_230;
												}
												continue;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamMenuItem> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1782382596;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Controls.Menus.XamMenuItem newItem = enumerator.Current;
												xamMenuItem.Items.Add(newItem);
												num = (short)1776222211;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)595132416;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_232:
											num = (short)1858338818;
											num4 = (int)((global::System.IntPtr)num);
											continue;
											IL_230:
											goto IL_232;
										}
										IL_2B4:;
									}
									finally
									{
										num = (short)1776746496;
										num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamMenuItem> enumerator;
											switch (num4)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_2EA;
												}
												continue;
											case 1:
												goto IL_321;
											case 2:
												enumerator.Dispose();
												num = (short)1615593473;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2EA:
											if (enumerator == null)
											{
												break;
											}
											num = (short)126746626;
											num4 = (int)((global::System.IntPtr)num);
										}
										IL_321:;
									}
									goto IL_324;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamMenuItem> enumerator = ((global::System.Collections.Generic.IList<global::Infragistics.Controls.Menus.XamMenuItem>)method.Invoke(this._menuBuilder, null)).GetEnumerator();
									num = (short)1905262594;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_108;
								IL_324:
								num = (short)58785793;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_33E:
							break;
							IL_108:
							xamMenuItem = new global::Infragistics.Controls.Menus.XamMenuItem
							{
								Header = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("黛鋝곟싡냣菥鯧黩쳫웭돯ꋱꟳ훵뇷铹裻鯽狿氁攃樅⠇帉椋納搏㈑嬓砕琗挙㔛", a_)
							};
							xamMenuItem.SubmenuOpened += this.a;
							this.cmnActions.Items.Add(xamMenuItem);
							global::System.Type type = global::System.Reflection.Assembly.Load(text).GetType(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軛뿝蓟诡诣ꯥ觧蓩跫觭闯鿱釳飵賷퓹뻻닽哿朁眃爅☇䜉椋怍攏們愓缕琗縙礛氝", a_));
							this._menuBuilder = global::System.Activator.CreateInstance(type);
							method = type.GetMethod(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("黛ꯝ觟軡胣ꯥ跧蓩駫", a_));
							num = (short)1445789696;
							num4 = (int)((global::System.IntPtr)num);
							goto IL_F1;
						}
						catch
						{
						}
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A798 File Offset: 0x00008998
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 0;
			short num = (short)146079744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_2BD;
					case 1:
						if (xamMenuItem != null)
						{
							goto IL_6E;
						}
						return;
					case 2:
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem>();
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)xamMenuItem.Items).GetEnumerator();
						num = (short)881590276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Reflection.MethodInfo method = this._menuBuilder.GetType().GetMethod(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("金볓돕믗뇙釛믝軟韡럣鋥觧黩駫鷭", a_));
						if (method == null)
						{
							return;
						}
						object[] parameters;
						method.Invoke(this._menuBuilder, parameters);
						num = (short)2022375425;
						if (num != 0)
						{
						}
						num = (short)1870528512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)343706157;
						short num3 = num;
						num = (short)433293869;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						default:
						{
							num = (short)331546624;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem> list;
							try
							{
								num = (short)599457793;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1B4;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_136;
										}
										continue;
									case 3:
										num = (short)483131392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)65404931;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Controls.Menus.XamMenuItem item = (global::Infragistics.Controls.Menus.XamMenuItem)enumerator.Current;
										list.Add(item);
										num = (short)847642626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_165:
									num = (short)327684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_136:
									goto IL_165;
								}
								IL_1B4:;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1D3;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1C0:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1086717954;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_229;
									case 1:
										goto IL_227;
									case 2:
										disposable.Dispose();
										num = (short)1495990273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D3;
								}
								IL_227:
								IL_229:
								goto EndFinally_6;
								IL_1D3:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1658650624;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1C0;
								EndFinally_6:;
							}
							object[] parameters = new object[]
							{
								list
							};
							num = (short)403570691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_4C;
					IL_6E:
					num = (short)1728446466;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2BD:
				num = (short)1263206400;
				short num4 = num;
				return;
				IL_4C:
				xamMenuItem = (A_0 as global::Infragistics.Controls.Menus.XamMenuItem);
				num = (short)1522597889;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num = (short)549344386;
			short num2 = num;
			num = (short)1031885954;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)179240960;
				short num3 = num;
				num = (short)1682243584;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					num = (short)1714421761;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郜냞闠賢韤裦藨諪쏬곮黰黲飴飶韸룺근곾⼀儂搄挆怈搊䀌渎缐爒爔爖琘縚猜欞༠怢䨤䨦䐨䐪䌬ᐮ到尲場䜶嘸唺堼儾㕀求⭄♆㽈≊⩌⹎═㩒㩔㥖⽘㉚㡜⡞习ൢѤᅦh౪౬᭮ᡰᱲ᭴ŶၸṺ੼兾呂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AB80 File Offset: 0x00008D80
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1936523264;
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
					num = (short)1403781122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_21A;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_2E2;
				case 2:
					goto IL_38A;
				case 3:
					goto IL_3E2;
				case 4:
					goto IL_37D;
				case 5:
					goto IL_3C8;
				case 6:
					goto IL_19A;
				case 7:
					goto IL_22C;
				case 8:
					goto IL_294;
				case 9:
					goto IL_21F;
				case 10:
					goto IL_180;
				case 11:
					goto IL_1CE;
				case 12:
					goto IL_2C8;
				case 13:
					goto IL_239;
				case 14:
					goto IL_2BB;
				case 15:
					goto IL_287;
				case 16:
					goto IL_2AE;
				case 17:
					goto IL_3BB;
				case 18:
					goto IL_26D;
				case 19:
					goto IL_260;
				case 20:
					goto IL_1F5;
				case 21:
					goto IL_2FC;
				case 22:
					goto IL_316;
				case 23:
					goto IL_478;
				case 24:
					goto IL_406;
				case 25:
					goto IL_2EF;
				case 26:
					goto IL_2D5;
				case 27:
					goto IL_173;
				case 28:
					goto IL_1C1;
				case 29:
					goto IL_420;
				case 30:
					goto IL_27A;
				case 31:
					goto IL_46B;
				case 32:
					goto IL_43A;
				case 33:
					goto IL_1A7;
				case 34:
					goto IL_116;
				case 35:
					goto IL_413;
				case 36:
					goto IL_3D5;
				case 37:
					goto IL_253;
				case 38:
					goto IL_309;
				case 39:
					goto IL_2A1;
				case 40:
					goto IL_18D;
				case 41:
					goto IL_447;
				case 42:
					goto IL_1DB;
				case 43:
					goto IL_246;
				case 44:
					goto IL_1B4;
				case 45:
					goto IL_323;
				case 46:
					goto IL_3AE;
				case 47:
					goto IL_1E8;
				case 48:
					goto IL_42D;
				default:
					num = (short)2091778049;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_116:
			num = (short)681246721;
			if (num != 0)
			{
			}
			num = (short)85262336;
			short num3 = num;
			this.mniDVRSFiles = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_173:
			this.mniLicense = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_180:
			this.mniImportFirmwares = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_18D:
			this.btnScheduleJob = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_19A:
			this.mniImportRadios = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_1A7:
			this.mniCertificates = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_1B4:
			this.tbiPCRSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
			return;
			IL_1C1:
			this.mniRadioLicense = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_1CE:
			this.mniImporVoiceAnnoucements = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_1DB:
			this.tbiRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
			return;
			IL_1E8:
			this.tbiJobs = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
			return;
			IL_1F5:
			this.mniPrintViewPreview = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_21A:
			this._contentLoaded = true;
			return;
			IL_21F:
			this.mniImportTemplates = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_22C:
			this.mniImportFileToGridCommand = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_239:
			this.mniImportCACertificates = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_246:
			this.tbiASTROSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
			return;
			IL_253:
			this.mniTasks = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_260:
			this.mniPrint = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_26D:
			this.mniExportGirdToFile = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_27A:
			this.mniFirmware = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_287:
			this.mniExport = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_294:
			this.mniImportFromConsole = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2A1:
			this.mniAbout = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2AE:
			this.mniExportRadio = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2BB:
			this.mniImportDVRSFiles = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2C8:
			this.mniImportLanguagePacks = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2D5:
			this.mniTemplates = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2E2:
			this.ButtonBarIconMode = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2EF:
			this.mniSetDebugger = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_2FC:
			this.mniPrintView = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_309:
			this.mniHelp = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_316:
			this.mniRestore = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_323:
			num = (short)1633695195;
			short num4 = num;
			num = (short)983119323;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_447:
				this.tbcMainModules = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabControl)target;
				this.tbcMainModules.PreviewMouseDown += this.a;
				return;
			default:
				num = (short)2095382528;
				if (num != 0)
				{
				}
				this.tbiASTROOtarProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
				return;
			}
			IL_37D:
			this.mniNewRadio = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_38A:
			this.tgbActions = (global::Motorola.CommonCPS.RadioManagement.Controls.RMActionMenu)target;
			this.tgbActions.Checked += this.a;
			return;
			IL_3AE:
			this.tbiASTRODataProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)target;
			return;
			IL_3BB:
			this.mniExportDVRS = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_3C8:
			this.mniImport = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_3D5:
			this.mniSettings = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_3E2:
			this.cmnActions = (global::Infragistics.Controls.Menus.XamContextMenu)target;
			this.cmnActions.Closed += this.b;
			return;
			IL_406:
			this.manageMenu = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_413:
			this.mniRnCodeplugUploader = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_420:
			this.mniApplicationLicense = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_42D:
			this.pnvPathNavigator = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator)target;
			return;
			IL_43A:
			this.mniVA = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_46B:
			this.mniLP = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_478:
			this.mniResetIdentifiers = (global::Infragistics.Controls.Menus.XamMenuItem)target;
		}

		// Token: 0x04000060 RID: 96
		private object _menuBuilder;

		// Token: 0x04000061 RID: 97
		internal global::System.Windows.Controls.Grid ButtonBarIconMode;

		// Token: 0x04000062 RID: 98
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMActionMenu tgbActions;

		// Token: 0x04000063 RID: 99
		internal global::Infragistics.Controls.Menus.XamContextMenu cmnActions;

		// Token: 0x04000064 RID: 100
		internal global::Infragistics.Controls.Menus.XamMenuItem mniNewRadio;

		// Token: 0x04000065 RID: 101
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImport;

		// Token: 0x04000066 RID: 102
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportRadios;

		// Token: 0x04000067 RID: 103
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportFileToGridCommand;

		// Token: 0x04000068 RID: 104
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportFromConsole;

		// Token: 0x04000069 RID: 105
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportTemplates;

		// Token: 0x0400006A RID: 106
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportFirmwares;

		// Token: 0x0400006B RID: 107
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImporVoiceAnnoucements;

		// Token: 0x0400006C RID: 108
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportLanguagePacks;

		// Token: 0x0400006D RID: 109
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportCACertificates;

		// Token: 0x0400006E RID: 110
		internal global::Infragistics.Controls.Menus.XamMenuItem mniImportDVRSFiles;

		// Token: 0x0400006F RID: 111
		internal global::Infragistics.Controls.Menus.XamMenuItem mniExport;

		// Token: 0x04000070 RID: 112
		internal global::Infragistics.Controls.Menus.XamMenuItem mniExportRadio;

		// Token: 0x04000071 RID: 113
		internal global::Infragistics.Controls.Menus.XamMenuItem mniExportDVRS;

		// Token: 0x04000072 RID: 114
		internal global::Infragistics.Controls.Menus.XamMenuItem mniExportGirdToFile;

		// Token: 0x04000073 RID: 115
		internal global::Infragistics.Controls.Menus.XamMenuItem mniPrint;

		// Token: 0x04000074 RID: 116
		internal global::Infragistics.Controls.Menus.XamMenuItem mniPrintViewPreview;

		// Token: 0x04000075 RID: 117
		internal global::Infragistics.Controls.Menus.XamMenuItem mniPrintView;

		// Token: 0x04000076 RID: 118
		internal global::Infragistics.Controls.Menus.XamMenuItem mniRestore;

		// Token: 0x04000077 RID: 119
		internal global::Infragistics.Controls.Menus.XamMenuItem mniResetIdentifiers;

		// Token: 0x04000078 RID: 120
		internal global::Infragistics.Controls.Menus.XamMenuItem manageMenu;

		// Token: 0x04000079 RID: 121
		internal global::Infragistics.Controls.Menus.XamMenuItem mniSetDebugger;

		// Token: 0x0400007A RID: 122
		internal global::Infragistics.Controls.Menus.XamMenuItem mniTemplates;

		// Token: 0x0400007B RID: 123
		internal global::Infragistics.Controls.Menus.XamMenuItem mniLicense;

		// Token: 0x0400007C RID: 124
		internal global::Infragistics.Controls.Menus.XamMenuItem mniRadioLicense;

		// Token: 0x0400007D RID: 125
		internal global::Infragistics.Controls.Menus.XamMenuItem mniApplicationLicense;

		// Token: 0x0400007E RID: 126
		internal global::Infragistics.Controls.Menus.XamMenuItem mniFirmware;

		// Token: 0x0400007F RID: 127
		internal global::Infragistics.Controls.Menus.XamMenuItem mniLP;

		// Token: 0x04000080 RID: 128
		internal global::Infragistics.Controls.Menus.XamMenuItem mniVA;

		// Token: 0x04000081 RID: 129
		internal global::Infragistics.Controls.Menus.XamMenuItem mniCertificates;

		// Token: 0x04000082 RID: 130
		internal global::Infragistics.Controls.Menus.XamMenuItem mniDVRSFiles;

		// Token: 0x04000083 RID: 131
		internal global::Infragistics.Controls.Menus.XamMenuItem mniRnCodeplugUploader;

		// Token: 0x04000084 RID: 132
		internal global::Infragistics.Controls.Menus.XamMenuItem mniSettings;

		// Token: 0x04000085 RID: 133
		internal global::Infragistics.Controls.Menus.XamMenuItem mniTasks;

		// Token: 0x04000086 RID: 134
		internal global::Infragistics.Controls.Menus.XamMenuItem mniHelp;

		// Token: 0x04000087 RID: 135
		internal global::Infragistics.Controls.Menus.XamMenuItem mniAbout;

		// Token: 0x04000088 RID: 136
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnScheduleJob;

		// Token: 0x04000089 RID: 137
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabControl tbcMainModules;

		// Token: 0x0400008A RID: 138
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiRadios;

		// Token: 0x0400008B RID: 139
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiASTROSystems;

		// Token: 0x0400008C RID: 140
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiPCRSystems;

		// Token: 0x0400008D RID: 141
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiASTROOtarProfiles;

		// Token: 0x0400008E RID: 142
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiASTRODataProfiles;

		// Token: 0x0400008F RID: 143
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem tbiJobs;

		// Token: 0x04000090 RID: 144
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator pnvPathNavigator;

		// Token: 0x04000091 RID: 145
		private bool _contentLoaded;
	}
}
