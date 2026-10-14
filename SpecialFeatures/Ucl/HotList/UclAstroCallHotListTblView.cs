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

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D5 RID: 469
	public class UclAstroCallHotListTblView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060016C6 RID: 5830 RVA: 0x001F55C0 File Offset: 0x001F37C0
		public UclAstroCallHotListTblView()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x001F55F8 File Offset: 0x001F37F8
		public override void SetDataContext()
		{
			short num = (short)176357378;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1303052288;
				short num3 = num;
				switch (num2)
				{
				case 0:
					IL_86:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2210);
					num = (short)2053832707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_8B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
					goto IL_8B;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)23527429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_200;
				case 5:
					goto IL_17E;
				}
				IL_66:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)562888704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2210);
				num = (short)678166529;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B:
				num = (short)1574319294;
				short num4 = num;
				num = (short)317011134;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_86;
				default:
					num = (short)1566572545;
					if (num != 0)
					{
					}
					num = (short)817364992;
					if (num != 0)
					{
					}
					this.UclAstroHotList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageUclAstroHotList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageUclAstroHotList.MyDataPresenter = this.UclAstroHotList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageUclAstroHotList;
					num = (short)46530564;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_17E:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2210);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclAstroHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_200:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclAstroHotList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x001F5814 File Offset: 0x001F3A14
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!this.b)
						{
							num2 = (short)2061631490;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_96;
					case 2:
						base.OnLoaded(sender, e);
						this.b = true;
						num2 = (short)676265985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_96:
				num2 = (short)1376190464;
				short num3 = num2;
				num2 = (short)1528299521;
				if (num2 != 0)
				{
				}
				num2 = (short)48476384;
				short num4 = num2;
				num2 = (short)971550944;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_11C;
				}
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageUclAstroHotList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)2072248320;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_11C:
			num2 = (short)1319895040;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x001F5954 File Offset: 0x001F3B54
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.b)
						{
							num2 = (short)1910571010;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_90;
					case 2:
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)194314241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_90:
				num2 = (short)4587520;
				short num3 = num2;
				num2 = (short)26476545;
				if (num2 != 0)
				{
				}
				num2 = (short)63627636;
				short num4 = num2;
				num2 = (short)1880940916;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_115;
				}
				IL_1C:
				this.RecNavToolbarPageUclAstroHotList.DataContext = null;
				this.RecNavToolbarPageUclAstroHotList.MyDataPresenter = null;
				num2 = (short)1710292992;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_115:
			num2 = (short)1797324800;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x001F5A90 File Offset: 0x001F3C90
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)251655174;
			short num2 = num;
			num = (short)1211233286;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1371537408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)393609217;
			if (num != 0)
			{
			}
			num = (short)900464640;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x001F5B40 File Offset: 0x001F3D40
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1402929154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13A;
					case 1:
						goto IL_9B;
					case 2:
						this.a.MoveCurrentToFirst();
						num2 = (short)1661534209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_9B:
				num2 = (short)111476736;
				short num3 = num2;
				num2 = (short)1086495371;
				short num4 = num2;
				num2 = (short)1738054283;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_FA;
				}
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageUclAstroHotList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)1522663424;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_FA:
			num2 = (short)1572798464;
			if (num2 != 0)
			{
			}
			num2 = (short)433061889;
			if (num2 != 0)
			{
			}
			IL_13A:
			global::SpecialFeatures.Ucl.HotList.UclAstroCallHotList a_ = (global::SpecialFeatures.Ucl.HotList.UclAstroCallHotList)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x001F5CA0 File Offset: 0x001F3EA0
		private void a(global::SpecialFeatures.Ucl.HotList.UclAstroCallHotList A_0)
		{
			short num = (short)1700070274;
			short num2 = num;
			num = (short)317784962;
			switch (num2 == num)
			{
			default:
			{
				num = (short)521207808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)124715008;
			if (num != 0)
			{
			}
			num = (short)1460862977;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x001F5D70 File Offset: 0x001F3F70
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num = (short)1839279958;
			short num2 = num;
			num = (short)1825255254;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)575471616;
				short num3 = num;
				num = (short)542834688;
				if (num != 0)
				{
				}
				if (this.c)
				{
					num = (short)1355743233;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖉ\udf8bﺍﶓ\udc99鍊ﾝ풟힡횣쎥\udba7醩쾫솭\uddaf슱\udbb3\ud8b5\uddb7풹좻醽ꎿꏁꣃ꫅ﳋꋍ맏ꇑꃓ뿛뇝軟蓡跣臥鷧飩跫髭駯鷱髳\ud9f5郷闹裻鋽槿焁瀃⤅紇椉怋漍挏昑易礕笗笙瀛爝䠟䴡倣䨥䄧天堫娭刯帱䈳張崷䴹ሻ䘽ℿ⽁⡃", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x001F5E50 File Offset: 0x001F4050
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1976827904;
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
						goto IL_F3;
					case 2:
					{
						num = (short)892338176;
						short num3 = num;
						num = (short)1460404225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_AB;
					case 2:
						goto IL_87;
					case 3:
						goto IL_177;
					case 4:
						goto IL_F8;
					default:
						num = (short)2072444930;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F8:
				num = (short)703773590;
				short num4 = num;
				num = (short)1478146966;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_12E;
				}
			}
			IL_87:
			this.RecNavToolbarPageUclAstroHotList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageUclAstroHotList.ModeClick += this.OnModeClick;
			return;
			IL_AB:
			((global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListTblView)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListTblView)target).Unloaded += this.OnUnloaded;
			return;
			IL_F3:
			goto IL_177;
			IL_12E:
			num = (short)1892220929;
			if (num != 0)
			{
			}
			num = (short)1165819904;
			if (num != 0)
			{
			}
			this.UclAstroHotList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_177:
			this.c = true;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x001F5FDC File Offset: 0x001F41DC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1595867136;
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
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)1715273729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)649631116;
				short num3 = num;
				num = (short)446469516;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2118385665;
					if (num != 0)
					{
					}
					num = (short)1391591424;
					if (num != 0)
					{
					}
					if (connectionId != 3)
					{
						return;
					}
					num = (short)941359104;
					short num4 = num;
					num = (short)1026031618;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x04000BC0 RID: 3008
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000BC1 RID: 3009
		private bool b;

		// Token: 0x04000BC2 RID: 3010
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageUclAstroHotList;

		// Token: 0x04000BC3 RID: 3011
		internal global::AcpUI.AcpXamDataPresenter UclAstroHotList;

		// Token: 0x04000BC4 RID: 3012
		private bool c;
	}
}
