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
using ConstraintHelper;
using ControlHeadGraphicView;
using Infragistics.Windows.DataPresenter;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003D3 RID: 979
	public class PageControlHeadO2 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008B64 RID: 35684 RVA: 0x00826920 File Offset: 0x00824B20
		public PageControlHeadO2()
		{
			try
			{
				this.InitializeComponent();
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				this.myO2GraphicView.MFKEmergencyAccess = (global::ConstraintHelper.UtilityMack.IsMobile() && radioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value);
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00826998 File Offset: 0x00824B98
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1648885760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				for (;;)
				{
					IL_27:
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3E2;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO2O2.MyDataPresenter = this.ExpanderControlHeadO2O2;
						num = (short)1701707776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (obj != null)
						{
							num = (short)119734278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_425;
					case 3:
						if (obj != null)
						{
							num = (short)698810380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34E;
					case 4:
						goto IL_34E;
					case 5:
						try
						{
							num = (short)412614661;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)199426051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)222887938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1086980100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)2023882758;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)128516096;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E6;
									}
									continue;
								case 6:
									goto IL_1A3;
								}
								IL_E8:
								num = (short)12255233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6:
								goto IL_E8;
							}
							IL_1A3:
							goto IL_37F;
						}
						finally
						{
							num = (short)635688658;
							short num3 = num;
							num = (short)1552471762;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_210;
							default:
								num = (short)309198848;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_210;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1FD:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)905314306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)51052544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_264;
								case 2:
									goto IL_262;
								}
								goto IL_210;
							}
							IL_262:
							IL_264:
							goto EndFinally_10;
							IL_210:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1007943681;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1FD;
							EndFinally_10:;
						}
						goto IL_265;
						IL_37F:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1933246474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.MyDataPresenter = this.ExpanderControlHeadO2O2MFKAssignmentControl;
						num = (short)1555234824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (obj != null)
						{
							num = (short)913702913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					case 8:
						goto IL_425;
					case 9:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadO2O2.MyRecordsetDataSource;
						num = (short)401342471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_3A6;
					case 11:
						if (!this.a)
						{
							num = (short)1404502025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46E;
					case 12:
						goto IL_265;
					}
					goto IL_62;
					IL_265:
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadO2O2NavigationControlsTable;
					num = (short)2013396993;
					if (num != 0)
					{
					}
					num = (short)1060044804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34E:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1982595077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E2:
					obj = this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.MyRecordsetDataSource;
					num = (short)823263234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_425:
					obj = this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.MyRecordsetDataSource;
					num = (short)1828323331;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3A6:
				IL_46E:
				num = (short)1781334016;
				short num4 = num;
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_62:
				this.PreOnLoaded(sender, e);
				num = (short)989462539;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00826E70 File Offset: 0x00825070
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1998520321;
			if (num != 0)
			{
			}
			num = (short)860944272;
			short num2 = num;
			num = (short)1302329232;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8E;
			default:
				num = (short)1175191552;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_7C:
				switch (num3)
				{
				case 0:
					goto IL_13A;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)2052194304;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.a)
					{
						num = (short)14745601;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				}
				goto IL_8E;
			}
			IL_13A:
			IL_13C:
			num = (short)1551630336;
			short num4 = num;
			return;
			IL_8E:
			this.PreOnUnloaded(sender, e);
			this.RecNavToolbarExpanderControlHeadO2O2.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO2O2.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.MyDataPresenter = null;
			num = (short)1967063042;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00826FE4 File Offset: 0x008251E4
		public override void SetDataContext()
		{
			short num = (short)26869781;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)919797767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10721].EmbeddedRecset != null)
					{
						num = (short)302514181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 2:
					num = (short)842399774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)252444681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)411369484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)775749652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10721].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl).SyncDataSources();
					num = (short)704315405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_384;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10722] != null)
					{
						num = (short)90046496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1086128152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_331;
				case 10:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4115);
					num = (short)1065091103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_1F0;
				case 12:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4115);
					num = (short)1159790610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_D0;
				case 14:
					if (feature != null)
					{
						num = (short)635961346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					num = (short)144900099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					num = (short)1050094170;
					short num3 = num;
					num = (short)1331440218;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_331;
					default:
					{
						num = (short)512819200;
						if (num != 0)
						{
						}
						num = (short)1450770432;
						short num4 = num;
						goto IL_64C;
					}
					}
					break;
				}
				case 17:
					num = (short)1764950042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (feature != null)
					{
						num = (short)169082895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 19:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10723].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2).SyncDataSources();
					num = (short)393150480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					return;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 22:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10721] != null)
					{
						num = (short)1638006812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 23:
					num = (short)506265601;
					if (num != 0)
					{
					}
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10723] != null)
					{
						num = (short)2424849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 24:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)547815451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 25:
					if (feature != null)
					{
						num = (short)232980488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 26:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10723].EmbeddedRecset != null)
					{
						num = (short)402391059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 27:
					num = (short)390201366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)902823937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10722].EmbeddedRecset != null)
					{
						num = (short)394985478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 30:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)141950976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 31:
					goto IL_1F0;
				case 32:
					num = (short)721420317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)669581322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4115);
				num = (short)1103364107;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0:
				num = (short)1291911182;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F0:
				num = (short)648806404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_331:
				num = (short)818872343;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64C:
				num = (short)757596185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_384:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10722].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable).SyncDataSources();
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00827678 File Offset: 0x00825878
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 12;
			short num = (short)1120731136;
			switch (num)
			{
			default:
			{
				num = (short)1856503821;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)643366921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					}
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴듶雸闺觼跾渀漂䴄戆栈漊䈌㴎帐ℒ嬔瘖漘爚稜縞唠䨢䨤䤦樨䐪䌬嬮䌰尲头䐶洸娺弼匾⑀", a_))
						{
							num = (short)1467285518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)1077802945;
						short num3 = num;
						num = (short)1266939841;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24F;
						default:
							goto IL_3AB;
						}
						break;
					}
					case 3:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1917386769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1835073547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1904345091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					}
					case 6:
						num = (short)681377799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴듶雸闺觼跾渀漂䴄戆栈漊䈌㴎帐ℒ", a_))
						{
							num = (short)798949398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 8:
						goto IL_DA;
					case 9:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)149094420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_4D9;
					case 11:
					{
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1609039890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)362872832;
						short num4 = num;
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)53542920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴듶雸闺觼跾渀漂䴄戆栈漊䈌㴎帐ℒ堔儖刘娚渜氞䠠䐢䬤䨦䰨䔪夬氮帰崲䄴䔶嘸场", a_))
						{
							num = (short)1275265028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 14:
						num = (short)497811479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource3 = this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.MyRecordsetDataSource;
						num = (short)663027736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							goto IL_24F;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2009399306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_4D9;
					case 18:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.MyRecordsetDataSource;
						num = (short)1103888384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadO2O2.MyRecordsetDataSource;
						num = (short)1067450373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_DA;
					case 21:
						goto IL_2E4;
					case 22:
						num = (short)311164944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1858732033;
							if (num != 0)
							{
							}
							num = (short)2088501263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1514536981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (myRecordsetDataSource3 != null)
						{
							num = (short)137560066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_B2:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)515047430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_DA:
					num = (short)2055667713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24F:
					num = (short)1185611795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D9:
					num = (short)492568588;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E4:
				return;
				IL_3AB:
				num = (short)535363584;
				if (num != 0)
				{
				}
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner)collectionView3.CurrentItem;
				collectionView3.MoveCurrentTo(item3);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00827C0C File Offset: 0x00825E0C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)441450496;
			short num2 = num;
			num = (short)407273447;
			short num3 = num;
			num = (short)262111207;
			switch (num3 == num)
			{
			}
			num = (short)429719552;
			if (num != 0)
			{
			}
			num = (short)2139553793;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00827CBC File Offset: 0x00825EBC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)547160064;
			short num2 = num;
			num = (short)431862536;
			short num3 = num;
			num = (short)287159048;
			switch (num3 == num)
			{
			}
			num = (short)424607745;
			if (num != 0)
			{
			}
			num = (short)675348480;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00827D6C File Offset: 0x00825F6C
		internal void OnExpanderControlHeadO2O2Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1589096668;
			short num2 = num;
			num = (short)1495904476;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_66;
			default:
				num = (short)1744568320;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner item;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_11F;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO2O2.SyncDataSources();
					num = (short)1510080513;
					if (num != 0)
					{
					}
					num = (short)2025062400;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1277034497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_121;
				}
				goto IL_66;
			}
			IL_11F:
			IL_121:
			num = (short)1543241728;
			short num4 = num;
			this.RecNavToolbarExpanderControlHeadO2O2.TableMode = false;
			return;
			IL_66:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO2O2.MyRecordsetDataSource;
			num = (short)1132199938;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00827ED0 File Offset: 0x008260D0
		internal void OnExpanderControlHeadO2O2MFKAssignmentControlClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)334071862;
			short num2 = num;
			num = (short)1123059766;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_67;
			default:
				num = (short)1580597248;
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
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner item;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_125;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.SyncDataSources();
					num = (short)887422976;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)767164417;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_127;
				}
				goto IL_67;
			}
			IL_125:
			IL_127:
			num = (short)799408128;
			short num4 = num;
			this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.TableMode = false;
			return;
			IL_67:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.MyRecordsetDataSource;
			num = (short)663552001;
			if (num != 0)
			{
			}
			num = (short)1661272066;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x0082803C File Offset: 0x0082623C
		internal void OnExpanderControlHeadO2O2NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1207697409;
			if (num != 0)
			{
			}
			num = (short)1920722335;
			short num2 = num;
			num = (short)807921055;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_91;
			default:
				num = (short)2004418560;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				break;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner item;
			for (;;)
			{
				IL_7F:
				switch (num3)
				{
				case 0:
					goto IL_124;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.SyncDataSources();
					num = (short)228720640;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)987299841;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126;
				}
				goto IL_91;
			}
			IL_124:
			IL_126:
			num = (short)286851072;
			short num4 = num;
			this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.TableMode = false;
			return;
			IL_91:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.MyRecordsetDataSource;
			num = (short)750125058;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x008281A4 File Offset: 0x008263A4
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1491271680;
			short num2 = num;
			num = (short)2041269211;
			short num3 = num;
			num = (short)1158368219;
			switch (num3 == num)
			{
			}
			num = (short)326565888;
			if (num != 0)
			{
			}
			num = (short)2069233665;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00828254 File Offset: 0x00826454
		private void PreOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)715784192;
			short num2 = num;
			num = (short)2061047796;
			short num3 = num;
			num = (short)441915380;
			switch (num3 == num)
			{
			}
			num = (short)1673920512;
			if (num != 0)
			{
			}
			num = (short)1005453313;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x00828304 File Offset: 0x00826504
		private void b()
		{
			short num = (short)1121135774;
			short num2 = num;
			num = (short)1422470302;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C2:
				num = (short)1805254657;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged -= this.OnAppInfoPropertyChanged;
				num = (short)1006764032;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1005977600;
				short num4 = num;
				num = (short)170655744;
				if (num != 0)
				{
				}
				num = (short)1679818754;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_C2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				IL_A4:
				if (this.a)
				{
					break;
				}
				num = (short)61210625;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x0082842C File Offset: 0x0082662C
		private void a()
		{
			short num = (short)1568030342;
			short num2 = num;
			num = (short)1535262342;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C1:
				num = (short)884015105;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged += this.OnAppInfoPropertyChanged;
				num = (short)1781530624;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)585564160;
				short num4 = num;
				num = (short)1223557120;
				if (num != 0)
				{
				}
				num = (short)812253186;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_C1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				IL_A4:
				if (this.a)
				{
					break;
				}
				num = (short)871235585;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x00828554 File Offset: 0x00826754
		private void OnAppInfoPropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1075314688;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)694453650;
				short num3 = num;
				num = (short)809141650;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_158;
				case 1:
					break;
				default:
				{
					num = (short)1168244736;
					short num4 = num;
					break;
				}
				}
				num = (short)1348468736;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					continue;
				case 1:
					IL_158:
					goto IL_E8;
				case 2:
					if (A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("鷓믕꣗뗙껛ꫝ꿟鋡臣铥觧黩藫臭黯뇱鯳鯵裷雹駻諽旿昁", a_))
					{
						num = (short)1426391041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				case 3:
					goto IL_10B;
				case 4:
					num = (short)1206452226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B4:
				if (!(A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("郓룕볗闙곛믝鋟菡郣迥蟧蓩꿫臭鷯英飳鏵賷鿹飻", a_)))
				{
					num = (short)134217732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E8:
				this.myO2GraphicView.SetMenuItems();
				num = (short)716636163;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_15A:
			num = (short)1984823297;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x008286E4 File Offset: 0x008268E4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num = (short)73370964;
			short num2 = num;
			num = (short)735087956;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1395982336;
				if (num != 0)
				{
				}
				num = (short)2034827264;
				short num3 = num;
				if (this.b)
				{
					num = (short)1309868033;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5诧藩臫黭鿯鳱釳飵賷헹軻鿽擿欁欃⌅㨇㨉椋簍眏紑稓礕甗猙缛洝ԟအᐣ䔥䜧䐩䨫䜭圯䜱䘳圵䰷匹医倽漿⅁⭃⡅㱇㡉⍋≍⍏絑㝓㥕㙗⹙⹛ㅝ౟䝡噣噥gཀྵ൫੭啯䁱䑳孵嵷䡹䱻ᅽ뉿궁ﺉﺋﲏ晴ﲗ꺛낝\ud89f쎡즣쪥", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x008287C4 File Offset: 0x008269C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)667287553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_316;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)1682964480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_74B;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
					goto IL_945;
				case 9:
					goto IL_423;
				case 10:
					goto IL_4BD;
				case 11:
					goto IL_857;
				case 12:
					goto IL_71A;
				case 13:
					goto IL_52C;
				case 14:
					goto IL_87B;
				case 15:
					goto IL_73E;
				case 16:
					goto IL_636;
				case 17:
					goto IL_70D;
				case 18:
					goto IL_252;
				case 19:
					goto IL_4B0;
				case 20:
					goto IL_4FB;
				case 21:
					goto IL_328;
				case 22:
					goto IL_550;
				case 23:
					goto IL_602;
				case 24:
					goto IL_31B;
				case 25:
					goto IL_1EF;
				case 26:
					goto IL_3BE;
				case 27:
					goto IL_77C;
				case 28:
					goto IL_29D;
				case 29:
					goto IL_335;
				case 30:
					goto IL_3F2;
				case 31:
					goto IL_3E5;
				case 32:
					goto IL_4EE;
				case 33:
					goto IL_3D8;
				case 34:
					goto IL_5AA;
				case 35:
					goto IL_3B1;
				case 36:
					goto IL_8C9;
				case 37:
					goto IL_92B;
				case 38:
					goto IL_454;
				case 39:
					goto IL_8AF;
				case 40:
					goto IL_802;
				case 41:
					goto IL_46E;
				case 42:
					goto IL_373;
				case 43:
					goto IL_397;
				case 44:
					goto IL_61C;
				case 45:
					goto IL_6C2;
				case 46:
					goto IL_2F2;
				case 47:
					goto IL_66A;
				case 48:
					goto IL_65D;
				case 49:
					goto IL_68E;
				case 50:
					goto IL_430;
				case 51:
					goto IL_789;
				case 52:
					goto IL_6B5;
				case 53:
					goto IL_416;
				case 54:
					goto IL_8A2;
				case 55:
					goto IL_895;
				case 56:
					goto IL_69B;
				case 57:
					goto IL_629;
				case 58:
					goto IL_1E2;
				case 59:
					goto IL_290;
				case 60:
					goto IL_650;
				case 61:
					goto IL_60F;
				case 62:
					goto IL_700;
				case 63:
					goto IL_586;
				case 64:
					goto IL_3A4;
				case 65:
					goto IL_6CF;
				case 66:
					goto IL_826;
				case 67:
					goto IL_888;
				case 68:
					goto IL_276;
				case 69:
					goto IL_7DE;
				case 70:
					goto IL_1D5;
				case 71:
					goto IL_7BA;
				case 72:
					goto IL_643;
				case 73:
					goto IL_5DB;
				case 74:
					goto IL_461;
				case 75:
					goto IL_7AD;
				case 76:
					goto IL_508;
				case 77:
					goto IL_366;
				case 78:
					goto IL_8BC;
				case 79:
					goto IL_6F3;
				case 80:
					goto IL_1FC;
				case 81:
					goto IL_3CB;
				case 82:
					goto IL_5CE;
				case 83:
					goto IL_5E8;
				case 84:
					goto IL_47B;
				case 85:
					goto IL_2C1;
				case 86:
					goto IL_5F5;
				case 87:
					goto IL_342;
				case 88:
					goto IL_283;
				case 89:
					goto IL_91E;
				case 90:
					goto IL_4E1;
				case 91:
					goto IL_833;
				case 92:
					goto IL_6A8;
				case 93:
					goto IL_8FA;
				case 94:
					goto IL_2E5;
				case 95:
					goto IL_8ED;
				case 96:
					goto IL_938;
				default:
					num = (short)1717567490;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1D5:
			this.CVBtnRadErgoControlO2MFKFeatureAssignment_A41275 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E2:
			this.ExpanderControlHeadO2O2MFKAssignmentControl = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1EF:
			this.CHO2EmergencyButtonFeature_A41272_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FC:
			num = (short)426357516;
			short num3 = num;
			num = (short)1300935436;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5E8:
				this.ExpanderControlHeadO2O2NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
				return;
			default:
				num = (short)1911291904;
				if (num != 0)
				{
				}
				this.ExpanderControlHeadO2O2NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
				return;
			}
			IL_252:
			this.RecNavToolbarExpanderControlHeadO2O2 = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO2O2.ModeClick += this.OnModeClick;
			return;
			IL_276:
			this.O2MFKAssignmentControlName_A41274Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_283:
			this.RTDBtnO2UpDownButtonName_A41277 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_290:
			this.O2MFKAssignmentControlName_A41274_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_29D:
			this.CHO2EmergencyButtonName_A41270 = (global::AcpUI.AcpLabel)target;
			this.CHO2EmergencyButtonName_A41270.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C1:
			this.O2UpDownButtonName_A41277 = (global::AcpUI.AcpLabel)target;
			this.O2UpDownButtonName_A41277.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E5:
			this.RTDBtnRadErgoControlO2UpDownButton_A41278 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F2:
			this.ExpanderControlHeadO2O2MultiFunctionKnob = (global::AcpUI.AcpExpander)target;
			return;
			IL_316:
			goto IL_945;
			IL_31B:
			this.CHO2EmergencyButtonBCO_A41271_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_328:
			this.ExpanderControlHeadO2O2TableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_335:
			this.CVBtnCHO2EmergencyButtonName_A41270 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_342:
			this.LblO2UpDownButtonName_A41277 = (global::AcpUI.AcpLabel)target;
			this.LblO2UpDownButtonName_A41277.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_366:
			this.ExpanderControlHeadO2O2NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_373:
			this.LblCHO2EmergencyButtonFeature_A41272 = (global::AcpUI.AcpLabel)target;
			this.LblCHO2EmergencyButtonFeature_A41272.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_397:
			this.RTDBtnCHO2EmergencyButtonFeature_A41272 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A4:
			this.CVBtnO2MFKAssignmentControlName_A41274 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B1:
			this.CVBtnCHO2EmergencyButtonBCO_A41271 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BE:
			this.ExpanderControlHeadO2O2SRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3CB:
			this.O2UpDownButtonName_A41277_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3D8:
			this.CHO2EmergencyButtonName_A41270Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E5:
			this.RTDBtnCHO2EmergencyButtonName_A41270 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F2:
			this.LblCHO2EmergencyButtonName_A41270 = (global::AcpUI.AcpLabel)target;
			this.LblCHO2EmergencyButtonName_A41270.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_416:
			this.CpyBtnRadErgoControlO2MFKButtonPress_A42217 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_423:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_430:
			this.LblRadErgoControlO2MFKButtonPress_A42217 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO2MFKButtonPress_A42217.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_454:
			this.CpyBtnCHO2EmergencyButtonBCO_A41271 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_461:
			this.RadErgoControlO2MFKFeatureAssignment_A41275Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_46E:
			this.CVBtnCHO2EmergencyButtonFeature_A41272 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_47B:
			num = (short)1760559104;
			short num4 = num;
			this.gridExpanderControlHeadO2O2NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4B0:
			this.ExpanderControlHeadO2O2GeneralExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4BD:
			this.HLinkControlHeadO2GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO2GraphicalView.Click += this.HLinkClick;
			return;
			IL_4E1:
			this.O2UpDownButtonName_A41277Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4EE:
			this.CpyBtnCHO2EmergencyButtonName_A41270 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4FB:
			this.ExpanderControlHeadO2O2Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_508:
			this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_52C:
			this.HLinkO2NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO2NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_550:
			num = (short)2081685505;
			if (num != 0)
			{
			}
			this.ExpanderControlHeadO2O2 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_586:
			this.O2MFKAssignmentControlName_A41274 = (global::AcpUI.AcpLabel)target;
			this.O2MFKAssignmentControlName_A41274.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5AA:
			this.CHO2EmergencyButtonBCO_A41271 = (global::AcpUI.AcpComboBox)target;
			this.CHO2EmergencyButtonBCO_A41271.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5CE:
			this.RadErgoControlO2UpDownButton_A41278_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5DB:
			this.CpyBtnRadErgoControlO2MFKFeatureAssignment_A41275 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5F5:
			this.CVBtnO2UpDownButtonName_A41277 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_602:
			this.CHO2EmergencyButtonName_A41270_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_60F:
			this.ExpanderControlHeadO2O2MFKAssignmentControlSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_61C:
			this.CpyBtnCHO2EmergencyButtonFeature_A41272 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_629:
			this.ExpanderControlHeadO2O2MFKAssignmentControlTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_636:
			this.myO2GraphicView = (global::ControlHeadGraphicView.O2GraphicView)target;
			return;
			IL_643:
			this.RTDBtnRadErgoControlO2MFKFeatureAssignment_A41275 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_650:
			this.RadErgoControlO2MFKFeatureAssignment_A41275_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_65D:
			this.GrpBoxExpanderControlHeadO2O2MultiFunctionKnobPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_66A:
			this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl.ModeClick += this.OnModeClick;
			return;
			IL_68E:
			this.CVBtnRadErgoControlO2MFKButtonPress_A42217 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_69B:
			this.ExpanderControlHeadO2O2MFKAssignmentControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6A8:
			this.CVBtnRadErgoControlO2UpDownButton_A41278 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6B5:
			this.RTDBtnRadErgoControlO2MFKButtonPress_A42217 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6C2:
			this.CHO2EmergencyButtonFeature_A41272Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6CF:
			this.LblO2MFKAssignmentControlName_A41274 = (global::AcpUI.AcpLabel)target;
			this.LblO2MFKAssignmentControlName_A41274.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6F3:
			this.ExpanderControlHeadO2O2NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_700:
			this.gridExpanderControlHeadO2O2MFKAssignmentControlSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_70D:
			this.ExpanderControlHeadO2O2GeneralExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_71A:
			this.HLinkO2MultiFunctionKnob = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO2MultiFunctionKnob.Click += this.HLinkClick;
			return;
			IL_73E:
			this.ExpanderControlHeadO2GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_74B:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.PageControlHeadO2)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.PageControlHeadO2)target).Unloaded += this.OnUnloaded;
			return;
			IL_77C:
			this.gridExpanderControlHeadO2O2SRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_789:
			this.RadErgoControlO2MFKButtonPress_A42217 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO2MFKButtonPress_A42217.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7AD:
			this.ExpanderControlHeadO2O2NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_7BA:
			this.LblRadErgoControlO2MFKFeatureAssignment_A41275 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO2MFKFeatureAssignment_A41275.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7DE:
			this.RadErgoControlO2MFKFeatureAssignment_A41275 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO2MFKFeatureAssignment_A41275.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_802:
			this.CHO2EmergencyButtonFeature_A41272 = (global::AcpUI.AcpComboBox)target;
			this.CHO2EmergencyButtonFeature_A41272.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_826:
			this.RTDBtnO2MFKAssignmentControlName_A41274 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_833:
			this.RadErgoControlO2UpDownButton_A41278 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO2UpDownButton_A41278.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_857:
			this.HLinkO2GeneralExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO2GeneralExpander.Click += this.HLinkClick;
			return;
			IL_87B:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_888:
			this.CpyBtnO2MFKAssignmentControlName_A41274 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_895:
			this.ExpanderControlHeadO2O2MultiFunctionKnobGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8A2:
			this.RadErgoControlO2MFKButtonPress_A42217Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8AF:
			this.CHO2EmergencyButtonBCO_A41271Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8BC:
			this.ExpanderControlHeadO2O2NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8C9:
			this.LblCHO2EmergencyButtonBCO_A41271 = (global::AcpUI.AcpLabel)target;
			this.LblCHO2EmergencyButtonBCO_A41271.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8ED:
			this.CpyBtnRadErgoControlO2UpDownButton_A41278 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8FA:
			this.LblRadErgoControlO2UpDownButton_A41278 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO2UpDownButton_A41278.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_91E:
			this.CpyBtnO2UpDownButtonName_A41277 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92B:
			this.RTDBtnCHO2EmergencyButtonBCO_A41271 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_938:
			this.RadErgoControlO2UpDownButton_A41278Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_945:
			this.b = true;
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x00829120 File Offset: 0x00827320
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
			{
				short num = (short)1682717404;
				short num2 = num;
				num = (short)414005980;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2131427328;
					if (num != 0)
					{
					}
					num = (short)1307574272;
					short num3 = num;
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 7:
			{
				short num = (short)1395195905;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
		}

		// Token: 0x040042E4 RID: 17124
		private bool a;

		// Token: 0x040042E5 RID: 17125
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040042E6 RID: 17126
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO2GraphicalView;

		// Token: 0x040042E7 RID: 17127
		internal global::System.Windows.Documents.Hyperlink HLinkO2GeneralExpander;

		// Token: 0x040042E8 RID: 17128
		internal global::System.Windows.Documents.Hyperlink HLinkO2MultiFunctionKnob;

		// Token: 0x040042E9 RID: 17129
		internal global::System.Windows.Documents.Hyperlink HLinkO2NavigationControlsExpander;

		// Token: 0x040042EA RID: 17130
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040042EB RID: 17131
		internal global::AcpUI.AcpExpander ExpanderControlHeadO2GraphicalView;

		// Token: 0x040042EC RID: 17132
		internal global::ControlHeadGraphicView.O2GraphicView myO2GraphicView;

		// Token: 0x040042ED RID: 17133
		internal global::AcpUI.AcpExpander ExpanderControlHeadO2O2GeneralExpander;

		// Token: 0x040042EE RID: 17134
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO2O2;

		// Token: 0x040042EF RID: 17135
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2GeneralExpanderGrid;

		// Token: 0x040042F0 RID: 17136
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2Grid;

		// Token: 0x040042F1 RID: 17137
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2TableView;

		// Token: 0x040042F2 RID: 17138
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO2O2;

		// Token: 0x040042F3 RID: 17139
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO2EmergencyButtonName_A41270_Col;

		// Token: 0x040042F4 RID: 17140
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO2EmergencyButtonBCO_A41271_Col;

		// Token: 0x040042F5 RID: 17141
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO2EmergencyButtonFeature_A41272_Col;

		// Token: 0x040042F6 RID: 17142
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2SRecView;

		// Token: 0x040042F7 RID: 17143
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO2O2SRecView;

		// Token: 0x040042F8 RID: 17144
		internal global::AcpUI.AcpLabel CHO2EmergencyButtonName_A41270;

		// Token: 0x040042F9 RID: 17145
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO2EmergencyButtonName_A41270;

		// Token: 0x040042FA RID: 17146
		internal global::AcpUI.AcpLabel LblCHO2EmergencyButtonName_A41270;

		// Token: 0x040042FB RID: 17147
		internal global::AcpUI.AcpRtdButton RTDBtnCHO2EmergencyButtonName_A41270;

		// Token: 0x040042FC RID: 17148
		internal global::AcpUI.AcpCopyButton CpyBtnCHO2EmergencyButtonName_A41270;

		// Token: 0x040042FD RID: 17149
		internal global::AcpUI.AcpLabel CHO2EmergencyButtonName_A41270Comp;

		// Token: 0x040042FE RID: 17150
		internal global::AcpUI.AcpComboBox CHO2EmergencyButtonBCO_A41271;

		// Token: 0x040042FF RID: 17151
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO2EmergencyButtonBCO_A41271;

		// Token: 0x04004300 RID: 17152
		internal global::AcpUI.AcpLabel LblCHO2EmergencyButtonBCO_A41271;

		// Token: 0x04004301 RID: 17153
		internal global::AcpUI.AcpRtdButton RTDBtnCHO2EmergencyButtonBCO_A41271;

		// Token: 0x04004302 RID: 17154
		internal global::AcpUI.AcpCopyButton CpyBtnCHO2EmergencyButtonBCO_A41271;

		// Token: 0x04004303 RID: 17155
		internal global::AcpUI.AcpLabel CHO2EmergencyButtonBCO_A41271Comp;

		// Token: 0x04004304 RID: 17156
		internal global::AcpUI.AcpComboBox CHO2EmergencyButtonFeature_A41272;

		// Token: 0x04004305 RID: 17157
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO2EmergencyButtonFeature_A41272;

		// Token: 0x04004306 RID: 17158
		internal global::AcpUI.AcpLabel LblCHO2EmergencyButtonFeature_A41272;

		// Token: 0x04004307 RID: 17159
		internal global::AcpUI.AcpRtdButton RTDBtnCHO2EmergencyButtonFeature_A41272;

		// Token: 0x04004308 RID: 17160
		internal global::AcpUI.AcpCopyButton CpyBtnCHO2EmergencyButtonFeature_A41272;

		// Token: 0x04004309 RID: 17161
		internal global::AcpUI.AcpLabel CHO2EmergencyButtonFeature_A41272Comp;

		// Token: 0x0400430A RID: 17162
		internal global::AcpUI.AcpExpander ExpanderControlHeadO2O2MultiFunctionKnob;

		// Token: 0x0400430B RID: 17163
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO2O2MFKAssignmentControl;

		// Token: 0x0400430C RID: 17164
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderControlHeadO2O2MultiFunctionKnobPseudo0;

		// Token: 0x0400430D RID: 17165
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO2MFKButtonPress_A42217;

		// Token: 0x0400430E RID: 17166
		internal global::AcpUI.AcpLabel LblRadErgoControlO2MFKButtonPress_A42217;

		// Token: 0x0400430F RID: 17167
		internal global::AcpUI.AcpComboBox RadErgoControlO2MFKButtonPress_A42217;

		// Token: 0x04004310 RID: 17168
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO2MFKButtonPress_A42217;

		// Token: 0x04004311 RID: 17169
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO2MFKButtonPress_A42217;

		// Token: 0x04004312 RID: 17170
		internal global::AcpUI.AcpLabel RadErgoControlO2MFKButtonPress_A42217Comp;

		// Token: 0x04004313 RID: 17171
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2MultiFunctionKnobGrid;

		// Token: 0x04004314 RID: 17172
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2MFKAssignmentControlGrid;

		// Token: 0x04004315 RID: 17173
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2MFKAssignmentControlTableView;

		// Token: 0x04004316 RID: 17174
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO2O2MFKAssignmentControl;

		// Token: 0x04004317 RID: 17175
		internal global::Infragistics.Windows.DataPresenter.UnboundField O2MFKAssignmentControlName_A41274_Col;

		// Token: 0x04004318 RID: 17176
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO2MFKFeatureAssignment_A41275_Col;

		// Token: 0x04004319 RID: 17177
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2MFKAssignmentControlSRecView;

		// Token: 0x0400431A RID: 17178
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO2O2MFKAssignmentControlSRecView;

		// Token: 0x0400431B RID: 17179
		internal global::AcpUI.AcpLabel O2MFKAssignmentControlName_A41274;

		// Token: 0x0400431C RID: 17180
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO2MFKAssignmentControlName_A41274;

		// Token: 0x0400431D RID: 17181
		internal global::AcpUI.AcpLabel LblO2MFKAssignmentControlName_A41274;

		// Token: 0x0400431E RID: 17182
		internal global::AcpUI.AcpRtdButton RTDBtnO2MFKAssignmentControlName_A41274;

		// Token: 0x0400431F RID: 17183
		internal global::AcpUI.AcpCopyButton CpyBtnO2MFKAssignmentControlName_A41274;

		// Token: 0x04004320 RID: 17184
		internal global::AcpUI.AcpLabel O2MFKAssignmentControlName_A41274Comp;

		// Token: 0x04004321 RID: 17185
		internal global::AcpUI.AcpComboBox RadErgoControlO2MFKFeatureAssignment_A41275;

		// Token: 0x04004322 RID: 17186
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO2MFKFeatureAssignment_A41275;

		// Token: 0x04004323 RID: 17187
		internal global::AcpUI.AcpLabel LblRadErgoControlO2MFKFeatureAssignment_A41275;

		// Token: 0x04004324 RID: 17188
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO2MFKFeatureAssignment_A41275;

		// Token: 0x04004325 RID: 17189
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO2MFKFeatureAssignment_A41275;

		// Token: 0x04004326 RID: 17190
		internal global::AcpUI.AcpLabel RadErgoControlO2MFKFeatureAssignment_A41275Comp;

		// Token: 0x04004327 RID: 17191
		internal global::AcpUI.AcpExpander ExpanderControlHeadO2O2NavigationControlsExpander;

		// Token: 0x04004328 RID: 17192
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO2O2NavigationControlsTable;

		// Token: 0x04004329 RID: 17193
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2NavigationControlsExpanderGrid;

		// Token: 0x0400432A RID: 17194
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO2O2NavigationControlsTableGrid;

		// Token: 0x0400432B RID: 17195
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2NavigationControlsTableTableView;

		// Token: 0x0400432C RID: 17196
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO2O2NavigationControlsTable;

		// Token: 0x0400432D RID: 17197
		internal global::Infragistics.Windows.DataPresenter.UnboundField O2UpDownButtonName_A41277_Col;

		// Token: 0x0400432E RID: 17198
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO2UpDownButton_A41278_Col;

		// Token: 0x0400432F RID: 17199
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO2O2NavigationControlsTableSRecView;

		// Token: 0x04004330 RID: 17200
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO2O2NavigationControlsTableSRecView;

		// Token: 0x04004331 RID: 17201
		internal global::AcpUI.AcpLabel O2UpDownButtonName_A41277;

		// Token: 0x04004332 RID: 17202
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO2UpDownButtonName_A41277;

		// Token: 0x04004333 RID: 17203
		internal global::AcpUI.AcpLabel LblO2UpDownButtonName_A41277;

		// Token: 0x04004334 RID: 17204
		internal global::AcpUI.AcpRtdButton RTDBtnO2UpDownButtonName_A41277;

		// Token: 0x04004335 RID: 17205
		internal global::AcpUI.AcpCopyButton CpyBtnO2UpDownButtonName_A41277;

		// Token: 0x04004336 RID: 17206
		internal global::AcpUI.AcpLabel O2UpDownButtonName_A41277Comp;

		// Token: 0x04004337 RID: 17207
		internal global::AcpUI.AcpComboBox RadErgoControlO2UpDownButton_A41278;

		// Token: 0x04004338 RID: 17208
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO2UpDownButton_A41278;

		// Token: 0x04004339 RID: 17209
		internal global::AcpUI.AcpLabel LblRadErgoControlO2UpDownButton_A41278;

		// Token: 0x0400433A RID: 17210
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO2UpDownButton_A41278;

		// Token: 0x0400433B RID: 17211
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO2UpDownButton_A41278;

		// Token: 0x0400433C RID: 17212
		internal global::AcpUI.AcpLabel RadErgoControlO2UpDownButton_A41278Comp;

		// Token: 0x0400433D RID: 17213
		private bool b;
	}
}
