using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonResources;
using AcpFileHandlerLib;
using AcpUI.Common;

namespace AcpUI.ImportExport
{
	// Token: 0x02000060 RID: 96
	public partial class PageFunctionImportExport : PageFunctionImportExportBase
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00061ED8 File Offset: 0x000600D8
		public void SetImportProcess(IAcpBatchOperation process)
		{
			short num = (short)1719008749;
			short num2 = num;
			num = (short)1346239981;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1169752064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1428226048;
			if (num != 0)
			{
			}
			num = (short)1827602433;
			if (num != 0)
			{
			}
			ImportExportManager.SetImportProcess(process);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00061F88 File Offset: 0x00060188
		public PageFunctionImportExport(XmlDocument document)
		{
			int a_ = 11;
			this.e = string.Empty;
			base..ctor();
			this.InitializeComponent();
			this.a = document;
			XmlNode xmlNode = document.ChildNodes[1];
			if (!xmlNode.Name.Equals(AcpUI.Common.Utility.c("좠캢햤좦\udba8\udfaa쪮즰쎲\udab4얶춸\ud9bc킾ꋀ", a_)))
			{
				throw new Exception(AcpUI.Common.Utility.c("辠\udba2좤쮦覨슪사\udfae\udeb0솲솴鞶\udfb8튺톼\udabe귂꫄돆꓊ꯌꗐ꫒ꗔ닖律드닞釠賢韤鏦뛨軪闬鿮黰臲致ꣶ鷸铺黼쇾", a_));
			}
			if (!this.CanImport)
			{
				throw new ArgumentException(AcpResources.Operation_Failed_Wrong_Language);
			}
			XmlNode lastChild = xmlNode.LastChild;
			this.b = Convert.ToBoolean(lastChild.Attributes[AcpUI.Common.Utility.c("\udba2햤좦\udba8\udfaa좬쮮\udfb2\ud9b4\udcb8\udaba즼쪾돀ꛂ뛄", a_)].Value.ToString(), CultureInfo.InvariantCulture);
			XmlAttribute xmlAttribute = lastChild.Attributes[AcpUI.Common.Utility.c("첢쮤톦첨\ud9aa\ud9ac쪮쎰킴\ud9b6\udcb8즺\udcbc쮾꓀Ꟃ", a_)];
			if (xmlAttribute != null)
			{
				this.c = Convert.ToBoolean(xmlAttribute.Value.ToString(), CultureInfo.InvariantCulture);
			}
			else
			{
				this.c = false;
			}
			AcpUI.Common.Utility.SetDirection(this);
			this.f.ItemsSource = ImportExportManager.a(document);
			base.Title = AcpResources.XML_Import_From;
			this.i.Content = AcpResources.Import_Id;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000620C4 File Offset: 0x000602C4
		public PageFunctionImportExport()
		{
			this.e = string.Empty;
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.f.ItemsSource = ImportExportManager.a();
			base.Title = AcpResources.XML_Export_To;
			this.i.Content = AcpResources.Export_Id;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0006211C File Offset: 0x0006031C
		private void ListBoxImportExport_SelectionChanged(object A_0, SelectionChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				short num2;
				ListBox listBox;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1917808108;
						short num3 = num2;
						num2 = (short)1808428524;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1591083008;
							if (num2 != 0)
							{
							}
							if (listBox.Items.Count == listBox.SelectedItems.Count)
							{
								num2 = (short)806092803;
								num = (int)((IntPtr)num2);
								continue;
							}
							goto IL_DF;
						}
						break;
					}
					case 1:
						goto IL_1FB;
					case 2:
					{
						num2 = (short)1903951872;
						short num4 = num2;
						num2 = (short)2056912896;
						num = (int)((IntPtr)num2);
						continue;
					}
					case 3:
						this.k.Visibility = Visibility.Visible;
						num2 = (short)1670840321;
						if (num2 != 0)
						{
						}
						num2 = (short)1195376641;
						num = (int)((IntPtr)num2);
						continue;
					case 4:
						if (!this.c)
						{
							num2 = (short)1722679305;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_23D;
					case 5:
						if (this.b)
						{
							num2 = (short)175112194;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_DF;
					case 6:
						if (listBox.SelectedItems.Count > 0)
						{
							num2 = (short)1041039368;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_23D;
					case 7:
						goto IL_1FB;
					case 8:
						num2 = (short)992346116;
						num = (int)((IntPtr)num2);
						continue;
					case 9:
						goto IL_DA;
					}
					break;
					IL_DF:
					this.k.Visibility = Visibility.Hidden;
					num2 = (short)1020002311;
					num = (int)((IntPtr)num2);
					continue;
					IL_1FB:
					num2 = (short)883884038;
					num = (int)((IntPtr)num2);
				}
				IL_38:
				listBox = (ListBox)A_0;
				num2 = (short)1123745797;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			IL_DA:
			this.i.IsEnabled = true;
			return;
			IL_23D:
			this.i.IsEnabled = false;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00062374 File Offset: 0x00060574
		private void BtnSelectAll_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2047610290;
			short num2 = num;
			num = (short)698158514;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_19F:
				this.k.Visibility = Visibility.Visible;
				num = (short)1057751041;
				if (num != 0)
				{
				}
				num = (short)32309252;
				num3 = (int)((IntPtr)num);
				break;
			default:
				num = (short)372441088;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				break;
			}
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
					if (!this.c)
					{
						num = (short)653656069;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CE;
				case 1:
					goto IL_CE;
				case 2:
					num = (short)89718784;
					num3 = (int)((IntPtr)num);
					continue;
				case 3:
					if (this.f.SelectedItems.Count > 0)
					{
						num = (short)1391132674;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
				{
					num = (short)920911872;
					short num4 = num;
					this.i.IsEnabled = true;
					num = (short)244514817;
					num3 = (int)((IntPtr)num);
					continue;
				}
				case 6:
					goto IL_108;
				case 7:
					if (this.b)
					{
						num = (short)1800339462;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_7C;
				IL_CE:
				num = (short)1580400647;
				num3 = (int)((IntPtr)num);
			}
			IL_108:
			goto IL_19F;
			IL_7C:
			this.f.SelectAll();
			num = (short)316801027;
			num3 = (int)((IntPtr)num);
			goto IL_56;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00062570 File Offset: 0x00060770
		private void BtnUnselectAll_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1084751872;
			short num2 = num;
			num = (short)1388461299;
			short num3 = num;
			num = (short)1897807091;
			switch (num3 == num)
			{
			}
			num = (short)426377217;
			if (num != 0)
			{
			}
			num = (short)2034761728;
			if (num != 0)
			{
			}
			this.f.UnselectAll();
			this.k.Visibility = Visibility.Hidden;
			this.i.IsEnabled = false;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00062640 File Offset: 0x00060840
		private void BtnCopy_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)667031870;
			short num2 = num;
			num = (short)2059934014;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1CF:
				AcpUI.Common.Utility.FieldsReportChanged(this, FieldReportType.ImpExp);
				num = (short)1419706373;
				num3 = (int)((IntPtr)num);
				break;
			default:
				num = (short)544473088;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				break;
			}
			for (;;)
			{
				IL_58:
				switch (num3)
				{
				case 0:
					goto IL_17F;
				case 1:
					AppInfoManager.ImportExportFieldsReport = new FieldsReportManager();
					num = (short)777650180;
					num3 = (int)((IntPtr)num);
					continue;
				case 2:
					if (AppInfoManager.ImportExportFieldsReport == null)
					{
						num = (short)623050753;
						num3 = (int)((IntPtr)num);
						continue;
					}
					AppInfoManager.ImportExportFieldsReport.Clear();
					num = (short)1573781507;
					num3 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_B9;
				case 4:
					goto IL_B9;
				case 5:
					goto IL_1ED;
				case 6:
					if (AppInfoManager.ImportExportFieldsReport.HasFields)
					{
						num = (short)2084306944;
						short num4 = num;
						num = (short)1716584448;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1EF;
				}
				goto IL_7A;
				IL_B9:
				num = (short)117899265;
				if (num != 0)
				{
				}
				ImportExportManager.a(this.a, this.f.SelectedItems, XmlFileType.ImpExp, true);
				((Window)base.Parent).Close();
				AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Copy_Operation_Completed, false);
				num = (short)1956904966;
				num3 = (int)((IntPtr)num);
			}
			IL_17F:
			goto IL_1CF;
			IL_1ED:
			IL_1EF:
			this.a();
			return;
			IL_7A:
			this.b();
			num = (short)1997012994;
			num3 = (int)((IntPtr)num);
			goto IL_58;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00062844 File Offset: 0x00060A44
		private bool CanImport
		{
			get
			{
				int a_ = 3;
				short num = (short)2145648640;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_59;
				}
				string text;
				for (;;)
				{
					IL_3B:
					int num3;
					switch (num3)
					{
					case 0:
						goto IL_157;
					case 1:
					{
						XmlElement xmlElement;
						if (xmlElement != null)
						{
							num = (short)604897285;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					case 2:
						goto IL_140;
					case 3:
						PageFunctionImportExport.d = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
						num = (short)1639055364;
						num3 = (int)((IntPtr)num);
						continue;
					case 4:
						goto IL_13B;
					case 5:
					{
						XmlElement xmlElement;
						text = xmlElement.InnerText;
						num = (short)776994818;
						num3 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_59;
					IL_140:
					num = (short)1858011136;
					num3 = (int)((IntPtr)num);
				}
				IL_13B:
				goto IL_1C5;
				IL_157:
				num = (short)1083244545;
				if (num != 0)
				{
				}
				if (PageFunctionImportExport.d == null)
				{
					goto IL_184;
				}
				IL_1C5:
				return text == PageFunctionImportExport.d;
				IL_59:
				num = (short)1333120668;
				short num4 = num;
				num = (short)2101464732;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_184:
					num = (short)560332803;
					int num3 = (int)((IntPtr)num);
					goto IL_3B;
				}
				default:
				{
					num = (short)1602486272;
					if (num != 0)
					{
					}
					text = AcpUI.Common.Utility.c("ﲘ", a_);
					XmlElement xmlElement = this.a[AcpUI.Common.Utility.c("펠힢瘝슦톨\udbaa슬\uddae얰톴\ud8b6\udab8", a_)][AcpUI.Common.Utility.c("햘漢풠슢스슦", a_)];
					num = (short)1131610113;
					int num3 = (int)((IntPtr)num);
					goto IL_3B;
				}
				}
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00062A24 File Offset: 0x00060C24
		public void ExportByCommand(string xmlPath)
		{
			short num = (short)1406337024;
			short num2 = num;
			num = (short)521240078;
			short num3 = num;
			num = (short)1518108174;
			switch (num3 == num)
			{
			}
			num = (short)1392574465;
			if (num != 0)
			{
			}
			num = (short)1352925184;
			if (num != 0)
			{
			}
			this.BtnSelectAll_Click(null, null);
			this.e = xmlPath;
			this.BtnImportExport_Click(null, null);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00062AE4 File Offset: 0x00060CE4
		private void BtnImportExport_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)120193024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				for (;;)
				{
					IL_31:
					bool flag;
					string fileName;
					AcpSaveFileDialog acpSaveFileDialog;
					XmlTextWriter xmlTextWriter;
					XmlDocument xmlDocument;
					switch (num2)
					{
					case 0:
						AcpUI.Common.Utility.FieldsReportChanged(this, FieldReportType.ImpExp);
						num = (short)114556949;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						flag = false;
						goto IL_91E;
					case 2:
						flag = true;
						goto IL_91E;
					case 3:
						if (AppInfoManager.ImportExportFieldsReport == null)
						{
							num = (short)1585250309;
							num2 = (int)((IntPtr)num);
							continue;
						}
						AppInfoManager.ImportExportFieldsReport.Clear();
						num = (short)1226899457;
						if (num != 0)
						{
						}
						num = (short)389480463;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						bool? flag2;
						bool flag3;
						if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
						{
							num = (short)1686372352;
							short num3 = num;
							num = (short)346161169;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3AB;
					}
					case 5:
						AppInfoManager.ImportExportFieldsReport = new FieldsReportManager();
						num = (short)1434386450;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						if (A_0 != null)
						{
							num = (short)1615331352;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_148;
					case 7:
						goto IL_497;
					case 8:
						if (fileName != null)
						{
							num = (short)515178521;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3AB;
					case 9:
						if (string.Equals(((Button)A_0).Content.ToString(), AcpResources.Import_Id, StringComparison.CurrentCulture))
						{
							num = (short)1361379347;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_148;
					case 10:
						if (AppInfoManager.ImportExportFieldsReport.HasFields)
						{
							num = (short)1429536768;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3AB;
					case 11:
					{
						bool? flag2 = acpSaveFileDialog.ShowDialog();
						bool flag3 = true;
						num = (short)385810436;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_625;
							}
							for (;;)
							{
								IL_5F2:
								switch (num2)
								{
								case 0:
									AcpUI.Common.Utility.FieldsReportChanged(this, FieldReportType.ImpExp);
									num = (short)1834811396;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_681;
								case 2:
									((Window)base.Parent).Close();
									num = (short)489816072;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									goto IL_7CA;
								case 4:
									goto IL_7B2;
								case 5:
									if (base.Parent != null)
									{
										num = (short)1178206210;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_748;
								case 6:
									goto IL_681;
								case 7:
									AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Export_Operation_Partial_Fail_Error_Unlimited_ASK_Needed, false);
									TrunkingSystemData.PartialXmlExport = false;
									num = (short)1589444614;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									goto IL_748;
								case 9:
									if (AppInfoManager.ImportExportFieldsReport.HasFields)
									{
										num = (short)457506816;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_7B2;
								case 10:
									if (TrunkingSystemData.PartialXmlExport)
									{
										num = (short)1794113543;
										num2 = (int)((IntPtr)num);
										continue;
									}
									AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Export_Operation_Completed, false);
									num = (short)1541603329;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_625;
								IL_681:
								num = (short)851574793;
								num2 = (int)((IntPtr)num);
								continue;
								IL_748:
								num = (short)990183434;
								num2 = (int)((IntPtr)num);
								continue;
								IL_7B2:
								num = (short)1415512067;
								num2 = (int)((IntPtr)num);
							}
							IL_7CA:
							goto IL_3AB;
							IL_625:
							xmlTextWriter = new XmlTextWriter(fileName, null);
							xmlTextWriter.Formatting = Formatting.Indented;
							xmlDocument.WriteContentTo(xmlTextWriter);
							xmlTextWriter.Flush();
							num = (short)1388838917;
							num2 = (int)((IntPtr)num);
							goto IL_5F2;
						}
						catch (Exception)
						{
							if (xmlTextWriter != null)
							{
								xmlTextWriter.Flush();
							}
							if (base.Parent != null)
							{
								((Window)base.Parent).Close();
							}
							AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Export_Operation_Failed_Error_Writing_File, false);
							AppInfoManager.ImportExportFieldsReport.FieldsReportChanged = true;
							goto IL_3AB;
						}
						finally
						{
							num = (short)1495597057;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									xmlTextWriter.Close();
									num = (short)2121334786;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_832;
								case 2:
								{
									num = (short)906690879;
									short num4 = num;
									num = (short)649724223;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_832;
									default:
										goto IL_8BE;
									}
									break;
								}
								}
								goto IL_84F;
								IL_832:
								switch (0)
								{
								case 0:
									IL_84F:
									if (xmlTextWriter == null)
									{
										goto IL_8D6;
									}
									num = (short)558825472;
									num2 = (int)((IntPtr)num);
									break;
								}
							}
							IL_8BE:
							num = (short)403243008;
							if (num != 0)
							{
							}
							IL_8D6:;
						}
						goto IL_8D7;
					case 13:
						if (base.Parent != null)
						{
							num = (short)933167120;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 14:
						if (fileName.EndsWith(AcpUI.Common.Utility.c("뒙첟", a_)))
						{
							num = (short)1153499158;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1255211037;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						goto IL_58E;
					case 16:
						((Window)base.Parent).Activate();
						num = (short)702218268;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						goto IL_368;
					case 18:
						goto IL_58E;
					case 19:
						ImportExportManager.a(this.a, this.f.SelectedItems, XmlFileType.ImpExp, false);
						((Window)base.Parent).Close();
						AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Import_Operation_Completed, false);
						num = (short)184745994;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						if (A_0 != null)
						{
							num = (short)773128203;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_368;
					case 21:
						goto IL_3AB;
					case 22:
						num = (short)722796570;
						num2 = (int)((IntPtr)num);
						continue;
					case 23:
						((Window)base.Parent).Close();
						num = (short)723189767;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						num = (short)1451032585;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						num = (short)200146958;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						if (this.f.Items.Count != this.f.SelectedItems.Count)
						{
							num = (short)1589051425;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8D7;
					case 27:
						goto IL_3AB;
					case 28:
						return;
					case 29:
						if (base.Parent != null)
						{
							num = (short)603586583;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_497;
					case 30:
						fileName = this.e;
						num = (short)424869920;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						if (A_0 == null)
						{
							num = (short)57475102;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4D2;
					case 32:
						goto IL_4D2;
					case 33:
						num = (short)1854537729;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C0;
					IL_148:
					acpSaveFileDialog = new AcpSaveFileDialog();
					acpSaveFileDialog.Filter = AcpUI.Common.Utility.c("슙肟쒡춣쪥춧\ud9a9貫蚭骯鲱첳\udbb5풷鎹삻钽뫁꧃꫅", a_);
					num = (short)1197146132;
					num2 = (int)((IntPtr)num);
					continue;
					IL_368:
					fileName = acpSaveFileDialog.FileName;
					num = (short)385351711;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3AB:
					this.a();
					num = (short)1341587469;
					num2 = (int)((IntPtr)num);
					continue;
					IL_497:
					AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, AcpResources.Export_Operation_Failed_Must_Have_Xml_Extension, false);
					AppInfoManager.ImportExportFieldsReport.FieldsReportChanged = true;
					num = (short)1936326683;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4D2:
					num = (short)1482096648;
					num2 = (int)((IntPtr)num);
					continue;
					IL_58E:
					num = (short)826802182;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8D7:
					num = (short)1252720642;
					num2 = (int)((IntPtr)num);
					continue;
					IL_91E:
					bool a_2 = flag;
					xmlDocument = ImportExportManager.a(this.f.SelectedItems, a_2);
					xmlTextWriter = null;
					num = (short)1316618252;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_C0:
				this.b();
				num = (short)779812867;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0006347C File Offset: 0x0006167C
		private void b()
		{
			short num = (short)394788864;
			short num2 = num;
			num = (short)583139329;
			if (num != 0)
			{
			}
			num = (short)837376089;
			short num3 = num;
			num = (short)1222269017;
			switch (num3 == num)
			{
			}
			num = (short)286195712;
			if (num != 0)
			{
			}
			this.g.IsEnabled = false;
			this.h.IsEnabled = false;
			this.i.IsEnabled = false;
			this.j.IsEnabled = false;
			this.k.IsEnabled = false;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00063564 File Offset: 0x00061764
		private void a()
		{
			short num = (short)1198325760;
			short num2 = num;
			num = (short)1931476993;
			if (num != 0)
			{
			}
			num = (short)1914889364;
			short num3 = num;
			num = (short)679928980;
			switch (num3 == num)
			{
			}
			num = (short)1461125120;
			if (num != 0)
			{
			}
			this.g.IsEnabled = true;
			this.h.IsEnabled = true;
			this.i.IsEnabled = true;
			this.j.IsEnabled = true;
			this.k.IsEnabled = true;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0006372C File Offset: 0x0006192C
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[DebuggerNonUserCode]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)1615331328;
			short num2 = num;
			num = (short)365981177;
			short num3 = num;
			num = (short)1716547065;
			switch (num3 == num)
			{
			}
			num = (short)587005952;
			if (num != 0)
			{
			}
			num = (short)1036124161;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x040002C0 RID: 704
		private XmlDocument a;

		// Token: 0x040002C1 RID: 705
		private bool b;

		// Token: 0x040002C2 RID: 706
		private bool c;

		// Token: 0x040002C3 RID: 707
		private static string d;

		// Token: 0x040002C4 RID: 708
		private string e;
	}
}
