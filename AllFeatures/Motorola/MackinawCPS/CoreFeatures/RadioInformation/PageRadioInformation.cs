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

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001AE RID: 430
	public class PageRadioInformation : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060050B8 RID: 20664 RVA: 0x00491B30 File Offset: 0x0048FD30
		public PageRadioInformation()
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

		// Token: 0x060050B9 RID: 20665 RVA: 0x00491B68 File Offset: 0x0048FD68
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)522321920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1397293058;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1950285830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81;
					}
					case 1:
						goto IL_158;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						try
						{
							num = (short)1469906946;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)893714432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_202;
									}
									continue;
								case 3:
									num = (short)1439301636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2C0;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)129957891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1544028166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (acpExpander != null)
									{
										num = (short)833945601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_204:
								num = (short)339542021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_202:
								goto IL_204;
							}
							IL_2C0:
							goto IL_124;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2E2;
							}
							for (;;)
							{
								IL_2CF:
								switch (num2)
								{
								case 0:
									goto IL_338;
								case 1:
								{
									global::System.IDisposable disposable;
									if (disposable != null)
									{
										num = (short)1890320386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_387;
								}
								case 2:
								{
									global::System.IDisposable disposable;
									disposable.Dispose();
									num = (short)830210048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_2E2;
							}
							IL_338:
							num = (short)226414120;
							short num3 = num;
							num = (short)1781255720;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
							{
								IL_2E2:
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								num = (short)1904082945;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2CF;
							}
							default:
								num = (short)2037252096;
								if (num != 0)
								{
								}
								break;
							}
							IL_387:;
						}
						goto IL_388;
						IL_124:
						base.OnLoaded(sender, e);
						this.a = true;
						this.RadInfoGeneralCodeplugAlias_A7684.Focus();
						num = (short)458620929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1547567105;
						if (num != 0)
						{
						}
						goto IL_81;
					case 5:
					{
						object obj = null;
						obj = this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.MyRecordsetDataSource;
						num = (short)630718464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.MyDataPresenter = this.ExpanderRadioInformationASKProgrammingHistory;
						num = (short)2078081028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5F:
					if (!this.a)
					{
						num = (short)1460011013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_81:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)73203712;
					short num4 = num;
					num = (short)923009027;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_158:
				IL_388:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00491F30 File Offset: 0x00490130
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
					goto IL_BA;
				case 1:
					if (this.a)
					{
						num2 = (short)975634434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)303955968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_BA:
			num2 = (short)1276051456;
			short num3 = num2;
			num2 = (short)1582307358;
			short num4 = num2;
			num2 = (short)1288443934;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				num2 = (short)1406861313;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.DataContext = null;
				this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.MyDataPresenter = null;
				num2 = (short)219611137;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)211156992;
				if (num2 != 0)
				{
				}
				break;
			}
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00492070 File Offset: 0x00490270
		public override void SetDataContext()
		{
			short num = (short)1558970378;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10112].EmbeddedRecset != null)
					{
						num = (short)1514471431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_305;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1737031691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory).MySecondaryRecordsetDataSource = null;
					num = (short)522846208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)981598222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_305;
				case 6:
					goto IL_265;
				case 7:
					goto IL_D1;
				case 8:
					num = (short)2058485761;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2049);
					num = (short)1697972226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (feature != null)
					{
						num = (short)454295564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 11:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2049);
					num = (short)174194697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)2004811789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1681653764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10112] != null)
					{
						num = (short)1711013894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_60:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1997471752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2049);
				num = (short)1876688151;
				short num3 = num;
				num = (short)2020408599;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)44498944;
					if (num != 0)
					{
					}
					num = (short)1383202821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_265:
				num = (short)32636928;
				short num4 = num;
				num = (short)783810561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_305:
				num = (short)2095841283;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10112].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory).SyncDataSources();
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x004923C0 File Offset: 0x004905C0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)107216900;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1550712837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)1160052738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)471854367;
					short num3 = num;
					num = (short)1136127263;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CC;
					default:
						num = (short)259784704;
						if (num != 0)
						{
						}
						num = (short)1264320518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)341704705;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.MyRecordsetDataSource;
					num = (short)133038087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_E9;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 5:
				{
					num = (short)474873856;
					short num4 = num;
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧꿩铫黭釯鳱郳鏵諷꣹鷻髽槿洁䴃栅渇攉縋挍焏昑紓礕瘗嬙伛唝瀟倡䬣䄥娧䬩䄫䌭夯就匳縵儷䤹䠻儽㈿㭁", a_))
					{
						num = (short)1873608712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
					return;
				case 7:
					goto IL_CC;
				case 8:
					num = (short)236322817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)283836416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_CC:
				if (myRecordsetDataSource == null)
				{
					return;
				}
				num = (short)647626755;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner item = (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00492610 File Offset: 0x00490810
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)68026368;
			short num2 = num;
			num = (short)407694358;
			short num3 = num;
			num = (short)1172040726;
			switch (num3 == num)
			{
			}
			num = (short)1115029505;
			if (num != 0)
			{
			}
			num = (short)514326528;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x004926C0 File Offset: 0x004908C0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)981139456;
			short num2 = num;
			num = (short)398509480;
			short num3 = num;
			num = (short)237749672;
			switch (num3 == num)
			{
			}
			num = (short)64749568;
			if (num != 0)
			{
			}
			num = (short)1874591745;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x0049276C File Offset: 0x0049096C
		internal void OnExpanderRadioInformationASKProgrammingHistoryClick(object sender, global::System.Windows.RoutedEventArgs e)
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
					goto IL_DC;
				case 1:
				{
					num2 = (short)2030305281;
					if (num2 != 0)
					{
					}
					object myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num2 = (short)2136932354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				}
				case 2:
				{
					object myRecordsetDataSource;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner item;
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.SyncDataSources();
					num2 = (short)801570816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_DC:
			num2 = (short)2000617472;
			short num3 = num2;
			num2 = (short)1383572362;
			short num4 = num2;
			num2 = (short)1066050442;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner item = (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				object myRecordsetDataSource = this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.MyRecordsetDataSource;
				num2 = (short)810024961;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)212336640;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_153:
			this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.TableMode = false;
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x004928D8 File Offset: 0x00490AD8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num;
			if (!this.b)
			{
				num = (short)618368025;
				short num2 = num;
				num = (short)431852569;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)9240577;
					if (num != 0)
					{
					}
					num = (short)1962541056;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺迼黾攀樂樄∆㬈㬊搌愎眐簒朔稖砘漚琜瀞传ఢ圤䘦䴨䈪䈬䘮弰唲娴䔶吸娺䤼嘾⹀ⵂ歄㽆⡈♊⅌", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1228210176;
			short num3 = num;
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x004929B8 File Offset: 0x00490BB8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1412366336;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					num = (short)992018434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_3D57;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_4C66;
				case 2:
				case 3:
					goto IL_5EC0;
				case 4:
					goto IL_1610;
				case 5:
					goto IL_1CC7;
				case 6:
					goto IL_15EC;
				case 7:
					goto IL_426D;
				case 8:
					goto IL_108E;
				case 9:
					goto IL_478A;
				case 10:
					goto IL_5DF2;
				case 11:
					goto IL_5993;
				case 12:
					goto IL_50BB;
				case 13:
					goto IL_2755;
				case 14:
					goto IL_5789;
				case 15:
					goto IL_5C29;
				case 16:
					goto IL_467E;
				case 17:
					goto IL_5E47;
				case 18:
					goto IL_4A1A;
				case 19:
					goto IL_4E4F;
				case 20:
					goto IL_2661;
				case 21:
					goto IL_1271;
				case 22:
					goto IL_399C;
				case 23:
					goto IL_260C;
				case 24:
					goto IL_2B3E;
				case 25:
					goto IL_1FA9;
				case 26:
					goto IL_55D4;
				case 27:
					goto IL_460C;
				case 28:
					goto IL_45CE;
				case 29:
					goto IL_1532;
				case 30:
					goto IL_507D;
				case 31:
					goto IL_11FF;
				case 32:
					goto IL_3B89;
				case 33:
					goto IL_2695;
				case 34:
					goto IL_577C;
				case 35:
					goto IL_2313;
				case 36:
					goto IL_2063;
				case 37:
					goto IL_5B5C;
				case 38:
					goto IL_58F3;
				case 39:
					goto IL_4583;
				case 40:
					goto IL_2151;
				case 41:
					goto IL_4FC6;
				case 42:
					goto IL_17C8;
				case 43:
					goto IL_504C;
				case 44:
					goto IL_5D2E;
				case 45:
					goto IL_4CA4;
				case 46:
					goto IL_286A;
				case 47:
					goto IL_2CEA;
				case 48:
					goto IL_4D85;
				case 49:
					goto IL_25D8;
				case 50:
					goto IL_1B0F;
				case 51:
					goto IL_3372;
				case 52:
					goto IL_51E4;
				case 53:
					goto IL_4EFF;
				case 54:
					goto IL_416E;
				case 55:
					goto IL_3CDC;
				case 56:
					goto IL_191C;
				case 57:
					goto IL_51F1;
				case 58:
					goto IL_468B;
				case 59:
					goto IL_41F4;
				case 60:
					goto IL_2762;
				case 61:
					goto IL_1E52;
				case 62:
					goto IL_4218;
				case 63:
					goto IL_2A08;
				case 64:
					goto IL_3A63;
				case 65:
					goto IL_524C;
				case 66:
					goto IL_3BDE;
				case 67:
					goto IL_3007;
				case 68:
					goto IL_3294;
				case 69:
					goto IL_3D76;
				case 70:
					goto IL_3AC5;
				case 71:
					goto IL_2D42;
				case 72:
					goto IL_5137;
				case 73:
					goto IL_4626;
				case 74:
					goto IL_26E3;
				case 75:
					goto IL_12C9;
				case 76:
					goto IL_4C59;
				case 77:
					goto IL_3E33;
				case 78:
					goto IL_2BC4;
				case 79:
					goto IL_1889;
				case 80:
					goto IL_21CD;
				case 81:
					goto IL_356F;
				case 82:
					goto IL_4F54;
				case 83:
					goto IL_1929;
				case 84:
					goto IL_2018;
				case 85:
					goto IL_4291;
				case 86:
					goto IL_3FB2;
				case 87:
					goto IL_3C8E;
				case 88:
					goto IL_3185;
				case 89:
					goto IL_1CF8;
				case 90:
					goto IL_5327;
				case 91:
					goto IL_4DC3;
				case 92:
					goto IL_573B;
				case 93:
					goto IL_4B7B;
				case 94:
					goto IL_5CBC;
				case 95:
					goto IL_5524;
				case 96:
					goto IL_3906;
				case 97:
					goto IL_2972;
				case 98:
					goto IL_26A2;
				case 99:
					goto IL_5B90;
				case 100:
					goto IL_1B4D;
				case 101:
					goto IL_45DB;
				case 102:
					goto IL_43D8;
				case 103:
					goto IL_291A;
				case 104:
					goto IL_4303;
				case 105:
					goto IL_3467;
				case 106:
					goto IL_4D37;
				case 107:
					goto IL_1501;
				case 108:
					goto IL_5E9C;
				case 109:
					goto IL_5B9D;
				case 110:
					goto IL_1C21;
				case 111:
					goto IL_31D0;
				case 112:
					goto IL_5232;
				case 113:
					goto IL_1B67;
				case 114:
					goto IL_44EA;
				case 115:
					goto IL_429E;
				case 116:
					goto IL_3310;
				case 117:
					goto IL_47AE;
				case 118:
					goto IL_5453;
				case 119:
					goto IL_4AA0;
				case 120:
					goto IL_4310;
				case 121:
					goto IL_3C5D;
				case 122:
					goto IL_4DA9;
				case 123:
					goto IL_2A9B;
				case 124:
					goto IL_2EE1;
				case 125:
					goto IL_2DEC;
				case 126:
					goto IL_459D;
				case 127:
					goto IL_2306;
				case 128:
					goto IL_2A6A;
				case 129:
					goto IL_35BA;
				case 130:
					goto IL_5C02;
				case 131:
					goto IL_50EC;
				case 132:
					goto IL_FE1;
				case 133:
					goto IL_3C1C;
				case 134:
					goto IL_1D67;
				case 135:
					goto IL_4C1B;
				case 136:
					goto IL_1556;
				case 137:
					goto IL_194D;
				case 138:
					goto IL_1FD0;
				case 139:
					goto IL_5BAA;
				case 140:
					goto IL_1DBF;
				case 141:
					goto IL_345A;
				case 142:
					goto IL_168C;
				case 143:
					goto IL_56A8;
				case 144:
					goto IL_1AD1;
				case 145:
					goto IL_1525;
				case 146:
					goto IL_392A;
				case 147:
					goto IL_3CB5;
				case 148:
					goto IL_13C1;
				case 149:
					goto IL_3E7B;
				case 150:
					goto IL_3859;
				case 151:
					goto IL_39E7;
				case 152:
					goto IL_1298;
				case 153:
					goto IL_1B1C;
				case 154:
					goto IL_20AE;
				case 155:
					goto IL_5270;
				case 156:
					goto IL_58CF;
				case 157:
					goto IL_10D6;
				case 158:
					goto IL_2504;
				case 159:
					goto IL_12D6;
				case 160:
					goto IL_4F95;
				case 161:
					goto IL_5900;
				case 162:
					goto IL_5D3B;
				case 163:
					goto IL_589B;
				case 164:
					goto IL_1264;
				case 165:
					goto IL_51D7;
				case 166:
					goto IL_290D;
				case 167:
					goto IL_1DCC;
				case 168:
					goto IL_32C5;
				case 169:
					goto IL_5B11;
				case 170:
					goto IL_2D35;
				case 171:
					goto IL_588E;
				case 172:
					goto IL_5BC4;
				case 173:
					goto IL_1BE3;
				case 174:
					goto IL_5168;
				case 175:
					goto IL_377F;
				case 176:
					goto IL_2F2C;
				case 177:
					goto IL_1376;
				case 178:
					goto IL_3832;
				case 179:
					goto IL_2F9B;
				case 180:
					goto IL_1C96;
				case 181:
					goto IL_39B6;
				case 182:
					goto IL_4E80;
				case 183:
					goto IL_270A;
				case 184:
					goto IL_3DCE;
				case 185:
					goto IL_4F7B;
				case 186:
					goto IL_3F2C;
				case 187:
					goto IL_3116;
				case 188:
					goto IL_5E8F;
				case 189:
					goto IL_3D69;
				case 190:
					goto IL_25B1;
				case 191:
					goto IL_3014;
				case 192:
					goto IL_10B2;
				case 193:
					goto IL_3D5C;
				case 194:
					goto IL_2D66;
				case 195:
					goto IL_3EEE;
				case 196:
					goto IL_56CC;
				case 197:
					goto IL_36B5;
				case 198:
					goto IL_2829;
				case 199:
					goto IL_47F9;
				case 200:
					goto IL_1B29;
				case 201:
					goto IL_43FC;
				case 202:
					goto IL_4664;
				case 203:
					goto IL_22C5;
				case 204:
					goto IL_44C3;
				case 205:
					goto IL_3FE6;
				case 206:
					goto IL_4365;
				case 207:
					goto IL_2D1B;
				case 208:
					goto IL_4EE5;
				case 209:
					goto IL_1307;
				case 210:
					goto IL_FB0;
				case 211:
					goto IL_4A6F;
				case 212:
					goto IL_5A71;
				case 213:
					goto IL_4E11;
				case 214:
					goto IL_119A;
				case 215:
					goto IL_5D5F;
				case 216:
					goto IL_4DEA;
				case 217:
					goto IL_4E8D;
				case 218:
					goto IL_53EE;
				case 219:
					goto IL_47C8;
				case 220:
					goto IL_10E3;
				case 221:
					goto IL_446B;
				case 222:
					goto IL_5A0C;
				case 223:
					goto IL_47BB;
				case 224:
					goto IL_56E6;
				case 225:
					goto IL_2E5B;
				case 226:
					goto IL_5579;
				case 227:
					goto IL_1E14;
				case 228:
					goto IL_43CB;
				case 229:
					goto IL_52C5;
				case 230:
					goto IL_14F4;
				case 231:
					goto IL_2ADC;
				case 232:
					goto IL_2EB0;
				case 233:
					goto IL_3B34;
				case 234:
					goto IL_128B;
				case 235:
					goto IL_499E;
				case 236:
					goto IL_2EFB;
				case 237:
					goto IL_1043;
				case 238:
					goto IL_4123;
				case 239:
					goto IL_46BC;
				case 240:
					goto IL_37FE;
				case 241:
					goto IL_27A0;
				case 242:
					goto IL_4BD0;
				case 243:
					goto IL_11E5;
				case 244:
					goto IL_3A70;
				case 245:
					goto IL_38D5;
				case 246:
					goto IL_5593;
				case 247:
					goto IL_19C9;
				case 248:
					goto IL_11D8;
				case 249:
					goto IL_3109;
				case 250:
					goto IL_24BC;
				case 251:
					goto IL_28DC;
				case 252:
					goto IL_1C7C;
				case 253:
					goto IL_3E19;
				case 254:
					goto IL_51FE;
				case 255:
					goto IL_2113;
				case 256:
					goto IL_4D13;
				case 257:
					goto IL_3D1A;
				case 258:
					goto IL_26AF;
				case 259:
					goto IL_3772;
				case 260:
					goto IL_2654;
				case 261:
					goto IL_2877;
				case 262:
					goto IL_294E;
				case 263:
					goto IL_3724;
				case 264:
					goto IL_3FD9;
				case 265:
					goto IL_22D2;
				case 266:
					goto IL_2793;
				case 267:
					goto IL_5396;
				case 268:
					goto IL_454F;
				case 269:
					goto IL_55C7;
				case 270:
					goto IL_1718;
				case 271:
					goto IL_2D97;
				case 272:
					goto IL_1AC4;
				case 273:
					goto IL_17EC;
				case 274:
					goto IL_1A0A;
				case 275:
					goto IL_2884;
				case 276:
					goto IL_3937;
				case 277:
					goto IL_2429;
				case 278:
					goto IL_26FD;
				case 279:
					goto IL_309A;
				case 280:
					goto IL_11CB;
				case 281:
					goto IL_1BA5;
				case 282:
					goto IL_24AF;
				case 283:
					goto IL_34D9;
				case 284:
					goto IL_16C0;
				case 285:
					goto IL_48A3;
				case 286:
					goto IL_244D;
				case 287:
					goto IL_3500;
				case 288:
					goto IL_285D;
				case 289:
					goto IL_5B76;
				case 290:
					goto IL_21DA;
				case 291:
					goto IL_4C0E;
				case 292:
					goto IL_2934;
				case 293:
					goto IL_34B2;
				case 294:
					goto IL_37CD;
				case 295:
					goto IL_471E;
				case 296:
					goto IL_576F;
				case 297:
					goto IL_4F6E;
				case 298:
					goto IL_3CE9;
				case 299:
					goto IL_1FC3;
				case 300:
					goto IL_2178;
				case 301:
					goto IL_49AB;
				case 302:
					goto IL_5CC9;
				case 303:
					goto IL_3CA8;
				case 304:
					goto IL_1B5A;
				case 305:
					goto IL_24A2;
				case 306:
					goto IL_1176;
				case 307:
					goto IL_547A;
				case 308:
					goto IL_23B0;
				case 309:
					goto IL_3F1F;
				case 310:
					goto IL_43B1;
				case 311:
					goto IL_13A7;
				case 312:
					goto IL_1219;
				case 313:
					goto IL_5643;
				case 314:
					goto IL_42AB;
				case 315:
					goto IL_5612;
				case 316:
					goto IL_237F;
				case 317:
					goto IL_53BD;
				case 318:
					goto IL_2AC2;
				case 319:
					goto IL_1644;
				case 320:
					goto IL_15AE;
				case 321:
					goto IL_3CC2;
				case 322:
					goto IL_384C;
				case 323:
					goto IL_4DF7;
				case 324:
					goto IL_1563;
				case 325:
					goto IL_40E5;
				case 326:
					goto IL_2E1D;
				case 327:
					goto IL_365D;
				case 328:
					goto IL_1FB6;
				case 329:
					goto IL_316B;
				case 330:
					goto IL_2C7B;
				case 331:
					goto IL_29B0;
				case 332:
					goto IL_2B93;
				case 333:
					goto IL_2094;
				case 334:
					goto IL_26BC;
				case 335:
					goto IL_25FF;
				case 336:
					goto IL_2C0C;
				case 337:
					goto IL_1725;
				case 338:
					goto IL_4766;
				case 339:
					goto IL_28CF;
				case 340:
					goto IL_3758;
				case 341:
					goto IL_124A;
				case 342:
					goto IL_26C9;
				case 343:
					goto IL_1A55;
				case 344:
					goto IL_21E7;
				case 345:
					goto IL_5CF0;
				case 346:
					goto IL_455C;
				case 347:
					goto IL_41C3;
				case 348:
					goto IL_18BA;
				case 349:
					goto IL_2630;
				case 350:
					goto IL_4B4A;
				case 351:
					goto IL_570A;
				case 352:
					goto IL_5586;
				case 353:
					goto IL_3232;
				case 354:
					goto IL_2688;
				case 355:
					goto IL_140C;
				case 356:
					goto IL_59C4;
				case 357:
					goto IL_4192;
				case 358:
					goto IL_5412;
				case 359:
					goto IL_1DA5;
				case 360:
					goto IL_4922;
				case 361:
					goto IL_1F54;
				case 362:
					goto IL_38B1;
				case 363:
					goto IL_2B62;
				case 364:
					goto IL_1F9C;
				case 365:
					goto IL_2E41;
				case 366:
					goto IL_3951;
				case 367:
					goto IL_3DF5;
				case 368:
					goto IL_484E;
				case 369:
					goto IL_518C;
				case 370:
					goto IL_19FD;
				case 371:
					goto IL_2DBB;
				case 372:
					goto IL_503F;
				case 373:
					goto IL_387D;
				case 374:
					goto IL_581F;
				case 375:
					goto IL_324C;
				case 376:
					goto IL_4633;
				case 377:
					goto IL_35D4;
				case 378:
					goto IL_2C6E;
				case 379:
					goto IL_5B04;
				case 380:
					goto IL_5303;
				case 381:
					goto IL_18C7;
				case 382:
					goto IL_451B;
				case 383:
					goto IL_1637;
				case 384:
					goto IL_4F61;
				case 385:
					goto IL_5762;
				case 386:
					goto IL_13FF;
				case 387:
					goto IL_20C8;
				case 388:
					goto IL_1145;
				case 389:
					goto IL_1430;
				case 390:
					goto IL_1138;
				case 391:
					goto IL_5CE3;
				case 392:
					goto IL_5667;
				case 393:
					goto IL_5C36;
				case 394:
					goto IL_497A;
				case 395:
					goto IL_59E8;
				case 396:
					goto IL_58C2;
				case 397:
					goto IL_3DE8;
				case 398:
					goto IL_39A9;
				case 399:
					goto IL_3A49;
				case 400:
					goto IL_5DC1;
				case 401:
					goto IL_147B;
				case 402:
					goto IL_42C5;
				case 403:
					goto IL_35C7;
				case 404:
					goto IL_4E9A;
				case 405:
					goto IL_2F6A;
				case 406:
					goto IL_37C0;
				case 407:
					goto IL_4542;
				case 408:
					goto IL_3D9D;
				case 409:
					goto IL_3038;
				case 410:
					goto IL_1A79;
				case 411:
					goto IL_2900;
				case 412:
					goto IL_5B69;
				case 413:
					goto IL_344D;
				case 414:
					goto IL_23BD;
				case 415:
					goto IL_419F;
				case 416:
					goto IL_2ED4;
				case 417:
					goto IL_5218;
				case 418:
					goto IL_162A;
				case 419:
					goto IL_3440;
				case 420:
					goto IL_4090;
				case 421:
					goto IL_4742;
				case 422:
					goto IL_5446;
				case 423:
					goto IL_3B27;
				case 424:
					goto IL_20BB;
				case 425:
					goto IL_4915;
				case 426:
					goto IL_1668;
				case 427:
					goto IL_1865;
				case 428:
					goto IL_4C28;
				case 429:
					goto IL_4D6B;
				case 430:
					goto IL_25E5;
				case 431:
					goto IL_4116;
				case 432:
					goto IL_2535;
				case 433:
					goto IL_5B38;
				case 434:
					goto IL_2C19;
				case 435:
					goto IL_2E4E;
				case 436:
					goto IL_146E;
				case 437:
					goto IL_44D0;
				case 438:
					goto IL_5E6B;
				case 439:
					goto IL_1E5F;
				case 440:
					goto IL_55A0;
				case 441:
					goto IL_305C;
				case 442:
					goto IL_52B8;
				case 443:
					goto IL_37B3;
				case 444:
					goto IL_1BBF;
				case 445:
					goto IL_106A;
				case 446:
					goto IL_27EB;
				case 447:
					goto IL_25CB;
				case 448:
					goto IL_2F5D;
				case 449:
					goto IL_2056;
				case 450:
					goto IL_51B3;
				case 451:
					goto IL_39C3;
				case 452:
					goto IL_120C;
				case 453:
					goto IL_1C55;
				case 454:
					goto IL_2927;
				case 455:
					goto IL_56D9;
				case 456:
					goto IL_5E23;
				case 457:
					goto IL_18F8;
				case 458:
					goto IL_5ADD;
				case 459:
					goto IL_3474;
				case 460:
					goto IL_4D06;
				case 461:
					goto IL_34A5;
				case 462:
					goto IL_396B;
				case 463:
					goto IL_20E2;
				case 464:
					goto IL_34F3;
				case 465:
					goto IL_38A4;
				case 466:
					goto IL_3A94;
				case 467:
					goto IL_1E90;
				case 468:
					goto IL_22A1;
				case 469:
					goto IL_1E9D;
				case 470:
					goto IL_19D6;
				case 471:
					goto IL_593E;
				case 472:
					goto IL_5A64;
				case 473:
					goto IL_5D21;
				case 474:
					goto IL_2D73;
				case 475:
					goto IL_3EFB;
				case 476:
					goto IL_281C;
				case 477:
					goto IL_5674;
				case 478:
					goto IL_57A3;
				case 479:
					goto IL_512A;
				case 480:
					goto IL_4BAC;
				case 481:
					goto IL_32A1;
				case 482:
					goto IL_216B;
				case 483:
					goto IL_15D2;
				case 484:
					goto IL_5850;
				case 485:
					goto IL_1AF5;
				case 486:
					goto IL_41D0;
				case 487:
					goto IL_40C1;
				case 488:
					goto IL_1D29;
				case 489:
					goto IL_35EE;
				case 490:
					goto IL_22F9;
				case 491:
					goto IL_11F2;
				case 492:
					goto IL_594B;
				case 493:
					goto IL_5059;
				case 494:
					goto IL_546D;
				case 495:
					goto IL_2D0E;
				case 496:
					goto IL_3825;
				case 497:
					goto IL_5460;
				case 498:
					goto IL_4225;
				case 499:
					goto IL_406C;
				case 500:
					goto IL_16FE;
				case 501:
					goto IL_3765;
				case 502:
					goto IL_3DC1;
				case 503:
					goto IL_1C6F;
				case 504:
					goto IL_5500;
				case 505:
					goto IL_2573;
				case 506:
					goto IL_5681;
				case 507:
					goto IL_59B7;
				case 508:
					goto IL_26D6;
				case 509:
					goto IL_5755;
				case 510:
					goto IL_21A9;
				case 511:
					goto IL_1998;
				case 512:
					goto IL_30BE;
				case 513:
					goto IL_46E0;
				case 514:
					goto IL_215E;
				case 515:
					goto IL_450E;
				case 516:
					goto IL_5A95;
				case 517:
					goto IL_5C67;
				case 518:
					goto IL_1454;
				case 519:
					goto IL_42D2;
				case 520:
					goto IL_220B;
				case 521:
					goto IL_25A4;
				case 522:
					goto IL_23E1;
				case 523:
					goto IL_1841;
				case 524:
					goto IL_537C;
				case 525:
					goto IL_357C;
				case 526:
					goto IL_2559;
				case 527:
					goto IL_161D;
				case 528:
					goto IL_2FE3;
				case 529:
					goto IL_235B;
				case 530:
					goto IL_13B4;
				case 531:
					goto IL_5748;
				case 532:
					goto IL_5B83;
				case 533:
					goto IL_2CDD;
				case 534:
					goto IL_4FEA;
				case 535:
					goto IL_501B;
				case 536:
					goto IL_4A00;
				case 537:
					goto IL_3E26;
				case 538:
					goto IL_2836;
				case 539:
					goto IL_4B6E;
				case 540:
					goto IL_2DC8;
				case 541:
					goto IL_2259;
				case 542:
					goto IL_31C3;
				case 543:
					goto IL_4AE8;
				case 544:
					goto IL_1AB7;
				case 545:
					goto IL_5A4A;
				case 546:
					goto IL_14D0;
				case 547:
					goto IL_3147;
				case 548:
					goto IL_3650;
				case 549:
					goto IL_4EA7;
				case 550:
					goto IL_1C48;
				case 551:
					goto IL_36A8;
				case 552:
					goto IL_33EB;
				case 553:
					goto IL_33C7;
				case 554:
					goto IL_4590;
				case 555:
					goto IL_2AB5;
				case 556:
					goto IL_1E21;
				case 557:
					goto IL_13F2;
				case 558:
					goto IL_57EE;
				case 559:
					goto IL_149F;
				case 560:
					goto IL_45C1;
				case 561:
					goto IL_FA3;
				case 562:
					goto IL_3F81;
				case 563:
					goto IL_5C8B;
				case 564:
					goto IL_3F5D;
				case 565:
					goto IL_3AD2;
				case 566:
					goto IL_398F;
				case 567:
					goto IL_4A0D;
				case 568:
					goto IL_2724;
				case 569:
					goto IL_1C3B;
				case 570:
					goto IL_54B8;
				case 571:
					goto IL_2A46;
				case 572:
					goto IL_4B3D;
				case 573:
					goto IL_4109;
				case 574:
					goto IL_2941;
				case 575:
					goto IL_30EF;
				case 576:
					goto IL_177D;
				case 577:
					goto IL_57BD;
				case 578:
					goto IL_1BB2;
				case 579:
					goto IL_16A6;
				case 580:
					goto IL_585D;
				case 581:
					goto IL_35AD;
				case 582:
					goto IL_4B88;
				case 583:
					goto IL_12E3;
				case 584:
					goto IL_1036;
				case 585:
					goto IL_16B3;
				case 586:
					goto IL_1756;
				case 587:
					goto IL_34E6;
				case 588:
					goto IL_334E;
				case 589:
					goto IL_1383;
				case 590:
					goto IL_3C29;
				case 591:
					goto IL_1D98;
				case 592:
					goto IL_3CCF;
				case 593:
					goto IL_3C0F;
				case 594:
					goto IL_52D2;
				case 595:
					goto IL_227D;
				case 596:
					goto IL_32E9;
				case 597:
					goto IL_51A6;
				case 598:
					goto IL_5C0F;
				case 599:
					goto IL_2786;
				case 600:
					goto IL_36CF;
				case 601:
					goto IL_3B65;
				case 602:
					goto IL_5CD6;
				case 603:
					goto IL_32F6;
				case 604:
					goto IL_2ACF;
				case 605:
					goto IL_4D44;
				case 606:
					goto IL_55E1;
				case 607:
					goto IL_2C95;
				case 608:
					goto IL_15A1;
				case 609:
					goto IL_2C88;
				case 610:
					goto IL_3303;
				case 611:
					goto IL_2597;
				case 612:
					goto IL_400A;
				case 613:
					goto IL_1FF4;
				case 614:
					goto IL_3731;
				case 615:
					goto IL_5B1E;
				case 616:
					goto IL_4671;
				case 617:
					goto IL_2A39;
				case 618:
					goto IL_4FA2;
				case 619:
					goto IL_2B1A;
				case 620:
					goto IL_5439;
				case 621:
					goto IL_2232;
				case 622:
					goto IL_50AE;
				case 623:
					goto IL_4535;
				case 624:
					goto IL_5CFD;
				case 625:
					goto IL_2F08;
				case 626:
					goto IL_1971;
				case 627:
					goto IL_405F;
				case 628:
					goto IL_17A1;
				case 629:
					goto IL_36C2;
				case 630:
					goto IL_5D6C;
				case 631:
					goto IL_5717;
				case 632:
					goto IL_54AB;
				case 633:
					goto IL_43BE;
				case 634:
					goto IL_1169;
				case 635:
					goto IL_2495;
				case 636:
					goto IL_4341;
				case 637:
					goto IL_2405;
				case 638:
					goto IL_5DB4;
				case 639:
					goto IL_198B;
				case 640:
					goto IL_1594;
				case 641:
					goto IL_31B6;
				case 642:
					goto IL_1A17;
				case 643:
					goto IL_1810;
				case 644:
					goto IL_42B8;
				case 645:
					goto IL_28C2;
				case 646:
					goto IL_568E;
				case 647:
					goto IL_1770;
				case 648:
					goto IL_5294;
				case 649:
					goto IL_1570;
				case 650:
					goto IL_1DB2;
				case 651:
					goto IL_3069;
				case 652:
					goto IL_58A8;
				case 653:
					goto IL_3FBF;
				case 654:
					goto IL_5A26;
				case 655:
					goto IL_16DA;
				case 656:
					goto IL_2B0D;
				case 657:
					goto IL_373E;
				case 658:
					goto IL_3A56;
				case 659:
					goto IL_48D7;
				case 660:
					goto IL_35FB;
				case 661:
					goto IL_3589;
				case 662:
					goto IL_4334;
				case 663:
					goto IL_1749;
				case 664:
					goto IL_48BD;
				case 665:
					goto IL_4D78;
				case 666:
					goto IL_1896;
				case 667:
					goto IL_5AB9;
				case 668:
					goto IL_4908;
				case 669:
					goto IL_40B4;
				case 670:
					goto IL_541F;
				case 671:
					goto IL_17AE;
				case 672:
					goto IL_1005;
				case 673:
					goto IL_2511;
				case 674:
					goto IL_4711;
				case 675:
					goto IL_3DDB;
				case 676:
					goto IL_38F9;
				case 677:
					goto IL_2E10;
				case 678:
					goto IL_2C4A;
				case 679:
					goto IL_3C6A;
				case 680:
					goto IL_1F3A;
				case 681:
					goto IL_22EC;
				case 682:
					goto IL_2EEE;
				case 683:
					goto IL_500E;
				case 684:
					goto IL_337F;
				case 685:
					goto IL_586A;
				case 686:
					goto IL_F96;
				case 687:
					goto IL_47EC;
				case 688:
					goto IL_4492;
				case 689:
					goto IL_53A3;
				case 690:
					goto IL_24E0;
				case 691:
					goto IL_1DF0;
				case 692:
					goto IL_5548;
				case 693:
					goto IL_3E9F;
				case 694:
					goto IL_1C62;
				case 695:
					goto IL_4154;
				case 696:
					goto IL_3481;
				case 697:
					goto IL_2F39;
				case 698:
					goto IL_3717;
				case 699:
					goto IL_569B;
				case 700:
					goto IL_170B;
				case 701:
					goto IL_57B0;
				case 702:
					goto IL_4CBE;
				case 703:
					goto IL_2B6F;
				case 704:
					goto IL_15DF;
				case 705:
					goto IL_3D83;
				case 706:
					goto IL_2120;
				case 707:
					goto IL_1F2D;
				case 708:
					goto IL_5D90;
				case 709:
					goto IL_4BEA;
				case 710:
					goto IL_1B8B;
				case 711:
					goto IL_3EE1;
				case 712:
					goto IL_1D1C;
				case 713:
					goto IL_30FC;
				case 714:
					goto IL_561F;
				case 715:
					goto IL_3192;
				case 716:
					goto IL_3818;
				case 717:
					goto IL_4147;
				case 718:
					goto IL_5796;
				case 719:
					goto IL_1E83;
				case 720:
					goto IL_449F;
				case 721:
					goto IL_212D;
				case 722:
					goto IL_380B;
				case 723:
					goto IL_123D;
				case 724:
					goto IL_549E;
				case 725:
					goto IL_3897;
				case 726:
					goto IL_27C7;
				case 727:
					goto IL_33A3;
				case 728:
					goto IL_4E42;
				case 729:
					goto IL_1AAA;
				case 730:
					goto IL_511D;
				case 731:
					goto IL_5812;
				case 732:
					goto IL_1321;
				case 733:
					goto IL_4A7C;
				case 734:
					goto IL_5924;
				case 735:
					goto IL_542C;
				case 736:
					goto IL_20A1;
				case 737:
					goto IL_25F2;
				case 738:
					goto IL_13CE;
				case 739:
					goto IL_5C98;
				case 740:
					goto IL_5B2B;
				case 741:
					goto IL_48B0;
				case 742:
					goto IL_29E1;
				case 743:
					goto IL_20D5;
				case 744:
					goto IL_3270;
				case 745:
					goto IL_49CF;
				case 746:
					goto IL_2566;
				case 747:
					goto IL_4E35;
				case 748:
					goto IL_267B;
				case 749:
					goto IL_2850;
				case 750:
					goto IL_353E;
				case 751:
					goto IL_482A;
				case 752:
					goto IL_313A;
				case 753:
					goto IL_55BA;
				case 754:
					goto IL_29FB;
				case 755:
					goto IL_1CBA;
				case 756:
					goto IL_3F8E;
				case 757:
					goto IL_2337;
				case 758:
					goto IL_4161;
				case 759:
					goto IL_520B;
				case 760:
					goto IL_1699;
				case 761:
					goto IL_4DDD;
				case 762:
					goto IL_12A5;
				case 763:
					goto IL_3A18;
				case 764:
					goto IL_378C;
				case 765:
					goto IL_14C3;
				case 766:
					goto IL_37A6;
				case 767:
					goto IL_16CD;
				case 768:
					goto IL_2471;
				case 769:
					goto IL_4EC1;
				case 770:
					goto IL_2049;
				case 771:
					goto IL_203C;
				case 772:
					goto IL_1C89;
				case 773:
					goto IL_197E;
				case 774:
					goto IL_1EC1;
				case 775:
					goto IL_36F3;
				case 776:
					goto IL_3562;
				case 777:
					goto IL_44DD;
				case 778:
					goto IL_1F47;
				case 779:
					goto IL_4BDD;
				case 780:
					goto IL_2A77;
				case 781:
					goto IL_1F78;
				case 782:
					goto IL_50DF;
				case 783:
					goto IL_3C50;
				case 784:
					goto IL_4619;
				case 785:
					goto IL_219C;
				case 786:
					goto IL_1114;
				case 787:
					goto IL_2CB9;
				case 788:
					goto IL_27BA;
				case 789:
					goto IL_5BD1;
				case 790:
					goto IL_1D36;
				case 791:
					goto IL_5E16;
				case 792:
					goto IL_4CE2;
				case 793:
					goto IL_FBD;
				case 794:
					goto IL_383F;
				case 795:
					goto IL_4485;
				case 796:
					goto IL_1B98;
				case 797:
					goto IL_2218;
				case 798:
					goto IL_2F77;
				case 799:
					goto IL_289E;
				case 800:
					goto IL_1763;
				case 801:
					goto IL_1C2E;
				case 802:
					goto IL_1314;
				case 803:
					goto IL_5A57;
				case 804:
					goto IL_11A7;
				case 805:
					goto IL_3CF6;
				case 806:
					goto IL_223F;
				case 807:
					goto IL_2AA8;
				case 808:
					goto IL_3643;
				case 809:
					goto IL_19E3;
				case 810:
					goto IL_4AC4;
				case 811:
					goto IL_2BE8;
				case 812:
					goto IL_3EAC;
				case 813:
					goto IL_1345;
				case 814:
					goto IL_3FCC;
				case 815:
					goto IL_4F47;
				case 816:
					goto IL_4A3E;
				case 817:
					goto IL_53CA;
				case 818:
					goto IL_4896;
				case 819:
					goto IL_48CA;
				case 820:
					goto IL_50A1;
				case 821:
					goto IL_17BB;
				case 822:
					goto IL_3201;
				case 823:
					goto IL_2731;
				case 824:
					goto IL_5389;
				case 825:
					goto IL_3944;
				case 826:
					goto IL_53B0;
				case 827:
					goto IL_374B;
				case 828:
					goto IL_39F4;
				case 829:
					goto IL_4698;
				case 830:
					goto IL_37F1;
				case 831:
					goto IL_5BB7;
				case 832:
					goto IL_4E04;
				case 833:
					goto IL_45FF;
				case 834:
					goto IL_4C35;
				case 835:
					goto IL_48E4;
				case 836:
					goto IL_366A;
				case 837:
					goto IL_1257;
				case 838:
					goto IL_5605;
				case 839:
					goto IL_3C02;
				case 840:
					goto IL_1352;
				case 841:
					goto IL_3076;
				case 842:
					goto IL_3524;
				case 843:
					goto IL_4569;
				case 844:
					goto IL_52F6;
				case 845:
					goto IL_515B;
				case 846:
					goto IL_4640;
				case 847:
					goto IL_30CB;
				case 848:
					goto IL_224C;
				case 849:
					goto IL_2BB7;
				case 850:
					goto IL_3C43;
				case 851:
					goto IL_1050;
				case 852:
					goto IL_403B;
				case 853:
					goto IL_4423;
				case 854:
					goto IL_19BC;
				case 855:
					goto IL_4409;
				case 856:
					goto IL_4478;
				case 857:
					goto IL_25BE;
				case 858:
					goto IL_4F23;
				case 859:
					goto IL_4B19;
				case 860:
					goto IL_1C07;
				case 861:
					goto IL_3A3C;
				case 862:
					goto IL_297F;
				case 863:
					goto IL_4EF2;
				case 864:
					goto IL_2C26;
				case 865:
					goto IL_42DF;
				case 866:
					goto IL_1461;
				case 867:
					goto IL_4C97;
				case 868:
					goto IL_3B58;
				case 869:
					goto IL_1B02;
				case 870:
					goto IL_5C43;
				case 871:
					goto IL_4249;
				case 872:
					goto IL_5C1C;
				case 873:
					goto IL_4416;
				case 874:
					goto IL_5843;
				case 875:
					goto IL_523F;
				case 876:
					goto IL_10F0;
				case 877:
					goto IL_54DC;
				case 878:
					goto IL_127E;
				case 879:
					goto IL_402E;
				case 880:
					goto IL_1834;
				case 881:
					goto IL_5A19;
				case 882:
					goto IL_3BBA;
				case 883:
					goto IL_3AA1;
				case 884:
					goto IL_1029;
				case 885:
					goto IL_5AF7;
				case 886:
					goto IL_2E7F;
				case 887:
					goto IL_1A3B;
				case 888:
					goto IL_1A86;
				case 889:
					goto IL_1D74;
				case 890:
					goto IL_3AF6;
				case 891:
					goto IL_3531;
				case 892:
					goto IL_3D90;
				case 893:
					goto IL_1A48;
				case 894:
					goto IL_3B96;
				case 895:
					goto IL_31DD;
				case 896:
					goto IL_369B;
				case 897:
					goto IL_26F0;
				case 898:
					goto IL_4DD0;
				case 899:
					goto IL_4A62;
				case 900:
					goto IL_2AE9;
				case 901:
					goto IL_4AF5;
				case 902:
					goto IL_534B;
				case 903:
					goto IL_5931;
				case 904:
					goto IL_5AEA;
				case 905:
					goto IL_27AD;
				case 906:
					goto IL_4447;
				case 907:
					goto IL_298C;
				case 908:
					goto IL_4576;
				case 909:
					goto IL_5225;
				case 910:
					goto IL_3C36;
				case 911:
					goto IL_5DE5;
				case 912:
					goto IL_4872;
				case 913:
					goto IL_1EE5;
				case 914:
					goto IL_4CB1;
				case 915:
					goto IL_35E1;
				case 916:
					goto IL_388A;
				case 917:
					goto IL_34CC;
				case 918:
					goto IL_238C;
				case 919:
					goto IL_3B03;
				case 920:
					goto IL_4F88;
				case 921:
					goto IL_3178;
				case 922:
					goto IL_4DB6;
				case 923:
					goto IL_1C14;
				case 924:
					goto IL_331D;
				case 925:
					goto IL_2FBF;
				case 926:
					goto IL_2106;
				case 927:
					goto IL_2891;
				case 928:
					goto IL_4D51;
				case 929:
					goto IL_2717;
				case 930:
					goto IL_361F;
				case 931:
					goto IL_46ED;
				case 932:
					goto IL_19F0;
				case 933:
					goto IL_2843;
				case 934:
					goto IL_49F3;
				case 935:
					goto IL_4D5E;
				case 936:
					goto IL_5BDE;
				case 937:
					goto IL_5358;
				case 938:
					goto IL_395E;
				case 939:
					goto IL_5110;
				case 940:
					goto IL_57E1;
				case 941:
					goto IL_340F;
				case 942:
					goto IL_27F8;
				case 943:
					goto IL_2A15;
				case 944:
					goto IL_29D4;
				case 945:
					goto IL_481D;
				case 946:
					goto IL_3799;
				case 947:
					goto IL_3225;
				case 948:
					goto IL_3E57;
				case 949:
					goto IL_2E8C;
				case 950:
					goto IL_105D;
				case 951:
					goto IL_2087;
				case 952:
					goto IL_4528;
				case 953:
					goto IL_1CEB;
				case 954:
					goto IL_4E5C;
				case 955:
					goto IL_1F09;
				case 956:
					goto IL_4EB4;
				case 957:
					goto IL_2D28;
				case 958:
					goto IL_266E;
				case 959:
					goto IL_34BF;
				case 960:
					goto IL_341C;
				case 961:
					goto IL_3677;
				case 962:
					goto IL_3F50;
				case 963:
					goto IL_22DF;
				case 964:
					goto IL_58B5;
				case 965:
					goto IL_5199;
				case 966:
					goto IL_596F;
				case 967:
					goto IL_1D43;
				case 968:
					goto IL_323F;
				case 969:
					goto IL_18EB;
				case 970:
					goto IL_2225;
				case 971:
					goto IL_55AD;
				case 972:
					goto IL_5555;
				case 973:
					goto IL_1E2E;
				case 974:
					goto IL_3341;
				case 975:
					goto IL_29EE;
				case 976:
					goto IL_3C9B;
				default:
					num = (short)1920663553;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F96:
			this.RTDBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FA3:
			this.CpyBtnRadInfoLabtoolGPSActivation_A23983 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FB0:
			this.GrpBoxExpanderRadioInformationTrackingOriginalProgrammedInformation = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_FBD:
			this.RadInfoLabtool00982SiteSelAlertForP25_42052 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtool00982SiteSelAlertForP25_42052.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FE1:
			this.RadInfoGeneralCodeplugVersion_A7683 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralCodeplugVersion_A7683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1005:
			this.LblRadInfoLabtoolAuthentication_A37609 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolAuthentication_A37609.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1029:
			this.RTDBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1036:
			this.RTDBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1043:
			this.CVBtnRadInfoFLASHportNumberofTimesFlashed_A8581 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1050:
			this.CVBtnRadInfoLabtoolThirdPartyModemTethering_A43043 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_105D:
			this.RTDBtnRadInfoLabtoolAPX1500EHNO3CH_A44832 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_106A:
			this.RadInfoLabtoolSecurePartitionVersionNumber_A9076 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolSecurePartitionVersionNumber_A9076.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_108E:
			this.HLinkAdvancedSystemKeyInfo = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvancedSystemKeyInfo.Click += this.HLinkClick;
			return;
			IL_10B2:
			this.RadInfoGeneralNautilusVersion_A8564 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralNautilusVersion_A8564.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10D6:
			this.RTDBtnRadInfoGeneralSecureHardwareType = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10E3:
			this.RTDBtnRadInfoTrackingCodeplugVersion_A7688 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10F0:
			this.LblRadInfoLabtoolQA07516NYPDTrigger_43587 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA07516NYPDTrigger_43587.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1114:
			this.LblEnhancedDataOperation_42024 = (global::AcpUI.AcpLabel)target;
			this.LblEnhancedDataOperation_42024.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1138:
			this.RTDBtnRadInfoOptionExpansionBoardBoardName_A37549 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1145:
			this.LblRadInfoOptionExpansionBoardBoardName_A37549 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoOptionExpansionBoardBoardName_A37549.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1169:
			this.RadInfoLabtoolQA00569_7800MHZ_A42596Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1176:
			this.LblRadInfoFrequencyRangesExtendRange762Capable_A43555 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesExtendRange762Capable_A43555.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_119A:
			this.RTDBtnRadInfoLabtoolBornOnDateDBValue_A7568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11A7:
			this.LblRadInfoLabtoolDualRadioOperation_A42245 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolDualRadioOperation_A42245.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11CB:
			this.RTDBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11D8:
			this.RadInfoFLASHportIButton_A8217Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11E5:
			this.CVBtnRadInfoFLASHportIButton_A8217 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11F2:
			this.CVBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11FF:
			this.RTDBtnRadInfoGeneralModelNumber_A8539 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_120C:
			this.RTDBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1219:
			this.LblRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_123D:
			this.CpyBtnRadInfoLabtoolQ667G193ADPSW_38631 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_124A:
			this.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1257:
			this.CpyBtnRadInfoLabtoolDINCPlusAudio_42670 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1264:
			this.CpyBtnRadInfoGeneralSecureHardwareVersion = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1271:
			this.RadInfoGeneralCodeplugAlias_A7684Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_127E:
			this.RTDBtnRadInfoLabtoolQA07516NYPDTrigger_43587 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_128B:
			this.RTDBtnRadInfoFLASHportFLASHcode_A8132 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1298:
			this.CpyBtnRadInfoGeneralUCMVersion_A9591 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12A5:
			this.LblRadInfoLabtoolCollaborativePhase1_A41683 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolCollaborativePhase1_A41683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12C9:
			this.RadInfoGeneralPrimaryFrequencyBand_A12713Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12D6:
			this.RadInfoGeneralSecureHardwareTypeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12E3:
			this.RadInfoLabtoolFrontDisplayFullKeypad_A23985 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolFrontDisplayFullKeypad_A23985.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1307:
			this.RadInfoTrackingSource1_A9171Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1314:
			this.RadInfoLabtoolLTEOperation_A41923Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1321:
			this.LblRadInfoLabtoolQA01770GA01770EnhancementLev1_38632 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA01770GA01770EnhancementLev1_38632.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1345:
			this.CpyBtnRadInfoLabtoolEncryptedVPNGateway_42279 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1352:
			this.LblRadInfoLabtoolGroupServices_42787 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolGroupServices_42787.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1376:
			this.RadInfoGeneralPSDTVersion_A8768Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1383:
			this.RadInfoLabtoolDualBandEnable_A23986 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolDualBandEnable_A23986.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13A7:
			this.CVBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13B4:
			this.RTDBtnRadInfoLabtoolQ445FiregroundSupport_A8796 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13C1:
			this.CVBtnRadInfoGeneralUCMVersion_A9591 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13CE:
			this.LblRadInfoLabtoolQA02751APXLiRadioTrigger_A41197 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA02751APXLiRadioTrigger_A41197.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13F2:
			this.CVBtnRadInfoLabtoolGPSActivation_A23983 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13FF:
			this.GrpBoxExpanderRadioInformationOptionExpansionBoardPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_140C:
			this.LblRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1430:
			this.RadInfoOptionExpansionBoardBoardName_A37549 = (global::AcpUI.AcpLabel)target;
			this.RadInfoOptionExpansionBoardBoardName_A37549.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1454:
			this.RTDBtnRadInfoLabtoolQ361G361APCOTrunking_A8794 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1461:
			this.RTDBtnRadInfoLabtoolSWAES_A43013 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_146E:
			this.RadInfoLabtoolQA02006APX6000XE_A38951Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_147B:
			this.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = (global::AcpUI.AcpLabel)target;
			this.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_149F:
			this.RadInfoLabtoolGPSActivation_A23983 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolGPSActivation_A23983.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14C3:
			this.CpyBtnRadInfoLabtoolCollaborativePhase1_A41683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14D0:
			this.LblRadInfoLabtoolQ947W947APCOPacketData_8804 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ947W947APCOPacketData_8804.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14F4:
			this.GrpBoxExpanderRadioInformationFLASHportPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1501:
			this.LblRadInfoGeneralPrimaryFrequencyBand900_A42548 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBand900_A42548.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1525:
			this.RTDBtnRadInfoGeneralDSPVersion_A7892 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1532:
			this.LblRadInfoGeneralModelNumber_A8539 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralModelNumber_A8539.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1556:
			this.CVBtnRadInfoGeneralFirmwareVersion_A8124 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1563:
			this.CVBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1570:
			this.RadInfoLabtoolSecondaryBands_A23988 = (global::AcpUI.AcpComboBox)target;
			this.RadInfoLabtoolSecondaryBands_A23988.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1594:
			this.RadInfoLabtoolGA04892_8900MHZ_A44827Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_15A1:
			this.RTDBtnRadInfoLabtoolPrimaryBands_A23987 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15AE:
			this.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15D2:
			this.CpyBtnRadInfoLabtoolH38G51Smartzone_A8185 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15DF:
			this.RTDBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15EC:
			this.HLinkTracking = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTracking.Click += this.HLinkClick;
			return;
			IL_1610:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_161D:
			this.CVBtnRadInfoLabtoolQ445FiregroundSupport_A8796 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_162A:
			this.RadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1637:
			this.CpyBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1644:
			this.LblRadInfoFrequencyRangesAllowInvalidFrequencies_A12493 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesAllowInvalidFrequencies_A12493.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1668:
			this.LblRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_168C:
			this.CVBtnRadInfoGeneralDSPVersion_A7892 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1699:
			this.RadInfoLabtoolH02EncryTacticalInhibit_A41560Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16A6:
			this.CpyBtnRadInfoLabtoolTDMAOperation_A23984 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16B3:
			this.CpyBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16C0:
			this.GrpBoxExpanderRadioInformationDepotKeyInfoPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_16CD:
			this.CVBtnRadInfoLabtoolV24Software_A41828 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16DA:
			this.RadInfoLabtoolBluetooth_A37042 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolBluetooth_A37042.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16FE:
			this.RTDBtnRadInfoLabtoolH869W969Multikey_A8193 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_170B:
			this.RadInfoLabtoolH04ConvTacticalRekey_35710Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1718:
			this.gridExpanderRadioInformationASKProgrammingHistorySRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1725:
			this.LblRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1749:
			this.CpyBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1756:
			this.RadInfoLabtoolFrontDisplayFullKeypad_A23985Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1763:
			this.RTDBtnRadInfoLabtoolLTEOperation_A41923 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1770:
			this.CVBtnRadInfoLabtoolSecondaryBands_A23988 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_177D:
			this.LblRadInfoLabtoolTDMAOperation_A23984 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolTDMAOperation_A23984.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17A1:
			this.RadInfoLabtoolQA00572UHFRange2_A42595Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17AE:
			this.CVBtnRadInfoLabtoolAuthentication_A37609 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17BB:
			this.CVBtnRadInfoLabtoolAstroAlertingOperHOption = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17C8:
			this.RadInfoGeneralSerialNumber_A9122 = (global::AcpUI.AcpTextBox)target;
			this.RadInfoGeneralSerialNumber_A9122.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17EC:
			this.LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1810:
			this.RadInfoLabtool900MHzEnable_A42570 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtool900MHzEnable_A42570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1834:
			this.RadInfoLabtoolQA07516NYPDTrigger_43587Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1841:
			this.RadInfoLabtoolQ387G387ConvVoteScan_A8795 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ387G387ConvVoteScan_A8795.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1865:
			this.RadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1889:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1896:
			this.LblRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18BA:
			this.CVBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18C7:
			this.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18EB:
			this.CpyBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18F8:
			this.RadInfoLabtoolNumOfSysEnhBytes_A22749 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolNumOfSysEnhBytes_A22749.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_191C:
			this.CpyBtnRadInfoGeneralMACAddress_A41837 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1929:
			this.LblRadInfoGeneralPrimaryFrequencyBandUHF1_A42546 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBandUHF1_A42546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_194D:
			this.LblRadInfoGeneralFirmwareVersion_A8124 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralFirmwareVersion_A8124.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1971:
			this.RTDBtnRadInfoLabtoolQA00572UHFRange2_A42595 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_197E:
			this.CVBtnRadInfoLabtoolRSIData_42491 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_198B:
			this.CpyBtnRadInfoLabtoolGA04892_8900MHZ_A44827 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1998:
			this.RadInfoLabtoolExtendedDispatch_A38638 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolExtendedDispatch_A38638.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19BC:
			this.RTDBtnRadInfoLabtoolThirdPartyModemTethering_A43043 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19C9:
			this.CpyBtnRadInfoFLASHportIButton_A8217 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19D6:
			this.RTDBtnRadInfoLabtoolG138MotorcycleRadio_A24684 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19E3:
			this.CVBtnRadInfoLabtoolEncryptedVPNGateway_42279 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19F0:
			this.RTDBtnRadInfoLabtoolProductModelIdentifier_A37178 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19FD:
			this.CpyBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A0A:
			this.RTDBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A17:
			this.LblRadInfoLabtool900MHzEnable_A42570 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtool900MHzEnable_A42570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A3B:
			this.CVBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED_VALUE = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A48:
			this.CVBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A55:
			this.LblRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A79:
			this.RTDBtnRadInfoLabtoolFPPStatus_A8144 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A86:
			this.LblRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED_VALUE = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED_VALUE.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AAA:
			this.CpyBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AB7:
			this.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1AC4:
			this.CVBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AD1:
			this.RadInfoGeneralDSPVersion_A7892 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralDSPVersion_A7892.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AF5:
			this.CVBtnRadInfoLabtoolQ806IMBE_A8191 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B02:
			this.CVBtnRadInfoLabtoolNightVisionGoggle_43542 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B0F:
			this.CpyBtnRadInfoGeneralElectronicSerialNumber_A41744 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B1C:
			this.RadInfoGeneralUCMVersion_A9591Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B29:
			this.RadInfoLabtoolLastProgrammedDateDBValue_A8411 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolLastProgrammedDateDBValue_A8411.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B4D:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBand800_A42544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B5A:
			this.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B67:
			this.LblRadInfoGeneralSecondaryFrequencyBand_A12715 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralSecondaryFrequencyBand_A12715.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B8B:
			this.RTDBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B98:
			this.RadInfoLabtool00982SiteSelAlertForP25_42052Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BA5:
			this.CpyBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BB2:
			this.RTDBtnRadInfoLabtoolTDMAOperation_A23984 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BBF:
			this.LblRadInfoLabtoolSecurePartitionVersionNumber_A9076 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolSecurePartitionVersionNumber_A9076.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BE3:
			this.LblRadInfoGeneralPSDTVersion_A8768 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPSDTVersion_A8768.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C07:
			this.RTDBtnRadInfoLabtoolMissionCriticalGeofencing_A43013 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C14:
			this.CVBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C21:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBand900_A42548 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C2E:
			this.CpyBtnRadInfoLabtoolLTEOperation_A41923 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C3B:
			this.CVBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C48:
			this.RadInfoLabtoolQ947W947APCOPacketData_8804Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C55:
			this.CpyBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C62:
			this.RadioInfoLabtoolExtremeNoiseReduction_A37723Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C6F:
			this.CVBtnRadInfoLabtoolQ173G173Omnilink_A8788 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C7C:
			this.RTDBtnRadInfoFLASHportLastUpgradeSource_A8387 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C89:
			this.RadInfoLabtoolV24Software_A41828Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C96:
			this.RadInfoGeneralBootloaderVersion_A7567 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralBootloaderVersion_A7567.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CBA:
			this.CVBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CC7:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_1CEB:
			this.CVBtnRadInfoLabtoolAtakHOption_HA00680 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CF8:
			this.LblRadInfoGeneralPrimaryFrequencyBandUHF2_A42547 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBandUHF2_A42547.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D1C:
			this.RadioInfoLabToolQA00631DvrsPsuActivation_A40166Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D29:
			this.RTDBtnRadInfoLabtoolQ806IMBE_A8191 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D36:
			this.EnhancedDataOperation_42024Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D43:
			this.RadInfoLabtoolQA08676_AdaptiveSpeakerVolume = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA08676_AdaptiveSpeakerVolume.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D67:
			this.CpyBtnRadInfoGeneralCodeplugVersion_A7683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D74:
			this.RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D98:
			this.CpyBtnRadInfoLabtoolDualBandEnable_A23986 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DA5:
			this.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1DB2:
			this.RTDBtnRadInfoLabtoolSecondaryBands_A23988 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DBF:
			this.CpyBtnRadInfoGeneralFirmwareVersion_A8124 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DCC:
			this.LblRadInfoGeneralTuningVersion_A9509 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralTuningVersion_A9509.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DF0:
			this.RadioInfoLabtoolExtremeNoiseReduction_A37723 = (global::AcpUI.AcpLabel)target;
			this.RadioInfoLabtoolExtremeNoiseReduction_A37723.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E14:
			this.CpyBtnRadInfoTrackingSource2_A8625 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E21:
			this.RadInfoLabtoolW12Preamp_A9671Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E2E:
			this.RadInfoLabtoolTacticalServicesHOption = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolTacticalServicesHOption.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E52:
			this.RTDBtnRadInfoGeneralWiFiMACAddress_42509 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E5F:
			this.RadInfoLabtoolCloningInProgress_A7672 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoLabtoolCloningInProgress_A7672.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E83:
			this.CVBtnRadInfoLabtoolQ667G193ADPSW_38631 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E90:
			this.CVBtnRadInfoLabtoolG138MotorcycleRadio_A24684 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E9D:
			this.RadInfoLabtoolG138MotorcycleRadio_A24684 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolG138MotorcycleRadio_A24684.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EC1:
			this.LblRadInfoLabtoolRSIData_42491 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolRSIData_42491.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EE5:
			this.RadInfoLabtoolPID = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolPID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F09:
			this.RadInfoLabtoolAtakHOption_HA00680 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoLabtoolAtakHOption_HA00680.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F2D:
			this.CVBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F3A:
			this.RTDBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F47:
			this.RadInfoLabtoolRSIData_42491Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F54:
			this.LblRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F78:
			this.RadInfoLabtoolP25CommonAirInterface_A42122 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolP25CommonAirInterface_A42122.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F9C:
			this.CpyBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FA9:
			this.RTDBtnRadInfoGeneralDisplayCodeplugAlias_43580 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FB6:
			this.CpyBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FC3:
			this.CVBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FD0:
			this.RadInfoGeneralFirmwareVersion_A8124 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralFirmwareVersion_A8124.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1FF4:
			this.RadInfoLabtoolQA00570VHF_A37151 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA00570VHF_A37151.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2018:
			this.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_203C:
			this.CpyBtnRadInfoLabtoolV24Software_A41828 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2049:
			this.RTDBtnRadInfoLabtoolV24Software_A41828 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2056:
			this.CVBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2063:
			this.RadInfoGeneralMaximumChannels_A11479 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralMaximumChannels_A11479.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2087:
			this.CpyBtnRadInfoLabtoolAPX1500EHNO3CH_A44832 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2094:
			this.RTDBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20A1:
			this.RadInfoLabtoolQA01770GA01770EnhancementLev1_38632Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_20AE:
			this.CVBtnRadInfoGeneralSecureHardwareType = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20BB:
			this.RadInfoLabtoolZoneCloningStatus_A9721Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_20C8:
			this.CVBtnRadInfoOptionExpansionBoardBoardName_A37549 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20D5:
			this.CVBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20E2:
			this.RadInfoLabtoolG966OTAP_A22740 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolG966OTAP_A22740.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2106:
			this.RTDBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2113:
			this.CVBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2120:
			this.RadInfoLabtoolQ507G507FCCMANDATE_A38198Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_212D:
			this.RadInfoLabtoolQ667G193ADPSW_38631 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ667G193ADPSW_38631.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2151:
			this.CVBtnRadInfoGeneralSerialNumber_A9122 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_215E:
			this.RadInfoLabtoolExtendedDispatch_A38638Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_216B:
			this.RTDBtnRadInfoLabtoolH38G51Smartzone_A8185 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2178:
			this.LblRadInfoFrequencyRangesExtendedUHFR1Capable_A41443 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesExtendedUHFR1Capable_A41443.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_219C:
			this.CVBtnEnhancedDataOperation_42024 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21A9:
			this.LblRadInfoLabtoolExtendedDispatch_A38638 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolExtendedDispatch_A38638.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21CD:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21DA:
			this.RadInfoDepotKeySerialNumber_42793Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21E7:
			this.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_220B:
			this.RadInfoLabtoolQ361G361APCOTrunking_A8794Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2218:
			this.CVBtnRadInfoLabtoolLTEOperation_A41923 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2225:
			this.RadInfoLabtoolQA08676_AdaptiveSpeakerVolumeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2232:
			this.CpyBtnRadInfoLabtoolQA00571UHFRange1_A42594 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_223F:
			this.RTDBtnRadInfoLabtoolDualRadioOperation_A42245 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_224C:
			this.RTDBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2259:
			this.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_227D:
			this.RadInfoLabtoolQA01648ASKEnable_A37150 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA01648ASKEnable_A37150.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22A1:
			this.LblRadInfoLabtoolG138MotorcycleRadio_A24684 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolG138MotorcycleRadio_A24684.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22C5:
			this.RadInfoLabtoolLastProgrammedDateDBValue_A8411Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22D2:
			this.ExpanderRadioInformationASKProgrammingHistoryTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_22DF:
			this.CpyBtnRadInfoLabtoolLTEHWEnablement_QA08887 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22EC:
			this.CpyBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22F9:
			this.RadInfoLabtoolQ806IMBE_A8191Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2306:
			this.RTDBtnRadInfoGeneralWiFiRegulatoryRegion_A43772 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2313:
			this.LblRadInfoGeneralMaximumChannels_A11479 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralMaximumChannels_A11479.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2337:
			this.RadInfoLabtoolH02EncryTacticalInhibit_A41560 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH02EncryTacticalInhibit_A41560.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_235B:
			this.RadInfoLabtoolQ445FiregroundSupport_A8796 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ445FiregroundSupport_A8796.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_237F:
			this.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_238C:
			this.LblRadInfoLabtoolSmartConnect_43719 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolSmartConnect_43719.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23B0:
			this.RTDBtnRadInfoFrequencyRangesExtendRange762Capable_A43555 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23BD:
			this.LblRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23E1:
			this.LblRadInfoLabtoolQ387G387ConvVoteScan_A8795 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ387G387ConvVoteScan_A8795.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2405:
			this.RadInfoLabtoolGA04892_8900MHZ_A44827 = (global::AcpUI.AcpComboBox)target;
			this.RadInfoLabtoolGA04892_8900MHZ_A44827.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2429:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = (global::AcpUI.AcpLabel)target;
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_244D:
			this.LblRadInfoDepotKeySerialNumber_42793 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoDepotKeySerialNumber_42793.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2471:
			this.LblRadInfoLabtoolV24Software_A41828 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolV24Software_A41828.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2495:
			this.CVBtnRadInfoLabtoolGA04892_8900MHZ_A44827 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24A2:
			this.CVBtnRadInfoFrequencyRangesExtendRange762Capable_A43555 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24AF:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24BC:
			this.LblRadInfoFLASHportLastUpgradeSource_A8387 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFLASHportLastUpgradeSource_A8387.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_24E0:
			this.LblRadioInfoLabtoolExtremeNoiseReduction_A37723 = (global::AcpUI.AcpLabel)target;
			this.LblRadioInfoLabtoolExtremeNoiseReduction_A37723.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2504:
			this.CpyBtnRadInfoGeneralSecureHardwareType = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2511:
			this.RadInfoLabtoolAuthentication_A37609 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolAuthentication_A37609.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2535:
			this.LblRadInfoLabtoolQA02006APX6000XE_A38951 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA02006APX6000XE_A38951.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2559:
			this.RadInfoLabtoolQ387G387ConvVoteScan_A8795Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2566:
			this.RTDBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2573:
			this.RadInfoLabtoolQ173G173Omnilink_A8788 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ173G173Omnilink_A8788.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2597:
			this.CVBtnRadInfoLabtoolQA00570VHF_A37151 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25A4:
			this.CVBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25B1:
			this.RadInfoGeneralInstalledTxmCertificateComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25BE:
			this.CVBtnRadInfoLabtoolMissionCriticalGeofencing_A43013 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25CB:
			this.CpyBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25D8:
			this.RTDBtnRadInfoGeneralElectronicSerialNumber_A41744 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25E5:
			this.RadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25F2:
			this.CVBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25FF:
			this.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_260C:
			this.LblRadInfoGeneralDisplayCodeplugAlias_43580 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralDisplayCodeplugAlias_43580.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2630:
			this.LblRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2654:
			this.RadInfoLabtoolLastFLASHKeyDateStampData_A8388Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2661:
			this.CpyBtnRadInfoGeneralCodeplugAlias_A7684 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_266E:
			this.RadInfoLabtoolAtakHOption_HA00680Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_267B:
			this.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2688:
			this.CVBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2695:
			this.RadInfoGeneralModelNumber_A8539Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26A2:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBand700_A42543 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26AF:
			this.RTDBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26BC:
			this.CpyBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26C9:
			this.CVBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26D6:
			this.RadInfoLabtoolQ173G173Omnilink_A8788Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26E3:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBand_A12713 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26F0:
			this.CpyBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26FD:
			this.CVBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_270A:
			this.RadInfoGeneralBootloaderVersion_A7567Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2717:
			this.CVBtnRadInfoLabtoolProductModelIdentifier_A37178 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2724:
			this.RadInfoLabtoolFPPNonFEDVersion_A8143Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2731:
			this.RadInfoLabtoolAstroAlertingOperHOption = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolAstroAlertingOperHOption.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2755:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_2762:
			this.RadInfoGeneralWiFiMACAddress_42509 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralWiFiMACAddress_42509.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2786:
			this.CVBtnRadInfoLabtoolQA01749LegacySWEnable_A37151 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2793:
			this.ExpanderRadioInformationASKProgrammingHistory = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_27A0:
			this.CpyBtnRadInfoFLASHportNumberofTimesFlashed_A8581 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27AD:
			this.CVBtnRadInfoLabtoolUUID_42562 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27BA:
			this.RTDBtnEnhancedDataOperation_42024 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27C7:
			this.LblRadioInfoLabToolGA00631DvrsMsuOperation_A41827 = (global::AcpUI.AcpLabel)target;
			this.LblRadioInfoLabToolGA00631DvrsMsuOperation_A41827.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27EB:
			this.RTDBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27F8:
			this.LblRadInfoLabtoolQA09028ViQi_VoiceControl = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA09028ViQi_VoiceControl.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_281C:
			this.RTDBtnRadInfoLabtoolH37G50Smartnet_A8184 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2829:
			this.CVBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2836:
			this.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2843:
			this.CpyBtnRadInfoLabtoolProductModelIdentifier_A37178 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2850:
			this.CVBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_285D:
			this.RTDBtnRadInfoDepotKeySerialNumber_42793 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_286A:
			this.CVBtnRadInfoGeneralElectronicSerialNumber_A41744 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2877:
			this.ExpanderRadioInformationAdvancedSystemKeyInfo = (global::AcpUI.AcpExpander)target;
			return;
			IL_2884:
			this.CpyBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2891:
			this.CpyBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_289E:
			this.RadInfoLabtoolLTEOperation_A41923 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolLTEOperation_A41923.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28C2:
			this.CpyBtnRadInfoLabtool900MHzEnable_A42570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28CF:
			this.RTDBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28DC:
			this.RadInfoFLASHportLastUpgradeSource_A8387 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFLASHportLastUpgradeSource_A8387.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2900:
			this.CpyBtnRadInfoLabtoolFPPStatus_A8144 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_290D:
			this.CVBtnRadInfoGeneralTuningVersion_A9509 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_291A:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBand800_A42544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2927:
			this.RadInfoLabtoolOriginalSecurePartitionVersion_A8626Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2934:
			this.GrpBoxExpanderRadioInformationFrequencyRangesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2941:
			this.RadInfoLabtoolMCHFamilyDifferntiator_A8482Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_294E:
			this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioInformationASKProgrammingHistory.ModeClick += this.OnModeClick;
			return;
			IL_2972:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBand700_A42543 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_297F:
			this.RadInfoLabtoolMissionCriticalGeofencing_A43013Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_298C:
			this.RadInfoLabtoolUUID_42562 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolUUID_42562.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29B0:
			this.LblRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29D4:
			this.RTDBtnRadInfoLabtoolQA09028ViQi_VoiceControl = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29E1:
			this.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_29EE:
			this.CpyBtnRadInfoLabtoolTacticalServicesHOption = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29FB:
			this.RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A08:
			this.RadInfoGeneralWiFiMACAddress_42509Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A15:
			this.RadInfoLabtoolQA09028ViQi_VoiceControl = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA09028ViQi_VoiceControl.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A39:
			this.CVBtnRadInfoLabtoolQA00571UHFRange1_A42594 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A46:
			this.RadInfoLabtoolMCHFamilyDifferntiator_A8482 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolMCHFamilyDifferntiator_A8482.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A6A:
			this.CpyBtnRadInfoGeneralWiFiRegulatoryRegion_A43772 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A77:
			this.LblRadInfoLabtoolP25CommonAirInterface_A42122 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolP25CommonAirInterface_A42122.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A9B:
			this.RadInfoGeneralRegionalGovernance_A36710Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AA8:
			this.CpyBtnRadInfoLabtoolDualRadioOperation_A42245 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AB5:
			this.CpyBtnRadInfoLabtoolW12Preamp_A9671 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AC2:
			this.CVBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2ACF:
			this.RadInfoLabtoolQA01749LegacySWEnable_A37151Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2ADC:
			this.CVBtnRadInfoFLASHportFLASHcode_A8132 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AE9:
			this.LblRadioInfoLabToolGermanFedGovEnabled_43792 = (global::AcpUI.AcpLabel)target;
			this.LblRadioInfoLabToolGermanFedGovEnabled_43792.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B0D:
			this.RTDBtnRadInfoLabtoolBluetooth_A37042 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B1A:
			this.RadInfoLabtoolQA00571UHFRange1_A42594 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA00571UHFRange1_A42594.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B3E:
			this.RadInfoGeneralDisplayCodeplugAlias_43580 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoGeneralDisplayCodeplugAlias_43580.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B62:
			this.RTDBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B6F:
			this.RadInfoLabtoolQ507G507FCCMANDATE_A38198 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ507G507FCCMANDATE_A38198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B93:
			this.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BB7:
			this.CpyBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BC4:
			this.RadInfoGeneralPrimaryFrequencyBandVHF_A42545 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BE8:
			this.RadInfoLabtoolEncryptedVPNGateway_42279 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolEncryptedVPNGateway_42279.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C0C:
			this.CVBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C19:
			this.RTDBtnRadInfoLabtoolQA02006APX6000XE_A38951 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C26:
			this.LblRadInfoLabtoolSWAES_A43013 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolSWAES_A43013.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C4A:
			this.LblRadInfoLabtoolH46G683OneTouchStatusMsg_37658 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH46G683OneTouchStatusMsg_37658.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C6E:
			this.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C7B:
			this.CVBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C88:
			this.CpyBtnRadInfoLabtoolPrimaryBands_A23987 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C95:
			this.RadInfoLabtoolPrimaryBands_A23987 = (global::AcpUI.AcpComboBox)target;
			this.RadInfoLabtoolPrimaryBands_A23987.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CB9:
			this.EnhancedDataOperation_42024 = (global::AcpUI.AcpLabel)target;
			this.EnhancedDataOperation_42024.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CDD:
			this.CVBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2CEA:
			this.LblRadInfoGeneralElectronicSerialNumber_A41744 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralElectronicSerialNumber_A41744.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D0E:
			this.CpyBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D1B:
			this.RTDBtnRadInfoTrackingSource1_A9171 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D28:
			this.CpyBtnRadInfoLabtoolAtakHOption_HA00680 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D35:
			this.CpyBtnRadInfoGeneralTuningVersion_A9509 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D42:
			this.LblRadInfoGeneralPrimaryFrequencyBand_A12713 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBand_A12713.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D66:
			this.CpyBtnRadInfoGeneralNautilusVersion_A8564 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D73:
			this.LblRadInfoLabtoolH37G50Smartnet_A8184 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH37G50Smartnet_A8184.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D97:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = (global::AcpUI.AcpLabel)target;
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2DBB:
			this.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2DC8:
			this.LblRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DEC:
			this.LblRadInfoGeneralWiFiRegulatoryRegion_A43772 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralWiFiRegulatoryRegion_A43772.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E10:
			this.CVBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E1D:
			this.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E41:
			this.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2E4E:
			this.CpyBtnRadInfoLabtoolQA02006APX6000XE_A38951 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E5B:
			this.RadInfoTrackingSource2_A8625 = (global::AcpUI.AcpLabel)target;
			this.RadInfoTrackingSource2_A8625.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E7F:
			this.RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E8C:
			this.RadInfoLabtoolAPX1500EHNO3CH_A44832 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolAPX1500EHNO3CH_A44832.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EB0:
			this.LblRadInfoFLASHportFLASHcode_A8132 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFLASHportFLASHcode_A8132.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2ED4:
			this.RTDBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EE1:
			this.CVBtnRadInfoGeneralWiFiRegulatoryRegion_A43772 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EEE:
			this.RadInfoLabtoolH46G683OneTouchStatusMsg_37658Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2EFB:
			this.RadInfoFLASHportFLASHcode_A8132Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F08:
			this.RadInfoLabtoolQA00572UHFRange2_A42595 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA00572UHFRange2_A42595.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F2C:
			this.CpyBtnRadInfoGeneralPSDTVersion_A8768 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F39:
			this.RadInfoLabtoolH04ConvTacticalRekey_35710 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH04ConvTacticalRekey_35710.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F5D:
			this.RadInfoLabtoolSecurePartitionVersionNumber_A9076Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F6A:
			this.ExpanderRadioInformationLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_2F77:
			this.LblRadInfoLabtoolLTEOperation_A41923 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolLTEOperation_A41923.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F9B:
			this.LblRadInfoGeneralBootloaderVersion_A7567 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralBootloaderVersion_A7567.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2FBF:
			this.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FE3:
			this.LblRadInfoLabtoolQ445FiregroundSupport_A8796 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ445FiregroundSupport_A8796.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3007:
			this.RTDBtnRadInfoGeneralWiFiBTMACAddress_42510 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3014:
			this.LblRadInfoGeneralNautilusVersion_A8564 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralNautilusVersion_A8564.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3038:
			this.RadInfoLabtoolFPPStatus_A8144 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoLabtoolFPPStatus_A8144.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_305C:
			this.CpyBtnRadInfoLabtoolCloningInProgress_A7672 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3069:
			this.CpyBtnRadInfoLabtoolSecondaryBands_A23988 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3076:
			this.RadInfoLabtoolGroupServices_42787 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolGroupServices_42787.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_309A:
			this.LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30BE:
			this.RTDBtnRadInfoLabtoolExtendedDispatch_A38638 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30CB:
			this.RadInfoLabtoolMotoVMLDataModemTethering_A42852 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolMotoVMLDataModemTethering_A42852.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30EF:
			this.CVBtnRadInfoLabtoolTDMAOperation_A23984 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30FC:
			this.CVBtnRadInfoLabtoolManDown_A40006 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3109:
			this.CVBtnRadInfoFLASHportLastUpgradeSource_A8387 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3116:
			this.RadInfoGeneralInstalledTxmCertificate = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralInstalledTxmCertificate.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_313A:
			this.RTDBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3147:
			this.RadInfoLabtoolQ947W947APCOPacketData_8804 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ947W947APCOPacketData_8804.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_316B:
			this.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3178:
			this.CpyBtnRadInfoLabtoolSmartConnect_43719 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3185:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3192:
			this.RadInfoLabtoolManDown_A40006 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolManDown_A40006.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31B6:
			this.CVBtnRadInfoLabtool900MHzEnable_A42570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31C3:
			this.RTDBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31D0:
			this.RadInfoGeneralPrimaryFrequencyBand900_A42548Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31DD:
			this.RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3201:
			this.LblRadInfoLabtoolAstroAlertingOperHOption = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolAstroAlertingOperHOption.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3225:
			this.CVBtnRadInfoLabtoolAPX1500EHNO3CH_A44832 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3232:
			this.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_323F:
			this.RTDBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_324C:
			this.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3270:
			this.LblRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3294:
			this.CpyBtnRadInfoGeneralWiFiBTMACAddress_42510 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32A1:
			this.RadInfoLabtoolH38G51Smartzone_A8185 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH38G51Smartzone_A8185.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32C5:
			this.RadInfoGeneralTuningVersion_A9509 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralTuningVersion_A9509.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32E9:
			this.RTDBtnRadInfoLabtoolQA01648ASKEnable_A37150 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32F6:
			this.CpyBtnRadInfoLabtoolQA01749LegacySWEnable_A37151 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3303:
			this.RadInfoLabtoolPrimaryBands_A23987Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3310:
			this.CpyBtnRadInfoGeneralSecondaryFrequencyBand_A12715 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_331D:
			this.LblRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3341:
			this.RTDBtnRadInfoLabtoolTacticalServicesHOption = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_334E:
			this.LblRadInfoLabtoolDualBandEnable_A23986 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolDualBandEnable_A23986.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3372:
			this.RadInfoGeneralElectronicSerialNumber_A41744Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_337F:
			this.LblRadInfoLabtoolQA01771GA01771EnhancementLev2_37660 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA01771GA01771EnhancementLev2_37660.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33A3:
			this.RadioInfoLabToolGA00631DvrsMsuOperation_A41827 = (global::AcpUI.AcpLabel)target;
			this.RadioInfoLabToolGA00631DvrsMsuOperation_A41827.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_33C7:
			this.RadInfoLabtoolW12Preamp_A9671 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolW12Preamp_A9671.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_33EB:
			this.LblRadInfoLabtoolW12Preamp_A9671 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolW12Preamp_A9671.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_340F:
			this.CVBtnRadInfoLabtoolQA09028ViQi_VoiceControl = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_341C:
			this.LblRadInfoLabtoolLTEHWEnablement_QA08887 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolLTEHWEnablement_QA08887.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3440:
			this.CVBtnRadInfoLabtoolZoneCloningStatus_A9721 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_344D:
			this.CVBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_345A:
			this.RadInfoGeneralFirmwareVersion_A8124Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3467:
			this.RadInfoGeneralPrimaryFrequencyBand800_A42544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3474:
			this.CpyBtnRadInfoLabtoolNumOfSysEnhBytes_A22749 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3481:
			this.LblRadInfoLabtoolH04ConvTacticalRekey_35710 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH04ConvTacticalRekey_35710.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_34A5:
			this.CVBtnRadInfoLabtoolG966OTAP_A22740 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34B2:
			this.CVBtnRadInfoFrequencyRangesOpenFrequency_A22699 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34BF:
			this.CVBtnRadInfoLabtoolLTEHWEnablement_QA08887 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34CC:
			this.CVBtnRadInfoLabtoolSmartConnect_43719 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34D9:
			this.ExpanderRadioInformationDepotKeyInfo = (global::AcpUI.AcpExpander)target;
			return;
			IL_34E6:
			this.CVBtnRadInfoLabtoolDualBandEnable_A23986 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34F3:
			this.RTDBtnRadInfoLabtoolG966OTAP_A22740 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3500:
			this.RadInfoDepotKeySerialNumber_42793 = (global::AcpUI.AcpLabel)target;
			this.RadInfoDepotKeySerialNumber_42793.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3524:
			this.RTDBtnRadInfoLabtoolGroupServices_42787 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3531:
			this.CpyBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_353E:
			this.LblRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3562:
			this.RTDBtnRadInfoLabtoolRSIData_42491 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_356F:
			this.RadInfoGeneralPrimaryFrequencyBandVHF_A42545Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_357C:
			this.CpyBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3589:
			this.RadInfoLabtoolQA01768EnhancedZoneBank_A37209 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA01768EnhancedZoneBank_A37209.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35AD:
			this.CVBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_35BA:
			this.RadInfoGeneralWiFiRegulatoryRegion_A43772Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35C7:
			this.CpyBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35D4:
			this.CpyBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35E1:
			this.CpyBtnRadInfoLabtoolPID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35EE:
			this.CpyBtnRadInfoLabtoolQ806IMBE_A8191 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35FB:
			this.LblRadInfoLabtoolQA01768EnhancedZoneBank_A37209 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA01768EnhancedZoneBank_A37209.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_361F:
			this.LblRadInfoLabtoolProductModelIdentifier_A37178 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolProductModelIdentifier_A37178.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3643:
			this.RadInfoLabtoolDualRadioOperation_A42245Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3650:
			this.RTDBtnRadInfoLabtoolQ947W947APCOPacketData_8804 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_365D:
			this.RTDBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_366A:
			this.RTDBtnRadInfoLabtoolDINCPlusAudio_42670 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3677:
			this.RadInfoLabtoolLTEHWEnablement_QA08887 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolLTEHWEnablement_QA08887.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_369B:
			this.RTDBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36A8:
			this.CVBtnRadInfoLabtoolW12Preamp_A9671 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36B5:
			this.GrpBoxExpanderRadioInformationTrackingLastProgrammedInformation = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_36C2:
			this.CVBtnRadInfoLabtoolQA00569_7800MHZ_A42596 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36CF:
			this.LblRadInfoLabtoolQA01749LegacySWEnable_A37151 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA01749LegacySWEnable_A37151.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36F3:
			this.RadInfoLabtoolRSIData_42491 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolRSIData_42491.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3717:
			this.RTDBtnRadInfoLabtoolH04ConvTacticalRekey_35710 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3724:
			this.ExpanderRadioInformationAdvancedSystemKeyInfoGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3731:
			this.RTDBtnRadInfoLabtoolQA00570VHF_A37151 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_373E:
			this.CpyBtnRadInfoLabtoolBluetooth_A37042 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_374B:
			this.CVBtnRadInfoLabtoolWiFiCapability_42549 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3758:
			this.CpyBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3765:
			this.CpyBtnRadInfoLabtoolH869W969Multikey_A8193 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3772:
			this.CpyBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_377F:
			this.RTDBtnRadInfoGeneralPSDTVersion_A8768 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_378C:
			this.RTDBtnRadInfoLabtoolCollaborativePhase1_A41683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3799:
			this.RadInfoLabtoolQA09028ViQi_VoiceControlComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37A6:
			this.RadInfoLabtoolCollaborativePhase1_A41683Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37B3:
			this.CVBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37C0:
			this.GrpBoxExpanderRadioInformationLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_37CD:
			this.LblRadInfoFrequencyRangesOpenFrequency_A22699 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesOpenFrequency_A22699.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37F1:
			this.RTDBtnRadInfoLabtoolWiFiCapability_42549 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37FE:
			this.RTDBtnRadInfoFLASHportNumberofTimesFlashed_A8581 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_380B:
			this.RTDBtnRadInfoLabtoolQ667G193ADPSW_38631 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3818:
			this.RTDBtnRadInfoLabtoolManDown_A40006 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3825:
			this.RadInfoLabtoolH868W968OtarAndMultikey_A8192Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3832:
			this.CVBtnRadInfoGeneralBootloaderVersion_A7567 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_383F:
			this.RTDBtnRadInfoLabtool00982SiteSelAlertForP25_42052 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_384C:
			this.CpyBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3859:
			this.RadInfoGeneralUCMVersion_A9591 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralUCMVersion_A9591.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_387D:
			this.CVBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_388A:
			this.RadInfoLabtoolPIDComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3897:
			this.CVBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_38A4:
			this.CpyBtnRadInfoLabtoolG966OTAP_A22740 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38B1:
			this.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_38D5:
			this.RadInfoFLASHportIButton_A8217 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFLASHportIButton_A8217.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_38F9:
			this.RadInfoLabtoolAuthentication_A37609Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3906:
			this.RadInfoGeneralPrimaryFrequencyBand700_A42543 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBand700_A42543.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_392A:
			this.CpyBtnRadInfoGeneralDSPVersion_A7892 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3937:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3944:
			this.CpyBtnRadInfoLabtoolAstroAlertingOperHOption = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3951:
			this.CVBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_395E:
			this.RTDBtnRadInfoLabtoolSmartConnectOverBroadband_43720 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_396B:
			this.LblRadInfoLabtoolG966OTAP_A22740 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolG966OTAP_A22740.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_398F:
			this.RTDBtnRadInfoLabtoolFPPNonFEDVersion_A8143 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_399C:
			this.CVBtnRadInfoGeneralDisplayCodeplugAlias_43580 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39A9:
			this.RadInfoOptionExpansionBoardBoardType_A37049Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39B6:
			this.RTDBtnRadInfoGeneralBootloaderVersion_A7567 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_39C3:
			this.RadInfoLabtoolOriginalSecurePartitionVersion_A8626 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolOriginalSecurePartitionVersion_A8626.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39E7:
			this.RTDBtnRadInfoGeneralUCMVersion_A9591 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_39F4:
			this.LblRadInfoLabtoolWiFiCapability_42549 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolWiFiCapability_42549.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A18:
			this.RadInfoLabtoolCollaborativePhase1_A41683 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolCollaborativePhase1_A41683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A3C:
			this.CpyBtnRadInfoLabtoolMissionCriticalGeofencing_A43013 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A49:
			this.CVBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A56:
			this.RadInfoLabtoolBluetooth_A37042Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3A63:
			this.CVBtnRadInfoGeneralWiFiBTMACAddress_42510 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A70:
			this.LblRadInfoFLASHportIButton_A8217 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFLASHportIButton_A8217.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A94:
			this.RadInfoLabtoolG966OTAP_A22740Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AA1:
			this.RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AC5:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBand_A12713 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3AD2:
			this.RadInfoLabtoolFPPNonFEDVersion_A8143 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolFPPNonFEDVersion_A8143.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AF6:
			this.RTDBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3B03:
			this.RadInfoLabtoolSmartConnect_43719 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolSmartConnect_43719.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B27:
			this.CpyBtnRadInfoLabtoolZoneCloningStatus_A9721 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B34:
			this.RadInfoFLASHportFLASHcode_A8132 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFLASHportFLASHcode_A8132.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B58:
			this.RadInfoLabtoolSWAES_A43013Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3B65:
			this.RadInfoLabtoolQA01749LegacySWEnable_A37151 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA01749LegacySWEnable_A37151.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B89:
			this.CpyBtnRadInfoGeneralModelNumber_A8539 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B96:
			this.LblRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BBA:
			this.LblRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Value = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Value.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BDE:
			this.RadInfoGeneralWiFiBTMACAddress_42510 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralWiFiBTMACAddress_42510.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C02:
			this.CVBtnRadInfoLabtoolGroupServices_42787 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C0F:
			this.CVBtnRadInfoLabtoolQA01648ASKEnable_A37150 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C1C:
			this.RTDBtnRadInfoGeneralCodeplugVersion_A7683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C29:
			this.RTDBtnRadInfoLabtoolDualBandEnable_A23986 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C36:
			this.RadInfoLabtoolUUID_42562Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C43:
			this.RadInfoLabtoolMotoVMLDataModemTethering_A42852Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C50:
			this.CpyBtnRadInfoLabtoolP25CommonAirInterface_A42122 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C5D:
			this.RTDBtnRadInfoGeneralRegionalGovernance_A36710 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C6A:
			this.RadInfoLabtoolH46G683OneTouchStatusMsg_37658 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH46G683OneTouchStatusMsg_37658.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C8E:
			this.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C9B:
			this.RadInfoLabtoolTacticalServicesHOptionComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CA8:
			this.CpyBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CB5:
			this.RadInfoGeneralDSPVersion_A7892Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CC2:
			this.RTDBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3CCF:
			this.RadInfoLabtoolDualBandEnable_A23986Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CDC:
			this.RTDBtnRadInfoGeneralMACAddress_A41837 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3CE9:
			this.RadInfoFrequencyRangesOpenFrequency_A22699Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3CF6:
			this.RadInfoLabtoolDualRadioOperation_A42245 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolDualRadioOperation_A42245.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D1A:
			this.RadInfoLabtoolLastFLASHKeyDateStampData_A8388 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolLastFLASHKeyDateStampData_A8388.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D57:
			goto IL_5EC0;
			IL_3D5C:
			this.RTDBtnRadInfoGeneralNautilusVersion_A8564 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D69:
			this.CpyBtnRadInfoGeneralInstalledTxmCertificate = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D76:
			this.RadInfoGeneralWiFiBTMACAddress_42510Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3D83:
			this.CpyBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D90:
			this.RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLEDComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3D9D:
			this.LblRadInfoLabtoolFPPStatus_A8144 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolFPPStatus_A8144.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DC1:
			this.RadInfoLabtoolH869W969Multikey_A8193Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3DCE:
			this.CVBtnRadInfoGeneralNautilusVersion_A8564 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3DDB:
			this.CpyBtnRadInfoLabtoolAuthentication_A37609 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3DE8:
			this.CpyBtnRadInfoOptionExpansionBoardBoardType_A37049 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3DF5:
			this.LblRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E19:
			this.CpyBtnRadInfoFLASHportLastUpgradeSource_A8387 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E26:
			this.CpyBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E33:
			this.LblRadInfoGeneralPrimaryFrequencyBandVHF_A42545 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBandVHF_A42545.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E57:
			this.LblRadInfoLabtoolAPX1500EHNO3CH_A44832 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolAPX1500EHNO3CH_A44832.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E7B:
			this.LblRadInfoGeneralUCMVersion_A9591 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralUCMVersion_A9591.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E9F:
			this.CpyBtnRadioInfoLabtoolExtremeNoiseReduction_A37723 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EAC:
			num = (short)849215489;
			if (num != 0)
			{
			}
			this.RTDBtnRadInfoLabtoolEncryptedVPNGateway_42279 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3EE1:
			this.CpyBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EEE:
			this.RadInfoGeneralNautilusVersion_A8564Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3EFB:
			this.RadInfoLabtoolH37G50Smartnet_A8184 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH37G50Smartnet_A8184.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F1F:
			this.CpyBtnRadInfoFrequencyRangesExtendRange762Capable_A43555 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F2C:
			this.LblRadInfoGeneralInstalledTxmCertificate = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralInstalledTxmCertificate.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F50:
			this.RTDBtnRadInfoLabtoolLTEHWEnablement_QA08887 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F5D:
			this.LblRadInfoLabtoolFPPNonFEDVersion_A8143 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolFPPNonFEDVersion_A8143.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F81:
			this.RadInfoLabtoolGPSActivation_A23983Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F8E:
			this.LblRadInfoLabtoolH02EncryTacticalInhibit_A41560 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH02EncryTacticalInhibit_A41560.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3FB2:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FBF:
			this.CVBtnRadInfoLabtoolBluetooth_A37042 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FCC:
			this.RadInfoLabtoolEncryptedVPNGateway_42279Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3FD9:
			this.ExpanderRadioInformationASKProgrammingHistoryGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3FE6:
			this.LblRadInfoTrackingSource1_A9171 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoTrackingSource1_A9171.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_400A:
			this.LblRadInfoLabtoolQA00570VHF_A37151 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA00570VHF_A37151.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_402E:
			this.CpyBtnRadInfoLabtoolQA07516NYPDTrigger_43587 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_403B:
			this.LblRadInfoLabtoolThirdPartyModemTethering_A43043 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolThirdPartyModemTethering_A43043.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_405F:
			this.CpyBtnRadInfoLabtoolQA00572UHFRange2_A42595 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_406C:
			this.RadInfoLabtoolH869W969Multikey_A8193 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH869W969Multikey_A8193.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4090:
			this.LblRadInfoLabtoolZoneCloningStatus_A9721 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolZoneCloningStatus_A9721.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_40B4:
			this.CpyBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40C1:
			this.RadInfoLabtoolQ806IMBE_A8191 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ806IMBE_A8191.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_40E5:
			this.LblRadInfoFrequencyRangesVHFUsedinCodeplug_A8481 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesVHFUsedinCodeplug_A8481.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4109:
			this.CpyBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4116:
			this.CVBtnRadInfoLabtoolQA02006APX6000XE_A38951 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4123:
			this.LblRadInfoFLASHportNumberofTimesFlashed_A8581 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFLASHportNumberofTimesFlashed_A8581.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4147:
			this.CpyBtnRadInfoLabtoolManDown_A40006 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4154:
			this.CVBtnRadInfoLabtoolH04ConvTacticalRekey_35710 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4161:
			this.RTDBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_416E:
			this.RadInfoGeneralMACAddress_A41837 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralMACAddress_A41837.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4192:
			this.RTDBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_419F:
			this.RadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_41C3:
			this.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_41D0:
			this.LblRadInfoLabtoolQ806IMBE_A8191 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ806IMBE_A8191.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41F4:
			this.LblRadInfoGeneralWiFiMACAddress_42509 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralWiFiMACAddress_42509.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4218:
			this.CpyBtnRadInfoGeneralWiFiMACAddress_42509 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4225:
			this.LblRadInfoLabtoolH869W969Multikey_A8193 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH869W969Multikey_A8193.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4249:
			this.RadInfoLabtoolNightVisionGoggle_43542 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolNightVisionGoggle_43542.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_426D:
			this.HLinkFLASHport = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFLASHport.Click += this.HLinkClick;
			return;
			IL_4291:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_429E:
			this.RTDBtnRadInfoGeneralSecondaryFrequencyBand_A12715 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42AB:
			this.RTDBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42B8:
			this.RTDBtnRadInfoLabtool900MHzEnable_A42570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42C5:
			this.RTDBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42D2:
			this.CpyBtnRadInfoLabtoolQ361G361APCOTrunking_A8794 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42DF:
			this.RadInfoLabtoolSWAES_A43013 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolSWAES_A43013.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4303:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBand800_A42544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4310:
			this.RadInfoGeneralRegionalGovernance_A36710 = (global::AcpUI.AcpComboBox)target;
			this.RadInfoGeneralRegionalGovernance_A36710.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4334:
			this.RTDBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4341:
			this.LblRadInfoLabtoolGA04892_8900MHZ_A44827 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolGA04892_8900MHZ_A44827.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4365:
			num = (short)255983616;
			short num3 = num;
			this.RadInfoTrackingSource1_A9171 = (global::AcpUI.AcpLabel)target;
			this.RadInfoTrackingSource1_A9171.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43B1:
			this.RadInfoFrequencyRangesExtendRange762Capable_A43555Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43BE:
			this.CpyBtnRadInfoLabtoolQA00569_7800MHZ_A42596 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_43CB:
			this.RadInfoTrackingSource2_A8625Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43D8:
			this.RadInfoGeneralPrimaryFrequencyBand800_A42544 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBand800_A42544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43FC:
			this.RTDBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4409:
			this.CpyBtnRadInfoLabtoolThirdPartyModemTethering_A43043 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4416:
			this.CpyBtnRadInfoLabtoolNightVisionGoggle_43542 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4423:
			this.RadInfoLabtoolThirdPartyModemTethering_A43043 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolThirdPartyModemTethering_A43043.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4447:
			this.LblRadInfoLabtoolUUID_42562 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolUUID_42562.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_446B:
			this.CpyBtnRadInfoTrackingCodeplugVersion_A7688 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4478:
			this.RadInfoLabtoolThirdPartyModemTethering_A43043Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4485:
			this.CpyBtnRadInfoLabtool00982SiteSelAlertForP25_42052 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4492:
			this.RadInfoLabtoolQA01771GA01771EnhancementLev2_37660Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_449F:
			this.LblRadInfoLabtoolQ667G193ADPSW_38631 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ667G193ADPSW_38631.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44C3:
			this.CVBtnRadInfoTrackingSource1_A9171 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_44D0:
			this.CVBtnRadInfoLabtoolCloningInProgress_A7672 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_44DD:
			this.CpyBtnRadInfoLabtoolRSIData_42491 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_44EA:
			this.RadInfoGeneralSecondaryFrequencyBand_A12715 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralSecondaryFrequencyBand_A12715.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_450E:
			this.CVBtnRadInfoLabtoolQ361G361APCOTrunking_A8794 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_451B:
			this.RTDBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4528:
			this.RadInfoLabtoolAPX1500EHNO3CH_A44832Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4535:
			this.CVBtnRadInfoLabtoolQA00572UHFRange2_A42595 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4542:
			this.CVBtnRadInfoLabtoolFPPStatus_A8144 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_454F:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_455C:
			this.CpyBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4569:
			this.CpyBtnRadInfoLabtoolGroupServices_42787 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4576:
			this.RTDBtnRadInfoLabtoolUUID_42562 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4583:
			this.RadInfoGeneralMaximumChannels_A11479Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4590:
			this.RTDBtnRadInfoLabtoolW12Preamp_A9671 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_459D:
			this.RadInfoGeneralWiFiRegulatoryRegion_A43772 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralWiFiRegulatoryRegion_A43772.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45C1:
			this.RTDBtnRadInfoLabtoolGPSActivation_A23983 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_45CE:
			this.CVBtnRadInfoGeneralModelNumber_A8539 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_45DB:
			this.LblRadInfoGeneralPrimaryFrequencyBand800_A42544 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBand800_A42544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_45FF:
			this.CVBtnRadInfoLabtoolDINCPlusAudio_42670 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_460C:
			this.RadInfoGeneralDisplayCodeplugAlias_43580Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4619:
			this.RadInfoLabtoolP25CommonAirInterface_A42122Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4626:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBand_A12713 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4633:
			this.RTDBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4640:
			this.LblRadInfoLabtoolMotoVMLDataModemTethering_A42852 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolMotoVMLDataModemTethering_A42852.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4664:
			this.CpyBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4671:
			this.RadInfoLabtoolQA00570VHF_A37151Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_467E:
			this.CVBtnRadInfoGeneralCodeplugAlias_A7684 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_468B:
			this.CVBtnRadInfoGeneralWiFiMACAddress_42509 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4698:
			this.RadInfoLabtoolWiFiCapability_42549 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolWiFiCapability_42549.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_46BC:
			this.RadInfoFLASHportNumberofTimesFlashed_A8581 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFLASHportNumberofTimesFlashed_A8581.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_46E0:
			this.CpyBtnRadInfoLabtoolExtendedDispatch_A38638 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_46ED:
			this.RadInfoLabtoolProductModelIdentifier_A37178 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolProductModelIdentifier_A37178.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4711:
			this.RTDBtnRadInfoLabtoolAuthentication_A37609 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_471E:
			this.RadInfoFrequencyRangesOpenFrequency_A22699 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRangesOpenFrequency_A22699.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4742:
			this.RadInfoLabtoolZoneCloningStatus_A9721 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoLabtoolZoneCloningStatus_A9721.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4766:
			this.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_478A:
			this.HLinkDepotKeyInfo = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDepotKeyInfo.Click += this.HLinkClick;
			return;
			IL_47AE:
			this.RadInfoGeneralSecondaryFrequencyBand_A12715Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_47BB:
			this.CVBtnRadInfoTrackingSource2_A8625 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_47C8:
			this.RadInfoTrackingCodeplugVersion_A7688 = (global::AcpUI.AcpLabel)target;
			this.RadInfoTrackingCodeplugVersion_A7688.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47EC:
			this.CpyBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_47F9:
			this.LblRadInfoLabtoolLastProgrammedDateDBValue_A8411 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolLastProgrammedDateDBValue_A8411.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_481D:
			this.CpyBtnRadInfoLabtoolQA09028ViQi_VoiceControl = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_482A:
			this.RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_484E:
			this.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4872:
			this.LblRadInfoLabtoolPID = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolPID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4896:
			this.RTDBtnRadInfoLabtoolGeoFence_42325 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_48A3:
			this.CVBtnRadInfoDepotKeySerialNumber_42793 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_48B0:
			this.CpyBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_48BD:
			this.RadInfoLabtoolQA01768EnhancedZoneBank_A37209Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_48CA:
			this.CpyBtnRadInfoLabtoolGeoFence_42325 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_48D7:
			this.CVBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_48E4:
			this.RadInfoLabtoolDINCPlusAudio_42670 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolDINCPlusAudio_42670.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4908:
			this.RTDBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4915:
			this.CVBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4922:
			num = (short)1567572870;
			short num4 = num;
			num = (short)1118978950;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5225:
				this.CpyBtnRadInfoLabtoolUUID_42562 = (global::AcpUI.AcpCopyButton)target;
				return;
			default:
				num = (short)1480982528;
				if (num != 0)
				{
				}
				this.CVBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_497A:
			this.LblRadInfoOptionExpansionBoardBoardType_A37049 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoOptionExpansionBoardBoardType_A37049.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_499E:
			this.CpyBtnRadInfoFLASHportFLASHcode_A8132 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49AB:
			this.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49CF:
			this.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49F3:
			this.RadInfoLabtoolProductModelIdentifier_A37178Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A00:
			this.RTDBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A0D:
			this.CpyBtnRadInfoLabtoolFPPNonFEDVersion_A8143 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4A1A:
			this.RadInfoGeneralCodeplugAlias_A7684 = (global::AcpUI.AcpTextBox)target;
			this.RadInfoGeneralCodeplugAlias_A7684.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4A3E:
			this.LblRadInfoLabtoolGeoFence_42325 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolGeoFence_42325.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A62:
			this.CVBtnRadioInfoLabToolGermanFedGovEnabled_43792 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A6F:
			this.CVBtnRadInfoLabtoolBornOnDateDBValue_A7568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A7C:
			this.RadInfoLabtoolQA01770GA01770EnhancementLev1_38632 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA01770GA01770EnhancementLev1_38632.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4AA0:
			this.LblRadInfoGeneralRegionalGovernance_A36710 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralRegionalGovernance_A36710.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4AC4:
			this.LblRadInfoLabtoolEncryptedVPNGateway_42279 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolEncryptedVPNGateway_42279.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4AE8:
			this.CpyBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4AF5:
			this.RadioInfoLabToolGermanFedGovEnabled_43792 = (global::AcpUI.AcpLabel)target;
			this.RadioInfoLabToolGermanFedGovEnabled_43792.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B19:
			this.RadInfoLabtoolMissionCriticalGeofencing_A43013 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolMissionCriticalGeofencing_A43013.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B3D:
			this.RTDBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4B4A:
			this.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B6E:
			this.CVBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B7B:
			this.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B88:
			this.LblRadInfoLabtoolFrontDisplayFullKeypad_A23985 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolFrontDisplayFullKeypad_A23985.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4BAC:
			this.LblRadInfoLabtoolH38G51Smartzone_A8185 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH38G51Smartzone_A8185.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4BD0:
			this.RadInfoFLASHportNumberofTimesFlashed_A8581Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4BDD:
			this.CVBtnRadInfoLabtoolP25CommonAirInterface_A42122 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4BEA:
			this.RadioInfoLabToolQA00631DvrsPsuActivation_A40166 = (global::AcpUI.AcpLabel)target;
			this.RadioInfoLabToolQA00631DvrsPsuActivation_A40166.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C0E:
			this.ExpanderRadioInformationFrequencyRanges = (global::AcpUI.AcpExpander)target;
			return;
			IL_4C1B:
			this.RadInfoGeneralCodeplugVersion_A7683Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C28:
			this.RTDBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4C35:
			this.LblRadInfoLabtoolDINCPlusAudio_42670 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolDINCPlusAudio_42670.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C59:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C66:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.PageRadioInformation)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.PageRadioInformation)target).Unloaded += this.OnUnloaded;
			return;
			IL_4C97:
			this.CpyBtnRadInfoLabtoolSWAES_A43013 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CA4:
			this.RadInfoGeneralSerialNumber_A9122Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4CB1:
			this.RTDBtnRadInfoLabtoolPID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4CBE:
			this.LblRadInfoLabtoolQ507G507FCCMANDATE_A38198 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ507G507FCCMANDATE_A38198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4CE2:
			this.LblRadInfoLabtool00982SiteSelAlertForP25_42052 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtool00982SiteSelAlertForP25_42052.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4D06:
			this.RadInfoLabtoolNumOfSysEnhBytes_A22749Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D13:
			this.LblRadInfoLabtoolLastFLASHKeyDateStampData_A8388 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolLastFLASHKeyDateStampData_A8388.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4D37:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBand900_A42548 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D44:
			this.CVBtnRadInfoLabtoolPrimaryBands_A23987 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D51:
			this.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D5E:
			this.CVBtnRadInfoLabtoolSmartConnectOverBroadband_43720 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D6B:
			this.CpyBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4D78:
			this.CVBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D85:
			this.RadInfoGeneralElectronicSerialNumber_A41744 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralElectronicSerialNumber_A41744.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4DA9:
			this.CpyBtnRadInfoGeneralRegionalGovernance_A36710 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4DB6:
			this.RadInfoLabtoolSmartConnect_43719Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4DC3:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4DD0:
			this.RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4DDD:
			this.CVBtnRadInfoLabtoolCollaborativePhase1_A41683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DEA:
			this.RadInfoLabtoolBornOnDateDBValue_A7568Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4DF7:
			this.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4E04:
			this.RadInfoLabtoolWiFiCapability_42549Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E11:
			this.RadInfoLabtoolBornOnDateDBValue_A7568 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolBornOnDateDBValue_A7568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E35:
			this.CpyBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E42:
			this.RTDBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E4F:
			this.RTDBtnRadInfoGeneralCodeplugAlias_A7684 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E5C:
			this.LblRadInfoLabtoolAtakHOption_HA00680 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolAtakHOption_HA00680.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E80:
			this.CpyBtnRadInfoGeneralBootloaderVersion_A7567 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E8D:
			this.CVBtnRadInfoTrackingCodeplugVersion_A7688 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E9A:
			this.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4EA7:
			this.CpyBtnRadInfoLabtoolQ947W947APCOPacketData_8804 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EB4:
			this.RTDBtnRadInfoLabtoolAtakHOption_HA00680 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4EC1:
			this.RadInfoLabtoolV24Software_A41828 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolV24Software_A41828.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4EE5:
			this.CpyBtnRadInfoTrackingSource1_A9171 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EF2:
			this.CVBtnRadInfoLabtoolSWAES_A43013 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4EFF:
			this.LblRadInfoGeneralMACAddress_A41837 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralMACAddress_A41837.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F23:
			this.LblRadInfoLabtoolMissionCriticalGeofencing_A43013 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolMissionCriticalGeofencing_A43013.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F47:
			this.CVBtnRadInfoLabtoolGeoFence_42325 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4F54:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4F61:
			this.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F6E:
			this.CpyBtnRadInfoFrequencyRangesOpenFrequency_A22699 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4F7B:
			this.CVBtnRadInfoGeneralInstalledTxmCertificate = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4F88:
			this.RTDBtnRadInfoLabtoolSmartConnect_43719 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4F95:
			this.CVBtnRadInfoGeneralSecureHardwareVersion = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4FA2:
			this.LblRadInfoLabtoolQA00571UHFRange1_A42594 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA00571UHFRange1_A42594.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4FC6:
			this.LblRadInfoGeneralSerialNumber_A9122 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralSerialNumber_A9122.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4FEA:
			this.LblRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_500E:
			this.CVBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_501B:
			this.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_503F:
			this.GrpBoxExpanderRadioInformationFrequencyRangesPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_504C:
			this.RTDBtnRadInfoGeneralSerialNumber_A9122 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5059:
			this.RadInfoLabtoolH868W968OtarAndMultikey_A8192 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH868W968OtarAndMultikey_A8192.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_507D:
			this.RadInfoGeneralModelNumber_A8539 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralModelNumber_A8539.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_50A1:
			this.RadInfoLabtoolGeoFence_42325Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_50AE:
			this.RadInfoLabtoolQA00571UHFRange1_A42594Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_50BB:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_50DF:
			this.RTDBtnRadInfoLabtoolP25CommonAirInterface_A42122 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_50EC:
			this.LblRadInfoGeneralCodeplugVersion_A7683 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralCodeplugVersion_A7683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5110:
			this.CpyBtnRadInfoLabtoolSmartConnectOverBroadband_43720 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_511D:
			this.RadioInfoLabToolGA00631DvrsMsuOperation_A41827Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_512A:
			this.CVBtnRadInfoLabtoolH38G51Smartzone_A8185 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5137:
			this.RadInfoGeneralPrimaryFrequencyBand_A12713 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBand_A12713.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_515B:
			this.CVBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5168:
			this.RadInfoGeneralPSDTVersion_A8768 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPSDTVersion_A8768.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_518C:
			this.RTDBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5199:
			this.CVBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_51A6:
			this.CpyBtnRadInfoLabtoolQA01648ASKEnable_A37150 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51B3:
			this.LblRadInfoLabtoolOriginalSecurePartitionVersion_A8626 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolOriginalSecurePartitionVersion_A8626.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51D7:
			this.RadInfoGeneralSecureHardwareVersionComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_51E4:
			this.CVBtnRadInfoGeneralMACAddress_A41837 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_51F1:
			this.RadInfoGeneralMACAddress_A41837Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_51FE:
			this.RadInfoFLASHportLastUpgradeSource_A8387Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_520B:
			this.CpyBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5218:
			this.CpyBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5232:
			this.CVBtnRadInfoGeneralSecondaryFrequencyBand_A12715 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_523F:
			this.CVBtnRadInfoLabtoolQA07516NYPDTrigger_43587 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_524C:
			this.LblRadInfoGeneralWiFiBTMACAddress_42510 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralWiFiBTMACAddress_42510.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5270:
			this.LblRadInfoGeneralSecureHardwareType = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralSecureHardwareType.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5294:
			this.LblRadInfoLabtoolSecondaryBands_A23988 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolSecondaryBands_A23988.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_52B8:
			this.RadInfoLabtoolCloningInProgress_A7672Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_52C5:
			this.ExpanderRadioInformationFLASHport = (global::AcpUI.AcpExpander)target;
			return;
			IL_52D2:
			this.LblRadInfoLabtoolQA01648ASKEnable_A37150 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA01648ASKEnable_A37150.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_52F6:
			this.RadInfoLabtoolGroupServices_42787Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5303:
			this.LblRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5327:
			this.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_534B:
			this.RTDBtnRadioInfoLabToolGermanFedGovEnabled_43792 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5358:
			this.RadInfoLabtoolSmartConnectOverBroadband_43720 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolSmartConnectOverBroadband_43720.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_537C:
			this.RTDBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5389:
			this.RTDBtnRadInfoLabtoolAstroAlertingOperHOption = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5396:
			this.RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_53A3:
			this.CVBtnRadioInfoLabtoolExtremeNoiseReduction_A37723 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_53B0:
			this.RadInfoLabtoolAstroAlertingOperHOptionComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_53BD:
			this.GrpBoxExpanderRadioInformationFrequencyRangesCodeplugFrequencies = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_53CA:
			this.RadInfoLabtoolGeoFence_42325 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolGeoFence_42325.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_53EE:
			this.LblRadInfoTrackingCodeplugVersion_A7688 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoTrackingCodeplugVersion_A7688.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5412:
			this.CpyBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_541F:
			this.RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_542C:
			this.CpyBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5439:
			this.RTDBtnRadInfoLabtoolQA00571UHFRange1_A42594 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5446:
			this.RTDBtnRadInfoLabtoolZoneCloningStatus_A9721 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5453:
			this.CVBtnRadInfoGeneralRegionalGovernance_A36710 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5460:
			this.CVBtnRadInfoLabtoolH869W969Multikey_A8193 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_546D:
			this.RTDBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_547A:
			this.RadInfoFrequencyRangesExtendRange762Capable_A43555 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFrequencyRangesExtendRange762Capable_A43555.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_549E:
			this.RadInfoLabtoolQ667G193ADPSW_38631Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_54AB:
			this.RTDBtnRadInfoLabtoolQA00569_7800MHZ_A42596 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_54B8:
			this.LblRadInfoLabtoolMCHFamilyDifferntiator_A8482 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolMCHFamilyDifferntiator_A8482.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_54DC:
			this.RadInfoLabtoolQA07516NYPDTrigger_43587 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA07516NYPDTrigger_43587.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5500:
			this.LblRadInfoLabtoolQ173G173Omnilink_A8788 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ173G173Omnilink_A8788.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5524:
			this.LblRadInfoGeneralPrimaryFrequencyBand700_A42543 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralPrimaryFrequencyBand700_A42543.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5548:
			this.RTDBtnRadioInfoLabtoolExtremeNoiseReduction_A37723 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5555:
			this.LblRadInfoLabtoolTacticalServicesHOption = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolTacticalServicesHOption.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5579:
			this.RTDBtnRadInfoTrackingSource2_A8625 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5586:
			this.CpyBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5593:
			this.RTDBtnRadInfoFLASHportIButton_A8217 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55A0:
			this.RTDBtnRadInfoLabtoolCloningInProgress_A7672 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55AD:
			this.CVBtnRadInfoLabtoolTacticalServicesHOption = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55BA:
			this.CpyBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_55C7:
			this.ExpanderRadioInformationASKProgrammingHistorySRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_55D4:
			this.CpyBtnRadInfoGeneralDisplayCodeplugAlias_43580 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_55E1:
			this.LblRadInfoLabtoolPrimaryBands_A23987 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolPrimaryBands_A23987.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5605:
			this.RadInfoLabtoolDINCPlusAudio_42670Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5612:
			this.CpyBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_561F:
			this.LblRadInfoLabtoolManDown_A40006 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolManDown_A40006.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5643:
			this.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = (global::AcpUI.AcpLabel)target;
			this.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5667:
			this.RadInfoOptionExpansionBoardBoardName_A37549Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5674:
			this.CpyBtnRadInfoLabtoolH37G50Smartnet_A8184 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5681:
			this.RTDBtnRadInfoLabtoolQ173G173Omnilink_A8788 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_568E:
			this.RadInfoLabtool900MHzEnable_A42570Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_569B:
			this.CpyBtnRadInfoLabtoolH04ConvTacticalRekey_35710 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_56A8:
			this.LblRadInfoGeneralDSPVersion_A7892 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralDSPVersion_A7892.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_56CC:
			this.ExpanderRadioInformationTracking = (global::AcpUI.AcpExpander)target;
			return;
			IL_56D9:
			this.CVBtnRadInfoLabtoolNumOfSysEnhBytes_A22749 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_56E6:
			this.LblRadInfoTrackingSource2_A8625 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoTrackingSource2_A8625.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_570A:
			this.RTDBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5717:
			this.RadInfoLabtoolQA00569_7800MHZ_A42596 = (global::AcpUI.AcpComboBox)target;
			this.RadInfoLabtoolQA00569_7800MHZ_A42596.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_573B:
			this.CpyBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5748:
			this.CpyBtnRadInfoLabtoolQ445FiregroundSupport_A8796 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5755:
			this.CVBtnRadInfoLabtoolExtendedDispatch_A38638 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5762:
			this.ExpanderRadioInformationOptionExpansionBoard = (global::AcpUI.AcpExpander)target;
			return;
			IL_576F:
			this.RTDBtnRadInfoFrequencyRangesOpenFrequency_A22699 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_577C:
			this.CVBtnRadInfoGeneralMaximumChannels_A11479 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5789:
			this.ExpanderRadioInformationGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_5796:
			this.RadInfoLabtoolManDown_A40006Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_57A3:
			this.RadInfoLabtoolH37G50Smartnet_A8184Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_57B0:
			this.CVBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57BD:
			this.RadInfoLabtoolTDMAOperation_A23984 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolTDMAOperation_A23984.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_57E1:
			this.RadInfoLabtoolSmartConnectOverBroadband_43720Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_57EE:
			this.LblRadInfoLabtoolGPSActivation_A23983 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolGPSActivation_A23983.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5812:
			this.CVBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_581F:
			this.LblRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5843:
			this.RadInfoLabtoolNightVisionGoggle_43542Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5850:
			this.RadInfoLabtoolH38G51Smartzone_A8185Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_585D:
			this.RadInfoLabtoolTDMAOperation_A23984Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_586A:
			this.RadInfoLabtoolQA01771GA01771EnhancementLev2_37660 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA01771GA01771EnhancementLev2_37660.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_588E:
			this.RadInfoGeneralTuningVersion_A9509Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_589B:
			this.RTDBtnRadInfoGeneralSecureHardwareVersion = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_58A8:
			this.RadInfoLabtoolSecondaryBands_A23988Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_58B5:
			this.RadInfoLabtoolLTEHWEnablement_QA08887Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_58C2:
			this.RTDBtnRadInfoOptionExpansionBoardBoardType_A37049 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_58CF:
			this.RadInfoGeneralSecureHardwareType = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralSecureHardwareType.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_58F3:
			this.CpyBtnRadInfoGeneralMaximumChannels_A11479 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5900:
			this.LblRadInfoGeneralSecureHardwareVersion = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralSecureHardwareVersion.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5924:
			this.RTDBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5931:
			this.CpyBtnRadioInfoLabToolGermanFedGovEnabled_43792 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_593E:
			this.CpyBtnRadInfoLabtoolG138MotorcycleRadio_A24684 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_594B:
			this.LblRadInfoLabtoolH868W968OtarAndMultikey_A8192 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolH868W968OtarAndMultikey_A8192.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_596F:
			this.LblRadInfoLabtoolQA08676_AdaptiveSpeakerVolume = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA08676_AdaptiveSpeakerVolume.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5993:
			this.HLinkOptionExpansionBoard = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkOptionExpansionBoard.Click += this.HLinkClick;
			return;
			IL_59B7:
			this.CpyBtnRadInfoLabtoolQ173G173Omnilink_A8788 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_59C4:
			this.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = (global::AcpUI.AcpCheckBox)target;
			this.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59E8:
			this.RadInfoOptionExpansionBoardBoardType_A37049 = (global::AcpUI.AcpLabel)target;
			this.RadInfoOptionExpansionBoardBoardType_A37049.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A0C:
			this.RadInfoTrackingCodeplugVersion_A7688Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5A19:
			this.CVBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Value = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A26:
			this.LblRadInfoLabtoolBluetooth_A37042 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolBluetooth_A37042.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A4A:
			this.CVBtnRadInfoLabtoolQ947W947APCOPacketData_8804 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A57:
			this.CVBtnRadInfoLabtoolDualRadioOperation_A42245 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A64:
			this.RadInfoLabtoolG138MotorcycleRadio_A24684Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5A71:
			this.LblRadInfoLabtoolBornOnDateDBValue_A7568 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolBornOnDateDBValue_A7568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A95:
			this.LblRadInfoLabtoolQ361G361APCOTrunking_A8794 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQ361G361APCOTrunking_A8794.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5AB9:
			this.RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5ADD:
			this.RTDBtnRadInfoLabtoolNumOfSysEnhBytes_A22749 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5AEA:
			this.RadioInfoLabToolGermanFedGovEnabled_43792Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5AF7:
			this.CpyBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B04:
			this.CVBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B11:
			this.RTDBtnRadInfoGeneralTuningVersion_A9509 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5B1E:
			this.CpyBtnRadInfoLabtoolQA00570VHF_A37151 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B2B:
			this.RTDBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5B38:
			this.RadInfoLabtoolQA02006APX6000XE_A38951 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA02006APX6000XE_A38951.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B5C:
			this.RTDBtnRadInfoGeneralMaximumChannels_A11479 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5B69:
			this.RadInfoLabtoolFPPStatus_A8144Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5B76:
			this.CpyBtnRadInfoDepotKeySerialNumber_42793 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B83:
			this.RadInfoLabtoolQ445FiregroundSupport_A8796Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5B90:
			this.RadInfoGeneralPrimaryFrequencyBand700_A42543Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5B9D:
			this.RTDBtnRadInfoGeneralPrimaryFrequencyBand900_A42548 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BAA:
			this.RTDBtnRadInfoGeneralFirmwareVersion_A8124 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BB7:
			this.CpyBtnRadInfoLabtoolWiFiCapability_42549 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BC4:
			this.CVBtnRadInfoGeneralPSDTVersion_A8768 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5BD1:
			this.CpyBtnEnhancedDataOperation_42024 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BDE:
			this.LblRadInfoLabtoolSmartConnectOverBroadband_43720 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolSmartConnectOverBroadband_43720.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C02:
			this.CVBtnRadInfoGeneralCodeplugVersion_A7683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C0F:
			this.RadInfoLabtoolQA01648ASKEnable_A37150Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5C1C:
			this.RTDBtnRadInfoLabtoolNightVisionGoggle_43542 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C29:
			this.GrpBoxExpanderRadioInformationGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5C36:
			this.CVBtnRadInfoOptionExpansionBoardBoardType_A37049 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C43:
			this.LblRadInfoLabtoolNightVisionGoggle_43542 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolNightVisionGoggle_43542.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C67:
			this.RadInfoLabtoolQ361G361APCOTrunking_A8794 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQ361G361APCOTrunking_A8794.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5C8B:
			this.CVBtnRadInfoLabtoolFPPNonFEDVersion_A8143 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C98:
			this.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197 = (global::AcpUI.AcpLabel)target;
			this.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5CBC:
			this.CVBtnRadInfoGeneralPrimaryFrequencyBand700_A42543 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5CC9:
			this.RTDBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CD6:
			this.RTDBtnRadInfoLabtoolQA01749LegacySWEnable_A37151 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CE3:
			this.CpyBtnRadInfoOptionExpansionBoardBoardName_A37549 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5CF0:
			this.RTDBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CFD:
			this.LblRadInfoLabtoolQA00572UHFRange2_A42595 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA00572UHFRange2_A42595.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D21:
			this.CVBtnRadInfoLabtoolH37G50Smartnet_A8184 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D2E:
			this.CpyBtnRadInfoGeneralSerialNumber_A9122 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5D3B:
			this.RadInfoGeneralSecureHardwareVersion = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralSecureHardwareVersion.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D5F:
			this.CpyBtnRadInfoLabtoolBornOnDateDBValue_A7568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5D6C:
			this.LblRadInfoLabtoolQA00569_7800MHZ_A42596 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolQA00569_7800MHZ_A42596.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D90:
			this.LblRadioInfoLabToolQA00631DvrsPsuActivation_A40166 = (global::AcpUI.AcpLabel)target;
			this.LblRadioInfoLabToolQA00631DvrsPsuActivation_A40166.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5DB4:
			this.RTDBtnRadInfoLabtoolGA04892_8900MHZ_A44827 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5DC1:
			this.LblRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5DE5:
			this.CVBtnRadInfoLabtoolPID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5DF2:
			this.HLinkFrequencyRanges = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFrequencyRanges.Click += this.HLinkClick;
			return;
			IL_5E16:
			this.CVBtnRadInfoLabtool00982SiteSelAlertForP25_42052 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5E23:
			this.LblRadInfoLabtoolNumOfSysEnhBytes_A22749 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolNumOfSysEnhBytes_A22749.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E47:
			this.LblRadInfoGeneralCodeplugAlias_A7684 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralCodeplugAlias_A7684.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E6B:
			this.LblRadInfoLabtoolCloningInProgress_A7672 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoLabtoolCloningInProgress_A7672.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E8F:
			this.RTDBtnRadInfoGeneralInstalledTxmCertificate = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E9C:
			this.RadInfoGeneralPrimaryFrequencyBand900_A42548 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralPrimaryFrequencyBand900_A42548.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5EC0:
			this.b = true;
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x0049888C File Offset: 0x00496A8C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)890896387;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1885077505;
					if (num != 0)
					{
					}
					num = (short)423316099;
					short num3 = num;
					num = (short)1516456579;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1000407040;
						short num4 = num;
						num = (short)773390336;
						if (num != 0)
						{
						}
						num = (short)1001586689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					if (connectionId != 3)
					{
						num = (short)225771522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 2:
					return;
				case 3:
					goto IL_14;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (connectionId == 2)
					{
						goto IL_ED;
					}
					num = (short)952238080;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_ED:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13D:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04001B0F RID: 6927
		private bool a;

		// Token: 0x04001B10 RID: 6928
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04001B11 RID: 6929
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04001B12 RID: 6930
		internal global::System.Windows.Documents.Hyperlink HLinkTracking;

		// Token: 0x04001B13 RID: 6931
		internal global::System.Windows.Documents.Hyperlink HLinkFLASHport;

		// Token: 0x04001B14 RID: 6932
		internal global::System.Windows.Documents.Hyperlink HLinkAdvancedSystemKeyInfo;

		// Token: 0x04001B15 RID: 6933
		internal global::System.Windows.Documents.Hyperlink HLinkDepotKeyInfo;

		// Token: 0x04001B16 RID: 6934
		internal global::System.Windows.Documents.Hyperlink HLinkFrequencyRanges;

		// Token: 0x04001B17 RID: 6935
		internal global::System.Windows.Documents.Hyperlink HLinkOptionExpansionBoard;

		// Token: 0x04001B18 RID: 6936
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04001B19 RID: 6937
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04001B1A RID: 6938
		internal global::AcpUI.AcpExpander ExpanderRadioInformationGeneral;

		// Token: 0x04001B1B RID: 6939
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationGeneralPseudo0;

		// Token: 0x04001B1C RID: 6940
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001B1D RID: 6941
		internal global::AcpUI.AcpLabel LblRadInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001B1E RID: 6942
		internal global::AcpUI.AcpTextBox RadInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001B1F RID: 6943
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001B20 RID: 6944
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001B21 RID: 6945
		internal global::AcpUI.AcpLabel RadInfoGeneralCodeplugAlias_A7684Comp;

		// Token: 0x04001B22 RID: 6946
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralDisplayCodeplugAlias_43580;

		// Token: 0x04001B23 RID: 6947
		internal global::AcpUI.AcpLabel LblRadInfoGeneralDisplayCodeplugAlias_43580;

		// Token: 0x04001B24 RID: 6948
		internal global::AcpUI.AcpCheckBox RadInfoGeneralDisplayCodeplugAlias_43580;

		// Token: 0x04001B25 RID: 6949
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralDisplayCodeplugAlias_43580;

		// Token: 0x04001B26 RID: 6950
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralDisplayCodeplugAlias_43580;

		// Token: 0x04001B27 RID: 6951
		internal global::AcpUI.AcpCheckBox RadInfoGeneralDisplayCodeplugAlias_43580Comp;

		// Token: 0x04001B28 RID: 6952
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralModelNumber_A8539;

		// Token: 0x04001B29 RID: 6953
		internal global::AcpUI.AcpLabel LblRadInfoGeneralModelNumber_A8539;

		// Token: 0x04001B2A RID: 6954
		internal global::AcpUI.AcpLabel RadInfoGeneralModelNumber_A8539;

		// Token: 0x04001B2B RID: 6955
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralModelNumber_A8539;

		// Token: 0x04001B2C RID: 6956
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralModelNumber_A8539;

		// Token: 0x04001B2D RID: 6957
		internal global::AcpUI.AcpLabel RadInfoGeneralModelNumber_A8539Comp;

		// Token: 0x04001B2E RID: 6958
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001B2F RID: 6959
		internal global::AcpUI.AcpLabel LblRadInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001B30 RID: 6960
		internal global::AcpUI.AcpLabel RadInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001B31 RID: 6961
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001B32 RID: 6962
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001B33 RID: 6963
		internal global::AcpUI.AcpLabel RadInfoGeneralMaximumChannels_A11479Comp;

		// Token: 0x04001B34 RID: 6964
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralSerialNumber_A9122;

		// Token: 0x04001B35 RID: 6965
		internal global::AcpUI.AcpLabel LblRadInfoGeneralSerialNumber_A9122;

		// Token: 0x04001B36 RID: 6966
		internal global::AcpUI.AcpTextBox RadInfoGeneralSerialNumber_A9122;

		// Token: 0x04001B37 RID: 6967
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralSerialNumber_A9122;

		// Token: 0x04001B38 RID: 6968
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralSerialNumber_A9122;

		// Token: 0x04001B39 RID: 6969
		internal global::AcpUI.AcpLabel RadInfoGeneralSerialNumber_A9122Comp;

		// Token: 0x04001B3A RID: 6970
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001B3B RID: 6971
		internal global::AcpUI.AcpLabel LblRadInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001B3C RID: 6972
		internal global::AcpUI.AcpLabel RadInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001B3D RID: 6973
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001B3E RID: 6974
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001B3F RID: 6975
		internal global::AcpUI.AcpLabel RadInfoGeneralElectronicSerialNumber_A41744Comp;

		// Token: 0x04001B40 RID: 6976
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralMACAddress_A41837;

		// Token: 0x04001B41 RID: 6977
		internal global::AcpUI.AcpLabel LblRadInfoGeneralMACAddress_A41837;

		// Token: 0x04001B42 RID: 6978
		internal global::AcpUI.AcpLabel RadInfoGeneralMACAddress_A41837;

		// Token: 0x04001B43 RID: 6979
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralMACAddress_A41837;

		// Token: 0x04001B44 RID: 6980
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralMACAddress_A41837;

		// Token: 0x04001B45 RID: 6981
		internal global::AcpUI.AcpLabel RadInfoGeneralMACAddress_A41837Comp;

		// Token: 0x04001B46 RID: 6982
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001B47 RID: 6983
		internal global::AcpUI.AcpLabel LblRadInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001B48 RID: 6984
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001B49 RID: 6985
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001B4A RID: 6986
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001B4B RID: 6987
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiMACAddress_42509Comp;

		// Token: 0x04001B4C RID: 6988
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001B4D RID: 6989
		internal global::AcpUI.AcpLabel LblRadInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001B4E RID: 6990
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001B4F RID: 6991
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001B50 RID: 6992
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001B51 RID: 6993
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiBTMACAddress_42510Comp;

		// Token: 0x04001B52 RID: 6994
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001B53 RID: 6995
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001B54 RID: 6996
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001B55 RID: 6997
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001B56 RID: 6998
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001B57 RID: 6999
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand_A12713Comp;

		// Token: 0x04001B58 RID: 7000
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001B59 RID: 7001
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001B5A RID: 7002
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001B5B RID: 7003
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001B5C RID: 7004
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001B5D RID: 7005
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandVHF_A42545Comp;

		// Token: 0x04001B5E RID: 7006
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001B5F RID: 7007
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001B60 RID: 7008
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001B61 RID: 7009
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001B62 RID: 7010
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001B63 RID: 7011
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandUHF1_A42546Comp;

		// Token: 0x04001B64 RID: 7012
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001B65 RID: 7013
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001B66 RID: 7014
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001B67 RID: 7015
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001B68 RID: 7016
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001B69 RID: 7017
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBandUHF2_A42547Comp;

		// Token: 0x04001B6A RID: 7018
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001B6B RID: 7019
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001B6C RID: 7020
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001B6D RID: 7021
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001B6E RID: 7022
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001B6F RID: 7023
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand700_A42543Comp;

		// Token: 0x04001B70 RID: 7024
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001B71 RID: 7025
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001B72 RID: 7026
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001B73 RID: 7027
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001B74 RID: 7028
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001B75 RID: 7029
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand800_A42544Comp;

		// Token: 0x04001B76 RID: 7030
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001B77 RID: 7031
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001B78 RID: 7032
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001B79 RID: 7033
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001B7A RID: 7034
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001B7B RID: 7035
		internal global::AcpUI.AcpLabel RadInfoGeneralPrimaryFrequencyBand900_A42548Comp;

		// Token: 0x04001B7C RID: 7036
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001B7D RID: 7037
		internal global::AcpUI.AcpLabel LblRadInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001B7E RID: 7038
		internal global::AcpUI.AcpLabel RadInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001B7F RID: 7039
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001B80 RID: 7040
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001B81 RID: 7041
		internal global::AcpUI.AcpLabel RadInfoGeneralSecondaryFrequencyBand_A12715Comp;

		// Token: 0x04001B82 RID: 7042
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001B83 RID: 7043
		internal global::AcpUI.AcpLabel LblRadInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001B84 RID: 7044
		internal global::AcpUI.AcpComboBox RadInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001B85 RID: 7045
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001B86 RID: 7046
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001B87 RID: 7047
		internal global::AcpUI.AcpLabel RadInfoGeneralRegionalGovernance_A36710Comp;

		// Token: 0x04001B88 RID: 7048
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001B89 RID: 7049
		internal global::AcpUI.AcpLabel LblRadInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001B8A RID: 7050
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001B8B RID: 7051
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001B8C RID: 7052
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001B8D RID: 7053
		internal global::AcpUI.AcpLabel RadInfoGeneralWiFiRegulatoryRegion_A43772Comp;

		// Token: 0x04001B8E RID: 7054
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001B8F RID: 7055
		internal global::AcpUI.AcpLabel LblRadInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001B90 RID: 7056
		internal global::AcpUI.AcpLabel RadInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001B91 RID: 7057
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001B92 RID: 7058
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001B93 RID: 7059
		internal global::AcpUI.AcpLabel RadInfoGeneralCodeplugVersion_A7683Comp;

		// Token: 0x04001B94 RID: 7060
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001B95 RID: 7061
		internal global::AcpUI.AcpLabel LblRadInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001B96 RID: 7062
		internal global::AcpUI.AcpLabel RadInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001B97 RID: 7063
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001B98 RID: 7064
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001B99 RID: 7065
		internal global::AcpUI.AcpLabel RadInfoGeneralFirmwareVersion_A8124Comp;

		// Token: 0x04001B9A RID: 7066
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralDSPVersion_A7892;

		// Token: 0x04001B9B RID: 7067
		internal global::AcpUI.AcpLabel LblRadInfoGeneralDSPVersion_A7892;

		// Token: 0x04001B9C RID: 7068
		internal global::AcpUI.AcpLabel RadInfoGeneralDSPVersion_A7892;

		// Token: 0x04001B9D RID: 7069
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralDSPVersion_A7892;

		// Token: 0x04001B9E RID: 7070
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralDSPVersion_A7892;

		// Token: 0x04001B9F RID: 7071
		internal global::AcpUI.AcpLabel RadInfoGeneralDSPVersion_A7892Comp;

		// Token: 0x04001BA0 RID: 7072
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralUCMVersion_A9591;

		// Token: 0x04001BA1 RID: 7073
		internal global::AcpUI.AcpLabel LblRadInfoGeneralUCMVersion_A9591;

		// Token: 0x04001BA2 RID: 7074
		internal global::AcpUI.AcpLabel RadInfoGeneralUCMVersion_A9591;

		// Token: 0x04001BA3 RID: 7075
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralUCMVersion_A9591;

		// Token: 0x04001BA4 RID: 7076
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralUCMVersion_A9591;

		// Token: 0x04001BA5 RID: 7077
		internal global::AcpUI.AcpLabel RadInfoGeneralUCMVersion_A9591Comp;

		// Token: 0x04001BA6 RID: 7078
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralSecureHardwareType;

		// Token: 0x04001BA7 RID: 7079
		internal global::AcpUI.AcpLabel LblRadInfoGeneralSecureHardwareType;

		// Token: 0x04001BA8 RID: 7080
		internal global::AcpUI.AcpLabel RadInfoGeneralSecureHardwareType;

		// Token: 0x04001BA9 RID: 7081
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralSecureHardwareType;

		// Token: 0x04001BAA RID: 7082
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralSecureHardwareType;

		// Token: 0x04001BAB RID: 7083
		internal global::AcpUI.AcpLabel RadInfoGeneralSecureHardwareTypeComp;

		// Token: 0x04001BAC RID: 7084
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralSecureHardwareVersion;

		// Token: 0x04001BAD RID: 7085
		internal global::AcpUI.AcpLabel LblRadInfoGeneralSecureHardwareVersion;

		// Token: 0x04001BAE RID: 7086
		internal global::AcpUI.AcpLabel RadInfoGeneralSecureHardwareVersion;

		// Token: 0x04001BAF RID: 7087
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralSecureHardwareVersion;

		// Token: 0x04001BB0 RID: 7088
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralSecureHardwareVersion;

		// Token: 0x04001BB1 RID: 7089
		internal global::AcpUI.AcpLabel RadInfoGeneralSecureHardwareVersionComp;

		// Token: 0x04001BB2 RID: 7090
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralTuningVersion_A9509;

		// Token: 0x04001BB3 RID: 7091
		internal global::AcpUI.AcpLabel LblRadInfoGeneralTuningVersion_A9509;

		// Token: 0x04001BB4 RID: 7092
		internal global::AcpUI.AcpLabel RadInfoGeneralTuningVersion_A9509;

		// Token: 0x04001BB5 RID: 7093
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralTuningVersion_A9509;

		// Token: 0x04001BB6 RID: 7094
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralTuningVersion_A9509;

		// Token: 0x04001BB7 RID: 7095
		internal global::AcpUI.AcpLabel RadInfoGeneralTuningVersion_A9509Comp;

		// Token: 0x04001BB8 RID: 7096
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001BB9 RID: 7097
		internal global::AcpUI.AcpLabel LblRadInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001BBA RID: 7098
		internal global::AcpUI.AcpLabel RadInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001BBB RID: 7099
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001BBC RID: 7100
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001BBD RID: 7101
		internal global::AcpUI.AcpLabel RadInfoGeneralPSDTVersion_A8768Comp;

		// Token: 0x04001BBE RID: 7102
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001BBF RID: 7103
		internal global::AcpUI.AcpLabel LblRadInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001BC0 RID: 7104
		internal global::AcpUI.AcpLabel RadInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001BC1 RID: 7105
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001BC2 RID: 7106
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001BC3 RID: 7107
		internal global::AcpUI.AcpLabel RadInfoGeneralBootloaderVersion_A7567Comp;

		// Token: 0x04001BC4 RID: 7108
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001BC5 RID: 7109
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001BC6 RID: 7110
		internal global::AcpUI.AcpLabel LblRadInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001BC7 RID: 7111
		internal global::AcpUI.AcpLabel RadInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001BC8 RID: 7112
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001BC9 RID: 7113
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001BCA RID: 7114
		internal global::AcpUI.AcpLabel RadInfoGeneralInstalledTxmCertificateComp;

		// Token: 0x04001BCB RID: 7115
		internal global::AcpUI.AcpLabel LblRadInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001BCC RID: 7116
		internal global::AcpUI.AcpLabel RadInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001BCD RID: 7117
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001BCE RID: 7118
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001BCF RID: 7119
		internal global::AcpUI.AcpLabel RadInfoGeneralNautilusVersion_A8564Comp;

		// Token: 0x04001BD0 RID: 7120
		internal global::AcpUI.AcpExpander ExpanderRadioInformationTracking;

		// Token: 0x04001BD1 RID: 7121
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationTrackingLastProgrammedInformation;

		// Token: 0x04001BD2 RID: 7122
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001BD3 RID: 7123
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001BD4 RID: 7124
		internal global::AcpUI.AcpLabel RadInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001BD5 RID: 7125
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001BD6 RID: 7126
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001BD7 RID: 7127
		internal global::AcpUI.AcpLabel RadInfoLabtoolLastProgrammedDateDBValue_A8411Comp;

		// Token: 0x04001BD8 RID: 7128
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoTrackingSource1_A9171;

		// Token: 0x04001BD9 RID: 7129
		internal global::AcpUI.AcpLabel LblRadInfoTrackingSource1_A9171;

		// Token: 0x04001BDA RID: 7130
		internal global::AcpUI.AcpLabel RadInfoTrackingSource1_A9171;

		// Token: 0x04001BDB RID: 7131
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoTrackingSource1_A9171;

		// Token: 0x04001BDC RID: 7132
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoTrackingSource1_A9171;

		// Token: 0x04001BDD RID: 7133
		internal global::AcpUI.AcpLabel RadInfoTrackingSource1_A9171Comp;

		// Token: 0x04001BDE RID: 7134
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationTrackingOriginalProgrammedInformation;

		// Token: 0x04001BDF RID: 7135
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001BE0 RID: 7136
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001BE1 RID: 7137
		internal global::AcpUI.AcpLabel RadInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001BE2 RID: 7138
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001BE3 RID: 7139
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001BE4 RID: 7140
		internal global::AcpUI.AcpLabel RadInfoLabtoolBornOnDateDBValue_A7568Comp;

		// Token: 0x04001BE5 RID: 7141
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001BE6 RID: 7142
		internal global::AcpUI.AcpLabel LblRadInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001BE7 RID: 7143
		internal global::AcpUI.AcpLabel RadInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001BE8 RID: 7144
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001BE9 RID: 7145
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001BEA RID: 7146
		internal global::AcpUI.AcpLabel RadInfoTrackingCodeplugVersion_A7688Comp;

		// Token: 0x04001BEB RID: 7147
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoTrackingSource2_A8625;

		// Token: 0x04001BEC RID: 7148
		internal global::AcpUI.AcpLabel LblRadInfoTrackingSource2_A8625;

		// Token: 0x04001BED RID: 7149
		internal global::AcpUI.AcpLabel RadInfoTrackingSource2_A8625;

		// Token: 0x04001BEE RID: 7150
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoTrackingSource2_A8625;

		// Token: 0x04001BEF RID: 7151
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoTrackingSource2_A8625;

		// Token: 0x04001BF0 RID: 7152
		internal global::AcpUI.AcpLabel RadInfoTrackingSource2_A8625Comp;

		// Token: 0x04001BF1 RID: 7153
		internal global::AcpUI.AcpExpander ExpanderRadioInformationFLASHport;

		// Token: 0x04001BF2 RID: 7154
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationFLASHportPseudo0;

		// Token: 0x04001BF3 RID: 7155
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001BF4 RID: 7156
		internal global::AcpUI.AcpLabel LblRadInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001BF5 RID: 7157
		internal global::AcpUI.AcpLabel RadInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001BF6 RID: 7158
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001BF7 RID: 7159
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001BF8 RID: 7160
		internal global::AcpUI.AcpLabel RadInfoFLASHportFLASHcode_A8132Comp;

		// Token: 0x04001BF9 RID: 7161
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFLASHportNumberofTimesFlashed_A8581;

		// Token: 0x04001BFA RID: 7162
		internal global::AcpUI.AcpLabel LblRadInfoFLASHportNumberofTimesFlashed_A8581;

		// Token: 0x04001BFB RID: 7163
		internal global::AcpUI.AcpLabel RadInfoFLASHportNumberofTimesFlashed_A8581;

		// Token: 0x04001BFC RID: 7164
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFLASHportNumberofTimesFlashed_A8581;

		// Token: 0x04001BFD RID: 7165
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFLASHportNumberofTimesFlashed_A8581;

		// Token: 0x04001BFE RID: 7166
		internal global::AcpUI.AcpLabel RadInfoFLASHportNumberofTimesFlashed_A8581Comp;

		// Token: 0x04001BFF RID: 7167
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFLASHportIButton_A8217;

		// Token: 0x04001C00 RID: 7168
		internal global::AcpUI.AcpLabel LblRadInfoFLASHportIButton_A8217;

		// Token: 0x04001C01 RID: 7169
		internal global::AcpUI.AcpLabel RadInfoFLASHportIButton_A8217;

		// Token: 0x04001C02 RID: 7170
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFLASHportIButton_A8217;

		// Token: 0x04001C03 RID: 7171
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFLASHportIButton_A8217;

		// Token: 0x04001C04 RID: 7172
		internal global::AcpUI.AcpLabel RadInfoFLASHportIButton_A8217Comp;

		// Token: 0x04001C05 RID: 7173
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001C06 RID: 7174
		internal global::AcpUI.AcpLabel LblRadInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001C07 RID: 7175
		internal global::AcpUI.AcpLabel RadInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001C08 RID: 7176
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001C09 RID: 7177
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001C0A RID: 7178
		internal global::AcpUI.AcpLabel RadInfoFLASHportLastUpgradeSource_A8387Comp;

		// Token: 0x04001C0B RID: 7179
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001C0C RID: 7180
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001C0D RID: 7181
		internal global::AcpUI.AcpLabel RadInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001C0E RID: 7182
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001C0F RID: 7183
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001C10 RID: 7184
		internal global::AcpUI.AcpLabel RadInfoLabtoolLastFLASHKeyDateStampData_A8388Comp;

		// Token: 0x04001C11 RID: 7185
		internal global::AcpUI.AcpExpander ExpanderRadioInformationAdvancedSystemKeyInfo;

		// Token: 0x04001C12 RID: 7186
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioInformationASKProgrammingHistory;

		// Token: 0x04001C13 RID: 7187
		internal global::System.Windows.Controls.Grid ExpanderRadioInformationAdvancedSystemKeyInfoGrid;

		// Token: 0x04001C14 RID: 7188
		internal global::System.Windows.Controls.Grid ExpanderRadioInformationASKProgrammingHistoryGrid;

		// Token: 0x04001C15 RID: 7189
		internal global::AcpUI.AcpGroupBox ExpanderRadioInformationASKProgrammingHistoryTableView;

		// Token: 0x04001C16 RID: 7190
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioInformationASKProgrammingHistory;

		// Token: 0x04001C17 RID: 7191
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Col;

		// Token: 0x04001C18 RID: 7192
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Col;

		// Token: 0x04001C19 RID: 7193
		internal global::AcpUI.AcpGroupBox ExpanderRadioInformationASKProgrammingHistorySRecView;

		// Token: 0x04001C1A RID: 7194
		internal global::System.Windows.Controls.Grid gridExpanderRadioInformationASKProgrammingHistorySRecView;

		// Token: 0x04001C1B RID: 7195
		internal global::AcpUI.AcpLabel RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001C1C RID: 7196
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001C1D RID: 7197
		internal global::AcpUI.AcpLabel LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001C1E RID: 7198
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001C1F RID: 7199
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001C20 RID: 7200
		internal global::AcpUI.AcpLabel RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Comp;

		// Token: 0x04001C21 RID: 7201
		internal global::AcpUI.AcpLabel RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;

		// Token: 0x04001C22 RID: 7202
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;

		// Token: 0x04001C23 RID: 7203
		internal global::AcpUI.AcpLabel LblRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;

		// Token: 0x04001C24 RID: 7204
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;

		// Token: 0x04001C25 RID: 7205
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;

		// Token: 0x04001C26 RID: 7206
		internal global::AcpUI.AcpLabel RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Comp;

		// Token: 0x04001C27 RID: 7207
		internal global::AcpUI.AcpExpander ExpanderRadioInformationDepotKeyInfo;

		// Token: 0x04001C28 RID: 7208
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationDepotKeyInfoPseudo0;

		// Token: 0x04001C29 RID: 7209
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoDepotKeySerialNumber_42793;

		// Token: 0x04001C2A RID: 7210
		internal global::AcpUI.AcpLabel LblRadInfoDepotKeySerialNumber_42793;

		// Token: 0x04001C2B RID: 7211
		internal global::AcpUI.AcpLabel RadInfoDepotKeySerialNumber_42793;

		// Token: 0x04001C2C RID: 7212
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoDepotKeySerialNumber_42793;

		// Token: 0x04001C2D RID: 7213
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoDepotKeySerialNumber_42793;

		// Token: 0x04001C2E RID: 7214
		internal global::AcpUI.AcpLabel RadInfoDepotKeySerialNumber_42793Comp;

		// Token: 0x04001C2F RID: 7215
		internal global::AcpUI.AcpExpander ExpanderRadioInformationFrequencyRanges;

		// Token: 0x04001C30 RID: 7216
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationFrequencyRangesPseudo0;

		// Token: 0x04001C31 RID: 7217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001C32 RID: 7218
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001C33 RID: 7219
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001C34 RID: 7220
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001C35 RID: 7221
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001C36 RID: 7222
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesOpenFrequency_A22699Comp;

		// Token: 0x04001C37 RID: 7223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001C38 RID: 7224
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001C39 RID: 7225
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001C3A RID: 7226
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001C3B RID: 7227
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001C3C RID: 7228
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendedUHFR1Capable_A41443Comp;

		// Token: 0x04001C3D RID: 7229
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001C3E RID: 7230
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001C3F RID: 7231
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001C40 RID: 7232
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001C41 RID: 7233
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001C42 RID: 7234
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendRange762Capable_A43555Comp;

		// Token: 0x04001C43 RID: 7235
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;

		// Token: 0x04001C44 RID: 7236
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;

		// Token: 0x04001C45 RID: 7237
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;

		// Token: 0x04001C46 RID: 7238
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;

		// Token: 0x04001C47 RID: 7239
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;

		// Token: 0x04001C48 RID: 7240
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578Comp;

		// Token: 0x04001C49 RID: 7241
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationFrequencyRangesCodeplugFrequencies;

		// Token: 0x04001C4A RID: 7242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001C4B RID: 7243
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001C4C RID: 7244
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001C4D RID: 7245
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001C4E RID: 7246
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001C4F RID: 7247
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesAllowInvalidFrequencies_A12493Comp;

		// Token: 0x04001C50 RID: 7248
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001C51 RID: 7249
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001C52 RID: 7250
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001C53 RID: 7251
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001C54 RID: 7252
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001C55 RID: 7253
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesVHFUsedinCodeplug_A8481Comp;

		// Token: 0x04001C56 RID: 7254
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001C57 RID: 7255
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001C58 RID: 7256
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001C59 RID: 7257
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001C5A RID: 7258
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001C5B RID: 7259
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504Comp;

		// Token: 0x04001C5C RID: 7260
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001C5D RID: 7261
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001C5E RID: 7262
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001C5F RID: 7263
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001C60 RID: 7264
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001C61 RID: 7265
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507Comp;

		// Token: 0x04001C62 RID: 7266
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001C63 RID: 7267
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001C64 RID: 7268
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001C65 RID: 7269
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001C66 RID: 7270
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001C67 RID: 7271
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551Comp;

		// Token: 0x04001C68 RID: 7272
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001C69 RID: 7273
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001C6A RID: 7274
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001C6B RID: 7275
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001C6C RID: 7276
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001C6D RID: 7277
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512Comp;

		// Token: 0x04001C6E RID: 7278
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001C6F RID: 7279
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001C70 RID: 7280
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001C71 RID: 7281
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001C72 RID: 7282
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001C73 RID: 7283
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552Comp;

		// Token: 0x04001C74 RID: 7284
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001C75 RID: 7285
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001C76 RID: 7286
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001C77 RID: 7287
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001C78 RID: 7288
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001C79 RID: 7289
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502Comp;

		// Token: 0x04001C7A RID: 7290
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001C7B RID: 7291
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001C7C RID: 7292
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001C7D RID: 7293
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001C7E RID: 7294
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001C7F RID: 7295
		internal global::AcpUI.AcpCheckBox RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516Comp;

		// Token: 0x04001C80 RID: 7296
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationFrequencyRangesPseudo1;

		// Token: 0x04001C81 RID: 7297
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001C82 RID: 7298
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001C83 RID: 7299
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001C84 RID: 7300
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001C85 RID: 7301
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001C86 RID: 7302
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575Comp;

		// Token: 0x04001C87 RID: 7303
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001C88 RID: 7304
		internal global::AcpUI.AcpLabel LblRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001C89 RID: 7305
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001C8A RID: 7306
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001C8B RID: 7307
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001C8C RID: 7308
		internal global::AcpUI.AcpLabel RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576Comp;

		// Token: 0x04001C8D RID: 7309
		internal global::AcpUI.AcpExpander ExpanderRadioInformationOptionExpansionBoard;

		// Token: 0x04001C8E RID: 7310
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationOptionExpansionBoardPseudo0;

		// Token: 0x04001C8F RID: 7311
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoOptionExpansionBoardBoardName_A37549;

		// Token: 0x04001C90 RID: 7312
		internal global::AcpUI.AcpLabel LblRadInfoOptionExpansionBoardBoardName_A37549;

		// Token: 0x04001C91 RID: 7313
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardName_A37549;

		// Token: 0x04001C92 RID: 7314
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoOptionExpansionBoardBoardName_A37549;

		// Token: 0x04001C93 RID: 7315
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoOptionExpansionBoardBoardName_A37549;

		// Token: 0x04001C94 RID: 7316
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardName_A37549Comp;

		// Token: 0x04001C95 RID: 7317
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001C96 RID: 7318
		internal global::AcpUI.AcpLabel LblRadInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001C97 RID: 7319
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001C98 RID: 7320
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001C99 RID: 7321
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001C9A RID: 7322
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardType_A37049Comp;

		// Token: 0x04001C9B RID: 7323
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001C9C RID: 7324
		internal global::AcpUI.AcpLabel LblRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001C9D RID: 7325
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001C9E RID: 7326
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001C9F RID: 7327
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001CA0 RID: 7328
		internal global::AcpUI.AcpLabel RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048Comp;

		// Token: 0x04001CA1 RID: 7329
		internal global::AcpUI.AcpExpander ExpanderRadioInformationLabtool;

		// Token: 0x04001CA2 RID: 7330
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioInformationLabtoolPseudo0;

		// Token: 0x04001CA3 RID: 7331
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolFPPStatus_A8144;

		// Token: 0x04001CA4 RID: 7332
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolFPPStatus_A8144;

		// Token: 0x04001CA5 RID: 7333
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolFPPStatus_A8144;

		// Token: 0x04001CA6 RID: 7334
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolFPPStatus_A8144;

		// Token: 0x04001CA7 RID: 7335
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolFPPStatus_A8144;

		// Token: 0x04001CA8 RID: 7336
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolFPPStatus_A8144Comp;

		// Token: 0x04001CA9 RID: 7337
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685;

		// Token: 0x04001CAA RID: 7338
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685;

		// Token: 0x04001CAB RID: 7339
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685;

		// Token: 0x04001CAC RID: 7340
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685;

		// Token: 0x04001CAD RID: 7341
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685;

		// Token: 0x04001CAE RID: 7342
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolCodeplugAllowsExpandedAustraliaFrequencies_A7685Comp;

		// Token: 0x04001CAF RID: 7343
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolZoneCloningStatus_A9721;

		// Token: 0x04001CB0 RID: 7344
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolZoneCloningStatus_A9721;

		// Token: 0x04001CB1 RID: 7345
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolZoneCloningStatus_A9721;

		// Token: 0x04001CB2 RID: 7346
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolZoneCloningStatus_A9721;

		// Token: 0x04001CB3 RID: 7347
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolZoneCloningStatus_A9721;

		// Token: 0x04001CB4 RID: 7348
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolZoneCloningStatus_A9721Comp;

		// Token: 0x04001CB5 RID: 7349
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991;

		// Token: 0x04001CB6 RID: 7350
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991;

		// Token: 0x04001CB7 RID: 7351
		internal global::AcpUI.AcpLabel RadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991;

		// Token: 0x04001CB8 RID: 7352
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991;

		// Token: 0x04001CB9 RID: 7353
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991;

		// Token: 0x04001CBA RID: 7354
		internal global::AcpUI.AcpLabel RadInfoLabtoolExternalRadioBlockExternalCodeplugSize_A7991Comp;

		// Token: 0x04001CBB RID: 7355
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA02006APX6000XE_A38951;

		// Token: 0x04001CBC RID: 7356
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA02006APX6000XE_A38951;

		// Token: 0x04001CBD RID: 7357
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02006APX6000XE_A38951;

		// Token: 0x04001CBE RID: 7358
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA02006APX6000XE_A38951;

		// Token: 0x04001CBF RID: 7359
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA02006APX6000XE_A38951;

		// Token: 0x04001CC0 RID: 7360
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02006APX6000XE_A38951Comp;

		// Token: 0x04001CC1 RID: 7361
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolCloningInProgress_A7672;

		// Token: 0x04001CC2 RID: 7362
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolCloningInProgress_A7672;

		// Token: 0x04001CC3 RID: 7363
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolCloningInProgress_A7672;

		// Token: 0x04001CC4 RID: 7364
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolCloningInProgress_A7672;

		// Token: 0x04001CC5 RID: 7365
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolCloningInProgress_A7672;

		// Token: 0x04001CC6 RID: 7366
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolCloningInProgress_A7672Comp;

		// Token: 0x04001CC7 RID: 7367
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076;

		// Token: 0x04001CC8 RID: 7368
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolSecurePartitionVersionNumber_A9076;

		// Token: 0x04001CC9 RID: 7369
		internal global::AcpUI.AcpLabel RadInfoLabtoolSecurePartitionVersionNumber_A9076;

		// Token: 0x04001CCA RID: 7370
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076;

		// Token: 0x04001CCB RID: 7371
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolSecurePartitionVersionNumber_A9076;

		// Token: 0x04001CCC RID: 7372
		internal global::AcpUI.AcpLabel RadInfoLabtoolSecurePartitionVersionNumber_A9076Comp;

		// Token: 0x04001CCD RID: 7373
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626;

		// Token: 0x04001CCE RID: 7374
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolOriginalSecurePartitionVersion_A8626;

		// Token: 0x04001CCF RID: 7375
		internal global::AcpUI.AcpLabel RadInfoLabtoolOriginalSecurePartitionVersion_A8626;

		// Token: 0x04001CD0 RID: 7376
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626;

		// Token: 0x04001CD1 RID: 7377
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolOriginalSecurePartitionVersion_A8626;

		// Token: 0x04001CD2 RID: 7378
		internal global::AcpUI.AcpLabel RadInfoLabtoolOriginalSecurePartitionVersion_A8626Comp;

		// Token: 0x04001CD3 RID: 7379
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolNumOfSysEnhBytes_A22749;

		// Token: 0x04001CD4 RID: 7380
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolNumOfSysEnhBytes_A22749;

		// Token: 0x04001CD5 RID: 7381
		internal global::AcpUI.AcpLabel RadInfoLabtoolNumOfSysEnhBytes_A22749;

		// Token: 0x04001CD6 RID: 7382
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolNumOfSysEnhBytes_A22749;

		// Token: 0x04001CD7 RID: 7383
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolNumOfSysEnhBytes_A22749;

		// Token: 0x04001CD8 RID: 7384
		internal global::AcpUI.AcpLabel RadInfoLabtoolNumOfSysEnhBytes_A22749Comp;

		// Token: 0x04001CD9 RID: 7385
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolG966OTAP_A22740;

		// Token: 0x04001CDA RID: 7386
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolG966OTAP_A22740;

		// Token: 0x04001CDB RID: 7387
		internal global::AcpUI.AcpLabel RadInfoLabtoolG966OTAP_A22740;

		// Token: 0x04001CDC RID: 7388
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolG966OTAP_A22740;

		// Token: 0x04001CDD RID: 7389
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolG966OTAP_A22740;

		// Token: 0x04001CDE RID: 7390
		internal global::AcpUI.AcpLabel RadInfoLabtoolG966OTAP_A22740Comp;

		// Token: 0x04001CDF RID: 7391
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolG138MotorcycleRadio_A24684;

		// Token: 0x04001CE0 RID: 7392
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolG138MotorcycleRadio_A24684;

		// Token: 0x04001CE1 RID: 7393
		internal global::AcpUI.AcpLabel RadInfoLabtoolG138MotorcycleRadio_A24684;

		// Token: 0x04001CE2 RID: 7394
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolG138MotorcycleRadio_A24684;

		// Token: 0x04001CE3 RID: 7395
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolG138MotorcycleRadio_A24684;

		// Token: 0x04001CE4 RID: 7396
		internal global::AcpUI.AcpLabel RadInfoLabtoolG138MotorcycleRadio_A24684Comp;

		// Token: 0x04001CE5 RID: 7397
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH37G50Smartnet_A8184;

		// Token: 0x04001CE6 RID: 7398
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH37G50Smartnet_A8184;

		// Token: 0x04001CE7 RID: 7399
		internal global::AcpUI.AcpLabel RadInfoLabtoolH37G50Smartnet_A8184;

		// Token: 0x04001CE8 RID: 7400
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH37G50Smartnet_A8184;

		// Token: 0x04001CE9 RID: 7401
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH37G50Smartnet_A8184;

		// Token: 0x04001CEA RID: 7402
		internal global::AcpUI.AcpLabel RadInfoLabtoolH37G50Smartnet_A8184Comp;

		// Token: 0x04001CEB RID: 7403
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH38G51Smartzone_A8185;

		// Token: 0x04001CEC RID: 7404
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH38G51Smartzone_A8185;

		// Token: 0x04001CED RID: 7405
		internal global::AcpUI.AcpLabel RadInfoLabtoolH38G51Smartzone_A8185;

		// Token: 0x04001CEE RID: 7406
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH38G51Smartzone_A8185;

		// Token: 0x04001CEF RID: 7407
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH38G51Smartzone_A8185;

		// Token: 0x04001CF0 RID: 7408
		internal global::AcpUI.AcpLabel RadInfoLabtoolH38G51Smartzone_A8185Comp;

		// Token: 0x04001CF1 RID: 7409
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ806IMBE_A8191;

		// Token: 0x04001CF2 RID: 7410
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ806IMBE_A8191;

		// Token: 0x04001CF3 RID: 7411
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ806IMBE_A8191;

		// Token: 0x04001CF4 RID: 7412
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ806IMBE_A8191;

		// Token: 0x04001CF5 RID: 7413
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ806IMBE_A8191;

		// Token: 0x04001CF6 RID: 7414
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ806IMBE_A8191Comp;

		// Token: 0x04001CF7 RID: 7415
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192;

		// Token: 0x04001CF8 RID: 7416
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH868W968OtarAndMultikey_A8192;

		// Token: 0x04001CF9 RID: 7417
		internal global::AcpUI.AcpLabel RadInfoLabtoolH868W968OtarAndMultikey_A8192;

		// Token: 0x04001CFA RID: 7418
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192;

		// Token: 0x04001CFB RID: 7419
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH868W968OtarAndMultikey_A8192;

		// Token: 0x04001CFC RID: 7420
		internal global::AcpUI.AcpLabel RadInfoLabtoolH868W968OtarAndMultikey_A8192Comp;

		// Token: 0x04001CFD RID: 7421
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH869W969Multikey_A8193;

		// Token: 0x04001CFE RID: 7422
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH869W969Multikey_A8193;

		// Token: 0x04001CFF RID: 7423
		internal global::AcpUI.AcpLabel RadInfoLabtoolH869W969Multikey_A8193;

		// Token: 0x04001D00 RID: 7424
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH869W969Multikey_A8193;

		// Token: 0x04001D01 RID: 7425
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH869W969Multikey_A8193;

		// Token: 0x04001D02 RID: 7426
		internal global::AcpUI.AcpLabel RadInfoLabtoolH869W969Multikey_A8193Comp;

		// Token: 0x04001D03 RID: 7427
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ173G173Omnilink_A8788;

		// Token: 0x04001D04 RID: 7428
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ173G173Omnilink_A8788;

		// Token: 0x04001D05 RID: 7429
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ173G173Omnilink_A8788;

		// Token: 0x04001D06 RID: 7430
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ173G173Omnilink_A8788;

		// Token: 0x04001D07 RID: 7431
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ173G173Omnilink_A8788;

		// Token: 0x04001D08 RID: 7432
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ173G173Omnilink_A8788Comp;

		// Token: 0x04001D09 RID: 7433
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolExtendedDispatch_A38638;

		// Token: 0x04001D0A RID: 7434
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolExtendedDispatch_A38638;

		// Token: 0x04001D0B RID: 7435
		internal global::AcpUI.AcpLabel RadInfoLabtoolExtendedDispatch_A38638;

		// Token: 0x04001D0C RID: 7436
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolExtendedDispatch_A38638;

		// Token: 0x04001D0D RID: 7437
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolExtendedDispatch_A38638;

		// Token: 0x04001D0E RID: 7438
		internal global::AcpUI.AcpLabel RadInfoLabtoolExtendedDispatch_A38638Comp;

		// Token: 0x04001D0F RID: 7439
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ361G361APCOTrunking_A8794;

		// Token: 0x04001D10 RID: 7440
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ361G361APCOTrunking_A8794;

		// Token: 0x04001D11 RID: 7441
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ361G361APCOTrunking_A8794;

		// Token: 0x04001D12 RID: 7442
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ361G361APCOTrunking_A8794;

		// Token: 0x04001D13 RID: 7443
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ361G361APCOTrunking_A8794;

		// Token: 0x04001D14 RID: 7444
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ361G361APCOTrunking_A8794Comp;

		// Token: 0x04001D15 RID: 7445
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795;

		// Token: 0x04001D16 RID: 7446
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ387G387ConvVoteScan_A8795;

		// Token: 0x04001D17 RID: 7447
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ387G387ConvVoteScan_A8795;

		// Token: 0x04001D18 RID: 7448
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795;

		// Token: 0x04001D19 RID: 7449
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ387G387ConvVoteScan_A8795;

		// Token: 0x04001D1A RID: 7450
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ387G387ConvVoteScan_A8795Comp;

		// Token: 0x04001D1B RID: 7451
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ445FiregroundSupport_A8796;

		// Token: 0x04001D1C RID: 7452
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ445FiregroundSupport_A8796;

		// Token: 0x04001D1D RID: 7453
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ445FiregroundSupport_A8796;

		// Token: 0x04001D1E RID: 7454
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ445FiregroundSupport_A8796;

		// Token: 0x04001D1F RID: 7455
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ445FiregroundSupport_A8796;

		// Token: 0x04001D20 RID: 7456
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ445FiregroundSupport_A8796Comp;

		// Token: 0x04001D21 RID: 7457
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;

		// Token: 0x04001D22 RID: 7458
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;

		// Token: 0x04001D23 RID: 7459
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;

		// Token: 0x04001D24 RID: 7460
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;

		// Token: 0x04001D25 RID: 7461
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;

		// Token: 0x04001D26 RID: 7462
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798Comp;

		// Token: 0x04001D27 RID: 7463
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;

		// Token: 0x04001D28 RID: 7464
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;

		// Token: 0x04001D29 RID: 7465
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;

		// Token: 0x04001D2A RID: 7466
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;

		// Token: 0x04001D2B RID: 7467
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;

		// Token: 0x04001D2C RID: 7468
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799Comp;

		// Token: 0x04001D2D RID: 7469
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ947W947APCOPacketData_8804;

		// Token: 0x04001D2E RID: 7470
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ947W947APCOPacketData_8804;

		// Token: 0x04001D2F RID: 7471
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ947W947APCOPacketData_8804;

		// Token: 0x04001D30 RID: 7472
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ947W947APCOPacketData_8804;

		// Token: 0x04001D31 RID: 7473
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ947W947APCOPacketData_8804;

		// Token: 0x04001D32 RID: 7474
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ947W947APCOPacketData_8804Comp;

		// Token: 0x04001D33 RID: 7475
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolW12Preamp_A9671;

		// Token: 0x04001D34 RID: 7476
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolW12Preamp_A9671;

		// Token: 0x04001D35 RID: 7477
		internal global::AcpUI.AcpLabel RadInfoLabtoolW12Preamp_A9671;

		// Token: 0x04001D36 RID: 7478
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolW12Preamp_A9671;

		// Token: 0x04001D37 RID: 7479
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolW12Preamp_A9671;

		// Token: 0x04001D38 RID: 7480
		internal global::AcpUI.AcpLabel RadInfoLabtoolW12Preamp_A9671Comp;

		// Token: 0x04001D39 RID: 7481
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolGPSActivation_A23983;

		// Token: 0x04001D3A RID: 7482
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolGPSActivation_A23983;

		// Token: 0x04001D3B RID: 7483
		internal global::AcpUI.AcpLabel RadInfoLabtoolGPSActivation_A23983;

		// Token: 0x04001D3C RID: 7484
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolGPSActivation_A23983;

		// Token: 0x04001D3D RID: 7485
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolGPSActivation_A23983;

		// Token: 0x04001D3E RID: 7486
		internal global::AcpUI.AcpLabel RadInfoLabtoolGPSActivation_A23983Comp;

		// Token: 0x04001D3F RID: 7487
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolFPPNonFEDVersion_A8143;

		// Token: 0x04001D40 RID: 7488
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolFPPNonFEDVersion_A8143;

		// Token: 0x04001D41 RID: 7489
		internal global::AcpUI.AcpLabel RadInfoLabtoolFPPNonFEDVersion_A8143;

		// Token: 0x04001D42 RID: 7490
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolFPPNonFEDVersion_A8143;

		// Token: 0x04001D43 RID: 7491
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolFPPNonFEDVersion_A8143;

		// Token: 0x04001D44 RID: 7492
		internal global::AcpUI.AcpLabel RadInfoLabtoolFPPNonFEDVersion_A8143Comp;

		// Token: 0x04001D45 RID: 7493
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482;

		// Token: 0x04001D46 RID: 7494
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolMCHFamilyDifferntiator_A8482;

		// Token: 0x04001D47 RID: 7495
		internal global::AcpUI.AcpLabel RadInfoLabtoolMCHFamilyDifferntiator_A8482;

		// Token: 0x04001D48 RID: 7496
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482;

		// Token: 0x04001D49 RID: 7497
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolMCHFamilyDifferntiator_A8482;

		// Token: 0x04001D4A RID: 7498
		internal global::AcpUI.AcpLabel RadInfoLabtoolMCHFamilyDifferntiator_A8482Comp;

		// Token: 0x04001D4B RID: 7499
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolTDMAOperation_A23984;

		// Token: 0x04001D4C RID: 7500
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolTDMAOperation_A23984;

		// Token: 0x04001D4D RID: 7501
		internal global::AcpUI.AcpLabel RadInfoLabtoolTDMAOperation_A23984;

		// Token: 0x04001D4E RID: 7502
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolTDMAOperation_A23984;

		// Token: 0x04001D4F RID: 7503
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolTDMAOperation_A23984;

		// Token: 0x04001D50 RID: 7504
		internal global::AcpUI.AcpLabel RadInfoLabtoolTDMAOperation_A23984Comp;

		// Token: 0x04001D51 RID: 7505
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985;

		// Token: 0x04001D52 RID: 7506
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolFrontDisplayFullKeypad_A23985;

		// Token: 0x04001D53 RID: 7507
		internal global::AcpUI.AcpLabel RadInfoLabtoolFrontDisplayFullKeypad_A23985;

		// Token: 0x04001D54 RID: 7508
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985;

		// Token: 0x04001D55 RID: 7509
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolFrontDisplayFullKeypad_A23985;

		// Token: 0x04001D56 RID: 7510
		internal global::AcpUI.AcpLabel RadInfoLabtoolFrontDisplayFullKeypad_A23985Comp;

		// Token: 0x04001D57 RID: 7511
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolDualBandEnable_A23986;

		// Token: 0x04001D58 RID: 7512
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolDualBandEnable_A23986;

		// Token: 0x04001D59 RID: 7513
		internal global::AcpUI.AcpLabel RadInfoLabtoolDualBandEnable_A23986;

		// Token: 0x04001D5A RID: 7514
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolDualBandEnable_A23986;

		// Token: 0x04001D5B RID: 7515
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolDualBandEnable_A23986;

		// Token: 0x04001D5C RID: 7516
		internal global::AcpUI.AcpLabel RadInfoLabtoolDualBandEnable_A23986Comp;

		// Token: 0x04001D5D RID: 7517
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA01648ASKEnable_A37150;

		// Token: 0x04001D5E RID: 7518
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA01648ASKEnable_A37150;

		// Token: 0x04001D5F RID: 7519
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01648ASKEnable_A37150;

		// Token: 0x04001D60 RID: 7520
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA01648ASKEnable_A37150;

		// Token: 0x04001D61 RID: 7521
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA01648ASKEnable_A37150;

		// Token: 0x04001D62 RID: 7522
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01648ASKEnable_A37150Comp;

		// Token: 0x04001D63 RID: 7523
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA01749LegacySWEnable_A37151;

		// Token: 0x04001D64 RID: 7524
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA01749LegacySWEnable_A37151;

		// Token: 0x04001D65 RID: 7525
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01749LegacySWEnable_A37151;

		// Token: 0x04001D66 RID: 7526
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA01749LegacySWEnable_A37151;

		// Token: 0x04001D67 RID: 7527
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA01749LegacySWEnable_A37151;

		// Token: 0x04001D68 RID: 7528
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01749LegacySWEnable_A37151Comp;

		// Token: 0x04001D69 RID: 7529
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolPrimaryBands_A23987;

		// Token: 0x04001D6A RID: 7530
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolPrimaryBands_A23987;

		// Token: 0x04001D6B RID: 7531
		internal global::AcpUI.AcpComboBox RadInfoLabtoolPrimaryBands_A23987;

		// Token: 0x04001D6C RID: 7532
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolPrimaryBands_A23987;

		// Token: 0x04001D6D RID: 7533
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolPrimaryBands_A23987;

		// Token: 0x04001D6E RID: 7534
		internal global::AcpUI.AcpLabel RadInfoLabtoolPrimaryBands_A23987Comp;

		// Token: 0x04001D6F RID: 7535
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA00570VHF_A37151;

		// Token: 0x04001D70 RID: 7536
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA00570VHF_A37151;

		// Token: 0x04001D71 RID: 7537
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00570VHF_A37151;

		// Token: 0x04001D72 RID: 7538
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA00570VHF_A37151;

		// Token: 0x04001D73 RID: 7539
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA00570VHF_A37151;

		// Token: 0x04001D74 RID: 7540
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00570VHF_A37151Comp;

		// Token: 0x04001D75 RID: 7541
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA00571UHFRange1_A42594;

		// Token: 0x04001D76 RID: 7542
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA00571UHFRange1_A42594;

		// Token: 0x04001D77 RID: 7543
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00571UHFRange1_A42594;

		// Token: 0x04001D78 RID: 7544
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA00571UHFRange1_A42594;

		// Token: 0x04001D79 RID: 7545
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA00571UHFRange1_A42594;

		// Token: 0x04001D7A RID: 7546
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00571UHFRange1_A42594Comp;

		// Token: 0x04001D7B RID: 7547
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA00572UHFRange2_A42595;

		// Token: 0x04001D7C RID: 7548
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA00572UHFRange2_A42595;

		// Token: 0x04001D7D RID: 7549
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00572UHFRange2_A42595;

		// Token: 0x04001D7E RID: 7550
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA00572UHFRange2_A42595;

		// Token: 0x04001D7F RID: 7551
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA00572UHFRange2_A42595;

		// Token: 0x04001D80 RID: 7552
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00572UHFRange2_A42595Comp;

		// Token: 0x04001D81 RID: 7553
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA00569_7800MHZ_A42596;

		// Token: 0x04001D82 RID: 7554
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA00569_7800MHZ_A42596;

		// Token: 0x04001D83 RID: 7555
		internal global::AcpUI.AcpComboBox RadInfoLabtoolQA00569_7800MHZ_A42596;

		// Token: 0x04001D84 RID: 7556
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA00569_7800MHZ_A42596;

		// Token: 0x04001D85 RID: 7557
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA00569_7800MHZ_A42596;

		// Token: 0x04001D86 RID: 7558
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA00569_7800MHZ_A42596Comp;

		// Token: 0x04001D87 RID: 7559
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolGA04892_8900MHZ_A44827;

		// Token: 0x04001D88 RID: 7560
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolGA04892_8900MHZ_A44827;

		// Token: 0x04001D89 RID: 7561
		internal global::AcpUI.AcpComboBox RadInfoLabtoolGA04892_8900MHZ_A44827;

		// Token: 0x04001D8A RID: 7562
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolGA04892_8900MHZ_A44827;

		// Token: 0x04001D8B RID: 7563
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolGA04892_8900MHZ_A44827;

		// Token: 0x04001D8C RID: 7564
		internal global::AcpUI.AcpLabel RadInfoLabtoolGA04892_8900MHZ_A44827Comp;

		// Token: 0x04001D8D RID: 7565
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtool900MHzEnable_A42570;

		// Token: 0x04001D8E RID: 7566
		internal global::AcpUI.AcpLabel LblRadInfoLabtool900MHzEnable_A42570;

		// Token: 0x04001D8F RID: 7567
		internal global::AcpUI.AcpLabel RadInfoLabtool900MHzEnable_A42570;

		// Token: 0x04001D90 RID: 7568
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtool900MHzEnable_A42570;

		// Token: 0x04001D91 RID: 7569
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtool900MHzEnable_A42570;

		// Token: 0x04001D92 RID: 7570
		internal global::AcpUI.AcpLabel RadInfoLabtool900MHzEnable_A42570Comp;

		// Token: 0x04001D93 RID: 7571
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolSecondaryBands_A23988;

		// Token: 0x04001D94 RID: 7572
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolSecondaryBands_A23988;

		// Token: 0x04001D95 RID: 7573
		internal global::AcpUI.AcpComboBox RadInfoLabtoolSecondaryBands_A23988;

		// Token: 0x04001D96 RID: 7574
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolSecondaryBands_A23988;

		// Token: 0x04001D97 RID: 7575
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolSecondaryBands_A23988;

		// Token: 0x04001D98 RID: 7576
		internal global::AcpUI.AcpLabel RadInfoLabtoolSecondaryBands_A23988Comp;

		// Token: 0x04001D99 RID: 7577
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolBluetooth_A37042;

		// Token: 0x04001D9A RID: 7578
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolBluetooth_A37042;

		// Token: 0x04001D9B RID: 7579
		internal global::AcpUI.AcpLabel RadInfoLabtoolBluetooth_A37042;

		// Token: 0x04001D9C RID: 7580
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolBluetooth_A37042;

		// Token: 0x04001D9D RID: 7581
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolBluetooth_A37042;

		// Token: 0x04001D9E RID: 7582
		internal global::AcpUI.AcpLabel RadInfoLabtoolBluetooth_A37042Comp;

		// Token: 0x04001D9F RID: 7583
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209;

		// Token: 0x04001DA0 RID: 7584
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA01768EnhancedZoneBank_A37209;

		// Token: 0x04001DA1 RID: 7585
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01768EnhancedZoneBank_A37209;

		// Token: 0x04001DA2 RID: 7586
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209;

		// Token: 0x04001DA3 RID: 7587
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA01768EnhancedZoneBank_A37209;

		// Token: 0x04001DA4 RID: 7588
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01768EnhancedZoneBank_A37209Comp;

		// Token: 0x04001DA5 RID: 7589
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;

		// Token: 0x04001DA6 RID: 7590
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;

		// Token: 0x04001DA7 RID: 7591
		internal global::AcpUI.AcpLabel RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;

		// Token: 0x04001DA8 RID: 7592
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;

		// Token: 0x04001DA9 RID: 7593
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;

		// Token: 0x04001DAA RID: 7594
		internal global::AcpUI.AcpLabel RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551Comp;

		// Token: 0x04001DAB RID: 7595
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolAuthentication_A37609;

		// Token: 0x04001DAC RID: 7596
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolAuthentication_A37609;

		// Token: 0x04001DAD RID: 7597
		internal global::AcpUI.AcpLabel RadInfoLabtoolAuthentication_A37609;

		// Token: 0x04001DAE RID: 7598
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolAuthentication_A37609;

		// Token: 0x04001DAF RID: 7599
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolAuthentication_A37609;

		// Token: 0x04001DB0 RID: 7600
		internal global::AcpUI.AcpLabel RadInfoLabtoolAuthentication_A37609Comp;

		// Token: 0x04001DB1 RID: 7601
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658;

		// Token: 0x04001DB2 RID: 7602
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH46G683OneTouchStatusMsg_37658;

		// Token: 0x04001DB3 RID: 7603
		internal global::AcpUI.AcpLabel RadInfoLabtoolH46G683OneTouchStatusMsg_37658;

		// Token: 0x04001DB4 RID: 7604
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658;

		// Token: 0x04001DB5 RID: 7605
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH46G683OneTouchStatusMsg_37658;

		// Token: 0x04001DB6 RID: 7606
		internal global::AcpUI.AcpLabel RadInfoLabtoolH46G683OneTouchStatusMsg_37658Comp;

		// Token: 0x04001DB7 RID: 7607
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660;

		// Token: 0x04001DB8 RID: 7608
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA01771GA01771EnhancementLev2_37660;

		// Token: 0x04001DB9 RID: 7609
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01771GA01771EnhancementLev2_37660;

		// Token: 0x04001DBA RID: 7610
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660;

		// Token: 0x04001DBB RID: 7611
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA01771GA01771EnhancementLev2_37660;

		// Token: 0x04001DBC RID: 7612
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01771GA01771EnhancementLev2_37660Comp;

		// Token: 0x04001DBD RID: 7613
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioInfoLabtoolExtremeNoiseReduction_A37723;

		// Token: 0x04001DBE RID: 7614
		internal global::AcpUI.AcpLabel LblRadioInfoLabtoolExtremeNoiseReduction_A37723;

		// Token: 0x04001DBF RID: 7615
		internal global::AcpUI.AcpLabel RadioInfoLabtoolExtremeNoiseReduction_A37723;

		// Token: 0x04001DC0 RID: 7616
		internal global::AcpUI.AcpRtdButton RTDBtnRadioInfoLabtoolExtremeNoiseReduction_A37723;

		// Token: 0x04001DC1 RID: 7617
		internal global::AcpUI.AcpCopyButton CpyBtnRadioInfoLabtoolExtremeNoiseReduction_A37723;

		// Token: 0x04001DC2 RID: 7618
		internal global::AcpUI.AcpLabel RadioInfoLabtoolExtremeNoiseReduction_A37723Comp;

		// Token: 0x04001DC3 RID: 7619
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH04ConvTacticalRekey_35710;

		// Token: 0x04001DC4 RID: 7620
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH04ConvTacticalRekey_35710;

		// Token: 0x04001DC5 RID: 7621
		internal global::AcpUI.AcpLabel RadInfoLabtoolH04ConvTacticalRekey_35710;

		// Token: 0x04001DC6 RID: 7622
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH04ConvTacticalRekey_35710;

		// Token: 0x04001DC7 RID: 7623
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH04ConvTacticalRekey_35710;

		// Token: 0x04001DC8 RID: 7624
		internal global::AcpUI.AcpLabel RadInfoLabtoolH04ConvTacticalRekey_35710Comp;

		// Token: 0x04001DC9 RID: 7625
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198;

		// Token: 0x04001DCA RID: 7626
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ507G507FCCMANDATE_A38198;

		// Token: 0x04001DCB RID: 7627
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ507G507FCCMANDATE_A38198;

		// Token: 0x04001DCC RID: 7628
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198;

		// Token: 0x04001DCD RID: 7629
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ507G507FCCMANDATE_A38198;

		// Token: 0x04001DCE RID: 7630
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ507G507FCCMANDATE_A38198Comp;

		// Token: 0x04001DCF RID: 7631
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166;

		// Token: 0x04001DD0 RID: 7632
		internal global::AcpUI.AcpLabel LblRadioInfoLabToolQA00631DvrsPsuActivation_A40166;

		// Token: 0x04001DD1 RID: 7633
		internal global::AcpUI.AcpLabel RadioInfoLabToolQA00631DvrsPsuActivation_A40166;

		// Token: 0x04001DD2 RID: 7634
		internal global::AcpUI.AcpRtdButton RTDBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166;

		// Token: 0x04001DD3 RID: 7635
		internal global::AcpUI.AcpCopyButton CpyBtnRadioInfoLabToolQA00631DvrsPsuActivation_A40166;

		// Token: 0x04001DD4 RID: 7636
		internal global::AcpUI.AcpLabel RadioInfoLabToolQA00631DvrsPsuActivation_A40166Comp;

		// Token: 0x04001DD5 RID: 7637
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolManDown_A40006;

		// Token: 0x04001DD6 RID: 7638
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolManDown_A40006;

		// Token: 0x04001DD7 RID: 7639
		internal global::AcpUI.AcpLabel RadInfoLabtoolManDown_A40006;

		// Token: 0x04001DD8 RID: 7640
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolManDown_A40006;

		// Token: 0x04001DD9 RID: 7641
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolManDown_A40006;

		// Token: 0x04001DDA RID: 7642
		internal global::AcpUI.AcpLabel RadInfoLabtoolManDown_A40006Comp;

		// Token: 0x04001DDB RID: 7643
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQ667G193ADPSW_38631;

		// Token: 0x04001DDC RID: 7644
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQ667G193ADPSW_38631;

		// Token: 0x04001DDD RID: 7645
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ667G193ADPSW_38631;

		// Token: 0x04001DDE RID: 7646
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQ667G193ADPSW_38631;

		// Token: 0x04001DDF RID: 7647
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQ667G193ADPSW_38631;

		// Token: 0x04001DE0 RID: 7648
		internal global::AcpUI.AcpLabel RadInfoLabtoolQ667G193ADPSW_38631Comp;

		// Token: 0x04001DE1 RID: 7649
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827;

		// Token: 0x04001DE2 RID: 7650
		internal global::AcpUI.AcpLabel LblRadioInfoLabToolGA00631DvrsMsuOperation_A41827;

		// Token: 0x04001DE3 RID: 7651
		internal global::AcpUI.AcpLabel RadioInfoLabToolGA00631DvrsMsuOperation_A41827;

		// Token: 0x04001DE4 RID: 7652
		internal global::AcpUI.AcpRtdButton RTDBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827;

		// Token: 0x04001DE5 RID: 7653
		internal global::AcpUI.AcpCopyButton CpyBtnRadioInfoLabToolGA00631DvrsMsuOperation_A41827;

		// Token: 0x04001DE6 RID: 7654
		internal global::AcpUI.AcpLabel RadioInfoLabToolGA00631DvrsMsuOperation_A41827Comp;

		// Token: 0x04001DE7 RID: 7655
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632;

		// Token: 0x04001DE8 RID: 7656
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA01770GA01770EnhancementLev1_38632;

		// Token: 0x04001DE9 RID: 7657
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01770GA01770EnhancementLev1_38632;

		// Token: 0x04001DEA RID: 7658
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632;

		// Token: 0x04001DEB RID: 7659
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA01770GA01770EnhancementLev1_38632;

		// Token: 0x04001DEC RID: 7660
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA01770GA01770EnhancementLev1_38632Comp;

		// Token: 0x04001DED RID: 7661
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197;

		// Token: 0x04001DEE RID: 7662
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA02751APXLiRadioTrigger_A41197;

		// Token: 0x04001DEF RID: 7663
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02751APXLiRadioTrigger_A41197;

		// Token: 0x04001DF0 RID: 7664
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197;

		// Token: 0x04001DF1 RID: 7665
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA02751APXLiRadioTrigger_A41197;

		// Token: 0x04001DF2 RID: 7666
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02751APXLiRadioTrigger_A41197Comp;

		// Token: 0x04001DF3 RID: 7667
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;

		// Token: 0x04001DF4 RID: 7668
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;

		// Token: 0x04001DF5 RID: 7669
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;

		// Token: 0x04001DF6 RID: 7670
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;

		// Token: 0x04001DF7 RID: 7671
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;

		// Token: 0x04001DF8 RID: 7672
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198Comp;

		// Token: 0x04001DF9 RID: 7673
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;

		// Token: 0x04001DFA RID: 7674
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;

		// Token: 0x04001DFB RID: 7675
		internal global::AcpUI.AcpLabel RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;

		// Token: 0x04001DFC RID: 7676
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;

		// Token: 0x04001DFD RID: 7677
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;

		// Token: 0x04001DFE RID: 7678
		internal global::AcpUI.AcpLabel RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509Comp;

		// Token: 0x04001DFF RID: 7679
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560;

		// Token: 0x04001E00 RID: 7680
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolH02EncryTacticalInhibit_A41560;

		// Token: 0x04001E01 RID: 7681
		internal global::AcpUI.AcpLabel RadInfoLabtoolH02EncryTacticalInhibit_A41560;

		// Token: 0x04001E02 RID: 7682
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560;

		// Token: 0x04001E03 RID: 7683
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolH02EncryTacticalInhibit_A41560;

		// Token: 0x04001E04 RID: 7684
		internal global::AcpUI.AcpLabel RadInfoLabtoolH02EncryTacticalInhibit_A41560Comp;

		// Token: 0x04001E05 RID: 7685
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolCollaborativePhase1_A41683;

		// Token: 0x04001E06 RID: 7686
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolCollaborativePhase1_A41683;

		// Token: 0x04001E07 RID: 7687
		internal global::AcpUI.AcpLabel RadInfoLabtoolCollaborativePhase1_A41683;

		// Token: 0x04001E08 RID: 7688
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolCollaborativePhase1_A41683;

		// Token: 0x04001E09 RID: 7689
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolCollaborativePhase1_A41683;

		// Token: 0x04001E0A RID: 7690
		internal global::AcpUI.AcpLabel RadInfoLabtoolCollaborativePhase1_A41683Comp;

		// Token: 0x04001E0B RID: 7691
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolV24Software_A41828;

		// Token: 0x04001E0C RID: 7692
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolV24Software_A41828;

		// Token: 0x04001E0D RID: 7693
		internal global::AcpUI.AcpLabel RadInfoLabtoolV24Software_A41828;

		// Token: 0x04001E0E RID: 7694
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolV24Software_A41828;

		// Token: 0x04001E0F RID: 7695
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolV24Software_A41828;

		// Token: 0x04001E10 RID: 7696
		internal global::AcpUI.AcpLabel RadInfoLabtoolV24Software_A41828Comp;

		// Token: 0x04001E11 RID: 7697
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolRSIData_42491;

		// Token: 0x04001E12 RID: 7698
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolRSIData_42491;

		// Token: 0x04001E13 RID: 7699
		internal global::AcpUI.AcpLabel RadInfoLabtoolRSIData_42491;

		// Token: 0x04001E14 RID: 7700
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolRSIData_42491;

		// Token: 0x04001E15 RID: 7701
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolRSIData_42491;

		// Token: 0x04001E16 RID: 7702
		internal global::AcpUI.AcpLabel RadInfoLabtoolRSIData_42491Comp;

		// Token: 0x04001E17 RID: 7703
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolP25CommonAirInterface_A42122;

		// Token: 0x04001E18 RID: 7704
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolP25CommonAirInterface_A42122;

		// Token: 0x04001E19 RID: 7705
		internal global::AcpUI.AcpLabel RadInfoLabtoolP25CommonAirInterface_A42122;

		// Token: 0x04001E1A RID: 7706
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolP25CommonAirInterface_A42122;

		// Token: 0x04001E1B RID: 7707
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolP25CommonAirInterface_A42122;

		// Token: 0x04001E1C RID: 7708
		internal global::AcpUI.AcpLabel RadInfoLabtoolP25CommonAirInterface_A42122Comp;

		// Token: 0x04001E1D RID: 7709
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEnhancedDataOperation_42024;

		// Token: 0x04001E1E RID: 7710
		internal global::AcpUI.AcpLabel LblEnhancedDataOperation_42024;

		// Token: 0x04001E1F RID: 7711
		internal global::AcpUI.AcpLabel EnhancedDataOperation_42024;

		// Token: 0x04001E20 RID: 7712
		internal global::AcpUI.AcpRtdButton RTDBtnEnhancedDataOperation_42024;

		// Token: 0x04001E21 RID: 7713
		internal global::AcpUI.AcpCopyButton CpyBtnEnhancedDataOperation_42024;

		// Token: 0x04001E22 RID: 7714
		internal global::AcpUI.AcpLabel EnhancedDataOperation_42024Comp;

		// Token: 0x04001E23 RID: 7715
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtool00982SiteSelAlertForP25_42052;

		// Token: 0x04001E24 RID: 7716
		internal global::AcpUI.AcpLabel LblRadInfoLabtool00982SiteSelAlertForP25_42052;

		// Token: 0x04001E25 RID: 7717
		internal global::AcpUI.AcpLabel RadInfoLabtool00982SiteSelAlertForP25_42052;

		// Token: 0x04001E26 RID: 7718
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtool00982SiteSelAlertForP25_42052;

		// Token: 0x04001E27 RID: 7719
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtool00982SiteSelAlertForP25_42052;

		// Token: 0x04001E28 RID: 7720
		internal global::AcpUI.AcpLabel RadInfoLabtool00982SiteSelAlertForP25_42052Comp;

		// Token: 0x04001E29 RID: 7721
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolLTEOperation_A41923;

		// Token: 0x04001E2A RID: 7722
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolLTEOperation_A41923;

		// Token: 0x04001E2B RID: 7723
		internal global::AcpUI.AcpLabel RadInfoLabtoolLTEOperation_A41923;

		// Token: 0x04001E2C RID: 7724
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolLTEOperation_A41923;

		// Token: 0x04001E2D RID: 7725
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolLTEOperation_A41923;

		// Token: 0x04001E2E RID: 7726
		internal global::AcpUI.AcpLabel RadInfoLabtoolLTEOperation_A41923Comp;

		// Token: 0x04001E2F RID: 7727
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolDualRadioOperation_A42245;

		// Token: 0x04001E30 RID: 7728
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolDualRadioOperation_A42245;

		// Token: 0x04001E31 RID: 7729
		internal global::AcpUI.AcpLabel RadInfoLabtoolDualRadioOperation_A42245;

		// Token: 0x04001E32 RID: 7730
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolDualRadioOperation_A42245;

		// Token: 0x04001E33 RID: 7731
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolDualRadioOperation_A42245;

		// Token: 0x04001E34 RID: 7732
		internal global::AcpUI.AcpLabel RadInfoLabtoolDualRadioOperation_A42245Comp;

		// Token: 0x04001E35 RID: 7733
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolEncryptedVPNGateway_42279;

		// Token: 0x04001E36 RID: 7734
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolEncryptedVPNGateway_42279;

		// Token: 0x04001E37 RID: 7735
		internal global::AcpUI.AcpLabel RadInfoLabtoolEncryptedVPNGateway_42279;

		// Token: 0x04001E38 RID: 7736
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolEncryptedVPNGateway_42279;

		// Token: 0x04001E39 RID: 7737
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolEncryptedVPNGateway_42279;

		// Token: 0x04001E3A RID: 7738
		internal global::AcpUI.AcpLabel RadInfoLabtoolEncryptedVPNGateway_42279Comp;

		// Token: 0x04001E3B RID: 7739
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolGeoFence_42325;

		// Token: 0x04001E3C RID: 7740
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolGeoFence_42325;

		// Token: 0x04001E3D RID: 7741
		internal global::AcpUI.AcpLabel RadInfoLabtoolGeoFence_42325;

		// Token: 0x04001E3E RID: 7742
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolGeoFence_42325;

		// Token: 0x04001E3F RID: 7743
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolGeoFence_42325;

		// Token: 0x04001E40 RID: 7744
		internal global::AcpUI.AcpLabel RadInfoLabtoolGeoFence_42325Comp;

		// Token: 0x04001E41 RID: 7745
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolAstroAlertingOperHOption;

		// Token: 0x04001E42 RID: 7746
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolAstroAlertingOperHOption;

		// Token: 0x04001E43 RID: 7747
		internal global::AcpUI.AcpLabel RadInfoLabtoolAstroAlertingOperHOption;

		// Token: 0x04001E44 RID: 7748
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolAstroAlertingOperHOption;

		// Token: 0x04001E45 RID: 7749
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolAstroAlertingOperHOption;

		// Token: 0x04001E46 RID: 7750
		internal global::AcpUI.AcpLabel RadInfoLabtoolAstroAlertingOperHOptionComp;

		// Token: 0x04001E47 RID: 7751
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolWiFiCapability_42549;

		// Token: 0x04001E48 RID: 7752
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolWiFiCapability_42549;

		// Token: 0x04001E49 RID: 7753
		internal global::AcpUI.AcpLabel RadInfoLabtoolWiFiCapability_42549;

		// Token: 0x04001E4A RID: 7754
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolWiFiCapability_42549;

		// Token: 0x04001E4B RID: 7755
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolWiFiCapability_42549;

		// Token: 0x04001E4C RID: 7756
		internal global::AcpUI.AcpLabel RadInfoLabtoolWiFiCapability_42549Comp;

		// Token: 0x04001E4D RID: 7757
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolDINCPlusAudio_42670;

		// Token: 0x04001E4E RID: 7758
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolDINCPlusAudio_42670;

		// Token: 0x04001E4F RID: 7759
		internal global::AcpUI.AcpLabel RadInfoLabtoolDINCPlusAudio_42670;

		// Token: 0x04001E50 RID: 7760
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolDINCPlusAudio_42670;

		// Token: 0x04001E51 RID: 7761
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolDINCPlusAudio_42670;

		// Token: 0x04001E52 RID: 7762
		internal global::AcpUI.AcpLabel RadInfoLabtoolDINCPlusAudio_42670Comp;

		// Token: 0x04001E53 RID: 7763
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolGroupServices_42787;

		// Token: 0x04001E54 RID: 7764
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolGroupServices_42787;

		// Token: 0x04001E55 RID: 7765
		internal global::AcpUI.AcpLabel RadInfoLabtoolGroupServices_42787;

		// Token: 0x04001E56 RID: 7766
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolGroupServices_42787;

		// Token: 0x04001E57 RID: 7767
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolGroupServices_42787;

		// Token: 0x04001E58 RID: 7768
		internal global::AcpUI.AcpLabel RadInfoLabtoolGroupServices_42787Comp;

		// Token: 0x04001E59 RID: 7769
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852;

		// Token: 0x04001E5A RID: 7770
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolMotoVMLDataModemTethering_A42852;

		// Token: 0x04001E5B RID: 7771
		internal global::AcpUI.AcpLabel RadInfoLabtoolMotoVMLDataModemTethering_A42852;

		// Token: 0x04001E5C RID: 7772
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852;

		// Token: 0x04001E5D RID: 7773
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolMotoVMLDataModemTethering_A42852;

		// Token: 0x04001E5E RID: 7774
		internal global::AcpUI.AcpLabel RadInfoLabtoolMotoVMLDataModemTethering_A42852Comp;

		// Token: 0x04001E5F RID: 7775
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolThirdPartyModemTethering_A43043;

		// Token: 0x04001E60 RID: 7776
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolThirdPartyModemTethering_A43043;

		// Token: 0x04001E61 RID: 7777
		internal global::AcpUI.AcpLabel RadInfoLabtoolThirdPartyModemTethering_A43043;

		// Token: 0x04001E62 RID: 7778
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolThirdPartyModemTethering_A43043;

		// Token: 0x04001E63 RID: 7779
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolThirdPartyModemTethering_A43043;

		// Token: 0x04001E64 RID: 7780
		internal global::AcpUI.AcpLabel RadInfoLabtoolThirdPartyModemTethering_A43043Comp;

		// Token: 0x04001E65 RID: 7781
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolMissionCriticalGeofencing_A43013;

		// Token: 0x04001E66 RID: 7782
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolMissionCriticalGeofencing_A43013;

		// Token: 0x04001E67 RID: 7783
		internal global::AcpUI.AcpLabel RadInfoLabtoolMissionCriticalGeofencing_A43013;

		// Token: 0x04001E68 RID: 7784
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolMissionCriticalGeofencing_A43013;

		// Token: 0x04001E69 RID: 7785
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolMissionCriticalGeofencing_A43013;

		// Token: 0x04001E6A RID: 7786
		internal global::AcpUI.AcpLabel RadInfoLabtoolMissionCriticalGeofencing_A43013Comp;

		// Token: 0x04001E6B RID: 7787
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolSWAES_A43013;

		// Token: 0x04001E6C RID: 7788
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolSWAES_A43013;

		// Token: 0x04001E6D RID: 7789
		internal global::AcpUI.AcpLabel RadInfoLabtoolSWAES_A43013;

		// Token: 0x04001E6E RID: 7790
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolSWAES_A43013;

		// Token: 0x04001E6F RID: 7791
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolSWAES_A43013;

		// Token: 0x04001E70 RID: 7792
		internal global::AcpUI.AcpLabel RadInfoLabtoolSWAES_A43013Comp;

		// Token: 0x04001E71 RID: 7793
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolNightVisionGoggle_43542;

		// Token: 0x04001E72 RID: 7794
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolNightVisionGoggle_43542;

		// Token: 0x04001E73 RID: 7795
		internal global::AcpUI.AcpLabel RadInfoLabtoolNightVisionGoggle_43542;

		// Token: 0x04001E74 RID: 7796
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolNightVisionGoggle_43542;

		// Token: 0x04001E75 RID: 7797
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolNightVisionGoggle_43542;

		// Token: 0x04001E76 RID: 7798
		internal global::AcpUI.AcpLabel RadInfoLabtoolNightVisionGoggle_43542Comp;

		// Token: 0x04001E77 RID: 7799
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA07516NYPDTrigger_43587;

		// Token: 0x04001E78 RID: 7800
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA07516NYPDTrigger_43587;

		// Token: 0x04001E79 RID: 7801
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA07516NYPDTrigger_43587;

		// Token: 0x04001E7A RID: 7802
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA07516NYPDTrigger_43587;

		// Token: 0x04001E7B RID: 7803
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA07516NYPDTrigger_43587;

		// Token: 0x04001E7C RID: 7804
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA07516NYPDTrigger_43587Comp;

		// Token: 0x04001E7D RID: 7805
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Value;

		// Token: 0x04001E7E RID: 7806
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Value;

		// Token: 0x04001E7F RID: 7807
		internal global::AcpUI.AcpLabel RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745;

		// Token: 0x04001E80 RID: 7808
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745;

		// Token: 0x04001E81 RID: 7809
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745;

		// Token: 0x04001E82 RID: 7810
		internal global::AcpUI.AcpLabel RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745Comp;

		// Token: 0x04001E83 RID: 7811
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED_VALUE;

		// Token: 0x04001E84 RID: 7812
		internal global::AcpUI.AcpLabel LblRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED_VALUE;

		// Token: 0x04001E85 RID: 7813
		internal global::AcpUI.AcpLabel RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED;

		// Token: 0x04001E86 RID: 7814
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED;

		// Token: 0x04001E87 RID: 7815
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED;

		// Token: 0x04001E88 RID: 7816
		internal global::AcpUI.AcpLabel RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLEDComp;

		// Token: 0x04001E89 RID: 7817
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;

		// Token: 0x04001E8A RID: 7818
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;

		// Token: 0x04001E8B RID: 7819
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;

		// Token: 0x04001E8C RID: 7820
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;

		// Token: 0x04001E8D RID: 7821
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;

		// Token: 0x04001E8E RID: 7822
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695Comp;

		// Token: 0x04001E8F RID: 7823
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioInfoLabToolGermanFedGovEnabled_43792;

		// Token: 0x04001E90 RID: 7824
		internal global::AcpUI.AcpLabel LblRadioInfoLabToolGermanFedGovEnabled_43792;

		// Token: 0x04001E91 RID: 7825
		internal global::AcpUI.AcpLabel RadioInfoLabToolGermanFedGovEnabled_43792;

		// Token: 0x04001E92 RID: 7826
		internal global::AcpUI.AcpRtdButton RTDBtnRadioInfoLabToolGermanFedGovEnabled_43792;

		// Token: 0x04001E93 RID: 7827
		internal global::AcpUI.AcpCopyButton CpyBtnRadioInfoLabToolGermanFedGovEnabled_43792;

		// Token: 0x04001E94 RID: 7828
		internal global::AcpUI.AcpLabel RadioInfoLabToolGermanFedGovEnabled_43792Comp;

		// Token: 0x04001E95 RID: 7829
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolUUID_42562;

		// Token: 0x04001E96 RID: 7830
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolUUID_42562;

		// Token: 0x04001E97 RID: 7831
		internal global::AcpUI.AcpLabel RadInfoLabtoolUUID_42562;

		// Token: 0x04001E98 RID: 7832
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolUUID_42562;

		// Token: 0x04001E99 RID: 7833
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolUUID_42562;

		// Token: 0x04001E9A RID: 7834
		internal global::AcpUI.AcpLabel RadInfoLabtoolUUID_42562Comp;

		// Token: 0x04001E9B RID: 7835
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolPID;

		// Token: 0x04001E9C RID: 7836
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolPID;

		// Token: 0x04001E9D RID: 7837
		internal global::AcpUI.AcpLabel RadInfoLabtoolPID;

		// Token: 0x04001E9E RID: 7838
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolPID;

		// Token: 0x04001E9F RID: 7839
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolPID;

		// Token: 0x04001EA0 RID: 7840
		internal global::AcpUI.AcpLabel RadInfoLabtoolPIDComp;

		// Token: 0x04001EA1 RID: 7841
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolSmartConnect_43719;

		// Token: 0x04001EA2 RID: 7842
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolSmartConnect_43719;

		// Token: 0x04001EA3 RID: 7843
		internal global::AcpUI.AcpLabel RadInfoLabtoolSmartConnect_43719;

		// Token: 0x04001EA4 RID: 7844
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolSmartConnect_43719;

		// Token: 0x04001EA5 RID: 7845
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolSmartConnect_43719;

		// Token: 0x04001EA6 RID: 7846
		internal global::AcpUI.AcpLabel RadInfoLabtoolSmartConnect_43719Comp;

		// Token: 0x04001EA7 RID: 7847
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;

		// Token: 0x04001EA8 RID: 7848
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;

		// Token: 0x04001EA9 RID: 7849
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;

		// Token: 0x04001EAA RID: 7850
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;

		// Token: 0x04001EAB RID: 7851
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;

		// Token: 0x04001EAC RID: 7852
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771Comp;

		// Token: 0x04001EAD RID: 7853
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolProductModelIdentifier_A37178;

		// Token: 0x04001EAE RID: 7854
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolProductModelIdentifier_A37178;

		// Token: 0x04001EAF RID: 7855
		internal global::AcpUI.AcpLabel RadInfoLabtoolProductModelIdentifier_A37178;

		// Token: 0x04001EB0 RID: 7856
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolProductModelIdentifier_A37178;

		// Token: 0x04001EB1 RID: 7857
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolProductModelIdentifier_A37178;

		// Token: 0x04001EB2 RID: 7858
		internal global::AcpUI.AcpLabel RadInfoLabtoolProductModelIdentifier_A37178Comp;

		// Token: 0x04001EB3 RID: 7859
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolSmartConnectOverBroadband_43720;

		// Token: 0x04001EB4 RID: 7860
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolSmartConnectOverBroadband_43720;

		// Token: 0x04001EB5 RID: 7861
		internal global::AcpUI.AcpLabel RadInfoLabtoolSmartConnectOverBroadband_43720;

		// Token: 0x04001EB6 RID: 7862
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolSmartConnectOverBroadband_43720;

		// Token: 0x04001EB7 RID: 7863
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolSmartConnectOverBroadband_43720;

		// Token: 0x04001EB8 RID: 7864
		internal global::AcpUI.AcpLabel RadInfoLabtoolSmartConnectOverBroadband_43720Comp;

		// Token: 0x04001EB9 RID: 7865
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA09028ViQi_VoiceControl;

		// Token: 0x04001EBA RID: 7866
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA09028ViQi_VoiceControl;

		// Token: 0x04001EBB RID: 7867
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA09028ViQi_VoiceControl;

		// Token: 0x04001EBC RID: 7868
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA09028ViQi_VoiceControl;

		// Token: 0x04001EBD RID: 7869
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA09028ViQi_VoiceControl;

		// Token: 0x04001EBE RID: 7870
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA09028ViQi_VoiceControlComp;

		// Token: 0x04001EBF RID: 7871
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolAPX1500EHNO3CH_A44832;

		// Token: 0x04001EC0 RID: 7872
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolAPX1500EHNO3CH_A44832;

		// Token: 0x04001EC1 RID: 7873
		internal global::AcpUI.AcpLabel RadInfoLabtoolAPX1500EHNO3CH_A44832;

		// Token: 0x04001EC2 RID: 7874
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolAPX1500EHNO3CH_A44832;

		// Token: 0x04001EC3 RID: 7875
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolAPX1500EHNO3CH_A44832;

		// Token: 0x04001EC4 RID: 7876
		internal global::AcpUI.AcpLabel RadInfoLabtoolAPX1500EHNO3CH_A44832Comp;

		// Token: 0x04001EC5 RID: 7877
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolAtakHOption_HA00680;

		// Token: 0x04001EC6 RID: 7878
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolAtakHOption_HA00680;

		// Token: 0x04001EC7 RID: 7879
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolAtakHOption_HA00680;

		// Token: 0x04001EC8 RID: 7880
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolAtakHOption_HA00680;

		// Token: 0x04001EC9 RID: 7881
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolAtakHOption_HA00680;

		// Token: 0x04001ECA RID: 7882
		internal global::AcpUI.AcpCheckBox RadInfoLabtoolAtakHOption_HA00680Comp;

		// Token: 0x04001ECB RID: 7883
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolLTEHWEnablement_QA08887;

		// Token: 0x04001ECC RID: 7884
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolLTEHWEnablement_QA08887;

		// Token: 0x04001ECD RID: 7885
		internal global::AcpUI.AcpLabel RadInfoLabtoolLTEHWEnablement_QA08887;

		// Token: 0x04001ECE RID: 7886
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolLTEHWEnablement_QA08887;

		// Token: 0x04001ECF RID: 7887
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolLTEHWEnablement_QA08887;

		// Token: 0x04001ED0 RID: 7888
		internal global::AcpUI.AcpLabel RadInfoLabtoolLTEHWEnablement_QA08887Comp;

		// Token: 0x04001ED1 RID: 7889
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume;

		// Token: 0x04001ED2 RID: 7890
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolQA08676_AdaptiveSpeakerVolume;

		// Token: 0x04001ED3 RID: 7891
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA08676_AdaptiveSpeakerVolume;

		// Token: 0x04001ED4 RID: 7892
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume;

		// Token: 0x04001ED5 RID: 7893
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolQA08676_AdaptiveSpeakerVolume;

		// Token: 0x04001ED6 RID: 7894
		internal global::AcpUI.AcpLabel RadInfoLabtoolQA08676_AdaptiveSpeakerVolumeComp;

		// Token: 0x04001ED7 RID: 7895
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoLabtoolTacticalServicesHOption;

		// Token: 0x04001ED8 RID: 7896
		internal global::AcpUI.AcpLabel LblRadInfoLabtoolTacticalServicesHOption;

		// Token: 0x04001ED9 RID: 7897
		internal global::AcpUI.AcpLabel RadInfoLabtoolTacticalServicesHOption;

		// Token: 0x04001EDA RID: 7898
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoLabtoolTacticalServicesHOption;

		// Token: 0x04001EDB RID: 7899
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoLabtoolTacticalServicesHOption;

		// Token: 0x04001EDC RID: 7900
		internal global::AcpUI.AcpLabel RadInfoLabtoolTacticalServicesHOptionComp;

		// Token: 0x04001EDD RID: 7901
		private bool b;
	}
}
