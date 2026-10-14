using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using AcpCommonLib;
using CommonResources;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000020 RID: 32
	public class CustomVASelectWindow : global::System.Windows.Window, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00050374 File Offset: 0x0004E574
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00050424 File Offset: 0x0004E624
		public global::System.Collections.Generic.List<string> SelectedVAFiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1400700929;
				if (num != 0)
				{
				}
				num = (short)1203111993;
				short num2 = num;
				num = (short)154929209;
				switch (num2 == num)
				{
				}
				num = (short)775618560;
				if (num != 0)
				{
				}
				num = (short)1206386688;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)95013831;
				short num2 = num;
				num = (short)471059399;
				switch (num2 == num)
				{
				}
				num = (short)1760428033;
				if (num != 0)
				{
				}
				num = (short)789381120;
				if (num != 0)
				{
				}
				num = (short)1618935808;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000504D8 File Offset: 0x0004E6D8
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00050588 File Offset: 0x0004E788
		public global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> PlanToDownloadFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1798370472;
				short num2 = num;
				num = (short)829355176;
				switch (num2 == num)
				{
				}
				num = (short)995033089;
				if (num != 0)
				{
				}
				num = (short)563871744;
				if (num != 0)
				{
				}
				num = (short)862322688;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)301500865;
				short num2 = num;
				num = (short)362056129;
				switch (num2 == num)
				{
				}
				num = (short)1875443712;
				short num3 = num;
				num = (short)589561856;
				if (num != 0)
				{
				}
				num = (short)779026433;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00050638 File Offset: 0x0004E838
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x000506F0 File Offset: 0x0004E8F0
		public global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> DownloadedFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1757492613;
				short num2 = num;
				num = (short)1648178565;
				switch (num2 == num)
				{
				}
				num = (short)685506560;
				short num3 = num;
				num = (short)885391360;
				if (num != 0)
				{
				}
				num = (short)2088828929;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1641459156;
				short num2 = num;
				num = (short)211201492;
				switch (num2 == num)
				{
				}
				num = (short)2002124800;
				short num3 = num;
				num = (short)146931713;
				if (num != 0)
				{
				}
				num = (short)1347092480;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002692 File Offset: 0x00000892
		public CustomVASelectWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000507A4 File Offset: 0x0004E9A4
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00050854 File Offset: 0x0004EA54
		public global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> VAFileItems
		{
			get
			{
				short num = (short)304414721;
				if (num != 0)
				{
				}
				num = (short)1795965282;
				short num2 = num;
				num = (short)1550598498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436142080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)377618432;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1677131451;
				short num2 = num;
				num = (short)952565435;
				switch (num2 == num)
				{
				}
				num = (short)969211904;
				short num3 = num;
				num = (short)1741815809;
				if (num != 0)
				{
				}
				num = (short)1079574528;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00050904 File Offset: 0x0004EB04
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000509B4 File Offset: 0x0004EBB4
		internal global::System.Windows.Controls.SelectionMode VAFileListBoxSelectionMethod
		{
			get
			{
				short num = (short)804247614;
				short num2 = num;
				num = (short)1411700798;
				switch (num2 == num)
				{
				}
				num = (short)986578944;
				short num3 = num;
				num = (short)867041281;
				if (num != 0)
				{
				}
				num = (short)1029963776;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				int a_ = 1;
				short num = (short)2027527116;
				short num2 = num;
				num = (short)1325112268;
				switch (num2 == num)
				{
				}
				num = (short)297926656;
				short num3 = num;
				num = (short)393216000;
				if (num != 0)
				{
				}
				num = (short)372375553;
				if (num != 0)
				{
				}
				(base.FindName(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튃입캇\udc8fﮑ\uda97", a_)) as global::System.Windows.Controls.ListBox).SelectionMode = value;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00050A84 File Offset: 0x0004EC84
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1427439617;
			if (num != 0)
			{
			}
			num = (short)139132928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> package;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (package == null)
						{
							num = (short)1627389952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E;
					case 2:
						try
						{
							num = (short)587988994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1FB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F0;
									}
									continue;
								case 3:
									num = (short)1817378816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary astrovoiceAnnouncementSummary;
									if (astrovoiceAnnouncementSummary != null)
									{
										num = (short)1386479623;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1818230787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary astrovoiceAnnouncementSummary = enumerator.Current as global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary;
									num = (short)1180565508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary astrovoiceAnnouncementSummary;
									this.VAFileItems.Add(new global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem(astrovoiceAnnouncementSummary.PackageName, astrovoiceAnnouncementSummary.Uuid));
									num = (short)2424833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary astrovoiceAnnouncementSummary;
									global::System.Guid? fileUuid = astrovoiceAnnouncementSummary.FileUuid;
									num = (short)454754312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Guid? fileUuid;
									if (fileUuid != null)
									{
										num = (short)540278790;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_12E:
								num = (short)439746565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F0:
								goto IL_12E;
							}
							IL_1FB:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_20E;
					}
					goto IL_61;
					IL_20E:
					num = (short)1101983788;
					short num3 = num;
					num = (short)42987564;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)390987776;
						short num4 = num;
						num = (short)1323106304;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator = package.GetEnumerator();
						num = (short)1941438466;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_61:
				package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement);
				num = (short)1338703873;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00050D58 File Offset: 0x0004EF58
		private void OKButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)423231490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_202;
				case 1:
					return;
				case 2:
					num = (short)4718593;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 3:
				{
					num = (short)1141506048;
					short num3 = num;
					try
					{
						num = (short)667680770;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)195688968;
								short num4 = num;
								num = (short)809040392;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)293797888;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)1483407364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem item = (global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem)enumerator.Current;
									this.PlanToDownloadFileList.Add(item);
									num = (short)602537987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 1:
								goto IL_18D;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C4;
								}
								continue;
							case 4:
								num = (short)289865729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F4:
							num = (short)1725169664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C4:
							goto IL_F4;
						}
						IL_18D:
						goto IL_2CD;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1AE;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_19C:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)99155970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)741933056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_201;
							case 2:
								goto IL_1FF;
							}
							goto IL_1AE;
						}
						IL_1FF:
						IL_201:
						goto EndFinally_6;
						IL_1AE:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1130102785;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_19C;
						EndFinally_6:;
					}
					goto IL_202;
					IL_2CD:
					this.OKButton.IsEnabled = false;
					this.a.RunWorkerAsync(this.PlanToDownloadFileList);
					num = (short)1369571329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5B:
				if (this.VAFileListBox.SelectedItems.Count > 0)
				{
					num = (short)2127757312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_202:
				this.a = new global::System.ComponentModel.BackgroundWorker();
				this.a.WorkerSupportsCancellation = true;
				this.a.WorkerReportsProgress = true;
				this.a.DoWork += this.downLoadWorker_DoWork;
				this.a.ProgressChanged += this.downLoadWorker_ProgressChanged;
				this.a.RunWorkerCompleted += this.downLoadWorker_RunWorkerCompleted;
				this.PlanToDownloadFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>();
				enumerator = this.VAFileListBox.SelectedItems.GetEnumerator();
				num = (short)1564344323;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00051088 File Offset: 0x0004F288
		private void CancelButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)171114497;
			if (num != 0)
			{
			}
			num = (short)122617857;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1626275840;
					short num3 = num;
					goto IL_E9;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_10B;
				}
				IL_58:
				num = (short)720984717;
				short num4 = num;
				num = (short)1397643917;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E9:
					this.a.CancelAsync();
					num = (short)722075650;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1073938432;
					if (num != 0)
					{
					}
					if (this.a == null)
					{
						goto IL_10D;
					}
					num = (short)554041344;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10B:
			IL_10D:
			this.SelectedVAFiles = new global::System.Collections.Generic.List<string>();
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000511BC File Offset: 0x0004F3BC
		private void Window_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool? dialogResult;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					this.a.CancelAsync();
					this.SelectedVAFiles = new global::System.Collections.Generic.List<string>();
					num2 = (short)280297472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (dialogResult == null)
					{
						num2 = (short)1570111491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)109707264;
					short num3 = num2;
					num2 = (short)1586102273;
					if (num2 != 0)
					{
					}
					num2 = (short)1244159711;
					short num4 = num2;
					num2 = (short)976641759;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)2102198272;
						if (num2 != 0)
						{
						}
						num2 = (short)1173553156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (this.a != null)
					{
						num2 = (short)411762689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			dialogResult = base.DialogResult;
			num2 = (short)204079106;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00051338 File Offset: 0x0004F538
		private void downLoadWorker_DoWork(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)1437335552;
			switch (num)
			{
			default:
			{
				num = (short)1061355520;
				short num2 = num;
				global::System.ComponentModel.BackgroundWorker backgroundWorker = A_0 as global::System.ComponentModel.BackgroundWorker;
				this.PlanToDownloadFileList = (global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>)A_1.Argument;
				this.DownloadedFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>();
				using (global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator())
				{
					num = (short)689242114;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)2014314500;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses.Downloading;
							num = (short)651427843;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_405;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_38F;
							}
							continue;
						case 4:
							num = (short)1023279105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3B6:
						num = (short)1022033920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_38F:
						goto IL_3B6;
					}
					IL_405:
					goto IL_33D;
				}
				goto IL_418;
				global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> list;
				for (;;)
				{
					IL_33D:
					list = new global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>();
					global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator();
					try
					{
						num = (short)569901059;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (backgroundWorker.CancellationPending)
								{
									num = (short)433651719;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1663238145;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_18F;
									}
									string text;
									global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem vafileItem;
									for (;;)
									{
										IL_174:
										switch (num3)
										{
										case 0:
											goto IL_254;
										case 1:
											goto IL_26C;
										case 2:
											if (!string.IsNullOrEmpty(text))
											{
												num = (short)1158545411;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											list.Add(vafileItem);
											num = (short)552337412;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
										{
											string text2 = text.Replace(global::System.IO.Path.GetExtension(text), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊋ", a_));
											global::System.IO.File.Copy(text, text2, true);
											vafileItem.FullPathAndName = text2;
											this.DownloadedFileList.Add(vafileItem);
											global::System.IO.File.Delete(text);
											num = (short)2089811968;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											goto IL_254;
										}
										goto IL_18F;
										IL_254:
										num = (short)494731265;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_26C:
									break;
									IL_18F:
									text = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(vafileItem.SoftwareUuid);
									num = (short)777191426;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_174;
								}
								catch (global::System.Exception)
								{
									break;
								}
								goto IL_277;
							case 2:
							{
								num = (short)893493242;
								short num4 = num;
								num = (short)797351930;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_2ED;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_CA;
								}
								continue;
							case 4:
								num = (short)591396866;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_297;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1572143108;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem vafileItem = enumerator.Current;
								num = (short)56557568;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_277;
							}
							IL_CF:
							num = (short)1904410630;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_CA:
							goto IL_CF;
							IL_277:
							A_1.Cancel = true;
							num = (short)594018309;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_297:
						break;
						IL_2ED:
						num = (short)1955397632;
						if (num != 0)
						{
						}
						break;
					}
					finally
					{
						num = (short)1088618497;
						if (num != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
				}
				IL_418:
				this.a(list);
				A_1.Result = this.DownloadedFileList;
				return;
			}
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000517BC File Offset: 0x0004F9BC
		private void a(global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> A_0)
		{
			int a_ = 9;
			short num = (short)1234763778;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_71;
				case 1:
				{
					string text;
					text += A_0[A_0.Count - 1].FileName;
					CS$<>8__locals1.msg = global::CommonResources.AppResources.Voice_Announcement_FileDownloadFailed + text;
					base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						short num6 = (short)1460797440;
						short num7 = num6;
						num6 = (short)1063848952;
						short num8 = num6;
						num6 = (short)1627851768;
						switch (num8 == num6)
						{
						}
						num6 = (short)918618112;
						if (num6 != 0)
						{
						}
						num6 = (short)345571329;
						if (num6 != 0)
						{
						}
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, CS$<>8__locals1.msg);
					}), global::System.Windows.Threading.DispatcherPriority.Background, global::System.Array.Empty<object>());
					num = (short)699072516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 3:
				{
					int num3;
					if (num3 >= A_0.Count - 1)
					{
						goto IL_91;
					}
					string text = text + A_0[num3].FileName + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂋ꺍", a_);
					num3++;
					num = (short)1342504960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
				{
					num = (short)226669384;
					short num4 = num;
					num = (short)884912968;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
					{
						num = (short)1494679552;
						if (num != 0)
						{
						}
						string text = "";
						int num3 = 0;
						num = (short)1690370049;
						if (num != 0)
						{
						}
						num = (short)1278410758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_71;
				}
				IL_4B:
				if (A_0.Count != 0)
				{
					num = (short)1208811525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_71:
				num = (short)472645635;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_91:
				num = (short)1622147072;
				short num5 = num;
				num = (short)1280770049;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000519E4 File Offset: 0x0004FBE4
		private void downLoadWorker_RunWorkerCompleted(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)483590146;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)2105898796;
						short num3 = num;
						num = (short)732002092;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)936837120;
							if (num != 0)
							{
							}
							base.DialogResult = new bool?(true);
							this.SelectedVAFiles = new global::System.Collections.Generic.List<string>();
							using (global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>.Enumerator enumerator = this.DownloadedFileList.GetEnumerator())
							{
								num = (short)1210122242;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1001717761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1A9;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_12B;
										}
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1683488768;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem vafileItem = enumerator.Current;
										this.SelectedVAFiles.Add(vafileItem.FullPathAndName);
										num = (short)903348228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_12D:
									num = (short)429129731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12B:
									goto IL_12D;
								}
								IL_1A9:;
							}
							break;
						}
						base.Close();
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					goto IL_1CA;
				case 1:
					goto IL_1CA;
				case 2:
					num = (short)63897601;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 3:
				{
					num = (short)629211136;
					short num4 = num;
					num = (short)279183364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (!A_1.Cancelled)
					{
						num = (short)1007288321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_5F:
				if (A_1.Error == null)
				{
					num = (short)735903747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CA:
				num = (short)537001984;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00051C70 File Offset: 0x0004FE70
		private void downLoadWorker_ProgressChanged(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)1490640439;
			short num2 = num;
			num = (short)644832823;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)782106624;
				short num3 = num;
				num = (short)1571487744;
				if (num != 0)
				{
				}
				int progressPercentage = A_1.ProgressPercentage;
				global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>.Enumerator enumerator = (A_1.UserState as global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>).GetEnumerator();
				try
				{
					num = (short)205586434;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1231355908;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses.Downloaded;
							num = (short)182648835;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_139;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C9;
							}
							continue;
						case 4:
							num = (short)1852768257;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EF:
						num = (short)504692736;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C9:
						goto IL_EF;
					}
					IL_139:;
				}
				finally
				{
					num = (short)683474945;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				break;
			}
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00051DFC File Offset: 0x0004FFFC
		public void Dispose()
		{
			short num = (short)332136449;
			if (num != 0)
			{
			}
			num = (short)495567734;
			short num2 = num;
			num = (short)2029175670;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1301807104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1318322176;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00051EB0 File Offset: 0x000500B0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)30277634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AF;
				case 1:
				{
					num = (short)197525504;
					short num3 = num;
					this.a.Dispose();
					this.a = null;
					num = (short)1882259456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 3:
				{
					num = (short)836165223;
					short num4 = num;
					num = (short)358997607;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						num = (short)1861746688;
						if (num != 0)
						{
						}
						num = (short)232456196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (this.a != null)
					{
						num = (short)983498753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_3A:
				if (!disposing)
				{
					return;
				}
				num = (short)1173422083;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AF:
			num = (short)348979201;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00052020 File Offset: 0x00050220
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			if (this.g)
			{
				short num = (short)1129401448;
				short num2 = num;
				num = (short)377637992;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)467795969;
					if (num != 0)
					{
					}
					num = (short)290127872;
					short num3 = num;
					num = (short)1961951232;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.g = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벒요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲횴\ud8b6풸쮺튼톾꓀귂뇄뿈꓊꓌곎듐닒믔맖뛘껚돜볞蓠転胤触鷨飪심駮黰髲雴鋶飸闺鏼郾琀洂昄戆搈渊挌笎紐稒昔挖㘘砚栜氞唠䰢䠤儦䠨堪䠬䌮吰倲䄴䀶倸唺夼倾㙀求♄㉆㩈㽊≌≎❐㉒♔㉖㕘㹚㹜⭞ᙠ੢୤ͦ٨ᱪ䍬ᝮၰṲᥴ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00052104 File Offset: 0x00050304
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1132920833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1316403814;
					short num3 = num;
					num = (short)2029304422;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
					{
						num = (short)230227968;
						if (num != 0)
						{
						}
						num = (short)435552256;
						short num4 = num;
						num = (short)1820459010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_11D;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_16D;
				case 2:
					goto IL_84;
				case 3:
					goto IL_60;
				case 4:
					goto IL_149;
				default:
					num = (short)691208192;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_60:
			this.OKButton = (global::System.Windows.Controls.Button)target;
			this.OKButton.Click += this.OKButton_Click;
			return;
			IL_84:
			this.VAFileListBox = (global::System.Windows.Controls.ListBox)target;
			return;
			IL_11D:
			num = (short)1411252225;
			if (num != 0)
			{
			}
			this.g = true;
			return;
			IL_149:
			this.CancelButton = (global::System.Windows.Controls.Button)target;
			this.CancelButton.Click += this.CancelButton_Click;
			return;
			IL_16D:
			((global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow)target).Closing += this.Window_Closing;
		}

		// Token: 0x04000252 RID: 594
		private global::System.ComponentModel.BackgroundWorker a;

		// Token: 0x04000253 RID: 595
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x04000254 RID: 596
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> c;

		// Token: 0x04000255 RID: 597
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> d;

		// Token: 0x04000256 RID: 598
		private global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem> e = new global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.VoiceAnnouncements.List.VAFileItem>();

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Controls.SelectionMode f;

		// Token: 0x04000258 RID: 600
		internal global::System.Windows.Controls.ListBox VAFileListBox;

		// Token: 0x04000259 RID: 601
		internal global::System.Windows.Controls.Button OKButton;

		// Token: 0x0400025A RID: 602
		internal global::System.Windows.Controls.Button CancelButton;

		// Token: 0x0400025B RID: 603
		private bool g;
	}
}
