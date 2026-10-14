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

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001A4 RID: 420
	public class CustomSelectWindow : global::System.Windows.Window, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x001CD348 File Offset: 0x001CB548
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x001CD3F4 File Offset: 0x001CB5F4
		public global::System.Collections.Generic.List<string> SelectedCertFiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)380436481;
				if (num != 0)
				{
				}
				num = (short)1902718424;
				short num2 = num;
				num = (short)1701260760;
				switch (num2 == num)
				{
				}
				num = (short)535232512;
				short num3 = num;
				num = (short)622067712;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)813738702;
				short num2 = num;
				num = (short)793094862;
				switch (num2 == num)
				{
				}
				num = (short)2057830401;
				if (num != 0)
				{
				}
				num = (short)439222272;
				short num3 = num;
				num = (short)1187053568;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x001CD4A4 File Offset: 0x001CB6A4
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x001CD550 File Offset: 0x001CB750
		public global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> PlanToDownloadFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1744787660;
				short num2 = num;
				num = (short)701061324;
				switch (num2 == num)
				{
				}
				num = (short)1800339457;
				if (num != 0)
				{
				}
				num = (short)861667328;
				short num3 = num;
				num = (short)1875116032;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)610904740;
				short num2 = num;
				num = (short)6400676;
				switch (num2 == num)
				{
				}
				num = (short)241696769;
				if (num != 0)
				{
				}
				num = (short)465633280;
				short num3 = num;
				num = (short)1732444160;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x001CD600 File Offset: 0x001CB800
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x001CD6B0 File Offset: 0x001CB8B0
		public global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> DownloadedFileList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)525926401;
				if (num != 0)
				{
				}
				num = (short)821637052;
				short num2 = num;
				num = (short)999567292;
				switch (num2 == num)
				{
				}
				num = (short)576651264;
				short num3 = num;
				num = (short)1624309760;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1955429151;
				short num2 = num;
				num = (short)1790606111;
				switch (num2 == num)
				{
				}
				num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)641400832;
				short num3 = num;
				num = (short)1573060608;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00003839 File Offset: 0x00001A39
		public CustomSelectWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x001CD760 File Offset: 0x001CB960
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x001CD814 File Offset: 0x001CBA14
		public global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.SystemCertificates.List.CertFileItem> CertFileItems
		{
			get
			{
				short num = (short)519931179;
				short num2 = num;
				num = (short)810714411;
				switch (num2 == num)
				{
				}
				num = (short)2041511937;
				if (num != 0)
				{
				}
				num = (short)850919424;
				short num3 = num;
				num = (short)1512898560;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)149963492;
				short num2 = num;
				num = (short)733561572;
				switch (num2 == num)
				{
				}
				num = (short)1212874752;
				if (num != 0)
				{
				}
				num = (short)1858863104;
				short num3 = num;
				num = (short)348520449;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x001CD8C4 File Offset: 0x001CBAC4
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x001CD970 File Offset: 0x001CBB70
		internal global::System.Windows.Controls.SelectionMode CertFileListBoxSelectionMethod
		{
			get
			{
				short num = (short)132120577;
				if (num != 0)
				{
				}
				num = (short)405748512;
				short num2 = num;
				num = (short)490683168;
				switch (num2 == num)
				{
				}
				num = (short)1302462464;
				short num3 = num;
				num = (short)1395720192;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				int a_ = 1;
				short num = (short)83245615;
				short num2 = num;
				num = (short)165231151;
				switch (num2 == num)
				{
				}
				num = (short)781320193;
				if (num != 0)
				{
				}
				num = (short)1414332416;
				short num3 = num;
				num = (short)1382744064;
				if (num != 0)
				{
				}
				(base.FindName(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃慎ﺉ쪋ﲏ\ud893ﾕ\ude9b\ud89f", a_)) as global::System.Windows.Controls.ListBox).SelectionMode = value;
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x001CDA44 File Offset: 0x001CBC44
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)222691328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)913965056;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> package;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1873412101;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Guid? fileUuid;
									if (fileUuid != null)
									{
										num = (short)855375875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_22E;
								case 3:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary;
									this.CertFileItems.Add(new global::SpecialFeatures.SystemCertificates.List.CertFileItem(astrocacertificatesSummary.PackageName, astrocacertificatesSummary.Uuid));
									num = (short)2076246016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1649803272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary = enumerator.Current as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary;
									num = (short)1856897030;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary;
									if (astrocacertificatesSummary != null)
									{
										num = (short)861601799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary;
									global::System.Guid? fileUuid = astrocacertificatesSummary.FileUuid;
									num = (short)1937113089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)843448322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15B:
								num = (short)701759492;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C:
								goto IL_15B;
							}
							IL_22E:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_241;
					case 1:
						if (package == null)
						{
							num = (short)1701445634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_241;
					case 2:
						return;
					}
					goto IL_64;
					IL_241:
					enumerator = package.GetEnumerator();
					num = (short)898170262;
					short num4 = num;
					num = (short)1935080854;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num = (short)678887424;
						if (num != 0)
						{
						}
						num = (short)428212224;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return;
				IL_64:
				package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates);
				num = (short)71761921;
				if (num != 0)
				{
				}
				num = (short)256966657;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x001CDD24 File Offset: 0x001CBF24
		private void OKButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2033385473;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_2DA;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_206;
				case 3:
					try
					{
						num = (short)1351286786;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1226244097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_140;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C6;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1305673728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.SystemCertificates.List.CertFileItem item = (global::SpecialFeatures.SystemCertificates.List.CertFileItem)enumerator.Current;
								this.PlanToDownloadFileList.Add(item);
								num = (short)1134493699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_F7:
							num = (short)882507780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C6:
							goto IL_F7;
						}
						IL_140:
						goto IL_2A6;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_161;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_14F:
							switch (num2)
							{
							case 0:
								goto IL_203;
							case 1:
								if (disposable != null)
								{
									num = (short)1173815298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_205;
							case 2:
								for (;;)
								{
									num = (short)1890777384;
									short num3 = num;
									num = (short)171505960;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_1CF;
									}
								}
								IL_1CF:
								num = (short)1595146240;
								if (num != 0)
								{
								}
								disposable.Dispose();
								num = (short)242614272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161;
						}
						IL_203:
						IL_205:
						goto EndFinally_6;
						IL_161:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)248250369;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_14F;
						EndFinally_6:;
					}
					goto IL_206;
					IL_2A6:
					this.OKButton.IsEnabled = false;
					this.a.RunWorkerAsync(this.PlanToDownloadFileList);
					num = (short)885653504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_35:
				num = (short)457113600;
				short num4 = num;
				if (this.CertFileListBox.SelectedItems.Count > 0)
				{
					num = (short)241238018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_206:
				this.a = new global::System.ComponentModel.BackgroundWorker();
				this.a.WorkerSupportsCancellation = true;
				this.a.WorkerReportsProgress = true;
				this.a.DoWork += this.downLoadWorker_DoWork;
				this.a.ProgressChanged += this.downLoadWorker_ProgressChanged;
				this.a.RunWorkerCompleted += this.downLoadWorker_RunWorkerCompleted;
				this.PlanToDownloadFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>();
				enumerator = this.CertFileListBox.SelectedItems.GetEnumerator();
				num = (short)565182467;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2DA:
			num = (short)1997209601;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x001CE044 File Offset: 0x001CC244
		private void CancelButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)827457537;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					for (;;)
					{
						this.a.CancelAsync();
						num = (short)1942855917;
						short num3 = num;
						num = (short)1581752557;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BB;
						}
					}
					IL_BB:
					num = (short)1165688833;
					if (num != 0)
					{
					}
					num = (short)487849984;
					if (num != 0)
					{
					}
					num = (short)1664548864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)1752170496;
				short num4 = num;
				if (this.a == null)
				{
					break;
				}
				num = (short)1088684034;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			this.SelectedCertFiles = new global::System.Collections.Generic.List<string>();
			base.DialogResult = new bool?(false);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x001CE17C File Offset: 0x001CC37C
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
					goto IL_148;
				case 1:
					this.a.CancelAsync();
					this.SelectedCertFiles = new global::System.Collections.Generic.List<string>();
					num2 = (short)1219952644;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1099890689;
					if (num2 != 0)
					{
					}
					if (dialogResult == null)
					{
						num2 = (short)1581056003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)1822556160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1383036727;
					short num3 = num2;
					num2 = (short)2095413047;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						goto IL_119;
					}
					break;
				}
				}
				goto IL_24;
				IL_148:
				if (this.a == null)
				{
					return;
				}
				num2 = (short)355729409;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_119:
			num2 = (short)1949499392;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			num2 = (short)1727922176;
			short num4 = num2;
			dialogResult = base.DialogResult;
			num2 = (short)1599340546;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x001CE2F8 File Offset: 0x001CC4F8
		private void downLoadWorker_DoWork(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			short num = (short)188350464;
			switch (num)
			{
			default:
			{
				num = (short)850067456;
				short num2 = num;
				global::System.ComponentModel.BackgroundWorker backgroundWorker = A_0 as global::System.ComponentModel.BackgroundWorker;
				this.PlanToDownloadFileList = (global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>)A_1.Argument;
				this.DownloadedFileList = new global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>();
				using (global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator())
				{
					num = (short)2055208963;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1399259137;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses.Downloading;
							num = (short)1452277762;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1068105732;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_383;
							}
							continue;
						case 4:
							goto IL_3F8;
						}
						IL_3A9:
						num = (short)457637888;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_383:
						goto IL_3A9;
					}
					IL_3F8:
					goto IL_332;
				}
				goto IL_40B;
				global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> list;
				for (;;)
				{
					IL_332:
					list = new global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>();
					using (global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>.Enumerator enumerator = this.PlanToDownloadFileList.GetEnumerator())
					{
						num = (short)362283014;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::SpecialFeatures.SystemCertificates.List.CertFileItem certFileItem;
							switch (num3)
							{
							case 0:
							{
								num = (short)246403767;
								short num4 = num;
								num = (short)1519178423;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_11E;
								default:
									num = (short)503513088;
									if (num != 0)
									{
									}
									if (backgroundWorker.CancellationPending)
									{
										num = (short)74055684;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1040384001;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1D8;
									}
									string text2;
									for (;;)
									{
										IL_1BD:
										switch (num3)
										{
										case 0:
											goto IL_2BD;
										case 1:
											num = (short)906559489;
											if (num != 0)
											{
											}
											goto IL_2BD;
										case 2:
										{
											string text = text2.Replace(global::System.IO.Path.GetExtension(text2), "");
											global::System.IO.File.Copy(text2, text, true);
											certFileItem.FullPathAndName = text;
											this.DownloadedFileList.Add(certFileItem);
											global::System.IO.File.Delete(text2);
											num = (short)266469376;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											if (!string.IsNullOrEmpty(text2))
											{
												num = (short)128057346;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											list.Add(certFileItem);
											num = (short)1406533633;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_2D7;
										}
										goto IL_1D8;
										IL_2BD:
										num = (short)1171259396;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_2D7:
									break;
									IL_1D8:
									text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(certFileItem.SoftwareUuid);
									num = (short)589496323;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_1BD;
								}
								catch (global::System.Exception)
								{
									break;
								}
								goto IL_2E2;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)263651333;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_11E;
							case 3:
								goto IL_302;
							case 4:
								goto IL_2E2;
							case 5:
								num = (short)1380712455;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 7:
								goto IL_31F;
							}
							IL_C6:
							num = (short)901054466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_C6;
							IL_11E:
							certFileItem = enumerator.Current;
							num = (short)86376448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E2:
							A_1.Cancel = true;
							num = (short)1713635331;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_302:
						IL_31F:
						break;
					}
				}
				IL_40B:
				this.a(list);
				A_1.Result = this.DownloadedFileList;
				return;
			}
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x001CE770 File Offset: 0x001CC970
		private void a(global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> A_0)
		{
			int a_ = 12;
			short num = (short)622919685;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					int num3;
					if (num3 >= A_0.Count - 1)
					{
						num = (short)1189019649;
						if (num != 0)
						{
						}
						num = (short)410145347;
						short num4 = num;
						num = (short)2123321923;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2102984704;
							if (num != 0)
							{
							}
							num = (short)1309999105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					string text = text + A_0[num3].FileName + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎎ놐", a_);
					num3++;
					num = (short)1153105923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)155254784;
					short num5 = num;
					string text;
					text += A_0[A_0.Count - 1].FileName;
					CS$<>8__locals1.msg = global::CommonResources.AppResources.SystemCertificate_FileDownloadFailed + text;
					base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						short num6 = (short)2129199105;
						if (num6 != 0)
						{
						}
						num6 = (short)430933975;
						short num7 = num6;
						num6 = (short)626165719;
						switch (num7 == num6)
						{
						default:
						{
							num6 = (short)841285632;
							short num8 = num6;
							break;
						}
						case true:
							break;
						}
						num6 = (short)1624113152;
						if (num6 != 0)
						{
						}
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, CS$<>8__locals1.msg);
					}), global::System.Windows.Threading.DispatcherPriority.Background, global::System.Array.Empty<object>());
					num = (short)920977414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_6F;
				case 3:
					goto IL_6F;
				case 4:
				{
					string text = "";
					int num3 = 0;
					num = (short)93847554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 6:
					return;
				}
				IL_4A:
				if (A_0.Count != 0)
				{
					num = (short)1797324804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6F:
				num = (short)1381236736;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x001CE994 File Offset: 0x001CCB94
		private void downLoadWorker_RunWorkerCompleted(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)1950482435;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1559615496;
						short num3 = num;
						num = (short)616617992;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2074476544;
							if (num != 0)
							{
							}
							base.DialogResult = new bool?(true);
							this.SelectedCertFiles = new global::System.Collections.Generic.List<string>();
							using (global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>.Enumerator enumerator = this.DownloadedFileList.GetEnumerator())
							{
								num = (short)839122947;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)654508036;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2013528064;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.SystemCertificates.List.CertFileItem certFileItem = enumerator.Current;
										this.SelectedCertFiles.Add(certFileItem.FullPathAndName);
										num = (short)56164353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_12D;
										}
										continue;
									case 4:
										goto IL_1AB;
									}
									IL_12F:
									num = (short)1998716930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12D:
									goto IL_12F;
								}
								IL_1AB:;
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
					goto IL_1CC;
				case 1:
					if (!A_1.Cancelled)
					{
						num = (short)1781661700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1580138497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)195035137;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 4:
					goto IL_1CC;
				}
				IL_60:
				if (A_1.Error == null)
				{
					num = (short)1736572930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CC:
				num = (short)809566208;
				short num4 = num;
				num = (short)261816320;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x001CEC24 File Offset: 0x001CCE24
		private void downLoadWorker_ProgressChanged(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)1936209575;
			short num2 = num;
			num = (short)427964071;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)178323456;
				short num3 = num;
				num = (short)1083768832;
				if (num != 0)
				{
				}
				int progressPercentage = A_1.ProgressPercentage;
				using (global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>.Enumerator enumerator = (A_1.UserState as global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem>).GetEnumerator())
				{
					num = (short)534839299;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)685506561;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.DownloadStatus = global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses.Downloaded;
							num = (short)369688578;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1362690052;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						case 4:
							goto IL_139;
						}
						IL_EB:
						num = (short)1513029632;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C6:
						goto IL_EB;
					}
					IL_139:;
				}
				break;
			}
			}
			num = (short)865730561;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x001CEDB4 File Offset: 0x001CCFB4
		public void Dispose()
		{
			short num = (short)1987117057;
			if (num != 0)
			{
			}
			num = (short)1804596540;
			short num2 = num;
			num = (short)749663548;
			switch (num2 == num)
			{
			default:
			{
				num = (short)689045504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1672937472;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x001CEE6C File Offset: 0x001CD06C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1061093379;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A7;
				case 1:
				{
					num = (short)2085477237;
					short num3 = num;
					num = (short)1977604981;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)494862336;
						if (num != 0)
						{
						}
						if (this.a != null)
						{
							num = (short)965345284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					}
					break;
				}
				case 2:
					num = (short)147324929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					this.a.Dispose();
					this.a = null;
					num = (short)1161822209;
					if (num != 0)
					{
					}
					num = (short)606339072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				if (!disposing)
				{
					break;
				}
				num = (short)484507650;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A7:
			IL_132:
			num = (short)1905983488;
			short num4 = num;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x001CEFD4 File Offset: 0x001CD1D4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			if (this.g)
			{
				short num = (short)660277073;
				short num2 = num;
				num = (short)350226257;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1150418945;
					if (num != 0)
					{
					}
					num = (short)1467744256;
					short num3 = num;
					num = (short)1088356352;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.g = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢆ\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쪨쒪사\udfae\udeb0\uddb2킴\ud9b6춸钺\udebc\udabe돀럂계ꇆꃈ꣊곌믎듐뻒듔맖룘볚룜닞蓠跢釤죦髨鋪黬鯮铰黲雴鋶诸迺铼駾栀怂搄猆氈朊搌簎攐㰒瘔或樘漚爜爞删䘢䤤䈦䨨弪娬䘮弰圲娴䀶ᘸ堺䠼䰾㕀ⱂ⡄㑆ⱈ❊⡌ⱎ═⑒㱔㥖㵘㑚⩜煞ᥠɢࡤ୦", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x001CF0B8 File Offset: 0x001CD2B8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1774190593;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1822818305;
					if (num != 0)
					{
					}
					num = (short)2083454978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_148;
				}
				IL_31:
				num = (short)1587750937;
				short num3 = num;
				num = (short)1011820569;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)856031232;
					short num4 = num;
					break;
				}
				}
				num = (short)585170944;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_171;
				case 2:
					goto IL_FD;
				case 3:
					goto IL_D9;
				case 4:
					goto IL_14D;
				default:
					num = (short)536805376;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D9:
			this.OKButton = (global::System.Windows.Controls.Button)target;
			this.OKButton.Click += this.OKButton_Click;
			return;
			IL_FD:
			this.CertFileListBox = (global::System.Windows.Controls.ListBox)target;
			return;
			IL_148:
			this.g = true;
			return;
			IL_14D:
			this.CancelButton = (global::System.Windows.Controls.Button)target;
			this.CancelButton.Click += this.CancelButton_Click;
			return;
			IL_171:
			((global::SpecialFeatures.SystemCertificates.List.CustomSelectWindow)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.SystemCertificates.List.CustomSelectWindow)target).Closing += this.Window_Closing;
		}

		// Token: 0x04000AF7 RID: 2807
		private global::System.ComponentModel.BackgroundWorker a;

		// Token: 0x04000AF8 RID: 2808
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x04000AF9 RID: 2809
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> c;

		// Token: 0x04000AFA RID: 2810
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::SpecialFeatures.SystemCertificates.List.CertFileItem> d;

		// Token: 0x04000AFB RID: 2811
		private global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.SystemCertificates.List.CertFileItem> e = new global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.SystemCertificates.List.CertFileItem>();

		// Token: 0x04000AFC RID: 2812
		private global::System.Windows.Controls.SelectionMode f;

		// Token: 0x04000AFD RID: 2813
		internal global::System.Windows.Controls.ListBox CertFileListBox;

		// Token: 0x04000AFE RID: 2814
		internal global::System.Windows.Controls.Button OKButton;

		// Token: 0x04000AFF RID: 2815
		internal global::System.Windows.Controls.Button CancelButton;

		// Token: 0x04000B00 RID: 2816
		private bool g;
	}
}
