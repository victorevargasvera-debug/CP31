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

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x0200024B RID: 587
	public class PagePersonnelAccountability : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600689C RID: 26780 RVA: 0x005D98F0 File Offset: 0x005D7AF0
		public PagePersonnelAccountability()
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

		// Token: 0x0600689D RID: 26781 RVA: 0x005D9928 File Offset: 0x005D7B28
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)5832704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					IL_1E:
					num = (short)921632771;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::AcpUI.AcpExpander acpExpander;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)607387651;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1115881473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_30F;
									case 2:
										if (!enumerator.MoveNext())
										{
											num = (short)326434816;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)1762787334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_254;
										}
										continue;
									case 4:
										base.Expanders.Add(acpExpander);
										num = (short)367853573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (acpExpander != null)
										{
											num = (short)1711144964;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									IL_256:
									num = (short)2137456642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_254:
									goto IL_256;
								}
								IL_30F:
								goto IL_162;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_331;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_31E:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1387659266;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_388;
									case 1:
										goto IL_386;
									case 2:
										disposable.Dispose();
										num = (short)1416626177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_331;
								}
								IL_386:
								IL_388:
								goto EndFinally_8;
								IL_331:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)723845120;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31E;
								EndFinally_8:;
							}
							goto IL_389;
							IL_162:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)2079784964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_82;
						case 2:
						{
							this.RecNavToolbarPagePersonnelAccountability.ChildToolbars.Add(this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable);
							object obj = null;
							obj = this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.MyRecordsetDataSource;
							num = (short)1605894149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_60;
							}
							continue;
						case 4:
							goto IL_189;
						case 5:
						{
							num = (short)130023425;
							if (num != 0)
							{
							}
							object obj;
							if (obj != null)
							{
								num = (short)1009909766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_82;
						}
						case 6:
						{
							num = (short)511221684;
							short num3 = num;
							num = (short)1684709300;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							default:
							{
								num = (short)1700134912;
								if (num != 0)
								{
								}
								object obj;
								global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
								this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.MyDataPresenter = this.ExpanderPersonnelAccountabilityPerAccListTable;
								num = (short)830996481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_60:
						if (!this.a)
						{
							num = (short)1523056642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
						IL_82:
						num = (short)1580531712;
						short num4 = num;
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1612775424;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_189:
				IL_389:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x005D9CF4 File Offset: 0x005D7EF4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
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
						num2 = (short)1045233664;
						short num3 = num2;
						if (this.a)
						{
							num2 = (short)502267906;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)1767768065;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1350945764;
						short num4 = num2;
						num2 = (short)22727652;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1287782400;
							if (num2 != 0)
							{
							}
							num2 = (short)1482031105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarPagePersonnelAccountability.DataContext = null;
				this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.DataContext = null;
				this.RecNavToolbarPagePersonnelAccountability.MyDataPresenter = null;
				this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.MyDataPresenter = null;
				num2 = (short)1683357696;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x005D9E48 File Offset: 0x005D8048
		public override void SetDataContext()
		{
			short num = (short)1971847171;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1491402753;
					if (num != 0)
					{
					}
					goto IL_A5;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1743781892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPagePersonnelAccountability).MySecondaryRecordsetDataSource = null;
					num = (short)1196949512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_236;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 4:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4176);
					num = (short)547553286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4176);
					num = (short)1358823431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (feature != null)
					{
						num = (short)2003959810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_A5;
				case 8:
					goto IL_14E;
				}
				IL_48:
				num = (short)379650048;
				short num3 = num;
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)958005253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4176);
				num = (short)748079446;
				short num4 = num;
				num = (short)1269877078;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)810418176;
					if (num != 0)
					{
					}
					num = (short)273022976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A5:
				this.RecNavToolbarPagePersonnelAccountability.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1514733569;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14E:
			return;
			IL_236:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPagePersonnelAccountability).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x005DA090 File Offset: 0x005D8290
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)725417984;
			switch (num)
			{
			default:
			{
				num = (short)834928644;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_2C7;
					case 1:
						num = (short)512491521;
						if (num != 0)
						{
						}
						num = (short)2079850499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1335754769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)2104098830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙賛뿝蟟蟡듣菥髧駩菫胭黯韱飳럵鯷駹鏻诽滿瘁攃搅愇昉攋稍椏", a_))
						{
							num = (short)575930381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 5:
						goto IL_246;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner;
						if (perAccListTableInner != null)
						{
							num = (short)87162901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)768540680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)541458434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)357564416;
							short num3 = num;
							num = (short)653066247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					}
					case 9:
						goto IL_26F;
					case 10:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.MyRecordsetDataSource;
						num = (short)93061138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)464912384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1712652298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)490405897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPagePersonnelAccountability.MyRecordsetDataSource;
						num = (short)1845952528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_1DA;
					case 15:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner = (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner)collectionView.CurrentItem;
						num = (short)1795620870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)2029322251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					}
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1866989573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)960757775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 19:
						goto IL_136;
					case 20:
						num = (short)704970764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner;
						collectionView.MoveCurrentTo(perAccListTableInner);
						num = (short)1098579987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙駛ꛝ郟菡諣若跧飩볫语苯臱鯳飵雷鿹郻뿽揿愁欃猅昇縉洋氍礏縑紓戕愗䨙礛氝感䄡䜣樥䄧天堫稭儯倱堳匵", a_))
						{
							num = (short)303955988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)346750977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2C7:
					num = (short)927924246;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_136:
				num = (short)1925735839;
				short num4 = num;
				num = (short)771122591;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_26F:
					return;
				default:
					num = (short)1834090496;
					if (num != 0)
					{
					}
					break;
				}
				IL_1DA:
				IL_246:
				IL_31E:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x005DA54C File Offset: 0x005D874C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1938188218;
			short num2 = num;
			num = (short)2046519226;
			switch (num2 == num)
			{
			default:
			{
				num = (short)88014848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)979173377;
			if (num != 0)
			{
			}
			num = (short)918683648;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x005DA600 File Offset: 0x005D8800
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)366113138;
			short num2 = num;
			num = (short)531984754;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1490812928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2028863489;
			if (num != 0)
			{
			}
			num = (short)2124939264;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x005DA6B0 File Offset: 0x005D88B0
		internal void OnExpanderPersonnelAccountabilityPerAccListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				object myRecordsetDataSource;
				short num2;
				global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner item;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (myRecordsetDataSource != null)
						{
							num2 = (short)1808334850;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_159;
					case 1:
						goto IL_157;
					case 2:
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.SyncDataSources();
						num2 = (short)1847758521;
						short num3 = num2;
						num2 = (short)2098302649;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)975044608;
							if (num2 != 0)
							{
							}
							num2 = (short)973275137;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				num2 = (short)418250753;
				if (num2 != 0)
				{
				}
				item = (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.MyRecordsetDataSource;
				num2 = (short)2026831872;
				short num4 = num2;
				num2 = (short)14155776;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_157:
			IL_159:
			this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.TableMode = false;
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x005DA824 File Offset: 0x005D8A24
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)1010140669;
			short num2 = num;
			num = (short)1414235645;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1569783808;
				if (num != 0)
				{
				}
				num = (short)500105217;
				if (num != 0)
				{
				}
				if (this.b)
				{
					num = (short)1180368896;
					short num3 = num;
					return;
				}
				break;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽狿持怃漅朇⼉㸋㸍甏怑猓礕瘗甙焛眝䌟儡ģᐥᠧ䤩䌫䀭嘯嬱匳䌵䨷嬹䠻圽⼿ⱁ歃㙅ⵇ㡉㽋⅍㹏㱑ㅓ㩕絗桙汛㽝͟šୣ፥٧ṩ൫౭᥯ṱᵳɵŷ啹౻᭽ﮓﶛﲝ즟캡춣튥톧蒩풫쾭\uddaf\udeb1", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x005DA904 File Offset: 0x005D8B04
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)205914112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2013947993;
					short num3 = num;
					num = (short)601647193;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_117;
					default:
						num = (short)836829185;
						if (num != 0)
						{
						}
						num = (short)425852928;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_216;
				case 2:
					num = (short)1374814209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A3;
				IL_117:
				num = (short)1129054210;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3:
				switch (connectionId)
				{
				case 1:
					goto IL_347;
				case 2:
					goto IL_309;
				case 3:
					goto IL_392;
				case 4:
					goto IL_169;
				case 5:
					goto IL_21B;
				case 6:
					goto IL_14F;
				case 7:
					goto IL_19D;
				case 8:
					goto IL_23F;
				case 9:
					goto IL_263;
				case 10:
					goto IL_32D;
				case 11:
					goto IL_1DB;
				case 12:
					goto IL_2A1;
				case 13:
					goto IL_2EF;
				case 14:
					goto IL_190;
				case 15:
					goto IL_142;
				case 16:
					goto IL_378;
				case 17:
					goto IL_2FC;
				case 18:
					goto IL_385;
				case 19:
					goto IL_135;
				case 20:
					goto IL_176;
				case 21:
					goto IL_294;
				case 22:
					goto IL_270;
				case 23:
					goto IL_15C;
				case 24:
					goto IL_1AA;
				case 25:
					goto IL_183;
				case 26:
					goto IL_33A;
				case 27:
					goto IL_1CE;
				}
				goto IL_117;
			}
			IL_135:
			this.RadioErgoConfigACReference_A42911_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_142:
			this.ExpanderPersonnelAccountabilityGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_14F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_15C:
			this.CVBtnRadioErgoConfigACReference_A42911 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_169:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_176:
			this.ExpanderPersonnelAccountabilityPerAccListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_183:
			this.RTDBtnRadioErgoConfigACReference_A42911 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_190:
			this.RadioErgoConfigACPAListAlertName_A42874Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19D:
			this.ExpanderPersonnelAccountabilityGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_1AA:
			this.LblRadioErgoConfigACReference_A42911 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACReference_A42911.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CE:
			this.RadioErgoConfigACReference_A42911Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DB:
			this.LblRadioErgoConfigACPAListAlertName_A42874 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACPAListAlertName_A42874.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_216:
			goto IL_392;
			IL_21B:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_23F:
			this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable.ModeClick += this.OnModeClick;
			return;
			IL_263:
			this.GrpBoxExpanderPersonnelAccountabilityGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_270:
			this.RadioErgoConfigACReference_A42911 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACReference_A42911.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_294:
			this.gridExpanderPersonnelAccountabilityPerAccListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2A1:
			num = (short)1163067392;
			short num4 = num;
			this.RadioErgoConfigACPAListAlertName_A42874 = (global::AcpUI.AcpTextBox)target;
			this.RadioErgoConfigACPAListAlertName_A42874.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EF:
			this.CpyBtnRadioErgoConfigACPAListAlertName_A42874 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FC:
			this.ExpanderPersonnelAccountabilityPerAccListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_309:
			this.RecNavToolbarPagePersonnelAccountability = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPagePersonnelAccountability.ModeClick += this.OnModeClick;
			return;
			IL_32D:
			this.CVBtnRadioErgoConfigACPAListAlertName_A42874 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33A:
			this.CpyBtnRadioErgoConfigACReference_A42911 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_347:
			((global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PagePersonnelAccountability)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PagePersonnelAccountability)target).Unloaded += this.OnUnloaded;
			return;
			IL_378:
			this.ExpanderPersonnelAccountabilityPerAccListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_385:
			this.ExpanderPersonnelAccountabilityPerAccListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_392:
			this.b = true;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x005DACAC File Offset: 0x005D8EAC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1346633728;
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
					goto IL_F2;
				case 2:
				{
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)1442281056;
					short num3 = num;
					num = (short)515929696;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
						num = (short)1579024384;
						if (num != 0)
						{
						}
						num = (short)17367041;
						if (num != 0)
						{
						}
						num = (short)2037579777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_31;
				IL_38:
				num = (short)648740866;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31:
				if (connectionId == 3)
				{
					goto IL_38;
				}
				return;
			}
			IL_F2:
			num = (short)79560704;
			short num4 = num;
		}

		// Token: 0x04002918 RID: 10520
		private bool a;

		// Token: 0x04002919 RID: 10521
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPagePersonnelAccountability;

		// Token: 0x0400291A RID: 10522
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400291B RID: 10523
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400291C RID: 10524
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400291D RID: 10525
		internal global::AcpUI.AcpExpander ExpanderPersonnelAccountabilityGeneral;

		// Token: 0x0400291E RID: 10526
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderPersonnelAccountabilityPerAccListTable;

		// Token: 0x0400291F RID: 10527
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPersonnelAccountabilityGeneralPseudo0;

		// Token: 0x04002920 RID: 10528
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACPAListAlertName_A42874;

		// Token: 0x04002921 RID: 10529
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACPAListAlertName_A42874;

		// Token: 0x04002922 RID: 10530
		internal global::AcpUI.AcpTextBox RadioErgoConfigACPAListAlertName_A42874;

		// Token: 0x04002923 RID: 10531
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACPAListAlertName_A42874;

		// Token: 0x04002924 RID: 10532
		internal global::AcpUI.AcpLabel RadioErgoConfigACPAListAlertName_A42874Comp;

		// Token: 0x04002925 RID: 10533
		internal global::System.Windows.Controls.Grid ExpanderPersonnelAccountabilityGeneralGrid;

		// Token: 0x04002926 RID: 10534
		internal global::System.Windows.Controls.Grid ExpanderPersonnelAccountabilityPerAccListTableGrid;

		// Token: 0x04002927 RID: 10535
		internal global::AcpUI.AcpGroupBox ExpanderPersonnelAccountabilityPerAccListTableTableView;

		// Token: 0x04002928 RID: 10536
		internal global::AcpUI.AcpXamDataPresenter ExpanderPersonnelAccountabilityPerAccListTable;

		// Token: 0x04002929 RID: 10537
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACReference_A42911_Col;

		// Token: 0x0400292A RID: 10538
		internal global::AcpUI.AcpGroupBox ExpanderPersonnelAccountabilityPerAccListTableSRecView;

		// Token: 0x0400292B RID: 10539
		internal global::System.Windows.Controls.Grid gridExpanderPersonnelAccountabilityPerAccListTableSRecView;

		// Token: 0x0400292C RID: 10540
		internal global::AcpUI.AcpComboBox RadioErgoConfigACReference_A42911;

		// Token: 0x0400292D RID: 10541
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACReference_A42911;

		// Token: 0x0400292E RID: 10542
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACReference_A42911;

		// Token: 0x0400292F RID: 10543
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACReference_A42911;

		// Token: 0x04002930 RID: 10544
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACReference_A42911;

		// Token: 0x04002931 RID: 10545
		internal global::AcpUI.AcpLabel RadioErgoConfigACReference_A42911Comp;

		// Token: 0x04002932 RID: 10546
		private bool b;
	}
}
