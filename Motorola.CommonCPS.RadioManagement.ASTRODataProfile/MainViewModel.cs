using System;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200001C RID: 28
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption>
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00008B1C File Offset: 0x00006D1C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 9;
			this.a = true;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﮧﺩﺫ펱삳ힵ좹펻\ud8bdꦿ껁ꇃ", a_));
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00008B80 File Offset: 0x00006D80
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00008C30 File Offset: 0x00006E30
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1245380609;
				if (num != 0)
				{
				}
				num = (short)227524708;
				short num2 = num;
				num = (short)307019876;
				switch (num2 == num)
				{
				}
				num = (short)895746048;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)630038452;
				short num2 = num;
				num = (short)1827839924;
				switch (num2 == num)
				{
				}
				num = (short)1099956225;
				if (num != 0)
				{
				}
				num = (short)1469513728;
				if (num != 0)
				{
				}
				num = (short)687538176;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008CE0 File Offset: 0x00006EE0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00008D90 File Offset: 0x00006F90
		public bool FilterOptionVisible
		{
			get
			{
				short num = (short)1674675377;
				short num2 = num;
				num = (short)1479705777;
				switch (num2 == num)
				{
				}
				num = (short)26738689;
				if (num != 0)
				{
				}
				num = (short)938868736;
				if (num != 0)
				{
				}
				num = (short)1977548800;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)607322113;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							num = (short)1873001279;
							short num3 = num;
							num = (short)1103739711;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_86;
							}
						}
						IL_86:
						num = (short)1127809025;
						if (num != 0)
						{
						}
						num = (short)969670656;
						if (num != 0)
						{
						}
						num = (short)509935616;
						short num4 = num;
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.MainViewModel.get_FilterOptionVisible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1214578690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					if (this.a == value)
					{
						break;
					}
					num = (short)2034958336;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00008EE4 File Offset: 0x000070E4
		private void b()
		{
			short num = (short)642430310;
			short num2 = num;
			num = (short)1947776358;
			switch (num2 == num)
			{
			}
			num = (short)1605828609;
			if (num != 0)
			{
			}
			num = (short)459472896;
			if (num != 0)
			{
			}
			num = (short)2097152;
			short num3 = num;
			this.a();
			this.LoadData();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008F98 File Offset: 0x00007198
		protected override string GetMainViewName()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption filterOption;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)436862978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					switch (filterOption)
					{
					case global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.All:
						goto IL_A2;
					case global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.DataProfiles:
						goto IL_93;
					case global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.Radios:
						goto IL_13D;
					default:
					{
						num2 = (short)49741824;
						short num3 = num2;
						num2 = (short)1078198272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				case 2:
					goto IL_13B;
				}
				goto IL_25;
			}
			IL_93:
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("톯욱햳쪷햹\udabbힽ겿ꟁ럃郅ꇇ꿉믋", a_);
			IL_A2:
			num2 = (short)1679884289;
			if (num2 != 0)
			{
			}
			num2 = (short)993180669;
			short num4 = num2;
			num2 = (short)426687485;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14C:
				return string.Empty;
			default:
				num2 = (short)1771765760;
				if (num2 != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﲭ톯횱\uddb3\ud9b5ﲷ\udbb9좻\udfbd邿냁ꯃꃅꇇꛉ꧋뷍蛏믑뇓ꇕ", a_);
			}
			IL_13B:
			goto IL_14C;
			IL_13D:
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ힵ\udcb7펹펻춽隿ꯁꇃ뇅", a_);
			IL_25:
			filterOption = base.FilterOption;
			num2 = (short)390397953;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000090F8 File Offset: 0x000072F8
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption filterOption)
		{
			int a_ = 8;
			short num = (short)516227074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)467776987;
				short num3 = num;
				num = (short)1652078043;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15A;
				case 1:
					break;
				default:
				{
					num = (short)361234432;
					short num4 = num;
					break;
				}
				}
				num = (short)1683357696;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1336344577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_12A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					continue;
				case 3:
					num = (short)1988034564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("욦\udda8쪪ﶬ\uddae\udeb0햲\udcb4\udbb6\udcb8좺횾꓀듂", a_)))
					{
						goto IL_15A;
					}
					goto IL_173;
				}
				IL_B7:
				num = (short)1159921665;
				if (num != 0)
				{
				}
				if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("寧첬쮮\ud8b0\udcb2운킸\udeba쪼", a_)))
				{
					num = (short)164888579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_15A:
				num = (short)127336448;
				num2 = (int)((global::System.IntPtr)num);
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.Radios;
			return true;
			IL_12A:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.All;
			return true;
			IL_173:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.DataProfiles;
			return true;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009284 File Offset: 0x00007484
		protected override string GetNavigationParameterName()
		{
			int a_ = 13;
			short num = (short)865270904;
			short num2 = num;
			num = (short)1187052664;
			switch (num2 == num)
			{
			}
			num = (short)58130433;
			if (num != 0)
			{
			}
			num = (short)1399455744;
			if (num != 0)
			{
			}
			num = (short)312213504;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udeab솭얯슱ﶳ", a_);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009344 File Offset: 0x00007544
		protected override void OnNavigateToViewRequested(string viewString)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					goto IL_2BC;
				case 1:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("睊ﲭ톯횱\uddb3\ud9b5쮷햻\udbbd랿", a_)))
					{
						num2 = (short)1281622018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_295;
				case 2:
				{
					num2 = (short)1902058483;
					short num3 = num2;
					num2 = (short)1102191603;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BC;
					default:
						num2 = (short)1116209153;
						if (num2 != 0)
						{
						}
						num2 = (short)1923612672;
						if (num2 != 0)
						{
						}
						num2 = (short)1576206344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					return;
				case 5:
					num2 = (short)583139337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("盛쮩좫잭\udfaf햳습\ud9b7캻톽ꚿꯁꣃꏅ믇鳉ꗋꯍ꟏", a_)))
					{
						num2 = (short)1068367885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9F;
				case 7:
					if (string.IsNullOrEmpty(viewString))
					{
						num2 = (short)348782595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = viewString.Split(new char[]
					{
						'?'
					})[0];
					num2 = (short)389545990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("睊ﲭ톯횱\uddb3\ud9b5ﲷ\udfb9좻\udfbdꦿ껁럃郅ꇇ꿉믋", a_)))
					{
						num2 = (short)415498245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F9;
				case 9:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쮩\ud8ab쾭삱\udbb3킵톷횹\ud9bb춽隿ꯁꇃ뇅", a_)))
					{
						num2 = (short)285802508;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 10:
					return;
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != base.MainModuleName)
					{
						num2 = (short)888078346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)684130311;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)1493762048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					num2 = (short)1517944832;
					short num4 = num2;
					num2 = (short)209780737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_51;
				IL_2BC:
				if (text == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쮩\ud8ab쾭삱\udbb3킵톷횹\ud9bb諾ꖿ뛁ꗃ꿅꓇막髋ꟍ뗏ꗑ", a_))
				{
					goto IL_33C;
				}
				num2 = (short)558628868;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_9F:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.All;
			return;
			IL_F9:
			this.FilterOptionVisible = false;
			return;
			IL_13F:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.DataProfiles;
			return;
			IL_295:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.Radios;
			return;
			IL_33C:
			this.FilterOptionVisible = false;
			return;
			IL_51:
			base.OnNavigateToViewRequested(viewString);
			num2 = (short)201785355;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009694 File Offset: 0x00007894
		private void a(object A_0)
		{
			int a_ = 14;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺬﮮﲲ횶춸\udaba춾껀ꗂ계ꯆ곈", a_))
			{
				short num = (short)562018097;
				short num2 = num;
				num = (short)1029617457;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)10354689;
					if (num != 0)
					{
					}
					num = (short)1288765440;
					short num3 = num;
					num = (short)1984036864;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.a();
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.All;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009774 File Offset: 0x00007974
		private void a()
		{
			short num = (short)355728338;
			short num2 = num;
			num = (short)998898642;
			switch (num2 == num)
			{
			}
			num = (short)2051932160;
			if (num != 0)
			{
			}
			num = (short)1667563521;
			if (num != 0)
			{
			}
			num = (short)1414594560;
			short num3 = num;
			base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			base.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009854 File Offset: 0x00007A54
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1036713986;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1184643036;
				short num3 = num;
				num = (short)289683420;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14A;
				case 1:
					break;
				default:
				{
					num = (short)1383792640;
					short num4 = num;
					break;
				}
				}
				num = (short)534052865;
				if (num != 0)
				{
				}
				num = (short)1983447040;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					try
					{
						this.a();
						base.OnNavigatedTo(navigationContext);
						return;
					}
					catch (global::System.Exception exception)
					{
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
						return;
					}
					goto IL_112;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D7;
					}
					continue;
				case 3:
					num = (short)413466628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
					{
						goto IL_14A;
					}
					goto IL_112;
				}
				IL_D7:
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					num = (short)249888771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_112:
				num = (short)1912799233;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)166395904;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000039 RID: 57
		private bool a;

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
