using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200003C RID: 60
	public class SettingsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000176 RID: 374 RVA: 0x0001AF94 File Offset: 0x00019194
		public SettingsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext settingsContext) : base(eventAggregator, commandHandler)
		{
			this.SettingsContext = settingsContext;
			this.SettingsContext.PropertyChanged += this.a;
			this.SettingsContext.Connection.PropertyChanged += this.a;
			this.SettingsContext.Language.PropertyChanged += this.a;
			this.SettingsContext.ButtonBarMode.PropertyChanged += this.a;
			this.SettingsContext.DealerInfo.PropertyChanged += this.a;
			this.SettingsContext.DBSizeInfo.PropertyChanged += this.a;
			this.SettingsContext.RMUserPassword.PropertyChanged += this.a;
			this.SettingsContext.LogSetting.PropertyChanged += this.a;
			this.RecoverApplicationLicensesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.r), new global::System.Func<bool>(this.i));
			this.RecoverRadioLicensesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.q), new global::System.Func<bool>(this.h));
			this.SaveSettingsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.p), new global::System.Func<bool>(this.g));
			this.ChangeRMUserPasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.m), new global::System.Func<bool>(this.e));
			this.ChangeRMAppLanguageCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.l), new global::System.Func<bool>(this.d));
			this.ChangeRMAppButtonBarModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.k), new global::System.Func<bool>(this.c));
			this.SaveDealerInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.o), new global::System.Func<bool>(this.f));
			this.SaveHiddenMessageCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.n), new global::System.Func<bool>(this.b));
			this.n = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.j), new global::System.Func<bool>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001B1E0 File Offset: 0x000193E0
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0001B290 File Offset: 0x00019490
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext SettingsContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1194097154;
				short num2 = num;
				num = (short)1274116610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)313327616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770834432;
				if (num != 0)
				{
				}
				num = (short)1329987585;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)651431009;
				short num2 = num;
				num = (short)1182534753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921449984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1752170497;
				if (num != 0)
				{
				}
				num = (short)848887808;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001B344 File Offset: 0x00019544
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0001B3F4 File Offset: 0x000195F4
		public static global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.CleanPasswordEvt RaiseCleanPasswordEvt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)18487903;
				short num2 = num;
				num = (short)597039711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008481792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993591296;
				if (num != 0)
				{
				}
				num = (short)1645150209;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)741801985;
				if (num != 0)
				{
				}
				num = (short)161218560;
				short num2 = num;
				num = (short)1775413039;
				short num3 = num;
				num = (short)1268950831;
				switch (num3 == num)
				{
				}
				num = (short)414711808;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.d = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001B4A8 File Offset: 0x000196A8
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0001B554 File Offset: 0x00019754
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CancelCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1182144173;
				short num2 = num;
				num = (short)71636653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)778633216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273102336;
				if (num != 0)
				{
				}
				num = (short)212140033;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1514340353;
				if (num != 0)
				{
				}
				num = (short)788201472;
				short num2 = num;
				num = (short)1498028053;
				short num3 = num;
				num = (short)535304213;
				switch (num3 == num)
				{
				}
				num = (short)1175388160;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001B608 File Offset: 0x00019808
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001B6B8 File Offset: 0x000198B8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RecoverApplicationLicensesCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)983246661;
				short num2 = num;
				num = (short)744236869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119696384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192675841;
				if (num != 0)
				{
				}
				num = (short)1023213568;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1177645146;
				short num2 = num;
				num = (short)1412198490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434503680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)739901441;
				if (num != 0)
				{
				}
				num = (short)353239040;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001B76C File Offset: 0x0001996C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0001B81C File Offset: 0x00019A1C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RecoverRadioLicensesCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1130093342;
				short num2 = num;
				num = (short)1400167198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877068288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)459931649;
				if (num != 0)
				{
				}
				num = (short)1383464960;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1998232067;
				short num2 = num;
				num = (short)599890435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42729472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400635393;
				if (num != 0)
				{
				}
				num = (short)1198063616;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001B8CC File Offset: 0x00019ACC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0001B97C File Offset: 0x00019B7C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveSettingsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)387243499;
				short num2 = num;
				num = (short)1834999275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452132864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761083393;
				if (num != 0)
				{
				}
				num = (short)1006108672;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)390337677;
				short num2 = num;
				num = (short)100799629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037121024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1473708032;
				if (num != 0)
				{
				}
				num = (short)2059468801;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001BA30 File Offset: 0x00019C30
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChangeRMUserPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1031403542;
				short num2 = num;
				num = (short)817690646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756350976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)351272960;
				if (num != 0)
				{
				}
				num = (short)1285619713;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1996206788;
				short num2 = num;
				num = (short)968274628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261357568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1538260993;
				if (num != 0)
				{
				}
				num = (short)652738560;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001BB90 File Offset: 0x00019D90
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0001BC40 File Offset: 0x00019E40
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChangeRMAppLanguageCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)893463514;
				short num2 = num;
				num = (short)1609640922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587071488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)466485248;
				if (num != 0)
				{
				}
				num = (short)127205377;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1386139877;
				short num2 = num;
				num = (short)1634390245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012137984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741094912;
				if (num != 0)
				{
				}
				num = (short)462028801;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChangeRMAppButtonBarModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1865322935;
				short num2 = num;
				num = (short)580882871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992673792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)667156480;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2022879021;
				short num2 = num;
				num = (short)1824960301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231997440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165806080;
				if (num != 0)
				{
				}
				num = (short)1507721217;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001BE58 File Offset: 0x0001A058
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0001BF04 File Offset: 0x0001A104
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveDealerInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1158283265;
				if (num != 0)
				{
				}
				num = (short)607977472;
				short num2 = num;
				num = (short)675116896;
				short num3 = num;
				num = (short)168327008;
				switch (num3 == num)
				{
				}
				num = (short)521076736;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1599683371;
				short num2 = num;
				num = (short)1422474027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042546688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)187760641;
				if (num != 0)
				{
				}
				num = (short)1773862912;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0001C064 File Offset: 0x0001A264
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveHiddenMessageCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)301548009;
				short num2 = num;
				num = (short)1419067881;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1879506944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)401145857;
				if (num != 0)
				{
				}
				num = (short)1192099840;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)557447807;
				short num2 = num;
				num = (short)1107819135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004746240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788215297;
				if (num != 0)
				{
				}
				num = (short)1936916480;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001C118 File Offset: 0x0001A318
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UpdateLoggingSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)327254936;
				short num2 = num;
				num = (short)1458144152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985413120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253703681;
				if (num != 0)
				{
				}
				num = (short)1994194944;
				if (num != 0)
				{
				}
				return this.n;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		private void r()
		{
			short num = (short)2140782998;
			short num2 = num;
			num = (short)1641202070;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1706426368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1559232513;
			if (num != 0)
			{
			}
			num = (short)242024448;
			if (num != 0)
			{
			}
			base.CommandHandler.RecoverApplicationLicensesCommand.Execute(global::System.Array.Empty<object>());
			base.CloseCommand.Execute();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001C294 File Offset: 0x0001A494
		private void q()
		{
			short num = (short)1974399898;
			short num2 = num;
			num = (short)838267802;
			switch (num2 == num)
			{
			default:
			{
				num = (short)762249216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)920190976;
			if (num != 0)
			{
			}
			num = (short)895221761;
			if (num != 0)
			{
			}
			base.CommandHandler.RecoverRadioLicensesCommand.Execute(global::System.Array.Empty<object>());
			base.CloseCommand.Execute();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001C360 File Offset: 0x0001A560
		private void p()
		{
			short num = (short)445028291;
			short num2 = num;
			num = (short)1072732099;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)498925568;
				short num3 = num;
				num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)2073296896;
				if (num != 0)
				{
				}
				bool flag = false;
				try
				{
					flag = (bool)base.CommandHandler.SaveSettingsCommand.Execute(new object[]
					{
						this.SettingsContext
					});
				}
				catch (global::System.Exception exception)
				{
					this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				}
				finally
				{
					num = (short)116391937;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							this.b = true;
							base.CloseCommand.Execute();
							num = (short)1548681218;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_10F;
							}
							continue;
						case 2:
							goto IL_14F;
						}
						IL_10F:
						if (!flag)
						{
							break;
						}
						num = (short)1631977472;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_14F:;
				}
				break;
			}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		private void o()
		{
			short num;
			try
			{
				num = (short)2128642852;
				short num2 = num;
				num = (short)1085965092;
				switch (num2 == num)
				{
				}
				num = (short)684720128;
				if (num != 0)
				{
				}
				base.CommandHandler.SaveDealerInfoCommand.Execute(new object[]
				{
					this.SettingsContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1068040192;
			short num3 = num;
			num = (short)1407385601;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		private void n()
		{
			short num;
			try
			{
				num = (short)1288075525;
				short num2 = num;
				num = (short)1889171717;
				switch (num2 == num)
				{
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)795017217;
				if (num != 0)
				{
				}
				base.CommandHandler.SaveHiddenMessageCommand.Execute(new object[]
				{
					this.SettingsContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1294467072;
			short num3 = num;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
		private void m()
		{
			short num;
			try
			{
				num = (short)1839807031;
				short num2 = num;
				num = (short)518797879;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_143:
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt == null)
					{
						goto IL_CD;
					}
					num = (short)1323433985;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)942931968;
					if (num != 0)
					{
					}
					num = (short)151060483;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_6B:
					switch (num3)
					{
					case 0:
						goto IL_129;
					case 1:
					{
						global::System.EventArgs eventArgs = new global::System.EventArgs();
						global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt(eventArgs);
						num = (short)1331822592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_163;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					case 4:
						goto IL_17A;
					case 5:
						num = (short)354484230;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_143;
					}
					IL_8D:
					if ((bool)base.CommandHandler.ChangeRMUserPasswordCommand.Execute(new object[]
					{
						this.SettingsContext
					}))
					{
						num = (short)930742277;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_163:
					num = (short)2057961476;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_129:
				goto IL_CD;
				IL_17A:
				goto IL_192;
				IL_CD:
				this.SettingsContext.ExceptionMessage = string.Empty;
				base.CloseCommand.Execute();
				num = (short)1671954434;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_6B;
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			IL_192:
			num = (short)1933049856;
			short num4 = num;
			num = (short)151453697;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		private void l()
		{
			short num;
			try
			{
				for (;;)
				{
					num = (short)1142947842;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_BC;
						case 1:
							this.SettingsContext.ExceptionMessage = string.Empty;
							base.CloseCommand.Execute();
							num = (short)1998258179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_34;
							}
							continue;
						case 3:
							goto IL_A5;
						}
						IL_34:
						if ((bool)base.CommandHandler.ChangeRMAppLanguageCommand.Execute(new object[]
						{
							this.SettingsContext
						}))
						{
							num = (short)50921473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A5:
						num = (short)572653568;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_BC:
					num = (short)364509481;
					short num3 = num;
					num = (short)1413675305;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F0;
					}
				}
				IL_F0:
				num = (short)346750976;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1162215424;
			short num4 = num;
			num = (short)371982337;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		private void k()
		{
			short num;
			try
			{
				for (;;)
				{
					num = (short)1641414658;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_BF;
						case 1:
							this.SettingsContext.ExceptionMessage = string.Empty;
							base.CloseCommand.Execute();
							num = (short)1810759683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_34;
							}
							continue;
						case 3:
							goto IL_A7;
						}
						IL_34:
						if ((bool)base.CommandHandler.ChangeRMAppButtonBarModeCommand.Execute(new object[]
						{
							this.SettingsContext
						}))
						{
							num = (short)1169031169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A7:
						num = (short)1510670336;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_BF:
					num = (short)1070329656;
					short num3 = num;
					num = (short)571404088;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F5;
					}
				}
				IL_F5:
				num = (short)399966208;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1742798848;
			short num4 = num;
			num = (short)504692737;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001CC18 File Offset: 0x0001AE18
		public void GetDatabaseSizeSummary()
		{
			short num;
			try
			{
				num = (short)11599875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary databaseSizeSummary = (global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary)base.CommandHandler.GetDatabaseSizeSummaryCommand.Execute(new object[]
						{
							this.SettingsContext
						});
						this.SettingsContext.DBSizeInfo.DBSize = databaseSizeSummary.AllOccupy;
						this.SettingsContext.DBSizeInfo.SetSize = databaseSizeSummary.OccupiedBySets;
						this.SettingsContext.DBSizeInfo.NumberOfSets = databaseSizeSummary.RowCountOfSets;
						num = (short)272171012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_18B;
					case 2:
						goto IL_174;
					case 3:
					{
						num = (short)1037599335;
						short num3 = num;
						num = (short)23167591;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1162739712;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						}
						break;
					}
					case 4:
						goto IL_174;
					}
					IL_83:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
					{
						num = (short)48627712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.SettingsContext.DBSizeInfo.DBSize = -1L;
					this.SettingsContext.DBSizeInfo.SetSize = -1L;
					this.SettingsContext.DBSizeInfo.NumberOfSets = -1L;
					num = (short)1542782978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_174:
					num = (short)831127553;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18B:;
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.DBSizeInfo.DBSize = -1L;
				this.SettingsContext.DBSizeInfo.SetSize = -1L;
				this.SettingsContext.DBSizeInfo.NumberOfSets = -1L;
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)583139328;
			short num4 = num;
			num = (short)316276737;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001CE68 File Offset: 0x0001B068
		private void j()
		{
			short num;
			try
			{
				num = (short)464130913;
				short num2 = num;
				num = (short)1557664609;
				switch (num2 == num)
				{
				}
				num = (short)355794944;
				if (num != 0)
				{
				}
				base.CommandHandler.UpdateLogSettingCommand.Execute(new object[]
				{
					this.SettingsContext.LogSetting
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SettingsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1151795200;
			short num3 = num;
			num = (short)334430209;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001CF6C File Offset: 0x0001B16C
		protected override void OnWindowClosed()
		{
			short num = (short)1892567151;
			short num2 = num;
			num = (short)858015855;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10A:
				num = (short)538181632;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2076966912;
				if (num != 0)
				{
				}
				num = (short)736952321;
				if (num != 0)
				{
				}
				num = (short)1053491204;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_121;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled = true;
					num = (short)1917124610;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_123;
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt != null)
					{
						num = (short)1732968453;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 5:
					goto IL_159;
				}
				IL_AD:
				if (!this.b)
				{
					num = (short)719847425;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_123:
				num = (short)1958084611;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_121:
			return;
			IL_159:
			num = (short)676593664;
			short num4 = num;
			global::System.EventArgs eventArgs = new global::System.EventArgs();
			global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.RaiseCleanPasswordEvt(eventArgs);
			goto IL_10A;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private bool i()
		{
			short num = (short)2086469633;
			if (num != 0)
			{
			}
			num = (short)951910400;
			short num2 = num;
			num = (short)785967002;
			short num3 = num;
			num = (short)1984030618;
			switch (num3 == num)
			{
			}
			num = (short)1030946816;
			if (num != 0)
			{
			}
			return base.CommandHandler.RecoverApplicationLicensesCommand.CanExecute(global::System.Array.Empty<object>());
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		private bool h()
		{
			short num = (short)1031366738;
			short num2 = num;
			num = (short)1366976594;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1786642432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)39780353;
			if (num != 0)
			{
			}
			num = (short)1687158784;
			if (num != 0)
			{
			}
			return base.CommandHandler.RecoverRadioLicensesCommand.CanExecute(global::System.Array.Empty<object>());
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001D278 File Offset: 0x0001B478
		private bool g()
		{
			short num = (short)1354383119;
			short num2 = num;
			num = (short)564936463;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1532624896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2020540417;
			if (num != 0)
			{
			}
			num = (short)211025920;
			if (num != 0)
			{
			}
			return base.CommandHandler.SaveSettingsCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001D33C File Offset: 0x0001B53C
		private bool f()
		{
			short num = (short)203751425;
			if (num != 0)
			{
			}
			num = (short)687341568;
			short num2 = num;
			num = (short)1499574799;
			short num3 = num;
			num = (short)1940959759;
			switch (num3 == num)
			{
			}
			num = (short)30015488;
			if (num != 0)
			{
			}
			return base.CommandHandler.SaveDealerInfoCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001D404 File Offset: 0x0001B604
		private bool e()
		{
			short num = (short)1376238379;
			short num2 = num;
			num = (short)717208363;
			switch (num2 == num)
			{
			default:
			{
				num = (short)696778752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)567017472;
			if (num != 0)
			{
			}
			num = (short)466223105;
			if (num != 0)
			{
			}
			return base.CommandHandler.ChangeRMUserPasswordCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
		private bool d()
		{
			short num = (short)1569958107;
			short num2 = num;
			num = (short)1771153627;
			switch (num2 == num)
			{
			}
			num = (short)214106112;
			short num3 = num;
			num = (short)1987969024;
			if (num != 0)
			{
			}
			num = (short)20054017;
			if (num != 0)
			{
			}
			return base.CommandHandler.ChangeRMAppLanguageCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001D59C File Offset: 0x0001B79C
		private bool c()
		{
			short num = (short)1504551139;
			short num2 = num;
			num = (short)1875026147;
			switch (num2 == num)
			{
			}
			num = (short)114819072;
			short num3 = num;
			num = (short)1413545985;
			if (num != 0)
			{
			}
			num = (short)2078998528;
			if (num != 0)
			{
			}
			return base.CommandHandler.ChangeRMAppButtonBarModeCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001D664 File Offset: 0x0001B864
		private bool b()
		{
			short num = (short)1164705793;
			if (num != 0)
			{
			}
			num = (short)960978118;
			short num2 = num;
			num = (short)1734696134;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1286864896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2144993280;
			if (num != 0)
			{
			}
			return base.CommandHandler.SaveHiddenMessageCommand.CanExecute(new object[]
			{
				this.SettingsContext
			});
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001D72C File Offset: 0x0001B92C
		private bool a()
		{
			short num = (short)1026614422;
			short num2 = num;
			num = (short)2064901270;
			switch (num2 == num)
			{
			}
			num = (short)1430913024;
			short num3 = num;
			num = (short)81788929;
			if (num != 0)
			{
			}
			num = (short)989134848;
			if (num != 0)
			{
			}
			return base.CommandHandler.UpdateLogSettingCommand.CanExecute(new object[]
			{
				this.SettingsContext.LogSetting
			});
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)1984299012;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_137;
				case 1:
					return;
				case 2:
				{
					num = (short)766640129;
					if (num != 0)
					{
					}
					num = (short)565051392;
					short num3 = num;
					this.GetDatabaseSizeSummary();
					num = (short)806158336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郘꣚黜냞迠跢胤蓦鷨軪觬", a_))
					{
						num = (short)1228996610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鳘ꏚ뻜뫞釠韢賤裦蟨ꛪ裬鳮苰鋲鋴鋶", a_))
				{
					num = (short)1767178241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)884604931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_137:
				num = (short)487997810;
				short num4 = num;
				num = (short)130498930;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_16E;
				}
			}
			return;
			IL_16E:
			num = (short)214892544;
			if (num != 0)
			{
			}
			this.SettingsContext.ExceptionMessage = string.Empty;
			this.SaveSettingsCommand.RaiseCanExecuteChanged();
			this.ChangeRMAppLanguageCommand.RaiseCanExecuteChanged();
			this.ChangeRMAppButtonBarModeCommand.RaiseCanExecuteChanged();
			this.SaveDealerInfoCommand.RaiseCanExecuteChanged();
			this.ChangeRMUserPasswordCommand.RaiseCanExecuteChanged();
			this.SaveHiddenMessageCommand.RaiseCanExecuteChanged();
			this.UpdateLoggingSetting.RaiseCanExecuteChanged();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		private void a(int A_0)
		{
			short num = (short)1952900802;
			short num2 = num;
			num = (short)1065543362;
			switch (num2 == num)
			{
			}
			num = (short)435355648;
			short num3 = num;
			num = (short)1982332929;
			if (num != 0)
			{
			}
			num = (short)1489567744;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x04000130 RID: 304
		private int a;

		// Token: 0x04000131 RID: 305
		private bool b;

		// Token: 0x04000132 RID: 306
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext c;

		// Token: 0x04000133 RID: 307
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel.CleanPasswordEvt d;

		// Token: 0x04000134 RID: 308
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000135 RID: 309
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000136 RID: 310
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand g;

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand h;

		// Token: 0x04000138 RID: 312
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand i;

		// Token: 0x04000139 RID: 313
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand j;

		// Token: 0x0400013A RID: 314
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand k;

		// Token: 0x0400013B RID: 315
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand l;

		// Token: 0x0400013C RID: 316
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand m;

		// Token: 0x0400013D RID: 317
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand n;

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001A5 RID: 421
		public delegate void CleanPasswordEvt(global::System.EventArgs e);
	}
}
