using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000023 RID: 35
	public class ResourceGroupViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public ResourceGroupViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectResourceRequestedEvent>().Subscribe(new global::System.Action<string>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadResourceRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000114EC File Offset: 0x0000F6EC
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> NavigationItems
		{
			get
			{
				short num = (short)1389232129;
				if (num != 0)
				{
				}
				if (this.a != null)
				{
					num = (short)2087418456;
					short num2 = num;
					num = (short)1672903256;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1815281664;
						short num3 = num;
						num = (short)1968373760;
						if (num != 0)
						{
						}
						return this.a;
					}
					}
				}
				this.a = base.ServiceProxy.LocalService.LoadRMResources();
				return this.a;
			}
			set
			{
				short num = (short)955449346;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)774565877;
						short num3 = num;
						num = (short)513667061;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_65;
						default:
							goto IL_104;
						}
						break;
					}
					case 1:
						this.a = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel.get_NavigationItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1895235584;
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
					goto IL_31;
					IL_65:
					num = (short)1311965185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31:
					num = (short)492896257;
					if (num != 0)
					{
					}
					if (value != this.a)
					{
						goto IL_65;
					}
					goto IL_11D;
				}
				IL_104:
				num = (short)469434368;
				if (num != 0)
				{
				}
				IL_11D:
				num = (short)254672896;
				short num4 = num;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001171C File Offset: 0x0000F91C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000117C8 File Offset: 0x0000F9C8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource SelectedNavigationItem
		{
			get
			{
				short num = (short)1146578255;
				short num2 = num;
				num = (short)586310991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1458176000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1744306176;
				if (num != 0)
				{
				}
				num = (short)2140143617;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 10;
				short num = (short)2087911424;
				switch (num)
				{
				default:
				{
					num = (short)405995533;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<string> list;
							string item;
							list.Add(item);
							base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleCouldCancelEvent>().Publish(list);
							num = (short)103809027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							num = (short)1533476864;
							short num3 = num;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource rmresource;
							if (rmresource.Name == global::Motorola.CommonCPS.ResourceRepository.Resources.General_HomeSets)
							{
								num = (short)2139226128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_33C;
						}
						case 2:
							goto IL_38A;
						case 3:
							goto IL_38C;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource rmresource = this.b;
							this.b = value;
							string item = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ConvertResourceNameToModuleName(this.SelectedNavigationItem.Name);
							base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FocusMainModuleRequestedEvent>().Publish(null);
							global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
							num = (short)213975049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource rmresource;
							if (rmresource == null)
							{
								num = (short)2081357830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1521549323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							return;
						case 7:
							if (value != this.b)
							{
								num = (short)2121269252;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 8:
						{
							global::System.Collections.Generic.List<string> list;
							if (list[1] == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鿛뿝軟臡臣諥跧軩", a_))
							{
								num = (short)1203240975;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_33C;
						}
						case 9:
						{
							string item;
							if (item != string.Empty)
							{
								num = (short)607191040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38C;
						}
						case 10:
							goto IL_33C;
						case 11:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count > 1)
							{
								num = (short)1011286028;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_33C;
						}
						case 12:
							num = (short)597360648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_90;
							}
							continue;
						case 14:
							goto IL_AC;
						case 15:
						{
							num = (short)1538160317;
							short num4 = num;
							num = (short)1940354749;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_AC;
							default:
								num = (short)1677328384;
								if (num != 0)
								{
								}
								num = (short)979238913;
								if (num != 0)
								{
								}
								num = (short)201850881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource rmresource;
							this.a.Remove(rmresource);
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource item2 = new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
							{
								Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_HomeSets
							};
							this.a.Add(item2);
							this.b = item2;
							num = (short)1930952714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_90:
						if (value != null)
						{
							num = (short)1505624078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_AC:
						num = (short)287440903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_33C:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel.get_SelectedNavigationItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)480968706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38C:
						num = (short)1378222085;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_38A:
					return;
				}
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		private void b(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource rmresource;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)615930338;
					short num3 = num2;
					num2 = (short)20077026;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					default:
						goto IL_10C;
					}
					break;
				}
				case 1:
					this.b = rmresource;
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel.get_SelectedNavigationItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num2 = (short)1027407872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_66;
				}
				goto IL_1C;
				IL_66:
				if (rmresource == null)
				{
					return;
				}
				num2 = (short)1002307585;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10C:
			num2 = (short)1381892096;
			if (num2 != 0)
			{
			}
			num2 = (short)718405633;
			if (num2 != 0)
			{
			}
			num2 = (short)1845100544;
			short num4 = num2;
			return;
			IL_1C:
			global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel.a a = new global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel.a();
			a.a = A_0;
			a.b = this;
			rmresource = this.NavigationItems.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource, bool>(a.c)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>().FirstOrDefault<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>();
			num2 = (short)2095316994;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00011D54 File Offset: 0x0000FF54
		private void a(string A_0)
		{
			short num = (short)1038778430;
			short num2 = num;
			num = (short)435388478;
			switch (num2 == num)
			{
			default:
			{
				num = (short)188547072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2111242240;
			if (num != 0)
			{
			}
			num = (short)1955790849;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000B7 RID: 183
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> a;

		// Token: 0x040000B8 RID: 184
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource b;

		// Token: 0x02000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000ED RID: 237 RVA: 0x00011E10 File Offset: 0x00010010
			internal bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource A_0)
			{
				short num = (short)87912884;
				short num2 = num;
				num = (short)1110143412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1327431680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1716518913;
				if (num != 0)
				{
				}
				num = (short)362938368;
				if (num != 0)
				{
				}
				return A_0.Name == this.a;
			}

			// Token: 0x040000B9 RID: 185
			public string a;

			// Token: 0x040000BA RID: 186
			public global::Motorola.CommonCPS.RadioManagement.Common.ResourceGroupViewModel b;
		}
	}
}
