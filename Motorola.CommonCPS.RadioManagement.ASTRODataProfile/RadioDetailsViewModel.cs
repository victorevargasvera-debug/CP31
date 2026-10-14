using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000014 RID: 20
	[global::System.ComponentModel.Composition.Export]
	public class RadioDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00007038 File Offset: 0x00005238
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 6;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﮨ쪪즬욮\udeb0킴쎶\ud8b8튺톼첾韀ꫂꃄ냆", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDetailsViewModel.<>c.<>9.a));
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000070B4 File Offset: 0x000052B4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00007164 File Offset: 0x00005364
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1623785472;
				short num2 = num;
				num = (short)1689782020;
				short num3 = num;
				num = (short)336725764;
				switch (num3 == num)
				{
				}
				num = (short)282722305;
				if (num != 0)
				{
				}
				num = (short)2045313024;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)236060672;
				short num2 = num;
				num = (short)1073678458;
				short num3 = num;
				num = (short)1658456186;
				switch (num3 == num)
				{
				}
				num = (short)1262092288;
				if (num != 0)
				{
				}
				num = (short)841351169;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00007218 File Offset: 0x00005418
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000072CC File Offset: 0x000054CC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1006043136;
				short num2 = num;
				num = (short)759669456;
				short num3 = num;
				num = (short)1001431760;
				switch (num3 == num)
				{
				}
				num = (short)1760821249;
				if (num != 0)
				{
				}
				num = (short)1964703744;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1409417216;
				short num2 = num;
				num = (short)1914676787;
				short num3 = num;
				num = (short)1432397363;
				switch (num3 == num)
				{
				}
				num = (short)1257701377;
				if (num != 0)
				{
				}
				num = (short)337707008;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007380 File Offset: 0x00005580
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1839267840;
			short num2 = num;
			num = (short)316116108;
			short num3 = num;
			num = (short)1412729996;
			switch (num3 == num)
			{
			}
			num = (short)14417920;
			if (num != 0)
			{
			}
			num = (short)287113217;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetProfileInfosbyRadio(this.a));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007444 File Offset: 0x00005644
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)932876709;
				short num2 = num;
				num = (short)433885605;
				switch (num2 == num)
				{
				}
				num = (short)1139933184;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveASTRODataProfileCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)502202369;
			if (num != 0)
			{
			}
			num = (short)650772480;
			short num3 = num;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007520 File Offset: 0x00005720
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num;
			try
			{
				num = (short)1135305334;
				short num2 = num;
				num = (short)1967874678;
				switch (num2 == num)
				{
				}
				num = (short)2097545216;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails = base.ServiceProxy.LocalService.GetRadioDetails(A_0.DeviceID.Value, false);
				this.ShowRadioDetailsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, radioDetails)
				{
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ViewRadioDetails
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)406323201;
			if (num != 0)
			{
			}
			num = (short)722731008;
			short num3 = num;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007630 File Offset: 0x00005830
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 3;
			short num = (short)1866268672;
			short num2 = num;
			num = (short)958159741;
			short num3 = num;
			num = (short)1917082493;
			switch (num3 == num)
			{
			}
			num = (short)2048196609;
			if (num != 0)
			{
			}
			num = (short)994312192;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쎡삣쾥잧", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("잡횣쾥즧용\udbad\uddaf킱톳쒵", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﮣ즧캩얫솭ힱ삳ힵ톷횹쾻ꦿꟁ돃", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x04000027 RID: 39
		private string a;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel> b;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;
	}
}
