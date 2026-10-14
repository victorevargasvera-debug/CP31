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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047E RID: 1150
	public class PageTrunkingEmergencyProfilesTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060097D2 RID: 38866 RVA: 0x008E86F4 File Offset: 0x008E68F4
		public PageTrunkingEmergencyProfilesTbl()
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

		// Token: 0x060097D3 RID: 38867 RVA: 0x008E872C File Offset: 0x008E692C
		public override void SetDataContext()
		{
			short num = (short)142999552;
			short num2 = num;
			num = (short)1129185280;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_3D;
				case 1:
					num = (short)252903425;
					if (num != 0)
					{
					}
					goto IL_D7;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)2014838788;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_209;
				case 3:
					goto IL_D7;
				case 4:
					goto IL_15B;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2076);
					num = (short)795934721;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_65;
				IL_3D:
				switch (0)
				{
				case 0:
					IL_65:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1465686900;
						short num4 = num;
						num = (short)478387060;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
							num = (short)1225785344;
							if (num != 0)
							{
							}
							num = (short)2070347781;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2076);
						num = (short)243597315;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_D7:
				this.TrunkingEmergencyProfilesList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageTrunkingEmergencyProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageTrunkingEmergencyProfiles.MyDataPresenter = this.TrunkingEmergencyProfilesList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageTrunkingEmergencyProfiles;
				num = (short)176226306;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_15B:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2076);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingEmergencyProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_209:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingEmergencyProfiles).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x008E8950 File Offset: 0x008E6B50
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)916848640;
			short num2 = num;
			num = (short)1892024322;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageTrunkingEmergencyProfiles.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1829896192;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				num = (short)1925018168;
				short num4 = num;
				num = (short)1637642808;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1377697793;
					if (num != 0)
					{
					}
					num = (short)1663369216;
					if (num != 0)
					{
					}
					if (this.b)
					{
						return;
					}
					num = (short)1172832257;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x008E8A90 File Offset: 0x008E6C90
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1558708224;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			int num3;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					base.OnUnloaded(sender, e);
					this.b = false;
					num = (short)2118844416;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)539986925;
					short num4 = num;
					num = (short)131828717;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1088094208;
						if (num != 0)
						{
						}
						if (this.b)
						{
							num = (short)1547567105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_46;
			}
			return;
			IL_46:
			num = (short)124452865;
			if (num != 0)
			{
			}
			this.RecNavToolbarPageTrunkingEmergencyProfiles.DataContext = null;
			this.RecNavToolbarPageTrunkingEmergencyProfiles.MyDataPresenter = null;
			num = (short)1856897026;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x008E8BC8 File Offset: 0x008E6DC8
		internal void OnTrunkingEmergencyProfilesFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1830682625;
			if (num != 0)
			{
			}
			num = (short)1722594109;
			short num2 = num;
			num = (short)557101885;
			switch (num2 == num)
			{
			}
			num = (short)1011482624;
			if (num != 0)
			{
			}
			num = (short)684130304;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x008E8CA0 File Offset: 0x008E6EA0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)562102273;
			if (num != 0)
			{
			}
			num = (short)699805868;
			short num2 = num;
			num = (short)959787180;
			switch (num2 == num)
			{
			}
			num = (short)1687617536;
			short num3 = num;
			num = (short)504758272;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x008E8D50 File Offset: 0x008E6F50
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
					goto IL_E3;
				case 1:
				{
					num2 = (short)1633843784;
					short num3 = num2;
					num2 = (short)1978235464;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num2 = (short)1939275776;
						if (num2 != 0)
						{
						}
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1588789250;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10B;
					}
					break;
				}
				case 2:
					goto IL_BE;
				}
				goto IL_1C;
				IL_BE:
				this.a.MoveCurrentToFirst();
				num2 = (short)785448960;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E3:
			num2 = (short)107544577;
			if (num2 != 0)
			{
			}
			IL_10B:
			num2 = (short)603193344;
			short num4 = num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageTrunkingEmergencyProfiles.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)612433921;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x008E8EAC File Offset: 0x008E70AC
		private void a(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles A_0)
		{
			short num = (short)1855473926;
			short num2 = num;
			num = (short)1242974470;
			switch (num2 == num)
			{
			}
			num = (short)759103489;
			if (num != 0)
			{
			}
			num = (short)1801584640;
			short num3 = num;
			num = (short)1281687552;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x008E8F7C File Offset: 0x008E717C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			while (!this.c)
			{
				short num = (short)929778111;
				short num2 = num;
				num = (short)1965246911;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1690304512;
					if (num != 0)
					{
					}
					num = (short)195362816;
					short num3 = num;
					num = (short)1553596417;
					if (num != 0)
					{
					}
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸黺郼髾猀搂怄椆樈爊⠌㴎ℐ瀒稔礖缘爚稜樞匠䈢儤並䘨䔪Ȭ嬮䌰䘲嬴尶倸唺娼ᨾ獀獂⁄⩆ⱈ㥊⩌⩎㽐げⱔ牖歘歚ⵜⵞ๠բ౤୦౨ᡪ䉬᭮Ͱٲ᭴ᱶၸᕺ᩼᩾杖햠솢즤覦톨쪪사쎮", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x008E905C File Offset: 0x008E725C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)24182788;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (connectionId != 23)
						{
							num = (short)927989762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D1;
					case 1:
						num = (short)181075974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)270336005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)461045760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 5:
						goto IL_97;
					case 6:
						if (connectionId != 2)
						{
							num = (short)1510211587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F;
					}
					IL_41:
					if (connectionId == 1)
					{
						break;
					}
					num = (short)183894017;
					num2 = (int)((global::System.IntPtr)num);
				}
				num = (short)1295450112;
				short num3 = num;
				num = (short)635054415;
				short num4 = num;
				num = (short)1260792143;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_173;
				}
			}
			IL_5F:
			this.RecNavToolbarPageTrunkingEmergencyProfiles = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingEmergencyProfiles.ModeClick += this.OnModeClick;
			return;
			IL_97:
			this.c = true;
			return;
			IL_D1:
			this.TrunkingEmergencyProfilesList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_173:
			num = (short)201326593;
			if (num != 0)
			{
			}
			num = (short)1124401152;
			if (num != 0)
			{
			}
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.PageTrunkingEmergencyProfilesTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.PageTrunkingEmergencyProfilesTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x008E9250 File Offset: 0x008E7450
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1228781058;
			short num2 = num;
			num = (short)889566722;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)371195904;
				if (num != 0)
				{
				}
				num = (short)1760493569;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 3:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 4:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 5:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 6:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 7:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 8:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 9:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 10:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 11:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 12:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 13:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 14:
				{
					num = (short)1629028352;
					short num3 = num;
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				case 15:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 16:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 17:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 18:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 19:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 20:
					break;
				case 21:
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 22:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				default:
					return;
				}
				break;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004B09 RID: 19209
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04004B0A RID: 19210
		private bool b;

		// Token: 0x04004B0B RID: 19211
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageTrunkingEmergencyProfiles;

		// Token: 0x04004B0C RID: 19212
		internal global::AcpUI.AcpXamDataPresenter TrunkingEmergencyProfilesList;

		// Token: 0x04004B0D RID: 19213
		private bool c;
	}
}
