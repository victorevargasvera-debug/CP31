using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x0200000D RID: 13
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption>
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000067E0 File Offset: 0x000049E0
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 2;
			this.c = true;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("琥䤧丩䔫䄭簯嬱圳匵嘷䤹夻", a_));
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			this.ShowRegistRadioLicenseDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel>();
			this.ShowSelectASKForCFSDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel>();
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRegisterRadioLicenseDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectASKForCFSDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006898 File Offset: 0x00004A98
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00006948 File Offset: 0x00004B48
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1150061287;
				short num2 = num;
				num = (short)1823836903;
				switch (num2 == num)
				{
				}
				num = (short)1883373568;
				short num3 = num;
				num = (short)1952579585;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)62408656;
				short num2 = num;
				num = (short)1622296528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)425328640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689452545;
				if (num != 0)
				{
				}
				num = (short)157417472;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000069FC File Offset: 0x00004BFC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00006AAC File Offset: 0x00004CAC
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel> ShowRegistRadioLicenseDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1512941031;
				short num2 = num;
				num = (short)819570151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039480320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753270785;
				if (num != 0)
				{
				}
				num = (short)586809344;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1329425438;
				short num2 = num;
				num = (short)1214868510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)371982336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1952776193;
				if (num != 0)
				{
				}
				num = (short)871497728;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00006B60 File Offset: 0x00004D60
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00006C10 File Offset: 0x00004E10
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel> ShowSelectASKForCFSDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1208563984;
				short num2 = num;
				num = (short)1118779664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1821048832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1578237952;
				if (num != 0)
				{
				}
				num = (short)1922891777;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1863516161;
				if (num != 0)
				{
				}
				num = (short)1622802432;
				short num2 = num;
				num = (short)1104747879;
				short num3 = num;
				num = (short)1982930279;
				switch (num3 == num)
				{
				}
				num = (short)1876819968;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006CC0 File Offset: 0x00004EC0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string rmc_Title_RegisterRadioLicense;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1317507394;
					short num3 = num2;
					num2 = (short)889360706;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_D7;
					}
					break;
				}
				case 1:
				{
					rmc_Title_RegisterRadioLicense = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_RegisterRadioLicense;
					num2 = (short)240910336;
					short num4 = num2;
					num2 = (short)414646272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (this.f == 1)
					{
						num2 = (short)687472641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				}
				goto IL_1C;
			}
			IL_D7:
			num2 = (short)1346699264;
			if (num2 != 0)
			{
			}
			num2 = (short)1459224577;
			if (num2 != 0)
			{
			}
			IL_116:
			this.ShowRegistRadioLicenseDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0, this.f)
			{
				Title = rmc_Title_RegisterRadioLicense
			});
			return;
			IL_1C:
			rmc_Title_RegisterRadioLicense = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_RegisterRadioLicense;
			num2 = (short)322830338;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006E14 File Offset: 0x00005014
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext A_0)
		{
			short num = (short)1250135663;
			short num2 = num;
			num = (short)95981167;
			switch (num2 == num)
			{
			default:
			{
				num = (short)533200896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1203109889;
			if (num != 0)
			{
			}
			num = (short)98631680;
			if (num != 0)
			{
			}
			this.ShowSelectASKForCFSDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectASK
			});
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006EE8 File Offset: 0x000050E8
		private void a(int ftype)
		{
			short num = (short)746782721;
			if (num != 0)
			{
			}
			num = (short)357302272;
			short num2 = num;
			num = (short)1202202951;
			short num3 = num;
			num = (short)368650567;
			switch (num3 == num)
			{
			}
			num = (short)527237120;
			if (num != 0)
			{
			}
			this.f = ftype;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00006F98 File Offset: 0x00005198
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00007044 File Offset: 0x00005244
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Groups
		{
			get
			{
				short num = (short)793919286;
				short num2 = num;
				num = (short)593510198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1953759232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850198529;
				if (num != 0)
				{
				}
				num = (short)1943142400;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1221328898;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_116;
					case 1:
						for (;;)
						{
							num = (short)894038332;
							short num3 = num;
							num = (short)1215754556;
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
						num = (short)2091909120;
						if (num != 0)
						{
						}
						this.a = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel.get_Groups())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1526267905;
						if (num != 0)
						{
						}
						num = (short)1006239744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (value == this.a)
					{
						return;
					}
					num = (short)412549121;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_116:
				num = (short)364642304;
				short num4 = num;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00007194 File Offset: 0x00005394
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00007248 File Offset: 0x00005448
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group SelectedGroup
		{
			get
			{
				short num = (short)357613743;
				short num2 = num;
				num = (short)1040564399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1993932800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333133313;
				if (num != 0)
				{
				}
				num = (short)1984954368;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1247870978;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12B;
					case 1:
						for (;;)
						{
							num = (short)1707712930;
							short num3 = num;
							num = (short)532193698;
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
						num = (short)2138177536;
						if (num != 0)
						{
						}
						num = (short)306380801;
						if (num != 0)
						{
						}
						this.b = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel.get_SelectedGroup())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.SaveLastSelectedItemSetting<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(this.b);
						num = (short)477560832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (value == this.b)
					{
						return;
					}
					num = (short)2104950785;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12B:
				num = (short)1812267008;
				short num4 = num;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000073AC File Offset: 0x000055AC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000745C File Offset: 0x0000565C
		public bool FilterOptionVisible
		{
			get
			{
				short num = (short)453326520;
				short num2 = num;
				num = (short)947730104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)938803200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)901251073;
				if (num != 0)
				{
				}
				num = (short)197853184;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1642659842;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11B;
					case 1:
						for (;;)
						{
							num = (short)2074353580;
							short num3 = num;
							num = (short)1503207340;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_88;
							}
						}
						IL_88:
						num = (short)941096960;
						if (num != 0)
						{
						}
						this.c = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel.get_FilterOptionVisible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1198915585;
						if (num != 0)
						{
						}
						num = (short)1772093440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (this.c == value)
					{
						return;
					}
					num = (short)373227521;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)231407616;
				short num4 = num;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000075B0 File Offset: 0x000057B0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000765C File Offset: 0x0000585C
		public bool IsSelectedNavigationItemLocked
		{
			get
			{
				short num = (short)959119361;
				if (num != 0)
				{
				}
				num = (short)1955594240;
				short num2 = num;
				num = (short)1829271262;
				short num3 = num;
				num = (short)190543582;
				switch (num3 == num)
				{
				}
				num = (short)2008088576;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1057619970;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_117;
					case 1:
						for (;;)
						{
							num = (short)1183842305;
							if (num != 0)
							{
							}
							num = (short)269550142;
							short num3 = num;
							num = (short)636355134;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_B0;
							}
						}
						IL_B0:
						num = (short)1915092992;
						if (num != 0)
						{
						}
						this.d = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel.get_IsSelectedNavigationItemLocked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1928331264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (this.d == value)
					{
						return;
					}
					num = (short)1736704001;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				num = (short)1438842880;
				short num4 = num;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000077AC File Offset: 0x000059AC
		private void b()
		{
			short num = (short)751307425;
			short num2 = num;
			num = (short)1662847649;
			switch (num2 == num)
			{
			default:
			{
				num = (short)44171264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1885601793;
			if (num != 0)
			{
			}
			num = (short)797966336;
			if (num != 0)
			{
			}
			this.a();
			this.LoadData();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007864 File Offset: 0x00005A64
		protected override void LoadData()
		{
			int a_ = 11;
			short num = (short)694444181;
			short num2 = num;
			num = (short)1996972181;
			switch (num2 == num)
			{
			default:
			{
				num = (short)698548224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1113260033;
			if (num != 0)
			{
			}
			num = (short)1397096448;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(this.GetMainViewName(), new global::System.Collections.Generic.List<string>
			{
				string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("吮İ串࠴䰶࠸䘺", a_), global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("栮䌰尲䀴䜶瀸缺", a_), (this.b == null) ? null : this.b.ID)
			});
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000797C File Offset: 0x00005B7C
		protected override string GetMainViewName()
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_119;
				case 1:
					num2 = (short)714080256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B7;
				}
				goto IL_25;
			}
			IL_B7:
			global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption filterOption;
			switch (filterOption)
			{
			case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All:
				return global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫戭夯儱儳堵䬷弹伻栽⤿❁㍃", a_);
			case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Features:
			{
				num2 = (short)1927282688;
				short num3 = num2;
				return global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫栭唯匱䀳䌵䨷弹伻栽⤿❁㍃", a_);
			}
			case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Radios:
				return global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫簭儯嘱崳夵䬷氹唻嬽㜿", a_);
			default:
			{
				IL_C9:
				num2 = (short)1140129793;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			IL_119:
			return string.Empty;
			IL_25:
			num2 = (short)1714683905;
			if (num2 != 0)
			{
			}
			filterOption = base.FilterOption;
			num2 = (short)1547713975;
			short num4 = num2;
			num2 = (short)1498496439;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C9;
			default:
			{
				num2 = (short)1855455232;
				if (num2 != 0)
				{
				}
				num2 = (short)1889075202;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007AE4 File Offset: 0x00005CE4
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption filterOption)
		{
			int a_ = 18;
			short num = (short)1437401092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_94;
				case 1:
				{
					num = (short)1510042836;
					short num3 = num;
					num = (short)1457810644;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_94;
					default:
						goto IL_E7;
					}
					break;
				}
				case 2:
					num = (short)1568407553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("搵琷改稻嬽ℿ㙁ㅃ㑅ⵇ㥉ᩋ❍㕏║", a_)))
					{
						num = (short)1146159106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				num = (short)837025793;
				if (num != 0)
				{
				}
				if (!(mainViewId == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("搵琷改渻弽␿⭁⭃㕅ṇ⍉⥋㥍", a_)))
				{
					num = (short)828768256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_94:
				num = (short)243662851;
				num2 = (int)((global::System.IntPtr)num);
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Radios;
			return true;
			IL_E7:
			num = (short)268500992;
			if (num != 0)
			{
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All;
			return true;
			IL_148:
			num = (short)1134166016;
			short num4 = num;
			filterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Features;
			return true;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007C6C File Offset: 0x00005E6C
		protected override void OnNavigateToViewRequested(string viewString)
		{
			int a_ = 0;
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
					if (!(text == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧砩䴫䨭夯崱䜳怵儷弹䬻", a_)))
					{
						num2 = (short)288882691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_288;
				case 1:
				{
					if (!string.IsNullOrEmpty(viewString))
					{
						text = viewString.Split(new char[]
						{
							'?'
						})[0];
						num2 = (short)1243414537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)488542423;
					short num3 = num2;
					num2 = (short)1441173719;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B6;
					default:
						num2 = (short)1671495680;
						if (num2 != 0)
						{
						}
						num2 = (short)1137508358;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)1663172608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)279838720;
					short num4 = num2;
					num2 = (short)1931411464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)421396492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1459617802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					return;
				case 8:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧砩䴫䨭夯崱䜳爵崷丹崻圽ⰿㅁቃ⽅ⵇ㵉", a_)))
					{
						num2 = (short)805699589;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12E;
				case 9:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧昩䔫䴭唯就䜳匵䬷氹唻嬽㜿", a_)))
					{
						num2 = (short)128253954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C9;
				case 10:
					if (!(text == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧氩䤫伭䐯䜱䘳匵䬷氹唻嬽㜿", a_)))
					{
						num2 = (short)333250564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != base.MainModuleName)
					{
						num2 = (short)523501581;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1566048257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_2B6;
				case 13:
					return;
				}
				goto IL_51;
				IL_2B6:
				if (text == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧氩䤫伭䐯䜱䘳匵䬷縹夻䨽ℿ⭁⡃㕅ṇ⍉⥋㥍", a_))
				{
					goto IL_365;
				}
				num2 = (short)1758658567;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_C9:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All;
			this.IsSelectedNavigationItemLocked = false;
			return;
			IL_12E:
			this.FilterOptionVisible = false;
			this.IsSelectedNavigationItemLocked = true;
			return;
			IL_1C9:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Features;
			this.IsSelectedNavigationItemLocked = false;
			return;
			IL_288:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Radios;
			this.IsSelectedNavigationItemLocked = false;
			return;
			IL_365:
			this.FilterOptionVisible = false;
			this.IsSelectedNavigationItemLocked = true;
			return;
			IL_51:
			base.OnNavigateToViewRequested(viewString);
			num2 = (short)2080768001;
			if (num2 != 0)
			{
			}
			num2 = (short)652541963;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007FEC File Offset: 0x000061EC
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)786300929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_256;
				case 2:
					return;
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption filterOption;
					switch (filterOption)
					{
					case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All:
						this.a(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫戭夯儱儳堵䬷弹伻栽⤿❁㍃", a_));
						num2 = (short)939720713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Features:
						this.a(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫栭唯匱䀳䌵䨷弹伻栽⤿❁㍃", a_));
						num2 = (short)284033030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Radios:
						this.a(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("稧昩猫簭儯嘱崳夵䬷氹唻嬽㜿", a_));
						num2 = (short)1936982023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)254935040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption filterOption = base.FilterOption;
					num2 = (short)945553411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("渧䌩䀫娭唯䀱笳䘵䰷匹医倽", a_)))
					{
						goto IL_10B;
					}
					goto IL_292;
				case 6:
					goto IL_256;
				case 7:
					goto IL_256;
				case 8:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("笧伩䀫䬭匯䘱儳刵缷䠹医䬽〿", a_))
					{
						num2 = (short)1382481930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
				{
					num2 = (short)1947250314;
					short num3 = num2;
					num2 = (short)1518841482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						num2 = (short)1325858816;
						if (num2 != 0)
						{
						}
						goto IL_256;
					}
					break;
				}
				case 10:
					num2 = (short)582418433;
					if (num2 != 0)
					{
					}
					goto IL_292;
				case 11:
					if (!this.e)
					{
						num2 = (short)1684537348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 12:
					num2 = (short)2089746440;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("笧伩䀫䬭匯䘱儳刵缷䠹医䬽〿", a_))
					{
						num2 = (short)1900609536;
						short num4 = num2;
						num2 = (short)550436879;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 14:
					goto IL_D6;
				case 15:
					num2 = (short)270991371;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_59;
				IL_D6:
				num2 = (short)1453916165;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10B:
				num2 = (short)579731468;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_256:
				base.CommandProxy.PrintViewCommand.RaiseCanExecuteChanged();
				base.CommandProxy.PrintViewPreviewCommand.RaiseCanExecuteChanged();
				num2 = (short)248053774;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_292:
				base.CommandProxy.PrintViewCommand.RaiseCanExecuteChanged();
				base.CommandProxy.PrintViewPreviewCommand.RaiseCanExecuteChanged();
				num2 = (short)810942466;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_59:
			base.OnPropertyChanged(sender, e);
			num2 = (short)1644101645;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008394 File Offset: 0x00006594
		private void a(string mainViewName)
		{
			int a_ = 19;
			short num = (short)183107585;
			if (num != 0)
			{
			}
			num = (short)2096889856;
			short num2 = num;
			num = (short)1540805342;
			short num3 = num;
			num = (short)1541264094;
			switch (num3 == num)
			{
			}
			num = (short)310640640;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = mainViewName;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(mainViewName, new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瀶䬸吺䠼伾ࡀ݂硄", a_) + this.b.ID.ToString()
			});
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000848C File Offset: 0x0000668C
		private void a()
		{
			short num;
			for (;;)
			{
				this.e = true;
				try
				{
					this.Groups = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
					this.SelectedGroup = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectGroupInGroupsView>().Publish(this.SelectedGroup);
				}
				finally
				{
					this.e = false;
				}
				num = (short)1609629696;
				short num2 = num;
				num = (short)574294320;
				short num3 = num;
				num = (short)754649392;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BC;
				}
			}
			IL_BC:
			num = (short)584581120;
			if (num != 0)
			{
			}
			num = (short)120258561;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000085A0 File Offset: 0x000067A0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 0;
			short num;
			for (;;)
			{
				base.OnNavigatedTo(navigationContext);
				try
				{
					this.a();
					this.a(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("瘣樥眧昩䔫䴭唯就䜳匵䬷氹唻嬽㜿", a_));
					base.FilterOption = global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All;
				}
				catch (global::System.Exception exception)
				{
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				}
				num = (short)1511522304;
				short num2 = num;
				num = (short)1695178115;
				short num3 = num;
				num = (short)1624137091;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9E;
				}
			}
			IL_9E:
			num = (short)1491730433;
			if (num != 0)
			{
			}
			num = (short)1518010368;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000023 RID: 35
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> a;

		// Token: 0x04000024 RID: 36
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group b;

		// Token: 0x04000025 RID: 37
		private bool c;

		// Token: 0x04000026 RID: 38
		private bool d;

		// Token: 0x04000027 RID: 39
		private bool e;

		// Token: 0x04000028 RID: 40
		private int f;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand g;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel> h;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel> i;
	}
}
