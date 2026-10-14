using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000010 RID: 16
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<global::Motorola.CommonCPS.RadioManagement.Job.FilterOption>
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000054E0 File Offset: 0x000036E0
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 18;
			this.a = true;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("校䬣䐥", a_));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ResetOptionFilterForJobViewEvent>().Subscribe(new global::System.Action<bool>(this.a));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005544 File Offset: 0x00003744
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000055F4 File Offset: 0x000037F4
		public bool IsOptionFilterVisible
		{
			get
			{
				short num = (short)1466236928;
				short num2 = num;
				num = (short)445160795;
				short num3 = num;
				num = (short)712351067;
				switch (num3 == num)
				{
				}
				num = (short)179437569;
				if (num != 0)
				{
				}
				num = (short)1767899136;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)790953985;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Job.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Job.MainViewModel.get_IsOptionFilterVisible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)778240002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						num = (short)283836417;
						if (num != 0)
						{
						}
						goto IL_CF;
					}
					IL_30:
					if (value != this.a)
					{
						num = (short)670629888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					num = (short)1484455936;
					short num3 = num;
					num = (short)589005810;
					short num4 = num;
					num = (short)1231193074;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_130;
					}
				}
				IL_130:
				num = (short)1449394176;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005748 File Offset: 0x00003948
		private void a(object A_0)
		{
			int a_ = 10;
			short num = (short)1066048776;
			short num2 = num;
			num = (short)1490853128;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1389887489;
				if (num != 0)
				{
				}
				num = (short)1080557568;
				if (num != 0)
				{
				}
				num = (short)916848640;
				short num3 = num;
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("候猛簝", a_))
				{
					return;
				}
				break;
			}
			}
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.All;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005820 File Offset: 0x00003A20
		private void a(bool A_0)
		{
			short num = (short)360579072;
			short num2 = num;
			num = (short)934319983;
			short num3 = num;
			num = (short)953849711;
			switch (num3 == num)
			{
			}
			num = (short)390332417;
			if (num != 0)
			{
			}
			num = (short)1232207872;
			if (num != 0)
			{
			}
			this.IsOptionFilterVisible = A_0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000058D4 File Offset: 0x00003AD4
		protected override void LoadData()
		{
			int a_ = 0;
			short num = (short)432078848;
			short num2 = num;
			num = (short)968294916;
			short num3 = num;
			num = (short)757531140;
			switch (num3 == num)
			{
			}
			num = (short)1318649856;
			if (num != 0)
			{
			}
			num = (short)144048129;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(this.GetMainViewName(), new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("嘏笑砓戕紗栙匛渝吟䬡䬣䠥ᔧ", a_) + base.FilterOption.ToString()
			});
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000059C4 File Offset: 0x00003BC4
		protected override string GetMainViewName()
		{
			int a_ = 1;
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Job.FilterOption filterOption;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)721767012;
						short num3 = num2;
						num2 = (short)195578468;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2C;
						default:
							num2 = (short)872349697;
							if (num2 != 0)
							{
							}
							num2 = (short)1647116288;
							if (num2 != 0)
							{
							}
							num2 = (short)1070596098;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						switch (filterOption)
						{
						case global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.All:
							goto IL_EA;
						case global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Operational:
							goto IL_DB;
						case global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Programming:
							goto IL_13F;
						default:
							num2 = (short)1472659456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					case 2:
						goto IL_13D;
					}
					goto IL_25;
				}
				IL_DB:
				return global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("帐挒瀔攖砘漚琜瀞传䈢䤤洦䘨䤪帬", a_);
				IL_EA:
				num2 = (short)94633984;
				short num4 = num2;
				return global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("嬐簒眔搖优爚砜栞", a_);
				IL_13D:
				return string.Empty;
				IL_13F:
				return global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䄐愒稔瀖欘稚瀜爞䠠䴢䈤洦䘨䤪帬", a_);
			}
			}
			IL_25:
			filterOption = base.FilterOption;
			IL_2C:
			num2 = (short)64684033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005B24 File Offset: 0x00003D24
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out global::Motorola.CommonCPS.RadioManagement.Job.FilterOption filterOption)
		{
			int a_ = 5;
			short num = (short)1002635264;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_43;
					}
					continue;
				case 1:
					goto IL_89;
				case 2:
					num = (short)8388609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)842399748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					if (mainViewId == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䔔攖瘘簚漜縞䰠丢䰤䤦丨愪䈬䴮䈰", a_))
					{
						goto IL_148;
					}
					num = (short)1528457639;
					short num3 = num;
					num = (short)277572007;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num = (short)1034092544;
						if (num != 0)
						{
						}
						num = (short)972881921;
						if (num != 0)
						{
						}
						num = (short)1547894786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_43:
				if (mainViewId == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("娔朖簘椚簜欞䠠䰢䬤䘦䔨愪䈬䴮䈰", a_))
				{
					break;
				}
				num = (short)1305608195;
				num2 = (int)((global::System.IntPtr)num);
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Operational;
			return true;
			IL_89:
			goto IL_14D;
			IL_148:
			filterOption = global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Programming;
			return true;
			IL_14D:
			num = (short)441384960;
			short num4 = num;
			filterOption = global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.All;
			return true;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005CAC File Offset: 0x00003EAC
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1858666496;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)687704243;
					short num3 = num;
					num = (short)906725555;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1195442176;
						if (num != 0)
						{
						}
						num = (short)1773469699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
					{
						num = (short)1152581633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
				}
				IL_34:
				num = (short)1500774401;
				if (num != 0)
				{
				}
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					goto IL_12C;
				}
				num = (short)813694976;
				short num4 = num;
				num = (short)1312096258;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_12C:
			base.OnNavigatedTo(navigationContext);
			this.LoadData();
		}

		// Token: 0x04000022 RID: 34
		private bool a;
	}
}
