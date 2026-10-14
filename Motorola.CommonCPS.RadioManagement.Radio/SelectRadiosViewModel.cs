using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000022 RID: 34
	public class SelectRadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600019B RID: 411 RVA: 0x0001DE38 File Offset: 0x0001C038
		public SelectRadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext selectRadiosContext) : base(eventAggregator, commandHandler)
		{
			this.SelectRadiosContext = selectRadiosContext;
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.ConfirmCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(this.b));
			this.SelectRadiosContext.PropertyChanged += this.a;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001DF6C File Offset: 0x0001C16C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1058416253;
				short num2 = num;
				num = (short)2131240573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)726401024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)637272065;
				if (num != 0)
				{
				}
				num = (short)1026949120;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1092036532;
				short num2 = num;
				num = (short)1809065908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1410465792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601358337;
				if (num != 0)
				{
				}
				num = (short)1616773120;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001E020 File Offset: 0x0001C220
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0001E0D4 File Offset: 0x0001C2D4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ConfirmCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1465360651;
				short num2 = num;
				num = (short)1412210955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)252510208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)246218753;
				if (num != 0)
				{
				}
				num = (short)2141192192;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)362872833;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				short num2 = num;
				num = (short)1950803456;
				short num3 = num;
				num = (short)655746560;
				switch (num3 == num)
				{
				}
				num = (short)1504772096;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001E184 File Offset: 0x0001C384
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0001E234 File Offset: 0x0001C434
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2058100415;
				short num2 = num;
				num = (short)1053302463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266024448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348337664;
				if (num != 0)
				{
				}
				num = (short)674562049;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1976893441;
				if (num != 0)
				{
				}
				num = (short)1750466560;
				short num2 = num;
				num = (short)1057630638;
				short num3 = num;
				num = (short)569059758;
				switch (num3 == num)
				{
				}
				num = (short)651755520;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0001E390 File Offset: 0x0001C590
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext SelectRadiosContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1554129850;
				short num2 = num;
				num = (short)129311674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026635264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1608253440;
				if (num != 0)
				{
				}
				num = (short)1689780225;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1182597121;
				if (num != 0)
				{
				}
				num = (short)168558592;
				short num2 = num;
				num = (short)201416033;
				short num3 = num;
				num = (short)2086690145;
				switch (num3 == num)
				{
				}
				num = (short)1315373056;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001E440 File Offset: 0x0001C640
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)959119363;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						num = (short)1526197980;
						short num3 = num;
						num = (short)587853532;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1966866432;
							if (num != 0)
							{
							}
							num = (short)1152188418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_105;
					case 2:
						flag = (this.SelectRadiosContext.SelectedRadioPairs.Count > 0);
						goto IL_ED;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						flag = true;
						goto IL_ED;
					}
					IL_38:
					if (!this.SelectRadiosContext.CanConfirmAnyway)
					{
						num = (short)777453568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1330315268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED:
					result = flag;
					num = (short)480772097;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_105:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)462946305;
			if (num != 0)
			{
			}
			num = (short)348585984;
			short num4 = num;
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		private void a(object[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_102;
				case 1:
					num2 = (short)182124545;
					if (num2 != 0)
					{
					}
					goto IL_102;
				case 2:
					if ((bool)A_0[1])
					{
						num2 = (short)1027342336;
						short num3 = num2;
						num2 = (short)1858469891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.SelectRadiosContext.SelectedRadioPairs.Add(item);
					num2 = (short)1036713985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_D7;
				}
				goto IL_20;
				IL_D7:
				this.SelectRadiosContext.SelectedRadioPairs.Remove(item);
				num2 = (short)1739718656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_102:
				num2 = (short)625084231;
				short num4 = num2;
				num2 = (short)1431635783;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D7;
				default:
					goto IL_137;
				}
			}
			IL_137:
			num2 = (short)1206976512;
			if (num2 != 0)
			{
			}
			this.ConfirmCommand.RaiseCanExecuteChanged();
			return;
			IL_20:
			item = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair);
			num2 = (short)814743554;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001E734 File Offset: 0x0001C934
		private void a()
		{
			short num;
			try
			{
				num = (short)1479025273;
				short num2 = num;
				num = (short)1030300281;
				switch (num2 == num)
				{
				}
				num = (short)609812480;
				if (num != 0)
				{
				}
				this.SelectRadiosContext.IsConfirmed = true;
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectRadiosContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1059586049;
			if (num != 0)
			{
			}
			num = (short)559284224;
			short num3 = num;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001E81C File Offset: 0x0001CA1C
		private void a(object A_0)
		{
			short num = (short)635633664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				object[] array;
				for (;;)
				{
					IL_27:
					bool? flag;
					bool flag2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					switch (num2)
					{
					case 0:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)386531332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectRadiosContext.SelectedRadioPairs.Clear();
						num = (short)1048576006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)865796099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 2:
						goto IL_477;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> enumerator = this.SelectRadiosContext.RadioPairs.GetEnumerator();
						num = (short)1072758793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)1827733509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)387776515;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)466812932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator2.Current;
									this.SelectRadiosContext.SelectedRadioPairs.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair);
									num = (short)681705474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_157;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_CD;
									}
									continue;
								case 4:
									num = (short)1985019905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_CF:
								num = (short)946798592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CD:
								goto IL_CF;
							}
							IL_157:
							goto IL_47C;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_16A;
					case 6:
						goto IL_2CD;
					case 7:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)1793982465;
						if (num != 0)
						{
						}
						num = (short)551223297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (array == null)
						{
							num = (short)887816199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 9:
						try
						{
							num = (short)2119630851;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_393;
								case 2:
									num = (short)1771700225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_30D;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1064763394;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair item = enumerator.Current;
									this.SelectRadiosContext.SelectedRadioPairs.Add(item);
									num = (short)1923743744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_340:
								num = (short)2133458948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30D:
								goto IL_340;
							}
							IL_393:
							goto IL_47C;
						}
						finally
						{
							num = (short)1679622145;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1588206309;
								short num3 = num;
								num = (short)659692261;
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> enumerator;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)159645696;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_44B;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_413;
										}
										continue;
									case 2:
										goto IL_42B;
									}
									IL_413:
									if (enumerator != null)
									{
										num = (short)1392115714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_44D;
								}
								IL_42B:
								enumerator.Dispose();
								num = (short)1310195712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_44B:
							IL_44D:;
						}
						goto IL_44E;
					}
					goto IL_56;
					IL_16A:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)1808400384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44E:
					this.SelectRadiosContext.SelectedRadioPairs.Clear();
					num = (short)878772226;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2CD:
				IL_477:
				IL_47C:
				num = (short)1415774208;
				short num4 = num;
				this.ConfirmCommand.RaiseCanExecuteChanged();
				return;
				IL_56:
				array = (A_0 as object[]);
				num = (short)1619132424;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 16;
			short num;
			if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("臃뻅ꯇ꿉볋뫍맏뷑뫓鯕뷗꧙꿛뿝蟟蟡", a_)))
			{
				num = (short)821807725;
				short num2 = num;
				num = (short)1429195373;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1647640577;
					if (num != 0)
					{
					}
					num = (short)1815543808;
					if (num != 0)
					{
					}
					this.SelectRadiosContext.ExceptionMessage = string.Empty;
					return;
				}
			}
			num = (short)1289289728;
			short num3 = num;
		}

		// Token: 0x040000BA RID: 186
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> a;

		// Token: 0x040000BB RID: 187
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x040000BC RID: 188
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> c;

		// Token: 0x040000BD RID: 189
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext d;
	}
}
