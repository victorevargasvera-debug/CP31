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
	// Token: 0x02000019 RID: 25
	[global::System.ComponentModel.Composition.Export]
	public class RadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00008194 File Offset: 0x00006394
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>(this.a));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000081C0 File Offset: 0x000063C0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo A_0)
		{
			int a_ = 16;
			short num = (short)545259521;
			if (num != 0)
			{
			}
			num = (short)1701314620;
			short num2 = num;
			num = (short)838074428;
			switch (num2 == num)
			{
			}
			num = (short)1343750144;
			if (num != 0)
			{
			}
			num = (short)159252480;
			short num3 = num;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﾬ캮햰\udab2\udab4ﺶﶸ蚺", a_) + A_0.ID.ToString());
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺬ쪮쎰\udab2풴\udbb6캺킼\uddbe꓀뇂", a_) + base.UrlEncode(A_0.SerialNumber));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﾮ풴펶킸풺寮\udabe뗀ꋂ계ꯆ뫈鷊꓌꫎ꛐ", a_), list);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000082DC File Offset: 0x000064DC
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1316210181;
			short num2 = num;
			num = (short)733332997;
			switch (num2 == num)
			{
			}
			num = (short)545456129;
			if (num != 0)
			{
			}
			num = (short)1665728512;
			if (num != 0)
			{
			}
			num = (short)984285184;
			short num3 = num;
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetProfileRadioInfos(this.a));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000083A0 File Offset: 0x000065A0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 15;
			short num = (short)402887430;
			short num2 = num;
			num = (short)1480364806;
			switch (num2 == num)
			{
			}
			num = (short)1024786433;
			if (num != 0)
			{
			}
			num = (short)1646067712;
			if (num != 0)
			{
			}
			num = (short)1663107072;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udcad\udfaf잱쒳ﾵﲷ", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺭ햳튵톷햹쾻ꦿꟁ돃", a_);
		}

		// Token: 0x04000033 RID: 51
		private string a;
	}
}
