using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000048 RID: 72
	public abstract class NavigatedTableViewModelBase<T, U> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<U> where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase where U : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0001C298 File Offset: 0x0001A498
		public NavigatedTableViewModelBase()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		public NavigatedTableViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0001C370 File Offset: 0x0001A570
		public global::System.Collections.ObjectModel.ObservableCollection<T> NavigationItems
		{
			get
			{
				short num = (short)195706998;
				short num2 = num;
				num = (short)1145061494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488060416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532021249;
				if (num != 0)
				{
				}
				num = (short)164036608;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1380909058;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)368176167;
						short num3 = num;
						num = (short)299559975;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1003487232;
							short num4 = num;
							num = (short)1547501568;
							if (num != 0)
							{
							}
							num = (short)1054277633;
							if (num != 0)
							{
							}
							this.a = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<T>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<T>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<T, U>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<T, U>.get_NavigationItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)967835648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
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
						break;
					}
					num = (short)1231159297;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0001C574 File Offset: 0x0001A774
		public virtual T SelectedNavigationItem
		{
			get
			{
				short num = (short)717402945;
				short num2 = num;
				num = (short)495694657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1823735808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)352714753;
				if (num != 0)
				{
				}
				num = (short)530382848;
				if (num != 0)
				{
				}
				return this.selectedNavigationItem;
			}
			set
			{
				short num = (short)1933377538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1473922278;
						short num3 = num;
						num = (short)433407206;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)506789888;
							short num4 = num;
							num = (short)146604033;
							if (num != 0)
							{
							}
							num = (short)1821310976;
							if (num != 0)
							{
							}
							this.selectedNavigationItem = value;
							base.RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<T, U>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<T, U>.get_SelectedNavigationItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.SaveLastSelectedItemSetting<T>(this.selectedNavigationItem);
							num = (short)432930816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (object.Equals(value, this.selectedNavigationItem))
					{
						break;
					}
					num = (short)780861441;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001C6EC File Offset: 0x0001A8EC
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)1924857856;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_E7;
				case 1:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("甥䴧䘩䤫䴭䐯圱倳砵夷䰹唻夽ℿ㙁ⵃ⥅♇͉㡋⭍㵏", a_))
					{
						num = (short)727646210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				case 2:
					IL_9E:
					num = (short)1857880065;
					if (num != 0)
					{
					}
					base.LoadItems();
					num = (short)1617362944;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
				IL_E7:
				num = (short)777566011;
				short num4 = num;
				num = (short)800962363;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9E;
				default:
					goto IL_11B;
				}
			}
			IL_11B:
			num = (short)1344602112;
			if (num != 0)
			{
			}
			return;
			IL_4E:
			base.OnPropertyChanged(sender, e);
			num = (short)1059323905;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060001F5 RID: 501
		protected abstract global::System.ComponentModel.ICollectionView GetItems(T selectedNavigationItem);

		// Token: 0x060001F6 RID: 502 RVA: 0x0001C82C File Offset: 0x0001AA2C
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)123094203;
			short num2 = num;
			num = (short)1398752443;
			switch (num2 == num)
			{
			}
			num = (short)696909824;
			if (num != 0)
			{
			}
			num = (short)416481281;
			if (num != 0)
			{
			}
			num = (short)1642790912;
			short num3 = num;
			return this.GetItems(this.selectedNavigationItem);
		}

		// Token: 0x040000D9 RID: 217
		private global::System.Collections.ObjectModel.ObservableCollection<T> a;

		// Token: 0x040000DA RID: 218
		protected T selectedNavigationItem;
	}
}
