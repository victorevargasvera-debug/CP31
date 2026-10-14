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
	// Token: 0x020001E7 RID: 487
	public class UclQCIICallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x00003B57 File Offset: 0x00001D57
		public UclQCIICallHotListPage()
		{
			this.InitializeComponent();
			base.PageFeatureId = 2218;
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x001FEFD4 File Offset: 0x001FD1D4
		public override void SetDataContext()
		{
			short num = (short)704839680;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num3;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					goto IL_DB;
				case 1:
					goto IL_10B;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(base.PageFeatureId);
					num = (short)1609564161;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)106561538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(base.PageFeatureId);
					num = (short)578682881;
					if (num != 0)
					{
					}
					num = (short)1922105344;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4B;
			}
			IL_DB:
			goto IL_157;
			IL_10B:
			num = (short)839119156;
			short num4 = num;
			num = (short)764735796;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2009399296;
				if (num != 0)
				{
				}
				break;
			}
			IL_157:
			this.RecNavToolbarQCIICallHotListHotList.MyDataPresenter = this.QCIICallHotListDataPresenter;
			return;
			IL_4B:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclQCIICallHotList;
			num = (short)750190595;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x001FF14C File Offset: 0x001FD34C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)241172480;
			short num2 = num;
			num = (short)6332148;
			short num3 = num;
			num = (short)521576180;
			switch (num3 == num)
			{
			}
			num = (short)859111424;
			if (num != 0)
			{
			}
			num = (short)546373633;
			if (num != 0)
			{
			}
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.RecNavToolbarUclQCIICallHotList.MyRecordsetDataSource);
			global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.RecNavToolbarQCIICallHotListHotList.MyRecordsetDataSource);
			base.OnLoaded(sender, e);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x001FF228 File Offset: 0x001FD428
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			short num;
			if (this.a)
			{
				num = (short)176160769;
				if (num != 0)
				{
				}
				num = (short)114725951;
				short num2 = num;
				num = (short)2462783;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1373437952;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1210122240;
			short num3 = num;
			this.a = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪄ풆麗ﾒ펔쒠킢麤쒦욨욪\uddac삮\udfb0횲\udbb4쎶隸\ud8ba\udcbc펾귀ꗈꋊ뻌믎듖뛘뗚믜뛞蛠離韤蛦鷨苪苬臮\udef0鯲髴菶闸鋺軼课⸀瘂昄欆砈栊搌明爐爒礔笖焘琚検猞䠠倢儤圦䠨䰪䠬Į䤰刲場嬶", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x001FF308 File Offset: 0x001FD508
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)912249392;
			short num2 = num;
			num = (short)1429983792;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)58785792;
				if (num != 0)
				{
				}
				num = (short)137101313;
				if (num != 0)
				{
				}
				num = (short)140509186;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)2102657025;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_161;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					IL_A2:
					switch (connectionId)
					{
					case 1:
						goto IL_123;
					case 2:
						goto IL_18A;
					case 3:
						goto IL_17D;
					case 4:
						goto IL_116;
					case 5:
						goto IL_163;
					case 6:
						goto IL_E1;
					case 7:
						goto IL_13C;
					case 8:
						goto IL_170;
					default:
						num = (short)297009152;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_116:
				this.ExpQCIICallHotList = (global::AcpUI.AcpExpander)target;
				return;
				IL_123:
				((global::SpecialFeatures.Ucl.HotList.UclQCIICallHotListPage)target).Loaded += this.OnLoaded;
				return;
				IL_13C:
				this.RecNavToolbarQCIICallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
				return;
				IL_161:
				this.a = true;
				return;
				IL_163:
				this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
				return;
				IL_170:
				this.QCIICallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
				return;
				IL_17D:
				this.LstBoxUclContact = (global::AcpUI.AcpListBox)target;
				return;
				IL_18A:
				this.RecNavToolbarUclQCIICallHotList = (global::AcpUI.AcpRecNavToolbar)target;
				return;
			}
			}
			IL_E1:
			num = (short)1356791808;
			short num4 = num;
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
		}

		// Token: 0x04000C1C RID: 3100
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarUclQCIICallHotList;

		// Token: 0x04000C1D RID: 3101
		internal global::AcpUI.AcpListBox LstBoxUclContact;

		// Token: 0x04000C1E RID: 3102
		internal global::AcpUI.AcpExpander ExpQCIICallHotList;

		// Token: 0x04000C1F RID: 3103
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000C20 RID: 3104
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000C21 RID: 3105
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarQCIICallHotListHotList;

		// Token: 0x04000C22 RID: 3106
		internal global::AcpUI.AcpXamDataPresenter QCIICallHotListDataPresenter;

		// Token: 0x04000C23 RID: 3107
		private bool a;
	}
}
