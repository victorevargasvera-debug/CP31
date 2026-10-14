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
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using Microsoft.Win32;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.Utilites;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x02000245 RID: 581
	public partial class PageSelectPrintItems : PageFunction<string>
	{
		// Token: 0x06001CF6 RID: 7414 RVA: 0x00003FE9 File Offset: 0x000021E9
		internal PageSelectPrintItems()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0028D454 File Offset: 0x0028B654
		private void InitializeData(object A_0, EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)1808334854;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (this.tvSelected.Items.Count == 0)
					{
						num2 = (short)1592066052;
						num = (int)((IntPtr)num2);
						continue;
					}
					this.btnRemSelectedItems.IsEnabled = true;
					num2 = (short)881131523;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_74;
				case 3:
					num2 = (short)448987137;
					if (num2 != 0)
					{
					}
					goto IL_74;
				case 4:
					goto IL_6F;
				case 5:
					return;
				case 6:
				{
					num2 = (short)588185600;
					short num3 = num2;
					num2 = (short)1392776358;
					short num4 = num2;
					num2 = (short)69670054;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)1513291776;
						if (num2 != 0)
						{
						}
						Keyboard.Focus(this);
						num2 = (short)2104885253;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
				IL_6F:
				this.btnSave.IsEnabled = false;
				this.btnSaveAs.IsEnabled = false;
				this.btnRemSelectedItems.IsEnabled = false;
				num2 = (short)1216217090;
				num = (int)((IntPtr)num2);
				continue;
				IL_74:
				num2 = (short)476839936;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_2C:
			this.a();
			num2 = (short)417267713;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0028D634 File Offset: 0x0028B834
		private void a()
		{
			int a_ = 3;
			short num = (short)2039676928;
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
				string text;
				int num3;
				string text2;
				BitmapImage bitmapImage;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						text = text.Substring(0, num3);
						num = (short)401276932;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1390823180;
						short num4 = num;
						num = (short)976701196;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E0;
						default:
							goto IL_124;
						}
						break;
					}
					case 2:
						goto IL_1E0;
					case 3:
						if (num3 > 0)
						{
							num = (short)1065418752;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_166;
					case 4:
						goto IL_166;
					case 5:
						if (File.Exists(text2))
						{
							num = (short)712048640;
							short num5 = num;
							num = (short)876150786;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_50;
					IL_166:
					text2 = text + RptMgrErrorHandler.b("憎ﲍ좓ﾕﮙﮛﮝﲟ쪡솣장첧쾩\udeab肭絛", a_);
					num = (short)108658693;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1E0:
					bitmapImage.BeginInit();
					bitmapImage.UriSource = new Uri(text2);
					bitmapImage.EndInit();
					this.imgMotologo.Source = bitmapImage;
					num = (short)172687361;
					num2 = (int)((IntPtr)num);
				}
				IL_124:
				num = (short)1649999872;
				if (num != 0)
				{
				}
				num = (short)325582849;
				if (num != 0)
				{
				}
				return;
				IL_50:
				bitmapImage = new BitmapImage();
				text2 = null;
				text = AppDomain.CurrentDomain.BaseDirectory;
				num3 = text.IndexOf(RptMgrErrorHandler.b("킋", a_));
				num = (short)352387075;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0028D84C File Offset: 0x0028BA4C
		internal void OnSelItemsCancel(object sender, RoutedEventArgs e)
		{
			short num = (short)1266013622;
			short num2 = num;
			num = (short)1311233462;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1748566016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)137101312;
			if (num != 0)
			{
			}
			num = (short)161546241;
			if (num != 0)
			{
			}
			((Window)base.Parent).Close();
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0028D908 File Offset: 0x0028BB08
		internal void OnSaveAs(object sender, RoutedEventArgs e)
		{
			short num = (short)1361510400;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)876150785;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					((Window)base.Parent).Close();
					num = (short)1395731291;
					short num3 = num;
					num = (short)1079192411;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						num = (short)72024064;
						if (num != 0)
						{
						}
						num = (short)1224015873;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_57;
				IL_63:
				num = (short)560332800;
				short num4 = num;
				num = (short)1696268290;
				num2 = (int)((IntPtr)num);
				continue;
				IL_57:
				if (this.a(PageSelectPrintItems.serializeAction.saveAs))
				{
					goto IL_63;
				}
				break;
			}
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0028DA2C File Offset: 0x0028BC2C
		internal void OnSave(object sender, RoutedEventArgs e)
		{
			short num = (short)769589248;
			int num2 = (int)((IntPtr)num);
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
					return;
				case 2:
				{
					num = (short)597819392;
					short num3 = num;
					((Window)base.Parent).Close();
					num = (short)1706537951;
					short num4 = num;
					num = (short)367899615;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num = (short)533659649;
						if (num != 0)
						{
						}
						num = (short)1374289920;
						if (num != 0)
						{
						}
						num = (short)2081751041;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_31;
				IL_3D:
				num = (short)436862978;
				num2 = (int)((IntPtr)num);
				continue;
				IL_31:
				if (this.a(PageSelectPrintItems.serializeAction.save))
				{
					goto IL_3D;
				}
				break;
			}
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0028DB54 File Offset: 0x0028BD54
		private bool a(PageSelectPrintItems.serializeAction A_0)
		{
			int a_ = 12;
			short num = (short)1088094208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_100;
				}
				string text;
				string usrPrntTemplateDir;
				bool result;
				for (;;)
				{
					IL_31:
					SaveFileDialog saveFileDialog;
					bool flag;
					bool? flag2;
					bool flag3;
					bool flag4;
					string b;
					string b2;
					switch (num2)
					{
					case 0:
						Trace.WriteLine(string.Format(RptMgrErrorHandler.b("즎ﾒ\ud996ꖞ\udaa0鎢\ud8a4", a_), this.tvAvailable.Tag));
						text = this.tvAvailable.Tag.ToString();
						num = (short)1295122478;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						saveFileDialog.FileName += RptMgrErrorHandler.b("ꆎ璉", a_);
						text = saveFileDialog.FileName;
						num = (short)716832772;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						if (Global.usrLastSavedContainer.Contains(text))
						{
							num = (short)1473708037;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_363;
					case 3:
						if (VersionInfoHelper.IsDFlagExisted(DFlagType.DASTRO))
						{
							num = (short)891551762;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5AE;
					case 4:
						goto IL_29A;
					case 5:
					{
						flag = true;
						num = (short)601817088;
						short num3 = num;
						num = (short)1088618537;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)419627010;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_570;
								case 1:
									goto IL_585;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_531;
									}
									continue;
								case 3:
									Directory.CreateDirectory(usrPrntTemplateDir);
									num = (short)1847984128;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_531:
								if (!Directory.Exists(usrPrntTemplateDir))
								{
									num = (short)697040899;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_570:
								num = (short)1941438465;
								num2 = (int)((IntPtr)num);
							}
							IL_585:
							goto IL_932;
						}
						catch (Exception ex)
						{
							Console.WriteLine(RptMgrErrorHandler.b("쪎杖릘爵삠힢첤즦캨讪\ud9ac쪮\udcb0쎲閴펶킸즺\ud8bc\udcbe뗀곂럄뻆", a_) + ex.Message);
							goto IL_932;
						}
						goto IL_5AE;
						IL_932:
						num = (short)1480392713;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						saveFileDialog = new SaveFileDialog();
						saveFileDialog.Title = AppResources.Save_As;
						saveFileDialog.InitialDirectory = usrPrntTemplateDir;
						num = (short)548470787;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						num = (short)589299714;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						if (Directory.Exists(usrPrntTemplateDir))
						{
							num = (short)152305671;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 10:
						if (File.Exists(this.tvAvailable.Tag.ToString()))
						{
							num = (short)1442775040;
							num2 = (int)((IntPtr)num);
							continue;
						}
						flag2 = saveFileDialog.ShowDialog();
						flag3 = true;
						num = (short)400425007;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						if (text.Length > 0)
						{
							num = (short)74383385;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 12:
						Global.usrLastSavedContainer.Add(text);
						num = (short)291504161;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						if (A_0 <= PageSelectPrintItems.serializeAction.save)
						{
							num = (short)798228512;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 14:
						Global.usrLastSavedContainer.Add(text);
						num = (short)1489567774;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
					{
						num = (short)1081365802;
						short num4 = num;
						num = (short)951932202;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_733;
						default:
							num = (short)18743296;
							if (num != 0)
							{
							}
							if (!flag)
							{
								num = (short)758120462;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_43A;
						}
						break;
					}
					case 16:
						if (Global.usrLastSavedContainer.Count > 0)
						{
							num = (short)73662472;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_363;
					case 17:
						goto IL_1C2;
					case 18:
						saveFileDialog.Filter = AppResources.Vertex_Standard_Template_File_Filter;
						num = (short)1236664342;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						saveFileDialog.FileName += RptMgrErrorHandler.b("ꆎ璉", a_);
						text = saveFileDialog.FileName;
						num = (short)1799815205;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
						{
							num = (short)848035882;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 21:
						if (!text.ToLower().EndsWith(RptMgrErrorHandler.b("ꆎ璉", a_)))
						{
							num = (short)2029846529;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 22:
						goto IL_1C2;
					case 23:
						if (!text.ToLower().EndsWith(RptMgrErrorHandler.b("ꆎ璉", a_)))
						{
							num = (short)2074476563;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 24:
						if (!flag4)
						{
							num = (short)1555628044;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 25:
						result = true;
						num = (short)1679032333;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						num = (short)602865674;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						if (saveFileDialog.InitialDirectory != b)
						{
							num = (short)2032205863;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 28:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_AA1;
							}
							FileAttributes fileAttributes;
							for (;;)
							{
								IL_A6A:
								ReportsSerializeItems reportsSerializeItems;
								IEnumerator enumerator3;
								BinaryFormatter binaryFormatter;
								FileStream fileStream;
								switch (num2)
								{
								case 0:
									num = (short)198770690;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									if (!fileAttributes.ToString().Equals(RptMgrErrorHandler.b("\udd8e\ud896", a_)))
									{
										num = (short)633470981;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_10E7;
								case 2:
									if ((File.GetAttributes(text) & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
									{
										num = (short)251789321;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_C38;
								case 3:
									goto IL_C38;
								case 4:
									File.SetAttributes(text, FileAttributes.Normal);
									num = (short)753795075;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									File.SetAttributes(text, fileAttributes);
									num = (short)327942150;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_10E7;
								case 7:
									try
									{
										num = (short)1707868163;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1916469250;
												num2 = (int)((IntPtr)num);
												continue;
											case 1:
												try
												{
													num = (short)958726147;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator enumerator;
														IEnumerator enumerator2;
														switch (num2)
														{
														case 0:
															try
															{
																num = (short)1169358854;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	RptTreeViewItem rptTreeViewItem;
																	switch (num2)
																	{
																	case 0:
																		goto IL_ECE;
																	case 1:
																		num = (short)1363935232;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 3:
																		goto IL_DB7;
																	case 4:
																		if (!reportsSerializeItems.sField.ContainsKey(rptTreeViewItem.RptPath))
																		{
																			num = (short)1414791175;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_DB7;
																	case 5:
																		if (!enumerator.MoveNext())
																		{
																			num = (short)1871052801;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		rptTreeViewItem = (RptTreeViewItem)enumerator.Current;
																		num = (short)1136001028;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 6:
																		switch (0)
																		{
																		case 0:
																			goto IL_DB2;
																		}
																		continue;
																	case 7:
																	{
																		RptTreeViewItem rptTreeViewItem2;
																		reportsSerializeItems.sField.Add(rptTreeViewItem.RptPath, rptTreeViewItem2.ID);
																		num = (short)1233715203;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	}
																	goto IL_DB2;
																	IL_DB7:
																	Trace.WriteLine(string.Format(RptMgrErrorHandler.b("\udf8eﶔ궖ꮚ", a_), rptTreeViewItem.RptPath));
																	num = (short)503054338;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_E44:
																	num = (short)1691222021;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_DB2:
																	goto IL_E44;
																}
																IL_ECE:
																break;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_EF0;
																}
																IDisposable disposable;
																for (;;)
																{
																	IL_EDD:
																	switch (num2)
																	{
																	case 0:
																		goto IL_F48;
																	case 1:
																		if (disposable != null)
																		{
																			num = (short)1760362498;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_F4A;
																	case 2:
																		disposable.Dispose();
																		num = (short)2047213568;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_EF0;
																}
																IL_F48:
																IL_F4A:
																goto EndFinally_43;
																IL_EF0:
																disposable = (enumerator as IDisposable);
																num = (short)1317404673;
																num2 = (int)((IntPtr)num);
																goto IL_EDD;
																EndFinally_43:;
															}
															goto IL_F4B;
														case 1:
															if (!enumerator2.MoveNext())
															{
																num = (short)1645477892;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_F4B;
														case 2:
															goto IL_F9B;
														case 3:
															switch (0)
															{
															case 0:
																goto IL_D2B;
															}
															continue;
														case 4:
															num = (short)647036930;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IL_D30:
														num = (short)262144001;
														num2 = (int)((IntPtr)num);
														continue;
														IL_D2B:
														goto IL_D30;
														IL_F4B:
														enumerator = ((IEnumerable)((RptTreeViewItem)enumerator2.Current).Items).GetEnumerator();
														num = (short)1463746560;
														num2 = (int)((IntPtr)num);
													}
													IL_F9B:;
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_FBA;
													}
													IDisposable disposable;
													for (;;)
													{
														IL_FA7:
														switch (num2)
														{
														case 0:
															goto IL_100F;
														case 1:
															if (disposable != null)
															{
																num = (short)1795817474;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_1011;
														case 2:
															disposable.Dispose();
															num = (short)1196621824;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_FBA;
													}
													IL_100F:
													IL_1011:
													break;
													IL_FBA:
													IEnumerator enumerator2;
													disposable = (enumerator2 as IDisposable);
													num = (short)1000144897;
													num2 = (int)((IntPtr)num);
													goto IL_FA7;
												}
												break;
											case 2:
												goto IL_106D;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_CB7;
												}
												continue;
											case 4:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)514654208;
													num2 = (int)((IntPtr)num);
													continue;
												}
												RptTreeViewItem rptTreeViewItem2 = (RptTreeViewItem)enumerator3.Current;
												IEnumerator enumerator2 = ((IEnumerable)rptTreeViewItem2.Items).GetEnumerator();
												num = (short)1808662529;
												num2 = (int)((IntPtr)num);
												continue;
											}
											}
											IL_1012:
											num = (short)1209466884;
											num2 = (int)((IntPtr)num);
											continue;
											IL_CB7:
											goto IL_1012;
										}
										IL_106D:
										goto IL_ADE;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_108F;
										}
										IDisposable disposable;
										for (;;)
										{
											IL_107C:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)1720909825;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_10E6;
											case 1:
												disposable.Dispose();
												num = (short)1057095682;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												goto IL_10E4;
											}
											goto IL_108F;
										}
										IL_10E4:
										IL_10E6:
										goto EndFinally_45;
										IL_108F:
										disposable = (enumerator3 as IDisposable);
										num = (short)1952382976;
										num2 = (int)((IntPtr)num);
										goto IL_107C;
										EndFinally_45:;
									}
									goto IL_10E7;
									IL_ADE:
									binaryFormatter.Serialize(fileStream, reportsSerializeItems);
									fileStream.Close();
									num = (short)687538177;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									goto IL_1100;
								case 9:
									fileAttributes = File.GetAttributes(text);
									num = (short)15204363;
									num2 = (int)((IntPtr)num);
									continue;
								case 10:
									if (File.Exists(text))
									{
										num = (short)540278784;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_C38;
								case 11:
									if (!fileAttributes.ToString().Equals(RptMgrErrorHandler.b("솎ﺐ", a_)))
									{
										num = (short)1091239940;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_C38;
								}
								goto IL_AA1;
								IL_C38:
								fileStream = new FileStream(text, FileMode.Create);
								binaryFormatter = new BinaryFormatter();
								reportsSerializeItems = new ReportsSerializeItems();
								enumerator3 = ((IEnumerable)this.tvSelected.Items).GetEnumerator();
								num = (short)697565191;
								num2 = (int)((IntPtr)num);
								continue;
								IL_10E7:
								num = (short)77922312;
								num2 = (int)((IntPtr)num);
							}
							IL_1100:
							return result;
							IL_AA1:
							fileAttributes = FileAttributes.ReadOnly;
							num = (short)1516175370;
							num2 = (int)((IntPtr)num);
							goto IL_A6A;
						}
						catch (Exception ex2)
						{
							result = false;
							MessageBox.Show(ex2.Message);
							return result;
						}
						goto IL_1111;
					case 29:
						if (saveFileDialog.InitialDirectory != b2)
						{
							num = (short)1052770353;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 30:
						num = (short)77856769;
						if (num != 0)
						{
						}
						goto IL_43A;
					case 31:
						goto IL_1111;
					case 32:
						num = (short)1029898280;
						num2 = (int)((IntPtr)num);
						continue;
					case 33:
						goto IL_43A;
					case 34:
						if (this.tvAvailable.Tag != null)
						{
							num = (short)56950829;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9BB;
					case 35:
						goto IL_854;
					case 36:
						text = saveFileDialog.FileName;
						num = (short)963051543;
						num2 = (int)((IntPtr)num);
						continue;
					case 37:
						goto IL_47D;
					case 38:
						if (Global.usrLastSavedContainer.Count > 0)
						{
							num = (short)596508720;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_854;
					case 39:
						num = (short)2008875046;
						num2 = (int)((IntPtr)num);
						continue;
					case 40:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)892534812;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 41:
						goto IL_363;
					case 42:
						text = saveFileDialog.FileName;
						num = (short)769851413;
						num2 = (int)((IntPtr)num);
						continue;
					case 43:
						if (A_0 == PageSelectPrintItems.serializeAction.save)
						{
							num = (short)1434451994;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9BB;
					case 44:
						if (Global.usrLastSavedContainer.Contains(text))
						{
							num = (short)1861550111;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_854;
					case 45:
						num = (short)2109276203;
						num2 = (int)((IntPtr)num);
						continue;
					case 46:
						goto IL_43A;
					case 47:
						if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
						{
							num = (short)1159921700;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 48:
						num = (short)610402348;
						num2 = (int)((IntPtr)num);
						continue;
					case 49:
						goto IL_733;
					}
					goto IL_100;
					IL_1C2:
					saveFileDialog.FilterIndex = 1;
					saveFileDialog.RestoreDirectory = true;
					num = (short)452460578;
					num2 = (int)((IntPtr)num);
					continue;
					IL_29A:
					flag4 = false;
					b = saveFileDialog.FileName.Remove(saveFileDialog.FileName.IndexOf(saveFileDialog.SafeFileName) - 1, saveFileDialog.SafeFileName.Length + 1);
					num = (short)473890843;
					num2 = (int)((IntPtr)num);
					continue;
					IL_363:
					num = (short)637730831;
					num2 = (int)((IntPtr)num);
					continue;
					IL_43A:
					num = (short)870973451;
					num2 = (int)((IntPtr)num);
					continue;
					IL_47D:
					flag = false;
					b2 = saveFileDialog.FileName.Remove(saveFileDialog.FileName.IndexOf(saveFileDialog.SafeFileName) - 1, saveFileDialog.SafeFileName.Length + 1);
					num = (short)516620317;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5AE:
					saveFileDialog.Filter = AppResources.Motorola_template_File_Filter;
					num = (short)1240924177;
					num2 = (int)((IntPtr)num);
					continue;
					IL_733:
					num = (short)1371602960;
					num2 = (int)((IntPtr)num);
					continue;
					IL_854:
					num = (short)982450200;
					num2 = (int)((IntPtr)num);
					continue;
					IL_9BB:
					flag2 = saveFileDialog.ShowDialog();
					flag3 = true;
					num = (short)90963988;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1111:
					flag4 = true;
					num = (short)870842403;
					num2 = (int)((IntPtr)num);
				}
				return result;
				IL_100:
				result = false;
				usrPrntTemplateDir = Global.usrPrntTemplateDir;
				text = "";
				num = (short)248315910;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0028ED10 File Offset: 0x0028CF10
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2117009408;
			short num2 = num;
			num = (short)1372637971;
			short num3 = num;
			num = (short)1207356179;
			switch (num3 == num)
			{
			}
			num = (short)1012858881;
			if (num != 0)
			{
			}
			num = (short)1616969728;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0028EDC4 File Offset: 0x0028CFC4
		private void buttonHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)2131334027;
				short num2 = num;
				num = (short)568103819;
				switch (num2 == num)
				{
				}
				num = (short)1959460864;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("꾋뺍꒏ꂑꚕꦗ겙瀞", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1935671296;
			short num3 = num;
			num = (short)350617601;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0028EEA4 File Offset: 0x0028D0A4
		internal void OnClickAdd(object sender, RoutedEventArgs e)
		{
			short num = (short)175702016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.SortItems(ref this.tvSelected);
						this.btnSave.IsEnabled = true;
						this.btnSaveAs.IsEnabled = true;
						this.btnRemSelectedItems.IsEnabled = true;
						num = (short)862846986;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
					{
						RptTreeViewItem rptTreeViewItem;
						if (rptTreeViewItem == null)
						{
							num = (short)1029373952;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.tvAvailable.ItemContainerGenerator.IndexFromContainer(rptTreeViewItem);
						int itemType = rptTreeViewItem.ItemType;
						num = (short)1889402885;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						num = (short)494534664;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)984743937;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_301;
					case 5:
					{
						int itemType;
						switch (itemType)
						{
						case 0:
						{
							RptTreeViewItem rptTreeViewItem;
							RptTreeViewItem rptTreeViewItem2 = rptTreeViewItem;
							this.c(rptTreeViewItem2);
							this.d(rptTreeViewItem2);
							num = (short)2052128775;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 1:
						{
							RptTreeViewItem rptTreeViewItem;
							RptTreeViewItem rptTreeViewItem2 = (RptTreeViewItem)rptTreeViewItem.Parent;
							RptTreeViewItem rptTreeViewItem3 = rptTreeViewItem;
							this.c(rptTreeViewItem2, rptTreeViewItem3);
							this.e(rptTreeViewItem2, rptTreeViewItem3);
							num = (short)368836614;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 2:
						{
							RptTreeViewItem rptTreeViewItem;
							RptTreeViewItem rptTreeViewItem3 = (RptTreeViewItem)rptTreeViewItem.Parent;
							RptTreeViewItem rptTreeViewItem2 = (RptTreeViewItem)rptTreeViewItem3.Parent;
							RptTreeViewItem gItem = rptTreeViewItem;
							this.RmvFromAvailableTreeItems(rptTreeViewItem2, rptTreeViewItem3, gItem);
							this.AddToSelectedTreeItems(rptTreeViewItem2, rptTreeViewItem3, gItem);
							num = (short)1449656321;
							if (num != 0)
							{
							}
							num = (short)2136408073;
							num2 = (int)((IntPtr)num);
							continue;
						}
						default:
							num = (short)567148547;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_1AB;
					case 7:
						goto IL_1AB;
					case 8:
						goto IL_2FC;
					case 9:
						goto IL_1AB;
					case 10:
						goto IL_2AF;
					}
					goto IL_5B;
					IL_1AB:
					num = (short)1249116164;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_2AF:
				goto IL_301;
				IL_2FC:
				goto IL_105;
				IL_301:
				num = (short)234291200;
				short num3 = num;
				return;
				IL_5B:
				num = (short)504116782;
				short num4 = num;
				num = (short)333395502;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_105:
					MessageBox.Show(AppResources.Invalid_Node_Type_Process_Aborted);
					return;
				default:
				{
					num = (short)1936195584;
					if (num != 0)
					{
					}
					RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
					RptTreeViewItem gItem = new RptTreeViewItem();
					RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
					RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
					rptTreeViewItem = (RptTreeViewItem)this.tvAvailable.SelectedItem;
					num = (short)1691549698;
					num2 = (int)((IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0028F1DC File Offset: 0x0028D3DC
		private void d(RptTreeViewItem A_0)
		{
			short num = (short)2039611392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7D;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					num = (short)322109441;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						IEnumerator enumerator = ((IEnumerable)this.tvSelected.Items).GetEnumerator();
						num = (short)1207042056;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)96796672;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_33F;
					case 2:
						this.a(ref this.tvSelected, A_0.ID);
						num = (short)904855561;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_F2;
					case 4:
						goto IL_36A;
					case 5:
						if (flag)
						{
							num = (short)574685186;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_407;
					case 6:
						if (!flag)
						{
							num = (short)230162439;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F2;
					case 7:
						this.tvSelected.Items.Add(A_0);
						num = (short)2135490563;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)908591104;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_19D;
									}
									continue;
								case 1:
								{
									RptTreeViewItem rptTreeViewItem;
									this.tvSelected.Items.Remove(rptTreeViewItem);
									flag = true;
									num = (short)1282473990;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 2:
								{
									RptTreeViewItem rptTreeViewItem;
									if (rptTreeViewItem.Header.ToString() == A_0.Header.ToString())
									{
										num = (short)2143289345;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)726663173;
										num2 = (int)((IntPtr)num);
										continue;
									}
									RptTreeViewItem rptTreeViewItem = (RptTreeViewItem)enumerator.Current;
									num = (short)1056833538;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									goto IL_27E;
								case 5:
									num = (short)25362436;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_260;
								}
								IL_1F7:
								num = (short)1553399811;
								num2 = (int)((IntPtr)num);
								continue;
								IL_19D:
								goto IL_1F7;
							}
							IL_260:
							goto IL_3CC;
							IL_27E:
							num = (short)740670710;
							short num3 = num;
							num = (short)23903478;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_260;
							default:
								num = (short)1324089344;
								if (num != 0)
								{
								}
								goto IL_3CC;
							}
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2EB;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_2D8:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1280376833;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_33E;
								case 1:
									disposable.Dispose();
									num = (short)1092550658;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_33C;
								}
								goto IL_2EB;
							}
							IL_33C:
							IL_33E:
							goto EndFinally_9;
							IL_2EB:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)845479936;
							num2 = (int)((IntPtr)num);
							goto IL_2D8;
							EndFinally_9:;
						}
						goto IL_33F;
						IL_3CC:
						num = (short)2117009414;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						goto IL_3CA;
					}
					goto IL_7D;
					IL_F2:
					num = (short)1983184901;
					num2 = (int)((IntPtr)num);
					continue;
					IL_33F:
					this.tvSelected.Items.Add(A_0);
					num = (short)604700676;
					num2 = (int)((IntPtr)num);
				}
				IL_36A:
				IL_3CA:
				IL_407:
				this.btnRemSelectedItems.IsEnabled = true;
				return;
				IL_7D:
				num = (short)441778176;
				short num4 = num;
				flag = false;
				num = (short)1780613121;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0028F618 File Offset: 0x0028D818
		private void e(RptTreeViewItem A_0, RptTreeViewItem A_1)
		{
			short num = (short)1086259200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1130561540;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)812777474;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_1C2;
								case 3:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1508704257;
										num2 = (int)((IntPtr)num);
										continue;
									}
									RptTreeViewItem a_ = (RptTreeViewItem)enumerator.Current;
									RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
									this.d(a_, rptTreeViewItem);
									RptTreeViewItem rptTreeViewItem2;
									rptTreeViewItem2.Items.Add(rptTreeViewItem);
									num = (short)826802176;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_12C;
									}
									continue;
								}
								IL_12E:
								num = (short)454819843;
								num2 = (int)((IntPtr)num);
								continue;
								IL_12C:
								goto IL_12E;
							}
							IL_1C2:
							goto IL_A4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1E4;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_1D1:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)666107905;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_23A;
								case 2:
									if (disposable != null)
									{
										num = (short)2083454976;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_23C;
								}
								goto IL_1E4;
							}
							IL_23A:
							IL_23C:
							goto EndFinally_26;
							IL_1E4:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)1051066370;
							num2 = (int)((IntPtr)num);
							goto IL_1D1;
							EndFinally_26:;
						}
						goto Block_4;
					case 1:
						goto IL_883;
					case 2:
						if (!flag)
						{
							num = (short)109117444;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 3:
						num = (short)775159809;
						if (num != 0)
						{
						}
						this.btnRemSelectedItems.IsEnabled = true;
						num = (short)292356097;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
						this.d(A_0, rptTreeViewItem3);
						this.tvSelected.Items.Add(rptTreeViewItem3);
						RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
						this.d(A_1, rptTreeViewItem2);
						rptTreeViewItem3.Items.Add(rptTreeViewItem2);
						IEnumerator enumerator = ((IEnumerable)A_1.Items).GetEnumerator();
						num = (short)1072496640;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						goto IL_23D;
					case 6:
						goto IL_7C6;
					case 7:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)1830748166;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_926;
					case 8:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)269352970;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_888;
					case 9:
						if (!this.btnRemSelectedItems.IsEnabled)
						{
							num = (short)1505034243;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_926;
					case 10:
					{
						IEnumerator enumerator = ((IEnumerable)this.tvSelected.Items).GetEnumerator();
						num = (short)72417285;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_5B;
					IL_A4:
					num = (short)1778581511;
					num2 = (int)((IntPtr)num);
					continue;
					IL_7C6:
					num = (short)100663305;
					num2 = (int)((IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_23D:
						num = (short)1966997512;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							RptTreeViewItem rptTreeViewItem2;
							IEnumerator enumerator2;
							RptTreeViewItem rptTreeViewItem4;
							RptTreeViewItem rptTreeViewItem5;
							switch (num2)
							{
							case 0:
								goto IL_749;
							case 1:
								goto IL_536;
							case 2:
								try
								{
									num = (short)1942683652;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											num = (short)142174711;
											short num3 = num;
											num = (short)162949623;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_5FF;
											default:
												num = (short)1226833920;
												if (num != 0)
												{
												}
												num = (short)183369730;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
										{
											if (!enumerator2.MoveNext())
											{
												goto IL_5FF;
											}
											RptTreeViewItem a_2 = (RptTreeViewItem)enumerator2.Current;
											RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
											this.d(a_2, rptTreeViewItem);
											rptTreeViewItem4.Items.Add(rptTreeViewItem);
											num = (short)2090532867;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 2:
											goto IL_67F;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_59B;
											}
											continue;
										}
										IL_5E0:
										num = (short)1392181249;
										num2 = (int)((IntPtr)num);
										continue;
										IL_59B:
										goto IL_5E0;
										IL_5FF:
										num = (short)2004025344;
										num2 = (int)((IntPtr)num);
									}
									IL_67F:
									goto IL_888;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_6A1;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_68E:
										switch (num2)
										{
										case 0:
											disposable.Dispose();
											num = (short)1411448833;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_6F9;
										case 2:
											if (disposable != null)
											{
												num = (short)1291583488;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_6FB;
										}
										goto IL_6A1;
									}
									IL_6F9:
									IL_6FB:
									goto EndFinally_24;
									IL_6A1:
									disposable = (enumerator2 as IDisposable);
									num = (short)310706178;
									num2 = (int)((IntPtr)num);
									goto IL_68E;
									EndFinally_24:;
								}
								goto IL_6FC;
							case 3:
							{
								IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)643956741;
									num2 = (int)((IntPtr)num);
									continue;
								}
								rptTreeViewItem5 = (RptTreeViewItem)enumerator.Current;
								num = (short)1452605450;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 4:
								try
								{
									num = (short)861798406;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)828899332;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_3F0;
										case 2:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)1195638784;
												num2 = (int)((IntPtr)num);
												continue;
											}
											RptTreeViewItem rptTreeViewItem6 = (RptTreeViewItem)enumerator2.Current;
											num = (short)1351483395;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 3:
										{
											RptTreeViewItem rptTreeViewItem6;
											if (rptTreeViewItem6.Header.ToString() == A_1.Header.ToString())
											{
												num = (short)1249574917;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											goto IL_40E;
										case 5:
										{
											RptTreeViewItem rptTreeViewItem6;
											rptTreeViewItem4 = rptTreeViewItem6;
											num = (short)2074279937;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 6:
											switch (0)
											{
											case 0:
												goto IL_33A;
											}
											continue;
										}
										IL_397:
										num = (short)1430126594;
										num2 = (int)((IntPtr)num);
										continue;
										IL_33A:
										goto IL_397;
									}
									IL_3F0:
									IL_40E:;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_42D;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_41A:
										switch (num2)
										{
										case 0:
											disposable.Dispose();
											num = (short)722010113;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_484;
										case 2:
											if (disposable != null)
											{
												num = (short)1051721728;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_486;
										}
										goto IL_42D;
									}
									IL_484:
									IL_486:
									goto EndFinally_23;
									IL_42D:
									disposable = (enumerator2 as IDisposable);
									num = (short)653393922;
									num2 = (int)((IntPtr)num);
									goto IL_41A;
									EndFinally_23:;
								}
								num = (short)221249542;
								num2 = (int)((IntPtr)num);
								continue;
							case 5:
								num = (short)421920768;
								num2 = (int)((IntPtr)num);
								continue;
							case 6:
								if (rptTreeViewItem4 == null)
								{
									num = (short)1694040073;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_536;
							case 7:
								goto IL_6FC;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_290;
								}
								continue;
							case 9:
								this.d(A_1, rptTreeViewItem2);
								rptTreeViewItem5.Items.Add(rptTreeViewItem2);
								rptTreeViewItem4 = rptTreeViewItem2;
								num = (short)1408892929;
								num2 = (int)((IntPtr)num);
								continue;
							case 10:
								if (!(rptTreeViewItem5.Header.ToString() != A_0.Header.ToString()))
								{
									num = (short)1864105991;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							IL_4C1:
							num = (short)697171971;
							num2 = (int)((IntPtr)num);
							continue;
							IL_290:
							goto IL_4C1;
							IL_536:
							flag = true;
							enumerator2 = ((IEnumerable)A_1.Items).GetEnumerator();
							num = (short)53477378;
							num2 = (int)((IntPtr)num);
							continue;
							IL_6FC:
							rptTreeViewItem2 = new RptTreeViewItem();
							rptTreeViewItem4 = null;
							enumerator2 = ((IEnumerable)rptTreeViewItem5.Items).GetEnumerator();
							num = (short)1358954500;
							num2 = (int)((IntPtr)num);
						}
						IL_749:
						goto IL_888;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_76B;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_758:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)649854977;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								goto IL_7C3;
							case 2:
								if (disposable != null)
								{
									num = (short)546897920;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_7C5;
							}
							goto IL_76B;
						}
						IL_7C3:
						IL_7C5:
						goto EndFinally_25;
						IL_76B:
						IEnumerator enumerator;
						disposable = (enumerator as IDisposable);
						num = (short)124387330;
						num2 = (int)((IntPtr)num);
						goto IL_758;
						EndFinally_25:;
					}
					goto IL_7C6;
					IL_888:
					num = (short)891617282;
					num2 = (int)((IntPtr)num);
				}
				IL_883:
				IL_926:
				num = (short)856686592;
				short num4 = num;
				return;
				IL_5B:
				flag = false;
				num = (short)104988680;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0028FFD8 File Offset: 0x0028E1D8
		internal void AddToSelectedTreeItems(RptTreeViewItem pItem, RptTreeViewItem cItem, RptTreeViewItem gItem)
		{
			short num = (short)675217408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
						this.d(pItem, rptTreeViewItem);
						this.tvSelected.Items.Add(rptTreeViewItem);
						RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
						this.d(cItem, rptTreeViewItem2);
						rptTreeViewItem.Items.Add(rptTreeViewItem2);
						RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
						this.d(gItem, rptTreeViewItem3);
						rptTreeViewItem2.Items.Add(rptTreeViewItem3);
						num = (short)730660873;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						if (!this.btnRemSelectedItems.IsEnabled)
						{
							num = (short)716570626;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_697;
					case 2:
						goto IL_5C0;
					case 3:
						goto IL_5E4;
					case 4:
						if (!flag)
						{
							num = (short)1261043712;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_CD;
					case 5:
						try
						{
							num = (short)1254490119;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								RptTreeViewItem rptTreeViewItem4;
								IEnumerator enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_543;
								case 1:
									if (!flag)
									{
										num = (short)1263861765;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_29C;
								case 3:
									if (!(rptTreeViewItem4.Header.ToString() != pItem.Header.ToString()))
									{
										num = (short)35782660;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 4:
								{
									IEnumerator enumerator = ((IEnumerable)rptTreeViewItem4.Items).GetEnumerator();
									num = (short)739180553;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
								{
									RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
									this.d(cItem, rptTreeViewItem2);
									rptTreeViewItem4.Items.Add(rptTreeViewItem2);
									RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
									this.d(gItem, rptTreeViewItem3);
									rptTreeViewItem2.Items.Add(rptTreeViewItem3);
									flag = true;
									num = (short)194641922;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									if (!enumerator2.MoveNext())
									{
										num = (short)115802120;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_489;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_1DD;
									}
									continue;
								case 8:
									num = (short)1573715968;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									try
									{
										num = (short)338558982;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)537722884;
												num2 = (int)((IntPtr)num);
												continue;
											case 1:
												goto IL_3A2;
											case 2:
											{
												IEnumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1875181568;
													num2 = (int)((IntPtr)num);
													continue;
												}
												RptTreeViewItem rptTreeViewItem5 = (RptTreeViewItem)enumerator.Current;
												num = (short)218628099;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 3:
											{
												RptTreeViewItem rptTreeViewItem5;
												if (rptTreeViewItem5.Header == cItem.Header)
												{
													num = (short)1118502917;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												goto IL_3C0;
											case 5:
											{
												RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
												this.d(gItem, rptTreeViewItem3);
												RptTreeViewItem rptTreeViewItem5;
												rptTreeViewItem5.Items.Add(rptTreeViewItem3);
												flag = true;
												num = (short)1214054401;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 6:
												switch (0)
												{
												case 0:
													goto IL_2E3;
												}
												continue;
											}
											IL_32F:
											num = (short)2057371650;
											num2 = (int)((IntPtr)num);
											continue;
											IL_2E3:
											goto IL_32F;
										}
										IL_3A2:
										IL_3C0:
										goto IL_4EF;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_3E2;
										}
										IDisposable disposable;
										for (;;)
										{
											IL_3CF:
											switch (num2)
											{
											case 0:
												goto IL_41D;
											case 1:
												goto IL_43C;
											case 2:
												if (disposable != null)
												{
													num = (short)69533696;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_43C;
											}
											goto IL_3E2;
											IL_41D:
											disposable.Dispose();
											num = (short)824639489;
											num2 = (int)((IntPtr)num);
											continue;
											IL_43C:
											num = (short)2069411626;
											short num3 = num;
											num = (short)769570602;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_41D;
											default:
												goto IL_473;
											}
										}
										IL_473:
										num = (short)1963065344;
										if (num != 0)
										{
										}
										goto EndFinally_16;
										IL_3E2:
										IEnumerator enumerator;
										disposable = (enumerator as IDisposable);
										num = (short)1938751490;
										num2 = (int)((IntPtr)num);
										goto IL_3CF;
										EndFinally_16:;
									}
									goto IL_489;
									IL_4EF:
									num = (short)634322945;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_20A:
								num = (short)818282502;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1DD:
								goto IL_20A;
								IL_489:
								rptTreeViewItem4 = (RptTreeViewItem)enumerator2.Current;
								num = (short)1755250691;
								num2 = (int)((IntPtr)num);
							}
							IL_29C:
							IL_543:
							goto IL_65B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_565;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_552:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)948174849;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_5BD;
								case 2:
									if (disposable != null)
									{
										num = (short)291569664;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5BF;
								}
								goto IL_565;
							}
							IL_5BD:
							IL_5BF:
							goto EndFinally_17;
							IL_565:
							IEnumerator enumerator2;
							disposable = (enumerator2 as IDisposable);
							num = (short)183107586;
							num2 = (int)((IntPtr)num);
							goto IL_552;
							EndFinally_17:;
						}
						goto IL_5C0;
					case 6:
						num = (short)1960902657;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)2067922950;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_697;
					case 8:
						if (this.tvSelected.Items.Count > 0)
						{
							num = (short)525729802;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_65B;
					case 9:
						goto IL_CD;
					case 10:
					{
						IEnumerator enumerator2 = ((IEnumerable)this.tvSelected.Items).GetEnumerator();
						num = (short)1339817989;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_5A;
					IL_CD:
					num = (short)208732167;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5C0:
					this.btnRemSelectedItems.IsEnabled = true;
					num = (short)1653342211;
					num2 = (int)((IntPtr)num);
					continue;
					IL_65B:
					num = (short)49545220;
					num2 = (int)((IntPtr)num);
				}
				IL_5E4:
				IL_697:
				num = (short)455540736;
				short num4 = num;
				return;
				IL_5A:
				flag = false;
				num = (short)1017905153;
				if (num != 0)
				{
				}
				num = (short)698548232;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x002906DC File Offset: 0x0028E8DC
		private void d(RptTreeViewItem A_0, RptTreeViewItem A_1)
		{
			short num = (short)727449600;
			short num2 = num;
			num = (short)2106281410;
			short num3 = num;
			num = (short)982207938;
			switch (num3 == num)
			{
			}
			num = (short)587268097;
			if (num != 0)
			{
			}
			num = (short)51576832;
			if (num != 0)
			{
			}
			A_1.RptRecordName = A_0.RptRecordName;
			A_1.Header = A_0.Header;
			A_1.ID = A_0.ID;
			A_1.ParentID = A_0.ParentID;
			A_1.ItemType = A_0.ItemType;
			A_1.RptPath = A_0.RptPath;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x002907D0 File Offset: 0x0028E9D0
		private void c(RptTreeViewItem A_0)
		{
			short num = (short)1684954954;
			short num2 = num;
			num = (short)1476878154;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A1:
				num = (short)1244856320;
				num3 = (int)((IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)1784348672;
				short num4 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_7E:
				switch (num3)
				{
				case 0:
					if (this.tvAvailable.Items.Count == 0)
					{
						num = (short)1897791489;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					this.btnAddSelectedItems.IsEnabled = false;
					num = (short)1164050434;
					num3 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_FE;
				}
				goto IL_90;
			}
			IL_FE:
			num = (short)958529537;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)1173028864;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			goto IL_7E;
			IL_90:
			this.tvAvailable.Items.Remove(A_0);
			goto IL_A1;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00290904 File Offset: 0x0028EB04
		private void c(RptTreeViewItem A_0, RptTreeViewItem A_1)
		{
			short num = (short)202047497;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
					if (this.btnAddSelectedItems.IsEnabled)
					{
						num = (short)932970504;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)30474241;
					if (num != 0)
					{
					}
					num = (short)295174144;
					short num3 = num;
					num4 = 0;
					num = (short)1828978690;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 2:
					goto IL_20B;
				case 3:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					rptTreeViewItem.Items.RemoveAt(num5);
					num = (short)1666318347;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 4:
					goto IL_136;
				case 5:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					if (((RptTreeViewItem)rptTreeViewItem.Items.GetItemAt(num5)).Header == A_1.Header)
					{
						num = (short)1134428163;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num5++;
					num = (short)471859215;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					RptTreeViewItem rptTreeViewItem;
					if (!(rptTreeViewItem.Header.ToString() != A_0.Header.ToString()))
					{
						num = (short)1958608908;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_346;
				}
				case 7:
					goto IL_20B;
				case 8:
					this.btnAddSelectedItems.IsEnabled = false;
					num = (short)118947860;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_15;
				case 10:
					num = (short)1936916480;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
				{
					RptTreeViewItem rptTreeViewItem;
					if (rptTreeViewItem.Items.Count == 0)
					{
						num = (short)411500560;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_256;
				}
				case 12:
				{
					int num5 = 0;
					num = (short)886833156;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 13:
				{
					if (this.tvAvailable.Items.Count != 0)
					{
						return;
					}
					num = (short)1956651221;
					short num6 = num;
					num = (short)246882517;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)2090139648;
						if (num != 0)
						{
						}
						num = (short)175636490;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					if (num5 >= rptTreeViewItem.Items.Count)
					{
						num = (short)1361838097;
						num2 = (int)((IntPtr)num);
						continue;
					}
					new RptTreeViewItem();
					num = (short)1904541701;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 15:
					goto IL_136;
				case 16:
					this.tvAvailable.Items.RemoveAt(num4);
					num = (short)921305109;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					goto IL_346;
				case 18:
				{
					if (num4 >= this.tvAvailable.Items.Count)
					{
						num = (short)1533607955;
						num2 = (int)((IntPtr)num);
						continue;
					}
					RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
					rptTreeViewItem = (RptTreeViewItem)this.tvAvailable.Items.GetItemAt(num4);
					num = (short)537853958;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 19:
					goto IL_251;
				case 20:
					goto IL_389;
				case 21:
					goto IL_256;
				}
				goto IL_7D;
				IL_15:
				switch (0)
				{
				case 0:
					IL_7D:
					if (this.tvAvailable.Items.Count <= 0)
					{
						return;
					}
					num = (short)1311047681;
					num2 = (int)((IntPtr)num);
					break;
				}
				continue;
				IL_136:
				num = (short)152698894;
				num2 = (int)((IntPtr)num);
				continue;
				IL_20B:
				num = (short)1031733266;
				num2 = (int)((IntPtr)num);
				continue;
				IL_256:
				num = (short)786235405;
				num2 = (int)((IntPtr)num);
				continue;
				IL_346:
				num4++;
				num = (short)1802371079;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_251:
			return;
			IL_389:;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00290D64 File Offset: 0x0028EF64
		internal void RmvFromAvailableTreeItems(RptTreeViewItem pItem, RptTreeViewItem cItem, RptTreeViewItem gItem)
		{
			short num = (short)773128192;
			switch (num)
			{
			default:
			{
				num = (short)398065669;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_393;
					case 1:
					{
						int num3 = 0;
						num = (short)1355415576;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
					{
						int num3;
						RptTreeViewItem rptTreeViewItem;
						rptTreeViewItem.Items.RemoveAt(num3);
						num = (short)1027407887;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
					{
						RptTreeViewItem rptTreeViewItem;
						if (rptTreeViewItem.Header == cItem.Header)
						{
							num = (short)1823932417;
							num2 = (int)((IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)201457681;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						this.tvAvailable.Items.RemoveAt(num5);
						num = (short)1507852304;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C1;
						}
						continue;
					case 6:
						num = (short)1405091866;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
					{
						RptTreeViewItem rptTreeViewItem2;
						if (!(rptTreeViewItem2.Header.ToString() != pItem.Header.ToString()))
						{
							num = (short)779157523;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_299;
					}
					case 8:
					{
						int num3;
						RptTreeViewItem rptTreeViewItem;
						if (num3 >= rptTreeViewItem.Items.Count)
						{
							num = (short)1775173653;
							num2 = (int)((IntPtr)num);
							continue;
						}
						new RptTreeViewItem();
						num = (short)307560461;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						if (this.tvAvailable.Items.Count == 0)
						{
							num = (short)917307398;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 10:
						this.btnAddSelectedItems.IsEnabled = false;
						num = (short)1789263884;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
					{
						RptTreeViewItem rptTreeViewItem2;
						if (rptTreeViewItem2.Items.Count == 0)
						{
							num = (short)812253188;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_52B;
					}
					case 12:
						goto IL_118;
					case 13:
					{
						int num3;
						RptTreeViewItem rptTreeViewItem;
						if (!(((RptTreeViewItem)rptTreeViewItem.Items.GetItemAt(num3)).Header.ToString() != gItem.Header.ToString()))
						{
							num = (short)319619074;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1238499357;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						goto IL_11D;
					case 15:
					{
						RptTreeViewItem rptTreeViewItem;
						if (rptTreeViewItem.Items.Count == 0)
						{
							num = (short)483917854;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11D;
					}
					case 16:
						goto IL_52B;
					case 17:
						goto IL_34C;
					case 18:
						num5 = 0;
						num = (short)652607510;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
					{
						int num4 = 0;
						num = (short)814678039;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 20:
						goto IL_3DA;
					case 21:
						goto IL_11D;
					case 22:
						goto IL_393;
					case 23:
						goto IL_34C;
					case 24:
					{
						num = (short)1270743040;
						short num6 = num;
						goto IL_2BA;
					}
					case 25:
					{
						if (num5 >= this.tvAvailable.Items.Count)
						{
							num = (short)431161364;
							num2 = (int)((IntPtr)num);
							continue;
						}
						RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
						rptTreeViewItem2 = (RptTreeViewItem)this.tvAvailable.Items.GetItemAt(num5);
						num = (short)1576534023;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 26:
						if (this.btnAddSelectedItems.IsEnabled)
						{
							num = (short)600440842;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 27:
					{
						int num4;
						RptTreeViewItem rptTreeViewItem2;
						if (num4 >= rptTreeViewItem2.Items.Count)
						{
							num = (short)1553727516;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)366953043;
						short num7 = num;
						num = (short)398606931;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3DA;
						default:
						{
							num = (short)1027801088;
							if (num != 0)
							{
							}
							RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
							rptTreeViewItem = (RptTreeViewItem)rptTreeViewItem2.Items.GetItemAt(num4);
							num = (short)1285619715;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 28:
						goto IL_299;
					case 29:
						goto IL_2BA;
					case 30:
					{
						int num4;
						RptTreeViewItem rptTreeViewItem2;
						rptTreeViewItem2.Items.RemoveAt(num4);
						num = (short)640614414;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_C1:
					if (this.tvAvailable.Items.Count > 0)
					{
						num = (short)1655177234;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5F6;
					IL_11D:
					num = (short)754843659;
					num2 = (int)((IntPtr)num);
					continue;
					IL_299:
					num5++;
					num = (short)482410496;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2BA:
					num = (short)756809736;
					num2 = (int)((IntPtr)num);
					continue;
					IL_34C:
					num = (short)79429659;
					num2 = (int)((IntPtr)num);
					continue;
					IL_393:
					num = (short)1199374361;
					num2 = (int)((IntPtr)num);
					continue;
					IL_52B:
					num = (short)40894473;
					num2 = (int)((IntPtr)num);
				}
				IL_118:
				return;
				IL_3DA:
				IL_5F6:
				num = (short)507772929;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00291390 File Offset: 0x0028F590
		internal void OnClickRmv(object sender, RoutedEventArgs e)
		{
			short num = (short)1635188736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				RptTreeViewItem rptTreeViewItem;
				RptTreeViewItem a_;
				RptTreeViewItem rptTreeViewItem2;
				RptTreeViewItem a_2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						if (rptTreeViewItem != null)
						{
							int itemType = rptTreeViewItem.ItemType;
							num = (short)1857748997;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)464093180;
						short num3 = num;
						num = (short)279543804;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_246;
						default:
							num = (short)1138229248;
							if (num != 0)
							{
							}
							num = (short)845742080;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						this.btnSave.IsEnabled = false;
						this.btnSaveAs.IsEnabled = false;
						this.btnRemSelectedItems.IsEnabled = false;
						num = (short)2069626892;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_246;
					case 4:
						goto IL_22E;
					case 5:
					{
						int itemType;
						switch (itemType)
						{
						case 0:
							a_ = rptTreeViewItem;
							this.a(a_);
							this.b(a_);
							num = (short)265224205;
							num2 = (int)((IntPtr)num);
							continue;
						case 1:
							a_ = (RptTreeViewItem)rptTreeViewItem.Parent;
							rptTreeViewItem2 = rptTreeViewItem;
							this.b(a_, rptTreeViewItem2);
							this.a(a_, rptTreeViewItem2);
							num = (short)870580234;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							rptTreeViewItem2 = (RptTreeViewItem)rptTreeViewItem.Parent;
							a_ = (RptTreeViewItem)rptTreeViewItem2.Parent;
							a_2 = rptTreeViewItem;
							this.b(a_, rptTreeViewItem2, a_2);
							this.a(a_, rptTreeViewItem2, a_2);
							num = (short)552271879;
							num2 = (int)((IntPtr)num);
							continue;
						default:
							num = (short)964231179;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)2147287049;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 7:
						goto IL_144;
					case 8:
						goto IL_35A;
					case 9:
						this.SortItems(ref this.tvAvailable);
						num = (short)2119696388;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						goto IL_144;
					case 11:
						num = (short)709754888;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_302;
					case 13:
						goto IL_144;
					}
					goto IL_67;
					IL_144:
					num = (short)1575288838;
					num2 = (int)((IntPtr)num);
					continue;
					IL_22E:
					num = (short)531496963;
					num2 = (int)((IntPtr)num);
					continue;
					IL_246:
					if (this.tvSelected.Items.Count != 0)
					{
						return;
					}
					num = (short)519897089;
					if (num != 0)
					{
					}
					num = (short)13762562;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_302:
				return;
				IL_35A:
				MessageBox.Show(AppResources.Invalid_Node_Type_Process_Aborted);
				return;
				IL_67:
				num = (short)2105475072;
				short num4 = num;
				rptTreeViewItem2 = new RptTreeViewItem();
				a_2 = new RptTreeViewItem();
				a_ = new RptTreeViewItem();
				rptTreeViewItem = new RptTreeViewItem();
				rptTreeViewItem = (RptTreeViewItem)this.tvSelected.SelectedItem;
				num = (short)1910439937;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00291738 File Offset: 0x0028F938
		private void b(RptTreeViewItem A_0)
		{
			short num = (short)1903165440;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
					if (this.tvAvailable.Items.Count > 0)
					{
						num = (short)1951072263;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
				{
					IEnumerator enumerator = ((IEnumerable)this.tvAvailable.Items).GetEnumerator();
					num = (short)226492422;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 4:
					goto IL_354;
				case 5:
					num = (short)500826113;
					if (num != 0)
					{
					}
					goto IL_354;
				case 6:
				{
					num = (short)1438764158;
					short num3 = num;
					num = (short)268356734;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AD;
					default:
						num = (short)1096286208;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1216282624;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_165;
									}
									continue;
								case 1:
								{
									RptTreeViewItem rptTreeViewItem;
									this.tvAvailable.Items.Remove(rptTreeViewItem);
									num = (short)15466498;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 2:
									goto IL_190;
								case 3:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1267662853;
										num2 = (int)((IntPtr)num);
										continue;
									}
									RptTreeViewItem rptTreeViewItem = (RptTreeViewItem)enumerator.Current;
									num = (short)1528496132;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
								{
									RptTreeViewItem rptTreeViewItem;
									if (rptTreeViewItem.Header.ToString() == A_0.Header.ToString())
									{
										num = (short)702021633;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)317980678;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_23F;
								}
								IL_1EE:
								num = (short)1551564803;
								num2 = (int)((IntPtr)num);
								continue;
								IL_165:
								goto IL_1EE;
							}
							IL_190:
							IL_23F:
							goto IL_CA;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_260;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_24E:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)541458433;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2B1;
								case 1:
									disposable.Dispose();
									num = (short)637009922;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_2AF;
								}
								goto IL_260;
							}
							IL_2AF:
							IL_2B1:
							goto EndFinally_8;
							IL_260:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)1320747008;
							num2 = (int)((IntPtr)num);
							goto IL_24E;
							EndFinally_8:;
						}
						goto IL_2B2;
						IL_CA:
						this.a(ref this.tvAvailable, A_0.ID);
						num = (short)193069061;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_2B2;
				}
				IL_44:
				num = (short)981598208;
				short num4 = num;
				if (this.tvAvailable.Items.Count > 0)
				{
					num = (short)1203634179;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.tvAvailable.Items.Add(A_0);
				IL_AD:
				num = (short)1315241988;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2B2:
				this.btnAddSelectedItems.IsEnabled = true;
				num = (short)305004546;
				num2 = (int)((IntPtr)num);
				continue;
				IL_354:
				num = (short)1847656449;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00291AFC File Offset: 0x0028FCFC
		private void b(RptTreeViewItem A_0, RptTreeViewItem A_1)
		{
			short num = (short)875233289;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
					if (this.btnRemSelectedItems.IsEnabled)
					{
						num = (short)1845166088;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)228524032;
					short num3 = num;
					num4 = 0;
					num = (short)1051787266;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 2:
					goto IL_209;
				case 3:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					rptTreeViewItem.Items.RemoveAt(num5);
					num = (short)1740177419;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 4:
					goto IL_10C;
				case 5:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					if (((RptTreeViewItem)rptTreeViewItem.Items.GetItemAt(num5)).Header == A_1.Header)
					{
						num = (short)1605500931;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num5++;
					num = (short)815136783;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					RptTreeViewItem rptTreeViewItem;
					if (!(rptTreeViewItem.Header.ToString() != A_0.Header.ToString()))
					{
						num = (short)12779532;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_342;
				}
				case 7:
					goto IL_209;
				case 8:
					this.btnRemSelectedItems.IsEnabled = false;
					num = (short)920911892;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_14;
				case 10:
					num = (short)1230831616;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
				{
					RptTreeViewItem rptTreeViewItem;
					if (rptTreeViewItem.Items.Count == 0)
					{
						num = (short)2096824336;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_252;
				}
				case 12:
				{
					int num5 = 0;
					num = (short)570097668;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 13:
				{
					if (this.tvSelected.Items.Count != 0)
					{
						return;
					}
					num = (short)1367123472;
					short num6 = num;
					num = (short)872130064;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)571277312;
						if (num != 0)
						{
						}
						num = (short)1211236362;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
				{
					RptTreeViewItem rptTreeViewItem;
					int num5;
					if (num5 >= rptTreeViewItem.Items.Count)
					{
						num = (short)339279889;
						num2 = (int)((IntPtr)num);
						continue;
					}
					new RptTreeViewItem();
					num = (short)381878277;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 15:
					goto IL_10C;
				case 16:
					this.tvSelected.Items.RemoveAt(num4);
					num = (short)1962475541;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					num = (short)867631105;
					if (num != 0)
					{
					}
					goto IL_342;
				case 18:
				{
					if (num4 >= this.tvSelected.Items.Count)
					{
						num = (short)334561299;
						num2 = (int)((IntPtr)num);
						continue;
					}
					RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
					rptTreeViewItem = (RptTreeViewItem)this.tvSelected.Items.GetItemAt(num4);
					num = (short)1272578054;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 19:
					goto IL_24D;
				case 20:
					goto IL_385;
				case 21:
					goto IL_252;
				}
				goto IL_7C;
				IL_14:
				switch (0)
				{
				case 0:
					IL_7C:
					if (this.tvSelected.Items.Count <= 0)
					{
						return;
					}
					num = (short)446758913;
					num2 = (int)((IntPtr)num);
					break;
				}
				continue;
				IL_10C:
				num = (short)1617625102;
				num2 = (int)((IntPtr)num);
				continue;
				IL_209:
				num = (short)1847328786;
				num2 = (int)((IntPtr)num);
				continue;
				IL_252:
				num = (short)323944461;
				num2 = (int)((IntPtr)num);
				continue;
				IL_342:
				num4++;
				num = (short)120586247;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_24D:
			return;
			IL_385:;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00291F54 File Offset: 0x00290154
		private void b(RptTreeViewItem A_0, RptTreeViewItem A_1, RptTreeViewItem A_2)
		{
			short num = (short)1999241216;
			switch (num)
			{
			default:
			{
				num = (short)927268874;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					RptTreeViewItem rptTreeViewItem2;
					int num5;
					switch (num2)
					{
					case 0:
						this.btnRemSelectedItems.IsEnabled = false;
						num = (short)757596164;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
					{
						RptTreeViewItem rptTreeViewItem;
						if (rptTreeViewItem == A_1)
						{
							num = (short)354156555;
							num2 = (int)((IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1235025935;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
					{
						RptTreeViewItem rptTreeViewItem;
						if (rptTreeViewItem.Items.Count == 0)
						{
							num = (short)622854157;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11E;
					}
					case 3:
						if (rptTreeViewItem2.Items.Count == 0)
						{
							num = (short)409927699;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_53A;
					case 4:
						goto IL_119;
					case 5:
					{
						int num3 = 0;
						num = (short)400228360;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						goto IL_2D5;
					case 7:
					{
						RptTreeViewItem rptTreeViewItem;
						int num4;
						if (num4 >= rptTreeViewItem.Items.Count)
						{
							num = (short)860422164;
							num2 = (int)((IntPtr)num);
							continue;
						}
						new RptTreeViewItem();
						num = (short)831520784;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						goto IL_33D;
					case 9:
						goto IL_2D5;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 11:
					{
						int num4 = 0;
						num = (short)363986953;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1754333214;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
					{
						int num3;
						rptTreeViewItem2.Items.RemoveAt(num3);
						num = (short)1194393622;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						if (!(rptTreeViewItem2.Header.ToString() != A_0.Header.ToString()))
						{
							num = (short)2146697221;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B3;
					case 15:
						goto IL_33D;
					case 16:
					{
						RptTreeViewItem rptTreeViewItem;
						int num4;
						if (((RptTreeViewItem)rptTreeViewItem.Items.GetItemAt(num4)).Header == A_2.Header)
						{
							num = (short)1627586588;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1661796358;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 17:
						goto IL_385;
					case 18:
						num5 = 0;
						num = (short)1274478609;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						this.tvSelected.Items.RemoveAt(num5);
						num = (short)2056257559;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						goto IL_11E;
					case 21:
						goto IL_385;
					case 22:
						goto IL_11E;
					case 23:
						goto IL_53A;
					case 24:
						goto IL_3F5;
					case 25:
						if (num5 >= this.tvSelected.Items.Count)
						{
							num = (short)1761083416;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4A1;
					case 26:
					{
						int num3;
						if (num3 >= rptTreeViewItem2.Items.Count)
						{
							num = (short)1952251933;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1959775348;
						short num6 = num;
						num = (short)1122421876;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4A1;
						default:
						{
							num = (short)833486848;
							if (num != 0)
							{
							}
							num = (short)332791809;
							if (num != 0)
							{
							}
							RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
							rptTreeViewItem = (RptTreeViewItem)rptTreeViewItem2.Items.GetItemAt(num3);
							num = (short)976748545;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 27:
						if (this.tvSelected.Items.Count == 0)
						{
							num = (short)1045954572;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 28:
					{
						RptTreeViewItem rptTreeViewItem;
						int num4;
						rptTreeViewItem.Items.RemoveAt(num4);
						num = (short)319946754;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 29:
						goto IL_2B3;
					case 30:
						if (this.btnRemSelectedItems.IsEnabled)
						{
							num = (short)1721761792;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					IL_BF:
					if (this.tvSelected.Items.Count > 0)
					{
						num = (short)1747976210;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
					IL_11E:
					num = (short)1351614467;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2B3:
					num5++;
					num = (short)486408213;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2D5:
					num = (short)1362558983;
					num2 = (int)((IntPtr)num);
					continue;
					IL_33D:
					num = (short)805437466;
					num2 = (int)((IntPtr)num);
					continue;
					IL_385:
					num = (short)1095499776;
					short num7 = num;
					num = (short)2061500441;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4A1:
					rptTreeViewItem2 = new RptTreeViewItem();
					rptTreeViewItem2 = (RptTreeViewItem)this.tvSelected.Items.GetItemAt(num5);
					num = (short)1200095246;
					num2 = (int)((IntPtr)num);
					continue;
					IL_53A:
					num = (short)1545142299;
					num2 = (int)((IntPtr)num);
				}
				IL_119:
				return;
				IL_3F5:
				return;
			}
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00292568 File Offset: 0x00290768
		private void a(RptTreeViewItem A_0)
		{
			short num = (short)1319704474;
			short num2 = num;
			num = (short)430708634;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DC:
				if (this.tvSelected.Items.Count != 0)
				{
					return;
				}
				num = (short)1037828097;
				num3 = (int)((IntPtr)num);
				break;
			default:
			{
				num = (short)2129068032;
				short num4 = num;
				num = (short)1779499009;
				if (num != 0)
				{
				}
				num = (short)261947392;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				break;
			}
			}
			for (;;)
			{
				IL_A4:
				switch (num3)
				{
				case 0:
					goto IL_129;
				case 1:
					this.btnRemSelectedItems.IsEnabled = false;
					num = (short)1601830912;
					num3 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_DC;
				}
				goto IL_B6;
			}
			IL_129:
			return;
			IL_B6:
			this.tvSelected.Items.Remove(A_0);
			num = (short)829947906;
			num3 = (int)((IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x002926A0 File Offset: 0x002908A0
		private void a(RptTreeViewItem A_0, RptTreeViewItem A_1)
		{
			short num = (short)115015680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)531300355;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_85D;
					case 1:
						if (!this.btnAddSelectedItems.IsEnabled)
						{
							num = (short)767623177;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)749469696;
							short num3 = num;
							num = (short)1700134922;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						IEnumerator enumerator = ((IEnumerable)this.tvAvailable.Items).GetEnumerator();
						num = (short)541065224;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
					{
						RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
						this.d(A_0, rptTreeViewItem);
						this.tvAvailable.Items.Add(rptTreeViewItem);
						RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
						this.d(A_1, rptTreeViewItem2);
						rptTreeViewItem.Items.Add(rptTreeViewItem2);
						IEnumerator enumerator = ((IEnumerable)A_1.Items).GetEnumerator();
						num = (short)1786380294;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						if (!flag)
						{
							num = (short)1779367940;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 6:
						goto IL_118;
						try
						{
							for (;;)
							{
								IL_118:
								num = (short)1600520192;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_153;
										}
										continue;
									case 1:
										goto IL_234;
									case 2:
										goto IL_19F;
									case 3:
										num = (short)984154113;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
									{
										IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)997720067;
											num2 = (int)((IntPtr)num);
											continue;
										}
										RptTreeViewItem a_ = (RptTreeViewItem)enumerator.Current;
										RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
										this.d(a_, rptTreeViewItem3);
										RptTreeViewItem rptTreeViewItem2;
										rptTreeViewItem2.Items.Add(rptTreeViewItem3);
										num = (short)72089602;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									goto IL_153;
									IL_19F:
									num = (short)1109917700;
									num2 = (int)((IntPtr)num);
									continue;
									IL_153:
									num = (short)1162593003;
									short num4 = num;
									num = (short)2144846571;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_118;
									default:
										num = (short)923926528;
										if (num != 0)
										{
										}
										goto IL_19F;
									}
								}
							}
							IL_234:
							goto IL_A4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_256;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_243:
								switch (num2)
								{
								case 0:
									goto IL_2AC;
								case 1:
									disposable.Dispose();
									num = (short)1819148288;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)2097020929;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2AE;
								}
								goto IL_256;
							}
							IL_2AC:
							IL_2AE:
							goto EndFinally_26;
							IL_256:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)1326776322;
							num2 = (int)((IntPtr)num);
							goto IL_243;
							EndFinally_26:;
						}
						goto Block_4;
					case 7:
						goto IL_831;
					case 8:
						goto IL_2AF;
					case 9:
						this.btnAddSelectedItems.IsEnabled = true;
						num = (short)1691549703;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						goto IL_799;
					}
					goto IL_5A;
					IL_A4:
					num = (short)614662146;
					num2 = (int)((IntPtr)num);
					continue;
					IL_799:
					num = (short)1479081985;
					num2 = (int)((IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_2AF:
						num = (short)1769078784;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2FD;
								}
								continue;
							case 1:
							{
								RptTreeViewItem rptTreeViewItem2;
								this.d(A_1, rptTreeViewItem2);
								RptTreeViewItem rptTreeViewItem4;
								rptTreeViewItem4.Items.Add(rptTreeViewItem2);
								flag = true;
								IEnumerator enumerator2 = ((IEnumerable)A_1.Items).GetEnumerator();
								num = (short)645005321;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 2:
							{
								RptTreeViewItem rptTreeViewItem4;
								if (!(rptTreeViewItem4.Header.ToString() != A_0.Header.ToString()))
								{
									num = (short)333971459;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
								num = (short)367001606;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 4:
								goto IL_704;
							case 5:
								goto IL_71E;
							case 6:
							{
								RptTreeViewItem rptTreeViewItem2;
								RptTreeViewItem rptTreeViewItem4;
								if (!this.a(rptTreeViewItem4, ref rptTreeViewItem2, A_1.Header.ToString()))
								{
									num = (short)1734803457;
									num2 = (int)((IntPtr)num);
									continue;
								}
								this.d(A_1, rptTreeViewItem2);
								IEnumerator enumerator2 = ((IEnumerable)A_1.Items).GetEnumerator();
								num = (short)1600651271;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 7:
								try
								{
									num = (short)1168572416;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_5F2;
											}
											continue;
										case 1:
											goto IL_689;
										case 3:
											num = (short)255852545;
											num2 = (int)((IntPtr)num);
											continue;
										case 4:
										{
											IEnumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)38993923;
												num2 = (int)((IntPtr)num);
												continue;
											}
											RptTreeViewItem a_2 = (RptTreeViewItem)enumerator2.Current;
											RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
											this.d(a_2, rptTreeViewItem3);
											RptTreeViewItem rptTreeViewItem2;
											rptTreeViewItem2.Items.Add(rptTreeViewItem3);
											flag = true;
											num = (short)147128322;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_5F4:
										num = (short)533528580;
										num2 = (int)((IntPtr)num);
										continue;
										IL_5F2:
										goto IL_5F4;
									}
									IL_689:
									goto IL_85D;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_6AB;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_698:
										switch (num2)
										{
										case 0:
											goto IL_701;
										case 1:
											disposable.Dispose();
											num = (short)755957760;
											num2 = (int)((IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)312082433;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_703;
										}
										goto IL_6AB;
									}
									IL_701:
									IL_703:
									goto EndFinally_24;
									IL_6AB:
									IEnumerator enumerator2;
									disposable = (enumerator2 as IDisposable);
									num = (short)504365058;
									num2 = (int)((IntPtr)num);
									goto IL_698;
									EndFinally_24:;
								}
								goto IL_704;
							case 8:
							{
								IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)833552388;
									num2 = (int)((IntPtr)num);
									continue;
								}
								RptTreeViewItem rptTreeViewItem4 = (RptTreeViewItem)enumerator.Current;
								num = (short)193331202;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 9:
								try
								{
									num = (short)631111680;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_3DD;
											}
											continue;
										case 1:
											goto IL_473;
										case 2:
											num = (short)550305793;
											num2 = (int)((IntPtr)num);
											continue;
										case 3:
										{
											IEnumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)791150594;
												num2 = (int)((IntPtr)num);
												continue;
											}
											RptTreeViewItem a_3 = (RptTreeViewItem)enumerator2.Current;
											RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
											this.d(a_3, rptTreeViewItem3);
											RptTreeViewItem rptTreeViewItem2;
											rptTreeViewItem2.Items.Add(rptTreeViewItem3);
											num = (short)625344516;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_420:
										num = (short)1065091075;
										num2 = (int)((IntPtr)num);
										continue;
										IL_3DD:
										goto IL_420;
									}
									IL_473:
									goto IL_85D;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_495;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_482:
										switch (num2)
										{
										case 0:
											goto IL_4EC;
										case 1:
											disposable.Dispose();
											num = (short)1766850560;
											num2 = (int)((IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)1052639233;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_4EE;
										}
										goto IL_495;
									}
									IL_4EC:
									IL_4EE:
									break;
									IL_495:
									IEnumerator enumerator2;
									disposable = (enumerator2 as IDisposable);
									num = (short)416874498;
									num2 = (int)((IntPtr)num);
									goto IL_482;
								}
								break;
							}
							IL_4EF:
							num = (short)562954248;
							num2 = (int)((IntPtr)num);
							continue;
							IL_2FD:
							goto IL_4EF;
							IL_704:
							num = (short)2129723397;
							num2 = (int)((IntPtr)num);
						}
						IL_71E:
						goto IL_85D;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_740;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_72D:
							switch (num2)
							{
							case 0:
								goto IL_796;
							case 1:
								disposable.Dispose();
								num = (short)368181248;
								num2 = (int)((IntPtr)num);
								continue;
							case 2:
								if (disposable != null)
								{
									num = (short)957612033;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_798;
							}
							goto IL_740;
						}
						IL_796:
						IL_798:
						goto EndFinally_25;
						IL_740:
						IEnumerator enumerator;
						disposable = (enumerator as IDisposable);
						num = (short)1898381314;
						num2 = (int)((IntPtr)num);
						goto IL_72D;
						EndFinally_25:;
					}
					goto IL_799;
					IL_85D:
					num = (short)1665466373;
					num2 = (int)((IntPtr)num);
				}
				IL_831:
				num = (short)14417921;
				if (num != 0)
				{
				}
				return;
				IL_5A:
				flag = false;
				num = (short)1065222144;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00293010 File Offset: 0x00291210
		private bool a(RptTreeViewItem A_0, ref RptTreeViewItem A_1, string A_2)
		{
			short num = (short)537657344;
			short num2 = num;
			num = (short)659488768;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				IEnumerator enumerator = ((IEnumerable)A_0.Items).GetEnumerator();
				bool result;
				try
				{
					num = (short)942473216;
					num3 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_9C;
							}
							continue;
						case 1:
							goto IL_185;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1822490630;
								num3 = (int)((IntPtr)num);
								continue;
							}
							RptTreeViewItem rptTreeViewItem = (RptTreeViewItem)enumerator.Current;
							num = (short)764084229;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 3:
						{
							RptTreeViewItem rptTreeViewItem;
							A_1 = rptTreeViewItem;
							result = true;
							num = (short)759758852;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 4:
							goto IL_140;
						case 5:
						{
							RptTreeViewItem rptTreeViewItem;
							if (rptTreeViewItem.Header.ToString() == A_2)
							{
								num = (short)1737424899;
								num3 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)1232994305;
							num3 = (int)((IntPtr)num);
							continue;
						}
						IL_9E:
						num = (short)279969794;
						num3 = (int)((IntPtr)num);
						continue;
						IL_9C:
						goto IL_9E;
					}
					IL_140:
					num = (short)1168834561;
					if (num != 0)
					{
					}
					return result;
					IL_185:
					return false;
				}
				finally
				{
					num = (short)1483873740;
					short num4 = num;
					num = (short)187375052;
					IDisposable disposable;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_20D:
						if (disposable == null)
						{
							goto IL_245;
						}
						num = (short)1433927681;
						num3 = (int)((IntPtr)num);
						break;
					default:
						num = (short)1767112704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_1F0;
						}
						break;
					}
					for (;;)
					{
						IL_1DD:
						switch (num3)
						{
						case 0:
							goto IL_243;
						case 1:
							disposable.Dispose();
							num = (short)1720713216;
							num3 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_20D;
						}
						goto IL_1F0;
					}
					IL_243:
					goto IL_245;
					IL_1F0:
					disposable = (enumerator as IDisposable);
					num = (short)761856002;
					num3 = (int)((IntPtr)num);
					goto IL_1DD;
					IL_245:;
				}
				return result;
			}
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00293280 File Offset: 0x00291480
		private void a(RptTreeViewItem A_0, RptTreeViewItem A_1, RptTreeViewItem A_2)
		{
			short num = (short)45154304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (!this.btnAddSelectedItems.IsEnabled)
						{
							num = (short)833159174;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)993918986;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_67F;
					case 2:
						return;
					case 3:
						num = (short)1025245184;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1792671744;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								RptTreeViewItem rptTreeViewItem;
								IEnumerator enumerator;
								IEnumerator enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1DC;
									}
									continue;
								case 1:
									goto IL_299;
								case 2:
									if (!(rptTreeViewItem.Header.ToString() != A_0.Header.ToString()))
									{
										num = (short)751894531;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_1E1;
								case 4:
									num = (short)1611071495;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)12779524;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_439;
								case 6:
									if (!flag)
									{
										num = (short)1617726935;
										short num3 = num;
										num = (short)678989271;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1E1;
										default:
											num = (short)1746010112;
											if (num != 0)
											{
											}
											num = (short)1245970440;
											num2 = (int)((IntPtr)num);
											continue;
										}
									}
									break;
								case 7:
									goto IL_53E;
								case 8:
								{
									RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
									this.d(A_1, rptTreeViewItem2);
									rptTreeViewItem.Items.Add(rptTreeViewItem2);
									RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
									this.d(A_2, rptTreeViewItem3);
									rptTreeViewItem2.Items.Add(rptTreeViewItem3);
									flag = true;
									num = (short)26279937;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 9:
									try
									{
										num = (short)225181699;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)1939996674;
													num2 = (int)((IntPtr)num);
													continue;
												}
												RptTreeViewItem rptTreeViewItem4 = (RptTreeViewItem)enumerator2.Current;
												num = (short)561381382;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 1:
											{
												RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
												this.d(A_2, rptTreeViewItem3);
												RptTreeViewItem rptTreeViewItem4;
												rptTreeViewItem4.Items.Add(rptTreeViewItem3);
												flag = true;
												num = (short)1862598661;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 2:
												num = (short)2026700804;
												num2 = (int)((IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_2E0;
												}
												continue;
											case 4:
												goto IL_3BE;
											case 5:
												goto IL_3A0;
											case 6:
											{
												RptTreeViewItem rptTreeViewItem4;
												if (rptTreeViewItem4.Header == A_1.Header)
												{
													num = (short)1840447489;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_32D:
											num = (short)728760320;
											num2 = (int)((IntPtr)num);
											continue;
											IL_2E0:
											goto IL_32D;
										}
										IL_3A0:
										IL_3BE:
										goto IL_49E;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_3E0;
										}
										IDisposable disposable;
										for (;;)
										{
											IL_3CD:
											switch (num2)
											{
											case 0:
												goto IL_436;
											case 1:
												disposable.Dispose();
												num = (short)510853120;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												if (disposable != null)
												{
													num = (short)1054474241;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_438;
											}
											goto IL_3E0;
										}
										IL_436:
										IL_438:
										goto EndFinally_16;
										IL_3E0:
										disposable = (enumerator2 as IDisposable);
										num = (short)1851916290;
										num2 = (int)((IntPtr)num);
										goto IL_3CD;
										EndFinally_16:;
									}
									goto IL_439;
									IL_49E:
									num = (short)383778822;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1DC;
								IL_1E1:
								enumerator2 = ((IEnumerable)rptTreeViewItem.Items).GetEnumerator();
								num = (short)1376780297;
								num2 = (int)((IntPtr)num);
								continue;
								IL_209:
								num = (short)751632389;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1DC:
								goto IL_209;
								IL_439:
								rptTreeViewItem = (RptTreeViewItem)enumerator.Current;
								num = (short)1303838722;
								num2 = (int)((IntPtr)num);
							}
							IL_299:
							IL_53E:
							goto IL_67F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_560;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_54D:
								switch (num2)
								{
								case 0:
									goto IL_5B7;
								case 1:
									disposable.Dispose();
									num = (short)996868096;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1043791873;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5B9;
								}
								goto IL_560;
							}
							IL_5B7:
							IL_5B9:
							goto EndFinally_17;
							IL_560:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)1468137474;
							num2 = (int)((IntPtr)num);
							goto IL_54D;
							EndFinally_17:;
						}
						goto IL_5BA;
					case 5:
						goto IL_A4;
					case 6:
						goto IL_5BA;
					case 7:
					{
						RptTreeViewItem rptTreeViewItem5 = new RptTreeViewItem();
						this.d(A_0, rptTreeViewItem5);
						this.tvAvailable.Items.Add(rptTreeViewItem5);
						RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
						this.d(A_1, rptTreeViewItem2);
						rptTreeViewItem5.Items.Add(rptTreeViewItem2);
						RptTreeViewItem rptTreeViewItem3 = new RptTreeViewItem();
						this.d(A_2, rptTreeViewItem3);
						rptTreeViewItem2.Items.Add(rptTreeViewItem3);
						num = (short)2010644485;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)1554710531;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (!flag)
						{
							num = (short)1097465863;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 10:
					{
						IEnumerator enumerator = ((IEnumerable)this.tvAvailable.Items).GetEnumerator();
						num = (short)980746244;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_5B;
					IL_A4:
					num = (short)659750912;
					short num4 = num;
					num = (short)288686088;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5BA:
					this.btnAddSelectedItems.IsEnabled = true;
					num = (short)1422131201;
					if (num != 0)
					{
					}
					num = (short)608763906;
					num2 = (int)((IntPtr)num);
					continue;
					IL_67F:
					num = (short)1797521417;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_5B:
				flag = false;
				num = (short)1172504577;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0029397C File Offset: 0x00291B7C
		internal void SortItems(ref TreeView itemsContainer)
		{
			short num = (short)385286144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)704774144;
				short num3 = num;
				num = (short)749338625;
				if (num != 0)
				{
				}
				int num4 = 0;
				IEnumerator enumerator = ((IEnumerable)itemsContainer.Items).GetEnumerator();
				try
				{
					num = (short)1016266756;
					num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)503578628;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										try
										{
											num = (short)2144206851;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 1:
												{
													RptTreeViewItem rptTreeViewItem;
													rptTreeViewItem.Items.SortDescriptions.Add(new SortDescription(HeaderedItemsControl.HeaderProperty.ToString(), ListSortDirection.Ascending));
													num = (short)1729363968;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 2:
												{
													IEnumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1168506885;
														num2 = (int)((IntPtr)num);
														continue;
													}
													RptTreeViewItem rptTreeViewItem2 = (RptTreeViewItem)enumerator2.Current;
													int num5;
													num5++;
													num = (short)416481286;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 3:
													goto IL_12E;
												case 4:
													goto IL_28E;
												case 5:
												{
													num = (short)1923216770;
													short num6 = num;
													num = (short)439416194;
													switch ((num6 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_12E;
													default:
														num = (short)71434240;
														if (num != 0)
														{
														}
														num = (short)1555693572;
														num2 = (int)((IntPtr)num);
														continue;
													}
													break;
												}
												case 6:
												{
													RptTreeViewItem rptTreeViewItem;
													int num5;
													if (num5 == rptTreeViewItem.Items.Count)
													{
														num = (short)28442625;
														num2 = (int)((IntPtr)num);
														continue;
													}
													break;
												}
												}
												goto IL_15B;
												IL_12E:
												switch (0)
												{
												case 0:
													IL_15B:
													goto IL_1EC;
												}
												continue;
												IL_1EC:
												num = (short)115212290;
												num2 = (int)((IntPtr)num);
											}
											IL_28E:
											goto IL_3C5;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_2B0;
											}
											IDisposable disposable;
											for (;;)
											{
												IL_29D:
												switch (num2)
												{
												case 0:
													goto IL_307;
												case 1:
													disposable.Dispose();
													num = (short)1020395520;
													num2 = (int)((IntPtr)num);
													continue;
												case 2:
													if (disposable != null)
													{
														num = (short)318832641;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_309;
												}
												goto IL_2B0;
											}
											IL_307:
											IL_309:
											break;
											IL_2B0:
											IEnumerator enumerator2;
											disposable = (enumerator2 as IDisposable);
											num = (short)753598466;
											num2 = (int)((IntPtr)num);
											goto IL_29D;
										}
										break;
										IL_3C5:
										int num7;
										num7++;
										num = (short)249233411;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 2:
										num = (short)304218117;
										num2 = (int)((IntPtr)num);
										continue;
									case 3:
									{
										int num7;
										RptTreeViewItem rptTreeViewItem3;
										if (num7 == rptTreeViewItem3.Items.Count)
										{
											num = (short)319684614;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_113;
										}
										continue;
									case 5:
										goto IL_429;
									case 6:
									{
										RptTreeViewItem rptTreeViewItem3;
										rptTreeViewItem3.Items.SortDescriptions.Add(new SortDescription(HeaderedItemsControl.HeaderProperty.ToString(), ListSortDirection.Ascending));
										num = (short)944177152;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 7:
									{
										IEnumerator enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)643301378;
											num2 = (int)((IntPtr)num);
											continue;
										}
										RptTreeViewItem rptTreeViewItem = (RptTreeViewItem)enumerator3.Current;
										int num5 = 0;
										IEnumerator enumerator2 = ((IEnumerable)rptTreeViewItem.Items).GetEnumerator();
										num = (short)824115201;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									IL_30A:
									num = (short)1770913799;
									num2 = (int)((IntPtr)num);
									continue;
									IL_113:
									goto IL_30A;
								}
								IL_429:
								goto IL_56B;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_44B;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_438:
									switch (num2)
									{
									case 0:
										goto IL_4A4;
									case 1:
										disposable.Dispose();
										num = (short)879099904;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										if (disposable != null)
										{
											num = (short)990380033;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_4A6;
									}
									goto IL_44B;
								}
								IL_4A4:
								IL_4A6:
								break;
								IL_44B:
								IEnumerator enumerator3;
								disposable = (enumerator3 as IDisposable);
								num = (short)1799028738;
								num2 = (int)((IntPtr)num);
								goto IL_438;
							}
							break;
							IL_56B:
							num4++;
							num = (short)2062417923;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							num = (short)183435269;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							if (num4 == itemsContainer.Items.Count)
							{
								num = (short)473300998;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							continue;
						case 5:
							goto IL_5D0;
						case 6:
							itemsContainer.Items.SortDescriptions.Add(new SortDescription(HeaderedItemsControl.HeaderProperty.ToString(), ListSortDirection.Ascending));
							itemsContainer.Items.Refresh();
							num = (short)1507721217;
							num2 = (int)((IntPtr)num);
							continue;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)694747138;
								num2 = (int)((IntPtr)num);
								continue;
							}
							RptTreeViewItem rptTreeViewItem3 = (RptTreeViewItem)enumerator.Current;
							int num7 = 0;
							IEnumerator enumerator3 = ((IEnumerable)rptTreeViewItem3.Items).GetEnumerator();
							num = (short)1196032000;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						IL_4A7:
						num = (short)1341456391;
						num2 = (int)((IntPtr)num);
						continue;
						IL_C8:
						goto IL_4A7;
					}
					IL_5D0:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_5EF;
					}
					IDisposable disposable;
					for (;;)
					{
						IL_5DC:
						switch (num2)
						{
						case 0:
							goto IL_646;
						case 1:
							disposable.Dispose();
							num = (short)2131165184;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							if (disposable != null)
							{
								num = (short)1148780545;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_648;
						}
						goto IL_5EF;
					}
					IL_646:
					IL_648:
					goto EndFinally_18;
					IL_5EF:
					disposable = (enumerator as IDisposable);
					num = (short)1682112514;
					num2 = (int)((IntPtr)num);
					goto IL_5DC;
					EndFinally_18:;
				}
				return;
			}
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00294020 File Offset: 0x00292220
		internal bool BuildPrintItems()
		{
			int a_ = 18;
			short num = (short)906559488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				RptTreeViewItem rptTreeViewItem;
				bool flag;
				RptTreeViewItem rptTreeViewItem2;
				RptTreeViewItem rptTreeViewItem3;
				IEnumerator<IAcpRecordset> enumerator5;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (this.tvAvailable.Items.Count > 0)
						{
							num = (short)1871708162;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_163A;
					case 1:
						goto IL_1638;
					case 2:
						goto IL_1613;
					case 3:
						try
						{
							num = (short)101974025;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IAcpRecordset acpRecordset;
								int num3;
								switch (num2)
								{
								case 0:
									goto IL_217;
								case 1:
									goto IL_217;
								case 2:
									if (rptTreeViewItem.Items.Count <= 0)
									{
										num = (short)500563972;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (!acpRecordset.HiddenStatic)
									{
										num = (short)1631191047;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 4:
									this.tvAvailable.Items.Remove(rptTreeViewItem);
									num = (short)1459027984;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									num = (short)506200066;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
								{
									IAcpFeatureNode acpFeatureNode;
									IEnumerator<IAcpFeatureSection> enumerator = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)2014248970;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 7:
								{
									rptTreeViewItem = new RptTreeViewItem();
									rptTreeViewItem.RptRecordName = acpRecordset.UIName;
									rptTreeViewItem.Header = acpRecordset.UIName;
									rptTreeViewItem.ID = acpRecordset.RecsetId;
									rptTreeViewItem.ParentID = 0;
									rptTreeViewItem.ItemType = 0;
									rptTreeViewItem.RptPath = acpRecordset.Path(RptMgrErrorHandler.b("⺔", a_));
									this.tvAvailable.Items.Add(rptTreeViewItem);
									Dictionary<int, string> dictionary = new Dictionary<int, string>();
									Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
									num3 = 0;
									num = (short)704970752;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
									this.tvAvailable.Items.Remove(rptTreeViewItem);
									num = (short)25886737;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_17A;
									}
									continue;
								case 10:
									try
									{
										num = (short)255918090;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											Dictionary<int, string> dictionary;
											IAcpFeatureSection acpFeatureSection2;
											switch (num2)
											{
											case 0:
												if (rptTreeViewItem.HasItems)
												{
													num = (short)1683226640;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 1:
												try
												{
													num = (short)781844486;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															Dictionary<int, string> dictionary2;
															IAcpFeatureSection acpFeatureSection;
															dictionary2.Add(acpFeatureSection.FeatureSectionId, acpFeatureSection.UIName);
															flag = false;
															IEnumerator<IAcpField> enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
															num = (short)1283391492;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 1:
														{
															Dictionary<int, string> dictionary2;
															IAcpFeatureSection acpFeatureSection;
															if (!dictionary2.ContainsKey(acpFeatureSection.FeatureSectionId))
															{
																num = (short)735313920;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														}
														case 2:
														{
															IEnumerator<IAcpFeatureSection> enumerator3;
															if (!enumerator3.MoveNext())
															{
																num = (short)959315971;
																num2 = (int)((IntPtr)num);
																continue;
															}
															IAcpFeatureSection acpFeatureSection = enumerator3.Current;
															num = (short)175243265;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 3:
															goto IL_9B8;
														case 4:
															try
															{
																num = (short)254476307;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		num = (short)1982398466;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 1:
																		if (rptTreeViewItem2.Items.Count > 0)
																		{
																			num = (short)894369807;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	case 2:
																	{
																		IAcpField acpField;
																		if (!FieldFilters.FilterSpecialFieldInReport(acpField))
																		{
																			num = (short)1150156813;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_78D;
																	}
																	case 3:
																	{
																		IAcpField acpField;
																		if (!((AcpFieldBase)acpField).HiddenDynamic)
																		{
																			num = (short)543031296;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_78D;
																	}
																	case 4:
																	{
																		IAcpField acpField;
																		if (!(acpField.Name == RptMgrErrorHandler.b("횔ﾖ爵춠킢쒦\udda8슪\udbac쪮\udbb2풴\ud9b6ힸ\udeba톼", a_)))
																		{
																			num = (short)1659895822;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 5:
																		rptTreeViewItem.Items.Add(rptTreeViewItem2);
																		num = (short)293928977;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 6:
																		num = (short)614137864;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 7:
																		num = (short)1215102994;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 8:
																	{
																		IAcpField acpField;
																		if (!((AcpFieldBase)acpField).HiddenStatic)
																		{
																			num = (short)2061500426;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_78D;
																	}
																	case 9:
																	{
																		IEnumerator<IAcpField> enumerator2;
																		if (!enumerator2.MoveNext())
																		{
																			num = (short)1393360903;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		IAcpField acpField = enumerator2.Current;
																		num = (short)1125842956;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 10:
																		num = (short)522846211;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 11:
																		goto IL_78D;
																	case 12:
																	{
																		IAcpField acpField;
																		if (acpField != null)
																		{
																			num = (short)532807686;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_78D;
																	}
																	case 13:
																		num = (short)1971126276;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 14:
																	{
																		flag = true;
																		rptTreeViewItem3 = new RptTreeViewItem();
																		IAcpField acpField;
																		rptTreeViewItem3.RptRecordName = acpField.UIName;
																		rptTreeViewItem3.Header = acpField.UIName;
																		rptTreeViewItem3.ParentID = rptTreeViewItem2.ID;
																		rptTreeViewItem3.ItemType = 2;
																		rptTreeViewItem3.RptPath = acpField.Path(RptMgrErrorHandler.b("⺔", a_));
																		rptTreeViewItem2.Items.Add(rptTreeViewItem3);
																		num = (short)1579679755;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 15:
																		num = (short)66060304;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 16:
																		if (!rptTreeViewItem.Items.Contains(rptTreeViewItem2))
																		{
																			num = (short)1279852549;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	case 18:
																		goto IL_946;
																	case 19:
																		switch (0)
																		{
																		case 0:
																			goto IL_64E;
																		}
																		continue;
																	}
																	goto IL_64E;
																	IL_78D:
																	num = (short)957415425;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_825:
																	num = (short)1376976905;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_64E:
																	goto IL_825;
																}
																IL_946:
																break;
															}
															finally
															{
																num = (short)1161756674;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	IEnumerator<IAcpField> enumerator2;
																	switch (num2)
																	{
																	case 0:
																		enumerator2.Dispose();
																		num = (short)1859649537;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 1:
																		goto IL_9B5;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_97E;
																		}
																		continue;
																	}
																	IL_97E:
																	if (enumerator2 == null)
																	{
																		break;
																	}
																	num = (short)1099038720;
																	num2 = (int)((IntPtr)num);
																}
																IL_9B5:;
															}
															goto IL_9B8;
														case 5:
															goto IL_9D1;
														case 6:
															switch (0)
															{
															case 0:
																goto IL_503;
															}
															continue;
														}
														IL_547:
														num = (short)251985922;
														num2 = (int)((IntPtr)num);
														continue;
														IL_503:
														goto IL_547;
														IL_9B8:
														num = (short)578420741;
														num2 = (int)((IntPtr)num);
													}
													IL_9D1:
													goto IL_131D;
												}
												finally
												{
													num = (short)639631362;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator<IAcpFeatureSection> enumerator3;
														switch (num2)
														{
														case 0:
															enumerator3.Dispose();
															num = (short)1234436097;
															num2 = (int)((IntPtr)num);
															continue;
														case 1:
															goto IL_A43;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_A0A;
															}
															continue;
														}
														IL_A0A:
														if (enumerator3 == null)
														{
															break;
														}
														num = (short)2069102592;
														num2 = (int)((IntPtr)num);
													}
													IL_A43:;
												}
												goto Block_14;
											case 2:
												num = (short)158597120;
												num2 = (int)((IntPtr)num);
												continue;
											case 3:
											{
												dictionary.Add(acpFeatureSection2.FeatureSectionId, acpFeatureSection2.UIName);
												flag = false;
												rptTreeViewItem2 = new RptTreeViewItem();
												rptTreeViewItem2.RptRecordName = acpFeatureSection2.UIName;
												rptTreeViewItem2.Header = acpFeatureSection2.UIName;
												rptTreeViewItem2.ID = acpFeatureSection2.FeatureSectionId;
												rptTreeViewItem2.ParentID = rptTreeViewItem.ID;
												rptTreeViewItem2.ItemType = 1;
												rptTreeViewItem2.RptPath = acpFeatureSection2.Path(RptMgrErrorHandler.b("⺔", a_)).ToString();
												IEnumerator<IAcpField> enumerator2 = acpFeatureSection2.FieldsCollection.GetEnumerator();
												num = (short)301924358;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 4:
												num = (short)1615003655;
												num2 = (int)((IntPtr)num);
												continue;
											case 5:
												if (!acpFeatureSection2.EmbeddedRecset.HiddenStatic)
												{
													num = (short)1031667726;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_131D;
											case 6:
												goto IL_A46;
											case 7:
												goto IL_13E3;
											case 8:
												if (!flag)
												{
													num = (short)27197442;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 10:
												switch (0)
												{
												case 0:
													goto IL_3F6;
												}
												continue;
											case 11:
												goto IL_43A;
											case 12:
												if (!dictionary.ContainsKey(acpFeatureSection2.FeatureSectionId))
												{
													num = (short)782172163;
													num2 = (int)((IntPtr)num);
													continue;
												}
												flag = true;
												num = (short)1242497035;
												num2 = (int)((IntPtr)num);
												continue;
											case 13:
												num = (short)1585840133;
												num2 = (int)((IntPtr)num);
												continue;
											case 14:
											{
												IEnumerator<IAcpFeatureSection> enumerator3 = acpFeatureSection2.EmbeddedRecset[0].FeatureSectionsCollection.GetEnumerator();
												num = (short)1004470273;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 15:
												if (acpFeatureSection2.EmbeddedRecset.Count > 0)
												{
													num = (short)448200717;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_131D;
											case 16:
												goto IL_1188;
											case 17:
												num = (short)1469906959;
												num2 = (int)((IntPtr)num);
												continue;
											case 18:
											{
												IEnumerator<IAcpFeatureSection> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1315438596;
													num2 = (int)((IntPtr)num);
													continue;
												}
												acpFeatureSection2 = enumerator.Current;
												num = (short)405864460;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 19:
												if (acpFeatureSection2.HasEmbeddedRecset)
												{
													num = (short)2039349265;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_131D;
											}
											goto IL_3F6;
											IL_43A:
											num = (short)666894355;
											num2 = (int)((IntPtr)num);
											continue;
											Block_14:
											try
											{
												IL_A46:
												num = (short)1872232474;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IAcpField acpField2;
													switch (num2)
													{
													case 0:
														if (!acpField2.IgnoreOnPrint)
														{
															num = (short)340262934;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 1:
														rptTreeViewItem.Items.Add(rptTreeViewItem2);
														num = (short)646709271;
														num2 = (int)((IntPtr)num);
														continue;
													case 2:
														if (rptTreeViewItem2 == null)
														{
															num = (short)1810497541;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_1008;
													case 3:
														num = (short)397737984;
														num2 = (int)((IntPtr)num);
														continue;
													case 4:
														goto IL_CC5;
													case 5:
														rptTreeViewItem2 = new RptTreeViewItem();
														rptTreeViewItem2.RptRecordName = acpField2.NewParent.UIName;
														rptTreeViewItem2.Header = acpField2.NewParent.UIName;
														rptTreeViewItem2.ID = acpField2.NewParent.FeatureSectionId;
														rptTreeViewItem2.ParentID = rptTreeViewItem.ID;
														rptTreeViewItem2.ItemType = 1;
														rptTreeViewItem2.RptPath = acpField2.NewParent.Path(RptMgrErrorHandler.b("⺔", a_)).ToString();
														num = (short)2107834377;
														num2 = (int)((IntPtr)num);
														continue;
													case 6:
														num = (short)180224008;
														num2 = (int)((IntPtr)num);
														continue;
													case 7:
														if (rptTreeViewItem2.Items.Count > 0)
														{
															num = (short)1099956244;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 8:
														if (!((AcpFieldBase)acpField2).HiddenDynamic)
														{
															num = (short)140836874;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 9:
														goto IL_1008;
													case 10:
														num = (short)974585877;
														num2 = (int)((IntPtr)num);
														continue;
													case 11:
														if (!rptTreeViewItem.Items.Contains(rptTreeViewItem2))
														{
															num = (short)1021181953;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 12:
														num = (short)1743192089;
														num2 = (int)((IntPtr)num);
														continue;
													case 13:
														try
														{
															num = (short)1577320448;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	switch (0)
																	{
																	case 0:
																		goto IL_DB9;
																	}
																	continue;
																case 1:
																{
																	RptTreeViewItem rptTreeViewItem4;
																	rptTreeViewItem2 = rptTreeViewItem4;
																	num = (short)83558403;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 2:
																	num = (short)1907294212;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 3:
																	goto IL_DD5;
																case 4:
																	goto IL_E88;
																case 5:
																{
																	IEnumerator enumerator4;
																	if (!enumerator4.MoveNext())
																	{
																		num = (short)846462978;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	RptTreeViewItem rptTreeViewItem4 = (RptTreeViewItem)enumerator4.Current;
																	num = (short)776011782;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 6:
																{
																	RptTreeViewItem rptTreeViewItem4;
																	if (rptTreeViewItem4.RptRecordName == acpField2.NewParent.UIName)
																	{
																		num = (short)1029963777;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																}
																IL_E33:
																num = (short)334036997;
																num2 = (int)((IntPtr)num);
																continue;
																IL_DB9:
																goto IL_E33;
															}
															IL_DD5:
															IL_E88:
															goto IL_C43;
														}
														finally
														{
															switch (0)
															{
															case 0:
																goto IL_EAA;
															}
															IDisposable disposable;
															for (;;)
															{
																IL_E97:
																switch (num2)
																{
																case 0:
																	if (disposable != null)
																	{
																		num = (short)1868103682;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_F02;
																case 1:
																	goto IL_F00;
																case 2:
																	disposable.Dispose();
																	num = (short)1810300929;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_EAA;
															}
															IL_F00:
															IL_F02:
															goto EndFinally_54;
															IL_EAA:
															IEnumerator enumerator4;
															disposable = (enumerator4 as IDisposable);
															num = (short)1605435392;
															num2 = (int)((IntPtr)num);
															goto IL_E97;
															EndFinally_54:;
														}
														goto IL_F03;
														IL_C43:
														num = (short)475136002;
														num2 = (int)((IntPtr)num);
														continue;
													case 14:
													{
														IEnumerator<IAcpField> enumerator2;
														if (!enumerator2.MoveNext())
														{
															num = (short)516751372;
															num2 = (int)((IntPtr)num);
															continue;
														}
														acpField2 = enumerator2.Current;
														num = (short)1756889105;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 15:
														if (acpField2.NewUIName != null)
														{
															num = (short)183238680;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_F03;
													case 16:
														goto IL_CC5;
													case 17:
														if (acpField2 != null)
														{
															num = (short)1354956818;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 18:
														num = (short)196673555;
														num2 = (int)((IntPtr)num);
														continue;
													case 19:
														if (!((AcpFieldBase)acpField2).HiddenStatic)
														{
															num = (short)835846150;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 20:
														num = (short)956366859;
														num2 = (int)((IntPtr)num);
														continue;
													case 21:
														if (!FieldFilters.FilterSpecialFieldInReport(acpField2))
														{
															num = (short)62783491;
															num2 = (int)((IntPtr)num);
															continue;
														}
														break;
													case 22:
														num = (short)699006991;
														num2 = (int)((IntPtr)num);
														continue;
													case 24:
													{
														rptTreeViewItem2 = null;
														IEnumerator enumerator4 = ((IEnumerable)rptTreeViewItem.Items).GetEnumerator();
														num = (short)194641933;
														num2 = (int)((IntPtr)num);
														continue;
													}
													case 25:
														goto IL_1115;
													case 26:
														switch (0)
														{
														case 0:
															goto IL_AD8;
														}
														continue;
													}
													goto IL_AD8;
													IL_CC5:
													num = (short)97386503;
													num2 = (int)((IntPtr)num);
													continue;
													IL_F03:
													flag = true;
													rptTreeViewItem3 = new RptTreeViewItem();
													rptTreeViewItem3.RptRecordName = acpField2.UIName;
													rptTreeViewItem3.Header = acpField2.UIName;
													rptTreeViewItem3.ParentID = rptTreeViewItem2.ID;
													rptTreeViewItem3.ItemType = 2;
													rptTreeViewItem3.RptPath = acpField2.Path(RptMgrErrorHandler.b("⺔", a_));
													rptTreeViewItem2.Items.Add(rptTreeViewItem3);
													num = (short)667222020;
													num2 = (int)((IntPtr)num);
													continue;
													IL_F85:
													num = (short)421527566;
													num2 = (int)((IntPtr)num);
													continue;
													IL_AD8:
													goto IL_F85;
													IL_1008:
													flag = true;
													rptTreeViewItem3 = new RptTreeViewItem();
													rptTreeViewItem3.RptRecordName = acpField2.NewUIName;
													rptTreeViewItem3.Header = acpField2.NewUIName;
													rptTreeViewItem3.ParentID = rptTreeViewItem2.ID;
													rptTreeViewItem3.ItemType = 2;
													rptTreeViewItem3.RptPath = acpField2.Path(RptMgrErrorHandler.b("⺔", a_));
													rptTreeViewItem2.Items.Add(rptTreeViewItem3);
													num = (short)1713045520;
													num2 = (int)((IntPtr)num);
												}
												IL_1115:
												goto IL_43A;
											}
											finally
											{
												num = (short)813760512;
												num2 = (int)((IntPtr)num);
												for (;;)
												{
													IEnumerator<IAcpField> enumerator2;
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_114D;
														}
														continue;
													case 1:
														goto IL_1185;
													case 2:
														enumerator2.Dispose();
														num = (short)758382593;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IL_114D:
													if (enumerator2 == null)
													{
														break;
													}
													num = (short)680198146;
													num2 = (int)((IntPtr)num);
												}
												IL_1185:;
											}
											IL_1188:
											rptTreeViewItem.Items.Remove(rptTreeViewItem2);
											dictionary.Remove(acpFeatureSection2.FeatureSectionId);
											num = (short)963510281;
											num2 = (int)((IntPtr)num);
											continue;
											IL_131D:
											num = (short)1639251976;
											num2 = (int)((IntPtr)num);
											continue;
											IL_138D:
											num = (short)1756758034;
											num2 = (int)((IntPtr)num);
											continue;
											IL_3F6:
											goto IL_138D;
										}
										IL_13E3:
										goto IL_289;
									}
									finally
									{
										num = (short)1515651072;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											IEnumerator<IAcpFeatureSection> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_141A;
												}
												continue;
											case 1:
												goto IL_1452;
											case 2:
												enumerator.Dispose();
												num = (short)595066881;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IL_141A:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1112801282;
											num2 = (int)((IntPtr)num);
										}
										IL_1452:;
									}
									goto IL_1455;
									IL_289:
									num = (short)371326990;
									num2 = (int)((IntPtr)num);
									continue;
								case 11:
									num = (short)2071855119;
									num2 = (int)((IntPtr)num);
									continue;
								case 12:
								{
									IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode != null)
									{
										num = (short)436994054;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1515;
								}
								case 13:
									if (!enumerator5.MoveNext())
									{
										num = (short)1176698891;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1455;
								case 14:
									if (rptTreeViewItem.Items.Count <= 0)
									{
										num = (short)1725956104;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1515;
								case 15:
									goto IL_1552;
								case 17:
									goto IL_1515;
								case 18:
								{
									if (num3 >= acpRecordset.Count)
									{
										num = (short)609288197;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IAcpFeatureNode acpFeatureNode = acpRecordset[num3];
									num = (short)572719116;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								goto IL_17A;
								IL_217:
								num = (short)365625362;
								num2 = (int)((IntPtr)num);
								continue;
								IL_33F:
								num = (short)1864892429;
								num2 = (int)((IntPtr)num);
								continue;
								IL_17A:
								goto IL_33F;
								IL_1455:
								acpRecordset = enumerator5.Current;
								num = (short)1041498115;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1515:
								num3++;
								num = (short)1096155137;
								num2 = (int)((IntPtr)num);
							}
							IL_1552:
							goto IL_BB;
						}
						finally
						{
							for (;;)
							{
								num = (short)759496704;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_158B;
										}
										continue;
									case 1:
										goto IL_15C5;
									case 2:
										enumerator5.Dispose();
										num = (short)1039663105;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IL_158B:
									if (enumerator5 == null)
									{
										goto IL_1612;
									}
									num = (short)1327890434;
									num2 = (int)((IntPtr)num);
								}
								IL_15C5:
								num = (short)1656747339;
								short num4 = num;
								num = (short)1580397899;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_15FA;
								}
							}
							IL_15FA:
							num = (short)289538048;
							if (num != 0)
							{
							}
							IL_1612:;
						}
						goto IL_1613;
						IL_BB:
						num = (short)211156992;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_47;
					IL_1613:
					this.SortItems(ref this.tvAvailable);
					num = (short)1220608001;
					num2 = (int)((IntPtr)num);
				}
				IL_1638:
				IL_163A:
				num = (short)2041053184;
				short num5 = num;
				bool result;
				return result;
				IL_47:
				this.tvAvailable.Items.Clear();
				result = true;
				flag = false;
				rptTreeViewItem = new RptTreeViewItem();
				rptTreeViewItem2 = new RptTreeViewItem();
				rptTreeViewItem3 = new RptTreeViewItem();
				enumerator5 = FeatureManager.Features.GetEnumerator();
				num = (short)12517377;
				if (num != 0)
				{
				}
				num = (short)1715077123;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00295728 File Offset: 0x00293928
		private bool a(ref TreeView A_0, int A_1)
		{
			int a_ = 11;
			short num = (short)1138425856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				bool flag;
				IEnumerator<IAcpRecordset> enumerator5;
				for (;;)
				{
					IL_30:
					num = (short)729219073;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1290;
					case 1:
						if (A_0.Items.Count > 0)
						{
							num = (short)42074112;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12B1;
					case 2:
						goto IL_12AF;
					case 3:
						try
						{
							num = (short)1217789958;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IAcpRecordset acpRecordset;
								switch (num2)
								{
								case 0:
								{
									RptTreeViewItem rptTreeViewItem;
									this.tvAvailable.Items.Remove(rptTreeViewItem);
									num = (short)726007817;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
									try
									{
										num = (short)1634140171;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											RptTreeViewItem rptTreeViewItem;
											RptTreeViewItem rptTreeViewItem3;
											switch (num2)
											{
											case 0:
											{
												IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.EmbeddedRecset.Count > 0)
												{
													num = (short)259129358;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_8E7;
											}
											case 1:
											{
												IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.HasEmbeddedRecset)
												{
													num = (short)350421008;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_8E7;
											}
											case 2:
											{
												IAcpFeatureSection acpFeatureSection;
												if (!acpFeatureSection.EmbeddedRecset.HiddenStatic)
												{
													num = (short)1661403142;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_8E7;
											}
											case 3:
												num = (short)142082061;
												num2 = (int)((IntPtr)num);
												continue;
											case 5:
												goto IL_10DD;
											case 6:
											{
												IAcpFeatureSection acpFeatureSection;
												IEnumerator<IAcpFeatureSection> enumerator = acpFeatureSection.EmbeddedRecset[0].FeatureSectionsCollection.GetEnumerator();
												num = (short)796262407;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 7:
												try
												{
													num = (short)143065091;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator<IAcpFeatureSection> enumerator;
														switch (num2)
														{
														case 0:
															num = (short)435552257;
															num2 = (int)((IntPtr)num);
															continue;
														case 1:
															goto IL_878;
														case 2:
															if (!enumerator.MoveNext())
															{
																num = (short)586285056;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_7F0;
														case 3:
															switch (0)
															{
															case 0:
																goto IL_4F7;
															}
															continue;
														case 4:
															goto IL_81B;
														}
														goto IL_4F7;
														IL_7F0:
														IEnumerator<IAcpField> enumerator2 = enumerator.Current.FieldsCollection.GetEnumerator();
														num = (short)171180036;
														num2 = (int)((IntPtr)num);
														continue;
														IL_81B:
														try
														{
															num = (short)2013396999;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	num = (short)566231042;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 1:
																	num = (short)103874566;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 2:
																	goto IL_77F;
																case 3:
																{
																	if (!enumerator2.MoveNext())
																	{
																		num = (short)646578176;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IAcpField acpField = enumerator2.Current;
																	num = (short)2108358666;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 4:
																	num = (short)315555851;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 5:
																{
																	flag = true;
																	RptTreeViewItem rptTreeViewItem2 = new RptTreeViewItem();
																	IAcpField acpField;
																	rptTreeViewItem2.RptRecordName = acpField.UIName;
																	rptTreeViewItem2.Header = acpField.UIName;
																	rptTreeViewItem2.ParentID = rptTreeViewItem3.ID;
																	rptTreeViewItem2.ItemType = 2;
																	rptTreeViewItem2.RptPath = acpField.Path(RptMgrErrorHandler.b("㖍", a_));
																	rptTreeViewItem3.Items.Add(rptTreeViewItem2);
																	num = (short)75956233;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																case 6:
																{
																	IAcpField acpField;
																	if (!((AcpFieldBase)acpField).HiddenStatic)
																	{
																		num = (short)2098724868;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 7:
																	switch (0)
																	{
																	case 0:
																		goto IL_5A0;
																	}
																	continue;
																case 8:
																{
																	IAcpField acpField;
																	if (!FieldFilters.FilterSpecialFieldInReport(acpField))
																	{
																		num = (short)1521221637;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 10:
																{
																	IAcpField acpField;
																	if (acpField != null)
																	{
																		num = (short)1083637761;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 11:
																{
																	IAcpField acpField;
																	if (!((AcpFieldBase)acpField).HiddenDynamic)
																	{
																		num = (short)222691340;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	break;
																}
																case 12:
																	num = (short)168689672;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																IL_6E4:
																num = (short)2145517571;
																num2 = (int)((IntPtr)num);
																continue;
																IL_5A0:
																goto IL_6E4;
															}
															IL_77F:
															goto IL_820;
														}
														finally
														{
															num = (short)33882114;
															num2 = (int)((IntPtr)num);
															for (;;)
															{
																switch (num2)
																{
																case 0:
																	enumerator2.Dispose();
																	num = (short)1253900289;
																	num2 = (int)((IntPtr)num);
																	continue;
																case 1:
																	goto IL_7ED;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_7B6;
																	}
																	continue;
																}
																IL_7B6:
																if (enumerator2 == null)
																{
																	break;
																}
																num = (short)158138368;
																num2 = (int)((IntPtr)num);
															}
															IL_7ED:;
														}
														goto IL_7F0;
														IL_4F7:
														num = (short)1037571246;
														short num3 = num;
														num = (short)1407718574;
														switch ((num3 == num) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_81B;
														default:
															num = (short)239730688;
															if (num != 0)
															{
															}
															break;
														}
														IL_820:
														num = (short)279117826;
														num2 = (int)((IntPtr)num);
													}
													IL_878:;
												}
												finally
												{
													num = (short)610336770;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator<IAcpFeatureSection> enumerator;
														switch (num2)
														{
														case 0:
															enumerator.Dispose();
															num = (short)1111556097;
															num2 = (int)((IntPtr)num);
															continue;
														case 1:
															goto IL_8E4;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_8AC;
															}
															continue;
														}
														IL_8AC:
														if (enumerator == null)
														{
															break;
														}
														num = (short)1273430016;
														num2 = (int)((IntPtr)num);
													}
													IL_8E4:;
												}
												goto IL_8E7;
											case 8:
												num = (short)1496121349;
												num2 = (int)((IntPtr)num);
												continue;
											case 9:
												if (!flag)
												{
													num = (short)1292435459;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 10:
											{
												IEnumerator<IAcpFeatureSection> enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)1064960008;
													num2 = (int)((IntPtr)num);
													continue;
												}
												IAcpFeatureSection acpFeatureSection = enumerator3.Current;
												Trace.WriteLine(string.Format(RptMgrErrorHandler.b("融馏ꂑ望첗鍊ﮝ춡삣쎥\udba7螩銫ﶭ햯톱躳춵袷잹", a_), acpFeatureSection.UIName));
												rptTreeViewItem3 = new RptTreeViewItem();
												rptTreeViewItem3.RptRecordName = acpFeatureSection.UIName;
												rptTreeViewItem3.Header = acpFeatureSection.UIName;
												rptTreeViewItem3.ID = acpFeatureSection.FeatureSectionId;
												rptTreeViewItem3.ParentID = rptTreeViewItem.ID;
												rptTreeViewItem3.ItemType = 1;
												rptTreeViewItem3.RptPath = acpFeatureSection.Path(RptMgrErrorHandler.b("㖍", a_));
												flag = false;
												IEnumerator<IAcpField> enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
												num = (short)1479671823;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 11:
												switch (0)
												{
												case 0:
													goto IL_2C9;
												}
												continue;
											case 12:
												goto IL_109C;
											case 13:
												if (rptTreeViewItem.HasItems)
												{
													num = (short)976748556;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											case 14:
												num = (short)274464770;
												num2 = (int)((IntPtr)num);
												continue;
											case 15:
												try
												{
													num = (short)288227351;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														RptTreeViewItem rptTreeViewItem2;
														IAcpField acpField2;
														switch (num2)
														{
														case 0:
															rptTreeViewItem.Items.Add(rptTreeViewItem3);
															num = (short)670302232;
															num2 = (int)((IntPtr)num);
															continue;
														case 1:
															if (!((AcpFieldBase)acpField2).HiddenDynamic)
															{
																num = (short)646971413;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 2:
															if (acpField2.NewUIName != null)
															{
																num = (short)1452933137;
																num2 = (int)((IntPtr)num);
																continue;
															}
															flag = true;
															rptTreeViewItem2 = new RptTreeViewItem();
															rptTreeViewItem2.RptRecordName = acpField2.UIName;
															rptTreeViewItem2.Header = acpField2.UIName;
															rptTreeViewItem2.ParentID = rptTreeViewItem3.ID;
															rptTreeViewItem2.ItemType = 2;
															rptTreeViewItem2.RptPath = acpField2.Path(RptMgrErrorHandler.b("㖍", a_));
															rptTreeViewItem3.Items.Add(rptTreeViewItem2);
															num = (short)1249574922;
															num2 = (int)((IntPtr)num);
															continue;
														case 3:
															if (!((AcpFieldBase)acpField2).HiddenStatic)
															{
																num = (short)1238958088;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 4:
															if (!acpField2.IgnoreOnPrint)
															{
																num = (short)2045247502;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 5:
															num = (short)255328259;
															num2 = (int)((IntPtr)num);
															continue;
														case 6:
															if (rptTreeViewItem3 == null)
															{
																num = (short)340394006;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_D49;
														case 7:
															if (rptTreeViewItem3.Items.Count > 0)
															{
																num = (short)1874067472;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 8:
															num = (short)1983971329;
															num2 = (int)((IntPtr)num);
															continue;
														case 9:
															num = (short)2027421700;
															num2 = (int)((IntPtr)num);
															continue;
														case 10:
															goto IL_AFA;
														case 11:
															goto IL_D49;
														case 12:
															if (!rptTreeViewItem.Items.Contains(rptTreeViewItem3))
															{
																num = (short)582877184;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 13:
															if (!FieldFilters.FilterSpecialFieldInReport(acpField2))
															{
																num = (short)1547042825;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 14:
															num = (short)1403387906;
															num2 = (int)((IntPtr)num);
															continue;
														case 15:
															goto IL_AFA;
														case 16:
															num = (short)1070465036;
															num2 = (int)((IntPtr)num);
															continue;
														case 17:
														{
															rptTreeViewItem3 = null;
															IEnumerator enumerator4 = ((IEnumerable)rptTreeViewItem.Items).GetEnumerator();
															num = (short)1304100890;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 18:
														{
															IEnumerator<IAcpField> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1328939033;
																num2 = (int)((IntPtr)num);
																continue;
															}
															acpField2 = enumerator2.Current;
															num = (short)2086338579;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 19:
															if (acpField2 != null)
															{
																num = (short)465698821;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														case 20:
															goto IL_102A;
														case 21:
															num = (short)1538785293;
															num2 = (int)((IntPtr)num);
															continue;
														case 22:
															rptTreeViewItem3 = new RptTreeViewItem();
															rptTreeViewItem3.RptRecordName = acpField2.NewParent.UIName;
															rptTreeViewItem3.Header = acpField2.NewParent.UIName;
															rptTreeViewItem3.ID = acpField2.NewParent.FeatureSectionId;
															rptTreeViewItem3.ParentID = rptTreeViewItem.ID;
															rptTreeViewItem3.ItemType = 1;
															rptTreeViewItem3.RptPath = acpField2.NewParent.Path(RptMgrErrorHandler.b("㖍", a_)).ToString();
															num = (short)1352335371;
															num2 = (int)((IntPtr)num);
															continue;
														case 23:
															switch (0)
															{
															case 0:
																goto IL_9FF;
															}
															continue;
														case 25:
															num = (short)658309140;
															num2 = (int)((IntPtr)num);
															continue;
														case 26:
															try
															{
																num = (short)535035908;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																	{
																		RptTreeViewItem rptTreeViewItem4;
																		if (rptTreeViewItem4.RptRecordName == acpField2.NewParent.UIName)
																		{
																			num = (short)1475805186;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 1:
																	{
																		IEnumerator enumerator4;
																		if (!enumerator4.MoveNext())
																		{
																			num = (short)470351878;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		RptTreeViewItem rptTreeViewItem4 = (RptTreeViewItem)enumerator4.Current;
																		num = (short)427294720;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 2:
																	{
																		RptTreeViewItem rptTreeViewItem4;
																		rptTreeViewItem3 = rptTreeViewItem4;
																		num = (short)614006787;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 4:
																		switch (0)
																		{
																		case 0:
																			goto IL_E92;
																		}
																		continue;
																	case 5:
																		goto IL_F5E;
																	case 6:
																		num = (short)1565196293;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IL_EE9:
																	num = (short)1543372801;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_E92:
																	goto IL_EE9;
																}
																IL_F5E:;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_F7D;
																}
																IDisposable disposable;
																for (;;)
																{
																	IL_F6A:
																	switch (num2)
																	{
																	case 0:
																		if (disposable != null)
																		{
																			num = (short)1084227586;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_FD4;
																	case 1:
																		goto IL_FD2;
																	case 2:
																		disposable.Dispose();
																		num = (short)1482752001;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_F7D;
																}
																IL_FD2:
																IL_FD4:
																goto EndFinally_48;
																IL_F7D:
																IEnumerator enumerator4;
																disposable = (enumerator4 as IDisposable);
																num = (short)167051264;
																num2 = (int)((IntPtr)num);
																goto IL_F6A;
																EndFinally_48:;
															}
															num = (short)777453574;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_9FF;
														IL_AFA:
														num = (short)1560150023;
														num2 = (int)((IntPtr)num);
														continue;
														IL_D49:
														flag = true;
														rptTreeViewItem2 = new RptTreeViewItem();
														rptTreeViewItem2.RptRecordName = acpField2.NewUIName;
														rptTreeViewItem2.Header = acpField2.NewUIName;
														rptTreeViewItem2.ParentID = rptTreeViewItem3.ID;
														rptTreeViewItem2.ItemType = 2;
														rptTreeViewItem2.RptPath = acpField2.Path(RptMgrErrorHandler.b("㖍", a_));
														rptTreeViewItem3.Items.Add(rptTreeViewItem2);
														num = (short)1188429839;
														num2 = (int)((IntPtr)num);
														continue;
														IL_DC4:
														num = (short)1794768914;
														num2 = (int)((IntPtr)num);
														continue;
														IL_9FF:
														goto IL_DC4;
													}
													IL_102A:
													goto IL_380;
												}
												finally
												{
													num = (short)651231232;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator<IAcpField> enumerator2;
														switch (num2)
														{
														case 0:
															switch (0)
															{
															case 0:
																goto IL_1061;
															}
															continue;
														case 1:
															goto IL_1099;
														case 2:
															enumerator2.Dispose();
															num = (short)661454849;
															num2 = (int)((IntPtr)num);
															continue;
														}
														IL_1061:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)1339228162;
														num2 = (int)((IntPtr)num);
													}
													IL_1099:;
												}
												goto IL_109C;
												IL_380:
												num = (short)184287233;
												num2 = (int)((IntPtr)num);
												continue;
											case 16:
												num = (short)786038784;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IL_40A:
											num = (short)1384710154;
											num2 = (int)((IntPtr)num);
											continue;
											IL_2C9:
											goto IL_40A;
											IL_8E7:
											num = (short)1464991753;
											num2 = (int)((IntPtr)num);
											continue;
											IL_109C:
											rptTreeViewItem.Items.Remove(rptTreeViewItem3);
											num = (short)12124164;
											num2 = (int)((IntPtr)num);
										}
										IL_10DD:
										goto IL_1D7;
									}
									finally
									{
										num = (short)230359040;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											IEnumerator<IAcpFeatureSection> enumerator3;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1114;
												}
												continue;
											case 1:
												goto IL_114C;
											case 2:
												enumerator3.Dispose();
												num = (short)1586036737;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IL_1114:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)560463874;
											num2 = (int)((IntPtr)num);
										}
										IL_114C:;
									}
									goto IL_114F;
									IL_1D7:
									num = (short)1279721477;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_121D;
								case 3:
									if (acpRecordset.RecsetId == A_1)
									{
										num = (short)155713543;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)724303874;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
								{
									RptTreeViewItem rptTreeViewItem;
									if (rptTreeViewItem.Items.Count <= 0)
									{
										num = (short)1856110592;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_135;
									}
									continue;
								case 7:
								{
									RptTreeViewItem rptTreeViewItem = new RptTreeViewItem();
									rptTreeViewItem.RptRecordName = acpRecordset.UIName;
									rptTreeViewItem.Header = acpRecordset.UIName;
									rptTreeViewItem.ID = acpRecordset.RecsetId;
									rptTreeViewItem.ParentID = 0;
									rptTreeViewItem.ItemType = 0;
									rptTreeViewItem.RptPath = acpRecordset.Path(RptMgrErrorHandler.b("㖍", a_));
									IAcpFeatureNode acpFeatureNode = acpRecordset[0];
									num = (short)1187053578;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
									if (!enumerator5.MoveNext())
									{
										num = (short)676528132;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_114F;
								case 10:
								{
									IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode != null)
									{
										num = (short)1208942603;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									RptTreeViewItem rptTreeViewItem;
									A_0.Items.Add(rptTreeViewItem);
									IAcpFeatureNode acpFeatureNode;
									IEnumerator<IAcpFeatureSection> enumerator3 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)710082561;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_21B:
								num = (short)867041288;
								num2 = (int)((IntPtr)num);
								continue;
								IL_135:
								goto IL_21B;
								IL_114F:
								acpRecordset = enumerator5.Current;
								num = (short)807141379;
								num2 = (int)((IntPtr)num);
							}
							IL_121D:
							goto IL_99;
						}
						finally
						{
							num = (short)1128660992;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1254;
									}
									continue;
								case 1:
									goto IL_128D;
								case 2:
									enumerator5.Dispose();
									num = (short)1259864065;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_1254:
								if (enumerator5 == null)
								{
									break;
								}
								num = (short)2064318466;
								num2 = (int)((IntPtr)num);
							}
							IL_128D:;
						}
						goto IL_1290;
						IL_99:
						num = (short)153092097;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6F;
					IL_1290:
					this.SortItems(ref A_0);
					num = (short)1936392194;
					num2 = (int)((IntPtr)num);
				}
				IL_12AF:
				IL_12B1:
				num = (short)1824063488;
				short num4 = num;
				bool result;
				return result;
				IL_6F:
				result = true;
				flag = false;
				enumerator5 = FeatureManager.Features.GetEnumerator();
				num = (short)1108672515;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x02000246 RID: 582
		private enum serializeAction
		{
			// Token: 0x04000E7B RID: 3707
			saveAs,
			// Token: 0x04000E7C RID: 3708
			save
		}
	}
}
