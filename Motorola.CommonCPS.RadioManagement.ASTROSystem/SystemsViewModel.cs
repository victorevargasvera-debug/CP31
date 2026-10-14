using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200001A RID: 26
	[global::System.ComponentModel.Composition.Export]
	public class SystemsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000B458 File Offset: 0x00009658
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public SystemsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>(this.a));
			this.b = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsViewModel.<>c.<>9.a), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsViewModel.<>c.<>9.b));
			this.c = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsViewModel.<>c.<>9.c), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsViewModel.<>c.<>9.d));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B528 File Offset: 0x00009728
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1541890952;
			short num2 = num;
			num = (short)1741185928;
			switch (num2 == num)
			{
			}
			num = (short)1393491968;
			if (num != 0)
			{
			}
			num = (short)42467329;
			if (num != 0)
			{
			}
			num = (short)1873739776;
			short num3 = num;
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROSystemInfos(this.a));
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000B5EC File Offset: 0x000097EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportAstroSystemToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)99662052;
				short num2 = num;
				num = (short)1964554468;
				switch (num2 == num)
				{
				}
				num = (short)864681985;
				if (num != 0)
				{
				}
				num = (short)292421632;
				if (num != 0)
				{
				}
				num = (short)920518656;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B69C File Offset: 0x0000989C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportAstroSystemFromFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1640497153;
				if (num != 0)
				{
				}
				num = (short)647759400;
				short num2 = num;
				num = (short)338101800;
				switch (num2 == num)
				{
				}
				num = (short)1042350080;
				if (num != 0)
				{
				}
				num = (short)1702363136;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000B74C File Offset: 0x0000994C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo A_0)
		{
			int a_ = 13;
			short num = (short)1787795864;
			short num2 = num;
			num = (short)575969688;
			switch (num2 == num)
			{
			}
			num = (short)2051997697;
			if (num != 0)
			{
			}
			num = (short)1650130944;
			if (num != 0)
			{
			}
			num = (short)1544552448;
			short num3 = num;
			global::System.Collections.Generic.List<string> parameters = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ud89e펠첢키힦邬", a_) + base.UrlEncode(this.a),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞\ud8a0킢톤슦쒨銮", a_) + base.UrlEncode(A_0.CustomID),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("톞삠캢삤骦", a_) + base.UrlEncode(A_0.SystemName)
			};
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첞\ud8a0킢톤슦쒨좬\udbae킰\udab2\ud9b4쒶튺\ud8bc좾", a_), parameters);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000B88C File Offset: 0x00009A8C
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 0;
			short num = (short)1634187997;
			short num2 = num;
			num = (short)2097265373;
			switch (num2 == num)
			{
			}
			num = (short)1148059649;
			if (num != 0)
			{
			}
			num = (short)625147904;
			if (num != 0)
			{
			}
			num = (short)980287488;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("햑秊햛\uda9d", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("솑ﾙ쮡솣톥", a_);
		}

		// Token: 0x04000045 RID: 69
		private string a;

		// Token: 0x04000046 RID: 70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x04000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand c;
	}
}
