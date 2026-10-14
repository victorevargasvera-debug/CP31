using System;
using System.CodeDom.Compiler;
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
	// Token: 0x020001D9 RID: 473
	public class UclDTMFCallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060016EF RID: 5871 RVA: 0x00003A76 File Offset: 0x00001C76
		public UclDTMFCallHotListPage()
		{
			this.InitializeComponent();
			base.PageFeatureId = 2216;
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x001F7550 File Offset: 0x001F5750
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_132;
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1137180675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1605632000;
					short num3 = num2;
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(base.PageFeatureId);
					num2 = (short)1799487490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_102;
				case 3:
					goto IL_AE;
				}
				goto IL_20;
			}
			IL_AE:
			base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(base.PageFeatureId);
			goto IL_11A;
			IL_102:
			goto IL_15B;
			IL_132:
			num2 = (short)441647105;
			if (num2 != 0)
			{
			}
			IL_15B:
			this.RecNavToolbarDTMFCallHotListHotList.MyDataPresenter = this.DTMFCallHotListDataPresenter;
			return;
			IL_20:
			num2 = (short)229776365;
			short num4 = num2;
			num2 = (short)319298541;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_11A:
				num2 = (short)1595146240;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1966014464;
				if (num2 != 0)
				{
				}
				base.MyBaseRecNavToolbar = this.RecNavToolbarUclDTMFCallHotList;
				num2 = (short)1795424257;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x001F76CC File Offset: 0x001F58CC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)472494323;
			short num2 = num;
			num = (short)1503965427;
			switch (num2 == num)
			{
			}
			num = (short)216203264;
			if (num != 0)
			{
			}
			num = (short)1830944769;
			if (num != 0)
			{
			}
			num = (short)1787363328;
			short num3 = num;
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.RecNavToolbarUclDTMFCallHotList.MyRecordsetDataSource);
			global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.RecNavToolbarDTMFCallHotListHotList.MyRecordsetDataSource);
			base.OnLoaded(sender, e);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x001F77A8 File Offset: 0x001F59A8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			while (!this.a)
			{
				short num = (short)832674131;
				short num2 = num;
				num = (short)2096601427;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1984561152;
					if (num != 0)
					{
					}
					num = (short)826015745;
					if (num != 0)
					{
					}
					num = (short)11993088;
					short num3 = num;
					this.a = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾏솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯톱\udbb3\udbb5좷햹튻\udbbd꺿뛁ꗅ꧇ꛉꃋ룓뿕ꯗ껙率탟臡诣裥軧菩诫鯭苯鏱胳鿵韷铹폻雽濿瘁栃漅笇縉⌋笍猏縑瀓戕甗簙缛缝䰟両䰣䤥尧䘩䔫崭䐯䈱唳儵崷ᐹ䐻弽ⴿ⹁", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x001F788C File Offset: 0x001F5A8C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)845086720;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1480499937;
					short num3 = num;
					num = (short)1683071713;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					case 1:
						break;
					default:
					{
						num = (short)1577648128;
						short num4 = num;
						break;
					}
					}
					num = (short)1991901184;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				case 1:
					goto IL_162;
				case 2:
					num = (short)950534145;
					if (num != 0)
					{
					}
					num = (short)569114625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				switch (connectionId)
				{
				case 1:
					goto IL_125;
				case 2:
					goto IL_18B;
				case 3:
					goto IL_17E;
				case 4:
					goto IL_118;
				case 5:
					goto IL_164;
				case 6:
					goto IL_10B;
				case 7:
					goto IL_13E;
				case 8:
					goto IL_171;
				default:
					num = (short)743964674;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10B:
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
			return;
			IL_118:
			this.ExpDTMFCallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_125:
			((global::SpecialFeatures.Ucl.HotList.UclDTMFCallHotListPage)target).Loaded += this.OnLoaded;
			return;
			IL_13E:
			this.RecNavToolbarDTMFCallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
			return;
			IL_162:
			this.a = true;
			return;
			IL_164:
			this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
			return;
			IL_171:
			this.DTMFCallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_17E:
			this.LstBoxUclContact = (global::AcpUI.AcpListBox)target;
			return;
			IL_18B:
			this.RecNavToolbarUclDTMFCallHotList = (global::AcpUI.AcpRecNavToolbar)target;
		}

		// Token: 0x04000BC7 RID: 3015
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarUclDTMFCallHotList;

		// Token: 0x04000BC8 RID: 3016
		internal global::AcpUI.AcpListBox LstBoxUclContact;

		// Token: 0x04000BC9 RID: 3017
		internal global::AcpUI.AcpExpander ExpDTMFCallHotList;

		// Token: 0x04000BCA RID: 3018
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000BCB RID: 3019
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000BCC RID: 3020
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarDTMFCallHotListHotList;

		// Token: 0x04000BCD RID: 3021
		internal global::AcpUI.AcpXamDataPresenter DTMFCallHotListDataPresenter;

		// Token: 0x04000BCE RID: 3022
		private bool a;
	}
}
