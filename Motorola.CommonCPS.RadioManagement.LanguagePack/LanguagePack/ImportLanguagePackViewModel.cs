using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LanguagePack
{
	// Token: 0x02000004 RID: 4
	public class ImportLanguagePackViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000032E8 File Offset: 0x000014E8
		public ImportLanguagePackViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext) : base(eventAggregator, commandHandler)
		{
			this.ImportLanguagePackContext = importLanguagePackContext;
			this.ImportLanguagePackContext.SelectedLanguagePacks.CollectionChanged += this.a;
			this.ImportLanguagePackCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.ImportLanguagePackContext.PropertyChanged += this.a;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00003388 File Offset: 0x00001588
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00003434 File Offset: 0x00001634
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext ImportLanguagePackContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)484092952;
				short num2 = num;
				num = (short)1245228056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1789198336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191247873;
				if (num != 0)
				{
				}
				num = (short)1682636800;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1287961422;
				short num2 = num;
				num = (short)1864809294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491206144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)924712961;
				if (num != 0)
				{
				}
				num = (short)1865547776;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000034E0 File Offset: 0x000016E0
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00003590 File Offset: 0x00001790
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportLanguagePackCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1424490497;
				if (num != 0)
				{
				}
				num = (short)886636544;
				short num2 = num;
				num = (short)1405234711;
				short num3 = num;
				num = (short)317730327;
				switch (num3 == num)
				{
				}
				num = (short)780861440;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)106315350;
				short num2 = num;
				num = (short)1109671510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262616576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1163788289;
				if (num != 0)
				{
				}
				num = (short)1161887744;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000036F4 File Offset: 0x000018F4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)319434975;
				short num2 = num;
				num = (short)920662239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976551936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041956865;
				if (num != 0)
				{
				}
				num = (short)494731264;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)154236750;
				short num2 = num;
				num = (short)915175246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985740800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276168704;
				if (num != 0)
				{
				}
				num = (short)784072705;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000037A8 File Offset: 0x000019A8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003858 File Offset: 0x00001A58
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)879164041;
				short num2 = num;
				num = (short)528480905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836384256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228341248;
				if (num != 0)
				{
				}
				num = (short)1119354881;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1893156752;
				short num2 = num;
				num = (short)2028095376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973288960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074593793;
				if (num != 0)
				{
				}
				num = (short)1755447296;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003908 File Offset: 0x00001B08
		private void a(object[] A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack item = A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack;
			if ((bool)A_0[1])
			{
				short num;
				for (;;)
				{
					num = (short)1696127830;
					short num2 = num;
					num = (short)2088295254;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4E;
					}
				}
				IL_4E:
				num = (short)17956865;
				if (num != 0)
				{
				}
				num = (short)1707802624;
				if (num != 0)
				{
				}
				num = (short)2083520512;
				short num3 = num;
				this.ImportLanguagePackContext.SelectedLanguagePacks.Remove(item);
				return;
			}
			this.ImportLanguagePackContext.SelectedLanguagePacks.Add(item);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000039F0 File Offset: 0x00001BF0
		private void b()
		{
			short num;
			try
			{
				num = (short)393298639;
				short num2 = num;
				num = (short)595870415;
				switch (num2 == num)
				{
				}
				num = (short)2020212736;
				if (num != 0)
				{
				}
				base.CommandHandler.ImportLanguagePackCommand.Execute(new object[]
				{
					this.ImportLanguagePackContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ImportLanguagePackContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1870397441;
			if (num != 0)
			{
			}
			num = (short)429588480;
			short num3 = num;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003AEC File Offset: 0x00001CEC
		private void a(object A_0)
		{
			short num = (short)1756561408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack> enumerator;
				object[] array;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					bool? flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_1F9;
					case 1:
						enumerator = this.ImportLanguagePackContext.LanguagePacks.GetEnumerator();
						num = (short)343408640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)1615855619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)1161297924;
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
										num = (short)1575419906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator2.Current;
									this.ImportLanguagePackContext.SelectedLanguagePacks.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack);
									num = (short)1746337793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)909639683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_156;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_CA;
									}
									continue;
								}
								IL_CC:
								num = (short)2097348608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CA:
								goto IL_CC;
							}
							IL_156:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_169;
					case 4:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)926351362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ImportLanguagePackContext.SelectedLanguagePacks.Clear();
						num = (short)691601413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2F3;
					case 6:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1221263361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_477;
					case 7:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)1719205894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (array == null)
						{
							num = (short)407633927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					}
					goto IL_52;
					IL_169:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)1110704132;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F9:
				num = (short)1601437696;
				short num3 = num;
				num = (short)1441988609;
				if (num != 0)
				{
				}
				try
				{
					num = (short)1977942020;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_3ED;
						case 2:
						{
							num = (short)145972958;
							short num4 = num;
							num = (short)1242390238;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3ED;
							default:
							{
								num = (short)793116672;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)1261174785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack item = enumerator.Current;
								this.ImportLanguagePackContext.SelectedLanguagePacks.Add(item);
								num = (short)2018967552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 3:
							goto IL_407;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_332;
							}
							continue;
						}
						IL_367:
						num = (short)1303838722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_332:
						goto IL_367;
						IL_3ED:
						num = (short)1454637059;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_407:
					return;
				}
				finally
				{
					num = (short)1744502786;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1170014209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_474;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_43F;
							}
							continue;
						}
						IL_43F:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1898774528;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_474:;
				}
				goto IL_477;
				IL_2F3:
				return;
				IL_477:
				this.ImportLanguagePackContext.SelectedLanguagePacks.Clear();
				return;
				IL_52:
				array = (A_0 as object[]);
				num = (short)1822490632;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003FB8 File Offset: 0x000021B8
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1335419992;
				short num2 = num;
				num = (short)486663256;
				switch (num2 == num)
				{
				}
				num = (short)249495553;
				if (num != 0)
				{
				}
				num = (short)2055602176;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ImportLanguagePackCommand.CanExecute(new object[]
				{
					this.ImportLanguagePackContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1105395712;
			short num3 = num;
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000040A4 File Offset: 0x000022A4
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1208412864;
			short num2 = num;
			num = (short)22670016;
			switch (num2 == num)
			{
			default:
			{
				num = (short)863764480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)398000129;
			if (num != 0)
			{
			}
			num = (short)245891072;
			if (num != 0)
			{
			}
			this.ImportLanguagePackContext.ExceptionMessage = string.Empty;
			this.ImportLanguagePackCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000416C File Offset: 0x0000236C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 7;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ᩞᥠbdᝦᵨɪɬŮ㱰ᙲٴѶᡸᱺ᡼", a_))
			{
				short num;
				for (;;)
				{
					num = (short)936968149;
					short num2 = num;
					num = (short)597950421;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5D;
					}
				}
				IL_5D:
				num = (short)1586167809;
				if (num != 0)
				{
				}
				num = (short)158203904;
				if (num != 0)
				{
				}
				num = (short)1728905216;
				short num3 = num;
				return;
			}
			this.ImportLanguagePackContext.ExceptionMessage = string.Empty;
			this.ImportLanguagePackCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext a;

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> c;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
