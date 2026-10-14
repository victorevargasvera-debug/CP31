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

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CA RID: 202
	public class PageRadioConfiguration : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x00104D98 File Offset: 0x00102F98
		public PageRadioConfiguration()
		{
			int a_ = 8;
			base..ctor();
			try
			{
				this.InitializeComponent();
				goto IL_11;
			}
			catch (global::System.Exception)
			{
				goto IL_11;
			}
			goto IL_53;
			IL_11:
			this.a();
			this.SetDataContext();
			if (!global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾌ", a_)))
			{
				return;
			}
			IL_53:
			this.RadioConfigCurrentFlashcodeValue.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.RadioConfigCurrentFlashcodeValue.TextAlignment = global::System.Windows.TextAlignment.Right;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00104E24 File Offset: 0x00103024
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
					goto IL_2B1;
				case 1:
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)1508966400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					try
					{
						num2 = (short)427622405;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1009326078;
								short num3 = num2;
								num2 = (short)1728649214;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_139;
								default:
									num2 = (short)1648099328;
									if (num2 != 0)
									{
									}
									if (acpExpander != null)
									{
										num2 = (short)1141833730;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								break;
							}
							case 1:
								num2 = (short)1318649859;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								base.Expanders.Add(acpExpander);
								num2 = (short)1471414278;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_23E;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1497432065;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_139;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_134;
								}
								continue;
							}
							goto IL_134;
							IL_139:
							acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
							num2 = (short)1648427008;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1C6:
							num2 = (short)73662468;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_134:
							goto IL_1C6;
						}
						IL_23E:
						goto IL_9E;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_25F;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_24D:
							switch (num)
							{
							case 0:
								disposable.Dispose();
								num2 = (short)1855062018;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (disposable != null)
								{
									num2 = (short)1991245824;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_2B0;
							case 2:
								goto IL_2AE;
							}
							goto IL_25F;
						}
						IL_2AE:
						IL_2B0:
						goto EndFinally_7;
						IL_25F:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)284164097;
						num = (int)((global::System.IntPtr)num2);
						goto IL_24D;
						EndFinally_7:;
					}
					goto IL_2B1;
					IL_9E:
					this.MyStackPanel.Children[0].Focus();
					num2 = (short)260636673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				}
				goto IL_20;
				IL_2B1:
				global::System.Windows.Input.Keyboard.Focus(this);
				num2 = (short)1175257091;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			num2 = (short)512491521;
			if (num2 != 0)
			{
			}
			acpExpander = null;
			enumerator = this.MyStackPanel.Children.GetEnumerator();
			num2 = (short)1189347328;
			short num4 = num2;
			num2 = (short)508624898;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00105120 File Offset: 0x00103320
		public override void SetDataContext()
		{
			short num = (short)941157378;
			short num2 = num;
			num = (short)511044610;
			switch (num2 == num)
			{
			default:
			{
				num = (short)803471360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)272891905;
			if (num != 0)
			{
			}
			num = (short)1262682112;
			if (num != 0)
			{
			}
			base.DataContext = global::SpecialFeatures.Flashport.FlashDataManager.GetFeature(this.a.RecsetId);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x001051E0 File Offset: 0x001033E0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)958529537;
			if (num != 0)
			{
			}
			num = (short)312868864;
			short num2 = num;
			num = (short)315570340;
			short num3 = num;
			num = (short)302004388;
			switch (num3 == num)
			{
			}
			num = (short)657260544;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00105290 File Offset: 0x00103490
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)238707482;
			short num2 = num;
			num = (short)436429594;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1405616128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)751828993;
			if (num != 0)
			{
			}
			num = (short)1827536896;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00105344 File Offset: 0x00103544
		private void a()
		{
			short num = (short)383436556;
			short num2 = num;
			num = (short)973326092;
			switch (num2 == num)
			{
			default:
			{
				num = (short)860880896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)617086977;
			if (num != 0)
			{
			}
			num = (short)86835200;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationRecset();
			this.a.AddRecord(this.a.CreateDefaultRecord());
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00105410 File Offset: 0x00103610
		private void ExpanderRadioCfgFeaturesTable_RecordActivating(object A_0, global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs A_1)
		{
			short num = (short)866536537;
			short num2 = num;
			num = (short)1671515225;
			switch (num2 == num)
			{
			default:
			{
				num = (short)626327552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)349175808;
			if (num != 0)
			{
			}
			num = (short)1479606273;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x001054C0 File Offset: 0x001036C0
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1401880164;
			short num2 = num;
			num = (short)567475812;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1644691456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1064435713;
			if (num != 0)
			{
			}
			num = (short)1669136384;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00105570 File Offset: 0x00103770
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)435913674;
				short num2 = num;
				num = (short)885949386;
				switch (num2 == num)
				{
				}
				num = (short)1026555904;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺌뮎ꢐ꒒ꢘꪚꮜ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1393688576;
			short num3 = num;
			num = (short)1516830721;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00105650 File Offset: 0x00103850
		private void buttonClose_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)593294643;
			short num2 = num;
			num = (short)1765143859;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1103364096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1414987776;
			if (num != 0)
			{
			}
			num = (short)1812594689;
			if (num != 0)
			{
			}
			((global::System.Windows.Window)base.Parent).Close();
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00105708 File Offset: 0x00103908
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (!this.b)
			{
				short num = (short)1545105934;
				short num2 = num;
				num = (short)201749006;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1327693825;
					if (num != 0)
					{
					}
					num = (short)1199243264;
					if (num != 0)
					{
					}
					num = (short)2021720064;
					short num3 = num;
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂ꇆꗈ꫊뻌꟎ꇐ볒꟔ꏖ꧚볜믞裠賢蛤裦蟨跪蓬裮蓰臲铴菶郸铺鏼탾猀戂愄渆昈栊戌愎眐稒爔或欘稚検瘞丠䴢ତ弦䠨䘪䄬", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x001057E4 File Offset: 0x001039E4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2022309890;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_277;
				case 1:
					num = (short)1120862208;
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
				for (;;)
				{
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_168;
					case 2:
						goto IL_27C;
					case 3:
						goto IL_C7;
					case 4:
						goto IL_1D6;
					case 5:
						goto IL_2AB;
					case 6:
						goto IL_253;
					case 7:
						goto IL_2CF;
					case 8:
						goto IL_1C9;
					case 9:
						goto IL_BA;
					case 10:
						goto IL_300;
					case 11:
						goto IL_181;
					case 12:
						goto IL_96;
					case 13:
						goto IL_2DC;
					case 14:
						goto IL_222;
					case 15:
					{
						num = (short)1239144975;
						short num3 = num;
						num = (short)504027663;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_109;
						}
						break;
					}
					case 16:
						goto IL_1A5;
					case 17:
						goto IL_22F;
					}
					break;
				}
				num = (short)401473537;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_96:
			this.RadioConfigCurrentFlashcodeValue = (global::AcpUI.AcpTextBox)target;
			this.RadioConfigCurrentFlashcodeValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA:
			this.StdGrpBoxExpanderRadioCfgGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_109:
			num = (short)958005249;
			if (num != 0)
			{
			}
			num = (short)1411055616;
			if (num != 0)
			{
			}
			this.ExpanderRadioCfgFeaturesTable = (global::AcpUI.AcpXamDataPresenter)target;
			this.ExpanderRadioCfgFeaturesTable.RecordActivating += this.ExpanderRadioCfgFeaturesTable_RecordActivating;
			return;
			IL_168:
			((global::SpecialFeatures.Flashport.RadioConfiguration.PageRadioConfiguration)target).Loaded += this.OnLoaded;
			return;
			IL_181:
			this.LblRadioConfigCurrentModelNumber = (global::AcpUI.AcpLabel)target;
			this.LblRadioConfigCurrentModelNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A5:
			this.buttonClose = (global::System.Windows.Controls.Button)target;
			this.buttonClose.Click += this.buttonClose_Click;
			return;
			IL_1C9:
			this.GrpBoxExpanderRadioCfgGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1D6:
			num = (short)1771503616;
			short num4 = num;
			this.HLinkRadioCfgGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRadioCfgGeneral.Click += this.HLinkClick;
			return;
			IL_222:
			this.ExpanderRadioCfgFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_22F:
			this.buttonHelp = (global::System.Windows.Controls.Button)target;
			this.buttonHelp.Click += this.buttonHelp_Click;
			return;
			IL_253:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_277:
			this.b = true;
			return;
			IL_27C:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_2AB:
			this.HLinkRadioCfgFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRadioCfgFeatures.Click += this.HLinkClick;
			return;
			IL_2CF:
			this.ExpanderRadioCfgGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_2DC:
			this.LblRadioConfigCurrentFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblRadioConfigCurrentFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_300:
			this.RadioConfigCurrentModelNumberValue = (global::AcpUI.AcpTextBox)target;
			this.RadioConfigCurrentModelNumberValue.GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400061C RID: 1564
		public global::System.Windows.Data.CollectionView myCollectionView;

		// Token: 0x0400061D RID: 1565
		private global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationRecset a;

		// Token: 0x0400061E RID: 1566
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400061F RID: 1567
		internal global::System.Windows.Documents.Hyperlink HLinkRadioCfgGeneral;

		// Token: 0x04000620 RID: 1568
		internal global::System.Windows.Documents.Hyperlink HLinkRadioCfgFeatures;

		// Token: 0x04000621 RID: 1569
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000622 RID: 1570
		internal global::AcpUI.AcpExpander ExpanderRadioCfgGeneral;

		// Token: 0x04000623 RID: 1571
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioCfgGeneralPseudo0;

		// Token: 0x04000624 RID: 1572
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderRadioCfgGeneralPseudo0;

		// Token: 0x04000625 RID: 1573
		internal global::AcpUI.AcpTextBox RadioConfigCurrentModelNumberValue;

		// Token: 0x04000626 RID: 1574
		internal global::AcpUI.AcpLabel LblRadioConfigCurrentModelNumber;

		// Token: 0x04000627 RID: 1575
		internal global::AcpUI.AcpTextBox RadioConfigCurrentFlashcodeValue;

		// Token: 0x04000628 RID: 1576
		internal global::AcpUI.AcpLabel LblRadioConfigCurrentFlashcode;

		// Token: 0x04000629 RID: 1577
		internal global::AcpUI.AcpExpander ExpanderRadioCfgFeatures;

		// Token: 0x0400062A RID: 1578
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioCfgFeaturesTable;

		// Token: 0x0400062B RID: 1579
		internal global::System.Windows.Controls.Button buttonClose;

		// Token: 0x0400062C RID: 1580
		internal global::System.Windows.Controls.Button buttonHelp;

		// Token: 0x0400062D RID: 1581
		private bool b;
	}
}
