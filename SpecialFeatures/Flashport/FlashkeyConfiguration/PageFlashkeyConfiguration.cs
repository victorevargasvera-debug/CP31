using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using Infragistics.Windows.DataPresenter.Events;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x02000106 RID: 262
	public class PageFlashkeyConfiguration : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x00146C60 File Offset: 0x00144E60
		public PageFlashkeyConfiguration()
		{
			int a_ = 11;
			base..ctor();
			this.a = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset();
			try
			{
				this.InitializeComponent();
				goto IL_1C;
			}
			catch (global::System.Exception)
			{
				goto IL_1C;
			}
			goto IL_5E;
			IL_1C:
			this.a();
			this.SetDataContext();
			if (!global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
			{
				return;
			}
			IL_5E:
			this.FkeyConfigFactoryOrderNumberValue.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.FkeyConfigFactoryOrderNumberValue.TextAlignment = global::System.Windows.TextAlignment.Right;
			this.FkeyConfigCurrentFlashcodeValue.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.FkeyConfigCurrentFlashcodeValue.TextAlignment = global::System.Windows.TextAlignment.Right;
			this.FkeyConfigNewFlashcodeValue.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.FkeyConfigNewFlashcodeValue.TextAlignment = global::System.Windows.TextAlignment.Right;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00146D28 File Offset: 0x00144F28
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpUI.AcpExpander acpExpander;
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_27F;
				case 1:
					try
					{
						num2 = (short)435027968;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_158;
								}
								continue;
							case 1:
								base.Expanders.Add(acpExpander);
								num2 = (short)1626079234;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								num2 = (short)444006406;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (acpExpander != null)
								{
									num2 = (short)400556033;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 5:
								if (!enumerator.MoveNext())
								{
									num2 = (short)971309059;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num2 = (short)6946820;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								goto IL_20A;
							}
							IL_198:
							num2 = (short)1322975237;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_158:
							goto IL_198;
						}
						IL_20A:
						goto IL_4C;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_22B;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_219:
							switch (num)
							{
							case 0:
								if (disposable != null)
								{
									num2 = (short)185597953;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_27E;
							case 1:
								disposable.Dispose();
								num2 = (short)618070018;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_27C;
							}
							goto IL_22B;
						}
						IL_27C:
						IL_27E:
						goto EndFinally_7;
						IL_22B:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)1034158080;
						num = (int)((global::System.IntPtr)num2);
						goto IL_219;
						EndFinally_7:;
					}
					goto IL_27F;
					IL_4C:
					this.MyStackPanel.Children[0].Focus();
					num2 = (short)635109378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (base.IsKeyboardFocusWithin)
					{
						return;
					}
					num2 = (short)769114779;
					short num3 = num2;
					num2 = (short)165593755;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)580190208;
						short num4 = num2;
						num2 = (short)1868693504;
						if (num2 != 0)
						{
						}
						num2 = (short)1293418496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_27F:
				num2 = (short)1364459521;
				if (num2 != 0)
				{
				}
				global::System.Windows.Input.Keyboard.Focus(this);
				num2 = (short)1673723907;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			acpExpander = null;
			enumerator = this.MyStackPanel.Children.GetEnumerator();
			num2 = (short)1058209793;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00147010 File Offset: 0x00145210
		public override void SetDataContext()
		{
			short num = (short)817578419;
			short num2 = num;
			num = (short)661471667;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2127822848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1190526977;
			if (num != 0)
			{
			}
			num = (short)839843840;
			if (num != 0)
			{
			}
			base.DataContext = global::SpecialFeatures.Flashport.FlashDataManager.GetFeature(this.a.RecsetId);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x001470D0 File Offset: 0x001452D0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1895067401;
			short num2 = num;
			num = (short)391147273;
			switch (num2 == num)
			{
			default:
			{
				num = (short)507183104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)308019201;
			if (num != 0)
			{
			}
			num = (short)699269120;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00147180 File Offset: 0x00145380
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1989508470;
			short num2 = num;
			num = (short)1716878710;
			switch (num2 == num)
			{
			default:
			{
				num = (short)103546880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1487011841;
			if (num != 0)
			{
			}
			num = (short)481755136;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00147230 File Offset: 0x00145430
		private void a()
		{
			short num = (short)1421835009;
			short num2 = num;
			num = (short)610040577;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1110573056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)478281728;
			if (num != 0)
			{
			}
			num = (short)387514369;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset();
			this.a.AddRecord(this.a.CreateDefaultRecord());
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x001472FC File Offset: 0x001454FC
		private void ExpanderFlashkeyCfgFeaturesTable_RecordActivating(object A_0, global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs A_1)
		{
			short num = (short)1200649404;
			short num2 = num;
			num = (short)489583804;
			switch (num2 == num)
			{
			default:
			{
				num = (short)311164928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1704591361;
			if (num != 0)
			{
			}
			num = (short)1352925184;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x001473AC File Offset: 0x001455AC
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)225619453;
			short num2 = num;
			num = (short)686861821;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1189412864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2137260033;
			if (num != 0)
			{
			}
			num = (short)191758336;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00147460 File Offset: 0x00145660
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)160447688;
				short num2 = num;
				num = (short)884358344;
				switch (num2 == num)
				{
				}
				num = (short)792526848;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺌Ꚑꪒ궔ꆘﶚ궜", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)998834176;
			short num3 = num;
			num = (short)1370161153;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00147540 File Offset: 0x00145740
		private void buttonClose_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1200353407;
			short num2 = num;
			num = (short)1437593727;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1788674048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)700579841;
			if (num != 0)
			{
			}
			num = (short)74514432;
			if (num != 0)
			{
			}
			((global::System.Windows.Window)base.Parent).Close();
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x001475F8 File Offset: 0x001457F8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			while (this.b)
			{
				short num = (short)1324941313;
				if (num != 0)
				{
				}
				num = (short)465046578;
				short num2 = num;
				num = (short)444337202;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)741670912;
					if (num != 0)
					{
					}
					num = (short)637140992;
					short num3 = num;
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒊ\ude8cﾎﲔ\udd9aﺞ햠횢힤슦\udaa8邪캬삮\udcb0쎲\udab4\ud9b6\udcb8햺즼邾Ꟁ꿂꓄듆ꇈ믊ꋌ뷎ꗐﳒ돔믖룘꣚뗜듞蓠髢蛤裦蟨跪蓬裮蓰臲铴菶郸铺鏼탾最漂搄理愈怊栌瘎爐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨Ԫ唬丮尰弲", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x001476D8 File Offset: 0x001458D8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)97845248;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					num = (short)790233090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_293;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_458;
					case 2:
					{
						num = (short)309084439;
						short num3 = num;
						num = (short)402735383;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							goto IL_3CC;
						}
						break;
					}
					case 3:
						goto IL_17A;
					case 4:
						goto IL_298;
					case 5:
						goto IL_109;
					case 6:
						goto IL_1F3;
					case 7:
						goto IL_2BC;
					case 8:
						goto IL_2C9;
					case 9:
						goto IL_38A;
					case 10:
						goto IL_257;
					case 11:
						goto IL_31E;
					case 12:
						goto IL_342;
					case 13:
						goto IL_434;
					case 14:
						goto IL_1CF;
					case 15:
						goto IL_E5;
					case 16:
						goto IL_471;
					case 17:
						goto IL_366;
					case 18:
						goto IL_187;
					case 19:
						goto IL_C1;
					case 20:
						goto IL_2FA;
					case 21:
						goto IL_495;
					case 22:
						goto IL_2D6;
					case 23:
						goto IL_156;
					case 24:
						goto IL_200;
					case 25:
						goto IL_1AB;
					case 26:
						goto IL_410;
					case 27:
						goto IL_20D;
					default:
						num = (short)1737621505;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_C1:
			this.LblFkeyConfigNewFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigNewFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E5:
			this.LblFkeyConfigNewModelNumber = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigNewModelNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_109:
			num = (short)179437568;
			short num4 = num;
			this.HLinkFlashkeyCfgFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFlashkeyCfgFeatures.Click += this.HLinkClick;
			return;
			IL_156:
			this.LblFkeyConfigUpgradesRemaining = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigUpgradesRemaining.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17A:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_187:
			this.FkeyConfigNewFlashcodeValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigNewFlashcodeValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AB:
			this.ExpanderFlashkeyCfgFeaturesTable = (global::AcpUI.AcpXamDataPresenter)target;
			this.ExpanderFlashkeyCfgFeaturesTable.RecordActivating += this.ExpanderFlashkeyCfgFeaturesTable_RecordActivating;
			return;
			IL_1CF:
			this.FkeyConfigNewModelNumberValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigNewModelNumberValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F3:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_200:
			this.ExpanderFlashkeyCfgFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_20D:
			num = (short)32243713;
			if (num != 0)
			{
			}
			this.buttonHelp = (global::System.Windows.Controls.Button)target;
			this.buttonHelp.Click += this.buttonHelp_Click;
			return;
			IL_257:
			this.FkeyConfigFactoryOrderNumberValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigFactoryOrderNumberValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_293:
			this.b = true;
			return;
			IL_298:
			this.HLinkFlashkeyCfgGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFlashkeyCfgGeneral.Click += this.HLinkClick;
			return;
			IL_2BC:
			this.ExpanderFlashkeyCfgGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_2C9:
			this.GrpBoxExpanderFlashkeyCfgGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2D6:
			this.FkeyConfigUpgradesRemainingValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigUpgradesRemainingValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FA:
			this.FkeyConfigUpgradesPurchasedValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigUpgradesPurchasedValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31E:
			this.LblFkeyConfigFactoryOrderNumber = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigFactoryOrderNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_342:
			this.FkeyConfigCurrentModelNumberValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigCurrentModelNumberValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_366:
			this.LblFkeyConfigCurrentFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigCurrentFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38A:
			this.StdGrpBoxExpanderFlashkeyCfgGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3CC:
			num = (short)1521287168;
			if (num != 0)
			{
			}
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_410:
			this.buttonClose = (global::System.Windows.Controls.Button)target;
			this.buttonClose.Click += this.buttonClose_Click;
			return;
			IL_434:
			this.LblFkeyConfigCurrentModelNumber = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigCurrentModelNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_458:
			((global::SpecialFeatures.Flashport.FlashkeyConfiguration.PageFlashkeyConfiguration)target).Loaded += this.OnLoaded;
			return;
			IL_471:
			this.FkeyConfigCurrentFlashcodeValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigCurrentFlashcodeValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_495:
			this.LblFkeyConfigUpgradesPurchased = (global::AcpUI.AcpLabel)target;
			this.LblFkeyConfigUpgradesPurchased.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
		}

		// Token: 0x0400079B RID: 1947
		public global::System.Windows.Data.CollectionView myCollectionView;

		// Token: 0x0400079C RID: 1948
		private global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset a;

		// Token: 0x0400079D RID: 1949
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400079E RID: 1950
		internal global::System.Windows.Documents.Hyperlink HLinkFlashkeyCfgGeneral;

		// Token: 0x0400079F RID: 1951
		internal global::System.Windows.Documents.Hyperlink HLinkFlashkeyCfgFeatures;

		// Token: 0x040007A0 RID: 1952
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040007A1 RID: 1953
		internal global::AcpUI.AcpExpander ExpanderFlashkeyCfgGeneral;

		// Token: 0x040007A2 RID: 1954
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderFlashkeyCfgGeneralPseudo0;

		// Token: 0x040007A3 RID: 1955
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderFlashkeyCfgGeneralPseudo0;

		// Token: 0x040007A4 RID: 1956
		internal global::AcpUI.AcpTextBox FkeyConfigFactoryOrderNumberValue;

		// Token: 0x040007A5 RID: 1957
		internal global::AcpUI.AcpLabel LblFkeyConfigFactoryOrderNumber;

		// Token: 0x040007A6 RID: 1958
		internal global::AcpUI.AcpTextBox FkeyConfigCurrentModelNumberValue;

		// Token: 0x040007A7 RID: 1959
		internal global::AcpUI.AcpLabel LblFkeyConfigCurrentModelNumber;

		// Token: 0x040007A8 RID: 1960
		internal global::AcpUI.AcpTextBox FkeyConfigNewModelNumberValue;

		// Token: 0x040007A9 RID: 1961
		internal global::AcpUI.AcpLabel LblFkeyConfigNewModelNumber;

		// Token: 0x040007AA RID: 1962
		internal global::AcpUI.AcpTextBox FkeyConfigCurrentFlashcodeValue;

		// Token: 0x040007AB RID: 1963
		internal global::AcpUI.AcpLabel LblFkeyConfigCurrentFlashcode;

		// Token: 0x040007AC RID: 1964
		internal global::AcpUI.AcpTextBox FkeyConfigNewFlashcodeValue;

		// Token: 0x040007AD RID: 1965
		internal global::AcpUI.AcpLabel LblFkeyConfigNewFlashcode;

		// Token: 0x040007AE RID: 1966
		internal global::AcpUI.AcpTextBox FkeyConfigUpgradesPurchasedValue;

		// Token: 0x040007AF RID: 1967
		internal global::AcpUI.AcpLabel LblFkeyConfigUpgradesPurchased;

		// Token: 0x040007B0 RID: 1968
		internal global::AcpUI.AcpTextBox FkeyConfigUpgradesRemainingValue;

		// Token: 0x040007B1 RID: 1969
		internal global::AcpUI.AcpLabel LblFkeyConfigUpgradesRemaining;

		// Token: 0x040007B2 RID: 1970
		internal global::AcpUI.AcpExpander ExpanderFlashkeyCfgFeatures;

		// Token: 0x040007B3 RID: 1971
		internal global::AcpUI.AcpXamDataPresenter ExpanderFlashkeyCfgFeaturesTable;

		// Token: 0x040007B4 RID: 1972
		internal global::System.Windows.Controls.Button buttonClose;

		// Token: 0x040007B5 RID: 1973
		internal global::System.Windows.Controls.Button buttonHelp;

		// Token: 0x040007B6 RID: 1974
		private bool b;
	}
}
