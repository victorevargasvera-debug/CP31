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
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000039 RID: 57
	public class PageSiteSelectableAlertListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x000663EC File Offset: 0x000645EC
		public PageSiteSelectableAlertListTbl()
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

		// Token: 0x060006DF RID: 1759 RVA: 0x00066424 File Offset: 0x00064624
		public override void SetDataContext()
		{
			short num = (short)947322881;
			if (num != 0)
			{
			}
			num = (short)335085573;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)52232192;
				short num3 = num;
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)116785156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 1:
					goto IL_B0;
				case 2:
					goto IL_B0;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4145);
					num = (short)967573506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_17F;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				}
				IL_8B:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1558183939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4145);
				num = (short)555941889;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B0:
				num = (short)915363207;
				short num4 = num;
				num = (short)605181319;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_203;
				default:
					num = (short)1848836096;
					if (num != 0)
					{
					}
					this.SiteSelectableAlertListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageSiteSelectableAlertList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageSiteSelectableAlertList.MyDataPresenter = this.SiteSelectableAlertListList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageSiteSelectableAlertList;
					num = (short)1675034624;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_17F:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4145);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSiteSelectableAlertList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_203:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSiteSelectableAlertList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00066640 File Offset: 0x00064840
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)658309122;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E7;
				case 1:
				{
					num = (short)70123520;
					short num3 = num;
					object myRecordsetDataSource = this.RecNavToolbarPageSiteSelectableAlertList.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1488322561;
					if (num != 0)
					{
					}
					num = (short)637534208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_3C:
				num = (short)1461714945;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7:
				num = (short)743597732;
				short num4 = num;
				num = (short)1207920292;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3C;
				default:
					goto IL_11B;
				}
				IL_31:
				if (!this.b)
				{
					goto IL_3C;
				}
				goto IL_E7;
			}
			IL_11B:
			num = (short)1239941120;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00066780 File Offset: 0x00064980
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1688101626;
					short num3 = num2;
					num2 = (short)1991664378;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
					{
						num2 = (short)1005453312;
						if (num2 != 0)
						{
						}
						num2 = (short)594804736;
						short num4 = num2;
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)1777664000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (this.b)
					{
						goto IL_7C;
					}
					return;
				}
				goto IL_1C;
				IL_7C:
				num2 = (short)2114453505;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)170786817;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarPageSiteSelectableAlertList.DataContext = null;
			this.RecNavToolbarPageSiteSelectableAlertList.MyDataPresenter = null;
			num2 = (short)947847170;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000668C0 File Offset: 0x00064AC0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1871984955;
			short num2 = num;
			num = (short)1340225851;
			switch (num2 == num)
			{
			}
			num = (short)1298333696;
			if (num != 0)
			{
			}
			num = (short)620363776;
			short num3 = num;
			num = (short)448528385;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00066970 File Offset: 0x00064B70
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_110;
				case 1:
				{
					num2 = (short)189813752;
					short num3 = num2;
					num2 = (short)1382241272;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
					{
						num2 = (short)1811677184;
						if (num2 != 0)
						{
						}
						this.a.MoveCurrentToFirst();
						num2 = (short)1608384512;
						short num4 = num2;
						num2 = (short)17367040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (this.a.CurrentItem == null)
					{
						goto IL_60;
					}
					goto IL_112;
				}
				goto IL_1C;
				IL_60:
				num2 = (short)570032129;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_110:
			IL_112:
			num2 = (short)1818427393;
			if (num2 != 0)
			{
			}
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList a_ = (global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageSiteSelectableAlertList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1398210562;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00066AD0 File Offset: 0x00064CD0
		private void a(global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList A_0)
		{
			short num = (short)356627366;
			short num2 = num;
			num = (short)680244134;
			switch (num2 == num)
			{
			}
			num = (short)1439629312;
			if (num != 0)
			{
			}
			num = (short)680919040;
			short num3 = num;
			num = (short)163774465;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00066BA0 File Offset: 0x00064DA0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (this.c)
			{
				short num = (short)1305804801;
				if (num != 0)
				{
				}
				num = (short)1410784022;
				short num2 = num;
				num = (short)303291158;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1296891904;
					if (num != 0)
					{
					}
					num = (short)1643184128;
					short num3 = num;
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂뇆ꛈꋊ껌꫎냐뷒믔룖곘뗚뻜뫞賠蛢诤鏦髨쓪黬蛮藰雲탴엶째裺飼鏾搀怂焄昆欈朊栌⨎⌐⌒琔笖簘椚検㨞ጠጢ䤤並娨弪Ȭ尮堰䜲倴䐶尸场堼尾㕀≂❄⭆ⱈ⩊⅌⩎⍐❒㥔㹖⩘⽚⥜㵞ൠ䵢ᵤ٦Ѩݪ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00066C84 File Offset: 0x00064E84
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2034761730;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F8;
				case 1:
					num = (short)1944715264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_88;
				case 2:
					goto IL_64;
				case 3:
				case 4:
					goto IL_154;
				case 5:
					goto IL_147;
				default:
					num = (short)1174667265;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_64:
			this.RecNavToolbarPageSiteSelectableAlertList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageSiteSelectableAlertList.ModeClick += this.OnModeClick;
			return;
			IL_88:
			num = (short)1618804737;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.PageSiteSelectableAlertListTbl)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.PageSiteSelectableAlertListTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_F8:
			num = (short)879495821;
			short num3 = num;
			num = (short)426052237;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_64;
			default:
				num = (short)1996816384;
				if (num != 0)
				{
				}
				goto IL_154;
			}
			IL_147:
			this.SiteSelectableAlertListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_154:
			num = (short)457244672;
			short num4 = num;
			this.c = true;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00066E18 File Offset: 0x00065018
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)211615747;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
				{
					num = (short)909115392;
					short num3 = num;
					num = (short)42598402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					while (connectionId != 4)
					{
						num = (short)1333079065;
						short num4 = num;
						num = (short)1074342937;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1181483008;
							if (num != 0)
							{
							}
							num = (short)2111307777;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					goto IL_116;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (connectionId == 3)
				{
					break;
				}
				num = (short)597360640;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_116:
			num = (short)532283393;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040002D5 RID: 725
		private bool b;

		// Token: 0x040002D6 RID: 726
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageSiteSelectableAlertList;

		// Token: 0x040002D7 RID: 727
		internal global::AcpUI.AcpXamDataPresenter SiteSelectableAlertListList;

		// Token: 0x040002D8 RID: 728
		private bool c;
	}
}
