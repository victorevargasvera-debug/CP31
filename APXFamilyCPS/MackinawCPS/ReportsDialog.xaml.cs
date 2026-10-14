using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using MackinawCPS.Properties;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.AcpReportManagerLib;

namespace MackinawCPS
{
	// Token: 0x0200003D RID: 61
	public partial class ReportsDialog : Window
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0005505C File Offset: 0x0005325C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0005510C File Offset: 0x0005330C
		internal bool Is_RadioInfo_Clicked
		{
			get
			{
				short num = (short)1356952179;
				short num2 = num;
				num = (short)1959555699;
				switch (num2 == num)
				{
				}
				num = (short)403243008;
				if (num != 0)
				{
				}
				num = (short)667746304;
				short num3 = num;
				num = (short)1257308161;
				if (num != 0)
				{
				}
				return this.is_RadioInfo_Clicked;
			}
			set
			{
				short num = (short)388431873;
				if (num != 0)
				{
				}
				num = (short)952518575;
				short num2 = num;
				num = (short)906971055;
				switch (num2 == num)
				{
				}
				num = (short)72810496;
				short num3 = num;
				num = (short)1436483584;
				if (num != 0)
				{
				}
				this.is_RadioInfo_Clicked = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000551BC File Offset: 0x000533BC
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0005526C File Offset: 0x0005346C
		internal bool Is_PorHandout_Clicked
		{
			get
			{
				short num = (short)736428033;
				if (num != 0)
				{
				}
				num = (short)2109218780;
				short num2 = num;
				num = (short)1998790620;
				switch (num2 == num)
				{
				}
				num = (short)1259798528;
				short num3 = num;
				num = (short)744357888;
				if (num != 0)
				{
				}
				return this.is_PorHandout_Clicked;
			}
			set
			{
				short num = (short)1550974977;
				if (num != 0)
				{
				}
				num = (short)1325012692;
				short num2 = num;
				num = (short)1508513492;
				switch (num2 == num)
				{
				}
				num = (short)7143424;
				short num3 = num;
				num = (short)2035679232;
				if (num != 0)
				{
				}
				this.is_PorHandout_Clicked = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0005531C File Offset: 0x0005351C
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000553CC File Offset: 0x000535CC
		internal bool Is_O2Handout_Clicked
		{
			get
			{
				short num = (short)466485249;
				if (num != 0)
				{
				}
				num = (short)365324119;
				short num2 = num;
				num = (short)1293182807;
				switch (num2 == num)
				{
				}
				num = (short)2088697856;
				short num3 = num;
				num = (short)1681326080;
				if (num != 0)
				{
				}
				return this.is_O2Handout_Clicked;
			}
			set
			{
				short num = (short)673126606;
				short num2 = num;
				num = (short)175053006;
				switch (num2 == num)
				{
				}
				num = (short)464781313;
				if (num != 0)
				{
				}
				num = (short)764411904;
				short num3 = num;
				num = (short)2000158720;
				if (num != 0)
				{
				}
				this.is_O2Handout_Clicked = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00055480 File Offset: 0x00053680
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00055534 File Offset: 0x00053734
		internal bool Is_O3Handout_Clicked
		{
			get
			{
				short num = (short)1428923260;
				short num2 = num;
				num = (short)458924924;
				switch (num2 == num)
				{
				}
				num = (short)467861505;
				if (num != 0)
				{
				}
				num = (short)1215037440;
				short num3 = num;
				num = (short)669057024;
				if (num != 0)
				{
				}
				return this.is_O3Handout_Clicked;
			}
			set
			{
				short num = (short)1893689037;
				short num2 = num;
				num = (short)1593272013;
				switch (num2 == num)
				{
				}
				num = (short)2092367873;
				if (num != 0)
				{
				}
				num = (short)278659072;
				short num3 = num;
				num = (short)1727725568;
				if (num != 0)
				{
				}
				this.is_O3Handout_Clicked = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000555E4 File Offset: 0x000537E4
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00055694 File Offset: 0x00053894
		internal bool Is_O7Handout_Clicked
		{
			get
			{
				short num = (short)843447460;
				short num2 = num;
				num = (short)1663106212;
				switch (num2 == num)
				{
				}
				num = (short)702545921;
				if (num != 0)
				{
				}
				num = (short)728104960;
				short num3 = num;
				num = (short)1643249664;
				if (num != 0)
				{
				}
				return this.is_O7Handout_Clicked;
			}
			set
			{
				short num = (short)2068140153;
				short num2 = num;
				num = (short)749817977;
				switch (num2 == num)
				{
				}
				num = (short)360382465;
				if (num != 0)
				{
				}
				num = (short)686817280;
				short num3 = num;
				num = (short)1474166784;
				if (num != 0)
				{
				}
				this.is_O7Handout_Clicked = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00055748 File Offset: 0x00053948
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000557F8 File Offset: 0x000539F8
		internal bool Is_E5Handout_Clicked
		{
			get
			{
				short num = (short)1458808804;
				short num2 = num;
				num = (short)1628612580;
				switch (num2 == num)
				{
				}
				num = (short)128581632;
				if (num != 0)
				{
				}
				num = (short)1289093120;
				short num3 = num;
				num = (short)2033647617;
				if (num != 0)
				{
				}
				return this.is_E5Handout_Clicked;
			}
			set
			{
				short num = (short)1614769101;
				short num2 = num;
				num = (short)1945529293;
				switch (num2 == num)
				{
				}
				num = (short)703463424;
				if (num != 0)
				{
				}
				num = (short)722796544;
				short num3 = num;
				num = (short)1810104321;
				if (num != 0)
				{
				}
				this.is_E5Handout_Clicked = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000558A8 File Offset: 0x00053AA8
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00055958 File Offset: 0x00053B58
		internal bool Is_O5Handout_Clicked
		{
			get
			{
				short num = (short)2077780585;
				short num2 = num;
				num = (short)1202612841;
				switch (num2 == num)
				{
				}
				num = (short)1964179456;
				if (num != 0)
				{
				}
				num = (short)1332674560;
				short num3 = num;
				num = (short)126615553;
				if (num != 0)
				{
				}
				return this.is_O5Handout_Clicked;
			}
			set
			{
				short num = (short)666840565;
				short num2 = num;
				num = (short)2146840053;
				switch (num2 == num)
				{
				}
				num = (short)2130116608;
				if (num != 0)
				{
				}
				num = (short)1128333312;
				short num3 = num;
				num = (short)1855389697;
				if (num != 0)
				{
				}
				this.is_O5Handout_Clicked = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00055A08 File Offset: 0x00053C08
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00055AB8 File Offset: 0x00053CB8
		internal bool Is_O9Handout_Clicked
		{
			get
			{
				short num = (short)1510107548;
				short num2 = num;
				num = (short)1650551196;
				switch (num2 == num)
				{
				}
				num = (short)701104128;
				if (num != 0)
				{
				}
				num = (short)219676672;
				short num3 = num;
				num = (short)176029697;
				if (num != 0)
				{
				}
				return this.is_O9Handout_Clicked;
			}
			set
			{
				short num = (short)1062038357;
				short num2 = num;
				num = (short)149318485;
				switch (num2 == num)
				{
				}
				num = (short)2105737217;
				if (num != 0)
				{
				}
				num = (short)1201405952;
				short num3 = num;
				num = (short)504233984;
				if (num != 0)
				{
				}
				this.is_O9Handout_Clicked = value;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00055B68 File Offset: 0x00053D68
		internal ReportsDialog(WindowMain parent)
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this._parent = parent;
			this.repDiaSettings = this._parent.settingsSavedOnAppExit;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00055BB8 File Offset: 0x00053DB8
		private void OnLoad(object sender, RoutedEventArgs e)
		{
			int a_ = 16;
			short num = (short)2094858240;
			short num2 = num;
			num = (short)2145189888;
			int num3 = (int)num;
			switch (num3)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				for (;;)
				{
					IL_59:
					bool flag;
					IEnumerator enumerator;
					switch (num3)
					{
					case 0:
						if (!flag)
						{
							num = (short)54198273;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						CultureInfo cultureInfo = new CultureInfo(App.mainAssemblyCulture);
						this.reportLangChoice.SelectedItem = cultureInfo.NativeName;
						num = (short)1359937540;
						num3 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						this.reportsLanguageSelection = this.repDiaSettings.UserSelectedReportsLanguage;
						num = (short)570032133;
						num3 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_C6;
						try
						{
							for (;;)
							{
								IL_C6:
								num = (short)527171589;
								num3 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)157417473;
										num3 = (int)((IntPtr)num);
										continue;
									case 1:
										goto IL_232;
									case 2:
									{
										if (enumerator.MoveNext())
										{
											KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)enumerator.Current;
											num = (short)2011234307;
											num3 = (int)((IntPtr)num);
											continue;
										}
										num = (short)1591721328;
										short num4 = num;
										num = (short)1163967856;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_C6;
										default:
											num = (short)648937472;
											if (num != 0)
											{
											}
											num = (short)1223622656;
											num3 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										KeyValuePair<string, string> keyValuePair;
										if (keyValuePair.Value == this.reportsLanguageSelection)
										{
											num = (short)1262682116;
											num3 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										KeyValuePair<string, string> keyValuePair;
										this.reportLangChoice.SelectedItem = keyValuePair.Key;
										flag = true;
										num = (short)1913716742;
										num3 = (int)((IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_108;
										}
										continue;
									case 6:
										goto IL_138;
									}
									IL_191:
									num = (short)1332346882;
									num3 = (int)((IntPtr)num);
									continue;
									IL_108:
									goto IL_191;
								}
							}
							IL_138:
							IL_232:
							goto IL_369;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_254;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_241:
								switch (num3)
								{
								case 0:
									disposable.Dispose();
									num = (short)435879937;
									num3 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_2A7;
								case 2:
									if (disposable != null)
									{
										num = (short)1636892672;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2A9;
								}
								goto IL_254;
							}
							IL_2A7:
							IL_2A9:
							goto EndFinally_8;
							IL_254:
							disposable = (enumerator as IDisposable);
							num = (short)1814102018;
							num3 = (int)((IntPtr)num);
							goto IL_241;
							EndFinally_8:;
						}
						goto IL_2AA;
						IL_369:
						num = (short)1170735104;
						num3 = (int)((IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						goto IL_3A4;
					case 6:
						if (this.repDiaSettings.UserSelectedReportsLanguage != null)
						{
							num = (short)1956642818;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 7:
						goto IL_3A4;
					}
					goto IL_80;
					IL_2AA:
					num = (short)1544224769;
					if (num != 0)
					{
					}
					this.reportsLanguageSelection = FixedLengthStream.b("闯鳱", a_);
					num = (short)804847623;
					num3 = (int)((IntPtr)num);
					continue;
					IL_3A4:
					this.reportLangChoice.SelectedItem = this.reportsLanguageSelection;
					flag = false;
					enumerator = ((IEnumerable)App.AdditionalCPSLanguages).GetEnumerator();
					num = (short)1808400387;
					num3 = (int)((IntPtr)num);
				}
				return;
				IL_80:
				this.PopulateComboBox();
				num = (short)360120326;
				num3 = (int)((IntPtr)num);
				goto IL_59;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00055FC4 File Offset: 0x000541C4
		private void F1HelpCommandCanExcute(object sender, CanExecuteRoutedEventArgs e)
		{
			short num = (short)1109636907;
			short num2 = num;
			num = (short)810268459;
			switch (num2 == num)
			{
			}
			num = (short)2049572864;
			if (num != 0)
			{
			}
			num = (short)1406664704;
			short num3 = num;
			num = (short)1884618753;
			if (num != 0)
			{
			}
			e.CanExecute = true;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00056078 File Offset: 0x00054278
		private void buttonHelp_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)509341751;
				short num2 = num;
				num = (short)1249505335;
				switch (num2 == num)
				{
				}
				num = (short)1577385984;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(FixedLengthStream.b("폯釱闳郵髷죹엻죽拿", a_));
			}
			catch (Exception)
			{
			}
			num = (short)218890240;
			short num3 = num;
			num = (short)821297153;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00056158 File Offset: 0x00054358
		private void buttonOK_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 19;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				int num;
				string text;
				AcpReportMgrLib acpReportMgrLib;
				for (;;)
				{
					IL_13:
					bool? isChecked;
					switch (num)
					{
					case 0:
						if (this.reportsLanguageSelection != text)
						{
							num2 = (short)1554907154;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5B1;
					case 1:
						goto IL_431;
					case 2:
						if (this.Is_O2Handout_Clicked)
						{
							num2 = (short)49872916;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)692518943;
						num = (int)((IntPtr)num2);
						continue;
					case 3:
						goto IL_5FD;
					case 4:
						AppInfoManager.ReportsLangSelection = FixedLengthStream.b("雲鯴", a_);
						num2 = (short)894894081;
						num = (int)((IntPtr)num2);
						continue;
					case 5:
						this.repDiaSettings.ReportLangDia = false;
						this.repDiaSettings.UserSelectedReportsLanguage = App.AdditionalCPSLanguages[text];
						AppInfoManager.ReportsLangSelection = this.repDiaSettings.UserSelectedReportsLanguage;
						num2 = (short)1381957654;
						num = (int)((IntPtr)num2);
						continue;
					case 6:
						goto IL_5FD;
					case 7:
						acpReportMgrLib.GenerateReport(reportType.HandOutO9);
						num2 = (short)1168703516;
						num = (int)((IntPtr)num2);
						continue;
					case 8:
						acpReportMgrLib.GenerateReport(reportType.RadioInfo);
						num2 = (short)242089997;
						num = (int)((IntPtr)num2);
						continue;
					case 9:
						goto IL_162;
					case 10:
						goto IL_5FD;
					case 11:
						goto IL_5FD;
					case 12:
						acpReportMgrLib.GenerateReport(reportType.HandOutO7);
						num2 = (short)1690959875;
						num = (int)((IntPtr)num2);
						continue;
					case 13:
						goto IL_5FD;
					case 14:
						acpReportMgrLib.GenerateReport(reportType.HandOutO3);
						num2 = (short)2077032480;
						num = (int)((IntPtr)num2);
						continue;
					case 15:
						goto IL_615;
					case 16:
						if (isChecked.Value)
						{
							num2 = (short)1385299973;
							num = (int)((IntPtr)num2);
							continue;
						}
						this.repDiaSettings.ReportLangDia = true;
						num2 = (short)1364262921;
						num = (int)((IntPtr)num2);
						continue;
					case 17:
						if (string.IsNullOrEmpty(AppInfoManager.ReportsLangSelection))
						{
							num2 = (short)2012020740;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_431;
					case 18:
						AppInfoManager.ReportsLangSelection = App.AdditionalCPSLanguages[text];
						this.repDiaSettings.UserSelectedReportsLanguage = AppInfoManager.ReportsLangSelection;
						num2 = (short)526843938;
						num = (int)((IntPtr)num2);
						continue;
					case 19:
						goto IL_5FD;
					case 20:
						acpReportMgrLib.GenerateReport(reportType.HandOutO2);
						num2 = (short)537722891;
						num = (int)((IntPtr)num2);
						continue;
					case 21:
						acpReportMgrLib.GenerateReport(reportType.HandOutE5);
						num2 = (short)42139654;
						num = (int)((IntPtr)num2);
						continue;
					case 22:
						goto IL_162;
					case 23:
						if (this.Is_RadioInfo_Clicked)
						{
							num2 = (short)242679816;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)298778653;
						num = (int)((IntPtr)num2);
						continue;
					case 24:
						if (this.Is_E5Handout_Clicked)
						{
							num2 = (short)1636696085;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_4C6;
					case 25:
						if (this.Is_O7Handout_Clicked)
						{
							num2 = (short)1000013836;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1096024091;
						num = (int)((IntPtr)num2);
						continue;
					case 26:
						acpReportMgrLib.GenerateReport(reportType.HandOut);
						num2 = (short)1134297107;
						num = (int)((IntPtr)num2);
						continue;
					case 27:
						num2 = (short)1488977921;
						if (num2 != 0)
						{
						}
						if (this.Is_O9Handout_Clicked)
						{
							num2 = (short)1488125959;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5FD;
					case 28:
						goto IL_5FD;
					case 29:
						if (this.Is_PorHandout_Clicked)
						{
							num2 = (short)830996506;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1028521986;
						num = (int)((IntPtr)num2);
						continue;
					case 30:
						acpReportMgrLib.GenerateReport(reportType.HandOutO5);
						num2 = (short)2021785610;
						num = (int)((IntPtr)num2);
						continue;
					case 31:
						if (this.Is_O3Handout_Clicked)
						{
							num2 = (short)67371022;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)752025624;
						num = (int)((IntPtr)num2);
						continue;
					case 32:
					{
						num2 = (short)355812217;
						short num3 = num2;
						num2 = (short)873546617;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C6;
						default:
							num2 = (short)668073984;
							if (num2 != 0)
							{
							}
							goto IL_5FD;
						}
						break;
					}
					case 33:
						if (this.Is_O5Handout_Clicked)
						{
							num2 = (short)596443166;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)869793817;
						num = (int)((IntPtr)num2);
						continue;
					case 34:
						goto IL_5B1;
					}
					goto IL_A5;
					IL_162:
					num2 = (short)895352849;
					num = (int)((IntPtr)num2);
					continue;
					IL_431:
					Settings.Default.Save();
					base.Close();
					num2 = (short)476839959;
					num = (int)((IntPtr)num2);
					continue;
					IL_4C6:
					num2 = (short)1204224033;
					num = (int)((IntPtr)num2);
					continue;
					IL_5B1:
					isChecked = this.reportDiaChkbox.IsChecked;
					num2 = (short)734003216;
					num = (int)((IntPtr)num2);
					continue;
					IL_5FD:
					num2 = (short)18939919;
					num = (int)((IntPtr)num2);
				}
				IL_615:
				goto IL_625;
				IL_A5:
				acpReportMgrLib = new AcpReportMgrLib();
				text = (string)this.reportLangChoice.SelectedItem;
				num2 = (short)1864433664;
				num = (int)((IntPtr)num2);
				goto IL_13;
			}
			catch (Exception)
			{
				MessageBox.Show(AppResources.Report_Gen_Failed);
			}
			IL_625:
			num2 = (short)2026504192;
			short num4 = num2;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000567D0 File Offset: 0x000549D0
		private void PopulateComboBox()
		{
			short num = (short)1668546560;
			short num2 = num;
			num = (short)815726592;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)1749841782;
				short num4 = num;
				num = (short)1100642166;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F7:
					num = (short)1084096514;
					num3 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1611464704;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B0;
					}
					break;
				}
				for (;;)
				{
					IL_9D:
					IEnumerator enumerator;
					switch (num3)
					{
					case 0:
						goto IL_E7;
					case 1:
						try
						{
							num = (short)2121728003;
							num3 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									KeyValuePair<string, string> keyValuePair;
									if (keyValuePair.Key != null)
									{
										num = (short)903741446;
										num3 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)206372866;
										num3 = (int)((IntPtr)num);
										continue;
									}
									KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)enumerator.Current;
									num = (short)1262944256;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 2:
									num = (short)834732037;
									num3 = (int)((IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_17D;
									}
									continue;
								case 5:
									goto IL_246;
								case 6:
								{
									KeyValuePair<string, string> keyValuePair;
									this.reportLangChoice.Items.Add(keyValuePair.Key);
									num = (short)121372676;
									num3 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_17F:
								num = (short)2098921473;
								num3 = (int)((IntPtr)num);
								continue;
								IL_17D:
								goto IL_17F;
							}
							IL_246:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_268;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_255:
								switch (num3)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1727594498;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2BB;
								case 1:
									goto IL_2B9;
								case 2:
									disposable.Dispose();
									num = (short)2110783489;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_268;
							}
							IL_2B9:
							IL_2BB:
							goto EndFinally_6;
							IL_268:
							disposable = (enumerator as IDisposable);
							num = (short)526057472;
							num3 = (int)((IntPtr)num);
							goto IL_255;
							EndFinally_6:;
						}
						goto IL_2BC;
					case 2:
						num = (short)1364590593;
						if (num != 0)
						{
						}
						goto IL_2BC;
					}
					goto IL_B0;
					IL_2BC:
					enumerator = ((IEnumerable)App.AdditionalCPSLanguages).GetEnumerator();
					num = (short)689569793;
					num3 = (int)((IntPtr)num);
				}
				IL_E7:
				if (App.AdditionalCPSLanguages.Count > 0)
				{
					goto IL_F7;
				}
				return;
				IL_B0:
				CultureInfo cultureInfo = new CultureInfo(App.mainAssemblyCulture);
				this.reportLangChoice.Items.Add(cultureInfo.NativeName);
				num = (short)2138570752;
				num3 = (int)((IntPtr)num);
				goto IL_9D;
			}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00056AE0 File Offset: 0x00054CE0
		private void buttonCancel_Click(object sender, RoutedEventArgs e)
		{
			short num = (short)1904939127;
			short num2 = num;
			num = (short)800460919;
			switch (num2 == num)
			{
			default:
			{
				num = (short)241565696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)612564993;
			if (num != 0)
			{
			}
			num = (short)82640896;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x0400013E RID: 318
		private WindowMain _parent;

		// Token: 0x0400013F RID: 319
		private string reportsLanguageSelection = string.Empty;

		// Token: 0x04000140 RID: 320
		private string locale = string.Empty;

		// Token: 0x04000141 RID: 321
		private Settings repDiaSettings;

		// Token: 0x04000142 RID: 322
		private bool is_RadioInfo_Clicked;

		// Token: 0x04000143 RID: 323
		private bool is_PorHandout_Clicked;

		// Token: 0x04000144 RID: 324
		private bool is_O2Handout_Clicked;

		// Token: 0x04000145 RID: 325
		private bool is_O3Handout_Clicked;

		// Token: 0x04000146 RID: 326
		private bool is_O7Handout_Clicked;

		// Token: 0x04000147 RID: 327
		private bool is_E5Handout_Clicked;

		// Token: 0x04000148 RID: 328
		private bool is_O5Handout_Clicked;

		// Token: 0x04000149 RID: 329
		private bool is_O9Handout_Clicked;

		// Token: 0x04000151 RID: 337
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
