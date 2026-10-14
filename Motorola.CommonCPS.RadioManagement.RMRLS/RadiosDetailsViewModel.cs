using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
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
	// Token: 0x02000010 RID: 16
	[global::System.ComponentModel.Composition.Export]
	public class RadiosDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00008928 File Offset: 0x00006B28
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 15;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("愲礴栶欸娺夼嘾⹀あń≆㵈⩊⑌⍎≐Ւ㱔㉖⹘", a_));
			this.PrepareRegisterRadioLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e), new global::System.Func<bool>(this.c));
			this.RestoreRadioLicenseCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000089B4 File Offset: 0x00006BB4
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00008A64 File Offset: 0x00006C64
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterRadioLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1838978268;
				short num2 = num;
				num = (short)1240634588;
				switch (num2 == num)
				{
				}
				num = (short)429850625;
				if (num != 0)
				{
				}
				num = (short)1827864576;
				if (num != 0)
				{
				}
				num = (short)1567162368;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)320877407;
				short num2 = num;
				num = (short)650982239;
				switch (num2 == num)
				{
				}
				num = (short)1609695233;
				if (num != 0)
				{
				}
				num = (short)140115968;
				if (num != 0)
				{
				}
				num = (short)906100736;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00008B18 File Offset: 0x00006D18
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00008BCC File Offset: 0x00006DCC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RestoreRadioLicenseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)956086285;
				short num2 = num;
				num = (short)1770240013;
				switch (num2 == num)
				{
				}
				num = (short)1467351040;
				if (num != 0)
				{
				}
				num = (short)1589248001;
				if (num != 0)
				{
				}
				num = (short)1024262144;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)509567735;
				short num2 = num;
				num = (short)1371103991;
				switch (num2 == num)
				{
				}
				num = (short)1938292737;
				if (num != 0)
				{
				}
				num = (short)1646395392;
				if (num != 0)
				{
				}
				num = (short)1540292608;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008C7C File Offset: 0x00006E7C
		private void e()
		{
			short num;
			try
			{
				num = (short)261549670;
				short num2 = num;
				num = (short)897707622;
				switch (num2 == num)
				{
				}
				num = (short)415301632;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1611202561;
			if (num != 0)
			{
			}
			num = (short)2055733248;
			short num3 = num;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008D58 File Offset: 0x00006F58
		private void d()
		{
			short num;
			try
			{
				num = (short)540128997;
				short num2 = num;
				num = (short)992458469;
				switch (num2 == num)
				{
				}
				num = (short)2042167296;
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
			num = (short)204079105;
			if (num != 0)
			{
			}
			num = (short)445579264;
			short num3 = num;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008E44 File Offset: 0x00007044
		private void a(int ftype)
		{
			short num = (short)784035281;
			short num2 = num;
			num = (short)1162833361;
			switch (num2 == num)
			{
			}
			num = (short)1745616897;
			if (num != 0)
			{
			}
			num = (short)927137792;
			if (num != 0)
			{
			}
			num = (short)172818432;
			short num3 = num;
			this.b = ftype;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008EF4 File Offset: 0x000070F4
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)1539795984;
				short num2 = num;
				num = (short)1183018000;
				switch (num2 == num)
				{
				}
				num = (short)1400373248;
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
			num = (short)1136656385;
			if (num != 0)
			{
			}
			num = (short)2016739328;
			short num3 = num;
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008FD4 File Offset: 0x000071D4
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)539721141;
				short num2 = num;
				num = (short)233536949;
				switch (num2 == num)
				{
				}
				num = (short)340590592;
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
			num = (short)650313729;
			if (num != 0)
			{
			}
			num = (short)1578827776;
			short num3 = num;
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000090C0 File Offset: 0x000072C0
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1113887513;
			short num2 = num;
			num = (short)1469158169;
			switch (num2 == num)
			{
			}
			num = (short)1048117248;
			if (num != 0)
			{
			}
			num = (short)826933249;
			if (num != 0)
			{
			}
			num = (short)1028915200;
			short num3 = num;
			this.RestoreRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009174 File Offset: 0x00007374
		protected override void Refresh()
		{
			short num = (short)878257809;
			short num2 = num;
			num = (short)1259480721;
			switch (num2 == num)
			{
			}
			num = (short)212795393;
			if (num != 0)
			{
			}
			num = (short)1448673280;
			if (num != 0)
			{
			}
			num = (short)1140457472;
			short num3 = num;
			this.a();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009224 File Offset: 0x00007424
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)598697128;
				short num2 = num;
				num = (short)141714600;
				switch (num2 == num)
				{
				}
				num = (short)846397440;
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
			num = (short)1351024641;
			if (num != 0)
			{
			}
			num = (short)1236533248;
			short num3 = num;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009300 File Offset: 0x00007500
		private void a()
		{
			short num;
			try
			{
				num = (short)1250691182;
				short num2 = num;
				num = (short)1855391854;
				switch (num2 == num)
				{
				}
				num = (short)2095185920;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadioFeatureDetailsByRadio(this.a, this.b));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)675807233;
			if (num != 0)
			{
			}
			num = (short)1025572864;
			short num3 = num;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000093F0 File Offset: 0x000075F0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 8;
			short num = (short)1574027847;
			short num2 = num;
			num = (short)172474951;
			switch (num2 == num)
			{
			}
			num = (short)1132265473;
			if (num != 0)
			{
			}
			num = (short)900464640;
			if (num != 0)
			{
			}
			num = (short)1549991936;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = new global::System.Guid(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("縫伭启嬱嬳缵簷", a_)]);
			this.a();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("缫䬭䈯嬱唳娵瘷伹儻尽┿ぁ", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("縫戭漯怱唳刵儷唹伻稽┿㙁╃⽅⑇㥉ᩋ❍㕏║", a_);
		}

		// Token: 0x0400002E RID: 46
		private global::System.Guid a;

		// Token: 0x0400002F RID: 47
		private int b;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;
	}
}
