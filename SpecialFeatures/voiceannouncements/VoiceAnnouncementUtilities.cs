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
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;
using ACPVoiceAnnouncementLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.VoiceAnnouncements
{
	// Token: 0x02000015 RID: 21
	public class VoiceAnnouncementUtilities : global::System.Windows.Navigation.PageFunction<string>, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		public VoiceAnnouncementUtilities()
		{
			int a_ = 0;
			this.f = new global::SpecialFeatures.SpecialFeaturesSettings();
			base..ctor();
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			this.c = null;
			this.d = false;
			this.b = new global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>();
			this.voiceAnnDownloadList.ItemsSource = this.GetListOfVoiceAnn();
			this.txtboxdownloadPath.Text = this.a();
			this.e = this.voiceAnnDownloadList.SelectionMode;
			if (this.voiceAnnDownloadList.Items.IsEmpty)
			{
				this.btnDownloadSelectAll.IsEnabled = false;
				this.btnDownloadUnSelectAll.IsEnabled = false;
			}
			else
			{
				this.btnDownloadSelectAll.IsEnabled = true;
				this.btnDownloadUnSelectAll.IsEnabled = true;
			}
			if (global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
			{
				this.txtboxdownloadPath.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
				this.txtboxdownloadPath.TextAlignment = global::System.Windows.TextAlignment.Right;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		internal global::System.Collections.Generic.List<string> GetListOfVoiceAnn()
		{
			short num = (short)476577792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)74055681;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_4D:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)722403331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						goto IL_2FE;
					case 2:
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)1938882561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 3:
						num = (short)132775938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)2095906816;
						short num3 = num;
						try
						{
							num = (short)2121859072;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_100;
									}
									continue;
								case 1:
									num = (short)1171062787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_23E;
								case 4:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)1719599109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo item = new global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo(voiceAnnouncementList.General.VoiceFileName_A21220Value, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.compressionType, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.compressionParam, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData.GetBuffer(), (int)voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData.Length);
									this.b.Add(item);
									list.Add(voiceAnnouncementList.General.VoiceFileName_A21220Value);
									num = (short)2134638594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1345454081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator.Current;
									num = (short)1351221252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_14B:
								num = (short)525795334;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_100:
								goto IL_14B;
							}
							IL_23E:
							return list;
						}
						finally
						{
							for (;;)
							{
								IL_243:
								num = (short)1355087873;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2FB;
									case 1:
									{
										num = (short)1286404629;
										short num4 = num;
										num = (short)506526229;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_243;
										default:
											num = (short)511508480;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_2C3;
											}
											continue;
										}
										break;
									}
									case 2:
										enumerator.Dispose();
										num = (short)720240640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2C3:
									if (enumerator == null)
									{
										goto IL_2FD;
									}
									num = (short)211025922;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_2FB:
							IL_2FD:;
						}
						goto IL_2FE;
					}
					}
					goto IL_68;
					IL_2FE:
					enumerator = voiceAnnouncementListRecSet.GetEnumerator();
					num = (short)1394606084;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_68:
				list = new global::System.Collections.Generic.List<string>();
				this.b.Clear();
				voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
				num = (short)545128448;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4D;
			}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000E884 File Offset: 0x0000CA84
		public override void OnApplyTemplate()
		{
			int a_ = 15;
			short num = (short)1666056192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::System.Windows.Style style;
				for (;;)
				{
					IL_31:
					global::System.Windows.Style style2;
					switch (num2)
					{
					case 0:
						if (style != null)
						{
							num = (short)1689518083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					case 1:
						goto IL_DF;
					case 2:
					{
						global::System.Windows.Style itemContainerStyle = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ListViewItem), style2);
						this.vaDownloadListView.ItemContainerStyle = itemContainerStyle;
						num = (short)1520369668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						IL_9F:
						global::System.Windows.Style itemContainerStyle2 = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ListViewItem), style);
						this.voiceAnnDownloadList.ItemContainerStyle = itemContainerStyle2;
						num = (short)787283969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_193;
					case 5:
						if (style2 != null)
						{
							num = (short)1264254978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					}
					goto IL_50;
					IL_193:
					num = (short)592470698;
					short num3 = num;
					num = (short)650797738;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						goto IL_1C9;
					}
					IL_DF:
					style2 = (global::System.Windows.Style)base.TryFindResource(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude91ﶓ척ﮝ힟킣쎥얧囹\ud8ab힭\udcafힱힵ쮷\udfb9", a_));
					num = (short)2121269249;
					if (num != 0)
					{
					}
					num = (short)1703018501;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C9:
				num = (short)1222705152;
				short num4 = num;
				num = (short)158466048;
				if (num != 0)
				{
				}
				return;
				IL_50:
				base.OnApplyTemplate();
				style = (global::System.Windows.Style)base.TryFindResource(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude91ﶓ척ﮝ힟킣쎥얧쎫삭쒯ힱ\udab3습캹얻튽ꖿ", a_));
				num = (short)1489502208;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000EA98 File Offset: 0x0000CC98
		protected override void Start()
		{
			short num = (short)1058668544;
			short num2 = num;
			num = (short)1862008833;
			if (num != 0)
			{
			}
			num = (short)1160490368;
			short num3 = num;
			num = (short)511290752;
			switch (num3 == num)
			{
			}
			num = (short)3211264;
			if (num != 0)
			{
			}
			this.c = (global::System.Windows.Window)base.Parent;
			this.c.Closing += this.parent_Closing;
			base.Start();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		private void parent_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)840237057;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E9;
					case 1:
					{
						num = (short)690015516;
						short num3 = num;
						num = (short)1269615900;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1893203968;
							short num4 = num;
							num = (short)1547632640;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						}
						}
						break;
					}
					case 2:
						this.a.CancelCompressAudioFilesInDirectory();
						num = (short)1651900416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (!this.d)
					{
						goto IL_EB;
					}
					num = (short)634912770;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E9:
			IL_EB:
			num = (short)1905393665;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000EC90 File Offset: 0x0000CE90
		private string a()
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (global::System.IO.Directory.Exists(this.f.VA_DOWNLOAD_FILE_LOCATION))
					{
						num2 = (short)796721155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊ﮎﺐ杖ﮖ잚\udc9c\ud9a0쒤쪦삨잪풬횸횺킼킾꿀鿂鏄꣆ꃈ꣊꣌軎뿐뷒뫔ꋖ럘룚룜닞蓠跢釤ꫦ鿨諪꯬蛮鷰雲蛴", a_));
					num2 = (short)281346053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return text;
				case 2:
				{
					num2 = (short)1092747264;
					short num3 = num2;
					text = global::CommonResources.AppResources.Please_Select_Voice_File_Download_Location;
					num2 = (short)1135607809;
					if (num2 != 0)
					{
					}
					num2 = (short)1812004868;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1547983402;
					short num4 = num2;
					num2 = (short)219241002;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1796341760;
						if (num2 != 0)
						{
						}
						text = this.f.VA_DOWNLOAD_FILE_LOCATION;
						num2 = (short)1952579585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return text;
				case 5:
					if (!global::System.IO.Directory.Exists(text))
					{
						num2 = (short)139329538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				}
				goto IL_31;
			}
			return text;
			IL_31:
			text = "";
			num2 = (short)567279616;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000EE54 File Offset: 0x0000D054
		private void btnDownloadSelectAll_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)439877632;
			short num2 = num;
			num = (short)1953948716;
			short num3 = num;
			num = (short)1371989036;
			switch (num3 == num)
			{
			}
			num = (short)1333854209;
			if (num != 0)
			{
			}
			num = (short)1377763328;
			if (num != 0)
			{
			}
			this.voiceAnnDownloadList.UnselectAll();
			this.voiceAnnDownloadList.SelectionMode = global::System.Windows.Controls.SelectionMode.Multiple;
			this.voiceAnnDownloadList.SelectAll();
			this.btnDownloadUnSelectAll.IsEnabled = true;
			this.voiceAnnDownloadList.Focus();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000EF38 File Offset: 0x0000D138
		private void btnDownloadUnSelectAll_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)587661312;
			short num2 = num;
			num = (short)2055062970;
			short num3 = num;
			num = (short)1092535738;
			switch (num3 == num)
			{
			}
			num = (short)115933184;
			if (num != 0)
			{
			}
			num = (short)791281665;
			if (num != 0)
			{
			}
			this.voiceAnnDownloadList.UnselectAll();
			this.voiceAnnDownloadList.SelectionMode = this.e;
			this.btnDownloadSelectAll.IsEnabled = true;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000F008 File Offset: 0x0000D208
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
					goto IL_119;
				case 1:
					if (this.vaDownloadListView.IsVisible)
					{
						num2 = (short)1728053250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				case 2:
				{
					num2 = (short)1998913537;
					if (num2 != 0)
					{
					}
					global::SpecialFeatures.VoiceAnnouncements.VoiceAnnouncementUtilities.ConvertResult convertResult;
					this.vaDownloadListView.ScrollIntoView(convertResult);
					num2 = (short)1176305664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_119:
			num2 = (short)37879808;
			short num3 = num2;
			IL_146:
			this.vaDownloadProgressBar.Value = (double)A_0.CurrentFileCount / (double)A_0.TotalFileCount * 100.0;
			return;
			IL_1C:
			num2 = (short)737279753;
			short num4 = num2;
			num2 = (short)1170276105;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)912457728;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.VoiceAnnouncements.VoiceAnnouncementUtilities.ConvertResult convertResult = new global::SpecialFeatures.VoiceAnnouncements.VoiceAnnouncementUtilities.ConvertResult(A_0.FileName, A_0.Code);
				this.vaDownloadListView.Items.Add(convertResult);
				num2 = (short)188284929;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000F180 File Offset: 0x0000D380
		private void a(global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted A_0)
		{
			short num = (short)1020554967;
			short num2 = num;
			num = (short)976121559;
			switch (num2 == num)
			{
			}
			num = (short)1379467265;
			if (num != 0)
			{
			}
			num = (short)1569587200;
			if (num != 0)
			{
			}
			num = (short)69992448;
			short num3 = num;
			this.a = null;
			this.d = false;
			this.btndownload.IsEnabled = true;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000F244 File Offset: 0x0000D444
		private void a(global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest A_0)
		{
			short num = (short)898961314;
			short num2 = num;
			num = (short)542248866;
			switch (num2 == num)
			{
			}
			num = (short)1642987521;
			if (num != 0)
			{
			}
			num = (short)422445056;
			if (num != 0)
			{
			}
			num = (short)870973440;
			short num3 = num;
			A_0.ActionToTake = global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.OVERWRITE_FILE;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		private void btndownload_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)210829312;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					num = (short)1546518531;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1582628865;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_345;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2AD;
										}
										continue;
									case 2:
										num = (short)2045968384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)360316930;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object item = enumerator.Current;
										int index = this.voiceAnnDownloadList.Items.IndexOf(item);
										global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> list;
										list.Add(this.b[index]);
										num = (short)654573571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_2AF:
									num = (short)912064516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2AD:
									goto IL_2AF;
								}
								IL_345:
								goto IL_8F;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_367;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_354:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1146093570;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3EC;
									case 1:
										goto IL_3EA;
									case 2:
										disposable.Dispose();
										num = (short)783482881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_367;
								}
								IL_3EA:
								IL_3EC:
								goto EndFinally_8;
								IL_367:
								num = (short)1529348097;
								if (num != 0)
								{
								}
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)502726656;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_354;
								EndFinally_8:;
							}
							goto IL_3ED;
							IL_8F:
							this.a = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate();
							num = (short)2031353862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_26E;
						case 2:
						{
							global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> list = new global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>();
							string text = this.txtboxdownloadPath.Text.Trim();
							this.vaDownloadListView.Items.Clear();
							this.vaDownloadListView.Items.SortDescriptions.Clear();
							this.vaDownloadProgressBar.Value = 0.0;
							global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption = global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.OVERWRITE_ALL_FILES;
							num = (short)449376588;
							short num3 = num;
							num = (short)753987916;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1914503168;
								if (num != 0)
								{
								}
								num = (short)1050148869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_62;
							}
							continue;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator = this.voiceAnnDownloadList.SelectedItems.GetEnumerator();
							num = (short)1882193920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							string text;
							if (global::System.IO.Directory.Exists(text))
							{
								num = (short)1814822916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E3;
						}
						case 6:
							try
							{
								this.btndownload.IsEnabled = false;
								global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> list;
								string text;
								global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption;
								this.a.DownloadVoiceDataToDirectoryAsync(list, text, overwriteOption, new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted(this.a));
								this.d = true;
								this.f.VA_DOWNLOAD_FILE_LOCATION = text;
								this.f.Save();
								goto IL_3ED;
							}
							catch (global::System.InvalidOperationException)
							{
								this.btndownload.IsEnabled = true;
								goto IL_3ED;
							}
							goto IL_24A;
						}
						IL_62:
						if (this.voiceAnnDownloadList.SelectedItems.Count > 0)
						{
							num = (short)1649934338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_24A:
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Select_Files_Download);
						num = (short)608108545;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_E3:
			global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.The_output_directory_does_not_exist, global::CommonResources.AppResources.Download_directory_not_found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
			return;
			IL_26E:
			IL_3ED:
			num = (short)1900281856;
			short num4 = num;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000F734 File Offset: 0x0000D934
		private void btndownloadCancel_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)907149312;
			short num2 = num;
			num = (short)840630274;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)137035777;
					if (num != 0)
					{
					}
					goto IL_C6;
				case 1:
					this.a.CancelCompressAudioFilesInDirectory();
					this.d = false;
					num = (short)1366032384;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 3:
					if (this.c != null)
					{
						num = (short)1014235140;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 4:
					this.c.DialogResult = new bool?(true);
					this.c.Close();
					num = (short)1943797765;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_170;
				}
				IL_70:
				if (this.d)
				{
					num = (short)1762197505;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C6:
				this.OnReturn(new global::System.Windows.Navigation.ReturnEventArgs<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즋憐", a_)));
				num = (short)1898512387;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_170:
				num = (short)587037295;
				short num4 = num;
				num = (short)489978479;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1A5;
				}
			}
			IL_1A5:
			num = (short)196345856;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		private void btnBrowse_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DE;
				case 1:
					if (global::System.IO.Directory.Exists(this.txtboxdownloadPath.Text))
					{
						num2 = (short)2068905988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DE;
				case 2:
				{
					num2 = (short)913047552;
					short num3 = num2;
					if (folderBrowserDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)2126643203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
					goto IL_14A;
				case 4:
					goto IL_C7;
				}
				goto IL_24;
				IL_DE:
				folderBrowserDialog.Description = global::CommonResources.AppResources.Select_the_location_to_store_voice_files;
				num2 = (short)774766594;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14A:
			num2 = (short)717553665;
			if (num2 != 0)
			{
			}
			this.txtboxdownloadPath.Text = folderBrowserDialog.SelectedPath;
			return;
			IL_24:
			folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.RootFolder = global::System.Environment.SpecialFolder.MyComputer;
			num2 = (short)445606754;
			short num4 = num2;
			num2 = (short)1538812770;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C7:
				folderBrowserDialog.SelectedPath = this.txtboxdownloadPath.Text;
				num2 = (short)1234436096;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1116995584;
				if (num2 != 0)
				{
				}
				num2 = (short)1133903873;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		private void vaDownloadLogExpander_Expanded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)281959912;
			short num2 = num;
			num = (short)1766415848;
			switch (num2 == num)
			{
			}
			num = (short)172949505;
			if (num != 0)
			{
			}
			num = (short)1272709120;
			if (num != 0)
			{
			}
			num = (short)1439694848;
			short num3 = num;
			this.vaDownloadListView.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000FB64 File Offset: 0x0000DD64
		private void vaDownloadLogExpander_Collapsed(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1966495084;
			short num2 = num;
			num = (short)1027954028;
			switch (num2 == num)
			{
			}
			num = (short)1556152320;
			if (num != 0)
			{
			}
			num = (short)1664090113;
			if (num != 0)
			{
			}
			num = (short)1237057536;
			short num3 = num;
			this.vaDownloadListView.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		private void GridViewColumnHeader_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)378929152;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 1:
					return;
				case 2:
					num = (short)1591083009;
					if (num != 0)
					{
					}
					this.vaDownloadListView.Items.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d", a_), global::System.ComponentModel.ListSortDirection.Ascending));
					this.vaDownloadListView.Items.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좍憐ﺑ\ud895聯鍊", a_), global::System.ComponentModel.ListSortDirection.Ascending));
					num = (short)1727594497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3A:
				num = (short)713752576;
				short num3 = num;
				global::System.Windows.Controls.ContentControl contentControl = A_0 as global::System.Windows.Controls.GridViewColumnHeader;
				global::System.Windows.Controls.ViewBase view = this.vaDownloadListView.View;
				this.vaDownloadListView.Items.SortDescriptions.Clear();
				if (!((string)contentControl.Content == global::CommonResources.AppResources.Download_Status))
				{
					break;
				}
				num = (short)821488975;
				short num4 = num;
				num = (short)200338767;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)394395648;
					if (num != 0)
					{
					}
					num = (short)363528194;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1121648640;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_E9;
				case 2:
					global::System.Windows.Input.Keyboard.Focus(this);
					num = (short)1602879489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				num = (short)1002766336;
				short num3 = num;
				if (base.IsKeyboardFocusWithin)
				{
					return;
				}
				num = (short)1301457282;
				short num4 = num;
				num = (short)2035198338;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E9;
				default:
					num = (short)558694400;
					if (num != 0)
					{
					}
					num = (short)1620901890;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E9:
			num = (short)1262026753;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1386826309;
			short num2 = num;
			num = (short)1220561477;
			switch (num2 == num)
			{
			}
			num = (short)728498177;
			if (num != 0)
			{
			}
			num = (short)1122631680;
			if (num != 0)
			{
			}
			num = (short)970457088;
			short num3 = num;
			A_1.CanExecute = true;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000FF98 File Offset: 0x0000E198
		private void btndownloadHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num;
			try
			{
				num = (short)1904705143;
				short num2 = num;
				num = (short)1620934263;
				switch (num2 == num)
				{
				}
				num = (short)1496383488;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪈ뮊뢌벎ꎒꚖꦘ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)108396545;
			if (num != 0)
			{
			}
			num = (short)415891456;
			short num3 = num;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00010078 File Offset: 0x0000E278
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)215661073;
			short num2 = num;
			num = (short)1514322449;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1243217920;
				if (num != 0)
				{
				}
				num = (short)54067201;
				if (num != 0)
				{
				}
				if (this.g)
				{
					num = (short)2125004800;
					short num3 = num;
					return;
				}
				break;
			}
			this.g = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겂횄﶐햒爵튠颢욤좦쒨\udbaa슬솮풰\uddb2솴颶쾸풺풼\udcbe꓀ꋂꯄ꧆ꛈ뻊ꏌ곎듐뻒냔맖귘꣚꧞軠諢蛤苦裨藪菬胮蓰鷲雴鋶铸黺鏼课栀渂甄栆笈缊砌明㸐攒稔縖稘縚簜焞传䰢値䤦䨨个䀬䨮弰䜲䀴䌶倸场吼䬾⡀♂㙄楆ㅈ⩊⁌⍎", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0001015C File Offset: 0x0000E35C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)307494912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_290;
				case 2:
				{
					num = (short)366208537;
					short num3 = num;
					num = (short)615835161;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1594228736;
						if (num != 0)
						{
						}
						num = (short)1574567936;
						short num4 = num;
						break;
					}
					}
					num = (short)702676993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_2A2;
				case 2:
					goto IL_193;
				case 3:
					goto IL_146;
				case 4:
					goto IL_200;
				case 5:
					goto IL_295;
				case 6:
					goto IL_2EC;
				case 7:
					goto IL_255;
				case 8:
					goto IL_2BA;
				case 9:
					goto IL_1F3;
				case 10:
					goto IL_122;
				case 11:
					goto IL_310;
				case 12:
					goto IL_2DF;
				case 13:
					goto IL_1C2;
				case 14:
					goto IL_115;
				case 15:
					goto IL_2C7;
				case 16:
					goto IL_17B;
				case 17:
					goto IL_20D;
				case 18:
					goto IL_1CF;
				case 19:
					goto IL_231;
				default:
					num = (short)1751252994;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_115:
			this.vaDownloadListView = (global::System.Windows.Controls.ListView)target;
			return;
			IL_122:
			this.btnBrowse = (global::System.Windows.Controls.Button)target;
			this.btnBrowse.Click += this.btnBrowse_Click;
			return;
			IL_146:
			num = (short)385548289;
			if (num != 0)
			{
			}
			this.OptionGrpBox = (global::System.Windows.Controls.GroupBox)target;
			return;
			IL_17B:
			((global::System.Windows.Controls.GridViewColumnHeader)target).Click += this.GridViewColumnHeader_Click;
			return;
			IL_193:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.btndownloadHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_1C2:
			this.vaDownloadProgressBar = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_1CF:
			this.btndownloadCancel = (global::System.Windows.Controls.Button)target;
			this.btndownloadCancel.Click += this.btndownloadCancel_Click;
			return;
			IL_1F3:
			this.txtboxdownloadPath = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_200:
			this.lblSelectionTitle = (global::System.Windows.Controls.Label)target;
			return;
			IL_20D:
			this.btndownload = (global::System.Windows.Controls.Button)target;
			this.btndownload.Click += this.btndownload_Click;
			return;
			IL_231:
			this.btndownloadHelp = (global::System.Windows.Controls.Button)target;
			this.btndownloadHelp.Click += this.btndownloadHelp_Click;
			return;
			IL_255:
			this.btnDownloadUnSelectAll = (global::System.Windows.Controls.Button)target;
			this.btnDownloadUnSelectAll.Click += this.btnDownloadUnSelectAll_Click;
			return;
			IL_290:
			this.g = true;
			return;
			IL_295:
			this.voiceAnnDownloadList = (global::System.Windows.Controls.ListView)target;
			return;
			IL_2A2:
			((global::SpecialFeatures.VoiceAnnouncements.VoiceAnnouncementUtilities)target).Loaded += this.OnLoaded;
			return;
			IL_2BA:
			this.lblSelectdownloadPath = (global::System.Windows.Controls.Label)target;
			return;
			IL_2C7:
			((global::System.Windows.Controls.GridViewColumnHeader)target).Click += this.GridViewColumnHeader_Click;
			return;
			IL_2DF:
			this.vaExpanderHeaderPanel = (global::System.Windows.Controls.DockPanel)target;
			return;
			IL_2EC:
			this.btnDownloadSelectAll = (global::System.Windows.Controls.Button)target;
			this.btnDownloadSelectAll.Click += this.btnDownloadSelectAll_Click;
			return;
			IL_310:
			this.vaDownloadLogExpander = (global::System.Windows.Controls.Expander)target;
			this.vaDownloadLogExpander.Expanded += this.vaDownloadLogExpander_Expanded;
			this.vaDownloadLogExpander.Collapsed += this.vaDownloadLogExpander_Collapsed;
		}

		// Token: 0x04000043 RID: 67
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate a;

		// Token: 0x04000044 RID: 68
		private global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> b;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Window c;

		// Token: 0x04000046 RID: 70
		private bool d;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Controls.SelectionMode e;

		// Token: 0x04000048 RID: 72
		private global::SpecialFeatures.SpecialFeaturesSettings f;

		// Token: 0x04000049 RID: 73
		internal global::System.Windows.Controls.GroupBox OptionGrpBox;

		// Token: 0x0400004A RID: 74
		internal global::System.Windows.Controls.Label lblSelectionTitle;

		// Token: 0x0400004B RID: 75
		internal global::System.Windows.Controls.ListView voiceAnnDownloadList;

		// Token: 0x0400004C RID: 76
		internal global::System.Windows.Controls.Button btnDownloadSelectAll;

		// Token: 0x0400004D RID: 77
		internal global::System.Windows.Controls.Button btnDownloadUnSelectAll;

		// Token: 0x0400004E RID: 78
		internal global::System.Windows.Controls.Label lblSelectdownloadPath;

		// Token: 0x0400004F RID: 79
		internal global::System.Windows.Controls.TextBox txtboxdownloadPath;

		// Token: 0x04000050 RID: 80
		internal global::System.Windows.Controls.Button btnBrowse;

		// Token: 0x04000051 RID: 81
		internal global::System.Windows.Controls.Expander vaDownloadLogExpander;

		// Token: 0x04000052 RID: 82
		internal global::System.Windows.Controls.DockPanel vaExpanderHeaderPanel;

		// Token: 0x04000053 RID: 83
		internal global::System.Windows.Controls.ProgressBar vaDownloadProgressBar;

		// Token: 0x04000054 RID: 84
		internal global::System.Windows.Controls.ListView vaDownloadListView;

		// Token: 0x04000055 RID: 85
		internal global::System.Windows.Controls.Button btndownload;

		// Token: 0x04000056 RID: 86
		internal global::System.Windows.Controls.Button btndownloadCancel;

		// Token: 0x04000057 RID: 87
		internal global::System.Windows.Controls.Button btndownloadHelp;

		// Token: 0x04000058 RID: 88
		private bool g;

		// Token: 0x02000016 RID: 22
		private class ConvertResult
		{
			// Token: 0x06000088 RID: 136 RVA: 0x0000263A File Offset: 0x0000083A
			internal ConvertResult(string fileName, global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes code)
			{
				this.a = fileName;
				this.b = code;
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000089 RID: 137 RVA: 0x000104BC File Offset: 0x0000E6BC
			public string FileName
			{
				get
				{
					short num = (short)1449053956;
					short num2 = num;
					num = (short)1831915268;
					switch (num2 == num)
					{
					}
					num = (short)1687420929;
					if (num != 0)
					{
					}
					num = (short)27197440;
					if (num != 0)
					{
					}
					num = (short)1150156800;
					short num3 = num;
					return this.a;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00010570 File Offset: 0x0000E770
			public string ShortFileName
			{
				get
				{
					short num;
					string result;
					try
					{
						num = (short)76988357;
						short num2 = num;
						num = (short)560906181;
						switch (num2 == num)
						{
						}
						num = (short)419037184;
						if (num != 0)
						{
						}
						result = new global::System.IO.FileInfo(this.a).Name;
					}
					catch (global::System.Exception)
					{
						result = "";
					}
					num = (short)1454440449;
					if (num != 0)
					{
					}
					num = (short)1335033856;
					short num3 = num;
					return result;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00010644 File Offset: 0x0000E844
			public string Status
			{
				get
				{
					short num = (short)1126694912;
					short num2 = num;
					num = (short)2074738690;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_109;
						case 1:
							goto IL_83;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_67;
							}
							continue;
						case 3:
							goto IL_BB;
						case 4:
							if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_VOICE_FILE_ALREADY_EXISTS)
							{
								num = (short)1456799744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)654508037;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR)
							{
								num = (short)1422262275;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)672697708;
							short num4 = num;
							num = (short)45845868;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_166;
							}
							break;
						}
						}
						IL_67:
						if (this.b == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
						{
							num = (short)596115457;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)373751812;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					IL_83:
					return global::CommonResources.AppResources.Success_Id;
					IL_BB:
					return global::CommonResources.AppResources.Failed_Unable_to_generate_output_mva_file;
					IL_109:
					num = (short)1617100801;
					if (num != 0)
					{
					}
					return global::CommonResources.AppResources.Voice_Announcement_Already_Exists;
					IL_166:
					num = (short)397213696;
					if (num != 0)
					{
					}
					return global::CommonResources.AppResources.Failed_Id;
				}
			}

			// Token: 0x04000059 RID: 89
			private string a;

			// Token: 0x0400005A RID: 90
			private global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes b;
		}
	}
}
