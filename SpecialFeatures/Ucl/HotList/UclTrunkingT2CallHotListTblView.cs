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
	// Token: 0x020001F1 RID: 497
	public class UclTrunkingT2CallHotListTblView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060017E6 RID: 6118 RVA: 0x00205FB4 File Offset: 0x002041B4
		public UclTrunkingT2CallHotListTblView()
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

		// Token: 0x060017E7 RID: 6119 RVA: 0x00205FEC File Offset: 0x002041EC
		public override void SetDataContext()
		{
			short num = (short)1325400066;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_202;
					}
					num = (short)242121593;
					short num3 = num;
					num = (short)424901497;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
						num = (short)927137792;
						if (num != 0)
						{
						}
						num = (short)1913520133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2214);
					num = (short)1220083716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_63;
				case 4:
					goto IL_63;
				case 5:
					goto IL_131;
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1220804609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2214);
				num = (short)407109635;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_63:
				this.UclTrunkingT2HotList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageUclTrunkingT2HotList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageUclTrunkingT2HotList.MyDataPresenter = this.UclTrunkingT2HotList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageUclTrunkingT2HotList;
				num = (short)1764556800;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_131:
			num = (short)106496000;
			short num4 = num;
			IL_1B8:
			num = (short)2111504385;
			if (num != 0)
			{
			}
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2214);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclTrunkingT2HotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_202:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclTrunkingT2HotList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00206208 File Offset: 0x00204408
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!this.b)
						{
							num2 = (short)2050949121;
							if (num2 != 0)
							{
							}
							num2 = (short)774111232;
							short num3 = num2;
							num2 = (short)1225785346;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						base.OnLoaded(sender, e);
						this.b = true;
						num2 = (short)937189073;
						short num4 = num2;
						num2 = (short)44654289;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							num2 = (short)637992960;
							if (num2 != 0)
							{
							}
							num2 = (short)885587969;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageUclTrunkingT2HotList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_39:
			num2 = (short)417267712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0020634C File Offset: 0x0020454C
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.b)
						{
							num2 = (short)1302921217;
							if (num2 != 0)
							{
							}
							num2 = (short)2111111168;
							short num3 = num2;
							num2 = (short)1204617218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)1655371684;
						short num4 = num2;
						num2 = (short)1767831460;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
							num2 = (short)1322450944;
							if (num2 != 0)
							{
							}
							num2 = (short)12255233;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarPageUclTrunkingT2HotList.DataContext = null;
			this.RecNavToolbarPageUclTrunkingT2HotList.MyDataPresenter = null;
			IL_34:
			num2 = (short)205258752;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0020648C File Offset: 0x0020468C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)215430796;
			short num2 = num;
			num = (short)2103391884;
			switch (num2 == num)
			{
			default:
			{
				num = (short)954597376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1846673408;
			if (num != 0)
			{
			}
			num = (short)641531905;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00206540 File Offset: 0x00204740
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1343029250;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_136;
					case 1:
						goto IL_134;
					case 2:
					{
						num2 = (short)179306496;
						short num3 = num2;
						num2 = (short)1552154625;
						if (num2 != 0)
						{
						}
						this.a.MoveCurrentToFirst();
						num2 = (short)1320369179;
						short num4 = num2;
						num2 = (short)1857305627;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
							num2 = (short)164954112;
							if (num2 != 0)
							{
							}
							num2 = (short)2066022401;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				IL_134:
				IL_136:
				global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotList a_ = (global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotList)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			}
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageUclTrunkingT2HotList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_3B:
			num2 = (short)173146112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0020669C File Offset: 0x0020489C
		private void a(global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotList A_0)
		{
			short num = (short)1292364253;
			short num2 = num;
			num = (short)545253853;
			switch (num2 == num)
			{
			default:
			{
				num = (short)285605888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)217972737;
			if (num != 0)
			{
			}
			num = (short)1540292608;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0020676C File Offset: 0x0020496C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)830165933;
			short num2 = num;
			num = (short)1430344621;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2099380224;
				short num3 = num;
				num = (short)702349313;
				if (num != 0)
				{
				}
				num = (short)1880293376;
				if (num != 0)
				{
				}
				if (!this.c)
				{
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂎ슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮튰\udcb2\ud8b4잶횸햺\ud8bc톾뗀ꛄꛆꗈꟊ﷎뿒볔ꓖ귘ﻚ苠賢诤臦胨質飬鷮郰蟲鳴飶韸퓺闼郾甀漂氄理紈␊砌氎紐朒朔或眘瀚琜焞䘠圢ᜤ䐦䠨䜪䄬䜮帰䜲头帶䨸伺䤼崾ⵀ㕂ⱄ≆㹈敊㕌⹎㱐㽒", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00206850 File Offset: 0x00204A50
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1769406464;
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
					goto IL_142;
				case 2:
					num = (short)1304231937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)695861248;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_F9;
				case 2:
					goto IL_D5;
				case 3:
					goto IL_17A;
				case 4:
					goto IL_16D;
				default:
				{
					num = (short)135255193;
					short num4 = num;
					num = (short)1696847001;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16D;
					default:
						num = (short)1257701376;
						if (num != 0)
						{
						}
						num = (short)1086652418;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_D5:
			this.RecNavToolbarPageUclTrunkingT2HotList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageUclTrunkingT2HotList.ModeClick += this.OnModeClick;
			return;
			IL_F9:
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListTblView)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListTblView)target).Unloaded += this.OnUnloaded;
			return;
			IL_142:
			num = (short)1196163073;
			if (num != 0)
			{
			}
			goto IL_17A;
			IL_16D:
			this.UclTrunkingT2HotList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_17A:
			this.c = true;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x002069E0 File Offset: 0x00204BE0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1065811968;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1836646400;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1184004925;
					short num4 = num;
					num = (short)600996669;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1661206528;
						if (num != 0)
						{
						}
						num = (short)716767233;
						if (num != 0)
						{
						}
						((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
						num = (short)1788477441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_59:
				if (connectionId != 3)
				{
					break;
				}
				num = (short)273416194;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000C7B RID: 3195
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000C7C RID: 3196
		private bool b;

		// Token: 0x04000C7D RID: 3197
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageUclTrunkingT2HotList;

		// Token: 0x04000C7E RID: 3198
		internal global::AcpUI.AcpXamDataPresenter UclTrunkingT2HotList;

		// Token: 0x04000C7F RID: 3199
		private bool c;
	}
}
