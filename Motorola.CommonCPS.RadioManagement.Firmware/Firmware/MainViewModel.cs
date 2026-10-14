using System;
using System.ComponentModel.Composition;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.PackageBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Firmware
{
	// Token: 0x02000004 RID: 4
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.PackageBase.PackageMainViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002550 File Offset: 0x00000750
		public bool CRUDToolbarVisibility
		{
			get
			{
				short num = (short)308982046;
				short num2 = num;
				num = (short)50901278;
				switch (num2 == num)
				{
				}
				num = (short)402653184;
				if (num != 0)
				{
				}
				num = (short)1183252481;
				if (num != 0)
				{
				}
				num = (short)515375104;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002608 File Offset: 0x00000808
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 17;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ꃥ臧飩臫駭釯胱釳", a_));
			base.CommandProxy.DeleteFirmwaresCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(base.CanDeletePackages));
			base.CommandProxy.PrepareImportFirmwaresCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(base.PrepareImportPackages), new global::System.Func<bool>(base.CanPrepareImportPackages));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadMainViewRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026A4 File Offset: 0x000008A4
		private void a()
		{
			short num = (short)1953485621;
			short num2 = num;
			num = (short)197907253;
			switch (num2 == num)
			{
			}
			num = (short)119930881;
			if (num != 0)
			{
			}
			num = (short)2105278464;
			if (num != 0)
			{
			}
			num = (short)1413808128;
			short num3 = num;
			base.DeletePackages();
			base.CommandProxy.DeleteFirmwaresCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002764 File Offset: 0x00000964
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1234108416;
			short num2 = num;
			num = (short)1334079008;
			short num3 = num;
			num = (short)926576160;
			switch (num3 == num)
			{
			}
			num = (short)1382481920;
			if (num != 0)
			{
			}
			num = (short)1488453633;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
			base.CommandProxy.DeleteFirmwaresCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002824 File Offset: 0x00000A24
		protected override void LoadPackages()
		{
			short num;
			try
			{
				num = (short)1899404572;
				short num2 = num;
				num = (short)613850396;
				switch (num2 == num)
				{
				}
				num = (short)1750466561;
				if (num != 0)
				{
				}
				num = (short)1304428544;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetFirmwarePackages());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1446313984;
			short num3 = num;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002904 File Offset: 0x00000B04
		private void a(string A_0)
		{
			int a_ = 17;
			short num = (short)653519013;
			short num2 = num;
			num = (short)1800988837;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1107820544;
				short num3 = num;
				num = (short)2111963136;
				if (num != 0)
				{
				}
				if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ꃥ臧飩臫駭釯胱釳", a_)))
				{
					this.LoadPackages();
					return;
				}
				break;
			}
			}
			num = (short)1866661889;
			if (num != 0)
			{
			}
		}
	}
}
