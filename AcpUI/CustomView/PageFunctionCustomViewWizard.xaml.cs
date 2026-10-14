using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpCommonLib;
using AcpCommonResources;
using AcpFileHandlerLib;
using AcpUI.Common;
using AcpUtility;

namespace AcpUI.CustomView
{
	// Token: 0x02000071 RID: 113
	public partial class PageFunctionCustomViewWizard : PageFunctionCustomViewWizardBase
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x000733DC File Offset: 0x000715DC
		public PageFunctionCustomViewWizard(CustomViewCreationInfo info)
		{
			int a_ = 17;
			base..ctor();
			this.InitializeComponent();
			this.b.IsChecked = new bool?(true);
			this.a = info;
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(AcpUI.Common.Utility.c("욦\udba8", a_)))
			{
				this.e.FlowDirection = FlowDirection.LeftToRight;
				this.e.TextAlignment = TextAlignment.Right;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0007345C File Offset: 0x0007165C
		private void OnBrowse(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1417805824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				bool? flag;
				bool flag2;
				AcpOpenFileDialog acpOpenFileDialog;
				for (;;)
				{
					IL_30:
					string fileName;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)249102336;
						short num3 = num;
						if (fileName != null)
						{
							num = (short)222822402;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_BD;
					case 3:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)2041315332;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						fileName = acpOpenFileDialog.FileName;
						num = (short)1187413340;
						short num4 = num;
						num = (short)314539356;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BD;
						default:
							num = (short)2046820353;
							if (num != 0)
							{
							}
							num = (short)1873870848;
							if (num != 0)
							{
							}
							num = (short)1699807233;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_4B;
					IL_BD:
					this.e.Text = fileName;
					num = (short)764739584;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_4B:
				acpOpenFileDialog = new AcpOpenFileDialog();
				acpOpenFileDialog.Filter = AcpUI.Common.Utility.c("\udeaa\udeac\udbae\udeb0\udeb2閴킸\udeba쪼첾뇈ꛊꇌ귐戮ﯔ꿖듘럚", a_);
				acpOpenFileDialog.MultiSelect = false;
				flag = acpOpenFileDialog.ShowDialog();
				flag2 = true;
				num = (short)1711996931;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00073630 File Offset: 0x00071830
		private void OnOK(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1138425856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				string text;
				Window window;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (this.a.CustomViewFileBaseline == AcpResources.Full_View)
						{
							num = (short)665124876;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4EB;
					case 1:
						goto IL_239;
					case 2:
						if (this.a.CustomViewFileBaseline == AcpResources.Expert_View)
						{
							num = (short)431292430;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1663303695;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_5C4;
					case 4:
						if (!File.Exists(text))
						{
							num = (short)870776833;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_659;
					case 5:
					{
						num = (short)939130881;
						if (num != 0)
						{
						}
						IEnumerator<IAcpRecordset> enumerator = AppInfoManager.DefaultDocument.Features.GetEnumerator();
						num = (short)2098921478;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)1649868800;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_705;
									}
									continue;
								case 1:
								{
									IEnumerator<IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1193410564;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IAcpRecordset acpRecordset = enumerator.Current;
									acpRecordset.CalculateVisibility(true);
									this.a(acpRecordset);
									num = (short)1709899778;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 3:
									goto IL_784;
								case 4:
									num = (short)892469251;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_737:
								num = (short)1220149249;
								num2 = (int)((IntPtr)num);
								continue;
								IL_705:
								goto IL_737;
							}
							IL_784:
							goto IL_23E;
						}
						finally
						{
							num = (short)707854336;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<IAcpRecordset> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_7BC;
									}
									continue;
								case 1:
									goto IL_7F6;
								case 2:
									enumerator.Dispose();
									num = (short)845611009;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_7BC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1560412162;
								num2 = (int)((IntPtr)num);
							}
							IL_7F6:;
						}
						goto IL_7F9;
					case 7:
						this.a.CustomViewFileBaseline = this.c.Text;
						num = (short)1976893469;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
					{
						bool? isChecked = this.b.IsChecked;
						bool flag = true;
						num = (short)2043412505;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						if (AppInfoManager.DefaultDocument != null)
						{
							num = (short)1677918216;
							num2 = (int)((IntPtr)num);
							continue;
						}
						window.DialogResult = new bool?(false);
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AcpResources.Error_Opening_Default_Codeplug);
						num = (short)1390739459;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						try
						{
							num = (short)1478754306;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								string message;
								switch (num2)
								{
								case 0:
									goto IL_408;
								case 1:
									window.DialogResult = new bool?(false);
									message = "";
									num = (short)2032861190;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_358;
									}
									continue;
								case 3:
									goto IL_408;
								case 4:
									goto IL_4A2;
								case 5:
									message = AcpResources.Error_Reading_Custom_View_File_LangMismatch.AcpStringFormat(new object[]
									{
										text
									});
									num = (short)1439694848;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									if (AppInfoManager.IsCustomViewLanguageMismatch)
									{
										num = (short)1376261;
										num2 = (int)((IntPtr)num);
										continue;
									}
									message = AcpResources.Error_Reading_Custom_View_File.AcpStringFormat(new object[]
									{
										text
									});
									num = (short)824967171;
									num2 = (int)((IntPtr)num);
									continue;
								case 7:
									goto IL_489;
								case 8:
									goto IL_489;
								}
								IL_358:
								if (!AppInfoManager.DefaultDocument.ImportFromXml(this.e.Text, XmlFileType.CustomView))
								{
									num = (short)963969025;
									num2 = (int)((IntPtr)num);
									continue;
								}
								window.DialogResult = new bool?(true);
								num = (short)299958279;
								num2 = (int)((IntPtr)num);
								continue;
								IL_408:
								AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, message);
								num = (short)96075784;
								num2 = (int)((IntPtr)num);
								continue;
								IL_489:
								num = (short)1701576708;
								num2 = (int)((IntPtr)num);
							}
							IL_4A2:
							goto IL_A0A;
						}
						catch (Exception ex)
						{
							string str = AcpResources.Error_Reading_Custom_View_File.AcpStringFormat(new object[]
							{
								text
							});
							AppInfoManager.StatusMsgReport.PostMessage(StatusMsgType.Error, str + AcpUI.Common.Utility.c("袧螩貫", a_) + ex.Message);
							goto IL_A0A;
						}
						goto IL_4EB;
					case 11:
						goto IL_2B3;
					case 12:
						AppInfoManager.CustomViewBaseView = DifferentiatedUserViewType.Full;
						num = (short)1171718157;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						goto IL_9C9;
					case 14:
						AppInfoManager.CustomViewBaseView = DifferentiatedUserViewType.Secret;
						num = (short)922681366;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						if (this.a.CustomViewFileBaseline == AcpResources.Custom_View_File)
						{
							num = (short)41615360;
							short num3 = num;
							num = (short)1933901854;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9C9;
					case 16:
						goto IL_263;
					case 17:
						AppInfoManager.CustomViewBaseView = DifferentiatedUserViewType.Basic;
						num = (short)658767903;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						if (this.a.CustomViewFileBaseline == AcpResources.Basic_View)
						{
							num = (short)751763473;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1200291860;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (!text.EndsWith(AcpUI.Common.Utility.c("蚧튩솫슭", a_)))
						{
							num = (short)280231947;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)56360964;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						if (this.a.CustomViewFileBaseline == AcpResources.Intermediate_View)
						{
							num = (short)1674575893;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7F9;
					case 21:
						AppInfoManager.CustomViewBaseView = DifferentiatedUserViewType.Intermediate;
						num = (short)449511450;
						num2 = (int)((IntPtr)num);
						continue;
					case 22:
						goto IL_9C9;
					case 23:
					{
						bool? isChecked;
						bool flag;
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)1327235079;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a.CustomViewFileBaseline = AcpResources.Custom_View_File;
						text = this.e.Text;
						num = (short)778895387;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 24:
						goto IL_94E;
					case 25:
					{
						bool? isChecked;
						bool flag;
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)513212421;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)618659850;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 26:
						goto IL_9C9;
					case 27:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)1830748184;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1168769043;
						num2 = (int)((IntPtr)num);
						continue;
					case 28:
						goto IL_9C9;
					case 29:
						goto IL_659;
					case 30:
						AppInfoManager.CustomViewBaseView = DifferentiatedUserViewType.Custom;
						num = (short)703922204;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						goto IL_9C9;
					}
					goto IL_B7;
					IL_4EB:
					num = (short)271908866;
					num2 = (int)((IntPtr)num);
					continue;
					IL_659:
					num = (short)405078034;
					num2 = (int)((IntPtr)num);
					continue;
					IL_7F9:
					num = (short)1847590912;
					num2 = (int)((IntPtr)num);
					continue;
					IL_9C9:
					num = (short)2022113289;
					num2 = (int)((IntPtr)num);
				}
				IL_239:
				MessageBox.Show(AcpResources.Does_Not_Exist.AcpStringFormat(new object[]
				{
					text
				}));
				this.e.Text = string.Empty;
				this.e.Focus();
				return;
				IL_263:
				goto IL_A0A;
				IL_2B3:
				MessageBox.Show(AcpResources.Not_Valid_Custom_View_File.AcpStringFormat(new object[]
				{
					text
				}));
				this.e.Text = string.Empty;
				this.e.Focus();
				return;
				IL_5C4:
				goto IL_A0A;
				IL_94E:
				MessageBox.Show(AcpResources.Enter_Full_Path_Custom_View_File);
				this.e.Focus();
				return;
				IL_A0A:
				this.OnReturn(new ReturnEventArgs<CustomViewCreationInfo>(this.a));
				window.Close();
				return;
				IL_B7:
				num = (short)2114967502;
				short num4 = num;
				num = (short)1894111182;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_23E:
					window.DialogResult = new bool?(true);
					num = (short)2108882960;
					num2 = (int)((IntPtr)num);
					goto IL_30;
				default:
				{
					num = (short)1879900160;
					if (num != 0)
					{
					}
					window = (Window)base.Parent;
					this.a.CustomViewFileName = this.e.Text;
					text = null;
					bool? isChecked = this.b.IsChecked;
					bool flag = true;
					num = (short)860880919;
					num2 = (int)((IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00074094 File Offset: 0x00072294
		private void OnRadBtnCheck(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			RadioButton radioButton;
			bool value;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_57;
				case 1:
					return;
				case 2:
					goto IL_8B;
				case 3:
				{
					num2 = (short)1615265793;
					if (num2 != 0)
					{
					}
					this.c.IsEnabled = false;
					this.e.IsEnabled = true;
					this.f.IsEnabled = true;
					num2 = (short)1211926772;
					short num3 = num2;
					num2 = (short)148474100;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num2 = (short)1111031808;
						if (num2 != 0)
						{
						}
						num2 = (short)1316421633;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (radioButton.Name == AcpUI.Common.Utility.c("쎡삣\udca7쒩\udbad쎯욱\udbb3\udbb5펹\ud9bb즽", a_) && value)
					{
						num2 = (short)455278595;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2D;
				IL_57:
				if (radioButton.Name == AcpUI.Common.Utility.c("쎡삣\udca7쒩ﲫ\udcad햯톳킵톷풹\ud9bb\udabd隿ꯁꇃ뇅", a_) && value)
				{
					num2 = (short)1304363010;
					num = (int)((IntPtr)num2);
				}
				else
				{
					num2 = (short)1373634564;
					num = (int)((IntPtr)num2);
				}
			}
			IL_8B:
			num2 = (short)2017263616;
			short num4 = num2;
			this.c.IsEnabled = true;
			this.e.IsEnabled = false;
			this.f.IsEnabled = false;
			return;
			IL_2D:
			radioButton = (RadioButton)A_0;
			value = radioButton.IsChecked.Value;
			num2 = (short)1494548480;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00074288 File Offset: 0x00072488
		private void a(IAcpRecordset A_0)
		{
			short num = (short)952762368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2059405229;
				short num3 = num;
				num = (short)1796999085;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A7:
					switch (0)
					{
					case 0:
						goto IL_C4;
					}
					break;
				default:
					num = (short)291897344;
					if (num != 0)
					{
					}
					num = (short)592379905;
					if (num != 0)
					{
					}
					num = (short)1657470976;
					num2 = (int)((IntPtr)num);
					break;
				}
				IL_B1:
				IEnumerator<IAcpFeatureSection> enumerator2;
				switch (num2)
				{
				case 0:
					goto IL_A7;
				case 1:
					try
					{
						num = (short)182845441;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							IAcpFeatureSection acpFeatureSection;
							IEnumerator<IAcpField> enumerator;
							switch (num2)
							{
							case 0:
								this.a(acpFeatureSection.EmbeddedRecset);
								num = (short)2129854470;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_15A;
								}
								continue;
							case 2:
								if (acpFeatureSection.HasEmbeddedRecset)
								{
									num = (short)1776812032;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1D4;
							case 3:
								try
								{
									num = (short)1347092481;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)506789892;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_266;
											}
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)209977344;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IAcpField acpField = enumerator.Current;
											num = (short)1952841735;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 3:
										{
											IAcpField acpField;
											acpField.CustomViewVisibility = true;
											num = (short)1667956741;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 4:
											goto IL_340;
										case 7:
										{
											IAcpField acpField;
											if (acpField.DifferentiatedUserView <= AppInfoManager.CustomViewBaseView)
											{
												num = (short)125435907;
												num2 = (int)((IntPtr)num);
												continue;
											}
											acpField.CustomViewVisibility = false;
											num = (short)75956230;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_268:
										num = (short)1765081090;
										num2 = (int)((IntPtr)num);
										continue;
										IL_266:
										goto IL_268;
									}
									IL_340:
									break;
								}
								finally
								{
									num = (short)532152320;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_377;
											}
											continue;
										case 1:
											goto IL_3AD;
										case 2:
											enumerator.Dispose();
											num = (short)1712193537;
											num2 = (int)((IntPtr)num);
											continue;
										}
										IL_377:
										if (enumerator == null)
										{
											break;
										}
										num = (short)687276034;
										num2 = (int)((IntPtr)num);
									}
									IL_3AD:;
								}
								goto IL_3B0;
							case 4:
								goto IL_3C9;
							case 5:
								if (!enumerator2.MoveNext())
								{
									num = (short)516423687;
									num2 = (int)((IntPtr)num);
									continue;
								}
								acpFeatureSection = enumerator2.Current;
								num = (short)225181698;
								num2 = (int)((IntPtr)num);
								continue;
							case 6:
								goto IL_1D4;
							case 7:
								goto IL_3B0;
							}
							IL_199:
							num = (short)2113273861;
							num2 = (int)((IntPtr)num);
							continue;
							IL_15A:
							goto IL_199;
							IL_1D4:
							enumerator = acpFeatureSection.FieldsCollection.GetEnumerator();
							num = (short)983433219;
							num2 = (int)((IntPtr)num);
							continue;
							IL_3B0:
							num = (short)531234820;
							num2 = (int)((IntPtr)num);
						}
						IL_3C9:
						return;
					}
					finally
					{
						num = (short)255655936;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_400;
								}
								continue;
							case 1:
								goto IL_436;
							case 2:
								enumerator2.Dispose();
								num = (short)485163009;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_400:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)107413506;
							num2 = (int)((IntPtr)num);
						}
						IL_436:;
					}
					goto IL_439;
				case 2:
					return;
				}
				IL_C4:
				num = (short)406454272;
				short num4 = num;
				if (A_0.Count == 0)
				{
					num = (short)112001026;
					num2 = (int)((IntPtr)num);
					goto IL_B1;
				}
				IL_439:
				enumerator2 = A_0[0].FeatureSectionsCollection.GetEnumerator();
				num = (short)219676673;
				num2 = (int)((IntPtr)num);
				goto IL_B1;
			}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00074814 File Offset: 0x00072A14
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)374669312;
			short num2 = num;
			num = (short)981476770;
			short num3 = num;
			num = (short)493626786;
			switch (num3 == num)
			{
			}
			num = (short)1358495745;
			if (num != 0)
			{
			}
			num = (short)194904064;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x04000308 RID: 776
		private CustomViewCreationInfo a;
	}
}
