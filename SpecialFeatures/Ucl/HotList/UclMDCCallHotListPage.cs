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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001DE RID: 478
	public class UclMDCCallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x001F9A30 File Offset: 0x001F7C30
		public UclMDCCallHotListPage()
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

		// Token: 0x06001725 RID: 5925 RVA: 0x001F9A68 File Offset: 0x001F7C68
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
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
					num2 = (short)1760559104;
					short num3 = num2;
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2212);
					num2 = (short)407699458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1628307461;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EB;
				case 2:
					goto IL_E6;
				case 3:
					goto IL_E6;
				case 4:
				{
					num2 = (short)78184439;
					short num4 = num2;
					num2 = (short)1288634359;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EB;
					default:
						num2 = (short)245825536;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)307888128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2212);
						num2 = (short)521601027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_15E;
				}
				goto IL_28;
				IL_E6:
				this.RecNavToolbarUclMDCCallHotList.MyRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num2 = (short)1825964033;
				if (num2 != 0)
				{
				}
				num2 = (short)1032585217;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15E:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2212);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclMDCCallHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclMDCCallHotList).SyncDataSources();
			return;
			IL_1EB:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclMDCCallHotList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclMDCCallHotList;
			num2 = (short)1082654724;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x001F9C6C File Offset: 0x001F7E6C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2006908928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)33882120;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)921501697;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarMDCCallHotListHotList.MyDataPresenter = this.MDCCallHotListDataPresenter;
						num = (short)1965555718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						num = (short)917110787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2F5;
					case 3:
						goto IL_3EF;
					case 4:
					{
						this.RecNavToolbarUclMDCCallHotList.ChildToolbars.Add(this.RecNavToolbarMDCCallHotListHotList);
						base.MyBaseRecNavToolbar = this.RecNavToolbarUclMDCCallHotList;
						object myRecordsetDataSource = this.RecNavToolbarUclMDCCallHotList.MyRecordsetDataSource;
						num = (short)80609280;
						short num3 = num;
						num = (short)170655753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)1481113605;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)161153028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_18E;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1018167296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)1491664897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_D6;
									}
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1293680643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1649082370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_118:
								num = (short)1953431558;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D6:
								goto IL_118;
							}
							IL_18E:
							goto IL_2B6;
						}
						finally
						{
							global::System.IDisposable disposable;
							switch (0)
							{
							case 0:
								break;
							default:
								for (;;)
								{
									IL_19D:
									switch (num2)
									{
									case 0:
										goto IL_258;
									case 1:
										if (disposable != null)
										{
											num = (short)558366722;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_25A;
									case 2:
									{
										num = (short)96161961;
										short num4 = num;
										num = (short)482365609;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1B8;
										default:
											num = (short)811401216;
											if (num != 0)
											{
											}
											disposable.Dispose();
											num = (short)1799225344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_1B0;
								}
								IL_258:
								IL_25A:
								goto EndFinally_9;
							}
							IL_1B0:
							disposable = (enumerator as global::System.IDisposable);
							IL_1B8:
							num = (short)2024144897;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_19D;
							EndFinally_9:;
						}
						goto IL_25B;
						IL_2B6:
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)138412034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_25B;
					case 7:
						if (obj != null)
						{
							num = (short)1384906752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 9:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)113508353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EF;
					}
					}
					IL_6C:
					if (!this.a)
					{
						num = (short)1921515524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_25B:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)571146245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EF:
					obj = null;
					obj = this.RecNavToolbarMDCCallHotListHotList.MyRecordsetDataSource;
					num = (short)1235091463;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F5:
				this.a();
				return;
			}
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x001FA0D4 File Offset: 0x001F82D4
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
						return;
					case 1:
						if (this.a)
						{
							num2 = (short)2040201217;
							if (num2 != 0)
							{
							}
							num2 = (short)1113325570;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)859872635;
						short num3 = num2;
						num2 = (short)318741883;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
						{
							num2 = (short)1535836160;
							if (num2 != 0)
							{
							}
							num2 = (short)275251200;
							short num4 = num2;
							base.OnUnloaded(sender, e);
							this.a = false;
							num2 = (short)726138880;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarMDCCallHotListHotList.DataContext = null;
			this.RecNavToolbarUclMDCCallHotList.DataContext = null;
			this.RecNavToolbarMDCCallHotListHotList.MyDataPresenter = null;
			this.RecNavToolbarUclMDCCallHotList.MyDataPresenter = null;
			IL_4C:
			num2 = (short)1280180225;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x001FA22C File Offset: 0x001F842C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1757937665;
			if (num != 0)
			{
			}
			num = (short)1562574848;
			short num2 = num;
			num = (short)1862793595;
			short num3 = num;
			num = (short)692189563;
			switch (num3 == num)
			{
			}
			num = (short)2016346112;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x001FA2D8 File Offset: 0x001F84D8
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)259915776;
			switch (num)
			{
			default:
			{
				num = (short)2015363080;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1482620931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ쮝쎟캡춫슭\udcaf缾\udbb3습펹쾻쪽", a_))
						{
							num = (short)719388677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)889257986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ펝장쒧용솭쒯ﺱ\uddb3억첷펻쪽貿ꯁ럃닅", a_))
						{
							num = (short)1335754752;
							short num3 = num;
							num = (short)1947074560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1581973517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)827654156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_225;
					case 5:
						myRecordsetDataSource = this.RecNavToolbarUclMDCCallHotList.MyRecordsetDataSource;
						num = (short)1271595025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1B7;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1712521220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 9:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::SpecialFeatures.Ucl.HotList.MDCCallHotList mdccallHotList = (global::SpecialFeatures.Ucl.HotList.MDCCallHotList)collectionView.CurrentItem;
						num = (short)633339914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)295370753;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Ucl.HotList.MDCCallHotList mdccallHotList;
						if (mdccallHotList != null)
						{
							num = (short)144637973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1276772367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)150077460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_24E;
					case 13:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarMDCCallHotListHotList.MyRecordsetDataSource;
						num = (short)78446611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_200;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1577517067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34D;
					}
					case 16:
						goto IL_179;
					case 17:
						if (myRecordsetDataSource != null)
						{
							num = (short)701300750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						num = (short)68616193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)797179913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 20:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)785866204;
							short num4 = num;
							num = (short)1627217372;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1455882240;
								if (num != 0)
								{
								}
								num = (short)1761017863;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						collectionView.MoveCurrentToFirst();
						num = (short)330039302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::SpecialFeatures.Ucl.HotList.MDCCallHotList mdccallHotList;
						collectionView.MoveCurrentTo(mdccallHotList);
						num = (short)2116616208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A4:
					if (!(A_0 is global::AcpUI.AcpRecNavToolbar))
					{
						return;
					}
					num = (short)715784210;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179:
				IL_1B7:
				goto IL_34D;
				IL_200:
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				return;
				IL_225:
				goto IL_34D;
				IL_24E:
				return;
				IL_34D:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x001FA76C File Offset: 0x001F896C
		private void a(object A_0)
		{
			short num = (short)131661825;
			if (num != 0)
			{
			}
			num = (short)1388707840;
			short num2 = num;
			num = (short)644037381;
			short num3 = num;
			num = (short)1722170117;
			switch (num3 == num)
			{
			}
			num = (short)1738014720;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x001FA814 File Offset: 0x001F8A14
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)727515139;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)674824196;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpBusinessLayer.Recordset)((global::SpecialFeatures.Ucl.Contact.UclContact)enumerator.Current).MDCCallList.EmbeddedRecset).RefreshKeyMap();
								num2 = (short)2042363906;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_148;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 4:
								num2 = (short)1622867969;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_C3:
							num2 = (short)1947009024;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C1:
							goto IL_C3;
						}
						IL_148:
						return;
					}
					finally
					{
						num2 = (short)1647640577;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1B3;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_17E;
								}
								continue;
							case 2:
								goto IL_197;
							}
							IL_17E:
							if (enumerator != null)
							{
								num2 = (short)113377282;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1B3;
							IL_197:
							enumerator.Dispose();
							num2 = (short)65142784;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1B3:
							num2 = (short)1295050969;
							short num3 = num2;
							num2 = (short)858187993;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_197;
							default:
								goto IL_1E9;
							}
						}
						IL_1E9:
						num2 = (short)1652621312;
						if (num2 != 0)
						{
						}
					}
					goto IL_200;
				case 1:
					if (uclContactRecset != null)
					{
						num2 = (short)1592393730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)1336934401;
					if (num2 != 0)
					{
					}
					goto IL_200;
				}
				goto IL_1C;
				IL_200:
				num2 = (short)91291648;
				short num4 = num2;
				enumerator = uclContactRecset.GetEnumerator();
				num2 = (short)771031040;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
			num2 = (short)40697857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x001FAA80 File Offset: 0x001F8C80
		private void HLinkMDCCallHotListClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1569790109;
			short num2 = num;
			num = (short)245831837;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1854668800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2061303809;
			if (num != 0)
			{
			}
			num = (short)1271267328;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x001FAB30 File Offset: 0x001F8D30
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			if (this.b)
			{
				short num = (short)1618730607;
				short num2 = num;
				num = (short)52878959;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B4;
				case 1:
					break;
				default:
				{
					num = (short)767033344;
					short num3 = num;
					break;
				}
				}
				num = (short)453115905;
				if (num != 0)
				{
				}
				num = (short)1868693504;
				if (num != 0)
				{
				}
				return;
			}
			IL_B4:
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂎ슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮튰\udcb2\ud8b4잶횸햺\ud8bc톾뗀ꛄꛆꗈꟊ﷎뿒볔ꓖ귘ﻚ苠賢诤臦胨質飬鷮郰蟲鳴飶韸퓺闼郾甀漂氄理紈␊砌氎紐縒焔琖稘稚焜猞䤠䰢儤䬦䀨堪夬弮倰吲倴ᤶ䄸娺值匾", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x001FAC14 File Offset: 0x001F8E14
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1793392641;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_298;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)574881793;
					if (num != 0)
					{
					}
					num = (short)2130313216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_3A5;
				case 2:
					goto IL_417;
				case 3:
				case 4:
					goto IL_46C;
				case 5:
					goto IL_38B;
				case 6:
					goto IL_14E;
				case 7:
					goto IL_2AA;
				case 8:
					goto IL_29D;
				case 9:
					goto IL_106;
				case 10:
					goto IL_1FB;
				case 11:
					goto IL_340;
				case 12:
					goto IL_2B7;
				case 13:
					goto IL_31C;
				case 14:
					goto IL_35A;
				case 15:
					goto IL_37E;
				case 16:
					goto IL_24D;
				case 17:
					goto IL_2F5;
				case 18:
					goto IL_302;
				case 19:
					goto IL_3FD;
				case 20:
					goto IL_3E3;
				case 21:
					goto IL_1EE;
				case 22:
					goto IL_F9;
				case 23:
					goto IL_3D6;
				case 24:
					goto IL_398;
				case 25:
					goto IL_30F;
				case 26:
					goto IL_43B;
				case 27:
					goto IL_EC;
				case 28:
					goto IL_172;
				case 29:
					goto IL_45F;
				case 30:
					goto IL_2D1;
				case 31:
					goto IL_34D;
				case 32:
					goto IL_12A;
				case 33:
					goto IL_2C4;
				case 34:
					goto IL_208;
				case 35:
					goto IL_3F0;
				case 36:
					goto IL_196;
				case 37:
					goto IL_40A;
				case 38:
					goto IL_240;
				default:
					num = (short)1004929026;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EC:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F9:
			this.CallIdTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_106:
			this.RecNavToolbarMDCCallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarMDCCallHotListHotList.ModeClick += this.OnModeClick;
			return;
			IL_12A:
			this.LblCallID = (global::AcpUI.AcpLabel)target;
			this.LblCallID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14E:
			this.HLinkMDCCallHotList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMDCCallHotList.Click += this.HLinkMDCCallHotListClick;
			return;
			IL_172:
			this.LblContactAlias = (global::AcpUI.AcpLabel)target;
			this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_196:
			num = (short)962846358;
			short num3 = num;
			num = (short)825613974;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_30F:
				this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
				return;
			default:
				num = (short)511246336;
				if (num != 0)
				{
				}
				this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
				return;
			}
			IL_1EE:
			this.ContactAliasTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FB:
			this.GrpBoxExpanderPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_208:
			num = (short)2092957696;
			short num4 = num;
			this.CompGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_240:
			this.CallIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_24D:
			this.CpyBtnHotListAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_298:
			goto IL_46C;
			IL_29D:
			this.ExpMDCCallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_2AA:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_2B7:
			this.CVBtnMDCHotListAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C4:
			this.RtdBtnCallID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D1:
			this.CallID = (global::AcpUI.AcpComboBox)target;
			this.CallID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F5:
			this.TxtBoxHotListAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_302:
			this.GridFrame = (global::System.Windows.Controls.Grid)target;
			return;
			IL_31C:
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
			this.LblHotListAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_340:
			this.StdGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_34D:
			this.CVBtnCallID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_35A:
			this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxHotListAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37E:
			this.CompGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_38B:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_398:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A5:
			((global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_3D6:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E3:
			this.MDCCallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3F0:
			this.CopyButtonContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FD:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_40A:
			this.CopyButtonCallID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_417:
			this.RecNavToolbarUclMDCCallHotList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarUclMDCCallHotList.ModeClick += this.OnModeClick;
			return;
			IL_43B:
			this.ContactAlias = (global::AcpUI.AcpComboBox)target;
			this.ContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45F:
			this.RtdBtnContactAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46C:
			this.b = true;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x001FB094 File Offset: 0x001F9294
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1550188545;
			if (num != 0)
			{
			}
			num = (short)1511391234;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_75;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
				{
					num = (short)33479108;
					short num3 = num;
					num = (short)1612372420;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						num = (short)1703149568;
						if (num != 0)
						{
						}
						if (connectionId != 4)
						{
							num = (short)1509490689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					}
					break;
				}
				}
				IL_5C:
				if (connectionId != 3)
				{
					num = (short)1889402880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_75:
				num = (short)1461452800;
				short num4 = num;
				num = (short)2053832707;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13B:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000BD3 RID: 3027
		private bool a;

		// Token: 0x04000BD4 RID: 3028
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarUclMDCCallHotList;

		// Token: 0x04000BD5 RID: 3029
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000BD6 RID: 3030
		internal global::System.Windows.Documents.Hyperlink HLinkMDCCallHotList;

		// Token: 0x04000BD7 RID: 3031
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000BD8 RID: 3032
		internal global::AcpUI.AcpExpander ExpMDCCallHotList;

		// Token: 0x04000BD9 RID: 3033
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarMDCCallHotListHotList;

		// Token: 0x04000BDA RID: 3034
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPseudo0;

		// Token: 0x04000BDB RID: 3035
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderColumn;

		// Token: 0x04000BDC RID: 3036
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMDCHotListAlias;

		// Token: 0x04000BDD RID: 3037
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000BDE RID: 3038
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000BDF RID: 3039
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderColumn;

		// Token: 0x04000BE0 RID: 3040
		internal global::AcpUI.AcpCopyButton CpyBtnHotListAlias;

		// Token: 0x04000BE1 RID: 3041
		internal global::AcpUI.AcpViewOnlyCtrl TxtBoxHotListAliasComp;

		// Token: 0x04000BE2 RID: 3042
		internal global::System.Windows.Controls.Grid GridFrame;

		// Token: 0x04000BE3 RID: 3043
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000BE4 RID: 3044
		internal global::AcpUI.AcpXamDataPresenter MDCCallHotListDataPresenter;

		// Token: 0x04000BE5 RID: 3045
		internal global::Infragistics.Windows.DataPresenter.UnboundField ContactAliasTable_Col;

		// Token: 0x04000BE6 RID: 3046
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallIdTable_Col;

		// Token: 0x04000BE7 RID: 3047
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000BE8 RID: 3048
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000BE9 RID: 3049
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000BEA RID: 3050
		internal global::AcpUI.AcpComboBox ContactAlias;

		// Token: 0x04000BEB RID: 3051
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000BEC RID: 3052
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000BED RID: 3053
		internal global::AcpUI.AcpRtdButton RtdBtnContactAlias;

		// Token: 0x04000BEE RID: 3054
		internal global::AcpUI.AcpComboBox CallID;

		// Token: 0x04000BEF RID: 3055
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallID;

		// Token: 0x04000BF0 RID: 3056
		internal global::AcpUI.AcpLabel LblCallID;

		// Token: 0x04000BF1 RID: 3057
		internal global::AcpUI.AcpRtdButton RtdBtnCallID;

		// Token: 0x04000BF2 RID: 3058
		internal global::System.Windows.Controls.Grid CompGridGeneralGrp;

		// Token: 0x04000BF3 RID: 3059
		internal global::AcpUI.AcpCopyButton CopyButtonContactAlias;

		// Token: 0x04000BF4 RID: 3060
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000BF5 RID: 3061
		internal global::AcpUI.AcpCopyButton CopyButtonCallID;

		// Token: 0x04000BF6 RID: 3062
		internal global::AcpUI.AcpViewOnlyCtrl CallIDComp;

		// Token: 0x04000BF7 RID: 3063
		private bool b;
	}
}
