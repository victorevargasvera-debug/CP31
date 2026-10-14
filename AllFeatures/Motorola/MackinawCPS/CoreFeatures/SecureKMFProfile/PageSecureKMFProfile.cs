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

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000103 RID: 259
	public class PageSecureKMFProfile : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x00251EB0 File Offset: 0x002500B0
		public PageSecureKMFProfile()
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

		// Token: 0x06002620 RID: 9760 RVA: 0x00251EE8 File Offset: 0x002500E8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)812464389;
			short num2 = num;
			num = (short)124336389;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_267:
				num = (short)2051080194;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)335413248;
				if (num != 0)
				{
				}
				num = (short)2074214400;
				num3 = (int)num;
				switch (num3)
				{
				default:
					num = (short)1915355137;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			global::AcpUI.AcpExpander acpExpander;
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				object obj;
				switch (num3)
				{
				case 0:
					this.RecNavToolbarPageSecureKMFProfile.ChildToolbars.Add(this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable);
					this.RecNavToolbarPageSecureKMFProfile.ChildToolbars.Add(this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable);
					obj = null;
					obj = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.MyRecordsetDataSource;
					num = (short)1819541505;
					if (num != 0)
					{
					}
					num = (short)1957036037;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					continue;
				case 2:
				{
					try
					{
						num = (short)640286720;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_121;
								}
								continue;
							case 1:
								if (acpExpander != null)
								{
									num = (short)451215362;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								base.Expanders.Add(acpExpander);
								num = (short)1999044613;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)314900484;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)93061121;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1806041094;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1DA;
							}
							IL_165:
							num = (short)110297091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_121:
							goto IL_165;
						}
						IL_1DA:
						goto IL_2BF;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1FC;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1E9:
							switch (num3)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)347406337;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_253;
							case 1:
								disposable.Dispose();
								num = (short)957022210;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_251;
							}
							goto IL_1FC;
						}
						IL_251:
						IL_253:
						goto EndFinally_9;
						IL_1FC:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)2012413952;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_1E9;
						EndFinally_9:;
					}
					goto IL_254;
					IL_2BF:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)326959104;
					short num4 = num;
					num = (short)1333395459;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_30F;
				case 4:
					goto IL_3EA;
				case 5:
					if (obj != null)
					{
						num = (short)460259335;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EA;
				case 6:
					if (obj != null)
					{
						num = (short)1985544201;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_254;
				case 7:
				{
					global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.MyDataPresenter = this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable;
					num = (short)401014788;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_3E5;
				case 9:
				{
					global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.MyDataPresenter = this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable;
					num = (short)2065235976;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_B8:
				if (!this.a)
				{
					num = (short)1956118528;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_42E;
				IL_3EA:
				obj = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.MyRecordsetDataSource;
				num = (short)1779171334;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_254:
			acpExpander = null;
			enumerator = this.MyStackPanel.Children.GetEnumerator();
			goto IL_267;
			IL_30F:
			goto IL_42E;
			IL_3E5:
			goto IL_254;
			IL_42E:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00252358 File Offset: 0x00250558
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
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
						if (this.a)
						{
							num2 = (short)1502478337;
							if (num2 != 0)
							{
							}
							num2 = (short)887357441;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1830748162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarPageSecureKMFProfile.DataContext = null;
				this.RecNavToolbarPageSecureKMFProfile.DataContext = null;
				this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.DataContext = null;
				this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.DataContext = null;
				this.RecNavToolbarPageSecureKMFProfile.MyDataPresenter = null;
				this.RecNavToolbarPageSecureKMFProfile.MyDataPresenter = null;
				this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.MyDataPresenter = null;
				this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.MyDataPresenter = null;
				num2 = (short)39657440;
				short num3 = num2;
				num2 = (short)552280032;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1049362432;
					if (num2 != 0)
					{
					}
					num2 = (short)1290993664;
					short num4 = num2;
					num2 = (short)2070020096;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x002524E0 File Offset: 0x002506E0
		public override void SetDataContext()
		{
			short num = (short)291045376;
			short num2 = num;
			num = (short)1194214326;
			short num3 = num;
			num = (short)2093106102;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_ED:
				num = (short)1471021057;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1904476160;
				if (num != 0)
				{
				}
				num = (short)268369920;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			object feature;
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)371720193;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_E2;
					}
					continue;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2055);
					num = (short)404815876;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)222822403;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSecureKMFProfile).MySecondaryRecordsetDataSource = null;
					num = (short)150601734;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2055);
					num = (short)950468613;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_115;
				case 5:
					if (feature != null)
					{
						num = (short)2133721096;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_1B8;
				case 7:
					goto IL_115;
				case 8:
					goto IL_229;
				}
				goto IL_E2;
				IL_115:
				this.RecNavToolbarPageSecureKMFProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1481441282;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_E2:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					goto IL_ED;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2055);
				num = (short)1301020679;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1B8:
			return;
			IL_229:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSecureKMFProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0025271C File Offset: 0x0025091C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)873201664;
			switch (num)
			{
			default:
			{
				num = (short)1499136000;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						continue;
					case 1:
						goto IL_379;
					case 2:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)2134048781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					}
					case 3:
						num = (short)1900871687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner secureHardwareEncryptionKeyReferencesListInner;
						if (secureHardwareEncryptionKeyReferencesListInner != null)
						{
							num = (short)2133131295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)555155464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2DC;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1770389537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					}
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("黋ꯍ돏鳑뗓ꃕ賗뗙돛닝苟菡難뛥觧跩觫뷭闯釱至蓵鷷뇹뇻룽僿瀁欃怅愇昉椋", a_))
						{
							num = (short)763101212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_491;
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)670957602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					}
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner secureHardwareEncryptionIndependentKeyListInner;
						collectionView.MoveCurrentTo(secureHardwareEncryptionIndependentKeyListInner);
						num = (short)825294866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)1516175365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1259339796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("黋ꯍ돏鳑뗓ꃕ賗뗙돛닝苟菡難ꏥ郧髩跫胭铯韱蛳ꗵ鷷駹觻賽旿䤁䤃䀅堇砉挋栍礏縑焓䔕紗礙椛氝䔟模䔣吥䰧崩䴫尭唯眱娳唵䨷䌹䰻䨽⤿ⵁ⩃ཅ♇⹉⥋㹍㕏㱑こ㍕㙗⹙᝛㭝ᥟ⹡ൣᕥᱧ㹩൫౭ᱯ᝱", a_))
						{
							num = (short)950403111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner secureHardwareEncryptionKeyReferencesListInner = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner)collectionView2.CurrentItem;
						num = (short)1609367556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_491;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.IsCurrentAfterLast)
						{
							num = (short)705363978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView2.MoveCurrentToFirst();
						num = (short)1333264405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_54F;
					case 17:
						goto IL_705;
					case 18:
						goto IL_576;
					case 19:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)326238237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1808990230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2100822043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_2DC;
					case 22:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.MyRecordsetDataSource;
						num = (short)730923010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)2147090433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num = (short)78512129;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)886571031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)99549200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner secureHardwareEncryptionIndependentKeyListInner;
						if (secureHardwareEncryptionIndependentKeyListInner != null)
						{
							num = (short)1989869577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)397779990;
						short num3 = num;
						num = (short)850568214;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							num = (short)740556800;
							if (num != 0)
							{
							}
							num = (short)228327430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 26:
						goto IL_3A2;
					case 27:
						goto IL_705;
					case 28:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3 = this.RecNavToolbarPageSecureKMFProfile.MyRecordsetDataSource;
						num = (short)933625892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner secureHardwareEncryptionIndependentKeyListInner = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner)collectionView.CurrentItem;
						num = (short)2121859097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource3.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)38404110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner secureHardwareEncryptionKeyReferencesListInner;
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentTo(secureHardwareEncryptionKeyReferencesListInner);
						num = (short)1989017635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("黋ꯍ돏鳑뗓ꃕ賗뗙돛닝苟菡難ꏥ郧髩跫胭铯韱蛳ꗵ鷷駹觻賽旿䤁䤃䀅堇砉挋栍礏縑焓䔕紗礙椛氝䔟模䔣吥䰧崩䴫尭唯眱娳唵䨷䌹䰻䨽⤿ⵁ⩃൅ⵇ㍉ṋ⭍㙏㝑♓㍕㙗㥙㥛ⵝⱟୡᝣብ㱧୩๫ɭᕯ", a_))
						{
							num = (short)1237254155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					case 33:
						num = (short)219938840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)549715983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_2DC;
					case 36:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)706150430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_491;
					}
					case 37:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1571684390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1743519770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.MyRecordsetDataSource;
						num = (short)1616379923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						num = (short)757530624;
						short num4 = num;
						num = (short)1857486885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_EC;
					IL_F7:
					num = (short)1428619267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						goto IL_F7;
					}
					return;
					IL_2DC:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)831520785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_491:
					num = (short)1664024608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_705:
					num = (short)321388556;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D0:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_379:
				goto IL_2D0;
				IL_3A2:
				return;
				IL_54F:
				IL_576:
				goto IL_2D0;
			}
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00252EB4 File Offset: 0x002510B4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1592918016;
			short num2 = num;
			num = (short)830668801;
			if (num != 0)
			{
			}
			num = (short)1989042891;
			short num3 = num;
			num = (short)630022859;
			switch (num3 == num)
			{
			}
			num = (short)897187840;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00252F64 File Offset: 0x00251164
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)534052864;
			short num2 = num;
			num = (short)1138403654;
			short num3 = num;
			num = (short)1496295750;
			switch (num3 == num)
			{
			}
			num = (short)1210449921;
			if (num != 0)
			{
			}
			num = (short)552402944;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0025301C File Offset: 0x0025121C
		internal void OnExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1245053676;
				short num2 = num;
				num = (short)156107500;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)402325504;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.SyncDataSources();
						num = (short)762970113;
						if (num != 0)
						{
						}
						num = (short)1893859330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (myRecordsetDataSource != null)
						{
							num = (short)597491712;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					case 2:
						goto IL_128;
					}
					goto IL_66;
				}
			}
			IL_128:
			IL_12A:
			num = (short)2061500416;
			short num4 = num;
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.TableMode = false;
			return;
			IL_66:
			item = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.MyRecordsetDataSource;
			num = (short)183500801;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00253188 File Offset: 0x00251388
		internal void OnExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1628061542;
				short num2 = num;
				num = (short)863911782;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_127;
				default:
					num = (short)225050624;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.SyncDataSources();
						num = (short)2003435522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (myRecordsetDataSource != null)
						{
							num = (short)2096955392;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_127;
					case 2:
						goto IL_FD;
					}
					goto IL_65;
				}
			}
			IL_FD:
			num = (short)621084673;
			if (num != 0)
			{
			}
			IL_127:
			num = (short)495583232;
			short num4 = num;
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.TableMode = false;
			return;
			IL_65:
			item = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.MyRecordsetDataSource;
			num = (short)1879638017;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x002532F4 File Offset: 0x002514F4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)1028653057;
			if (num != 0)
			{
			}
			if (this.b)
			{
				num = (short)917723124;
				short num2 = num;
				num = (short)1709856756;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1035206656;
					short num3 = num;
					num = (short)867368960;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽珿朁會猅稇漉⤋㰍‏焑笓砕縗猙笛欝刟䌡倣伥䜧䐩̫崭唯儱䄳䐵崷Ἱ฻฽⬿⽁≃捅穇穉㱋㱍㽏㑑㵓㩕㵗留⽛㭝͟ᝡᙣͥͧݩ੫ṭɯᵱታήᑷό剻ٽ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x002533D4 File Offset: 0x002515D4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)27590657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1981612034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_AC8;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_4EE;
				case 2:
					goto IL_ACD;
				case 3:
				case 4:
				case 5:
				case 6:
					goto IL_15DD;
				case 7:
					goto IL_11F7;
				case 8:
					goto IL_782;
				case 9:
					goto IL_144F;
				case 10:
					goto IL_69F;
				case 11:
					goto IL_9D0;
				case 12:
					goto IL_14F2;
				case 13:
					goto IL_FB5;
				case 14:
					goto IL_CF8;
				case 15:
					goto IL_136B;
				case 16:
					goto IL_E07;
				case 17:
					goto IL_14A7;
				case 18:
					goto IL_1211;
				case 19:
					goto IL_D8B;
				case 20:
					goto IL_7DA;
				case 21:
					goto IL_148D;
				case 22:
					goto IL_E14;
				case 23:
					goto IL_FF3;
				case 24:
					goto IL_99F;
				case 25:
					goto IL_110C;
				case 26:
					goto IL_1024;
				case 27:
					goto IL_12D8;
				case 28:
					goto IL_F77;
				case 29:
					goto IL_FD9;
				case 30:
					goto IL_9F4;
				case 31:
					goto IL_9AC;
				case 32:
					goto IL_42A;
				case 33:
					goto IL_E21;
				case 34:
					goto IL_8A4;
				case 35:
					goto IL_B8E;
				case 36:
					goto IL_7C0;
				case 37:
					goto IL_1269;
				case 38:
					goto IL_52C;
				case 39:
					goto IL_749;
				case 40:
					goto IL_7E7;
				case 41:
					goto IL_11DD;
				case 42:
					goto IL_10B7;
				case 43:
					goto IL_859;
				case 44:
					goto IL_15B9;
				case 45:
					goto IL_FE6;
				case 46:
					goto IL_51F;
				case 47:
					goto IL_12E5;
				case 48:
					goto IL_153D;
				case 49:
					goto IL_1480;
				case 50:
					goto IL_3F9;
				case 51:
					goto IL_623;
				case 52:
					goto IL_F6A;
				case 53:
					goto IL_818;
				case 54:
					goto IL_550;
				case 55:
					goto IL_992;
				case 56:
					goto IL_475;
				case 57:
					goto IL_E6F;
				case 58:
					goto IL_7B3;
				case 59:
					goto IL_685;
				case 60:
					goto IL_678;
				case 61:
					goto IL_11AC;
				case 62:
					goto IL_1316;
				case 63:
					goto IL_EC7;
				case 64:
					goto IL_D05;
				case 65:
					goto IL_1442;
				case 66:
					goto IL_C31;
				case 67:
					goto IL_66B;
				case 68:
					goto IL_1090;
				case 69:
					goto IL_1428;
				case 70:
					goto IL_BC2;
				case 71:
					goto IL_1000;
				case 72:
					goto IL_5FF;
				case 73:
					goto IL_1473;
				case 74:
					goto IL_F29;
				case 75:
					goto IL_1557;
				case 76:
					goto IL_6E7;
				case 77:
					goto IL_B46;
				case 78:
					goto IL_88A;
				case 79:
					goto IL_A72;
				case 80:
					goto IL_DBC;
				case 81:
					goto IL_A27;
				case 82:
					goto IL_718;
				case 83:
					goto IL_C3E;
				case 84:
					goto IL_12BE;
				case 85:
					goto IL_EBA;
				case 86:
					goto IL_906;
				case 87:
					goto IL_1523;
				case 88:
					goto IL_14CE;
				case 89:
					goto IL_DC9;
				case 90:
					goto IL_577;
				case 91:
					goto IL_584;
				case 92:
					goto IL_154A;
				case 93:
					goto IL_F36;
				case 94:
					goto IL_8E2;
				case 95:
					goto IL_B22;
				case 96:
					goto IL_913;
				case 97:
					goto IL_947;
				case 98:
					goto IL_1378;
				case 99:
					goto IL_D7E;
				case 100:
					goto IL_1392;
				case 101:
					goto IL_4CA;
				case 102:
					goto IL_13B6;
				case 103:
					goto IL_B15;
				case 104:
					goto IL_93A;
				case 105:
					goto IL_116E;
				case 106:
					goto IL_6C3;
				case 107:
					goto IL_B6A;
				case 108:
					goto IL_10AA;
				case 109:
					goto IL_DFA;
				case 110:
					goto IL_E93;
				case 111:
					goto IL_1242;
				case 112:
					goto IL_F84;
				case 113:
					goto IL_1588;
				case 114:
					goto IL_692;
				case 115:
					goto IL_A7F;
				case 116:
					goto IL_119F;
				case 117:
					goto IL_E55;
				case 118:
					goto IL_D5A;
				case 119:
					goto IL_C00;
				case 120:
					goto IL_1530;
				case 121:
					goto IL_920;
				case 122:
					goto IL_F5D;
				case 123:
					goto IL_897;
				case 124:
					goto IL_1323;
				case 125:
					goto IL_AF1;
				case 126:
					goto IL_985;
				case 127:
					goto IL_1161;
				case 128:
					goto IL_3EC;
				case 129:
					goto IL_8D5;
				case 130:
					goto IL_129A;
				case 131:
					goto IL_954;
				case 132:
					goto IL_1154;
				case 133:
					goto IL_468;
				case 134:
					goto IL_109D;
				case 135:
					goto IL_87D;
				case 136:
					goto IL_7F4;
				case 137:
					goto IL_C96;
				case 138:
					goto IL_149A;
				case 139:
					goto IL_140E;
				case 140:
					goto IL_C6F;
				case 141:
					goto IL_BA8;
				case 142:
					goto IL_BB5;
				case 143:
					goto IL_A65;
				case 144:
					goto IL_5DB;
				case 145:
					goto IL_13EA;
				case 146:
					goto IL_12CB;
				case 147:
					goto IL_EEB;
				case 148:
					goto IL_E2E;
				case 149:
					goto IL_A58;
				case 150:
					goto IL_CBA;
				case 151:
					goto IL_A34;
				case 152:
					goto IL_D29;
				case 153:
					goto IL_44E;
				case 154:
					goto IL_C89;
				case 155:
					goto IL_E48;
				case 156:
					goto IL_BDC;
				case 157:
					goto IL_3C8;
				case 158:
					goto IL_15AC;
				case 159:
					goto IL_C62;
				case 160:
					goto IL_DAF;
				case 161:
					goto IL_CDE;
				case 162:
					goto IL_12F2;
				case 163:
					goto IL_A8C;
				case 164:
					goto IL_141B;
				case 165:
					goto IL_C24;
				case 166:
					goto IL_70B;
				case 167:
					goto IL_832;
				case 168:
					goto IL_8B1;
				case 169:
					goto IL_117B;
				case 170:
					goto IL_1235;
				case 171:
					goto IL_1385;
				case 172:
					goto IL_F50;
				case 173:
					goto IL_7CD;
				case 174:
					goto IL_1048;
				case 175:
					goto IL_978;
				case 176:
					goto IL_1435;
				case 177:
					goto IL_11EA;
				case 178:
					goto IL_56A;
				case 179:
					goto IL_B9B;
				case 180:
					goto IL_13C3;
				case 181:
					goto IL_41D;
				case 182:
					goto IL_BCF;
				case 183:
					goto IL_647;
				case 184:
					goto IL_825;
				case 185:
					goto IL_11B9;
				case 186:
					goto IL_83F;
				case 187:
					goto IL_1130;
				case 188:
					goto IL_E3B;
				case 189:
					goto IL_106C;
				case 190:
					goto IL_124F;
				case 191:
					goto IL_73C;
				case 192:
					goto IL_84C;
				case 193:
					goto IL_C7C;
				case 194:
					goto IL_499;
				case 195:
					goto IL_14B4;
				case 196:
					goto IL_EA0;
				case 197:
					goto IL_CEB;
				case 198:
					goto IL_14C1;
				case 199:
					goto IL_55D;
				case 200:
					goto IL_92D;
				case 201:
					goto IL_45B;
				case 202:
					goto IL_7A6;
				case 203:
					goto IL_1564;
				case 204:
					goto IL_FA8;
				case 205:
					goto IL_10C4;
				case 206:
					goto IL_E62;
				case 207:
					goto IL_F43;
				case 208:
					goto IL_D36;
				case 209:
					goto IL_F1C;
				case 210:
					goto IL_EF8;
				case 211:
					goto IL_128D;
				case 212:
					goto IL_13D0;
				case 213:
					goto IL_1516;
				case 214:
					goto IL_13DD;
				case 215:
					goto IL_EAD;
				case 216:
					goto IL_4BD;
				case 217:
					goto IL_10E8;
				case 218:
					goto IL_1347;
				case 219:
					goto IL_1204;
				case 220:
					goto IL_125C;
				case 221:
					goto IL_DED;
				default:
					num = (short)453771264;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_3C8:
			this.SecKmfProfDataTransportSubscriberOTARPort_A9226 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfDataTransportSubscriberOTARPort_A9226.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3EC:
			this.SecKmfProfASTROOTARInformationResponseKind_A8947Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F9:
			this.LblSecKmfProfUserSelectable_43657 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfUserSelectable_43657.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41D:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_42A:
			this.SecKmfProfileInfiniteUKEKRetention_43651 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfileInfiniteUKEKRetention_43651.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_44E:
			this.CpyBtnSecKmfProfDataTransportKMFUDPPort_A8384 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_45B:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_468:
			this.CpyBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_475:
			this.LblSecKmfProfErasePreviousOnUserChange_43658 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfErasePreviousOnUserChange_43658.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_499:
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable.ModeClick += this.OnModeClick;
			return;
			IL_4BD:
			this.CVBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4CA:
			this.SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4EE:
			((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.PageSecureKMFProfile)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.PageSecureKMFProfile)target).Unloaded += this.OnUnloaded;
			return;
			IL_51F:
			this.CpyBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_52C:
			this.SecKmfProfOTARGenerateKeyLossKey_43652 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfOTARGenerateKeyLossKey_43652.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_550:
			this.SecKmfProfUserSelectable_43657Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_55D:
			this.SecProfIndependMultikeyListKeyName_43595_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_56A:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_577:
			this.RTDBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_584:
			num = (short)65066332;
			short num3 = num;
			num = (short)1300157788;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B6A:
				this.SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = (global::AcpUI.AcpComboBox)target;
				this.SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				num = (short)479592448;
				if (num != 0)
				{
				}
				this.CpyBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = (global::AcpUI.AcpCopyButton)target;
				return;
			}
			IL_5DB:
			this.LblSecKmfProfDataTransportKMFIPAddress_A8375 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfDataTransportKMFIPAddress_A8375.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5FF:
			this.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = (global::AcpUI.AcpTextBox)target;
			this.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_623:
			this.SecKmfProfUserSelectable_43657 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfUserSelectable_43657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_647:
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = (global::AcpUI.AcpLabel)target;
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_66B:
			this.SecKmfProfileSecureProfileGUID_43662Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_678:
			this.SecKmfProfErasePreviousOnUserChange_43658Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_685:
			this.CpyBtnSecKmfProfErasePreviousOnUserChange_43658 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_692:
			this.RTDBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_69F:
			this.HLinkDataTransport = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataTransport.Click += this.HLinkClick;
			return;
			IL_6C3:
			this.LblSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6E7:
			this.LblSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_70B:
			this.SecKmfProfDataTransportOTARTransportComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_718:
			this.LblSecKmfProfRadioInhibitViaASTROOTAR_43690 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfRadioInhibitViaASTROOTAR_43690.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_73C:
			this.CpyBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_749:
			num = (short)1742602240;
			short num4 = num;
			this.RTDBtnSecKmfProfOTARGenerateKeyLossKey_43652 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_782:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_7A6:
			this.gridExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7B3:
			this.RTDBtnSecKmfProfErasePreviousOnUserChange_43658 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7C0:
			this.CVBtnSecKmfProfOTARGenerateKeyLossKey_43652 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7CD:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesList = (global::AcpUI.AcpExpander)target;
			return;
			IL_7DA:
			this.RTDBtnSecKmfProfGenIndependentKeyList_43597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7E7:
			this.CpyBtnSecKmfProfOTARGenerateKeyLossKey_43652 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7F4:
			this.LblSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_818:
			this.CpyBtnSecKmfProfUserSelectable_43657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_825:
			this.CVBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_832:
			this.CVBtnSecKmfProfDataTransportKMFBroadbandId = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_83F:
			this.RTDBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_84C:
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_859:
			this.LblSecKmfProfKVLFIPSLevel3ApprovedMode_43653 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfKVLFIPSLevel3ApprovedMode_43653.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_87D:
			this.CVBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_88A:
			this.RTDBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_897:
			this.CVBtnSecKmfProfASTROOTARInformationResponseKind_A8947 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A4:
			this.CpyBtnSecKmfProfileInfiniteUKEKRetention_43651 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8B1:
			this.LblSecKmfProfDataTransportKMFBroadbandId = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfDataTransportKMFBroadbandId.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D5:
			this.CVBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8E2:
			this.LblSecKmfProfASTROOTARInformationNumberofAttempts_A8576 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationNumberofAttempts_A8576.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_906:
			this.SecKmfProfRadioInhibitViaASTROOTAR_43690Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_913:
			this.RTDBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_920:
			this.CpyBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92D:
			this.SecProfIndependMultikeyListCKR_43594_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_93A:
			this.SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_947:
			this.CpyBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_954:
			this.SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_978:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_985:
			this.RTDBtnSecKmfProfASTROOTARInformationResponseKind_A8947 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_992:
			this.CVBtnSecKmfProfErasePreviousOnUserChange_43658 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_99F:
			this.CVBtnSecKmfProfKeyListMgmtEraseAllKeys_43650 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9AC:
			this.LblSecKmfProfileInfiniteUKEKRetention_43651 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfileInfiniteUKEKRetention_43651.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9D0:
			this.HLinkSecureHardwareEncryptionKeyReferencesList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecureHardwareEncryptionKeyReferencesList.Click += this.HLinkClick;
			return;
			IL_9F4:
			num = (short)275251201;
			if (num != 0)
			{
			}
			this.CVBtnSecKmfProfileInfiniteUKEKRetention_43651 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A27:
			this.CVBtnSecKmfProfRadioInhibitViaASTROOTAR_43690 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A34:
			this.SecKmfProfDataTransportKMFUDPPort_A8384 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfDataTransportKMFUDPPort_A8384.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A58:
			this.CVBtnSecKmfProfDataTransportKMFUDPPort_A8384 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A65:
			this.CVBtnSecKmfProfDataTransportKMFIPAddress_A8375 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A72:
			this.CpyBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A7F:
			this.CpyBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A8C:
			this.SecKmfProfDataTransportOTARTransport = (global::AcpUI.AcpComboBox)target;
			this.SecKmfProfDataTransportOTARTransport.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AC8:
			goto IL_15DD;
			IL_ACD:
			this.RecNavToolbarPageSecureKMFProfile = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageSecureKMFProfile.ModeClick += this.OnModeClick;
			return;
			IL_AF1:
			this.SecKmfProfASTROOTARInformationResponseKind_A8947 = (global::AcpUI.AcpComboBox)target;
			this.SecKmfProfASTROOTARInformationResponseKind_A8947.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B15:
			this.CpyBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B22:
			this.SecKmfProfASTROOTARInformationNumberofAttempts_A8576 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfASTROOTARInformationNumberofAttempts_A8576.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B46:
			this.SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B8E:
			this.SecKmfProfileInfiniteUKEKRetention_43651Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B9B:
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BA8:
			this.ExpanderSecureKMFProfileDataTransport = (global::AcpUI.AcpExpander)target;
			return;
			IL_BB5:
			this.GrpBoxExpanderSecureKMFProfileDataTransportPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BC2:
			this.CVBtnSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BCF:
			this.gridExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BDC:
			this.LblSecKmfProfDataTransportSubscriberOTARPort_A9226 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfDataTransportSubscriberOTARPort_A9226.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C00:
			this.SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C24:
			this.CpyBtnSecKmfProfDataTransportOTARTransport = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C31:
			this.CpyBtnSecKmfProfileSecureProfileGUID_43662 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C3E:
			this.SecKmfProfRadioInhibitViaASTROOTAR_43690 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfRadioInhibitViaASTROOTAR_43690.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C62:
			this.CpyBtnSecKmfProfDataTransportSubscriberOTARPort_A9226 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C6F:
			this.SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_C7C:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyList = (global::AcpUI.AcpExpander)target;
			return;
			IL_C89:
			this.SecKmfProfDataTransportKMFUDPPort_A8384Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C96:
			this.SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CBA:
			this.LblSecKmfProfDataTransportKMFUDPPort_A8384 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfDataTransportKMFUDPPort_A8384.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CDE:
			this.CVBtnSecKmfProfDataTransportOTARTransport = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CEB:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_CF8:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_D05:
			this.SecKmfProfileSecureProfileGUID_43662 = (global::AcpUI.AcpLabel)target;
			this.SecKmfProfileSecureProfileGUID_43662.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D29:
			this.RTDBtnSecKmfProfDataTransportKMFUDPPort_A8384 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D36:
			this.SecProfIndependMultikeyListCKR_43594 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecProfIndependMultikeyListCKR_43594.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D5A:
			this.LblSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D7E:
			this.CVBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D8B:
			this.SecKmfProfGenIndependentKeyList_43597 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfGenIndependentKeyList_43597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DAF:
			this.SecKmfProfDataTransportSubscriberOTARPort_A9226Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DBC:
			this.SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_DC9:
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DED:
			this.SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DFA:
			this.CpyBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E07:
			this.GrpBoxExpanderSecureKMFProfileGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E14:
			this.SecKmfProfGenIndependentKeyList_43597Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E21:
			this.RTDBtnSecKmfProfileInfiniteUKEKRetention_43651 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E2E:
			this.SecKmfProfDataTransportKMFIPAddress_A8375Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E3B:
			this.CVBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E48:
			this.CVBtnSecKmfProfDataTransportSubscriberOTARPort_A9226 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E55:
			this.CVBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E62:
			this.CpyBtnSecProfIndependMultikeyListKeyName_43595 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E6F:
			this.SecKmfProfErasePreviousOnUserChange_43658 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfErasePreviousOnUserChange_43658.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E93:
			this.SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EA0:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_EAD:
			this.GrpBoxExpanderSecureKMFProfileLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EBA:
			this.CpyBtnSecKmfProfRadioInhibitViaASTROOTAR_43690 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EC7:
			this.LblSecKmfProfileSecureProfileGUID_43662 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfileSecureProfileGUID_43662.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EEB:
			this.CpyBtnSecKmfProfDataTransportKMFIPAddress_A8375 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EF8:
			this.LblSecProfIndependMultikeyListCKR_43594 = (global::AcpUI.AcpLabel)target;
			this.LblSecProfIndependMultikeyListCKR_43594.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F1C:
			this.CVBtnSecProfIndependMultikeyListCKR_43594 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F29:
			this.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F36:
			this.CVBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F43:
			this.SecProfIndependMultikeyListKeyName_43595Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F50:
			this.SecKmfProfDataTransportKMFBroadbandIdComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F5D:
			this.SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F6A:
			this.RTDBtnSecKmfProfUserSelectable_43657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F77:
			this.CpyBtnSecKmfProfKeyListMgmtEraseAllKeys_43650 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F84:
			this.LblSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FA8:
			this.CVBtnSecProfIndependMultikeyListKeyName_43595 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FB5:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_FD9:
			this.SecKmfProfKeyListMgmtEraseAllKeys_43650Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_FE6:
			this.RTDBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FF3:
			this.GrpBoxExpanderSecureKMFProfileGeneralKeyListManagement = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1000:
			this.LblSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1024:
			this.SecKmfProfKeyListMgmtEraseAllKeys_43650 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfKeyListMgmtEraseAllKeys_43650.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1048:
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable.ModeClick += this.OnModeClick;
			return;
			IL_106C:
			this.LblSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1090:
			this.ExpanderSecureKMFProfileASTROOTARInformation = (global::AcpUI.AcpExpander)target;
			return;
			IL_109D:
			this.SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10AA:
			this.RTDBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10B7:
			this.CVBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10C4:
			this.LblSecProfIndependMultikeyListKeyName_43595 = (global::AcpUI.AcpLabel)target;
			this.LblSecProfIndependMultikeyListKeyName_43595.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10E8:
			this.LblSecKmfProfLabtoolLastUserSelectedProfileKey_A8416 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfLabtoolLastUserSelectedProfileKey_A8416.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_110C:
			this.LblSecKmfProfKeyListMgmtEraseAllKeys_43650 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfKeyListMgmtEraseAllKeys_43650.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1130:
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = (global::AcpUI.AcpComboBox)target;
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1154:
			this.RTDBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1161:
			this.CpyBtnSecKmfProfASTROOTARInformationResponseKind_A8947 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_116E:
			this.CVBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_117B:
			this.SecKmfProfDataTransportKMFBroadbandId = (global::AcpUI.AcpTextBox)target;
			this.SecKmfProfDataTransportKMFBroadbandId.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_119F:
			this.SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11AC:
			this.GrpBoxExpanderSecureKMFProfileGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_11B9:
			this.LblSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11DD:
			this.SecKmfProfOTARGenerateKeyLossKey_43652Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_11EA:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_11F7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_1204:
			this.RTDBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1211:
			this.LblSecKmfProfGenIndependentKeyList_43597 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfGenIndependentKeyList_43597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1235:
			this.RTDBtnSecKmfProfDataTransportKMFBroadbandId = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1242:
			this.CVBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_124F:
			this.RTDBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_125C:
			this.CpyBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1269:
			this.LblSecKmfProfOTARGenerateKeyLossKey_43652 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfOTARGenerateKeyLossKey_43652.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_128D:
			this.RTDBtnSecProfIndependMultikeyListCKR_43594 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_129A:
			this.LblSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12BE:
			this.RTDBtnSecKmfProfRadioInhibitViaASTROOTAR_43690 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12CB:
			this.RTDBtnSecKmfProfDataTransportKMFIPAddress_A8375 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12D8:
			this.RTDBtnSecKmfProfKeyListMgmtEraseAllKeys_43650 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12E5:
			this.SecKmfProfKVLFIPSLevel3ApprovedMode_43653Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_12F2:
			this.LblSecKmfProfDataTransportOTARTransport = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfDataTransportOTARTransport.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1316:
			this.CVBtnSecKmfProfileSecureProfileGUID_43662 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1323:
			this.LblSecKmfProfASTROOTARInformationResponseKind_A8947 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationResponseKind_A8947.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1347:
			this.SecKmfProfLabtoolLastUserSelectedProfileKey_A8416 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecKmfProfLabtoolLastUserSelectedProfileKey_A8416.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_136B:
			this.ExpanderSecureKMFProfileGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_1378:
			this.SecKmfProfASTROOTARInformationNumberofAttempts_A8576Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1385:
			this.CpyBtnSecKmfProfDataTransportKMFBroadbandId = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1392:
			this.LblSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13B6:
			this.RTDBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13C3:
			this.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13D0:
			this.CpyBtnSecProfIndependMultikeyListCKR_43594 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13DD:
			this.ExpanderSecureKMFProfileLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_13EA:
			this.SecKmfProfDataTransportKMFIPAddress_A8375 = (global::AcpUI.AcpTextBox)target;
			this.SecKmfProfDataTransportKMFIPAddress_A8375.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_140E:
			this.CpyBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_141B:
			this.RTDBtnSecKmfProfDataTransportOTARTransport = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1428:
			this.GrpBoxExpanderSecureKMFProfileASTROOTARInformationPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1435:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1442:
			this.RTDBtnSecKmfProfileSecureProfileGUID_43662 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_144F:
			this.HLinkASTROOTARInformation = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTROOTARInformation.Click += this.HLinkClick;
			return;
			IL_1473:
			this.CpyBtnSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1480:
			this.CVBtnSecKmfProfUserSelectable_43657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_148D:
			this.CpyBtnSecKmfProfGenIndependentKeyList_43597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_149A:
			this.RTDBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14A7:
			this.CVBtnSecKmfProfGenIndependentKeyList_43597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14B4:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_14C1:
			this.ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_14CE:
			this.LblSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = (global::AcpUI.AcpLabel)target;
			this.LblSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14F2:
			this.HLinkSecureHardwareEncryptionIndependentKeyList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecureHardwareEncryptionIndependentKeyList.Click += this.HLinkClick;
			return;
			IL_1516:
			this.SecProfIndependMultikeyListCKR_43594Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1523:
			this.CVBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1530:
			this.RTDBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_153D:
			this.GrpBoxExpanderSecureKMFProfileGeneralKeyset = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_154A:
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1557:
			this.CVBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1564:
			this.SecProfIndependMultikeyListKeyName_43595 = (global::AcpUI.AcpTextBox)target;
			this.SecProfIndependMultikeyListKeyName_43595.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1588:
			this.SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = (global::AcpUI.AcpComboBox)target;
			this.SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15AC:
			this.RTDBtnSecKmfProfDataTransportSubscriberOTARPort_A9226 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15B9:
			this.SecKmfProfKVLFIPSLevel3ApprovedMode_43653 = (global::AcpUI.AcpCheckBox)target;
			this.SecKmfProfKVLFIPSLevel3ApprovedMode_43653.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15DD:
			this.b = true;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x002549C8 File Offset: 0x00252BC8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				switch (connectionId)
				{
				case 3:
					goto IL_59;
				case 4:
					goto IL_41;
				case 5:
					goto IL_9B;
				case 6:
				{
					num = (short)2082177920;
					short num2 = num;
					num = (short)1052410752;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E8;
					}
					break;
				}
				}
				break;
			}
			num = (short)1427374081;
			if (num != 0)
			{
			}
			num = (short)440926208;
			short num3 = num;
			return;
			IL_41:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9B:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E8:
			num = (short)1604845568;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000D75 RID: 3445
		private bool a;

		// Token: 0x04000D76 RID: 3446
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageSecureKMFProfile;

		// Token: 0x04000D77 RID: 3447
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000D78 RID: 3448
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000D79 RID: 3449
		internal global::System.Windows.Documents.Hyperlink HLinkASTROOTARInformation;

		// Token: 0x04000D7A RID: 3450
		internal global::System.Windows.Documents.Hyperlink HLinkDataTransport;

		// Token: 0x04000D7B RID: 3451
		internal global::System.Windows.Documents.Hyperlink HLinkSecureHardwareEncryptionKeyReferencesList;

		// Token: 0x04000D7C RID: 3452
		internal global::System.Windows.Documents.Hyperlink HLinkSecureHardwareEncryptionIndependentKeyList;

		// Token: 0x04000D7D RID: 3453
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000D7E RID: 3454
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000D7F RID: 3455
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileGeneral;

		// Token: 0x04000D80 RID: 3456
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileGeneralPseudo0;

		// Token: 0x04000D81 RID: 3457
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D82 RID: 3458
		internal global::AcpUI.AcpLabel LblSecKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D83 RID: 3459
		internal global::AcpUI.AcpCheckBox SecKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D84 RID: 3460
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D85 RID: 3461
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D86 RID: 3462
		internal global::AcpUI.AcpCheckBox SecKmfProfGenIndependentKeyList_43597Comp;

		// Token: 0x04000D87 RID: 3463
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileGeneralKeyListManagement;

		// Token: 0x04000D88 RID: 3464
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D89 RID: 3465
		internal global::AcpUI.AcpLabel LblSecKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D8A RID: 3466
		internal global::AcpUI.AcpCheckBox SecKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D8B RID: 3467
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D8C RID: 3468
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D8D RID: 3469
		internal global::AcpUI.AcpCheckBox SecKmfProfKeyListMgmtEraseAllKeys_43650Comp;

		// Token: 0x04000D8E RID: 3470
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D8F RID: 3471
		internal global::AcpUI.AcpLabel LblSecKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D90 RID: 3472
		internal global::AcpUI.AcpCheckBox SecKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D91 RID: 3473
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D92 RID: 3474
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D93 RID: 3475
		internal global::AcpUI.AcpCheckBox SecKmfProfileInfiniteUKEKRetention_43651Comp;

		// Token: 0x04000D94 RID: 3476
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D95 RID: 3477
		internal global::AcpUI.AcpLabel LblSecKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D96 RID: 3478
		internal global::AcpUI.AcpCheckBox SecKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D97 RID: 3479
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D98 RID: 3480
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D99 RID: 3481
		internal global::AcpUI.AcpCheckBox SecKmfProfOTARGenerateKeyLossKey_43652Comp;

		// Token: 0x04000D9A RID: 3482
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D9B RID: 3483
		internal global::AcpUI.AcpLabel LblSecKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D9C RID: 3484
		internal global::AcpUI.AcpCheckBox SecKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D9D RID: 3485
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D9E RID: 3486
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D9F RID: 3487
		internal global::AcpUI.AcpCheckBox SecKmfProfKVLFIPSLevel3ApprovedMode_43653Comp;

		// Token: 0x04000DA0 RID: 3488
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileGeneralKeyset;

		// Token: 0x04000DA1 RID: 3489
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfUserSelectable_43657;

		// Token: 0x04000DA2 RID: 3490
		internal global::AcpUI.AcpLabel LblSecKmfProfUserSelectable_43657;

		// Token: 0x04000DA3 RID: 3491
		internal global::AcpUI.AcpCheckBox SecKmfProfUserSelectable_43657;

		// Token: 0x04000DA4 RID: 3492
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfUserSelectable_43657;

		// Token: 0x04000DA5 RID: 3493
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfUserSelectable_43657;

		// Token: 0x04000DA6 RID: 3494
		internal global::AcpUI.AcpCheckBox SecKmfProfUserSelectable_43657Comp;

		// Token: 0x04000DA7 RID: 3495
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000DA8 RID: 3496
		internal global::AcpUI.AcpLabel LblSecKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000DA9 RID: 3497
		internal global::AcpUI.AcpCheckBox SecKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000DAA RID: 3498
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000DAB RID: 3499
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000DAC RID: 3500
		internal global::AcpUI.AcpCheckBox SecKmfProfErasePreviousOnUserChange_43658Comp;

		// Token: 0x04000DAD RID: 3501
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileGeneralPseudo2;

		// Token: 0x04000DAE RID: 3502
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfileSecureProfileGUID_43662;

		// Token: 0x04000DAF RID: 3503
		internal global::AcpUI.AcpLabel LblSecKmfProfileSecureProfileGUID_43662;

		// Token: 0x04000DB0 RID: 3504
		internal global::AcpUI.AcpLabel SecKmfProfileSecureProfileGUID_43662;

		// Token: 0x04000DB1 RID: 3505
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfileSecureProfileGUID_43662;

		// Token: 0x04000DB2 RID: 3506
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfileSecureProfileGUID_43662;

		// Token: 0x04000DB3 RID: 3507
		internal global::AcpUI.AcpLabel SecKmfProfileSecureProfileGUID_43662Comp;

		// Token: 0x04000DB4 RID: 3508
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileASTROOTARInformation;

		// Token: 0x04000DB5 RID: 3509
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileASTROOTARInformationPseudo0;

		// Token: 0x04000DB6 RID: 3510
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;

		// Token: 0x04000DB7 RID: 3511
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;

		// Token: 0x04000DB8 RID: 3512
		internal global::AcpUI.AcpTextBox SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;

		// Token: 0x04000DB9 RID: 3513
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;

		// Token: 0x04000DBA RID: 3514
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663Comp;

		// Token: 0x04000DBB RID: 3515
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000DBC RID: 3516
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000DBD RID: 3517
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000DBE RID: 3518
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000DBF RID: 3519
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000DC0 RID: 3520
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978Comp;

		// Token: 0x04000DC1 RID: 3521
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000DC2 RID: 3522
		internal global::AcpUI.AcpLabel LblSecKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000DC3 RID: 3523
		internal global::AcpUI.AcpCheckBox SecKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000DC4 RID: 3524
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000DC5 RID: 3525
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000DC6 RID: 3526
		internal global::AcpUI.AcpCheckBox SecKmfProfRadioInhibitViaASTROOTAR_43690Comp;

		// Token: 0x04000DC7 RID: 3527
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000DC8 RID: 3528
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000DC9 RID: 3529
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000DCA RID: 3530
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000DCB RID: 3531
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000DCC RID: 3532
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Comp;

		// Token: 0x04000DCD RID: 3533
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000DCE RID: 3534
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000DCF RID: 3535
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000DD0 RID: 3536
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000DD1 RID: 3537
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000DD2 RID: 3538
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationNumberofAttempts_A8576Comp;

		// Token: 0x04000DD3 RID: 3539
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000DD4 RID: 3540
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000DD5 RID: 3541
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000DD6 RID: 3542
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000DD7 RID: 3543
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000DD8 RID: 3544
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Comp;

		// Token: 0x04000DD9 RID: 3545
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000DDA RID: 3546
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000DDB RID: 3547
		internal global::AcpUI.AcpComboBox SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000DDC RID: 3548
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000DDD RID: 3549
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000DDE RID: 3550
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674Comp;

		// Token: 0x04000DDF RID: 3551
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000DE0 RID: 3552
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000DE1 RID: 3553
		internal global::AcpUI.AcpComboBox SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000DE2 RID: 3554
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000DE3 RID: 3555
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000DE4 RID: 3556
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677Comp;

		// Token: 0x04000DE5 RID: 3557
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000DE6 RID: 3558
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000DE7 RID: 3559
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000DE8 RID: 3560
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000DE9 RID: 3561
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000DEA RID: 3562
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928Comp;

		// Token: 0x04000DEB RID: 3563
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000DEC RID: 3564
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000DED RID: 3565
		internal global::AcpUI.AcpComboBox SecKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000DEE RID: 3566
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000DEF RID: 3567
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000DF0 RID: 3568
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationResponseKind_A8947Comp;

		// Token: 0x04000DF1 RID: 3569
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000DF2 RID: 3570
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000DF3 RID: 3571
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000DF4 RID: 3572
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000DF5 RID: 3573
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000DF6 RID: 3574
		internal global::AcpUI.AcpLabel SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Comp;

		// Token: 0x04000DF7 RID: 3575
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000DF8 RID: 3576
		internal global::AcpUI.AcpLabel LblSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000DF9 RID: 3577
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000DFA RID: 3578
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000DFB RID: 3579
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000DFC RID: 3580
		internal global::AcpUI.AcpCheckBox SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608Comp;

		// Token: 0x04000DFD RID: 3581
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileDataTransport;

		// Token: 0x04000DFE RID: 3582
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileDataTransportPseudo0;

		// Token: 0x04000DFF RID: 3583
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000E00 RID: 3584
		internal global::AcpUI.AcpLabel LblSecKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000E01 RID: 3585
		internal global::AcpUI.AcpTextBox SecKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000E02 RID: 3586
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000E03 RID: 3587
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000E04 RID: 3588
		internal global::AcpUI.AcpLabel SecKmfProfDataTransportKMFIPAddress_A8375Comp;

		// Token: 0x04000E05 RID: 3589
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000E06 RID: 3590
		internal global::AcpUI.AcpLabel LblSecKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000E07 RID: 3591
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000E08 RID: 3592
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000E09 RID: 3593
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000E0A RID: 3594
		internal global::AcpUI.AcpLabel SecKmfProfDataTransportKMFUDPPort_A8384Comp;

		// Token: 0x04000E0B RID: 3595
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000E0C RID: 3596
		internal global::AcpUI.AcpLabel LblSecKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000E0D RID: 3597
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000E0E RID: 3598
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000E0F RID: 3599
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000E10 RID: 3600
		internal global::AcpUI.AcpLabel SecKmfProfDataTransportSubscriberOTARPort_A9226Comp;

		// Token: 0x04000E11 RID: 3601
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfDataTransportOTARTransport;

		// Token: 0x04000E12 RID: 3602
		internal global::AcpUI.AcpLabel LblSecKmfProfDataTransportOTARTransport;

		// Token: 0x04000E13 RID: 3603
		internal global::AcpUI.AcpComboBox SecKmfProfDataTransportOTARTransport;

		// Token: 0x04000E14 RID: 3604
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfDataTransportOTARTransport;

		// Token: 0x04000E15 RID: 3605
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfDataTransportOTARTransport;

		// Token: 0x04000E16 RID: 3606
		internal global::AcpUI.AcpLabel SecKmfProfDataTransportOTARTransportComp;

		// Token: 0x04000E17 RID: 3607
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfDataTransportKMFBroadbandId;

		// Token: 0x04000E18 RID: 3608
		internal global::AcpUI.AcpLabel LblSecKmfProfDataTransportKMFBroadbandId;

		// Token: 0x04000E19 RID: 3609
		internal global::AcpUI.AcpTextBox SecKmfProfDataTransportKMFBroadbandId;

		// Token: 0x04000E1A RID: 3610
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfDataTransportKMFBroadbandId;

		// Token: 0x04000E1B RID: 3611
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfDataTransportKMFBroadbandId;

		// Token: 0x04000E1C RID: 3612
		internal global::AcpUI.AcpLabel SecKmfProfDataTransportKMFBroadbandIdComp;

		// Token: 0x04000E1D RID: 3613
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesList;

		// Token: 0x04000E1E RID: 3614
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable;

		// Token: 0x04000E1F RID: 3615
		internal global::System.Windows.Controls.Grid ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListGrid;

		// Token: 0x04000E20 RID: 3616
		internal global::System.Windows.Controls.Grid ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableGrid;

		// Token: 0x04000E21 RID: 3617
		internal global::AcpUI.AcpGroupBox ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableTableView;

		// Token: 0x04000E22 RID: 3618
		internal global::AcpUI.AcpXamDataPresenter ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTable;

		// Token: 0x04000E23 RID: 3619
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Col;

		// Token: 0x04000E24 RID: 3620
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Col;

		// Token: 0x04000E25 RID: 3621
		internal global::AcpUI.AcpGroupBox ExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableSRecView;

		// Token: 0x04000E26 RID: 3622
		internal global::System.Windows.Controls.Grid gridExpanderSecureKMFProfileSecureHardwareEncryptionKeyReferencesListTableSRecView;

		// Token: 0x04000E27 RID: 3623
		internal global::AcpUI.AcpLabel SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;

		// Token: 0x04000E28 RID: 3624
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;

		// Token: 0x04000E29 RID: 3625
		internal global::AcpUI.AcpLabel LblSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;

		// Token: 0x04000E2A RID: 3626
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;

		// Token: 0x04000E2B RID: 3627
		internal global::AcpUI.AcpComboBox SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;

		// Token: 0x04000E2C RID: 3628
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;

		// Token: 0x04000E2D RID: 3629
		internal global::AcpUI.AcpLabel LblSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;

		// Token: 0x04000E2E RID: 3630
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;

		// Token: 0x04000E2F RID: 3631
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;

		// Token: 0x04000E30 RID: 3632
		internal global::AcpUI.AcpLabel SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194Comp;

		// Token: 0x04000E31 RID: 3633
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyList;

		// Token: 0x04000E32 RID: 3634
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable;

		// Token: 0x04000E33 RID: 3635
		internal global::System.Windows.Controls.Grid ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListGrid;

		// Token: 0x04000E34 RID: 3636
		internal global::System.Windows.Controls.Grid ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableGrid;

		// Token: 0x04000E35 RID: 3637
		internal global::AcpUI.AcpGroupBox ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableTableView;

		// Token: 0x04000E36 RID: 3638
		internal global::AcpUI.AcpXamDataPresenter ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTable;

		// Token: 0x04000E37 RID: 3639
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecProfIndependMultikeyListKeyName_43595_Col;

		// Token: 0x04000E38 RID: 3640
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecProfIndependMultikeyListCKR_43594_Col;

		// Token: 0x04000E39 RID: 3641
		internal global::AcpUI.AcpGroupBox ExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableSRecView;

		// Token: 0x04000E3A RID: 3642
		internal global::System.Windows.Controls.Grid gridExpanderSecureKMFProfileSecureHardwareEncryptionIndependentKeyListTableSRecView;

		// Token: 0x04000E3B RID: 3643
		internal global::AcpUI.AcpTextBox SecProfIndependMultikeyListKeyName_43595;

		// Token: 0x04000E3C RID: 3644
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecProfIndependMultikeyListKeyName_43595;

		// Token: 0x04000E3D RID: 3645
		internal global::AcpUI.AcpLabel LblSecProfIndependMultikeyListKeyName_43595;

		// Token: 0x04000E3E RID: 3646
		internal global::AcpUI.AcpCopyButton CpyBtnSecProfIndependMultikeyListKeyName_43595;

		// Token: 0x04000E3F RID: 3647
		internal global::AcpUI.AcpLabel SecProfIndependMultikeyListKeyName_43595Comp;

		// Token: 0x04000E40 RID: 3648
		internal global::AcpUI.AcpTextBoxSpinner SecProfIndependMultikeyListCKR_43594;

		// Token: 0x04000E41 RID: 3649
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecProfIndependMultikeyListCKR_43594;

		// Token: 0x04000E42 RID: 3650
		internal global::AcpUI.AcpLabel LblSecProfIndependMultikeyListCKR_43594;

		// Token: 0x04000E43 RID: 3651
		internal global::AcpUI.AcpRtdButton RTDBtnSecProfIndependMultikeyListCKR_43594;

		// Token: 0x04000E44 RID: 3652
		internal global::AcpUI.AcpCopyButton CpyBtnSecProfIndependMultikeyListCKR_43594;

		// Token: 0x04000E45 RID: 3653
		internal global::AcpUI.AcpLabel SecProfIndependMultikeyListCKR_43594Comp;

		// Token: 0x04000E46 RID: 3654
		internal global::AcpUI.AcpExpander ExpanderSecureKMFProfileLabtool;

		// Token: 0x04000E47 RID: 3655
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSecureKMFProfileLabtoolPseudo0;

		// Token: 0x04000E48 RID: 3656
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416;

		// Token: 0x04000E49 RID: 3657
		internal global::AcpUI.AcpLabel LblSecKmfProfLabtoolLastUserSelectedProfileKey_A8416;

		// Token: 0x04000E4A RID: 3658
		internal global::AcpUI.AcpTextBoxSpinner SecKmfProfLabtoolLastUserSelectedProfileKey_A8416;

		// Token: 0x04000E4B RID: 3659
		internal global::AcpUI.AcpRtdButton RTDBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416;

		// Token: 0x04000E4C RID: 3660
		internal global::AcpUI.AcpCopyButton CpyBtnSecKmfProfLabtoolLastUserSelectedProfileKey_A8416;

		// Token: 0x04000E4D RID: 3661
		internal global::AcpUI.AcpLabel SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Comp;

		// Token: 0x04000E4E RID: 3662
		private bool b;
	}
}
