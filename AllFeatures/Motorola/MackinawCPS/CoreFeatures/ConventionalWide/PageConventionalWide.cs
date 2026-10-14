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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000546 RID: 1350
	public class PageConventionalWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B51E RID: 46366 RVA: 0x00A7C318 File Offset: 0x00A7A518
		public PageConventionalWide()
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

		// Token: 0x0600B51F RID: 46367 RVA: 0x00A7C350 File Offset: 0x00A7A550
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)691142656;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1737687042;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						global::AcpUI.AcpExpander acpExpander;
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							if (obj != null)
							{
								num = (short)722010119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_349;
						case 1:
							goto IL_29B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_6D;
							}
							continue;
						case 3:
							goto IL_349;
						case 4:
							try
							{
								num = (short)546439170;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										base.Expanders.Add(acpExpander);
										num = (short)1190199302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (acpExpander != null)
										{
											num = (short)64356352;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_D6;
										}
										continue;
									case 3:
										num = (short)1812463621;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = (short)2131296259;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)2033254401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_191;
									}
									IL_118:
									num = (short)203554820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D6:
									goto IL_118;
								}
								IL_191:
								goto IL_274;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1B3;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1A0:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)2030764033;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_208;
									case 1:
										disposable.Dispose();
										num = (short)862912514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_206;
									}
									goto IL_1B3;
								}
								IL_206:
								IL_208:
								goto EndFinally_8;
								IL_1B3:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)24379392;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1A0;
								EndFinally_8:;
							}
							goto IL_209;
							IL_274:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)1811218433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)1354891264;
							short num3 = num;
							obj = null;
							obj = this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.MyRecordsetDataSource;
							num = (short)2062417920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderConventionalWideOTAC.MyDataPresenter = this.ExpanderConventionalWideOTAC;
							num = (short)462618632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.MyDataPresenter = this.ExpanderConventionalWideASTROGroupIDList;
							num = (short)654966787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_209;
						case 9:
							if (obj != null)
							{
								num = (short)492830726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_209;
						}
						IL_6D:
						if (!this.a)
						{
							num = (short)475004933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_209:
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1549205508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_349:
						obj = this.RecNavToolbarExpanderConventionalWideOTAC.MyRecordsetDataSource;
						num = (short)1388314633;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_393:
					num = (short)776216018;
					short num4 = num;
					num = (short)912727506;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_3C8;
					}
					IL_29B:
					goto IL_393;
				}
				}
			}
			IL_3C8:
			num = (short)2071855105;
			if (num != 0)
			{
			}
			num = (short)845086720;
			if (num != 0)
			{
			}
			this.PostOnLoaded(sender, e);
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x00A7C7A0 File Offset: 0x00A7A9A0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)501743617;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)844516852;
					short num3 = num;
					num = (short)1748323828;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						goto IL_131;
					}
					break;
				}
				case 1:
					goto IL_D2;
				case 2:
					if (this.a)
					{
						num = (short)1539833856;
						short num4 = num;
						num = (short)1891500033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_43;
				IL_D2:
				base.OnUnloaded(sender, e);
				this.a = false;
				num = (short)1855586304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_131:
			num = (short)1491795968;
			if (num != 0)
			{
			}
			return;
			IL_43:
			this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.DataContext = null;
			this.RecNavToolbarExpanderConventionalWideOTAC.DataContext = null;
			this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalWideOTAC.MyDataPresenter = null;
			num = (short)1570177026;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00A7C8F8 File Offset: 0x00A7AAF8
		public override void SetDataContext()
		{
			short num = (short)730202121;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1349058565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)881590282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EF;
				case 2:
					num = (short)1830027275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)809697280;
					short num3 = num;
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10055] != null)
					{
						num = (short)160038920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideASTROGroupIDList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10053].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideASTROGroupIDList).SyncDataSources();
					num = (short)533725207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10053].EmbeddedRecset != null)
					{
						num = (short)129761284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EF;
				case 6:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2024);
					num = (short)1785331733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2024);
					num = (short)1431437324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1311047700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 10:
					num = (short)1496055822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)939327501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (feature != null)
					{
						num = (short)2114322447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EF;
				case 13:
					num = (short)2115764227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10053] != null)
					{
						num = (short)998768640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EF;
				case 15:
				{
					num = (short)586344110;
					short num4 = num;
					num = (short)2061100718;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_407;
					default:
						num = (short)2006515713;
						if (num != 0)
						{
						}
						num = (short)298319872;
						if (num != 0)
						{
						}
						num = (short)1394671617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)630128647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideASTROGroupIDList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideOTAC).MySecondaryRecordsetDataSource = null;
					num = (short)1442775062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_407;
				case 18:
					goto IL_13F;
				case 19:
					goto IL_1CD;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10055].EmbeddedRecset != null)
					{
						num = (short)2080505875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					goto IL_13F;
				case 22:
					return;
				case 23:
					goto IL_3EF;
				}
				IL_84:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)426180614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2024);
				num = (short)923074578;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13F:
				num = (short)84082704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EF:
				num = (short)1979449361;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_407:
				if (feature == null)
				{
					return;
				}
				num = (short)2146369538;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1CD:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideOTAC).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10055].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalWideOTAC).SyncDataSources();
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00A7CDEC File Offset: 0x00A7AFEC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)623378432;
			switch (num)
			{
			default:
			{
				num = (short)1284833282;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸跺飼釾甀樂樄椆栈朊娌明甐瘒娔䌖堘堚", a_))
						{
							num = (short)1698562061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInner item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1525612556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 3:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarExpanderConventionalWideOTAC.MyRecordsetDataSource;
						num = (short)1372127248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.MyRecordsetDataSource;
						num = (short)1022820366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1219493889;
						if (num != 0)
						{
						}
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸跺飼釾甀樂樄椆栈朊娌明甐瘒吔䐖䴘䤚刜堞匠䰢値圦怨漪愬䘮䈰䜲", a_))
						{
							num = (short)454688783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 6:
						num = (short)1029701637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)617545732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)428277768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1211738667;
						short num3 = num;
						num = (short)140487211;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2CF;
						default:
							num = (short)135397376;
							if (num != 0)
							{
							}
							goto IL_135;
						}
						break;
					}
					case 9:
						goto IL_107;
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1814036483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						goto IL_2CF;
					case 11:
						return;
					case 12:
						goto IL_135;
					case 13:
						num = (short)1512898570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)520224769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					}
					case 15:
						num = (short)2073821191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)967245833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_91:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)2061107206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_135:
					num = (short)279248896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF:
					num = (short)1047789579;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_107:
				num = (short)1481310208;
				short num4 = num;
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x00A7D1F8 File Offset: 0x00A7B3F8
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2006356003;
			short num2 = num;
			num = (short)700551203;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1670643712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)176619521;
			if (num != 0)
			{
			}
			num = (short)931463168;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x00A7D2A8 File Offset: 0x00A7B4A8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)946130770;
			short num2 = num;
			num = (short)1270468434;
			switch (num2 == num)
			{
			default:
			{
				num = (short)325386240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)494665729;
			if (num != 0)
			{
			}
			num = (short)1249247232;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x00A7D358 File Offset: 0x00A7B558
		internal void OnExpanderConventionalWideASTROGroupIDListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			int num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1516437505;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)557983612;
					short num3 = num;
					num = (short)661333884;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						goto IL_142;
					}
					break;
				}
				case 1:
					goto IL_D5;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1097007104;
						short num4 = num;
						num = (short)1164574721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				}
				goto IL_45;
				IL_D5:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.SyncDataSources();
				num = (short)9764864;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_142:
			num = (short)2095251456;
			if (num != 0)
			{
			}
			IL_15A:
			this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.TableMode = false;
			return;
			IL_45:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.MyRecordsetDataSource;
			num = (short)896794626;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x00A7D4CC File Offset: 0x00A7B6CC
		internal void OnExpanderConventionalWideOTACClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)542848694;
					short num3 = num2;
					num2 = (short)968767158;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CE;
					default:
						goto IL_139;
					}
					break;
				}
				case 1:
					goto IL_CE;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)500301824;
						short num4 = num2;
						num2 = (short)1670512641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				}
				goto IL_1C;
				IL_CE:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderConventionalWideOTAC.SyncDataSources();
				num2 = (short)999096320;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_139:
			num2 = (short)1194524672;
			if (num2 != 0)
			{
			}
			IL_150:
			this.RecNavToolbarExpanderConventionalWideOTAC.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1295843329;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalWideOTAC.MyRecordsetDataSource;
			num2 = (short)2062745602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x00A7D638 File Offset: 0x00A7B838
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1387667539;
			short num2 = num;
			num = (short)21241939;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1452539904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1589313536;
			if (num != 0)
			{
			}
			num = (short)2127626241;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x00A7D6E8 File Offset: 0x00A7B8E8
		private void a()
		{
			short num = (short)2041560130;
			short num2 = num;
			num = (short)1208400962;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1352335360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)790102016;
			if (num != 0)
			{
			}
			num = (short)826802177;
			if (num != 0)
			{
			}
			this.CnvWideASTROGroupIDGroupID1_A7480_Col.Settings.CellWidth = 180.0;
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x00A7D7AC File Offset: 0x00A7B9AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1574895616;
			short num2 = num;
			if (!this.b)
			{
				num = (short)1461152280;
				short num3 = num;
				num = (short)271608344;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)925827073;
					if (num != 0)
					{
					}
					num = (short)200015872;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﳒ铔믖뗘鷚룜뻞闠離韤苦髨탪軬胮鳰菲髴駶鳸闺觼탾戀氂欄焆氈攊礌明縐紒琔笖㰘⤚ⴜ簞丠䴢䌤並丨帪弬丮䔰娲娴夶ᘸ堺刼儾㝀♂⭄㍆⁈⑊⍌⹎㵐癒杔杖⹘㉚㥜㩞习b੤०Ὠ๪ͬ᭮ᡰᱲ᭴ᙶᕸ౺ᑼ᭾궂ﶄ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x0600B52A RID: 46378 RVA: 0x00A7D890 File Offset: 0x00A7BA90
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)340983810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AD1;
				case 1:
					num = (short)1421541376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_4DC;
				case 2:
				case 3:
				case 4:
				case 5:
					goto IL_1782;
				case 6:
					goto IL_AD6;
				case 7:
					goto IL_11CC;
				case 8:
					goto IL_72D;
				case 9:
					goto IL_1469;
				case 10:
					goto IL_A16;
				case 11:
					goto IL_6A4;
				case 12:
					goto IL_14F5;
				case 13:
					goto IL_1628;
				case 14:
					goto IL_FB8;
				case 15:
					goto IL_D2F;
				case 16:
					goto IL_1340;
				case 17:
					goto IL_DF9;
				case 18:
					goto IL_14C1;
				case 19:
					goto IL_16BB;
				case 20:
					goto IL_11FD;
				case 21:
					goto IL_7B3;
				case 22:
					goto IL_D94;
				case 23:
					goto IL_1775;
				case 24:
					goto IL_E06;
				case 25:
					goto IL_100D;
				case 26:
					goto IL_10F8;
				case 27:
					goto IL_9FC;
				case 28:
					goto IL_103E;
				case 29:
					goto IL_14A7;
				case 30:
					goto IL_F91;
				case 31:
					goto IL_126C;
				case 32:
					goto IL_E13;
				case 33:
					goto IL_A3A;
				case 34:
					goto IL_A09;
				case 35:
					goto IL_45D;
				case 36:
					goto IL_FDC;
				case 37:
					goto IL_8D9;
				case 38:
					goto IL_76B;
				case 39:
					goto IL_B69;
				case 40:
					goto IL_12DB;
				case 41:
					goto IL_531;
				case 42:
					goto IL_720;
				case 43:
					goto IL_7C0;
				case 44:
					goto IL_156E;
				case 45:
					goto IL_10BA;
				case 46:
					goto IL_877;
				case 47:
					goto IL_11B2;
				case 48:
					goto IL_12E8;
				case 49:
					goto IL_50D;
				case 50:
					goto IL_FE9;
				case 51:
					goto IL_1768;
				case 52:
					goto IL_15EA;
				case 53:
					goto IL_16DF;
				case 54:
					goto IL_443;
				case 55:
					goto IL_5C7;
				case 56:
					goto IL_7F1;
				case 57:
					goto IL_1198;
				case 58:
					goto IL_53E;
				case 59:
					goto IL_9EF;
				case 60:
					goto IL_F84;
				case 61:
					goto IL_491;
				case 62:
					goto IL_75E;
				case 63:
					goto IL_673;
				case 64:
					goto IL_605;
				case 65:
					goto IL_EB7;
				case 66:
					goto IL_1302;
				case 67:
					goto IL_167D;
				case 68:
					goto IL_EF8;
				case 69:
					goto IL_D3C;
				case 70:
					goto IL_C3A;
				case 71:
					goto IL_149A;
				case 72:
					goto IL_5F8;
				case 73:
					goto IL_1065;
				case 74:
					goto IL_148D;
				case 75:
					goto IL_BCB;
				case 76:
					goto IL_1445;
				case 77:
					goto IL_5A3;
				case 78:
					goto IL_1031;
				case 79:
					goto IL_1414;
				case 80:
					goto IL_F2C;
				case 81:
					goto IL_6D5;
				case 82:
					goto IL_16EC;
				case 83:
					goto IL_B21;
				case 84:
					goto IL_8A8;
				case 85:
					goto IL_A92;
				case 86:
					goto IL_A47;
				case 87:
					goto IL_12AA;
				case 88:
					goto IL_6EF;
				case 89:
					goto IL_DAE;
				case 90:
					goto IL_C5E;
				case 91:
					goto IL_153D;
				case 92:
					goto IL_EEB;
				case 93:
					goto IL_93B;
				case 94:
					goto IL_1670;
				case 95:
					goto IL_159F;
				case 96:
					goto IL_DBB;
				case 97:
					goto IL_565;
				case 98:
					goto IL_589;
				case 99:
					goto IL_14E8;
				case 100:
					goto IL_F39;
				case 101:
					goto IL_92E;
				case 102:
					goto IL_AFD;
				case 103:
					goto IL_948;
				case 104:
					goto IL_993;
				case 105:
					goto IL_1592;
				case 106:
					goto IL_134D;
				case 107:
					goto IL_D87;
				case 108:
					goto IL_1374;
				case 109:
					goto IL_4B8;
				case 110:
					goto IL_AF0;
				case 111:
					goto IL_1367;
				case 112:
					goto IL_986;
				case 113:
					goto IL_115A;
				case 114:
					goto IL_6C8;
				case 115:
					goto IL_B45;
				case 116:
					goto IL_1096;
				case 117:
					goto IL_DEC;
				case 118:
					goto IL_15B9;
				case 119:
					goto IL_EC4;
				case 120:
					goto IL_F9E;
				case 121:
					goto IL_122E;
				case 122:
					goto IL_164C;
				case 123:
					goto IL_697;
				case 124:
					goto IL_A9F;
				case 125:
					goto IL_118B;
				case 126:
					goto IL_16AE;
				case 127:
					goto IL_E5E;
				case 128:
					goto IL_BF2;
				case 129:
					goto IL_D7A;
				case 130:
					goto IL_96C;
				case 131:
					goto IL_174E;
				case 132:
					goto IL_F77;
				case 133:
					goto IL_8B5;
				case 134:
					goto IL_130F;
				case 135:
					goto IL_AE3;
				case 136:
					goto IL_9E2;
				case 137:
					goto IL_114D;
				case 138:
					goto IL_921;
				case 139:
					goto IL_41F;
				case 140:
					goto IL_1710;
				case 141:
					goto IL_1140;
				case 142:
					goto IL_9C8;
				case 143:
					goto IL_129D;
				case 144:
					goto IL_484;
				case 145:
					goto IL_1072;
				case 146:
					goto IL_884;
				case 147:
					goto IL_7E4;
				case 148:
					goto IL_CCD;
				case 149:
					goto IL_14B4;
				case 150:
					goto IL_CA6;
				case 151:
					goto IL_B83;
				case 152:
					goto IL_BA7;
				case 153:
					goto IL_15F7;
				case 154:
					goto IL_A85;
				case 155:
					goto IL_13FA;
				case 156:
					goto IL_596;
				case 157:
					goto IL_12B7;
				case 158:
					goto IL_1604;
				case 159:
					goto IL_F05;
				case 160:
					goto IL_CDA;
				case 161:
					goto IL_A78;
				case 162:
					goto IL_E37;
				case 163:
					goto IL_A54;
				case 164:
					goto IL_D60;
				case 165:
					goto IL_CC0;
				case 166:
					goto IL_46A;
				case 167:
					goto IL_E51;
				case 168:
					goto IL_BE5;
				case 169:
					goto IL_412;
				case 170:
					goto IL_13ED;
				case 171:
					goto IL_C82;
				case 172:
					goto IL_DA1;
				case 173:
					goto IL_CE7;
				case 174:
					goto IL_1561;
				case 175:
					goto IL_12F5;
				case 176:
					goto IL_AAC;
				case 177:
					goto IL_15AC;
				case 178:
					goto IL_C16;
				case 179:
					goto IL_6E2;
				case 180:
					goto IL_822;
				case 181:
					goto IL_1167;
				case 182:
					goto IL_8FD;
				case 183:
					goto IL_1221;
				case 184:
					goto IL_104B;
				case 185:
					goto IL_F6A;
				case 186:
					goto IL_135A;
				case 187:
					goto IL_78F;
				case 188:
					goto IL_1421;
				case 189:
					goto IL_9D5;
				case 190:
					goto IL_1407;
				case 191:
					goto IL_11BF;
				case 192:
					goto IL_558;
				case 193:
					goto IL_B76;
				case 194:
					goto IL_1398;
				case 195:
					goto IL_BD8;
				case 196:
					goto IL_450;
				case 197:
					goto IL_11A5;
				case 198:
					goto IL_5EB;
				case 199:
					goto IL_815;
				case 200:
					goto IL_14DB;
				case 201:
					goto IL_82F;
				case 202:
					goto IL_E44;
				case 203:
					goto IL_111C;
				case 204:
					goto IL_1058;
				case 205:
					goto IL_CB3;
				case 206:
					goto IL_6FC;
				case 207:
					goto IL_1252;
				case 208:
					goto IL_853;
				case 209:
					goto IL_49E;
				case 210:
					goto IL_ED1;
				case 211:
					goto IL_14CE;
				case 212:
					goto IL_D0B;
				case 213:
					goto IL_175B;
				case 214:
					goto IL_168A;
				case 215:
					goto IL_54B;
				case 216:
					goto IL_979;
				case 217:
					goto IL_751;
				case 218:
					goto IL_477;
				case 219:
					goto IL_1734;
				case 220:
					goto IL_FAB;
				case 221:
					goto IL_EAA;
				case 222:
					goto IL_10C7;
				case 223:
					goto IL_F46;
				case 224:
					goto IL_D6D;
				case 225:
					goto IL_1290;
				case 226:
					goto IL_F12;
				case 227:
					goto IL_F1F;
				case 228:
					goto IL_15C6;
				case 229:
					goto IL_13A5;
				case 230:
					goto IL_1741;
				case 231:
					goto IL_10EB;
				case 232:
					goto IL_EDE;
				case 233:
					goto IL_4AB;
				case 234:
					goto IL_13C9;
				case 235:
					goto IL_1519;
				case 236:
					goto IL_1333;
				case 237:
					goto IL_11F0;
				case 238:
					goto IL_DDF;
				case 239:
					goto IL_125F;
				default:
					num = (short)620494849;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_412:
			this.ExpanderConventionalWideASTROGroupIDListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_41F:
			this.LblCnvWideASTRODataTxLimitedPatienceSec_A9544 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataTxLimitedPatienceSec_A9544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_443:
			this.CVBtnCnvWideGeneralMplRecallMode_A41698 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_450:
			this.CnvWideASTROOTACPosition_A19768_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_45D:
			this.CnvWideGeneralHUBDefeatsPL_A8215Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_46A:
			this.ExpanderConventionalWideASTROGroupIDListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_477:
			this.ExpanderConventionalWideSmartPTT = (global::AcpUI.AcpExpander)target;
			return;
			IL_484:
			this.CVBtnCnvWideASTRODataARPCacheDepth_A7463 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_491:
			this.GrpBoxExpanderConventionalWideFeaturesSmartPTT = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_49E:
			this.RTDBtnCnvWideASTROOTACZone_A8645 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4AB:
			this.CVBtnCnvWideLabtoolExpandedMDCID_A41790 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B8:
			this.CnvWideASTRODataMaxPacketSizebytes_A8471 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataMaxPacketSizebytes_A8471.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4DC:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.PageConventionalWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.PageConventionalWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_50D:
			this.LblCnvWideGeneralLatchEnableTime_A8421 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralLatchEnableTime_A8421.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_531:
			this.CnvWideGeneralSquelchPerPersonality_A19313Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_53E:
			this.CpyBtnCnvWideGeneralMplRecallMode_A41698 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_54B:
			this.RTDBtnCnvWideASTROOTACChannel_A8629 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_558:
			this.ExpanderConventionalWideASTROOTACGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_565:
			this.CnvWideASTRODataResponseTimerms_A8948 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataResponseTimerms_A8948.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_589:
			this.RTDBtnCnvWideASTRODataResponseTimerms_A8948 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_596:
			this.CVBtnCnvWideConventionalCustomerID_41558 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A3:
			this.CnvWideFeaturesSoftIDFeature_A9168 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideFeaturesSoftIDFeature_A9168.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5C7:
			this.LblCnvWideGeneralMplRecallMode_A41698 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralMplRecallMode_A41698.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5EB:
			this.CnvWideASTROOTACChannel_A8629_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5F8:
			this.CpyBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_605:
			num = (short)947080862;
			short num3 = num;
			num = (short)261967518;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14E8:
				this.CpyBtnCnvWideASTRODataResponseTimerms_A8948 = (global::AcpUI.AcpCopyButton)target;
				return;
			default:
				num = (short)1977679872;
				if (num != 0)
				{
				}
				this.CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = (global::AcpUI.AcpTextBoxSpinner)target;
				this.CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_673:
			this.LblCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_697:
			this.RTDBtnCnvWideASTRODataTxShortRandomRangeMs_A9565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6A4:
			this.HLinkASTROOTAC = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROOTAC.Click += this.HLinkClick;
			return;
			IL_6C8:
			this.CVBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6D5:
			this.CVBtnConventionlWideFeaturesStatusNumOfAttempts_42156 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6E2:
			this.GrpBoxExpanderConventionalWideASTROOTACPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6EF:
			this.GrpBoxExpanderConventionalWideASTRODataCAIData = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6FC:
			this.CnvWideASTROOTACZone_A8645 = (global::AcpUI.AcpComboBox)target;
			this.CnvWideASTROOTACZone_A8645.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_720:
			this.CVBtnCnvWideGeneralLatchEnableTone_A8422 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_72D:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_751:
			this.CnvWideASTROOTACChannel_A8629Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_75E:
			this.CVBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_76B:
			this.CnvWideGeneralSquelchPerPersonality_A19313 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideGeneralSquelchPerPersonality_A19313.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_78F:
			this.LblCnvWideASTROOTACOTACRFeature_A8662 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROOTACOTACRFeature_A8662.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7B3:
			this.RTDBtnCnvWideGeneralMonitorType_A8544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7C0:
			this.LblCnvWideGeneralLatchEnableTone_A8422 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralLatchEnableTone_A8422.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E4:
			this.RTDBtnCnvWideASTRODataARPCacheDepth_A7463 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7F1:
			this.CnvWideGeneralMplRecallMode_A41698 = (global::AcpUI.AcpComboBox)target;
			this.CnvWideGeneralMplRecallMode_A41698.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_815:
			this.ExpanderConventionalWideOTACSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_822:
			this.CVBtnCnvWideASTROOTACOTACSFeature_A8667 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_82F:
			this.CnvWideASTROOTACPosition_A19768 = (global::AcpUI.AcpLabel)target;
			this.CnvWideASTROOTACPosition_A19768.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_853:
			this.LblCnvWideASTROOTACZone_A8645 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROOTACZone_A8645.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_877:
			this.CpyBtnCnvWideGeneralLatchEnableTone_A8422 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_884:
			this.CnvWideASTRODataARPCacheDepth_A7463 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataARPCacheDepth_A7463.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A8:
			this.RTDBtnConventionlWideFeaturesStatusNumOfAttempts_42156 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B5:
			this.LblCnvWideASTRODataTxRespRandomRangeMs_A9563 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataTxRespRandomRangeMs_A9563.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D9:
			this.LblCnvWideGeneralSquelchPerPersonality_A19313 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralSquelchPerPersonality_A19313.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8FD:
			this.CnvWideASTROOTACOTACSFeature_A8667 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideASTROOTACOTACSFeature_A8667.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_921:
			this.CVBtnCnvWideASTRODataTxLimitedPatienceSec_A9544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_92E:
			this.CVBtnCnvWideASTRODataMinResponseTimerms_A8514 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93B:
			this.CpyBtnCnvWideASTRODataMaxTxAttempts_A8474 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_948:
			this.CnvWideASTRODataMinResponseTimerms_A8514 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataMinResponseTimerms_A8514.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_96C:
			this.CpyBtnCnvWideASTRODataTxLongRandomRangeMs_A9546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_979:
			this.CpyBtnCnvWideASTROOTACChannel_A8629 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_986:
			this.CnvWideASTRODataMaxPacketSizebytes_A8471Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_993:
			num = (short)394002433;
			if (num != 0)
			{
			}
			this.RTDBtnCnvWideASTRODataMinResponseTimerms_A8514 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9C8:
			this.CpyBtnCnvWideASTRODataTxLimitedPatienceSec_A9544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9D5:
			this.RTDBtnCnvWideASTROOTACOTACRFeature_A8662 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E2:
			this.CpyBtnCnvWideASTRODataTxRespRandomRangeMs_A9563 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9EF:
			this.CnvWideGeneralMplRecallMode_A41698Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9FC:
			this.RTDBtnCnvWideGeneralDirectFrequency_A7860 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A09:
			this.CpyBtnCnvWideGeneralHUBDefeatsPL_A8215 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A16:
			this.HLinkASTROGroupID = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROGroupID.Click += this.HLinkClick;
			return;
			IL_A3A:
			this.RTDBtnCnvWideGeneralHUBDefeatsPL_A8215 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A47:
			this.ConventionlWideFeaturesStatusNumOfAttempts_42156Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A54:
			this.RecNavToolbarExpanderConventionalWideASTROGroupIDList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalWideASTROGroupIDList.ModeClick += this.OnModeClick;
			return;
			IL_A78:
			this.CnvWideConventionalCustomerID_41558Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A85:
			this.CpyBtnCnvWideASTRODataARPCacheTimehrs_A7464 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A92:
			this.CpyBtnConventionlWideFeaturesStatusNumOfAttempts_42156 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A9F:
			this.CpyBtnCnvWideASTRODataTxShortRandomRangeMs_A9565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AAC:
			this.CnvWideASTROGroupIDGroupID1_A7480Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_AD1:
			goto IL_1782;
			IL_AD6:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_AE3:
			this.RTDBtnCnvWideASTRODataTxRespRandomRangeMs_A9563 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AF0:
			this.RTDBtnCnvWideASTRODataMaxPacketSizebytes_A8471 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AFD:
			this.LblCnvWideASTRODataMinResponseTimerms_A8514 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataMinResponseTimerms_A8514.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B21:
			this.ConventionlWideFeaturesStatusNumOfAttempts_42156 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ConventionlWideFeaturesStatusNumOfAttempts_42156.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B45:
			this.LblCnvWideASTRODataFrameSyncSeekPeriodms_A8145 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataFrameSyncSeekPeriodms_A8145.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B69:
			this.RTDBtnCnvWideGeneralSquelchPerPersonality_A19313 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B76:
			this.ExpanderConventionalWideOTACGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B83:
			this.LblCnvWideASTRODataARPCacheTimehrs_A7464 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataARPCacheTimehrs_A7464.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BA7:
			this.CnvWideASTRODataARPCacheTimehrs_A7464 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataARPCacheTimehrs_A7464.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BCB:
			this.CVBtnCnvWideFeaturesSoftIDFeature_A9168 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BD8:
			this.ExpanderConventionalWideOTAC = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_BE5:
			this.CnvWideASTROGroupIDGroupID1_A7480_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BF2:
			this.CnvWideASTRODataTxLongRandomRangeMs_A9546 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataTxLongRandomRangeMs_A9546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C16:
			this.RecNavToolbarExpanderConventionalWideOTAC = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalWideOTAC.ModeClick += this.OnModeClick;
			return;
			IL_C3A:
			this.CnvWideFeaturesSmartPTTRetryTimerms_A9163 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideFeaturesSmartPTTRetryTimerms_A9163.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C5E:
			this.LblCnvWideASTRODataMaxTxAttempts_A8474 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataMaxTxAttempts_A8474.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C82:
			this.CnvWideASTROGroupIDGroupID1_A7480 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvWideASTROGroupIDGroupID1_A7480.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CA6:
			this.CVBtnCnvWideASTRODataARPCacheTimehrs_A7464 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CB3:
			this.CnvWideASTROOTACPosition_A19768Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CC0:
			this.ExpanderConventionalWideASTROGroupIDListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CCD:
			this.CpyBtnCnvWideASTRODataARPCacheDepth_A7463 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CDA:
			this.CpyBtnCnvWideConventionalCustomerID_41558 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CE7:
			this.LblCnvWideASTROGroupIDGroupID1_A7480 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROGroupIDGroupID1_A7480.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D0B:
			this.CnvWideASTROOTACChannel_A8629 = (global::AcpUI.AcpComboBox)target;
			this.CnvWideASTROOTACChannel_A8629.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D2F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_D3C:
			this.LblCnvWideFeaturesSmartPTTRetryTimerms_A9163 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideFeaturesSmartPTTRetryTimerms_A9163.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D60:
			this.ExpanderConventionalWideASTROGroupIDGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D6D:
			this.RTDBtnCnvWideLabtoolUserSelectableSquelch_A9610 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D7A:
			this.RTDBtnCnvWideASTRODataTxLongRandomRangeMs_A9546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D87:
			this.CVBtnCnvWideASTRODataMaxPacketSizebytes_A8471 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D94:
			this.CpyBtnCnvWideGeneralMonitorType_A8544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DA1:
			this.CVBtnCnvWideASTROGroupIDGroupID1_A7480 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DAE:
			this.CVBtnCnvWideASTRODataMaxTxAttempts_A8474 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DBB:
			this.LblCnvWideASTRODataResponseTimerms_A8948 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataResponseTimerms_A8948.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DDF:
			this.CnvWideLabtoolExpandedMDCID_A41790Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DEC:
			this.RTDBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DF9:
			this.GrpBoxExpanderConventionalWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E06:
			this.CVBtnCnvWideGeneralDirectFrequency_A7860 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E13:
			this.CnvWideGeneralHUBDefeatsPL_A8215 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideGeneralHUBDefeatsPL_A8215.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E37:
			this.ExpanderConventionalWideASTROGroupID = (global::AcpUI.AcpExpander)target;
			return;
			IL_E44:
			this.CVBtnCnvWideASTROOTACPosition_A19768 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E51:
			this.ExpanderConventionalWideASTROGroupIDList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_E5E:
			num = (short)930414592;
			short num4 = num;
			this.LblCnvWideASTRODataTxLongRandomRangeMs_A9546 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataTxLongRandomRangeMs_A9546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EAA:
			this.CVBtnCnvWideLabtoolUserSelectableSquelch_A9610 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EB7:
			this.RTDBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EC4:
			this.CnvWideASTRODataFrameSyncSeekPeriodms_A8145Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ED1:
			this.CpyBtnCnvWideASTROOTACZone_A8645 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EDE:
			this.CnvWideLabtoolManufacturerID_A19439Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EEB:
			this.RTDBtnCnvWideASTRODataMaxTxAttempts_A8474 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EF8:
			this.CVBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F05:
			this.RTDBtnCnvWideConventionalCustomerID_41558 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F12:
			this.CnvWideLabtoolUserSelectableSquelch_A9610Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F1F:
			this.CVBtnCnvWideLabtoolManufacturerID_A19439 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F2C:
			this.CnvWideFeaturesSoftIDFeature_A9168Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F39:
			this.CnvWideASTRODataResponseTimerms_A8948Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F46:
			this.CnvWideLabtoolUserSelectableSquelch_A9610 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideLabtoolUserSelectableSquelch_A9610.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F6A:
			this.CnvWideASTROOTACOTACSFeature_A8667Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F77:
			this.CVBtnCnvWideASTRODataTxRespRandomRangeMs_A9563 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F84:
			this.ExpanderConventionalWideFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_F91:
			this.CVBtnCnvWideGeneralHUBDefeatsPL_A8215 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F9E:
			this.CVBtnCnvWideASTRODataTxShortRandomRangeMs_A9565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FAB:
			this.GrpBoxExpanderConventionalWideLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_FB8:
			this.HLinkOneTouch = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkOneTouch.Click += this.HLinkClick;
			return;
			IL_FDC:
			this.CVBtnCnvWideGeneralSquelchPerPersonality_A19313 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FE9:
			this.CnvWideGeneralLatchEnableTime_A8421 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideGeneralLatchEnableTime_A8421.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_100D:
			this.LblCnvWideGeneralDirectFrequency_A7860 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralDirectFrequency_A7860.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1031:
			this.RTDBtnCnvWideFeaturesSoftIDFeature_A9168 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_103E:
			this.CpyBtnCnvWideGeneralDirectFrequency_A7860 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_104B:
			this.CpyBtnCnvWideASTROOTACOTACSFeature_A8667 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1058:
			this.CpyBtnCnvWideASTROOTACPosition_A19768 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1065:
			this.CnvWideFeaturesSmartPTTRetryTimerms_A9163Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1072:
			this.LblCnvWideASTRODataARPCacheDepth_A7463 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataARPCacheDepth_A7463.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1096:
			this.CnvWideASTRODataFrameSyncSeekPeriodms_A8145 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataFrameSyncSeekPeriodms_A8145.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10BA:
			this.RTDBtnCnvWideGeneralLatchEnableTone_A8422 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C7:
			this.LblCnvWideLabtoolUserSelectableSquelch_A9610 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideLabtoolUserSelectableSquelch_A9610.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10EB:
			this.CpyBtnCnvWideLabtoolManufacturerID_A19439 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10F8:
			this.CnvWideGeneralDirectFrequency_A7860 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideGeneralDirectFrequency_A7860.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_111C:
			this.LblCnvWideASTROOTACPosition_A19768 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROOTACPosition_A19768.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1140:
			this.RTDBtnCnvWideASTRODataTxLimitedPatienceSec_A9544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_114D:
			this.CnvWideASTRODataTxRespRandomRangeMs_A9563Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_115A:
			this.GrpBoxExpanderConventionalWideASTRODataPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1167:
			this.LblCnvWideASTROOTACOTACSFeature_A8667 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROOTACOTACSFeature_A8667.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_118B:
			this.CnvWideASTRODataTxShortRandomRangeMs_A9565Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1198:
			this.RTDBtnCnvWideGeneralMplRecallMode_A41698 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11A5:
			this.CnvWideASTROOTACZone_A8645_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_11B2:
			this.CnvWideGeneralLatchEnableTone_A8422Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_11BF:
			this.CnvWideASTROOTACOTACRFeature_A8662Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_11CC:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_11F0:
			this.CpyBtnCnvWideLabtoolExpandedMDCID_A41790 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11FD:
			this.CnvWideGeneralMonitorType_A8544 = (global::AcpUI.AcpComboBox)target;
			this.CnvWideGeneralMonitorType_A8544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1221:
			this.RTDBtnCnvWideASTROOTACOTACSFeature_A8667 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_122E:
			this.LblCnvWideASTRODataTxShortRandomRangeMs_A9565 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataTxShortRandomRangeMs_A9565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1252:
			this.CVBtnCnvWideASTROOTACZone_A8645 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_125F:
			this.ExpanderConventionalWideOneTouch = (global::AcpUI.AcpExpander)target;
			return;
			IL_126C:
			this.LblCnvWideGeneralHUBDefeatsPL_A8215 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralHUBDefeatsPL_A8215.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1290:
			this.CpyBtnCnvWideLabtoolUserSelectableSquelch_A9610 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_129D:
			this.CnvWideASTRODataTxLimitedPatienceSec_A9544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12AA:
			this.ExpanderConventionalWideASTROData = (global::AcpUI.AcpExpander)target;
			return;
			IL_12B7:
			this.LblCnvWideConventionalCustomerID_41558 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideConventionalCustomerID_41558.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12DB:
			this.CpyBtnCnvWideGeneralSquelchPerPersonality_A19313 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12E8:
			this.CVBtnCnvWideGeneralLatchEnableTime_A8421 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12F5:
			this.CpyBtnCnvWideASTROGroupIDGroupID1_A7480 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1302:
			this.CpyBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_130F:
			this.CnvWideASTRODataTxRespRandomRangeMs_A9563 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataTxRespRandomRangeMs_A9563.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1333:
			this.RTDBtnCnvWideLabtoolExpandedMDCID_A41790 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1340:
			this.ExpanderConventionalWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_134D:
			this.CnvWideASTRODataMinResponseTimerms_A8514Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_135A:
			this.CVBtnCnvWideASTROOTACOTACRFeature_A8662 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1367:
			this.CpyBtnCnvWideASTRODataMaxPacketSizebytes_A8471 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1374:
			this.LblCnvWideASTRODataMaxPacketSizebytes_A8471 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTRODataMaxPacketSizebytes_A8471.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1398:
			this.ExpanderConventionalWideOTACTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_13A5:
			this.CnvWideLabtoolManufacturerID_A19439 = (global::AcpUI.AcpLabel)target;
			this.CnvWideLabtoolManufacturerID_A19439.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13C9:
			this.LblCnvWideLabtoolExpandedMDCID_A41790 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideLabtoolExpandedMDCID_A41790.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13ED:
			this.gridExpanderConventionalWideASTROGroupIDListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_13FA:
			this.CnvWideASTRODataARPCacheTimehrs_A7464Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1407:
			this.CpyBtnCnvWideASTROOTACOTACRFeature_A8662 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1414:
			this.CpyBtnCnvWideFeaturesSoftIDFeature_A9168 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1421:
			this.CnvWideASTROOTACOTACRFeature_A8662 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideASTROOTACOTACRFeature_A8662.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1445:
			this.LblCnvWideFeaturesSoftIDFeature_A9168 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideFeaturesSoftIDFeature_A9168.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1469:
			this.HLinkASTROData = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROData.Click += this.HLinkClick;
			return;
			IL_148D:
			this.GrpBoxExpanderConventionalWideFeaturesPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_149A:
			this.RTDBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14A7:
			this.CnvWideGeneralDirectFrequency_A7860Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_14B4:
			this.CnvWideASTRODataARPCacheDepth_A7463Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14C1:
			this.CVBtnCnvWideGeneralMonitorType_A8544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14CE:
			this.CnvWideASTROOTACZone_A8645Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14DB:
			this.gridExpanderConventionalWideOTACSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_14F5:
			this.HLinkSmartPTT = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSmartPTT.Click += this.HLinkClick;
			return;
			IL_1519:
			this.CnvWideLabtoolExpandedMDCID_A41790 = (global::AcpUI.AcpLabel)target;
			this.CnvWideLabtoolExpandedMDCID_A41790.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_153D:
			this.CnvWideASTRODataMaxTxAttempts_A8474 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataMaxTxAttempts_A8474.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1561:
			this.RTDBtnCnvWideASTROGroupIDGroupID1_A7480 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_156E:
			this.CnvWideGeneralLatchEnableTone_A8422 = (global::AcpUI.AcpCheckBox)target;
			this.CnvWideGeneralLatchEnableTone_A8422.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1592:
			this.CpyBtnCnvWideASTRODataMinResponseTimerms_A8514 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_159F:
			this.CVBtnCnvWideASTRODataResponseTimerms_A8948 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15AC:
			this.ExpanderConventionalWideASTROOTAC = (global::AcpUI.AcpExpander)target;
			return;
			IL_15B9:
			this.CpyBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15C6:
			this.LblCnvWideLabtoolManufacturerID_A19439 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideLabtoolManufacturerID_A19439.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15EA:
			this.CpyBtnCnvWideGeneralLatchEnableTime_A8421 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15F7:
			this.RTDBtnCnvWideASTRODataARPCacheTimehrs_A7464 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1604:
			this.CnvWideConventionalCustomerID_41558 = (global::AcpUI.AcpTextBox)target;
			this.CnvWideConventionalCustomerID_41558.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1628:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_164C:
			this.CnvWideASTRODataTxShortRandomRangeMs_A9565 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataTxShortRandomRangeMs_A9565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1670:
			this.CnvWideASTRODataMaxTxAttempts_A8474Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_167D:
			this.CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_168A:
			this.LblCnvWideASTROOTACChannel_A8629 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideASTROOTACChannel_A8629.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16AE:
			this.CVBtnCnvWideASTRODataTxLongRandomRangeMs_A9546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16BB:
			this.LblCnvWideGeneralMonitorType_A8544 = (global::AcpUI.AcpLabel)target;
			this.LblCnvWideGeneralMonitorType_A8544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16DF:
			this.CnvWideGeneralLatchEnableTime_A8421Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16EC:
			this.LblConventionlWideFeaturesStatusNumOfAttempts_42156 = (global::AcpUI.AcpLabel)target;
			this.LblConventionlWideFeaturesStatusNumOfAttempts_42156.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1710:
			this.CnvWideASTRODataTxLimitedPatienceSec_A9544 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvWideASTRODataTxLimitedPatienceSec_A9544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1734:
			this.ExpanderConventionalWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_1741:
			this.RTDBtnCnvWideLabtoolManufacturerID_A19439 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_174E:
			this.CnvWideASTRODataTxLongRandomRangeMs_A9546Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_175B:
			this.CVBtnCnvWideASTROOTACChannel_A8629 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1768:
			this.RTDBtnCnvWideGeneralLatchEnableTime_A8421 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1775:
			this.CnvWideGeneralMonitorType_A8544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1782:
			this.b = true;
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x00A7F028 File Offset: 0x00A7D228
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)657627011;
			short num2 = num;
			num = (short)887592835;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_101;
			case 1:
				break;
			default:
			{
				num = (short)1833959424;
				short num3 = num;
				break;
			}
			}
			num = (short)2036858881;
			if (num != 0)
			{
			}
			num = (short)995557376;
			if (num != 0)
			{
			}
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				IL_101:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
		}

		// Token: 0x040057BE RID: 22462
		private bool a;

		// Token: 0x040057BF RID: 22463
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040057C0 RID: 22464
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040057C1 RID: 22465
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x040057C2 RID: 22466
		internal global::System.Windows.Documents.Hyperlink HLinkASTROData;

		// Token: 0x040057C3 RID: 22467
		internal global::System.Windows.Documents.Hyperlink HLinkASTROGroupID;

		// Token: 0x040057C4 RID: 22468
		internal global::System.Windows.Documents.Hyperlink HLinkASTROOTAC;

		// Token: 0x040057C5 RID: 22469
		internal global::System.Windows.Documents.Hyperlink HLinkSmartPTT;

		// Token: 0x040057C6 RID: 22470
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x040057C7 RID: 22471
		internal global::System.Windows.Documents.Hyperlink HLinkOneTouch;

		// Token: 0x040057C8 RID: 22472
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040057C9 RID: 22473
		internal global::AcpUI.AcpExpander ExpanderConventionalWideGeneral;

		// Token: 0x040057CA RID: 22474
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideGeneralPseudo0;

		// Token: 0x040057CB RID: 22475
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralMonitorType_A8544;

		// Token: 0x040057CC RID: 22476
		internal global::AcpUI.AcpLabel LblCnvWideGeneralMonitorType_A8544;

		// Token: 0x040057CD RID: 22477
		internal global::AcpUI.AcpComboBox CnvWideGeneralMonitorType_A8544;

		// Token: 0x040057CE RID: 22478
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralMonitorType_A8544;

		// Token: 0x040057CF RID: 22479
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralMonitorType_A8544;

		// Token: 0x040057D0 RID: 22480
		internal global::AcpUI.AcpLabel CnvWideGeneralMonitorType_A8544Comp;

		// Token: 0x040057D1 RID: 22481
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040057D2 RID: 22482
		internal global::AcpUI.AcpLabel LblCnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040057D3 RID: 22483
		internal global::AcpUI.AcpCheckBox CnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040057D4 RID: 22484
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040057D5 RID: 22485
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040057D6 RID: 22486
		internal global::AcpUI.AcpCheckBox CnvWideGeneralDirectFrequency_A7860Comp;

		// Token: 0x040057D7 RID: 22487
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040057D8 RID: 22488
		internal global::AcpUI.AcpLabel LblCnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040057D9 RID: 22489
		internal global::AcpUI.AcpCheckBox CnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040057DA RID: 22490
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040057DB RID: 22491
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040057DC RID: 22492
		internal global::AcpUI.AcpCheckBox CnvWideGeneralHUBDefeatsPL_A8215Comp;

		// Token: 0x040057DD RID: 22493
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040057DE RID: 22494
		internal global::AcpUI.AcpLabel LblCnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040057DF RID: 22495
		internal global::AcpUI.AcpCheckBox CnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040057E0 RID: 22496
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040057E1 RID: 22497
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040057E2 RID: 22498
		internal global::AcpUI.AcpCheckBox CnvWideGeneralSquelchPerPersonality_A19313Comp;

		// Token: 0x040057E3 RID: 22499
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040057E4 RID: 22500
		internal global::AcpUI.AcpLabel LblCnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040057E5 RID: 22501
		internal global::AcpUI.AcpCheckBox CnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040057E6 RID: 22502
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040057E7 RID: 22503
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040057E8 RID: 22504
		internal global::AcpUI.AcpCheckBox CnvWideGeneralLatchEnableTone_A8422Comp;

		// Token: 0x040057E9 RID: 22505
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040057EA RID: 22506
		internal global::AcpUI.AcpLabel LblCnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040057EB RID: 22507
		internal global::AcpUI.AcpTextBoxSpinner CnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040057EC RID: 22508
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040057ED RID: 22509
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040057EE RID: 22510
		internal global::AcpUI.AcpLabel CnvWideGeneralLatchEnableTime_A8421Comp;

		// Token: 0x040057EF RID: 22511
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideGeneralMplRecallMode_A41698;

		// Token: 0x040057F0 RID: 22512
		internal global::AcpUI.AcpLabel LblCnvWideGeneralMplRecallMode_A41698;

		// Token: 0x040057F1 RID: 22513
		internal global::AcpUI.AcpComboBox CnvWideGeneralMplRecallMode_A41698;

		// Token: 0x040057F2 RID: 22514
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideGeneralMplRecallMode_A41698;

		// Token: 0x040057F3 RID: 22515
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideGeneralMplRecallMode_A41698;

		// Token: 0x040057F4 RID: 22516
		internal global::AcpUI.AcpLabel CnvWideGeneralMplRecallMode_A41698Comp;

		// Token: 0x040057F5 RID: 22517
		internal global::AcpUI.AcpExpander ExpanderConventionalWideFeatures;

		// Token: 0x040057F6 RID: 22518
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideFeaturesSmartPTT;

		// Token: 0x040057F7 RID: 22519
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040057F8 RID: 22520
		internal global::AcpUI.AcpLabel LblCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040057F9 RID: 22521
		internal global::AcpUI.AcpTextBoxSpinner CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040057FA RID: 22522
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040057FB RID: 22523
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040057FC RID: 22524
		internal global::AcpUI.AcpLabel CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Comp;

		// Token: 0x040057FD RID: 22525
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x040057FE RID: 22526
		internal global::AcpUI.AcpLabel LblCnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x040057FF RID: 22527
		internal global::AcpUI.AcpTextBoxSpinner CnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x04005800 RID: 22528
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x04005801 RID: 22529
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x04005802 RID: 22530
		internal global::AcpUI.AcpLabel CnvWideFeaturesSmartPTTRetryTimerms_A9163Comp;

		// Token: 0x04005803 RID: 22531
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideFeaturesPseudo1;

		// Token: 0x04005804 RID: 22532
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x04005805 RID: 22533
		internal global::AcpUI.AcpLabel LblCnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x04005806 RID: 22534
		internal global::AcpUI.AcpCheckBox CnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x04005807 RID: 22535
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x04005808 RID: 22536
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x04005809 RID: 22537
		internal global::AcpUI.AcpCheckBox CnvWideFeaturesSoftIDFeature_A9168Comp;

		// Token: 0x0400580A RID: 22538
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConventionlWideFeaturesStatusNumOfAttempts_42156;

		// Token: 0x0400580B RID: 22539
		internal global::AcpUI.AcpLabel LblConventionlWideFeaturesStatusNumOfAttempts_42156;

		// Token: 0x0400580C RID: 22540
		internal global::AcpUI.AcpTextBoxSpinner ConventionlWideFeaturesStatusNumOfAttempts_42156;

		// Token: 0x0400580D RID: 22541
		internal global::AcpUI.AcpRtdButton RTDBtnConventionlWideFeaturesStatusNumOfAttempts_42156;

		// Token: 0x0400580E RID: 22542
		internal global::AcpUI.AcpCopyButton CpyBtnConventionlWideFeaturesStatusNumOfAttempts_42156;

		// Token: 0x0400580F RID: 22543
		internal global::AcpUI.AcpLabel ConventionlWideFeaturesStatusNumOfAttempts_42156Comp;

		// Token: 0x04005810 RID: 22544
		internal global::AcpUI.AcpExpander ExpanderConventionalWideASTROData;

		// Token: 0x04005811 RID: 22545
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideASTRODataCAIData;

		// Token: 0x04005812 RID: 22546
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x04005813 RID: 22547
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x04005814 RID: 22548
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x04005815 RID: 22549
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x04005816 RID: 22550
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x04005817 RID: 22551
		internal global::AcpUI.AcpLabel CnvWideASTRODataMaxTxAttempts_A8474Comp;

		// Token: 0x04005818 RID: 22552
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x04005819 RID: 22553
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x0400581A RID: 22554
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x0400581B RID: 22555
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x0400581C RID: 22556
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x0400581D RID: 22557
		internal global::AcpUI.AcpLabel CnvWideASTRODataResponseTimerms_A8948Comp;

		// Token: 0x0400581E RID: 22558
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x0400581F RID: 22559
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x04005820 RID: 22560
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x04005821 RID: 22561
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x04005822 RID: 22562
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x04005823 RID: 22563
		internal global::AcpUI.AcpLabel CnvWideASTRODataMinResponseTimerms_A8514Comp;

		// Token: 0x04005824 RID: 22564
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x04005825 RID: 22565
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x04005826 RID: 22566
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x04005827 RID: 22567
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x04005828 RID: 22568
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x04005829 RID: 22569
		internal global::AcpUI.AcpLabel CnvWideASTRODataMaxPacketSizebytes_A8471Comp;

		// Token: 0x0400582A RID: 22570
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideASTRODataPseudo1;

		// Token: 0x0400582B RID: 22571
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x0400582C RID: 22572
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x0400582D RID: 22573
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x0400582E RID: 22574
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x0400582F RID: 22575
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x04005830 RID: 22576
		internal global::AcpUI.AcpLabel CnvWideASTRODataFrameSyncSeekPeriodms_A8145Comp;

		// Token: 0x04005831 RID: 22577
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x04005832 RID: 22578
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x04005833 RID: 22579
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x04005834 RID: 22580
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x04005835 RID: 22581
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x04005836 RID: 22582
		internal global::AcpUI.AcpLabel CnvWideASTRODataTxShortRandomRangeMs_A9565Comp;

		// Token: 0x04005837 RID: 22583
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x04005838 RID: 22584
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x04005839 RID: 22585
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x0400583A RID: 22586
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x0400583B RID: 22587
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x0400583C RID: 22588
		internal global::AcpUI.AcpLabel CnvWideASTRODataTxLongRandomRangeMs_A9546Comp;

		// Token: 0x0400583D RID: 22589
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x0400583E RID: 22590
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x0400583F RID: 22591
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x04005840 RID: 22592
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x04005841 RID: 22593
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x04005842 RID: 22594
		internal global::AcpUI.AcpLabel CnvWideASTRODataTxRespRandomRangeMs_A9563Comp;

		// Token: 0x04005843 RID: 22595
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x04005844 RID: 22596
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x04005845 RID: 22597
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x04005846 RID: 22598
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x04005847 RID: 22599
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x04005848 RID: 22600
		internal global::AcpUI.AcpLabel CnvWideASTRODataTxLimitedPatienceSec_A9544Comp;

		// Token: 0x04005849 RID: 22601
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x0400584A RID: 22602
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x0400584B RID: 22603
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x0400584C RID: 22604
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x0400584D RID: 22605
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x0400584E RID: 22606
		internal global::AcpUI.AcpLabel CnvWideASTRODataARPCacheDepth_A7463Comp;

		// Token: 0x0400584F RID: 22607
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x04005850 RID: 22608
		internal global::AcpUI.AcpLabel LblCnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x04005851 RID: 22609
		internal global::AcpUI.AcpTextBoxSpinner CnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x04005852 RID: 22610
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x04005853 RID: 22611
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x04005854 RID: 22612
		internal global::AcpUI.AcpLabel CnvWideASTRODataARPCacheTimehrs_A7464Comp;

		// Token: 0x04005855 RID: 22613
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideConventionalCustomerID_41558;

		// Token: 0x04005856 RID: 22614
		internal global::AcpUI.AcpLabel LblCnvWideConventionalCustomerID_41558;

		// Token: 0x04005857 RID: 22615
		internal global::AcpUI.AcpTextBox CnvWideConventionalCustomerID_41558;

		// Token: 0x04005858 RID: 22616
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideConventionalCustomerID_41558;

		// Token: 0x04005859 RID: 22617
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideConventionalCustomerID_41558;

		// Token: 0x0400585A RID: 22618
		internal global::AcpUI.AcpLabel CnvWideConventionalCustomerID_41558Comp;

		// Token: 0x0400585B RID: 22619
		internal global::AcpUI.AcpExpander ExpanderConventionalWideASTROGroupID;

		// Token: 0x0400585C RID: 22620
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderConventionalWideASTROGroupIDList;

		// Token: 0x0400585D RID: 22621
		internal global::System.Windows.Controls.Grid ExpanderConventionalWideASTROGroupIDGrid;

		// Token: 0x0400585E RID: 22622
		internal global::System.Windows.Controls.Grid ExpanderConventionalWideASTROGroupIDListGrid;

		// Token: 0x0400585F RID: 22623
		internal global::AcpUI.AcpGroupBox ExpanderConventionalWideASTROGroupIDListTableView;

		// Token: 0x04005860 RID: 22624
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalWideASTROGroupIDList;

		// Token: 0x04005861 RID: 22625
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvWideASTROGroupIDGroupID1_A7480_Col;

		// Token: 0x04005862 RID: 22626
		internal global::AcpUI.AcpGroupBox ExpanderConventionalWideASTROGroupIDListSRecView;

		// Token: 0x04005863 RID: 22627
		internal global::System.Windows.Controls.Grid gridExpanderConventionalWideASTROGroupIDListSRecView;

		// Token: 0x04005864 RID: 22628
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvWideASTROGroupIDGroupID1_A7480;

		// Token: 0x04005865 RID: 22629
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROGroupIDGroupID1_A7480;

		// Token: 0x04005866 RID: 22630
		internal global::AcpUI.AcpLabel LblCnvWideASTROGroupIDGroupID1_A7480;

		// Token: 0x04005867 RID: 22631
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTROGroupIDGroupID1_A7480;

		// Token: 0x04005868 RID: 22632
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROGroupIDGroupID1_A7480;

		// Token: 0x04005869 RID: 22633
		internal global::AcpUI.AcpTextBoxDecHex CnvWideASTROGroupIDGroupID1_A7480Comp;

		// Token: 0x0400586A RID: 22634
		internal global::AcpUI.AcpExpander ExpanderConventionalWideASTROOTAC;

		// Token: 0x0400586B RID: 22635
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderConventionalWideOTAC;

		// Token: 0x0400586C RID: 22636
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideASTROOTACPseudo0;

		// Token: 0x0400586D RID: 22637
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROOTACOTACSFeature_A8667;

		// Token: 0x0400586E RID: 22638
		internal global::AcpUI.AcpLabel LblCnvWideASTROOTACOTACSFeature_A8667;

		// Token: 0x0400586F RID: 22639
		internal global::AcpUI.AcpCheckBox CnvWideASTROOTACOTACSFeature_A8667;

		// Token: 0x04005870 RID: 22640
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTROOTACOTACSFeature_A8667;

		// Token: 0x04005871 RID: 22641
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROOTACOTACSFeature_A8667;

		// Token: 0x04005872 RID: 22642
		internal global::AcpUI.AcpCheckBox CnvWideASTROOTACOTACSFeature_A8667Comp;

		// Token: 0x04005873 RID: 22643
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x04005874 RID: 22644
		internal global::AcpUI.AcpLabel LblCnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x04005875 RID: 22645
		internal global::AcpUI.AcpCheckBox CnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x04005876 RID: 22646
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x04005877 RID: 22647
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x04005878 RID: 22648
		internal global::AcpUI.AcpCheckBox CnvWideASTROOTACOTACRFeature_A8662Comp;

		// Token: 0x04005879 RID: 22649
		internal global::System.Windows.Controls.Grid ExpanderConventionalWideASTROOTACGrid;

		// Token: 0x0400587A RID: 22650
		internal global::System.Windows.Controls.Grid ExpanderConventionalWideOTACGrid;

		// Token: 0x0400587B RID: 22651
		internal global::AcpUI.AcpGroupBox ExpanderConventionalWideOTACTableView;

		// Token: 0x0400587C RID: 22652
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalWideOTAC;

		// Token: 0x0400587D RID: 22653
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvWideASTROOTACPosition_A19768_Col;

		// Token: 0x0400587E RID: 22654
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvWideASTROOTACZone_A8645_Col;

		// Token: 0x0400587F RID: 22655
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvWideASTROOTACChannel_A8629_Col;

		// Token: 0x04005880 RID: 22656
		internal global::AcpUI.AcpGroupBox ExpanderConventionalWideOTACSRecView;

		// Token: 0x04005881 RID: 22657
		internal global::System.Windows.Controls.Grid gridExpanderConventionalWideOTACSRecView;

		// Token: 0x04005882 RID: 22658
		internal global::AcpUI.AcpLabel CnvWideASTROOTACPosition_A19768;

		// Token: 0x04005883 RID: 22659
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROOTACPosition_A19768;

		// Token: 0x04005884 RID: 22660
		internal global::AcpUI.AcpLabel LblCnvWideASTROOTACPosition_A19768;

		// Token: 0x04005885 RID: 22661
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROOTACPosition_A19768;

		// Token: 0x04005886 RID: 22662
		internal global::AcpUI.AcpLabel CnvWideASTROOTACPosition_A19768Comp;

		// Token: 0x04005887 RID: 22663
		internal global::AcpUI.AcpComboBox CnvWideASTROOTACZone_A8645;

		// Token: 0x04005888 RID: 22664
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROOTACZone_A8645;

		// Token: 0x04005889 RID: 22665
		internal global::AcpUI.AcpLabel LblCnvWideASTROOTACZone_A8645;

		// Token: 0x0400588A RID: 22666
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTROOTACZone_A8645;

		// Token: 0x0400588B RID: 22667
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROOTACZone_A8645;

		// Token: 0x0400588C RID: 22668
		internal global::AcpUI.AcpLabel CnvWideASTROOTACZone_A8645Comp;

		// Token: 0x0400588D RID: 22669
		internal global::AcpUI.AcpComboBox CnvWideASTROOTACChannel_A8629;

		// Token: 0x0400588E RID: 22670
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideASTROOTACChannel_A8629;

		// Token: 0x0400588F RID: 22671
		internal global::AcpUI.AcpLabel LblCnvWideASTROOTACChannel_A8629;

		// Token: 0x04005890 RID: 22672
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideASTROOTACChannel_A8629;

		// Token: 0x04005891 RID: 22673
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideASTROOTACChannel_A8629;

		// Token: 0x04005892 RID: 22674
		internal global::AcpUI.AcpLabel CnvWideASTROOTACChannel_A8629Comp;

		// Token: 0x04005893 RID: 22675
		internal global::AcpUI.AcpExpander ExpanderConventionalWideSmartPTT;

		// Token: 0x04005894 RID: 22676
		internal global::AcpUI.AcpExpander ExpanderConventionalWideLabtool;

		// Token: 0x04005895 RID: 22677
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalWideLabtoolPseudo0;

		// Token: 0x04005896 RID: 22678
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x04005897 RID: 22679
		internal global::AcpUI.AcpLabel LblCnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x04005898 RID: 22680
		internal global::AcpUI.AcpCheckBox CnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x04005899 RID: 22681
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x0400589A RID: 22682
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x0400589B RID: 22683
		internal global::AcpUI.AcpCheckBox CnvWideLabtoolUserSelectableSquelch_A9610Comp;

		// Token: 0x0400589C RID: 22684
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideLabtoolManufacturerID_A19439;

		// Token: 0x0400589D RID: 22685
		internal global::AcpUI.AcpLabel LblCnvWideLabtoolManufacturerID_A19439;

		// Token: 0x0400589E RID: 22686
		internal global::AcpUI.AcpLabel CnvWideLabtoolManufacturerID_A19439;

		// Token: 0x0400589F RID: 22687
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideLabtoolManufacturerID_A19439;

		// Token: 0x040058A0 RID: 22688
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideLabtoolManufacturerID_A19439;

		// Token: 0x040058A1 RID: 22689
		internal global::AcpUI.AcpLabel CnvWideLabtoolManufacturerID_A19439Comp;

		// Token: 0x040058A2 RID: 22690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvWideLabtoolExpandedMDCID_A41790;

		// Token: 0x040058A3 RID: 22691
		internal global::AcpUI.AcpLabel LblCnvWideLabtoolExpandedMDCID_A41790;

		// Token: 0x040058A4 RID: 22692
		internal global::AcpUI.AcpLabel CnvWideLabtoolExpandedMDCID_A41790;

		// Token: 0x040058A5 RID: 22693
		internal global::AcpUI.AcpRtdButton RTDBtnCnvWideLabtoolExpandedMDCID_A41790;

		// Token: 0x040058A6 RID: 22694
		internal global::AcpUI.AcpCopyButton CpyBtnCnvWideLabtoolExpandedMDCID_A41790;

		// Token: 0x040058A7 RID: 22695
		internal global::AcpUI.AcpLabel CnvWideLabtoolExpandedMDCID_A41790Comp;

		// Token: 0x040058A8 RID: 22696
		internal global::AcpUI.AcpExpander ExpanderConventionalWideOneTouch;

		// Token: 0x040058A9 RID: 22697
		private bool b;
	}
}
