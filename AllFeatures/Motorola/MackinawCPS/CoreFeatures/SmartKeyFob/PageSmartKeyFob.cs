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

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CC RID: 716
	public class PageSmartKeyFob : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06007710 RID: 30480 RVA: 0x006BABA8 File Offset: 0x006B8DA8
		public PageSmartKeyFob()
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

		// Token: 0x06007711 RID: 30481 RVA: 0x006BABE0 File Offset: 0x006B8DE0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2138243072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1374289923;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_14C;
					case 1:
						try
						{
							num = (short)1736966147;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)1284046853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1119485956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)459210752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1F7;
									}
									continue;
								case 4:
									goto IL_2B4;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1427963905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)591986690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F9:
								num = (short)788398086;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F7:
								goto IL_1F9;
							}
							IL_2B4:
							goto IL_124;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2D6;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C3:
								switch (num2)
								{
								case 0:
									goto IL_379;
								case 1:
									disposable.Dispose();
									num = (short)1476329472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)2021459707;
									short num3 = num;
									num = (short)1970800379;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_37B;
									default:
										num = (short)1326710784;
										if (num != 0)
										{
										}
										if (disposable != null)
										{
											num = (short)1537212417;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_37B;
									}
									break;
								}
								}
								goto IL_2D6;
							}
							IL_379:
							IL_37B:
							goto EndFinally_8;
							IL_2D6:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)894238722;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2C3;
							EndFinally_8:;
						}
						goto IL_37C;
						IL_124:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1919221760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.MyDataPresenter = this.ExpanderSmartKeyFobSmartKeyFobButtonTable;
						num = (short)2098724868;
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
						num = (short)62652417;
						if (num != 0)
						{
						}
						goto IL_AC;
					case 5:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1127219202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 6:
					{
						object obj = null;
						obj = this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.MyRecordsetDataSource;
						num = (short)1147207685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_60:
					if (!this.a)
					{
						num = (short)1879048192;
						short num4 = num;
						num = (short)429916166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AC:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1407123457;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14C:
				IL_37C:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x006BAF9C File Offset: 0x006B919C
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
				{
					num2 = (short)390529024;
					short num3 = num2;
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)18415616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)1966178603;
					short num4 = num2;
					num2 = (short)1045856555;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)173867008;
						if (num2 != 0)
						{
						}
						if (this.a)
						{
							num2 = (short)119144449;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.DataContext = null;
			this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.MyDataPresenter = null;
			num2 = (short)220921857;
			if (num2 != 0)
			{
			}
			num2 = (short)619511810;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x006BB0D8 File Offset: 0x006B92D8
		public override void SetDataContext()
		{
			short num = (short)2128936971;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (feature != null)
					{
						num = (short)1648885766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)369220589;
					short num3 = num;
					num = (short)188996589;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						goto IL_2A7;
					}
					break;
				}
				case 2:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4130);
					num = (short)1509687296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10747] != null)
					{
						num = (short)1557725191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10747].EmbeddedRecset != null)
					{
						num = (short)847249422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)8454146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable).MySecondaryRecordsetDataSource = null;
					num = (short)1292632065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_D9;
				case 7:
					num = (short)1362493444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4130);
					num = (short)920453133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)1383399424;
					short num4 = num;
					goto IL_30B;
				}
				case 10:
					num = (short)1396506627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)609222666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
					goto IL_30B;
				case 14:
					goto IL_D4;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1889009672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4130);
				num = (short)259260425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D9:
				num = (short)1678573580;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30B:
				num = (short)26804229;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			num = (short)487718913;
			if (num != 0)
			{
			}
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10747].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable).SyncDataSources();
			return;
			IL_2A7:
			num = (short)1724841984;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x006BB430 File Offset: 0x006B9630
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)1320878088;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰ꃲ飴零诸迺뛼髾砀䔂樄攆娈昊氌紎攐堒瀔渖弘琚缜崞吠圢儤䠦䜨缪䰬䴮崰嘲", a_))
					{
						num = (short)1988493312;
						short num3 = num;
						num = (short)14483462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.MyRecordsetDataSource;
					num = (short)1221722114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1584726019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_112;
				case 4:
					return;
				case 5:
					num = (short)473563136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)205193223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)140771329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)2066351645;
					short num4 = num;
					num = (short)653198877;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						num = (short)567869440;
						if (num != 0)
						{
						}
						num = (short)255066116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				}
				IL_51:
				if (!(A_0 is global::AcpUI.AcpRecNavToolbar))
				{
					return;
				}
				num = (short)1382285317;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_75:
			num = (short)1473576961;
			if (num != 0)
			{
			}
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
			return;
			IL_112:
			goto IL_75;
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x006BB684 File Offset: 0x006B9884
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1244416404;
			short num2 = num;
			num = (short)1599752596;
			switch (num2 == num)
			{
			default:
			{
				num = (short)772997120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)841023489;
			if (num != 0)
			{
			}
			num = (short)951451648;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x006BB738 File Offset: 0x006B9938
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1176271381;
			short num2 = num;
			num = (short)708672021;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2113470464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)684589057;
			if (num != 0)
			{
			}
			num = (short)267255808;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x006BB7EC File Offset: 0x006B99EC
		internal void OnExpanderSmartKeyFobSmartKeyFobButtonTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_152;
				case 1:
				{
					object myRecordsetDataSource;
					global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner item;
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.SyncDataSources();
					num2 = (short)270860288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)2109865985;
					if (num2 != 0)
					{
					}
					object myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1053556737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_154;
				}
				}
				goto IL_1C;
			}
			IL_152:
			goto IL_154;
			IL_1C:
			num2 = (short)391437410;
			short num3 = num2;
			num2 = (short)1920588898;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_154:
				this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.TableMode = false;
				return;
			default:
			{
				num2 = (short)531693568;
				if (num2 != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				object myRecordsetDataSource = this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.MyRecordsetDataSource;
				num2 = (short)1915813888;
				short num4 = num2;
				num2 = (short)1355218946;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x006BB95C File Offset: 0x006B9B5C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			if (!this.b)
			{
				short num = (short)727979649;
				short num2 = num;
				num = (short)1866667649;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1238695937;
					if (num != 0)
					{
					}
					num = (short)1562181632;
					if (num != 0)
					{
					}
					num = (short)1060896768;
					short num3 = num;
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4蓦蛨蛪鷬胮鿰雲鯴菶훸觺鳼鯾栀氂\u2004㔆㤈渊缌栎縐紒稔稖瀘砚渜㨞ጠጢ䘤䠦䜨䴪䐬䠮䐰䄲吴䌶倸吺匼ှ≀ⱂ⭄㍆㭈⑊⅌㱎繐⁒㡔㙖⭘⽚硜浞兠ࡢdṦ䱨奪嵬८Ṱᅲ婴Ѷᑸོ᩺୾ﲄꎌﺒ璉", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x006BBA3C File Offset: 0x006B9C3C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)132644866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_28D;
				case 1:
					num = (short)1607204864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
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
					goto IL_3C8;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					goto IL_621;
				case 8:
					goto IL_447;
				case 9:
					goto IL_5D6;
				case 10:
					goto IL_488;
				case 11:
					goto IL_43A;
				case 12:
					goto IL_46E;
				case 13:
					goto IL_1DF;
				case 14:
					goto IL_29F;
				case 15:
					goto IL_574;
				case 16:
					goto IL_292;
				case 17:
					goto IL_1C5;
				case 18:
					goto IL_34C;
				case 19:
					goto IL_22A;
				case 20:
					goto IL_38A;
				case 21:
					goto IL_2C3;
				case 22:
					goto IL_397;
				case 23:
					goto IL_33F;
				case 24:
					goto IL_37D;
				case 25:
					goto IL_461;
				case 26:
					goto IL_4AC;
				case 27:
					goto IL_2F7;
				case 28:
					goto IL_2EA;
				case 29:
					goto IL_251;
				case 30:
					goto IL_406;
				case 31:
					goto IL_420;
				case 32:
					goto IL_4C6;
				case 33:
					goto IL_58E;
				case 34:
					goto IL_3F9;
				case 35:
					goto IL_3A4;
				case 36:
					goto IL_614;
				case 37:
					goto IL_1B8;
				case 38:
					goto IL_21D;
				case 39:
					goto IL_5B2;
				case 40:
					goto IL_581;
				case 41:
					goto IL_31B;
				case 42:
					goto IL_607;
				case 43:
					goto IL_4B9;
				case 44:
					goto IL_1EC;
				case 45:
					goto IL_194;
				case 46:
					goto IL_53F;
				case 47:
					goto IL_4F7;
				case 48:
					goto IL_413;
				case 49:
					goto IL_2DD;
				case 50:
					goto IL_47B;
				case 51:
					goto IL_359;
				case 52:
					goto IL_1D2;
				case 53:
					goto IL_4D3;
				case 54:
					goto IL_237;
				case 55:
					goto IL_2D0;
				case 56:
					goto IL_42D;
				case 57:
					goto IL_1F9;
				case 58:
					goto IL_454;
				case 59:
					goto IL_51B;
				case 60:
					goto IL_244;
				case 61:
					goto IL_5FA;
				default:
				{
					num = (short)248812297;
					short num3 = num;
					num = (short)1217303305;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43A;
					default:
						num = (short)1058734080;
						if (num != 0)
						{
						}
						num = (short)623247361;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_194:
			this.RadErgoCfgFobTrunkingBCO_A41578 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgFobTrunkingBCO_A41578.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B8:
			this.CpyBtnRadErgoCfgFobConventionalBCO_A41577 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C5:
			this.ExpanderSmartKeyFobSmartKeyFobButtonTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1D2:
			this.CVBtnRadErgoCfgFobTrunkingFeature_A41575 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DF:
			this.ExpanderSmartKeyFobGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_1EC:
			this.RadErgoCfgFobConventionalFeature_A41574Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F9:
			this.RadErgoCfgSmartKeyFobButtonKey_A41579 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgSmartKeyFobButtonKey_A41579.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_21D:
			this.RadErgoCfgFobConventionalBCO_A41577Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22A:
			this.RadErgoCfgFobButtonName_A41573_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_237:
			this.RTDBtnRadErgoCfgFobTrunkingFeature_A41575 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_244:
			this.CpyBtnRadErgoCfgSmartKeyFobButtonKey_A41579 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_251:
			this.LblRadErgoCfgFobButtonName_A41573 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgFobButtonName_A41573.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28D:
			goto IL_621;
			IL_292:
			this.ExpanderSmartKeyFobSmartKeyFobButtonTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_29F:
			this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable.ModeClick += this.OnModeClick;
			return;
			IL_2C3:
			this.RadErgoCfgFobConventionalFeature_A41574_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2D0:
			this.CpyBtnRadErgoCfgFobTrunkingFeature_A41575 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DD:
			this.CpyBtnRadErgoCfgFobTrunkingBCO_A41578 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2EA:
			this.CVBtnRadErgoCfgFobButtonName_A41573 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F7:
			this.RadErgoCfgFobButtonName_A41573 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgFobButtonName_A41573.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31B:
			this.LblRadErgoCfgFobConventionalFeature_A41574 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgFobConventionalFeature_A41574.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33F:
			this.RadErgoCfgFobTrunkingFeature_A41575_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_34C:
			this.ExpanderSmartKeyFobSmartKeyFobButtonTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_359:
			this.RadErgoCfgFobTrunkingFeature_A41575 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgFobTrunkingFeature_A41575.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37D:
			this.RadErgoCfgSmartKeyFobButtonKey_A41579_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_38A:
			this.RadErgoCfgFobConventionalBCO_A41577_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_397:
			this.RadErgoCfgFobTrunkingBCO_A41578_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3A4:
			this.LblRadErgoCfgFobConventionalBCO_A41577 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgFobConventionalBCO_A41577.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C8:
			((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.PageSmartKeyFob)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.PageSmartKeyFob)target).Unloaded += this.OnUnloaded;
			return;
			IL_3F9:
			this.CVBtnRadErgoCfgFobConventionalBCO_A41577 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_406:
			this.RTDBtnRadErgoCfgFobButtonName_A41573 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_413:
			this.RTDBtnRadErgoCfgFobTrunkingBCO_A41578 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_420:
			this.CpyBtnRadErgoCfgFobButtonName_A41573 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42D:
			this.RadErgoCfgFobTrunkingFeature_A41575Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43A:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_447:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_454:
			this.CVBtnRadErgoCfgSmartKeyFobButtonKey_A41579 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_461:
			this.ExpanderSmartKeyFobSmartKeyFobButtonTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_46E:
			this.ExpanderSmartKeyFobGraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_47B:
			this.RadErgoCfgFobTrunkingBCO_A41578Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_488:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_4AC:
			this.gridExpanderSmartKeyFobSmartKeyFobButtonTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4B9:
			this.CpyBtnRadErgoCfgFobConventionalFeature_A41574 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C6:
			this.RadErgoCfgFobButtonName_A41573Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D3:
			this.LblRadErgoCfgFobTrunkingFeature_A41575 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgFobTrunkingFeature_A41575.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F7:
			this.LblRadErgoCfgFobTrunkingBCO_A41578 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgFobTrunkingBCO_A41578.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51B:
			this.LblRadErgoCfgSmartKeyFobButtonKey_A41579 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSmartKeyFobButtonKey_A41579.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53F:
			num = (short)188416001;
			if (num != 0)
			{
			}
			this.CVBtnRadErgoCfgFobTrunkingBCO_A41578 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_574:
			this.ExpanderSmartKeyFobGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_581:
			this.CVBtnRadErgoCfgFobConventionalFeature_A41574 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_58E:
			this.RadErgoCfgFobConventionalBCO_A41577 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgFobConventionalBCO_A41577.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B2:
			this.RadErgoCfgFobConventionalFeature_A41574 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgFobConventionalFeature_A41574.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D6:
			this.HLinkSmartKeyFobGraphicView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSmartKeyFobGraphicView.Click += this.HLinkClick;
			return;
			IL_5FA:
			this.RadErgoCfgSmartKeyFobButtonKey_A41579Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_607:
			this.RTDBtnRadErgoCfgFobConventionalFeature_A41574 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_614:
			this.RTDBtnRadErgoCfgFobConventionalBCO_A41577 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_621:
			num = (short)333905920;
			short num4 = num;
			this.b = true;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x006BC09C File Offset: 0x006BA29C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)340328449;
			if (num != 0)
			{
			}
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
			{
				num = (short)1682374656;
				short num2 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				break;
			default:
			{
				num = (short)2121155984;
				short num3 = num;
				num = (short)1517241744;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)554631168;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400317D RID: 12669
		private bool a;

		// Token: 0x0400317E RID: 12670
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400317F RID: 12671
		internal global::System.Windows.Documents.Hyperlink HLinkSmartKeyFobGraphicView;

		// Token: 0x04003180 RID: 12672
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04003181 RID: 12673
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04003182 RID: 12674
		internal global::AcpUI.AcpExpander ExpanderSmartKeyFobGraphicalView;

		// Token: 0x04003183 RID: 12675
		internal global::AcpUI.AcpExpander ExpanderSmartKeyFobGeneral;

		// Token: 0x04003184 RID: 12676
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSmartKeyFobSmartKeyFobButtonTable;

		// Token: 0x04003185 RID: 12677
		internal global::System.Windows.Controls.Grid ExpanderSmartKeyFobGeneralGrid;

		// Token: 0x04003186 RID: 12678
		internal global::System.Windows.Controls.Grid ExpanderSmartKeyFobSmartKeyFobButtonTableGrid;

		// Token: 0x04003187 RID: 12679
		internal global::AcpUI.AcpGroupBox ExpanderSmartKeyFobSmartKeyFobButtonTableTableView;

		// Token: 0x04003188 RID: 12680
		internal global::AcpUI.AcpXamDataPresenter ExpanderSmartKeyFobSmartKeyFobButtonTable;

		// Token: 0x04003189 RID: 12681
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgFobButtonName_A41573_Col;

		// Token: 0x0400318A RID: 12682
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgFobConventionalBCO_A41577_Col;

		// Token: 0x0400318B RID: 12683
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgFobConventionalFeature_A41574_Col;

		// Token: 0x0400318C RID: 12684
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgFobTrunkingBCO_A41578_Col;

		// Token: 0x0400318D RID: 12685
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgFobTrunkingFeature_A41575_Col;

		// Token: 0x0400318E RID: 12686
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSmartKeyFobButtonKey_A41579_Col;

		// Token: 0x0400318F RID: 12687
		internal global::AcpUI.AcpGroupBox ExpanderSmartKeyFobSmartKeyFobButtonTableSRecView;

		// Token: 0x04003190 RID: 12688
		internal global::System.Windows.Controls.Grid gridExpanderSmartKeyFobSmartKeyFobButtonTableSRecView;

		// Token: 0x04003191 RID: 12689
		internal global::AcpUI.AcpLabel RadErgoCfgFobButtonName_A41573;

		// Token: 0x04003192 RID: 12690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgFobButtonName_A41573;

		// Token: 0x04003193 RID: 12691
		internal global::AcpUI.AcpLabel LblRadErgoCfgFobButtonName_A41573;

		// Token: 0x04003194 RID: 12692
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgFobButtonName_A41573;

		// Token: 0x04003195 RID: 12693
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgFobButtonName_A41573;

		// Token: 0x04003196 RID: 12694
		internal global::AcpUI.AcpLabel RadErgoCfgFobButtonName_A41573Comp;

		// Token: 0x04003197 RID: 12695
		internal global::AcpUI.AcpComboBox RadErgoCfgFobConventionalBCO_A41577;

		// Token: 0x04003198 RID: 12696
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgFobConventionalBCO_A41577;

		// Token: 0x04003199 RID: 12697
		internal global::AcpUI.AcpLabel LblRadErgoCfgFobConventionalBCO_A41577;

		// Token: 0x0400319A RID: 12698
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgFobConventionalBCO_A41577;

		// Token: 0x0400319B RID: 12699
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgFobConventionalBCO_A41577;

		// Token: 0x0400319C RID: 12700
		internal global::AcpUI.AcpLabel RadErgoCfgFobConventionalBCO_A41577Comp;

		// Token: 0x0400319D RID: 12701
		internal global::AcpUI.AcpComboBox RadErgoCfgFobConventionalFeature_A41574;

		// Token: 0x0400319E RID: 12702
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgFobConventionalFeature_A41574;

		// Token: 0x0400319F RID: 12703
		internal global::AcpUI.AcpLabel LblRadErgoCfgFobConventionalFeature_A41574;

		// Token: 0x040031A0 RID: 12704
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgFobConventionalFeature_A41574;

		// Token: 0x040031A1 RID: 12705
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgFobConventionalFeature_A41574;

		// Token: 0x040031A2 RID: 12706
		internal global::AcpUI.AcpLabel RadErgoCfgFobConventionalFeature_A41574Comp;

		// Token: 0x040031A3 RID: 12707
		internal global::AcpUI.AcpComboBox RadErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031A4 RID: 12708
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031A5 RID: 12709
		internal global::AcpUI.AcpLabel LblRadErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031A6 RID: 12710
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031A7 RID: 12711
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031A8 RID: 12712
		internal global::AcpUI.AcpLabel RadErgoCfgFobTrunkingBCO_A41578Comp;

		// Token: 0x040031A9 RID: 12713
		internal global::AcpUI.AcpComboBox RadErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031AA RID: 12714
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031AB RID: 12715
		internal global::AcpUI.AcpLabel LblRadErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031AC RID: 12716
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031AD RID: 12717
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031AE RID: 12718
		internal global::AcpUI.AcpLabel RadErgoCfgFobTrunkingFeature_A41575Comp;

		// Token: 0x040031AF RID: 12719
		internal global::AcpUI.AcpTextBox RadErgoCfgSmartKeyFobButtonKey_A41579;

		// Token: 0x040031B0 RID: 12720
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSmartKeyFobButtonKey_A41579;

		// Token: 0x040031B1 RID: 12721
		internal global::AcpUI.AcpLabel LblRadErgoCfgSmartKeyFobButtonKey_A41579;

		// Token: 0x040031B2 RID: 12722
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSmartKeyFobButtonKey_A41579;

		// Token: 0x040031B3 RID: 12723
		internal global::AcpUI.AcpLabel RadErgoCfgSmartKeyFobButtonKey_A41579Comp;

		// Token: 0x040031B4 RID: 12724
		private bool b;
	}
}
