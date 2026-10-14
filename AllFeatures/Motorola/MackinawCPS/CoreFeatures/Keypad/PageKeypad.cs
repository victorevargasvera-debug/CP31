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
using ControlHeadGraphicView;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000301 RID: 769
	public class PageKeypad : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06007AC1 RID: 31425 RVA: 0x006FE2E4 File Offset: 0x006FC4E4
		public PageKeypad()
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

		// Token: 0x06007AC2 RID: 31426 RVA: 0x006FE31C File Offset: 0x006FC51C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)921370624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					IL_1E:
					num = (short)1883766785;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpUI.AcpExpander acpExpander;
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1581318145;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1520304133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_245;
										}
										continue;
									case 2:
										if (acpExpander != null)
										{
											num = (short)1998585860;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 3:
										if (!enumerator.MoveNext())
										{
											num = (short)1013317632;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)298713090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										base.Expanders.Add(acpExpander);
										num = (short)1700134918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_300;
									}
									IL_247:
									num = (short)257949699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_245:
									goto IL_247;
								}
								IL_300:
								goto IL_19B;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_322;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_30F:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1876623362;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_375;
									case 1:
										goto IL_373;
									case 2:
										disposable.Dispose();
										num = (short)725155841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_322;
								}
								IL_373:
								IL_375:
								goto EndFinally_8;
								IL_322:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)235864064;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_30F;
								EndFinally_8:;
							}
							goto IL_376;
							IL_19B:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)2096627716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_61;
							}
							continue;
						case 2:
						{
							object obj;
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderKeypadKeypadButton.MyDataPresenter = this.ExpanderKeypadKeypadButton;
							num = (short)181927941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							object obj = null;
							obj = this.RecNavToolbarExpanderKeypadKeypadButton.MyRecordsetDataSource;
							num = (short)701300742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1C2;
						case 5:
							goto IL_FA;
						case 6:
						{
							object obj;
							if (obj != null)
							{
								num = (short)240386050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FA;
						}
						}
						IL_61:
						num = (short)167046759;
						short num3 = num;
						num = (short)1033563751;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
						{
							num = (short)11075584;
							short num4 = num;
							num = (short)878706688;
							if (num != 0)
							{
							}
							if (!this.a)
							{
								num = (short)664010755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_376;
						}
						}
						IL_FA:
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1543569409;
						if (num != 0)
						{
						}
						num = (short)1300103168;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1C2:
				IL_376:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x006FE6D4 File Offset: 0x006FC8D4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1143141222;
				short num2 = num;
				num = (short)37483366;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)783220736;
					if (num != 0)
					{
					}
					num = (short)492306433;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (this.a)
						{
							num = (short)292421634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						num = (short)1787559936;
						short num4 = num;
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)1975386113;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_8E;
				}
			}
			return;
			IL_8E:
			this.RecNavToolbarExpanderKeypadKeypadButton.DataContext = null;
			this.RecNavToolbarExpanderKeypadKeypadButton.MyDataPresenter = null;
			num = (short)1865416704;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x006FE814 File Offset: 0x006FCA14
		public override void SetDataContext()
		{
			short num = (short)719257605;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2BE;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10710].EmbeddedRecset != null)
					{
						num = (short)861863946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)427753473;
					if (num != 0)
					{
					}
					num = (short)2081882118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1722778727;
					short num3 = num;
					num = (short)821003367;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BE;
					default:
						num = (short)1378746368;
						if (num != 0)
						{
						}
						num = (short)615120907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10710] != null)
					{
						num = (short)252248076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_2E1;
				case 8:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1129250829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadKeypadButton).MySecondaryRecordsetDataSource = null;
					num = (short)1872822276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4109);
					num = (short)839647246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_D3;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)345047042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					num = (short)775290881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1224605696;
					short num4 = num;
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4109);
					num = (short)1087569920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_2E1;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)829947913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4109);
				num = (short)1045823495;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BE:
				if (feature != null)
				{
					num = (short)1275723779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_2E1:
				num = (short)1253703688;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D3:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadKeypadButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10710].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadKeypadButton).SyncDataSources();
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x006FEB6C File Offset: 0x006FCD6C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)669450243;
			int num2 = (int)((global::System.IntPtr)num);
			object myRecordsetDataSource;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_134;
				case 1:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)1889665031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)668467202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)1463439199;
					short num3 = num;
					num = (short)1137528671;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						num = (short)933888000;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9B;
						}
						continue;
					}
					break;
				}
				case 4:
					goto IL_BA;
				case 5:
					if (myRecordsetDataSource != null)
					{
						num = (short)2070085632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)1257111553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)911802369;
					if (num != 0)
					{
					}
					num = (short)1481441280;
					short num4 = num;
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarExpanderKeypadKeypadButton.MyRecordsetDataSource;
					num = (short)134479877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻뗽旿笁球朅氇䄉椋眍怏猑瀓吕洗渙栛焝丟", a_))
					{
						num = (short)1604190214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_9B:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1049231364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_BA:
				num = (short)1873936392;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_134:
			global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)collectionView.CurrentItem;
			collectionView.MoveCurrentTo(item);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x006FEDBC File Offset: 0x006FCFBC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1510568369;
			short num2 = num;
			num = (short)1498902961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)845676544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)261947392;
			if (num != 0)
			{
			}
			num = (short)1104805889;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x006FEE6C File Offset: 0x006FD06C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1138919528;
			short num2 = num;
			num = (short)2054916200;
			switch (num2 == num)
			{
			default:
			{
				num = (short)488112128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)450494464;
			if (num != 0)
			{
			}
			num = (short)73793537;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x006FEF1C File Offset: 0x006FD11C
		internal void OnExpanderKeypadKeypadButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1606941177;
				short num2 = num;
				num = (short)418511353;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_154;
				default:
					num = (short)1155465216;
					if (num != 0)
					{
					}
					num = (short)978780161;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (myRecordsetDataSource != null)
						{
							num = (short)570753026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					case 1:
						goto IL_154;
					case 2:
					{
						num = (short)960954368;
						short num4 = num;
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderKeypadKeypadButton.SyncDataSources();
						num = (short)790495233;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_90;
				}
			}
			IL_154:
			IL_156:
			this.RecNavToolbarExpanderKeypadKeypadButton.TableMode = false;
			return;
			IL_90:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderKeypadKeypadButton.MyRecordsetDataSource;
			num = (short)2006319104;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x006FF08C File Offset: 0x006FD28C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			short num = (short)1817442862;
			short num2 = num;
			num = (short)788462126;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)938409984;
				short num3 = num;
				num = (short)2029649920;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					num = (short)576978945;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2蟴零鷸鋺鋼\udafe㌀㌂怄甆済搊挌怎簐稒瘔搖㰘⤚ⴜ簞丠䴢䌤並丨帪弬丮䔰娲娴夶ᘸ堺刼儾㕀ㅂ⩄⭆㩈摊♌⩎⡐⍒㑔㍖癘ず㡜♞ᅠɢŤ䥦ᅨ੪lͮ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x006FF170 File Offset: 0x006FD370
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1019346944;
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
					goto IL_20A;
				case 2:
					num = (short)763297793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_324;
				case 2:
				case 3:
				case 4:
				case 5:
					goto IL_51C;
				case 6:
					goto IL_3FF;
				case 7:
					goto IL_3DB;
				case 8:
					goto IL_426;
				case 9:
					goto IL_15B;
				case 10:
					goto IL_244;
				case 11:
					goto IL_2D6;
				case 12:
					goto IL_237;
				case 13:
					goto IL_12A;
				case 14:
					goto IL_1A6;
				case 15:
					goto IL_2FD;
				case 16:
					goto IL_251;
				case 17:
					goto IL_2F0;
				case 18:
					goto IL_2C9;
				case 19:
					goto IL_30A;
				case 20:
					goto IL_285;
				case 21:
					goto IL_278;
				case 22:
					goto IL_1E4;
				case 23:
					goto IL_419;
				case 24:
					goto IL_379;
				case 25:
					goto IL_3C1;
				case 26:
					goto IL_355;
				case 27:
					goto IL_317;
				case 28:
					goto IL_11D;
				case 29:
					goto IL_199;
				case 30:
					goto IL_46E;
				case 31:
					goto IL_292;
				case 32:
					goto IL_4DE;
				case 33:
					goto IL_168;
				case 34:
					goto IL_110;
				case 35:
					goto IL_50F;
				case 36:
					goto IL_44A;
				case 37:
					goto IL_26B;
				case 38:
					goto IL_39D;
				case 39:
					goto IL_2E3;
				case 40:
					goto IL_14E;
				case 41:
					goto IL_502;
				case 42:
					goto IL_1B3;
				case 43:
					goto IL_25E;
				case 44:
					goto IL_175;
				case 45:
					goto IL_3CE;
				case 46:
					goto IL_40C;
				case 47:
					goto IL_1D7;
				default:
					num = (short)91684866;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_110:
			this.CpyBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11D:
			this.CpyBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12A:
			this.RecNavToolbarExpanderKeypadKeypadButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderKeypadKeypadButton.ModeClick += this.OnModeClick;
			return;
			IL_14E:
			this.CpyBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15B:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_168:
			this.RTDBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_175:
			this.LblRadErgCtrlKeypadGeneralKeypadButtonIndex_41415 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlKeypadGeneralKeypadButtonIndex_41415.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_199:
			this.RadErgCtrlKeypadGeneralKeypadButtonName_A41069Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A6:
			this.ExpanderKeypadGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1B3:
			this.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D7:
			this.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E4:
			this.ExpanderKeypadKeypadButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_20A:
			num = (short)1620377601;
			if (num != 0)
			{
			}
			goto IL_51C;
			IL_237:
			this.ExpanderKeypadGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_244:
			this.ExpanderKeypadGraphicview = (global::AcpUI.AcpExpander)target;
			return;
			IL_251:
			this.ExpanderKeypadKeypadButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_25E:
			this.CVBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26B:
			this.CVBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_278:
			this.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_285:
			this.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_292:
			num = (short)1679884288;
			short num3 = num;
			this.CVBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C9:
			this.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2D6:
			this.myKeypadGraphicView = (global::ControlHeadGraphicView.KeypadGraphicView)target;
			return;
			IL_2E3:
			this.RTDBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F0:
			this.ExpanderKeypadKeypadButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2FD:
			this.ExpanderKeypadKeypadButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_30A:
			this.RadErgCtrlKeypadGeneralKeypadBCO_A41070_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_317:
			this.RTDBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_324:
			((global::Motorola.MackinawCPS.CoreFeatures.Keypad.PageKeypad)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.Keypad.PageKeypad)target).Unloaded += this.OnUnloaded;
			return;
			IL_355:
			this.LblRadErgCtrlKeypadGeneralKeypadButtonName_A41069 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlKeypadGeneralKeypadButtonName_A41069.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_379:
			this.RadErgCtrlKeypadGeneralKeypadButtonName_A41069 = (global::AcpUI.AcpLabel)target;
			this.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39D:
			this.LblRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C1:
			this.CVBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3CE:
			this.RTDBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3DB:
			this.HLinkKeypadGraphicview = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkKeypadGraphicview.Click += this.HLinkClick;
			return;
			IL_3FF:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_40C:
			this.CpyBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_419:
			this.gridExpanderKeypadKeypadButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_426:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_44A:
			this.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_46E:
			num = (short)1066529819;
			short num4 = num;
			num = (short)282391579;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_278;
			default:
				num = (short)83886080;
				if (num != 0)
				{
				}
				this.RadErgCtrlKeypadGeneralKeypadBCO_A41070 = (global::AcpUI.AcpComboBox)target;
				this.RadErgCtrlKeypadGeneralKeypadBCO_A41070.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_4DE:
			this.LblRadErgCtrlKeypadGeneralKeypadBCO_A41070 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlKeypadGeneralKeypadBCO_A41070.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_502:
			this.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_50F:
			this.RadErgCtrlKeypadGeneralKeypadBCO_A41070Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_51C:
			this.b = true;
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x006FF6A0 File Offset: 0x006FD8A0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				switch (connectionId)
				{
				case 2:
					goto IL_A7;
				case 3:
				{
					num = (short)285492284;
					short num2 = num;
					num = (short)1103447100;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_52;
					}
					break;
				}
				case 4:
					goto IL_E8;
				case 5:
					goto IL_100;
				}
				break;
			}
			return;
			IL_52:
			num = (short)1584398337;
			if (num != 0)
			{
			}
			num = (short)102236160;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A7:
			num = (short)1792147456;
			short num3 = num;
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E8:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_100:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040035B4 RID: 13748
		private bool a;

		// Token: 0x040035B5 RID: 13749
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040035B6 RID: 13750
		internal global::System.Windows.Documents.Hyperlink HLinkKeypadGraphicview;

		// Token: 0x040035B7 RID: 13751
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040035B8 RID: 13752
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040035B9 RID: 13753
		internal global::AcpUI.AcpExpander ExpanderKeypadGraphicview;

		// Token: 0x040035BA RID: 13754
		internal global::ControlHeadGraphicView.KeypadGraphicView myKeypadGraphicView;

		// Token: 0x040035BB RID: 13755
		internal global::AcpUI.AcpExpander ExpanderKeypadGeneral;

		// Token: 0x040035BC RID: 13756
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderKeypadKeypadButton;

		// Token: 0x040035BD RID: 13757
		internal global::System.Windows.Controls.Grid ExpanderKeypadGeneralGrid;

		// Token: 0x040035BE RID: 13758
		internal global::System.Windows.Controls.Grid ExpanderKeypadKeypadButtonGrid;

		// Token: 0x040035BF RID: 13759
		internal global::AcpUI.AcpGroupBox ExpanderKeypadKeypadButtonTableView;

		// Token: 0x040035C0 RID: 13760
		internal global::AcpUI.AcpXamDataPresenter ExpanderKeypadKeypadButton;

		// Token: 0x040035C1 RID: 13761
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Col;

		// Token: 0x040035C2 RID: 13762
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlKeypadGeneralKeypadBCO_A41070_Col;

		// Token: 0x040035C3 RID: 13763
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Col;

		// Token: 0x040035C4 RID: 13764
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Col;

		// Token: 0x040035C5 RID: 13765
		internal global::AcpUI.AcpGroupBox ExpanderKeypadKeypadButtonSRecView;

		// Token: 0x040035C6 RID: 13766
		internal global::System.Windows.Controls.Grid gridExpanderKeypadKeypadButtonSRecView;

		// Token: 0x040035C7 RID: 13767
		internal global::AcpUI.AcpLabel RadErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035C8 RID: 13768
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035C9 RID: 13769
		internal global::AcpUI.AcpLabel LblRadErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035CA RID: 13770
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035CB RID: 13771
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035CC RID: 13772
		internal global::AcpUI.AcpLabel RadErgCtrlKeypadGeneralKeypadButtonName_A41069Comp;

		// Token: 0x040035CD RID: 13773
		internal global::AcpUI.AcpComboBox RadErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035CE RID: 13774
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035CF RID: 13775
		internal global::AcpUI.AcpLabel LblRadErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035D0 RID: 13776
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035D1 RID: 13777
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035D2 RID: 13778
		internal global::AcpUI.AcpLabel RadErgCtrlKeypadGeneralKeypadBCO_A41070Comp;

		// Token: 0x040035D3 RID: 13779
		internal global::AcpUI.AcpComboBox RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035D4 RID: 13780
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035D5 RID: 13781
		internal global::AcpUI.AcpLabel LblRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035D6 RID: 13782
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035D7 RID: 13783
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035D8 RID: 13784
		internal global::AcpUI.AcpLabel RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Comp;

		// Token: 0x040035D9 RID: 13785
		internal global::AcpUI.AcpComboBox RadErgCtrlKeypadGeneralKeypadButtonIndex_41415;

		// Token: 0x040035DA RID: 13786
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415;

		// Token: 0x040035DB RID: 13787
		internal global::AcpUI.AcpLabel LblRadErgCtrlKeypadGeneralKeypadButtonIndex_41415;

		// Token: 0x040035DC RID: 13788
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415;

		// Token: 0x040035DD RID: 13789
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlKeypadGeneralKeypadButtonIndex_41415;

		// Token: 0x040035DE RID: 13790
		internal global::AcpUI.AcpLabel RadErgCtrlKeypadGeneralKeypadButtonIndex_41415Comp;

		// Token: 0x040035DF RID: 13791
		private bool b;
	}
}
