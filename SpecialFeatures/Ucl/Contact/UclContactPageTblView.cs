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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200021A RID: 538
	public class UclContactPageTblView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x002395D8 File Offset: 0x002377D8
		public UclContactPageTblView()
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

		// Token: 0x06001B86 RID: 7046 RVA: 0x00239610 File Offset: 0x00237810
		public override void SetDataContext()
		{
			short num = (short)2062942213;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num = (short)1440592865;
					short num3 = num;
					num = (short)1980937185;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E0;
					case 1:
						break;
					default:
					{
						num = (short)126746624;
						short num4 = num;
						break;
					}
					}
					num = (short)1555693568;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200);
					num = (short)1816199168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_FD;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1954349060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_202;
				case 4:
					goto IL_180;
				case 5:
					num = (short)459866113;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				}
				IL_64:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)859242497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2200);
				num = (short)743309314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FD:
				this.UclContactList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageUclContact.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageUclContact.MyDataPresenter = this.UclContactList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageUclContact;
				num = (short)621871107;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_180:
			IL_1E0:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclContact).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_202:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclContact).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0023982C File Offset: 0x00237A2C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1431633922;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1883308032;
				short num3 = num;
				num = (short)1798145561;
				short num4 = num;
				num = (short)304973337;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1419313153;
					if (num != 0)
					{
					}
					num = (short)1025966080;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						base.OnLoaded(sender, e);
						object myRecordsetDataSource = this.RecNavToolbarPageUclContact.MyRecordsetDataSource;
						this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						this.b = true;
						num = (short)2136539136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_14;
					}
					goto IL_CE;
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_CE:
					if (this.b)
					{
						return;
					}
					num = (short)247595009;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00239970 File Offset: 0x00237B70
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
					return;
				case 1:
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)928186368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.b)
					{
						num2 = (short)1887502337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1043267585;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarPageUclContact.DataContext = null;
			this.RecNavToolbarPageUclContact.MyDataPresenter = null;
			num2 = (short)197328896;
			short num3 = num2;
			num2 = (short)278339475;
			short num4 = num2;
			num2 = (short)1535057811;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)105316352;
				if (num2 != 0)
				{
				}
				num2 = (short)1181417474;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00239AB0 File Offset: 0x00237CB0
		internal void OnUclContactFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1977197911;
			short num2 = num;
			num = (short)793683287;
			switch (num2 == num)
			{
			}
			num = (short)2135162881;
			if (num != 0)
			{
			}
			num = (short)1741488128;
			if (num != 0)
			{
			}
			num = (short)1330577408;
			short num3 = num;
			global::SpecialFeatures.Ucl.Contact.UclContact a_ = (global::SpecialFeatures.Ucl.Contact.UclContact)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00239B88 File Offset: 0x00237D88
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1477960069;
			short num2 = num;
			num = (short)1727979909;
			switch (num2 == num)
			{
			}
			num = (short)1219821569;
			if (num != 0)
			{
			}
			num = (short)581828608;
			if (num != 0)
			{
			}
			num = (short)728498176;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00239C38 File Offset: 0x00237E38
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)823787521;
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
					goto IL_138;
				case 1:
					this.a.MoveCurrentToFirst();
					num = (short)1113391104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.a.CurrentItem == null)
					{
						num = (short)1499463681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				}
				goto IL_43;
			}
			IL_138:
			IL_13A:
			global::SpecialFeatures.Ucl.Contact.UclContact a_ = (global::SpecialFeatures.Ucl.Contact.UclContact)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_43:
			object myRecordsetDataSource = this.RecNavToolbarPageUclContact.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)550633472;
			short num3 = num;
			num = (short)2114761127;
			short num4 = num;
			num = (short)949399975;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_31;
			default:
			{
				num = (short)184811520;
				if (num != 0)
				{
				}
				num = (short)535560194;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00239D98 File Offset: 0x00237F98
		private void a(global::SpecialFeatures.Ucl.Contact.UclContact A_0)
		{
			short num = (short)2100035646;
			short num2 = num;
			num = (short)1099366462;
			switch (num2 == num)
			{
			}
			num = (short)969146369;
			if (num != 0)
			{
			}
			num = (short)371326976;
			if (num != 0)
			{
			}
			num = (short)123928576;
			short num3 = num;
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00239E64 File Offset: 0x00238064
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num;
			if (!this.c)
			{
				num = (short)2023380048;
				short num2 = num;
				num = (short)1309103184;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1341980673;
					if (num != 0)
					{
					}
					num = (short)139067392;
					if (num != 0)
					{
					}
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몔쒖ﺚﺜ삠쾢슦좨\udfaa\ud8ac\uddae풰삲躴풶횸횺춼킾꿀ꛂꯄ돆꣊곌ꏎ뷐뗘닚껜ꯞ쓠퇢헤蓦蛨藪诬蛮雰蛲蟴零跸鋺鋼釾⸀怂樄椆紈樊渌笎㸐昒瘔笖稘琚猜欞䀠䀢儤圦䠨䰪䠬嬮匰弲䌴帶尸䰺ጼ䜾⁀⹂⥄", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)2064056320;
			short num3 = num;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00239F44 File Offset: 0x00238144
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1470955522;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F9;
				case 1:
					num = (short)132448256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)78970880;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_B1;
				case 2:
					goto IL_8D;
				case 3:
				case 4:
					goto IL_108;
				case 5:
					goto IL_FB;
				default:
					num = (short)1687486465;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8D:
			this.RecNavToolbarPageUclContact = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageUclContact.ModeClick += this.OnModeClick;
			return;
			IL_B1:
			((global::SpecialFeatures.Ucl.Contact.UclContactPageTblView)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.Contact.UclContactPageTblView)target).Unloaded += this.OnUnloaded;
			return;
			IL_F9:
			goto IL_108;
			IL_FB:
			this.UclContactList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_108:
			num = (short)1640896952;
			short num4 = num;
			num = (short)1325210040;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8D;
			default:
				num = (short)1395654656;
				if (num != 0)
				{
				}
				num = (short)2131951617;
				if (num != 0)
				{
				}
				this.c = true;
				return;
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0023A0D4 File Offset: 0x002382D4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)2056716291;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1546780672;
				short num3 = num;
				num = (short)2054666730;
				short num4 = num;
				num = (short)2001648106;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1621229569;
					if (num != 0)
					{
					}
					num = (short)1851326464;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1836580866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (connectionId != 4)
						{
							goto IL_121;
						}
						goto IL_13B;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					}
					IL_CE:
					if (connectionId != 3)
					{
						num = (short)1887174657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				}
				IL_121:
				num = (short)2074542080;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			((global::AcpUI.AcpFlyInButton)target).Click += this.OnUclContactFlyInClick;
			return;
			IL_13B:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000DA3 RID: 3491
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000DA4 RID: 3492
		private bool b;

		// Token: 0x04000DA5 RID: 3493
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageUclContact;

		// Token: 0x04000DA6 RID: 3494
		internal global::AcpUI.AcpXamDataPresenter UclContactList;

		// Token: 0x04000DA7 RID: 3495
		private bool c;
	}
}
