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
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000009 RID: 9
	[global::System.ComponentModel.Composition.Export]
	public class OtarProfileDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003A84 File Offset: 0x00001C84
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public OtarProfileDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 0;
			this.c = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo();
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၐRŔՖᙘњቜ⭞`ᅢ㕤ᕦ٨൪Ѭͮᑰ㝲ၴͶᡸቺᅼ౾힀", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.OtarProfileDetailsViewModel.<>c.<>9.a));
			this.CellFillStartedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003B38 File Offset: 0x00001D38
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1898859006;
				short num2 = num;
				num = (short)420825598;
				switch (num2 == num)
				{
				}
				num = (short)1965686784;
				short num3 = num;
				num = (short)1853095936;
				if (num != 0)
				{
				}
				num = (short)1294598145;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1031667713;
				if (num != 0)
				{
				}
				num = (short)1986670780;
				short num2 = num;
				num = (short)229716156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481768960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172097536;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003C98 File Offset: 0x00001E98
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003D48 File Offset: 0x00001F48
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)647799025;
				short num2 = num;
				num = (short)1523687665;
				switch (num2 == num)
				{
				}
				num = (short)946405376;
				short num3 = num;
				num = (short)1698627585;
				if (num != 0)
				{
				}
				num = (short)1542324224;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)173262944;
				short num2 = num;
				num = (short)1402128480;
				switch (num2 == num)
				{
				}
				num = (short)1493499904;
				short num3 = num;
				num = (short)621608960;
				if (num != 0)
				{
				}
				num = (short)339148801;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003DFC File Offset: 0x00001FFC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003EB0 File Offset: 0x000020B0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1754558848;
				short num2 = num;
				num = (short)1936880000;
				switch (num2 == num)
				{
				}
				num = (short)2067070976;
				short num3 = num;
				num = (short)1339031552;
				if (num != 0)
				{
				}
				num = (short)2035417089;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)302162736;
				short num2 = num;
				num = (short)21865264;
				switch (num2 == num)
				{
				}
				num = (short)1873674240;
				short num3 = num;
				num = (short)702611456;
				if (num != 0)
				{
				}
				num = (short)1559363585;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003F64 File Offset: 0x00002164
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00004014 File Offset: 0x00002214
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)374081044;
				short num2 = num;
				num = (short)769328660;
				switch (num2 == num)
				{
				}
				num = (short)2024144896;
				short num3 = num;
				num = (short)819658752;
				if (num != 0)
				{
				}
				num = (short)729874433;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)998440961;
				if (num != 0)
				{
				}
				num = (short)1410828780;
				short num2 = num;
				num = (short)519539180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593507840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133117440;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000040C4 File Offset: 0x000022C4
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)2022613990;
			short num2 = num;
			num = (short)1195025382;
			switch (num2 == num)
			{
			}
			num = (short)2036006912;
			short num3 = num;
			num = (short)1967259649;
			if (num != 0)
			{
			}
			num = (short)1241448448;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTRORadiosByOtarProfile(this.a, this.c));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000419C File Offset: 0x0000239C
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)462125641;
				short num2 = num;
				num = (short)1010858569;
				switch (num2 == num)
				{
				}
				num = (short)1739194368;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveASTROOTARProfileCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)1227423745;
			if (num != 0)
			{
			}
			num = (short)91619328;
			short num3 = num;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004278 File Offset: 0x00002478
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			short num;
			try
			{
				num = (short)2143139900;
				short num2 = num;
				num = (short)1796323388;
				switch (num2 == num)
				{
				}
				num = (short)1913061377;
				if (num != 0)
				{
				}
				num = (short)1091043328;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails = base.ServiceProxy.LocalService.GetRadioDetails(A_0.RadioID.Value, false);
				this.ShowRadioDetailsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, radioDetails)
				{
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ViewRadioDetails
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)272826368;
			short num3 = num;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000438C File Offset: 0x0000258C
		private void b()
		{
			short num = (short)1573978113;
			if (num != 0)
			{
			}
			num = (short)1284025095;
			short num2 = num;
			num = (short)802073351;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1585905664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)603848704;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004440 File Offset: 0x00002640
		private void a()
		{
			short num = (short)760769162;
			short num2 = num;
			num = (short)799959690;
			switch (num2 == num)
			{
			}
			num = (short)2069495808;
			short num3 = num;
			num = (short)307953665;
			if (num != 0)
			{
			}
			num = (short)1289158656;
			if (num != 0)
			{
			}
			base.ServiceProxy.LocalService.RefreshASTROOtarProfilesForFillUpDown(base.SelectedItems);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004500 File Offset: 0x00002700
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 4;
			short num = (short)1218772993;
			if (num != 0)
			{
			}
			num = (short)1832111638;
			short num2 = num;
			num = (short)1681575446;
			switch (num2 == num)
			{
			default:
			{
				num = (short)214040576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1799815168;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ቔ╖㙘⹚ⵜᙞ╠", a_)];
			this.b = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᩔ⍖㡘⥚൜ⵞ๠բ౤୦౨╪౬ɮᑰ", a_)];
			this.c.OtarProfileName = this.b;
			this.c.IndependentList = bool.Parse(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᱔㥖㵘㹚ⵜ㩞འݢd०ᵨ❪Ѭᱮհ", a_)]);
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(this.b);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᑔі൘ग़ቜ^⹠ᝢѤᕦ㥨ᥪɬ८ᡰὲၴ㍶ᱸེᱼᙾ펄ﲊ", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x0400000A RID: 10
		private string a;

		// Token: 0x0400000B RID: 11
		private string b;

		// Token: 0x0400000C RID: 12
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo c;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel> d;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand g;
	}
}
