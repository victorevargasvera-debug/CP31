using System;
using System.ComponentModel.Composition;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.PackageBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.VoiceAnnouncement
{
	// Token: 0x02000004 RID: 4
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.PackageBase.PackageMainViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002500 File Offset: 0x00000700
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 19;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement, global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ⱹ፻᝽얃曆煉", a_));
			base.CommandProxy.DeleteVoiceAnnouncementsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(base.CanDeletePackages));
			base.CommandProxy.PrepareImportVoiceAnnouncementsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(base.PrepareImportPackages), new global::System.Func<bool>(base.CanPrepareImportPackages));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000257C File Offset: 0x0000077C
		private void a()
		{
			short num = (short)44761089;
			if (num != 0)
			{
			}
			num = (short)90758312;
			short num2 = num;
			num = (short)842783912;
			switch (num2 == num)
			{
			}
			num = (short)1039532032;
			if (num != 0)
			{
			}
			num = (short)411959296;
			short num3 = num;
			base.DeletePackages();
			base.CommandProxy.DeleteVoiceAnnouncementsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000263C File Offset: 0x0000083C
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)617430892;
			short num2 = num;
			num = (short)1396195180;
			switch (num2 == num)
			{
			}
			num = (short)451870721;
			if (num != 0)
			{
			}
			num = (short)1858142208;
			if (num != 0)
			{
			}
			num = (short)69009408;
			short num3 = num;
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.DeleteVoiceAnnouncementsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000026FC File Offset: 0x000008FC
		protected override void LoadPackages()
		{
			short num;
			try
			{
				num = (short)1691527167;
				short num2 = num;
				num = (short)1875617791;
				switch (num2 == num)
				{
				}
				num = (short)410058752;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetVoiceAnnouncementPackages());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)391118849;
			if (num != 0)
			{
			}
			num = (short)1618345984;
			short num3 = num;
		}
	}
}
