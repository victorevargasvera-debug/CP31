using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x02000262 RID: 610
	public class PageExternalMicNoiseReductionProfileTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06006C26 RID: 27686 RVA: 0x006098C0 File Offset: 0x00607AC0
		public PageExternalMicNoiseReductionProfileTbl()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x006098F8 File Offset: 0x00607AF8
		public override void SetDataContext()
		{
			short num = (short)30474241;
			if (num != 0)
			{
			}
			num = (short)1024720897;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1810956288;
						short num3 = num;
						num = (short)2070937605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_208;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					goto IL_D8;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2087);
					num = (short)311820290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_D8;
				case 5:
					goto IL_186;
				}
				IL_65:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2087);
					num = (short)396689412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)763226970;
				short num4 = num;
				num = (short)1803152218;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_186;
				default:
					num = (short)827392000;
					if (num != 0)
					{
					}
					num = (short)324009987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D8:
				this.ExternalMicNoiseReductionProfileList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageExternalMicNoiseReductionProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageExternalMicNoiseReductionProfile.MyDataPresenter = this.ExternalMicNoiseReductionProfileList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageExternalMicNoiseReductionProfile;
				num = (short)2048458752;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_186:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2087);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageExternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_208:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageExternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00609B1C File Offset: 0x00607D1C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2107244544;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
					goto IL_EB;
				}
				IL_30:
				num = (short)1280407016;
				short num3 = num;
				num = (short)2086499816;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_EB:
					object myRecordsetDataSource = this.RecNavToolbarPageExternalMicNoiseReductionProfile.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1060110337;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
				{
					num = (short)2117337089;
					if (num != 0)
					{
					}
					num = (short)269418496;
					short num4 = num;
					num = (short)434896896;
					if (num != 0)
					{
					}
					if (this.b)
					{
						return;
					}
					num = (short)122421250;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x00609C60 File Offset: 0x00607E60
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1327497217;
					if (num2 != 0)
					{
					}
					if (this.b)
					{
						num2 = (short)1737359362;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_DC;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)138716933;
			short num3 = num2;
			num2 = (short)1335797509;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DC:
				base.OnUnloaded(sender, e);
				this.b = false;
				num2 = (short)2027421696;
				short num4 = num2;
				num2 = (short)1563099137;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)226754560;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarPageExternalMicNoiseReductionProfile.DataContext = null;
				this.RecNavToolbarPageExternalMicNoiseReductionProfile.MyDataPresenter = null;
				num2 = (short)1780875264;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00609DA0 File Offset: 0x00607FA0
		internal void OnExternalMicNoiseReductionProfileFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)667040871;
			short num2 = num;
			num = (short)1803828327;
			switch (num2 == num)
			{
			}
			num = (short)654180352;
			short num3 = num;
			num = (short)683802625;
			if (num != 0)
			{
			}
			num = (short)1880227840;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x00609E74 File Offset: 0x00608074
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)548308168;
			short num2 = num;
			num = (short)1394181320;
			switch (num2 == num)
			{
			}
			num = (short)1819803648;
			short num3 = num;
			num = (short)1219297281;
			if (num != 0)
			{
			}
			num = (short)425852928;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x00609F24 File Offset: 0x00608124
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1388838913;
					if (num2 != 0)
					{
					}
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1976107010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 1:
					goto IL_136;
				case 2:
					goto IL_E9;
				}
				goto IL_1C;
			}
			IL_136:
			IL_138:
			global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			num2 = (short)514489163;
			short num3 = num2;
			num2 = (short)833190731;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E9:
				this.a.MoveCurrentToFirst();
				num2 = (short)1488322560;
				short num4 = num2;
				num2 = (short)196083713;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1586561024;
				if (num2 != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageExternalMicNoiseReductionProfile.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)1632698368;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x0060A084 File Offset: 0x00608284
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile A_0)
		{
			short num = (short)1700211692;
			short num2 = num;
			num = (short)471542764;
			switch (num2 == num)
			{
			}
			num = (short)2091057152;
			short num3 = num;
			num = (short)265814017;
			if (num != 0)
			{
			}
			num = (short)977141760;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x0060A154 File Offset: 0x00608354
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			while (this.c)
			{
				short num = (short)936338061;
				short num2 = num;
				num = (short)1656316557;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1443102720;
					short num3 = num;
					num = (short)1353777152;
					if (num != 0)
					{
					}
					num = (short)2050818049;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0臲铴鏶郸铺\ud8fc췾㄀昂眄怆昈攊戌戎砐瀒昔㈖⬘⬚縜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴ᠶ圸吺吼䰾⑀時睄睆㭈⹊⥌㩎㉐❒㱔㡖㝘繚潜潞ɠౢ୤Ŧh౪ᡬᵮၰݲᱴᡶ᝸呺᡼ݾꢌ붎ꆐﺒﲔ벘ꦚ궜캠쪢횤슦貨馪鶬\uddae풰ힲ살풶춸튺튼톾럆믈꓊ꯌꛎ뷐뛒䀹닖ꇘ꿚룜귞迠苢觤諦胨裪菬胮飰胲郴藶鳸鿺裼鳾甀樂樄椆礈礊戌椎砐缒瀔挖笘眚㌜朞䀠丢䤤", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x0060A23C File Offset: 0x0060843C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1286209538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C1;
				case 1:
				{
					if (connectionId == 2)
					{
						goto IL_86;
					}
					num = (short)1169568704;
					short num3 = num;
					num = (short)2115187648;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						num = (short)1589313537;
						if (num != 0)
						{
						}
						num = (short)1910898688;
						if (num != 0)
						{
						}
						num = (short)447021062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					if (connectionId != 22)
					{
						num = (short)964296709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16A;
				case 4:
					num = (short)31326209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1AA;
				case 6:
					num = (short)1922236419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				num = (short)1982791680;
				short num4 = num;
				if (connectionId != 1)
				{
					num = (short)296943620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1AF;
				IL_1AA:
				num = (short)1481113600;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_86:
			this.RecNavToolbarPageExternalMicNoiseReductionProfile = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageExternalMicNoiseReductionProfile.ModeClick += this.OnModeClick;
			return;
			IL_C1:
			this.c = true;
			return;
			IL_16A:
			this.ExternalMicNoiseReductionProfileList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1AF:
			((global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.PageExternalMicNoiseReductionProfileTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.PageExternalMicNoiseReductionProfileTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x0060A430 File Offset: 0x00608630
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
			{
				short num = (short)1909073921;
				short num2 = num;
				num = (short)1661085697;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)191889408;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 15:
			{
				short num = (short)485752833;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 16:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
			{
				short num = (short)1017708544;
				short num3 = num;
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 19:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				break;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002ACC RID: 10956
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04002ACD RID: 10957
		private bool b;

		// Token: 0x04002ACE RID: 10958
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageExternalMicNoiseReductionProfile;

		// Token: 0x04002ACF RID: 10959
		internal global::AcpUI.AcpXamDataPresenter ExternalMicNoiseReductionProfileList;

		// Token: 0x04002AD0 RID: 10960
		private bool c;
	}
}
