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

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x020003FE RID: 1022
	public class PageButtons : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008DC2 RID: 36290 RVA: 0x0084D4A0 File Offset: 0x0084B6A0
		public PageButtons()
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

		// Token: 0x06008DC3 RID: 36291 RVA: 0x0084D4D8 File Offset: 0x0084B6D8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)902568950;
			short num2 = num;
			num = (short)500177910;
			global::AcpUI.AcpExpander acpExpander;
			global::System.Collections.IEnumerator enumerator;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_344:
				num = (short)1830420480;
				short num3 = num;
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1705967617;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)317980672;
				if (num != 0)
				{
				}
				num = (short)767688704;
				num4 = (int)num;
				switch (num4)
				{
				default:
					num = (short)977797124;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				object obj;
				switch (num4)
				{
				case 0:
					obj = null;
					obj = this.RecNavToolbarExpanderButtonsPortableButton.MyRecordsetDataSource;
					num = (short)837025793;
					if (num != 0)
					{
					}
					num = (short)1085407235;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					try
					{
						num = (short)1334575105;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								if (acpExpander != null)
								{
									num = (short)2071068674;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_12C;
								}
								continue;
							case 2:
								base.Expanders.Add(acpExpander);
								num = (short)1157300229;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)704905222;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)873201667;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)1198587904;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1E7;
							}
							IL_12E:
							num = (short)1743847428;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_12C:
							goto IL_12E;
						}
						IL_1E7:
						goto IL_39F;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_209;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1F6:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)682295297;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_25D;
							case 1:
								disposable.Dispose();
								num = (short)1916928002;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_25B;
							}
							goto IL_209;
						}
						IL_25B:
						IL_25D:
						goto EndFinally_10;
						IL_209:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)998834176;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_1F6;
						EndFinally_10:;
					}
					goto IL_25E;
					IL_39F:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1326383113;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (obj != null)
					{
						num = (short)859439115;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_445;
				case 3:
					if (obj != null)
					{
						num = (short)367722502;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_403;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_C3;
					}
					continue;
				case 5:
					goto IL_293;
				case 6:
				{
					global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderButtonsPortableButton.MyDataPresenter = this.ExpanderButtonsPortableButton;
					num = (short)387579914;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_445;
				case 8:
					if (obj != null)
					{
						num = (short)1450442764;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_344;
				case 9:
					goto IL_3C6;
				case 10:
					goto IL_403;
				case 11:
				{
					global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderButtonsDataButtonTable.MyDataPresenter = this.ExpanderButtonsDataButtonTable;
					num = (short)1270480903;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_25E;
				}
				IL_C3:
				if (!this.a)
				{
					num = (short)262995968;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_48D;
				IL_25E:
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
				this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.MyDataPresenter = this.ExpanderButtonsPortableSideUpDownArrowButton;
				num = (short)684261381;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_403:
				obj = this.RecNavToolbarExpanderButtonsDataButtonTable.MyRecordsetDataSource;
				num = (short)1873084418;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_445:
				obj = this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.MyRecordsetDataSource;
				num = (short)611581960;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_293:
			goto IL_344;
			IL_3C6:
			IL_48D:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x0084D9A8 File Offset: 0x0084BBA8
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
					goto IL_C4;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)1878786048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.a)
					{
						num2 = (short)1624899585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_C4:
			num2 = (short)379221610;
			short num3 = num2;
			num2 = (short)1606907498;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num2 = (short)150339584;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)828571648;
			if (num2 != 0)
			{
			}
			num2 = (short)1816985601;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderButtonsPortableButton.DataContext = null;
			this.RecNavToolbarExpanderButtonsDataButtonTable.DataContext = null;
			this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.DataContext = null;
			this.RecNavToolbarExpanderButtonsPortableButton.MyDataPresenter = null;
			this.RecNavToolbarExpanderButtonsDataButtonTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.MyDataPresenter = null;
			num2 = (short)586022914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x0084DB18 File Offset: 0x0084BD18
		public override void SetDataContext()
		{
			short num = (short)1477509146;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2042);
					num = (short)1579352079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10745] != null)
					{
						num = (short)1671036960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					goto IL_5DA;
				case 4:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsDataButtonTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10089].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsDataButtonTable).SyncDataSources();
					num = (short)769982477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_4F0;
				case 6:
					num = (short)1916796937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2042);
					num = (short)913506324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10745].EmbeddedRecset != null)
					{
						num = (short)1925251100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)384761887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DA;
				case 10:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10091].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableButton).SyncDataSources();
					num = (short)1691811843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)371720217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10089].EmbeddedRecset != null)
					{
						num = (short)1212022788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 13:
					goto IL_D0;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10091].EmbeddedRecset != null)
					{
						num = (short)482410506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DA;
				case 15:
					if (feature != null)
					{
						num = (short)623575046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DA;
				case 16:
					num = (short)272236556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1375338497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1143275541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)270008349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_21B;
				case 21:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)2048196627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 22:
					num = (short)951517198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10091] != null)
					{
						num = (short)98762774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DA;
				case 24:
					if (feature != null)
					{
						num = (short)1575485440;
						short num3 = num;
						num = (short)123469835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 25:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)66453521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 26:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 27:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)554696704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsDataButtonTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton).MySecondaryRecordsetDataSource = null;
					num = (short)1572470786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_3B0;
				case 29:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10089] != null)
					{
						num = (short)824311824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 30:
				{
					num = (short)264369516;
					short num4 = num;
					num = (short)1889989996;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F0;
					default:
						num = (short)1167589376;
						if (num != 0)
						{
						}
						num = (short)74711041;
						if (num != 0)
						{
						}
						if (feature != null)
						{
							num = (short)157351954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					}
					break;
				}
				case 31:
					num = (short)2068316183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					num = (short)2082013192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)581566471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2042);
				num = (short)944635909;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0:
				num = (short)1309343768;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21B:
				num = (short)1726742555;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4F0:
				goto IL_21B;
				IL_5DA:
				num = (short)610664478;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3B0:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10745].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton).SyncDataSources();
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x0084E1B0 File Offset: 0x0084C3B0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1528823808;
			switch (num)
			{
			default:
			{
				num = (short)326041618;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					object myRecordsetDataSource2;
					switch (num2)
					{
					case 0:
						goto IL_4D6;
					case 1:
						goto IL_D9;
					case 2:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.MyRecordsetDataSource;
						num = (short)1477312512;
						short num3 = num;
						num = (short)1134034968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_D9;
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1919549455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)289669129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1130233856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)497877012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮돰蛲致菶雸闺軼믾怀眂搄䔆簈缊礌怎缐䜒琔甖甘縚", a_))
						{
							num = (short)2110324742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮돰蛲致菶雸闺軼꿾渀焂焄昆欈朊栌導砐眒瀔䈖椘弚爜栞传戢圤唦䘨尪漬娮䔰䜲娴夶", a_))
						{
							num = (short)1093468181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarExpanderButtonsPortableButton.MyRecordsetDataSource;
						num = (short)1021575178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1A8;
					case 11:
						num = (short)85983237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderButtonsDataButtonTable.MyRecordsetDataSource;
						num = (short)1507721238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_26F;
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1741094914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1272905751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_4D6;
					case 16:
						num = (short)1486225425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮돰蛲致菶雸闺軼꿾渀焂焄昆欈朊栌䴎搐朒愔砖眘", a_))
						{
							num = (short)1360396299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D6;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					case 19:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2060451843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)975765516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1243086849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)147324942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)343867411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					}
					case 23:
					{
						num = (short)883904829;
						short num4 = num;
						num = (short)511988029;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A8;
						default:
							goto IL_33F;
						}
						break;
					}
					case 24:
						num = (short)677904385;
						if (num != 0)
						{
						}
						if (myRecordsetDataSource != null)
						{
							num = (short)1801781261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_B1:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)773390352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_D9:
					num = (short)1255604232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					if (myRecordsetDataSource2 != null)
					{
						num = (short)768147460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4D6:
					num = (short)543358983;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26F:
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner)collectionView3.CurrentItem;
				collectionView3.MoveCurrentTo(item3);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_33F:
				num = (short)1358757888;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x0084E740 File Offset: 0x0084C940
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1343359541;
			short num2 = num;
			num = (short)1814891061;
			switch (num2 == num)
			{
			}
			num = (short)2011168769;
			if (num != 0)
			{
			}
			num = (short)291635200;
			short num3 = num;
			num = (short)462684160;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x0084E7F0 File Offset: 0x0084C9F0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1229848577;
			if (num != 0)
			{
			}
			num = (short)2029437371;
			short num2 = num;
			num = (short)710787515;
			switch (num2 == num)
			{
			}
			num = (short)973209600;
			short num3 = num;
			num = (short)1529741312;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x0084E8A0 File Offset: 0x0084CAA0
		internal void OnExpanderButtonsPortableButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B4;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderButtonsPortableButton.SyncDataSources();
					num2 = (short)260898816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)455278593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				}
				goto IL_1C;
			}
			IL_B4:
			num2 = (short)2010185729;
			if (num2 != 0)
			{
			}
			num2 = (short)474415104;
			short num3 = num2;
			num2 = (short)344186651;
			short num4 = num2;
			num2 = (short)982245147;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1496776704;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_151:
			this.RecNavToolbarExpanderButtonsPortableButton.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderButtonsPortableButton.MyRecordsetDataSource;
			num2 = (short)12648450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x0084EA0C File Offset: 0x0084CC0C
		internal void OnExpanderButtonsDataButtonTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_DD;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderButtonsDataButtonTable.SyncDataSources();
					num2 = (short)153157632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)476250113;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)612040705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_155;
				}
				goto IL_1C;
			}
			IL_DD:
			num2 = (short)1126301696;
			short num3 = num2;
			num2 = (short)1420481959;
			short num4 = num2;
			num2 = (short)1014551975;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1561919488;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_155:
			this.RecNavToolbarExpanderButtonsDataButtonTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderButtonsDataButtonTable.MyRecordsetDataSource;
			num2 = (short)1501822978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x0084EB7C File Offset: 0x0084CD7C
		internal void OnExpanderButtonsPortableSideUpDownArrowButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B2;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.SyncDataSources();
					num2 = (short)427753472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)336920577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				}
				goto IL_1C;
			}
			IL_B2:
			num2 = (short)1115160577;
			if (num2 != 0)
			{
			}
			num2 = (short)891748352;
			short num3 = num2;
			num2 = (short)963886268;
			short num4 = num2;
			num2 = (short)2128198844;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1806303232;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_150:
			this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.MyRecordsetDataSource;
			num2 = (short)1599406082;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x0084ECE8 File Offset: 0x0084CEE8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)275434307;
			short num2 = num;
			num = (short)1933167427;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1182072833;
				if (num != 0)
				{
				}
				num = (short)676724736;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽狿持怃漅朇⼉㸋㸍甏怑猓礕瘗甙焛眝䌟儡ģᐥᠧ䤩䌫䀭嘯嬱匳䌵䨷嬹䠻圽⼿ⱁ歃╅❇⑉㡋㱍㽏㹑❓祕㩗⽙⡛⩝ཟౡᝣ䥥੧ὩᡫᩭὯᱱݳ塵w᭹ᅻች", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)407633920;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x0084EDC8 File Offset: 0x0084CFC8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1371996162;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A1A;
				case 1:
					num = (short)1515520000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_453;
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
					goto IL_10CA;
				case 22:
					goto IL_A1F;
				case 23:
					goto IL_688;
				case 24:
					goto IL_931;
				case 25:
					goto IL_5E8;
				case 26:
					goto IL_1072;
				case 27:
					goto IL_ED4;
				case 28:
					goto IL_BC0;
				case 29:
					goto IL_CF8;
				case 30:
					goto IL_FE6;
				case 31:
					goto IL_C53;
				case 32:
					goto IL_6E0;
				case 33:
					goto IL_EFB;
				case 34:
					goto IL_D05;
				case 35:
					goto IL_8A5;
				case 36:
					goto IL_EAD;
				case 37:
					goto IL_F2C;
				case 38:
					goto IL_EE1;
				case 39:
					goto IL_D12;
				case 40:
					goto IL_924;
				case 41:
					goto IL_7AA;
				case 42:
					goto IL_3A6;
				case 43:
					goto IL_955;
				case 44:
					goto IL_6C6;
				case 45:
					goto IL_664;
				case 46:
					goto IL_491;
				case 47:
					goto IL_A84;
				case 48:
					goto IL_6ED;
				case 49:
					goto IL_F91;
				case 50:
					goto IL_748;
				case 51:
					goto IL_E89;
				case 52:
					goto IL_484;
				case 53:
					goto IL_EEE;
				case 54:
					goto IL_1058;
				case 55:
					goto IL_375;
				case 56:
					goto IL_555;
				case 57:
					goto IL_D8E;
				case 58:
					goto IL_707;
				case 59:
					goto IL_49E;
				case 60:
					goto IL_408;
				case 61:
					goto IL_881;
				case 62:
					goto IL_6B9;
				case 63:
					goto IL_5A0;
				case 64:
					goto IL_593;
				case 65:
					goto IL_E14;
				case 66:
					goto IL_108C;
				case 67:
					goto IL_BE4;
				case 68:
					goto IL_B10;
				case 69:
					goto IL_56F;
				case 70:
					goto IL_E48;
				case 71:
					goto IL_F53;
				case 72:
					goto IL_AB8;
				case 73:
					goto IL_531;
				case 74:
					goto IL_E07;
				case 75:
					goto IL_CAD;
				case 76:
					goto IL_619;
				case 77:
					goto IL_A6A;
				case 78:
					goto IL_9DB;
				case 79:
					goto IL_762;
				case 80:
					goto IL_F08;
				case 81:
					goto IL_633;
				case 82:
					goto IL_979;
				case 83:
					goto IL_B1D;
				case 84:
					goto IL_E55;
				case 85:
					goto IL_7F5;
				case 86:
					goto IL_500;
				case 87:
					goto IL_4F3;
				case 88:
					goto IL_CD1;
				case 89:
					goto IL_10BD;
				case 90:
					goto IL_C46;
				case 91:
					goto IL_7D1;
				case 92:
					goto IL_819;
				case 93:
					goto IL_84D;
				case 94:
					goto IL_A5D;
				case 95:
					goto IL_446;
				case 96:
					goto IL_1031;
				case 97:
					goto IL_EBA;
				case 98:
					goto IL_A50;
				case 99:
					goto IL_840;
				case 100:
					goto IL_60C;
				case 101:
					goto IL_CEB;
				case 102:
					goto IL_A77;
				case 103:
					goto IL_DB2;
				case 104:
					goto IL_104B;
				case 105:
					goto IL_E7C;
				case 106:
					goto IL_5C4;
				case 107:
					goto IL_9E8;
				case 108:
					goto IL_C22;
				case 109:
					goto IL_D5D;
				case 110:
					goto IL_ADF;
				case 111:
					goto IL_826;
				case 112:
					goto IL_786;
				case 113:
					goto IL_F84;
				case 114:
					goto IL_1000;
				case 115:
					goto IL_874;
				case 116:
					goto IL_368;
				case 117:
					goto IL_7C4;
				case 118:
					goto IL_A2C;
				case 119:
					goto IL_85A;
				case 120:
					goto IL_3E4;
				case 121:
					goto IL_1024;
				case 122:
					goto IL_755;
				case 123:
					goto IL_6FA;
				case 124:
					goto IL_F60;
				case 125:
					goto IL_B75;
				case 126:
					goto IL_1099;
				case 127:
					goto IL_B4E;
				case 128:
					goto IL_524;
				case 129:
					goto IL_A9E;
				case 130:
					goto IL_9B7;
				case 131:
					goto IL_AAB;
				case 132:
					goto IL_D39;
				case 133:
					goto IL_B82;
				case 134:
					goto IL_9AA;
				case 135:
					goto IL_3B3;
				case 136:
					goto IL_986;
				case 137:
					goto IL_C08;
				case 138:
					goto IL_344;
				case 139:
					goto IL_B68;
				case 140:
					goto IL_D1F;
				case 141:
					goto IL_AD2;
				case 142:
					goto IL_B2A;
				case 143:
					goto IL_C89;
				case 144:
					goto IL_9F5;
				case 145:
					goto IL_626;
				case 146:
					goto IL_721;
				case 147:
					goto IL_7B7;
				case 148:
					goto IL_B8F;
				case 149:
					goto IL_AEC;
				case 150:
					goto IL_E21;
				case 151:
					goto IL_6D3;
				case 152:
					goto IL_867;
				case 153:
					goto IL_103E;
				case 154:
					goto IL_4CF;
				case 155:
					goto IL_E6F;
				case 156:
					goto IL_F39;
				case 157:
					goto IL_399;
				case 158:
					goto IL_FF3;
				case 159:
					goto IL_562;
				case 160:
					goto IL_714;
				case 161:
					goto IL_A91;
				case 162:
					goto IL_72E;
				case 163:
					goto IL_AC5;
				case 164:
					goto IL_F46;
				case 165:
					goto IL_640;
				case 166:
					goto IL_73B;
				case 167:
					goto IL_415;
				case 168:
					goto IL_1065;
				case 169:
					goto IL_D2C;
				case 170:
					goto IL_B5B;
				case 171:
					goto IL_4AB;
				case 172:
					goto IL_EC7;
				case 173:
					goto IL_3C0;
				case 174:
					goto IL_6AC;
				case 175:
					goto IL_833;
				case 176:
					goto IL_BB3;
				case 177:
					goto IL_DBF;
				case 178:
					goto IL_E62;
				case 179:
					goto IL_D6A;
				case 180:
					goto IL_E3B;
				case 181:
					goto IL_C15;
				case 182:
					goto IL_E2E;
				case 183:
					goto IL_FB5;
				case 184:
					goto IL_439;
				case 185:
					goto IL_DE3;
				case 186:
					goto IL_107F;
				case 187:
					goto IL_FD9;
				case 188:
					goto IL_CDE;
				default:
					num = (short)1483866113;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_344:
			this.LblBtnButtonDataButtonKey_A22613 = (global::AcpUI.AcpLabel)target;
			this.LblBtnButtonDataButtonKey_A22613.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_368:
			this.CpyBtnBtnConventionalButtonDataButtonBCO_A22611 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_375:
			this.BtnGeneralConventionalFeature_A19544 = (global::AcpUI.AcpComboBox)target;
			this.BtnGeneralConventionalFeature_A19544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_399:
			this.ExpanderButtonsPortableSideUpDownArrowButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3A6:
			this.gridExpanderButtonsPortableButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3B3:
			this.BtnTrunkingButtonDatatButtonFeature_A22608Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C0:
			this.LblBtnSideUpDownArrowButtonPrimaryFunction_A41568 = (global::AcpUI.AcpLabel)target;
			this.LblBtnSideUpDownArrowButtonPrimaryFunction_A41568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E4:
			this.LblBtnConventionalButtonDatatButtonFeature_A22610 = (global::AcpUI.AcpLabel)target;
			this.LblBtnConventionalButtonDatatButtonFeature_A22610.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_408:
			this.BtnGeneralConventionalFeature_A19544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_415:
			this.LblBtnSideArrowButtonName_A41567 = (global::AcpUI.AcpLabel)target;
			this.LblBtnSideArrowButtonName_A41567.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_439:
			this.CVBtnBtnSideUpDownArrowButtonMFBBCO_A41633 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_446:
			this.ExpanderButtonsDataButtonTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_453:
			((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PageButtons)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PageButtons)target).Unloaded += this.OnUnloaded;
			return;
			IL_484:
			this.RTDBtnBtnGeneralConventionalBCO_A19543 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_491:
			this.RTDBtnBtnPortableButtonName_A22558 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_49E:
			this.CpyBtnBtnGeneralConventionalFeature_A19544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4AB:
			this.BtnSideUpDownArrowButtonPrimaryFunction_A41568 = (global::AcpUI.AcpComboBox)target;
			this.BtnSideUpDownArrowButtonPrimaryFunction_A41568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4CF:
			this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton.ModeClick += this.OnModeClick;
			return;
			IL_4F3:
			this.RTDBtnBtnPortableTopButtonLongPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_500:
			this.BtnPortableTopButtonLongPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.BtnPortableTopButtonLongPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_524:
			this.CpyBtnBtnTrunkingButtonDataButtonBCO_A22609 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_531:
			this.BtnPortableButtonKey_A22557 = (global::AcpUI.AcpTextBox)target;
			this.BtnPortableButtonKey_A22557.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_555:
			this.CVBtnBtnGeneralConventionalFeature_A19544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_562:
			this.BtnSideArrowButtonName_A41567_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_56F:
			this.LblBtnTrunkingPortableButtonFeature_A19546 = (global::AcpUI.AcpLabel)target;
			this.LblBtnTrunkingPortableButtonFeature_A19546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_593:
			this.RTDBtnBtnTrunkingPortableTrunkingBCO_A19545 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5A0:
			this.LblBtnTrunkingPortableTrunkingBCO_A19545 = (global::AcpUI.AcpLabel)target;
			this.LblBtnTrunkingPortableTrunkingBCO_A19545.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C4:
			this.BtnButtonDataButtonName_A22612 = (global::AcpUI.AcpLabel)target;
			this.BtnButtonDataButtonName_A22612.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5E8:
			this.HLinkSideArrowButtons = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSideArrowButtons.Click += this.HLinkClick;
			return;
			IL_60C:
			this.BtnTrunkingButtonDatatButtonFeature_A22608_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_619:
			this.CpyBtnBtnPortableButtonKey_A22557 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_626:
			this.CpyBtnBtnPortableDataButtonShortPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_633:
			this.RTDBtnBtnTopButtonShortPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_640:
			this.BtnSideArrowButtonName_A41567 = (global::AcpUI.AcpLabel)target;
			this.BtnSideArrowButtonName_A41567.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_664:
			this.LblBtnPortableButtonName_A22558 = (global::AcpUI.AcpLabel)target;
			this.LblBtnPortableButtonName_A22558.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_688:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_6AC:
			this.RTDBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6B9:
			this.CVBtnBtnTrunkingPortableTrunkingBCO_A19545 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6C6:
			this.CVBtnBtnPortableButtonName_A22558 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6D3:
			this.CpyBtnBtnButtonDataButtonLongPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6E0:
			this.ExpanderButtonsPortableButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_6ED:
			this.BtnPortableButtonName_A22558Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6FA:
			this.BtnConventionalButtonDatatButtonFeature_A22610Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_707:
			this.RTDBtnBtnGeneralConventionalFeature_A19544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_714:
			this.BtnSideUpDownArrowButtonPrimaryFunction_A41568_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_721:
			this.BtnPortableDataButtonShortPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_72E:
			this.BtnSideUpDownArrowButtonMFBBCO_A41633_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_73B:
			this.CVBtnBtnSideArrowButtonName_A41567 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_748:
			this.CVBtnBtnGeneralConventionalBCO_A19543 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_755:
			this.CpyBtnBtnConventionalButtonDatatButtonFeature_A22610 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_762:
			this.LblBtnTopButtonShortPressTime = (global::AcpUI.AcpLabel)target;
			this.LblBtnTopButtonShortPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_786:
			this.BtnConventionalButtonDataButtonBCO_A22611 = (global::AcpUI.AcpComboBox)target;
			this.BtnConventionalButtonDataButtonBCO_A22611.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7AA:
			this.ExpanderButtonsPortableButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7B7:
			this.CVBtnBtnButtonDataButtonLongPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7C4:
			this.BtnConventionalButtonDataButtonBCO_A22611Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7D1:
			this.RecNavToolbarExpanderButtonsDataButtonTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderButtonsDataButtonTable.ModeClick += this.OnModeClick;
			return;
			IL_7F5:
			this.LblBtnPortableTopButtonLongPressTime = (global::AcpUI.AcpLabel)target;
			this.LblBtnPortableTopButtonLongPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_819:
			this.ExpanderButtonsDataButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_826:
			this.BtnButtonDataButtonName_A22612Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_833:
			this.CpyBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_840:
			this.BtnTrunkingButtonDataButtonBCO_A22609_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_84D:
			this.ExpanderButtonsDataButtonTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_85A:
			this.CVBtnBtnConventionalButtonDatatButtonFeature_A22610 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_867:
			this.BtnButtonDataButtonLongPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_874:
			this.RTDBtnBtnConventionalButtonDataButtonBCO_A22611 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_881:
			this.BtnTrunkingPortableTrunkingBCO_A19545 = (global::AcpUI.AcpComboBox)target;
			this.BtnTrunkingPortableTrunkingBCO_A19545.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A5:
			num = (short)1760592644;
			short num3 = num;
			num = (short)978879236;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_344;
			default:
				num = (short)1241448449;
				if (num != 0)
				{
				}
				num = (short)1385168896;
				if (num != 0)
				{
				}
				this.BtnGeneralConventionalFeature_A19544_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			}
			IL_924:
			this.BtnPortableTopButtonLongPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_931:
			this.HLinkDataButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataButton.Click += this.HLinkClick;
			return;
			IL_955:
			this.BtnPortableButtonName_A22558 = (global::AcpUI.AcpLabel)target;
			this.BtnPortableButtonName_A22558.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_979:
			this.CpyBtnBtnTopButtonShortPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_986:
			this.BtnButtonDataButtonKey_A22613 = (global::AcpUI.AcpTextBox)target;
			this.BtnButtonDataButtonKey_A22613.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9AA:
			this.CpyBtnBtnTrunkingButtonDatatButtonFeature_A22608 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9B7:
			this.BtnTrunkingButtonDatatButtonFeature_A22608 = (global::AcpUI.AcpComboBox)target;
			this.BtnTrunkingButtonDatatButtonFeature_A22608.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9DB:
			this.CVBtnBtnTopButtonShortPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9E8:
			this.CVBtnBtnButtonDataButtonName_A22612 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F5:
			this.RTDBtnBtnPortableDataButtonShortPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A1A:
			goto IL_10CA;
			IL_A1F:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_A2C:
			this.BtnConventionalButtonDatatButtonFeature_A22610 = (global::AcpUI.AcpComboBox)target;
			this.BtnConventionalButtonDatatButtonFeature_A22610.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A50:
			this.BtnConventionalButtonDatatButtonFeature_A22610_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A5D:
			this.ExpanderButtonsDataButtonTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A6A:
			this.BtnPortableButtonKey_A22557Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A77:
			this.BtnPortableDataButtonShortPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A84:
			this.CpyBtnBtnPortableButtonName_A22558 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A91:
			this.BtnSideUpDownArrowButtonSecondaryFunction_A41592_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A9E:
			this.BtnTrunkingButtonDataButtonBCO_A22609Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AAB:
			this.CVBtnBtnTrunkingButtonDatatButtonFeature_A22608 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AB8:
			this.BtnTrunkingPortableButtonFeature_A19546Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AC5:
			this.ExpanderButtonsPortableSideUpDownArrowButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AD2:
			this.CVBtnBtnPortableDataButtonShortPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ADF:
			this.CpyBtnBtnButtonDataButtonName_A22612 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AEC:
			this.BtnButtonDataButtonLongPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.BtnButtonDataButtonLongPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B10:
			this.CVBtnBtnTrunkingPortableButtonFeature_A19546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B1D:
			this.BtnTopButtonShortPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B2A:
			this.LblBtnPortableDataButtonShortPressTime = (global::AcpUI.AcpLabel)target;
			this.LblBtnPortableDataButtonShortPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B4E:
			this.RTDBtnBtnTrunkingButtonDataButtonBCO_A22609 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B5B:
			this.BtnSideArrowButtonName_A41567Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B68:
			this.CpyBtnBtnButtonDataButtonKey_A22613 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B75:
			this.CVBtnBtnTrunkingButtonDataButtonBCO_A22609 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B82:
			this.RTDBtnBtnTrunkingButtonDatatButtonFeature_A22608 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B8F:
			this.LblBtnButtonDataButtonLongPressTime = (global::AcpUI.AcpLabel)target;
			this.LblBtnButtonDataButtonLongPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BB3:
			this.BtnSideUpDownArrowButtonPrimaryFunction_A41568Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BC0:
			this.RecNavToolbarExpanderButtonsPortableButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderButtonsPortableButton.ModeClick += this.OnModeClick;
			return;
			IL_BE4:
			this.BtnTrunkingPortableButtonFeature_A19546 = (global::AcpUI.AcpComboBox)target;
			this.BtnTrunkingPortableButtonFeature_A19546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C08:
			this.CVBtnBtnButtonDataButtonKey_A22613 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C15:
			this.CpyBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C22:
			this.LblBtnButtonDataButtonName_A22612 = (global::AcpUI.AcpLabel)target;
			this.LblBtnButtonDataButtonName_A22612.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C46:
			this.ExpanderButtonsDataButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_C53:
			num = (short)486473728;
			short num4 = num;
			this.ExpanderButtonsPortableButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C89:
			this.BtnPortableDataButtonShortPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.BtnPortableDataButtonShortPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CAD:
			this.LblBtnPortableButtonKey_A22557 = (global::AcpUI.AcpLabel)target;
			this.LblBtnPortableButtonKey_A22557.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CD1:
			this.CpyBtnBtnPortableTopButtonLongPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CDE:
			this.BtnSideUpDownArrowButtonMFBBCO_A41633Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CEB:
			this.BtnButtonDataButtonKey_A22613_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_CF8:
			this.ExpanderButtonsGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D05:
			this.BtnGeneralConventionalBCO_A19543_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D12:
			this.BtnTopButtonShortPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D1F:
			this.BtnButtonDataButtonKey_A22613Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D2C:
			this.CpyBtnBtnSideArrowButtonName_A41567 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D39:
			this.LblBtnTrunkingButtonDatatButtonFeature_A22608 = (global::AcpUI.AcpLabel)target;
			this.LblBtnTrunkingButtonDatatButtonFeature_A22608.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D5D:
			this.RTDBtnBtnButtonDataButtonName_A22612 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D6A:
			this.LblBtnSideUpDownArrowButtonSecondaryFunction_A41592 = (global::AcpUI.AcpLabel)target;
			this.LblBtnSideUpDownArrowButtonSecondaryFunction_A41592.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D8E:
			this.LblBtnGeneralConventionalFeature_A19544 = (global::AcpUI.AcpLabel)target;
			this.LblBtnGeneralConventionalFeature_A19544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB2:
			this.BtnButtonDataButtonLongPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_DBF:
			this.BtnSideUpDownArrowButtonSecondaryFunction_A41592 = (global::AcpUI.AcpComboBox)target;
			this.BtnSideUpDownArrowButtonSecondaryFunction_A41592.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE3:
			this.LblBtnSideUpDownArrowButtonMFBBCO_A41633 = (global::AcpUI.AcpLabel)target;
			this.LblBtnSideUpDownArrowButtonMFBBCO_A41633.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E07:
			this.CVBtnBtnPortableButtonKey_A22557 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E14:
			this.CpyBtnBtnTrunkingPortableTrunkingBCO_A19545 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E21:
			this.RTDBtnBtnButtonDataButtonLongPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E2E:
			this.BtnSideUpDownArrowButtonSecondaryFunction_A41592Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E3B:
			this.RTDBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E48:
			this.RTDBtnBtnTrunkingPortableButtonFeature_A19546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E55:
			this.CVBtnBtnPortableTopButtonLongPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E62:
			this.CVBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E6F:
			this.ExpanderButtonsSideArrowButtonsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E7C:
			this.gridExpanderButtonsDataButtonTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E89:
			this.LblBtnGeneralConventionalBCO_A19543 = (global::AcpUI.AcpLabel)target;
			this.LblBtnGeneralConventionalBCO_A19543.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EAD:
			this.BtnTrunkingPortableTrunkingBCO_A19545_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_EBA:
			this.BtnConventionalButtonDataButtonBCO_A22611_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_EC7:
			this.CVBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ED4:
			this.ExpanderButtonsGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_EE1:
			this.BtnPortableButtonKey_A22557_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_EEE:
			this.CpyBtnBtnGeneralConventionalBCO_A19543 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EFB:
			this.BtnPortableButtonName_A22558_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F08:
			this.BtnTopButtonShortPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.BtnTopButtonShortPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F2C:
			this.BtnTrunkingPortableButtonFeature_A19546_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F39:
			this.ExpanderButtonsPortableSideUpDownArrowButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F46:
			this.gridExpanderButtonsPortableSideUpDownArrowButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F53:
			this.CpyBtnBtnTrunkingPortableButtonFeature_A19546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F60:
			this.BtnTrunkingButtonDataButtonBCO_A22609 = (global::AcpUI.AcpComboBox)target;
			this.BtnTrunkingButtonDataButtonBCO_A22609.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F84:
			this.CVBtnBtnConventionalButtonDataButtonBCO_A22611 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F91:
			this.BtnGeneralConventionalBCO_A19543 = (global::AcpUI.AcpComboBox)target;
			this.BtnGeneralConventionalBCO_A19543.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FB5:
			this.BtnSideUpDownArrowButtonMFBBCO_A41633 = (global::AcpUI.AcpComboBox)target;
			this.BtnSideUpDownArrowButtonMFBBCO_A41633.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FD9:
			this.CpyBtnBtnSideUpDownArrowButtonMFBBCO_A41633 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FE6:
			this.ExpanderButtonsPortableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_FF3:
			this.ExpanderButtonsPortableSideUpDownArrowButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1000:
			this.LblBtnConventionalButtonDataButtonBCO_A22611 = (global::AcpUI.AcpLabel)target;
			this.LblBtnConventionalButtonDataButtonBCO_A22611.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1024:
			this.RTDBtnBtnConventionalButtonDatatButtonFeature_A22610 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1031:
			this.BtnButtonDataButtonName_A22612_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_103E:
			this.ExpanderButtonsSideArrowButtons = (global::AcpUI.AcpExpander)target;
			return;
			IL_104B:
			this.ExpanderButtonsDataButtonTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1058:
			this.BtnGeneralConventionalBCO_A19543Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1065:
			this.RTDBtnBtnSideArrowButtonName_A41567 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1072:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_107F:
			this.RTDBtnBtnSideUpDownArrowButtonMFBBCO_A41633 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_108C:
			this.BtnTrunkingPortableTrunkingBCO_A19545Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1099:
			this.LblBtnTrunkingButtonDataButtonBCO_A22609 = (global::AcpUI.AcpLabel)target;
			this.LblBtnTrunkingButtonDataButtonBCO_A22609.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10BD:
			this.BtnPortableTopButtonLongPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10CA:
			this.b = true;
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x0084FEA8 File Offset: 0x0084E0A8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
			{
				short num = (short)594739200;
				short num2 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 10:
				break;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
			{
				short num = (short)1268693394;
				short num3 = num;
				num = (short)1021294994;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1506803713;
					if (num != 0)
					{
					}
					num = (short)1262551040;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 13:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400458F RID: 17807
		private bool a;

		// Token: 0x04004590 RID: 17808
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004591 RID: 17809
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004592 RID: 17810
		internal global::System.Windows.Documents.Hyperlink HLinkDataButton;

		// Token: 0x04004593 RID: 17811
		internal global::System.Windows.Documents.Hyperlink HLinkSideArrowButtons;

		// Token: 0x04004594 RID: 17812
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004595 RID: 17813
		internal global::AcpUI.AcpExpander ExpanderButtonsGeneral;

		// Token: 0x04004596 RID: 17814
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderButtonsPortableButton;

		// Token: 0x04004597 RID: 17815
		internal global::System.Windows.Controls.Grid ExpanderButtonsGeneralGrid;

		// Token: 0x04004598 RID: 17816
		internal global::System.Windows.Controls.Grid ExpanderButtonsPortableButtonGrid;

		// Token: 0x04004599 RID: 17817
		internal global::AcpUI.AcpGroupBox ExpanderButtonsPortableButtonTableView;

		// Token: 0x0400459A RID: 17818
		internal global::AcpUI.AcpXamDataPresenter ExpanderButtonsPortableButton;

		// Token: 0x0400459B RID: 17819
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnPortableButtonName_A22558_Col;

		// Token: 0x0400459C RID: 17820
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnGeneralConventionalBCO_A19543_Col;

		// Token: 0x0400459D RID: 17821
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnGeneralConventionalFeature_A19544_Col;

		// Token: 0x0400459E RID: 17822
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnTrunkingPortableTrunkingBCO_A19545_Col;

		// Token: 0x0400459F RID: 17823
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnTrunkingPortableButtonFeature_A19546_Col;

		// Token: 0x040045A0 RID: 17824
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnPortableButtonKey_A22557_Col;

		// Token: 0x040045A1 RID: 17825
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnTopButtonShortPressTime_Col;

		// Token: 0x040045A2 RID: 17826
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnPortableTopButtonLongPressTime_Col;

		// Token: 0x040045A3 RID: 17827
		internal global::AcpUI.AcpGroupBox ExpanderButtonsPortableButtonSRecView;

		// Token: 0x040045A4 RID: 17828
		internal global::System.Windows.Controls.Grid gridExpanderButtonsPortableButtonSRecView;

		// Token: 0x040045A5 RID: 17829
		internal global::AcpUI.AcpLabel BtnPortableButtonName_A22558;

		// Token: 0x040045A6 RID: 17830
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnPortableButtonName_A22558;

		// Token: 0x040045A7 RID: 17831
		internal global::AcpUI.AcpLabel LblBtnPortableButtonName_A22558;

		// Token: 0x040045A8 RID: 17832
		internal global::AcpUI.AcpRtdButton RTDBtnBtnPortableButtonName_A22558;

		// Token: 0x040045A9 RID: 17833
		internal global::AcpUI.AcpCopyButton CpyBtnBtnPortableButtonName_A22558;

		// Token: 0x040045AA RID: 17834
		internal global::AcpUI.AcpLabel BtnPortableButtonName_A22558Comp;

		// Token: 0x040045AB RID: 17835
		internal global::AcpUI.AcpComboBox BtnGeneralConventionalBCO_A19543;

		// Token: 0x040045AC RID: 17836
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnGeneralConventionalBCO_A19543;

		// Token: 0x040045AD RID: 17837
		internal global::AcpUI.AcpLabel LblBtnGeneralConventionalBCO_A19543;

		// Token: 0x040045AE RID: 17838
		internal global::AcpUI.AcpRtdButton RTDBtnBtnGeneralConventionalBCO_A19543;

		// Token: 0x040045AF RID: 17839
		internal global::AcpUI.AcpCopyButton CpyBtnBtnGeneralConventionalBCO_A19543;

		// Token: 0x040045B0 RID: 17840
		internal global::AcpUI.AcpLabel BtnGeneralConventionalBCO_A19543Comp;

		// Token: 0x040045B1 RID: 17841
		internal global::AcpUI.AcpComboBox BtnGeneralConventionalFeature_A19544;

		// Token: 0x040045B2 RID: 17842
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnGeneralConventionalFeature_A19544;

		// Token: 0x040045B3 RID: 17843
		internal global::AcpUI.AcpLabel LblBtnGeneralConventionalFeature_A19544;

		// Token: 0x040045B4 RID: 17844
		internal global::AcpUI.AcpRtdButton RTDBtnBtnGeneralConventionalFeature_A19544;

		// Token: 0x040045B5 RID: 17845
		internal global::AcpUI.AcpCopyButton CpyBtnBtnGeneralConventionalFeature_A19544;

		// Token: 0x040045B6 RID: 17846
		internal global::AcpUI.AcpLabel BtnGeneralConventionalFeature_A19544Comp;

		// Token: 0x040045B7 RID: 17847
		internal global::AcpUI.AcpComboBox BtnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x040045B8 RID: 17848
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x040045B9 RID: 17849
		internal global::AcpUI.AcpLabel LblBtnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x040045BA RID: 17850
		internal global::AcpUI.AcpRtdButton RTDBtnBtnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x040045BB RID: 17851
		internal global::AcpUI.AcpCopyButton CpyBtnBtnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x040045BC RID: 17852
		internal global::AcpUI.AcpLabel BtnTrunkingPortableTrunkingBCO_A19545Comp;

		// Token: 0x040045BD RID: 17853
		internal global::AcpUI.AcpComboBox BtnTrunkingPortableButtonFeature_A19546;

		// Token: 0x040045BE RID: 17854
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnTrunkingPortableButtonFeature_A19546;

		// Token: 0x040045BF RID: 17855
		internal global::AcpUI.AcpLabel LblBtnTrunkingPortableButtonFeature_A19546;

		// Token: 0x040045C0 RID: 17856
		internal global::AcpUI.AcpRtdButton RTDBtnBtnTrunkingPortableButtonFeature_A19546;

		// Token: 0x040045C1 RID: 17857
		internal global::AcpUI.AcpCopyButton CpyBtnBtnTrunkingPortableButtonFeature_A19546;

		// Token: 0x040045C2 RID: 17858
		internal global::AcpUI.AcpLabel BtnTrunkingPortableButtonFeature_A19546Comp;

		// Token: 0x040045C3 RID: 17859
		internal global::AcpUI.AcpTextBox BtnPortableButtonKey_A22557;

		// Token: 0x040045C4 RID: 17860
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnPortableButtonKey_A22557;

		// Token: 0x040045C5 RID: 17861
		internal global::AcpUI.AcpLabel LblBtnPortableButtonKey_A22557;

		// Token: 0x040045C6 RID: 17862
		internal global::AcpUI.AcpCopyButton CpyBtnBtnPortableButtonKey_A22557;

		// Token: 0x040045C7 RID: 17863
		internal global::AcpUI.AcpLabel BtnPortableButtonKey_A22557Comp;

		// Token: 0x040045C8 RID: 17864
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnTopButtonShortPressTime;

		// Token: 0x040045C9 RID: 17865
		internal global::AcpUI.AcpLabel LblBtnTopButtonShortPressTime;

		// Token: 0x040045CA RID: 17866
		internal global::AcpUI.AcpTextBoxSpinner BtnTopButtonShortPressTime;

		// Token: 0x040045CB RID: 17867
		internal global::AcpUI.AcpRtdButton RTDBtnBtnTopButtonShortPressTime;

		// Token: 0x040045CC RID: 17868
		internal global::AcpUI.AcpCopyButton CpyBtnBtnTopButtonShortPressTime;

		// Token: 0x040045CD RID: 17869
		internal global::AcpUI.AcpLabel BtnTopButtonShortPressTimeComp;

		// Token: 0x040045CE RID: 17870
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnPortableTopButtonLongPressTime;

		// Token: 0x040045CF RID: 17871
		internal global::AcpUI.AcpLabel LblBtnPortableTopButtonLongPressTime;

		// Token: 0x040045D0 RID: 17872
		internal global::AcpUI.AcpTextBoxSpinner BtnPortableTopButtonLongPressTime;

		// Token: 0x040045D1 RID: 17873
		internal global::AcpUI.AcpRtdButton RTDBtnBtnPortableTopButtonLongPressTime;

		// Token: 0x040045D2 RID: 17874
		internal global::AcpUI.AcpCopyButton CpyBtnBtnPortableTopButtonLongPressTime;

		// Token: 0x040045D3 RID: 17875
		internal global::AcpUI.AcpLabel BtnPortableTopButtonLongPressTimeComp;

		// Token: 0x040045D4 RID: 17876
		internal global::AcpUI.AcpExpander ExpanderButtonsDataButton;

		// Token: 0x040045D5 RID: 17877
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderButtonsDataButtonTable;

		// Token: 0x040045D6 RID: 17878
		internal global::System.Windows.Controls.Grid ExpanderButtonsDataButtonGrid;

		// Token: 0x040045D7 RID: 17879
		internal global::System.Windows.Controls.Grid ExpanderButtonsDataButtonTableGrid;

		// Token: 0x040045D8 RID: 17880
		internal global::AcpUI.AcpGroupBox ExpanderButtonsDataButtonTableTableView;

		// Token: 0x040045D9 RID: 17881
		internal global::AcpUI.AcpXamDataPresenter ExpanderButtonsDataButtonTable;

		// Token: 0x040045DA RID: 17882
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnButtonDataButtonName_A22612_Col;

		// Token: 0x040045DB RID: 17883
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnConventionalButtonDataButtonBCO_A22611_Col;

		// Token: 0x040045DC RID: 17884
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnConventionalButtonDatatButtonFeature_A22610_Col;

		// Token: 0x040045DD RID: 17885
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnTrunkingButtonDataButtonBCO_A22609_Col;

		// Token: 0x040045DE RID: 17886
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnTrunkingButtonDatatButtonFeature_A22608_Col;

		// Token: 0x040045DF RID: 17887
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnButtonDataButtonKey_A22613_Col;

		// Token: 0x040045E0 RID: 17888
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnPortableDataButtonShortPressTime_Col;

		// Token: 0x040045E1 RID: 17889
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnButtonDataButtonLongPressTime_Col;

		// Token: 0x040045E2 RID: 17890
		internal global::AcpUI.AcpGroupBox ExpanderButtonsDataButtonTableSRecView;

		// Token: 0x040045E3 RID: 17891
		internal global::System.Windows.Controls.Grid gridExpanderButtonsDataButtonTableSRecView;

		// Token: 0x040045E4 RID: 17892
		internal global::AcpUI.AcpLabel BtnButtonDataButtonName_A22612;

		// Token: 0x040045E5 RID: 17893
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnButtonDataButtonName_A22612;

		// Token: 0x040045E6 RID: 17894
		internal global::AcpUI.AcpLabel LblBtnButtonDataButtonName_A22612;

		// Token: 0x040045E7 RID: 17895
		internal global::AcpUI.AcpRtdButton RTDBtnBtnButtonDataButtonName_A22612;

		// Token: 0x040045E8 RID: 17896
		internal global::AcpUI.AcpCopyButton CpyBtnBtnButtonDataButtonName_A22612;

		// Token: 0x040045E9 RID: 17897
		internal global::AcpUI.AcpLabel BtnButtonDataButtonName_A22612Comp;

		// Token: 0x040045EA RID: 17898
		internal global::AcpUI.AcpComboBox BtnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x040045EB RID: 17899
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x040045EC RID: 17900
		internal global::AcpUI.AcpLabel LblBtnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x040045ED RID: 17901
		internal global::AcpUI.AcpRtdButton RTDBtnBtnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x040045EE RID: 17902
		internal global::AcpUI.AcpCopyButton CpyBtnBtnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x040045EF RID: 17903
		internal global::AcpUI.AcpLabel BtnConventionalButtonDataButtonBCO_A22611Comp;

		// Token: 0x040045F0 RID: 17904
		internal global::AcpUI.AcpComboBox BtnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x040045F1 RID: 17905
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x040045F2 RID: 17906
		internal global::AcpUI.AcpLabel LblBtnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x040045F3 RID: 17907
		internal global::AcpUI.AcpRtdButton RTDBtnBtnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x040045F4 RID: 17908
		internal global::AcpUI.AcpCopyButton CpyBtnBtnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x040045F5 RID: 17909
		internal global::AcpUI.AcpLabel BtnConventionalButtonDatatButtonFeature_A22610Comp;

		// Token: 0x040045F6 RID: 17910
		internal global::AcpUI.AcpComboBox BtnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x040045F7 RID: 17911
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x040045F8 RID: 17912
		internal global::AcpUI.AcpLabel LblBtnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x040045F9 RID: 17913
		internal global::AcpUI.AcpRtdButton RTDBtnBtnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x040045FA RID: 17914
		internal global::AcpUI.AcpCopyButton CpyBtnBtnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x040045FB RID: 17915
		internal global::AcpUI.AcpLabel BtnTrunkingButtonDataButtonBCO_A22609Comp;

		// Token: 0x040045FC RID: 17916
		internal global::AcpUI.AcpComboBox BtnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x040045FD RID: 17917
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x040045FE RID: 17918
		internal global::AcpUI.AcpLabel LblBtnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x040045FF RID: 17919
		internal global::AcpUI.AcpRtdButton RTDBtnBtnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x04004600 RID: 17920
		internal global::AcpUI.AcpCopyButton CpyBtnBtnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x04004601 RID: 17921
		internal global::AcpUI.AcpLabel BtnTrunkingButtonDatatButtonFeature_A22608Comp;

		// Token: 0x04004602 RID: 17922
		internal global::AcpUI.AcpTextBox BtnButtonDataButtonKey_A22613;

		// Token: 0x04004603 RID: 17923
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnButtonDataButtonKey_A22613;

		// Token: 0x04004604 RID: 17924
		internal global::AcpUI.AcpLabel LblBtnButtonDataButtonKey_A22613;

		// Token: 0x04004605 RID: 17925
		internal global::AcpUI.AcpCopyButton CpyBtnBtnButtonDataButtonKey_A22613;

		// Token: 0x04004606 RID: 17926
		internal global::AcpUI.AcpLabel BtnButtonDataButtonKey_A22613Comp;

		// Token: 0x04004607 RID: 17927
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnPortableDataButtonShortPressTime;

		// Token: 0x04004608 RID: 17928
		internal global::AcpUI.AcpLabel LblBtnPortableDataButtonShortPressTime;

		// Token: 0x04004609 RID: 17929
		internal global::AcpUI.AcpTextBoxSpinner BtnPortableDataButtonShortPressTime;

		// Token: 0x0400460A RID: 17930
		internal global::AcpUI.AcpRtdButton RTDBtnBtnPortableDataButtonShortPressTime;

		// Token: 0x0400460B RID: 17931
		internal global::AcpUI.AcpCopyButton CpyBtnBtnPortableDataButtonShortPressTime;

		// Token: 0x0400460C RID: 17932
		internal global::AcpUI.AcpLabel BtnPortableDataButtonShortPressTimeComp;

		// Token: 0x0400460D RID: 17933
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnButtonDataButtonLongPressTime;

		// Token: 0x0400460E RID: 17934
		internal global::AcpUI.AcpLabel LblBtnButtonDataButtonLongPressTime;

		// Token: 0x0400460F RID: 17935
		internal global::AcpUI.AcpTextBoxSpinner BtnButtonDataButtonLongPressTime;

		// Token: 0x04004610 RID: 17936
		internal global::AcpUI.AcpRtdButton RTDBtnBtnButtonDataButtonLongPressTime;

		// Token: 0x04004611 RID: 17937
		internal global::AcpUI.AcpCopyButton CpyBtnBtnButtonDataButtonLongPressTime;

		// Token: 0x04004612 RID: 17938
		internal global::AcpUI.AcpLabel BtnButtonDataButtonLongPressTimeComp;

		// Token: 0x04004613 RID: 17939
		internal global::AcpUI.AcpExpander ExpanderButtonsSideArrowButtons;

		// Token: 0x04004614 RID: 17940
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderButtonsPortableSideUpDownArrowButton;

		// Token: 0x04004615 RID: 17941
		internal global::System.Windows.Controls.Grid ExpanderButtonsSideArrowButtonsGrid;

		// Token: 0x04004616 RID: 17942
		internal global::System.Windows.Controls.Grid ExpanderButtonsPortableSideUpDownArrowButtonGrid;

		// Token: 0x04004617 RID: 17943
		internal global::AcpUI.AcpGroupBox ExpanderButtonsPortableSideUpDownArrowButtonTableView;

		// Token: 0x04004618 RID: 17944
		internal global::AcpUI.AcpXamDataPresenter ExpanderButtonsPortableSideUpDownArrowButton;

		// Token: 0x04004619 RID: 17945
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnSideArrowButtonName_A41567_Col;

		// Token: 0x0400461A RID: 17946
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnSideUpDownArrowButtonPrimaryFunction_A41568_Col;

		// Token: 0x0400461B RID: 17947
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnSideUpDownArrowButtonSecondaryFunction_A41592_Col;

		// Token: 0x0400461C RID: 17948
		internal global::Infragistics.Windows.DataPresenter.UnboundField BtnSideUpDownArrowButtonMFBBCO_A41633_Col;

		// Token: 0x0400461D RID: 17949
		internal global::AcpUI.AcpGroupBox ExpanderButtonsPortableSideUpDownArrowButtonSRecView;

		// Token: 0x0400461E RID: 17950
		internal global::System.Windows.Controls.Grid gridExpanderButtonsPortableSideUpDownArrowButtonSRecView;

		// Token: 0x0400461F RID: 17951
		internal global::AcpUI.AcpLabel BtnSideArrowButtonName_A41567;

		// Token: 0x04004620 RID: 17952
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnSideArrowButtonName_A41567;

		// Token: 0x04004621 RID: 17953
		internal global::AcpUI.AcpLabel LblBtnSideArrowButtonName_A41567;

		// Token: 0x04004622 RID: 17954
		internal global::AcpUI.AcpRtdButton RTDBtnBtnSideArrowButtonName_A41567;

		// Token: 0x04004623 RID: 17955
		internal global::AcpUI.AcpCopyButton CpyBtnBtnSideArrowButtonName_A41567;

		// Token: 0x04004624 RID: 17956
		internal global::AcpUI.AcpLabel BtnSideArrowButtonName_A41567Comp;

		// Token: 0x04004625 RID: 17957
		internal global::AcpUI.AcpComboBox BtnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x04004626 RID: 17958
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x04004627 RID: 17959
		internal global::AcpUI.AcpLabel LblBtnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x04004628 RID: 17960
		internal global::AcpUI.AcpRtdButton RTDBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x04004629 RID: 17961
		internal global::AcpUI.AcpCopyButton CpyBtnBtnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x0400462A RID: 17962
		internal global::AcpUI.AcpLabel BtnSideUpDownArrowButtonPrimaryFunction_A41568Comp;

		// Token: 0x0400462B RID: 17963
		internal global::AcpUI.AcpComboBox BtnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x0400462C RID: 17964
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x0400462D RID: 17965
		internal global::AcpUI.AcpLabel LblBtnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x0400462E RID: 17966
		internal global::AcpUI.AcpRtdButton RTDBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x0400462F RID: 17967
		internal global::AcpUI.AcpCopyButton CpyBtnBtnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x04004630 RID: 17968
		internal global::AcpUI.AcpLabel BtnSideUpDownArrowButtonSecondaryFunction_A41592Comp;

		// Token: 0x04004631 RID: 17969
		internal global::AcpUI.AcpComboBox BtnSideUpDownArrowButtonMFBBCO_A41633;

		// Token: 0x04004632 RID: 17970
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnBtnSideUpDownArrowButtonMFBBCO_A41633;

		// Token: 0x04004633 RID: 17971
		internal global::AcpUI.AcpLabel LblBtnSideUpDownArrowButtonMFBBCO_A41633;

		// Token: 0x04004634 RID: 17972
		internal global::AcpUI.AcpRtdButton RTDBtnBtnSideUpDownArrowButtonMFBBCO_A41633;

		// Token: 0x04004635 RID: 17973
		internal global::AcpUI.AcpCopyButton CpyBtnBtnSideUpDownArrowButtonMFBBCO_A41633;

		// Token: 0x04004636 RID: 17974
		internal global::AcpUI.AcpLabel BtnSideUpDownArrowButtonMFBBCO_A41633Comp;

		// Token: 0x04004637 RID: 17975
		private bool b;
	}
}
