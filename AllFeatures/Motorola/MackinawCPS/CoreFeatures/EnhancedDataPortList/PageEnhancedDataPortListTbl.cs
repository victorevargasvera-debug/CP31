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

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004BE RID: 1214
	public class PageEnhancedDataPortListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06009FD9 RID: 40921 RVA: 0x0095205C File Offset: 0x0095025C
		public PageEnhancedDataPortListTbl()
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

		// Token: 0x06009FDA RID: 40922 RVA: 0x00952094 File Offset: 0x00950294
		public override void SetDataContext()
		{
			short num = (short)1126039552;
			short num2 = num;
			num = (short)205258755;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_15B;
				case 1:
					goto IL_8C;
				case 2:
					goto IL_8C;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				case 4:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4148);
					num = (short)73400322;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_207;
					}
					num = (short)771044039;
					short num4 = num;
					num = (short)686109383;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15B;
					default:
						num = (short)1446051840;
						if (num != 0)
						{
						}
						num = (short)2143158272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_67:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)261029892;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2022834177;
				if (num != 0)
				{
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4148);
				num = (short)380764161;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C:
				this.EnhancedDataPortListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageEnhancedDataPortList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageEnhancedDataPortList.MyDataPresenter = this.EnhancedDataPortListList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageEnhancedDataPortList;
				num = (short)394592261;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_15B:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4148);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageEnhancedDataPortList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_207:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageEnhancedDataPortList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x009522B4 File Offset: 0x009504B4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)721551361;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)1711013889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
				{
					num = (short)1833435136;
					short num3 = num;
					object myRecordsetDataSource = this.RecNavToolbarPageEnhancedDataPortList.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)1749656719;
					short num4 = num;
					num = (short)1641784463;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)171769856;
						if (num != 0)
						{
						}
						num = (short)355991552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_57:
				if (this.b)
				{
					break;
				}
				num = (short)36700162;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x009523F8 File Offset: 0x009505F8
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
				{
					num2 = (short)1034771478;
					short num3 = num2;
					num2 = (short)256531478;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						goto IL_EF;
					}
					break;
				}
				case 1:
					if (this.b)
					{
						goto IL_53;
					}
					return;
				case 2:
				{
					num2 = (short)1592000512;
					short num4 = num2;
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)516292608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_53:
				num2 = (short)1269825538;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EF:
			num2 = (short)190906368;
			if (num2 != 0)
			{
			}
			num2 = (short)854130689;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarPageEnhancedDataPortList.DataContext = null;
			this.RecNavToolbarPageEnhancedDataPortList.MyDataPresenter = null;
			num2 = (short)931790849;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x00952534 File Offset: 0x00950734
		internal void OnEnhancedDataPortListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2104745185;
			short num2 = num;
			num = (short)1858919649;
			switch (num2 == num)
			{
			}
			num = (short)323682304;
			short num3 = num;
			num = (short)1871511553;
			if (num != 0)
			{
			}
			num = (short)1657929728;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList a_ = (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x0095260C File Offset: 0x0095080C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1066729473;
			if (num != 0)
			{
			}
			num = (short)1126249268;
			short num2 = num;
			num = (short)1264726836;
			switch (num2 == num)
			{
			default:
			{
				num = (short)719650816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)986906624;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x009526BC File Offset: 0x009508BC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)802226177;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num2;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
				{
					num = (short)752811316;
					short num3 = num;
					num = (short)1769995572;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						goto IL_11F;
					}
					break;
				}
				case 1:
					if (this.a.CurrentItem == null)
					{
						goto IL_88;
					}
					goto IL_137;
				case 2:
				{
					num = (short)1010237440;
					short num4 = num;
					this.a.MoveCurrentToFirst();
					num = (short)2095185920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num = (short)162791426;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			num = (short)461701120;
			if (num != 0)
			{
			}
			IL_137:
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList a_ = (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_44:
			object myRecordsetDataSource = this.RecNavToolbarPageEnhancedDataPortList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)996933633;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x00952818 File Offset: 0x00950A18
		private void a(global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList A_0)
		{
			short num = (short)1406761704;
			short num2 = num;
			num = (short)911440616;
			switch (num2 == num)
			{
			}
			num = (short)1005060096;
			short num3 = num;
			num = (short)1047068672;
			if (num != 0)
			{
			}
			num = (short)2060845057;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x009528E4 File Offset: 0x00950AE4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			while (this.c)
			{
				short num = (short)548577738;
				short num2 = num;
				num = (short)1275765194;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)210763777;
					if (num != 0)
					{
					}
					num = (short)923402240;
					short num3 = num;
					num = (short)559415296;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2蛤裦蓨鯪苬臮铰鷲致\ud8f6鷸髺觼黾␀㄂㔄搆昈攊欌明瘐昒朔瘖洘爚爜焞ภ䘢䬤伦䠨䔪丬䨮唰ᘲܴܶ崸娺䤼帾摀煂畄㝆♈㥊㥌橎捐捒㥔㹖⩘⽚牜㩞འୢѤ०੨๪६୮ၰݲᑴݶᙸॺॼ፾ꎌﺒ璉", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x009529C4 File Offset: 0x00950BC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)945291265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1583346743;
				short num3 = num;
				num = (short)419886135;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_179;
				default:
					num = (short)997785600;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_16A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						num = (short)340721664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					switch (connectionId)
					{
					case 1:
						goto IL_121;
					case 2:
						goto IL_FD;
					case 3:
						goto IL_179;
					case 4:
						goto IL_16C;
					default:
					{
						num = (short)1976958977;
						if (num != 0)
						{
						}
						num = (short)1310130176;
						short num4 = num;
						num = (short)1273495554;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
			}
			IL_FD:
			this.RecNavToolbarPageEnhancedDataPortList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageEnhancedDataPortList.ModeClick += this.OnModeClick;
			return;
			IL_121:
			((global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.PageEnhancedDataPortListTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.PageEnhancedDataPortListTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_16A:
			goto IL_179;
			IL_16C:
			this.EnhancedDataPortListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_179:
			this.c = true;
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x00952B54 File Offset: 0x00950D54
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1079836673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)1041367040;
					short num3 = num;
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)829932272;
					short num4 = num;
					num = (short)259965680;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1215758336;
						if (num != 0)
						{
						}
						num = (short)1998716929;
						if (num != 0)
						{
						}
						num = (short)72876032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_30:
				if (connectionId != 3)
				{
					break;
				}
				num = (short)1355874306;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04004DEC RID: 19948
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04004DED RID: 19949
		private bool b;

		// Token: 0x04004DEE RID: 19950
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageEnhancedDataPortList;

		// Token: 0x04004DEF RID: 19951
		internal global::AcpUI.AcpXamDataPresenter EnhancedDataPortListList;

		// Token: 0x04004DF0 RID: 19952
		private bool c;
	}
}
