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
	// Token: 0x0200000C RID: 12
	[global::System.ComponentModel.Composition.Export]
	public class OtarProfilesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public OtarProfilesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>(this.a));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004C24 File Offset: 0x00002E24
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo A_0)
		{
			int a_ = 0;
			short num = (short)1952579584;
			short num2 = num;
			num = (short)1179372925;
			short num3 = num;
			num = (short)2003553661;
			switch (num3 == num)
			{
			}
			num = (short)842924033;
			if (num != 0)
			{
			}
			num = (short)1837694976;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᙐ⅒㩔≖⥘ቚᥜ扞", a_) + base.UrlEncode(this.a));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("Ṑ❒㑔╖क़⥚㉜㥞ࡠརd⥦ࡨ٪࡬剮", a_) + base.UrlEncode(A_0.OtarProfileName));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᡐ㵒ㅔ㉖⥘㹚㍜㭞Ѡൢᅤ⭦hᡪᥬ剮", a_) + base.UrlEncode(A_0.IndependentList.ToString()));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("Ṑ❒㑔╖ၘ὚恜", a_) + base.UrlEncode(A_0.OtarID.ToString()));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ၐRŔՖᙘњቜ⭞`ᅢ㕤ᕦ٨൪Ѭͮᑰ㝲ၴͶᡸቺᅼ౾힀", a_), list);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004D90 File Offset: 0x00002F90
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)661192704;
			short num2 = num;
			num = (short)377220538;
			short num3 = num;
			num = (short)1055911354;
			switch (num3 == num)
			{
			}
			num = (short)566493185;
			if (num != 0)
			{
			}
			num = (short)2088370176;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROOtarProfileInfos(this.a));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004E58 File Offset: 0x00003058
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 10;
			short num = (short)1247412224;
			short num2 = num;
			num = (short)1328427153;
			short num3 = num;
			num = (short)1872507025;
			switch (num3 == num)
			{
			}
			num = (short)1435828225;
			if (num != 0)
			{
			}
			num = (short)384892928;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᱚ⽜ぞᑠ።Ɽ⍦", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᩚ๜୞㍠Ɫ㩤⡦ᵨ੪Ὤ㽮Ͱᱲ፴ṶᕸṺ๼⥾", a_);
		}

		// Token: 0x04000015 RID: 21
		private string a;
	}
}
