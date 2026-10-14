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

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005DE RID: 1502
	public class PageASTROTalkgroupListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600CF3A RID: 53050 RVA: 0x00C0D810 File Offset: 0x00C0BA10
		public PageASTROTalkgroupListTbl()
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

		// Token: 0x0600CF3B RID: 53051 RVA: 0x00C0D848 File Offset: 0x00C0BA48
		public override void SetDataContext()
		{
			short num = (short)902168577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					goto IL_8A;
				case 3:
				{
					num = (short)319684608;
					short num3 = num;
					num = (short)569041901;
					short num4 = num;
					num = (short)2124080109;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F5;
					default:
						num = (short)653656065;
						if (num != 0)
						{
						}
						num = (short)767033344;
						if (num != 0)
						{
						}
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2062);
						num = (short)1320681474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_10C;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_F5;
					}
					goto IL_205;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)793182211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2062);
				num = (short)1329332224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8A:
				this.ASTROTalkgroupListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageASTROTalkgroupList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageASTROTalkgroupList.MyDataPresenter = this.ASTROTalkgroupListList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageASTROTalkgroupList;
				num = (short)774045701;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F5:
				num = (short)55640068;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2062);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageASTROTalkgroupList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_205:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageASTROTalkgroupList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x00C0DA68 File Offset: 0x00C0BC68
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1311440896;
			short num2 = num;
			num = (short)617414656;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)183762945;
					if (num != 0)
					{
					}
					object myRecordsetDataSource = this.RecNavToolbarPageASTROTalkgroupList.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1885810067;
					short num4 = num;
					num = (short)947531155;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1772748800;
						if (num != 0)
						{
						}
						num = (short)1856634881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_58:
				if (this.b)
				{
					break;
				}
				num = (short)437780482;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x00C0DBA8 File Offset: 0x00C0BDA8
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1685061632;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (this.b)
					{
						num = (short)88997890;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)1362082126;
					short num4 = num;
					num = (short)248494414;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						goto IL_114;
					}
					break;
				}
				case 2:
					num = (short)200081409;
					if (num != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.b = false;
					goto IL_C8;
				}
				goto IL_44;
				IL_C8:
				num = (short)850657281;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			num = (short)1494548480;
			if (num != 0)
			{
			}
			return;
			IL_44:
			this.RecNavToolbarPageASTROTalkgroupList.DataContext = null;
			this.RecNavToolbarPageASTROTalkgroupList.MyDataPresenter = null;
			num = (short)1672413184;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x00C0DCE0 File Offset: 0x00C0BEE0
		internal void OnASTROTalkgroupListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)22937600;
			short num2 = num;
			num = (short)438782715;
			short num3 = num;
			num = (short)2019904251;
			switch (num3 == num)
			{
			}
			num = (short)1136918529;
			if (num != 0)
			{
			}
			num = (short)89194496;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600CF3F RID: 53055 RVA: 0x00C0DDB4 File Offset: 0x00C0BFB4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)579993600;
			short num2 = num;
			num = (short)1384906753;
			if (num != 0)
			{
			}
			num = (short)718221518;
			short num3 = num;
			num = (short)338112718;
			switch (num3 == num)
			{
			}
			num = (short)1158873088;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x00C0DE64 File Offset: 0x00C0C064
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)421068801;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_31:
					int num2;
					switch (num2)
					{
					case 0:
						this.a.MoveCurrentToFirst();
						num = (short)541786114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.a.CurrentItem == null)
						{
							num = (short)1225719808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					case 2:
						goto IL_10E;
					}
					break;
				}
				IL_43:
				object myRecordsetDataSource = this.RecNavToolbarPageASTROTalkgroupList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num = (short)654648761;
				short num3 = num;
				num = (short)776152505;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1892089856;
					if (num != 0)
					{
					}
					num = (short)391643137;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			IL_10E:
			num = (short)218628096;
			short num4 = num;
			IL_13A:
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x0600CF41 RID: 53057 RVA: 0x00C0DFC4 File Offset: 0x00C0C1C4
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList A_0)
		{
			short num = (short)821370130;
			short num2 = num;
			num = (short)1815158034;
			switch (num2 == num)
			{
			}
			num = (short)732823552;
			short num3 = num;
			num = (short)926547969;
			if (num != 0)
			{
			}
			num = (short)2036989952;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600CF42 RID: 53058 RVA: 0x00C0E094 File Offset: 0x00C0C294
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num = (short)1625482367;
			short num2 = num;
			num = (short)18277503;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)519307264;
				if (num != 0)
				{
				}
				num = (short)285671425;
				if (num != 0)
				{
				}
				if (this.c)
				{
					return;
				}
				break;
			}
			num = (short)653131776;
			short num3 = num;
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdf臡诣该飧藩苫语黯蛱\udbf3闵韷铹諻鯽滿瘁洃椅昇欉怋⬍∏∑眓礕瘗簙甛礝唟倡䔣別䄧䔩䈫ĭ儯䄱䀳䐵圷Ἱ฻฽㐿⍁⡃ⵅ⽇㡉⍋㭍⁏睑晓晕㑗㍙⽛⩝佟͡ᝣብᩧթᡫ཭ᱯᥱ፳ѵ᝷ཹ౻ችꊋﾑ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x00C0E170 File Offset: 0x00C0C370
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1246494723;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1181745157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)427098118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1444216836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
					if (connectionId != 2)
					{
						num = (short)573898753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F;
				case 5:
					goto IL_97;
				case 6:
					if (connectionId != 7)
					{
						num = (short)697630720;
						short num3 = num;
						num = (short)1853292544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D2;
				}
				IL_42:
				if (connectionId == 1)
				{
					goto IL_142;
				}
				num = (short)1475805186;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5F:
			this.RecNavToolbarPageASTROTalkgroupList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageASTROTalkgroupList.ModeClick += this.OnModeClick;
			return;
			IL_97:
			goto IL_1E5;
			IL_D2:
			this.ASTROTalkgroupListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_142:
			num = (short)1164247041;
			if (num != 0)
			{
			}
			num = (short)628990934;
			short num4 = num;
			num = (short)224764886;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1E5:
				this.c = true;
				return;
			default:
				num = (short)1816395776;
				if (num != 0)
				{
				}
				((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.PageASTROTalkgroupListTbl)target).Loaded += this.OnLoaded;
				((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.PageASTROTalkgroupListTbl)target).Unloaded += this.OnUnloaded;
				return;
			}
		}

		// Token: 0x0600CF44 RID: 53060 RVA: 0x00C0E36C File Offset: 0x00C0C56C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
			{
				short num = (short)971440128;
				short num2 = num;
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
			{
				short num = (short)850955705;
				short num3 = num;
				num = (short)1161072057;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1613037568;
					if (num != 0)
					{
					}
					num = (short)352256001;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			}
		}

		// Token: 0x0400659F RID: 26015
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040065A0 RID: 26016
		private bool b;

		// Token: 0x040065A1 RID: 26017
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageASTROTalkgroupList;

		// Token: 0x040065A2 RID: 26018
		internal global::AcpUI.AcpXamDataPresenter ASTROTalkgroupListList;

		// Token: 0x040065A3 RID: 26019
		private bool c;
	}
}
