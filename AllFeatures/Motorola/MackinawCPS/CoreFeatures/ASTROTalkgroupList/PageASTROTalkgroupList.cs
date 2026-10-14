using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005DC RID: 1500
	public class PageASTROTalkgroupList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600CF1C RID: 53020 RVA: 0x00C0A318 File Offset: 0x00C08518
		public PageASTROTalkgroupList()
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

		// Token: 0x0600CF1D RID: 53021 RVA: 0x00C0A350 File Offset: 0x00C08550
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)825425920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				for (;;)
				{
					IL_28:
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)630259715;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)592707586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)1524563973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2D0;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_213;
									}
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)1468530689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)658046976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1025048580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_215:
								num = (short)949420038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_213:
								goto IL_215;
							}
							IL_2D0:
							goto IL_169;
						}
						finally
						{
							for (;;)
							{
								IL_2D5:
								switch (0)
								{
								case 0:
									goto IL_2F2;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2DF:
									switch (num2)
									{
									case 0:
										goto IL_395;
									case 1:
										disposable.Dispose();
										num = (short)1014169600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										num = (short)516726744;
										short num3 = num;
										num = (short)1092722648;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2D5;
										default:
											num = (short)1825701888;
											if (num != 0)
											{
											}
											if (disposable != null)
											{
												num = (short)1624637441;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_397;
										}
										break;
									}
									}
									break;
								}
								IL_2F2:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)552665090;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2DF;
							}
							IL_395:
							IL_397:;
						}
						goto IL_398;
						IL_169:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1126301697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_190;
					case 2:
						goto IL_DE;
					case 3:
						num = (short)2094399489;
						if (num != 0)
						{
						}
						if (!this.a)
						{
							num = (short)1720909824;
							short num4 = num;
							num = (short)668205062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					case 4:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.MyDataPresenter = this.ExpanderASTROTalkgroupListTalkgroupTable;
						num = (short)1678770178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						object obj;
						if (obj != null)
						{
							num = (short)640024580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE;
					}
					case 6:
					{
						this.RecNavToolbarPageASTROTalkgroupList.ChildToolbars.Add(this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable);
						object obj = null;
						obj = this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.MyRecordsetDataSource;
						num = (short)1012006917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4B;
					IL_DE:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1723072512;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_190:
				IL_398:
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_4B:
				this.PreOnLoaded(sender, e);
				num = (short)574160899;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x0600CF1E RID: 53022 RVA: 0x00C0A728 File Offset: 0x00C08928
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)489029633;
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
						return;
					case 1:
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)1334050816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2044827342;
						short num3 = num;
						num = (short)1749063374;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)790298624;
							if (num != 0)
							{
							}
							num = (short)971440128;
							short num4 = num;
							if (this.a)
							{
								num = (short)787349505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					}
					break;
				}
				IL_44:
				this.RecNavToolbarPageASTROTalkgroupList.DataContext = null;
				this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.DataContext = null;
				this.RecNavToolbarPageASTROTalkgroupList.MyDataPresenter = null;
				this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.MyDataPresenter = null;
				num = (short)1491140610;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x00C0A87C File Offset: 0x00C08A7C
		public override void SetDataContext()
		{
			short num = (short)23003138;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F9;
				case 1:
				{
					num = (short)44441297;
					short num3 = num;
					num = (short)1589255889;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
					{
						num = (short)1568604160;
						if (num != 0)
						{
						}
						feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2062);
						num = (short)1281032193;
						if (num != 0)
						{
						}
						num = (short)1954086912;
						short num4 = num;
						num = (short)1209401350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					goto IL_7C;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)405340161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageASTROTalkgroupList).MySecondaryRecordsetDataSource = null;
					num = (short)1271529479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_22B;
				case 6:
					if (feature != null)
					{
						num = (short)1294532613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_11E;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2062);
					num = (short)1396834304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1636171784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2062);
				num = (short)1886519299;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C:
				this.RecNavToolbarPageASTROTalkgroupList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1046020100;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F9:
				goto IL_7C;
			}
			IL_11E:
			return;
			IL_22B:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageASTROTalkgroupList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x00C0AABC File Offset: 0x00C08CBC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)1889206272;
			switch (num)
			{
			default:
			{
				num = (short)627048461;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1716649985;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_22A;
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙賛뿝蟟蟡ꗣ뗥볧룩ꏫ뫭釯黱鿳釵諷闹觻軽䳿欁眃爅", a_))
						{
							num = (short)523698182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙駛ꛝ郟菡諣若跧飩귫뷭ꓯꃱ믳ꋵ駷雹韻駽狿洁焃瘅䐇按缋稍䐏猑砓紕缗栙猛欝借瘡䔣䐥䐧伩", a_))
						{
							num = (short)1820852245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)2016935954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner;
						if (talkgroupTableInner != null)
						{
							num = (short)868810759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2100953102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2C2;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageASTROTalkgroupList.MyRecordsetDataSource;
						num = (short)1217724419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner;
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentTo(talkgroupTableInner);
						num = (short)1589837840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)908001289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)646250501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.MyRecordsetDataSource;
						num = (short)2070609935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)845611008;
						short num3 = num;
						global::System.Windows.Data.CollectionView collectionView;
						if (!collectionView.IsCurrentAfterLast)
						{
							collectionView.MoveCurrentToFirst();
							num = (short)2035548160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)317296080;
						short num4 = num;
						num = (short)2052165072;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3BB;
						default:
							num = (short)1348272128;
							if (num != 0)
							{
							}
							num = (short)671088662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						num = (short)1751842817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_297;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					case 14:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1672413204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_371;
					}
					case 15:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1122172947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 16:
						goto IL_1D0;
					case 17:
						goto IL_31A;
					case 18:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1526595601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner = (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner)collectionView.CurrentItem;
						num = (short)1178009604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)371851274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_3BB;
					case 22:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1186922508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_D2:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)789643275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_31A:
					num = (short)1894383618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BB:
					num = (short)1056374792;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D0:
				IL_22A:
				IL_297:
				goto IL_371;
				IL_2C2:
				return;
				IL_371:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x00C0AF74 File Offset: 0x00C09174
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1301020672;
			short num2 = num;
			num = (short)308816147;
			short num3 = num;
			num = (short)1864247571;
			switch (num3 == num)
			{
			}
			num = (short)722534401;
			if (num != 0)
			{
			}
			num = (short)94175232;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x00C0B028 File Offset: 0x00C09228
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)130351104;
			short num2 = num;
			num = (short)152454293;
			short num3 = num;
			num = (short)1516848277;
			switch (num3 == num)
			{
			}
			num = (short)1498480641;
			if (num != 0)
			{
			}
			num = (short)1095368704;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x00C0B0D8 File Offset: 0x00C092D8
		internal void OnExpanderASTROTalkgroupListTalkgroupTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)255601177;
			short num2 = num;
			num = (short)738732569;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_14C;
			case 1:
				break;
			default:
			{
				num = (short)1258291200;
				short num3 = num;
				break;
			}
			}
			num = (short)1506803713;
			if (num != 0)
			{
			}
			num = (short)352976896;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B7;
			}
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner item;
			for (;;)
			{
				IL_A5:
				switch (num4)
				{
				case 0:
					goto IL_14A;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num = (short)1689059330;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.SyncDataSources();
					num = (short)4390912;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_B7;
			}
			IL_14A:
			goto IL_14C;
			IL_B7:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.MyRecordsetDataSource;
			num = (short)372506625;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A5;
			IL_14C:
			this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.TableMode = false;
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x00C0B240 File Offset: 0x00C09440
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1595998208;
			short num2 = num;
			num = (short)325723337;
			short num3 = num;
			num = (short)1719477449;
			switch (num3 == num)
			{
			}
			num = (short)1354760192;
			if (num != 0)
			{
			}
			num = (short)1212874753;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x00C0B2F0 File Offset: 0x00C094F0
		private void a()
		{
			short num = (short)1605894144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int num5;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
				bool flag;
				bool value;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset = (astrotalkgroupListRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset;
						talkgroupTableInnerRecset.Permissions = (global::AcpCommonLib.Permissions)768;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = talkgroupTableInnerRecset.GetEnumerator();
						num = (short)1562902529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)35061760;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_204;
									}
									continue;
								case 1:
									num = (short)2136539138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_27C;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1365442561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.Permissions = (global::AcpCommonLib.Permissions)79;
									num = (short)97320963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_22C:
								num = (short)459407364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_204:
								goto IL_22C;
							}
							IL_27C:
							return;
						}
						finally
						{
							num = (short)1585239246;
							short num3 = num;
							num = (short)1986057422;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)839647232;
								if (num != 0)
								{
								}
								num = (short)1712652289;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_337;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2FF;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1038876672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2FF:
									if (enumerator == null)
									{
										break;
									}
									num = (short)190382082;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_337:
								break;
							}
						}
						goto IL_33A;
					case 2:
						goto IL_3C3;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						if (astrotalkgroupListRecset.Count > 0)
						{
							num = (short)318242816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						num = (short)1317994499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1445068800;
						short num4 = num;
						if (num5 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)265224199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33A;
					}
					case 6:
						flag = true;
						num = (short)882180107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_10C;
					case 8:
						goto IL_3C3;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
						num = (short)827129869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)703332353;
						if (num != 0)
						{
						}
						if (value || flag)
						{
							num = (short)1513029641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_10C;
					case 12:
						if (num5 != 15)
						{
							num = (short)1696137231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						if (astrotalkgroupListRecset != null)
						{
							num = (short)1315307524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						if ((zoneChannelAssignmentRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)1903362054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)286588936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1979711502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
					IL_10C:
					num = (short)608370698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					num = (short)2126381068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C3:
					num = (short)563347461;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6E:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
				value = features.RadWideFeaturesZoneCloneEnable_43130.Value;
				flag = false;
				num5 = 0;
				num = (short)1301610498;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x00C0B7C8 File Offset: 0x00C099C8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num = (short)1163256894;
			short num2 = num;
			num = (short)1988551742;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B2;
			case 1:
				break;
			default:
			{
				num = (short)2002518016;
				short num3 = num;
				break;
			}
			}
			num = (short)1891631104;
			if (num != 0)
			{
			}
			num = (short)1312948225;
			if (num != 0)
			{
			}
			if (this.b)
			{
				return;
			}
			IL_B2:
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺黼郾漀甂怄椆紈戊戌愎瀐缒〔┖⤘砚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲ᨴ嘶䨸伺似倾摀煂畄㍆⡈❊♌⡎⍐㱒⁔❖籘楚浜㍞ࡠၢᅤ䡦ࡨᡪᥬᵮṰݲᑴ᭶ቸᱺོၾ愈ﾊꎌﺒ璉", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600CF27 RID: 53031 RVA: 0x00C0B8AC File Offset: 0x00C09AAC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1347354625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_28E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						num = (short)109969408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					switch (connectionId)
					{
					case 1:
						goto IL_4B3;
					case 2:
						goto IL_3E0;
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
						goto IL_8C0;
					case 9:
						goto IL_7BB;
					case 10:
						goto IL_78A;
					case 11:
						goto IL_85E;
					case 12:
						goto IL_56F;
					case 13:
						goto IL_77D;
					case 14:
						goto IL_667;
					case 15:
						goto IL_45C;
					case 16:
						goto IL_1F8;
					case 17:
						goto IL_53E;
					case 18:
						goto IL_2B7;
					case 19:
						goto IL_61C;
					case 20:
						goto IL_57C;
					case 21:
						goto IL_293;
					case 22:
						goto IL_1C7;
					case 23:
						goto IL_34D;
					case 24:
						goto IL_7AE;
					case 25:
						goto IL_243;
					case 26:
						goto IL_2C4;
					case 27:
						goto IL_3AF;
					case 28:
						goto IL_38B;
					case 29:
						goto IL_531;
					case 30:
						goto IL_37E;
					case 31:
						goto IL_340;
					case 32:
						goto IL_7C8;
					case 33:
						goto IL_596;
					case 34:
						goto IL_882;
					case 35:
						goto IL_411;
					case 36:
						goto IL_42B;
					case 37:
						goto IL_30F;
					case 38:
						goto IL_302;
					case 39:
						goto IL_820;
					case 40:
						goto IL_26A;
					case 41:
						goto IL_636;
					case 42:
						goto IL_6DA;
					case 43:
						goto IL_732;
					case 44:
						goto IL_6CD;
					case 45:
						goto IL_404;
					case 46:
						goto IL_6E7;
					case 47:
						goto IL_725;
					case 48:
						goto IL_3D3;
					case 49:
						goto IL_7D5;
					case 50:
						goto IL_770;
					case 51:
						goto IL_1BA;
					case 52:
						goto IL_643;
					case 53:
						goto IL_236;
					case 54:
						goto IL_6A9;
					case 55:
						goto IL_629;
					case 56:
						goto IL_6F4;
					case 57:
						goto IL_31C;
					case 58:
						goto IL_589;
					case 59:
						goto IL_73F;
					case 60:
						goto IL_844;
					case 61:
						goto IL_21C;
					case 62:
						goto IL_1AD;
					case 63:
						goto IL_7FC;
					case 64:
						goto IL_7EF;
					case 65:
						goto IL_5C7;
					case 66:
						goto IL_41E;
					case 67:
						goto IL_69C;
					case 68:
						goto IL_562;
					case 69:
						goto IL_2DE;
					case 70:
						goto IL_7E2;
					case 71:
						goto IL_35A;
					case 72:
						goto IL_1EB;
					case 73:
						goto IL_763;
					case 74:
						goto IL_5BA;
					case 75:
						goto IL_5EB;
					case 76:
						goto IL_250;
					case 77:
						goto IL_438;
					case 78:
						goto IL_2D1;
					case 79:
						goto IL_229;
					case 80:
						goto IL_60F;
					case 81:
						goto IL_50D;
					case 82:
						goto IL_8B3;
					case 83:
						goto IL_701;
					case 84:
						goto IL_851;
					case 85:
						goto IL_25D;
					case 86:
						goto IL_8A6;
					default:
						num = (short)948764674;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_45C:
				num = (short)304098236;
				short num3 = num;
				num = (short)1751067580;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_490;
				}
			}
			IL_1AD:
			this.AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_1BA:
			this.gridExpanderASTROTalkgroupListTalkgroupTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1C7:
			this.AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EB:
			this.RTDBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F8:
			this.LblAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21C:
			this.CpyBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_229:
			this.CpyBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_236:
			this.CVBtnAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_243:
			this.AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_250:
			this.CVBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25D:
			this.CpyBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26A:
			this.ExpanderASTROTalkgroupListTalkgroupListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_28E:
			goto IL_8C0;
			IL_293:
			this.LblAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B7:
			this.CpyBtnAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C4:
			this.CVBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D1:
			this.RTDBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DE:
			this.AstTlkgrpLstTalkgroupListTalkgroupID_A9282 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.AstTlkgrpLstTalkgroupListTalkgroupID_A9282.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_302:
			this.ExpanderASTROTalkgroupListTalkgroupList = (global::AcpUI.AcpExpander)target;
			return;
			IL_30F:
			this.AstTlkgrpLstGeneralKMFProfileIndex_A8380Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31C:
			this.AstTlkgrpLstTalkgroupListDVRSWACNID_A40163 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.AstTlkgrpLstTalkgroupListDVRSWACNID_A40163.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_340:
			this.AstTlkgrpLstGeneralTalkgroupAlias_A9277Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34D:
			this.RTDBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35A:
			this.LblAstTlkgrpLstTalkgroupListTalkgroupID_A9282 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListTalkgroupID_A9282.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37E:
			this.CpyBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38B:
			this.AstTlkgrpLstGeneralTalkgroupAlias_A9277 = (global::AcpUI.AcpCheckBox)target;
			this.AstTlkgrpLstGeneralTalkgroupAlias_A9277.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AF:
			this.LblAstTlkgrpLstGeneralTalkgroupAlias_A9277 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstGeneralTalkgroupAlias_A9277.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D3:
			this.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3E0:
			this.RecNavToolbarPageASTROTalkgroupList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageASTROTalkgroupList.ModeClick += this.OnModeClick;
			return;
			IL_404:
			this.AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_411:
			this.RTDBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41E:
			this.RTDBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42B:
			this.CpyBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_438:
			this.LblAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_490:
			num = (short)1431306240;
			if (num != 0)
			{
			}
			this.CVBtnAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B3:
			num = (short)1320157184;
			short num4 = num;
			((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.PageASTROTalkgroupList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.PageASTROTalkgroupList)target).Unloaded += this.OnUnloaded;
			return;
			IL_50D:
			this.AstTlkgrpLstTalkgroupListKeySelectReference_A8366 = (global::AcpUI.AcpComboBox)target;
			this.AstTlkgrpLstTalkgroupListKeySelectReference_A8366.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_531:
			this.RTDBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_53E:
			this.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = (global::AcpUI.AcpTextBox)target;
			this.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_562:
			this.AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_56F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_57C:
			this.CVBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_589:
			this.CVBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_596:
			this.LblAstTlkgrpLstGeneralKMFProfileIndex_A8380 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstGeneralKMFProfileIndex_A8380.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BA:
			this.AstTlkgrpLstTalkgroupListTalkgroupID_A9282Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_5C7:
			this.LblAstTlkgrpLstTalkgroupListDVRSSystemID_A40162 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListDVRSSystemID_A40162.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5EB:
			this.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = (global::AcpUI.AcpComboBox)target;
			this.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_60F:
			this.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_61C:
			this.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_629:
			this.CpyBtnAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_636:
			this.ExpanderASTROTalkgroupListTalkgroupTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_643:
			this.AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = (global::AcpUI.AcpTextBox)target;
			this.AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_667:
			num = (short)883556353;
			if (num != 0)
			{
			}
			this.GrpBoxExpanderASTROTalkgroupListGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_69C:
			this.CpyBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6A9:
			this.LblAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6CD:
			this.AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6DA:
			this.ExpanderASTROTalkgroupListTalkgroupTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6E7:
			this.AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6F4:
			this.AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_701:
			this.LblAstTlkgrpLstTalkgroupListKeySelectReference_A8366 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListKeySelectReference_A8366.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_725:
			this.AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_732:
			this.ExpanderASTROTalkgroupListTalkgroupTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_73F:
			this.LblAstTlkgrpLstTalkgroupListDVRSWACNID_A40163 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstTalkgroupListDVRSWACNID_A40163.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_763:
			this.CpyBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_770:
			this.ExpanderASTROTalkgroupListTalkgroupTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_77D:
			this.ExpanderASTROTalkgroupListGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_78A:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_7AE:
			this.CpyBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7BB:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_7C8:
			this.CVBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D5:
			this.AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7E2:
			this.CVBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7EF:
			this.CVBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7FC:
			this.AstTlkgrpLstTalkgroupListDVRSSystemID_A40162 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.AstTlkgrpLstTalkgroupListDVRSSystemID_A40162.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_820:
			this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable.ModeClick += this.OnModeClick;
			return;
			IL_844:
			this.RTDBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_851:
			this.RTDBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_85E:
			this.HLinkTalkgroupList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTalkgroupList.Click += this.HLinkClick;
			return;
			IL_882:
			this.AstTlkgrpLstGeneralKMFProfileIndex_A8380 = (global::AcpUI.AcpComboBox)target;
			this.AstTlkgrpLstGeneralKMFProfileIndex_A8380.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A6:
			this.AstTlkgrpLstTalkgroupListKeySelectReference_A8366Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8B3:
			this.CVBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8C0:
			this.b = true;
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x00C0C180 File Offset: 0x00C0A380
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)747700224;
			short num2 = num;
			num = (short)1188765101;
			short num3 = num;
			num = (short)1672617389;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1140916224;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 3:
					num = (short)1891631105;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 4:
					((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 5:
					break;
				case 6:
					((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 7:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 8:
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				default:
					return;
				}
				break;
			}
			((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400654A RID: 25930
		private bool a;

		// Token: 0x0400654B RID: 25931
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageASTROTalkgroupList;

		// Token: 0x0400654C RID: 25932
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400654D RID: 25933
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400654E RID: 25934
		internal global::System.Windows.Documents.Hyperlink HLinkTalkgroupList;

		// Token: 0x0400654F RID: 25935
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04006550 RID: 25936
		internal global::AcpUI.AcpExpander ExpanderASTROTalkgroupListGeneral;

		// Token: 0x04006551 RID: 25937
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderASTROTalkgroupListGeneralPseudo0;

		// Token: 0x04006552 RID: 25938
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;

		// Token: 0x04006553 RID: 25939
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;

		// Token: 0x04006554 RID: 25940
		internal global::AcpUI.AcpTextBox AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;

		// Token: 0x04006555 RID: 25941
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;

		// Token: 0x04006556 RID: 25942
		internal global::AcpUI.AcpLabel AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Comp;

		// Token: 0x04006557 RID: 25943
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;

		// Token: 0x04006558 RID: 25944
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;

		// Token: 0x04006559 RID: 25945
		internal global::AcpUI.AcpTextBoxSpinner AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;

		// Token: 0x0400655A RID: 25946
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;

		// Token: 0x0400655B RID: 25947
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;

		// Token: 0x0400655C RID: 25948
		internal global::AcpUI.AcpLabel AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Comp;

		// Token: 0x0400655D RID: 25949
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x0400655E RID: 25950
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x0400655F RID: 25951
		internal global::AcpUI.AcpCheckBox AstTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x04006560 RID: 25952
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x04006561 RID: 25953
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x04006562 RID: 25954
		internal global::AcpUI.AcpCheckBox AstTlkgrpLstGeneralTalkgroupAlias_A9277Comp;

		// Token: 0x04006563 RID: 25955
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x04006564 RID: 25956
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x04006565 RID: 25957
		internal global::AcpUI.AcpComboBox AstTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x04006566 RID: 25958
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x04006567 RID: 25959
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x04006568 RID: 25960
		internal global::AcpUI.AcpLabel AstTlkgrpLstGeneralKMFProfileIndex_A8380Comp;

		// Token: 0x04006569 RID: 25961
		internal global::AcpUI.AcpExpander ExpanderASTROTalkgroupListTalkgroupList;

		// Token: 0x0400656A RID: 25962
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderASTROTalkgroupListTalkgroupTable;

		// Token: 0x0400656B RID: 25963
		internal global::System.Windows.Controls.Grid ExpanderASTROTalkgroupListTalkgroupListGrid;

		// Token: 0x0400656C RID: 25964
		internal global::System.Windows.Controls.Grid ExpanderASTROTalkgroupListTalkgroupTableGrid;

		// Token: 0x0400656D RID: 25965
		internal global::AcpUI.AcpGroupBox ExpanderASTROTalkgroupListTalkgroupTableTableView;

		// Token: 0x0400656E RID: 25966
		internal global::AcpUI.AcpXamDataPresenter ExpanderASTROTalkgroupListTalkgroupTable;

		// Token: 0x0400656F RID: 25967
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Col;

		// Token: 0x04006570 RID: 25968
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Col;

		// Token: 0x04006571 RID: 25969
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Col;

		// Token: 0x04006572 RID: 25970
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Col;

		// Token: 0x04006573 RID: 25971
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Col;

		// Token: 0x04006574 RID: 25972
		internal global::Infragistics.Windows.DataPresenter.UnboundField AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Col;

		// Token: 0x04006575 RID: 25973
		internal global::AcpUI.AcpGroupBox ExpanderASTROTalkgroupListTalkgroupTableSRecView;

		// Token: 0x04006576 RID: 25974
		internal global::System.Windows.Controls.Grid gridExpanderASTROTalkgroupListTalkgroupTableSRecView;

		// Token: 0x04006577 RID: 25975
		internal global::AcpUI.AcpTextBox AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;

		// Token: 0x04006578 RID: 25976
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;

		// Token: 0x04006579 RID: 25977
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;

		// Token: 0x0400657A RID: 25978
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;

		// Token: 0x0400657B RID: 25979
		internal global::AcpUI.AcpLabel AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278Comp;

		// Token: 0x0400657C RID: 25980
		internal global::AcpUI.AcpTextBoxCustomDecHex AstTlkgrpLstTalkgroupListDVRSWACNID_A40163;

		// Token: 0x0400657D RID: 25981
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163;

		// Token: 0x0400657E RID: 25982
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListDVRSWACNID_A40163;

		// Token: 0x0400657F RID: 25983
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163;

		// Token: 0x04006580 RID: 25984
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListDVRSWACNID_A40163;

		// Token: 0x04006581 RID: 25985
		internal global::AcpUI.AcpTextBoxCustomDecHex AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Comp;

		// Token: 0x04006582 RID: 25986
		internal global::AcpUI.AcpTextBoxCustomDecHex AstTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x04006583 RID: 25987
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x04006584 RID: 25988
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x04006585 RID: 25989
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x04006586 RID: 25990
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x04006587 RID: 25991
		internal global::AcpUI.AcpTextBoxCustomDecHex AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Comp;

		// Token: 0x04006588 RID: 25992
		internal global::AcpUI.AcpTextBoxSpinnerDecHex AstTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x04006589 RID: 25993
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x0400658A RID: 25994
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x0400658B RID: 25995
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x0400658C RID: 25996
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x0400658D RID: 25997
		internal global::AcpUI.AcpTextBoxDecHex AstTlkgrpLstTalkgroupListTalkgroupID_A9282Comp;

		// Token: 0x0400658E RID: 25998
		internal global::AcpUI.AcpComboBox AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x0400658F RID: 25999
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x04006590 RID: 26000
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x04006591 RID: 26001
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x04006592 RID: 26002
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x04006593 RID: 26003
		internal global::AcpUI.AcpLabel AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654Comp;

		// Token: 0x04006594 RID: 26004
		internal global::AcpUI.AcpComboBox AstTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x04006595 RID: 26005
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x04006596 RID: 26006
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x04006597 RID: 26007
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x04006598 RID: 26008
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x04006599 RID: 26009
		internal global::AcpUI.AcpLabel AstTlkgrpLstTalkgroupListKeySelectReference_A8366Comp;

		// Token: 0x0400659A RID: 26010
		private bool b;
	}
}
