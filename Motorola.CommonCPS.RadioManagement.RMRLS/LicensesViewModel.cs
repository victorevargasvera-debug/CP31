using System;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x0200000B RID: 11
	[global::System.ComponentModel.Composition.Export]
	public class LicensesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000051D4 File Offset: 0x000033D4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public LicensesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.PrepareRegisterRadioLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.f), new global::System.Func<bool>(this.d));
			this.RestoreRadioLicenseCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e), new global::System.Func<bool>(this.c));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintCommandRequestedEvent>().Subscribe(new global::System.Action<object>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintPreviewCommandRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005280 File Offset: 0x00003480
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005334 File Offset: 0x00003534
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterRadioLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)444006401;
				if (num != 0)
				{
				}
				num = (short)1289282728;
				short num2 = num;
				num = (short)1722672296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556859392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)971964416;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1036927437;
				short num2 = num;
				num = (short)968901069;
				switch (num2 == num)
				{
				}
				num = (short)2134114304;
				short num3 = num;
				num = (short)1242955776;
				if (num != 0)
				{
				}
				num = (short)1817116673;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000053E4 File Offset: 0x000035E4
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00005494 File Offset: 0x00003694
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RestoreRadioLicenseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1473361314;
				short num2 = num;
				num = (short)416134562;
				switch (num2 == num)
				{
				}
				num = (short)1232404480;
				short num3 = num;
				num = (short)1329922048;
				if (num != 0)
				{
				}
				num = (short)1470693377;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1768292353;
				if (num != 0)
				{
				}
				num = (short)539628023;
				short num2 = num;
				num = (short)1957106167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1617100800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558956544;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005540 File Offset: 0x00003740
		private void b(object A_0)
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)1987641346;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ServiceProxy.CommandHandler.PrintViewCommand.Execute(new object[]
						{
							base.SelectedItems
						});
						num = (short)3735555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("笨未爬挮堰倲倴夶䨸帺丼椾⡀♂㉄", a_))
						{
							num = (short)1649606656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
					{
						num = (short)180414931;
						short num3 = num;
						num = (short)2126965203;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_150;
						default:
							num = (short)1374027776;
							if (num != 0)
							{
							}
							goto IL_150;
						}
						break;
					}
					case 4:
						goto IL_167;
					case 5:
						num = (short)1437007873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_45:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("笨䨪䤬䘮帰缲尴吶尸唺丼娾", a_))
					{
						num = (short)531496965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_150:
					num = (short)574291972;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_167:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1120272385;
			if (num != 0)
			{
			}
			num = (short)1445396480;
			short num4 = num;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005730 File Offset: 0x00003930
		private void a(object A_0)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)1684078594;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ServiceProxy.CommandHandler.PrintPreviewCommand.Execute(new object[]
						{
							base.SelectedItems
						});
						num = (short)877527043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)358678529;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("礪愬瀮細娲嘴制圸䠺堼䰾ᝀ⩂⁄う", a_))
						{
							num = (short)1282867200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 3:
					{
						num = (short)94555177;
						short num3 = num;
						num = (short)1212599337;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17A;
						default:
							num = (short)1215561728;
							if (num != 0)
							{
							}
							goto IL_17A;
						}
						break;
					}
					case 4:
						goto IL_193;
					case 5:
						num = (short)167837697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_46:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("礪䰬䬮堰尲礴帶娸帺匼䰾⑀", a_))
					{
						num = (short)396165125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_17A:
					num = (short)1410531332;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_193:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1482686464;
			short num4 = num;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005924 File Offset: 0x00003B24
		private void a(int ftype)
		{
			short num = (short)1823539202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)151257089;
					if (num != 0)
					{
					}
					this.b = ftype;
					this.a();
					this.Refresh();
					num = (short)1145259001;
					short num3 = num;
					num = (short)2002535417;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2020999168;
						if (num != 0)
						{
						}
						num = (short)297926656;
						short num4 = num;
						num = (short)599654401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.b == ftype)
				{
					break;
				}
				num = (short)1409941504;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005A4C File Offset: 0x00003C4C
		private void f()
		{
			short num;
			try
			{
				num = (short)1435694571;
				short num2 = num;
				num = (short)637793771;
				switch (num2 == num)
				{
				}
				num = (short)1975648256;
				if (num != 0)
				{
				}
				num = (short)1398407169;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1285685248;
			short num3 = num;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005B28 File Offset: 0x00003D28
		private void e()
		{
			short num;
			try
			{
				num = (short)963942109;
				short num2 = num;
				num = (short)803444445;
				switch (num2 == num)
				{
				}
				num = (short)1587806208;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.RestoreRadioLicenseCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1238630401;
			if (num != 0)
			{
			}
			num = (short)1886191616;
			short num3 = num;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005C14 File Offset: 0x00003E14
		private bool d()
		{
			short num;
			bool result;
			try
			{
				num = (short)369617807;
				short num2 = num;
				num = (short)1351216015;
				switch (num2 == num)
				{
				}
				num = (short)746979329;
				if (num != 0)
				{
				}
				num = (short)451084288;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.CanExecute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1172045824;
			short num3 = num;
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005CF8 File Offset: 0x00003EF8
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)37391819;
				short num2 = num;
				num = (short)998215115;
				switch (num2 == num)
				{
				}
				num = (short)1158479872;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.RestoreRadioLicenseCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)419102721;
			if (num != 0)
			{
			}
			num = (short)307429376;
			short num3 = num;
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005DEC File Offset: 0x00003FEC
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)2010447873;
			if (num != 0)
			{
			}
			num = (short)1845425670;
			short num2 = num;
			num = (short)2064250374;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1314521088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)178520064;
			if (num != 0)
			{
			}
			this.RestoreRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005EA0 File Offset: 0x000040A0
		protected override void Refresh()
		{
			short num = (short)948043777;
			if (num != 0)
			{
			}
			num = (short)1385926839;
			short num2 = num;
			num = (short)1705545911;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1501233152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)938147840;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005F50 File Offset: 0x00004150
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)799284667;
				short num2 = num;
				num = (short)55451067;
				switch (num2 == num)
				{
				}
				num = (short)1939734528;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveRadioLicenseCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				throw;
			}
			num = (short)180617217;
			if (num != 0)
			{
			}
			num = (short)1678770176;
			short num3 = num;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000602C File Offset: 0x0000422C
		private void b()
		{
			short num;
			try
			{
				num = (short)726649328;
				short num2 = num;
				num = (short)491309552;
				switch (num2 == num)
				{
				}
				num = (short)1551958017;
				if (num != 0)
				{
				}
				num = (short)923074560;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadioFeatures(this.a, this.b));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)151322624;
			short num3 = num;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006118 File Offset: 0x00004318
		private void a()
		{
			short num = (short)1553210981;
			short num2 = num;
			num = (short)1597578853;
			switch (num2 == num)
			{
			}
			num = (short)1681063936;
			short num3 = num;
			num = (short)1616248833;
			if (num != 0)
			{
			}
			num = (short)2136276992;
			if (num != 0)
			{
			}
			this.AstroRadioLicenseVisibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000061C8 File Offset: 0x000043C8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00006278 File Offset: 0x00004478
		public global::System.Windows.Visibility AstroRadioLicenseVisibility
		{
			get
			{
				short num = (short)1939794247;
				short num2 = num;
				num = (short)1771235655;
				switch (num2 == num)
				{
				}
				num = (short)1287454720;
				short num3 = num;
				num = (short)866189313;
				if (num != 0)
				{
				}
				num = (short)770834432;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1868759042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.c = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.LicensesViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.LicensesViewModel.get_AstroRadioLicenseVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1516597490;
						short num3 = num;
						num = (short)797143282;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)609943553;
							if (num != 0)
							{
							}
							num = (short)1476198400;
							if (num != 0)
							{
							}
							num = (short)1231290368;
							short num4 = num;
							num = (short)1652948993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.c)
					{
						break;
					}
					num = (short)1392050176;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000063C8 File Offset: 0x000045C8
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 11;
			short num = (short)973046021;
			short num2 = num;
			num = (short)1081835781;
			switch (num2 == num)
			{
			}
			num = (short)1067974656;
			short num3 = num;
			num = (short)248119297;
			if (num != 0)
			{
			}
			num = (short)2046427136;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("栮䌰尲䀴䜶瀸缺", a_)];
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("紮細氲礴帶娸帺匼䰾⑀あፄ⹆ⱈ㱊", a_);
			this.b();
			this.a();
		}

		// Token: 0x04000018 RID: 24
		private string a;

		// Token: 0x04000019 RID: 25
		private int b;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Visibility c = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;
	}
}
