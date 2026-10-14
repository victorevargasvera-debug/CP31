using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.PackageBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LanguagePack
{
	// Token: 0x02000006 RID: 6
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.PackageBase.PackageMainViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00004658 File Offset: 0x00002858
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 2;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack, global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ᙙ㵛そݟᝡգť൧㩩൫൭᭯", a_));
			base.CommandProxy.DeleteLanguagePacksCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(base.CanDeletePackages));
			base.CommandProxy.PrepareImportLanguagePacksCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(base.PrepareImportPackages), new global::System.Func<bool>(base.CanPrepareImportPackages));
			this.ShowImportLanguagePackDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackViewModel>();
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportLanguagePackDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext>(this.a));
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000046FC File Offset: 0x000028FC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000047AC File Offset: 0x000029AC
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackViewModel> ShowImportLanguagePackDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2051887972;
				short num2 = num;
				num = (short)1098666852;
				switch (num2 == num)
				{
				}
				num = (short)1688141825;
				if (num != 0)
				{
				}
				num = (short)1916993536;
				if (num != 0)
				{
				}
				num = (short)1169883136;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2050127053;
				short num2 = num;
				num = (short)248149197;
				switch (num2 == num)
				{
				}
				num = (short)1036058624;
				if (num != 0)
				{
				}
				num = (short)560267265;
				if (num != 0)
				{
				}
				num = (short)395902976;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000485C File Offset: 0x00002A5C
		private void a()
		{
			short num = (short)1834792686;
			short num2 = num;
			num = (short)832747246;
			switch (num2 == num)
			{
			}
			num = (short)1170472961;
			if (num != 0)
			{
			}
			num = (short)1421410304;
			if (num != 0)
			{
			}
			num = (short)791478272;
			short num3 = num;
			base.DeletePackages();
			base.CommandProxy.DeleteLanguagePacksCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000491C File Offset: 0x00002B1C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext A_0)
		{
			short num = (short)1041367041;
			if (num != 0)
			{
			}
			num = (short)1148125852;
			short num2 = num;
			num = (short)1338049180;
			switch (num2 == num)
			{
			}
			num = (short)1268645888;
			if (num != 0)
			{
			}
			num = (short)671219712;
			short num3 = num;
			this.ShowImportLanguagePackDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportLanguagePacks
			});
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000049F4 File Offset: 0x00002BF4
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)2137063425;
			if (num != 0)
			{
			}
			num = (short)1198445792;
			short num2 = num;
			num = (short)980604128;
			switch (num2 == num)
			{
			}
			num = (short)152829952;
			if (num != 0)
			{
			}
			num = (short)364904448;
			short num3 = num;
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.DeleteLanguagePacksCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004AB0 File Offset: 0x00002CB0
		protected override void LoadPackages()
		{
			short num;
			try
			{
				num = (short)834770497;
				short num2 = num;
				num = (short)1219270209;
				switch (num2 == num)
				{
				}
				num = (short)164167680;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetLanguagePackages());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)109969409;
			if (num != 0)
			{
			}
			num = (short)2139357184;
			short num3 = num;
		}

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackViewModel> a;
	}
}
