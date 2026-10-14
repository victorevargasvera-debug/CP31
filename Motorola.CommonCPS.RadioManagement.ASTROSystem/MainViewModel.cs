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

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200001E RID: 30
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption>
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000C988 File Offset: 0x0000AB88
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 4;
			this.a = true;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("힕쮗캙캛톝\udba1힣튥춧잩", a_));
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000CA98 File Offset: 0x0000AC98
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)793312610;
				short num2 = num;
				num = (short)1441122;
				switch (num2 == num)
				{
				}
				num = (short)1618345985;
				if (num != 0)
				{
				}
				num = (short)113311744;
				short num3 = num;
				num = (short)948174848;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1763475317;
				short num2 = num;
				num = (short)983072629;
				switch (num2 == num)
				{
				}
				num = (short)769589249;
				if (num != 0)
				{
				}
				num = (short)1291517952;
				short num3 = num;
				num = (short)1777532928;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000CB48 File Offset: 0x0000AD48
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		public bool FilterOptionVisible
		{
			get
			{
				short num = (short)1031258585;
				short num2 = num;
				num = (short)605012441;
				switch (num2 == num)
				{
				}
				num = (short)70320128;
				if (num != 0)
				{
				}
				num = (short)2067857408;
				short num3 = num;
				num = (short)1224671233;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)211943424;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_15;
					case 1:
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.MainViewModel.get_FilterOptionVisible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)268173314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1146708515;
						short num3 = num;
						num = (short)116482595;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							goto IL_102;
						}
						break;
					}
					}
					goto IL_59;
					IL_15:
					num = (short)1512046592;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_59:
						if (this.a == value)
						{
							return;
						}
						num = (short)1146880001;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_102:
				num = (short)1046937601;
				if (num != 0)
				{
				}
				num = (short)1413611520;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000CD44 File Offset: 0x0000AF44
		private void b()
		{
			short num = (short)1488715777;
			if (num != 0)
			{
			}
			num = (short)1420698968;
			short num2 = num;
			num = (short)1419912536;
			switch (num2 == num)
			{
			}
			num = (short)1066336256;
			short num3 = num;
			num = (short)943652864;
			if (num != 0)
			{
			}
			this.a();
			this.LoadData();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		protected override string GetMainViewName()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption filterOption;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					switch (filterOption)
					{
					case global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.All:
					{
						num2 = (short)1758773410;
						short num3 = num2;
						num2 = (short)1839710370;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_69;
						default:
							goto IL_B2;
						}
						break;
					}
					case global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Radios:
						goto IL_6E;
					case global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Systems:
						goto IL_13F;
					default:
						num2 = (short)1278607361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 1:
					goto IL_69;
				case 2:
					goto IL_114;
				}
				goto IL_25;
				IL_69:
				num2 = (short)292028418;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_6E:
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("瘝좨쾪쒬삮슰\udcb4튶캸", a_);
			IL_B2:
			num2 = (short)1753022464;
			if (num2 != 0)
			{
			}
			num2 = (short)1351352321;
			if (num2 != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쒤쎦삨쒪ﺬ횮슰잲킴\udab6쪸풼\udabe뛀", a_);
			IL_114:
			num2 = (short)1946812416;
			short num4 = num2;
			return string.Empty;
			IL_13F:
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udca4풦\udda8캪사\udcae\udab2킴삶", a_);
			IL_25:
			filterOption = base.FilterOption;
			num2 = (short)502267904;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000CF5C File Offset: 0x0000B15C
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption filterOption)
		{
			int a_ = 8;
			short num = (short)711327746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("즙풟잡즣향ﺧ쎩즫\ud9ad", a_)))
					{
						num = (short)917831680;
						short num3 = num;
						num = (short)1444085764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 1:
					goto IL_101;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 3:
					goto IL_FF;
				case 4:
				{
					num = (short)1140845116;
					short num4 = num;
					num = (short)1206315580;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)1729822721;
						if (num != 0)
						{
						}
						num = (short)834863104;
						if (num != 0)
						{
						}
						num = (short)2123431939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_42:
				if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("즙쎛첝솟욡춣즥\udba7ﲩ얫쮭잯", a_)))
				{
					num = (short)1017184257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_101:
				num = (short)390791168;
				num2 = (int)((global::System.IntPtr)num);
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Radios;
			return true;
			IL_FF:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.All;
			return true;
			IL_173:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Systems;
			return true;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		protected override string GetNavigationParameterName()
		{
			int a_ = 12;
			short num = (short)314722034;
			short num2 = num;
			num = (short)1303070450;
			switch (num2 == num)
			{
			}
			num = (short)500301824;
			if (num != 0)
			{
			}
			num = (short)442105856;
			short num3 = num;
			num = (short)1555890177;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ud99d튟춡톣횥", a_);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		protected override void OnNavigateToViewRequested(string viewString)
		{
			int a_ = 13;
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
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦直튪\udeac\udbae풰\udeb2운킸\udeba쪼", a_)))
					{
						goto IL_1D4;
					}
					goto IL_98;
				}
				case 2:
				{
					num2 = (short)1935147009;
					if (num2 != 0)
					{
					}
					num2 = (short)1784807424;
					short num3 = num2;
					num2 = (short)1187119113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				case 4:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞\ud8a0킢톤슦쒨\ud8aaﮬ욮풰쒲", a_)))
					{
						num2 = (short)606208011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_133;
				}
				case 5:
					return;
				case 6:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != base.MainModuleName)
					{
						num2 = (short)716308480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)439877640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞ﺠ쒤쎦삨쒪쪮얰튲\udcb4\udbb6쪸풼\udabe뛀", a_)))
					{
						num2 = (short)1791557644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F1;
				}
				case 8:
				{
					if (string.IsNullOrEmpty(viewString))
					{
						num2 = (short)1778712579;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text = viewString.Split(new char[]
					{
						'?'
					})[0];
					num2 = (short)517341185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞ﺠ쒤쎦삨쒪\udeac瑩\ud8b0횲슴", a_)))
					{
						num2 = (short)1569718285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_217;
				}
				case 10:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞\ud8a0킢톤슦쒨좬\udbae킰\udab2\ud9b4쒶튺\ud8bc좾", a_)))
					{
						num2 = (short)305332229;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_334;
				}
				case 11:
					num2 = (short)1577713674;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)850329604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					num2 = (short)2101235362;
					short num4 = num2;
					num2 = (short)130764450;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D4;
					default:
						num2 = (short)144703488;
						if (num2 != 0)
						{
						}
						num2 = (short)1940324359;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_51;
				IL_1D4:
				num2 = (short)3211266;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_98:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.All;
			return;
			IL_F1:
			this.FilterOptionVisible = false;
			return;
			IL_133:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Systems;
			return;
			IL_217:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Radios;
			return;
			IL_334:
			this.FilterOptionVisible = false;
			return;
			IL_51:
			base.OnNavigateToViewRequested(viewString);
			num2 = (short)1045626886;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		private void a(object A_0)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				num = (short)70778880;
				short num2 = num;
				if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﮨﺬ횮슰잲킴\udab6", a_)))
				{
					goto IL_C3;
				}
				num = (short)2103690157;
				short num3 = num;
				num = (short)995804077;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			IL_87:
			num = (short)1720254465;
			if (num != 0)
			{
			}
			num = (short)2119827456;
			if (num != 0)
			{
			}
			return;
			IL_C3:
			this.a();
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.All;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		private void a()
		{
			short num = (short)824995108;
			short num2 = num;
			num = (short)1435266340;
			switch (num2 == num)
			{
			}
			num = (short)1991180289;
			if (num != 0)
			{
			}
			num = (short)369885184;
			short num3 = num;
			num = (short)358416384;
			if (num != 0)
			{
			}
			base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			base.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)738525186;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
					{
						num = (short)611647488;
						short num3 = num;
						num = (short)989724676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77;
				case 1:
					goto IL_108;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
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
					goto IL_77;
				case 4:
					return;
				}
				IL_38:
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					num = (short)386859009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_77:
				num = (short)1236636998;
				short num4 = num;
				num = (short)1419613510;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_108:
					num = (short)959774720;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1062666241;
					if (num != 0)
					{
					}
					num = (short)718340096;
					if (num != 0)
					{
					}
					num = (short)1908015107;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x04000053 RID: 83
		private bool a;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
