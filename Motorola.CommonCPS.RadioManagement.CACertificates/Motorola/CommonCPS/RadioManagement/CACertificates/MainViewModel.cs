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

namespace Motorola.CommonCPS.RadioManagement.CACertificates
{
	// Token: 0x02000006 RID: 6
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.PackageBase.PackageMainViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002930 File Offset: 0x00000B30
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 7;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates, global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("﮷\udfb9캻쪽ꦿ꓁귃ꗅ꧇뻉꧋뷍", a_));
			base.CommandProxy.DeleteCACertificatesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(base.CanDeletePackages));
			base.CommandProxy.PrepareImportCACertificatesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(base.PrepareImportPackages), new global::System.Func<bool>(base.CanPrepareImportPackages));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029B0 File Offset: 0x00000BB0
		private void a()
		{
			short num = (short)1364685727;
			short num2 = num;
			num = (short)1009808287;
			switch (num2 == num)
			{
			}
			num = (short)119603200;
			short num3 = num;
			num = (short)1965555713;
			if (num != 0)
			{
			}
			num = (short)1078788096;
			if (num != 0)
			{
			}
			base.DeletePackages();
			base.CommandProxy.DeleteCACertificatesCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A70 File Offset: 0x00000C70
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1290618958;
			short num2 = num;
			num = (short)2021738574;
			switch (num2 == num)
			{
			}
			num = (short)65404928;
			short num3 = num;
			num = (short)1306591232;
			if (num != 0)
			{
			}
			num = (short)707985409;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.DeleteCACertificatesCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B30 File Offset: 0x00000D30
		protected override void LoadPackages()
		{
			short num;
			try
			{
				num = (short)331277887;
				short num2 = num;
				num = (short)987096639;
				switch (num2 == num)
				{
				}
				num = (short)1828061184;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetCACertificatesPackages());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1639317504;
			short num3 = num;
			num = (short)1304297473;
			if (num != 0)
			{
			}
		}
	}
}
