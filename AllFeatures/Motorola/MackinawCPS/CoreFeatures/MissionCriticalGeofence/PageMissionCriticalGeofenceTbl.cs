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

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x0200026F RID: 623
	public class PageMissionCriticalGeofenceTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06006EFC RID: 28412 RVA: 0x0062E8E4 File Offset: 0x0062CAE4
		public PageMissionCriticalGeofenceTbl()
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

		// Token: 0x06006EFD RID: 28413 RVA: 0x0062E91C File Offset: 0x0062CB1C
		public override void SetDataContext()
		{
			short num = (short)1152057346;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AC;
				case 1:
				{
					num = (short)688848896;
					short num3 = num;
					num = (short)1423900673;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)144375813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				}
				case 2:
				{
					num = (short)1151724630;
					short num4 = num;
					num = (short)2144726102;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AC;
					default:
						num = (short)1937440768;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4174);
					num = (short)697171968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_AC;
				case 5:
					goto IL_184;
				}
				IL_88:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)492961795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4174);
				num = (short)806551556;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				this.MissionCriticalGeofenceList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageMissionCriticalGeofence.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageMissionCriticalGeofence.MyDataPresenter = this.MissionCriticalGeofenceList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageMissionCriticalGeofence;
				num = (short)151322625;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_184:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4174);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMissionCriticalGeofence).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_206:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMissionCriticalGeofence).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x0062EB3C File Offset: 0x0062CD3C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1536491520;
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
						goto IL_10C;
					case 2:
					{
						object myRecordsetDataSource = this.RecNavToolbarPageMissionCriticalGeofence.MyRecordsetDataSource;
						this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						base.OnLoaded(sender, e);
						this.b = true;
						num = (short)723320833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (this.b)
					{
						goto IL_10E;
					}
					num = (short)1040752770;
					short num3 = num;
					num = (short)603889794;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)828571648;
						if (num != 0)
						{
						}
						num = (short)898105345;
						if (num != 0)
						{
						}
						num = (short)411893762;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_10C:
			IL_10E:
			num = (short)991625216;
			short num4 = num;
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x0062EC84 File Offset: 0x0062CE84
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				IL_00:
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
					{
						if (!this.b)
						{
							goto IL_107;
						}
						num2 = (short)1956778514;
						short num3 = num2;
						num2 = (short)55382546;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1625423872;
							if (num2 != 0)
							{
							}
							num2 = (short)837681154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_105;
					case 2:
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)469237761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarPageMissionCriticalGeofence.DataContext = null;
				this.RecNavToolbarPageMissionCriticalGeofence.MyDataPresenter = null;
				num2 = (short)1249312769;
				if (num2 != 0)
				{
				}
				num2 = (short)73400320;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_105:
			IL_107:
			num2 = (short)987889664;
			short num4 = num2;
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x0062EDC4 File Offset: 0x0062CFC4
		internal void OnMissionCriticalGeofenceFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)194344046;
			short num2 = num;
			num = (short)1512207470;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1612644352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)163315713;
			if (num != 0)
			{
			}
			num = (short)1623326720;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence a_ = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x0062EE98 File Offset: 0x0062D098
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)398925172;
			short num2 = num;
			num = (short)568991092;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1313013760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1401159680;
			if (num != 0)
			{
			}
			num = (short)1019084801;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x0062EF4C File Offset: 0x0062D14C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num2;
			for (;;)
			{
				IL_00:
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
					{
						if (this.a.CurrentItem != null)
						{
							goto IL_EB;
						}
						num2 = (short)500075095;
						short num3 = num2;
						num2 = (short)87525975;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)974323712;
							if (num2 != 0)
							{
							}
							num2 = (short)2027225090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_E9;
					case 2:
						this.a.MoveCurrentToFirst();
						num2 = (short)344391681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageMissionCriticalGeofence.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)799408128;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_E9:
			IL_EB:
			num2 = (short)1717239809;
			if (num2 != 0)
			{
			}
			num2 = (short)57868288;
			short num4 = num2;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence a_ = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x0062F0B0 File Offset: 0x0062D2B0
		private void a(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence A_0)
		{
			short num = (short)1203534970;
			short num2 = num;
			num = (short)1489992826;
			switch (num2 == num)
			{
			default:
			{
				num = (short)945160192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)496107521;
			if (num != 0)
			{
			}
			num = (short)330104832;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x0062F180 File Offset: 0x0062D380
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 9;
			while (this.c)
			{
				short num = (short)2097196967;
				short num2 = num;
				num = (short)1484435367;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1929248768;
					short num3 = num;
					num = (short)906625025;
					if (num != 0)
					{
					}
					num = (short)1380646912;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1蟣觥藧髩菫胭闯鳱胳\ud9f5諷鯹飻韽濿✁㘃㘅洇砉欋愍縏紑礓缕笗椙㤛Ⱍဟ䄡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹ጻ匽⤿ㅁ㝃⽅❇⑉楋籍恏ㅑ♓㽕ⱗ㍙㽛㽝౟䝡噣噥ཧཀྵͫ࡭ᕯᱱᝳ፵坷᝹ᕻൽ揄憐歹ﾗﾙ얟첡잣쎥\udca7좩삫肭좯펱\ud9b3\udab5", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x0062F264 File Offset: 0x0062D464
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1952645123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)980680705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)2018680861;
					short num3 = num;
					num = (short)388472861;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_121;
					}
					break;
				}
				case 2:
					if (connectionId != 2)
					{
						num = (short)836042758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2;
				case 3:
					goto IL_15;
				case 4:
					num = (short)2080702466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (connectionId != 8)
					{
						num = (short)699662336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_175;
				case 6:
					num = (short)1052639237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6B;
				IL_15:
				num = (short)1184825344;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_6B:
					if (connectionId == 1)
					{
						goto IL_1BA;
					}
					num = (short)2010841089;
					if (num != 0)
					{
					}
					num = (short)836698116;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B2:
			this.RecNavToolbarPageMissionCriticalGeofence = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageMissionCriticalGeofence.ModeClick += this.OnModeClick;
			return;
			IL_121:
			num = (short)1084030976;
			if (num != 0)
			{
			}
			this.c = true;
			return;
			IL_175:
			this.MissionCriticalGeofenceList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BA:
			((global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.PageMissionCriticalGeofenceTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.PageMissionCriticalGeofenceTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x0062F464 File Offset: 0x0062D664
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
			{
				short num = (short)197158914;
				short num2 = num;
				num = (short)935946242;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)631373824;
					if (num != 0)
					{
					}
					num = (short)328138752;
					short num3 = num;
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 5:
				break;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
			{
				short num = (short)600834049;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002B32 RID: 11058
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04002B33 RID: 11059
		private bool b;

		// Token: 0x04002B34 RID: 11060
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageMissionCriticalGeofence;

		// Token: 0x04002B35 RID: 11061
		internal global::AcpUI.AcpXamDataPresenter MissionCriticalGeofenceList;

		// Token: 0x04002B36 RID: 11062
		private bool c;
	}
}
