using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000045 RID: 69
	public abstract class ContainerViewModelBase<T> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000196F0 File Offset: 0x000178F0
		public ContainerViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string mainModuleName) : base(eventAggregator, regionManager)
		{
			this.MainModuleName = mainModuleName;
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToViewRequestedEvent>().Subscribe(new global::System.Action<string>(this.OnNavigateToViewRequested));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadMainViewRequestedEvent>().Subscribe(new global::System.Action<string>(this.OnReloadMainViewRequested));
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00019740 File Offset: 0x00017940
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000197EC File Offset: 0x000179EC
		public T FilterOption
		{
			get
			{
				short num = (short)413335552;
				short num2 = num;
				num = (short)1934652171;
				short num3 = num;
				num = (short)1728738059;
				switch (num3 == num)
				{
				}
				num = (short)2144731137;
				if (num != 0)
				{
				}
				num = (short)2002321408;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1866006529;
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
						num = (short)1923746338;
						short num3 = num;
						num = (short)834275874;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)2079391745;
							if (num != 0)
							{
							}
							num = (short)1915224064;
							if (num != 0)
							{
							}
							num = (short)273088512;
							short num4 = num;
							this.a = value;
							base.RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<T>.get_FilterOption())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1797718016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_31:
					if (value.Equals(this.a))
					{
						break;
					}
					num = (short)806289410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00019958 File Offset: 0x00017B58
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00019A0C File Offset: 0x00017C0C
		private protected string MainModuleName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)2112749568;
				short num2 = num;
				num = (short)906100737;
				if (num != 0)
				{
				}
				num = (short)1368268875;
				short num3 = num;
				num = (short)1525030987;
				switch (num3 == num)
				{
				}
				num = (short)625344512;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)791674880;
				short num2 = num;
				num = (short)1289331022;
				short num3 = num;
				num = (short)787325262;
				switch (num3 == num)
				{
				}
				num = (short)1010434049;
				if (num != 0)
				{
				}
				num = (short)348979200;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00019ABC File Offset: 0x00017CBC
		protected virtual void OnNavigateToViewRequested(string viewString)
		{
			int a_ = 10;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != this.MainModuleName)
			{
				short num = (short)154468352;
				short num2 = num;
				num = (short)366084097;
				if (num != 0)
				{
				}
				num = (short)1638481829;
				short num3 = num;
				num = (short)169033637;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)795213824;
					if (num != 0)
					{
					}
					return;
				}
			}
			string payload = viewString;
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("挡眣爥稧攩猫", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("昡琣礥", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("校笣", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("瀡笣", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("無笣", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("瀡栣礥", a_), string.Empty);
			viewString = viewString.Replace(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("愡椣樥眧", a_), string.Empty);
			string regionName = this.a();
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToViewChangedEvent>().Publish(payload);
			base.RegionManager.RequestNavigate(regionName, new global::System.Uri(viewString, global::System.UriKind.Relative));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00019C70 File Offset: 0x00017E70
		public virtual void OnReloadMainViewRequested(string mainViewId)
		{
			short num = (short)652607491;
			int num2 = (int)((global::System.IntPtr)num);
			T t;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					T filterOption;
					if (filterOption.Equals(t))
					{
						num = (short)397213696;
						short num3 = num;
						num = (short)1907359748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)567667394;
					short num4 = num;
					num = (short)790620866;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						goto IL_18B;
					}
					break;
				}
				case 1:
					goto IL_153;
				case 2:
				{
					if (!this.TranslateViewIdToFilterOption(mainViewId, out t))
					{
						num = (short)1961558017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					T filterOption = this.FilterOption;
					num = (short)126615552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 4:
					goto IL_DD;
				case 5:
					return;
				}
				IL_3E:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != this.MainModuleName)
				{
					num = (short)2086993925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EE:
				num = (short)232194049;
				if (num != 0)
				{
				}
				num = (short)107937794;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_DD:
			this.LoadData();
			return;
			IL_153:
			this.LoadData();
			return;
			IL_18B:
			num = (short)632750080;
			if (num != 0)
			{
			}
			this.FilterOption = t;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00019E28 File Offset: 0x00018028
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 17;
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
					goto IL_105;
				case 1:
					num2 = (short)952893441;
					if (num2 != 0)
					{
					}
					this.LoadData();
					num2 = (short)1803485184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_8C;
				}
				goto IL_25;
			}
			IL_105:
			goto IL_107;
			IL_25:
			num2 = (short)1649951895;
			short num3 = num2;
			num2 = (short)2045789335;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8C:
				if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("漨䈪䄬嬮吰䄲稴䜶䴸刺刼儾", a_))
				{
					num2 = (short)194707457;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			default:
			{
				num2 = (short)1947074560;
				if (num2 != 0)
				{
				}
				base.OnPropertyChanged(sender, e);
				num2 = (short)563806210;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			IL_107:
			num2 = (short)2025914368;
			short num4 = num2;
		}

		// Token: 0x060001BF RID: 447
		protected abstract string GetMainViewName();

		// Token: 0x060001C0 RID: 448
		protected abstract bool TranslateViewIdToFilterOption(string mainViewId, out T filterOption);

		// Token: 0x060001C1 RID: 449 RVA: 0x00019F68 File Offset: 0x00018168
		protected virtual void LoadData()
		{
			short num = (short)1683544761;
			short num2 = num;
			num = (short)646240953;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1802895360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1130102784;
			if (num != 0)
			{
			}
			num = (short)1574240257;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(this.GetMainViewName());
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001A01C File Offset: 0x0001821C
		private string a()
		{
			int a_ = 9;
			short num = (short)349177175;
			short num2 = num;
			num = (short)1798178135;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1916665856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1926955009;
			if (num != 0)
			{
			}
			num = (short)1031143424;
			if (num != 0)
			{
			}
			return this.MainModuleName + global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("氠䈢䰤䤦笨个䨬䘮帰崲", a_);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001A0EC File Offset: 0x000182EC
		public override void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num;
			try
			{
				num = (short)380594688;
				short num2 = num;
				num = (short)1744464384;
				switch (num2 == num)
				{
				}
				num = (short)1582039040;
				if (num != 0)
				{
				}
				base.OnNavigatedFrom(navigationContext);
				string payload = this.a();
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.CleanViewCacheDataRequestedEvent>().Publish(payload);
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.CachedDataContext = null;
			}
			catch
			{
			}
			num = (short)1577517057;
			if (num != 0)
			{
			}
			num = (short)102563840;
			short num3 = num;
		}

		// Token: 0x040000C9 RID: 201
		private T a;

		// Token: 0x040000CA RID: 202
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
