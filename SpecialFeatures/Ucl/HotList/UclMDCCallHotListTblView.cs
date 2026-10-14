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
	// Token: 0x020001DF RID: 479
	public class UclMDCCallHotListTblView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x001FB1F4 File Offset: 0x001F93F4
		public UclMDCCallHotListTblView()
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

		// Token: 0x06001731 RID: 5937 RVA: 0x001FB22C File Offset: 0x001F942C
		public override void SetDataContext()
		{
			short num = (short)2046099460;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)391118848;
					short num3 = num;
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2212);
					num = (short)1023672322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1633681413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				case 2:
					goto IL_100;
				case 3:
					goto IL_100;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_184;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1970208769;
					if (num != 0)
					{
					}
					num = (short)827180228;
					short num4 = num;
					num = (short)1884538052;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1848639488;
						if (num != 0)
						{
						}
						num = (short)1171062784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				else
				{
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2212);
				}
				num = (short)651886595;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_100:
				this.UclMDCHotList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageUclMDCHotList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageUclMDCHotList.MyDataPresenter = this.UclMDCHotList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageUclMDCHotList;
				num = (short)1302986753;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_184:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2212);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclMDCHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_206:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageUclMDCHotList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x001FB44C File Offset: 0x001F964C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!this.b)
						{
							num2 = (short)1541210112;
							short num3 = num2;
							num2 = (short)1456078849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)418120634;
						short num4 = num2;
						num2 = (short)1760887738;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							num2 = (short)408485889;
							if (num2 != 0)
							{
							}
							num2 = (short)859045888;
							if (num2 != 0)
							{
							}
							base.OnLoaded(sender, e);
							this.b = true;
							num2 = (short)765526018;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageUclMDCHotList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_39:
			num2 = (short)930283520;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x001FB590 File Offset: 0x001F9790
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.b)
						{
							num2 = (short)1007747072;
							short num3 = num2;
							num2 = (short)1527906305;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)1997916686;
						short num4 = num2;
						num2 = (short)73648654;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
							num2 = (short)2119434240;
							if (num2 != 0)
							{
							}
							base.OnUnloaded(sender, e);
							this.b = false;
							num2 = (short)735707138;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_109;
					}
					goto IL_1C;
				}
				IL_109:
				num2 = (short)813694977;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarPageUclMDCHotList.DataContext = null;
			this.RecNavToolbarPageUclMDCHotList.MyDataPresenter = null;
			IL_34:
			num2 = (short)129695744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x001FB6D0 File Offset: 0x001F98D0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2107207766;
			short num2 = num;
			num = (short)87191638;
			switch (num2 == num)
			{
			}
			num = (short)1499660288;
			short num3 = num;
			num = (short)657457152;
			if (num != 0)
			{
			}
			num = (short)408748033;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x001FB780 File Offset: 0x001F9980
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1288634368;
							short num3 = num2;
							num2 = (short)231079937;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_113;
					case 1:
					{
						num2 = (short)875056058;
						short num4 = num2;
						num2 = (short)964840378;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
							num2 = (short)509870080;
							if (num2 != 0)
							{
							}
							this.a.MoveCurrentToFirst();
							num2 = (short)1569718274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_111;
					}
					goto IL_1C;
				}
				IL_111:
				IL_113:
				num2 = (short)121765889;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.Ucl.HotList.UclMDCCallHotList a_ = (global::SpecialFeatures.Ucl.HotList.UclMDCCallHotList)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			}
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageUclMDCHotList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_3B:
			num2 = (short)412483584;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x001FB8E0 File Offset: 0x001F9AE0
		private void a(global::SpecialFeatures.Ucl.HotList.UclMDCCallHotList A_0)
		{
			short num = (short)1822464097;
			short num2 = num;
			num = (short)1196136545;
			switch (num2 == num)
			{
			}
			num = (short)350945280;
			short num3 = num;
			num = (short)439418880;
			if (num != 0)
			{
			}
			num = (short)1979645953;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x001FB9B4 File Offset: 0x001F9BB4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			short num;
			while (this.c)
			{
				num = (short)1704694344;
				short num2 = num;
				num = (short)2010878536;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1716453377;
					if (num != 0)
					{
					}
					num = (short)1783431168;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)983629824;
			short num3 = num;
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾ꃂ꓄ꯆꗈￌￎ뷐뫒ꛔꏖﳘ볞軠跢菤軦軨黪鿬軮藰髲髴駶훸鏺鋼课洀樂瘄猆☈縊渌挎簐眒瘔琖砘眚焜眞丠圢䤤並娨弪夬䴮崰䔲尴制丸ᔺ䔼帾ⱀ⽂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x001FBA98 File Offset: 0x001F9C98
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1967718400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1820000257;
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
					goto IL_84;
				case 2:
					goto IL_168;
				}
				IL_58:
				switch (connectionId)
				{
				case 1:
				{
					num = (short)319658777;
					short num3 = num;
					num = (short)1351654169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					case 1:
						goto IL_10A;
					}
					goto Block_2;
				}
				case 2:
					goto IL_89;
				case 3:
					goto IL_177;
				case 4:
					goto IL_16A;
				default:
					num = (short)1223884801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_84:
				num = (short)197525506;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_89:
			this.RecNavToolbarPageUclMDCHotList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageUclMDCHotList.ModeClick += this.OnModeClick;
			return;
			Block_2:
			num = (short)1960902656;
			short num4 = num;
			IL_10A:
			num = (short)1838219264;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListTblView)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListTblView)target).Unloaded += this.OnUnloaded;
			return;
			IL_168:
			goto IL_177;
			IL_16A:
			this.UclMDCHotList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_177:
			this.c = true;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x001FBC24 File Offset: 0x001F9E24
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1016594432;
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
				{
					IL_4A:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)2089549824;
					short num3 = num;
					num = (short)1424359426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_A7;
				}
				IL_31:
				if (connectionId == 3)
				{
					num = (short)1615724545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A7:
				num = (short)1027274668;
				short num4 = num;
				num = (short)956037036;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4A;
				default:
					goto IL_DB;
				}
			}
			IL_DB:
			num = (short)869269505;
			if (num != 0)
			{
			}
			num = (short)283312128;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000BF8 RID: 3064
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000BF9 RID: 3065
		private bool b;

		// Token: 0x04000BFA RID: 3066
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageUclMDCHotList;

		// Token: 0x04000BFB RID: 3067
		internal global::AcpUI.AcpXamDataPresenter UclMDCHotList;

		// Token: 0x04000BFC RID: 3068
		private bool c;
	}
}
