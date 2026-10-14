using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonResources;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using ControlHeadGraphicView.acpcontrol;
using MackinawCPS.CommandLineCPS;
using MackinawCPS.Properties;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using PreEmptive.SoS.Runtime;
using SpecialFeatures;
using SpecialFeatures.Flashport;
using SpecialFeatures.Model_Configuration;

namespace MackinawCPS
{
	// Token: 0x02000003 RID: 3
	public partial class App : Application
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000026A0 File Offset: 0x000008A0
		public AcpDocument TheDocument
		{
			get
			{
				short num = (short)466288640;
				short num2 = num;
				num = (short)795821223;
				short num3 = num;
				num = (short)1469400231;
				switch (num3 == num)
				{
				}
				num = (short)192610305;
				if (num != 0)
				{
				}
				num = (short)1356267520;
				if (num != 0)
				{
				}
				return this.document;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000274C File Offset: 0x0000094C
		internal FlashDocument FlashDoc
		{
			get
			{
				short num = (short)950468608;
				short num2 = num;
				num = (short)1430628058;
				short num3 = num;
				num = (short)77702874;
				switch (num3 == num)
				{
				}
				num = (short)1177354241;
				if (num != 0)
				{
				}
				num = (short)1652293632;
				if (num != 0)
				{
				}
				return this.flashdoc;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000027F8 File Offset: 0x000009F8
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000028A8 File Offset: 0x00000AA8
		internal static CPS_Languages AdditionalCPSLanguages
		{
			[CompilerGenerated]
			get
			{
				short num = (short)702021632;
				short num2 = num;
				num = (short)1637447174;
				short num3 = num;
				num = (short)1830647302;
				switch (num3 == num)
				{
				}
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)333840385;
				if (num != 0)
				{
				}
				return App.<AdditionalCPSLanguages>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				short num = (short)1839563569;
				short num2 = num;
				num = (short)962626353;
				switch (num2 == num)
				{
				}
				num = (short)1464598528;
				if (num != 0)
				{
				}
				num = (short)272891905;
				if (num != 0)
				{
				}
				num = (short)1173684224;
				short num3 = num;
				App.<AdditionalCPSLanguages>k__BackingField = value;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002954 File Offset: 0x00000B54
		static App()
		{
			int a_ = 18;
			short num = (short)1655077410;
			short num2 = num;
			num = (short)756120098;
			switch (num2 == num)
			{
			}
			num = (short)104267777;
			if (num != 0)
			{
			}
			num = (short)1529479168;
			if (num != 0)
			{
			}
			num = (short)1374027776;
			short num3 = num;
			App.mainAssemblyCulture = FixedLengthStream.b("韱髳", a_);
			App.ExportXMLCommandMode = false;
			App.ExportSourceMCPath = string.Empty;
			App.AdditionalCPSLanguages = new CPS_Languages();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002A34 File Offset: 0x00000C34
		public App()
		{
			int a_ = 8;
			this.FPSCommandLineArgs = new string[100];
			base..ctor();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			try
			{
				if (commandLineArgs.Length > 1 && commandLineArgs[1].ToLower() == FixedLengthStream.b("쟧觩黫鯭黯釱鳳鏵諷", a_))
				{
					base.Properties[FixedLengthStream.b("ꯧ藩臫菭釯鳱郳뫵釷铹駻뷽僿儁", a_)] = true;
					goto IL_15E;
				}
				IL_54:
				base.Properties[FixedLengthStream.b("ꯧ藩臫菭釯鳱郳뫵釷铹駻뷽僿儁", a_)] = false;
				IL_15E:
				AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
				base.DispatcherUnhandledException += this.App_DispatcherUnhandledException;
				TaskScheduler.UnobservedTaskException += this.TaskScheduler_UnobservedTaskException;
				base.Deactivated += this.App_Deactivated;
				this.document = new MackCPSDocument();
				this.flashdoc = new FlashDocument();
				string text = App.mainAssemblyCulture;
				Settings settings = new Settings();
				if (!string.IsNullOrEmpty(settings.UserSelectedApplicationLanguage))
				{
					text = settings.UserSelectedApplicationLanguage;
				}
				else if (!string.IsNullOrEmpty(App.AdditionalCPSLanguages.DefaultCPSLanguage))
				{
					text = App.AdditionalCPSLanguages.DefaultCPSLanguage;
				}
				if (text != FixedLengthStream.b("跧蓩", a_))
				{
					AcpTextBox.DisableMask = true;
					AcpTextBoxSpinner_G.DisableMask = true;
				}
				CultureInfo cultureInfo;
				for (;;)
				{
					if (text == FixedLengthStream.b("飧黩", a_))
					{
						AcpTextBox.DisableIPMask = true;
					}
					cultureInfo = null;
					try
					{
						if (text == FixedLengthStream.b("鋧苩쇫뫭꟯", a_))
						{
							cultureInfo = new CultureInfo(197636);
						}
						else if (text == FixedLengthStream.b("跧駩", a_))
						{
							cultureInfo = new CultureInfo(FixedLengthStream.b("跧駩쇫ꏭ꣯", a_));
						}
						else if (text == FixedLengthStream.b("觧飩", a_))
						{
							cultureInfo = new CultureInfo(FixedLengthStream.b("觧飩쇫ꗭ꟯", a_));
							cultureInfo.NumberFormat.DigitSubstitution = DigitShapes.None;
						}
						else
						{
							cultureInfo = new CultureInfo(text);
						}
						break;
					}
					catch (CultureNotFoundException)
					{
						cultureInfo = new CultureInfo(App.mainAssemblyCulture);
						break;
					}
				}
				Thread.CurrentThread.CurrentCulture = cultureInfo;
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
				CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
				CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
				AppResources.Culture = cultureInfo;
				AcgResources.Culture = cultureInfo;
				MTFResources.Culture = cultureInfo;
				AcpResources.Culture = cultureInfo;
				Motorola.CommonCPS.ResourceRepository.Resources.Culture = cultureInfo;
				using (ModelTiering modelTiering = new ModelTiering(FixedLengthStream.b("ꃧ폩\udbeb뫭럯뛱췳꛵꿷쯹뷻냽", a_), ModelTiering.ActionTypes.NONE, ModelTiering.TargetTypes.NONE, false))
				{
					modelTiering.LoadAliasList();
					goto IL_78;
				}
				goto IL_54;
				IL_78:
				FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
				this.document.SetModificationLogPath(Environment.CurrentDirectory + FixedLengthStream.b("듧ꛩ菫觭곯鿱鯳鋵釷鳹闻鷽懿瘁洃椅昇␉怋愍眏", a_), false);
				this.document.ModificationLogEnabled = false;
				if (MackinawCPS.Startup.IsGuest)
				{
					MessageBox.Show(AppResources.The_Windows_Guest_Account, AppResources.APX_CPS_Access_Denied, MessageBoxButton.OK, MessageBoxImage.Hand);
					Environment.Exit(0);
				}
				AppInfoManager.AppType = ApplicationType.CPS;
				this.InitializeComponent();
			}
			catch (ConfigurationErrorsException ex)
			{
				string path = "";
				if (!string.IsNullOrEmpty(ex.Filename))
				{
					path = ex.Filename;
				}
				else
				{
					ConfigurationErrorsException ex2 = ex.InnerException as ConfigurationErrorsException;
					if (ex2 != null && !string.IsNullOrEmpty(ex2.Filename))
					{
						path = ex2.Filename;
					}
				}
				for (;;)
				{
					if (commandLineArgs.Length <= 1)
					{
						goto IL_450;
					}
					IL_3D4:
					if (commandLineArgs[1].ToLower() == FixedLengthStream.b("쟧觩黫鯭黯釱鳳鏵諷", a_))
					{
						try
						{
							if (File.Exists(path))
							{
								File.Delete(path);
							}
							goto IL_42D;
						}
						catch
						{
							goto IL_42D;
						}
						continue;
						IL_42D:
						Environment.Exit(-18);
					}
					IL_450:
					if (!File.Exists(path))
					{
						goto IL_45B;
					}
					if (MessageBox.Show(AppResources.User_Config_File_Delete, AppResources.Confirm_Deleting, MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
					{
						try
						{
							File.Delete(path);
							Environment.Exit(0);
							goto IL_45B;
						}
						catch (IOException)
						{
							Environment.Exit(1212);
							goto IL_45B;
						}
						goto IL_3D4;
					}
					break;
				}
				Environment.Exit(0);
				IL_45B:;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002F1C File Offset: 0x0000111C
		private bool CheckIfExceptionShallBeForwardedBackToRMC(CommonException cex)
		{
			short num = (short)1450639363;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1526071297;
					if (num != 0)
					{
					}
					num = (short)1698758656;
					short num3 = num;
					num = (short)791851138;
					short num4 = num;
					num = (short)568111234;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					default:
						num = (short)1862336512;
						if (num != 0)
						{
						}
						num = (short)1008795649;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (cex.ErrorCode != CommonErrorCode.RMC_CommunicationServerCommunicationError)
					{
						goto IL_127;
					}
					return true;
				case 2:
					goto IL_13E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (cex.ErrorCode != CommonErrorCode.RMC_CommunicationServerNotAvailabe)
				{
					num = (short)549322752;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return true;
				IL_127:
				num = (short)1936195586;
				num2 = (int)((IntPtr)num);
			}
			IL_13E:
			return cex.ErrorCode == CommonErrorCode.RMC_CommunicationServerTimeout;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003070 File Offset: 0x00001270
		private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			CommonException ex;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)984154112;
					short num3 = num2;
					MessageBox.Show(AppResources.Unkown_Error, AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
					num2 = (short)519700481;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_2A0;
				case 2:
					goto IL_2F6;
				case 3:
				{
					Environment.Exit(-15);
					num2 = (short)1941097982;
					short num4 = num2;
					num2 = (short)1073204734;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num2 = (short)254214144;
						if (num2 != 0)
						{
						}
						num2 = (short)1770192902;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1429602314;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					goto IL_108;
				case 6:
					goto IL_135;
				case 7:
					goto IL_64;
				case 8:
					if (this.CheckIfExceptionShallBeForwardedBackToRMC(ex))
					{
						num2 = (short)1658388485;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 9:
					if (e.Exception.Source == FixedLengthStream.b("뫨鯪裬賮飰鋲駴뇶鳸髺觼諾猀昂瘄", a_))
					{
						num2 = (short)1709899776;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (ex.ErrorCode == CommonExceptionHelper.DirectMsgCode)
					{
						num2 = (short)205455362;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)689635336;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					if (ex != null)
					{
						num2 = (short)812646404;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)2082996233;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_49;
				IL_64:
				if ((bool)Application.Current.Properties[FixedLengthStream.b("ꫨ蓪胬苮郰鷲釴믶郸闺飼볾儀倂", a_)])
				{
					num2 = (short)578945027;
					num = (int)((IntPtr)num2);
					continue;
				}
				IL_135:
				ex = (e.Exception.InnerException as CommonException);
				num2 = (short)111607819;
				num = (int)((IntPtr)num2);
			}
			IL_A7:
			MessageBox.Show(ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
			IL_108:
			num2 = (short)1677656065;
			if (num2 != 0)
			{
			}
			RMCExportInterface.GetInstance().HandleGlobalException(ex);
			return;
			IL_2A0:
			return;
			IL_2F6:
			MessageBox.Show(ex.Message, AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
			IL_49:
			e.SetObserved();
			num2 = (short)593494023;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003378 File Offset: 0x00001578
		private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			CommonException ex;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2122055680;
					short num3 = num2;
					MessageBox.Show(AppResources.Unkown_Error, AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
					num2 = (short)488701953;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_29E;
				case 2:
					goto IL_2F4;
				case 3:
				{
					Environment.Exit(-15);
					num2 = (short)1990168077;
					short num4 = num2;
					num2 = (short)110333453;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num2 = (short)1889861633;
						if (num2 != 0)
						{
						}
						num2 = (short)350158848;
						if (num2 != 0)
						{
						}
						num2 = (short)1888813062;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1701838858;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					goto IL_108;
				case 6:
					goto IL_10D;
				case 7:
					goto IL_64;
				case 8:
					if (this.CheckIfExceptionShallBeForwardedBackToRMC(ex))
					{
						num2 = (short)807600133;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 9:
					if (e.Exception.Source == FixedLengthStream.b("뻬鿮铰郲鳴零闸뷺飼黾甀瘂眄戆稈", a_))
					{
						num2 = (short)606863360;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (ex.ErrorCode == CommonExceptionHelper.DirectMsgCode)
					{
						num2 = (short)992608258;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1854668808;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					if (ex != null)
					{
						num2 = (short)409206788;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)775159817;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_49;
				IL_64:
				if ((bool)Application.Current.Properties[FixedLengthStream.b("껬胮鳰黲铴駶鷸럺铼釾搀䀂唄吆", a_)])
				{
					num2 = (short)468779011;
					num = (int)((IntPtr)num2);
					continue;
				}
				IL_10D:
				ex = (e.Exception as CommonException);
				num2 = (short)187498507;
				num = (int)((IntPtr)num2);
			}
			IL_A7:
			MessageBox.Show(ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
			IL_108:
			RMCExportInterface.GetInstance().HandleGlobalException(ex);
			return;
			IL_29E:
			return;
			IL_2F4:
			MessageBox.Show(ex.Message, AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
			IL_49:
			e.Handled = true;
			num2 = (short)1161363463;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000367C File Offset: 0x0000187C
		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			int a_ = 11;
			short num = (short)196673538;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)305856513;
					if (num != 0)
					{
					}
					Environment.Exit(-15);
					num = (short)899481603;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
				{
					if (!((e.ExceptionObject as Exception).Source == FixedLengthStream.b("룪鷬諮鋰髲铴鯶뿸黺鳼课琀焂怄理", a_)))
					{
						return;
					}
					num = (short)70455926;
					short num3 = num;
					num = (short)557781622;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
					{
						num = (short)1562836992;
						short num4 = num;
						num = (short)1974992896;
						if (num != 0)
						{
						}
						num = (short)1356857348;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_1D;
				case 3:
					goto IL_DA;
				case 4:
					MessageBox.Show(AppResources.Unkown_Error, AppResources.error_Id, MessageBoxButton.OK, MessageBoxImage.Hand);
					num = (short)1387003909;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					return;
				}
				goto IL_45;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_45:
					if (!(bool)Application.Current.Properties[FixedLengthStream.b("꣪苬苮鳰鋲鯴鏶뗸鋺鏼髾䈀匂嘄", a_)])
					{
						goto IL_DA;
					}
					num = (short)1106837504;
					num2 = (int)((IntPtr)num);
					break;
				}
				continue;
				IL_DA:
				num = (short)640155649;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003854 File Offset: 0x00001A54
		private void App_Deactivated(object sender, EventArgs e)
		{
			short num = (short)548425810;
			short num2 = num;
			num = (short)270749778;
			switch (num2 == num)
			{
			}
			num = (short)791019520;
			if (num != 0)
			{
			}
			num = (short)513802240;
			short num3 = num;
			num = (short)1517355009;
			if (num != 0)
			{
			}
			AcpUI.Common.Utility.SaveFieldWithFocus();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000039B0 File Offset: 0x00001BB0
		internal string CommandLineArgument
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1090650113;
				if (num != 0)
				{
				}
				num = (short)1842475187;
				short num2 = num;
				num = (short)520371;
				switch (num2 == num)
				{
				}
				num = (short)1553727488;
				short num3 = num;
				num = (short)40566784;
				if (num != 0)
				{
				}
				return this.<CommandLineArgument>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				short num = (short)1170841104;
				short num2 = num;
				num = (short)1771740688;
				switch (num2 == num)
				{
				}
				num = (short)1986068481;
				if (num != 0)
				{
				}
				num = (short)1911881728;
				short num3 = num;
				num = (short)1050607616;
				if (num != 0)
				{
				}
				this.<CommandLineArgument>k__BackingField = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003A60 File Offset: 0x00001C60
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			int a_ = 0;
			short num = (short)1305214978;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.CommandLineArgument == FixedLengthStream.b("쿟臡難鏥蛧觩蓫语苯", a_))
					{
						num = (short)1387331590;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_130;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 3:
				{
					num = (short)1690205529;
					short num3 = num;
					num = (short)1834974553;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E9;
					default:
						goto IL_1A6;
					}
					break;
				}
				case 4:
					if (e.Args.Length == 0)
					{
						num = (short)713490435;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1E9;
				case 5:
					goto IL_135;
				case 6:
					num = (short)1731854345;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					Debugger.Launch();
					num = (short)2007105541;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					Cruncher.Instance.ParseCommandLineParameters(e.Args);
					num = (short)1345388545;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					if (e.Args.Length > 1)
					{
						num = (short)717094913;
						if (num != 0)
						{
						}
						num = (short)1406926856;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				IL_55:
				if (File.Exists(FixedLengthStream.b("菟\ud8e1룣ꫥ跧黩돫菭闯귱鳳鏵铷諹ꏻ蟽濿省嬃戅洇栉礋植伏焑笓笕甗笙爛稝䰟䬡䨣䌥眧椩簫紭漯̱سԵ", a_)))
				{
					num = (short)162725895;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_135:
				num = (short)997457924;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1E9:
				this.CommandLineArgument = e.Args[0].ToLower();
				num = (short)1545732096;
				num2 = (int)((IntPtr)num);
			}
			IL_130:
			return;
			IL_1A6:
			num = (short)1573519360;
			short num4 = num;
			num = (short)194379776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003CB8 File Offset: 0x00001EB8
		private void WalkDictionary(ResourceDictionary resources)
		{
			short num = (short)2054291456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1677131777;
				if (num != 0)
				{
				}
				IDictionaryEnumerator enumerator = resources.GetEnumerator();
				try
				{
					num = (short)535625731;
					num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_22D;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)924516356;
								num2 = (int)((IntPtr)num);
								continue;
							}
							DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
							num = (short)877133826;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_1BA;
							}
							continue;
						case 4:
							num = (short)2141454336;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_1BC:
						num = (short)964493313;
						num2 = (int)((IntPtr)num);
						continue;
						IL_1BA:
						goto IL_1BC;
					}
					IL_22D:
					goto IL_16F;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_24F;
					}
					IDisposable disposable;
					for (;;)
					{
						IL_23C:
						switch (num2)
						{
						case 0:
							goto IL_2F1;
						case 1:
						{
							num = (short)198800389;
							short num3 = num;
							num = (short)1364947973;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1332215808;
								if (num != 0)
								{
								}
								if (disposable != null)
								{
									num = (short)1525153794;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_2F3;
							}
							break;
						}
						case 2:
							disposable.Dispose();
							num = (short)1256325120;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_24F;
					}
					IL_2F1:
					IL_2F3:
					goto EndFinally_10;
					IL_24F:
					disposable = (enumerator as IDisposable);
					num = (short)150208513;
					num2 = (int)((IntPtr)num);
					goto IL_23C;
					EndFinally_10:;
				}
				goto IL_2F4;
				for (;;)
				{
					IL_16F:
					IEnumerator<ResourceDictionary> enumerator2 = resources.MergedDictionaries.GetEnumerator();
					try
					{
						num = (short)2053701635;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_FE;
							case 1:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1045889028;
									num2 = (int)((IntPtr)num);
									continue;
								}
								ResourceDictionary resources2 = enumerator2.Current;
								this.WalkDictionary(resources2);
								num = (short)1867251714;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_89;
								}
								continue;
							case 4:
								num = (short)1313800192;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_8B:
							num = (short)1822490625;
							num2 = (int)((IntPtr)num);
							continue;
							IL_89:
							goto IL_8B;
						}
						IL_FE:
						break;
					}
					finally
					{
						num = (short)1878392833;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_16C;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_135;
								}
								continue;
							case 2:
								enumerator2.Dispose();
								num = (short)1538588672;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_135:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)479395842;
							num2 = (int)((IntPtr)num);
						}
						IL_16C:;
					}
				}
				IL_2F4:
				num = (short)1040646144;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000410C File Offset: 0x0000230C
		[GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[STAThread]
		[DebuggerNonUserCode]
		public static void Main()
		{
			short num = (short)1115029505;
			if (num != 0)
			{
			}
			num = (short)559129593;
			short num2 = num;
			num = (short)1965138937;
			switch (num2 == num)
			{
			}
			num = (short)899743744;
			if (num != 0)
			{
			}
			num = (short)217186304;
			short num3 = num;
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}

		// Token: 0x04000003 RID: 3
		internal string[] FPSCommandLineArgs;

		// Token: 0x04000004 RID: 4
		internal string FPSOwnerSysIDArg;

		// Token: 0x04000005 RID: 5
		internal static readonly string mainAssemblyCulture;

		// Token: 0x04000006 RID: 6
		private AcpDocument document;

		// Token: 0x04000007 RID: 7
		private FlashDocument flashdoc;

		// Token: 0x04000009 RID: 9
		public static bool ExportXMLCommandMode;

		// Token: 0x0400000A RID: 10
		public static string ExportSourceMCPath;

		// Token: 0x0400000D RID: 13
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
