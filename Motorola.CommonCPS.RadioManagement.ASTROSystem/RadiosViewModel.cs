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
	// Token: 0x02000012 RID: 18
	[global::System.ComponentModel.Composition.Export]
	public class RadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00005FF4 File Offset: 0x000041F4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>(this.a));
			this.b = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosViewModel.<>c.<>9.a), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosViewModel.<>c.<>9.b));
			this.c = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosViewModel.<>c.<>9.c), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosViewModel.<>c.<>9.d));
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000060C4 File Offset: 0x000042C4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportAstroSystemToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)312401918;
				short num2 = num;
				num = (short)743170046;
				switch (num2 == num)
				{
				}
				num = (short)283967489;
				if (num != 0)
				{
				}
				num = (short)1528627200;
				if (num != 0)
				{
				}
				num = (short)1153564672;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006170 File Offset: 0x00004370
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportAstroSystemFromFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)256209367;
				short num2 = num;
				num = (short)974811607;
				switch (num2 == num)
				{
				}
				num = (short)1681653761;
				if (num != 0)
				{
				}
				num = (short)1487077376;
				if (num != 0)
				{
				}
				num = (short)403046400;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006220 File Offset: 0x00004420
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo A_0)
		{
			int a_ = 7;
			short num = (short)645451904;
			short num2 = num;
			num = (short)1454493824;
			switch (num2 == num)
			{
			}
			num = (short)256573441;
			if (num != 0)
			{
			}
			num = (short)455147520;
			if (num != 0)
			{
			}
			num = (short)1435959296;
			short num3 = num;
			global::System.Collections.Generic.List<string> parameters = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쮘漢列캠骦", a_) + A_0.ID.ToString(),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쪘ﺚ삠쾢튦쒨즪좬\uddae貰", a_) + base.UrlEncode(A_0.SerialNumber)
			};
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쪘쒚쾜ﺞ얠쪢쪤첨\udfaa첬욮\uddb0삲\udeb6\udcb8첺", a_), parameters);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006340 File Offset: 0x00004540
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1893638988;
			short num2 = num;
			num = (short)501916492;
			switch (num2 == num)
			{
			}
			num = (short)1607073793;
			if (num != 0)
			{
			}
			num = (short)2134769664;
			if (num != 0)
			{
			}
			num = (short)264503296;
			short num3 = num;
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetSystemRadioInfos(this.a));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006404 File Offset: 0x00004604
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 14;
			short num = (short)548972144;
			short num2 = num;
			num = (short)567453296;
			switch (num2 == num)
			{
			}
			num = (short)251658240;
			if (num != 0)
			{
			}
			num = (short)227540993;
			if (num != 0)
			{
			}
			num = (short)1510473728;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("킡쮣펥\ud8a7", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﶡ장첧쎩쎫\uddad\udbb1톳솵", a_);
		}

		// Token: 0x04000020 RID: 32
		private string a;

		// Token: 0x04000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand c;
	}
}
