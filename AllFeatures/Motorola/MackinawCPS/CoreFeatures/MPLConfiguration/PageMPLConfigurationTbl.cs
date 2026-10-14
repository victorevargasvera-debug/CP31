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

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x0200053A RID: 1338
	public class PageMPLConfigurationTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B213 RID: 45587 RVA: 0x00A5661C File Offset: 0x00A5481C
		public PageMPLConfigurationTbl()
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

		// Token: 0x0600B214 RID: 45588 RVA: 0x00A56654 File Offset: 0x00A54854
		public override void SetDataContext()
		{
			short num = (short)218628098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)227672065;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2078);
					num = (short)1213595652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_17F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_87;
				case 4:
					goto IL_87;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)102825984;
						short num3 = num;
						num = (short)1138753537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				}
				goto IL_3C;
				IL_47:
				num = (short)1557790720;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_87:
				num = (short)1117850193;
				short num4 = num;
				num = (short)1878002257;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_47;
				default:
					num = (short)1079443456;
					if (num != 0)
					{
					}
					this.MPLConfigurationList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageMPLConfiguration.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageMPLConfiguration.MyDataPresenter = this.MPLConfigurationList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageMPLConfiguration;
					num = (short)490143749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					goto IL_47;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2078);
				num = (short)816381955;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_17F:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2078);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMPLConfiguration).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_204:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMPLConfiguration).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x00A56874 File Offset: 0x00A54A74
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)919928832;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)737083392;
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
					goto IL_EE;
				}
				IL_59:
				num = (short)1136230271;
				short num4 = num;
				num = (short)1508343679;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_EE:
					object myRecordsetDataSource = this.RecNavToolbarPageMPLConfiguration.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1096941569;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)78839809;
					if (num != 0)
					{
					}
					num = (short)323026944;
					if (num != 0)
					{
					}
					if (this.b)
					{
						return;
					}
					num = (short)746913794;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600B216 RID: 45590 RVA: 0x00A569B4 File Offset: 0x00A54BB4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)792264704;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_9E;
				case 1:
					return;
				case 2:
				{
					num = (short)847822315;
					short num4 = num;
					num = (short)1721679339;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9E;
					default:
						num = (short)1768161280;
						if (num != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.b = false;
						num = (short)80871425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_47;
				IL_9E:
				if (!this.b)
				{
					break;
				}
				num = (short)1191444482;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_47:
			num = (short)472645633;
			if (num != 0)
			{
			}
			this.RecNavToolbarPageMPLConfiguration.DataContext = null;
			this.RecNavToolbarPageMPLConfiguration.MyDataPresenter = null;
			num = (short)384106496;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x00A56AF8 File Offset: 0x00A54CF8
		internal void OnMPLConfigurationFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1698403520;
			short num2 = num;
			num = (short)416650432;
			switch (num2 == num)
			{
			}
			num = (short)448397313;
			if (num != 0)
			{
			}
			num = (short)536805376;
			short num3 = num;
			num = (short)610729984;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration a_ = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x00A56BD0 File Offset: 0x00A54DD0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)912553024;
			short num2 = num;
			num = (short)2025157696;
			switch (num2 == num)
			{
			}
			num = (short)1387331584;
			if (num != 0)
			{
			}
			num = (short)117178368;
			short num3 = num;
			num = (short)498139137;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x00A56C80 File Offset: 0x00A54E80
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)14286848;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_7B;
				case 1:
					goto IL_13B;
				case 2:
				{
					num = (short)1224622599;
					short num4 = num;
					num = (short)837370375;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						num = (short)28377088;
						if (num != 0)
						{
						}
						this.a.MoveCurrentToFirst();
						num = (short)609026049;
						if (num != 0)
						{
						}
						num = (short)451215361;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_48;
				IL_7B:
				if (this.a.CurrentItem != null)
				{
					break;
				}
				num = (short)724172802;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_13B:
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration a_ = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_48:
			object myRecordsetDataSource = this.RecNavToolbarPageMPLConfiguration.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)1268711424;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x00A56DE4 File Offset: 0x00A54FE4
		private void a(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration A_0)
		{
			short num = (short)374248947;
			short num2 = num;
			num = (short)1837340147;
			switch (num2 == num)
			{
			}
			num = (short)1260191744;
			if (num != 0)
			{
			}
			num = (short)396427264;
			short num3 = num;
			num = (short)314834945;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x00A56EB4 File Offset: 0x00A550B4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num = (short)280388127;
			short num2 = num;
			num = (short)1882415647;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1186267136;
				if (num != 0)
				{
				}
				if (!this.c)
				{
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛菟跡解雥蟧蓩觫胭蓯\uddf1音駵雷賹駻都瓿欁欃栅椇昉⤋㰍‏焑笓砕縗猙笛欝刟䌡倣伥䜧䐩̫䌭䀯帱ᄳе࠷夹医倽☿⭁⍃㍅㩇⭉㡋❍㽏㱑筓㭕⡗㙙㽛ㅝ๟ѡൣťᵧᡩ൫ᩭ᥯ᵱᩳɵ᩷ᙹ剻ٽ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)1207304193;
				if (num != 0)
				{
				}
				num = (short)1997209600;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x00A56F94 File Offset: 0x00A55194
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2065760256;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_149;
				case 2:
					num = (short)2026438657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				num = (short)1357840385;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
				{
					num = (short)1435494196;
					short num3 = num;
					num = (short)2014897972;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_EB;
					}
					break;
				}
				case 2:
					goto IL_90;
				case 3:
				case 4:
					goto IL_181;
				case 5:
					goto IL_174;
				}
				num = (short)1676804098;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_90:
			this.RecNavToolbarPageMPLConfiguration = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageMPLConfiguration.ModeClick += this.OnModeClick;
			return;
			IL_EB:
			num = (short)1562116096;
			if (num != 0)
			{
			}
			((global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.PageMPLConfigurationTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.PageMPLConfigurationTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_149:
			num = (short)2090532864;
			short num4 = num;
			goto IL_181;
			IL_174:
			this.MPLConfigurationList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_181:
			this.c = true;
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x00A5712C File Offset: 0x00A5532C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1870528512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					if (connectionId != 4)
					{
						num = (short)488964098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				case 2:
					return;
				case 3:
				{
					num = (short)432576210;
					short num3 = num;
					num = (short)1272813266;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1310064641;
						if (num != 0)
						{
						}
						num = (short)828178432;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)271581185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_34:
				num = (short)155320320;
				short num4 = num;
				if (connectionId == 3)
				{
					break;
				}
				num = (short)2005073923;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13A:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400578D RID: 22413
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x0400578E RID: 22414
		private bool b;

		// Token: 0x0400578F RID: 22415
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageMPLConfiguration;

		// Token: 0x04005790 RID: 22416
		internal global::AcpUI.AcpXamDataPresenter MPLConfigurationList;

		// Token: 0x04005791 RID: 22417
		private bool c;
	}
}
