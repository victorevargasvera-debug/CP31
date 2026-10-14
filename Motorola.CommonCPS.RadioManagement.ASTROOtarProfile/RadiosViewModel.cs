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

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000019 RID: 25
	[global::System.ComponentModel.Composition.Export]
	public class RadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000094A0 File Offset: 0x000076A0
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>(this.a));
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000094CC File Offset: 0x000076CC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo A_0)
		{
			int a_ = 0;
			short num = (short)975807377;
			short num2 = num;
			num = (short)116630417;
			switch (num2 == num)
			{
			}
			num = (short)559939584;
			short num3 = num;
			num = (short)1869414400;
			if (num != 0)
			{
			}
			num = (short)473890817;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("͐㉒ㅔ㹖㙘ቚᥜ扞", a_) + A_0.ID.ToString());
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ɐ㙒❔㹖㡘㝚፜⩞ౠŢdᕦ周", a_) + base.UrlEncode(A_0.SerialNumber));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၐRŔՖᙘњཛྷ㹞ՠ੢੤⍦౨Ὢ౬ٮᵰr⍴Ṷᱸ౺", a_), list);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000095EC File Offset: 0x000077EC
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)18892230;
			short num2 = num;
			num = (short)1809728966;
			switch (num2 == num)
			{
			}
			num = (short)2079588352;
			short num3 = num;
			num = (short)315752448;
			if (num != 0)
			{
			}
			num = (short)1343684609;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROOtarProfileRadioInfos(this.a));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000096B4 File Offset: 0x000078B4
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 6;
			short num = (short)2114061096;
			short num2 = num;
			num = (short)1120535336;
			switch (num2 == num)
			{
			}
			num = (short)848035840;
			short num3 = num;
			num = (short)2010710016;
			if (num != 0)
			{
			}
			num = (short)575733761;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၖ⭘㑚⡜⽞⡠❢", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᙖ੘ཚཛྷၞ㹠ㅢѤͦhѪṬ㥮ᡰᙲɴ", a_);
		}

		// Token: 0x0400003D RID: 61
		private string a;
	}
}
