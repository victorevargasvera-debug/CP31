using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using SpecialFeatures.AcpXMLCoreEngineLib;
using SpecialFeatures.Utilites;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x02000241 RID: 577
	public partial class PageCustomPrintSelection : PageFunction<string>
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x00003FCA File Offset: 0x000021CA
		internal PageCustomPrintSelection()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00281918 File Offset: 0x0027FB18
		public override void OnApplyTemplate()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			Style style;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_5A;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1478764468;
					short num3 = num2;
					num2 = (short)897984436;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
					{
						num2 = (short)1320091648;
						if (num2 != 0)
						{
						}
						num2 = (short)46858241;
						if (num2 != 0)
						{
						}
						num2 = (short)2050424832;
						short num4 = num2;
						Style itemContainerStyle = new Style(typeof(System.Windows.Controls.ListViewItem), style);
						this.lstUIValue.ItemContainerStyle = itemContainerStyle;
						num2 = (short)631570433;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_25;
				IL_5A:
				if (style == null)
				{
					break;
				}
				num2 = (short)1624506370;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_25:
			base.OnApplyTemplate();
			style = (Style)base.TryFindResource(RptMgrErrorHandler.b("\ud893ﾕ쪛얟햡튥춧잩솭\udeaf욱톳\ud8b5첷좻잽겿ꟁ", a_));
			num2 = (short)331546624;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00281A70 File Offset: 0x0027FC70
		public void InitializeData(object sender, EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_87;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1284391524;
					short num3 = num2;
					num2 = (short)42877540;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
					{
						num2 = (short)788791296;
						if (num2 != 0)
						{
						}
						num2 = (short)1316290560;
						short num4 = num2;
						Keyboard.Focus(this);
						num2 = (short)1457127425;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_87:
				if (base.IsKeyboardFocusWithin)
				{
					break;
				}
				num2 = (short)849346562;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)1261174785;
			if (num2 != 0)
			{
			}
			this.a();
			this.btnPrtUnSelectAll.IsEnabled = false;
			this.radBtnFeatures.IsChecked = new bool?(true);
			this.a.Clear();
			num2 = (short)1944518656;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00281BC0 File Offset: 0x0027FDC0
		private void a()
		{
			int a_ = 12;
			short num = (short)1288896512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num3;
				BitmapImage bitmapImage;
				string text;
				string text2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_C1;
						case 1:
							if (num3 > 0)
							{
								num = (short)1046413317;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_22F;
						case 2:
							bitmapImage.BeginInit();
							bitmapImage.UriSource = new Uri(text);
							bitmapImage.EndInit();
							this.imgMotologo.Source = bitmapImage;
							num = (short)237305860;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							if (File.Exists(text))
							{
								num = (short)1819082754;
								num2 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 4:
							return;
						case 5:
						{
							num = (short)344653824;
							short num4 = num;
							text2 = text2.Substring(0, num3);
							num = (short)1644232711;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 6:
							text = text2 + RptMgrErrorHandler.b("ﶎ杖솜철슢스슦쎪좬캮햰횲잴쾸\udeba쾼쮾꓀믂跆駈賊", a_);
							num = (short)1447690249;
							num2 = (int)((IntPtr)num);
							continue;
						case 7:
						{
							num = (short)1588840947;
							short num5 = num;
							num = (short)834259443;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_88;
							default:
								num = (short)1961230336;
								if (num != 0)
								{
								}
								goto IL_22F;
							}
							break;
						}
						case 8:
							if (VersionInfoHelper.IsDFlagExisted(DFlagType.DASTRO))
							{
								num = (short)579534854;
								num2 = (int)((IntPtr)num);
								continue;
							}
							text = text2 + RptMgrErrorHandler.b("ﶎ杖솜철슢스슦쎪좬캮햰횲잴馶謁", a_);
							num = (short)1643642880;
							num2 = (int)((IntPtr)num);
							continue;
						case 9:
							num = (short)1377173505;
							if (num != 0)
							{
							}
							goto IL_C1;
						}
						goto IL_60;
						IL_C1:
						num = (short)109379587;
						num2 = (int)((IntPtr)num);
						continue;
						IL_22F:
						num = (short)577110024;
						num2 = (int)((IntPtr)num);
					}
					return;
				}
				IL_60:
				bitmapImage = new BitmapImage();
				text = null;
				text2 = AppDomain.CurrentDomain.BaseDirectory;
				num3 = text2.IndexOf(RptMgrErrorHandler.b("ﶒ즔", a_));
				IL_88:
				num = (short)80871425;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00281E70 File Offset: 0x00280070
		internal void OnPrtSelectAll(object sender, RoutedEventArgs e)
		{
			short num = (short)1098776576;
			short num2 = num;
			num = (short)715344061;
			short num3 = num;
			num = (short)576473277;
			switch (num3 == num)
			{
			}
			num = (short)1495072769;
			if (num != 0)
			{
			}
			num = (short)1151467520;
			if (num != 0)
			{
			}
			this.lstUIValue.UnselectAll();
			this.lstUIValue.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
			this.lstUIValue.SelectAll();
			this.btnPrtSelectAll.IsEnabled = true;
			this.btnPrtPreview.IsEnabled = true;
			this.lstUIValue.Focus();
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00281F60 File Offset: 0x00280160
		internal void OnPrtUnSelectAll(object sender, RoutedEventArgs e)
		{
			short num = (short)767295489;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2059312190;
					short num3 = num;
					num = (short)1729469502;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A8;
					default:
						num = (short)868220928;
						if (num != 0)
						{
						}
						this.lstUIValue.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
						num = (short)1117126659;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)1982922753;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
					if (this.lstUIValue.SelectedItems.Count == 0)
					{
						num = (short)635699204;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 3:
					goto IL_1A8;
				case 4:
				{
					num = (short)1347026944;
					short num4 = num;
					this.btnPrtPreview.IsEnabled = false;
					num = (short)1038876677;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 5:
					goto IL_111;
				}
				IL_63:
				if (this.lstUIValue.SelectedItems.Count == this.lstUIValue.Items.Count)
				{
					num = (short)1294794752;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_116:
				num = (short)379518978;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1A8:
				goto IL_116;
			}
			IL_111:
			IL_1AD:
			this.lstUIValue.UnselectAll();
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00282128 File Offset: 0x00280328
		internal void OnPrtSelCancel(object sender, RoutedEventArgs e)
		{
			short num = (short)1359282176;
			short num2 = num;
			num = (short)709296129;
			if (num != 0)
			{
			}
			num = (short)1250064363;
			short num3 = num;
			num = (short)1055094763;
			switch (num3 == num)
			{
			}
			num = (short)957612032;
			if (num != 0)
			{
			}
			((Window)base.Parent).Close();
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x002821E0 File Offset: 0x002803E0
		internal void OnPrtPreview(object sender, RoutedEventArgs e)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			bool? isChecked;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1867251719;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (this.lstUIValue.SelectedItems.Count > 0)
					{
						num2 = (short)1059323915;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)688521219;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					if (!this.BuildTemplateFileXMLData(this.lstUIValue.SelectedItem.ToString()))
					{
						num2 = (short)1731198981;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 4:
				{
					if (!(isChecked.GetValueOrDefault() == flag & isChecked != null))
					{
						Trace.WriteLine(string.Format(RptMgrErrorHandler.b("좊搜ﾐ꾔랖ꮚ", a_), this.lstUIValue.SelectedItems.Count));
						num2 = (short)2144993289;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1441634168;
					short num3 = num2;
					num2 = (short)2053019512;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)392626176;
						if (num2 != 0)
						{
						}
						num2 = (short)585433096;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return;
				case 6:
					return;
				case 7:
					if (!this.BuildFeatureXMLData())
					{
						num2 = (short)1542848518;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 8:
					num2 = (short)2034237441;
					if (num2 != 0)
					{
					}
					num2 = (short)342753290;
					num = (int)((IntPtr)num2);
					continue;
				case 9:
					if (this.lstUIValue.SelectedItems.Count > 0)
					{
						num2 = (short)1093861376;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 10:
					if (this.lstUIValue.SelectedItems.Count > 0)
					{
						num2 = (short)1052508162;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 11:
				{
					this.BuildPrintChoicesReport();
					num2 = (short)192544768;
					short num4 = num2;
					num2 = (short)1465516044;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 12:
					return;
				}
				goto IL_4D;
				IL_237:
				num2 = (short)1033306113;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_4D:
			isChecked = this.radBtnTemplates.IsChecked;
			flag = true;
			num2 = (short)727318532;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x002824EC File Offset: 0x002806EC
		private void OnTemplateSelected(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7D;
				case 1:
					goto IL_176;
				case 2:
				{
					num2 = (short)440706605;
					short num3 = num2;
					num2 = (short)927835693;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
					{
						num2 = (short)1220149248;
						if (num2 != 0)
						{
						}
						num2 = (short)1826750465;
						if (num2 != 0)
						{
						}
						num2 = (short)1844314112;
						short num4 = num2;
						this.btnPrtEditTpl.IsEnabled = false;
						this.btnPrtDelTpl.IsEnabled = false;
						num2 = (short)1453326337;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_7D:
				if (this.lstUIValue.Items.Count != 0)
				{
					break;
				}
				num2 = (short)1633419266;
				num = (int)((IntPtr)num2);
			}
			IL_176:
			this.btnPrtSelectAll.IsEnabled = false;
			this.btnPrtUnSelectAll.IsEnabled = false;
			this.btnPrtPreview.IsEnabled = false;
			this.btnPrtCreateTpl.IsEnabled = true;
			return;
			IL_1C:
			this.a.Clear();
			this.a.AddRange(this.lstUIValue.SelectedItems);
			this.lstUIValue.Items.Clear();
			string text = "";
			this.a(PageCustomPrintSelection.fileAction.display, ref text);
			this.lstUIValue.SelectionMode = System.Windows.Controls.SelectionMode.Single;
			num2 = (short)211222528;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x002826A4 File Offset: 0x002808A4
		private void OnFeatureSelected(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1885536256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)898564096;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				for (;;)
				{
					IL_51:
					IEnumerator enumerator;
					System.Windows.Controls.ListViewItem listViewItem;
					switch (num2)
					{
					case 0:
						this.btnPrtSelectAll.IsEnabled = true;
						this.btnPrtUnSelectAll.IsEnabled = true;
						this.btnPrtCreateTpl.IsEnabled = false;
						this.btnPrtEditTpl.IsEnabled = false;
						this.btnPrtDelTpl.IsEnabled = false;
						this.btnPrtPreview.IsEnabled = false;
						num = (short)995033091;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (this.a.Count > 0)
						{
							num = (short)652083201;
							if (num != 0)
							{
							}
							num = (short)98828293;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (this.lstUIValue.Items.Count > 0)
						{
							num = (short)1252589568;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 3:
						goto IL_4A0;
					case 4:
						try
						{
							num = (short)274923521;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator enumerator2;
								System.Windows.Controls.ListViewItem listViewItem2;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1564475395;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_346;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_108;
									}
									continue;
								case 2:
									try
									{
										num = (short)194969603;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1707737089;
												num2 = (int)((IntPtr)num);
												continue;
											case 1:
												goto IL_2CB;
											case 2:
												if (!enumerator2.MoveNext())
												{
													num = (short)1565196288;
													num2 = (int)((IntPtr)num);
													continue;
												}
												listViewItem = (System.Windows.Controls.ListViewItem)enumerator2.Current;
												num = (short)1032388612;
												num2 = (int)((IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_1D3;
												}
												continue;
											case 4:
												if (listViewItem2.Content.Equals(listViewItem.Content))
												{
													num = (short)320471046;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 6:
											{
												int index = this.lstUIValue.Items.IndexOf(listViewItem);
												((System.Windows.Controls.ListViewItem)this.lstUIValue.Items[index]).IsSelected = true;
												num = (short)684982277;
												num2 = (int)((IntPtr)num);
												continue;
											}
											}
											IL_1D5:
											num = (short)1350041602;
											num2 = (int)((IntPtr)num);
											continue;
											IL_1D3:
											goto IL_1D5;
										}
										IL_2CB:
										break;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_2ED;
										}
										IDisposable disposable;
										for (;;)
										{
											IL_2DA:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)808779777;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_345;
											case 1:
												disposable.Dispose();
												num = (short)1290731522;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												goto IL_343;
											}
											goto IL_2ED;
										}
										IL_343:
										IL_345:
										goto EndFinally_12;
										IL_2ED:
										disposable = (enumerator2 as IDisposable);
										num = (short)22216704;
										num2 = (int)((IntPtr)num);
										goto IL_2DA;
										EndFinally_12:;
									}
									goto IL_346;
								case 3:
								{
									num = (short)1337925816;
									short num4 = num;
									num = (short)1683890360;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)471728128;
										if (num != 0)
										{
										}
										num = (short)1762983940;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_398;
								}
								IL_10D:
								num = (short)19070976;
								num2 = (int)((IntPtr)num);
								continue;
								IL_108:
								goto IL_10D;
								IL_346:
								listViewItem2 = (System.Windows.Controls.ListViewItem)enumerator.Current;
								enumerator2 = ((IEnumerable)this.lstUIValue.Items).GetEnumerator();
								num = (short)1233846274;
								num2 = (int)((IntPtr)num);
							}
							IL_398:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3BA;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_3A7:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1808269313;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_412;
								case 1:
									disposable.Dispose();
									num = (short)296484866;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_410;
								}
								goto IL_3BA;
							}
							IL_410:
							IL_412:
							goto EndFinally_13;
							IL_3BA:
							disposable = (enumerator as IDisposable);
							num = (short)1524301824;
							num2 = (int)((IntPtr)num);
							goto IL_3A7;
							EndFinally_13:;
						}
						goto IL_413;
					case 5:
						goto IL_413;
					}
					goto IL_70;
					IL_413:
					listViewItem = null;
					enumerator = this.a.GetEnumerator();
					num = (short)1015611396;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4A0:
					num = (short)122552321;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_70:
				this.lstUIValue.Items.Clear();
				this.BuildCustomPrintSelection();
				num = (short)1882849282;
				num2 = (int)((IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00282BF4 File Offset: 0x00280DF4
		private bool a(PageCustomPrintSelection.fileAction A_0, ref string A_1)
		{
			int a_ = 6;
			short num = (short)952136143;
			short num2 = num;
			num = (short)167145935;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1911685120;
				short num3 = num;
				num = (short)468975616;
				if (num != 0)
				{
				}
				num = (short)705232897;
				if (num != 0)
				{
				}
				num = (short)1039990784;
				switch (num)
				{
				}
				break;
			}
			}
			bool result = false;
			string usrPrntTemplateDir = Global.usrPrntTemplateDir;
			try
			{
				num = (short)1848901660;
				int num4 = (int)((IntPtr)num);
				for (;;)
				{
					int num5;
					switch (num4)
					{
					case 0:
						goto IL_498;
					case 1:
						goto IL_66E;
					case 2:
						result = true;
						num = (short)1682178081;
						num4 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_408;
					case 4:
					{
						string[] files;
						if (files.Length != 0)
						{
							num = (short)859242528;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BD;
					}
					case 5:
						if (num5 < Global.usrLastSavedContainer.Count)
						{
							num = (short)129368100;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5AD;
					case 6:
						goto IL_5EE;
					case 7:
					{
						int num6;
						string[] array;
						if (num6 >= array.Length)
						{
							num = (short)1193345035;
							num4 = (int)((IntPtr)num);
							continue;
						}
						string text = array[num6].Remove(0, usrPrntTemplateDir.Length + 1);
						this.lstUIValue.Items.Add(text);
						text = "";
						num6++;
						num = (short)1011154954;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						goto IL_66E;
					case 9:
						if (num5 < Global.usrLastSavedContainer.Count)
						{
							num = (short)899219477;
							num4 = (int)((IntPtr)num);
							continue;
						}
						A_1 = usrPrntTemplateDir + RptMgrErrorHandler.b("했", a_) + A_1;
						num = (short)685572114;
						num4 = (int)((IntPtr)num);
						continue;
					case 10:
						goto IL_498;
					case 11:
						goto IL_1BD;
					case 12:
						result = false;
						num = (short)250216477;
						num4 = (int)((IntPtr)num);
						continue;
					case 13:
						if (File.Exists(A_1.ToString()))
						{
							num = (short)938344450;
							num4 = (int)((IntPtr)num);
							continue;
						}
						System.Windows.MessageBox.Show(AppResources.File_not_found + A_1.ToString());
						num = (short)414318597;
						num4 = (int)((IntPtr)num);
						continue;
					case 14:
						goto IL_8BD;
					case 15:
					{
						string text2;
						if (!this.lstUIValue.Items.Contains(text2))
						{
							num = (short)1263730711;
							num4 = (int)((IntPtr)num);
							continue;
						}
						int num7;
						num7++;
						string text;
						text2 = text + RptMgrErrorHandler.b("ꦈ킊", a_) + num7.ToString() + RptMgrErrorHandler.b("품", a_);
						num = (short)465174529;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 16:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_2DE;
							}
							for (;;)
							{
								IL_2C7:
								switch (num4)
								{
								case 0:
									if (num5 < Global.usrLastSavedContainer.Count)
									{
										num = (short)874053634;
										num4 = (int)((IntPtr)num);
										continue;
									}
									goto IL_344;
								case 1:
									goto IL_344;
								case 2:
									Global.usrLastSavedContainer.Remove(A_1);
									num = (short)176357377;
									num4 = (int)((IntPtr)num);
									continue;
								case 3:
									goto IL_35E;
								}
								goto IL_2DE;
								IL_344:
								result = true;
								num = (short)527761411;
								num4 = (int)((IntPtr)num);
							}
							IL_35E:
							goto IL_904;
							IL_2DE:
							File.Delete(A_1);
							num = (short)148504576;
							num4 = (int)((IntPtr)num);
							goto IL_2C7;
						}
						catch (Exception ex)
						{
							System.Windows.MessageBox.Show(ex.Message);
							result = false;
							goto IL_904;
						}
						goto IL_375;
					case 17:
						goto IL_8BD;
					case 18:
						goto IL_3CA;
					case 19:
					{
						int num8 = 0;
						num = (short)1476853763;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 20:
						switch (A_0)
						{
						case PageCustomPrintSelection.fileAction.display:
						{
							string[] files = Directory.GetFiles(usrPrntTemplateDir, RptMgrErrorHandler.b("ꎈꖊ歷ﾎ﶐", a_));
							string text = "";
							this.lstUIValue.Items.Clear();
							num = (short)78512132;
							num4 = (int)((IntPtr)num);
							continue;
						}
						case PageCustomPrintSelection.fileAction.edit:
							Trace.WriteLine(RptMgrErrorHandler.b("첈ﮎ", a_));
							num5 = this.lstUIValue.Items.IndexOf(A_1);
							num = (short)1745551390;
							num4 = (int)((IntPtr)num);
							continue;
						case PageCustomPrintSelection.fileAction.del:
							num5 = this.lstUIValue.Items.IndexOf(A_1);
							num = (short)840171529;
							num4 = (int)((IntPtr)num);
							continue;
						default:
							num = (short)1166737443;
							num4 = (int)((IntPtr)num);
							continue;
						}
						break;
					case 21:
					{
						int index = Global.usrLastSavedContainer.Count - num5 - 1;
						A_1 = Global.usrLastSavedContainer[index];
						num = (short)627310616;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 22:
						goto IL_904;
					case 23:
					{
						string text2;
						string text = text2;
						this.lstUIValue.Items.Insert(0, text);
						text = "";
						int num8;
						num8++;
						num = (short)2146172954;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 24:
						goto IL_3CA;
					case 25:
						goto IL_5AD;
					case 26:
						goto IL_408;
					case 27:
						if (Global.usrLastSavedContainer.Count > 0)
						{
							num = (short)1400766483;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 28:
						switch (0)
						{
						case 0:
							goto IL_193;
						}
						continue;
					case 29:
						goto IL_904;
					case 30:
						if (num5 < Global.usrLastSavedContainer.Count)
						{
							num = (short)1244397607;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_375;
					case 31:
						num = (short)639762452;
						num4 = (int)((IntPtr)num);
						continue;
					case 32:
					{
						string[] files;
						string[] array = files;
						int num6 = 0;
						num = (short)234094592;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 33:
						goto IL_904;
					case 34:
					{
						int num8;
						if (num8 >= Global.usrLastSavedContainer.Count)
						{
							num = (short)237961222;
							num4 = (int)((IntPtr)num);
							continue;
						}
						string text = Global.usrLastSavedContainer[num8];
						text = text.Remove(0, text.LastIndexOf(RptMgrErrorHandler.b("했", a_)) + 1);
						int num7 = 0;
						string text2 = text;
						num = (short)1198915592;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 35:
						num = (short)879820812;
						num4 = (int)((IntPtr)num);
						continue;
					case 36:
						Global.usrLastSavedContainer.Remove(A_1);
						num = (short)34275353;
						num4 = (int)((IntPtr)num);
						continue;
					case 37:
						goto IL_91D;
					case 38:
						goto IL_904;
					case 39:
					{
						int index2 = Global.usrLastSavedContainer.Count - num5 - 1;
						A_1 = Global.usrLastSavedContainer[index2];
						num = (short)1405681681;
						num4 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_193:
					if (Directory.Exists(usrPrntTemplateDir))
					{
						num = (short)1097138207;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_904;
					IL_1BD:
					num = (short)513867803;
					num4 = (int)((IntPtr)num);
					continue;
					IL_375:
					A_1 = usrPrntTemplateDir + RptMgrErrorHandler.b("했", a_) + A_1;
					num = (short)1454833678;
					num4 = (int)((IntPtr)num);
					continue;
					IL_3CA:
					num = (short)1654259728;
					num4 = (int)((IntPtr)num);
					continue;
					IL_408:
					num = (short)2128609314;
					num4 = (int)((IntPtr)num);
					continue;
					IL_498:
					num = (short)1590624263;
					num4 = (int)((IntPtr)num);
					continue;
					IL_5AD:
					this.lstUIValue.Items.Remove(this.lstUIValue.Items[num5]);
					result = false;
					num = (short)1146421286;
					num4 = (int)((IntPtr)num);
					continue;
					IL_5EE:
					result = true;
					num = (short)1293221910;
					num4 = (int)((IntPtr)num);
					continue;
					IL_66E:
					num = (short)397934607;
					num4 = (int)((IntPtr)num);
					continue;
					IL_8BD:
					num = (short)134283277;
					num4 = (int)((IntPtr)num);
					continue;
					IL_904:
					num = (short)284164133;
					num4 = (int)((IntPtr)num);
				}
				IL_91D:;
			}
			catch (Exception ex2)
			{
				result = false;
				System.Windows.MessageBox.Show(ex2.Message);
			}
			return result;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00283564 File Offset: 0x00281764
		private void OnSelectExistingTemplateFile(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			bool? isChecked;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_2E8;
				case 1:
					this.btnPrtPreview.IsEnabled = false;
					num2 = (short)319356931;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)1032060935;
						num = (int)((IntPtr)num2);
						continue;
					}
					this.lstUIValue.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
					this.btnPrtPreview.IsEnabled = true;
					this.btnPrtSelectAll.IsEnabled = true;
					this.btnPrtDelTpl.IsEnabled = false;
					this.btnPrtEditTpl.IsEnabled = false;
					this.btnPrtCreateTpl.IsEnabled = false;
					num2 = (short)1109065736;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					return;
				case 4:
				{
					num2 = (short)1374773313;
					short num3 = num2;
					num2 = (short)1226465345;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E8;
					default:
					{
						num2 = (short)971898880;
						short num4 = num2;
						num2 = (short)323616768;
						if (num2 != 0)
						{
						}
						goto IL_297;
					}
					}
					break;
				}
				case 5:
					this.lstUIValue.SelectionMode = System.Windows.Controls.SelectionMode.Single;
					num2 = (short)1249050628;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					goto IL_E7;
				case 7:
					num2 = (short)1666777097;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					if (this.lstUIValue.SelectedItems.Count == 0)
					{
						num2 = (short)717750273;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 9:
					if (this.lstUIValue.SelectedItems.Count != this.lstUIValue.Items.Count)
					{
						num2 = (short)669384709;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_297;
				case 10:
					if (this.lstUIValue.SelectedItems.Count >= 1)
					{
						num2 = (short)485228544;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_93;
				}
				goto IL_3C;
				IL_297:
				this.btnPrtCreateTpl.IsEnabled = true;
				num2 = (short)1650851850;
				num = (int)((IntPtr)num2);
				continue;
				IL_2E8:
				num2 = (short)433389569;
				if (num2 != 0)
				{
				}
				this.btnPrtDelTpl.IsEnabled = true;
				this.btnPrtEditTpl.IsEnabled = true;
				this.btnPrtPreview.IsEnabled = true;
				num2 = (short)324141062;
				num = (int)((IntPtr)num2);
			}
			IL_93:
			this.btnPrtSelectAll.IsEnabled = false;
			this.btnPrtUnSelectAll.IsEnabled = false;
			return;
			IL_E7:
			goto IL_93;
			IL_3C:
			isChecked = this.radBtnTemplates.IsChecked;
			flag = true;
			num2 = (short)232128514;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00283888 File Offset: 0x00281A88
		private void OnCreateTemplate(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1779137615;
			short num2 = num;
			num = (short)1462074447;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1495203840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)802422785;
			if (num != 0)
			{
			}
			num = (short)380305408;
			if (num != 0)
			{
			}
			PageSelectPrintItems pageSelectPrintItems = new PageSelectPrintItems();
			pageSelectPrintItems.BuildPrintItems();
			AcpUIDialogWindow<string> acpUIDialogWindow = new AcpUIDialogWindow<string>(pageSelectPrintItems, null);
			acpUIDialogWindow.Width = 645.0;
			acpUIDialogWindow.Height = 480.0;
			acpUIDialogWindow.ResizeMode = ResizeMode.NoResize;
			acpUIDialogWindow.WindowStartupLocation = WindowStartupLocation.Manual;
			acpUIDialogWindow.Top = ((double)SystemInformation.MaxWindowTrackSize.Height - acpUIDialogWindow.Height) / 2.0;
			acpUIDialogWindow.Left = ((double)SystemInformation.MaxWindowTrackSize.Width - acpUIDialogWindow.Width) / 2.0;
			acpUIDialogWindow.MaxHeight = acpUIDialogWindow.Height;
			acpUIDialogWindow.MaxWidth = acpUIDialogWindow.Width;
			acpUIDialogWindow.Show();
			acpUIDialogWindow.Focus();
			acpUIDialogWindow.Hide();
			acpUIDialogWindow.ShowDialog();
			this.lblSelectionTitle.Content = AppResources.Features_Id_Template;
			this.lstUIValue.Items.Clear();
			string text = "";
			this.radBtnTemplates.IsChecked = new bool?(true);
			this.radBtnFeatures.IsChecked = new bool?(false);
			this.btnPrtDelTpl.IsEnabled = false;
			this.btnPrtEditTpl.IsEnabled = false;
			this.btnPrtPreview.IsEnabled = false;
			this.a(PageCustomPrintSelection.fileAction.display, ref text);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00283A64 File Offset: 0x00281C64
		private void OnEditTemplate(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1455947776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)61014017;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						string text;
						if (File.Exists(text))
						{
							num = (short)865861634;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1AD3;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 2:
						num = (short)400162817;
						if (num != 0)
						{
						}
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							string text;
							PageSelectPrintItems pageSelectPrintItems;
							RptTreeViewItem rptTreeViewItem;
							int num3;
							RptTreeViewItem rptTreeViewItem2;
							string text3;
							string text4;
							Dictionary<string, int>.KeyCollection.Enumerator enumerator;
							ReportsSerializeItems reportsSerializeItems;
							string text5;
							string text6;
							RptTreeViewItem rptTreeViewItem3;
							for (;;)
							{
								IL_A1:
								AcpUIDialogWindow<string> acpUIDialogWindow;
								switch (num2)
								{
								case 0:
									goto IL_19FC;
								case 1:
									goto IL_194E;
								case 2:
									if (pageSelectPrintItems.tvSelected.Items.Count > 0)
									{
										num = (short)593887239;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_17BF;
								case 3:
									try
									{
										num = (short)877985840;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											IAcpRecordset parentRecset;
											IAcpFeatureSection acpFeatureSection;
											IAcpFeatureNode acpFeatureNode;
											IAcpFeatureSection acpFeatureSection2;
											IAcpFeatureSection acpFeatureSection3;
											switch (num2)
											{
											case 0:
												goto IL_16CA;
											case 1:
												goto IL_17AC;
											case 2:
												goto IL_57C;
											case 3:
											{
												IAcpRecordset feature;
												if (feature != null)
												{
													num = (short)1234370568;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												goto IL_16CA;
											case 5:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)635437056;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 6:
												num = (short)115998721;
												num2 = (int)((IntPtr)num);
												continue;
											case 7:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)945619021;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 8:
												num = (short)16908321;
												num2 = (int)((IntPtr)num);
												continue;
											case 9:
											{
												IAcpRecordset feature;
												string text2;
												IAcpField acpField = feature.FieldFromFavoritePath(text2, RptMgrErrorHandler.b("쾒", a_));
												num = (short)314572817;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 10:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)173670414;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 11:
												acpFeatureSection = parentRecset.ParentSection;
												acpFeatureNode = acpFeatureSection.Parent;
												num = (short)426967042;
												num2 = (int)((IntPtr)num);
												continue;
											case 12:
												if (text3 != parentRecset.RecordsetName)
												{
													num = (short)829227053;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)2106654752;
												num2 = (int)((IntPtr)num);
												continue;
											case 14:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)917569540;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 15:
												goto IL_16CA;
											case 16:
												goto IL_16CA;
											case 17:
												goto IL_446;
											case 18:
												goto IL_16CA;
											case 19:
												if (text4 != acpFeatureNode.UIName)
												{
													num = (short)1089929285;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)672727091;
												num2 = (int)((IntPtr)num);
												continue;
											case 20:
												goto IL_16CA;
											case 21:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)1189740582;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 22:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)482148358;
													num2 = (int)((IntPtr)num);
													continue;
												}
												string text2 = enumerator.Current;
												reportsSerializeItems.sField.TryGetValue(text2, out num3);
												Trace.WriteLine(string.Format(RptMgrErrorHandler.b("햒ﲔﾚ출ﺞ햠쮢龤\udca6馨횪膬辮횲풴쎶첸즺\ud8bcꗀ蓼뻄듈", a_), text2, num3));
												IAcpRecordset feature = FeatureManager.GetFeature(num3);
												num = (short)1247346691;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 23:
												text5 = "";
												text6 = "";
												rptTreeViewItem3 = new RptTreeViewItem();
												rptTreeViewItem3.Header = parentRecset.UIName;
												rptTreeViewItem3.RptRecordName = parentRecset.RecordsetName;
												rptTreeViewItem3.ID = num3;
												rptTreeViewItem3.ItemType = 0;
												pageSelectPrintItems.tvSelected.Items.Add(rptTreeViewItem3);
												text3 = parentRecset.RecordsetName;
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.Header = acpFeatureSection2.UIName;
												rptTreeViewItem2.RptRecordName = acpFeatureSection2.UIName;
												rptTreeViewItem2.ID = num3;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem3.Items.Add(rptTreeViewItem2);
												text5 = acpFeatureSection2.UIName;
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)757530645;
												num2 = (int)((IntPtr)num);
												continue;
											case 24:
											{
												bool flag;
												if (!flag)
												{
													num = (short)1148387351;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)978976832;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 25:
												if (text6 != acpFeatureSection.UIName)
												{
													num = (short)1463943226;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_13E2;
											case 26:
												goto IL_1117;
											case 27:
												goto IL_16CA;
											case 28:
											{
												IAcpField acpField;
												acpFeatureSection3 = acpField.Parent;
												goto IL_4FB;
											}
											case 29:
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.Header = acpFeatureSection2.UIName;
												rptTreeViewItem2.RptRecordName = acpFeatureSection2.UIName;
												rptTreeViewItem2.ID = num3;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem3.Items.Add(rptTreeViewItem2);
												text5 = acpFeatureSection2.UIName;
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)2135883830;
												num2 = (int)((IntPtr)num);
												continue;
											case 30:
											{
												IAcpRecordset feature;
												string text2;
												IAcpField acpField = feature.FieldFromFavoritePath(text2, RptMgrErrorHandler.b("⢒", a_));
												num = (short)705626159;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 31:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1898184724;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 32:
												if (text5 != acpFeatureSection2.UIName)
												{
													num = (short)1497825309;
													num2 = (int)((IntPtr)num);
													continue;
												}
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)112984074;
												num2 = (int)((IntPtr)num);
												continue;
											case 33:
												if (Global.printTemplateVersion == 0)
												{
													num = (short)947912713;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)2051932228;
												num2 = (int)((IntPtr)num);
												continue;
											case 34:
												rptTreeViewItem3.Header = acpFeatureNode.Parent.UIName;
												rptTreeViewItem3.RptRecordName = acpFeatureNode.Parent.RecordsetName;
												num = (short)151978055;
												num2 = (int)((IntPtr)num);
												continue;
											case 35:
												goto IL_16CA;
											case 36:
												try
												{
													num = (short)631635974;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															bool flag = true;
															num = (short)985726979;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 1:
															goto IL_732;
														case 2:
														{
															IEnumerator enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1506410500;
																num2 = (int)((IntPtr)num);
																continue;
															}
															num = (short)237043717;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 3:
															goto IL_71A;
														case 4:
															goto IL_71A;
														case 5:
														{
															IEnumerator enumerator2;
															if (((RptTreeViewItem)enumerator2.Current).RptRecordName.Equals(parentRecset.RecordsetName))
															{
																num = (short)236126208;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														}
														case 6:
															switch (0)
															{
															case 0:
																goto IL_674;
															}
															continue;
														}
														IL_676:
														num = (short)299630594;
														num2 = (int)((IntPtr)num);
														continue;
														IL_674:
														goto IL_676;
														IL_71A:
														num = (short)336068609;
														num2 = (int)((IntPtr)num);
													}
													IL_732:;
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_751;
													}
													IDisposable disposable;
													for (;;)
													{
														IL_73E:
														switch (num2)
														{
														case 0:
															goto IL_7A9;
														case 1:
															disposable.Dispose();
															num = (short)1667956736;
															num2 = (int)((IntPtr)num);
															continue;
														case 2:
															if (disposable != null)
															{
																num = (short)1193410561;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_7AB;
														}
														goto IL_751;
													}
													IL_7A9:
													IL_7AB:
													goto EndFinally_61;
													IL_751:
													IEnumerator enumerator2;
													disposable = (enumerator2 as IDisposable);
													num = (short)1482424322;
													num2 = (int)((IntPtr)num);
													goto IL_73E;
													EndFinally_61:;
												}
												num = (short)1185284120;
												num2 = (int)((IntPtr)num);
												continue;
											case 37:
												num = (short)1932394521;
												num2 = (int)((IntPtr)num);
												continue;
											case 38:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1646133318;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 39:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1464598544;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 40:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)754778186;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 41:
											{
												bool flag2;
												if (flag2)
												{
													num = (short)739835941;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_13E2;
											}
											case 42:
												text5 = "";
												text6 = "";
												rptTreeViewItem3 = new RptTreeViewItem();
												num = (short)211615803;
												num2 = (int)((IntPtr)num);
												continue;
											case 43:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1120403474;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 44:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1211105315;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 45:
											{
												bool flag = false;
												IEnumerator enumerator2 = ((IEnumerable)pageSelectPrintItems.tvSelected.Items).GetEnumerator();
												num = (short)1987837988;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 46:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)115539973;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 47:
												goto IL_446;
											case 48:
												switch (0)
												{
												case 0:
													goto IL_2E6;
												}
												continue;
											case 49:
											{
												bool flag2;
												if (!flag2)
												{
													num = (short)762642474;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)108331049;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 50:
											{
												IAcpField acpField;
												if (acpField != null)
												{
													num = (short)2145058872;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)1149567043;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 51:
												if (text6 != acpFeatureSection.UIName)
												{
													num = (short)1694171191;
													num2 = (int)((IntPtr)num);
													continue;
												}
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)121438254;
												num2 = (int)((IntPtr)num);
												continue;
											case 52:
												num = (short)17629244;
												num2 = (int)((IntPtr)num);
												continue;
											case 53:
												try
												{
													num = (short)2072838150;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															IEnumerator enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1110638595;
																num2 = (int)((IntPtr)num);
																continue;
															}
															num = (short)929038340;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 1:
														{
															num = (short)1994963600;
															short num4 = num;
															num = (short)205830800;
															switch ((num4 == num) ? 1 : 0)
															{
															case 0:
															case 2:
																continue;
															default:
																goto IL_F7C;
															}
															break;
														}
														case 2:
															goto IL_F2F;
														case 3:
															goto IL_F2F;
														case 4:
														{
															IEnumerator enumerator2;
															if (((RptTreeViewItem)enumerator2.Current).RptRecordName.Equals(acpFeatureNode.FeatureName))
															{
																num = (short)322502661;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														}
														case 5:
														{
															bool flag2 = true;
															num = (short)1149173762;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 6:
															switch (0)
															{
															case 0:
																goto IL_E85;
															}
															continue;
														}
														IL_EF3:
														num = (short)1115815936;
														num2 = (int)((IntPtr)num);
														continue;
														IL_E85:
														goto IL_EF3;
														IL_F2F:
														num = (short)412155905;
														num2 = (int)((IntPtr)num);
													}
													IL_F7C:
													num = (short)789577728;
													if (num != 0)
													{
													}
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_FB0;
													}
													IDisposable disposable;
													for (;;)
													{
														IL_F9D:
														switch (num2)
														{
														case 0:
															goto IL_1007;
														case 1:
															if (disposable != null)
															{
																num = (short)847708162;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_1009;
														case 2:
															disposable.Dispose();
															num = (short)1541996544;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_FB0;
													}
													IL_1007:
													IL_1009:
													goto EndFinally_60;
													IL_FB0:
													IEnumerator enumerator2;
													disposable = (enumerator2 as IDisposable);
													num = (short)2041118721;
													num2 = (int)((IntPtr)num);
													goto IL_F9D;
													EndFinally_60:;
												}
												num = (short)246415409;
												num2 = (int)((IntPtr)num);
												continue;
											case 54:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)99483687;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 55:
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.Header = acpFeatureSection.UIName;
												rptTreeViewItem2.RptRecordName = acpFeatureSection.FeatureSectionName;
												rptTreeViewItem2.ID = num3;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem3.Items.Add(rptTreeViewItem2);
												text6 = acpFeatureSection.UIName;
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)535887933;
												num2 = (int)((IntPtr)num);
												continue;
											case 56:
												num = (short)41877566;
												num2 = (int)((IntPtr)num);
												continue;
											case 57:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)771883039;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 58:
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.Header = acpFeatureSection.UIName;
												rptTreeViewItem2.RptRecordName = acpFeatureSection.FeatureSectionName;
												rptTreeViewItem2.ID = num3;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem3.Items.Add(rptTreeViewItem2);
												text6 = acpFeatureSection.UIName;
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)1969422393;
												num2 = (int)((IntPtr)num);
												continue;
											case 59:
												if (acpFeatureNode.Parent.RecordsetName.Equals(AppResources.Unified_Call_List))
												{
													num = (short)829751330;
													num2 = (int)((IntPtr)num);
													continue;
												}
												rptTreeViewItem3.Header = acpFeatureNode.UIName;
												rptTreeViewItem3.RptRecordName = acpFeatureNode.FeatureName;
												num = (short)1740111898;
												num2 = (int)((IntPtr)num);
												continue;
											case 60:
											{
												IAcpField acpField;
												acpFeatureSection3 = acpField.NewParent;
												goto IL_4FB;
											}
											case 61:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)2117992491;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 62:
											{
												IAcpField acpField;
												if (acpField.NewParent != null)
												{
													num = (short)23789620;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)881459228;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 63:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)1860304972;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 64:
											{
												bool flag;
												if (flag)
												{
													num = (short)48365648;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_AE1;
											}
											case 65:
												num = (short)61931532;
												num2 = (int)((IntPtr)num);
												continue;
											case 66:
												if (!parentRecset.IsEmbeddedRecset)
												{
													num = (short)1548156993;
													num2 = (int)((IntPtr)num);
													continue;
												}
												num = (short)1214513171;
												num2 = (int)((IntPtr)num);
												continue;
											case 67:
												if (System.Windows.MessageBox.Show(AppResources.Template_Not_Supported, AppResources.Cannot_Edit_Template_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
												{
													num = (short)1822949457;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 68:
												if (Global.printTemplateVersion == 1)
												{
													num = (short)1638430;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_446;
											case 69:
											{
												bool flag2 = false;
												IEnumerator enumerator2 = ((IEnumerable)pageSelectPrintItems.tvSelected.Items).GetEnumerator();
												num = (short)1201668149;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 70:
												goto IL_16CA;
											case 71:
												goto IL_1117;
											case 72:
												goto IL_174D;
											case 73:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)2081620031;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 74:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)254935055;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 75:
												if (text5 != acpFeatureSection2.UIName)
												{
													num = (short)557449295;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_AE1;
											case 76:
												goto IL_16CA;
											case 77:
											{
												IAcpField acpField;
												rptTreeViewItem.RptRecordName = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												rptTreeViewItem.ID = num3;
												rptTreeViewItem.ItemType = 2;
												rptTreeViewItem.RptPath = acpField.Path(RptMgrErrorHandler.b("⢒", a_));
												rptTreeViewItem2.Items.Add(rptTreeViewItem);
												num = (short)548143131;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 78:
												if (parentRecset.IsEmbeddedRecset)
												{
													num = (short)1758527499;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_57C;
											case 79:
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.Header = acpFeatureSection2.UIName;
												rptTreeViewItem2.RptRecordName = acpFeatureSection2.UIName;
												rptTreeViewItem2.ID = num3;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem3.Items.Add(rptTreeViewItem2);
												text5 = acpFeatureSection2.UIName;
												rptTreeViewItem = new RptTreeViewItem();
												num = (short)204210249;
												num2 = (int)((IntPtr)num);
												continue;
											case 80:
												num = (short)24838219;
												num2 = (int)((IntPtr)num);
												continue;
											case 81:
												num = (short)1003946056;
												num2 = (int)((IntPtr)num);
												continue;
											case 82:
											{
												IAcpField acpField;
												rptTreeViewItem.Header = ((acpField.NewUIName != null) ? acpField.NewUIName : acpField.UIName);
												num = (short)944570412;
												num2 = (int)((IntPtr)num);
												continue;
											}
											}
											goto IL_2E6;
											IL_446:
											num = (short)2096103474;
											num2 = (int)((IntPtr)num);
											continue;
											IL_4FB:
											acpFeatureSection2 = acpFeatureSection3;
											IAcpFeatureNode parent = acpFeatureSection2.Parent;
											parentRecset = acpFeatureSection2.ParentRecset;
											acpFeatureSection = null;
											acpFeatureNode = null;
											num = (short)372441166;
											num2 = (int)((IntPtr)num);
											continue;
											IL_57C:
											num = (short)138149954;
											num2 = (int)((IntPtr)num);
											continue;
											IL_AE1:
											rptTreeViewItem = new RptTreeViewItem();
											num = (short)1930559495;
											num2 = (int)((IntPtr)num);
											continue;
											IL_1117:
											rptTreeViewItem3.ID = num3;
											rptTreeViewItem3.ItemType = 0;
											pageSelectPrintItems.tvSelected.Items.Add(rptTreeViewItem3);
											text4 = acpFeatureNode.UIName;
											rptTreeViewItem2 = new RptTreeViewItem();
											rptTreeViewItem2.Header = acpFeatureSection.UIName;
											rptTreeViewItem2.RptRecordName = acpFeatureSection.FeatureSectionName;
											rptTreeViewItem2.ID = num3;
											rptTreeViewItem2.ItemType = 1;
											rptTreeViewItem3.Items.Add(rptTreeViewItem2);
											text6 = acpFeatureSection.UIName;
											rptTreeViewItem = new RptTreeViewItem();
											num = (short)132972626;
											num2 = (int)((IntPtr)num);
											continue;
											IL_13E2:
											rptTreeViewItem = new RptTreeViewItem();
											num = (short)1786839080;
											num2 = (int)((IntPtr)num);
											continue;
											IL_16CA:
											pageSelectPrintItems.RmvFromAvailableTreeItems(rptTreeViewItem3, rptTreeViewItem2, rptTreeViewItem);
											num = (short)1373306893;
											num2 = (int)((IntPtr)num);
											continue;
											IL_1752:
											num = (short)1314258966;
											num2 = (int)((IntPtr)num);
											continue;
											IL_2E6:
											goto IL_1752;
										}
										IL_174D:
										goto IL_1AD3;
										IL_17AC:
										goto IL_18D9;
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
									}
									goto IL_17BF;
									IL_18D9:
									num = (short)1781334018;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									if (this.b != null)
									{
										num = (short)285736965;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_194E;
								case 5:
									acpUIDialogWindow.Owner = this.b;
									num = (short)1903099905;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_17BF;
								case 7:
									pageSelectPrintItems.SortItems(ref pageSelectPrintItems.tvSelected);
									num = (short)1846345734;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_C8;
								IL_17BF:
								pageSelectPrintItems.tvAvailable.Tag = text;
								acpUIDialogWindow = new AcpUIDialogWindow<string>(pageSelectPrintItems, null);
								acpUIDialogWindow.Width = 645.0;
								acpUIDialogWindow.Height = 480.0;
								acpUIDialogWindow.ResizeMode = ResizeMode.NoResize;
								acpUIDialogWindow.WindowStartupLocation = WindowStartupLocation.Manual;
								acpUIDialogWindow.Top = ((double)SystemInformation.MaxWindowTrackSize.Height - acpUIDialogWindow.Height) / 2.0;
								acpUIDialogWindow.Left = ((double)SystemInformation.MaxWindowTrackSize.Width - acpUIDialogWindow.Width) / 2.0;
								acpUIDialogWindow.MaxHeight = acpUIDialogWindow.Height;
								acpUIDialogWindow.MaxWidth = acpUIDialogWindow.Width;
								num = (short)347799556;
								num2 = (int)((IntPtr)num);
								continue;
								IL_194E:
								acpUIDialogWindow.Show();
								acpUIDialogWindow.Focus();
								acpUIDialogWindow.Hide();
								acpUIDialogWindow.ShowDialog();
								this.lblSelectionTitle.Content = AppResources.Features_Id_Template;
								this.lstUIValue.Items.Clear();
								text = "";
								this.radBtnTemplates.IsChecked = new bool?(true);
								this.radBtnFeatures.IsChecked = new bool?(false);
								this.btnPrtDelTpl.IsEnabled = false;
								this.btnPrtEditTpl.IsEnabled = false;
								this.btnPrtPreview.IsEnabled = false;
								this.a(PageCustomPrintSelection.fileAction.display, ref text);
								num = (short)520159232;
								num2 = (int)((IntPtr)num);
							}
							IL_19FC:
							goto IL_1AD3;
							IL_C8:
							FileStream fileStream = new FileStream(text, FileMode.Open);
							BinaryFormatter binaryFormatter = new BinaryFormatter();
							reportsSerializeItems = new ReportsSerializeItems();
							reportsSerializeItems = (ReportsSerializeItems)binaryFormatter.Deserialize(fileStream);
							fileStream.Close();
							pageSelectPrintItems = new PageSelectPrintItems();
							pageSelectPrintItems.tvSelected.Items.Clear();
							pageSelectPrintItems.BuildPrintItems();
							num3 = 0;
							text3 = "";
							text5 = "";
							text6 = "";
							text4 = "";
							rptTreeViewItem3 = new RptTreeViewItem();
							rptTreeViewItem2 = new RptTreeViewItem();
							rptTreeViewItem = new RptTreeViewItem();
							enumerator = reportsSerializeItems.sField.Keys.GetEnumerator();
							num = (short)2074345475;
							num2 = (int)((IntPtr)num);
							goto IL_A1;
						}
						catch (Exception ex)
						{
							System.Windows.MessageBox.Show(ex.Message);
							goto IL_1AD3;
						}
						goto IL_1A11;
					case 3:
					{
						IAcpField acpField = null;
						string text = this.lstUIValue.SelectedItem.ToString();
						num = (short)1934753797;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1A11;
					case 5:
					{
						string text;
						if (this.a(PageCustomPrintSelection.fileAction.edit, ref text))
						{
							num = (short)321585156;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1AD3;
					}
					}
					IL_65:
					if (this.lstUIValue.SelectedItems.Count > 0)
					{
						num = (short)603914243;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_1A11:
					num = (short)130613248;
					num2 = (int)((IntPtr)num);
				}
				IL_1AD3:
				num = (short)1193607168;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x002855D4 File Offset: 0x002837D4
		private void OnDelTemplate(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)748814337;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					Trace.WriteLine(string.Format(RptMgrErrorHandler.b("\udc91ﮕﶗ몙꺝\udd9f", a_), this.lstUIValue.SelectedItem));
					string text = this.lstUIValue.SelectedItem.ToString();
					num = (short)2040135686;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 2:
				{
					num = (short)2129918740;
					short num3 = num;
					num = (short)1423112980;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1676148736;
						if (num != 0)
						{
						}
						if (this.lstUIValue.SelectedItems.Count != 0)
						{
							return;
						}
						break;
					}
					num = (short)904724484;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1268580353;
					if (num != 0)
					{
					}
					this.lstUIValue.Items.Remove(this.lstUIValue.SelectedItem);
					num = (short)1000865799;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_276;
				case 5:
					num = (short)1430192136;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
				{
					string text;
					if (this.a(PageCustomPrintSelection.fileAction.del, ref text))
					{
						num = (short)531496963;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1EC;
				}
				case 7:
					goto IL_1EC;
				case 8:
					if (System.Windows.MessageBox.Show(AppResources.Are_You_Sure_Remove_Selected_Template_From_List, AppResources.Confirm_Deleting, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
					{
						num = (short)1924136960;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_14D;
				}
				IL_52:
				if (this.lstUIValue.SelectedItems.Count > 0)
				{
					num = (short)60030981;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return;
				IL_1EC:
				num = (short)1492582402;
				num2 = (int)((IntPtr)num);
			}
			IL_14D:
			num = (short)515375104;
			short num4 = num;
			return;
			IL_276:
			this.btnPrtDelTpl.IsEnabled = false;
			this.btnPrtEditTpl.IsEnabled = false;
			this.btnPrtPreview.IsEnabled = false;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0028585C File Offset: 0x00283A5C
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1796380046;
			short num2 = num;
			num = (short)2005439886;
			switch (num2 == num)
			{
			}
			num = (short)250806273;
			if (num != 0)
			{
			}
			num = (short)934739968;
			if (num != 0)
			{
			}
			num = (short)1145765888;
			short num3 = num;
			A_1.CanExecute = true;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00285910 File Offset: 0x00283B10
		private void OnHelp(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num;
			try
			{
				num = (short)1805535216;
				short num2 = num;
				num = (short)307316720;
				switch (num2 == num)
				{
				}
				num = (short)1214644225;
				if (num != 0)
				{
				}
				num = (short)1962344448;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("ꪈ뮊릌붎ꎒ꒔ꆖﾘ", a_));
			}
			catch (Exception)
			{
			}
			num = (short)509476864;
			short num3 = num;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x002859F0 File Offset: 0x00283BF0
		internal bool BuildCustomPrintSelection()
		{
			short num = (short)1209925632;
			switch (num)
			{
			default:
			{
				num = (short)686555136;
				short num2 = num;
				num = (short)527892481;
				if (num != 0)
				{
				}
				bool result = true;
				this.lstUIValue.Items.Clear();
				IEnumerator<IAcpRecordset> enumerator = FeatureManager.Features.GetEnumerator();
				try
				{
					num = (short)457244672;
					int num3 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CF;
							}
							continue;
						case 1:
						{
							System.Windows.Controls.ListViewItem listViewItem;
							IAcpRecordset acpRecordset;
							listViewItem.Content = acpRecordset.UIName;
							this.lstUIValue.Items.Add(listViewItem);
							num = (short)1317666819;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1834549253;
								num3 = (int)((IntPtr)num);
								continue;
							}
							IAcpRecordset acpRecordset = enumerator.Current;
							System.Windows.Controls.ListViewItem listViewItem = new System.Windows.Controls.ListViewItem();
							num = (short)1384579078;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1A0;
						case 5:
							num = (short)1751056388;
							num3 = (int)((IntPtr)num);
							continue;
						case 6:
						{
							IAcpRecordset acpRecordset;
							if (!acpRecordset.HiddenStatic)
							{
								num = (short)1390215169;
								num3 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_113:
						num = (short)1850408962;
						num3 = (int)((IntPtr)num);
						continue;
						IL_CF:
						goto IL_113;
					}
					IL_1A0:;
				}
				finally
				{
					num = (short)302495151;
					short num4 = num;
					num = (short)1098626479;
					int num3;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_245:
						num = (short)973668352;
						num3 = (int)((IntPtr)num);
						break;
					default:
						num = (short)516096000;
						if (num != 0)
						{
						}
						num = (short)1254490114;
						num3 = (int)((IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_25A;
						case 1:
							goto IL_23D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_224;
							}
							continue;
						}
						IL_224:
						if (enumerator == null)
						{
							goto IL_25C;
						}
						num = (short)253886465;
						num3 = (int)((IntPtr)num);
					}
					IL_23D:
					enumerator.Dispose();
					goto IL_245;
					IL_25A:
					IL_25C:;
				}
				this.lstUIValue.Items.SortDescriptions.Add(new SortDescription(ContentControl.ContentProperty.ToString(), ListSortDirection.Ascending));
				return result;
			}
			}
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00285C9C File Offset: 0x00283E9C
		private bool a(IAcpFeatureNode A_0, IAcpFeatureSection A_1)
		{
			short num = (short)1539702784;
			switch (num)
			{
			default:
			{
				bool flag = false;
				IEnumerator<IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)1992097792;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_74;
							}
							continue;
						case 1:
							goto IL_424;
						case 2:
							try
							{
								num = (short)1673789448;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										IAcpField acpField;
										if (acpField.NewParent != acpField.Parent)
										{
											num = (short)1557331969;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										num = (short)1787691023;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										num = (short)725090310;
										num2 = (int)((IntPtr)num);
										continue;
									case 3:
										num = (short)1978925065;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
									{
										IAcpField acpField;
										if (!((AcpFieldBase)acpField).HiddenStatic)
										{
											num = (short)1502806033;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										IAcpField acpField;
										if (acpField.NewParent != null)
										{
											num = (short)359661571;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										goto IL_32B;
									case 7:
									{
										IAcpField acpField;
										if (((AcpFieldBase)acpField).Visible)
										{
											num = (short)1997930506;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_EB;
										}
										continue;
									case 9:
									{
										IAcpField acpField;
										if (acpField.NewParent == A_1)
										{
											num = (short)943521803;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										flag = true;
										num = (short)942931984;
										num2 = (int)((IntPtr)num);
										continue;
									case 11:
										num = (short)1784938496;
										num2 = (int)((IntPtr)num);
										continue;
									case 12:
									{
										IAcpField acpField;
										if (!((AcpFieldBase)acpField).HiddenDynamic)
										{
											num = (short)374210574;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 13:
										num = (short)795738116;
										num2 = (int)((IntPtr)num);
										continue;
									case 14:
										num = (short)2093613063;
										num2 = (int)((IntPtr)num);
										continue;
									case 15:
									{
										IAcpField acpField;
										if (acpField != null)
										{
											num = (short)810156045;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 16:
										goto IL_147;
									case 17:
										num = (short)528678924;
										num2 = (int)((IntPtr)num);
										continue;
									case 18:
									{
										IEnumerator<IAcpField> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)541130754;
											num2 = (int)((IntPtr)num);
											continue;
										}
										IAcpField acpField = enumerator2.Current;
										num = (short)1844903941;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									IL_14C:
									num = (short)1139802130;
									num2 = (int)((IntPtr)num);
									continue;
									IL_EB:
									goto IL_14C;
								}
								IL_147:
								IL_32B:
								goto IL_429;
							}
							finally
							{
								num = (short)1010892802;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									IEnumerator<IAcpField> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_399;
									case 1:
										enumerator2.Dispose();
										num = (short)1748697088;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_362;
										}
										continue;
									}
									IL_362:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1360396289;
									num2 = (int)((IntPtr)num);
								}
								IL_399:;
							}
							break;
							IL_429:
							num = (short)2004221958;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							num = (short)2000617473;
							num2 = (int)((IntPtr)num);
							continue;
						case 4:
							num = (short)902692869;
							num2 = (int)((IntPtr)num);
							continue;
						case 5:
							goto IL_47C;
						case 6:
							if (flag)
							{
								num = (short)1982660611;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)808517636;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IEnumerator<IAcpField> enumerator2 = enumerator.Current.FieldsCollection.GetEnumerator();
							num = (short)55705602;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						IL_39C:
						num = (short)1291190279;
						num2 = (int)((IntPtr)num);
						continue;
						IL_74:
						goto IL_39C;
					}
					IL_424:
					IL_47C:;
				}
				finally
				{
					num = (short)712824559;
					short num3 = num;
					num = (short)1202444015;
					int num2;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_520:
						num = (short)572784640;
						num2 = (int)((IntPtr)num);
						break;
					default:
						num = (short)814612480;
						if (num != 0)
						{
						}
						num = (short)542507010;
						num2 = (int)((IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_535;
						case 1:
							goto IL_518;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4FF;
							}
							continue;
						}
						IL_4FF:
						if (enumerator == null)
						{
							goto IL_55F;
						}
						num = (short)1793392641;
						num2 = (int)((IntPtr)num);
					}
					IL_518:
					enumerator.Dispose();
					goto IL_520;
					IL_535:
					num = (short)119078913;
					if (num != 0)
					{
					}
					IL_55F:;
				}
				num = (short)1802240000;
				short num4 = num;
				return flag;
			}
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0028626C File Offset: 0x0028446C
		private bool a(IAcpFeatureSection A_0)
		{
			bool flag = false;
			IEnumerator<IAcpField> enumerator = A_0.FieldsCollection.GetEnumerator();
			short num;
			try
			{
				num = (short)201129995;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)779223056;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						num = (short)1300103176;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_ED;
					case 3:
						num = (short)189661194;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						goto IL_1CD;
					case 5:
					{
						IAcpField acpField;
						if (acpField != null)
						{
							num = (short)1085014019;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 6:
						if (flag)
						{
							num = (short)1366032398;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					case 7:
					{
						IAcpField acpField;
						if (acpField.NewParent != null)
						{
							num = (short)2074345487;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1CD;
					}
					case 8:
					{
						IAcpField acpField;
						if (acpField.NewParent == acpField.Parent)
						{
							num = (short)680460292;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 9:
						goto IL_205;
					case 10:
					{
						IAcpField acpField;
						if (!((AcpFieldBase)acpField).HiddenStatic)
						{
							num = (short)882245632;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					case 12:
						num = (short)708968468;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						flag = true;
						num = (short)1168637961;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						num = (short)1236860930;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						num = (short)1027145749;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
					{
						IAcpField acpField;
						if (!((AcpFieldBase)acpField).HiddenDynamic)
						{
							num = (short)560005132;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 17:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1558315026;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IAcpField acpField = enumerator.Current;
						num = (short)2128478215;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 18:
						num = (short)612171795;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						goto IL_322;
					case 20:
					{
						IAcpField acpField;
						if (((AcpFieldBase)acpField).Visible)
						{
							num = (short)993787917;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 21:
					{
						IAcpField acpField;
						if (acpField.NewParent != null)
						{
							num = (short)1480654849;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					}
					IL_150:
					num = (short)1307181073;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8D:
					goto IL_150;
					IL_1CD:
					num = (short)316080133;
					num2 = (int)((IntPtr)num);
					continue;
					IL_205:
					num = (short)1219297286;
					num2 = (int)((IntPtr)num);
				}
				IL_ED:
				IL_322:;
			}
			finally
			{
				num = (short)126236919;
				short num3 = num;
				num = (short)862009591;
				int num2;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_3C2:
					num = (short)853475328;
					num2 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1488650240;
					if (num != 0)
					{
					}
					num = (short)1108410370;
					num2 = (int)((IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3D7;
					case 1:
						goto IL_3BA;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3A3;
						}
						continue;
					}
					IL_3A3:
					if (enumerator == null)
					{
						goto IL_3D9;
					}
					num = (short)128843777;
					num2 = (int)((IntPtr)num);
				}
				IL_3BA:
				enumerator.Dispose();
				goto IL_3C2;
				IL_3D7:
				IL_3D9:;
			}
			num = (short)208273409;
			if (num != 0)
			{
			}
			num = (short)1620639744;
			short num4 = num;
			return flag;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x002866C0 File Offset: 0x002848C0
		internal bool BuildFeatureXMLData()
		{
			int a_ = 12;
			short num = (short)811335680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool flag = true;
				bool result;
				try
				{
					XmlTextWriter xmlTextWriter = new XmlTextWriter(Global.XMLFileName, null);
					xmlTextWriter.Formatting = Formatting.Indented;
					xmlTextWriter.Indentation = 3;
					xmlTextWriter.WriteStartDocument();
					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쮎", a_));
					IEnumerator enumerator = this.lstUIValue.SelectedItems.GetEnumerator();
					try
					{
						num = (short)1629028365;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							IAcpRecordset feature;
							int num6;
							int id;
							switch (num2)
							{
							case 0:
							{
								bool flag2;
								if (!flag2)
								{
									num = (short)1663959046;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_487;
							}
							case 1:
								goto IL_1AA;
							case 2:
								if (feature != null)
								{
									num = (short)492699653;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							case 3:
								num = (short)1751121928;
								num2 = (int)((IntPtr)num);
								continue;
							case 4:
								try
								{
									num = (short)451543042;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										IEnumerator<IAcpField> enumerator2;
										IAcpFeatureSection acpFeatureSection;
										XmlWriter xmlWriter;
										string localName;
										string value;
										IAcpFeatureNode acpFeatureNode;
										bool flag6;
										switch (num2)
										{
										case 0:
											goto IL_2888;
										case 1:
											try
											{
												num = (short)984940556;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														num = (short)1857224708;
														num2 = (int)((IntPtr)num);
														continue;
													case 1:
														goto IL_150D;
													case 2:
													{
														bool flag3 = true;
														num = (short)1343291403;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 3:
													{
														if (!enumerator2.MoveNext())
														{
															num = (short)1841889289;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IAcpField acpField = enumerator2.Current;
														num = (short)2106851338;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 4:
													{
														IAcpField acpField;
														if (((AcpFieldBase)acpField).Visible)
														{
															num = (short)462356482;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 5:
													{
														IAcpField acpField;
														if (!((AcpFieldBase)acpField).HiddenDynamic)
														{
															num = (short)1479278592;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 6:
														num = (short)259522568;
														num2 = (int)((IntPtr)num);
														continue;
													case 7:
														num = (short)252968965;
														num2 = (int)((IntPtr)num);
														continue;
													case 8:
													{
														IAcpField acpField;
														if (!((AcpFieldBase)acpField).HiddenStatic)
														{
															num = (short)66256903;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 9:
														goto IL_14F5;
													case 10:
													{
														IAcpField acpField;
														if (acpField != null)
														{
															num = (short)1344077830;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 11:
														goto IL_14F5;
													case 12:
														switch (0)
														{
														case 0:
															goto IL_137E;
														}
														continue;
													}
													IL_1470:
													num = (short)1367998467;
													num2 = (int)((IntPtr)num);
													continue;
													IL_137E:
													goto IL_1470;
													IL_14F5:
													num = (short)1052377089;
													num2 = (int)((IntPtr)num);
												}
												IL_150D:
												goto IL_226C;
											}
											finally
											{
												num = (short)642973696;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_1545;
														}
														continue;
													case 1:
														enumerator2.Dispose();
														num = (short)124649474;
														num2 = (int)((IntPtr)num);
														continue;
													case 2:
														goto IL_157D;
													}
													IL_1545:
													if (enumerator2 == null)
													{
														break;
													}
													num = (short)1601568769;
													num2 = (int)((IntPtr)num);
												}
												IL_157D:;
											}
											break;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_5B9;
											}
											continue;
										case 3:
											goto IL_1934;
										case 4:
											goto IL_210E;
										case 5:
											num = (short)222625801;
											num2 = (int)((IntPtr)num);
											continue;
										case 6:
											if (!(acpFeatureSection.GetType() == typeof(AlertTones)))
											{
												num = (short)1284243482;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										case 7:
											goto IL_2074;
										case 8:
											if (acpFeatureSection.HasVisibleObjects)
											{
												num = (short)1025441797;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_226C;
										case 9:
											if (acpFeatureSection.HasEmbeddedRecset)
											{
												num = (short)292159501;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_21FC;
										case 10:
											Trace.WriteLine(string.Format(RptMgrErrorHandler.b("쪎ﲐﶘﺚ列톞삠캢삤鶦튨鮪킬", a_), acpFeatureSection.EmbeddedRecset.UIName));
											enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
											num = (short)1315045406;
											num2 = (int)((IntPtr)num);
											continue;
										case 11:
											goto IL_286F;
										case 12:
											goto IL_210E;
										case 13:
											num = (short)771096612;
											num2 = (int)((IntPtr)num);
											continue;
										case 14:
											xmlWriter = xmlTextWriter;
											localName = RptMgrErrorHandler.b("쪎ﲐ요\ude96", a_);
											if (!acpFeatureSection.HasEmbeddedRecset)
											{
												goto IL_1C64;
											}
											value = RptMgrErrorHandler.b("\udb8e", a_);
											goto IL_2227;
										case 15:
											goto IL_20EB;
										case 16:
											enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
											num = (short)1317077017;
											num2 = (int)((IntPtr)num);
											continue;
										case 17:
										{
											bool flag4;
											if (flag4)
											{
												num = (short)764805152;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_20EB;
										}
										case 18:
										{
											bool flag4;
											bool flag5;
											if (flag5 || flag4)
											{
												num = (short)967311370;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IEnumerator<IAcpFeatureSection> enumerator3 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
											num = (short)2118844435;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 19:
											try
											{
												num = (short)125566978;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														try
														{
															num = (short)1321730055;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																IAcpField acpField2;
																switch (num2)
																{
																case 0:
																	num = (short)1267138578;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 1:
																{
																	int length = acpField2.ToString().Length;
																	string text = "";
																	text = text.PadLeft(length, '*');
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), text);
																	num = (short)971112485;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 2:
																	if (acpField2.NewParent != acpFeatureSection)
																	{
																		num = (short)1924530200;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_92A;
																case 3:
																	num = (short)1808138257;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 4:
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("즎\udd90햒ﲔﾚ", a_));
																	num = (short)1286078495;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 5:
																	goto IL_A6C;
																case 6:
																	num = (short)337510411;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 7:
																	switch (0)
																	{
																	case 0:
																		goto IL_7BD;
																	}
																	continue;
																case 8:
																{
																	IAcpFeatureSection acpFeatureSection2;
																	if (acpFeatureSection2 == acpFeatureSection)
																	{
																		num = (short)1189543963;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 10:
																	if (acpField2 is AcpListField)
																	{
																		num = (short)1723072553;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9E4;
																case 11:
																	if (!((AcpFieldBase)acpField2).HiddenDynamic)
																	{
																		num = (short)397934626;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 12:
																	if (acpField2 != null)
																	{
																		num = (short)2101280798;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 13:
																	goto IL_10DE;
																case 14:
																	if (((AcpFieldBase)acpField2).Visible)
																	{
																		num = (short)395575299;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 15:
																	try
																	{
																		num = (short)950730762;
																		num2 = (int)((IntPtr)num);
																		for (;;)
																		{
																			ListItem listItem;
																			switch (num2)
																			{
																			case 0:
																				goto IL_C4D;
																			case 1:
																				goto IL_D0C;
																			case 2:
																				num = (short)1844314113;
																				num2 = (int)((IntPtr)num);
																				continue;
																			case 3:
																				xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField2.NewUIName);
																				num = (short)252379141;
																				num2 = (int)((IntPtr)num);
																				continue;
																			case 4:
																				if (!string.IsNullOrEmpty(acpField2.NewUIName))
																				{
																					num = (short)192151555;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField2.UIName);
																				num = (short)2051604480;
																				num2 = (int)((IntPtr)num);
																				continue;
																			case 5:
																				goto IL_C4D;
																			case 6:
																				if (listItem.ItemVisibility)
																				{
																					num = (short)171311113;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				break;
																			case 8:
																			{
																				IEnumerator<ListItem> enumerator4;
																				if (!enumerator4.MoveNext())
																				{
																					num = (short)115802114;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				listItem = enumerator4.Current;
																				num = (short)1497038854;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			case 9:
																				xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("즎\udd90햒ﲔﾚ", a_));
																				num = (short)588644356;
																				num2 = (int)((IntPtr)num);
																				continue;
																			case 10:
																				switch (0)
																				{
																				case 0:
																					goto IL_B5B;
																				}
																				continue;
																			}
																			IL_BA1:
																			num = (short)1725890568;
																			num2 = (int)((IntPtr)num);
																			continue;
																			IL_B5B:
																			goto IL_BA1;
																			IL_C4D:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), listItem.ItemName.ToString().Trim());
																			xmlTextWriter.WriteEndElement();
																			num = (short)1184301063;
																			num2 = (int)((IntPtr)num);
																		}
																		IL_D0C:
																		goto IL_9A2;
																	}
																	finally
																	{
																		num = (short)1045889026;
																		num2 = (int)((IntPtr)num);
																		for (;;)
																		{
																			IEnumerator<ListItem> enumerator4;
																			switch (num2)
																			{
																			case 0:
																				enumerator4.Dispose();
																				num = (short)2006908929;
																				num2 = (int)((IntPtr)num);
																				continue;
																			case 1:
																				goto IL_D7A;
																			case 2:
																				switch (0)
																				{
																				case 0:
																					goto IL_D43;
																				}
																				continue;
																			}
																			IL_D43:
																			if (enumerator4 == null)
																			{
																				break;
																			}
																			num = (short)1428684800;
																			num2 = (int)((IntPtr)num);
																		}
																		IL_D7A:;
																	}
																	goto IL_D7D;
																case 16:
																	num = (short)558497820;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 17:
																	if (!FieldFilters.FilterSpecialFieldInReport(acpField2))
																	{
																		num = (short)968228887;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 18:
																	if (acpField2.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4쾸\udaba풼펾ꃀꇂ꧄ꋆ蓈껊ꏌ뫎飐꟒냔뫖꫘蓚鳜폠헢폤퇦", a_))
																	{
																		num = (short)1488715818;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9E4;
																case 19:
																	if (((AcpListField)acpField2).SerializeItems)
																	{
																		num = (short)242483200;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9E4;
																case 20:
																	goto IL_A6C;
																case 21:
																	if (acpField2.IsMasked)
																	{
																		num = (short)809304065;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	num = (short)1960116250;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 22:
																	num = (short)1360265229;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 23:
																	num = (short)1653866525;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 24:
																	num = (short)1854144521;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 25:
																	num = (short)1806696450;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 26:
																	if (acpField2.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4쾸\udaba풼펾ꃀꇂ꧄ꋆ蓈껊ꏌ뫎飐꟒냔뫖꫘蓚鳜폠헢폤퇦", a_))
																	{
																		num = (short)1814626320;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9A2;
																case 27:
																	goto IL_92A;
																case 28:
																	if (acpField2.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ쮞펠횢쮤첦삨얪쪬잰튲\udcb4\udbb6\ud8b8\ud9ba톼\udabe賀ꛂꯄ닆胈뿊꣌ꋎꋐ賒铔", a_))
																	{
																		num = (short)798752801;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9A2;
																case 29:
																	if (!acpField2.IgnoreOnPrint)
																	{
																		num = (short)1883766788;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 30:
																	num = (short)1838743595;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 31:
																	if (!string.IsNullOrEmpty(acpField2.NewUIName))
																	{
																		num = (short)1204092966;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_D7D;
																case 32:
																	if (acpField2.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ쮞펠횢쮤첦삨얪쪬잰튲\udcb4\udbb6\ud8b8\ud9ba톼\udabe賀ꛂꯄ닆胈뿊꣌ꋎꋐ賒铔", a_))
																	{
																		num = (short)786472;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_9E4;
																case 33:
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), AcpXMLCoreEngLib.convertToArabicFormat(acpField2.ToString()));
																	num = (short)2127822887;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 34:
																	num = (short)1033568270;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 36:
																	if (!enumerator2.MoveNext())
																	{
																		num = (short)1291517974;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	acpField2 = enumerator2.Current;
																	num = (short)971964460;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 37:
																	goto IL_9A2;
																case 38:
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField2.NewUIName);
																	num = (short)1659895828;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 39:
																	goto IL_9A2;
																case 40:
																{
																	IEnumerator<ListItem> enumerator4 = ((AcpListField)acpField2).Items.GetEnumerator();
																	num = (short)76611599;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 41:
																	num = (short)497942547;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 42:
																	num = (short)647036960;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 43:
																	if (!((AcpFieldBase)acpField2).HiddenStatic)
																	{
																		num = (short)245694470;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																case 44:
																	if (acpField2.NewParent != null)
																	{
																		num = (short)1572208665;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	num = (short)1644888072;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_7BD;
																IL_92A:
																num = (short)1605828620;
																num2 = (int)((IntPtr)num);
																continue;
																IL_9A2:
																xmlTextWriter.WriteEndElement();
																num = (short)497352739;
																num2 = (int)((IntPtr)num);
																continue;
																IL_9E4:
																num = (short)1855651861;
																num2 = (int)((IntPtr)num);
																continue;
																IL_A6C:
																num = (short)407044106;
																num2 = (int)((IntPtr)num);
																continue;
																IL_D7D:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField2.UIName);
																num = (short)1603534853;
																num2 = (int)((IntPtr)num);
																continue;
																IL_F34:
																num = (short)1683488804;
																num2 = (int)((IntPtr)num);
																continue;
																IL_7BD:
																goto IL_F34;
															}
															IL_10DE:;
														}
														finally
														{
															num = (short)1153499138;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	enumerator2.Dispose();
																	num = (short)2064842753;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 1:
																	goto IL_114D;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_1113;
																	}
																	continue;
																}
																IL_1113:
																if (enumerator2 == null)
																{
																	break;
																}
																num = (short)1563492352;
																num2 = (int)((IntPtr)num);
															}
															IL_114D:;
														}
														break;
													case 1:
														goto IL_11A8;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_6AF;
														}
														continue;
													case 3:
													{
														IEnumerator<IAcpFeatureSection> enumerator3;
														if (!enumerator3.MoveNext())
														{
															num = (short)662765572;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IAcpFeatureSection acpFeatureSection2 = enumerator3.Current;
														enumerator2 = acpFeatureSection2.FieldsCollection.GetEnumerator();
														num = (short)309067776;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 4:
														num = (short)668336129;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_1150:
													num = (short)1794506755;
													num2 = (int)((IntPtr)num);
													continue;
													IL_6AF:
													goto IL_1150;
												}
												IL_11A8:
												goto IL_20EB;
											}
											finally
											{
												num = (short)2045116418;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IEnumerator<IAcpFeatureSection> enumerator3;
													switch (num2)
													{
													case 0:
														enumerator3.Dispose();
														num = (short)1068695553;
														num2 = (int)((IntPtr)num);
														continue;
													case 1:
														goto IL_1216;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_11DF;
														}
														continue;
													}
													IL_11DF:
													if (enumerator3 == null)
													{
														break;
													}
													num = (short)1320681472;
													num2 = (int)((IntPtr)num);
												}
												IL_1216:;
											}
											goto IL_1219;
										case 20:
											num = (short)1567162383;
											num2 = (int)((IntPtr)num);
											continue;
										case 21:
										{
											int num3;
											if (num3 >= acpFeatureSection.EmbeddedRecset.Count)
											{
												num = (short)580976660;
												num2 = (int)((IntPtr)num);
												continue;
											}
											xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쪎ﲐ\udc94練ﲜ슠욢", a_));
											xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쪎ﲐ\udc94\ude96\udd98", a_), num3.ToString());
											IAcpFeatureNode acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[num3];
											xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쪎ﲐ요滛쾠", a_));
											xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쪎ﲐ펔쒖ﲘ캠춢", a_), acpFeatureNode2.UIName);
											IEnumerator<IAcpFeatureSection> enumerator3 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
											num = (short)1770717219;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 23:
										{
											bool flag3 = false;
											num = (short)1074200583;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 24:
											goto IL_1934;
										case 25:
										{
											try
											{
												num = (short)873398273;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														num = (short)1049821193;
														num2 = (int)((IntPtr)num);
														continue;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_1683;
														}
														continue;
													case 2:
														num = (short)985399300;
														num2 = (int)((IntPtr)num);
														continue;
													case 3:
													{
														IAcpField acpField3;
														if (!((AcpFieldBase)acpField3).HiddenStatic)
														{
															num = (short)2022768640;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 4:
													{
														IAcpField acpField3;
														if (((AcpFieldBase)acpField3).Visible)
														{
															num = (short)571539467;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 5:
													{
														IAcpField acpField3;
														if (acpField3 != null)
														{
															num = (short)741605388;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 6:
														goto IL_180C;
													case 7:
														goto IL_17F2;
													case 8:
													{
														if (!enumerator2.MoveNext())
														{
															num = (short)1704787978;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IAcpField acpField3 = enumerator2.Current;
														num = (short)659030021;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 9:
													{
														IAcpField acpField3;
														if (!((AcpFieldBase)acpField3).HiddenDynamic)
														{
															num = (short)1611399170;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 10:
														goto IL_17F2;
													case 11:
													{
														bool flag5 = true;
														num = (short)725680135;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 12:
														num = (short)1557659651;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_1772:
													num = (short)1265762312;
													num2 = (int)((IntPtr)num);
													continue;
													IL_1683:
													goto IL_1772;
													IL_17F2:
													num = (short)2028601350;
													num2 = (int)((IntPtr)num);
												}
												IL_180C:;
											}
											finally
											{
												num = (short)2143879168;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_1840;
														}
														continue;
													case 1:
														enumerator2.Dispose();
														num = (short)1788149762;
														num2 = (int)((IntPtr)num);
														continue;
													case 2:
														goto IL_1877;
													}
													IL_1840:
													if (enumerator2 == null)
													{
														break;
													}
													num = (short)321388545;
													num2 = (int)((IntPtr)num);
												}
												IL_1877:;
											}
											int num4 = 0;
											num = (short)1730150404;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 26:
										{
											bool flag3 = false;
											bool flag5 = false;
											bool flag4 = false;
											num = (short)1227096072;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 27:
										{
											int num4;
											if (num4 >= acpFeatureSection.EmbeddedRecset.Count)
											{
												num = (short)517406758;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IEnumerator<IAcpFeatureSection> enumerator3 = acpFeatureSection.EmbeddedRecset[num4].FeatureSectionsCollection.GetEnumerator();
											num = (short)583401500;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 28:
										{
											try
											{
												num = (short)516620292;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IAcpFeatureSection acpFeatureSection3;
													switch (num2)
													{
													case 0:
														goto IL_2001;
													case 1:
														try
														{
															num = (short)394526730;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																{
																	IAcpField acpField4;
																	if (((AcpFieldBase)acpField4).Visible)
																	{
																		num = (short)1322319878;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 1:
																{
																	IAcpField acpField4;
																	if (!((AcpFieldBase)acpField4).HiddenDynamic)
																	{
																		num = (short)1501495300;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 2:
																	num = (short)35913729;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 3:
																	num = (short)1425670149;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 4:
																	num = (short)141361152;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 5:
																{
																	IAcpField acpField4;
																	if (!((AcpFieldBase)acpField4).HiddenStatic)
																	{
																		num = (short)1789919234;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 6:
																{
																	bool flag4 = true;
																	num = (short)210960396;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 7:
																	goto IL_1F0A;
																case 8:
																{
																	IAcpField acpField4;
																	if (acpField4 != null)
																	{
																		num = (short)1689583619;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 9:
																	goto IL_1EF2;
																case 10:
																	switch (0)
																	{
																	case 0:
																		goto IL_1D86;
																	}
																	continue;
																case 11:
																{
																	if (!enumerator2.MoveNext())
																	{
																		num = (short)989659145;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IAcpField acpField4 = enumerator2.Current;
																	num = (short)641794056;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 12:
																	goto IL_1EF2;
																}
																IL_1DE5:
																num = (short)435421195;
																num2 = (int)((IntPtr)num);
																continue;
																IL_1D86:
																goto IL_1DE5;
																IL_1EF2:
																num = (short)410910727;
																num2 = (int)((IntPtr)num);
															}
															IL_1F0A:
															break;
														}
														finally
														{
															num = (short)2025979906;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	enumerator2.Dispose();
																	num = (short)906428417;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 1:
																	goto IL_1F7C;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_1F43;
																	}
																	continue;
																}
																IL_1F43:
																if (enumerator2 == null)
																{
																	break;
																}
																num = (short)41549824;
																num2 = (int)((IntPtr)num);
															}
															IL_1F7C:;
														}
														goto IL_1F7F;
													case 2:
													{
														IEnumerator<IAcpFeatureSection> enumerator3;
														if (!enumerator3.MoveNext())
														{
															num = (short)1767440387;
															num2 = (int)((IntPtr)num);
															continue;
														}
														acpFeatureSection3 = enumerator3.Current;
														num = (short)1513619462;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 3:
														goto IL_1FE9;
													case 4:
														switch (0)
														{
														case 0:
															goto IL_1CE4;
														}
														continue;
													case 5:
														goto IL_1F7F;
													case 6:
													{
														bool flag4;
														if (!flag4)
														{
															num = (short)933232645;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_1FE9;
													}
													}
													goto IL_1CE4;
													IL_1F7F:
													enumerator2 = acpFeatureSection3.FieldsCollection.GetEnumerator();
													num = (short)152764417;
													num2 = (int)((IntPtr)num);
													continue;
													IL_1FAA:
													num = (short)880541698;
													num2 = (int)((IntPtr)num);
													continue;
													IL_1CE4:
													goto IL_1FAA;
													IL_1FE9:
													num = (short)1485635584;
													num2 = (int)((IntPtr)num);
												}
												IL_2001:
												goto IL_651;
											}
											finally
											{
												num = (short)516685825;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IEnumerator<IAcpFeatureSection> enumerator3;
													switch (num2)
													{
													case 0:
														goto IL_2071;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_2039;
														}
														continue;
													case 2:
														enumerator3.Dispose();
														num = (short)354746368;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_2039:
													if (enumerator3 == null)
													{
														break;
													}
													num = (short)275644418;
													num2 = (int)((IntPtr)num);
												}
												IL_2071:;
											}
											goto IL_2074;
											IL_651:
											int num4;
											num4++;
											num = (short)1355350028;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 29:
										{
											IEnumerator<IAcpFeatureSection> enumerator5;
											if (!enumerator5.MoveNext())
											{
												num = (short)1962213387;
												num2 = (int)((IntPtr)num);
												continue;
											}
											acpFeatureSection = enumerator5.Current;
											num = (short)310378502;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 30:
										{
											try
											{
												num = (short)336396291;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														num = (short)1520500744;
														num2 = (int)((IntPtr)num);
														continue;
													case 2:
														num = (short)727580676;
														num2 = (int)((IntPtr)num);
														continue;
													case 3:
														switch (0)
														{
														case 0:
															goto IL_19D4;
														}
														continue;
													case 4:
													{
														IAcpField acpField5;
														if (!FieldFilters.FilterSpecialFieldInReport(acpField5))
														{
															num = (short)802947081;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 5:
													{
														IAcpField acpField5;
														if (!((AcpFieldBase)acpField5).HiddenStatic)
														{
															num = (short)165281805;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 6:
													{
														IAcpField acpField5;
														if (((AcpFieldBase)acpField5).Visible)
														{
															num = (short)1259405314;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 7:
													{
														IAcpField acpField5;
														if (acpField5 != null)
														{
															num = (short)598999054;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 8:
														goto IL_1BF0;
													case 9:
													{
														xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\udb8e\udd90햒ﲔﾚ", a_));
														IAcpField acpField5;
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField5.UIName);
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), AcpXMLCoreEngLib.convertToArabicFormat(acpField5.ToString()));
														xmlTextWriter.WriteEndElement();
														num = (short)703791105;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 10:
													{
														IAcpField acpField5;
														if (!((AcpFieldBase)acpField5).HiddenDynamic)
														{
															num = (short)316669964;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 11:
													{
														if (!enumerator2.MoveNext())
														{
															num = (short)350224384;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IAcpField acpField5 = enumerator2.Current;
														num = (short)1068367879;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 12:
														num = (short)2098200582;
														num2 = (int)((IntPtr)num);
														continue;
													case 13:
														num = (short)1942683658;
														num2 = (int)((IntPtr)num);
														continue;
													case 14:
														num = (short)803864581;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_19D6:
													num = (short)881131531;
													num2 = (int)((IntPtr)num);
													continue;
													IL_19D4:
													goto IL_19D6;
												}
												IL_1BF0:
												goto IL_12E5;
											}
											finally
											{
												num = (short)1714814978;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														enumerator2.Dispose();
														num = (short)1228275713;
														num2 = (int)((IntPtr)num);
														continue;
													case 1:
														goto IL_1C61;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_1C28;
														}
														continue;
													}
													IL_1C28:
													if (enumerator2 == null)
													{
														break;
													}
													num = (short)928382976;
													num2 = (int)((IntPtr)num);
												}
												IL_1C61:;
											}
											goto IL_1C64;
											IL_12E5:
											int num3 = 0;
											num = (short)1423573016;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 31:
											goto IL_1219;
										case 32:
											num = (short)666894357;
											num2 = (int)((IntPtr)num);
											continue;
										case 33:
											goto IL_226C;
										case 34:
											if (!this.a(acpFeatureSection))
											{
												num = (short)2055077911;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_2074;
										case 35:
										{
											try
											{
												num = (short)427098115;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														num = (short)2083323906;
														num2 = (int)((IntPtr)num);
														continue;
													case 1:
													{
														IEnumerator<IAcpFeatureSection> enumerator3;
														if (!enumerator3.MoveNext())
														{
															num = (short)508952576;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IAcpFeatureSection acpFeatureSection4 = enumerator3.Current;
														Trace.WriteLine(string.Format(RptMgrErrorHandler.b("쪎ﲐﶘﺚ列쒠삢톤캦욨얪캮\udcb0횲辴첶覸욺", a_), acpFeatureSection4.UIName));
														enumerator2 = acpFeatureSection4.FieldsCollection.GetEnumerator();
														num = (short)1828585476;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 2:
														goto IL_27FE;
													case 3:
														switch (0)
														{
														case 0:
															goto IL_238E;
														}
														continue;
													case 4:
														try
														{
															num = (short)936247313;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																{
																	IAcpField acpField6;
																	if (((AcpFieldBase)acpField6).Visible)
																	{
																		num = (short)1829175301;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 1:
																	num = (short)1706754059;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 2:
																{
																	IAcpField acpField6;
																	if (!FieldFilters.FilterSpecialFieldInReport(acpField6))
																	{
																		num = (short)1320812558;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 3:
																{
																	IAcpField acpField6;
																	if (!((AcpFieldBase)acpField6).HiddenStatic)
																	{
																		num = (short)378142721;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 4:
																{
																	IAcpField acpField6;
																	if (acpField6 != null)
																	{
																		num = (short)1864433677;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 5:
																	num = (short)1587085314;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 6:
																{
																	IAcpField acpField6;
																	int length2 = acpField6.ToString().Length;
																	string text2 = "";
																	text2 = text2.PadLeft(length2, '*');
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), text2);
																	num = (short)760610828;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 7:
																	num = (short)936902656;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 8:
																	goto IL_26E3;
																case 9:
																{
																	if (!enumerator2.MoveNext())
																	{
																		num = (short)34013194;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IAcpField acpField6 = enumerator2.Current;
																	num = (short)622264324;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 10:
																	num = (short)1603141640;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 11:
																{
																	IAcpField acpField6;
																	if (!((AcpFieldBase)acpField6).HiddenDynamic)
																	{
																		num = (short)625213447;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 12:
																	goto IL_2660;
																case 13:
																	num = (short)828964867;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 14:
																{
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\udc8e\udd90햒ﲔﾚ", a_));
																	IAcpField acpField6;
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_), acpField6.UIName);
																	num = (short)1584070674;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 16:
																	goto IL_2660;
																case 17:
																	switch (0)
																	{
																	case 0:
																		goto IL_2405;
																	}
																	continue;
																case 18:
																{
																	IAcpField acpField6;
																	if (acpField6.IsMasked)
																	{
																		num = (short)202178566;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_), AcpXMLCoreEngLib.convertToArabicFormat(acpField6.ToString()));
																	num = (short)418971664;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																}
																IL_24CA:
																num = (short)1760362505;
																num2 = (int)((IntPtr)num);
																continue;
																IL_2405:
																goto IL_24CA;
																IL_2660:
																xmlTextWriter.WriteEndElement();
																num = (short)2062811151;
																num2 = (int)((IntPtr)num);
															}
															IL_26E3:;
														}
														finally
														{
															num = (short)1442709505;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	goto IL_2751;
																case 1:
																	switch (0)
																	{
																	case 0:
																		goto IL_2719;
																	}
																	continue;
																case 2:
																	enumerator2.Dispose();
																	num = (short)706215936;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																IL_2719:
																if (enumerator2 == null)
																{
																	break;
																}
																num = (short)2073755650;
																num2 = (int)((IntPtr)num);
															}
															IL_2751:;
														}
														break;
													}
													IL_2754:
													num = (short)1314717697;
													num2 = (int)((IntPtr)num);
													continue;
													IL_238E:
													goto IL_2754;
												}
												IL_27FE:
												goto IL_20BB;
											}
											finally
											{
												num = (short)335937537;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IEnumerator<IAcpFeatureSection> enumerator3;
													switch (num2)
													{
													case 0:
														goto IL_286C;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_2835;
														}
														continue;
													case 2:
														enumerator3.Dispose();
														num = (short)950075392;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_2835:
													if (enumerator3 == null)
													{
														break;
													}
													num = (short)985726978;
													num2 = (int)((IntPtr)num);
												}
												IL_286C:;
											}
											goto IL_286F;
											IL_20BB:
											xmlTextWriter.WriteEndElement();
											xmlTextWriter.WriteEndElement();
											int num3;
											num3++;
											num = (short)1987379203;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 36:
											if (!acpFeatureSection.EmbeddedRecset.HiddenStatic)
											{
												num = (short)1798242320;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_21FC;
										case 37:
										{
											bool flag3;
											bool flag4;
											bool flag5;
											if (flag3 || flag5 || flag4 || flag6)
											{
												num = (short)972161055;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 38:
											num = (short)1284702241;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_5B9;
										IL_1219:
										Trace.WriteLine(string.Format(RptMgrErrorHandler.b("ﲎﺖ펜ﺞ철욢龤\udca6馨횪", a_), acpFeatureSection.UIName));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\udc8eﺖ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("즎슐", a_), acpFeatureSection.UIName);
										num = (short)897253390;
										num2 = (int)((IntPtr)num);
										continue;
										IL_1580:
										num = (short)1550450717;
										num2 = (int)((IntPtr)num);
										continue;
										IL_5B9:
										goto IL_1580;
										IL_1934:
										num = (short)1337917457;
										num2 = (int)((IntPtr)num);
										continue;
										IL_2074:
										num = (short)782172197;
										num2 = (int)((IntPtr)num);
										continue;
										IL_20EB:
										xmlTextWriter.WriteEndElement();
										num = (short)482213910;
										num2 = (int)((IntPtr)num);
										continue;
										IL_210E:
										num = (short)161153051;
										num2 = (int)((IntPtr)num);
										continue;
										IL_21FC:
										enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
										num = (short)1646395393;
										num2 = (int)((IntPtr)num);
										continue;
										IL_2227:
										xmlWriter.WriteAttributeString(localName, value);
										num = (short)1880031250;
										num2 = (int)((IntPtr)num);
										continue;
										IL_1C64:
										value = RptMgrErrorHandler.b("즎", a_);
										goto IL_2227;
										IL_226C:
										flag6 = this.a(acpFeatureNode, acpFeatureSection);
										num = (short)99221538;
										num2 = (int)((IntPtr)num);
										continue;
										IL_286F:
										num = (short)2002649088;
										num2 = (int)((IntPtr)num);
									}
									IL_2888:
									goto IL_4CC;
								}
								finally
								{
									num = (short)420675585;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										IEnumerator<IAcpFeatureSection> enumerator5;
										switch (num2)
										{
										case 0:
											goto IL_294C;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_28C1;
											}
											continue;
										case 2:
											for (;;)
											{
												enumerator5.Dispose();
												num = (short)622923035;
												short num5 = num;
												num = (short)1055526171;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													goto IL_291E;
												}
											}
											IL_291E:
											num = (short)916586496;
											if (num != 0)
											{
											}
											num = (short)1166802944;
											num2 = (int)((IntPtr)num);
											continue;
										}
										IL_28C1:
										if (enumerator5 == null)
										{
											break;
										}
										num = (short)1804533762;
										num2 = (int)((IntPtr)num);
									}
									IL_294C:;
								}
								goto IL_294F;
								IL_4CC:
								xmlTextWriter.WriteEndElement();
								num6++;
								num = (short)466354190;
								num2 = (int)((IntPtr)num);
								continue;
							case 5:
								goto IL_294F;
							case 6:
								flag = false;
								result = flag;
								num = (short)700907527;
								num2 = (int)((IntPtr)num);
								continue;
							case 7:
								goto IL_24B;
							case 8:
								goto IL_29DB;
							case 9:
								xmlTextWriter.WriteEndElement();
								num = (short)307101708;
								num2 = (int)((IntPtr)num);
								continue;
							case 10:
							{
								if (num6 >= feature.Count)
								{
									num = (short)572653577;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IAcpFeatureNode acpFeatureNode = feature[num6];
								Trace.WriteLine(string.Format(RptMgrErrorHandler.b("ﾐꎘ궜", a_), num6.ToString()));
								xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("욎ﾐ", a_));
								xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욎\ud890힒", a_), num6.ToString());
								IEnumerator<IAcpFeatureSection> enumerator5 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
								num = (short)1127350276;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 11:
								try
								{
									num = (short)662306820;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_3FE;
										case 1:
											goto IL_3FE;
										case 2:
											goto IL_416;
										case 3:
										{
											IAcpRecordset acpRecordset;
											System.Windows.Controls.ListViewItem listViewItem;
											if (acpRecordset.UIName == listViewItem.Content.ToString())
											{
												num = (short)916324357;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_325;
											}
											continue;
										case 5:
										{
											IAcpRecordset acpRecordset;
											Trace.WriteLine(string.Format(RptMgrErrorHandler.b("\udd8e杖ﶘ햚ﲜ쒠馢\udea4鞦풨", a_), acpRecordset.UIName));
											bool flag2 = true;
											id = acpRecordset.RecsetId;
											num = (short)347930624;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 6:
										{
											IEnumerator<IAcpRecordset> enumerator6;
											if (!enumerator6.MoveNext())
											{
												num = (short)1783037953;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IAcpRecordset acpRecordset = enumerator6.Current;
											num = (short)1963458563;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_36C:
										num = (short)140181510;
										num2 = (int)((IntPtr)num);
										continue;
										IL_325:
										goto IL_36C;
										IL_3FE:
										num = (short)1611661314;
										num2 = (int)((IntPtr)num);
									}
									IL_416:
									goto IL_2A7;
								}
								finally
								{
									num = (short)501678082;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										IEnumerator<IAcpRecordset> enumerator6;
										switch (num2)
										{
										case 0:
											goto IL_484;
										case 1:
											enumerator6.Dispose();
											num = (short)734330880;
											num2 = (int)((IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_44D;
											}
											continue;
										}
										IL_44D:
										if (enumerator6 == null)
										{
											break;
										}
										num = (short)1340342273;
										num2 = (int)((IntPtr)num);
									}
									IL_484:;
								}
								goto IL_487;
								IL_2A7:
								num = (short)1167720448;
								num2 = (int)((IntPtr)num);
								continue;
							case 13:
								switch (0)
								{
								case 0:
									goto IL_101;
								}
								continue;
							case 14:
								goto IL_1AA;
							case 15:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1679228931;
									num2 = (int)((IntPtr)num);
									continue;
								}
								System.Windows.Controls.ListViewItem listViewItem = (System.Windows.Controls.ListViewItem)enumerator.Current;
								Trace.WriteLine(string.Format(RptMgrErrorHandler.b("ﺒ궖릘궜", a_), listViewItem.Content));
								id = 0;
								bool flag2 = false;
								IEnumerator<IAcpRecordset> enumerator6 = FeatureManager.Features.GetEnumerator();
								num = (short)1641873419;
								num2 = (int)((IntPtr)num);
								continue;
							}
							}
							goto IL_101;
							IL_1AA:
							num = (short)1877606410;
							num2 = (int)((IntPtr)num);
							continue;
							IL_1EE:
							num = (short)1501102095;
							num2 = (int)((IntPtr)num);
							continue;
							IL_101:
							goto IL_1EE;
							IL_487:
							feature = FeatureManager.GetFeature(id);
							num = (short)1429733378;
							num2 = (int)((IntPtr)num);
							continue;
							IL_294F:
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("즎ﺚ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("즎\udf90", a_), feature.UIName);
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첎ﺐﮔ", a_), feature.Count.ToString());
							num6 = 0;
							num = (short)1372848129;
							num2 = (int)((IntPtr)num);
						}
						IL_24B:
						goto IL_2A75;
						IL_29DB:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_29FA;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_29E7:
							switch (num2)
							{
							case 0:
								goto IL_2A4F;
							case 1:
								if (disposable != null)
								{
									num = (short)677838850;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_2A51;
							case 2:
								disposable.Dispose();
								num = (short)88080384;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_29FA;
						}
						IL_2A4F:
						IL_2A51:
						goto EndFinally_125;
						IL_29FA:
						disposable = (enumerator as IDisposable);
						num = (short)2026110977;
						num2 = (int)((IntPtr)num);
						goto IL_29E7;
						EndFinally_125:;
					}
					xmlTextWriter.WriteEndElement();
					xmlTextWriter.Close();
					goto IL_2A;
				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show(ex.Message);
					flag = false;
					goto IL_2A;
				}
				goto IL_2A75;
				IL_2A:
				num = (short)1271857153;
				if (num != 0)
				{
				}
				return flag;
				IL_2A75:
				num = (short)1882456064;
				short num7 = num;
				return result;
			}
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x002892C4 File Offset: 0x002874C4
		public Window ParenWnd
		{
			set
			{
				short num = (short)923860992;
				short num2 = num;
				num = (short)1691485892;
				short num3 = num;
				num = (short)1117718212;
				switch (num3 == num)
				{
				}
				num = (short)357105665;
				if (num != 0)
				{
				}
				num = (short)866254848;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00289374 File Offset: 0x00287574
		internal bool BuildTemplateFileXMLData(string fileName)
		{
			int a_ = 7;
			short num = (short)1875509248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1661861888;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				bool flag;
				for (;;)
				{
					IL_5A:
					num = (short)1036713985;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (this.a(PageCustomPrintSelection.fileAction.edit, ref fileName))
						{
							num = (short)2070740994;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_131;
					case 1:
						return flag;
					case 2:
						goto IL_12F;
					}
					goto IL_93;
				}
				IL_12F:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_175;
					}
					ReportsSerializeItems reportsSerializeItems;
					int num4;
					for (;;)
					{
						IL_15A:
						switch (num2)
						{
						case 0:
							if (reportsSerializeItems.sField.Count > 0)
							{
								num = (short)402522114;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_74D;
						case 1:
							goto IL_765;
						case 2:
						{
							List<int> list = new List<int>();
							CS$<>8__locals1.lstSectionItemsId = new List<int>();
							CS$<>8__locals1.lstFieldName = new List<string>();
							IAcpField acpField = null;
							Dictionary<string, int>.KeyCollection.Enumerator enumerator = reportsSerializeItems.sField.Keys.GetEnumerator();
							num = (short)1366949891;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 3:
							goto IL_2C1;
						case 4:
							try
							{
								CS$<>8__locals1.tWriter = new XmlTextWriter(Global.XMLFileName, null);
								CS$<>8__locals1.tWriter.Formatting = Formatting.Indented;
								CS$<>8__locals1.tWriter.Indentation = 3;
								CS$<>8__locals1.tWriter.WriteStartDocument();
								CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("캉揄", a_));
								List<int> list;
								list.ForEach(delegate(int featureID)
								{
									int a_2 = 12;
									short num6 = (short)1713111040;
									int num7 = (int)num6;
									switch (num7)
									{
									default:
									{
										switch (0)
										{
										case 0:
											goto IL_58;
										}
										IAcpRecordset feature2;
										for (;;)
										{
											IL_31:
											switch (num7)
											{
											case 0:
												return;
											case 1:
												goto IL_221;
											case 2:
												goto IL_221;
											case 3:
											{
												int num8;
												if (num8 >= feature2.Count)
												{
													num6 = (short)1032257543;
													num7 = (int)((IntPtr)num6);
													continue;
												}
												IAcpFeatureNode acpFeatureNode = feature2[num8];
												Trace.WriteLine(string.Format(RptMgrErrorHandler.b("ﾐꎘ궜", a_2), num8.ToString()));
												CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("욎ﾐ", a_2));
												CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("욎\ud890힒", a_2), num8.ToString());
												IEnumerator<IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
												num6 = (short)1053097989;
												num7 = (int)((IntPtr)num6);
												continue;
											}
											case 4:
												num6 = (short)227082241;
												if (num6 != 0)
												{
												}
												if (feature2 != null)
												{
													num6 = (short)938475526;
													num7 = (int)((IntPtr)num6);
													continue;
												}
												return;
											case 5:
											{
												try
												{
													num6 = (short)790560780;
													num7 = (int)((IntPtr)num6);
													for (;;)
													{
														IAcpFeatureSection acpFeatureSection;
														bool flag2;
														IEnumerator<IAcpField> enumerator3;
														bool flag3;
														bool flag4;
														bool flag5;
														bool flag6;
														IEnumerator<IAcpFeatureSection> enumerator4;
														bool flag7;
														int num11;
														XmlWriter tWriter;
														string localName;
														string value;
														switch (num7)
														{
														case 0:
															num6 = (short)1385431059;
															num7 = (int)((IntPtr)num6);
															continue;
														case 1:
														{
															IEnumerator<IAcpFeatureSection> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num6 = (short)1539899392;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															acpFeatureSection = enumerator2.Current;
															flag2 = false;
															num6 = (short)124583945;
															num7 = (int)((IntPtr)num6);
															continue;
														}
														case 2:
															num6 = (short)521994261;
															num7 = (int)((IntPtr)num6);
															continue;
														case 3:
															enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
															num6 = (short)2028142623;
															num7 = (int)((IntPtr)num6);
															continue;
														case 4:
															num6 = (short)1015152667;
															num7 = (int)((IntPtr)num6);
															continue;
														case 5:
															if (acpFeatureSection.HasVisibleObjects)
															{
																num6 = (short)547618818;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															num6 = (short)1553989676;
															num7 = (int)((IntPtr)num6);
															continue;
														case 6:
															if (acpFeatureSection.EmbeddedRecset.Count > 0)
															{
																num6 = (short)1345519645;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_2B09;
														case 7:
															goto IL_CEC;
														case 8:
															num6 = (short)975306758;
															num7 = (int)((IntPtr)num6);
															continue;
														case 9:
															if (acpFeatureSection.HasEmbeddedRecset)
															{
																num6 = (short)1440677896;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_2B09;
														case 10:
															goto IL_C5B;
														case 11:
															if (flag3 || flag4)
															{
																num6 = (short)1673199652;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_B70;
														case 12:
															switch (0)
															{
															case 0:
																goto IL_371;
															}
															continue;
														case 13:
															num6 = (short)1727070246;
															num7 = (int)((IntPtr)num6);
															continue;
														case 14:
															goto IL_C5B;
														case 15:
															try
															{
																num6 = (short)186253314;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																	{
																		IAcpField acpField2;
																		if (!((AcpFieldBase)acpField2).HiddenDynamic)
																		{
																			num6 = (short)1344667658;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 1:
																		num6 = (short)14680067;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_F08;
																		}
																		continue;
																	case 3:
																		goto IL_10DB;
																	case 4:
																	{
																		IAcpField acpField2;
																		if (acpField2 != null)
																		{
																			num6 = (short)2064318475;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 5:
																		flag5 = true;
																		num6 = (short)293535756;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 6:
																	{
																		IAcpField acpField2;
																		if (!((AcpFieldBase)acpField2).HiddenStatic)
																		{
																			num6 = (short)791871502;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 7:
																		num6 = (short)1424162829;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 8:
																	{
																		if (!enumerator3.MoveNext())
																		{
																			num6 = (short)1752367105;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		IAcpField acpField2 = enumerator3.Current;
																		num6 = (short)880148484;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	case 9:
																	{
																		IAcpField acpField2;
																		if (((AcpFieldBase)acpField2).Visible)
																		{
																			num6 = (short)1007091719;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 10:
																		num6 = (short)1275723785;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 11:
																		num6 = (short)1756889094;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 12:
																		goto IL_F6D;
																	case 13:
																	{
																		IAcpField acpField2;
																		if (CS$<>8__locals1.lstFieldName.Contains(acpField2.Name))
																		{
																			num6 = (short)1418002437;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 14:
																		num6 = (short)298123264;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	IL_1044:
																	num6 = (short)2088042504;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_F08:
																	goto IL_1044;
																}
																IL_F6D:
																IL_10DB:
																goto IL_761;
															}
															finally
															{
																num6 = (short)1846018050;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		enumerator3.Dispose();
																		num6 = (short)1664221185;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 1:
																		goto IL_114B;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_1113;
																		}
																		continue;
																	}
																	IL_1113:
																	if (enumerator3 == null)
																	{
																		break;
																	}
																	num6 = (short)220725248;
																	num7 = (int)((IntPtr)num6);
																}
																IL_114B:;
															}
															goto IL_114E;
														case 16:
															num6 = (short)36372520;
															num7 = (int)((IntPtr)num6);
															continue;
														case 17:
															goto IL_CEC;
														case 18:
															goto IL_2B54;
														case 19:
															goto IL_2C00;
														case 20:
															if (acpFeatureSection.HasEmbeddedRecset)
															{
																num6 = (short)77201412;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_872;
														case 21:
															flag6 = CS$<>8__locals1.lstSectionItemsId.Contains(acpFeatureSection.FeatureSectionId);
															goto IL_2A5F;
														case 22:
															if (!CS$<>8__locals1.<>4__this.a(acpFeatureSection))
															{
																num6 = (short)1901330458;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_2B54;
														case 23:
														{
															int num9;
															if (num9 >= acpFeatureSection.EmbeddedRecset.Count)
															{
																num6 = (short)387710992;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("쪎ﲐ\udc94練ﲜ슠욢", a_2));
															CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("쪎ﲐ\udc94\ude96\udd98", a_2), num9.ToString());
															IAcpFeatureNode acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[num9];
															CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("쪎ﲐ요滛쾠", a_2));
															CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("쪎ﲐ펔쒖ﲘ캠춢", a_2), acpFeatureNode2.UIName);
															enumerator4 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
															num6 = (short)1258094635;
															num7 = (int)((IntPtr)num6);
															continue;
														}
														case 25:
															goto IL_1F8C;
														case 26:
															flag5 = false;
															num6 = (short)266272786;
															num7 = (int)((IntPtr)num6);
															continue;
														case 27:
															if (!acpFeatureSection.EmbeddedRecset.HiddenStatic)
															{
																num6 = (short)385089539;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_872;
														case 28:
															try
															{
																num6 = (short)735576064;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		switch (0)
																		{
																		case 0:
																			goto IL_11AB;
																		}
																		continue;
																	case 1:
																		goto IL_125D;
																	case 2:
																		num6 = (short)1592918022;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 3:
																		for (;;)
																		{
																			flag2 = true;
																			num6 = (short)730144650;
																			short num10 = num6;
																			num6 = (short)1632116618;
																			switch ((num10 == num6) ? 1 : 0)
																			{
																			case 0:
																			case 2:
																				break;
																			default:
																				goto IL_122E;
																			}
																		}
																		IL_122E:
																		num6 = (short)1983447040;
																		if (num6 != 0)
																		{
																		}
																		num6 = (short)2098266113;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 4:
																	{
																		IAcpFeatureSection acpFeatureSection2;
																		if (CS$<>8__locals1.lstSectionItemsId.Contains(acpFeatureSection2.FeatureSectionId))
																		{
																			num6 = (short)279838723;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 5:
																	{
																		if (!enumerator4.MoveNext())
																		{
																			num6 = (short)978714626;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		IAcpFeatureSection acpFeatureSection2 = enumerator4.Current;
																		num6 = (short)1416626184;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	case 6:
																		goto IL_1301;
																	case 7:
																		num6 = (short)324206596;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 8:
																	{
																		IAcpFeatureSection acpFeatureSection2;
																		if (acpFeatureSection2.HasVisibleObjects)
																		{
																			num6 = (short)1301741575;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	}
																	IL_1262:
																	num6 = (short)1166540805;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_11AB:
																	goto IL_1262;
																}
																IL_125D:
																IL_1301:
																goto IL_2B09;
															}
															finally
															{
																num6 = (short)1220542465;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		goto IL_1371;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_1339;
																		}
																		continue;
																	case 2:
																		enumerator4.Dispose();
																		num6 = (short)2027356160;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	IL_1339:
																	if (enumerator4 == null)
																	{
																		break;
																	}
																	num6 = (short)1612120066;
																	num7 = (int)((IntPtr)num6);
																}
																IL_1371:;
															}
															goto IL_1374;
														case 29:
															num6 = (short)2017460257;
															num7 = (int)((IntPtr)num6);
															continue;
														case 30:
															if (flag4)
															{
																num6 = (short)723910697;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_7B5;
														case 31:
															try
															{
																num6 = (short)1560215554;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																	{
																		IAcpField acpField3;
																		if (CS$<>8__locals1.lstFieldName.Contains(acpField3.Name))
																		{
																			num6 = (short)825294858;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 1:
																		num6 = (short)1998585865;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_920;
																		}
																		continue;
																	case 3:
																		goto IL_AFD;
																	case 4:
																	{
																		IAcpField acpField3;
																		if (!((AcpFieldBase)acpField3).HiddenDynamic)
																		{
																			num6 = (short)2133917707;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 5:
																		num6 = (short)938344448;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 6:
																		goto IL_93C;
																	case 7:
																		num6 = (short)1169686532;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 8:
																	{
																		IAcpField acpField3;
																		if (acpField3 != null)
																		{
																			num6 = (short)178716673;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 9:
																	{
																		IAcpField acpField3;
																		if (!((AcpFieldBase)acpField3).HiddenStatic)
																		{
																			num6 = (short)488374279;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 10:
																		flag3 = true;
																		num6 = (short)65542;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 11:
																		num6 = (short)1306460173;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 12:
																		num6 = (short)136052739;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 13:
																	{
																		IAcpField acpField3;
																		if (((AcpFieldBase)acpField3).Visible)
																		{
																			num6 = (short)1220542469;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 14:
																	{
																		if (!enumerator3.MoveNext())
																		{
																			num6 = (short)563478540;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		IAcpField acpField3 = enumerator3.Current;
																		num6 = (short)389283848;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	}
																	IL_941:
																	num6 = (short)708575246;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_920:
																	goto IL_941;
																}
																IL_93C:
																IL_AFD:
																goto IL_1374;
															}
															finally
															{
																num6 = (short)1862533122;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		enumerator3.Dispose();
																		num6 = (short)1161887745;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 1:
																		goto IL_B6D;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_B34;
																		}
																		continue;
																	}
																	IL_B34:
																	if (enumerator3 == null)
																	{
																		break;
																	}
																	num6 = (short)512819200;
																	num7 = (int)((IntPtr)num6);
																}
																IL_B6D:;
															}
															goto IL_B70;
														case 32:
															enumerator4 = acpFeatureSection.EmbeddedRecset[0].FeatureSectionsCollection.GetEnumerator();
															num6 = (short)489226268;
															num7 = (int)((IntPtr)num6);
															continue;
														case 33:
															if (!acpFeatureSection.EmbeddedRecset.HiddenStatic)
															{
																num6 = (short)1928462368;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_2B09;
														case 34:
															if (flag5 || flag3 || flag4 || flag7)
															{
																num6 = (short)705626157;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															break;
														case 35:
															num6 = (short)1614479380;
															num7 = (int)((IntPtr)num6);
															continue;
														case 36:
															Trace.WriteLine(string.Format(RptMgrErrorHandler.b("쪎ﲐﶘﺚ列톞삠캢삤鶦튨鮪킬", a_2), acpFeatureSection.EmbeddedRecset.UIName));
															enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
															num6 = (short)785317930;
															num7 = (int)((IntPtr)num6);
															continue;
														case 37:
															try
															{
																num6 = (short)1351548931;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	IAcpFeatureSection acpFeatureSection3;
																	switch (num7)
																	{
																	case 0:
																		goto IL_1F1A;
																	case 1:
																		num6 = (short)258539520;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 2:
																		try
																		{
																			num6 = (short)94699537;
																			num7 = (int)((IntPtr)num6);
																			for (;;)
																			{
																				switch (num7)
																				{
																				case 0:
																					num6 = (short)478085147;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 1:
																				{
																					IAcpField acpField4;
																					if (!((AcpFieldBase)acpField4).HiddenStatic)
																					{
																						num6 = (short)1339817984;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 2:
																				{
																					IAcpField acpField4;
																					if (acpField4 is AcpListField)
																					{
																						num6 = (short)1508311064;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1D37;
																				}
																				case 4:
																					num6 = (short)1028522021;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 5:
																					try
																					{
																						num6 = (short)1006370816;
																						num7 = (int)((IntPtr)num6);
																						for (;;)
																						{
																							ListItem listItem;
																							switch (num7)
																							{
																							case 0:
																								switch (0)
																								{
																								case 0:
																									goto IL_19F5;
																								}
																								continue;
																							case 1:
																							{
																								IEnumerator<ListItem> enumerator5;
																								if (!enumerator5.MoveNext())
																								{
																									num6 = (short)1682046979;
																									num7 = (int)((IntPtr)num6);
																									continue;
																								}
																								listItem = enumerator5.Current;
																								num6 = (short)945225735;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							}
																							case 3:
																								num6 = (short)685703174;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							case 4:
																								goto IL_1B1D;
																							case 5:
																							{
																								IAcpField acpField4;
																								CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField4.NewUIName);
																								num6 = (short)956891144;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							}
																							case 6:
																								goto IL_1BBF;
																							case 7:
																								if (listItem.ItemVisibility)
																								{
																									num6 = (short)1701838858;
																									num7 = (int)((IntPtr)num6);
																									continue;
																								}
																								break;
																							case 8:
																								goto IL_1B1D;
																							case 9:
																							{
																								IAcpField acpField4;
																								if (!string.IsNullOrEmpty(acpField4.NewUIName))
																								{
																									num6 = (short)1046806533;
																									num7 = (int)((IntPtr)num6);
																									continue;
																								}
																								CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField4.UIName);
																								num6 = (short)188219396;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							}
																							case 10:
																								CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("즎\udd90햒ﲔﾚ", a_2));
																								num6 = (short)1447362569;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							}
																							IL_1A54:
																							num6 = (short)1048772609;
																							num7 = (int)((IntPtr)num6);
																							continue;
																							IL_19F5:
																							goto IL_1A54;
																							IL_1B1D:
																							CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), listItem.ItemName.ToString());
																							CS$<>8__locals1.tWriter.WriteEndElement();
																							num6 = (short)143458306;
																							num7 = (int)((IntPtr)num6);
																						}
																						IL_1BBF:
																						goto IL_1CF2;
																					}
																					finally
																					{
																						num6 = (short)1767112705;
																						num7 = (int)((IntPtr)num6);
																						for (;;)
																						{
																							IEnumerator<ListItem> enumerator5;
																							switch (num7)
																							{
																							case 0:
																								goto IL_1C2F;
																							case 1:
																								switch (0)
																								{
																								case 0:
																									goto IL_1BF7;
																								}
																								continue;
																							case 2:
																								enumerator5.Dispose();
																								num6 = (short)1251344384;
																								num7 = (int)((IntPtr)num6);
																								continue;
																							}
																							IL_1BF7:
																							if (enumerator5 == null)
																							{
																								break;
																							}
																							num6 = (short)1542848514;
																							num7 = (int)((IntPtr)num6);
																						}
																						IL_1C2F:;
																					}
																					goto IL_1C32;
																				case 6:
																					num6 = (short)361889832;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 7:
																				{
																					IAcpField acpField4;
																					IEnumerator<ListItem> enumerator5 = ((AcpListField)acpField4).Items.GetEnumerator();
																					num6 = (short)1486487557;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 8:
																					num6 = (short)1124532245;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 9:
																				{
																					if (!enumerator3.MoveNext())
																					{
																						num6 = (short)1971191814;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					IAcpField acpField4 = enumerator3.Current;
																					num6 = (short)1067319319;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 10:
																					goto IL_1CF2;
																				case 11:
																				{
																					IAcpField acpField4;
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), AcpXMLCoreEngLib.convertToArabicFormat(acpField4.ToString()));
																					num6 = (short)1393819674;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 12:
																					num6 = (short)1031143437;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 13:
																				{
																					IAcpField acpField4;
																					if (acpField4.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ쮞펠횢쮤첦삨얪쪬잰튲\udcb4\udbb6\ud8b8\ud9ba톼\udabe賀ꛂꯄ닆胈뿊꣌ꋎꋐ賒铔", a_2))
																					{
																						num6 = (short)1150681095;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1D37;
																				}
																				case 14:
																				{
																					IAcpField acpField4;
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField4.NewUIName);
																					num6 = (short)421724179;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 15:
																					goto IL_1814;
																				case 16:
																					num6 = (short)56688668;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 17:
																					switch (0)
																					{
																					case 0:
																						goto IL_14B1;
																					}
																					continue;
																				case 18:
																				{
																					IAcpField acpField4;
																					if (acpField4.NewParent != acpFeatureSection)
																					{
																						num6 = (short)731906052;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1814;
																				}
																				case 19:
																					goto IL_1D79;
																				case 20:
																				{
																					IAcpField acpField4;
																					if (CS$<>8__locals1.lstFieldName.Contains(acpField4.Name))
																					{
																						num6 = (short)821624862;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 21:
																				{
																					IAcpField acpField4;
																					if (((AcpFieldBase)acpField4).Visible)
																					{
																						num6 = (short)2013003808;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 22:
																				{
																					IAcpField acpField4;
																					if (((AcpListField)acpField4).SerializeItems)
																					{
																						num6 = (short)877723664;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1D37;
																				}
																				case 23:
																				{
																					IAcpField acpField4;
																					if (acpField4.NewParent != null)
																					{
																						num6 = (short)202571818;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					num6 = (short)210436139;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 24:
																					num6 = (short)873267222;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 25:
																					goto IL_1D79;
																				case 26:
																					goto IL_1CF2;
																				case 27:
																				{
																					IAcpField acpField4;
																					if (!((AcpFieldBase)acpField4).HiddenDynamic)
																					{
																						num6 = (short)1824063496;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 28:
																				{
																					IAcpField acpField4;
																					if (acpField4.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4쾸\udaba풼펾ꃀꇂ꧄ꋆ蓈껊ꏌ뫎飐꟒냔뫖꫘蓚鳜폠헢폤퇦", a_2))
																					{
																						num6 = (short)250609676;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1D37;
																				}
																				case 29:
																				{
																					IAcpField acpField4;
																					if (acpField4.IsMasked)
																					{
																						num6 = (short)1586757670;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					num6 = (short)1276706852;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 30:
																					num6 = (short)310968351;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 31:
																				{
																					IAcpField acpField4;
																					if (!FieldFilters.FilterSpecialFieldInReport(acpField4))
																					{
																						num6 = (short)222560289;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 32:
																					num6 = (short)588513300;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 33:
																					CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("즎\udd90햒ﲔﾚ", a_2));
																					num6 = (short)881262627;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 34:
																				{
																					IAcpField acpField4;
																					if (acpField4 != null)
																					{
																						num6 = (short)1737097260;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 35:
																				{
																					IAcpField acpField4;
																					if (!string.IsNullOrEmpty(acpField4.NewUIName))
																					{
																						num6 = (short)1305346062;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField4.UIName);
																					num6 = (short)1572536345;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 36:
																				{
																					IAcpField acpField4;
																					if (acpField4.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4쾸\udaba풼펾ꃀꇂ꧄ꋆ蓈껊ꏌ뫎飐꟒냔뫖꫘蓚鳜폠헢폤퇦", a_2))
																					{
																						num6 = (short)494534697;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1CF2;
																				}
																				case 38:
																				{
																					IAcpField acpField4;
																					int length = acpField4.ToString().Length;
																					string text2 = "";
																					text2 = text2.PadLeft(length, '*');
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), text2);
																					num6 = (short)2105344010;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 39:
																				{
																					IAcpField acpField4;
																					if (acpField4.Name != RptMgrErrorHandler.b("쮎\uda96ﲘ쮞펠횢쮤첦삨얪쪬잰튲\udcb4\udbb6\ud8b8\ud9ba톼\udabe賀ꛂꯄ닆胈뿊꣌ꋎꋐ賒铔", a_2))
																					{
																						num6 = (short)1697710091;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					goto IL_1CF2;
																				}
																				case 40:
																					goto IL_1E1B;
																				case 41:
																					num6 = (short)1610743847;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 42:
																					goto IL_1C32;
																				case 43:
																					if (acpFeatureSection3 == acpFeatureSection)
																					{
																						num6 = (short)1325203471;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				case 44:
																					num6 = (short)1257177089;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				IL_1612:
																				num6 = (short)1288306697;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_14B1:
																				goto IL_1612;
																				IL_1814:
																				num6 = (short)677445666;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_1C32:
																				num6 = (short)635961362;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_1CF2:
																				CS$<>8__locals1.tWriter.WriteEndElement();
																				num6 = (short)1260584963;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_1D37:
																				num6 = (short)931069981;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_1D79:
																				num6 = (short)166461442;
																				num7 = (int)((IntPtr)num6);
																			}
																			IL_1E1B:
																			break;
																		}
																		finally
																		{
																			num6 = (short)922484737;
																			num7 = (int)((IntPtr)num6);
																			for (;;)
																			{
																				switch (num7)
																				{
																				case 0:
																					goto IL_1E8D;
																				case 1:
																					switch (0)
																					{
																					case 0:
																						goto IL_1E53;
																					}
																					continue;
																				case 2:
																					enumerator3.Dispose();
																					num6 = (short)1737424896;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				IL_1E53:
																				if (enumerator3 == null)
																				{
																					break;
																				}
																				num6 = (short)824508418;
																				num7 = (int)((IntPtr)num6);
																			}
																			IL_1E8D:;
																		}
																		goto IL_1E90;
																	case 3:
																		switch (0)
																		{
																		case 0:
																			goto IL_13D0;
																		}
																		continue;
																	case 4:
																		if (!enumerator4.MoveNext())
																		{
																			num6 = (short)431685633;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		goto IL_1E90;
																	}
																	goto IL_13D0;
																	IL_1E90:
																	acpFeatureSection3 = enumerator4.Current;
																	enumerator3 = acpFeatureSection3.FieldsCollection.GetEnumerator();
																	num6 = (short)1182269442;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_1EC4:
																	num6 = (short)375390212;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_13D0:
																	goto IL_1EC4;
																}
																IL_1F1A:
																goto IL_7B5;
															}
															finally
															{
																num6 = (short)1078198273;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		goto IL_1F89;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_1F51;
																		}
																		continue;
																	case 2:
																		enumerator4.Dispose();
																		num6 = (short)1826226176;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	IL_1F51:
																	if (enumerator4 == null)
																	{
																		break;
																	}
																	num6 = (short)526778370;
																	num7 = (int)((IntPtr)num6);
																}
																IL_1F89:;
															}
															goto Block_17;
														case 38:
															goto IL_761;
														case 39:
															if (num11 >= acpFeatureSection.EmbeddedRecset.Count)
															{
																num6 = (short)1755054093;
																num7 = (int)((IntPtr)num6);
																continue;
															}
															goto IL_29BE;
														case 40:
															goto IL_7B5;
														case 41:
															num6 = (short)1950679063;
															num7 = (int)((IntPtr)num6);
															continue;
														case 42:
														{
															try
															{
																num6 = (short)1917779971;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																	{
																		IAcpField acpField5;
																		if (!((AcpFieldBase)acpField5).HiddenDynamic)
																		{
																			num6 = (short)397279233;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 1:
																		num6 = (short)291831822;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 2:
																	{
																		IAcpField acpField5;
																		if (!((AcpFieldBase)acpField5).HiddenStatic)
																		{
																			num6 = (short)2115829767;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 3:
																		switch (0)
																		{
																		case 0:
																			goto IL_427;
																		}
																		continue;
																	case 4:
																		num6 = (short)1937113104;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 5:
																		num6 = (short)429326338;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 6:
																		goto IL_6B0;
																	case 7:
																		num6 = (short)1628438528;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 8:
																	{
																		IAcpField acpField5;
																		if (!FieldFilters.FilterSpecialFieldInReport(acpField5))
																		{
																			num6 = (short)1247805449;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 9:
																	{
																		CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("\udb8e\udd90햒ﲔﾚ", a_2));
																		IAcpField acpField5;
																		CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField5.UIName);
																		CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), AcpXMLCoreEngLib.convertToArabicFormat(acpField5.ToString()));
																		CS$<>8__locals1.tWriter.WriteEndElement();
																		num6 = (short)442302479;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	case 10:
																	{
																		IAcpField acpField5;
																		if (acpField5 != null)
																		{
																			num6 = (short)19726341;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 11:
																		num6 = (short)1077870600;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 12:
																	{
																		if (!enumerator3.MoveNext())
																		{
																			num6 = (short)372899853;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		IAcpField acpField5 = enumerator3.Current;
																		num6 = (short)876478474;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	case 13:
																		num6 = (short)876085254;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 14:
																	{
																		IAcpField acpField5;
																		if (((AcpFieldBase)acpField5).Visible)
																		{
																			num6 = (short)284557316;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	case 16:
																	{
																		IAcpField acpField5;
																		if (CS$<>8__locals1.lstFieldName.Contains(acpField5.Name))
																		{
																			num6 = (short)956629003;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		break;
																	}
																	}
																	IL_4F9:
																	num6 = (short)130023436;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_427:
																	goto IL_4F9;
																}
																IL_6B0:;
															}
															finally
															{
																num6 = (short)586809346;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		enumerator3.Dispose();
																		num6 = (short)481558529;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 1:
																		goto IL_71D;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_6E5;
																		}
																		continue;
																	}
																	IL_6E5:
																	if (enumerator3 == null)
																	{
																		break;
																	}
																	num6 = (short)1629159424;
																	num7 = (int)((IntPtr)num6);
																}
																IL_71D:;
															}
															int num9 = 0;
															num6 = (short)683474951;
															num7 = (int)((IntPtr)num6);
															continue;
														}
														case 43:
														{
															try
															{
																num6 = (short)1819738116;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																	{
																		if (!enumerator4.MoveNext())
																		{
																			num6 = (short)174391299;
																			num7 = (int)((IntPtr)num6);
																			continue;
																		}
																		IAcpFeatureSection acpFeatureSection4 = enumerator4.Current;
																		Trace.WriteLine(string.Format(RptMgrErrorHandler.b("쪎ﲐﶘﺚ列쒠삢톤캦욨얪캮\udcb0횲辴첶覸욺", a_2), acpFeatureSection4.UIName));
																		enumerator3 = acpFeatureSection4.FieldsCollection.GetEnumerator();
																		num6 = (short)1603534850;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	case 1:
																		goto IL_294A;
																	case 2:
																		try
																		{
																			num6 = (short)167247892;
																			num7 = (int)((IntPtr)num6);
																			for (;;)
																			{
																				switch (num7)
																				{
																				case 1:
																				{
																					IAcpField acpField6;
																					int length2 = acpField6.ToString().Length;
																					string text3 = "";
																					text3 = text3.PadLeft(length2, '*');
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), text3);
																					num6 = (short)632487948;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 2:
																				{
																					IAcpField acpField6;
																					if (!((AcpFieldBase)acpField6).HiddenDynamic)
																					{
																						num6 = (short)136970257;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 3:
																					num6 = (short)1435828226;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 4:
																					goto IL_28BF;
																				case 5:
																					num6 = (short)1391263748;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 6:
																				{
																					IAcpField acpField6;
																					if (CS$<>8__locals1.lstFieldName.Contains(acpField6.Name))
																					{
																						num6 = (short)1421541389;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 7:
																				{
																					CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("\udc8e\udd90햒ﲔﾚ", a_2));
																					IAcpField acpField6;
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("솎ﺒ", a_2), acpField6.UIName);
																					num6 = (short)1983053843;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 8:
																				{
																					IAcpField acpField6;
																					if (((AcpFieldBase)acpField6).Visible)
																					{
																						num6 = (short)1622802448;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 9:
																					goto IL_25C4;
																				case 10:
																				{
																					if (!enumerator3.MoveNext())
																					{
																						num6 = (short)552534021;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					IAcpField acpField6 = enumerator3.Current;
																					num6 = (short)1384644623;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 11:
																				{
																					IAcpField acpField6;
																					if (!((AcpFieldBase)acpField6).HiddenStatic)
																					{
																						num6 = (short)1419771907;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 12:
																					goto IL_25C4;
																				case 13:
																					num6 = (short)1466368014;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 14:
																				{
																					IAcpField acpField6;
																					if (!FieldFilters.FilterSpecialFieldInReport(acpField6))
																					{
																						num6 = (short)1565065223;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 15:
																				{
																					IAcpField acpField6;
																					if (acpField6 != null)
																					{
																						num6 = (short)82313234;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					break;
																				}
																				case 16:
																					num6 = (short)174260230;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 17:
																					num6 = (short)1171128328;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 18:
																					num6 = (short)679870475;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 19:
																				{
																					IAcpField acpField6;
																					if (acpField6.IsMasked)
																					{
																						num6 = (short)696254465;
																						num7 = (int)((IntPtr)num6);
																						continue;
																					}
																					CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98eﾒ", a_2), AcpXMLCoreEngLib.convertToArabicFormat(acpField6.ToString()));
																					num6 = (short)1620967433;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				case 20:
																					switch (0)
																					{
																					case 0:
																						goto IL_257A;
																					}
																					continue;
																				}
																				goto IL_257A;
																				IL_25C4:
																				CS$<>8__locals1.tWriter.WriteEndElement();
																				num6 = (short)1665204224;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_278F:
																				num6 = (short)1699020810;
																				num7 = (int)((IntPtr)num6);
																				continue;
																				IL_257A:
																				goto IL_278F;
																			}
																			IL_28BF:
																			break;
																		}
																		finally
																		{
																			num6 = (short)460455937;
																			num7 = (int)((IntPtr)num6);
																			for (;;)
																			{
																				switch (num7)
																				{
																				case 0:
																					enumerator3.Dispose();
																					num6 = (short)653852674;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				case 1:
																					switch (0)
																					{
																					case 0:
																						goto IL_28F6;
																					}
																					continue;
																				case 2:
																					goto IL_292E;
																				}
																				IL_28F6:
																				if (enumerator3 == null)
																				{
																					break;
																				}
																				num6 = (short)776470528;
																				num7 = (int)((IntPtr)num6);
																			}
																			IL_292E:;
																		}
																		goto IL_2931;
																	case 3:
																		goto IL_2931;
																	case 4:
																		switch (0)
																		{
																		case 0:
																			goto IL_246C;
																		}
																		continue;
																	}
																	IL_24BF:
																	num6 = (short)2018181120;
																	num7 = (int)((IntPtr)num6);
																	continue;
																	IL_246C:
																	goto IL_24BF;
																	IL_2931:
																	num6 = (short)1514799105;
																	num7 = (int)((IntPtr)num6);
																}
																IL_294A:
																goto IL_2A12;
															}
															finally
															{
																num6 = (short)569245697;
																num7 = (int)((IntPtr)num6);
																for (;;)
																{
																	switch (num7)
																	{
																	case 0:
																		enumerator4.Dispose();
																		num6 = (short)141885442;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_2982;
																		}
																		continue;
																	case 2:
																		goto IL_29BB;
																	}
																	IL_2982:
																	if (enumerator4 == null)
																	{
																		break;
																	}
																	num6 = (short)1447755776;
																	num7 = (int)((IntPtr)num6);
																}
																IL_29BB:;
															}
															goto IL_29BE;
															IL_2A12:
															CS$<>8__locals1.tWriter.WriteEndElement();
															CS$<>8__locals1.tWriter.WriteEndElement();
															int num9;
															num9++;
															num6 = (short)1042677777;
															num7 = (int)((IntPtr)num6);
															continue;
														}
														case 44:
															flag6 = false;
															goto IL_2A5F;
														case 45:
															Trace.WriteLine(string.Format(RptMgrErrorHandler.b("ﲎﺖ펜ﺞ철욢龤\udca6馨횪", a_2), acpFeatureSection.UIName));
															CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("\udc8eﺖ", a_2));
															CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("즎슐", a_2), acpFeatureSection.UIName);
															num6 = (short)803864622;
															num7 = (int)((IntPtr)num6);
															continue;
														case 46:
															tWriter = CS$<>8__locals1.tWriter;
															localName = RptMgrErrorHandler.b("쪎ﲐ요\ude96", a_2);
															if (!acpFeatureSection.HasEmbeddedRecset)
															{
																value = RptMgrErrorHandler.b("즎", a_2);
																goto IL_23D0;
															}
															goto IL_114E;
														}
														goto IL_371;
														IL_761:
														IAcpFeatureNode acpFeatureNode;
														flag7 = CS$<>8__locals1.<>4__this.a(acpFeatureNode, acpFeatureSection);
														num6 = (short)2085945366;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_2A5F:
														if (flag6 || flag2)
														{
															num6 = (short)391970851;
															num7 = (int)((IntPtr)num6);
															continue;
														}
														goto IL_761;
														IL_7B5:
														CS$<>8__locals1.tWriter.WriteEndElement();
														num6 = (short)1122238488;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_7DC:
														num6 = (short)2142371841;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_371:
														goto IL_7DC;
														Block_17:
														try
														{
															IL_1F8C:
															num6 = (short)1434189824;
															num7 = (int)((IntPtr)num6);
															for (;;)
															{
																switch (num7)
																{
																case 0:
																	switch (0)
																	{
																	case 0:
																		goto IL_1FD2;
																	}
																	continue;
																case 1:
																	goto IL_22FD;
																case 2:
																	goto IL_235E;
																case 3:
																{
																	if (!enumerator4.MoveNext())
																	{
																		num6 = (short)1424228356;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	IAcpFeatureSection acpFeatureSection5 = enumerator4.Current;
																	num6 = (short)1366294534;
																	num7 = (int)((IntPtr)num6);
																	continue;
																}
																case 4:
																	num6 = (short)877527042;
																	num7 = (int)((IntPtr)num6);
																	continue;
																case 5:
																	try
																	{
																		num6 = (short)1112670222;
																		num7 = (int)((IntPtr)num6);
																		for (;;)
																		{
																			switch (num7)
																			{
																			case 0:
																				goto IL_2223;
																			case 1:
																				num6 = (short)174456845;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 2:
																				goto IL_228B;
																			case 3:
																			{
																				IAcpField acpField7;
																				if (!((AcpFieldBase)acpField7).HiddenStatic)
																				{
																					num6 = (short)1541799937;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				break;
																			}
																			case 4:
																			{
																				IAcpField acpField7;
																				if (((AcpFieldBase)acpField7).Visible)
																				{
																					num6 = (short)168755205;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				break;
																			}
																			case 5:
																				num6 = (short)1353318411;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 6:
																				num6 = (short)1031340034;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 7:
																				num6 = (short)529596420;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 8:
																				num6 = (short)801570819;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 9:
																				flag4 = true;
																				num6 = (short)1708654592;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 10:
																			{
																				if (!enumerator3.MoveNext())
																				{
																					num6 = (short)1165164550;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				IAcpField acpField7 = enumerator3.Current;
																				num6 = (short)1760886796;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			}
																			case 11:
																			{
																				IAcpField acpField7;
																				if (CS$<>8__locals1.lstFieldName.Contains(acpField7.Name))
																				{
																					num6 = (short)1763901449;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				break;
																			}
																			case 12:
																			{
																				IAcpField acpField7;
																				if (acpField7 != null)
																				{
																					num6 = (short)425787400;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				break;
																			}
																			case 13:
																			{
																				IAcpField acpField7;
																				if (!((AcpFieldBase)acpField7).HiddenDynamic)
																				{
																					num6 = (short)26607623;
																					num7 = (int)((IntPtr)num6);
																					continue;
																				}
																				break;
																			}
																			case 14:
																				switch (0)
																				{
																				case 0:
																					goto IL_20B6;
																				}
																				continue;
																			}
																			IL_20B8:
																			num6 = (short)1433272330;
																			num7 = (int)((IntPtr)num6);
																			continue;
																			IL_20B6:
																			goto IL_20B8;
																		}
																		IL_2223:
																		IL_228B:
																		break;
																	}
																	finally
																	{
																		num6 = (short)1552482306;
																		num7 = (int)((IntPtr)num6);
																		for (;;)
																		{
																			switch (num7)
																			{
																			case 0:
																				goto IL_22FA;
																			case 1:
																				enumerator3.Dispose();
																				num6 = (short)2021720064;
																				num7 = (int)((IntPtr)num6);
																				continue;
																			case 2:
																				switch (0)
																				{
																				case 0:
																					goto IL_22C2;
																				}
																				continue;
																			}
																			IL_22C2:
																			if (enumerator3 == null)
																			{
																				break;
																			}
																			num6 = (short)1641611265;
																			num7 = (int)((IntPtr)num6);
																		}
																		IL_22FA:;
																	}
																	goto IL_22FD;
																case 6:
																{
																	if (flag4)
																	{
																		num6 = (short)1069350913;
																		num7 = (int)((IntPtr)num6);
																		continue;
																	}
																	IAcpFeatureSection acpFeatureSection5;
																	enumerator3 = acpFeatureSection5.FieldsCollection.GetEnumerator();
																	num6 = (short)1399783429;
																	num7 = (int)((IntPtr)num6);
																	continue;
																}
																case 7:
																	goto IL_2315;
																}
																IL_2016:
																num6 = (short)115277827;
																num7 = (int)((IntPtr)num6);
																continue;
																IL_1FD2:
																goto IL_2016;
																IL_22FD:
																num6 = (short)1099431943;
																num7 = (int)((IntPtr)num6);
															}
															IL_2315:
															IL_235E:
															goto IL_81E;
														}
														finally
														{
															num6 = (short)826081282;
															num7 = (int)((IntPtr)num6);
															for (;;)
															{
																switch (num7)
																{
																case 0:
																	goto IL_23CD;
																case 1:
																	enumerator4.Dispose();
																	num6 = (short)80740352;
																	num7 = (int)((IntPtr)num6);
																	continue;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_2395;
																	}
																	continue;
																}
																IL_2395:
																if (enumerator4 == null)
																{
																	break;
																}
																num6 = (short)837746689;
																num7 = (int)((IntPtr)num6);
															}
															IL_23CD:;
														}
														goto IL_23D0;
														IL_81E:
														num11++;
														num6 = (short)654966794;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_872:
														enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
														num6 = (short)1405157391;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_B70:
														enumerator4 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
														num6 = (short)1881669669;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_C5B:
														num6 = (short)1677328423;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_CEC:
														num6 = (short)1942749214;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_1374:
														num11 = 0;
														num6 = (short)1393033230;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_23D0:
														tWriter.WriteAttributeString(localName, value);
														num6 = (short)838008843;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_114E:
														value = RptMgrErrorHandler.b("\udb8e", a_2);
														goto IL_23D0;
														IL_29BE:
														enumerator4 = acpFeatureSection.EmbeddedRecset[num11].FeatureSectionsCollection.GetEnumerator();
														num6 = (short)157155353;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_2B09:
														flag5 = false;
														flag3 = false;
														flag4 = false;
														num6 = (short)2099576837;
														num7 = (int)((IntPtr)num6);
														continue;
														IL_2B54:
														num6 = (short)873857058;
														num7 = (int)((IntPtr)num6);
													}
													IL_2C00:
													goto IL_C1;
												}
												finally
												{
													num6 = (short)1310064641;
													num7 = (int)((IntPtr)num6);
													for (;;)
													{
														IEnumerator<IAcpFeatureSection> enumerator2;
														switch (num7)
														{
														case 0:
															enumerator2.Dispose();
															num6 = (short)1899233282;
															num7 = (int)((IntPtr)num6);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_2C37;
															}
															continue;
														case 2:
															goto IL_2C70;
														}
														IL_2C37:
														if (enumerator2 == null)
														{
															break;
														}
														num6 = (short)2011365376;
														num7 = (int)((IntPtr)num6);
													}
													IL_2C70:;
												}
												return;
												IL_C1:
												CS$<>8__locals1.tWriter.WriteEndElement();
												int num8;
												num8++;
												num6 = (short)896401409;
												num7 = (int)((IntPtr)num6);
												continue;
											}
											case 6:
											{
												CS$<>8__locals1.tWriter.WriteStartElement(RptMgrErrorHandler.b("즎ﺚ", a_2));
												CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("즎\udf90", a_2), feature2.UIName);
												CS$<>8__locals1.tWriter.WriteAttributeString(RptMgrErrorHandler.b("첎ﺐﮔ", a_2), feature2.Count.ToString());
												int num8 = 0;
												num6 = (short)703201282;
												num7 = (int)((IntPtr)num6);
												continue;
											}
											case 7:
												CS$<>8__locals1.tWriter.WriteEndElement();
												num6 = (short)702742528;
												num7 = (int)((IntPtr)num6);
												continue;
											}
											goto IL_58;
											IL_221:
											num6 = (short)850198528;
											short num12 = num6;
											num6 = (short)1695481859;
											num7 = (int)((IntPtr)num6);
										}
										return;
										IL_58:
										feature2 = FeatureManager.GetFeature(featureID);
										num6 = (short)905576452;
										num7 = (int)((IntPtr)num6);
										goto IL_31;
									}
									}
								});
								CS$<>8__locals1.tWriter.WriteEndElement();
								CS$<>8__locals1.tWriter.Close();
								goto IL_74D;
							}
							catch (Exception ex)
							{
								System.Windows.MessageBox.Show(ex.Message);
								flag = false;
								goto IL_74D;
							}
							goto Block_5;
						}
						goto IL_175;
						Block_5:
						try
						{
							IL_2C1:
							num = (short)1022689287;
							num2 = (int)((IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									IAcpFeatureSection parent;
									if (!CS$<>8__locals1.lstSectionItemsId.Contains(parent.FeatureSectionId))
									{
										num = (short)1417150489;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5C4;
								}
								case 1:
									if (System.Windows.MessageBox.Show(AppResources.Template_Not_Supported, AppResources.Print_Preview, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
									{
										num = (short)36765712;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 2:
									num = (short)1799880714;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									IAcpRecordset feature;
									string text;
									IAcpField acpField = feature.FieldFromFavoritePath(text, RptMgrErrorHandler.b("횉", a_));
									num = (short)2115502103;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
								{
									Dictionary<string, int>.KeyCollection.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)574029833;
										num2 = (int)((IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									reportsSerializeItems.sField.TryGetValue(text, out num4);
									IAcpRecordset feature = FeatureManager.GetFeature(num4);
									num = (short)1700593676;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
								{
									IAcpField acpField;
									IAcpFeatureSection parent = acpField.Parent;
									IAcpFeatureNode parent2 = parent.Parent;
									IAcpRecordset parentRecset = parent.ParentRecset;
									num = (short)98238485;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									goto IL_71E;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_34F;
									}
									continue;
								case 8:
									goto IL_5C4;
								case 9:
									num = (short)1784479750;
									num2 = (int)((IntPtr)num);
									continue;
								case 10:
									if (Global.printTemplateVersion == 0)
									{
										num = (short)1633681411;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)58130450;
									num2 = (int)((IntPtr)num);
									continue;
								case 11:
									goto IL_4C6;
								case 12:
								{
									IAcpRecordset feature;
									if (feature != null)
									{
										num = (short)1335099394;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									IAcpField acpField;
									if (acpField != null)
									{
										num = (short)973144069;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)1950679041;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 14:
									goto IL_577;
								case 15:
								{
									List<int> list;
									list.Add(num4);
									num = (short)1408565262;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 16:
									flag = false;
									result = flag;
									num = (short)1768226836;
									num2 = (int)((IntPtr)num);
									continue;
								case 17:
								{
									IAcpField acpField;
									CS$<>8__locals1.lstFieldName.Add(acpField.Name);
									num = (short)1601568792;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 18:
									if (Global.printTemplateVersion == 1)
									{
										num = (short)1540423699;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_4C6;
								case 19:
								{
									IAcpRecordset feature;
									string text;
									IAcpField acpField = feature.FieldFromFavoritePath(text, RptMgrErrorHandler.b("ㆉ", a_));
									num = (short)1701773323;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 20:
									goto IL_520;
								case 21:
								{
									List<int> list;
									if (!list.Contains(num4))
									{
										num = (short)708050959;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_577;
								}
								case 22:
								{
									IAcpField acpField;
									if (!CS$<>8__locals1.lstFieldName.Contains(acpField.Name))
									{
										num = (short)1913126929;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 23:
									goto IL_4C6;
								case 25:
								{
									IAcpFeatureSection parent;
									CS$<>8__locals1.lstSectionItemsId.Add(parent.FeatureSectionId);
									num = (short)701956104;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_354:
								num = (short)2070282244;
								num2 = (int)((IntPtr)num);
								continue;
								IL_34F:
								goto IL_354;
								IL_4C6:
								num = (short)1031864333;
								num2 = (int)((IntPtr)num);
								continue;
								IL_577:
								num = (short)2076508160;
								num2 = (int)((IntPtr)num);
								continue;
								IL_5C4:
								num = (short)1339490326;
								num2 = (int)((IntPtr)num);
							}
							IL_520:
							return result;
							IL_71E:;
						}
						finally
						{
							Dictionary<string, int>.KeyCollection.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						num = (short)1719140356;
						num2 = (int)((IntPtr)num);
						continue;
						IL_74D:
						num = (short)1212416001;
						num2 = (int)((IntPtr)num);
					}
					IL_765:
					return flag;
					IL_175:
					FileStream fileStream = new FileStream(fileName.ToString(), FileMode.Open, FileAccess.Read);
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					reportsSerializeItems = new ReportsSerializeItems();
					reportsSerializeItems = (ReportsSerializeItems)binaryFormatter.Deserialize(fileStream);
					fileStream.Close();
					num4 = 0;
					num = (short)590479360;
					num2 = (int)((IntPtr)num);
					goto IL_15A;
				}
				catch (Exception ex2)
				{
					System.Windows.MessageBox.Show(ex2.Message);
					flag = false;
				}
				return flag;
				IL_131:
				flag = false;
				goto IL_133;
				IL_93:
				num = (short)863777152;
				short num5 = num;
				num = (short)1738617216;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_133:
					num = (short)1608581121;
					num2 = (int)((IntPtr)num);
					goto IL_5A;
				default:
					num = (short)759103488;
					if (num != 0)
					{
					}
					flag = true;
					num = (short)886505472;
					num2 = (int)((IntPtr)num);
					goto IL_5A;
				}
				break;
			}
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00289B48 File Offset: 0x00287D48
		internal void BuildPrintChoicesReport()
		{
			int a_ = 18;
			short num = (short)529530880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1277373859;
				short num3 = num;
				num = (short)2074750371;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_6B1:
					num = (short)1552941063;
					num2 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1091174400;
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
				int num4;
				int num6;
				Random random;
				bool flag;
				for (;;)
				{
					IL_7D:
					ReportViewer reportViewer;
					switch (num2)
					{
					case 0:
						goto IL_661;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_217;
							}
							for (;;)
							{
								IL_1D8:
								switch (num2)
								{
								case 0:
									if (File.Exists(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_)))
									{
										num = (short)352780290;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5AE;
								case 1:
									reportViewer.Owner = this.b;
									num = (short)1301086214;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
								{
									FileAttributes attributes = File.GetAttributes(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_));
									File.SetAttributes(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_), attributes & ~FileAttributes.ReadOnly);
									attributes = File.GetAttributes(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_));
									num = (short)1563033605;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 3:
									if (File.Exists(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_)))
									{
										num = (short)1787756554;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3E7;
								case 4:
									goto IL_44E;
								case 5:
								{
									FileAttributes attributes;
									if (attributes.ToString().Equals(RptMgrErrorHandler.b("\udb94ﲜ", a_)))
									{
										num = (short)1878917129;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5AE;
								}
								case 6:
									goto IL_353;
								case 7:
									reportViewer.usrInpDia.Close();
									num = (short)2131427332;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									goto IL_3E7;
								case 9:
									try
									{
										File.Delete(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_));
										goto IL_5AE;
									}
									catch (Exception ex)
									{
										Console.WriteLine(string.Concat(new string[]
										{
											RptMgrErrorHandler.b("킔뾞얠욢즤슦\udda8슪쎬좮", a_),
											Global.usrTempDirPath,
											RptMgrErrorHandler.b("솔ﲘﺚ쮜쒠풢쮦욨\udcaa삮튰욲\ud8b4튶ힸ쾺", a_),
											num4.ToString(),
											RptMgrErrorHandler.b("뮔", a_),
											ex.ToString()
										}));
										return;
									}
									goto IL_353;
								case 10:
									File.SetAttributes(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_), FileAttributes.ReadOnly);
									num = (short)390463496;
									num2 = (int)((IntPtr)num);
									continue;
								case 11:
									if (this.b != null)
									{
										num = (short)1590558721;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_353;
								case 12:
									if (reportViewer.usrInpDia != null)
									{
										num = (short)2141126663;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_44E;
								case 13:
									goto IL_5C6;
								}
								goto IL_217;
								IL_353:
								reportViewer.ShowDialog();
								num = (short)103612428;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3E7:
								num = (short)923598859;
								num2 = (int)((IntPtr)num);
								continue;
								IL_44E:
								num = (short)155254784;
								num2 = (int)((IntPtr)num);
								continue;
								IL_5AE:
								num = (short)152305677;
								num2 = (int)((IntPtr)num);
							}
							IL_5C6:
							return;
							IL_217:
							reportViewer.RptViewer.Focus();
							num = (short)977928195;
							num2 = (int)((IntPtr)num);
							goto IL_1D8;
						}
						catch (Exception ex2)
						{
							Console.WriteLine(RptMgrErrorHandler.b("킔뾞얠욢즤슦\udda8슪쎬좮醰", a_) + Global.XMLFileName + RptMgrErrorHandler.b("떔", a_) + ex2.ToString());
							return;
						}
						goto Block_4;
					case 2:
						goto IL_110;
					case 3:
						if (File.Exists(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_)))
						{
							goto IL_6B1;
						}
						goto IL_C9;
					case 4:
						goto IL_110;
					case 5:
					{
						num = (short)750714880;
						short num5 = num;
						num = (short)167247873;
						if (num != 0)
						{
						}
						if (num6 >= 100)
						{
							num = (short)1632174080;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num4 += random.Next(12345);
						num6++;
						num = (short)1153695746;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						if (flag)
						{
							num = (short)795213825;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_604;
					}
					goto IL_A4;
					IL_C9:
					reportViewer = new ReportViewer(reportType.Choices, Global.XMLFileName, num4, ref flag);
					num = (short)151715846;
					num2 = (int)((IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_604:
						File.Delete(Global.usrTempDirPath + RptMgrErrorHandler.b("즔쎖ﺚ즞좠욢튤얨쒪\udaac\udeb0킲살\udab6\udcb8햺즼", a_) + num4.ToString() + RptMgrErrorHandler.b("뮔", a_));
						goto IL_C9;
					}
					catch (Exception ex3)
					{
						Trace.WriteLine(string.Format(RptMgrErrorHandler.b("Ꞗ", a_), ex3.Message));
						goto IL_C9;
					}
					goto IL_661;
					IL_110:
					num = (short)1348272133;
					num2 = (int)((IntPtr)num);
					continue;
					IL_661:
					num = (short)192675843;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_A4:
				flag = false;
				num4 = 0;
				random = new Random();
				num6 = 0;
				num = (short)1094189060;
				num2 = (int)((IntPtr)num);
				goto IL_7D;
			}
			}
		}

		// Token: 0x04000E50 RID: 3664
		private ArrayList a = new ArrayList();

		// Token: 0x04000E51 RID: 3665
		private Window b;

		// Token: 0x02000242 RID: 578
		private enum fileAction
		{
			// Token: 0x04000E62 RID: 3682
			display,
			// Token: 0x04000E63 RID: 3683
			edit,
			// Token: 0x04000E64 RID: 3684
			del
		}

		// Token: 0x02000243 RID: 579
		public enum ItemType
		{
			// Token: 0x04000E66 RID: 3686
			Parent,
			// Token: 0x04000E67 RID: 3687
			Child,
			// Token: 0x04000E68 RID: 3688
			GrandChild
		}
	}
}
