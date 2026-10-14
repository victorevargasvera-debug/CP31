using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using CommonResources;
using Infragistics.Windows;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000215 RID: 533
	public class PageRadioProfiles : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06006018 RID: 24600 RVA: 0x005618CC File Offset: 0x0055FACC
		public PageRadioProfiles()
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

		// Token: 0x06006019 RID: 24601 RVA: 0x00561904 File Offset: 0x0055FB04
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1093140483;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num2)
				{
				case 0:
					goto IL_212;
				case 1:
					goto IL_28F;
				case 2:
				{
					try
					{
						num = (short)1462632454;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)1204748293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)1538916354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (acpExpander != null)
								{
									num = (short)150667267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								base.Expanders.Add(acpExpander);
								num = (short)1511456769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_14E;
							case 5:
								num = (short)1206255620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_9B;
								}
								continue;
							}
							IL_DB:
							num = (short)1588068352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9B:
							goto IL_DB;
						}
						IL_14E:
						goto IL_241;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1B9;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_15D:
							num = (short)518053602;
							short num3 = num;
							num = (short)818601698;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)488570880;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_20F;
								case 1:
									goto IL_1F0;
								case 2:
									if (disposable != null)
									{
										num = (short)697040897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_211;
								}
								goto IL_1B9;
							}
							IL_1F0:
							disposable.Dispose();
							num = (short)1800470528;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_20F:
						IL_211:
						goto EndFinally_7;
						IL_1B9:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1383989250;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_15D;
						EndFinally_7:;
					}
					goto IL_212;
					IL_241:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1911750656;
					short num4 = num;
					num = (short)1506148353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (!this.a)
				{
					num = (short)893255680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2B9;
				IL_212:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)221970434;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_28F:
			num = (short)682754049;
			if (num != 0)
			{
			}
			IL_2B9:
			this.PostOnLoaded(sender, e);
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x00561BFC File Offset: 0x0055FDFC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)603455490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10F;
				case 1:
				{
					num = (short)1643970560;
					short num3 = num;
					base.OnUnloaded(sender, e);
					this.a = false;
					goto IL_FA;
				}
				case 2:
				{
					num = (short)470486517;
					short num4 = num;
					num = (short)1023151605;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FA;
					default:
						num = (short)1702625281;
						if (num != 0)
						{
						}
						num = (short)2021588992;
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
				}
				IL_A3:
				if (this.a)
				{
					num = (short)1346699265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FA:
				num = (short)870514688;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			this.PostOnUnloaded(sender, e);
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x00561D24 File Offset: 0x0055FF24
		public override void SetDataContext()
		{
			short num = (short)476184584;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_118;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)814022660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageRadioProfiles).MySecondaryRecordsetDataSource = null;
					num = (short)184745991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (feature != null)
					{
						num = (short)404160518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)784187806;
					short num3 = num;
					num = (short)821805470;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num = (short)516358144;
						short num4 = num;
						break;
					}
					}
					num = (short)330366976;
					if (num != 0)
					{
					}
					num = (short)812318721;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2077);
					num = (short)940441605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2077);
					num = (short)1516175362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_118;
				case 6:
					goto IL_232;
				case 7:
					goto IL_1C1;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)431292419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2077);
				num = (short)1466564608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				this.RecNavToolbarPageRadioProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)869924865;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C1:
			return;
			IL_232:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageRadioProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x00561F68 File Offset: 0x00560168
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)109772806;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num = (short)1427111941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
					goto IL_19D;
				case 2:
					num = (short)1636958209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
				{
					num = (short)1379991552;
					short num3 = num;
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageRadioProfiles.MyRecordsetDataSource;
					num = (short)1996619776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					num = (short)164823043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				num = (short)360450131;
				short num4 = num;
				num = (short)1448478803;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_19D:
					if (!(((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫뻭釯闱釳ꓵ駷黹闻釽僿瀁欃怅愇昉椋納", a_)))
					{
						return;
					}
					num = (short)513867780;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1999503361;
					if (num != 0)
					{
					}
					num = (short)2054356992;
					if (num != 0)
					{
					}
					if (!(A_0 is global::AcpUI.AcpRecNavToolbar))
					{
						return;
					}
					num = (short)2101280770;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00562150 File Offset: 0x00560350
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1997519790;
			short num2 = num;
			num = (short)1098365870;
			switch (num2 == num)
			{
			}
			num = (short)1885143041;
			if (num != 0)
			{
			}
			num = (short)86441984;
			short num3 = num;
			num = (short)1097728000;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x00562200 File Offset: 0x00560400
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)648153772;
			short num2 = num;
			num = (short)788269740;
			switch (num2 == num)
			{
			}
			num = (short)1843920897;
			if (num != 0)
			{
			}
			num = (short)64225280;
			short num3 = num;
			num = (short)519962624;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x005622B0 File Offset: 0x005604B0
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1533739394;
			short num2 = num;
			num = (short)1469120898;
			switch (num2 == num)
			{
			}
			num = (short)150011905;
			if (num != 0)
			{
			}
			num = (short)2071920640;
			short num3 = num;
			num = (short)7143424;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00562360 File Offset: 0x00560560
		private void PostOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)463405057;
			if (num != 0)
			{
			}
			num = (short)504058698;
			short num2 = num;
			num = (short)1401967434;
			switch (num2 == num)
			{
			}
			num = (short)1282539520;
			short num3 = num;
			num = (short)675414016;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00562410 File Offset: 0x00560610
		private void b()
		{
			short num = (short)1604059149;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1914044420;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2027552770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1F1;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)268697600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.IsVisibleChanged += this.a;
								num = (short)624951297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_177;
								}
								continue;
							}
							IL_1A6:
							num = (short)862388227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_177:
							goto IL_1A6;
						}
						IL_1F1:
						goto IL_521;
					}
					finally
					{
						num = (short)938147842;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_25B;
							case 1:
								enumerator.Dispose();
								num = (short)948895744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_227;
								}
								continue;
							}
							IL_227:
							if (enumerator == null)
							{
								break;
							}
							num = (short)845479937;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_25B:;
					}
					goto IL_25E;
				case 1:
					if (this.e != null)
					{
						num = (short)1067581452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
				case 2:
					global::Infragistics.Windows.Utilities.GetDescendantFromType<global::AcpUI.AcpLabel>(this.GrpBoxExpanderRadioProfilesAudioSettingsSpeakerRXSettings, false, new global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::AcpUI.AcpLabel>(this.a));
					num = (short)1692073990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.f.Count > 0)
					{
						num = (short)1694695432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_521;
				case 4:
				{
					num = (short)724566016;
					short num3 = num;
					num = (short)1179451393;
					if (num != 0)
					{
					}
					num = (short)521994243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					try
					{
						num = (short)713555972;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2082603010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_4B3;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
								if (enumerator.MoveNext())
								{
									enumerator.Current.IsVisibleChanged += this.b;
									num = (short)1504706561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1169384669;
								short num4 = num;
								num = (short)1352230109;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)356319232;
									if (num != 0)
									{
									}
									num = (short)1917648896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_3EB;
								}
								continue;
							}
							IL_41A:
							num = (short)669777923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3EB:
							goto IL_41A;
						}
						IL_4B3:
						goto IL_BE;
					}
					finally
					{
						num = (short)541196290;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_51E;
							case 1:
								enumerator.Dispose();
								num = (short)1194328064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4E9;
								}
								continue;
							}
							IL_4E9:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1787822081;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_51E:;
					}
					goto IL_521;
				case 6:
					if (this.f != null)
					{
						num = (short)607846404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_521;
				case 7:
					if (this.f == null)
					{
						num = (short)1865089026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_521;
				case 8:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator = this.f.GetEnumerator();
					num = (short)2104426496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (this.e.Count > 0)
					{
						num = (short)1713176586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
				case 10:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator = this.e.GetEnumerator();
					num = (short)855310341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_25E;
				case 12:
					num = (short)824639497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				if (this.e == null)
				{
					num = (short)1968439307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BE:
				num = (short)1841037319;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25E:
				global::Infragistics.Windows.Utilities.GetDescendantFromType<global::AcpUI.AcpLabel>(this.GrpBoxExpanderRadioProfilesAudioSettingsMicrophoneTXSettings, false, new global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::AcpUI.AcpLabel>(this.b));
				num = (short)1125253121;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_521:
			this.b(this, default(global::System.Windows.DependencyPropertyChangedEventArgs));
			this.a(this, default(global::System.Windows.DependencyPropertyChangedEventArgs));
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00562994 File Offset: 0x00560B94
		private void b(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)659353985;
			short num2 = num;
			num = (short)2030629249;
			switch (num2 == num)
			{
			}
			num = (short)1097334785;
			if (num != 0)
			{
			}
			num = (short)1834876928;
			short num3 = num;
			num = (short)1721958400;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.Controls.Grid>(this.GrpBoxExpanderRadioProfilesAudioSettingsMicrophoneTXSettings, false, new global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Grid>(this.b));
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00562A54 File Offset: 0x00560C54
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)488739046;
			short num2 = num;
			num = (short)1053724902;
			switch (num2 == num)
			{
			}
			num = (short)535494656;
			if (num != 0)
			{
			}
			num = (short)2079129600;
			short num3 = num;
			num = (short)1374814209;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.Controls.Grid>(this.GrpBoxExpanderRadioProfilesAudioSettingsSpeakerRXSettings, false, new global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Grid>(this.a));
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00562B18 File Offset: 0x00560D18
		private static void c(global::System.Windows.Controls.Grid A_0)
		{
			short num = (short)538771457;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.b = A_0.ColumnDefinitions[2].Width;
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.c = A_0.ColumnDefinitions[5].Width;
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.d = true;
					num = (short)541646079;
					short num3 = num;
					num = (short)1431821567;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10D;
					default:
						num = (short)1416888320;
						if (num != 0)
						{
						}
						num = (short)1089798146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_E4;
				}
				IL_31:
				if (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.d)
				{
					goto IL_10D;
				}
				num = (short)1829568512;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			num = (short)949813249;
			if (num != 0)
			{
			}
			IL_10D:
			num = (short)1923219456;
			short num4 = num;
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00562C5C File Offset: 0x00560E5C
		private bool b(global::AcpUI.AcpLabel A_0)
		{
			short num = (short)1695678467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_171;
				case 1:
					if (A_0.Content != null)
					{
						num = (short)1212481545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1453981697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					if (A_0.Content.ToString().Equals(global::CommonResources.AcgResources.ID_RADIO))
					{
						num = (short)400031751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
				{
					num = (short)388338682;
					short num3 = num;
					num = (short)70816762;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_171;
					default:
						num = (short)425721856;
						if (num != 0)
						{
						}
						num = (short)1977221124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					return false;
				case 7:
					this.e.Add(A_0);
					num = (short)784990214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1782251521;
					if (num != 0)
					{
					}
					num = (short)891944960;
					short num4 = num;
					if (A_0.MyBLObject != null)
					{
						num = (short)1741815810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
					num = (short)944635915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.e = new global::System.Collections.Generic.List<global::AcpUI.AcpLabel>();
					num = (short)943587328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_0.MyBLObject.IgnoreOnPrint)
					{
						num = (short)2112815109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_55:
				if (this.e == null)
				{
					num = (short)418054154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_19C:
				num = (short)414908424;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_171:
				goto IL_19C;
			}
			return false;
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x00562ED4 File Offset: 0x005610D4
		private bool a(global::AcpUI.AcpLabel A_0)
		{
			short num = (short)1146159107;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_19B;
				case 1:
					if (A_0.Content != null)
					{
						num = (short)1683619849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)662306817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)500498433;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 4:
					if (A_0.Content.ToString().Equals(global::CommonResources.AcgResources.ID_RADIO))
					{
						num = (short)815267847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
				{
					num = (short)2054224731;
					short num3 = num;
					num = (short)2006317915;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19B;
					default:
						num = (short)1092354048;
						if (num != 0)
						{
						}
						num = (short)1059717124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					return false;
				case 7:
					this.f.Add(A_0);
					num = (short)1916272646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)2090074112;
					short num4 = num;
					if (A_0.MyBLObject != null)
					{
						num = (short)42598402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
					num = (short)631111691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.f = new global::System.Collections.Generic.List<global::AcpUI.AcpLabel>();
					num = (short)1662713856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_0.MyBLObject.IgnoreOnPrint)
					{
						num = (short)520552453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_7C:
				if (this.f == null)
				{
					num = (short)1996292106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1C5:
				num = (short)1466171400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19B:
				goto IL_1C5;
			}
			return false;
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00563154 File Offset: 0x00561354
		private bool a(global::System.Collections.Generic.IList<global::AcpUI.AcpLabel> A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator = A_0.GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)333185029;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14C;
					case 1:
						goto IL_130;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1094320132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)6750211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (enumerator.Current.IsVisible)
						{
							num = (short)523473276;
							short num3 = num;
							num = (short)1231327612;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_130;
							default:
								num = (short)1862795264;
								if (num != 0)
								{
								}
								num = (short)892600321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					case 4:
						num = (short)786300934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 6:
						goto IL_191;
					}
					IL_76:
					num = (short)403308546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74:
					goto IL_76;
					IL_130:
					result = true;
					num = (short)219021312;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14C:
				num = (short)1511587841;
				if (num != 0)
				{
				}
				return result;
				IL_191:
				goto IL_09;
			}
			finally
			{
				num = (short)323223553;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)649920514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1C8;
						}
						continue;
					case 2:
						goto IL_1FB;
					}
					IL_1C8:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1549533184;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FB:;
			}
			return result;
			IL_09:
			num = (short)1873215488;
			short num4 = num;
			return false;
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0056337C File Offset: 0x0056157C
		private bool b(global::System.Windows.Controls.Grid A_0)
		{
			if (A_0.ColumnDefinitions.Count != 11)
			{
				short num;
				for (;;)
				{
					num = (short)1815871488;
					short num2 = num;
					num = (short)1130500793;
					short num3 = num;
					num = (short)1591153337;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_72;
					}
				}
				IL_72:
				num = (short)898891777;
				if (num != 0)
				{
				}
				num = (short)1318256640;
				if (num != 0)
				{
				}
				return false;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.c(A_0);
			this.a(this.e, A_0);
			return true;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00563450 File Offset: 0x00561650
		private bool a(global::System.Windows.Controls.Grid A_0)
		{
			if (A_0.ColumnDefinitions.Count != 11)
			{
				short num;
				for (;;)
				{
					num = (short)1010368512;
					short num2 = num;
					num = (short)701642416;
					short num3 = num;
					num = (short)1789867696;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)15204353;
				if (num != 0)
				{
				}
				num = (short)1588854784;
				if (num != 0)
				{
				}
				return false;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.c(A_0);
			this.a(this.f, A_0);
			return true;
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00563524 File Offset: 0x00561724
		private void a(global::System.Collections.Generic.IList<global::AcpUI.AcpLabel> A_0, global::System.Windows.Controls.Grid A_1)
		{
			short num = (short)965214209;
			if (num != 0)
			{
			}
			if (this.a(A_0))
			{
				for (;;)
				{
					num = (short)1030160384;
					short num2 = num;
					num = (short)1585735130;
					short num3 = num;
					num = (short)247031258;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_94;
					}
				}
				IL_94:
				num = (short)1482162176;
				if (num != 0)
				{
				}
				A_1.ColumnDefinitions[2].Width = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.b;
				A_1.ColumnDefinitions[5].Width = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles.c;
				return;
			}
			A_1.ColumnDefinitions[2].Width = global::System.Windows.GridLength.Auto;
			A_1.ColumnDefinitions[5].Width = global::System.Windows.GridLength.Auto;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00563634 File Offset: 0x00561834
		private void a()
		{
			short num = (short)533135368;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator = this.e.GetEnumerator();
					num = (short)2027421700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator = this.f.GetEnumerator();
					num = (short)1439629317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (this.f != null)
					{
						num = (short)2047475719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_243;
				case 4:
					try
					{
						num = (short)390594563;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)964427780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)660668416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.IsVisibleChanged -= this.b;
								num = (short)9109506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_305;
								}
								continue;
							case 4:
							{
								num = (short)858279682;
								short num3 = num;
								num = (short)1633111810;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_3B5;
								}
								break;
							}
							}
							IL_335:
							num = (short)1305673729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_305:
							goto IL_335;
						}
						IL_3B5:
						num = (short)1845886977;
						if (num != 0)
						{
						}
						num = (short)1524432896;
						if (num != 0)
						{
						}
						goto IL_94;
					}
					finally
					{
						num = (short)412549121;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)81657858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_427;
								}
								continue;
							case 2:
								goto IL_45E;
							}
							IL_427:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1561722880;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_45E:;
					}
					return;
				case 5:
					try
					{
						num = (short)1025966083;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1547894788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)143327233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.IsVisibleChanged -= this.a;
								num = (short)1693974528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_160;
								}
								continue;
							case 4:
								goto IL_1D8;
							}
							IL_162:
							num = (short)682885122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_160:
							goto IL_162;
						}
						IL_1D8:
						return;
					}
					finally
					{
						num = (short)1181810689;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpLabel> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)826736642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_20D;
								}
								continue;
							case 2:
								goto IL_240;
							}
							IL_20D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)942997504;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_240:;
					}
					goto IL_243;
				case 6:
					if (this.e.Count > 0)
					{
						num = (short)1945698304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				case 7:
				{
					num = (short)2052915200;
					short num4 = num;
					num = (short)509542409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 9:
					if (this.f.Count > 0)
					{
						num = (short)548929537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_4C:
				if (this.e != null)
				{
					num = (short)1188888579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_94:
				num = (short)1675100162;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_243:
				num = (short)1827602438;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00563AD8 File Offset: 0x00561CD8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			short num = (short)913899521;
			if (num != 0)
			{
			}
			if (this.g)
			{
				for (;;)
				{
					num = (short)2057437184;
					short num2 = num;
					num = (short)300319197;
					short num3 = num;
					num = (short)1644134877;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_99;
					}
				}
				IL_99:
				num = (short)390201344;
				if (num != 0)
				{
				}
				return;
			}
			this.g = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2蛤裦蓨鯪苬臮铰鷲致\ud8f6诸髺駼雾渀☂㜄㜆氈礊樌怎缐簒研縖稘栚㠜ⴞᄠ䀢䨤䤦伨䈪䨬娮䌰刲䄴帶嘸唺ሼ䴾⁀❂ⱄ⡆汈祊経㽎⍐㱒㍔㹖㕘㹚⹜灞፠ɢŤ๦٨᭪Ὤnᝰᩲᥴቶ੸啺ռṾ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00563BB8 File Offset: 0x00561DB8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1444216832;
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
					num = (short)551747586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_3746;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_103B;
				case 2:
					goto IL_1716;
				case 3:
					goto IL_102E;
				case 4:
					goto IL_B88;
				case 5:
					goto IL_3B77;
				case 6:
					goto IL_3EC1;
				case 7:
					goto IL_3EF2;
				case 8:
					goto IL_219D;
				case 9:
					goto IL_3376;
				case 10:
					goto IL_3DFA;
				case 11:
					goto IL_3563;
				case 12:
					goto IL_204D;
				case 13:
					goto IL_D3D;
				case 14:
					goto IL_200F;
				case 15:
					goto IL_25E2;
				case 16:
					goto IL_19F1;
				case 17:
					goto IL_3AAB;
				case 18:
					goto IL_F74;
				case 19:
					goto IL_3B03;
				case 20:
					goto IL_CB4;
				case 21:
					goto IL_36FB;
				case 22:
					goto IL_1D72;
				case 23:
					goto IL_1A94;
				case 24:
					goto IL_2098;
				case 25:
					goto IL_3B10;
				case 26:
					goto IL_1BB0;
				case 27:
					goto IL_394B;
				case 28:
					goto IL_1217;
				case 29:
					goto IL_2D07;
				case 30:
					goto IL_271B;
				case 31:
					goto IL_1FDB;
				case 32:
					goto IL_2325;
				case 33:
					goto IL_1502;
				case 34:
					goto IL_3454;
				case 35:
					goto IL_349F;
				case 36:
					goto IL_35A1;
				case 37:
					goto IL_130F;
				case 38:
					goto IL_3793;
				case 39:
					goto IL_367F;
				case 40:
					goto IL_18C8;
				case 41:
					goto IL_21AA;
				case 42:
					goto IL_24AC;
				case 43:
					goto IL_2C29;
				case 44:
					goto IL_29C5;
				case 45:
					goto IL_3867;
				case 46:
					goto IL_2EBF;
				case 47:
					goto IL_27A1;
				case 48:
					goto IL_32C9;
				case 49:
					goto IL_212B;
				case 50:
					goto IL_D95;
				case 51:
					goto IL_3CE8;
				case 52:
					goto IL_1C2C;
				case 53:
					goto IL_127C;
				case 54:
					goto IL_263A;
				case 55:
					goto IL_1A49;
				case 56:
					goto IL_131C;
				case 57:
					goto IL_3B9B;
				case 58:
					goto IL_2AFE;
				case 59:
					goto IL_175E;
				case 60:
					goto IL_3C0D;
				case 61:
					goto IL_3E76;
				case 62:
					goto IL_364E;
				case 63:
					goto IL_3BA8;
				case 64:
					goto IL_20BC;
				case 65:
					goto IL_242D;
				case 66:
					goto IL_1529;
				case 67:
					goto IL_2DB7;
				case 68:
					goto IL_23D5;
				case 69:
					goto IL_35F6;
				case 70:
					goto IL_2B32;
				case 71:
					goto IL_F5A;
				case 72:
					goto IL_3C31;
				case 73:
					goto IL_15FD;
				case 74:
					goto IL_2CA5;
				case 75:
					goto IL_155A;
				case 76:
					goto IL_32ED;
				case 77:
					goto IL_321C;
				case 78:
					goto IL_2F0A;
				case 79:
					goto IL_33AA;
				case 80:
					goto IL_28E4;
				case 81:
					goto IL_2528;
				case 82:
					goto IL_27EF;
				case 83:
					goto IL_1D65;
				case 84:
					goto IL_250E;
				case 85:
					goto IL_36BD;
				case 86:
					goto IL_2DAA;
				case 87:
					goto IL_3881;
				case 88:
					goto IL_17CD;
				case 89:
					goto IL_1A18;
				case 90:
					goto IL_B20;
				case 91:
					goto IL_F98;
				case 92:
					goto IL_1329;
				case 93:
					goto IL_3DA5;
				case 94:
					goto IL_1863;
				case 95:
					goto IL_14AD;
				case 96:
					goto IL_10C4;
				case 97:
					goto IL_F67;
				case 98:
					goto IL_31DE;
				case 99:
					goto IL_E5F;
				case 100:
					goto IL_3390;
				case 101:
					goto IL_30E6;
				case 102:
					goto IL_3F23;
				case 103:
					goto IL_D7B;
				case 104:
					goto IL_150F;
				case 105:
					goto IL_1AF6;
				case 106:
					goto IL_1F07;
				case 107:
					goto IL_BD0;
				case 108:
					goto IL_DA2;
				case 109:
					goto IL_2C5A;
				case 110:
					goto IL_390A;
				case 111:
					goto IL_D19;
				case 112:
					goto IL_23B1;
				case 113:
					goto IL_3802;
				case 114:
					goto IL_1870;
				case 115:
					goto IL_2794;
				case 116:
					goto IL_374B;
				case 117:
					goto IL_2946;
				case 118:
					goto IL_15A8;
				case 119:
					goto IL_299E;
				case 120:
					goto IL_376F;
				case 121:
					goto IL_E2B;
				case 122:
					goto IL_16E5;
				case 123:
					goto IL_2FEE;
				case 124:
					goto IL_2169;
				case 125:
					goto IL_2AA6;
				case 126:
					goto IL_38E3;
				case 127:
					goto IL_1F9D;
				case 128:
					goto IL_29D2;
				case 129:
					goto IL_27AE;
				case 130:
					goto IL_3C86;
				case 131:
					goto IL_BAC;
				case 132:
					goto IL_397F;
				case 133:
					goto IL_229F;
				case 134:
					goto IL_3A60;
				case 135:
					goto IL_3525;
				case 136:
					goto IL_151C;
				case 137:
					goto IL_1CF6;
				case 138:
					goto IL_274C;
				case 139:
					goto IL_3CF5;
				case 140:
					goto IL_3CDB;
				case 141:
					goto IL_3193;
				case 142:
					goto IL_3298;
				case 143:
					goto IL_B06;
				case 144:
					goto IL_DBC;
				case 145:
					goto IL_3461;
				case 146:
					goto IL_C66;
				case 147:
					goto IL_3722;
				case 148:
					goto IL_3D36;
				case 149:
					goto IL_2847;
				case 150:
					goto IL_30D9;
				case 151:
					goto IL_BDD;
				case 152:
					goto IL_2597;
				case 153:
					goto IL_289C;
				case 154:
					goto IL_3046;
				case 155:
					goto IL_188A;
				case 156:
					goto IL_292C;
				case 157:
					goto IL_384D;
				case 158:
					goto IL_F4D;
				case 159:
					goto IL_32FA;
				case 160:
					goto IL_21E8;
				case 161:
					goto IL_D6E;
				case 162:
					goto IL_B54;
				case 163:
					goto IL_2A99;
				case 164:
					goto IL_3162;
				case 165:
					goto IL_2397;
				case 166:
					goto IL_1ED6;
				case 167:
					goto IL_C9A;
				case 168:
					goto IL_3972;
				case 169:
					goto IL_1377;
				case 170:
					goto IL_C8D;
				case 171:
					goto IL_3699;
				case 172:
					goto IL_16CB;
				case 173:
					goto IL_20C9;
				case 174:
					goto IL_1B72;
				case 175:
					goto IL_2029;
				case 176:
					goto IL_2E29;
				case 177:
					goto IL_2332;
				case 178:
					goto IL_2420;
				case 179:
					goto IL_21DB;
				case 180:
					goto IL_1D03;
				case 181:
					goto IL_2E7E;
				case 182:
					goto IL_27C8;
				case 183:
					goto IL_233F;
				case 184:
					goto IL_1489;
				case 185:
					goto IL_1167;
				case 186:
					goto IL_1E2C;
				case 187:
					goto IL_1224;
				case 188:
					goto IL_13E6;
				case 189:
					goto IL_1EC9;
				case 190:
					goto IL_215C;
				case 191:
					goto IL_1E50;
				case 192:
					goto IL_C80;
				case 193:
					goto IL_1581;
				case 194:
					goto IL_3708;
				case 195:
					goto IL_2A2A;
				case 196:
					goto IL_1126;
				case 197:
					goto IL_2301;
				case 198:
					goto IL_1C39;
				case 199:
					goto IL_2E02;
				case 200:
					goto IL_3AE9;
				case 201:
					goto IL_2406;
				case 202:
					goto IL_36CA;
				case 203:
					goto IL_1C05;
				case 204:
					goto IL_1A0B;
				case 205:
					goto IL_320F;
				case 206:
					goto IL_1EA5;
				case 207:
					goto IL_3A39;
				case 208:
					goto IL_1536;
				case 209:
					goto IL_1DCA;
				case 210:
					goto IL_C59;
				case 211:
					goto IL_30BF;
				case 212:
					goto IL_2F96;
				case 213:
					goto IL_1D99;
				case 214:
					goto IL_38FD;
				case 215:
					goto IL_CCE;
				case 216:
					goto IL_E45;
				case 217:
					goto IL_3C93;
				case 218:
					goto IL_3ACF;
				case 219:
					goto IL_254F;
				case 220:
					goto IL_10AA;
				case 221:
					goto IL_FF0;
				case 222:
					goto IL_328B;
				case 223:
					goto IL_19FE;
				case 224:
					goto IL_FA5;
				case 225:
					goto IL_2809;
				case 226:
					goto IL_26C3;
				case 227:
					goto IL_2AE4;
				case 228:
					goto IL_1AC5;
				case 229:
					goto IL_2002;
				case 230:
					goto IL_20D6;
				case 231:
					goto IL_2620;
				case 232:
					goto IL_1174;
				case 233:
					goto IL_2454;
				case 234:
					goto IL_238A;
				case 235:
					goto IL_CE8;
				case 236:
					goto IL_141A;
				case 237:
					goto IL_1C46;
				case 238:
					goto IL_201C;
				case 239:
					goto IL_12AD;
				case 240:
					goto IL_20FA;
				case 241:
					goto IL_266B;
				case 242:
					goto IL_3314;
				case 243:
					goto IL_208B;
				case 244:
					goto IL_3BB5;
				case 245:
					goto IL_E93;
				case 246:
					goto IL_19CA;
				case 247:
					goto IL_1849;
				case 248:
					goto IL_3229;
				case 249:
					goto IL_19E4;
				case 250:
					goto IL_2B7D;
				case 251:
					goto IL_3840;
				case 252:
					goto IL_3E69;
				case 253:
					goto IL_25EF;
				case 254:
					goto IL_13C2;
				case 255:
					goto IL_3E14;
				case 256:
					goto IL_2816;
				case 257:
					goto IL_2F24;
				case 258:
					goto IL_27D5;
				case 259:
					goto IL_3ADC;
				case 260:
					goto IL_2BF8;
				case 261:
					goto IL_269F;
				case 262:
					goto IL_12D1;
				case 263:
					goto IL_3423;
				case 264:
					goto IL_109D;
				case 265:
					goto IL_1B27;
				case 266:
					goto IL_C3F;
				case 267:
					goto IL_C1B;
				case 268:
					goto IL_E86;
				case 269:
					goto IL_3383;
				case 270:
					goto IL_EA0;
				case 271:
					goto IL_313E;
				case 272:
					goto IL_381C;
				case 273:
					goto IL_39FB;
				case 274:
					goto IL_2F17;
				case 275:
					goto IL_37D1;
				case 276:
					goto IL_3501;
				case 277:
					goto IL_EEB;
				case 278:
					goto IL_3A53;
				case 279:
					goto IL_2D9D;
				case 280:
					goto IL_296D;
				case 281:
					goto IL_2D90;
				case 282:
					goto IL_1427;
				case 283:
					goto IL_1DD7;
				case 284:
					goto IL_23A4;
				case 285:
					goto IL_3E9A;
				case 286:
					goto IL_29DF;
				case 287:
					goto IL_28C0;
				case 288:
					goto IL_3131;
				case 289:
					goto IL_1090;
				case 290:
					goto IL_1FE8;
				case 291:
					goto IL_1B03;
				case 292:
					goto IL_3BE6;
				case 293:
					goto IL_1258;
				case 294:
					goto IL_339D;
				case 295:
					goto IL_10B7;
				case 296:
					goto IL_1F38;
				case 297:
					goto IL_327E;
				case 298:
					goto IL_3DB2;
				case 299:
					goto IL_2678;
				case 300:
					goto IL_283A;
				case 301:
					goto IL_EDE;
				case 302:
					goto IL_18D5;
				case 303:
					goto IL_1FCE;
				case 304:
					goto IL_3345;
				case 305:
					goto IL_B7B;
				case 306:
					goto IL_3A2C;
				case 307:
					goto IL_159B;
				case 308:
					goto IL_1A87;
				case 309:
					goto IL_2261;
				case 310:
					goto IL_346E;
				case 311:
					goto IL_CC1;
				case 312:
					goto IL_1676;
				case 313:
					goto IL_29EC;
				case 314:
					goto IL_23F9;
				case 315:
					goto IL_12EB;
				case 316:
					goto IL_2960;
				case 317:
					goto IL_2DDB;
				case 318:
					goto IL_2DF5;
				case 319:
					goto IL_1B58;
				case 320:
					goto IL_1CD2;
				case 321:
					goto IL_191D;
				case 322:
					goto IL_192A;
				case 323:
					goto IL_2E71;
				case 324:
					goto IL_1384;
				case 325:
					goto IL_38F0;
				case 326:
					goto IL_31BA;
				case 327:
					goto IL_27BB;
				case 328:
					goto IL_2292;
				case 329:
					goto IL_39EE;
				case 330:
					goto IL_30CC;
				case 331:
					goto IL_1BE1;
				case 332:
					goto IL_14D1;
				case 333:
					goto IL_FFD;
				case 334:
					goto IL_2F3E;
				case 335:
					goto IL_1D41;
				case 336:
					goto IL_178F;
				case 337:
					goto IL_2C36;
				case 338:
					goto IL_CA7;
				case 339:
					goto IL_3AF6;
				case 340:
					goto IL_273F;
				case 341:
					goto IL_3EE5;
				case 342:
					goto IL_37DE;
				case 343:
					goto IL_3B46;
				case 344:
					goto IL_3E07;
				case 345:
					goto IL_114D;
				case 346:
					goto IL_16A7;
				case 347:
					goto IL_1F76;
				case 348:
					goto IL_3E45;
				case 349:
					goto IL_3A46;
				case 350:
					goto IL_1C1F;
				case 351:
					goto IL_211E;
				case 352:
					goto IL_135D;
				case 353:
					goto IL_1BBD;
				case 354:
					goto IL_2ECC;
				case 355:
					goto IL_385A;
				case 356:
					goto IL_1F90;
				case 357:
					goto IL_EAD;
				case 358:
					goto IL_1C53;
				case 359:
					goto IL_1DE4;
				case 360:
					goto IL_124B;
				case 361:
					goto IL_2A4E;
				case 362:
					goto IL_1F45;
				case 363:
					goto IL_1D8C;
				case 364:
					goto IL_106C;
				case 365:
					goto IL_E52;
				case 366:
					goto IL_3931;
				case 367:
					goto IL_2FE1;
				case 368:
					goto IL_26F7;
				case 369:
					goto IL_29B8;
				case 370:
					goto IL_2F72;
				case 371:
					goto IL_1CB8;
				case 372:
					goto IL_36EE;
				case 373:
					goto IL_22C3;
				case 374:
					goto IL_147C;
				case 375:
					goto IL_F29;
				case 376:
					goto IL_27E2;
				case 377:
					goto IL_2D52;
				case 378:
					goto IL_2B25;
				case 379:
					goto IL_1652;
				case 380:
					goto IL_2D45;
				case 381:
					goto IL_2AC0;
				case 382:
					goto IL_18AE;
				case 383:
					goto IL_E79;
				case 384:
					goto IL_3369;
				case 385:
					goto IL_EF8;
				case 386:
					goto IL_AE2;
				case 387:
					goto IL_2542;
				case 388:
					goto IL_3603;
				case 389:
					goto IL_34C3;
				case 390:
					goto IL_35D2;
				case 391:
					goto IL_3924;
				case 392:
					goto IL_162E;
				case 393:
					goto IL_2501;
				case 394:
					goto IL_2183;
				case 395:
					goto IL_2EFD;
				case 396:
					goto IL_353F;
				case 397:
					goto IL_11CC;
				case 398:
					goto IL_158E;
				case 399:
					goto IL_2413;
				case 400:
					goto IL_10F5;
				case 401:
					goto IL_2E4D;
				case 402:
					goto IL_B47;
				case 403:
					goto IL_DAF;
				case 404:
					goto IL_2A7F;
				case 405:
					goto IL_1102;
				case 406:
					goto IL_E38;
				case 407:
					goto IL_118E;
				case 408:
					goto IL_183C;
				case 409:
					goto IL_2CFA;
				case 410:
					goto IL_1CC5;
				case 411:
					goto IL_3BF3;
				case 412:
					goto IL_3008;
				case 413:
					goto IL_2C67;
				case 414:
					goto IL_3F16;
				case 415:
					goto IL_21CE;
				case 416:
					goto IL_3053;
				case 417:
					goto IL_26DD;
				case 418:
					goto IL_2573;
				case 419:
					goto IL_26D0;
				case 420:
					goto IL_FE3;
				case 421:
					goto IL_1F83;
				case 422:
					goto IL_1A3C;
				case 423:
					goto IL_2C74;
				case 424:
					goto IL_398C;
				case 425:
					goto IL_2C98;
				case 426:
					goto IL_24F4;
				case 427:
					goto IL_1C7A;
				case 428:
					goto IL_25D5;
				case 429:
					goto IL_39CA;
				case 430:
					goto IL_3D74;
				case 431:
					goto IL_2FFB;
				case 432:
					goto IL_1336;
				case 433:
					goto IL_11F0;
				case 434:
					goto IL_3D81;
				case 435:
					goto IL_2939;
				case 436:
					goto IL_C4C;
				case 437:
					goto IL_1E98;
				case 438:
					goto IL_1E08;
				case 439:
					goto IL_3958;
				case 440:
					goto IL_3C62;
				case 441:
					goto IL_FD6;
				case 442:
					goto IL_1350;
				case 443:
					goto IL_13F3;
				case 444:
					goto IL_1231;
				case 445:
					goto IL_3430;
				case 446:
					goto IL_237D;
				case 447:
					goto IL_11BF;
				case 448:
					goto IL_FC9;
				case 449:
					goto IL_1856;
				case 450:
					goto IL_2B18;
				case 451:
					goto IL_3077;
				case 452:
					goto IL_365B;
				case 453:
					goto IL_1140;
				case 454:
					goto IL_25C8;
				case 455:
					goto IL_2A10;
				case 456:
					goto IL_3A08;
				case 457:
					goto IL_2ED9;
				case 458:
					goto IL_2F4B;
				case 459:
					goto IL_1181;
				case 460:
					goto IL_380F;
				case 461:
					goto IL_1289;
				case 462:
					goto IL_B2D;
				case 463:
					goto IL_1F14;
				case 464:
					goto IL_32BC;
				case 465:
					goto IL_11FD;
				case 466:
					goto IL_3BD9;
				case 467:
					goto IL_3A7A;
				case 468:
					goto IL_1D34;
				case 469:
					goto IL_1999;
				case 470:
					goto IL_2692;
				case 471:
					goto IL_27FC;
				case 472:
					goto IL_AD5;
				case 473:
					goto IL_37A0;
				case 474:
					goto IL_2908;
				case 475:
					goto IL_2D2B;
				case 476:
					goto IL_1EFA;
				case 477:
					goto IL_187D;
				case 478:
					goto IL_388E;
				case 479:
					goto IL_3039;
				case 480:
					goto IL_1683;
				case 481:
					goto IL_38D6;
				case 482:
					goto IL_2DE8;
				case 483:
					goto IL_115A;
				case 484:
					goto IL_25FC;
				case 485:
					goto IL_2953;
				case 486:
					goto IL_100A;
				case 487:
					goto IL_1B7F;
				case 488:
					goto IL_198C;
				case 489:
					goto IL_31AD;
				case 490:
					goto IL_3CB7;
				case 491:
					goto IL_1567;
				case 492:
					goto IL_176B;
				case 493:
					goto IL_31A0;
				case 494:
					goto IL_3271;
				case 495:
					goto IL_2A8C;
				case 496:
					goto IL_1B8C;
				case 497:
					goto IL_18F9;
				case 498:
					goto IL_CDB;
				case 499:
					goto IL_2B0B;
				case 500:
					goto IL_3A6D;
				case 501:
					goto IL_3C3E;
				case 502:
					goto IL_2254;
				case 503:
					goto IL_2D38;
				case 504:
					goto IL_DED;
				case 505:
					goto IL_1458;
				case 506:
					goto IL_3F47;
				case 507:
					goto IL_362A;
				case 508:
					goto IL_E6C;
				case 509:
					goto IL_1AE9;
				case 510:
					goto IL_393E;
				case 511:
					goto IL_1FF5;
				case 512:
					goto IL_2C05;
				case 513:
					goto IL_1B4B;
				case 514:
					goto IL_246E;
				case 515:
					goto IL_3A9E;
				case 516:
					goto IL_1F52;
				case 517:
					goto IL_207E;
				case 518:
					goto IL_22DD;
				case 519:
					goto IL_2EA5;
				case 520:
					goto IL_1D7F;
				case 521:
					goto IL_1709;
				case 522:
					goto IL_3124;
				case 523:
					goto IL_2488;
				case 524:
					goto IL_2AB3;
				case 525:
					goto IL_D88;
				case 526:
					goto IL_10E8;
				case 527:
					goto IL_F05;
				case 528:
					goto IL_310A;
				case 529:
					goto IL_1E74;
				case 530:
					goto IL_1133;
				case 531:
					goto IL_1A7A;
				case 532:
					goto IL_1A6D;
				case 533:
					goto IL_16D8;
				case 534:
					goto IL_1937;
				case 535:
					goto IL_1343;
				case 536:
					goto IL_302C;
				case 537:
					goto IL_19BD;
				case 538:
					goto IL_33DB;
				case 539:
					goto IL_19D7;
				case 540:
					goto IL_BF7;
				case 541:
					goto IL_2EB2;
				case 542:
					goto IL_251B;
				case 543:
					goto IL_3715;
				case 544:
					goto IL_1C12;
				case 545:
					goto IL_179C;
				case 546:
					goto IL_B13;
				case 547:
					goto IL_3D67;
				case 548:
					goto IL_26EA;
				case 549:
					goto IL_2230;
				case 550:
					goto IL_1574;
				case 551:
					goto IL_31EB;
				case 552:
					goto IL_DE0;
				case 553:
					goto IL_C73;
				case 554:
					goto IL_1621;
				case 555:
					goto IL_11B2;
				case 556:
					goto IL_38B2;
				case 557:
					goto IL_1C60;
				case 558:
					goto IL_2F65;
				case 559:
					goto IL_1C9E;
				case 560:
					goto IL_DFA;
				case 561:
					goto IL_13A8;
				case 562:
					goto IL_2359;
				case 563:
					goto IL_2535;
				case 564:
					goto IL_2991;
				case 565:
					goto IL_265E;
				case 566:
					goto IL_3965;
				case 567:
					goto IL_3DD6;
				case 568:
					goto IL_120A;
				case 569:
					goto IL_3EA7;
				case 570:
					goto IL_35C5;
				case 571:
					goto IL_309B;
				case 572:
					goto IL_2190;
				case 573:
					goto IL_2B4C;
				case 574:
					goto IL_3307;
				case 575:
					goto IL_3186;
				case 576:
					goto IL_D0C;
				case 577:
					goto IL_33CE;
				case 578:
					goto IL_2FA3;
				case 579:
					goto IL_E1E;
				case 580:
					goto IL_361D;
				case 581:
					goto IL_2E8B;
				case 582:
					goto IL_3D43;
				case 583:
					goto IL_2A1D;
				case 584:
					goto IL_39A6;
				case 585:
					goto IL_3D1C;
				case 586:
					goto IL_B61;
				case 587:
					goto IL_1CAB;
				case 588:
					goto IL_262D;
				case 589:
					goto IL_2A5B;
				case 590:
					goto IL_3EB4;
				case 591:
					goto IL_136A;
				case 592:
					goto IL_3532;
				case 593:
					goto IL_33FF;
				case 594:
					goto IL_1FC1;
				case 595:
					goto IL_15B5;
				case 596:
					goto IL_3999;
				case 597:
					goto IL_ED1;
				case 598:
					goto IL_243A;
				case 599:
					goto IL_2685;
				case 600:
					goto IL_14DE;
				case 601:
					goto IL_3594;
				case 602:
					goto IL_37C4;
				case 603:
					goto IL_BEA;
				case 604:
					goto IL_3570;
				case 605:
					goto IL_D61;
				case 606:
					goto IL_347B;
				case 607:
					goto IL_2FD4;
				case 608:
					goto IL_2E98;
				case 609:
					goto IL_B3A;
				case 610:
					goto IL_123E;
				case 611:
					goto IL_34D0;
				case 612:
					goto IL_286B;
				case 613:
					goto IL_144B;
				case 614:
					goto IL_1400;
				case 615:
					goto IL_1818;
				case 616:
					goto IL_3B53;
				case 617:
					goto IL_3C00;
				case 618:
					goto IL_140D;
				case 619:
					goto IL_2B3F;
				case 620:
					goto IL_25A4;
				case 621:
					goto IL_214F;
				case 622:
					goto IL_3610;
				case 623:
					goto IL_3D02;
				case 624:
					goto IL_324D;
				case 625:
					goto IL_2F31;
				case 626:
					goto IL_220C;
				case 627:
					goto IL_2447;
				case 628:
					goto IL_2E1C;
				case 629:
					goto IL_34F4;
				case 630:
					goto IL_3D0F;
				case 631:
					goto IL_195B;
				case 632:
					goto IL_2F58;
				case 633:
					goto IL_1DBD;
				case 634:
					goto IL_2AF1;
				case 635:
					goto IL_2CC9;
				case 636:
					goto IL_29AB;
				case 637:
					goto IL_15D9;
				case 638:
					goto IL_234C;
				case 639:
					goto IL_1B65;
				case 640:
					goto IL_3D29;
				case 641:
					goto IL_2176;
				case 642:
					goto IL_3321;
				case 643:
					goto IL_13B5;
				case 644:
					goto IL_22D0;
				case 645:
					goto IL_3117;
				case 646:
					goto IL_2D5F;
				case 647:
					goto IL_3874;
				case 648:
					goto IL_24D0;
				case 649:
					goto IL_2285;
				case 650:
					goto IL_3917;
				case 651:
					goto IL_2461;
				case 652:
					goto IL_2B70;
				case 653:
					goto IL_2878;
				case 654:
					goto IL_B6E;
				case 655:
					goto IL_1AB8;
				case 656:
					goto IL_2E0F;
				case 657:
					goto IL_173A;
				case 658:
					goto IL_197F;
				case 659:
					goto IL_2770;
				case 660:
					goto IL_2071;
				case 661:
					goto IL_2D83;
				case 662:
					goto IL_2FC7;
				case 663:
					goto IL_1D27;
				case 664:
					goto IL_3E21;
				case 665:
					goto IL_368C;
				case 666:
					goto IL_1C6D;
				case 667:
					goto IL_17C0;
				case 668:
					goto IL_12DE;
				case 669:
					goto IL_2BEB;
				case 670:
					goto IL_18BB;
				case 671:
					goto IL_2CED;
				case 672:
					goto IL_247B;
				default:
					num = (short)162725889;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AD5:
			this.RadProfAlertTonesMinimumAudioVolume_A8517Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AE2:
			this.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661 = (global::AcpUI.AcpCheckBox)target;
			this.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B06:
			this.CVBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B13:
			this.RTDBtnAnalogHighFrequencyBandAccessory_42650 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B20:
			this.RTDBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B2D:
			this.CVBtnRadProfAudioSettingsMaximumAudioVolume_A19577 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B3A:
			this.RadProfAudioSettingsSecurenet_A9097Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B47:
			this.RTDBtnAudioEqualizationAccessory_42612 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B54:
			this.CpyBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B61:
			this.CpyBtnRadProfLabtoolSecurenetBassControl_A19508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B6E:
			this.RTDBtnReceiveAGCGainControlOutputAccessory_42746 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B7B:
			this.RTDBtnRadProfAudioSettingsDigitalAGC1_A7854 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B88:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_BAC:
			this.LblRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BD0:
			this.GrpBoxExpanderRadioProfilesAudioSettingsExternalMicGain = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BDD:
			this.CpyBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BEA:
			this.SecurenetMidFrequencyBandAccessory_42659Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BF7:
			this.RadProfAudioSettingsAnalog_A7438 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsAnalog_A7438.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C1B:
			this.RadProfCustomSettingsRadioMicOverloadComp_42675 = (global::AcpUI.AcpComboBox)target;
			this.RadProfCustomSettingsRadioMicOverloadComp_42675.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C3F:
			this.CVBtnRadProfCustomSettingsRadioMicOverloadComp_42675 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C4C:
			this.CpyBtnMidFrequencyBandAccessory_42641 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C59:
			this.CpyBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C66:
			this.CpyBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C73:
			this.CpyBtnRadProfLabtoolDigitalBassControl_A19507 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C80:
			this.RTDBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C8D:
			this.CVBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C9A:
			this.RTDBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CA7:
			this.RTDBtnRadProfAudioSettingsTotal_A9394 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CB4:
			this.CpyBtnRadProfNVGEnable_A41615 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CC1:
			this.CpyBtnRadProfAudioSettingsDigitalAGC2_A7853 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CCE:
			this.CpyBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CDB:
			this.RTDBtnAudioEqualizationRadio_42602 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CE8:
			this.RadProfAudioSettingsExternalMicDirectivityMode_A21549 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsExternalMicDirectivityMode_A21549.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D0C:
			this.RadProfAudioSettingsDigital_A7850Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D19:
			this.LblNoiseReductionRadio_42575 = (global::AcpUI.AcpLabel)target;
			this.LblNoiseReductionRadio_42575.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D3D:
			this.RadProfGeneralRadioProfileName_A19564 = (global::AcpUI.AcpTextBox)target;
			this.RadProfGeneralRadioProfileName_A19564.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D61:
			this.CVBtnRadProfAudioSettingsSecurenet_A9097 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D6E:
			this.RTDBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D7B:
			this.RTDBtnRadProfAudioSettingsFeedbackSupressionTime_A43793 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D88:
			this.CpyBtnAnalogLowFrequencyBandAccessory_42647 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D95:
			this.RTDBtnRadProfGeneralSpeakerAudioRouting_A19566 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DA2:
			this.GrpBoxExpanderRadioProfilesAudioSettingsAGC = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_DAF:
			this.CpyBtnAudioEqualizationAccessory_42612 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DBC:
			this.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE0:
			this.RTDBtnRadProfLabtoolDigitalBassControl_A19507 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DED:
			this.AudioEqualizationAccessory_42603Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DFA:
			this.LblDigitalMidFrequencyBandRadio_42653 = (global::AcpUI.AcpLabel)target;
			this.LblDigitalMidFrequencyBandRadio_42653.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E1E:
			this.RTDBtnDigitalHighFrequencyBandAccessory_42655 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E2B:
			this.CVBtnNoiseReductionGroupSettingRadio_42584 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E38:
			this.CVBtnAudioEqualizationGroupSettingRadio_42613 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E45:
			this.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E52:
			this.RTDBtnRadProfAudioSettingsDigitalFixedGain2_A7855 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E5F:
			this.RadioProfilesAudioSettingsMicHWAGC_A37722Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E6C:
			this.RTDBtnAudioEqualizationGroupSettingRadio_42604 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E79:
			this.CpyBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E86:
			this.RTDBtnRadProfCustomSettingsRadioMicOverloadComp_42675 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E93:
			this.RTDBtnRadioProfilesAdaptiveNoiseSuppressionAccessory_42739 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EA0:
			this.RadProfCustomSettingsRadioMicOverloadComp_42675Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EAD:
			this.LblRadProfAudioSettingsDigitalFixedGain1_A7856 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsDigitalFixedGain1_A7856.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ED1:
			this.CpyBtnSecurenetMidFrequencyBandRadio_42658 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EDE:
			this.RadProfAudioSettingsAnalogAGC2_A7439Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_EEB:
			this.RTDBtnGainSensitivityAccessory_42607 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EF8:
			this.CVBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F05:
			this.LblAnalogMidFrequencyBandRadio_42648 = (global::AcpUI.AcpLabel)target;
			this.LblAnalogMidFrequencyBandRadio_42648.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F29:
			this.RadProfAudioSettingsSecurenetFixedGain2_A9101 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsSecurenetFixedGain2_A9101.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F4D:
			this.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F5A:
			this.RadProfGeneralDisableEmergencyAlertsNotification_A19570Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F67:
			this.RTDBtnRadioProfilesAudioSettingsMicHWAGC_A37722 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F74:
			this.RadProfNVGEnable_A41615 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfNVGEnable_A41615.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F98:
			this.CpyBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FA5:
			this.RadProfLabtoolExternalMicSourceMode_A21548 = (global::AcpUI.AcpComboBox)target;
			this.RadProfLabtoolExternalMicSourceMode_A21548.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FC9:
			this.HighFrequencyBandAccessory_42643Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FD6:
			this.RTDBtnHighFrequencyBandRadio_42642 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FE3:
			this.CpyBtnLowFrequencyBandRadio_42638 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FF0:
			this.CpyBtnRadProfAudioSettingsInternalMicSourceMode_A22193 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FFD:
			this.CpyBtnAGCGainControlOutputAccessory_42644 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_100A:
			this.RadProfAlertTonesMinimumAlertToneVolume_A8521 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAlertTonesMinimumAlertToneVolume_A8521.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_102E:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_103B:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfiles)target).Unloaded += this.OnUnloaded;
			return;
			IL_106C:
			this.RadProfAudioSettingsDigitalFixedGain2_A7855 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsDigitalFixedGain2_A7855.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1090:
			this.CpyBtnGainSensitivityGroupSettingAccessory_42610 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_109D:
			this.RadProfCustomSettingsAccessoryMicAutoMode_42674Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10AA:
			this.RTDBtnRadProfAudioSettingsInternalMicSourceMode_A22193 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10B7:
			this.CpyBtnRadProfAudioSettingsAnalogAGC1_A7440 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10C4:
			this.RadioProfilesAudioSettingsMicHWAGC_A37722 = (global::AcpUI.AcpCheckBox)target;
			this.RadioProfilesAudioSettingsMicHWAGC_A37722.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10E8:
			this.AnalogLowFrequencyBandAccessory_42647Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10F5:
			this.AudioEqualizationRadio_42611Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1102:
			this.LblAudioEqualizationGroupSettingRadio_42613 = (global::AcpUI.AcpLabel)target;
			this.LblAudioEqualizationGroupSettingRadio_42613.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1126:
			this.CVBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1133:
			this.RTDBtnAnalogMidFrequencyBandRadio_42648 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1140:
			this.RTDBtnRadProfAudioSettingsFeedbackSupression = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_114D:
			this.AGCGainControlTotalAccessory_42645Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_115A:
			this.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1167:
			this.CVBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1174:
			this.CpyBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1181:
			this.CpyBtnVolumeControlRadioAccessory_42598 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_118E:
			this.AudioEqualizationGroupSettingRadio_42613 = (global::AcpUI.AcpComboBox)target;
			this.AudioEqualizationGroupSettingRadio_42613.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11B2:
			this.CVBtnDigitalLowFrequencyBandAccessory_42652 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11BF:
			this.CpyBtnHighFrequencyBandAccessory_42643 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11CC:
			this.AudioEqualizationRadio_42611 = (global::AcpUI.AcpLabel)target;
			this.AudioEqualizationRadio_42611.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11F0:
			this.CVBtnMidFrequencyBandAccessory_42641 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11FD:
			this.CpyBtnRadProfAudioSettingsMaximumAudioVolume_A19577 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_120A:
			this.RTDBtnDigitalMidFrequencyBandAccessory_42654 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1217:
			this.CVBtnRadProfPermanentDisableTxRxLED_A41609 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1224:
			this.RTDBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1231:
			this.CVBtnHighFrequencyBandAccessory_42643 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_123E:
			this.CVBtnSecurenetHighFrequencyBandAccessory_42660 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_124B:
			this.RTDBtnRadProfAudioSettingsDigitalFixedGain1_A7856 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1258:
			this.RadProfAudioSettingsAnalogAGC1_A7440 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsAnalogAGC1_A7440.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_127C:
			this.CVBtnRadProfGeneralDisableLights_A7866 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1289:
			this.LblRadProfAudioSettingsMaximumAudioVolume_A19577 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsMaximumAudioVolume_A19577.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12AD:
			this.LblRadioProfilesAdaptiveNoiseSuppressionRadio_42738 = (global::AcpUI.AcpLabel)target;
			this.LblRadioProfilesAdaptiveNoiseSuppressionRadio_42738.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12D1:
			this.RTDBtnRadProfCustomSettingsAccessoryMicAutoMode_42674 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12DE:
			this.GrpBoxExpanderRadioProfilesAudioSettingsPseudo8 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_12EB:
			this.RadProfAudioSettingsSecurenetAGC1_A9099 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsSecurenetAGC1_A9099.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_130F:
			this.RTDBtnRadProfPermanentTopDisplayBacklight = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_131C:
			this.RTDBtnRadProfGeneralDisableLights_A7866 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1329:
			this.RadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1336:
			this.MidFrequencyBandRadio_42640Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1343:
			this.RTDBtnAnalogMidFrequencyBandAccessory_42649 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1350:
			this.CpyBtnHighFrequencyBandRadio_42642 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_135D:
			this.CVBtnRadProfAudioSettingsAnalogFixedGain2_A7441 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_136A:
			this.CpyBtnSecurenetLowFrequencyBandAccessory_42657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1377:
			this.RadProfAudioSettingsIntMicPassAlarmFilter_A42382Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1384:
			this.LblRadProfAudioSettingsOutput_A8679 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsOutput_A8679.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13A8:
			this.CVBtnDigitalMidFrequencyBandRadio_42653 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13B5:
			this.RTDBtnReceiveAGCEnableAccessory_42744 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13C2:
			this.LblRadProfCustomSettingsRadioMicAutoMode_42673 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfCustomSettingsRadioMicAutoMode_42673.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13E6:
			this.CpyBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13F3:
			this.HighFrequencyBandRadio_42642Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1400:
			this.SecurenetHighFrequencyBandAccessory_42660Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_140D:
			this.CpyBtnGainControlRadio_42617 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_141A:
			this.RTDBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1427:
			this.GainSensitivityGroupSettingRadio_42608 = (global::AcpUI.AcpComboBox)target;
			this.GainSensitivityGroupSettingRadio_42608.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_144B:
			this.CpyBtnSecurenetHighFrequencyBandAccessory_42660 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1458:
			this.LblAudioEqualizationGroupSettingRadio_42604 = (global::AcpUI.AcpLabel)target;
			this.LblAudioEqualizationGroupSettingRadio_42604.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_147C:
			this.CVBtnRadProfAudioSettingsSecurenetFixedGain2_A9101 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1489:
			this.LblRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14AD:
			this.LblRadioProfilesAudioSettingsMicHWAGC_A37722 = (global::AcpUI.AcpLabel)target;
			this.LblRadioProfilesAudioSettingsMicHWAGC_A37722.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14D1:
			this.RTDBtnAGCGainControlOutputAccessory_42644 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14DE:
			this.SecurenetMidFrequencyBandAccessory_42659 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecurenetMidFrequencyBandAccessory_42659.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1502:
			this.RadProfPermanentDisableTxRxLED_A41609Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_150F:
			this.CpyBtnRadProfAudioSettingsFeedbackSupressionTime_A43793 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_151C:
			this.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1529:
			this.CVBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1536:
			this.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_155A:
			this.RTDBtnRadProfGeneralDisableCriticalAlertsNotification_A19571 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1567:
			this.CVBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1574:
			this.CVBtnRadProfLabtoolDigitalBassControl_A19507 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1581:
			this.CpyBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_158E:
			this.RTDBtnAudioEqualizationRadio_42611 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_159B:
			this.RadProfAudioSettingsDigitalAGC1_A7854Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_15A8:
			this.CpyBtnNoiseReductionAccessory_42576 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15B5:
			this.SecurenetMidFrequencyBandRadio_42658 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecurenetMidFrequencyBandRadio_42658.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15D9:
			this.ReceiveAGCEnableInternal_42743 = (global::AcpUI.AcpCheckBox)target;
			this.ReceiveAGCEnableInternal_42743.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15FD:
			this.LblRadProfGeneralDisableCriticalAlertsNotification_A19571 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralDisableCriticalAlertsNotification_A19571.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1621:
			this.RadProfLabtoolDigitalBassControl_A19507Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_162E:
			this.RadProfAudioSettingsBluetoothMicGainLevel_41989 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsBluetoothMicGainLevel_41989.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1652:
			this.LblRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715 = (global::AcpUI.AcpLabel)target;
			this.LblRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1676:
			this.RadProfAudioSettingsDigitalAGC2_A7853Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1683:
			this.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16A7:
			this.LblRadProfAudioSettingsAnalogFixedGain1_A7442 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsAnalogFixedGain1_A7442.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16CB:
			this.RTDBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16D8:
			this.CVBtnAnalogMidFrequencyBandAccessory_42649 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16E5:
			this.NoiseReductionGroupSettingRadio_42584 = (global::AcpUI.AcpComboBox)target;
			this.NoiseReductionGroupSettingRadio_42584.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1709:
			this.RadProfLabtoolAnalogBassControl_A19506Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1716:
			this.RecNavToolbarPageRadioProfiles = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageRadioProfiles.ModeClick += this.OnModeClick;
			return;
			IL_173A:
			this.LblReceiveAGCGainControlTotalInternal_42741 = (global::AcpUI.AcpLabel)target;
			this.LblReceiveAGCGainControlTotalInternal_42741.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_175E:
			this.CVBtnRadProfGeneralDisableTones_A7870 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_176B:
			this.RadProfAudioSettingsMaximumAlertToneVolume_A21368 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsMaximumAlertToneVolume_A21368.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_178F:
			this.CVBtnRadProfAudioSettingsTotal_A9394 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_179C:
			this.AnalogHighFrequencyBandAccessory_42650 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AnalogHighFrequencyBandAccessory_42650.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17C0:
			this.ReceiveAGCGainControlTotalAccessory_42742Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17CD:
			num = (short)1774583809;
			if (num != 0)
			{
			}
			this.LblRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1818:
			this.LblGainControlRadio_42617 = (global::AcpUI.AcpLabel)target;
			this.LblGainControlRadio_42617.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_183C:
			this.RTDBtnAudioEqualizationGroupSettingRadio_42613 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1849:
			this.RadioProfilesAdaptiveNoiseSuppressionAccessory_42739Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1856:
			this.GrpBoxExpanderRadioProfilesAudioSettingsSpeakerRXSettings = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1863:
			this.CVBtnRadioProfilesAudioSettingsMicHWAGC_A37722 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1870:
			this.CpyBtnNoiseReductionRadio_42575 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_187D:
			this.AlertTonesRadioAccessory_42601Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_188A:
			this.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18AE:
			this.RTDBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18BB:
			this.GrpBoxExpanderRadioProfilesLabtoolRAD_PROF_CDAPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18C8:
			this.CVBtnRadProfileSelectNoiseSensingVolumeControl = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18D5:
			this.LblRadProfAudioSettingsDigitalAGC1_A7854 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsDigitalAGC1_A7854.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18F9:
			this.AudioEqualizationRadio_42602 = (global::AcpUI.AcpLabel)target;
			this.AudioEqualizationRadio_42602.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_191D:
			this.RTDBtnRadProfAudioSettingsSecurenetAGC2_A9098 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_192A:
			this.CpyBtnRadProfAudioSettingsSecurenetAGC2_A9098 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1937:
			this.AnalogMidFrequencyBandAccessory_42649 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AnalogMidFrequencyBandAccessory_42649.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_195B:
			this.ReceiveAGCGroupSettingAccessory_42616 = (global::AcpUI.AcpComboBox)target;
			this.ReceiveAGCGroupSettingAccessory_42616.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_197F:
			this.CVBtnReceiveAGCGainControlTotalInternal_42741 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_198C:
			this.CpyBtnRadProfAlertTonesMinimumAlertToneVolume_A8521 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1999:
			this.RadProfAlertTonesMinimumAudioVolume_A8517 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAlertTonesMinimumAudioVolume_A8517.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19BD:
			this.AnalogMidFrequencyBandAccessory_42649Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19CA:
			this.CpyBtnRadioProfilesAdaptiveNoiseSuppressionAccessory_42739 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19D7:
			this.CVBtnRadProfAudioSettingsAnalog_A7438 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19E4:
			this.CVBtnRadProfCustomSettingsRadioSAMMode_42672 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19F1:
			this.CVBtnRadProfNVGEnable_A41615 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19FE:
			this.CVBtnRadProfLabtoolExternalMicSourceMode_A21548 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A0B:
			this.CpyBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A18:
			this.RadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A3C:
			this.CVBtnLowFrequencyBandAccessory_42639 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A49:
			this.RadProfGeneralDisableLights_A7866 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfGeneralDisableLights_A7866.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A6D:
			this.AnalogMidFrequencyBandRadio_42648Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A7A:
			this.CpyBtnAnalogMidFrequencyBandRadio_42648 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A87:
			this.CVBtnRadProfAudioSettingsDigitalAGC2_A7853 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A94:
			this.LblPermanentFrontDisplayBacklight_A22337 = (global::AcpUI.AcpLabel)target;
			this.LblPermanentFrontDisplayBacklight_A22337.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AB8:
			this.CpyBtnReceiveAGCGainControlOutputAccessory_42746 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AC5:
			this.LblRadProfAudioSettingsInternalMicDirectivityMode_A22195 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicDirectivityMode_A22195.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AE9:
			this.CpyBtnAudioEqualizationGroupSettingRadio_42604 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AF6:
			this.RadProfAudioSettingsFeedbackSupressionTime_A43793Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B03:
			this.LblRadProfAudioSettingsAnalogAGC1_A7440 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsAnalogAGC1_A7440.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B27:
			this.LblRadProfCustomSettingsRadioMicOverloadComp_42675 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfCustomSettingsRadioMicOverloadComp_42675.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B4B:
			this.RTDBtnAudioEqualizationGroupSettingAccessory_42605 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B58:
			this.CVBtnRadProfAudioSettingsSecurenetAGC2_A9098 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B65:
			this.CpyBtnReceiveAGCEnableInternal_42743 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B72:
			this.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1B7F:
			this.RTDBtnRadProfAlertTonesMinimumAlertToneVolume_A8521 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B8C:
			this.LblAudioEqualizationRadio_42602 = (global::AcpUI.AcpLabel)target;
			this.LblAudioEqualizationRadio_42602.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BB0:
			this.CpyBtnPermanentFrontDisplayBacklight_A22337 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BBD:
			this.RadProfAudioSettingsAnalogFixedGain2_A7441 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsAnalogFixedGain2_A7441.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BE1:
			this.AGCGainControlOutputAccessory_42644 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AGCGainControlOutputAccessory_42644.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C05:
			this.RTDBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C12:
			this.CVBtnAnalogHighFrequencyBandAccessory_42650 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C1F:
			this.CpyBtnRadProfAudioSettingsAnalogFixedGain1_A7442 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C2C:
			this.RadProfGeneralSpeakerAudioRouting_A19566Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C39:
			this.RTDBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C46:
			this.CpyBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C53:
			this.CVBtnRadProfAudioSettingsDigitalFixedGain1_A7856 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C60:
			this.RTDBtnDigitalLowFrequencyBandAccessory_42652 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C6D:
			this.CpyBtnReceiveAGCGainControlTotalAccessory_42742 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C7A:
			this.LblMidFrequencyBandRadio_42640 = (global::AcpUI.AcpLabel)target;
			this.LblMidFrequencyBandRadio_42640.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C9E:
			this.DigitalLowFrequencyBandAccessory_42652Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CAB:
			this.RadProfLabtoolSecurenetBassControl_A19508Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CB8:
			this.RTDBtnRadProfAudioSettingsSecurenetFixedGain1_A9100 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CC5:
			this.AudioEqualizationGroupSettingRadio_42613Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CD2:
			this.RadProfAudioSettingsSecurenetAGC2_A9098 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsSecurenetAGC2_A9098.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CF6:
			this.CVBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D03:
			this.CustomNoiseReductionAccessory_42600 = (global::AcpUI.AcpLabel)target;
			this.CustomNoiseReductionAccessory_42600.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D27:
			this.CVBtnReceiveAGCGainControlTotalAccessory_42742 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D34:
			this.CVBtnRadProfAlertTonesMinimumAudioVolume_A8517 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D41:
			this.LblRadProfAudioSettingsTotal_A9394 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsTotal_A9394.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D65:
			this.RadProfGeneralDisableCallAlertsNotification_A19572Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1D72:
			this.CVBtnPermanentFrontDisplayBacklight_A22337 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D7F:
			this.CpyBtnRadProfLabtoolAnalogBassControl_A19506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D8C:
			this.CVBtnRadProfAudioSettingsDigitalFixedGain2_A7855 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D99:
			this.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DBD:
			this.CpyBtnReceiveAGCGroupSettingAccessory_42616 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DCA:
			this.RTDBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DD7:
			this.RTDBtnGainSensitivityGroupSettingRadio_42608 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DE4:
			this.RadProfAudioSettingsDigitalFixedGain1_A7856 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsDigitalFixedGain1_A7856.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E08:
			this.LblHighFrequencyBandRadio_42642 = (global::AcpUI.AcpLabel)target;
			this.LblHighFrequencyBandRadio_42642.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E2C:
			this.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = (global::AcpUI.AcpComboBox)target;
			this.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E50:
			this.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = (global::AcpUI.AcpComboBox)target;
			this.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E74:
			this.AnalogMidFrequencyBandRadio_42648 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AnalogMidFrequencyBandRadio_42648.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E98:
			this.MidFrequencyBandAccessory_42641Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1EA5:
			this.LblRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EC9:
			this.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1ED6:
			this.RadProfAudioSettingsIntMicPassAlarmFilter_A42382 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsIntMicPassAlarmFilter_A42382.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EFA:
			this.CpyBtnAlertTonesRadioAccessory_42601 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F07:
			this.GrpBoxExpanderRadioProfilesAudioSettingsInternalMicGain = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F14:
			this.RadProfAudioSettingsMaximumAudioVolume_A19577 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsMaximumAudioVolume_A19577.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F38:
			this.RadProfAudioSettingsAnalogAGC1_A7440Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F45:
			this.RadProfAudioSettingsDigitalFixedGain1_A7856Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F52:
			this.LblRadProfLabtoolAnalogBassControl_A19506 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfLabtoolAnalogBassControl_A19506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F76:
			this.CVBtnRadProfAudioSettingsAnalogFixedGain1_A7442 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F83:
			this.LowFrequencyBandRadio_42638Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F90:
			this.RadProfAudioSettingsAnalogFixedGain2_A7441Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F9D:
			this.NoiseReductionGroupSettingAccessory_42585 = (global::AcpUI.AcpComboBox)target;
			this.NoiseReductionGroupSettingAccessory_42585.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1FC1:
			this.CVBtnSecurenetMidFrequencyBandRadio_42658 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FCE:
			this.CVBtnRadProfAudioSettingsDigitalAGC1_A7854 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FDB:
			this.RTDBtnRadProfPermanentDisableTxRxLED_A41609 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FE8:
			this.GainSensitivityGroupSettingAccessory_42610Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1FF5:
			this.CVBtnAudioEqualizationGroupSettingAccessory_42605 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2002:
			this.CVBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_200F:
			this.CpyBtnRadProfGeneralRadioProfileName_A19564 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_201C:
			this.RadProfAudioSettingsExternalMicDirectivityMode_A21549Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2029:
			this.LblCustomNoiseReductionRadio_42599 = (global::AcpUI.AcpLabel)target;
			this.LblCustomNoiseReductionRadio_42599.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_204D:
			this.LblRadProfGeneralRadioProfileName_A19564 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralRadioProfileName_A19564.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2071:
			this.RTDBtnReceiveAGCGainControlTotalInternal_42741 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_207E:
			this.CVBtnRadProfLabtoolAnalogBassControl_A19506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_208B:
			this.RadioProfilesAdaptiveNoiseSuppressionRadio_42738Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2098:
			this.PermanentFrontDisplayBacklight_A22337 = (global::AcpUI.AcpCheckBox)target;
			this.PermanentFrontDisplayBacklight_A22337.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20BC:
			this.RadProfGeneralDisableTones_A7870Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_20C9:
			this.CpyBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_20D6:
			this.RadProfAudioSettingsInternalMicDirectivityMode_A22195 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicDirectivityMode_A22195.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20FA:
			this.RadioProfilesAdaptiveNoiseSuppressionRadio_42738 = (global::AcpUI.AcpLabel)target;
			this.RadioProfilesAdaptiveNoiseSuppressionRadio_42738.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_211E:
			this.RadProfAudioSettingsAnalogFixedGain1_A7442Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_212B:
			this.RadProfGeneralSpeakerAudioRouting_A19566 = (global::AcpUI.AcpComboBox)target;
			this.RadProfGeneralSpeakerAudioRouting_A19566.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_214F:
			this.RTDBtnGainControlAccessory_42618 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_215C:
			this.CVBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2169:
			this.CpyBtnNoiseReductionGroupSettingRadio_42584 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2176:
			this.CVBtnReceiveAGCEnableAccessory_42744 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2183:
			this.CpyBtnRadProfAudioSettingsBluetoothMicGainLevel_41989 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2190:
			this.CVBtnRadProfAudioSettingsDigital_A7850 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_219D:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_21AA:
			this.LblRadProfileSelectNoiseSensingVolumeControl = (global::AcpUI.AcpLabel)target;
			this.LblRadProfileSelectNoiseSensingVolumeControl.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21CE:
			this.AudioEqualizationGroupSettingAccessory_42614Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21DB:
			this.CustomNoiseReductionRadio_42599Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21E8:
			this.RadProfExternalMicWindNoiseReductionLevelSelection_A21511 = (global::AcpUI.AcpComboBox)target;
			this.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_220C:
			this.ReceiveAGCGroupSettingInternal_42615 = (global::AcpUI.AcpComboBox)target;
			this.ReceiveAGCGroupSettingInternal_42615.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2230:
			this.LblRadProfLabtoolDigitalBassControl_A19507 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfLabtoolDigitalBassControl_A19507.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2254:
			this.RTDBtnAudioEqualizationAccessory_42603 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2261:
			this.RadProfAudioSettingsDigitalAGC2_A7853 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsDigitalAGC2_A7853.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2285:
			this.RTDBtnReceiveAGCGainControlOutputInternal_42745 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2292:
			this.CpyBtnRadProfAudioSettingsOutput_A8679 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_229F:
			this.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22C3:
			this.RadProfAudioSettingsSecurenetFixedGain1_A9100Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22D0:
			this.CpyBtnReceiveAGCEnableAccessory_42744 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22DD:
			this.RadProfLabtoolAnalogBassControl_A19506 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfLabtoolAnalogBassControl_A19506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2301:
			this.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2325:
			this.CpyBtnRadProfPermanentDisableTxRxLED_A41609 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2332:
			this.RTDBtnCustomNoiseReductionRadio_42599 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_233F:
			this.CustomNoiseReductionAccessory_42600Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_234C:
			this.RTDBtnReceiveAGCEnableInternal_42743 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2359:
			this.DigitalMidFrequencyBandRadio_42653 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DigitalMidFrequencyBandRadio_42653.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_237D:
			this.RTDBtnHighFrequencyBandAccessory_42643 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_238A:
			this.CVBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2397:
			this.CVBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23A4:
			this.CpyBtnGainSensitivityGroupSettingRadio_42608 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23B1:
			this.NoiseReductionRadio_42575 = (global::AcpUI.AcpLabel)target;
			this.NoiseReductionRadio_42575.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23D5:
			this.RadProfGeneralDisableEmergencyAlertsNotification_A19570 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfGeneralDisableEmergencyAlertsNotification_A19570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23F9:
			this.CVBtnRadProfAudioSettingsSecurenetAGC1_A9099 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2406:
			this.CVBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2413:
			this.CpyBtnAudioEqualizationRadio_42611 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2420:
			this.CpyBtnCustomNoiseReductionRadio_42599 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_242D:
			this.GrpBoxExpanderRadioProfilesGeneralIntelligentLighting = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_243A:
			this.SecurenetMidFrequencyBandRadio_42658Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2447:
			this.RTDBtnReceiveAGCGroupSettingInternal_42615 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2454:
			this.RadProfAudioSettingsInternalMicDirectivityMode_A22195Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2461:
			this.ReceiveAGCGainControlOutputInternal_42745Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_246E:
			this.CpyBtnAudioEqualizationGroupSettingAccessory_42605 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_247B:
			this.GrpBoxExpanderRadioProfilesAlertTonesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2488:
			this.AnalogLowFrequencyBandAccessory_42647 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AnalogLowFrequencyBandAccessory_42647.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24AC:
			this.RadProfileSelectNoiseSensingVolumeControl = (global::AcpUI.AcpCheckBox)target;
			this.RadProfileSelectNoiseSensingVolumeControl.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24D0:
			this.ReceiveAGCGainControlOutputInternal_42745 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ReceiveAGCGainControlOutputInternal_42745.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24F4:
			this.LowFrequencyBandAccessory_42639Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2501:
			this.RTDBtnRadProfAudioSettingsBluetoothMicGainLevel_41989 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_250E:
			this.ExpanderRadioProfilesAudioSettings = (global::AcpUI.AcpExpander)target;
			return;
			IL_251B:
			this.CpyBtnRadProfAudioSettingsAnalog_A7438 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2528:
			this.RTDBtnRadProfGeneralDisableCallAlertsNotification_A19572 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2535:
			this.RTDBtnDigitalMidFrequencyBandRadio_42653 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2542:
			this.RTDBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_254F:
			this.RadProfAudioSettingsInternalMicSourceMode_A22193 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsInternalMicSourceMode_A22193.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2573:
			this.LowFrequencyBandRadio_42638 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LowFrequencyBandRadio_42638.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2597:
			this.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25A4:
			this.GainControlAccessory_42618 = (global::AcpUI.AcpLabel)target;
			this.GainControlAccessory_42618.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25C8:
			this.CpyBtnRadProfAudioSettingsFeedbackSupression = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25D5:
			this.CVBtnMidFrequencyBandRadio_42640 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25E2:
			this.RadProfGeneralRadioProfileName_A19564Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25EF:
			this.RadProfCustomSettingsRadioSAMMode_42672Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25FC:
			this.LblRadProfAlertTonesMinimumAlertToneVolume_A8521 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesMinimumAlertToneVolume_A8521.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2620:
			this.RTDBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_262D:
			this.CVBtnSecurenetLowFrequencyBandAccessory_42657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_263A:
			this.LblRadProfGeneralDisableLights_A7866 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralDisableLights_A7866.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_265E:
			this.DigitalMidFrequencyBandRadio_42653Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_266B:
			this.RTDBtnRadioProfilesAdaptiveNoiseSuppressionRadio_42738 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2678:
			this.RTDBtnRadProfAudioSettingsAnalogAGC2_A7439 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2685:
			this.CVBtnSecurenetMidFrequencyBandAccessory_42659 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2692:
			this.RTDBtnRadProfAlertTonesMinimumAudioVolume_A8517 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_269F:
			this.RadProfCustomSettingsAccessoryMicAutoMode_42674 = (global::AcpUI.AcpComboBox)target;
			this.RadProfCustomSettingsAccessoryMicAutoMode_42674.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26C3:
			this.CpyBtnRadProfLabtoolExternalMicSourceMode_A21548 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26D0:
			this.RTDBtnLowFrequencyBandRadio_42638 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26DD:
			this.CVBtnLowFrequencyBandRadio_42638 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26EA:
			this.AnalogHighFrequencyBandAccessory_42650Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26F7:
			this.LblRadProfAudioSettingsSecurenetFixedGain1_A9100 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsSecurenetFixedGain1_A9100.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_271B:
			this.RadProfPermanentDisableTxRxLED_A41609 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfPermanentDisableTxRxLED_A41609.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_273F:
			this.RadProfAudioSettingsTotal_A9394Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_274C:
			this.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2770:
			this.ReceiveAGCGainControlTotalInternal_42741 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ReceiveAGCGainControlTotalInternal_42741.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2794:
			this.NoiseReductionRadio_42575Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27A1:
			this.CVBtnRadProfGeneralSpeakerAudioRouting_A19566 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27AE:
			this.CpyBtnNoiseReductionGroupSettingAccessory_42585 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27BB:
			this.RTDBtnRadProfAudioSettingsOutput_A8679 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27C8:
			this.CpyBtnCustomNoiseReductionAccessory_42600 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27D5:
			this.CpyBtnRadProfCustomSettingsRadioMicAutoMode_42673 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27E2:
			this.RTDBtnRadProfAudioSettingsSecurenetFixedGain2_A9101 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27EF:
			this.CpyBtnRadProfGeneralDisableCallAlertsNotification_A19572 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27FC:
			this.CpyBtnRadProfAlertTonesMinimumAudioVolume_A8517 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2809:
			this.RTDBtnRadProfLabtoolExternalMicSourceMode_A21548 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2816:
			this.RadProfCustomSettingsRadioMicAutoMode_42673 = (global::AcpUI.AcpComboBox)target;
			this.RadProfCustomSettingsRadioMicAutoMode_42673.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_283A:
			this.CpyBtnRadProfAudioSettingsAnalogAGC2_A7439 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2847:
			this.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_286B:
			this.RTDBtnSecurenetHighFrequencyBandAccessory_42660 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2878:
			this.ReceiveAGCGainControlOutputAccessory_42746 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ReceiveAGCGainControlOutputAccessory_42746.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_289C:
			this.LblRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28C0:
			this.GainSensitivityGroupSettingAccessory_42610 = (global::AcpUI.AcpComboBox)target;
			this.GainSensitivityGroupSettingAccessory_42610.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28E4:
			this.RadProfGeneralDisableCallAlertsNotification_A19572 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfGeneralDisableCallAlertsNotification_A19572.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2908:
			this.AlertTonesRadioAccessory_42601 = (global::AcpUI.AcpLabel)target;
			this.AlertTonesRadioAccessory_42601.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_292C:
			this.RTDBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2939:
			this.RTDBtnMidFrequencyBandAccessory_42641 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2946:
			this.RTDBtnNoiseReductionAccessory_42576 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2953:
			this.CVBtnRadProfAlertTonesMinimumAlertToneVolume_A8521 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2960:
			this.RTDBtnRadProfAudioSettingsSecurenetAGC1_A9099 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_296D:
			this.LblGainSensitivityGroupSettingRadio_42608 = (global::AcpUI.AcpLabel)target;
			this.LblGainSensitivityGroupSettingRadio_42608.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2991:
			this.CpyBtnDigitalMidFrequencyBandRadio_42653 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_299E:
			this.NoiseReductionAccessory_42576Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_29AB:
			this.CVBtnReceiveAGCEnableInternal_42743 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29B8:
			this.CVBtnRadProfAudioSettingsSecurenetFixedGain1_A9100 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29C5:
			this.CpyBtnRadProfileSelectNoiseSensingVolumeControl = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29D2:
			this.RTDBtnNoiseReductionGroupSettingAccessory_42585 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29DF:
			this.CVBtnGainSensitivityGroupSettingAccessory_42610 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29EC:
			this.LblRadProfAudioSettingsSecurenetAGC1_A9099 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsSecurenetAGC1_A9099.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A10:
			this.RadProfAudioSettingsFeedbackSupressionComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2A1D:
			this.CVBtnRadProfLabtoolSecurenetBassControl_A19508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A2A:
			this.LblRadProfAudioSettingsInternalMicOtherNoiseMode_A22196 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicOtherNoiseMode_A22196.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A4E:
			this.CpyBtnRadProfAudioSettingsDigitalFixedGain1_A7856 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A5B:
			this.SecurenetLowFrequencyBandAccessory_42657 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecurenetLowFrequencyBandAccessory_42657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A7F:
			this.AudioEqualizationAccessory_42612Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A8C:
			this.RadProfAudioSettingsMaximumAlertToneVolume_A21368Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A99:
			this.RadProfExternalMicWindNoiseReductionLevelSelection_A21511Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AA6:
			this.NoiseReductionGroupSettingRadio_42584Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AB3:
			this.RTDBtnAnalogLowFrequencyBandAccessory_42647 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AC0:
			this.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715 = (global::AcpUI.AcpCheckBox)target;
			this.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2AE4:
			this.RadProfLabtoolExternalMicSourceMode_A21548Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AF1:
			this.ReceiveAGCGroupSettingAccessory_42616Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AFE:
			this.RadProfGeneralDisableLights_A7866Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2B0B:
			this.CpyBtnAudioEqualizationRadio_42602 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B18:
			this.CVBRadProfAudioSettingsFeedbackSupression = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B25:
			this.RadProfAudioSettingsSecurenetFixedGain2_A9101Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B32:
			this.CpyBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B3F:
			this.GainControlRadio_42617Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B4C:
			this.RadProfAudioSettingsDigital_A7850 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsDigital_A7850.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B70:
			this.CVBtnReceiveAGCGainControlOutputAccessory_42746 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B7D:
			num = (short)1048025939;
			short num3 = num;
			num = (short)1602263891;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_234C;
			default:
				num = (short)1890975744;
				if (num != 0)
				{
				}
				this.RadProfCustomSettingsRadioSAMMode_42672 = (global::AcpUI.AcpComboBox)target;
				this.RadProfCustomSettingsRadioSAMMode_42672.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_2BEB:
			this.ExpanderRadioProfilesLabtoolRAD_PROF_CDA = (global::AcpUI.AcpExpander)target;
			return;
			IL_2BF8:
			this.CVBtnRadProfCustomSettingsAccessoryMicAutoMode_42674 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C05:
			this.AudioEqualizationGroupSettingAccessory_42605 = (global::AcpUI.AcpComboBox)target;
			this.AudioEqualizationGroupSettingAccessory_42605.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C29:
			this.RTDBtnRadProfileSelectNoiseSensingVolumeControl = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C36:
			this.RadProfAudioSettingsTotal_A9394 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsTotal_A9394.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C5A:
			this.GrpBoxExpanderRadioProfilesAudioSettingsTrebleControl = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2C67:
			this.RTDBtnAudioEqualizationGroupSettingAccessory_42614 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C74:
			this.LowFrequencyBandAccessory_42639 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LowFrequencyBandAccessory_42639.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C98:
			this.CpyBtnLowFrequencyBandAccessory_42639 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CA5:
			this.RadProfGeneralDisableCriticalAlertsNotification_A19571 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfGeneralDisableCriticalAlertsNotification_A19571.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CC9:
			this.LblReceiveAGCEnableInternal_42743 = (global::AcpUI.AcpLabel)target;
			this.LblReceiveAGCEnableInternal_42743.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CED:
			this.ExpanderRadioProfilesAlertTones = (global::AcpUI.AcpExpander)target;
			return;
			IL_2CFA:
			this.CpyBtnAudioEqualizationGroupSettingRadio_42613 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D07:
			this.LblRadProfPermanentDisableTxRxLED_A41609 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfPermanentDisableTxRxLED_A41609.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D2B:
			this.RTDBtnAlertTonesRadioAccessory_42601 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D38:
			this.CpyBtnAudioEqualizationAccessory_42603 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D45:
			this.CVBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D52:
			this.CpyBtnRadProfAudioSettingsSecurenetFixedGain2_A9101 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D5F:
			this.LblReceiveAGCGainControlOutputInternal_42745 = (global::AcpUI.AcpLabel)target;
			this.LblReceiveAGCGainControlOutputInternal_42745.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D83:
			this.CpyBtnReceiveAGCGainControlTotalInternal_42741 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D90:
			this.CVBtnGainSensitivityGroupSettingRadio_42608 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D9D:
			this.GainSensitivityAccessory_42607Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2DAA:
			this.GrpBoxExpanderRadioProfilesAudioSettingsNoiseReduction = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2DB7:
			this.LblRadProfGeneralDisableEmergencyAlertsNotification_A19570 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralDisableEmergencyAlertsNotification_A19570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DDB:
			this.CpyBtnRadProfAudioSettingsSecurenetAGC1_A9099 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DE8:
			this.CpyBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DF5:
			this.RadProfAudioSettingsSecurenetAGC1_A9099Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2E02:
			this.CpyBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E0F:
			this.ReceiveAGCGainControlOutputAccessory_42746Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E1C:
			this.CpyBtnReceiveAGCGroupSettingInternal_42615 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E29:
			this.CustomNoiseReductionRadio_42599 = (global::AcpUI.AcpLabel)target;
			this.CustomNoiseReductionRadio_42599.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E4D:
			this.AudioEqualizationAccessory_42612 = (global::AcpUI.AcpLabel)target;
			this.AudioEqualizationAccessory_42612.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E71:
			this.RadProfAudioSettingsSecurenetAGC2_A9098Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2E7E:
			this.RTDBtnCustomNoiseReductionAccessory_42600 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E8B:
			this.DigitalHighFrequencyBandAccessory_42655Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E98:
			this.CpyBtnRadProfAudioSettingsSecurenet_A9097 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2EA5:
			this.RTDBtnRadProfLabtoolAnalogBassControl_A19506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EB2:
			this.RTDBtnRadProfAudioSettingsAnalog_A7438 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EBF:
			this.GrpBoxExpanderRadioProfilesGeneralSurveillanceMode = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2ECC:
			this.RTDBtnRadProfAudioSettingsAnalogFixedGain2_A7441 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ED9:
			this.VolumeControlRadioAccessory_42598 = (global::AcpUI.AcpLabel)target;
			this.VolumeControlRadioAccessory_42598.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EFD:
			this.RadProfAudioSettingsBluetoothMicGainLevel_41989Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F0A:
			this.CVBtnRadProfGeneralDisableCallAlertsNotification_A19572 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F17:
			this.CpyBtnGainSensitivityRadio_42606 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F24:
			this.RTDBtnRadProfCustomSettingsRadioMicAutoMode_42673 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F31:
			this.CVBtnReceiveAGCGroupSettingInternal_42615 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F3E:
			this.AGCGainControlOutputAccessory_42644Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F4B:
			this.RTDBtnVolumeControlRadioAccessory_42598 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F58:
			this.RTDBtnReceiveAGCGroupSettingAccessory_42616 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F65:
			this.CpyBtnDigitalLowFrequencyBandAccessory_42652 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F72:
			this.RadProfAudioSettingsSecurenetFixedGain1_A9100 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsSecurenetFixedGain1_A9100.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F96:
			this.CVBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FA3:
			this.DigitalHighFrequencyBandAccessory_42655 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DigitalHighFrequencyBandAccessory_42655.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FC7:
			this.ReceiveAGCGainControlTotalInternal_42741Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2FD4:
			this.RTDBtnRadProfAudioSettingsSecurenet_A9097 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FE1:
			this.RadProfAudioSettingsDigitalFixedGain2_A7855Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2FEE:
			this.RTDBtnNoiseReductionGroupSettingRadio_42584 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FFB:
			this.CpyBtnMidFrequencyBandRadio_42640 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3008:
			this.AudioEqualizationGroupSettingAccessory_42614 = (global::AcpUI.AcpComboBox)target;
			this.AudioEqualizationGroupSettingAccessory_42614.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_302C:
			this.CpyBtnAnalogMidFrequencyBandAccessory_42649 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3039:
			this.CVBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3046:
			this.CVBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3053:
			this.LblLowFrequencyBandRadio_42638 = (global::AcpUI.AcpLabel)target;
			this.LblLowFrequencyBandRadio_42638.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3077:
			this.LblRadProfAudioSettingsFeedbackSupression = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsFeedbackSupression.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_309B:
			this.LblRadProfAudioSettingsDigital_A7850 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsDigital_A7850.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30BF:
			this.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30CC:
			this.CVBtnAGCGainControlOutputAccessory_42644 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30D9:
			this.RTDBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30E6:
			this.LblRadProfAudioSettingsFeedbackSupressionTime_A43793 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsFeedbackSupressionTime_A43793.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_310A:
			this.CVBtnAnalogMidFrequencyBandRadio_42648 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3117:
			this.ReceiveAGCEnableAccessory_42744Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3124:
			this.CVBtnAnalogLowFrequencyBandAccessory_42647 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3131:
			this.RTDBtnGainSensitivityGroupSettingAccessory_42610 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_313E:
			this.LblGainSensitivityRadio_42606 = (global::AcpUI.AcpLabel)target;
			this.LblGainSensitivityRadio_42606.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3162:
			this.LblRadProfAudioSettingsIntMicPassAlarmFilter_A42382 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsIntMicPassAlarmFilter_A42382.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3186:
			this.CpyBtnRadProfAudioSettingsDigital_A7850 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3193:
			this.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_31A0:
			this.RTDBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31AD:
			this.RadProfAlertTonesMinimumAlertToneVolume_A8521Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31BA:
			this.RadProfAudioSettingsOutput_A8679 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsOutput_A8679.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31DE:
			this.CpyBtnRadioProfilesAudioSettingsMicHWAGC_A37722 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31EB:
			this.RadProfLabtoolDigitalBassControl_A19507 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfLabtoolDigitalBassControl_A19507.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_320F:
			this.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_321C:
			this.RadProfGeneralDisableCriticalAlertsNotification_A19571Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3229:
			this.LblRadProfCustomSettingsRadioSAMMode_42672 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfCustomSettingsRadioSAMMode_42672.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_324D:
			this.LblReceiveAGCGroupSettingInternal_42615 = (global::AcpUI.AcpLabel)target;
			this.LblReceiveAGCGroupSettingInternal_42615.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3271:
			this.CpyBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_327E:
			this.CVBtnRadProfAudioSettingsAnalogAGC2_A7439 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_328B:
			this.RadProfAudioSettingsInternalMicSourceMode_A22193Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3298:
			this.LblRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32BC:
			this.RTDBtnRadProfAudioSettingsMaximumAudioVolume_A19577 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32C9:
			this.LblRadProfGeneralSpeakerAudioRouting_A19566 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralSpeakerAudioRouting_A19566.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32ED:
			this.CpyBtnRadProfGeneralDisableCriticalAlertsNotification_A19571 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32FA:
			this.CVBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3307:
			this.RTDBtnRadProfAudioSettingsDigital_A7850 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3314:
			this.CpyBtnRadioProfilesAdaptiveNoiseSuppressionRadio_42738 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3321:
			this.ReceiveAGCEnableAccessory_42744 = (global::AcpUI.AcpCheckBox)target;
			this.ReceiveAGCEnableAccessory_42744.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3345:
			this.RadProfAudioSettingsDigitalAGC1_A7854 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsDigitalAGC1_A7854.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3369:
			this.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3376:
			this.ExpanderRadioProfilesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_3383:
			this.CpyBtnRadProfCustomSettingsRadioMicOverloadComp_42675 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3390:
			this.CVBtnRadProfAudioSettingsFeedbackSupressionTime_A43793 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_339D:
			this.RTDBtnRadProfAudioSettingsAnalogAGC1_A7440 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_33AA:
			this.LblRadProfGeneralDisableCallAlertsNotification_A19572 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralDisableCallAlertsNotification_A19572.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33CE:
			this.CVBtnDigitalHighFrequencyBandAccessory_42655 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33DB:
			this.LblRadProfAudioSettingsAnalog_A7438 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsAnalog_A7438.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33FF:
			this.LblSecurenetMidFrequencyBandRadio_42658 = (global::AcpUI.AcpLabel)target;
			this.LblSecurenetMidFrequencyBandRadio_42658.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3423:
			this.CpyBtnRadProfCustomSettingsAccessoryMicAutoMode_42674 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3430:
			this.HighFrequencyBandAccessory_42643 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.HighFrequencyBandAccessory_42643.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3454:
			this.CVBtnRadProfPermanentTopDisplayBacklight = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3461:
			this.RTDBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_346E:
			this.RTDBtnRadProfAudioSettingsDigitalAGC2_A7853 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_347B:
			this.RadProfAudioSettingsSecurenet_A9097 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsSecurenet_A9097.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_349F:
			this.LblRadProfPermanentTopDisplayBacklight = (global::AcpUI.AcpLabel)target;
			this.LblRadProfPermanentTopDisplayBacklight.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_34C3:
			this.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34D0:
			this.SecurenetHighFrequencyBandAccessory_42660 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SecurenetHighFrequencyBandAccessory_42660.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34F4:
			this.ReceiveAGCGroupSettingInternal_42615Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3501:
			this.GainSensitivityAccessory_42607 = (global::AcpUI.AcpLabel)target;
			this.GainSensitivityAccessory_42607.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3525:
			this.CpyBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3532:
			this.SecurenetLowFrequencyBandAccessory_42657Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_353F:
			this.LblAudioEqualizationRadio_42611 = (global::AcpUI.AcpLabel)target;
			this.LblAudioEqualizationRadio_42611.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3563:
			this.CVBtnRadProfGeneralRadioProfileName_A19564 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3570:
			this.LblRadProfAudioSettingsSecurenet_A9097 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsSecurenet_A9097.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3594:
			this.RTDBtnSecurenetMidFrequencyBandAccessory_42659 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35A1:
			this.RadProfPermanentTopDisplayBacklight = (global::AcpUI.AcpCheckBox)target;
			this.RadProfPermanentTopDisplayBacklight.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35C5:
			this.DigitalMidFrequencyBandAccessory_42654Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35D2:
			this.LblRadProfAudioSettingsBluetoothMicGainLevel_41989 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsBluetoothMicGainLevel_41989.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35F6:
			this.RTDBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3603:
			this.CpyBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3610:
			this.CpyBtnGainControlAccessory_42618 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_361D:
			this.CpyBtnDigitalHighFrequencyBandAccessory_42655 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_362A:
			this.AudioEqualizationGroupSettingRadio_42604 = (global::AcpUI.AcpComboBox)target;
			this.AudioEqualizationGroupSettingRadio_42604.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_364E:
			this.RTDBtnRadProfGeneralDisableTones_A7870 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_365B:
			this.RadProfAudioSettingsFeedbackSupression = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsFeedbackSupression.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_367F:
			this.RadProfPermanentTopDisplayBacklightComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_368C:
			this.RTDBtnReceiveAGCGainControlTotalAccessory_42742 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3699:
			this.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36BD:
			this.GrpBoxExpanderRadioProfilesAudioSettingsVolumeControl = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_36CA:
			this.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36EE:
			this.CpyBtnRadProfAudioSettingsSecurenetFixedGain1_A9100 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36FB:
			this.RadProfNVGEnable_A41615Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3708:
			this.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3715:
			this.RadProfAudioSettingsAnalog_A7438Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3722:
			this.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3746:
			this.g = true;
			return;
			IL_374B:
			this.NoiseReductionAccessory_42576 = (global::AcpUI.AcpLabel)target;
			this.NoiseReductionAccessory_42576.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_376F:
			this.LblNoiseReductionGroupSettingRadio_42584 = (global::AcpUI.AcpLabel)target;
			this.LblNoiseReductionGroupSettingRadio_42584.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3793:
			this.CpyBtnRadProfPermanentTopDisplayBacklight = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37A0:
			this.LblAlertTonesRadioAccessory_42601 = (global::AcpUI.AcpLabel)target;
			this.LblAlertTonesRadioAccessory_42601.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37C4:
			this.CpyBtnSecurenetMidFrequencyBandAccessory_42659 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37D1:
			this.GainSensitivityRadio_42606Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37DE:
			this.AGCGainControlTotalAccessory_42645 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AGCGainControlTotalAccessory_42645.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3802:
			this.RTDBtnNoiseReductionRadio_42575 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_380F:
			this.VolumeControlRadioAccessory_42598Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_381C:
			this.GainSensitivityRadio_42606 = (global::AcpUI.AcpLabel)target;
			this.GainSensitivityRadio_42606.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3840:
			this.RTDBtnRadProfCustomSettingsRadioSAMMode_42672 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_384D:
			this.CpyBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_385A:
			this.CpyBtnRadProfAudioSettingsAnalogFixedGain2_A7441 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3867:
			this.RadProfileSelectNoiseSensingVolumeControlComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3874:
			this.CVBtnReceiveAGCGainControlOutputInternal_42745 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3881:
			this.CVBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_388E:
			this.LblRadProfAlertTonesAlertToneVolumeOffsetdB_A7427 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesAlertToneVolumeOffsetdB_A7427.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38B2:
			this.DigitalLowFrequencyBandAccessory_42652 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DigitalLowFrequencyBandAccessory_42652.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_38D6:
			this.RTDBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38E3:
			this.CVBtnNoiseReductionGroupSettingAccessory_42585 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_38F0:
			this.CVBtnRadProfAudioSettingsOutput_A8679 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_38FD:
			this.RTDBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_390A:
			this.GrpBoxExpanderRadioProfilesAudioSettingsMicrophoneTXSettings = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3917:
			this.CpyBtnReceiveAGCGainControlOutputInternal_42745 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3924:
			this.CVBtnRadProfAudioSettingsBluetoothMicGainLevel_41989 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3931:
			this.CpyBtnRadProfAudioSettingsDigitalFixedGain2_A7855 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_393E:
			this.AudioEqualizationGroupSettingRadio_42604Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_394B:
			this.PermanentFrontDisplayBacklight_A22337Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3958:
			this.CVBtnHighFrequencyBandRadio_42642 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3965:
			this.CVBtnDigitalMidFrequencyBandAccessory_42654 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3972:
			this.CpyBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_397F:
			this.CVBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_398C:
			this.RTDBtnLowFrequencyBandAccessory_42639 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3999:
			this.RTDBtnSecurenetMidFrequencyBandRadio_42658 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_39A6:
			this.RadProfLabtoolSecurenetBassControl_A19508 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfLabtoolSecurenetBassControl_A19508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39CA:
			this.MidFrequencyBandRadio_42640 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.MidFrequencyBandRadio_42640.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39EE:
			this.RadProfAudioSettingsOutput_A8679Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39FB:
			this.RTDBtnGainSensitivityRadio_42606 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A08:
			this.LblVolumeControlRadioAccessory_42598 = (global::AcpUI.AcpLabel)target;
			this.LblVolumeControlRadioAccessory_42598.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A2C:
			this.CpyBtnRadProfAudioSettingsDigitalAGC1_A7854 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A39:
			this.CVBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A46:
			this.RTDBtnRadProfAudioSettingsAnalogFixedGain1_A7442 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A53:
			this.CpyBtnGainSensitivityAccessory_42607 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A60:
			this.RTDBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A6D:
			this.AudioEqualizationRadio_42602Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3A7A:
			this.LblRadProfAlertTonesMinimumAudioVolume_A8517 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesMinimumAudioVolume_A8517.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A9E:
			this.AudioEqualizationGroupSettingAccessory_42605Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AAB:
			this.LblRadProfNVGEnable_A41615 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfNVGEnable_A41615.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3ACF:
			this.CVBtnRadProfAudioSettingsInternalMicSourceMode_A22193 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3ADC:
			this.RadProfCustomSettingsRadioMicAutoMode_42673Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AE9:
			this.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AF6:
			this.CpyBtnRadProfAudioSettingsTotal_A9394 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B03:
			this.RTDBtnRadProfNVGEnable_A41615 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B10:
			num = (short)1453326336;
			short num4 = num;
			this.RTDBtnPermanentFrontDisplayBacklight_A22337 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B46:
			this.RTDBtnAGCGainControlTotalAccessory_42645 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B53:
			this.GainControlRadio_42617 = (global::AcpUI.AcpLabel)target;
			this.GainControlRadio_42617.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B77:
			this.HLinkAudioSettings = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAudioSettings.Click += this.HLinkClick;
			return;
			IL_3B9B:
			this.CpyBtnRadProfGeneralDisableLights_A7866 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3BA8:
			this.CpyBtnRadProfGeneralDisableTones_A7870 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3BB5:
			this.RadioProfilesAdaptiveNoiseSuppressionAccessory_42739 = (global::AcpUI.AcpLabel)target;
			this.RadioProfilesAdaptiveNoiseSuppressionAccessory_42739.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3BD9:
			this.RadProfAudioSettingsMaximumAudioVolume_A19577Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3BE6:
			this.CVBtnRadProfAudioSettingsAnalogAGC1_A7440 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BF3:
			this.CVBtnAudioEqualizationGroupSettingAccessory_42614 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C00:
			this.RTDBtnGainControlRadio_42617 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C0D:
			this.LblRadProfGeneralDisableTones_A7870 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfGeneralDisableTones_A7870.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C31:
			this.CVBtnRadProfGeneralDisableCriticalAlertsNotification_A19571 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C3E:
			this.AudioEqualizationAccessory_42603 = (global::AcpUI.AcpLabel)target;
			this.AudioEqualizationAccessory_42603.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C62:
			this.HighFrequencyBandRadio_42642 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.HighFrequencyBandRadio_42642.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C86:
			this.NoiseReductionGroupSettingAccessory_42585Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C93:
			this.LblRadProfAudioSettingsInternalMicSourceMode_A22193 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsInternalMicSourceMode_A22193.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CB7:
			this.LblRadProfAudioSettingsMaximumAlertToneVolume_A21368 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAudioSettingsMaximumAlertToneVolume_A21368.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CDB:
			this.CpyBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CE8:
			this.CpyBtnRadProfGeneralSpeakerAudioRouting_A19566 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CF5:
			this.RTDBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D02:
			this.GainControlAccessory_42618Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3D0F:
			this.CVBtnReceiveAGCGroupSettingAccessory_42616 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D1C:
			this.RTDBtnRadProfLabtoolSecurenetBassControl_A19508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D29:
			this.ReceiveAGCEnableInternal_42743Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3D36:
			this.CVBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D43:
			this.LblRadProfLabtoolSecurenetBassControl_A19508 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfLabtoolSecurenetBassControl_A19508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D67:
			this.CpyBtnAnalogHighFrequencyBandAccessory_42650 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D74:
			this.RTDBtnMidFrequencyBandRadio_42640 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D81:
			this.MidFrequencyBandAccessory_42641 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.MidFrequencyBandAccessory_42641.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DA5:
			this.GrpBoxExpanderRadioProfilesAudioSettingsPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3DB2:
			this.RadProfAudioSettingsAnalogAGC2_A7439 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAudioSettingsAnalogAGC2_A7439.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DD6:
			this.DigitalMidFrequencyBandAccessory_42654 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DigitalMidFrequencyBandAccessory_42654.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DFA:
			this.GrpBoxExpanderRadioProfilesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E07:
			this.CpyBtnAGCGainControlTotalAccessory_42645 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E14:
			this.CVBtnRadProfCustomSettingsRadioMicAutoMode_42673 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E21:
			this.ReceiveAGCGainControlTotalAccessory_42742 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ReceiveAGCGainControlTotalAccessory_42742.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E45:
			this.RadProfAudioSettingsAnalogFixedGain1_A7442 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsAnalogFixedGain1_A7442.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E69:
			this.CpyBtnRadProfCustomSettingsRadioSAMMode_42672 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E76:
			this.RadProfGeneralDisableTones_A7870 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfGeneralDisableTones_A7870.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E9A:
			this.GainSensitivityGroupSettingRadio_42608Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3EA7:
			this.CpyBtnDigitalMidFrequencyBandAccessory_42654 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EB4:
			this.RTDBtnSecurenetLowFrequencyBandAccessory_42657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3EC1:
			this.HLinkLabtoolRAD_PROF_CDA = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtoolRAD_PROF_CDA.Click += this.HLinkClick;
			return;
			IL_3EE5:
			this.CVBtnAGCGainControlTotalAccessory_42645 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3EF2:
			this.HLinkAlertTones = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAlertTones.Click += this.HLinkClick;
			return;
			IL_3F16:
			this.CpyBtnAudioEqualizationGroupSettingAccessory_42614 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F23:
			this.RadProfAudioSettingsFeedbackSupressionTime_A43793 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAudioSettingsFeedbackSupressionTime_A43793.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F47:
			this.CVBtnAudioEqualizationGroupSettingRadio_42604 = (global::AcpUI.AcpCustomViewCheckBox)target;
		}

		// Token: 0x04002354 RID: 9044
		private bool a;

		// Token: 0x04002355 RID: 9045
		private static global::System.Windows.GridLength b;

		// Token: 0x04002356 RID: 9046
		private static global::System.Windows.GridLength c;

		// Token: 0x04002357 RID: 9047
		private static bool d;

		// Token: 0x04002358 RID: 9048
		private global::System.Collections.Generic.IList<global::AcpUI.AcpLabel> e;

		// Token: 0x04002359 RID: 9049
		private global::System.Collections.Generic.IList<global::AcpUI.AcpLabel> f;

		// Token: 0x0400235A RID: 9050
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageRadioProfiles;

		// Token: 0x0400235B RID: 9051
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400235C RID: 9052
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400235D RID: 9053
		internal global::System.Windows.Documents.Hyperlink HLinkAudioSettings;

		// Token: 0x0400235E RID: 9054
		internal global::System.Windows.Documents.Hyperlink HLinkLabtoolRAD_PROF_CDA;

		// Token: 0x0400235F RID: 9055
		internal global::System.Windows.Documents.Hyperlink HLinkAlertTones;

		// Token: 0x04002360 RID: 9056
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002361 RID: 9057
		internal global::AcpUI.AcpExpander ExpanderRadioProfilesGeneral;

		// Token: 0x04002362 RID: 9058
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesGeneralPseudo0;

		// Token: 0x04002363 RID: 9059
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralRadioProfileName_A19564;

		// Token: 0x04002364 RID: 9060
		internal global::AcpUI.AcpLabel LblRadProfGeneralRadioProfileName_A19564;

		// Token: 0x04002365 RID: 9061
		internal global::AcpUI.AcpTextBox RadProfGeneralRadioProfileName_A19564;

		// Token: 0x04002366 RID: 9062
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralRadioProfileName_A19564;

		// Token: 0x04002367 RID: 9063
		internal global::AcpUI.AcpLabel RadProfGeneralRadioProfileName_A19564Comp;

		// Token: 0x04002368 RID: 9064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfNVGEnable_A41615;

		// Token: 0x04002369 RID: 9065
		internal global::AcpUI.AcpLabel LblRadProfNVGEnable_A41615;

		// Token: 0x0400236A RID: 9066
		internal global::AcpUI.AcpCheckBox RadProfNVGEnable_A41615;

		// Token: 0x0400236B RID: 9067
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfNVGEnable_A41615;

		// Token: 0x0400236C RID: 9068
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfNVGEnable_A41615;

		// Token: 0x0400236D RID: 9069
		internal global::AcpUI.AcpCheckBox RadProfNVGEnable_A41615Comp;

		// Token: 0x0400236E RID: 9070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPermanentFrontDisplayBacklight_A22337;

		// Token: 0x0400236F RID: 9071
		internal global::AcpUI.AcpLabel LblPermanentFrontDisplayBacklight_A22337;

		// Token: 0x04002370 RID: 9072
		internal global::AcpUI.AcpCheckBox PermanentFrontDisplayBacklight_A22337;

		// Token: 0x04002371 RID: 9073
		internal global::AcpUI.AcpRtdButton RTDBtnPermanentFrontDisplayBacklight_A22337;

		// Token: 0x04002372 RID: 9074
		internal global::AcpUI.AcpCopyButton CpyBtnPermanentFrontDisplayBacklight_A22337;

		// Token: 0x04002373 RID: 9075
		internal global::AcpUI.AcpCheckBox PermanentFrontDisplayBacklight_A22337Comp;

		// Token: 0x04002374 RID: 9076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002375 RID: 9077
		internal global::AcpUI.AcpLabel LblRadProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002376 RID: 9078
		internal global::AcpUI.AcpCheckBox RadProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002377 RID: 9079
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002378 RID: 9080
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002379 RID: 9081
		internal global::AcpUI.AcpCheckBox RadProfPermanentDisableTxRxLED_A41609Comp;

		// Token: 0x0400237A RID: 9082
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfPermanentTopDisplayBacklight;

		// Token: 0x0400237B RID: 9083
		internal global::AcpUI.AcpLabel LblRadProfPermanentTopDisplayBacklight;

		// Token: 0x0400237C RID: 9084
		internal global::AcpUI.AcpCheckBox RadProfPermanentTopDisplayBacklight;

		// Token: 0x0400237D RID: 9085
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfPermanentTopDisplayBacklight;

		// Token: 0x0400237E RID: 9086
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfPermanentTopDisplayBacklight;

		// Token: 0x0400237F RID: 9087
		internal global::AcpUI.AcpCheckBox RadProfPermanentTopDisplayBacklightComp;

		// Token: 0x04002380 RID: 9088
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002381 RID: 9089
		internal global::AcpUI.AcpLabel LblRadProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002382 RID: 9090
		internal global::AcpUI.AcpCheckBox RadProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002383 RID: 9091
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002384 RID: 9092
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002385 RID: 9093
		internal global::AcpUI.AcpCheckBox RadProfileSelectNoiseSensingVolumeControlComp;

		// Token: 0x04002386 RID: 9094
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesGeneralSurveillanceMode;

		// Token: 0x04002387 RID: 9095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x04002388 RID: 9096
		internal global::AcpUI.AcpLabel LblRadProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x04002389 RID: 9097
		internal global::AcpUI.AcpComboBox RadProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x0400238A RID: 9098
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x0400238B RID: 9099
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x0400238C RID: 9100
		internal global::AcpUI.AcpLabel RadProfGeneralSpeakerAudioRouting_A19566Comp;

		// Token: 0x0400238D RID: 9101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralDisableLights_A7866;

		// Token: 0x0400238E RID: 9102
		internal global::AcpUI.AcpLabel LblRadProfGeneralDisableLights_A7866;

		// Token: 0x0400238F RID: 9103
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableLights_A7866;

		// Token: 0x04002390 RID: 9104
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralDisableLights_A7866;

		// Token: 0x04002391 RID: 9105
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralDisableLights_A7866;

		// Token: 0x04002392 RID: 9106
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableLights_A7866Comp;

		// Token: 0x04002393 RID: 9107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralDisableTones_A7870;

		// Token: 0x04002394 RID: 9108
		internal global::AcpUI.AcpLabel LblRadProfGeneralDisableTones_A7870;

		// Token: 0x04002395 RID: 9109
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableTones_A7870;

		// Token: 0x04002396 RID: 9110
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralDisableTones_A7870;

		// Token: 0x04002397 RID: 9111
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralDisableTones_A7870;

		// Token: 0x04002398 RID: 9112
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableTones_A7870Comp;

		// Token: 0x04002399 RID: 9113
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesGeneralIntelligentLighting;

		// Token: 0x0400239A RID: 9114
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x0400239B RID: 9115
		internal global::AcpUI.AcpLabel LblRadProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x0400239C RID: 9116
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x0400239D RID: 9117
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x0400239E RID: 9118
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x0400239F RID: 9119
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableEmergencyAlertsNotification_A19570Comp;

		// Token: 0x040023A0 RID: 9120
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x040023A1 RID: 9121
		internal global::AcpUI.AcpLabel LblRadProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x040023A2 RID: 9122
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x040023A3 RID: 9123
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x040023A4 RID: 9124
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x040023A5 RID: 9125
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableCriticalAlertsNotification_A19571Comp;

		// Token: 0x040023A6 RID: 9126
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x040023A7 RID: 9127
		internal global::AcpUI.AcpLabel LblRadProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x040023A8 RID: 9128
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x040023A9 RID: 9129
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x040023AA RID: 9130
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x040023AB RID: 9131
		internal global::AcpUI.AcpCheckBox RadProfGeneralDisableCallAlertsNotification_A19572Comp;

		// Token: 0x040023AC RID: 9132
		internal global::AcpUI.AcpExpander ExpanderRadioProfilesAudioSettings;

		// Token: 0x040023AD RID: 9133
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsVolumeControl;

		// Token: 0x040023AE RID: 9134
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsNoiseReduction;

		// Token: 0x040023AF RID: 9135
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174;

		// Token: 0x040023B0 RID: 9136
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174;

		// Token: 0x040023B1 RID: 9137
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174;

		// Token: 0x040023B2 RID: 9138
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174;

		// Token: 0x040023B3 RID: 9139
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174;

		// Token: 0x040023B4 RID: 9140
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomGlobalNoiseReductionEnable_A36174Comp;

		// Token: 0x040023B5 RID: 9141
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsPseudo2;

		// Token: 0x040023B6 RID: 9142
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioProfilesAudioSettingsMicHWAGC_A37722;

		// Token: 0x040023B7 RID: 9143
		internal global::AcpUI.AcpLabel LblRadioProfilesAudioSettingsMicHWAGC_A37722;

		// Token: 0x040023B8 RID: 9144
		internal global::AcpUI.AcpCheckBox RadioProfilesAudioSettingsMicHWAGC_A37722;

		// Token: 0x040023B9 RID: 9145
		internal global::AcpUI.AcpRtdButton RTDBtnRadioProfilesAudioSettingsMicHWAGC_A37722;

		// Token: 0x040023BA RID: 9146
		internal global::AcpUI.AcpCopyButton CpyBtnRadioProfilesAudioSettingsMicHWAGC_A37722;

		// Token: 0x040023BB RID: 9147
		internal global::AcpUI.AcpCheckBox RadioProfilesAudioSettingsMicHWAGC_A37722Comp;

		// Token: 0x040023BC RID: 9148
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsFeedbackSupressionTime_A43793;

		// Token: 0x040023BD RID: 9149
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsFeedbackSupressionTime_A43793;

		// Token: 0x040023BE RID: 9150
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsFeedbackSupressionTime_A43793;

		// Token: 0x040023BF RID: 9151
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsFeedbackSupressionTime_A43793;

		// Token: 0x040023C0 RID: 9152
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsFeedbackSupressionTime_A43793;

		// Token: 0x040023C1 RID: 9153
		internal global::AcpUI.AcpLabel RadProfAudioSettingsFeedbackSupressionTime_A43793Comp;

		// Token: 0x040023C2 RID: 9154
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsInternalMicGain;

		// Token: 0x040023C3 RID: 9155
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsExternalMicGain;

		// Token: 0x040023C4 RID: 9156
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsAGC;

		// Token: 0x040023C5 RID: 9157
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsTrebleControl;

		// Token: 0x040023C6 RID: 9158
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsMicrophoneTXSettings;

		// Token: 0x040023C7 RID: 9159
		internal global::AcpUI.AcpLabel LblNoiseReductionRadio_42575;

		// Token: 0x040023C8 RID: 9160
		internal global::AcpUI.AcpLabel NoiseReductionRadio_42575;

		// Token: 0x040023C9 RID: 9161
		internal global::AcpUI.AcpRtdButton RTDBtnNoiseReductionRadio_42575;

		// Token: 0x040023CA RID: 9162
		internal global::AcpUI.AcpCopyButton CpyBtnNoiseReductionRadio_42575;

		// Token: 0x040023CB RID: 9163
		internal global::AcpUI.AcpLabel NoiseReductionRadio_42575Comp;

		// Token: 0x040023CC RID: 9164
		internal global::AcpUI.AcpLabel NoiseReductionAccessory_42576;

		// Token: 0x040023CD RID: 9165
		internal global::AcpUI.AcpRtdButton RTDBtnNoiseReductionAccessory_42576;

		// Token: 0x040023CE RID: 9166
		internal global::AcpUI.AcpCopyButton CpyBtnNoiseReductionAccessory_42576;

		// Token: 0x040023CF RID: 9167
		internal global::AcpUI.AcpLabel NoiseReductionAccessory_42576Comp;

		// Token: 0x040023D0 RID: 9168
		internal global::AcpUI.AcpLabel LblNoiseReductionGroupSettingRadio_42584;

		// Token: 0x040023D1 RID: 9169
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnNoiseReductionGroupSettingRadio_42584;

		// Token: 0x040023D2 RID: 9170
		internal global::AcpUI.AcpComboBox NoiseReductionGroupSettingRadio_42584;

		// Token: 0x040023D3 RID: 9171
		internal global::AcpUI.AcpRtdButton RTDBtnNoiseReductionGroupSettingRadio_42584;

		// Token: 0x040023D4 RID: 9172
		internal global::AcpUI.AcpCopyButton CpyBtnNoiseReductionGroupSettingRadio_42584;

		// Token: 0x040023D5 RID: 9173
		internal global::AcpUI.AcpLabel NoiseReductionGroupSettingRadio_42584Comp;

		// Token: 0x040023D6 RID: 9174
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnNoiseReductionGroupSettingAccessory_42585;

		// Token: 0x040023D7 RID: 9175
		internal global::AcpUI.AcpComboBox NoiseReductionGroupSettingAccessory_42585;

		// Token: 0x040023D8 RID: 9176
		internal global::AcpUI.AcpRtdButton RTDBtnNoiseReductionGroupSettingAccessory_42585;

		// Token: 0x040023D9 RID: 9177
		internal global::AcpUI.AcpCopyButton CpyBtnNoiseReductionGroupSettingAccessory_42585;

		// Token: 0x040023DA RID: 9178
		internal global::AcpUI.AcpLabel NoiseReductionGroupSettingAccessory_42585Comp;

		// Token: 0x040023DB RID: 9179
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294;

		// Token: 0x040023DC RID: 9180
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294;

		// Token: 0x040023DD RID: 9181
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294;

		// Token: 0x040023DE RID: 9182
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294;

		// Token: 0x040023DF RID: 9183
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294;

		// Token: 0x040023E0 RID: 9184
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294Comp;

		// Token: 0x040023E1 RID: 9185
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294;

		// Token: 0x040023E2 RID: 9186
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294;

		// Token: 0x040023E3 RID: 9187
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294;

		// Token: 0x040023E4 RID: 9188
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294;

		// Token: 0x040023E5 RID: 9189
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294Comp;

		// Token: 0x040023E6 RID: 9190
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;

		// Token: 0x040023E7 RID: 9191
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;

		// Token: 0x040023E8 RID: 9192
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;

		// Token: 0x040023E9 RID: 9193
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;

		// Token: 0x040023EA RID: 9194
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;

		// Token: 0x040023EB RID: 9195
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292Comp;

		// Token: 0x040023EC RID: 9196
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291;

		// Token: 0x040023ED RID: 9197
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291;

		// Token: 0x040023EE RID: 9198
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291;

		// Token: 0x040023EF RID: 9199
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291;

		// Token: 0x040023F0 RID: 9200
		internal global::AcpUI.AcpLabel RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291Comp;

		// Token: 0x040023F1 RID: 9201
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;

		// Token: 0x040023F2 RID: 9202
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;

		// Token: 0x040023F3 RID: 9203
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;

		// Token: 0x040023F4 RID: 9204
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;

		// Token: 0x040023F5 RID: 9205
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;

		// Token: 0x040023F6 RID: 9206
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194Comp;

		// Token: 0x040023F7 RID: 9207
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511;

		// Token: 0x040023F8 RID: 9208
		internal global::AcpUI.AcpComboBox RadProfExternalMicWindNoiseReductionLevelSelection_A21511;

		// Token: 0x040023F9 RID: 9209
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511;

		// Token: 0x040023FA RID: 9210
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfExternalMicWindNoiseReductionLevelSelection_A21511;

		// Token: 0x040023FB RID: 9211
		internal global::AcpUI.AcpLabel RadProfExternalMicWindNoiseReductionLevelSelection_A21511Comp;

		// Token: 0x040023FC RID: 9212
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsIntMicPassAlarmFilter_A42382;

		// Token: 0x040023FD RID: 9213
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382;

		// Token: 0x040023FE RID: 9214
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsIntMicPassAlarmFilter_A42382;

		// Token: 0x040023FF RID: 9215
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382;

		// Token: 0x04002400 RID: 9216
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsIntMicPassAlarmFilter_A42382;

		// Token: 0x04002401 RID: 9217
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsIntMicPassAlarmFilter_A42382Comp;

		// Token: 0x04002402 RID: 9218
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386;

		// Token: 0x04002403 RID: 9219
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsExternalMicPassAlarmFilter_A42386;

		// Token: 0x04002404 RID: 9220
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386;

		// Token: 0x04002405 RID: 9221
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsExternalMicPassAlarmFilter_A42386;

		// Token: 0x04002406 RID: 9222
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsExternalMicPassAlarmFilter_A42386Comp;

		// Token: 0x04002407 RID: 9223
		internal global::AcpUI.AcpLabel LblCustomNoiseReductionRadio_42599;

		// Token: 0x04002408 RID: 9224
		internal global::AcpUI.AcpLabel CustomNoiseReductionRadio_42599;

		// Token: 0x04002409 RID: 9225
		internal global::AcpUI.AcpRtdButton RTDBtnCustomNoiseReductionRadio_42599;

		// Token: 0x0400240A RID: 9226
		internal global::AcpUI.AcpCopyButton CpyBtnCustomNoiseReductionRadio_42599;

		// Token: 0x0400240B RID: 9227
		internal global::AcpUI.AcpLabel CustomNoiseReductionRadio_42599Comp;

		// Token: 0x0400240C RID: 9228
		internal global::AcpUI.AcpLabel CustomNoiseReductionAccessory_42600;

		// Token: 0x0400240D RID: 9229
		internal global::AcpUI.AcpRtdButton RTDBtnCustomNoiseReductionAccessory_42600;

		// Token: 0x0400240E RID: 9230
		internal global::AcpUI.AcpCopyButton CpyBtnCustomNoiseReductionAccessory_42600;

		// Token: 0x0400240F RID: 9231
		internal global::AcpUI.AcpLabel CustomNoiseReductionAccessory_42600Comp;

		// Token: 0x04002410 RID: 9232
		internal global::AcpUI.AcpLabel LblRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x04002411 RID: 9233
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x04002412 RID: 9234
		internal global::AcpUI.AcpComboBox RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x04002413 RID: 9235
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x04002414 RID: 9236
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x04002415 RID: 9237
		internal global::AcpUI.AcpLabel RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312Comp;

		// Token: 0x04002416 RID: 9238
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;

		// Token: 0x04002417 RID: 9239
		internal global::AcpUI.AcpComboBox RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;

		// Token: 0x04002418 RID: 9240
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;

		// Token: 0x04002419 RID: 9241
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;

		// Token: 0x0400241A RID: 9242
		internal global::AcpUI.AcpLabel RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314Comp;

		// Token: 0x0400241B RID: 9243
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x0400241C RID: 9244
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x0400241D RID: 9245
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x0400241E RID: 9246
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x0400241F RID: 9247
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x04002420 RID: 9248
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicOtherNoiseMode_A22196Comp;

		// Token: 0x04002421 RID: 9249
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551;

		// Token: 0x04002422 RID: 9250
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsExternalMicOtherNoiseMode_A21551;

		// Token: 0x04002423 RID: 9251
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551;

		// Token: 0x04002424 RID: 9252
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsExternalMicOtherNoiseMode_A21551;

		// Token: 0x04002425 RID: 9253
		internal global::AcpUI.AcpLabel RadProfAudioSettingsExternalMicOtherNoiseMode_A21551Comp;

		// Token: 0x04002426 RID: 9254
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x04002427 RID: 9255
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x04002428 RID: 9256
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x04002429 RID: 9257
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x0400242A RID: 9258
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x0400242B RID: 9259
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197Comp;

		// Token: 0x0400242C RID: 9260
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;

		// Token: 0x0400242D RID: 9261
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;

		// Token: 0x0400242E RID: 9262
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;

		// Token: 0x0400242F RID: 9263
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;

		// Token: 0x04002430 RID: 9264
		internal global::AcpUI.AcpLabel RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550Comp;

		// Token: 0x04002431 RID: 9265
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x04002432 RID: 9266
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x04002433 RID: 9267
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x04002434 RID: 9268
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x04002435 RID: 9269
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x04002436 RID: 9270
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicSourceMode_A22193Comp;

		// Token: 0x04002437 RID: 9271
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfLabtoolExternalMicSourceMode_A21548;

		// Token: 0x04002438 RID: 9272
		internal global::AcpUI.AcpComboBox RadProfLabtoolExternalMicSourceMode_A21548;

		// Token: 0x04002439 RID: 9273
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfLabtoolExternalMicSourceMode_A21548;

		// Token: 0x0400243A RID: 9274
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfLabtoolExternalMicSourceMode_A21548;

		// Token: 0x0400243B RID: 9275
		internal global::AcpUI.AcpLabel RadProfLabtoolExternalMicSourceMode_A21548Comp;

		// Token: 0x0400243C RID: 9276
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x0400243D RID: 9277
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x0400243E RID: 9278
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x0400243F RID: 9279
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x04002440 RID: 9280
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x04002441 RID: 9281
		internal global::AcpUI.AcpLabel RadProfAudioSettingsInternalMicDirectivityMode_A22195Comp;

		// Token: 0x04002442 RID: 9282
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549;

		// Token: 0x04002443 RID: 9283
		internal global::AcpUI.AcpComboBox RadProfAudioSettingsExternalMicDirectivityMode_A21549;

		// Token: 0x04002444 RID: 9284
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549;

		// Token: 0x04002445 RID: 9285
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsExternalMicDirectivityMode_A21549;

		// Token: 0x04002446 RID: 9286
		internal global::AcpUI.AcpLabel RadProfAudioSettingsExternalMicDirectivityMode_A21549Comp;

		// Token: 0x04002447 RID: 9287
		internal global::AcpUI.AcpLabel LblRadioProfilesAdaptiveNoiseSuppressionRadio_42738;

		// Token: 0x04002448 RID: 9288
		internal global::AcpUI.AcpLabel RadioProfilesAdaptiveNoiseSuppressionRadio_42738;

		// Token: 0x04002449 RID: 9289
		internal global::AcpUI.AcpRtdButton RTDBtnRadioProfilesAdaptiveNoiseSuppressionRadio_42738;

		// Token: 0x0400244A RID: 9290
		internal global::AcpUI.AcpCopyButton CpyBtnRadioProfilesAdaptiveNoiseSuppressionRadio_42738;

		// Token: 0x0400244B RID: 9291
		internal global::AcpUI.AcpLabel RadioProfilesAdaptiveNoiseSuppressionRadio_42738Comp;

		// Token: 0x0400244C RID: 9292
		internal global::AcpUI.AcpLabel RadioProfilesAdaptiveNoiseSuppressionAccessory_42739;

		// Token: 0x0400244D RID: 9293
		internal global::AcpUI.AcpRtdButton RTDBtnRadioProfilesAdaptiveNoiseSuppressionAccessory_42739;

		// Token: 0x0400244E RID: 9294
		internal global::AcpUI.AcpCopyButton CpyBtnRadioProfilesAdaptiveNoiseSuppressionAccessory_42739;

		// Token: 0x0400244F RID: 9295
		internal global::AcpUI.AcpLabel RadioProfilesAdaptiveNoiseSuppressionAccessory_42739Comp;

		// Token: 0x04002450 RID: 9296
		internal global::AcpUI.AcpLabel LblRadProfCustomSettingsRadioSAMMode_42672;

		// Token: 0x04002451 RID: 9297
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfCustomSettingsRadioSAMMode_42672;

		// Token: 0x04002452 RID: 9298
		internal global::AcpUI.AcpComboBox RadProfCustomSettingsRadioSAMMode_42672;

		// Token: 0x04002453 RID: 9299
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfCustomSettingsRadioSAMMode_42672;

		// Token: 0x04002454 RID: 9300
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfCustomSettingsRadioSAMMode_42672;

		// Token: 0x04002455 RID: 9301
		internal global::AcpUI.AcpLabel RadProfCustomSettingsRadioSAMMode_42672Comp;

		// Token: 0x04002456 RID: 9302
		internal global::AcpUI.AcpLabel LblRadProfCustomSettingsRadioMicAutoMode_42673;

		// Token: 0x04002457 RID: 9303
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfCustomSettingsRadioMicAutoMode_42673;

		// Token: 0x04002458 RID: 9304
		internal global::AcpUI.AcpComboBox RadProfCustomSettingsRadioMicAutoMode_42673;

		// Token: 0x04002459 RID: 9305
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfCustomSettingsRadioMicAutoMode_42673;

		// Token: 0x0400245A RID: 9306
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfCustomSettingsRadioMicAutoMode_42673;

		// Token: 0x0400245B RID: 9307
		internal global::AcpUI.AcpLabel RadProfCustomSettingsRadioMicAutoMode_42673Comp;

		// Token: 0x0400245C RID: 9308
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfCustomSettingsAccessoryMicAutoMode_42674;

		// Token: 0x0400245D RID: 9309
		internal global::AcpUI.AcpComboBox RadProfCustomSettingsAccessoryMicAutoMode_42674;

		// Token: 0x0400245E RID: 9310
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfCustomSettingsAccessoryMicAutoMode_42674;

		// Token: 0x0400245F RID: 9311
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfCustomSettingsAccessoryMicAutoMode_42674;

		// Token: 0x04002460 RID: 9312
		internal global::AcpUI.AcpLabel RadProfCustomSettingsAccessoryMicAutoMode_42674Comp;

		// Token: 0x04002461 RID: 9313
		internal global::AcpUI.AcpLabel LblRadProfCustomSettingsRadioMicOverloadComp_42675;

		// Token: 0x04002462 RID: 9314
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfCustomSettingsRadioMicOverloadComp_42675;

		// Token: 0x04002463 RID: 9315
		internal global::AcpUI.AcpComboBox RadProfCustomSettingsRadioMicOverloadComp_42675;

		// Token: 0x04002464 RID: 9316
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfCustomSettingsRadioMicOverloadComp_42675;

		// Token: 0x04002465 RID: 9317
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfCustomSettingsRadioMicOverloadComp_42675;

		// Token: 0x04002466 RID: 9318
		internal global::AcpUI.AcpLabel RadProfCustomSettingsRadioMicOverloadComp_42675Comp;

		// Token: 0x04002467 RID: 9319
		internal global::AcpUI.AcpLabel LblGainSensitivityRadio_42606;

		// Token: 0x04002468 RID: 9320
		internal global::AcpUI.AcpLabel GainSensitivityRadio_42606;

		// Token: 0x04002469 RID: 9321
		internal global::AcpUI.AcpRtdButton RTDBtnGainSensitivityRadio_42606;

		// Token: 0x0400246A RID: 9322
		internal global::AcpUI.AcpCopyButton CpyBtnGainSensitivityRadio_42606;

		// Token: 0x0400246B RID: 9323
		internal global::AcpUI.AcpLabel GainSensitivityRadio_42606Comp;

		// Token: 0x0400246C RID: 9324
		internal global::AcpUI.AcpLabel GainSensitivityAccessory_42607;

		// Token: 0x0400246D RID: 9325
		internal global::AcpUI.AcpRtdButton RTDBtnGainSensitivityAccessory_42607;

		// Token: 0x0400246E RID: 9326
		internal global::AcpUI.AcpCopyButton CpyBtnGainSensitivityAccessory_42607;

		// Token: 0x0400246F RID: 9327
		internal global::AcpUI.AcpLabel GainSensitivityAccessory_42607Comp;

		// Token: 0x04002470 RID: 9328
		internal global::AcpUI.AcpLabel LblGainSensitivityGroupSettingRadio_42608;

		// Token: 0x04002471 RID: 9329
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGainSensitivityGroupSettingRadio_42608;

		// Token: 0x04002472 RID: 9330
		internal global::AcpUI.AcpComboBox GainSensitivityGroupSettingRadio_42608;

		// Token: 0x04002473 RID: 9331
		internal global::AcpUI.AcpRtdButton RTDBtnGainSensitivityGroupSettingRadio_42608;

		// Token: 0x04002474 RID: 9332
		internal global::AcpUI.AcpCopyButton CpyBtnGainSensitivityGroupSettingRadio_42608;

		// Token: 0x04002475 RID: 9333
		internal global::AcpUI.AcpLabel GainSensitivityGroupSettingRadio_42608Comp;

		// Token: 0x04002476 RID: 9334
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGainSensitivityGroupSettingAccessory_42610;

		// Token: 0x04002477 RID: 9335
		internal global::AcpUI.AcpComboBox GainSensitivityGroupSettingAccessory_42610;

		// Token: 0x04002478 RID: 9336
		internal global::AcpUI.AcpRtdButton RTDBtnGainSensitivityGroupSettingAccessory_42610;

		// Token: 0x04002479 RID: 9337
		internal global::AcpUI.AcpCopyButton CpyBtnGainSensitivityGroupSettingAccessory_42610;

		// Token: 0x0400247A RID: 9338
		internal global::AcpUI.AcpLabel GainSensitivityGroupSettingAccessory_42610Comp;

		// Token: 0x0400247B RID: 9339
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsAnalogAGC1_A7440;

		// Token: 0x0400247C RID: 9340
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsAnalogAGC1_A7440;

		// Token: 0x0400247D RID: 9341
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsAnalogAGC1_A7440;

		// Token: 0x0400247E RID: 9342
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsAnalogAGC1_A7440;

		// Token: 0x0400247F RID: 9343
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsAnalogAGC1_A7440;

		// Token: 0x04002480 RID: 9344
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsAnalogAGC1_A7440Comp;

		// Token: 0x04002481 RID: 9345
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsAnalogAGC2_A7439;

		// Token: 0x04002482 RID: 9346
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsAnalogAGC2_A7439;

		// Token: 0x04002483 RID: 9347
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsAnalogAGC2_A7439;

		// Token: 0x04002484 RID: 9348
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsAnalogAGC2_A7439;

		// Token: 0x04002485 RID: 9349
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsAnalogAGC2_A7439Comp;

		// Token: 0x04002486 RID: 9350
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsDigitalAGC1_A7854;

		// Token: 0x04002487 RID: 9351
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsDigitalAGC1_A7854;

		// Token: 0x04002488 RID: 9352
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsDigitalAGC1_A7854;

		// Token: 0x04002489 RID: 9353
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsDigitalAGC1_A7854;

		// Token: 0x0400248A RID: 9354
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsDigitalAGC1_A7854;

		// Token: 0x0400248B RID: 9355
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsDigitalAGC1_A7854Comp;

		// Token: 0x0400248C RID: 9356
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsDigitalAGC2_A7853;

		// Token: 0x0400248D RID: 9357
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsDigitalAGC2_A7853;

		// Token: 0x0400248E RID: 9358
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsDigitalAGC2_A7853;

		// Token: 0x0400248F RID: 9359
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsDigitalAGC2_A7853;

		// Token: 0x04002490 RID: 9360
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsDigitalAGC2_A7853Comp;

		// Token: 0x04002491 RID: 9361
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsSecurenetAGC1_A9099;

		// Token: 0x04002492 RID: 9362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsSecurenetAGC1_A9099;

		// Token: 0x04002493 RID: 9363
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsSecurenetAGC1_A9099;

		// Token: 0x04002494 RID: 9364
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsSecurenetAGC1_A9099;

		// Token: 0x04002495 RID: 9365
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsSecurenetAGC1_A9099;

		// Token: 0x04002496 RID: 9366
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsSecurenetAGC1_A9099Comp;

		// Token: 0x04002497 RID: 9367
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsSecurenetAGC2_A9098;

		// Token: 0x04002498 RID: 9368
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsSecurenetAGC2_A9098;

		// Token: 0x04002499 RID: 9369
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsSecurenetAGC2_A9098;

		// Token: 0x0400249A RID: 9370
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsSecurenetAGC2_A9098;

		// Token: 0x0400249B RID: 9371
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsSecurenetAGC2_A9098Comp;

		// Token: 0x0400249C RID: 9372
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsOutput_A8679;

		// Token: 0x0400249D RID: 9373
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsOutput_A8679;

		// Token: 0x0400249E RID: 9374
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsOutput_A8679;

		// Token: 0x0400249F RID: 9375
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsOutput_A8679;

		// Token: 0x040024A0 RID: 9376
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsOutput_A8679;

		// Token: 0x040024A1 RID: 9377
		internal global::AcpUI.AcpLabel RadProfAudioSettingsOutput_A8679Comp;

		// Token: 0x040024A2 RID: 9378
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAGCGainControlOutputAccessory_42644;

		// Token: 0x040024A3 RID: 9379
		internal global::AcpUI.AcpTextBoxSpinner AGCGainControlOutputAccessory_42644;

		// Token: 0x040024A4 RID: 9380
		internal global::AcpUI.AcpRtdButton RTDBtnAGCGainControlOutputAccessory_42644;

		// Token: 0x040024A5 RID: 9381
		internal global::AcpUI.AcpCopyButton CpyBtnAGCGainControlOutputAccessory_42644;

		// Token: 0x040024A6 RID: 9382
		internal global::AcpUI.AcpLabel AGCGainControlOutputAccessory_42644Comp;

		// Token: 0x040024A7 RID: 9383
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsTotal_A9394;

		// Token: 0x040024A8 RID: 9384
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsTotal_A9394;

		// Token: 0x040024A9 RID: 9385
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsTotal_A9394;

		// Token: 0x040024AA RID: 9386
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsTotal_A9394;

		// Token: 0x040024AB RID: 9387
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsTotal_A9394;

		// Token: 0x040024AC RID: 9388
		internal global::AcpUI.AcpLabel RadProfAudioSettingsTotal_A9394Comp;

		// Token: 0x040024AD RID: 9389
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAGCGainControlTotalAccessory_42645;

		// Token: 0x040024AE RID: 9390
		internal global::AcpUI.AcpTextBoxSpinner AGCGainControlTotalAccessory_42645;

		// Token: 0x040024AF RID: 9391
		internal global::AcpUI.AcpRtdButton RTDBtnAGCGainControlTotalAccessory_42645;

		// Token: 0x040024B0 RID: 9392
		internal global::AcpUI.AcpCopyButton CpyBtnAGCGainControlTotalAccessory_42645;

		// Token: 0x040024B1 RID: 9393
		internal global::AcpUI.AcpLabel AGCGainControlTotalAccessory_42645Comp;

		// Token: 0x040024B2 RID: 9394
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsAnalogFixedGain1_A7442;

		// Token: 0x040024B3 RID: 9395
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsAnalogFixedGain1_A7442;

		// Token: 0x040024B4 RID: 9396
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsAnalogFixedGain1_A7442;

		// Token: 0x040024B5 RID: 9397
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsAnalogFixedGain1_A7442;

		// Token: 0x040024B6 RID: 9398
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsAnalogFixedGain1_A7442;

		// Token: 0x040024B7 RID: 9399
		internal global::AcpUI.AcpLabel RadProfAudioSettingsAnalogFixedGain1_A7442Comp;

		// Token: 0x040024B8 RID: 9400
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsAnalogFixedGain2_A7441;

		// Token: 0x040024B9 RID: 9401
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsAnalogFixedGain2_A7441;

		// Token: 0x040024BA RID: 9402
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsAnalogFixedGain2_A7441;

		// Token: 0x040024BB RID: 9403
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsAnalogFixedGain2_A7441;

		// Token: 0x040024BC RID: 9404
		internal global::AcpUI.AcpLabel RadProfAudioSettingsAnalogFixedGain2_A7441Comp;

		// Token: 0x040024BD RID: 9405
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsDigitalFixedGain1_A7856;

		// Token: 0x040024BE RID: 9406
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsDigitalFixedGain1_A7856;

		// Token: 0x040024BF RID: 9407
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsDigitalFixedGain1_A7856;

		// Token: 0x040024C0 RID: 9408
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsDigitalFixedGain1_A7856;

		// Token: 0x040024C1 RID: 9409
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsDigitalFixedGain1_A7856;

		// Token: 0x040024C2 RID: 9410
		internal global::AcpUI.AcpLabel RadProfAudioSettingsDigitalFixedGain1_A7856Comp;

		// Token: 0x040024C3 RID: 9411
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsDigitalFixedGain2_A7855;

		// Token: 0x040024C4 RID: 9412
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsDigitalFixedGain2_A7855;

		// Token: 0x040024C5 RID: 9413
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsDigitalFixedGain2_A7855;

		// Token: 0x040024C6 RID: 9414
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsDigitalFixedGain2_A7855;

		// Token: 0x040024C7 RID: 9415
		internal global::AcpUI.AcpLabel RadProfAudioSettingsDigitalFixedGain2_A7855Comp;

		// Token: 0x040024C8 RID: 9416
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsSecurenetFixedGain1_A9100;

		// Token: 0x040024C9 RID: 9417
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsSecurenetFixedGain1_A9100;

		// Token: 0x040024CA RID: 9418
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsSecurenetFixedGain1_A9100;

		// Token: 0x040024CB RID: 9419
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsSecurenetFixedGain1_A9100;

		// Token: 0x040024CC RID: 9420
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsSecurenetFixedGain1_A9100;

		// Token: 0x040024CD RID: 9421
		internal global::AcpUI.AcpLabel RadProfAudioSettingsSecurenetFixedGain1_A9100Comp;

		// Token: 0x040024CE RID: 9422
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsSecurenetFixedGain2_A9101;

		// Token: 0x040024CF RID: 9423
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsSecurenetFixedGain2_A9101;

		// Token: 0x040024D0 RID: 9424
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsSecurenetFixedGain2_A9101;

		// Token: 0x040024D1 RID: 9425
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsSecurenetFixedGain2_A9101;

		// Token: 0x040024D2 RID: 9426
		internal global::AcpUI.AcpLabel RadProfAudioSettingsSecurenetFixedGain2_A9101Comp;

		// Token: 0x040024D3 RID: 9427
		internal global::AcpUI.AcpLabel LblRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;

		// Token: 0x040024D4 RID: 9428
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;

		// Token: 0x040024D5 RID: 9429
		internal global::AcpUI.AcpCheckBox RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;

		// Token: 0x040024D6 RID: 9430
		internal global::AcpUI.AcpRtdButton RTDBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;

		// Token: 0x040024D7 RID: 9431
		internal global::AcpUI.AcpCopyButton CpyBtnRadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;

		// Token: 0x040024D8 RID: 9432
		internal global::AcpUI.AcpCheckBox RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715Comp;

		// Token: 0x040024D9 RID: 9433
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;

		// Token: 0x040024DA RID: 9434
		internal global::AcpUI.AcpCheckBox RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;

		// Token: 0x040024DB RID: 9435
		internal global::AcpUI.AcpRtdButton RTDBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;

		// Token: 0x040024DC RID: 9436
		internal global::AcpUI.AcpCopyButton CpyBtnRadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;

		// Token: 0x040024DD RID: 9437
		internal global::AcpUI.AcpCheckBox RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661Comp;

		// Token: 0x040024DE RID: 9438
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsBluetoothMicGainLevel_41989;

		// Token: 0x040024DF RID: 9439
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsBluetoothMicGainLevel_41989;

		// Token: 0x040024E0 RID: 9440
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsBluetoothMicGainLevel_41989;

		// Token: 0x040024E1 RID: 9441
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsBluetoothMicGainLevel_41989;

		// Token: 0x040024E2 RID: 9442
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsBluetoothMicGainLevel_41989;

		// Token: 0x040024E3 RID: 9443
		internal global::AcpUI.AcpLabel RadProfAudioSettingsBluetoothMicGainLevel_41989Comp;

		// Token: 0x040024E4 RID: 9444
		internal global::AcpUI.AcpLabel LblAudioEqualizationRadio_42611;

		// Token: 0x040024E5 RID: 9445
		internal global::AcpUI.AcpLabel AudioEqualizationRadio_42611;

		// Token: 0x040024E6 RID: 9446
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationRadio_42611;

		// Token: 0x040024E7 RID: 9447
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationRadio_42611;

		// Token: 0x040024E8 RID: 9448
		internal global::AcpUI.AcpLabel AudioEqualizationRadio_42611Comp;

		// Token: 0x040024E9 RID: 9449
		internal global::AcpUI.AcpLabel AudioEqualizationAccessory_42612;

		// Token: 0x040024EA RID: 9450
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationAccessory_42612;

		// Token: 0x040024EB RID: 9451
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationAccessory_42612;

		// Token: 0x040024EC RID: 9452
		internal global::AcpUI.AcpLabel AudioEqualizationAccessory_42612Comp;

		// Token: 0x040024ED RID: 9453
		internal global::AcpUI.AcpLabel LblAudioEqualizationGroupSettingRadio_42613;

		// Token: 0x040024EE RID: 9454
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAudioEqualizationGroupSettingRadio_42613;

		// Token: 0x040024EF RID: 9455
		internal global::AcpUI.AcpComboBox AudioEqualizationGroupSettingRadio_42613;

		// Token: 0x040024F0 RID: 9456
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationGroupSettingRadio_42613;

		// Token: 0x040024F1 RID: 9457
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationGroupSettingRadio_42613;

		// Token: 0x040024F2 RID: 9458
		internal global::AcpUI.AcpLabel AudioEqualizationGroupSettingRadio_42613Comp;

		// Token: 0x040024F3 RID: 9459
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAudioEqualizationGroupSettingAccessory_42614;

		// Token: 0x040024F4 RID: 9460
		internal global::AcpUI.AcpComboBox AudioEqualizationGroupSettingAccessory_42614;

		// Token: 0x040024F5 RID: 9461
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationGroupSettingAccessory_42614;

		// Token: 0x040024F6 RID: 9462
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationGroupSettingAccessory_42614;

		// Token: 0x040024F7 RID: 9463
		internal global::AcpUI.AcpLabel AudioEqualizationGroupSettingAccessory_42614Comp;

		// Token: 0x040024F8 RID: 9464
		internal global::AcpUI.AcpLabel LblLowFrequencyBandRadio_42638;

		// Token: 0x040024F9 RID: 9465
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLowFrequencyBandRadio_42638;

		// Token: 0x040024FA RID: 9466
		internal global::AcpUI.AcpTextBoxSpinner LowFrequencyBandRadio_42638;

		// Token: 0x040024FB RID: 9467
		internal global::AcpUI.AcpRtdButton RTDBtnLowFrequencyBandRadio_42638;

		// Token: 0x040024FC RID: 9468
		internal global::AcpUI.AcpCopyButton CpyBtnLowFrequencyBandRadio_42638;

		// Token: 0x040024FD RID: 9469
		internal global::AcpUI.AcpLabel LowFrequencyBandRadio_42638Comp;

		// Token: 0x040024FE RID: 9470
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLowFrequencyBandAccessory_42639;

		// Token: 0x040024FF RID: 9471
		internal global::AcpUI.AcpTextBoxSpinner LowFrequencyBandAccessory_42639;

		// Token: 0x04002500 RID: 9472
		internal global::AcpUI.AcpRtdButton RTDBtnLowFrequencyBandAccessory_42639;

		// Token: 0x04002501 RID: 9473
		internal global::AcpUI.AcpCopyButton CpyBtnLowFrequencyBandAccessory_42639;

		// Token: 0x04002502 RID: 9474
		internal global::AcpUI.AcpLabel LowFrequencyBandAccessory_42639Comp;

		// Token: 0x04002503 RID: 9475
		internal global::AcpUI.AcpLabel LblMidFrequencyBandRadio_42640;

		// Token: 0x04002504 RID: 9476
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMidFrequencyBandRadio_42640;

		// Token: 0x04002505 RID: 9477
		internal global::AcpUI.AcpTextBoxSpinner MidFrequencyBandRadio_42640;

		// Token: 0x04002506 RID: 9478
		internal global::AcpUI.AcpRtdButton RTDBtnMidFrequencyBandRadio_42640;

		// Token: 0x04002507 RID: 9479
		internal global::AcpUI.AcpCopyButton CpyBtnMidFrequencyBandRadio_42640;

		// Token: 0x04002508 RID: 9480
		internal global::AcpUI.AcpLabel MidFrequencyBandRadio_42640Comp;

		// Token: 0x04002509 RID: 9481
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMidFrequencyBandAccessory_42641;

		// Token: 0x0400250A RID: 9482
		internal global::AcpUI.AcpTextBoxSpinner MidFrequencyBandAccessory_42641;

		// Token: 0x0400250B RID: 9483
		internal global::AcpUI.AcpRtdButton RTDBtnMidFrequencyBandAccessory_42641;

		// Token: 0x0400250C RID: 9484
		internal global::AcpUI.AcpCopyButton CpyBtnMidFrequencyBandAccessory_42641;

		// Token: 0x0400250D RID: 9485
		internal global::AcpUI.AcpLabel MidFrequencyBandAccessory_42641Comp;

		// Token: 0x0400250E RID: 9486
		internal global::AcpUI.AcpLabel LblHighFrequencyBandRadio_42642;

		// Token: 0x0400250F RID: 9487
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnHighFrequencyBandRadio_42642;

		// Token: 0x04002510 RID: 9488
		internal global::AcpUI.AcpTextBoxSpinner HighFrequencyBandRadio_42642;

		// Token: 0x04002511 RID: 9489
		internal global::AcpUI.AcpRtdButton RTDBtnHighFrequencyBandRadio_42642;

		// Token: 0x04002512 RID: 9490
		internal global::AcpUI.AcpCopyButton CpyBtnHighFrequencyBandRadio_42642;

		// Token: 0x04002513 RID: 9491
		internal global::AcpUI.AcpLabel HighFrequencyBandRadio_42642Comp;

		// Token: 0x04002514 RID: 9492
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnHighFrequencyBandAccessory_42643;

		// Token: 0x04002515 RID: 9493
		internal global::AcpUI.AcpTextBoxSpinner HighFrequencyBandAccessory_42643;

		// Token: 0x04002516 RID: 9494
		internal global::AcpUI.AcpRtdButton RTDBtnHighFrequencyBandAccessory_42643;

		// Token: 0x04002517 RID: 9495
		internal global::AcpUI.AcpCopyButton CpyBtnHighFrequencyBandAccessory_42643;

		// Token: 0x04002518 RID: 9496
		internal global::AcpUI.AcpLabel HighFrequencyBandAccessory_42643Comp;

		// Token: 0x04002519 RID: 9497
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsSpeakerRXSettings;

		// Token: 0x0400251A RID: 9498
		internal global::AcpUI.AcpCustomViewCheckBox CVBRadProfAudioSettingsFeedbackSupression;

		// Token: 0x0400251B RID: 9499
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsFeedbackSupression;

		// Token: 0x0400251C RID: 9500
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsFeedbackSupression;

		// Token: 0x0400251D RID: 9501
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsFeedbackSupression;

		// Token: 0x0400251E RID: 9502
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsFeedbackSupression;

		// Token: 0x0400251F RID: 9503
		internal global::AcpUI.AcpCheckBox RadProfAudioSettingsFeedbackSupressionComp;

		// Token: 0x04002520 RID: 9504
		internal global::AcpUI.AcpLabel LblVolumeControlRadioAccessory_42598;

		// Token: 0x04002521 RID: 9505
		internal global::AcpUI.AcpLabel VolumeControlRadioAccessory_42598;

		// Token: 0x04002522 RID: 9506
		internal global::AcpUI.AcpRtdButton RTDBtnVolumeControlRadioAccessory_42598;

		// Token: 0x04002523 RID: 9507
		internal global::AcpUI.AcpCopyButton CpyBtnVolumeControlRadioAccessory_42598;

		// Token: 0x04002524 RID: 9508
		internal global::AcpUI.AcpLabel VolumeControlRadioAccessory_42598Comp;

		// Token: 0x04002525 RID: 9509
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsMaximumAudioVolume_A19577;

		// Token: 0x04002526 RID: 9510
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsMaximumAudioVolume_A19577;

		// Token: 0x04002527 RID: 9511
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsMaximumAudioVolume_A19577;

		// Token: 0x04002528 RID: 9512
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsMaximumAudioVolume_A19577;

		// Token: 0x04002529 RID: 9513
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsMaximumAudioVolume_A19577;

		// Token: 0x0400252A RID: 9514
		internal global::AcpUI.AcpLabel RadProfAudioSettingsMaximumAudioVolume_A19577Comp;

		// Token: 0x0400252B RID: 9515
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesMinimumAudioVolume_A8517;

		// Token: 0x0400252C RID: 9516
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesMinimumAudioVolume_A8517;

		// Token: 0x0400252D RID: 9517
		internal global::AcpUI.AcpTextBoxSpinner RadProfAlertTonesMinimumAudioVolume_A8517;

		// Token: 0x0400252E RID: 9518
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesMinimumAudioVolume_A8517;

		// Token: 0x0400252F RID: 9519
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesMinimumAudioVolume_A8517;

		// Token: 0x04002530 RID: 9520
		internal global::AcpUI.AcpLabel RadProfAlertTonesMinimumAudioVolume_A8517Comp;

		// Token: 0x04002531 RID: 9521
		internal global::AcpUI.AcpLabel LblAlertTonesRadioAccessory_42601;

		// Token: 0x04002532 RID: 9522
		internal global::AcpUI.AcpLabel AlertTonesRadioAccessory_42601;

		// Token: 0x04002533 RID: 9523
		internal global::AcpUI.AcpRtdButton RTDBtnAlertTonesRadioAccessory_42601;

		// Token: 0x04002534 RID: 9524
		internal global::AcpUI.AcpCopyButton CpyBtnAlertTonesRadioAccessory_42601;

		// Token: 0x04002535 RID: 9525
		internal global::AcpUI.AcpLabel AlertTonesRadioAccessory_42601Comp;

		// Token: 0x04002536 RID: 9526
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x04002537 RID: 9527
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x04002538 RID: 9528
		internal global::AcpUI.AcpComboBox RadProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x04002539 RID: 9529
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x0400253A RID: 9530
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x0400253B RID: 9531
		internal global::AcpUI.AcpLabel RadProfAlertTonesAlertToneVolumeOffsetdB_A7427Comp;

		// Token: 0x0400253C RID: 9532
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x0400253D RID: 9533
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x0400253E RID: 9534
		internal global::AcpUI.AcpTextBoxSpinner RadProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x0400253F RID: 9535
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x04002540 RID: 9536
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x04002541 RID: 9537
		internal global::AcpUI.AcpLabel RadProfAlertTonesMinimumAlertToneVolume_A8521Comp;

		// Token: 0x04002542 RID: 9538
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsMaximumAlertToneVolume_A21368;

		// Token: 0x04002543 RID: 9539
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368;

		// Token: 0x04002544 RID: 9540
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsMaximumAlertToneVolume_A21368;

		// Token: 0x04002545 RID: 9541
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368;

		// Token: 0x04002546 RID: 9542
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsMaximumAlertToneVolume_A21368;

		// Token: 0x04002547 RID: 9543
		internal global::AcpUI.AcpLabel RadProfAudioSettingsMaximumAlertToneVolume_A21368Comp;

		// Token: 0x04002548 RID: 9544
		internal global::AcpUI.AcpLabel LblAudioEqualizationRadio_42602;

		// Token: 0x04002549 RID: 9545
		internal global::AcpUI.AcpLabel AudioEqualizationRadio_42602;

		// Token: 0x0400254A RID: 9546
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationRadio_42602;

		// Token: 0x0400254B RID: 9547
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationRadio_42602;

		// Token: 0x0400254C RID: 9548
		internal global::AcpUI.AcpLabel AudioEqualizationRadio_42602Comp;

		// Token: 0x0400254D RID: 9549
		internal global::AcpUI.AcpLabel AudioEqualizationAccessory_42603;

		// Token: 0x0400254E RID: 9550
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationAccessory_42603;

		// Token: 0x0400254F RID: 9551
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationAccessory_42603;

		// Token: 0x04002550 RID: 9552
		internal global::AcpUI.AcpLabel AudioEqualizationAccessory_42603Comp;

		// Token: 0x04002551 RID: 9553
		internal global::AcpUI.AcpLabel LblAudioEqualizationGroupSettingRadio_42604;

		// Token: 0x04002552 RID: 9554
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAudioEqualizationGroupSettingRadio_42604;

		// Token: 0x04002553 RID: 9555
		internal global::AcpUI.AcpComboBox AudioEqualizationGroupSettingRadio_42604;

		// Token: 0x04002554 RID: 9556
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationGroupSettingRadio_42604;

		// Token: 0x04002555 RID: 9557
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationGroupSettingRadio_42604;

		// Token: 0x04002556 RID: 9558
		internal global::AcpUI.AcpLabel AudioEqualizationGroupSettingRadio_42604Comp;

		// Token: 0x04002557 RID: 9559
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAudioEqualizationGroupSettingAccessory_42605;

		// Token: 0x04002558 RID: 9560
		internal global::AcpUI.AcpComboBox AudioEqualizationGroupSettingAccessory_42605;

		// Token: 0x04002559 RID: 9561
		internal global::AcpUI.AcpRtdButton RTDBtnAudioEqualizationGroupSettingAccessory_42605;

		// Token: 0x0400255A RID: 9562
		internal global::AcpUI.AcpCopyButton CpyBtnAudioEqualizationGroupSettingAccessory_42605;

		// Token: 0x0400255B RID: 9563
		internal global::AcpUI.AcpLabel AudioEqualizationGroupSettingAccessory_42605Comp;

		// Token: 0x0400255C RID: 9564
		internal global::AcpUI.AcpLabel LblRadProfLabtoolAnalogBassControl_A19506;

		// Token: 0x0400255D RID: 9565
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfLabtoolAnalogBassControl_A19506;

		// Token: 0x0400255E RID: 9566
		internal global::AcpUI.AcpTextBoxSpinner RadProfLabtoolAnalogBassControl_A19506;

		// Token: 0x0400255F RID: 9567
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfLabtoolAnalogBassControl_A19506;

		// Token: 0x04002560 RID: 9568
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfLabtoolAnalogBassControl_A19506;

		// Token: 0x04002561 RID: 9569
		internal global::AcpUI.AcpLabel RadProfLabtoolAnalogBassControl_A19506Comp;

		// Token: 0x04002562 RID: 9570
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAnalogLowFrequencyBandAccessory_42647;

		// Token: 0x04002563 RID: 9571
		internal global::AcpUI.AcpTextBoxSpinner AnalogLowFrequencyBandAccessory_42647;

		// Token: 0x04002564 RID: 9572
		internal global::AcpUI.AcpRtdButton RTDBtnAnalogLowFrequencyBandAccessory_42647;

		// Token: 0x04002565 RID: 9573
		internal global::AcpUI.AcpCopyButton CpyBtnAnalogLowFrequencyBandAccessory_42647;

		// Token: 0x04002566 RID: 9574
		internal global::AcpUI.AcpLabel AnalogLowFrequencyBandAccessory_42647Comp;

		// Token: 0x04002567 RID: 9575
		internal global::AcpUI.AcpLabel LblAnalogMidFrequencyBandRadio_42648;

		// Token: 0x04002568 RID: 9576
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAnalogMidFrequencyBandRadio_42648;

		// Token: 0x04002569 RID: 9577
		internal global::AcpUI.AcpTextBoxSpinner AnalogMidFrequencyBandRadio_42648;

		// Token: 0x0400256A RID: 9578
		internal global::AcpUI.AcpRtdButton RTDBtnAnalogMidFrequencyBandRadio_42648;

		// Token: 0x0400256B RID: 9579
		internal global::AcpUI.AcpCopyButton CpyBtnAnalogMidFrequencyBandRadio_42648;

		// Token: 0x0400256C RID: 9580
		internal global::AcpUI.AcpLabel AnalogMidFrequencyBandRadio_42648Comp;

		// Token: 0x0400256D RID: 9581
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAnalogMidFrequencyBandAccessory_42649;

		// Token: 0x0400256E RID: 9582
		internal global::AcpUI.AcpTextBoxSpinner AnalogMidFrequencyBandAccessory_42649;

		// Token: 0x0400256F RID: 9583
		internal global::AcpUI.AcpRtdButton RTDBtnAnalogMidFrequencyBandAccessory_42649;

		// Token: 0x04002570 RID: 9584
		internal global::AcpUI.AcpCopyButton CpyBtnAnalogMidFrequencyBandAccessory_42649;

		// Token: 0x04002571 RID: 9585
		internal global::AcpUI.AcpLabel AnalogMidFrequencyBandAccessory_42649Comp;

		// Token: 0x04002572 RID: 9586
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsAnalog_A7438;

		// Token: 0x04002573 RID: 9587
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsAnalog_A7438;

		// Token: 0x04002574 RID: 9588
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsAnalog_A7438;

		// Token: 0x04002575 RID: 9589
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsAnalog_A7438;

		// Token: 0x04002576 RID: 9590
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsAnalog_A7438;

		// Token: 0x04002577 RID: 9591
		internal global::AcpUI.AcpLabel RadProfAudioSettingsAnalog_A7438Comp;

		// Token: 0x04002578 RID: 9592
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAnalogHighFrequencyBandAccessory_42650;

		// Token: 0x04002579 RID: 9593
		internal global::AcpUI.AcpTextBoxSpinner AnalogHighFrequencyBandAccessory_42650;

		// Token: 0x0400257A RID: 9594
		internal global::AcpUI.AcpRtdButton RTDBtnAnalogHighFrequencyBandAccessory_42650;

		// Token: 0x0400257B RID: 9595
		internal global::AcpUI.AcpCopyButton CpyBtnAnalogHighFrequencyBandAccessory_42650;

		// Token: 0x0400257C RID: 9596
		internal global::AcpUI.AcpLabel AnalogHighFrequencyBandAccessory_42650Comp;

		// Token: 0x0400257D RID: 9597
		internal global::AcpUI.AcpLabel LblRadProfLabtoolDigitalBassControl_A19507;

		// Token: 0x0400257E RID: 9598
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfLabtoolDigitalBassControl_A19507;

		// Token: 0x0400257F RID: 9599
		internal global::AcpUI.AcpTextBoxSpinner RadProfLabtoolDigitalBassControl_A19507;

		// Token: 0x04002580 RID: 9600
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfLabtoolDigitalBassControl_A19507;

		// Token: 0x04002581 RID: 9601
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfLabtoolDigitalBassControl_A19507;

		// Token: 0x04002582 RID: 9602
		internal global::AcpUI.AcpLabel RadProfLabtoolDigitalBassControl_A19507Comp;

		// Token: 0x04002583 RID: 9603
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDigitalLowFrequencyBandAccessory_42652;

		// Token: 0x04002584 RID: 9604
		internal global::AcpUI.AcpTextBoxSpinner DigitalLowFrequencyBandAccessory_42652;

		// Token: 0x04002585 RID: 9605
		internal global::AcpUI.AcpRtdButton RTDBtnDigitalLowFrequencyBandAccessory_42652;

		// Token: 0x04002586 RID: 9606
		internal global::AcpUI.AcpCopyButton CpyBtnDigitalLowFrequencyBandAccessory_42652;

		// Token: 0x04002587 RID: 9607
		internal global::AcpUI.AcpLabel DigitalLowFrequencyBandAccessory_42652Comp;

		// Token: 0x04002588 RID: 9608
		internal global::AcpUI.AcpLabel LblDigitalMidFrequencyBandRadio_42653;

		// Token: 0x04002589 RID: 9609
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDigitalMidFrequencyBandRadio_42653;

		// Token: 0x0400258A RID: 9610
		internal global::AcpUI.AcpTextBoxSpinner DigitalMidFrequencyBandRadio_42653;

		// Token: 0x0400258B RID: 9611
		internal global::AcpUI.AcpRtdButton RTDBtnDigitalMidFrequencyBandRadio_42653;

		// Token: 0x0400258C RID: 9612
		internal global::AcpUI.AcpCopyButton CpyBtnDigitalMidFrequencyBandRadio_42653;

		// Token: 0x0400258D RID: 9613
		internal global::AcpUI.AcpLabel DigitalMidFrequencyBandRadio_42653Comp;

		// Token: 0x0400258E RID: 9614
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDigitalMidFrequencyBandAccessory_42654;

		// Token: 0x0400258F RID: 9615
		internal global::AcpUI.AcpTextBoxSpinner DigitalMidFrequencyBandAccessory_42654;

		// Token: 0x04002590 RID: 9616
		internal global::AcpUI.AcpRtdButton RTDBtnDigitalMidFrequencyBandAccessory_42654;

		// Token: 0x04002591 RID: 9617
		internal global::AcpUI.AcpCopyButton CpyBtnDigitalMidFrequencyBandAccessory_42654;

		// Token: 0x04002592 RID: 9618
		internal global::AcpUI.AcpLabel DigitalMidFrequencyBandAccessory_42654Comp;

		// Token: 0x04002593 RID: 9619
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsDigital_A7850;

		// Token: 0x04002594 RID: 9620
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsDigital_A7850;

		// Token: 0x04002595 RID: 9621
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsDigital_A7850;

		// Token: 0x04002596 RID: 9622
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsDigital_A7850;

		// Token: 0x04002597 RID: 9623
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsDigital_A7850;

		// Token: 0x04002598 RID: 9624
		internal global::AcpUI.AcpLabel RadProfAudioSettingsDigital_A7850Comp;

		// Token: 0x04002599 RID: 9625
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDigitalHighFrequencyBandAccessory_42655;

		// Token: 0x0400259A RID: 9626
		internal global::AcpUI.AcpTextBoxSpinner DigitalHighFrequencyBandAccessory_42655;

		// Token: 0x0400259B RID: 9627
		internal global::AcpUI.AcpRtdButton RTDBtnDigitalHighFrequencyBandAccessory_42655;

		// Token: 0x0400259C RID: 9628
		internal global::AcpUI.AcpCopyButton CpyBtnDigitalHighFrequencyBandAccessory_42655;

		// Token: 0x0400259D RID: 9629
		internal global::AcpUI.AcpLabel DigitalHighFrequencyBandAccessory_42655Comp;

		// Token: 0x0400259E RID: 9630
		internal global::AcpUI.AcpLabel LblRadProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x0400259F RID: 9631
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x040025A0 RID: 9632
		internal global::AcpUI.AcpTextBoxSpinner RadProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x040025A1 RID: 9633
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x040025A2 RID: 9634
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x040025A3 RID: 9635
		internal global::AcpUI.AcpLabel RadProfLabtoolSecurenetBassControl_A19508Comp;

		// Token: 0x040025A4 RID: 9636
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecurenetLowFrequencyBandAccessory_42657;

		// Token: 0x040025A5 RID: 9637
		internal global::AcpUI.AcpTextBoxSpinner SecurenetLowFrequencyBandAccessory_42657;

		// Token: 0x040025A6 RID: 9638
		internal global::AcpUI.AcpRtdButton RTDBtnSecurenetLowFrequencyBandAccessory_42657;

		// Token: 0x040025A7 RID: 9639
		internal global::AcpUI.AcpCopyButton CpyBtnSecurenetLowFrequencyBandAccessory_42657;

		// Token: 0x040025A8 RID: 9640
		internal global::AcpUI.AcpLabel SecurenetLowFrequencyBandAccessory_42657Comp;

		// Token: 0x040025A9 RID: 9641
		internal global::AcpUI.AcpLabel LblSecurenetMidFrequencyBandRadio_42658;

		// Token: 0x040025AA RID: 9642
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecurenetMidFrequencyBandRadio_42658;

		// Token: 0x040025AB RID: 9643
		internal global::AcpUI.AcpTextBoxSpinner SecurenetMidFrequencyBandRadio_42658;

		// Token: 0x040025AC RID: 9644
		internal global::AcpUI.AcpRtdButton RTDBtnSecurenetMidFrequencyBandRadio_42658;

		// Token: 0x040025AD RID: 9645
		internal global::AcpUI.AcpCopyButton CpyBtnSecurenetMidFrequencyBandRadio_42658;

		// Token: 0x040025AE RID: 9646
		internal global::AcpUI.AcpLabel SecurenetMidFrequencyBandRadio_42658Comp;

		// Token: 0x040025AF RID: 9647
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecurenetMidFrequencyBandAccessory_42659;

		// Token: 0x040025B0 RID: 9648
		internal global::AcpUI.AcpTextBoxSpinner SecurenetMidFrequencyBandAccessory_42659;

		// Token: 0x040025B1 RID: 9649
		internal global::AcpUI.AcpRtdButton RTDBtnSecurenetMidFrequencyBandAccessory_42659;

		// Token: 0x040025B2 RID: 9650
		internal global::AcpUI.AcpCopyButton CpyBtnSecurenetMidFrequencyBandAccessory_42659;

		// Token: 0x040025B3 RID: 9651
		internal global::AcpUI.AcpLabel SecurenetMidFrequencyBandAccessory_42659Comp;

		// Token: 0x040025B4 RID: 9652
		internal global::AcpUI.AcpLabel LblRadProfAudioSettingsSecurenet_A9097;

		// Token: 0x040025B5 RID: 9653
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAudioSettingsSecurenet_A9097;

		// Token: 0x040025B6 RID: 9654
		internal global::AcpUI.AcpTextBoxSpinner RadProfAudioSettingsSecurenet_A9097;

		// Token: 0x040025B7 RID: 9655
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAudioSettingsSecurenet_A9097;

		// Token: 0x040025B8 RID: 9656
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAudioSettingsSecurenet_A9097;

		// Token: 0x040025B9 RID: 9657
		internal global::AcpUI.AcpLabel RadProfAudioSettingsSecurenet_A9097Comp;

		// Token: 0x040025BA RID: 9658
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSecurenetHighFrequencyBandAccessory_42660;

		// Token: 0x040025BB RID: 9659
		internal global::AcpUI.AcpTextBoxSpinner SecurenetHighFrequencyBandAccessory_42660;

		// Token: 0x040025BC RID: 9660
		internal global::AcpUI.AcpRtdButton RTDBtnSecurenetHighFrequencyBandAccessory_42660;

		// Token: 0x040025BD RID: 9661
		internal global::AcpUI.AcpCopyButton CpyBtnSecurenetHighFrequencyBandAccessory_42660;

		// Token: 0x040025BE RID: 9662
		internal global::AcpUI.AcpLabel SecurenetHighFrequencyBandAccessory_42660Comp;

		// Token: 0x040025BF RID: 9663
		internal global::AcpUI.AcpLabel LblGainControlRadio_42617;

		// Token: 0x040025C0 RID: 9664
		internal global::AcpUI.AcpLabel GainControlRadio_42617;

		// Token: 0x040025C1 RID: 9665
		internal global::AcpUI.AcpRtdButton RTDBtnGainControlRadio_42617;

		// Token: 0x040025C2 RID: 9666
		internal global::AcpUI.AcpCopyButton CpyBtnGainControlRadio_42617;

		// Token: 0x040025C3 RID: 9667
		internal global::AcpUI.AcpLabel GainControlRadio_42617Comp;

		// Token: 0x040025C4 RID: 9668
		internal global::AcpUI.AcpLabel GainControlAccessory_42618;

		// Token: 0x040025C5 RID: 9669
		internal global::AcpUI.AcpRtdButton RTDBtnGainControlAccessory_42618;

		// Token: 0x040025C6 RID: 9670
		internal global::AcpUI.AcpCopyButton CpyBtnGainControlAccessory_42618;

		// Token: 0x040025C7 RID: 9671
		internal global::AcpUI.AcpLabel GainControlAccessory_42618Comp;

		// Token: 0x040025C8 RID: 9672
		internal global::AcpUI.AcpLabel LblReceiveAGCGroupSettingInternal_42615;

		// Token: 0x040025C9 RID: 9673
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGroupSettingInternal_42615;

		// Token: 0x040025CA RID: 9674
		internal global::AcpUI.AcpComboBox ReceiveAGCGroupSettingInternal_42615;

		// Token: 0x040025CB RID: 9675
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGroupSettingInternal_42615;

		// Token: 0x040025CC RID: 9676
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGroupSettingInternal_42615;

		// Token: 0x040025CD RID: 9677
		internal global::AcpUI.AcpLabel ReceiveAGCGroupSettingInternal_42615Comp;

		// Token: 0x040025CE RID: 9678
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGroupSettingAccessory_42616;

		// Token: 0x040025CF RID: 9679
		internal global::AcpUI.AcpComboBox ReceiveAGCGroupSettingAccessory_42616;

		// Token: 0x040025D0 RID: 9680
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGroupSettingAccessory_42616;

		// Token: 0x040025D1 RID: 9681
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGroupSettingAccessory_42616;

		// Token: 0x040025D2 RID: 9682
		internal global::AcpUI.AcpLabel ReceiveAGCGroupSettingAccessory_42616Comp;

		// Token: 0x040025D3 RID: 9683
		internal global::AcpUI.AcpLabel LblReceiveAGCEnableInternal_42743;

		// Token: 0x040025D4 RID: 9684
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCEnableInternal_42743;

		// Token: 0x040025D5 RID: 9685
		internal global::AcpUI.AcpCheckBox ReceiveAGCEnableInternal_42743;

		// Token: 0x040025D6 RID: 9686
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCEnableInternal_42743;

		// Token: 0x040025D7 RID: 9687
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCEnableInternal_42743;

		// Token: 0x040025D8 RID: 9688
		internal global::AcpUI.AcpCheckBox ReceiveAGCEnableInternal_42743Comp;

		// Token: 0x040025D9 RID: 9689
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCEnableAccessory_42744;

		// Token: 0x040025DA RID: 9690
		internal global::AcpUI.AcpCheckBox ReceiveAGCEnableAccessory_42744;

		// Token: 0x040025DB RID: 9691
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCEnableAccessory_42744;

		// Token: 0x040025DC RID: 9692
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCEnableAccessory_42744;

		// Token: 0x040025DD RID: 9693
		internal global::AcpUI.AcpCheckBox ReceiveAGCEnableAccessory_42744Comp;

		// Token: 0x040025DE RID: 9694
		internal global::AcpUI.AcpLabel LblReceiveAGCGainControlOutputInternal_42745;

		// Token: 0x040025DF RID: 9695
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGainControlOutputInternal_42745;

		// Token: 0x040025E0 RID: 9696
		internal global::AcpUI.AcpTextBoxSpinner ReceiveAGCGainControlOutputInternal_42745;

		// Token: 0x040025E1 RID: 9697
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGainControlOutputInternal_42745;

		// Token: 0x040025E2 RID: 9698
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGainControlOutputInternal_42745;

		// Token: 0x040025E3 RID: 9699
		internal global::AcpUI.AcpLabel ReceiveAGCGainControlOutputInternal_42745Comp;

		// Token: 0x040025E4 RID: 9700
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGainControlOutputAccessory_42746;

		// Token: 0x040025E5 RID: 9701
		internal global::AcpUI.AcpTextBoxSpinner ReceiveAGCGainControlOutputAccessory_42746;

		// Token: 0x040025E6 RID: 9702
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGainControlOutputAccessory_42746;

		// Token: 0x040025E7 RID: 9703
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGainControlOutputAccessory_42746;

		// Token: 0x040025E8 RID: 9704
		internal global::AcpUI.AcpLabel ReceiveAGCGainControlOutputAccessory_42746Comp;

		// Token: 0x040025E9 RID: 9705
		internal global::AcpUI.AcpLabel LblReceiveAGCGainControlTotalInternal_42741;

		// Token: 0x040025EA RID: 9706
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGainControlTotalInternal_42741;

		// Token: 0x040025EB RID: 9707
		internal global::AcpUI.AcpTextBoxSpinner ReceiveAGCGainControlTotalInternal_42741;

		// Token: 0x040025EC RID: 9708
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGainControlTotalInternal_42741;

		// Token: 0x040025ED RID: 9709
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGainControlTotalInternal_42741;

		// Token: 0x040025EE RID: 9710
		internal global::AcpUI.AcpLabel ReceiveAGCGainControlTotalInternal_42741Comp;

		// Token: 0x040025EF RID: 9711
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnReceiveAGCGainControlTotalAccessory_42742;

		// Token: 0x040025F0 RID: 9712
		internal global::AcpUI.AcpTextBoxSpinner ReceiveAGCGainControlTotalAccessory_42742;

		// Token: 0x040025F1 RID: 9713
		internal global::AcpUI.AcpRtdButton RTDBtnReceiveAGCGainControlTotalAccessory_42742;

		// Token: 0x040025F2 RID: 9714
		internal global::AcpUI.AcpCopyButton CpyBtnReceiveAGCGainControlTotalAccessory_42742;

		// Token: 0x040025F3 RID: 9715
		internal global::AcpUI.AcpLabel ReceiveAGCGainControlTotalAccessory_42742Comp;

		// Token: 0x040025F4 RID: 9716
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAudioSettingsPseudo8;

		// Token: 0x040025F5 RID: 9717
		internal global::AcpUI.AcpExpander ExpanderRadioProfilesLabtoolRAD_PROF_CDA;

		// Token: 0x040025F6 RID: 9718
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesLabtoolRAD_PROF_CDAPseudo0;

		// Token: 0x040025F7 RID: 9719
		internal global::AcpUI.AcpExpander ExpanderRadioProfilesAlertTones;

		// Token: 0x040025F8 RID: 9720
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioProfilesAlertTonesPseudo0;

		// Token: 0x040025F9 RID: 9721
		private bool g;
	}
}
