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

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051D RID: 1309
	public class PageRepeaterIDList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B15F RID: 45407 RVA: 0x00A462AC File Offset: 0x00A444AC
		public PageRepeaterIDList()
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

		// Token: 0x0600B160 RID: 45408 RVA: 0x00A462E4 File Offset: 0x00A444E4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1561001984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)863305729;
				if (num != 0)
				{
				}
				num = (short)869072897;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					object obj;
					switch (num2)
					{
					case 0:
						goto IL_27D;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 2:
						try
						{
							num = (short)1377763331;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1128529924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1004601349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_FB;
									}
									continue;
								case 4:
									goto IL_1B3;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)309133312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)929103873;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1627979778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_13E:
								num = (short)1062338566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FB:
								goto IL_13E;
							}
							IL_1B3:
							goto IL_2E7;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1D5;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1C2:
								switch (num2)
								{
								case 0:
									goto IL_27A;
								case 1:
									if (disposable != null)
									{
										num = (short)174981122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								case 2:
									for (;;)
									{
										disposable.Dispose();
										num = (short)538517439;
										short num3 = num;
										num = (short)97525695;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_24B;
										}
									}
									IL_24B:
									num = (short)173408256;
									if (num != 0)
									{
									}
									num = (short)1768620032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D5;
							}
							IL_27A:
							IL_27C:
							goto EndFinally_9;
							IL_1D5:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)848297985;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1C2;
							EndFinally_9:;
						}
						goto IL_27D;
						IL_2E7:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1629749257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (obj != null)
						{
							num = (short)21889028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_393;
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.MyDataPresenter = this.ExpanderRepeaterIDListMDCRepeaterIDTable;
						num = (short)1340932101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_393;
					case 6:
						obj = null;
						obj = this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.MyRecordsetDataSource;
						num = (short)155516931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (obj != null)
						{
							num = (short)381485064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27D;
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.MyDataPresenter = this.ExpanderRepeaterIDListSingletoneFrequencyTable;
						num = (short)1204944896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_30E;
					}
					IL_92:
					if (!this.a)
					{
						num = (short)318963718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_27D:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1702297602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_393:
					obj = this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.MyRecordsetDataSource;
					num = (short)807862272;
					short num4 = num;
					num = (short)799604743;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_30E:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x00A4671C File Offset: 0x00A4491C
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
					goto IL_11E;
				case 1:
					if (this.a)
					{
						num2 = (short)1602486274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					for (;;)
					{
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)805137375;
						short num3 = num2;
						num2 = (short)262237151;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C7;
						}
					}
					IL_C7:
					num2 = (short)697303041;
					if (num2 != 0)
					{
					}
					num2 = (short)1207107584;
					if (num2 != 0)
					{
					}
					num2 = (short)747962368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_11E:
			num2 = (short)1671823360;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.DataContext = null;
			this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.DataContext = null;
			this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.MyDataPresenter = null;
			num2 = (short)1243742209;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x00A46874 File Offset: 0x00A44A74
		public override void SetDataContext()
		{
			short num = (short)1236533252;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)812908546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_242;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1987706886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 3:
					num = (short)526254103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2017329153;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					continue;
				case 5:
					goto IL_2F1;
				case 6:
					num = (short)1000472595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10224].EmbeddedRecset != null)
					{
						num = (short)1990656001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BB;
				case 8:
					num = (short)2014248967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_168;
				case 10:
					goto IL_3C0;
				case 11:
					goto IL_168;
				case 12:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2034);
					num = (short)96665609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)451936271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10077].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable).SyncDataSources();
					num = (short)1596719114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)259063811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BB;
				case 16:
					if (feature != null)
					{
						goto IL_3DE;
					}
					goto IL_4BB;
				case 17:
					if (feature != null)
					{
						num = (short)1785593856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 18:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2034);
					num = (short)1390084113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10077] != null)
					{
						num = (short)1004404758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 20:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable).MySecondaryRecordsetDataSource = null;
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable).MySecondaryRecordsetDataSource = null;
						num = (short)1901789189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1333133041;
					short num3 = num;
					num = (short)753336049;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3DE;
					default:
						num = (short)1523318784;
						if (num != 0)
						{
						}
						num = (short)656277522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 21:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10077].EmbeddedRecset != null)
					{
						num = (short)1747386382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 22:
					num = (short)524484629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10224] != null)
					{
						num = (short)276103176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BB;
				}
				IL_AB:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1457127436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2034);
				num = (short)2118647819;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_168:
				num = (short)1567621140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C0:
				num = (short)1969356816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DE:
				num = (short)872480781;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_242:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10224].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable).SyncDataSources();
			return;
			IL_2F1:
			IL_4BB:
			num = (short)1376387072;
			short num4 = num;
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x00A46D68 File Offset: 0x00A44F68
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)1634074624;
			switch (num)
			{
			default:
			{
				num = (short)662765573;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)734134281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (myRecordsetDataSource != null)
						{
							num = (short)2141257741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰ꇲ郴蟶鳸髺觼髾猀䨂䄄䬆怈砊礌䈎唐倒䜔爖椘縚簜欞䐠儢氤挦紨䨪伬䌮吰", a_))
						{
							num = (short)1673068558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					case 4:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.MyRecordsetDataSource;
						num = (short)1161428993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 6:
						goto IL_10D;
					case 7:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)769196038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_B2;
					case 9:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2072576004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1633026050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1394147335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					}
					case 11:
					{
						num = (short)47513600;
						short num3 = num;
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰ꇲ郴蟶鳸髺觼髾猀䨂䄄䬆怈砊礌導砐紒爔笖簘漚爜焞䐠攢圤䈦堨帪䠬䄮到䨲愴嘶嬸场堼", a_))
						{
							num = (short)2055077888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 12:
					{
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1450442768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)790644843;
						short num4 = num;
						num = (short)1956399211;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B2;
						default:
							num = (short)36700160;
							if (num != 0)
							{
							}
							num = (short)71041039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_108;
					case 14:
						num = (short)1940914177;
						if (num != 0)
						{
						}
						num = (short)2022047756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_10D;
					case 16:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.MyRecordsetDataSource;
						num = (short)350355466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_91:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1315700744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_B2:
					num = (short)194969603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D:
					num = (short)998899723;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_108:
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x00A47170 File Offset: 0x00A45370
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1642096534;
			short num2 = num;
			num = (short)1804298134;
			switch (num2 == num)
			{
			}
			num = (short)375980033;
			if (num != 0)
			{
			}
			num = (short)2050949120;
			if (num != 0)
			{
			}
			num = (short)772866048;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x00A47220 File Offset: 0x00A45420
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)823844869;
			short num2 = num;
			num = (short)1202446341;
			switch (num2 == num)
			{
			}
			num = (short)1327693825;
			if (num != 0)
			{
			}
			num = (short)203948032;
			if (num != 0)
			{
			}
			num = (short)1319370752;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x00A472D0 File Offset: 0x00A454D0
		internal void OnExpanderRepeaterIDListMDCRepeaterIDTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_127;
				case 1:
					num2 = (short)1635647489;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1734672386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 2:
					for (;;)
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.SyncDataSources();
						num2 = (short)1695134115;
						short num3 = num2;
						num2 = (short)445559203;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_FB;
						}
					}
					IL_FB:
					num2 = (short)56229888;
					if (num2 != 0)
					{
					}
					num2 = (short)1633288192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_127:
			num2 = (short)1707212800;
			short num4 = num2;
			IL_152:
			this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.MyRecordsetDataSource;
			num2 = (short)1681522689;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x00A4743C File Offset: 0x00A4563C
		internal void OnExpanderRepeaterIDListSingletoneFrequencyTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_129;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)506920962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_154;
				case 2:
					for (;;)
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.SyncDataSources();
						num2 = (short)999330735;
						short num3 = num2;
						num2 = (short)1981453231;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_FD;
						}
					}
					IL_FD:
					num2 = (short)1124532224;
					if (num2 != 0)
					{
					}
					num2 = (short)207224832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_129:
			num2 = (short)515899392;
			short num4 = num2;
			IL_154:
			this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1369505793;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.MyRecordsetDataSource;
			num2 = (short)80150529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x00A475AC File Offset: 0x00A457AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)190382080;
			short num2 = num;
			num = (short)1308853022;
			short num3 = num;
			num = (short)1706918686;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)852033536;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸飺鋼釾眀昂欄猆怈搊挌渎紐㘒✔✖稘琚猜礞䠠䐢値唦䠨弪䐬䀮弰ᰲ䜴制䤸帺尼䬾⑀ㅂ恄畆祈≊⥌橎捐捒㥔㹖⩘⽚牜ⵞѠ።d٦ᵨ๪ὬٮᕰὲᱴѶ൸啺ռṾ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			num = (short)1367146497;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x00A4768C File Offset: 0x00A4588C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)35782657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C8;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)2074083328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_33C;
				case 2:
				case 3:
					goto IL_435;
				case 4:
					goto IL_428;
				case 5:
					goto IL_2B1;
				case 6:
					goto IL_131;
				case 7:
					goto IL_1DA;
				case 8:
					goto IL_1CD;
				case 9:
					goto IL_100;
				case 10:
					goto IL_17C;
				case 11:
					goto IL_315;
				case 12:
					goto IL_1E7;
				case 13:
					goto IL_2A4;
				case 14:
					goto IL_308;
				case 15:
					goto IL_1A3;
				case 16:
					goto IL_225;
				case 17:
					goto IL_25C;
				case 18:
					goto IL_322;
				case 19:
					goto IL_37A;
				case 20:
					goto IL_16F;
				case 21:
					goto IL_F3;
				case 22:
					goto IL_36D;
				case 23:
					goto IL_280;
				case 24:
					goto IL_32F;
				case 25:
					goto IL_155;
				case 26:
					goto IL_E6;
				case 27:
					goto IL_3C2;
				case 28:
					goto IL_218;
				case 29:
					goto IL_2D5;
				case 30:
					goto IL_124;
				case 31:
					goto IL_39E;
				case 32:
					goto IL_189;
				case 33:
					goto IL_1F4;
				case 34:
					goto IL_162;
				case 35:
					goto IL_41B;
				case 36:
					goto IL_196;
				default:
					num = (short)1802960898;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E6:
			this.ExpanderRepeaterIDListSingletoneFrequencyTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F3:
			this.CnvCfgMDCRepeaterIDListRepeaterID_A8941Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_100:
			this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable.ModeClick += this.OnModeClick;
			return;
			IL_124:
			this.gridExpanderRepeaterIDListSingletoneFrequencyTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_131:
			this.HLinkSingletoneFrequencyList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSingletoneFrequencyList.Click += this.HLinkClick;
			return;
			IL_155:
			this.ExpanderRepeaterIDListSingletoneFrequencyTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_162:
			this.RTDBtnCnvCfgSingletoneFrequencyListToneHz_A9385 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16F:
			this.CpyBtnCnvCfgMDCRepeaterIDListRepeaterID_A8941 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17C:
			this.ExpanderRepeaterIDListMDCRepeaterIDListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_189:
			this.CVBtnCnvCfgSingletoneFrequencyListToneHz_A9385 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_196:
			this.CnvCfgSingletoneFrequencyListToneHz_A9385Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A3:
			this.ExpanderRepeaterIDListMDCRepeaterIDTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1C8:
			goto IL_435;
			IL_1CD:
			this.ExpanderRepeaterIDListMDCRepeaterIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_1DA:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1E7:
			this.ExpanderRepeaterIDListMDCRepeaterIDTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F4:
			this.LblCnvCfgSingletoneFrequencyListToneHz_A9385 = (global::AcpUI.AcpLabel)target;
			this.LblCnvCfgSingletoneFrequencyListToneHz_A9385.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_218:
			this.CnvCfgSingletoneFrequencyListToneHz_A9385_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_225:
			num = (short)1390149632;
			short num3 = num;
			this.gridExpanderRepeaterIDListMDCRepeaterIDTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_25C:
			this.CnvCfgMDCRepeaterIDListRepeaterID_A8941 = (global::AcpUI.AcpTextBox)target;
			this.CnvCfgMDCRepeaterIDListRepeaterID_A8941.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_280:
			this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable.ModeClick += this.OnModeClick;
			return;
			IL_2A4:
			this.ExpanderRepeaterIDListMDCRepeaterIDTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2B1:
			this.HLinkMDCRepeaterIDList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMDCRepeaterIDList.Click += this.HLinkClick;
			return;
			IL_2D5:
			num = (short)1661009921;
			if (num != 0)
			{
			}
			this.ExpanderRepeaterIDListSingletoneFrequencyTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_308:
			this.CnvCfgMDCRepeaterIDListRepeaterID_A8941_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_315:
			this.ExpanderRepeaterIDListMDCRepeaterIDTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_322:
			this.CVBtnCnvCfgMDCRepeaterIDListRepeaterID_A8941 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32F:
			this.ExpanderRepeaterIDListSingletoneFrequencyListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_33C:
			((global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.PageRepeaterIDList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.PageRepeaterIDList)target).Unloaded += this.OnUnloaded;
			return;
			IL_36D:
			this.ExpanderRepeaterIDListSingletoneFrequencyList = (global::AcpUI.AcpExpander)target;
			return;
			IL_37A:
			this.LblCnvCfgMDCRepeaterIDListRepeaterID_A8941 = (global::AcpUI.AcpLabel)target;
			this.LblCnvCfgMDCRepeaterIDListRepeaterID_A8941.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_39E:
			this.CnvCfgSingletoneFrequencyListToneHz_A9385 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvCfgSingletoneFrequencyListToneHz_A9385.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C2:
			num = (short)1829187236;
			short num4 = num;
			num = (short)1259482788;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2B1;
			default:
				num = (short)135921664;
				if (num != 0)
				{
				}
				this.ExpanderRepeaterIDListSingletoneFrequencyTable = (global::AcpUI.AcpXamDataPresenter)target;
				return;
			}
			IL_41B:
			this.CpyBtnCnvCfgSingletoneFrequencyListToneHz_A9385 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_428:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_435:
			this.b = true;
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x00A47AD8 File Offset: 0x00A45CD8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1636433921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)1812856833;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					if (connectionId != 3)
					{
						num = (short)963837952;
						short num3 = num;
						num = (short)432209920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_139;
				case 3:
					goto IL_75;
				}
				IL_5D:
				if (connectionId != 2)
				{
					num = (short)1511063555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)364317023;
				short num4 = num;
				num = (short)1173948767;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AB;
				}
				IL_75:
				num = (short)326893570;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			num = (short)502661120;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_139:
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040053FF RID: 21503
		private bool a;

		// Token: 0x04005400 RID: 21504
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04005401 RID: 21505
		internal global::System.Windows.Documents.Hyperlink HLinkMDCRepeaterIDList;

		// Token: 0x04005402 RID: 21506
		internal global::System.Windows.Documents.Hyperlink HLinkSingletoneFrequencyList;

		// Token: 0x04005403 RID: 21507
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04005404 RID: 21508
		internal global::AcpUI.AcpExpander ExpanderRepeaterIDListMDCRepeaterIDList;

		// Token: 0x04005405 RID: 21509
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRepeaterIDListMDCRepeaterIDTable;

		// Token: 0x04005406 RID: 21510
		internal global::System.Windows.Controls.Grid ExpanderRepeaterIDListMDCRepeaterIDListGrid;

		// Token: 0x04005407 RID: 21511
		internal global::System.Windows.Controls.Grid ExpanderRepeaterIDListMDCRepeaterIDTableGrid;

		// Token: 0x04005408 RID: 21512
		internal global::AcpUI.AcpGroupBox ExpanderRepeaterIDListMDCRepeaterIDTableTableView;

		// Token: 0x04005409 RID: 21513
		internal global::AcpUI.AcpXamDataPresenter ExpanderRepeaterIDListMDCRepeaterIDTable;

		// Token: 0x0400540A RID: 21514
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvCfgMDCRepeaterIDListRepeaterID_A8941_Col;

		// Token: 0x0400540B RID: 21515
		internal global::AcpUI.AcpGroupBox ExpanderRepeaterIDListMDCRepeaterIDTableSRecView;

		// Token: 0x0400540C RID: 21516
		internal global::System.Windows.Controls.Grid gridExpanderRepeaterIDListMDCRepeaterIDTableSRecView;

		// Token: 0x0400540D RID: 21517
		internal global::AcpUI.AcpTextBox CnvCfgMDCRepeaterIDListRepeaterID_A8941;

		// Token: 0x0400540E RID: 21518
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvCfgMDCRepeaterIDListRepeaterID_A8941;

		// Token: 0x0400540F RID: 21519
		internal global::AcpUI.AcpLabel LblCnvCfgMDCRepeaterIDListRepeaterID_A8941;

		// Token: 0x04005410 RID: 21520
		internal global::AcpUI.AcpCopyButton CpyBtnCnvCfgMDCRepeaterIDListRepeaterID_A8941;

		// Token: 0x04005411 RID: 21521
		internal global::AcpUI.AcpLabel CnvCfgMDCRepeaterIDListRepeaterID_A8941Comp;

		// Token: 0x04005412 RID: 21522
		internal global::AcpUI.AcpExpander ExpanderRepeaterIDListSingletoneFrequencyList;

		// Token: 0x04005413 RID: 21523
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRepeaterIDListSingletoneFrequencyTable;

		// Token: 0x04005414 RID: 21524
		internal global::System.Windows.Controls.Grid ExpanderRepeaterIDListSingletoneFrequencyListGrid;

		// Token: 0x04005415 RID: 21525
		internal global::System.Windows.Controls.Grid ExpanderRepeaterIDListSingletoneFrequencyTableGrid;

		// Token: 0x04005416 RID: 21526
		internal global::AcpUI.AcpGroupBox ExpanderRepeaterIDListSingletoneFrequencyTableTableView;

		// Token: 0x04005417 RID: 21527
		internal global::AcpUI.AcpXamDataPresenter ExpanderRepeaterIDListSingletoneFrequencyTable;

		// Token: 0x04005418 RID: 21528
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvCfgSingletoneFrequencyListToneHz_A9385_Col;

		// Token: 0x04005419 RID: 21529
		internal global::AcpUI.AcpGroupBox ExpanderRepeaterIDListSingletoneFrequencyTableSRecView;

		// Token: 0x0400541A RID: 21530
		internal global::System.Windows.Controls.Grid gridExpanderRepeaterIDListSingletoneFrequencyTableSRecView;

		// Token: 0x0400541B RID: 21531
		internal global::AcpUI.AcpTextBoxSpinner CnvCfgSingletoneFrequencyListToneHz_A9385;

		// Token: 0x0400541C RID: 21532
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvCfgSingletoneFrequencyListToneHz_A9385;

		// Token: 0x0400541D RID: 21533
		internal global::AcpUI.AcpLabel LblCnvCfgSingletoneFrequencyListToneHz_A9385;

		// Token: 0x0400541E RID: 21534
		internal global::AcpUI.AcpRtdButton RTDBtnCnvCfgSingletoneFrequencyListToneHz_A9385;

		// Token: 0x0400541F RID: 21535
		internal global::AcpUI.AcpCopyButton CpyBtnCnvCfgSingletoneFrequencyListToneHz_A9385;

		// Token: 0x04005420 RID: 21536
		internal global::AcpUI.AcpLabel CnvCfgSingletoneFrequencyListToneHz_A9385Comp;

		// Token: 0x04005421 RID: 21537
		private bool b;
	}
}
