using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000028 RID: 40
	public class SelectProvisioningPackageViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000205E8 File Offset: 0x0001E7E8
		public SelectProvisioningPackageViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext context) : base(eventAggregator, commandHandler)
		{
			this.b = context;
			this.a = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SelectedItemChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(new global::System.Action<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(this.a));
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00020640 File Offset: 0x0001E840
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectProvisioningPackageCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1952534735;
				short num2 = num;
				num = (short)21254351;
				switch (num2 == num)
				{
				}
				num = (short)878641152;
				short num3 = num;
				num = (short)1453457409;
				if (num != 0)
				{
				}
				num = (short)1899560960;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000206F0 File Offset: 0x0001E8F0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext Context
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2048851969;
				if (num != 0)
				{
				}
				num = (short)545408678;
				short num2 = num;
				num = (short)738150054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908604928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318846464;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000207A0 File Offset: 0x0001E9A0
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00020850 File Offset: 0x0001EA50
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> SelectedItemChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1758510309;
				short num2 = num;
				num = (short)1174191333;
				switch (num2 == num)
				{
				}
				num = (short)1313406976;
				short num3 = num;
				num = (short)1690238977;
				if (num != 0)
				{
				}
				num = (short)573243392;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1624492646;
				short num2 = num;
				num = (short)572050022;
				switch (num2 == num)
				{
				}
				num = (short)781123584;
				short num3 = num;
				num = (short)152305665;
				if (num != 0)
				{
				}
				num = (short)1928527872;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00020900 File Offset: 0x0001EB00
		private void b()
		{
			short num;
			try
			{
				num = (short)1654523950;
				short num2 = num;
				num = (short)1255082030;
				switch (num2 == num)
				{
				}
				num = (short)1793720320;
				if (num != 0)
				{
				}
				base.CommandHandler.SelectGeneralPackagesCommand.Execute(new object[]
				{
					this.Context
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.Context.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1464664065;
			if (num != 0)
			{
			}
			num = (short)2021195776;
			short num3 = num;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000209FC File Offset: 0x0001EBFC
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)206415336;
				short num2 = num;
				num = (short)1778165224;
				switch (num2 == num)
				{
				}
				num = (short)800522240;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectGeneralPackagesCommand.CanExecute(new object[]
				{
					this.Context
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1653932033;
			if (num != 0)
			{
			}
			num = (short)1326252032;
			short num3 = num;
			return result;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00020AE4 File Offset: 0x0001ECE4
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_0)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1959329792;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						try
						{
							num = (short)1090584579;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_82:
								switch (num2)
								{
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage;
									generalPackage.VValue = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("탤", a_);
									num = (short)920125445;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1F4;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_A8;
									}
									continue;
								case 4:
									while (enumerator.MoveNext())
									{
										num = (short)1397036152;
										short num3 = num;
										num = (short)1665209464;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)655425536;
											if (num != 0)
											{
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage = enumerator.Current;
											num = (short)1302396934;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_82;
										}
										}
									}
									num = (short)1089142791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage;
									if (generalPackage.Uuid == (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage).Uuid)
									{
										num = (short)9502721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									generalPackage.VValue = "";
									num = (short)1802043392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1679294466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_AA:
								num = (short)898039812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A8:
								goto IL_AA;
							}
							IL_1F4:
							goto IL_28D;
						}
						finally
						{
							num = (short)82378754;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)957022209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_25D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_229;
									}
									continue;
								}
								IL_229:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1915224064;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25D:;
						}
						goto IL_260;
					case 2:
						goto IL_2B0;
					case 3:
						goto IL_260;
					}
					IL_3D:
					if (A_0.Count == 1)
					{
						num = (short)684195843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28D;
					IL_260:
					enumerator = this.Context.Packages.GetEnumerator();
					num = (short)466878465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28D:
					this.SelectProvisioningPackageCommand.RaiseCanExecuteChanged();
					num = (short)1431502850;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B0:;
			}
			catch (global::System.Exception exception)
			{
				this.Context.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1703936001;
			if (num != 0)
			{
			}
			num = (short)2109997056;
			short num4 = num;
		}

		// Token: 0x040000D1 RID: 209
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand a;

		// Token: 0x040000D2 RID: 210
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext b;

		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> c;
	}
}
