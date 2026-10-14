using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000011 RID: 17
	[global::System.ComponentModel.Composition.Export]
	public class RadioOtarProfilesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006020 File Offset: 0x00004220
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioOtarProfilesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.ShowRadioDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(this.b));
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadioOtarProfilesViewModel.<>c.<>9.a));
			this.CellFillStartedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance().ExportRadioOtarProfilesCommand = (this.ExportOtarProfileToFileCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.e)));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000060F0 File Offset: 0x000042F0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000619C File Offset: 0x0000439C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> ShowRadioDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)679739392;
				short num2 = num;
				num = (short)1510283072;
				short num3 = num;
				num = (short)1921128256;
				switch (num3 == num)
				{
				}
				num = (short)1489436673;
				if (num != 0)
				{
				}
				num = (short)2143485952;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)388956160;
				short num2 = num;
				num = (short)2045027598;
				short num3 = num;
				num = (short)1479255310;
				switch (num3 == num)
				{
				}
				num = (short)112263169;
				if (num != 0)
				{
				}
				num = (short)1929838592;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006250 File Offset: 0x00004450
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00006304 File Offset: 0x00004504
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)667615232;
				short num2 = num;
				num = (short)1603897938;
				short num3 = num;
				num = (short)432966226;
				switch (num3 == num)
				{
				}
				num = (short)1204420609;
				if (num != 0)
				{
				}
				num = (short)1538392064;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1938030592;
				short num2 = num;
				num = (short)1507986518;
				short num3 = num;
				num = (short)2033585238;
				switch (num3 == num)
				{
				}
				num = (short)1536884737;
				if (num != 0)
				{
				}
				num = (short)1589903360;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000063B4 File Offset: 0x000045B4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00006464 File Offset: 0x00004664
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillStartedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)692781056;
				short num2 = num;
				num = (short)717423389;
				short num3 = num;
				num = (short)398328605;
				switch (num3 == num)
				{
				}
				num = (short)492306433;
				if (num != 0)
				{
				}
				num = (short)1169883136;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)904200192;
				short num2 = num;
				num = (short)2145473718;
				short num3 = num;
				num = (short)694244534;
				switch (num3 == num)
				{
				}
				num = (short)847970305;
				if (num != 0)
				{
				}
				num = (short)1130233856;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006514 File Offset: 0x00004714
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000065C4 File Offset: 0x000047C4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)737280000;
				short num2 = num;
				num = (short)790385878;
				short num3 = num;
				num = (short)495998166;
				switch (num3 == num)
				{
				}
				num = (short)1135017985;
				if (num != 0)
				{
				}
				num = (short)1136328704;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)606546159;
				short num2 = num;
				num = (short)1199188207;
				switch (num2 == num)
				{
				}
				num = (short)1977221121;
				if (num != 0)
				{
				}
				num = (short)35782656;
				if (num != 0)
				{
				}
				num = (short)360710144;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006670 File Offset: 0x00004870
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00006724 File Offset: 0x00004924
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportOtarProfileToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1109983233;
				if (num != 0)
				{
				}
				num = (short)2026484560;
				short num2 = num;
				num = (short)1644475216;
				switch (num2 == num)
				{
				}
				num = (short)68878336;
				if (num != 0)
				{
				}
				num = (short)1240006656;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)159055873;
				if (num != 0)
				{
				}
				num = (short)281648046;
				short num2 = num;
				num = (short)1943444398;
				switch (num2 == num)
				{
				}
				num = (short)1648689152;
				if (num != 0)
				{
				}
				num = (short)1074069504;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000067D4 File Offset: 0x000049D4
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1392608259;
			short num2 = num;
			num = (short)658801667;
			switch (num2 == num)
			{
			}
			num = (short)448331776;
			if (num != 0)
			{
			}
			num = (short)879427585;
			if (num != 0)
			{
			}
			num = (short)1575944192;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROOtarProfiles(this.a));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000068A4 File Offset: 0x00004AA4
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)279048223;
				short num2 = num;
				num = (short)483455007;
				switch (num2 == num)
				{
				}
				num = (short)897908736;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveASTROOTARProfileCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)448856065;
			if (num != 0)
			{
			}
			num = (short)911736832;
			short num3 = num;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006980 File Offset: 0x00004B80
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1007419393;
			if (num != 0)
			{
			}
			num = (short)484915686;
			short num2 = num;
			num = (short)63060454;
			switch (num2 == num)
			{
			}
			num = (short)161218560;
			if (num != 0)
			{
			}
			num = (short)1391788032;
			short num3 = num;
			base.OnSelectedItemsCollectionChanged();
			this.ExportOtarProfileToFileCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006A3C File Offset: 0x00004C3C
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)610082383;
				short num2 = num;
				num = (short)1436229199;
				switch (num2 == num)
				{
				}
				num = (short)606601216;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("੗㭙㡛㝝ཟ⭡⁣孥", a_) + A_0.RadioID.ToString());
				list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ୗ㽙⹛㝝ş๡⩣፥էࡩ५ᱭ䵯", a_) + base.UrlEncode(A_0.SerialNumber));
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᥗख़࡛ౝ⽟㵡㙣ݥ౧ͩͫ⩭ᕯٱᕳήᑷॹ⩻᝽", a_), list);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)434307073;
			if (num != 0)
			{
			}
			num = (short)1465647104;
			short num3 = num;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006B78 File Offset: 0x00004D78
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			int a_ = 5;
			short num = (short)148203564;
			short num2 = num;
			num = (short)1019373612;
			switch (num2 == num)
			{
			}
			num = (short)28770305;
			if (num != 0)
			{
			}
			num = (short)1467875328;
			if (num != 0)
			{
			}
			num = (short)665583616;
			short num3 = num;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᅕ⩗㕙⥛⹝⥟♡奣", a_) + base.UrlEncode(this.a));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᥕⱗ㭙⹛๝቟ൡɣཥѧཀྵ≫཭ᵯ᝱䥳", a_) + base.UrlEncode(A_0.OtarProfileName));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ὕ㙗㹙㥛⹝՟ౡcͥ٧ṩ⁫ݭͯٱ䥳", a_) + base.UrlEncode(A_0.IndependentList.ToString()));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᥕⱗ㭙⹛᝝⑟彡", a_) + base.UrlEncode(A_0.OtarID.ToString()));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᝕ୗ๙๛ᅝ㽟ⵡၣݥᩧ㩩ṫŭᙯ᭱ᡳ፵㱷όࡻώ킅ﮋ", a_), list);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006CF4 File Offset: 0x00004EF4
		private bool e()
		{
			short num;
			bool result;
			try
			{
				num = (short)93281348;
				short num2 = num;
				num = (short)248142916;
				switch (num2 == num)
				{
				}
				num = (short)1245970432;
				if (num != 0)
				{
				}
				num = (short)1211236353;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.ExportOtarProfileGridToFileCommand.CanExecute(new object[]
				{
					this.OtarProfilesToFileItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)686096384;
			short num3 = num;
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006DE4 File Offset: 0x00004FE4
		private void d()
		{
			short num;
			try
			{
				num = (short)432406571;
				short num2 = num;
				num = (short)130809899;
				switch (num2 == num)
				{
				}
				num = (short)1658454016;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ExportOtarProfileGridToFileCommand.Execute(new object[]
				{
					this.OtarProfilesToFileItems.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>()
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2121728001;
			if (num != 0)
			{
			}
			num = (short)979566592;
			short num3 = num;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006ED4 File Offset: 0x000050D4
		private void c()
		{
			short num = (short)2058510456;
			short num2 = num;
			num = (short)1904894072;
			switch (num2 == num)
			{
			}
			num = (short)1881931777;
			if (num != 0)
			{
			}
			num = (short)230424576;
			if (num != 0)
			{
			}
			num = (short)1479147520;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006F88 File Offset: 0x00005188
		private void b()
		{
			short num = (short)1306103874;
			short num2 = num;
			num = (short)415862850;
			switch (num2 == num)
			{
			}
			num = (short)1447231489;
			if (num != 0)
			{
			}
			num = (short)367329280;
			if (num != 0)
			{
			}
			num = (short)222101504;
			short num3 = num;
			base.ServiceProxy.LocalService.RefreshASTROOtarProfilesForFillUpDown(base.SelectedItems);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00007048 File Offset: 0x00005248
		private global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> OtarProfilesToFileItems
		{
			get
			{
				short num = (short)449052674;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_CD;
					case 1:
						goto IL_E4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (base.SelectedItems.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>())
					{
						goto IL_F8;
					}
					num = (short)1758256220;
					short num3 = num;
					num = (short)623959132;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1646133248;
						if (num != 0)
						{
						}
						num = (short)1588461569;
						if (num != 0)
						{
						}
						num = (short)1062862848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CD:
					num = (short)616169473;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E4:
				global::System.ComponentModel.ICollectionView items = base.Items;
				if (items == null)
				{
					return null;
				}
				return items.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				IL_F8:
				num = (short)1761935360;
				short num4 = num;
				return base.SelectedItems;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007180 File Offset: 0x00005380
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 11;
			short num = (short)1096198751;
			short num2 = num;
			num = (short)816360031;
			switch (num2 == num)
			{
			}
			num = (short)1337917441;
			if (num != 0)
			{
			}
			num = (short)1170604032;
			if (num != 0)
			{
			}
			num = (short)380960768;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭛ⱝཟᝡᑣ⽥Ⱨ", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᵛ൝㑟ち⭣㥥㩧୩࡫ݭὯ㵱s᝵੷⩹๻ᅽﮇ\udc89", a_);
		}

		// Token: 0x04000022 RID: 34
		private string a;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> b;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;
	}
}
