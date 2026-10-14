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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E3 RID: 483
	public class UclPhoneCallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600174D RID: 5965 RVA: 0x001FC84C File Offset: 0x001FAA4C
		public UclPhoneCallHotListPage()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x001FC884 File Offset: 0x001FAA84
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)278134784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)8454145;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)614649779;
						short num3 = num;
						num = (short)1473957811;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)474152960;
							if (num != 0)
							{
							}
							object myRecordsetDataSource;
							if (myRecordsetDataSource == null)
							{
								goto IL_85;
							}
							break;
						}
						}
						num = (short)1835270149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 2:
						goto IL_19F;
					case 3:
						try
						{
							num = (short)586743809;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)690749441;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_261;
									}
									continue;
								case 2:
									base.Expanders.Add(acpExpander);
									num = (short)1420427264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)868286470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)989921283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)290062341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (acpExpander != null)
									{
										num = (short)1193017346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_31D;
								}
								IL_263:
								num = (short)653983748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_261:
								goto IL_263;
							}
							IL_31D:
							goto IL_161;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_33F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_32C:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)79233025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_393;
								case 1:
									disposable.Dispose();
									num = (short)1880555522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_391;
								}
								goto IL_33F;
							}
							IL_391:
							IL_393:
							goto EndFinally_7;
							IL_33F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)363462656;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_32C;
							EndFinally_7:;
						}
						goto IL_394;
						IL_161:
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1076101122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						base.MyBaseRecNavToolbar = this.RecNavToolbarPhoneCallHotListHotList;
						object myRecordsetDataSource = this.RecNavToolbarPhoneCallHotListHotList.MyRecordsetDataSource;
						num = (short)128581632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						num = (short)1976958982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_85;
					}
					IL_63:
					if (!this.a)
					{
						num = (short)615120900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_394;
					IL_85:
					this.RecNavToolbarPhoneCallHotListHotList.MyDataPresenter = this.PhoneCallHotListDataPresenter;
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1856897027;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19F:
				num = (short)1474101248;
				short num4 = num;
				IL_394:
				this.a();
				return;
			}
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x001FCC48 File Offset: 0x001FAE48
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)805830657;
						if (num2 != 0)
						{
						}
						num2 = (short)578289664;
						short num3 = num2;
						if (this.a)
						{
							num2 = (short)1279197185;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
					{
						num2 = (short)1174853850;
						short num4 = num2;
						num2 = (short)934074586;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
							num2 = (short)822935552;
							if (num2 != 0)
							{
							}
							base.OnUnloaded(sender, e);
							this.a = false;
							num2 = (short)783286274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarPhoneCallHotListHotList.DataContext = null;
			this.RecNavToolbarPhoneCallHotListHotList.MyDataPresenter = null;
			IL_34:
			num2 = (short)128385024;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x001FCD88 File Offset: 0x001FAF88
		public override void SetDataContext()
		{
			short num = (short)821231616;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)785383428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				case 2:
					goto IL_86;
				case 3:
					num = (short)577568769;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2220);
					num = (short)1586495493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)484364642;
					short num3 = num;
					num = (short)94687586;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						goto IL_180;
					}
					break;
				}
				case 5:
					goto IL_86;
				}
				IL_3E:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)442236931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2220);
				goto IL_D2;
				IL_86:
				num = (short)4325377;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D2:
				num = (short)1173815296;
				short num4 = num;
				num = (short)586809346;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_180:
			num = (short)1016856576;
			if (num != 0)
			{
			}
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2220);
			this.RecNavToolbarPhoneCallHotListHotList.MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10427].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPhoneCallHotListHotList).SyncDataSources();
			return;
			IL_1D9:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPhoneCallHotListHotList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x001FCF7C File Offset: 0x001FB17C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)1290141699;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1346877307;
					short num3 = num;
					num = (short)2026092411;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FF;
					default:
						num = (short)119603200;
						if (num != 0)
						{
						}
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87삍삓秊ﺛﾝ튟첣즥욧쾩쾭\udcaf\udeb1ﲳ\ud9b5첷햻춽뒿諁ꯃ닅蓇ꏉ뿋뫍", a_))
						{
							num = (short)988020737;
							if (num != 0)
							{
							}
							num = (short)1259732994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					num = (short)1291976704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1FF;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 4:
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarPhoneCallHotListHotList.MyRecordsetDataSource;
					num = (short)686292998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_113;
				case 6:
					if (myRecordsetDataSource != null)
					{
						num = (short)822083589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					return;
				case 8:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)1741094916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)868548615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_51:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)790495232;
					short num4 = num;
					num = (short)572391425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_1FF:
				num = (short)924975112;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::SpecialFeatures.Ucl.HotList.PhoneCallHotList item = (global::SpecialFeatures.Ucl.HotList.PhoneCallHotList)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x001FD1CC File Offset: 0x001FB3CC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)165594672;
			short num2 = num;
			num = (short)1178912304;
			switch (num2 == num)
			{
			}
			num = (short)1553072128;
			short num3 = num;
			num = (short)1563951105;
			if (num != 0)
			{
			}
			num = (short)396165120;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x001FD27C File Offset: 0x001FB47C
		private void a()
		{
			short num = (short)916520961;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
			for (;;)
			{
				IL_31:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_203;
				case 1:
					try
					{
						num = (short)812318720;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 1:
								num = (short)2074083331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1896385917;
								short num3 = num;
								num = (short)994282877;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_DF;
								default:
									num = (short)1928986624;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 3:
								goto IL_197;
							case 4:
								if (!enumerator.MoveNext())
								{
									goto IL_DF;
								}
								((global::AcpBusinessLayer.Recordset)((global::SpecialFeatures.Ucl.Contact.UclContact)enumerator.Current).PhoneCallList.EmbeddedRecset).RefreshKeyMap();
								num = (short)931463170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_C3:
							num = (short)705560580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_C3;
							IL_DF:
							num = (short)900333569;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_197:
						return;
					}
					finally
					{
						num = (short)14155778;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)484507649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_200;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1CC;
								}
								continue;
							}
							IL_1CC:
							if (enumerator == null)
							{
								break;
							}
							num = (short)328204288;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_200:;
					}
					goto IL_203;
				case 2:
					if (uclContactRecset != null)
					{
						num = (short)1528692736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_43;
				IL_203:
				enumerator = uclContactRecset.GetEnumerator();
				num = (short)2018639872;
				short num4 = num;
				num = (short)1555562497;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_43:
			uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
			num = (short)1479475202;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x001FD4F8 File Offset: 0x001FB6F8
		private void HLinkPhoneCallHotListClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)683802624;
			short num2 = num;
			num = (short)1679923053;
			short num3 = num;
			num = (short)110008173;
			switch (num3 == num)
			{
			}
			num = (short)956039169;
			if (num != 0)
			{
			}
			num = (short)1102446592;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x001FD5A8 File Offset: 0x001FB7A8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 11;
			short num;
			if (this.b)
			{
				num = (short)29425665;
				if (num != 0)
				{
				}
				num = (short)775017561;
				short num2 = num;
				num = (short)1521931353;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)193724416;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1732771840;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆍ쎏ﮙ\ud89d얟쎡킣펥\udaa7쾩\udfab閭펯\uddb1\ud9b3욵ힷ풹\ud9bb킽뒿ꟃꟅ꓇ꛉﳍ뻑뷓ꗕ곗￙菟跡諣胥臧跩駫鳭釯蛱鷳駵雷헹铻釽瓿渁洃甅簇┉礋洍簏我簓礕瘗缙缛缝䰟両䰣䤥尧䘩䔫崭䐯䈱唳儵崷ᐹ䐻弽ⴿ⹁", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x001FD688 File Offset: 0x001FB888
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)826212354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1467613185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_24A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1177100930;
				short num3 = num;
				num = (short)808985218;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_190;
				default:
					num = (short)287178752;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_32B;
					case 2:
					case 3:
						goto IL_38D;
					case 4:
						goto IL_2DB;
					case 5:
						goto IL_19D;
					case 6:
						goto IL_24F;
					case 7:
						goto IL_183;
					case 8:
						goto IL_1E8;
					case 9:
						goto IL_25C;
					case 10:
						goto IL_269;
					case 11:
						goto IL_2CE;
					case 12:
						goto IL_226;
					case 13:
						goto IL_290;
					case 14:
						goto IL_29D;
					case 15:
						goto IL_31E;
					case 16:
						goto IL_1DB;
					case 17:
						goto IL_137;
					case 18:
						goto IL_35C;
					case 19:
						goto IL_2AA;
					case 20:
						goto IL_1C1;
					case 21:
						goto IL_113;
					case 22:
						goto IL_283;
					case 23:
						goto IL_369;
					case 24:
						goto IL_276;
					case 25:
						goto IL_190;
					case 26:
						goto IL_20C;
					case 27:
						goto IL_1CE;
					case 28:
						goto IL_2E8;
					case 29:
						goto IL_219;
					default:
						num = (short)862912512;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_113:
			this.CallID = (global::AcpUI.AcpComboBox)target;
			this.CallID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_137:
			num = (short)430571520;
			short num4 = num;
			this.ContactAlias = (global::AcpUI.AcpComboBox)target;
			this.ContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_183:
			this.ExpPhoneCallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_190:
			this.CompGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_19D:
			this.HLinkPhoneCallHotList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPhoneCallHotList.Click += this.HLinkPhoneCallHotListClick;
			return;
			IL_1C1:
			this.RtdBtnContactAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CE:
			this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1DB:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1E8:
			this.RecNavToolbarPhoneCallHotListHotList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPhoneCallHotListHotList.ModeClick += this.OnModeClick;
			return;
			IL_20C:
			this.CopyButtonContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_219:
			this.CallIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_226:
			this.ContactAliasTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_24A:
			goto IL_38D;
			IL_24F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_25C:
			this.GridFrame = (global::System.Windows.Controls.Grid)target;
			return;
			IL_269:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_276:
			this.RtdBtnCallID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_283:
			this.CVBtnCallID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_290:
			this.CallIdTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_29D:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2AA:
			this.LblContactAlias = (global::AcpUI.AcpLabel)target;
			this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CE:
			this.PhoneCallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2DB:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_2E8:
			num = (short)74907649;
			if (num != 0)
			{
			}
			this.CopyButtonCallID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31E:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_32B:
			((global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_35C:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_369:
			this.LblCallID = (global::AcpUI.AcpLabel)target;
			this.LblCallID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38D:
			this.b = true;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x001FDA2C File Offset: 0x001FBC2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)99418112;
			short num2 = num;
			num = (short)206831619;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					if (connectionId == 3)
					{
						goto IL_135;
					}
					num = (short)654928381;
					short num4 = num;
					num = (short)1440377341;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						num = (short)884670464;
						if (num != 0)
						{
						}
						num = (short)2004090881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					num = (short)1393819648;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)765591553;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				}
				IL_84:
				if (connectionId == 2)
				{
					break;
				}
				num = (short)48496642;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_A0:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_135:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000BFE RID: 3070
		private bool a;

		// Token: 0x04000BFF RID: 3071
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000C00 RID: 3072
		internal global::System.Windows.Documents.Hyperlink HLinkPhoneCallHotList;

		// Token: 0x04000C01 RID: 3073
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000C02 RID: 3074
		internal global::AcpUI.AcpExpander ExpPhoneCallHotList;

		// Token: 0x04000C03 RID: 3075
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPhoneCallHotListHotList;

		// Token: 0x04000C04 RID: 3076
		internal global::System.Windows.Controls.Grid GridFrame;

		// Token: 0x04000C05 RID: 3077
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000C06 RID: 3078
		internal global::AcpUI.AcpXamDataPresenter PhoneCallHotListDataPresenter;

		// Token: 0x04000C07 RID: 3079
		internal global::Infragistics.Windows.DataPresenter.UnboundField ContactAliasTable_Col;

		// Token: 0x04000C08 RID: 3080
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallIdTable_Col;

		// Token: 0x04000C09 RID: 3081
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000C0A RID: 3082
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000C0B RID: 3083
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000C0C RID: 3084
		internal global::AcpUI.AcpComboBox ContactAlias;

		// Token: 0x04000C0D RID: 3085
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000C0E RID: 3086
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000C0F RID: 3087
		internal global::AcpUI.AcpRtdButton RtdBtnContactAlias;

		// Token: 0x04000C10 RID: 3088
		internal global::AcpUI.AcpComboBox CallID;

		// Token: 0x04000C11 RID: 3089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallID;

		// Token: 0x04000C12 RID: 3090
		internal global::AcpUI.AcpLabel LblCallID;

		// Token: 0x04000C13 RID: 3091
		internal global::AcpUI.AcpRtdButton RtdBtnCallID;

		// Token: 0x04000C14 RID: 3092
		internal global::System.Windows.Controls.Grid CompGridGeneralGrp;

		// Token: 0x04000C15 RID: 3093
		internal global::AcpUI.AcpCopyButton CopyButtonContactAlias;

		// Token: 0x04000C16 RID: 3094
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000C17 RID: 3095
		internal global::AcpUI.AcpCopyButton CopyButtonCallID;

		// Token: 0x04000C18 RID: 3096
		internal global::AcpUI.AcpViewOnlyCtrl CallIDComp;

		// Token: 0x04000C19 RID: 3097
		private bool b;
	}
}
