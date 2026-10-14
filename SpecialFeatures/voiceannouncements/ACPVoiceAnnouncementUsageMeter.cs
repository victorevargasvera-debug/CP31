using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.VoiceAnnouncements
{
	// Token: 0x02000012 RID: 18
	public class ACPVoiceAnnouncementUsageMeter : global::System.Windows.Navigation.PageFunction<string>, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002603 File Offset: 0x00000803
		public ACPVoiceAnnouncementUsageMeter()
		{
			this.InitializeComponent();
			this.c = null;
			global::AcpUI.Common.Utility.SetDirection(this);
			this.b();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000AA78 File Offset: 0x00008C78
		protected override void Start()
		{
			short num = (short)1319374199;
			short num2 = num;
			num = (short)1904086391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)698875904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)716177408;
			if (num != 0)
			{
			}
			num = (short)855441409;
			if (num != 0)
			{
			}
			this.c = (global::System.Windows.Window)base.Parent;
			this.c.Closing += this.parent_Closing;
			base.Start();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000AB50 File Offset: 0x00008D50
		private void parent_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			short num = (short)47631114;
			short num2 = num;
			num = (short)300534538;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1280311296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)177340417;
			if (num != 0)
			{
			}
			num = (short)1217855488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		private void b()
		{
			int a_ = 2;
			short num = (short)530972672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)298975233;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				int num4;
				double num6;
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
				for (;;)
				{
					IL_58:
					int voiceFilesTotalMS;
					switch (num2)
					{
					case 0:
					{
						num = (short)75038720;
						short num3 = num;
						if (num4 > 0)
						{
							num = (short)1013907461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					case 1:
					{
						if (voiceFilesTotalMS <= 0)
						{
							goto IL_238;
						}
						num = (short)2082664013;
						short num5 = num;
						num = (short)994831949;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C3;
						default:
							num = (short)1158086656;
							if (num != 0)
							{
							}
							num = (short)890568706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						this.vaUnitsLabel.Content = global::CommonResources.AppResources.Seconds_ID;
						this.vaMaxLabel.Content = 1000;
						num6 = (double)voiceFilesTotalMS / 1000000.0;
						num = (short)815136772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num4 = voiceAnnouncementListRecSet.Count;
						num = (short)166133767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_236;
					case 5:
						goto IL_1C3;
					case 6:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)839450627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151;
					case 7:
						goto IL_151;
					}
					goto IL_7F;
					IL_151:
					voiceFilesTotalMS = global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.VoiceFilesTotalMS;
					num6 = 0.0;
					num = (short)1249312768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C3:
					num = (short)882507777;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_236:
				IL_238:
				num6 *= 100.0;
				num6 = global::System.Math.Ceiling(num6);
				this.vaMemoryUsageBar1.Value = num6;
				this.vaUseageTextLabel1.Content = num6.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎄랆", a_));
				return;
				IL_7F:
				num4 = 0;
				voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
				num = (short)1723662342;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000AE7C File Offset: 0x0000907C
		private void a()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			short num2;
			double num4;
			int num6;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1717960704;
					short num3 = num2;
					this.vaUnitsLabel.Content = global::CommonResources.AppResources.Seconds_ID;
					this.vaMaxLabel.Content = 1000;
					int num5;
					num4 = (double)num5 / 1000000.0;
					num2 = (short)18350081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_12F;
				case 2:
					if (num4 >= 500.0)
					{
						num2 = (short)193134592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.vaUnitsLabel.Content = global::CommonResources.AppResources.Files_Id;
					this.vaMaxLabel.Content = 2000;
					num4 = (double)num6 / 2000.0;
					num2 = (short)2093547524;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)23265285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_24E;
				case 5:
				{
					num2 = (short)1304756225;
					if (num2 != 0)
					{
					}
					int num5;
					if (num5 > 0)
					{
						num2 = (short)88670215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_250;
				}
				case 6:
					goto IL_C2;
				case 7:
				{
					int num5;
					num4 = (double)num5 / (double)num6;
					num2 = (short)2121596930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_39;
			}
			IL_C2:
			if (num6 > 0)
			{
				goto IL_C9;
			}
			IL_12F:
			IL_24E:
			IL_250:
			num4 *= 100.0;
			num4 = global::System.Math.Ceiling(num4);
			this.vaMemoryUsageBar1.Value = num4;
			this.vaUseageTextLabel1.Content = num4.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삅뢇", a_));
			return;
			IL_39:
			num2 = (short)1760306489;
			short num7 = num2;
			num2 = (short)1275012409;
			switch ((num7 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C9:
				num2 = (short)474021891;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)2107572224;
				if (num2 != 0)
				{
				}
				global::System.Random random = new global::System.Random();
				num6 = random.Next(2000);
				int num5 = random.Next(1000000);
				num4 = 0.0;
				num2 = (short)1502412806;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000B118 File Offset: 0x00009318
		private void vaUsageMeterRefreshButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1091966508;
			short num2 = num;
			num = (short)1829770796;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1721237504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)879886336;
			if (num != 0)
			{
			}
			num = (short)1347354625;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000B1C8 File Offset: 0x000093C8
		private void vaUsageCloseButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)618187290;
					short num3 = num2;
					num2 = (short)1323289114;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)36700160;
						if (num2 != 0)
						{
						}
						this.c.DialogResult = new bool?(true);
						num2 = (short)736559106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)346030081;
					if (num2 != 0)
					{
					}
					if (this.c != null)
					{
						num2 = (short)117178368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				case 2:
					goto IL_113;
				}
				goto IL_25;
			}
			IL_113:
			IL_115:
			num2 = (short)1392574464;
			short num4 = num2;
			return;
			IL_25:
			this.OnReturn(new global::System.Windows.Navigation.ReturnEventArgs<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킔ﮞ", a_)));
			num2 = (short)1293156353;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000B314 File Offset: 0x00009514
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)708640769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C4;
				case 1:
				{
					num = (short)406099833;
					short num3 = num;
					num = (short)494770041;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						num = (short)2131296256;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_7B:
				num = (short)584974337;
				if (num != 0)
				{
				}
				if (!base.IsKeyboardFocusWithin)
				{
					num = (short)933363712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C4:
				num = (short)34406400;
				short num4 = num;
				global::System.Windows.Input.Keyboard.Focus(this);
				num = (short)227540994;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000B430 File Offset: 0x00009630
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)747953068;
			short num2 = num;
			num = (short)1832049580;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1984430080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)528023552;
			if (num != 0)
			{
			}
			num = (short)305659905;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000B4E0 File Offset: 0x000096E0
		private void vaUsageHelpButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)992608257;
				if (num != 0)
				{
				}
				num = (short)1980844776;
				short num2 = num;
				num = (short)315968232;
				switch (num2 == num)
				{
				}
				num = (short)1948385280;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖅ릇뢍ꖏ꒑꾕", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1799815168;
			short num3 = num;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000B5BC File Offset: 0x000097BC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num;
			if (this.d)
			{
				num = (short)1096256260;
				short num2 = num;
				num = (short)454462212;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1484849152;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1502740480;
			short num3 = num;
			num = (short)2093285377;
			if (num != 0)
			{
			}
			this.d = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂎ슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮튰\udcb2\ud8b4잶횸햺\ud8bc톾뗀도꣆ꃈ꣊꣌껎뿐뷒뫔ꋖ럘룚룜닞蓠跢釤铦웨鷪苬蛮鋰雲铴駶韸铺裼釾戀昂栄戆月缊渌渎紐瀒怔笖砘漚砜樞䠠ఢ䐤䐦夨崪䈬䘮到嘲吴夶圸吺䠼儾≀♂⡄≆❈㽊㡌㱎ぐ㑒ご㩖㱘⽚㡜ⵞ你᭢Ѥ੦ը", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000B69C File Offset: 0x0000989C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1038090242;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)462422017;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_249;
				case 1:
					num = (short)1731592192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				switch (connectionId)
				{
				case 1:
					goto IL_11F;
				case 2:
					goto IL_CC;
				case 3:
					goto IL_19D;
				case 4:
				{
					num = (short)1359017886;
					short num3 = num;
					num = (short)1623390110;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_20F;
					}
					break;
				}
				case 5:
					goto IL_24E;
				case 6:
					goto IL_190;
				case 7:
					goto IL_BF;
				case 8:
					goto IL_1CE;
				case 9:
					goto IL_B2;
				case 10:
					goto IL_137;
				case 11:
					goto IL_FB;
				case 12:
					goto IL_1AA;
				case 13:
					goto IL_144;
				}
				num = (short)903479297;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B2:
			this.vaUseageTextLabel1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_BF:
			this.vaUsageLabel1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_CC:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.vaUsageHelpButton_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_FB:
			this.vaUsageMeterRefreshButton = (global::System.Windows.Controls.Button)target;
			this.vaUsageMeterRefreshButton.Click += this.vaUsageMeterRefreshButton_Click;
			return;
			IL_11F:
			((global::SpecialFeatures.VoiceAnnouncements.ACPVoiceAnnouncementUsageMeter)target).Loaded += this.OnLoaded;
			return;
			IL_137:
			this.vaPercentLabel = (global::System.Windows.Controls.Label)target;
			return;
			IL_144:
			num = (short)1915355136;
			short num4 = num;
			this.vaUsageHelpButton = (global::System.Windows.Controls.Button)target;
			this.vaUsageHelpButton.Click += this.vaUsageHelpButton_Click;
			return;
			IL_190:
			this.vaUnitsLabel = (global::System.Windows.Controls.Label)target;
			return;
			IL_19D:
			this.vaMemoryUsageGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1AA:
			this.vaUsageCloseButton = (global::System.Windows.Controls.Button)target;
			this.vaUsageCloseButton.Click += this.vaUsageCloseButton_Click;
			return;
			IL_1CE:
			this.vaMemoryUsageBar1 = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_20F:
			num = (short)419692544;
			if (num != 0)
			{
			}
			this.vaMinimumLabel = (global::System.Windows.Controls.Label)target;
			return;
			IL_249:
			this.d = true;
			return;
			IL_24E:
			this.vaMaxLabel = (global::System.Windows.Controls.Label)target;
		}

		// Token: 0x0400001C RID: 28
		private const int a = 2000;

		// Token: 0x0400001D RID: 29
		private const int b = 1000;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Window c;

		// Token: 0x0400001F RID: 31
		internal global::System.Windows.Controls.Grid vaMemoryUsageGrid;

		// Token: 0x04000020 RID: 32
		internal global::System.Windows.Controls.Label vaMinimumLabel;

		// Token: 0x04000021 RID: 33
		internal global::System.Windows.Controls.Label vaMaxLabel;

		// Token: 0x04000022 RID: 34
		internal global::System.Windows.Controls.Label vaUnitsLabel;

		// Token: 0x04000023 RID: 35
		internal global::System.Windows.Controls.Label vaUsageLabel1;

		// Token: 0x04000024 RID: 36
		internal global::System.Windows.Controls.ProgressBar vaMemoryUsageBar1;

		// Token: 0x04000025 RID: 37
		internal global::System.Windows.Controls.Label vaUseageTextLabel1;

		// Token: 0x04000026 RID: 38
		internal global::System.Windows.Controls.Label vaPercentLabel;

		// Token: 0x04000027 RID: 39
		internal global::System.Windows.Controls.Button vaUsageMeterRefreshButton;

		// Token: 0x04000028 RID: 40
		internal global::System.Windows.Controls.Button vaUsageCloseButton;

		// Token: 0x04000029 RID: 41
		internal global::System.Windows.Controls.Button vaUsageHelpButton;

		// Token: 0x0400002A RID: 42
		private bool d;
	}
}
