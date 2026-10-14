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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x0200012C RID: 300
	public class DVRSFileListPage : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x0016339C File Offset: 0x0016159C
		public DVRSFileListPage()
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

		// Token: 0x06000FD3 RID: 4051 RVA: 0x001633D4 File Offset: 0x001615D4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)232128512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)87359491;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)722403331;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1353580548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (acpExpander != null)
									{
										num = (short)1761345541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)665321472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)467599361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_206;
									}
									continue;
								case 4:
									goto IL_2C4;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)1956511750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_208:
								num = (short)1933180930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_206:
								goto IL_208;
							}
							IL_2C4:
							goto IL_105;
						}
						finally
						{
							global::System.IDisposable disposable;
							switch (0)
							{
							case 0:
								break;
							default:
								for (;;)
								{
									IL_2D3:
									switch (num2)
									{
									case 0:
										goto IL_38B;
									case 1:
										if (disposable != null)
										{
											num = (short)1846804482;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_38D;
									case 2:
									{
										disposable.Dispose();
										num = (short)1853371339;
										short num3 = num;
										num = (short)1690121163;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2ED;
										default:
											num = (short)1754923008;
											if (num != 0)
											{
											}
											num = (short)25690112;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_2E6;
								}
								IL_38B:
								IL_38D:
								goto EndFinally_8;
							}
							IL_2E6:
							disposable = (enumerator as global::System.IDisposable);
							IL_2ED:
							num = (short)1443037185;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2D3;
							EndFinally_8:;
						}
						return;
						IL_105:
						num = (short)1017380864;
						short num4 = num;
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)610795525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						num = (short)754647044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						this.RecNavToolbarExpanderDVRSFileListEmbeddedList.MyDataPresenter = this.ExpanderDVRSFileListEmbeddedList;
						object obj = null;
						obj = this.RecNavToolbarExpanderDVRSFileListEmbeddedList.MyRecordsetDataSource;
						num = (short)694550534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 4:
						num = (short)19136513;
						if (num != 0)
						{
						}
						goto IL_82;
					case 5:
						return;
					case 6:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1025572865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					}
					IL_60:
					if (!this.a)
					{
						num = (short)212140034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_82:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1524695040;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0016378C File Offset: 0x0016198C
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
						return;
					case 1:
						if (this.a)
						{
							num2 = (short)1086390272;
							short num3 = num2;
							num2 = (short)357761026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1949884550;
						short num4 = num2;
						num2 = (short)1250091142;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
							num2 = (short)358219776;
							if (num2 != 0)
							{
							}
							num2 = (short)777715712;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarPageDVRSFileList.DataContext = null;
			this.RecNavToolbarPageDVRSFileList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDVRSFileListEmbeddedList.DataContext = null;
			this.RecNavToolbarExpanderDVRSFileListEmbeddedList.MyDataPresenter = null;
			IL_4C:
			num2 = (short)839122945;
			if (num2 != 0)
			{
			}
			num2 = (short)1554382849;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x001638E4 File Offset: 0x00161AE4
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_155;
				case 1:
					goto IL_84;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)71761923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4234);
					goto IL_6F;
				case 3:
				{
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4234);
					num2 = (short)493392810;
					short num3 = num2;
					num2 = (short)1260426154;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)1069940737;
						if (num2 != 0)
						{
						}
						num2 = (short)2089943040;
						if (num2 != 0)
						{
						}
						num2 = (short)153092096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_6F:
				num2 = (short)1524498433;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_84:
			num2 = (short)1260388352;
			short num4 = num2;
			IL_155:
			this.RecNavToolbarPageDVRSFileList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSFileList).MySecondaryRecordsetDataSource = null;
			return;
			IL_20:
			base.MyBaseRecNavToolbar = this.RecNavToolbarPageDVRSFileList;
			num2 = (short)1148059650;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00163A6C File Offset: 0x00161C6C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)4156799;
			short num2 = num;
			num = (short)1495428479;
			switch (num2 == num)
			{
			}
			num = (short)87949313;
			if (num != 0)
			{
			}
			num = (short)1743323136;
			short num3 = num;
			num = (short)511836160;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00163B18 File Offset: 0x00161D18
		private void a(object A_0)
		{
			short num = (short)1946404622;
			short num2 = num;
			num = (short)262326030;
			switch (num2 == num)
			{
			}
			num = (short)1330708480;
			if (num != 0)
			{
			}
			num = (short)1249312768;
			short num3 = num;
			num = (short)1293811713;
			if (num != 0)
			{
			}
			global::AcpCommonLib.ApplicationMode appMode = global::AcpCommonLib.AppInfoManager.AppMode;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00163BCC File Offset: 0x00161DCC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)719954434;
			short num2 = num;
			num = (short)2090443266;
			switch (num2 == num)
			{
			}
			num = (short)2089615361;
			if (num != 0)
			{
			}
			num = (short)1250689024;
			short num3 = num;
			num = (short)1460731904;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00163C78 File Offset: 0x00161E78
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1613037569;
			if (num != 0)
			{
			}
			num = (short)1268334673;
			short num2 = num;
			num = (short)1620852817;
			switch (num2 == num)
			{
			}
			num = (short)1502543872;
			short num3 = num;
			num = (short)939065344;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00163D28 File Offset: 0x00161F28
		private void OnMultiAddClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1800492686;
			short num2 = num;
			num = (short)915429006;
			switch (num2 == num)
			{
			}
			num = (short)17760257;
			if (num != 0)
			{
			}
			num = (short)1665728512;
			short num3 = num;
			num = (short)700841984;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00163DD4 File Offset: 0x00161FD4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			if (!this.b)
			{
				short num = (short)1433874780;
				short num2 = num;
				num = (short)232010076;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1078788097;
					if (num != 0)
					{
					}
					num = (short)1415708672;
					short num3 = num;
					num = (short)529072128;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겂횄﶐햒爵튠颢욤좦쒨\udbaa슬솮풰\uddb2솴颶\uddb8춺쾼첾Ꟁꫂ꧄ꋆ뫈꧌많ꏐꃒ돔뻖뗘뻚뇜뛞鋠韢쫤菦鿨駪黬觮飰鿲郴鯶郸裺觼퇾礀戂栄欆", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00163EB8 File Offset: 0x001620B8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)449445889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_24F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)1950154753;
					if (num != 0)
					{
					}
					num = (short)1033568256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_305;
				case 2:
					goto IL_11E;
				case 3:
				case 4:
					goto IL_343;
				case 5:
					goto IL_254;
				case 6:
					goto IL_ED;
				case 7:
					goto IL_1BF;
				case 8:
					goto IL_261;
				case 9:
					goto IL_1FD;
				case 10:
					goto IL_26E;
				case 11:
					goto IL_2E1;
				case 12:
					goto IL_19B;
				case 13:
					goto IL_E0;
				case 14:
					goto IL_336;
				case 15:
					goto IL_2D4;
				case 16:
					goto IL_D3;
				case 17:
					goto IL_16A;
				case 18:
					goto IL_27B;
				case 19:
					goto IL_111;
				case 20:
					goto IL_1CC;
				case 21:
					goto IL_177;
				case 22:
					goto IL_1D9;
				default:
					num = (short)814940162;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D3:
			this.ExpanderDVRSFileListEmbeddedList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_E0:
			this.ExpanderDVRSFileListLabtoolGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_ED:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_111:
			this.gridExpanderDVRSFileListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_11E:
			num = (short)392167424;
			short num3 = num;
			this.RecNavToolbarPageDVRSFileList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageDVRSFileList.ModeClick += this.OnModeClick;
			return;
			IL_16A:
			this.DVRSConfigDVRSFileData_A43734_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_177:
			this.DVRSConfigDVRSFileData_A43734 = (global::AcpUI.AcpTextBox)target;
			this.DVRSConfigDVRSFileData_A43734.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19B:
			this.DVRSConfigDVRSFileName_A43736 = (global::AcpUI.AcpTextBox)target;
			this.DVRSConfigDVRSFileName_A43736.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BF:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1CC:
			this.StdGridExpanderDVRSFileListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1D9:
			this.LblDVRSConfigDVRSFileData_A43734 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSConfigDVRSFileData_A43734.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FD:
			this.RecNavToolbarExpanderDVRSFileListEmbeddedList = (global::AcpUI.AcpVoiceAnnRecNavToolBar)target;
			this.RecNavToolbarExpanderDVRSFileListEmbeddedList.ModeClick += this.OnModeClick;
			this.RecNavToolbarExpanderDVRSFileListEmbeddedList.MultiAddClick += this.OnMultiAddClick;
			return;
			IL_24F:
			goto IL_343;
			IL_254:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_261:
			this.ExpanderDVRSFileLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_26E:
			this.GrpBoxExpanderDVRSFileListLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_27B:
			num = (short)1120948969;
			short num4 = num;
			num = (short)1559974633;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_19B;
			default:
				num = (short)1203109888;
				if (num != 0)
				{
				}
				this.GroupBoxExpanderDVRSFileListSRecView = (global::AcpUI.AcpGroupBox)target;
				return;
			}
			IL_2D4:
			this.GroupBoxExpanderDVRSFileListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2E1:
			this.LblDVRSConfigDVRSFileName_A43736 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSConfigDVRSFileName_A43736.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_305:
			((global::SpecialFeatures.DVRSFiles.List.DVRSFileListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.DVRSFiles.List.DVRSFileListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_336:
			this.ExpanderDVRSFileListEmbeddedListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_343:
			this.b = true;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00164210 File Offset: 0x00162410
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1119485954;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C7;
				case 1:
					if (connectionId == 4)
					{
						num = (short)939261693;
						short num3 = num;
						num = (short)1899429629;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_128;
						}
					}
					num = (short)2051735552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
				{
					num = (short)460718080;
					short num4 = num;
					num = (short)778698753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_35:
				if (connectionId == 3)
				{
					break;
				}
				num = (short)87752707;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTextBoxFileBrowser)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C7:
			num = (short)507707393;
			if (num != 0)
			{
			}
			return;
			IL_128:
			num = (short)1265172480;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000826 RID: 2086
		private bool a;

		// Token: 0x04000827 RID: 2087
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageDVRSFileList;

		// Token: 0x04000828 RID: 2088
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000829 RID: 2089
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x0400082A RID: 2090
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400082B RID: 2091
		internal global::AcpUI.AcpExpander ExpanderDVRSFileLabtool;

		// Token: 0x0400082C RID: 2092
		internal global::AcpUI.AcpVoiceAnnRecNavToolBar RecNavToolbarExpanderDVRSFileListEmbeddedList;

		// Token: 0x0400082D RID: 2093
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSFileListLabtoolPseudo0;

		// Token: 0x0400082E RID: 2094
		internal global::AcpUI.AcpLabel LblDVRSConfigDVRSFileName_A43736;

		// Token: 0x0400082F RID: 2095
		internal global::AcpUI.AcpTextBox DVRSConfigDVRSFileName_A43736;

		// Token: 0x04000830 RID: 2096
		internal global::System.Windows.Controls.Grid ExpanderDVRSFileListLabtoolGrid;

		// Token: 0x04000831 RID: 2097
		internal global::System.Windows.Controls.Grid ExpanderDVRSFileListEmbeddedListGrid;

		// Token: 0x04000832 RID: 2098
		internal global::AcpUI.AcpGroupBox GroupBoxExpanderDVRSFileListTableView;

		// Token: 0x04000833 RID: 2099
		internal global::AcpUI.AcpXamDataPresenter ExpanderDVRSFileListEmbeddedList;

		// Token: 0x04000834 RID: 2100
		internal global::Infragistics.Windows.DataPresenter.UnboundField DVRSConfigDVRSFileData_A43734_Col;

		// Token: 0x04000835 RID: 2101
		internal global::AcpUI.AcpGroupBox GroupBoxExpanderDVRSFileListSRecView;

		// Token: 0x04000836 RID: 2102
		internal global::System.Windows.Controls.Grid gridExpanderDVRSFileListSRecView;

		// Token: 0x04000837 RID: 2103
		internal global::System.Windows.Controls.Grid StdGridExpanderDVRSFileListSRecView;

		// Token: 0x04000838 RID: 2104
		internal global::AcpUI.AcpTextBox DVRSConfigDVRSFileData_A43734;

		// Token: 0x04000839 RID: 2105
		internal global::AcpUI.AcpLabel LblDVRSConfigDVRSFileData_A43734;

		// Token: 0x0400083A RID: 2106
		private bool b;
	}
}
