using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Threading;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.StatusMessage;
using AcpCommonLib.UndoRedo;
using AcpFileHandlerLib;
using AcpSecurityLib;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using Infragistics.Windows.DataPresenter;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.Comms;
using SpecialFeatures.Programming;
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.Security;

namespace SpecialFeatures.CloneWizard
{
	// Token: 0x0200018E RID: 398
	public class PageCloneWizard : global::AcpUI.AcpPageFeature, global::System.ComponentModel.INotifyPropertyChanged, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x001BB01C File Offset: 0x001B921C
		public PageCloneWizard()
		{
			this.InitializeComponent();
			base.PreviewKeyDown += this.PageCloneWizard_PreviewKeyDown;
			base.PreviewMouseDown += this.PageCloneWizard_PreviewMouseDown;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x001BB07C File Offset: 0x001B927C
		private void PageCloneWizard_PreviewMouseDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)152895488;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1010441886;
				short num3 = num;
				num = (short)670703262;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1760100352;
					short num4 = num;
					num = (short)753270784;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 1:
						return;
					case 2:
						A_1.Handled = true;
						goto IL_FA;
					}
					IL_A8:
					if (this.t)
					{
						num = (short)1746206721;
						if (num != 0)
						{
						}
						num = (short)638320642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_FA:
				num = (short)528678913;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x001BB19C File Offset: 0x001B939C
		private void PageCloneWizard_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1179058176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)667274569;
				short num3 = num;
				num = (short)1034145097;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2102132736;
					short num4 = num;
					num = (short)883228672;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 1:
						return;
					case 2:
						A_1.Handled = true;
						goto IL_F7;
					}
					IL_A8:
					if (this.t)
					{
						num = (short)747307009;
						if (num != 0)
						{
						}
						num = (short)2040070146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_F7:
				num = (short)1379598337;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x001BB2BC File Offset: 0x001B94BC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)621150214;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					num = (short)1878392833;
					if (num != 0)
					{
					}
					if (base.Parent is global::System.Windows.Window)
					{
						num = (short)892796939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F4;
				case 1:
					goto IL_79;
				case 2:
				{
					num = (short)1805004170;
					short num3 = num;
					num = (short)694234506;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num = (short)599982080;
						if (num != 0)
						{
						}
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)1939865607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					goto IL_3F4;
				case 4:
					num = (short)830210048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 7:
					goto IL_358;
				case 8:
					if (!this.a)
					{
						num = (short)485687306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 9:
					try
					{
						num = (short)1989083137;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								base.Expanders.Add(acpExpander);
								num = (short)631504899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_232;
								}
								continue;
							case 2:
								num = (short)794034181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1838088194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)166395910;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_2E6;
							case 6:
								if (acpExpander != null)
								{
									num = (short)380502016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_234:
							num = (short)420216836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_232:
							goto IL_234;
						}
						IL_2E6:
						goto IL_E2;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_307;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2F5:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1192755202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_357;
							case 1:
								goto IL_355;
							case 2:
								disposable.Dispose();
								num = (short)1049427969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_307;
						}
						IL_355:
						IL_357:
						goto EndFinally_10;
						IL_307:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1645936640;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2F5;
						EndFinally_10:;
					}
					goto IL_358;
				case 10:
				{
					num = (short)250609664;
					short num4 = num;
					this.i();
					this.a = true;
					this.progressBar2.Value = 0.0;
					global::SpecialFeatures.Comms.Comms.displayOTAP += this.CloneW_DisplayOTAP;
					num = (short)1805844481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					this.r = ((global::System.Windows.Interop.HwndSource)global::System.Windows.PresentationSource.FromVisual(this)).Handle;
					num = (short)586612739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				if (base.Parent != null)
				{
					num = (short)167510020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3F4;
				IL_79:
				global::AcpCommonLib.AppInfoManager.ClonePageNotLoaded = false;
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1121648649;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E2:
				this.MyStackPanel.Children[0].Focus();
				num = (short)1433862146;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_358:
				global::System.Windows.Input.Keyboard.Focus(this);
				num = (short)1879834629;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F4:
				this.b = new global::SpecialFeatures.Clone_Configuration.Common.RadioEjectTimer();
				this.b.Tick += this.OnRadioEjectTimeOut;
				num = (short)172818440;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x001BB730 File Offset: 0x001B9930
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1181337745;
			short num2 = num;
			num = (short)1490798737;
			switch (num2 == num)
			{
			}
			num = (short)1554382849;
			if (num != 0)
			{
			}
			num = (short)677117952;
			if (num != 0)
			{
			}
			num = (short)1008467968;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x001BB7E4 File Offset: 0x001B99E4
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1213246226;
			short num2 = num;
			num = (short)1369418514;
			switch (num2 == num)
			{
			}
			num = (short)54394881;
			if (num != 0)
			{
			}
			num = (short)1787756544;
			if (num != 0)
			{
			}
			num = (short)1366687744;
			short num3 = num;
			A_1.CanExecute = true;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x001BB894 File Offset: 0x001B9A94
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)1445143170;
				short num2 = num;
				num = (short)226501250;
				switch (num2 == num)
				{
				}
				num = (short)595656704;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궍꾕ﮗꮙ꾛ꚝ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1997209600;
			short num3 = num;
			num = (short)1418854401;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x001BB978 File Offset: 0x001B9B78
		private void i()
		{
			short num = (short)1136318396;
			short num2 = num;
			num = (short)1756026812;
			switch (num2 == num)
			{
			}
			num = (short)1782906880;
			if (num != 0)
			{
			}
			num = (short)401670145;
			if (num != 0)
			{
			}
			num = (short)206635008;
			short num3 = num;
			this.ExpMultipleRadio.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			this.a(this.ExpMultipleRadio.DataContext);
			this.TrunkingIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
			this.a(this.TrunkingIDDataPresenter.DataContext);
			this.CnvSysIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2053);
			this.a(this.CnvSysIDDataPresenter.DataContext);
			this.ExpIndAstroOtarRadioIDList.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			this.a(this.ExpIndAstroOtarRadioIDList.DataContext);
			this.IndAstroOtardRadioIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2055);
			this.a(this.IndAstroOtardRadioIDDataPresenter.DataContext);
			this.DataProfilesDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054);
			this.a(this.DataProfilesDataPresenter.DataContext);
			this.ExpDataWide.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066];
			this.a(this.ExpDataWide.DataContext);
			this.ExpUserInfo.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045);
			this.a(this.ExpUserInfo.DataContext);
			this.ExpBluetooth.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630];
			this.a(this.ExpBluetooth.DataContext);
			this.ExpFileClone.DataContext = this;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			this.u = radioInformation.General.RadInfoGeneralSerialNumber_A9122Value;
			this.SerNum = this.u;
			this.SerialNumberBox.IsAcpEditable = global::SpecialFeatures.Security.RadioAccessValidator.FileCloneSerialNumberEditabilityCheck();
			this.p = global::SpecialFeatures.Security.RadioAccessValidator.CacheCodeplugSecurityFields(out this.i, out this.j, out this.k, out this.l, out this.m, out this.o, out this.n);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x001BBC30 File Offset: 0x001B9E30
		private void a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpCommonLib.IAcpConstraints acpConstraints;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (acpConstraints != null)
					{
						num2 = (short)392888322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_11C;
				case 2:
					acpConstraints.CalculateApplicability();
					acpConstraints.CalculateEditability(true);
					acpConstraints.CalculateVisibility(true);
					num2 = (short)1214447617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_11C:
			return;
			IL_1C:
			acpConstraints = (A_0 as global::AcpCommonLib.IAcpConstraints);
			num2 = (short)624641715;
			short num3 = num2;
			num2 = (short)1254835891;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num2 = (short)1664286720;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)394854401;
			if (num2 != 0)
			{
			}
			num2 = (short)193855488;
			if (num2 != 0)
			{
			}
			num2 = (short)1964113920;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x001BBD5C File Offset: 0x001B9F5C
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
					if (this.a)
					{
						num2 = (short)1228210178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_167;
				case 1:
					goto IL_165;
				case 2:
					num2 = (short)1489829889;
					if (num2 != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)1413808129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_165:
			goto IL_167;
			IL_1C:
			global::AcpCommonLib.AppInfoManager.ClonePageNotLoaded = true;
			this.CloneRadiobutton.IsEnabled = true;
			this.ReadRadioIDsbutton.IsEnabled = true;
			this.FileCloneEnBox.IsEnabled = true;
			global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.r, true);
			global::SpecialFeatures.Comms.Comms.displayOTAP -= this.CloneW_DisplayOTAP;
			this.h();
			num2 = (short)153223319;
			short num3 = num2;
			num2 = (short)1268318359;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_167:
				this.b.Tick -= this.OnRadioEjectTimeOut;
				return;
			case 1:
				break;
			default:
			{
				num2 = (short)1505034240;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)295370752;
			if (num2 != 0)
			{
			}
			num2 = (short)226492416;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x001BBEE8 File Offset: 0x001BA0E8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1053687810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					this.q.Dispose();
					this.q = null;
					num = (short)343080963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)587005952;
					short num3 = num;
					num = (short)1445265412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					return;
				case 4:
					num = (short)1015742465;
					if (num != 0)
					{
					}
					if (this.q != null)
					{
						num = (short)1892417536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_39:
				while (disposing)
				{
					num = (short)696914549;
					short num4 = num;
					num = (short)1589777013;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1557725184;
						if (num != 0)
						{
						}
						num = (short)1805320193;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
				}
				break;
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x001BC054 File Offset: 0x001BA254
		public void Dispose()
		{
			short num = (short)1696530433;
			if (num != 0)
			{
			}
			num = (short)224722249;
			short num2 = num;
			num = (short)2015558985;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1634533376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1436549120;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x001BC10C File Offset: 0x001BA30C
		private void h()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_11E;
				case 2:
					if (radioInformation.General.RadInfoGeneralSerialNumber_A9122Value != this.u)
					{
						num2 = (short)1170866180;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DF;
				case 3:
					global::SpecialFeatures.Security.RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.i, this.j, this.k, this.l, this.m, this.o, this.n);
					num2 = (short)1491468288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)2011263504;
					short num3 = num2;
					num2 = (short)874934800;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
					{
						num2 = (short)90439680;
						if (num2 != 0)
						{
						}
						radioInformation.General.RadInfoGeneralSerialNumber_A9122.SetValue(this.u);
						num2 = (short)225705984;
						short num4 = num2;
						num2 = (short)325779461;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_DF;
				}
				goto IL_28;
				IL_DF:
				num2 = (short)423952385;
				if (num2 != 0)
				{
				}
				num2 = (short)933429249;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11E:
				if (!this.p)
				{
					break;
				}
				num2 = (short)1192755203;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			this.q.ForceClose();
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1714618370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x001BC304 File Offset: 0x001BA504
		public override void SetDataContext()
		{
			short num = (short)1522807212;
			short num2 = num;
			num = (short)77279660;
			switch (num2 == num)
			{
			}
			num = (short)541196288;
			short num3 = num;
			num = (short)1702428673;
			if (num != 0)
			{
			}
			num = (short)1028128768;
			if (num != 0)
			{
			}
			this.ExpMultipleRadio.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			this.TrunkingIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
			this.CnvSysIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2053);
			this.ExpIndAstroOtarRadioIDList.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			this.IndAstroOtardRadioIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2055);
			this.DataProfilesDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054);
			this.ExpDataWide.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066];
			global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = (global::AcpCommonLib.IAcpFeatureSection)this.ExpDataWide.DataContext;
			this.ExpUserInfo.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045);
			this.ExpBluetooth.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630];
			this.ExpFileClone.DataContext = this;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x001BC4C0 File Offset: 0x001BA6C0
		private void OK_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					num2 = (short)1808597000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_513;
				case 2:
					if (this.f == 0)
					{
						num2 = (short)1571028992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_102;
				case 3:
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
					num2 = (short)1856438276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					try
					{
						num2 = (short)550699009;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)603324420;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_16B;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)302514176;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpCommonLib.IAcpField a_ = ((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).General.TrkSysGeneralUnitID_A12651;
								this.a(a_, this.d);
								num2 = (short)264634370;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 4:
								goto IL_1F3;
							}
							IL_16D:
							num2 = (short)1708916739;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_16B:
							goto IL_16D;
						}
						IL_1F3:
						goto IL_55E;
					}
					finally
					{
						num2 = (short)20774913;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)544824031;
								short num3 = num2;
								num2 = (short)1813338847;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20D;
								default:
									num2 = (short)1997012992;
									if (num2 != 0)
									{
									}
									enumerator.Dispose();
									num2 = (short)532742146;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_20D;
							case 2:
								goto IL_2AD;
							}
							goto IL_229;
							IL_20D:
							switch (0)
							{
							case 0:
								IL_229:
								if (enumerator == null)
								{
									goto IL_2AF;
								}
								num2 = (short)1736572928;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
						}
						IL_2AD:
						IL_2AF:;
					}
					goto IL_2B0;
				case 5:
					if (this.d != 0)
					{
						num2 = (short)932446209;
						if (num2 != 0)
						{
						}
						num2 = (short)640417795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55E;
				case 6:
					return;
				case 7:
					try
					{
						num2 = (short)544210948;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								if (this.f != 0)
								{
									num2 = (short)1623064582;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_3EA;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)591069191;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
								num2 = (short)326238209;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								if (this.e != 0)
								{
									num2 = (short)2053242885;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_371;
								}
								continue;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
								global::AcpCommonLib.IAcpField a_ = conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744;
								this.a(a_, this.e);
								num2 = (short)1533018112;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
								global::AcpCommonLib.IAcpField a_ = conventionalSystem.General.CnvSysGeneralIndividualID_A8287;
								this.a(a_, this.f);
								num2 = (short)1907294216;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 7:
								num2 = (short)1996947465;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 8:
								goto IL_3EA;
							case 9:
								goto IL_4A7;
							}
							goto IL_371;
							IL_3EA:
							num2 = (short)148701187;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_455:
							num2 = (short)84148226;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_371:
							goto IL_455;
						}
						IL_4A7:
						goto IL_2B0;
					}
					finally
					{
						num2 = (short)2101608449;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1132920834;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_4DD;
								}
								continue;
							case 2:
								goto IL_510;
							}
							IL_4DD:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)292552704;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_510:;
					}
					goto IL_513;
				case 8:
					if (this.e != 0)
					{
						num2 = (short)997130250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B0;
				case 9:
					if (this.g != 0)
					{
						num2 = (short)1606877185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					goto IL_102;
				}
				goto IL_3C;
				IL_102:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
				num2 = (short)274464775;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B0:
				num2 = (short)416546825;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_513:
				this.g();
				num2 = (short)1962934272;
				short num4 = num2;
				num2 = (short)381353990;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_55E:
				num2 = (short)995950594;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			int.TryParse(this.TrkSysUnitIDIncrement.Text, out this.d);
			int.TryParse(this.CnvSysAstroIDIncrement.Text, out this.f);
			int.TryParse(this.CnvSysMdcIDIncrement.Text, out this.e);
			int.TryParse(this.IndAstroOtarRadioIDIncrement.Text, out this.g);
			num2 = (short)1199767557;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x001BCADC File Offset: 0x001BACDC
		private void g()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset feature;
			for (;;)
			{
				IL_0A:
				global::AcpBusinessLayer.AcpSimpleRangeField secWideASTROOTARIndividualASTROOTARRadioID_A;
				int num3;
				switch (num)
				{
				case 0:
					num2 = (short)1738801159;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					for (;;)
					{
						secWideASTROOTARIndividualASTROOTARRadioID_A = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284;
						num3 = secWideASTROOTARIndividualASTROOTARRadioID_A.Value + this.g;
						num2 = (short)1652354277;
						short num4 = num2;
						num2 = (short)377285861;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_131;
						}
					}
					IL_131:
					num2 = (short)1114963968;
					if (num2 != 0)
					{
					}
					num2 = (short)1428029440;
					short num5 = num2;
					num2 = (short)301924357;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1C7;
				case 3:
					goto IL_73;
				case 4:
					if (feature != null)
					{
						num2 = (short)49283073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20D;
				case 5:
					if (num3 <= secWideASTROOTARIndividualASTROOTARRadioID_A.Max)
					{
						num2 = (short)2001534976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B4;
				case 6:
				{
					bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					secWideASTROOTARIndividualASTROOTARRadioID_A.Value = num3;
					if (flag)
					{
						num2 = (short)806813704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20D;
				}
				case 7:
					if (secWideASTROOTARIndividualASTROOTARRadioID_A.Value < secWideASTROOTARIndividualASTROOTARRadioID_A.Min)
					{
						num2 = (short)2024210441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_73;
				case 8:
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num2 = (short)1044119554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_B4;
				}
				goto IL_38;
				IL_73:
				num2 = (short)1174667270;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_B4:
				num3 = secWideASTROOTARIndividualASTROOTARRadioID_A.Min - 1;
				num2 = (short)787087363;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C7:
			IL_20D:
			num2 = (short)696647681;
			if (num2 != 0)
			{
			}
			return;
			IL_38:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			num2 = (short)1905459204;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x001BCD20 File Offset: 0x001BAF20
		private void a(global::AcpCommonLib.IAcpField A_0, int A_1)
		{
			short num = (short)465633292;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1511653377;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpRangeField acpRangeField;
				int num4;
				switch (num2)
				{
				case 0:
					if (acpRangeField != null)
					{
						num = (short)80609282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A3;
				case 1:
				{
					num = (short)1994784768;
					short num3 = num;
					if (((global::AcpBusinessLayer.AcpField<int>)A_0).Value < acpRangeField.Min)
					{
						goto IL_281;
					}
					goto IL_1A3;
				}
				case 2:
					num = (short)1097990154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					((global::AcpBusinessLayer.AcpField<int>)A_0).Value = num4;
					if (flag)
					{
						num = (short)1659109383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					if (A_0.Applicable)
					{
						num = (short)1152122896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)595132425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)501474439;
					short num5 = num;
					num = (short)26731655;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_281;
					default:
						num = (short)508493824;
						if (num != 0)
						{
						}
						num = (short)501415940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num = (short)1358757901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1A3;
				case 9:
					if (A_0.Visible)
					{
						num = (short)409927686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (num4 <= acpRangeField.Max)
					{
						num = (short)1142292494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 11:
					goto IL_B5;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					continue;
				case 13:
					return;
				case 14:
					num = (short)213712897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (A_0.Editable)
					{
						num = (short)2025717777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					num = (short)1546125327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num4 = ((global::AcpBusinessLayer.AcpField<int>)A_0).Value + A_1;
					acpRangeField = (A_0 as global::AcpCommonLib.IAcpRangeField);
					num = (short)2008809472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_93:
				if (A_0 != null)
				{
					num = (short)1174994949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B5:
				num4 = acpRangeField.Min - 1;
				num = (short)530317320;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A3:
				num = (short)1778122755;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_281:
				num = (short)1402470411;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x001BD07C File Offset: 0x001BB27C
		private void OnCloneWizardClone(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1003356169;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool? isChecked;
				string empty;
				switch (num2)
				{
				case 0:
					goto IL_162;
				case 1:
					num = (short)1114636294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					goto IL_214;
				case 4:
					goto IL_37D;
				case 5:
					return;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
					{
						num = (short)1065418755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)121110539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_178;
				case 8:
					goto IL_278;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 10:
					if (isChecked.Value)
					{
						num = (short)560267265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.ReadRadioIDsbutton.IsEnabled = false;
					this.CloneRadiobutton.IsEnabled = false;
					this.FileCloneEnBox.IsEnabled = false;
					global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.r, false);
					global::AcpUI.Common.Utility.SaveFieldWithFocus();
					this.f();
					this.PrePackHandler();
					this.t = true;
					this.s = base.Cursor;
					base.Cursor = global::System.Windows.Input.Cursors.Wait;
					new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.e)).Start();
					num = (short)1750728708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					if (this.SerialNumberBox.IsAcpValid)
					{
						new global::AcpUI.AcpLabel();
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)347013132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1813323873;
					short num3 = num;
					num = (short)564863073;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_278;
					default:
						num = (short)616955904;
						if (num != 0)
						{
						}
						num = (short)440860672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					if (radioInformation.General.RadInfoGeneralSerialNumber_A9122Value != this.SerialNumberBox.Text)
					{
						num = (short)1386545166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_178;
				}
				case 13:
				{
					bool flag = this.b(out empty);
					this.ProgText.Content = empty;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					if (radioInformation.General.RadInfoGeneralSerialNumber_A9122Value != this.u)
					{
						radioInformation.General.RadInfoGeneralSerialNumber_A9122.SetValue(this.u);
					}
					if (flag)
					{
						num = (short)969801736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 14:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					radioInformation.General.RadInfoGeneralSerialNumber_A9122.SetValue(this.SerialNumberBox.Text);
					num = (short)552075271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_60:
				if (!global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.OpenValidateDlg((global::System.Windows.Window)base.Parent))
				{
					num = (short)1644494853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				isChecked = this.FileCloneEnBox.IsChecked;
				num = (short)385941514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_178:
				empty = string.Empty;
				this.ProgText.Content = global::CommonResources.AppResources.Saving_Codeplug_;
				num = (short)2053570573;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_278:
				num = (short)1597964288;
				short num4 = num;
				global::SpecialFeatures.Clone_Configuration.Common.DVRSXmlUtil.ExportDVRSAfterClone(this.SerialNumberBox.Text);
				num = (short)1460797442;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_162:
			this.ProgText.Content = global::CommonResources.AppResources.FileClone_Invalid_Serial_Number;
			return;
			IL_214:
			this.ProgText.Content = global::CommonResources.AppResources.Codeplug_has_Invalid_fields_Please_correct_them_and_try_again;
			return;
			IL_37D:
			num = (short)633208833;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x001BD4A0 File Offset: 0x001BB6A0
		private void f()
		{
			short num = (short)876675073;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)121372673;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1755054082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo = enumerator.Current;
								num = (short)202375171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A2;
								}
								continue;
							case 2:
								num = (short)990183430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
								if (!fieldsReportInfo.Field.Valid)
								{
									num = (short)1436483589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
								fieldsReportInfo.Field.ResetToDefault();
								num = (short)1508769796;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_158;
							}
							IL_E4:
							num = (short)1506082816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A2:
							goto IL_E4;
						}
						IL_158:
						return;
					}
					finally
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_16B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
				{
					num = (short)1175846912;
					short num3 = num;
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
					{
						num = (short)935329796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					num = (short)942342146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_16B;
				}
				IL_39:
				if (!global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiHasFields)
				{
					num = (short)1628110851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16B:
				num = (short)1366892582;
				short num4 = num;
				num = (short)344268838;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)673054721;
					if (num != 0)
					{
					}
					num = (short)1087176704;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>.Enumerator enumerator = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Fields).GetEnumerator();
					break;
				}
				}
				num = (short)491847680;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x001BD738 File Offset: 0x001BB938
		internal void PrePackHandler()
		{
			short num = (short)451835734;
			short num2 = num;
			num = (short)440891222;
			switch (num2 == num)
			{
			}
			num = (short)2039873536;
			short num3 = num;
			num = (short)2036596737;
			if (num != 0)
			{
			}
			num = (short)17760256;
			if (num != 0)
			{
			}
			new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().PrePackHandler();
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x001BD7E8 File Offset: 0x001BB9E8
		private void e()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			bool status;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_16E;
				case 1:
					if (!this.h)
					{
						num2 = (short)669974531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16E;
				case 2:
				{
					num2 = (short)1270022144;
					short num3 = num2;
					num2 = (short)838729729;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
					{
						num2 = (short)1534525444;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::SpecialFeatures.Comms.Comms.updateStatus += this.CallMainUiProcess;
					num2 = (short)1461714945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_E1;
				case 4:
					goto IL_B7;
				case 5:
					try
					{
						status = this.d();
						goto IL_1D8;
					}
					catch (global::System.Exception ex)
					{
						if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
						{
							status = false;
						}
						goto IL_1D8;
					}
					goto IL_E1;
				}
				goto IL_28;
				IL_E1:
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				num2 = (short)744292352;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_16E:
				num2 = (short)721218076;
				short num4 = num2;
				num2 = (short)483650076;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B7;
				default:
					num2 = (short)1803943936;
					if (num2 != 0)
					{
					}
					num2 = (short)1495531525;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_B7:
			this.CallMainUiProcess(0.0, global::CommonResources.AppResources.Codeplug_has_Invalid_fields_Please_correct_them_and_try_again);
			this.CallMainFinish(status);
			return;
			IL_1D8:
			this.CallMainFinish(status);
			global::SpecialFeatures.Comms.Comms.updateStatus -= this.CallMainUiProcess;
			return;
			IL_28:
			status = false;
			num2 = (short)672661506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x001BD9F8 File Offset: 0x001BBBF8
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x001BDAA4 File Offset: 0x001BBCA4
		public string StatusOfClone
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)100270081;
				if (num != 0)
				{
				}
				num = (short)1463960099;
				short num2 = num;
				num = (short)587481635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109196800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880541696;
				if (num != 0)
				{
				}
				return this.x;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)575442242;
				short num2 = num;
				num = (short)150375746;
				switch (num2 == num)
				{
				}
				num = (short)1817837568;
				short num3 = num;
				num = (short)2104557569;
				if (num != 0)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				this.x = value;
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x001BDB58 File Offset: 0x001BBD58
		private void a(double A_0, string A_1)
		{
			short num = (short)31270295;
			short num2 = num;
			num = (short)38348183;
			switch (num2 == num)
			{
			}
			num = (short)2036531200;
			short num3 = num;
			num = (short)1206779904;
			if (num != 0)
			{
			}
			num = (short)4390913;
			if (num != 0)
			{
			}
			this.StatusOfClone = A_1;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x001BDC0C File Offset: 0x001BBE0C
		private bool d()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			string radioSN;
			int num;
			short num2;
			bool flag;
			bool flag2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_2B6;
						}
						for (;;)
						{
							IL_298:
							switch (num)
							{
							case 0:
								goto IL_394;
							case 1:
								base.Dispatcher.Invoke(delegate()
								{
									short num5 = (short)1029234996;
									short num6 = num5;
									num5 = (short)1045881140;
									switch (num6 == num5)
									{
									default:
									{
										num5 = (short)402128896;
										short num7 = num5;
										break;
									}
									case true:
										break;
									}
									num5 = (short)1446379520;
									if (num5 != 0)
									{
									}
									num5 = (short)185794561;
									if (num5 != 0)
									{
									}
									this.SerNum = radioSN;
								});
								num2 = (short)1140719619;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (radioSN.Trim().Length > 0)
								{
									num2 = (short)1798504449;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_37D;
							case 3:
								goto IL_37D;
							case 4:
								if (radioSN != null)
								{
									num2 = (short)121241605;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_37D;
							case 5:
								num2 = (short)579076098;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_2B6;
							IL_37D:
							num2 = (short)902889472;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_394:
						goto IL_116;
						IL_2B6:
						radioSN = global::SpecialFeatures.Comms.ParseDataHelper.RadioSNToString(this.q.GetRadioParams().SerialNumber);
						num2 = (short)1420099588;
						num = (int)((global::System.IntPtr)num2);
						goto IL_298;
					}
					catch
					{
						goto IL_116;
					}
					goto IL_39F;
				case 1:
					if (this.p)
					{
						num2 = (short)1949433865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				case 2:
					goto IL_18F;
				case 3:
					if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍ﾏﾑ煉ﺙ킛캟잡ﮧ", a_)])
					{
						num2 = (short)487325702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				case 4:
					if (flag)
					{
						num2 = (short)2135949312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 5:
					goto IL_153;
				case 6:
				{
					num2 = (short)1314914304;
					short num3 = num2;
					global::SpecialFeatures.Security.RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.i, this.j, this.k, this.l, this.m, this.o, this.n);
					num2 = (short)202375173;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (flag2)
					{
						num2 = (short)323420162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 8:
					num2 = (short)1010761729;
					if (num2 != 0)
					{
					}
					try
					{
						flag = this.q.CloneRadio(this.h, global::SpecialFeatures.Comms.CloneParameters.CloneWriteType, global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState, base.Parent as global::System.Windows.Window, false);
						goto IL_39F;
					}
					catch (global::System.Exception ex)
					{
						if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
						{
							num2 = (short)1640714926;
							short num4 = num2;
							num2 = (short)851137198;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num2 = (short)2122317824;
								if (num2 != 0)
								{
								}
								flag = false;
								flag2 = true;
								break;
							}
						}
						goto IL_39F;
					}
					goto IL_228;
				case 9:
					goto IL_228;
				}
				goto IL_41;
				IL_116:
				num2 = (short)686358529;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_153:
				this.h = false;
				num2 = (short)1402535943;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_228:
				num2 = (short)1278672899;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_39F:
				global::SpecialFeatures.Comms.Comms.updateStatus -= this.a;
				num2 = (short)1878982660;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_18F:
			throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
			IL_41:
			flag = false;
			flag2 = false;
			global::SpecialFeatures.Comms.Comms.updateStatus += this.a;
			num2 = (short)965672968;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x001BE03C File Offset: 0x001BC23C
		private void OnCloneWizardReadIds(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1088608773;
			short num2 = num;
			num = (short)783473157;
			switch (num2 == num)
			{
			}
			num = (short)1310523393;
			if (num != 0)
			{
			}
			num = (short)1630142464;
			short num3 = num;
			num = (short)2055733248;
			if (num != 0)
			{
			}
			this.ReadRadioIDsbutton.IsEnabled = false;
			this.CloneRadiobutton.IsEnabled = false;
			this.FileCloneEnBox.IsEnabled = false;
			global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.r, false);
			global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
			this.SaveRadioIds();
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x001BE124 File Offset: 0x001BC324
		public void SaveRadioIds()
		{
			short num = (short)814828248;
			short num2 = num;
			num = (short)1270237912;
			switch (num2 == num)
			{
			}
			num = (short)2127298561;
			if (num != 0)
			{
			}
			num = (short)477036544;
			short num3 = num;
			num = (short)956235776;
			if (num != 0)
			{
			}
			new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a)).Start();
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x001BE1E8 File Offset: 0x001BC3E8
		public void SaveRadioIdsInCruncher(global::SpecialFeatures.Comms.RadioIdInfo TempRadioIds)
		{
			short num = (short)1346633728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool a_;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							bool radInfoLabtoolH37G50Smartnet_A8184Value;
							bool radInfoLabtoolH38G51Smartzone_A8185Value;
							if (radInfoLabtoolH37G50Smartnet_A8184Value || radInfoLabtoolH38G51Smartzone_A8185Value)
							{
								num = (short)258277378;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_165;
						}
						case 1:
							goto IL_BF;
						case 2:
							a_ = true;
							num = (short)739770369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (radioInformation != null)
							{
								num = (short)2077753348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_165;
						case 4:
						{
							bool radInfoLabtoolH37G50Smartnet_A8184Value = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
							bool radInfoLabtoolH38G51Smartzone_A8185Value = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value;
							num = (short)2027749376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_43;
					}
					IL_BF:
					num = (short)1561460736;
					short num3 = num;
					num = (short)650969089;
					if (num != 0)
					{
					}
					IL_165:
					num = (short)1900652006;
					short num4 = num;
					num = (short)415278566;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73;
					default:
						num = (short)80609280;
						if (num != 0)
						{
						}
						this.a(TempRadioIds, a_);
						global::SpecialFeatures.Comms.Comms.updateStatus -= this.CallMainUiProcess;
						return;
					}
					break;
				}
				}
				IL_43:
				this.h = false;
				global::SpecialFeatures.Comms.Comms.updateStatus += this.CallMainUiProcess;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				a_ = false;
				IL_73:
				num = (short)1725235203;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x001BE3C0 File Offset: 0x001BC5C0
		private void a(global::SpecialFeatures.Comms.RadioIdInfo A_0, bool A_1)
		{
			int a_ = 3;
			short num = (short)1850540032;
			switch (num)
			{
			default:
			{
				num = (short)1256652820;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					switch (num2)
					{
					case 0:
						if (A_0.AstroOtarRadioIds != null)
						{
							num = (short)750387242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161C;
					case 1:
						goto IL_161C;
					case 2:
						try
						{
							num = (short)937361412;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1299513345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
									string referenceKey = conventionalSystem.ReferenceKey;
									global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2 = A_0.CnvSysIds.GetEnumerator();
									num = (short)1350828035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1368915970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6EE;
								case 3:
									try
									{
										num = (short)392298502;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_66C;
											case 1:
												goto IL_686;
											case 2:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
												string cnvSysGeneralSystemType_A13262_UIValue = conventionalSystem.General.CnvSysGeneralSystemType_A13262_UIValue;
												num = (short)1975582727;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
											{
												global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)604045312;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair = enumerator2.Current;
												string key = keyValuePair.Key;
												num = (short)72089608;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
												num = (short)1651769349;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_62C;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_4FC;
												}
												continue;
											case 7:
											{
												bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.ASTRO_Id || cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.DVRS_Id)
												{
													global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
													global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair;
													conventionalSystem.General.CnvSysGeneralIndividualID_A8287.Value = keyValuePair.Value[1];
												}
												else if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.MDC_Id)
												{
													global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
													global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair;
													conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744.Value = keyValuePair.Value[1];
												}
												if (flag)
												{
													num = (short)486146052;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_66C;
											}
											case 8:
											{
												string referenceKey;
												string key;
												if (referenceKey.Equals(key.TrimEnd(new char[1])))
												{
													num = (short)829620226;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_62E:
											num = (short)1565917187;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4FC:
											goto IL_62E;
											IL_66C:
											num = (short)1816330241;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_62C:
										IL_686:;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_46F;
									}
									continue;
								}
								IL_696:
								num = (short)1723596800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_46F:
								goto IL_696;
							}
							IL_6EE:
							goto IL_346;
						}
						finally
						{
							num = (short)2140864514;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2014576641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_75D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_725;
									}
									continue;
								}
								IL_725:
								if (enumerator == null)
								{
									break;
								}
								num = (short)975110144;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_75D:;
						}
						goto IL_760;
					case 3:
						goto IL_11F0;
					case 4:
					{
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						int num3;
						string strB = dataProfIP.DataProfName.Substring(0, num3);
						num = (short)1543897119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)830210049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2A2;
					case 7:
						goto IL_D4E;
					case 8:
						if (A_0.DataProfIps != null)
						{
							num = (short)926679053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F0;
					case 9:
					{
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						if (dataProfIP.BTPeerIP != null)
						{
							num = (short)958136347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F0;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
						enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)1427767337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (secureWideRecset != null)
						{
							num = (short)336330786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161C;
					case 12:
					{
						int num4;
						if (num4 != -1)
						{
							num = (short)2021851164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161C;
					}
					case 13:
					{
						global::SpecialFeatures.Comms.DataProfIP[] dataProfIps = A_0.DataProfIps;
						int num5 = 0;
						num = (short)868876294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						A_0.RadioAlias = this.a(A_0.RadioAlias);
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAlias_A8829.SetValue(A_0.RadioAlias);
						num = (short)794558489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
						num = (short)1578827822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_760;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						dataWide.General.DataWideGeneralPeerIPAddress1_A8524.SetValue(dataProfIP.PeerIP.Address);
						dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.SetValue(dataProfIP.SubIP.Address);
						num = (short)2064384032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
						if (trunkingSystemRecset != null)
						{
							num = (short)1706426378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_231;
					}
					case 19:
						if (A_0.SoftIds != null)
						{
							num = (short)1995571238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11AF;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_115;
						}
						continue;
					case 21:
						goto IL_11AF;
					case 22:
						try
						{
							num = (short)1114439684;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
								global::System.Collections.Generic.Dictionary<string, int>.Enumerator enumerator3;
								string referenceKey2;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1374027777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BA8;
								case 1:
									num = (short)49020930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_C41;
								case 3:
									try
									{
										num = (short)1584398345;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_B98;
											case 1:
											{
												bool flag2 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair2;
												secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value = keyValuePair2.Value;
												if (flag2)
												{
													num = (short)1887240199;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_ACA;
											}
											case 2:
												goto IL_B7F;
											case 3:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)1343029250;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair2 = enumerator3.Current;
												string key2 = keyValuePair2.Key;
												num = (short)444661764;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												string key2;
												if (referenceKey2.Equals(key2.TrimEnd(new char[1])))
												{
													num = (short)458096650;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												goto IL_B7D;
											case 6:
											{
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair2;
												int num4 = keyValuePair2.Value;
												num = (short)1879091642;
												short num6 = num;
												num = (short)132295098;
												switch ((num6 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_B98;
												default:
													num = (short)1134952448;
													if (num != 0)
													{
													}
													num = (short)733216773;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
												num = (short)1317339147;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
												{
													num = (short)1107034118;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_B7F;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_9BD;
												}
												continue;
											case 10:
												num = (short)304021505;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												goto IL_ACA;
											}
											IL_9DF:
											num = (short)194314243;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_9BD:
											goto IL_9DF;
											IL_ACA:
											num = (short)629407752;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_B7F:
											num = (short)1723072512;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_B7D:
										IL_B98:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator3).Dispose();
									}
									goto IL_BA8;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_960;
									}
									continue;
								}
								goto IL_960;
								IL_BA8:
								secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
								referenceKey2 = secureKMFProfile.ReferenceKey;
								enumerator3 = A_0.AstroOtarRadioIds.GetEnumerator();
								num = (short)722010115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BEB:
								num = (short)2126446592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_960:
								goto IL_BEB;
							}
							IL_C41:;
						}
						finally
						{
							num = (short)1968177154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1479540737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_CAD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C76;
									}
									continue;
								}
								IL_C76:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1874919424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CAD:;
						}
						goto IL_CB0;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						A_0.BluetoothFriendlyName = this.a(A_0.BluetoothFriendlyName);
						radioWide2.Bluetooth.RadWideBluetoothFriendlyName_A41181.SetValue(A_0.BluetoothFriendlyName);
						num = (short)877527047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_11F0;
					case 25:
						goto IL_1BD;
					case 26:
					{
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						dataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.SetValue(dataProfIP.BTSubIP.Address);
						num = (short)1137967137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						dataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.SetValue(dataProfIP.BTPeerIP.Address);
						num = (short)228786200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = secureWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
						bool flag3 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						int num4;
						secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value = num4;
						num = (short)1465122865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						string strB;
						if (strB == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅ﺉ\ud98d憐", a_))
						{
							num = (short)388366353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
						num = (short)1161625640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_152F;
					case 31:
						goto IL_16D;
					case 32:
					{
						global::SpecialFeatures.Comms.DataProfIP dataProfIP;
						if (dataProfIP.BTSubIP != null)
						{
							num = (short)1801650177;
							if (num != 0)
							{
							}
							num = (short)875692058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D0;
					}
					case 33:
						goto IL_7D0;
					case 34:
						num = (short)1698168844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						if (secureKMFProfileRecset != null)
						{
							num = (short)880279599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB0;
					}
					case 36:
						goto IL_2A2;
					case 37:
					{
						global::SpecialFeatures.Comms.DataProfIP[] dataProfIps;
						int num5;
						if (num5 >= dataProfIps.Length)
						{
							num = (short)1894580227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Comms.DataProfIP dataProfIP = dataProfIps[num5];
						string strB = dataProfIP.DataProfName;
						int num3 = dataProfIP.DataProfName.IndexOf('\0');
						num = (short)819003435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide3 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						string value = this.a(A_0.SoftIds[0]);
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.SetValue(value);
						global::SpecialFeatures.Clone_Configuration.Common.PINPasswordUtil.UpdatePINPasswordFromRadio(A_0);
						value = this.a(A_0.SoftIds[3]);
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306.SetValue(value);
						num = (short)574488597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (A_0.RadioAlias != null)
						{
							num = (short)2129199118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD;
					case 40:
					{
						try
						{
							num = (short)1750597635;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_101D;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
									{
										num = (short)914423817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_113F;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_EF6;
									}
									continue;
								case 4:
								{
									string strB;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.ReferenceKey.CompareTo(strB) == 0)
									{
										num = (short)548274181;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1248526337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_10B0;
								case 7:
									goto IL_1126;
								case 8:
								{
									global::SpecialFeatures.Comms.DataProfIP dataProfIP;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127.SetValue(dataProfIP.BTPeerIP.Address);
									num = (short)1254162432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::SpecialFeatures.Comms.DataProfIP dataProfIP;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.SetValue(dataProfIP.SubIP.Address);
									dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.SetValue(dataProfIP.PeerIP.Address);
									dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.SetValue(dataProfIP.SubAirInterfaceIP.Address);
									num = (short)1552613387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::SpecialFeatures.Comms.DataProfIP dataProfIP;
									if (dataProfIP.BTPeerIP != null)
									{
										num = (short)1038614536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1126;
								}
								case 11:
								{
									global::SpecialFeatures.Comms.DataProfIP dataProfIP;
									if (dataProfIP.BTSubIP != null)
									{
										num = (short)2052128781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10B0;
								}
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1758461959;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1593835524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::SpecialFeatures.Comms.DataProfIP dataProfIP;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.SetValue(dataProfIP.BTSubIP.Address);
									num = (short)1227489286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1022:
								num = (short)1516896268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EF6:
								goto IL_1022;
								IL_10B0:
								num = (short)367788042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1126:
								num = (short)2069823490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_101D:
							IL_113F:
							goto IL_7AC;
						}
						finally
						{
							num = (short)344064001;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11AC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1177;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1585971200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1177:
								if (enumerator == null)
								{
									break;
								}
								num = (short)37683202;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11AC:;
						}
						goto IL_11AF;
						IL_7AC:
						int num5;
						num5++;
						num = (short)6291492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						try
						{
							num = (short)108265475;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)722010116;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
											global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair3;
											string key3;
											switch (num2)
											{
											case 0:
												goto IL_1490;
											case 1:
												num = (short)623378432;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												try
												{
													switch (0)
													{
													case 0:
														goto IL_1361;
													}
													bool flag4;
													for (;;)
													{
														IL_134A:
														switch (num2)
														{
														case 0:
															global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
															num = (short)1684078595;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															goto IL_13FA;
														case 2:
															if (flag4)
															{
																num = (short)2065694720;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_13E1;
														case 3:
															goto IL_13E1;
														}
														goto IL_1361;
														IL_13E1:
														num = (short)450232321;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_13FA:
													goto IL_1285;
													IL_1361:
													global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = true;
													flag4 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.Value = keyValuePair3.Value[1];
													num = (short)572129282;
													num2 = (int)((global::System.IntPtr)num);
													goto IL_134A;
												}
												catch
												{
													goto IL_1285;
												}
												finally
												{
													global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = false;
												}
												goto IL_1417;
											case 3:
												if (!enumerator2.MoveNext())
												{
													num = (short)1536884737;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1417;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_1302;
												}
												continue;
											case 5:
											{
												string referenceKey3;
												if (referenceKey3.Equals(key3.TrimEnd(new char[1])))
												{
													num = (short)1675362306;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_1304:
											num = (short)21233667;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1302:
											goto IL_1304;
											IL_1417:
											keyValuePair3 = enumerator2.Current;
											key3 = keyValuePair3.Key;
											num = (short)458948613;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1490:
										break;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_14A3;
								case 1:
									goto IL_14BB;
								case 2:
									goto IL_14A3;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1248;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)827981826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									string referenceKey3 = trunkingSystem.ReferenceKey;
									global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2 = A_0.TrkSysIds.GetEnumerator();
									num = (short)2050162688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1285:
								num = (short)597950468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1248:
								goto IL_1285;
								IL_14A3:
								num = (short)762642433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_14BB:
							goto IL_231;
						}
						finally
						{
							num = (short)1211629569;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_152C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_14F4;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1356464128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_14F4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1216217090;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_152C:;
						}
						goto Block_20;
					case 42:
					{
						int num4 = -1;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset = global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset;
						num = (short)266141731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)1069154308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D;
					}
					case 44:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
						num = (short)42598418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						if (A_0.CnvSysIds != null)
						{
							num = (short)1519452175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 46:
						if (conventionalSystemRecset != null)
						{
							num = (short)705757200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 47:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1812529174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						if (A_0.BluetoothFriendlyName != null)
						{
							num = (short)1932853271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4E;
					case 49:
					{
						bool flag3;
						if (flag3)
						{
							num = (short)1804730373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161C;
					}
					}
					IL_115:
					num = (short)638779392;
					short num7 = num;
					if (A_0.TrkSysIds != null && A_1)
					{
						num = (short)756285484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231;
					IL_16D:
					num = (short)791347229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD:
					num = (short)361431088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_231:
					num = (short)1163984941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A2:
					num = (short)401473573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_346:
					num = (short)287637504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_760:
					enumerator = conventionalSystemRecset.GetEnumerator();
					num = (short)589692930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D0:
					num = (short)309329929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB0:
					secureWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset);
					num = (short)1220149259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D4E:
					num = (short)1538523144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11AF:
					num = (short)1765277735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F0:
					num = (short)1596850206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161C:
					num = (short)238157843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_20:
					try
					{
						IL_152F:
						num = (short)1252589572;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1611;
							case 1:
								goto IL_15F9;
							case 2:
								this.SerNum = A_0.SerialNumber;
								num = (short)238288897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1488715781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_156E;
								}
								continue;
							case 5:
								if (A_0.SerialNumber.Trim().Length > 0)
								{
									num = (short)2110521346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15F9;
							}
							IL_156E:
							if (A_0.SerialNumber != null)
							{
								num = (short)634454019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_15F9:
							num = (short)972816384;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1611:
						break;
					}
					catch
					{
						break;
					}
					goto IL_161C;
				}
				return;
			}
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x001BFC80 File Offset: 0x001BDE80
		private string a(string A_0)
		{
			short num = (short)1979121665;
			if (num != 0)
			{
			}
			num = (short)323354626;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1085734912;
					short num3 = num;
					int num4;
					if (num4 == 0)
					{
						num = (short)882704389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)549715975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)1118364371;
					short num5 = num;
					num = (short)1282794195;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1330511872;
						if (num != 0)
						{
						}
						int num4 = A_0.IndexOf('\0');
						break;
					}
					}
					num = (short)39649280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 3:
				{
					int num4;
					A_0 = A_0.Substring(0, num4);
					num = (short)1517027332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return A_0;
				case 5:
					A_0 = "";
					num = (short)760479750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return A_0;
				case 7:
				{
					int num4;
					if (num4 > 0)
					{
						num = (short)759758851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return A_0;
				}
				}
				IL_6B:
				if (A_0 == null)
				{
					break;
				}
				num = (short)794492929;
				num2 = (int)((global::System.IntPtr)num);
			}
			return A_0;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x001BFE50 File Offset: 0x001BE050
		internal void CallMainUiProcess(double n, string stat)
		{
			short num = (short)422248448;
			short num2 = num;
			num = (short)944196498;
			short num3 = num;
			num = (short)307710866;
			switch (num3 == num)
			{
			}
			num = (short)134283264;
			if (num != 0)
			{
			}
			num = (short)1600126977;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneWizard.PageCloneWizard.UpdateProgress(this.CloneRadio_updateStatus), n, new object[]
			{
				stat
			});
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x001BFF24 File Offset: 0x001BE124
		internal void CloneRadio_updateStatus(double n, string stat)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_C9;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (stat == global::CommonResources.AppResources.Writing_radio_codeplug_completed)
					{
						num2 = (short)991821845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1877934118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_24B;
				case 2:
					goto IL_208;
				case 3:
					if (stat == global::CommonResources.AppResources.WaitForRadioEject_Id)
					{
						num2 = (short)725549092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)74711081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (stat == global::CommonResources.AppResources.Read_Radio_Verification_Start)
					{
						num2 = (short)33357861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)160235528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_3CB;
				case 6:
					goto IL_16F;
				case 7:
					if (stat == global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version)
					{
						num2 = (short)553517075;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)63766539;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (stat == global::CommonResources.AppResources.Read_Radio_Verification_Complete)
					{
						num2 = (short)1278476314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6FF;
				case 9:
					if (stat == global::CommonResources.AppResources.Reading_radio_codeplug_)
					{
						num2 = (short)300875789;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)634650634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (stat == global::CommonResources.AppResources.ReadRadio_Reading_codeplug_from_radio)
					{
						num2 = (short)551813121;
						if (num2 != 0)
						{
						}
						num2 = (short)712048662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)107806724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (stat == global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio)
					{
						num2 = (short)1908211743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8CD;
				case 12:
					if (stat == global::CommonResources.AppResources.Opening_Port)
					{
						num2 = (short)1287454753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)908066831;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_5B1;
				case 14:
					goto IL_6FA;
				case 15:
					if (stat == global::CommonResources.AppResources.Open_Port_Complete)
					{
						num2 = (short)915537952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1084817438;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (stat == global::CommonResources.AppResources.Reading_radio_codeplug_completed)
					{
						num2 = (short)147587072;
						short num3 = num2;
						num2 = (short)627572778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)780926985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_73E;
				case 18:
					if (this.v)
					{
						num2 = (short)1341849606;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1948975139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_290;
				case 20:
					if (stat == global::CommonResources.AppResources.WriteRadio_Writing_codeplug_to_radio)
					{
						num2 = (short)1379467293;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)96010240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)501678098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_4E4;
				case 23:
					if (stat == global::CommonResources.AppResources.Writing_radio_codeplug)
					{
						num2 = (short)1776615441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)596705300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (stat == global::CommonResources.AppResources.Read_Radio_Info_Complete)
					{
						num2 = (short)757006338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)906690588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (stat == global::CommonResources.AppResources.Password_validation_failed)
					{
						num2 = (short)1494679595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)939786247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					goto IL_376;
				case 27:
					goto IL_1C4;
				case 28:
					if (stat == global::CommonResources.AppResources.ReadRadio_Calling_End_Read_Radio)
					{
						num2 = (short)1867186181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1537802256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
				{
					num2 = (short)502154518;
					short num4 = num2;
					num2 = (short)1579238678;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6FF;
					default:
						goto IL_682;
					}
					break;
				}
				case 30:
					if (stat == global::CommonResources.AppResources.Read_Radio_Info)
					{
						num2 = (short)2016739367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1535049752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					goto IL_7E6;
				case 32:
					goto IL_649;
				case 33:
					goto IL_120;
				case 34:
					if (stat == global::CommonResources.AppResources.Radio_Erase_in_Progress_please_wait)
					{
						num2 = (short)973078555;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)288817177;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					if (!string.IsNullOrEmpty(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage))
					{
						num2 = (short)1017774120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_879;
				case 36:
					goto IL_8C8;
				case 37:
					goto IL_5F5;
				case 38:
					if (stat == global::CommonResources.AppResources.WriteRadio_eject_radio)
					{
						num2 = (short)1983381505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1185677315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					goto IL_792;
				case 40:
					goto IL_477;
				case 41:
					if (stat == global::CommonResources.AppResources.WriteRadio_Close_Port)
					{
						num2 = (short)792723470;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)75235362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					goto IL_54B;
				case 43:
					goto IL_32A;
				}
				goto IL_C9;
				IL_6FF:
				num2 = (short)1120665623;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_120:
			this.ProgText.Content = global::CommonResources.AppResources.Opening_Connection_To_Radio;
			return;
			IL_16F:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_complete_LP_Radio_display_Lng_Not_Supported_By_this_radio;
			return;
			IL_1C4:
			this.ProgText.Content = global::CommonResources.AppResources.Radio_Erasing_please_wait;
			return;
			IL_208:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_info_complete_;
			return;
			IL_24B:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_releasing_radio;
			return;
			IL_290:
			this.ProgText.Content = global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version;
			return;
			IL_32A:
			this.ProgText.Content = global::CommonResources.AppResources.Password_validation_failed_suspension;
			return;
			IL_376:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Verification_Complete;
			return;
			IL_3CB:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_codeplug_complete;
			return;
			IL_477:
			this.ProgText.Content = global::CommonResources.AppResources.Write_Complete + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖄ", a_) + global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage;
			return;
			IL_4E4:
			this.ProgText.Content = global::CommonResources.AppResources.Begin_read_codeplug;
			return;
			IL_54B:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Info_;
			return;
			IL_5B1:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Info_;
			return;
			IL_5F5:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Verification_Start_;
			return;
			IL_649:
			this.ProgText.Content = global::CommonResources.AppResources.Connecting_opened_to_radio;
			return;
			IL_682:
			num2 = (short)1031077888;
			if (num2 != 0)
			{
			}
			this.ProgText.Content = global::CommonResources.AppResources.Begin_write_to_radio;
			return;
			IL_6FA:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_release_complete;
			return;
			IL_73E:
			this.ProgText.Content = global::CommonResources.AppResources.Write_to_radio_in_progress;
			return;
			IL_792:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_info_start_;
			return;
			IL_7E6:
			this.v = true;
			return;
			IL_879:
			this.ProgText.Content = global::CommonResources.AppResources.Write_to_radio_complete;
			return;
			IL_8C8:
			this.b.StartTimer();
			this.c = true;
			return;
			IL_8CD:
			this.ProgText.Content = stat;
			return;
			IL_C9:
			double value = n * 100.0;
			this.progressBar2.Value = value;
			num2 = (short)1744437260;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x001C080C File Offset: 0x001BEA0C
		internal void CallMainFinish(bool status)
		{
			short num = (short)1999372288;
			short num2 = num;
			num = (short)32899073;
			if (num != 0)
			{
			}
			num = (short)636452004;
			short num3 = num;
			num = (short)1891073188;
			switch (num3 == num)
			{
			}
			num = (short)1814298624;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneWizard.PageCloneWizard.MainFinish(this.CloneFinished), status);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x001C08D8 File Offset: 0x001BEAD8
		internal void CloneFinished(bool status)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				bool? isChecked;
				switch (num)
				{
				case 0:
					if (status)
					{
						num2 = (short)2131165194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D4;
				case 1:
				{
					num2 = (short)1770940977;
					short num3 = num2;
					num2 = (short)1362782769;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_170;
					default:
						num2 = (short)216596480;
						if (num2 != 0)
						{
						}
						if (!status)
						{
							num2 = (short)1245315077;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_122;
					}
					break;
				}
				case 2:
				{
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport;
					statusMsgReport.ContainsField(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒕聯ﺙ肟솣풥솧쮩삫躭ﺯ잱\ud9b3풵\uddb7좹鲻쮽낿ꛁꗃ닅귇꫋꿍맏뻑뇓닕", a_));
					num2 = (short)217645059;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_122;
				case 4:
					goto IL_E9;
				case 5:
				{
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport = global::AcpCommonLib.AppInfoManager.StatusMsgReport;
					num2 = (short)1305149448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_249;
				case 7:
					if (isChecked.Value)
					{
						num2 = (short)1709047817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 8:
				{
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport;
					if (!statusMsgReport.ContainsField(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒕聯ﺙ肟솣풥솧쮩삫躭ﺯ잱\ud9b3풵\uddb7좹鲻쮽낿ꛁꗃ닅귇껉", a_)))
					{
						num2 = (short)1732706306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				}
				case 9:
					this.h = false;
					this.q.FileCloneForceClose();
					num2 = (short)224919556;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					byte[] bytes = global::System.Convert.FromBase64String(this.q.GetRadioParams().SerialNumber);
					this.w = global::System.Text.Encoding.ASCII.GetString(bytes);
					global::SpecialFeatures.Clone_Configuration.Common.DVRSXmlUtil.ExportDVRSAfterClone(this.w);
					num2 = (short)1467678726;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_45;
				IL_E9:
				num2 = (short)1246691328;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_170:
				num2 = (short)73072647;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_122:
				this.CloneRadiobutton.IsEnabled = true;
				this.ReadRadioIDsbutton.IsEnabled = true;
				this.FileCloneEnBox.IsEnabled = true;
				global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.r, true);
				this.c = false;
				this.b.Stop();
				isChecked = this.FileCloneEnBox.IsChecked;
				goto IL_170;
			}
			IL_249:
			num2 = (short)1390608384;
			short num4 = num2;
			IL_2D4:
			num2 = (short)435552257;
			if (num2 != 0)
			{
			}
			return;
			IL_45:
			this.t = false;
			base.Cursor = this.s;
			this.v = false;
			global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage = string.Empty;
			num2 = (short)886308865;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x001C0BE0 File Offset: 0x001BEDE0
		internal void CloneW_DisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject)
		{
			short num = (short)4784128;
			short num2 = num;
			num = (short)213075497;
			short num3 = num;
			num = (short)236406313;
			switch (num3 == num)
			{
			}
			num = (short)869072897;
			if (num != 0)
			{
			}
			num = (short)690749440;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneWizard.PageCloneWizard.MainUIDisplayOTAP(this.DisplayOTAP), ProgOp, new object[]
			{
				LastCommsOTAPUserState,
				RadioObject
			});
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x001C0CB8 File Offset: 0x001BEEB8
		internal void DisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject)
		{
			int a_ = 5;
			short num = (short)1657798657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)821058679;
					short num3 = num;
					num = (short)1428380791;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)565575680;
						if (num != 0)
						{
						}
						num = (short)1632763905;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Programming.OTAPProgrammingWindow otapprogrammingWindow = new global::SpecialFeatures.Programming.OTAPProgrammingWindow(ProgOp, LastCommsOTAPUserState);
						global::System.Windows.Window mainWindow = global::System.Windows.Application.Current.MainWindow;
						otapprogrammingWindow.Owner = mainWindow;
						bool? otapDialogResult = otapprogrammingWindow.ShowDialog();
						RadioObject(otapDialogResult, otapprogrammingWindow.OTAPProgrammingLastState, otapprogrammingWindow.PrescenceResult);
						global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잇\ude89춋\ude8d풏ﮑﮙ증솟쮡킣", a_)).Release(1);
						num = (short)307691522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					return;
				}
				IL_39:
				if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇ﲑ\uda95鍊\udd9d", a_)])
				{
					break;
				}
				num = (short)633077760;
				short num4 = num;
				num = (short)1282670592;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x001C0E3C File Offset: 0x001BF03C
		internal void CloneW_DisplayRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn RadioRtn)
		{
			short num = (short)1899429888;
			short num2 = num;
			num = (short)2009736702;
			short num3 = num;
			num = (short)64759294;
			switch (num3 == num)
			{
			}
			num = (short)1099235329;
			if (num != 0)
			{
			}
			num = (short)783613952;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneWizard.PageCloneWizard.WriteRadioQuery(this.DisplayRadioQuery), RadioRtn);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x001C0F00 File Offset: 0x001BF100
		internal void DisplayRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn RadioRtn)
		{
			int a_ = 15;
			short num = (short)197787649;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)761949053;
					short num3 = num;
					num = (short)1585867645;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)162660353;
						if (num != 0)
						{
						}
						num = (short)420675584;
						if (num != 0)
						{
						}
						global::System.Windows.MessageBoxResult radioRtn = global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_You_are_about_to_write_protect_the_attached_radio_Press_OK_write_Cancel_to_abort, global::CommonResources.AppResources.Radio_Write_Protect_Warning, global::System.Windows.MessageBoxButton.OKCancel, global::System.Windows.MessageBoxImage.Exclamation);
						RadioRtn(radioRtn);
						global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삑쮛즟횡솣춧\udea9", a_)).Release(1);
						num = (short)257556482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					return;
				}
				IL_3A:
				if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﮕﮙ瞧쮡쪣쎥睊ﾫ", a_)])
				{
					break;
				}
				num = (short)338558976;
				short num4 = num;
				num = (short)1263337472;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x001C1070 File Offset: 0x001BF270
		private void OnRadioEjectTimeOut(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1034813440;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.r, true);
					this.b.Stop();
					num = (short)2023555074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					num = (short)807993348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2111307777;
					if (num != 0)
					{
					}
					if (this.c)
					{
						num = (short)1543372801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_38:
				if (this.b == null)
				{
					break;
				}
				num = (short)1430629298;
				short num3 = num;
				num = (short)757902258;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1351024640;
					if (num != 0)
					{
					}
					num = (short)1817509888;
					short num4 = num;
					num = (short)1630404611;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x001C11E0 File Offset: 0x001BF3E0
		private bool b(out string A_0)
		{
			int a_ = 3;
			short num = (short)703332352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)154206208;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = null;
				bool flag = false;
				string value = string.Empty;
				A_0 = global::CommonResources.AppResources.FileClone_failed_or_cancelled;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_99;
					}
					for (;;)
					{
						IL_6E:
						switch (num2)
						{
						case 0:
							num = (short)1984167943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1852309507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_32C;
						case 3:
						{
							bool flag2 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
							global::AcpFileHandlerLib.AcpSaveFileDialog acpSaveFileDialog = new global::AcpFileHandlerLib.AcpSaveFileDialog();
							if (global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO))
							{
								acpSaveFileDialog.Filter = global::CommonResources.AppResources.Vertex_Codeplug_Filter;
							}
							else
							{
								acpSaveFileDialog.Filter = global::CommonResources.AppResources.Motorola_Codeplug_Filter;
							}
							acpSaveFileDialog.FileName = this.SerialNumberBox.Text;
							global::AcpFileHandlerLib.AcpFileHeader acpFileHeader = this.b();
							bool? flag3 = acpSaveFileDialog.ShowDialog(acpFileHeader, (global::System.Windows.Window)base.Parent);
							bool flag4 = true;
							if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
							{
								string fileName = acpSaveFileDialog.FileName;
								if (fileName != null)
								{
									radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
									value = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
									if (fileName.EndsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢅ", a_)))
									{
										radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.SetValue(global::AcpCommonLib.AppInfoManager.AppVersion);
										radioInformation.Labtool.RadInfoLabtoolSecurePartitionVersionNumber_A9076.SetValue(global::AcpCommonLib.AppInfoManager.AppVersion);
										acpFileHeader.VersionNumber = global::AcpCommonLib.AppInfoManager.AppVersion;
										flag = ((global::AcpBusinessLayer.AcpDocument)global::AcpCommonLib.FeatureManager.ActiveDocument).FileSaveAs(fileName, acpFileHeader);
									}
									if (flag)
									{
										global::AcpCommonLib.UndoRedo.UndoManager.Reset();
										A_0 = global::CommonResources.AppResources.FileClone_Successful;
									}
								}
							}
							if (flag2)
							{
								num = (short)501022725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32C;
						}
						case 4:
							num = (short)461504513;
							if (num != 0)
							{
							}
							if (this.c())
							{
								num = (short)848101376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0 = global::CommonResources.AppResources.Unable_to_save_Codeplug_Permission_denied;
							num = (short)2120220674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)588425643;
							short num4 = num;
							num = (short)1900325291;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1268645888;
								if (num != 0)
								{
								}
								global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
								num = (short)1145700360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_346;
						case 7:
							if (this.a(ref A_0))
							{
								num = (short)1552547841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32C;
						case 8:
							goto IL_32C;
						}
						goto IL_99;
						IL_32C:
						num = (short)382140422;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_346:
					return flag;
					IL_99:
					global::AcpUI.Common.Utility.SaveFieldWithFocus();
					num = (short)1228931076;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_6E;
				}
				catch (global::System.Exception ex)
				{
					if (value != "")
					{
						radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.SetValue(value);
					}
					A_0 = ex.Message;
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
				}
				return flag;
			}
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x001C1588 File Offset: 0x001BF788
		private bool c()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					result = true;
					num2 = (short)857538560;
					short num3 = num2;
					num2 = (short)956366849;
					if (num2 != 0)
					{
					}
					num2 = (short)435748867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
					{
						num2 = (short)92930052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)446038021;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					if (global::AcpSecurityLib.SecurityManager.CheckIfSpecialKeyIsAttached())
					{
						num2 = (short)2032926720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)845646681;
					short num4 = num2;
					num2 = (short)1025084249;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1562574848;
						if (num2 != 0)
						{
						}
						result = false;
						num2 = (short)583335938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			return result;
			IL_28:
			result = true;
			num2 = (short)1201668097;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x001C170C File Offset: 0x001BF90C
		private global::AcpFileHandlerLib.AcpFileHeader b()
		{
			short num;
			global::AcpFileHandlerLib.AcpFileHeader acpFileHeader;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
				for (;;)
				{
					IL_0A:
					num = (short)710803457;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = radioInformationRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						acpFileHeader.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.ToString();
						acpFileHeader.SerialNumber = radioInformation.General.RadInfoGeneralSerialNumber_A9122.ToString();
						acpFileHeader.FlashCode = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132.ToString();
						acpFileHeader.VersionNumber = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.ToString();
						num = (short)707592194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1733951488;
						short num3 = num;
						if (radioInformationRecset != null)
						{
							num = (short)213450752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpFileHeader;
					}
					case 2:
						goto IL_134;
					}
					goto IL_44;
				}
				IL_134:
				num = (short)692548898;
				short num4 = num;
				num = (short)1067873570;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_169;
				}
				IL_44:
				acpFileHeader = new global::AcpFileHandlerLib.AcpFileHeader();
				radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
				num = (short)768212993;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_169:
			num = (short)280428544;
			if (num != 0)
			{
			}
			return acpFileHeader;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x001C189C File Offset: 0x001BFA9C
		private bool a(ref string A_0)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			bool result;
			string appVersion;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					string radInfoGeneralCodeplugVersion_A7683_UIValue;
					if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length != 0)
					{
						num2 = (short)2108227585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BB;
				}
				case 1:
					num2 = (short)1761542151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					string radInfoGeneralCodeplugVersion_A7683_UIValue = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
					num2 = (short)1336213504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1688829338;
					short num3 = num2;
					num2 = (short)684031386;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num2 = (short)1112080385;
						if (num2 != 0)
						{
						}
						num2 = (short)1427832832;
						if (num2 != 0)
						{
						}
						result = (global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_you_are_about_to_save_a_Release, global::CommonResources.AppResources.Saving_Codeplug_, global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Exclamation) == global::System.Windows.MessageBoxResult.Yes);
						num2 = (short)1728905228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_96;
				case 5:
					if (appVersion.Length != 0)
					{
						num2 = (short)1962934282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 6:
					goto IL_171;
				case 7:
				{
					string radInfoGeneralCodeplugVersion_A7683_UIValue;
					if (radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(0, 1) == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88", a_))
					{
						num2 = (short)749666307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BB;
				}
				case 8:
					if (appVersion.Substring(0, 1) != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88", a_))
					{
						num2 = (short)789250050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 9:
					goto IL_B6;
				case 10:
					num2 = (short)2032533512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					A_0 = global::CommonResources.AppResources.CPS_version_is_not_current;
					num2 = (short)1870331910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_236;
				case 13:
				{
					string radInfoGeneralCodeplugVersion_A7683_UIValue;
					if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length == 0)
					{
						num2 = (short)130154500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 14:
					if (appVersion.Length == 0)
					{
						num2 = (short)1564999691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_55;
				IL_96:
				A_0 = global::CommonResources.AppResources.Unable_to_save_Codeplug_Invalid_or_empty_Codeplug_version;
				result = false;
				num2 = (short)701497353;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_BB:
				num2 = (short)1883045901;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C9:
				num2 = (short)396230670;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B6:
			IL_171:
			return result;
			IL_236:
			num2 = (short)1102708736;
			short num4 = num2;
			return result;
			IL_55:
			result = true;
			appVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
			num2 = (short)645660677;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x001C1BD8 File Offset: 0x001BFDD8
		public bool CommandLineCPSCloneProcedure()
		{
			int a_ = 3;
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85\ud887펏ﺑﮓﶗ춙솟킡삣ﮥ슫좭\udfaf삱\ud9b3ힵ첷펹펻킽鶿駁蛃ꏅ꿇ꏉꋋ鏍诏金믓믕뗗믙닛뫝곟诡諣菥ꯧ뫩뿫귭鳯鷱髳鏵ꣷ裹鏻鷽旿昁焃琅洇圉", a_));
			bool flag = false;
			short num;
			bool result;
			try
			{
				num = (short)1635778562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_170;
					case 1:
						goto IL_B3;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 3:
						goto IL_DE;
					}
					IL_91:
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
					{
						num = (short)807600129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.i();
					this.PrePackHandler();
					global::SpecialFeatures.Comms.Comms.updateStatus += this.CallMainUiProcess;
					flag = this.d();
					this.h();
					num = (short)1741976765;
					short num3 = num;
					num = (short)1429042365;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1840513024;
						if (num != 0)
						{
						}
						num = (short)1003094016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B3:
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85\ud887펏ﺑﮓﶗ춙솟킡삣ﮥ\udeab\udcad\udfaf삱﮷햹톻펽ꆿ곁ꃃ諅ꇇ꓉꧋跍胏臑韓뫕럗듙맛軝鋟跡蟣菥賧鿩黫语귯죱퓳뗵韷黹駻軽泿省挃★怇欉缋⸍夏簑戓眕琗猙砛㸝䘟䬡䄣䨥䰧天+อ猯䀱䄳堵嬷刹夻䰽怿Łࡃॅهཉ汋⅍⁏㝑♓㝕ⱗ㍙㍛そ䁟͡٣॥ᩧṩ५੭", a_));
					result = flag;
					num = (short)455147523;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DE:
				goto IL_1B7;
				IL_170:
				goto IL_20;
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
				}
				global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85\ud887펏ﺑﮓﶗ춙솟킡삣ﮥ풫춭햯슱삳\udfb5ힷ풹莿귁꧃ꯅ꧇꓉꣋苍맏병뇓闕裗觙鿛닝迟賡臣뛥髧藩迫语铯蟱蛳鏵ꗷ샹\udcfb", a_) + ex.Message);
				result = false;
			}
			goto IL_1B7;
			IL_20:
			num = (short)561840129;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85\ud887펏ﺑﮓﶗ춙솟킡삣ﮥ슫좭\udfaf삱\ud9b3ힵ첷펹펻킽鶿駁臃ꣅ곇韉韋跍뿏뿑맓럕뛗뻙郛럝軟蟡꟣뛥믧ꧩ胫臭黯韱ꓳ蓵韷駹駻髽痿瀁愃嬅", a_));
			return flag;
			IL_1B7:
			num = (short)933625856;
			short num4 = num;
			return result;
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x001C1DE4 File Offset: 0x001BFFE4
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x001C1E94 File Offset: 0x001C0094
		public string SerNum
		{
			get
			{
				short num = (short)1534263296;
				short num2 = num;
				num = (short)1782981672;
				short num3 = num;
				num = (short)2010784808;
				switch (num3 == num)
				{
				}
				num = (short)57933824;
				if (num != 0)
				{
				}
				num = (short)420020225;
				if (num != 0)
				{
				}
				return this.y;
			}
			set
			{
				int a_ = 1;
				short num = (short)2030895105;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)625267147;
						short num3 = num;
						num = (short)64672203;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)900988929;
							if (num != 0)
							{
							}
							num = (short)1670709248;
							if (num != 0)
							{
							}
							this.y = value.ToUpper();
							this.FirePropertyChanged(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃慎쒉曆", a_));
							num = (short)1864957954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					case 2:
						return;
					}
					IL_3A:
					if (!(this.y != value))
					{
						break;
					}
					num = (short)156172288;
					short num4 = num;
					num = (short)786759680;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001350 RID: 4944 RVA: 0x001C1FDC File Offset: 0x001C01DC
		// (remove) Token: 0x06001351 RID: 4945 RVA: 0x001C2110 File Offset: 0x001C0310
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_0A:
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)1399455746;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						case 1:
							goto IL_39;
						case 2:
							goto IL_DC;
						}
						goto IL_1C;
						IL_39:
						num2 = (short)174325760;
						short num3 = num2;
						num2 = (short)1367736321;
						if (num2 != 0)
						{
						}
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.z, value2, propertyChangedEventHandler2);
						num2 = (short)1577517056;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_DC:
					num2 = (short)1047507810;
					short num4 = num2;
					num2 = (short)706392930;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_110;
					}
					IL_1C:
					propertyChangedEventHandler = this.z;
					num2 = (short)844169217;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_110:
				num2 = (short)1870200832;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_0A:
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)589299714;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						case 1:
							goto IL_39;
						case 2:
							goto IL_B2;
						}
						goto IL_1C;
						IL_39:
						num2 = (short)299892736;
						short num3 = num2;
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.z, value2, propertyChangedEventHandler2);
						num2 = (short)53411840;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_B2:
					num2 = (short)1851349143;
					short num4 = num2;
					num2 = (short)1612601495;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E8;
					}
					IL_1C:
					propertyChangedEventHandler = this.z;
					num2 = (short)897318913;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_E8:
				num2 = (short)864026625;
				if (num2 != 0)
				{
				}
				num2 = (short)619511808;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x001C2244 File Offset: 0x001C0444
		public void FirePropertyChanged(string name)
		{
			short num = (short)1682767873;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1584607412;
					short num3 = num;
					num = (short)898379956;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2133655552;
						if (num != 0)
						{
						}
						num = (short)734068737;
						if (num != 0)
						{
						}
						this.z(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
						num = (short)1576796162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return;
				}
				IL_31:
				if (this.z == null)
				{
					break;
				}
				num = (short)789774336;
				short num4 = num;
				num = (short)1762787328;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x001C236C File Offset: 0x001C056C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 3;
			short num;
			if (!this.aa)
			{
				num = (short)850631360;
				short num2 = num;
				num = (short)311401152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1265369088;
					if (num != 0)
					{
					}
					this.aa = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦅ\udb87憎憐킕ﶗﮙ튟잡힣鶥쮧얩솫\udead\udfaf\udcb1톳\ud8b5첷閹\udfbb튽꾿곁ꇃ難韛꿋ꇍ뻏듑뷓뇕귗꣙뷛ꫝ觟跡諣짥诧蛩菫胭闯ퟱ웳웵迷鏹蛻鿽狿昁⬃瘅椇洉椋洍簏紑稓猕漗猙昛缝刟䘡ਣ帥䤧䜩䀫", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)784138241;
			if (num != 0)
			{
			}
			num = (short)467795968;
			short num3 = num;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x001C244C File Offset: 0x001C064C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)991690753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1251475458;
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
					goto IL_25A;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_489;
				case 2:
					goto IL_3F5;
				case 3:
					goto IL_6DB;
				case 4:
					goto IL_6B7;
				case 5:
					goto IL_505;
				case 6:
					goto IL_6E8;
				case 7:
					goto IL_5F7;
				case 8:
					goto IL_465;
				case 9:
					goto IL_1AB;
				case 10:
					goto IL_4D4;
				case 11:
					goto IL_26C;
				case 12:
					goto IL_5AC;
				case 13:
					goto IL_25F;
				case 14:
					goto IL_529;
				case 15:
					goto IL_191;
				case 16:
					goto IL_344;
				case 17:
					goto IL_1F6;
				case 18:
					goto IL_290;
				case 19:
					goto IL_38F;
				case 20:
					goto IL_382;
				case 21:
					goto IL_375;
				case 22:
					goto IL_4C7;
				case 23:
					goto IL_337;
				case 24:
					goto IL_70C;
				case 25:
					goto IL_543;
				case 26:
					goto IL_431;
				case 27:
					goto IL_683;
				case 28:
					goto IL_2CE;
				case 29:
					goto IL_2F2;
				case 30:
					goto IL_44B;
				case 31:
					goto IL_234;
				case 32:
					goto IL_676;
				case 33:
					goto IL_5DD;
				case 34:
					goto IL_642;
				case 35:
					goto IL_635;
				case 36:
					goto IL_424;
				case 37:
					goto IL_64F;
				case 38:
					goto IL_39C;
				case 39:
					goto IL_719;
				case 40:
					goto IL_5EA;
				case 41:
					goto IL_184;
				case 42:
					goto IL_1E9;
				case 43:
					goto IL_628;
				case 44:
					goto IL_5D0;
				case 45:
					goto IL_65C;
				case 46:
					goto IL_2FF;
				case 47:
					goto IL_536;
				case 48:
					goto IL_6AA;
				case 49:
					goto IL_1CF;
				case 50:
					goto IL_690;
				case 51:
					goto IL_177;
				case 52:
					goto IL_726;
				case 53:
					goto IL_585;
				case 54:
					goto IL_61B;
				case 55:
					goto IL_43E;
				case 56:
					goto IL_4F8;
				case 57:
					goto IL_2C1;
				case 58:
					goto IL_69D;
				case 59:
					goto IL_19E;
				case 60:
					goto IL_368;
				case 61:
					goto IL_550;
				case 62:
					goto IL_592;
				case 63:
					goto IL_21A;
				case 64:
					goto IL_458;
				case 65:
					goto IL_2B4;
				case 66:
					goto IL_1DC;
				case 67:
					goto IL_59F;
				case 68:
					goto IL_4BA;
				case 69:
					goto IL_740;
				case 70:
					goto IL_669;
				case 71:
					goto IL_227;
				case 72:
					goto IL_733;
				default:
					num = (short)34930688;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_177:
			this.PeerIPAddress1 = (global::AcpUI.AcpLabel)target;
			return;
			IL_184:
			this.ExpIndAstroOtarRadioIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_191:
			this.progressBar2 = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_19E:
			this.DataProfilesDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1AB:
			this.HLinkDataWide = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataWide.Click += this.HLinkClick;
			return;
			IL_1CF:
			this.SubscriberIPAddress1 = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DC:
			this.LblUserInfoUserLoginUnitID = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E9:
			this.LblSecWideASTROOTARIndividualASTROOTARRadioID = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F6:
			this.CloneRadiobutton = (global::System.Windows.Controls.Button)target;
			this.CloneRadiobutton.Click += this.OnCloneWizardClone;
			return;
			IL_21A:
			this.RadWideUserInformationandPasswordsSoftIDUsername = (global::AcpUI.AcpTextBox)target;
			return;
			IL_227:
			this.BluetoothFriendlyName = (global::AcpUI.AcpLabel)target;
			return;
			IL_234:
			this.FileCloneEnBox = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_25A:
			this.aa = true;
			return;
			IL_25F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_26C:
			this.HLinkUserInfo = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkUserInfo.Click += this.HLinkClick;
			return;
			IL_290:
			this.btnBatchProgrammingHelp = (global::System.Windows.Controls.Button)target;
			this.btnBatchProgrammingHelp.Click += this.buttonHelp_Click;
			return;
			IL_2B4:
			this.RadWideUserInformationandPasswordsPINPassword = (global::AcpUI.AcpPasswordEyeBox)target;
			return;
			IL_2C1:
			this.DataWideGeneralBTPeerIPAddress = (global::AcpUI.AcpTextBox)target;
			return;
			IL_2CE:
			this.OK = (global::AcpUI.AcpButton)target;
			this.OK.Click += this.OK_Click;
			return;
			IL_2F2:
			this.ExpFileClone = (global::AcpUI.AcpExpander)target;
			return;
			IL_2FF:
			num = (short)660078592;
			short num3 = num;
			this.IndAstroOtarRadioID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_337:
			this.CnvSysAstroIDIncrement = (global::AcpUI.AcpTextBox)target;
			return;
			IL_344:
			this.ReadRadioIDsbutton = (global::System.Windows.Controls.Button)target;
			this.ReadRadioIDsbutton.Click += this.OnCloneWizardReadIds;
			return;
			IL_368:
			this.DataProfileName_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_375:
			this.TrkSysUnitIDIncrement = (global::AcpUI.AcpTextBox)target;
			return;
			IL_382:
			this.UnitID = (global::AcpUI.AcpLabel)target;
			return;
			IL_38F:
			this.ExpMultipleRadio = (global::AcpUI.AcpExpander)target;
			return;
			IL_39C:
			num = (short)1181094103;
			short num4 = num;
			num = (short)1886458071;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_44B:
				this.FileCloneEn = (global::AcpUI.AcpLabel)target;
				return;
			default:
				num = (short)1962672128;
				if (num != 0)
				{
				}
				this.UnitID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			}
			IL_3F5:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_424:
			this.TrkSysName_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_431:
			this.AstroOtarRadioID = (global::AcpUI.AcpLabel)target;
			return;
			IL_43E:
			this.DataWideGeneralBTSubscriberIPAddress = (global::AcpUI.AcpTextBox)target;
			return;
			IL_458:
			this.LblUserInfoPINPassword = (global::AcpUI.AcpLabel)target;
			return;
			IL_465:
			this.HLinkExpIndAstroOtarRadioIDList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkExpIndAstroOtarRadioIDList.Click += this.HLinkClick;
			return;
			IL_489:
			((global::SpecialFeatures.CloneWizard.PageCloneWizard)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.CloneWizard.PageCloneWizard)target).Unloaded += this.OnUnloaded;
			return;
			IL_4BA:
			this.LblRadioAlias = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C7:
			this.ASTROID = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D4:
			this.HLinkDataProfileList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataProfileList.Click += this.HLinkClick;
			return;
			IL_4F8:
			this.DataWideBTPeerIPAddress = (global::AcpUI.AcpLabel)target;
			return;
			IL_505:
			this.HLinkFileClone = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFileClone.Click += this.HLinkClick;
			return;
			IL_529:
			this.ProgText = (global::AcpUI.AcpLabel)target;
			return;
			IL_536:
			this.ExpDataWide = (global::AcpUI.AcpExpander)target;
			return;
			IL_543:
			this.CnvSysMdcIDIncrement = (global::AcpUI.AcpTextBox)target;
			return;
			IL_550:
			num = (short)1743388673;
			if (num != 0)
			{
			}
			this.ExpUserInfo = (global::AcpUI.AcpExpander)target;
			return;
			IL_585:
			this.GrpBoxExpanderDataWideGeneralBluetoothDUNAddresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_592:
			this.SoftIDUsername = (global::AcpUI.AcpLabel)target;
			return;
			IL_59F:
			this.RadWideUserInformationandPasswordsUserLoginUnitID = (global::AcpUI.AcpTextBox)target;
			return;
			IL_5AC:
			this.HLinkBluetooth = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkBluetooth.Click += this.HLinkClick;
			return;
			IL_5D0:
			this.IndAstroOtardRadioIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_5DD:
			this.SerialNumberBox = (global::AcpUI.AcpTextBox)target;
			return;
			IL_5EA:
			this.CnvSysIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_5F7:
			this.HLinkExpCnvSysIDList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkExpCnvSysIDList.Click += this.HLinkClick;
			return;
			IL_61B:
			this.DataWideBTSubscriberIPAddress = (global::AcpUI.AcpLabel)target;
			return;
			IL_628:
			this.SecWideASTROOTARIndividualASTROOTARRadioID = (global::AcpUI.AcpTextBoxSpinner)target;
			return;
			IL_635:
			this.TrunkingIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_642:
			this.ExpTrkSysIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_64F:
			this.TrkSysID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_65C:
			this.SecureKMFProfile_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_669:
			this.ExpBluetooth = (global::AcpUI.AcpExpander)target;
			return;
			IL_676:
			this.SerialNumber = (global::AcpUI.AcpLabel)target;
			return;
			IL_683:
			this.IndAstroOtarRadioIDIncrement = (global::AcpUI.AcpTextBox)target;
			return;
			IL_690:
			this.DataWideGeneralSubscriberIPAddress1 = (global::AcpUI.AcpTextBox)target;
			return;
			IL_69D:
			this.ExpDataProfileList = (global::AcpUI.AcpExpander)target;
			return;
			IL_6AA:
			this.GrpBoxExpanderDataWideGeneralSerialLink1Addresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6B7:
			this.HLinkMultipleRadio = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMultipleRadio.Click += this.HLinkClick;
			return;
			IL_6DB:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_6E8:
			this.HLinkTrkSysIDList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrkSysIDList.Click += this.HLinkClick;
			return;
			IL_70C:
			this.MDCID = (global::AcpUI.AcpLabel)target;
			return;
			IL_719:
			this.ExpCnvSysIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_726:
			this.DataWideGeneralPeerIPAddress1 = (global::AcpUI.AcpTextBox)target;
			return;
			IL_733:
			this.RadWideBluetoothFriendlyName = (global::AcpUI.AcpTextBox)target;
			return;
			IL_740:
			this.RadWideUserInformationandPasswordsRadioAlias = (global::AcpUI.AcpTextBox)target;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x001C2BB0 File Offset: 0x001C0DB0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			int a_ = 5;
			short num = (short)454361088;
			short num2 = num;
			num = (short)1202192384;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_59:
					switch (num3)
					{
					case 0:
						goto IL_145;
					case 1:
						goto IL_188;
					case 2:
						num = (short)1161297921;
						if (num != 0)
						{
						}
						flag = true;
						num = (short)1573191681;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						bool radInfoLabtoolH37G50Smartnet_A8184Value;
						bool radInfoLabtoolH38G51Smartzone_A8185Value;
						if (radInfoLabtoolH37G50Smartnet_A8184Value || radInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)1012727810;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					}
					case 4:
						if (radioInformation != null)
						{
							num = (short)272957440;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					}
					goto IL_74;
				}
				IL_145:
				goto IL_18A;
				IL_188:
				IL_1DE:
				global::SpecialFeatures.Comms.RadioIdInfo radioIdInfo;
				base.Dispatcher.Invoke(new global::SpecialFeatures.CloneWizard.PageCloneWizard.MainThreadUpdateRadioIds(this.a), new object[]
				{
					radioIdInfo,
					flag
				});
				this.CallMainFinish(false);
				global::SpecialFeatures.Comms.Comms.updateStatus -= this.CallMainUiProcess;
				return;
				IL_74:
				num = (short)2048516437;
				short num4 = num;
				num = (short)716824917;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_18A:
					bool radInfoLabtoolH37G50Smartnet_A8184Value = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
					bool radInfoLabtoolH38G51Smartzone_A8185Value = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value;
					num = (short)219283459;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_59;
				}
				default:
					num = (short)678559744;
					if (num != 0)
					{
					}
					this.h = true;
					global::SpecialFeatures.Comms.Comms.updateStatus += this.CallMainUiProcess;
					radioIdInfo = this.q.ReadRadioIds(global::SpecialFeatures.Comms.CloneParameters.CloneWriteType, 0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릇뎉뺋ꂍꆏ꒑겓뢕ꦗꢙ꒛낝醟", a_), false, false);
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					flag = false;
					num = (short)1091764228;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_59;
				}
				break;
			}
			}
		}

		// Token: 0x04000A3A RID: 2618
		private bool a;

		// Token: 0x04000A3B RID: 2619
		private global::SpecialFeatures.Clone_Configuration.Common.RadioEjectTimer b;

		// Token: 0x04000A3C RID: 2620
		private bool c;

		// Token: 0x04000A3D RID: 2621
		private int d;

		// Token: 0x04000A3E RID: 2622
		private int e;

		// Token: 0x04000A3F RID: 2623
		private int f;

		// Token: 0x04000A40 RID: 2624
		private int g;

		// Token: 0x04000A41 RID: 2625
		private bool h;

		// Token: 0x04000A42 RID: 2626
		private bool i;

		// Token: 0x04000A43 RID: 2627
		private bool j;

		// Token: 0x04000A44 RID: 2628
		private int k;

		// Token: 0x04000A45 RID: 2629
		private int l;

		// Token: 0x04000A46 RID: 2630
		private int m;

		// Token: 0x04000A47 RID: 2631
		private int n;

		// Token: 0x04000A48 RID: 2632
		private global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset o;

		// Token: 0x04000A49 RID: 2633
		private bool p;

		// Token: 0x04000A4A RID: 2634
		private global::SpecialFeatures.Comms.Clone q = new global::SpecialFeatures.Comms.Clone();

		// Token: 0x04000A4B RID: 2635
		private global::System.IntPtr r = global::System.IntPtr.Zero;

		// Token: 0x04000A4C RID: 2636
		private global::System.Windows.Input.Cursor s;

		// Token: 0x04000A4D RID: 2637
		private bool t;

		// Token: 0x04000A4E RID: 2638
		private string u;

		// Token: 0x04000A4F RID: 2639
		private bool v;

		// Token: 0x04000A50 RID: 2640
		private string w = "";

		// Token: 0x04000A51 RID: 2641
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string x;

		// Token: 0x04000A52 RID: 2642
		private string y;

		// Token: 0x04000A53 RID: 2643
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler z;

		// Token: 0x04000A54 RID: 2644
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000A55 RID: 2645
		internal global::System.Windows.Documents.Hyperlink HLinkMultipleRadio;

		// Token: 0x04000A56 RID: 2646
		internal global::System.Windows.Documents.Hyperlink HLinkFileClone;

		// Token: 0x04000A57 RID: 2647
		internal global::System.Windows.Documents.Hyperlink HLinkTrkSysIDList;

		// Token: 0x04000A58 RID: 2648
		internal global::System.Windows.Documents.Hyperlink HLinkExpCnvSysIDList;

		// Token: 0x04000A59 RID: 2649
		internal global::System.Windows.Documents.Hyperlink HLinkExpIndAstroOtarRadioIDList;

		// Token: 0x04000A5A RID: 2650
		internal global::System.Windows.Documents.Hyperlink HLinkDataWide;

		// Token: 0x04000A5B RID: 2651
		internal global::System.Windows.Documents.Hyperlink HLinkDataProfileList;

		// Token: 0x04000A5C RID: 2652
		internal global::System.Windows.Documents.Hyperlink HLinkUserInfo;

		// Token: 0x04000A5D RID: 2653
		internal global::System.Windows.Documents.Hyperlink HLinkBluetooth;

		// Token: 0x04000A5E RID: 2654
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000A5F RID: 2655
		internal global::AcpUI.AcpLabel ProgText;

		// Token: 0x04000A60 RID: 2656
		internal global::System.Windows.Controls.ProgressBar progressBar2;

		// Token: 0x04000A61 RID: 2657
		internal global::System.Windows.Controls.Button ReadRadioIDsbutton;

		// Token: 0x04000A62 RID: 2658
		internal global::System.Windows.Controls.Button CloneRadiobutton;

		// Token: 0x04000A63 RID: 2659
		internal global::System.Windows.Controls.Button btnBatchProgrammingHelp;

		// Token: 0x04000A64 RID: 2660
		internal global::AcpUI.AcpExpander ExpMultipleRadio;

		// Token: 0x04000A65 RID: 2661
		internal global::AcpUI.AcpLabel UnitID;

		// Token: 0x04000A66 RID: 2662
		internal global::AcpUI.AcpTextBox TrkSysUnitIDIncrement;

		// Token: 0x04000A67 RID: 2663
		internal global::AcpUI.AcpLabel ASTROID;

		// Token: 0x04000A68 RID: 2664
		internal global::AcpUI.AcpTextBox CnvSysAstroIDIncrement;

		// Token: 0x04000A69 RID: 2665
		internal global::AcpUI.AcpLabel MDCID;

		// Token: 0x04000A6A RID: 2666
		internal global::AcpUI.AcpTextBox CnvSysMdcIDIncrement;

		// Token: 0x04000A6B RID: 2667
		internal global::AcpUI.AcpLabel AstroOtarRadioID;

		// Token: 0x04000A6C RID: 2668
		internal global::AcpUI.AcpTextBox IndAstroOtarRadioIDIncrement;

		// Token: 0x04000A6D RID: 2669
		internal global::AcpUI.AcpButton OK;

		// Token: 0x04000A6E RID: 2670
		internal global::AcpUI.AcpExpander ExpFileClone;

		// Token: 0x04000A6F RID: 2671
		internal global::AcpUI.AcpLabel FileCloneEn;

		// Token: 0x04000A70 RID: 2672
		internal global::AcpUI.AcpCheckBox FileCloneEnBox;

		// Token: 0x04000A71 RID: 2673
		internal global::AcpUI.AcpLabel SerialNumber;

		// Token: 0x04000A72 RID: 2674
		internal global::AcpUI.AcpTextBox SerialNumberBox;

		// Token: 0x04000A73 RID: 2675
		internal global::AcpUI.AcpExpander ExpTrkSysIDList;

		// Token: 0x04000A74 RID: 2676
		internal global::AcpUI.AcpXamDataPresenter TrunkingIDDataPresenter;

		// Token: 0x04000A75 RID: 2677
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysName_Col;

		// Token: 0x04000A76 RID: 2678
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysID_Col;

		// Token: 0x04000A77 RID: 2679
		internal global::Infragistics.Windows.DataPresenter.UnboundField UnitID_Col;

		// Token: 0x04000A78 RID: 2680
		internal global::AcpUI.AcpExpander ExpCnvSysIDList;

		// Token: 0x04000A79 RID: 2681
		internal global::AcpUI.AcpXamDataPresenter CnvSysIDDataPresenter;

		// Token: 0x04000A7A RID: 2682
		internal global::AcpUI.AcpExpander ExpIndAstroOtarRadioIDList;

		// Token: 0x04000A7B RID: 2683
		internal global::AcpUI.AcpLabel LblSecWideASTROOTARIndividualASTROOTARRadioID;

		// Token: 0x04000A7C RID: 2684
		internal global::AcpUI.AcpTextBoxSpinner SecWideASTROOTARIndividualASTROOTARRadioID;

		// Token: 0x04000A7D RID: 2685
		internal global::AcpUI.AcpXamDataPresenter IndAstroOtardRadioIDDataPresenter;

		// Token: 0x04000A7E RID: 2686
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecureKMFProfile_Col;

		// Token: 0x04000A7F RID: 2687
		internal global::Infragistics.Windows.DataPresenter.UnboundField IndAstroOtarRadioID_Col;

		// Token: 0x04000A80 RID: 2688
		internal global::AcpUI.AcpExpander ExpDataWide;

		// Token: 0x04000A81 RID: 2689
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralSerialLink1Addresses;

		// Token: 0x04000A82 RID: 2690
		internal global::AcpUI.AcpLabel SubscriberIPAddress1;

		// Token: 0x04000A83 RID: 2691
		internal global::AcpUI.AcpTextBox DataWideGeneralSubscriberIPAddress1;

		// Token: 0x04000A84 RID: 2692
		internal global::AcpUI.AcpLabel PeerIPAddress1;

		// Token: 0x04000A85 RID: 2693
		internal global::AcpUI.AcpTextBox DataWideGeneralPeerIPAddress1;

		// Token: 0x04000A86 RID: 2694
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralBluetoothDUNAddresses;

		// Token: 0x04000A87 RID: 2695
		internal global::AcpUI.AcpLabel DataWideBTSubscriberIPAddress;

		// Token: 0x04000A88 RID: 2696
		internal global::AcpUI.AcpTextBox DataWideGeneralBTSubscriberIPAddress;

		// Token: 0x04000A89 RID: 2697
		internal global::AcpUI.AcpLabel DataWideBTPeerIPAddress;

		// Token: 0x04000A8A RID: 2698
		internal global::AcpUI.AcpTextBox DataWideGeneralBTPeerIPAddress;

		// Token: 0x04000A8B RID: 2699
		internal global::AcpUI.AcpExpander ExpDataProfileList;

		// Token: 0x04000A8C RID: 2700
		internal global::AcpUI.AcpXamDataPresenter DataProfilesDataPresenter;

		// Token: 0x04000A8D RID: 2701
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfileName_Col;

		// Token: 0x04000A8E RID: 2702
		internal global::AcpUI.AcpExpander ExpUserInfo;

		// Token: 0x04000A8F RID: 2703
		internal global::AcpUI.AcpLabel SoftIDUsername;

		// Token: 0x04000A90 RID: 2704
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsSoftIDUsername;

		// Token: 0x04000A91 RID: 2705
		internal global::AcpUI.AcpLabel LblUserInfoPINPassword;

		// Token: 0x04000A92 RID: 2706
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPasswordsPINPassword;

		// Token: 0x04000A93 RID: 2707
		internal global::AcpUI.AcpLabel LblUserInfoUserLoginUnitID;

		// Token: 0x04000A94 RID: 2708
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsUserLoginUnitID;

		// Token: 0x04000A95 RID: 2709
		internal global::AcpUI.AcpLabel LblRadioAlias;

		// Token: 0x04000A96 RID: 2710
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsRadioAlias;

		// Token: 0x04000A97 RID: 2711
		internal global::AcpUI.AcpExpander ExpBluetooth;

		// Token: 0x04000A98 RID: 2712
		internal global::AcpUI.AcpLabel BluetoothFriendlyName;

		// Token: 0x04000A99 RID: 2713
		internal global::AcpUI.AcpTextBox RadWideBluetoothFriendlyName;

		// Token: 0x04000A9A RID: 2714
		private bool aa;

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06001357 RID: 4951
		public delegate void MainUIDisplayCBI(global::SpecialFeatures.Comms.Comms.CBIReturn CbiSN);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x0600135B RID: 4955
		public delegate void MainUIDisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject radioObject);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x0600135F RID: 4959
		public delegate void WriteRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn info);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x06001363 RID: 4963
		private delegate void UpdateProgress(double n, string stat);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x06001367 RID: 4967
		private delegate void MainFinish(bool status);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x0600136B RID: 4971
		private delegate void MainThreadUpdateRadioIds(global::SpecialFeatures.Comms.RadioIdInfo TempRadioIds, bool TrkEnabled);
	}
}
