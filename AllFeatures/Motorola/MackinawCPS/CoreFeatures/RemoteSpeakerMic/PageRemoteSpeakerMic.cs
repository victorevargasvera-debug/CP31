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

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002D9 RID: 729
	public class PageRemoteSpeakerMic : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060077FA RID: 30714 RVA: 0x006CECA0 File Offset: 0x006CCEA0
		public PageRemoteSpeakerMic()
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

		// Token: 0x060077FB RID: 30715 RVA: 0x006CECD8 File Offset: 0x006CCED8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)383320064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)827457537;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
						goto IL_AB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 2:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1289093126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					}
					case 3:
						IL_D6:
						try
						{
							num = (short)569311233;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2AF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F2;
									}
									continue;
								case 3:
									num = (short)1778647040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1812070403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)747634694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)347537410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (acpExpander != null)
									{
										num = (short)1237385221;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_1F4:
								num = (short)1261240324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F2:
								goto IL_1F4;
							}
							IL_2AF:
							goto IL_120;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2D1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2BE:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1205600257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_32A;
								case 1:
									disposable.Dispose();
									num = (short)349634562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_328;
								}
								goto IL_2D1;
							}
							IL_328:
							IL_32A:
							goto EndFinally_8;
							IL_2D1:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)794427392;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2BE;
							EndFinally_8:;
						}
						goto IL_32B;
						IL_120:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1399652357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1123811329;
						if (num != 0)
						{
						}
						object obj = null;
						obj = this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.MyRecordsetDataSource;
						num = (short)1121845250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)445251584;
						short num3 = num;
						goto IL_32B;
					}
					case 6:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.MyDataPresenter = this.ExpanderRemoteSpeakerMicRSMButton;
						num = (short)1588002816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5F:
					if (!this.a)
					{
						num = (short)1819934724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32B;
					IL_AB:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)2100690947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32B:
					num = (short)1220521332;
					short num4 = num;
					num = (short)808430964;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						goto IL_360;
					}
				}
				IL_360:
				num = (short)1915355136;
				if (num != 0)
				{
				}
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x006CF090 File Offset: 0x006CD290
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
					if (this.a)
					{
						num2 = (short)692060161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_DD;
				case 2:
					goto IL_105;
				}
				goto IL_1C;
			}
			IL_DD:
			base.OnUnloaded(sender, e);
			this.a = false;
			goto IL_EE;
			IL_105:
			num2 = (short)274006016;
			short num3 = num2;
			return;
			IL_1C:
			num2 = (short)1830223873;
			if (num2 != 0)
			{
			}
			num2 = (short)198550457;
			short num4 = num2;
			num2 = (short)1256825785;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_EE:
				num2 = (short)1558773762;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)154664960;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.DataContext = null;
				this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.MyDataPresenter = null;
				num2 = (short)610598912;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x006CF1D0 File Offset: 0x006CD3D0
		public override void SetDataContext()
		{
			short num = (short)480313353;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)279773192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton).MySecondaryRecordsetDataSource = null;
					num = (short)1362427918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_30B;
				case 2:
					goto IL_30B;
				case 3:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)2130968588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)1375010816;
					short num3 = num;
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2036);
					num = (short)519503874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)2092040193;
					if (num != 0)
					{
					}
					num = (short)427754460;
					short num4 = num;
					num = (short)1596392412;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E9;
					default:
						num = (short)769130496;
						if (num != 0)
						{
						}
						if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10079].EmbeddedRecset != null)
						{
							num = (short)1663631366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 6:
					goto IL_172;
				case 7:
					goto IL_2E9;
				case 8:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2036);
					num = (short)723517447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 10:
					num = (short)831193093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10079] != null)
					{
						num = (short)1908146186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					num = (short)753991691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)298057731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					return;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1758658564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2036);
				num = (short)551092225;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E9:
				if (feature != null)
				{
					num = (short)1163329549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_30B:
				num = (short)2099642368;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_172:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10079].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton).SyncDataSources();
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x006CF528 File Offset: 0x006CD728
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1633615875;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)480706565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.MyRecordsetDataSource;
					num = (short)1027604486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_EB;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 4:
					num = (short)1513095175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)2123104256;
					short num3 = num;
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鿹釻釽瓿朁圃瘅洇欉朋欍戏弑紓甕䨗䤙儛尝唟嘡倣䤥䘧", a_))
					{
						num = (short)395968516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				}
				case 6:
					IL_CC:
					if (myRecordsetDataSource != null)
					{
						num = (short)689045506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 7:
					num = (short)1385365505;
					if (num != 0)
					{
					}
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)128122881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1575813128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1FB;
				}
				IL_51:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1018036224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1FB:
				num = (short)860101608;
				short num4 = num;
				num = (short)2038963176;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CC;
				default:
					goto IL_230;
				}
			}
			IL_EB:
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
			return;
			IL_230:
			num = (short)79036416;
			if (num != 0)
			{
			}
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x006CF77C File Offset: 0x006CD97C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)526712832;
			short num2 = num;
			num = (short)133698850;
			short num3 = num;
			num = (short)821105954;
			switch (num3 == num)
			{
			}
			num = (short)2062942208;
			if (num != 0)
			{
			}
			num = (short)601030657;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x006CF82C File Offset: 0x006CDA2C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2120810496;
			short num2 = num;
			num = (short)2137846236;
			short num3 = num;
			num = (short)396685788;
			switch (num3 == num)
			{
			}
			num = (short)621871105;
			if (num != 0)
			{
			}
			num = (short)530972672;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x006CF8DC File Offset: 0x006CDADC
		internal void OnExpanderRemoteSpeakerMicRSMButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)579272705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_158;
				case 1:
					goto IL_CF;
				case 2:
					goto IL_106;
				}
				goto IL_1C;
			}
			IL_CF:
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner item;
			((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
			this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.SyncDataSources();
			goto IL_EE;
			IL_106:
			num2 = (short)1033633793;
			if (num2 != 0)
			{
			}
			num2 = (short)2144075776;
			short num3 = num2;
			IL_158:
			this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1516244739;
			short num4 = num2;
			num2 = (short)1279987459;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_EE:
				num2 = (short)473104386;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1164640256;
				if (num2 != 0)
				{
				}
				item = (global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.MyRecordsetDataSource;
				num2 = (short)1514668032;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x006CFA50 File Offset: 0x006CDC50
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			while (this.b)
			{
				short num = (short)158400512;
				short num2 = num;
				num = (short)240136918;
				short num3 = num;
				num = (short)1932079830;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)534183937;
					if (num != 0)
					{
					}
					num = (short)150667264;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2蛤裦蓨鯪苬臮铰鷲致\ud8f6诸髺駼雾渀☂㜄㜆氈礊樌怎缐簒研縖稘栚㠜ⴞᄠ䀢䨤䤦伨䈪䨬娮䌰刲䄴帶嘸唺ሼ尾⹀ⵂㅄ㕆♈❊㹌恎⍐㙒㡔㡖ⵘ㹚硜浞兠ၢᕤɦࡨj࡬ᵮ呰䅲䕴᩶ၸ᡺剼ൾﶌﺜ놞\ud9a0슢좤쮦", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x006CFB34 File Offset: 0x006CDD34
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)332988416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)481230850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2A3;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_48D;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					goto IL_763;
				case 10:
					goto IL_3C7;
				case 11:
					goto IL_725;
				case 12:
					goto IL_749;
				case 13:
					goto IL_509;
				case 14:
					goto IL_5EA;
				case 15:
					goto IL_480;
				case 16:
					goto IL_1CB;
				case 17:
					goto IL_4EF;
				case 18:
					goto IL_2B5;
				case 19:
					goto IL_59F;
				case 20:
					goto IL_2A8;
				case 21:
					goto IL_516;
				case 22:
					goto IL_1B1;
				case 23:
					goto IL_362;
				case 24:
					goto IL_216;
				case 25:
					goto IL_2C2;
				case 26:
					goto IL_389;
				case 27:
					goto IL_396;
				case 28:
					goto IL_37C;
				case 29:
					goto IL_33E;
				case 30:
					goto IL_4E2;
				case 31:
					goto IL_6DA;
				case 32:
					goto IL_41E;
				case 33:
					goto IL_530;
				case 34:
					goto IL_300;
				case 35:
					goto IL_30D;
				case 36:
					goto IL_44F;
				case 37:
					goto IL_23D;
				case 38:
					goto IL_6CD;
				case 39:
					goto IL_5D0;
				case 40:
					goto IL_635;
				case 41:
					goto IL_3D4;
				case 42:
					goto IL_628;
				case 43:
					goto IL_3A3;
				case 44:
					goto IL_642;
				case 45:
					goto IL_61B;
				case 46:
					goto IL_1A4;
				case 47:
					goto IL_1F2;
				case 48:
					goto IL_5DD;
				case 49:
					goto IL_5AC;
				case 50:
					goto IL_718;
				case 51:
					goto IL_331;
				case 52:
					goto IL_523;
				case 53:
					goto IL_69C;
				case 54:
					goto IL_1D8;
				case 55:
					goto IL_180;
				case 56:
					goto IL_6FE;
				case 57:
					goto IL_60E;
				case 58:
					goto IL_561;
				case 59:
					goto IL_42B;
				case 60:
					goto IL_4FC;
				case 61:
					goto IL_2DC;
				case 62:
					goto IL_70B;
				case 63:
					goto IL_1BE;
				case 64:
					goto IL_36F;
				case 65:
					goto IL_53D;
				case 66:
					goto IL_45C;
				case 67:
					goto IL_223;
				case 68:
					goto IL_2CF;
				case 69:
					goto IL_56E;
				case 70:
					goto IL_1E5;
				case 71:
					goto IL_4BE;
				case 72:
					goto IL_57B;
				case 73:
					goto IL_6C0;
				case 74:
					goto IL_230;
				case 75:
					goto IL_756;
				default:
					num = (short)1654194177;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_180:
			this.LblRadErgoCfgRSMlTrunkingFeature_A19742 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMlTrunkingFeature_A19742.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A4:
			this.RadErgoCfgRSMlConventionalFeature_A19640Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B1:
			this.RadErgoCfgRSMTrunkingBCO_A19741_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1BE:
			this.RadErgoCfgRSMButtonKey_A22526Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CB:
			this.ExpanderRemoteSpeakerMicRSMButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1D8:
			this.CVBtnRadErgoCfgRSMlTrunkingFeature_A19742 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E5:
			this.CVBtnRadErgoCfgRSMlTopButtonLongPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F2:
			this.RadErgoCfgRSMTrunkingBCO_A19741 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgRSMTrunkingBCO_A19741.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_216:
			this.RadErgoCfgRSMButtonKey_A22526_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_223:
			this.RTDBtnRadErgoCfgRSMlTopButtonShortPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_230:
			this.CpyBtnRadErgoCfgRSMlTopButtonLongPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23D:
			num = (short)819265536;
			short num3 = num;
			this.LblRadErgoCfgRSMConventionalBCO_A19639 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMConventionalBCO_A19639.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A3:
			goto IL_763;
			IL_2A8:
			this.RadErgoCfgRSMConventionalBCO_A19639_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2B5:
			this.ExpanderRemoteSpeakerMicRSMButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2C2:
			this.RadErgoCfgRSMlTopButtonShortPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2CF:
			this.CpyBtnRadErgoCfgRSMlTopButtonShortPressTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DC:
			this.LblRadErgoCfgRSMButtonKey_A22526 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMButtonKey_A22526.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_300:
			this.RadErgoCfgRSMButtonName_A22527Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30D:
			this.RadErgoCfgRSMConventionalBCO_A19639 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgRSMConventionalBCO_A19639.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_331:
			this.CpyBtnRadErgoCfgRSMTrunkingBCO_A19741 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33E:
			this.RadErgoCfgRSMButtonName_A22527 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgRSMButtonName_A22527.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_362:
			this.RadErgoCfgRSMlTrunkingFeature_A19742_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_36F:
			this.CVBtnRadErgoCfgRSMlTopButtonShortPressTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37C:
			this.gridExpanderRemoteSpeakerMicRSMButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_389:
			this.RadErgoCfgRSMlTopButtonLongPressTime_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_396:
			this.ExpanderRemoteSpeakerMicRSMButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3A3:
			this.LblRadErgoCfgRSMlConventionalFeature_A19640 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMlConventionalFeature_A19640.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_3D4:
			num = (short)303038465;
			if (num != 0)
			{
			}
			this.RadErgoCfgRSMlConventionalFeature_A19640 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgRSMlConventionalFeature_A19640.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_41E:
			this.RTDBtnRadErgoCfgRSMButtonName_A22527 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42B:
			this.RadErgoCfgRSMButtonKey_A22526 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgRSMButtonKey_A22526.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_44F:
			this.CVBtnRadErgoCfgRSMConventionalBCO_A19639 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_45C:
			this.RadErgoCfgRSMlTopButtonShortPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoCfgRSMlTopButtonShortPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_480:
			this.ExpanderRemoteSpeakerMicGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_48D:
			((global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.PageRemoteSpeakerMic)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.PageRemoteSpeakerMic)target).Unloaded += this.OnUnloaded;
			return;
			IL_4BE:
			this.LblRadErgoCfgRSMlTopButtonLongPressTime = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMlTopButtonLongPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E2:
			this.CVBtnRadErgoCfgRSMButtonName_A22527 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4EF:
			this.ExpanderRemoteSpeakerMicRSMButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4FC:
			this.CVBtnRadErgoCfgRSMButtonKey_A22526 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_509:
			this.ExpanderRemoteSpeakerMicGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_516:
			this.RadErgoCfgRSMlConventionalFeature_A19640_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_523:
			this.RadErgoCfgRSMTrunkingBCO_A19741Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_530:
			this.CpyBtnRadErgoCfgRSMButtonName_A22527 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53D:
			this.LblRadErgoCfgRSMlTopButtonShortPressTime = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMlTopButtonShortPressTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_561:
			this.RadErgoCfgRSMlTrunkingFeature_A19742Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_56E:
			this.RadErgoCfgRSMlTopButtonShortPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_57B:
			this.RadErgoCfgRSMlTopButtonLongPressTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoCfgRSMlTopButtonLongPressTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59F:
			this.RadErgoCfgRSMButtonName_A22527_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5AC:
			this.LblRadErgoCfgRSMTrunkingBCO_A19741 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMTrunkingBCO_A19741.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D0:
			this.CpyBtnRadErgoCfgRSMConventionalBCO_A19639 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5DD:
			this.CVBtnRadErgoCfgRSMTrunkingBCO_A19741 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EA:
			this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRemoteSpeakerMicRSMButton.ModeClick += this.OnModeClick;
			return;
			IL_60E:
			this.CpyBtnRadErgoCfgRSMlTrunkingFeature_A19742 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61B:
			this.CpyBtnRadErgoCfgRSMlConventionalFeature_A19640 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_628:
			this.CVBtnRadErgoCfgRSMlConventionalFeature_A19640 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_635:
			this.RadErgoCfgRSMConventionalBCO_A19639Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_642:
			num = (short)336893447;
			short num4 = num;
			num = (short)1780585991;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_530;
			default:
				num = (short)1210843136;
				if (num != 0)
				{
				}
				this.RTDBtnRadErgoCfgRSMlConventionalFeature_A19640 = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_69C:
			this.RadErgoCfgRSMlTrunkingFeature_A19742 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgRSMlTrunkingFeature_A19742.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C0:
			this.RTDBtnRadErgoCfgRSMlTopButtonLongPressTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6CD:
			this.RTDBtnRadErgoCfgRSMConventionalBCO_A19639 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6DA:
			this.LblRadErgoCfgRSMButtonName_A22527 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgRSMButtonName_A22527.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6FE:
			this.RTDBtnRadErgoCfgRSMlTrunkingFeature_A19742 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_70B:
			this.CpyBtnRadErgoCfgRSMButtonKey_A22526 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_718:
			this.RTDBtnRadErgoCfgRSMTrunkingBCO_A19741 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_725:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_749:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_756:
			this.RadErgoCfgRSMlTopButtonLongPressTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_763:
			this.b = true;
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x006D02AC File Offset: 0x006CE4AC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
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
				break;
			case 6:
			{
				short num = (short)951458358;
				short num2 = num;
				num = (short)846731830;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1487601665;
					if (num != 0)
					{
					}
					num = (short)904527872;
					short num3 = num;
					num = (short)204537856;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 7:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040032B2 RID: 12978
		private bool a;

		// Token: 0x040032B3 RID: 12979
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040032B4 RID: 12980
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040032B5 RID: 12981
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040032B6 RID: 12982
		internal global::AcpUI.AcpExpander ExpanderRemoteSpeakerMicGeneral;

		// Token: 0x040032B7 RID: 12983
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRemoteSpeakerMicRSMButton;

		// Token: 0x040032B8 RID: 12984
		internal global::System.Windows.Controls.Grid ExpanderRemoteSpeakerMicGeneralGrid;

		// Token: 0x040032B9 RID: 12985
		internal global::System.Windows.Controls.Grid ExpanderRemoteSpeakerMicRSMButtonGrid;

		// Token: 0x040032BA RID: 12986
		internal global::AcpUI.AcpGroupBox ExpanderRemoteSpeakerMicRSMButtonTableView;

		// Token: 0x040032BB RID: 12987
		internal global::AcpUI.AcpXamDataPresenter ExpanderRemoteSpeakerMicRSMButton;

		// Token: 0x040032BC RID: 12988
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMButtonName_A22527_Col;

		// Token: 0x040032BD RID: 12989
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMConventionalBCO_A19639_Col;

		// Token: 0x040032BE RID: 12990
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMlConventionalFeature_A19640_Col;

		// Token: 0x040032BF RID: 12991
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMTrunkingBCO_A19741_Col;

		// Token: 0x040032C0 RID: 12992
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMlTrunkingFeature_A19742_Col;

		// Token: 0x040032C1 RID: 12993
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMButtonKey_A22526_Col;

		// Token: 0x040032C2 RID: 12994
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMlTopButtonShortPressTime_Col;

		// Token: 0x040032C3 RID: 12995
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgRSMlTopButtonLongPressTime_Col;

		// Token: 0x040032C4 RID: 12996
		internal global::AcpUI.AcpGroupBox ExpanderRemoteSpeakerMicRSMButtonSRecView;

		// Token: 0x040032C5 RID: 12997
		internal global::System.Windows.Controls.Grid gridExpanderRemoteSpeakerMicRSMButtonSRecView;

		// Token: 0x040032C6 RID: 12998
		internal global::AcpUI.AcpLabel RadErgoCfgRSMButtonName_A22527;

		// Token: 0x040032C7 RID: 12999
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMButtonName_A22527;

		// Token: 0x040032C8 RID: 13000
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMButtonName_A22527;

		// Token: 0x040032C9 RID: 13001
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMButtonName_A22527;

		// Token: 0x040032CA RID: 13002
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMButtonName_A22527;

		// Token: 0x040032CB RID: 13003
		internal global::AcpUI.AcpLabel RadErgoCfgRSMButtonName_A22527Comp;

		// Token: 0x040032CC RID: 13004
		internal global::AcpUI.AcpComboBox RadErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032CD RID: 13005
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032CE RID: 13006
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032CF RID: 13007
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032D0 RID: 13008
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032D1 RID: 13009
		internal global::AcpUI.AcpLabel RadErgoCfgRSMConventionalBCO_A19639Comp;

		// Token: 0x040032D2 RID: 13010
		internal global::AcpUI.AcpComboBox RadErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x040032D3 RID: 13011
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x040032D4 RID: 13012
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x040032D5 RID: 13013
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x040032D6 RID: 13014
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x040032D7 RID: 13015
		internal global::AcpUI.AcpLabel RadErgoCfgRSMlConventionalFeature_A19640Comp;

		// Token: 0x040032D8 RID: 13016
		internal global::AcpUI.AcpComboBox RadErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032D9 RID: 13017
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032DA RID: 13018
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032DB RID: 13019
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032DC RID: 13020
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032DD RID: 13021
		internal global::AcpUI.AcpLabel RadErgoCfgRSMTrunkingBCO_A19741Comp;

		// Token: 0x040032DE RID: 13022
		internal global::AcpUI.AcpComboBox RadErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x040032DF RID: 13023
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x040032E0 RID: 13024
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x040032E1 RID: 13025
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x040032E2 RID: 13026
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x040032E3 RID: 13027
		internal global::AcpUI.AcpLabel RadErgoCfgRSMlTrunkingFeature_A19742Comp;

		// Token: 0x040032E4 RID: 13028
		internal global::AcpUI.AcpTextBox RadErgoCfgRSMButtonKey_A22526;

		// Token: 0x040032E5 RID: 13029
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMButtonKey_A22526;

		// Token: 0x040032E6 RID: 13030
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMButtonKey_A22526;

		// Token: 0x040032E7 RID: 13031
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMButtonKey_A22526;

		// Token: 0x040032E8 RID: 13032
		internal global::AcpUI.AcpLabel RadErgoCfgRSMButtonKey_A22526Comp;

		// Token: 0x040032E9 RID: 13033
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032EA RID: 13034
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032EB RID: 13035
		internal global::AcpUI.AcpTextBoxSpinner RadErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032EC RID: 13036
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032ED RID: 13037
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032EE RID: 13038
		internal global::AcpUI.AcpLabel RadErgoCfgRSMlTopButtonShortPressTimeComp;

		// Token: 0x040032EF RID: 13039
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgRSMlTopButtonLongPressTime;

		// Token: 0x040032F0 RID: 13040
		internal global::AcpUI.AcpLabel LblRadErgoCfgRSMlTopButtonLongPressTime;

		// Token: 0x040032F1 RID: 13041
		internal global::AcpUI.AcpTextBoxSpinner RadErgoCfgRSMlTopButtonLongPressTime;

		// Token: 0x040032F2 RID: 13042
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgRSMlTopButtonLongPressTime;

		// Token: 0x040032F3 RID: 13043
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgRSMlTopButtonLongPressTime;

		// Token: 0x040032F4 RID: 13044
		internal global::AcpUI.AcpLabel RadErgoCfgRSMlTopButtonLongPressTimeComp;

		// Token: 0x040032F5 RID: 13045
		private bool b;
	}
}
