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
using ConstraintHelper;
using ControlHeadGraphicView;
using Infragistics.Windows.DataPresenter;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200032C RID: 812
	public class PageDEK : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06007D4A RID: 32074 RVA: 0x007372DC File Offset: 0x007354DC
		public PageDEK()
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

		// Token: 0x06007D4B RID: 32075 RVA: 0x00737314 File Offset: 0x00735514
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1208877056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)147259401;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
						goto IL_340;
					case 1:
						goto IL_12A;
					case 2:
						goto IL_3FC;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDEKDEKVIPTable.MyDataPresenter = this.ExpanderDEKDEKVIPTable;
						num = (short)108134407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_37B;
					case 5:
						try
						{
							num = (short)1966014466;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1244790789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B5;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)303038465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									goto IL_1CB;
								case 4:
									base.Expanders.Add(acpExpander);
									num = (short)1524170752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2C8;
								case 6:
									if (acpExpander != null)
									{
										num = (short)341805020;
										short num3 = num;
										num = (short)516523996;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1CB;
										default:
											num = (short)603455488;
											if (num != 0)
											{
											}
											num = (short)1313865732;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								goto IL_1B5;
								IL_1CB:
								num = (short)773390342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_272:
								num = (short)234422275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B5:
								goto IL_272;
							}
							IL_2C8:
							goto IL_3D4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2EA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2D7:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)418643969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_33D;
								case 2:
									if (disposable != null)
									{
										num = (short)637009920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33F;
								}
								goto IL_2EA;
							}
							IL_33D:
							IL_33F:
							goto EndFinally_12;
							IL_2EA:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)490340354;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2D7;
							EndFinally_12:;
						}
						goto IL_340;
						IL_3D4:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)238157826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (obj != null)
						{
							num = (short)2133655569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 7:
						goto IL_4C5;
					case 8:
						if (obj != null)
						{
							num = (short)398786563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 10:
						obj = null;
						obj = this.RecNavToolbarExpanderDEKDEKButton.MyRecordsetDataSource;
						num = (short)753598482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (obj != null)
						{
							num = (short)223674381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 12:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDEKDirectMessageList.MyDataPresenter = this.ExpanderDEKDirectMessageList;
						num = (short)370933775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDEKDirectStatusBCOList.MyDataPresenter = this.ExpanderDEKDirectStatusBCOList;
						num = (short)749862916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (obj != null)
						{
							num = (short)1906573324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_401;
					case 15:
						goto IL_401;
					case 16:
						goto IL_47D;
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDEKDirectModeBCOList.MyDataPresenter = this.ExpanderDEKDirectModeBCOList;
						num = (short)1812791312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (obj != null)
						{
							num = (short)1951793152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					IL_91:
					if (!this.a)
					{
						num = (short)707723274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_12A:
					obj = this.RecNavToolbarExpanderDEKDEKVIPTable.MyRecordsetDataSource;
					num = (short)1250754568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340:
					global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderDEKDEKButton.MyDataPresenter = this.ExpanderDEKDEKButton;
					num = (short)669777921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num = (short)1514471424;
					short num4 = num;
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1037959173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_401:
					obj = this.RecNavToolbarExpanderDEKDirectModeBCOList.MyRecordsetDataSource;
					num = (short)93847558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47D:
					obj = this.RecNavToolbarExpanderDEKDirectStatusBCOList.MyRecordsetDataSource;
					num = (short)1384120331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C5:
					num = (short)2032599041;
					if (num != 0)
					{
					}
					obj = this.RecNavToolbarExpanderDEKDirectMessageList.MyRecordsetDataSource;
					num = (short)1857355790;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3FC:
				this.PostOnLoaded(sender, e);
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x00737910 File Offset: 0x00735B10
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
					base.OnUnloaded(sender, e);
					this.a = false;
					goto IL_12B;
				case 1:
					goto IL_16B;
				case 2:
				{
					num2 = (short)966048346;
					short num3 = num2;
					num2 = (short)1849211482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12B;
					default:
						num2 = (short)729153536;
						if (num2 != 0)
						{
						}
						if (this.a)
						{
							num2 = (short)2037514240;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_12B:
				num2 = (short)633143296;
				short num4 = num2;
				num2 = (short)1184825345;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16B:
			num2 = (short)760217601;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderDEKDEKButton.DataContext = null;
			this.RecNavToolbarExpanderDEKDEKVIPTable.DataContext = null;
			this.RecNavToolbarExpanderDEKDirectMessageList.DataContext = null;
			this.RecNavToolbarExpanderDEKDirectModeBCOList.DataContext = null;
			this.RecNavToolbarExpanderDEKDirectStatusBCOList.DataContext = null;
			this.RecNavToolbarExpanderDEKDEKButton.MyDataPresenter = null;
			this.RecNavToolbarExpanderDEKDEKVIPTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderDEKDirectMessageList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDEKDirectModeBCOList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDEKDirectStatusBCOList.MyDataPresenter = null;
			num2 = (short)1704329218;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00737AB4 File Offset: 0x00735CB4
		public override void SetDataContext()
		{
			short num = (short)323485734;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1747189782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10233].EmbeddedRecset != null)
					{
						num = (short)2076114964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B6;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10232].EmbeddedRecset != null)
					{
						num = (short)1509359630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F1;
				case 3:
					if (feature != null)
					{
						num = (short)1316421651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)363593734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10219] != null)
					{
						num = (short)1907425328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1556676644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F1;
				case 7:
					goto IL_8B6;
				case 8:
					num = (short)473890828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10220] != null)
					{
						num = (short)457244698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67C;
				case 10:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2129);
					num = (short)292749337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10229].EmbeddedRecset != null)
					{
						num = (short)1129840667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98D;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)993525790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98D;
				case 13:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectModeBCOList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10220].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectModeBCOList).SyncDataSources();
					num = (short)288620577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10232].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKButton).SyncDataSources();
					num = (short)2125398060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1914634251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)49610801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67C;
				case 17:
					return;
				case 18:
					num = (short)2025324546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1761411118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKVIPTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10233].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKVIPTable).SyncDataSources();
					num = (short)1244790791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1780940816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					num = (short)534436378;
					short num3 = num;
					num = (short)362076698;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_76C;
					default:
						num = (short)1263140864;
						if (num != 0)
						{
						}
						if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
						{
							num = (short)1719140353;
							if (num != 0)
							{
							}
							num = (short)1237975087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B6;
					}
					break;
				}
				case 23:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)771031072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDEKVIPTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectMessageList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectModeBCOList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectStatusBCOList).MySecondaryRecordsetDataSource = null;
					num = (short)835715089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_82B;
				case 25:
					goto IL_82B;
				case 26:
					num = (short)347602979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectMessageList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10229].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectMessageList).SyncDataSources();
					num = (short)617676841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
				{
					num = (short)557776896;
					short num4 = num;
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10229] != null)
					{
						num = (short)540803087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98D;
				}
				case 29:
					if (feature != null)
					{
						num = (short)422117376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B6;
				case 30:
					num = (short)1908015132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10219].EmbeddedRecset != null)
					{
						num = (short)1386610722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 32:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2129);
					num = (short)2077491250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					goto IL_67C;
				case 34:
					goto IL_32E;
				case 35:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10220].EmbeddedRecset != null)
					{
						num = (short)1237057549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67C;
				case 36:
					num = (short)1543700522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					goto IL_76C;
				case 38:
					switch (0)
					{
					case 0:
						goto IL_F1;
					}
					continue;
				case 39:
					num = (short)1769472001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					num = (short)436666373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_98D;
				case 42:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10232] != null)
					{
						num = (short)1041825810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F1;
				case 43:
					if (feature != null)
					{
						num = (short)1380974613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67C;
				case 44:
					goto IL_7F1;
				case 45:
					if (feature != null)
					{
						num = (short)553582600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98D;
				case 46:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1256194088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 47:
					num = (short)1517355045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					num = (short)25886751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					num = (short)484245513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					if (feature != null)
					{
						num = (short)1121255428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F1;
				}
				IL_F1:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1581842442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2129);
				num = (short)788332568;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_67C:
				num = (short)1060569091;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_76C:
				if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10233] != null)
				{
					num = (short)1479409703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_8B6;
				IL_7F1:
				num = (short)467861533;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_82B:
				num = (short)603324439;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B6:
				num = (short)2001993773;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_98D:
				num = (short)1188757547;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32E:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectStatusBCOList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10219].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDEKDirectStatusBCOList).SyncDataSources();
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00738488 File Offset: 0x00736688
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)620625920;
			switch (num)
			{
			default:
			{
				object myRecordsetDataSource3;
				for (;;)
				{
					IL_26:
					num = (short)1406205980;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_720;
						case 1:
							goto IL_689;
						case 2:
						{
							object myRecordsetDataSource;
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner)collectionView.CurrentItem;
							collectionView.MoveCurrentTo(item);
							((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
							num = (short)776601606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource2 = this.RecNavToolbarExpanderDEKDEKButton.MyRecordsetDataSource;
							num = (short)1369178152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1225064468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)2112159762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_689;
						case 7:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺맼뫾䨀䜂䀄䰆弈䈊崌嬎瀐焒礔爖", a_))
							{
								num = (short)258736140;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_689;
						case 8:
						{
							object myRecordsetDataSource;
							if (myRecordsetDataSource != null)
							{
								num = (short)1350893570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_689;
						}
						case 9:
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							myRecordsetDataSource3 = this.RecNavToolbarExpanderDEKDirectStatusBCOList.MyRecordsetDataSource;
							num = (short)225771547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							num = (short)1693726479;
							short num3 = num;
							num = (short)1321875215;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26;
							default:
							{
								num = (short)1895301120;
								if (num != 0)
								{
								}
								object myRecordsetDataSource4;
								global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)collectionView2.CurrentItem;
								collectionView2.MoveCurrentTo(item2);
								((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
								num = (short)992673824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 11:
							goto IL_4FF;
						case 12:
							num = (short)1743454242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_1E1;
						case 14:
						{
							object myRecordsetDataSource4;
							if (myRecordsetDataSource4 != null)
							{
								num = (short)2130051082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_720;
						}
						case 15:
						{
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource = this.RecNavToolbarExpanderDEKDEKVIPTable.MyRecordsetDataSource;
							num = (short)1563426824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							object myRecordsetDataSource5;
							if (myRecordsetDataSource5 != null)
							{
								num = (short)1757347857;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E1;
						}
						case 17:
						{
							object myRecordsetDataSource5;
							global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)collectionView3.CurrentItem;
							collectionView3.MoveCurrentTo(item3);
							((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
							num = (short)163905549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)1092354070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)2103312384;
							short num4 = num;
							num = (short)960823296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_479;
						case 20:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺맼뫾䨀䜂䀄䰆䬈縊礌笎縐紒", a_))
							{
								num = (short)1381433370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4FF;
						case 21:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺맼뫾䨀䜂氄甆氈栊礌䈎縐眒瀔唖娘吚儜瘞删圢", a_))
							{
								num = (short)813891619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E1;
						case 22:
						{
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource4 = this.RecNavToolbarExpanderDEKDirectMessageList.MyRecordsetDataSource;
							num = (short)309329934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							object myRecordsetDataSource2;
							global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)collectionView4.CurrentItem;
							collectionView4.MoveCurrentTo(item4);
							((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
							num = (short)1824981029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_1E1;
						case 25:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)166133763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)731447307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)33357849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (myRecordsetDataSource3 != null)
							{
								num = (short)34799645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 28:
							switch (0)
							{
							case 0:
								goto IL_F1;
							}
							continue;
						case 29:
							goto IL_63A;
						case 30:
							num = (short)695336998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺맼뫾䨀䜂氄甆氈栊礌䈎琐怒昔瘖縘縚儜瘞删圢", a_))
							{
								num = (short)1236467717;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_720;
						case 32:
							goto IL_720;
						case 33:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)2073165825;
								if (num != 0)
								{
								}
								num = (short)1827340327;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)1322975256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)25427983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)1502478337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							num = (short)1599143969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺맼뫾䨀䜂氄甆氈栊礌導攐爒愔或樘多帜倞洠䨢嘤匦", a_))
							{
								num = (short)1743519774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 37:
							goto IL_4FF;
						case 38:
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)2089353225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)789577747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
						{
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource5 = this.RecNavToolbarExpanderDEKDirectModeBCOList.MyRecordsetDataSource;
							num = (short)2029322256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 40:
						{
							object myRecordsetDataSource2;
							if (myRecordsetDataSource2 != null)
							{
								num = (short)1354170391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4FF;
						}
						}
						IL_F1:
						if (A_0 is global::AcpUI.AcpRecNavToolbar)
						{
							num = (short)1511522308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_1E1:
						num = (short)11468836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4FF:
						num = (short)1351942151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_689:
						num = (short)382926879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_720:
						num = (short)1349058581;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_479:
				return;
				IL_63A:
				global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)collectionView5.CurrentItem;
				collectionView5.MoveCurrentTo(item5);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00738D28 File Offset: 0x00736F28
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1666436558;
			short num2 = num;
			num = (short)1194511822;
			switch (num2 == num)
			{
			}
			num = (short)852623361;
			if (num != 0)
			{
			}
			num = (short)1199505408;
			if (num != 0)
			{
			}
			num = (short)2138963968;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00738DD8 File Offset: 0x00736FD8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1596194817;
			if (num != 0)
			{
			}
			num = (short)1312056452;
			short num2 = num;
			num = (short)1633707140;
			switch (num2 == num)
			{
			}
			num = (short)9699328;
			if (num != 0)
			{
			}
			num = (short)713490432;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00738E88 File Offset: 0x00737088
		internal void OnExpanderDEKDEKButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner item;
			for (;;)
			{
				IL_0A:
				num = (short)392370353;
				short num2 = num;
				num = (short)1664358577;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8F;
				default:
				{
					num = (short)999096320;
					short num3 = num;
					num = (short)1143472128;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_153;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDEKDEKButton.SyncDataSources();
						num = (short)485359616;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1818099713;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					goto IL_8F;
				}
				}
			}
			IL_153:
			IL_155:
			this.RecNavToolbarExpanderDEKDEKButton.TableMode = false;
			return;
			IL_8F:
			num = (short)1246363649;
			if (num != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDEKDEKButton.MyRecordsetDataSource;
			num = (short)1519583234;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x00738FF8 File Offset: 0x007371F8
		internal void OnExpanderDEKDEKVIPTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_B9;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1665733886;
				short num2 = num;
				num = (short)291116286;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B9;
				default:
				{
					num = (short)1441726464;
					short num3 = num;
					num = (short)1831665665;
					if (num != 0)
					{
					}
					num = (short)1099628544;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_153;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDEKDEKVIPTable.SyncDataSources();
						num = (short)2051080192;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)2053832705;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					goto IL_B9;
				}
				}
			}
			IL_153:
			IL_155:
			this.RecNavToolbarExpanderDEKDEKVIPTable.TableMode = false;
			return;
			IL_B9:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDEKDEKVIPTable.MyRecordsetDataSource;
			num = (short)1903951874;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x00739168 File Offset: 0x00737368
		internal void OnExpanderDEKDirectMessageListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1539579116;
				short num2 = num;
				num = (short)896081132;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_90;
				default:
				{
					num = (short)374996992;
					short num3 = num;
					num = (short)1456865280;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_12B;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDEKDirectMessageList.SyncDataSources();
						num = (short)1362100224;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)197787649;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					}
					goto IL_90;
				}
				}
			}
			IL_12B:
			num = (short)395771905;
			if (num != 0)
			{
			}
			IL_153:
			this.RecNavToolbarExpanderDEKDirectMessageList.TableMode = false;
			return;
			IL_90:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDEKDirectMessageList.MyRecordsetDataSource;
			num = (short)459866114;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x007392D4 File Offset: 0x007374D4
		internal void OnExpanderDEKDirectModeBCOListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1858670212;
				short num2 = num;
				num = (short)1426394756;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8F;
				default:
				{
					num = (short)681508864;
					short num3 = num;
					num = (short)181862400;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_14F;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDEKDirectModeBCOList.SyncDataSources();
						num = (short)1317732353;
						if (num != 0)
						{
						}
						num = (short)190513152;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)868941825;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151;
					}
					goto IL_8F;
				}
				}
			}
			IL_14F:
			IL_151:
			this.RecNavToolbarExpanderDEKDirectModeBCOList.TableMode = false;
			return;
			IL_8F:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDEKDirectModeBCOList.MyRecordsetDataSource;
			num = (short)1565392898;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x00739440 File Offset: 0x00737640
		internal void OnExpanderDEKDirectStatusBCOListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_B6;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)207618049;
				if (num != 0)
				{
				}
				num = (short)648706555;
				short num2 = num;
				num = (short)446659067;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B6;
				case 1:
					break;
				default:
				{
					num = (short)1296695296;
					short num3 = num;
					break;
				}
				}
				num = (short)900136960;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_14E;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDEKDirectStatusBCOList.SyncDataSources();
					num = (short)1573453824;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)2019950593;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_150;
				}
				goto IL_B6;
			}
			IL_14E:
			IL_150:
			this.RecNavToolbarExpanderDEKDirectStatusBCOList.TableMode = false;
			return;
			IL_B6:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDEKDirectStatusBCOList.MyRecordsetDataSource;
			num = (short)221511682;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x007395AC File Offset: 0x007377AC
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)730812212;
			short num2 = num;
			num = (short)115298100;
			switch (num2 == num)
			{
			}
			num = (short)1366425601;
			if (num != 0)
			{
			}
			num = (short)288358400;
			if (num != 0)
			{
			}
			num = (short)1567490048;
			short num3 = num;
			this.a();
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x00739658 File Offset: 0x00737858
		private void a()
		{
			short num = (short)1306198016;
			switch (num)
			{
			default:
			{
				num = (short)106692608;
				short num2 = num;
				num = (short)2068709411;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK dek;
					int num6;
					switch (num3)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (num4 >= topFunctionProgrammableButtonListInnerRecset.Count)
						{
							num = (short)946929690;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = topFunctionProgrammableButtonListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner;
						num = (short)1325334564;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (directModeBCOListInnerRecset != null)
						{
							num = (short)1903034391;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)136445958;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A;
									if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == cnvTopFunctionButtonBCO_A.Value)
									{
										num = (short)1707737090;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_492;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									global::AcpBusinessLayer.AcpListField topFunctionBtnCnvChannel_A;
									directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535.UIValue = topFunctionBtnCnvChannel_A.UIValue;
									num = (short)142671876;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)653131781;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)1711669248;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_473;
								case 5:
									num = (short)858128385;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_3AD;
									}
									continue;
								}
								IL_406:
								num = (short)1481637891;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AD:
								goto IL_406;
							}
							IL_473:
							IL_492:
							goto IL_2C3;
						}
						finally
						{
							num = (short)274268162;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_550;
								case 1:
									enumerator.Dispose();
									num = (short)2049835008;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)728911741;
									short num5 = num;
									num = (short)1682919293;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)24707072;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_516;
										}
										continue;
									}
									break;
								}
								}
								IL_516:
								if (enumerator == null)
								{
									break;
								}
								num = (short)934477825;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_550:;
						}
						goto IL_553;
					case 3:
						goto IL_2E8;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
						if (dekbuttonInnerSection.DEKChannel_A22565.UIValue != dekbuttonInnerSection.DEKChannel_A22565.InvalidText)
						{
							num = (short)704708616;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					}
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2129);
						num = (short)1456668704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = dekbuttonInner.DEKButtonInnerSection;
						num = (short)1731198992;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1688404009;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)9175058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1537146900;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection;
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						global::AcpBusinessLayer.AcpListField topFunctionBtnCnvChannel_A = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943;
						global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A = topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628;
						num = (short)697040910;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2E8;
					case 12:
						if (global::AcpCommonLib.FeatureManager.GetFeature(4003) != null)
						{
							num = (short)656277541;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						dek = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK);
						num = (short)2023227413;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 74)
						{
							num = (short)835780650;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C3;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						if (num6 >= dekbuttonInnerRecset.Count)
						{
							num = (short)1558380566;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = dekbuttonInnerRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner;
						num = (short)1945632798;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
						if (dekbuttonInnerSection != null)
						{
							num = (short)1271857176;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					}
					case 17:
						goto IL_553;
					case 18:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)172163081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					case 19:
						num4 = 0;
						num = (short)1948057643;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
						{
							num = (short)248315944;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					case 21:
						if (dek != null)
						{
							num = (short)839909401;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						goto IL_165;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO = global::AcpCommonLib.FeatureManager.GetFeature(4003)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9;
						num = (short)484376604;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)480509986;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset = dek.General.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
						num = (short)1339162653;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						return;
					case 27:
						goto IL_8E6;
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO;
						if (controlHeadO != null)
						{
							num = (short)974192678;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						if (dekbuttonInnerRecset != null)
						{
							num = (short)36372513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					}
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
						if (dekbuttonInner != null)
						{
							num = (short)146472966;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					}
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset != null)
						{
							num = (short)1993474067;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 32:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1103953933;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 33:
						num6 = 0;
						num = (short)608108547;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
						if (dekbuttonInnerSection.DEKChannel_A22565 != null)
						{
							num = (short)1778974727;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					}
					case 35:
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						continue;
					case 36:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
						if (topFunctionProgrammableButtonListInner != null)
						{
							num = (short)774111233;
							if (num != 0)
							{
							}
							num = (short)178651146;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C3;
					}
					case 37:
						num = (short)1696530433;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = controlHeadO.TopFunctionProgrammableButton.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						num = (short)515375135;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						num = (short)908197892;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
						dekbuttonInnerSection.DEKChannel_A22565.ResetToDefaultWithUndo();
						num = (short)103415835;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
						if (dekbuttonInnerSection.DEKChannel_A22565.ReferencedNode == null)
						{
							num = (short)1699348519;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E6;
					}
					case 42:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)934346754;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_553;
					}
					IL_11C:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num = (short)1004929029;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_165:
					directModeBCOListInnerRecset = (dek.DirectMode.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset);
					num = (short)1841037324;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C3:
					num4++;
					num = (short)1996423185;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					num = (short)107151375;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_553:
					num = (short)188088320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E6:
					num6++;
					num = (short)650575883;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x00739FE0 File Offset: 0x007381E0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1370445132;
			short num2 = num;
			num = (short)219960652;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1043595264;
				short num3 = num;
				num = (short)1034092545;
				if (num != 0)
				{
				}
				num = (short)1399652352;
				if (num != 0)
				{
				}
				if (this.b)
				{
					return;
				}
				break;
			}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸觺鳼鯾栀氂\u2004㔆㤈渊缌栎縐紒稔稖瀘砚渜㨞ጠጢ䘤䠦䜨䴪䐬䠮䐰䄲吴䌶倸吺匼ှ≀ⱂ⭄㍆㭈⑊⅌㱎繐㝒ご㱖癘㽚㡜㑞你᭢Ѥ੦ը", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0073A0BC File Offset: 0x007382BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1703018497;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1854799874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1041825793;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					goto IL_A92;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
					goto IL_4DC;
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
				case 22:
					goto IL_1410;
				case 23:
					goto IL_A97;
				case 24:
					goto IL_10F2;
				case 25:
					goto IL_69E;
				case 26:
					goto IL_9A9;
				case 27:
					goto IL_62C;
				case 28:
					goto IL_138A;
				case 29:
					goto IL_124F;
				case 30:
					goto IL_C38;
				case 31:
					goto IL_F0C;
				case 32:
					goto IL_CEB;
				case 33:
					goto IL_13D2;
				case 34:
					goto IL_1123;
				case 35:
					goto IL_C9D;
				case 36:
					goto IL_724;
				case 37:
					goto IL_101E;
				case 38:
					goto IL_D0F;
				case 39:
					goto IL_F4A;
				case 40:
					goto IL_978;
				case 41:
					goto IL_F7B;
				case 42:
					goto IL_EE5;
				case 43:
					goto IL_11EA;
				case 44:
					goto IL_F19;
				case 45:
					goto IL_9CD;
				case 46:
					goto IL_99C;
				case 47:
					goto IL_45D;
				case 48:
					goto IL_D1C;
				case 49:
					goto IL_81C;
				case 50:
					goto IL_70A;
				case 51:
					goto IL_B13;
				case 52:
					goto IL_691;
				case 53:
					goto IL_51A;
				case 54:
					goto IL_117B;
				case 55:
					goto IL_748;
				case 56:
					goto IL_FF7;
				case 57:
					goto IL_7BA;
				case 58:
					goto IL_10D8;
				case 59:
					goto IL_F26;
				case 60:
					goto IL_50D;
				case 61:
					goto IL_1363;
				case 62:
					goto IL_11F7;
				case 63:
					goto IL_EC1;
				case 64:
					goto IL_42C;
				case 65:
					goto IL_599;
				case 66:
					goto IL_779;
				case 67:
					goto IL_527;
				case 68:
					goto IL_10BE;
				case 69:
					goto IL_954;
				case 70:
					goto IL_491;
				case 71:
					goto IL_6E6;
				case 72:
					goto IL_5FB;
				case 73:
					goto IL_5EE;
				case 74:
					goto IL_D81;
				case 75:
					goto IL_E07;
				case 76:
					goto IL_137D;
				case 77:
					goto IL_C45;
				case 78:
					goto IL_B88;
				case 79:
					goto IL_5E1;
				case 80:
					goto IL_1228;
				case 81:
					goto IL_FB9;
				case 82:
					goto IL_B47;
				case 83:
					goto IL_13AE;
				case 84:
					goto IL_58C;
				case 85:
					goto IL_E80;
				case 86:
					goto IL_F6E;
				case 87:
					goto IL_11B9;
				case 88:
					goto IL_65D;
				case 89:
					goto IL_ACB;
				case 90:
					goto IL_7EB;
				case 91:
					goto IL_A53;
				case 92:
					goto IL_CB7;
				case 93:
					goto IL_9DA;
				case 94:
					goto IL_677;
				case 95:
					goto IL_B95;
				case 96:
					goto IL_DFA;
				case 97:
					goto IL_13F6;
				case 98:
					goto IL_867;
				case 99:
					goto IL_1309;
				case 100:
					goto IL_CC4;
				case 101:
					goto IL_565;
				case 102:
					goto IL_572;
				case 103:
					goto IL_128D;
				case 104:
					goto IL_E8D;
				case 105:
					goto IL_85A;
				case 106:
					goto IL_ABE;
				case 107:
					goto IL_874;
				case 108:
					goto IL_8BF;
				case 109:
					goto IL_1273;
				case 110:
					goto IL_C90;
				case 111:
					goto IL_4CF;
				case 112:
					goto IL_129A;
				case 113:
					goto IL_AB1;
				case 114:
					goto IL_1080;
				case 115:
					goto IL_8B2;
				case 116:
					goto IL_650;
				case 117:
					goto IL_FEA;
				case 118:
					goto IL_AEF;
				case 119:
					goto IL_CDE;
				case 120:
					goto IL_D8E;
				case 121:
					goto IL_EF2;
				case 122:
					goto IL_113D;
				case 123:
					goto IL_10B1;
				case 124:
					goto IL_608;
				case 125:
					goto IL_A60;
				case 126:
					goto IL_D50;
				case 127:
					goto IL_C83;
				case 128:
					goto IL_B6E;
				case 129:
					goto IL_1235;
				case 130:
					goto IL_881;
				case 131:
					goto IL_EB4;
				case 132:
					goto IL_7F8;
				case 133:
					goto IL_11AC;
				case 134:
					goto IL_AA4;
				case 135:
					goto IL_8FD;
				case 136:
					goto IL_836;
				case 137:
					goto IL_41F;
				case 138:
					goto IL_105C;
				case 139:
					goto IL_104F;
				case 140:
					goto IL_8CC;
				case 141:
					goto IL_484;
				case 142:
					goto IL_12E5;
				case 143:
					goto IL_7DE;
				case 144:
					goto IL_755;
				case 145:
					goto IL_C04;
				case 146:
					goto IL_FDD;
				case 147:
					goto IL_1370;
				case 148:
					goto IL_BC6;
				case 149:
					goto IL_B2D;
				case 150:
					goto IL_B3A;
				case 151:
					goto IL_57F;
				case 152:
					goto IL_A46;
				case 153:
					goto IL_11DD;
				case 154:
					goto IL_1356;
				case 155:
					goto IL_D43;
				case 156:
					goto IL_C11;
				case 157:
					goto IL_A22;
				case 158:
					goto IL_C69;
				case 159:
					goto IL_9FE;
				case 160:
					goto IL_46A;
				case 161:
					goto IL_BF7;
				case 162:
					goto IL_D29;
				case 163:
					goto IL_3FB;
				case 164:
					goto IL_B61;
				case 165:
					goto IL_E2B;
				case 166:
					goto IL_BB9;
				case 167:
					goto IL_CAA;
				case 168:
					goto IL_C1E;
				case 169:
					goto IL_1204;
				case 170:
					goto IL_A6D;
				case 171:
					goto IL_B7B;
				case 172:
					goto IL_66A;
				case 173:
					goto IL_793;
				case 174:
					goto IL_829;
				case 175:
					goto IL_1130;
				case 176:
					goto IL_10A4;
				case 177:
					goto IL_1280;
				case 178:
					goto IL_EA7;
				case 179:
					goto IL_717;
				case 180:
					goto IL_8D9;
				case 181:
					goto IL_F88;
				case 182:
					goto IL_541;
				case 183:
					goto IL_12BE;
				case 184:
					goto IL_10E5;
				case 185:
					goto IL_B20;
				case 186:
					goto IL_439;
				case 187:
					goto IL_B54;
				case 188:
					goto IL_5BD;
				case 189:
					goto IL_786;
				case 190:
					goto IL_10CB;
				case 191:
					goto IL_7A0;
				case 192:
					goto IL_102B;
				case 193:
					goto IL_D36;
				case 194:
					goto IL_F95;
				case 195:
					goto IL_684;
				case 196:
					goto IL_7AD;
				case 197:
					goto IL_114A;
				case 198:
					goto IL_49E;
				case 199:
					goto IL_BEA;
				case 200:
					goto IL_DB2;
				case 201:
					goto IL_C2B;
				case 202:
					goto IL_534;
				case 203:
					goto IL_1403;
				case 204:
					goto IL_6C2;
				case 205:
					goto IL_477;
				case 206:
					goto IL_8A5;
				case 207:
					goto IL_12D8;
				case 208:
					goto IL_EFF;
				case 209:
					goto IL_1004;
				case 210:
					goto IL_D74;
				case 211:
					goto IL_E9A;
				case 212:
					goto IL_C76;
				case 213:
					goto IL_E4F;
				case 214:
					goto IL_E73;
				case 215:
					goto IL_1188;
				case 216:
					goto IL_12CB;
				case 217:
					goto IL_1011;
				case 218:
					goto IL_4C2;
				case 219:
					goto IL_DD6;
				case 220:
					goto IL_1242;
				case 221:
					goto IL_1157;
				case 222:
					goto IL_1116;
				case 223:
					goto IL_CD1;
				default:
					num = (short)351731712;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_3FB:
			this.DEKDirectMessageBCOKey_A21292 = (global::AcpUI.AcpTextBox)target;
			this.DEKDirectMessageBCOKey_A21292.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_41F:
			this.CVBtnDEKVIPOutputFeature_A21346 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_42C:
			this.CVBtnDEKButtonBCO_A21352 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_439:
			this.DEKDirectModeZone_A8538 = (global::AcpUI.AcpComboBox)target;
			this.DEKDirectModeZone_A8538.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45D:
			this.ExpanderDEKDEKButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_46A:
			this.RTDBtnDEKDirectMessageBCO_A8506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_477:
			this.ExpanderDEKDirectStatusGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_484:
			this.DEKVIPOutputFeature_A21346Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_491:
			this.CVBtnDEKButtonFeature_A21353 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49E:
			this.DEKDirectModeKey_A21200 = (global::AcpUI.AcpTextBox)target;
			this.DEKDirectModeKey_A21200.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C2:
			this.DEKDirectStatusBCO_A9196Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4CF:
			this.gridExpanderDEKDEKVIPTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4DC:
			((global::Motorola.MackinawCPS.CoreFeatures.DEK.PageDEK)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DEK.PageDEK)target).Unloaded += this.OnUnloaded;
			return;
			IL_50D:
			this.RTDBtnDEKButtonName_A22568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51A:
			this.DEKChannel_A22565_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_527:
			this.CpyBtnDEKButtonBCO_A21352 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_534:
			this.DEKDirectModeKey_A21200Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_541:
			this.LblDEKDirectModeBCO_A8534 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectModeBCO_A8534.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_565:
			this.ExpanderDEKDEKVIPTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_572:
			this.ExpanderDEKDEKVIPTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_57F:
			this.ExpanderDEKDirectMessageListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_58C:
			this.RTDBtnDEKZone_A22566 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_599:
			this.LblDEKButtonBCO_A21352 = (global::AcpUI.AcpLabel)target;
			this.LblDEKButtonBCO_A21352.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BD:
			this.LblDEKDirectModeZone_A8538 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectModeZone_A8538.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E1:
			this.CpyBtnDEKButtonIndex_A22570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5EE:
			this.CpyBtnDEKButtonFeature_A21353 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5FB:
			this.RTDBtnDEKButtonFeature_A21353 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_608:
			this.DEKVIPInputFeature_A21338 = (global::AcpUI.AcpComboBox)target;
			this.DEKVIPInputFeature_A21338.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_62C:
			this.HLinkDirectMessage = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDirectMessage.Click += this.HLinkClick;
			return;
			IL_650:
			this.CpyBtnDEKVIPName_A22574 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_65D:
			this.CVBtnDEKChannel_A22565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_66A:
			this.ExpanderDEKDirectModeBCOListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_677:
			this.CVBtnDEKButtonKey_A22569 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_684:
			this.RTDBtnDEKDirectModeChannel_A8535 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_691:
			this.DEKZone_A22566_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_69E:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_6C2:
			this.RecNavToolbarExpanderDEKDirectStatusBCOList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDEKDirectStatusBCOList.ModeClick += this.OnModeClick;
			return;
			IL_6E6:
			this.LblDEKButtonFeature_A21353 = (global::AcpUI.AcpLabel)target;
			this.LblDEKButtonFeature_A21353.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_70A:
			this.DEKButtonFeature_A21353_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_717:
			this.gridExpanderDEKDirectModeBCOListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_724:
			this.RecNavToolbarExpanderDEKDEKButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDEKDEKButton.ModeClick += this.OnModeClick;
			return;
			IL_748:
			this.ExpanderDEKDEKButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_755:
			this.LblDEKVIPKey_A22573 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPKey_A22573.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_779:
			this.RTDBtnDEKButtonBCO_A21352 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_786:
			this.RTDBtnDEKDirectModeZone_A8538 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_793:
			this.ExpanderDEKDirectModeBCOList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_7A0:
			this.DEKDirectModeZone_A8538Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7AD:
			this.CpyBtnDEKDirectModeChannel_A8535 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7BA:
			this.DEKButtonName_A22568 = (global::AcpUI.AcpLabel)target;
			this.DEKButtonName_A22568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7DE:
			this.CVBtnDEKVIPKey_A22573 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7EB:
			this.RTDBtnDEKChannel_A22565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7F8:
			this.LblDEKVIPOutputBCO_A21347 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPOutputBCO_A21347.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_81C:
			this.DEKButtonBCO_A21352_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_829:
			this.DEKDirectModeBCO_A8534_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_836:
			this.DEKVIPOutputFeature_A21346 = (global::AcpUI.AcpComboBox)target;
			this.DEKVIPOutputFeature_A21346.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_85A:
			this.DEKVIPInputBCO_A21337_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_867:
			this.ExpanderDEKDEKVIP = (global::AcpUI.AcpExpander)target;
			return;
			IL_874:
			this.DEKVIPOutputBCO_A21347_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_881:
			this.DEKVIPOutputBCO_A21347 = (global::AcpUI.AcpComboBox)target;
			this.DEKVIPOutputBCO_A21347.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A5:
			this.ExpanderDEKDirectStatusBCOListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8B2:
			this.RTDBtnDEKVIPName_A22574 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8BF:
			this.DEKVIPOutputFeature_A21346_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8CC:
			this.CpyBtnDEKVIPOutputFeature_A21346 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8D9:
			this.DEKDirectModeBCO_A8534 = (global::AcpUI.AcpComboBox)target;
			this.DEKDirectModeBCO_A8534.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8FD:
			num = (short)1473221649;
			short num3 = num;
			num = (short)1197708305;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1130:
				this.DEKDirectModeZone_A8538_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			default:
				num = (short)45219840;
				if (num != 0)
				{
				}
				this.DEKVIPOutputBCO_A21347Comp = (global::AcpUI.AcpLabel)target;
				return;
			}
			IL_954:
			this.DEKButtonFeature_A21353 = (global::AcpUI.AcpComboBox)target;
			this.DEKButtonFeature_A21353.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_978:
			this.DEKNumberofDEKBoxes_A8579 = (global::AcpUI.AcpComboBox)target;
			this.DEKNumberofDEKBoxes_A8579.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_99C:
			this.ExpanderDEKDEKButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9A9:
			this.HLinkDEKVIP = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDEKVIP.Click += this.HLinkClick;
			return;
			IL_9CD:
			this.ExpanderDEKDEKButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9DA:
			this.DEKButtonKey_A22569 = (global::AcpUI.AcpTextBox)target;
			this.DEKButtonKey_A22569.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9FE:
			this.LblDEKDirectMessageBCO_A8506 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectMessageBCO_A8506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A22:
			this.DEKDirectMessageBCO_A8506 = (global::AcpUI.AcpComboBox)target;
			this.DEKDirectMessageBCO_A8506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A46:
			this.ExpanderDEKDirectMessageList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A53:
			this.CpyBtnDEKChannel_A22565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A60:
			this.CVBtnDEKVIPInputFeature_A21338 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A6D:
			this.ExpanderDEKDirectModeGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A92:
			goto IL_1410;
			IL_A97:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_AA4:
			this.CpyBtnDEKVIPOutputBCO_A21347 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB1:
			this.CVBtnDEKVIPName_A22574 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ABE:
			this.DEKVIPInputFeature_A21338_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_ACB:
			this.LblDEKChannel_A22565 = (global::AcpUI.AcpLabel)target;
			this.LblDEKChannel_A22565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AEF:
			this.DEKVIPInputBCO_A21337 = (global::AcpUI.AcpComboBox)target;
			this.DEKVIPInputBCO_A21337.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B13:
			this.DEKButtonIndex_A22570_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B20:
			this.DEKDirectModeBCO_A8534Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B2D:
			this.ExpanderDEKDirectMessageGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B3A:
			this.ExpanderDEKDirectMessageListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B47:
			this.CVBtnDEKZone_A22566 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B54:
			this.CVBtnDEKDirectModeZone_A8538 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B61:
			this.CVBtnDEKDirectMessageBCOKey_A21292 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B6E:
			this.CpyBtnDEKVIPInputFeature_A21338 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B7B:
			this.ExpanderDEKDirectModeBCOListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B88:
			this.RTDBtnDEKButtonIndex_A22570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B95:
			this.LblDEKButtonKey_A22569 = (global::AcpUI.AcpLabel)target;
			this.LblDEKButtonKey_A22569.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BB9:
			this.CpyBtnDEKDirectMessageBCOKey_A21292 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BC6:
			this.RecNavToolbarExpanderDEKDirectMessageList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDEKDirectMessageList.ModeClick += this.OnModeClick;
			return;
			IL_BEA:
			this.CVBtnDEKDirectModeKey_A21200 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BF7:
			this.CpyBtnDEKDirectMessageBCO_A8506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C04:
			this.CpyBtnDEKVIPKey_A22573 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C11:
			this.gridExpanderDEKDirectMessageListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C1E:
			this.ExpanderDEKDirectMode = (global::AcpUI.AcpExpander)target;
			return;
			IL_C2B:
			this.CpyBtnDEKDirectModeKey_A21200 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C38:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_C45:
			this.LblDEKButtonIndex_A22570 = (global::AcpUI.AcpLabel)target;
			this.LblDEKButtonIndex_A22570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C69:
			this.CVBtnDEKDirectMessageBCO_A8506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C76:
			this.gridExpanderDEKDirectStatusBCOListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C83:
			this.RTDBtnDEKVIPInputFeature_A21338 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C90:
			this.ExpanderDEKDEKVIPTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C9D:
			this.ExpanderDEKGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_CAA:
			this.DEKDirectMessageBCOKey_A21292Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CB7:
			this.DEKChannel_A22565Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CC4:
			this.ExpanderDEKDEKVIPGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CD1:
			this.DEKDirectStatusBCOKey_A21270Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CDE:
			this.CVBtnDEKVIPInputBCO_A21337 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CEB:
			this.LblDEKNumberofDEKBoxes_A8579GraphicalView = (global::AcpUI.AcpLabel)target;
			this.LblDEKNumberofDEKBoxes_A8579GraphicalView.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D0F:
			this.CVBtnDEKNumberofDEKBoxes_A8579 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D1C:
			this.DEKButtonName_A22568_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D29:
			this.DEKDirectMessageBCO_A8506Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D36:
			this.CVBtnDEKDirectModeChannel_A8535 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D43:
			this.ExpanderDEKDirectMessageListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D50:
			this.LblDEKVIPInputFeature_A21338 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPInputFeature_A21338.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D74:
			this.DEKDirectStatusBCOKey_A21270_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D81:
			this.DEKButtonFeature_A21353Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D8E:
			this.LblDEKVIPInputBCO_A21337 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPInputBCO_A21337.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB2:
			this.LblDEKDirectModeKey_A21200 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectModeKey_A21200.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DD6:
			this.DEKDirectStatusBCOKey_A21270 = (global::AcpUI.AcpTextBox)target;
			this.DEKDirectStatusBCOKey_A21270.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DFA:
			this.CpyBtnDEKButtonKey_A22569 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E07:
			this.DEKButtonIndex_A22570 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DEKButtonIndex_A22570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E2B:
			this.LblDEKDirectMessageBCOKey_A21292 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectMessageBCOKey_A21292.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E4F:
			this.DEKDirectStatusBCO_A9196 = (global::AcpUI.AcpComboBox)target;
			this.DEKDirectStatusBCO_A9196.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E73:
			this.CVBtnDEKDirectStatusBCO_A9196 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E80:
			this.CpyBtnDEKZone_A22566 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E8D:
			this.DEKVIPName_A22574_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E9A:
			this.ExpanderDEKDirectStatusBCOListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EA7:
			this.ExpanderDEKDirectModeBCOListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EB4:
			this.CVBtnDEKVIPOutputBCO_A21347 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EC1:
			this.DEKButtonBCO_A21352 = (global::AcpUI.AcpComboBox)target;
			this.DEKButtonBCO_A21352.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EE5:
			this.CpyBtnDEKNumberofDEKBoxes_A8579 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EF2:
			this.RTDBtnDEKVIPInputBCO_A21337 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EFF:
			this.ExpanderDEKDirectStatusBCOList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_F0C:
			this.ExpanderDEKGraphicview = (global::AcpUI.AcpExpander)target;
			return;
			IL_F19:
			this.ExpanderDEKGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F26:
			this.LblDEKButtonName_A22568 = (global::AcpUI.AcpLabel)target;
			this.LblDEKButtonName_A22568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F4A:
			this.LblDEKNumberofDEKBoxes_A8579 = (global::AcpUI.AcpLabel)target;
			this.LblDEKNumberofDEKBoxes_A8579.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F6E:
			this.DEKZone_A22566Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F7B:
			this.RTDBtnDEKNumberofDEKBoxes_A8579 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F88:
			this.CVBtnDEKDirectModeBCO_A8534 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F95:
			this.LblDEKDirectModeChannel_A8535 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectModeChannel_A8535.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FB9:
			this.DEKZone_A22566 = (global::AcpUI.AcpComboBox)target;
			this.DEKZone_A22566.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FDD:
			this.DEKVIPKey_A22573Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FEA:
			this.DEKVIPName_A22574Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FF7:
			this.gridExpanderDEKDEKButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1004:
			this.DEKDirectStatusBCO_A9196_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1011:
			this.CpyBtnDEKDirectStatusBCO_A9196 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_101E:
			this.GrpBoxExpanderDEKGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_102B:
			this.DEKDirectModeChannel_A8535 = (global::AcpUI.AcpComboBox)target;
			this.DEKDirectModeChannel_A8535.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_104F:
			this.RTDBtnDEKVIPOutputFeature_A21346 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_105C:
			this.LblDEKVIPOutputFeature_A21346 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPOutputFeature_A21346.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1080:
			this.LblDEKVIPName_A22574 = (global::AcpUI.AcpLabel)target;
			this.LblDEKVIPName_A22574.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10A4:
			this.DEKDirectModeChannel_A8535_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_10B1:
			this.DEKVIPInputBCO_A21337Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10BE:
			this.DEKButtonBCO_A21352Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10CB:
			this.CpyBtnDEKDirectModeZone_A8538 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10D8:
			this.CVBtnDEKButtonName_A22568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10E5:
			this.CpyBtnDEKDirectModeBCO_A8534 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10F2:
			this.HLinkDEKGraphicview = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDEKGraphicview.Click += this.HLinkClick;
			return;
			IL_1116:
			this.CpyBtnDEKDirectStatusBCOKey_A21270 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1123:
			this.myDEKGraphicView = (global::ControlHeadGraphicView.DEKGraphicView)target;
			return;
			IL_113D:
			this.CpyBtnDEKVIPInputBCO_A21337 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_114A:
			this.DEKDirectModeChannel_A8535Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1157:
			this.LblDEKDirectStatusBCOKey_A21270 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectStatusBCOKey_A21270.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_117B:
			this.DEKButtonKey_A22569_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1188:
			this.LblDEKDirectStatusBCO_A9196 = (global::AcpUI.AcpLabel)target;
			this.LblDEKDirectStatusBCO_A9196.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11AC:
			this.RTDBtnDEKVIPOutputBCO_A21347 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11B9:
			this.DEKChannel_A22565 = (global::AcpUI.AcpComboBox)target;
			this.DEKChannel_A22565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11DD:
			this.DEKDirectMessageBCO_A8506_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_11EA:
			this.DEKNumberofDEKBoxes_A8579Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11F7:
			this.DEKButtonName_A22568Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1204:
			this.RecNavToolbarExpanderDEKDirectModeBCOList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDEKDirectModeBCOList.ModeClick += this.OnModeClick;
			return;
			IL_1228:
			this.DEKButtonIndex_A22570Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1235:
			this.DEKVIPInputFeature_A21338Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1242:
			this.CVBtnDEKDirectStatusBCOKey_A21270 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_124F:
			this.HLinkDirectStatus = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDirectStatus.Click += this.HLinkClick;
			return;
			IL_1273:
			this.DEKVIPKey_A22573_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1280:
			this.DEKDirectModeKey_A21200_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_128D:
			this.ExpanderDEKDEKVIPTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_129A:
			this.DEKVIPName_A22574 = (global::AcpUI.AcpLabel)target;
			this.DEKVIPName_A22574.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12BE:
			this.RTDBtnDEKDirectModeBCO_A8534 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12CB:
			this.RTDBtnDEKDirectStatusBCO_A9196 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12D8:
			this.ExpanderDEKDirectStatusBCOListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_12E5:
			this.DEKVIPKey_A22573 = (global::AcpUI.AcpTextBox)target;
			this.DEKVIPKey_A22573.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1309:
			num = (short)1356464128;
			short num4 = num;
			this.RecNavToolbarExpanderDEKDEKVIPTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDEKDEKVIPTable.ModeClick += this.OnModeClick;
			return;
			IL_1356:
			this.DEKDirectMessageBCOKey_A21292_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1363:
			this.CpyBtnDEKButtonName_A22568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1370:
			this.ExpanderDEKDirectMessage = (global::AcpUI.AcpExpander)target;
			return;
			IL_137D:
			this.CVBtnDEKButtonIndex_A22570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_138A:
			this.HLinkDirectMode = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDirectMode.Click += this.HLinkClick;
			return;
			IL_13AE:
			this.LblDEKZone_A22566 = (global::AcpUI.AcpLabel)target;
			this.LblDEKZone_A22566.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13D2:
			this.DEKNumberofDEKBoxesGraphicalView = (global::AcpUI.AcpComboBox)target;
			this.DEKNumberofDEKBoxesGraphicalView.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13F6:
			this.DEKButtonKey_A22569Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1403:
			this.ExpanderDEKDirectStatus = (global::AcpUI.AcpExpander)target;
			return;
			IL_1410:
			this.b = true;
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x0073B4E0 File Offset: 0x007396E0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
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
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
			{
				short num = (short)1639972865;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				break;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
			{
				short num = (short)1517813760;
				short num2 = num;
				num = (short)1804603739;
				short num3 = num;
				num = (short)1314853211;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)979435520;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 21:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040038B8 RID: 14520
		private bool a;

		// Token: 0x040038B9 RID: 14521
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040038BA RID: 14522
		internal global::System.Windows.Documents.Hyperlink HLinkDEKGraphicview;

		// Token: 0x040038BB RID: 14523
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040038BC RID: 14524
		internal global::System.Windows.Documents.Hyperlink HLinkDEKVIP;

		// Token: 0x040038BD RID: 14525
		internal global::System.Windows.Documents.Hyperlink HLinkDirectMessage;

		// Token: 0x040038BE RID: 14526
		internal global::System.Windows.Documents.Hyperlink HLinkDirectMode;

		// Token: 0x040038BF RID: 14527
		internal global::System.Windows.Documents.Hyperlink HLinkDirectStatus;

		// Token: 0x040038C0 RID: 14528
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040038C1 RID: 14529
		internal global::AcpUI.AcpExpander ExpanderDEKGraphicview;

		// Token: 0x040038C2 RID: 14530
		internal global::AcpUI.AcpLabel LblDEKNumberofDEKBoxes_A8579GraphicalView;

		// Token: 0x040038C3 RID: 14531
		internal global::AcpUI.AcpComboBox DEKNumberofDEKBoxesGraphicalView;

		// Token: 0x040038C4 RID: 14532
		internal global::ControlHeadGraphicView.DEKGraphicView myDEKGraphicView;

		// Token: 0x040038C5 RID: 14533
		internal global::AcpUI.AcpExpander ExpanderDEKGeneral;

		// Token: 0x040038C6 RID: 14534
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDEKDEKButton;

		// Token: 0x040038C7 RID: 14535
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDEKGeneralPseudo0;

		// Token: 0x040038C8 RID: 14536
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKNumberofDEKBoxes_A8579;

		// Token: 0x040038C9 RID: 14537
		internal global::AcpUI.AcpLabel LblDEKNumberofDEKBoxes_A8579;

		// Token: 0x040038CA RID: 14538
		internal global::AcpUI.AcpComboBox DEKNumberofDEKBoxes_A8579;

		// Token: 0x040038CB RID: 14539
		internal global::AcpUI.AcpRtdButton RTDBtnDEKNumberofDEKBoxes_A8579;

		// Token: 0x040038CC RID: 14540
		internal global::AcpUI.AcpCopyButton CpyBtnDEKNumberofDEKBoxes_A8579;

		// Token: 0x040038CD RID: 14541
		internal global::AcpUI.AcpLabel DEKNumberofDEKBoxes_A8579Comp;

		// Token: 0x040038CE RID: 14542
		internal global::System.Windows.Controls.Grid ExpanderDEKGeneralGrid;

		// Token: 0x040038CF RID: 14543
		internal global::System.Windows.Controls.Grid ExpanderDEKDEKButtonGrid;

		// Token: 0x040038D0 RID: 14544
		internal global::AcpUI.AcpGroupBox ExpanderDEKDEKButtonTableView;

		// Token: 0x040038D1 RID: 14545
		internal global::AcpUI.AcpXamDataPresenter ExpanderDEKDEKButton;

		// Token: 0x040038D2 RID: 14546
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKButtonName_A22568_Col;

		// Token: 0x040038D3 RID: 14547
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKButtonBCO_A21352_Col;

		// Token: 0x040038D4 RID: 14548
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKButtonFeature_A21353_Col;

		// Token: 0x040038D5 RID: 14549
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKButtonIndex_A22570_Col;

		// Token: 0x040038D6 RID: 14550
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKZone_A22566_Col;

		// Token: 0x040038D7 RID: 14551
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKChannel_A22565_Col;

		// Token: 0x040038D8 RID: 14552
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKButtonKey_A22569_Col;

		// Token: 0x040038D9 RID: 14553
		internal global::AcpUI.AcpGroupBox ExpanderDEKDEKButtonSRecView;

		// Token: 0x040038DA RID: 14554
		internal global::System.Windows.Controls.Grid gridExpanderDEKDEKButtonSRecView;

		// Token: 0x040038DB RID: 14555
		internal global::AcpUI.AcpLabel DEKButtonName_A22568;

		// Token: 0x040038DC RID: 14556
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKButtonName_A22568;

		// Token: 0x040038DD RID: 14557
		internal global::AcpUI.AcpLabel LblDEKButtonName_A22568;

		// Token: 0x040038DE RID: 14558
		internal global::AcpUI.AcpRtdButton RTDBtnDEKButtonName_A22568;

		// Token: 0x040038DF RID: 14559
		internal global::AcpUI.AcpCopyButton CpyBtnDEKButtonName_A22568;

		// Token: 0x040038E0 RID: 14560
		internal global::AcpUI.AcpLabel DEKButtonName_A22568Comp;

		// Token: 0x040038E1 RID: 14561
		internal global::AcpUI.AcpComboBox DEKButtonBCO_A21352;

		// Token: 0x040038E2 RID: 14562
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKButtonBCO_A21352;

		// Token: 0x040038E3 RID: 14563
		internal global::AcpUI.AcpLabel LblDEKButtonBCO_A21352;

		// Token: 0x040038E4 RID: 14564
		internal global::AcpUI.AcpRtdButton RTDBtnDEKButtonBCO_A21352;

		// Token: 0x040038E5 RID: 14565
		internal global::AcpUI.AcpCopyButton CpyBtnDEKButtonBCO_A21352;

		// Token: 0x040038E6 RID: 14566
		internal global::AcpUI.AcpLabel DEKButtonBCO_A21352Comp;

		// Token: 0x040038E7 RID: 14567
		internal global::AcpUI.AcpComboBox DEKButtonFeature_A21353;

		// Token: 0x040038E8 RID: 14568
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKButtonFeature_A21353;

		// Token: 0x040038E9 RID: 14569
		internal global::AcpUI.AcpLabel LblDEKButtonFeature_A21353;

		// Token: 0x040038EA RID: 14570
		internal global::AcpUI.AcpRtdButton RTDBtnDEKButtonFeature_A21353;

		// Token: 0x040038EB RID: 14571
		internal global::AcpUI.AcpCopyButton CpyBtnDEKButtonFeature_A21353;

		// Token: 0x040038EC RID: 14572
		internal global::AcpUI.AcpLabel DEKButtonFeature_A21353Comp;

		// Token: 0x040038ED RID: 14573
		internal global::AcpUI.AcpTextBoxSpinner DEKButtonIndex_A22570;

		// Token: 0x040038EE RID: 14574
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKButtonIndex_A22570;

		// Token: 0x040038EF RID: 14575
		internal global::AcpUI.AcpLabel LblDEKButtonIndex_A22570;

		// Token: 0x040038F0 RID: 14576
		internal global::AcpUI.AcpRtdButton RTDBtnDEKButtonIndex_A22570;

		// Token: 0x040038F1 RID: 14577
		internal global::AcpUI.AcpCopyButton CpyBtnDEKButtonIndex_A22570;

		// Token: 0x040038F2 RID: 14578
		internal global::AcpUI.AcpLabel DEKButtonIndex_A22570Comp;

		// Token: 0x040038F3 RID: 14579
		internal global::AcpUI.AcpComboBox DEKZone_A22566;

		// Token: 0x040038F4 RID: 14580
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKZone_A22566;

		// Token: 0x040038F5 RID: 14581
		internal global::AcpUI.AcpLabel LblDEKZone_A22566;

		// Token: 0x040038F6 RID: 14582
		internal global::AcpUI.AcpRtdButton RTDBtnDEKZone_A22566;

		// Token: 0x040038F7 RID: 14583
		internal global::AcpUI.AcpCopyButton CpyBtnDEKZone_A22566;

		// Token: 0x040038F8 RID: 14584
		internal global::AcpUI.AcpLabel DEKZone_A22566Comp;

		// Token: 0x040038F9 RID: 14585
		internal global::AcpUI.AcpComboBox DEKChannel_A22565;

		// Token: 0x040038FA RID: 14586
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKChannel_A22565;

		// Token: 0x040038FB RID: 14587
		internal global::AcpUI.AcpLabel LblDEKChannel_A22565;

		// Token: 0x040038FC RID: 14588
		internal global::AcpUI.AcpRtdButton RTDBtnDEKChannel_A22565;

		// Token: 0x040038FD RID: 14589
		internal global::AcpUI.AcpCopyButton CpyBtnDEKChannel_A22565;

		// Token: 0x040038FE RID: 14590
		internal global::AcpUI.AcpLabel DEKChannel_A22565Comp;

		// Token: 0x040038FF RID: 14591
		internal global::AcpUI.AcpTextBox DEKButtonKey_A22569;

		// Token: 0x04003900 RID: 14592
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKButtonKey_A22569;

		// Token: 0x04003901 RID: 14593
		internal global::AcpUI.AcpLabel LblDEKButtonKey_A22569;

		// Token: 0x04003902 RID: 14594
		internal global::AcpUI.AcpCopyButton CpyBtnDEKButtonKey_A22569;

		// Token: 0x04003903 RID: 14595
		internal global::AcpUI.AcpLabel DEKButtonKey_A22569Comp;

		// Token: 0x04003904 RID: 14596
		internal global::AcpUI.AcpExpander ExpanderDEKDEKVIP;

		// Token: 0x04003905 RID: 14597
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDEKDEKVIPTable;

		// Token: 0x04003906 RID: 14598
		internal global::System.Windows.Controls.Grid ExpanderDEKDEKVIPGrid;

		// Token: 0x04003907 RID: 14599
		internal global::System.Windows.Controls.Grid ExpanderDEKDEKVIPTableGrid;

		// Token: 0x04003908 RID: 14600
		internal global::AcpUI.AcpGroupBox ExpanderDEKDEKVIPTableTableView;

		// Token: 0x04003909 RID: 14601
		internal global::AcpUI.AcpXamDataPresenter ExpanderDEKDEKVIPTable;

		// Token: 0x0400390A RID: 14602
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPName_A22574_Col;

		// Token: 0x0400390B RID: 14603
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPInputBCO_A21337_Col;

		// Token: 0x0400390C RID: 14604
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPInputFeature_A21338_Col;

		// Token: 0x0400390D RID: 14605
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPOutputBCO_A21347_Col;

		// Token: 0x0400390E RID: 14606
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPOutputFeature_A21346_Col;

		// Token: 0x0400390F RID: 14607
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKVIPKey_A22573_Col;

		// Token: 0x04003910 RID: 14608
		internal global::AcpUI.AcpGroupBox ExpanderDEKDEKVIPTableSRecView;

		// Token: 0x04003911 RID: 14609
		internal global::System.Windows.Controls.Grid gridExpanderDEKDEKVIPTableSRecView;

		// Token: 0x04003912 RID: 14610
		internal global::AcpUI.AcpLabel DEKVIPName_A22574;

		// Token: 0x04003913 RID: 14611
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPName_A22574;

		// Token: 0x04003914 RID: 14612
		internal global::AcpUI.AcpLabel LblDEKVIPName_A22574;

		// Token: 0x04003915 RID: 14613
		internal global::AcpUI.AcpRtdButton RTDBtnDEKVIPName_A22574;

		// Token: 0x04003916 RID: 14614
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPName_A22574;

		// Token: 0x04003917 RID: 14615
		internal global::AcpUI.AcpLabel DEKVIPName_A22574Comp;

		// Token: 0x04003918 RID: 14616
		internal global::AcpUI.AcpComboBox DEKVIPInputBCO_A21337;

		// Token: 0x04003919 RID: 14617
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPInputBCO_A21337;

		// Token: 0x0400391A RID: 14618
		internal global::AcpUI.AcpLabel LblDEKVIPInputBCO_A21337;

		// Token: 0x0400391B RID: 14619
		internal global::AcpUI.AcpRtdButton RTDBtnDEKVIPInputBCO_A21337;

		// Token: 0x0400391C RID: 14620
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPInputBCO_A21337;

		// Token: 0x0400391D RID: 14621
		internal global::AcpUI.AcpLabel DEKVIPInputBCO_A21337Comp;

		// Token: 0x0400391E RID: 14622
		internal global::AcpUI.AcpComboBox DEKVIPInputFeature_A21338;

		// Token: 0x0400391F RID: 14623
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPInputFeature_A21338;

		// Token: 0x04003920 RID: 14624
		internal global::AcpUI.AcpLabel LblDEKVIPInputFeature_A21338;

		// Token: 0x04003921 RID: 14625
		internal global::AcpUI.AcpRtdButton RTDBtnDEKVIPInputFeature_A21338;

		// Token: 0x04003922 RID: 14626
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPInputFeature_A21338;

		// Token: 0x04003923 RID: 14627
		internal global::AcpUI.AcpLabel DEKVIPInputFeature_A21338Comp;

		// Token: 0x04003924 RID: 14628
		internal global::AcpUI.AcpComboBox DEKVIPOutputBCO_A21347;

		// Token: 0x04003925 RID: 14629
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPOutputBCO_A21347;

		// Token: 0x04003926 RID: 14630
		internal global::AcpUI.AcpLabel LblDEKVIPOutputBCO_A21347;

		// Token: 0x04003927 RID: 14631
		internal global::AcpUI.AcpRtdButton RTDBtnDEKVIPOutputBCO_A21347;

		// Token: 0x04003928 RID: 14632
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPOutputBCO_A21347;

		// Token: 0x04003929 RID: 14633
		internal global::AcpUI.AcpLabel DEKVIPOutputBCO_A21347Comp;

		// Token: 0x0400392A RID: 14634
		internal global::AcpUI.AcpComboBox DEKVIPOutputFeature_A21346;

		// Token: 0x0400392B RID: 14635
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPOutputFeature_A21346;

		// Token: 0x0400392C RID: 14636
		internal global::AcpUI.AcpLabel LblDEKVIPOutputFeature_A21346;

		// Token: 0x0400392D RID: 14637
		internal global::AcpUI.AcpRtdButton RTDBtnDEKVIPOutputFeature_A21346;

		// Token: 0x0400392E RID: 14638
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPOutputFeature_A21346;

		// Token: 0x0400392F RID: 14639
		internal global::AcpUI.AcpLabel DEKVIPOutputFeature_A21346Comp;

		// Token: 0x04003930 RID: 14640
		internal global::AcpUI.AcpTextBox DEKVIPKey_A22573;

		// Token: 0x04003931 RID: 14641
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKVIPKey_A22573;

		// Token: 0x04003932 RID: 14642
		internal global::AcpUI.AcpLabel LblDEKVIPKey_A22573;

		// Token: 0x04003933 RID: 14643
		internal global::AcpUI.AcpCopyButton CpyBtnDEKVIPKey_A22573;

		// Token: 0x04003934 RID: 14644
		internal global::AcpUI.AcpLabel DEKVIPKey_A22573Comp;

		// Token: 0x04003935 RID: 14645
		internal global::AcpUI.AcpExpander ExpanderDEKDirectMessage;

		// Token: 0x04003936 RID: 14646
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDEKDirectMessageList;

		// Token: 0x04003937 RID: 14647
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectMessageGrid;

		// Token: 0x04003938 RID: 14648
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectMessageListGrid;

		// Token: 0x04003939 RID: 14649
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectMessageListTableView;

		// Token: 0x0400393A RID: 14650
		internal global::AcpUI.AcpXamDataPresenter ExpanderDEKDirectMessageList;

		// Token: 0x0400393B RID: 14651
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectMessageBCO_A8506_Col;

		// Token: 0x0400393C RID: 14652
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectMessageBCOKey_A21292_Col;

		// Token: 0x0400393D RID: 14653
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectMessageListSRecView;

		// Token: 0x0400393E RID: 14654
		internal global::System.Windows.Controls.Grid gridExpanderDEKDirectMessageListSRecView;

		// Token: 0x0400393F RID: 14655
		internal global::AcpUI.AcpComboBox DEKDirectMessageBCO_A8506;

		// Token: 0x04003940 RID: 14656
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectMessageBCO_A8506;

		// Token: 0x04003941 RID: 14657
		internal global::AcpUI.AcpLabel LblDEKDirectMessageBCO_A8506;

		// Token: 0x04003942 RID: 14658
		internal global::AcpUI.AcpRtdButton RTDBtnDEKDirectMessageBCO_A8506;

		// Token: 0x04003943 RID: 14659
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectMessageBCO_A8506;

		// Token: 0x04003944 RID: 14660
		internal global::AcpUI.AcpLabel DEKDirectMessageBCO_A8506Comp;

		// Token: 0x04003945 RID: 14661
		internal global::AcpUI.AcpTextBox DEKDirectMessageBCOKey_A21292;

		// Token: 0x04003946 RID: 14662
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectMessageBCOKey_A21292;

		// Token: 0x04003947 RID: 14663
		internal global::AcpUI.AcpLabel LblDEKDirectMessageBCOKey_A21292;

		// Token: 0x04003948 RID: 14664
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectMessageBCOKey_A21292;

		// Token: 0x04003949 RID: 14665
		internal global::AcpUI.AcpLabel DEKDirectMessageBCOKey_A21292Comp;

		// Token: 0x0400394A RID: 14666
		internal global::AcpUI.AcpExpander ExpanderDEKDirectMode;

		// Token: 0x0400394B RID: 14667
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDEKDirectModeBCOList;

		// Token: 0x0400394C RID: 14668
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectModeGrid;

		// Token: 0x0400394D RID: 14669
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectModeBCOListGrid;

		// Token: 0x0400394E RID: 14670
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectModeBCOListTableView;

		// Token: 0x0400394F RID: 14671
		internal global::AcpUI.AcpXamDataPresenter ExpanderDEKDirectModeBCOList;

		// Token: 0x04003950 RID: 14672
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectModeBCO_A8534_Col;

		// Token: 0x04003951 RID: 14673
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectModeZone_A8538_Col;

		// Token: 0x04003952 RID: 14674
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectModeChannel_A8535_Col;

		// Token: 0x04003953 RID: 14675
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectModeKey_A21200_Col;

		// Token: 0x04003954 RID: 14676
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectModeBCOListSRecView;

		// Token: 0x04003955 RID: 14677
		internal global::System.Windows.Controls.Grid gridExpanderDEKDirectModeBCOListSRecView;

		// Token: 0x04003956 RID: 14678
		internal global::AcpUI.AcpComboBox DEKDirectModeBCO_A8534;

		// Token: 0x04003957 RID: 14679
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectModeBCO_A8534;

		// Token: 0x04003958 RID: 14680
		internal global::AcpUI.AcpLabel LblDEKDirectModeBCO_A8534;

		// Token: 0x04003959 RID: 14681
		internal global::AcpUI.AcpRtdButton RTDBtnDEKDirectModeBCO_A8534;

		// Token: 0x0400395A RID: 14682
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectModeBCO_A8534;

		// Token: 0x0400395B RID: 14683
		internal global::AcpUI.AcpLabel DEKDirectModeBCO_A8534Comp;

		// Token: 0x0400395C RID: 14684
		internal global::AcpUI.AcpComboBox DEKDirectModeZone_A8538;

		// Token: 0x0400395D RID: 14685
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectModeZone_A8538;

		// Token: 0x0400395E RID: 14686
		internal global::AcpUI.AcpLabel LblDEKDirectModeZone_A8538;

		// Token: 0x0400395F RID: 14687
		internal global::AcpUI.AcpRtdButton RTDBtnDEKDirectModeZone_A8538;

		// Token: 0x04003960 RID: 14688
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectModeZone_A8538;

		// Token: 0x04003961 RID: 14689
		internal global::AcpUI.AcpLabel DEKDirectModeZone_A8538Comp;

		// Token: 0x04003962 RID: 14690
		internal global::AcpUI.AcpComboBox DEKDirectModeChannel_A8535;

		// Token: 0x04003963 RID: 14691
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectModeChannel_A8535;

		// Token: 0x04003964 RID: 14692
		internal global::AcpUI.AcpLabel LblDEKDirectModeChannel_A8535;

		// Token: 0x04003965 RID: 14693
		internal global::AcpUI.AcpRtdButton RTDBtnDEKDirectModeChannel_A8535;

		// Token: 0x04003966 RID: 14694
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectModeChannel_A8535;

		// Token: 0x04003967 RID: 14695
		internal global::AcpUI.AcpLabel DEKDirectModeChannel_A8535Comp;

		// Token: 0x04003968 RID: 14696
		internal global::AcpUI.AcpTextBox DEKDirectModeKey_A21200;

		// Token: 0x04003969 RID: 14697
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectModeKey_A21200;

		// Token: 0x0400396A RID: 14698
		internal global::AcpUI.AcpLabel LblDEKDirectModeKey_A21200;

		// Token: 0x0400396B RID: 14699
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectModeKey_A21200;

		// Token: 0x0400396C RID: 14700
		internal global::AcpUI.AcpLabel DEKDirectModeKey_A21200Comp;

		// Token: 0x0400396D RID: 14701
		internal global::AcpUI.AcpExpander ExpanderDEKDirectStatus;

		// Token: 0x0400396E RID: 14702
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDEKDirectStatusBCOList;

		// Token: 0x0400396F RID: 14703
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectStatusGrid;

		// Token: 0x04003970 RID: 14704
		internal global::System.Windows.Controls.Grid ExpanderDEKDirectStatusBCOListGrid;

		// Token: 0x04003971 RID: 14705
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectStatusBCOListTableView;

		// Token: 0x04003972 RID: 14706
		internal global::AcpUI.AcpXamDataPresenter ExpanderDEKDirectStatusBCOList;

		// Token: 0x04003973 RID: 14707
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectStatusBCO_A9196_Col;

		// Token: 0x04003974 RID: 14708
		internal global::Infragistics.Windows.DataPresenter.UnboundField DEKDirectStatusBCOKey_A21270_Col;

		// Token: 0x04003975 RID: 14709
		internal global::AcpUI.AcpGroupBox ExpanderDEKDirectStatusBCOListSRecView;

		// Token: 0x04003976 RID: 14710
		internal global::System.Windows.Controls.Grid gridExpanderDEKDirectStatusBCOListSRecView;

		// Token: 0x04003977 RID: 14711
		internal global::AcpUI.AcpComboBox DEKDirectStatusBCO_A9196;

		// Token: 0x04003978 RID: 14712
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectStatusBCO_A9196;

		// Token: 0x04003979 RID: 14713
		internal global::AcpUI.AcpLabel LblDEKDirectStatusBCO_A9196;

		// Token: 0x0400397A RID: 14714
		internal global::AcpUI.AcpRtdButton RTDBtnDEKDirectStatusBCO_A9196;

		// Token: 0x0400397B RID: 14715
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectStatusBCO_A9196;

		// Token: 0x0400397C RID: 14716
		internal global::AcpUI.AcpLabel DEKDirectStatusBCO_A9196Comp;

		// Token: 0x0400397D RID: 14717
		internal global::AcpUI.AcpTextBox DEKDirectStatusBCOKey_A21270;

		// Token: 0x0400397E RID: 14718
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDEKDirectStatusBCOKey_A21270;

		// Token: 0x0400397F RID: 14719
		internal global::AcpUI.AcpLabel LblDEKDirectStatusBCOKey_A21270;

		// Token: 0x04003980 RID: 14720
		internal global::AcpUI.AcpCopyButton CpyBtnDEKDirectStatusBCOKey_A21270;

		// Token: 0x04003981 RID: 14721
		internal global::AcpUI.AcpLabel DEKDirectStatusBCOKey_A21270Comp;

		// Token: 0x04003982 RID: 14722
		private bool b;
	}
}
