using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000040 RID: 64
	[global::System.ComponentModel.Composition.Export]
	public class NavigationViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001E14C File Offset: 0x0001C34C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0001E1FC File Offset: 0x0001C3FC
		private bool IsOpeningArchive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)618673304;
				short num2 = num;
				num = (short)205862040;
				switch (num2 == num)
				{
				}
				num = (short)1195966464;
				short num3 = num;
				num = (short)1805123585;
				if (num != 0)
				{
				}
				num = (short)1149829120;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1274758432;
				short num2 = num;
				num = (short)1196770592;
				switch (num2 == num)
				{
				}
				num = (short)1114308608;
				short num3 = num;
				num = (short)2019819521;
				if (num != 0)
				{
				}
				num = (short)2099445760;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001E2B0 File Offset: 0x0001C4B0
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public NavigationViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 7;
			this.n = -1;
			base..ctor(eventAggregator, regionManager);
			this.e = new global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>();
			base.PropertyChanged += this.a;
			this.TabHeaderStyle = global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.Text;
			this.f = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("飘럚뇜", a_),
				global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觘駚鿜", a_)
			};
			this.b();
			this.NavigateCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.e));
			this.TechnologySelectCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.d));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.AppendInfoToNavigationPathRequestedEvent>().Subscribe(new global::System.Action<string>(this.c));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Subscribe(new global::System.Action<string>(this.b), global::Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread);
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleCouldCancelEvent>().Subscribe(new global::System.Action<global::System.Collections.Generic.List<string>>(this.a), global::Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread);
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToViewRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.UpdateNavigationPathRequestedEvent>().Subscribe(new global::System.Action<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioDetailsRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
			if (new global::System.Collections.Generic.List<string>(global::Motorola.CommonCPS.RadioManagement.Global.ModuleNames.TemplateLandPageArray).Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage))
			{
				this.ActiveMainModule = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage;
			}
			else
			{
				this.ActiveMainModule = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뫚맜뛞軠", a_);
			}
			this.a();
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001E440 File Offset: 0x0001C640
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		public string ActiveMainModule
		{
			get
			{
				short num = (short)750721961;
				short num2 = num;
				num = (short)837163945;
				switch (num2 == num)
				{
				}
				num = (short)563281920;
				short num3 = num;
				num = (short)520683521;
				if (num != 0)
				{
				}
				num = (short)35454976;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 11;
				short num = (short)1448411147;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.a)
						{
							num = (short)1031274504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView != global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远뻞藠諢諤铦뿨苪裬飮", a_))
						{
							num = (short)87490565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (this.IsOpeningArchive)
						{
							num = (short)1763901450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2052784128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.a == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远뻞藠諢諤", a_))
						{
							num = (short)1127022596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)40501249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_ActiveMainModule())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)436142087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_18B;
					case 7:
						return;
					case 8:
						num = (short)883490819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1365966849;
						if (num != 0)
						{
						}
						num = (short)2041380866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_172;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					}
					IL_5D:
					if (!(value != this.a))
					{
						num = (short)1644494848;
						short num3 = num;
						num = (short)1267728393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_172:
					num = (short)1655242758;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18B:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_2A1;
					}
					for (;;)
					{
						IL_27B:
						switch (num2)
						{
						case 0:
							num = (short)225247234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Collections.Generic.List<bool> list;
							if (list[0])
							{
								num = (short)779616262;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D3;
						}
						case 2:
						{
							num = (short)42303363;
							short num4 = num;
							num = (short)1600225155;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3D3;
							default:
								num = (short)93913088;
								if (num != 0)
								{
								}
								if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ReloadConfiguration)
								{
									num = (short)1080492036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3D3;
							}
							break;
						}
						case 3:
							goto IL_376;
						case 4:
						{
							global::System.Collections.Generic.List<bool> list = new global::System.Collections.Generic.List<bool>();
							list.Add(false);
							base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveMainModuleChangingEvent>().Publish(list);
							num = (short)1803681793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_43D;
						case 6:
							num = (short)2145255427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.RedirectWhenStartFromCPS)
							{
								num = (short)1875574784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D3;
						}
						goto IL_2A1;
						IL_3D3:
						base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EndGrouplistEditModeRequestedEvent>().Publish(null);
						this.a = value;
						this.PickerVisibility = global::System.Windows.Visibility.Collapsed;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_ActiveMainModule())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1130364933;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_376:
					IL_43D:
					return;
					IL_2A1:
					this.IsOpeningArchive = false;
					num = (short)1499529223;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27B;
				}
				finally
				{
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.RedirectWhenStartFromCPS = false;
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0001E960 File Offset: 0x0001CB60
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001EA10 File Offset: 0x0001CC10
		public string ActiveView
		{
			get
			{
				short num = (short)1133611209;
				short num2 = num;
				num = (short)49055945;
				switch (num2 == num)
				{
				}
				num = (short)10223616;
				short num3 = num;
				num = (short)368181248;
				if (num != 0)
				{
				}
				num = (short)2015035393;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)338690050;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_ActiveView())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)964100096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						num = (short)844191945;
						short num3 = num;
						num = (short)318986441;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)228524032;
							short num4 = num;
							num = (short)2059206657;
							if (num != 0)
							{
							}
							num = (short)1506541568;
							if (num != 0)
							{
							}
							if (!(value != this.b))
							{
								return;
							}
							num = (short)1618804737;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0001EB64 File Offset: 0x0001CD64
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>> PathSections
		{
			get
			{
				short num = (short)545371029;
				short num2 = num;
				num = (short)832549781;
				switch (num2 == num)
				{
				}
				num = (short)221839360;
				short num3 = num;
				num = (short)1841889281;
				if (num != 0)
				{
				}
				num = (short)1909719040;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1600978946;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.e = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_PathSections())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1326972928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_15;
					}
					goto IL_31;
					IL_15:
					switch (0)
					{
					case 0:
					{
						IL_31:
						num = (short)1238269673;
						short num3 = num;
						num = (short)1534426857;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
						{
							num = (short)931201024;
							short num4 = num;
							num = (short)643039232;
							if (num != 0)
							{
							}
							num = (short)540344321;
							if (num != 0)
							{
							}
							if (value == this.e)
							{
								return;
							}
							num = (short)947912705;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0001ED68 File Offset: 0x0001CF68
		public global::System.Collections.Generic.List<string> Technologies
		{
			get
			{
				short num = (short)512726256;
				short num2 = num;
				num = (short)1916441840;
				switch (num2 == num)
				{
				}
				num = (short)967835648;
				short num3 = num;
				num = (short)592707585;
				if (num != 0)
				{
				}
				num = (short)2095251456;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001EE18 File Offset: 0x0001D018
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle TabHeaderStyle
		{
			get
			{
				short num = (short)279096895;
				short num2 = num;
				num = (short)461155903;
				switch (num2 == num)
				{
				}
				num = (short)1392574464;
				short num3 = num;
				num = (short)532414465;
				if (num != 0)
				{
				}
				num = (short)1152122880;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1688731650;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1952382977;
						if (num != 0)
						{
						}
						this.g = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_TabHeaderStyle())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)908197888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						num = (short)1847211554;
						short num3 = num;
						num = (short)1041380898;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1538523136;
							short num4 = num;
							num = (short)374079488;
							if (num != 0)
							{
							}
							if (value == this.g)
							{
								return;
							}
							num = (short)781123585;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001F020 File Offset: 0x0001D220
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		public global::System.Windows.Visibility AstroSystemVisibility
		{
			get
			{
				short num = (short)993190389;
				short num2 = num;
				num = (short)1569710581;
				switch (num2 == num)
				{
				}
				num = (short)740622336;
				short num3 = num;
				num = (short)339738625;
				if (num != 0)
				{
				}
				num = (short)493551616;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1959788546;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)169476097;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.h = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_AstroSystemVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1737359360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_15;
					}
					goto IL_59;
					IL_15:
					switch (0)
					{
					case 0:
					{
						IL_59:
						num = (short)68790987;
						short num3 = num;
						num = (short)1282648779;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						case 1:
							break;
						default:
						{
							num = (short)961150976;
							short num4 = num;
							break;
						}
						}
						num = (short)1433141248;
						if (num != 0)
						{
						}
						if (value == this.h)
						{
							return;
						}
						num = (short)1110966273;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001F220 File Offset: 0x0001D420
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		public global::System.Windows.Visibility AstroOtarProfileVisibility
		{
			get
			{
				short num = (short)494099332;
				short num2 = num;
				num = (short)1090083716;
				switch (num2 == num)
				{
				}
				num = (short)177537024;
				short num3 = num;
				num = (short)392298496;
				if (num != 0)
				{
				}
				num = (short)671547393;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1388511234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1594490881;
						if (num != 0)
						{
						}
						this.i = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_AstroOtarProfileVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)43122688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						num = (short)983339;
						short num3 = num;
						num = (short)1709375787;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1454243840;
							short num4 = num;
							num = (short)154206208;
							if (num != 0)
							{
							}
							if (value == this.i)
							{
								return;
							}
							num = (short)1699545089;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001F41C File Offset: 0x0001D61C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		public global::System.Windows.Visibility PCRSystemVisibility
		{
			get
			{
				short num = (short)383430566;
				short num2 = num;
				num = (short)1126018982;
				switch (num2 == num)
				{
				}
				num = (short)2018377728;
				short num3 = num;
				num = (short)2134376449;
				if (num != 0)
				{
				}
				num = (short)839843840;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1787166722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.j = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_PCRSystemVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)825163776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						num = (short)1724776449;
						if (num != 0)
						{
						}
						num = (short)1176685353;
						short num3 = num;
						num = (short)1647299369;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						case 1:
							break;
						default:
						{
							num = (short)313982976;
							short num4 = num;
							break;
						}
						}
						num = (short)1528496128;
						if (num != 0)
						{
						}
						if (value == this.j)
						{
							return;
						}
						num = (short)1850998785;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001F61C File Offset: 0x0001D81C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		public global::System.Windows.Visibility DataProfileVisibility
		{
			get
			{
				short num = (short)20447232;
				short num2 = num;
				num = (short)288473991;
				short num3 = num;
				num = (short)1868350343;
				switch (num3 == num)
				{
				}
				num = (short)775553025;
				if (num != 0)
				{
				}
				num = (short)1509425152;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1515913217;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1551433728;
						short num3 = num;
						this.k = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_DataProfileVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)990380034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						IL_16:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						goto IL_D4;
					}
					IL_32:
					if (value != this.k)
					{
						num = (short)1439039488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D4:
					num = (short)589533653;
					short num4 = num;
					num = (short)2063372757;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_109;
					}
				}
				IL_109:
				num = (short)1272053761;
				if (num != 0)
				{
				}
				num = (short)1862402048;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0001F824 File Offset: 0x0001DA24
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		public global::System.Windows.Visibility PickerVisibility
		{
			get
			{
				short num = (short)1722023936;
				short num2 = num;
				num = (short)939384744;
				short num3 = num;
				num = (short)2127028136;
				switch (num3 == num)
				{
				}
				num = (short)168361985;
				if (num != 0)
				{
				}
				num = (short)1129250816;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)632619009;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)907214848;
						short num3 = num;
						this.l = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_PickerVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)777781250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						IL_15:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_D0;
					}
					IL_31:
					if (value != this.l)
					{
						num = (short)1208942592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D0:
					num = (short)1365701634;
					short num4 = num;
					num = (short)1816130562;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_106;
					}
				}
				IL_106:
				num = (short)2060713985;
				if (num != 0)
				{
				}
				num = (short)1336475648;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001FA24 File Offset: 0x0001DC24
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
		public bool JobsClickable
		{
			get
			{
				short num = (short)335347712;
				short num2 = num;
				num = (short)526044805;
				short num3 = num;
				num = (short)1967312517;
				switch (num3 == num)
				{
				}
				num = (short)2131623937;
				if (num != 0)
				{
				}
				num = (short)1061355520;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				short num = (short)2061631489;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.m = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_JobsClickable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)556269570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						IL_14:
						num = (short)677773313;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						goto IL_F8;
					}
					IL_58:
					if (value != this.m)
					{
						num = (short)1114439680;
						short num3 = num;
						num = (short)761593856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F8:
					num = (short)243767879;
					short num4 = num;
					num = (short)579705415;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_12E;
					}
				}
				IL_12E:
				num = (short)303104000;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001FC28 File Offset: 0x0001DE28
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0001FCD8 File Offset: 0x0001DED8
		public int TechSelectedIndex
		{
			get
			{
				short num = (short)756482048;
				short num2 = num;
				num = (short)1292756259;
				short num3 = num;
				num = (short)942400803;
				switch (num3 == num)
				{
				}
				num = (short)195362817;
				if (num != 0)
				{
				}
				num = (short)47841280;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)1879179265;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1610350593;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.n = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.NavigationViewModel.get_TechSelectedIndex())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1992097794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						IL_16:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						goto IL_FC;
					}
					IL_5A:
					if (value != this.n)
					{
						num = (short)401997824;
						short num3 = num;
						num = (short)1923481600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FC:
					num = (short)906630632;
					short num4 = num;
					num = (short)1966020072;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_133;
					}
				}
				IL_133:
				num = (short)1764950016;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001FE30 File Offset: 0x0001E030
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> NavigateCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1533018112;
				short num2 = num;
				num = (short)2038710822;
				short num3 = num;
				num = (short)1289437734;
				switch (num3 == num)
				{
				}
				num = (short)530776065;
				if (num != 0)
				{
				}
				num = (short)287178752;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1001717760;
				short num2 = num;
				num = (short)145873619;
				short num3 = num;
				num = (short)1354357459;
				switch (num3 == num)
				{
				}
				num = (short)173080576;
				if (num != 0)
				{
				}
				num = (short)1487142913;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001FF94 File Offset: 0x0001E194
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00020048 File Offset: 0x0001E248
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> TechnologySelectCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)151257088;
				short num2 = num;
				num = (short)401672858;
				short num3 = num;
				num = (short)2002520730;
				switch (num3 == num)
				{
				}
				num = (short)1903886336;
				if (num != 0)
				{
				}
				num = (short)1536229377;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1328480256;
				short num2 = num;
				num = (short)287401968;
				short num3 = num;
				num = (short)2147051504;
				switch (num3 == num)
				{
				}
				num = (short)1259798528;
				if (num != 0)
				{
				}
				num = (short)1555365889;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000200F8 File Offset: 0x0001E2F8
		private void e(string A_0)
		{
			int a_ = 2;
			short num = (short)1674903554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.Contains(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛓돕꣗뗙껛ꫝ鏟", a_)))
					{
						num = (short)2025455619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 1:
					goto IL_B6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					goto IL_10F;
				}
				IL_3E:
				if (A_0.Contains(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郓돕곗믙뗛닝鏟", a_)))
				{
					num = (short)307206816;
					short num3 = num;
					num = (short)1503238816;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B6;
					default:
						num = (short)1777795072;
						if (num != 0)
						{
						}
						num = (short)290717697;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1941438464;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B6:
			num = (short)147062785;
			if (num != 0)
			{
			}
			num = (short)478412800;
			short num4 = num;
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshDetailsViewRequestedEvent>().Publish(null);
			return;
			IL_10F:
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRadioReportsRequestedEvent>().Publish(null);
			return;
			IL_173:
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadMainViewRequestedEvent>().Publish(A_0);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0002028C File Offset: 0x0001E48C
		private void d(string A_0)
		{
			short num = (short)630587392;
			short num2 = num;
			num = (short)846069761;
			if (num != 0)
			{
			}
			num = (short)1153975780;
			short num3 = num;
			num = (short)73418212;
			switch (num3 == num)
			{
			}
			num = (short)1765539840;
			if (num != 0)
			{
			}
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangeTechnologyRequestedEvent>().Publish(A_0);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadResourceRequestedEvent>().Publish(A_0);
			this.a();
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastTech = A_0;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00020378 File Offset: 0x0001E578
		private void b()
		{
			short num = (short)1798176768;
			short num2 = num;
			num = (short)865927169;
			if (num != 0)
			{
			}
			num = (short)70117413;
			short num3 = num;
			num = (short)1438115877;
			switch (num3 == num)
			{
			}
			num = (short)1609170944;
			if (num != 0)
			{
			}
			this.n = 0;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00020428 File Offset: 0x0001E628
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					this.AstroOtarProfileVisibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)667353090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num2 = (short)540082176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				case 2:
					goto IL_132;
				}
				goto IL_1C;
			}
			IL_132:
			goto IL_134;
			IL_1C:
			this.AstroSystemVisibility = global::System.Windows.Visibility.Visible;
			this.AstroOtarProfileVisibility = global::System.Windows.Visibility.Visible;
			this.DataProfileVisibility = global::System.Windows.Visibility.Visible;
			this.PickerVisibility = global::System.Windows.Visibility.Collapsed;
			num2 = (short)845210983;
			short num3 = num2;
			num2 = (short)172025191;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_134:
				this.PCRSystemVisibility = global::System.Windows.Visibility.Collapsed;
				this.JobsClickable = true;
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance().ExportCurrentGridToFileCommand.RaiseCanExecuteChanged();
				return;
			default:
			{
				num2 = (short)360579072;
				if (num2 != 0)
				{
				}
				num2 = (short)1506672640;
				short num4 = num2;
				num2 = (short)1580269569;
				if (num2 != 0)
				{
				}
				num2 = (short)211550209;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00020588 File Offset: 0x0001E788
		private void c(string A_0)
		{
			int a_ = 18;
			short num = (short)2132475904;
			short num2 = num;
			num = (short)184686427;
			short num3 = num;
			num = (short)50665307;
			switch (num3 == num)
			{
			}
			num = (short)1355677697;
			if (num != 0)
			{
			}
			num = (short)1516896256;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.KeyValuePair<string, string> item = this.e.Last<global::System.Collections.Generic.KeyValuePair<string, string>>();
			item = new global::System.Collections.Generic.KeyValuePair<string, string>(item.Key, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鿣훥闧", a_), A_0));
			this.e.RemoveAt(this.e.Count - 1);
			this.e.Add(item);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00020694 File Offset: 0x0001E894
		private void b(string A_0)
		{
			int a_ = 8;
			short num = (short)1365704713;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string[] array;
				string text;
				switch (num2)
				{
				case 0:
					if (array[1].StartsWith(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("駙돛냝蛟诡菣ꗥ룧맩꯫鯭駯雱짳", a_)))
					{
						num = (short)325058572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 1:
					goto IL_2E7;
				case 2:
					if (this.c != text)
					{
						num = (short)464715779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_160;
				case 3:
				{
					num = (short)1719664640;
					short num3 = num;
					this.a(array);
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadMainViewRequestedEvent>().Publish("");
					num = (short)1014497284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_160;
				case 5:
					num = (short)853344258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_268;
				case 7:
					this.d = A_0;
					array = A_0.Split(new char[]
					{
						'?'
					});
					num = (short)1824849921;
					if (num != 0)
					{
					}
					num = (short)1535901707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)2028929024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 10:
					if (this.ActiveMainModule == array[0])
					{
						num = (short)1373896718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_160;
				case 11:
					if (array.Length > 1)
					{
						num = (short)1687027720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 12:
					this.IsOpeningArchive = true;
					num = (short)160694278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!string.IsNullOrEmpty(this.c))
					{
						num = (short)933101573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_160;
				case 14:
					num = (short)181600269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6A:
				if (!string.IsNullOrEmpty(A_0))
				{
					num = (short)1857421319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2E7;
				IL_16D:
				num = (short)1715470337;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E7:
				num = (short)386485711;
				short num4 = num;
				num = (short)1595952591;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_16D;
				default:
					goto IL_31C;
				}
				IL_160:
				this.c = this.c(array);
				goto IL_16D;
				IL_268:
				text = this.c(array);
				this.b(array);
				this.ActiveMainModule = array[0];
				num = (short)986972170;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_31C:
			num = (short)2019622912;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000209D4 File Offset: 0x0001EBD4
		private void a(global::System.Collections.Generic.List<string> A_0)
		{
			int a_ = 6;
			short num = (short)678690817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1345375809;
					short num3 = num;
					num = (short)1582747201;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)949485568;
						if (num != 0)
						{
						}
						num = (short)1112014849;
						if (num != 0)
						{
						}
						num = (short)1107361792;
						short num4 = num;
						this.d = A_0[0];
						string[] array = A_0[0].Split(new char[]
						{
							'?'
						});
						this.b(array);
						this.ActiveMainModule = array[0];
						num = (short)2116812804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 2:
					if (A_0.Count > 0)
					{
						num = (short)295305216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_F7;
				case 4:
				{
					string[] array;
					if (this.ActiveMainModule != array[0])
					{
						num = (short)187170819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a(array);
					num = (short)1395392518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)2134376450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return;
				}
				IL_4B:
				if (A_0 == null)
				{
					return;
				}
				num = (short)1994391557;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:
			A_0.Add(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鯗믙닛뷝藟軡臣若", a_));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00020BDC File Offset: 0x0001EDDC
		private string c(string[] A_0)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_0.Length == 2)
					{
						num2 = (short)1378877449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8D;
				case 1:
					result = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뗤ꗦꯨ맪賬诮飰鳲맴黶髸黺鏼賾搀", a_);
					num2 = (short)2100625412;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_0.Length == 1)
					{
						num2 = (short)1556873228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (A_0[0] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("럤蛦跨苪苬ꏮ飰郲郴駶諸黺", a_))
					{
						num2 = (short)1798963210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_F0;
				case 5:
					num2 = (short)93454343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					if (A_0[1] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뗤ꗦꯨ", a_))
					{
						num2 = (short)1831010305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8D;
				case 8:
					if (A_0 == null)
					{
						num2 = (short)363790342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)848560128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1161691149;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1522532353;
					if (num2 != 0)
					{
					}
					result = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("럤蛦跨苪苬ꏮ飰郲郴駶諸黺", a_);
					num2 = (short)494403595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return result;
				case 12:
					num2 = (short)157351939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					if (!(A_0[0] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("럤蛦跨苪苬ꏮ飰郲郴駶諸黺", a_)))
					{
						goto IL_8D;
					}
					num2 = (short)1145121989;
					short num3 = num2;
					num2 = (short)1625828549;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)543883264;
						if (num2 != 0)
						{
						}
						num2 = (short)1671364613;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_51;
				IL_8D:
				num2 = (short)1698758658;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_F0:
			num2 = (short)2047475712;
			short num4 = num2;
			return result;
			IL_51:
			result = "";
			num2 = (short)2128740360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		private void b(string[] A_0)
		{
			int a_ = 6;
			short num = (short)1791950848;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)288358400;
					short num3 = num;
					if (A_0[0] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諗믙룛럝迟껡跣藥跧蓩鿫语", a_))
					{
						goto IL_131;
					}
					return;
				}
				case 3:
				{
					num = (short)1194813463;
					short num4 = num;
					num = (short)256600087;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num = (short)1632305152;
						if (num != 0)
						{
						}
						num = (short)987627522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)2064384001;
					if (num != 0)
					{
					}
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Publish(0);
					num = (short)491782145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_42:
				if (A_0.Length != 2)
				{
					num = (short)1202782211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_131:
				num = (short)1674969092;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00021058 File Offset: 0x0001F258
		private void a(string[] A_0)
		{
			int a_ = 9;
			short num = (short)799014912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 1:
					goto IL_E3;
				case 2:
				{
					num = (short)1123483648;
					short num3 = num;
					if (A_0[0] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觚볜믞裠賢ꧤ軦諨軪菬鳮铰", a_))
					{
						goto IL_13C;
					}
					goto IL_158;
				}
				case 3:
				{
					num = (short)1787158409;
					short num4 = num;
					num = (short)215146377;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num = (short)1370750976;
						if (num != 0)
						{
						}
						num = (short)2145255426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					this.b(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
					{
						new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLicence)
					});
					num = (short)1353777153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (A_0.Length != 2)
				{
					num = (short)1233256451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13C:
				num = (short)585564164;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E3:
			IL_158:
			num = (short)216793089;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000211E4 File Offset: 0x0001F3E4
		private void a(string A_0)
		{
			int a_ = 5;
			short num = (short)1707474944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_2F8;
				}
				string text;
				for (;;)
				{
					IL_31:
					uint num3;
					string a_2;
					switch (num2)
					{
					case 0:
						if (num3 != 3225328704U)
						{
							num = (short)531562574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)548470918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚远뻞藠諢諤铦뿨苪裬飮", a_)))
						{
							num = (short)890830870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚远뻞藠諢諤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_Radios));
						num = (short)1172570224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)424673432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3 != 581792707U)
						{
							num = (short)1451360366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)469499952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)2131689594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_171F;
					case 6:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖蛘鿚룜ꯞ胠諢觤铦뿨苪裬飮", a_)))
						{
							num = (short)1924202610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖蛘鿚룜ꯞ胠諢觤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Radio_Details));
						num = (short)1803354286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1AE1;
					case 8:
						if (!A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뫚맜뛞軠ꫢꇤ\udae6", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1416036384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FD;
					case 9:
						if (!A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("釘듚냜뫞닠蛢釤ꧦ裨蛪裬틮", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1186857048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FD;
					case 10:
						goto IL_11A6;
					case 11:
						if (num3 != 1467226466U)
						{
							num = (short)1341653094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)591921292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1235746899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_53E;
					case 14:
						num = (short)1576140897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num3 != 1675942070U)
						{
							num = (short)1441529967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1427374138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num3 != 2458097430U)
						{
							num = (short)1222770835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)295043203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_194A;
					case 18:
					{
						num = (short)1547501568;
						short num4 = num;
						if (num3 <= 1143102916U)
						{
							num = (short)972292235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)610599045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (num3 != 1509069118U)
						{
							num = (short)1093730377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1927807069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)304283687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num3 != 2136779761U)
						{
							num = (short)579534860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1841102930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)63242407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1127874730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (num3 <= 3225328704U)
						{
							num = (short)64553051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1413546103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (num3 != 4012723735U)
						{
							num = (short)1143341076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)407634095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)508493959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖觘蓚远뻞藠諢諤铦뿨苪裬飮", a_)))
						{
							num = (short)1401356380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖觘蓚远뻞藠諢諤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_Radios));
						num = (short)1365114914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)2083717139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_600;
					case 30:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖룘꿚볜连鏠賢菤軦藨軪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_)))
						{
							num = (short)1825112066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖룘꿚볜连鏠賢菤軦藨軪黬맮飰雲苴", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_DataProfiles));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖룘꿚볜连鏠賢菤軦藨軪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_DataProfileDetails));
						num = (short)1969881257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)426442865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1643118601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_1B72;
					case 34:
						goto IL_E4C;
					case 35:
						goto IL_15A6;
					case 36:
						goto IL_CF7;
					case 37:
						num = (short)1628110893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (num3 != 1643882096U)
						{
							num = (short)1329856543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1489174578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (num3 != 4274094195U)
						{
							num = (short)840237181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)431489079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.e.Count < 2)
						{
							num = (short)405667921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.RemoveAt(1);
						num = (short)1756299300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_1BE1;
					case 42:
						if (num3 != 3149912935U)
						{
							num = (short)142213173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)16515099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)1207566351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (num3 != 977822851U)
						{
							num = (short)1680998545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)13041725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_1968;
					case 46:
						if (num3 != 491085313U)
						{
							num = (short)978976791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)335806632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_12F8;
					case 48:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚远뻞藠諢諤铦귨軪駬軮飰鿲蛴ꇶ郸黺諼", a_)))
						{
							num = (short)398721098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚远뻞藠諢諤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_Radios));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚远뻞藠諢諤铦귨軪駬軮飰鿲蛴ꇶ郸黺諼", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_RadioDetails));
						num = (short)173080749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_15A1;
					case 50:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖蛘觚룜꿞軠釢釤铦뿨苪裬飮", a_)))
						{
							num = (short)257884197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖蛘觚룜꿞軠釢釤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Reports));
						num = (short)1240662092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						text = text.Substring(0, text.IndexOf(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("", a_)));
						num = (short)252510243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)1433862185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)1518862336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)975241354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖ꃘ꣚꧜뫞賠꟢胤鏦裨苪臬鳮꟰髲郴胶", a_)))
						{
							num = (short)869531794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖ꃘ꣚꧜뫞賠郢돤軦賨鳪", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_Systems));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖ꃘ꣚꧜뫞賠꟢胤鏦裨苪臬鳮꟰髲郴胶", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_SystemDetails));
						num = (short)1775042628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (num3 != 352612821U)
						{
							num = (short)1406468201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1665269761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						num = (short)459735050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蟖ꯘ듚뫜귞胠転裤軦蟨質꟬胮鏰胲", a_)))
						{
							num = (short)1105657882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蟖ꯘ듚뫜귞胠転裤軦蟨質꟬胮鏰胲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Operational));
						num = (short)130875425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)435748872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_11E7;
					case 61:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("飖꧘뻚꿜뻞闠諢諤触裨蟪꟬胮鏰胲", a_)))
						{
							num = (short)1017839781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("飖꧘뻚꿜뻞闠諢諤触裨蟪꟬胮鏰胲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Operational));
						num = (short)847839392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)1759313974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF7;
					case 63:
						goto IL_90F;
					case 64:
						goto IL_69B;
					case 65:
						if (num3 != 2849801469U)
						{
							num = (short)816578718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA7;
					case 66:
						goto IL_5E1;
					case 67:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠뇢蓤菦胨蓪黬맮飰雲苴", a_)))
						{
							num = (short)932773940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠뇢蓤菦胨蓪黬맮飰雲苴", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_Radios));
						num = (short)728039528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_1C94;
					case 69:
						goto IL_4D1;
					case 70:
						num = (short)1503920244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)2020999189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_ADA;
					case 73:
						num = (short)1142161455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1367736477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_1CF7;
					case 76:
						goto IL_1DB4;
					case 77:
						num = (short)907083927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)110231688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_766;
					case 80:
						if (num3 <= 491085313U)
						{
							num = (short)226361467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2066481155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_12FD;
					case 82:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖蛘觚볜믞裠賢ꇤ苦鷨諪蓬菮苰ꗲ鳴鋶軸", a_)))
						{
							num = (short)763101241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖蛘觚볜믞裠賢雤뇦胨軪髬", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_Radios));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖蛘觚볜믞裠賢ꇤ苦鷨諪蓬菮苰ꗲ鳴鋶軸", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_RadioDetails));
						num = (short)1192296544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (num3 != 2198627678U)
						{
							num = (short)1815281807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2084700246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						num = (short)1631518844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (text.Contains(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("", a_)))
						{
							num = (short)1396899891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A6;
					case 86:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚鯜뫞胠韢郤闦賨飪믬蛮铰蓲", a_)))
						{
							num = (short)1659109390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚鯜뫞胠韢郤闦賨飪믬蛮铰蓲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_Features));
						num = (short)2046165052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (num3 != 2665932838U)
						{
							num = (short)2055798884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2121007210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)297599147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)987496557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (num3 != 1143102916U)
						{
							num = (short)870842471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)254869571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						num = (short)1570111553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)1718026245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚鯜뫞胠韢郤闦賨飪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_)))
						{
							num = (short)127008857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚鯜뫞胠韢郤闦賨飪믬蛮铰蓲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_Features));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖闘蓚鯜뫞胠韢郤闦賨飪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLisence_FeatureDetails));
						num = (short)1014431761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						if (num3 != 2506051725U)
						{
							num = (short)706805902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)106299422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						num = (short)161480733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						goto IL_F62;
					case 97:
						goto IL_14F3;
					case 98:
						goto IL_8F1;
					case 99:
					{
						if (num3 <= 1675942070U)
						{
							num = (short)1255211164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1130423878;
						short num5 = num;
						num = (short)2047403590;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CA7;
						default:
							num = (short)1114898432;
							if (num != 0)
							{
							}
							num = (short)447479926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 100:
						num = (short)803340443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						goto IL_362;
					case 102:
						num = (short)197918868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						num = (short)256245824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						goto IL_57E;
					case 105:
						num = (short)1285226542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖蛘觚볜믞裠賢雤뇦胨軪髬", a_)))
						{
							num = (short)717422662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖蛘觚볜믞裠賢雤뇦胨軪髬", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_Radios));
						num = (short)219676751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_1D74;
					case 108:
						if (A_0 != global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("駖뛘꿚黜꫞闠", a_))
						{
							num = (short)627245200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FD;
					case 109:
						goto IL_490;
					case 110:
						num = (short)1331494956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						num = (short)1715666957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						goto IL_C1E;
					case 113:
						if (num3 != 1653145892U)
						{
							num = (short)1677393963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1273757816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						num = (short)670433409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						goto IL_19C5;
					case 116:
						goto IL_10FE;
					case 117:
						goto IL_EFD;
					case 118:
						if (num3 <= 2665932838U)
						{
							num = (short)181731332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2090795032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						if (num3 != 3837870765U)
						{
							num = (short)646250660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)991690914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖觘蓚远뻞藠諢諤ꏦ賨鿪賬蛮鷰胲ꏴ黶鳸賺", a_)))
						{
							num = (short)1598881876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖觘蓚远뻞藠諢諤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_Radios));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖觘蓚远뻞藠諢諤ꏦ賨鿪賬蛮鷰胲ꏴ黶鳸賺", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_RadioDetails));
						num = (short)1954676737;
						if (num != 0)
						{
						}
						num = (short)996147207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						num = (short)21954571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						if (num3 <= 2239454622U)
						{
							num = (short)52035655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2096365584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)1104412728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						goto IL_1188;
					case 125:
						num = (short)1414398102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (num3 != 2239454622U)
						{
							num = (short)1932591253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)395706527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						goto IL_1985;
					case 128:
						num = (short)954859592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						goto IL_783;
					case 130:
						goto IL_1486;
					case 131:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠곢釤蛦鯨믪鿬胮韰髲駴鋶諸귺铼髾瘀", a_)))
						{
							num = (short)992018598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠곢釤蛦鯨믪鿬胮韰髲駴鋶諸귺铼髾瘀", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_OtarProfiles));
						num = (short)834535539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						goto IL_1781;
					case 133:
						if (num3 <= 1509069118U)
						{
							num = (short)1843396729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)339476518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖ꃘ꣚꧜뫞賠郢돤軦賨鳪", a_)))
						{
							num = (short)1982529690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖ꃘ꣚꧜뫞賠郢돤軦賨鳪", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_Systems));
						num = (short)601096261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						goto IL_10E1;
					case 136:
						goto IL_AF7;
					case 137:
						goto IL_12DB;
					case 138:
						if (!A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("高듚돜맞裠蓢郤闦裨鿪蓬胮鿰뫲뇴쫶", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)2135228475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FD;
					case 139:
						num = (short)1236992080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖룘꿚볜连鏠賢菤軦藨軪黬맮飰雲苴", a_)))
						{
							num = (short)804454495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏖룘꿚볜连鏠賢菤軦藨軪黬맮飰雲苴", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile_DataProfiles));
						num = (short)36372578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						num = (short)1419182129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						num = (short)1415905367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						num = (short)1958019198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						num = (short)1085866046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						num = (short)740556890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						num = (short)989986953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						num = (short)573767774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						if (num3 != 1483734528U)
						{
							num = (short)891224092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1172832419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						num = (short)631177279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						goto IL_7E0;
					case 151:
						goto IL_1204;
					case 152:
						goto IL_116A;
					case 153:
						goto IL_B5A;
					case 154:
						num = (short)1671430271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						goto IL_18E5;
					case 156:
						num = (short)220987410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
						goto IL_16B2;
					case 158:
						num = (short)1932918826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("飖꧘뻚꿜뻞闠諢諤触裨蟪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_)))
						{
							num = (short)2092302464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("飖꧘뻚꿜뻞闠諢諤触裨蟪꟬胮鏰胲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Operational));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鷖蛘鿚룜ꯞ胠諢觤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Details));
						num = (short)1346830411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 160:
						goto IL_1EA0;
					case 161:
						num = (short)95092837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蟖ꯘ듚뫜귞胠転裤軦蟨質ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_)))
						{
							num = (short)757203085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蟖ꯘ듚뫜귞胠転裤軦蟨質꟬胮鏰胲", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Programming));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鷖蛘鿚룜ꯞ胠諢觤铦뿨苪裬飮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job_Details));
						num = (short)1018888258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鷖뛘맚껜觞裠蛢鋤", a_)))
						{
							num = (short)490340513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE3;
					case 164:
						num = (short)143654937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						num = (short)859635842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 166:
						num = (short)1111883883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						goto IL_1270;
					case 168:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠곢釤蛦鯨믪鿬胮韰髲駴鋶뷸黺觼黾栀漂瘄儆怈渊稌", a_)))
						{
							num = (short)1865154637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠곢釤蛦鯨믪鿬胮韰髲駴鋶諸귺铼髾瘀", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_OtarProfiles));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠곢釤蛦鯨믪鿬胮韰髲駴鋶뷸黺觼黾栀漂瘄儆怈渊稌", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_OtarProfileDetails));
						num = (short)191365237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						goto IL_455;
					case 170:
						goto IL_472;
					case 171:
						goto IL_CF7;
					case 172:
						num = (short)875888772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 173:
						goto IL_1826;
					case 174:
						goto IL_1F73;
					case 175:
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠뇢蓤菦胨蓪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_)))
						{
							num = (short)381878444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠뇢蓤菦胨蓪黬맮飰雲苴", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_Radios));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖諘迚远郞뻠뇢蓤菦胨蓪ꧬ諮藰鋲鳴鯶諸귺铼髾瘀", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile_RadioDetails));
						num = (short)224985241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F8;
					IL_CA7:
					num = (short)88604678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF7:
					num = (short)1853161512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12FD:
					a_2 = A_0.Split(new char[]
					{
						'?'
					})[0];
					num3 = global::h.a(a_2);
					num = (short)918945891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A6:
					this.ActiveView = text;
					global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖뫘꿚드꧞蓠껢蓤軦蟨ꛪ苬诮蓰鿲郴", a_), this.ActiveMainModule);
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("雖뫘꿚드꧞蓠뗢賤苦黨", a_), this.ActiveView);
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveViewChangedEvent>().Publish(dictionary);
					num = (short)347799660;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_362:
				IL_455:
				IL_472:
				IL_490:
				IL_4D1:
				IL_53E:
				IL_57E:
				IL_5E1:
				IL_600:
				IL_69B:
				IL_766:
				IL_783:
				IL_7E0:
				IL_8F1:
				IL_90F:
				IL_ADA:
				IL_AF7:
				IL_B5A:
				IL_C1E:
				IL_E4C:
				IL_EFD:
				IL_F62:
				IL_10E1:
				IL_10FE:
				IL_116A:
				IL_1188:
				IL_11A6:
				IL_11E7:
				IL_1204:
				IL_1270:
				IL_12DB:
				IL_12F8:
				IL_1486:
				IL_14F3:
				IL_15A1:
				IL_16B2:
				IL_171F:
				IL_1781:
				IL_1826:
				IL_18E5:
				IL_194A:
				IL_1968:
				IL_1985:
				IL_19C5:
				IL_1AE1:
				IL_1B72:
				IL_1BE1:
				IL_1C94:
				IL_1CF7:
				IL_1D74:
				IL_1DB4:
				IL_1EA0:
				IL_1F73:
				IL_1FE3:
				this.a(this.PathSections.ToList<global::System.Collections.Generic.KeyValuePair<string, string>>());
				return;
				IL_2F8:
				text = A_0;
				num = (short)877592661;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000231E8 File Offset: 0x000213E8
		private void b(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> A_0)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					goto IL_64;
				case 1:
					if (num2 >= A_0.Count)
					{
						num3 = (short)1283129351;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					text = A_0[num2].Value;
					num3 = (short)751370241;
					if (num3 != 0)
					{
					}
					num3 = (short)299696130;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_19A;
				case 3:
				{
					num3 = (short)670891641;
					short num4 = num3;
					num3 = (short)1266482809;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19A;
					default:
					{
						num3 = (short)466223104;
						if (num3 != 0)
						{
						}
						num3 = (short)1422065664;
						short num5 = num3;
						text = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铓觕裗ﻙ껛ﯝ藟蓡쟣迥雧鋩", a_) + text;
						num3 = (short)738000896;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_1BB;
				case 5:
					goto IL_1BB;
				case 6:
					num3 = (short)262602760;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					return;
				case 8:
					if (!text.StartsWith(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铓觕裗ﻙ껛ﯝ藟蓡쟣迥雧鋩", a_)))
					{
						num3 = (short)1425670147;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_64;
				}
				goto IL_3D;
				IL_64:
				this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(A_0[num2].Key, text));
				num2++;
				num3 = (short)1756037125;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1BB:
				num3 = (short)1483407361;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_19A:
				if (num2 != 0)
				{
					goto IL_64;
				}
				num3 = (short)258867206;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_3D:
			this.e.Clear();
			num2 = 0;
			num3 = (short)1819475972;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0002343C File Offset: 0x0002163C
		private void a(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> A_0)
		{
			int a_ = 10;
			short num = (short)2012363841;
			short num2 = num;
			num = (short)977419329;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1027145728;
				short num3 = num;
				break;
			}
			}
			num = (short)324796417;
			if (num != 0)
			{
			}
			num = (short)1804468224;
			if (num != 0)
			{
			}
			this.e.Clear();
			int num4 = 0;
			using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator = A_0.GetEnumerator())
			{
				num = (short)1673068550;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						if (num4 != 0)
						{
							num = (short)165347332;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1027014667;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(keyValuePair.Key, keyValuePair.Value));
						num = (short)1813774346;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_14C;
					case 3:
						num = (short)1170997253;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(keyValuePair.Key, keyValuePair.Value));
						num = (short)1726087175;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2E6;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_112;
						}
						continue;
					case 7:
						goto IL_14C;
					case 9:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)721944579;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
						num = (short)1198784512;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_14C;
					case 11:
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						if (keyValuePair.Value.Contains(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳛臝냟웡難쏥跧賩쿫蟭軯諱", a_)))
						{
							num = (short)358088705;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(keyValuePair.Key, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳛臝냟웡難쏥跧賩쿫蟭軯諱", a_) + keyValuePair.Value));
						num = (short)2032926722;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_112;
					IL_14C:
					num4++;
					num = (short)1607794696;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_200:
					num = (short)1407582217;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_112:
					goto IL_200;
				}
				IL_2E6:;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0002375C File Offset: 0x0002195C
		private void a(object A_0)
		{
			short num = (short)1333466090;
			short num2 = num;
			num = (short)1357452266;
			switch (num2 == num)
			{
			}
			num = (short)330891264;
			short num3 = num;
			num = (short)1534132225;
			if (num != 0)
			{
			}
			num = (short)405536768;
			if (num != 0)
			{
			}
			this.PickerVisibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0002380C File Offset: 0x00021A0C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)710541312;
			switch (num)
			{
			default:
			{
				num = (short)664272979;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						num = (short)612499553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诜냞裠胢胤ꛦ蟨藪苬髮鿰郲郴髶鳸闺觼", a_)))
						{
							num = (short)1783037975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ResourceView_Title));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.General_VoiceAnnouncements));
						num = (short)229572624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string[] array = this.d.Split(new char[]
						{
							'?'
						});
						num = (short)1754136620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_5E8;
					case 4:
						goto IL_5E8;
					case 5:
						return;
					case 6:
						num = (short)1478623262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜볞闠諢鏤苦ꓨ諪蓬臮볰鳲釴苶闸黺", a_))
						{
							num = (short)179634244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_5E8;
					case 9:
						num = (short)37027905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_5E8;
					case 11:
						goto IL_5E8;
					case 12:
						num = (short)1789198368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)2018705462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						uint num3;
						if (num3 != 4104333365U)
						{
							num = (short)1531510865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1620312167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_5E8;
					case 16:
						goto IL_5E8;
					case 17:
						goto IL_5E8;
					case 18:
						goto IL_5E8;
					case 19:
					{
						num = (short)1398734848;
						short num4 = num;
						num = (short)397148175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_5E8;
					case 21:
						goto IL_5E8;
					case 22:
						this.a = string.Empty;
						num = (short)1166082149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1315897379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤꏦ裨鿪賬뿮菰鳲鏴黶闸黺", a_)))
						{
							num = (short)1313275960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤꏦ裨鿪賬뿮菰鳲鏴黶闸黺", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTRODataProfile));
						num = (short)301072455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						uint num3;
						if (num3 <= 3361029697U)
						{
							num = (short)228065286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1926561894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_314;
					case 27:
						goto IL_5E8;
					case 28:
						goto IL_5E8;
					case 29:
						num = (short)659947538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						uint num3;
						if (num3 != 2495482549U)
						{
							num = (short)1616052269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2008875051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_5E8;
					case 32:
					{
						uint num3;
						if (num3 != 1450572116U)
						{
							num = (short)2035744810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1571291188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						num = (short)530710531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_5E8;
					case 35:
						goto IL_5E8;
					case 36:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觜뫞賠鏢觤蛦鷨軪", a_)))
						{
							num = (short)849739813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觜뫞賠鏢觤蛦鷨軪", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Template));
						num = (short)2089091106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)474611789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_5E8;
					case 39:
					{
						uint num3;
						if (num3 != 3776259653U)
						{
							num = (short)1860894818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)56623194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						num = (short)1889206280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)544342067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)839843844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("黜點ꋠ蛢韤鏦胨跪蓬賮郰蟲郴蓶", a_)))
						{
							num = (short)2011430931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ResourceView_Title));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.General_CACertificates));
						num = (short)1666711572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						string[] array;
						if (array.Length == 2)
						{
							num = (short)1943994450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1336;
					}
					case 45:
						num = (short)1257111640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)1485963360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						uint num3;
						if (num3 != 3361029697U)
						{
							num = (short)984219741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1309671448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_5E8;
					case 49:
						goto IL_5E8;
					case 50:
						if (this.a == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("關냞賠蛢", a_))
						{
							num = (short)1198325782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D33;
					case 51:
					{
						uint num3;
						if (num3 != 2313466252U)
						{
							num = (short)1547632731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2136080471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远뻞藠諢諤", a_)))
						{
							num = (short)1005453352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远뻞藠諢諤", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Radio));
						num = (short)261947423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						num = (short)569114686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						uint num3;
						if (num3 <= 1450572116U)
						{
							num = (short)246808637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1385889871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						text = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("關냞賠蛢돤軦賨鳪", a_);
						num = (short)1823866956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)1254031409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						uint num3;
						if (num3 <= 2313466252U)
						{
							num = (short)1894842381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1930035225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						uint num3;
						if (num3 != 1121529980U)
						{
							num = (short)503513100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)254279785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (this.d != null)
						{
							num = (short)2057633794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1336;
					case 60:
						num = (short)1567359034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)533790789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_5E8;
					case 63:
						num = (short)1879310346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)2033909849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_5E8;
					case 66:
						goto IL_5E8;
					case 67:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("釜뻞迠蓢郤蛦軨軪뷬軮鋰飲", a_)))
						{
							num = (short)1244463150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ResourceView_Title));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.General_LanguagePacks));
						num = (short)591331339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
					{
						this.e.Clear();
						string a_2 = this.a;
						uint num3 = global::h.a(a_2);
						num = (short)1974206521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
					{
						uint num3;
						if (num3 != 1119240004U)
						{
							num = (short)1340014652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)229376104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						num = (short)828178516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						goto IL_5E8;
					case 72:
						goto IL_5E8;
					case 73:
						num = (short)1082261542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_5E8;
					case 75:
						goto IL_5E8;
					case 76:
						goto IL_1336;
					case 77:
						goto IL_5E8;
					case 78:
						num = (short)1440546922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						uint num3;
						if (num3 != 1704356651U)
						{
							num = (short)1814757376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)726859812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
						if (this.a == string.Empty)
						{
							num = (short)1891434497;
							if (num != 0)
							{
							}
							num = (short)1224343607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = this.a + global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郜뻞裠跢돤軦賨鳪", a_);
						num = (short)143917115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)1992097884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
					{
						string[] array;
						text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛜ鳠\udce2黤훦铨", a_), text, array[1]);
						num = (short)2121269343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						switch (0)
						{
						case 0:
							goto IL_1F8;
						}
						continue;
					case 84:
					{
						uint num3;
						if (num3 != 3687800990U)
						{
							num = (short)934543424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)353304577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("远뻞藠諢諤ꯦ胨裪裬臮苰雲", a_)))
						{
							num = (short)1917059145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_RadioLicence));
						num = (short)1433534492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						num = (short)2038104136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鯜뛞鏠転鋤蛦鯨軪", a_)))
						{
							num = (short)969146446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ResourceView_Title));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.General_Firmware));
						num = (short)1151533077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
					{
						num = (short)949744292;
						short num5 = num;
						num = (short)795275940;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_314;
						default:
						{
							num = (short)1015808000;
							if (num != 0)
							{
							}
							uint num3;
							if (num3 != 2536692479U)
							{
								num = (short)1555890202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)572063829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 89:
					{
						uint num3;
						if (num3 != 3724606214U)
						{
							num = (short)109772809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1586561091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤ듦部飪駬諮鳰", a_)))
						{
							num = (short)1212284991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤ듦部飪駬諮鳰", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem));
						num = (short)1837891650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
						num = (short)625082442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						goto IL_5E8;
					case 93:
						num = (short)1806106672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						goto IL_5E8;
					case 95:
						goto IL_1336;
					case 96:
						goto IL_5E8;
					case 97:
					{
						uint num3;
						if (num3 != 2036726955U)
						{
							num = (short)348717097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1663238244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 98:
						num = (short)184549390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						return;
					case 100:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("駜觞돠냢ꏤ軦藨軪黬", a_)))
						{
							num = (short)1199767638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ResourceView_Title));
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.General_DVRS_Files));
						num = (short)1834090571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 101:
						goto IL_D33;
					case 102:
					{
						uint num3;
						if (num3 <= 3724606214U)
						{
							num = (short)283312198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)117768231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤ꣦鷨諪鿬뿮菰鳲鏴黶闸黺", a_)))
						{
							num = (short)761266205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜賞뗠뇢ꫤ꣦鷨諪鿬뿮菰鳲鏴黶闸黺", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROOtarProfile));
						num = (short)1431830545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳜꿞釠迢賤蓦裨鿪蓬胮鿰뿲鳴银鳸闺軼髾", a_)))
						{
							num = (short)189923381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ApplicationLicence));
						num = (short)2047148126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
					{
						string a_2;
						if (!(a_2 == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("韜냞菠", a_)))
						{
							num = (short)369360929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(string.Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_Job));
						num = (short)64290843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 106:
						goto IL_5E8;
					}
					IL_1F8:
					if (this.s)
					{
						num = (short)1969618949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)699400199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_314:
					num = (short)1871446063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E8:
					this.a(this.PathSections.ToList<global::System.Collections.Generic.KeyValuePair<string, string>>());
					num = (short)176422962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D33:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule = this.a;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage = this.a;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
					text = string.Empty;
					num = (short)388235344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1336:
					this.s = true;
					base.RegionManager.RequestNavigate(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郜뻞裠跢럤苦軨苪苬臮", a_), new global::System.Uri(text, global::System.UriKind.Relative), new global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult>(this.a));
					num = (short)756023395;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00024BA0 File Offset: 0x00022DA0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Microsoft.Practices.Prism.Regions.NavigationResult A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			short num;
			int num3;
			bool? result;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)2126577664;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (result.GetValueOrDefault() == flag & result != null)
					{
						num = (short)19595270;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = A_0.Result;
					flag = false;
					num = (short)912523269;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1089208321;
					if (num != 0)
					{
					}
					if (A_0.Error != null)
					{
						num = (short)1558380548;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)409337857;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
				{
					num = (short)333653667;
					short num4 = num;
					num = (short)1072113315;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1164574720;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(A_0.Error, true, false);
						num = (short)1382350851;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (result.GetValueOrDefault() == flag & result != null)
					{
						num = (short)1400045570;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_A7;
				}
				goto IL_54;
			}
			IL_A7:
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveMainModuleChangedEvent>().Publish(this.a);
			base.CommandProxy.AddGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.AddSetCommand.RaiseCanExecuteChanged();
			base.CommandProxy.DeleteConfigurationsCommand.RaiseCanExecuteChanged();
			base.CommandProxy.DeleteGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ExportDVRSCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ExportRadioCommand.RaiseCanExecuteChanged();
			base.CommandProxy.MoveDeviceCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareAddConfigurationCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareCopyConfigurationCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareAddRadioCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportFileToGridCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ImportFromConsoleCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportFirmwaresCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportLanguagePacksCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportRadiosCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportTemplatesCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportVoiceAnnouncementsCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportCACertificatesCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareImportDVRSFilesCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareMoveDeviceCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareRenameGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareResetIdentifiersCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSaveAsSetCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSaveAsSetInConfigurationCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareScheduleJobCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSelectFirmwareCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSelectFlashPortCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrintViewCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrintViewPreviewCommand.RaiseCanExecuteChanged();
			base.CommandProxy.RestoreRadioCommand.RaiseCanExecuteChanged();
			base.CommandProxy.SaveConfigurationCommand.RaiseCanExecuteChanged();
			base.CommandProxy.SaveSetCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ShowRadioDetailsCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareUploadSystemKeysCommand.RaiseCanExecuteChanged();
			base.CommandProxy.HelpCommand.RaiseCanExecuteChanged();
			return;
			IL_54:
			this.s = false;
			result = A_0.Result;
			flag = true;
			num = (short)134152192;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000142 RID: 322
		private string a;

		// Token: 0x04000143 RID: 323
		private string b;

		// Token: 0x04000144 RID: 324
		private string c;

		// Token: 0x04000145 RID: 325
		private string d;

		// Token: 0x04000146 RID: 326
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>> e;

		// Token: 0x04000147 RID: 327
		private global::System.Collections.Generic.List<string> f;

		// Token: 0x04000148 RID: 328
		private global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle g;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Visibility h;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Visibility i;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Visibility j;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Visibility k;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Visibility l;

		// Token: 0x0400014E RID: 334
		private bool m;

		// Token: 0x0400014F RID: 335
		private int n;

		// Token: 0x04000150 RID: 336
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o;

		// Token: 0x04000151 RID: 337
		private const string p = "@_P$r%ef#i~x";

		// Token: 0x04000152 RID: 338
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> q;

		// Token: 0x04000153 RID: 339
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> r;

		// Token: 0x04000154 RID: 340
		private bool s;
	}
}
