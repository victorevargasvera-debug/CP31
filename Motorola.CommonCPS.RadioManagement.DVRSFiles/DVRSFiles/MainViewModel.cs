using System;
using System.ComponentModel.Composition;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.PackageBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.DVRSFiles
{
	// Token: 0x02000004 RID: 4
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.PackageBase.PackageMainViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000021C8 File Offset: 0x000003C8
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles, "DVRSFiles")
		{
			base.CommandProxy.DeleteDVRSFilesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.DeleteDVRSFiles), new global::System.Func<bool>(base.CanDeletePackages));
			base.CommandProxy.PrepareImportDVRSFilesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(base.PrepareImportPackages), new global::System.Func<bool>(base.CanPrepareImportPackages));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002233 File Offset: 0x00000433
		private void DeleteDVRSFiles()
		{
			base.DeletePackages();
			base.CommandProxy.DeleteDVRSFilesCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000224B File Offset: 0x0000044B
		protected override void OnSelectedItemsCollectionChanged()
		{
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.DeleteDVRSFilesCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002264 File Offset: 0x00000464
		protected override void LoadPackages()
		{
			try
			{
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetDVRSFilesPackages());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
		}
	}
}
