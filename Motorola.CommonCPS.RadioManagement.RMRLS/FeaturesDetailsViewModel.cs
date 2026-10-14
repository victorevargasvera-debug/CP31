using System;
using System.ComponentModel.Composition;
using System.Globalization;
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
	// Token: 0x02000007 RID: 7
	[global::System.ComponentModel.Composition.Export]
	public class FeaturesDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000034B4 File Offset: 0x000016B4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public FeaturesDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 14;
			this.d = global::System.Windows.Visibility.Collapsed;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("怱砳椵縷弹崻䨽㔿ぁ⅃㕅ే⽉㡋⽍㥏㹑❓Uㅗ㽙⭛", a_));
			this.PrepareRegisterRadioLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.f), new global::System.Func<bool>(this.d));
			this.RestoreRadioLicenseCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e), new global::System.Func<bool>(this.c));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003544 File Offset: 0x00001744
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000035F4 File Offset: 0x000017F4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterRadioLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)838414101;
				short num2 = num;
				num = (short)1819946773;
				switch (num2 == num)
				{
				}
				num = (short)150339584;
				short num3 = num;
				num = (short)256114689;
				if (num != 0)
				{
				}
				num = (short)1779499008;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)421000092;
				short num2 = num;
				num = (short)1642328988;
				switch (num2 == num)
				{
				}
				num = (short)204603392;
				short num3 = num;
				num = (short)248053760;
				if (num != 0)
				{
				}
				num = (short)1475936257;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003750 File Offset: 0x00001950
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RestoreRadioLicenseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)634778643;
				short num2 = num;
				num = (short)124711955;
				switch (num2 == num)
				{
				}
				num = (short)1985544192;
				short num3 = num;
				num = (short)691077120;
				if (num != 0)
				{
				}
				num = (short)1685127169;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2036989253;
				short num2 = num;
				num = (short)349044037;
				switch (num2 == num)
				{
				}
				num = (short)471924736;
				short num3 = num;
				num = (short)1592721409;
				if (num != 0)
				{
				}
				num = (short)470089728;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003800 File Offset: 0x00001A00
		private void f()
		{
			short num;
			try
			{
				num = (short)46696010;
				short num2 = num;
				num = (short)1156875850;
				switch (num2 == num)
				{
				}
				num = (short)1344733185;
				if (num != 0)
				{
				}
				num = (short)1677328384;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1371275264;
			short num3 = num;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000038DC File Offset: 0x00001ADC
		private void e()
		{
			short num;
			try
			{
				num = (short)1348958342;
				short num2 = num;
				num = (short)416512134;
				switch (num2 == num)
				{
				}
				num = (short)887619585;
				if (num != 0)
				{
				}
				num = (short)1757872128;
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
			num = (short)508887040;
			short num3 = num;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000039C8 File Offset: 0x00001BC8
		private void a(int ftype)
		{
			short num = (short)1191433551;
			short num2 = num;
			num = (short)1389679951;
			switch (num2 == num)
			{
			}
			num = (short)166854657;
			if (num != 0)
			{
			}
			num = (short)1867186176;
			short num3 = num;
			num = (short)777912320;
			if (num != 0)
			{
			}
			this.c = ftype;
			this.a();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003A80 File Offset: 0x00001C80
		private bool d()
		{
			short num;
			bool result;
			try
			{
				num = (short)1535871190;
				short num2 = num;
				num = (short)1868138710;
				switch (num2 == num)
				{
				}
				num = (short)1433403393;
				if (num != 0)
				{
				}
				num = (short)676921344;
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
			num = (short)1920073728;
			short num3 = num;
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003B60 File Offset: 0x00001D60
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)493218833;
				short num2 = num;
				num = (short)402451473;
				switch (num2 == num)
				{
				}
				num = (short)1253703681;
				if (num != 0)
				{
				}
				num = (short)432209920;
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
			num = (short)561184768;
			short num3 = num;
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003C50 File Offset: 0x00001E50
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)848287434;
			short num2 = num;
			num = (short)1952765642;
			switch (num2 == num)
			{
			}
			num = (short)1385299968;
			if (num != 0)
			{
			}
			num = (short)1804271616;
			short num3 = num;
			num = (short)2060124161;
			if (num != 0)
			{
			}
			this.RestoreRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003D04 File Offset: 0x00001F04
		protected override void Refresh()
		{
			short num = (short)440181902;
			short num2 = num;
			num = (short)242853006;
			switch (num2 == num)
			{
			}
			num = (short)1970143233;
			if (num != 0)
			{
			}
			num = (short)1755250688;
			short num3 = num;
			num = (short)824180736;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003DB0 File Offset: 0x00001FB0
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)2060989346;
				short num2 = num;
				num = (short)635515810;
				switch (num2 == num)
				{
				}
				num = (short)1284177920;
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
			num = (short)1886191617;
			if (num != 0)
			{
			}
			num = (short)1935015936;
			short num3 = num;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003E8C File Offset: 0x0000208C
		private void b()
		{
			short num;
			try
			{
				num = (short)112985010;
				short num2 = num;
				num = (short)730858418;
				switch (num2 == num)
				{
				}
				num = (short)342032384;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadioFeatureDetailsByFeature(this.b, this.a, this.c));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)818937857;
			if (num != 0)
			{
			}
			num = (short)2121924608;
			short num3 = num;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003F80 File Offset: 0x00002180
		private void a()
		{
			short num = (short)403405926;
			short num2 = num;
			num = (short)1944550502;
			switch (num2 == num)
			{
			}
			num = (short)85721089;
			if (num != 0)
			{
			}
			num = (short)1286799360;
			short num3 = num;
			num = (short)1534590976;
			if (num != 0)
			{
			}
			this.AstroRadioLicenseVisibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00004030 File Offset: 0x00002230
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000040DC File Offset: 0x000022DC
		public global::System.Windows.Visibility AstroRadioLicenseVisibility
		{
			get
			{
				short num = (short)172375126;
				short num2 = num;
				num = (short)484064342;
				switch (num2 == num)
				{
				}
				num = (short)1326907393;
				if (num != 0)
				{
				}
				num = (short)1722155008;
				short num3 = num;
				num = (short)607846400;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)587988994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2009399297;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)878364901;
						short num3 = num;
						num = (short)212650213;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2126118912;
							if (num != 0)
							{
							}
							this.d = value;
							base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.FeaturesDetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.FeaturesDetailsViewModel.get_AstroRadioLicenseVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1002569728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					}
					IL_57:
					if (value == this.d)
					{
						break;
					}
					num = (short)1546321920;
					short num4 = num;
					num = (short)1191247873;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004230 File Offset: 0x00002430
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 6;
			short num = (short)1654954472;
			short num2 = num;
			num = (short)1551407592;
			switch (num2 == num)
			{
			}
			num = (short)861667329;
			if (num != 0)
			{
			}
			num = (short)1762000896;
			short num3 = num;
			num = (short)323485696;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.b = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("洩師䄭䔯䈱紳爵", a_)];
			this.a = int.Parse(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("氩䤫伭䐯䜱䘳匵焷縹", a_)], global::System.Globalization.CultureInfo.InvariantCulture);
			this.b();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("氩䤫伭䐯䜱䘳匵瘷嬹儻嬽", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("砩怫焭瘯圱唳䈵䴷䠹夻䴽п❁ぃ❅ⅇ♉㽋ᡍ㥏㝑⍓", a_);
		}

		// Token: 0x0400000B RID: 11
		private int a;

		// Token: 0x0400000C RID: 12
		private string b;

		// Token: 0x0400000D RID: 13
		private int c;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Visibility d;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;
	}
}
