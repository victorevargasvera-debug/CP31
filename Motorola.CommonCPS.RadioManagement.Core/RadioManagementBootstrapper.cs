using System;
using System.ComponentModel.Composition.Hosting;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Regions;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.ApplicationLicense;
using Motorola.CommonCPS.RadioManagement.ASTRODataProfile;
using Motorola.CommonCPS.RadioManagement.ASTROOtarProfile;
using Motorola.CommonCPS.RadioManagement.ASTROSystem;
using Motorola.CommonCPS.RadioManagement.CACertificates;
using Motorola.CommonCPS.RadioManagement.Common;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonCore;
using Motorola.CommonCPS.RadioManagement.DVRSFiles;
using Motorola.CommonCPS.RadioManagement.Firmware;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.Job;
using Motorola.CommonCPS.RadioManagement.LanguagePack;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.Radio;
using Motorola.CommonCPS.RadioManagement.RadioLicense;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.Template;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.VoiceAnnouncement;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.RadioManagement.Core
{
	// Token: 0x02000005 RID: 5
	public class RadioManagementBootstrapper : global::Microsoft.Practices.Prism.MefExtensions.MefBootstrapper
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000022C8 File Offset: 0x000004C8
		public RadioManagementBootstrapper(string rmServerFeature)
		{
			if (global::System.Windows.Application.Current == null)
			{
				new global::Motorola.CommonCPS.RadioManagement.Core.MyApp();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022EC File Offset: 0x000004EC
		public static void LanuchForTestCase(string rmServerFeature)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			short num;
			int num3;
			int num4;
			for (;;)
			{
				IL_13:
				num = (short)489357312;
				short num2 = num;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1046413314;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)678166529;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1C7;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_195;
								}
								continue;
							case 3:
								goto IL_1DD;
							}
							IL_195:
							if (global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper.Connect())
							{
								num = (short)643366912;
								num3 = (int)((global::System.IntPtr)num);
							}
							else
							{
								num = (short)367656963;
								num3 = (int)((global::System.IntPtr)num);
							}
						}
						IL_1C7:
						return;
						IL_1DD:
						goto IL_9E;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(e, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("얣좥\udda7즩쒫\udfaf삱펵쮷캹ﾻ\udfbd뎿ꟁﻃ诇ꗉꋋꃍ뗏뇑ꃓ𥉉뿙껛곝迟郡", a_));
						goto IL_9E;
					}
					return;
					for (;;)
					{
						IL_9E:
						global::System.Threading.Thread.Sleep(500);
						num4++;
						num = (short)523194455;
						short num5 = num;
						num = (short)257380439;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E1;
						}
					}
					IL_E1:
					num = (short)775159808;
					if (num != 0)
					{
					}
					num = (short)506003459;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_129;
				case 2:
					if (num4 >= 3)
					{
						num = (short)761266180;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)472776704;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_129;
				case 4:
					return;
				}
				goto IL_59;
				IL_129:
				num = (short)68681730;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_59:
			num = (short)1663041537;
			if (num != 0)
			{
			}
			num4 = 0;
			num = (short)791412737;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002510 File Offset: 0x00000710
		public static bool Launch(object container, string rmServerFeature)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper radioManagementBootstrapper;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					(container as global::System.Windows.Controls.ContentControl).Content = radioManagementBootstrapper.Shell;
					num2 = (short)207028225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_B0;
				case 2:
					if (container is global::System.Windows.Controls.ContentControl)
					{
						num2 = (short)2088501248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)488112134;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_10E;
				case 4:
					return false;
				case 5:
				{
					num2 = (short)229109950;
					short num3 = num2;
					num2 = (short)807792830;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10E;
					default:
						num2 = (short)1773731840;
						if (num2 != 0)
						{
						}
						(container as global::System.Windows.Forms.Integration.ElementHost).Child = (radioManagementBootstrapper.Shell as global::System.Windows.UIElement);
						num2 = (short)990838791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (container is global::System.Windows.Forms.Integration.ElementHost)
					{
						num2 = (short)798818313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B0;
				case 7:
					num2 = (short)543227905;
					if (num2 != 0)
					{
					}
					goto IL_B0;
				case 8:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
					{
						num2 = (short)893911044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					num2 = (short)1001848835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_B0:
				global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor.CreateInstance();
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup = true;
				num2 = (short)516554760;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10E:
				if ((container as global::System.Windows.Forms.Integration.ElementHost).Child != null)
				{
					goto IL_B0;
				}
				num2 = (short)892862469;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_38:
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup = false;
			radioManagementBootstrapper = new global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper(rmServerFeature);
			radioManagementBootstrapper.Run();
			num2 = (short)595001344;
			short num4 = num2;
			num2 = (short)551485442;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002768 File Offset: 0x00000968
		public static bool Connect()
		{
			short num = (short)1457564255;
			short num2 = num;
			num = (short)2043652703;
			switch (num2 == num)
			{
			}
			num = (short)1439367169;
			if (num != 0)
			{
			}
			num = (short)682426368;
			if (num != 0)
			{
			}
			num = (short)1755774976;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.Connect(false);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002824 File Offset: 0x00000A24
		public static void Disconnect()
		{
			short num = (short)135350158;
			short num2 = num;
			num = (short)366102414;
			switch (num2 == num)
			{
			}
			num = (short)1051721728;
			if (num != 0)
			{
			}
			num = (short)1740570625;
			if (num != 0)
			{
			}
			num = (short)2004549632;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.Disconnect();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000028DC File Offset: 0x00000ADC
		protected override void ConfigureAggregateCatalog()
		{
			short num = (short)1109365716;
			short num2 = num;
			num = (short)38310868;
			switch (num2 == num)
			{
			}
			num = (short)1010434049;
			if (num != 0)
			{
			}
			num = (short)1994129408;
			if (num != 0)
			{
			}
			num = (short)1782185984;
			short num3 = num;
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Template.ModuleTemplate).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.ModuleApplicationLicense).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Firmware.ModuleFirmware).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.LanguagePack.ModuleLanguagePack).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.RadioLicense.ModuleRadioLicense).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Radio.ModuleRadio).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.VoiceAnnouncement.ModuleVoiceAnnouncement).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.CACertificates.ModuleCACertificates).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.DVRSFiles.ModuleDVRSFiles).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RadioManagementInfrastructure).Assembly));
			base.AggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(global::Motorola.CommonCPS.RadioManagement.CommonCore.CommonCore).Assembly));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BE8 File Offset: 0x00000DE8
		protected override global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
		{
			int a_ = 18;
			short num = (short)1385584071;
			short num2 = num;
			num = (short)1566070215;
			switch (num2 == num)
			{
			}
			num = (short)239140864;
			if (num != 0)
			{
			}
			num = (short)71761921;
			if (num != 0)
			{
			}
			num = (short)1829175296;
			short num3 = num;
			global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory = base.ConfigureDefaultRegionBehaviors();
			regionBehaviorFactory.AddIfMissing(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("튦\udda8쒪ﶬ삮솰욲\ud9b4횶춸\udeba잾뇀곂럄돆곈꿊鯌ꛎ듐ꓒꛔ闖볘돚볜꧞裠賢韤", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.AutoPopulateExportedViewsBehavior));
			return regionBehaviorFactory;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002CBC File Offset: 0x00000EBC
		protected override global::System.Windows.DependencyObject CreateShell()
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper.b())
					{
						num2 = (short)390332428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A2;
				case 1:
					num2 = (short)602341378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo != null)
					{
						num2 = (short)1709703175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AB;
				case 3:
					goto IL_2EC;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
					{
						num2 = (short)1946943503;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_383;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason == global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBUpgrade)
					{
						num2 = (short)788987907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A2;
				case 6:
					goto IL_2AB;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext dbmigrationContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo.ToEntityMode());
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, true);
					instance.ConnectionClosedFaulted = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted)global::System.Delegate.Combine(instance.ConnectionClosedFaulted, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted(dbmigrationContext.OnServerConnectionFaulted));
					flag = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowDBMigrationDialog(dbmigrationContext);
					num2 = (short)2029191174;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBMigration)
					{
						num2 = (short)881721353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EC;
				case 9:
					goto IL_DC;
				case 10:
					goto IL_A2;
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
					{
						num2 = (short)471859201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)826146824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowTemplateRadiosDetectedDialog();
					num2 = (short)1829240832;
					short num3 = num2;
					num2 = (short)798359562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					if (flag)
					{
						num2 = (short)2098200593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)796000260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					num2 = (short)955844993;
					short num4 = num2;
					num2 = (short)1225984385;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
						goto IL_254;
					}
					break;
				}
				case 15:
					global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementBootstrapper.Disconnect();
					num2 = (short)1780219918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_A2;
				case 17:
					goto IL_D7;
				}
				goto IL_58;
				IL_A2:
				num2 = (short)1907163149;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_DC:
				num2 = (short)1114898437;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2AB:
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeVersionInfo dbupgradeVersionInfo = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBUpgradeVersionInfo;
				num2 = (short)356384768;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2EC:
				flag = false;
				num2 = (short)785448961;
				if (num2 != 0)
				{
				}
				num2 = (short)941424656;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D7:
			base.Container.GetExportedValue<global::Motorola.CommonCPS.RadioManagement.CommonCore.CustomInteractionsService>();
			global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControl exportedValue;
			return exportedValue;
			IL_254:
			num2 = (short)761004032;
			if (num2 != 0)
			{
			}
			IL_383:
			return null;
			IL_58:
			exportedValue = base.Container.GetExportedValue<global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControl>();
			flag = true;
			num2 = (short)2100625419;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003050 File Offset: 0x00001250
		private static bool b()
		{
			short num = (short)434867137;
			short num2 = num;
			num = (short)1594395585;
			switch (num2 == num)
			{
			}
			num = (short)1844969473;
			if (num != 0)
			{
			}
			num = (short)2031943680;
			if (num != 0)
			{
			}
			num = (short)871235584;
			short num3 = num;
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000030F8 File Offset: 0x000012F8
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PACType a()
		{
			short num = (short)985009544;
			short num2 = num;
			num = (short)290393480;
			switch (num2 == num)
			{
			}
			num = (short)931397633;
			if (num != 0)
			{
			}
			num = (short)828178432;
			if (num != 0)
			{
			}
			num = (short)205979648;
			short num3 = num;
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO;
		}
	}
}
