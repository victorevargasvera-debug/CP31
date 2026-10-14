using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200000C RID: 12
	[global::System.ComponentModel.Composition.Export]
	public class DataProfilesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000047F8 File Offset: 0x000029F8
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public DataProfilesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>(this.a));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004824 File Offset: 0x00002A24
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo A_0)
		{
			int a_ = 8;
			short num = (short)2108282454;
			short num2 = num;
			num = (short)706664022;
			switch (num2 == num)
			{
			default:
			{
				num = (short)303759360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)427425793;
			if (num != 0)
			{
			}
			num = (short)1907490816;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("햦욨\udeaa\uddac躲", a_) + base.UrlEncode(this.a));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("욦\udda8쪪ﶬ\uddae\udeb0햲\udcb4\udbb6\udcb8寮芾", a_) + base.UrlEncode(A_0.CustomID));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("욦쒨캪邬", a_) + base.UrlEncode(A_0.ProfileName));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("욦\udda8쪪ﶬ\uddae\udeb0햲\udcb4\udbb6\udcb8ﾺ\ud8bc쮾ꃀꫂ꧄듆鿈ꋊ꣌룎", a_), list);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004960 File Offset: 0x00002B60
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1852965093;
			short num2 = num;
			num = (short)1873281253;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1419902976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)4980737;
			if (num != 0)
			{
			}
			num = (short)281935872;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROProfileInfos(this.a));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004A24 File Offset: 0x00002C24
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)443270491;
			short num2 = num;
			num = (short)1560724827;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1086062592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)52756481;
			if (num != 0)
			{
			}
			num = (short)172687360;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004ACC File Offset: 0x00002CCC
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 1;
			short num = (short)98500609;
			if (num != 0)
			{
			}
			num = (short)268238848;
			short num2 = num;
			num = (short)2000868559;
			short num3 = num;
			num = (short)1403704527;
			switch (num3 == num)
			{
			}
			num = (short)600178688;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\ud99d튟춡톣횥", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\uda9d솟횡얣\udaa7얩쪫잭\udcafힱ잳톷\udfb9쮻", a_);
		}

		// Token: 0x04000011 RID: 17
		private string a;
	}
}
