using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BD RID: 701
	public class PageSwitches : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060075D4 RID: 30164 RVA: 0x006A2FF8 File Offset: 0x006A11F8
		public PageSwitches()
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

		// Token: 0x060075D5 RID: 30165 RVA: 0x006A3030 File Offset: 0x006A1230
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1506279424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)278003715;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					object obj;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)41353216;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_32E;
									}
									continue;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)1688666114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3E8;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)430571526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1049296901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_441;
								case 5:
									if (acpExpander != null)
									{
										num = (short)727056385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3EA;
								case 6:
									num = (short)642187268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_32E;
								IL_3EA:
								num = (short)760020995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E8:
								goto IL_3EA;
								IL_32E:
								num = (short)1434575630;
								short num3 = num;
								num = (short)689824526;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3E8;
								default:
									num = (short)1328545792;
									if (num != 0)
									{
									}
									goto IL_3EA;
								}
							}
							IL_441:
							goto IL_202;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_463;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_450:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)2064187394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1677131776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B8;
								case 2:
									goto IL_4B6;
								}
								goto IL_463;
							}
							IL_4B6:
							IL_4B8:
							goto EndFinally_11;
							IL_463:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)467730433;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_450;
							EndFinally_11:;
						}
						goto IL_4B9;
						IL_202:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1415839745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_22A;
					case 2:
						goto IL_11F;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 4:
						goto IL_DB;
					case 5:
						obj = null;
						obj = this.RecNavToolbarExpanderSwitchesRotaryControl.MyRecordsetDataSource;
						num = (short)919142411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_4B9;
					case 7:
						if (obj != null)
						{
							num = (short)1309343756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 8:
						goto IL_22F;
					case 9:
					{
						num = (short)1043333120;
						short num4 = num;
						if (obj != null)
						{
							num = (short)443547654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					}
					case 10:
						goto IL_AB;
					case 11:
						if (obj != null)
						{
							num = (short)978518031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F;
					case 12:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.MyDataPresenter = this.ExpanderSwitchesConventionalSwitchTableTable;
						num = (short)1501298696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.MyDataPresenter = this.ExpanderSwitchesMFKAssignmentControl;
						num = (short)171638794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (obj != null)
						{
							num = (short)1805058061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderSwitchesRotaryControl.MyDataPresenter = this.ExpanderSwitchesRotaryControl;
						num = (short)1045102594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_85:
					if (!this.a)
					{
						num = (short)1231028229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AB:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1905328128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB:
					obj = this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.MyRecordsetDataSource;
					num = (short)1007419406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F:
					obj = this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.MyRecordsetDataSource;
					num = (short)1715404801;
					if (num != 0)
					{
					}
					num = (short)672137223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F:
					obj = this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.MyRecordsetDataSource;
					num = (short)1603403785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B9:
					global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.MyDataPresenter = this.ExpanderSwitchesTrunkingSwitchTableTable;
					num = (short)1000538116;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_22A:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x006A35A0 File Offset: 0x006A17A0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)508416186;
			short num2 = num;
			num = (short)1693765818;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_163:
				num = (short)1562968066;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1416691712;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_152;
				case 1:
					if (this.a)
					{
						num = (short)313655297;
						if (num != 0)
						{
						}
						num = (short)1111031808;
						short num4 = num;
						num = (short)721879040;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_67;
			}
			IL_152:
			base.OnUnloaded(sender, e);
			this.a = false;
			goto IL_163;
			IL_67:
			this.RecNavToolbarExpanderSwitchesRotaryControl.DataContext = null;
			this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.DataContext = null;
			this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.DataContext = null;
			this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.DataContext = null;
			this.RecNavToolbarExpanderSwitchesRotaryControl.MyDataPresenter = null;
			this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.MyDataPresenter = null;
			num = (short)757596161;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x006A372C File Offset: 0x006A192C
		public override void SetDataContext()
		{
			short num = (short)867762179;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2038);
					num = (short)2123104263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10085].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable).SyncDataSources();
					num = (short)1801846823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)397475840;
					short num3 = num;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesRotaryControl).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10081].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesRotaryControl).SyncDataSources();
					num = (short)1249902604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10637] != null)
					{
						num = (short)1011351572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)1846083588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)737869853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (feature != null)
					{
						num = (short)1803026438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2038);
					num = (short)298975262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)554434570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10085] != null)
					{
						num = (short)92798989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 11:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10083].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable).SyncDataSources();
					num = (short)613482517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_45C;
				case 13:
					num = (short)2016935973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						goto IL_70E;
					}
					goto IL_148;
				case 15:
					goto IL_218;
				case 16:
					goto IL_40B;
				case 17:
					return;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10083].EmbeddedRecset != null)
					{
						num = (short)1203372043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F0;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1032716293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
				{
					num = (short)1537637550;
					short num4 = num;
					num = (short)965901486;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70E;
					default:
						num = (short)178192384;
						if (num != 0)
						{
						}
						num = (short)1630273564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 21:
					goto IL_7F0;
				case 22:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10081] != null)
					{
						num = (short)2069692450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 23:
					num = (short)1343619073;
					if (num != 0)
					{
					}
					num = (short)1795293202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)908984334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (feature != null)
					{
						num = (short)1825112095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F0;
				case 26:
					num = (short)1734148118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (feature != null)
					{
						num = (short)607977504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 28:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10637].EmbeddedRecset != null)
					{
						num = (short)75694096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 29:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)466747418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 30:
					goto IL_218;
				case 31:
					num = (short)1620901929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					num = (short)1759051795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10081].EmbeddedRecset != null)
					{
						num = (short)1514930178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 34:
					num = (short)271056929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)1578565668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10083] != null)
					{
						num = (short)1390673943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F0;
				case 37:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10085].EmbeddedRecset != null)
					{
						num = (short)697892865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 38:
					if (feature != null)
					{
						num = (short)2005991448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 39:
					goto IL_148;
				case 40:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1159004160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesRotaryControl).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesMFKAssignmentControl).MySecondaryRecordsetDataSource = null;
					num = (short)1659895825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1063649315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F0;
				}
				IL_CE:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)493879304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2038);
				num = (short)1701445647;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_148:
				num = (short)1358954521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_218:
				num = (short)1364721704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45C:
				num = (short)1197998118;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_70E:
				num = (short)895680521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F0:
				num = (short)1906180123;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_40B:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesMFKAssignmentControl).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10637].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSwitchesMFKAssignmentControl).SyncDataSources();
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x006A3F64 File Offset: 0x006A2164
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 0;
			short num = (short)1738670080;
			switch (num)
			{
			default:
			{
				num = (short)282132482;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2088501249;
						if (num != 0)
						{
						}
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1259601932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C2;
					}
					case 1:
						goto IL_125;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					case 3:
						num = (short)200146950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1247150085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_3ED;
					case 6:
						goto IL_487;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)531955743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1312948237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.MyRecordsetDataSource;
						num = (short)1876164637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.MyRecordsetDataSource;
						num = (short)1037033657;
						short num3 = num;
						num = (short)571859129;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_487;
						default:
							num = (short)1863974912;
							if (num != 0)
							{
							}
							num = (short)1642790916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_5A9;
					case 11:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderSwitchesRotaryControl.MyRecordsetDataSource;
						num = (short)837025792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInner item = (global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)399507470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_125;
					case 14:
						goto IL_4C2;
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨룪髬蛮藰郲鷴鋶諸뛺민듾䀀瀂瘄渆済攊怌樎缐朒嘔砖眘漚漜瀞䴠", a_))
						{
							num = (short)1843068954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)399573000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)146931722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨룪髬蛮藰郲鷴鋶諸룺鋼釾眀昂欄猆怈搊挌渎紐䀒戔縖洘砚甜䬞䀠䄢䤤䈦紨䨪伬䌮吰", a_))
						{
							num = (short)411172892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 18:
						goto IL_5A9;
					case 19:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)394330113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)867434512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨룪髬蛮藰郲鷴鋶諸꿺迼諾漀栂氄椆済堊稌明攐瀒純䌖砘礚焜稞甠䈢䜤䬦䰨", a_))
						{
							num = (short)1640235028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A9;
					case 22:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)909115410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)353042459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)450232339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					case 25:
						goto IL_4C2;
					case 26:
						num = (short)775618592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)915800075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)696123417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)669319175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)593100822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A9;
					}
					case 30:
						return;
					case 31:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.MyRecordsetDataSource;
						num = (short)1854013464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1608974345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1572012062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D3:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1439629315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_125:
					num = (short)1571946517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_487:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨룪髬蛮藰郲鷴鋶諸ꧺ鋼课怀焂簄䐆昈攊礌紎縐缒", a_))
					{
						num = (short)989986839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4C2:
					num = (short)1073348625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A9:
					num = (short)1573191680;
					short num4 = num;
					num = (short)1469054991;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3ED:
				global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner)collectionView4.CurrentItem;
				collectionView4.MoveCurrentTo(item4);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x006A4684 File Offset: 0x006A2884
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1261093425;
			short num2 = num;
			num = (short)1770701361;
			switch (num2 == num)
			{
			}
			num = (short)158859265;
			if (num != 0)
			{
			}
			num = (short)1416757248;
			if (num != 0)
			{
			}
			num = (short)1935998976;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x006A4734 File Offset: 0x006A2934
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1458260370;
			short num2 = num;
			num = (short)91179410;
			switch (num2 == num)
			{
			}
			num = (short)762904577;
			if (num != 0)
			{
			}
			num = (short)1190133760;
			if (num != 0)
			{
			}
			num = (short)1445068800;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x006A47E4 File Offset: 0x006A29E4
		internal void OnExpanderSwitchesRotaryControlClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1882657854;
			short num2 = num;
			num = (short)527897662;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1263730688;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				int num3;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInner item;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						goto IL_120;
					case 1:
						num = (short)1674903553;
						if (num != 0)
						{
						}
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSwitchesRotaryControl.SyncDataSources();
						num = (short)1572339712;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1470234625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					}
					goto IL_67;
				}
				IL_120:
				break;
				IL_67:
				item = (global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderSwitchesRotaryControl.MyRecordsetDataSource;
				num = (short)445579266;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			}
			IL_122:
			num = (short)116719616;
			short num4 = num;
			this.RecNavToolbarExpanderSwitchesRotaryControl.TableMode = false;
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x006A4948 File Offset: 0x006A2B48
		internal void OnExpanderSwitchesConventionalSwitchTableTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)846546116;
			short num2 = num;
			num = (short)1113212100;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)818937856;
				if (num != 0)
				{
				}
				num = (short)1528758273;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num3;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner item;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
						goto IL_124;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.SyncDataSources();
						num = (short)1468989440;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)476643329;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					}
					goto IL_8F;
				}
				IL_124:
				break;
				IL_8F:
				item = (global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.MyRecordsetDataSource;
				num = (short)1920729090;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
			IL_126:
			num = (short)141230080;
			short num4 = num;
			this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.TableMode = false;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x006A4AB4 File Offset: 0x006A2CB4
		internal void OnExpanderSwitchesTrunkingSwitchTableTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1392863764;
			short num2 = num;
			num = (short)2134665748;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1944584192;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num3;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner item;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						goto IL_126;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.SyncDataSources();
						num = (short)568721408;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1871052801;
							if (num != 0)
							{
							}
							num = (short)1006370817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_128;
					}
					goto IL_66;
				}
				IL_126:
				break;
				IL_66:
				item = (global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.MyRecordsetDataSource;
				num = (short)954138626;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
			IL_128:
			num = (short)841744384;
			short num4 = num;
			this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.TableMode = false;
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x006A4C20 File Offset: 0x006A2E20
		internal void OnExpanderSwitchesMFKAssignmentControlClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1902147505;
			short num2 = num;
			num = (short)1777301425;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1851064320;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num3;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner item;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						goto IL_123;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.SyncDataSources();
						num = (short)2137456640;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)319815681;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					goto IL_66;
				}
				IL_123:
				break;
				IL_66:
				item = (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.MyRecordsetDataSource;
				num = (short)1853816833;
				if (num != 0)
				{
				}
				num = (short)975503362;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
			IL_125:
			num = (short)450035712;
			short num4 = num;
			this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.TableMode = false;
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x006A4D88 File Offset: 0x006A2F88
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)1451163648;
			short num2 = num;
			if (!this.b)
			{
				num = (short)572182181;
				short num3 = num;
				num = (short)2012663461;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)454230017;
					if (num != 0)
					{
					}
					num = (short)1751842816;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ룚닜닞釠賢诤苦蟨鿪심鷮郰韲鳴飶\udcf8짺췼髾猀搂樄椆昈昊搌氎成㘒✔✖稘琚猜礞䠠䐢値唦䠨弪䐬䀮弰ᰲ嘴堶圸伺似倾ⵀあ橄㑆㹈≊㥌ⱎ㥐㙒♔硖⩘ⱚ㑜⭞ɠୢdᑦ䝨፪౬ɮᵰ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x006A4E68 File Offset: 0x006A3068
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2131886082;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1891500033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_ABB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_540;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
					goto IL_1800;
				case 22:
					goto IL_AC0;
				case 23:
					goto IL_11EF;
				case 24:
					goto IL_1631;
				case 25:
					goto IL_702;
				case 26:
					goto IL_9EA;
				case 27:
					goto IL_662;
				case 28:
					goto IL_1472;
				case 29:
					goto IL_155A;
				case 30:
					goto IL_1363;
				case 31:
					goto IL_C8F;
				case 32:
					goto IL_FDB;
				case 33:
					goto IL_17E6;
				case 34:
					goto IL_DE8;
				case 35:
					goto IL_150F;
				case 36:
					goto IL_1696;
				case 37:
					goto IL_D6C;
				case 38:
					goto IL_788;
				case 39:
					goto IL_1237;
				case 40:
					goto IL_DF5;
				case 41:
					goto IL_178E;
				case 42:
					goto IL_1002;
				case 43:
					goto IL_10BF;
				case 44:
					goto IL_9B9;
				case 45:
					goto IL_1033;
				case 46:
					goto IL_14DE;
				case 47:
					goto IL_12E7;
				case 48:
					goto IL_F86;
				case 49:
					goto IL_12A6;
				case 50:
					goto IL_A0E;
				case 51:
					goto IL_9DD;
				case 52:
					goto IL_4C1;
				case 53:
					goto IL_E02;
				case 54:
					goto IL_8A7;
				case 55:
					goto IL_B25;
				case 56:
					goto IL_740;
				case 57:
					goto IL_FE8;
				case 58:
					goto IL_6F5;
				case 59:
					goto IL_57E;
				case 60:
					goto IL_795;
				case 61:
					goto IL_179B;
				case 62:
					goto IL_11A7;
				case 63:
					goto IL_1098;
				case 64:
					goto IL_835;
				case 65:
					goto IL_158E;
				case 66:
					goto IL_FF5;
				case 67:
					goto IL_571;
				case 68:
					goto IL_12F4;
				case 69:
					goto IL_176A;
				case 70:
					goto IL_17D9;
				case 71:
					goto IL_160A;
				case 72:
					goto IL_4A7;
				case 73:
					goto IL_5FD;
				case 74:
					goto IL_7C6;
				case 75:
					goto IL_1325;
				case 76:
					goto IL_58B;
				case 77:
					goto IL_1176;
				case 78:
					goto IL_9AC;
				case 79:
					goto IL_50C;
				case 80:
					goto IL_733;
				case 81:
					goto IL_631;
				case 82:
					goto IL_E50;
				case 83:
					goto IL_624;
				case 84:
					goto IL_F79;
				case 85:
					goto IL_166F;
				case 86:
					goto IL_EBF;
				case 87:
					goto IL_14BA;
				case 88:
					goto IL_CB3;
				case 89:
					goto IL_BDF;
				case 90:
					goto IL_617;
				case 91:
					goto IL_16A3;
				case 92:
					goto IL_105A;
				case 93:
					goto IL_B70;
				case 94:
					goto IL_1496;
				case 95:
					goto IL_1465;
				case 96:
					goto IL_5F0;
				case 97:
					goto IL_1026;
				case 98:
					goto IL_144B;
				case 99:
					goto IL_F0A;
				case 100:
					goto IL_693;
				case 101:
					goto IL_16B0;
				case 102:
					goto IL_84F;
				case 103:
					goto IL_A7D;
				case 104:
					goto IL_B0B;
				case 105:
					goto IL_A32;
				case 106:
					goto IL_1574;
				case 107:
					goto IL_6C4;
				case 108:
					goto IL_D86;
				case 109:
					goto IL_BEC;
				case 110:
					goto IL_12CD;
				case 111:
					goto IL_EB2;
				case 112:
					goto IL_909;
				case 113:
					goto IL_1750;
				case 114:
					goto IL_15A8;
				case 115:
					goto IL_DAA;
				case 116:
					goto IL_5BF;
				case 117:
					goto IL_5B2;
				case 118:
					goto IL_175D;
				case 119:
					goto IL_154D;
				case 120:
					goto IL_AE7;
				case 121:
					goto IL_8E5;
				case 122:
					goto IL_916;
				case 123:
					goto IL_F17;
				case 124:
					goto IL_978;
				case 125:
					goto IL_159B;
				case 126:
					goto IL_139B;
				case 127:
					goto IL_D48;
				case 128:
					goto IL_1662;
				case 129:
					goto IL_533;
				case 130:
					goto IL_ADA;
				case 131:
					goto IL_13CC;
				case 132:
					goto IL_954;
				case 133:
					goto IL_1138;
				case 134:
					goto IL_B18;
				case 135:
					goto IL_686;
				case 136:
					goto IL_108B;
				case 137:
					goto IL_DDB;
				case 138:
					goto IL_13D9;
				case 139:
					goto IL_E74;
				case 140:
					goto IL_15D9;
				case 141:
					goto IL_FAA;
				case 142:
					goto IL_1268;
				case 143:
					goto IL_1655;
				case 144:
					goto IL_655;
				case 145:
					goto IL_A8A;
				case 146:
					goto IL_1152;
				case 147:
					goto IL_E36;
				case 148:
					goto IL_BAE;
				case 149:
					goto IL_D3B;
				case 150:
					goto IL_1689;
				case 151:
					goto IL_923;
				case 152:
					goto IL_17B5;
				case 153:
					goto IL_89A;
				case 154:
					goto IL_F55;
				case 155:
					goto IL_ACD;
				case 156:
					goto IL_1349;
				case 157:
					goto IL_99F;
				case 158:
					goto IL_1114;
				case 159:
					goto IL_8D8;
				case 160:
					goto IL_483;
				case 161:
					goto IL_16D4;
				case 162:
					goto IL_12C0;
				case 163:
					goto IL_985;
				case 164:
					goto IL_10F0;
				case 165:
					goto IL_4FF;
				case 166:
					goto IL_1067;
				case 167:
					goto IL_842;
				case 168:
					goto IL_7B9;
				case 169:
					goto IL_C44;
				case 170:
					goto IL_14EB;
				case 171:
					goto IL_1712;
				case 172:
					goto IL_C06;
				case 173:
					goto IL_B56;
				case 174:
					goto IL_B63;
				case 175:
					goto IL_17F3;
				case 176:
					goto IL_A59;
				case 177:
					goto IL_1617;
				case 178:
					goto IL_5CC;
				case 179:
					goto IL_12DA;
				case 180:
					goto IL_1431;
				case 181:
					goto IL_E0F;
				case 182:
					goto IL_C51;
				case 183:
					goto IL_A4C;
				case 184:
					goto IL_ECC;
				case 185:
					goto IL_A3F;
				case 186:
					goto IL_D21;
				case 187:
					goto IL_C37;
				case 188:
					goto IL_4CE;
				case 189:
					goto IL_E29;
				case 190:
					goto IL_BA1;
				case 191:
					goto IL_1624;
				case 192:
					goto IL_476;
				case 193:
					goto IL_BF9;
				case 194:
					goto IL_D79;
				case 195:
					goto IL_C75;
				case 196:
					goto IL_1424;
				case 197:
					goto IL_1318;
				case 198:
					goto IL_1581;
				case 199:
					goto IL_A97;
				case 200:
					goto IL_BD2;
				case 201:
					goto IL_1145;
				case 202:
					goto IL_6A0;
				case 203:
					goto IL_80E;
				case 204:
					goto IL_1244;
				case 205:
					goto IL_8CB;
				case 206:
					goto IL_15CC;
				case 207:
					goto IL_1040;
				case 208:
					goto IL_F31;
				case 209:
					goto IL_13BF;
				case 210:
					goto IL_764;
				case 211:
					goto IL_1458;
				case 212:
					goto IL_992;
				case 213:
					goto IL_143E;
				case 214:
					goto IL_11CB;
				case 215:
					goto IL_5A5;
				case 216:
					goto IL_B32;
				case 217:
					goto IL_13E6;
				case 218:
					goto IL_B94;
				case 219:
					goto IL_4B4;
				case 220:
					goto IL_1183;
				case 221:
					goto IL_60A;
				case 222:
					goto IL_7EA;
				case 223:
					goto IL_1540;
				case 224:
					goto IL_E1C;
				case 225:
					goto IL_81B;
				case 226:
					goto IL_10CC;
				case 227:
					goto IL_104D;
				case 228:
					goto IL_1275;
				case 229:
					goto IL_C2A;
				case 230:
					goto IL_6E8;
				case 231:
					goto IL_828;
				case 232:
					goto IL_151C;
				case 233:
					goto IL_519;
				case 234:
					goto IL_E81;
				case 235:
					goto IL_C82;
				case 236:
					goto IL_171F;
				case 237:
					goto IL_167C;
				case 238:
					goto IL_172C;
				case 239:
					goto IL_598;
				case 240:
					goto IL_930;
				case 241:
					goto IL_726;
				case 242:
					goto IL_4F2;
				case 243:
					goto IL_16E1;
				case 244:
					goto IL_FB7;
				case 245:
					goto IL_E43;
				case 246:
					goto IL_10A5;
				case 247:
					goto IL_F24;
				case 248:
					goto IL_D2E;
				case 249:
					goto IL_12B3;
				case 250:
					goto IL_EF0;
				case 251:
					goto IL_EFD;
				case 252:
					goto IL_17A8;
				case 253:
					goto IL_15E6;
				case 254:
					goto IL_13F3;
				case 255:
					goto IL_16EE;
				case 256:
					goto IL_10B2;
				case 257:
					goto IL_EA5;
				case 258:
					goto IL_526;
				case 259:
					goto IL_1400;
				case 260:
					goto IL_1567;
				case 261:
					goto IL_1213;
				case 262:
					goto IL_1356;
				case 263:
					goto IL_DCE;
				case 264:
					goto IL_1299;
				default:
					num = (short)1310195712;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_476:
			this.ExpanderSwitchesTrunkingSwitchTableTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_483:
			this.LblSwitchConventionalSwitchTablePosition2Feature_A19656 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePosition2Feature_A19656.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A7:
			this.SwitchConventionalSwitchesPosition1_A7734Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B4:
			this.SwitchTrunkingSwitchTablePosition2Feature_A21005Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C1:
			this.CpyBtnSwitchRotaryControlButtonBCO_A22906 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CE:
			this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable.ModeClick += this.OnModeClick;
			return;
			IL_4F2:
			this.SwitchTrunkingSwitchKey_A21294Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4FF:
			this.CVBtnSwitchConventionalSwitchTablePosition3Feature_A19657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_50C:
			this.GrpBoxExpanderSwitchesConventionalSwitchesToggleSwitch = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_519:
			this.CVBtnSwitchTrunkingSwitchTablePosition5Feature_A21008 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_526:
			this.SwitchMFKAssignmentControlName_A38529Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_533:
			this.CpyBtnSwitchTrunkingSwitchesPosition5_A21535 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_540:
			((global::Motorola.MackinawCPS.CoreFeatures.Switches.PageSwitches)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.Switches.PageSwitches)target).Unloaded += this.OnUnloaded;
			return;
			IL_571:
			this.CVBtnSwitchConventionalSwitchesPosition1_A7734 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57E:
			this.SwitchGeneralRotaryControl_A8984Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_58B:
			this.RTDBtnSwitchConventionalSwitchesPosition2_A7735 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_598:
			this.CVBtnSwitchTrunkingSwitchKey_A21294 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A5:
			this.CVBtnSwitchTrunkingSwitchTablePosition2Feature_A21005 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B2:
			this.CpyBtnSwitchTrunkingSwitchesPosition3_A9468 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BF:
			this.RTDBtnSwitchTrunkingSwitchesPosition3_A9468 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CC:
			this.LblSwitchConventionalSwitchTablePosition5Feature_A19717 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePosition5Feature_A19717.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F0:
			this.CpyBtnSwitchConventionalSwitchesPosition5_A21531 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5FD:
			this.CVBtnSwitchConventionalSwitchesPosition2_A7735 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_60A:
			this.CVBtnSwitchTrunkingSwitchTablePosition3Feature_A21006 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_617:
			this.CpyBtnSwitchConventionalSwitchesPosition4_A21530 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_624:
			this.RTDBtnSwitchConventionalSwitchesPosition3_A7737 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_631:
			this.LblSwitchConventionalSwitchesPosition3_A7737 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition3_A7737.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_655:
			this.ExpanderSwitchesConventionalSwitchTableTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_662:
			this.HLinkTrunkingSwitchTable = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingSwitchTable.Click += this.HLinkClick;
			return;
			IL_686:
			this.ExpanderSwitchesConventionalSwitchTableTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_693:
			this.CVBtnSwitchTrunkingSwitchesPosition1_A9466 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6A0:
			this.SwitchTrunkingSwitchTablePositionsQuantity_A21003 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePositionsQuantity_A21003.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C4:
			this.LblSwitchTrunkingSwitchesPosition2_A9467 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchesPosition2_A9467.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6E8:
			this.CpyBtnSwitchTrunkingSwitchTablePosition4Feature_A21007 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6F5:
			this.CpyBtnSwitchGeneralRotaryControl_A8984 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_702:
			this.HLinkTrunkingSwitches = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingSwitches.Click += this.HLinkClick;
			return;
			IL_726:
			this.CpyBtnSwitchTrunkingSwitchKey_A21294 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_733:
			this.CVBtnSwitchConventionalSwitchesPosition3_A7737 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_740:
			this.LblSwitchGeneralRotaryControl_A8984 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchGeneralRotaryControl_A8984.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_764:
			this.LblSwitchTrunkingSwitchTablePosition1Feature_A21004 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePosition1Feature_A21004.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_788:
			this.SwitchGeneralRotaryControl_A8984_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_795:
			this.SwitchRotaryControlButtonKey_A22905 = (global::AcpUI.AcpTextBox)target;
			this.SwitchRotaryControlButtonKey_A22905.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7B9:
			this.CpyBtnSwitchConventionalSwitchTablePosition3Feature_A19657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7C6:
			this.LblSwitchConventionalSwitchesPosition2_A7735 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition2_A7735.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7EA:
			this.LblSwitchTrunkingSwitchTablePosition3Feature_A21006 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePosition3Feature_A21006.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_80E:
			this.CVBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_81B:
			this.SwitchTrunkingSwitchTablePosition3Feature_A21006Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_828:
			this.SwitchTrunkingSwitchTablePosition4Feature_A21007Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_835:
			this.SwitchRotaryControlButtonKey_A22905Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_842:
			this.RTDBtnSwitchConventionalSwitchTablePosition3Feature_A19657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_84F:
			num = (short)1647247361;
			if (num != 0)
			{
			}
			this.SwitchTrunkingSwitchesPosition1_A9466 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchesPosition1_A9466.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_89A:
			this.CVBtnSwitchConventionalSwitchTablePosition1Feature_A19655 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A7:
			this.SwitchGeneralRotaryControl_A8984 = (global::AcpUI.AcpComboBox)target;
			this.SwitchGeneralRotaryControl_A8984.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8CB:
			this.RTDBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8D8:
			this.CVBtnSwitchConventionalSwitchTablePosition2Feature_A19656 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8E5:
			this.SwitchTrunkingSwitchesPosition4_A21534 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchesPosition4_A21534.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_909:
			this.GrpBoxExpanderSwitchesTrunkingSwitchesToggleSwitch = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_916:
			this.RTDBtnSwitchTrunkingSwitchesPosition4_A21534 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_923:
			this.SwitchConventionalSwitchTablePositionsQuantity_A19654Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_930:
			this.LblSwitchTrunkingSwitchKey_A21294 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchKey_A21294.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_954:
			this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSwitchesConventionalSwitchTableTable.ModeClick += this.OnModeClick;
			return;
			IL_978:
			this.SwitchTrunkingSwitchesPosition4_A21534Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_985:
			this.SwitchConventionalSwitchTablePosition2Feature_A19656Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_992:
			this.CpyBtnSwitchTrunkingSwitchTablePosition1Feature_A21004 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_99F:
			this.SwitchConventionalSwitchTablePosition1Feature_A19655Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9AC:
			this.SwitchConventionalSwitchesPosition2_A7735Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9B9:
			this.LblSwitchRotaryControlButtonName_A22903 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchRotaryControlButtonName_A22903.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9DD:
			this.RTDBtnSwitchRotaryControlButtonBCO_A22906 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9EA:
			this.HLinkConventionalSwitchTable = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConventionalSwitchTable.Click += this.HLinkClick;
			return;
			IL_A0E:
			this.LblSwitchRotaryControlButtonBCO_A22906 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchRotaryControlButtonBCO_A22906.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A32:
			this.SwitchTrunkingSwitchesPosition1_A9466Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A3F:
			this.CpyBtnSwitchConventionalSwitchKey_A21293 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A4C:
			this.CVBtnSwitchConventionalSwitchKey_A21293 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A59:
			this.SwitchConventionalSwitchTablePosition5Feature_A19717 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePosition5Feature_A19717.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A7D:
			this.RTDBtnSwitchTrunkingSwitchesPosition1_A9466 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A8A:
			this.gridExpanderSwitchesConventionalSwitchTableTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A97:
			this.SwitchTrunkingSwitchKey_A21294_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_ABB:
			goto IL_1800;
			IL_AC0:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_ACD:
			this.RTDBtnSwitchConventionalSwitchTablePosition1Feature_A19655 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ADA:
			this.SwitchTrunkingSwitchesPosition5_A21535Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AE7:
			this.LblSwitchTrunkingSwitchesPosition4_A21534 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchesPosition4_A21534.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B0B:
			this.CpyBtnSwitchTrunkingSwitchesPosition1_A9466 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B18:
			this.ExpanderSwitchesConventionalSwitchTableTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B25:
			this.CVBtnSwitchGeneralRotaryControl_A8984 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B32:
			this.LblSwitchTrunkingSwitchTablePosition2Feature_A21005 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePosition2Feature_A21005.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B56:
			this.RTDBtnSwitchConventionalSwitchTablePosition4Feature_A19658 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B63:
			this.CpyBtnSwitchConventionalSwitchTablePosition4Feature_A19658 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B70:
			this.LblSwitchConventionalSwitchesPosition5_A21531 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition5_A21531.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B94:
			this.CpyBtnSwitchTrunkingSwitchTablePosition2Feature_A21005 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BA1:
			this.ExpanderSwitchesTrunkingSwitchTableTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BAE:
			this.LblSwitchConventionalSwitchTablePositionsQuantity_A19654 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePositionsQuantity_A19654.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BD2:
			this.ExpanderSwitchesTrunkingSwitchTableTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BDF:
			this.RTDBtnSwitchConventionalSwitchesPosition4_A21530 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BEC:
			this.RTDBtnSwitchTrunkingSwitchesPosition2_A9467 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BF9:
			this.SwitchTrunkingSwitchTablePositionsQuantity_A21003_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C06:
			this.LblSwitchConventionalSwitchTablePosition4Feature_A19658 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePosition4Feature_A19658.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C2A:
			this.RTDBtnSwitchTrunkingSwitchTablePosition4Feature_A21007 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C37:
			this.ExpanderSwitchesTrunkingSwitchTable = (global::AcpUI.AcpExpander)target;
			return;
			IL_C44:
			this.SwitchConventionalSwitchTablePosition3Feature_A19657Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C51:
			this.SwitchConventionalSwitchKey_A21293 = (global::AcpUI.AcpTextBox)target;
			this.SwitchConventionalSwitchKey_A21293.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C75:
			this.SwitchTrunkingSwitchTablePosition2Feature_A21005_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C82:
			this.RTDBtnSwitchTrunkingSwitchTablePosition5Feature_A21008 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C8F:
			this.RecNavToolbarExpanderSwitchesRotaryControl = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSwitchesRotaryControl.ModeClick += this.OnModeClick;
			return;
			IL_CB3:
			num = (short)1160105761;
			short num3 = num;
			num = (short)965267233;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1696:
				this.SwitchRotaryControlButtonName_A22903_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			default:
				num = (short)663552000;
				if (num != 0)
				{
				}
				this.SwitchConventionalSwitchesPosition4_A21530 = (global::AcpUI.AcpComboBox)target;
				this.SwitchConventionalSwitchesPosition4_A21530.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_D21:
			this.SwitchConventionalSwitchKey_A21293Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D2E:
			this.ExpanderSwitchesMFKAssignmentControl = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D3B:
			this.RTDBtnSwitchConventionalSwitchTablePositionsQuantity_A19654 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D48:
			this.SwitchTrunkingSwitchesPosition5_A21535 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchesPosition5_A21535.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D6C:
			this.SwitchRotaryControlButtonBCO_A22906_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D79:
			this.SwitchTrunkingSwitchTablePosition1Feature_A21004_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D86:
			this.SwitchTrunkingSwitchesPosition2_A9467 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchesPosition2_A9467.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DAA:
			this.SwitchTrunkingSwitchesPosition3_A9468 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchesPosition3_A9468.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DCE:
			this.CpyBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DDB:
			this.SwitchConventionalSwitchTablePositionsQuantity_A19654_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_DE8:
			this.ExpanderSwitchesRotaryControlTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_DF5:
			this.ExpanderSwitchesRotaryControlSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E02:
			this.SwitchRotaryControlButtonBCO_A22906Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E0F:
			this.SwitchConventionalSwitchTablePosition5Feature_A19717Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E1C:
			this.CpyBtnSwitchTrunkingSwitchTablePosition3Feature_A21006 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E29:
			this.ExpanderSwitchesTrunkingSwitchTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E36:
			this.CVBtnSwitchConventionalSwitchTablePositionsQuantity_A19654 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E43:
			this.ExpanderSwitchesMultiFunctionKnobGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E50:
			this.SwitchConventionalSwitchesPosition3_A7737 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchesPosition3_A7737.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E74:
			this.SwitchConventionalSwitchTablePosition2Feature_A19656_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E81:
			this.LblSwitchTrunkingSwitchTablePosition5Feature_A21008 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePosition5Feature_A21008.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EA5:
			this.CpyBtnSwitchMFKAssignmentControlName_A38529 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EB2:
			this.SwitchTrunkingSwitchesPosition2_A9467Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EBF:
			this.CVBtnSwitchConventionalSwitchesPosition4_A21530 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ECC:
			this.LblSwitchConventionalSwitchKey_A21293 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchKey_A21293.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EF0:
			this.RadErgoControlSwitchsMFKFeatureAssignment_A38514_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_EFD:
			this.ExpanderSwitchesMFKAssignmentControlSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F0A:
			this.GrpBoxExpanderSwitchesTrunkingSwitchesConcentricSwitch = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F17:
			this.CpyBtnSwitchTrunkingSwitchesPosition4_A21534 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F24:
			this.ExpanderSwitchesMFKAssignmentControlTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F31:
			this.SwitchTrunkingSwitchTablePosition1Feature_A21004 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePosition1Feature_A21004.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F55:
			this.LblSwitchConventionalSwitchTablePosition1Feature_A19655 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePosition1Feature_A19655.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F79:
			this.CpyBtnSwitchConventionalSwitchesPosition3_A7737 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F86:
			this.SwitchRotaryControlButtonBCO_A22906 = (global::AcpUI.AcpComboBox)target;
			this.SwitchRotaryControlButtonBCO_A22906.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FAA:
			this.SwitchConventionalSwitchTablePosition4Feature_A19658_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_FB7:
			this.RecNavToolbarExpanderSwitchesMFKAssignmentControl = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSwitchesMFKAssignmentControl.ModeClick += this.OnModeClick;
			return;
			IL_FDB:
			this.ExpanderSwitchesGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_FE8:
			this.RTDBtnSwitchGeneralRotaryControl_A8984 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FF5:
			this.GrpBoxExpanderSwitchesConventionalSwitchesConcentricSwitch = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1002:
			this.SwitchRotaryControlButtonName_A22903 = (global::AcpUI.AcpLabel)target;
			this.SwitchRotaryControlButtonName_A22903.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1026:
			this.SwitchConventionalSwitchesPosition5_A21531Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1033:
			this.RTDBtnSwitchRotaryControlButtonName_A22903 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1040:
			this.SwitchTrunkingSwitchTablePositionsQuantity_A21003Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_104D:
			this.CVBtnSwitchTrunkingSwitchTablePosition4Feature_A21007 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_105A:
			this.CVBtnSwitchConventionalSwitchesPosition5_A21531 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1067:
			this.LblSwitchConventionalSwitchTablePosition3Feature_A19657 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchTablePosition3Feature_A19657.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_108B:
			this.ExpanderSwitchesConventionalSwitchTableTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1098:
			this.CpyBtnSwitchRotaryControlButtonKey_A22905 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10A5:
			this.ExpanderSwitchesMFKAssignmentControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_10B2:
			this.RTDBtnSwitchMFKAssignmentControlName_A38529 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10BF:
			this.CVBtnSwitchRotaryControlButtonName_A22903 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10CC:
			this.SwitchTrunkingSwitchTablePosition4Feature_A21007 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePosition4Feature_A21007.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10F0:
			this.SwitchConventionalSwitchTablePosition3Feature_A19657 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePosition3Feature_A19657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1114:
			this.SwitchConventionalSwitchTablePosition2Feature_A19656 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePosition2Feature_A19656.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1138:
			this.ExpanderSwitchesConventionalSwitchTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1145:
			this.gridExpanderSwitchesTrunkingSwitchTableTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1152:
			this.SwitchConventionalSwitchTablePositionsQuantity_A19654 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePositionsQuantity_A19654.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1176:
			this.CpyBtnSwitchConventionalSwitchesPosition2_A7735 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1183:
			this.SwitchTrunkingSwitchTablePosition3Feature_A21006 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePosition3Feature_A21006.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11A7:
			this.LblSwitchRotaryControlButtonKey_A22905 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchRotaryControlButtonKey_A22905.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11CB:
			this.SwitchTrunkingSwitchTablePosition2Feature_A21005 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePosition2Feature_A21005.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11EF:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_1213:
			this.LblRadErgoControlSwitchsMFKFeatureAssignment_A38514 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlSwitchsMFKFeatureAssignment_A38514.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1237:
			this.SwitchRotaryControlButtonKey_A22905_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1244:
			this.LblSwitchTrunkingSwitchTablePositionsQuantity_A21003 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePositionsQuantity_A21003.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1268:
			this.SwitchConventionalSwitchTablePosition5Feature_A19717_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1275:
			this.LblSwitchTrunkingSwitchTablePosition4Feature_A21007 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchTablePosition4Feature_A21007.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1299:
			this.RadErgoControlSwitchsMFKFeatureAssignment_A38514Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12A6:
			this.CVBtnSwitchRotaryControlButtonBCO_A22906 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12B3:
			this.SwitchMFKAssignmentControlName_A38529_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_12C0:
			this.CpyBtnSwitchConventionalSwitchTablePosition2Feature_A19656 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12CD:
			this.CpyBtnSwitchTrunkingSwitchesPosition2_A9467 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12DA:
			this.RTDBtnSwitchConventionalSwitchTablePosition5Feature_A19717 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12E7:
			this.SwitchRotaryControlButtonName_A22903Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12F4:
			this.LblSwitchConventionalSwitchesPosition1_A7734 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition1_A7734.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1318:
			this.SwitchTrunkingSwitchTablePosition4Feature_A21007_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1325:
			this.SwitchConventionalSwitchesPosition2_A7735 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchesPosition2_A7735.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1349:
			this.CpyBtnSwitchConventionalSwitchTablePosition1Feature_A19655 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1356:
			this.RTDBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1363:
			num = (short)1288568832;
			short num4 = num;
			this.ExpanderSwitchesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_139B:
			this.LblSwitchTrunkingSwitchesPosition5_A21535 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchesPosition5_A21535.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13BF:
			this.CVBtnSwitchTrunkingSwitchTablePosition1Feature_A21004 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13CC:
			this.ExpanderSwitchesConventionalSwitchTable = (global::AcpUI.AcpExpander)target;
			return;
			IL_13D9:
			this.SwitchConventionalSwitchTablePosition1Feature_A19655_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13E6:
			this.RTDBtnSwitchTrunkingSwitchTablePosition2Feature_A21005 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13F3:
			this.CVBtnSwitchMFKAssignmentControlName_A38529 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1400:
			this.RadErgoControlSwitchsMFKFeatureAssignment_A38514 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlSwitchsMFKFeatureAssignment_A38514.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1424:
			this.SwitchTrunkingSwitchTablePosition3Feature_A21006_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1431:
			this.CpyBtnSwitchConventionalSwitchTablePosition5Feature_A19717 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_143E:
			this.SwitchTrunkingSwitchTablePosition1Feature_A21004Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_144B:
			this.ExpanderSwitchesTrunkingSwitches = (global::AcpUI.AcpExpander)target;
			return;
			IL_1458:
			this.RTDBtnSwitchTrunkingSwitchTablePosition1Feature_A21004 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1465:
			this.RTDBtnSwitchConventionalSwitchesPosition5_A21531 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1472:
			this.HLinkMultiFunctionKnob = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMultiFunctionKnob.Click += this.HLinkClick;
			return;
			IL_1496:
			this.SwitchConventionalSwitchesPosition5_A21531 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchesPosition5_A21531.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14BA:
			this.LblSwitchConventionalSwitchesPosition4_A21530 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition4_A21530.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14DE:
			this.CpyBtnSwitchRotaryControlButtonName_A22903 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14EB:
			this.SwitchConventionalSwitchTablePosition4Feature_A19658 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePosition4Feature_A19658.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_150F:
			this.ExpanderSwitchesRotaryControl = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_151C:
			this.SwitchTrunkingSwitchTablePosition5Feature_A21008 = (global::AcpUI.AcpComboBox)target;
			this.SwitchTrunkingSwitchTablePosition5Feature_A21008.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1540:
			this.RTDBtnSwitchTrunkingSwitchTablePosition3Feature_A21006 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_154D:
			this.CVBtnSwitchTrunkingSwitchesPosition4_A21534 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_155A:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1567:
			this.CVBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1574:
			this.CVBtnSwitchTrunkingSwitchesPosition2_A9467 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1581:
			this.SwitchTrunkingSwitchTablePosition5Feature_A21008_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_158E:
			this.ExpanderSwitchesConventionalSwitches = (global::AcpUI.AcpExpander)target;
			return;
			IL_159B:
			this.CVBtnSwitchTrunkingSwitchesPosition5_A21535 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15A8:
			this.LblSwitchTrunkingSwitchesPosition3_A9468 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchesPosition3_A9468.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15CC:
			this.CpyBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15D9:
			this.SwitchConventionalSwitchTablePosition3Feature_A19657_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_15E6:
			this.SwitchMFKAssignmentControlName_A38529 = (global::AcpUI.AcpLabel)target;
			this.SwitchMFKAssignmentControlName_A38529.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_160A:
			this.CpyBtnSwitchConventionalSwitchesPosition1_A7734 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1617:
			this.CVBtnSwitchConventionalSwitchTablePosition5Feature_A19717 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1624:
			this.ExpanderSwitchesTrunkingSwitchTableTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1631:
			this.HLinkConventionalSwitches = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConventionalSwitches.Click += this.HLinkClick;
			return;
			IL_1655:
			this.SwitchConventionalSwitchKey_A21293_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1662:
			this.RTDBtnSwitchTrunkingSwitchesPosition5_A21535 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_166F:
			this.SwitchConventionalSwitchesPosition3_A7737Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_167C:
			this.SwitchTrunkingSwitchTablePosition5Feature_A21008Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1689:
			this.CpyBtnSwitchConventionalSwitchTablePositionsQuantity_A19654 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16A3:
			this.SwitchConventionalSwitchesPosition4_A21530Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16B0:
			this.LblSwitchTrunkingSwitchesPosition1_A9466 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchTrunkingSwitchesPosition1_A9466.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16D4:
			this.RTDBtnSwitchConventionalSwitchTablePosition2Feature_A19656 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16E1:
			this.ExpanderSwitchesMultiFunctionKnob = (global::AcpUI.AcpExpander)target;
			return;
			IL_16EE:
			this.LblSwitchMFKAssignmentControlName_A38529 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchMFKAssignmentControlName_A38529.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1712:
			this.CVBtnSwitchConventionalSwitchTablePosition4Feature_A19658 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_171F:
			this.CpyBtnSwitchTrunkingSwitchTablePosition5Feature_A21008 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_172C:
			this.SwitchTrunkingSwitchKey_A21294 = (global::AcpUI.AcpTextBox)target;
			this.SwitchTrunkingSwitchKey_A21294.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1750:
			this.CVBtnSwitchTrunkingSwitchesPosition3_A9468 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_175D:
			this.SwitchTrunkingSwitchesPosition3_A9468Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_176A:
			this.SwitchConventionalSwitchesPosition1_A7734 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchesPosition1_A7734.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_178E:
			this.gridExpanderSwitchesRotaryControlSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_179B:
			this.CVBtnSwitchRotaryControlButtonKey_A22905 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17A8:
			this.gridExpanderSwitchesMFKAssignmentControlSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_17B5:
			this.SwitchConventionalSwitchTablePosition1Feature_A19655 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchTablePosition1Feature_A19655.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17D9:
			this.RTDBtnSwitchConventionalSwitchesPosition1_A7734 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17E6:
			this.ExpanderSwitchesRotaryControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_17F3:
			this.SwitchConventionalSwitchTablePosition4Feature_A19658Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1800:
			this.b = true;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x006A667C File Offset: 0x006A487C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
			{
				short num = (short)466376442;
				short num2 = num;
				num = (short)2104121082;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)810418176;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
			{
				short num = (short)352190465;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 19:
			{
				short num = (short)1304166400;
				short num3 = num;
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 20:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
		}

		// Token: 0x04002F8B RID: 12171
		private bool a;

		// Token: 0x04002F8C RID: 12172
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002F8D RID: 12173
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002F8E RID: 12174
		internal global::System.Windows.Documents.Hyperlink HLinkConventionalSwitches;

		// Token: 0x04002F8F RID: 12175
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingSwitches;

		// Token: 0x04002F90 RID: 12176
		internal global::System.Windows.Documents.Hyperlink HLinkConventionalSwitchTable;

		// Token: 0x04002F91 RID: 12177
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingSwitchTable;

		// Token: 0x04002F92 RID: 12178
		internal global::System.Windows.Documents.Hyperlink HLinkMultiFunctionKnob;

		// Token: 0x04002F93 RID: 12179
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002F94 RID: 12180
		internal global::AcpUI.AcpExpander ExpanderSwitchesGeneral;

		// Token: 0x04002F95 RID: 12181
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSwitchesRotaryControl;

		// Token: 0x04002F96 RID: 12182
		internal global::System.Windows.Controls.Grid ExpanderSwitchesGeneralGrid;

		// Token: 0x04002F97 RID: 12183
		internal global::System.Windows.Controls.Grid ExpanderSwitchesRotaryControlGrid;

		// Token: 0x04002F98 RID: 12184
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesRotaryControlTableView;

		// Token: 0x04002F99 RID: 12185
		internal global::AcpUI.AcpXamDataPresenter ExpanderSwitchesRotaryControl;

		// Token: 0x04002F9A RID: 12186
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchRotaryControlButtonName_A22903_Col;

		// Token: 0x04002F9B RID: 12187
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchRotaryControlButtonBCO_A22906_Col;

		// Token: 0x04002F9C RID: 12188
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchGeneralRotaryControl_A8984_Col;

		// Token: 0x04002F9D RID: 12189
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchRotaryControlButtonKey_A22905_Col;

		// Token: 0x04002F9E RID: 12190
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesRotaryControlSRecView;

		// Token: 0x04002F9F RID: 12191
		internal global::System.Windows.Controls.Grid gridExpanderSwitchesRotaryControlSRecView;

		// Token: 0x04002FA0 RID: 12192
		internal global::AcpUI.AcpLabel SwitchRotaryControlButtonName_A22903;

		// Token: 0x04002FA1 RID: 12193
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchRotaryControlButtonName_A22903;

		// Token: 0x04002FA2 RID: 12194
		internal global::AcpUI.AcpLabel LblSwitchRotaryControlButtonName_A22903;

		// Token: 0x04002FA3 RID: 12195
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchRotaryControlButtonName_A22903;

		// Token: 0x04002FA4 RID: 12196
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchRotaryControlButtonName_A22903;

		// Token: 0x04002FA5 RID: 12197
		internal global::AcpUI.AcpLabel SwitchRotaryControlButtonName_A22903Comp;

		// Token: 0x04002FA6 RID: 12198
		internal global::AcpUI.AcpComboBox SwitchRotaryControlButtonBCO_A22906;

		// Token: 0x04002FA7 RID: 12199
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchRotaryControlButtonBCO_A22906;

		// Token: 0x04002FA8 RID: 12200
		internal global::AcpUI.AcpLabel LblSwitchRotaryControlButtonBCO_A22906;

		// Token: 0x04002FA9 RID: 12201
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchRotaryControlButtonBCO_A22906;

		// Token: 0x04002FAA RID: 12202
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchRotaryControlButtonBCO_A22906;

		// Token: 0x04002FAB RID: 12203
		internal global::AcpUI.AcpLabel SwitchRotaryControlButtonBCO_A22906Comp;

		// Token: 0x04002FAC RID: 12204
		internal global::AcpUI.AcpComboBox SwitchGeneralRotaryControl_A8984;

		// Token: 0x04002FAD RID: 12205
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchGeneralRotaryControl_A8984;

		// Token: 0x04002FAE RID: 12206
		internal global::AcpUI.AcpLabel LblSwitchGeneralRotaryControl_A8984;

		// Token: 0x04002FAF RID: 12207
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchGeneralRotaryControl_A8984;

		// Token: 0x04002FB0 RID: 12208
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchGeneralRotaryControl_A8984;

		// Token: 0x04002FB1 RID: 12209
		internal global::AcpUI.AcpLabel SwitchGeneralRotaryControl_A8984Comp;

		// Token: 0x04002FB2 RID: 12210
		internal global::AcpUI.AcpTextBox SwitchRotaryControlButtonKey_A22905;

		// Token: 0x04002FB3 RID: 12211
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchRotaryControlButtonKey_A22905;

		// Token: 0x04002FB4 RID: 12212
		internal global::AcpUI.AcpLabel LblSwitchRotaryControlButtonKey_A22905;

		// Token: 0x04002FB5 RID: 12213
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchRotaryControlButtonKey_A22905;

		// Token: 0x04002FB6 RID: 12214
		internal global::AcpUI.AcpLabel SwitchRotaryControlButtonKey_A22905Comp;

		// Token: 0x04002FB7 RID: 12215
		internal global::AcpUI.AcpExpander ExpanderSwitchesConventionalSwitches;

		// Token: 0x04002FB8 RID: 12216
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSwitchesConventionalSwitchesConcentricSwitch;

		// Token: 0x04002FB9 RID: 12217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002FBA RID: 12218
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002FBB RID: 12219
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002FBC RID: 12220
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002FBD RID: 12221
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002FBE RID: 12222
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition1_A7734Comp;

		// Token: 0x04002FBF RID: 12223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002FC0 RID: 12224
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002FC1 RID: 12225
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002FC2 RID: 12226
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002FC3 RID: 12227
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002FC4 RID: 12228
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition2_A7735Comp;

		// Token: 0x04002FC5 RID: 12229
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSwitchesConventionalSwitchesToggleSwitch;

		// Token: 0x04002FC6 RID: 12230
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002FC7 RID: 12231
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002FC8 RID: 12232
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002FC9 RID: 12233
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002FCA RID: 12234
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002FCB RID: 12235
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition3_A7737Comp;

		// Token: 0x04002FCC RID: 12236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002FCD RID: 12237
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002FCE RID: 12238
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002FCF RID: 12239
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002FD0 RID: 12240
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002FD1 RID: 12241
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition4_A21530Comp;

		// Token: 0x04002FD2 RID: 12242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition5_A21531;

		// Token: 0x04002FD3 RID: 12243
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition5_A21531;

		// Token: 0x04002FD4 RID: 12244
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition5_A21531;

		// Token: 0x04002FD5 RID: 12245
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition5_A21531;

		// Token: 0x04002FD6 RID: 12246
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition5_A21531;

		// Token: 0x04002FD7 RID: 12247
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition5_A21531Comp;

		// Token: 0x04002FD8 RID: 12248
		internal global::AcpUI.AcpExpander ExpanderSwitchesTrunkingSwitches;

		// Token: 0x04002FD9 RID: 12249
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSwitchesTrunkingSwitchesConcentricSwitch;

		// Token: 0x04002FDA RID: 12250
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04002FDB RID: 12251
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04002FDC RID: 12252
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04002FDD RID: 12253
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04002FDE RID: 12254
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04002FDF RID: 12255
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchesPosition1_A9466Comp;

		// Token: 0x04002FE0 RID: 12256
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04002FE1 RID: 12257
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04002FE2 RID: 12258
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04002FE3 RID: 12259
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04002FE4 RID: 12260
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04002FE5 RID: 12261
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchesPosition2_A9467Comp;

		// Token: 0x04002FE6 RID: 12262
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSwitchesTrunkingSwitchesToggleSwitch;

		// Token: 0x04002FE7 RID: 12263
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04002FE8 RID: 12264
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04002FE9 RID: 12265
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04002FEA RID: 12266
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04002FEB RID: 12267
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04002FEC RID: 12268
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchesPosition3_A9468Comp;

		// Token: 0x04002FED RID: 12269
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04002FEE RID: 12270
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04002FEF RID: 12271
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04002FF0 RID: 12272
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04002FF1 RID: 12273
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04002FF2 RID: 12274
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchesPosition4_A21534Comp;

		// Token: 0x04002FF3 RID: 12275
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchesPosition5_A21535;

		// Token: 0x04002FF4 RID: 12276
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchesPosition5_A21535;

		// Token: 0x04002FF5 RID: 12277
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchesPosition5_A21535;

		// Token: 0x04002FF6 RID: 12278
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchesPosition5_A21535;

		// Token: 0x04002FF7 RID: 12279
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchesPosition5_A21535;

		// Token: 0x04002FF8 RID: 12280
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchesPosition5_A21535Comp;

		// Token: 0x04002FF9 RID: 12281
		internal global::AcpUI.AcpExpander ExpanderSwitchesConventionalSwitchTable;

		// Token: 0x04002FFA RID: 12282
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSwitchesConventionalSwitchTableTable;

		// Token: 0x04002FFB RID: 12283
		internal global::System.Windows.Controls.Grid ExpanderSwitchesConventionalSwitchTableGrid;

		// Token: 0x04002FFC RID: 12284
		internal global::System.Windows.Controls.Grid ExpanderSwitchesConventionalSwitchTableTableGrid;

		// Token: 0x04002FFD RID: 12285
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesConventionalSwitchTableTableTableView;

		// Token: 0x04002FFE RID: 12286
		internal global::AcpUI.AcpXamDataPresenter ExpanderSwitchesConventionalSwitchTableTable;

		// Token: 0x04002FFF RID: 12287
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePositionsQuantity_A19654_Col;

		// Token: 0x04003000 RID: 12288
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePosition1Feature_A19655_Col;

		// Token: 0x04003001 RID: 12289
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePosition2Feature_A19656_Col;

		// Token: 0x04003002 RID: 12290
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePosition3Feature_A19657_Col;

		// Token: 0x04003003 RID: 12291
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePosition4Feature_A19658_Col;

		// Token: 0x04003004 RID: 12292
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchTablePosition5Feature_A19717_Col;

		// Token: 0x04003005 RID: 12293
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchConventionalSwitchKey_A21293_Col;

		// Token: 0x04003006 RID: 12294
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesConventionalSwitchTableTableSRecView;

		// Token: 0x04003007 RID: 12295
		internal global::System.Windows.Controls.Grid gridExpanderSwitchesConventionalSwitchTableTableSRecView;

		// Token: 0x04003008 RID: 12296
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x04003009 RID: 12297
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x0400300A RID: 12298
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x0400300B RID: 12299
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x0400300C RID: 12300
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x0400300D RID: 12301
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePositionsQuantity_A19654Comp;

		// Token: 0x0400300E RID: 12302
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x0400300F RID: 12303
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x04003010 RID: 12304
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x04003011 RID: 12305
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x04003012 RID: 12306
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x04003013 RID: 12307
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePosition1Feature_A19655Comp;

		// Token: 0x04003014 RID: 12308
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04003015 RID: 12309
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04003016 RID: 12310
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04003017 RID: 12311
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04003018 RID: 12312
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04003019 RID: 12313
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePosition2Feature_A19656Comp;

		// Token: 0x0400301A RID: 12314
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x0400301B RID: 12315
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x0400301C RID: 12316
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x0400301D RID: 12317
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x0400301E RID: 12318
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x0400301F RID: 12319
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePosition3Feature_A19657Comp;

		// Token: 0x04003020 RID: 12320
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04003021 RID: 12321
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04003022 RID: 12322
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04003023 RID: 12323
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04003024 RID: 12324
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04003025 RID: 12325
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePosition4Feature_A19658Comp;

		// Token: 0x04003026 RID: 12326
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x04003027 RID: 12327
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x04003028 RID: 12328
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x04003029 RID: 12329
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x0400302A RID: 12330
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x0400302B RID: 12331
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchTablePosition5Feature_A19717Comp;

		// Token: 0x0400302C RID: 12332
		internal global::AcpUI.AcpTextBox SwitchConventionalSwitchKey_A21293;

		// Token: 0x0400302D RID: 12333
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchKey_A21293;

		// Token: 0x0400302E RID: 12334
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchKey_A21293;

		// Token: 0x0400302F RID: 12335
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchKey_A21293;

		// Token: 0x04003030 RID: 12336
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchKey_A21293Comp;

		// Token: 0x04003031 RID: 12337
		internal global::AcpUI.AcpExpander ExpanderSwitchesTrunkingSwitchTable;

		// Token: 0x04003032 RID: 12338
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSwitchesTrunkingSwitchTableTable;

		// Token: 0x04003033 RID: 12339
		internal global::System.Windows.Controls.Grid ExpanderSwitchesTrunkingSwitchTableGrid;

		// Token: 0x04003034 RID: 12340
		internal global::System.Windows.Controls.Grid ExpanderSwitchesTrunkingSwitchTableTableGrid;

		// Token: 0x04003035 RID: 12341
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesTrunkingSwitchTableTableTableView;

		// Token: 0x04003036 RID: 12342
		internal global::AcpUI.AcpXamDataPresenter ExpanderSwitchesTrunkingSwitchTableTable;

		// Token: 0x04003037 RID: 12343
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePositionsQuantity_A21003_Col;

		// Token: 0x04003038 RID: 12344
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePosition1Feature_A21004_Col;

		// Token: 0x04003039 RID: 12345
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePosition2Feature_A21005_Col;

		// Token: 0x0400303A RID: 12346
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePosition3Feature_A21006_Col;

		// Token: 0x0400303B RID: 12347
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePosition4Feature_A21007_Col;

		// Token: 0x0400303C RID: 12348
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchTablePosition5Feature_A21008_Col;

		// Token: 0x0400303D RID: 12349
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchTrunkingSwitchKey_A21294_Col;

		// Token: 0x0400303E RID: 12350
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesTrunkingSwitchTableTableSRecView;

		// Token: 0x0400303F RID: 12351
		internal global::System.Windows.Controls.Grid gridExpanderSwitchesTrunkingSwitchTableTableSRecView;

		// Token: 0x04003040 RID: 12352
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x04003041 RID: 12353
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x04003042 RID: 12354
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x04003043 RID: 12355
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x04003044 RID: 12356
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x04003045 RID: 12357
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePositionsQuantity_A21003Comp;

		// Token: 0x04003046 RID: 12358
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x04003047 RID: 12359
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x04003048 RID: 12360
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x04003049 RID: 12361
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x0400304A RID: 12362
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x0400304B RID: 12363
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePosition1Feature_A21004Comp;

		// Token: 0x0400304C RID: 12364
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x0400304D RID: 12365
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x0400304E RID: 12366
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x0400304F RID: 12367
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x04003050 RID: 12368
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x04003051 RID: 12369
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePosition2Feature_A21005Comp;

		// Token: 0x04003052 RID: 12370
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x04003053 RID: 12371
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x04003054 RID: 12372
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x04003055 RID: 12373
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x04003056 RID: 12374
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x04003057 RID: 12375
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePosition3Feature_A21006Comp;

		// Token: 0x04003058 RID: 12376
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x04003059 RID: 12377
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x0400305A RID: 12378
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x0400305B RID: 12379
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x0400305C RID: 12380
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x0400305D RID: 12381
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePosition4Feature_A21007Comp;

		// Token: 0x0400305E RID: 12382
		internal global::AcpUI.AcpComboBox SwitchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x0400305F RID: 12383
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x04003060 RID: 12384
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x04003061 RID: 12385
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x04003062 RID: 12386
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x04003063 RID: 12387
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchTablePosition5Feature_A21008Comp;

		// Token: 0x04003064 RID: 12388
		internal global::AcpUI.AcpTextBox SwitchTrunkingSwitchKey_A21294;

		// Token: 0x04003065 RID: 12389
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchTrunkingSwitchKey_A21294;

		// Token: 0x04003066 RID: 12390
		internal global::AcpUI.AcpLabel LblSwitchTrunkingSwitchKey_A21294;

		// Token: 0x04003067 RID: 12391
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchTrunkingSwitchKey_A21294;

		// Token: 0x04003068 RID: 12392
		internal global::AcpUI.AcpLabel SwitchTrunkingSwitchKey_A21294Comp;

		// Token: 0x04003069 RID: 12393
		internal global::AcpUI.AcpExpander ExpanderSwitchesMultiFunctionKnob;

		// Token: 0x0400306A RID: 12394
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSwitchesMFKAssignmentControl;

		// Token: 0x0400306B RID: 12395
		internal global::System.Windows.Controls.Grid ExpanderSwitchesMultiFunctionKnobGrid;

		// Token: 0x0400306C RID: 12396
		internal global::System.Windows.Controls.Grid ExpanderSwitchesMFKAssignmentControlGrid;

		// Token: 0x0400306D RID: 12397
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesMFKAssignmentControlTableView;

		// Token: 0x0400306E RID: 12398
		internal global::AcpUI.AcpXamDataPresenter ExpanderSwitchesMFKAssignmentControl;

		// Token: 0x0400306F RID: 12399
		internal global::Infragistics.Windows.DataPresenter.UnboundField SwitchMFKAssignmentControlName_A38529_Col;

		// Token: 0x04003070 RID: 12400
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlSwitchsMFKFeatureAssignment_A38514_Col;

		// Token: 0x04003071 RID: 12401
		internal global::AcpUI.AcpGroupBox ExpanderSwitchesMFKAssignmentControlSRecView;

		// Token: 0x04003072 RID: 12402
		internal global::System.Windows.Controls.Grid gridExpanderSwitchesMFKAssignmentControlSRecView;

		// Token: 0x04003073 RID: 12403
		internal global::AcpUI.AcpLabel SwitchMFKAssignmentControlName_A38529;

		// Token: 0x04003074 RID: 12404
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchMFKAssignmentControlName_A38529;

		// Token: 0x04003075 RID: 12405
		internal global::AcpUI.AcpLabel LblSwitchMFKAssignmentControlName_A38529;

		// Token: 0x04003076 RID: 12406
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchMFKAssignmentControlName_A38529;

		// Token: 0x04003077 RID: 12407
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchMFKAssignmentControlName_A38529;

		// Token: 0x04003078 RID: 12408
		internal global::AcpUI.AcpLabel SwitchMFKAssignmentControlName_A38529Comp;

		// Token: 0x04003079 RID: 12409
		internal global::AcpUI.AcpComboBox RadErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x0400307A RID: 12410
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x0400307B RID: 12411
		internal global::AcpUI.AcpLabel LblRadErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x0400307C RID: 12412
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x0400307D RID: 12413
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x0400307E RID: 12414
		internal global::AcpUI.AcpLabel RadErgoControlSwitchsMFKFeatureAssignment_A38514Comp;

		// Token: 0x0400307F RID: 12415
		private bool b;
	}
}
