using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using AcpCommonLib;
using AcpUI;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.ACPXMLCoreEngineLib;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x0200023E RID: 574
	public class AcpReportMgrLib
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x0027F540 File Offset: 0x0027D740
		public static void CleanReportsTempFiles()
		{
			int a_ = 4;
			short num = (short)1868085326;
			short num2 = num;
			num = (short)1930606670;
			switch (num2 == num)
			{
			}
			num = (short)887226369;
			if (num != 0)
			{
			}
			num = (short)395771904;
			if (num != 0)
			{
			}
			num = (short)1031143424;
			short num3 = num;
			global::SpecialFeatures.AcpReportManagerLib.AcpReportMgrLib.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆ﮊﶎ즔ﲘ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궆ꞈꆊ", a_));
			global::SpecialFeatures.AcpReportManagerLib.AcpReportMgrLib.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆ﮊﶎ즔ﲜ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궆ꞈ", a_));
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0027F638 File Offset: 0x0027D838
		private void a(global::SpecialFeatures.AcpReportManagerLib.reportType A_0, string A_1, int A_2, ref bool A_3)
		{
			int a_ = 0;
			short num = (short)7405584;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::SpecialFeatures.AcpReportManagerLib.ReportViewer reportViewer;
				switch (num2)
				{
				case 0:
					reportViewer.Owner = this.b;
					num = (short)207945737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					global::System.IO.File.Delete(A_1);
					num = (short)935591947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					reportViewer.usrInpDia.Close();
					num = (short)566689804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_371;
				case 4:
					if (this.b != null)
					{
						num = (short)102891520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25E;
				case 5:
					global::System.IO.File.SetAttributes(A_1, global::System.IO.FileAttributes.ReadOnly);
					num = (short)200212498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1295646721;
					if (num != 0)
					{
					}
					if (A_3)
					{
						num = (short)1650917383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_371;
				case 7:
					goto IL_DD;
				case 8:
					if (global::System.IO.File.Exists(A_1))
					{
						num = (short)640286725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
				case 9:
					goto IL_25E;
				case 10:
					if (reportViewer.usrInpDia != null)
					{
						num = (short)533004290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 11:
					goto IL_18E;
				case 12:
					goto IL_9E;
				case 13:
					try
					{
						global::System.IO.File.Delete(A_1);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::System.Console.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욂力권ﾒ煮", a_) + A_1 + ex.ToString());
						return;
					}
					goto IL_18E;
				case 14:
				{
					global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(A_1);
					global::System.IO.File.SetAttributes(A_1, attributes & ~global::System.IO.FileAttributes.ReadOnly);
					attributes = global::System.IO.File.GetAttributes(A_1);
					num = (short)2010578961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					if (global::System.IO.File.Exists(A_1))
					{
						num = (short)2120024078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 17:
				{
					global::System.IO.FileAttributes attributes;
					if (attributes.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춂", a_)))
					{
						num = (short)1166016525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 18:
					goto IL_2C2;
				}
				IL_79:
				if (global::System.IO.File.Exists(A_1))
				{
					num = (short)932380673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_18E;
				IL_9E:
				num = (short)1282015247;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DD:
				reportViewer.Show();
				reportViewer.Focus();
				reportViewer.Hide();
				reportViewer.ShowDialog();
				num = (short)128319488;
				short num3 = num;
				num = (short)1436811267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18E:
				num = (short)841410689;
				short num4 = num;
				num = (short)287434881;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_DD;
				default:
					num = (short)518258688;
					if (num != 0)
					{
					}
					reportViewer = new global::SpecialFeatures.AcpReportManagerLib.ReportViewer(A_0, global::SpecialFeatures.AcpReportManagerLib.Global.XMLFileName, A_2, ref A_3);
					reportViewer.RptViewer.Focus();
					num = (short)332464136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_25E:
				num = (short)1335164934;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C2:
				num = (short)819265540;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_371:
				num = (short)339738634;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0027FA54 File Offset: 0x0027DC54
		public void GenerateReport(global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 9;
			short num = (short)279838720;
			switch (num)
			{
			default:
			{
				num = (short)126943240;
				int num2 = (int)((global::System.IntPtr)num);
				int num4;
				string a_2;
				bool flag;
				for (;;)
				{
					int num3;
					global::System.Random random;
					global::AcpUI.AcpUIDialogWindow<string> acpUIDialogWindow;
					switch (num2)
					{
					case 0:
						goto IL_C2;
					case 1:
						if (num3 >= 100)
						{
							num = (short)1804271631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 += random.Next(12345);
						num3++;
						num = (short)2143879171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_138;
					case 3:
						goto IL_4CD;
					case 4:
						if (this.b != null)
						{
							num = (short)1952186382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42A;
					case 5:
						goto IL_4CD;
					case 6:
						return;
					case 7:
						goto IL_42A;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 9:
						try
						{
							global::SpecialFeatures.AcpReportManagerLib.Global.systemTempPath = global::System.IO.Path.GetTempPath();
							goto IL_3DC;
						}
						catch (global::System.Exception ex)
						{
							global::System.Console.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8bﮕ뢗캙\ud99b펝芡삣쾥\udaa7쾩쾫\udaad\udfaf삱춳隵쾷\udbb9쾻麽꺿귁냃껇ꗉ맋ꃍ듏ﳑ裗뛙맛뿝鏟蟡쓣菥蛧駩駫鳭闯틱뇳飵軷鏹軻釽滿漁愃栅簇欉怋⸍昏猑易缕礗砙瀛笝\u001f瘡愣欥砧਩䤫嘭夯䄱䀳", a_) + ex.Message);
							return;
						}
						goto IL_4A7;
						IL_3DC:
						num = (short)297926666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int num5;
						if ((num5 = this.SetGlobalDirectoryAndCheckReportFiles(rptType)) > 0)
						{
							num = (short)1980956684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A7;
					}
					case 11:
						switch (rptType)
						{
						case global::SpecialFeatures.AcpReportManagerLib.reportType.RadioInfo:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOut:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO2:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO3:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO7:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO5:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO9:
						case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutE5:
						{
							int num5;
							global::SpecialFeatures.ACPXMLCoreEngineLib.AcpBaseXMLCoreEngine acpBaseXMLCoreEngine;
							acpBaseXMLCoreEngine.BuildXMLfile(global::SpecialFeatures.AcpReportManagerLib.Global.XMLFileName, ref num5);
							num = (short)2144665616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::SpecialFeatures.AcpReportManagerLib.reportType.Choices:
						{
							global::SpecialFeatures.AcpReportManagerLib.PageCustomPrintSelection pageCustomPrintSelection = new global::SpecialFeatures.AcpReportManagerLib.PageCustomPrintSelection();
							pageCustomPrintSelection.btnPrtCreateTpl.IsEnabled = false;
							pageCustomPrintSelection.btnPrtDelTpl.IsEnabled = false;
							pageCustomPrintSelection.btnPrtEditTpl.IsEnabled = false;
							pageCustomPrintSelection.btnPrtPreview.IsEnabled = false;
							pageCustomPrintSelection.BuildCustomPrintSelection();
							acpUIDialogWindow = new global::AcpUI.AcpUIDialogWindow<string>(pageCustomPrintSelection, null);
							pageCustomPrintSelection.ParenWnd = acpUIDialogWindow;
							acpUIDialogWindow.Width = 500.0;
							acpUIDialogWindow.Height = 400.0;
							acpUIDialogWindow.ResizeMode = global::System.Windows.ResizeMode.NoResize;
							acpUIDialogWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.Manual;
							acpUIDialogWindow.Top = ((double)global::System.Windows.Forms.SystemInformation.MaxWindowTrackSize.Height - acpUIDialogWindow.Height) / 2.0;
							acpUIDialogWindow.Left = ((double)global::System.Windows.Forms.SystemInformation.MaxWindowTrackSize.Width - acpUIDialogWindow.Width) / 2.0;
							acpUIDialogWindow.MaxHeight = acpUIDialogWindow.Height;
							acpUIDialogWindow.MaxWidth = acpUIDialogWindow.Width;
							num = (short)1068826628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)1249312781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 12:
						return;
					case 13:
						goto IL_1D4;
					case 14:
					{
						num = (short)1785307316;
						short num6 = num;
						num = (short)643473588;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D4;
						default:
							num = (short)1682767872;
							if (num != 0)
							{
							}
							acpUIDialogWindow.Owner = this.b;
							num = (short)1227948039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
					{
						string fileNameByRptType = global::SpecialFeatures.AcpReportManagerLib.ReportFileItem.GetFileNameByRptType(rptType);
						a_2 = global::System.IO.Path.Combine(global::SpecialFeatures.AcpReportManagerLib.Global.usrTempDirPath, fileNameByRptType + num4.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊋ", a_));
						global::SpecialFeatures.ACPXMLCoreEngineLib.AcpBaseXMLCoreEngine acpBaseXMLCoreEngine = new global::SpecialFeatures.ACPXMLCoreEngineLib.XMLCoreEngineFactory().MakeXMLCoreObj(rptType);
						num = (short)1352204299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						int num5;
						if (num5 > 0)
						{
							num = (short)806486016;
							short num7 = num;
							num = (short)860225538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41D;
					}
					}
					IL_93:
					if (!global::System.Enum.IsDefined(typeof(global::SpecialFeatures.AcpReportManagerLib.reportType), rptType))
					{
						num = (short)1200619520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num = (short)1301086217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42A:
					acpUIDialogWindow.Show();
					acpUIDialogWindow.Focus();
					acpUIDialogWindow.Hide();
					acpUIDialogWindow.ShowDialog();
					num = (short)557383686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A7:
					num4 = 0;
					random = new global::System.Random();
					num3 = 0;
					num = (short)1935802373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CD:
					num = (short)9437185;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C2:
				throw new global::System.ArgumentException(global::CommonResources.AppResources.Invalid_Report_Type);
				IL_138:
				this.a.DisplayError(4U, global::CommonResources.AppResources.Incomplete_Operation, null);
				return;
				IL_1D4:
				num = (short)1414135809;
				if (num != 0)
				{
				}
				return;
				IL_41D:
				this.a(rptType, a_2, num4, ref flag);
				return;
			}
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0027FFA8 File Offset: 0x0027E1A8
		public global::System.Windows.Window ParentWnd
		{
			set
			{
				short num = (short)444546638;
				short num2 = num;
				num = (short)1489387086;
				switch (num2 == num)
				{
				}
				num = (short)955187200;
				short num3 = num;
				num = (short)499908609;
				if (num != 0)
				{
				}
				num = (short)1437663232;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0028005C File Offset: 0x0027E25C
		internal int SetGlobalDirectoryAndCheckReportFiles(global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 10;
			short num = (short)1691680768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D7;
				}
				bool flag;
				string path;
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<string> list2;
				int result;
				string radInfoGeneralModelNumber_A8539_UIValue;
				for (;;)
				{
					IL_30:
					string text;
					string text2;
					int num5;
					switch (num2)
					{
					case 0:
						if (global::ConstraintHelper.UtilityMack.IsAPX1000With2Knobs)
						{
							num = (short)2136145938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_584;
					case 1:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)1669464090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_584;
					}
					case 2:
						num = (short)1465319440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!text.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐꒒ꂔꞖꦘ", a_)))
						{
							num = (short)1897070621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41E;
					case 4:
						flag = true;
						num = (short)1038221320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1483407398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						path = global::System.IO.Path.Combine(path, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﾐ杖ﮖﲘ爵", a_));
						num = (short)180748313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flag)
						{
							num = (short)1955397647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF6;
					case 8:
						if (!global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1516109829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1204158476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						text = list.Find(delegate(string Result)
						{
							short num7 = (short)389218304;
							short num8 = num7;
							num7 = (short)938914650;
							short num9 = num7;
							num7 = (short)315667290;
							switch (num9 == num7)
							{
							}
							num7 = (short)1378680833;
							if (num7 != 0)
							{
							}
							num7 = (short)1070399488;
							if (num7 != 0)
							{
							}
							return global::ConstraintHelper.UtilityMack.ProductModelId.Equals(Result);
						});
						num = (short)887619611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1434124316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55A;
					case 11:
						num = (short)1139539968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶌﺚ", a_);
						goto IL_84D;
					case 13:
						goto IL_584;
					case 14:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1569849348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 15:
					{
						global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory = global::SpecialFeatures.AcpReportManagerLib.Global.systemTempPath + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8cﲒ잚", a_);
						global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory = global::System.AppDomain.CurrentDomain.BaseDirectory;
						int num3 = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory.IndexOf(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ쾒", a_));
						num = (short)1490944001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (!global::ConstraintHelper.UtilityMack.IsAPX2000APX4000With2Knobs)
						{
							num = (short)1033109515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C6;
					case 17:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)778698774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_584;
					case 18:
					{
						num = (short)528351232;
						short num4 = num;
						goto IL_8C6;
					}
					case 19:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)1964900389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C9;
					case 20:
						global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory.Substring(0, num5);
						num = (short)892862477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_584;
					case 22:
						num = (short)79036448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						text = list2.Find(delegate(string Result)
						{
							short num7 = (short)178651136;
							short num8 = num7;
							num7 = (short)514833920;
							short num9 = num7;
							num7 = (short)1048034816;
							switch (num9 == num7)
							{
							}
							num7 = (short)925892609;
							if (num7 != 0)
							{
							}
							num7 = (short)901971968;
							if (num7 != 0)
							{
							}
							return global::ConstraintHelper.UtilityMack.ProductModelId.Equals(Result);
						});
						num = (short)1863516179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (num5 > 0)
						{
							num = (short)1958608916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_584;
					case 25:
						goto IL_D5A;
					case 26:
					{
						int num3;
						global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory.Substring(0, num3);
						num = (short)99876885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_6C9;
					case 28:
						num = (short)1183973407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1549991969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_55A;
					case 31:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)850919454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 32:
						if (!global::ConstraintHelper.UtilityMack.IsWorldWidePro)
						{
							num = (short)811401218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C6;
					case 33:
						if (text.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꞒꂔꞖꦘ", a_)))
						{
							num = (short)941490211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE5;
					case 34:
						goto IL_D5A;
					case 35:
						goto IL_41E;
					case 36:
						try
						{
							num = (short)1979449354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_BD8;
								case 1:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.usrTempDirPath);
									num = (short)875954179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.usrPrntTemplateDir))
									{
										num = (short)508493836;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CB2;
								case 3:
									goto IL_ADF;
								case 4:
									goto IL_CB2;
								case 5:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.usrDesRptPath);
									num = (short)1183645696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_C1D;
								case 7:
									if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.usrDesRptPath))
									{
										num = (short)290258949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BD8;
								case 8:
									if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.usrDataDirPath))
									{
										num = (short)838533136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B96;
								case 9:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.flowDocPath);
									num = (short)894697478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_9FC;
									}
									continue;
								case 11:
								{
									num = (short)1284965969;
									short num6 = num;
									num = (short)2033452625;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)34537472;
										if (num != 0)
										{
										}
										goto IL_A25;
									}
									break;
								}
								case 12:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.usrPrntTemplateDir);
									num = (short)1485242372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory);
									num = (short)429326347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory))
									{
										num = (short)244514829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A25;
								case 15:
									goto IL_B96;
								case 16:
									global::System.IO.Directory.CreateDirectory(global::SpecialFeatures.AcpReportManagerLib.Global.usrDataDirPath);
									num = (short)847052815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_CCB;
								case 18:
									if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.usrTempDirPath))
									{
										num = (short)122224641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_ADF;
								}
								IL_9FC:
								if (!global::System.IO.Directory.Exists(global::SpecialFeatures.AcpReportManagerLib.Global.flowDocPath))
								{
									num = (short)415301641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_C1D;
								IL_A25:
								num = (short)897384466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ADF:
								num = (short)943652872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B96:
								num = (short)1777598471;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD8:
								num = (short)1566244866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C1D:
								num = (short)823918606;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CB2:
								num = (short)2071527441;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CCB:
							return result;
						}
						catch (global::System.Exception ex)
						{
							global::System.Console.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좌ﶎﲒ랖滛ﺞ햠쪢쮤삦覨쾪쒬\uddae풰킲솴\ud8b6쮸슺鎼", a_) + ex.Message);
							return result;
						}
						goto IL_CF6;
					case 37:
						num = (short)1798111241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("朗璉", a_);
						goto IL_84D;
					case 39:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("소", a_)))
						{
							num = (short)673841158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE5;
					}
					goto IL_D7;
					IL_41E:
					num = (short)1833041959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55A:
					num = (short)707461143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_584:
					global::SpecialFeatures.AcpReportManagerLib.Global.XMLFileName = string.Concat(new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즔", a_),
						rptType.ToString(),
						global::System.IO.Path.GetRandomFileName(),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎌﲐﾒ", a_)
					});
					global::SpecialFeatures.AcpReportManagerLib.Global.usrDesRptPath = global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8cﲒ얘", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.tempPath = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾌﲒ잚爵철펢捻", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.contentDir = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8cﲒ잚삠쒢삤ﮦ", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.flowDocPath = global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("歷ﲐ즔", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.usrDataDirPath = global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즔", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.usrTempDirPath = global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("歷ﲐ", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.usrPrntTemplateDir = global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8cﶎﶒ쎖ﲘ삠힢삤", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.usrLastSavedContainer = new global::System.Collections.Generic.List<string>();
					num = (short)1754267684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C9:
					num = (short)1346895886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_84D:
					path = text2;
					num = (short)1674706945;
					if (num != 0)
					{
					}
					num = (short)88211459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C6:
					global::SpecialFeatures.AcpReportManagerLib.Global.usrReportsDirectory = global::SpecialFeatures.AcpReportManagerLib.Global.systemTempPath + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8cﲒ잚", a_);
					global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory = global::System.AppDomain.CurrentDomain.BaseDirectory;
					num5 = global::SpecialFeatures.AcpReportManagerLib.Global.workingDirectory.IndexOf(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ쾒", a_));
					num = (short)615251992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF6:
					num = (short)59637777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5A:
					num = (short)1123745799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE5:
					path = global::System.IO.Path.Combine(path, text);
					num = (short)684195874;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_D7:
				radInfoGeneralModelNumber_A8539_UIValue = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539_UIValue;
				result = 0;
				list2 = new global::System.Collections.Generic.List<string>
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꂒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꖒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꖒꖔꞖꦘ힚", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꚒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꖒꖔꞖꦘ쎚\ud89c", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8c\udd8e즐ꆒꞔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐꒒ꖔꞖꦘ쎚\ud89c", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐꒒ꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꞒꖔꞖꦘ쎚햜", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꮒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꮒꖔꞖꦘ쎚\ud89c", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8c", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꮒꖔꞖꦘ펚얜\uda9e", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꮒꖔꞖꦘ펚", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꊒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udb8e슐ꆒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94튖솘쾚", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94튖솘쾚붜잞", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94ꂖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94ꊖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94꒖ꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐뎒\udb94튖솘쾚붜잞", a_)
				};
				list = new global::System.Collections.Generic.List<string>
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꮒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐꒒ꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꖒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꖒꂔꞖꦘ힚", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꚒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꆒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98c힎\udc90ꆒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98c힎\udc90ꂒꖔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꞒꂔꞖꦘ", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꞒꂔꞖꦘ힚", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udf8e즐ꊒꂔꞖꦘ", a_)
				};
				flag = false;
				path = string.Empty;
				num = (short)1846018058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00280F6C File Offset: 0x0027F16C
		private static void a(string A_0, string A_1)
		{
			int a_ = 11;
			short num = (short)1477181440;
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
				string text;
				for (;;)
				{
					IL_30:
					int num3;
					string[] array;
					string[] files;
					switch (num2)
					{
					case 0:
						if (global::System.IO.Directory.Exists(text))
						{
							num = (short)1677066244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_F9;
					case 2:
					{
						if (num3 >= array.Length)
						{
							num = (short)593690632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string path = array[num3];
						num = (short)562757638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)989396993;
						if (num != 0)
						{
						}
						if (files.Length != 0)
						{
							num = (short)1036582919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						files = global::System.IO.Directory.GetFiles(text, A_1);
						num = (short)100663299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_F9;
					case 6:
						try
						{
							string path;
							global::System.IO.File.Delete(path);
							goto IL_215;
						}
						catch (global::System.Exception ex)
						{
							global::System.Diagnostics.Trace.WriteLine(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂏ", a_), ex.Message));
							goto IL_215;
						}
						goto IL_DB;
						IL_215:
						num3++;
						num = (short)1842872325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1983662275;
						short num4 = num;
						num = (short)1318865091;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1185021952;
							if (num != 0)
							{
							}
							goto IL_DB;
						}
						break;
					}
					case 8:
						return;
					}
					goto IL_5B;
					IL_DB:
					array = files;
					num3 = 0;
					num = (short)751108097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F9:
					num = (short)1407254528;
					short num5 = num;
					num = (short)1664745474;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5B:
				text = "";
				text = global::SpecialFeatures.AcpReportManagerLib.Global.systemTempPath;
				text += A_0;
				num = (short)1024524288;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000E46 RID: 3654
		private global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler a = new global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler();

		// Token: 0x04000E47 RID: 3655
		private global::System.Windows.Window b;
	}
}
