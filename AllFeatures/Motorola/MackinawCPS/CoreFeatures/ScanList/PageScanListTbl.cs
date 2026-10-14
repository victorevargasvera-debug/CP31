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

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x02000121 RID: 289
	public class PageScanListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06002A85 RID: 10885 RVA: 0x00296BC0 File Offset: 0x00294DC0
		public PageScanListTbl()
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

		// Token: 0x06002A86 RID: 10886 RVA: 0x00296BF8 File Offset: 0x00294DF8
		public override void SetDataContext()
		{
			short num = (short)1934884865;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2039303540;
				short num3 = num;
				num = (short)32656756;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)155451392;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_AF;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 2:
						goto IL_131;
					case 3:
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2057);
						num = (short)1455947780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_AF;
					case 5:
						goto IL_10F;
					}
					IL_87:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)145948675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2057);
					num = (short)342097920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF:
					this.ScanListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageScanList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageScanList.MyDataPresenter = this.ScanListList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageScanList;
					num = (short)713293829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10F:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					goto IL_1B3;
				}
				num = (short)1761476610;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_131:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2057);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageScanList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_1B3:
			num = (short)937164801;
			if (num != 0)
			{
			}
			num = (short)2082668544;
			short num4 = num;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageScanList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00296E14 File Offset: 0x00295014
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)582746112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)598671360;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				case 1:
					return;
				case 2:
				{
					num = (short)989835223;
					short num4 = num;
					num = (short)465088471;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1574961152;
						if (num != 0)
						{
						}
						object myRecordsetDataSource = this.RecNavToolbarPageScanList.MyRecordsetDataSource;
						this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						base.OnLoaded(sender, e);
						this.b = true;
						num = (short)110690305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_5A:
				if (this.b)
				{
					break;
				}
				num = (short)1503657985;
				if (num != 0)
				{
				}
				num = (short)12451842;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00296F58 File Offset: 0x00295158
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
					if (this.b)
					{
						num2 = (short)420741122;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1576730625;
					if (num2 != 0)
					{
					}
					num2 = (short)1643188688;
					short num3 = num2;
					num2 = (short)617812432;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1780613120;
						if (num2 != 0)
						{
						}
						num2 = (short)1325989888;
						short num4 = num2;
						base.OnUnloaded(sender, e);
						this.b = false;
						break;
					}
					}
					num2 = (short)842203137;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarPageScanList.DataContext = null;
			this.RecNavToolbarPageScanList.MyDataPresenter = null;
			num2 = (short)745734144;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00297090 File Offset: 0x00295290
		internal void OnScanListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)931901596;
			short num2 = num;
			num = (short)1532276892;
			switch (num2 == num)
			{
			}
			num = (short)522256384;
			if (num != 0)
			{
			}
			num = (short)1934819328;
			short num3 = num;
			num = (short)1072496641;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00297164 File Offset: 0x00295364
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)531777984;
			short num2 = num;
			num = (short)26102208;
			switch (num2 == num)
			{
			}
			num = (short)1431306241;
			if (num != 0)
			{
			}
			num = (short)1105985536;
			short num3 = num;
			num = (short)804388864;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00297214 File Offset: 0x00295414
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
					num2 = (short)1474822145;
					if (num2 != 0)
					{
					}
					if (this.a.CurrentItem == null)
					{
						num2 = (short)541523970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 1:
					goto IL_136;
				case 2:
				{
					num2 = (short)843033553;
					short num3 = num2;
					num2 = (short)1574218705;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1122172928;
						if (num2 != 0)
						{
						}
						num2 = (short)894697472;
						short num4 = num2;
						this.a.MoveCurrentToFirst();
						break;
					}
					}
					num2 = (short)1723924481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_136:
			IL_138:
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageScanList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1941897216;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00297374 File Offset: 0x00295574
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList A_0)
		{
			short num = (short)1771448700;
			short num2 = num;
			num = (short)1255876988;
			switch (num2 == num)
			{
			}
			num = (short)711196673;
			if (num != 0)
			{
			}
			num = (short)466681856;
			short num3 = num;
			num = (short)1808400384;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00297444 File Offset: 0x00295644
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 6;
			while (this.c)
			{
				short num = (short)1435025670;
				short num2 = num;
				num = (short)1631764742;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1695678465;
					if (num != 0)
					{
					}
					num = (short)1992753152;
					if (num != 0)
					{
					}
					num = (short)55181312;
					short num3 = num;
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2蛴银飸闺\ud8fc췾㄀怂樄椆漈戊樌税挐爒愔縖瘘甚㈜氞䈠䈢䬤Ȧᬨᬪ䄬䘮䈰䜲ᨴ䐶娸娺匼匾⡀あㅄ㍆⭈❊捌㝎ぐ㹒㥔", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00297524 File Offset: 0x00295724
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)218693633;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1504575490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
				{
					if (connectionId == 25)
					{
						goto IL_127;
					}
					num = (short)2033172633;
					short num3 = num;
					num = (short)897826969;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1417478144;
						if (num != 0)
						{
						}
						num = (short)762314757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)485228550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_C3;
				case 5:
				{
					num = (short)1524105216;
					short num4 = num;
					num = (short)118882308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)1306525697;
					if (num != 0)
					{
					}
					if (connectionId != 2)
					{
						num = (short)1506410496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D;
				}
				IL_40:
				if (connectionId == 1)
				{
					goto IL_1B7;
				}
				num = (short)1685913603;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			this.RecNavToolbarPageScanList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageScanList.ModeClick += this.OnModeClick;
			return;
			IL_C3:
			this.c = true;
			return;
			IL_127:
			this.ScanListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B7:
			((global::Motorola.MackinawCPS.CoreFeatures.ScanList.PageScanListTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ScanList.PageScanListTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00297720 File Offset: 0x00295920
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
			{
				short num = (short)1344348414;
				short num2 = num;
				num = (short)590422270;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)106758144;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 17:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
			{
				short num = (short)686948352;
				short num3 = num;
				num = (short)578355201;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000FCB RID: 4043
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000FCC RID: 4044
		private bool b;

		// Token: 0x04000FCD RID: 4045
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageScanList;

		// Token: 0x04000FCE RID: 4046
		internal global::AcpUI.AcpXamDataPresenter ScanListList;

		// Token: 0x04000FCF RID: 4047
		private bool c;
	}
}
