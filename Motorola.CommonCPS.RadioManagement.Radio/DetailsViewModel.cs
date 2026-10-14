using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200000D RID: 13
	[global::System.ComponentModel.Composition.Export]
	public class DetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000058A4 File Offset: 0x00003AA4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public DetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.CommandProxy.RestoreRadioCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.b));
			base.CommandProxy.CloseDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c));
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000058FC File Offset: 0x00003AFC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000059AC File Offset: 0x00003BAC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails Details
		{
			get
			{
				short num = (short)958596668;
				short num2 = num;
				num = (short)300287548;
				switch (num2 == num)
				{
				}
				num = (short)2052259840;
				if (num != 0)
				{
				}
				num = (short)211484673;
				if (num != 0)
				{
				}
				num = (short)800980992;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)412352514;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)9895937;
					if (num != 0)
					{
					}
					num = (short)574881792;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.a = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.DetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Radio.DetailsViewModel.get_Details())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)402915328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)843356313;
						short num4 = num;
						num = (short)1065851033;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6;
						default:
							num = (short)2025193472;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						}
						break;
					}
					}
					goto IL_CD;
					IL_D6:
					num = (short)1391460353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD:
					if (value != this.a)
					{
						goto IL_D6;
					}
					break;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005AFC File Offset: 0x00003CFC
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00005BAC File Offset: 0x00003DAC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext ShowMismatchOptionsContext
		{
			get
			{
				short num = (short)203627019;
				short num2 = num;
				num = (short)827136523;
				switch (num2 == num)
				{
				}
				num = (short)55705600;
				if (num != 0)
				{
				}
				num = (short)321191937;
				if (num != 0)
				{
				}
				num = (short)324599808;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1603796994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)318111745;
						if (num != 0)
						{
						}
						this.c = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.DetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Radio.DetailsViewModel.get_ShowMismatchOptionsContext())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1364983808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1268563180;
						short num3 = num;
						num = (short)712817900;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)542572544;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						}
						break;
					}
					}
					goto IL_79;
					IL_AE:
					num = (short)1532559361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79:
					num = (short)993001472;
					short num4 = num;
					if (value != this.c)
					{
						goto IL_AE;
					}
					break;
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005CFC File Offset: 0x00003EFC
		private void d()
		{
			short num;
			try
			{
				num = (short)262002749;
				short num2 = num;
				num = (short)2028197949;
				switch (num2 == num)
				{
				}
				num = (short)706019328;
				if (num != 0)
				{
				}
				num = (short)265879553;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.RestoreCommand.Execute(new object[]
				{
					this.a,
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1005977600;
			short num3 = num;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005DF4 File Offset: 0x00003FF4
		private void c()
		{
			int a_ = 11;
			short num = (short)1118067204;
			short num2 = num;
			num = (short)857037316;
			switch (num2 == num)
			{
			}
			num = (short)773914624;
			if (num != 0)
			{
			}
			num = (short)512491521;
			if (num != 0)
			{
			}
			num = (short)784859136;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀꟂ계꣆뫈鷊꓌꫎ꛐ", a_));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005EB8 File Offset: 0x000040B8
		protected override void Refresh()
		{
			short num = (short)1881492873;
			short num2 = num;
			num = (short)236146057;
			switch (num2 == num)
			{
			}
			num = (short)1920008193;
			if (num != 0)
			{
			}
			num = (short)147587072;
			if (num != 0)
			{
			}
			num = (short)127074304;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005F64 File Offset: 0x00004164
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)31337365;
			short num2 = num;
			num = (short)1551444885;
			switch (num2 == num)
			{
			}
			num = (short)612302849;
			if (num != 0)
			{
			}
			num = (short)1488257024;
			if (num != 0)
			{
			}
			num = (short)869138432;
			short num3 = num;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000600C File Offset: 0x0000420C
		private bool b()
		{
			int a_ = 17;
			short num = (short)997261317;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)885444982;
				short num3 = num;
				num = (short)1040109942;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_18C;
				case 1:
					break;
				default:
				{
					num = (short)1420820480;
					short num4 = num;
					break;
				}
				}
				num = (short)2076049408;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1808072705;
					if (num != 0)
					{
					}
					num = (short)1993867268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ServiceProxy.CommandHandler.RestoreCommand != null)
					{
						goto IL_18C;
					}
					return false;
				case 2:
					goto IL_15A;
				case 3:
					num = (short)179437569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.ServiceProxy.CommandHandler.RestoreCommand.CanExecute(new object[]
					{
						this.a,
						base.SelectedItems
					}))
					{
						num = (short)959971330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_C1;
					}
					continue;
				case 6:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("韄飆跈껊만껎룐뿒ꛔ臖냘뻚ꫜ", a_))
					{
						num = (short)1279590403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					num = (short)1910636550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C1:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("韄ꛆ귈ꋊꋌ", a_))
				{
					num = (short)819789831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_18C:
				num = (short)1030946816;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_15A:
			return this.a(this.a.ProductFamily);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000624C File Offset: 0x0000444C
		private bool a(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily A_0)
		{
			short num = (short)860094467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num = (short)747831298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					return false;
				case 2:
					num = (short)1305804807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1833107457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 4:
					goto IL_A6;
				case 5:
					num = (short)1398276096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1563426816;
					short num3 = num;
					num = (short)111214596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
					{
						return false;
					}
					num = (short)1274658915;
					short num4 = num;
					num = (short)1927069795;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A6;
					default:
						num = (short)346095616;
						if (num != 0)
						{
						}
						num = (short)1324941318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_6C:
				if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
				{
					num = (short)1725956101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A6:
				if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
				{
					return true;
				}
				num = (short)269811713;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006418 File Offset: 0x00004618
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)867799022;
			short num2 = num;
			num = (short)927240174;
			switch (num2 == num)
			{
			}
			num = (short)1009057793;
			if (num != 0)
			{
			}
			num = (short)21233664;
			if (num != 0)
			{
			}
			num = (short)207290368;
			short num3 = num;
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.RestoreRadioCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000064D8 File Offset: 0x000046D8
		private void a()
		{
			short num;
			try
			{
				num = (short)1966984904;
				short num2 = num;
				num = (short)694079176;
				switch (num2 == num)
				{
				}
				num = (short)2037579777;
				if (num != 0)
				{
				}
				num = (short)1919549440;
				if (num != 0)
				{
				}
				this.Details = base.ServiceProxy.LocalService.GetRadioDetails(new global::System.Guid(this.b), false);
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.a.HistoricalJobs);
				bool isRadioInfoVisible = this.Details.IsRadioInfoVisible;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1641742336;
			short num3 = num;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000065E0 File Offset: 0x000047E0
		public override void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 18;
			short num = (short)218329803;
			short num2 = num;
			num = (short)1478521547;
			switch (num2 == num)
			{
			}
			num = (short)583598081;
			if (num != 0)
			{
			}
			num = (short)635502592;
			if (num != 0)
			{
			}
			num = (short)1847984128;
			short num3 = num;
			navigationContext.Parameters.Add(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闅Ꟈ뿉뻋귍뗏蓑뷓돕꿗", a_), global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅韇軉꧋뫍뇏믑룓ꗕ軗동맛꧝", a_));
			base.OnNavigatedFrom(navigationContext);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000066C0 File Offset: 0x000048C0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 13;
			short num = (short)1392693612;
			short num2 = num;
			num = (short)114282860;
			switch (num2 == num)
			{
			}
			num = (short)1784283137;
			if (num != 0)
			{
			}
			num = (short)843710464;
			if (num != 0)
			{
			}
			num = (short)607911936;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.d = long.Parse(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铀諂蛄꿆꣈ꗊ꫌꫎飐뷒뇔뻖뫘뫚꧜냞鏠", a_)], global::System.Globalization.CultureInfo.InvariantCulture);
			this.b = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ苊觌", a_)];
			this.a();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鋀ꛂ럄껆꣈ꟊ菌뫎볐뇒냔ꗖ", a_)] + global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Details);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀鳂臄ꋆ뷈꫊꓌ꏎꋐ藒볔닖께", a_);
			base.CommandProxy.PrepareScheduleJobCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0400002A RID: 42
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a;

		// Token: 0x0400002B RID: 43
		private string b;

		// Token: 0x0400002C RID: 44
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext c;

		// Token: 0x0400002D RID: 45
		private long d;
	}
}
