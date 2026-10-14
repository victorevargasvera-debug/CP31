using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000021 RID: 33
	public class TemplateConversionViewMode : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00010418 File Offset: 0x0000E618
		public global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext TemplateConversionContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1657274368;
				short num2 = num;
				num = (short)299706363;
				short num3 = num;
				num = (short)2132289531;
				switch (num3 == num)
				{
				}
				num = (short)634126336;
				if (num != 0)
				{
				}
				num = (short)1287127041;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1482686464;
				short num2 = num;
				num = (short)1077106633;
				short num3 = num;
				num = (short)1477007305;
				switch (num3 == num)
				{
				}
				num = (short)1074397185;
				if (num != 0)
				{
				}
				num = (short)166199296;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public TemplateConversionViewMode(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext context) : base(eventAggregator, commandHandler)
		{
			this.TemplateConversionContext = context;
			this.TemplateConversionContext.SelectedTemplates.CollectionChanged += this.a;
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.PrepareShowTemplateLanguagePacksDetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(this.b));
			this.PrepareShowTemplateVADetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(this.a));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001055C File Offset: 0x0000E75C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)159055872;
			short num2 = num;
			num = (short)288955439;
			short num3 = num;
			num = (short)2070158383;
			switch (num3 == num)
			{
			}
			num = (short)913113089;
			if (num != 0)
			{
			}
			num = (short)1683226624;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00010604 File Offset: 0x0000E804
		private void a(object[] A_0)
		{
			short num = (short)1792016385;
			if (num != 0)
			{
			}
			num = (short)2109997056;
			short num2 = num;
			num = (short)1056807951;
			short num3 = num;
			num = (short)942447631;
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase item;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)669384704;
				if (num != 0)
				{
				}
				item = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase);
				if (!(bool)A_0[2])
				{
					this.TemplateConversionContext.SelectedTemplates.Remove(item);
					return;
				}
				break;
			}
			this.TemplateConversionContext.SelectedTemplates.Add(item);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000106E8 File Offset: 0x0000E8E8
		private void a(object A_0)
		{
			short num = (short)1891893248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				object[] array;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator2;
				for (;;)
				{
					IL_29:
					bool? flag;
					bool flag2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					switch (num2)
					{
					case 0:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)527302658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)601554944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_145;
									}
									continue;
								case 1:
									num = (short)1041563651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1D0;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)931594241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
									this.TemplateConversionContext.SelectedTemplates.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase);
									num = (short)64028674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_147:
								num = (short)699072516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_145:
								goto IL_147;
							}
							IL_1D0:
							return;
						}
						finally
						{
							num = (short)2102329345;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_20B;
					case 2:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1050017797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 3:
						if (array == null)
						{
							num = (short)981598208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 4:
						goto IL_344;
					case 5:
						enumerator2 = this.TemplateConversionContext.Templates.GetEnumerator();
						num = (short)1208418310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_29B;
					case 7:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)624361480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.TemplateConversionContext.SelectedTemplates.Clear();
						num = (short)1701576708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator = list.GetEnumerator();
						num = (short)934936577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_54;
					IL_20B:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)739311623;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29B:
				try
				{
					num = (short)755302400;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_384;
							}
							continue;
						case 1:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)845742082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase item = enumerator2.Current;
							this.TemplateConversionContext.SelectedTemplates.Add(item);
							num = (short)1949302788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)779485187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_40C;
						}
						IL_3B9:
						num = (short)133234689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_384:
						goto IL_3B9;
					}
					IL_40C:
					return;
				}
				finally
				{
					num = (short)569245697;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_47A;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_445;
							}
							continue;
						case 2:
							enumerator2.Dispose();
							num = (short)1333592064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_445:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)129695746;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_47A:;
				}
				IL_47D:
				this.TemplateConversionContext.SelectedTemplates.Clear();
				return;
				IL_54:
				array = (A_0 as object[]);
				num = (short)2115239936;
				short num3 = num;
				num = (short)474591134;
				short num4 = num;
				num = (short)12365726;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_344:
					break;
				default:
					num = (short)160956416;
					if (num != 0)
					{
					}
					num = (short)1854930947;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				return;
			}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num;
			try
			{
				num = (short)1418012350;
				short num2 = num;
				num = (short)1185162942;
				switch (num2 == num)
				{
				}
				num = (short)655884288;
				if (num != 0)
				{
				}
				base.CommandHandler.ShowTemplateLanguageDetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)682033153;
			if (num != 0)
			{
			}
			num = (short)526974976;
			short num3 = num;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00010C80 File Offset: 0x0000EE80
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num;
			try
			{
				num = (short)913073584;
				short num2 = num;
				num = (short)1053517232;
				switch (num2 == num)
				{
				}
				num = (short)1433337856;
				if (num != 0)
				{
				}
				base.CommandHandler.ShowTemplateVADetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)859373569;
			if (num != 0)
			{
			}
			num = (short)181534720;
			short num3 = num;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00010D60 File Offset: 0x0000EF60
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00010E10 File Offset: 0x0000F010
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)313786368;
				short num2 = num;
				num = (short)228468976;
				short num3 = num;
				num = (short)573909232;
				switch (num3 == num)
				{
				}
				num = (short)2039873537;
				if (num != 0)
				{
				}
				num = (short)1543307264;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1252458496;
				short num2 = num;
				num = (short)1128971707;
				short num3 = num;
				num = (short)229424571;
				switch (num3 == num)
				{
				}
				num = (short)2011758593;
				if (num != 0)
				{
				}
				num = (short)961019904;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00010F74 File Offset: 0x0000F174
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)55219808;
				short num2 = num;
				num = (short)2099353184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537526272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408565248;
				if (num != 0)
				{
				}
				num = (short)1796538369;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1180824057;
				short num2 = num;
				num = (short)974975481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626786304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541261824;
				if (num != 0)
				{
				}
				num = (short)1082261505;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00011024 File Offset: 0x0000F224
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000110D4 File Offset: 0x0000F2D4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> PrepareShowTemplateLanguagePacksDetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1456677083;
				short num2 = num;
				num = (short)423567579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071906816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719402497;
				if (num != 0)
				{
				}
				num = (short)912523264;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1483932734;
				short num2 = num;
				num = (short)653788222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859963392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202520065;
				if (num != 0)
				{
				}
				num = (short)989265920;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00011184 File Offset: 0x0000F384
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00011234 File Offset: 0x0000F434
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> PrepareShowTemplateVADetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)376503313;
				short num2 = num;
				num = (short)2079128593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471414272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153302528;
				if (num != 0)
				{
				}
				num = (short)695926785;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1858510399;
				short num2 = num;
				num = (short)768319039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994850304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398603776;
				if (num != 0)
				{
				}
				num = (short)2059141121;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x040000B0 RID: 176
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext a;

		// Token: 0x040000B1 RID: 177
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> c;

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> d;

		// Token: 0x040000B4 RID: 180
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> e;
	}
}
