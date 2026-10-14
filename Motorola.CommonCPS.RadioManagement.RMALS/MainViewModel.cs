using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ApplicationLicense
{
	// Token: 0x02000004 RID: 4
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000246C File Offset: 0x0000066C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.PrepareRegisterApplicationLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.c));
			this.ShowRegisterApplicationLicenseDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel>();
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRegisterApplicationLicenseDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext>(this.a));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000024CC File Offset: 0x000006CC
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000257C File Offset: 0x0000077C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel> ShowRegisterApplicationLicenseDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)674886746;
				short num2 = num;
				num = (short)178713690;
				switch (num2 == num)
				{
				}
				num = (short)2106982400;
				short num3 = num;
				num = (short)1849360384;
				if (num != 0)
				{
				}
				num = (short)1165164545;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)230913895;
				short num2 = num;
				num = (short)1036679015;
				switch (num2 == num)
				{
				}
				num = (short)1279590400;
				short num3 = num;
				num = (short)720830465;
				if (num != 0)
				{
				}
				num = (short)397279232;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000262C File Offset: 0x0000082C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext A_0)
		{
			short num = (short)782958593;
			if (num != 0)
			{
			}
			num = (short)1323498089;
			short num2 = num;
			num = (short)1130297961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1774190592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)246087680;
			if (num != 0)
			{
			}
			this.ShowRegisterApplicationLicenseDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_RegisterApplicationLicense
			});
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002704 File Offset: 0x00000904
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000027B4 File Offset: 0x000009B4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterApplicationLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)368246784;
				short num2 = num;
				num = (short)503730104;
				short num3 = num;
				num = (short)519524280;
				switch (num3 == num)
				{
				}
				num = (short)840368128;
				if (num != 0)
				{
				}
				num = (short)1976238081;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)419954688;
				short num2 = num;
				num = (short)491290110;
				short num3 = num;
				num = (short)930446846;
				switch (num3 == num)
				{
				}
				num = (short)529006593;
				if (num != 0)
				{
				}
				num = (short)1137770496;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002864 File Offset: 0x00000A64
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)1012609919;
				short num2 = num;
				num = (short)1808806783;
				switch (num2 == num)
				{
				}
				num = (short)255852544;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.PrepareRegisterApplicationLicenseCommand.CanExecute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				result = false;
			}
			num = (short)762511360;
			short num3 = num;
			num = (short)1044774913;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000294C File Offset: 0x00000B4C
		private void b()
		{
			short num;
			try
			{
				num = (short)205598861;
				short num2 = num;
				num = (short)1640706189;
				switch (num2 == num)
				{
				}
				num = (short)1886715905;
				if (num != 0)
				{
				}
				num = (short)1120468992;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterApplicationLicenseCommand.Execute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
			}
			num = (short)1801388032;
			short num3 = num;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A30 File Offset: 0x00000C30
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1663172608;
			short num2 = num;
			num = (short)1685573910;
			short num3 = num;
			num = (short)741724438;
			switch (num3 == num)
			{
			}
			num = (short)2064515073;
			if (num != 0)
			{
			}
			num = (short)1275658240;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002AD8 File Offset: 0x00000CD8
		protected override void Refresh()
		{
			short num = (short)1866006528;
			short num2 = num;
			num = (short)439177062;
			short num3 = num;
			num = (short)340610918;
			switch (num3 == num)
			{
			}
			num = (short)762445825;
			if (num != 0)
			{
			}
			num = (short)783155200;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B84 File Offset: 0x00000D84
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1073028977;
				short num2 = num;
				num = (short)1404772209;
				switch (num2 == num)
				{
				}
				num = (short)72744960;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveApplicationLicenseCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
			}
			num = (short)1969553408;
			short num3 = num;
			num = (short)913440769;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C5C File Offset: 0x00000E5C
		private void a()
		{
			short num;
			try
			{
				num = (short)582018317;
				short num2 = num;
				num = (short)1836705037;
				switch (num2 == num)
				{
				}
				num = (short)124125184;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.ListAppFeatures());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1277362176;
			short num3 = num;
			num = (short)1869348865;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D3C File Offset: 0x00000F3C
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1001127936;
			short num2 = num;
			num = (short)1056498732;
			short num3 = num;
			num = (short)1479599148;
			switch (num3 == num)
			{
			}
			num = (short)1553399808;
			if (num != 0)
			{
			}
			num = (short)605814785;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a();
		}

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel> a;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
