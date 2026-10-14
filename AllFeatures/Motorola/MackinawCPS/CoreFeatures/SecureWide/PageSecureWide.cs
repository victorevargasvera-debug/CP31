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

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000EB RID: 235
	public class PageSecureWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x00221108 File Offset: 0x0021F308
		public PageSecureWide()
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

		// Token: 0x060022E8 RID: 8936 RVA: 0x00221140 File Offset: 0x0021F340
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)206307328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)255262726;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1324089348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81;
					}
					case 1:
					{
						object obj = null;
						obj = this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.MyRecordsetDataSource;
						num = (short)463798272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)719257606;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)60030978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)390004740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)671860528;
									short num3 = num;
									num = (short)1900529456;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_22A;
									default:
										num = (short)803012608;
										if (num != 0)
										{
										}
										num = (short)624230405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_22A;
								case 4:
									if (acpExpander != null)
									{
										num = (short)1588723715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_2F8;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1F2;
									}
									continue;
								}
								IL_1F4:
								num = (short)478019585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F2:
								goto IL_1F4;
								IL_22A:
								base.Expanders.Add(acpExpander);
								num = (short)1207631872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F8:
							goto IL_F3;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_31A;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_307:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)544407553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_36C;
								case 2:
									if (disposable != null)
									{
										num = (short)1205600256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_36E;
								}
								goto IL_31A;
							}
							IL_36C:
							IL_36E:
							goto EndFinally_8;
							IL_31A:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)923860994;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_307;
							EndFinally_8:;
						}
						goto IL_36F;
						IL_F3:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)504365059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_11B;
					case 4:
					{
						num = (short)1996226560;
						short num4 = num;
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.MyDataPresenter = this.ExpanderSecureWideEncryptionKeyListTable;
						num = (short)321519617;
						if (num != 0)
						{
						}
						num = (short)770179077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_81;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					}
					IL_5F:
					if (!this.a)
					{
						num = (short)1732378625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_81:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)983957506;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				IL_36F:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x002214F0 File Offset: 0x0021F6F0
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
					goto IL_68;
				case 1:
				{
					num2 = (short)79036416;
					short num3 = num2;
					num2 = (short)1197424110;
					short num4 = num2;
					num2 = (short)722419182;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						goto IL_117;
					}
					break;
				}
				case 2:
					if (this.a)
					{
						num2 = (short)554303488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
				IL_68:
				num2 = (short)1616773121;
				if (num2 != 0)
				{
				}
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)65273857;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_117:
			num2 = (short)1517617152;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.DataContext = null;
			this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.MyDataPresenter = null;
			num2 = (short)270073858;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0022162C File Offset: 0x0021F82C
		public override void SetDataContext()
		{
			short num = (short)1343815691;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)218955781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable).MySecondaryRecordsetDataSource = null;
					num = (short)1743912960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)826867720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1875968013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_D1;
				case 5:
				{
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2021);
					num = (short)2117861376;
					short num3 = num;
					num = (short)171376646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (feature != null)
					{
						num = (short)1444544524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_30B;
				case 8:
					num = (short)1982595082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_30B;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10040] != null)
					{
						num = (short)623575043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 12:
				{
					num = (short)1801452125;
					short num4 = num;
					num = (short)2105735773;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
						num = (short)1067450368;
						if (num != 0)
						{
						}
						num = (short)1049952258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10040].EmbeddedRecset != null)
					{
						num = (short)1449328644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					num = (short)2102788097;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2021);
					num = (short)275972105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1834942478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_166:
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
				num = (short)2014183431;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30B:
				num = (short)1959985153;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10040].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable).SyncDataSources();
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00221984 File Offset: 0x0021FB84
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)834142216;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)856031234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮ꋰ雲雴苶诸黺꫼雾攀昂䀄椆樈礊琌缎攐稒稔礖刘縚搜匞䠠倢儤猦䠨䤪䄬䨮", a_))
					{
						num = (short)1834483712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)1566703621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1362690054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1108236854;
					short num3 = num;
					num = (short)2047695414;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)147324928;
						if (num != 0)
						{
						}
						if (myRecordsetDataSource != null)
						{
							num = (short)467271684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					goto IL_137;
				case 5:
					goto IL_9F;
				case 6:
					goto IL_1B3;
				case 7:
					num = (short)1646723073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				}
				IL_51:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)936574983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_9F:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				myRecordsetDataSource = this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.MyRecordsetDataSource;
				num = (short)815923203;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_137:
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner item = (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
			return;
			IL_1B3:
			num = (short)791347200;
			short num4 = num;
			num = (short)1568014337;
			if (num != 0)
			{
			}
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00221BDC File Offset: 0x0021FDDC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1290797057;
			if (num != 0)
			{
			}
			num = (short)1986854912;
			short num2 = num;
			num = (short)1405813718;
			short num3 = num;
			num = (short)708641750;
			switch (num3 == num)
			{
			}
			num = (short)275251200;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00221C8C File Offset: 0x0021FE8C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)831791867;
			short num2 = num;
			num = (short)1153049339;
			switch (num2 == num)
			{
			default:
			{
				num = (short)774373376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)95485953;
			if (num != 0)
			{
			}
			num = (short)1129447424;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00221D3C File Offset: 0x0021FF3C
		internal void OnExpanderSecureWideEncryptionKeyListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num2 = (short)823289327;
					short num3 = num2;
					num2 = (short)624715247;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					case 1:
						goto IL_110;
					}
					goto Block_2;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)2040332288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				}
				goto IL_1C;
				IL_7C:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.SyncDataSources();
				num2 = (short)460324865;
				num = (int)((global::System.IntPtr)num2);
			}
			Block_2:
			num2 = (short)1461911552;
			short num4 = num2;
			IL_110:
			num2 = (short)71761920;
			if (num2 != 0)
			{
			}
			IL_128:
			num2 = (short)1453457409;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.MyRecordsetDataSource;
			num2 = (short)1610547202;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00221EA4 File Offset: 0x002200A4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num;
			while (!this.b)
			{
				num = (short)445888124;
				short num2 = num;
				num = (short)224310908;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)544800768;
					if (num != 0)
					{
					}
					num = (short)108199936;
					short num3 = num;
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ뿛뇝跟鋡诣裥跧蓩飫쇭華韱音菵諷鿹\ud9fb쳽ヿ愁欃栅渇按欋笍戏猑怓缕眗琙㌛洝䔟䄡儣吥䴧༩ḫḭ䜯嬱倳匵᜷䤹夻崽㔿ぁ⅃ㅅⅇ⹉⥋恍⡏㍑㥓㩕", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1613889537;
			if (num != 0)
			{
			}
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00221F84 File Offset: 0x00220184
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)705036288;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)718120937;
					short num3 = num;
					num = (short)1625335785;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61C;
					default:
						num = (short)553910272;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)1081999362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_CE6;
				}
				IL_7A:
				switch (connectionId)
				{
				case 1:
					goto IL_C9D;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
					goto IL_2144;
				case 9:
					goto IL_728;
				case 10:
					goto IL_137E;
				case 11:
					goto IL_1D77;
				case 12:
					goto IL_1BAA;
				case 13:
					goto IL_922;
				case 14:
					goto IL_1BE8;
				case 15:
					goto IL_1632;
				case 16:
					goto IL_BB5;
				case 17:
					goto IL_882;
				case 18:
					goto IL_1985;
				case 19:
					goto IL_16D5;
				case 20:
					goto IL_17C3;
				case 21:
					goto IL_1B48;
				case 22:
					goto IL_EC4;
				case 23:
					goto IL_11AF;
				case 24:
					goto IL_1C4A;
				case 25:
					goto IL_1520;
				case 26:
					goto IL_FA5;
				case 27:
					goto IL_20E2;
				case 28:
					goto IL_1EBA;
				case 29:
					goto IL_1CD7;
				case 30:
					goto IL_16A1;
				case 31:
					goto IL_1828;
				case 32:
					goto IL_991;
				case 33:
					goto IL_F57;
				case 34:
					goto IL_13AF;
				case 35:
					goto IL_FB2;
				case 36:
					goto IL_1D9B;
				case 37:
					goto IL_1C57;
				case 38:
					goto IL_1FAF;
				case 39:
					goto IL_11D6;
				case 40:
					goto IL_2007;
				case 41:
					goto IL_B84;
				case 42:
					goto IL_12C1;
				case 43:
					goto IL_1207;
				case 44:
					goto IL_1978;
				case 45:
					goto IL_1A90;
				case 46:
					goto IL_1670;
				case 47:
					goto IL_1F8B;
				case 48:
					goto IL_141E;
				case 49:
					goto IL_1188;
				case 50:
					goto IL_BD9;
				case 51:
					goto IL_FD6;
				case 52:
					goto IL_64D;
				case 53:
					goto IL_148D;
				case 54:
					goto IL_BA8;
				case 55:
					goto IL_A5B;
				case 56:
					goto IL_D2C;
				case 57:
					goto IL_960;
				case 58:
					goto IL_11BC;
				case 59:
					goto IL_2120;
				case 60:
					goto IL_99E;
				case 61:
					goto IL_759;
				case 62:
					goto IL_915;
				case 63:
					goto IL_1737;
				case 64:
					goto IL_1B21;
				case 65:
					goto IL_14B1;
				case 66:
					goto IL_1283;
				case 67:
					goto IL_1364;
				case 68:
					goto IL_A27;
				case 69:
					goto IL_1D15;
				case 70:
					goto IL_1E62;
				case 71:
					goto IL_1F71;
				case 72:
					goto IL_1909;
				case 73:
					goto IL_735;
				case 74:
					goto IL_11C9;
				case 75:
					goto IL_1FFA;
				case 76:
					goto IL_1BDB;
				case 77:
					goto IL_1A76;
				case 78:
					goto IL_1DC2;
				case 79:
					goto IL_61C;
				case 80:
					goto IL_806;
				case 81:
					goto IL_9CF;
				case 82:
					goto IL_1A69;
				case 83:
					goto IL_766;
				case 84:
					goto IL_19FA;
				case 85:
					goto IL_14E2;
				case 86:
					goto IL_192D;
				case 87:
					goto IL_B77;
				case 88:
					goto IL_6DD;
				case 89:
					goto IL_953;
				case 90:
					goto IL_179C;
				case 91:
					goto IL_851;
				case 92:
					goto IL_1333;
				case 93:
					goto IL_844;
				case 94:
					goto IL_1052;
				case 95:
					goto IL_1C64;
				case 96:
					goto IL_1A1E;
				case 97:
					goto IL_1164;
				case 98:
					goto IL_1A45;
				case 99:
					goto IL_1093;
				case 100:
					goto IL_19C6;
				case 101:
					goto IL_DFD;
				case 102:
					goto IL_EE8;
				case 103:
					goto IL_1835;
				case 104:
					goto IL_820;
				case 105:
					goto IL_1245;
				case 106:
					goto IL_17EA;
				case 107:
					goto IL_D77;
				case 108:
					goto IL_1663;
				case 109:
					goto IL_19AC;
				case 110:
					goto IL_1D08;
				case 111:
					goto IL_1E96;
				case 112:
					goto IL_11E3;
				case 113:
					goto IL_7F9;
				case 114:
					goto IL_1656;
				case 115:
					goto IL_1B9D;
				case 116:
					goto IL_1DB5;
				case 117:
					goto IL_89C;
				case 118:
					goto IL_16EF;
				case 119:
					goto IL_A41;
				case 120:
					goto IL_D12;
				case 121:
					goto IL_C48;
				case 122:
					goto IL_1859;
				case 123:
					goto IL_BE6;
				case 124:
					goto IL_10C7;
				case 125:
					goto IL_1625;
				case 126:
					goto IL_E0A;
				case 127:
					goto IL_8E4;
				case 128:
					goto IL_160B;
				case 129:
					goto IL_F71;
				case 130:
					goto IL_1BCE;
				case 131:
					goto IL_145C;
				case 132:
					goto IL_1C26;
				case 133:
					goto IL_AA6;
				case 134:
					goto IL_1EDE;
				case 135:
					goto IL_1086;
				case 136:
					goto IL_1C71;
				case 137:
					goto IL_1C7E;
				case 138:
					goto IL_1751;
				case 139:
					goto IL_F7E;
				case 140:
					goto IL_19D3;
				case 141:
					goto IL_7BB;
				case 142:
					goto IL_7C8;
				case 143:
					goto IL_D05;
				case 144:
					goto IL_1B6C;
				case 145:
					goto IL_A82;
				case 146:
					goto IL_AB3;
				case 147:
					goto IL_1B3B;
				case 148:
					goto IL_1AAA;
				case 149:
					goto IL_AFE;
				case 150:
					goto IL_10EB;
				case 151:
					goto IL_1EEB;
				case 152:
					goto IL_1744;
				case 153:
					goto IL_1F64;
				case 154:
					goto IL_18FC;
				case 155:
					goto IL_CF8;
				case 156:
					goto IL_F33;
				case 157:
					goto IL_152D;
				case 158:
					goto IL_16C8;
				case 159:
					goto IL_71B;
				case 160:
					goto IL_D1F;
				case 161:
					goto IL_AF1;
				case 162:
					goto IL_1FE0;
				case 163:
					goto IL_1954;
				case 164:
					goto IL_125F;
				case 165:
					goto IL_88F;
				case 166:
					goto IL_12F5;
				case 167:
					goto IL_1782;
				case 168:
					goto IL_F98;
				case 169:
					goto IL_155E;
				case 170:
					goto IL_1582;
				case 171:
					goto IL_105F;
				case 172:
					goto IL_1F7E;
				case 173:
					goto IL_17DD;
				case 174:
					goto IL_1195;
				case 175:
					goto IL_1AFA;
				case 176:
					goto IL_13E0;
				case 177:
					goto IL_C55;
				case 178:
					goto IL_875;
				case 179:
					goto IL_1B14;
				case 180:
					goto IL_19E0;
				case 181:
					goto IL_1326;
				case 182:
					goto IL_1804;
				case 183:
					goto IL_DCC;
				case 184:
					goto IL_1038;
				case 185:
					goto IL_17D0;
				case 186:
					goto IL_199F;
				case 187:
					goto IL_F26;
				case 188:
					goto IL_AC0;
				case 189:
					goto IL_18CB;
				case 190:
					goto IL_1866;
				case 191:
					goto IL_A4E;
				case 192:
					goto IL_1E0D;
				case 193:
					goto IL_CEB;
				case 194:
					goto IL_1AB7;
				case 195:
					goto IL_1157;
				case 196:
					goto IL_1E3E;
				case 197:
					goto IL_B53;
				case 198:
					goto IL_12E8;
				case 199:
					goto IL_1506;
				case 200:
					goto IL_A75;
				case 201:
					goto IL_60F;
				case 202:
					goto IL_205C;
				case 203:
					goto IL_B0B;
				case 204:
					goto IL_2113;
				case 205:
					goto IL_12DB;
				case 206:
					goto IL_18EF;
				case 207:
					goto IL_1CA2;
				case 208:
					goto IL_6B9;
				case 209:
					goto IL_E62;
				case 210:
					goto IL_1252;
				case 211:
					goto IL_9C2;
				case 212:
					goto IL_A34;
				case 213:
					goto IL_144F;
				case 214:
					goto IL_E24;
				case 215:
					goto IL_D46;
				case 216:
					goto IL_D6A;
				case 217:
					goto IL_1E6F;
				case 218:
					goto IL_1B07;
				case 219:
					goto IL_1694;
				case 220:
					goto IL_1FBC;
				case 221:
					goto IL_C24;
				case 222:
					goto IL_18A4;
				case 223:
					goto IL_1D46;
				case 224:
					goto IL_19ED;
				case 225:
					goto IL_1A38;
				case 226:
					goto IL_7D5;
				case 227:
					goto IL_20BE;
				case 228:
					goto IL_FE3;
				case 229:
					goto IL_E86;
				case 230:
					goto IL_1480;
				case 231:
					goto IL_C17;
				case 232:
					goto IL_1014;
				case 233:
					goto IL_EF5;
				case 234:
					goto IL_C0A;
				case 235:
					goto IL_10A0;
				case 236:
					goto IL_E55;
				case 237:
					goto IL_1DA8;
				case 238:
					goto IL_DA8;
				case 239:
					goto IL_671;
				case 240:
					goto IL_1947;
				case 241:
					goto IL_1A9D;
				case 242:
					goto IL_E17;
				case 243:
					goto IL_15F1;
				case 244:
					goto IL_F64;
				case 245:
					goto IL_602;
				case 246:
					goto IL_E93;
				case 247:
					goto IL_1F40;
				case 248:
					goto IL_1A83;
				case 249:
					goto IL_17A9;
				case 250:
					goto IL_14D5;
				case 251:
					goto IL_15E4;
				case 252:
					goto IL_1302;
				case 253:
					goto IL_C79;
				case 254:
					goto IL_DF0;
				case 255:
					goto IL_2106;
				case 256:
					goto IL_17B6;
				case 257:
					goto IL_13D3;
				case 258:
					goto IL_8C0;
				case 259:
					goto IL_1214;
				case 260:
					goto IL_1FED;
				case 261:
					goto IL_9E9;
				case 262:
					goto IL_A68;
				case 263:
					goto IL_1551;
				case 264:
					goto IL_1713;
				case 265:
					goto IL_1133;
				case 266:
					goto IL_1E89;
				case 267:
					goto IL_1775;
				case 268:
					goto IL_1E00;
				case 269:
					goto IL_1992;
				case 270:
					goto IL_1B90;
				case 271:
					goto IL_96D;
				case 272:
					goto IL_B2F;
				case 273:
					goto IL_1371;
				case 274:
					goto IL_16BB;
				case 275:
					goto IL_D39;
				case 276:
					goto IL_15FE;
				case 277:
					goto IL_D84;
				case 278:
					goto IL_797;
				case 279:
					goto IL_1357;
				case 280:
					goto IL_15A6;
				case 281:
					goto IL_1618;
				case 282:
					goto IL_640;
				case 283:
					goto IL_FF0;
				case 284:
					goto IL_16AE;
				case 285:
					goto IL_9DC;
				case 286:
					goto IL_813;
				case 287:
					goto IL_1404;
				case 288:
					goto IL_12CE;
				case 289:
					goto IL_1238;
				case 290:
					goto IL_9F6;
				case 291:
					goto IL_1A2B;
				case 292:
					goto IL_E48;
				case 293:
					goto IL_1AED;
				case 294:
					goto IL_17F7;
				case 295:
					goto IL_106C;
				case 296:
					goto IL_18B1;
				case 297:
					goto IL_8F1;
				case 298:
					goto IL_EB7;
				case 299:
					goto IL_A03;
				case 300:
					goto IL_1873;
				case 301:
					goto IL_1C19;
				case 302:
					goto IL_6EA;
				case 303:
					goto IL_20A4;
				case 304:
					goto IL_1F1C;
				case 305:
					goto IL_1DF3;
				case 306:
					goto IL_20B1;
				case 307:
					goto IL_18BE;
				case 308:
					goto IL_1D53;
				case 309:
					goto IL_AE4;
				case 310:
					goto IL_773;
				case 311:
					goto IL_1045;
				case 312:
					goto IL_946;
				case 313:
					goto IL_12A7;
				case 314:
					goto IL_695;
				case 315:
					goto IL_11A2;
				case 316:
					goto IL_2080;
				case 317:
					goto IL_1B2E;
				case 318:
					goto IL_202B;
				case 319:
					goto IL_F19;
				case 320:
					goto IL_110F;
				case 321:
					goto IL_10AD;
				case 322:
					goto IL_142B;
				case 323:
					goto IL_10BA;
				case 324:
					goto IL_1F0F;
				case 325:
					goto IL_1DE6;
				case 326:
					goto IL_1CE4;
				case 327:
					goto IL_19B9;
				case 328:
					goto IL_15B3;
				case 329:
					goto IL_1E7C;
				case 330:
					goto IL_178F;
				case 331:
					goto IL_12B4;
				case 332:
					goto IL_1D22;
				case 333:
					goto IL_1079;
				case 334:
					goto IL_1E1A;
				case 335:
					goto IL_1C0C;
				case 336:
					goto IL_70E;
				case 337:
					goto IL_16E2;
				case 338:
					goto IL_15D7;
				case 339:
					goto IL_193A;
				case 340:
					goto IL_13A2;
				case 341:
					goto IL_2038;
				case 342:
					goto IL_1880;
				case 343:
					goto IL_1411;
				case 344:
					goto IL_F8B;
				case 345:
					goto IL_1513;
				default:
					num = (short)1671036929;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_602:
			this.CVBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_60F:
			this.CVBtnSecWideFeaturesProperCodeEnhancer_A8764 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_61C:
			this.SecureWideAESAlgorithmEnable_43201 = (global::AcpUI.AcpCheckBox)target;
			this.SecureWideAESAlgorithmEnable_43201.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_640:
			this.ExpanderSecureWideEncryptionKeyList = (global::AcpUI.AcpExpander)target;
			return;
			IL_64D:
			this.LblSecureConfigurationSecureWide_A19833 = (global::AcpUI.AcpLabel)target;
			this.LblSecureConfigurationSecureWide_A19833.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_671:
			this.SecWideFeaturesXLScanUnsquelchDurationMs_A9682 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideFeaturesXLScanUnsquelchDurationMs_A9682.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_695:
			this.SecWideMultikeyListSlotA_A9155 = (global::AcpUI.AcpLabel)target;
			this.SecWideMultikeyListSlotA_A9155.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6B9:
			this.LblSecWideFeaturesPeriodicKeyfailAlertTone_A8695 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesPeriodicKeyfailAlertTone_A8695.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6DD:
			this.SecureWideDESAlgorithmEnable_43744Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6EA:
			this.SecWideMultikeyListCKR_A7665 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideMultikeyListCKR_A7665.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_70E:
			this.CpyBtnSecWideMultikeyListSelectableADPKeyID_A9107 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_71B:
			this.CpyBtnSecWideMDCOTARPowerUp_A8716 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_728:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_735:
			this.SecureWideADPAlgorithmEnable_43200 = (global::AcpUI.AcpCheckBox)target;
			this.SecureWideADPAlgorithmEnable_43200.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_759:
			this.RTDBtnSecWideMultikeyUserSelectable_A9604 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_766:
			this.CVBtnSecureWideDESAlgorithmEnable_43744 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_773:
			this.LblSecWideMultikeyListIndexed_A8282 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListIndexed_A8282.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_797:
			this.SecWideMultikeyTxHangTimeMs_A9540 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideMultikeyTxHangTimeMs_A9540.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7BB:
			this.SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_7C8:
			this.GrpBoxExpanderSecureWideMDCOTAROTARAcknowledgements = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7D5:
			this.LblSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F9:
			this.RTDBtnSecWideASTROOTARASTROOTAREnable_A7496 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_806:
			this.RTDBtnSecureWideAESAlgorithmEnable_43201 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_813:
			this.ExpanderSecureWideEncryptionKeyListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_820:
			this.SecWideGeneralEnhancedADPRadioInhibit_A41461 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideGeneralEnhancedADPRadioInhibit_A41461.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_844:
			this.RTDBtnSecureWideKeyloadingSource_43204 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_851:
			this.LblSecureWideKeyloadingSource_43204 = (global::AcpUI.AcpLabel)target;
			this.LblSecureWideKeyloadingSource_43204.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_875:
			this.RTDBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_882:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_88F:
			this.RTDBtnSecWideMDCOTARMode_A8533 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_89C:
			this.LblSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8C0:
			this.LblSecWideMultikeyDisplayOnModeChange_A7877 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyDisplayOnModeChange_A7877.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8E4:
			this.SecWideASTROOTARIndividualASTROOTARRadioID_A8284Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8F1:
			this.SecWideMultikeyListKeyName_A8362 = (global::AcpUI.AcpTextBox)target;
			this.SecWideMultikeyListKeyName_A8362.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_915:
			this.CpyBtnSecWideMultikeyUserSelectable_A9604 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_922:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_946:
			this.CpyBtnSecWideMultikeyListIndexed_A8282 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_953:
			this.GrpBoxExpanderSecureWideGeneralPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_960:
			this.GrpBoxExpanderSecureWideGeneralKeyset = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_96D:
			this.LblSecWideMultikeyRxHangTimems_A9019 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyRxHangTimems_A9019.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_991:
			this.GrpBoxExpanderSecureWideGeneralKeyListManagement = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_99E:
			this.SecWideMultikeyUserSelectable_A9604 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMultikeyUserSelectable_A9604.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9C2:
			this.CpyBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9CF:
			this.CpyBtnSecureWideAESAlgorithmEnable_43201 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9DC:
			this.ExpanderSecureWideEncryptionKeyListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9E9:
			this.CpyBtnSecWideMultikeyDisplayOnModeChange_A7877 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9F6:
			this.SecWideMultikeyListIndexed_A8282_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A03:
			this.LblSecWideMultikeyListKeyName_A8362 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListKeyName_A8362.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A27:
			this.CpyBtnSecWideMultikeyErasePreviousOnUserChange_A8373 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A34:
			this.SecWideFeaturesPeriodicKeyfailAlertTone_A8695Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A41:
			this.RTDBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A4E:
			this.CpyBtnSecWideMDCOTARMDCOTARSystem_A8490 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A5B:
			this.CpyBtnSecureConfigurationSecureWide_A19833 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A68:
			this.SecWideMultikeyDisplayOnModeChange_A7877Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A75:
			this.SecWideFeaturesInfiniteKeyRetention_A8292Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A82:
			this.SecWideMDCOTAREnable_A7967 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTAREnable_A7967.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AA6:
			this.RTDBtnSecWideMDCOTARMDCOTAREnable_A8488 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AB3:
			this.RTDBtnSecWideMDCOTAREnable_A7967 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AC0:
			this.LblSecWideMDCOTARMDCOTARSystem_A8490 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARMDCOTARSystem_A8490.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AE4:
			this.CVBtnSecWideMultikeyListIndexed_A8282 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AF1:
			this.GrpBoxExpanderSecureWideMDCOTARRekeyRequest = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AFE:
			this.CVBtnSecWideMDCOTAREncryptedOnly_A7971 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B0B:
			this.SecWideFeaturesProperCodeEnhancer_A8764 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideFeaturesProperCodeEnhancer_A8764.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B2F:
			this.SecWideMultikeyRxHangTimems_A9019 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideMultikeyRxHangTimems_A9019.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B53:
			this.SecWideFeaturesInfiniteKeyRetention_A8292 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideFeaturesInfiniteKeyRetention_A8292.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B77:
			this.CpyBtnSecureWideDESAlgorithmEnable_43744 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B84:
			this.SecWideInfiniteUKEKRetention_A41551 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideInfiniteUKEKRetention_A41551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA8:
			this.RTDBtnSecureConfigurationSecureWide_A19833 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB5:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_BD9:
			this.SecWideGeneralOTARGenerateKeyLossKey_A8169Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BE6:
			this.LblSecWideASTROOTARIndividualASTROOTARRadioID_A8284 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideASTROOTARIndividualASTROOTARRadioID_A8284.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C0A:
			this.RTDBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C17:
			this.CVBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C24:
			this.SecWideFeaturesClearAlertTones_A9524 = (global::AcpUI.AcpComboBox)target;
			this.SecWideFeaturesClearAlertTones_A9524.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C48:
			this.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_C55:
			this.SecWideMDCOTARErasePreviousIndexonIndexChange_A7976 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTARErasePreviousIndexonIndexChange_A7976.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C79:
			this.SecWideMultikeyDisplayOnPTT_A7879 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMultikeyDisplayOnPTT_A7879.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C9D:
			((global::Motorola.MackinawCPS.CoreFeatures.SecureWide.PageSecureWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.SecureWide.PageSecureWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_CE6:
			goto IL_2144;
			IL_CEB:
			this.ExpanderSecureWideFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_CF8:
			this.CVBtnSecWideMDCOTARPowerUp_A8716 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D05:
			this.CVBtnSecWideMDCOTAREnable_A7967 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D12:
			this.CpyBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D1F:
			this.SecWideMDCOTARPowerUp_A8716Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D2C:
			this.SecureConfigurationSecureWide_A19833Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D39:
			this.SecWideMultikeyRxHangTimems_A9019Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D46:
			this.SecWideFeaturesDisableHardKeyZeroize_A43046 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideFeaturesDisableHardKeyZeroize_A43046.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D6A:
			this.RTDBtnSecWideFeaturesDisableHardKeyZeroize_A43046 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D77:
			this.SecWideGeneralEnhancedADPRadioInhibit_A41461Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D84:
			this.LblSecWideMultikeyTxHangTimeMs_A9540 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyTxHangTimeMs_A9540.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DA8:
			this.LblSecWideFeaturesXLScanUnsquelchDurationMs_A9682 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesXLScanUnsquelchDurationMs_A9682.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DCC:
			this.SecWideMDCOTARKMCID_A8374 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.SecWideMDCOTARKMCID_A8374.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DF0:
			this.RTDBtnSecWideMultikeyDisplayOnPTT_A7879 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DFD:
			this.SecWideGeneralOTAREnable_A7966Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E0A:
			this.CpyBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E17:
			this.SecWideFeaturesXLScanUnsquelchDurationMs_A9682Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E24:
			this.LblSecWideFeaturesDisableHardKeyZeroize_A43046 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesDisableHardKeyZeroize_A43046.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E48:
			this.SecWideMultikeyListSlotB_A9158_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E55:
			this.SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E62:
			this.SecWideFeaturesPeriodicKeyfailAlertTone_A8695 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideFeaturesPeriodicKeyfailAlertTone_A8695.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E86:
			this.CpyBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E93:
			this.LblSecWideMultikeyDisplayOnSecureSwitchSelect_A7881 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyDisplayOnSecureSwitchSelect_A7881.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EB7:
			this.CVBtnSecWideMultikeyListKeyName_A8362 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EC4:
			this.SecWideGeneralSecureOperation_A9067 = (global::AcpUI.AcpComboBox)target;
			this.SecWideGeneralSecureOperation_A9067.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EE8:
			this.CVBtnSecWideGeneralEnhancedADPRadioInhibit_A41461 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EF5:
			this.SecWideFeaturesNonXLScanUnsquelchDurationms_A8570 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideFeaturesNonXLScanUnsquelchDurationms_A8570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F19:
			this.SecWideMultikeyListSlotA_A9155Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F26:
			this.CVBtnSecWideMDCOTARMDCOTARSystem_A8490 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F33:
			this.LblSecWideMDCOTARPowerUp_A8716 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARPowerUp_A8716.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F57:
			this.CVBtnSecWideKeyListMgmtEraseAllKeys_43648 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F64:
			this.GrpBoxExpanderSecureWideMultikeyPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F71:
			this.GrpBoxExpanderSecureWideMDCOTARPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F7E:
			this.RTDBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F8B:
			this.CpyBtnSecWideLabtoolPIDIndexMapping_A8279 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F98:
			this.CVBtnSecWideMDCOTARStatusAlertTone_A8489 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FA5:
			this.CVBtnSecWideGeneralOTAROperation_43700 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FB2:
			this.SecWideKeyListMgmtEraseAllKeys_43648 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideKeyListMgmtEraseAllKeys_43648.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FD6:
			this.CVBtnSecureConfigurationSecureWide_A19833 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FE3:
			this.RTDBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FF0:
			this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderSecureWideEncryptionKeyListTable.ModeClick += this.OnModeClick;
			return;
			IL_1014:
			this.LblSecWideFeaturesNonXLScanUnsquelchDurationms_A8570 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesNonXLScanUnsquelchDurationms_A8570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1038:
			this.RTDBtnSecWideMDCOTARKMCID_A8374 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1045:
			this.RTDBtnSecWideMultikeyListIndexed_A8282 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1052:
			this.CpyBtnSecureWideKeyloadingSource_43204 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_105F:
			this.RTDBtnSecWideMDCOTARStatusAlertTone_A8489 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_106C:
			this.ExpanderSecureWideEncryptionKeyListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1079:
			this.CVBtnSecWideMultikeyListSelectableADPKeyID_A9107 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1086:
			this.SecWideMDCOTARMDCOTAREnable_A8488Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1093:
			this.RTDBtnSecWideGeneralOTAREnable_A7966 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10A0:
			this.CpyBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10AD:
			this.CVBtnSecWideMultikeyListSlotB_A9158 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10BA:
			this.RTDBtnSecWideMultikeyListSlotB_A9158 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C7:
			this.SecWideASTROOTARIndividualASTROOTARRadioID_A8284 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10EB:
			this.LblSecWideMDCOTAREncryptedOnly_A7971 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTAREncryptedOnly_A7971.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_110F:
			this.SecWideMultikeyListSlotB_A9158 = (global::AcpUI.AcpLabel)target;
			this.SecWideMultikeyListSlotB_A9158.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1133:
			this.SecWideMultikeyPIDKeyManagementforASNMode_A8704 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMultikeyPIDKeyManagementforASNMode_A8704.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1157:
			this.CVBtnSecWideFeaturesInfiniteKeyRetention_A8292 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1164:
			this.LblSecWideGeneralOTAREnable_A7966 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideGeneralOTAREnable_A7966.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1188:
			this.CpyBtnSecWideGeneralOTARGenerateKeyLossKey_A8169 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1195:
			this.GrpBoxExpanderSecureWideMDCOTARPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_11A2:
			this.CVBtnSecWideMultikeyListSlotA_A9155 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11AF:
			this.RTDBtnSecWideGeneralSecureOperation_A9067 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11BC:
			this.CVBtnSecWideMultikeyUserSelectable_A9604 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11C9:
			this.RTDBtnSecureWideADPAlgorithmEnable_43200 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11D6:
			this.CVBtnSecWideInfiniteUKEKRetention_A41551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11E3:
			this.SecWideASTROOTARASTROOTAREnable_A7496 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideASTROOTARASTROOTAREnable_A7496.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1207:
			this.CpyBtnSecWideInfiniteUKEKRetention_A41551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1214:
			this.SecWideMultikeyDisplayOnModeChange_A7877 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMultikeyDisplayOnModeChange_A7877.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1238:
			this.SecWideMultikeyListCKR_A7665_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1245:
			this.RTDBtnSecWideGeneralEnhancedADPRadioInhibit_A41461 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1252:
			this.RTDBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_125F:
			this.SecWideMDCOTARMode_A8533 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMDCOTARMode_A8533.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1283:
			this.SecWideMultikeyErasePreviousOnUserChange_A8373 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMultikeyErasePreviousOnUserChange_A8373.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12A7:
			this.SecWideMultikeyListIndexed_A8282Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_12B4:
			this.SecWideMultikeyListSelectableADPKeyData_A9106Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12C1:
			this.RTDBtnSecWideInfiniteUKEKRetention_A41551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12CE:
			this.SecWideMultikeyListKeyName_A8362_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_12DB:
			this.CpyBtnSecWideFeaturesProperCodeEnhancer_A8764 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12E8:
			this.RTDBtnSecWideFeaturesInfiniteKeyRetention_A8292 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12F5:
			this.CpyBtnSecWideMDCOTARMode_A8533 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1302:
			this.LblSecWideMultikeyDisplayOnPTT_A7879 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyDisplayOnPTT_A7879.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1326:
			this.CVBtnSecWideMDCOTARKMCID_A8374 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1333:
			this.SecureWideKeyloadingSource_43204 = (global::AcpUI.AcpComboBox)target;
			this.SecureWideKeyloadingSource_43204.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1357:
			this.RTDBtnSecWideMultikeyTxHangTimeMs_A9540 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1364:
			this.RTDBtnSecWideMultikeyErasePreviousOnUserChange_A8373 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1371:
			this.RTDBtnSecWideMultikeyRxHangTimems_A9019 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_137E:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_13A2:
			this.CVBtnSecWideLabtoolPIDIndexMapping_A8279 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13AF:
			this.LblSecWideKeyListMgmtEraseAllKeys_43648 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideKeyListMgmtEraseAllKeys_43648.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13D3:
			this.CVBtnSecWideMultikeyDisplayOnModeChange_A7877 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13E0:
			this.LblSecWideMDCOTARErasePreviousIndexonIndexChange_A7976 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARErasePreviousIndexonIndexChange_A7976.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1404:
			this.ExpanderSecureWideEncryptionKeyListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1411:
			this.RTDBtnSecWideLabtoolPIDIndexMapping_A8279 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_141E:
			this.RTDBtnSecWideGeneralOTARGenerateKeyLossKey_A8169 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_142B:
			this.LblSecWideMultikeyListSlotB_A9158 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListSlotB_A9158.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_144F:
			this.CVBtnSecWideFeaturesDisableHardKeyZeroize_A43046 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_145C:
			this.LblSecWideMDCOTARMDCOTAREnable_A8488 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARMDCOTAREnable_A8488.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1480:
			this.SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_148D:
			this.SecureConfigurationSecureWide_A19833 = (global::AcpUI.AcpCheckBox)target;
			this.SecureConfigurationSecureWide_A19833.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14B1:
			this.LblSecWideMultikeyErasePreviousOnUserChange_A8373 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyErasePreviousOnUserChange_A8373.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14D5:
			this.SecWideMultikeyDisplayOnSecureSwitchSelect_A7881Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14E2:
			this.SecureWideDESAlgorithmEnable_43744 = (global::AcpUI.AcpCheckBox)target;
			this.SecureWideDESAlgorithmEnable_43744.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1506:
			this.CpyBtnSecWideFeaturesInfiniteKeyRetention_A8292 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1513:
			this.SecWideLabtoolPIDIndexMapping_A8279Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1520:
			this.SecWideGeneralSecureOperation_A9067Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_152D:
			this.SecWideMDCOTARPowerUp_A8716 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMDCOTARPowerUp_A8716.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1551:
			this.CVBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_155E:
			this.LblSecWideMDCOTARStatusAlertTone_A8489 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARStatusAlertTone_A8489.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1582:
			this.SecWideMDCOTARStatusAlertTone_A8489 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTARStatusAlertTone_A8489.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15A6:
			this.CpyBtnSecWideMultikeyTxHangTimeMs_A9540 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15B3:
			this.LblSecWideMultikeyListSelectableADPKeyData_A9106 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListSelectableADPKeyData_A9106.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15D7:
			this.ExpanderSecureWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_15E4:
			this.CVBtnSecWideMultikeyDisplayOnPTT_A7879 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15F1:
			this.ExpanderSecureWideMultikey = (global::AcpUI.AcpExpander)target;
			return;
			IL_15FE:
			this.CVBtnSecWideMultikeyTxHangTimeMs_A9540 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_160B:
			this.ExpanderSecureWideMDCOTAR = (global::AcpUI.AcpExpander)target;
			return;
			IL_1618:
			this.SecWideMultikeyTxHangTimeMs_A9540Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1625:
			this.RTDBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1632:
			this.HLinkEncryptionKeyList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEncryptionKeyList.Click += this.HLinkClick;
			return;
			IL_1656:
			this.CpyBtnSecWideASTROOTARASTROOTAREnable_A7496 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1663:
			this.ExpanderSecureWideASTROOTAR = (global::AcpUI.AcpExpander)target;
			return;
			IL_1670:
			this.LblSecWideGeneralOTARGenerateKeyLossKey_A8169 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideGeneralOTARGenerateKeyLossKey_A8169.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1694:
			this.CVBtnSecWideFeaturesClearAlertTones_A9524 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16A1:
			this.CpyBtnSecWideGeneralOTAROperation_43700 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16AE:
			this.ExpanderSecureWideEncryptionKeyListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_16BB:
			this.CpyBtnSecWideMultikeyRxHangTimems_A9019 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16C8:
			this.RTDBtnSecWideMDCOTARPowerUp_A8716 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16D5:
			this.GrpBoxExpanderSecureWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_16E2:
			this.SecWideMultikeyListSelectableADPKeyID_A9107Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16EF:
			this.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1713:
			this.LblSecWideMultikeyPIDKeyManagementforASNMode_A8704 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyPIDKeyManagementforASNMode_A8704.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1737:
			this.SecWideMultikeyUserSelectable_A9604Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1744:
			this.RTDBtnSecWideMDCOTAREncryptedOnly_A7971 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1751:
			this.SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1775:
			this.CpyBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1782:
			this.SecWideMDCOTARMode_A8533Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_178F:
			this.CpyBtnSecWideMultikeyListSelectableADPKeyData_A9106 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_179C:
			this.CVBtnSecureWideKeyloadingSource_43204 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17A9:
			this.CpyBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17B6:
			this.SecWideMultikeyDisplayOnPTT_A7879Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17C3:
			this.CVBtnSecWideGeneralSecureOperation_A9067 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17D0:
			this.CpyBtnSecWideMDCOTARKMCID_A8374 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17DD:
			this.SecWideMDCOTARStatusAlertTone_A8489Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_17EA:
			this.CpyBtnSecWideGeneralEnhancedADPRadioInhibit_A41461 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17F7:
			this.SecWideMultikeyListSelectableADPKeyID_A9107_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1804:
			this.LblSecWideMDCOTARKMCID_A8374 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARKMCID_A8374.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1828:
			this.SecWideGeneralOTAROperation_43700Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1835:
			this.LblSecWideGeneralEnhancedADPRadioInhibit_A41461 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideGeneralEnhancedADPRadioInhibit_A41461.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1859:
			this.CVBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1866:
			this.RTDBtnSecWideMDCOTARMDCOTARSystem_A8490 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1873:
			this.CpyBtnSecWideMultikeyListKeyName_A8362 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1880:
			this.SecWideLabtoolPIDIndexMapping_A8279 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecWideLabtoolPIDIndexMapping_A8279.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18A4:
			this.RTDBtnSecWideFeaturesClearAlertTones_A9524 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18B1:
			this.gridExpanderSecureWideEncryptionKeyListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_18BE:
			this.SecWideMultikeyListCKR_A7665Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18CB:
			this.SecWideMDCOTARMDCOTARSystem_A8490 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMDCOTARMDCOTARSystem_A8490.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18EF:
			this.SecWideFeaturesProperCodeEnhancer_A8764Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_18FC:
			this.SecWideMDCOTAREncryptedOnly_A7971Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1909:
			this.LblSecureWideADPAlgorithmEnable_43200 = (global::AcpUI.AcpLabel)target;
			this.LblSecureWideADPAlgorithmEnable_43200.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_192D:
			this.RTDBtnSecureWideDESAlgorithmEnable_43744 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_193A:
			this.GrpBoxExpanderSecureWideLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1947:
			this.RTDBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1954:
			this.LblSecWideMDCOTARMode_A8533 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARMode_A8533.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1978:
			this.SecWideInfiniteUKEKRetention_A41551Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1985:
			this.ExpanderSecureWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_1992:
			this.GrpBoxExpanderSecureWideMultikeyKeyID = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_199F:
			this.SecWideMDCOTARKMCID_A8374Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_19AC:
			this.GrpBoxExpanderSecureWideASTROOTARPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_19B9:
			this.CVBtnSecWideMultikeyListSelectableADPKeyData_A9106 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19C6:
			this.CpyBtnSecWideGeneralOTAREnable_A7966 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19D3:
			this.CpyBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19E0:
			this.SecWideMDCOTARErasePreviousIndexonIndexChange_A7976Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_19ED:
			this.SecWideFeaturesClearAlertTones_A9524Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19FA:
			this.LblSecureWideDESAlgorithmEnable_43744 = (global::AcpUI.AcpLabel)target;
			this.LblSecureWideDESAlgorithmEnable_43744.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A1E:
			this.CVBtnSecWideGeneralOTAREnable_A7966 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A2B:
			this.SecWideMultikeyListSlotA_A9155_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A38:
			this.CVBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A45:
			this.SecWideGeneralOTAREnable_A7966 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideGeneralOTAREnable_A7966.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A69:
			this.SecureWideAESAlgorithmEnable_43201Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1A76:
			this.CVBtnSecureWideAESAlgorithmEnable_43201 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A83:
			this.RTDBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A90:
			this.CVBtnSecWideGeneralOTARGenerateKeyLossKey_A8169 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A9D:
			this.CpyBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AAA:
			this.SecWideMDCOTAREnable_A7967Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1AB7:
			num = (short)606470144;
			short num4 = num;
			this.GrpBoxExpanderSecureWideFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1AED:
			this.SecWideMultikeyListSelectableADPKeyData_A9106_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1AFA:
			this.CVBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B07:
			this.SecWideFeaturesDisableHardKeyZeroize_A43046Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1B14:
			this.CpyBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B21:
			this.CVBtnSecWideMultikeyErasePreviousOnUserChange_A8373 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B2E:
			this.RTDBtnSecWideMultikeyListSlotA_A9155 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B3B:
			this.CpyBtnSecWideMDCOTAREnable_A7967 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B48:
			this.LblSecWideGeneralSecureOperation_A9067 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideGeneralSecureOperation_A9067.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B6C:
			this.LblSecWideMDCOTAREnable_A7967 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTAREnable_A7967.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B90:
			this.CVBtnSecWideMultikeyRxHangTimems_A9019 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B9D:
			this.SecWideASTROOTARASTROOTAREnable_A7496Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BAA:
			this.HLinkMDCOTAR = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMDCOTAR.Click += this.HLinkClick;
			return;
			IL_1BCE:
			this.CVBtnSecWideMDCOTARMDCOTAREnable_A8488 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BDB:
			this.SecureWideADPAlgorithmEnable_43200Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BE8:
			this.HLinkMultikey = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMultikey.Click += this.HLinkClick;
			return;
			IL_1C0C:
			this.RTDBtnSecWideMultikeyListSelectableADPKeyID_A9107 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C19:
			this.SecWideMultikeyListKeyName_A8362Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C26:
			this.SecWideMDCOTARMDCOTAREnable_A8488 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTARMDCOTAREnable_A8488.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C4A:
			this.CpyBtnSecWideGeneralSecureOperation_A9067 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C57:
			this.CpyBtnSecWideKeyListMgmtEraseAllKeys_43648 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C64:
			this.SecureWideKeyloadingSource_43204Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C71:
			this.CVBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C7E:
			this.LblSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CA2:
			num = (short)1158348801;
			if (num != 0)
			{
			}
			this.CVBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CD7:
			this.RTDBtnSecWideGeneralOTAROperation_43700 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CE4:
			this.SecWideMultikeyListSelectableADPKeyData_A9106 = (global::AcpUI.AcpTextBox)target;
			this.SecWideMultikeyListSelectableADPKeyData_A9106.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D08:
			this.CVBtnSecWideASTROOTARASTROOTAREnable_A7496 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D15:
			this.SecWideMultikeyErasePreviousOnUserChange_A8373Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1D22:
			this.SecWideMultikeyListSelectableADPKeyID_A9107 = (global::AcpUI.AcpTextBox)target;
			this.SecWideMultikeyListSelectableADPKeyID_A9107.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D46:
			this.CpyBtnSecWideFeaturesClearAlertTones_A9524 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D53:
			this.SecWideMultikeyListIndexed_A8282 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMultikeyListIndexed_A8282.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D77:
			this.HLinkASTROOTAR = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROOTAR.Click += this.HLinkClick;
			return;
			IL_1D9B:
			this.RTDBtnSecWideKeyListMgmtEraseAllKeys_43648 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DA8:
			this.CVBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DB5:
			this.CVBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DC2:
			this.LblSecureWideAESAlgorithmEnable_43201 = (global::AcpUI.AcpLabel)target;
			this.LblSecureWideAESAlgorithmEnable_43201.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DE6:
			this.SecWideMultikeyListSlotB_A9158Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DF3:
			this.RTDBtnSecWideMultikeyListCKR_A7665 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E00:
			this.SecWideMultikeyPIDKeyManagementforASNMode_A8704Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1E0D:
			this.SecWideMDCOTARMDCOTARSystem_A8490Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E1A:
			this.LblSecWideMultikeyListSelectableADPKeyID_A9107 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListSelectableADPKeyID_A9107.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E3E:
			this.LblSecWideFeaturesInfiniteKeyRetention_A8292 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesInfiniteKeyRetention_A8292.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E62:
			this.GrpBoxExpanderSecureWideGeneralSecureAlgorithms = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E6F:
			this.CpyBtnSecWideFeaturesDisableHardKeyZeroize_A43046 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E7C:
			this.RTDBtnSecWideMultikeyListSelectableADPKeyData_A9106 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E89:
			this.RTDBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E96:
			this.LblSecWideASTROOTARASTROOTAREnable_A7496 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideASTROOTARASTROOTAREnable_A7496.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EBA:
			this.SecWideGeneralOTAROperation_43700 = (global::AcpUI.AcpComboBox)target;
			this.SecWideGeneralOTAROperation_43700.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EDE:
			this.CpyBtnSecWideMDCOTARMDCOTAREnable_A8488 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EEB:
			this.SecWideMDCOTAREncryptedOnly_A7971 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideMDCOTAREncryptedOnly_A7971.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F0F:
			this.CpyBtnSecWideMultikeyListSlotB_A9158 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F1C:
			this.LblSecWideMultikeyListCKR_A7665 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListCKR_A7665.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F40:
			this.SecWideMultikeyDisplayOnSecureSwitchSelect_A7881 = (global::AcpUI.AcpComboBox)target;
			this.SecWideMultikeyDisplayOnSecureSwitchSelect_A7881.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F64:
			this.CpyBtnSecWideMDCOTAREncryptedOnly_A7971 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F71:
			this.CVBtnSecureWideADPAlgorithmEnable_43200 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F7E:
			this.CpyBtnSecWideMDCOTARStatusAlertTone_A8489 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F8B:
			this.SecWideGeneralOTARGenerateKeyLossKey_A8169 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideGeneralOTARGenerateKeyLossKey_A8169.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1FAF:
			this.SecWideKeyListMgmtEraseAllKeys_43648Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1FBC:
			this.LblSecWideFeaturesClearAlertTones_A9524 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesClearAlertTones_A9524.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FE0:
			this.CVBtnSecWideMDCOTARMode_A8533 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FED:
			this.RTDBtnSecWideMultikeyDisplayOnModeChange_A7877 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FFA:
			this.CpyBtnSecureWideADPAlgorithmEnable_43200 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2007:
			this.LblSecWideInfiniteUKEKRetention_A41551 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideInfiniteUKEKRetention_A41551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_202B:
			this.CpyBtnSecWideMultikeyListSlotA_A9155 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2038:
			this.LblSecWideLabtoolPIDIndexMapping_A8279 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideLabtoolPIDIndexMapping_A8279.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_205C:
			this.LblSecWideFeaturesProperCodeEnhancer_A8764 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideFeaturesProperCodeEnhancer_A8764.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2080:
			this.LblSecWideMultikeyListSlotA_A9155 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyListSlotA_A9155.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20A4:
			this.CVBtnSecWideMultikeyListCKR_A7665 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20B1:
			this.CpyBtnSecWideMultikeyListCKR_A7665 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_20BE:
			this.SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = (global::AcpUI.AcpCheckBox)target;
			this.SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20E2:
			this.LblSecWideGeneralOTAROperation_43700 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideGeneralOTAROperation_43700.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2106:
			this.CpyBtnSecWideMultikeyDisplayOnPTT_A7879 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2113:
			this.RTDBtnSecWideFeaturesProperCodeEnhancer_A8764 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2120:
			this.LblSecWideMultikeyUserSelectable_A9604 = (global::AcpUI.AcpLabel)target;
			this.LblSecWideMultikeyUserSelectable_A9604.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2144:
			this.b = true;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x002240DC File Offset: 0x002222DC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
			{
				short num = (short)797939976;
				short num2 = num;
				num = (short)753637640;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1394933760;
					if (num != 0)
					{
					}
					num = (short)1047134208;
					short num3 = num;
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 3:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				break;
			case 7:
			{
				short num = (short)86704129;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 8:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000BE4 RID: 3044
		private bool a;

		// Token: 0x04000BE5 RID: 3045
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000BE6 RID: 3046
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000BE7 RID: 3047
		internal global::System.Windows.Documents.Hyperlink HLinkASTROOTAR;

		// Token: 0x04000BE8 RID: 3048
		internal global::System.Windows.Documents.Hyperlink HLinkMDCOTAR;

		// Token: 0x04000BE9 RID: 3049
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x04000BEA RID: 3050
		internal global::System.Windows.Documents.Hyperlink HLinkMultikey;

		// Token: 0x04000BEB RID: 3051
		internal global::System.Windows.Documents.Hyperlink HLinkEncryptionKeyList;

		// Token: 0x04000BEC RID: 3052
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000BED RID: 3053
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000BEE RID: 3054
		internal global::AcpUI.AcpExpander ExpanderSecureWideGeneral;

		// Token: 0x04000BEF RID: 3055
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideGeneralPseudo0;

		// Token: 0x04000BF0 RID: 3056
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideGeneralSecureOperation_A9067;

		// Token: 0x04000BF1 RID: 3057
		internal global::AcpUI.AcpLabel LblSecWideGeneralSecureOperation_A9067;

		// Token: 0x04000BF2 RID: 3058
		internal global::AcpUI.AcpComboBox SecWideGeneralSecureOperation_A9067;

		// Token: 0x04000BF3 RID: 3059
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideGeneralSecureOperation_A9067;

		// Token: 0x04000BF4 RID: 3060
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideGeneralSecureOperation_A9067;

		// Token: 0x04000BF5 RID: 3061
		internal global::AcpUI.AcpLabel SecWideGeneralSecureOperation_A9067Comp;

		// Token: 0x04000BF6 RID: 3062
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideGeneralOTAROperation_43700;

		// Token: 0x04000BF7 RID: 3063
		internal global::AcpUI.AcpLabel LblSecWideGeneralOTAROperation_43700;

		// Token: 0x04000BF8 RID: 3064
		internal global::AcpUI.AcpComboBox SecWideGeneralOTAROperation_43700;

		// Token: 0x04000BF9 RID: 3065
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideGeneralOTAROperation_43700;

		// Token: 0x04000BFA RID: 3066
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideGeneralOTAROperation_43700;

		// Token: 0x04000BFB RID: 3067
		internal global::AcpUI.AcpLabel SecWideGeneralOTAROperation_43700Comp;

		// Token: 0x04000BFC RID: 3068
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideGeneralKeyListManagement;

		// Token: 0x04000BFD RID: 3069
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideKeyListMgmtEraseAllKeys_43648;

		// Token: 0x04000BFE RID: 3070
		internal global::AcpUI.AcpLabel LblSecWideKeyListMgmtEraseAllKeys_43648;

		// Token: 0x04000BFF RID: 3071
		internal global::AcpUI.AcpCheckBox SecWideKeyListMgmtEraseAllKeys_43648;

		// Token: 0x04000C00 RID: 3072
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideKeyListMgmtEraseAllKeys_43648;

		// Token: 0x04000C01 RID: 3073
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideKeyListMgmtEraseAllKeys_43648;

		// Token: 0x04000C02 RID: 3074
		internal global::AcpUI.AcpCheckBox SecWideKeyListMgmtEraseAllKeys_43648Comp;

		// Token: 0x04000C03 RID: 3075
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000C04 RID: 3076
		internal global::AcpUI.AcpLabel LblSecWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000C05 RID: 3077
		internal global::AcpUI.AcpCheckBox SecWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000C06 RID: 3078
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000C07 RID: 3079
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000C08 RID: 3080
		internal global::AcpUI.AcpCheckBox SecWideInfiniteUKEKRetention_A41551Comp;

		// Token: 0x04000C09 RID: 3081
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000C0A RID: 3082
		internal global::AcpUI.AcpLabel LblSecWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000C0B RID: 3083
		internal global::AcpUI.AcpCheckBox SecWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000C0C RID: 3084
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000C0D RID: 3085
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000C0E RID: 3086
		internal global::AcpUI.AcpCheckBox SecWideGeneralOTARGenerateKeyLossKey_A8169Comp;

		// Token: 0x04000C0F RID: 3087
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecureConfigurationSecureWide_A19833;

		// Token: 0x04000C10 RID: 3088
		internal global::AcpUI.AcpLabel LblSecureConfigurationSecureWide_A19833;

		// Token: 0x04000C11 RID: 3089
		internal global::AcpUI.AcpCheckBox SecureConfigurationSecureWide_A19833;

		// Token: 0x04000C12 RID: 3090
		internal global::AcpUI.AcpRtdButton RTDBtnSecureConfigurationSecureWide_A19833;

		// Token: 0x04000C13 RID: 3091
		internal global::AcpUI.AcpCopyButton CpyBtnSecureConfigurationSecureWide_A19833;

		// Token: 0x04000C14 RID: 3092
		internal global::AcpUI.AcpCheckBox SecureConfigurationSecureWide_A19833Comp;

		// Token: 0x04000C15 RID: 3093
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideGeneralKeyset;

		// Token: 0x04000C16 RID: 3094
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyUserSelectable_A9604;

		// Token: 0x04000C17 RID: 3095
		internal global::AcpUI.AcpLabel LblSecWideMultikeyUserSelectable_A9604;

		// Token: 0x04000C18 RID: 3096
		internal global::AcpUI.AcpCheckBox SecWideMultikeyUserSelectable_A9604;

		// Token: 0x04000C19 RID: 3097
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyUserSelectable_A9604;

		// Token: 0x04000C1A RID: 3098
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyUserSelectable_A9604;

		// Token: 0x04000C1B RID: 3099
		internal global::AcpUI.AcpCheckBox SecWideMultikeyUserSelectable_A9604Comp;

		// Token: 0x04000C1C RID: 3100
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000C1D RID: 3101
		internal global::AcpUI.AcpLabel LblSecWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000C1E RID: 3102
		internal global::AcpUI.AcpCheckBox SecWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000C1F RID: 3103
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000C20 RID: 3104
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000C21 RID: 3105
		internal global::AcpUI.AcpCheckBox SecWideMultikeyErasePreviousOnUserChange_A8373Comp;

		// Token: 0x04000C22 RID: 3106
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideGeneralSecureAlgorithms;

		// Token: 0x04000C23 RID: 3107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecureWideADPAlgorithmEnable_43200;

		// Token: 0x04000C24 RID: 3108
		internal global::AcpUI.AcpLabel LblSecureWideADPAlgorithmEnable_43200;

		// Token: 0x04000C25 RID: 3109
		internal global::AcpUI.AcpCheckBox SecureWideADPAlgorithmEnable_43200;

		// Token: 0x04000C26 RID: 3110
		internal global::AcpUI.AcpRtdButton RTDBtnSecureWideADPAlgorithmEnable_43200;

		// Token: 0x04000C27 RID: 3111
		internal global::AcpUI.AcpCopyButton CpyBtnSecureWideADPAlgorithmEnable_43200;

		// Token: 0x04000C28 RID: 3112
		internal global::AcpUI.AcpCheckBox SecureWideADPAlgorithmEnable_43200Comp;

		// Token: 0x04000C29 RID: 3113
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecureWideAESAlgorithmEnable_43201;

		// Token: 0x04000C2A RID: 3114
		internal global::AcpUI.AcpLabel LblSecureWideAESAlgorithmEnable_43201;

		// Token: 0x04000C2B RID: 3115
		internal global::AcpUI.AcpCheckBox SecureWideAESAlgorithmEnable_43201;

		// Token: 0x04000C2C RID: 3116
		internal global::AcpUI.AcpRtdButton RTDBtnSecureWideAESAlgorithmEnable_43201;

		// Token: 0x04000C2D RID: 3117
		internal global::AcpUI.AcpCopyButton CpyBtnSecureWideAESAlgorithmEnable_43201;

		// Token: 0x04000C2E RID: 3118
		internal global::AcpUI.AcpCheckBox SecureWideAESAlgorithmEnable_43201Comp;

		// Token: 0x04000C2F RID: 3119
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecureWideDESAlgorithmEnable_43744;

		// Token: 0x04000C30 RID: 3120
		internal global::AcpUI.AcpLabel LblSecureWideDESAlgorithmEnable_43744;

		// Token: 0x04000C31 RID: 3121
		internal global::AcpUI.AcpCheckBox SecureWideDESAlgorithmEnable_43744;

		// Token: 0x04000C32 RID: 3122
		internal global::AcpUI.AcpRtdButton RTDBtnSecureWideDESAlgorithmEnable_43744;

		// Token: 0x04000C33 RID: 3123
		internal global::AcpUI.AcpCopyButton CpyBtnSecureWideDESAlgorithmEnable_43744;

		// Token: 0x04000C34 RID: 3124
		internal global::AcpUI.AcpCheckBox SecureWideDESAlgorithmEnable_43744Comp;

		// Token: 0x04000C35 RID: 3125
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideGeneralPseudo3;

		// Token: 0x04000C36 RID: 3126
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecureWideKeyloadingSource_43204;

		// Token: 0x04000C37 RID: 3127
		internal global::AcpUI.AcpLabel LblSecureWideKeyloadingSource_43204;

		// Token: 0x04000C38 RID: 3128
		internal global::AcpUI.AcpComboBox SecureWideKeyloadingSource_43204;

		// Token: 0x04000C39 RID: 3129
		internal global::AcpUI.AcpRtdButton RTDBtnSecureWideKeyloadingSource_43204;

		// Token: 0x04000C3A RID: 3130
		internal global::AcpUI.AcpCopyButton CpyBtnSecureWideKeyloadingSource_43204;

		// Token: 0x04000C3B RID: 3131
		internal global::AcpUI.AcpLabel SecureWideKeyloadingSource_43204Comp;

		// Token: 0x04000C3C RID: 3132
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideGeneralOTAREnable_A7966;

		// Token: 0x04000C3D RID: 3133
		internal global::AcpUI.AcpLabel LblSecWideGeneralOTAREnable_A7966;

		// Token: 0x04000C3E RID: 3134
		internal global::AcpUI.AcpCheckBox SecWideGeneralOTAREnable_A7966;

		// Token: 0x04000C3F RID: 3135
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideGeneralOTAREnable_A7966;

		// Token: 0x04000C40 RID: 3136
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideGeneralOTAREnable_A7966;

		// Token: 0x04000C41 RID: 3137
		internal global::AcpUI.AcpCheckBox SecWideGeneralOTAREnable_A7966Comp;

		// Token: 0x04000C42 RID: 3138
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000C43 RID: 3139
		internal global::AcpUI.AcpLabel LblSecWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000C44 RID: 3140
		internal global::AcpUI.AcpCheckBox SecWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000C45 RID: 3141
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000C46 RID: 3142
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000C47 RID: 3143
		internal global::AcpUI.AcpCheckBox SecWideGeneralEnhancedADPRadioInhibit_A41461Comp;

		// Token: 0x04000C48 RID: 3144
		internal global::AcpUI.AcpExpander ExpanderSecureWideASTROOTAR;

		// Token: 0x04000C49 RID: 3145
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideASTROOTARPseudo0;

		// Token: 0x04000C4A RID: 3146
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000C4B RID: 3147
		internal global::AcpUI.AcpLabel LblSecWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000C4C RID: 3148
		internal global::AcpUI.AcpCheckBox SecWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000C4D RID: 3149
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000C4E RID: 3150
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000C4F RID: 3151
		internal global::AcpUI.AcpCheckBox SecWideASTROOTARASTROOTAREnable_A7496Comp;

		// Token: 0x04000C50 RID: 3152
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000C51 RID: 3153
		internal global::AcpUI.AcpLabel LblSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000C52 RID: 3154
		internal global::AcpUI.AcpCheckBox SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000C53 RID: 3155
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000C54 RID: 3156
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000C55 RID: 3157
		internal global::AcpUI.AcpCheckBox SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834Comp;

		// Token: 0x04000C56 RID: 3158
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284;

		// Token: 0x04000C57 RID: 3159
		internal global::AcpUI.AcpLabel LblSecWideASTROOTARIndividualASTROOTARRadioID_A8284;

		// Token: 0x04000C58 RID: 3160
		internal global::AcpUI.AcpTextBoxSpinner SecWideASTROOTARIndividualASTROOTARRadioID_A8284;

		// Token: 0x04000C59 RID: 3161
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284;

		// Token: 0x04000C5A RID: 3162
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideASTROOTARIndividualASTROOTARRadioID_A8284;

		// Token: 0x04000C5B RID: 3163
		internal global::AcpUI.AcpLabel SecWideASTROOTARIndividualASTROOTARRadioID_A8284Comp;

		// Token: 0x04000C5C RID: 3164
		internal global::AcpUI.AcpExpander ExpanderSecureWideMDCOTAR;

		// Token: 0x04000C5D RID: 3165
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMDCOTARPseudo0;

		// Token: 0x04000C5E RID: 3166
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000C5F RID: 3167
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000C60 RID: 3168
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000C61 RID: 3169
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000C62 RID: 3170
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000C63 RID: 3171
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARMDCOTAREnable_A8488Comp;

		// Token: 0x04000C64 RID: 3172
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835;

		// Token: 0x04000C65 RID: 3173
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835;

		// Token: 0x04000C66 RID: 3174
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835;

		// Token: 0x04000C67 RID: 3175
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835;

		// Token: 0x04000C68 RID: 3176
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARRadioInhibitviaMDCOTAR_A8835;

		// Token: 0x04000C69 RID: 3177
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835Comp;

		// Token: 0x04000C6A RID: 3178
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMDCOTAROTARAcknowledgements;

		// Token: 0x04000C6B RID: 3179
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTAREnable_A7967;

		// Token: 0x04000C6C RID: 3180
		internal global::AcpUI.AcpLabel LblSecWideMDCOTAREnable_A7967;

		// Token: 0x04000C6D RID: 3181
		internal global::AcpUI.AcpCheckBox SecWideMDCOTAREnable_A7967;

		// Token: 0x04000C6E RID: 3182
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTAREnable_A7967;

		// Token: 0x04000C6F RID: 3183
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTAREnable_A7967;

		// Token: 0x04000C70 RID: 3184
		internal global::AcpUI.AcpCheckBox SecWideMDCOTAREnable_A7967Comp;

		// Token: 0x04000C71 RID: 3185
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000C72 RID: 3186
		internal global::AcpUI.AcpLabel LblSecWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000C73 RID: 3187
		internal global::AcpUI.AcpCheckBox SecWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000C74 RID: 3188
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000C75 RID: 3189
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000C76 RID: 3190
		internal global::AcpUI.AcpCheckBox SecWideMDCOTAREncryptedOnly_A7971Comp;

		// Token: 0x04000C77 RID: 3191
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARPowerUp_A8716;

		// Token: 0x04000C78 RID: 3192
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARPowerUp_A8716;

		// Token: 0x04000C79 RID: 3193
		internal global::AcpUI.AcpComboBox SecWideMDCOTARPowerUp_A8716;

		// Token: 0x04000C7A RID: 3194
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARPowerUp_A8716;

		// Token: 0x04000C7B RID: 3195
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARPowerUp_A8716;

		// Token: 0x04000C7C RID: 3196
		internal global::AcpUI.AcpLabel SecWideMDCOTARPowerUp_A8716Comp;

		// Token: 0x04000C7D RID: 3197
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMDCOTARRekeyRequest;

		// Token: 0x04000C7E RID: 3198
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARMode_A8533;

		// Token: 0x04000C7F RID: 3199
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARMode_A8533;

		// Token: 0x04000C80 RID: 3200
		internal global::AcpUI.AcpComboBox SecWideMDCOTARMode_A8533;

		// Token: 0x04000C81 RID: 3201
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARMode_A8533;

		// Token: 0x04000C82 RID: 3202
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARMode_A8533;

		// Token: 0x04000C83 RID: 3203
		internal global::AcpUI.AcpLabel SecWideMDCOTARMode_A8533Comp;

		// Token: 0x04000C84 RID: 3204
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000C85 RID: 3205
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000C86 RID: 3206
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000C87 RID: 3207
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000C88 RID: 3208
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000C89 RID: 3209
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARStatusAlertTone_A8489Comp;

		// Token: 0x04000C8A RID: 3210
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMDCOTARPseudo2;

		// Token: 0x04000C8B RID: 3211
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000C8C RID: 3212
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000C8D RID: 3213
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000C8E RID: 3214
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000C8F RID: 3215
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000C90 RID: 3216
		internal global::AcpUI.AcpCheckBox SecWideMDCOTARErasePreviousIndexonIndexChange_A7976Comp;

		// Token: 0x04000C91 RID: 3217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARKMCID_A8374;

		// Token: 0x04000C92 RID: 3218
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARKMCID_A8374;

		// Token: 0x04000C93 RID: 3219
		internal global::AcpUI.AcpTextBoxSpinnerDecHex SecWideMDCOTARKMCID_A8374;

		// Token: 0x04000C94 RID: 3220
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARKMCID_A8374;

		// Token: 0x04000C95 RID: 3221
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARKMCID_A8374;

		// Token: 0x04000C96 RID: 3222
		internal global::AcpUI.AcpTextBoxDecHex SecWideMDCOTARKMCID_A8374Comp;

		// Token: 0x04000C97 RID: 3223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000C98 RID: 3224
		internal global::AcpUI.AcpLabel LblSecWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000C99 RID: 3225
		internal global::AcpUI.AcpComboBox SecWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000C9A RID: 3226
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000C9B RID: 3227
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000C9C RID: 3228
		internal global::AcpUI.AcpLabel SecWideMDCOTARMDCOTARSystem_A8490Comp;

		// Token: 0x04000C9D RID: 3229
		internal global::AcpUI.AcpExpander ExpanderSecureWideFeatures;

		// Token: 0x04000C9E RID: 3230
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideFeaturesPseudo0;

		// Token: 0x04000C9F RID: 3231
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000CA0 RID: 3232
		internal global::AcpUI.AcpLabel LblSecWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000CA1 RID: 3233
		internal global::AcpUI.AcpCheckBox SecWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000CA2 RID: 3234
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000CA3 RID: 3235
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000CA4 RID: 3236
		internal global::AcpUI.AcpCheckBox SecWideFeaturesInfiniteKeyRetention_A8292Comp;

		// Token: 0x04000CA5 RID: 3237
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000CA6 RID: 3238
		internal global::AcpUI.AcpLabel LblSecWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000CA7 RID: 3239
		internal global::AcpUI.AcpCheckBox SecWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000CA8 RID: 3240
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000CA9 RID: 3241
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000CAA RID: 3242
		internal global::AcpUI.AcpCheckBox SecWideFeaturesProperCodeEnhancer_A8764Comp;

		// Token: 0x04000CAB RID: 3243
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000CAC RID: 3244
		internal global::AcpUI.AcpLabel LblSecWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000CAD RID: 3245
		internal global::AcpUI.AcpCheckBox SecWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000CAE RID: 3246
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000CAF RID: 3247
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000CB0 RID: 3248
		internal global::AcpUI.AcpCheckBox SecWideFeaturesPeriodicKeyfailAlertTone_A8695Comp;

		// Token: 0x04000CB1 RID: 3249
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesDisableHardKeyZeroize_A43046;

		// Token: 0x04000CB2 RID: 3250
		internal global::AcpUI.AcpLabel LblSecWideFeaturesDisableHardKeyZeroize_A43046;

		// Token: 0x04000CB3 RID: 3251
		internal global::AcpUI.AcpCheckBox SecWideFeaturesDisableHardKeyZeroize_A43046;

		// Token: 0x04000CB4 RID: 3252
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesDisableHardKeyZeroize_A43046;

		// Token: 0x04000CB5 RID: 3253
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesDisableHardKeyZeroize_A43046;

		// Token: 0x04000CB6 RID: 3254
		internal global::AcpUI.AcpCheckBox SecWideFeaturesDisableHardKeyZeroize_A43046Comp;

		// Token: 0x04000CB7 RID: 3255
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000CB8 RID: 3256
		internal global::AcpUI.AcpLabel LblSecWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000CB9 RID: 3257
		internal global::AcpUI.AcpComboBox SecWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000CBA RID: 3258
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000CBB RID: 3259
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000CBC RID: 3260
		internal global::AcpUI.AcpLabel SecWideFeaturesClearAlertTones_A9524Comp;

		// Token: 0x04000CBD RID: 3261
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000CBE RID: 3262
		internal global::AcpUI.AcpLabel LblSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000CBF RID: 3263
		internal global::AcpUI.AcpCheckBox SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000CC0 RID: 3264
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000CC1 RID: 3265
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000CC2 RID: 3266
		internal global::AcpUI.AcpCheckBox SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238Comp;

		// Token: 0x04000CC3 RID: 3267
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000CC4 RID: 3268
		internal global::AcpUI.AcpLabel LblSecWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000CC5 RID: 3269
		internal global::AcpUI.AcpTextBoxSpinner SecWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000CC6 RID: 3270
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000CC7 RID: 3271
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000CC8 RID: 3272
		internal global::AcpUI.AcpLabel SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Comp;

		// Token: 0x04000CC9 RID: 3273
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000CCA RID: 3274
		internal global::AcpUI.AcpLabel LblSecWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000CCB RID: 3275
		internal global::AcpUI.AcpTextBoxSpinner SecWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000CCC RID: 3276
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000CCD RID: 3277
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000CCE RID: 3278
		internal global::AcpUI.AcpLabel SecWideFeaturesXLScanUnsquelchDurationMs_A9682Comp;

		// Token: 0x04000CCF RID: 3279
		internal global::AcpUI.AcpExpander ExpanderSecureWideMultikey;

		// Token: 0x04000CD0 RID: 3280
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMultikeyPseudo0;

		// Token: 0x04000CD1 RID: 3281
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000CD2 RID: 3282
		internal global::AcpUI.AcpLabel LblSecWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000CD3 RID: 3283
		internal global::AcpUI.AcpComboBox SecWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000CD4 RID: 3284
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000CD5 RID: 3285
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000CD6 RID: 3286
		internal global::AcpUI.AcpLabel SecWideMultikeyDisplayOnSecureSwitchSelect_A7881Comp;

		// Token: 0x04000CD7 RID: 3287
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000CD8 RID: 3288
		internal global::AcpUI.AcpLabel LblSecWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000CD9 RID: 3289
		internal global::AcpUI.AcpComboBox SecWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000CDA RID: 3290
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000CDB RID: 3291
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000CDC RID: 3292
		internal global::AcpUI.AcpLabel SecWideMultikeyDisplayOnPTT_A7879Comp;

		// Token: 0x04000CDD RID: 3293
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000CDE RID: 3294
		internal global::AcpUI.AcpLabel LblSecWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000CDF RID: 3295
		internal global::AcpUI.AcpComboBox SecWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000CE0 RID: 3296
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000CE1 RID: 3297
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000CE2 RID: 3298
		internal global::AcpUI.AcpLabel SecWideMultikeyDisplayOnModeChange_A7877Comp;

		// Token: 0x04000CE3 RID: 3299
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000CE4 RID: 3300
		internal global::AcpUI.AcpLabel LblSecWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000CE5 RID: 3301
		internal global::AcpUI.AcpCheckBox SecWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000CE6 RID: 3302
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000CE7 RID: 3303
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000CE8 RID: 3304
		internal global::AcpUI.AcpCheckBox SecWideMultikeyPIDKeyManagementforASNMode_A8704Comp;

		// Token: 0x04000CE9 RID: 3305
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideMultikeyKeyID;

		// Token: 0x04000CEA RID: 3306
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000CEB RID: 3307
		internal global::AcpUI.AcpLabel LblSecWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000CEC RID: 3308
		internal global::AcpUI.AcpTextBoxSpinner SecWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000CED RID: 3309
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000CEE RID: 3310
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000CEF RID: 3311
		internal global::AcpUI.AcpLabel SecWideMultikeyRxHangTimems_A9019Comp;

		// Token: 0x04000CF0 RID: 3312
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000CF1 RID: 3313
		internal global::AcpUI.AcpLabel LblSecWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000CF2 RID: 3314
		internal global::AcpUI.AcpTextBoxSpinner SecWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000CF3 RID: 3315
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000CF4 RID: 3316
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000CF5 RID: 3317
		internal global::AcpUI.AcpLabel SecWideMultikeyTxHangTimeMs_A9540Comp;

		// Token: 0x04000CF6 RID: 3318
		internal global::AcpUI.AcpExpander ExpanderSecureWideEncryptionKeyList;

		// Token: 0x04000CF7 RID: 3319
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderSecureWideEncryptionKeyListTable;

		// Token: 0x04000CF8 RID: 3320
		internal global::System.Windows.Controls.Grid ExpanderSecureWideEncryptionKeyListGrid;

		// Token: 0x04000CF9 RID: 3321
		internal global::System.Windows.Controls.Grid ExpanderSecureWideEncryptionKeyListTableGrid;

		// Token: 0x04000CFA RID: 3322
		internal global::AcpUI.AcpGroupBox ExpanderSecureWideEncryptionKeyListTableTableView;

		// Token: 0x04000CFB RID: 3323
		internal global::AcpUI.AcpXamDataPresenter ExpanderSecureWideEncryptionKeyListTable;

		// Token: 0x04000CFC RID: 3324
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListKeyName_A8362_Col;

		// Token: 0x04000CFD RID: 3325
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListCKR_A7665_Col;

		// Token: 0x04000CFE RID: 3326
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListIndexed_A8282_Col;

		// Token: 0x04000CFF RID: 3327
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListSlotA_A9155_Col;

		// Token: 0x04000D00 RID: 3328
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListSlotB_A9158_Col;

		// Token: 0x04000D01 RID: 3329
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListSelectableADPKeyData_A9106_Col;

		// Token: 0x04000D02 RID: 3330
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecWideMultikeyListSelectableADPKeyID_A9107_Col;

		// Token: 0x04000D03 RID: 3331
		internal global::AcpUI.AcpGroupBox ExpanderSecureWideEncryptionKeyListTableSRecView;

		// Token: 0x04000D04 RID: 3332
		internal global::System.Windows.Controls.Grid gridExpanderSecureWideEncryptionKeyListTableSRecView;

		// Token: 0x04000D05 RID: 3333
		internal global::AcpUI.AcpTextBox SecWideMultikeyListKeyName_A8362;

		// Token: 0x04000D06 RID: 3334
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListKeyName_A8362;

		// Token: 0x04000D07 RID: 3335
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListKeyName_A8362;

		// Token: 0x04000D08 RID: 3336
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListKeyName_A8362;

		// Token: 0x04000D09 RID: 3337
		internal global::AcpUI.AcpLabel SecWideMultikeyListKeyName_A8362Comp;

		// Token: 0x04000D0A RID: 3338
		internal global::AcpUI.AcpTextBoxSpinner SecWideMultikeyListCKR_A7665;

		// Token: 0x04000D0B RID: 3339
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListCKR_A7665;

		// Token: 0x04000D0C RID: 3340
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListCKR_A7665;

		// Token: 0x04000D0D RID: 3341
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListCKR_A7665;

		// Token: 0x04000D0E RID: 3342
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListCKR_A7665;

		// Token: 0x04000D0F RID: 3343
		internal global::AcpUI.AcpLabel SecWideMultikeyListCKR_A7665Comp;

		// Token: 0x04000D10 RID: 3344
		internal global::AcpUI.AcpCheckBox SecWideMultikeyListIndexed_A8282;

		// Token: 0x04000D11 RID: 3345
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListIndexed_A8282;

		// Token: 0x04000D12 RID: 3346
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListIndexed_A8282;

		// Token: 0x04000D13 RID: 3347
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListIndexed_A8282;

		// Token: 0x04000D14 RID: 3348
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListIndexed_A8282;

		// Token: 0x04000D15 RID: 3349
		internal global::AcpUI.AcpCheckBox SecWideMultikeyListIndexed_A8282Comp;

		// Token: 0x04000D16 RID: 3350
		internal global::AcpUI.AcpLabel SecWideMultikeyListSlotA_A9155;

		// Token: 0x04000D17 RID: 3351
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListSlotA_A9155;

		// Token: 0x04000D18 RID: 3352
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListSlotA_A9155;

		// Token: 0x04000D19 RID: 3353
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListSlotA_A9155;

		// Token: 0x04000D1A RID: 3354
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListSlotA_A9155;

		// Token: 0x04000D1B RID: 3355
		internal global::AcpUI.AcpLabel SecWideMultikeyListSlotA_A9155Comp;

		// Token: 0x04000D1C RID: 3356
		internal global::AcpUI.AcpLabel SecWideMultikeyListSlotB_A9158;

		// Token: 0x04000D1D RID: 3357
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListSlotB_A9158;

		// Token: 0x04000D1E RID: 3358
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListSlotB_A9158;

		// Token: 0x04000D1F RID: 3359
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListSlotB_A9158;

		// Token: 0x04000D20 RID: 3360
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListSlotB_A9158;

		// Token: 0x04000D21 RID: 3361
		internal global::AcpUI.AcpLabel SecWideMultikeyListSlotB_A9158Comp;

		// Token: 0x04000D22 RID: 3362
		internal global::AcpUI.AcpTextBox SecWideMultikeyListSelectableADPKeyData_A9106;

		// Token: 0x04000D23 RID: 3363
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListSelectableADPKeyData_A9106;

		// Token: 0x04000D24 RID: 3364
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListSelectableADPKeyData_A9106;

		// Token: 0x04000D25 RID: 3365
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListSelectableADPKeyData_A9106;

		// Token: 0x04000D26 RID: 3366
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListSelectableADPKeyData_A9106;

		// Token: 0x04000D27 RID: 3367
		internal global::AcpUI.AcpLabel SecWideMultikeyListSelectableADPKeyData_A9106Comp;

		// Token: 0x04000D28 RID: 3368
		internal global::AcpUI.AcpTextBox SecWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000D29 RID: 3369
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000D2A RID: 3370
		internal global::AcpUI.AcpLabel LblSecWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000D2B RID: 3371
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000D2C RID: 3372
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000D2D RID: 3373
		internal global::AcpUI.AcpLabel SecWideMultikeyListSelectableADPKeyID_A9107Comp;

		// Token: 0x04000D2E RID: 3374
		internal global::AcpUI.AcpExpander ExpanderSecureWideLabtool;

		// Token: 0x04000D2F RID: 3375
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureWideLabtoolPseudo0;

		// Token: 0x04000D30 RID: 3376
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecWideLabtoolPIDIndexMapping_A8279;

		// Token: 0x04000D31 RID: 3377
		internal global::AcpUI.AcpLabel LblSecWideLabtoolPIDIndexMapping_A8279;

		// Token: 0x04000D32 RID: 3378
		internal global::AcpUI.AcpTextBoxSpinner SecWideLabtoolPIDIndexMapping_A8279;

		// Token: 0x04000D33 RID: 3379
		internal global::AcpUI.AcpRtdButton RTDBtnSecWideLabtoolPIDIndexMapping_A8279;

		// Token: 0x04000D34 RID: 3380
		internal global::AcpUI.AcpCopyButton CpyBtnSecWideLabtoolPIDIndexMapping_A8279;

		// Token: 0x04000D35 RID: 3381
		internal global::AcpUI.AcpLabel SecWideLabtoolPIDIndexMapping_A8279Comp;

		// Token: 0x04000D36 RID: 3382
		private bool b;
	}
}
