using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000031 RID: 49
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ContainerViewModelBase<object>
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00024934 File Offset: 0x00022B34
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 3;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b8\udfba풼킾", a_));
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00024990 File Offset: 0x00022B90
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00024A44 File Offset: 0x00022C44
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2027396365;
				short num2 = num;
				num = (short)699440397;
				switch (num2 == num)
				{
				}
				num = (short)2020605952;
				short num3 = num;
				num = (short)1177485313;
				if (num != 0)
				{
				}
				num = (short)2106523648;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1301252773;
				short num2 = num;
				num = (short)68061861;
				switch (num2 == num)
				{
				}
				num = (short)2036465664;
				short num3 = num;
				num = (short)106627073;
				if (num != 0)
				{
				}
				num = (short)529072128;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00024AF8 File Offset: 0x00022CF8
		private void a(object A_0)
		{
			int a_ = 3;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b8\udfba풼킾", a_))
			{
				short num = (short)1832910975;
				short num2 = num;
				num = (short)1635713151;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)840499200;
					short num3 = num;
					num = (short)77791233;
					if (num != 0)
					{
					}
					num = (short)400490496;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b8\udfba풼킾닀闂계ꋆ뻈", a_));
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00024BDC File Offset: 0x00022DDC
		private void a()
		{
			int a_ = 13;
			short num = (short)1880962255;
			short num2 = num;
			num = (short)1110979791;
			switch (num2 == num)
			{
			}
			num = (short)1583677440;
			short num3 = num;
			num = (short)1031274497;
			if (num != 0)
			{
			}
			num = (short)2042560512;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ룊鯌ꛎ듐ꓒ", a_));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00024CA4 File Offset: 0x00022EA4
		protected override string GetMainViewName()
		{
			int a_ = 7;
			short num = (short)837287002;
			short num2 = num;
			num = (short)2113731674;
			switch (num2 == num)
			{
			}
			num = (short)1299447808;
			short num3 = num;
			num = (short)1120927745;
			if (num != 0)
			{
			}
			num = (short)1942421504;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udcbc\udbbeꣀ곂뛄釆ꃈ껊뫌", a_);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00024D64 File Offset: 0x00022F64
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out object filterOption)
		{
			short num = (short)1224291686;
			short num2 = num;
			num = (short)1188705638;
			switch (num2 == num)
			{
			}
			num = (short)2097152;
			short num3 = num;
			num = (short)1759903744;
			if (num != 0)
			{
			}
			num = (short)41025537;
			if (num != 0)
			{
			}
			filterOption = new object();
			return false;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00024E18 File Offset: 0x00023018
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 18;
			short num = (short)1160944917;
			short num2 = num;
			num = (short)203660565;
			switch (num2 == num)
			{
			}
			num = (short)226689024;
			short num3 = num;
			num = (short)381812736;
			if (num != 0)
			{
			}
			num = (short)384434177;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅꧇껉ꗋꇍꏏ蓑뷓돕꿗", a_));
		}

		// Token: 0x040000F9 RID: 249
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand a;
	}
}
