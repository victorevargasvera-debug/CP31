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
	// Token: 0x02000009 RID: 9
	[global::System.ComponentModel.Composition.Export]
	public class DataProfileDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00003614 File Offset: 0x00001814
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public DataProfileDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 17;
			this.c = string.Empty;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("톯욱햳쪷햹\udabbힽ겿ꟁ胃ꏅ볇ꯉꗋꋍꏏ蓑뷓돕꿗", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfileDetailsViewModel.<>c.<>9.a));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000369C File Offset: 0x0000189C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003748 File Offset: 0x00001948
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)409803539;
				short num2 = num;
				num = (short)321985299;
				switch (num2 == num)
				{
				}
				num = (short)105119745;
				if (num != 0)
				{
				}
				num = (short)1883111424;
				short num3 = num;
				num = (short)743964672;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)541411953;
				short num2 = num;
				num = (short)1687898737;
				switch (num2 == num)
				{
				}
				num = (short)844496897;
				if (num != 0)
				{
				}
				num = (short)1083965440;
				short num3 = num;
				num = (short)1947074560;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000038A8 File Offset: 0x00001AA8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557613889;
				short num2 = num;
				num = (short)616530753;
				switch (num2 == num)
				{
				}
				num = (short)1794637825;
				if (num != 0)
				{
				}
				num = (short)739639296;
				short num3 = num;
				num = (short)1166868480;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1237965982;
				short num2 = num;
				num = (short)875879582;
				switch (num2 == num)
				{
				}
				num = (short)1473708032;
				if (num != 0)
				{
				}
				num = (short)1453785088;
				short num3 = num;
				num = (short)1704525825;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003954 File Offset: 0x00001B54
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1774797506;
			short num2 = num;
			num = (short)1375421122;
			switch (num2 == num)
			{
			}
			num = (short)1830158336;
			if (num != 0)
			{
			}
			num = (short)1379598336;
			short num3 = num;
			num = (short)1019609089;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadiosByProfile(this.b, this.a, this.c));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003A24 File Offset: 0x00001C24
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1251710989;
				short num2 = num;
				num = (short)518494221;
				switch (num2 == num)
				{
				}
				num = (short)1001586688;
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
			num = (short)62586881;
			if (num != 0)
			{
			}
			num = (short)1295908864;
			short num3 = num;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003B04 File Offset: 0x00001D04
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num;
			try
			{
				num = (short)526122283;
				short num2 = num;
				num = (short)203488555;
				switch (num2 == num)
				{
				}
				num = (short)880541696;
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
			num = (short)545062913;
			if (num != 0)
			{
			}
			num = (short)730857472;
			short num3 = num;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003C18 File Offset: 0x00001E18
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 15;
			short num = (short)1631826018;
			short num2 = num;
			num = (short)1372434530;
			switch (num2 == num)
			{
			}
			num = (short)1617362945;
			if (num != 0)
			{
			}
			num = (short)1048969216;
			short num3 = num;
			num = (short)488112128;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.b = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udcad\udfaf잱쒳ﾵﲷ", a_)];
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쾭쒯펱쒵ힷ\udcb9햻튽ꖿ证胃", a_)];
			this.c = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쾭\uddafힱ", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쾭\uddafힱ", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쾭쒯펱쒵ힷ\udcb9햻튽ꖿ蛁ꇃ닅꧇ꏉꃋ뷍蛏믑뇓ꇕ", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x04000008 RID: 8
		private string a;

		// Token: 0x04000009 RID: 9
		private string b;

		// Token: 0x0400000A RID: 10
		private string c;

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioJobsViewModel> d;

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;
	}
}
