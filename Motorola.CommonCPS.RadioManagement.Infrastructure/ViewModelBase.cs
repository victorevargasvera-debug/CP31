using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000046 RID: 70
	public abstract class ViewModelBase : global::Microsoft.Practices.Prism.ViewModel.NotificationObject, global::Microsoft.Practices.Prism.Regions.INavigationAware
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0001A1D0 File Offset: 0x000183D0
		public ViewModelBase()
		{
			this.CommandProxy = global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance();
			this.ServiceProxy = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy.GetInstance();
			base.PropertyChanged += this.OnPropertyChanged;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001A20C File Offset: 0x0001840C
		public ViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : this()
		{
			this.EventAggregator = eventAggregator;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001A228 File Offset: 0x00018428
		public ViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager) : this(eventAggregator)
		{
			this.RegionManager = regionManager;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001A244 File Offset: 0x00018444
		public ViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.Common.LogUtility.ILog logger) : this(eventAggregator)
		{
			this.Logger = logger;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001A260 File Offset: 0x00018460
		public ViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, global::Motorola.Common.LogUtility.ILog logger) : this(eventAggregator)
		{
			this.RegionManager = regionManager;
			this.Logger = logger;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001A284 File Offset: 0x00018484
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0001A334 File Offset: 0x00018534
		public global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy CommandProxy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1864499200;
				short num2 = num;
				num = (short)164830005;
				short num3 = num;
				num = (short)1450384181;
				switch (num3 == num)
				{
				}
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)841154560;
				short num2 = num;
				num = (short)960160652;
				short num3 = num;
				num = (short)364372876;
				switch (num3 == num)
				{
				}
				num = (short)435552257;
				if (num != 0)
				{
				}
				num = (short)61603840;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001A3E4 File Offset: 0x000185E4
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0001A490 File Offset: 0x00018690
		private protected global::Microsoft.Practices.Prism.Events.IEventAggregator EventAggregator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)1114046464;
				short num2 = num;
				num = (short)1148464676;
				short num3 = num;
				num = (short)2134584868;
				switch (num3 == num)
				{
				}
				num = (short)1197408257;
				if (num != 0)
				{
				}
				num = (short)367460352;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1084227584;
				short num2 = num;
				num = (short)554000934;
				short num3 = num;
				num = (short)765944358;
				switch (num3 == num)
				{
				}
				num = (short)1455947777;
				if (num != 0)
				{
				}
				num = (short)698417152;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001A540 File Offset: 0x00018740
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0001A5F0 File Offset: 0x000187F0
		private protected global::Microsoft.Practices.Prism.Regions.IRegionManager RegionManager
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)1906376704;
				short num2 = num;
				num = (short)1706260615;
				short num3 = num;
				num = (short)1559132295;
				switch (num3 == num)
				{
				}
				num = (short)1485570049;
				if (num != 0)
				{
				}
				num = (short)1559625728;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)617414656;
				short num2 = num;
				num = (short)1258187848;
				short num3 = num;
				num = (short)1630366792;
				switch (num3 == num)
				{
				}
				num = (short)236978177;
				if (num != 0)
				{
				}
				num = (short)776601600;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0001A6A4 File Offset: 0x000188A4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0001A750 File Offset: 0x00018950
		private protected global::Motorola.Common.LogUtility.ILog Logger
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)1463615488;
				short num2 = num;
				num = (short)136627040;
				short num3 = num;
				num = (short)656458592;
				switch (num3 == num)
				{
				}
				num = (short)1472856064;
				if (num != 0)
				{
				}
				num = (short)617152513;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)639434752;
				short num2 = num;
				num = (short)297625763;
				short num3 = num;
				num = (short)2025154723;
				switch (num3 == num)
				{
				}
				num = (short)127926273;
				if (num != 0)
				{
				}
				num = (short)663289856;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001A804 File Offset: 0x00018A04
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		private protected global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy ServiceProxy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)589103104;
				short num2 = num;
				num = (short)727694453;
				short num3 = num;
				num = (short)820558965;
				switch (num3 == num)
				{
				}
				num = (short)16646145;
				if (num != 0)
				{
				}
				num = (short)606339072;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1008336896;
				short num2 = num;
				num = (short)1308727612;
				short num3 = num;
				num = (short)1037408572;
				switch (num3 == num)
				{
				}
				num = (short)223936513;
				if (num != 0)
				{
				}
				num = (short)2082865152;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0001A960 File Offset: 0x00018B60
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0001AA10 File Offset: 0x00018C10
		public bool IsLoading
		{
			get
			{
				short num = (short)1139998720;
				short num2 = num;
				num = (short)1921478179;
				short num3 = num;
				num = (short)1031892515;
				switch (num3 == num)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				num = (short)956366849;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1538392066;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1715994624;
						short num3 = num;
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase.get_IsLoading())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1109458945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_D0;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value != this.a)
					{
						num = (short)736755712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D0:
					num = (short)375730829;
					short num4 = num;
					num = (short)806236813;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_31;
					default:
						goto IL_108;
					}
				}
				IL_108:
				num = (short)842465280;
				if (num != 0)
				{
				}
				num = (short)314703873;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001AB60 File Offset: 0x00018D60
		protected string UrlEncode(string str)
		{
			int a_ = 17;
			short num = (short)779157508;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				int num3;
				byte[] bytes;
				switch (num2)
				{
				case 0:
					goto IL_128;
				case 1:
					if (num3 >= bytes.Length)
					{
						num = (short)232980483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("న", a_) + global::System.Convert.ToString(bytes[num3], 16));
					num3++;
					goto IL_8A;
				case 2:
					goto IL_5D;
				case 3:
				{
					num = (short)1365484837;
					short num4 = num;
					num = (short)1896850725;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						goto IL_197;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					num = (short)1205862401;
					if (num != 0)
					{
					}
					goto IL_128;
				}
				IL_45:
				if (str == null)
				{
					num = (short)385810434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				stringBuilder = new global::System.Text.StringBuilder();
				bytes = global::System.Text.Encoding.UTF8.GetBytes(str);
				num3 = 0;
				num = (short)2005794821;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8A:
				num = (short)1628766208;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_128:
				num = (short)783810561;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			num = (short)134610944;
			short num5 = num;
			return string.Empty;
			IL_197:
			num = (short)1838481408;
			if (num != 0)
			{
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001AD20 File Offset: 0x00018F20
		protected virtual void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1167416733;
			short num2 = num;
			num = (short)1161387421;
			switch (num2 == num)
			{
			default:
			{
				num = (short)178520064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1125580801;
			if (num != 0)
			{
			}
			num = (short)1360396288;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001ADCC File Offset: 0x00018FCC
		public virtual bool IsNavigationTarget(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1952232655;
			short num2 = num;
			num = (short)470529231;
			switch (num2 == num)
			{
			default:
			{
				num = (short)680067072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2123169792;
			if (num != 0)
			{
			}
			num = (short)1470824449;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001AE74 File Offset: 0x00019074
		public virtual void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num;
			try
			{
				num = (short)1154220037;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_CB;
					case 1:
						goto IL_74;
					case 2:
						goto IL_16C;
					case 3:
						goto IL_B3;
					case 4:
						num = (short)2001993729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 6:
					{
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext is global::System.ComponentModel.ICollectionView))
						{
							num = (short)1980170244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext = null;
						this.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveDataContextChangedEvent>().Publish(null);
						num = (short)661241700;
						short num3 = num;
						num = (short)1371389796;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B3;
						default:
							num = (short)1791623168;
							if (num != 0)
							{
							}
							num = (short)1286537218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_41:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext == null)
					{
						num = (short)1531772931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)902627334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B3:
					num = (short)1818492928;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_74:
				goto IL_171;
				IL_CB:
				num = (short)1544355841;
				if (num != 0)
				{
				}
				IL_16C:;
			}
			catch
			{
			}
			IL_171:
			num = (short)619380736;
			short num4 = num;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001B038 File Offset: 0x00019238
		public virtual void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1093337408;
			short num2 = num;
			num = (short)208273728;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1492254720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)557383681;
			if (num != 0)
			{
			}
			num = (short)308346880;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000CB RID: 203
		private bool a;

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy b;

		// Token: 0x040000CD RID: 205
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Events.IEventAggregator c;

		// Token: 0x040000CE RID: 206
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Regions.IRegionManager d;

		// Token: 0x040000CF RID: 207
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.ILog e;

		// Token: 0x040000D0 RID: 208
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy f;
	}
}
