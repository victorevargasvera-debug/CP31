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

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000241 RID: 577
	public class PageRadioErgonomicsWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060067F9 RID: 26617 RVA: 0x005CD5F8 File Offset: 0x005CB7F8
		public PageRadioErgonomicsWide()
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

		// Token: 0x060067FA RID: 26618 RVA: 0x005CD630 File Offset: 0x005CB830
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1767243776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)160956424;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_371;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.MyDataPresenter = this.ExpanderRadioErgonomicsWideAuxControlTable;
						num = (short)2019229705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_263;
					case 3:
						if (obj != null)
						{
							num = (short)102957057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_448;
					case 4:
						try
						{
							num = (short)795410436;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_199;
								case 2:
									base.Expanders.Add(acpExpander);
									num = (short)1155858433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (acpExpander != null)
									{
										num = (short)9764866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_DE;
									}
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)2009464838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1541210115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1192755200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E0:
								num = (short)978452485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DE:
								goto IL_E0;
							}
							IL_199:
							goto IL_3A2;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_206;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1A8:
								num = (short)1906289055;
								short num3 = num;
								num = (short)1631889823;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)2123759616;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_260;
									case 1:
										if (disposable != null)
										{
											num = (short)106823682;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_262;
									case 2:
										goto IL_23F;
									}
									goto IL_206;
								}
								IL_23F:
								disposable.Dispose();
								num = (short)1489043456;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_260:
							IL_262:
							goto EndFinally_10;
							IL_206:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)948174849;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A8;
							EndFinally_10:;
						}
						goto IL_263;
						IL_3A2:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)716374022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (obj != null)
						{
							num = (short)1285292034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_371;
					case 6:
						goto IL_3C9;
					case 7:
						if (obj != null)
						{
							num = (short)1094713344;
							short num4 = num;
							num = (short)750059532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_405;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 9:
						goto IL_448;
					case 10:
						obj = null;
						obj = this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.MyRecordsetDataSource;
						num = (short)1321926663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_405;
					case 12:
					{
						num = (short)30146561;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.MyDataPresenter = this.ExpanderRadioErgonomicsWideControlHeadAliasList;
						num = (short)446365707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_77:
					if (!this.a)
					{
						num = (short)1287782410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_263:
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.MyDataPresenter = this.ExpanderRadioErgonomicsWidePresetZoneAndChannelTable;
					num = (short)190119936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_371:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1361969156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_405:
					obj = this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.MyRecordsetDataSource;
					num = (short)2066415619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_448:
					obj = this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.MyRecordsetDataSource;
					num = (short)664469509;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3C9:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x005CDB00 File Offset: 0x005CBD00
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)2123792704;
				short num2 = num;
				num = (short)1686667584;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_110;
				case 1:
					break;
				default:
				{
					num = (short)1082916864;
					short num3 = num;
					break;
				}
				}
				num = (short)1365704704;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					return;
				case 1:
					if (this.a)
					{
						num = (short)1266614274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					IL_110:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1412038657;
					if (num != 0)
					{
					}
					num = (short)313065472;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_91;
			}
			return;
			IL_91:
			this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.DataContext = null;
			this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.DataContext = null;
			this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.DataContext = null;
			this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.MyDataPresenter = null;
			num = (short)1628372993;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x005CDC70 File Offset: 0x005CBE70
		public override void SetDataContext()
		{
			short num = (short)1837760534;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)656211973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10223].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList).SyncDataSources();
					num = (short)667615261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10223].EmbeddedRecset != null)
					{
						num = (short)61276161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_658;
				case 3:
					num = (short)1015414811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2082603018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10633].EmbeddedRecset != null)
					{
						num = (short)2131820552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 6:
					goto IL_23C;
				case 7:
					goto IL_D0;
				case 8:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10633].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable).SyncDataSources();
					num = (short)1308622855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10640] != null)
					{
						num = (short)38469648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10633] != null)
					{
						num = (short)558563328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 11:
					return;
				case 12:
					if (feature != null)
					{
						num = (short)850198553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 13:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2033);
					num = (short)1373306898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_23C;
				case 15:
					goto IL_4BD;
				case 16:
					num = (short)998375445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)748093463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 18:
				{
					num = (short)1879195727;
					short num3 = num;
					num = (short)240009295;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4BD;
					default:
						num = (short)1449263104;
						if (num != 0)
						{
						}
						if (feature != null)
						{
							num = (short)1021247491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					}
					break;
				}
				case 19:
					goto IL_3D7;
				case 20:
					if (feature != null)
					{
						num = (short)938541086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10640].EmbeddedRecset != null)
					{
						num = (short)26804243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					continue;
				case 23:
					num = (short)1680539657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1334575106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)1845100576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					num = (short)603521039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1592131610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_658;
				case 28:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2033);
					num = (short)1503199246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_658;
				case 30:
				{
					num = (short)566034432;
					short num4 = num;
					num = (short)849870865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 31:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)556990477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable).MySecondaryRecordsetDataSource = null;
					num = (short)690159627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1133641732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				}
				IL_A8:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)77660188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)886308865;
				if (num != 0)
				{
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2033);
				num = (short)987627526;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0:
				num = (short)495910932;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23C:
				num = (short)1778974751;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BD:
				if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10223] != null)
				{
					num = (short)1237516312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_658:
				num = (short)964558860;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3D7:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10640].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable).SyncDataSources();
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x005CE310 File Offset: 0x005CC510
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)421003264;
			switch (num)
			{
			default:
			{
				num = (short)1918959639;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙駛ꛝ郟菡諣若跧飩뻫迭铯鯱鯳돵諷鷹鏻都濿漁洃攅笇崉攋樍甏匑愓渕嬗甙爛樝刟䴡䠣爥䤧䠩䀫䬭", a_))
						{
							num = (short)929103893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 1:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.MyRecordsetDataSource;
						num = (short)450625538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)397934601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1105133572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_D8;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙駛ꛝ郟菡諣若跧飩뻫迭铯鯱鯳돵諷鷹鏻都濿漁洃攅笇崉攋樍甏儑笓砕気栙猛爝栟䜡䔣䈥椧䘩䔫伭䌯縱崳䔵䰷", a_))
						{
							num = (short)1220149258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D4;
					case 6:
						goto IL_D8;
					case 7:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)78839811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					}
					case 8:
						num = (short)1283915777;
						if (num != 0)
						{
						}
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("郁ꇃꗅ蛇ꯉ뫋髍뿏뷑룓듕맗꣙駛ꛝ郟菡諣若跧飩뻫迭铯鯱鯳돵諷鷹鏻都濿漁洃攅笇崉攋樍甏䈑易猕欗缙栛䐝伟䰡䄣朥䘧丩漫䘭儯就娳匵吷渹崻尽ⰿ❁", a_))
						{
							num = (short)1628110861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_246;
					case 10:
						num = (short)1377566737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)313131026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)110821382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1645674501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1666580496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return;
					case 15:
					{
						num = (short)181401572;
						short num3 = num;
						num = (short)851900388;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_43A;
						default:
							num = (short)929562624;
							if (num != 0)
							{
							}
							goto IL_4D4;
						}
						break;
					}
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							goto IL_43A;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)226230286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)339673107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)83230744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.MyRecordsetDataSource;
						num = (short)1973420039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)1388118016;
						short num4 = num;
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.MyRecordsetDataSource;
						num = (short)713818132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)301137942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D4;
					}
					case 21:
						num = (short)775421963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)757334031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 24:
						goto IL_4D4;
					}
					IL_B0:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)78512140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_D8:
					num = (short)320208904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					num = (short)719126529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D4:
					num = (short)244973568;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_246:
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner)collectionView3.CurrentItem;
				collectionView3.MoveCurrentTo(item3);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x005CE8A4 File Offset: 0x005CCAA4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)247136257;
			if (num != 0)
			{
			}
			num = (short)2026045440;
			short num2 = num;
			num = (short)317505662;
			short num3 = num;
			num = (short)2075377790;
			switch (num3 == num)
			{
			}
			num = (short)286326784;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x005CE954 File Offset: 0x005CCB54
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)156635159;
			short num2 = num;
			num = (short)1791954967;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1535115264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1093795840;
			if (num != 0)
			{
			}
			num = (short)738459649;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x005CEA00 File Offset: 0x005CCC00
		internal void OnExpanderRadioErgonomicsWideControlHeadAliasListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1142030336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12C;
				case 2:
				{
					num2 = (short)1660170921;
					short num3 = num2;
					num2 = (short)630076073;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_114;
					}
					break;
				}
				}
				goto IL_1C;
				IL_7C:
				num2 = (short)665124865;
				if (num2 != 0)
				{
				}
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.SyncDataSources();
				num2 = (short)41222146;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_114:
			num2 = (short)1527840768;
			if (num2 != 0)
			{
			}
			IL_12C:
			num2 = (short)1614610432;
			short num4 = num2;
			this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.MyRecordsetDataSource;
			num2 = (short)625672193;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x005CEB70 File Offset: 0x005CCD70
		internal void OnExpanderRadioErgonomicsWideAuxControlTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1570701312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 2:
				{
					num2 = (short)460865435;
					short num3 = num2;
					num2 = (short)1610301339;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_E8;
					}
					break;
				}
				}
				goto IL_1C;
				IL_7C:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.SyncDataSources();
				num2 = (short)1637875714;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E8:
			num2 = (short)1178992640;
			if (num2 != 0)
			{
			}
			num2 = (short)846135297;
			if (num2 != 0)
			{
			}
			IL_125:
			num2 = (short)5832704;
			short num4 = num2;
			this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.MyRecordsetDataSource;
			num2 = (short)227540993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x005CECD8 File Offset: 0x005CCED8
		internal void OnExpanderRadioErgonomicsWidePresetZoneAndChannelTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7D;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)212336640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12A;
				case 2:
				{
					num2 = (short)2128429907;
					short num3 = num2;
					num2 = (short)798180179;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
						goto IL_112;
					}
					break;
				}
				}
				goto IL_1C;
				IL_7D:
				num2 = (short)275775489;
				if (num2 != 0)
				{
				}
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.SyncDataSources();
				num2 = (short)1725366274;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_112:
			num2 = (short)1840971776;
			if (num2 != 0)
			{
			}
			IL_12A:
			num2 = (short)337117184;
			short num4 = num2;
			this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.MyRecordsetDataSource;
			num2 = (short)1702494209;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x005CEE44 File Offset: 0x005CD044
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num;
			if (this.b)
			{
				num = (short)1906005988;
				short num2 = num;
				num = (short)894064612;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1096679425;
					if (num != 0)
					{
					}
					num = (short)1204092928;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			num = (short)626720768;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺迼黾攀樂樄∆㬈㬊栌紎瘐簒笔砖琘爚縜氞Рᄢᔤ䐦䘨䔪䬬䘮嘰䘲䜴嘶䴸刺刼儾湀ㅂ⑄⍆⁈⑊桌絎慐㙒❔ざ㙘㕚㉜㉞ࡠbᙤ䉦孨孪ᩬٮᕰᙲ婴նᡸὺᑼၾﺖﶘﺚ뎜삠캢즤", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x005CEF24 File Offset: 0x005CD124
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)328466433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_37BE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					num = (short)1840381952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_FFD;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_38D5;
				case 11:
					goto IL_FF0;
				case 12:
					goto IL_1687;
				case 13:
					goto IL_A64;
				case 14:
					goto IL_33D6;
				case 15:
					goto IL_3595;
				case 16:
					goto IL_20FE;
				case 17:
					goto IL_375B;
				case 18:
					goto IL_35EA;
				case 19:
					goto IL_1FAE;
				case 20:
					goto IL_C5E;
				case 21:
					goto IL_1F59;
				case 22:
					goto IL_24E7;
				case 23:
					goto IL_193B;
				case 24:
					goto IL_34B4;
				case 25:
					goto IL_F08;
				case 26:
					goto IL_BD5;
				case 27:
					goto IL_3516;
				case 28:
					goto IL_1CBC;
				case 29:
					goto IL_19DE;
				case 30:
					goto IL_1FF9;
				case 31:
					goto IL_2C07;
				case 32:
					goto IL_1ACC;
				case 33:
					goto IL_36F6;
				case 34:
					goto IL_1202;
				case 35:
					goto IL_264E;
				case 36:
					goto IL_1F25;
				case 37:
					goto IL_2241;
				case 38:
					goto IL_147A;
				case 39:
					goto IL_3340;
				case 40:
					goto IL_37F4;
				case 41:
					goto IL_12CC;
				case 42:
					goto IL_2B57;
				case 43:
					goto IL_1812;
				case 44:
					goto IL_28F8;
				case 45:
					goto IL_2122;
				case 46:
					goto IL_23DF;
				case 47:
					goto IL_2E1B;
				case 48:
					goto IL_36DC;
				case 49:
					goto IL_26EB;
				case 50:
					goto IL_3438;
				case 51:
					goto IL_208C;
				case 52:
					goto IL_1B31;
				case 53:
					goto IL_CB6;
				case 54:
					goto IL_253F;
				case 55:
					goto IL_1267;
				case 56:
					goto IL_1993;
				case 57:
					goto IL_2A76;
				case 58:
					goto IL_12D9;
				case 59:
					goto IL_334D;
				case 60:
					goto IL_16B8;
				case 61:
					goto IL_3293;
				case 62:
					goto IL_2CCE;
				case 63:
					goto IL_363F;
				case 64:
					goto IL_2006;
				case 65:
					goto IL_2349;
				case 66:
					goto IL_14B8;
				case 67:
					goto IL_3407;
				case 68:
					goto IL_2308;
				case 69:
					goto IL_2AC1;
				case 70:
					goto IL_2BBC;
				case 71:
					goto IL_ED7;
				case 72:
					goto IL_15B3;
				case 73:
					goto IL_2E7D;
				case 74:
					goto IL_14D2;
				case 75:
					goto IL_3255;
				case 76:
					goto IL_371D;
				case 77:
					goto IL_2817;
				case 78:
					goto IL_245B;
				case 79:
					goto IL_2750;
				case 80:
					goto IL_1CAF;
				case 81:
					goto IL_2441;
				case 82:
					goto IL_2CAA;
				case 83:
					goto IL_3111;
				case 84:
					goto IL_1979;
				case 85:
					goto IL_1727;
				case 86:
					goto IL_3897;
				case 87:
					goto IL_9E5;
				case 88:
					goto IL_F2C;
				case 89:
					goto IL_12FD;
				case 90:
					goto IL_177F;
				case 91:
					goto IL_1453;
				case 92:
					goto IL_1086;
				case 93:
					goto IL_EFB;
				case 94:
					goto IL_37D0;
				case 95:
					goto IL_D80;
				case 96:
					goto IL_2B71;
				case 97:
					goto IL_1E51;
				case 98:
					goto IL_C9C;
				case 99:
					goto IL_149E;
				case 100:
					goto IL_1A12;
				case 101:
					goto IL_3557;
				case 102:
					goto IL_A95;
				case 103:
					goto IL_CDA;
				case 104:
					goto IL_3002;
				case 105:
					goto IL_C51;
				case 106:
					goto IL_22E4;
				case 107:
					goto IL_26C7;
				case 108:
					goto IL_3799;
				case 109:
					goto IL_178C;
				case 110:
					goto IL_2862;
				case 111:
					goto IL_28D1;
				case 112:
					goto IL_155E;
				case 113:
					goto IL_29F0;
				case 114:
					goto IL_D4C;
				case 115:
					goto IL_1656;
				case 116:
					goto IL_330F;
				case 117:
					goto IL_20B3;
				case 118:
					goto IL_31A7;
				case 119:
					goto IL_1ED0;
				case 120:
					goto IL_2905;
				case 121:
					goto IL_26F8;
				case 122:
					goto IL_34C1;
				case 123:
					goto IL_A88;
				case 124:
					goto IL_21D2;
				case 125:
					goto IL_267F;
				case 126:
					goto IL_14AB;
				case 127:
					goto IL_3710;
				case 128:
					goto IL_1C40;
				case 129:
					goto IL_3104;
				case 130:
					goto IL_3088;
				case 131:
					goto IL_3176;
				case 132:
					goto IL_3371;
				case 133:
					goto IL_27BF;
				case 134:
					goto IL_9CB;
				case 135:
					goto IL_D0B;
				case 136:
					goto IL_B42;
				case 137:
					goto IL_377F;
				case 138:
					goto IL_249C;
				case 139:
					goto IL_27E6;
				case 140:
					goto IL_AA2;
				case 141:
					goto IL_3286;
				case 142:
					goto IL_2848;
				case 143:
					goto IL_3741;
				case 144:
					goto IL_17BD;
				case 145:
					goto IL_29CC;
				case 146:
					goto IL_ECA;
				case 147:
					goto IL_2160;
				case 148:
					goto IL_22CA;
				case 149:
					goto IL_C8F;
				case 150:
					goto IL_A19;
				case 151:
					goto IL_1E20;
				case 152:
					goto IL_2D85;
				case 153:
					goto IL_2DC3;
				case 154:
					goto IL_BBB;
				case 155:
					goto IL_233C;
				case 156:
					goto IL_1362;
				case 157:
					goto IL_B97;
				case 158:
					goto IL_1F8A;
				case 159:
					goto IL_1625;
				case 160:
					goto IL_1A8E;
				case 161:
					goto IL_202A;
				case 162:
					goto IL_2265;
				case 163:
					goto IL_2D19;
				case 164:
					goto IL_1C4D;
				case 165:
					goto IL_2153;
				case 166:
					goto IL_2712;
				case 167:
					goto IL_1DA4;
				case 168:
					goto IL_1446;
				case 169:
					goto IL_1DFC;
				case 170:
					goto IL_1112;
				case 171:
					goto IL_13A3;
				case 172:
					goto IL_120F;
				case 173:
					goto IL_20A6;
				case 174:
					goto IL_1DB1;
				case 175:
					goto IL_2272;
				case 176:
					goto IL_B73;
				case 177:
					goto IL_1537;
				case 178:
					goto IL_295D;
				case 179:
					goto IL_2234;
				case 180:
					goto IL_10D1;
				case 181:
					goto IL_1B55;
				case 182:
					goto IL_30BC;
				case 183:
					goto IL_32EB;
				case 184:
					goto IL_2322;
				case 185:
					goto IL_1B0A;
				case 186:
					goto IL_196C;
				case 187:
					goto IL_1DEF;
				case 188:
					goto IL_2F65;
				case 189:
					goto IL_1D42;
				case 190:
					goto IL_14C5;
				case 191:
					goto IL_B35;
				case 192:
					goto IL_37C3;
				case 193:
					goto IL_338B;
				case 194:
					goto IL_1D11;
				case 195:
					goto IL_32A0;
				case 196:
					goto IL_C06;
				case 197:
					goto IL_384C;
				case 198:
					goto IL_D66;
				case 199:
					goto IL_349A;
				case 200:
					goto IL_2482;
				case 201:
					goto IL_106C;
				case 202:
					goto IL_F84;
				case 203:
					goto IL_1948;
				case 204:
					goto IL_276A;
				case 205:
					goto IL_F50;
				case 206:
					goto IL_1F4C;
				case 207:
					goto IL_19F8;
				case 208:
					goto IL_25C8;
				case 209:
					goto IL_2037;
				case 210:
					goto IL_250E;
				case 211:
					goto IL_2387;
				case 212:
					goto IL_1136;
				case 213:
					goto IL_C20;
				case 214:
					goto IL_13EE;
				case 215:
					goto IL_1B62;
				case 216:
					goto IL_1F66;
				case 217:
					goto IL_1281;
				case 218:
					goto IL_205B;
				case 219:
					goto IL_22BD;
				case 220:
					goto IL_1FEC;
				case 221:
					goto IL_2570;
				case 222:
					goto IL_DF9;
				case 223:
					goto IL_18FD;
				case 224:
					goto IL_1765;
				case 225:
					goto IL_192E;
				case 226:
					goto IL_2A45;
				case 227:
					goto IL_3169;
				case 228:
					goto IL_2EAE;
				case 229:
					goto IL_2B0C;
				case 230:
					goto IL_1396;
				case 231:
					goto IL_33FA;
				case 232:
					goto IL_24F4;
				case 233:
					goto IL_354A;
				case 234:
					goto IL_2777;
				case 235:
					goto IL_271F;
				case 236:
					goto IL_128E;
				case 237:
					goto IL_2B3D;
				case 238:
					goto IL_1A43;
				case 239:
					goto IL_105F;
				case 240:
					goto IL_B04;
				case 241:
					goto IL_AE0;
				case 242:
					goto IL_25BB;
				case 243:
					goto IL_DEC;
				case 244:
					goto IL_E1D;
				case 245:
					goto IL_315C;
				case 246:
					goto IL_2E8A;
				case 247:
					goto IL_3873;
				case 248:
					goto IL_32DE;
				case 249:
					goto IL_2C9D;
				case 250:
					goto IL_E68;
				case 251:
					goto IL_2C90;
				case 252:
					goto IL_381B;
				case 253:
					goto IL_1D66;
				case 254:
					goto IL_33A5;
				case 255:
					goto IL_13FB;
				case 256:
					goto IL_22D7;
				case 257:
					goto IL_28A0;
				case 258:
					goto IL_3248;
				case 259:
					goto IL_1F32;
				case 260:
					goto IL_27F3;
				case 261:
					goto IL_103B;
				case 262:
					goto IL_1A36;
				case 263:
					goto IL_2912;
				case 264:
					goto IL_125A;
				case 265:
					goto IL_1E6B;
				case 266:
					goto IL_1079;
				case 267:
					goto IL_30E0;
				case 268:
					goto IL_3414;
				case 269:
					goto IL_2594;
				case 270:
					goto IL_1F18;
				case 271:
					goto IL_E5B;
				case 272:
					goto IL_1836;
				case 273:
					goto IL_2DB6;
				case 274:
					goto IL_A57;
				case 275:
					goto IL_279B;
				case 276:
					goto IL_19BA;
				case 277:
					goto IL_1551;
				case 278:
					goto IL_2194;
				case 279:
					goto IL_2CDB;
				case 280:
					goto IL_BF9;
				case 281:
					goto IL_15E7;
				case 282:
					goto IL_2CF5;
				case 283:
					goto IL_2315;
				case 284:
					goto IL_12BF;
				case 285:
					goto IL_1C33;
				case 286:
					goto IL_1A74;
				case 287:
					goto IL_287C;
				case 288:
					goto IL_1850;
				case 289:
					goto IL_1874;
				case 290:
					goto IL_291F;
				case 291:
					goto IL_136F;
				case 292:
					goto IL_3866;
				case 293:
					goto IL_34CE;
				case 294:
					goto IL_21AE;
				case 295:
					goto IL_2705;
				case 296:
					goto IL_2EF6;
				case 297:
					goto IL_1AFD;
				case 298:
					goto IL_1460;
				case 299:
					goto IL_FA8;
				case 300:
					goto IL_1C8B;
				case 301:
					goto IL_16E9;
				case 302:
					goto IL_374E;
				case 303:
					goto IL_BC8;
				case 304:
					goto IL_2B64;
				case 305:
					goto IL_265B;
				case 306:
					goto IL_364C;
				case 307:
					goto IL_3632;
				case 308:
					goto IL_1E92;
				case 309:
					goto IL_10F8;
				case 310:
					goto IL_1618;
				case 311:
					goto IL_2FDE;
				case 312:
					goto IL_2E3F;
				case 313:
					goto IL_1B24;
				case 314:
					goto IL_33C9;
				case 315:
					goto IL_1348;
				case 316:
					goto IL_1AF0;
				case 317:
					goto IL_2068;
				case 318:
					goto IL_1EAC;
				case 319:
					goto IL_E2A;
				case 320:
					goto IL_1D73;
				case 321:
					goto IL_124D;
				case 322:
					goto IL_1B86;
				case 323:
					goto IL_2F41;
				case 324:
					goto IL_1CED;
				case 325:
					goto IL_1E78;
				case 326:
					goto IL_D73;
				case 327:
					goto IL_102E;
				case 328:
					goto IL_3588;
				case 329:
					goto IL_262A;
				case 330:
					goto IL_296A;
				case 331:
					goto IL_1C02;
				case 332:
					goto IL_2C69;
				case 333:
					goto IL_28EB;
				case 334:
					goto IL_1439;
				case 335:
					goto IL_EA6;
				case 336:
					goto IL_21F6;
				case 337:
					goto IL_2C5C;
				case 338:
					goto IL_15DA;
				case 339:
					goto IL_2743;
				case 340:
					goto IL_2AB4;
				case 341:
					goto IL_17E1;
				case 342:
					goto IL_DC8;
				case 343:
					goto IL_3523;
				case 344:
					goto IL_9BE;
				case 345:
					goto IL_E75;
				case 346:
					goto IL_2475;
				case 347:
					goto IL_2A21;
				case 348:
					goto IL_3828;
				case 349:
					goto IL_2E70;
				case 350:
					goto IL_15CD;
				case 351:
					goto IL_2434;
				case 352:
					goto IL_3033;
				case 353:
					goto IL_20CD;
				case 354:
					goto IL_1177;
				case 355:
					goto IL_1544;
				case 356:
					goto IL_2DA9;
				case 357:
					goto IL_2BFA;
				case 358:
					goto IL_A0C;
				case 359:
					goto IL_CE7;
				case 360:
					goto IL_10A0;
				case 361:
					goto IL_232F;
				case 362:
					goto IL_D59;
				case 363:
					goto IL_10C4;
				case 364:
					goto IL_1150;
				case 365:
					goto IL_1741;
				case 366:
					goto IL_1C0F;
				case 367:
					goto IL_299B;
				case 368:
					goto IL_3095;
				case 369:
					goto IL_36E9;
				case 370:
					goto IL_2B7E;
				case 371:
					goto IL_212F;
				case 372:
					goto IL_25F9;
				case 373:
					goto IL_248F;
				case 374:
					goto IL_1E9F;
				case 375:
					goto IL_F77;
				case 376:
					goto IL_1986;
				case 377:
					goto IL_25D5;
				case 378:
					goto IL_38B1;
				case 379:
					goto IL_2B8B;
				case 380:
					goto IL_1BC4;
				case 381:
					goto IL_2427;
				case 382:
					goto IL_24DA;
				case 383:
					goto IL_2B98;
				case 384:
					goto IL_300F;
				case 385:
					goto IL_1321;
				case 386:
					goto IL_11C4;
				case 387:
					goto IL_34A7;
				case 388:
					goto IL_B28;
				case 389:
					goto IL_1DCB;
				case 390:
					goto IL_1D80;
				case 391:
					goto IL_30A2;
				case 392:
					goto IL_2855;
				case 393:
					goto IL_F6A;
				case 394:
					goto IL_133B;
				case 395:
					goto IL_13B0;
				case 396:
					goto IL_121C;
				case 397:
					goto IL_22B0;
				case 398:
					goto IL_116A;
				case 399:
					goto IL_F5D;
				case 400:
					goto IL_1772;
				case 401:
					goto IL_331C;
				case 402:
					goto IL_2A90;
				case 403:
					goto IL_10EB;
				case 404:
					goto IL_3801;
				case 405:
					goto IL_24CD;
				case 406:
					goto IL_2E63;
				case 407:
					goto IL_292C;
				case 408:
					goto IL_2F03;
				case 409:
					goto IL_1143;
				case 410:
					goto IL_1E5E;
				case 411:
					goto IL_9F2;
				case 412:
					goto IL_1274;
				case 413:
					goto IL_36B8;
				case 414:
					goto IL_11D1;
				case 415:
					goto IL_378C;
				case 416:
					goto IL_1C7E;
				case 417:
					goto IL_18E3;
				case 418:
					goto IL_25AE;
				case 419:
					goto IL_99A;
				case 420:
					goto IL_3064;
				case 421:
					goto IL_275D;
				case 422:
					goto IL_2C2B;
				case 423:
					goto IL_1E44;
				case 424:
					goto IL_283B;
				case 425:
					goto IL_1799;
				case 426:
					goto IL_3224;
				case 427:
					goto IL_160B;
				case 428:
					goto IL_31CB;
				case 429:
					goto IL_2501;
				case 430:
					goto IL_1105;
				case 431:
					goto IL_1A9B;
				case 432:
					goto IL_FCC;
				case 433:
					goto IL_18D6;
				case 434:
					goto IL_2CE8;
				case 435:
					goto IL_286F;
				case 436:
					goto IL_32D1;
				case 437:
					goto IL_14DF;
				case 438:
					goto IL_16C5;
				case 439:
					goto IL_3859;
				case 440:
					goto IL_1ABF;
				case 441:
					goto IL_1843;
				case 442:
					goto IL_C13;
				case 443:
					goto IL_3694;
				case 444:
					goto IL_29A8;
				case 445:
					goto IL_2A83;
				case 446:
					goto IL_2187;
				case 447:
					goto IL_D25;
				case 448:
					goto IL_142C;
				case 449:
					goto IL_2C38;
				case 450:
					goto IL_DA4;
				case 451:
					goto IL_314F;
				case 452:
					goto IL_1A05;
				case 453:
					goto IL_3135;
				case 454:
					goto IL_1F3F;
				case 455:
					goto IL_1A50;
				case 456:
					goto IL_23A1;
				case 457:
					goto IL_2B4A;
				case 458:
					goto IL_1E85;
				case 459:
					goto IL_2227;
				case 460:
					goto IL_1FDF;
				case 461:
					goto IL_1CC9;
				case 462:
					goto IL_1663;
				case 463:
					goto IL_2E01;
				case 464:
					goto IL_23D2;
				case 465:
					goto IL_CA9;
				case 466:
					goto IL_1093;
				case 467:
					goto IL_E82;
				case 468:
					goto IL_3040;
				case 469:
					goto IL_1DBE;
				case 470:
					goto IL_10DE;
				case 471:
					goto IL_19AD;
				case 472:
					goto IL_19A0;
				case 473:
					goto IL_1632;
				case 474:
					goto IL_1881;
				case 475:
					goto IL_132E;
				case 476:
					goto IL_2A14;
				case 477:
					goto IL_18F0;
				case 478:
					goto IL_AD3;
				case 479:
					goto IL_190A;
				case 480:
					goto IL_360E;
				case 481:
					goto IL_2E0E;
				case 482:
					goto IL_244E;
				case 483:
					goto IL_1B17;
				case 484:
					goto IL_9D8;
				case 485:
					goto IL_16F6;
				case 486:
					goto IL_3469;
				case 487:
					goto IL_261D;
				case 488:
					goto IL_152A;
				case 489:
					goto IL_D18;
				case 490:
					goto IL_B66;
				case 491:
					goto IL_3262;
				case 492:
					goto IL_15C0;
				case 493:
					goto IL_115D;
				case 494:
					goto IL_217A;
				case 495:
					goto IL_1B93;
				case 496:
					goto IL_D32;
				case 497:
					goto IL_2F34;
				case 498:
					goto IL_137C;
				case 499:
					goto IL_1BD1;
				case 500:
					goto IL_22A3;
				case 501:
					goto IL_2468;
				case 502:
					goto IL_38A4;
				case 503:
					goto IL_254C;
				case 504:
					goto IL_11F5;
				case 505:
					goto IL_28AD;
				case 506:
					goto IL_35DD;
				case 507:
					goto IL_30AF;
				case 508:
					goto IL_3183;
				case 509:
					goto IL_20F1;
				case 510:
					goto IL_C2D;
				case 511:
					goto IL_2ADB;
				case 512:
					goto IL_D3F;
				case 513:
					goto IL_337E;
				case 514:
					goto IL_2F89;
				case 515:
					goto IL_2DD0;
				case 516:
					goto IL_3445;
				case 517:
					goto IL_357B;
				case 518:
					goto IL_A26;
				case 519:
					goto IL_2950;
				case 520:
					goto IL_1BDE;
				case 521:
					goto IL_2532;
				case 522:
					goto IL_35B9;
				case 523:
					goto IL_298E;
				case 524:
					goto IL_1355;
				case 525:
					goto IL_348D;
				case 526:
					goto IL_1EF4;
				case 527:
					goto IL_1582;
				case 528:
					goto IL_E37;
				case 529:
					goto IL_380E;
				case 530:
					goto IL_236D;
				case 531:
					goto IL_25A1;
				case 532:
					goto IL_146D;
				case 533:
					goto IL_AAF;
				case 534:
					goto IL_2FD1;
				case 535:
					goto IL_C82;
				case 536:
					goto IL_34F2;
				case 537:
					goto IL_2DDD;
				case 538:
					goto IL_9FF;
				case 539:
					goto IL_3530;
				case 540:
					goto IL_1240;
				case 541:
					goto IL_353D;
				case 542:
					goto IL_27CC;
				case 543:
					goto IL_141F;
				case 544:
					goto IL_13D4;
				case 545:
					goto IL_1734;
				case 546:
					goto IL_32C4;
				case 547:
					goto IL_13E1;
				case 548:
					goto IL_2ACE;
				case 549:
					goto IL_24C0;
				case 550:
					goto IL_2ED2;
				case 551:
					goto IL_2099;
				case 552:
					goto IL_2D61;
				case 553:
					goto IL_2F27;
				case 554:
					goto IL_216D;
				case 555:
					goto IL_237A;
				case 556:
					goto IL_3670;
				case 557:
					goto IL_3142;
				case 558:
					goto IL_18A5;
				case 559:
					goto IL_2BE0;
				case 560:
					goto IL_1D35;
				case 561:
					goto IL_28DE;
				case 562:
					goto IL_2A52;
				case 563:
					goto IL_2296;
				case 564:
					goto IL_158F;
				case 565:
					goto IL_1A81;
				case 566:
					goto IL_3398;
				case 567:
					goto IL_20C0;
				case 568:
					goto IL_1389;
				case 569:
					goto IL_221A;
				case 570:
					goto IL_2C76;
				case 571:
					goto IL_2D3D;
				case 572:
					goto IL_2403;
				case 573:
					goto IL_21A1;
				case 574:
					goto IL_2C83;
				case 575:
					goto IL_2394;
				case 576:
					goto IL_27D9;
				case 577:
					goto IL_2AE8;
				case 578:
					goto IL_A33;
				case 579:
					goto IL_19EB;
				case 580:
					goto IL_18C9;
				case 581:
					goto IL_16AB;
				case 582:
					goto IL_1FD2;
				case 583:
					goto IL_26A3;
				case 584:
					goto IL_2FAD;
				case 585:
					goto IL_1C71;
				case 586:
					goto IL_3703;
				case 587:
					goto IL_2B30;
				case 588:
					goto IL_171A;
				case 589:
					goto IL_1BA0;
				case 590:
					goto IL_129B;
				case 591:
					goto IL_2BED;
				case 592:
					goto IL_1805;
				case 593:
					goto IL_23C5;
				default:
					num = (short)1367867394;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_99A:
			this.LblRadErgoWideAdvancedActiveMicForIndirectPTT_44816 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedActiveMicForIndirectPTT_44816.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9BE:
			this.CpyBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9CB:
			this.ExpanderRadioErgonomicsWideControlHeadAliasListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9D8:
			this.CVBtnRadErgoWideMOSCADDataEnable_A8545 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9E5:
			this.CVBtnRadErgoWideControlHeadRemoteMicSource_A8930 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F2:
			this.RadErgoWideAdvancedActiveMicForRSMPTT_43050Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9FF:
			this.RTDBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A0C:
			this.CVBtnRadErgoWideAdvancedTouchScreenLockEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A19:
			this.CVBtnRadErgoWidePASirenOptionsAudioMuting_A8623 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A26:
			this.CpyBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A33:
			this.RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A57:
			this.CVBtnRadErgoWideAdvancedShortKeypressDurationms_A9125 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A64:
			this.HLinkControlHead = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHead.Click += this.HLinkClick;
			return;
			IL_A88:
			this.CVBtnRadioErgoWideControlHeadBlockDarkestDimLevel = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A95:
			this.RTDBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AA2:
			this.RadErgoWideControlHeadControlHead1Alias_A7718Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AAF:
			this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable.ModeClick += this.OnModeClick;
			return;
			IL_AD3:
			this.CVBtnRadWideNVGBacklightBrightnessLevel_A41616 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AE0:
			this.RadErgoWideHornandLightsAlarmRearmOption_A7423 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideHornandLightsAlarmRearmOption_A7423.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B04:
			this.LblRadErgoWideHornandLightsAlarmRearmOption_A7423 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsAlarmRearmOption_A7423.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B28:
			this.CVBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B35:
			this.CpyBtnRadErgoWidePASirenManualTone_A8464 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B42:
			this.RadErgoWideControlHeadControlHead1Alias_A7718 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoWideControlHeadControlHead1Alias_A7718.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B66:
			this.ExpanderRadioErgonomicsWideAuxControl = (global::AcpUI.AcpExpander)target;
			return;
			IL_B73:
			this.RadErgoWidePASirenSirenPAAfterReset_A9140 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWidePASirenSirenPAAfterReset_A9140.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B97:
			this.LblRadErgoWidePASirenExternalRadioIgnition_A7992 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenExternalRadioIgnition_A7992.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BBB:
			this.CpyBtnRadErgoWidePASirenOptionsAudioMuting_A8623 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BC8:
			this.RadErgoWideAdvancedPowerOffKeypressDuration_42489Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BD5:
			this.RadErgoWideHomeModeHomeModeSelection_A8202 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideHomeModeHomeModeSelection_A8202.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BF9:
			this.CVBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C06:
			this.RTDBtnRadErgoWidePASirenSirenIgnitionSense_A9138 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C13:
			this.CVBtnRadErgoWideAdvancedConsoletteEnable_A37231 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C20:
			this.RadErgoWideHornandLightsPermanentHornLights_A8697Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_C2D:
			this.LblRadErgoWideAuxControlActiveDuration_A37249 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAuxControlActiveDuration_A37249.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C51:
			this.CVBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C5E:
			this.HLinkLogicalProfileConfiguration = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLogicalProfileConfiguration.Click += this.HLinkClick;
			return;
			IL_C82:
			this.CVBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C8F:
			this.GrpBoxExpanderRadioErgonomicsWidePASirenPublicAddress = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C9C:
			this.RadErgoWideControlHeadBluetoothControl_44820Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CA9:
			this.RadErgoWideAdvancedFixedVolumeLevel_A37219Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CB6:
			this.RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CDA:
			this.CpyBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CE7:
			this.LblRadErgoWideAdvancedTouchScreenLockEnable = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedTouchScreenLockEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D0B:
			this.gridExpanderRadioErgonomicsWideControlHeadAliasListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D18:
			this.RadErgoWideMOSCADDataEnable_A8545Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D25:
			this.RadErgoWideAdvancedConsoletteEnable_A37231Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D32:
			this.RadErgoWideAuxControlAuxCtrlName_A37714_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D3F:
			this.CpyBtnRadErgoWideAuxControlActiveDuration_A37249 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D4C:
			this.RTDBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D59:
			this.CpyBtnRadErgoWideAdvancedTouchScreenLockEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D66:
			this.RadErgoWidePASirenSirenIgnitionSense_A9138Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D73:
			this.CpyBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D80:
			this.RadErgoWideControlHeadBluetoothControl_44820 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadBluetoothControl_44820.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DA4:
			this.RadErgoWideAdvancedConsoletteFatalError_A37233 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedConsoletteFatalError_A37233.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DC8:
			this.RadErgoWideAdvancedRotarySwitchLockEnable_A8987 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedRotarySwitchLockEnable_A8987.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DEC:
			this.CpyBtnRadErgoWideHornandLightsAlarmRearmOption_A7423 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DF9:
			this.RadErgoWideHornandLightsLightDurationsec_A8430 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideHornandLightsLightDurationsec_A8430.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E1D:
			this.RadErgoWideHornandLightsAlarmRearmOption_A7423Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E2A:
			this.RTDBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E37:
			this.LblRadErgoWideAuxControlAuxOffAlias_A37252 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAuxControlAuxOffAlias_A37252.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E5B:
			this.RadErgoWideStealthSaveStealthMode_A36491Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E68:
			this.RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E75:
			this.RadErgoWideAdvancedRotarySwitchLockEnable_A8987Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E82:
			this.LblRadErgoWideAdvancedDefaultCHHubState_A37222 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedDefaultCHHubState_A37222.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EA6:
			this.LblRadErgoWideAdvancedLogicalSwitch2_A7756 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedLogicalSwitch2_A7756.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ECA:
			this.RTDBtnRadErgoWidePASirenSirenOperation_A9139 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ED7:
			this.RadErgoWideControlHeadExpectedNumofControlHeads_A7982 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadExpectedNumofControlHeads_A7982.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EFB:
			this.CVBtnRadErgoWideControlHeadBluetoothControl_44820 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F08:
			this.LblRadErgoWideHomeModeHomeModeSelection_A8202 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHomeModeHomeModeSelection_A8202.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F2C:
			this.LblRadErgoWideControlHeadRemoteMicSource_A8930 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadRemoteMicSource_A8930.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F50:
			this.CpyBtnRadErgoWideHornandLightsHornLights_A8206 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F5D:
			this.RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F6A:
			this.RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F77:
			this.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F84:
			this.LblRadErgoWideHornandLightsHornLights_A8206 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsHornLights_A8206.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FA8:
			this.LblRadErgoWideAdvancedPowerOffKeypressDuration_42489 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedPowerOffKeypressDuration_42489.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FCC:
			this.RadioErgoCfgExternalAccessoryEnable_A36198 = (global::AcpUI.AcpCheckBox)target;
			this.RadioErgoCfgExternalAccessoryEnable_A36198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FF0:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_FFD:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PageRadioErgonomicsWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PageRadioErgonomicsWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_102E:
			this.RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_103B:
			this.RadErgoWideStealthDisableTones_A36487 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideStealthDisableTones_A36487.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_105F:
			this.CVBtnRadErgoWideHornandLightsAlarmRearmOption_A7423 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_106C:
			this.CVBtnRadErgoWideHornandLightsHornLights_A8206 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1079:
			this.CVBtnRadErgoWideStealthSaveStealthMode_A36491 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1086:
			this.RadErgoWideControlHeadRemoteMicSource_A8930Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1093:
			this.CVBtnRadErgoWideAdvancedDefaultCHHubState_A37222 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10A0:
			this.RadErgoWideAdvancedTouchScreenLockEnable = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedTouchScreenLockEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10C4:
			this.RadErgoWideAdvancedTouchScreenLockEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_10D1:
			this.GrpBoxExpanderRadioErgonomicsWidePASirenSiren = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10DE:
			this.CpyBtnRadErgoWideAdvancedDefaultCHHubState_A37222 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10EB:
			this.RTDBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10F8:
			this.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1105:
			this.CVBtnRadioErgoCfgExternalAccessoryEnable_A36198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1112:
			this.RadErgoWidePASirenDefaultPAVolumeLevel_A7812 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWidePASirenDefaultPAVolumeLevel_A7812.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1136:
			this.CpyBtnRadErgoWideHornandLightsPermanentHornLights_A8697 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1143:
			this.RTDBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1150:
			this.CVBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_115D:
			this.ExpanderRadioErgonomicsWideAuxControlTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_116A:
			this.CpyBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1177:
			num = (short)1041694720;
			short num3 = num;
			this.RadErgoWideAdvancedSideButtonsLockEnable_A38725 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedSideButtonsLockEnable_A38725.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11C4:
			this.CpyBtnRadErgoWideAdvancedNumberofZoneBanks_A37256 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11D1:
			this.RadErgoWideAdvancedActiveMicForBTPTT_43051 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedActiveMicForBTPTT_43051.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11F5:
			this.CVBtnRadErgoWideAuxControlAuxCtrlName_A37714 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1202:
			this.CpyBtnRadErgoWideHomeModeZone_A9691 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_120F:
			this.CpyBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_121C:
			this.RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1240:
			this.RadWideGeneralConfigurablePresetZoneAndChannel_A44917Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_124D:
			this.RadErgoWideAdvancedMFKInactivityTimeout_A38507Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_125A:
			this.RadErgoWideStealthDisableTones_A36487Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1267:
			this.CpyBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1274:
			this.CVBtnRadErgoWideAdvancedActiveMicForBTPTT_43051 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1281:
			this.RTDBtnRadErgoWideHornandLightsHornDurationsec_A8207 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_128E:
			this.RTDBtnRadErgoWideHornandLightsAlarmType_A7424 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_129B:
			this.RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12BF:
			this.CpyBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12CC:
			this.HomeModeChannelComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12D9:
			this.LblRadErgoWideControlHeadMulCHTxAudioRouting_A38459 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadMulCHTxAudioRouting_A38459.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12FD:
			this.RadErgoWideControlHeadRemoteMicSource_A8930 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadRemoteMicSource_A8930.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1321:
			this.RTDBtnRadErgoWideAdvancedNumberofZoneBanks_A37256 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_132E:
			this.RTDBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_133B:
			this.CVBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1348:
			this.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1355:
			this.CpyBtnRadErgoWideAuxControlAuxOnAlias_A37250 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1362:
			this.CVBtnRadErgoWidePASirenExternalRadioIgnition_A7992 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_136F:
			this.RadErgoWideAdvancedLongKeypressDurationms_A8450Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_137C:
			this.RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1389:
			this.ExpanderRadioErgonomicsWideLogicalProfileConfiguration = (global::AcpUI.AcpExpander)target;
			return;
			IL_1396:
			this.RTDBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13A3:
			this.RTDBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13B0:
			this.LblRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13D4:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannelTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_13E1:
			this.LabtoolPresetChannel_A41080_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13EE:
			this.CVBtnRadErgoWideHornandLightsHornDurationsec_A8207 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13FB:
			this.RadErgoWideStealthDisableLightLED_A36482 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideStealthDisableLightLED_A36482.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_141F:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannelTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_142C:
			this.CVBtnRadErgoWideAdvancedConsoletteFatalError_A37233 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1439:
			this.CVBtnRadErgoWideAdvancedLogicalSwitch2_A7756 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1446:
			this.CVBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1453:
			this.CpyBtnRadErgoWideControlHeadRemoteMicSource_A8930 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1460:
			this.CVBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_146D:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannel = (global::AcpUI.AcpExpander)target;
			return;
			IL_147A:
			this.HomeModeChannel = (global::AcpUI.AcpTextBoxSpinner)target;
			this.HomeModeChannel.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_149E:
			this.CVBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14AB:
			this.RTDBtnRadioErgoWideControlHeadBlockDarkestDimLevel = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14B8:
			this.RTDBtnRadErgoWideControlHeadAggregateCableLength_A38456 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14C5:
			this.RTDBtnRadErgoWidePASirenManualTone_A8464 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14D2:
			this.RadErgoWideControlHeadExpectedNumofControlHeads_A7982Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14DF:
			num = (short)196476929;
			if (num != 0)
			{
			}
			this.LblRadioErgoCfgFatalError_A36202 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoCfgFatalError_A36202.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_152A:
			this.CpyBtnRadErgoWideMOSCADDataEnable_A8545 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1537:
			this.RTDBtnRadErgoWidePASirenSirenPAAfterReset_A9140 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1544:
			this.RTDBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1551:
			this.RTDBtnRadErgoWideAdvancedShortKeypressDurationms_A9125 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_155E:
			this.LblRadErgoWideControlHeadTransceiverDEKDimControl_A9404 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadTransceiverDEKDimControl_A9404.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1582:
			this.CVBtnRadErgoWideAuxControlAuxOffAlias_A37252 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_158F:
			this.LblLabtoolPresetChannel_A41080 = (global::AcpUI.AcpLabel)target;
			this.LblLabtoolPresetChannel_A41080.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15B3:
			this.RTDBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15C0:
			this.ExpanderRadioErgonomicsWideAuxControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_15CD:
			this.CpyBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15DA:
			this.CpyBtnRadErgoWideAdvancedLogicalSwitch2_A7756 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15E7:
			this.LblRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_160B:
			this.RTDBtnRadErgoWideAdvancedBTReceiveAudio_43052 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1618:
			this.CVBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1625:
			this.RTDBtnRadErgoWidePASirenExternalRadioIgnition_A7992 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1632:
			this.LblRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1656:
			this.CpyBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1663:
			this.RadErgoWideAdvancedFixedVolumeLevel_A37219 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedFixedVolumeLevel_A37219.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1687:
			this.HLinkHomeMode = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkHomeMode.Click += this.HLinkClick;
			return;
			IL_16AB:
			this.RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16B8:
			this.RTDBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16C5:
			this.RadioErgoCfgFatalError_A36202 = (global::AcpUI.AcpCheckBox)target;
			this.RadioErgoCfgFatalError_A36202.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16E9:
			this.RTDBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16F6:
			this.LblRadErgoWideMOSCADDataEnable_A8545 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideMOSCADDataEnable_A8545.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_171A:
			this.CVBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1727:
			this.CpyBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1734:
			this.PresetModeSelect_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1741:
			this.LblRadErgoWideAdvancedLastSelectedChannelPerZone_A41073 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedLastSelectedChannelPerZone_A41073.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1765:
			this.CpyBtnRadErgoWideHornandLightsLightDurationsec_A8430 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1772:
			this.CVBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_177F:
			this.RTDBtnRadErgoWideControlHeadRemoteMicSource_A8930 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_178C:
			this.CpyBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1799:
			this.LblRadErgoWideAdvancedBTReceiveAudio_43052 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedBTReceiveAudio_43052.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17BD:
			this.LblRadErgoWidePASirenSirenOperation_A9139 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenSirenOperation_A9139.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17E1:
			this.LblRadErgoWideAdvancedRotarySwitchLockEnable_A8987 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedRotarySwitchLockEnable_A8987.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1805:
			this.CpyBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1812:
			this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList.ModeClick += this.OnModeClick;
			return;
			IL_1836:
			this.ExpanderRadioErgonomicsWideAdvanced = (global::AcpUI.AcpExpander)target;
			return;
			IL_1843:
			this.RadioErgoCfgFatalError_A36202Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1850:
			this.RadErgoWideAdvancedLongKeypressDurationms_A8450 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedLongKeypressDurationms_A8450.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1874:
			this.RTDBtnRadErgoWideAdvancedLongKeypressDurationms_A8450 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1881:
			this.RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18A5:
			this.LblLabtoolPresetZone_A41079 = (global::AcpUI.AcpLabel)target;
			this.LblLabtoolPresetZone_A41079.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18C9:
			this.CpyBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18D6:
			this.RTDBtnRadioErgoCfgExternalAccessoryEnable_A36198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18E3:
			this.RadErgoWideAdvancedActiveMicForBTPTT_43051Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18F0:
			this.RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18FD:
			this.RTDBtnRadErgoWideHornandLightsLightDurationsec_A8430 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_190A:
			this.LblRadWideNVGBacklightBrightnessLevel_A41616 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideNVGBacklightBrightnessLevel_A41616.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_192E:
			this.RadErgoWideHornandLightsLightDurationsec_A8430Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_193B:
			this.GrpBoxExpanderRadioErgonomicsWideHomeModePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1948:
			this.RadErgoWideHornandLightsHornLights_A8206 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideHornandLightsHornLights_A8206.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_196C:
			this.RadErgoWidePASirenHiLoAirhornTones_A8200Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1979:
			this.RTDBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1986:
			this.CVBtnRadErgoWideAdvancedZoneBankOperation_A37543 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1993:
			this.RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_19A0:
			this.CVBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19AD:
			this.RadErgoWideAdvancedDefaultCHHubState_A37222Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19BA:
			this.RadErgoWideAdvancedShortKeypressDurationms_A9125 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedShortKeypressDurationms_A9125.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19DE:
			this.RadErgoWideHomeModeHomeModeSelection_A8202Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_19EB:
			this.RTDBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19F8:
			this.GrpBoxExpanderRadioErgonomicsWideHornAndLightsHornAndLights = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1A05:
			this.CpyBtnRadErgoWideAdvancedConsoletteFatalError_A37233 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A12:
			this.LblRadErgoWideControlHeadControlHeadVIPInputSource_A7724 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadControlHeadVIPInputSource_A7724.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A36:
			this.RTDBtnRadErgoWideStealthDisableTones_A36487 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A43:
			this.RadErgoWideHornandLightsAlarmType_A7424Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A50:
			this.LblRadErgoWideAdvancedFixedVolumeEnable_A37218 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedFixedVolumeEnable_A37218.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A74:
			this.CVBtnRadErgoWideAdvancedLongKeypressDurationms_A8450 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A81:
			this.RTDBtnLabtoolPresetChannel_A41080 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A8E:
			this.CpyBtnRadErgoWidePASirenExternalRadioIgnition_A7992 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A9B:
			this.LblRadioErgoCfgExternalAccessoryEnable_A36198 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoCfgExternalAccessoryEnable_A36198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1ABF:
			this.CpyBtnRadioErgoCfgFatalError_A36202 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1ACC:
			this.RadErgoWideHomeModeZone_A9691 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideHomeModeZone_A9691.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AF0:
			this.CVBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AFD:
			this.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B0A:
			this.CpyBtnRadErgoWidePASirenHiLoAirhornTones_A8200 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B17:
			this.RadWideNVGBacklightBrightnessLevel_A41616Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B24:
			this.RTDBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B31:
			this.LblRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B55:
			this.CVBtnRadErgoWidePASirenHiLoAirhornTones_A8200 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B62:
			this.LblRadErgoWideHornandLightsHornDurationsec_A8207 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsHornDurationsec_A8207.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B86:
			this.CVBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B93:
			this.ExpanderRadioErgonomicsWideAuxControlTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BA0:
			this.LblRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BC4:
			this.CpyBtnRadErgoWideAdvancedZoneBankOperation_A37543 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BD1:
			this.RadErgoWideAuxControlAuxOnAlias_A37250_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1BDE:
			this.RadErgoWideAuxControlAuxOnAlias_A37250 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoWideAuxControlAuxOnAlias_A37250.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C02:
			this.RTDBtnRadErgoWideAdvancedSoftPowerOff_A9170 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C0F:
			this.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C33:
			this.RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C40:
			this.RadioErgoWideControlHeadBlockDarkestDimLevelComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1C4D:
			this.RadErgoWidePASirenPAIgnitionSense_A8683 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWidePASirenPAIgnitionSense_A8683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C71:
			this.RTDBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C7E:
			this.CpyBtnRadErgoWideAdvancedActiveMicForBTPTT_43051 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C8B:
			this.RadErgoWideAdvancedPowerOffKeypressDuration_42489 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedPowerOffKeypressDuration_42489.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CAF:
			this.RadErgoWideControlHeadMultipleControlHeadStyle_A8561Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CBC:
			this.CpyBtnRadErgoWideHomeModeHomeModeSelection_A8202 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CC9:
			this.LblRadErgoWideAdvancedFixedVolumeLevel_A37219 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedFixedVolumeLevel_A37219.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CED:
			this.RadErgoWideSideAdvancedMFBInactivityTimeout_A41565 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideSideAdvancedMFBInactivityTimeout_A41565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D11:
			this.LblRadErgoWidePASirenSirenIgnitionSense_A9138 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenSirenIgnitionSense_A9138.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D35:
			this.CpyBtnLabtoolPresetZone_A41079 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D42:
			this.RadErgoWidePASirenManualTone_A8464 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWidePASirenManualTone_A8464.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D66:
			this.CVBtnRadErgoWideStealthDisableLightLED_A36482 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D73:
			this.CpyBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D80:
			this.RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DA4:
			this.RadErgoWidePASirenPAIgnitionSense_A8683Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1DB1:
			this.CVBtnRadErgoWidePASirenSirenPAAfterReset_A9140 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DBE:
			this.RTDBtnRadErgoWideAdvancedDefaultCHHubState_A37222 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DCB:
			this.LblRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DEF:
			this.CVBtnRadErgoWidePASirenManualTone_A8464 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DFC:
			this.LblRadErgoWidePASirenDefaultPAVolumeLevel_A7812 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenDefaultPAVolumeLevel_A7812.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E20:
			this.LblRadErgoWidePASirenOptionsAudioMuting_A8623 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenOptionsAudioMuting_A8623.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E44:
			this.RadErgoWideAdvancedActiveMicForIndirectPTT_44816Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E51:
			this.CpyBtnRadErgoWideControlHeadBluetoothControl_44820 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E5E:
			this.CpyBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E6B:
			this.GrpBoxExpanderRadioErgonomicsWideStealthPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E78:
			this.RTDBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E85:
			this.CpyBtnRadErgoWideAdvancedFixedVolumeEnable_A37218 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E92:
			this.CpyBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E9F:
			this.CpyBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EAC:
			this.RadErgoWideAdvancedMFKInactivityTimeout_A38507 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedMFKInactivityTimeout_A38507.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1ED0:
			this.RadErgoWideControlHeadPowerUpBrightness = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadPowerUpBrightness.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EF4:
			this.RadErgoWideAuxControlAuxOffAlias_A37252 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoWideAuxControlAuxOffAlias_A37252.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F18:
			this.CpyBtnRadErgoWideStealthSaveStealthMode_A36491 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F25:
			this.CVBtnHomeModeChannel = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F32:
			this.CVBtnRadErgoWideStealthDisableTones_A36487 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F3F:
			this.CVBtnRadErgoWideAdvancedFixedVolumeEnable_A37218 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F4C:
			this.RadErgoWideHornandLightsHornLights_A8206Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F59:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1F66:
			this.RadErgoWideHornandLightsHornDurationsec_A8207 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideHornandLightsHornDurationsec_A8207.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F8A:
			this.RadErgoWidePASirenExternalRadioIgnition_A7992 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWidePASirenExternalRadioIgnition_A7992.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1FAE:
			this.HLinkPresetZoneAndChannel = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPresetZoneAndChannel.Click += this.HLinkClick;
			return;
			IL_1FD2:
			this.CVBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FDF:
			this.CVBtnRadErgoWideAdvancedFixedVolumeLevel_A37219 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FEC:
			this.CVBtnRadErgoWideHornandLightsLightDurationsec_A8430 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FF9:
			this.CVBtnRadErgoWideHomeModeZone_A9691 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2006:
			this.LblRadErgoWideControlHeadAggregateCableLength_A38456 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadAggregateCableLength_A38456.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_202A:
			this.RadErgoWidePASirenExternalRadioIgnition_A7992Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2037:
			this.LblRadErgoWideHornandLightsPermanentHornLights_A8697 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsPermanentHornLights_A8697.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_205B:
			this.CpyBtnRadErgoWideHornandLightsHornDurationsec_A8207 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2068:
			this.LblRadErgoWideAdvancedMFKInactivityTimeout_A38507 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedMFKInactivityTimeout_A38507.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_208C:
			this.CVBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2099:
			this.CVBtnPresetModeSelect = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20A6:
			this.RadErgoWidePASirenDefaultPAVolumeLevel_A7812Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_20B3:
			this.CVBtnRadErgoWideControlHeadPowerUpBrightness = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20C0:
			this.LabtoolPresetChannel_A41080Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_20CD:
			this.LblRadErgoWideAdvancedSideButtonsLockEnable_A38725 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedSideButtonsLockEnable_A38725.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20F1:
			this.CVBtnRadErgoWideAuxControlActiveDuration_A37249 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20FE:
			this.HLinkStealth = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkStealth.Click += this.HLinkClick;
			return;
			IL_2122:
			this.CVBtnRadErgoWideControlHeadMultiControlHead_A8550 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_212F:
			this.LblRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2153:
			this.RTDBtnRadErgoWidePASirenPAIgnitionSense_A8683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2160:
			this.CpyBtnRadErgoWidePASirenSirenOperation_A9139 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_216D:
			this.CpyBtnPresetModeSelect = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_217A:
			this.ExpanderRadioErgonomicsWideAuxControlTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2187:
			this.CpyBtnRadErgoWideAdvancedConsoletteEnable_A37231 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2194:
			this.CpyBtnRadErgoWideAdvancedShortKeypressDurationms_A9125 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21A1:
			this.RTDBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21AE:
			this.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_21D2:
			this.LblRadioErgoWideControlHeadBlockDarkestDimLevel = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoWideControlHeadBlockDarkestDimLevel.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21F6:
			this.RadErgoWideAdvancedLogicalSwitch2_A7756 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedLogicalSwitch2_A7756.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_221A:
			this.GrpBoxExpanderRadioErgonomicsWideLogicalProfileConfigurationPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2227:
			this.RadErgoWideAdvancedFixedVolumeEnable_A37218Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2234:
			this.RadErgoWidePASirenSirenPAAfterReset_A9140Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2241:
			this.LblHomeModeChannel = (global::AcpUI.AcpLabel)target;
			this.LblHomeModeChannel.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2265:
			this.CVBtnRadErgoWidePASirenPAIgnitionSense_A8683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2272:
			this.LblRadErgoWidePASirenSirenPAAfterReset_A9140 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenSirenPAAfterReset_A9140.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2296:
			this.CVBtnLabtoolPresetChannel_A41080 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22A3:
			this.RadErgoWideAuxControlAuxOffAlias_A37252_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_22B0:
			this.RTDBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22BD:
			this.RadErgoWideHornandLightsHornDurationsec_A8207Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22CA:
			this.RadErgoWidePASirenSirenOperation_A9139Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22D7:
			this.RTDBtnRadErgoWideStealthDisableLightLED_A36482 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22E4:
			this.LblRadErgoWideControlHeadTransceiverVolumeControl_A9405 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadTransceiverVolumeControl_A9405.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2308:
			this.RadErgoWideControlHeadAggregateCableLength_A38456Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2315:
			this.RTDBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2322:
			this.RTDBtnRadErgoWidePASirenHiLoAirhornTones_A8200 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_232F:
			this.RTDBtnRadErgoWideAdvancedTouchScreenLockEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_233C:
			this.RadErgoWidePASirenOptionsAudioMuting_A8623Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2349:
			this.RadErgoWideControlHeadAggregateCableLength_A38456 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadAggregateCableLength_A38456.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_236D:
			this.CpyBtnRadErgoWideAuxControlAuxOffAlias_A37252 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_237A:
			this.PresetModeSelectComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2387:
			this.RTDBtnRadErgoWideHornandLightsPermanentHornLights_A8697 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2394:
			this.RadErgoWideLogicalProfileConfigurationCovertProfile_A43135Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23A1:
			this.RadErgoWideAdvancedFixedVolumeEnable_A37218 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedFixedVolumeEnable_A37218.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23C5:
			this.RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23D2:
			this.CpyBtnRadErgoWideAdvancedFixedVolumeLevel_A37219 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23DF:
			this.LblRadErgoWideControlHeadMultiControlHead_A8550 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadMultiControlHead_A8550.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2403:
			this.RadErgoWideLogicalProfileConfigurationCovertProfile_A43135 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideLogicalProfileConfigurationCovertProfile_A43135.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2427:
			this.RadErgoWideAdvancedZoneBankOperation_A37543Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2434:
			this.RadErgoWideAdvancedToggleSwitchLockEnable_43773Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2441:
			this.CVBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_244E:
			this.CpyBtnRadWideNVGBacklightBrightnessLevel_A41616 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_245B:
			this.RTDBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2468:
			this.ExpanderRadioErgonomicsWideAuxControlTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2475:
			this.CVBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2482:
			this.GrpBoxExpanderRadioErgonomicsWideHornAndLightsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_248F:
			this.RTDBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_249C:
			this.LblRadErgoWideControlHeadControlHead1Alias_A7718 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadControlHead1Alias_A7718.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_24C0:
			this.gridExpanderRadioErgonomicsWidePresetZoneAndChannelTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_24CD:
			this.RadErgoWideAdvancedActiveMicForRadioPTT_A38766Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24DA:
			this.CVBtnRadErgoWideAdvancedNumberofZoneBanks_A37256 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24E7:
			this.ExpanderRadioErgonomicsWideHomeMode = (global::AcpUI.AcpExpander)target;
			return;
			IL_24F4:
			this.RadErgoWideHornAndLightsTwoAlarmOption_A9510Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2501:
			this.RadErgoWideAdvancedBTReceiveAudio_43052Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_250E:
			this.RadErgoWideHornandLightsPermanentHornLights_A8697 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideHornandLightsPermanentHornLights_A8697.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2532:
			this.CVBtnRadErgoWideAuxControlAuxOnAlias_A37250 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_253F:
			this.RTDBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_254C:
			this.RadErgoWideAuxControlAuxCtrlName_A37714 = (global::AcpUI.AcpLabel)target;
			this.RadErgoWideAuxControlAuxCtrlName_A37714.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2570:
			this.LblRadErgoWideHornandLightsLightDurationsec_A8430 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsLightDurationsec_A8430.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2594:
			this.RTDBtnRadErgoWideStealthSaveStealthMode_A36491 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25A1:
			this.RadErgoWideAuxControlAuxOffAlias_A37252Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25AE:
			this.CVBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25BB:
			this.RTDBtnRadErgoWideHornandLightsAlarmRearmOption_A7423 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25C8:
			this.CVBtnRadErgoWideHornandLightsPermanentHornLights_A8697 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25D5:
			this.LblRadErgoWideAdvancedZoneBankOperation_A37543 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedZoneBankOperation_A37543.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25F9:
			this.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_261D:
			this.RTDBtnRadErgoWideMOSCADDataEnable_A8545 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_262A:
			this.LblRadErgoWideAdvancedSoftPowerOff_A9170 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedSoftPowerOff_A9170.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_264E:
			this.RadErgoWideHomeModeZone_A9691Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_265B:
			this.LblRadErgoWideAdvancedShortKeypressDurationforMFK_A38505 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedShortKeypressDurationforMFK_A38505.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_267F:
			this.RadioErgoWideControlHeadBlockDarkestDimLevel = (global::AcpUI.AcpCheckBox)target;
			this.RadioErgoWideControlHeadBlockDarkestDimLevel.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26A3:
			this.LblRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26C7:
			this.RadErgoWideControlHeadTransceiverVolumeControl_A9405 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadTransceiverVolumeControl_A9405.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26EB:
			this.CpyBtnRadErgoWideControlHeadMultiControlHead_A8550 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26F8:
			this.CpyBtnRadErgoWideControlHeadPowerUpBrightness = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2705:
			this.RTDBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2712:
			this.CpyBtnRadErgoWidePASirenPAIgnitionSense_A8683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_271F:
			this.RadErgoWideHornandLightsAlarmType_A7424 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideHornandLightsAlarmType_A7424.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2743:
			this.RadErgoWideAdvancedLogicalSwitch2_A7756Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2750:
			this.CpyBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_275D:
			this.RTDBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_276A:
			this.RTDBtnRadErgoWideHornandLightsHornLights_A8206 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2777:
			this.LblRadErgoWideHornandLightsAlarmType_A7424 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsAlarmType_A7424.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_279B:
			this.LblRadErgoWideAdvancedShortKeypressDurationms_A9125 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedShortKeypressDurationms_A9125.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27BF:
			this.RadErgoWideControlHeadControlHead1Alias_A7718_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_27CC:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannelTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_27D9:
			this.CVBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27E6:
			this.CpyBtnRadErgoWideControlHeadControlHead1Alias_A7718 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27F3:
			this.LblRadErgoWideStealthDisableTones_A36487 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideStealthDisableTones_A36487.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2817:
			this.RadErgoWideControlHeadMultipleControlHeadStyle_A8561 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_283B:
			this.CVBtnRadErgoWideAdvancedBTReceiveAudio_43052 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2848:
			this.GrpBoxExpanderRadioErgonomicsWidePASirenPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2855:
			this.CpyBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2862:
			this.RadErgoWideControlHeadTransceiverVolumeControl_A9405Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_286F:
			this.RadioErgoCfgExternalAccessoryEnable_A36198Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_287C:
			this.LblRadErgoWideAdvancedLongKeypressDurationms_A8450 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedLongKeypressDurationms_A8450.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28A0:
			this.CpyBtnRadErgoWideStealthDisableLightLED_A36482 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28AD:
			this.LblRadErgoWideAuxControlAuxCtrlName_A37714 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAuxControlAuxCtrlName_A37714.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28D1:
			this.CVBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28DE:
			this.LabtoolPresetZone_A41079Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28EB:
			this.RadErgoWideAdvancedSoftPowerOff_A9170Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28F8:
			this.GrpBoxExpanderRadioErgonomicsWideControlHeadPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2905:
			this.RTDBtnRadErgoWideControlHeadPowerUpBrightness = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2912:
			this.CpyBtnRadErgoWideStealthDisableTones_A36487 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_291F:
			this.CpyBtnRadErgoWideAdvancedLongKeypressDurationms_A8450 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_292C:
			this.LblRadErgoWideAdvancedActiveMicForRSMPTT_43050 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedActiveMicForRSMPTT_43050.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2950:
			this.RadErgoWideAuxControlAbbrAuxOnAlias_A37612Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_295D:
			this.CpyBtnRadErgoWidePASirenSirenPAAfterReset_A9140 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_296A:
			this.RadErgoWideAdvancedSoftPowerOff_A9170 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedSoftPowerOff_A9170.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_298E:
			this.RTDBtnRadErgoWideAuxControlAuxOnAlias_A37250 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_299B:
			this.RTDBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29A8:
			this.RadErgoWideAdvancedConsoletteEnable_A37231 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedConsoletteEnable_A37231.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29CC:
			this.RadErgoWidePASirenSirenOperation_A9139 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWidePASirenSirenOperation_A9139.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29F0:
			this.RadErgoWideControlHeadTransceiverDEKDimControl_A9404 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadTransceiverDEKDimControl_A9404.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A14:
			this.CpyBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A21:
			this.LblRadErgoWideAdvancedToggleSwitchLockEnable_43773 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedToggleSwitchLockEnable_43773.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A45:
			this.GrpBoxExpanderRadioErgonomicsWideHornAndLightsAlarm = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2A52:
			this.LabtoolPresetChannel_A41080 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LabtoolPresetChannel_A41080.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A76:
			this.CVBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A83:
			this.RTDBtnRadErgoWideAdvancedConsoletteEnable_A37231 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A90:
			this.RadErgoWideAdvancedActiveMicForRadioPTT_A38766 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedActiveMicForRadioPTT_A38766.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2AB4:
			this.CVBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AC1:
			this.CVBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2ACE:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannelTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2ADB:
			this.RTDBtnRadErgoWideAuxControlActiveDuration_A37249 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AE8:
			this.LblRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B0C:
			this.RadErgoWideHornAndLightsTwoAlarmOption_A9510 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideHornAndLightsTwoAlarmOption_A9510.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B30:
			this.RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B3D:
			this.CpyBtnRadErgoWideHornandLightsAlarmType_A7424 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B4A:
			this.RTDBtnRadErgoWideAdvancedFixedVolumeEnable_A37218 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B57:
			this.ExpanderRadioErgonomicsWideControlHead = (global::AcpUI.AcpExpander)target;
			return;
			IL_2B64:
			this.CVBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B71:
			this.RTDBtnRadErgoWideControlHeadBluetoothControl_44820 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B7E:
			this.CVBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B8B:
			this.RTDBtnRadErgoWideAdvancedZoneBankOperation_A37543 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B98:
			this.LblRadErgoWideAdvancedNumberofZoneBanks_A37256 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedNumberofZoneBanks_A37256.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2BBC:
			this.LblRadErgoWideControlHeadExpectedNumofControlHeads_A7982 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadExpectedNumofControlHeads_A7982.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2BE0:
			this.RTDBtnLabtoolPresetZone_A41079 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BED:
			this.RTDBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BFA:
			this.RadErgoWideAdvancedSideButtonsLockEnable_A38725Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2C07:
			this.LblRadErgoWideHomeModeZone_A9691 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHomeModeZone_A9691.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C2B:
			this.CpyBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C38:
			this.LblRadErgoWideAdvancedConsoletteFatalError_A37233 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedConsoletteFatalError_A37233.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C5C:
			this.RTDBtnRadErgoWideAdvancedLogicalSwitch2_A7756 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C69:
			this.CpyBtnRadErgoWideAdvancedSoftPowerOff_A9170 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C76:
			this.CVBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C83:
			this.CpyBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C90:
			this.ExpanderRadioErgonomicsWideStealth = (global::AcpUI.AcpExpander)target;
			return;
			IL_2C9D:
			this.CpyBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CAA:
			this.LblRadErgoWideControlHeadIntercomTimeoutTimersec_A8297 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadIntercomTimeoutTimersec_A8297.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CCE:
			this.RadErgoWideControlHeadMulCHTxAudioRouting_A38459Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2CDB:
			this.RadErgoWideAdvancedShortKeypressDurationms_A9125Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CE8:
			this.CpyBtnRadioErgoCfgExternalAccessoryEnable_A36198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CF5:
			this.RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D19:
			this.LblRadErgoWidePASirenPAIgnitionSense_A8683 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenPAIgnitionSense_A8683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D3D:
			this.LblRadErgoWideLogicalProfileConfigurationCovertProfile_A43135 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideLogicalProfileConfigurationCovertProfile_A43135.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D61:
			this.LblPresetModeSelect = (global::AcpUI.AcpLabel)target;
			this.LblPresetModeSelect.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D85:
			this.RadErgoWidePASirenOptionsAudioMuting_A8623 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWidePASirenOptionsAudioMuting_A8623.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2DA9:
			this.CpyBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DB6:
			this.GrpBoxExpanderRadioErgonomicsWideAdvancedPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2DC3:
			this.RTDBtnRadErgoWidePASirenOptionsAudioMuting_A8623 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DD0:
			this.CVBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DDD:
			this.RadWideGeneralConfigurablePresetZoneAndChannel_A44917 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideGeneralConfigurablePresetZoneAndChannel_A44917.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E01:
			this.RTDBtnRadErgoWideAdvancedFixedVolumeLevel_A37219 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E0E:
			this.RTDBtnRadWideNVGBacklightBrightnessLevel_A41616 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E1B:
			this.RadErgoWideControlHeadMultiControlHead_A8550 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideControlHeadMultiControlHead_A8550.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E3F:
			this.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E63:
			this.CVBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E70:
			this.RTDBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E7D:
			this.CpyBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E8A:
			this.LblRadErgoWideHornandLightsExternalAlarmDelaysec_A7984 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornandLightsExternalAlarmDelaysec_A7984.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EAE:
			this.LblRadErgoWideHornAndLightsTwoAlarmOption_A9510 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideHornAndLightsTwoAlarmOption_A9510.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2ED2:
			this.PresetModeSelect = (global::AcpUI.AcpLabel)target;
			this.PresetModeSelect.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EF6:
			this.CpyBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F03:
			this.RadErgoWideAdvancedActiveMicForRSMPTT_43050 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedActiveMicForRSMPTT_43050.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F27:
			this.RTDBtnPresetModeSelect = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F34:
			this.RadErgoWideAuxControlActiveDuration_A37249_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2F41:
			this.LblRadErgoWideSideAdvancedMFBInactivityTimeout_A41565 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideSideAdvancedMFBInactivityTimeout_A41565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F65:
			this.LblRadErgoWidePASirenManualTone_A8464 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenManualTone_A8464.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F89:
			this.RadErgoWideAuxControlAbbrAuxOnAlias_A37612 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoWideAuxControlAbbrAuxOnAlias_A37612.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FAD:
			this.RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FD1:
			this.GrpBoxExpanderPresetZoneAndChannelPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2FDE:
			this.LblRadErgoWideAdvancedLongKeypressDurationforMFK_A38506 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedLongKeypressDurationforMFK_A38506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3002:
			this.RadErgoWideControlHeadControlHeadVIPInputSource_A7724Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_300F:
			this.RadErgoWideAdvancedNumberofZoneBanks_A37256 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedNumberofZoneBanks_A37256.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3033:
			this.CVBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3040:
			this.RadErgoWideAdvancedDefaultCHHubState_A37222 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedDefaultCHHubState_A37222.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3064:
			this.RadErgoWideAdvancedActiveMicForIndirectPTT_44816 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedActiveMicForIndirectPTT_44816.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3088:
			this.ExpanderRadioErgonomicsWideControlHeadAliasListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3095:
			this.CpyBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_30A2:
			this.RTDBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30AF:
			this.RadErgoWideAuxControlAuxCtrlName_A37714Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30BC:
			this.LblRadErgoWidePASirenHiLoAirhornTones_A8200 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWidePASirenHiLoAirhornTones_A8200.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30E0:
			this.LblRadErgoWideStealthSaveStealthMode_A36491 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideStealthSaveStealthMode_A36491.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3104:
			this.ExpanderRadioErgonomicsWideControlHeadGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3111:
			this.RadErgoWideControlHeadIntercomTimeoutTimersec_A8297 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideControlHeadIntercomTimeoutTimersec_A8297.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3135:
			this.RadErgoWideAdvancedConsoletteFatalError_A37233Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3142:
			this.CVBtnLabtoolPresetZone_A41079 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_314F:
			this.RTDBtnRadErgoWideAdvancedConsoletteFatalError_A37233 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_315C:
			this.CVBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3169:
			this.CVBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3176:
			this.ExpanderRadioErgonomicsWideControlHeadAliasListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3183:
			this.RadErgoWideAuxControlActiveDuration_A37249 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAuxControlActiveDuration_A37249.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31A7:
			this.LblRadErgoWideControlHeadPowerUpBrightness = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadPowerUpBrightness.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31CB:
			num = (short)312092627;
			short num4 = num;
			num = (short)877340627;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_3111;
			default:
				num = (short)1447755776;
				if (num != 0)
				{
				}
				this.CpyBtnRadErgoWideAdvancedBTReceiveAudio_43052 = (global::AcpUI.AcpCopyButton)target;
				return;
			}
			IL_3224:
			this.RadErgoWideAdvancedBTReceiveAudio_43052 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedBTReceiveAudio_43052.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3248:
			this.RadErgoWideStealthDisableLightLED_A36482Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3255:
			this.CVBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3262:
			this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable.ModeClick += this.OnModeClick;
			return;
			IL_3286:
			this.ExpanderRadioErgonomicsWidePASiren = (global::AcpUI.AcpExpander)target;
			return;
			IL_3293:
			this.CpyBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32A0:
			this.RadErgoWidePASirenSirenIgnitionSense_A9138 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWidePASirenSirenIgnitionSense_A9138.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32C4:
			this.LabtoolPresetZone_A41079_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_32D1:
			this.CVBtnRadioErgoCfgFatalError_A36202 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32DE:
			this.RTDBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32EB:
			this.RadErgoWidePASirenHiLoAirhornTones_A8200 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWidePASirenHiLoAirhornTones_A8200.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_330F:
			this.RadErgoWideControlHeadTransceiverDEKDimControl_A9404Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_331C:
			this.LblRadErgoWideAdvancedActiveMicForRadioPTT_A38766 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedActiveMicForRadioPTT_A38766.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3340:
			this.RTDBtnHomeModeChannel = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_334D:
			this.RadErgoWideControlHeadMulCHTxAudioRouting_A38459 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideControlHeadMulCHTxAudioRouting_A38459.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3371:
			this.ExpanderRadioErgonomicsWideControlHeadAliasList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_337E:
			this.RadErgoWideAuxControlActiveDuration_A37249Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_338B:
			this.CVBtnRadErgoWidePASirenSirenIgnitionSense_A9138 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3398:
			this.CpyBtnLabtoolPresetChannel_A41080 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33A5:
			this.LblRadErgoWideStealthDisableLightLED_A36482 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideStealthDisableLightLED_A36482.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33C9:
			this.CpyBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33D6:
			this.HLinkPASiren = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPASiren.Click += this.HLinkClick;
			return;
			IL_33FA:
			this.CpyBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3407:
			this.CpyBtnRadErgoWideControlHeadAggregateCableLength_A38456 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3414:
			this.RadErgoWideStealthSaveStealthMode_A36491 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideStealthSaveStealthMode_A36491.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3438:
			this.RadErgoWideControlHeadMultiControlHead_A8550Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3445:
			this.LblRadErgoWideAuxControlAbbrAuxOnAlias_A37612 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAuxControlAbbrAuxOnAlias_A37612.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3469:
			this.RadErgoWideMOSCADDataEnable_A8545 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideMOSCADDataEnable_A8545.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_348D:
			this.RadErgoWideAuxControlAuxOnAlias_A37250Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_349A:
			this.ExpanderRadioErgonomicsWideHornAndLights = (global::AcpUI.AcpExpander)target;
			return;
			IL_34A7:
			this.RadErgoWideAdvancedNumberofZoneBanks_A37256Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_34B4:
			this.CVBtnRadErgoWideHomeModeHomeModeSelection_A8202 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34C1:
			this.RadErgoWideControlHeadPowerUpBrightnessComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_34CE:
			this.LblRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_34F2:
			this.LblRadWideGeneralConfigurablePresetZoneAndChannel_A44917 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralConfigurablePresetZoneAndChannel_A44917.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3516:
			this.RTDBtnRadErgoWideHomeModeHomeModeSelection_A8202 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3523:
			this.RTDBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3530:
			this.CpyBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_353D:
			this.ExpanderRadioErgonomicsWidePresetZoneAndChannelGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_354A:
			this.CVBtnRadErgoWideHornandLightsAlarmType_A7424 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3557:
			this.RadErgoWideControlHeadControlHeadVIPInputSource_A7724 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideControlHeadControlHeadVIPInputSource_A7724.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_357B:
			this.RTDBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3588:
			this.CVBtnRadErgoWideAdvancedSoftPowerOff_A9170 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3595:
			this.HLinkHornAndLights = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkHornAndLights.Click += this.HLinkClick;
			return;
			IL_35B9:
			this.LblRadErgoWideAuxControlAuxOnAlias_A37250 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAuxControlAuxOnAlias_A37250.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35DD:
			this.CpyBtnRadErgoWideAuxControlAuxCtrlName_A37714 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35EA:
			this.HLinkAuxControl = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAuxControl.Click += this.HLinkClick;
			return;
			IL_360E:
			this.RadWideNVGBacklightBrightnessLevel_A41616 = (global::AcpUI.AcpComboBox)target;
			this.RadWideNVGBacklightBrightnessLevel_A41616.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3632:
			this.RTDBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_363F:
			this.CVBtnRadErgoWideControlHeadAggregateCableLength_A38456 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_364C:
			this.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3670:
			this.LabtoolPresetZone_A41079 = (global::AcpUI.AcpComboBox)target;
			this.LabtoolPresetZone_A41079.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3694:
			this.LblRadErgoWideAdvancedConsoletteEnable_A37231 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedConsoletteEnable_A37231.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36B8:
			this.LblRadErgoWideAdvancedActiveMicForBTPTT_43051 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedActiveMicForBTPTT_43051.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36DC:
			this.RTDBtnRadErgoWideControlHeadMultiControlHead_A8550 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36E9:
			this.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_36F6:
			this.RTDBtnRadErgoWideHomeModeZone_A9691 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3703:
			this.CpyBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3710:
			this.CpyBtnRadioErgoWideControlHeadBlockDarkestDimLevel = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_371D:
			this.LblRadErgoWideControlHeadMultipleControlHeadStyle_A8561 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadMultipleControlHeadStyle_A8561.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3741:
			this.CVBtnRadErgoWidePASirenSirenOperation_A9139 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_374E:
			this.CpyBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_375B:
			this.HLinkAdvanced = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvanced.Click += this.HLinkClick;
			return;
			IL_377F:
			this.CVBtnRadErgoWideControlHeadControlHead1Alias_A7718 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_378C:
			this.RTDBtnRadErgoWideAdvancedActiveMicForBTPTT_43051 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3799:
			this.RTDBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37BE:
			goto IL_38D5;
			IL_37C3:
			this.RadErgoWidePASirenManualTone_A8464Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37D0:
			this.LblRadErgoWideControlHeadBluetoothControl_44820 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideControlHeadBluetoothControl_44820.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37F4:
			this.CpyBtnHomeModeChannel = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3801:
			this.CpyBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_380E:
			this.RTDBtnRadErgoWideAuxControlAuxOffAlias_A37252 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_381B:
			this.GrpBoxExpanderRadioErgonomicsWideStealthStealthMode = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3828:
			this.RadErgoWideAdvancedToggleSwitchLockEnable_43773 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideAdvancedToggleSwitchLockEnable_43773.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_384C:
			this.CpyBtnRadErgoWidePASirenSirenIgnitionSense_A9138 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3859:
			this.RTDBtnRadioErgoCfgFatalError_A36202 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3866:
			this.CVBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3873:
			this.RadErgoWideHornandLightsExternalAlarmDelaysec_A7984 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoWideHornandLightsExternalAlarmDelaysec_A7984.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3897:
			this.RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_38A4:
			this.gridExpanderRadioErgonomicsWideAuxControlTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_38B1:
			this.RadErgoWideAdvancedZoneBankOperation_A37543 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedZoneBankOperation_A37543.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_38D5:
			this.b = true;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x005D2810 File Offset: 0x005D0A10
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)992608256;
			short num2 = num;
			switch (connectionId)
			{
			case 2:
				num = (short)294453249;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
			{
				num = (short)172119870;
				short num3 = num;
				num = (short)225072958;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1177747456;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 8:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040026C4 RID: 9924
		private bool a;

		// Token: 0x040026C5 RID: 9925
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040026C6 RID: 9926
		internal global::System.Windows.Documents.Hyperlink HLinkHomeMode;

		// Token: 0x040026C7 RID: 9927
		internal global::System.Windows.Documents.Hyperlink HLinkControlHead;

		// Token: 0x040026C8 RID: 9928
		internal global::System.Windows.Documents.Hyperlink HLinkPASiren;

		// Token: 0x040026C9 RID: 9929
		internal global::System.Windows.Documents.Hyperlink HLinkHornAndLights;

		// Token: 0x040026CA RID: 9930
		internal global::System.Windows.Documents.Hyperlink HLinkStealth;

		// Token: 0x040026CB RID: 9931
		internal global::System.Windows.Documents.Hyperlink HLinkAdvanced;

		// Token: 0x040026CC RID: 9932
		internal global::System.Windows.Documents.Hyperlink HLinkAuxControl;

		// Token: 0x040026CD RID: 9933
		internal global::System.Windows.Documents.Hyperlink HLinkPresetZoneAndChannel;

		// Token: 0x040026CE RID: 9934
		internal global::System.Windows.Documents.Hyperlink HLinkLogicalProfileConfiguration;

		// Token: 0x040026CF RID: 9935
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040026D0 RID: 9936
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideHomeMode;

		// Token: 0x040026D1 RID: 9937
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideHomeModePseudo0;

		// Token: 0x040026D2 RID: 9938
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026D3 RID: 9939
		internal global::AcpUI.AcpLabel LblRadErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026D4 RID: 9940
		internal global::AcpUI.AcpCheckBox RadErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026D5 RID: 9941
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026D6 RID: 9942
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026D7 RID: 9943
		internal global::AcpUI.AcpCheckBox RadErgoWideHomeModeHomeModeSelection_A8202Comp;

		// Token: 0x040026D8 RID: 9944
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHomeModeZone_A9691;

		// Token: 0x040026D9 RID: 9945
		internal global::AcpUI.AcpLabel LblRadErgoWideHomeModeZone_A9691;

		// Token: 0x040026DA RID: 9946
		internal global::AcpUI.AcpComboBox RadErgoWideHomeModeZone_A9691;

		// Token: 0x040026DB RID: 9947
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHomeModeZone_A9691;

		// Token: 0x040026DC RID: 9948
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHomeModeZone_A9691;

		// Token: 0x040026DD RID: 9949
		internal global::AcpUI.AcpLabel RadErgoWideHomeModeZone_A9691Comp;

		// Token: 0x040026DE RID: 9950
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnHomeModeChannel;

		// Token: 0x040026DF RID: 9951
		internal global::AcpUI.AcpLabel LblHomeModeChannel;

		// Token: 0x040026E0 RID: 9952
		internal global::AcpUI.AcpTextBoxSpinner HomeModeChannel;

		// Token: 0x040026E1 RID: 9953
		internal global::AcpUI.AcpRtdButton RTDBtnHomeModeChannel;

		// Token: 0x040026E2 RID: 9954
		internal global::AcpUI.AcpCopyButton CpyBtnHomeModeChannel;

		// Token: 0x040026E3 RID: 9955
		internal global::AcpUI.AcpLabel HomeModeChannelComp;

		// Token: 0x040026E4 RID: 9956
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideControlHead;

		// Token: 0x040026E5 RID: 9957
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioErgonomicsWideControlHeadAliasList;

		// Token: 0x040026E6 RID: 9958
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideControlHeadPseudo0;

		// Token: 0x040026E7 RID: 9959
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x040026E8 RID: 9960
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x040026E9 RID: 9961
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x040026EA RID: 9962
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x040026EB RID: 9963
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x040026EC RID: 9964
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadMultiControlHead_A8550Comp;

		// Token: 0x040026ED RID: 9965
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x040026EE RID: 9966
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x040026EF RID: 9967
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x040026F0 RID: 9968
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x040026F1 RID: 9969
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x040026F2 RID: 9970
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725Comp;

		// Token: 0x040026F3 RID: 9971
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x040026F4 RID: 9972
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x040026F5 RID: 9973
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x040026F6 RID: 9974
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x040026F7 RID: 9975
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x040026F8 RID: 9976
		internal global::AcpUI.AcpCheckBox RadErgoWideControlHeadMulCHTxAudioRouting_A38459Comp;

		// Token: 0x040026F9 RID: 9977
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x040026FA RID: 9978
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x040026FB RID: 9979
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x040026FC RID: 9980
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x040026FD RID: 9981
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x040026FE RID: 9982
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadAggregateCableLength_A38456Comp;

		// Token: 0x040026FF RID: 9983
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002700 RID: 9984
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002701 RID: 9985
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002702 RID: 9986
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002703 RID: 9987
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002704 RID: 9988
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadExpectedNumofControlHeads_A7982Comp;

		// Token: 0x04002705 RID: 9989
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x04002706 RID: 9990
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x04002707 RID: 9991
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x04002708 RID: 9992
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x04002709 RID: 9993
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x0400270A RID: 9994
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadMultipleControlHeadStyle_A8561Comp;

		// Token: 0x0400270B RID: 9995
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x0400270C RID: 9996
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x0400270D RID: 9997
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x0400270E RID: 9998
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x0400270F RID: 9999
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x04002710 RID: 10000
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Comp;

		// Token: 0x04002711 RID: 10001
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x04002712 RID: 10002
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x04002713 RID: 10003
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x04002714 RID: 10004
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x04002715 RID: 10005
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x04002716 RID: 10006
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadRemoteMicSource_A8930Comp;

		// Token: 0x04002717 RID: 10007
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x04002718 RID: 10008
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x04002719 RID: 10009
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x0400271A RID: 10010
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x0400271B RID: 10011
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x0400271C RID: 10012
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadBluetoothControl_44820Comp;

		// Token: 0x0400271D RID: 10013
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x0400271E RID: 10014
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x0400271F RID: 10015
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x04002720 RID: 10016
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x04002721 RID: 10017
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x04002722 RID: 10018
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadControlHeadVIPInputSource_A7724Comp;

		// Token: 0x04002723 RID: 10019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x04002724 RID: 10020
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x04002725 RID: 10021
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x04002726 RID: 10022
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x04002727 RID: 10023
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x04002728 RID: 10024
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadTransceiverVolumeControl_A9405Comp;

		// Token: 0x04002729 RID: 10025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400272A RID: 10026
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400272B RID: 10027
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400272C RID: 10028
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400272D RID: 10029
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400272E RID: 10030
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadTransceiverDEKDimControl_A9404Comp;

		// Token: 0x0400272F RID: 10031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002730 RID: 10032
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002731 RID: 10033
		internal global::AcpUI.AcpComboBox RadErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002732 RID: 10034
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002733 RID: 10035
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002734 RID: 10036
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadPowerUpBrightnessComp;

		// Token: 0x04002735 RID: 10037
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoWideControlHeadBlockDarkestDimLevel;

		// Token: 0x04002736 RID: 10038
		internal global::AcpUI.AcpLabel LblRadioErgoWideControlHeadBlockDarkestDimLevel;

		// Token: 0x04002737 RID: 10039
		internal global::AcpUI.AcpCheckBox RadioErgoWideControlHeadBlockDarkestDimLevel;

		// Token: 0x04002738 RID: 10040
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoWideControlHeadBlockDarkestDimLevel;

		// Token: 0x04002739 RID: 10041
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoWideControlHeadBlockDarkestDimLevel;

		// Token: 0x0400273A RID: 10042
		internal global::AcpUI.AcpCheckBox RadioErgoWideControlHeadBlockDarkestDimLevelComp;

		// Token: 0x0400273B RID: 10043
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWideControlHeadGrid;

		// Token: 0x0400273C RID: 10044
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWideControlHeadAliasListGrid;

		// Token: 0x0400273D RID: 10045
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWideControlHeadAliasListTableView;

		// Token: 0x0400273E RID: 10046
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioErgonomicsWideControlHeadAliasList;

		// Token: 0x0400273F RID: 10047
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideControlHeadControlHead1Alias_A7718_Col;

		// Token: 0x04002740 RID: 10048
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWideControlHeadAliasListSRecView;

		// Token: 0x04002741 RID: 10049
		internal global::System.Windows.Controls.Grid gridExpanderRadioErgonomicsWideControlHeadAliasListSRecView;

		// Token: 0x04002742 RID: 10050
		internal global::AcpUI.AcpTextBox RadErgoWideControlHeadControlHead1Alias_A7718;

		// Token: 0x04002743 RID: 10051
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideControlHeadControlHead1Alias_A7718;

		// Token: 0x04002744 RID: 10052
		internal global::AcpUI.AcpLabel LblRadErgoWideControlHeadControlHead1Alias_A7718;

		// Token: 0x04002745 RID: 10053
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideControlHeadControlHead1Alias_A7718;

		// Token: 0x04002746 RID: 10054
		internal global::AcpUI.AcpLabel RadErgoWideControlHeadControlHead1Alias_A7718Comp;

		// Token: 0x04002747 RID: 10055
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWidePASiren;

		// Token: 0x04002748 RID: 10056
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWidePASirenPseudo0;

		// Token: 0x04002749 RID: 10057
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenSirenOperation_A9139;

		// Token: 0x0400274A RID: 10058
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenSirenOperation_A9139;

		// Token: 0x0400274B RID: 10059
		internal global::AcpUI.AcpComboBox RadErgoWidePASirenSirenOperation_A9139;

		// Token: 0x0400274C RID: 10060
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenSirenOperation_A9139;

		// Token: 0x0400274D RID: 10061
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenSirenOperation_A9139;

		// Token: 0x0400274E RID: 10062
		internal global::AcpUI.AcpLabel RadErgoWidePASirenSirenOperation_A9139Comp;

		// Token: 0x0400274F RID: 10063
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWidePASirenPublicAddress;

		// Token: 0x04002750 RID: 10064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x04002751 RID: 10065
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x04002752 RID: 10066
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x04002753 RID: 10067
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x04002754 RID: 10068
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x04002755 RID: 10069
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenOptionsAudioMuting_A8623Comp;

		// Token: 0x04002756 RID: 10070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x04002757 RID: 10071
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x04002758 RID: 10072
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x04002759 RID: 10073
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x0400275A RID: 10074
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x0400275B RID: 10075
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenExternalRadioIgnition_A7992Comp;

		// Token: 0x0400275C RID: 10076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x0400275D RID: 10077
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x0400275E RID: 10078
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x0400275F RID: 10079
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x04002760 RID: 10080
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x04002761 RID: 10081
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenPAIgnitionSense_A8683Comp;

		// Token: 0x04002762 RID: 10082
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x04002763 RID: 10083
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x04002764 RID: 10084
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x04002765 RID: 10085
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x04002766 RID: 10086
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x04002767 RID: 10087
		internal global::AcpUI.AcpLabel RadErgoWidePASirenDefaultPAVolumeLevel_A7812Comp;

		// Token: 0x04002768 RID: 10088
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x04002769 RID: 10089
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x0400276A RID: 10090
		internal global::AcpUI.AcpComboBox RadErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x0400276B RID: 10091
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x0400276C RID: 10092
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x0400276D RID: 10093
		internal global::AcpUI.AcpLabel RadErgoWidePASirenSirenPAAfterReset_A9140Comp;

		// Token: 0x0400276E RID: 10094
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWidePASirenSiren;

		// Token: 0x0400276F RID: 10095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x04002770 RID: 10096
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x04002771 RID: 10097
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x04002772 RID: 10098
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x04002773 RID: 10099
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x04002774 RID: 10100
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenHiLoAirhornTones_A8200Comp;

		// Token: 0x04002775 RID: 10101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenManualTone_A8464;

		// Token: 0x04002776 RID: 10102
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenManualTone_A8464;

		// Token: 0x04002777 RID: 10103
		internal global::AcpUI.AcpComboBox RadErgoWidePASirenManualTone_A8464;

		// Token: 0x04002778 RID: 10104
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenManualTone_A8464;

		// Token: 0x04002779 RID: 10105
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenManualTone_A8464;

		// Token: 0x0400277A RID: 10106
		internal global::AcpUI.AcpLabel RadErgoWidePASirenManualTone_A8464Comp;

		// Token: 0x0400277B RID: 10107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x0400277C RID: 10108
		internal global::AcpUI.AcpLabel LblRadErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x0400277D RID: 10109
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x0400277E RID: 10110
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x0400277F RID: 10111
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x04002780 RID: 10112
		internal global::AcpUI.AcpCheckBox RadErgoWidePASirenSirenIgnitionSense_A9138Comp;

		// Token: 0x04002781 RID: 10113
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideHornAndLights;

		// Token: 0x04002782 RID: 10114
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideHornAndLightsPseudo0;

		// Token: 0x04002783 RID: 10115
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsHornLights_A8206;

		// Token: 0x04002784 RID: 10116
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsHornLights_A8206;

		// Token: 0x04002785 RID: 10117
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsHornLights_A8206;

		// Token: 0x04002786 RID: 10118
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsHornLights_A8206;

		// Token: 0x04002787 RID: 10119
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsHornLights_A8206;

		// Token: 0x04002788 RID: 10120
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsHornLights_A8206Comp;

		// Token: 0x04002789 RID: 10121
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideHornAndLightsHornAndLights;

		// Token: 0x0400278A RID: 10122
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x0400278B RID: 10123
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x0400278C RID: 10124
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x0400278D RID: 10125
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x0400278E RID: 10126
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x0400278F RID: 10127
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsPermanentHornLights_A8697Comp;

		// Token: 0x04002790 RID: 10128
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x04002791 RID: 10129
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x04002792 RID: 10130
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x04002793 RID: 10131
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x04002794 RID: 10132
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x04002795 RID: 10133
		internal global::AcpUI.AcpLabel RadErgoWideHornandLightsHornDurationsec_A8207Comp;

		// Token: 0x04002796 RID: 10134
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x04002797 RID: 10135
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x04002798 RID: 10136
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x04002799 RID: 10137
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x0400279A RID: 10138
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x0400279B RID: 10139
		internal global::AcpUI.AcpLabel RadErgoWideHornandLightsLightDurationsec_A8430Comp;

		// Token: 0x0400279C RID: 10140
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideHornAndLightsAlarm;

		// Token: 0x0400279D RID: 10141
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510;

		// Token: 0x0400279E RID: 10142
		internal global::AcpUI.AcpLabel LblRadErgoWideHornAndLightsTwoAlarmOption_A9510;

		// Token: 0x0400279F RID: 10143
		internal global::AcpUI.AcpCheckBox RadErgoWideHornAndLightsTwoAlarmOption_A9510;

		// Token: 0x040027A0 RID: 10144
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510;

		// Token: 0x040027A1 RID: 10145
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornAndLightsTwoAlarmOption_A9510;

		// Token: 0x040027A2 RID: 10146
		internal global::AcpUI.AcpCheckBox RadErgoWideHornAndLightsTwoAlarmOption_A9510Comp;

		// Token: 0x040027A3 RID: 10147
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040027A4 RID: 10148
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040027A5 RID: 10149
		internal global::AcpUI.AcpComboBox RadErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040027A6 RID: 10150
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040027A7 RID: 10151
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040027A8 RID: 10152
		internal global::AcpUI.AcpLabel RadErgoWideHornandLightsAlarmType_A7424Comp;

		// Token: 0x040027A9 RID: 10153
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040027AA RID: 10154
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040027AB RID: 10155
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040027AC RID: 10156
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040027AD RID: 10157
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040027AE RID: 10158
		internal global::AcpUI.AcpCheckBox RadErgoWideHornandLightsAlarmRearmOption_A7423Comp;

		// Token: 0x040027AF RID: 10159
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040027B0 RID: 10160
		internal global::AcpUI.AcpLabel LblRadErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040027B1 RID: 10161
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040027B2 RID: 10162
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040027B3 RID: 10163
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040027B4 RID: 10164
		internal global::AcpUI.AcpLabel RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Comp;

		// Token: 0x040027B5 RID: 10165
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideStealth;

		// Token: 0x040027B6 RID: 10166
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideStealthStealthMode;

		// Token: 0x040027B7 RID: 10167
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideStealthDisableLightLED_A36482;

		// Token: 0x040027B8 RID: 10168
		internal global::AcpUI.AcpLabel LblRadErgoWideStealthDisableLightLED_A36482;

		// Token: 0x040027B9 RID: 10169
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthDisableLightLED_A36482;

		// Token: 0x040027BA RID: 10170
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideStealthDisableLightLED_A36482;

		// Token: 0x040027BB RID: 10171
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideStealthDisableLightLED_A36482;

		// Token: 0x040027BC RID: 10172
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthDisableLightLED_A36482Comp;

		// Token: 0x040027BD RID: 10173
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideStealthDisableTones_A36487;

		// Token: 0x040027BE RID: 10174
		internal global::AcpUI.AcpLabel LblRadErgoWideStealthDisableTones_A36487;

		// Token: 0x040027BF RID: 10175
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthDisableTones_A36487;

		// Token: 0x040027C0 RID: 10176
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideStealthDisableTones_A36487;

		// Token: 0x040027C1 RID: 10177
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideStealthDisableTones_A36487;

		// Token: 0x040027C2 RID: 10178
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthDisableTones_A36487Comp;

		// Token: 0x040027C3 RID: 10179
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideStealthPseudo1;

		// Token: 0x040027C4 RID: 10180
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideStealthSaveStealthMode_A36491;

		// Token: 0x040027C5 RID: 10181
		internal global::AcpUI.AcpLabel LblRadErgoWideStealthSaveStealthMode_A36491;

		// Token: 0x040027C6 RID: 10182
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthSaveStealthMode_A36491;

		// Token: 0x040027C7 RID: 10183
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideStealthSaveStealthMode_A36491;

		// Token: 0x040027C8 RID: 10184
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideStealthSaveStealthMode_A36491;

		// Token: 0x040027C9 RID: 10185
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthSaveStealthMode_A36491Comp;

		// Token: 0x040027CA RID: 10186
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideAdvanced;

		// Token: 0x040027CB RID: 10187
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideAdvancedPseudo0;

		// Token: 0x040027CC RID: 10188
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x040027CD RID: 10189
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x040027CE RID: 10190
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x040027CF RID: 10191
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x040027D0 RID: 10192
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x040027D1 RID: 10193
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedShortKeypressDurationms_A9125Comp;

		// Token: 0x040027D2 RID: 10194
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x040027D3 RID: 10195
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x040027D4 RID: 10196
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x040027D5 RID: 10197
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x040027D6 RID: 10198
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x040027D7 RID: 10199
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Comp;

		// Token: 0x040027D8 RID: 10200
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x040027D9 RID: 10201
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x040027DA RID: 10202
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x040027DB RID: 10203
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x040027DC RID: 10204
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x040027DD RID: 10205
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedLongKeypressDurationms_A8450Comp;

		// Token: 0x040027DE RID: 10206
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x040027DF RID: 10207
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x040027E0 RID: 10208
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x040027E1 RID: 10209
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x040027E2 RID: 10210
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x040027E3 RID: 10211
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Comp;

		// Token: 0x040027E4 RID: 10212
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x040027E5 RID: 10213
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x040027E6 RID: 10214
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x040027E7 RID: 10215
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x040027E8 RID: 10216
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x040027E9 RID: 10217
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedPowerOffKeypressDuration_42489Comp;

		// Token: 0x040027EA RID: 10218
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x040027EB RID: 10219
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x040027EC RID: 10220
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x040027ED RID: 10221
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x040027EE RID: 10222
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x040027EF RID: 10223
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Comp;

		// Token: 0x040027F0 RID: 10224
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x040027F1 RID: 10225
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x040027F2 RID: 10226
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x040027F3 RID: 10227
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x040027F4 RID: 10228
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x040027F5 RID: 10229
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Comp;

		// Token: 0x040027F6 RID: 10230
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x040027F7 RID: 10231
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x040027F8 RID: 10232
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x040027F9 RID: 10233
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x040027FA RID: 10234
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x040027FB RID: 10235
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedMFKInactivityTimeout_A38507Comp;

		// Token: 0x040027FC RID: 10236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x040027FD RID: 10237
		internal global::AcpUI.AcpLabel LblRadErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x040027FE RID: 10238
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x040027FF RID: 10239
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x04002800 RID: 10240
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x04002801 RID: 10241
		internal global::AcpUI.AcpLabel RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Comp;

		// Token: 0x04002802 RID: 10242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002803 RID: 10243
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002804 RID: 10244
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002805 RID: 10245
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002806 RID: 10246
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002807 RID: 10247
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedSoftPowerOff_A9170Comp;

		// Token: 0x04002808 RID: 10248
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x04002809 RID: 10249
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x0400280A RID: 10250
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x0400280B RID: 10251
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x0400280C RID: 10252
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x0400280D RID: 10253
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedLogicalSwitch2_A7756Comp;

		// Token: 0x0400280E RID: 10254
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x0400280F RID: 10255
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x04002810 RID: 10256
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x04002811 RID: 10257
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x04002812 RID: 10258
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x04002813 RID: 10259
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedRotarySwitchLockEnable_A8987Comp;

		// Token: 0x04002814 RID: 10260
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x04002815 RID: 10261
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x04002816 RID: 10262
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x04002817 RID: 10263
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x04002818 RID: 10264
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x04002819 RID: 10265
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedToggleSwitchLockEnable_43773Comp;

		// Token: 0x0400281A RID: 10266
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400281B RID: 10267
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400281C RID: 10268
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400281D RID: 10269
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400281E RID: 10270
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400281F RID: 10271
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedSideButtonsLockEnable_A38725Comp;

		// Token: 0x04002820 RID: 10272
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedTouchScreenLockEnable;

		// Token: 0x04002821 RID: 10273
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedTouchScreenLockEnable;

		// Token: 0x04002822 RID: 10274
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedTouchScreenLockEnable;

		// Token: 0x04002823 RID: 10275
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedTouchScreenLockEnable;

		// Token: 0x04002824 RID: 10276
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedTouchScreenLockEnable;

		// Token: 0x04002825 RID: 10277
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedTouchScreenLockEnableComp;

		// Token: 0x04002826 RID: 10278
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x04002827 RID: 10279
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x04002828 RID: 10280
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x04002829 RID: 10281
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x0400282A RID: 10282
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x0400282B RID: 10283
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedLastSelectedChannelPerZone_A41073Comp;

		// Token: 0x0400282C RID: 10284
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x0400282D RID: 10285
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x0400282E RID: 10286
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x0400282F RID: 10287
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x04002830 RID: 10288
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x04002831 RID: 10289
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787Comp;

		// Token: 0x04002832 RID: 10290
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002833 RID: 10291
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002834 RID: 10292
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002835 RID: 10293
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002836 RID: 10294
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002837 RID: 10295
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedZoneBankOperation_A37543Comp;

		// Token: 0x04002838 RID: 10296
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x04002839 RID: 10297
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x0400283A RID: 10298
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x0400283B RID: 10299
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x0400283C RID: 10300
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x0400283D RID: 10301
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedNumberofZoneBanks_A37256Comp;

		// Token: 0x0400283E RID: 10302
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x0400283F RID: 10303
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x04002840 RID: 10304
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x04002841 RID: 10305
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x04002842 RID: 10306
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x04002843 RID: 10307
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244Comp;

		// Token: 0x04002844 RID: 10308
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x04002845 RID: 10309
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x04002846 RID: 10310
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x04002847 RID: 10311
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x04002848 RID: 10312
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x04002849 RID: 10313
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245Comp;

		// Token: 0x0400284A RID: 10314
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400284B RID: 10315
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400284C RID: 10316
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400284D RID: 10317
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400284E RID: 10318
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400284F RID: 10319
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedActiveMicForRadioPTT_A38766Comp;

		// Token: 0x04002850 RID: 10320
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002851 RID: 10321
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002852 RID: 10322
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002853 RID: 10323
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002854 RID: 10324
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002855 RID: 10325
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedActiveMicForRSMPTT_43050Comp;

		// Token: 0x04002856 RID: 10326
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x04002857 RID: 10327
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x04002858 RID: 10328
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x04002859 RID: 10329
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x0400285A RID: 10330
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x0400285B RID: 10331
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedActiveMicForBTPTT_43051Comp;

		// Token: 0x0400285C RID: 10332
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x0400285D RID: 10333
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x0400285E RID: 10334
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x0400285F RID: 10335
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x04002860 RID: 10336
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x04002861 RID: 10337
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedActiveMicForIndirectPTT_44816Comp;

		// Token: 0x04002862 RID: 10338
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002863 RID: 10339
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002864 RID: 10340
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002865 RID: 10341
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002866 RID: 10342
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002867 RID: 10343
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedBTReceiveAudio_43052Comp;

		// Token: 0x04002868 RID: 10344
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x04002869 RID: 10345
		internal global::AcpUI.AcpLabel LblRadioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x0400286A RID: 10346
		internal global::AcpUI.AcpCheckBox RadioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x0400286B RID: 10347
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x0400286C RID: 10348
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x0400286D RID: 10349
		internal global::AcpUI.AcpCheckBox RadioErgoCfgExternalAccessoryEnable_A36198Comp;

		// Token: 0x0400286E RID: 10350
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoCfgFatalError_A36202;

		// Token: 0x0400286F RID: 10351
		internal global::AcpUI.AcpLabel LblRadioErgoCfgFatalError_A36202;

		// Token: 0x04002870 RID: 10352
		internal global::AcpUI.AcpCheckBox RadioErgoCfgFatalError_A36202;

		// Token: 0x04002871 RID: 10353
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoCfgFatalError_A36202;

		// Token: 0x04002872 RID: 10354
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoCfgFatalError_A36202;

		// Token: 0x04002873 RID: 10355
		internal global::AcpUI.AcpCheckBox RadioErgoCfgFatalError_A36202Comp;

		// Token: 0x04002874 RID: 10356
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002875 RID: 10357
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002876 RID: 10358
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002877 RID: 10359
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002878 RID: 10360
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002879 RID: 10361
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedConsoletteEnable_A37231Comp;

		// Token: 0x0400287A RID: 10362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x0400287B RID: 10363
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x0400287C RID: 10364
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x0400287D RID: 10365
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x0400287E RID: 10366
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x0400287F RID: 10367
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedConsoletteFatalError_A37233Comp;

		// Token: 0x04002880 RID: 10368
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x04002881 RID: 10369
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x04002882 RID: 10370
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x04002883 RID: 10371
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x04002884 RID: 10372
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x04002885 RID: 10373
		internal global::AcpUI.AcpCheckBox RadErgoWideAdvancedFixedVolumeEnable_A37218Comp;

		// Token: 0x04002886 RID: 10374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x04002887 RID: 10375
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x04002888 RID: 10376
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x04002889 RID: 10377
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x0400288A RID: 10378
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x0400288B RID: 10379
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedFixedVolumeLevel_A37219Comp;

		// Token: 0x0400288C RID: 10380
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x0400288D RID: 10381
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x0400288E RID: 10382
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x0400288F RID: 10383
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x04002890 RID: 10384
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x04002891 RID: 10385
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedDefaultCHHubState_A37222Comp;

		// Token: 0x04002892 RID: 10386
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002893 RID: 10387
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002894 RID: 10388
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002895 RID: 10389
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002896 RID: 10390
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002897 RID: 10391
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569Comp;

		// Token: 0x04002898 RID: 10392
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x04002899 RID: 10393
		internal global::AcpUI.AcpLabel LblRadWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x0400289A RID: 10394
		internal global::AcpUI.AcpComboBox RadWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x0400289B RID: 10395
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x0400289C RID: 10396
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x0400289D RID: 10397
		internal global::AcpUI.AcpLabel RadWideNVGBacklightBrightnessLevel_A41616Comp;

		// Token: 0x0400289E RID: 10398
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideMOSCADDataEnable_A8545;

		// Token: 0x0400289F RID: 10399
		internal global::AcpUI.AcpLabel LblRadErgoWideMOSCADDataEnable_A8545;

		// Token: 0x040028A0 RID: 10400
		internal global::AcpUI.AcpCheckBox RadErgoWideMOSCADDataEnable_A8545;

		// Token: 0x040028A1 RID: 10401
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideMOSCADDataEnable_A8545;

		// Token: 0x040028A2 RID: 10402
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideMOSCADDataEnable_A8545;

		// Token: 0x040028A3 RID: 10403
		internal global::AcpUI.AcpCheckBox RadErgoWideMOSCADDataEnable_A8545Comp;

		// Token: 0x040028A4 RID: 10404
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideAuxControl;

		// Token: 0x040028A5 RID: 10405
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioErgonomicsWideAuxControlTable;

		// Token: 0x040028A6 RID: 10406
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWideAuxControlGrid;

		// Token: 0x040028A7 RID: 10407
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWideAuxControlTableGrid;

		// Token: 0x040028A8 RID: 10408
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWideAuxControlTableTableView;

		// Token: 0x040028A9 RID: 10409
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioErgonomicsWideAuxControlTable;

		// Token: 0x040028AA RID: 10410
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideAuxControlAuxCtrlName_A37714_Col;

		// Token: 0x040028AB RID: 10411
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideAuxControlActiveDuration_A37249_Col;

		// Token: 0x040028AC RID: 10412
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Col;

		// Token: 0x040028AD RID: 10413
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideAuxControlAuxOnAlias_A37250_Col;

		// Token: 0x040028AE RID: 10414
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoWideAuxControlAuxOffAlias_A37252_Col;

		// Token: 0x040028AF RID: 10415
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWideAuxControlTableSRecView;

		// Token: 0x040028B0 RID: 10416
		internal global::System.Windows.Controls.Grid gridExpanderRadioErgonomicsWideAuxControlTableSRecView;

		// Token: 0x040028B1 RID: 10417
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlAuxCtrlName_A37714;

		// Token: 0x040028B2 RID: 10418
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAuxControlAuxCtrlName_A37714;

		// Token: 0x040028B3 RID: 10419
		internal global::AcpUI.AcpLabel LblRadErgoWideAuxControlAuxCtrlName_A37714;

		// Token: 0x040028B4 RID: 10420
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAuxControlAuxCtrlName_A37714;

		// Token: 0x040028B5 RID: 10421
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlAuxCtrlName_A37714Comp;

		// Token: 0x040028B6 RID: 10422
		internal global::AcpUI.AcpTextBoxSpinner RadErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x040028B7 RID: 10423
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x040028B8 RID: 10424
		internal global::AcpUI.AcpLabel LblRadErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x040028B9 RID: 10425
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x040028BA RID: 10426
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x040028BB RID: 10427
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlActiveDuration_A37249Comp;

		// Token: 0x040028BC RID: 10428
		internal global::AcpUI.AcpTextBox RadErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x040028BD RID: 10429
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x040028BE RID: 10430
		internal global::AcpUI.AcpLabel LblRadErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x040028BF RID: 10431
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x040028C0 RID: 10432
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x040028C1 RID: 10433
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlAbbrAuxOnAlias_A37612Comp;

		// Token: 0x040028C2 RID: 10434
		internal global::AcpUI.AcpTextBox RadErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x040028C3 RID: 10435
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x040028C4 RID: 10436
		internal global::AcpUI.AcpLabel LblRadErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x040028C5 RID: 10437
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x040028C6 RID: 10438
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x040028C7 RID: 10439
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlAuxOnAlias_A37250Comp;

		// Token: 0x040028C8 RID: 10440
		internal global::AcpUI.AcpTextBox RadErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x040028C9 RID: 10441
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x040028CA RID: 10442
		internal global::AcpUI.AcpLabel LblRadErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x040028CB RID: 10443
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x040028CC RID: 10444
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x040028CD RID: 10445
		internal global::AcpUI.AcpLabel RadErgoWideAuxControlAuxOffAlias_A37252Comp;

		// Token: 0x040028CE RID: 10446
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWidePresetZoneAndChannel;

		// Token: 0x040028CF RID: 10447
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioErgonomicsWidePresetZoneAndChannelTable;

		// Token: 0x040028D0 RID: 10448
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPresetZoneAndChannelPseudo0;

		// Token: 0x040028D1 RID: 10449
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917;

		// Token: 0x040028D2 RID: 10450
		internal global::AcpUI.AcpLabel LblRadWideGeneralConfigurablePresetZoneAndChannel_A44917;

		// Token: 0x040028D3 RID: 10451
		internal global::AcpUI.AcpCheckBox RadWideGeneralConfigurablePresetZoneAndChannel_A44917;

		// Token: 0x040028D4 RID: 10452
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917;

		// Token: 0x040028D5 RID: 10453
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralConfigurablePresetZoneAndChannel_A44917;

		// Token: 0x040028D6 RID: 10454
		internal global::AcpUI.AcpCheckBox RadWideGeneralConfigurablePresetZoneAndChannel_A44917Comp;

		// Token: 0x040028D7 RID: 10455
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWidePresetZoneAndChannelGrid;

		// Token: 0x040028D8 RID: 10456
		internal global::System.Windows.Controls.Grid ExpanderRadioErgonomicsWidePresetZoneAndChannelTableGrid;

		// Token: 0x040028D9 RID: 10457
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWidePresetZoneAndChannelTableTableView;

		// Token: 0x040028DA RID: 10458
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioErgonomicsWidePresetZoneAndChannelTable;

		// Token: 0x040028DB RID: 10459
		internal global::Infragistics.Windows.DataPresenter.UnboundField PresetModeSelect_Col;

		// Token: 0x040028DC RID: 10460
		internal global::Infragistics.Windows.DataPresenter.UnboundField LabtoolPresetZone_A41079_Col;

		// Token: 0x040028DD RID: 10461
		internal global::Infragistics.Windows.DataPresenter.UnboundField LabtoolPresetChannel_A41080_Col;

		// Token: 0x040028DE RID: 10462
		internal global::AcpUI.AcpGroupBox ExpanderRadioErgonomicsWidePresetZoneAndChannelTableSRecView;

		// Token: 0x040028DF RID: 10463
		internal global::System.Windows.Controls.Grid gridExpanderRadioErgonomicsWidePresetZoneAndChannelTableSRecView;

		// Token: 0x040028E0 RID: 10464
		internal global::AcpUI.AcpLabel PresetModeSelect;

		// Token: 0x040028E1 RID: 10465
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPresetModeSelect;

		// Token: 0x040028E2 RID: 10466
		internal global::AcpUI.AcpLabel LblPresetModeSelect;

		// Token: 0x040028E3 RID: 10467
		internal global::AcpUI.AcpRtdButton RTDBtnPresetModeSelect;

		// Token: 0x040028E4 RID: 10468
		internal global::AcpUI.AcpCopyButton CpyBtnPresetModeSelect;

		// Token: 0x040028E5 RID: 10469
		internal global::AcpUI.AcpLabel PresetModeSelectComp;

		// Token: 0x040028E6 RID: 10470
		internal global::AcpUI.AcpComboBox LabtoolPresetZone_A41079;

		// Token: 0x040028E7 RID: 10471
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLabtoolPresetZone_A41079;

		// Token: 0x040028E8 RID: 10472
		internal global::AcpUI.AcpLabel LblLabtoolPresetZone_A41079;

		// Token: 0x040028E9 RID: 10473
		internal global::AcpUI.AcpRtdButton RTDBtnLabtoolPresetZone_A41079;

		// Token: 0x040028EA RID: 10474
		internal global::AcpUI.AcpCopyButton CpyBtnLabtoolPresetZone_A41079;

		// Token: 0x040028EB RID: 10475
		internal global::AcpUI.AcpLabel LabtoolPresetZone_A41079Comp;

		// Token: 0x040028EC RID: 10476
		internal global::AcpUI.AcpTextBoxSpinner LabtoolPresetChannel_A41080;

		// Token: 0x040028ED RID: 10477
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLabtoolPresetChannel_A41080;

		// Token: 0x040028EE RID: 10478
		internal global::AcpUI.AcpLabel LblLabtoolPresetChannel_A41080;

		// Token: 0x040028EF RID: 10479
		internal global::AcpUI.AcpRtdButton RTDBtnLabtoolPresetChannel_A41080;

		// Token: 0x040028F0 RID: 10480
		internal global::AcpUI.AcpCopyButton CpyBtnLabtoolPresetChannel_A41080;

		// Token: 0x040028F1 RID: 10481
		internal global::AcpUI.AcpLabel LabtoolPresetChannel_A41080Comp;

		// Token: 0x040028F2 RID: 10482
		internal global::AcpUI.AcpExpander ExpanderRadioErgonomicsWideLogicalProfileConfiguration;

		// Token: 0x040028F3 RID: 10483
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioErgonomicsWideLogicalProfileConfigurationPseudo0;

		// Token: 0x040028F4 RID: 10484
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040028F5 RID: 10485
		internal global::AcpUI.AcpLabel LblRadErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040028F6 RID: 10486
		internal global::AcpUI.AcpComboBox RadErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040028F7 RID: 10487
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040028F8 RID: 10488
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040028F9 RID: 10489
		internal global::AcpUI.AcpLabel RadErgoWideLogicalProfileConfigurationCovertProfile_A43135Comp;

		// Token: 0x040028FA RID: 10490
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040028FB RID: 10491
		internal global::AcpUI.AcpLabel LblRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040028FC RID: 10492
		internal global::AcpUI.AcpComboBox RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040028FD RID: 10493
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040028FE RID: 10494
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040028FF RID: 10495
		internal global::AcpUI.AcpLabel RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136Comp;

		// Token: 0x04002900 RID: 10496
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;

		// Token: 0x04002901 RID: 10497
		internal global::AcpUI.AcpLabel LblRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;

		// Token: 0x04002902 RID: 10498
		internal global::AcpUI.AcpComboBox RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;

		// Token: 0x04002903 RID: 10499
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;

		// Token: 0x04002904 RID: 10500
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;

		// Token: 0x04002905 RID: 10501
		internal global::AcpUI.AcpLabel RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137Comp;

		// Token: 0x04002906 RID: 10502
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x04002907 RID: 10503
		internal global::AcpUI.AcpLabel LblRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x04002908 RID: 10504
		internal global::AcpUI.AcpComboBox RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x04002909 RID: 10505
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x0400290A RID: 10506
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x0400290B RID: 10507
		internal global::AcpUI.AcpLabel RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138Comp;

		// Token: 0x0400290C RID: 10508
		private bool b;
	}
}
