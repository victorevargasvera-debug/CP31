using System;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.PackageBase
{
	// Token: 0x02000004 RID: 4
	public abstract class PackageMainViewModelBase<T> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T> where T : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002444 File Offset: 0x00000644
		public bool IsCloudFirmwareDeletionAttempt
		{
			get
			{
				int a_ = 7;
				while (this.a == global::<Module>.b("즎", a_))
				{
					short num = (short)1691178563;
					short num2 = num;
					num = (short)1428510275;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)233963521;
						if (num != 0)
						{
						}
						num = (short)1080295424;
						short num3 = num;
						num = (short)36438016;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
					}
					}
				}
				return false;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002524 File Offset: 0x00000724
		public PackageMainViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string moduleName) : base(eventAggregator)
		{
			this.b = packageType;
			this.a = moduleName;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002548 File Offset: 0x00000748
		protected override void Refresh()
		{
			short num = (short)1724645377;
			if (num != 0)
			{
			}
			num = (short)859135075;
			short num2 = num;
			num = (short)453860451;
			switch (num2 == num)
			{
			}
			num = (short)62586880;
			short num3 = num;
			num = (short)688324608;
			if (num != 0)
			{
			}
			this.LoadPackages();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025F8 File Offset: 0x000007F8
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)492249302;
			short num2 = num;
			num = (short)770318550;
			switch (num2 == num)
			{
			}
			num = (short)2021916672;
			if (num != 0)
			{
			}
			num = (short)813957120;
			short num3 = num;
			num = (short)1588920321;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026A8 File Offset: 0x000008A8
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)81381513;
				short num2 = num;
				num = (short)251906185;
				switch (num2 == num)
				{
				}
				num = (short)729612288;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SavePackageCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				throw;
			}
			num = (short)2129854465;
			if (num != 0)
			{
			}
			num = (short)2117206016;
			short num3 = num;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002788 File Offset: 0x00000988
		protected bool CanDeletePackages()
		{
			short num;
			bool result;
			try
			{
				num = (short)1730609154;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = base.ServiceProxy.CommandHandler.DeletePackagesCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_F7;
					case 1:
						goto IL_10F;
					case 2:
					{
						num = (short)562837484;
						short num3 = num;
						num = (short)1832859628;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10F;
						default:
							num = (short)844300288;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						}
						break;
					}
					case 3:
						flag = false;
						goto IL_F7;
					case 4:
						num = (short)1539178496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					if (!this.IsCloudFirmwareDeletionAttempt)
					{
						num = (short)130809860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1935802371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F7:
					result = flag;
					num = (short)2132541441;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1323237377;
			if (num != 0)
			{
			}
			num = (short)776142848;
			short num4 = num;
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002920 File Offset: 0x00000B20
		protected bool CanPrepareImportPackages()
		{
			short num;
			bool result;
			try
			{
				num = (short)843120642;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = base.ServiceProxy.CommandHandler.PrepareImportPackagesCommand.CanExecute(new object[]
						{
							this.b
						});
						goto IL_12A;
					case 1:
						goto IL_143;
					case 2:
					{
						num = (short)1427778640;
						short num3 = num;
						num = (short)1981557840;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_143;
						default:
							num = (short)192282625;
							if (num != 0)
							{
							}
							num = (short)952434688;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						}
						break;
					}
					case 3:
						flag = false;
						goto IL_12A;
					case 4:
						num = (short)829816832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AB:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == this.a)
					{
						num = (short)267714564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1240793091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12A:
					result = flag;
					num = (short)114425857;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_143:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)962396160;
			short num4 = num;
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002AC4 File Offset: 0x00000CC4
		protected void DeletePackages()
		{
			short num;
			try
			{
				num = (short)1393536850;
				short num2 = num;
				num = (short)1927524178;
				switch (num2 == num)
				{
				}
				num = (short)870055936;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.DeletePackagesCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1337851905;
			if (num != 0)
			{
			}
			num = (short)1620049920;
			short num3 = num;
		}

		// Token: 0x06000011 RID: 17
		protected abstract void LoadPackages();

		// Token: 0x06000012 RID: 18 RVA: 0x00002BB0 File Offset: 0x00000DB0
		protected void PrepareImportPackages()
		{
			short num;
			try
			{
				num = (short)783854584;
				short num2 = num;
				num = (short)2016717816;
				switch (num2 == num)
				{
				}
				num = (short)1245380608;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareImportPackagesCommand.Execute(new object[]
				{
					this.b
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1083899905;
			if (num != 0)
			{
			}
			num = (short)232914944;
			short num3 = num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1146623880;
			short num2 = num;
			num = (short)1788221320;
			switch (num2 == num)
			{
			default:
			{
				num = (short)235012096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)183566337;
			if (num != 0)
			{
			}
			num = (short)1778581504;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			string payload = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ConvertModuleNameToResourceName(this.a);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectResourceRequestedEvent>().Publish(payload);
			this.LoadPackages();
		}

		// Token: 0x04000005 RID: 5
		private string a;

		// Token: 0x04000006 RID: 6
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType b;
	}
}
