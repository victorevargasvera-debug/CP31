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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x0200057C RID: 1404
	public class PageConventionalPersonality : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600C20D RID: 49677 RVA: 0x00B55A0C File Offset: 0x00B53C0C
		public PageConventionalPersonality()
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

		// Token: 0x0600C20E RID: 49678 RVA: 0x00B55A44 File Offset: 0x00B53C44
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1455423488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)928186373;
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
							num = (short)152895490;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acpExpander != null)
									{
										num = (short)1864433669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									num = (short)273219587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D5;
									}
									continue;
								case 3:
									goto IL_1DC;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)655753217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									goto IL_E8;
								case 5:
								{
									num = (short)1567566896;
									short num3 = num;
									num = (short)1899244592;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_E8;
									default:
										num = (short)111804416;
										if (num != 0)
										{
										}
										base.Expanders.Add(acpExpander);
										num = (short)374865926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_D5;
								IL_E8:
								num = (short)287768576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_117:
								num = (short)2000158724;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D5:
								goto IL_117;
							}
							IL_1DC:
							goto IL_2BF;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1FE;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1EB:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)599719938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1779564544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_252;
								case 2:
									goto IL_250;
								}
								goto IL_1FE;
							}
							IL_250:
							IL_252:
							goto EndFinally_9;
							IL_1FE:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)305266689;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1EB;
							EndFinally_9:;
						}
						goto IL_253;
						IL_2BF:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)197591048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3EC;
					case 2:
						num = (short)549126145;
						if (num != 0)
						{
						}
						goto IL_253;
					case 3:
						this.RecNavToolbarPageConventionalPersonality.ChildToolbars.Add(this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable);
						this.RecNavToolbarPageConventionalPersonality.ChildToolbars.Add(this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable);
						obj = null;
						obj = this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.MyRecordsetDataSource;
						num = (short)1949564932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (obj != null)
						{
							num = (short)1326317575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EC;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.MyDataPresenter = this.ExpanderConventionalPersonalityOneTouchTable;
						num = (short)928317442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)840957952;
						short num4 = num;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.MyDataPresenter = this.ExpanderConventionalPersonalityFrequencyOptionsTable;
						num = (short)1015676929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_2E7;
					case 9:
						if (obj != null)
						{
							num = (short)805699590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					}
					IL_6D:
					if (!this.a)
					{
						num = (short)1555234819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_253:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1763835904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					obj = this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.MyRecordsetDataSource;
					num = (short)1642463241;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E7:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x00B55EB8 File Offset: 0x00B540B8
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)929693696;
					short num2 = num;
					switch (num3)
					{
					case 0:
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)1590231042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!this.a)
						{
							return;
						}
						num = (short)1040283487;
						short num4 = num;
						num = (short)2105505631;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A4;
						default:
							num = (short)1204224001;
							if (num != 0)
							{
							}
							num = (short)1696858112;
							if (num != 0)
							{
							}
							num = (short)184942592;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_44;
				}
				return;
			}
			IL_44:
			this.RecNavToolbarPageConventionalPersonality.DataContext = null;
			this.RecNavToolbarPageConventionalPersonality.DataContext = null;
			this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.DataContext = null;
			this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.DataContext = null;
			this.RecNavToolbarPageConventionalPersonality.MyDataPresenter = null;
			this.RecNavToolbarPageConventionalPersonality.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.MyDataPresenter = null;
			IL_A4:
			num = (short)1719664641;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600C210 RID: 49680 RVA: 0x00B56040 File Offset: 0x00B54240
		public override void SetDataContext()
		{
			short num = (short)431423492;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2059);
					num = (short)1364131843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)392167431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalPersonality).MySecondaryRecordsetDataSource = null;
					num = (short)295043072;
					short num3 = num;
					num = (short)2122514438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_7F;
				case 3:
					num = (short)1513291777;
					if (num != 0)
					{
					}
					goto IL_7F;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					goto IL_235;
				case 6:
					goto IL_1C4;
				case 7:
					goto IL_1F3;
				case 8:
					if (feature != null)
					{
						num = (short)87293957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1548288000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num = (short)598474754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F:
				num = (short)427701937;
				short num4 = num;
				num = (short)682899121;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1F3:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2059);
					num = (short)1612513288;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)393412608;
					if (num != 0)
					{
					}
					this.RecNavToolbarPageConventionalPersonality.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					num = (short)625672193;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1C4:
			return;
			IL_235:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalPersonality).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600C211 RID: 49681 RVA: 0x00B56288 File Offset: 0x00B54488
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)1908015104;
			switch (num)
			{
			default:
			{
				num = (short)326172692;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.MyRecordsetDataSource;
						num = (short)660865056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						collectionView.MoveCurrentTo(frequencyOptionsInner);
						num = (short)359464983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1565720588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					}
					case 3:
						goto IL_737;
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner oneTouchInner;
						collectionView2.MoveCurrentTo(oneTouchInner);
						num = (short)167772170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)1616379917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F5;
					}
					case 6:
						num = (short)503709724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageConventionalPersonality.MyRecordsetDataSource;
						num = (short)703987712;
						short num3 = num;
						num = (short)101187623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1185153048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)37879811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)176750603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_5CB;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)334364672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)318439440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2040004646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)2005532690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner oneTouchInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)collectionView2.CurrentItem;
						num = (short)993984547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner != null)
						{
							num = (short)893779969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53D;
					}
					case 16:
						goto IL_3C9;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧꿩铫黭釯鳱郳鏵諷맹鏻都盿朁樃爅愇攉戋漍簏䈑焓搕欗甙爛缝䰟䬡倣弥朧䐩䤫稭弯䜱圳帵氷嬹帻刽┿", a_))
						{
							num = (short)486277129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (!collectionView2.IsCurrentAfterLast)
						{
							collectionView2.MoveCurrentToFirst();
							num = (short)707461150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1386108988;
						short num4 = num;
						num = (short)1538938940;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_53D;
						default:
							num = (short)95748096;
							if (num != 0)
							{
							}
							num = (short)987299862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)800456741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						switch (0)
						{
						case 0:
							goto IL_ED;
						}
						continue;
					case 21:
						num = (short)1424293896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)1212219421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_301;
					case 24:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.MyRecordsetDataSource;
						num = (short)1685717019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_301;
					case 26:
						goto IL_737;
					case 27:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)1888419841;
							if (num != 0)
							{
							}
							num = (short)1529085988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_737;
					}
					case 28:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧뫩跫觭闯뇱鯳飵軷鿹鋻諽槿洁樃朅搇娉椋簍挏紑稓眕琗猙栛朝", a_))
						{
							num = (short)1387134983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E4;
					case 29:
						goto IL_3A0;
					case 30:
						goto IL_5A2;
					case 31:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧꿩铫黭釯鳱郳鏵諷맹鏻都盿朁樃爅愇攉戋漍簏䈑焓搕欗甙爛缝䰟䬡倣弥渧堩䤫弭䔯圱娳唵䄷甹䰻䨽⤿ⵁ⩃㕅᱇⭉⹋≍㕏", a_))
						{
							num = (short)600571925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_737;
					case 32:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)2133196814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 33:
						goto IL_4E4;
					case 34:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)948764705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner oneTouchInner;
						if (oneTouchInner != null)
						{
							num = (short)432340996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1122566149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)collectionView.CurrentItem;
						num = (short)880410639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_301;
					case 38:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)84738067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)508887065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)642187298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E4;
					}
					}
					IL_ED:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)2002059270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_301:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)702218266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E4:
					num = (short)687210527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53D:
					num = (short)988282882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_737:
					num = (short)403505169;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F5:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_3A0:
				goto IL_2F5;
				IL_3C9:
				return;
				IL_5A2:
				IL_5CB:
				goto IL_2F5;
			}
			}
		}

		// Token: 0x0600C212 RID: 49682 RVA: 0x00B56A28 File Offset: 0x00B54C28
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2137128960;
			short num2 = num;
			num = (short)1995487334;
			short num3 = num;
			num = (short)1100855398;
			switch (num3 == num)
			{
			}
			num = (short)1019805697;
			if (num != 0)
			{
			}
			num = (short)2029322240;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600C213 RID: 49683 RVA: 0x00B56ADC File Offset: 0x00B54CDC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2057502720;
			short num2 = num;
			num = (short)1327389226;
			short num3 = num;
			num = (short)951671338;
			switch (num3 == num)
			{
			}
			num = (short)1970339841;
			if (num != 0)
			{
			}
			num = (short)2042560512;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x00B56B8C File Offset: 0x00B54D8C
		internal void OnExpanderConventionalPersonalityFrequencyOptionsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1963589632;
					short num2 = num;
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.SyncDataSources();
						num = (short)1319305218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (myRecordsetDataSource == null)
						{
							goto IL_157;
						}
						num = (short)770120894;
						short num4 = num;
						num = (short)1035148478;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9E;
						default:
							num = (short)1926692864;
							if (num != 0)
							{
							}
							num = (short)90308608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_155;
					}
					goto IL_46;
				}
				IL_155:
				IL_157:
				this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.TableMode = false;
				return;
			}
			IL_46:
			num = (short)370147329;
			if (num != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.MyRecordsetDataSource;
			IL_9E:
			num = (short)1070530561;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x00B56CFC File Offset: 0x00B54EFC
		internal void OnExpanderConventionalPersonalityOneTouchTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)752615424;
					short num2 = num;
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.SyncDataSources();
						num = (short)544079874;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (myRecordsetDataSource == null)
						{
							goto IL_157;
						}
						num = (short)328485281;
						short num4 = num;
						num = (short)998263201;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_77;
						default:
							num = (short)725024769;
							if (num != 0)
							{
							}
							num = (short)2121531392;
							if (num != 0)
							{
							}
							num = (short)1344143360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_155;
					}
					goto IL_46;
				}
				IL_155:
				IL_157:
				this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.TableMode = false;
				return;
			}
			IL_46:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.MyRecordsetDataSource;
			IL_77:
			num = (short)605683713;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x00B56E6C File Offset: 0x00B5506C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num = (short)1059520786;
			short num2 = num;
			num = (short)804520210;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)2110849024;
				short num3 = num;
				break;
			}
			}
			num = (short)1496383488;
			if (num != 0)
			{
			}
			num = (short)319225857;
			if (num != 0)
			{
			}
			if (!this.b)
			{
				this.b = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛菟跡解雥蟧蓩觫胭蓯\uddf1音駵雷賹駻都瓿欁欃栅椇昉⤋㰍‏焑笓砕縗猙笛欝刟䌡倣伥䜧䐩̫䴭弯就䈳匵嘷丹唻儽⸿⍁⡃捅穇穉㱋⭍≏⅑㭓㡕㥗㙙㕛⩝ᥟ䵡ݣ॥٧ᱩ५mѯ᭱᭳ᡵ᥷ᙹ౻᭽揄벑", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x00B56F48 File Offset: 0x00B55148
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1480982528;
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
					goto IL_3EA3;
				case 2:
					num = (short)1294794753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_4C63;
				case 2:
					goto IL_178B;
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
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
					goto IL_6A4E;
				case 38:
					goto IL_1E9E;
				case 39:
					goto IL_4310;
				case 40:
					goto IL_1767;
				case 41:
					goto IL_65E5;
				case 42:
					goto IL_12D8;
				case 43:
					goto IL_488A;
				case 44:
					goto IL_61A6;
				case 45:
					goto IL_6704;
				case 46:
					goto IL_5A2A;
				case 47:
					goto IL_50CF;
				case 48:
					goto IL_28FE;
				case 49:
					goto IL_6A2A;
				case 50:
					goto IL_5809;
				case 51:
					goto IL_63A0;
				case 52:
					goto IL_479A;
				case 53:
					goto IL_6291;
				case 54:
					goto IL_5CEE;
				case 55:
					goto IL_4AB8;
				case 56:
					goto IL_2769;
				case 57:
					goto IL_1431;
				case 58:
					goto IL_4E7A;
				case 59:
					goto IL_272B;
				case 60:
					goto IL_2D2C;
				case 61:
					goto IL_2169;
				case 62:
					goto IL_3B17;
				case 63:
					goto IL_66EA;
				case 64:
					goto IL_62D9;
				case 65:
					goto IL_16C4;
				case 66:
					goto IL_4711;
				case 67:
					goto IL_13D6;
				case 68:
					goto IL_46EA;
				case 69:
					goto IL_5626;
				case 70:
					goto IL_27E2;
				case 71:
					goto IL_5091;
				case 72:
					goto IL_24EA;
				case 73:
					goto IL_220C;
				case 74:
					goto IL_3CBF;
				case 75:
					goto IL_6063;
				case 76:
					goto IL_611D;
				case 77:
					goto IL_57FC;
				case 78:
					goto IL_5EB7;
				case 79:
					goto IL_22E3;
				case 80:
					goto IL_1971;
				case 81:
					goto IL_69EC;
				case 82:
					goto IL_469F;
				case 83:
					goto IL_4FDA;
				case 84:
					goto IL_2A58;
				case 85:
					goto IL_5049;
				case 86:
					goto IL_2E7C;
				case 87:
					goto IL_6647;
				case 88:
					goto IL_26E0;
				case 89:
					goto IL_4CB8;
				case 90:
					goto IL_1C8A;
				case 91:
					goto IL_341E;
				case 92:
					goto IL_5236;
				case 93:
					goto IL_5243;
				case 94:
					goto IL_4D99;
				case 95:
					goto IL_5BF3;
				case 96:
					goto IL_1A69;
				case 97:
					goto IL_5311;
				case 98:
					goto IL_3E40;
				case 99:
					goto IL_4284;
				case 100:
					goto IL_4F13;
				case 101:
					goto IL_2922;
				case 102:
					goto IL_2029;
				case 103:
					goto IL_47BE;
				case 104:
					goto IL_2C52;
				case 105:
					goto IL_53A7;
				case 106:
					goto IL_42DC;
				case 107:
					goto IL_42E9;
				case 108:
					goto IL_3BB0;
				case 109:
					goto IL_313D;
				case 110:
					goto IL_5189;
				case 111:
					goto IL_336E;
				case 112:
					goto IL_3CFD;
				case 113:
					goto IL_3ED9;
				case 114:
					goto IL_2EEB;
				case 115:
					goto IL_59A1;
				case 116:
					goto IL_3C29;
				case 117:
					goto IL_2875;
				case 118:
					goto IL_1472;
				case 119:
					goto IL_472B;
				case 120:
					goto IL_6362;
				case 121:
					goto IL_648E;
				case 122:
					goto IL_2376;
				case 123:
					goto IL_19ED;
				case 124:
					goto IL_2D9B;
				case 125:
					goto IL_4C56;
				case 126:
					goto IL_3604;
				case 127:
					goto IL_1A8D;
				case 128:
					goto IL_21C1;
				case 129:
					goto IL_3FC4;
				case 130:
					goto IL_4F3A;
				case 131:
					goto IL_4334;
				case 132:
					goto IL_40BF;
				case 133:
					goto IL_328D;
				case 134:
					goto IL_3DAD;
				case 135:
					goto IL_1EB8;
				case 136:
					goto IL_57A4;
				case 137:
					goto IL_4DD7;
				case 138:
					goto IL_6284;
				case 139:
					goto IL_63F8;
				case 140:
					goto IL_5FA2;
				case 141:
					goto IL_5548;
				case 142:
					goto IL_4BA6;
				case 143:
					goto IL_61E4;
				case 144:
					goto IL_2806;
				case 145:
					goto IL_2BA5;
				case 146:
					goto IL_1CC8;
				case 147:
					goto IL_3A53;
				case 148:
					goto IL_6A1D;
				case 149:
					goto IL_5DDC;
				case 150:
					goto IL_2B36;
				case 151:
					goto IL_46F7;
				case 152:
					goto IL_5C3E;
				case 153:
					goto IL_34CE;
				case 154:
					goto IL_43A6;
				case 155:
					goto IL_16AA;
				case 156:
					goto IL_4453;
				case 157:
					goto IL_4D06;
				case 158:
					goto IL_1DB3;
				case 159:
					goto IL_52C9;
				case 160:
					goto IL_32C1;
				case 161:
					goto IL_1D10;
				case 162:
					goto IL_5D6A;
				case 163:
					goto IL_54A5;
				case 164:
					goto IL_48AE;
				case 165:
					goto IL_45D8;
				case 166:
					goto IL_33D3;
				case 167:
					goto IL_655F;
				case 168:
					goto IL_4341;
				case 169:
					goto IL_5EF5;
				case 170:
					goto IL_4DA6;
				case 171:
					goto IL_4B10;
				case 172:
					goto IL_43B3;
				case 173:
					goto IL_6199;
				case 174:
					goto IL_2CB7;
				case 175:
					goto IL_2F50;
				case 176:
					goto IL_302E;
				case 177:
					goto IL_3D93;
				case 178:
					goto IL_24DD;
				case 179:
					goto IL_2C86;
				case 180:
					goto IL_5127;
				case 181:
					goto IL_364F;
				case 182:
					goto IL_615B;
				case 183:
					goto IL_1259;
				case 184:
					goto IL_46D0;
				case 185:
					goto IL_641F;
				case 186:
					goto IL_1F55;
				case 187:
					goto IL_16E8;
				case 188:
					goto IL_1AB1;
				case 189:
					goto IL_5335;
				case 190:
					goto IL_21A7;
				case 191:
					goto IL_4C18;
				case 192:
					goto IL_1FC4;
				case 193:
					goto IL_3D52;
				case 194:
					goto IL_1807;
				case 195:
					goto IL_60DF;
				case 196:
					goto IL_34C1;
				case 197:
					goto IL_1C35;
				case 198:
					goto IL_16B7;
				case 199:
					goto IL_6168;
				case 200:
					goto IL_5C62;
				case 201:
					goto IL_1581;
				case 202:
					goto IL_3E19;
				case 203:
					goto IL_3A77;
				case 204:
					goto IL_3FDE;
				case 205:
					goto IL_1458;
				case 206:
					goto IL_1CAE;
				case 207:
					goto IL_2240;
				case 208:
					goto IL_5711;
				case 209:
					goto IL_39A6;
				case 210:
					goto IL_3B62;
				case 211:
					goto IL_1309;
				case 212:
					goto IL_260C;
				case 213:
					goto IL_147F;
				case 214:
					goto IL_67E2;
				case 215:
					goto IL_6878;
				case 216:
					goto IL_4FC0;
				case 217:
					goto IL_59C5;
				case 218:
					goto IL_5994;
				case 219:
					goto IL_1424;
				case 220:
					goto IL_68DA;
				case 221:
					goto IL_2B12;
				case 222:
					goto IL_1FD1;
				case 223:
					goto IL_5CB0;
				case 224:
					goto IL_3388;
				case 225:
					goto IL_64E3;
				case 226:
					goto IL_2EC7;
				case 227:
					goto IL_5229;
				case 228:
					goto IL_6609;
				case 229:
					goto IL_1D8C;
				case 230:
					goto IL_5C6F;
				case 231:
					goto IL_63DE;
				case 232:
					goto IL_5932;
				case 233:
					goto IL_3090;
				case 234:
					goto IL_151F;
				case 235:
					goto IL_6728;
				case 236:
					goto IL_1E84;
				case 237:
					goto IL_30FF;
				case 238:
					goto IL_38B5;
				case 239:
					goto IL_3968;
				case 240:
					goto IL_5DE9;
				case 241:
					goto IL_28B3;
				case 242:
					goto IL_3B48;
				case 243:
					goto IL_51BA;
				case 244:
					goto IL_3F48;
				case 245:
					goto IL_6386;
				case 246:
					goto IL_3235;
				case 247:
					goto IL_4050;
				case 248:
					goto IL_4E94;
				case 249:
					goto IL_26B9;
				case 250:
					goto IL_4F8F;
				case 251:
					goto IL_12FC;
				case 252:
					goto IL_3161;
				case 253:
					goto IL_2F0F;
				case 254:
					goto IL_3ECC;
				case 255:
					goto IL_4012;
				case 256:
					goto IL_3EA8;
				case 257:
					goto IL_5925;
				case 258:
					goto IL_29BB;
				case 259:
					goto IL_37BD;
				case 260:
					goto IL_1CBB;
				case 261:
					goto IL_4927;
				case 262:
					goto IL_4460;
				case 263:
					goto IL_2485;
				case 264:
					goto IL_64BF;
				case 265:
					goto IL_4769;
				case 266:
					goto IL_5C89;
				case 267:
					goto IL_43F1;
				case 268:
					goto IL_40F3;
				case 269:
					goto IL_2EAD;
				case 270:
					goto IL_14B0;
				case 271:
					goto IL_123F;
				case 272:
					goto IL_4583;
				case 273:
					goto IL_571E;
				case 274:
					goto IL_4EE2;
				case 275:
					goto IL_1388;
				case 276:
					goto IL_4ADF;
				case 277:
					goto IL_5429;
				case 278:
					goto IL_62FD;
				case 279:
					goto IL_4E3C;
				case 280:
					goto IL_67BE;
				case 281:
					goto IL_5B91;
				case 282:
					goto IL_1316;
				case 283:
					goto IL_4E15;
				case 284:
					goto IL_4EA1;
				case 285:
					goto IL_6393;
				case 286:
					goto IL_48DF;
				case 287:
					goto IL_6918;
				case 288:
					goto IL_44FD;
				case 289:
					goto IL_48D2;
				case 290:
					goto IL_1FEB;
				case 291:
					goto IL_2FA8;
				case 292:
					goto IL_6809;
				case 293:
					goto IL_5F71;
				case 294:
					goto IL_1686;
				case 295:
					goto IL_535C;
				case 296:
					goto IL_2CF8;
				case 297:
					goto IL_5586;
				case 298:
					goto IL_2FE6;
				case 299:
					goto IL_144B;
				case 300:
					goto IL_442F;
				case 301:
					goto IL_128D;
				case 302:
					goto IL_66DD;
				case 303:
					goto IL_3076;
				case 304:
					goto IL_5250;
				case 305:
					goto IL_3C81;
				case 306:
					goto IL_47EF;
				case 307:
					goto IL_2949;
				case 308:
					goto IL_13BC;
				case 309:
					goto IL_4A53;
				case 310:
					goto IL_4239;
				case 311:
					goto IL_53E8;
				case 312:
					goto IL_1AFF;
				case 313:
					goto IL_3934;
				case 314:
					goto IL_13AF;
				case 315:
					goto IL_4BCD;
				case 316:
					goto IL_55A0;
				case 317:
					goto IL_3228;
				case 318:
					goto IL_1E3C;
				case 319:
					goto IL_25DB;
				case 320:
					goto IL_2AE1;
				case 321:
					goto IL_3A22;
				case 322:
					goto IL_22A5;
				case 323:
					goto IL_3BD4;
				case 324:
					goto IL_574F;
				case 325:
					goto IL_3FAA;
				case 326:
					goto IL_2813;
				case 327:
					goto IL_5AF1;
				case 328:
					goto IL_2A7C;
				case 329:
					goto IL_275C;
				case 330:
					goto IL_5602;
				case 331:
					goto IL_2B98;
				case 332:
					goto IL_40E6;
				case 333:
					goto IL_3E7E;
				case 334:
					goto IL_2492;
				case 335:
					goto IL_293C;
				case 336:
					goto IL_3891;
				case 337:
					goto IL_382C;
				case 338:
					goto IL_1893;
				case 339:
					goto IL_4CF9;
				case 340:
					goto IL_5A75;
				case 341:
					goto IL_2F29;
				case 342:
					goto IL_197E;
				case 343:
					goto IL_1C28;
				case 344:
					goto IL_1B6E;
				case 345:
					goto IL_2AA0;
				case 346:
					goto IL_4654;
				case 347:
					goto IL_31D0;
				case 348:
					goto IL_2576;
				case 349:
					goto IL_28A6;
				case 350:
					goto IL_13A2;
				case 351:
					goto IL_1D37;
				case 352:
					goto IL_49BA;
				case 353:
					goto IL_25CE;
				case 354:
					goto IL_6997;
				case 355:
					goto IL_183B;
				case 356:
					goto IL_3585;
				case 357:
					goto IL_259A;
				case 358:
					goto IL_3A84;
				case 359:
					goto IL_67EF;
				case 360:
					goto IL_2A34;
				case 361:
					goto IL_35AC;
				case 362:
					goto IL_2383;
				case 363:
					goto IL_6766;
				case 364:
					goto IL_2B50;
				case 365:
					goto IL_57EF;
				case 366:
					goto IL_3547;
				case 367:
					goto IL_4C0B;
				case 368:
					goto IL_391A;
				case 369:
					goto IL_4863;
				case 370:
					goto IL_4F6B;
				case 371:
					goto IL_54E3;
				case 372:
					goto IL_2183;
				case 373:
					goto IL_234F;
				case 374:
					goto IL_4A60;
				case 375:
					goto IL_3E4D;
				case 376:
					goto IL_69F9;
				case 377:
					goto IL_6222;
				case 378:
					goto IL_1CEC;
				case 379:
					goto IL_137B;
				case 380:
					goto IL_25C1;
				case 381:
					goto IL_64B2;
				case 382:
					goto IL_402C;
				case 383:
					goto IL_252B;
				case 384:
					goto IL_3DF5;
				case 385:
					goto IL_1567;
				case 386:
					goto IL_13F0;
				case 387:
					goto IL_540F;
				case 388:
					goto IL_43FE;
				case 389:
					goto IL_56AC;
				case 390:
					goto IL_5664;
				case 391:
					goto IL_2511;
				case 392:
					goto IL_434E;
				case 393:
					goto IL_2CDE;
				case 394:
					goto IL_17D6;
				case 395:
					goto IL_1740;
				case 396:
					goto IL_5F7E;
				case 397:
					goto IL_5773;
				case 398:
					goto IL_4E22;
				case 399:
					goto IL_3E26;
				case 400:
					goto IL_16F5;
				case 401:
					goto IL_3999;
				case 402:
					goto IL_2F6A;
				case 403:
					goto IL_68A9;
				case 404:
					goto IL_2176;
				case 405:
					goto IL_3273;
				case 406:
					goto IL_487D;
				case 407:
					goto IL_2E24;
				case 408:
					goto IL_2BE3;
				case 409:
					goto IL_2D6A;
				case 410:
					goto IL_2DB5;
				case 411:
					goto IL_2226;
				case 412:
					goto IL_2820;
				case 413:
					goto IL_271E;
				case 414:
					goto IL_18A0;
				case 415:
					goto IL_41E4;
				case 416:
					goto IL_3720;
				case 417:
					goto IL_2AD4;
				case 418:
					goto IL_5E0D;
				case 419:
					goto IL_140A;
				case 420:
					goto IL_5593;
				case 421:
					goto IL_282D;
				case 422:
					goto IL_1BB9;
				case 423:
					goto IL_2390;
				case 424:
					goto IL_3877;
				case 425:
					goto IL_4B8C;
				case 426:
					goto IL_4678;
				case 427:
					goto IL_1A07;
				case 428:
					goto IL_6094;
				case 429:
					goto IL_274F;
				case 430:
					goto IL_42C2;
				case 431:
					goto IL_6685;
				case 432:
					goto IL_330C;
				case 433:
					goto IL_5C24;
				case 434:
					goto IL_27BE;
				case 435:
					goto IL_15B5;
				case 436:
					goto IL_5436;
				case 437:
					goto IL_51C7;
				case 438:
					goto IL_4291;
				case 439:
					goto IL_4A39;
				case 440:
					goto IL_1F93;
				case 441:
					goto IL_497C;
				case 442:
					goto IL_2D50;
				case 443:
					goto IL_2114;
				case 444:
					goto IL_2F8E;
				case 445:
					goto IL_58CD;
				case 446:
					goto IL_2145;
				case 447:
					goto IL_3AB5;
				case 448:
					goto IL_3A15;
				case 449:
					goto IL_3F9D;
				case 450:
					goto IL_2F36;
				case 451:
					goto IL_5A5B;
				case 452:
					goto IL_1B4A;
				case 453:
					goto IL_5025;
				case 454:
					goto IL_66F7;
				case 455:
					goto IL_539A;
				case 456:
					goto IL_5D77;
				case 457:
					goto IL_333D;
				case 458:
					goto IL_39B3;
				case 459:
					goto IL_4738;
				case 460:
					goto IL_622F;
				case 461:
					goto IL_2E17;
				case 462:
					goto IL_3680;
				case 463:
					goto IL_57E2;
				case 464:
					goto IL_67FC;
				case 465:
					goto IL_1A2B;
				case 466:
					goto IL_4F47;
				case 467:
					goto IL_17C9;
				case 468:
					goto IL_4609;
				case 469:
					goto IL_693F;
				case 470:
					goto IL_15A8;
				case 471:
					goto IL_225A;
				case 472:
					goto IL_15D9;
				case 473:
					goto IL_1361;
				case 474:
					goto IL_56B9;
				case 475:
					goto IL_1354;
				case 476:
					goto IL_61D7;
				case 477:
					goto IL_662D;
				case 478:
					goto IL_5D9E;
				case 479:
					goto IL_5B6D;
				case 480:
					goto IL_4A46;
				case 481:
					goto IL_5A68;
				case 482:
					goto IL_694C;
				case 483:
					goto IL_5D12;
				case 484:
					goto IL_5970;
				case 485:
					goto IL_3B24;
				case 486:
					goto IL_3F90;
				case 487:
					goto IL_1624;
				case 488:
					goto IL_3B96;
				case 489:
					goto IL_5D91;
				case 490:
					goto IL_365C;
				case 491:
					goto IL_30CE;
				case 492:
					goto IL_4368;
				case 493:
					goto IL_61F1;
				case 494:
					goto IL_4EAE;
				case 495:
					goto IL_390D;
				case 496:
					goto IL_3185;
				case 497:
					goto IL_2AEE;
				case 498:
					goto IL_1BDD;
				case 499:
					goto IL_4647;
				case 500:
					goto IL_3F17;
				case 501:
					goto IL_5298;
				case 502:
					goto IL_2538;
				case 503:
					goto IL_300A;
				case 504:
					goto IL_34B4;
				case 505:
					goto IL_63EB;
				case 506:
					goto IL_17BC;
				case 507:
					goto IL_4870;
				case 508:
					goto IL_34A7;
				case 509:
					goto IL_429E;
				case 510:
					goto IL_5481;
				case 511:
					goto IL_41BD;
				case 512:
					goto IL_60EC;
				case 513:
					goto IL_4A2C;
				case 514:
					goto IL_224D;
				case 515:
					goto IL_3C74;
				case 516:
					goto IL_17FA;
				case 517:
					goto IL_19C9;
				case 518:
					goto IL_601B;
				case 519:
					goto IL_4C25;
				case 520:
					goto IL_5E86;
				case 521:
					goto IL_26ED;
				case 522:
					goto IL_4D68;
				case 523:
					goto IL_2626;
				case 524:
					goto IL_6175;
				case 525:
					goto IL_2DD9;
				case 526:
					goto IL_2F9B;
				case 527:
					goto IL_1617;
				case 528:
					goto IL_422C;
				case 529:
					goto IL_4590;
				case 530:
					goto IL_6590;
				case 531:
					goto IL_204D;
				case 532:
					goto IL_31A9;
				case 533:
					goto IL_55C4;
				case 534:
					goto IL_534F;
				case 535:
					goto IL_572B;
				case 536:
					goto IL_1D68;
				case 537:
					goto IL_2994;
				case 538:
					goto IL_12CB;
				case 539:
					goto IL_30C1;
				case 540:
					goto IL_26D3;
				case 541:
					goto IL_5205;
				case 542:
					goto IL_69BB;
				case 543:
					goto IL_21FF;
				case 544:
					goto IL_3900;
				case 545:
					goto IL_13E3;
				case 546:
					goto IL_1DFE;
				case 547:
					goto IL_2B43;
				case 548:
					goto IL_3B55;
				case 549:
					goto IL_5C00;
				case 550:
					goto IL_6692;
				case 551:
					goto IL_1A5C;
				case 552:
					goto IL_6759;
				case 553:
					goto IL_34F2;
				case 554:
					goto IL_682D;
				case 555:
					goto IL_3523;
				case 556:
					goto IL_5FF7;
				case 557:
					goto IL_3AFD;
				case 558:
					goto IL_228B;
				case 559:
					goto IL_359F;
				case 560:
					goto IL_5F26;
				case 561:
					goto IL_3A08;
				case 562:
					goto IL_2067;
				case 563:
					goto IL_3BE1;
				case 564:
					goto IL_2478;
				case 565:
					goto IL_208B;
				case 566:
					goto IL_1B23;
				case 567:
					goto IL_4CEC;
				case 568:
					goto IL_5BCF;
				case 569:
					goto IL_60F9;
				case 570:
					goto IL_2F1C;
				case 571:
					goto IL_6780;
				case 572:
					goto IL_401F;
				case 573:
					goto IL_29AE;
				case 574:
					goto IL_59EC;
				case 575:
					goto IL_6735;
				case 576:
					goto IL_62B5;
				case 577:
					goto IL_337B;
				case 578:
					goto IL_56C6;
				case 579:
					goto IL_583A;
				case 580:
					goto IL_174D;
				case 581:
					goto IL_232B;
				case 582:
					goto IL_1C42;
				case 583:
					goto IL_4BC0;
				case 584:
					goto IL_517C;
				case 585:
					goto IL_5B46;
				case 586:
					goto IL_42CF;
				case 587:
					goto IL_1F00;
				case 588:
					goto IL_36B1;
				case 589:
					goto IL_24D0;
				case 590:
					goto IL_13C9;
				case 591:
					goto IL_67B1;
				case 592:
					goto IL_41D7;
				case 593:
					goto IL_6412;
				case 594:
					goto IL_2E89;
				case 595:
					goto IL_506D;
				case 596:
					goto IL_5AE4;
				case 597:
					goto IL_395B;
				case 598:
					goto IL_42F6;
				case 599:
					goto IL_1879;
				case 600:
					goto IL_54D6;
				case 601:
					goto IL_58FE;
				case 602:
					goto IL_3F24;
				case 603:
					goto IL_1E18;
				case 604:
					goto IL_3884;
				case 605:
					goto IL_41B0;
				case 606:
					goto IL_267B;
				case 607:
					goto IL_59F9;
				case 608:
					goto IL_2851;
				case 609:
					goto IL_54B2;
				case 610:
					goto IL_31DD;
				case 611:
					goto IL_2369;
				case 612:
					goto IL_1AE5;
				case 613:
					goto IL_56D3;
				case 614:
					goto IL_553B;
				case 615:
					goto IL_645D;
				case 616:
					goto IL_2307;
				case 617:
					goto IL_4813;
				case 618:
					goto IL_45FC;
				case 619:
					goto IL_6959;
				case 620:
					goto IL_15FD;
				case 621:
					goto IL_5FC6;
				case 622:
					goto IL_4375;
				case 623:
					goto IL_239D;
				case 624:
					goto IL_26AC;
				case 625:
					goto IL_255C;
				case 626:
					goto IL_19BC;
				case 627:
					goto IL_57D5;
				case 628:
					goto IL_3119;
				case 629:
					goto IL_264A;
				case 630:
					goto IL_3628;
				case 631:
					goto IL_17AF;
				case 632:
					goto IL_5A4E;
				case 633:
					goto IL_2504;
				case 634:
					goto IL_1574;
				case 635:
					goto IL_64F0;
				case 636:
					goto IL_5AFE;
				case 637:
					goto IL_2E6F;
				case 638:
					goto IL_5F40;
				case 639:
					goto IL_6773;
				case 640:
					goto IL_53CE;
				case 641:
					goto IL_6966;
				case 642:
					goto IL_29DF;
				case 643:
					goto IL_4A9E;
				case 644:
					goto IL_2F43;
				case 645:
					goto IL_32B4;
				case 646:
					goto IL_3FB7;
				case 647:
					goto IL_2430;
				case 648:
					goto IL_57B1;
				case 649:
					goto IL_3266;
				case 650:
					goto IL_1C1B;
				case 651:
					goto IL_1679;
				case 652:
					goto IL_63C4;
				case 653:
					goto IL_4FE7;
				case 654:
					goto IL_36FC;
				case 655:
					goto IL_4B41;
				case 656:
					goto IL_4B99;
				case 657:
					goto IL_1DF1;
				case 658:
					goto IL_3480;
				case 659:
					goto IL_5C31;
				case 660:
					goto IL_345C;
				case 661:
					goto IL_3799;
				case 662:
					goto IL_2CD1;
				case 663:
					goto IL_1FF8;
				case 664:
					goto IL_5018;
				case 665:
					goto IL_159B;
				case 666:
					goto IL_46AC;
				case 667:
					goto IL_1631;
				case 668:
					goto IL_4EBB;
				case 669:
					goto IL_46DD;
				case 670:
					goto IL_1232;
				case 671:
					goto IL_408E;
				case 672:
					goto IL_5D2C;
				case 673:
					goto IL_612A;
				case 674:
					goto IL_406A;
				case 675:
					goto IL_3B0A;
				case 676:
					goto IL_3C36;
				case 677:
					goto IL_28E4;
				case 678:
					goto IL_2C79;
				case 679:
					goto IL_1DE4;
				case 680:
					goto IL_4AAB;
				case 681:
					goto IL_5885;
				case 682:
					goto IL_2B74;
				case 683:
					goto IL_320E;
				case 684:
					goto IL_5AB3;
				case 685:
					goto IL_66C3;
				case 686:
					goto IL_1926;
				case 687:
					goto IL_4208;
				case 688:
					goto IL_1D44;
				case 689:
					goto IL_1821;
				case 690:
					goto IL_4B7F;
				case 691:
					goto IL_6678;
				case 692:
					goto IL_3642;
				case 693:
					goto IL_5854;
				case 694:
					goto IL_148C;
				case 695:
					goto IL_182E;
				case 696:
					goto IL_1280;
				case 697:
					goto IL_18D1;
				case 698:
					goto IL_3592;
				case 699:
					goto IL_3411;
				case 700:
					goto IL_5521;
				case 701:
					goto IL_1543;
				case 702:
					goto IL_1F6F;
				case 703:
					goto IL_3D5F;
				case 704:
					goto IL_4BB3;
				case 705:
					goto IL_3E33;
				case 706:
					goto IL_3395;
				case 707:
					goto IL_2454;
				case 708:
					goto IL_3D2E;
				case 709:
					goto IL_5D39;
				case 710:
					goto IL_5CD4;
				case 711:
					goto IL_292F;
				case 712:
					goto IL_5369;
				case 713:
					goto IL_37EE;
				case 714:
					goto IL_3C9B;
				case 715:
					goto IL_590B;
				case 716:
					goto IL_33A2;
				case 717:
					goto IL_2CEB;
				case 718:
					goto IL_51F8;
				case 719:
					goto IL_663A;
				case 720:
					goto IL_33AF;
				case 721:
					goto IL_2E3E;
				case 722:
					goto IL_1733;
				case 723:
					goto IL_2E31;
				case 724:
					goto IL_686B;
				case 725:
					goto IL_4D13;
				case 726:
					goto IL_2688;
				case 727:
					goto IL_4117;
				case 728:
					goto IL_21B4;
				case 729:
					goto IL_3839;
				case 730:
					goto IL_5DCF;
				case 731:
					goto IL_2C6C;
				case 732:
					goto IL_4776;
				case 733:
					goto IL_603F;
				case 734:
					goto IL_2D1F;
				case 735:
					goto IL_5DC2;
				case 736:
					goto IL_63D1;
				case 737:
					goto IL_23DB;
				case 738:
					goto IL_5D84;
				case 739:
					goto IL_4623;
				case 740:
					goto IL_5633;
				case 741:
					goto IL_3083;
				case 742:
					goto IL_4FCD;
				case 743:
					goto IL_1ABE;
				case 744:
					goto IL_1933;
				case 745:
					goto IL_37CA;
				case 746:
					goto IL_5E1A;
				case 747:
					goto IL_41A3;
				case 748:
					goto IL_50C2;
				case 749:
					goto IL_6925;
				case 750:
					goto IL_4422;
				case 751:
					goto IL_545D;
				case 752:
					goto IL_43CD;
				case 753:
					goto IL_136E;
				case 754:
					goto IL_25B4;
				case 755:
					goto IL_2569;
				case 756:
					goto IL_32A7;
				case 757:
					goto IL_1AD8;
				case 758:
					goto IL_1726;
				case 759:
					goto IL_6885;
				case 760:
					goto IL_1B7B;
				case 761:
					goto IL_435B;
				case 762:
					goto IL_19A2;
				case 763:
					goto IL_2AC7;
				case 764:
					goto IL_66B6;
				case 765:
					goto IL_1902;
				case 766:
					goto IL_5B9E;
				case 767:
					goto IL_31B6;
				case 768:
					goto IL_1719;
				case 769:
					goto IL_60B8;
				case 770:
					goto IL_1FB7;
				case 771:
					goto IL_5F4D;
				case 772:
					goto IL_54FD;
				case 773:
					goto IL_40CC;
				case 774:
					goto IL_6405;
				case 775:
					goto IL_186C;
				case 776:
					goto IL_2D12;
				case 777:
					goto IL_3846;
				case 778:
					goto IL_5780;
				case 779:
					goto IL_3BA3;
				case 780:
					goto IL_43C0;
				case 781:
					goto IL_36D5;
				case 782:
					goto IL_3635;
				case 783:
					goto IL_630A;
				case 784:
					goto IL_18AD;
				case 785:
					goto IL_49EB;
				case 786:
					goto IL_4A05;
				case 787:
					goto IL_5342;
				case 788:
					goto IL_19FA;
				case 789:
					goto IL_5E62;
				case 790:
					goto IL_56E0;
				case 791:
					goto IL_4A1F;
				case 792:
					goto IL_41CA;
				case 793:
					goto IL_1940;
				case 794:
					goto IL_2619;
				case 795:
					goto IL_1266;
				case 796:
					goto IL_4D75;
				case 797:
					goto IL_5F02;
				case 798:
					goto IL_4856;
				case 799:
					goto IL_2F5D;
				case 800:
					goto IL_5F33;
				case 801:
					goto IL_2E0A;
				case 802:
					goto IL_3A2F;
				case 803:
					goto IL_3052;
				case 804:
					goto IL_20FA;
				case 805:
					goto IL_24C3;
				case 806:
					goto IL_3DA0;
				case 807:
					goto IL_3442;
				case 808:
					goto IL_3F6C;
				case 809:
					goto IL_4903;
				case 810:
					goto IL_5956;
				case 811:
					goto IL_1225;
				case 812:
					goto IL_6348;
				case 813:
					goto IL_4552;
				case 814:
					goto IL_6654;
				case 815:
					goto IL_25E8;
				case 816:
					goto IL_1FDE;
				case 817:
					goto IL_500B;
				case 818:
					goto IL_5AA6;
				case 819:
					goto IL_1E0B;
				case 820:
					goto IL_3FEB;
				case 821:
					goto IL_34FF;
				case 822:
					goto IL_309D;
				case 823:
					goto IL_426A;
				case 824:
					goto IL_5443;
				case 825:
					goto IL_381F;
				case 826:
					goto IL_1886;
				case 827:
					goto IL_6847;
				case 828:
					goto IL_678D;
				case 829:
					goto IL_53F5;
				case 830:
					goto IL_2D5D;
				case 831:
					goto IL_175A;
				case 832:
					goto IL_5847;
				case 833:
					goto IL_3EE6;
				case 834:
					goto IL_20D6;
				case 835:
					goto IL_22C9;
				case 836:
					goto IL_4CD2;
				case 837:
					goto IL_1D1D;
				case 838:
					goto IL_556C;
				case 839:
					goto IL_321B;
				case 840:
					goto IL_1EDC;
				case 841:
					goto IL_4BE7;
				case 842:
					goto IL_4005;
				case 843:
					goto IL_329A;
				case 844:
					goto IL_394E;
				case 845:
					goto IL_425D;
				case 846:
					goto IL_5918;
				case 847:
					goto IL_205A;
				case 848:
					goto IL_455F;
				case 849:
					goto IL_5B22;
				case 850:
					goto IL_22D6;
				case 851:
					goto IL_5704;
				case 852:
					goto IL_13FD;
				case 853:
					goto IL_3941;
				case 854:
					goto IL_6253;
				case 855:
					goto IL_2970;
				case 856:
					goto IL_39E4;
				case 857:
					goto IL_344F;
				case 858:
					goto IL_6355;
				case 859:
					goto IL_582D;
				case 860:
					goto IL_1C0E;
				case 861:
					goto IL_58A9;
				case 862:
					goto IL_4E56;
				case 863:
					goto IL_14F8;
				case 864:
					goto IL_4B03;
				case 865:
					goto IL_6552;
				case 866:
					goto IL_59D2;
				case 867:
					goto IL_2233;
				case 868:
					goto IL_26FA;
				case 869:
					goto IL_5688;
				case 870:
					goto IL_158E;
				case 871:
					goto IL_516F;
				case 872:
					goto IL_65B4;
				case 873:
					goto IL_5EE8;
				case 874:
					goto IL_2C14;
				case 875:
					goto IL_334A;
				case 876:
					goto IL_227E;
				case 877:
					goto IL_54F0;
				case 878:
					goto IL_266E;
				case 879:
					goto IL_49DE;
				case 880:
					goto IL_279A;
				case 881:
					goto IL_2A10;
				case 882:
					goto IL_35EA;
				case 883:
					goto IL_4A6D;
				case 884:
					goto IL_3259;
				case 885:
					goto IL_683A;
				case 886:
					goto IL_68B6;
				case 887:
					goto IL_4958;
				case 888:
					goto IL_2C45;
				case 889:
					goto IL_1E91;
				case 890:
					goto IL_4277;
				case 891:
					goto IL_24F7;
				case 892:
					goto IL_409B;
				case 893:
					goto IL_5E3E;
				case 894:
					goto IL_4E49;
				case 895:
					goto IL_1814;
				case 896:
					goto IL_60C5;
				case 897:
					goto IL_38D9;
				case 898:
					goto IL_1465;
				case 899:
					goto IL_5450;
				case 900:
					goto IL_1848;
				case 901:
					goto IL_1655;
				case 902:
					goto IL_38F3;
				case 903:
					goto IL_3B7C;
				case 904:
					goto IL_25A7;
				case 905:
					goto IL_3812;
				case 906:
					goto IL_21DB;
				case 907:
					goto IL_1E60;
				case 908:
					goto IL_2098;
				case 909:
					goto IL_1ACB;
				case 910:
					goto IL_21CE;
				case 911:
					goto IL_35F7;
				case 912:
					goto IL_652E;
				case 913:
					goto IL_45B4;
				case 914:
					goto IL_5BC2;
				case 915:
					goto IL_2107;
				case 916:
					goto IL_2CAA;
				case 917:
					goto IL_4E08;
				case 918:
					goto IL_2121;
				case 919:
					goto IL_4BDA;
				case 920:
					goto IL_471E;
				case 921:
					goto IL_3D86;
				case 922:
					goto IL_235C;
				case 923:
					goto IL_2E62;
				case 924:
					goto IL_1347;
				case 925:
					goto IL_2963;
				case 926:
					goto IL_4ED5;
				case 927:
					goto IL_690B;
				case 928:
					goto IL_1F24;
				case 929:
					goto IL_5274;
				case 930:
					goto IL_511A;
				case 931:
					goto IL_3975;
				case 932:
					goto IL_30F2;
				case 933:
					goto IL_124C;
				case 934:
					goto IL_452E;
				case 935:
					goto IL_1D2A;
				case 936:
					goto IL_23AA;
				case 937:
					goto IL_2ABA;
				case 938:
					goto IL_5C96;
				case 939:
					goto IL_4CDF;
				case 940:
					goto IL_18DE;
				case 941:
					goto IL_1DD7;
				case 942:
					goto IL_14D4;
				case 943:
					goto IL_2CC4;
				case 944:
					goto IL_6932;
				case 945:
					goto IL_1395;
				case 946:
					goto IL_23E8;
				case 947:
					goto IL_36EF;
				case 948:
					goto IL_3E5A;
				case 949:
					goto IL_2DA8;
				case 950:
					goto IL_1B30;
				case 951:
					goto IL_4B34;
				case 952:
					goto IL_3FF8;
				case 953:
					goto IL_40D9;
				case 954:
					goto IL_1505;
				case 955:
					goto IL_55DE;
				case 956:
					goto IL_65C1;
				case 957:
					goto IL_4AC5;
				case 958:
					goto IL_66D0;
				case 959:
					goto IL_4F2D;
				case 960:
					goto IL_49AD;
				case 961:
					goto IL_32DB;
				case 962:
					goto IL_194D;
				case 963:
					goto IL_49F8;
				case 964:
					goto IL_28F1;
				case 965:
					goto IL_632E;
				case 966:
					goto IL_3AA8;
				case 967:
					goto IL_5AC0;
				case 968:
					goto IL_642C;
				case 969:
					goto IL_386A;
				case 970:
					goto IL_3B6F;
				case 971:
					goto IL_50B5;
				case 972:
					goto IL_47E2;
				case 973:
					goto IL_3927;
				case 974:
					goto IL_61FE;
				case 975:
					goto IL_5D46;
				case 976:
					goto IL_53DB;
				case 977:
					goto IL_4704;
				case 978:
					goto IL_4E2F;
				case 979:
					goto IL_4A12;
				case 980:
					goto IL_4C32;
				case 981:
					goto IL_3744;
				case 982:
					goto IL_1417;
				case 983:
					goto IL_541C;
				case 984:
					goto IL_31C3;
				case 985:
					goto IL_1512;
				case 986:
					goto IL_3D0A;
				case 987:
					goto IL_35B9;
				case 988:
					goto IL_5C7C;
				case 989:
					goto IL_4685;
				case 990:
					goto IL_5402;
				case 991:
					goto IL_614E;
				case 992:
					goto IL_31EA;
				case 993:
					goto IL_240C;
				case 994:
					goto IL_2D8E;
				case 995:
					goto IL_475C;
				case 996:
					goto IL_4148;
				case 997:
					goto IL_3D79;
				case 998:
					goto IL_129A;
				case 999:
					goto IL_44B5;
				case 1000:
					goto IL_4484;
				case 1001:
					goto IL_1AF2;
				case 1002:
					goto IL_5657;
				case 1003:
					goto IL_4521;
				case 1004:
					goto IL_26C6;
				case 1005:
					goto IL_5196;
				case 1006:
					goto IL_4B5B;
				case 1007:
					goto IL_6521;
				case 1008:
					goto IL_1D99;
				case 1009:
					goto IL_2BB2;
				case 1010:
					goto IL_3B89;
				case 1011:
					goto IL_4C94;
				case 1012:
					goto IL_2DE6;
				case 1013:
					goto IL_4F06;
				case 1014:
					goto IL_4399;
				case 1015:
					goto IL_160A;
				case 1016:
					goto IL_4F20;
				case 1017:
					goto IL_3C8E;
				case 1018:
					goto IL_1C66;
				case 1019:
					goto IL_5376;
				case 1020:
					goto IL_5FEA;
				case 1021:
					goto IL_4303;
				case 1022:
					goto IL_44A8;
				case 1023:
					goto IL_6481;
				case 1024:
					goto IL_58DA;
				case 1025:
					goto IL_656C;
				case 1026:
					goto IL_552E;
				case 1027:
					goto IL_133A;
				case 1028:
					goto IL_19AF;
				case 1029:
					goto IL_143E;
				case 1030:
					goto IL_52ED;
				case 1031:
					goto IL_68E7;
				case 1032:
					goto IL_413B;
				case 1033:
					goto IL_5A99;
				case 1034:
					goto IL_3CF0;
				case 1035:
					goto IL_1273;
				case 1036:
					goto IL_3C05;
				case 1037:
					goto IL_1BEA;
				case 1038:
					goto IL_1B9F;
				case 1039:
					goto IL_2FB5;
				case 1040:
					goto IL_1F62;
				case 1041:
					goto IL_60D2;
				case 1042:
					goto IL_3C43;
				case 1043:
					goto IL_6070;
				case 1044:
					goto IL_35DD;
				case 1045:
					goto IL_1BAC;
				case 1046:
					goto IL_3F0A;
				case 1047:
					goto IL_32CE;
				case 1048:
					goto IL_3CCC;
				case 1049:
					goto IL_2882;
				case 1050:
					goto IL_378C;
				case 1051:
					goto IL_4AD2;
				case 1052:
					goto IL_4B4E;
				case 1053:
					goto IL_2D05;
				case 1054:
					goto IL_4DE4;
				case 1055:
					goto IL_5E93;
				case 1056:
					goto IL_5D1F;
				case 1057:
					goto IL_53B4;
				case 1058:
					goto IL_69DF;
				case 1059:
					goto IL_2956;
				case 1060:
					goto IL_44D9;
				case 1061:
					goto IL_2BBF;
				case 1062:
					goto IL_59DF;
				case 1063:
					goto IL_4692;
				case 1064:
					goto IL_5B53;
				case 1065:
					goto IL_5B60;
				case 1066:
					goto IL_52A5;
				case 1067:
					goto IL_20A5;
				case 1068:
					goto IL_3D6C;
				case 1069:
					goto IL_49A0;
				case 1070:
					goto IL_4CC5;
				case 1071:
					goto IL_5CE1;
				case 1072:
					goto IL_368D;
				case 1073:
					goto IL_39C0;
				case 1074:
					goto IL_251E;
				case 1075:
					goto IL_3C67;
				case 1076:
					goto IL_3578;
				case 1077:
					goto IL_3280;
				case 1078:
					goto IL_4FB3;
				case 1079:
					goto IL_1DA6;
				case 1080:
					goto IL_4D20;
				case 1081:
					goto IL_33E0;
				case 1082:
					goto IL_2AAD;
				case 1083:
					goto IL_2298;
				case 1084:
					goto IL_310C;
				case 1085:
					goto IL_4DCA;
				case 1086:
					goto IL_28C0;
				case 1087:
					goto IL_6260;
				case 1088:
					goto IL_36E2;
				case 1089:
					goto IL_1B3D;
				case 1090:
					goto IL_2A03;
				case 1091:
					goto IL_4820;
				case 1092:
					goto IL_4A7A;
				case 1093:
					goto IL_4D44;
				case 1094:
					goto IL_6450;
				case 1095:
					goto IL_61CA;
				case 1096:
					goto IL_53C1;
				case 1097:
					goto IL_6514;
				case 1098:
					goto IL_3AD9;
				case 1099:
					goto IL_514B;
				case 1100:
					goto IL_5878;
				case 1101:
					goto IL_2C5F;
				case 1102:
					goto IL_29A1;
				case 1103:
					goto IL_348D;
				case 1104:
					goto IL_2BF0;
				case 1105:
					goto IL_4934;
				case 1106:
					goto IL_3FD1;
				case 1107:
					goto IL_32FF;
				case 1108:
					goto IL_38E6;
				case 1109:
					goto IL_4EC8;
				case 1110:
					goto IL_12A7;
				case 1111:
					goto IL_2FC2;
				case 1112:
					goto IL_2219;
				case 1113:
					goto IL_4616;
				case 1114:
					goto IL_1EAB;
				case 1115:
					goto IL_4E87;
				case 1116:
					goto IL_20C9;
				case 1117:
					goto IL_698A;
				case 1118:
					goto IL_5A06;
				case 1119:
					goto IL_2776;
				case 1120:
					goto IL_2EBA;
				case 1121:
					goto IL_356B;
				case 1122:
					goto IL_349A;
				case 1123:
					goto IL_405D;
				case 1124:
					goto IL_3768;
				case 1125:
					goto IL_51D4;
				case 1126:
					goto IL_24B6;
				case 1127:
					goto IL_5963;
				case 1128:
					goto IL_5EDB;
				case 1129:
					goto IL_5CA3;
				case 1130:
					goto IL_1F31;
				case 1131:
					goto IL_3319;
				case 1132:
					goto IL_1A4F;
				case 1133:
					goto IL_23CE;
				case 1134:
					goto IL_55D1;
				case 1135:
					goto IL_633B;
				case 1136:
					goto IL_3DD1;
				case 1137:
					goto IL_2005;
				case 1138:
					goto IL_3404;
				case 1139:
					goto IL_2C38;
				case 1140:
					goto IL_5579;
				default:
					num = (short)1707212802;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1225:
			this.CpyBtnCnvPerFeaturesMixedVoteScanEnable_A38723 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1232:
			this.CnvPerTacticalInhibitStunOperation_A41557Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_123F:
			this.RTDBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_124C:
			this.CnvPerOneTouchButton_A19765Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1259:
			this.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1266:
			this.CVBtnCnvPerLabtoolScanListSelection_A9054 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1273:
			this.CVBtnCnvPerSecureASTROOTAR_A7493 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1280:
			this.CpyBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_128D:
			this.RTDBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_129A:
			this.CVBtnCnvPerSecureSecureClearStrapping2_A9091 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12A7:
			this.LblCnvPerAdvanceBroadbandProtection = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvanceBroadbandProtection.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12CB:
			this.CpyBtnCnvPerAGAGSecStrap_A40158 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12D8:
			this.HLinkFrequencyOptions = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFrequencyOptions.Click += this.HLinkClick;
			return;
			IL_12FC:
			this.CVBtnCnvPerConventionalChannelOptionsTAFrequency_A9260 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1309:
			this.CnvPerConventionalChannelOptionsTASquelchType_A9265_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1316:
			this.LblCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_133A:
			this.CpyBtnCnvPerSecureBroadbandASTROOTAR = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1347:
			this.CnvPerOneTouchFeature_A19662_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1354:
			this.CnvPerSignalingRevertChannel_A13267Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1361:
			this.RTDBtnCnvPerSignalingRevertChannel_A13267 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_136E:
			this.RTDBtnCnvPerRACSingletone_A43073 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_137B:
			this.RTDBtnCnvPerConventionalChannelOptionsTADPLCode_A9256 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1388:
			this.CVBtnCnvPerConventionalChannelOptionsTANetworkID_A7863 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1395:
			this.CnvPerOneTouchIndex_A19663Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_13A2:
			this.CpyBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13AF:
			this.CpyBtnCnvPerConventionalChannelOptionsRxPLCode_A8917 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13BC:
			this.CpyBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13C9:
			this.CpyBtnCnvPerNonASTROCallUnlimitedCalling_A9597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13D6:
			this.CpyBtnCnvPerFeaturesDVRSProf_A41794 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13E3:
			this.CnvPerAGAGKeySel_A40159Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_13F0:
			this.CpyBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13FD:
			this.CnvPerTPSTPSUIEnable_A9400Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_140A:
			this.CnvPerSignalingDigitalModulatorType_A7857Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1417:
			this.RTDBtnCnvPerSecureKeyStrapping_A8370 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1424:
			this.ExpanderConventionalPersonalityFrequencyOptionsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1431:
			this.GrpBoxExpanderConventionalPersonalityGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_143E:
			this.CVBtnCnvPerSecureOTARTx_A8675 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_144B:
			this.CVBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1458:
			this.CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1465:
			this.GrpBoxExpanderConventionalPersonalityPhonePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1472:
			this.CnvPerRxOptionsRxDeEmphasis_A9010Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_147F:
			this.CnvPerConventionalChannelOptionsTAPLCode_A9261_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_148C:
			this.CnvPerASTROTalkgroupOptionsSelectionType_A9112 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROTalkgroupOptionsSelectionType_A9112.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14B0:
			this.LblCnvPerConventionalChannelOptionsTxNetworkID_A9550 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxNetworkID_A9550.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14D4:
			this.LblCnvPerOneTouchIndex_A19663 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerOneTouchIndex_A19663.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14F8:
			this.RTDBtnCnvPerFeaturesTxVoiceType_A9573 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1505:
			this.CVBtnCnvPerSecureSecureVoiceSignalType_A9086 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1512:
			this.CVBtnCnvPerSecureKeySelection2_A8369 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_151F:
			this.LblCnvPerConventionalChannelOptionsTxFrequency_A9414 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxFrequency_A9414.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1543:
			this.LblCnvPerRACRepeaterAccess_A8939 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACRepeaterAccess_A8939.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1567:
			this.RTDBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1574:
			this.CVBtnCnvPerASTROCallTacticalServicesOperation = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1581:
			this.CnvPerConventionalChannelOptionsRxSquelchType_A8919_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_158E:
			this.RTDBtnCnvPerFeaturesOTARadioAliasType_42784 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_159B:
			this.CVBtnCnvPerTacticalInhibitStunOperation_A41557 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15A8:
			this.CVBtnCnvPerSignalingRevertChannel_A13267 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15B5:
			this.CnvPerSignalingSignalingType_A9129 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingSignalingType_A9129.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15D9:
			this.CnvPerSignalingRevertChannel_A13267 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingRevertChannel_A13267.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15FD:
			this.CVBtnCnvPerASTROCallInCallUserAlertEnable_A8250 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_160A:
			this.CnvPerSecureIgnoreRxClearPacketData_A19310Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1617:
			this.CnvPerAGAGSysID_A40156Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_1624:
			this.CpyBtnCnvPerSignalingRevertTGSYSID_A40151 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1631:
			this.CnvPerTacticalInhibitStunOperation_A41557 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerTacticalInhibitStunOperation_A41557.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1655:
			this.CnvPerPhonePhoneOperation_A8703 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerPhonePhoneOperation_A8703.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1679:
			this.CnvPerASTROCallRemoteMonitorTxRxTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1686:
			this.LblCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16AA:
			this.CpyBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16B7:
			this.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_16C4:
			this.CnvPerFeaturesDVRSProf_A41794 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerFeaturesDVRSProf_A41794.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16E8:
			this.ExpanderConventionalPersonalityFrequencyOptionsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_16F5:
			this.CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1719:
			this.CpyBtnCnvPerFeaturesTacticalRekeyEnable_A19309 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1726:
			this.CVBtnCnvPerLabtoolOTACROTACSMessaging_A8663 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1733:
			this.RTDBtnCnvPerRACCodeType1_A7680 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1740:
			this.CVBtnCnvPerConventionalChannelOptionsTalkaround_A19837 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_174D:
			this.CVBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_175A:
			this.CnvPerLabtoolQuickKeyOverride_A8808Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1767:
			this.HLinkRxOptions = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxOptions.Click += this.HLinkClick;
			return;
			IL_178B:
			this.RecNavToolbarPageConventionalPersonality = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageConventionalPersonality.ModeClick += this.OnModeClick;
			return;
			IL_17AF:
			this.CpyBtnCnvPerASTROCallASTROUnlimitedCalling_A7501 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17BC:
			this.CnvPerSignalingRevertTGKeySel_A40154Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17C9:
			this.RTDBtnCnvPerSignalingRevertZone_A13269 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17D6:
			this.CnvPerConventionalChannelOptionsTalkaround_A19837 = (global::AcpUI.AcpLabel)target;
			this.CnvPerConventionalChannelOptionsTalkaround_A19837.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17FA:
			this.CVBtnCnvPerAGAGWACNID_A40155 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1807:
			this.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1814:
			this.CpyBtnCnvPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1821:
			this.RTDBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_182E:
			this.RTDBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_183B:
			this.RTDBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1848:
			this.LblCnvPerPhonePhoneOperation_A8703 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerPhonePhoneOperation_A8703.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_186C:
			this.CnvPerLabtoolHotKeypad_A8208Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1879:
			this.ExpanderConventionalPersonalityASTROCall = (global::AcpUI.AcpExpander)target;
			return;
			IL_1886:
			this.CVBtnCnvPerLabtoolQuickKeyOverride_A8808 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1893:
			this.CpyBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18A0:
			this.CVBtnCnvPerSignalingDigitalModulatorType_A7857 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18AD:
			this.CnvPerEndTxOnVoiceAbsence_42460 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerEndTxOnVoiceAbsence_42460.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18D1:
			this.CnvPerASTROTalkgroupOptionsSelectionType_A9112Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18DE:
			this.CnvPerOneTouchIndex_A19663 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerOneTouchIndex_A19663.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1902:
			this.LblCnvPerFeaturesTacticalRekeyEnable_A19309 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesTacticalRekeyEnable_A19309.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1926:
			this.CVBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1933:
			this.CVBtnCnvPerRACMDCRepeaterID2_A8814 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1940:
			this.CnvPerFeatureRFModem_42485Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_194D:
			this.CnvPerSecureXLTransmit_A9683 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureXLTransmit_A9683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1971:
			this.RTDBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_197E:
			this.LblCnvPerConventionalChannelOptionsTxPLCode_A9418 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxPLCode_A9418.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_19A2:
			this.CpyBtnCnvPerLabtoolOTACROTACSMessaging_A8663 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19AF:
			this.CnvPerSecureBroadbandASTROOTARComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_19BC:
			this.GrpBoxExpanderConventionalPersonalityASTROCallPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_19C9:
			this.LblCnvPerAGAGWACNID_A40155 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAGAGWACNID_A40155.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_19ED:
			this.CpyBtnCnvPerRxOptionsHearClear_A36408 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19FA:
			this.CVBtnCnvPerFeatureRFModem_42485 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A07:
			this.LblCnvPerSignalingLateEntryFastUnmute_A8423 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingLateEntryFastUnmute_A8423.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A2B:
			this.LblCnvPerSignalingRevertZone_A13269 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertZone_A13269.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A4F:
			this.RTDBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A5C:
			this.RTDBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A69:
			this.LblCnvPerRxOptionsRxUnmuteDelayms_A9033 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsRxUnmuteDelayms_A9033.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A8D:
			this.CnvPerRxOptionsConcurrentRXEnable = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerRxOptionsConcurrentRXEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AB1:
			this.CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1ABE:
			this.CnvPerRACCodeType2_A8817Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1ACB:
			this.CpyBtnCnvPerPhoneAccessTimingTable_A7387 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AD8:
			this.GrpBoxExpanderConventionalPersonalityFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1AE5:
			this.CnvPerASTROCallAutoSelectiveCallTransmit_A7518Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1AF2:
			this.RTDBtnCnvPerSecureSecureClearStrapping2_A9091 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1AFF:
			this.LblCnvPerConventionalChannelOptionsRxPLCode_A8917 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxPLCode_A8917.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B23:
			this.CnvPerNonASTROCallCallAlertRxTx_A7588Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B30:
			this.CpyBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B3D:
			this.CpyBtnCnvPerAdvancedSecondLOSideInjection_A9063 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B4A:
			this.LblCnvPerSignalingEmergencyPTTID_A7944 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingEmergencyPTTID_A7944.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B6E:
			this.CpyBtnCnvPerConventionalChannelOptionsTxPLCode_A9418 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B7B:
			this.CnvPerLabtoolOTACROTACSMessaging_A8663 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerLabtoolOTACROTACSMessaging_A8663.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B9F:
			this.RTDBtnCnvPerSecureASTROOTAR_A7493 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BAC:
			this.CpyBtnCnvPerSecureKMFProfileIndex_A8381 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BB9:
			this.CnvPerSignalingASTRORxUnmuteRule_A9042 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingASTRORxUnmuteRule_A9042.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BDD:
			this.RTDBtnCnvPerSignalingRevertTGSecClearStrap_A40153 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BEA:
			this.CnvPerSecureASTROOTAR_A7493 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureASTROOTAR_A7493.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C0E:
			this.CVBtnCnvPerFeaturesTxVoiceType_A9573 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C1B:
			this.CpyBtnCnvPerASTROCallRemoteMonitorTxRxTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C28:
			this.RTDBtnCnvPerConventionalChannelOptionsTxPLCode_A9418 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C35:
			this.CnvPerConventionalChannelOptionsTANetworkID_A7863_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1C42:
			this.CnvPerNonASTROCallAutoSelectCallTransmit_A7520 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerNonASTROCallAutoSelectCallTransmit_A7520.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C66:
			this.LblCnvPerSecureProperCodeDetect_A8762 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureProperCodeDetect_A8762.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C8A:
			this.LblCnvPerRxOptionsUnmuteMuteType_A9602 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsUnmuteMuteType_A9602.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CAE:
			this.CnvPerConventionalChannelOptionsTxSquelchType_A9426_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1CBB:
			this.CpyBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CC8:
			this.LblCnvPerTxOptionsTransmitPreEmphasis_A9411 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsTransmitPreEmphasis_A9411.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CEC:
			this.LblCnvPerConventionalChannelOptionsTADPLCode_A9256 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTADPLCode_A9256.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D10:
			this.CpyBtnCnvPerTxOptionsTransmitPowerLevel_A9420 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D1D:
			this.CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1D2A:
			this.CVBtnCnvPerOneTouchFeature_A19662 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D37:
			this.CnvPerConventionalChannelOptionsTxDPLCode_A9409Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D44:
			this.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D68:
			this.CnvPerAGAGSecStrap_A40158 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerAGAGSecStrap_A40158.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D8C:
			this.RTDBtnCnvPerConventionalChannelOptionsRxFrequency_A8911 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D99:
			this.CpyBtnCnvPerSecureKeySelection1_A8368 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DA6:
			this.CVBtnCnvPerAdvancedAdvancedRFAGC_A7408 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DB3:
			this.LblCnvPerTxOptionsTransmitPowerLevel_A9420 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsTransmitPowerLevel_A9420.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DD7:
			this.CVBtnCnvPerOneTouchIndex_A19663 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DE4:
			this.GrpBoxExpanderConventionalPersonalityASTROTalkgroupPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1DF1:
			this.CnvPerASTROCallRemotemonitorfrequencyoptionComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DFE:
			this.ExpanderConventionalPersonalityNonASTROCall = (global::AcpUI.AcpExpander)target;
			return;
			IL_1E0B:
			this.GrpBoxExpanderConventionalPersonalityFeaturesSmartPTT = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E18:
			this.CnvPerASTROCallSelectiveCallRxTx_A9114 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallSelectiveCallRxTx_A9114.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E3C:
			this.LblCnvPerConventionalChannelOptionsRxDPLCode_A8908 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxDPLCode_A8908.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E60:
			this.CnvPerPhoneAccessTimingTable_A7387 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerPhoneAccessTimingTable_A7387.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E84:
			this.CpyBtnCnvPerConventionalChannelOptionsTxFrequency_A9414 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E91:
			this.CpyBtnCnvPerFeaturesRSSIDisplayTimer_42786 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E9E:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_1EAB:
			this.CnvPerAdvanceBroadbandProtectionComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1EB8:
			this.CnvPerTxOptionsTxVoiceSignalType_A9574 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerTxOptionsTxVoiceSignalType_A9574.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EDC:
			this.LblConPerFeatureIncidentSignalingType_A41507 = (global::AcpUI.AcpLabel)target;
			this.LblConPerFeatureIncidentSignalingType_A41507.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F00:
			this.LblCnvPerNonASTROCallUnlimitedCalling_A9597 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallUnlimitedCalling_A9597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F24:
			this.gridExpanderConventionalPersonalityOneTouchTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1F31:
			this.LblCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F55:
			this.ExpanderConventionalPersonalityFrequencyOptionsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F62:
			this.CnvPerSecureASTROOTAR_A7493Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F6F:
			this.CnvPerRACRepeaterAccess_A8939 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerRACRepeaterAccess_A8939.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F93:
			this.LblCnvPerSignalingSystemNumber_A9243 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingSystemNumber_A9243.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FB7:
			this.CVBtnCnvPerLabtoolHotKeypad_A8208 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FC4:
			this.CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FD1:
			this.CVBtnCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FDE:
			this.RTDBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FEB:
			this.CpyBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FF8:
			this.CpyBtnCnvPerTacticalInhibitKillOperation_A41553 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2005:
			this.CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2029:
			this.LblCnvPerRxOptionsSquelchFineTune_A9176 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsSquelchFineTune_A9176.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_204D:
			this.RTDBtnCnvPerAGAGTalkgroupID_A40157 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_205A:
			this.CVBtnCnvPerTPSTPSUIEnable_A9400 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2067:
			this.LblCnvPerNonASTROCallCallAlertRxTx_A7588 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallCallAlertRxTx_A7588.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_208B:
			this.CpyBtnCnvPerNonASTROCallCallAlertRxTx_A7588 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2098:
			this.RTDBtnCnvPerPhoneAccessTimingTable_A7387 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20A5:
			this.CnvPerSecureKeyID_A8361 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureKeyID_A8361.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20C9:
			this.GrpBoxExpanderConventionalPersonalityLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_20D6:
			this.CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20FA:
			this.RTDBtnCnvPerLabtoolAutomaticScan_A7527 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2107:
			this.CpyBtnCnvPerPhoneAutoAccessCodeSelect_A7503 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2114:
			this.CpyBtnCnvPerSignalingSystemNumber_A9243 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2121:
			this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalPersonalityOneTouchTable.ModeClick += this.OnModeClick;
			return;
			IL_2145:
			this.LblCnvPerSignalingPTTID_A8770 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingPTTID_A8770.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2169:
			this.CpyBtnCnvPerGeneralConventionalPersonalityName_A12660 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2176:
			this.CpyBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2183:
			this.LblCnvPerConventionalChannelOptionsTAPLCode_A9261 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTAPLCode_A9261.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21A7:
			this.CnvPerConventionalChannelOptionsTxFrequency_A9414_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_21B4:
			this.RTDBtnCnvPerRACMDCRepeaterID1_A8783 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21C1:
			this.RTDBtnCnvPerRxOptionsConcurrentRXEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21CE:
			this.CnvPerPhoneAccessTimingTable_A7387Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21DB:
			this.LblCnvPerPhoneAccessTimingTable_A7387 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerPhoneAccessTimingTable_A7387.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21FF:
			this.RTDBtnCnvPerAGAGKeySel_A40159 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_220C:
			this.CpyBtnCnvPerGeneralTalkgroupTextList_A19822 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2219:
			this.RTDBtnCnvPerAdvanceBroadbandProtection = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2226:
			this.RTDBtnCnvPerSignalingASTROSystem_A7498 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2233:
			this.CVBtnCnvPerFeaturesOTARadioAliasType_42784 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2240:
			this.CnvPerConventionalChannelOptionsTxPLFreq_A9419_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_224D:
			this.ExpanderConventionalPersonalityDVRS = (global::AcpUI.AcpExpander)target;
			return;
			IL_225A:
			this.LblCnvPerSignalingRevertChannel_A13267 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertChannel_A13267.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_227E:
			this.RTDBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_228B:
			this.CpyBtnCnvPerNonASTROCallUnmuteType_A9601 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2298:
			this.CpyBtnCnvPerAdvancedAdvancedRFAGC_A7408 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22A5:
			this.CnvPerConventionalChannelOptionsRxDPLInvert_A8909 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsRxDPLInvert_A8909.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22C9:
			this.RTDBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22D6:
			this.RTDBtnCnvPerTPSTPSUIEnable_A9400 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22E3:
			this.CnvPerRxOptionsReceiveOnlyPersonality_A8916 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerRxOptionsReceiveOnlyPersonality_A8916.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2307:
			this.CnvPerASTROCallCallAlertRxTx_A7586 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallCallAlertRxTx_A7586.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_232B:
			this.LblCnvPerNonASTROCallAutoSelectCallTransmit_A7520 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallAutoSelectCallTransmit_A7520.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_234F:
			this.RTDBtnCnvPerConventionalChannelOptionsTAPLCode_A9261 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_235C:
			this.ExpanderConventionalPersonalityOneTouchTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2369:
			this.CpyBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2376:
			this.RTDBtnCnvPerRxOptionsHearClear_A36408 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2383:
			this.CpyBtnCnvPerConventionalChannelOptionsTASquelchType_A9265 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2390:
			this.RTDBtnCnvPerSignalingASTRORxUnmuteRule_A9042 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_239D:
			this.RTDBtnCnvPerASTROCallInCallUserAlertEnable_A8250 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23AA:
			this.LblCnvPerOneTouchFeature_A19662 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerOneTouchFeature_A19662.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23CE:
			this.CpyBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23DB:
			this.GrpBoxExpanderConventionalPersonalityRACRepeaterAccessButton2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_23E8:
			this.CnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerOneTouchAbbreviatedOneTouchAlias_A19664.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_240C:
			this.CnvPerIgnoreRxClearVoice_A41617 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerIgnoreRxClearVoice_A41617.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2430:
			this.LblCnvPerASTROCallRemoteMonitorTxRxTime = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallRemoteMonitorTxRxTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2454:
			this.LblCnvPerRACAccessType_A7388 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACAccessType_A7388.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2478:
			this.RTDBtnCnvPerNonASTROCallCallAlertRxTx_A7588 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2485:
			this.CVBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2492:
			this.CnvPerConventionalChannelOptionsTxPLFreq_A9419 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTxPLFreq_A9419.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24B6:
			this.RTDBtnCnvPerLabtoolSyncMode_A19308 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24C3:
			this.CpyBtnCnvPerLabtoolAutomaticScan_A7527 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_24D0:
			this.RTDBtnCnvPerNonASTROCallUnlimitedCalling_A9597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24DD:
			this.CVBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24EA:
			this.RTDBtnCnvPerGeneralTalkgroupTextList_A19822 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24F7:
			this.CVBtnCnvPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2504:
			this.GrpBoxExpanderConventionalPersonalityASTROCallTacticalServices = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2511:
			this.RTDBtnCnvPerConventionalChannelOptionsPLDeviation_A8708 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_251E:
			this.RTDBtnCnvPerSecureXLDelayFollowingKeyID_A9680 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_252B:
			this.CVBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2538:
			this.LblCnvPerSignalingRevertTGKeySel_A40154 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertTGKeySel_A40154.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_255C:
			this.CnvPerASTROCallInCallUserAlertEnable_A8250Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2569:
			this.CnvPerRACSingletone_A43073Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2576:
			this.LblCnvPerConventionalChannelOptionsTxDPLCode_A9409 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxDPLCode_A9409.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_259A:
			this.CnvPerConventionalChannelOptionsTxDPLInvert_A9410Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_25A7:
			this.CnvPerPhonePhoneOperation_A8703Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25B4:
			this.CpyBtnCnvPerRACSingletone_A43073 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25C1:
			this.CpyBtnCnvPerConventionalChannelOptionsTADPLCode_A9256 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25CE:
			this.CVBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25DB:
			this.RTDBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25E8:
			this.CnvPerFeaturesMixedVoteScanTxSteering_A38878 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesMixedVoteScanTxSteering_A38878.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_260C:
			this.CnvPerConventionalChannelOptionsTAPLFreq_A9264_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2619:
			this.GrpBoxExpanderConventionalPersonalityFeaturesScan = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2626:
			this.LblCnvPerAGAGSysID_A40156 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAGAGSysID_A40156.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_264A:
			this.CnvPerASTROCallASTROUnlimitedCalling_A7501 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerASTROCallASTROUnlimitedCalling_A7501.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_266E:
			this.CnvPerFeaturesOTARadioAliasUpdateEnable_A43059Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_267B:
			this.CnvPerASTROCallSelectiveCallRxTx_A9114Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2688:
			this.LblCnvPerRACMDCRepeaterID1_A8783 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACMDCRepeaterID1_A8783.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26AC:
			this.CpyBtnCnvPerASTROCallInCallUserAlertEnable_A8250 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26B9:
			this.CnvPerConventionalChannelOptionsDirectTalkaround_A9255Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_26C6:
			this.CVBtnCnvPerSecureKeySelection1_A8368 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26D3:
			this.CVBtnCnvPerAGAGKeySel_A40159 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26E0:
			this.CnvPerRxOptionsRxVoiceSignalType_A9044Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26ED:
			this.CnvPerAGAGWACNID_A40155Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_26FA:
			this.LblCnvPerFeaturesOTARadioAliasType_42784 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesOTARadioAliasType_42784.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_271E:
			this.CnvPerSignalingASTROSystem_A7498Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_272B:
			this.LblCnvPerGeneralConventionalPersonalityName_A12660 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerGeneralConventionalPersonalityName_A12660.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_274F:
			this.RTDBtnCnvPerSignalingLateEntryFastUnmute_A8423 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_275C:
			this.CVBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2769:
			this.ExpanderConventionalPersonalityGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_2776:
			this.ConPerMDCRunMDCDemodulator_A8494 = (global::AcpUI.AcpCheckBox)target;
			this.ConPerMDCRunMDCDemodulator_A8494.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_279A:
			this.LblCnvPerFeaturesConvetionalRSSIDisplay_42785 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesConvetionalRSSIDisplay_42785.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27BE:
			this.LblCnvPerSignalingSignalingType_A9129 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingSignalingType_A9129.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27E2:
			this.LblCnvPerGeneralTalkgroupTextList_A19822 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerGeneralTalkgroupTextList_A19822.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2806:
			this.CnvPerTxOptionsTimeOutTimersec_A9378Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2813:
			this.CpyBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2820:
			this.CpyBtnCnvPerSignalingASTROSystem_A7498 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_282D:
			this.LblCnvPerSignalingASTRORxUnmuteRule_A9042 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingASTRORxUnmuteRule_A9042.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2851:
			this.LblCnvPerASTROCallAutoSelectiveCallTransmit_A7518 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallAutoSelectiveCallTransmit_A7518.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2875:
			this.CpyBtnCnvPerRxOptionsRxDeEmphasis_A9010 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2882:
			this.CnvPerSecureEchoMuteTimems_A7919 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerSecureEchoMuteTimems_A7919.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28A6:
			this.RTDBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28B3:
			this.RTDBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28C0:
			this.LblCnvPerAdvancedSecondLOSideInjection_A9063 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvancedSecondLOSideInjection_A9063.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28E4:
			this.CnvPerASTROCallASTROCallHotList_A7488Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28F1:
			this.CpyBtnCnvPerSecureXLTransmit_A9683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28FE:
			this.HLinkRAC = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRAC.Click += this.HLinkClick;
			return;
			IL_2922:
			this.CVBtnCnvPerRxOptionsSquelchFineTune_A9176 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_292F:
			this.CnvPerRACAccessType_A7388Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_293C:
			this.CVBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2949:
			this.RTDBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2956:
			this.CVBtnCnvPerSecureScanHoldoffStrapping_A9050 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2963:
			this.CnvPerOneTouchIndex_A19663_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2970:
			this.LblCnvPerFeaturesFiregroundRegistration_A33242 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesFiregroundRegistration_A33242.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2994:
			this.RTDBtnCnvPerAGAGSecStrap_A40158 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29A1:
			this.CnvPerAdvancedDisableHighPassFilter_A7864Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_29AE:
			this.GrpBoxExpanderConventionalPersonalityNonASTROCallMDC = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_29BB:
			this.LblCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29DF:
			this.CnvPerASTROCallRadioUninhibitDecodeAction_A9045 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallRadioUninhibitDecodeAction_A9045.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A03:
			this.CnvPerAdvancedSecondLOSideInjection_A9063Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2A10:
			this.CnvPerFeaturesConvetionalRSSIDisplay_42785 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesConvetionalRSSIDisplay_42785.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A34:
			this.LblCnvPerConventionalChannelOptionsTASquelchType_A9265 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTASquelchType_A9265.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A58:
			this.LblCnvPerRxOptionsRxVoiceSignalType_A9044 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsRxVoiceSignalType_A9044.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A7C:
			this.CnvPerConventionalChannelOptionsTxSquelchType_A9426 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTxSquelchType_A9426.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2AA0:
			this.CnvPerConventionalChannelOptionsTxPLCode_A9418Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AAD:
			this.RTDBtnCnvPerAdvancedAdvancedRFAGC_A7408 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ABA:
			this.RTDBtnCnvPerOneTouchFeature_A19662 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AC7:
			this.CnvPerLabtoolOTACROTACSMessaging_A8663Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2AD4:
			this.RTDBtnCnvPerSignalingDigitalModulatorType_A7857 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AE1:
			this.CpyBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AEE:
			this.CnvPerSignalingRevertTGSecClearStrap_A40153 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingRevertTGSecClearStrap_A40153.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B12:
			this.CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B36:
			this.CnvPerTxOptionsTransmitPreEmphasis_A9411Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2B43:
			this.GrpBoxExpanderConventionalPersonalityNonASTROCallSelectiveCall = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2B50:
			this.CnvPerConventionalChannelOptionsTAPLFreq_A9264 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTAPLFreq_A9264.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B74:
			this.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B98:
			this.RTDBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BA5:
			this.CVBtnCnvPerTxOptionsTransmitPreEmphasis_A9411 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BB2:
			this.CnvPerSecureKeySelection1_A8368Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BBF:
			this.CnvPerSecureScanHoldoffStrapping_A9050 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureScanHoldoffStrapping_A9050.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BE3:
			this.CVBtnCnvPerSignalingASTROSystem_A7498 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BF0:
			this.LblCnvPerAdvancedAnalogWidebandData_A1994 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvancedAnalogWidebandData_A1994.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C14:
			this.LblCnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesOTARadioAliasUpdateEnable_A43059.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C38:
			this.CpyBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C45:
			this.RTDBtnCnvPerFeaturesRSSIDisplayTimer_42786 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C52:
			this.RTDBtnCnvPerRxOptionsSquelchFineTune_A9176 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C5F:
			this.CpyBtnCnvPerAdvancedDisableHighPassFilter_A7864 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C6C:
			this.CVBtnCnvPerRACSingletone_A43072 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C79:
			this.ExpanderConventionalPersonalityASTROTalkgroup = (global::AcpUI.AcpExpander)target;
			return;
			IL_2C86:
			this.LblCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CAA:
			this.CnvPerPhoneAutoAccessCodeSelect_A7503Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CB7:
			this.CnvPerTxOptionsTalkPermitToneComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2CC4:
			this.RTDBtnCnvPerOneTouchIndex_A19663 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CD1:
			this.RTDBtnCnvPerTacticalInhibitKillOperation_A41553 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CDE:
			this.CnvPerConventionalChannelOptionsPLDeviation_A8708Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CEB:
			this.CnvPerRACToneSignalingSystem_A9392Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CF8:
			this.CpyBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D05:
			this.CVBtnCnvPerSecureScanSelect_A9056 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D12:
			this.CVBtnCnvPerFeatureDTMFMicEn_A42481 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D1F:
			this.RTDBtnCnvPerRACSingletone_A43072 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D2C:
			this.CnvPerGeneralConventionalPersonalityName_A12660 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerGeneralConventionalPersonalityName_A12660.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D50:
			this.RTDBtnCnvPerSignalingSystemNumber_A9243 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D5D:
			this.CpyBtnCnvPerLabtoolQuickKeyOverride_A8808 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D6A:
			this.LblCnvPerSignalingASTROSystem_A7498 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingASTROSystem_A7498.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D8E:
			this.RTDBtnCnvPerIgnoreRxClearVoice_A41617 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D9B:
			this.CnvPerRxOptionsHearClear_A36408Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2DA8:
			this.RTDBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DB5:
			this.CnvPerSignalingASTROSystem_A7498 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingASTROSystem_A7498.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2DD9:
			this.RTDBtnCnvPerAGAGSysID_A40156 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DE6:
			this.CnvPerSecureIgnoreRxClearPacketData_A19310 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureIgnoreRxClearPacketData_A19310.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E0A:
			this.CVBtnCnvPerLabtoolAutomaticScan_A7527 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E17:
			this.RTDBtnCnvPerSignalingRevertType_A8953 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E24:
			this.GrpBoxExpanderConventionalPersonalitySignalingASTRO = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2E31:
			this.CpyBtnCnvPerRACCodeType1_A7680 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E3E:
			this.CnvPerRACCodeType1_A7680 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACCodeType1_A7680.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E62:
			this.CnvPerOneTouchButton_A19765_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2E6F:
			this.RTDBtnCnvPerASTROCallTacticalServicesOperation = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E7C:
			this.RTDBtnCnvPerRxOptionsRxVoiceSignalType_A9044 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E89:
			this.LblCnvPerLabtoolAnalogHotListItemID_A21918 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolAnalogHotListItemID_A21918.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EAD:
			this.CVBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EBA:
			this.RTDBtnConPerMDCRunMDCDemodulator_A8494 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EC7:
			this.CnvPerConventionalChannelOptionsRxFrequency_A8911 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerConventionalChannelOptionsRxFrequency_A8911.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EEB:
			this.LblCnvPerRxOptionsRxDeEmphasis_A9010 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsRxDeEmphasis_A9010.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F0F:
			this.RTDBtnCnvPerConventionalChannelOptionsTAFrequency_A9260 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F1C:
			this.RTDBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F29:
			this.CVBtnCnvPerConventionalChannelOptionsTxPLCode_A9418 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F36:
			this.CnvPerSignalingPTTID_A8770Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2F43:
			this.CpyBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F50:
			this.ExpanderConventionalPersonalityFrequencyOptions = (global::AcpUI.AcpExpander)target;
			return;
			IL_2F5D:
			this.CpyBtnCnvPerLabtoolScanListSelection_A9054 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F6A:
			this.LblCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F8E:
			this.CnvPerSignalingSystemNumber_A9243Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F9B:
			this.CpyBtnCnvPerAGAGSysID_A40156 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FA8:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2FB5:
			this.CpyBtnCnvPerSecureASTROOTAR_A7493 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FC2:
			this.CnvPerAdvanceBroadbandProtection = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerAdvanceBroadbandProtection.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FE6:
			this.CnvPerConventionalChannelOptionsRxSquelchType_A8919 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsRxSquelchType_A8919.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_300A:
			this.CnvPerSignalingRevertTGKeySel_A40154 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingRevertTGKeySel_A40154.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_302E:
			this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable.ModeClick += this.OnModeClick;
			return;
			IL_3052:
			this.CnvPerLabtoolAutomaticScan_A7527 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerLabtoolAutomaticScan_A7527.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3076:
			this.CnvPerConventionalChannelOptionsRxSquelchType_A8919Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3083:
			this.RTDBtnCnvPerRACCodeType2_A8817 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3090:
			this.CVBtnCnvPerConventionalChannelOptionsTxFrequency_A9414 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_309D:
			this.CnvPerLabtoolSmartPTTType_A9164 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerLabtoolSmartPTTType_A9164.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30C1:
			this.CnvPerAGAGSecStrap_A40158Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30CE:
			this.CnvPerSignalingRevertTG_A40152 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvPerSignalingRevertTG_A40152.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30F2:
			this.CpyBtnCnvPerOneTouchButton_A19765 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_30FF:
			this.CnvPerConventionalChannelOptionsTxFrequency_A9414Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_310C:
			this.CnvPerAdvancedAdvancedRFAGC_A7408Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3119:
			this.LblCnvPerASTROCallASTROUnlimitedCalling_A7501 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallASTROUnlimitedCalling_A7501.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_313D:
			this.CnvPerRxOptionsBusyLED_A7570 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerRxOptionsBusyLED_A7570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3161:
			this.LblCnvPerConventionalChannelOptionsTAFrequency_A9260 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTAFrequency_A9260.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3185:
			this.LblCnvPerSignalingRevertTGSecClearStrap_A40153 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertTGSecClearStrap_A40153.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31A9:
			this.CpyBtnCnvPerAGAGTalkgroupID_A40157 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31B6:
			this.RTDBtnCnvPerFeaturesTacticalRekeyEnable_A19309 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31C3:
			this.CnvPerSecureKeyStrapping_A8370Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31D0:
			this.CVBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31DD:
			this.RTDBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31EA:
			this.LblCnvPerIgnoreRxClearVoice_A41617 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerIgnoreRxClearVoice_A41617.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_320E:
			this.RTDBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_321B:
			this.CVBtnConPerFeatureIncidentSignalingType_A41507 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3228:
			this.CVBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3235:
			this.LblCnvPerConventionalChannelOptionsDirectTalkaround_A9255 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsDirectTalkaround_A9255.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3259:
			this.CnvPerFeaturesConvetionalRSSIDisplay_42785Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3266:
			this.RTDBtnCnvPerASTROCallRemoteMonitorTxRxTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3273:
			this.CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3280:
			this.ExpanderConventionalPersonalityAdvanced = (global::AcpUI.AcpExpander)target;
			return;
			IL_328D:
			this.CVBtnCnvPerTxOptionsTxVoiceSignalType_A9574 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_329A:
			this.CpyBtnConPerFeatureIncidentSignalingType_A41507 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32A7:
			this.ExpanderConventionalPersonalityFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_32B4:
			this.CnvPerASTROCallRadioUninhibitDecodeAction_A9045Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_32C1:
			this.RTDBtnCnvPerTxOptionsTransmitPowerLevel_A9420 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32CE:
			this.CVBtnCnvPerSecureEchoMuteTimems_A7919 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32DB:
			this.LblCnvPerSecureXLTransmit_A9683 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureXLTransmit_A9683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32FF:
			this.CpyBtnCnvPerAdvancedAnalogWidebandData_A1994 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_330C:
			this.GrpBoxExpanderConventionalPersonalitySignalingNonASTRO = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3319:
			this.CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_333D:
			this.GrpBoxExpanderConventionalPersonalitySignalingEmergencyRevert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_334A:
			this.CnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesOTARadioAliasUpdateEnable_A43059.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_336E:
			this.CpyBtnCnvPerRxOptionsBusyLED_A7570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_337B:
			this.RTDBtnCnvPerNonASTROCallRTTButtonAccess_A8493 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3388:
			this.CpyBtnCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3395:
			this.CVBtnCnvPerRACAccessType_A7388 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33A2:
			this.CpyBtnCnvPerRACToneSignalingSystem_A9392 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33AF:
			this.LblCnvPerRACCodeType1_A7680 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACCodeType1_A7680.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33D3:
			this.RTDBtnCnvPerTxOptionsAdaptivePower_A7405 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_33E0:
			this.CnvPerAdvancedAdvancedRFAGC_A7408 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerAdvancedAdvancedRFAGC_A7408.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3404:
			this.RTDBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3411:
			this.GrpBoxExpanderConventionalPersonalityRACPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_341E:
			this.CnvPerRxOptionsUnmuteMuteType_A9602 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRxOptionsUnmuteMuteType_A9602.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3442:
			this.CVBtnCnvPerFeaturesMixedVoteScanEnable_A38723 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_344F:
			this.RTDBtnCnvPerFeaturesFiregroundRegistration_A33242 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_345C:
			this.LblCnvPerTacticalInhibitKillOperation_A41553 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTacticalInhibitKillOperation_A41553.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3480:
			this.GrpBoxExpanderConventionalPersonalityASTROCallTacticalInhibit = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_348D:
			this.CVBtnCnvPerAdvancedAnalogWidebandData_A1994 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_349A:
			this.ConPerMDCRunMDCDemodulator_A8494Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34A7:
			this.CVBtnCnvPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34B4:
			this.RTDBtnCnvPerSignalingRevertTGKeySel_A40154 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34C1:
			this.CnvPerConventionalChannelOptionsTxNetworkID_A9550_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_34CE:
			this.CnvPerTxOptionsReverseBurstTurnOffCode_A8952 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerTxOptionsReverseBurstTurnOffCode_A8952.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34F2:
			this.CnvPerNonASTROCallSelectiveCallRxTx_A9116Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_34FF:
			this.LblCnvPerLabtoolSmartPTTType_A9164 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolSmartPTTType_A9164.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3523:
			this.LblCnvPerNonASTROCallUnmuteType_A9601 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallUnmuteType_A9601.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3547:
			this.LblCnvPerConventionalChannelOptionsTAPLFreq_A9264 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTAPLFreq_A9264.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_356B:
			this.CpyBtnConPerMDCRunMDCDemodulator_A8494 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3578:
			this.CnvPerSecureXLDelayFollowingKeyID_A9680Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3585:
			this.CpyBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3592:
			this.ExpanderConventionalPersonalityRAC = (global::AcpUI.AcpExpander)target;
			return;
			IL_359F:
			this.CnvPerNonASTROCallUnmuteType_A9601Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35AC:
			this.RTDBtnCnvPerConventionalChannelOptionsTASquelchType_A9265 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35B9:
			this.CnvPerSecureKeySelection2_A8369 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureKeySelection2_A8369.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35DD:
			this.RTDBtnCnvPerSecureKMFProfileIndex_A8381 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35EA:
			this.RTDBtnCnvPerFeaturesConvetionalRSSIDisplay_42785 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35F7:
			this.CVBtnCnvPerPhoneAutoAccessCodeSelect_A7503 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3604:
			this.LblCnvPerRxOptionsConcurrentRXEnable = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsConcurrentRXEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3628:
			this.RTDBtnCnvPerASTROCallASTROUnlimitedCalling_A7501 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3635:
			this.CVBtnCnvPerEndTxOnVoiceAbsence_42460 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3642:
			this.CVBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_364F:
			this.RTDBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_365C:
			this.LblCnvPerSignalingRevertTG_A40152 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertTG_A40152.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3680:
			this.CpyBtnCnvPerSignalingRevertType_A8953 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_368D:
			this.LblCnvPerSecureXLDelayFollowingKeyID_A9680 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureXLDelayFollowingKeyID_A9680.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36B1:
			this.CnvPerNonASTROCallUnlimitedCalling_A9597 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerNonASTROCallUnlimitedCalling_A9597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36D5:
			this.CnvPerFeatureDTMFMicEn_A42481Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_36E2:
			this.RTDBtnCnvPerAdvancedSecondLOSideInjection_A9063 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36EF:
			this.CVBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36FC:
			this.CnvPerASTROCallRemotemonitorfrequencyoption = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallRemotemonitorfrequencyoption.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3720:
			this.CnvPerSignalingDigitalModulatorType_A7857 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingDigitalModulatorType_A7857.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3744:
			this.CnvPerSecureKeyStrapping_A8370 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureKeyStrapping_A8370.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3768:
			this.LblCnvPerLabtoolSyncMode_A19308 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolSyncMode_A19308.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_378C:
			this.RTDBtnCnvPerSecureEchoMuteTimems_A7919 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3799:
			this.CnvPerTacticalInhibitKillOperation_A41553 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerTacticalInhibitKillOperation_A41553.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37BD:
			this.RTDBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37CA:
			this.LblCnvPerRACMDCRepeaterID2_A8814 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACMDCRepeaterID2_A8814.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37EE:
			this.LblCnvPerRACToneSignalingSystem_A9392 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACToneSignalingSystem_A9392.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3812:
			this.CVBtnCnvPerPhoneAccessTimingTable_A7387 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_381F:
			this.CnvPerLabtoolSmartPTTType_A9164Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_382C:
			this.RTDBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3839:
			this.CpyBtnCnvPerRACMDCRepeaterID1_A8783 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3846:
			this.LblCnvPerFeatureDTMFMicEn_A42481 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeatureDTMFMicEn_A42481.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_386A:
			this.RTDBtnCnvPerSecureDESXLTxDefault_A7831 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3877:
			this.CpyBtnCnvPerSignalingASTRORxUnmuteRule_A9042 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3884:
			this.RTDBtnCnvPerASTROCallSelectiveCallRxTx_A9114 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3891:
			this.LblCnvPerConventionalChannelOptionsTxPLFreq_A9419 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxPLFreq_A9419.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38B5:
			this.CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = (global::AcpUI.AcpLabel)target;
			this.CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_38D9:
			this.ExpanderConventionalPersonalityPhone = (global::AcpUI.AcpExpander)target;
			return;
			IL_38E6:
			this.CnvPerAdvancedAnalogWidebandData_A1994Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_38F3:
			this.RTDBtnCnvPerPhonePhoneOperation_A8703 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3900:
			this.CpyBtnCnvPerAGAGKeySel_A40159 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_390D:
			this.CVBtnCnvPerSignalingRevertTGSecClearStrap_A40153 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_391A:
			this.CpyBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3927:
			this.CVBtnCnvPerSecureSecureClearStrapping1_A9090 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3934:
			this.RTDBtnCnvPerConventionalChannelOptionsRxPLCode_A8917 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3941:
			this.GrpBoxExpanderConventionalPersonalityFeaturesPersonnelAccountability = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_394E:
			this.ConPerFeatureIncidentSignalingType_A41507Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_395B:
			this.CpyBtnCnvPerLabtoolAnalogHotListItemID_A21918 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3968:
			this.CVBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3975:
			this.LblCnvPerOneTouchButton_A19765 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerOneTouchButton_A19765.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3999:
			this.CVBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39A6:
			this.CnvPerConventionalChannelOptionsTxDPLCode_A9409_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_39B3:
			this.CVBtnCnvPerSignalingRevertType_A8953 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39C0:
			this.CnvPerSecureXLDelayFollowingKeyID_A9680 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerSecureXLDelayFollowingKeyID_A9680.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39E4:
			this.CnvPerFeaturesFiregroundRegistration_A33242 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesFiregroundRegistration_A33242.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A08:
			this.CVBtnCnvPerNonASTROCallCallAlertRxTx_A7588 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A15:
			this.RTDBtnCnvPerSignalingPTTID_A8770 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A22:
			this.CnvPerConventionalChannelOptionsRxDPLCode_A8908Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3A2F:
			this.LblCnvPerLabtoolAutomaticScan_A7527 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolAutomaticScan_A7527.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A53:
			this.CnvPerTxOptionsTransmitPreEmphasis_A9411 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerTxOptionsTransmitPreEmphasis_A9411.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A77:
			this.CnvPerConventionalChannelOptionsRxPLCode_A8917_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3A84:
			this.CnvPerConventionalChannelOptionsTASquelchType_A9265 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTASquelchType_A9265.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AA8:
			this.CVBtnCnvPerSecureDESXLTxDefault_A7831 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3AB5:
			this.CnvPerSignalingPTTID_A8770 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSignalingPTTID_A8770.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AD9:
			this.LblCnvPerAdvancedDisableHighPassFilter_A7864 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvancedDisableHighPassFilter_A7864.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3AFD:
			this.RTDBtnCnvPerNonASTROCallUnmuteType_A9601 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B0A:
			this.RTDBtnCnvPerASTROCallASTROCallHotList_A7488 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B17:
			this.CnvPerGeneralConventionalPersonalityName_A12660Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3B24:
			this.CnvPerSignalingRevertTGSYSID_A40151 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvPerSignalingRevertTGSYSID_A40151.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B48:
			this.CpyBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B55:
			this.CVBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B62:
			this.CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3B6F:
			this.CpyBtnCnvPerSecureDESXLTxDefault_A7831 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B7C:
			this.CpyBtnCnvPerPhonePhoneOperation_A8703 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B89:
			this.CVBtnCnvPerSecureIgnoreRxClearPacketData_A19310 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B96:
			this.CnvPerSignalingRevertTGSYSID_A40151Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_3BA3:
			this.RTDBtnCnvPerFeatureDTMFMicEn_A42481 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3BB0:
			this.LblCnvPerRxOptionsBusyLED_A7570 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsBusyLED_A7570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BD4:
			this.CVBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BE1:
			this.CnvPerNonASTROCallCallAlertRxTx_A7588 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerNonASTROCallCallAlertRxTx_A7588.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C05:
			this.LblCnvPerSecureASTROOTAR_A7493 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureASTROOTAR_A7493.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C29:
			this.RTDBtnCnvPerRxOptionsRxDeEmphasis_A9010 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C36:
			this.CpyBtnCnvPerASTROCallASTROCallHotList_A7488 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C43:
			this.LblCnvPerSecureKMFProfileIndex_A8381 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureKMFProfileIndex_A8381.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C67:
			this.CpyBtnCnvPerSecureXLDelayFollowingKeyID_A9680 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C74:
			this.GrpBoxExpanderConventionalPersonalityDVRSAnnouncementGroup = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3C81:
			this.CVBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C8E:
			this.CVBtnCnvPerSecureProperCodeDetect_A8762 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C9B:
			this.CnvPerRACToneSignalingSystem_A9392 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACToneSignalingSystem_A9392.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3CBF:
			this.CnvPerGeneralTalkgroupTextList_A19822Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CCC:
			this.LblCnvPerSecureEchoMuteTimems_A7919 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureEchoMuteTimems_A7919.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CF0:
			this.CnvPerSecureOTARTx_A8675Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3CFD:
			this.CnvPerRxOptionsBusyLED_A7570Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3D0A:
			this.LblCnvPerSecureKeySelection2_A8369 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureKeySelection2_A8369.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D2E:
			this.CnvPerRACAccessType_A7388 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACAccessType_A7388.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D52:
			this.CnvPerConventionalChannelOptionsTAFrequency_A9260_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3D5F:
			this.RTDBtnCnvPerRACRepeaterAccess_A8939 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D6C:
			this.RTDBtnCnvPerSecureKeyID_A8361 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D79:
			this.GrpBoxExpanderConventionalPersonalitySecurePacketData = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3D86:
			this.ExpanderConventionalPersonalityOneTouchTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3D93:
			this.GrpBoxExpanderConventionalPersonalityFrequencyOptionsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3DA0:
			this.CnvPerLabtoolAutomaticScan_A7527Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3DAD:
			this.LblCnvPerTxOptionsTxVoiceSignalType_A9574 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsTxVoiceSignalType_A9574.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DD1:
			this.LblCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DF5:
			this.LblCnvPerConventionalChannelOptionsTADPLInvert_A9259 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTADPLInvert_A9259.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E19:
			this.CnvPerConventionalChannelOptionsRxPLFreq_A8918_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3E26:
			this.CnvPerConventionalChannelOptionsTalkaround_A19837Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E33:
			this.CnvPerRACRepeaterAccess_A8939Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3E40:
			this.RTDBtnCnvPerRxOptionsRxUnmuteDelayms_A9033 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E4D:
			this.CnvPerConventionalChannelOptionsTAPLCode_A9261Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E5A:
			this.LblCnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerOneTouchAbbreviatedOneTouchAlias_A19664.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E7E:
			this.CnvPerConventionalChannelOptionsTxSquelchType_A9426Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3EA3:
			goto IL_6A4E;
			IL_3EA8:
			this.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3ECC:
			this.CpyBtnCnvPerConventionalChannelOptionsTAFrequency_A9260 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3ED9:
			this.CVBtnCnvPerRxOptionsRxDeEmphasis_A9010 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3EE6:
			this.LblCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F0A:
			this.CnvPerSecureKMFProfileIndex_A8381Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F17:
			this.CnvPerSignalingRevertTGSecClearStrap_A40153Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F24:
			this.LblCnvPerASTROCallSelectiveCallRxTx_A9114 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallSelectiveCallRxTx_A9114.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F48:
			this.CnvPerConventionalChannelOptionsDirectTalkaround_A9255 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsDirectTalkaround_A9255.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F6C:
			this.LblCnvPerFeaturesMixedVoteScanEnable_A38723 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesMixedVoteScanEnable_A38723.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F90:
			this.RTDBtnCnvPerSignalingRevertTGSYSID_A40151 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F9D:
			this.CpyBtnCnvPerSignalingPTTID_A8770 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FAA:
			this.RTDBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FB7:
			this.CVBtnCnvPerASTROCallRemoteMonitorTxRxTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FC4:
			this.CpyBtnCnvPerRxOptionsConcurrentRXEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FD1:
			this.RTDBtnCnvPerAdvancedAnalogWidebandData_A1994 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FDE:
			this.CnvPerConventionalChannelOptionsRxDPLCode_A8908_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3FEB:
			this.CVBtnCnvPerLabtoolSmartPTTType_A9164 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FF8:
			this.ExpanderConventionalPersonalitySecure = (global::AcpUI.AcpExpander)target;
			return;
			IL_4005:
			this.RTDBtnConPerFeatureIncidentSignalingType_A41507 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4012:
			this.CnvPerConventionalChannelOptionsTAFrequency_A9260Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_401F:
			this.CnvPerNonASTROCallInCallUserAlertEnable_A8252Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_402C:
			this.CnvPerConventionalChannelOptionsTADPLInvert_A9259 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsTADPLInvert_A9259.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4050:
			this.RTDBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_405D:
			this.CVBtnCnvPerLabtoolSyncMode_A19308 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_406A:
			this.CnvPerASTROCallASTROCallHotList_A7488 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallASTROCallHotList_A7488.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_408E:
			this.GrpBoxExpanderConventionalPersonalityASTROCallPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_409B:
			this.LblCnvPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesHazardZoneModePersonality.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_40BF:
			this.GrpBoxExpanderConventionalPersonalityTxOptionsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_40CC:
			this.RTDBtnCnvPerLabtoolHotKeypad_A8208 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40D9:
			this.GrpBoxExpanderConventionalPersonalitySecurePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_40E6:
			this.CpyBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40F3:
			this.CnvPerConventionalChannelOptionsTxNetworkID_A9550 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvPerConventionalChannelOptionsTxNetworkID_A9550.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4117:
			this.CnvPerRACMDCRepeaterID1_A8783 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACMDCRepeaterID1_A8783.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_413B:
			this.RTDBtnCnvPerSecureOTARTx_A8675 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4148:
			num = (short)2122642811;
			short num3 = num;
			num = (short)744945019;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5E1A:
				this.CnvPerRACMDCRepeaterID2_A8814 = (global::AcpUI.AcpComboBox)target;
				this.CnvPerRACMDCRepeaterID2_A8814.GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				num = (short)591527936;
				if (num != 0)
				{
				}
				this.CnvPerIgnoreRxClearVoice_A41617Comp = (global::AcpUI.AcpCheckBox)target;
				return;
			}
			IL_41A3:
			this.RTDBtnCnvPerRACMDCRepeaterID2_A8814 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41B0:
			this.CpyBtnCnvPerASTROCallSelectiveCallRxTx_A9114 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_41BD:
			this.RTDBtnCnvPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41CA:
			this.CpyBtnCnvPerFeatureRFModem_42485 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_41D7:
			this.GrpBoxExpanderConventionalPersonalityNonASTROCallPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_41E4:
			this.LblCnvPerSignalingDigitalModulatorType_A7857 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingDigitalModulatorType_A7857.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4208:
			this.LblCnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROTalkgroupOptionsTalkgroupList_A9283.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_422C:
			this.CVBtnCnvPerAGAGTalkgroupID_A40157 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4239:
			this.CnvPerConventionalChannelOptionsRxPLCode_A8917 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsRxPLCode_A8917.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_425D:
			this.GrpBoxExpanderConventionalPersonalityFeaturesTacticalPublicSafety = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_426A:
			this.RTDBtnCnvPerLabtoolSmartPTTType_A9164 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4277:
			this.CnvPerFeaturesRSSIDisplayTimer_42786Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4284:
			this.CpyBtnCnvPerRxOptionsRxUnmuteDelayms_A9033 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4291:
			this.CnvPerSignalingSignalingType_A9129Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_429E:
			this.LblCnvPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesAstroAlertingToneTable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_42C2:
			this.CpyBtnCnvPerSignalingLateEntryFastUnmute_A8423 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42CF:
			this.CVBtnCnvPerNonASTROCallUnlimitedCalling_A9597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_42DC:
			this.CnvPerRxOptionsSquelchFineTune_A9176Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_42E9:
			this.CVBtnCnvPerRxOptionsBusyLED_A7570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_42F6:
			this.CnvPerLabtoolAnalogHotListItemID_A21918Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4303:
			this.CpyBtnCnvPerSecureProperCodeDetect_A8762 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4310:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_4334:
			this.ExpanderConventionalPersonalityTxOptions = (global::AcpUI.AcpExpander)target;
			return;
			IL_4341:
			this.CnvPerTxOptionsAdaptivePower_A7405Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_434E:
			this.CpyBtnCnvPerConventionalChannelOptionsPLDeviation_A8708 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_435B:
			this.RTDBtnCnvPerLabtoolOTACROTACSMessaging_A8663 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4368:
			this.RTDBtnCnvPerSignalingRevertTG_A40152 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4375:
			this.CnvPerASTROCallInCallUserAlertEnable_A8250 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerASTROCallInCallUserAlertEnable_A8250.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4399:
			this.CpyBtnCnvPerSecureIgnoreRxClearPacketData_A19310 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_43A6:
			this.RTDBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_43B3:
			this.RTDBtnCnvPerTxOptionsTalkPermitTone = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_43C0:
			this.CpyBtnCnvPerFeatureDTMFMicEn_A42481 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_43CD:
			this.CnvPerRACSingletone_A43073 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACSingletone_A43073.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43F1:
			this.CnvPerConventionalChannelOptionsRxNetworkID_A9023Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_43FE:
			this.CnvPerConventionalChannelOptionsPLDeviation_A8708 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsPLDeviation_A8708.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4422:
			this.CVBtnCnvPerRACSingletone_A43073 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_442F:
			this.LblCnvPerConventionalChannelOptionsRxSquelchType_A8919 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxSquelchType_A8919.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4453:
			this.CnvPerTxOptionsReverseBurstTurnOffCode_A8952Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4460:
			this.CnvPerConventionalChannelOptionsRxNetworkID_A9023 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvPerConventionalChannelOptionsRxNetworkID_A9023.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4484:
			this.CnvPerSecureSecureClearStrapping2_A9091 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureSecureClearStrapping2_A9091.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_44A8:
			this.CnvPerSecureProperCodeDetect_A8762Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_44B5:
			this.LblCnvPerSecureSecureClearStrapping2_A9091 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureSecureClearStrapping2_A9091.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44D9:
			this.LblCnvPerSecureScanHoldoffStrapping_A9050 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureScanHoldoffStrapping_A9050.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44FD:
			this.LblCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4521:
			this.CnvPerSecureSecureClearStrapping2_A9091Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_452E:
			this.CnvPerOneTouchFeature_A19662 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerOneTouchFeature_A19662.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4552:
			this.CVBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_455F:
			this.LblCnvPerTPSTPSUIEnable_A9400 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTPSTPSUIEnable_A9400.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4583:
			this.CpyBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4590:
			this.LblCnvPerAGAGTalkgroupID_A40157 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAGAGTalkgroupID_A40157.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_45B4:
			this.CnvPerPhoneAutoAccessCodeSelect_A7503 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerPhoneAutoAccessCodeSelect_A7503.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45D8:
			this.CnvPerTxOptionsAdaptivePower_A7405 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerTxOptionsAdaptivePower_A7405.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45FC:
			this.CpyBtnCnvPerASTROCallCallAlertRxTx_A7586 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4609:
			this.CpyBtnCnvPerSignalingRevertZone_A13269 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4616:
			this.CpyBtnCnvPerAdvanceBroadbandProtection = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4623:
			this.LblCnvPerRACCodeType2_A8817 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACCodeType2_A8817.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4647:
			this.CpyBtnCnvPerSignalingRevertTGSecClearStrap_A40153 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4654:
			this.CnvPerConventionalChannelOptionsTxDPLCode_A9409 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTxDPLCode_A9409.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4678:
			this.CVBtnCnvPerSignalingLateEntryFastUnmute_A8423 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4685:
			this.CpyBtnCnvPerSecureKeySelection2_A8369 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4692:
			this.CpyBtnCnvPerSecureScanHoldoffStrapping_A9050 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_469F:
			this.CnvPerRxOptionsReceiveOnlyPersonality_A8916Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_46AC:
			this.LblCnvPerTacticalInhibitStunOperation_A41557 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTacticalInhibitStunOperation_A41557.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_46D0:
			this.ExpanderConventionalPersonalityFrequencyOptionsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_46DD:
			this.CpyBtnCnvPerTacticalInhibitStunOperation_A41557 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_46EA:
			this.CnvPerFeaturesDVRSProf_A41794Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_46F7:
			this.CVBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4704:
			this.CpyBtnCnvPerSecureSecureClearStrapping1_A9090 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4711:
			this.RTDBtnCnvPerFeaturesDVRSProf_A41794 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_471E:
			this.ExpanderConventionalPersonalityOneTouchTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_472B:
			this.CVBtnCnvPerRxOptionsHearClear_A36408 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4738:
			this.LblCnvPerSignalingRevertType_A8953 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertType_A8953.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_475C:
			this.CpyBtnCnvPerIgnoreRxClearVoice_A41617 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4769:
			this.RTDBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4776:
			this.LblCnvPerRACSingletone_A43072 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACSingletone_A43072.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_479A:
			this.HLinkSecure = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecure.Click += this.HLinkClick;
			return;
			IL_47BE:
			this.CnvPerRxOptionsSquelchFineTune_A9176 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRxOptionsSquelchFineTune_A9176.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47E2:
			this.GrpBoxExpanderConventionalPersonalitySecureVoice = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_47EF:
			this.LblCnvPerConventionalChannelOptionsRxPLFreq_A8918 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxPLFreq_A8918.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4813:
			this.RTDBtnCnvPerASTROCallCallAlertRxTx_A7586 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4820:
			num = (short)2067660800;
			short num4 = num;
			this.CVBtnCnvPerAdvancedAnalogFlatAudio_A7443 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4856:
			this.RTDBtnCnvPerLabtoolScanListSelection_A9054 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4863:
			this.CnvPerConventionalChannelOptionsTAPLFreq_A9264Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4870:
			this.GrpBoxExpanderConventionalPersonalitySignalingPseudo4 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_487D:
			this.ExpanderConventionalPersonalitySignaling = (global::AcpUI.AcpExpander)target;
			return;
			IL_488A:
			this.HLinkSignaling = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSignaling.Click += this.HLinkClick;
			return;
			IL_48AE:
			this.LblCnvPerTxOptionsAdaptivePower_A7405 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsAdaptivePower_A7405.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_48D2:
			this.RTDBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_48DF:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4903:
			this.CnvPerFeaturesMixedVoteScanEnable_A38723 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesMixedVoteScanEnable_A38723.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4927:
			this.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4934:
			this.CnvPerAdvancedAnalogWidebandData_A1994 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerAdvancedAnalogWidebandData_A1994.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4958:
			this.CnvPerFeaturesRSSIDisplayTimer_42786 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerFeaturesRSSIDisplayTimer_42786.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_497C:
			this.CnvPerSignalingSystemNumber_A9243 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingSystemNumber_A9243.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49A0:
			this.CpyBtnCnvPerSecureKeyID_A8361 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49AD:
			this.CVBtnCnvPerSecureXLTransmit_A9683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49BA:
			this.CnvPerConventionalChannelOptionsTxDPLInvert_A9410 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsTxDPLInvert_A9410.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49DE:
			this.CVBtnCnvPerFeaturesConvetionalRSSIDisplay_42785 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49EB:
			this.RTDBtnCnvPerEndTxOnVoiceAbsence_42460 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_49F8:
			this.RTDBtnCnvPerSecureXLTransmit_A9683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A05:
			this.CpyBtnCnvPerEndTxOnVoiceAbsence_42460 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4A12:
			this.CVBtnCnvPerSecureKeyStrapping_A8370 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A1F:
			this.RTDBtnCnvPerFeatureRFModem_42485 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A2C:
			this.CnvPerFeaturesAstroAlertingToneTableComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A39:
			this.CVBtnCnvPerSignalingSystemNumber_A9243 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A46:
			this.RTDBtnCnvPerSignalingRevertTGWACNID_A40150 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A53:
			this.CnvPerConventionalChannelOptionsRxPLFreq_A8918Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A60:
			this.CpyBtnCnvPerConventionalChannelOptionsTAPLCode_A9261 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4A6D:
			this.CpyBtnCnvPerFeaturesConvetionalRSSIDisplay_42785 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4A7A:
			this.LblCnvPerAdvancedAnalogFlatAudio_A7443 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvancedAnalogFlatAudio_A7443.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A9E:
			this.RTDBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4AAB:
			this.CVBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4AB8:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_4AC5:
			this.RTDBtnCnvPerSecureSecureVoiceSignalType_A9086 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4AD2:
			this.CpyBtnCnvPerSecureEchoMuteTimems_A7919 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4ADF:
			this.LblCnvPerConventionalChannelOptionsTANetworkID_A7863 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTANetworkID_A7863.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B03:
			this.CpyBtnCnvPerFeaturesTxVoiceType_A9573 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B10:
			this.CnvPerTxOptionsTalkPermitTone = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerTxOptionsTalkPermitTone.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B34:
			this.CnvPerOneTouchAbbreviatedOneTouchAlias_A19664Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B41:
			this.RTDBtnCnvPerASTROCallRemotemonitorfrequencyoption = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4B4E:
			this.CnvPerSecureEchoMuteTimems_A7919Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B5B:
			this.CnvPerSecureKeySelection1_A8368 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureKeySelection1_A8368.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B7F:
			this.CpyBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B8C:
			this.CnvPerSignalingASTRORxUnmuteRule_A9042Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B99:
			this.CpyBtnCnvPerASTROCallRemotemonitorfrequencyoption = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BA6:
			this.RTDBtnCnvPerTxOptionsTimeOutTimersec_A9378 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BB3:
			this.CpyBtnCnvPerRACRepeaterAccess_A8939 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BC0:
			this.RTDBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BCD:
			this.CnvPerConventionalChannelOptionsRxPLCode_A8917Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4BDA:
			this.ExpanderConventionalPersonalityOneTouchGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4BE7:
			this.ConPerFeatureIncidentSignalingType_A41507 = (global::AcpUI.AcpComboBox)target;
			this.ConPerFeatureIncidentSignalingType_A41507.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C0B:
			this.RTDBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4C18:
			this.CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4C25:
			this.RTDBtnCnvPerAGAGWACNID_A40155 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4C32:
			this.LblCnvPerSecureKeyStrapping_A8370 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureKeyStrapping_A8370.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C56:
			this.CVBtnCnvPerRxOptionsConcurrentRXEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C63:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.PageConventionalPersonality)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.PageConventionalPersonality)target).Unloaded += this.OnUnloaded;
			return;
			IL_4C94:
			this.LblCnvPerSecureIgnoreRxClearPacketData_A19310 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureIgnoreRxClearPacketData_A19310.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4CB8:
			this.CVBtnCnvPerRxOptionsUnmuteMuteType_A9602 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4CC5:
			this.CnvPerSecureKeyID_A8361Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4CD2:
			this.CpyBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CDF:
			this.CnvPerOneTouchFeature_A19662Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4CEC:
			this.CVBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4CF9:
			this.CnvPerConventionalChannelOptionsTxPLFreq_A9419Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D06:
			this.CVBtnCnvPerTxOptionsTransmitPowerLevel_A9420 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D13:
			this.CVBtnCnvPerRACMDCRepeaterID1_A8783 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D20:
			this.LblCnvPerAdvancedAdvancedRFAGC_A7408 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAdvancedAdvancedRFAGC_A7408.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4D44:
			this.CnvPerAdvancedAnalogFlatAudio_A7443 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerAdvancedAnalogFlatAudio_A7443.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4D68:
			this.CVBtnCnvPerAGAGSysID_A40156 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D75:
			this.LblCnvPerLabtoolScanListSelection_A9054 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolScanListSelection_A9054.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4D99:
			this.CnvPerRxOptionsUnmuteMuteType_A9602Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4DA6:
			this.LblCnvPerTxOptionsTalkPermitTone = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsTalkPermitTone.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4DCA:
			this.CVBtnCnvPerAdvancedSecondLOSideInjection_A9063 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DD7:
			this.CpyBtnCnvPerTxOptionsTxVoiceSignalType_A9574 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4DE4:
			this.LblCnvPerSecureScanSelect_A9056 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureScanSelect_A9056.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E08:
			this.ExpanderConventionalPersonalityOneTouch = (global::AcpUI.AcpExpander)target;
			return;
			IL_4E15:
			this.RTDBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E22:
			this.CpyBtnCnvPerConventionalChannelOptionsTalkaround_A19837 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E2F:
			this.CnvPerSecureSecureClearStrapping1_A9090Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E3C:
			this.CnvPerConventionalChannelOptionsTANetworkID_A7863Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4E49:
			this.RTDBtnCnvPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E56:
			this.CnvPerFeaturesTxVoiceType_A9573 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerFeaturesTxVoiceType_A9573.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E7A:
			this.CVBtnCnvPerGeneralConventionalPersonalityName_A12660 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E87:
			this.ExpanderConventionalPersonalityLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_4E94:
			this.CpyBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EA1:
			this.CpyBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EAE:
			this.CnvPerSignalingRevertTG_A40152Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4EBB:
			this.RTDBtnCnvPerTacticalInhibitStunOperation_A41557 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4EC8:
			this.CVBtnCnvPerAdvanceBroadbandProtection = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4ED5:
			this.CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4EE2:
			this.CnvPerConventionalChannelOptionsTANetworkID_A7863 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvPerConventionalChannelOptionsTANetworkID_A7863.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F06:
			this.RTDBtnCnvPerSecureIgnoreRxClearPacketData_A19310 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4F13:
			this.CnvPerRxOptionsRxUnmuteDelayms_A9033Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F20:
			this.GrpBoxExpanderConventionalPersonalitySecurePseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4F2D:
			this.CnvPerSecureSecureVoiceSignalType_A9086Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F3A:
			this.CnvPerRxOptionsConcurrentRXEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4F47:
			this.CnvPerSignalingRevertZone_A13269 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingRevertZone_A13269.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F6B:
			this.CnvPerConventionalChannelOptionsTAPLCode_A9261 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTAPLCode_A9261.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F8F:
			this.CnvPerConventionalChannelOptionsTAFrequency_A9260 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerConventionalChannelOptionsTAFrequency_A9260.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4FB3:
			this.GrpBoxExpanderConventionalPersonalityAdvancedPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4FC0:
			this.CnvPerConventionalChannelOptionsPLDeviation_A8708_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4FCD:
			this.CpyBtnCnvPerRACCodeType2_A8817 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4FDA:
			this.CVBtnCnvPerRxOptionsRxVoiceSignalType_A9044 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4FE7:
			this.LblCnvPerASTROCallRemotemonitorfrequencyoption = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallRemotemonitorfrequencyoption.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_500B:
			this.CpyBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5018:
			this.CnvPerTacticalInhibitKillOperation_A41553Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5025:
			this.CnvPerSignalingEmergencyPTTID_A7944 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSignalingEmergencyPTTID_A7944.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5049:
			this.CnvPerRxOptionsRxVoiceSignalType_A9044 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRxOptionsRxVoiceSignalType_A9044.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_506D:
			this.CnvPerLabtoolAnalogHotListItemID_A21918 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerLabtoolAnalogHotListItemID_A21918.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5091:
			this.CnvPerGeneralTalkgroupTextList_A19822 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerGeneralTalkgroupTextList_A19822.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_50B5:
			this.CnvPerSecureDESXLTxDefault_A7831Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_50C2:
			this.CpyBtnCnvPerRACMDCRepeaterID2_A8814 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_50CF:
			num = (short)1489567745;
			if (num != 0)
			{
			}
			this.HLinkASTROTalkgroup = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROTalkgroup.Click += this.HLinkClick;
			return;
			IL_511A:
			this.CVBtnCnvPerOneTouchButton_A19765 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5127:
			this.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_514B:
			this.CnvPerAdvancedDisableHighPassFilter_A7864 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerAdvancedDisableHighPassFilter_A7864.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_516F:
			this.CpyBtnCnvPerFeaturesOTARadioAliasType_42784 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_517C:
			this.CpyBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5189:
			this.RTDBtnCnvPerRxOptionsBusyLED_A7570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5196:
			this.LblCnvPerSecureKeySelection1_A8368 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureKeySelection1_A8368.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51BA:
			this.CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_51C7:
			this.CpyBtnCnvPerSignalingSignalingType_A9129 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51D4:
			this.CnvPerLabtoolSyncMode_A19308 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerLabtoolSyncMode_A19308.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_51F8:
			this.GrpBoxExpanderConventionalPersonalityRACRepeaterAccessButton1PTT = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5205:
			this.LblCnvPerAGAGKeySel_A40159 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAGAGKeySel_A40159.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5229:
			this.CVBtnCnvPerConventionalChannelOptionsRxFrequency_A8911 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5236:
			this.RTDBtnCnvPerRxOptionsUnmuteMuteType_A9602 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5243:
			this.CpyBtnCnvPerRxOptionsUnmuteMuteType_A9602 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5250:
			this.CnvPerConventionalChannelOptionsRxPLFreq_A8918 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsRxPLFreq_A8918.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5274:
			this.CnvPerOneTouchButton_A19765 = (global::AcpUI.AcpLabel)target;
			this.CnvPerOneTouchButton_A19765.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5298:
			this.CVBtnCnvPerSignalingRevertTGKeySel_A40154 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_52A5:
			this.LblCnvPerSecureKeyID_A8361 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureKeyID_A8361.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_52C9:
			this.CnvPerTxOptionsTransmitPowerLevel_A9420 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerTxOptionsTransmitPowerLevel_A9420.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_52ED:
			this.LblCnvPerSecureOTARTx_A8675 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureOTARTx_A8675.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5311:
			this.CnvPerRxOptionsRxUnmuteDelayms_A9033 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRxOptionsRxUnmuteDelayms_A9033.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5335:
			this.CnvPerConventionalChannelOptionsRxFrequency_A8911_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5342:
			this.CnvPerEndTxOnVoiceAbsence_42460Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_534F:
			this.CVBtnCnvPerAGAGSecStrap_A40158 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_535C:
			this.RTDBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5369:
			this.CVBtnCnvPerRACToneSignalingSystem_A9392 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5376:
			this.CnvPerSecureProperCodeDetect_A8762 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureProperCodeDetect_A8762.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_539A:
			this.CpyBtnCnvPerSignalingEmergencyPTTID_A7944 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53A7:
			this.CpyBtnCnvPerRxOptionsSquelchFineTune_A9176 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53B4:
			this.CpyBtnCnvPerSecureScanSelect_A9056 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53C1:
			this.CnvPerAdvancedAnalogFlatAudio_A7443Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_53CE:
			this.CVBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_53DB:
			this.RTDBtnCnvPerSecureSecureClearStrapping1_A9090 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_53E8:
			this.CVBtnCnvPerConventionalChannelOptionsRxPLCode_A8917 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_53F5:
			this.RTDBtnCnvPerLabtoolQuickKeyOverride_A8808 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5402:
			this.CnvPerSecureKeySelection2_A8369Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_540F:
			this.CnvPerConventionalChannelOptionsTADPLInvert_A9259Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_541C:
			this.CpyBtnCnvPerSecureKeyStrapping_A8370 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5429:
			this.RTDBtnCnvPerConventionalChannelOptionsTANetworkID_A7863 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5436:
			this.RTDBtnCnvPerSignalingSignalingType_A9129 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5443:
			this.CpyBtnCnvPerLabtoolSmartPTTType_A9164 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5450:
			this.CVBtnCnvPerPhonePhoneOperation_A8703 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_545D:
			this.LblCnvPerRACSingletone_A43073 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRACSingletone_A43073.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5481:
			this.CnvPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpComboBox)target;
			this.CnvPerFeaturesAstroAlertingToneTable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_54A5:
			this.CVBtnCnvPerTxOptionsAdaptivePower_A7405 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_54B2:
			this.CnvPerASTROCallAutoSelectiveCallTransmit_A7518 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerASTROCallAutoSelectiveCallTransmit_A7518.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_54D6:
			this.GrpBoxExpanderConventionalPersonalityASTROCallSelectiveCall = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_54E3:
			this.CVBtnCnvPerConventionalChannelOptionsTAPLCode_A9261 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_54F0:
			this.CpyBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_54FD:
			this.CnvPerLabtoolHotKeypad_A8208 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerLabtoolHotKeypad_A8208.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5521:
			this.CVBtnCnvPerRACRepeaterAccess_A8939 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_552E:
			this.RTDBtnCnvPerSecureBroadbandASTROOTAR = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_553B:
			this.CVBtnCnvPerASTROCallCallAlertRxTx_A7586 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5548:
			this.CnvPerTxOptionsTimeOutTimersec_A9378 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerTxOptionsTimeOutTimersec_A9378.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_556C:
			this.GrpBoxExpanderConventionalPersonalityFeaturesPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5579:
			this.CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5586:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5593:
			this.CVBtnCnvPerSignalingASTRORxUnmuteRule_A9042 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55A0:
			this.CnvPerConventionalChannelOptionsRxDPLCode_A8908 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsRxDPLCode_A8908.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_55C4:
			this.CnvPerAGAGTalkgroupID_A40157Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_55D1:
			this.CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_55DE:
			this.LblCnvPerSecureSecureVoiceSignalType_A9086 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureSecureVoiceSignalType_A9086.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5602:
			this.LblCnvPerConventionalChannelOptionsTxSquelchType_A9426 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxSquelchType_A9426.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5626:
			this.CVBtnCnvPerGeneralTalkgroupTextList_A19822 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5633:
			this.CnvPerRACCodeType2_A8817 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACCodeType2_A8817.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5657:
			this.CpyBtnCnvPerSecureSecureClearStrapping2_A9091 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5664:
			this.LblCnvPerConventionalChannelOptionsPLDeviation_A8708 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsPLDeviation_A8708.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5688:
			this.CnvPerFeaturesOTARadioAliasType_42784 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerFeaturesOTARadioAliasType_42784.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_56AC:
			this.CVBtnCnvPerConventionalChannelOptionsPLDeviation_A8708 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_56B9:
			this.CpyBtnCnvPerSignalingRevertChannel_A13267 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_56C6:
			this.CpyBtnCnvPerNonASTROCallRTTButtonAccess_A8493 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_56D3:
			this.GrpBoxExpanderConventionalPersonalityASTROCallCallAlert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_56E0:
			this.CnvPerFeatureRFModem_42485 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerFeatureRFModem_42485.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5704:
			this.CpyBtnCnvPerTPSTPSUIEnable_A9400 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5711:
			this.CnvPerConventionalChannelOptionsTxPLCode_A9418_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_571E:
			this.CnvPerConventionalChannelOptionsTxNetworkID_A9550Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_572B:
			this.LblCnvPerAGAGSecStrap_A40158 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerAGAGSecStrap_A40158.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_574F:
			this.LblCnvPerConventionalChannelOptionsRxDPLInvert_A8909 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxDPLInvert_A8909.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5773:
			this.RTDBtnCnvPerConventionalChannelOptionsTalkaround_A19837 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5780:
			this.CnvPerFeatureDTMFMicEn_A42481 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeatureDTMFMicEn_A42481.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_57A4:
			this.RTDBtnCnvPerTxOptionsTxVoiceSignalType_A9574 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_57B1:
			this.CnvPerASTROCallRemoteMonitorTxRxTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvPerASTROCallRemoteMonitorTxRxTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_57D5:
			this.CVBtnCnvPerASTROCallASTROUnlimitedCalling_A7501 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57E2:
			this.CnvPerSignalingRevertType_A8953Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_57EF:
			this.CVBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57FC:
			this.CVBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5809:
			this.HLinkPhone = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPhone.Click += this.HLinkClick;
			return;
			IL_582D:
			this.CnvPerFeaturesFiregroundRegistration_A33242Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_583A:
			this.CnvPerNonASTROCallRTTButtonAccess_A8493Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5847:
			this.CVBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5854:
			this.LblCnvPerASTROTalkgroupOptionsSelectionType_A9112 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROTalkgroupOptionsSelectionType_A9112.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5878:
			this.RTDBtnCnvPerAdvancedDisableHighPassFilter_A7864 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5885:
			this.LblCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58A9:
			this.LblCnvPerFeaturesTxVoiceType_A9573 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesTxVoiceType_A9573.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58CD:
			this.CVBtnCnvPerSignalingPTTID_A8770 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_58DA:
			this.LblCnvPerSecureBroadbandASTROOTAR = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureBroadbandASTROOTAR.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58FE:
			this.CVBtnCnvPerASTROCallSelectiveCallRxTx_A9114 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_590B:
			this.RTDBtnCnvPerRACToneSignalingSystem_A9392 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5918:
			this.GrpBoxExpanderConventionalPersonalityFeaturesPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5925:
			this.CVBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5932:
			this.CnvPerConventionalChannelOptionsTxFrequency_A9414 = (global::AcpUI.AcpTextBox)target;
			this.CnvPerConventionalChannelOptionsTxFrequency_A9414.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5956:
			this.RTDBtnCnvPerFeaturesMixedVoteScanEnable_A38723 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5963:
			this.CpyBtnCnvPerLabtoolSyncMode_A19308 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5970:
			this.LblCnvPerSignalingRevertTGSYSID_A40151 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertTGSYSID_A40151.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5994:
			this.CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_59A1:
			this.CnvPerRxOptionsRxDeEmphasis_A9010 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerRxOptionsRxDeEmphasis_A9010.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59C5:
			this.CnvPerConventionalChannelOptionsTalkaround_A19837_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_59D2:
			this.GrpBoxExpanderConventionalPersonalityFeaturesPseudo4 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_59DF:
			this.RTDBtnCnvPerSecureScanHoldoffStrapping_A9050 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_59EC:
			this.CVBtnCnvPerNonASTROCallRTTButtonAccess_A8493 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_59F9:
			this.CVBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A06:
			this.LblConPerMDCRunMDCDemodulator_A8494 = (global::AcpUI.AcpLabel)target;
			this.LblConPerMDCRunMDCDemodulator_A8494.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A2A:
			this.HLinkASTROCall = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROCall.Click += this.HLinkClick;
			return;
			IL_5A4E:
			this.CnvPerASTROCallASTROUnlimitedCalling_A7501Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5A5B:
			this.CVBtnCnvPerSignalingEmergencyPTTID_A7944 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A68:
			this.CpyBtnCnvPerSignalingRevertTGWACNID_A40150 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5A75:
			this.CnvPerConventionalChannelOptionsTxPLCode_A9418 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTxPLCode_A9418.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A99:
			this.CpyBtnCnvPerSecureOTARTx_A8675 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5AA6:
			this.CnvPerFeaturesMixedVoteScanTxSteering_A38878Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5AB3:
			this.CpyBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5AC0:
			this.LblCnvPerSecureDESXLTxDefault_A7831 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureDESXLTxDefault_A7831.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5AE4:
			this.RTDBtnCnvPerLabtoolAnalogHotListItemID_A21918 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5AF1:
			this.CnvPerConventionalChannelOptionsRxDPLInvert_A8909Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5AFE:
			this.CnvPerASTROCallTacticalServicesOperation = (global::AcpUI.AcpComboBox)target;
			this.CnvPerASTROCallTacticalServicesOperation.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B22:
			this.CnvPerTPSTPSUIEnable_A9400 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerTPSTPSUIEnable_A9400.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B46:
			this.CnvPerNonASTROCallAutoSelectCallTransmit_A7520Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5B53:
			this.CnvPerSecureScanHoldoffStrapping_A9050Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5B60:
			this.CVBtnCnvPerSecureKeyID_A8361 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B6D:
			this.CnvPerSignalingRevertTGWACNID_A40150 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvPerSignalingRevertTGWACNID_A40150.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B91:
			this.CVBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B9E:
			this.CnvPerFeaturesTacticalRekeyEnable_A19309 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesTacticalRekeyEnable_A19309.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5BC2:
			this.RTDBtnCnvPerPhoneAutoAccessCodeSelect_A7503 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BCF:
			this.LblCnvPerNonASTROCallInCallUserAlertEnable_A8252 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallInCallUserAlertEnable_A8252.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BF3:
			this.CVBtnCnvPerRxOptionsRxUnmuteDelayms_A9033 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C00:
			this.LblCnvPerNonASTROCallSelectiveCallRxTx_A9116 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallSelectiveCallRxTx_A9116.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C24:
			this.CVBtnCnvPerSignalingSignalingType_A9129 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C31:
			this.CVBtnCnvPerTacticalInhibitKillOperation_A41553 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C3E:
			this.LblCnvPerTxOptionsReverseBurstTurnOffCode_A8952 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsReverseBurstTurnOffCode_A8952.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C62:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5C6F:
			this.CpyBtnCnvPerConventionalChannelOptionsRxFrequency_A8911 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C7C:
			this.RTDBtnCnvPerSecureKeySelection2_A8369 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C89:
			this.CpyBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C96:
			this.CpyBtnCnvPerOneTouchFeature_A19662 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5CA3:
			this.CVBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5CB0:
			this.LblCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5CD4:
			this.CpyBtnCnvPerRACAccessType_A7388 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5CE1:
			this.CVBtnCnvPerSecureXLDelayFollowingKeyID_A9680 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5CEE:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_5D12:
			this.CVBtnCnvPerSignalingRevertTGSYSID_A40151 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D1F:
			this.RTDBtnCnvPerSecureScanSelect_A9056 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D2C:
			this.CVBtnCnvPerASTROCallASTROCallHotList_A7488 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D39:
			this.RTDBtnCnvPerRACAccessType_A7388 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D46:
			this.CnvPerSecureSecureClearStrapping1_A9090 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureSecureClearStrapping1_A9090.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D6A:
			this.CnvPerTxOptionsTransmitPowerLevel_A9420Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5D77:
			this.CnvPerSignalingEmergencyPTTID_A7944Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5D84:
			this.CVBtnCnvPerRACCodeType2_A8817 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D91:
			this.CVBtnCnvPerSignalingRevertTG_A40152 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D9E:
			this.LblCnvPerSignalingRevertTGWACNID_A40150 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSignalingRevertTGWACNID_A40150.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5DC2:
			this.CpyBtnCnvPerRACSingletone_A43072 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5DCF:
			this.CnvPerRACMDCRepeaterID1_A8783Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5DDC:
			this.CpyBtnCnvPerTxOptionsTransmitPreEmphasis_A9411 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5DE9:
			this.LblCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E0D:
			this.CpyBtnCnvPerSignalingDigitalModulatorType_A7857 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5E3E:
			this.CnvPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerFeaturesHazardZoneModePersonality.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5E62:
			this.LblCnvPerFeatureRFModem_42485 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeatureRFModem_42485.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E86:
			this.CpyBtnCnvPerAGAGWACNID_A40155 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5E93:
			this.CnvPerSecureScanSelect_A9056 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureScanSelect_A9056.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5EB7:
			this.LblCnvPerRxOptionsReceiveOnlyPersonality_A8916 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsReceiveOnlyPersonality_A8916.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5EDB:
			this.CnvPerLabtoolSyncMode_A19308Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5EE8:
			this.CVBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EF5:
			this.CVBtnCnvPerTxOptionsTalkPermitTone = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5F02:
			this.CnvPerLabtoolScanListSelection_A9054 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerLabtoolScanListSelection_A9054.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5F26:
			this.GrpBoxExpanderConventionalPersonalityNonASTROCallCallAlert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5F33:
			this.CnvPerLabtoolScanListSelection_A9054Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F40:
			this.CpyBtnCnvPerASTROCallTacticalServicesOperation = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5F4D:
			this.LblCnvPerLabtoolHotKeypad_A8208 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolHotKeypad_A8208.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F71:
			this.CVBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5F7E:
			this.LblCnvPerConventionalChannelOptionsTalkaround_A19837 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTalkaround_A19837.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5FA2:
			this.LblCnvPerTxOptionsTimeOutTimersec_A9378 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerTxOptionsTimeOutTimersec_A9378.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5FC6:
			this.LblCnvPerASTROCallInCallUserAlertEnable_A8250 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallInCallUserAlertEnable_A8250.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5FEA:
			this.RTDBtnCnvPerSecureProperCodeDetect_A8762 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5FF7:
			this.CnvPerNonASTROCallUnmuteType_A9601 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerNonASTROCallUnmuteType_A9601.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_601B:
			this.CnvPerAGAGWACNID_A40155 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvPerAGAGWACNID_A40155.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_603F:
			this.CnvPerRACSingletone_A43072 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRACSingletone_A43072.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6063:
			this.ExpanderConventionalPersonalityRxOptions = (global::AcpUI.AcpExpander)target;
			return;
			IL_6070:
			this.CnvPerSecureKMFProfileIndex_A8381 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureKMFProfileIndex_A8381.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6094:
			this.CnvPerSignalingLateEntryFastUnmute_A8423 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSignalingLateEntryFastUnmute_A8423.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_60B8:
			this.CnvPerFeaturesTacticalRekeyEnable_A19309Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_60C5:
			this.CnvPerFeaturesHazardZoneModePersonalityComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_60D2:
			this.CVBtnCnvPerSecureKMFProfileIndex_A8381 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_60DF:
			this.CnvPerConventionalChannelOptionsRxNetworkID_A9023_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_60EC:
			this.CpyBtnCnvPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_60F9:
			this.CnvPerNonASTROCallInCallUserAlertEnable_A8252 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerNonASTROCallInCallUserAlertEnable_A8252.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_611D:
			this.GrpBoxExpanderConventionalPersonalityRxOptionsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_612A:
			this.LblCnvPerASTROCallASTROCallHotList_A7488 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallASTROCallHotList_A7488.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_614E:
			this.CVBtnCnvPerIgnoreRxClearVoice_A41617 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_615B:
			this.CpyBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6168:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6175:
			this.CnvPerAGAGSysID_A40156 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvPerAGAGSysID_A40156.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6199:
			this.CpyBtnCnvPerTxOptionsTalkPermitTone = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61A6:
			this.HLinkDVRS = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDVRS.Click += this.HLinkClick;
			return;
			IL_61CA:
			this.CpyBtnCnvPerAdvancedAnalogFlatAudio_A7443 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61D7:
			this.GrpBoxExpanderConventionalPersonalitySignalingRevertTalkgroup = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_61E4:
			this.CpyBtnCnvPerTxOptionsTimeOutTimersec_A9378 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61F1:
			this.CpyBtnCnvPerSignalingRevertTG_A40152 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61FE:
			this.LblCnvPerSecureSecureClearStrapping1_A9090 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerSecureSecureClearStrapping1_A9090.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6222:
			this.CVBtnCnvPerConventionalChannelOptionsTADPLCode_A9256 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_622F:
			this.CnvPerSignalingRevertType_A8953 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSignalingRevertType_A8953.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6253:
			this.CVBtnCnvPerFeaturesFiregroundRegistration_A33242 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6260:
			this.CnvPerAdvancedSecondLOSideInjection_A9063 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerAdvancedSecondLOSideInjection_A9063.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6284:
			this.CnvPerTxOptionsTxVoiceSignalType_A9574Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6291:
			this.HLinkAdvanced = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvanced.Click += this.HLinkClick;
			return;
			IL_62B5:
			this.CnvPerNonASTROCallRTTButtonAccess_A8493 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerNonASTROCallRTTButtonAccess_A8493.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_62D9:
			this.LblCnvPerFeaturesDVRSProf_A41794 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesDVRSProf_A41794.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_62FD:
			this.CpyBtnCnvPerConventionalChannelOptionsTANetworkID_A7863 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_630A:
			this.LblCnvPerEndTxOnVoiceAbsence_42460 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerEndTxOnVoiceAbsence_42460.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_632E:
			this.CnvPerSecureXLTransmit_A9683Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_633B:
			this.CVBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6348:
			this.CnvPerFeaturesMixedVoteScanEnable_A38723Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6355:
			this.CpyBtnCnvPerFeaturesFiregroundRegistration_A33242 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6362:
			this.LblCnvPerRxOptionsHearClear_A36408 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerRxOptionsHearClear_A36408.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6386:
			this.CVBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6393:
			this.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63A0:
			this.HLinkOneTouch = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkOneTouch.Click += this.HLinkClick;
			return;
			IL_63C4:
			this.CVBtnCnvPerASTROCallRemotemonitorfrequencyoption = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_63D1:
			this.CnvPerRACSingletone_A43072Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63DE:
			this.CnvPerConventionalChannelOptionsRxFrequency_A8911Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63EB:
			this.CpyBtnCnvPerSignalingRevertTGKeySel_A40154 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_63F8:
			this.CVBtnCnvPerTxOptionsTimeOutTimersec_A9378 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6405:
			this.CpyBtnCnvPerLabtoolHotKeypad_A8208 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6412:
			this.CVBtnCnvPerLabtoolAnalogHotListItemID_A21918 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_641F:
			this.ExpanderConventionalPersonalityFrequencyOptionsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_642C:
			this.CnvPerSecureDESXLTxDefault_A7831 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureDESXLTxDefault_A7831.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6450:
			this.RTDBtnCnvPerAdvancedAnalogFlatAudio_A7443 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_645D:
			this.LblCnvPerASTROCallCallAlertRxTx_A7586 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallCallAlertRxTx_A7586.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6481:
			this.CVBtnCnvPerSecureBroadbandASTROOTAR = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_648E:
			this.CnvPerRxOptionsHearClear_A36408 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerRxOptionsHearClear_A36408.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_64B2:
			this.CnvPerConventionalChannelOptionsTADPLCode_A9256Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_64BF:
			this.LblCnvPerConventionalChannelOptionsRxNetworkID_A9023 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxNetworkID_A9023.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_64E3:
			this.CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_64F0:
			this.LblCnvPerASTROCallTacticalServicesOperation = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallTacticalServicesOperation.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6514:
			this.CVBtnCnvPerAdvancedDisableHighPassFilter_A7864 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6521:
			this.RTDBtnCnvPerSecureKeySelection1_A8368 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_652E:
			this.LblCnvPerPhoneAutoAccessCodeSelect_A7503 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerPhoneAutoAccessCodeSelect_A7503.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6552:
			this.CnvPerFeaturesTxVoiceType_A9573Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_655F:
			this.CpyBtnCnvPerTxOptionsAdaptivePower_A7405 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_656C:
			this.CnvPerSecureBroadbandASTROOTAR = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureBroadbandASTROOTAR.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6590:
			this.CnvPerAGAGTalkgroupID_A40157 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvPerAGAGTalkgroupID_A40157.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65B4:
			this.CnvPerFeaturesOTARadioAliasType_42784Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_65C1:
			this.CnvPerSecureSecureVoiceSignalType_A9086 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerSecureSecureVoiceSignalType_A9086.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65E5:
			this.HLinkTxOptions = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTxOptions.Click += this.HLinkClick;
			return;
			IL_6609:
			this.LblCnvPerConventionalChannelOptionsRxFrequency_A8911 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsRxFrequency_A8911.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_662D:
			this.CVBtnCnvPerSignalingRevertTGWACNID_A40150 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_663A:
			this.CVBtnCnvPerRACCodeType1_A7680 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6647:
			this.CpyBtnCnvPerRxOptionsRxVoiceSignalType_A9044 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6654:
			this.LblCnvPerFeaturesMixedVoteScanTxSteering_A38878 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesMixedVoteScanTxSteering_A38878.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6678:
			this.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6685:
			this.CnvPerSignalingLateEntryFastUnmute_A8423Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6692:
			this.CnvPerNonASTROCallSelectiveCallRxTx_A9116 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerNonASTROCallSelectiveCallRxTx_A9116.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_66B6:
			this.CVBtnCnvPerFeaturesTacticalRekeyEnable_A19309 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_66C3:
			this.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_66D0:
			this.CpyBtnCnvPerSecureSecureVoiceSignalType_A9086 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_66DD:
			this.CpyBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_66EA:
			this.CVBtnCnvPerFeaturesDVRSProf_A41794 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_66F7:
			this.RTDBtnCnvPerSignalingEmergencyPTTID_A7944 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6704:
			this.HLinkNonASTROCall = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkNonASTROCall.Click += this.HLinkClick;
			return;
			IL_6728:
			this.RTDBtnCnvPerConventionalChannelOptionsTxFrequency_A9414 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6735:
			this.LblCnvPerNonASTROCallRTTButtonAccess_A8493 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerNonASTROCallRTTButtonAccess_A8493.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6759:
			this.CpyBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6766:
			this.CnvPerConventionalChannelOptionsTASquelchType_A9265Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6773:
			this.CnvPerASTROCallTacticalServicesOperationComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6780:
			this.CpyBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_678D:
			this.CnvPerLabtoolQuickKeyOverride_A8808 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerLabtoolQuickKeyOverride_A8808.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_67B1:
			this.CnvPerNonASTROCallUnlimitedCalling_A9597Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_67BE:
			this.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_67E2:
			this.CnvPerConventionalChannelOptionsTADPLCode_A9256_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_67EF:
			this.CVBtnCnvPerConventionalChannelOptionsTASquelchType_A9265 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_67FC:
			this.CVBtnCnvPerSignalingRevertZone_A13269 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6809:
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_682D:
			this.CVBtnCnvPerNonASTROCallUnmuteType_A9601 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_683A:
			this.CVBtnCnvPerFeaturesRSSIDisplayTimer_42786 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6847:
			this.LblCnvPerLabtoolQuickKeyOverride_A8808 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolQuickKeyOverride_A8808.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_686B:
			this.CnvPerRACCodeType1_A7680Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6878:
			this.CnvPerConventionalChannelOptionsTADPLInvert_A9259_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6885:
			this.LblCnvPerLabtoolOTACROTACSMessaging_A8663 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerLabtoolOTACROTACSMessaging_A8663.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_68A9:
			this.RTDBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_68B6:
			this.LblCnvPerFeaturesRSSIDisplayTimer_42786 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerFeaturesRSSIDisplayTimer_42786.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_68DA:
			this.gridExpanderConventionalPersonalityFrequencyOptionsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_68E7:
			this.CnvPerSecureOTARTx_A8675 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerSecureOTARTx_A8675.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_690B:
			this.ExpanderConventionalPersonalityOneTouchTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6918:
			this.CVBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6925:
			this.CnvPerRACMDCRepeaterID2_A8814Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6932:
			this.CpyBtnCnvPerOneTouchIndex_A19663 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_693F:
			this.CnvPerSignalingRevertZone_A13269Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_694C:
			this.CnvPerSignalingRevertTGWACNID_A40150Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_6959:
			this.CnvPerASTROCallCallAlertRxTx_A7586Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6966:
			this.LblCnvPerASTROCallRadioUninhibitDecodeAction_A9045 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerASTROCallRadioUninhibitDecodeAction_A9045.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_698A:
			this.CVBtnConPerMDCRunMDCDemodulator_A8494 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6997:
			this.LblCnvPerConventionalChannelOptionsTxDPLInvert_A9410 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerConventionalChannelOptionsTxDPLInvert_A9410.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_69BB:
			this.CnvPerAGAGKeySel_A40159 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerAGAGKeySel_A40159.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_69DF:
			this.CnvPerSecureScanSelect_A9056Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_69EC:
			this.CpyBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_69F9:
			this.CnvPerConventionalChannelOptionsTADPLCode_A9256 = (global::AcpUI.AcpComboBox)target;
			this.CnvPerConventionalChannelOptionsTADPLCode_A9256.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A1D:
			this.RTDBtnCnvPerTxOptionsTransmitPreEmphasis_A9411 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6A2A:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_6A4E:
			this.b = true;
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x00B5D9AC File Offset: 0x00B5BBAC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
			{
				short num = (short)1102592262;
				short num2 = num;
				num = (short)599406854;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)770768896;
					short num3 = num;
					num = (short)1126563841;
					if (num != 0)
					{
					}
					num = (short)712572928;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				break;
			case 21:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04005C54 RID: 23636
		private bool a;

		// Token: 0x04005C55 RID: 23637
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageConventionalPersonality;

		// Token: 0x04005C56 RID: 23638
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04005C57 RID: 23639
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04005C58 RID: 23640
		internal global::System.Windows.Documents.Hyperlink HLinkRxOptions;

		// Token: 0x04005C59 RID: 23641
		internal global::System.Windows.Documents.Hyperlink HLinkTxOptions;

		// Token: 0x04005C5A RID: 23642
		internal global::System.Windows.Documents.Hyperlink HLinkFrequencyOptions;

		// Token: 0x04005C5B RID: 23643
		internal global::System.Windows.Documents.Hyperlink HLinkSignaling;

		// Token: 0x04005C5C RID: 23644
		internal global::System.Windows.Documents.Hyperlink HLinkDVRS;

		// Token: 0x04005C5D RID: 23645
		internal global::System.Windows.Documents.Hyperlink HLinkNonASTROCall;

		// Token: 0x04005C5E RID: 23646
		internal global::System.Windows.Documents.Hyperlink HLinkASTROCall;

		// Token: 0x04005C5F RID: 23647
		internal global::System.Windows.Documents.Hyperlink HLinkASTROTalkgroup;

		// Token: 0x04005C60 RID: 23648
		internal global::System.Windows.Documents.Hyperlink HLinkRAC;

		// Token: 0x04005C61 RID: 23649
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x04005C62 RID: 23650
		internal global::System.Windows.Documents.Hyperlink HLinkPhone;

		// Token: 0x04005C63 RID: 23651
		internal global::System.Windows.Documents.Hyperlink HLinkOneTouch;

		// Token: 0x04005C64 RID: 23652
		internal global::System.Windows.Documents.Hyperlink HLinkSecure;

		// Token: 0x04005C65 RID: 23653
		internal global::System.Windows.Documents.Hyperlink HLinkAdvanced;

		// Token: 0x04005C66 RID: 23654
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04005C67 RID: 23655
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04005C68 RID: 23656
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityGeneral;

		// Token: 0x04005C69 RID: 23657
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityGeneralPseudo0;

		// Token: 0x04005C6A RID: 23658
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerGeneralConventionalPersonalityName_A12660;

		// Token: 0x04005C6B RID: 23659
		internal global::AcpUI.AcpLabel LblCnvPerGeneralConventionalPersonalityName_A12660;

		// Token: 0x04005C6C RID: 23660
		internal global::AcpUI.AcpTextBox CnvPerGeneralConventionalPersonalityName_A12660;

		// Token: 0x04005C6D RID: 23661
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerGeneralConventionalPersonalityName_A12660;

		// Token: 0x04005C6E RID: 23662
		internal global::AcpUI.AcpLabel CnvPerGeneralConventionalPersonalityName_A12660Comp;

		// Token: 0x04005C6F RID: 23663
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesDVRSProf_A41794;

		// Token: 0x04005C70 RID: 23664
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesDVRSProf_A41794;

		// Token: 0x04005C71 RID: 23665
		internal global::AcpUI.AcpComboBox CnvPerFeaturesDVRSProf_A41794;

		// Token: 0x04005C72 RID: 23666
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesDVRSProf_A41794;

		// Token: 0x04005C73 RID: 23667
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesDVRSProf_A41794;

		// Token: 0x04005C74 RID: 23668
		internal global::AcpUI.AcpLabel CnvPerFeaturesDVRSProf_A41794Comp;

		// Token: 0x04005C75 RID: 23669
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x04005C76 RID: 23670
		internal global::AcpUI.AcpLabel LblCnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x04005C77 RID: 23671
		internal global::AcpUI.AcpComboBox CnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x04005C78 RID: 23672
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x04005C79 RID: 23673
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x04005C7A RID: 23674
		internal global::AcpUI.AcpLabel CnvPerGeneralTalkgroupTextList_A19822Comp;

		// Token: 0x04005C7B RID: 23675
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityRxOptions;

		// Token: 0x04005C7C RID: 23676
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityRxOptionsPseudo0;

		// Token: 0x04005C7D RID: 23677
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x04005C7E RID: 23678
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x04005C7F RID: 23679
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x04005C80 RID: 23680
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x04005C81 RID: 23681
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x04005C82 RID: 23682
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsReceiveOnlyPersonality_A8916Comp;

		// Token: 0x04005C83 RID: 23683
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x04005C84 RID: 23684
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x04005C85 RID: 23685
		internal global::AcpUI.AcpComboBox CnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x04005C86 RID: 23686
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x04005C87 RID: 23687
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x04005C88 RID: 23688
		internal global::AcpUI.AcpLabel CnvPerRxOptionsRxVoiceSignalType_A9044Comp;

		// Token: 0x04005C89 RID: 23689
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x04005C8A RID: 23690
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x04005C8B RID: 23691
		internal global::AcpUI.AcpComboBox CnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x04005C8C RID: 23692
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x04005C8D RID: 23693
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x04005C8E RID: 23694
		internal global::AcpUI.AcpLabel CnvPerRxOptionsUnmuteMuteType_A9602Comp;

		// Token: 0x04005C8F RID: 23695
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x04005C90 RID: 23696
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x04005C91 RID: 23697
		internal global::AcpUI.AcpComboBox CnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x04005C92 RID: 23698
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x04005C93 RID: 23699
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x04005C94 RID: 23700
		internal global::AcpUI.AcpLabel CnvPerRxOptionsRxUnmuteDelayms_A9033Comp;

		// Token: 0x04005C95 RID: 23701
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x04005C96 RID: 23702
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x04005C97 RID: 23703
		internal global::AcpUI.AcpComboBox CnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x04005C98 RID: 23704
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x04005C99 RID: 23705
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x04005C9A RID: 23706
		internal global::AcpUI.AcpLabel CnvPerRxOptionsSquelchFineTune_A9176Comp;

		// Token: 0x04005C9B RID: 23707
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsBusyLED_A7570;

		// Token: 0x04005C9C RID: 23708
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsBusyLED_A7570;

		// Token: 0x04005C9D RID: 23709
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsBusyLED_A7570;

		// Token: 0x04005C9E RID: 23710
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsBusyLED_A7570;

		// Token: 0x04005C9F RID: 23711
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsBusyLED_A7570;

		// Token: 0x04005CA0 RID: 23712
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsBusyLED_A7570Comp;

		// Token: 0x04005CA1 RID: 23713
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x04005CA2 RID: 23714
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x04005CA3 RID: 23715
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x04005CA4 RID: 23716
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x04005CA5 RID: 23717
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x04005CA6 RID: 23718
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsRxDeEmphasis_A9010Comp;

		// Token: 0x04005CA7 RID: 23719
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsHearClear_A36408;

		// Token: 0x04005CA8 RID: 23720
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsHearClear_A36408;

		// Token: 0x04005CA9 RID: 23721
		internal global::AcpUI.AcpComboBox CnvPerRxOptionsHearClear_A36408;

		// Token: 0x04005CAA RID: 23722
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsHearClear_A36408;

		// Token: 0x04005CAB RID: 23723
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsHearClear_A36408;

		// Token: 0x04005CAC RID: 23724
		internal global::AcpUI.AcpLabel CnvPerRxOptionsHearClear_A36408Comp;

		// Token: 0x04005CAD RID: 23725
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRxOptionsConcurrentRXEnable;

		// Token: 0x04005CAE RID: 23726
		internal global::AcpUI.AcpLabel LblCnvPerRxOptionsConcurrentRXEnable;

		// Token: 0x04005CAF RID: 23727
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsConcurrentRXEnable;

		// Token: 0x04005CB0 RID: 23728
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRxOptionsConcurrentRXEnable;

		// Token: 0x04005CB1 RID: 23729
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRxOptionsConcurrentRXEnable;

		// Token: 0x04005CB2 RID: 23730
		internal global::AcpUI.AcpCheckBox CnvPerRxOptionsConcurrentRXEnableComp;

		// Token: 0x04005CB3 RID: 23731
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityTxOptions;

		// Token: 0x04005CB4 RID: 23732
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityTxOptionsPseudo0;

		// Token: 0x04005CB5 RID: 23733
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04005CB6 RID: 23734
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04005CB7 RID: 23735
		internal global::AcpUI.AcpComboBox CnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04005CB8 RID: 23736
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04005CB9 RID: 23737
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04005CBA RID: 23738
		internal global::AcpUI.AcpLabel CnvPerTxOptionsTxVoiceSignalType_A9574Comp;

		// Token: 0x04005CBB RID: 23739
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04005CBC RID: 23740
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04005CBD RID: 23741
		internal global::AcpUI.AcpTextBoxSpinner CnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04005CBE RID: 23742
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04005CBF RID: 23743
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04005CC0 RID: 23744
		internal global::AcpUI.AcpLabel CnvPerTxOptionsTimeOutTimersec_A9378Comp;

		// Token: 0x04005CC1 RID: 23745
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04005CC2 RID: 23746
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04005CC3 RID: 23747
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04005CC4 RID: 23748
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04005CC5 RID: 23749
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04005CC6 RID: 23750
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsTransmitPreEmphasis_A9411Comp;

		// Token: 0x04005CC7 RID: 23751
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04005CC8 RID: 23752
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04005CC9 RID: 23753
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04005CCA RID: 23754
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04005CCB RID: 23755
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04005CCC RID: 23756
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsReverseBurstTurnOffCode_A8952Comp;

		// Token: 0x04005CCD RID: 23757
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04005CCE RID: 23758
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04005CCF RID: 23759
		internal global::AcpUI.AcpComboBox CnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04005CD0 RID: 23760
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04005CD1 RID: 23761
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04005CD2 RID: 23762
		internal global::AcpUI.AcpLabel CnvPerTxOptionsTransmitPowerLevel_A9420Comp;

		// Token: 0x04005CD3 RID: 23763
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04005CD4 RID: 23764
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04005CD5 RID: 23765
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04005CD6 RID: 23766
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04005CD7 RID: 23767
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04005CD8 RID: 23768
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsAdaptivePower_A7405Comp;

		// Token: 0x04005CD9 RID: 23769
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTxOptionsTalkPermitTone;

		// Token: 0x04005CDA RID: 23770
		internal global::AcpUI.AcpLabel LblCnvPerTxOptionsTalkPermitTone;

		// Token: 0x04005CDB RID: 23771
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsTalkPermitTone;

		// Token: 0x04005CDC RID: 23772
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTxOptionsTalkPermitTone;

		// Token: 0x04005CDD RID: 23773
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTxOptionsTalkPermitTone;

		// Token: 0x04005CDE RID: 23774
		internal global::AcpUI.AcpCheckBox CnvPerTxOptionsTalkPermitToneComp;

		// Token: 0x04005CDF RID: 23775
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityFrequencyOptions;

		// Token: 0x04005CE0 RID: 23776
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderConventionalPersonalityFrequencyOptionsTable;

		// Token: 0x04005CE1 RID: 23777
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFrequencyOptionsPseudo0;

		// Token: 0x04005CE2 RID: 23778
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;

		// Token: 0x04005CE3 RID: 23779
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;

		// Token: 0x04005CE4 RID: 23780
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;

		// Token: 0x04005CE5 RID: 23781
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;

		// Token: 0x04005CE6 RID: 23782
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;

		// Token: 0x04005CE7 RID: 23783
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257Comp;

		// Token: 0x04005CE8 RID: 23784
		internal global::System.Windows.Controls.Grid ExpanderConventionalPersonalityFrequencyOptionsGrid;

		// Token: 0x04005CE9 RID: 23785
		internal global::System.Windows.Controls.Grid ExpanderConventionalPersonalityFrequencyOptionsTableGrid;

		// Token: 0x04005CEA RID: 23786
		internal global::AcpUI.AcpGroupBox ExpanderConventionalPersonalityFrequencyOptionsTableTableView;

		// Token: 0x04005CEB RID: 23787
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalPersonalityFrequencyOptionsTable;

		// Token: 0x04005CEC RID: 23788
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Col;

		// Token: 0x04005CED RID: 23789
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxFrequency_A8911_Col;

		// Token: 0x04005CEE RID: 23790
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxFrequency_A9414_Col;

		// Token: 0x04005CEF RID: 23791
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Col;

		// Token: 0x04005CF0 RID: 23792
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Col;

		// Token: 0x04005CF1 RID: 23793
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTAFrequency_A9260_Col;

		// Token: 0x04005CF2 RID: 23794
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Col;

		// Token: 0x04005CF3 RID: 23795
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxNetworkID_A9023_Col;

		// Token: 0x04005CF4 RID: 23796
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxNetworkID_A9550_Col;

		// Token: 0x04005CF5 RID: 23797
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTANetworkID_A7863_Col;

		// Token: 0x04005CF6 RID: 23798
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Col;

		// Token: 0x04005CF7 RID: 23799
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Col;

		// Token: 0x04005CF8 RID: 23800
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Col;

		// Token: 0x04005CF9 RID: 23801
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxSquelchType_A8919_Col;

		// Token: 0x04005CFA RID: 23802
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxPLFreq_A8918_Col;

		// Token: 0x04005CFB RID: 23803
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxPLCode_A8917_Col;

		// Token: 0x04005CFC RID: 23804
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxDPLCode_A8908_Col;

		// Token: 0x04005CFD RID: 23805
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Col;

		// Token: 0x04005CFE RID: 23806
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxSquelchType_A9426_Col;

		// Token: 0x04005CFF RID: 23807
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxPLFreq_A9419_Col;

		// Token: 0x04005D00 RID: 23808
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxPLCode_A9418_Col;

		// Token: 0x04005D01 RID: 23809
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxDPLCode_A9409_Col;

		// Token: 0x04005D02 RID: 23810
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Col;

		// Token: 0x04005D03 RID: 23811
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTASquelchType_A9265_Col;

		// Token: 0x04005D04 RID: 23812
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTAPLFreq_A9264_Col;

		// Token: 0x04005D05 RID: 23813
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTAPLCode_A9261_Col;

		// Token: 0x04005D06 RID: 23814
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTADPLCode_A9256_Col;

		// Token: 0x04005D07 RID: 23815
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTADPLInvert_A9259_Col;

		// Token: 0x04005D08 RID: 23816
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsPLDeviation_A8708_Col;

		// Token: 0x04005D09 RID: 23817
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalChannelOptionsTalkaround_A19837_Col;

		// Token: 0x04005D0A RID: 23818
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Col;

		// Token: 0x04005D0B RID: 23819
		internal global::AcpUI.AcpGroupBox ExpanderConventionalPersonalityFrequencyOptionsTableSRecView;

		// Token: 0x04005D0C RID: 23820
		internal global::System.Windows.Controls.Grid gridExpanderConventionalPersonalityFrequencyOptionsTableSRecView;

		// Token: 0x04005D0D RID: 23821
		internal global::AcpUI.AcpTextBox CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;

		// Token: 0x04005D0E RID: 23822
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;

		// Token: 0x04005D0F RID: 23823
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;

		// Token: 0x04005D10 RID: 23824
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;

		// Token: 0x04005D11 RID: 23825
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745Comp;

		// Token: 0x04005D12 RID: 23826
		internal global::AcpUI.AcpTextBox CnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04005D13 RID: 23827
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04005D14 RID: 23828
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04005D15 RID: 23829
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04005D16 RID: 23830
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04005D17 RID: 23831
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsRxFrequency_A8911Comp;

		// Token: 0x04005D18 RID: 23832
		internal global::AcpUI.AcpTextBox CnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x04005D19 RID: 23833
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x04005D1A RID: 23834
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x04005D1B RID: 23835
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x04005D1C RID: 23836
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x04005D1D RID: 23837
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxFrequency_A9414Comp;

		// Token: 0x04005D1E RID: 23838
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04005D1F RID: 23839
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04005D20 RID: 23840
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04005D21 RID: 23841
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04005D22 RID: 23842
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04005D23 RID: 23843
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359Comp;

		// Token: 0x04005D24 RID: 23844
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x04005D25 RID: 23845
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x04005D26 RID: 23846
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x04005D27 RID: 23847
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x04005D28 RID: 23848
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x04005D29 RID: 23849
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsDirectTalkaround_A9255Comp;

		// Token: 0x04005D2A RID: 23850
		internal global::AcpUI.AcpTextBox CnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x04005D2B RID: 23851
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x04005D2C RID: 23852
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x04005D2D RID: 23853
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x04005D2E RID: 23854
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x04005D2F RID: 23855
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTAFrequency_A9260Comp;

		// Token: 0x04005D30 RID: 23856
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x04005D31 RID: 23857
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x04005D32 RID: 23858
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x04005D33 RID: 23859
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x04005D34 RID: 23860
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x04005D35 RID: 23861
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192Comp;

		// Token: 0x04005D36 RID: 23862
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04005D37 RID: 23863
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04005D38 RID: 23864
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04005D39 RID: 23865
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04005D3A RID: 23866
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04005D3B RID: 23867
		internal global::AcpUI.AcpTextBoxDecHex CnvPerConventionalChannelOptionsRxNetworkID_A9023Comp;

		// Token: 0x04005D3C RID: 23868
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x04005D3D RID: 23869
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x04005D3E RID: 23870
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x04005D3F RID: 23871
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x04005D40 RID: 23872
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x04005D41 RID: 23873
		internal global::AcpUI.AcpTextBoxDecHex CnvPerConventionalChannelOptionsTxNetworkID_A9550Comp;

		// Token: 0x04005D42 RID: 23874
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04005D43 RID: 23875
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04005D44 RID: 23876
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04005D45 RID: 23877
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04005D46 RID: 23878
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04005D47 RID: 23879
		internal global::AcpUI.AcpTextBoxDecHex CnvPerConventionalChannelOptionsTANetworkID_A7863Comp;

		// Token: 0x04005D48 RID: 23880
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x04005D49 RID: 23881
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x04005D4A RID: 23882
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x04005D4B RID: 23883
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x04005D4C RID: 23884
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x04005D4D RID: 23885
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281Comp;

		// Token: 0x04005D4E RID: 23886
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x04005D4F RID: 23887
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x04005D50 RID: 23888
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x04005D51 RID: 23889
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x04005D52 RID: 23890
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x04005D53 RID: 23891
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606Comp;

		// Token: 0x04005D54 RID: 23892
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;

		// Token: 0x04005D55 RID: 23893
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;

		// Token: 0x04005D56 RID: 23894
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;

		// Token: 0x04005D57 RID: 23895
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;

		// Token: 0x04005D58 RID: 23896
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;

		// Token: 0x04005D59 RID: 23897
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029Comp;

		// Token: 0x04005D5A RID: 23898
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04005D5B RID: 23899
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04005D5C RID: 23900
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04005D5D RID: 23901
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04005D5E RID: 23902
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04005D5F RID: 23903
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsRxSquelchType_A8919Comp;

		// Token: 0x04005D60 RID: 23904
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04005D61 RID: 23905
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04005D62 RID: 23906
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04005D63 RID: 23907
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04005D64 RID: 23908
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04005D65 RID: 23909
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsRxPLFreq_A8918Comp;

		// Token: 0x04005D66 RID: 23910
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04005D67 RID: 23911
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04005D68 RID: 23912
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04005D69 RID: 23913
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04005D6A RID: 23914
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04005D6B RID: 23915
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsRxPLCode_A8917Comp;

		// Token: 0x04005D6C RID: 23916
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04005D6D RID: 23917
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04005D6E RID: 23918
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04005D6F RID: 23919
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04005D70 RID: 23920
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04005D71 RID: 23921
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsRxDPLCode_A8908Comp;

		// Token: 0x04005D72 RID: 23922
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04005D73 RID: 23923
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04005D74 RID: 23924
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04005D75 RID: 23925
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04005D76 RID: 23926
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04005D77 RID: 23927
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsRxDPLInvert_A8909Comp;

		// Token: 0x04005D78 RID: 23928
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x04005D79 RID: 23929
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x04005D7A RID: 23930
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x04005D7B RID: 23931
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x04005D7C RID: 23932
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x04005D7D RID: 23933
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxSquelchType_A9426Comp;

		// Token: 0x04005D7E RID: 23934
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x04005D7F RID: 23935
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x04005D80 RID: 23936
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x04005D81 RID: 23937
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x04005D82 RID: 23938
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x04005D83 RID: 23939
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxPLFreq_A9419Comp;

		// Token: 0x04005D84 RID: 23940
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x04005D85 RID: 23941
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x04005D86 RID: 23942
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x04005D87 RID: 23943
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x04005D88 RID: 23944
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x04005D89 RID: 23945
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxPLCode_A9418Comp;

		// Token: 0x04005D8A RID: 23946
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x04005D8B RID: 23947
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x04005D8C RID: 23948
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x04005D8D RID: 23949
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x04005D8E RID: 23950
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x04005D8F RID: 23951
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTxDPLCode_A9409Comp;

		// Token: 0x04005D90 RID: 23952
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x04005D91 RID: 23953
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x04005D92 RID: 23954
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x04005D93 RID: 23955
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x04005D94 RID: 23956
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x04005D95 RID: 23957
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsTxDPLInvert_A9410Comp;

		// Token: 0x04005D96 RID: 23958
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x04005D97 RID: 23959
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x04005D98 RID: 23960
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x04005D99 RID: 23961
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x04005D9A RID: 23962
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x04005D9B RID: 23963
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTASquelchType_A9265Comp;

		// Token: 0x04005D9C RID: 23964
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x04005D9D RID: 23965
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x04005D9E RID: 23966
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x04005D9F RID: 23967
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x04005DA0 RID: 23968
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x04005DA1 RID: 23969
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTAPLFreq_A9264Comp;

		// Token: 0x04005DA2 RID: 23970
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x04005DA3 RID: 23971
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x04005DA4 RID: 23972
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x04005DA5 RID: 23973
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x04005DA6 RID: 23974
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x04005DA7 RID: 23975
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTAPLCode_A9261Comp;

		// Token: 0x04005DA8 RID: 23976
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x04005DA9 RID: 23977
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x04005DAA RID: 23978
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x04005DAB RID: 23979
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x04005DAC RID: 23980
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x04005DAD RID: 23981
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTADPLCode_A9256Comp;

		// Token: 0x04005DAE RID: 23982
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x04005DAF RID: 23983
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x04005DB0 RID: 23984
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x04005DB1 RID: 23985
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x04005DB2 RID: 23986
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x04005DB3 RID: 23987
		internal global::AcpUI.AcpCheckBox CnvPerConventionalChannelOptionsTADPLInvert_A9259Comp;

		// Token: 0x04005DB4 RID: 23988
		internal global::AcpUI.AcpComboBox CnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04005DB5 RID: 23989
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04005DB6 RID: 23990
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04005DB7 RID: 23991
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04005DB8 RID: 23992
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04005DB9 RID: 23993
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsPLDeviation_A8708Comp;

		// Token: 0x04005DBA RID: 23994
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x04005DBB RID: 23995
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x04005DBC RID: 23996
		internal global::AcpUI.AcpLabel LblCnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x04005DBD RID: 23997
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x04005DBE RID: 23998
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x04005DBF RID: 23999
		internal global::AcpUI.AcpLabel CnvPerConventionalChannelOptionsTalkaround_A19837Comp;

		// Token: 0x04005DC0 RID: 24000
		internal global::AcpUI.AcpCheckBox CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x04005DC1 RID: 24001
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x04005DC2 RID: 24002
		internal global::AcpUI.AcpLabel LblCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x04005DC3 RID: 24003
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x04005DC4 RID: 24004
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x04005DC5 RID: 24005
		internal global::AcpUI.AcpCheckBox CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726Comp;

		// Token: 0x04005DC6 RID: 24006
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalitySignaling;

		// Token: 0x04005DC7 RID: 24007
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySignalingASTRO;

		// Token: 0x04005DC8 RID: 24008
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingASTROSystem_A7498;

		// Token: 0x04005DC9 RID: 24009
		internal global::AcpUI.AcpLabel LblCnvPerSignalingASTROSystem_A7498;

		// Token: 0x04005DCA RID: 24010
		internal global::AcpUI.AcpComboBox CnvPerSignalingASTROSystem_A7498;

		// Token: 0x04005DCB RID: 24011
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingASTROSystem_A7498;

		// Token: 0x04005DCC RID: 24012
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingASTROSystem_A7498;

		// Token: 0x04005DCD RID: 24013
		internal global::AcpUI.AcpLabel CnvPerSignalingASTROSystem_A7498Comp;

		// Token: 0x04005DCE RID: 24014
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x04005DCF RID: 24015
		internal global::AcpUI.AcpLabel LblCnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x04005DD0 RID: 24016
		internal global::AcpUI.AcpComboBox CnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x04005DD1 RID: 24017
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x04005DD2 RID: 24018
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x04005DD3 RID: 24019
		internal global::AcpUI.AcpLabel CnvPerSignalingDigitalModulatorType_A7857Comp;

		// Token: 0x04005DD4 RID: 24020
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x04005DD5 RID: 24021
		internal global::AcpUI.AcpLabel LblCnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x04005DD6 RID: 24022
		internal global::AcpUI.AcpComboBox CnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x04005DD7 RID: 24023
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x04005DD8 RID: 24024
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x04005DD9 RID: 24025
		internal global::AcpUI.AcpLabel CnvPerSignalingASTRORxUnmuteRule_A9042Comp;

		// Token: 0x04005DDA RID: 24026
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x04005DDB RID: 24027
		internal global::AcpUI.AcpLabel LblCnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x04005DDC RID: 24028
		internal global::AcpUI.AcpCheckBox CnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x04005DDD RID: 24029
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x04005DDE RID: 24030
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x04005DDF RID: 24031
		internal global::AcpUI.AcpCheckBox CnvPerSignalingLateEntryFastUnmute_A8423Comp;

		// Token: 0x04005DE0 RID: 24032
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySignalingNonASTRO;

		// Token: 0x04005DE1 RID: 24033
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingSignalingType_A9129;

		// Token: 0x04005DE2 RID: 24034
		internal global::AcpUI.AcpLabel LblCnvPerSignalingSignalingType_A9129;

		// Token: 0x04005DE3 RID: 24035
		internal global::AcpUI.AcpComboBox CnvPerSignalingSignalingType_A9129;

		// Token: 0x04005DE4 RID: 24036
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingSignalingType_A9129;

		// Token: 0x04005DE5 RID: 24037
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingSignalingType_A9129;

		// Token: 0x04005DE6 RID: 24038
		internal global::AcpUI.AcpLabel CnvPerSignalingSignalingType_A9129Comp;

		// Token: 0x04005DE7 RID: 24039
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingSystemNumber_A9243;

		// Token: 0x04005DE8 RID: 24040
		internal global::AcpUI.AcpLabel LblCnvPerSignalingSystemNumber_A9243;

		// Token: 0x04005DE9 RID: 24041
		internal global::AcpUI.AcpComboBox CnvPerSignalingSystemNumber_A9243;

		// Token: 0x04005DEA RID: 24042
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingSystemNumber_A9243;

		// Token: 0x04005DEB RID: 24043
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingSystemNumber_A9243;

		// Token: 0x04005DEC RID: 24044
		internal global::AcpUI.AcpLabel CnvPerSignalingSystemNumber_A9243Comp;

		// Token: 0x04005DED RID: 24045
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingPTTID_A8770;

		// Token: 0x04005DEE RID: 24046
		internal global::AcpUI.AcpLabel LblCnvPerSignalingPTTID_A8770;

		// Token: 0x04005DEF RID: 24047
		internal global::AcpUI.AcpCheckBox CnvPerSignalingPTTID_A8770;

		// Token: 0x04005DF0 RID: 24048
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingPTTID_A8770;

		// Token: 0x04005DF1 RID: 24049
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingPTTID_A8770;

		// Token: 0x04005DF2 RID: 24050
		internal global::AcpUI.AcpCheckBox CnvPerSignalingPTTID_A8770Comp;

		// Token: 0x04005DF3 RID: 24051
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x04005DF4 RID: 24052
		internal global::AcpUI.AcpLabel LblCnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x04005DF5 RID: 24053
		internal global::AcpUI.AcpCheckBox CnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x04005DF6 RID: 24054
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x04005DF7 RID: 24055
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x04005DF8 RID: 24056
		internal global::AcpUI.AcpCheckBox CnvPerSignalingEmergencyPTTID_A7944Comp;

		// Token: 0x04005DF9 RID: 24057
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySignalingEmergencyRevert;

		// Token: 0x04005DFA RID: 24058
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertType_A8953;

		// Token: 0x04005DFB RID: 24059
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertType_A8953;

		// Token: 0x04005DFC RID: 24060
		internal global::AcpUI.AcpComboBox CnvPerSignalingRevertType_A8953;

		// Token: 0x04005DFD RID: 24061
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertType_A8953;

		// Token: 0x04005DFE RID: 24062
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertType_A8953;

		// Token: 0x04005DFF RID: 24063
		internal global::AcpUI.AcpLabel CnvPerSignalingRevertType_A8953Comp;

		// Token: 0x04005E00 RID: 24064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertZone_A13269;

		// Token: 0x04005E01 RID: 24065
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertZone_A13269;

		// Token: 0x04005E02 RID: 24066
		internal global::AcpUI.AcpComboBox CnvPerSignalingRevertZone_A13269;

		// Token: 0x04005E03 RID: 24067
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertZone_A13269;

		// Token: 0x04005E04 RID: 24068
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertZone_A13269;

		// Token: 0x04005E05 RID: 24069
		internal global::AcpUI.AcpLabel CnvPerSignalingRevertZone_A13269Comp;

		// Token: 0x04005E06 RID: 24070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertChannel_A13267;

		// Token: 0x04005E07 RID: 24071
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertChannel_A13267;

		// Token: 0x04005E08 RID: 24072
		internal global::AcpUI.AcpComboBox CnvPerSignalingRevertChannel_A13267;

		// Token: 0x04005E09 RID: 24073
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertChannel_A13267;

		// Token: 0x04005E0A RID: 24074
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertChannel_A13267;

		// Token: 0x04005E0B RID: 24075
		internal global::AcpUI.AcpLabel CnvPerSignalingRevertChannel_A13267Comp;

		// Token: 0x04005E0C RID: 24076
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySignalingRevertTalkgroup;

		// Token: 0x04005E0D RID: 24077
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x04005E0E RID: 24078
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x04005E0F RID: 24079
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x04005E10 RID: 24080
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x04005E11 RID: 24081
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x04005E12 RID: 24082
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerSignalingRevertTGWACNID_A40150Comp;

		// Token: 0x04005E13 RID: 24083
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x04005E14 RID: 24084
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x04005E15 RID: 24085
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x04005E16 RID: 24086
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x04005E17 RID: 24087
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x04005E18 RID: 24088
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerSignalingRevertTGSYSID_A40151Comp;

		// Token: 0x04005E19 RID: 24089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertTG_A40152;

		// Token: 0x04005E1A RID: 24090
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertTG_A40152;

		// Token: 0x04005E1B RID: 24091
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvPerSignalingRevertTG_A40152;

		// Token: 0x04005E1C RID: 24092
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertTG_A40152;

		// Token: 0x04005E1D RID: 24093
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertTG_A40152;

		// Token: 0x04005E1E RID: 24094
		internal global::AcpUI.AcpTextBoxDecHex CnvPerSignalingRevertTG_A40152Comp;

		// Token: 0x04005E1F RID: 24095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x04005E20 RID: 24096
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x04005E21 RID: 24097
		internal global::AcpUI.AcpComboBox CnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x04005E22 RID: 24098
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x04005E23 RID: 24099
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x04005E24 RID: 24100
		internal global::AcpUI.AcpLabel CnvPerSignalingRevertTGSecClearStrap_A40153Comp;

		// Token: 0x04005E25 RID: 24101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04005E26 RID: 24102
		internal global::AcpUI.AcpLabel LblCnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04005E27 RID: 24103
		internal global::AcpUI.AcpComboBox CnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04005E28 RID: 24104
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04005E29 RID: 24105
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04005E2A RID: 24106
		internal global::AcpUI.AcpLabel CnvPerSignalingRevertTGKeySel_A40154Comp;

		// Token: 0x04005E2B RID: 24107
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySignalingPseudo4;

		// Token: 0x04005E2C RID: 24108
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesAstroAlertingToneTable;

		// Token: 0x04005E2D RID: 24109
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesAstroAlertingToneTable;

		// Token: 0x04005E2E RID: 24110
		internal global::AcpUI.AcpComboBox CnvPerFeaturesAstroAlertingToneTable;

		// Token: 0x04005E2F RID: 24111
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesAstroAlertingToneTable;

		// Token: 0x04005E30 RID: 24112
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesAstroAlertingToneTable;

		// Token: 0x04005E31 RID: 24113
		internal global::AcpUI.AcpLabel CnvPerFeaturesAstroAlertingToneTableComp;

		// Token: 0x04005E32 RID: 24114
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityDVRS;

		// Token: 0x04005E33 RID: 24115
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityDVRSAnnouncementGroup;

		// Token: 0x04005E34 RID: 24116
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAGAGWACNID_A40155;

		// Token: 0x04005E35 RID: 24117
		internal global::AcpUI.AcpLabel LblCnvPerAGAGWACNID_A40155;

		// Token: 0x04005E36 RID: 24118
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGWACNID_A40155;

		// Token: 0x04005E37 RID: 24119
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAGAGWACNID_A40155;

		// Token: 0x04005E38 RID: 24120
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAGAGWACNID_A40155;

		// Token: 0x04005E39 RID: 24121
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGWACNID_A40155Comp;

		// Token: 0x04005E3A RID: 24122
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAGAGSysID_A40156;

		// Token: 0x04005E3B RID: 24123
		internal global::AcpUI.AcpLabel LblCnvPerAGAGSysID_A40156;

		// Token: 0x04005E3C RID: 24124
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGSysID_A40156;

		// Token: 0x04005E3D RID: 24125
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAGAGSysID_A40156;

		// Token: 0x04005E3E RID: 24126
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAGAGSysID_A40156;

		// Token: 0x04005E3F RID: 24127
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGSysID_A40156Comp;

		// Token: 0x04005E40 RID: 24128
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04005E41 RID: 24129
		internal global::AcpUI.AcpLabel LblCnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04005E42 RID: 24130
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04005E43 RID: 24131
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04005E44 RID: 24132
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04005E45 RID: 24133
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvPerAGAGTalkgroupID_A40157Comp;

		// Token: 0x04005E46 RID: 24134
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAGAGSecStrap_A40158;

		// Token: 0x04005E47 RID: 24135
		internal global::AcpUI.AcpLabel LblCnvPerAGAGSecStrap_A40158;

		// Token: 0x04005E48 RID: 24136
		internal global::AcpUI.AcpComboBox CnvPerAGAGSecStrap_A40158;

		// Token: 0x04005E49 RID: 24137
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAGAGSecStrap_A40158;

		// Token: 0x04005E4A RID: 24138
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAGAGSecStrap_A40158;

		// Token: 0x04005E4B RID: 24139
		internal global::AcpUI.AcpLabel CnvPerAGAGSecStrap_A40158Comp;

		// Token: 0x04005E4C RID: 24140
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAGAGKeySel_A40159;

		// Token: 0x04005E4D RID: 24141
		internal global::AcpUI.AcpLabel LblCnvPerAGAGKeySel_A40159;

		// Token: 0x04005E4E RID: 24142
		internal global::AcpUI.AcpComboBox CnvPerAGAGKeySel_A40159;

		// Token: 0x04005E4F RID: 24143
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAGAGKeySel_A40159;

		// Token: 0x04005E50 RID: 24144
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAGAGKeySel_A40159;

		// Token: 0x04005E51 RID: 24145
		internal global::AcpUI.AcpLabel CnvPerAGAGKeySel_A40159Comp;

		// Token: 0x04005E52 RID: 24146
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityNonASTROCall;

		// Token: 0x04005E53 RID: 24147
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityNonASTROCallSelectiveCall;

		// Token: 0x04005E54 RID: 24148
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x04005E55 RID: 24149
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x04005E56 RID: 24150
		internal global::AcpUI.AcpComboBox CnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x04005E57 RID: 24151
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x04005E58 RID: 24152
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x04005E59 RID: 24153
		internal global::AcpUI.AcpLabel CnvPerNonASTROCallSelectiveCallRxTx_A9116Comp;

		// Token: 0x04005E5A RID: 24154
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x04005E5B RID: 24155
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x04005E5C RID: 24156
		internal global::AcpUI.AcpComboBox CnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x04005E5D RID: 24157
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x04005E5E RID: 24158
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x04005E5F RID: 24159
		internal global::AcpUI.AcpLabel CnvPerNonASTROCallUnmuteType_A9601Comp;

		// Token: 0x04005E60 RID: 24160
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityNonASTROCallCallAlert;

		// Token: 0x04005E61 RID: 24161
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x04005E62 RID: 24162
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x04005E63 RID: 24163
		internal global::AcpUI.AcpComboBox CnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x04005E64 RID: 24164
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x04005E65 RID: 24165
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x04005E66 RID: 24166
		internal global::AcpUI.AcpLabel CnvPerNonASTROCallCallAlertRxTx_A7588Comp;

		// Token: 0x04005E67 RID: 24167
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x04005E68 RID: 24168
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x04005E69 RID: 24169
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x04005E6A RID: 24170
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x04005E6B RID: 24171
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x04005E6C RID: 24172
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallInCallUserAlertEnable_A8252Comp;

		// Token: 0x04005E6D RID: 24173
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityNonASTROCallMDC;

		// Token: 0x04005E6E RID: 24174
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x04005E6F RID: 24175
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x04005E70 RID: 24176
		internal global::AcpUI.AcpComboBox CnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x04005E71 RID: 24177
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x04005E72 RID: 24178
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x04005E73 RID: 24179
		internal global::AcpUI.AcpLabel CnvPerNonASTROCallRTTButtonAccess_A8493Comp;

		// Token: 0x04005E74 RID: 24180
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x04005E75 RID: 24181
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x04005E76 RID: 24182
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x04005E77 RID: 24183
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x04005E78 RID: 24184
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x04005E79 RID: 24185
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallAutoSelectCallTransmit_A7520Comp;

		// Token: 0x04005E7A RID: 24186
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x04005E7B RID: 24187
		internal global::AcpUI.AcpLabel LblCnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x04005E7C RID: 24188
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x04005E7D RID: 24189
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x04005E7E RID: 24190
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x04005E7F RID: 24191
		internal global::AcpUI.AcpCheckBox CnvPerNonASTROCallUnlimitedCalling_A9597Comp;

		// Token: 0x04005E80 RID: 24192
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityNonASTROCallPseudo3;

		// Token: 0x04005E81 RID: 24193
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolAnalogHotListItemID_A21918;

		// Token: 0x04005E82 RID: 24194
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolAnalogHotListItemID_A21918;

		// Token: 0x04005E83 RID: 24195
		internal global::AcpUI.AcpComboBox CnvPerLabtoolAnalogHotListItemID_A21918;

		// Token: 0x04005E84 RID: 24196
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolAnalogHotListItemID_A21918;

		// Token: 0x04005E85 RID: 24197
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolAnalogHotListItemID_A21918;

		// Token: 0x04005E86 RID: 24198
		internal global::AcpUI.AcpLabel CnvPerLabtoolAnalogHotListItemID_A21918Comp;

		// Token: 0x04005E87 RID: 24199
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityASTROCall;

		// Token: 0x04005E88 RID: 24200
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallSelectiveCall;

		// Token: 0x04005E89 RID: 24201
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005E8A RID: 24202
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005E8B RID: 24203
		internal global::AcpUI.AcpComboBox CnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005E8C RID: 24204
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005E8D RID: 24205
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005E8E RID: 24206
		internal global::AcpUI.AcpLabel CnvPerASTROCallSelectiveCallRxTx_A9114Comp;

		// Token: 0x04005E8F RID: 24207
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005E90 RID: 24208
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005E91 RID: 24209
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005E92 RID: 24210
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005E93 RID: 24211
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005E94 RID: 24212
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallAutoSelectiveCallTransmit_A7518Comp;

		// Token: 0x04005E95 RID: 24213
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallCallAlert;

		// Token: 0x04005E96 RID: 24214
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005E97 RID: 24215
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005E98 RID: 24216
		internal global::AcpUI.AcpComboBox CnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005E99 RID: 24217
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005E9A RID: 24218
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005E9B RID: 24219
		internal global::AcpUI.AcpLabel CnvPerASTROCallCallAlertRxTx_A7586Comp;

		// Token: 0x04005E9C RID: 24220
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005E9D RID: 24221
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005E9E RID: 24222
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005E9F RID: 24223
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005EA0 RID: 24224
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005EA1 RID: 24225
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallInCallUserAlertEnable_A8250Comp;

		// Token: 0x04005EA2 RID: 24226
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallPseudo2;

		// Token: 0x04005EA3 RID: 24227
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005EA4 RID: 24228
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005EA5 RID: 24229
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005EA6 RID: 24230
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005EA7 RID: 24231
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005EA8 RID: 24232
		internal global::AcpUI.AcpCheckBox CnvPerASTROCallASTROUnlimitedCalling_A7501Comp;

		// Token: 0x04005EA9 RID: 24233
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallTacticalServices;

		// Token: 0x04005EAA RID: 24234
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005EAB RID: 24235
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005EAC RID: 24236
		internal global::AcpUI.AcpComboBox CnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005EAD RID: 24237
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005EAE RID: 24238
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005EAF RID: 24239
		internal global::AcpUI.AcpLabel CnvPerASTROCallTacticalServicesOperationComp;

		// Token: 0x04005EB0 RID: 24240
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005EB1 RID: 24241
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005EB2 RID: 24242
		internal global::AcpUI.AcpComboBox CnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005EB3 RID: 24243
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005EB4 RID: 24244
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005EB5 RID: 24245
		internal global::AcpUI.AcpLabel CnvPerASTROCallRadioUninhibitDecodeAction_A9045Comp;

		// Token: 0x04005EB6 RID: 24246
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallRemoteMonitorTxRxTime;

		// Token: 0x04005EB7 RID: 24247
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallRemoteMonitorTxRxTime;

		// Token: 0x04005EB8 RID: 24248
		internal global::AcpUI.AcpTextBoxSpinner CnvPerASTROCallRemoteMonitorTxRxTime;

		// Token: 0x04005EB9 RID: 24249
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallRemoteMonitorTxRxTime;

		// Token: 0x04005EBA RID: 24250
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallRemoteMonitorTxRxTime;

		// Token: 0x04005EBB RID: 24251
		internal global::AcpUI.AcpLabel CnvPerASTROCallRemoteMonitorTxRxTimeComp;

		// Token: 0x04005EBC RID: 24252
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005EBD RID: 24253
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005EBE RID: 24254
		internal global::AcpUI.AcpComboBox CnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005EBF RID: 24255
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005EC0 RID: 24256
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005EC1 RID: 24257
		internal global::AcpUI.AcpLabel CnvPerASTROCallRemotemonitorfrequencyoptionComp;

		// Token: 0x04005EC2 RID: 24258
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallTacticalInhibit;

		// Token: 0x04005EC3 RID: 24259
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005EC4 RID: 24260
		internal global::AcpUI.AcpLabel LblCnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005EC5 RID: 24261
		internal global::AcpUI.AcpComboBox CnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005EC6 RID: 24262
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005EC7 RID: 24263
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005EC8 RID: 24264
		internal global::AcpUI.AcpLabel CnvPerTacticalInhibitKillOperation_A41553Comp;

		// Token: 0x04005EC9 RID: 24265
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005ECA RID: 24266
		internal global::AcpUI.AcpLabel LblCnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005ECB RID: 24267
		internal global::AcpUI.AcpComboBox CnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005ECC RID: 24268
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005ECD RID: 24269
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005ECE RID: 24270
		internal global::AcpUI.AcpLabel CnvPerTacticalInhibitStunOperation_A41557Comp;

		// Token: 0x04005ECF RID: 24271
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROCallPseudo3;

		// Token: 0x04005ED0 RID: 24272
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005ED1 RID: 24273
		internal global::AcpUI.AcpLabel LblCnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005ED2 RID: 24274
		internal global::AcpUI.AcpComboBox CnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005ED3 RID: 24275
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005ED4 RID: 24276
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005ED5 RID: 24277
		internal global::AcpUI.AcpLabel CnvPerASTROCallASTROCallHotList_A7488Comp;

		// Token: 0x04005ED6 RID: 24278
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityASTROTalkgroup;

		// Token: 0x04005ED7 RID: 24279
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityASTROTalkgroupPseudo0;

		// Token: 0x04005ED8 RID: 24280
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005ED9 RID: 24281
		internal global::AcpUI.AcpLabel LblCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005EDA RID: 24282
		internal global::AcpUI.AcpCheckBox CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005EDB RID: 24283
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005EDC RID: 24284
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005EDD RID: 24285
		internal global::AcpUI.AcpCheckBox CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272Comp;

		// Token: 0x04005EDE RID: 24286
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283;

		// Token: 0x04005EDF RID: 24287
		internal global::AcpUI.AcpLabel LblCnvPerASTROTalkgroupOptionsTalkgroupList_A9283;

		// Token: 0x04005EE0 RID: 24288
		internal global::AcpUI.AcpComboBox CnvPerASTROTalkgroupOptionsTalkgroupList_A9283;

		// Token: 0x04005EE1 RID: 24289
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283;

		// Token: 0x04005EE2 RID: 24290
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROTalkgroupOptionsTalkgroupList_A9283;

		// Token: 0x04005EE3 RID: 24291
		internal global::AcpUI.AcpLabel CnvPerASTROTalkgroupOptionsTalkgroupList_A9283Comp;

		// Token: 0x04005EE4 RID: 24292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005EE5 RID: 24293
		internal global::AcpUI.AcpLabel LblCnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005EE6 RID: 24294
		internal global::AcpUI.AcpComboBox CnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005EE7 RID: 24295
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005EE8 RID: 24296
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005EE9 RID: 24297
		internal global::AcpUI.AcpLabel CnvPerASTROTalkgroupOptionsSelectionType_A9112Comp;

		// Token: 0x04005EEA RID: 24298
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityRAC;

		// Token: 0x04005EEB RID: 24299
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityRACPseudo0;

		// Token: 0x04005EEC RID: 24300
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACRepeaterAccess_A8939;

		// Token: 0x04005EED RID: 24301
		internal global::AcpUI.AcpLabel LblCnvPerRACRepeaterAccess_A8939;

		// Token: 0x04005EEE RID: 24302
		internal global::AcpUI.AcpCheckBox CnvPerRACRepeaterAccess_A8939;

		// Token: 0x04005EEF RID: 24303
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACRepeaterAccess_A8939;

		// Token: 0x04005EF0 RID: 24304
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACRepeaterAccess_A8939;

		// Token: 0x04005EF1 RID: 24305
		internal global::AcpUI.AcpCheckBox CnvPerRACRepeaterAccess_A8939Comp;

		// Token: 0x04005EF2 RID: 24306
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACAccessType_A7388;

		// Token: 0x04005EF3 RID: 24307
		internal global::AcpUI.AcpLabel LblCnvPerRACAccessType_A7388;

		// Token: 0x04005EF4 RID: 24308
		internal global::AcpUI.AcpComboBox CnvPerRACAccessType_A7388;

		// Token: 0x04005EF5 RID: 24309
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACAccessType_A7388;

		// Token: 0x04005EF6 RID: 24310
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACAccessType_A7388;

		// Token: 0x04005EF7 RID: 24311
		internal global::AcpUI.AcpLabel CnvPerRACAccessType_A7388Comp;

		// Token: 0x04005EF8 RID: 24312
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACToneSignalingSystem_A9392;

		// Token: 0x04005EF9 RID: 24313
		internal global::AcpUI.AcpLabel LblCnvPerRACToneSignalingSystem_A9392;

		// Token: 0x04005EFA RID: 24314
		internal global::AcpUI.AcpComboBox CnvPerRACToneSignalingSystem_A9392;

		// Token: 0x04005EFB RID: 24315
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACToneSignalingSystem_A9392;

		// Token: 0x04005EFC RID: 24316
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACToneSignalingSystem_A9392;

		// Token: 0x04005EFD RID: 24317
		internal global::AcpUI.AcpLabel CnvPerRACToneSignalingSystem_A9392Comp;

		// Token: 0x04005EFE RID: 24318
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityRACRepeaterAccessButton1PTT;

		// Token: 0x04005EFF RID: 24319
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACCodeType1_A7680;

		// Token: 0x04005F00 RID: 24320
		internal global::AcpUI.AcpLabel LblCnvPerRACCodeType1_A7680;

		// Token: 0x04005F01 RID: 24321
		internal global::AcpUI.AcpComboBox CnvPerRACCodeType1_A7680;

		// Token: 0x04005F02 RID: 24322
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACCodeType1_A7680;

		// Token: 0x04005F03 RID: 24323
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACCodeType1_A7680;

		// Token: 0x04005F04 RID: 24324
		internal global::AcpUI.AcpLabel CnvPerRACCodeType1_A7680Comp;

		// Token: 0x04005F05 RID: 24325
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x04005F06 RID: 24326
		internal global::AcpUI.AcpLabel LblCnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x04005F07 RID: 24327
		internal global::AcpUI.AcpComboBox CnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x04005F08 RID: 24328
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x04005F09 RID: 24329
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x04005F0A RID: 24330
		internal global::AcpUI.AcpLabel CnvPerRACMDCRepeaterID1_A8783Comp;

		// Token: 0x04005F0B RID: 24331
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACSingletone_A43072;

		// Token: 0x04005F0C RID: 24332
		internal global::AcpUI.AcpLabel LblCnvPerRACSingletone_A43072;

		// Token: 0x04005F0D RID: 24333
		internal global::AcpUI.AcpComboBox CnvPerRACSingletone_A43072;

		// Token: 0x04005F0E RID: 24334
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACSingletone_A43072;

		// Token: 0x04005F0F RID: 24335
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACSingletone_A43072;

		// Token: 0x04005F10 RID: 24336
		internal global::AcpUI.AcpLabel CnvPerRACSingletone_A43072Comp;

		// Token: 0x04005F11 RID: 24337
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityRACRepeaterAccessButton2;

		// Token: 0x04005F12 RID: 24338
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACCodeType2_A8817;

		// Token: 0x04005F13 RID: 24339
		internal global::AcpUI.AcpLabel LblCnvPerRACCodeType2_A8817;

		// Token: 0x04005F14 RID: 24340
		internal global::AcpUI.AcpComboBox CnvPerRACCodeType2_A8817;

		// Token: 0x04005F15 RID: 24341
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACCodeType2_A8817;

		// Token: 0x04005F16 RID: 24342
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACCodeType2_A8817;

		// Token: 0x04005F17 RID: 24343
		internal global::AcpUI.AcpLabel CnvPerRACCodeType2_A8817Comp;

		// Token: 0x04005F18 RID: 24344
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x04005F19 RID: 24345
		internal global::AcpUI.AcpLabel LblCnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x04005F1A RID: 24346
		internal global::AcpUI.AcpComboBox CnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x04005F1B RID: 24347
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x04005F1C RID: 24348
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x04005F1D RID: 24349
		internal global::AcpUI.AcpLabel CnvPerRACMDCRepeaterID2_A8814Comp;

		// Token: 0x04005F1E RID: 24350
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerRACSingletone_A43073;

		// Token: 0x04005F1F RID: 24351
		internal global::AcpUI.AcpLabel LblCnvPerRACSingletone_A43073;

		// Token: 0x04005F20 RID: 24352
		internal global::AcpUI.AcpComboBox CnvPerRACSingletone_A43073;

		// Token: 0x04005F21 RID: 24353
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerRACSingletone_A43073;

		// Token: 0x04005F22 RID: 24354
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerRACSingletone_A43073;

		// Token: 0x04005F23 RID: 24355
		internal global::AcpUI.AcpLabel CnvPerRACSingletone_A43073Comp;

		// Token: 0x04005F24 RID: 24356
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityFeatures;

		// Token: 0x04005F25 RID: 24357
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesPseudo0;

		// Token: 0x04005F26 RID: 24358
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04005F27 RID: 24359
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04005F28 RID: 24360
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04005F29 RID: 24361
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04005F2A RID: 24362
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04005F2B RID: 24363
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolOTACROTACSMessaging_A8663Comp;

		// Token: 0x04005F2C RID: 24364
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x04005F2D RID: 24365
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x04005F2E RID: 24366
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x04005F2F RID: 24367
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x04005F30 RID: 24368
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x04005F31 RID: 24369
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesTacticalRekeyEnable_A19309Comp;

		// Token: 0x04005F32 RID: 24370
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04005F33 RID: 24371
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04005F34 RID: 24372
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04005F35 RID: 24373
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04005F36 RID: 24374
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04005F37 RID: 24375
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolHotKeypad_A8208Comp;

		// Token: 0x04005F38 RID: 24376
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04005F39 RID: 24377
		internal global::AcpUI.AcpLabel LblCnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04005F3A RID: 24378
		internal global::AcpUI.AcpCheckBox CnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04005F3B RID: 24379
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04005F3C RID: 24380
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04005F3D RID: 24381
		internal global::AcpUI.AcpCheckBox CnvPerFeatureDTMFMicEn_A42481Comp;

		// Token: 0x04005F3E RID: 24382
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04005F3F RID: 24383
		internal global::AcpUI.AcpLabel LblCnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04005F40 RID: 24384
		internal global::AcpUI.AcpCheckBox CnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04005F41 RID: 24385
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04005F42 RID: 24386
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04005F43 RID: 24387
		internal global::AcpUI.AcpCheckBox CnvPerEndTxOnVoiceAbsence_42460Comp;

		// Token: 0x04005F44 RID: 24388
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeatureRFModem_42485;

		// Token: 0x04005F45 RID: 24389
		internal global::AcpUI.AcpLabel LblCnvPerFeatureRFModem_42485;

		// Token: 0x04005F46 RID: 24390
		internal global::AcpUI.AcpComboBox CnvPerFeatureRFModem_42485;

		// Token: 0x04005F47 RID: 24391
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeatureRFModem_42485;

		// Token: 0x04005F48 RID: 24392
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeatureRFModem_42485;

		// Token: 0x04005F49 RID: 24393
		internal global::AcpUI.AcpLabel CnvPerFeatureRFModem_42485Comp;

		// Token: 0x04005F4A RID: 24394
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesScan;

		// Token: 0x04005F4B RID: 24395
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04005F4C RID: 24396
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04005F4D RID: 24397
		internal global::AcpUI.AcpComboBox CnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04005F4E RID: 24398
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04005F4F RID: 24399
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04005F50 RID: 24400
		internal global::AcpUI.AcpLabel CnvPerLabtoolScanListSelection_A9054Comp;

		// Token: 0x04005F51 RID: 24401
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04005F52 RID: 24402
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04005F53 RID: 24403
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04005F54 RID: 24404
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04005F55 RID: 24405
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04005F56 RID: 24406
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolAutomaticScan_A7527Comp;

		// Token: 0x04005F57 RID: 24407
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x04005F58 RID: 24408
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x04005F59 RID: 24409
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x04005F5A RID: 24410
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x04005F5B RID: 24411
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x04005F5C RID: 24412
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesMixedVoteScanEnable_A38723Comp;

		// Token: 0x04005F5D RID: 24413
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x04005F5E RID: 24414
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x04005F5F RID: 24415
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x04005F60 RID: 24416
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x04005F61 RID: 24417
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x04005F62 RID: 24418
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesMixedVoteScanTxSteering_A38878Comp;

		// Token: 0x04005F63 RID: 24419
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesSmartPTT;

		// Token: 0x04005F64 RID: 24420
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04005F65 RID: 24421
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04005F66 RID: 24422
		internal global::AcpUI.AcpComboBox CnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04005F67 RID: 24423
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04005F68 RID: 24424
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04005F69 RID: 24425
		internal global::AcpUI.AcpLabel CnvPerLabtoolSmartPTTType_A9164Comp;

		// Token: 0x04005F6A RID: 24426
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04005F6B RID: 24427
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04005F6C RID: 24428
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04005F6D RID: 24429
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04005F6E RID: 24430
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04005F6F RID: 24431
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolQuickKeyOverride_A8808Comp;

		// Token: 0x04005F70 RID: 24432
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;

		// Token: 0x04005F71 RID: 24433
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;

		// Token: 0x04005F72 RID: 24434
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;

		// Token: 0x04005F73 RID: 24435
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;

		// Token: 0x04005F74 RID: 24436
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;

		// Token: 0x04005F75 RID: 24437
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913Comp;

		// Token: 0x04005F76 RID: 24438
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesPseudo2;

		// Token: 0x04005F77 RID: 24439
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConPerFeatureIncidentSignalingType_A41507;

		// Token: 0x04005F78 RID: 24440
		internal global::AcpUI.AcpLabel LblConPerFeatureIncidentSignalingType_A41507;

		// Token: 0x04005F79 RID: 24441
		internal global::AcpUI.AcpComboBox ConPerFeatureIncidentSignalingType_A41507;

		// Token: 0x04005F7A RID: 24442
		internal global::AcpUI.AcpRtdButton RTDBtnConPerFeatureIncidentSignalingType_A41507;

		// Token: 0x04005F7B RID: 24443
		internal global::AcpUI.AcpCopyButton CpyBtnConPerFeatureIncidentSignalingType_A41507;

		// Token: 0x04005F7C RID: 24444
		internal global::AcpUI.AcpLabel ConPerFeatureIncidentSignalingType_A41507Comp;

		// Token: 0x04005F7D RID: 24445
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesTacticalPublicSafety;

		// Token: 0x04005F7E RID: 24446
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesPseudo3;

		// Token: 0x04005F7F RID: 24447
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerTPSTPSUIEnable_A9400;

		// Token: 0x04005F80 RID: 24448
		internal global::AcpUI.AcpLabel LblCnvPerTPSTPSUIEnable_A9400;

		// Token: 0x04005F81 RID: 24449
		internal global::AcpUI.AcpCheckBox CnvPerTPSTPSUIEnable_A9400;

		// Token: 0x04005F82 RID: 24450
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerTPSTPSUIEnable_A9400;

		// Token: 0x04005F83 RID: 24451
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerTPSTPSUIEnable_A9400;

		// Token: 0x04005F84 RID: 24452
		internal global::AcpUI.AcpCheckBox CnvPerTPSTPSUIEnable_A9400Comp;

		// Token: 0x04005F85 RID: 24453
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesPersonnelAccountability;

		// Token: 0x04005F86 RID: 24454
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04005F87 RID: 24455
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04005F88 RID: 24456
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04005F89 RID: 24457
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04005F8A RID: 24458
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04005F8B RID: 24459
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesFiregroundRegistration_A33242Comp;

		// Token: 0x04005F8C RID: 24460
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x04005F8D RID: 24461
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x04005F8E RID: 24462
		internal global::AcpUI.AcpComboBox CnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x04005F8F RID: 24463
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x04005F90 RID: 24464
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x04005F91 RID: 24465
		internal global::AcpUI.AcpLabel CnvPerFeaturesTxVoiceType_A9573Comp;

		// Token: 0x04005F92 RID: 24466
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityFeaturesPseudo4;

		// Token: 0x04005F93 RID: 24467
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04005F94 RID: 24468
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04005F95 RID: 24469
		internal global::AcpUI.AcpComboBox CnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04005F96 RID: 24470
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04005F97 RID: 24471
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04005F98 RID: 24472
		internal global::AcpUI.AcpLabel CnvPerFeaturesOTARadioAliasType_42784Comp;

		// Token: 0x04005F99 RID: 24473
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04005F9A RID: 24474
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04005F9B RID: 24475
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04005F9C RID: 24476
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04005F9D RID: 24477
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04005F9E RID: 24478
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesOTARadioAliasUpdateEnable_A43059Comp;

		// Token: 0x04005F9F RID: 24479
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04005FA0 RID: 24480
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04005FA1 RID: 24481
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04005FA2 RID: 24482
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04005FA3 RID: 24483
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04005FA4 RID: 24484
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesConvetionalRSSIDisplay_42785Comp;

		// Token: 0x04005FA5 RID: 24485
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04005FA6 RID: 24486
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04005FA7 RID: 24487
		internal global::AcpUI.AcpTextBoxSpinner CnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04005FA8 RID: 24488
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04005FA9 RID: 24489
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04005FAA RID: 24490
		internal global::AcpUI.AcpLabel CnvPerFeaturesRSSIDisplayTimer_42786Comp;

		// Token: 0x04005FAB RID: 24491
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04005FAC RID: 24492
		internal global::AcpUI.AcpLabel LblCnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04005FAD RID: 24493
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04005FAE RID: 24494
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04005FAF RID: 24495
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04005FB0 RID: 24496
		internal global::AcpUI.AcpCheckBox CnvPerFeaturesHazardZoneModePersonalityComp;

		// Token: 0x04005FB1 RID: 24497
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityPhone;

		// Token: 0x04005FB2 RID: 24498
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityPhonePseudo0;

		// Token: 0x04005FB3 RID: 24499
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerPhonePhoneOperation_A8703;

		// Token: 0x04005FB4 RID: 24500
		internal global::AcpUI.AcpLabel LblCnvPerPhonePhoneOperation_A8703;

		// Token: 0x04005FB5 RID: 24501
		internal global::AcpUI.AcpComboBox CnvPerPhonePhoneOperation_A8703;

		// Token: 0x04005FB6 RID: 24502
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerPhonePhoneOperation_A8703;

		// Token: 0x04005FB7 RID: 24503
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerPhonePhoneOperation_A8703;

		// Token: 0x04005FB8 RID: 24504
		internal global::AcpUI.AcpLabel CnvPerPhonePhoneOperation_A8703Comp;

		// Token: 0x04005FB9 RID: 24505
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x04005FBA RID: 24506
		internal global::AcpUI.AcpLabel LblCnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x04005FBB RID: 24507
		internal global::AcpUI.AcpComboBox CnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x04005FBC RID: 24508
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x04005FBD RID: 24509
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x04005FBE RID: 24510
		internal global::AcpUI.AcpLabel CnvPerPhoneAccessTimingTable_A7387Comp;

		// Token: 0x04005FBF RID: 24511
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x04005FC0 RID: 24512
		internal global::AcpUI.AcpLabel LblCnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x04005FC1 RID: 24513
		internal global::AcpUI.AcpComboBox CnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x04005FC2 RID: 24514
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x04005FC3 RID: 24515
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x04005FC4 RID: 24516
		internal global::AcpUI.AcpLabel CnvPerPhoneAutoAccessCodeSelect_A7503Comp;

		// Token: 0x04005FC5 RID: 24517
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityOneTouch;

		// Token: 0x04005FC6 RID: 24518
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderConventionalPersonalityOneTouchTable;

		// Token: 0x04005FC7 RID: 24519
		internal global::System.Windows.Controls.Grid ExpanderConventionalPersonalityOneTouchGrid;

		// Token: 0x04005FC8 RID: 24520
		internal global::System.Windows.Controls.Grid ExpanderConventionalPersonalityOneTouchTableGrid;

		// Token: 0x04005FC9 RID: 24521
		internal global::AcpUI.AcpGroupBox ExpanderConventionalPersonalityOneTouchTableTableView;

		// Token: 0x04005FCA RID: 24522
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalPersonalityOneTouchTable;

		// Token: 0x04005FCB RID: 24523
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerOneTouchButton_A19765_Col;

		// Token: 0x04005FCC RID: 24524
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerOneTouchFeature_A19662_Col;

		// Token: 0x04005FCD RID: 24525
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerOneTouchIndex_A19663_Col;

		// Token: 0x04005FCE RID: 24526
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Col;

		// Token: 0x04005FCF RID: 24527
		internal global::AcpUI.AcpGroupBox ExpanderConventionalPersonalityOneTouchTableSRecView;

		// Token: 0x04005FD0 RID: 24528
		internal global::System.Windows.Controls.Grid gridExpanderConventionalPersonalityOneTouchTableSRecView;

		// Token: 0x04005FD1 RID: 24529
		internal global::AcpUI.AcpLabel CnvPerOneTouchButton_A19765;

		// Token: 0x04005FD2 RID: 24530
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerOneTouchButton_A19765;

		// Token: 0x04005FD3 RID: 24531
		internal global::AcpUI.AcpLabel LblCnvPerOneTouchButton_A19765;

		// Token: 0x04005FD4 RID: 24532
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerOneTouchButton_A19765;

		// Token: 0x04005FD5 RID: 24533
		internal global::AcpUI.AcpLabel CnvPerOneTouchButton_A19765Comp;

		// Token: 0x04005FD6 RID: 24534
		internal global::AcpUI.AcpComboBox CnvPerOneTouchFeature_A19662;

		// Token: 0x04005FD7 RID: 24535
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerOneTouchFeature_A19662;

		// Token: 0x04005FD8 RID: 24536
		internal global::AcpUI.AcpLabel LblCnvPerOneTouchFeature_A19662;

		// Token: 0x04005FD9 RID: 24537
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerOneTouchFeature_A19662;

		// Token: 0x04005FDA RID: 24538
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerOneTouchFeature_A19662;

		// Token: 0x04005FDB RID: 24539
		internal global::AcpUI.AcpLabel CnvPerOneTouchFeature_A19662Comp;

		// Token: 0x04005FDC RID: 24540
		internal global::AcpUI.AcpTextBoxSpinner CnvPerOneTouchIndex_A19663;

		// Token: 0x04005FDD RID: 24541
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerOneTouchIndex_A19663;

		// Token: 0x04005FDE RID: 24542
		internal global::AcpUI.AcpLabel LblCnvPerOneTouchIndex_A19663;

		// Token: 0x04005FDF RID: 24543
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerOneTouchIndex_A19663;

		// Token: 0x04005FE0 RID: 24544
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerOneTouchIndex_A19663;

		// Token: 0x04005FE1 RID: 24545
		internal global::AcpUI.AcpLabel CnvPerOneTouchIndex_A19663Comp;

		// Token: 0x04005FE2 RID: 24546
		internal global::AcpUI.AcpTextBox CnvPerOneTouchAbbreviatedOneTouchAlias_A19664;

		// Token: 0x04005FE3 RID: 24547
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664;

		// Token: 0x04005FE4 RID: 24548
		internal global::AcpUI.AcpLabel LblCnvPerOneTouchAbbreviatedOneTouchAlias_A19664;

		// Token: 0x04005FE5 RID: 24549
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664;

		// Token: 0x04005FE6 RID: 24550
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerOneTouchAbbreviatedOneTouchAlias_A19664;

		// Token: 0x04005FE7 RID: 24551
		internal global::AcpUI.AcpLabel CnvPerOneTouchAbbreviatedOneTouchAlias_A19664Comp;

		// Token: 0x04005FE8 RID: 24552
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalitySecure;

		// Token: 0x04005FE9 RID: 24553
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySecurePseudo0;

		// Token: 0x04005FEA RID: 24554
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x04005FEB RID: 24555
		internal global::AcpUI.AcpLabel LblCnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x04005FEC RID: 24556
		internal global::AcpUI.AcpComboBox CnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x04005FED RID: 24557
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x04005FEE RID: 24558
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x04005FEF RID: 24559
		internal global::AcpUI.AcpLabel CnvPerSecureSecureVoiceSignalType_A9086Comp;

		// Token: 0x04005FF0 RID: 24560
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureXLTransmit_A9683;

		// Token: 0x04005FF1 RID: 24561
		internal global::AcpUI.AcpLabel LblCnvPerSecureXLTransmit_A9683;

		// Token: 0x04005FF2 RID: 24562
		internal global::AcpUI.AcpCheckBox CnvPerSecureXLTransmit_A9683;

		// Token: 0x04005FF3 RID: 24563
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureXLTransmit_A9683;

		// Token: 0x04005FF4 RID: 24564
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureXLTransmit_A9683;

		// Token: 0x04005FF5 RID: 24565
		internal global::AcpUI.AcpCheckBox CnvPerSecureXLTransmit_A9683Comp;

		// Token: 0x04005FF6 RID: 24566
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x04005FF7 RID: 24567
		internal global::AcpUI.AcpLabel LblCnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x04005FF8 RID: 24568
		internal global::AcpUI.AcpCheckBox CnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x04005FF9 RID: 24569
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x04005FFA RID: 24570
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x04005FFB RID: 24571
		internal global::AcpUI.AcpCheckBox CnvPerSecureDESXLTxDefault_A7831Comp;

		// Token: 0x04005FFC RID: 24572
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySecureVoice;

		// Token: 0x04005FFD RID: 24573
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x04005FFE RID: 24574
		internal global::AcpUI.AcpLabel LblCnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x04005FFF RID: 24575
		internal global::AcpUI.AcpComboBox CnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x04006000 RID: 24576
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x04006001 RID: 24577
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x04006002 RID: 24578
		internal global::AcpUI.AcpLabel CnvPerSecureSecureClearStrapping1_A9090Comp;

		// Token: 0x04006003 RID: 24579
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureKeyStrapping_A8370;

		// Token: 0x04006004 RID: 24580
		internal global::AcpUI.AcpLabel LblCnvPerSecureKeyStrapping_A8370;

		// Token: 0x04006005 RID: 24581
		internal global::AcpUI.AcpComboBox CnvPerSecureKeyStrapping_A8370;

		// Token: 0x04006006 RID: 24582
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureKeyStrapping_A8370;

		// Token: 0x04006007 RID: 24583
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureKeyStrapping_A8370;

		// Token: 0x04006008 RID: 24584
		internal global::AcpUI.AcpLabel CnvPerSecureKeyStrapping_A8370Comp;

		// Token: 0x04006009 RID: 24585
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureKeySelection2_A8369;

		// Token: 0x0400600A RID: 24586
		internal global::AcpUI.AcpLabel LblCnvPerSecureKeySelection2_A8369;

		// Token: 0x0400600B RID: 24587
		internal global::AcpUI.AcpComboBox CnvPerSecureKeySelection2_A8369;

		// Token: 0x0400600C RID: 24588
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureKeySelection2_A8369;

		// Token: 0x0400600D RID: 24589
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureKeySelection2_A8369;

		// Token: 0x0400600E RID: 24590
		internal global::AcpUI.AcpLabel CnvPerSecureKeySelection2_A8369Comp;

		// Token: 0x0400600F RID: 24591
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerIgnoreRxClearVoice_A41617;

		// Token: 0x04006010 RID: 24592
		internal global::AcpUI.AcpLabel LblCnvPerIgnoreRxClearVoice_A41617;

		// Token: 0x04006011 RID: 24593
		internal global::AcpUI.AcpCheckBox CnvPerIgnoreRxClearVoice_A41617;

		// Token: 0x04006012 RID: 24594
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerIgnoreRxClearVoice_A41617;

		// Token: 0x04006013 RID: 24595
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerIgnoreRxClearVoice_A41617;

		// Token: 0x04006014 RID: 24596
		internal global::AcpUI.AcpCheckBox CnvPerIgnoreRxClearVoice_A41617Comp;

		// Token: 0x04006015 RID: 24597
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySecurePacketData;

		// Token: 0x04006016 RID: 24598
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x04006017 RID: 24599
		internal global::AcpUI.AcpLabel LblCnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x04006018 RID: 24600
		internal global::AcpUI.AcpComboBox CnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x04006019 RID: 24601
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x0400601A RID: 24602
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x0400601B RID: 24603
		internal global::AcpUI.AcpLabel CnvPerSecureSecureClearStrapping2_A9091Comp;

		// Token: 0x0400601C RID: 24604
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureKeySelection1_A8368;

		// Token: 0x0400601D RID: 24605
		internal global::AcpUI.AcpLabel LblCnvPerSecureKeySelection1_A8368;

		// Token: 0x0400601E RID: 24606
		internal global::AcpUI.AcpComboBox CnvPerSecureKeySelection1_A8368;

		// Token: 0x0400601F RID: 24607
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureKeySelection1_A8368;

		// Token: 0x04006020 RID: 24608
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureKeySelection1_A8368;

		// Token: 0x04006021 RID: 24609
		internal global::AcpUI.AcpLabel CnvPerSecureKeySelection1_A8368Comp;

		// Token: 0x04006022 RID: 24610
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x04006023 RID: 24611
		internal global::AcpUI.AcpLabel LblCnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x04006024 RID: 24612
		internal global::AcpUI.AcpCheckBox CnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x04006025 RID: 24613
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x04006026 RID: 24614
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x04006027 RID: 24615
		internal global::AcpUI.AcpCheckBox CnvPerSecureIgnoreRxClearPacketData_A19310Comp;

		// Token: 0x04006028 RID: 24616
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalitySecurePseudo2;

		// Token: 0x04006029 RID: 24617
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureProperCodeDetect_A8762;

		// Token: 0x0400602A RID: 24618
		internal global::AcpUI.AcpLabel LblCnvPerSecureProperCodeDetect_A8762;

		// Token: 0x0400602B RID: 24619
		internal global::AcpUI.AcpCheckBox CnvPerSecureProperCodeDetect_A8762;

		// Token: 0x0400602C RID: 24620
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureProperCodeDetect_A8762;

		// Token: 0x0400602D RID: 24621
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureProperCodeDetect_A8762;

		// Token: 0x0400602E RID: 24622
		internal global::AcpUI.AcpCheckBox CnvPerSecureProperCodeDetect_A8762Comp;

		// Token: 0x0400602F RID: 24623
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureBroadbandASTROOTAR;

		// Token: 0x04006030 RID: 24624
		internal global::AcpUI.AcpLabel LblCnvPerSecureBroadbandASTROOTAR;

		// Token: 0x04006031 RID: 24625
		internal global::AcpUI.AcpCheckBox CnvPerSecureBroadbandASTROOTAR;

		// Token: 0x04006032 RID: 24626
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureBroadbandASTROOTAR;

		// Token: 0x04006033 RID: 24627
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureBroadbandASTROOTAR;

		// Token: 0x04006034 RID: 24628
		internal global::AcpUI.AcpCheckBox CnvPerSecureBroadbandASTROOTARComp;

		// Token: 0x04006035 RID: 24629
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureOTARTx_A8675;

		// Token: 0x04006036 RID: 24630
		internal global::AcpUI.AcpLabel LblCnvPerSecureOTARTx_A8675;

		// Token: 0x04006037 RID: 24631
		internal global::AcpUI.AcpCheckBox CnvPerSecureOTARTx_A8675;

		// Token: 0x04006038 RID: 24632
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureOTARTx_A8675;

		// Token: 0x04006039 RID: 24633
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureOTARTx_A8675;

		// Token: 0x0400603A RID: 24634
		internal global::AcpUI.AcpCheckBox CnvPerSecureOTARTx_A8675Comp;

		// Token: 0x0400603B RID: 24635
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureASTROOTAR_A7493;

		// Token: 0x0400603C RID: 24636
		internal global::AcpUI.AcpLabel LblCnvPerSecureASTROOTAR_A7493;

		// Token: 0x0400603D RID: 24637
		internal global::AcpUI.AcpCheckBox CnvPerSecureASTROOTAR_A7493;

		// Token: 0x0400603E RID: 24638
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureASTROOTAR_A7493;

		// Token: 0x0400603F RID: 24639
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureASTROOTAR_A7493;

		// Token: 0x04006040 RID: 24640
		internal global::AcpUI.AcpCheckBox CnvPerSecureASTROOTAR_A7493Comp;

		// Token: 0x04006041 RID: 24641
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x04006042 RID: 24642
		internal global::AcpUI.AcpLabel LblCnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x04006043 RID: 24643
		internal global::AcpUI.AcpComboBox CnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x04006044 RID: 24644
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x04006045 RID: 24645
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x04006046 RID: 24646
		internal global::AcpUI.AcpLabel CnvPerSecureKMFProfileIndex_A8381Comp;

		// Token: 0x04006047 RID: 24647
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x04006048 RID: 24648
		internal global::AcpUI.AcpLabel LblCnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x04006049 RID: 24649
		internal global::AcpUI.AcpTextBoxSpinner CnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x0400604A RID: 24650
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x0400604B RID: 24651
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x0400604C RID: 24652
		internal global::AcpUI.AcpLabel CnvPerSecureEchoMuteTimems_A7919Comp;

		// Token: 0x0400604D RID: 24653
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureScanSelect_A9056;

		// Token: 0x0400604E RID: 24654
		internal global::AcpUI.AcpLabel LblCnvPerSecureScanSelect_A9056;

		// Token: 0x0400604F RID: 24655
		internal global::AcpUI.AcpComboBox CnvPerSecureScanSelect_A9056;

		// Token: 0x04006050 RID: 24656
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureScanSelect_A9056;

		// Token: 0x04006051 RID: 24657
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureScanSelect_A9056;

		// Token: 0x04006052 RID: 24658
		internal global::AcpUI.AcpLabel CnvPerSecureScanSelect_A9056Comp;

		// Token: 0x04006053 RID: 24659
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x04006054 RID: 24660
		internal global::AcpUI.AcpLabel LblCnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x04006055 RID: 24661
		internal global::AcpUI.AcpComboBox CnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x04006056 RID: 24662
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x04006057 RID: 24663
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x04006058 RID: 24664
		internal global::AcpUI.AcpLabel CnvPerSecureScanHoldoffStrapping_A9050Comp;

		// Token: 0x04006059 RID: 24665
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureKeyID_A8361;

		// Token: 0x0400605A RID: 24666
		internal global::AcpUI.AcpLabel LblCnvPerSecureKeyID_A8361;

		// Token: 0x0400605B RID: 24667
		internal global::AcpUI.AcpComboBox CnvPerSecureKeyID_A8361;

		// Token: 0x0400605C RID: 24668
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureKeyID_A8361;

		// Token: 0x0400605D RID: 24669
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureKeyID_A8361;

		// Token: 0x0400605E RID: 24670
		internal global::AcpUI.AcpLabel CnvPerSecureKeyID_A8361Comp;

		// Token: 0x0400605F RID: 24671
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x04006060 RID: 24672
		internal global::AcpUI.AcpLabel LblCnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x04006061 RID: 24673
		internal global::AcpUI.AcpTextBoxSpinner CnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x04006062 RID: 24674
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x04006063 RID: 24675
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x04006064 RID: 24676
		internal global::AcpUI.AcpLabel CnvPerSecureXLDelayFollowingKeyID_A9680Comp;

		// Token: 0x04006065 RID: 24677
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityAdvanced;

		// Token: 0x04006066 RID: 24678
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityAdvancedPseudo0;

		// Token: 0x04006067 RID: 24679
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x04006068 RID: 24680
		internal global::AcpUI.AcpLabel LblCnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x04006069 RID: 24681
		internal global::AcpUI.AcpComboBox CnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x0400606A RID: 24682
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x0400606B RID: 24683
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x0400606C RID: 24684
		internal global::AcpUI.AcpLabel CnvPerAdvancedAdvancedRFAGC_A7408Comp;

		// Token: 0x0400606D RID: 24685
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x0400606E RID: 24686
		internal global::AcpUI.AcpLabel LblCnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x0400606F RID: 24687
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x04006070 RID: 24688
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x04006071 RID: 24689
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x04006072 RID: 24690
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedSecondLOSideInjection_A9063Comp;

		// Token: 0x04006073 RID: 24691
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04006074 RID: 24692
		internal global::AcpUI.AcpLabel LblCnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04006075 RID: 24693
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04006076 RID: 24694
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04006077 RID: 24695
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04006078 RID: 24696
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedAnalogFlatAudio_A7443Comp;

		// Token: 0x04006079 RID: 24697
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x0400607A RID: 24698
		internal global::AcpUI.AcpLabel LblCnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x0400607B RID: 24699
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x0400607C RID: 24700
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x0400607D RID: 24701
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x0400607E RID: 24702
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedDisableHighPassFilter_A7864Comp;

		// Token: 0x0400607F RID: 24703
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04006080 RID: 24704
		internal global::AcpUI.AcpLabel LblCnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04006081 RID: 24705
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04006082 RID: 24706
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04006083 RID: 24707
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04006084 RID: 24708
		internal global::AcpUI.AcpCheckBox CnvPerAdvancedAnalogWidebandData_A1994Comp;

		// Token: 0x04006085 RID: 24709
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerAdvanceBroadbandProtection;

		// Token: 0x04006086 RID: 24710
		internal global::AcpUI.AcpLabel LblCnvPerAdvanceBroadbandProtection;

		// Token: 0x04006087 RID: 24711
		internal global::AcpUI.AcpCheckBox CnvPerAdvanceBroadbandProtection;

		// Token: 0x04006088 RID: 24712
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerAdvanceBroadbandProtection;

		// Token: 0x04006089 RID: 24713
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerAdvanceBroadbandProtection;

		// Token: 0x0400608A RID: 24714
		internal global::AcpUI.AcpCheckBox CnvPerAdvanceBroadbandProtectionComp;

		// Token: 0x0400608B RID: 24715
		internal global::AcpUI.AcpExpander ExpanderConventionalPersonalityLabtool;

		// Token: 0x0400608C RID: 24716
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalPersonalityLabtoolPseudo0;

		// Token: 0x0400608D RID: 24717
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConPerMDCRunMDCDemodulator_A8494;

		// Token: 0x0400608E RID: 24718
		internal global::AcpUI.AcpLabel LblConPerMDCRunMDCDemodulator_A8494;

		// Token: 0x0400608F RID: 24719
		internal global::AcpUI.AcpCheckBox ConPerMDCRunMDCDemodulator_A8494;

		// Token: 0x04006090 RID: 24720
		internal global::AcpUI.AcpRtdButton RTDBtnConPerMDCRunMDCDemodulator_A8494;

		// Token: 0x04006091 RID: 24721
		internal global::AcpUI.AcpCopyButton CpyBtnConPerMDCRunMDCDemodulator_A8494;

		// Token: 0x04006092 RID: 24722
		internal global::AcpUI.AcpCheckBox ConPerMDCRunMDCDemodulator_A8494Comp;

		// Token: 0x04006093 RID: 24723
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolSyncMode_A19308;

		// Token: 0x04006094 RID: 24724
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolSyncMode_A19308;

		// Token: 0x04006095 RID: 24725
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolSyncMode_A19308;

		// Token: 0x04006096 RID: 24726
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolSyncMode_A19308;

		// Token: 0x04006097 RID: 24727
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolSyncMode_A19308;

		// Token: 0x04006098 RID: 24728
		internal global::AcpUI.AcpCheckBox CnvPerLabtoolSyncMode_A19308Comp;

		// Token: 0x04006099 RID: 24729
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;

		// Token: 0x0400609A RID: 24730
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;

		// Token: 0x0400609B RID: 24731
		internal global::AcpUI.AcpComboBox CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;

		// Token: 0x0400609C RID: 24732
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;

		// Token: 0x0400609D RID: 24733
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;

		// Token: 0x0400609E RID: 24734
		internal global::AcpUI.AcpLabel CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630Comp;

		// Token: 0x0400609F RID: 24735
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040060A0 RID: 24736
		internal global::AcpUI.AcpLabel LblCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040060A1 RID: 24737
		internal global::AcpUI.AcpComboBox CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040060A2 RID: 24738
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040060A3 RID: 24739
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040060A4 RID: 24740
		internal global::AcpUI.AcpLabel CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474Comp;

		// Token: 0x040060A5 RID: 24741
		private bool b;
	}
}
