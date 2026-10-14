using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200002A RID: 42
	[global::System.ComponentModel.Composition.Export]
	public class StatusViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00013EEC File Offset: 0x000120EC
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public StatusViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 1;
			base..ctor(eventAggregator);
			string text = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment ? global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName : global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ServerAddress;
			this.a = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("", a_) + text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DatabaseSpaceWarningEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel>(this.a));
			global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.CheckDatabaseSpaceStatus();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReportStatusRequestedEvent>().Subscribe(new global::System.Action<string>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReportInformationRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00013FA8 File Offset: 0x000121A8
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00014058 File Offset: 0x00012258
		public string Status
		{
			get
			{
				short num = (short)1599786520;
				short num2 = num;
				num = (short)189189656;
				switch (num2 == num)
				{
				}
				num = (short)2055340033;
				if (num != 0)
				{
				}
				num = (short)471269376;
				short num3 = num;
				num = (short)1819017216;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)626130944;
				short num2 = num;
				num = (short)1445320586;
				short num3 = num;
				num = (short)2011551626;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)114950144;
					if (num != 0)
					{
					}
					num = (short)2134376449;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							return;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 2:
							this.a = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel.get_Status())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1652162560;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A3:
						num = (short)315949057;
						if (num != 0)
						{
						}
						if (!(value != this.a))
						{
							break;
						}
						num = (short)1761214466;
						num4 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000141AC File Offset: 0x000123AC
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0001425C File Offset: 0x0001245C
		public string Information
		{
			get
			{
				short num = (short)1191684730;
				short num2 = num;
				num = (short)1664658042;
				switch (num2 == num)
				{
				}
				num = (short)1897791488;
				if (num != 0)
				{
				}
				num = (short)175046656;
				short num3 = num;
				num = (short)2011430913;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)819593217;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1089810195;
						short num3 = num;
						num = (short)943402771;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1784872960;
							if (num != 0)
							{
							}
							break;
						}
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel.get_Information())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2052980736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					num = (short)617283585;
					if (num != 0)
					{
					}
					if (!(value != this.b))
					{
						break;
					}
					num = (short)1828061184;
					short num4 = num;
					num = (short)1270480898;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000143B8 File Offset: 0x000125B8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00014468 File Offset: 0x00012668
		public global::System.Windows.Media.Imaging.BitmapImage DatabaseSpaceWarningIcon
		{
			get
			{
				short num = (short)1087307776;
				short num2 = num;
				num = (short)1780186708;
				short num3 = num;
				num = (short)132415060;
				switch (num3 == num)
				{
				}
				num = (short)1258029056;
				if (num != 0)
				{
				}
				num = (short)783024129;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				int a_ = 13;
				short num = (short)2054946816;
				short num2 = num;
				num = (short)1927549612;
				short num3 = num;
				num = (short)1121915564;
				switch (num3 == num)
				{
				}
				num = (short)816906241;
				if (num != 0)
				{
				}
				num = (short)682164224;
				if (num != 0)
				{
				}
				this.e = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鯞胠韢蓤藦裨飪裬볮臰鋲雴鋶껸髺迼釾栀洂戄丆樈搊挌", a_));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00014538 File Offset: 0x00012738
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000145EC File Offset: 0x000127EC
		public global::System.Windows.Media.Brush DatabaseSpaceWarningColor
		{
			get
			{
				short num = (short)195035136;
				short num2 = num;
				num = (short)1404114765;
				short num3 = num;
				num = (short)1080039245;
				switch (num3 == num)
				{
				}
				num = (short)1035534336;
				if (num != 0)
				{
				}
				num = (short)509411329;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)2031616000;
				short num2 = num;
				num = (short)1378226848;
				short num3 = num;
				num = (short)653791904;
				switch (num3 == num)
				{
				}
				num = (short)1122369536;
				if (num != 0)
				{
				}
				num = (short)504823809;
				if (num != 0)
				{
				}
				this.f = value;
				base.RaisePropertyChanged<global::System.Windows.Media.Brush>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Media.Brush>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel.get_DatabaseSpaceWarningColor())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000146D0 File Offset: 0x000128D0
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00014780 File Offset: 0x00012980
		public string DatabaseSpaceWarningMsg
		{
			get
			{
				short num = (short)845479936;
				short num2 = num;
				num = (short)990221781;
				short num3 = num;
				num = (short)756651477;
				switch (num3 == num)
				{
				}
				num = (short)1032650753;
				if (num != 0)
				{
				}
				num = (short)1479999488;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1723072512;
				short num2 = num;
				num = (short)799604737;
				if (num != 0)
				{
				}
				num = (short)1894572069;
				short num3 = num;
				num = (short)359915557;
				switch (num3 == num)
				{
				}
				num = (short)1850867712;
				if (num != 0)
				{
				}
				this.g = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel.get_DatabaseSpaceWarningMsg())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00014868 File Offset: 0x00012A68
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0001491C File Offset: 0x00012B1C
		public global::System.Windows.Visibility DatabaseSpaceWarningVisibility
		{
			get
			{
				short num = (short)807665664;
				short num2 = num;
				num = (short)990771732;
				short num3 = num;
				num = (short)885586452;
				switch (num3 == num)
				{
				}
				num = (short)1081016320;
				if (num != 0)
				{
				}
				num = (short)1843986433;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)481492992;
				short num2 = num;
				num = (short)1062465942;
				short num3 = num;
				num = (short)1430253974;
				switch (num3 == num)
				{
				}
				num = (short)1965752321;
				if (num != 0)
				{
				}
				num = (short)1773469696;
				if (num != 0)
				{
				}
				this.h = value;
				base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel.get_DatabaseSpaceWarningVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014A04 File Offset: 0x00012C04
		private void b(string A_0)
		{
			short num = (short)629866496;
			short num2 = num;
			num = (short)840738867;
			short num3 = num;
			num = (short)769173555;
			switch (num3 == num)
			{
			}
			num = (short)1840971777;
			if (num != 0)
			{
			}
			num = (short)1109000192;
			if (num != 0)
			{
			}
			this.Status = A_0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00014AB4 File Offset: 0x00012CB4
		private void a(string A_0)
		{
			short num = (short)1583349760;
			short num2 = num;
			num = (short)634386293;
			short num3 = num;
			num = (short)1759180661;
			switch (num3 == num)
			{
			}
			num = (short)520290304;
			if (num != 0)
			{
			}
			num = (short)619380737;
			if (num != 0)
			{
			}
			this.Information = A_0;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00014B64 File Offset: 0x00012D64
		private void a(global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel A_0)
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				switch (A_0)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel.DatabaseSpaceNormal:
					goto IL_135;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel.DatabaseSpaceWarning:
					goto IL_BC;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel.DatabaseSpaceCritical:
					goto IL_145;
				default:
				{
					num = (short)1886766958;
					short num2 = num;
					num = (short)639092590;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7A;
					}
					goto Block_2;
				}
				}
			}
			Block_2:
			num = (short)365887488;
			short num3 = num;
			IL_7A:
			num = (short)2001010689;
			if (num != 0)
			{
			}
			num = (short)1380450304;
			if (num != 0)
			{
			}
			return;
			IL_BC:
			this.DatabaseSpaceWarningIcon = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뗡藣铥蛧菩苫觭맯釱鯳飵", a_)] as global::System.Windows.Media.Imaging.BitmapImage);
			this.DatabaseSpaceWarningVisibility = global::System.Windows.Visibility.Visible;
			this.DatabaseSpaceWarningMsg = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛡ藣鋥觧裩跫鷭闯틱鯳菵賷\udaf9鏻飽⃿焁瀃椅稇欉欋欍』愑搓眕笗缙㈛㸝挟両䴣䔥䌧਩䐫䬭䈯圱ᐳ倵圷䠹᰻娽┿㙁╃⽅⑇摉", a_);
			this.DatabaseSpaceWarningColor = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.OrangeRed);
			this.c = global::Motorola.CommonCPS.ResourceRepository.Resources.DBSpaceWarningTitle;
			this.d = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛡꛣ뗥飧诩迫语꟯鏱蛳飵釷铹鯻뷽濿氁瀃挅昇縉", a_), null);
			return;
			IL_135:
			this.DatabaseSpaceWarningIcon = null;
			this.DatabaseSpaceWarningVisibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_145:
			this.DatabaseSpaceWarningIcon = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꇡ難迥鳧菩迫迭鳯믱音駵雷", a_)] as global::System.Windows.Media.Imaging.BitmapImage);
			this.DatabaseSpaceWarningVisibility = global::System.Windows.Visibility.Visible;
			this.DatabaseSpaceWarningMsg = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛡ藣鋥觧裩跫鷭闯틱蟳苵韷裹鷻駽旿∁眃瘅椇椉椋⸍礏愑㐓眕気㨙缛氝䤟嘡䴣䔥䤧䘩ఫ䈭唯䐱儳娵ᘷᨹ缻刽⤿⅁⽃晅⁇⽉㹋⭍灏㑑㭓⑕硗㹙㥛⩝şୡࡣ䡥", a_);
			this.DatabaseSpaceWarningColor = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Red);
			this.c = global::Motorola.CommonCPS.ResourceRepository.Resources.DBSpaceCriticalTitle;
			this.d = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛡꛣ뗥飧诩迫语돯胱鷳苵釷駹鷻鋽䏿洁樃爅洇搉砋", a_), null);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014D30 File Offset: 0x00012F30
		internal void a()
		{
			short num = (short)1014693888;
			short num2 = num;
			num = (short)1877842600;
			short num3 = num;
			num = (short)1130732200;
			switch (num3 == num)
			{
			}
			num = (short)472317953;
			if (num != 0)
			{
			}
			num = (short)672792576;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(this.d, this.c);
		}

		// Token: 0x040000D5 RID: 213
		private string a;

		// Token: 0x040000D6 RID: 214
		private string b;

		// Token: 0x040000D7 RID: 215
		private string c;

		// Token: 0x040000D8 RID: 216
		private string d;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Media.Imaging.BitmapImage e;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Media.Brush f;

		// Token: 0x040000DB RID: 219
		private string g;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Visibility h;
	}
}
