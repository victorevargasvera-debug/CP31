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
using AcpUITTS;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200004E RID: 78
	public class PageZoneChannelAssignmentTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00048D08 File Offset: 0x00046F08
		public PageZoneChannelAssignmentTbl()
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x00048D40 File Offset: 0x00046F40
		public override void SetDataContext()
		{
			short num = (short)655556612;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2051);
					num = (short)1951399937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)2129739865;
					short num3 = num;
					num = (short)1913339993;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1141309440;
						if (num != 0)
						{
						}
						goto IL_89;
					}
					break;
				}
				case 2:
					goto IL_10B;
				case 3:
					goto IL_89;
				case 4:
					goto IL_14;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1780350978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				}
				goto IL_3C;
				IL_14:
				switch (0)
				{
				case 0:
					IL_3C:
					num = (short)2087124993;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2005270528;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2051);
						num = (short)660471811;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_89:
				this.ZoneChannelAssignmentList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageZoneChannelAssignment.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageZoneChannelAssignment.MyDataPresenter = this.ZoneChannelAssignmentList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageZoneChannelAssignment;
				num = (short)1843134469;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			num = (short)758448128;
			short num4 = num;
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2051);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageZoneChannelAssignment).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_204:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageZoneChannelAssignment).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00048F60 File Offset: 0x00047160
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1486028801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageZoneChannelAssignment.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)347449505;
					short num3 = num;
					num = (short)424454305;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1976958976;
						if (num != 0)
						{
						}
						num = (short)1026686977;
						if (num != 0)
						{
						}
						num = (short)285868032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_32:
				if (this.b)
				{
					return;
				}
				num = (short)1543634946;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			num = (short)1280376832;
			short num4 = num;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000490A4 File Offset: 0x000472A4
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
					return;
				case 1:
					num2 = (short)157483009;
					if (num2 != 0)
					{
					}
					if (this.b)
					{
						goto IL_7B;
					}
					return;
				case 2:
				{
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)343768849;
					short num3 = num2;
					num2 = (short)1723825937;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
					{
						num2 = (short)396230656;
						if (num2 != 0)
						{
						}
						num2 = (short)845283328;
						short num4 = num2;
						num2 = (short)2029780992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_7B:
				num2 = (short)2121990146;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			this.RecNavToolbarPageZoneChannelAssignment.DataContext = null;
			this.RecNavToolbarPageZoneChannelAssignment.MyDataPresenter = null;
			num2 = (short)305397761;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000491E8 File Offset: 0x000473E8
		internal void OnZoneChannelAssignmentFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)190378466;
			short num2 = num;
			num = (short)1848898018;
			switch (num2 == num)
			{
			}
			num = (short)8519681;
			if (num != 0)
			{
			}
			num = (short)2139029504;
			if (num != 0)
			{
			}
			num = (short)718667776;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment a_ = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000492BC File Offset: 0x000474BC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1669962935;
			short num2 = num;
			num = (short)1489935543;
			switch (num2 == num)
			{
			}
			num = (short)993787905;
			if (num != 0)
			{
			}
			num = (short)1105526784;
			if (num != 0)
			{
			}
			num = (short)1211695104;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0004936C File Offset: 0x0004756C
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
					goto IL_136;
				case 1:
					if (this.a.CurrentItem == null)
					{
						goto IL_87;
					}
					goto IL_138;
				case 2:
				{
					this.a.MoveCurrentToFirst();
					num2 = (short)1668504407;
					short num3 = num2;
					num2 = (short)1091001175;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
					{
						num2 = (short)1219166208;
						if (num2 != 0)
						{
						}
						num2 = (short)193396736;
						short num4 = num2;
						num2 = (short)1828585472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_87:
				num2 = (short)317063170;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_136:
			IL_138:
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment a_ = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			num2 = (short)834535425;
			if (num2 != 0)
			{
			}
			object myRecordsetDataSource = this.RecNavToolbarPageZoneChannelAssignment.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)784793601;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000494CC File Offset: 0x000476CC
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment A_0)
		{
			short num = (short)1294906668;
			short num2 = num;
			num = (short)360953132;
			switch (num2 == num)
			{
			}
			num = (short)117768193;
			if (num != 0)
			{
			}
			num = (short)1215102976;
			if (num != 0)
			{
			}
			num = (short)806879232;
			short num3 = num;
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0004959C File Offset: 0x0004779C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1362624513;
			if (num != 0)
			{
			}
			if (!this.c)
			{
				num = (short)1499856448;
				short num2 = num;
				num = (short)1776025152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)103350272;
					short num3 = num;
					break;
				}
				}
				num = (short)1413087232;
				if (num != 0)
				{
				}
				this.c = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸臺鋼釾搀☂㜄㜆樈挊氌愎缐瘒礔㈖⬘⬚簜氞删䨢䈤䤦䐨个䌬嬮Ḱ䤲娴夶尸堺唼帾⽀ⵂ⁄⭆⡈㡊㹌♎㙐㵒㡔㉖㝘⽚⥜㵞ൠ䵢ᵤ٦Ѩݪ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0004967C File Offset: 0x0004787C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1742995458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)604569601;
					if (num != 0)
					{
					}
					if (connectionId != 23)
					{
						num = (short)782630915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_100;
				case 1:
					num = (short)1575944192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
				{
					num = (short)788198492;
					short num3 = num;
					num = (short)518321244;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1784152064;
						if (num != 0)
						{
						}
						num = (short)222298112;
						short num4 = num;
						num = (short)1130758148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_C2;
				case 5:
					if (connectionId != 2)
					{
						num = (short)1531052033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E;
				case 6:
					num = (short)2072576005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (connectionId == 1)
				{
					goto IL_1B8;
				}
				num = (short)1004339206;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5E:
			this.RecNavToolbarPageZoneChannelAssignment = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageZoneChannelAssignment.ModeClick += this.OnModeClick;
			return;
			IL_C2:
			this.c = true;
			return;
			IL_100:
			this.ZoneChannelAssignmentList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B8:
			((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.PageZoneChannelAssignmentTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.PageZoneChannelAssignmentTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0004987C File Offset: 0x00047A7C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
			{
				short num = (short)1217602288;
				short num2 = num;
				num = (short)1768891120;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)148373504;
					if (num != 0)
					{
					}
					((global::AcpUITTS.AcpTTSTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 5:
				break;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
			{
				short num = (short)1710292992;
				short num3 = num;
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
			{
				short num = (short)27721729;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 22:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040001D2 RID: 466
		private bool b;

		// Token: 0x040001D3 RID: 467
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageZoneChannelAssignment;

		// Token: 0x040001D4 RID: 468
		internal global::AcpUI.AcpXamDataPresenter ZoneChannelAssignmentList;

		// Token: 0x040001D5 RID: 469
		private bool c;
	}
}
