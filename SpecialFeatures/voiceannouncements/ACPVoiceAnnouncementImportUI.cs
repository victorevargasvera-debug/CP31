using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using ACPBrowser;
using AcpUI.Common;
using ACPVoiceAnnouncementLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements
{
	// Token: 0x02000013 RID: 19
	public class ACPVoiceAnnouncementImportUI : global::System.Windows.Navigation.PageFunction<string>, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000B90C File Offset: 0x00009B0C
		public ACPVoiceAnnouncementImportUI()
		{
			int a_ = 12;
			this.d = new global::SpecialFeatures.SpecialFeaturesSettings();
			base..ctor();
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			this.a = false;
			this.b = null;
			this.c = null;
			this.txtboxSelectWavFilesPath.Text = this.b();
			this.txtboxSelectConvertedFilesPath.Text = this.a();
			this.listAvailableWavFiles.SelectionMode = global::System.Windows.Controls.SelectionMode.Multiple;
			this.c();
			if (global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
			{
				this.txtboxSelectWavFilesPath.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
				this.txtboxSelectWavFilesPath.TextAlignment = global::System.Windows.TextAlignment.Right;
				this.txtboxSelectConvertedFilesPath.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
				this.txtboxSelectConvertedFilesPath.TextAlignment = global::System.Windows.TextAlignment.Right;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public override void OnApplyTemplate()
		{
			int a_ = 14;
			for (;;)
			{
				IL_09:
				short num = (short)402849792;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					global::System.Windows.Style style2;
					for (;;)
					{
						IL_30:
						global::System.Windows.Style style;
						switch (num2)
						{
						case 0:
						{
							num = (short)1722849295;
							short num3 = num;
							num = (short)224172047;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
							{
								num = (short)1290338304;
								if (num != 0)
								{
								}
								num = (short)61014016;
								short num4 = num;
								global::System.Windows.Style itemContainerStyle = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ListViewItem), style);
								this.vaConvertListView.ItemContainerStyle = itemContainerStyle;
								num = (short)679280641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							return;
						case 2:
						{
							global::System.Windows.Style itemContainerStyle2 = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ListViewItem), style2);
							this.listAvailableWavFiles.ItemContainerStyle = itemContainerStyle2;
							num = (short)727187459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_105;
						case 4:
							if (style != null)
							{
								num = (short)1892810752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 5:
							num = (short)791609345;
							if (num != 0)
							{
							}
							if (style2 != null)
							{
								num = (short)2014314498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_105;
						}
						break;
						IL_105:
						style = (global::System.Windows.Style)base.TryFindResource(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd90朗쾘힢삤쪦直\udfaa풬쎮풰풴쒶\udcb8", a_));
						num = (short)1277558788;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4F:
					base.OnApplyTemplate();
					style2 = (global::System.Windows.Style)base.TryFindResource(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd90朗쾘힢삤쪦쒪쎬\udbae풰\uddb2솴춸슺톼\udabe", a_));
					num = (short)18415621;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000BC04 File Offset: 0x00009E04
		protected override void Start()
		{
			short num = (short)270727614;
			short num2 = num;
			num = (short)2017655230;
			switch (num2 == num)
			{
			default:
			{
				num = (short)275447808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)941096961;
			if (num != 0)
			{
			}
			num = (short)1221132288;
			if (num != 0)
			{
			}
			this.c = (global::System.Windows.Window)base.Parent;
			this.c.Closing += this.parent_Closing;
			this.txtboxSelectWavFilesPath.TextChanged += this.txtboxSelectWavFilesPath_TextChanged;
			base.Start();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		private void parent_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1592655872;
				short num2 = num;
				num = (short)1666449410;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						this.b.CancelCompressAudioFilesInDirectory();
						num = (short)119076450;
						short num4 = num;
						num = (short)1808332386;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1586495488;
							if (num != 0)
							{
							}
							num = (short)1056964608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					num = (short)1210646529;
					if (num != 0)
					{
					}
					if (!this.a)
					{
						return;
					}
					num = (short)238878721;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000BE10 File Offset: 0x0000A010
		private void c()
		{
			int a_ = 16;
			short num = (short)1568276480;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			int num3;
			for (;;)
			{
				IL_3C:
				switch (num3)
				{
				case 0:
					goto IL_108;
					try
					{
						for (;;)
						{
							IL_108:
							switch (0)
							{
							case 0:
								goto IL_12C;
							}
							global::System.Collections.Generic.List<string> list;
							int num4;
							global::System.IO.FileInfo[] files;
							for (;;)
							{
								IL_112:
								switch (num3)
								{
								case 0:
									goto IL_19D;
								case 1:
									this.listAvailableWavFiles.ItemsSource = list;
									num = (short)1053753346;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1F9;
								case 3:
									if (num4 >= files.Length)
									{
										num = (short)1195704321;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(files[num4].Name);
									num4++;
									num = (short)1254621184;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_19D;
								}
								goto IL_12C;
								IL_19D:
								num = (short)317521923;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1F9:
							num = (short)1451939306;
							short num5 = num;
							num = (short)534697450;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_22D;
							}
							IL_12C:
							files = new global::System.IO.DirectoryInfo(this.txtboxSelectWavFilesPath.Text).GetFiles(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릒뮔", a_));
							list = new global::System.Collections.Generic.List<string>();
							num4 = 0;
							num = (short)152371204;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_112;
						}
						IL_22D:
						num = (short)1198653440;
						if (num != 0)
						{
						}
						goto IL_9B;
					}
					catch (global::System.Exception)
					{
						goto IL_9B;
					}
					goto IL_24F;
				case 1:
					goto IL_103;
				case 2:
					num = (short)1482293249;
					if (num != 0)
					{
					}
					if (this.listAvailableWavFiles.Items.IsEmpty)
					{
						num = (short)1202913281;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 3:
					if (global::System.IO.Directory.Exists(this.txtboxSelectWavFilesPath.Text))
					{
						num = (short)1711407104;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				}
				goto IL_52;
				IL_9B:
				num = (short)1652883458;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_103:
			IL_24F:
			this.btnWavFilesSelectAll.IsEnabled = false;
			this.btnWavFilesUnSelectAll.IsEnabled = false;
			return;
			IL_268:
			this.btnWavFilesUnSelectAll.IsEnabled = true;
			this.btnWavFilesSelectAll.IsEnabled = true;
			return;
			IL_52:
			this.listAvailableWavFiles.ItemsSource = null;
			num = (short)82771971;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3C;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		private string b()
		{
			int a_ = 18;
			short num = (short)1783017674;
			short num2 = num;
			num = (short)1180741834;
			string text;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_181:
				text = global::CommonResources.AppResources.Select_Wav_File_Location;
				num = (short)1160577025;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)311885824;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				break;
			}
			for (;;)
			{
				IL_5D:
				num = (short)1642790912;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_181;
				case 1:
					return text;
				case 2:
					num = (short)1790771201;
					if (num != 0)
					{
					}
					text = this.d.VA_WAV_FILE_LOCATION;
					num = (short)1421475843;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return text;
				case 4:
					if (!global::System.IO.Directory.Exists(text))
					{
						num = (short)1218183168;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 5:
					if (global::System.IO.Directory.Exists(this.d.VA_WAV_FILE_LOCATION))
					{
						num = (short)1767505922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud894춠슢捻\ud9a8펪캮\udcb0\udab2\ud9b4캶視苀곂꣄꫆ꛈꗊ里駎뻐뫒뛔닖飘뗚돜냞铠跢蛤苦蓨軪菬鯮꛰鋲菴뇶郸韺飼賾", a_));
					num = (short)205783044;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A4;
			}
			return text;
			IL_A4:
			text = "";
			num = (short)409600005;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5D;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000C274 File Offset: 0x0000A474
		private string a()
		{
			int a_ = 5;
			short num = (short)2065993533;
			short num2 = num;
			num = (short)550473533;
			string text;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_17F:
				text = global::CommonResources.AppResources.Select_Voice_File_Storage_Location;
				num = (short)724434945;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1813250049;
				if (num != 0)
				{
				}
				num = (short)2020278272;
				if (num != 0)
				{
				}
				num = (short)759300096;
				short num4 = num;
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				break;
			}
			}
			for (;;)
			{
				IL_AF:
				switch (num3)
				{
				case 0:
					goto IL_17F;
				case 1:
					return text;
				case 2:
					text = this.d.VA_MVA_FILE_LOCATION;
					num = (short)1015218179;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return text;
				case 4:
					if (!global::System.IO.Directory.Exists(text))
					{
						num = (short)920190976;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 5:
					if (global::System.IO.Directory.Exists(this.d.VA_MVA_FILE_LOCATION))
					{
						num = (short)641269762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇﶑쒗\udb99쎡즣쾥쒧펩ﺭ\ud9b5햷ힹ펻킽鲿铁ꯃ꿅ꯇ꿉跋ꃍ뻏뷑ꇓ룕믗뿙뇛믝軟雡ꧣ郥觧곩藫苭闯臱", a_));
					num = (short)1184694276;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_CD;
			}
			return text;
			IL_CD:
			text = "";
			num = (short)652869637;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_AF;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000C42C File Offset: 0x0000A62C
		private void btnConvertedFilesPathBrowse_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)323747841;
					if (num2 != 0)
					{
					}
					folderBrowserDialog.SelectedPath = this.txtboxSelectConvertedFilesPath.Text;
					num2 = (short)574947330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)380026571;
					short num3 = num2;
					num2 = (short)237420235;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19C;
					default:
						goto IL_12F;
					}
					break;
				}
				case 2:
					goto IL_19C;
				case 3:
					if (folderBrowserDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)2057240577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (global::System.IO.Directory.Exists(this.txtboxSelectConvertedFilesPath.Text))
					{
						num2 = (short)2003173376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B2;
				}
				goto IL_24;
				IL_B2:
				folderBrowserDialog.Description = global::CommonResources.AppResources.Select_the_location_to_store_voice_files;
				num2 = (short)1630928899;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19C:
				goto IL_B2;
			}
			IL_12F:
			num2 = (short)1129512960;
			short num4 = num2;
			num2 = (short)1918435328;
			if (num2 != 0)
			{
			}
			this.txtboxSelectConvertedFilesPath.Text = folderBrowserDialog.SelectedPath;
			return;
			IL_24:
			folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.RootFolder = global::System.Environment.SpecialFolder.MyComputer;
			num2 = (short)605421572;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		private void btnWavFilesPathBrowse_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			int num2;
			global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				IL_0A:
				num = (short)1546780673;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					folderBrowserDialog.SelectedPath = this.txtboxSelectWavFilesPath.Text;
					num = (short)268435458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)894400914;
					short num3 = num;
					num = (short)743995794;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A4;
					default:
						goto IL_136;
					}
					break;
				}
				case 2:
					goto IL_1A4;
				case 3:
					if (folderBrowserDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
					{
						num = (short)1389690881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (global::System.IO.Directory.Exists(this.txtboxSelectWavFilesPath.Text))
					{
						num = (short)504758272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				}
				goto IL_4C;
				IL_B8:
				folderBrowserDialog.Description = global::CommonResources.AppResources.Select_the_location_of_the_files_to_convert;
				num = (short)296747011;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A4:
				goto IL_B8;
			}
			IL_136:
			num = (short)982450176;
			short num4 = num;
			num = (short)760807424;
			if (num != 0)
			{
			}
			this.txtboxSelectWavFilesPath.Text = folderBrowserDialog.SelectedPath;
			return;
			IL_4C:
			folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.RootFolder = global::System.Environment.SpecialFolder.MyComputer;
			num = (short)599523332;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000C794 File Offset: 0x0000A994
		private void txtboxSelectWavFilesPath_TextChanged(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)1279131648;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			int num3;
			for (;;)
			{
				IL_3D:
				switch (num3)
				{
				case 0:
					goto IL_10F;
					try
					{
						for (;;)
						{
							IL_10F:
							switch (0)
							{
							case 0:
								goto IL_133;
							}
							global::System.Collections.Generic.List<string> list;
							int num4;
							global::System.IO.FileInfo[] files;
							for (;;)
							{
								IL_119:
								switch (num3)
								{
								case 0:
									goto IL_1A0;
								case 1:
									this.listAvailableWavFiles.ItemsSource = list;
									num = (short)2072182786;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1FB;
								case 3:
									if (num4 >= files.Length)
									{
										num = (short)533004289;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(files[num4].Name);
									num4++;
									num = (short)665321472;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1A0;
								}
								goto IL_133;
								IL_1A0:
								num = (short)903217155;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1FB:
							num = (short)1596742147;
							short num5 = num;
							num = (short)1563515395;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_22F;
							}
							IL_133:
							files = new global::System.IO.DirectoryInfo(this.txtboxSelectWavFilesPath.Text).GetFiles(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚋꂍ", a_));
							list = new global::System.Collections.Generic.List<string>();
							num4 = 0;
							num = (short)1546190852;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_119;
						}
						IL_22F:
						num = (short)323682304;
						if (num != 0)
						{
						}
						goto IL_C7;
					}
					catch (global::System.Exception)
					{
						goto IL_C7;
					}
					goto IL_24F;
				case 1:
					goto IL_10A;
				case 2:
					if (this.listAvailableWavFiles.Items.IsEmpty)
					{
						num = (short)527368193;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 3:
					num = (short)556990465;
					if (num != 0)
					{
					}
					if (global::System.IO.Directory.Exists(this.txtboxSelectWavFilesPath.Text))
					{
						num = (short)1122566144;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
				}
				goto IL_53;
				IL_C7:
				num = (short)570949634;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10A:
			IL_24F:
			this.btnWavFilesSelectAll.IsEnabled = false;
			this.btnWavFilesUnSelectAll.IsEnabled = false;
			return;
			IL_268:
			this.btnWavFilesUnSelectAll.IsEnabled = true;
			this.btnWavFilesSelectAll.IsEnabled = true;
			return;
			IL_53:
			this.listAvailableWavFiles.ItemsSource = null;
			num = (short)1067319299;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3D;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000CA40 File Offset: 0x0000AC40
		private void btnWavFilesSelectAll_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)27497685;
			short num2 = num;
			num = (short)449221845;
			switch (num2 == num)
			{
			default:
			{
				num = (short)92667904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1257373697;
			if (num != 0)
			{
			}
			num = (short)701169664;
			if (num != 0)
			{
			}
			this.listAvailableWavFiles.UnselectAll();
			this.listAvailableWavFiles.SelectAll();
			this.btnWavFilesUnSelectAll.IsEnabled = true;
			this.listAvailableWavFiles.Focus();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000CB14 File Offset: 0x0000AD14
		private void btnWavFilesUnSelectAll_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1036698418;
			short num2 = num;
			num = (short)1584775986;
			switch (num2 == num)
			{
			default:
			{
				num = (short)728432640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1392836609;
			if (num != 0)
			{
			}
			num = (short)2082013184;
			if (num != 0)
			{
			}
			this.listAvailableWavFiles.UnselectAll();
			this.btnWavFilesSelectAll.IsEnabled = true;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		private void OnLoad(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1441792;
				short num2 = num;
				num = (short)1364721666;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						global::System.Windows.Input.Keyboard.Focus(this);
						num = (short)836390034;
						short num4 = num;
						num = (short)267668626;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1845362688;
							if (num != 0)
							{
							}
							num = (short)506920960;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					}
					IL_5B:
					num = (short)2128347137;
					if (num != 0)
					{
					}
					if (base.IsKeyboardFocusWithin)
					{
						return;
					}
					num = (short)134021121;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1011954748;
			short num2 = num;
			num = (short)10826812;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1384906752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1900871680;
			if (num != 0)
			{
			}
			num = (short)228196353;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		private void vaHelpButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)330776352;
				short num2 = num;
				num = (short)643448608;
				switch (num2 == num)
				{
				}
				num = (short)95944704;
				if (num != 0)
				{
				}
				num = (short)652148737;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞃ늅뢋ꊏꖑ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)413270016;
			short num3 = num;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000CE80 File Offset: 0x0000B080
		private void btnConvert_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1633091584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1407254528;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 1:
						num = (short)461897730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string text;
						if (global::System.IO.Directory.Exists(text))
						{
							num = (short)1761411075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C;
					}
					case 3:
					{
						num = (short)2001993729;
						if (num != 0)
						{
						}
						global::System.Collections.IEnumerator enumerator = this.listAvailableWavFiles.SelectedItems.GetEnumerator();
						num = (short)1846870022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
						try
						{
							this.btnConvert.IsEnabled = false;
							string text;
							string[] array;
							string text2;
							global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption;
							this.b.CompressAudioFilesInDirectoryAsync(array, text, text2, overwriteOption, new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted(this.a));
							this.a = true;
							this.d.VA_WAV_FILE_LOCATION = text;
							this.d.VA_MVA_FILE_LOCATION = text2;
							this.d.Save();
							return;
						}
						catch (global::System.InvalidOperationException)
						{
							this.btnConvert.IsEnabled = true;
							return;
						}
						goto Block_5;
					case 6:
						goto IL_30A;
					case 7:
					{
						string text2;
						if (global::System.IO.Directory.Exists(text2))
						{
							num = (short)858062849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					}
					case 8:
					{
						int num3 = 0;
						string[] array = new string[this.listAvailableWavFiles.SelectedItems.Count];
						string text = this.txtboxSelectWavFilesPath.Text.Trim();
						string text2 = this.txtboxSelectConvertedFilesPath.Text.Trim();
						this.vaConvertListView.Items.Clear();
						this.vaConvertListView.Items.SortDescriptions.Clear();
						this.vaVoiceConvertProgressBar.Value = 0.0;
						global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption = global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.OVERWRITE_ALL_FILES;
						num = (short)1196752896;
						short num4 = num;
						num = (short)340066311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_68:
					if (this.listAvailableWavFiles.SelectedItems.Count > 0)
					{
						num = (short)19005448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Select_Files_Convert);
					num = (short)1280770052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_30A:
						num = (short)488636420;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1950023682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_3C4;
							case 3:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1943994369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text3 = (string)enumerator.Current;
								string[] array;
								int num3;
								array[num3++] = text3;
								num = (short)742195200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_344;
								}
								continue;
							}
							IL_375:
							num = (short)1417740291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_344:
							goto IL_375;
						}
						IL_3C4:
						goto IL_99;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_3E6;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_3D3:
							switch (num2)
							{
							case 0:
								goto IL_48C;
							case 1:
								goto IL_46B;
							case 2:
								if (disposable != null)
								{
									num = (short)411959297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_48E;
							}
							goto IL_3E6;
						}
						IL_46B:
						disposable.Dispose();
						goto IL_474;
						IL_48C:
						IL_48E:
						goto EndFinally_10;
						IL_3E6:
						num = (short)152913704;
						short num5 = num;
						num = (short)545081128;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_474:
							num = (short)177799168;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3D3;
						default:
						{
							num = (short)1855586304;
							if (num != 0)
							{
							}
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1054146562;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3D3;
						}
						}
						EndFinally_10:;
					}
					return;
					IL_99:
					this.b = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate();
					num = (short)385482757;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.The_output_directory_does_not_exist, global::CommonResources.AppResources.Conversion_directory_not_found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
				return;
				IL_21C:
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.The_input_directory_does_not_exist, global::CommonResources.AppResources.Source_directory_not_found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
				return;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000D338 File Offset: 0x0000B538
		private void a(global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementProgress A_0)
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
					goto IL_139;
				case 1:
					if (this.vaConvertListView.IsVisible)
					{
						num2 = (short)1040252930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 2:
				{
					global::SpecialFeatures.VoiceAnnouncements.ACPVoiceAnnouncementImportUI.ConvertResult convertResult;
					this.vaConvertListView.ScrollIntoView(convertResult);
					num2 = (short)955908096;
					short num3 = num2;
					num2 = (short)1879900160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_139:
			IL_13B:
			this.vaVoiceConvertProgressBar.Value = (double)A_0.CurrentFileCount / (double)A_0.TotalFileCount * 100.0;
			return;
			IL_1C:
			num2 = (short)1815216129;
			if (num2 != 0)
			{
			}
			num2 = (short)575670868;
			short num4 = num2;
			num2 = (short)831392340;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)626982912;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.VoiceAnnouncements.ACPVoiceAnnouncementImportUI.ConvertResult convertResult = new global::SpecialFeatures.VoiceAnnouncements.ACPVoiceAnnouncementImportUI.ConvertResult(A_0.FileName, A_0.Code);
				this.vaConvertListView.Items.Add(convertResult);
				num2 = (short)451215361;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		private void a(global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted A_0)
		{
			short num = (short)1523318784;
			short num2 = num;
			num = (short)209521164;
			short num3 = num;
			num = (short)1139280396;
			switch (num3 == num)
			{
			}
			num = (short)1145110529;
			if (num != 0)
			{
			}
			num = (short)645726208;
			if (num != 0)
			{
			}
			this.b = null;
			this.a = false;
			this.btnConvert.IsEnabled = true;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000D568 File Offset: 0x0000B768
		private void a(global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest A_0)
		{
			short num = (short)259719168;
			short num2 = num;
			num = (short)658910872;
			short num3 = num;
			num = (short)700591768;
			switch (num3 == num)
			{
			}
			num = (short)288555008;
			if (num != 0)
			{
			}
			num = (short)2033582081;
			if (num != 0)
			{
			}
			A_0.ActionToTake = global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.OVERWRITE_FILE;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000D61C File Offset: 0x0000B81C
		private void vaCloseButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)547880960;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 1:
					goto IL_13F;
				case 2:
					this.c.DialogResult = new bool?(true);
					this.c.Close();
					num = (short)2078081028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)306380800;
					short num3 = num;
					this.b.CancelCompressAudioFilesInDirectory();
					this.a = false;
					num = (short)108986369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1662502079;
					short num4 = num;
					num = (short)1960232127;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						goto IL_FC;
					}
					break;
				}
				case 5:
					if (this.c != null)
					{
						goto IL_177;
					}
					return;
				}
				IL_46:
				if (this.a)
				{
					num = (short)1155399683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_13F:
				this.OnReturn(new global::System.Windows.Navigation.ReturnEventArgs<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톓鍊瞧", a_)));
				num = (short)1384775685;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_177:
				num = (short)1430519810;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			num = (short)1945436160;
			if (num != 0)
			{
			}
			num = (short)904462337;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		private void vaConversionLogExpander_Expanded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2146697216;
			short num2 = num;
			num = (short)2026707160;
			short num3 = num;
			num = (short)1246238936;
			switch (num3 == num)
			{
			}
			num = (short)1544552448;
			if (num != 0)
			{
			}
			num = (short)1617362945;
			if (num != 0)
			{
			}
			this.vaConvertListView.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		private void vaConversionLogExpander_Collapsed(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)917897216;
			short num2 = num;
			num = (short)869275171;
			short num3 = num;
			num = (short)1752372771;
			switch (num3 == num)
			{
			}
			num = (short)1403191297;
			if (num != 0)
			{
			}
			num = (short)192348160;
			if (num != 0)
			{
			}
			this.vaConvertListView.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000D954 File Offset: 0x0000BB54
		private void GridViewColumnHeader_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			for (;;)
			{
				IL_09:
				short num = (short)2011299841;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)414032077;
						short num3 = num;
						num = (short)1181851853;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1298268160;
							short num4 = num;
							num = (short)1055719424;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						}
						}
						break;
					}
					case 2:
						this.vaConvertListView.Items.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐", a_), global::System.ComponentModel.ListSortDirection.Ascending));
						this.vaConvertListView.Items.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힐朗璉힘漢爵", a_), global::System.ComponentModel.ListSortDirection.Ascending));
						num = (short)165412865;
						if (num != 0)
						{
						}
						num = (short)186974208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B4:
					global::System.Windows.Controls.ContentControl contentControl = A_0 as global::System.Windows.Controls.GridViewColumnHeader;
					global::System.Windows.Controls.ViewBase view = this.vaConvertListView.View;
					this.vaConvertListView.Items.SortDescriptions.Clear();
					if (!((string)contentControl.Content == global::CommonResources.AppResources.Convert_Status))
					{
						return;
					}
					num = (short)1203175426;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num;
			for (;;)
			{
				num = (short)178192384;
				short num2 = num;
				num = (short)229638145;
				if (num != 0)
				{
				}
				if (this.e)
				{
					break;
				}
				num = (short)1962340712;
				short num3 = num;
				num = (short)60879208;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_98;
				}
			}
			return;
			IL_98:
			num = (short)635895808;
			if (num != 0)
			{
			}
			this.e = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾏솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯톱\udbb3\udbb5좷햹튻\udbbd꺿뛁냅Ꟈꏉ꿋ꯍ뇏병뫓맕귗듙뿛믝跟蟡諣鋥鯧엩髫臭駯釱釳韵雷铹鏻诽滿愁愃欅洇搉砋服紏我笓搕気漙甛ㄝ䄟䄡吣倥䜧䌩伫䬭儯就娳夵䴷吹弻嬽ⴿ❁⩃㉅ⅇ❉㱋⅍≏♑⅓㽕癗≙㵛㍝౟", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2014642177;
			int num2 = (int)((global::System.IntPtr)num);
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
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)459210753;
					if (num != 0)
					{
					}
					num = (short)635568128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_36C;
				case 2:
					goto IL_19A;
				case 3:
					goto IL_2B4;
				case 4:
					goto IL_14C;
				case 5:
					goto IL_207;
				case 6:
					goto IL_2C1;
				case 7:
					goto IL_2CE;
				case 8:
					goto IL_273;
				case 9:
					goto IL_300;
				case 10:
					goto IL_1FA;
				case 11:
					goto IL_30D;
				case 12:
					goto IL_128;
				case 13:
					goto IL_331;
				case 14:
					goto IL_1C9;
				case 15:
					goto IL_11B;
				case 16:
					goto IL_2F3;
				case 17:
					goto IL_2DB;
				case 18:
					goto IL_182;
				case 19:
					goto IL_22B;
				case 20:
					goto IL_1D6;
				case 21:
					goto IL_24F;
				default:
				{
					num = (short)1246665798;
					short num3 = num;
					num = (short)550870086;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2F3;
					default:
						num = (short)1750335488;
						if (num != 0)
						{
						}
						num = (short)1837957122;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_11B:
			this.vaVoiceConvertProgressBar = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_128:
			this.btnWavFilesUnSelectAll = (global::System.Windows.Controls.Button)target;
			this.btnWavFilesUnSelectAll.Click += this.btnWavFilesUnSelectAll_Click;
			return;
			IL_14C:
			num = (short)1485766656;
			short num4 = num;
			this.txtboxSelectWavFilesPath = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_182:
			((global::System.Windows.Controls.GridViewColumnHeader)target).Click += this.GridViewColumnHeader_Click;
			return;
			IL_19A:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.vaHelpButton_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_1C9:
			this.vaExpanderHeaderPanel = (global::System.Windows.Controls.DockPanel)target;
			return;
			IL_1D6:
			this.vaCloseButton = (global::System.Windows.Controls.Button)target;
			this.vaCloseButton.Click += this.vaCloseButton_Click;
			return;
			IL_1FA:
			this.listAvailableWavFiles = (global::System.Windows.Controls.ListView)target;
			return;
			IL_207:
			this.btnWavFilesPathBrowse = (global::System.Windows.Controls.Button)target;
			this.btnWavFilesPathBrowse.Click += this.btnWavFilesPathBrowse_Click;
			return;
			IL_22B:
			this.btnConvert = (global::System.Windows.Controls.Button)target;
			this.btnConvert.Click += this.btnConvert_Click;
			return;
			IL_24F:
			this.vaImportHelpButton = (global::System.Windows.Controls.Button)target;
			this.vaImportHelpButton.Click += this.vaHelpButton_Click;
			return;
			IL_273:
			this.btnConvertedFilesPathBrowse = (global::System.Windows.Controls.Button)target;
			this.btnConvertedFilesPathBrowse.Click += this.btnConvertedFilesPathBrowse_Click;
			return;
			IL_2AF:
			this.e = true;
			return;
			IL_2B4:
			this.lblSelectionTitle = (global::System.Windows.Controls.Label)target;
			return;
			IL_2C1:
			this.lblSelectConvertedFilesPath = (global::System.Windows.Controls.Label)target;
			return;
			IL_2CE:
			this.txtboxSelectConvertedFilesPath = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_2DB:
			((global::System.Windows.Controls.GridViewColumnHeader)target).Click += this.GridViewColumnHeader_Click;
			return;
			IL_2F3:
			this.vaConvertListView = (global::System.Windows.Controls.ListView)target;
			return;
			IL_300:
			this.OptionGrpBox = (global::System.Windows.Controls.GroupBox)target;
			return;
			IL_30D:
			this.btnWavFilesSelectAll = (global::System.Windows.Controls.Button)target;
			this.btnWavFilesSelectAll.Click += this.btnWavFilesSelectAll_Click;
			return;
			IL_331:
			this.vaConversionLogExpander = (global::System.Windows.Controls.Expander)target;
			this.vaConversionLogExpander.Expanded += this.vaConversionLogExpander_Expanded;
			this.vaConversionLogExpander.Collapsed += this.vaConversionLogExpander_Collapsed;
			return;
			IL_36C:
			((global::SpecialFeatures.VoiceAnnouncements.ACPVoiceAnnouncementImportUI)target).Loaded += this.OnLoad;
		}

		// Token: 0x0400002B RID: 43
		private bool a;

		// Token: 0x0400002C RID: 44
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate b;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Window c;

		// Token: 0x0400002E RID: 46
		private global::SpecialFeatures.SpecialFeaturesSettings d;

		// Token: 0x0400002F RID: 47
		internal global::System.Windows.Controls.Label lblSelectionTitle;

		// Token: 0x04000030 RID: 48
		internal global::System.Windows.Controls.TextBox txtboxSelectWavFilesPath;

		// Token: 0x04000031 RID: 49
		internal global::System.Windows.Controls.Button btnWavFilesPathBrowse;

		// Token: 0x04000032 RID: 50
		internal global::System.Windows.Controls.Label lblSelectConvertedFilesPath;

		// Token: 0x04000033 RID: 51
		internal global::System.Windows.Controls.TextBox txtboxSelectConvertedFilesPath;

		// Token: 0x04000034 RID: 52
		internal global::System.Windows.Controls.Button btnConvertedFilesPathBrowse;

		// Token: 0x04000035 RID: 53
		internal global::System.Windows.Controls.GroupBox OptionGrpBox;

		// Token: 0x04000036 RID: 54
		internal global::System.Windows.Controls.ListView listAvailableWavFiles;

		// Token: 0x04000037 RID: 55
		internal global::System.Windows.Controls.Button btnWavFilesSelectAll;

		// Token: 0x04000038 RID: 56
		internal global::System.Windows.Controls.Button btnWavFilesUnSelectAll;

		// Token: 0x04000039 RID: 57
		internal global::System.Windows.Controls.Expander vaConversionLogExpander;

		// Token: 0x0400003A RID: 58
		internal global::System.Windows.Controls.DockPanel vaExpanderHeaderPanel;

		// Token: 0x0400003B RID: 59
		internal global::System.Windows.Controls.ProgressBar vaVoiceConvertProgressBar;

		// Token: 0x0400003C RID: 60
		internal global::System.Windows.Controls.ListView vaConvertListView;

		// Token: 0x0400003D RID: 61
		internal global::System.Windows.Controls.Button btnConvert;

		// Token: 0x0400003E RID: 62
		internal global::System.Windows.Controls.Button vaCloseButton;

		// Token: 0x0400003F RID: 63
		internal global::System.Windows.Controls.Button vaImportHelpButton;

		// Token: 0x04000040 RID: 64
		private bool e;

		// Token: 0x02000014 RID: 20
		private class ConvertResult
		{
			// Token: 0x0600006E RID: 110 RVA: 0x00002624 File Offset: 0x00000824
			internal ConvertResult(string fileName, global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes code)
			{
				this.a = fileName;
				this.b = code;
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600006F RID: 111 RVA: 0x0000DF78 File Offset: 0x0000C178
			public string FileName
			{
				get
				{
					short num = (short)378929152;
					short num2 = num;
					num = (short)1457263585;
					short num3 = num;
					num = (short)1067520993;
					switch (num3 == num)
					{
					}
					num = (short)2066743297;
					if (num != 0)
					{
					}
					num = (short)2006056960;
					if (num != 0)
					{
					}
					return this.a;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000070 RID: 112 RVA: 0x0000E028 File Offset: 0x0000C228
			public string ShortFileName
			{
				get
				{
					short num;
					string result;
					try
					{
						num = (short)1421051875;
						short num2 = num;
						num = (short)306415587;
						switch (num2 == num)
						{
						}
						num = (short)1522597888;
						if (num != 0)
						{
						}
						result = new global::System.IO.FileInfo(this.a).Name;
					}
					catch (global::System.Exception)
					{
						result = "";
					}
					num = (short)626524160;
					short num3 = num;
					num = (short)1380646913;
					if (num != 0)
					{
					}
					return result;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000071 RID: 113 RVA: 0x0000E0FC File Offset: 0x0000C2FC
			public string Status
			{
				get
				{
					short num = (short)120127491;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_12A;
						case 1:
							if (this.b != global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR)
							{
								num = (short)1293484039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_268;
						case 2:
							if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_SIZE_ERROR)
							{
								num = (short)636944392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1217658891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_5D;
							}
							continue;
						case 4:
						{
							if (this.b != global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_DOES_NOT_EXIST)
							{
								num = (short)1512046598;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)756482049;
							if (num != 0)
							{
							}
							num = (short)912789801;
							short num3 = num;
							num = (short)685445417;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F0;
							default:
								num = (short)1940783104;
								if (num != 0)
								{
								}
								num = (short)1319108608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_7C;
						case 6:
							if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR)
							{
								num = (short)816119821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AB;
						case 7:
							num = (short)1240793090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_25A;
						case 9:
							goto IL_1F0;
						case 10:
							goto IL_211;
						case 11:
						{
							num = (short)756875264;
							short num4 = num;
							if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR)
							{
								num = (short)606732300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1651834884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_194;
						case 13:
							goto IL_1D7;
						}
						IL_5D:
						if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
						{
							num = (short)822870021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1127284745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F0:
						if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_VOICE_FILE_ALREADY_EXISTS)
						{
							num = (short)720306186;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1215299585;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_7C:
					return global::CommonResources.AppResources.Success_Id;
					IL_12A:
					return global::CommonResources.AppResources.Failed_Input_wav_file_does_not_exist;
					IL_194:
					return global::CommonResources.AppResources.Failed_Unable_to_generate_output_mva_file;
					IL_1D7:
					return global::CommonResources.AppResources.Failed_Input_wav_file_error;
					IL_211:
					return global::CommonResources.AppResources.Voice_Announcement_Already_Exists;
					IL_25A:
					IL_268:
					return global::CommonResources.AppResources.Failed_Wav_file_format_needs_to_be;
					IL_2AB:
					return global::CommonResources.AppResources.Failed_Id;
				}
			}

			// Token: 0x04000041 RID: 65
			private string a;

			// Token: 0x04000042 RID: 66
			private global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes b;
		}
	}
}
