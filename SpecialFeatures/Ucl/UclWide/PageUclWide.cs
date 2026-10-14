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

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001B4 RID: 436
	public class PageUclWide : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06001479 RID: 5241 RVA: 0x0000387F File Offset: 0x00001A7F
		public PageUclWide()
		{
			this.InitializeComponent();
			base.PageFeatureId = 2222;
			this.SetDataContext();
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x001D70CC File Offset: 0x001D52CC
		public override void SetDataContext()
		{
			short num = (short)858456070;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(base.PageFeatureId);
					num = (short)81133569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_DB;
				case 2:
					global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2222);
					num = (short)1176305668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1502806016;
					short num3 = num;
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1997733890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					return;
				case 5:
					goto IL_DB;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(base.PageFeatureId);
					num = (short)1116143621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)454069545;
				short num4 = num;
				num = (short)707431721;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1140326401;
					if (num != 0)
					{
					}
					num = (short)2026242048;
					if (num != 0)
					{
					}
					num = (short)918487040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DB:
				num = (short)667549699;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x001D72A4 File Offset: 0x001D54A4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1567686659;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_237;
				case 1:
					goto IL_2A3;
				case 2:
					try
					{
						num = (short)1533214726;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (acpExpander != null)
								{
									num = (short)1143537667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1085276165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)295436288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								base.Expanders.Add(acpExpander);
								num = (short)435355649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_179;
							case 5:
								num = (short)1832779780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C3;
								}
								continue;
							}
							IL_103:
							num = (short)195428354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C3:
							goto IL_103;
						}
						IL_179:
						goto IL_266;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_19A;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_188:
							switch (num2)
							{
							case 0:
								goto IL_1EB;
							case 1:
								if (disposable != null)
								{
									num = (short)2123563010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EB;
							case 2:
								disposable.Dispose();
								num = (short)1326841856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19A;
							IL_1EB:
							num = (short)731263367;
							short num3 = num;
							num = (short)1336422791;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_221;
							}
						}
						IL_221:
						num = (short)2110980096;
						if (num != 0)
						{
						}
						goto EndFinally_7;
						IL_19A:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1286864897;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_188;
						EndFinally_7:;
					}
					goto IL_237;
					IL_266:
					this.MyStackPanel.Children[0].Focus();
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1127612417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)646971392;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				}
				}
				IL_5F:
				if (!this.a)
				{
					num = (short)1988755456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_237:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)922746882;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2A3:
			num = (short)1074462721;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x001D7590 File Offset: 0x001D5790
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2095054849;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1046151169;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
				{
					num = (short)540606464;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				}
				case 2:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)59572224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_84:
				if (!this.a)
				{
					return;
				}
				num = (short)79888386;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			num = (short)739166682;
			short num4 = num;
			num = (short)266062298;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1158807552;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x001D76B8 File Offset: 0x001D58B8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)579704537;
			short num2 = num;
			num = (short)180262617;
			switch (num2 == num)
			{
			}
			num = (short)1254293504;
			if (num != 0)
			{
			}
			num = (short)1011810304;
			short num3 = num;
			num = (short)1851392001;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x001D776C File Offset: 0x001D596C
		private void HLinkUclWideClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1953923093;
			short num2 = num;
			num = (short)537100309;
			switch (num2 == num)
			{
			}
			num = (short)1659240449;
			if (num != 0)
			{
			}
			num = (short)337772544;
			short num3 = num;
			num = (short)1789788160;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x001D781C File Offset: 0x001D5A1C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			while (this.b)
			{
				short num = (short)1316290023;
				short num2 = num;
				num = (short)1116470759;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)29622273;
					if (num != 0)
					{
					}
					num = (short)950861824;
					if (num != 0)
					{
					}
					num = (short)570294272;
					short num3 = num;
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒊ\ude8cﾎﲔ\udd9aﺞ햠횢힤슦\udaa8邪캬삮\udcb0쎲\udab4\ud9b6\udcb8햺즼邾ꋀꋂ꧄ꯆ流﷌ꏎ룐ꃒꇔ뻜냞迠藢賤胦鳨駪賬鯮飰鳲鯴\ud8f6賸飺釼裾栀朂怄⠆礈樊樌樎搐瀒礔怖瀘缚砜ㄞ夠䈢䠤䬦", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x001D7900 File Offset: 0x001D5B00
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)937885697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_287;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)1021444096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_3D9;
				case 2:
					goto IL_4C5;
				case 3:
					goto IL_6AB;
				case 4:
					goto IL_51D;
				case 5:
					goto IL_62C;
				case 6:
					goto IL_4B8;
				case 7:
					goto IL_17B;
				case 8:
					goto IL_4EC;
				case 9:
					goto IL_2B0;
				case 10:
					goto IL_5E1;
				case 11:
					goto IL_28C;
				case 12:
					goto IL_161;
				case 13:
					goto IL_35D;
				case 14:
					goto IL_1F9;
				case 15:
					goto IL_3A8;
				case 16:
					goto IL_2BD;
				case 17:
					goto IL_39B;
				case 18:
					goto IL_377;
				case 19:
					goto IL_339;
				case 20:
					goto IL_4DF;
				case 21:
					goto IL_541;
				case 22:
					goto IL_43F;
				case 23:
					goto IL_308;
				case 24:
					goto IL_2FB;
				case 25:
					goto IL_261;
				case 26:
					goto IL_55B;
				case 27:
					goto IL_470;
				case 28:
					goto IL_660;
				case 29:
					goto IL_612;
				case 30:
					goto IL_432;
				case 31:
					goto IL_653;
				case 32:
					goto IL_3CC;
				case 33:
					goto IL_646;
				case 34:
					goto IL_154;
				case 35:
					goto IL_1EC;
				case 36:
					goto IL_61F;
				case 37:
					goto IL_605;
				case 38:
					goto IL_32C;
				case 39:
					goto IL_66D;
				case 40:
					goto IL_54E;
				case 41:
					goto IL_1D2;
				case 42:
					goto IL_147;
				case 43:
					goto IL_67A;
				case 44:
					goto IL_5A3;
				case 45:
					goto IL_639;
				case 46:
					goto IL_463;
				case 47:
					goto IL_2D7;
				case 48:
					goto IL_4F9;
				case 49:
					goto IL_36A;
				case 50:
					goto IL_16E;
				case 51:
					goto IL_57F;
				case 52:
					goto IL_494;
				case 53:
					goto IL_21D;
				case 54:
					goto IL_2CA;
				case 55:
					goto IL_1DF;
				case 56:
					goto IL_5C7;
				case 57:
					goto IL_4D2;
				case 58:
					goto IL_5D4;
				case 59:
					goto IL_22A;
				case 60:
					goto IL_69E;
				default:
					num = (short)204472322;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_147:
			this.CVBtnMaxContacts = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_154:
			this.PhoneNumEditComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_161:
			this.RTDBtnUclEdit = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16E:
			this.CVBtnMaxHotlistContacts = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17B:
			num = (short)2012594105;
			short num3 = num;
			num = (short)1813888953;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_377:
				this.LblPhoneNumEdit = (global::AcpUI.AcpLabel)target;
				this.LblPhoneNumEdit.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
				num = (short)2036727808;
				if (num != 0)
				{
				}
				this.GrpBoxGeneral = (global::AcpUI.AcpGroupBox)target;
				return;
			}
			IL_1D2:
			this.StdGridLabtoolGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1DF:
			this.CpyBtnMaxContacts = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EC:
			this.CpyBtnRadioIdEdit = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F9:
			this.LblHotListEdit = (global::AcpUI.AcpLabel)target;
			this.LblHotListEdit.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21D:
			this.RTDBtnMaxHotlistContacts = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22A:
			num = (short)907673600;
			short num4 = num;
			this.CpyBtnMaxHotlistContacts = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_261:
			this.CVBtnOrderableItem = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_287:
			this.b = true;
			return;
			IL_28C:
			this.ChkBoxUclEdit = (global::AcpUI.AcpCheckBox)target;
			this.ChkBoxUclEdit.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B0:
			this.CVBtnUclEdit = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BD:
			this.RTDBtnHotListEdit = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CA:
			this.CompGrpBoxLabtool = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2D7:
			this.LblContactsCombinedDataMax = (global::AcpUI.AcpLabel)target;
			this.LblContactsCombinedDataMax.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2FB:
			this.RTDBtnRadioIdEdit = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_308:
			this.ChkBoxRadioIdEdit = (global::AcpUI.AcpCheckBox)target;
			this.ChkBoxRadioIdEdit.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32C:
			this.DataOderItemComp = (global::AcpUI.AcpOrderableListBox)target;
			return;
			IL_339:
			this.ChkBoxPhoneNumEdit = (global::AcpUI.AcpCheckBox)target;
			this.ChkBoxPhoneNumEdit.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35D:
			this.CVBtnHotListEdit = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36A:
			this.RTDBtnContactsCombDataMax = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_39B:
			this.CVBtnPhoneNumEdit = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A8:
			this.ChkBoxHotListEdit = (global::AcpUI.AcpCheckBox)target;
			this.ChkBoxHotListEdit.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3CC:
			this.HotListEditComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3D9:
			num = (short)61603841;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.Ucl.UclWide.PageUclWide)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.UclWide.PageUclWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_432:
			this.UclEditComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_43F:
			this.LblRadioIdEdit = (global::AcpUI.AcpLabel)target;
			this.LblRadioIdEdit.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_463:
			this.CVBtnContactsCombDataMax = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_470:
			this.OrderableItemTest = (global::AcpUI.AcpOrderableListBox)target;
			this.OrderableItemTest.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_494:
			this.TxtBoxMaxHotlistContacts = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxMaxHotlistContacts.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B8:
			this.ExpUclWideGen = (global::AcpUI.AcpExpander)target;
			return;
			IL_4C5:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4D2:
			this.CpyBtnContactsCombDataMax = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4DF:
			this.RTDBtnPhoneNumEdit = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4EC:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4F9:
			this.TxtBoxContactsCombDataMax = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxContactsCombDataMax.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_51D:
			this.HLinkUCLWideLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkUCLWideLabtool.Click += this.HLinkUclWideClick;
			return;
			IL_541:
			this.CVBtnRadioIdEdit = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_54E:
			this.GrpBoxLabtool = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_55B:
			this.LblOrderableItemTest = (global::AcpUI.AcpLabel)target;
			this.LblOrderableItemTest.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_57F:
			this.LblMaxHotlistContacts = (global::AcpUI.AcpLabel)target;
			this.LblMaxHotlistContacts.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A3:
			this.TxtBoxMaxContactNumbers = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxMaxContactNumbers.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5C7:
			this.MaxContactsComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_5D4:
			this.ContactsCombDataMaxComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_5E1:
			this.LblUclEdit = (global::AcpUI.AcpLabel)target;
			this.LblUclEdit.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_605:
			this.CpyBtnDataOderItem = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_612:
			this.CpyBtnUclEdit = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61F:
			this.RadioIdEditComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_62C:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_639:
			this.RTDBtnMaxContacts = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_646:
			this.CpyBtnPhoneNumEdit = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_653:
			this.CpyBtnHotListEdit = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_660:
			this.CompGrpBoxGeneral = (global::System.Windows.Controls.Grid)target;
			return;
			IL_66D:
			this.ExpUCLWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_67A:
			this.LblMaxContacts = (global::AcpUI.AcpLabel)target;
			this.LblMaxContacts.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_69E:
			this.MaxHotlistContactsComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_6AB:
			this.HLinkUclWideGen = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkUclWideGen.Click += this.HLinkUclWideClick;
		}

		// Token: 0x04000B39 RID: 2873
		private bool a;

		// Token: 0x04000B3A RID: 2874
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000B3B RID: 2875
		internal global::System.Windows.Documents.Hyperlink HLinkUclWideGen;

		// Token: 0x04000B3C RID: 2876
		internal global::System.Windows.Documents.Hyperlink HLinkUCLWideLabtool;

		// Token: 0x04000B3D RID: 2877
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000B3E RID: 2878
		internal global::AcpUI.AcpExpander ExpUclWideGen;

		// Token: 0x04000B3F RID: 2879
		internal global::AcpUI.AcpGroupBox GrpBoxGeneral;

		// Token: 0x04000B40 RID: 2880
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000B41 RID: 2881
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnUclEdit;

		// Token: 0x04000B42 RID: 2882
		internal global::AcpUI.AcpLabel LblUclEdit;

		// Token: 0x04000B43 RID: 2883
		internal global::AcpUI.AcpCheckBox ChkBoxUclEdit;

		// Token: 0x04000B44 RID: 2884
		internal global::AcpUI.AcpRtdButton RTDBtnUclEdit;

		// Token: 0x04000B45 RID: 2885
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnHotListEdit;

		// Token: 0x04000B46 RID: 2886
		internal global::AcpUI.AcpLabel LblHotListEdit;

		// Token: 0x04000B47 RID: 2887
		internal global::AcpUI.AcpCheckBox ChkBoxHotListEdit;

		// Token: 0x04000B48 RID: 2888
		internal global::AcpUI.AcpRtdButton RTDBtnHotListEdit;

		// Token: 0x04000B49 RID: 2889
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhoneNumEdit;

		// Token: 0x04000B4A RID: 2890
		internal global::AcpUI.AcpLabel LblPhoneNumEdit;

		// Token: 0x04000B4B RID: 2891
		internal global::AcpUI.AcpCheckBox ChkBoxPhoneNumEdit;

		// Token: 0x04000B4C RID: 2892
		internal global::AcpUI.AcpRtdButton RTDBtnPhoneNumEdit;

		// Token: 0x04000B4D RID: 2893
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioIdEdit;

		// Token: 0x04000B4E RID: 2894
		internal global::AcpUI.AcpLabel LblRadioIdEdit;

		// Token: 0x04000B4F RID: 2895
		internal global::AcpUI.AcpCheckBox ChkBoxRadioIdEdit;

		// Token: 0x04000B50 RID: 2896
		internal global::AcpUI.AcpRtdButton RTDBtnRadioIdEdit;

		// Token: 0x04000B51 RID: 2897
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnOrderableItem;

		// Token: 0x04000B52 RID: 2898
		internal global::AcpUI.AcpLabel LblOrderableItemTest;

		// Token: 0x04000B53 RID: 2899
		internal global::AcpUI.AcpOrderableListBox OrderableItemTest;

		// Token: 0x04000B54 RID: 2900
		internal global::System.Windows.Controls.Grid CompGrpBoxGeneral;

		// Token: 0x04000B55 RID: 2901
		internal global::AcpUI.AcpCopyButton CpyBtnUclEdit;

		// Token: 0x04000B56 RID: 2902
		internal global::AcpUI.AcpCheckBox UclEditComp;

		// Token: 0x04000B57 RID: 2903
		internal global::AcpUI.AcpCopyButton CpyBtnHotListEdit;

		// Token: 0x04000B58 RID: 2904
		internal global::AcpUI.AcpCheckBox HotListEditComp;

		// Token: 0x04000B59 RID: 2905
		internal global::AcpUI.AcpCopyButton CpyBtnPhoneNumEdit;

		// Token: 0x04000B5A RID: 2906
		internal global::AcpUI.AcpCheckBox PhoneNumEditComp;

		// Token: 0x04000B5B RID: 2907
		internal global::AcpUI.AcpCopyButton CpyBtnRadioIdEdit;

		// Token: 0x04000B5C RID: 2908
		internal global::AcpUI.AcpCheckBox RadioIdEditComp;

		// Token: 0x04000B5D RID: 2909
		internal global::AcpUI.AcpCopyButton CpyBtnDataOderItem;

		// Token: 0x04000B5E RID: 2910
		internal global::AcpUI.AcpOrderableListBox DataOderItemComp;

		// Token: 0x04000B5F RID: 2911
		internal global::AcpUI.AcpExpander ExpUCLWideLabtool;

		// Token: 0x04000B60 RID: 2912
		internal global::AcpUI.AcpGroupBox GrpBoxLabtool;

		// Token: 0x04000B61 RID: 2913
		internal global::System.Windows.Controls.Grid StdGridLabtoolGrp;

		// Token: 0x04000B62 RID: 2914
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMaxContacts;

		// Token: 0x04000B63 RID: 2915
		internal global::AcpUI.AcpLabel LblMaxContacts;

		// Token: 0x04000B64 RID: 2916
		internal global::AcpUI.AcpTextBox TxtBoxMaxContactNumbers;

		// Token: 0x04000B65 RID: 2917
		internal global::AcpUI.AcpRtdButton RTDBtnMaxContacts;

		// Token: 0x04000B66 RID: 2918
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactsCombDataMax;

		// Token: 0x04000B67 RID: 2919
		internal global::AcpUI.AcpLabel LblContactsCombinedDataMax;

		// Token: 0x04000B68 RID: 2920
		internal global::AcpUI.AcpTextBox TxtBoxContactsCombDataMax;

		// Token: 0x04000B69 RID: 2921
		internal global::AcpUI.AcpRtdButton RTDBtnContactsCombDataMax;

		// Token: 0x04000B6A RID: 2922
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMaxHotlistContacts;

		// Token: 0x04000B6B RID: 2923
		internal global::AcpUI.AcpLabel LblMaxHotlistContacts;

		// Token: 0x04000B6C RID: 2924
		internal global::AcpUI.AcpTextBox TxtBoxMaxHotlistContacts;

		// Token: 0x04000B6D RID: 2925
		internal global::AcpUI.AcpRtdButton RTDBtnMaxHotlistContacts;

		// Token: 0x04000B6E RID: 2926
		internal global::System.Windows.Controls.Grid CompGrpBoxLabtool;

		// Token: 0x04000B6F RID: 2927
		internal global::AcpUI.AcpCopyButton CpyBtnMaxContacts;

		// Token: 0x04000B70 RID: 2928
		internal global::AcpUI.AcpViewOnlyCtrl MaxContactsComp;

		// Token: 0x04000B71 RID: 2929
		internal global::AcpUI.AcpCopyButton CpyBtnContactsCombDataMax;

		// Token: 0x04000B72 RID: 2930
		internal global::AcpUI.AcpViewOnlyCtrl ContactsCombDataMaxComp;

		// Token: 0x04000B73 RID: 2931
		internal global::AcpUI.AcpCopyButton CpyBtnMaxHotlistContacts;

		// Token: 0x04000B74 RID: 2932
		internal global::AcpUI.AcpViewOnlyCtrl MaxHotlistContactsComp;

		// Token: 0x04000B75 RID: 2933
		private bool b;
	}
}
