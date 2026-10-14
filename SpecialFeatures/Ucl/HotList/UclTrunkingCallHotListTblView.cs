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
	// Token: 0x020001EC RID: 492
	public class UclTrunkingCallHotListTblView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060017AC RID: 6060 RVA: 0x00202498 File Offset: 0x00200698
		public UclTrunkingCallHotListTblView()
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

		// Token: 0x060017AD RID: 6061 RVA: 0x002024D0 File Offset: 0x002006D0
		public override void SetDataContext()
		{
			short num = (short)922157059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10C;
				case 1:
					goto IL_62;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2208);
					num = (short)695992324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_62;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1994326017;
						if (num != 0)
						{
						}
						num = (short)586809344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18D;
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)107544578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2208);
				num = (short)1235156993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62:
				this.UclTrunkingHotList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageUclTrunkingHotList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageUclTrunkingHotList.MyDataPresenter = this.UclTrunkingHotList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageUclTrunkingHotList;
				num = (short)560398341;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			IL_16B:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2208);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclTrunkingHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_18D:
			num = (short)44338475;
			short num3 = num;
			num = (short)528715051;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_16B;
			default:
			{
				num = (short)1997471744;
				if (num != 0)
				{
				}
				num = (short)645726208;
				short num4 = num;
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclTrunkingHotList).MySecondaryRecordsetDataSource = null;
				return;
			}
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x002026EC File Offset: 0x002008EC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
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
					if (!this.b)
					{
						num2 = (short)953614338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10F;
				case 1:
					goto IL_10D;
				case 2:
					goto IL_E4;
				}
				goto IL_1C;
			}
			IL_10D:
			IL_10F:
			num2 = (short)61800449;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)401801216;
			short num3 = num2;
			num2 = (short)1067203444;
			short num4 = num2;
			num2 = (short)1613183860;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E4:
				base.OnLoaded(sender, e);
				this.b = true;
				num2 = (short)420216833;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2060779520;
				if (num2 != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageUclTrunkingHotList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)353632256;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00202830 File Offset: 0x00200A30
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
					if (this.b)
					{
						num2 = (short)612696066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_108;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1234829312;
			short num3 = num2;
			num2 = (short)735903745;
			if (num2 != 0)
			{
			}
			num2 = (short)789651815;
			short num4 = num2;
			num2 = (short)549593447;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_108:
				base.OnUnloaded(sender, e);
				this.b = false;
				num2 = (short)1124401153;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1436680192;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarPageUclTrunkingHotList.DataContext = null;
				this.RecNavToolbarPageUclTrunkingHotList.MyDataPresenter = null;
				num2 = (short)1123811328;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00202970 File Offset: 0x00200B70
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2099220518;
			short num2 = num;
			num = (short)1391104038;
			switch (num2 == num)
			{
			}
			num = (short)6750209;
			if (num != 0)
			{
			}
			num = (short)883032064;
			short num3 = num;
			num = (short)116654080;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00202A1C File Offset: 0x00200C1C
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
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1486880770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 1:
					goto IL_110;
				case 2:
					goto IL_EB;
				}
				goto IL_1C;
			}
			IL_110:
			num2 = (short)39780353;
			if (num2 != 0)
			{
			}
			IL_139:
			global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotList a_ = (global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			num2 = (short)1373896704;
			short num3 = num2;
			num2 = (short)687316558;
			short num4 = num2;
			num2 = (short)1206033998;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_EB:
				this.a.MoveCurrentToFirst();
				num2 = (short)2031026177;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1612316672;
				if (num2 != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageUclTrunkingHotList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)1757675520;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00202B7C File Offset: 0x00200D7C
		private void a(global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotList A_0)
		{
			short num = (short)285931225;
			short num2 = num;
			num = (short)226621145;
			switch (num2 == num)
			{
			}
			num = (short)1025310721;
			if (num != 0)
			{
			}
			num = (short)1629224960;
			short num3 = num;
			num = (short)159318016;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00202C4C File Offset: 0x00200E4C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (this.c)
			{
				short num = (short)1290207232;
				short num2 = num;
				num = (short)1880711812;
				short num3 = num;
				num = (short)105013892;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)709099520;
					if (num != 0)
					{
					}
					num = (short)942473217;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂꓆꣈ꟊꇌ맔뻖꫘꿚퇠胢諤触迨苪諬髮菰鋲致黶雸闺틼韾渀眂椄渆稈缊∌税爐缒愔攖氘甚瘜瘞传䐢䘤䘦䔨䜪䔬䀮䔰弲尴䐶䴸伺弼匾㝀⩂⁄う杈㍊ⱌ≎㵐", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00202D2C File Offset: 0x00200F2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)828309504;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1727594497;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					goto IL_169;
				case 2:
					goto IL_151;
				}
				IL_58:
				num = (short)417352050;
				short num3 = num;
				num = (short)918571378;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_151:
					num = (short)385875969;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)814612480;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_120;
					case 2:
						goto IL_D4;
					case 3:
						goto IL_178;
					case 4:
						goto IL_16B;
					default:
						num = (short)1108934658;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_D4:
			num = (short)55050240;
			short num4 = num;
			this.RecNavToolbarPageUclTrunkingHotList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageUclTrunkingHotList.ModeClick += this.OnModeClick;
			return;
			IL_120:
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListTblView)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListTblView)target).Unloaded += this.OnUnloaded;
			return;
			IL_169:
			goto IL_178;
			IL_16B:
			this.UclTrunkingHotList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_178:
			this.c = true;
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00202EB8 File Offset: 0x002010B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)897908736;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_F6;
				case 2:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)1331691521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				num = (short)2064983090;
				short num3 = num;
				num = (short)1471751218;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F8;
				default:
				{
					num = (short)1521090560;
					if (num != 0)
					{
					}
					if (connectionId != 3)
					{
						goto IL_F8;
					}
					num = (short)1980301312;
					short num4 = num;
					num = (short)571146242;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_F6:
			IL_F8:
			num = (short)476381185;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000C4D RID: 3149
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000C4E RID: 3150
		private bool b;

		// Token: 0x04000C4F RID: 3151
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageUclTrunkingHotList;

		// Token: 0x04000C50 RID: 3152
		internal global::AcpUI.AcpXamDataPresenter UclTrunkingHotList;

		// Token: 0x04000C51 RID: 3153
		private bool c;
	}
}
