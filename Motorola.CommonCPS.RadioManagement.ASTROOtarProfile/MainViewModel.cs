using System;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x0200001C RID: 28
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedContainerViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption>
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00009E40 File Offset: 0x00008040
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
		{
			int a_ = 8;
			this.a = true;
			base..ctor(eventAggregator, regionManager, global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᡘ࡚ड़൞⹠Ɫᅤ٦᭨㭪Ὤnᝰᩲᥴቶ", a_));
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00009EA4 File Offset: 0x000080A4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00009F54 File Offset: 0x00008154
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2000355329;
				if (num != 0)
				{
				}
				num = (short)330299611;
				short num2 = num;
				num = (short)1504049371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050818048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808400384;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1222508545;
				if (num != 0)
				{
				}
				num = (short)1107942384;
				short num2 = num;
				num = (short)1400364016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1569849344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)792199168;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000A008 File Offset: 0x00008208
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public bool FilterOptionVisible
		{
			get
			{
				short num = (short)581509916;
				short num2 = num;
				num = (short)595796764;
				switch (num2 == num)
				{
				}
				num = (short)115933184;
				short num3 = num;
				num = (short)416677888;
				if (num != 0)
				{
				}
				num = (short)1271595009;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)161415170;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.MainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.MainViewModel.get_FilterOptionVisible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1108934657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)1443474650;
					short num3 = num;
					num = (short)188329178;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1212743680;
						short num4 = num;
						num = (short)295567360;
						if (num != 0)
						{
						}
						if (this.a == value)
						{
							return;
						}
						num = (short)394395648;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_11D:
				num = (short)353894401;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000A20C File Offset: 0x0000840C
		private void b()
		{
			short num = (short)1115724814;
			short num2 = num;
			num = (short)1587190798;
			switch (num2 == num)
			{
			}
			num = (short)1319436288;
			short num3 = num;
			num = (short)554434561;
			if (num != 0)
			{
			}
			num = (short)451018752;
			if (num != 0)
			{
			}
			this.a();
			this.LoadData();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000A2C0 File Offset: 0x000084C0
		protected override string GetMainViewName()
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption filterOption;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_88;
				case 1:
				{
					num2 = (short)943063041;
					if (num2 != 0)
					{
					}
					num2 = (short)1317853822;
					short num3 = num2;
					num2 = (short)495508094;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						goto IL_10E;
					}
					break;
				}
				case 2:
					switch (filterOption)
					{
					case global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.All:
						goto IL_79;
					case global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.OtarProfiles:
						goto IL_6A;
					case global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.Radios:
						goto IL_A2;
					default:
						num2 = (short)1397882880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_25;
				IL_88:
				num2 = (short)744423425;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_6A:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣⥥ᱧ୩ṫ㹭ɯᵱታήᑷόཻ⡽", a_);
			IL_79:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣㑥१๩իŭ㽯ٱᕳѵ⡷ࡹ፻᡽\ude87轢", a_);
			IL_A2:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣㑥१๩իŭͯ⑱ᵳ፵ཷ", a_);
			IL_10E:
			num2 = (short)1213267968;
			short num4 = num2;
			num2 = (short)69337088;
			if (num2 != 0)
			{
			}
			return string.Empty;
			IL_25:
			filterOption = base.FilterOption;
			num2 = (short)1910243330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000A420 File Offset: 0x00008620
		protected override bool TranslateViewIdToFilterOption(string mainViewId, out global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption filterOption)
		{
			int a_ = 11;
			short num = (short)1420034049;
			if (num != 0)
			{
			}
			num = (short)1290600452;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DB;
				case 1:
					num = (short)31522816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᵛ൝㑟ち⭣㥥❧ṩ൫ᱭ⁯q᭳ၵᅷᙹ᥻ൽ홿", a_))
					{
						goto IL_172;
					}
					num = (short)1850301410;
					short num3 = num;
					num = (short)2049924066;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num = (short)1605042176;
						if (num != 0)
						{
						}
						num = (short)913375233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)560005122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)887816192;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				}
				}
				IL_95:
				if (mainViewId == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᵛ൝㑟ち⭣㥥㩧୩࡫ݭὯű≳ήᵷ൹", a_))
				{
					break;
				}
				num = (short)1672478723;
				num2 = (int)((global::System.IntPtr)num);
			}
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.Radios;
			return true;
			IL_DB:
			goto IL_177;
			IL_172:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.OtarProfiles;
			return true;
			IL_177:
			filterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.All;
			return true;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000A5A8 File Offset: 0x000087A8
		protected override string GetNavigationParameterName()
		{
			int a_ = 12;
			short num = (short)84158085;
			short num2 = num;
			num = (short)682239621;
			switch (num2 == num)
			{
			}
			num = (short)1408958464;
			short num3 = num;
			num = (short)1759444993;
			if (num != 0)
			{
			}
			num = (short)1379663872;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᩜⵞ๠ᙢᕤ⹦⵨", a_);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000A664 File Offset: 0x00008864
		protected override void OnNavigateToViewRequested(string viewString)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)204079116;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣⥥ᱧ୩ṫ㹭ɯᵱታήᑷό㡻᭽ﮇ\udc89", a_)))
					{
						num2 = (short)1869807618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32F;
				}
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != base.MainModuleName)
					{
						num2 = (short)176226317;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)748027915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣㑥१๩իŭ㽯ٱᕳѵ⡷ࡹ፻᡽\ude87轢", a_)))
					{
						num2 = (short)1096220679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				}
				case 6:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣㑥१๩իŭͯ⑱ᵳ፵ཷ", a_)))
					{
						num2 = (short)158924801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_289;
				}
				case 7:
					num2 = (short)1368784902;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)475725833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_15E;
				case 10:
					num2 = (short)1952120835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					if (string.IsNullOrEmpty(viewString))
					{
						num2 = (short)1958150144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text = viewString.Split(new char[]
					{
						'?'
					})[0];
					num2 = (short)430505989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
				{
					string text;
					if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣㑥१๩իŭ㑯᝱s᝵ᅷᙹཻ⡽", a_)))
					{
						num2 = (short)1923743752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				}
				case 13:
					return;
				}
				goto IL_51;
			}
			return;
			IL_138:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.All;
			return;
			IL_191:
			this.FilterOptionVisible = false;
			return;
			IL_289:
			this.FilterOptionVisible = true;
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.Radios;
			return;
			IL_32F:
			this.FilterOptionVisible = false;
			return;
			IL_51:
			num2 = (short)427119290;
			short num3 = num2;
			num2 = (short)363156154;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_15E:
				string text;
				if (!(text == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭙ཛ੝㉟ⵡ㭣⥥ᱧ୩ṫ㹭ɯᵱታήᑷόཻ⡽", a_)))
				{
					num2 = (short)231276554;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				this.FilterOptionVisible = true;
				base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.OtarProfiles;
				return;
			}
			default:
			{
				num2 = (short)972357633;
				if (num2 != 0)
				{
				}
				num2 = (short)1245970432;
				short num4 = num2;
				num2 = (short)892665856;
				if (num2 != 0)
				{
				}
				base.OnNavigateToViewRequested(viewString);
				num2 = (short)947453956;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		private void a(object A_0)
		{
			int a_ = 18;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("≢㙤㍦㭨⑪≬᭮ၰŲ╴նᙸᵺᑼ፾", a_))
			{
				short num = (short)1575686654;
				short num2 = num;
				num = (short)998838782;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)598409217;
					if (num != 0)
					{
					}
					num = (short)1196163072;
					if (num != 0)
					{
					}
					num = (short)1800536064;
					short num3 = num;
					return;
				}
				}
			}
			this.a();
			base.FilterOption = global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.All;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000AA88 File Offset: 0x00008C88
		private void a()
		{
			short num = (short)1320162627;
			short num2 = num;
			num = (short)9704771;
			switch (num2 == num)
			{
			}
			num = (short)1595408384;
			short num3 = num;
			num = (short)174129153;
			if (num != 0)
			{
			}
			num = (short)654376960;
			if (num != 0)
			{
			}
			base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			base.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000AB68 File Offset: 0x00008D68
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1726742531;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
					{
						num = (short)1567883265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				case 1:
					return;
				case 2:
					num = (short)711852032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)671733138;
					short num3 = num;
					num = (short)228709778;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					default:
						num = (short)405667840;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					}
					break;
				}
				case 4:
					try
					{
						this.a();
						base.OnNavigatedTo(navigationContext);
						return;
					}
					catch (global::System.Exception exception)
					{
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
						return;
					}
					goto IL_E9;
				}
				IL_85:
				num = (short)760217601;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					num = (short)817496066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EA:
				num = (short)1941897216;
				short num4 = num;
				num = (short)1873281028;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E9:
				goto IL_EA;
			}
		}

		// Token: 0x04000043 RID: 67
		private bool a;

		// Token: 0x04000044 RID: 68
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
