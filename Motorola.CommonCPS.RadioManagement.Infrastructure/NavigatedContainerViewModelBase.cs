using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000044 RID: 68
	public abstract class NavigatedContainerViewModelBase<T, U> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<U> where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00018CE4 File Offset: 0x00016EE4
		public NavigatedContainerViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string mainModuleName) : base(eventAggregator, regionManager, mainModuleName)
		{
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00018D14 File Offset: 0x00016F14
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00018DC4 File Offset: 0x00016FC4
		public global::System.Collections.ObjectModel.ObservableCollection<T> NavigationItems
		{
			get
			{
				short num = (short)2095185920;
				short num2 = num;
				num = (short)750648565;
				short num3 = num;
				num = (short)235601141;
				switch (num3 == num)
				{
				}
				num = (short)632029185;
				if (num != 0)
				{
				}
				num = (short)1272774656;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)388169729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1356333057;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 2:
					{
						num = (short)415497064;
						short num3 = num;
						num = (short)650181480;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)898629632;
							if (num != 0)
							{
							}
							num = (short)786235392;
							short num4 = num;
							this.b = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<T>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<T>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>.get_NavigationItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1277231104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_56:
					if (value == this.b)
					{
						break;
					}
					num = (short)2133393410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00018FC8 File Offset: 0x000171C8
		public bool IsSelectedNavigationItemLocked
		{
			get
			{
				short num = (short)312868864;
				short num2 = num;
				num = (short)1896480769;
				if (num != 0)
				{
				}
				num = (short)915870239;
				short num3 = num;
				num = (short)1547112991;
				switch (num3 == num)
				{
				}
				num = (short)1736376320;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)308740097;
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
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)959225193;
						short num3 = num;
						num = (short)1975360873;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)592052224;
							if (num != 0)
							{
							}
							num = (short)861995008;
							short num4 = num;
							this.a = value;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>.get_IsSelectedNavigationItemLocked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)622002177;
							if (num != 0)
							{
							}
							num = (short)2026897408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_31:
					if (value == this.a)
					{
						break;
					}
					num = (short)745865218;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001911C File Offset: 0x0001731C
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000191CC File Offset: 0x000173CC
		public T SelectedNavigationItem
		{
			get
			{
				short num = (short)514195456;
				short num2 = num;
				num = (short)1086652417;
				if (num != 0)
				{
				}
				num = (short)1670925869;
				short num3 = num;
				num = (short)929189421;
				switch (num3 == num)
				{
				}
				num = (short)1627258880;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1245773825;
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
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)310194720;
						short num3 = num;
						num = (short)613495328;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)1831731200;
							if (num != 0)
							{
							}
							num = (short)1007681536;
							short num4 = num;
							this.c = value;
							base.RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<T, U>.get_SelectedNavigationItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.SaveLastSelectedItemSetting<T>(this.c);
							num = (short)864092160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_31:
					num = (short)453836801;
					if (num != 0)
					{
					}
					if (object.Equals(value, this.c))
					{
						break;
					}
					num = (short)488308738;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00019348 File Offset: 0x00017548
		private void a(object A_0)
		{
			short num = (short)100925440;
			short num2 = num;
			num = (short)909747897;
			short num3 = num;
			num = (short)169649849;
			switch (num3 == num)
			{
			}
			num = (short)771948544;
			if (num != 0)
			{
			}
			num = (short)607387649;
			if (num != 0)
			{
			}
			this.IsSelectedNavigationItemLocked = true;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000193FC File Offset: 0x000175FC
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_25;
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
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("东稞䴠䘢䘤匦䰨伪挬丮䜰娲刴嘶䴸刺刼儾ࡀ㝂⁄⩆", a_))
					{
						num2 = (short)1830158338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)959774721;
					if (num2 != 0)
					{
					}
					num2 = (short)521317297;
					short num3 = num2;
					num2 = (short)1840032689;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1770061824;
						if (num2 != 0)
						{
						}
						num2 = (short)812974080;
						short num4 = num2;
						this.LoadData();
						num2 = (short)782761984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_25;
			}
			return;
			IL_25:
			base.OnPropertyChanged(sender, e);
			num2 = (short)193724417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001B4 RID: 436
		protected abstract string GetNavigationParameterName();

		// Token: 0x060001B5 RID: 437 RVA: 0x0001953C File Offset: 0x0001773C
		protected override void LoadData()
		{
			int a_ = 12;
			short num = (short)1918042112;
			short num2 = num;
			num = (short)1492385793;
			if (num != 0)
			{
			}
			num = (short)421154262;
			short num3 = num;
			num = (short)1704676822;
			switch (num3 == num)
			{
			}
			num = (short)796590080;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(this.GetMainViewName(), new global::System.Collections.Generic.List<string>
			{
				string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("弣ᘥ唧ᜩ圫Ἥ䴯", a_), this.GetNavigationParameterName(), this.c.ID)
			});
			this.IsSelectedNavigationItemLocked = false;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001963C File Offset: 0x0001783C
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1905065984;
			short num2 = num;
			num = (short)357040129;
			if (num != 0)
			{
			}
			num = (short)1981758548;
			short num3 = num;
			num = (short)240860244;
			switch (num3 == num)
			{
			}
			num = (short)1750728704;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.LoadData();
		}

		// Token: 0x040000C6 RID: 198
		private bool a;

		// Token: 0x040000C7 RID: 199
		private global::System.Collections.ObjectModel.ObservableCollection<T> b;

		// Token: 0x040000C8 RID: 200
		private T c;
	}
}
