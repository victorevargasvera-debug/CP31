using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000033 RID: 51
	public class ScheduleJobViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00025334 File Offset: 0x00023534
		public global::System.Windows.Visibility FactoryResetVisible
		{
			get
			{
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
				{
					short num = (short)155254785;
					if (num != 0)
					{
					}
					num = (short)1150271926;
					short num2 = num;
					num = (short)214614454;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return global::System.Windows.Visibility.Collapsed;
					case 1:
						break;
					default:
					{
						num = (short)608763904;
						short num3 = num;
						break;
					}
					}
					num = (short)79364096;
					if (num != 0)
					{
					}
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000253F4 File Offset: 0x000235F4
		public global::System.Windows.Visibility ConnectionTypeVisible
		{
			get
			{
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
				{
					short num = (short)1960837121;
					if (num != 0)
					{
					}
					num = (short)192809402;
					short num2 = num;
					num = (short)163973562;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return global::System.Windows.Visibility.Collapsed;
					case 1:
						break;
					default:
					{
						num = (short)1785200640;
						short num3 = num;
						break;
					}
					}
					num = (short)1685258240;
					if (num != 0)
					{
					}
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000254B4 File Offset: 0x000236B4
		public ScheduleJobViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext, global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate scheduleJobContextValidator, global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilderFactory compositeCommandBuilderFactory) : base(eventAggregator, commandHandler)
		{
			this.a = scheduleJobContextValidator;
			this.b = scheduleJobContext;
			this.ScheduleJobContext.PropertyChanged += this.a;
			global::System.Collections.Generic.List<global::System.Windows.Input.ICommand> list = new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.j))
			};
			list.Add(new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.b)));
			this.c = compositeCommandBuilderFactory.CreateInstance.RegisterCommands(list).BuildDelegateCommand();
			this.d = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.i));
			this.e = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.h));
			this.g = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.f));
			this.f = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.g));
			this.h = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e));
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000255BC File Offset: 0x000237BC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext ScheduleJobContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1083150834;
				short num2 = num;
				num = (short)42111474;
				switch (num2 == num)
				{
				}
				num = (short)1339228160;
				short num3 = num;
				num = (short)95092737;
				if (num != 0)
				{
				}
				num = (short)823721984;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0002566C File Offset: 0x0002386C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ScheduleJobCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2145366058;
				short num2 = num;
				num = (short)589672490;
				switch (num2 == num)
				{
				}
				num = (short)1620901888;
				short num3 = num;
				num = (short)998047745;
				if (num != 0)
				{
				}
				num = (short)1542914048;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0002571C File Offset: 0x0002391C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectUEFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)382734625;
				short num2 = num;
				num = (short)1001132321;
				switch (num2 == num)
				{
				}
				num = (short)484769792;
				short num3 = num;
				num = (short)1687289856;
				if (num != 0)
				{
				}
				num = (short)876806145;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000257CC File Offset: 0x000239CC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UnselectUEFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1685267716;
				short num2 = num;
				num = (short)2027496708;
				switch (num2 == num)
				{
				}
				num = (short)575275008;
				short num3 = num;
				num = (short)1891237888;
				if (num != 0)
				{
				}
				num = (short)932708353;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0002587C File Offset: 0x00023A7C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectEnableAllCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1561508499;
				short num2 = num;
				num = (short)1229961875;
				switch (num2 == num)
				{
				}
				num = (short)561381376;
				short num3 = num;
				num = (short)67108864;
				if (num != 0)
				{
				}
				num = (short)1897136129;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0002592C File Offset: 0x00023B2C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectDisableAllCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)524353537;
				if (num != 0)
				{
				}
				num = (short)27180121;
				short num2 = num;
				num = (short)1568259161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1077936128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)608763904;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000259E0 File Offset: 0x00023BE0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnableImmediateDeploymentCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)719127748;
				short num2 = num;
				num = (short)330892484;
				switch (num2 == num)
				{
				}
				num = (short)1855782912;
				short num3 = num;
				num = (short)96337920;
				if (num != 0)
				{
				}
				num = (short)1814364161;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00025A90 File Offset: 0x00023C90
		private void j()
		{
			int a_ = 19;
			short num = (short)1164256179;
			short num2 = num;
			num = (short)1562518451;
			switch (num2 == num)
			{
			}
			num = (short)7929856;
			short num3 = num;
			num = (short)349634560;
			if (num != 0)
			{
			}
			num = (short)158793729;
			if (num != 0)
			{
			}
			this.a.Validate(this.ScheduleJobContext, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铆뷈꫊뿌믎郐뗒ꇔ닖ꯘ迚드닞蓠", a_)));
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00025B68 File Offset: 0x00023D68
		private void a(global::System.Action A_0)
		{
			short num;
			try
			{
				num = (short)1797849090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!this.ScheduleJobContext.IsFactoryResetJobCanceled)
						{
							num = (short)985399299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					case 1:
						goto IL_82;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 3:
						base.CloseCommand.Execute();
						num = (short)1567162369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						A_0();
						num = (short)39976961;
						if (num != 0)
						{
						}
						num = (short)850591744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)639599632;
						short num3 = num;
						num = (short)445875216;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_82;
						default:
							goto IL_13F;
						}
						break;
					}
					}
					IL_3C:
					if (!this.ScheduleJobContext.HasError())
					{
						num = (short)817299460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F1:
					num = (short)938737669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82:
					goto IL_F1;
				}
				IL_13F:
				num = (short)1984364544;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				this.ScheduleJobContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1968111616;
			short num4 = num;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00025D28 File Offset: 0x00023F28
		private bool a(global::System.Func<bool> A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)924134758;
				short num2 = num;
				num = (short)1250569574;
				switch (num2 == num)
				{
				}
				num = (short)621019136;
				if (num != 0)
				{
				}
				result = A_0();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)2041643008;
			short num3 = num;
			num = (short)537329665;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00025DF4 File Offset: 0x00023FF4
		private void i()
		{
			int a_ = 8;
			short num = (short)1332474356;
			short num2 = num;
			num = (short)422506996;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1631322113;
				if (num != 0)
				{
				}
				num = (short)2091188224;
				short num3 = num;
				num = (short)1143996416;
				if (num != 0)
				{
				}
				string text = global::System.AppDomain.CurrentDomain.BaseDirectory + global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("낿껁ꯃꟅ곇飉꧋뿍ꗏ럑ꟓꋕ蓗꿙곛닝迟菡胣맥髧迩鷫鯭闯臱胳\ud8f5胷韹郻", a_);
				try
				{
					num = (short)795934722;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_1B7;
						case 1:
							goto IL_159;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 3:
							goto IL_1B7;
						case 4:
							if (string.IsNullOrEmpty(this.a(text)))
							{
								num = (short)1166802945;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.ScheduleJobContext.UEFileContent = global::System.IO.File.ReadAllBytes(text);
							num = (short)1221525507;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)2038169604;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1CF;
						}
						IL_104:
						if (text.Length > 0)
						{
							num = (short)669319173;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ScheduleJobContext.IsRetrieveLogFilesChecked = false;
						num = (short)1364721664;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B7:
						num = (short)614072326;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_159:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_UE_File_Type_Format_is_Incorrect);
					IL_1CF:;
				}
				catch (global::System.Exception exception)
				{
					this.ScheduleJobContext.IsRetrieveLogFilesChecked = false;
					this.ScheduleJobContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				}
				break;
			}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00026010 File Offset: 0x00024210
		private void h()
		{
			short num = (short)882376928;
			short num2 = num;
			num = (short)1476264160;
			switch (num2 == num)
			{
			}
			num = (short)1759510528;
			short num3 = num;
			num = (short)294387713;
			if (num != 0)
			{
			}
			num = (short)1639120896;
			if (num != 0)
			{
			}
			this.ScheduleJobContext.UEFileContent = null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000260C4 File Offset: 0x000242C4
		private void g()
		{
			short num = (short)56492471;
			short num2 = num;
			num = (short)437060023;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)722075649;
				if (num != 0)
				{
				}
				num = (short)1650130944;
				if (num != 0)
				{
				}
				num = (short)1139867648;
				short num3 = num;
				num = (short)1421344769;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						this.ScheduleJobContext.IsSysCertDisableAllChecked = false;
						num = (short)1648099330;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					case 2:
						goto IL_10D;
					}
					IL_C9:
					if (!this.ScheduleJobContext.IsSysCertDisableAllChecked)
					{
						break;
					}
					num = (short)594411520;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_10D:
				break;
			}
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000261E0 File Offset: 0x000243E0
		private void f()
		{
			short num = (short)512667147;
			short num2 = num;
			num = (short)2121313803;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)258080768;
				if (num != 0)
				{
				}
				num = (short)2081226753;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1575485441;
						if (num != 0)
						{
						}
						this.ScheduleJobContext.IsSysCertEnableAllChcked = false;
						num = (short)118816770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1910243328;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					}
					case 2:
						goto IL_112;
					}
					IL_A6:
					if (!this.ScheduleJobContext.IsSysCertEnableAllChcked)
					{
						break;
					}
					num = (short)8912896;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_112:
				break;
			}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00026304 File Offset: 0x00024504
		private void e()
		{
			short num = (short)958005250;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1787822081;
					if (num != 0)
					{
					}
					num = (short)2132082688;
					short num3 = num;
					this.ScheduleJobContext.EnableImmediateDeployment = false;
					goto IL_10B;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)310178869;
				short num4 = num;
				num = (short)963441717;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_10B:
					num = (short)1037434880;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1187512320;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Force_Immediate_Update_Warning_Content, global::Motorola.CommonCPS.ResourceRepository.Resources.Force_Immediate_Update_Warning_Title))
					{
						return;
					}
					num = (short)588644353;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00026438 File Offset: 0x00024638
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)404094977;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)709230593;
					if (num != 0)
					{
					}
					num = (short)590636197;
					short num3 = num;
					num = (short)1849451685;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)480772096;
						if (num != 0)
						{
						}
						if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("蓀믂ꛄꋆ마뿊꓌ꃎ뿐黒냔ꓖ꫘뫚뫜뫞", a_)))
						{
							goto IL_1A2;
						}
						break;
					}
					num = (short)840171522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContextHandler.UpdateExceptionMessage(this.ScheduleJobContext))
					{
						num = (short)1805385728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 5:
				{
					num = (short)153878528;
					short num4 = num;
					num = (short)1962606596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_45:
				if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闀뫂뗄ꋆ", a_))
				{
					num = (short)1800536069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				num = (short)1551106051;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1A2:
			this.ScheduleJobContext.ExceptionMessage = string.Empty;
			this.ScheduleJobCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00026604 File Offset: 0x00024804
		private string a(string A_0)
		{
			int a_ = 1;
			short num = (short)1073217537;
			if (num != 0)
			{
			}
			num = (short)687669248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text = "";
				string name = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횴\udbb6킸\udeba펼쮾黀ꫂꇄ", a_);
				string name2 = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("펴\udeb6햸\udeba쮾룀돂ꃄ", a_);
				string name3 = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("살잶햸풺\udcbc\udbbe黀뇂ꃄ뛆볈껊뻌믎", a_);
				string item = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("領襁튼\udbbe꓀鏂꧄닆껈", a_);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D0;
					}
					global::System.Collections.IEnumerator enumerator;
					global::System.Collections.Generic.List<string> list;
					for (;;)
					{
						IL_9D:
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_60E;
						case 1:
							goto IL_17E;
						case 2:
							goto IL_10B;
						case 3:
							goto IL_17E;
						case 4:
							try
							{
								num = (short)1266352128;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_20B;
										}
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)463929349;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										num = (short)941424646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_495;
									case 3:
									{
										global::System.Xml.XmlNode xmlNode;
										global::System.Collections.IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										num = (short)1979973636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										try
										{
											num = (short)1323892736;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_2E8;
													}
													continue;
												case 1:
												{
													global::System.Collections.IEnumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)9633797;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
													num = (short)39321603;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													goto IL_3B7;
												case 3:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (xmlNode2.Attributes != null)
													{
														num = (short)1048580;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 4:
												{
													global::System.Xml.XmlNode xmlNode2;
													list.Add(xmlNode2.Attributes[name2].Value);
													num = (short)1343946758;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
													num = (short)280428546;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_361:
												num = (short)1640169473;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_2E8:
												goto IL_361;
											}
											IL_3B7:;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_3D6;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_3C3:
												switch (num2)
												{
												case 0:
													goto IL_42E;
												case 1:
													disposable.Dispose();
													num = (short)1216937984;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													if (disposable != null)
													{
														num = (short)962461697;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_430;
												}
												goto IL_3D6;
											}
											IL_42E:
											IL_430:
											break;
											IL_3D6:
											global::System.Collections.IEnumerator enumerator2;
											disposable = (enumerator2 as global::System.IDisposable);
											num = (short)359399426;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_3C3;
										}
										break;
									case 5:
										num = (short)2026635266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::System.Xml.XmlNode xmlNode;
										if (string.Equals(xmlNode.Attributes[name].Value.ToUpperInvariant(), global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("襁", a_), global::System.StringComparison.Ordinal))
										{
											num = (short)806092803;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_472;
									}
									}
									IL_431:
									num = (short)1915879425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20B:
									goto IL_431;
								}
								IL_472:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_UE_File_Upload_Not_For_RM);
								IL_495:
								goto IL_5B6;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_4B7;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_4A4:
									switch (num2)
									{
									case 0:
										goto IL_50F;
									case 1:
										goto IL_4F1;
									case 2:
										if (disposable != null)
										{
											num = (short)88014849;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_50F;
									}
									goto IL_4B7;
									IL_4F1:
									disposable.Dispose();
									num = (short)1498808320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_50F:
									num = (short)2022082520;
									short num3 = num;
									num = (short)2011465688;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4F1;
									default:
										goto IL_544;
									}
								}
								IL_544:
								num = (short)1968177152;
								if (num != 0)
								{
								}
								goto EndFinally_18;
								IL_4B7:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)492765186;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_4A4;
								EndFinally_18:;
							}
							goto IL_55B;
							IL_5B6:
							num = (short)1122631687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (num4 >= list.Count)
							{
								num = (short)1940127752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += list[num4];
							num = (short)1050083338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_55B;
						case 7:
							if (list.Contains(item))
							{
								num = (short)201981961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list.Sort();
							num4 = 0;
							num = (short)1269104641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)319094784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_5F1;
						case 10:
							if (num4 != list.Count - 1)
							{
								num = (short)847708166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10B;
						}
						goto IL_D0;
						IL_10B:
						num4++;
						num = (short)2143617027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17E:
						num = (short)1241251845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_55B:
						text += global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("馴鞶", a_);
						num = (short)700383234;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5F1:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_UE_File_Upload_CanNot_Contains_LMRCodePlug);
					IL_60E:
					goto IL_61C;
					IL_D0:
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(A_0);
					global::System.Xml.XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName(name3);
					list = new global::System.Collections.Generic.List<string>();
					enumerator = elementsByTagName.GetEnumerator();
					num = (short)1159200772;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9D;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch
				{
					text = "";
				}
				IL_61C:
				num = (short)53018624;
				short num5 = num;
				return text;
			}
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00026CBC File Offset: 0x00024EBC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d()
		{
			short num = (short)326893568;
			short num2 = num;
			num = (short)257214567;
			short num3 = num;
			num = (short)843368551;
			switch (num3 == num)
			{
			}
			num = (short)1055653889;
			if (num != 0)
			{
			}
			num = (short)879755264;
			if (num != 0)
			{
			}
			this.a(new global::System.Action(this.c));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00026D78 File Offset: 0x00024F78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c()
		{
			short num = (short)2025652224;
			short num2 = num;
			num = (short)317148074;
			short num3 = num;
			num = (short)2136165290;
			switch (num3 == num)
			{
			}
			num = (short)101777409;
			if (num != 0)
			{
			}
			num = (short)2086076416;
			if (num != 0)
			{
			}
			base.CommandHandler.ScheduleJobCommand.Execute(new object[]
			{
				this.ScheduleJobContext
			});
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00026E44 File Offset: 0x00025044
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b()
		{
			short num = (short)2015035392;
			short num2 = num;
			num = (short)1413774908;
			short num3 = num;
			num = (short)813465148;
			switch (num3 == num)
			{
			}
			num = (short)660668417;
			if (num != 0)
			{
			}
			num = (short)267321344;
			if (num != 0)
			{
			}
			return this.a(new global::System.Func<bool>(this.a));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00026F00 File Offset: 0x00025100
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a()
		{
			short num = (short)1771438080;
			short num2 = num;
			num = (short)912633288;
			short num3 = num;
			num = (short)443526600;
			switch (num3 == num)
			{
			}
			num = (short)1048838145;
			if (num != 0)
			{
			}
			num = (short)722468864;
			if (num != 0)
			{
			}
			return base.CommandHandler.ScheduleJobCommand.CanExecute(new object[]
			{
				this.ScheduleJobContext
			});
		}

		// Token: 0x0400011C RID: 284
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate a;

		// Token: 0x0400011D RID: 285
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext b;

		// Token: 0x0400011E RID: 286
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x0400011F RID: 287
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000120 RID: 288
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000121 RID: 289
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000122 RID: 290
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand g;

		// Token: 0x04000123 RID: 291
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand h;
	}
}
