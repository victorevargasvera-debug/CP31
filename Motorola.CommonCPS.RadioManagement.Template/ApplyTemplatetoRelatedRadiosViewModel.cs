using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000E RID: 14
	public class ApplyTemplatetoRelatedRadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00009A20 File Offset: 0x00007C20
		public ApplyTemplatetoRelatedRadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext) : base(eventAggregator, commandHandler)
		{
			this.ApplyTemplatetoRelatedRadiosContext = applyTemplatetoRelatedRadiosContext;
			this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.CollectionChanged += this.a;
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectRelatedRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.ApplyTemplatetoRelatedRadiosContext.PropertyChanged += this.a;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009AC0 File Offset: 0x00007CC0
		private void a(object[] A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair item;
			short num;
			for (;;)
			{
				item = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair);
				if ((bool)A_0[1])
				{
					num = (short)1342974762;
					short num2 = num;
					num = (short)658320170;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_78;
					}
					break;
				}
				goto IL_C7;
			}
			num = (short)1142816768;
			short num3 = num;
			IL_78:
			num = (short)209059841;
			if (num != 0)
			{
			}
			num = (short)1568473088;
			if (num != 0)
			{
			}
			this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Remove(item);
			return;
			IL_C7:
			this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Add(item);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009BA8 File Offset: 0x00007DA8
		private void b()
		{
			short num;
			try
			{
				num = (short)918533298;
				short num2 = num;
				num = (short)930395314;
				switch (num2 == num)
				{
				}
				num = (short)757530624;
				if (num != 0)
				{
				}
				base.CommandHandler.ApplyTemplatetoRelatedRadiosCommand.Execute(new object[]
				{
					this.ApplyTemplatetoRelatedRadiosContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ApplyTemplatetoRelatedRadiosContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)888143872;
			short num3 = num;
			num = (short)1193869313;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009CA4 File Offset: 0x00007EA4
		private void a(object A_0)
		{
			short num = (short)507510784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> observableCollectionFast;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> list2;
				object[] array;
				for (;;)
				{
					IL_28:
					num = (short)1657405440;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_F0;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
						enumerator = list.GetEnumerator();
						num = (short)431882251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						bool? flag = (bool?)A_0;
						bool flag2 = true;
						num = (short)1816002568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_34D;
					case 4:
						goto IL_1CC;
					case 5:
					{
						if (observableCollectionFast == null)
						{
							num = (short)386793473;
							if (num != 0)
							{
							}
							num = (short)1514143745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
						enumerator = list.GetEnumerator();
						num = (short)1671102464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (array == null)
						{
							num = (short)1106640898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag3 = (bool?)array[0];
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list = array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>;
						bool? flag = flag3;
						bool flag2 = true;
						num = (short)1519190023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)87556105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Clear();
						num = (short)197263370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1506213891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F7;
					}
					case 9:
						observableCollectionFast = (this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>);
						num = (short)370606085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_3A5;
					case 11:
						try
						{
							num = (short)117112832;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12F;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1430978562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
									this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair);
									num = (short)604504067;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)144244740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1B9;
								}
								IL_168:
								num = (short)870187009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12F:
								goto IL_168;
							}
							IL_1B9:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					}
					goto IL_87;
					IL_34D:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> enumerator2 = this.ApplyTemplatetoRelatedRadiosContext.RadioPairs.GetEnumerator();
					num = (short)1849360388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_1CC:
						num = (short)1690959872;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_208;
								}
								continue;
							case 1:
								num = (short)1201012740;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)2010251265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair item = enumerator2.Current;
								this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Add(item);
								num = (short)1737972495;
								short num4 = num;
								num = (short)307190543;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2DC;
								default:
									num = (short)1745420288;
									if (num != 0)
									{
									}
									num = (short)1489371138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_2DC;
							}
							IL_20A:
							num = (short)2004877315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_208:
							goto IL_20A;
						}
						IL_2DC:
						return;
					}
					finally
					{
						num = (short)1395130369;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)1359806466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_313;
								}
								continue;
							case 2:
								goto IL_34A;
							}
							IL_313:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)1582759936;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_34A:;
					}
					goto IL_34D;
				}
				IL_F0:
				try
				{
					num = (short)1885667328;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_465;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)644022274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase2 = enumerator.Current;
							list2.Add(uimodelBase2 as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair);
							num = (short)278462467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)2024472580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_4E4;
						}
						IL_496:
						num = (short)113377281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_465:
						goto IL_496;
					}
					IL_4E4:
					goto IL_421;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_4F7;
				IL_421:
				observableCollectionFast.Reset(list2);
				return;
				IL_3A5:
				return;
				IL_4F7:
				this.ApplyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Clear();
				return;
				IL_87:
				array = (A_0 as object[]);
				num = (short)240451590;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000A2E8 File Offset: 0x000084E8
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1883580195;
				short num2 = num;
				num = (short)1897080611;
				switch (num2 == num)
				{
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ApplyTemplatetoRelatedRadiosCommand.CanExecute(new object[]
				{
					this.ApplyTemplatetoRelatedRadiosContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1060700161;
			if (num != 0)
			{
			}
			num = (short)477954048;
			short num3 = num;
			return result;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000A3D0 File Offset: 0x000085D0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000A480 File Offset: 0x00008680
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext ApplyTemplatetoRelatedRadiosContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2000469633;
				short num2 = num;
				num = (short)99139201;
				switch (num2 == num)
				{
				}
				num = (short)5832704;
				short num3 = num;
				num = (short)1707343872;
				if (num != 0)
				{
				}
				num = (short)347406337;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)404717047;
				short num2 = num;
				num = (short)1777958391;
				switch (num2 == num)
				{
				}
				num = (short)231538688;
				short num3 = num;
				num = (short)427098113;
				if (num != 0)
				{
				}
				num = (short)599130112;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000A530 File Offset: 0x00008730
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)493223937;
				if (num != 0)
				{
				}
				num = (short)1981238094;
				short num2 = num;
				num = (short)1111771982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1793196032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599209472;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1603105995;
				short num2 = num;
				num = (short)1064465611;
				switch (num2 == num)
				{
				}
				num = (short)470810624;
				short num3 = num;
				num = (short)1603665921;
				if (num != 0)
				{
				}
				num = (short)1413677056;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000A68C File Offset: 0x0000888C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000A73C File Offset: 0x0000893C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectRelatedRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2074792591;
				short num2 = num;
				num = (short)289854095;
				switch (num2 == num)
				{
				}
				num = (short)642711552;
				short num3 = num;
				num = (short)261095424;
				if (num != 0)
				{
				}
				num = (short)1527054337;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1144173385;
				short num2 = num;
				num = (short)607630153;
				switch (num2 == num)
				{
				}
				num = (short)283115520;
				short num3 = num;
				num = (short)1343225857;
				if (num != 0)
				{
				}
				num = (short)1338966016;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000A7EC File Offset: 0x000089EC
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000A89C File Offset: 0x00008A9C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)415534860;
				short num2 = num;
				num = (short)268209932;
				switch (num2 == num)
				{
				}
				num = (short)31195136;
				short num3 = num;
				num = (short)231735296;
				if (num != 0)
				{
				}
				num = (short)1849229313;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)129564673;
				if (num != 0)
				{
				}
				num = (short)1281634051;
				short num2 = num;
				num = (short)1021390595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003238912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700659200;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A94C File Offset: 0x00008B4C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)629139201;
			short num2 = num;
			num = (short)1537468161;
			switch (num2 == num)
			{
			}
			num = (short)546701312;
			short num3 = num;
			num = (short)1494220800;
			if (num != 0)
			{
			}
			num = (short)1344143361;
			if (num != 0)
			{
			}
			this.ApplyTemplatetoRelatedRadiosContext.ExceptionMessage = string.Empty;
			this.SelectRelatedRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000AA10 File Offset: 0x00008C10
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 1;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("냴迶髸黺跼课栀氂欄䨆氈砊縌渎瘐瘒", a_))
			{
				short num = (short)1882128385;
				if (num != 0)
				{
				}
				num = (short)274908057;
				short num2 = num;
				num = (short)222872473;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C5;
				case 1:
					break;
				default:
				{
					num = (short)324075520;
					short num3 = num;
					break;
				}
				}
				num = (short)2097545216;
				if (num != 0)
				{
				}
				return;
			}
			IL_C5:
			this.ApplyTemplatetoRelatedRadiosContext.ExceptionMessage = string.Empty;
			this.SelectRelatedRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x04000037 RID: 55
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext a;

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
