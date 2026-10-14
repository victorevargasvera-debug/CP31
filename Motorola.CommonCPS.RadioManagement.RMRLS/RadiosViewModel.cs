using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
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
	// Token: 0x02000012 RID: 18
	[global::System.ComponentModel.Composition.Export]
	public class RadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000098DC File Offset: 0x00007ADC
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.PrepareRegisterRadioLicenseDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.c));
			this.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FeatureTypeRequestedEvent>().Subscribe(new global::System.Action<int>(this.a));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000994C File Offset: 0x00007B4C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000099FC File Offset: 0x00007BFC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRegisterRadioLicenseDialogCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)578917176;
				short num2 = num;
				num = (short)1555600184;
				switch (num2 == num)
				{
				}
				num = (short)925761537;
				if (num != 0)
				{
				}
				num = (short)800849920;
				if (num != 0)
				{
				}
				num = (short)1345454080;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1080819384;
				short num2 = num;
				num = (short)687537848;
				switch (num2 == num)
				{
				}
				num = (short)1726414849;
				if (num != 0)
				{
				}
				num = (short)1717960704;
				if (num != 0)
				{
				}
				num = (short)1363214336;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00009AAC File Offset: 0x00007CAC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00009B60 File Offset: 0x00007D60
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> ShowDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)234386024;
				short num2 = num;
				num = (short)1329623656;
				switch (num2 == num)
				{
				}
				num = (short)2016083969;
				if (num != 0)
				{
				}
				num = (short)619577344;
				if (num != 0)
				{
				}
				num = (short)1361641472;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)121466547;
				short num2 = num;
				num = (short)523529907;
				switch (num2 == num)
				{
				}
				num = (short)1309147136;
				if (num != 0)
				{
				}
				num = (short)258605057;
				if (num != 0)
				{
				}
				num = (short)1308491776;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009C14 File Offset: 0x00007E14
		private void d()
		{
			short num;
			try
			{
				num = (short)735409763;
				short num2 = num;
				num = (short)1649178211;
				switch (num2 == num)
				{
				}
				num = (short)1309540352;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareRegisterRadioLicense.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)772931585;
			if (num != 0)
			{
			}
			num = (short)2003107840;
			short num3 = num;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009CF0 File Offset: 0x00007EF0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase A_0)
		{
			int a_ = 19;
			short num = (short)1697442356;
			short num2 = num;
			num = (short)216394292;
			switch (num2 == num)
			{
			}
			num = (short)711000065;
			if (num != 0)
			{
			}
			num = (short)134676480;
			if (num != 0)
			{
			}
			num = (short)978911232;
			short num3 = num;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("收堸强吼倾ࡀ݂硄", a_) + A_0.RadioGUID.ToString());
			list.Add(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("搶尸䤺吼帾ⵀൂい⩆⭈⹊㽌牎", a_) + A_0.SerialNumber);
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("收甸携漼帾╀⩂⩄㑆ൈ⹊㥌⹎㡐㽒♔Ŗじ㹚⩜", a_), list);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009E08 File Offset: 0x00008008
		private void a(int ftype)
		{
			short num = (short)1703713767;
			short num2 = num;
			num = (short)720870375;
			switch (num2 == num)
			{
			}
			num = (short)586350592;
			if (num != 0)
			{
			}
			num = (short)1806499841;
			if (num != 0)
			{
			}
			num = (short)921894912;
			short num3 = num;
			this.b = ftype;
			this.a();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009EC0 File Offset: 0x000080C0
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)917569537;
				if (num != 0)
				{
				}
				num = (short)1253607789;
				short num2 = num;
				num = (short)145328493;
				switch (num2 == num)
				{
				}
				num = (short)1550254080;
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
			num = (short)1834156032;
			short num3 = num;
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009FA4 File Offset: 0x000081A4
		protected override void Refresh()
		{
			short num = (short)7338512;
			short num2 = num;
			num = (short)1828059664;
			switch (num2 == num)
			{
			}
			num = (short)387317761;
			if (num != 0)
			{
			}
			num = (short)530841600;
			if (num != 0)
			{
			}
			num = (short)1174536192;
			short num3 = num;
			this.b();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A054 File Offset: 0x00008254
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)210147653;
			short num2 = num;
			num = (short)1647548741;
			switch (num2 == num)
			{
			}
			num = (short)1012006913;
			if (num != 0)
			{
			}
			num = (short)495452160;
			if (num != 0)
			{
			}
			num = (short)2084175872;
			short num3 = num;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A0FC File Offset: 0x000082FC
		private void b()
		{
			short num;
			try
			{
				num = (short)2133644040;
				short num2 = num;
				num = (short)194368264;
				switch (num2 == num)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.ListRadioFeatureSummaryByRadio(this.a, this.b));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1841758209;
			if (num != 0)
			{
			}
			num = (short)2137260032;
			short num3 = num;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A1EC File Offset: 0x000083EC
		private void a()
		{
			short num = (short)1043292909;
			short num2 = num;
			num = (short)855466733;
			switch (num2 == num)
			{
			}
			num = (short)1553268737;
			if (num != 0)
			{
			}
			num = (short)65077248;
			if (num != 0)
			{
			}
			num = (short)1733558272;
			short num3 = num;
			this.AstroRadioLicenseVisibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000A29C File Offset: 0x0000849C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000A34C File Offset: 0x0000854C
		public global::System.Windows.Visibility AstroRadioLicenseVisibility
		{
			get
			{
				short num = (short)964362240;
				short num2 = num;
				num = (short)1644682124;
				short num3 = num;
				num = (short)1794235276;
				switch (num3 == num)
				{
				}
				num = (short)1336606721;
				if (num != 0)
				{
				}
				num = (short)1294860288;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1580466178;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_D0;
						case 1:
							this.c = value;
							base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.RadiosViewModel.get_AstroRadioLicenseVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)613089280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						}
						IL_31:
						if (value == this.c)
						{
							break;
						}
						num = (short)1965948928;
						short num3 = num;
						num = (short)1954480129;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_D2:
					num = (short)669360602;
					short num4 = num;
					num = (short)1319870938;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_107;
					}
					IL_D0:
					goto IL_D2;
				}
				IL_107:
				num = (short)1441595393;
				if (num != 0)
				{
				}
				num = (short)358744064;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000A4A0 File Offset: 0x000086A0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 12;
			short num = (short)226820096;
			short num2 = num;
			num = (short)1522526323;
			short num3 = num;
			num = (short)253552755;
			switch (num3 == num)
			{
			}
			num = (short)578486273;
			if (num != 0)
			{
			}
			num = (short)212402176;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("眯䀱嬳䌵䠷猹砻", a_)];
			this.b();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("戯縱欳搵夷帹唻儽㌿ᑁⵃ⍅㽇", a_);
			this.a();
		}

		// Token: 0x04000035 RID: 53
		private string a;

		// Token: 0x04000036 RID: 54
		private int b;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Visibility c = global::System.Windows.Visibility.Collapsed;

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> e;
	}
}
