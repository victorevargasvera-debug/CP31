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

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001BA RID: 442
	public class PageVirtualPartnerAlertTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060051BB RID: 20923 RVA: 0x004A4F90 File Offset: 0x004A3190
		public PageVirtualPartnerAlertTbl()
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

		// Token: 0x060051BC RID: 20924 RVA: 0x004A4FC8 File Offset: 0x004A31C8
		public override void SetDataContext()
		{
			short num = (short)95669916;
			short num2 = num;
			num = (short)295554716;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_15C:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVirtualPartnerAlert).MySecondaryRecordsetDataSource = null;
					return;
				}
				num = (short)1328021506;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)649592833;
				if (num != 0)
				{
				}
				num = (short)244187136;
				short num4 = num;
				num = (short)1606287360;
				if (num != 0)
				{
				}
				num = (short)818479109;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_FC;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4231);
					num = (short)1421082624;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_17E;
				case 3:
					goto IL_15C;
				case 4:
					goto IL_FC;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_D8;
					}
					continue;
				}
				IL_D8:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)929628161;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4231);
				num = (short)941621252;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_FC:
				this.VirtualPartnerAlertList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageVirtualPartnerAlert.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageVirtualPartnerAlert.MyDataPresenter = this.VirtualPartnerAlertList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageVirtualPartnerAlert;
				num = (short)2089222147;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_17E:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4231);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVirtualPartnerAlert).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x004A51E4 File Offset: 0x004A33E4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1280114690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E4;
				case 1:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageVirtualPartnerAlert.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)2084700160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)565051392;
				short num3 = num;
				if (!this.b)
				{
					num = (short)410517505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E4:
				num = (short)31001965;
				short num4 = num;
				num = (short)1369312621;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_31;
				default:
					goto IL_11B;
				}
			}
			IL_11B:
			num = (short)880345088;
			if (num != 0)
			{
			}
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x004A5324 File Offset: 0x004A3524
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
					goto IL_109;
				case 1:
				{
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)903479296;
					short num3 = num2;
					num2 = (short)1953955840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (this.b)
					{
						num2 = (short)724434945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_109:
			num2 = (short)405995521;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1973880436;
			short num4 = num2;
			num2 = (short)584844916;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)156368896;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarPageVirtualPartnerAlert.DataContext = null;
				this.RecNavToolbarPageVirtualPartnerAlert.MyDataPresenter = null;
				num2 = (short)1962147842;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x004A5464 File Offset: 0x004A3664
		internal void OnVirtualPartnerAlertFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)724697089;
			if (num != 0)
			{
			}
			num = (short)1440092162;
			short num2 = num;
			num = (short)2125205506;
			switch (num2 == num)
			{
			}
			num = (short)428605440;
			if (num != 0)
			{
			}
			num = (short)511508480;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert a_ = (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x004A5538 File Offset: 0x004A3738
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1236540200;
			short num2 = num;
			num = (short)1336875816;
			switch (num2 == num)
			{
			}
			num = (short)2095710209;
			if (num != 0)
			{
			}
			num = (short)633208832;
			if (num != 0)
			{
			}
			num = (short)423034880;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x004A55E8 File Offset: 0x004A37E8
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
					goto IL_13A;
				case 1:
				{
					num2 = (short)572719104;
					short num3 = num2;
					this.a.MoveCurrentToFirst();
					num2 = (short)1340473344;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)375521281;
					if (num2 != 0)
					{
					}
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1361182721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				}
				goto IL_1C;
			}
			IL_13A:
			goto IL_13C;
			IL_1C:
			num2 = (short)1220217696;
			short num4 = num2;
			num2 = (short)53218144;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13C:
				global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert a_ = (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			default:
			{
				num2 = (short)776208384;
				if (num2 != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageVirtualPartnerAlert.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)668467202;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x004A574C File Offset: 0x004A394C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert A_0)
		{
			short num = (short)1668101841;
			short num2 = num;
			num = (short)1778398929;
			switch (num2 == num)
			{
			}
			num = (short)138149889;
			if (num != 0)
			{
			}
			num = (short)1019543552;
			if (num != 0)
			{
			}
			num = (short)1854210048;
			short num3 = num;
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x004A5818 File Offset: 0x004A3A18
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num;
			if (!this.c)
			{
				num = (short)1491610957;
				short num2 = num;
				num = (short)119614797;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)920846337;
					if (num != 0)
					{
					}
					num = (short)1503985664;
					if (num != 0)
					{
					}
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸觺鳼鯾栀氂\u2004㔆㤈渊缌栎縐紒稔稖瀘砚渜㨞ጠጢ䘤䠦䜨䴪䐬䠮䐰䄲吴䌶倸吺匼ှ㝀⩂㝄㍆㱈⩊⅌橎捐捒╔㙖⭘⽚㍜㩞፠䙢坤坦ࡨݪ࡬ᵮհ屲ʹṶ୸ེࡼṾﶈﶎﾒﾜ辠\udba2쒤쪦얨", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1395130368;
			short num3 = num;
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x004A58F8 File Offset: 0x004A3AF8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1244266496;
			short num2 = num;
			num = (short)1936195586;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_12A;
				case 1:
					goto IL_104;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				num = (short)1987641345;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_D3;
				case 2:
					goto IL_AF;
				case 3:
				{
					IL_12A:
					num = (short)1780696419;
					short num4 = num;
					num = (short)914179427;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_15F;
					}
					break;
				}
				case 4:
					goto IL_11D;
				default:
					num = (short)135659521;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_104:
				num = (short)1352794112;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_AF:
			this.RecNavToolbarPageVirtualPartnerAlert = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageVirtualPartnerAlert.ModeClick += this.OnModeClick;
			return;
			IL_D3:
			((global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.PageVirtualPartnerAlertTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.PageVirtualPartnerAlertTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_11D:
			this.VirtualPartnerAlertList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_15F:
			num = (short)1872953344;
			if (num != 0)
			{
			}
			this.c = true;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x004A5A80 File Offset: 0x004A3C80
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1428619266;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)763035648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if (connectionId == 3)
				{
					num = (short)14221312;
					short num3 = num;
					num = (short)2065694721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A2:
				num = (short)2025023733;
				short num4 = num;
				num = (short)2127194357;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				default:
					goto IL_D8;
				}
			}
			IL_D8:
			num = (short)957874177;
			if (num != 0)
			{
			}
			num = (short)2076966912;
			if (num != 0)
			{
			}
		}

		// Token: 0x04001F1A RID: 7962
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04001F1B RID: 7963
		private bool b;

		// Token: 0x04001F1C RID: 7964
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageVirtualPartnerAlert;

		// Token: 0x04001F1D RID: 7965
		internal global::AcpUI.AcpXamDataPresenter VirtualPartnerAlertList;

		// Token: 0x04001F1E RID: 7966
		private bool c;
	}
}
