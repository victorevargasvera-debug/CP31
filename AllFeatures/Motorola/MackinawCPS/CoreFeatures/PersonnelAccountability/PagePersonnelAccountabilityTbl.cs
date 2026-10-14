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

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x0200024D RID: 589
	public class PagePersonnelAccountabilityTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060068B2 RID: 26802 RVA: 0x005DB4CC File Offset: 0x005D96CC
		public PagePersonnelAccountabilityTbl()
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

		// Token: 0x060068B3 RID: 26803 RVA: 0x005DB504 File Offset: 0x005D9704
		public override void SetDataContext()
		{
			short num = (short)1232182060;
			short num2 = num;
			num = (short)218798892;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5F:
				switch (0)
				{
				case 0:
					goto IL_B1;
				}
				break;
			default:
				num = (short)1880162304;
				if (num != 0)
				{
				}
				num = (short)1071644674;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_69:
				num = (short)1903296512;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_D6;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4176);
					num = (short)1647443968;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_5F;
				case 3:
					num = (short)304218113;
					if (num != 0)
					{
					}
					goto IL_D6;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)2116943877;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				case 5:
					goto IL_15A;
				}
				goto IL_B1;
				IL_D6:
				this.PersonnelAccountabilityList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPagePersonnelAccountability.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPagePersonnelAccountability.MyDataPresenter = this.PersonnelAccountabilityList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPagePersonnelAccountability;
				num = (short)721944580;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_15A:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4176);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPagePersonnelAccountability).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_206:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPagePersonnelAccountability).MySecondaryRecordsetDataSource = null;
			return;
			IL_B1:
			if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
			{
				num = (short)922550273;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_69;
			}
			base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4176);
			num = (short)457441283;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_69;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x005DB724 File Offset: 0x005D9924
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1718026240;
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
					goto IL_10B;
				case 2:
				{
					num = (short)963248129;
					if (num != 0)
					{
					}
					object myRecordsetDataSource = this.RecNavToolbarPagePersonnelAccountability.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1627743223;
					short num3 = num;
					num = (short)1563255799;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C;
					default:
						num = (short)1587150848;
						if (num != 0)
						{
						}
						num = (short)938737665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_31;
				IL_3C:
				num = (short)951582722;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31:
				if (!this.b)
				{
					goto IL_3C;
				}
				return;
			}
			IL_10B:
			num = (short)777650176;
			short num4 = num;
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x005DB868 File Offset: 0x005D9A68
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
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
					{
						num2 = (short)1433337856;
						short num3 = num2;
						if (this.b)
						{
							num2 = (short)745275394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)366084097;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)382035486;
						short num4 = num2;
						num2 = (short)461989406;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)40370176;
							if (num2 != 0)
							{
							}
							num2 = (short)2076311553;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarPagePersonnelAccountability.DataContext = null;
				this.RecNavToolbarPagePersonnelAccountability.MyDataPresenter = null;
				num2 = (short)1126498304;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x005DB9A8 File Offset: 0x005D9BA8
		internal void OnPersonnelAccountabilityFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)852089581;
			short num2 = num;
			num = (short)1416682221;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1731657728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1463615488;
			if (num != 0)
			{
			}
			num = (short)763166721;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability a_ = (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x005DBA80 File Offset: 0x005D9C80
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1392508928;
			short num2 = num;
			num = (short)724238337;
			if (num != 0)
			{
			}
			num = (short)594327395;
			short num3 = num;
			num = (short)2115549027;
			switch (num3 == num)
			{
			}
			num = (short)940441600;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x005DBB30 File Offset: 0x005D9D30
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)1776222209;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					this.a.MoveCurrentToFirst();
					goto IL_11D;
				case 1:
				{
					num = (short)1665852569;
					short num3 = num;
					num = (short)1871897753;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
					{
						num = (short)482803712;
						if (num != 0)
						{
						}
						num = (short)1178206208;
						short num4 = num;
						if (this.a.CurrentItem == null)
						{
							num = (short)581042176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					}
					}
					break;
				}
				case 2:
					goto IL_134;
				}
				goto IL_43;
				IL_11D:
				num = (short)2092498946;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_134:
			IL_136:
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability a_ = (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_43:
			object myRecordsetDataSource = this.RecNavToolbarPagePersonnelAccountability.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)60555265;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x005DBC8C File Offset: 0x005D9E8C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability A_0)
		{
			short num = (short)303628288;
			short num2 = num;
			num = (short)489591366;
			short num3 = num;
			num = (short)1648857670;
			switch (num3 == num)
			{
			}
			num = (short)1646395392;
			if (num != 0)
			{
			}
			num = (short)1320288257;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x005DBD5C File Offset: 0x005D9F5C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this.c)
			{
				short num;
				for (;;)
				{
					num = (short)221577216;
					short num2 = num;
					num = (short)1551612915;
					short num3 = num;
					num = (short)1772731379;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)1728315392;
				if (num != 0)
				{
				}
				num = (short)848494593;
				if (num != 0)
				{
				}
				return;
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5诧藩臫黭鿯鳱釳飵賷헹軻鿽擿欁欃⌅㨇㨉椋簍眏紑稓礕甗猙缛洝ԟအᐣ䔥䜧䐩䨫䜭圯䜱䘳圵䰷匹医倽漿㉁⅃㑅㭇╉≋⁍㕏㹑煓摕桗㭙㽛㵝ཟᝡ੣ብ१ࡩիɭ᥯ٱ൳奵ࡷό๻ൽﾏ望聯즟횡\udda3튥쪧용芫횭톯\udfb1\ud8b3", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x005DBE40 File Offset: 0x005DA040
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1052573697;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)129105920;
						short num3 = num;
						num = (short)1207107586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)673906689;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						goto IL_11D;
					}
					IL_5A:
					switch (connectionId)
					{
					case 1:
						goto IL_AC;
					case 2:
						goto IL_88;
					case 3:
						goto IL_176;
					case 4:
						goto IL_11F;
					default:
						num = (short)632619008;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11F:
				num = (short)952546568;
				short num4 = num;
				num = (short)768259336;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_154;
				}
			}
			IL_88:
			this.RecNavToolbarPagePersonnelAccountability = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPagePersonnelAccountability.ModeClick += this.OnModeClick;
			return;
			IL_AC:
			((global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PagePersonnelAccountabilityTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PagePersonnelAccountabilityTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_11D:
			goto IL_176;
			IL_154:
			num = (short)1746403328;
			if (num != 0)
			{
			}
			this.PersonnelAccountabilityList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_176:
			this.c = true;
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x005DBFCC File Offset: 0x005DA1CC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)524222465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					goto IL_FC;
				case 1:
				{
					num = (short)154855278;
					short num3 = num;
					num = (short)1166534510;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						num = (short)1223098368;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_7C:
				num = (short)1202257921;
				if (num != 0)
				{
				}
				num = (short)1067778048;
				short num4 = num;
				if (connectionId == 3)
				{
					num = (short)1172897792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FC:
				num = (short)1227685890;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04002937 RID: 10551
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04002938 RID: 10552
		private bool b;

		// Token: 0x04002939 RID: 10553
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPagePersonnelAccountability;

		// Token: 0x0400293A RID: 10554
		internal global::AcpUI.AcpXamDataPresenter PersonnelAccountabilityList;

		// Token: 0x0400293B RID: 10555
		private bool c;
	}
}
