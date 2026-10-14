using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Printing;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using System.Xml;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using Common;
using CommonResources;
using ConstraintHelper;
using DevComponents.WpfRibbon;
using Microsoft.Win32;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x02000247 RID: 583
	public partial class ReportViewer : Window, IDisposable
	{
		// Token: 0x06001D14 RID: 7444 RVA: 0x00296E4C File Offset: 0x0029504C
		public ReportViewer(reportType rptType, string xmlFile, int fileCreationTime, ref bool retVal)
		{
			int a_ = 10;
			this.l = true;
			base..ctor();
			this.InitializeComponent();
			if (AppInfoManager.ReportsLangSelection == RptMgrErrorHandler.b("ﶎ", a_))
			{
				AppInfoManager.ReportsLangSelection = RptMgrErrorHandler.b("ﶎ벐\ud892슔", a_);
			}
			this.h = xmlFile;
			this.m = "";
			this.n = fileCreationTime;
			this.o = rptType;
			if (this.a(rptType, fileCreationTime))
			{
				retVal = true;
			}
			AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00296EE0 File Offset: 0x002950E0
		public void UpdateStatusBar()
		{
			int a_ = 6;
			short num = (short)979632128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				string radInfoGeneralModelNumber_A8539_UIValue;
				TextBlock textBlock;
				CultureInfo cultureInfo;
				TextBlock textBlock2;
				StatusBarItem statusBarItem;
				StatusBarItem statusBarItem2;
				for (;;)
				{
					IL_30:
					IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("솈늊뺌", a_)))
						{
							num = (short)710017034;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1297809423;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						num = (short)1074790401;
						if (num != 0)
						{
						}
						if (feature != null)
						{
							num = (short)1025900562;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6ED;
					case 2:
						goto IL_4EB;
					case 3:
						goto IL_4EB;
					case 4:
					{
						num = (short)1146421248;
						short num3 = num;
						textBlock.Text = RptMgrErrorHandler.b("좈\udb8a햌꾎ꢐꎒꖔ", a_);
						num = (short)1227816962;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("얈", a_)))
						{
							num = (short)1347289104;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)276758542;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						num = (short)1394737165;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						goto IL_411;
					case 8:
						goto IL_4EB;
					case 9:
						textBlock.Text = RptMgrErrorHandler.b("좈\udf8a\ude8c꾎ꎐꚒꖔꞖ", a_);
						num = (short)538837000;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						textBlock.Text = RptMgrErrorHandler.b("\udf88ﾌﮎ", a_);
						num = (short)1327104023;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						textBlock.Text = RptMgrErrorHandler.b("좈\udb8a햌꾎\udf90ꂒꖔ", a_);
						num = (short)743440406;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_4EB;
					case 13:
						if (!UtilityMack.IsAPX1000i)
						{
							num = (short)800915460;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5BC;
					case 14:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("솈늊뾌", a_)))
						{
							num = (short)1080033286;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5BC;
					case 15:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("솈늊릌", a_)))
						{
							num = (short)107216905;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)179568659;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
					{
						num = (short)193984052;
						short num4 = num;
						num = (short)1638528564;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F9;
						default:
							num = (short)1408565248;
							if (num != 0)
							{
							}
							textBlock.Text = RptMgrErrorHandler.b("좈\udb8a햌꾎튐ﲒﮔ햠욢", a_);
							num = (short)1364131852;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						goto IL_4E6;
					case 18:
					{
						IAcpField acpField = feature.FieldFromPath(string.Concat(new string[]
						{
							AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udb88ﺐ첒\udc94練ﾘ삠힢첤좦잨", a_), cultureInfo),
							RptMgrErrorHandler.b("했", a_),
							AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("캈璉좖킘ﾚ", a_), cultureInfo),
							RptMgrErrorHandler.b("했", a_),
							AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쒈﶐첒\udb94連", a_), cultureInfo)
						}), RptMgrErrorHandler.b("했", a_));
						num = (short)545062933;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 19:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("솈몊뢌\uda8e튐햒겔잖캘궚\udc9c톞", a_)))
						{
							num = (short)455999499;
							num2 = (int)((IntPtr)num);
							continue;
						}
						textBlock.Text = UtilityMack.ProductModelId.Substring(0, 3) + RptMgrErrorHandler.b("ꦈ", a_) + UtilityMack.ProductModelId.Substring(3);
						num = (short)1480785923;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
					{
						IAcpField acpField;
						textBlock2.Text = acpField.ToString();
						num = (short)2077949969;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 21:
					{
						IAcpField acpField;
						if (acpField != null)
						{
							num = (short)1193017364;
							num2 = (int)((IntPtr)num);
							continue;
						}
						textBlock2.Text = "";
						goto IL_3F9;
					}
					case 22:
						goto IL_4EB;
					case 23:
						goto IL_4EB;
					}
					goto IL_97;
					IL_3F9:
					num = (short)484114439;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4EB:
					statusBarItem.Content = textBlock;
					statusBarItem.BorderBrush = Brushes.WhiteSmoke;
					statusBarItem.Width = 200.0;
					this.stsbtmBar.Items.Add(statusBarItem);
					Separator newItem = new Separator();
					this.stsbtmBar.Items.Add(newItem);
					statusBarItem2 = new StatusBarItem();
					textBlock2 = new TextBlock();
					feature = FeatureManager.GetFeature(2049);
					num = (short)1608056833;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5BC:
					num = (short)621674496;
					num2 = (int)((IntPtr)num);
				}
				IL_411:
				IL_4E6:
				IL_6ED:
				statusBarItem2.Content = textBlock2;
				statusBarItem2.BorderBrush = Brushes.WhiteSmoke;
				statusBarItem2.Width = 200.0;
				this.stsbtmBar.Items.Add(statusBarItem2);
				Separator newItem2 = new Separator();
				this.stsbtmBar.Items.Add(newItem2);
				return;
				IL_97:
				cultureInfo = new CultureInfo(AppInfoManager.ReportsLangSelection);
				bool isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				this.stsbtmBar.Items.Clear();
				int masterPageNumber = this.RptViewer.MasterPageNumber;
				StatusBarItem statusBarItem3 = new StatusBarItem();
				statusBarItem3.Content = new TextBlock
				{
					Text = AppResources.Page_Id + masterPageNumber.ToString()
				};
				statusBarItem3.BorderBrush = Brushes.WhiteSmoke;
				statusBarItem3.Width = 400.0;
				this.stsbtmBar.Items.Add(statusBarItem3);
				Separator newItem3 = new Separator();
				this.stsbtmBar.Items.Add(newItem3);
				statusBarItem = new StatusBarItem();
				textBlock = new TextBlock();
				radInfoGeneralModelNumber_A8539_UIValue = (FeatureManager.GetFeature(2049)[0] as RadioInformation).General.RadInfoGeneralModelNumber_A8539_UIValue;
				num = (short)497483781;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0029762C File Offset: 0x0029582C
		public void Dispose()
		{
			short num = (short)721163456;
			short num2 = num;
			num = (short)1694110912;
			switch (num2 == num)
			{
			}
			num = (short)1595932673;
			if (num != 0)
			{
			}
			num = (short)190054400;
			short num3 = num;
			num = (short)566099968;
			if (num != 0)
			{
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x002976E0 File Offset: 0x002958E0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1219166211;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.j.Close();
					this.j = null;
					num = (short)620560386;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					num = (short)1899626500;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_8B;
				case 3:
					num = (short)891813889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 4:
					goto IL_17F;
				case 5:
				{
					if (this.i == null)
					{
						return;
					}
					num = (short)496686607;
					short num3 = num;
					num = (short)1983698447;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
					{
						num = (short)1923678208;
						short num4 = num;
						num = (short)781713408;
						if (num != 0)
						{
						}
						num = (short)966131718;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					this.i.Dispose();
					this.i = null;
					num = (short)1801584647;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					return;
				}
				IL_6C:
				if (disposing)
				{
					num = (short)59047937;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_8B:
				num = (short)836829189;
				num2 = (int)((IntPtr)num);
				continue;
				IL_17F:
				if (this.j == null)
				{
					goto IL_8B;
				}
				num = (short)863961088;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x002978C0 File Offset: 0x00295AC0
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2133262337;
			if (num != 0)
			{
			}
			num = (short)1118392618;
			short num2 = num;
			num = (short)1885753642;
			switch (num2 == num)
			{
			}
			num = (short)887095296;
			short num3 = num;
			num = (short)2115305472;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00297974 File Offset: 0x00295B74
		private void buttonHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 12;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				int num;
				reportType reportType;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)538443783;
						num = (int)((IntPtr)num2);
						continue;
					case 1:
						goto IL_10E;
					case 2:
						num2 = (short)1229586433;
						num = (int)((IntPtr)num2);
						continue;
					case 3:
						goto IL_1A1;
					case 4:
						if (reportType != reportType.RadioInfo)
						{
							num2 = (short)569049088;
							num = (int)((IntPtr)num2);
							continue;
						}
						ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("겎Ꚑ꒔ꂖ겘겚ꮜ爵", a_));
						num2 = (short)477364227;
						num = (int)((IntPtr)num2);
						continue;
					case 5:
					{
						num2 = (short)551124148;
						short num3 = num2;
						num2 = (short)903052468;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10E;
						default:
							num2 = (short)635961344;
							if (num2 != 0)
							{
							}
							goto IL_1A1;
						}
						break;
					}
					case 6:
						goto IL_1A1;
					case 7:
						if (reportType != reportType.Choices)
						{
							num2 = (short)337707010;
							num = (int)((IntPtr)num2);
							continue;
						}
						ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("겎ꆐꞒꞔꦘꪚꮜ咽", a_));
						num2 = (short)1162543110;
						num = (int)((IntPtr)num2);
						continue;
					case 8:
						goto IL_1B8;
					}
					goto IL_3D;
					IL_10E:
					ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("겎ꂒ꒔꺖漢ꖜﺞ", a_));
					num2 = (short)970784773;
					num = (int)((IntPtr)num2);
					continue;
					IL_1A1:
					num2 = (short)1715273736;
					num = (int)((IntPtr)num2);
				}
				IL_1B8:
				goto IL_1BD;
				IL_3D:
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				reportType = this.o;
				num2 = (short)114163716;
				num = (int)((IntPtr)num2);
				goto IL_13;
			}
			catch (Exception)
			{
			}
			IL_1BD:
			num2 = (short)1005256704;
			short num4 = num2;
			num2 = (short)2024865793;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00297BAC File Offset: 0x00295DAC
		private bool a(reportType A_0, int A_1)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1D0;
				case 1:
					return result;
				case 2:
				{
					string text;
					this.j = new XpsDocument(text, FileAccess.ReadWrite);
					this.k = XpsDocument.CreateXpsDocumentWriter(this.j);
					this.k.Write(this.b(A_0).DocumentPaginator);
					this.RptViewer.Document = this.j.GetFixedDocumentSequence();
					this.j.Close();
					result = true;
					num2 = (short)1046544385;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 3:
				{
					bool flag;
					if (flag)
					{
						num2 = (short)1152581642;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					goto IL_107;
				case 5:
					if (!this.h())
					{
						num2 = (short)492371976;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)283181056;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					goto IL_107;
				case 7:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)1316356098;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				}
				case 8:
					goto IL_DC;
				case 9:
					goto IL_107;
				case 10:
					num2 = (short)258080775;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					num2 = (short)847249420;
					num = (int)((IntPtr)num2);
					continue;
				case 12:
					goto IL_107;
				}
				goto IL_4D;
				IL_107:
				num2 = (short)15400963;
				num = (int)((IntPtr)num2);
			}
			IL_DC:
			num2 = (short)225705985;
			if (num2 != 0)
			{
			}
			return result;
			IL_4D:
			num2 = (short)1204314949;
			short num3 = num2;
			num2 = (short)2054185797;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1D0:
				switch (A_0)
				{
				case reportType.RadioInfo:
				{
					bool flag = this.f();
					string text = Global.flowDocPath + ReportFileItem.GetFileNameByRptType(A_0) + A_1.ToString() + RptMgrErrorHandler.b("ꦆﮊﺌ", a_);
					num2 = (short)247791622;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				case reportType.HandOut:
				case reportType.HandOutO2:
				case reportType.HandOutO3:
				case reportType.HandOutO7:
				case reportType.HandOutO5:
				case reportType.HandOutO9:
				case reportType.HandOutE5:
				{
					bool flag = this.a(A_0);
					string text = Global.flowDocPath + ReportFileItem.GetFileNameByRptType(A_0) + A_1.ToString() + RptMgrErrorHandler.b("ꦆﮊﺌ", a_);
					num2 = (short)622657536;
					short num4 = num2;
					num2 = (short)1472725001;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				case reportType.Choices:
				{
					bool flag = this.g();
					string text = Global.flowDocPath + RptMgrErrorHandler.b("펆ﮈ\ud98e톖\udb9e캠삢키쪦첨얪\ud9ac", a_) + A_1.ToString() + RptMgrErrorHandler.b("ꦆﮊﺌ", a_);
					num2 = (short)379453444;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)2086404107;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				}
				break;
			default:
			{
				num2 = (short)1995309056;
				if (num2 != 0)
				{
				}
				bool flag = false;
				string text = string.Empty;
				result = false;
				num2 = (short)1036582917;
				int num = (int)((IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00297F38 File Offset: 0x00296138
		private static void a(string A_0, string A_1, FileSystemRights A_2, AccessControlType A_3)
		{
			short num = (short)783372396;
			short num2 = num;
			num = (short)1557614700;
			switch (num2 == num)
			{
			}
			num = (short)1444741120;
			if (num != 0)
			{
			}
			num = (short)710934528;
			short num3 = num;
			num = (short)728825857;
			if (num != 0)
			{
			}
			FileSecurity accessControl = File.GetAccessControl(A_0);
			accessControl.RemoveAccessRule(new FileSystemAccessRule(A_1, A_2, A_3));
			File.SetAccessControl(A_0, accessControl);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00297FFC File Offset: 0x002961FC
		private IDocumentPaginatorSource b(reportType A_0)
		{
			int a_ = 11;
			short num = (short)2008678404;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_106;
				case 1:
					goto IL_189;
				case 2:
					goto IL_229;
				case 3:
					goto IL_26A;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 5:
					goto IL_2EE;
				case 6:
					goto IL_1E7;
				case 7:
					num = (short)1856897030;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					goto IL_2AB;
				case 9:
					goto IL_147;
				case 10:
					goto IL_1CB;
				case 11:
					goto IL_3A0;
				}
				IL_5D:
				switch (A_0)
				{
				case reportType.RadioInfo:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑쒕聯ﺙ첡슣즥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)1595277313;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.HandOut:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡誣\udea5즧잩삫", a_), FileMode.Open, FileAccess.Read);
					num = (short)208732165;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.HandOutO2:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡钥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)1158873096;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.HandOutO3:
				{
					num = (short)212914295;
					short num3 = num;
					num = (short)921686135;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1702756353;
						if (num != 0)
						{
						}
						num = (short)1624834048;
						if (num != 0)
						{
						}
						this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡閥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
						num = (short)504889355;
						num2 = (int)((IntPtr)num);
						break;
					}
					break;
				}
				case reportType.HandOutO7:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡醥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)1859387401;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.HandOutO5:
				{
					num = (short)670498816;
					short num4 = num;
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡鎥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)381878272;
					num2 = (int)((IntPtr)num);
					break;
				}
				case reportType.HandOutO9:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡龥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)1544028170;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.Choices:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑슕ﾙ鍊좝즟잡펣톧쒩춫쎭\ud9af톱骳캵\ud9b7ힹ킻", a_), FileMode.Open, FileAccess.Read);
					num = (short)603324419;
					num2 = (int)((IntPtr)num);
					break;
				case reportType.HandOutE5:
					this.i = new FileStream(Global.flowDocPath + RptMgrErrorHandler.b("좍ﲏ﶑\ude95聯톝햟횡鎥蚧튩춫쎭\udcaf", a_), FileMode.Open, FileAccess.Read);
					num = (short)1225064450;
					num2 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1947074567;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_106:
			IL_147:
			IL_189:
			IL_1CB:
			IL_1E7:
			IL_229:
			IL_26A:
			IL_2AB:
			IL_2EE:
			IL_3A0:
			FlowDocument flowDocument = XamlReader.Load(this.i) as FlowDocument;
			flowDocument.PageHeight = 900.0;
			flowDocument.ColumnWidth = 750.0;
			flowDocument.MaxPageHeight = 900.0;
			flowDocument.MaxPageWidth = 755.0;
			flowDocument.TextAlignment = TextAlignment.Left;
			return flowDocument;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00298404 File Offset: 0x00296604
		private bool h()
		{
			short num = (short)847380480;
			short num2 = num;
			num = (short)1825568092;
			short num3 = num;
			num = (short)1961424220;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1272709120;
				if (num != 0)
				{
				}
				num = (short)950009857;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					this.a = new XmlDocument();
					this.a.Load(this.h);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					result = false;
				}
				break;
			}
			return result;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x002984F4 File Offset: 0x002966F4
		private void a(ref XmlTextWriter A_0)
		{
			int a_ = 17;
			short num = (short)1662320640;
			short num2 = num;
			num = (short)1639955952;
			short num3 = num;
			num = (short)1565441520;
			switch (num3 == num)
			{
			}
			num = (short)1188954113;
			if (num != 0)
			{
			}
			num = (short)1539506176;
			if (num != 0)
			{
			}
			A_0.WriteStartElement(RptMgrErrorHandler.b("삓流鍊첝쾟햡", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("삓流鍊\udd9d얟캡좣", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("힓秊튡얣좥", a_), RptMgrErrorHandler.b("ꖓ", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("쒓ﮙﮛ솟튡첣", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("튓秊\uda9bﾝ춟쮡좣\udfa5", a_), RptMgrErrorHandler.b("햓ﮙ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("튓秊쾛\uda9f잡", a_), RptMgrErrorHandler.b("ꖓ꒕", a_));
			A_0.WriteString("");
			A_0.WriteEndElement();
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00298670 File Offset: 0x00296870
		public static string convertToArabicDateTime(string dt)
		{
			int a_ = 19;
			short num = (short)537791255;
			short num2 = num;
			num = (short)1604717335;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_197:
				num = (short)1390804995;
				num3 = (int)((IntPtr)num);
				break;
			default:
				num = (short)1471873025;
				if (num != 0)
				{
				}
				num = (short)2069626880;
				if (num != 0)
				{
				}
				num = (short)2096955392;
				switch (num)
				{
				default:
					num = (short)261750785;
					num3 = (int)((IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return dt;
				case 1:
				{
					num = (short)819200000;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_109;
					}
					continue;
				}
				case 2:
				{
					char c;
					if (c != 'م')
					{
						num = (short)558432260;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_191;
				}
				case 3:
					goto IL_1B1;
				case 4:
					num = (short)1364459526;
					num3 = (int)((IntPtr)num);
					continue;
				case 5:
					return dt;
				case 6:
				{
					char c;
					if (c != 'ص')
					{
						num = (short)1083899909;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_191;
				}
				}
				IL_109:
				if (string.IsNullOrEmpty(dt))
				{
					num = (short)2036465664;
					num3 = (int)((IntPtr)num);
				}
				else
				{
					char c = dt[dt.Length - 1];
					num = (short)1454833666;
					num3 = (int)((IntPtr)num);
				}
			}
			return dt;
			IL_191:
			string empty = string.Empty;
			goto IL_197;
			IL_1B1:
			try
			{
				string text = dt.Substring(dt.Length - 1, 1);
				return string.Format(RptMgrErrorHandler.b("ꢗ꾝\udd9f芡\udfa3钥햧誩힫鶭춯", a_), new object[]
				{
					text,
					RptMgrErrorHandler.b("颵", a_),
					dt.Substring(11, 8),
					dt.Substring(0, 10)
				});
			}
			catch (Exception)
			{
				return dt;
			}
			goto IL_191;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x002988D4 File Offset: 0x00296AD4
		private bool g()
		{
			int a_ = 2;
			short num = (short)1502064956;
			short num2 = num;
			num = (short)515682620;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C0;
			case 1:
				break;
			default:
			{
				num = (short)700186624;
				short num3 = num;
				break;
			}
			}
			num = (short)943718401;
			if (num != 0)
			{
			}
			num = (short)1139343360;
			if (num != 0)
			{
			}
			num = (short)1992949760;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_C0:
				int num5 = 0;
				bool result = true;
				CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
				this.b = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ춈歷", a_));
				try
				{
					switch (0)
					{
					case 0:
						goto IL_115;
					}
					XmlTextWriter xmlTextWriter;
					for (;;)
					{
						IL_FA:
						switch (num4)
						{
						case 0:
							if (this.b.Count != 0)
							{
								num = (short)1640038401;
								num4 = (int)((IntPtr)num);
								continue;
							}
							goto IL_7BB;
						case 1:
						{
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("횄ﾊﾐ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임\udf8e햖ﲘﶚ쒠", a_), RptMgrErrorHandler.b("톄ﲈ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첄", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮎ", a_), RptMgrErrorHandler.b("낄랆", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﮈ歷戀", a_), RptMgrErrorHandler.b("쎄", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ붒ﾔﺘ", a_));
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							this.c = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ춈歷뺐벒펔쒠", a_));
							IEnumerator enumerator = this.c.GetEnumerator();
							num = (short)2134769666;
							num4 = (int)((IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								num = (short)1419051008;
								num4 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_5E3;
										}
										continue;
									case 1:
									{
										IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)416940034;
											num4 = (int)((IntPtr)num);
											continue;
										}
										XmlNode xmlNode = (XmlNode)enumerator.Current;
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), RptMgrErrorHandler.b("튄ﾊ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ얐ﮒﲔ튠", a_), RptMgrErrorHandler.b("랄ꮆ뮈꞊뾌ꎎꎐ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ펐", a_), RptMgrErrorHandler.b("Ꚅ솆쾈뮊붌벎튐꒒ꆔ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("햄", a_), RptMgrErrorHandler.b("낄", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄\udd8eﺐ튔", a_));
										this.a(ref xmlTextWriter, xmlNode.Attributes[num5].Value);
										xmlTextWriter.WriteEndElement();
										xmlTextWriter.WriteEndElement();
										num = (short)125894660;
										num4 = (int)((IntPtr)num);
										continue;
									}
									case 2:
										num = (short)1970733059;
										num4 = (int)((IntPtr)num);
										continue;
									case 3:
										goto IL_73E;
									}
									IL_5E8:
									num = (short)1479081985;
									num4 = (int)((IntPtr)num);
									continue;
									IL_5E3:
									goto IL_5E8;
								}
								IL_73E:
								goto IL_364;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_760;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_74D:
									switch (num4)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1414397953;
											num4 = (int)((IntPtr)num);
											continue;
										}
										goto IL_7BA;
									case 1:
										disposable.Dispose();
										num = (short)624164866;
										num4 = (int)((IntPtr)num);
										continue;
									case 2:
										goto IL_7B8;
									}
									goto IL_760;
								}
								IL_7B8:
								IL_7BA:
								goto EndFinally_9;
								IL_760:
								IEnumerator enumerator;
								disposable = (enumerator as IDisposable);
								num = (short)1115750400;
								num4 = (int)((IntPtr)num);
								goto IL_74D;
								EndFinally_9:;
							}
							goto IL_7BB;
							IL_364:
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﺊﾌ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("펄ﮈﾊﾒ풔練滛", a_), RptMgrErrorHandler.b("햄쾌杖殺", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898ﺜ캠톢", a_), RptMgrErrorHandler.b("욄ﾊ솒ﲔ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좄ﮈ", a_), RptMgrErrorHandler.b("뒄ꮆ뢈꞊벌ꎎꂐ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("임\uda8e\ud890킒杖練漢쒠톢", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄ﾊ쾌ﺐﺔ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898쾠캢삤즦\udda8", a_), RptMgrErrorHandler.b("힄歷", a_));
							xmlTextWriter.WriteString(ReportViewer.convertToArabicDateTime(DateTime.Now.ToString(currentUICulture)));
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﺊﾌ", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("펄ﮈﾊﾒ풔練滛", a_), RptMgrErrorHandler.b("햄쾌杖殺", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좄ﮈ", a_), RptMgrErrorHandler.b("뒄ꮆ뢈꞊벌ꎎꂐ", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("임\uda8e\ud890킒杖練漢쒠톢", a_));
							xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첄", a_));
							xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ얆ﾊ歷ﲐ붒\udf94잖\ude98", a_));
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							xmlTextWriter.WriteEndElement();
							num = (short)371195908;
							num4 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_7E0;
						case 4:
							goto IL_7BB;
						}
						goto IL_115;
						IL_7BB:
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.Close();
						num = (short)123666435;
						num4 = (int)((IntPtr)num);
					}
					IL_7E0:
					return result;
					IL_115:
					xmlTextWriter = new XmlTextWriter(Global.flowDocPath + RptMgrErrorHandler.b("쎄ﲊ\ud98cﶎ쎔ﺖﲘ\ud99c쾠슢좤캦쪨薪햬캮\udcb0\udfb2", a_), Encoding.Unicode);
					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﲊ즌", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶄﺌ", a_), RptMgrErrorHandler.b("ﶈﮊ람ꂎ뺐ﾖﲘﲜ辠캢첤쒦\udba8쒪\udeac삮ힰ잲鮴풶횸횺銼좾ꣀ귂ꏄ뿆流﷌ￎﳒ귔뛖듘럚꿞鏠蛢雤苦蟨鿪賬鯮飰鳲鯴", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶄﺌ떎", a_), RptMgrErrorHandler.b("ﶈﮊ람ꂎ뺐ﾖﲘﲜ辠캢첤쒦\udba8쒪\udeac삮ힰ잲鮴풶횸횺銼좾ꣀ귂ꏄ뿆流﷌ￎﳒ귔뛖듘럚", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쮄", a_), RptMgrErrorHandler.b("", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶄ놊ﺌﾎ", a_), RptMgrErrorHandler.b("ﶎ", a_));
					num = (short)471597056;
					num4 = (int)((IntPtr)num);
					goto IL_FA;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00299108 File Offset: 0x00297308
		private void c(ref XmlTextWriter A_0, string A_1)
		{
			int a_ = 12;
			short num = (short)344522752;
			short num2 = num;
			num = (short)1356211972;
			short num3 = num;
			num = (short)2102863620;
			switch (num3 == num)
			{
			}
			num = (short)1388642305;
			if (num != 0)
			{
			}
			num = (short)2053570560;
			if (num != 0)
			{
			}
			Trace.WriteLine(string.Format(RptMgrErrorHandler.b("\udc8e\udf90ꎘ궜", a_), A_1));
			A_0.WriteStartElement(RptMgrErrorHandler.b("\udb8e璉쮘", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("\udb8e璉\uda98ﺚ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("첎ﺐﾒ殺좚ﺞ쾠", a_), RptMgrErrorHandler.b("붎", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("\udf8e漢", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺐ쾚슠좢쮤슦\udaa8\ud8aa", a_), RptMgrErrorHandler.b("붎붐ꆒ릔ꖖ떘ꦚ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺐ\ud99a튠쮢", a_), RptMgrErrorHandler.b("겎힐햒ꖔꞖꪘ\ud89aꪜꮞ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺔ얠", a_), Colors.Coral.ToString());
			A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ쒖", a_), RptMgrErrorHandler.b("뺎ꖐ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ톖\ud8a0", a_), RptMgrErrorHandler.b("캎朗ﮖ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ삖ﲘ煮햠", a_), RptMgrErrorHandler.b("춎ﺐﾒ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐ얠", a_), Colors.Black.ToString());
			A_0.WriteString(RptMgrErrorHandler.b("蚎颐", a_) + A_1);
			A_0.WriteEndElement();
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00299364 File Offset: 0x00297564
		private void a(ref XmlTextWriter A_0, XmlNodeList A_1)
		{
			int a_ = 6;
			short num = (short)1360527360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1757151233;
				if (num != 0)
				{
				}
				num = (short)1826881536;
				short num3 = num;
				CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
				bool isRightToLeft = currentUICulture.TextInfo.IsRightToLeft;
				int num4 = 1;
				bool flag = true;
				bool flag2 = true;
				bool flag3 = true;
				IEnumerator enumerator = A_1.GetEnumerator();
				try
				{
					num = (short)566755350;
					num2 = (int)((IntPtr)num);
					for (;;)
					{
						XmlNode xmlNode;
						string text2;
						switch (num2)
						{
						case 0:
							num = (short)2110980131;
							num2 = (int)((IntPtr)num);
							continue;
						case 1:
							num = (short)1319567392;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							if (xmlNode.Attributes[0].Value != AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈ﮎ좖\udd98漢ﺞﺠ힤쎦첨\ud9aa\udfb0ힲ\udcb4풶\ud8b8쾺튼춾", a_), currentUICulture))
							{
								num = (short)2037055502;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 3:
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("얈풒杖ﮖﶘﺚ캠잢ﲤ슦얨잪슬\ud8ae", a_));
							num = (short)1892679733;
							num2 = (int)((IntPtr)num);
							continue;
						case 4:
							if (num4 % 2 == 0)
							{
								num = (short)1619591171;
								num2 = (int)((IntPtr)num);
								continue;
							}
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("", a_));
							num = (short)1677590572;
							num2 = (int)((IntPtr)num);
							continue;
						case 5:
							goto IL_2F8;
						case 6:
							if (xmlNode.Attributes[0].Value != AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udd88力敖朗ﮔ욘좚쒠삢톤슦춨쪮\udfb0욲ﺶ춸\udeba킼첾", a_), currentUICulture))
							{
								num = (short)124846081;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 7:
							if (!(xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udd88力敖朗ﮔ욘좚쒠삢톤슦춨쪮\udfb0욲ﺶ춸\udeba킼첾", a_), currentUICulture)))
							{
								num = (short)397017131;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_F6B;
						case 8:
						{
							string text;
							try
							{
								text = xmlNode.Attributes[1].Value;
								goto IL_8AB;
							}
							catch (Exception)
							{
								text = "";
								goto IL_8AB;
							}
							goto IL_FD2;
							IL_8AB:
							A_0.WriteString(text);
							text = "";
							text2 = "";
							A_0.WriteEndElement();
							A_0.WriteEndElement();
							A_0.WriteEndElement();
							num4++;
							num = (short)1806827531;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 9:
							text2 = RptMgrErrorHandler.b("ꦈ", a_);
							num = (short)1015414813;
							num2 = (int)((IntPtr)num);
							continue;
						case 10:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈年ﶒﺖﲜﺠ삤쮦첨좪\ud9ac쪮햰튶ힸ캺뗀ꛂ꣄듆", a_), currentUICulture))
							{
								num = (short)1046282279;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)966328360;
							num2 = (int)((IntPtr)num);
							continue;
						case 12:
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("얈풒杖ﮖﶘﺚ캠잢ﲤ슦얨잪슬\ud8ae", a_));
							num = (short)763363391;
							num2 = (int)((IntPtr)num);
							continue;
						case 13:
							goto IL_1152;
						case 14:
							A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88솒杖", a_));
							A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88킒ﮖ", a_));
							A_0.WriteStartElement(RptMgrErrorHandler.b("\ud988ﾌ", a_));
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ솔ﾖ쒠킢횤", a_), RptMgrErrorHandler.b("뢈꞊벌ꎎꆐ뾒ꖔ", a_));
							num = (short)103219204;
							num2 = (int)((IntPtr)num);
							continue;
						case 15:
							goto IL_FD2;
						case 16:
							goto IL_1152;
						case 17:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈年ﶒﺖﲜﺠ삤쮦첨좪\ud9ac쪮햰튶ힸ캺뗀ꛂ꣄듆", a_), currentUICulture))
							{
								num = (short)711065626;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_8F5;
						case 18:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈ﮎ좖\udd98漢ﺞﺠ힤쎦첨\ud9aa\udfb0ힲ\udcb4풶\ud8b8쾺튼춾", a_), currentUICulture))
							{
								num = (short)621936678;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_10E7;
						case 19:
							if (!xmlNode.HasChildNodes)
							{
								num = (short)1659764767;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_10E7;
						case 20:
							num = (short)1059586100;
							num2 = (int)((IntPtr)num);
							continue;
						case 21:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈ﮎ좖\udd98漢ﺞﺠ힤쎦첨\ud9aa\udfb0ힲ\udcb4풶\ud8b8쾺튼춾", a_), currentUICulture))
							{
								num = (short)250216494;
								num2 = (int)((IntPtr)num);
								continue;
							}
							text2 = RptMgrErrorHandler.b("ꦈ", a_);
							num = (short)207683635;
							num2 = (int)((IntPtr)num);
							continue;
						case 22:
							switch (0)
							{
							case 0:
								goto IL_1D5;
							}
							continue;
						case 23:
							if (num4 % 2 == 0)
							{
								num = (short)1032060940;
								num2 = (int)((IntPtr)num);
								continue;
							}
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("", a_));
							num = (short)1078001724;
							num2 = (int)((IntPtr)num);
							continue;
						case 24:
							goto IL_61D;
						case 25:
							goto IL_1152;
						case 26:
							text2 = xmlNode.Attributes[0].Value;
							flag2 = false;
							num = (short)1240727565;
							num2 = (int)((IntPtr)num);
							continue;
						case 27:
							goto IL_2F8;
						case 28:
							goto IL_1152;
						case 29:
							goto IL_1152;
						case 30:
							if (xmlNode.Attributes[0].Value != AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈年ﶒﺖﲜﺠ펤욦삨잪첬춮\uddb0횲襁\udcb8햺좼裀럂ꃄ꫆뫈", a_), currentUICulture))
							{
								num = (short)1318256690;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 31:
							goto IL_CAF;
						case 32:
							if (xmlNode.Attributes[0].Value != AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈年ﶒﺖﲜﺠ삤쮦첨좪\ud9ac쪮햰튶ힸ캺뗀ꛂ꣄듆", a_), currentUICulture))
							{
								num = (short)1623654415;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 33:
							num = (short)592052226;
							num2 = (int)((IntPtr)num);
							continue;
						case 34:
							goto IL_1226;
						case 35:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udd88力敖朗ﮔ욘좚쒠삢톤슦춨쪮\udfb0욲ﺶ춸\udeba킼첾", a_), currentUICulture))
							{
								num = (short)180355127;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_961;
						case 36:
							if (!enumerator.MoveNext())
							{
								num = (short)1215430721;
								num2 = (int)((IntPtr)num);
								continue;
							}
							xmlNode = (XmlNode)enumerator.Current;
							num = (short)1201340423;
							num2 = (int)((IntPtr)num);
							continue;
						case 37:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udd88力敖朗ﮔ욘좚쒠삢톤슦춨쪮\udfb0욲ﺶ춸\udeba킼첾", a_), currentUICulture))
							{
								num = (short)1653669897;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1463549999;
							num2 = (int)((IntPtr)num);
							continue;
						case 38:
							goto IL_F6B;
						case 39:
							text2 = RptMgrErrorHandler.b("ꦈ", a_);
							num = (short)827129910;
							num2 = (int)((IntPtr)num);
							continue;
						case 40:
							if (flag3)
							{
								num = (short)1925513236;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_840;
						case 41:
							if (flag)
							{
								num = (short)551026688;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_961;
						case 42:
							num = (short)267845649;
							num2 = (int)((IntPtr)num);
							continue;
						case 43:
							num = (short)2020278331;
							num2 = (int)((IntPtr)num);
							continue;
						case 44:
							goto IL_E36;
						case 45:
							if (num4 % 2 == 0)
							{
								num = (short)302645297;
								num2 = (int)((IntPtr)num);
								continue;
							}
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("", a_));
							num = (short)1956315202;
							num2 = (int)((IntPtr)num);
							continue;
						case 46:
							text2 = RptMgrErrorHandler.b("ꦈ", a_);
							num = (short)123469849;
							num2 = (int)((IntPtr)num);
							continue;
						case 47:
							if (flag2)
							{
								num = (short)509345834;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_8F5;
						case 48:
							if (num4 % 2 == 0)
							{
								num = (short)1785790528;
								num2 = (int)((IntPtr)num);
								continue;
							}
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("", a_));
							num = (short)675020805;
							num2 = (int)((IntPtr)num);
							continue;
						case 49:
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("얈풒杖ﮖﶘﺚ캠잢ﲤ슦얨잪슬\ud8ae", a_));
							num = (short)456851480;
							num2 = (int)((IntPtr)num);
							continue;
						case 50:
							num = (short)27263038;
							num2 = (int)((IntPtr)num);
							continue;
						case 51:
							goto IL_1152;
						case 52:
							if (xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈ﮎ좖\udd98漢ﺞﺠ힤쎦첨\ud9aa\udfb0ힲ\udcb4풶\ud8b8쾺튼춾", a_), currentUICulture))
							{
								num = (short)390791224;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_840;
						case 53:
							goto IL_E36;
						case 54:
							goto IL_1152;
						case 55:
							text2 = xmlNode.Attributes[0].Value;
							flag = false;
							num = (short)838533136;
							num2 = (int)((IntPtr)num);
							continue;
						case 56:
							text2 = xmlNode.Attributes[0].Value;
							flag3 = false;
							num = (short)350093340;
							num2 = (int)((IntPtr)num);
							continue;
						case 58:
							num = (short)821755922;
							num2 = (int)((IntPtr)num);
							continue;
						case 59:
							if (!(xmlNode.Attributes[0].Value == AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("쪈年ﶒﺖﲜﺠ삤쮦첨좪\ud9ac쪮햰튶ힸ캺뗀ꛂ꣄듆", a_), currentUICulture)))
							{
								num = (short)218824762;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_F6B;
						case 60:
							goto IL_3A1;
						case 61:
						{
							string text;
							try
							{
								text = xmlNode.Attributes[1].Value;
								goto IL_4B9;
							}
							catch (Exception)
							{
								text = "";
								goto IL_4B9;
							}
							goto IL_CAF;
							IL_4B9:
							A_0.WriteString(text);
							text = "";
							text2 = "";
							A_0.WriteEndElement();
							A_0.WriteEndElement();
							A_0.WriteEndElement();
							num4++;
							num = (short)495583289;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 62:
							if (xmlNode.Attributes[0].Value != AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("\udd88力敖朗ﮔ욘\uda9aﺞ좠쾢쒤얦얨캪풰\uddb2살쾺\ud8bc튾닀", a_), currentUICulture))
							{
								num = (short)904658977;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						case 63:
							goto IL_3A1;
						case 64:
							A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈杖ﾚ", a_), RptMgrErrorHandler.b("얈풒杖ﮖﶘﺚ캠잢ﲤ슦얨잪슬\ud8ae", a_));
							num = (short)714670107;
							num2 = (int)((IntPtr)num);
							continue;
						case 65:
							num = (short)643366946;
							num2 = (int)((IntPtr)num);
							continue;
						case 66:
							goto IL_61D;
						}
						goto IL_1D5;
						IL_2F8:
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ힔", a_), RptMgrErrorHandler.b("ꪈ춊쮌뾎ꆐꂒ횔ꂖ궘", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ슐朗", a_), RptMgrErrorHandler.b("뢈릊", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ힐ﺖ", a_), RptMgrErrorHandler.b("좈力﶐", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("\udd88ﮎ킐ﾒﲔ햠", a_), RptMgrErrorHandler.b("\udb88", a_));
						num = (short)101974077;
						num2 = (int)((IntPtr)num);
						continue;
						IL_3A1:
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ힔", a_), RptMgrErrorHandler.b("ꪈ춊쮌뾎ꆐꂒ횔ꂖ궘", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ슐朗", a_), RptMgrErrorHandler.b("뢈릊", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ힐ﺖ", a_), RptMgrErrorHandler.b("좈力﶐", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("\udd88ﮎ킐ﾒﲔ햠", a_), RptMgrErrorHandler.b("\udb88", a_));
						num = (short)1989541896;
						num2 = (int)((IntPtr)num);
						continue;
						IL_61D:
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ힔", a_), RptMgrErrorHandler.b("ꪈ춊쮌뾎ꆐꂒ횔ꂖ궘", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ슐朗", a_), RptMgrErrorHandler.b("뢈릊", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ힐ﺖ", a_), RptMgrErrorHandler.b("좈力﶐", a_));
						num = (short)661520425;
						num2 = (int)((IntPtr)num);
						continue;
						IL_840:
						num = (short)1913258005;
						num2 = (int)((IntPtr)num);
						continue;
						IL_8F5:
						num = (short)1326710794;
						num2 = (int)((IntPtr)num);
						continue;
						IL_961:
						num = (short)700186661;
						num2 = (int)((IntPtr)num);
						continue;
						IL_CAF:
						A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88솒杖", a_));
						A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88킒ﮖ", a_));
						A_0.WriteStartElement(RptMgrErrorHandler.b("\ud988ﾌ", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ솔ﾖ쒠킢횤", a_), RptMgrErrorHandler.b("뢈꞊벌ꎎꆐ뾒ꖔ", a_));
						num = (short)1010106413;
						num2 = (int)((IntPtr)num);
						continue;
						IL_E36:
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ힔", a_), RptMgrErrorHandler.b("ꪈ춊쮌뾎ꆐꂒ횔ꂖ궘", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ슐朗", a_), RptMgrErrorHandler.b("뢈릊", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쾈ﮎ힐ﺖ", a_), RptMgrErrorHandler.b("좈力﶐", a_));
						text2 = xmlNode.Attributes[0].Value;
						Trace.WriteLine(string.Format(RptMgrErrorHandler.b("뮊", a_), text2));
						A_0.WriteString(text2);
						A_0.WriteEndElement();
						A_0.WriteEndElement();
						A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88킒ﮖ", a_));
						A_0.WriteStartElement(RptMgrErrorHandler.b("\ud988ﾌ", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ솔ﾖ쒠킢횤", a_), RptMgrErrorHandler.b("뢈꞊벌ꎎꆐ뾒ꖔ", a_));
						num = (short)657653808;
						num2 = (int)((IntPtr)num);
						continue;
						IL_F6B:
						num = (short)2072707091;
						num2 = (int)((IntPtr)num);
						continue;
						IL_FD2:
						num = (short)1394606110;
						num2 = (int)((IntPtr)num);
						continue;
						IL_103B:
						num = (short)1474953252;
						num2 = (int)((IntPtr)num);
						continue;
						IL_1D5:
						goto IL_103B;
						IL_10E7:
						num = (short)102760454;
						num2 = (int)((IntPtr)num);
						continue;
						IL_1152:
						Trace.WriteLine(string.Format(RptMgrErrorHandler.b("뮊", a_), text2));
						A_0.WriteString(text2);
						A_0.WriteEndElement();
						A_0.WriteEndElement();
						A_0.WriteStartElement(RptMgrErrorHandler.b("\udd88킒ﮖ", a_));
						A_0.WriteStartElement(RptMgrErrorHandler.b("\ud988ﾌ", a_));
						A_0.WriteAttributeString(RptMgrErrorHandler.b("쮈ﾌ솔ﾖ쒠킢횤", a_), RptMgrErrorHandler.b("뢈꞊벌ꎎꆐ뾒ꖔ", a_));
						num = (short)818216983;
						num2 = (int)((IntPtr)num);
					}
					IL_1226:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1248;
					}
					IDisposable disposable;
					for (;;)
					{
						IL_1235:
						switch (num2)
						{
						case 0:
							goto IL_12EE;
						case 1:
							disposable.Dispose();
							num = (short)419561472;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1938277606;
							short num5 = num;
							num = (short)548914406;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_12EE;
							default:
								num = (short)2051080192;
								if (num != 0)
								{
								}
								if (disposable != null)
								{
									num = (short)29294593;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_12F0;
							}
							break;
						}
						}
						goto IL_1248;
					}
					IL_12EE:
					IL_12F0:
					goto EndFinally_31;
					IL_1248:
					disposable = (enumerator as IDisposable);
					num = (short)573964290;
					num2 = (int)((IntPtr)num);
					goto IL_1235;
					EndFinally_31:;
				}
				return;
			}
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0029A6B0 File Offset: 0x002988B0
		private void b(ref XmlTextWriter A_0, string A_1)
		{
			int a_ = 4;
			short num = (short)1602017431;
			short num2 = num;
			num = (short)60348567;
			switch (num2 == num)
			{
			default:
			{
				num = (short)52822016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1131741184;
			if (num != 0)
			{
			}
			num = (short)925827073;
			if (num != 0)
			{
			}
			Trace.WriteLine(string.Format(RptMgrErrorHandler.b("풆있ꮐꖔ", a_), A_1));
			A_0.WriteStartElement(RptMgrErrorHandler.b("펆쎐ﲒ", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("펆튐璉ﮖ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("쒆ﾐ삒", a_), RptMgrErrorHandler.b("떆", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("힆力ﾖ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("얆力잒ﶔﺖ滛爵튠킢", a_), RptMgrErrorHandler.b("떆ꖈ릊ꆌ붎붐ꆒ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("얆力톒", a_), RptMgrErrorHandler.b("ꒆ쾈춊붌뾎ꊐ킒ꊔꎖ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("얆ﲒ練ﶘ", a_), Colors.Coral.ToString());
			A_0.WriteAttributeString(RptMgrErrorHandler.b("솆歷\udc8e", a_), RptMgrErrorHandler.b("뚆놈", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("솆歷즎ﺒﲔﮖ", a_), RptMgrErrorHandler.b("욆ﮈ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("솆歷\ud88e朗ﾖ", a_), RptMgrErrorHandler.b("얆", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("솆力ﲒ練ﶘ", a_), Colors.Black.ToString());
			A_0.WriteString(RptMgrErrorHandler.b("躆肈", a_) + A_1);
			A_0.WriteEndElement();
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0029A910 File Offset: 0x00298B10
		private void a(ref XmlTextWriter A_0, string A_1)
		{
			int a_ = 12;
			short num = (short)1295056896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int num3;
				string text3;
				for (;;)
				{
					IL_31:
					IEnumerator enumerator;
					int num5;
					XmlNodeList xmlNodeList2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_AE3;
					case 2:
						goto IL_9DE;
					case 3:
						try
						{
							num = (short)1864499213;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6EA;
								case 2:
								{
									XmlNode xmlNode;
									if (!xmlNode.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꢎ", a_)))
									{
										num = (short)810090504;
										num2 = (int)((IntPtr)num);
										continue;
									}
									string text = RptMgrErrorHandler.b("궎", a_) + xmlNode.Attributes[0].Value + RptMgrErrorHandler.b("궎", a_);
									num = (short)1601503232;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 3:
									goto IL_686;
								case 4:
									goto IL_686;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1730740239;
										num2 = (int)((IntPtr)num);
										continue;
									}
									XmlNode xmlNode = (XmlNode)enumerator.Current;
									A_0.WriteStartElement(RptMgrErrorHandler.b("\udb8e璉쮘", a_));
									A_0.WriteStartElement(RptMgrErrorHandler.b("\udb8e璉\uda98ﺚ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("첎ﺐﾒ殺좚ﺞ쾠", a_), RptMgrErrorHandler.b("붎", a_));
									A_0.WriteStartElement(RptMgrErrorHandler.b("\udf8e漢", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺐ쾚슠좢쮤슦\udaa8\ud8aa", a_), RptMgrErrorHandler.b("뾎붐ꎒ릔Ꞗ떘ꦚ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺐ\ud99a튠쮢", a_), RptMgrErrorHandler.b("겎힐햒ꖔꞖꪘ\ud89aꪜꮞ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ쒖", a_), RptMgrErrorHandler.b("뺎Ꞑ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ톖\ud8a0", a_), RptMgrErrorHandler.b("캎朗ﮖ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐﶒ삖ﲘ煮햠", a_), RptMgrErrorHandler.b("춎ﺐﾒ", a_));
									A_0.WriteAttributeString(RptMgrErrorHandler.b("즎ﺐ얠", a_), Colors.DarkBlue.ToString());
									A_0.WriteAttributeString(RptMgrErrorHandler.b("춎ﺔ얠", a_), Colors.Coral.ToString());
									A_0.WriteString(xmlNode.Attributes[num3].Value);
									A_0.WriteEndElement();
									A_0.WriteEndElement();
									A_0.WriteEndElement();
									string text = null;
									num = (short)382468098;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
								{
									int num4;
									XmlNodeList xmlNodeList;
									if (num4 >= xmlNodeList.Count)
									{
										num = (short)1006764035;
										num2 = (int)((IntPtr)num);
										continue;
									}
									string text;
									string text2 = this.a.SelectNodes(string.Concat(new string[]
									{
										RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
										text3,
										RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
										num5.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢ﺤ좬첮얰\udab2\udab4\ud9b6蒸", a_),
										text,
										RptMgrErrorHandler.b("튎뺐벒킔殺ﮘ튚햠슢쮤쒦첨\udcb0톲ﲴﺶﶸ蚺骼", a_),
										num4.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔튖連캜爵슠힢첤좦잨", a_)
									})).Item(0).Attributes[0].Value.ToString() + RptMgrErrorHandler.b("꾎", a_) + (num4 + 1).ToString();
									this.c(ref A_0, text2.Replace(RptMgrErrorHandler.b("ꦎ杖ꊘ", a_), RptMgrErrorHandler.b("ꢎ", a_)));
									this.g = this.a.SelectNodes(string.Concat(new string[]
									{
										RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
										text3,
										RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
										num5.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢ﺤ좬첮얰\udab2\udab4\ud9b6蒸", a_),
										text,
										RptMgrErrorHandler.b("튎뺐벒킔殺ﮘ튚햠슢쮤쒦첨\udcb0톲ﲴﺶﶸ蚺骼", a_),
										num4.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔튖連캜爵슠힢첤좦잨蒪芬ﲮﶰ\udcb4튶햸\udfba", a_)
									}));
									this.a(ref A_0, this.g);
									num4++;
									num = (short)1459224583;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 7:
									goto IL_6AA;
								case 8:
								{
									XmlNode xmlNode;
									string text = RptMgrErrorHandler.b("ꢎ", a_) + xmlNode.Attributes[0].Value + RptMgrErrorHandler.b("ꢎ", a_);
									num = (short)1523187721;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 9:
									goto IL_6EA;
								case 10:
								{
									XmlNode xmlNode;
									if (xmlNode.Attributes[num3 + 1].Value == RptMgrErrorHandler.b("즎", a_))
									{
										num = (short)187760652;
										num2 = (int)((IntPtr)num);
										continue;
									}
									string text;
									this.g = this.a.SelectNodes(string.Concat(new string[]
									{
										RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
										text3,
										RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
										num5.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢ﺤ좬첮얰\udab2\udab4\ud9b6蒸", a_),
										text,
										RptMgrErrorHandler.b("튎뺐벒솔\udb96\udf98얠", a_)
									}));
									this.a(ref A_0, this.g);
									XmlNodeList xmlNodeList = this.a.SelectNodes(string.Concat(new string[]
									{
										RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
										text3,
										RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
										num5.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢ﺤ좬첮얰\udab2\udab4\ud9b6蒸", a_),
										text,
										RptMgrErrorHandler.b("튎뺐벒킔殺ﮘ튚햠슢쮤쒦첨", a_)
									}));
									int num4 = 0;
									num = (short)1106444302;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 11:
									goto IL_913;
								case 12:
								{
									string text;
									this.g = this.a.SelectNodes(string.Concat(new string[]
									{
										RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
										text3,
										RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
										num5.ToString(),
										RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢ﺤ좬첮얰\udab2\udab4\ud9b6蒸", a_),
										text,
										RptMgrErrorHandler.b("튎뺐벒펔\udb96\udf98얠", a_)
									}));
									this.a(ref A_0, this.g);
									num = (short)1516765188;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 13:
									switch (0)
									{
									case 0:
										goto IL_1F5;
									}
									continue;
								case 14:
									goto IL_6AA;
								case 15:
									num = (short)1189150731;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_1FA:
								num = (short)120717317;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1F5:
								goto IL_1FA;
								IL_686:
								this.a(ref A_0);
								num = (short)353894401;
								num2 = (int)((IntPtr)num);
								continue;
								IL_6AA:
								num = (short)2092564486;
								num2 = (int)((IntPtr)num);
								continue;
								IL_6EA:
								num = (short)577503242;
								num2 = (int)((IntPtr)num);
							}
							IL_913:
							goto IL_129;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_935;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_922:
								switch (num2)
								{
								case 0:
									goto IL_9DB;
								case 1:
									disposable.Dispose();
									num = (short)768802816;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
								{
									num = (short)231529976;
									short num6 = num;
									num = (short)2091245048;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_9DB;
									default:
										num = (short)979632128;
										if (num != 0)
										{
										}
										if (disposable != null)
										{
											num = (short)1978204161;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_9DD;
									}
									break;
								}
								}
								goto IL_935;
							}
							IL_9DB:
							IL_9DD:
							goto EndFinally_11;
							IL_935:
							disposable = (enumerator as IDisposable);
							num = (short)618332162;
							num2 = (int)((IntPtr)num);
							goto IL_922;
							EndFinally_11:;
						}
						goto IL_9DE;
						IL_129:
						num5++;
						num = (short)366346245;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						goto IL_AE3;
					case 5:
						goto IL_9DE;
					case 6:
						if (xmlNodeList2.Count > 1)
						{
							num = (short)1924923400;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_BE;
					case 7:
						goto IL_BE;
					case 8:
					{
						num = (short)1669595136;
						short num7 = num;
						this.b(ref A_0, A_1 + RptMgrErrorHandler.b("꾎", a_) + (num5 + 1).ToString());
						num = (short)393412615;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						if (!A_1.Contains(RptMgrErrorHandler.b("ꢎ", a_)))
						{
							num = (short)737869835;
							num2 = (int)((IntPtr)num);
							continue;
						}
						text3 = RptMgrErrorHandler.b("궎", a_) + A_1 + RptMgrErrorHandler.b("궎", a_);
						num = (short)432209924;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						if (num5 >= xmlNodeList2.Count)
						{
							num = (short)124387329;
							if (num != 0)
							{
							}
							num = (short)34734080;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.e = this.a.SelectNodes(string.Concat(new string[]
						{
							RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_),
							text3,
							RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢ﺤ銮隰", a_),
							num5.ToString(),
							RptMgrErrorHandler.b("ꢎ첐벒몔쒖ﲘ캠춢", a_)
						}));
						num = (short)1624702982;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						text3 = RptMgrErrorHandler.b("ꢎ", a_) + A_1 + RptMgrErrorHandler.b("ꢎ", a_);
						num = (short)769851393;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_BE:
					enumerator = this.e.GetEnumerator();
					num = (short)1862991875;
					num2 = (int)((IntPtr)num);
					continue;
					IL_9DE:
					num = (short)282066954;
					num2 = (int)((IntPtr)num);
					continue;
					IL_AE3:
					xmlNodeList2 = this.a.SelectNodes(RptMgrErrorHandler.b("ꂎ뺐햒爵猪좨욪좬銮", a_) + text3 + RptMgrErrorHandler.b("튎뺐벒\udc94練ﲜ슠욢", a_));
					num5 = 0;
					num = (short)1317142530;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_68:
				num3 = 0;
				this.a(ref A_0, A_1, 2);
				text3 = A_1;
				num = (short)599195657;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0029B4DC File Offset: 0x002996DC
		private void a(ref XmlTextWriter A_0, string A_1, int A_2)
		{
			int a_ = 19;
			short num = (short)352779909;
			short num2 = num;
			num = (short)385089157;
			switch (num2 == num)
			{
			}
			num = (short)214237184;
			short num3 = num;
			num = (short)148897793;
			if (num != 0)
			{
			}
			num = (short)455016448;
			if (num != 0)
			{
			}
			A_0.WriteStartElement(RptMgrErrorHandler.b("슕聯ﮝ춡펣", a_));
			A_0.WriteStartElement(RptMgrErrorHandler.b("슕聯ﮝ잡좣쪥", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("풕ﮝ튟첣쾥쮧솩슫쮭쎯솱", a_), RptMgrErrorHandler.b("ꚕ뒗ꪙ낛꺝貟邡", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("풕ﮝ튟횣펥\udba7슩", a_), RptMgrErrorHandler.b("떕\ude97\udc99겛꺝邟銡钣隥", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("햕캟풣장욧", a_), A_2.ToString());
			A_0.WriteStartElement(RptMgrErrorHandler.b("욕聯ﶛ劣튟쎡풣캥", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("풕ﮝ튟첣쾥쮧솩슫쮭쎯솱", a_), RptMgrErrorHandler.b("ꚕ뒗ꪙ낛꺝貟邡", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("풕ﮝ튟횣펥\udba7슩", a_), RptMgrErrorHandler.b("떕\ude97\udc99겛꺝鎟鎣銥", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("킕춝즟\ud8a1솣", a_), RptMgrErrorHandler.b("꒕ꪗ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("킕\ud89d솟쾡춣쪥톧", a_), RptMgrErrorHandler.b("힕ﶛ", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("킕증얟쮡쎣캥\udca7", a_), RptMgrErrorHandler.b("풕", a_));
			A_0.WriteAttributeString(RptMgrErrorHandler.b("킕鍊劣튟춡톣좥첧", a_), RptMgrErrorHandler.b("튕聯\udc9d첟힡솣", a_));
			A_0.WriteString(A_1);
			A_0.WriteEndElement();
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0029B720 File Offset: 0x00299920
		private bool a(reportType A_0)
		{
			int a_ = 3;
			short num = (short)1508376576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4AB;
				}
				string radInfoGeneralModelNumber_A8539_UIValue;
				string empty;
				int a_2;
				int a_3;
				int a_4;
				string a_5;
				string a_6;
				bool result;
				for (;;)
				{
					IL_30:
					string a_7;
					string a_8;
					int a_9;
					int a_10;
					int a_11;
					int a_12;
					int a_13;
					int a_14;
					switch (num2)
					{
					case 0:
						num = (short)1569980525;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (UtilityMack.IsPortable())
						{
							num = (short)1818951755;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_148E;
					case 2:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뮉\ud98b춍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)195625039;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1183;
					case 3:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ첓펕", a_)))
						{
							num = (short)637862141;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2CA4;
					case 4:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉잋쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)2047344915;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BDE;
					case 5:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)789577958;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4D;
					case 6:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뮉잋쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)1657405571;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1069;
					case 7:
					{
						if (!UtilityMack.IsPortable())
						{
							goto IL_2CA4;
						}
						num = (short)1323272493;
						short num3 = num;
						num = (short)124946733;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F7B;
						default:
							num = (short)191758336;
							if (num != 0)
							{
							}
							num = (short)407634052;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_1A02;
					case 9:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뢉\ud98b춍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)425852954;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3104;
					case 10:
						if (radInfoGeneralModelNumber_A8539_UIValue.Contains(RptMgrErrorHandler.b("놅즇쒉", a_)))
						{
							num = (short)826671328;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_314D;
					case 11:
						if (UtilityMack.IsPortable())
						{
							num = (short)1779957937;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4D;
					case 12:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ\ud893ﾕ쎡욣쎥쒧蒩ﺭ", a_), 200, 650, 220);
						num = (short)56361045;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ\udc93캕\udd97", a_)))
						{
							num = (short)222167211;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1571;
					case 14:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("킅", a_)))
						{
							num = (short)1865285854;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_314D;
					case 15:
						goto IL_2F3D;
					case 16:
						goto IL_A1E;
					case 17:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뮋뺍ꂏꊑﾕ킛ﾝ슟잡좣袥睊", a_), 300, 650, 200);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1293484216;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						num = (short)1715077263;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (UtilityMack.IsMobile())
						{
							num = (short)192348280;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2CE4;
					case 20:
						goto IL_36C0;
					case 21:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뮍ꂏꊑ\ud893ﾕ", a_)))
						{
							num = (short)106561803;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B4D;
					case 22:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\ud98b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1322254375;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_334E;
					case 23:
						if (UtilityMack.IsPortable())
						{
							num = (short)1814954051;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_26E0;
					case 24:
						goto IL_26E0;
					case 25:
						if (UtilityMack.IsMobile())
						{
							num = (short)300351574;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B4D;
					case 26:
						num = (short)1622474793;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇붉\ud88b즍풏ꮑ쒓솕ꦗ\udb99튛", a_)))
						{
							num = (short)782630929;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1EB3;
					case 28:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뮉\udf8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)1094058049;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1183;
					case 29:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("햅\uda87튉뺋벍ꂏꊑ쮓\uda95聯鍊얟욡誣", a_), 200, 650, 220);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1384841457;
						num2 = (int)((IntPtr)num);
						continue;
					case 30:
						if (radInfoGeneralModelNumber_A8539_UIValue.Trim().ToUpper().Contains(RptMgrErrorHandler.b("톅뾇", a_)))
						{
							num = (short)196608157;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉릋뺍ꂏꊑ쮓\udb95ꪗ얙킛ﾝ슟잡좣쎥첧蒩ﺭ", a_), 200, 590, 220);
						num = (short)1855586403;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅낇뺉\ud98b춍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)162332924;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2A25;
					case 32:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅낇뺉\udf8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)1293221977;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2A25;
					case 33:
						goto IL_1F93;
					case 34:
						if (UtilityMack.IsPortable())
						{
							num = (short)2085879912;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1571;
					case 35:
						goto IL_2488;
					case 36:
						if (UtilityMack.IsPortable())
						{
							num = (short)792854589;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_20B6;
					case 37:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅몇뾉풋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)711196911;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_36C0;
					case 38:
						a_7 = RptMgrErrorHandler.b("즅붇행잋\ude8d\udd8fꎑ쮓ꂕ궗ꪙ겛튝즟ﶡ장쪧쾩삫쮭풯鲱ﺳﾷ", a_);
						num = (short)1411711126;
						num2 = (int)((IntPtr)num);
						continue;
					case 39:
						num = (short)1473118349;
						num2 = (int)((IntPtr)num);
						continue;
					case 40:
						if (UtilityMack.IsPortable())
						{
							num = (short)1075314793;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3779;
					case 41:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뢉\udd8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)2045640880;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3104;
					case 42:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉릋뺍ꂏꊑ", a_)))
						{
							num = (short)996802706;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2192;
					case 43:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뢋뺍ꂏꊑ\ud893ﾕ", a_)))
						{
							num = (short)1202389191;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1069;
					case 44:
						if (UtilityMack.IsAPX2000APX4000With2Knobs)
						{
							num = (short)796196921;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_148E;
					case 45:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udb8b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)98959368;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A4D;
					case 46:
						num = (short)1569980458;
						num2 = (int)((IntPtr)num);
						continue;
					case 47:
						if (UtilityMack.IsAPX1000i)
						{
							num = (short)557121604;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_23A5;
					case 48:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995펛겝躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("즅몇행잋\ude8d\udd8fꎑ쮓\uda95聯鍊얟욡誣", a_), 250, 600, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1563230336;
						num2 = (int)((IntPtr)num);
						continue;
					case 49:
						goto IL_A1E;
					case 50:
						goto IL_19C2;
					case 51:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ", a_)))
						{
							num = (short)2024931600;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)308412425;
						num2 = (int)((IntPtr)num);
						continue;
					case 52:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뺋뺍ꂏꊑ", a_)))
						{
							num = (short)931070217;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)258146347;
						num2 = (int)((IntPtr)num);
						continue;
					case 53:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉릋뮍ꂏꊑ", a_)))
						{
							num = (short)1959461029;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_10F1;
					case 54:
						goto IL_2192;
					case 55:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ첓펕", a_)))
						{
							num = (short)1633943759;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 56:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)1248329908;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_BB4;
					case 57:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뺋뺍ꂏꊑ쮓ꊕꢗꪙ겛솝銟ﶡ좥잧좩톯킱톳\udab5\uddb7\udeb9銻풽낿ꗁ", a_), 300, 590, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1061093494;
						num2 = (int)((IntPtr)num);
						continue;
					case 58:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udd8b쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)1603666031;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_38DE;
					case 59:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ\ud893ﾕ", a_)))
						{
							num = (short)275185676;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑﾕ킛ﾝ슟잡좣袥睊", a_), 200, 650, 220);
						num = (short)91947243;
						num2 = (int)((IntPtr)num);
						continue;
					case 60:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅낇뺉\udd8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)300875916;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2A25;
					case 61:
						num = (short)1359020122;
						num2 = (int)((IntPtr)num);
						continue;
					case 62:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\udc87\ud989뺋뮍ꂏꊑ", a_)))
						{
							goto IL_1F7B;
						}
						goto IL_E9A;
					case 63:
						num = (short)1127284909;
						num2 = (int)((IntPtr)num);
						continue;
					case 64:
						return result;
					case 65:
						num = (short)18087942;
						num2 = (int)((IntPtr)num);
						continue;
					case 66:
						num = (short)781385921;
						num2 = (int)((IntPtr)num);
						continue;
					case 67:
						num = (short)1572012102;
						num2 = (int)((IntPtr)num);
						continue;
					case 68:
						num = (short)1534656781;
						num2 = (int)((IntPtr)num);
						continue;
					case 69:
						goto IL_314D;
					case 70:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅벇뎉\ud88b즍풏ꮑ쒓솕ꦗ\udb99튛", a_)))
						{
							num = (short)1367605436;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_26E0;
					case 71:
						if (UtilityMack.IsPortable())
						{
							num = (short)662110338;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_314D;
					case 72:
						if (UtilityMack.IsPortable())
						{
							num = (short)1372324124;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19C2;
					case 73:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						num = (short)840564918;
						num2 = (int)((IntPtr)num);
						continue;
					case 74:
						num = (short)254869693;
						num2 = (int)((IntPtr)num);
						continue;
					case 75:
						num = (short)75497516;
						num2 = (int)((IntPtr)num);
						continue;
					case 76:
						num = (short)120193028;
						num2 = (int)((IntPtr)num);
						continue;
					case 77:
						num = (short)1485832463;
						num2 = (int)((IntPtr)num);
						continue;
					case 78:
						goto IL_2CA4;
					case 79:
						num = (short)1878851671;
						num2 = (int)((IntPtr)num);
						continue;
					case 80:
						a_8 = RptMgrErrorHandler.b("쎅붇행잋\ude8d\udd8fꎑ쮓ꎕ궗ꪙ겛솝쎡욣쎥쒧쾩좫肭絛", a_);
						num = (short)396230778;
						num2 = (int)((IntPtr)num);
						continue;
					case 81:
						if (UtilityMack.IsMobile())
						{
							num = (short)1381826752;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 82:
						if (UtilityMack.IsPortable())
						{
							num = (short)767033492;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2F3D;
					case 83:
						if (UtilityMack.IsPortable())
						{
							num = (short)36634815;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_175C;
					case 84:
						num = (short)806879388;
						num2 = (int)((IntPtr)num);
						continue;
					case 85:
						goto IL_253D;
					case 86:
						num = (short)1012596757;
						num2 = (int)((IntPtr)num);
						continue;
					case 87:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뮉\udd8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)945684581;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1183;
					case 88:
						num = (short)1053425815;
						num2 = (int)((IntPtr)num);
						continue;
					case 89:
						num = (short)2047803423;
						num2 = (int)((IntPtr)num);
						continue;
					case 90:
						if (UtilityMack.IsWorldWidePro)
						{
							num = (short)2013593673;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_20B6;
					case 91:
						goto IL_20B6;
					case 92:
						num = (short)232783925;
						num2 = (int)((IntPtr)num);
						continue;
					case 93:
						if (UtilityMack.IsPortable())
						{
							num = (short)220594264;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_256B;
					case 94:
						if (UtilityMack.IsMobile())
						{
							num = (short)1324220508;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_10F1;
					case 95:
						goto IL_10F1;
					case 96:
						num = (short)1941176420;
						num2 = (int)((IntPtr)num);
						continue;
					case 97:
						if (A_0 == reportType.HandOutO3)
						{
							num = (short)442040499;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_CDB;
					case 98:
						goto IL_2B4D;
					case 99:
						goto IL_1D4A;
					case 100:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udf8b쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)771227905;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A02;
					case 101:
						num = (short)1185546268;
						num2 = (int)((IntPtr)num);
						continue;
					case 102:
						num = (short)1803026652;
						num2 = (int)((IntPtr)num);
						continue;
					case 103:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995펛ꮝ躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						a_7 = RptMgrErrorHandler.b("즅붇행잋\ude8d\udd8fꎑ쮓\uda95聯鍊얟욡誣", a_);
						a_9 = 250;
						a_10 = 600;
						a_11 = 300;
						num = (short)508231774;
						num2 = (int)((IntPtr)num);
						continue;
					case 104:
						num = (short)551157773;
						num2 = (int)((IntPtr)num);
						continue;
					case 105:
						num = (short)1663762677;
						num2 = (int)((IntPtr)num);
						continue;
					case 106:
						goto IL_38DE;
					case 107:
						goto IL_3779;
					case 108:
						num = (short)1042612407;
						num2 = (int)((IntPtr)num);
						continue;
					case 109:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅릇뾉잋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1046937770;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FD0;
					case 110:
						num = (short)1221001217;
						if (num != 0)
						{
						}
						num = (short)910295095;
						num2 = (int)((IntPtr)num);
						continue;
					case 111:
						num = (short)470417634;
						num2 = (int)((IntPtr)num);
						continue;
					case 112:
						a_7 = RptMgrErrorHandler.b("즅붇행잋\ude8d\udd8fꎑ쮓ꂕ궗ꪙ겛솝쎡욣쎥쒧쾩좫肭絛", a_);
						num = (short)1676148863;
						num2 = (int)((IntPtr)num);
						continue;
					case 113:
						if (UtilityMack.IsPortable())
						{
							num = (short)1930952859;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B0E;
					case 114:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅릇뾉풋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)106365126;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FD0;
					case 115:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ\udc93", a_)))
						{
							num = (short)830144647;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2BE6;
					case 116:
						if (UtilityMack.IsAPX1000i)
						{
							num = (short)584974469;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_28A0;
					case 117:
						goto IL_A1E;
					case 118:
						goto IL_148E;
					case 119:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉잋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1603338482;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A02;
					case 120:
						num = (short)1810235606;
						num2 = (int)((IntPtr)num);
						continue;
					case 121:
						goto IL_BB4;
					case 122:
						goto IL_2222;
					case 123:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉릋뮍ꂏꊑ", a_)))
						{
							num = (short)633929808;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2222;
					case 124:
						if (UtilityMack.IsPortable())
						{
							num = (short)200736969;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2BE6;
					case 125:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ첓펕잗횙ﶛﲝ얟캡솣슥蚧ﲫ", a_), 200, 650, 220);
						num = (short)1685782703;
						num2 = (int)((IntPtr)num);
						continue;
					case 126:
						if (A_0 == reportType.HandOutO2)
						{
							num = (short)656801840;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3631;
					case 127:
						goto IL_2CE4;
					case 128:
						goto IL_3631;
					case 129:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉펋삍햏쪑삓즕풗ﮙﺛﮝ첟잡삣袥睊", a_), 300, 650, 320);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1656422636;
						num2 = (int)((IntPtr)num);
						continue;
					case 130:
						num = (short)543424526;
						num2 = (int)((IntPtr)num);
						continue;
					case 131:
						goto IL_1183;
					case 132:
						num = (short)248381443;
						num2 = (int)((IntPtr)num);
						continue;
					case 133:
						num = (short)217448470;
						num2 = (int)((IntPtr)num);
						continue;
					case 134:
						if (A_0 == reportType.HandOutE5)
						{
							num = (short)976289945;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2488;
					case 135:
						goto IL_27B0;
					case 136:
						goto IL_344F;
					case 137:
						num = (short)616235270;
						num2 = (int)((IntPtr)num);
						continue;
					case 138:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅몇뾉잋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1858863335;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FD0;
					case 139:
						num = (short)1317929083;
						num2 = (int)((IntPtr)num);
						continue;
					case 140:
						num = (short)797638688;
						num2 = (int)((IntPtr)num);
						continue;
					case 141:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udd8b쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)316014820;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_334E;
					case 142:
						if (UtilityMack.IsPortable())
						{
							num = (short)42598612;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E0B;
					case 143:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뾉\ud88b즍얏ꮑ쒓솕ꂗ\udb99튛", a_)))
						{
							num = (short)880214124;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_25AA;
					case 144:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("킅춑ꚓ즕풗ﮙﺛﮝ첟잡삣袥슧\udaa9쮫", a_), 300, 590, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, !Product.IsVertex());
						num = (short)721879286;
						num2 = (int)((IntPtr)num);
						continue;
					case 145:
						if (UtilityMack.IsMobile())
						{
							num = (short)1585971381;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_CDB;
					case 146:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						num = (short)936247326;
						num2 = (int)((IntPtr)num);
						continue;
					case 147:
						goto IL_8C7;
					case 148:
						num = (short)679149737;
						num2 = (int)((IntPtr)num);
						continue;
					case 149:
						num = (short)285605950;
						num2 = (int)((IntPtr)num);
						continue;
					case 150:
						goto IL_2EA7;
					case 151:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("햅\uda87튉뺋벍ꂏꊑ", a_)))
						{
							num = (short)1641545757;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_256B;
					case 152:
						goto IL_2720;
					case 153:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995\ud99bꮝ躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						a_8 = RptMgrErrorHandler.b("쎅붇행잋\ude8d\udd8fꎑ쮓\uda95聯鍊얟욡誣", a_);
						a_12 = 250;
						a_13 = 600;
						a_14 = 300;
						num = (short)469500151;
						num2 = (int)((IntPtr)num);
						continue;
					case 154:
						goto IL_CDB;
					case 155:
						num = (short)859766956;
						num2 = (int)((IntPtr)num);
						continue;
					case 156:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udd8b쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)663879913;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BDE;
					case 157:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉릋뺍ꂏꊑ쮓\udb95ꮗ얙킛ﾝ슟잡좣쎥첧蒩ﺭ", a_), 200, 590, 220);
						num = (short)646971646;
						num2 = (int)((IntPtr)num);
						continue;
					case 158:
						goto IL_1601;
					case 159:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udf8b쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)962592834;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_334E;
					case 160:
						if (UtilityMack.IsPortable())
						{
							num = (short)853344474;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1EB3;
					case 161:
						goto IL_BB4;
					case 162:
						if (UtilityMack.IsPortable())
						{
							num = (short)371130616;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_28A0;
					case 163:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뾋뺍ꂏꊑ", a_)))
						{
							num = (short)1186791692;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19C2;
					case 164:
						num = (short)146014268;
						num2 = (int)((IntPtr)num);
						continue;
					case 165:
						a_7 = RptMgrErrorHandler.b("즅붇행잋\ude8d\udd8fꎑ쮓ꎕ궗ꪙ겛솝쎡욣쎥쒧쾩좫肭絛", a_);
						num = (short)2131820639;
						num2 = (int)((IntPtr)num);
						continue;
					case 166:
						if (UtilityMack.IsPortable())
						{
							num = (short)1216020729;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1601;
					case 167:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udb8b춍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)1208156365;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_23A5;
					case 168:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뢉잋쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)1041039620;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1241710644;
						num2 = (int)((IntPtr)num);
						continue;
					case 169:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뢋뺍ꂏꊑ첓\ude95", a_)))
						{
							num = (short)1606222011;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2F3D;
					case 170:
						num = (short)1621688458;
						num2 = (int)((IntPtr)num);
						continue;
					case 171:
						goto IL_2300;
					case 172:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉겋삍햏쪑삓", a_)))
						{
							num = (short)1798570113;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B0E;
					case 173:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udb8b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1256784109;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_28A0;
					case 174:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅뮇뾉\ud98b춍쒏ꮑ쒓솕ꂗ\udb99튛", a_)))
						{
							num = (short)1793523712;
							short num4 = num;
							num = (short)1971388693;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1601;
					case 175:
						goto IL_253D;
					case 176:
						num = (short)28836106;
						num2 = (int)((IntPtr)num);
						continue;
					case 177:
						num = (short)884736005;
						num2 = (int)((IntPtr)num);
						continue;
					case 178:
						if (UtilityMack.IsPortable())
						{
							num = (short)868942083;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_BB4;
					case 179:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995펛궝躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("즅뮇행쾋ﺏ秊튙鍊ﾝ쒟얣쒥춧용즫쪭麯", a_), 250, 600, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)620101786;
						num2 = (int)((IntPtr)num);
						continue;
					case 180:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ쮓꒕잗톙슟ﶡ장쪧쾩삫肭\udaaf슱펳", a_), 300, 590, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)882507897;
						num2 = (int)((IntPtr)num);
						continue;
					case 181:
						num = (short)1889206369;
						num2 = (int)((IntPtr)num);
						continue;
					case 182:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅낇뺉잋쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)133890212;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2A25;
					case 183:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅벇뾉\ud88b즍얏ꮑ쒓솕ꂗ\udb99튛", a_)))
						{
							num = (short)1844904191;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E26;
					case 184:
						goto IL_1EB3;
					case 185:
						if (UtilityMack.IsPortable())
						{
							num = (short)1575485514;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_36C0;
					case 186:
						if (UtilityMack.IsPortable())
						{
							num = (short)716898322;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E26;
					case 187:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뢋뺍ꂏꊑ첓\ude95잗횙ﶛﲝ얟캡誣첥\ud8a7충", a_), 300, 590, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1941635087;
						num2 = (int)((IntPtr)num);
						continue;
					case 188:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("삅쎍ﾓꞕ잗횙ﶛﲝ얟캡솣슥蚧ﲫ", a_), 200, 650, 220);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1817837592;
						num2 = (int)((IntPtr)num);
						continue;
					case 189:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅몇뾉\ud98b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)601882906;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FD0;
					case 190:
						goto IL_1E26;
					case 191:
						num = (short)525467929;
						num2 = (int)((IntPtr)num);
						continue;
					case 192:
						num = (short)1202192510;
						num2 = (int)((IntPtr)num);
						continue;
					case 193:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉잋쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)2071986239;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_334E;
					case 194:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅릇뾉\ud98b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)658309120;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FD0;
					case 195:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ", a_)))
						{
							num = (short)1410990343;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E0B;
					case 196:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995펛ꞝ躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("즅놇행쾋揄ﺑ\udc93聯ﺙ킛ﾝ슟잡좣쎥첧蒩ﺭ", a_), 225, 650, 250);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)592117907;
						num2 = (int)((IntPtr)num);
						continue;
					case 197:
						goto IL_2A25;
					case 198:
						num = (short)694222885;
						num2 = (int)((IntPtr)num);
						continue;
					case 199:
						num = (short)1698365442;
						num2 = (int)((IntPtr)num);
						continue;
					case 200:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뮍ꂏꊑ\ud893ﾕ", a_)))
						{
							num = (short)1384644646;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2EA7;
					case 201:
						num = (short)709099635;
						num2 = (int)((IntPtr)num);
						continue;
					case 202:
						if (UtilityMack.IsPortable())
						{
							num = (short)148242534;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_26A1;
					case 203:
						num = (short)1033371858;
						num2 = (int)((IntPtr)num);
						continue;
					case 204:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udb8b춍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)489881706;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_26A1;
					case 205:
						goto IL_1BDE;
					case 206:
						num = (short)148373551;
						num2 = (int)((IntPtr)num);
						continue;
					case 207:
						num = (short)1329201428;
						num2 = (int)((IntPtr)num);
						continue;
					case 208:
						if (radInfoGeneralModelNumber_A8539_UIValue.Contains(RptMgrErrorHandler.b("낅즇쒉", a_)))
						{
							num = (short)437256336;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_175C;
					case 209:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\ud98b춍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1600651401;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A02;
					case 210:
						if (A_0 == reportType.HandOutO9)
						{
							num = (short)2002649284;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8C7;
					case 211:
						num = (short)1949237469;
						num2 = (int)((IntPtr)num);
						continue;
					case 212:
						num = (short)1074659523;
						num2 = (int)((IntPtr)num);
						continue;
					case 213:
						goto IL_A1E;
					case 214:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뮍ꂏꊑ", a_)))
						{
							num = (short)2083979376;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2CE4;
					case 215:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅낇뺉\udb8b춍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)1656094917;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2068054067;
						num2 = (int)((IntPtr)num);
						continue;
					case 216:
						goto IL_BB4;
					case 217:
						goto IL_E0B;
					case 218:
						num = (short)75956251;
						num2 = (int)((IntPtr)num);
						continue;
					case 219:
						goto IL_BB4;
					case 220:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)203489357;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_26A1;
					case 221:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뮍ꂏꊑ", a_)))
						{
							num = (short)80544005;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_344F;
					case 222:
						num = (short)1952317450;
						num2 = (int)((IntPtr)num);
						continue;
					case 223:
						if (UtilityMack.IsMobile())
						{
							num = (short)239272139;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8C7;
					case 224:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("킅춑ꞓ즕풗ﮙﺛﮝ첟잡삣袥슧\udaa9쮫", a_), 300, 590, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, !Product.IsVertex());
						num = (short)931201093;
						num2 = (int)((IntPtr)num);
						continue;
					case 225:
						if (UtilityMack.IsPortable())
						{
							num = (short)868548757;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E9A;
					case 226:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udf8b쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)666173672;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_38DE;
					case 227:
						num = (short)14287048;
						num2 = (int)((IntPtr)num);
						continue;
					case 228:
						num = (short)1997602975;
						num2 = (int)((IntPtr)num);
						continue;
					case 229:
						goto IL_A1E;
					case 230:
						num = (short)1483473105;
						num2 = (int)((IntPtr)num);
						continue;
					case 231:
						num = (short)33554546;
						num2 = (int)((IntPtr)num);
						continue;
					case 232:
						num = (short)1764884759;
						num2 = (int)((IntPtr)num);
						continue;
					case 233:
						num = (short)71631118;
						num2 = (int)((IntPtr)num);
						continue;
					case 234:
						if (A_0 == reportType.HandOutO7)
						{
							num = (short)1680605457;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 235:
						goto IL_253D;
					case 236:
						goto IL_2B0E;
					case 237:
						goto IL_334E;
					case 238:
						goto IL_BB4;
					case 239:
						goto IL_2FD0;
					case 240:
						if (UtilityMack.IsPortable())
						{
							num = (short)810418382;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_23A5;
					case 241:
						goto IL_256B;
					case 242:
						num = (short)1160839213;
						num2 = (int)((IntPtr)num);
						continue;
					case 243:
						if (A_0 == reportType.HandOutO5)
						{
							num = (short)1656029287;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2720;
					case 244:
						num = (short)335937704;
						num2 = (int)((IntPtr)num);
						continue;
					case 245:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ", a_)))
						{
							num = (short)687341678;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 246:
						goto IL_175C;
					case 247:
						if (UtilityMack.IsMobile())
						{
							num = (short)1587150987;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2222;
					case 248:
						num = (short)1755709556;
						num2 = (int)((IntPtr)num);
						continue;
					case 249:
						num = (short)103678126;
						num2 = (int)((IntPtr)num);
						continue;
					case 250:
						goto IL_7B2;
					case 251:
						if (UtilityMack.IsPortable())
						{
							num = (short)885522478;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2192;
					case 252:
						num = (short)280559831;
						num2 = (int)((IntPtr)num);
						continue;
					case 253:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ첓펕잗횙ﶛﲝ얟캡솣슥蚧삩\udcab즭", a_), 200, 650, 220);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)43974734;
						num2 = (int)((IntPtr)num);
						continue;
					case 254:
						goto IL_1D4A;
					case 255:
						goto IL_25AA;
					case 256:
						if (UtilityMack.IsMobile())
						{
							num = (short)1421279443;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_344F;
					case 257:
						num = (short)55902327;
						num2 = (int)((IntPtr)num);
						continue;
					case 258:
						num = (short)805568570;
						num2 = (int)((IntPtr)num);
						continue;
					case 259:
						num = (short)1624244280;
						num2 = (int)((IntPtr)num);
						continue;
					case 260:
						goto IL_3104;
					case 261:
						a_8 = RptMgrErrorHandler.b("쎅붇행잋\ude8d\udd8fꎑ쮓ꂕ궗ꪙ겛솝쎡욣쎥쒧쾩좫肭絛", a_);
						num = (short)1307574408;
						num2 = (int)((IntPtr)num);
						continue;
					case 262:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udd8b쪍횏ꮑ쒓솕꺗\udb99튛", a_)))
						{
							num = (short)1144062048;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A02;
					case 263:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑﾕ킛ﾝ슟잡좣袥슧\udaa9쮫", a_), 200, 650, 220);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)782762201;
						num2 = (int)((IntPtr)num);
						continue;
					case 264:
						if (UtilityMack.IsMobile())
						{
							num = (short)1998323939;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2EA7;
					case 265:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뺋뺍ꂏꊑ쮓\uda95聯鍊얟욡誣", a_), 300, 590, 300);
						num = (short)1101070549;
						num2 = (int)((IntPtr)num);
						continue;
					case 266:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅붇뢉\udf8b쪍풏ꮑ쒓솕궗\udb99튛", a_)))
						{
							num = (short)306249972;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3104;
					case 267:
						a_8 = RptMgrErrorHandler.b("쎅붇행잋\ude8d\udd8fꎑ쮓ꂕ궗ꪙ겛튝즟ﶡ장쪧쾩삫쮭풯鲱ﺳﾷ", a_);
						num = (short)932511842;
						num2 = (int)((IntPtr)num);
						continue;
					case 268:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뾋뺍ꂏꊑ쮓\uda95聯鍊얟욡誣", a_), 240, 590, 200);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)591986738;
						num2 = (int)((IntPtr)num);
						continue;
					case 269:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\ud98b춍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)2052063316;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BDE;
					case 270:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\udf8b쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)1269825612;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BDE;
					case 271:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉\ud98b춍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)1163395330;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_38DE;
					case 272:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ쮓\uda95聯鍊얟욡誣", a_), 300, 590, 300);
						num = (short)283246821;
						num2 = (int)((IntPtr)num);
						continue;
					case 273:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995펛ꦝ躟\udaa1얣쮥쒧", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("즅뾇행잋\ude8d\udd8fꎑ쮓\uda95聯鍊얟욡誣", a_), 250, 600, 300);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)1368916032;
						num2 = (int)((IntPtr)num);
						continue;
					case 274:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ첓펕", a_)))
						{
							num = (short)221184125;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1359740987;
						num2 = (int)((IntPtr)num);
						continue;
					case 275:
						num = (short)1987444903;
						num2 = (int)((IntPtr)num);
						continue;
					case 276:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("입\ud887튉몋뺍ꂏꊑ\ud893ﾕ", a_)))
						{
							num = (short)1934360826;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3779;
					case 277:
						a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
						a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉펋삍ꞏꊑ쮓\uda95聯鍊얟욡誣", a_), 300, 650, 320);
						result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
						num = (short)362741918;
						num2 = (int)((IntPtr)num);
						continue;
					case 278:
						num = (short)1801650384;
						num2 = (int)((IntPtr)num);
						continue;
					case 279:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("캅놇뢉잋쪍\ud88fꮑ쒓솕꾗\udb99튛", a_)))
						{
							num = (short)174260504;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_38DE;
					case 280:
						num = (short)1690304716;
						num2 = (int)((IntPtr)num);
						continue;
					case 281:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("킅", a_)))
						{
							num = (short)1602748694;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_175C;
					case 282:
						num = (short)273875138;
						num2 = (int)((IntPtr)num);
						continue;
					case 283:
						goto IL_A1E;
					case 284:
						num = (short)812843171;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4AB;
					IL_7B2:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					num = (short)1610547474;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8C7:
					num = (short)519307345;
					num2 = (int)((IntPtr)num);
					continue;
					IL_A1E:
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)85721179;
					num2 = (int)((IntPtr)num);
					continue;
					IL_A4D:
					num = (short)1320288458;
					num2 = (int)((IntPtr)num);
					continue;
					IL_BB4:
					num = (short)212533330;
					num2 = (int)((IntPtr)num);
					continue;
					IL_CDB:
					num = (short)76742790;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E0B:
					num = (short)507117692;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E9A:
					num = (short)853016583;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1069:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뢋뺍ꂏꊑ쮓\uda95聯鍊얟욡誣", a_), 300, 590, 300);
					num = (short)2069364752;
					num2 = (int)((IntPtr)num);
					continue;
					IL_10F1:
					num = (short)912982035;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1183:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뢋뺍ꂏꊑ\ud893ﾕ잗ꮙ늛ꮝﾟ얣쒥춧용즫쪭麯", a_), 300, 590, 300);
					num = (short)1702559861;
					num2 = (int)((IntPtr)num);
					continue;
					IL_148E:
					num = (short)1247477771;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1571:
					num = (short)23920712;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1601:
					num = (short)1101070521;
					num2 = (int)((IntPtr)num);
					continue;
					IL_175C:
					num = (short)527761479;
					num2 = (int)((IntPtr)num);
					continue;
					IL_19C2:
					num = (short)1833631784;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1A02:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ욓ﺗ鍊좟ﶡ隣殮쮩캫쮭\udcaf鲱\udeb3욵\udfb7", a_), 300, 590, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1816658136;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1BDE:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑﶓ즕ꮗ얙킛ﾝ슟잡좣袥슧\udaa9쮫", a_), 300, 590, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)116785390;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1D4A:
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)205389878;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1E26:
					num = (short)284491942;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1EB3:
					num = (short)1372389412;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1F7B:
					num = (short)42598433;
					num2 = (int)((IntPtr)num);
					continue;
					IL_20B6:
					num = (short)1905590273;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2192:
					num = (short)1526923357;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2222:
					num = (short)1135476992;
					num2 = (int)((IntPtr)num);
					continue;
					IL_23A5:
					num = (short)562823346;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2488:
					num = (short)731316467;
					num2 = (int)((IntPtr)num);
					continue;
					IL_253D:
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1982398571;
					num2 = (int)((IntPtr)num);
					continue;
					IL_256B:
					num = (short)518782999;
					num2 = (int)((IntPtr)num);
					continue;
					IL_25AA:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉펋삍햏쪑삓즕삗풙쎛튝솟삡솣쪥춧캩芫", a_), 300, 650, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1944780990;
					num2 = (int)((IntPtr)num);
					continue;
					IL_26A1:
					num = (short)1698496674;
					num2 = (int)((IntPtr)num);
					continue;
					IL_26E0:
					num = (short)2083848305;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2720:
					num = (short)1719075039;
					num2 = (int)((IntPtr)num);
					continue;
					IL_28A0:
					num = (short)1262354672;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2A25:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ쮓ꞕ뚗꾙쎛튝솟삡솣쪥춧캩芫", a_), 300, 590, 300);
					num = (short)1574502683;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2B0E:
					num = (short)1903231162;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2B4D:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, a_8, a_12, a_13, a_14);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1925054499;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2BE6:
					num = (short)939393058;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2CA4:
					num = (short)1628635278;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2CE4:
					num = (short)368640264;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2EA7:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, a_7, a_9, a_10, a_11);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1907753112;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2F3D:
					num = (short)388235347;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2FD0:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉펋삍ꖏꊑ쮓\ud895ꮗꪙ쎛튝솟삡솣쪥춧캩芫", a_), 300, 650, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)677052436;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3104:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뺋뺍ꂏꊑ쮓ꞕ뚗꾙쎛튝솟삡솣쪥춧캩芫", a_), 300, 590, 300);
					num = (short)2128937009;
					num2 = (int)((IntPtr)num);
					continue;
					IL_314D:
					num = (short)1446510817;
					num2 = (int)((IntPtr)num);
					continue;
					IL_334E:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑﶓ즕ꪗ얙킛ﾝ슟잡좣袥슧\udaa9쮫", a_), 300, 590, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)950927521;
					num2 = (int)((IntPtr)num);
					continue;
					IL_344F:
					num = (short)1972437017;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3631:
					num = (short)1567621354;
					num2 = (int)((IntPtr)num);
					continue;
					IL_36C0:
					num = (short)896663697;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3779:
					num = (short)1085341947;
					num2 = (int)((IntPtr)num);
					continue;
					IL_38DE:
					a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
					a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ욓ﺗ鍊좟ﶡ鞣殮쮩캫쮭\udcaf鲱\udeb3욵\udfb7", a_), 300, 590, 320);
					result = this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
					num = (short)1797652699;
					num2 = (int)((IntPtr)num);
				}
				IL_1F93:
				a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
				a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉붋뺍ꂏꊑ욓ﺗ鍊좟ﶡ鞣殮쮩캫쮭\udcaf鲱\udeb3욵\udfb7", a_), 300, 590, 320);
				return this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
				IL_2300:
				a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
				a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ\udc93캕\udd97얙킛ﾝ슟잡좣쎥첧蒩욫\udead힯", a_), 200, 650, 220);
				return this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
				IL_27B0:
				a_5 = RptMgrErrorHandler.b("삅ﮋ욍ﲑ\ud995늛솟쾡좣", a_);
				a_6 = RptMgrErrorHandler.b("풅쾏\uda91ﲗ", a_);
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("입\ud887튉뒋뺍ꂏꊑ\udc93즕풗ﮙﺛﮝ첟잡삣袥슧\udaa9쮫", a_), 200, 650, 220);
				return this.a(a_5, a_6, empty, a_2, a_3, a_4, true);
				IL_4AB:
				a_2 = 200;
				a_3 = 600;
				a_4 = 350;
				result = true;
				bool isRightToLeft = new CultureInfo(AppInfoManager.ReportsLangSelection).TextInfo.IsRightToLeft;
				a_5 = string.Empty;
				a_6 = string.Empty;
				empty = string.Empty;
				radInfoGeneralModelNumber_A8539_UIValue = (FeatureManager.GetFeature(2049)[0] as RadioInformation).General.RadInfoGeneralModelNumber_A8539_UIValue;
				num = (short)1274544288;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0029F1E4 File Offset: 0x0029D3E4
		private bool a(string A_0, string A_1, string A_2, int A_3, int A_4, int A_5, bool A_6 = true)
		{
			int a_ = 11;
			short num = (short)1924071424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1315962881;
				if (num != 0)
				{
				}
				this.b = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏횑聯", a_));
				int num3 = 0;
				int num4 = 0;
				bool result = true;
				CultureInfo cultureInfo = new CultureInfo(AppInfoManager.ReportsLangSelection);
				bool isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					XmlTextWriter xmlTextWriter;
					for (;;)
					{
						IL_9A:
						switch (num2)
						{
						case 0:
							if (this.b.Count != 0)
							{
								num = (short)911409154;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_85E6;
						case 1:
							goto IL_8613;
						case 2:
						{
							IEnumerator enumerator = this.b.GetEnumerator();
							num = (short)134152195;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)526516247;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									XmlNode xmlNode;
									IEnumerator enumerator3;
									switch (num2)
									{
									case 0:
										num = (short)1196818453;
										num2 = (int)((IntPtr)num);
										continue;
									case 1:
										goto IL_662;
									case 2:
									{
										IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)218628096;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlNode = (XmlNode)enumerator.Current;
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\udd8dﾕ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﶕ좗ﮙﮛﮝ잡슣즥\udaa7쾩", a_), RptMgrErrorHandler.b("\uda8d", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("슍", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("잍ﶏ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﮑﺕ", a_), RptMgrErrorHandler.b("뮍ꂏ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﮗ", a_), RptMgrErrorHandler.b("좍憐ﺑ", a_));
										num = (short)1224998934;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 3:
									{
										try
										{
											num = (short)269025285;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												string text;
												switch (num2)
												{
												case 0:
												{
													if (isRightToLeft)
													{
														num = (short)1718878222;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IEnumerator enumerator2 = this.e.GetEnumerator();
													num = (short)390201354;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 1:
													goto IL_7EE3;
												case 2:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1661272073;
														num2 = (int)((IntPtr)num);
														continue;
													}
													XmlNode xmlNode2 = (XmlNode)enumerator3.Current;
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.White.ToString());
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꊑ뢓ꚕ뒗ꪙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꮗ\ud999ꮛꪝ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ude8dﾕﶙ", a_), RptMgrErrorHandler.b("뮍", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗\ud99d튟춡톣횥", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꊑ뢓ꚕ뒗ꢙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("벍", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꊑ뢓ꚕ뒗ꢙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꮗ\ud999ꮛꪝ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("벍ꊏ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
													xmlTextWriter.WriteEndElement();
													xmlTextWriter.WriteEndElement();
													xmlTextWriter.WriteEndElement();
													text = null;
													num = (short)330301451;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 3:
													try
													{
														num = (short)301269005;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															XmlNode xmlNode3;
															string text2;
															string text3;
															IEnumerator enumerator4;
															switch (num2)
															{
															case 0:
																if (!xmlNode3.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)247463939;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_71F2;
															case 1:
															{
																IEnumerator enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)1165950988;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode4 = (XmlNode)enumerator2.Current;
																text2 = null;
																num = (short)381616137;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 2:
																goto IL_742B;
															case 3:
																text3 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)95551493;
																num2 = (int)((IntPtr)num);
																continue;
															case 4:
																try
																{
																	num = (short)1808072705;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		switch (num2)
																		{
																		case 0:
																			num = (short)469499907;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 1:
																			switch (0)
																			{
																			case 0:
																				goto IL_6FFC;
																			}
																			continue;
																		case 3:
																			goto IL_7176;
																		case 4:
																		{
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)88145920;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
																			xmlTextWriter.WriteString(xmlNode5.InnerText);
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			num = (short)1578958850;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		}
																		IL_7001:
																		num = (short)54132740;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_6FFC:
																		goto IL_7001;
																	}
																	IL_7176:
																	goto IL_7307;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_7198;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_7185:
																		switch (num2)
																		{
																		case 0:
																			goto IL_71EF;
																		case 1:
																			if (disposable != null)
																			{
																				num = (short)1402273794;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_71F1;
																		case 2:
																			disposable.Dispose();
																			num = (short)1202782208;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_7198;
																	}
																	IL_71EF:
																	IL_71F1:
																	goto EndFinally_183;
																	IL_7198:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)351076353;
																	num2 = (int)((IntPtr)num);
																	goto IL_7185;
																	EndFinally_183:;
																}
																goto IL_71F2;
																IL_7307:
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
																xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)1510277128;
																num2 = (int)((IntPtr)num);
																continue;
															case 5:
																goto IL_742B;
															case 6:
																goto IL_74DB;
															case 7:
															{
																XmlNode xmlNode4;
																text2 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode4.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)2034302987;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 9:
															{
																XmlNode xmlNode4;
																if (!xmlNode4.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)942276615;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text2 = RptMgrErrorHandler.b("겍", a_) + xmlNode4.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)612171782;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 10:
																goto IL_7692;
															case 11:
																goto IL_74DB;
															case 12:
																num = (short)1029046282;
																num2 = (int)((IntPtr)num);
																continue;
															case 13:
																switch (0)
																{
																case 0:
																	goto IL_6FBD;
																}
																continue;
															}
															goto IL_6FBD;
															IL_71F2:
															text3 = RptMgrErrorHandler.b("겍", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
															num = (short)114491394;
															num2 = (int)((IntPtr)num);
															continue;
															IL_742B:
															this.f = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text2,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																text3,
																RptMgrErrorHandler.b("펍뾏쒑歹ﾙ", a_)
															}));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
															enumerator4 = this.f.GetEnumerator();
															num = (short)607846404;
															num2 = (int)((IntPtr)num);
															continue;
															IL_74DB:
															xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text2,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															text3 = null;
															num = (short)1609367552;
															num2 = (int)((IntPtr)num);
															continue;
															IL_7591:
															num = (short)1189937153;
															num2 = (int)((IntPtr)num);
															continue;
															IL_6FBD:
															goto IL_7591;
														}
														IL_7692:
														goto IL_7EB8;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_76B4;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_76A1:
															switch (num2)
															{
															case 0:
																disposable.Dispose();
																num = (short)1386348546;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
																if (disposable != null)
																{
																	num = (short)1660747776;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_770C;
															case 2:
																goto IL_770A;
															}
															goto IL_76B4;
														}
														IL_770A:
														IL_770C:
														goto EndFinally_184;
														IL_76B4:
														IEnumerator enumerator2;
														disposable = (enumerator2 as IDisposable);
														num = (short)239468545;
														num2 = (int)((IntPtr)num);
														goto IL_76A1;
														EndFinally_184:;
													}
													goto Block_136;
												case 4:
												{
													XmlNode xmlNode2;
													text = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode2.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
													num = (short)532480012;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 5:
													switch (0)
													{
													case 0:
														goto IL_6EE0;
													}
													continue;
												case 6:
													goto IL_8305;
												case 7:
													if (this.e.Count > 0)
													{
														num = (short)1568997384;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_7EB8;
												case 8:
													num = (short)202768384;
													num2 = (int)((IntPtr)num);
													continue;
												case 9:
													num = (short)944504838;
													num2 = (int)((IntPtr)num);
													continue;
												case 10:
													goto IL_770D;
												case 11:
												{
													XmlNode xmlNode2;
													if (!xmlNode2.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
													{
														num = (short)1650393092;
														num2 = (int)((IntPtr)num);
														continue;
													}
													text = RptMgrErrorHandler.b("겍", a_) + xmlNode2.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
													num = (short)59506689;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 12:
													goto IL_7EE3;
												case 14:
												{
													IEnumerator enumerator2 = this.e.GetEnumerator();
													num = (short)695533571;
													num2 = (int)((IntPtr)num);
													continue;
												}
												}
												IL_6F1C:
												num = (short)1885536258;
												num2 = (int)((IntPtr)num);
												continue;
												IL_6EE0:
												goto IL_6F1C;
												IL_7EB8:
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												num = (short)1426128909;
												num2 = (int)((IntPtr)num);
												continue;
												Block_136:
												try
												{
													IL_770D:
													num = (short)1426718725;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														XmlNode xmlNode3;
														IEnumerator enumerator4;
														string text4;
														string text5;
														switch (num2)
														{
														case 0:
															goto IL_7771;
														case 1:
															goto IL_7827;
														case 2:
														{
															XmlNode xmlNode6;
															if (!xmlNode6.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
															{
																num = (short)920190986;
																num2 = (int)((IntPtr)num);
																continue;
															}
															text4 = RptMgrErrorHandler.b("겍", a_) + xmlNode6.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
															num = (short)69730312;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 3:
															try
															{
																num = (short)1837957123;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																	{
																		if (!enumerator4.MoveNext())
																		{
																			num = (short)1367605252;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		XmlNode xmlNode7 = (XmlNode)enumerator4.Current;
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
																		xmlTextWriter.WriteString(xmlNode7.InnerText);
																		xmlTextWriter.WriteEndElement();
																		xmlTextWriter.WriteEndElement();
																		num = (short)1932853249;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 2:
																		goto IL_7DA4;
																	case 3:
																		switch (0)
																		{
																		case 0:
																			goto IL_7C2B;
																		}
																		continue;
																	case 4:
																		num = (short)1507655682;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IL_7C30:
																	num = (short)825950208;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_7C2B:
																	goto IL_7C30;
																}
																IL_7DA4:
																goto IL_7ACB;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_7DC6;
																}
																IDisposable disposable;
																for (;;)
																{
																	IL_7DB3:
																	switch (num2)
																	{
																	case 0:
																		if (disposable != null)
																		{
																			num = (short)864288769;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_7E23;
																	case 1:
																		disposable.Dispose();
																		num = (short)1872166914;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 2:
																		goto IL_7E21;
																	}
																	goto IL_7DC6;
																}
																IL_7E21:
																IL_7E23:
																goto EndFinally_181;
																IL_7DC6:
																disposable = (enumerator4 as IDisposable);
																num = (short)1436155904;
																num2 = (int)((IntPtr)num);
																goto IL_7DB3;
																EndFinally_181:;
															}
															goto IL_7E24;
															IL_7ACB:
															xmlTextWriter.WriteEndElement();
															num = (short)1200488459;
															num2 = (int)((IntPtr)num);
															continue;
														case 4:
															if (!xmlNode3.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
															{
																num = (short)1345912844;
																num2 = (int)((IntPtr)num);
																continue;
															}
															text5 = RptMgrErrorHandler.b("겍", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
															num = (short)1295450118;
															num2 = (int)((IntPtr)num);
															continue;
														case 5:
															switch (0)
															{
															case 0:
																goto IL_776C;
															}
															continue;
														case 6:
															goto IL_7827;
														case 7:
															goto IL_7E3C;
														case 8:
															goto IL_7771;
														case 9:
															goto IL_7E24;
														case 10:
														{
															XmlNode xmlNode6;
															text4 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode6.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
															num = (short)1955725312;
															num2 = (int)((IntPtr)num);
															continue;
														}
														case 12:
															text5 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
															num = (short)264044545;
															num2 = (int)((IntPtr)num);
															continue;
														case 13:
														{
															IEnumerator enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1376714761;
																num2 = (int)((IntPtr)num);
																continue;
															}
															XmlNode xmlNode6 = (XmlNode)enumerator2.Current;
															text4 = null;
															num = (short)1280704514;
															num2 = (int)((IntPtr)num);
															continue;
														}
														}
														goto IL_776C;
														IL_7771:
														xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
														{
															RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
															text,
															RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
															text4,
															RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
														}));
														text5 = null;
														num = (short)2031222788;
														num2 = (int)((IntPtr)num);
														continue;
														IL_7827:
														this.f = this.a.SelectNodes(string.Concat(new string[]
														{
															RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
															text,
															RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
															text4,
															RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
															text5,
															RptMgrErrorHandler.b("펍뾏쒑歹ﾙ", a_)
														}));
														xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
														xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
														xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
														xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
														xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
														xmlTextWriter.WriteEndElement();
														xmlTextWriter.WriteEndElement();
														enumerator4 = this.f.GetEnumerator();
														num = (short)2078015491;
														num2 = (int)((IntPtr)num);
														continue;
														IL_7B5D:
														num = (short)1916076045;
														num2 = (int)((IntPtr)num);
														continue;
														IL_776C:
														goto IL_7B5D;
														IL_7E24:
														num = (short)1910046727;
														num2 = (int)((IntPtr)num);
													}
													IL_7E3C:;
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_7E5B;
													}
													IDisposable disposable;
													for (;;)
													{
														IL_7E48:
														switch (num2)
														{
														case 0:
															if (disposable != null)
															{
																num = (short)1555365889;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_7EB7;
														case 1:
															disposable.Dispose();
															num = (short)320733186;
															num2 = (int)((IntPtr)num);
															continue;
														case 2:
															goto IL_7EB5;
														}
														goto IL_7E5B;
													}
													IL_7EB5:
													IL_7EB7:
													goto EndFinally_182;
													IL_7E5B:
													IEnumerator enumerator2;
													disposable = (enumerator2 as IDisposable);
													num = (short)1228275712;
													num2 = (int)((IntPtr)num);
													goto IL_7E48;
													EndFinally_182:;
												}
												goto IL_7EB8;
												IL_7EE3:
												this.e = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_) + text + RptMgrErrorHandler.b("펍뾏삑쮗ﾙ", a_));
												num = (short)371130375;
												num2 = (int)((IntPtr)num);
											}
											IL_8305:
											goto IL_343;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_8327;
											}
											IDisposable disposable;
											for (;;)
											{
												IL_8314:
												switch (num2)
												{
												case 0:
													if (disposable != null)
													{
														num = (short)1824129025;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_8381;
												case 1:
													disposable.Dispose();
													num = (short)297533442;
													num2 = (int)((IntPtr)num);
													continue;
												case 2:
													goto IL_837F;
												}
												goto IL_8327;
											}
											IL_837F:
											IL_8381:
											goto EndFinally_185;
											IL_8327:
											disposable = (enumerator3 as IDisposable);
											num = (short)745472000;
											num2 = (int)((IntPtr)num);
											goto IL_8314;
											EndFinally_185:;
										}
										goto IL_8382;
										IL_343:
										string xpath = RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱鎳", a_) + AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("첍秊쎛ﾝ캟욡ﮣ잧쒩\ud8ab\udcad\udfaf\udeb1잳", a_), cultureInfo) + RptMgrErrorHandler.b("ꦍ춏", a_);
										this.c = this.a.SelectNodes(xpath);
										enumerator3 = this.c.GetEnumerator();
										num = (short)370737168;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 4:
										if (isRightToLeft)
										{
											num = (short)1559625739;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﾏﶓﾝ첟좣쾥쾧쒩솫쮭\udeaf욱", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
										num = (short)1187184665;
										num2 = (int)((IntPtr)num);
										continue;
									case 5:
										if (A_6)
										{
											num = (short)2090074130;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_6DE8;
									case 6:
										goto IL_83C0;
									case 7:
										goto IL_662;
									case 8:
										try
										{
											num = (short)175702047;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												IEnumerator enumerator2;
												string text8;
												XmlNode xmlNode11;
												bool flag;
												switch (num2)
												{
												case 0:
													try
													{
														num = (short)781647886;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															XmlNode xmlNode3;
															IEnumerator enumerator4;
															string text6;
															string text7;
															switch (num2)
															{
															case 1:
																goto IL_13B8;
															case 2:
																text6 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)273416197;
																num2 = (int)((IntPtr)num);
																continue;
															case 3:
																num = (short)1331560456;
																num2 = (int)((IntPtr)num);
																continue;
															case 4:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)636747793;
																num2 = (int)((IntPtr)num);
																continue;
															case 5:
																goto IL_11B6;
															case 6:
																if (!xmlNode3.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)1714552834;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text6 = RptMgrErrorHandler.b("겍", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)817430537;
																num2 = (int)((IntPtr)num);
																continue;
															case 7:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)2143158275;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode8 = (XmlNode)enumerator2.Current;
																text7 = null;
																num = (short)1697120268;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 8:
																goto IL_159A;
															case 9:
																goto IL_11B6;
															case 10:
																goto IL_1312;
															case 11:
																try
																{
																	num = (short)41353217;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		XmlNode xmlNode9;
																		switch (num2)
																		{
																		case 0:
																			if (num4 % 2 == 0)
																			{
																				num = (short)744161283;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																			num = (short)307036164;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 1:
																			switch (0)
																			{
																			case 0:
																				goto IL_ED3;
																			}
																			continue;
																		case 2:
																			goto IL_113B;
																		case 3:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																			num = (short)1736114181;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 4:
																			goto IL_FBF;
																		case 5:
																			goto IL_FBF;
																		case 6:
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)432734215;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlNode9 = (XmlNode)enumerator4.Current;
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			num = (short)415956992;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 7:
																			num = (short)1940520962;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_ED3;
																		IL_FBF:
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																		xmlTextWriter.WriteString(xmlNode9.InnerText);
																		xmlTextWriter.WriteEndElement();
																		xmlTextWriter.WriteEndElement();
																		num = (short)916979720;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_10E2:
																		num = (short)1656946694;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_ED3:
																		goto IL_10E2;
																	}
																	IL_113B:
																	goto IL_12E8;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_115D;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_114A:
																		switch (num2)
																		{
																		case 0:
																			if (disposable != null)
																			{
																				num = (short)612433922;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_11B5;
																		case 1:
																			goto IL_11B3;
																		case 2:
																			disposable.Dispose();
																			num = (short)2020802561;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_115D;
																	}
																	IL_11B3:
																	IL_11B5:
																	goto EndFinally_178;
																	IL_115D:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)141033472;
																	num2 = (int)((IntPtr)num);
																	goto IL_114A;
																	EndFinally_178:;
																}
																goto IL_11B6;
																IL_12E8:
																xmlTextWriter.WriteEndElement();
																num4--;
																num = (short)1814233088;
																num2 = (int)((IntPtr)num);
																continue;
															case 12:
															{
																XmlNode xmlNode8;
																if (!xmlNode8.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)34275344;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text7 = RptMgrErrorHandler.b("겍", a_) + xmlNode8.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)167706634;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 13:
																goto IL_1312;
															case 14:
																switch (0)
																{
																case 0:
																	goto IL_CD5;
																}
																continue;
															case 15:
																if (num4 % 2 == 0)
																{
																	num = (short)1545338884;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)944111617;
																num2 = (int)((IntPtr)num);
																continue;
															case 16:
															{
																XmlNode xmlNode8;
																text7 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode8.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)1821966349;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 17:
																goto IL_13B8;
															}
															goto IL_CD5;
															IL_11B6:
															this.f = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text8,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text7,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																text6,
																RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
															}));
															enumerator4 = this.f.GetEnumerator();
															num = (short)69140491;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1312:
															xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text8,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text7,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
															num = (short)220069903;
															num2 = (int)((IntPtr)num);
															continue;
															IL_13B8:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text6 = null;
															num = (short)137035782;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1542:
															num = (short)29884423;
															num2 = (int)((IntPtr)num);
															continue;
															IL_CD5:
															goto IL_1542;
														}
														IL_159A:
														goto IL_2B9F;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_15BC;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_15A9:
															switch (num2)
															{
															case 0:
																if (disposable != null)
																{
																	num = (short)1005322242;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_1614;
															case 1:
																goto IL_1612;
															case 2:
																disposable.Dispose();
																num = (short)974127105;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_15BC;
														}
														IL_1612:
														IL_1614:
														goto EndFinally_179;
														IL_15BC:
														disposable = (enumerator2 as IDisposable);
														num = (short)1155923968;
														num2 = (int)((IntPtr)num);
														goto IL_15A9;
														EndFinally_179:;
													}
													goto IL_1615;
												case 1:
													try
													{
														num = (short)2046033923;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)438042625;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode10 = (XmlNode)enumerator2.Current;
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꎏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteString(xmlNode10.InnerText);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)1883111426;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 1:
																num = (short)1269039108;
																num2 = (int)((IntPtr)num);
																continue;
															case 3:
																switch (0)
																{
																case 0:
																	goto IL_23CB;
																}
																continue;
															case 4:
																goto IL_254C;
															}
															IL_24F4:
															num = (short)1858273280;
															num2 = (int)((IntPtr)num);
															continue;
															IL_23CB:
															goto IL_24F4;
														}
														IL_254C:
														goto IL_2B31;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_256E;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_255B:
															switch (num2)
															{
															case 0:
																disposable.Dispose();
																num = (short)1010106370;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
																if (disposable != null)
																{
																	num = (short)73007104;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_25C8;
															case 2:
																goto IL_25C6;
															}
															goto IL_256E;
														}
														IL_25C6:
														IL_25C8:
														goto EndFinally_177;
														IL_256E:
														disposable = (enumerator2 as IDisposable);
														num = (short)740294657;
														num2 = (int)((IntPtr)num);
														goto IL_255B;
														EndFinally_177:;
													}
													goto IL_25C9;
													IL_2B31:
													xmlTextWriter.WriteEndElement();
													num = (short)619577362;
													num2 = (int)((IntPtr)num);
													continue;
												case 2:
													if (!enumerator3.MoveNext())
													{
														num = (short)1178009640;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlNode11 = (XmlNode)enumerator3.Current;
													text8 = null;
													num = (short)532086800;
													num2 = (int)((IntPtr)num);
													continue;
												case 3:
													goto IL_2BCF;
												case 4:
													if (isRightToLeft)
													{
														num = (short)1502347288;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteString(xmlNode11.Attributes[num3].Value);
													num = (short)1715470363;
													num2 = (int)((IntPtr)num);
													continue;
												case 5:
													goto IL_21E5;
												case 6:
													if (isRightToLeft)
													{
														num = (short)1681915945;
														num2 = (int)((IntPtr)num);
														continue;
													}
													enumerator2 = this.d.GetEnumerator();
													num = (short)1718747148;
													num2 = (int)((IntPtr)num);
													continue;
												case 7:
													goto IL_2D8A;
												case 8:
													goto IL_AC1;
												case 9:
													try
													{
														num = (short)238092292;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															XmlNode xmlNode3;
															IEnumerator enumerator4;
															string text9;
															string text10;
															switch (num2)
															{
															case 0:
																goto IL_1C7A;
															case 1:
																goto IL_1D22;
															case 2:
																goto IL_1D22;
															case 3:
																num = (short)1308885001;
																num2 = (int)((IntPtr)num);
																continue;
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_189F;
																}
																continue;
															case 5:
																goto IL_1DCB;
															case 6:
																try
																{
																	num = (short)1242038276;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		XmlNode xmlNode12;
																		switch (num2)
																		{
																		case 0:
																			goto IL_1B5C;
																		case 1:
																			if (num4 % 2 == 0)
																			{
																				num = (short)542900229;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																			num = (short)1480523779;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 2:
																			goto IL_1936;
																		case 3:
																			goto IL_1936;
																		case 4:
																			switch (0)
																			{
																			case 0:
																				goto IL_18EF;
																			}
																			continue;
																		case 5:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																			num = (short)1872035842;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 7:
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)1080688648;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlNode12 = (XmlNode)enumerator4.Current;
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			num = (short)1397030913;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 8:
																			num = (short)1403060224;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_18EF;
																		IL_1936:
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																		xmlTextWriter.WriteString(xmlNode12.InnerText);
																		xmlTextWriter.WriteEndElement();
																		xmlTextWriter.WriteEndElement();
																		num = (short)1121779718;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1A5A:
																		num = (short)293732359;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_18EF:
																		goto IL_1A5A;
																	}
																	IL_1B5C:
																	goto IL_1F0A;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_1B7E;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_1B6B:
																		switch (num2)
																		{
																		case 0:
																			goto IL_1BD4;
																		case 1:
																			if (disposable != null)
																			{
																				num = (short)1501233154;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_1BD6;
																		case 2:
																			disposable.Dispose();
																			num = (short)20447232;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_1B7E;
																	}
																	IL_1BD4:
																	IL_1BD6:
																	goto EndFinally_175;
																	IL_1B7E:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)1980694529;
																	num2 = (int)((IntPtr)num);
																	goto IL_1B6B;
																	EndFinally_175:;
																}
																goto IL_1BD7;
																IL_1F0A:
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꂑ뢓ꚕ뒗ꪙ", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num4--;
																num = (short)1761673233;
																num2 = (int)((IntPtr)num);
																continue;
															case 7:
																if (!xmlNode3.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)741867534;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text9 = RptMgrErrorHandler.b("겍", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)424869898;
																num2 = (int)((IntPtr)num);
																continue;
															case 8:
															{
																XmlNode xmlNode13;
																if (!xmlNode13.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)1561657360;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text10 = RptMgrErrorHandler.b("겍", a_) + xmlNode13.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)885719040;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 9:
																goto IL_2168;
															case 10:
																goto IL_1DCB;
															case 11:
																goto IL_1C7A;
															case 12:
																if (num4 % 2 == 0)
																{
																	num = (short)633536525;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)871104513;
																num2 = (int)((IntPtr)num);
																continue;
															case 13:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)134152194;
																num2 = (int)((IntPtr)num);
																continue;
															case 14:
																goto IL_1BD7;
															case 15:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)1358168067;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode13 = (XmlNode)enumerator2.Current;
																text10 = null;
																num = (short)1591607304;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 16:
															{
																XmlNode xmlNode13;
																text10 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode13.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)784138251;
																num2 = (int)((IntPtr)num);
																continue;
															}
															}
															goto IL_189F;
															IL_1BD7:
															text9 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode3.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
															num = (short)1242497029;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1C7A:
															xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text8,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text10,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
															num = (short)1432682508;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1D22:
															text9 = null;
															num = (short)2060058631;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1DCB:
															this.f = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text8,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text10,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																text9,
																RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
															}));
															enumerator4 = this.f.GetEnumerator();
															num = (short)1686568966;
															num2 = (int)((IntPtr)num);
															continue;
															IL_209F:
															num = (short)882704399;
															num2 = (int)((IntPtr)num);
															continue;
															IL_189F:
															goto IL_209F;
														}
														IL_2168:
														goto IL_2B9F;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_218A;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_2177:
															switch (num2)
															{
															case 0:
																goto IL_21E2;
															case 1:
																if (disposable != null)
																{
																	num = (short)656474114;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_21E4;
															case 2:
																disposable.Dispose();
																num = (short)1421934592;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_218A;
														}
														IL_21E2:
														IL_21E4:
														goto EndFinally_176;
														IL_218A:
														disposable = (enumerator2 as IDisposable);
														num = (short)1651572737;
														num2 = (int)((IntPtr)num);
														goto IL_2177;
														EndFinally_176:;
													}
													goto IL_21E5;
												case 10:
													if (this.e.Count > 0)
													{
														num = (short)616890406;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_2B9F;
												case 11:
													if (this.d.Count > 4)
													{
														num = (short)62521381;
														num2 = (int)((IntPtr)num);
														continue;
													}
													num = (short)583860239;
													num2 = (int)((IntPtr)num);
													continue;
												case 12:
													try
													{
														num = (short)2146107395;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																num = (short)1825308676;
																num2 = (int)((IntPtr)num);
																continue;
															case 2:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)1697120256;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode14 = (XmlNode)enumerator2.Current;
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꎏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteString(xmlNode14.InnerText);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)632356865;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 3:
																switch (0)
																{
																case 0:
																	goto IL_28AA;
																}
																continue;
															case 4:
																goto IL_2A2C;
															}
															IL_28AF:
															num = (short)1946025986;
															num2 = (int)((IntPtr)num);
															continue;
															IL_28AA:
															goto IL_28AF;
														}
														IL_2A2C:
														goto IL_180B;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_2A4E;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_2A3B:
															switch (num2)
															{
															case 0:
																disposable.Dispose();
																num = (short)2042298370;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
																if (disposable != null)
																{
																	num = (short)1527054336;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_2AA7;
															case 2:
																goto IL_2AA5;
															}
															goto IL_2A4E;
														}
														IL_2AA5:
														IL_2AA7:
														break;
														IL_2A4E:
														disposable = (enumerator2 as IDisposable);
														num = (short)1653866497;
														num2 = (int)((IntPtr)num);
														goto IL_2A3B;
													}
													break;
													IL_180B:
													xmlTextWriter.WriteEndElement();
													num = (short)1938358280;
													num2 = (int)((IntPtr)num);
													continue;
												case 13:
													goto IL_178C;
												case 14:
													goto IL_26A9;
												case 15:
													if (this.d.Count == 4)
													{
														num = (short)319684625;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_26A9;
												case 16:
													if (!xmlNode11.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
													{
														num = (short)611385373;
														num2 = (int)((IntPtr)num);
														continue;
													}
													text8 = RptMgrErrorHandler.b("겍", a_) + xmlNode11.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
													num = (short)1675362336;
													num2 = (int)((IntPtr)num);
													continue;
												case 17:
												{
													string innerText = this.d[0].InnerText;
													string innerText2 = this.d[1].InnerText;
													string innerText3 = this.d[2].InnerText;
													string innerText4 = this.d[3].InnerText;
													num = (short)1701183521;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 18:
													goto IL_AC1;
												case 19:
													goto IL_26A9;
												case 20:
													goto IL_25C9;
												case 21:
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뾍ꂏ", a_));
													num = (short)1250492421;
													num2 = (int)((IntPtr)num);
													continue;
												case 22:
													if (flag)
													{
														num = (short)813563924;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_A7D;
												case 24:
													goto IL_1615;
												case 25:
													if (this.d.Count < 5)
													{
														num = (short)579010581;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("벍ꖏ", a_));
													num = (short)1003880487;
													num2 = (int)((IntPtr)num);
													continue;
												case 26:
													if (this.d.Count > 0)
													{
														num = (short)1776484387;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_2B9F;
												case 27:
													goto IL_178C;
												case 28:
													if (this.l)
													{
														num = (short)528744484;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_26A9;
												case 29:
													text8 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode11.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
													num = (short)291438595;
													num2 = (int)((IntPtr)num);
													continue;
												case 30:
												{
													string innerText2;
													this.d[0].InnerText = innerText2;
													string innerText3;
													this.d[1].InnerText = innerText3;
													string innerText4;
													this.d[2].InnerText = innerText4;
													string innerText;
													this.d[3].InnerText = innerText;
													num = (short)2056192014;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 31:
													switch (0)
													{
													case 0:
														goto IL_A30;
													}
													continue;
												case 32:
													goto IL_2BCF;
												case 33:
													if (this.l)
													{
														num = (short)1548681246;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_26A9;
												case 34:
													if (isRightToLeft)
													{
														num = (short)1743978538;
														num2 = (int)((IntPtr)num);
														continue;
													}
													enumerator2 = this.e.GetEnumerator();
													num = (short)1897529344;
													num2 = (int)((IntPtr)num);
													continue;
												case 35:
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
													num = (short)1058144262;
													num2 = (int)((IntPtr)num);
													continue;
												case 36:
												{
													string innerText5;
													this.d[0].InnerText = innerText5;
													string innerText6;
													this.d[1].InnerText = innerText6;
													string innerText7;
													this.d[2].InnerText = innerText7;
													string innerText8;
													this.d[3].InnerText = innerText8;
													string innerText9;
													this.d[4].InnerText = innerText9;
													string innerText10;
													this.d[5].InnerText = innerText10;
													string innerText11;
													this.d[6].InnerText = innerText11;
													num = (short)1157627923;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 37:
												{
													string innerText11 = this.d[0].InnerText;
													string innerText5 = this.d[1].InnerText;
													string innerText6 = this.d[2].InnerText;
													string innerText7 = this.d[3].InnerText;
													string innerText8 = this.d[4].InnerText;
													string innerText9 = this.d[5].InnerText;
													string innerText10 = this.d[6].InnerText;
													num = (short)1329004572;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 38:
													num4 = this.e.Count;
													num = (short)730071074;
													num2 = (int)((IntPtr)num);
													continue;
												case 39:
													goto IL_21E5;
												case 40:
													num = (short)374669319;
													num2 = (int)((IntPtr)num);
													continue;
												case 41:
													num = (short)1188102155;
													num2 = (int)((IntPtr)num);
													continue;
												case 42:
													enumerator2 = this.e.GetEnumerator();
													num = (short)224133129;
													num2 = (int)((IntPtr)num);
													continue;
												case 43:
												{
													num = (short)279108013;
													short num5 = num;
													num = (short)1675549101;
													switch ((num5 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_A7D;
													default:
														num = (short)1370161152;
														if (num != 0)
														{
														}
														goto IL_A7D;
													}
													break;
												}
												}
												goto IL_A30;
												IL_A7D:
												num = (short)129433626;
												num2 = (int)((IntPtr)num);
												continue;
												IL_AC1:
												this.e = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_) + text8 + RptMgrErrorHandler.b("펍뾏삑쮗ﾙ", a_));
												num = (short)274989066;
												num2 = (int)((IntPtr)num);
												continue;
												IL_1615:
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
												xmlTextWriter.WriteString(xmlNode11.Attributes[num3].Value);
												num = (short)439156749;
												num2 = (int)((IntPtr)num);
												continue;
												IL_178C:
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												num = (short)313983019;
												num2 = (int)((IntPtr)num);
												continue;
												IL_21E5:
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꚏ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
												num = (short)1877409796;
												num2 = (int)((IntPtr)num);
												continue;
												IL_25C9:
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.Coral.ToString());
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꊑ뢓ꚕ뒗ꮙ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꢗꪙ겛꺝", a_));
												num = (short)1657274393;
												num2 = (int)((IntPtr)num);
												continue;
												IL_26A9:
												enumerator2 = this.d.GetEnumerator();
												num = (short)65273857;
												num2 = (int)((IntPtr)num);
												continue;
												IL_2AA8:
												num = (short)1580466178;
												num2 = (int)((IntPtr)num);
												continue;
												IL_A30:
												goto IL_2AA8;
												IL_2B9F:
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												flag = false;
												num = (short)1945698327;
												num2 = (int)((IntPtr)num);
												continue;
												IL_2BCF:
												this.d = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_) + text8 + RptMgrErrorHandler.b("펍뾏욑ﾙ풛ﮝ솟욡솣풥螧쎫슭\udbb1삳\udab5\uddb7", a_));
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎍ﾕ", a_), RptMgrErrorHandler.b("뺍", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightSlateGray.ToString());
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뾍벏ꎑ뢓ꞕ뒗ꮙ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꮗ\ud999ꮛꪝ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ude8dﾕﶙ", a_), RptMgrErrorHandler.b("뮍", a_));
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗\ud99d튟춡톣횥", a_));
												num = (short)1416495126;
												num2 = (int)((IntPtr)num);
											}
											IL_2D8A:
											goto IL_7F7;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_2DAC;
											}
											IDisposable disposable;
											for (;;)
											{
												IL_2D99:
												switch (num2)
												{
												case 0:
													disposable.Dispose();
													num = (short)490733570;
													num2 = (int)((IntPtr)num);
													continue;
												case 1:
													if (disposable != null)
													{
														num = (short)184483840;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_2E05;
												case 2:
													goto IL_2E03;
												}
												goto IL_2DAC;
											}
											IL_2E03:
											IL_2E05:
											goto EndFinally_180;
											IL_2DAC:
											disposable = (enumerator3 as IDisposable);
											num = (short)1208090625;
											num2 = (int)((IntPtr)num);
											goto IL_2D99;
											EndFinally_180:;
										}
										goto IL_2E06;
										IL_7F7:
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("좍憐ﶗ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud88dﾕﮗﮙ\udf9d캟송첣즥\udaa7", a_), RptMgrErrorHandler.b("\ude8d풕춟", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﾏﶓﾝ첟쪣얥삧얩\udeab", a_), RptMgrErrorHandler.b("춍ﾏﲑ캛잟쪡킣", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎍ﾕ", a_), RptMgrErrorHandler.b("뺍", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첍ﲏ﶑ﶕ춗펙\udf9b캟횡얣쾥욧쾩\udeab", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d풕ﾛ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﮑﺕ", a_), RptMgrErrorHandler.b("뾍ꖏ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
										num = (short)1782906884;
										num2 = (int)((IntPtr)num);
										continue;
									case 9:
										goto IL_8382;
									case 10:
										if (A_6)
										{
											num = (short)2116747279;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍﶗ쎛첟쮡풣횥춧캩\ud8ad햯삱삳펵삷钹횻캽ꞿ", a_));
										num = (short)1095958529;
										num2 = (int)((IntPtr)num);
										continue;
									case 11:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﾏﶓﾝ첟좣쾥쾧쒩솫쮭\udeaf욱", a_), RptMgrErrorHandler.b("슍", a_));
										num = (short)1056636934;
										num2 = (int)((IntPtr)num);
										continue;
									case 12:
										goto IL_2E06;
									case 13:
										if (isRightToLeft)
										{
											num = (short)1535705107;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﾏﶓﾝ첟좣쾥쾧쒩솫쮭\udeaf욱", a_), RptMgrErrorHandler.b("슍", a_));
										num = (short)1906442252;
										num2 = (int)((IntPtr)num);
										continue;
									case 14:
										goto IL_2E06;
									case 15:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍﶗ쎛첟쮡풣횥춧캩芫쒭삯햱", a_));
										num = (short)1163067409;
										num2 = (int)((IntPtr)num);
										continue;
									case 16:
									{
										try
										{
											num = (short)1251147790;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												IEnumerator enumerator2;
												XmlNode xmlNode15;
												string text12;
												switch (num2)
												{
												case 0:
													goto IL_6C99;
												case 1:
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
													xmlTextWriter.WriteString(xmlNode15.Attributes[num3].Value);
													num = (short)488308745;
													num2 = (int)((IntPtr)num);
													continue;
												case 2:
													num4 = this.e.Count;
													enumerator2 = this.e.GetEnumerator();
													num = (short)1714094088;
													num2 = (int)((IntPtr)num);
													continue;
												case 3:
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("벍ꖏ", a_));
													num = (short)2131558405;
													num2 = (int)((IntPtr)num);
													continue;
												case 4:
													goto IL_3A3D;
												case 5:
													goto IL_35F3;
												case 6:
												{
													string innerText12 = this.d[0].InnerText;
													string innerText13 = this.d[1].InnerText;
													string innerText14 = this.d[2].InnerText;
													string innerText15 = this.d[3].InnerText;
													num = (short)602406940;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 7:
												{
													string innerText15;
													this.d[0].InnerText = innerText15;
													string innerText14;
													this.d[1].InnerText = innerText14;
													string innerText13;
													this.d[2].InnerText = innerText13;
													string innerText12;
													this.d[3].InnerText = innerText12;
													num = (short)63635460;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 8:
													try
													{
														num = (short)1673265204;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															IEnumerator enumerator4;
															XmlNode xmlNode16;
															string text13;
															string text14;
															string text15;
															string text17;
															switch (num2)
															{
															case 0:
																goto IL_42CE;
															case 1:
																if (xmlNode16.Attributes[num3].Value.Contains(AppResources.NOPRINT_Id))
																{
																	num = (short)1971912724;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
																num = (short)1694629892;
																num2 = (int)((IntPtr)num);
																continue;
															case 2:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)1967980547;
																num2 = (int)((IntPtr)num);
																continue;
															case 3:
																goto IL_4055;
															case 4:
																if (num4 % 2 == 0)
																{
																	num = (short)2035482673;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)1115947008;
																num2 = (int)((IntPtr)num);
																continue;
															case 5:
																goto IL_600E;
															case 6:
																goto IL_69D7;
															case 7:
																try
																{
																	num = (short)1945567236;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		string text11;
																		IEnumerator enumerator5;
																		switch (num2)
																		{
																		case 0:
																			goto IL_5ED4;
																		case 1:
																			goto IL_59C9;
																		case 2:
																		{
																			XmlNode xmlNode17;
																			text11 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode17.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																			num = (short)1005191175;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 3:
																			try
																			{
																				num = (short)38928385;
																				num2 = (int)((IntPtr)num);
																				for (;;)
																				{
																					switch (num2)
																					{
																					case 0:
																						goto IL_5E57;
																					case 1:
																						switch (0)
																						{
																						case 0:
																							goto IL_5CFF;
																						}
																						continue;
																					case 2:
																					{
																						if (!enumerator5.MoveNext())
																						{
																							num = (short)693436419;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						XmlNode xmlNode18 = (XmlNode)enumerator5.Current;
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("붍", a_));
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																						xmlTextWriter.WriteString(xmlNode18.InnerText);
																						xmlTextWriter.WriteEndElement();
																						xmlTextWriter.WriteEndElement();
																						num = (short)122880004;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					case 3:
																						num = (short)1314390016;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					IL_5DFF:
																					num = (short)948043778;
																					num2 = (int)((IntPtr)num);
																					continue;
																					IL_5CFF:
																					goto IL_5DFF;
																				}
																				IL_5E57:
																				break;
																			}
																			finally
																			{
																				switch (0)
																				{
																				case 0:
																					goto IL_5E79;
																				}
																				IDisposable disposable;
																				for (;;)
																				{
																					IL_5E66:
																					switch (num2)
																					{
																					case 0:
																						if (disposable != null)
																						{
																							num = (short)1274937346;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						goto IL_5ED3;
																					case 1:
																						goto IL_5ED1;
																					case 2:
																						disposable.Dispose();
																						num = (short)1790574593;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					goto IL_5E79;
																				}
																				IL_5ED1:
																				IL_5ED3:
																				goto EndFinally_170;
																				IL_5E79:
																				disposable = (enumerator5 as IDisposable);
																				num = (short)1558118400;
																				num2 = (int)((IntPtr)num);
																				goto IL_5E66;
																				EndFinally_170:;
																			}
																			goto IL_5ED4;
																		case 4:
																			switch (0)
																			{
																			case 0:
																				goto IL_59C4;
																			}
																			continue;
																		case 5:
																			goto IL_5EED;
																		case 6:
																		{
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)181731328;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			XmlNode xmlNode17 = (XmlNode)enumerator4.Current;
																			XmlNode xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
																			{
																				RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																				text12,
																				RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																				text13,
																				RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
																			}));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																			xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			text11 = null;
																			num = (short)2093547528;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 7:
																			goto IL_59C9;
																		case 8:
																		{
																			XmlNode xmlNode17;
																			if (!xmlNode17.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																			{
																				num = (short)1105002498;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			text11 = RptMgrErrorHandler.b("겍", a_) + xmlNode17.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																			num = (short)1992818689;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		}
																		goto IL_59C4;
																		IL_59C9:
																		this.f = this.a.SelectNodes(string.Concat(new string[]
																		{
																			RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																			text12,
																			RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																			text13,
																			RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																			text11,
																			RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
																		}));
																		enumerator5 = this.f.GetEnumerator();
																		num = (short)2030239747;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_5BDD:
																		num = (short)340590598;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_59C4:
																		goto IL_5BDD;
																		IL_5ED4:
																		num = (short)1664352261;
																		num2 = (int)((IntPtr)num);
																	}
																	IL_5EED:
																	goto IL_4030;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_5F0F;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_5EFC:
																		switch (num2)
																		{
																		case 0:
																			if (disposable != null)
																			{
																				num = (short)644612098;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_5F68;
																		case 1:
																			goto IL_5F66;
																		case 2:
																			disposable.Dispose();
																			num = (short)1057292289;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_5F0F;
																	}
																	IL_5F66:
																	IL_5F68:
																	goto EndFinally_171;
																	IL_5F0F:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)2037448704;
																	num2 = (int)((IntPtr)num);
																	goto IL_5EFC;
																	EndFinally_171:;
																}
																goto IL_5F69;
																IL_4030:
																xmlTextWriter.WriteEndElement();
																num = (short)613416970;
																num2 = (int)((IntPtr)num);
																continue;
															case 8:
																goto IL_6954;
															case 9:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)157155364;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text14 = RptMgrErrorHandler.b("겍", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)1278148613;
																num2 = (int)((IntPtr)num);
																continue;
															case 10:
																goto IL_5398;
															case 11:
																goto IL_5446;
															case 12:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)11010092;
																num2 = (int)((IntPtr)num);
																continue;
															case 13:
																goto IL_4055;
															case 14:
																if (isRightToLeft)
																{
																	num = (short)138870824;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																num = (short)281870373;
																num2 = (int)((IntPtr)num);
																continue;
															case 15:
																goto IL_6954;
															case 16:
																goto IL_3CBD;
															case 17:
																goto IL_57C3;
															case 18:
																if (!enumerator2.MoveNext())
																{
																	num = (short)652607538;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlNode16 = (XmlNode)enumerator2.Current;
																num = (short)1292238862;
																num2 = (int)((IntPtr)num);
																continue;
															case 19:
																if (xmlNode16.Attributes[num3].Value.Contains(AppResources.NOPRINT_Id))
																{
																	num = (short)151453720;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
																num = (short)1371734051;
																num2 = (int)((IntPtr)num);
																continue;
															case 20:
																goto IL_5927;
															case 21:
																goto IL_6AC7;
															case 22:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)1863712806;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_6816;
															case 23:
																text15 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)407044113;
																num2 = (int)((IntPtr)num);
																continue;
															case 24:
																goto IL_56E3;
															case 25:
																goto IL_42CE;
															case 27:
																text13 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)286392328;
																num2 = (int)((IntPtr)num);
																continue;
															case 28:
																if (num4 % 2 == 0)
																{
																	num = (short)1522663436;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)1106313227;
																num2 = (int)((IntPtr)num);
																continue;
															case 29:
																goto IL_600E;
															case 30:
																try
																{
																	num = (short)717291531;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		IEnumerator enumerator5;
																		XmlNode xmlNode19;
																		string text16;
																		switch (num2)
																		{
																		case 1:
																			goto IL_648F;
																		case 2:
																			if (!xmlNode19.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																			{
																				num = (short)820445188;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			text16 = RptMgrErrorHandler.b("겍", a_) + xmlNode19.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																			num = (short)951058438;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 3:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																			num = (short)205651973;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 4:
																			text16 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode19.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																			num = (short)648609799;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 5:
																			goto IL_648F;
																		case 6:
																			goto IL_66EA;
																		case 7:
																			goto IL_66EA;
																		case 8:
																			try
																			{
																				num = (short)39059458;
																				num2 = (int)((IntPtr)num);
																				for (;;)
																				{
																					switch (num2)
																					{
																					case 0:
																						num = (short)274989060;
																						num2 = (int)((IntPtr)num);
																						continue;
																					case 1:
																					{
																						if (!enumerator5.MoveNext())
																						{
																							num = (short)1765539840;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						XmlNode xmlNode20 = (XmlNode)enumerator5.Current;
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뮍", a_));
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																						xmlTextWriter.WriteString(xmlNode20.InnerText);
																						xmlTextWriter.WriteEndElement();
																						xmlTextWriter.WriteEndElement();
																						num = (short)948109315;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					case 2:
																						switch (0)
																						{
																						case 0:
																							goto IL_6209;
																						}
																						continue;
																					case 4:
																						goto IL_6361;
																					}
																					IL_6308:
																					num = (short)405536769;
																					num2 = (int)((IntPtr)num);
																					continue;
																					IL_6209:
																					goto IL_6308;
																				}
																				IL_6361:
																				goto IL_653B;
																			}
																			finally
																			{
																				switch (0)
																				{
																				case 0:
																					goto IL_6383;
																				}
																				IDisposable disposable;
																				for (;;)
																				{
																					IL_6370:
																					switch (num2)
																					{
																					case 0:
																						if (disposable != null)
																						{
																							num = (short)2070872065;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						goto IL_63DB;
																					case 1:
																						disposable.Dispose();
																						num = (short)1357512706;
																						num2 = (int)((IntPtr)num);
																						continue;
																					case 2:
																						goto IL_63D9;
																					}
																					goto IL_6383;
																				}
																				IL_63D9:
																				IL_63DB:
																				goto EndFinally_168;
																				IL_6383:
																				disposable = (enumerator5 as IDisposable);
																				num = (short)1155334144;
																				num2 = (int)((IntPtr)num);
																				goto IL_6370;
																				EndFinally_168:;
																			}
																			goto IL_63DC;
																			IL_653B:
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뮍", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																			xmlTextWriter.WriteString(xmlNode19.Attributes[0].Value);
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뢍", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																			xmlTextWriter.WriteString("");
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			num = (short)1323368448;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 9:
																			if (num4 % 2 == 0)
																			{
																				num = (short)1112145923;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																			num = (short)797507585;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 10:
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)735772684;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_63DC;
																		case 11:
																			switch (0)
																			{
																			case 0:
																				goto IL_60F0;
																			}
																			continue;
																		case 12:
																			num = (short)256049165;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 13:
																			goto IL_679C;
																		}
																		IL_6147:
																		num = (short)1886912522;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_60F0:
																		goto IL_6147;
																		IL_63DC:
																		xmlNode19 = (XmlNode)enumerator4.Current;
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
																		num = (short)1689387017;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_648F:
																		text16 = null;
																		num = (short)888406018;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_66EA:
																		this.f = this.a.SelectNodes(string.Concat(new string[]
																		{
																			RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																			text12,
																			RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																			text17,
																			RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																			text16,
																			RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
																		}));
																		enumerator5 = this.f.GetEnumerator();
																		num = (short)1636958216;
																		num2 = (int)((IntPtr)num);
																	}
																	IL_679C:
																	goto IL_56C2;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_67BE;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_67AB:
																		switch (num2)
																		{
																		case 0:
																			if (disposable != null)
																			{
																				num = (short)1041301505;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_6815;
																		case 1:
																			disposable.Dispose();
																			num = (short)760545282;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 2:
																			goto IL_6813;
																		}
																		goto IL_67BE;
																	}
																	IL_6813:
																	IL_6815:
																	goto EndFinally_169;
																	IL_67BE:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)1065222144;
																	num2 = (int)((IntPtr)num);
																	goto IL_67AB;
																	EndFinally_169:;
																}
																goto IL_6816;
															case 31:
																num = (short)1017249811;
																num2 = (int)((IntPtr)num);
																continue;
															case 32:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("삍\udf8f슑욓\udf95횗캙", a_)))
																{
																	num = (short)194641954;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_5927;
															case 33:
																goto IL_4C35;
															case 34:
																num = (short)152567809;
																num2 = (int)((IntPtr)num);
																continue;
															case 35:
																if (num4 % 2 == 0)
																{
																	num = (short)699400194;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)2029649933;
																num2 = (int)((IntPtr)num);
																continue;
															case 36:
																goto IL_5F69;
															case 37:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("삍\udf8f슑욓\udf95횗캙", a_)))
																{
																	num = (short)1976959007;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_56E3;
															case 38:
																text17 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
																num = (short)1286996016;
																num2 = (int)((IntPtr)num);
																continue;
															case 39:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)387448848;
																num2 = (int)((IntPtr)num);
																continue;
															case 40:
																num = (short)700252192;
																num2 = (int)((IntPtr)num);
																continue;
															case 41:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)1572995095;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text15 = RptMgrErrorHandler.b("겍", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)2119499827;
																num2 = (int)((IntPtr)num);
																continue;
															case 42:
																if (!xmlNode16.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																{
																	num = (short)109707291;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text13 = RptMgrErrorHandler.b("겍", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
																num = (short)402718735;
																num2 = (int)((IntPtr)num);
																continue;
															case 43:
																goto IL_3CBD;
															case 44:
																goto IL_5446;
															case 45:
																if (num4 % 2 == 0)
																{
																	num = (short)1711669287;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																num = (short)1348141099;
																num2 = (int)((IntPtr)num);
																continue;
															case 46:
																goto IL_56C2;
															case 47:
																try
																{
																	num = (short)457113608;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		IEnumerator enumerator5;
																		string text18;
																		switch (num2)
																		{
																		case 0:
																			goto IL_4738;
																		case 1:
																		{
																			XmlNode xmlNode21;
																			if (!xmlNode21.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																			{
																				num = (short)918355970;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			text18 = RptMgrErrorHandler.b("겍", a_) + xmlNode21.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																			num = (short)794624009;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 2:
																		{
																			XmlNode xmlNode21;
																			text18 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode21.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																			num = (short)193921024;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 4:
																		{
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)561446918;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			XmlNode xmlNode21 = (XmlNode)enumerator4.Current;
																			text18 = null;
																			num = (short)1118568449;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 5:
																		{
																			try
																			{
																				num = (short)1487798275;
																				num2 = (int)((IntPtr)num);
																				for (;;)
																				{
																					switch (num2)
																					{
																					case 0:
																					{
																						if (!enumerator5.MoveNext())
																						{
																							num = (short)683212802;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						XmlNode xmlNode22 = (XmlNode)enumerator5.Current;
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뮍", a_));
																						xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																						xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																						xmlTextWriter.WriteString(xmlNode22.InnerText);
																						xmlTextWriter.WriteEndElement();
																						xmlTextWriter.WriteEndElement();
																						num = (short)1125384196;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					case 1:
																						goto IL_4988;
																					case 2:
																						num = (short)497090561;
																						num2 = (int)((IntPtr)num);
																						continue;
																					case 3:
																						switch (0)
																						{
																						case 0:
																							goto IL_485B;
																						}
																						continue;
																					}
																					IL_485D:
																					num = (short)818085888;
																					num2 = (int)((IntPtr)num);
																					continue;
																					IL_485B:
																					goto IL_485D;
																				}
																				IL_4988:;
																			}
																			finally
																			{
																				switch (0)
																				{
																				case 0:
																					goto IL_49A7;
																				}
																				IDisposable disposable;
																				for (;;)
																				{
																					IL_4994:
																					switch (num2)
																					{
																					case 0:
																						goto IL_49FD;
																					case 1:
																						disposable.Dispose();
																						num = (short)1622016000;
																						num2 = (int)((IntPtr)num);
																						continue;
																					case 2:
																						if (disposable != null)
																						{
																							num = (short)1660682241;
																							num2 = (int)((IntPtr)num);
																							continue;
																						}
																						goto IL_49FF;
																					}
																					goto IL_49A7;
																				}
																				IL_49FD:
																				IL_49FF:
																				goto EndFinally_166;
																				IL_49A7:
																				disposable = (enumerator5 as IDisposable);
																				num = (short)1448738818;
																				num2 = (int)((IntPtr)num);
																				goto IL_4994;
																				EndFinally_166:;
																			}
																			XmlNode xmlNode3 = this.a.SelectSingleNode(string.Concat(new string[]
																			{
																				RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																				text12,
																				RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																				text15,
																				RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
																			}));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뢍", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																			xmlTextWriter.WriteString(xmlNode3.Attributes[0].Value);
																			xmlTextWriter.WriteEndElement();
																			xmlTextWriter.WriteEndElement();
																			num = (short)781320195;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		case 6:
																			num = (short)776011783;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 7:
																			goto IL_4BB9;
																		case 8:
																			switch (0)
																			{
																			case 0:
																				goto IL_4687;
																			}
																			continue;
																		case 9:
																			goto IL_4738;
																		}
																		IL_468C:
																		num = (short)1167065092;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_4687:
																		goto IL_468C;
																		IL_4738:
																		this.f = this.a.SelectNodes(string.Concat(new string[]
																		{
																			RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																			text12,
																			RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																			text15,
																			RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																			text18,
																			RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
																		}));
																		enumerator5 = this.f.GetEnumerator();
																		num = (short)84410373;
																		num2 = (int)((IntPtr)num);
																	}
																	IL_4BB9:
																	goto IL_3B6D;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_4BDB;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_4BC8:
																		switch (num2)
																		{
																		case 0:
																			goto IL_4C32;
																		case 1:
																			disposable.Dispose();
																			num = (short)151781376;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 2:
																			if (disposable != null)
																			{
																				num = (short)1208156161;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_4C34;
																		}
																		goto IL_4BDB;
																	}
																	IL_4C32:
																	IL_4C34:
																	goto EndFinally_167;
																	IL_4BDB:
																	disposable = (enumerator4 as IDisposable);
																	num = (short)1428357122;
																	num2 = (int)((IntPtr)num);
																	goto IL_4BC8;
																	EndFinally_167:;
																}
																goto Block_84;
																IL_3B6D:
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뮍", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteString(xmlNode16.Attributes[num3 + 1].Value);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)25821230;
																num2 = (int)((IntPtr)num);
																continue;
															case 48:
																goto IL_69D7;
															case 49:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																num = (short)1140457497;
																num2 = (int)((IntPtr)num);
																continue;
															case 50:
																num = (short)1803091989;
																num2 = (int)((IntPtr)num);
																continue;
															case 51:
																goto IL_57C3;
															case 52:
																switch (0)
																{
																case 0:
																	goto IL_3B68;
																}
																continue;
															}
															goto IL_3B68;
															IL_3CBD:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text15 = null;
															num = (short)1025507369;
															num2 = (int)((IntPtr)num);
															continue;
															IL_4055:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("붍", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteString(xmlNode16.Attributes[num3 + 1].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뢍", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteString(xmlNode16.Attributes[num3].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text14 = null;
															num = (short)1958871049;
															num2 = (int)((IntPtr)num);
															continue;
															IL_42CE:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뾍ꞏ", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteString(xmlNode16.Attributes[num3].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뮍", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
															xmlTextWriter.WriteString(xmlNode16.Attributes[num3 + 1].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text17 = null;
															num = (short)1211957270;
															num2 = (int)((IntPtr)num);
															continue;
															IL_5398:
															num4--;
															num = (short)659554330;
															num2 = (int)((IntPtr)num);
															continue;
															Block_84:
															try
															{
																IL_4C35:
																num = (short)179503117;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	IEnumerator enumerator5;
																	XmlNode xmlNode24;
																	string text19;
																	switch (num2)
																	{
																	case 0:
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightYellow.ToString());
																		num = (short)1179516930;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 1:
																		try
																		{
																			num = (short)2052915202;
																			num2 = (int)((IntPtr)num);
																			for (;;)
																			{
																				switch (num2)
																				{
																				case 1:
																					goto IL_4E2A;
																				case 2:
																					switch (0)
																					{
																					case 0:
																						goto IL_4CD4;
																					}
																					continue;
																				case 3:
																				{
																					if (!enumerator5.MoveNext())
																					{
																						num = (short)2106261508;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					XmlNode xmlNode23 = (XmlNode)enumerator5.Current;
																					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("붍", a_));
																					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
																					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																					xmlTextWriter.WriteString(xmlNode23.InnerText);
																					xmlTextWriter.WriteEndElement();
																					xmlTextWriter.WriteEndElement();
																					num = (short)1434124288;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				case 4:
																					num = (short)2093809665;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				IL_4CD9:
																				num = (short)1193476099;
																				num2 = (int)((IntPtr)num);
																				continue;
																				IL_4CD4:
																				goto IL_4CD9;
																			}
																			IL_4E2A:
																			goto IL_5071;
																		}
																		finally
																		{
																			switch (0)
																			{
																			case 0:
																				goto IL_4E4C;
																			}
																			IDisposable disposable;
																			for (;;)
																			{
																				IL_4E39:
																				switch (num2)
																				{
																				case 0:
																					goto IL_4EA3;
																				case 1:
																					if (disposable != null)
																					{
																						num = (short)1576796162;
																						num2 = (int)((IntPtr)num);
																						continue;
																					}
																					goto IL_4EA5;
																				case 2:
																					disposable.Dispose();
																					num = (short)988217344;
																					num2 = (int)((IntPtr)num);
																					continue;
																				}
																				goto IL_4E4C;
																			}
																			IL_4EA3:
																			IL_4EA5:
																			goto EndFinally_164;
																			IL_4E4C:
																			disposable = (enumerator5 as IDisposable);
																			num = (short)1290403841;
																			num2 = (int)((IntPtr)num);
																			goto IL_4E39;
																			EndFinally_164:;
																		}
																		goto IL_4EA6;
																		IL_5071:
																		xmlTextWriter.WriteEndElement();
																		num = (short)512294917;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 2:
																		goto IL_4EA6;
																	case 3:
																		goto IL_5269;
																	case 4:
																		if (!xmlNode24.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
																		{
																			num = (short)750911496;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		text19 = RptMgrErrorHandler.b("겍", a_) + xmlNode24.Attributes[0].Value + RptMgrErrorHandler.b("겍", a_);
																		num = (short)1527250954;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 6:
																		goto IL_4EA6;
																	case 7:
																		if (num4 % 2 == 0)
																		{
																			num = (short)728629248;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightGray.ToString());
																		num = (short)581697542;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 8:
																		text19 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode24.Attributes[0].Value + RptMgrErrorHandler.b("ꦍ", a_);
																		num = (short)58851331;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 9:
																		num = (short)937164811;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 10:
																		goto IL_5269;
																	case 11:
																		goto IL_531C;
																	case 12:
																		if (!enumerator4.MoveNext())
																		{
																			num = (short)574226441;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		xmlNode24 = (XmlNode)enumerator4.Current;
																		xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
																		num = (short)1860894727;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 13:
																		switch (0)
																		{
																		case 0:
																			goto IL_4C94;
																		}
																		continue;
																	}
																	goto IL_4C94;
																	IL_4EA6:
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																	xmlTextWriter.WriteString("");
																	xmlTextWriter.WriteEndElement();
																	xmlTextWriter.WriteEndElement();
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																	xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																	xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
																	xmlTextWriter.WriteString(xmlNode24.Attributes[0].Value);
																	xmlTextWriter.WriteEndElement();
																	xmlTextWriter.WriteEndElement();
																	text19 = null;
																	num = (short)1627193348;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_5227:
																	num = (short)1962475532;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_4C94:
																	goto IL_5227;
																	IL_5269:
																	this.f = this.a.SelectNodes(string.Concat(new string[]
																	{
																		RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																		text12,
																		RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																		text14,
																		RptMgrErrorHandler.b("펍뾏풑ﶓﺙ잛\ude9d쮡솣쪥첧즫\uddad趯", a_),
																		text19,
																		RptMgrErrorHandler.b("펍뾏쒑歹ﾙ놝쎡좣펥춧", a_)
																	}));
																	enumerator5 = this.f.GetEnumerator();
																	num = (short)1726152705;
																	num2 = (int)((IntPtr)num);
																}
																IL_531C:;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_533B;
																}
																IDisposable disposable;
																for (;;)
																{
																	IL_5328:
																	switch (num2)
																	{
																	case 0:
																		goto IL_5395;
																	case 1:
																		disposable.Dispose();
																		num = (short)1110769664;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 2:
																		if (disposable != null)
																		{
																			num = (short)2012413953;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_5397;
																	}
																	goto IL_533B;
																}
																IL_5395:
																IL_5397:
																goto EndFinally_165;
																IL_533B:
																disposable = (enumerator4 as IDisposable);
																num = (short)57081858;
																num2 = (int)((IntPtr)num);
																goto IL_5328;
																EndFinally_165:;
															}
															goto IL_5398;
															IL_5446:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("붍", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteString(xmlNode16.Attributes[num3 + 1].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꊏ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text13 = null;
															num = (short)1837432874;
															num2 = (int)((IntPtr)num);
															continue;
															IL_56C2:
															num4--;
															num = (short)23199797;
															num2 = (int)((IntPtr)num);
															continue;
															IL_56E3:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
															num = (short)465633308;
															num2 = (int)((IntPtr)num);
															continue;
															IL_57C3:
															this.g = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text12,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text15,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															enumerator4 = this.g.GetEnumerator();
															num = (short)1908801583;
															num2 = (int)((IntPtr)num);
															continue;
															IL_58E4:
															num = (short)63373330;
															num2 = (int)((IntPtr)num);
															continue;
															IL_3B68:
															goto IL_58E4;
															IL_5927:
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
															num = (short)488112173;
															num2 = (int)((IntPtr)num);
															continue;
															IL_5F69:
															text14 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
															num = (short)1251999773;
															num2 = (int)((IntPtr)num);
															continue;
															IL_600E:
															this.g = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text12,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text14,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															enumerator4 = this.g.GetEnumerator();
															num = (short)2021785633;
															num2 = (int)((IntPtr)num);
															continue;
															IL_6816:
															text17 = RptMgrErrorHandler.b("겍", a_) + xmlNode16.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
															num = (short)1130823686;
															num2 = (int)((IntPtr)num);
															continue;
															IL_6954:
															this.g = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text12,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text13,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															enumerator4 = this.g.GetEnumerator();
															num = (short)437321735;
															num2 = (int)((IntPtr)num);
															continue;
															IL_69D7:
															this.g = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_),
																text12,
																RptMgrErrorHandler.b("펍뾏삑쮗ﾙ얝솣얥ﲧ쎩\ud8ab슭햯辱", a_),
																text17,
																RptMgrErrorHandler.b("펍뾏풑ﶓﺙ", a_)
															}));
															enumerator4 = this.g.GetEnumerator();
															num = (short)948437022;
															num2 = (int)((IntPtr)num);
														}
														IL_6AC7:;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_6AE6;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_6AD3:
															switch (num2)
															{
															case 0:
																if (disposable != null)
																{
																	num = (short)287703041;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_6B3F;
															case 1:
																disposable.Dispose();
																num = (short)1052114946;
																num2 = (int)((IntPtr)num);
																continue;
															case 2:
																goto IL_6B3D;
															}
															goto IL_6AE6;
														}
														IL_6B3D:
														IL_6B3F:
														goto EndFinally_172;
														IL_6AE6:
														disposable = (enumerator2 as IDisposable);
														num = (short)1309474816;
														num2 = (int)((IntPtr)num);
														goto IL_6AD3;
														EndFinally_172:;
													}
													goto IL_6B40;
												case 9:
													goto IL_39C5;
												case 10:
													if (isRightToLeft)
													{
														num = (short)809762822;
														num2 = (int)((IntPtr)num);
														continue;
													}
													enumerator2 = this.d.GetEnumerator();
													num = (short)757202964;
													num2 = (int)((IntPtr)num);
													continue;
												case 11:
													if (this.d.Count > 0)
													{
														num = (short)1147731981;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_6B40;
												case 12:
													text12 = RptMgrErrorHandler.b("ꦍ", a_) + xmlNode15.Attributes[num3].Value + RptMgrErrorHandler.b("ꦍ", a_);
													num = (short)1063714843;
													num2 = (int)((IntPtr)num);
													continue;
												case 13:
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
													num = (short)1554579466;
													num2 = (int)((IntPtr)num);
													continue;
												case 14:
													switch (0)
													{
													case 0:
														goto IL_2FF9;
													}
													continue;
												case 15:
													if (this.e.Count > 0)
													{
														num = (short)353828866;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_6B40;
												case 16:
													if (isRightToLeft)
													{
														num = (short)405340163;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뾍ꂏ", a_));
													num = (short)2057437203;
													num2 = (int)((IntPtr)num);
													continue;
												case 17:
													if (!enumerator3.MoveNext())
													{
														num = (short)980484119;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlNode15 = (XmlNode)enumerator3.Current;
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.LightSlateGray.ToString());
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뾍벏ꎑ뢓ꞕ뒗ꮙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꮗ\ud999ꮛꪝ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ude8dﾕﶙ", a_), RptMgrErrorHandler.b("뮍", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗\ud99d튟춡톣횥", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d쪗", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾓ쒟", a_), Colors.Coral.ToString());
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ캙쎟즡쪣쎥\udba7\ud9a9", a_), RptMgrErrorHandler.b("뺍벏ꊑ뢓ꚕ뒗ꮙ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﾏ\ud899펟쪡", a_), RptMgrErrorHandler.b("궍횏풑꒓ꚕꢗꪙ겛꺝", a_));
													num = (short)698417168;
													num2 = (int)((IntPtr)num);
													continue;
												case 18:
													goto IL_6D6E;
												case 19:
													goto IL_35F3;
												case 20:
													try
													{
														num = (short)1589968900;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)1977614338;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode25 = (XmlNode)enumerator2.Current;
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("몍", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꎏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteString(xmlNode25.InnerText);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)607453185;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 2:
																num = (short)71434243;
																num2 = (int)((IntPtr)num);
																continue;
															case 3:
																goto IL_324F;
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_30CD;
																}
																continue;
															}
															IL_31F5:
															num = (short)1995767808;
															num2 = (int)((IntPtr)num);
															continue;
															IL_30CD:
															goto IL_31F5;
														}
														IL_324F:
														goto IL_6C18;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_3271;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_325E:
															switch (num2)
															{
															case 0:
																disposable.Dispose();
																num = (short)2056650753;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
																goto IL_32C8;
															case 2:
																if (disposable != null)
																{
																	num = (short)1550647296;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_32CA;
															}
															goto IL_3271;
														}
														IL_32C8:
														IL_32CA:
														goto EndFinally_163;
														IL_3271:
														disposable = (enumerator2 as IDisposable);
														num = (short)1498152962;
														num2 = (int)((IntPtr)num);
														goto IL_325E;
														EndFinally_163:;
													}
													goto IL_32CB;
												case 21:
													if (!xmlNode15.Attributes[num3].Value.Contains(RptMgrErrorHandler.b("ꦍ", a_)))
													{
														num = (short)1714028556;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_32CB;
												case 23:
													num = (short)1066598418;
													num2 = (int)((IntPtr)num);
													continue;
												case 24:
													goto IL_39C5;
												case 25:
													if (isRightToLeft)
													{
														num = (short)917438465;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("슍", a_));
													xmlTextWriter.WriteString(xmlNode15.Attributes[num3].Value);
													num = (short)1324744728;
													num2 = (int)((IntPtr)num);
													continue;
												case 26:
													try
													{
														num = (short)1600847876;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																num = (short)18219011;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)24838144;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode26 = (XmlNode)enumerator2.Current;
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\uda8d\udb97ﾙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춍ﾏﺑﮕ즙ﾝ캟", a_), RptMgrErrorHandler.b("뢍", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꎏ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
																xmlTextWriter.WriteString(xmlNode26.InnerText);
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)566820866;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 3:
																goto IL_3949;
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_37C8;
																}
																continue;
															}
															IL_37CD:
															num = (short)421265409;
															num2 = (int)((IntPtr)num);
															continue;
															IL_37C8:
															goto IL_37CD;
														}
														IL_3949:
														goto IL_6C18;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_396B;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_3958:
															switch (num2)
															{
															case 0:
																if (disposable != null)
																{
																	num = (short)1855651842;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_39C4;
															case 1:
																goto IL_39C2;
															case 2:
																disposable.Dispose();
																num = (short)207028225;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_396B;
														}
														IL_39C2:
														IL_39C4:
														goto EndFinally_162;
														IL_396B:
														disposable = (enumerator2 as IDisposable);
														num = (short)543162368;
														num2 = (int)((IntPtr)num);
														goto IL_3958;
														EndFinally_162:;
													}
													goto IL_39C5;
												case 27:
													goto IL_6C99;
												case 28:
													if (this.l)
													{
														num = (short)1184825351;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_3A3D;
												}
												goto IL_2FF9;
												IL_32CB:
												text12 = RptMgrErrorHandler.b("겍", a_) + xmlNode15.Attributes[num3].Value + RptMgrErrorHandler.b("겍", a_);
												num = (short)1567162368;
												num2 = (int)((IntPtr)num);
												continue;
												IL_33A9:
												num = (short)1001979921;
												num2 = (int)((IntPtr)num);
												continue;
												IL_2FF9:
												goto IL_33A9;
												IL_35F3:
												xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("뾍ꚏ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ솕ﶗﮛ풟", a_), RptMgrErrorHandler.b("첍ﾏﺑ", a_));
												xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), Colors.DarkBlue.ToString());
												num = (short)230621209;
												num2 = (int)((IntPtr)num);
												continue;
												IL_39C5:
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												text12 = null;
												num = (short)8650773;
												num2 = (int)((IntPtr)num);
												continue;
												IL_3A3D:
												enumerator2 = this.d.GetEnumerator();
												num = (short)1138688026;
												num2 = (int)((IntPtr)num);
												continue;
												IL_6B40:
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												num = (short)63111190;
												num2 = (int)((IntPtr)num);
												continue;
												IL_6C18:
												xmlTextWriter.WriteEndElement();
												this.e = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_) + text12 + RptMgrErrorHandler.b("펍뾏삑쮗ﾙ", a_));
												num = (short)1826422799;
												num2 = (int)((IntPtr)num);
												continue;
												IL_6C99:
												this.d = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱", a_) + text12 + RptMgrErrorHandler.b("펍뾏욑ﾙ풛ﮝ솟욡솣풥螧쎫슭\udbb1삳\udab5\uddb7", a_));
												num = (short)915275787;
												num2 = (int)((IntPtr)num);
											}
											IL_6D6E:
											goto IL_245;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_6D90;
											}
											IDisposable disposable;
											for (;;)
											{
												IL_6D7D:
												switch (num2)
												{
												case 0:
													if (disposable != null)
													{
														num = (short)177537025;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_6DE7;
												case 1:
													disposable.Dispose();
													num = (short)737214466;
													num2 = (int)((IntPtr)num);
													continue;
												case 2:
													goto IL_6DE5;
												}
												goto IL_6D90;
											}
											IL_6DE5:
											IL_6DE7:
											goto EndFinally_173;
											IL_6D90:
											disposable = (enumerator3 as IDisposable);
											num = (short)1356333056;
											num2 = (int)((IntPtr)num);
											goto IL_6D7D;
											EndFinally_173:;
										}
										goto IL_6DE8;
										IL_245:
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("첍ﶕ좗ﮙﮛﮝ잡슣즥\udaa7쾩", a_), RptMgrErrorHandler.b("\uda8d", a_));
										xmlTextWriter.WriteEndElement();
										string xpath = RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛ﶝ쾟첡킣장솧쒩\udfab蚭햳풵풷\udfb9\udfbd궿ꟁ", a_) + AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("풍ﾏﲑ잗ﮙ瞧ﾟ첣장욧쒩즫슭쎯", a_), cultureInfo) + RptMgrErrorHandler.b("ꦍ릏쾑", a_);
										this.c = this.a.SelectNodes(xpath);
										bool flag = true;
										enumerator3 = this.c.GetEnumerator();
										num = (short)1135411208;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 17:
										goto IL_662;
									case 18:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍﶗ늛킟얡", a_));
										num = (short)48889880;
										num2 = (int)((IntPtr)num);
										continue;
									case 19:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﾏﶓﾝ첟좣쾥쾧쒩솫쮭\udeaf욱", a_), RptMgrErrorHandler.b("\udc8d憐ﲓ", a_));
										num = (short)1777991694;
										num2 = (int)((IntPtr)num);
										continue;
									case 21:
										goto IL_856C;
									case 22:
										if (isRightToLeft)
										{
											num = (short)1215823881;
											num2 = (int)((IntPtr)num);
											continue;
										}
										num = (short)36634629;
										num2 = (int)((IntPtr)num);
										continue;
									case 23:
										switch (0)
										{
										case 0:
											goto IL_240;
										}
										continue;
									case 24:
										goto IL_662;
									case 25:
										goto IL_83C0;
									}
									IL_447:
									num = (short)1377107970;
									num2 = (int)((IntPtr)num);
									continue;
									IL_240:
									goto IL_447;
									IL_662:
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ얕鍊", a_), RptMgrErrorHandler.b("벍ꊏ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\uda8d힕ﮛ춟잡쪣튥", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏ쒟", a_), RptMgrErrorHandler.b("쪍ﾓ풕鍊", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좍ﾏﲑ킕聯\ud99f", a_), RptMgrErrorHandler.b("쾍ﮑ歹\uda97ﶛﶝ쮟", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첍ﾏﺑ", a_));
									xmlTextWriter.WriteString(AppResources.ResourceManager.GetString(A_1, cultureInfo) + RptMgrErrorHandler.b("꺍낏늑", a_) + xmlNode.Attributes[num3].Value);
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("좍ﲏ﶑ﶗ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98d憐ﺕ", a_), A_5.ToString());
									num = (short)305594381;
									num2 = (int)((IntPtr)num);
									continue;
									IL_2E06:
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첍ﲏ﶑ﶕ춗펙\udf9b캟횡얣쾥욧쾩\udeab", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("잍ﶏ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud88dﾕﮗﮙ\udf9d첟쮡쎣좥얧쾩슫\udaad", a_), RptMgrErrorHandler.b("춍ﲑ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﮑﺕ", a_), A_4.ToString());
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud98d憐ﺕ", a_), A_3.ToString());
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍ", a_) + A_2);
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									this.c = this.a.SelectNodes(RptMgrErrorHandler.b("ꆍ뾏욑ﾙ잛\ude9d쎡욣쪥춧춫쎭햯辱鎳\uddb7풹\ud9bb첽ꆿ껁賃꿅곇껉꧋ꃍ近", a_));
									enumerator3 = this.c.GetEnumerator();
									num = (short)1161756675;
									num2 = (int)((IntPtr)num);
									continue;
									IL_6DE8:
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍﶗ쎛얟킡킣쎥킧蒩욫\udead힯", a_));
									num = (short)941948935;
									num2 = (int)((IntPtr)num);
									continue;
									IL_8382:
									num = (short)587333642;
									num2 = (int)((IntPtr)num);
									continue;
									IL_83C0:
									xmlTextWriter.WriteString(ReportViewer.convertToArabicDateTime(DateTime.Now.ToString(cultureInfo)));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("좍憐ﶗ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\ud88dﾕﮗﮙ\udf9d캟송첣즥\udaa7", a_), RptMgrErrorHandler.b("\ude8d풕춟", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎍ﾕ", a_), RptMgrErrorHandler.b("뺍", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첍ﲏ﶑ﶕ춗펙\udf9b캟횡얣쾥욧쾩\udeab", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("잍ﶏ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욍ﮑﺕ", a_), RptMgrErrorHandler.b("뚍", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("\udd8dﾏﶗ", a_), Global.contentDir + RptMgrErrorHandler.b("ꆍ튏﶑늛풝", a_));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("\ude8dﮙ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("슍憐ﲑ풕ﾙﶛ", a_));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									num = (short)1410662420;
									num2 = (int)((IntPtr)num);
								}
								IL_856C:;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_858B;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_8578:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)1375404034;
										num2 = (int)((IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)746258432;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_85E5;
									case 2:
										goto IL_85E3;
									}
									goto IL_858B;
								}
								IL_85E3:
								IL_85E5:
								goto EndFinally_186;
								IL_858B:
								IEnumerator enumerator;
								disposable = (enumerator as IDisposable);
								num = (short)1695481857;
								num2 = (int)((IntPtr)num);
								goto IL_8578;
								EndFinally_186:;
							}
							goto IL_85E6;
						}
						goto IL_B1;
						IL_85E6:
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.Close();
						this.l = false;
						num = (short)1106837505;
						num2 = (int)((IntPtr)num);
					}
					IL_8613:
					goto IL_8624;
					IL_B1:
					xmlTextWriter = new XmlTextWriter(Global.flowDocPath + A_0, Encoding.Unicode);
					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("좍ﲏ﶑튕蓮얟첡킣", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶏﺑ望", a_), RptMgrErrorHandler.b("겕랗떙ﶝ좟잡즣장\udba7蒩솫잭펯삱\udbb3억ힷ\udcb9좻邽ꎿ귁꧃뿇ꏉꋋ꣍꣏﷑ꛝ臟迡裣짥飧飩觫鷭闯鳱胳韵賷鏹鏻都", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶏﺑ望ꊗ", a_), RptMgrErrorHandler.b("겕랗떙ﶝ좟잡즣장\udba7蒩솫잭펯삱\udbb3억ힷ\udcb9좻邽ꎿ귁꧃뿇ꏉꋋ꣍꣏﷑ꛝ臟迡裣", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("삍ﾑ", a_), RptMgrErrorHandler.b("ﲏﮓ", a_));
					num = (short)968622080;
					num2 = (int)((IntPtr)num);
					goto IL_9A;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					result = false;
				}
				IL_8624:
				num = (short)247988224;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x002A7AB4 File Offset: 0x002A5CB4
		private bool a(string A_0, string A_1, int A_2, int A_3, int A_4, bool A_5 = true)
		{
			int a_ = 2;
			short num = (short)476381184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)120782848;
				short num3 = num;
				num = (short)1732640769;
				if (num != 0)
				{
				}
				this.b = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ춈歷", a_));
				int num4 = 0;
				int num5 = 0;
				bool result = true;
				CultureInfo cultureInfo = new CultureInfo(AppInfoManager.ReportsLangSelection);
				bool isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_DC;
					}
					XmlTextWriter xmlTextWriter;
					for (;;)
					{
						IL_C5:
						switch (num2)
						{
						case 0:
						{
							IEnumerator enumerator = this.b.GetEnumerator();
							num = (short)1500971010;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 1:
							if (this.b.Count != 0)
							{
								num = (short)1688993792;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_2A51;
						case 2:
							try
							{
								num = (short)1987510277;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									IEnumerator enumerator4;
									switch (num2)
									{
									case 0:
										goto IL_287;
									case 1:
										goto IL_287;
									case 2:
									{
										if (isRightToLeft)
										{
											num = (short)1365180436;
											num2 = (int)((IntPtr)num);
											continue;
										}
										XmlNode xmlNode;
										xmlTextWriter.WriteString(AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("힄킎\ud890ﶒﲜ좠첢쮤", a_), cultureInfo) + RptMgrErrorHandler.b("ꖄꞆꦈ", a_) + xmlNode.Attributes[num4].Value);
										num = (short)757661717;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 3:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ붒ﾔﺘ", a_));
										num = (short)1686896650;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
										goto IL_29D9;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_282;
										}
										continue;
									case 6:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898쾠캢삤즦\udda8", a_), RptMgrErrorHandler.b("힄歷", a_));
										num = (short)1374814208;
										num2 = (int)((IntPtr)num);
										continue;
									case 7:
										try
										{
											num = (short)2123366403;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												string text;
												string text2;
												switch (num2)
												{
												case 0:
												{
													XmlNode xmlNode2;
													text = RptMgrErrorHandler.b("ꊄ", a_) + xmlNode2.Attributes[num4].Value + RptMgrErrorHandler.b("ꊄ", a_);
													num = (short)2083651605;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 1:
													try
													{
														num = (short)546570244;
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
																	num = (short)641007618;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text2 = ((XmlNode)enumerator2.Current).InnerText + RptMgrErrorHandler.b("ꖄꞆꦈꮊ권", a_);
																num = (short)1108148227;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 1:
																goto IL_176D;
															case 2:
																num = (short)1838219265;
																num2 = (int)((IntPtr)num);
																continue;
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_16DB;
																}
																continue;
															}
															IL_16DD:
															num = (short)814546944;
															num2 = (int)((IntPtr)num);
															continue;
															IL_16DB:
															goto IL_16DD;
														}
														IL_176D:
														goto IL_138A;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_178F;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_177C:
															switch (num2)
															{
															case 0:
																goto IL_183C;
															case 1:
															{
																num = (short)1786637381;
																short num6 = num;
																num = (short)889252933;
																switch ((num6 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	continue;
																default:
																	num = (short)1945042944;
																	if (num != 0)
																	{
																	}
																	disposable.Dispose();
																	num = (short)622133248;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																break;
															}
															case 2:
																if (disposable != null)
																{
																	num = (short)1233387521;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_183E;
															}
															goto IL_178F;
														}
														IL_183C:
														IL_183E:
														goto EndFinally_59;
														IL_178F:
														IEnumerator enumerator2;
														disposable = (enumerator2 as IDisposable);
														num = (short)1055719426;
														num2 = (int)((IntPtr)num);
														goto IL_177C;
														EndFinally_59:;
													}
													goto IL_183F;
												case 2:
													goto IL_23AA;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_9ED;
													}
													continue;
												case 4:
													goto IL_167B;
												case 5:
													try
													{
														num = (short)1177485322;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															string text3;
															IEnumerator enumerator3;
															XmlNode xmlNode5;
															string text4;
															switch (num2)
															{
															case 0:
															{
																IEnumerator enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)1085866003;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
																text3 = null;
																num = (short)348782605;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 1:
																goto IL_20FD;
															case 2:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGoldenrodYellow.ToString());
																num = (short)1700200454;
																num2 = (int)((IntPtr)num);
																continue;
															case 3:
															{
																XmlNode xmlNode3;
																text3 = RptMgrErrorHandler.b("ꊄ", a_) + xmlNode3.Attributes[num4].Value + RptMgrErrorHandler.b("ꊄ", a_);
																num = (short)794427406;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 4:
																try
																{
																	num = (short)984743938;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		XmlNode xmlNode4;
																		switch (num2)
																		{
																		case 0:
																			goto IL_1D32;
																		case 1:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGoldenrodYellow.ToString());
																			num = (short)1111752704;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 2:
																			switch (0)
																			{
																			case 0:
																				goto IL_1BF1;
																			}
																			continue;
																		case 3:
																			goto IL_1D32;
																		case 4:
																			if (num5 % 2 == 0)
																			{
																				num = (short)433127425;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGray.ToString());
																			num = (short)1004404739;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 5:
																			goto IL_1CFC;
																		case 6:
																			goto IL_1E84;
																		case 7:
																			if (isRightToLeft)
																			{
																				num = (short)1828323339;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
																			num = (short)440074245;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 8:
																			num = (short)2043412486;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 9:
																			if (!enumerator3.MoveNext())
																			{
																				num = (short)660078600;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlNode4 = (XmlNode)enumerator3.Current;
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄첎ﾒ璉", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
																			num = (short)1041104900;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 10:
																			goto IL_1CFC;
																		case 11:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("힄歷", a_));
																			num = (short)2056519690;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_1BF1;
																		IL_1CFC:
																		xmlTextWriter.WriteString(xmlNode4.InnerText);
																		xmlTextWriter.WriteEndElement();
																		xmlTextWriter.WriteEndElement();
																		num = (short)693370892;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1D32:
																		num = (short)1932722183;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1D6E:
																		num = (short)744292361;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1BF1:
																		goto IL_1D6E;
																	}
																	IL_1E84:
																	goto IL_2264;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_1EA6;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_1E93:
																		switch (num2)
																		{
																		case 0:
																			if (disposable != null)
																			{
																				num = (short)1886912514;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_1EFE;
																		case 1:
																			goto IL_1EFC;
																		case 2:
																			disposable.Dispose();
																			num = (short)322764801;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_1EA6;
																	}
																	IL_1EFC:
																	IL_1EFE:
																	goto EndFinally_57;
																	IL_1EA6:
																	disposable = (enumerator3 as IDisposable);
																	num = (short)267649024;
																	num2 = (int)((IntPtr)num);
																	goto IL_1E93;
																	EndFinally_57:;
																}
																goto IL_1EFF;
																IL_2264:
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄첎ﾒ璉", a_));
																xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
																num = (short)1436811284;
																num2 = (int)((IntPtr)num);
																continue;
															case 5:
																goto IL_232D;
															case 6:
																goto IL_1A52;
															case 7:
																if (!xmlNode5.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꊄ", a_)))
																{
																	num = (short)1059127313;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text4 = RptMgrErrorHandler.b("Ꞅ", a_) + xmlNode5.Attributes[0].Value + RptMgrErrorHandler.b("Ꞅ", a_);
																num = (short)1065615381;
																num2 = (int)((IntPtr)num);
																continue;
															case 8:
																goto IL_20FD;
															case 9:
																if (isRightToLeft)
																{
																	num = (short)327352331;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
																num = (short)436207617;
																num2 = (int)((IntPtr)num);
																continue;
															case 10:
																switch (0)
																{
																case 0:
																	goto IL_19FA;
																}
																continue;
															case 11:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("힄歷", a_));
																num = (short)712245256;
																num2 = (int)((IntPtr)num);
																continue;
															case 12:
																goto IL_2032;
															case 13:
															{
																XmlNode xmlNode3;
																if (!xmlNode3.Attributes[num4].Value.Contains(RptMgrErrorHandler.b("ꊄ", a_)))
																{
																	num = (short)1741946883;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text3 = RptMgrErrorHandler.b("Ꞅ", a_) + xmlNode3.Attributes[num4].Value + RptMgrErrorHandler.b("Ꞅ", a_);
																num = (short)186384396;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 14:
																goto IL_2032;
															case 15:
																goto IL_1A52;
															case 17:
																text4 = RptMgrErrorHandler.b("ꊄ", a_) + xmlNode5.Attributes[0].Value + RptMgrErrorHandler.b("ꊄ", a_);
																num = (short)817954834;
																num2 = (int)((IntPtr)num);
																continue;
															case 18:
																goto IL_1EFF;
															case 19:
																num = (short)789774341;
																num2 = (int)((IntPtr)num);
																continue;
															case 20:
																if (num5 % 2 == 0)
																{
																	num = (short)2110521346;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGray.ToString());
																num = (short)322240527;
																num2 = (int)((IntPtr)num);
																continue;
															case 21:
																goto IL_1EFF;
															}
															goto IL_19FA;
															IL_1A52:
															num = (short)995426313;
															num2 = (int)((IntPtr)num);
															continue;
															IL_1EFF:
															this.f = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_),
																text,
																RptMgrErrorHandler.b("\ud884ꢆ\udb88\udc8e캔힖쮘ﺚﺜ쮞좠힢즤슦钨", a_),
																text3,
																RptMgrErrorHandler.b("\ud884ꢆ쾈좒햔톖ﺚﮞ욢횤骦", a_),
																text4,
																RptMgrErrorHandler.b("\ud884ꢆ\udf88搜", a_)
															}));
															enumerator3 = this.f.GetEnumerator();
															num = (short)1839595524;
															num2 = (int)((IntPtr)num);
															continue;
															IL_2032:
															xmlNode5 = this.a.SelectSingleNode(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_),
																text,
																RptMgrErrorHandler.b("\ud884ꢆ\udb88\udc8e캔힖쮘ﺚﺜ쮞좠힢즤슦钨", a_),
																text3,
																RptMgrErrorHandler.b("\ud884ꢆ쾈", a_)
															}));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄\udd8eﺐ", a_));
															text4 = null;
															num = (short)897318919;
															num2 = (int)((IntPtr)num);
															continue;
															IL_20FD:
															xmlTextWriter.WriteString(xmlNode5.Attributes[0].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															num5++;
															xmlTextWriter.WriteEndElement();
															num = (short)1789263888;
															num2 = (int)((IntPtr)num);
															continue;
															IL_2221:
															num = (short)1460404224;
															num2 = (int)((IntPtr)num);
															continue;
															IL_19FA:
															goto IL_2221;
														}
														IL_232D:
														goto IL_13C7;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_234F;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_233C:
															switch (num2)
															{
															case 0:
																if (disposable != null)
																{
																	num = (short)835846146;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_23A9;
															case 1:
																goto IL_23A7;
															case 2:
																disposable.Dispose();
																num = (short)244056065;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_234F;
														}
														IL_23A7:
														IL_23A9:
														goto EndFinally_58;
														IL_234F:
														IEnumerator enumerator2;
														disposable = (enumerator2 as IDisposable);
														num = (short)1589051392;
														num2 = (int)((IntPtr)num);
														goto IL_233C;
														EndFinally_58:;
													}
													goto IL_23AA;
												case 6:
													num = (short)1394737160;
													num2 = (int)((IntPtr)num);
													continue;
												case 7:
													goto IL_23AA;
												case 8:
												{
													if (isRightToLeft)
													{
														num = (short)1346633745;
														num2 = (int)((IntPtr)num);
														continue;
													}
													IEnumerator enumerator2 = this.e.GetEnumerator();
													num = (short)623706125;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 10:
												{
													text2 = "";
													IEnumerator enumerator2 = this.d.GetEnumerator();
													num = (short)1044709377;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 11:
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("힄歷", a_));
													num = (short)282918914;
													num2 = (int)((IntPtr)num);
													continue;
												case 12:
													if (isRightToLeft)
													{
														num = (short)1985806347;
														num2 = (int)((IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
													num = (short)1652293639;
													num2 = (int)((IntPtr)num);
													continue;
												case 13:
													try
													{
														num = (short)1572995074;
														num2 = (int)((IntPtr)num);
														for (;;)
														{
															IEnumerator enumerator3;
															XmlNode xmlNode5;
															string text5;
															string text6;
															switch (num2)
															{
															case 0:
																if (num5 % 2 == 0)
																{
																	num = (short)482672655;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGray.ToString());
																num = (short)214106117;
																num2 = (int)((IntPtr)num);
																continue;
															case 1:
																if (!xmlNode5.Attributes[0].Value.Contains(RptMgrErrorHandler.b("ꊄ", a_)))
																{
																	num = (short)1493565456;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text5 = RptMgrErrorHandler.b("Ꞅ", a_) + xmlNode5.Attributes[0].Value + RptMgrErrorHandler.b("Ꞅ", a_);
																num = (short)309788678;
																num2 = (int)((IntPtr)num);
																continue;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_AA2;
																}
																continue;
															case 3:
																goto IL_C2B;
															case 4:
															{
																IEnumerator enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)293666827;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																XmlNode xmlNode6 = (XmlNode)enumerator2.Current;
																text6 = null;
																num = (short)692518920;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 5:
																goto IL_D42;
															case 6:
																goto IL_11C0;
															case 7:
																goto IL_D42;
															case 8:
															{
																XmlNode xmlNode6;
																if (!xmlNode6.Attributes[num4].Value.Contains(RptMgrErrorHandler.b("ꊄ", a_)))
																{
																	num = (short)1261502476;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																text6 = RptMgrErrorHandler.b("Ꞅ", a_) + xmlNode6.Attributes[num4].Value + RptMgrErrorHandler.b("Ꞅ", a_);
																num = (short)153223178;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 10:
																goto IL_C2B;
															case 11:
																num = (short)210436110;
																num2 = (int)((IntPtr)num);
																continue;
															case 12:
															{
																XmlNode xmlNode6;
																text6 = RptMgrErrorHandler.b("ꊄ", a_) + xmlNode6.Attributes[num4].Value + RptMgrErrorHandler.b("ꊄ", a_);
																num = (short)2078343171;
																num2 = (int)((IntPtr)num);
																continue;
															}
															case 13:
																try
																{
																	num = (short)438501388;
																	num2 = (int)((IntPtr)num);
																	for (;;)
																	{
																		XmlNode xmlNode7;
																		switch (num2)
																		{
																		case 0:
																			if (num5 % 2 == 0)
																			{
																				num = (short)352714761;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGray.ToString());
																			num = (short)1431371777;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 1:
																			goto IL_FAA;
																		case 2:
																			goto IL_10AF;
																		case 3:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("힄歷", a_));
																			num = (short)537067524;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 4:
																			goto IL_1022;
																		case 5:
																			goto IL_FAA;
																		case 7:
																			goto IL_1022;
																		case 8:
																			if (isRightToLeft)
																			{
																				num = (short)2062680067;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
																			num = (short)1143472135;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 9:
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGoldenrodYellow.ToString());
																			num = (short)1794179077;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 10:
																			if (!enumerator3.MoveNext())
																			{
																				num = (short)1483341835;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			xmlNode7 = (XmlNode)enumerator3.Current;
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄첎ﾒ璉", a_));
																			xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
																			xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
																			num = (short)993067008;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 11:
																			num = (short)925892610;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 12:
																			switch (0)
																			{
																			case 0:
																				goto IL_E23;
																			}
																			continue;
																		}
																		goto IL_E23;
																		IL_FAA:
																		num = (short)1808400392;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1022:
																		xmlTextWriter.WriteString(xmlNode7.InnerText);
																		xmlTextWriter.WriteEndElement();
																		xmlTextWriter.WriteEndElement();
																		num = (short)674365446;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_1058:
																		num = (short)1149829130;
																		num2 = (int)((IntPtr)num);
																		continue;
																		IL_E23:
																		goto IL_1058;
																	}
																	IL_10AF:
																	goto IL_1259;
																}
																finally
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_10D1;
																	}
																	IDisposable disposable;
																	for (;;)
																	{
																		IL_10BE:
																		switch (num2)
																		{
																		case 0:
																			goto IL_1129;
																		case 1:
																			disposable.Dispose();
																			num = (short)561774592;
																			num2 = (int)((IntPtr)num);
																			continue;
																		case 2:
																			if (disposable != null)
																			{
																				num = (short)1153105921;
																				num2 = (int)((IntPtr)num);
																				continue;
																			}
																			goto IL_112B;
																		}
																		goto IL_10D1;
																	}
																	IL_1129:
																	IL_112B:
																	break;
																	IL_10D1:
																	disposable = (enumerator3 as IDisposable);
																	num = (short)1629618178;
																	num2 = (int)((IntPtr)num);
																	goto IL_10BE;
																}
																break;
																IL_1259:
																num5++;
																xmlTextWriter.WriteEndElement();
																num = (short)1902903305;
																num2 = (int)((IntPtr)num);
																continue;
															case 14:
																goto IL_130C;
															case 15:
																xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.LightGoldenrodYellow.ToString());
																num = (short)79691783;
																num2 = (int)((IntPtr)num);
																continue;
															case 16:
																text5 = RptMgrErrorHandler.b("ꊄ", a_) + xmlNode5.Attributes[0].Value + RptMgrErrorHandler.b("ꊄ", a_);
																num = (short)914096145;
																num2 = (int)((IntPtr)num);
																continue;
															case 17:
																goto IL_11C0;
															}
															goto IL_AA2;
															IL_C2B:
															xmlNode5 = this.a.SelectSingleNode(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_),
																text,
																RptMgrErrorHandler.b("\ud884ꢆ\udb88\udc8e캔힖쮘ﺚﺜ쮞좠힢즤슦钨", a_),
																text6,
																RptMgrErrorHandler.b("\ud884ꢆ쾈", a_)
															}));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄\udd8eﺐ", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄첎ﾒ璉", a_));
															xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
															xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
															num = (short)994377728;
															num2 = (int)((IntPtr)num);
															continue;
															IL_D42:
															xmlTextWriter.WriteString(xmlNode5.Attributes[0].Value);
															xmlTextWriter.WriteEndElement();
															xmlTextWriter.WriteEndElement();
															text5 = null;
															num = (short)1138819073;
															num2 = (int)((IntPtr)num);
															continue;
															IL_112C:
															num = (short)1428094980;
															num2 = (int)((IntPtr)num);
															continue;
															IL_AA2:
															goto IL_112C;
															IL_11C0:
															this.f = this.a.SelectNodes(string.Concat(new string[]
															{
																RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_),
																text,
																RptMgrErrorHandler.b("\ud884ꢆ\udb88\udc8e캔힖쮘ﺚﺜ쮞좠힢즤슦钨", a_),
																text6,
																RptMgrErrorHandler.b("\ud884ꢆ쾈좒햔톖ﺚﮞ욢횤骦", a_),
																text5,
																RptMgrErrorHandler.b("\ud884ꢆ\udf88搜", a_)
															}));
															enumerator3 = this.f.GetEnumerator();
															num = (short)869466125;
															num2 = (int)((IntPtr)num);
														}
														IL_130C:
														goto IL_13C7;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_132E;
														}
														IDisposable disposable;
														for (;;)
														{
															IL_131B:
															switch (num2)
															{
															case 0:
																goto IL_1387;
															case 1:
																disposable.Dispose();
																num = (short)1371668480;
																num2 = (int)((IntPtr)num);
																continue;
															case 2:
																if (disposable != null)
																{
																	num = (short)944046081;
																	num2 = (int)((IntPtr)num);
																	continue;
																}
																goto IL_1389;
															}
															goto IL_132E;
														}
														IL_1387:
														IL_1389:
														goto EndFinally_56;
														IL_132E:
														IEnumerator enumerator2;
														disposable = (enumerator2 as IDisposable);
														num = (short)1858273282;
														num2 = (int)((IntPtr)num);
														goto IL_131B;
														EndFinally_56:;
													}
													goto IL_138A;
												case 14:
												{
													XmlNode xmlNode2;
													if (!xmlNode2.Attributes[num4].Value.Contains(RptMgrErrorHandler.b("ꊄ", a_)))
													{
														num = (short)888733696;
														num2 = (int)((IntPtr)num);
														continue;
													}
													text = RptMgrErrorHandler.b("Ꞅ", a_) + xmlNode2.Attributes[num4].Value + RptMgrErrorHandler.b("Ꞅ", a_);
													num = (short)2117206038;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 15:
													if (this.e.Count > 0)
													{
														num = (short)1138098182;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_13C7;
												case 16:
												{
													if (!enumerator4.MoveNext())
													{
														num = (short)2013265938;
														num2 = (int)((IntPtr)num);
														continue;
													}
													XmlNode xmlNode2 = (XmlNode)enumerator4.Current;
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﶎﺐﮔ", a_), Colors.Coral.ToString());
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ얐ﮒﲔ튠", a_), RptMgrErrorHandler.b("랄ꮆ뮈꞊뾌ꎎꎐ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ펐", a_), RptMgrErrorHandler.b("Ꚅ솆쾈뮊붌벎튐꒒ꆔ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("햄", a_), RptMgrErrorHandler.b("뚄", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄\udd8eﺐ튔", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄\udd8eﺐ", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄첎ﾒ璉", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ얐ﮒﲔ튠", a_), RptMgrErrorHandler.b("떄ꮆ릈꞊붌ꎎꎐ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("욄ﺊ슐練", a_), RptMgrErrorHandler.b("랄", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임ﮈﶎ펐", a_), RptMgrErrorHandler.b("Ꚅ솆쾈뮊붌뾎ꆐꎒꖔ", a_));
													xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
													xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\uda8cﶔ", a_), RptMgrErrorHandler.b("임", a_));
													text = null;
													num = (short)1491533838;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 17:
												{
													IEnumerator enumerator2 = this.e.GetEnumerator();
													num = (short)1301479429;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 18:
													num = (short)1801715731;
													num2 = (int)((IntPtr)num);
													continue;
												case 19:
													goto IL_253C;
												case 20:
													if (this.d.Count > 0)
													{
														num = (short)266928138;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_167B;
												case 21:
													goto IL_183F;
												case 22:
													goto IL_183F;
												}
												goto IL_9ED;
												IL_138A:
												num = (short)1126236172;
												num2 = (int)((IntPtr)num);
												continue;
												IL_13C7:
												xmlTextWriter.WriteEndElement();
												num = (short)251461636;
												num2 = (int)((IntPtr)num);
												continue;
												IL_167B:
												xmlTextWriter.WriteEndElement();
												num = (short)134152201;
												num2 = (int)((IntPtr)num);
												continue;
												IL_183F:
												this.d = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_) + text + RptMgrErrorHandler.b("\ud884ꢆ\udd88\udb92ﶘﺚ낞첢즤삨\udfaa솬쪮", a_));
												num = (short)1681784852;
												num2 = (int)((IntPtr)num);
												continue;
												IL_23AA:
												xmlTextWriter.WriteString(text2);
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												xmlTextWriter.WriteEndElement();
												this.e = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ\udd88좒햔쎖連爵슢좤슦钨", a_) + text + RptMgrErrorHandler.b("\ud884ꢆ\udb88\udc8e", a_));
												num = (short)1130364943;
												num2 = (int)((IntPtr)num);
												continue;
												IL_2445:
												num = (short)1580138512;
												num2 = (int)((IntPtr)num);
												continue;
												IL_9ED:
												goto IL_2445;
											}
											IL_253C:
											goto IL_828;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_255E;
											}
											IDisposable disposable;
											for (;;)
											{
												IL_254B:
												switch (num2)
												{
												case 0:
													if (disposable != null)
													{
														num = (short)1274478594;
														num2 = (int)((IntPtr)num);
														continue;
													}
													goto IL_25B6;
												case 1:
													goto IL_25B4;
												case 2:
													disposable.Dispose();
													num = (short)2091057153;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_255E;
											}
											IL_25B4:
											IL_25B6:
											goto EndFinally_60;
											IL_255E:
											disposable = (enumerator4 as IDisposable);
											num = (short)622002176;
											num2 = (int)((IntPtr)num);
											goto IL_254B;
											EndFinally_60:;
										}
										goto IL_25B7;
										IL_828:
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﺊﾌ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("펄ﮈﾊﾒ풔練滛", a_), RptMgrErrorHandler.b("햄쾌杖殺", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898ﺜ캠톢", a_), RptMgrErrorHandler.b("욄ﾊ솒ﲔ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좄ﮈ", a_), RptMgrErrorHandler.b("뒄ꮆ뢈꞊벌ꎎꂐ", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("임\uda8e\ud890킒杖練漢쒠톢", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("톄ﾊ쾌ﺐﺔ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("뒄떆", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄", a_));
										num = (short)1189150729;
										num2 = (int)((IntPtr)num);
										continue;
									case 8:
										goto IL_280F;
									case 9:
										if (isRightToLeft)
										{
											num = (short)2085290003;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898쾠캢삤즦\udda8", a_), RptMgrErrorHandler.b("힄歷", a_));
										num = (short)1993342991;
										num2 = (int)((IntPtr)num);
										continue;
									case 10:
										goto IL_71B;
									case 11:
										num = (short)1628045338;
										num2 = (int)((IntPtr)num);
										continue;
									case 12:
										if (A_5)
										{
											num = (short)2090598403;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ첒ﮖ爵얠ﲢ펤슦\udba8\udfaa좬힮龰\ud9b2어킶", a_));
										num = (short)1278803986;
										num2 = (int)((IntPtr)num);
										continue;
									case 13:
									{
										IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)851902493;
											num2 = (int)((IntPtr)num);
											continue;
										}
										XmlNode xmlNode = (XmlNode)enumerator.Current;
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("횄ﾊﾐ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("임\udf8e햖ﲘﶚ쒠", a_), RptMgrErrorHandler.b("톄ﲈ", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
										xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첄", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮎ", a_), RptMgrErrorHandler.b("낄랆", a_));
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﮈ歷戀", a_), RptMgrErrorHandler.b("쎄", a_));
										num = (short)1221197847;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 15:
										goto IL_280F;
									case 16:
										if (isRightToLeft)
										{
											num = (short)753336326;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898쾠캢삤즦\udda8", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
										num = (short)1631518721;
										num2 = (int)((IntPtr)num);
										continue;
									case 17:
										goto IL_71B;
									case 18:
										goto IL_71B;
									case 19:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮈﾐﮖ\ud898쾠캢삤즦\udda8", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
										num = (short)1015349256;
										num2 = (int)((IntPtr)num);
										continue;
									case 20:
									{
										XmlNode xmlNode;
										xmlTextWriter.WriteString(xmlNode.Attributes[num4].Value + RptMgrErrorHandler.b("ꖄꞆꦈ", a_) + AppResources.ResourceManager.GetString(RptMgrErrorHandler.b("힄킎\ud890ﶒﲜ좠첢쮤", a_), cultureInfo));
										num = (short)492371992;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 21:
										goto IL_25B7;
									case 22:
										goto IL_71B;
									case 23:
										if (isRightToLeft)
										{
											num = (short)566951947;
											num2 = (int)((IntPtr)num);
											continue;
										}
										num = (short)1277034508;
										num2 = (int)((IntPtr)num);
										continue;
									case 24:
										goto IL_25B7;
									case 25:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("힄歷", a_));
										num = (short)2135883804;
										num2 = (int)((IntPtr)num);
										continue;
									case 26:
										if (A_5)
										{
											num = (short)1286144031;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ첒辠즢햤삦", a_));
										num = (short)1069285393;
										num2 = (int)((IntPtr)num);
										continue;
									case 27:
										if (isRightToLeft)
										{
											num = (short)1460076569;
											num2 = (int)((IntPtr)num);
											continue;
										}
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("즄ﾊ", a_));
										num = (short)1593114654;
										num2 = (int)((IntPtr)num);
										continue;
									case 28:
										goto IL_3E1;
									case 29:
										num = (short)796983300;
										num2 = (int)((IntPtr)num);
										continue;
									case 30:
										goto IL_3E1;
									case 31:
										xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ첒ﮖ爵얠趢쾤힦캨", a_));
										num = (short)483852310;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_282;
									IL_287:
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첄", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("펄ﮈﾊﾒ풔ﮖﲚ쒠춢톤", a_), RptMgrErrorHandler.b("톄麗", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("춄ﮎ", a_), A_3.ToString());
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("튄ﾊ", a_), A_2.ToString());
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ", a_) + A_1);
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									this.c = this.a.SelectNodes(RptMgrErrorHandler.b("ꪄꢆ\udd88", a_));
									enumerator4 = this.c.GetEnumerator();
									num = (short)1038155783;
									num2 = (int)((IntPtr)num);
									continue;
									IL_3E1:
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄歷", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("튄ﾊ", a_), A_4.ToString());
									num = (short)611844112;
									num2 = (int)((IntPtr)num);
									continue;
									IL_4DC:
									num = (short)1104019469;
									num2 = (int)((IntPtr)num);
									continue;
									IL_282:
									goto IL_4DC;
									IL_71B:
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ\ude8c", a_), RptMgrErrorHandler.b("랄떆", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("톄ﾊ첌ﮔ殺ﲘ", a_), RptMgrErrorHandler.b("욄ﾊﶎ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﮈﶎﺐﮔ", a_), Colors.DarkBlue.ToString());
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쎄ﾊ쮌ﲐ朗璉", a_), RptMgrErrorHandler.b("쒄춎﶐ﲖ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("임", a_));
									num = (short)887881730;
									num2 = (int)((IntPtr)num);
									continue;
									IL_25B7:
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
									num = (short)1150287899;
									num2 = (int)((IntPtr)num);
									continue;
									IL_280F:
									xmlTextWriter.WriteString(ReportViewer.convertToArabicDateTime(DateTime.Now.ToString(cultureInfo)));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﺊﾌ", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("펄ﮈﾊﾒ풔練滛", a_), RptMgrErrorHandler.b("햄쾌杖殺", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("좄ﮈ", a_), RptMgrErrorHandler.b("뒄ꮆ뢈꞊벌ꎎꂐ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("임\uda8e\ud890킒杖練漢쒠톢", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("첄", a_));
									xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("횄ﲈ力", a_), Global.contentDir + RptMgrErrorHandler.b("ꪄ얆ﾊ歷ﲐ붒\udf94잖\ude98", a_));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("햄ﮈﶎﶔ", a_));
									xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("즄쾌ﶎﺔ", a_));
									xmlTextWriter.WriteEndElement();
									xmlTextWriter.WriteEndElement();
									num = (short)1001783310;
									num2 = (int)((IntPtr)num);
								}
								IL_29D9:;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_29F8;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_29E5:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)827195394;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_2A50;
									case 1:
										goto IL_2A4E;
									case 2:
										disposable.Dispose();
										num = (short)721747969;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_29F8;
								}
								IL_2A4E:
								IL_2A50:
								goto EndFinally_61;
								IL_29F8:
								IEnumerator enumerator;
								disposable = (enumerator as IDisposable);
								num = (short)372637696;
								num2 = (int)((IntPtr)num);
								goto IL_29E5;
								EndFinally_61:;
							}
							goto IL_2A51;
						case 3:
							goto IL_2A77;
						}
						goto IL_DC;
						IL_2A51:
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.Close();
						num = (short)1700069379;
						num2 = (int)((IntPtr)num);
					}
					IL_2A77:
					return result;
					IL_DC:
					xmlTextWriter = new XmlTextWriter(Global.flowDocPath + A_0, Encoding.Unicode);
					xmlTextWriter.WriteStartElement(RptMgrErrorHandler.b("쎄ﲊ즌", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶄﺌ", a_), RptMgrErrorHandler.b("ﶈﮊ람ꂎ뺐ﾖﲘﲜ辠캢첤쒦\udba8쒪\udeac삮ힰ잲鮴풶횸횺銼좾ꣀ귂ꏄ뿆流﷌ￎﳒ귔뛖듘럚꿞鏠蛢雤苦蟨鿪賬鯮飰鳲鯴", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("ﶄﺌ떎", a_), RptMgrErrorHandler.b("ﶈﮊ람ꂎ뺐ﾖﲘﲜ辠캢첤쒦\udba8쒪\udeac삮ힰ잲鮴풶횸횺銼좾ꣀ귂ꏄ뿆流﷌ￎﳒ귔뛖듘럚", a_));
					xmlTextWriter.WriteAttributeString(RptMgrErrorHandler.b("쮄", a_), RptMgrErrorHandler.b("", a_));
					num = (short)1161428993;
					num2 = (int)((IntPtr)num);
					goto IL_C5;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x002AA610 File Offset: 0x002A8810
		private void a(ref string A_0, ref int A_1, ref int A_2, ref int A_3, string A_4, int A_5, int A_6, int A_7)
		{
			short num = (short)1376633968;
			short num2 = num;
			num = (short)507430000;
			switch (num2 == num)
			{
			}
			num = (short)1848967169;
			if (num != 0)
			{
			}
			num = (short)135069696;
			short num3 = num;
			num = (short)1233911808;
			if (num != 0)
			{
			}
			A_0 = A_4;
			A_1 = A_5;
			A_2 = A_6;
			A_3 = A_7;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x002AA6CC File Offset: 0x002A88CC
		private bool f()
		{
			int a_ = 2;
			short num = (short)1972305920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4EC;
				}
				string radInfoGeneralModelNumber_A8539_UIValue;
				string empty;
				int a_2;
				int a_3;
				int a_4;
				string a_5;
				bool result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뚆번\ude8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1108869331;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 1:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊뢌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)1078657299;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄늆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜꾞銠ﲢ鎤銦馨鮪莬", a_), 250, 600, 300);
						num = (short)1877213252;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						num = (short)422117501;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\uda8a즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)96075951;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2724;
					case 4:
						if (UtilityMack.IsPortable())
						{
							num = (short)1571553381;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3603;
					case 5:
						goto IL_22CD;
					case 6:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈삊즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)467599506;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E20;
					case 7:
						num = (short)1192886357;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆번\udf8a쪌\uda8eꢐ쎒슔꾖\ud898햚", a_)))
						{
							num = (short)236453965;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16E5;
					case 9:
						goto IL_1F6B;
					case 10:
						goto IL_6EB;
					case 11:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뎊뢌뾎ꆐ", a_)))
						{
							num = (short)490078462;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A84;
					case 12:
						if (UtilityMack.IsAPX1000i)
						{
							num = (short)1075970205;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3A2E;
					case 13:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뾆불\ud88a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1316094230;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19AD;
					case 14:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄떆번삊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)967508267;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 15:
						num = (short)1195049103;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("톄\udf86쒈뢊붌뾎ꆐ", a_)))
						{
							num = (short)1287782524;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_27CB;
					case 17:
						goto IL_2AB5;
					case 18:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뎆번\udf8a쪌\uda8eꢐ쎒슔꾖\ud898햚", a_)))
						{
							num = (short)1439891601;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1501;
					case 19:
						num = (short)1117520086;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						num = (short)227803299;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						num = (short)235405427;
						num2 = (int)((IntPtr)num);
						continue;
					case 22:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈풊쎌쪎즐잒쪔\ud996힚ﲜﶞ쒠쾢认令", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)1593638981;
						num2 = (int)((IntPtr)num);
						continue;
					case 23:
						num = (short)1403191454;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						num = (short)1226637570;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						goto IL_1F23;
					case 26:
						if (radInfoGeneralModelNumber_A8539_UIValue.Contains(RptMgrErrorHandler.b("늄욆있", a_)))
						{
							num = (short)2122514639;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2151;
					case 27:
						num = (short)1373765919;
						num2 = (int)((IntPtr)num);
						continue;
					case 28:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄펆\uda88릊뢌뾎ꆐ", a_)))
						{
							num = (short)705691916;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3603;
					case 29:
						goto IL_12D8;
					case 30:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ뎜토쒢", a_), 300, 550, 275);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)517144623;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						goto IL_2917;
					case 32:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뚆번펊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1434255410;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 33:
						num = (short)2129789156;
						num2 = (int)((IntPtr)num);
						continue;
					case 34:
						if (UtilityMack.IsPortable())
						{
							num = (short)1886257176;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_346B;
					case 35:
						goto IL_2FCE;
					case 36:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊뢌뾎ꆐ", a_)))
						{
							num = (short)1565655172;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_85B;
					case 37:
						goto IL_A84;
					case 38:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈몊뢌뾎ꆐ", a_)))
						{
							num = (short)232259735;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1930559670;
						num2 = (int)((IntPtr)num);
						continue;
					case 39:
						if (UtilityMack.IsPortable())
						{
							num = (short)883032168;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_30FF;
					case 40:
						goto IL_37A0;
					case 41:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뢊붌뾎ꆐ", a_)))
						{
							num = (short)1394671667;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2AB5;
					case 42:
						num = (short)1297154161;
						num2 = (int)((IntPtr)num);
						continue;
					case 43:
						if (UtilityMack.IsPortable())
						{
							num = (short)462028856;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1628;
					case 44:
						num = (short)1626145051;
						num2 = (int)((IntPtr)num);
						continue;
					case 45:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊뢌뾎ꆐ", a_)))
						{
							num = (short)1958674653;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_13B8;
					case 46:
						goto IL_27CB;
					case 47:
						goto IL_D9B;
					case 48:
						num = (short)956104993;
						num2 = (int)((IntPtr)num);
						continue;
					case 49:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈릊붌뾎ꆐ첒ꆔꞖꦘꮚ슜궞ﺠ쮤좦쮨삮ﶰ튲ힴ튶햸閺ힼ쾾ꛀ", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)755630138;
						num2 = (int)((IntPtr)num);
						continue;
					case 50:
						num = (short)1303904408;
						num2 = (int)((IntPtr)num);
						continue;
					case 51:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뢊붌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 200, 550, 200);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)314966033;
						num2 = (int)((IntPtr)num);
						continue;
					case 52:
						if (UtilityMack.IsPortable())
						{
							num = (short)1196949674;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7D0;
					case 53:
						if (UtilityMack.IsPortable())
						{
							num = (short)1026162770;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D9B;
					case 54:
						goto IL_1921;
					case 55:
						if (UtilityMack.IsPortable())
						{
							num = (short)1470758991;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_35C2;
					case 56:
						num = (short)2085224730;
						num2 = (int)((IntPtr)num);
						continue;
					case 57:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뮈\ude8a캌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)256966745;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1F23;
					case 58:
						goto IL_7D0;
					case 59:
						goto IL_29A1;
					case 60:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)357564716;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2191;
					case 61:
						if (UtilityMack.IsAPX2000APX4000With2Knobs)
						{
							num = (short)488177713;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7D0;
					case 62:
					{
						num = (short)1315504128;
						short num3 = num;
						num = (short)1748631809;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 63:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊뢌뾎ꆐ", a_)))
						{
							num = (short)1818427677;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2C58;
					case 64:
						goto IL_383B;
					case 65:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ude8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)513147075;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_21D1;
					case 66:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈ꮊ쎌쪎즐잒", a_)))
						{
							num = (short)2119893014;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 67:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ", a_)))
						{
							num = (short)785907742;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D9B;
					case 68:
						goto IL_368B;
					case 69:
						goto IL_D5A;
					case 70:
						goto IL_2632;
					case 71:
						goto IL_1459;
					case 72:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ", a_)))
						{
							num = (short)869269665;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_227B;
					case 73:
						num = (short)1741291634;
						num2 = (int)((IntPtr)num);
						continue;
					case 74:
						goto IL_2151;
					case 75:
						if (UtilityMack.IsPortable())
						{
							num = (short)10944631;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1501;
					case 76:
						num = (short)48365742;
						num2 = (int)((IntPtr)num);
						continue;
					case 77:
						goto IL_2102;
					case 78:
						num = (short)662044738;
						num2 = (int)((IntPtr)num);
						continue;
					case 79:
						num = (short)1317339333;
						num2 = (int)((IntPtr)num);
						continue;
					case 80:
						num = (short)2140930143;
						num2 = (int)((IntPtr)num);
						continue;
					case 81:
						goto IL_27CB;
					case 82:
						num = (short)151060547;
						num2 = (int)((IntPtr)num);
						continue;
					case 83:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뺈\udf8a쪌쮎ꢐ쎒슔Ꚗ\ud898햚", a_)))
						{
							num = (short)562102564;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_30FF;
					case 84:
						num = (short)1109393631;
						num2 = (int)((IntPtr)num);
						continue;
					case 85:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\udc8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1814823010;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3A2E;
					case 86:
						num = (short)1247740041;
						num2 = (int)((IntPtr)num);
						continue;
					case 87:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("펄ﮈﾊ", a_)))
						{
							num = (short)303235158;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1595;
					case 88:
						if (UtilityMack.IsPortable())
						{
							num = (short)844103840;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2632;
					case 89:
						num = (short)50790562;
						num2 = (int)((IntPtr)num);
						continue;
					case 90:
						num = (short)1003028679;
						num2 = (int)((IntPtr)num);
						continue;
					case 91:
						goto IL_18E2;
					case 92:
						num = (short)432406722;
						num2 = (int)((IntPtr)num);
						continue;
					case 93:
						num = (short)1994588161;
						if (num != 0)
						{
						}
						if (UtilityMack.IsPortable())
						{
							num = (short)974651634;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3A2E;
					case 94:
						goto IL_34AA;
					case 95:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈몊뢌뾎ꆐ", a_)))
						{
							num = (short)1386938403;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 96:
						num = (short)1551630478;
						num2 = (int)((IntPtr)num);
						continue;
					case 97:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ", a_)))
						{
							num = (short)747569369;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2073296953;
						num2 = (int)((IntPtr)num);
						continue;
					case 98:
						goto IL_21D1;
					case 99:
						num = (short)1611268275;
						num2 = (int)((IntPtr)num);
						continue;
					case 100:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("즄", a_)))
						{
							num = (short)1409876170;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_85B;
					case 101:
						num = (short)243859484;
						num2 = (int)((IntPtr)num);
						continue;
					case 102:
						if (UtilityMack.IsPortable())
						{
							num = (short)404291739;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1921;
					case 103:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뾆불\uda8a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1151729856;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19AD;
					case 104:
						num = (short)1158479955;
						num2 = (int)((IntPtr)num);
						continue;
					case 105:
						goto IL_27CB;
					case 106:
						if (UtilityMack.IsWorldWidePro)
						{
							num = (short)2070544411;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1921;
					case 107:
						num = (short)1146880290;
						num2 = (int)((IntPtr)num);
						continue;
					case 108:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("펄ﮈﾊ", a_)))
						{
							num = (short)569180289;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2151;
					case 109:
						if (UtilityMack.IsPortable())
						{
							num = (short)1370685705;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6EB;
					case 110:
						goto IL_2C2B;
					case 111:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ud88a즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)637796396;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2724;
					case 112:
						num = (short)732299502;
						num2 = (int)((IntPtr)num);
						continue;
					case 113:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뢈\ud88a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1973944468;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3643;
					case 114:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뮈삊즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)721158169;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1398735098;
						num2 = (int)((IntPtr)num);
						continue;
					case 115:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈릊뢌뾎ꆐ", a_)))
						{
							num = (short)508559375;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FCE;
					case 116:
						goto IL_29E1;
					case 117:
						goto IL_2632;
					case 118:
						goto IL_C03;
					case 119:
						num = (short)1075904520;
						num2 = (int)((IntPtr)num);
						continue;
					case 120:
						goto IL_19AD;
					case 121:
						goto IL_227B;
					case 122:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뾆불\ude8a캌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)657195084;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19AD;
					case 123:
						num = (short)1448083564;
						num2 = (int)((IntPtr)num);
						continue;
					case 124:
						goto IL_37A5;
					case 125:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈벊뢌뾎ꆐ", a_)))
						{
							num = (short)629473370;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12D8;
					case 126:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\uda8a즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1782775892;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_21D1;
					case 127:
						num = (short)712900784;
						num2 = (int)((IntPtr)num);
						continue;
					case 128:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄떆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜킞銠ﲢ鞤銦馨鮪莬", a_), 250, 600, 300);
						num = (short)1365180497;
						num2 = (int)((IntPtr)num);
						continue;
					case 129:
						num = (short)1355350042;
						num2 = (int)((IntPtr)num);
						continue;
					case 130:
						if (UtilityMack.IsPortable())
						{
							num = (short)540737802;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_24A0;
					case 131:
						if (UtilityMack.IsMobile())
						{
							num = (short)508428309;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 132:
						num = (short)869400676;
						num2 = (int)((IntPtr)num);
						continue;
					case 133:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ쮒킔", a_)))
						{
							num = (short)228851925;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_227B;
					case 134:
						num = (short)321323227;
						num2 = (int)((IntPtr)num);
						continue;
					case 135:
						goto IL_DDB;
					case 136:
						num = (short)1402601673;
						num2 = (int)((IntPtr)num);
						continue;
					case 137:
						if (radInfoGeneralModelNumber_A8539_UIValue.Contains(RptMgrErrorHandler.b("뎄욆있", a_)))
						{
							num = (short)1289027836;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1595;
					case 138:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)1345781982;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2632;
					case 139:
						num = (short)1591935063;
						num2 = (int)((IntPtr)num);
						continue;
					case 140:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쎄ﮈ삌쪔\ud996힚ﲜﶞ쒠쾢认令", a_), 350, 550, 300);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)890568922;
						num2 = (int)((IntPtr)num);
						continue;
					case 141:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊붌뾎ꆐ쮒\udd94", a_)))
						{
							num = (short)1725432039;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_DDB;
					case 142:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("톄\udf86쒈뢊붌뾎ꆐ", a_)))
						{
							num = (short)2125856848;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FCE;
					case 143:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊뢌뾎ꆐ", a_)))
						{
							num = (short)1245774070;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FCE;
					case 144:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈릊붌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 260, 550, 260);
						num = (short)252182721;
						num2 = (int)((IntPtr)num);
						continue;
					case 145:
						goto IL_16E5;
					case 146:
						num = (short)445776088;
						num2 = (int)((IntPtr)num);
						continue;
					case 147:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄늆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜꾞銠ﲢ邤銦馨鮪莬", a_), 250, 600, 300);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)1405616222;
						num2 = (int)((IntPtr)num);
						continue;
					case 148:
						num = (short)1659633849;
						num2 = (int)((IntPtr)num);
						continue;
					case 149:
						num = (short)570425347;
						num2 = (int)((IntPtr)num);
						continue;
					case 150:
						num = (short)1235157095;
						num2 = (int)((IntPtr)num);
						continue;
					case 151:
						goto IL_2C58;
					case 152:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄떆번펊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)355270727;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_123F;
					case 153:
						if (UtilityMack.IsMobile())
						{
							num = (short)2122055888;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A84;
					case 154:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈풊쎌쪎즐잒쪔\ud996힚ﲜﶞ쒠쾢认춦\ud9a8첪", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)2104492148;
						num2 = (int)((IntPtr)num);
						continue;
					case 155:
						num = (short)395968618;
						num2 = (int)((IntPtr)num);
						continue;
					case 156:
						num = (short)2135425288;
						num2 = (int)((IntPtr)num);
						continue;
					case 157:
						num = (short)1319501889;
						num2 = (int)((IntPtr)num);
						continue;
					case 158:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뢈\ude8a캌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1620115555;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3643;
					case 159:
						if (radInfoGeneralModelNumber_A8539_UIValue.Trim().ToUpper().Contains(RptMgrErrorHandler.b("튄낆", a_)))
						{
							num = (short)1080754469;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뺊붌뾎ꆐ첒\ud894ꖖ욘햚펞삠솢삤쮦螨ﶬ", a_), 350, 550, 275);
						num = (short)174981383;
						num2 = (int)((IntPtr)num);
						continue;
					case 160:
						num = (short)1042808970;
						num2 = (int)((IntPtr)num);
						continue;
					case 161:
						num = (short)1213202565;
						num2 = (int)((IntPtr)num);
						continue;
					case 162:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뮈\uda8a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1622081783;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1F23;
					case 163:
						if (UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)871497931;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E1B;
					case 164:
						if (UtilityMack.IsMobile())
						{
							num = (short)1910374615;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_22CD;
					case 165:
						goto IL_1D36;
					case 166:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊붌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)191430679;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_611;
					case 167:
						if (UtilityMack.IsPortable())
						{
							num = (short)114229387;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1595;
					case 168:
						goto IL_1E20;
					case 169:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뮈\ud88a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1130365001;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1F23;
					case 170:
						num = (short)1951793213;
						num2 = (int)((IntPtr)num);
						continue;
					case 171:
						if (UtilityMack.IsPortable())
						{
							num = (short)339214459;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2151;
					case 172:
						if (UtilityMack.IsMobile())
						{
							num = (short)44105820;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34AA;
					case 173:
						num = (short)1336803334;
						num2 = (int)((IntPtr)num);
						continue;
					case 174:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뾆불\udc8a캌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)650379384;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)468123745;
						num2 = (int)((IntPtr)num);
						continue;
					case 175:
						num = (short)339673199;
						num2 = (int)((IntPtr)num);
						continue;
					case 176:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈삊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1052311559;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_21D1;
					case 177:
						goto IL_1595;
					case 178:
						goto IL_1F6B;
					case 179:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뢈\uda8a즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)203227178;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3643;
					case 180:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ude8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1679556744;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3985;
					case 181:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊뢌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)2162898;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_22CD;
					case 182:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("톄\udf86쒈릊붌뾎ꆐ", a_)))
						{
							num = (short)13828300;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_37A5;
					case 183:
						goto IL_2C2B;
					case 184:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊뢌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)1615134907;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2C58;
					case 185:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄늆뢈삊즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1938686181;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_611;
					case 186:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\udc8a캌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)778436847;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E1B;
					case 187:
						num = (short)1808793638;
						num2 = (int)((IntPtr)num);
						continue;
					case 188:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ\udb92", a_)))
						{
							num = (short)1297285160;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_24A0;
					case 189:
						if (UtilityMack.IsPortable())
						{
							num = (short)780075028;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E1B;
					case 190:
						if (UtilityMack.IsMobile())
						{
							num = (short)1703936002;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12D8;
					case 191:
						goto IL_C03;
					case 192:
						num = (short)1388969997;
						num2 = (int)((IntPtr)num);
						continue;
					case 193:
						goto IL_C03;
					case 194:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뺊뢌뾎ꆐ", a_)))
						{
							num = (short)1532690579;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34AA;
					case 195:
						num = (short)666894462;
						num2 = (int)((IntPtr)num);
						continue;
					case 196:
						if (UtilityMack.IsPortable())
						{
							num = (short)1558118433;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1D36;
					case 197:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뎆낈\udf8a쪌쮎ꢐ쎒슔Ꚗ\ud898햚", a_)))
						{
							num = (short)90505356;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_35C2;
					case 198:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ\udf92ﲔ좖힘톜ﺞ쎠욢즤覦ﮪ", a_), 300, 550, 275);
						num = (short)321126583;
						num2 = (int)((IntPtr)num);
						continue;
					case 199:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(RptMgrErrorHandler.b("즄", a_)))
						{
							num = (short)1706098900;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄늆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜꾞銠ﲢ욦쮨캪솬쪮햰鶲ﾴﺸ", a_), 250, 600, 300);
						num = (short)1839399090;
						num2 = (int)((IntPtr)num);
						continue;
					case 200:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ude8a캌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)1260322965;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2724;
					case 201:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\uda8a즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)2059337790;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3985;
					case 202:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("욄래", a_), 250, 600, 300);
						num = (short)2124611689;
						num2 = (int)((IntPtr)num);
						continue;
					case 203:
						num = (short)851509448;
						num2 = (int)((IntPtr)num);
						continue;
					case 204:
						num = (short)555876368;
						num2 = (int)((IntPtr)num);
						continue;
					case 205:
						num = (short)756220045;
						num2 = (int)((IntPtr)num);
						continue;
					case 206:
						if (UtilityMack.IsPortable())
						{
							num = (short)1015218420;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_123F;
					case 207:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("펄ﮈﾊ캐ꂒ쪔\ud996힚ﲜﶞ쒠쾢认令", a_), 300, 550, 275);
						result = this.a(a_5, empty, a_2, a_3, a_4, !Product.IsVertex());
						num = (short)994443338;
						num2 = (int)((IntPtr)num);
						continue;
					case 208:
						num = (short)483459083;
						num2 = (int)((IntPtr)num);
						continue;
					case 209:
						num = (short)427622400;
						num2 = (int)((IntPtr)num);
						continue;
					case 210:
						goto IL_13B8;
					case 211:
						num = (short)1487798551;
						num2 = (int)((IntPtr)num);
						continue;
					case 212:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("욄래", a_), 250, 600, 300);
						num = (short)1220608009;
						num2 = (int)((IntPtr)num);
						continue;
					case 213:
						num = (short)718930146;
						num2 = (int)((IntPtr)num);
						continue;
					case 214:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\udc8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1893007605;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2191;
					case 215:
						num = (short)1188692013;
						num2 = (int)((IntPtr)num);
						continue;
					case 216:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\udc8a캌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)1356791976;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1628;
					case 217:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 260, 550, 260);
						num = (short)1510998310;
						num2 = (int)((IntPtr)num);
						continue;
					case 218:
						goto IL_35C2;
					case 219:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("톄\udf86쒈릊붌뾎ꆐ", a_)))
						{
							num = (short)1479082080;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FCE;
					case 220:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈릊뢌뾎ꆐ", a_)))
						{
							num = (short)227606656;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)474415167;
						num2 = (int)((IntPtr)num);
						continue;
					case 221:
						num = (short)708116661;
						num2 = (int)((IntPtr)num);
						continue;
					case 222:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ첒ꞔ좖튘ﶞﺠ쪤좨즪좬쎮龰\ud9b2어킶", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)1722220614;
						num2 = (int)((IntPtr)num);
						continue;
					case 223:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ud88a즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)933429375;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_21D1;
					case 224:
						num = (short)59834527;
						num2 = (int)((IntPtr)num);
						continue;
					case 225:
						goto IL_2632;
					case 226:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)359465081;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2917;
					case 227:
						num = (short)53084174;
						num2 = (int)((IntPtr)num);
						continue;
					case 228:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ쮒킔", a_)))
						{
							num = (short)498270504;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1D36;
					case 229:
						goto IL_3643;
					case 230:
						if (UtilityMack.IsPortable())
						{
							num = (short)1506672909;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_29A1;
					case 231:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뾊붌뾎ꆐ쮒\udd94릖煮", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)270860423;
						num2 = (int)((IntPtr)num);
						continue;
					case 232:
						if (UtilityMack.IsPortable())
						{
							num = (short)55902456;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2AB5;
					case 233:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ쮒킔좖힘톜ﺞ쎠욢즤覦ﮪ", a_), 300, 550, 275);
						num = (short)90374425;
						num2 = (int)((IntPtr)num);
						continue;
					case 234:
						goto IL_2632;
					case 235:
						goto IL_27CB;
					case 236:
						goto IL_123F;
					case 237:
						if (UtilityMack.IsPortable())
						{
							num = (short)794886300;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_29E1;
					case 238:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ud88a즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)656801965;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E20;
					case 239:
						goto IL_2724;
					case 240:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ude8a캌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)66125931;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E20;
					case 241:
						if (UtilityMack.IsPortable())
						{
							num = (short)1436614861;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_DDB;
					case 242:
						num = (short)656408588;
						num2 = (int)((IntPtr)num);
						continue;
					case 243:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ쮒킔", a_)))
						{
							num = (short)753336553;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)734789908;
						num2 = (int)((IntPtr)num);
						continue;
					case 244:
						num = (short)1538851065;
						num2 = (int)((IntPtr)num);
						continue;
					case 245:
						goto IL_3985;
					case 246:
						num = (short)299565307;
						num2 = (int)((IntPtr)num);
						continue;
					case 247:
						num = (short)1372848297;
						num2 = (int)((IntPtr)num);
						continue;
					case 248:
						num = (short)980811817;
						num2 = (int)((IntPtr)num);
						continue;
					case 249:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄떆번\ude8a캌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1388118225;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 250:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈릊붌뾎ꆐ", a_)))
						{
							num = (short)473956496;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1595015334;
						num2 = (int)((IntPtr)num);
						continue;
					case 251:
						if (!UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뾊뢌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)584253574;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2FCE;
					case 252:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("펄ﮈﾊ캐ꆒ쪔\ud996힚ﲜﶞ쒠쾢认令", a_), 300, 550, 275);
						result = this.a(a_5, empty, a_2, a_3, a_4, !Product.IsVertex());
						num = (short)166527153;
						num2 = (int)((IntPtr)num);
						continue;
					case 253:
						num = (short)1420296432;
						num2 = (int)((IntPtr)num);
						continue;
					case 254:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄늆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜꾞銠ﲢ鶤銦馨鮪킰톲킴\udbb6\udcb8\udfba鎼햾뇀꓂", a_), 250, 600, 300);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)225640485;
						num2 = (int)((IntPtr)num);
						continue;
					case 255:
						num = (short)1706491964;
						num2 = (int)((IntPtr)num);
						continue;
					case 256:
						if (UtilityMack.IsPortable())
						{
							num = (short)568656131;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2917;
					case 257:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\ud88a즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)679280688;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3985;
					case 258:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ\udb92추튖", a_)))
						{
							num = (short)493551680;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_346B;
					case 259:
						num = (short)1065943112;
						num2 = (int)((IntPtr)num);
						continue;
					case 260:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("횄햆톈릊뾌뾎ꆐ", a_)))
						{
							num = (short)1992556842;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6EB;
					case 261:
						if (UtilityMack.IsPortable())
						{
							num = (short)1143144715;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_18E2;
					case 262:
						goto IL_2632;
					case 263:
						goto IL_20D5;
					case 264:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈ꮊ쎌쪎즐잒떔쾖\udc98", a_)))
						{
							num = (short)1807941786;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_29E1;
					case 265:
						num = (short)255590660;
						num2 = (int)((IntPtr)num);
						continue;
					case 266:
						num = (short)967573692;
						num2 = (int)((IntPtr)num);
						continue;
					case 267:
						num = (short)2228510;
						num2 = (int)((IntPtr)num);
						continue;
					case 268:
						goto IL_8F2;
					case 269:
						num = (short)1730674979;
						num2 = (int)((IntPtr)num);
						continue;
					case 270:
						goto IL_368B;
					case 271:
						goto IL_C03;
					case 272:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈풊쎌뢎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)1020723291;
						num2 = (int)((IntPtr)num);
						continue;
					case 273:
						goto IL_20D5;
					case 274:
						goto IL_27F3;
					case 275:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄늆횈삊\udd8c슎ꂐ첒ꎔꊖꦘꮚ톜辠", a_), 250, 600, 300);
						num = (short)457834766;
						num2 = (int)((IntPtr)num);
						continue;
					case 276:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ\udf92ﲔ", a_)))
						{
							num = (short)1962410182;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈붊붌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 300, 550, 275);
						num = (short)152305774;
						num2 = (int)((IntPtr)num);
						continue;
					case 277:
						if (UtilityMack.IsPortable())
						{
							num = (short)496762958;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 278:
						num = (short)550961274;
						num2 = (int)((IntPtr)num);
						continue;
					case 279:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뚆번삊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)88080611;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 280:
						num = (short)1674510522;
						num2 = (int)((IntPtr)num);
						continue;
					case 281:
						goto IL_2C2B;
					case 282:
						if (UtilityMack.IsAPX1000i)
						{
							num = (short)309657853;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1628;
					case 283:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈삊즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)589627672;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2724;
					case 284:
						goto IL_30FF;
					case 285:
						num = (short)862322872;
						num2 = (int)((IntPtr)num);
						continue;
					case 286:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뒆번\ude8a캌\udb8eꢐ쎒슔꾖\ud898햚", a_)))
						{
							num = (short)1283457296;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_18E2;
					case 287:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뾆불삊즌쮎ꢐ쎒슔ꊖ\ud898햚", a_)))
						{
							num = (short)1939865750;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19AD;
					case 288:
						if (UtilityMack.IsPortable())
						{
							num = (short)1219428607;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2191;
					case 289:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈삊즌즎ꢐ쎒슔ꆖ\ud898햚", a_)))
						{
							num = (short)1085472787;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3985;
					case 290:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Equals(RptMgrErrorHandler.b("춄뺆뮈\uda8a즌잎ꢐ쎒슔ꂖ\ud898햚", a_)))
						{
							num = (short)1082130544;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E20;
					case 291:
						if (UtilityMack.ProductModelId.Equals(RptMgrErrorHandler.b("쒄힆톈뺊붌뾎ꆐ", a_)))
						{
							num = (short)1747648736;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_29A1;
					case 292:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈벊붌뾎ꆐ붒\udf94잖\ude98", a_), 260, 550, 260);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)455147804;
						num2 = (int)((IntPtr)num);
						continue;
					case 293:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뺊붌뾎ꆐ첒\ud894꒖욘햚펞삠솢삤쮦螨ﶬ", a_), 350, 550, 275);
						num = (short)397803793;
						num2 = (int)((IntPtr)num);
						continue;
					case 294:
						goto IL_C03;
					case 295:
						goto IL_C03;
					case 296:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ쮒킔좖힘톜ﺞ쎠욢즤覦쎨\udbaa쪬", a_), 300, 550, 275);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)273416357;
						num2 = (int)((IntPtr)num);
						continue;
					case 297:
						goto IL_1501;
					case 298:
						this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("횄햆톈릊뾌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 250, 450, 275);
						result = this.a(a_5, empty, a_2, a_3, a_4, true);
						num = (short)932184074;
						num2 = (int)((IntPtr)num);
						continue;
					case 299:
						num = (short)1948909600;
						num2 = (int)((IntPtr)num);
						continue;
					case 300:
						num = (short)661586100;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4EC;
					IL_611:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뾊붌뾎ꆐ첒\udb94햘漢ﾜ爵춠趢", a_), 260, 550, 260);
					num = (short)1230504127;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6EB:
					num = (short)419889382;
					num2 = (int)((IntPtr)num);
					continue;
					IL_7D0:
					num = (short)319684896;
					num2 = (int)((IntPtr)num);
					continue;
					IL_85B:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쪄떆횈삊\udd8c슎ꂐ첒\ude94잖풘ꦚ슜ꮞ钠鎢閤覦ﮪ", a_), 250, 600, 300);
					num = (short)1322713323;
					num2 = (int)((IntPtr)num);
					continue;
					IL_A84:
					num = (short)2147352766;
					num2 = (int)((IntPtr)num);
					continue;
					IL_C03:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)639041590;
					num2 = (int)((IntPtr)num);
					continue;
					IL_D5A:
					num = (short)2118385901;
					num2 = (int)((IntPtr)num);
					continue;
					IL_D9B:
					num = (short)2072313986;
					num2 = (int)((IntPtr)num);
					continue;
					IL_DDB:
					num = (short)1966080232;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E1B:
					num = (short)649003101;
					num2 = (int)((IntPtr)num);
					continue;
					IL_123F:
					num = (short)1158611200;
					num2 = (int)((IntPtr)num);
					continue;
					IL_12D8:
					num = (short)963379372;
					num2 = (int)((IntPtr)num);
					continue;
					IL_13B8:
					num = (short)821035009;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1459:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈풊쎌몎ꆐ첒\udb94꒖ꦘ쒚펜슢잤슦얨薪ﾮ", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)829489388;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1501:
					num = (short)1486487813;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1595:
					num = (short)1241645227;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1628:
					num = (short)488964184;
					num2 = (int)((IntPtr)num);
					continue;
					IL_16E5:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈풊쎌쪎즐잒쪔쾖힘쒚펜슢잤슦얨薪ﾮ", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)327483689;
					num2 = (int)((IntPtr)num);
					continue;
					IL_18E2:
					num = (short)255328462;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1921:
					num = (short)1358823476;
					num2 = (int)((IntPtr)num);
					continue;
					IL_19AD:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ첒꒔릖겘쒚펜슢잤슦얨薪ﾮ", a_), 260, 550, 260);
					num = (short)458817807;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1D36:
					num = (short)370081845;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1E20:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ朗쪔꒖욘햚펞삠솢삤쮦螨솪\uddac좮", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)902955270;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1F23:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈릊붌뾎ꆐ첒꒔릖겘쒚펜슢잤슦얨薪ﾮ", a_), 260, 550, 260);
					num = (short)291307815;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1F6B:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)1337196573;
					num2 = (int)((IntPtr)num);
					continue;
					IL_20D5:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)623181883;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2102:
					num = (short)328663058;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2C58:
					num = (short)242856323;
					short num4 = num;
					num = (short)423211395;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2102;
					default:
						num = (short)1005649920;
						if (num != 0)
						{
						}
						num = (short)31064100;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_2151:
					num = (short)1342046263;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2191:
					num = (short)739705021;
					num2 = (int)((IntPtr)num);
					continue;
					IL_21D1:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ朗쪔ꖖ욘햚펞삠솢삤쮦螨솪\uddac좮", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)847446250;
					num2 = (int)((IntPtr)num);
					continue;
					IL_227B:
					num = (short)1116864755;
					num2 = (int)((IntPtr)num);
					continue;
					IL_22CD:
					num = (short)1550057603;
					num2 = (int)((IntPtr)num);
					continue;
					IL_24A0:
					num = (short)947519522;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2632:
					num = (short)1703673860;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2724:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ솒ﺚﺠ邢瘝욨첬춮풰\udfb2鮴\uddb6즸\udcba", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)1251475681;
					num2 = (int)((IntPtr)num);
					continue;
					IL_27CB:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)1616380178;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2917:
					num = (short)363069549;
					num2 = (int)((IntPtr)num);
					continue;
					IL_29A1:
					num = (short)1843331239;
					num2 = (int)((IntPtr)num);
					continue;
					IL_29E1:
					num = (short)137363531;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2AB5:
					num = (short)799998229;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2C2B:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)2064515103;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2FCE:
					num = (short)1187447004;
					num2 = (int)((IntPtr)num);
					continue;
					IL_30FF:
					num = (short)524746854;
					num2 = (int)((IntPtr)num);
					continue;
					IL_346B:
					num = (short)1366949927;
					num2 = (int)((IntPtr)num);
					continue;
					IL_34AA:
					num = (short)445710500;
					num2 = (int)((IntPtr)num);
					continue;
					IL_35C2:
					num = (short)1415446681;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3603:
					num = (short)1595539697;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3643:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뾊붌뾎ꆐ\udf92ﲔ좖ꢘ떚ꢜ삞첢욦쮨캪솬膮ﮰ", a_), 260, 550, 260);
					num = (short)2024865910;
					num2 = (int)((IntPtr)num);
					continue;
					IL_368B:
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)1418330117;
					num2 = (int)((IntPtr)num);
					continue;
					IL_37A5:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("톄\udf86쒈릊붌뾎ꆐ붒\udf94잖\ude98", a_), 250, 600, 300);
					num = (short)1287847982;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3985:
					this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ솒ﺚﺠ醢瘝욨첬춮풰\udfb2鮴\uddb6즸\udcba", a_), 260, 550, 260);
					result = this.a(a_5, empty, a_2, a_3, a_4, true);
					num = (short)1473708149;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3A2E:
					num = (short)1373175851;
					num2 = (int)((IntPtr)num);
				}
				IL_8F2:
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈몊붌뾎ꆐ솒ﺚﺠ邢瘝욨첬춮풰\udfb2鮴\uddb6즸\udcba", a_), 260, 550, 260);
				return this.a(a_5, empty, a_2, a_3, a_4, true);
				IL_27F3:
				return result;
				IL_37A0:
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ\udb92쪔\ud996힚ﲜﶞ쒠쾢认춦\ud9a8첪", a_), 220, 550, 275);
				return this.a(a_5, empty, a_2, a_3, a_4, true);
				IL_383B:
				this.a(ref empty, ref a_2, ref a_3, ref a_4, RptMgrErrorHandler.b("쒄힆톈뎊붌뾎ꆐ\udb92추튖욘햚펞삠솢삤쮦螨솪\uddac좮", a_), 220, 550, 275);
				return this.a(a_5, empty, a_2, a_3, a_4, true);
				IL_4EC:
				a_2 = 200;
				a_3 = 600;
				a_4 = 300;
				result = true;
				a_5 = RptMgrErrorHandler.b("쎄ﲊ\udf8c朗杖\ude96ﶚ놞\ud9a0슢좤쮦", a_);
				empty = string.Empty;
				radInfoGeneralModelNumber_A8539_UIValue = (FeatureManager.GetFeature(2049)[0] as RadioInformation).General.RadInfoGeneralModelNumber_A8539_UIValue;
				num = (short)551485636;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x002AE148 File Offset: 0x002AC348
		private void OnDragUpdateStatus(object A_0, MouseEventArgs A_1)
		{
			short num = (short)346488832;
			short num2 = num;
			num = (short)1091592484;
			short num3 = num;
			num = (short)475291940;
			switch (num3 == num)
			{
			}
			num = (short)223346689;
			if (num != 0)
			{
			}
			num = (short)1213202432;
			if (num != 0)
			{
			}
			this.UpdateStatusBar();
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x002AE1F8 File Offset: 0x002AC3F8
		private void GoToPage(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)508887040;
			short num2 = num;
			num = (short)1125207507;
			short num3 = num;
			num = (short)1777814995;
			switch (num3 == num)
			{
			}
			num = (short)1765736448;
			if (num != 0)
			{
			}
			num = (short)740425729;
			if (num != 0)
			{
			}
			this.usrInpDia = new InputDialog();
			this.usrInpDia.Show();
			this.usrInpDia.txtUserInput.Focus();
			RoutedCommand command = new RoutedCommand();
			CommandBinding commandBinding = new CommandBinding(command, new ExecutedRoutedEventHandler(this.ExecutedCustomCommand), new CanExecuteRoutedEventHandler(this.CanExecuteCustomCommand));
			this.usrInpDia.BtnOk.CommandBindings.Add(commandBinding);
			this.usrInpDia.BtnOk.Command = command;
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x002AE318 File Offset: 0x002AC518
		private void ExecutedCustomCommand(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1742143488;
			short num2 = num;
			num = (short)1699425055;
			short num3 = num;
			num = (short)858991391;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_157:
				num = (short)1288765450;
				num4 = (int)((IntPtr)num);
				break;
			default:
				num = (short)138870784;
				if (num != 0)
				{
				}
				num = (short)946012161;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_EA;
				}
				break;
			}
			int num5;
			bool flag;
			for (;;)
			{
				IL_A4:
				switch (num4)
				{
				case 0:
					if (num5 > 0)
					{
						goto IL_157;
					}
					goto IL_109;
				case 1:
					num = (short)1037959168;
					num4 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_2DD;
				case 3:
					if (num5 != 0)
					{
						num = (short)1828454402;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_173;
				case 4:
					goto IL_31F;
				case 5:
					try
					{
						num = (short)2080243712;
						num4 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1E2;
								}
								continue;
							case 1:
								goto IL_26C;
							case 2:
								MessageBox.Show(AppResources.Value_is_not_a_valid_integer);
								this.usrInpDia.txtUserInput.Focus();
								this.usrInpDia.txtUserInput.Text = "";
								num = (short)774701057;
								num4 = (int)((IntPtr)num);
								continue;
							case 3:
								goto IL_29F;
							}
							IL_1E2:
							if (this.usrInpDia.txtUserInput.Text.Length > 2147483647.ToString().Length - 1)
							{
								num = (short)676331522;
								num4 = (int)((IntPtr)num);
							}
							else
							{
								num5 = int.Parse(this.usrInpDia.txtUserInput.Text);
								num = (short)885391363;
								num4 = (int)((IntPtr)num);
							}
						}
						IL_26C:
						return;
						IL_29F:
						goto IL_3B3;
					}
					catch (FormatException)
					{
						flag = false;
						this.usrInpDia.txtUserInput.Text = "";
						this.usrInpDia.txtUserInput.Focus();
						MessageBox.Show(AppResources.Value_is_not_a_valid_integer);
						goto IL_3B3;
					}
					goto IL_2DD;
					IL_3B3:
					num = (short)2045313037;
					num4 = (int)((IntPtr)num);
					continue;
				case 6:
					if (this.RptViewer.PageCount >= num5)
					{
						num = (short)1779957761;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_109;
				case 7:
					if (num5 <= 0)
					{
						num = (short)672661508;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (this.RptViewer.PageCount >= num5)
					{
						num = (short)1003225102;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31F;
				case 9:
					num = (short)425918476;
					num4 = (int)((IntPtr)num);
					continue;
				case 10:
					goto IL_16E;
				case 11:
					return;
				case 12:
					if (this.usrInpDia.click)
					{
						num = (short)342163471;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_109;
				case 13:
					if (flag)
					{
						num = (short)1802043401;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 14:
					goto IL_173;
				case 15:
					num = (short)1743585286;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_EA;
				IL_109:
				num = (short)1787232259;
				num4 = (int)((IntPtr)num);
				continue;
				IL_173:
				num = (short)344260615;
				num4 = (int)((IntPtr)num);
				continue;
				IL_2DD:
				num = (short)718274568;
				num4 = (int)((IntPtr)num);
				continue;
				IL_31F:
				MessageBox.Show(AppResources.Invalid_page_number);
				this.usrInpDia.txtUserInput.Text = "";
				this.usrInpDia.txtUserInput.Focus();
				num = (short)1010434059;
				num4 = (int)((IntPtr)num);
			}
			IL_16E:
			this.RptViewer.GoToPage(num5);
			this.usrInpDia.txtUserInput.Text = "";
			this.usrInpDia.Hide();
			return;
			IL_EA:
			flag = true;
			num5 = 0;
			num = (short)1212153861;
			num4 = (int)((IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x002AE794 File Offset: 0x002AC994
		private void CanExecuteCustomCommand(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1899626496;
			short num2 = num;
			num = (short)938477552;
			short num3 = num;
			num = (short)1502676976;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1355087872;
				if (num != 0)
				{
				}
				if (!(A_1.Source is Control))
				{
					num = (short)378863617;
					if (num != 0)
					{
					}
					A_1.CanExecute = false;
					return;
				}
				break;
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x002AE85C File Offset: 0x002ACA5C
		private void OnMenuItemClick(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)911867905;
			if (num != 0)
			{
			}
			num = (short)1514864640;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)995971515;
					short num3 = num;
					num = (short)1518227899;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)188940288;
						short num4 = num;
						num = (short)85721088;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					if (A_0 == this.MenuItemFilePrint)
					{
						num = (short)1417805828;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)781254659;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_102;
				case 3:
					if (A_0 == this.MenuItemFileExit)
					{
						num = (short)65667079;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1C8;
				case 4:
					goto IL_13E;
				case 5:
					goto IL_177;
				case 6:
					if (A_0 == this.MenuItemFileSave)
					{
						num = (short)1855717381;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)107610113;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_1BE;
				}
				IL_E5:
				if (A_0 == this.MenuItemFileOpen)
				{
					num = (short)1090846722;
					num2 = (int)((IntPtr)num);
				}
				else
				{
					num = (short)920518662;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_102:
			this.e();
			return;
			IL_13E:
			this.d();
			return;
			IL_177:
			this.a(false);
			return;
			IL_1BE:
			base.Close();
			return;
			IL_1C8:
			MessageBox.Show(AppResources.On_MenuItem_Click_Unsupported_Sender);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x002AEA3C File Offset: 0x002ACC3C
		private void e()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (text == null)
					{
						num2 = (short)1619066881;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)201785347;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					goto IL_C2;
				case 3:
					if (!File.Exists(text))
					{
						num2 = (short)1626669058;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1435041793;
					if (num2 != 0)
					{
					}
					num2 = (short)691535876;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					try
					{
						XPFContent xpfcontent = new XPFContent(Global.contentDir);
						this.RptViewer.Document = xpfcontent.LoadViewableFixedContent(text);
						this.m = text;
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
					goto IL_C2;
				}
				goto IL_24;
				IL_C2:
				num2 = (short)1961503040;
				short num3 = num2;
				num2 = (short)1620453696;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F8;
				}
			}
			return;
			IL_F8:
			num2 = (short)702218240;
			if (num2 != 0)
			{
			}
			MessageBox.Show(AppResources.File_Id_not_found + text, base.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
			IL_24:
			num2 = (short)614596608;
			short num4 = num2;
			text = this.b();
			num2 = (short)1605632000;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x002AEC0C File Offset: 0x002ACE0C
		private void a(bool A_0)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (text == null)
					{
						num2 = (short)139001857;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_4D7;
				case 1:
					return;
				case 2:
					try
					{
						num2 = (short)496631815;
						num = (int)((IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)142934021;
								num = (int)((IntPtr)num2);
								continue;
							case 1:
								if (File.Exists(text))
								{
									num2 = (short)334233614;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_445;
							case 2:
							{
								try
								{
									num2 = (short)1868169218;
									num = (int)((IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_37F;
										case 1:
											goto IL_36B;
										case 2:
										{
											num2 = (short)2008958942;
											short num3 = num2;
											num2 = (short)1158957022;
											switch ((num3 == num2) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_353;
											default:
												num2 = (short)124190720;
												if (num2 != 0)
												{
												}
												switch (0)
												{
												case 0:
													goto IL_32F;
												}
												continue;
											}
											break;
										}
										case 3:
											File.Delete(text);
											goto IL_353;
										}
										IL_32F:
										if (File.Exists(text))
										{
											num2 = (short)849870851;
											num = (int)((IntPtr)num2);
											continue;
										}
										goto IL_36B;
										IL_353:
										num2 = (short)1858011137;
										num = (int)((IntPtr)num2);
										continue;
										IL_36B:
										num2 = (short)3080192;
										num = (int)((IntPtr)num2);
									}
									IL_37F:
									goto IL_1AB;
								}
								catch (Exception)
								{
									MessageBox.Show(AppResources.Access_denied, base.Title);
									return;
								}
								goto IL_39B;
								IL_1AB:
								XpsDocument xpsDocument = new XpsDocument(text, FileAccess.ReadWrite);
								XpsDocument.CreateXpsDocumentWriter(xpsDocument).Write(this.RptViewer.Document.DocumentPaginator);
								xpsDocument.Close();
								MessageBox.Show(AppResources.Saved_successfully, base.Title);
								num2 = (short)760217612;
								num = (int)((IntPtr)num2);
								continue;
							}
							case 3:
								num2 = (short)381812744;
								num = (int)((IntPtr)num2);
								continue;
							case 4:
								goto IL_271;
							case 5:
								if (!text.Equals(Global.flowDocPath + RptMgrErrorHandler.b("\ude89ﺋ쒑ﶓ\udc99힟쮣얥\udda7잩즫삭쒯", a_) + this.n.ToString() + RptMgrErrorHandler.b("ꒉﺍ", a_)))
								{
									num2 = (short)2112749572;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_485;
							case 6:
								if (text.Equals(Global.flowDocPath + RptMgrErrorHandler.b("\ud889憐﶑\udd93ﺗ\uda9b쾟햡즥쮧\udfa9솫쮭\udeaf욱", a_) + this.n.ToString() + RptMgrErrorHandler.b("ꒉﺍ", a_)))
								{
									num2 = (short)1394802697;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_166;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_CD;
								}
								continue;
							case 8:
								if (File.Exists(text))
								{
									num2 = (short)478281728;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_271;
							case 9:
								goto IL_485;
							case 10:
								goto IL_445;
							case 11:
								num2 = (short)1017118726;
								num = (int)((IntPtr)num2);
								continue;
							case 12:
								goto IL_4B0;
							case 13:
								goto IL_4B0;
							case 14:
								goto IL_39B;
							case 15:
								if (File.Exists(text))
								{
									num2 = (short)1359544331;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_166;
							case 16:
								if (!text.Equals(Global.flowDocPath + RptMgrErrorHandler.b("슉\udd91\ude97춡잣펥얧쾩슫\udaad", a_) + this.n.ToString() + RptMgrErrorHandler.b("ꒉﺍ", a_)))
								{
									num2 = (short)1458372618;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_485;
							case 17:
								goto IL_4C8;
							}
							IL_CD:
							if (!this.m.Equals(text))
							{
								num2 = (short)370278403;
								num = (int)((IntPtr)num2);
								continue;
							}
							goto IL_485;
							IL_166:
							num2 = (short)39321601;
							if (num2 != 0)
							{
							}
							num2 = (short)677904386;
							num = (int)((IntPtr)num2);
							continue;
							IL_271:
							num2 = (short)729481217;
							num = (int)((IntPtr)num2);
							continue;
							IL_39B:
							num2 = (short)394395664;
							num = (int)((IntPtr)num2);
							continue;
							IL_445:
							num2 = (short)745406479;
							num = (int)((IntPtr)num2);
							continue;
							IL_485:
							MessageBox.Show(AppResources.Save_File_With_Different_Name, base.Title);
							num2 = (short)1734344717;
							num = (int)((IntPtr)num2);
							continue;
							IL_4B0:
							num2 = (short)1886846993;
							num = (int)((IntPtr)num2);
						}
						IL_4C8:
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
					goto IL_4D7;
				}
				goto IL_25;
				IL_4D7:
				num2 = (short)337903616;
				short num4 = num2;
				num2 = (short)2080505858;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_25:
			text = this.a();
			num2 = (short)1728905216;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x002AF16C File Offset: 0x002AD36C
		private void d()
		{
			short num = (short)1536229376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				string text;
				for (;;)
				{
					IL_28:
					num = (short)481899993;
					short num3 = num;
					num = (short)435238361;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num = (short)897581056;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_1E3;
						case 1:
						{
							if (text == null)
							{
								num = (short)1777270790;
								num2 = (int)((IntPtr)num);
								continue;
							}
							PrintDialog printDialog = new PrintDialog();
							printDialog.PageRangeSelection = PageRangeSelection.AllPages;
							printDialog.UserPageRangeEnabled = true;
							bool? flag = printDialog.ShowDialog();
							bool flag2 = true;
							num = (short)2036662279;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 2:
							text = this.m;
							num = (short)1378156548;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							try
							{
								FixedDocumentSequence fixedDocumentSequence = new XpsDocument(text, FileAccess.Read).GetFixedDocumentSequence();
								PrintDialog printDialog;
								printDialog.PrintDocument(fixedDocumentSequence.DocumentPaginator, this.j.Uri.UserInfo);
								goto IL_244;
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
								goto IL_244;
							}
							goto IL_1E3;
						case 4:
							goto IL_1E3;
						case 5:
							if (this.m != "")
							{
								num = (short)1438121986;
								num2 = (int)((IntPtr)num);
								continue;
							}
							text = Global.usrReportsDirectory.ToString();
							text += this.c();
							num = (short)276889600;
							num2 = (int)((IntPtr)num);
							continue;
						case 6:
							return;
						case 7:
						{
							bool? flag;
							bool flag2;
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)1106509827;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_244;
						}
						}
						goto IL_9A;
						IL_1E3:
						num = (short)799080449;
						if (num != 0)
						{
						}
						num = (short)1148977153;
						num2 = (int)((IntPtr)num);
						break;
					}
				}
				return;
				IL_244:
				num = (short)624033792;
				short num4 = num;
				return;
				IL_9A:
				text = this.m;
				num = (short)2109997061;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x002AF3F8 File Offset: 0x002AD5F8
		private string c()
		{
			int a_ = 14;
			short num = (short)2140585620;
			short num2 = num;
			num = (short)2022751892;
			switch (num2 == num)
			{
			}
			num = (short)936050689;
			if (num != 0)
			{
			}
			num = (short)2113404928;
			short num3 = num;
			num = (short)122421248;
			if (num != 0)
			{
			}
			string text = this.j.Uri.AbsolutePath.ToString();
			int num4 = text.IndexOf(RptMgrErrorHandler.b("쎐낞", a_));
			return text.Remove(0, num4 + 8);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x002AF4DC File Offset: 0x002AD6DC
		private string b()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = AppResources.XPS_Document_files_Filter;
			openFileDialog.FilterIndex = 1;
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = true;
			if (!(flag.GetValueOrDefault() == flag2 & flag != null))
			{
				short num = (short)1555251323;
				short num2 = num;
				num = (short)1249132667;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_37;
				case 1:
					break;
				default:
				{
					num = (short)250675200;
					short num3 = num;
					break;
				}
				}
				num = (short)1749811201;
				if (num != 0)
				{
				}
				num = (short)1125122048;
				if (num != 0)
				{
				}
				return null;
			}
			IL_37:
			return openFileDialog.FileName;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x002AF5C8 File Offset: 0x002AD7C8
		private string a()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			SaveFileDialog saveFileDialog;
			short num2;
			bool? flag;
			bool flag2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!saveFileDialog.FileName.EndsWith(RptMgrErrorHandler.b("벑", a_), true, null))
					{
						num2 = (short)1274740739;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_12D;
				case 1:
					goto IL_16C;
				case 2:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)461242372;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1BF;
				case 3:
				{
					SaveFileDialog saveFileDialog2 = saveFileDialog;
					saveFileDialog2.FileName += RptMgrErrorHandler.b("벑", a_);
					num2 = (short)2102853633;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)1356529664;
					short num3 = num2;
					num2 = (short)1286327927;
					short num4 = num2;
					num2 = (short)784584311;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num2 = (short)258736129;
						if (num2 != 0)
						{
						}
						num2 = (short)455999488;
						if (num2 != 0)
						{
						}
						num2 = (short)537133056;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2D;
			}
			IL_12D:
			return saveFileDialog.FileName;
			IL_16C:
			goto IL_12D;
			IL_1BF:
			return null;
			IL_2D:
			saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = AppResources.XPS_Document_files_Filter;
			saveFileDialog.FilterIndex = 1;
			flag = saveFileDialog.ShowDialog();
			flag2 = true;
			num2 = (short)1722417154;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x002AF798 File Offset: 0x002AD998
		private void Window_Loaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)441562533;
			short num2 = num;
			num = (short)1052685733;
			switch (num2 == num)
			{
			}
			num = (short)1304297473;
			if (num != 0)
			{
			}
			num = (short)320536576;
			short num3 = num;
			num = (short)1280835584;
			if (num != 0)
			{
			}
			base.Dispatcher.UnhandledException += this.Dispatcher_UnhandledException;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x002AF85C File Offset: 0x002ADA5C
		private void Dispatcher_UnhandledException(object A_0, DispatcherUnhandledExceptionEventArgs A_1)
		{
			short num = (short)737607682;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11A;
				case 1:
					goto IL_11A;
				case 2:
					num = (short)1171914753;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 3:
					goto IL_E5;
				}
				IL_5E:
				if (A_1.Exception.GetType() == typeof(PrintSystemException))
				{
					num = (short)1121320963;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)1357381632;
				short num3 = num;
				MessageBox.Show(A_1.Exception.Message);
				num = (short)479133697;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E5:
				MessageBox.Show(AppResources.System_Printing_PrintSystemException + A_1.Exception.Message);
				num = (short)2075066368;
				num2 = (int)((IntPtr)num);
				continue;
				IL_11A:
				num = (short)1517043705;
				short num4 = num;
				num = (short)1581727737;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E5;
				default:
					goto IL_151;
				}
			}
			IL_151:
			num = (short)1251540992;
			if (num != 0)
			{
			}
			A_1.Handled = true;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x002AF9D8 File Offset: 0x002ADBD8
		private void Window_Closing(object A_0, CancelEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_8C;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)260155445;
				short num2 = num;
				num = (short)1853663285;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1176633345;
					if (num != 0)
					{
					}
					num = (short)118030336;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_110;
					case 1:
						if (File.Exists(Global.XMLFileName))
						{
							num = (short)1878720514;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_112;
					case 2:
						goto IL_E0;
					}
					goto IL_8C;
				}
				IL_E0:
				FileAttributes attributes = File.GetAttributes(Global.XMLFileName);
				File.SetAttributes(Global.XMLFileName, attributes & ~FileAttributes.ReadOnly);
				num = (short)1763901440;
				num3 = (int)((IntPtr)num);
			}
			IL_110:
			IL_112:
			num = (short)702349312;
			short num4 = num;
			return;
			IL_8C:
			base.Dispatcher.UnhandledException -= this.Dispatcher_UnhandledException;
			num = (short)1277886465;
			num3 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x002AFB20 File Offset: 0x002ADD20
		private void CustomLastPage_CommandBinding_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1028428776;
			short num2 = num;
			num = (short)1849922536;
			switch (num2 == num)
			{
			}
			num = (short)1128595456;
			if (num != 0)
			{
			}
			num = (short)567934976;
			short num3 = num;
			num = (short)1217265665;
			if (num != 0)
			{
			}
			this.RptViewer.GoToPage(this.RptViewer.PageCount);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x002AFBE0 File Offset: 0x002ADDE0
		private void CustomLastPage_CommandBinding_CanExecute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1309828608;
			short num2 = num;
			num = (short)1063872000;
			switch (num2 == num)
			{
			}
			num = (short)1638858752;
			if (num != 0)
			{
			}
			num = (short)320274432;
			short num3 = num;
			num = (short)987496449;
			if (num != 0)
			{
			}
			A_1.CanExecute = (this.RptViewer.PageCount >= this.RptViewer.MasterPageNumber + this.RptViewer.MaxPagesAcross);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x002AFCB4 File Offset: 0x002ADEB4
		private void CustomNextPage_CommandBinding_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1958138125;
			short num2 = num;
			num = (short)26923277;
			switch (num2 == num)
			{
			}
			num = (short)1459159041;
			if (num != 0)
			{
			}
			num = (short)516816896;
			short num3 = num;
			num = (short)469630976;
			if (num != 0)
			{
			}
			this.RptViewer.GoToPage(this.RptViewer.MasterPageNumber + this.RptViewer.MaxPagesAcross);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x002AFD80 File Offset: 0x002ADF80
		private void CustomNextPage_CommandBinding_CanExecute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)199949316;
			short num2 = num;
			num = (short)1983380484;
			switch (num2 == num)
			{
			}
			num = (short)552337408;
			if (num != 0)
			{
			}
			num = (short)1339424768;
			short num3 = num;
			num = (short)192282625;
			if (num != 0)
			{
			}
			A_1.CanExecute = (this.RptViewer.PageCount >= this.RptViewer.MasterPageNumber + this.RptViewer.MaxPagesAcross);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x002B0298 File Offset: 0x002AE498
		// Note: this type is marked as 'beforefieldinit'.
		static ReportViewer()
		{
			short num = (short)1829079712;
			short num2 = num;
			num = (short)1488685728;
			switch (num2 == num)
			{
			}
			num = (short)452722689;
			if (num != 0)
			{
			}
			num = (short)1344536576;
			short num3 = num;
			num = (short)209649664;
			if (num != 0)
			{
			}
			ReportViewer.CustomLastPage = new RoutedCommand();
			ReportViewer.CustomNextPage = new RoutedCommand();
		}

		// Token: 0x04000E7D RID: 3709
		private XmlDocument a;

		// Token: 0x04000E7E RID: 3710
		private XmlNodeList b;

		// Token: 0x04000E7F RID: 3711
		private XmlNodeList c;

		// Token: 0x04000E80 RID: 3712
		private XmlNodeList d;

		// Token: 0x04000E81 RID: 3713
		private XmlNodeList e;

		// Token: 0x04000E82 RID: 3714
		private XmlNodeList f;

		// Token: 0x04000E83 RID: 3715
		private XmlNodeList g;

		// Token: 0x04000E84 RID: 3716
		private string h;

		// Token: 0x04000E85 RID: 3717
		private FileStream i;

		// Token: 0x04000E86 RID: 3718
		private XpsDocument j;

		// Token: 0x04000E87 RID: 3719
		private XpsDocumentWriter k;

		// Token: 0x04000E88 RID: 3720
		public InputDialog usrInpDia;

		// Token: 0x04000E89 RID: 3721
		private bool l;

		// Token: 0x04000E8A RID: 3722
		private string m;

		// Token: 0x04000E8B RID: 3723
		private int n;

		// Token: 0x04000E8C RID: 3724
		private reportType o;

		// Token: 0x04000E8D RID: 3725
		public static RoutedCommand CustomLastPage;

		// Token: 0x04000E8E RID: 3726
		public static RoutedCommand CustomNextPage;
	}
}
