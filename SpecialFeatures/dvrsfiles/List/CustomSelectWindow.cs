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
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000125 RID: 293
	public class CustomSelectWindow : global::System.Windows.Window, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0015F430 File Offset: 0x0015D630
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0015F4E0 File Offset: 0x0015D6E0
		public global::System.Collections.Generic.List<string> SelectedDVRSFiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)285176299;
				short num2 = num;
				num = (short)1588228587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928055296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982384641;
				if (num != 0)
				{
				}
				num = (short)1134821376;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1028980737;
				if (num != 0)
				{
				}
				num = (short)595066880;
				short num2 = num;
				num = (short)732775605;
				short num3 = num;
				num = (short)1864582325;
				switch (num3 == num)
				{
				}
				num = (short)1722023936;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0015F590 File Offset: 0x0015D790
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0015F640 File Offset: 0x0015D840
		public global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> PlanToDownloadFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1699878895;
				short num2 = num;
				num = (short)1149835247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269039104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1731723264;
				if (num != 0)
				{
				}
				num = (short)932118529;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1199959049;
				short num2 = num;
				num = (short)1619323913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1811087360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1935998977;
				if (num != 0)
				{
				}
				num = (short)1039138816;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0015F6F0 File Offset: 0x0015D8F0
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0015F7A0 File Offset: 0x0015D9A0
		public global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> DownloadedFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2088860019;
				short num2 = num;
				num = (short)1329363315;
				switch (num2 == num)
				{
				}
				num = (short)1450704897;
				if (num != 0)
				{
				}
				num = (short)1043857408;
				short num3 = num;
				num = (short)1675755520;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)434784038;
				short num2 = num;
				num = (short)120669990;
				switch (num2 == num)
				{
				}
				num = (short)2016935937;
				if (num != 0)
				{
				}
				num = (short)1065549824;
				short num3 = num;
				num = (short)759693312;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00003491 File Offset: 0x00001691
		public CustomSelectWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0015F850 File Offset: 0x0015DA50
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x0015F8FC File Offset: 0x0015DAFC
		public global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> DVRSFileItems
		{
			get
			{
				short num = (short)1324836731;
				short num2 = num;
				num = (short)1600022395;
				switch (num2 == num)
				{
				}
				num = (short)1955463169;
				if (num != 0)
				{
				}
				num = (short)921370624;
				short num3 = num;
				num = (short)212336640;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1382589199;
				short num2 = num;
				num = (short)1254728463;
				switch (num2 == num)
				{
				}
				num = (short)298254337;
				if (num != 0)
				{
				}
				num = (short)1751384064;
				short num3 = num;
				num = (short)1080885248;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0015F9AC File Offset: 0x0015DBAC
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x0015FA5C File Offset: 0x0015DC5C
		internal global::System.Windows.Controls.SelectionMode DVRSFileListBoxSelectionMethod
		{
			get
			{
				short num = (short)1595075175;
				short num2 = num;
				num = (short)1434905191;
				switch (num2 == num)
				{
				}
				num = (short)975634433;
				if (num != 0)
				{
				}
				num = (short)893845504;
				short num3 = num;
				num = (short)1142226944;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				int a_ = 3;
				short num = (short)704978143;
				short num2 = num;
				num = (short)850468063;
				switch (num2 == num)
				{
				}
				num = (short)398524416;
				if (num != 0)
				{
				}
				num = (short)257294336;
				short num3 = num;
				num = (short)1532755969;
				if (num != 0)
				{
				}
				(base.FindName(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889\udf8b좍憐ﺑ\uda95\udc9d쾟\udaa1", a_)) as global::System.Windows.Controls.ListBox).SelectionMode = value;
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0015FB2C File Offset: 0x0015DD2C
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1311402242;
			short num2 = num;
			num = (short)2113235202;
			switch (num2 == num)
			{
			}
			num = (short)1935212544;
			if (num != 0)
			{
			}
			num = (short)284819456;
			short num3 = num;
			num = (short)651952129;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0015FBD4 File Offset: 0x0015DDD4
		private void OKButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)810549249;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1467219969;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)484311042;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							IL_D7:
							switch (num2)
							{
							case 0:
								num = (short)1217265668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								while (enumerator.MoveNext())
								{
									num = (short)689397458;
									short num3 = num;
									num = (short)824925906;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)523763712;
										if (num != 0)
										{
										}
										global::SpecialFeatures.DVRSFiles.List.DVRSFileItem item = (global::SpecialFeatures.DVRSFiles.List.DVRSFileItem)enumerator.Current;
										this.PlanToDownloadFileList.Add(item);
										num = (short)1257832451;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_D7;
									}
									}
								}
								num = (short)1525153792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_F1;
								}
								continue;
							case 4:
								goto IL_1C3;
							}
							IL_16E:
							num = (short)1890516993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_F1:
							goto IL_16E;
						}
						IL_1C3:
						goto IL_2D5;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1E4;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1D2:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1994260482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)942669824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_234;
							case 2:
								goto IL_232;
							}
							goto IL_1E4;
						}
						IL_232:
						IL_234:
						goto EndFinally_6;
						IL_1E4:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1903165441;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1D2;
						EndFinally_6:;
					}
					goto IL_235;
					IL_2D5:
					this.OKButton.IsEnabled = false;
					this.a.RunWorkerAsync(this.PlanToDownloadFileList);
					num = (short)1178533891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					goto IL_235;
				case 3:
					return;
				}
				IL_5B:
				if (this.DVRSFileListBox.SelectedItems.Count > 0)
				{
					num = (short)1367736320;
					short num4 = num;
					num = (short)1810497538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_235:
				this.a = new global::System.ComponentModel.BackgroundWorker();
				this.a.WorkerSupportsCancellation = true;
				this.a.WorkerReportsProgress = true;
				this.a.DoWork += this.downLoadWorker_DoWork;
				this.a.ProgressChanged += this.downLoadWorker_ProgressChanged;
				this.a.RunWorkerCompleted += this.downLoadWorker_RunWorkerCompleted;
				this.PlanToDownloadFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>();
				enumerator = this.DVRSFileListBox.SelectedItems.GetEnumerator();
				num = (short)1729626112;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0015FF0C File Offset: 0x0015E10C
		private void CancelButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1027997697;
			if (num != 0)
			{
			}
			num = (short)1000144897;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)774936950;
					short num3 = num;
					num = (short)136681846;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)46530560;
						if (num != 0)
						{
						}
						this.a.CancelAsync();
						num = (short)224198658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					goto IL_113;
				}
				IL_5A:
				if (this.a == null)
				{
					break;
				}
				num = (short)2100887552;
				short num4 = num;
				num = (short)437256192;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			this.SelectedDVRSFiles = new global::System.Collections.Generic.List<string>();
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00160048 File Offset: 0x0015E248
		private void Window_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_98;
			}
			short num;
			int num4;
			bool? dialogResult;
			for (;;)
			{
				IL_0A:
				num = (short)1242100769;
				short num2 = num;
				num = (short)72872993;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1024524288;
					short num3 = num;
					break;
				}
				}
				num = (short)1877409792;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1290928132;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					if (dialogResult == null)
					{
						num = (short)1946681347;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)702414849;
					if (num != 0)
					{
					}
					num = (short)1721040896;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.a.CancelAsync();
					this.SelectedDVRSFiles = new global::System.Collections.Generic.List<string>();
					num = (short)1432813569;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_98;
			}
			return;
			IL_98:
			dialogResult = base.DialogResult;
			num = (short)777191426;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x001601C0 File Offset: 0x0015E3C0
		private void downLoadWorker_DoWork(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			short num = (short)1601306624;
			switch (num)
			{
			default:
			{
				global::System.ComponentModel.BackgroundWorker backgroundWorker = A_0 as global::System.ComponentModel.BackgroundWorker;
				this.PlanToDownloadFileList = (global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>)A_1.Argument;
				this.DownloadedFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>();
				using (global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator())
				{
					num = (short)1945239554;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1314979844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)1660813312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses.Downloading;
							num = (short)678625283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_384;
							}
							continue;
						case 4:
							goto IL_3FB;
						}
						IL_3AC:
						num = (short)1975386113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_384:
						goto IL_3AC;
					}
					IL_3FB:
					goto IL_2E1;
				}
				goto IL_40E;
				global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> list;
				for (;;)
				{
					IL_2E1:
					num = (short)1725825025;
					if (num != 0)
					{
					}
					num = (short)1090125824;
					short num3 = num;
					list = new global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>();
					using (global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator())
					{
						num = (short)1525481475;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1899298817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2CE;
							case 2:
								if (backgroundWorker.CancellationPending)
								{
									num = (short)871038980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)762970118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_9A;
								}
								continue;
							case 4:
								goto IL_291;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)567738368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.DVRSFiles.List.DVRSFileItem dvrsfileItem = enumerator.Current;
								num = (short)1522073602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1A8;
									}
									global::SpecialFeatures.DVRSFiles.List.DVRSFileItem dvrsfileItem;
									string text;
									for (;;)
									{
										IL_141:
										num = (short)1199477015;
										short num4 = num;
										num = (short)1409323287;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1735720960;
											if (num != 0)
											{
											}
											switch (num2)
											{
											case 0:
												goto IL_26E;
											case 1:
												goto IL_24A;
											case 2:
												if (!string.IsNullOrEmpty(text))
												{
													num = (short)387514371;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												list.Add(dvrsfileItem);
												num = (short)1239482368;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												string text2 = text.Replace(global::System.IO.Path.GetExtension(text), "");
												global::System.IO.File.Copy(text, text2, true);
												dvrsfileItem.FullPathAndName = text2;
												this.DownloadedFileList.Add(dvrsfileItem);
												global::System.IO.File.Delete(text);
												num = (short)108199937;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_286;
											}
											goto IL_1A8;
										}
										IL_26E:
										num = (short)1822228484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_24A:
										goto IL_26E;
									}
									IL_286:
									break;
									IL_1A8:
									text = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(dvrsfileItem.SoftwareUuid);
									num = (short)1233059842;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_141;
								}
								catch (global::System.Exception)
								{
									break;
								}
								goto IL_291;
							case 7:
								goto IL_2B1;
							}
							IL_9F:
							num = (short)1437663237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9A:
							goto IL_9F;
							IL_291:
							A_1.Cancel = true;
							num = (short)1731854343;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2B1:
						IL_2CE:
						break;
					}
				}
				IL_40E:
				this.a(list);
				A_1.Result = this.DownloadedFileList;
				return;
			}
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0016063C File Offset: 0x0015E83C
		private void a(global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> A_0)
		{
			int a_ = 0;
			short num = (short)413138947;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				int num4;
				switch (num2)
				{
				case 0:
					goto IL_94;
				case 1:
					return;
				case 2:
				{
					text += A_0[A_0.Count - 1].FileName;
					string msg = global::CommonResources.AppResources.SystemCertificate_FileDownloadFailed + text;
					base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						short num6 = (short)1604155668;
						short num7 = num6;
						num6 = (short)534673684;
						switch (num7 == num6)
						{
						}
						num6 = (short)160890881;
						if (num6 != 0)
						{
						}
						num6 = (short)448266240;
						short num8 = num6;
						num6 = (short)444465152;
						if (num6 != 0)
						{
						}
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, msg);
					}), global::System.Windows.Threading.DispatcherPriority.Background, global::System.Array.Empty<object>());
					num = (short)704512001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 4:
					num = (short)1528430593;
					if (num != 0)
					{
					}
					goto IL_18B;
				case 5:
				{
					num = (short)1234698240;
					short num3 = num;
					if (num4 >= A_0.Count - 1)
					{
						num = (short)356974594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = text + A_0[num4].FileName + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꾂ꖄ", a_);
					num4++;
					num = (short)626419476;
					short num5 = num;
					num = (short)1978820372;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18B;
					default:
						num = (short)1724121088;
						if (num != 0)
						{
						}
						num = (short)800849920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_94;
				}
				IL_49:
				if (A_0.Count != 0)
				{
					num = (short)346488836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_94:
				num = (short)1028784133;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18B:
				text = "";
				num4 = 0;
				num = (short)1640693766;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00160864 File Offset: 0x0015EA64
		private void downLoadWorker_RunWorkerCompleted(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)1699807233;
			if (num != 0)
			{
			}
			num = (short)1300365312;
			short num2 = num;
			num = (short)2136997890;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (!A_1.Cancelled)
					{
						num = (short)945553412;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					try
					{
						num = (short)992228046;
						short num4 = num;
						num = (short)2006135502;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1315635200;
							if (num != 0)
							{
							}
							base.DialogResult = new bool?(true);
							this.SelectedDVRSFiles = new global::System.Collections.Generic.List<string>();
							using (global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>.Enumerator enumerator = this.DownloadedFileList.GetEnumerator())
							{
								num = (short)920387586;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
										num = (short)1207894020;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_153;
										}
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)313065473;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.DVRSFiles.List.DVRSFileItem dvrsfileItem = enumerator.Current;
										this.SelectedDVRSFiles.Add(dvrsfileItem.FullPathAndName);
										num = (short)670695424;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1D1;
									}
									IL_155:
									num = (short)477495299;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_153:
									goto IL_155;
								}
								IL_1D1:;
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
					goto IL_1EC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				case 3:
					num = (short)1745420288;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1EC;
				}
				IL_87:
				if (A_1.Error == null)
				{
					num = (short)581894147;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1EC:
				num = (short)973996033;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00160AEC File Offset: 0x0015ECEC
		private void downLoadWorker_ProgressChanged(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)1654128641;
			if (num != 0)
			{
			}
			num = (short)1426194432;
			short num2 = num;
			num = (short)1660256073;
			short num3 = num;
			num = (short)781942601;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)174522368;
				if (num != 0)
				{
				}
				int progressPercentage = A_1.ProgressPercentage;
				using (global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>.Enumerator enumerator = (A_1.UserState as global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>).GetEnumerator())
				{
					num = (short)1314390018;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1883832324;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)1142751232;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses.Downloaded;
							num = (short)242089987;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						case 4:
							goto IL_163;
						}
						IL_116:
						num = (short)1012203521;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EF:
						goto IL_116;
					}
					IL_163:;
				}
				break;
			}
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00160C7C File Offset: 0x0015EE7C
		public void Dispose()
		{
			short num = (short)377058895;
			short num2 = num;
			num = (short)196179535;
			switch (num2 == num)
			{
			}
			num = (short)861011969;
			if (num != 0)
			{
			}
			num = (short)1815609344;
			short num3 = num;
			num = (short)353042432;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00160D30 File Offset: 0x0015EF30
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)705888260;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)174850051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_121;
				case 3:
				{
					num = (short)1841421738;
					short num3 = num;
					num = (short)135388586;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_121;
					default:
						num = (short)2082996225;
						if (num != 0)
						{
						}
						num = (short)1462763520;
						if (num != 0)
						{
						}
						this.a.Dispose();
						this.a = null;
						num = (short)2026897409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					num = (short)898301952;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				}
				IL_62:
				if (disposing)
				{
					num = (short)1938292738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_121:
				num = (short)1687814144;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00160E9C File Offset: 0x0015F09C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this.g)
			{
				short num = (short)162812402;
				short num2 = num;
				num = (short)1160794610;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1204420608;
					if (num != 0)
					{
					}
					num = (short)1189085185;
					if (num != 0)
					{
					}
					num = (short)997523456;
					short num3 = num;
					break;
				}
				}
				return;
			}
			this.g = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾Ꟃ도뗆뫈귊꓌ꏎ듐ꃒ䀹돖꿘꧚껜맞裠迢胤详胨飪駬샮鋰蛲蛴菶雸雺軼髾洀昂昄猆縈戊挌欎縐搒㨔琖氘栚検瀞䰠倢䀤䬦䰨䠪夬堮堰崲儴堶丸ᔺ䔼帾ⱀ⽂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00160F80 File Offset: 0x0015F180
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1673658370;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1744201550;
					short num3 = num;
					num = (short)729376590;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						num = (short)974192640;
						if (num != 0)
						{
						}
						num = (short)842465281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_143;
				case 2:
				{
					num = (short)1398210560;
					short num4 = num;
					num = (short)944766977;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				}
				}
				IL_81:
				switch (connectionId)
				{
				case 1:
					goto IL_16C;
				case 2:
					goto IL_11F;
				case 3:
					goto IL_FB;
				case 4:
					goto IL_148;
				default:
					num = (short)628031488;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FB:
			this.OKButton = (global::System.Windows.Controls.Button)target;
			this.OKButton.Click += this.OKButton_Click;
			return;
			IL_11F:
			this.DVRSFileListBox = (global::System.Windows.Controls.ListBox)target;
			return;
			IL_143:
			this.g = true;
			return;
			IL_148:
			this.CancelButton = (global::System.Windows.Controls.Button)target;
			this.CancelButton.Click += this.CancelButton_Click;
			return;
			IL_16C:
			((global::SpecialFeatures.DVRSFiles.List.CustomSelectWindow)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.DVRSFiles.List.CustomSelectWindow)target).Closing += this.Window_Closing;
		}

		// Token: 0x04000810 RID: 2064
		private global::System.ComponentModel.BackgroundWorker a;

		// Token: 0x04000811 RID: 2065
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x04000812 RID: 2066
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> c;

		// Token: 0x04000813 RID: 2067
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> d;

		// Token: 0x04000814 RID: 2068
		private global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem> e = new global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.DVRSFiles.List.DVRSFileItem>();

		// Token: 0x04000815 RID: 2069
		private global::System.Windows.Controls.SelectionMode f;

		// Token: 0x04000816 RID: 2070
		internal global::System.Windows.Controls.ListBox DVRSFileListBox;

		// Token: 0x04000817 RID: 2071
		internal global::System.Windows.Controls.Button OKButton;

		// Token: 0x04000818 RID: 2072
		internal global::System.Windows.Controls.Button CancelButton;

		// Token: 0x04000819 RID: 2073
		private bool g;
	}
}
