using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x0200000C RID: 12
	[global::System.ComponentModel.Composition.Export]
	public class JobsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000422C File Offset: 0x0000242C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public JobsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.DeleteJobsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(this.a));
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000427C File Offset: 0x0000247C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004330 File Offset: 0x00002530
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteJobsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1771305590;
				short num2 = num;
				num = (short)1190984310;
				switch (num2 == num)
				{
				}
				num = (short)1802174464;
				short num3 = num;
				num = (short)1946615809;
				if (num != 0)
				{
				}
				num = (short)939130880;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)347849875;
				short num2 = num;
				num = (short)2139473043;
				switch (num2 == num)
				{
				}
				num = (short)2038366208;
				short num3 = num;
				num = (short)986710017;
				if (num != 0)
				{
				}
				num = (short)101515264;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000043E0 File Offset: 0x000025E0
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000448C File Offset: 0x0000268C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> ShowDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)672261447;
				short num2 = num;
				num = (short)1568859463;
				switch (num2 == num)
				{
				}
				num = (short)68616192;
				short num3 = num;
				num = (short)1396965376;
				if (num != 0)
				{
				}
				num = (short)1145634817;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1468268545;
				if (num != 0)
				{
				}
				num = (short)1441077574;
				short num2 = num;
				num = (short)53811526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194838528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322582016;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000453C File Offset: 0x0000273C
		private void b()
		{
			short num;
			try
			{
				num = (short)582724346;
				short num2 = num;
				num = (short)514632442;
				switch (num2 == num)
				{
				}
				num = (short)1479016448;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.DeleteJobContainerCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)257032192;
			short num3 = num;
			num = (short)884604929;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004628 File Offset: 0x00002828
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0)
		{
			int a_ = 6;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("引尗✙", a_) + A_0.ID.ToString());
			list.Add(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("堕礗眙礛⌝", a_) + A_0.ContainerName);
			if (A_0.ForReadWrite)
			{
				short num = (short)776361011;
				short num2 = num;
				num = (short)1981174835;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)814415872;
					short num3 = num;
					num = (short)1111556097;
					if (num != 0)
					{
					}
					num = (short)1722613760;
					if (num != 0)
					{
					}
					break;
				}
				}
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䘕樗甙笛氝䄟伡䤣伥䘧䴩栫䬭䐯匱崳娵䬷氹唻嬽㜿", a_), list);
				return;
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("夕栗缙減缝吟䬡䬣䠥䤧䘩栫䬭䐯匱崳娵䬷氹唻嬽㜿", a_), list);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004760 File Offset: 0x00002960
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)252786349;
				short num2 = num;
				num = (short)786183853;
				switch (num2 == num)
				{
				}
				num = (short)1265500160;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.DeleteJobContainerCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)239140864;
			short num3 = num;
			num = (short)250675201;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004850 File Offset: 0x00002A50
		protected override void Refresh()
		{
			short num = (short)1405222913;
			if (num != 0)
			{
			}
			num = (short)1473860531;
			short num2 = num;
			num = (short)1213682611;
			switch (num2 == num)
			{
			default:
			{
				num = (short)103350272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)361103360;
			if (num != 0)
			{
			}
			this.a(this.a);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004904 File Offset: 0x00002B04
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)199876274;
			short num2 = num;
			num = (short)2127683250;
			switch (num2 == num)
			{
			}
			num = (short)532480000;
			short num3 = num;
			num = (short)1891827712;
			if (num != 0)
			{
			}
			num = (short)1316421633;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000049B0 File Offset: 0x00002BB0
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1567855272;
			short num2 = num;
			num = (short)1541968552;
			switch (num2 == num)
			{
			}
			num = (short)216465408;
			short num3 = num;
			num = (short)1699348481;
			if (num != 0)
			{
			}
			num = (short)669188096;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
			this.DeleteJobsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004A68 File Offset: 0x00002C68
		protected override bool IsGoingToDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 8;
			string text = navigationContext.Uri.ToString();
			if (!text.StartsWith(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("圗標礛氝䄟嘡䴣䤥䘧䬩䀫樭唯䘱唳張吷䤹樻圽┿㕁", a_), global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num = (short)19267585;
				if (num != 0)
				{
				}
				num = (short)217725094;
				short num2 = num;
				num = (short)449329318;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CE;
				case 1:
					break;
				default:
				{
					num = (short)154599424;
					short num3 = num;
					break;
				}
				}
				num = (short)905838592;
				if (num != 0)
				{
				}
				IL_CE:
				return text.StartsWith(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䠗栙猛礝刟䌡䤣䬥䄧䐩䬫樭唯䘱唳張吷䤹樻圽┿㕁", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004B5C File Offset: 0x00002D5C
		protected override bool IsComingBackFromDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1193541633;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					string text;
					if (text == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("伞匠䰢䈤唦䠨䘪䀬䘮弰吲焴制䴸娺吼匾㉀ᕂⱄ≆㹈", a_))
					{
						num2 = (short)1431109635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 2:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("倞儠䘢圤䘦崨䈪䈬䄮倰弲焴制䴸娺吼匾㉀ᕂⱄ≆㹈", a_)))
					{
						num2 = (short)1669332992;
						short num3 = num2;
						num2 = (short)115015680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					goto IL_16D;
				}
				goto IL_29;
			}
			IL_16D:
			return true;
			IL_29:
			num2 = (short)2073658450;
			short num4 = num2;
			num2 = (short)1996194898;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num2 = (short)596180992;
				if (num2 != 0)
				{
				}
				num2 = (short)301596673;
				if (num2 != 0)
				{
				}
				string text = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䰞丠嘢圤䐦䰨紪䐬䨮䘰", a_)];
				num2 = (short)1285160962;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004CDC File Offset: 0x00002EDC
		private void a(global::Motorola.CommonCPS.RadioManagement.Job.FilterOption A_0)
		{
			short num;
			try
			{
				num = (short)1258815495;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1084096520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_0 != global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Programming)
						{
							num = (short)938999808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetJobContainers(true));
						num = (short)1315241988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1A4;
					case 3:
						goto IL_1CE;
					case 4:
						goto IL_1A4;
					case 5:
					{
						num = (short)1546304466;
						short num3 = num;
						num = (short)1261419474;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11F;
						default:
							num = (short)464584704;
							if (num != 0)
							{
							}
							goto IL_1A4;
						}
						break;
					}
					case 6:
						goto IL_11F;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_48;
						}
						continue;
					case 8:
						base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetJobContainers());
						num = (short)1443561474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_48:
					if (A_0 != global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Operational)
					{
						num = (short)2089549830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetJobContainers(false));
					num = (short)183107589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F:
					num = (short)796590081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ResetOptionFilterForJobViewEvent>().Publish(true);
					num = (short)1670905859;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CE:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1254686720;
			short num4 = num;
			num = (short)17956865;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F30 File Offset: 0x00003130
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Job.FilterOption filterOption;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)147564663;
					short num3 = num2;
					num2 = (short)1842849911;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						goto IL_172;
					}
					break;
				}
				case 1:
					if (this.a.Equals(filterOption))
					{
						num2 = (short)1798307840;
						short num4 = num2;
						num2 = (short)1310195712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 2:
					num2 = (short)328400899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.Items == null)
					{
						num2 = (short)130482181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1776353281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_7B;
				case 5:
					goto IL_1D9;
				}
				goto IL_31;
				IL_7B:
				if (!this.IsComingBackFromDetail(navigationContext))
				{
					goto IL_189;
				}
				num2 = (short)167182337;
				if (num2 != 0)
				{
				}
				num2 = (short)177537026;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_172:
			num2 = (short)685899776;
			if (num2 != 0)
			{
			}
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ResetOptionFilterForJobViewEvent>().Publish(true);
			base.RaisePropertyChanged<global::System.ComponentModel.ICollectionView>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.ComponentModel.ICollectionView>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Job.JobsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>.get_Items())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Job.JobsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>.get_SelectedItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			this.OnSelectedItemsCollectionChanged();
			return;
			IL_189:
			this.a = filterOption;
			this.a(this.a);
			return;
			IL_1D9:
			goto IL_189;
			IL_265:
			this.a = filterOption;
			this.a(this.a);
			return;
			IL_31:
			base.OnNavigatedTo(navigationContext);
			filterOption = (global::Motorola.CommonCPS.RadioManagement.Job.FilterOption)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.RadioManagement.Job.FilterOption), navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("唒簔笖洘縚漜倞儠圢䰤䠦䜨", a_)]);
			num2 = (short)1579220996;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0400001B RID: 27
		private global::Motorola.CommonCPS.RadioManagement.Job.FilterOption a;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> c;
	}
}
