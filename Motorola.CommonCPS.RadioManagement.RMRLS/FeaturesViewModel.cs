using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.Composition.Export]
	public class FeaturesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000275C File Offset: 0x0000095C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public FeaturesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.PrepareRegisterRadioLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c), new global::System.Func<bool>(this.b));
			this.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000027C4 File Offset: 0x000009C4
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002870 File Offset: 0x00000A70
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterRadioLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)606838;
				short num2 = num;
				num = (short)1332363894;
				switch (num2 == num)
				{
				}
				num = (short)309723136;
				short num3 = num;
				num = (short)6160385;
				if (num != 0)
				{
				}
				num = (short)198311936;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2109731764;
				short num2 = num;
				num = (short)1300558772;
				switch (num2 == num)
				{
				}
				num = (short)770048000;
				short num3 = num;
				num = (short)1205141504;
				if (num != 0)
				{
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002924 File Offset: 0x00000B24
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000029D4 File Offset: 0x00000BD4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> ShowDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1778253825;
				if (num != 0)
				{
				}
				num = (short)798978589;
				short num2 = num;
				num = (short)3306013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1857683456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)719781888;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2036096260;
				short num2 = num;
				num = (short)1866161412;
				switch (num2 == num)
				{
				}
				num = (short)1007222784;
				short num3 = num;
				num = (short)1571422209;
				if (num != 0)
				{
				}
				num = (short)1345519616;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A84 File Offset: 0x00000C84
		private void c()
		{
			short num;
			try
			{
				num = (short)1450137552;
				short num2 = num;
				num = (short)1777817552;
				switch (num2 == num)
				{
				}
				num = (short)489816065;
				if (num != 0)
				{
				}
				num = (short)416481280;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)969932800;
			short num3 = num;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002B64 File Offset: 0x00000D64
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase A_0)
		{
			int a_ = 3;
			short num = (short)1340534616;
			short num2 = num;
			num = (short)1327492952;
			switch (num2 == num)
			{
			}
			num = (short)2012086272;
			short num3 = num;
			num = (short)822542337;
			if (num != 0)
			{
			}
			num = (short)559742976;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("怦嬨䐪堬弮砰眲࠴", a_) + base.UrlEncode(this.a));
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("愦䰨䨪夬娮䌰嘲簴猶и", a_) + base.UrlEncode(A_0.FeatureID));
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("樦䘨伪䠬䌮缰䘲場唶尸䤺<", a_) + base.UrlEncode(A_0.ModelNumber));
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("愦䰨䨪夬娮䌰嘲笴嘶吸帺<", a_) + base.UrlEncode(A_0.FeatureName));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("甦攨琪欬䨮倰䜲䀴䔶尸䠺礼娾㕀≂ⱄ⭆㩈ᵊ⑌⩎♐", a_), list);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CC4 File Offset: 0x00000EC4
		private void a(int ftype)
		{
			short num = (short)1946222593;
			if (num != 0)
			{
			}
			num = (short)1653411136;
			short num2 = num;
			num = (short)59641152;
			switch (num2 == num)
			{
			default:
			{
				num = (short)57278464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1150812160;
			if (num != 0)
			{
			}
			this.b = ftype;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D78 File Offset: 0x00000F78
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)960231924;
				short num2 = num;
				num = (short)209975796;
				switch (num2 == num)
				{
				}
				num = (short)446955520;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.CanExecute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1516437504;
			short num3 = num;
			num = (short)361037825;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002E54 File Offset: 0x00001054
		protected override void Refresh()
		{
			short num = (short)123275086;
			short num2 = num;
			num = (short)1793263438;
			switch (num2 == num)
			{
			}
			num = (short)171835392;
			short num3 = num;
			num = (short)820314113;
			if (num != 0)
			{
			}
			num = (short)1436483584;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F08 File Offset: 0x00001108
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)1564574759;
			short num2 = num;
			num = (short)1448969255;
			switch (num2 == num)
			{
			}
			num = (short)1207828480;
			short num3 = num;
			num = (short)915668992;
			if (num != 0)
			{
			}
			num = (short)632815617;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FB0 File Offset: 0x000011B0
		private void a()
		{
			short num;
			try
			{
				num = (short)1976921804;
				short num2 = num;
				num = (short)1092906700;
				switch (num2 == num)
				{
				}
				num = (short)1254621185;
				if (num != 0)
				{
				}
				num = (short)825950208;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.ListRadioFeatureSummaryByFeature(this.a, this.b));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1327693824;
			short num3 = num;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000030A0 File Offset: 0x000012A0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 10;
			short num = (short)1753286150;
			short num2 = num;
			num = (short)978978310;
			switch (num2 == num)
			{
			}
			num = (short)1718222848;
			short num3 = num;
			num = (short)1877737472;
			if (num != 0)
			{
			}
			num = (short)1408827393;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("椭䈯崱䄳䘵焷縹", a_)];
			this.a();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("簭簯洱爳匵夷丹䤻䰽┿ㅁቃ⽅ⵇ㵉", a_);
		}

		// Token: 0x04000005 RID: 5
		private string a;

		// Token: 0x04000006 RID: 6
		private int b;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> d;
	}
}
