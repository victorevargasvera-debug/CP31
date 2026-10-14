using System;
using System.CodeDom.Compiler;
using System.Collections;
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
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AC RID: 428
	public class SystemCertificateListPage : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x001D36B8 File Offset: 0x001D18B8
		public SystemCertificateListPage()
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

		// Token: 0x06001444 RID: 5188 RVA: 0x001D36F0 File Offset: 0x001D18F0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)165478401;
			if (num != 0)
			{
			}
			num = (short)663093251;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1046020096;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num2)
				{
				case 0:
					goto IL_260;
				case 1:
					try
					{
						num = (short)198705158;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1578401955;
								short num4 = num;
								num = (short)71729315;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1891631104;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)1388511235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									break;
								}
								num = (short)1435369473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								if (acpExpander != null)
								{
									num = (short)575209474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								base.Expanders.Add(acpExpander);
								num = (short)875167748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1120862213;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_1EC;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_E7;
								}
								continue;
							}
							IL_12A:
							num = (short)237895680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E7:
							goto IL_12A;
						}
						IL_1EC:
						goto IL_28F;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_20D;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1FB:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1577582593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_25D;
							case 2:
								if (disposable != null)
								{
									num = (short)2095054848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_25F;
							}
							goto IL_20D;
						}
						IL_25D:
						IL_25F:
						goto EndFinally_7;
						IL_20D:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1182072834;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1FB;
						EndFinally_7:;
					}
					goto IL_260;
					IL_28F:
					this.MyStackPanel.Children[0].Focus();
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1025966082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				}
				IL_83:
				if (!this.a)
				{
					num = (short)976289792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_260:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1216282625;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x001D39EC File Offset: 0x001D1BEC
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
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)343998465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_106;
				case 2:
					if (this.a)
					{
						num2 = (short)1778778112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_106:
			num2 = (short)1534197761;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1788097540;
			short num3 = num2;
			num2 = (short)799814660;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1894776832;
				if (num2 != 0)
				{
				}
				this.RecNavToolbarPageSystemCertificateList.DataContext = null;
				this.RecNavToolbarPageSystemCertificateList.MyDataPresenter = null;
				break;
			}
			num2 = (short)941752320;
			short num4 = num2;
			num2 = (short)1585446914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x001D3B2C File Offset: 0x001D1D2C
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)139001858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4228);
					num2 = (short)361496580;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_134;
				case 3:
					goto IL_E5;
				case 4:
					goto IL_E5;
				case 5:
				{
					while (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1838599401;
						short num3 = num2;
						num2 = (short)316329193;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)717619200;
							if (num2 != 0)
							{
							}
							num2 = (short)534511617;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4228);
					num2 = (short)2143420416;
					short num4 = num2;
					num2 = (short)1600126979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
				IL_E5:
				this.RecNavToolbarPageSystemCertificateList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num2 = (short)1473445888;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_134:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4228);
			this.CompGrpBoxExpanderSystemCertificateGeneralPseudo0.DataContext = feature;
			this.RecNavToolbarPageSystemCertificateList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSystemCertificateList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSystemCertificateList).SyncDataSources();
			return;
			IL_210:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSystemCertificateList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarPageSystemCertificateList;
			num2 = (short)1744633857;
			if (num2 != 0)
			{
			}
			num2 = (short)1475543045;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x001D3D58 File Offset: 0x001D1F58
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)876085254;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
				switch (num2)
				{
				case 0:
					goto IL_13B;
				case 1:
					num = (short)637403140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					num = (short)535625730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)647430145;
					if (num != 0)
					{
					}
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c\udd92춘쎠슢힤좨첪좬ﲮ좰삲솴튶풸\ud8bc춾뗀ꫂꏄ껆꫈꫊만꫎鷐뫒ꛔꏖ", a_))
					{
						num = (short)355598341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					myRecordsetDataSource = this.RecNavToolbarPageSystemCertificateList.MyRecordsetDataSource;
					num = (short)1488519168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)264570039;
					short num3 = num;
					num = (short)1034814647;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					case 1:
						break;
					default:
					{
						num = (short)109445120;
						short num4 = num;
						break;
					}
					}
					num = (short)217710592;
					if (num != 0)
					{
					}
					num = (short)540737537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13B:
				if (myRecordsetDataSource == null)
				{
					break;
				}
				num = (short)355139587;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x001D3F3C File Offset: 0x001D213C
		private void a(object A_0)
		{
			short num = (short)1779217625;
			short num2 = num;
			num = (short)1705424089;
			switch (num2 == num)
			{
			default:
			{
				num = (short)427950080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)966131713;
			if (num != 0)
			{
			}
			num = (short)969932800;
			if (num != 0)
			{
			}
			global::AcpCommonLib.ApplicationMode appMode = global::AcpCommonLib.AppInfoManager.AppMode;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x001D3FF0 File Offset: 0x001D21F0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1545453723;
			short num2 = num;
			num = (short)652066971;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2049114112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)120324097;
			if (num != 0)
			{
			}
			num = (short)1591869440;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x001D40A0 File Offset: 0x001D22A0
		private void HLinkSystemCertificateClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1166832734;
			short num2 = num;
			num = (short)1474327646;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1990000640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1741160449;
			if (num != 0)
			{
			}
			num = (short)1363935232;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x001D4150 File Offset: 0x001D2350
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 7;
			if (this.b)
			{
				short num = (short)1642594304;
				short num2 = num;
				num = (short)477808782;
				short num3 = num;
				num = (short)1733871758;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)232390656;
					if (num != 0)
					{
					}
					num = (short)1845100545;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖉ\udf8bﺍﶓ\udc99鍊ﾝ풟힡횣쎥\udba7醩쾫솭\uddaf슱\udbb3\ud8b5\uddb7풹좻醽ꎿꟁ뛃닅ꇇ곉ꗋ귍뇏ꛑ뇓믕맗듙뷛망藟迡臣裥鳧엩鿫韭華蛱釳鯵鯷鿹軻諽槿搁洃攅椇縉椋戍礏愑怓㤕欗挙漛樝䔟伡䜣䌥娧帩䔫䠭夯儱唳䈵崷嘹唻䴽㐿汁㱃❅╇♉", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x001D4238 File Offset: 0x001D2438
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1597833218;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1699938305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1F2;
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
						goto IL_22C;
					case 2:
						goto IL_E4;
					case 3:
						goto IL_B3;
					case 4:
						goto IL_146;
					case 5:
						goto IL_1F7;
					case 6:
						goto IL_1CE;
					case 7:
						goto IL_25D;
					case 8:
						goto IL_2B2;
					case 9:
						goto IL_139;
					case 10:
						goto IL_A6;
					case 11:
						goto IL_28E;
					case 12:
						goto IL_108;
					case 13:
						goto IL_99;
					case 14:
						goto IL_26A;
					case 15:
						goto IL_C0;
					case 16:
						goto IL_16A;
					case 17:
						goto IL_12C;
					case 18:
						goto IL_177;
					default:
						num = (short)247791616;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_177:
				num = (short)526560975;
				short num3 = num;
				num = (short)449425103;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1AC;
				}
			}
			IL_99:
			this.CVBtnSystemCertificateFileName_A43634 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A6:
			this.CVBtnSystemCertificateName = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B3:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_C0:
			this.SecSysCertGeneralCertificateFilename_A43634 = (global::AcpUI.AcpTextBoxFileBrowser)target;
			this.SecSysCertGeneralCertificateFilename_A43634.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E4:
			this.RecNavToolbarPageSystemCertificateList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageSystemCertificateList.ModeClick += this.OnModeClick;
			return;
			IL_108:
			this.SecSysCertGeneralKeyofSystemCertificates_A43633 = (global::AcpUI.AcpTextBox)target;
			this.SecSysCertGeneralKeyofSystemCertificates_A43633.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12C:
			this.CpyBtnSystemCertificateFileName_A43634 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_139:
			this.StdGrpBoxExpanderSystemCertificateGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_146:
			this.HLinkSystemCertificateGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSystemCertificateGeneral.Click += this.HLinkSystemCertificateClick;
			return;
			IL_16A:
			this.CompGrpBoxExpanderSystemCertificateGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1AC:
			num = (short)391053312;
			if (num != 0)
			{
			}
			this.SystemCertificateFileName_A43634Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1CE:
			this.ExpanderSystemCertificateGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_1F2:
			this.b = true;
			return;
			IL_1F7:
			num = (short)310837249;
			if (num != 0)
			{
			}
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_22C:
			((global::SpecialFeatures.SystemCertificates.List.SystemCertificateListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.SystemCertificates.List.SystemCertificateListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_25D:
			this.ExpanderSystemCertificateGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_26A:
			this.LblSystemCertificateFileName_A43634 = (global::AcpUI.AcpLabel)target;
			this.LblSystemCertificateFileName_A43634.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28E:
			this.LblSystemCertificateName = (global::AcpUI.AcpLabel)target;
			this.LblSystemCertificateName.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B2:
			num = (short)83951616;
			short num4 = num;
			this.GrpBoxExpanderSystemCertificateListGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
		}

		// Token: 0x04000B0E RID: 2830
		private bool a;

		// Token: 0x04000B0F RID: 2831
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageSystemCertificateList;

		// Token: 0x04000B10 RID: 2832
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000B11 RID: 2833
		internal global::System.Windows.Documents.Hyperlink HLinkSystemCertificateGeneral;

		// Token: 0x04000B12 RID: 2834
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000B13 RID: 2835
		internal global::AcpUI.AcpExpander ExpanderSystemCertificateGeneral;

		// Token: 0x04000B14 RID: 2836
		internal global::System.Windows.Controls.Grid ExpanderSystemCertificateGeneralGrid;

		// Token: 0x04000B15 RID: 2837
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSystemCertificateListGeneralPseudo0;

		// Token: 0x04000B16 RID: 2838
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderSystemCertificateGeneralPseudo0;

		// Token: 0x04000B17 RID: 2839
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemCertificateName;

		// Token: 0x04000B18 RID: 2840
		internal global::AcpUI.AcpLabel LblSystemCertificateName;

		// Token: 0x04000B19 RID: 2841
		internal global::AcpUI.AcpTextBox SecSysCertGeneralKeyofSystemCertificates_A43633;

		// Token: 0x04000B1A RID: 2842
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemCertificateFileName_A43634;

		// Token: 0x04000B1B RID: 2843
		internal global::AcpUI.AcpLabel LblSystemCertificateFileName_A43634;

		// Token: 0x04000B1C RID: 2844
		internal global::AcpUI.AcpTextBoxFileBrowser SecSysCertGeneralCertificateFilename_A43634;

		// Token: 0x04000B1D RID: 2845
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderSystemCertificateGeneralPseudo0;

		// Token: 0x04000B1E RID: 2846
		internal global::AcpUI.AcpCopyButton CpyBtnSystemCertificateFileName_A43634;

		// Token: 0x04000B1F RID: 2847
		internal global::AcpUI.AcpViewOnlyCtrl SystemCertificateFileName_A43634Comp;

		// Token: 0x04000B20 RID: 2848
		private bool b;
	}
}
