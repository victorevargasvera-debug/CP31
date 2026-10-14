using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml.Serialization;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x0200009D RID: 157
	public partial class POP25BatchProgrammerRadioList : Window, INotifyPropertyChanged
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x000D1920 File Offset: 0x000CFB20
		public ObservableCollection<POP25BatchProgrammerRadioList.RadioInfo> DataSource
		{
			get
			{
				short num = (short)1608253440;
				short num2 = num;
				num = (short)62513681;
				short num3 = num;
				num = (short)133292561;
				switch (num3 == num)
				{
				}
				num = (short)130285568;
				if (num != 0)
				{
				}
				num = (short)66453505;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000D19CC File Offset: 0x000CFBCC
		public POP25BatchProgrammerRadioList()
		{
			int a_ = 8;
			this.a = "";
			this.b = new SpecialFeaturesSettings();
			this.c = new XmlSerializer(typeof(POP25BatchProgrammerRadioList.RadioList));
			this.d = new POP25BatchProgrammerRadioList.RadioList();
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.txtboxRadioListFilePath.Text = this.a();
			this.a(this.a);
			base.DataContext = this;
			this.DataSource.CollectionChanged += this.DataSource_CollectionChanged;
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(RptMgrErrorHandler.b("ﾌ", a_)))
			{
				this.txtboxRadioListFilePath.FlowDirection = System.Windows.FlowDirection.LeftToRight;
				this.txtboxRadioListFilePath.TextAlignment = TextAlignment.Right;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000D1AAC File Offset: 0x000CFCAC
		private void btnDone_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1153826816;
			short num2 = num;
			num = (short)1268601611;
			short num3 = num;
			num = (short)2090619659;
			switch (num3 == num)
			{
			}
			num = (short)1909522433;
			if (num != 0)
			{
			}
			num = (short)468385792;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000D1B5C File Offset: 0x000CFD5C
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1625751552;
			short num2 = num;
			num = (short)1669683711;
			short num3 = num;
			num = (short)1017534975;
			switch (num3 == num)
			{
			}
			num = (short)948961280;
			if (num != 0)
			{
			}
			num = (short)331087873;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000D1C0C File Offset: 0x000CFE0C
		private void btnRadioListHelp_click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)182385131;
				short num2 = num;
				num = (short)1696659947;
				switch (num2 == num)
				{
				}
				num = (short)282460160;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("궍ꎏꖑﺗ蓮ꮛꢝ", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1979056128;
			short num3 = num;
			num = (short)1804468225;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000D1CEC File Offset: 0x000CFEEC
		private void btndelete_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1021444096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1459421187;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_3C9;
					case 1:
					{
						if (num3 >= this.dgRadioList.SelectedItems.Count)
						{
							num = (short)901251074;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)616356145;
						short num4 = num;
						num = (short)1678039345;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A0;
						default:
						{
							num = (short)1553661952;
							if (num != 0)
							{
							}
							POP25BatchProgrammerRadioList.RadioInfo radioInfo = new POP25BatchProgrammerRadioList.RadioInfo();
							num = (short)1258094596;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						ArrayList arrayList;
						IEnumerator enumerator = arrayList.GetEnumerator();
						num = (short)904396806;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 4:
					{
						POP25BatchProgrammerRadioList.RadioInfo radioInfo;
						if (this.dgRadioList.SelectedItems[num3].GetType() == radioInfo.GetType())
						{
							num = (short)1121320972;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3C9;
					}
					case 5:
						num = (short)963051533;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1857486848;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F6;
									}
									continue;
								case 2:
									goto IL_17A;
								case 3:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1856569348;
										num2 = (int)((IntPtr)num);
										continue;
									}
									POP25BatchProgrammerRadioList.RadioInfo item = (POP25BatchProgrammerRadioList.RadioInfo)enumerator.Current;
									this.DataSource.Remove(item);
									num = (short)1434714113;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1377304578;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_12A:
								num = (short)1686568963;
								num2 = (int)((IntPtr)num);
								continue;
								IL_F6:
								goto IL_12A;
							}
							IL_17A:
							goto IL_498;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_19C;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_189:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)963706881;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1F2;
								case 1:
									disposable.Dispose();
									num = (short)1172111362;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_1F0;
								}
								goto IL_19C;
							}
							IL_1F0:
							IL_1F2:
							goto EndFinally_9;
							IL_19C:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)778108928;
							num2 = (int)((IntPtr)num);
							goto IL_189;
							EndFinally_9:;
						}
						goto IL_1F3;
					case 7:
						goto IL_339;
					case 8:
						num = (short)814546945;
						if (num != 0)
						{
						}
						goto IL_1F3;
					case 9:
						goto IL_1F3;
					case 10:
						if (System.Windows.MessageBox.Show(AppResources.Are_You_Sure_Remove_Selected_Radio_From_List, AppResources.Confirm_Deleting, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						{
							num = (short)664535051;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						ArrayList arrayList = new ArrayList();
						num3 = 0;
						num = (short)1575157768;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
					{
						ArrayList arrayList;
						arrayList.Add(this.dgRadioList.SelectedItems[num3]);
						num = (short)1933180928;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 13:
						if (this.dgRadioList.SelectedIndex != this.dgRadioList.Items.Count - 1)
						{
							num = (short)1062535182;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_302;
					case 14:
						num = (short)1172766730;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8A;
					IL_A0:
					num = (short)1865089029;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8A:
					if (this.dgRadioList.SelectedItems.Count > 0)
					{
						goto IL_A0;
					}
					goto IL_302;
					IL_1F3:
					num = (short)1494810625;
					num2 = (int)((IntPtr)num);
					continue;
					IL_302:
					System.Windows.MessageBox.Show(AppResources.Please_Select_A_Radio_To_Deleted + RptMgrErrorHandler.b("ꚅ", a_));
					num = (short)1557004295;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3C9:
					num3++;
					num = (short)481034249;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_339:
				IL_498:
				num = (short)1991049216;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000D21CC File Offset: 0x000D03CC
		private void btnDeleteAll_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1962632398;
			short num2 = num;
			num = (short)328885454;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1242824704;
				if (num != 0)
				{
				}
				if (System.Windows.MessageBox.Show(AppResources.Are_You_Sure_Remove_All_Radios_From_List, AppResources.Confirm_Deleting, MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
				{
					return;
				}
				break;
			}
			num = (short)321847296;
			short num3 = num;
			num = (short)360644609;
			if (num != 0)
			{
			}
			this.DataSource.Clear();
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000D2298 File Offset: 0x000D0498
		private void btnSave_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (File.Exists(this.a))
					{
						num2 = (short)1340801039;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5A1;
				case 1:
				{
					num2 = (short)794296320;
					short num3 = num2;
					num2 = (short)939327499;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
					if (File.Exists(this.a))
					{
						num2 = (short)483196936;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_604;
				case 3:
					if (!string.IsNullOrEmpty(this.a))
					{
						num2 = (short)531300370;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Readonly, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num2 = (short)1378091020;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5BF;
				case 6:
					if ((File.GetAttributes(this.a) & FileAttributes.Hidden) == FileAttributes.Hidden)
					{
						num2 = (short)1660551169;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5A1;
				case 7:
					if ((File.GetAttributes(this.a) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						num2 = (short)160563213;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_604;
				case 8:
					num2 = (short)33226759;
					num = (int)((IntPtr)num2);
					continue;
				case 9:
					if (this.a == AppResources.Please_Select_Radio_List_Location)
					{
						num2 = (short)1281687571;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_55E;
				case 10:
					goto IL_5BF;
				case 11:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Hidden, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num2 = (short)1540554768;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5BF;
				case 12:
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Is_Read_Only);
					num2 = (short)973144081;
					num = (int)((IntPtr)num2);
					continue;
				case 13:
					num2 = (short)1641938949;
					num = (int)((IntPtr)num2);
					continue;
				case 14:
					try
					{
						num2 = (short)480648653;
						short num4 = num2;
						num2 = (short)281550285;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_468:
							if (System.Windows.MessageBox.Show(AppResources.Fix_Delete_The_Invalid_Entries_Before_Saving_The_File, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) != MessageBoxResult.OK)
							{
								goto IL_4ED;
							}
							num2 = (short)1948516367;
							num = (int)((IntPtr)num2);
							break;
						default:
							num2 = (short)1913126913;
							if (num2 != 0)
							{
							}
							num2 = (short)454557696;
							if (num2 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_243;
							}
							break;
						}
						int num5;
						for (;;)
						{
							IL_1F1:
							switch (num)
							{
							case 0:
								num2 = (short)1226506249;
								num = (int)((IntPtr)num2);
								continue;
							case 1:
								goto IL_328;
							case 2:
								goto IL_2E1;
							case 3:
								goto IL_2E6;
							case 4:
								if (num5 >= this.d.Count)
								{
									num2 = (short)311164945;
									num = (int)((IntPtr)num2);
									continue;
								}
								num2 = (short)1495072774;
								num = (int)((IntPtr)num2);
								continue;
							case 5:
								goto IL_3E3;
							case 6:
								if (this.d[num5].Radio_ID_Valid)
								{
									num2 = (short)1106575372;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_3E3;
							case 7:
								goto IL_323;
							case 8:
								goto IL_328;
							case 9:
								if (!this.a.EndsWith(RptMgrErrorHandler.b("ꊋﶏﺑ", a_)))
								{
									num2 = (short)1163460619;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_2E6;
							case 10:
								goto IL_468;
							case 11:
								this.a += RptMgrErrorHandler.b("ꊋﶏﺑ", a_);
								num2 = (short)1677656067;
								num = (int)((IntPtr)num2);
								continue;
							case 12:
								num2 = (short)455213074;
								num = (int)((IntPtr)num2);
								continue;
							case 13:
								if (!this.f)
								{
									num2 = (short)1103888384;
									num = (int)((IntPtr)num2);
									continue;
								}
								num2 = (short)1755447306;
								num = (int)((IntPtr)num2);
								continue;
							case 14:
								goto IL_369;
							case 15:
								num2 = (short)1129709570;
								num = (int)((IntPtr)num2);
								continue;
							case 16:
								goto IL_515;
							case 17:
								goto IL_369;
							case 18:
								if (!this.d[num5].Radio_IP_Valid)
								{
									num2 = (short)69730309;
									num = (int)((IntPtr)num2);
									continue;
								}
								this.f = false;
								num5++;
								num2 = (short)298254337;
								num = (int)((IntPtr)num2);
								continue;
							}
							goto IL_243;
							IL_2E6:
							TextWriter textWriter = new StreamWriter(this.a);
							this.c.Serialize(textWriter, this.d);
							textWriter.Close();
							num2 = (short)1622867975;
							num = (int)((IntPtr)num2);
							continue;
							IL_328:
							num2 = (short)2145845252;
							num = (int)((IntPtr)num2);
							continue;
							IL_369:
							num2 = (short)656867341;
							num = (int)((IntPtr)num2);
							continue;
							IL_3E3:
							this.f = true;
							num2 = (short)1312817166;
							num = (int)((IntPtr)num2);
						}
						IL_2E1:
						return;
						IL_323:
						goto IL_4ED;
						IL_515:
						goto IL_5BF;
						IL_243:
						num5 = 0;
						num2 = (short)692322312;
						num = (int)((IntPtr)num2);
						goto IL_1F1;
						IL_4ED:
						this.txtboxRadioListFilePath.Text = this.a;
						num2 = (short)889585680;
						num = (int)((IntPtr)num2);
						goto IL_1F1;
					}
					catch (Exception ex)
					{
						if (System.Windows.MessageBox.Show(ex.Message, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Without_Excalmatory + RptMgrErrorHandler.b("겋", a_) + this.a);
						}
						goto IL_5BF;
					}
					goto IL_55E;
				case 15:
					num2 = (short)928972806;
					num = (int)((IntPtr)num2);
					continue;
				case 16:
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_saving_Radio_List_File_Is_Hidden);
					num2 = (short)707067914;
					num = (int)((IntPtr)num2);
					continue;
				case 17:
					goto IL_5BF;
				case 18:
					num2 = (short)1554644994;
					num = (int)((IntPtr)num2);
					continue;
				case 19:
					goto IL_BB;
				}
				goto IL_69;
				IL_55E:
				num2 = (short)327221251;
				num = (int)((IntPtr)num2);
				continue;
				IL_5A1:
				num2 = (short)1636171790;
				num = (int)((IntPtr)num2);
				continue;
				IL_5BF:
				this.b.OTAP_BATCH_RADIO_LIST_LOCATION = this.txtboxRadioListFilePath.Text;
				this.b.Save();
				this.e = false;
				num2 = (short)1328414724;
				num = (int)((IntPtr)num2);
				continue;
				IL_604:
				num2 = (short)493879296;
				num = (int)((IntPtr)num2);
			}
			IL_BB:
			this.btnSaveAs_Click(A_0, A_1);
			return;
			IL_69:
			this.a = this.txtboxRadioListFilePath.Text;
			num2 = (short)1986396169;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000D2A44 File Offset: 0x000D0C44
		private void btnSaveAs_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1934098432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				SaveFileDialog saveFileDialog;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						string fileName;
						if (File.Exists(fileName))
						{
							num = (short)1868038159;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E8;
					}
					case 1:
						goto IL_6CD;
					case 2:
					{
						string fileName;
						if ((File.GetAttributes(fileName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
						{
							num = (short)2009792520;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_268;
					}
					case 3:
					{
						string fileName;
						if (File.Exists(fileName))
						{
							num = (short)629538834;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_268;
					}
					case 4:
						goto IL_263;
					case 5:
					{
						string fileName;
						if (!string.IsNullOrEmpty(fileName))
						{
							num = (short)1013645324;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_79D;
					}
					case 6:
					{
						string fileName;
						if ((File.GetAttributes(fileName) & FileAttributes.Hidden) == FileAttributes.Hidden)
						{
							num = (short)1583939585;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E8;
					}
					case 7:
						if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Readonly, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)521666573;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_221;
					case 8:
						num = (short)742064135;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							num = (short)1803747347;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_79D;
					case 10:
						try
						{
							num = (short)1461304067;
							short num3 = num;
							num = (short)690141955;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_5D5:
								if (this.a.EndsWith(RptMgrErrorHandler.b("뺏煉歹", a_)))
								{
									goto IL_46D;
								}
								num = (short)140443663;
								num2 = (int)((IntPtr)num);
								break;
							default:
								num = (short)1206648832;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_39F;
								}
								break;
							}
							int num4;
							for (;;)
							{
								IL_34C:
								switch (num2)
								{
								case 0:
									if (num4 >= this.d.Count)
									{
										num = (short)751304707;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)1802633222;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_3BC;
								case 2:
									goto IL_4F0;
								case 3:
									goto IL_4AE;
								case 4:
									goto IL_65B;
								case 5:
									if (!this.d[num4].Radio_IP_Valid)
									{
										num = (short)41746433;
										num2 = (int)((IntPtr)num);
										continue;
									}
									this.f = false;
									num4++;
									num = (short)605749250;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									if (this.d[num4].Radio_ID_Valid)
									{
										num = (short)635437068;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3BC;
								case 7:
									goto IL_468;
								case 8:
									goto IL_4F0;
								case 9:
									if (System.Windows.MessageBox.Show(AppResources.Fix_Delete_The_Invalid_Entries_Before_Saving_The_File, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
									{
										num = (short)448462859;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_65B;
								case 10:
									goto IL_5D5;
								case 11:
									num = (short)1548419079;
									num2 = (int)((IntPtr)num);
									continue;
								case 12:
									num = (short)1749811205;
									num2 = (int)((IntPtr)num);
									continue;
								case 13:
									num = (short)449511434;
									num2 = (int)((IntPtr)num);
									continue;
								case 14:
									goto IL_56C;
								case 15:
									this.a += RptMgrErrorHandler.b("뺏煉歹", a_);
									num = (short)214433806;
									num2 = (int)((IntPtr)num);
									continue;
								case 16:
									goto IL_686;
								case 17:
									if (!this.f)
									{
										num = (short)878379021;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)753926153;
									num2 = (int)((IntPtr)num);
									continue;
								case 18:
									goto IL_4AE;
								}
								goto IL_39F;
								IL_3BC:
								this.f = true;
								num = (short)1095827474;
								num2 = (int)((IntPtr)num);
								continue;
								IL_4AE:
								num = (short)981401617;
								num2 = (int)((IntPtr)num);
								continue;
								IL_4F0:
								num = (short)370802688;
								num2 = (int)((IntPtr)num);
								continue;
								IL_65B:
								this.txtboxRadioListFilePath.Text = this.a;
								num = (short)1069613072;
								num2 = (int)((IntPtr)num);
							}
							IL_468:
							goto IL_79D;
							IL_56C:
							goto IL_46D;
							IL_686:
							goto IL_221;
							IL_39F:
							num4 = 0;
							num = (short)1968373768;
							num2 = (int)((IntPtr)num);
							goto IL_34C;
							IL_46D:
							TextWriter textWriter = new StreamWriter(this.a);
							this.c.Serialize(textWriter, this.d);
							textWriter.Close();
							num = (short)978780164;
							num2 = (int)((IntPtr)num);
							goto IL_34C;
						}
						catch (Exception ex)
						{
							if (System.Windows.MessageBox.Show(ex.Message, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
							{
								string fileName;
								AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Without_Excalmatory + RptMgrErrorHandler.b("낏", a_) + fileName);
							}
							goto IL_221;
						}
						goto IL_6CD;
					case 11:
						if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Hidden, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)1391263760;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_221;
					case 12:
						num = (short)558825475;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Is_Read_Only);
						num = (short)569704465;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						goto IL_221;
					case 15:
						num = (short)1845559302;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_saving_Radio_List_File_Is_Hidden);
						num = (short)707067918;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						goto IL_221;
					case 18:
						num = (short)1675624449;
						if (num != 0)
						{
						}
						num = (short)1435697154;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
					{
						this.a = saveFileDialog.FileName;
						string fileName = saveFileDialog.FileName;
						num = (short)944832517;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_88;
					IL_E8:
					num = (short)1371275274;
					num2 = (int)((IntPtr)num);
					continue;
					IL_221:
					this.b.OTAP_BATCH_RADIO_LIST_LOCATION = this.txtboxRadioListFilePath.Text;
					this.b.Save();
					this.e = false;
					num = (short)913506308;
					num2 = (int)((IntPtr)num);
					continue;
					IL_268:
					num = (short)1754923008;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6CD:
					num = (short)1394606091;
					num2 = (int)((IntPtr)num);
				}
				IL_263:
				IL_79D:
				num = (short)1762394112;
				short num5 = num;
				return;
				IL_88:
				saveFileDialog = new SaveFileDialog();
				saveFileDialog.InitialDirectory = this.a;
				saveFileDialog.Filter = AppResources.Radio_List_Without_Mark_Filter;
				num = (short)274071561;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000D3234 File Offset: 0x000D1434
		private void btnCancel_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1696384977;
			short num2 = num;
			num = (short)910608337;
			switch (num2 == num)
			{
			}
			num = (short)1624571904;
			short num3 = num;
			num = (short)138936321;
			if (num != 0)
			{
			}
			num = (short)1892352000;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000D32E4 File Offset: 0x000D14E4
		private string a()
		{
			int a_ = 3;
			short num = (short)718995461;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				IL_27:
				switch (num2)
				{
				case 0:
					if (!File.Exists(this.a))
					{
						num = (short)1215692802;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 1:
					this.a = this.b.OTAP_BATCH_RADIO_LIST_LOCATION;
					num = (short)1292500995;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					this.a = AppResources.Please_Select_Radio_List_Location;
					num = (short)684589060;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_19C;
				case 4:
					goto IL_10B;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				while (File.Exists(this.b.OTAP_BATCH_RADIO_LIST_LOCATION))
				{
					num = (short)725678749;
					short num3 = num;
					num = (short)1746336413;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)598212608;
						short num4 = num;
						break;
					}
					}
					num = (short)528416768;
					if (num != 0)
					{
					}
					num = (short)984743937;
					num2 = (int)((IntPtr)num);
					goto IL_27;
				}
				this.a = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), RptMgrErrorHandler.b("쮅ﺉﲍﾏﺑ쪕\ud997\ud89d솟쾡춣쪥톧ﲫﶭ\udbb3\udbb5햷햹튻芿ꏁ냃ꗅꃇ雉黋꿍듏믑믓觕铗동꿛ꫝ컟髡解諥", a_));
				num = (short)2015494144;
				num2 = (int)((IntPtr)num);
			}
			IL_10B:
			IL_19C:
			IL_19E:
			num = (short)734461953;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000D34BC File Offset: 0x000D16BC
		private void btnRadioListFilePathBrowse_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			OpenFileDialog openFileDialog;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)1397227521;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1042349552;
					short num3 = num2;
					num2 = (short)1731657200;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1495990273;
						if (num2 != 0)
						{
						}
						num2 = (short)1459486720;
						if (num2 != 0)
						{
						}
						this.txtboxRadioListFilePath.Text = openFileDialog.FileName;
						this.a(this.txtboxRadioListFilePath.Text);
						num2 = (short)870055936;
						short num4 = num2;
						num2 = (short)811335682;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_15E;
				}
				goto IL_25;
			}
			return;
			IL_15E:
			this.b.OTAP_BATCH_RADIO_LIST_LOCATION = this.txtboxRadioListFilePath.Text;
			this.b.Save();
			return;
			IL_25:
			openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = this.a;
			openFileDialog.DefaultExt = RptMgrErrorHandler.b("ﺅ", a_);
			openFileDialog.Filter = AppResources.XML_Document_Filter;
			num2 = (short)766509056;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x000D364C File Offset: 0x000D184C
		private void a(string A_0)
		{
			int a_ = 2;
			short num;
			try
			{
				FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.d = (POP25BatchProgrammerRadioList.RadioList)this.c.Deserialize(fileStream);
				this.FirePropertyChanged(RptMgrErrorHandler.b("솄ﶈ\ude8c", a_));
				fileStream.Close();
			}
			catch (Exception ex)
			{
				if (File.Exists(this.a))
				{
					if (System.Windows.MessageBox.Show(ex.Message, AppResources.Invalid_XML_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						for (;;)
						{
							num = (short)1915668330;
							short num2 = num;
							num = (short)1635239786;
							switch ((num2 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_95;
							}
						}
						IL_95:
						num = (short)1738211329;
						if (num != 0)
						{
						}
						num = (short)1587412992;
						if (num != 0)
						{
						}
						if (this.DataSource.Count > 0)
						{
							this.DataSource.Clear();
						}
					}
				}
			}
			num = (short)929103872;
			short num3 = num;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000D37A0 File Offset: 0x000D19A0
		private void DataSource_CollectionChanged(object A_0, NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)652784466;
			short num2 = num;
			num = (short)1374466898;
			switch (num2 == num)
			{
			}
			num = (short)296878080;
			short num3 = num;
			num = (short)709951488;
			if (num != 0)
			{
			}
			num = (short)274137089;
			if (num != 0)
			{
			}
			this.e = true;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000D3854 File Offset: 0x000D1A54
		private void dgRadioList_CurrentCellChanged(object A_0, EventArgs A_1)
		{
			short num = (short)1515500017;
			short num2 = num;
			num = (short)1387573745;
			switch (num2 == num)
			{
			}
			num = (short)1257963520;
			short num3 = num;
			num = (short)153812993;
			if (num != 0)
			{
			}
			num = (short)1241710592;
			if (num != 0)
			{
			}
			this.e = true;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000D3904 File Offset: 0x000D1B04
		private void This_Closing(object A_0, CancelEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1482293248;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 1:
					A_1.Cancel = true;
					num = (short)1960509447;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					if (System.Windows.MessageBox.Show(AppResources.File_Must_Have_A_Xml_Extension, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num = (short)1397882896;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 3:
					goto IL_451;
				case 4:
					num = (short)1552744476;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					num = (short)690487310;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					if (this.a.EndsWith(RptMgrErrorHandler.b("ꢅ", a_)))
					{
						num = (short)655163396;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)745799682;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_167;
				case 8:
					A_1.Cancel = true;
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Is_Read_Only);
					num = (short)1902706710;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					if (this.a == AppResources.Please_Select_Radio_List_Location)
					{
						num = (short)1240596483;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)273809418;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					if (this.a != null)
					{
						num = (short)785907738;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 11:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Hidden, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num = (short)595722264;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 12:
					num = (short)1022820353;
					if (num != 0)
					{
					}
					num = (short)120127507;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Readonly, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num = (short)1445658632;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 14:
					if (System.Windows.MessageBox.Show(AppResources.Do_You_Want_To_Save_The_Radio_List, AppResources.Confirm_Saving, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
					{
						num = (short)79691776;
						short num3 = num;
						num = (short)1099300889;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 15:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_1BC;
						}
						int num4;
						for (;;)
						{
							IL_176:
							switch (num2)
							{
							case 0:
								if (System.Windows.MessageBox.Show(AppResources.Fix_The_Invalid_Entries_Before_Saving_File, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
								{
									num = (short)1692073999;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_3DD;
							case 1:
								if (this.d[num4].Radio_ID_Valid)
								{
									num = (short)410058755;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_241;
							case 2:
								if (!this.f)
								{
									num = (short)1189937166;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1290731520;
								num2 = (int)((IntPtr)num);
								continue;
							case 3:
								num = (short)1741619207;
								num2 = (int)((IntPtr)num);
								continue;
							case 4:
								goto IL_405;
							case 5:
								goto IL_2CE;
							case 6:
								goto IL_241;
							case 7:
								if (!this.d[num4].Radio_IP_Valid)
								{
									num = (short)1156644870;
									num2 = (int)((IntPtr)num);
									continue;
								}
								this.f = false;
								num4++;
								num = (short)2024472584;
								num2 = (int)((IntPtr)num);
								continue;
							case 8:
								goto IL_2CE;
							case 9:
								goto IL_358;
							case 10:
								goto IL_358;
							case 11:
								goto IL_3DD;
							case 12:
								goto IL_3DD;
							case 13:
								if (num4 >= this.d.Count)
								{
									num = (short)1776943114;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)489553921;
								num2 = (int)((IntPtr)num);
								continue;
							case 14:
							{
								TextWriter textWriter = new StreamWriter(this.a);
								this.c.Serialize(textWriter, this.d);
								textWriter.Close();
								num = (short)1463353356;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 15:
								A_1.Cancel = true;
								num = (short)1710293003;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_1BC;
							IL_241:
							this.f = true;
							num = (short)1157758985;
							num2 = (int)((IntPtr)num);
							continue;
							IL_2CE:
							num = (short)1247477773;
							num2 = (int)((IntPtr)num);
							continue;
							IL_358:
							num = (short)1970470914;
							num2 = (int)((IntPtr)num);
							continue;
							IL_3DD:
							this.txtboxRadioListFilePath.Text = this.a;
							num = (short)1696989188;
							num2 = (int)((IntPtr)num);
						}
						IL_405:
						goto IL_897;
						IL_1BC:
						num4 = 0;
						num = (short)1594687493;
						num2 = (int)((IntPtr)num);
						goto IL_176;
					}
					catch (Exception ex)
					{
						if (System.Windows.MessageBox.Show(ex.Message, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Without_Excalmatory + RptMgrErrorHandler.b("ꚅ", a_) + this.a);
						}
						goto IL_897;
					}
					goto IL_451;
				case 16:
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_Radio_List_File_Must_Have_Xml_Extension);
					num = (short)152895509;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					goto IL_81F;
				case 18:
					if (System.Windows.MessageBox.Show(AppResources.Please_Select_A_Valid_Xml_File_Or_Click_Save_As, AppResources.Error_Saving_Radio_List_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num = (short)532086785;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_897;
				case 19:
					if ((File.GetAttributes(this.a) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						num = (short)263913501;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_104;
				case 20:
					goto IL_FF;
				case 21:
					goto IL_614;
				case 22:
					goto IL_5AA;
				case 23:
					if (File.Exists(this.a))
					{
						num = (short)293863451;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7E8;
				case 24:
					A_1.Cancel = true;
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_saving_Radio_List_File_Is_Hidden);
					num = (short)320012308;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					this.a = this.txtboxRadioListFilePath.Text;
					num = (short)1566048265;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					num = (short)104267782;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
					num = (short)855834641;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					if (File.Exists(this.a))
					{
						num = (short)1980432396;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_104;
				case 29:
					num = (short)584712205;
					num2 = (int)((IntPtr)num);
					continue;
				case 30:
				{
					num = (short)1726398634;
					short num5 = num;
					num = (short)1926873258;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81F;
					default:
						num = (short)1283653632;
						if (num != 0)
						{
						}
						num = (short)1198194699;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_A9:
				if (this.e)
				{
					num = (short)600375301;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_104:
				num = (short)1476788247;
				num2 = (int)((IntPtr)num);
				continue;
				IL_451:
				num = (short)665452562;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7E8:
				num = (short)891420687;
				num2 = (int)((IntPtr)num);
				continue;
				IL_81F:
				if ((File.GetAttributes(this.a) & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					goto IL_7E8;
				}
				num = (short)1256128542;
				num2 = (int)((IntPtr)num);
			}
			IL_FF:
			IL_167:
			IL_5AA:
			IL_614:
			IL_897:
			this.b.OTAP_BATCH_RADIO_LIST_LOCATION = this.txtboxRadioListFilePath.Text;
			this.b.Save();
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000B16 RID: 2838 RVA: 0x000D41E8 File Offset: 0x000D23E8
		// (remove) Token: 0x06000B17 RID: 2839 RVA: 0x000D4320 File Offset: 0x000D2520
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1398145026;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 2:
						goto IL_D6;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.g, value2, propertyChangedEventHandler2);
					num2 = (short)972894680;
					short num3 = num2;
					num2 = (short)882651608;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
						num2 = (short)1363869696;
						if (num2 != 0)
						{
						}
						num2 = (short)37289985;
						num = (int)((IntPtr)num2);
						break;
					}
				}
				IL_D6:
				num2 = (short)358154241;
				if (num2 != 0)
				{
				}
				num2 = (short)1243086848;
				short num4 = num2;
				return;
				IL_1C:
				propertyChangedEventHandler = this.g;
				num2 = (short)589365248;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			[CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)2110521345;
					if (num != 0)
					{
					}
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num2)
					{
					case 0:
						goto IL_60;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)398852098;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_60;
					case 2:
						goto IL_FF;
					}
					goto IL_43;
					IL_60:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.g, value2, propertyChangedEventHandler2);
					num = (short)1187354324;
					short num3 = num;
					num = (short)2058000084;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43;
					default:
						num = (short)635961344;
						if (num != 0)
						{
						}
						num = (short)1781006337;
						num2 = (int)((IntPtr)num);
						break;
					}
				}
				IL_FF:
				num = (short)1105330176;
				short num4 = num;
				return;
				IL_43:
				propertyChangedEventHandler = this.g;
				num = (short)1846542336;
				num2 = (int)((IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000D4458 File Offset: 0x000D2658
		public void FirePropertyChanged(string name)
		{
			short num = (short)383713280;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)603127808;
				short num3 = num;
				num = (short)490088094;
				short num4 = num;
				num = (short)2088838814;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1429667840;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 1:
						this.g(this, new PropertyChangedEventArgs(name));
						num = (short)834142210;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_A4:
					num = (short)1198194689;
					if (num != 0)
					{
					}
					if (this.g == null)
					{
						return;
					}
					num = (short)799997953;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x040004AC RID: 1196
		private string a;

		// Token: 0x040004AD RID: 1197
		private SpecialFeaturesSettings b;

		// Token: 0x040004AE RID: 1198
		private XmlSerializer c;

		// Token: 0x040004AF RID: 1199
		private POP25BatchProgrammerRadioList.RadioList d;

		// Token: 0x040004B0 RID: 1200
		private bool e;

		// Token: 0x040004B1 RID: 1201
		private bool f;

		// Token: 0x040004B2 RID: 1202
		[CompilerGenerated]
		private PropertyChangedEventHandler g;

		// Token: 0x0200009E RID: 158
		[XmlType("Radio")]
		[Serializable]
		public class RadioInfo
		{
			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000D498C File Offset: 0x000D2B8C
			// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000D4A40 File Offset: 0x000D2C40
			public string Radio_ID
			{
				get
				{
					short num = (short)2015690753;
					if (num != 0)
					{
					}
					num = (short)524095708;
					short num2 = num;
					num = (short)1148457180;
					switch (num2 == num)
					{
					default:
					{
						num = (short)736952320;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1138884608;
					if (num != 0)
					{
					}
					return this.radio_id;
				}
				set
				{
					short num = (short)587556734;
					short num2 = num;
					num = (short)1971677054;
					int num3;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_13F:
						num = (short)1388314630;
						num3 = (int)((IntPtr)num);
						break;
					default:
						num = (short)193069056;
						if (num != 0)
						{
						}
						num = (short)1431175169;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						break;
					}
					int num4;
					int num5;
					for (;;)
					{
						IL_7B:
						switch (num3)
						{
						case 0:
							if (num4 >= num5)
							{
								num = (short)1943601160;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_169;
						case 1:
							if (string.IsNullOrEmpty(this.radio_id))
							{
								num = (short)316997637;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)419430402;
							num3 = (int)((IntPtr)num);
							continue;
						case 2:
							if (!int.TryParse(value, out num4))
							{
								num = (short)1436745735;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)873463808;
							num3 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_188;
						case 4:
							goto IL_138;
						case 5:
							goto IL_F4;
						case 6:
							goto IL_169;
						case 7:
							goto IL_1C3;
						case 8:
						{
							num = (short)541786112;
							short num6 = num;
							num = (short)1637810180;
							num3 = (int)((IntPtr)num);
							continue;
						}
						}
						goto IL_A5;
						IL_169:
						this.Radio_ID_Valid = false;
						num = (short)234291203;
						num3 = (int)((IntPtr)num);
					}
					IL_F4:
					this.Radio_ID_Valid = true;
					return;
					IL_138:
					int num7;
					if (num4 > num7)
					{
						goto IL_13F;
					}
					IL_188:
					return;
					IL_1C3:
					this.Radio_ID_Valid = false;
					return;
					IL_A5:
					this.radio_id = value;
					num5 = 1;
					num7 = 16777211;
					this.Radio_ID_Valid = true;
					num = (short)815071233;
					num3 = (int)((IntPtr)num);
					goto IL_7B;
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000D4C4C File Offset: 0x000D2E4C
			// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000D4CFC File Offset: 0x000D2EFC
			public string Radio_IP
			{
				get
				{
					short num = (short)1759660926;
					short num2 = num;
					num = (short)1942768510;
					switch (num2 == num)
					{
					}
					num = (short)1411121152;
					short num3 = num;
					num = (short)1520828416;
					if (num != 0)
					{
					}
					num = (short)1270153217;
					if (num != 0)
					{
					}
					return this.radio_ip;
				}
				set
				{
					short num = (short)2144141312;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						num = (short)494469121;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						for (;;)
						{
							IL_4D:
							switch (num2)
							{
							case 0:
							{
								if (string.IsNullOrEmpty(this.radio_ip))
								{
									num = (short)107610120;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1578893312;
								short num3 = num;
								string[] array = value.Split(new char[]
								{
									'.'
								});
								num = (short)2142175241;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 1:
							{
								int num4;
								if (num4 > 255)
								{
									num = (short)2004811778;
									num2 = (int)((IntPtr)num);
									continue;
								}
								int num5;
								num5++;
								num = (short)1031667727;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 2:
								goto IL_16B;
							case 3:
								num = (short)688062465;
								num2 = (int)((IntPtr)num);
								continue;
							case 4:
								goto IL_216;
							case 5:
								goto IL_259;
							case 6:
								goto IL_305;
							case 7:
							{
								string[] array;
								string[] array2 = array;
								int num5 = 0;
								num = (short)1606025221;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 8:
								goto IL_E2;
							case 9:
							{
								string[] array;
								if (array.Length != 4)
								{
									num = (short)933953540;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)938868748;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 10:
							{
								int num4;
								int num5;
								string[] array2;
								if (!int.TryParse(array2[num5], out num4))
								{
									num = (short)1229914118;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1258618894;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 11:
							{
								int num5;
								string[] array2;
								if (num5 >= array2.Length)
								{
									num = (short)1479802893;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1107951626;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 12:
								if (this.Radio_IP_Valid)
								{
									num = (short)951517191;
									num2 = (int)((IntPtr)num);
									continue;
								}
								return;
							case 13:
								goto IL_291;
							case 14:
							{
								int num4;
								if (num4 >= 0)
								{
									num = (short)560988163;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_2BD;
							}
							case 15:
								goto IL_259;
							}
							goto IL_94;
							IL_259:
							num = (short)230424587;
							num2 = (int)((IntPtr)num);
						}
						IL_E2:
						num = (short)2034393;
						short num6 = num;
						num = (short)2081950425;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_305:
							this.Radio_IP_Valid = false;
							return;
						default:
							num = (short)631504896;
							if (num != 0)
							{
							}
							this.Radio_IP_Valid = true;
							return;
						}
						IL_16B:
						goto IL_2BD;
						IL_216:
						this.Radio_IP_Valid = false;
						return;
						IL_291:
						return;
						IL_2BD:
						this.Radio_IP_Valid = false;
						return;
						IL_94:
						this.radio_ip = value;
						this.Radio_IP_Valid = true;
						num = (short)1672478720;
						num2 = (int)((IntPtr)num);
						goto IL_4D;
					}
					}
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000D5054 File Offset: 0x000D3254
			// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000D5104 File Offset: 0x000D3304
			[XmlIgnore]
			public bool Radio_ID_Valid
			{
				get
				{
					short num = (short)1366753280;
					short num2 = num;
					num = (short)852681709;
					short num3 = num;
					num = (short)1085400045;
					switch (num3 == num)
					{
					}
					num = (short)109903873;
					if (num != 0)
					{
					}
					num = (short)1712193536;
					if (num != 0)
					{
					}
					return this.radio_id_valid;
				}
				set
				{
					short num = (short)139919360;
					short num2 = num;
					num = (short)1312214655;
					short num3 = num;
					num = (short)1671089791;
					switch (num3 == num)
					{
					}
					num = (short)931266560;
					if (num != 0)
					{
					}
					num = (short)1126498305;
					if (num != 0)
					{
					}
					this.radio_id_valid = value;
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000D51B8 File Offset: 0x000D33B8
			// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000D5268 File Offset: 0x000D3468
			[XmlIgnore]
			public bool Radio_IP_Valid
			{
				get
				{
					short num = (short)1288363067;
					short num2 = num;
					num = (short)1566563387;
					switch (num2 == num)
					{
					}
					num = (short)1359413249;
					if (num != 0)
					{
					}
					num = (short)135462912;
					if (num != 0)
					{
					}
					num = (short)112525312;
					short num3 = num;
					return this.radio_ip_valid;
				}
				set
				{
					short num = (short)2336817;
					short num2 = num;
					num = (short)265922609;
					switch (num2 == num)
					{
					}
					num = (short)1517420545;
					if (num != 0)
					{
					}
					num = (short)873594880;
					if (num != 0)
					{
					}
					num = (short)1541734400;
					short num3 = num;
					this.radio_ip_valid = value;
				}
			}

			// Token: 0x040004C2 RID: 1218
			private string radio_id;

			// Token: 0x040004C3 RID: 1219
			private string radio_ip;

			// Token: 0x040004C4 RID: 1220
			private bool radio_id_valid = true;

			// Token: 0x040004C5 RID: 1221
			private bool radio_ip_valid = true;
		}

		// Token: 0x0200009F RID: 159
		[XmlType("RadioList_Table")]
		[Serializable]
		public class RadioList : ObservableCollection<POP25BatchProgrammerRadioList.RadioInfo>
		{
		}
	}
}
