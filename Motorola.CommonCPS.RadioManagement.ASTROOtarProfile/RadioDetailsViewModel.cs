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
	// Token: 0x02000014 RID: 20
	[global::System.ComponentModel.Composition.Export]
	public class RadioDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00007ED0 File Offset: 0x000060D0
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 12;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᱜ౞㕠ㅢ⩤㡦㭨੪६ٮṰ㝲ၴͶᡸቺᅼ౾힀", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioDetailsViewModel.<>c.<>9.a));
			this.CellFillStartedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00007F7C File Offset: 0x0000617C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000802C File Offset: 0x0000622C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1479377221;
				short num2 = num;
				num = (short)1986363717;
				switch (num2 == num)
				{
				}
				num = (short)542310400;
				if (num != 0)
				{
				}
				num = (short)1148387329;
				if (num != 0)
				{
				}
				num = (short)1067319296;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)694353921;
				if (num != 0)
				{
				}
				num = (short)61024367;
				short num2 = num;
				num = (short)958277743;
				switch (num2 == num)
				{
				}
				num = (short)171638784;
				if (num != 0)
				{
				}
				num = (short)1516437504;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000080DC File Offset: 0x000062DC
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000818C File Offset: 0x0000638C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)564749160;
				short num2 = num;
				num = (short)263938920;
				switch (num2 == num)
				{
				}
				num = (short)1017708545;
				if (num != 0)
				{
				}
				num = (short)438894592;
				if (num != 0)
				{
				}
				num = (short)1812201472;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1051206714;
				short num2 = num;
				num = (short)855385146;
				switch (num2 == num)
				{
				}
				num = (short)2026700801;
				if (num != 0)
				{
				}
				num = (short)1970601984;
				if (num != 0)
				{
				}
				num = (short)302579712;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000823C File Offset: 0x0000643C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000082EC File Offset: 0x000064EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1767521627;
				short num2 = num;
				num = (short)545013083;
				switch (num2 == num)
				{
				}
				num = (short)1668153345;
				if (num != 0)
				{
				}
				num = (short)1157038080;
				if (num != 0)
				{
				}
				num = (short)633143296;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1880548199;
				short num2 = num;
				num = (short)1856627559;
				switch (num2 == num)
				{
				}
				num = (short)1067253761;
				if (num != 0)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				num = (short)415498240;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000839C File Offset: 0x0000659C
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00008448 File Offset: 0x00006648
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)182796365;
				short num2 = num;
				num = (short)1897939021;
				switch (num2 == num)
				{
				}
				num = (short)722468864;
				if (num != 0)
				{
				}
				num = (short)370409473;
				if (num != 0)
				{
				}
				num = (short)1946419200;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1853345760;
				short num2 = num;
				num = (short)511758304;
				switch (num2 == num)
				{
				}
				num = (short)1740439552;
				if (num != 0)
				{
				}
				num = (short)127336449;
				if (num != 0)
				{
				}
				num = (short)534773760;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000084F8 File Offset: 0x000066F8
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1931246448;
			short num2 = num;
			num = (short)1980463984;
			switch (num2 == num)
			{
			}
			num = (short)194052097;
			if (num != 0)
			{
			}
			num = (short)825819136;
			if (num != 0)
			{
			}
			num = (short)1858732032;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROOtarProfileInfosbyRadio(this.a));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000085C4 File Offset: 0x000067C4
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1726145500;
				short num2 = num;
				num = (short)892658652;
				switch (num2 == num)
				{
				}
				num = (short)2129854465;
				if (num != 0)
				{
				}
				num = (short)738918400;
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
			num = (short)1510146048;
			short num3 = num;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000086A0 File Offset: 0x000068A0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			short num;
			try
			{
				num = (short)691201684;
				short num2 = num;
				num = (short)2062673556;
				switch (num2 == num)
				{
				}
				num = (short)1269956609;
				if (num != 0)
				{
				}
				num = (short)35782656;
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
			num = (short)1061224448;
			short num3 = num;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000087B4 File Offset: 0x000069B4
		private void b()
		{
			short num = (short)1818492929;
			if (num != 0)
			{
			}
			num = (short)2123447317;
			short num2 = num;
			num = (short)1973500949;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1309409280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2076704768;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008868 File Offset: 0x00006A68
		private void a()
		{
			short num = (short)1319056521;
			short num2 = num;
			num = (short)863253641;
			switch (num2 == num)
			{
			}
			num = (short)291241984;
			short num3 = num;
			num = (short)853803009;
			if (num != 0)
			{
			}
			num = (short)366477312;
			if (num != 0)
			{
			}
			base.ServiceProxy.LocalService.RefreshASTROOtarProfilesForFillUpDown(base.SelectedItems);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008928 File Offset: 0x00006B28
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 1;
			short num = (short)184212370;
			short num2 = num;
			num = (short)250993554;
			switch (num2 == num)
			{
			}
			num = (short)1327693824;
			short num3 = num;
			num = (short)406585345;
			if (num != 0)
			{
			}
			num = (short)1516044288;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("Q㕓㉕ㅗ㕙ᕛᩝ", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("őㅓ⑕ㅗ㭙せၝᕟཡ٣ͥᩧ", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ፑݓɕ੗ᕙ͛ౝş١ൣ॥Ⱨཀྵᡫ཭᥯ṱݳ⁵ᅷό୻", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x0400002F RID: 47
		private string a;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioJobsViewModel> b;

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;
	}
}
